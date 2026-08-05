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
using RecRoom.DataLayer.Attributes;
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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D342C0", Offset = "0x6D332C0", VA = "0x186D342C0", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D35D90", Offset = "0x6D34D90", VA = "0x186D35D90", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6D354D0", Offset = "0x6D344D0", VA = "0x186D354D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D353F0", Offset = "0x6D343F0", VA = "0x186D353F0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D35490", Offset = "0x6D34490", VA = "0x186D35490")]
		public RecNetCDNAssetReference(RecNetCDNKey MLAECOMLIEC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D35510", Offset = "0x6D34510", VA = "0x186D35510")]
		public static RecNetCDNKey CBEBDCKGMIA(string FCLJAKHLDFI, string BHLOIFKLAOG = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6524AB0", Offset = "0x6523AB0", VA = "0x186524AB0")]
		public void MNOLBALFPKC(string IOLAPKJIMJN, string DFDCMIDOIMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D35610", Offset = "0x6D34610", VA = "0x186D35610")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGJOKJDJLNC]
public class PCNDHIOAALL : PGBMKDBLHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> GMBOEDAGLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> DBBPCGOBJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> MGEMJBPMAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> NAAGJNPMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> OKFFIBPLJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> LIGNCKENGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> EDJNEPJACFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator IOBJFDLIGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected CMCDHOKBBFF IHBHFPKICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte KCGBBFCMIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> BFPBMGDEIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> NGAAFMPMCJE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D34830", Offset = "0x6D33830", VA = "0x186D34830", Slot = "4")]
	public void EMNFJLCHEAG(Mesh BKGAJHNMIBN, Matrix4x4 BPKHDBLOPAL, byte[] PLJGGOAPADK, bool KOJPPKOBMFL = false, ODJFHHHGCLI.EDMGMMBMGFC BOOJGIFPGNN = (ODJFHHHGCLI.EDMGMMBMGFC)0, int JKOBJOLEPPD = -1, bool HEEGOJPJIHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D34590", Offset = "0x6D33590", VA = "0x186D34590", Slot = "5")]
	public void BBFMHFPPBII(Allocator HHJAFJNPHLL, CMCDHOKBBFF GJDNEKDNECO, byte DPCJMGAADAK, [Optional] IList<int> OGNCKAMEIAA, [Optional] IList<int> JBOKJLPHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D345D0", Offset = "0x6D335D0", VA = "0x186D345D0")]
	private static void DCBGBDKEDGL(Mesh BKGAJHNMIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D34A40", Offset = "0x6D33A40", VA = "0x186D34A40")]
	public PCNDHIOAALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PGJOKJDJLNC]
public struct DHDKFJMBFBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public DFNEHGMJAIC EDBEGBGHLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int KLJHLGJJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public BGNFILBMCBE GMGELKAICGE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E940", Offset = "0x6D2D940", VA = "0x186D2E940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[PGJOKJDJLNC]
public struct BGNFILBMCBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct JNILOENONNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 DLFBDFKJCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 LCMGGHKGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 JMKLKMFGJMB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct GODFOEEFBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float ICJLJCGBKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float BNEIKLCBMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float OKDMFJPEGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float JDNADLJAOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte HGNNFMNJOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte EAMGIGAOPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte LMFILGPCLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte JPABAJKBELC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct PCDHCKJNFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half ICJLJCGBKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half BNEIKLCBMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half OKDMFJPEGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half JDNADLJAOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte HGNNFMNJOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte EAMGIGAOPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte LMFILGPCLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte JPABAJKBELC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JILLNFADMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 BCAEDANNHCE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KPECINGNBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 BMIGPIJEIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BGIKELHEFHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 BMIGPIJEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 ANBHPDDAMEM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AGDMHFMNFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 BMIGPIJEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 ANBHPDDAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 OOFOHNHEFFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct AFKJOKGFHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float ICJLJCGBKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float BNEIKLCBMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float OKDMFJPEGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float JDNADLJAOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int HGNNFMNJOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int EAMGIGAOPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int LMFILGPCLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int JPABAJKBELC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BCJPMFMGCJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 BCAEDANNHCE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ECALDDOGGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 BMIGPIJEIGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct FAGCNLEOABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 BMIGPIJEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 ANBHPDDAMEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct AMNBPGHNGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color DANHKIEIFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 BCAEDANNHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 BMIGPIJEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 ANBHPDDAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 OOFOHNHEFFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool BNHHDAICFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<JNILOENONNG> KNHBPCKLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JILLNFADMLH> KKNGGGAPAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<KPECINGNBLM> JEMGEKOKNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<BGIKELHEFHH> IMNEIPKENIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<AGDMHFMNFJD> PECKBMBCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<PCDHCKJNFCI> AMBEKNNPNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<GODFOEEFBLM> DMPDJEEABDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BCJPMFMGCJO> LIALEFIKELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ECALDDOGGCC> JOANKJONEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FAGCNLEOABJ> ECCDDBONACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<AMNBPGHNGJK> KBKBNLMINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<AFKJOKGFHGI> EGEKODEGMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> BPBOPPCBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> NNEEOGBFNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> HKIDEKDDJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> BMFIKENDCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> BAJDFBGJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PEPGMFKFEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> NKJPAKDKMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> LJLHFICKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> IEEFMIOJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool PGJHPMBGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool HKCEEGEEAEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MJPEPFGJJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D1FF60", Offset = "0x6D1EF60", VA = "0x186D1FF60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E150", Offset = "0x6D1D150", VA = "0x186D1E150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JCFONNOCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E3E0", Offset = "0x6D1D3E0", VA = "0x186D1E3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E3D0", Offset = "0x6D1D3D0", VA = "0x186D1E3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OIAEFMEKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E3C0", Offset = "0x6D1D3C0", VA = "0x186D1E3C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E790", Offset = "0x6D1D790", VA = "0x186D1E790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NBBAPJLMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1E720", Offset = "0x6D1D720", VA = "0x186D1E720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FF70", Offset = "0x6D1EF70", VA = "0x186D1FF70")]
	public BGNFILBMCBE(int LDONODAEBKA, int IDPKPFJHCJN, int HNPNFMJIFBA, int DKBGEAPALAO, Allocator HHJAFJNPHLL, int HNPOAJPNNLB, HCBIEALPJBG LLMEODMFOFJ, bool PGJHPMBGHHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FAA0", Offset = "0x6D1EAA0", VA = "0x186D1FAA0")]
	public void NEPHMLDNLHL(int KHAIDMGPIED, Vector3 DEGBNBIJGGI, Vector3 INDEACBIFHB, Vector4 JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FB30", Offset = "0x6D1EB30", VA = "0x186D1FB30")]
	public void PBDJNLKOOGN(int KHAIDMGPIED, BoneWeight HDJMOMGOLJH, NativeSlice<byte> PLJGGOAPADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E3F0", Offset = "0x6D1D3F0", VA = "0x186D1E3F0")]
	public Color HPNJAIFIDDL(int KHAIDMGPIED)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DC70", Offset = "0x6D1CC70", VA = "0x186D1DC70")]
	public void BPKJBLEDMHI(int KHAIDMGPIED, Color JGODMBGCENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F6F0", Offset = "0x6D1E6F0", VA = "0x186D1F6F0")]
	public void NBFAODDMANH(byte DEJHEKCAJJB, int KHAIDMGPIED, Vector2 JCCEDMINBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E140", Offset = "0x6D1D140", VA = "0x186D1E140")]
	public void DFGLHLAOICF(int KHAIDMGPIED, int BEJHOPLFNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DC10", Offset = "0x6D1CC10", VA = "0x186D1DC10")]
	public bool AKHEHBCEOIB(int DEJHEKCAJJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E070", Offset = "0x6D1D070", VA = "0x186D1E070")]
	public void CPHDHCLFNBC(int EKBFPIEHLBP, int OFDADLBABBI, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E160", Offset = "0x6D1D160", VA = "0x186D1E160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E7A0", Offset = "0x6D1D7A0", VA = "0x186D1E7A0")]
	public Mesh MOJCNCKCLDE([Optional] string ECFINAPFLNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[PGJOKJDJLNC]
[DefaultMember("Item")]
public struct DFNEHGMJAIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray GFMDBGHJNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> BCCPKOLHPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> DEPHPEEEOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> LJLHFICKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> HLPHOOEHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> POBEGHGAMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> KGPICBMGFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AGIIHAGPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> LPANLJDBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> ECIBGJADACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> CMGLKFJCJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> HEEGOJPJIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> JKOBJOLEPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool PGJHPMBGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> CBKBPPKOMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool HKCEEGEEAEP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int MDHMGOLCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D400", Offset = "0x6D2C400", VA = "0x186D2D400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PBLOPCLIMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D2F0", Offset = "0x6D2C2F0", VA = "0x186D2D2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JCBODPGAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D300", Offset = "0x6D2C300", VA = "0x186D2D300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JOEHAJIBEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D3E0", Offset = "0x6D2C3E0", VA = "0x186D2D3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D4E0", Offset = "0x6D2C4E0", VA = "0x186D2D4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MJPEPFGJJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D760", Offset = "0x6D2C760", VA = "0x186D2D760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D160", Offset = "0x6D2C160", VA = "0x186D2D160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CJOFOPIMDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D150", Offset = "0x6D2C150", VA = "0x186D2D150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D3F0", Offset = "0x6D2C3F0", VA = "0x186D2D3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CMCDHOKBBFF MIPJGGADJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D750", Offset = "0x6D2C750", VA = "0x186D2D750")]
		get
		{
			return default(CMCDHOKBBFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D170", Offset = "0x6D2C170", VA = "0x186D2D170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte IOFPANDPCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D3D0", Offset = "0x6D2C3D0", VA = "0x186D2D3D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D740", Offset = "0x6D2C740", VA = "0x186D2D740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public GBMALLMHINO JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D4F0", Offset = "0x6D2C4F0", VA = "0x186D2D4F0")]
		get
		{
			return default(GBMALLMHINO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D770", Offset = "0x6D2C770", VA = "0x186D2D770")]
	public DFNEHGMJAIC(IList<Mesh> KBHHGEKLMEE, IList<Matrix4x4> KIONJODIDNB, IList<bool> HEEGOJPJIHF, byte DPCJMGAADAK, IList<byte[]> OCGPNFPKGEB, IList<int> KDMGPKFEMHK, IList<bool> BCPJDEMPLEC, IList<int> JKOBJOLEPPD, IList<int> OGNCKAMEIAA, IList<int> NPNOLGBFIFA, Allocator HHJAFJNPHLL, CMCDHOKBBFF GJDNEKDNECO, bool PGJHPMBGHHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D410", Offset = "0x6D2C410", VA = "0x186D2D410")]
	public BGNFILBMCBE MKJMDMCMHHJ(Allocator HHJAFJNPHLL, HCBIEALPJBG LLMEODMFOFJ)
	{
		return default(BGNFILBMCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D180", Offset = "0x6D2C180", VA = "0x186D2D180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PGJOKJDJLNC]
public class IOMEJDHBGNF : PCNDHIOAALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool JJFHEBNFNEN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker GEJEMOGNEDP;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D304A0", Offset = "0x6D2F4A0", VA = "0x186D304A0")]
	public DFNEHGMJAIC AKCFOCKFEKE()
	{
		return default(DFNEHGMJAIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D307A0", Offset = "0x6D2F7A0", VA = "0x186D307A0")]
	public IOMEJDHBGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GBMALLMHINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData AAJJHDOFOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> LJLHFICKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> PBMDCGONBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BINDKEMLOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 AHMGCGOELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int JMICFJMFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> PLJGGOAPADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool EKNOIKLGOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int FEINIMBMLCD;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BIOMPCEPIBK : GFMDJEEHKJD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class FOHCGLOJJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly PPEPNMKDOKP MJJOILELEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool FBMBOKBHOGC;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool ALCGHEFEJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool GKPAAAAKEGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual ODJFHHHGCLI.EDMGMMBMGFC JMICFJMFLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
			get
			{
				return default(ODJFHHHGCLI.EDMGMMBMGFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool CLKJOCMILNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCF5360", Offset = "0xCF4360", VA = "0x180CF5360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool OJJBOPCEJNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1A81D90", Offset = "0x1A80D90", VA = "0x181A81D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool LMICGNBHACG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6D30440", Offset = "0x6D2F440", VA = "0x186D30440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool CFPHJKEHGIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6D30420", Offset = "0x6D2F420", VA = "0x186D30420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		protected FOHCGLOJJFP(PPEPNMKDOKP PLFINIJEBED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract KKJPAEAJCIM DJOGDODIKBJ(int[] OKKMLHLAHGG, List<MACEGDFFACH> BLJBCECPAIF, List<MACEGDFFACH> MKCPGAOIFDL);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract APCKLAJONLH GIHPFJKMKBM(uint ADNNLIGBFLK, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class PIHBCCDPEEO : FOHCGLOJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CHCEBENHNIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public DIHMDMOKEDJ<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public PIHBCCDPEEO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public CHCEBENHNIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D2CD60", Offset = "0x6D2BD60", VA = "0x186D2CD60")]
			internal void FPMPANMKMGG(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AvatarSkinAssetItem.JKEAHFIBIPL CMKJKCKIDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly AssetReference IJOMIMAGCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly ODJFHHHGCLI.EDMGMMBMGFC IGBNBAKKKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly CEHCJOLGKJG? BIIOCFDJIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Material[] BCHGAKNLFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private SkinnedMeshRenderer[] JBPKIHCEELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AvatarSkinAssetItem OHLMKCHIOJE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override ODJFHHHGCLI.EDMGMMBMGFC JMICFJMFLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660", Slot = "6")]
			get
			{
				return default(ODJFHHHGCLI.EDMGMMBMGFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D35180", Offset = "0x6D34180", VA = "0x186D35180")]
		public PIHBCCDPEEO(AvatarSkinAssetItem.JKEAHFIBIPL MBINAIDKCFH, AssetReference LILLOGLJLHI, Material FBLOOOOPAMI, PPEPNMKDOKP ABOBDACKLMM, ODJFHHHGCLI.EDMGMMBMGFC MFADHEJFDPL = (ODJFHHHGCLI.EDMGMMBMGFC)0, [Optional] CEHCJOLGKJG? JGAAHDFODLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D35290", Offset = "0x6D34290", VA = "0x186D35290")]
		public PIHBCCDPEEO(AvatarSkinAssetItem.JKEAHFIBIPL MBINAIDKCFH, AssetReference LILLOGLJLHI, Material FBLOOOOPAMI, ODJFHHHGCLI.EDMGMMBMGFC MFADHEJFDPL = (ODJFHHHGCLI.EDMGMMBMGFC)0, [Optional] CEHCJOLGKJG? JGAAHDFODLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D34C70", Offset = "0x6D33C70", VA = "0x186D34C70", Slot = "7")]
		public override KKJPAEAJCIM DJOGDODIKBJ(int[] OKKMLHLAHGG, List<MACEGDFFACH> BLJBCECPAIF, List<MACEGDFFACH> MKCPGAOIFDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D34E40", Offset = "0x6D33E40", VA = "0x186D34E40", Slot = "8")]
		public override APCKLAJONLH GIHPFJKMKBM(uint ADNNLIGBFLK, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D35110", Offset = "0x6D34110", VA = "0x186D35110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KLFPFEEDLBK : FOHCGLOJJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly EDKLCJCDDMF NGKAHCEKDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private DIHMDMOKEDJ<BNMAGILCGLN> MKDBHHDAOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public BNMAGILCGLN LAFLHOHBJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private DIHMDMOKEDJ<Material[]> ENLPOLNJBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material[] IELDOLJEJCA;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool ALCGHEFEJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool GKPAAAAKEGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D310E0", Offset = "0x6D300E0", VA = "0x186D310E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D31A10", Offset = "0x6D30A10", VA = "0x186D31A10")]
		public KLFPFEEDLBK(PPEPNMKDOKP PLFINIJEBED, EDKLCJCDDMF CPIODEGGCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D31140", Offset = "0x6D30140", VA = "0x186D31140", Slot = "7")]
		public override KKJPAEAJCIM DJOGDODIKBJ(int[] OKKMLHLAHGG, List<MACEGDFFACH> BLJBCECPAIF, List<MACEGDFFACH> MKCPGAOIFDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D315C0", Offset = "0x6D305C0", VA = "0x186D315C0", Slot = "8")]
		public override APCKLAJONLH GIHPFJKMKBM(uint ADNNLIGBFLK, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D317B0", Offset = "0x6D307B0", VA = "0x186D317B0")]
		public APCKLAJONLH NPJBCKKPGOF(GameObject HKFENGNLOPK, uint ADNNLIGBFLK, bool ICGAIOAGALF, bool IOHHOHENMFI, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D30D80", Offset = "0x6D2FD80", VA = "0x186D30D80")]
		public static bool AFAAJNMCLKH(Renderer[] BFKHCABMNMD, string HILCHGCKAEO, [Out] Renderer PFGOMFCDABN, [Out] Renderer GLAENKCLFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D319C0", Offset = "0x6D309C0", VA = "0x186D319C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D316F0", Offset = "0x6D306F0", VA = "0x186D316F0")]
		private (DIHMDMOKEDJ<BNMAGILCGLN>, DIHMDMOKEDJ<Material[]>) NMJAMFOBLOF()
		{
			return default((DIHMDMOKEDJ<BNMAGILCGLN>, DIHMDMOKEDJ<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47697B0", Offset = "0x47687B0", VA = "0x1847697B0")]
		[CompilerGenerated]
		private void KEKPFDKLGOE(BNMAGILCGLN POCKBMKNJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E20", Offset = "0x8B8E20", VA = "0x1808B9E20")]
		[CompilerGenerated]
		private void EOEALEHAIIN(Material[] POCKBMKNJHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LFFNKONMCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CFFPJCLEIFJ avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BIOMPCEPIBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public EDMIDDLGGJL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LFFNKONMCMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D33E00", Offset = "0x6D32E00", VA = "0x186D33E00")]
		internal bool NMJOAIBIKDO(EDKLCJCDDMF item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D33D30", Offset = "0x6D32D30", VA = "0x186D33D30")]
		internal void EPFDIMEDCFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D33D50", Offset = "0x6D32D50", VA = "0x186D33D50")]
		internal void MLLNFKJCJEF(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D33D70", Offset = "0x6D32D70", VA = "0x186D33D70")]
		internal void NINMMGLBPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D33CA0", Offset = "0x6D32CA0", VA = "0x186D33CA0")]
		internal void BFLMFFCDJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		internal KKJPAEAJCIM GNHEEHCFOPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JBBFLBFCFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public LFFNKONMCMH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JBBFLBFCFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D30A00", Offset = "0x6D2FA00", VA = "0x186D30A00")]
		internal CMAHAPJCLAL MJNPAGEAJEK(int lod)
		{
			return default(CMAHAPJCLAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AHGOOJPBKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<EDMIDDLGGJL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AHGOOJPBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D1DAE0", Offset = "0x6D1CAE0", VA = "0x186D1DAE0")]
		internal void CCDCIMEAEGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IPECNMCFCGJ : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public BIOMPCEPIBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<FOHCGLOJJFP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<EDMIDDLGGJL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Func<int, CMAHAPJCLAL> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public EPOGNIAMNNB materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public IPECNMCFCGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D307B0", Offset = "0x6D2F7B0", VA = "0x186D307B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D309B0", Offset = "0x6D2F9B0", VA = "0x186D309B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class POPCHEPFEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BIOMPCEPIBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public POPCHEPFEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D353A0", Offset = "0x6D343A0", VA = "0x186D353A0")]
		internal KKJPAEAJCIM IMJGONCHLFB(FOHCGLOJJFP p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ACJDGBALGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public LALJJBCFLND cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ACJDGBALGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x958170", Offset = "0x957170", VA = "0x180958170")]
		internal void LAHHOJJNBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9581C0", Offset = "0x9571C0", VA = "0x1809581C0")]
		internal void KOBCIDKICAI(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FKMCFJAAFNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public BIOMPCEPIBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FKMCFJAAFNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KKDBNAJLLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public BGNFILBMCBE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public DFNEHGMJAIC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FKMCFJAAFNI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KKDBNAJLLLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D30B40", Offset = "0x6D2FB40", VA = "0x186D30B40")]
		internal void BECHDNFGELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xE13110", Offset = "0xE12110", VA = "0x180E13110")]
		internal void GFDBPMOFLPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OGAICLMAHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public DBDGONCFCBL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EJEEEMOGFIJ legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public FKMCFJAAFNI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OGAICLMAHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D34350", Offset = "0x6D33350", VA = "0x186D34350")]
		internal void ILKOOEAHFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xE11770", Offset = "0xE10770", VA = "0x180E11770")]
		internal void MCHDCPINADM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class LGNBHCMHBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KeyValuePair<string, EDKLCJCDDMF> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public LALJJBCFLND cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public EDKLCJCDDMF avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BIOMPCEPIBK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LGNBHCMHBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D33E90", Offset = "0x6D32E90", VA = "0x186D33E90")]
		internal KKJPAEAJCIM EKLGIJBDAMM(LLHAHCOPPAC item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D33E50", Offset = "0x6D32E50", VA = "0x186D33E50")]
		internal void CPCCGKMFCFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GHNINNPAFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public DIHMDMOKEDJ<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GHNINNPAFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D30450", Offset = "0x6D2F450", VA = "0x186D30450")]
		internal void BENNFOMINKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KENBDHNDAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public PPEPNMKDOKP overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KENBDHNDAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D30AC0", Offset = "0x6D2FAC0", VA = "0x186D30AC0")]
		internal bool PPABJKFGOFJ(KeyValuePair<string, EDKLCJCDDMF> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration GDHDFGHGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform ODBKFPGLJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference IJOMIMAGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject MGDEMGDEACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject JOOCBHDCIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer KEPNKBMELNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData LDPJHNCFMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] OJLMAPDNNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] JNAJADBKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material PMDDHDABEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material INKHJBNJAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material KIKALNEDOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader LHFBMLNHLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader LBBJMNNAJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator BHOCEFHOMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] MAIDMGBCPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private ODJFHHHGCLI.EDMGMMBMGFC BJGBFFJPBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager DDDNJHMFJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> MKBENDFNABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.OHAFBHMHFEO KCEABAIMPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.KDEODFCMBGN HGFNDICEIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool LBOJDNFIJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool IFMJANFGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color DOJCFNLFJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color IGCKEPAPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color LANPNAPLEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? LLGFHGFDKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? LFFHEIMJADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? DJLLIMNFPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? FJPDFPGBCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D FAABEMNBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D PECHMKDIDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private EDKLCJCDDMF NLPMJALEDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture BJAAEMFNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color GILKGAPJPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, EPOGNIAMNNB> GOJOCNIAOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, EPOGNIAMNNB> OHNIPEDBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<ENKNAPKELMB>> ILHNIBMBGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<ENKNAPKELMB>> JAFHNMDKBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<MACEGDFFACH> BJEAAEBDCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<MACEGDFFACH> FKDOLBLABJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<MACEGDFFACH> FBNMONEECGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<MACEGDFFACH> KJNBEGGJKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<ENKNAPKELMB, Material> HGBAMBBDGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<ENKNAPKELMB, Material> LFNEMLNMEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] JJICEHLGFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] GHELEEILMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] NDMENLBOCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] IBEECMGJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, DIHMDMOKEDJ<Texture2D>> LNOCLKKIMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, DIHMDMOKEDJ<Texture2D>> DDPDMHADOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData CPLMMOGKDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData CGLECLAAPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData DDABMMLKKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData GMCFGKGFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private DIHADCKDDGJ GBHCDEHGKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? BDGHCJHFNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation ANPLIIDAIGD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material ALDPMAMKPLI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material KIFOMIIAGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, EDKLCJCDDMF> LNAGMMLJPBF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int JAIDBPMILIC;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EKGKOLLNGAC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int AIMCPNLKEIC;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KGHLCJPJEOC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DLNPOBGIDEL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int KMPEKGAGDLN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int CODMICBOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly GDBINPMHEFP NOIKMKHEKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly GDBINPMHEFP KMIHDPFPLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool OLPOBODPDIG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<OJMFEDOPAFE> BDFGOMIFCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<KMDGCACGBPN> LHEDCKNAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<HHMILCOKIIM> MGBPGPJLHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JGHFHJBGHPA LLFMFNIOPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> DNIMIFPKHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JBNKJKEOLAH DAGPCNMBFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] NFPJCNNCCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int EKIJEGEHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool CGGKHJFCEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int HCNABPFJLIF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static bool KCCLPNOCPOK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GGKNKDKOFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD6D4C0", Offset = "0xD6C4C0", VA = "0x180D6D4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD6C350", Offset = "0xD6B350", VA = "0x180D6C350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material PNNIJLAGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D23F30", Offset = "0x6D22F30", VA = "0x186D23F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material ICFANDOMIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D284F0", Offset = "0x6D274F0", VA = "0x186D284F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool KNLMDNPBENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HEGHLNFMEGC MIHFGIHMNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "21")]
		get
		{
			return default(HEGHLNFMEGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static OJMFEDOPAFE JFKDGCHPBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D22E10", Offset = "0x6D21E10", VA = "0x186D22E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private KMDGCACGBPN OLKIBBAENOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D23450", Offset = "0x6D22450", VA = "0x186D23450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private HHMILCOKIIM JOBJCILEIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D27F90", Offset = "0x6D26F90", VA = "0x186D27F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private JGHFHJBGHPA MPNDOBNEOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D23CE0", Offset = "0x6D22CE0", VA = "0x186D23CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GDBINPMHEFP MBGCGGNNCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA17080", Offset = "0xA16080", VA = "0x180A17080", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GDBINPMHEFP JCGNIPFGAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA17050", Offset = "0xA16050", VA = "0x180A17050", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] DNPBLMCJJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1BFAC20", Offset = "0x1BF9C20", VA = "0x181BFAC20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] GDBCCMCEIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B72B0", VA = "0x1808B82B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GHOHMONCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D209A0", Offset = "0x6D1F9A0", VA = "0x186D209A0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation JLDPCBNKOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D24360", Offset = "0x6D23360", VA = "0x186D24360", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ODJFHHHGCLI.EDMGMMBMGFC OIPNCOJEHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8310", Offset = "0x8B7310", VA = "0x1808B8310", Slot = "18")]
		get
		{
			return default(ODJFHHHGCLI.EDMGMMBMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int ABJCKPJOKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1C931D0", Offset = "0x1C921D0", VA = "0x181C931D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B350", Offset = "0x6D2A350", VA = "0x186D2B350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool PELMDLKLCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D24770", Offset = "0x6D23770", VA = "0x186D24770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool EIFFDHFNGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D22920", Offset = "0x6D21920", VA = "0x186D22920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C5B0", Offset = "0x6D2B5B0", VA = "0x186D2C5B0")]
	public BIOMPCEPIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D22340", Offset = "0x6D21340", VA = "0x186D22340", Slot = "28")]
	public void CPDDJGLEDNE(IHJMHHJNOCP NAFEJPFELBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D23B80", Offset = "0x6D22B80", VA = "0x186D23B80", Slot = "29")]
	public void GKAIGLPCJMK(NIGJOAAEPMP MIKMGKIJGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B350", Offset = "0x6D2A350", VA = "0x186D2B350", Slot = "4")]
	public void OGFMAJAEFME(int ADNNLIGBFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D28160", Offset = "0x6D27160", VA = "0x186D28160", Slot = "9")]
	public void MBNMHMNFGPD(JEPPGHKNIDM NGPDHJFJGDI, Texture2D JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D246F0", Offset = "0x6D236F0", VA = "0x186D246F0", Slot = "10")]
	public void IAKLPBGIFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D28380", Offset = "0x6D27380", VA = "0x186D28380", Slot = "11")]
	public bool MCGPBAFOFNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D21880", Offset = "0x6D20880", VA = "0x186D21880", Slot = "8")]
	public void BLADOCPAFKK(FLAOKOLOPDK CHEKLCLJKCJ, Color? DANHKIEIFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D250A0", Offset = "0x6D240A0", VA = "0x186D250A0")]
	private void JFHKCMCAKFH(Action LKPKMABACPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D239B0", Offset = "0x6D229B0", VA = "0x186D239B0", Slot = "5")]
	public void FNPEBCNGKIH(EDKLCJCDDMF BOMHOJAJNDG, Texture GFIMOGMIFGM, Color MGBPKGNHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xD6C350", Offset = "0xD6B350", VA = "0x180D6C350", Slot = "6")]
	public void OPJBGOAPIOA(bool HDLONDIOONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1BBEC90", Offset = "0x1BBDC90", VA = "0x181BBEC90", Slot = "7")]
	public void EBEIEHCGBNG(JBNKJKEOLAH IEEFMIOJLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D28A00", Offset = "0x6D27A00", VA = "0x186D28A00", Slot = "14")]
	public EDMIDDLGGJL NAAGELDGPDF(CFFPJCLEIFJ MILICNPCCCF, bool LDDIOMJJMLL, int[] PCANGGNPAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A000", Offset = "0x6D29000", VA = "0x186D2A000", Slot = "15")]
	public void NCKFFNLBFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D25440", Offset = "0x6D24440", VA = "0x186D25440", Slot = "26")]
	public void KADFCHILFIB([Optional] DIHADCKDDGJ PEIDAJMALFG, [Optional] bool? NGEKJAHMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A5E0", Offset = "0x6D295E0", VA = "0x186D2A5E0")]
	private bool NELCMGBGNDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D20D00", Offset = "0x6D1FD00", VA = "0x186D20D00", Slot = "19")]
	public bool ALPPCFGDLNF(ODJFHHHGCLI.EDMGMMBMGFC OKEKAABAJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D242A0", Offset = "0x6D232A0", VA = "0x186D242A0")]
	private bool HLGMGMKLLGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D22E80", Offset = "0x6D21E80", VA = "0x186D22E80")]
	private EDMIDDLGGJL FACJFHFFBBE(bool LDDIOMJJMLL, List<FOHCGLOJJFP> COLFCEBPMMF, int[] PCANGGNPAFC, Func<int, CMAHAPJCLAL> CHMGKCFJGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D247F0", Offset = "0x6D237F0", VA = "0x186D247F0")]
	[IteratorStateMachine(typeof(IPECNMCFCGJ))]
	private IEnumerator<MIAEKAOKMEH> ICOJGKEFHLC(bool LDDIOMJJMLL, List<FOHCGLOJJFP> COLFCEBPMMF, int[] PCANGGNPAFC, Func<int, CMAHAPJCLAL> CHMGKCFJGJK, EPOGNIAMNNB AFBOHCPDOGC, Material KFJHJCKABEJ, List<EDMIDDLGGJL> LDGEILBLPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D21FF0", Offset = "0x6D20FF0", VA = "0x186D21FF0")]
	private EDMIDDLGGJL CBKPEOLCDFK(List<FOHCGLOJJFP> COLFCEBPMMF, int[] PCANGGNPAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D26270", Offset = "0x6D25270", VA = "0x186D26270")]
	private DDGDFMBPLHP LFFDIFMBOKG(List<FOHCGLOJJFP> COLFCEBPMMF, int ADNNLIGBFLK, bool LDDIOMJJMLL, CMAHAPJCLAL BKMADAFHHHB, bool FAANKLCHEOJ, EPOGNIAMNNB AFBOHCPDOGC, Material KFJHJCKABEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D22600", Offset = "0x6D21600", VA = "0x186D22600", Slot = "22")]
	public void DBFIKGOLFDF(AvatarFaceShape MGJPKIFNODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D23C00", Offset = "0x6D22C00", VA = "0x186D23C00", Slot = "23")]
	public void GMCOJMIBHDC(AvatarBodyShape CFCCMKBELNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D27E90", Offset = "0x6D26E90", VA = "0x186D27E90", Slot = "25")]
	public void LLIDEOLNCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D25FD0", Offset = "0x6D24FD0", VA = "0x186D25FD0", Slot = "24")]
	public void KGOCKKKECFP(bool KNKBBIBEIHB, bool DOPMAGPBGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BBE0", Offset = "0x6D2ABE0", VA = "0x186D2BBE0")]
	private void PBMLNGGIPAP(SkinnedMeshRenderer JIALEMMBILG, int ADNNLIGBFLK, Mesh BKGAJHNMIBN, List<Material> OGILNJDCCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24900", Offset = "0x6D23900", VA = "0x186D24900")]
	private static Material IGKAEBDGBNK(Dictionary<ENKNAPKELMB, Material> BHIIAKKFDEB, Material HGPFDMEGJMI, MNGJIPIOLKF DMKLLKMOOIF, FGLLDEOHPGM OCMGLDFKCOK, PPEPNMKDOKP ABOBDACKLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D26150", Offset = "0x6D25150", VA = "0x186D26150")]
	private static MNGJIPIOLKF LDFODIJKBEH(FOHCGLOJJFP DMNMNPBHEJD, int BLGMIMODHLP)
	{
		return default(MNGJIPIOLKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D285E0", Offset = "0x6D275E0", VA = "0x186D285E0")]
	private void MKCOFOECFCH(int OEDNNJBIBHD, Material BIDMCIBAHOL, FOHCGLOJJFP DMNMNPBHEJD, [Out] Texture2D GLMJGFGIMMF, [Out] Vector4 FOLAMEFHDJC, [Out] Texture2D KCCIBPFPLCD, [Out] Texture2D JNGCCCCECIN, [Out] Texture2D MNLLJLGIDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D234D0", Offset = "0x6D224D0", VA = "0x186D234D0")]
	private void FIAEBBHEJFJ(int OEDNNJBIBHD, Material BIDMCIBAHOL, FOHCGLOJJFP DMNMNPBHEJD, [Out] Color DNJBBPDJGKI, [Out] Color DLBBNMAKHKC, [Out] Color GMNBBPBIOBF, [Out] Color IHGDNLCEGKO, [Out] Color OMNMILOBKGF, [Out] Color HMGMJNBFGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AB40", Offset = "0x6D29B40", VA = "0x186D2AB40")]
	private bool OBGEMMLKJEL(Material BIDMCIBAHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BD20", Offset = "0x6D2AD20", VA = "0x186D2BD20")]
	private static Material PEHCADCEGOD(int OEDNNJBIBHD, KLFPFEEDLBK DMNMNPBHEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A200", Offset = "0x6D29200", VA = "0x186D2A200")]
	private static FGLLDEOHPGM NCNLGGOIKHA(FOHCGLOJJFP DMNMNPBHEJD, int BLGMIMODHLP)
	{
		return default(FGLLDEOHPGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A300", Offset = "0x6D29300", VA = "0x186D2A300")]
	private static void NEKBHCAHMPB(Dictionary<string, List<ENKNAPKELMB>> CDMHNBPIDAK, FOHCGLOJJFP MBAPCIHALLF, Material HGPFDMEGJMI, MNGJIPIOLKF CHEKLCLJKCJ, FGLLDEOHPGM NGPDHJFJGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D226F0", Offset = "0x6D216F0", VA = "0x186D226F0")]
	private static SkinnedMeshRenderer DPDMNPGANJG(Transform AOPGFHJDIDA, Transform EEHOEFDDEDB, SkinnedMeshRenderer[] BFKHCABMNMD, int ADNNLIGBFLK, CMAHAPJCLAL BKMADAFHHHB, bool LDDIOMJJMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D21E30", Offset = "0x6D20E30", VA = "0x186D21E30")]
	private void CAONMPGCHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BBD0", Offset = "0x6D2ABD0", VA = "0x186D2BBD0")]
	private void PAFPNNFPOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D23A20", Offset = "0x6D22A20", VA = "0x186D23A20")]
	private static void GHHBDOINAFM(Dictionary<ENKNAPKELMB, Material> BHIIAKKFDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D22BE0", Offset = "0x6D21BE0", VA = "0x186D22BE0")]
	private static void EJAFHAKLFJE(Dictionary<Renderer, EPOGNIAMNNB> HFIPKPMHDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BAB0", Offset = "0x6D2AAB0", VA = "0x186D2BAB0")]
	private void ONMFKIAFLMK(SkinnedMeshRenderer[] BFKHCABMNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D20D20", Offset = "0x6D1FD20", VA = "0x186D20D20")]
	private void AMJFLJMEPHE(SkinnedMeshRenderer NONNMBINJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D240C0", Offset = "0x6D230C0", VA = "0x186D240C0")]
	private void HKNLHKBLACP(List<MACEGDFFACH> LHPBLLPGAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D21C80", Offset = "0x6D20C80", VA = "0x186D21C80")]
	private void BOPFOLMGAFO(Dictionary<string, DIHMDMOKEDJ<Texture2D>> CDMHNBPIDAK, bool PPMNIDMIMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D25F80", Offset = "0x6D24F80", VA = "0x186D25F80")]
	private void KEJMDHHOOMK(Dictionary<string, List<ENKNAPKELMB>> CDMHNBPIDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D252E0", Offset = "0x6D242E0", VA = "0x186D252E0")]
	private void JOMNHBGHMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A7B0", Offset = "0x6D297B0", VA = "0x186D2A7B0")]
	private void NMFNMLDDIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D2ADA0", Offset = "0x6D29DA0", VA = "0x186D2ADA0")]
	private void OBOOBMELODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D24A60", Offset = "0x6D23A60", VA = "0x186D24A60")]
	private void INJGBIIJFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B790", Offset = "0x6D2A790", VA = "0x186D2B790")]
	private void ODJGOHBAODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D27FE0", Offset = "0x6D26FE0", VA = "0x186D27FE0")]
	private void LPHIIKMHDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D22AC0", Offset = "0x6D21AC0", VA = "0x186D22AC0")]
	private void ECMABHNEOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D27DF0", Offset = "0x6D26DF0", VA = "0x186D27DF0")]
	private void LGNJJGNLKMO(bool IEANPLPFJFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D22D40", Offset = "0x6D21D40", VA = "0x186D22D40")]
	private void ELKHLGHKMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BFB0", Offset = "0x6D2AFB0", VA = "0x186D2BFB0")]
	private void PJLJMJCJMBA(bool IEANPLPFJFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C050", Offset = "0x6D2B050", VA = "0x186D2C050")]
	private void PKOFCFFILAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D24B30", Offset = "0x6D23B30", VA = "0x186D24B30")]
	private void JEFBKPBIEEB(Material KFJHJCKABEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D25FE0", Offset = "0x6D24FE0", VA = "0x186D25FE0")]
	private void KLNAOJAMPMI(Material KFJHJCKABEJ, Color AMCIAOGBCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BD70", Offset = "0x6D2AD70", VA = "0x186D2BD70")]
	private void PGGBKDOFGDB(Material KFJHJCKABEJ, Color AMCIAOGBCJH, Color ALKNPHAJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B8D0", Offset = "0x6D2A8D0", VA = "0x186D2B8D0")]
	private void OJHCIDAABNG(Material KFJHJCKABEJ, Color DNJBBPDJGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A940", Offset = "0x6D29940", VA = "0x186D2A940")]
	private void OAOENBHEICC(Material KFJHJCKABEJ, Texture2D JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D20B10", Offset = "0x6D1FB10", VA = "0x186D20B10")]
	private void ALCHLONHOIK(Material KFJHJCKABEJ, Texture EIGALCAGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D25120", Offset = "0x6D24120", VA = "0x186D25120")]
	private void JGMIFPMOEKD(Action<EPOGNIAMNNB> DGHAMPDLBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D23DB0", Offset = "0x6D22DB0", VA = "0x186D23DB0")]
	private void HABCIPODCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D24390", Offset = "0x6D23390", VA = "0x186D24390")]
	private void HPIGDMDKFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D20E50", Offset = "0x6D1FE50", VA = "0x186D20E50")]
	private EDMIDDLGGJL BAAMACICECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D214B0", Offset = "0x6D204B0", VA = "0x186D214B0")]
	private void BKJJKHNLDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B400", Offset = "0x6D2A400", VA = "0x186D2B400")]
	public void ODHPEMEDDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D25EF0", Offset = "0x6D24EF0", VA = "0x186D25EF0")]
	[CompilerGenerated]
	private void KBOMICCMDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D226C0", Offset = "0x6D216C0", VA = "0x186D226C0")]
	[CompilerGenerated]
	private void DBFMEDGNCJL(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BA20", Offset = "0x6D2AA20", VA = "0x186D2BA20")]
	[CompilerGenerated]
	private void OKBKPKMIPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D23CC0", Offset = "0x6D22CC0", VA = "0x186D23CC0")]
	[CompilerGenerated]
	private void GMGLIGJJKGO(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D20DC0", Offset = "0x6D1FDC0", VA = "0x186D20DC0")]
	[CompilerGenerated]
	private void APBNJLLNMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D22B90", Offset = "0x6D21B90", VA = "0x186D22B90")]
	[CompilerGenerated]
	private void EGHKMOCFBJC(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D222B0", Offset = "0x6D212B0", VA = "0x186D222B0")]
	[CompilerGenerated]
	private void CKKBFJHPDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D234A0", Offset = "0x6D224A0", VA = "0x186D234A0")]
	[CompilerGenerated]
	private void FEGBAPCBPAD(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D20C70", Offset = "0x6D1FC70", VA = "0x186D20C70")]
	[CompilerGenerated]
	private void ALHIADAILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D21E00", Offset = "0x6D20E00", VA = "0x186D21E00")]
	[CompilerGenerated]
	private void BPKGOPFOIJJ(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A720", Offset = "0x6D29720", VA = "0x186D2A720")]
	[CompilerGenerated]
	private void NJFBINMCLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D28130", Offset = "0x6D27130", VA = "0x186D28130")]
	[CompilerGenerated]
	private void MAOGIJMIHGM(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D25010", Offset = "0x6D24010", VA = "0x186D25010")]
	[CompilerGenerated]
	private void JFAIFOLICEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D23D80", Offset = "0x6D22D80", VA = "0x186D23D80")]
	[CompilerGenerated]
	private void GPBEEFPMGNF(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B820", Offset = "0x6D2A820", VA = "0x186D2B820")]
	[CompilerGenerated]
	private void OFPIOPLGICJ(KeyValuePair<string, DIHMDMOKEDJ<Texture2D>> BNPAILGIBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B370", Offset = "0x6D2A370", VA = "0x186D2B370")]
	[CompilerGenerated]
	private void OCMHGJINNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B8A0", Offset = "0x6D2A8A0", VA = "0x186D2B8A0")]
	[CompilerGenerated]
	private void OHLACBEFALG(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D21420", Offset = "0x6D20420", VA = "0x186D21420")]
	[CompilerGenerated]
	private void BFDCJPPBFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D22BB0", Offset = "0x6D21BB0", VA = "0x186D22BB0")]
	[CompilerGenerated]
	private void EHGFNOFOAME(EPOGNIAMNNB OJIKBBEDIGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KPFMBDIOCFK : HDPGNAMFPFM
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int EOAKKGAPEAO;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int PFCLECHEPBB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int FHBNGJJGAKB;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int BFLAIFKMOPH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int DGFAGKGFMMI;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int HLPIAMLKLOL;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int JBGGIANGDJH;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int FIAGPGCBFIN;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int ONMAPJCPGFG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int OFIEEGMDMJN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int PCBNCDKLJPK;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int MPDMHGCADFP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int LMJCGOCBINC;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int DJBCHKDNGKD;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BDHANCPBMAP;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int IHPGFOLNHOC;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int GKJOCDNICKF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int KOGNOKLIDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform CBLLMECDHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform OAJCBDCEHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform KBBDDPABHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform OCBBCOBLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform FGFHLOAJGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform IGIIBEDFLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform NHJAEGGDEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private KJHOPANKMFM IPMGGDKMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock GLEPHLPFPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private SkinnedMeshRenderer[] COFKLOABODK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock MNCLAJKJLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D31A70", Offset = "0x6D30A70", VA = "0x186D31A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GIKNMPKMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D31D70", Offset = "0x6D30D70", VA = "0x186D31D70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D31B30", Offset = "0x6D30B30", VA = "0x186D31B30", Slot = "7")]
	public void CPDDJGLEDNE(KJHOPANKMFM GKBGGLNDHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D31C00", Offset = "0x6D30C00", VA = "0x186D31C00", Slot = "8")]
	public void EGMMOKIALAN(BMOBDGFPEEH MLBAPODAFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D33440", Offset = "0x6D32440", VA = "0x186D33440", Slot = "5")]
	public void ONHHICEMNHF(CLPNELMHOBN OJGGFHJAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D31D10", Offset = "0x6D30D10", VA = "0x186D31D10")]
	private Vector2 KBLLJDGKAGO(Vector2 HKBIEFMPCNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D322C0", Offset = "0x6D312C0", VA = "0x186D322C0", Slot = "6")]
	public void MGKLGBDAAKG(IIJEKAACEBL MLBAPODAFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D31F80", Offset = "0x6D30F80", VA = "0x186D31F80")]
	private void LPBOLKNNIBP(IIJEKAACEBL GLKGLJGKFIO, LDKDNFOJIAF MAABPOIOFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D31C30", Offset = "0x6D30C30", VA = "0x186D31C30")]
	private void GIJAMCALJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D33C40", Offset = "0x6D32C40", VA = "0x186D33C40")]
	public KPFMBDIOCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D31EF0", Offset = "0x6D30EF0", VA = "0x186D31EF0")]
	[CompilerGenerated]
	internal static (float, float) KPMJHIDJCLB(float KJKBLBKDMEB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D31AF0", Offset = "0x6D30AF0", VA = "0x186D31AF0")]
	[CompilerGenerated]
	internal static Vector4 CNFHNKCNJIO(Vector2 PAMMLHPIJIB, Vector2 KBGFEDJHNAE)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private FKLOMFJFNCB? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public BEFENALLNEP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6D364A0", Offset = "0x6D354A0", VA = "0x186D364A0")]
			get
			{
				return default(BEFENALLNEP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FKLOMFJFNCB MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6D364D0", Offset = "0x6D354D0", VA = "0x186D364D0")]
			get
			{
				return default(FKLOMFJFNCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8B4280", Offset = "0x8B3280", VA = "0x1808B4280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D36300", Offset = "0x6D35300", VA = "0x186D36300")]
		public Material[] PLFMIHMDCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D36110", Offset = "0x6D35110", VA = "0x186D36110")]
		public static void MEDMODEFEGN(AvatarItemMaterial BOLILDGDEDI, Material BIDMCIBAHOL, int OEDNNJBIBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D35F60", Offset = "0x6D34F60", VA = "0x186D35F60")]
		private static bool JAIIAAMLDBO(AvatarItemMaterial BOLILDGDEDI, int OEDNNJBIBHD, [Out] Material BANKJBBNBAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D363E0", Offset = "0x6D353E0", VA = "0x186D363E0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[PGJOKJDJLNC]
public struct EMDBACJFIMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	public EJEEEMOGFIJ EDBEGBGHLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	public int KLJHLGJJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public DBDGONCFCBL GMGELKAICGE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D39D30", Offset = "0x6D38D30", VA = "0x186D39D30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[PGJOKJDJLNC]
public struct DBDGONCFCBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public NativeArray<Vector3> NAAPEKGGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NativeArray<Vector3> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<Vector4> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector2> JEFINEIINOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector2> ANBHPDDAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector2> OOFOHNHEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> ODKDHGOBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Color> KEGLFIONCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<int> BPBOPPCBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<int> NNEEOGBFNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> HKIDEKDDJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> BMFIKENDCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> BAJDFBGJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<int> PEPGMFKFEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<int> NKJPAKDKMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<BoneWeight> FDBEKPPCIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> IEEFMIOJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool HKCEEGEEAEP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MJPEPFGJJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D372F0", Offset = "0x6D362F0", VA = "0x186D372F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D369E0", Offset = "0x6D359E0", VA = "0x186D369E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JCFONNOCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D36BC0", Offset = "0x6D35BC0", VA = "0x186D36BC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D36BB0", Offset = "0x6D35BB0", VA = "0x186D36BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int OIAEFMEKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D36BA0", Offset = "0x6D35BA0", VA = "0x186D36BA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D36BF0", Offset = "0x6D35BF0", VA = "0x186D36BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D37300", Offset = "0x6D36300", VA = "0x186D37300")]
	public DBDGONCFCBL(int LDONODAEBKA, int IDPKPFJHCJN, int HNPNFMJIFBA, int DKBGEAPALAO, Allocator HHJAFJNPHLL, int HNPOAJPNNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D36FA0", Offset = "0x6D35FA0", VA = "0x186D36FA0")]
	public void NEPHMLDNLHL(int KHAIDMGPIED, Vector3 DEGBNBIJGGI, Vector3 INDEACBIFHB, Vector4 JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D37010", Offset = "0x6D36010", VA = "0x186D37010")]
	public void PBDJNLKOOGN(int KHAIDMGPIED, BoneWeight HDJMOMGOLJH, NativeSlice<byte> PLJGGOAPADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D36BD0", Offset = "0x6D35BD0", VA = "0x186D36BD0")]
	public Color HPNJAIFIDDL(int KHAIDMGPIED)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D368E0", Offset = "0x6D358E0", VA = "0x186D368E0")]
	public void BPKJBLEDMHI(int KHAIDMGPIED, Color JGODMBGCENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D36F50", Offset = "0x6D35F50", VA = "0x186D36F50")]
	public void NBFAODDMANH(byte DEJHEKCAJJB, int KHAIDMGPIED, Vector2 JCCEDMINBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D369D0", Offset = "0x6D359D0", VA = "0x186D369D0")]
	public void DFGLHLAOICF(int KHAIDMGPIED, int BEJHOPLFNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D368B0", Offset = "0x6D358B0", VA = "0x186D368B0")]
	public bool AKHEHBCEOIB(int DEJHEKCAJJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D36900", Offset = "0x6D35900", VA = "0x186D36900")]
	public void CPHDHCLFNBC(int EKBFPIEHLBP, int OFDADLBABBI, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D37240", Offset = "0x6D36240", VA = "0x186D37240")]
	public int[] PMFEDFCEHCM(int EKBFPIEHLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D371B0", Offset = "0x6D361B0", VA = "0x186D371B0")]
	private NativeSlice<int> PJHOFBNIPHM(int EKBFPIEHLBP)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D369F0", Offset = "0x6D359F0", VA = "0x186D369F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D36C00", Offset = "0x6D35C00", VA = "0x186D36C00")]
	public Mesh MOJCNCKCLDE([Optional] string ECFINAPFLNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[PGJOKJDJLNC]
[NativeContainer]
public struct EJEEEMOGFIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<Vector3> NAAPEKGGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<Vector3> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<Vector4> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector2> JEFINEIINOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector2> ANBHPDDAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector2> OOFOHNHEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> ODKDHGOBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Color> KEGLFIONCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<int> KMLHLDBKBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<int> PDDHGELHJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<int> KDHMDAODFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> ILNMBCKHFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<bool> HEEGOJPJIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> JKOBJOLEPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> DEPHPEEEOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<BoneWeight> LJLHFICKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<Matrix4x4> HLPHOOEHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> POBEGHGAMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<byte> KGPICBMGFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<int> AGIIHAGPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> LPANLJDBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<sbyte> ECIBGJADACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<byte> CMGLKFJCJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> CBKBPPKOMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool HKCEEGEEAEP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int MDHMGOLCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x22F9A20", Offset = "0x22F8A20", VA = "0x1822F9A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int PBLOPCLIMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1404B50", Offset = "0x1403B50", VA = "0x181404B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JCBODPGAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6D37E40", Offset = "0x6D36E40", VA = "0x186D37E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JOEHAJIBEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6D37E80", Offset = "0x6D36E80", VA = "0x186D37E80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D37F70", Offset = "0x6D36F70", VA = "0x186D37F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int MJPEPFGJJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D384C0", Offset = "0x6D374C0", VA = "0x186D384C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6D37BC0", Offset = "0x6D36BC0", VA = "0x186D37BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CJOFOPIMDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D37BB0", Offset = "0x6D36BB0", VA = "0x186D37BB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D37E90", Offset = "0x6D36E90", VA = "0x186D37E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CMCDHOKBBFF MIPJGGADJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D384B0", Offset = "0x6D374B0", VA = "0x186D384B0")]
		get
		{
			return default(CMCDHOKBBFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D37BD0", Offset = "0x6D36BD0", VA = "0x186D37BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte IOFPANDPCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D37E70", Offset = "0x6D36E70", VA = "0x186D37E70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D384A0", Offset = "0x6D374A0", VA = "0x186D384A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CIMILLHJLLE JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6D37F80", Offset = "0x6D36F80", VA = "0x186D37F80")]
		get
		{
			return default(CIMILLHJLLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6D384D0", Offset = "0x6D374D0", VA = "0x186D384D0")]
	public EJEEEMOGFIJ(IList<Mesh> KBHHGEKLMEE, IList<Matrix4x4> KIONJODIDNB, IList<bool> HEEGOJPJIHF, byte DPCJMGAADAK, IList<byte[]> OCGPNFPKGEB, IList<int> KDMGPKFEMHK, IList<bool> BCPJDEMPLEC, IList<int> JKOBJOLEPPD, IList<int> OGNCKAMEIAA, IList<int> NPNOLGBFIFA, Allocator HHJAFJNPHLL, CMCDHOKBBFF GJDNEKDNECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6D37EA0", Offset = "0x6D36EA0", VA = "0x186D37EA0")]
	public DBDGONCFCBL MKJMDMCMHHJ(Allocator HHJAFJNPHLL)
	{
		return default(DBDGONCFCBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D37BE0", Offset = "0x6D36BE0", VA = "0x186D37BE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PGJOKJDJLNC]
public class BAAFHCIANIJ : PCNDHIOAALL
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D36590", Offset = "0x6D35590", VA = "0x186D36590")]
	public EJEEEMOGFIJ AKCFOCKFEKE()
	{
		return default(EJEEEMOGFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D307A0", Offset = "0x6D2F7A0", VA = "0x186D307A0")]
	public BAAFHCIANIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CIMILLHJLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public NativeSlice<Vector3> NAAPEKGGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeSlice<Vector3> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeSlice<Vector4> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector2> JEFINEIINOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector2> ANBHPDDAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector2> OOFOHNHEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> ODKDHGOBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Color> KEGLFIONCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<int> EBGFHBBODOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<int> ILNMBCKHFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<BoneWeight> LJLHFICKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<byte> PBMDCGONBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int BINDKEMLOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Matrix4x4 AHMGCGOELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public int JMICFJMFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<byte> PLJGGOAPADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public bool EKNOIKLGOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int FEINIMBMLCD;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct ENKNAPKELMB : IEquatable<ENKNAPKELMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	internal readonly Material DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	internal readonly MNGJIPIOLKF NBJGJFDFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	internal readonly FGLLDEOHPGM GLEFIFHIFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly PPEPNMKDOKP ABFBNDAKGHA;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xE15FD0", Offset = "0xE14FD0", VA = "0x180E15FD0")]
	public ENKNAPKELMB(Material BIDMCIBAHOL, MNGJIPIOLKF DMKLLKMOOIF, FGLLDEOHPGM OCMGLDFKCOK, PPEPNMKDOKP ABOBDACKLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AE10", Offset = "0x6D39E10", VA = "0x186D3AE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xE15D30", Offset = "0xE14D30", VA = "0x180E15D30", Slot = "4")]
	public bool Equals(ENKNAPKELMB DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AC90", Offset = "0x6D39C90", VA = "0x186D3AC90", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AD70", Offset = "0x6D39D70", VA = "0x186D3AD70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EPOGNIAMNNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MaterialPropertyBlock KGOJLKMLOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Color? FGIBJGGMLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Color? HFLPBLELBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public Color? KNHPGPLDJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? BNEABBBHBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color KMBILLNBOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color GMMDBPEOFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color CODFCAIIHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Texture2D LIJECBCNKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Texture2D ECKCKBIJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Dictionary<ENKNAPKELMB, int> BGMCNPGNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private MNGJIPIOLKF[] KGFPBMGBGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private FGLLDEOHPGM[] JLLEILBLKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector4[] DAGDACJKEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector4[] LACADNAHNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector4[] JABKJBNKJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] IHIGLADLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] JKLGDPLAJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] HHEBGIDCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private List<Texture2D> LNLBAIMEKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private Vector4[] HNJJDBKKDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private List<Texture2D> PGCJJHNBFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private float[] CPGOANILGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] HHFNKHOHBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float[] ACACCBCBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float[] HKNGEBLLBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> GIGODDGKAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] MFGCBMNDPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> INHCMAKKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Vector4[] IBOOJLDFMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] EDCELAKAJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Vector4[] KGJPBIFCNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] LLNACFCLJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Texture2DArray CBJHJBPLNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Texture2DArray GPFBJCDJBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Texture2DArray GNOJHBJEOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray BLCFDHCHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool BMDEJGLKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int BJJGGNNNBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Vector2? MFCPNKDPOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private TextureFormat LJAIHNLAFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Vector2? HCAAAMLFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private TextureFormat DKDDCJMMMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Vector2? CGHADDBAIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private TextureFormat FJDCDEGFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private Vector2? MNHLHKCJEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private TextureFormat CJAKILKNLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool GNHIBNEGODJ;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int BKBHPKFMECE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int NIPFBHNFHJE;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static int CNOOACOKPPB;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int PLOELOKGGKG;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int AGBJPNONHEK;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int OEOOKEIMMFL;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int JKDBBKLNODP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int KIANBDCEDAO;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int JHNJKCCKCDB;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int KMEFPNEPOIC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int JDHILEKBFFA;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int MNKHPGGJGCC;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int HEODJHKPBBJ;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int LJNLIMDOBGA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int GDKLNBLAGOI;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int HNHADLGLMND;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int EGNEBIGCGDN;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int BADENGFMFNM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int EPLCHKGDEEO;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int FBPCLPAGGHD;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D580", Offset = "0x6D3C580", VA = "0x186D3D580")]
	private EPOGNIAMNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DA70", Offset = "0x6D3CA70", VA = "0x186D3DA70")]
	public EPOGNIAMNNB(Color PBBMIIMAGAJ, Color FJMEPHJOGEI, Color JCIDDNHOPDE, Color? JBGEJAJOOLP, Color? FDKAIOANCEG, Color? JKMKFMLKPOJ, Texture2D MDNGAIKAEFC, Texture2D FJCJNMDJKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B4A0", Offset = "0x6D3A4A0", VA = "0x186D3B4A0")]
	internal int JECEICMJFHA(Material OIMNJKHDOIJ, MNGJIPIOLKF DMKLLKMOOIF, FGLLDEOHPGM OCMGLDFKCOK, PPEPNMKDOKP ABOBDACKLMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B410", Offset = "0x6D3A410", VA = "0x186D3B410")]
	private int JECEICMJFHA(ENKNAPKELMB MLAECOMLIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B590", Offset = "0x6D3A590", VA = "0x186D3B590")]
	internal int KHJHONPLDCE(Material OIMNJKHDOIJ, Color DNJBBPDJGKI, Color DLBBNMAKHKC, Color GMNBBPBIOBF, Color IHGDNLCEGKO, Color OMNMILOBKGF, Texture2D FJOFJBIHPFJ, Vector4 OOADBABAJPL, Texture2D JILCHNADLGN, Vector4 HCNGHLNPNLI, float ODNHDNMEMDH, float PECGIEKEFGN, Texture2D HDCAPMKOLBL, Vector4 ICJECBBKDLG, float IBKDPLNNHKN, Texture2D HDNEJHAFJIF, Color HMGMJNBFGNO, Vector4 BKMJODHEJGD, MNGJIPIOLKF DMKLLKMOOIF, FGLLDEOHPGM OCMGLDFKCOK, PPEPNMKDOKP ABOBDACKLMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C160", Offset = "0x6D3B160", VA = "0x186D3C160")]
	private void LDAFPHBMKDN(List<Texture2D> LNLBAIMEKON, [Out] Texture2DArray BGOIIIFLEEE, [Out] Texture2DArray HFJMGEHDJEL, [Out] Texture2DArray IHAIGCPFCIH, [Out] Texture2DArray KBDLOPPIMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B2C0", Offset = "0x6D3A2C0", VA = "0x186D3B2C0")]
	public void EHGMLBECKGC(Shader NKGHABFCNAN, Renderer CONCMEKGEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C5D0", Offset = "0x6D3B5D0", VA = "0x186D3C5D0")]
	private void OOGCHDJAGKL(Shader NKGHABFCNAN, Renderer CONCMEKGEHE, int ONLGIJANAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C3D0", Offset = "0x6D3B3D0", VA = "0x186D3C3D0")]
	private Color OFIGGHGPJGJ(Color HADMOANLNCM, MNGJIPIOLKF CHEKLCLJKCJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B030", Offset = "0x6D3A030", VA = "0x186D3B030")]
	private Color BBNCMNNBLHB(Color JCNKHIKOBHK, MNGJIPIOLKF CHEKLCLJKCJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B180", Offset = "0x6D3A180", VA = "0x186D3B180")]
	private bool BLAFMBKFGNE(Texture2D BCDMEOKABPG, FGLLDEOHPGM NGPDHJFJGDI, [Out] Texture2D KAHDFGLCBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C320", Offset = "0x6D3B320", VA = "0x186D3C320")]
	private void MLGKPCOCBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B280", Offset = "0x6D3A280", VA = "0x186D3B280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MBGBPIKFOJH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class IDGEAJEFBIK : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public IDGEAJEFBIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xE18A40", Offset = "0xE17A40", VA = "0x180E18A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E8F0", Offset = "0x6D3D8F0", VA = "0x186D3E8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public static void PJFNKDFLGCK(string JHCIODFGPNM, int ADNNLIGBFLK, long ICHMEGHFMJN, long JOPLPEKHMOG, long ABJLDHIBCIL, long DMKPDAEPLKP, long DLADJGJAACG, long AGGHLOEMIEH, long ODCIOPODIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D3EF10", Offset = "0x6D3DF10", VA = "0x186D3EF10")]
	public static DDGDFMBPLHP JGGANIFPGKG(JobHandle LFJDJPGAHKL, bool JIEIMICAPPI, bool KNLMDNPBENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D3EEA0", Offset = "0x6D3DEA0", VA = "0x186D3EEA0")]
	[IteratorStateMachine(typeof(IDGEAJEFBIK))]
	private static IEnumerator<MIAEKAOKMEH> EBICJAIJNNH(JobHandle GCBNNIKBPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FPLFLIDKMJI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum AKPKLNIDHGN
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly int CIKHDKKOJNP;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly int GPCPJGPGFHD;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly int CFCMIMMPKJA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly int KGJPFIBJEEE;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static readonly int IMPCEBMCEFB;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static readonly int NHNGHKPHLCE;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly int HGDMIJKBGJF;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly int MPJPELFNGEP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DBF0", Offset = "0x6D3CBF0", VA = "0x186D3DBF0")]
	public static bool GCABGPANMDE(Material BIDMCIBAHOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DB30", Offset = "0x6D3CB30", VA = "0x186D3DB30")]
	public static bool BILGMDINFIK(Material BIDMCIBAHOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MFMLIJMAMFK : HHMILCOKIIM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private HCLEHEFKOEM ENMFEGEIJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private MEIMGFEEEKB ENKDAIGCGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IRecRoomQualityConfigProvider CIFDKMICGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool HKCEEGEEAEP;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F060", Offset = "0x6D3E060", VA = "0x186D3F060")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void AANLPAMKFCI(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6047FE0", Offset = "0x6046FE0", VA = "0x186047FE0")]
	[UnityEngine.Scripting.Preserve]
	public MFMLIJMAMFK([GAHPILLNNBL(null)] MEIMGFEEEKB FJBBNBBIFKF, [GAHPILLNNBL(null)] HCLEHEFKOEM NMHLAKLJGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F160", Offset = "0x6D3E160", VA = "0x186D3F160")]
	private void AELNIDDLNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F7F0", Offset = "0x6D3E7F0", VA = "0x186D3F7F0", Slot = "4")]
	public void IAKLPBGIFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F1F0", Offset = "0x6D3E1F0", VA = "0x186D3F1F0", Slot = "5")]
	public DIHMDMOKEDJ<Texture2D> FOHKKNMAPDI(LLHAHCOPPAC BMNHLLBGNPK, [Optional] JBNKJKEOLAH IEEFMIOJLFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F6C0", Offset = "0x6D3E6C0", VA = "0x186D3F6C0")]
	private uint GMLBLDPMKOC(LLHAHCOPPAC BMNHLLBGNPK, JBNKJKEOLAH IEEFMIOJLFJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PGBMKDBLHLO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMNFJLCHEAG(Mesh BKGAJHNMIBN, Matrix4x4 BPKHDBLOPAL, byte[] PLJGGOAPADK, bool KOJPPKOBMFL = false, ODJFHHHGCLI.EDMGMMBMGFC BOOJGIFPGNN = (ODJFHHHGCLI.EDMGMMBMGFC)0, int JKOBJOLEPPD = -1, bool HEEGOJPJIHF = false);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBFMHFPPBII(Allocator HHJAFJNPHLL, CMCDHOKBBFF GJDNEKDNECO, byte DPCJMGAADAK, [Optional] IList<int> OGNCKAMEIAA, [Optional] IList<int> JBOKJLPHPEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct BNMAGILCGLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly GameObject HKFENGNLOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly AvatarItemMaterial NCBMKMLKOAP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public BNMAGILCGLN(GameObject HKFENGNLOPK, AvatarItemMaterial NCBMKMLKOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6D36680", Offset = "0x6D35680", VA = "0x186D36680")]
	public void KEJPFNFMACG(Material BIDMCIBAHOL, int OEDNNJBIBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PGHPKILEHKK : BALDHGIADLH<Task<(GameObject, AvatarItemMaterial)>, BNMAGILCGLN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OMOGGMPHEIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6D3FD10", Offset = "0x6D3ED10", VA = "0x186D3FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6D40210", Offset = "0x6D3F210", VA = "0x186D40210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private DIHMDMOKEDJ<GameObject> BIDFPGLPLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private DIHMDMOKEDJ<AvatarItemMaterial> BMJCGEHPMHF;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D408E0", Offset = "0x6D3F8E0", VA = "0x186D408E0")]
	private PGHPKILEHKK(Task<(GameObject, AvatarItemMaterial)> KDFIPCHFLGF, DIHMDMOKEDJ<GameObject> LHLMMCNIKIP, DIHMDMOKEDJ<AvatarItemMaterial> KFKODOJHCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D40280", Offset = "0x6D3F280", VA = "0x186D40280")]
	public static PGHPKILEHKK AIOPMLNOOEO(AssetReference FFPIDHNJJEI, [Optional] AssetReference MILLFBOBNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D40710", Offset = "0x6D3F710", VA = "0x186D40710", Slot = "11")]
	protected override BNMAGILCGLN ELLPKGJKPLC(Task<(GameObject, AvatarItemMaterial)> JKAJPAEGJIL)
	{
		return default(BNMAGILCGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D40690", Offset = "0x6D3F690", VA = "0x186D40690", Slot = "12")]
	protected override void BDNOPBPGHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6D407B0", Offset = "0x6D3F7B0", VA = "0x186D407B0")]
	[AsyncStateMachine(typeof(OMOGGMPHEIB))]
	private static Task<(GameObject, AvatarItemMaterial)> FGPEOEOBHOD(Task<GameObject> OAIAGAEFNBK, Task<AvatarItemMaterial> DIFOMGLBGMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NGPCPBKKIME
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class JFCMGDKFHAK : BALDHGIADLH<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private DIHMDMOKEDJ<MaterialMapAsset> GCBNNIKBPHJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3EDC0", Offset = "0x6D3DDC0", VA = "0x186D3EDC0")]
		public JFCMGDKFHAK(DIHMDMOKEDJ<MaterialMapAsset> GCBNNIKBPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E9A0", Offset = "0x6D3D9A0", VA = "0x186D3E9A0", Slot = "11")]
		protected override Material[] ELLPKGJKPLC(Task<MaterialMapAsset> KDFIPCHFLGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E940", Offset = "0x6D3D940", VA = "0x186D3E940", Slot = "12")]
		protected override void BDNOPBPGHDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class GHKJPOCJHAM : BALDHGIADLH<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private List<DIHMDMOKEDJ<Material>> CAAEFBINFDJ;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E880", Offset = "0x6D3D880", VA = "0x186D3E880")]
		public GHKJPOCJHAM(Task<Material[]> KDFIPCHFLGF, List<DIHMDMOKEDJ<Material>> CAAEFBINFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E830", Offset = "0x6D3D830", VA = "0x186D3E830", Slot = "11")]
		protected override Material[] ELLPKGJKPLC(Task<Material[]> JKAJPAEGJIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E6F0", Offset = "0x6D3D6F0", VA = "0x186D3E6F0", Slot = "12")]
		protected override void BDNOPBPGHDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F870", Offset = "0x6D3E870", VA = "0x186D3F870")]
	public static DIHMDMOKEDJ<Material[]> KCAFGKGACDH(AssetReference[] DALAIMIBLOE)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6D40970", Offset = "0x6D3F970", VA = "0x186D40970")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct DNJDDGCCCAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<GIJJKIDEJBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private TaskAwaiter<GIJJKIDEJBL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6D37760", Offset = "0x6D36760", VA = "0x186D37760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6D37B40", Offset = "0x6D36B40", VA = "0x186D37B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private Dictionary<CEHCJOLGKJG, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<CEHCJOLGKJG, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<CEHCJOLGKJG, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<CEHCJOLGKJG, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private readonly Dictionary<CEHCJOLGKJG, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private GIJJKIDEJBL _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GIJJKIDEJBL _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6D3E6C0", Offset = "0x6D3D6C0", VA = "0x186D3E6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E1B0", Offset = "0x6D3D1B0", VA = "0x186D3E1B0")]
		public GIJJKIDEJBL MGNMOOIBEPK(HEGHLNFMEGC KJFGNCHICJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E000", Offset = "0x6D3D000", VA = "0x186D3E000")]
		[AsyncStateMachine(typeof(DNJDDGCCCAG))]
		public Task<GIJJKIDEJBL> EKCADHLOLMO(int? CCICAILGJDC, int EMBIKFJCDHF, int OIBOMIOHGBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E410", Offset = "0x6D3D410", VA = "0x186D3E410")]
		public NoseFaceOption PJCBNFEOAIJ(int DEKJIPBCCMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E4B0", Offset = "0x6D3D4B0", VA = "0x186D3E4B0")]
		public SelectableFaceOption PNMJPAKFCCB(FaceFeatureType LDJGABCJBIB, CEHCJOLGKJG CACNEJONHCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E130", Offset = "0x6D3D130", VA = "0x186D3E130")]
		public int IOKIJDNMMNB(CEHCJOLGKJG CACNEJONHCK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DDD0", Offset = "0x6D3CDD0", VA = "0x186D3DDD0")]
		private void BJHFKCFEHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2F76390", Offset = "0x2F75390", VA = "0x182F76390")]
		private void OCAOCPBDPDB<T>(IDictionary<CEHCJOLGKJG, T> LMPEOFNFEPH, IReadOnlyList<T> OMLDJCJEOFL) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E360", Offset = "0x6D3D360", VA = "0x186D3E360")]
		public CEHCJOLGKJG NJICEDHLCJG(FaceFeatureType LDJGABCJBIB)
		{
			return default(CEHCJOLGKJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E240", Offset = "0x6D3D240", VA = "0x186D3E240")]
		public CEHCJOLGKJG NDJDJGOADIN(FaceFeatureType LDJGABCJBIB)
		{
			return default(CEHCJOLGKJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E630", Offset = "0x6D3D630", VA = "0x186D3E630")]
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
