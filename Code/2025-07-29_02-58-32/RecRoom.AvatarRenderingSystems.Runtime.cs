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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8131310", Offset = "0x812FD10", VA = "0x188131310", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x81337E0", Offset = "0x81321E0", VA = "0x1881337E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8133770", Offset = "0x8132170", VA = "0x188133770", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81337A0", Offset = "0x81321A0", VA = "0x1881337A0")]
		public RecNetCDNAssetReference(RecNetCDNKey LNBCHJPEENA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum ALIMJAEDENL : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ALIMJAEDENL PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF26B10", Offset = "0xF25510", VA = "0x180F26B10")]
			[CompilerGenerated]
			get
			{
				return default(ALIMJAEDENL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x157F750", Offset = "0x157E150", VA = "0x18157F750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81338F0", Offset = "0x81322F0", VA = "0x1881338F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8133870", Offset = "0x8132270", VA = "0x188133870")]
		public static RecNetCDNKey CLGIFNBBNBC(string ACEIGJEDPNK, ALIMJAEDENL LOLBNMCKAHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8133820", Offset = "0x8132220", VA = "0x188133820")]
		public void BPIDHIOFOGC(string FJELCKPNDJK, string KEGBPMLIINA, bool MIPHLPOHOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IHCCCAONNEJ]
public class PELKIMAOJDA : JIAOPHGAFFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> IHKAIBEMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> ELGELDPKDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> MKIPLNHDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> BMJGAEMDKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> OOMAEPFKFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> CBJLPDFHCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> EICPPJMBJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator OCAGBAGJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected FFOICIGPDAP MCMKPKIKBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte HCFLBLFKPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> JCBHFNAFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> CECBMHLIJKE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8132F90", Offset = "0x8131990", VA = "0x188132F90", Slot = "4")]
	public void MEPHJBHIIDF(Mesh HFCMFMCGELA, Matrix4x4 FAJKMJNBNAD, byte[] GKJGONNIFAP, bool KKIFBMMOHPF = false, EAIOHGIPLKL.BKMDKGNIEFL OJIPFBNOEHM = (EAIOHGIPLKL.BKMDKGNIEFL)0L, int OIIGNCDIDBK = -1, bool OOBMHEOBKLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8132F50", Offset = "0x8131950", VA = "0x188132F50", Slot = "5")]
	public void AOJIMFACMBK(Allocator POJKLAFAMOD, FFOICIGPDAP NPEMINJBBFN, byte PCNKGECIAEF, [Optional] IList<int> JMOCHABNFND, [Optional] IList<int> DMBIDKOHAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81332C0", Offset = "0x8131CC0", VA = "0x1881332C0")]
	private static void OBDGLMGDHGB(Mesh HFCMFMCGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8133520", Offset = "0x8131F20", VA = "0x188133520")]
	public PELKIMAOJDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IHCCCAONNEJ]
public struct KLPEFGKKFDM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public PCKFNGNFHEA LJMLKFNGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int JDJOBCEOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public BMLODCDIMPL CIBKBDJMBHK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x812F900", Offset = "0x812E300", VA = "0x18812F900", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[IHCCCAONNEJ]
public struct BMLODCDIMPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct GNFDGGBHGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 LIMFMFDFBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 HKIFHFOHPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 CBDPDNHHJDB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OKPHGKKAFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float KJBEIBFIFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float NGCGJIMNKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float BOPDCDMPLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float DKMGOLMACPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte AGGFLECCDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte LBDGNKKFABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte CDGKMABCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte ONILNKIMAAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BLHCKFHMHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half KJBEIBFIFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half NGCGJIMNKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half BOPDCDMPLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half DKMGOLMACPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte AGGFLECCDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte LBDGNKKFABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte CDGKMABCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte ONILNKIMAAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CFPFAEJPHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct DGNEDKDABOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DCENMJLHMLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 PIEJMAALAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EHHACPNKLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 PIEJMAALAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 HJILCAJBBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BMJLOEAGBPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float KJBEIBFIFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float NGCGJIMNKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float BOPDCDMPLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float DKMGOLMACPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int AGGFLECCDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int LBDGNKKFABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int CDGKMABCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int ONILNKIMAAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct NAOBBDLCFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EDNFGKODFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PIBFLJILLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 PIEJMAALAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IFIEDNCCEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color EDNHAEBPHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 IDPEJCCEMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 MJLHLNGPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 PIEJMAALAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 HJILCAJBBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 BHFHKMMMHHD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool PFIDHEAFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<GNFDGGBHGAB> AHFOAGIFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<CFPFAEJPHGG> MNIKLOEFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<DGNEDKDABOK> HPEAKBHIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DCENMJLHMLD> LGMHDMOAHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<EHHACPNKLIO> OAMFAHFALDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BLHCKFHMHHE> HFFPANMAAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OKPHGKKAFCI> PHKICKDJKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<NAOBBDLCFDF> PLJHAPOGILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<EDNFGKODFGI> PNGABFDDABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<PIBFLJILLFF> CGCBENJCCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<IFIEDNCCEKC> CPJENIALIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<BMJLOEAGBPC> FCNIJDEICHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> CPFKODKIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> PNLFJAMKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> PLCBBGENKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OEJGIPEKOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> KIDGNEBDGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> ABDDOIDCPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> JBAMPAHCLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> FNONCOGGOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> HKENEGGNMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool DCGJECKIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ABCPPNJCCKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JMIMGNNKING
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8120100", Offset = "0x811EB00", VA = "0x188120100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81205A0", Offset = "0x811EFA0", VA = "0x1881205A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IJEPFCODIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x811DE10", Offset = "0x811C810", VA = "0x18811DE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x811F920", Offset = "0x811E320", VA = "0x18811F920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KKHDGMOBAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81205B0", Offset = "0x811EFB0", VA = "0x1881205B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x811DD60", Offset = "0x811C760", VA = "0x18811DD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int POOAPHLIJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x811F8B0", Offset = "0x811E2B0", VA = "0x18811F8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81205C0", Offset = "0x811EFC0", VA = "0x1881205C0")]
	public BMLODCDIMPL(int DNNLLCOBDHH, int IPIDELNGPDP, int HCMPNECOHIM, int BKENDDNDLCL, Allocator POJKLAFAMOD, int IHOKHPIJHKB, HELBJPCILHJ FEFMLHDFOBE, bool DCGJECKIBJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x811DD70", Offset = "0x811C770", VA = "0x18811DD70")]
	public void BOJHFKPLGDD(int FILGHJLFKAL, Vector3 ELPCBPJLJEF, Vector3 AMLMOHAGJJA, Vector4 JCAFCJGCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x811FCD0", Offset = "0x811E6D0", VA = "0x18811FCD0")]
	public void MOHGEDKNFEP(int FILGHJLFKAL, BoneWeight BOBPGPAAOLB, NativeSlice<byte> GKJGONNIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x811F4C0", Offset = "0x811DEC0", VA = "0x18811F4C0")]
	public Color JKCCCIAPCAF(int FILGHJLFKAL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8120170", Offset = "0x811EB70", VA = "0x188120170")]
	public void NHMDJAGANPG(int FILGHJLFKAL, Color HFDMMDBJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x811F3D0", Offset = "0x811DDD0", VA = "0x18811F3D0")]
	public void JCBGDDKJJNP(int FILGHJLFKAL, Vector3 FBHMIIMHGKJ, Vector3 JDCKEHABNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x811F930", Offset = "0x811E330", VA = "0x18811F930")]
	public void MENACPDKPGF(int FILGHJLFKAL, half4 JMKACMMOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x811FA80", Offset = "0x811E480", VA = "0x18811FA80")]
	public void MICALCDLPDO(int FILGHJLFKAL, Vector3 JMKACMMOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x811EFC0", Offset = "0x811D9C0", VA = "0x18811EFC0")]
	public void JBFLLLOBJED(byte COECLOPKNPG, int FILGHJLFKAL, Vector2 JMKACMMOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x811DE00", Offset = "0x811C800", VA = "0x18811DE00")]
	public void DKMOBIGDBFE(int FILGHJLFKAL, int IFAMLBGMMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8120110", Offset = "0x811EB10", VA = "0x188120110")]
	public bool NGEKCEHFDIM(int COECLOPKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x811F7E0", Offset = "0x811E1E0", VA = "0x18811F7E0")]
	public void LHEHFAOPKFF(int FBFMMNLCIEN, int KIOPHNHDMKE, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x811DE20", Offset = "0x811C820", VA = "0x18811DE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x811E080", Offset = "0x811CA80", VA = "0x18811E080")]
	public Mesh EMKBECPNPMA([Optional] string MPONCKBONFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[IHCCCAONNEJ]
public struct PCKFNGNFHEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray KPENCHGOPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> CFBEBFHNLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> IEPKICNHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> FNONCOGGOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> PEHEDAMCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> JGBEBNBIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> FGFLPACPNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> NCEFOPCKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> MCPOLIBPNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> JNBAOKKKGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> MCABNODCAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> OOBMHEOBKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> OIIGNCDIDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool DCGJECKIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> IJHEKEHAOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool ABCPPNJCCKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NKOFPMBEGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81318D0", Offset = "0x81302D0", VA = "0x1881318D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ICOCENKBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8131D50", Offset = "0x8130750", VA = "0x188131D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FDJJDLNIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8131B70", Offset = "0x8130570", VA = "0x188131B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PEJMECJCBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81318C0", Offset = "0x81302C0", VA = "0x1881318C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8131900", Offset = "0x8130300", VA = "0x188131900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JMIMGNNKING
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8131C40", Offset = "0x8130640", VA = "0x188131C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8131C60", Offset = "0x8130660", VA = "0x188131C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GLFPGBMCDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81318E0", Offset = "0x81302E0", VA = "0x1881318E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8131B60", Offset = "0x8130560", VA = "0x188131B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FFOICIGPDAP HNGNHLGNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81318F0", Offset = "0x81302F0", VA = "0x1881318F0")]
		get
		{
			return default(FFOICIGPDAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8131C50", Offset = "0x8130650", VA = "0x188131C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte HDNAHKNCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8131C70", Offset = "0x8130670", VA = "0x188131C70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8131730", Offset = "0x8130130", VA = "0x188131730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BADDCEBDAIP EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8131910", Offset = "0x8130310", VA = "0x188131910")]
		get
		{
			return default(BADDCEBDAIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8131D60", Offset = "0x8130760", VA = "0x188131D60")]
	public PCKFNGNFHEA(IList<Mesh> AGHGFLKJGKM, IList<Matrix4x4> NDEHPICJKCB, IList<bool> OOBMHEOBKLP, byte PCNKGECIAEF, IList<byte[]> GJDIBDDOOCP, IList<long> OGGHEAOGFBE, IList<bool> OBOEBDPLPBE, IList<int> OIIGNCDIDBK, IList<int> JMOCHABNFND, IList<int> JLABENOIGLA, Allocator POJKLAFAMOD, FFOICIGPDAP NPEMINJBBFN, bool DCGJECKIBJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8131C80", Offset = "0x8130680", VA = "0x188131C80")]
	public BMLODCDIMPL PKACPABLLDB(Allocator POJKLAFAMOD, HELBJPCILHJ FEFMLHDFOBE)
	{
		return default(BMLODCDIMPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8131740", Offset = "0x8130140", VA = "0x188131740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IHCCCAONNEJ]
public class HGOMMFGDFEJ : PELKIMAOJDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool MMEBIBMNFAD;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker LHHFEECMDPL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8121970", Offset = "0x8120370", VA = "0x188121970")]
	public PCKFNGNFHEA NFCEAKLCJBC()
	{
		return default(PCKFNGNFHEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8121C30", Offset = "0x8120630", VA = "0x188121C30")]
	public HGOMMFGDFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BADDCEBDAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData LOAEKAINCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> FNONCOGGOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> LEGLNKAKLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int JOGNOEGGOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 HBNEEFJKGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long PNGNADEGJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> GKJGONNIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool HDHBEMALEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int COKCFIFLNDN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KAAAFBEDNIK : POODIKIDKFI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OKNJPEAKGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KAAAFBEDNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DAMMDADGLAC buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Action<KeyValuePair<string, FDLGIOOGFEJ<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OKNJPEAKGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x81315C0", Offset = "0x812FFC0", VA = "0x1881315C0")]
		internal bool FNCFJKIDKEH(MFEMMJNIGFA item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8131600", Offset = "0x8130000", VA = "0x188131600")]
		internal void LIPLOIIDHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8131650", Offset = "0x8130050", VA = "0x188131650")]
		internal void MAIKFBDCOJE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8131600", Offset = "0x8130000", VA = "0x188131600")]
		internal void JHBIOIGDCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8131650", Offset = "0x8130050", VA = "0x188131650")]
		internal void PJDJPKBPFLN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8131620", Offset = "0x8130020", VA = "0x188131620")]
		internal void KOMBHNPNNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8131590", Offset = "0x812FF90", VA = "0x188131590")]
		internal void DHMMOGEKGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8131670", Offset = "0x8130070", VA = "0x188131670")]
		internal void PLFJACHADLJ(Dictionary<string, FDLGIOOGFEJ<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x81314D0", Offset = "0x812FED0", VA = "0x1881314D0")]
		internal void AJCLIODMKJP(KeyValuePair<string, FDLGIOOGFEJ<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		internal PNBAKNHPHGJ HCINLELNOCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AKNPKPAAMPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public OKNJPEAKGGM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AKNPKPAAMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x811DCA0", Offset = "0x811C6A0", VA = "0x18811DCA0")]
		internal MILNCMCHGEA BJPCIMDBPAJ(int lod)
		{
			return default(MILNCMCHGEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GCLAJFCHPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GCLAJFCHPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		internal DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>> GIFIAFHIMJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MAKFOGGIMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<DAMMDADGLAC> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MAKFOGGIMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x81313A0", Offset = "0x812FDA0", VA = "0x1881313A0")]
		internal void NBNAAAAHAFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GMIBNEMMDDB : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public KAAAFBEDNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<LOGBNBAILEJ> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<DAMMDADGLAC> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Func<int, MILNCMCHGEA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CHCHOGCNLGF materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public GMIBNEMMDDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x81216A0", Offset = "0x81200A0", VA = "0x1881216A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8121920", Offset = "0x8120320", VA = "0x188121920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MJNIHNKDELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public MNBLEBGMFII cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MJNIHNKDELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBD1A00", Offset = "0xBD0400", VA = "0x180BD1A00")]
		internal void PLMEMCAIOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1DDE0", Offset = "0xE1C7E0", VA = "0x180E1DDE0")]
		internal void ALAEHFKGBIG(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EJEPEOBPAHF
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
		public KAAAFBEDNIK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EJEPEOBPAHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GLJIKEOEPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public BMLODCDIMPL defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public PCKFNGNFHEA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public EJEPEOBPAHF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GLJIKEOEPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8121030", Offset = "0x811FA30", VA = "0x188121030")]
		internal void FHBPLLEMGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8121630", Offset = "0x8120030", VA = "0x188121630")]
		internal void JPHNCNPPADB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JPLKENABGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public IMDBBAIHNMF legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public HMCFDEEIKGA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public EJEPEOBPAHF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JPLKENABGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8121C40", Offset = "0x8120640", VA = "0x188121C40")]
		internal void IGEPNNLLPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8121E80", Offset = "0x8120880", VA = "0x188121E80")]
		internal void OAFPCFCLLKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GLEMADAAAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public KAAAFBEDNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GLEMADAAAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8120FF0", Offset = "0x811F9F0", VA = "0x188120FF0")]
		internal void EHLHKHMIPBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KPGJFAHGOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BEBMGMBEIIO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KPGJFAHGOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8131290", Offset = "0x812FC90", VA = "0x188131290")]
		internal bool GDELNMHJEBC(KeyValuePair<string, MFEMMJNIGFA> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly HPDJJKCNBLF BPBDELAHJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HPDJJKCNBLF PGECOACBIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<CIDNHECLAKJ, float> HICLDOLNJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<OEBHGMLHFGG, float> GFFNENGJHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<BDONOFFGMKE, float> PINCPIAJKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, BILPPIHAGGF> NCELFEDFNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, BILPPIHAGGF> KBPEGLJOLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, BILPPIHAGGF> LCEOMGHPBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, BILPPIHAGGF> MGOAEAJICOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private JPPAJFNEJPL JOCKEDJILCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private JPPAJFNEJPL OPLHFIOCIFM;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float LGBHIBHPCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? MDENFHLKEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? FDKOHLJKEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? KMOLJLFFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? CEHKKJMAJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration HEDFCIHNABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform FFFAPNMLLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem NGAILDLBIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference BKCPNJPGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GameObject DOHFJNKEGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private GameObject EODLBAJIBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private SkinnedMeshRenderer OBHIKPOKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private AvatarSkinnedMeshBoneOrderRemapsData GMPNAHCHHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Transform[] AMIIKKBLKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Matrix4x4[] JOOCDEANEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Material LADHBGHKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Material EEIPOPFPFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Material EEAENJCGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Material CEENNILHNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Shader NBMDLNGNDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Shader KKMLOFOPODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Animator NNFGLNEEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Renderer[] HBDPBCOLELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private EAIOHGIPLKL.BKMDKGNIEFL AEMAFJPFPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarBodyPartShapesManager EAOBAKIHPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private IReadOnlyDictionary<string, Transform> GCJIPDLINOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private AvatarFaceShapeData.KEAEOIMBJON MOAAKGFJHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AvatarBodyShapeData.CHGJAENOJIL LHJLIGJFMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private BALOCJGIMAO LOIGFDPBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool FKEIAPBPBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool KCLAMLECLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Color IAAAIDGOEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Color HPIBBCBOGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color DFPMGOIMLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color? DBBDHGJMBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Color? EABNOOJHPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color? IIEGGNMBOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color? HDDKNLFJGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Texture2D EONCKJLJECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Texture2D KNDHGHMJPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CanBeNull]
	private MFEMMJNIGFA JFAMPEOCPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Texture PLHFBJIKOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color EMMPNMCGCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Dictionary<Renderer, CHCHOGCNLGF> HDGDFIKKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<Renderer, CHCHOGCNLGF> AHFBOLOIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Dictionary<string, List<GCKGBKNGHNK>> PECOBMPHPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Dictionary<string, List<GCKGBKNGHNK>> AJEMGLDJGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly List<OMAHFCAPHPN> CPIGLDEJICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<OMAHFCAPHPN> DHDNLPEBCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<OMAHFCAPHPN> NNDKNIPGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<OMAHFCAPHPN> ECDPMLFKNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<GCKGBKNGHNK, Material> MINGHDDEANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<GCKGBKNGHNK, Material> FJANJDFHDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private SkinnedMeshRenderer[] PJKNKEFPLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] JLHNHNFPOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] KLFHAIHLKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SkinnedMeshRenderer[] EMPKLAGNGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Dictionary<string, FDLGIOOGFEJ<Texture2D>> HPDIFGEAPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<string, FDLGIOOGFEJ<Texture2D>> FCGEAGBKEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private AdditionalHatData MAHGEGPHAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AdditionalHatData PKPJJOLEJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HairData FOAFHGMLHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HairData JJKHNJLHECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private JNPBPAOBAGK OCNLKHGEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool? EKAGMDMOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation CHLJCLHJOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Transform MALFBAIELJH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Material EOJJNJPDLLG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Material BKEFBPCMCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Dictionary<string, MFEMMJNIGFA> FNNAOBHPGJE;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int HLNJMGLFCIG;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int EBIKCDLJGPI;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int OOCFJPAGAMH;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int HCLPHFEPHLF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int JKEGGKJHFJJ;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int BCCHELBJMFJ;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JCIALLGGCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool FPFLNLCKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private List<Action> EOMCMHDLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NKOKBMFEAOJ BNHGNDFICCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private SkinnedMeshRenderer[] DEMCEBCPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int FANNBBAJOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool HJNCECKAHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int MKJMGPEMNOP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HPDJJKCNBLF EOHDHJNNOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HPDJJKCNBLF CBLOGLFBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private DBKGBEHKCFL HENOFOKJKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8128AA0", Offset = "0x81274A0", VA = "0x188128AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool FMLAFBIAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x812CFB0", Offset = "0x812B9B0", VA = "0x18812CFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool PICBDKLOCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8126C00", Offset = "0x8125600", VA = "0x188126C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool HHMIJHDGHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x812E240", Offset = "0x812CC40", VA = "0x18812E240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool MEGEICFPGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8123570", Offset = "0x8121F70", VA = "0x188123570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration KCMCILAJIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JAFOLMIDBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8123750", Offset = "0x8122150", VA = "0x188123750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2649270", Offset = "0x2647C70", VA = "0x182649270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material KJKPLPIOKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8123020", Offset = "0x8121A20", VA = "0x188123020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material HJHMIIEFOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8123390", Offset = "0x8121D90", VA = "0x188123390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LNMFALGDCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EAJLGMHEHMA BHILEGIKIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1351200", Offset = "0x134FC00", VA = "0x181351200", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(EAJLGMHEHMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x134F710", Offset = "0x134E110", VA = "0x18134F710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material PKOLGEKADML
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB40660", Offset = "0xB3F060", VA = "0x180B40660", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] JLHJHPNAAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB82160", Offset = "0xB80B60", VA = "0x180B82160", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] FPDFJFECNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAFCCC0", Offset = "0xAFB6C0", VA = "0x180AFCCC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BHBNKOOEHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8128D70", Offset = "0x8127770", VA = "0x188128D70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EAIOHGIPLKL.BKMDKGNIEFL LPOELOHIGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB0A4B0", Offset = "0xB08EB0", VA = "0x180B0A4B0", Slot = "20")]
		get
		{
			return default(EAIOHGIPLKL.BKMDKGNIEFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OGBJMLHOODA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x134F980", Offset = "0x134E380", VA = "0x18134F980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81261E0", Offset = "0x8124BE0", VA = "0x1881261E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool AMBLBHGHNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8127800", Offset = "0x8126200", VA = "0x188127800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool FMDMKFHCGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8122060", Offset = "0x8120A60", VA = "0x188122060", Slot = "15")]
	public DAMMDADGLAC AFILPMPDKKP(PKHBAFJFHAL DLDGIFCDFPL, bool KBONCIJCCCC, int[] CIJIIIPLHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x812E320", Offset = "0x812CD20", VA = "0x18812E320", Slot = "14")]
	public DAMMDADGLAC NKAKEABOAAI(PKHBAFJFHAL DLDGIFCDFPL, bool KBONCIJCCCC, int[] CIJIIIPLHCD, Func<Dictionary<string, MFEMMJNIGFA>, (DAMMDADGLAC, DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>>)> KNCINIFAGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81290B0", Offset = "0x8127AB0", VA = "0x1881290B0")]
	public DAMMDADGLAC JLALCENJNMF(PKHBAFJFHAL DLDGIFCDFPL, bool KBONCIJCCCC, int[] CIJIIIPLHCD, bool DOOHBPMMGBP, JPPAJFNEJPL NFJHDACFDHG, [Optional] Func<Dictionary<string, MFEMMJNIGFA>, (DAMMDADGLAC, DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>>)> KNCINIFAGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8127FE0", Offset = "0x81269E0", VA = "0x188127FE0")]
	private bool IMFNGJPHGDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8128440", Offset = "0x8126E40", VA = "0x188128440")]
	private DAMMDADGLAC JEFKCGILIOI(bool KBONCIJCCCC, List<LOGBNBAILEJ> ENOFCODHFIA, int[] CIJIIIPLHCD, Func<int, MILNCMCHGEA> PPAEHMMNMMG, bool DOOHBPMMGBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81260C0", Offset = "0x8124AC0", VA = "0x1881260C0")]
	[IteratorStateMachine(typeof(GMIBNEMMDDB))]
	private IEnumerator<BHOPOIJKEJE> GHHLCJOHEHL(bool KBONCIJCCCC, List<LOGBNBAILEJ> ENOFCODHFIA, int[] CIJIIIPLHCD, Func<int, MILNCMCHGEA> PPAEHMMNMMG, CHCHOGCNLGF KBLHKCKFEMA, Material KDMOOJPGHNH, List<DAMMDADGLAC> APCPDELBHPG, bool DDONLPJNDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8123DE0", Offset = "0x81227E0", VA = "0x188123DE0")]
	private void DHMNAFAAPGM(List<LOGBNBAILEJ> ENOFCODHFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81251C0", Offset = "0x8123BC0", VA = "0x1881251C0")]
	private DAMMDADGLAC EHIAKNCDKJB(List<LOGBNBAILEJ> ENOFCODHFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x812BB80", Offset = "0x812A580", VA = "0x18812BB80")]
	private NNFEFJFFOPD LFKPODMOKFN(List<LOGBNBAILEJ> ENOFCODHFIA, int JLNNLJBBHIC, bool KBONCIJCCCC, MILNCMCHGEA FJOENFKFEOK, bool DBDDNKBCJKA, CHCHOGCNLGF KBLHKCKFEMA, Material KDMOOJPGHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8124E90", Offset = "0x8123890", VA = "0x188124E90", Slot = "27")]
	public void EGCAABNGKDE(CIDNHECLAKJ BNODGLHLEAK, float PDKJBMPOMNC, bool NGGIPNGCELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8127880", Offset = "0x8126280", VA = "0x188127880", Slot = "29")]
	public void HOMIMBIJDEJ(OEBHGMLHFGG GCKJJJCNODJ, float PDKJBMPOMNC, bool FLOPBBKIOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8124460", Offset = "0x8122E60", VA = "0x188124460", Slot = "30")]
	public void DPBHMKNHIEE(BDONOFFGMKE IIDIBBIIPPI, float PDKJBMPOMNC, bool GFHOGDHFGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x812E1E0", Offset = "0x812CBE0", VA = "0x18812E1E0", Slot = "28")]
	public void MPLEBHMKBEM(bool JDLEJHLGIPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8122090", Offset = "0x8120A90", VA = "0x188122090", Slot = "31")]
	public void ALPPAIIAMFF(bool JDLEJHLGIPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x812CE40", Offset = "0x812B840", VA = "0x18812CE40", Slot = "32")]
	public void LFPBNAOKOHF(bool JDLEJHLGIPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x812CEA0", Offset = "0x812B8A0", VA = "0x18812CEA0")]
	private void LGFNEPILDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x812E160", Offset = "0x812CB60", VA = "0x18812E160")]
	private void MLHKIBJHIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x812DFC0", Offset = "0x812C9C0", VA = "0x18812DFC0")]
	private void MHFDCNKOMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x812E480", Offset = "0x812CE80", VA = "0x18812E480", Slot = "25")]
	public void OHLCOEHAAEE(AvatarFaceShape FHLDPPBLEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x812B960", Offset = "0x812A360", VA = "0x18812B960", Slot = "26")]
	public void KKCMBLHKPHN(AvatarBodyShape LIJMKAGCHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xBEC8A0", Offset = "0xBEB2A0", VA = "0x180BEC8A0", Slot = "33")]
	public void OHBKCEMHCDM(BALOCJGIMAO HLHJKHFOCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x812D510", Offset = "0x812BF10", VA = "0x18812D510", Slot = "35")]
	public void LLLIADJFNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81276B0", Offset = "0x81260B0", VA = "0x1881276B0", Slot = "40")]
	public void HHFEOCJFMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x812B530", Offset = "0x8129F30", VA = "0x18812B530", Slot = "34")]
	public void KIPPFIEHLOI(bool JCCKNALHEPE, bool HPMMENJOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x812B110", Offset = "0x8129B10", VA = "0x18812B110")]
	private void KDOHOABHNDO(SkinnedMeshRenderer DAIICEEMGMD, int JLNNLJBBHIC, Mesh HFCMFMCGELA, List<Material> KBGGAFIBJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x812E540", Offset = "0x812CF40", VA = "0x18812E540")]
	private static Material OMJBNDOEIBC(Dictionary<GCKGBKNGHNK, Material> OGGPCFGNEEP, Material LJNLHHFMOBG, DFPLNBIGNDB PHICLGPIFCF, OKMDDDEAMIA KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x812E370", Offset = "0x812CD70", VA = "0x18812E370")]
	private static DFPLNBIGNDB OCHNMDOBJGN(LOGBNBAILEJ MCGJOOBMIIH, int EKNAJDDGFFK)
	{
		return default(DFPLNBIGNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x812ACF0", Offset = "0x81296F0", VA = "0x18812ACF0")]
	private void JMKJEOAFHMA(int EHLCELNNEBG, Material POCHLMCAOAO, LOGBNBAILEJ MCGJOOBMIIH, [Out] Texture2D EHJNAGEEPBN, [Out] Vector4 JLJCHBGEHIO, [Out] Texture2D EHCJJKIENHJ, [Out] Texture2D LOFNHBMAAGC, [Out] Texture2D PEJLCHONCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81264A0", Offset = "0x8124EA0", VA = "0x1881264A0")]
	private void GOJFIHKPJKP(int EHLCELNNEBG, Material POCHLMCAOAO, LOGBNBAILEJ MCGJOOBMIIH, [Out] Color MIBPJAMPLAH, [Out] Color EDBPCEOJKMK, [Out] Color AKPPCGLCPCE, [Out] Color NHNKCIMEAFC, [Out] Color NNJFMBEJFFJ, [Out] Color EMKONIJNLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8128B10", Offset = "0x8127510", VA = "0x188128B10")]
	private bool JIOJDJABKCA(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8124410", Offset = "0x8122E10", VA = "0x188124410")]
	private static Material DMBIEHNBCCL(int EHLCELNNEBG, BMLKKHECINI MCGJOOBMIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81220F0", Offset = "0x8120AF0", VA = "0x1881220F0")]
	private static OKMDDDEAMIA ANKDLEOCNMA(LOGBNBAILEJ MCGJOOBMIIH, int EKNAJDDGFFK)
	{
		return default(OKMDDDEAMIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8123950", Offset = "0x8122350", VA = "0x188123950")]
	private static void DFNOJJPENOH(Dictionary<string, List<GCKGBKNGHNK>> EKGECJENMCF, LOGBNBAILEJ EODNJOFAAPO, Material LJNLHHFMOBG, DFPLNBIGNDB FLINNIHPCCA, OKMDDDEAMIA OLKENKEHFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8125690", Offset = "0x8124090", VA = "0x188125690")]
	private static SkinnedMeshRenderer EKCBJOLDHED(Transform DJPFIGFALGM, Transform NFPKCPKNPCC, SkinnedMeshRenderer[] GKDMMPNJCBF, int JLNNLJBBHIC, MILNCMCHGEA FJOENFKFEOK, bool KBONCIJCCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x812EF40", Offset = "0x812D940", VA = "0x18812EF40")]
	public KAAAFBEDNIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8127B70", Offset = "0x8126570", VA = "0x188127B70")]
	public void ICNIAFDKEKI([In] PBOBCPJECCG MFPHCOHJPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x812D8F0", Offset = "0x812C2F0", VA = "0x18812D8F0")]
	public void LMMKDDGBABG([In] DOEKENMCOCA BJMDEEMCIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x81261E0", Offset = "0x8124BE0", VA = "0x1881261E0", Slot = "5")]
	public void KMBHNBDHLKM(int JLNNLJBBHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8124F70", Offset = "0x8123970", VA = "0x188124F70", Slot = "10")]
	public void EGHKGFNGDJO(KONMDFHOHBD OLKENKEHFAH, Texture2D GIAGKAKEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
	public static bool NNBPKGMPHMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x812B260", Offset = "0x8129C60", VA = "0x18812B260", Slot = "11")]
	public bool KIBGGNFODOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x812E840", Offset = "0x812D240", VA = "0x18812E840", Slot = "9")]
	public void PIMJNPCAIJD(AKLKKNEAKPM FLINNIHPCCA, Color? EDNHAEBPHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8127630", Offset = "0x8126030", VA = "0x188127630")]
	private void HFGGIKGPGPI(Action OHNNHLFOCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8124550", Offset = "0x8122F50", VA = "0x188124550", Slot = "6")]
	public void ECBBNPGFABO(MFEMMJNIGFA HIBMMEEDKDC, Texture HNCNCGACCAE, Color PADEGBIOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2649270", Offset = "0x2647C70", VA = "0x182649270", Slot = "7")]
	public void IBDHKDMKCBN(bool DDONLPJNDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1EFA510", Offset = "0x1EF8F10", VA = "0x181EFA510", Slot = "8")]
	public void BBGBOGAFDOK(NKOKBMFEAOJ HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8127960", Offset = "0x8126360", VA = "0x188127960", Slot = "16")]
	public void HPLJPCELHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8125FD0", Offset = "0x81249D0", VA = "0x188125FD0", Slot = "36")]
	public void FIHLPBJBFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x81221D0", Offset = "0x8120BD0", VA = "0x1881221D0", Slot = "37")]
	public void APLHAEMKKCP([Optional] JNPBPAOBAGK HOCLJJCDJMG, [Optional] bool? OHKPCEDLMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x81280B0", Offset = "0x8126AB0", VA = "0x1881280B0")]
	private bool JAEGGGOCGCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8123760", Offset = "0x8122160", VA = "0x188123760", Slot = "21")]
	public bool DAIDMOMNKND(EAIOHGIPLKL.BKMDKGNIEFL MPBKLKENAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x812BA20", Offset = "0x812A420", VA = "0x18812BA20", Slot = "38")]
	public void LCAPMILOMBA(float COKEMMOBIHO, Color EDNHAEBPHJD, bool KIMNIHKOKOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x812D970", Offset = "0x812C370", VA = "0x18812D970")]
	public void LOJKGLFFDEO(float COKEMMOBIHO, Color EDNHAEBPHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8123480", Offset = "0x8121E80", VA = "0x188123480")]
	private static bool CCFHBBEBHGL(Material KDMOOJPGHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x812DDD0", Offset = "0x812C7D0", VA = "0x18812DDD0", Slot = "39")]
	public void MBKCNNAJEFH(CNGNBIMOHPO HCHFOPEGKMB, MIENOMMKPFM OJBBGLBGOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x812E6A0", Offset = "0x812D0A0", VA = "0x18812E6A0")]
	private static bool PHNIHLLOBDH(GCKGBKNGHNK LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8125C20", Offset = "0x8124620", VA = "0x188125C20")]
	public void FEHDFBHDKDH(CNGNBIMOHPO PDJEKOLGOFN, MIENOMMKPFM ADALKINOANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x81231C0", Offset = "0x8121BC0", VA = "0x1881231C0")]
	private void BIEOEEMFHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x812B100", Offset = "0x8129B00", VA = "0x18812B100")]
	private void KCLMKJELNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8125AC0", Offset = "0x81244C0", VA = "0x188125AC0")]
	private static void FEFBCKMODGC(Dictionary<GCKGBKNGHNK, Material> OGGPCFGNEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x812D090", Offset = "0x812BA90", VA = "0x18812D090")]
	private static void LKNINDGEEJG(Dictionary<Renderer, CHCHOGCNLGF> PHBIAEJAEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8126AE0", Offset = "0x81254E0", VA = "0x188126AE0")]
	private void HBOLNKJGBLE(SkinnedMeshRenderer[] GKDMMPNJCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81258C0", Offset = "0x81242C0", VA = "0x1881258C0")]
	private void EMAANNBMJDJ(SkinnedMeshRenderer FHHDEFAFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8123C00", Offset = "0x8122600", VA = "0x188123C00")]
	private void DHAALHCEBKK(List<OMAHFCAPHPN> ACIGBHGAOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8126320", Offset = "0x8124D20", VA = "0x188126320")]
	private void GKAPACHIGDO(Dictionary<string, FDLGIOOGFEJ<Texture2D>> EKGECJENMCF, bool FOPOBAPEAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8123780", Offset = "0x8122180", VA = "0x188123780")]
	private void DEPGFFGEHNE(Dictionary<string, List<GCKGBKNGHNK>> EKGECJENMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8126960", Offset = "0x8125360", VA = "0x188126960")]
	private void HADGOLFGEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8125E40", Offset = "0x8124840", VA = "0x188125E40")]
	private void FEONDFABCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8126CE0", Offset = "0x81256E0", VA = "0x188126CE0")]
	private void HDLJABMHABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x812DD00", Offset = "0x812C700", VA = "0x18812DD00")]
	private void MBDFKNDAEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x812CF20", Offset = "0x812B920", VA = "0x18812CF20")]
	private void LGKODCJEMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x812B3E0", Offset = "0x8129DE0", VA = "0x18812B3E0")]
	private void KILMDPCEJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8127EE0", Offset = "0x81268E0", VA = "0x188127EE0")]
	private void IEPPDPDCLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x812E070", Offset = "0x812CA70", VA = "0x18812E070")]
	private void MKCHPEHEBFB(bool FBFDEIJMNMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x812DE60", Offset = "0x812C860", VA = "0x18812DE60")]
	private void MDHOHINBDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8121EF0", Offset = "0x81208F0", VA = "0x188121EF0")]
	private void ABOGONAFPJK(bool FBFDEIJMNMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x812D1F0", Offset = "0x812BBF0", VA = "0x18812D1F0")]
	private void LLEECBJMOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8124990", Offset = "0x8123390", VA = "0x188124990")]
	private void EFDKGOPBCLH(Material KDMOOJPGHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81237D0", Offset = "0x81221D0", VA = "0x1881237D0")]
	private void DFFBNCNMHIP(Material KDMOOJPGHNH, Color FGHOGCMNIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81281F0", Offset = "0x8126BF0", VA = "0x1881281F0")]
	private void JAHMHKAKGHO(Material KDMOOJPGHNH, Color FGHOGCMNIPN, Color KAMEJFMCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8128F10", Offset = "0x8127910", VA = "0x188128F10")]
	private void JKPJGCIHLEA(Material KDMOOJPGHNH, Color MIBPJAMPLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81254A0", Offset = "0x8123EA0", VA = "0x1881254A0")]
	private void EIDFCAOADMM(Material KDMOOJPGHNH, Texture2D GIAGKAKEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x812EC40", Offset = "0x812D640", VA = "0x18812EC40")]
	private void PKPBCGANNIA(Material KDMOOJPGHNH, Texture PNAAABBIKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8125960", Offset = "0x8124360", VA = "0x188125960")]
	private void FCLEIFFOKBB(Action<CHCHOGCNLGF> GAOKFNOLAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x812E6C0", Offset = "0x812D0C0", VA = "0x18812E6C0")]
	private void PILCPEAEBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x812B540", Offset = "0x8129F40", VA = "0x18812B540")]
	private void KKCEGMEPKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81245C0", Offset = "0x8122FC0", VA = "0x1881245C0")]
	private void EEGCDLAHAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81272A0", Offset = "0x8125CA0", VA = "0x1881272A0")]
	public void HEPOOCPACOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x812D8F0", Offset = "0x812C2F0", VA = "0x18812D8F0", Slot = "4")]
	private void NBOIHPLHJHM([In] DOEKENMCOCA BJMDEEMCIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8123710", Offset = "0x8122110", VA = "0x188123710")]
	[CompilerGenerated]
	private PNBAKNHPHGJ CMJICFAIBBG(LOGBNBAILEJ DJKLMOIIBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8125410", Offset = "0x8123E10", VA = "0x188125410")]
	[CompilerGenerated]
	private void EHIKDNDNABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8127FB0", Offset = "0x81269B0", VA = "0x188127FB0")]
	[CompilerGenerated]
	private void IJIJEPCKPIL(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8126030", Offset = "0x8124A30", VA = "0x188126030")]
	[CompilerGenerated]
	private void FKBJEMDLJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x812E350", Offset = "0x812CD50", VA = "0x18812E350")]
	[CompilerGenerated]
	private void NOJGDALMDAI(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8126290", Offset = "0x8124C90", VA = "0x188126290")]
	[CompilerGenerated]
	private void GJNNCFJHEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x812EDB0", Offset = "0x812D7B0", VA = "0x18812EDB0")]
	[CompilerGenerated]
	private void PKPNANNJNIF(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x812DF30", Offset = "0x812C930", VA = "0x18812DF30")]
	[CompilerGenerated]
	private void MFIDJODPKMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81236E0", Offset = "0x81220E0", VA = "0x1881236E0")]
	[CompilerGenerated]
	private void CJDLDBDJCGK(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8126200", Offset = "0x8124C00", VA = "0x188126200")]
	[CompilerGenerated]
	private void GJLKBLHLINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8125190", Offset = "0x8123B90", VA = "0x188125190")]
	[CompilerGenerated]
	private void EGIIDIDAMMC(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8121FD0", Offset = "0x81209D0", VA = "0x188121FD0")]
	[CompilerGenerated]
	private void ADJHGIJLFJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8126AB0", Offset = "0x81254B0", VA = "0x188126AB0")]
	[CompilerGenerated]
	private void HBJGNCCDCKJ(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8123650", Offset = "0x8122050", VA = "0x188123650")]
	[CompilerGenerated]
	private void CHJEEOEACPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8128EE0", Offset = "0x81278E0", VA = "0x188128EE0")]
	[CompilerGenerated]
	private void JIPGOKBDOPF(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8128A20", Offset = "0x8127420", VA = "0x188128A20")]
	[CompilerGenerated]
	private void JEIGJGLAPOF(KeyValuePair<string, FDLGIOOGFEJ<Texture2D>> MICOBNLMBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8127B60", Offset = "0x8126560", VA = "0x188127B60")]
	[CompilerGenerated]
	private void HPOMBGEHOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x812E040", Offset = "0x812CA40", VA = "0x18812E040")]
	[CompilerGenerated]
	private void MJBMHMNPCMF(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x812E150", Offset = "0x812CB50", VA = "0x18812E150")]
	[CompilerGenerated]
	private void MKMOBICFCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x812ACC0", Offset = "0x81296C0", VA = "0x18812ACC0")]
	[CompilerGenerated]
	private void JLIHDEKIFMF(CHCHOGCNLGF HFGPHHEBAGL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, LBPAJMNCKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
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
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3? DBPEKABDMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool BAMKOHHIAAK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81340E0", Offset = "0x8132AE0", VA = "0x1881340E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8134710", Offset = "0x8133110", VA = "0x188134710", Slot = "4")]
		public void UpdateController(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD71850", Offset = "0xD70250", VA = "0x180D71850", Slot = "6")]
		public void SetEnabled(bool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81341C0", Offset = "0x8132BC0", VA = "0x1881341C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8134B30", Offset = "0x8133530", VA = "0x188134B30")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, LBPAJMNCKBF
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private const float AHILPIAGIFI = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
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
		private Vector3 AHPMAIPJJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 JKBKAMGBCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool BAMKOHHIAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private float APNOMBNAFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private float NDNCPNPGGDE;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8134EB0", Offset = "0x81338B0", VA = "0x188134EB0", Slot = "4")]
		public void UpdateController(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xFE67A0", Offset = "0xFE51A0", VA = "0x180FE67A0", Slot = "6")]
		public void SetEnabled(bool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8134BD0", Offset = "0x81335D0", VA = "0x188134BD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8135970", Offset = "0x8134370", VA = "0x188135970")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LOGFLOJMGGF : ELPBBPMJKFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int ADBODAABJAF;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int OBJBKPFFMKH;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int FLEFMAPPDED;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int IDIOKPHMPJL;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int JPAECGKFJFB;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int JPOPFOKDEBL;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int EFCFMPJIJCO;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int CLGOFCCJNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int NPMMLKFEPEH;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int DDFOBIJFELL;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int OFFBACAHBBD;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int FDOAMJHFBFB;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int BHMIPCCMEEP;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int CKIMADGPJFA;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int GGMKEAADLOH;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int CAGPPGDFBID;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int JCOIBMMIGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Transform DBLHCANBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Transform AFDKFJKAEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Transform JMMNNMEDFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Transform OCFHNDGOAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Transform HAAFMIMPBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform FKLHHINHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private CMOBGFDCLNP LJNAGPJKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Material FIJPEDKDPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private SkinnedMeshRenderer[] GIAAPLNCFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly List<Material> BENGDILEKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private PFPLHGPNPBJ IBLOOABKMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HPDJJKCNBLF OJLIIFCNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private PFPLHGPNPBJ HCCIOPNHFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8147750", Offset = "0x8146150", VA = "0x188147750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8147510", Offset = "0x8145F10", VA = "0x188147510", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8147050", Offset = "0x8145A50", VA = "0x188147050")]
	public void ICNIAFDKEKI([In] CMOBGFDCLNP FLHCKPNLGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8146620", Offset = "0x8145020", VA = "0x188146620")]
	public void DJJNFOGEGNJ([In] BJKOGHIKEHB MEFGMENKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8146B20", Offset = "0x8145520", VA = "0x188146B20", Slot = "6")]
	public void FJNMAFBMOBE(FEKHNCLIOAJ EOKCFEPEKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8146A50", Offset = "0x8145450", VA = "0x188146A50")]
	private Vector2 DPHFBIDOEPH(Vector2 DEMKBDCIHDI)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8145720", Offset = "0x8144120", VA = "0x188145720")]
	public void AMCOOKLHDHB([In] DKCAACAJKPA MEFGMENKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8147140", Offset = "0x8145B40", VA = "0x188147140")]
	private void KMGEFOINJHH(GFNOBPOJPPE GMHLNNBDJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x81466C0", Offset = "0x81450C0", VA = "0x1881466C0")]
	private void DJLJKFPFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8146AB0", Offset = "0x81454B0", VA = "0x188146AB0")]
	private void MNDNPNJJACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8146AB0", Offset = "0x81454B0", VA = "0x188146AB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8147AF0", Offset = "0x81464F0", VA = "0x188147AF0")]
	public LOGFLOJMGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8146620", Offset = "0x8145020", VA = "0x188146620", Slot = "5")]
	private void MAKBIBJPBKE([In] BJKOGHIKEHB MEFGMENKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8146610", Offset = "0x8145010", VA = "0x188146610", Slot = "7")]
	private void BBMFGLEPNOC([In] DKCAACAJKPA MEFGMENKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x81477D0", Offset = "0x81461D0", VA = "0x1881477D0")]
	[CompilerGenerated]
	internal static float OCILIKNALNL(float PDKJBMPOMNC, float COPCMABMCKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8147660", Offset = "0x8146060", VA = "0x188147660")]
	[CompilerGenerated]
	internal static void MHFOHNCLNCN(Vector2 ACDENENFBLL, Vector2 MPKIOCCMLIN, Vector2 CGAAPEOHPIP, Vector2 OIMFMPLNJEN, Vector2 HJDOALAIPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8147100", Offset = "0x8145B00", VA = "0x188147100")]
	[CompilerGenerated]
	internal static Vector4 JGIGPDFDDMJ(Vector2 DDIHIBMHCDH, Vector2 DILGPPEHCGK)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, LBPAJMNCKBF
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
		private float APNOMBNAFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool BAMKOHHIAAK;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x81359A0", Offset = "0x81343A0", VA = "0x1881359A0", Slot = "4")]
		public void UpdateController(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x223A850", Offset = "0x2239250", VA = "0x18223A850", Slot = "6")]
		public void SetEnabled(bool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8136210", Offset = "0x8134C10", VA = "0x188136210")]
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

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8136240", Offset = "0x8134C40", VA = "0x188136240")]
		public void CEKLAJMLNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8136360", Offset = "0x8134D60", VA = "0x188136360")]
		public int PMCHPCEPDGC(int HADHNPCHHLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PJADJOAPGAD : JBNDMGCJPFE
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8148F10", Offset = "0x8147910", VA = "0x188148F10", Slot = "24")]
	public override float HBAAGPMLHDK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8148F60", Offset = "0x8147960", VA = "0x188148F60")]
	public PJADJOAPGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JBNDMGCJPFE : JPICLCPJPKE
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int FBBGLKBIMFK;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int JCMJJCMDAMF;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int FIPEJIAKBMD;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int OOGECHHMAAH;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int EBFGJPDEJCM;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int MNMEKLMFCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int PHBGKOFEINJ;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int[] NDCLEOECDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private DCIOKJIGPHM LJNAGPJKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private LJBPBPOGGDK IKCDJAJKFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private int MNEHFMDGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private float BIMJLDNLCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	protected Animator NNFGLNEEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	protected AvatarConfiguration FMHHIHPJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected int IJMCOCBBIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private int GHGHAOFBNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private int BBKKAAPIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool CKPCBEHMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private KJGMOLMOGDB CKGNAFOAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int PJCNKOCGHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private float LACEJEDPAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AvatarHandDisplaySettings ACBFCLNOAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private EAJLGMHEHMA EPPEMAOGOCO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ALIJBOFMNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 KJNOPCCMAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x194E220", Offset = "0x194CC20", VA = "0x18194E220")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x194E2A0", Offset = "0x194CCA0", VA = "0x18194E2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion BKBPMJPIFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE86AC0", Offset = "0xE854C0", VA = "0x180E86AC0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079970", VA = "0x18107AF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BHJEKCFFKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8143200", Offset = "0x8141C00", VA = "0x188143200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8143330", Offset = "0x8141D30", VA = "0x188143330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CNKEAAENHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAF41D0", Offset = "0xAF2BD0", VA = "0x180AF41D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 IMJNDNEJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB1D70", Offset = "0xAB0770", VA = "0x180AB1D70", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAB1DB0", Offset = "0xAB07B0", VA = "0x180AB1DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion HLPMBGJCLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x125C1B0", Offset = "0x125ABB0", VA = "0x18125C1B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x16D1A00", Offset = "0x16D0400", VA = "0x1816D1A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GCPPKJEFDIG LIMAMLHNMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB28950", Offset = "0xB27350", VA = "0x180B28950", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(GCPPKJEFDIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB28020", Offset = "0xB26A20", VA = "0x180B28020", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GCPPKJEFDIG GINMBJJCGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB28940", Offset = "0xB27340", VA = "0x180B28940", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(GCPPKJEFDIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB28810", Offset = "0xB27210", VA = "0x180B28810", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float NHAFKMDFPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBED670", Offset = "0xBEC070", VA = "0x180BED670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x108CB30", Offset = "0x108B530", VA = "0x18108CB30", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PKNFGGCFNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8143B70", Offset = "0x8142570", VA = "0x188143B70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8143B80", Offset = "0x8142580", VA = "0x188143B80", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CMFJAHMLEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x81431E0", Offset = "0x8141BE0", VA = "0x1881431E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HFONNMLMHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x81432F0", Offset = "0x8141CF0", VA = "0x1881432F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EMNJNIJADFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8143320", Offset = "0x8141D20", VA = "0x188143320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DBOMDAKKEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8143250", Offset = "0x8141C50", VA = "0x188143250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8143360", Offset = "0x8141D60", VA = "0x188143360", Slot = "23")]
	public void ICNIAFDKEKI(DCIOKJIGPHM FLHCKPNLGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8143720", Offset = "0x8142120", VA = "0x188143720")]
	public void LPPMLNCMAIK(LJBPBPOGGDK KJHEPIOHFBH, AvatarHandDisplaySettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8143260", Offset = "0x8141C60", VA = "0x188143260", Slot = "14")]
	public void CJOEDENOPBK(bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8143800", Offset = "0x8142200", VA = "0x188143800", Slot = "13")]
	public void NLAHMAEFEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xBED670", Offset = "0xBEC070", VA = "0x180BED670", Slot = "24")]
	public virtual float HBAAGPMLHDK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8143050", Offset = "0x8141A50", VA = "0x188143050")]
	private int ABJCOBFKIEA(GCPPKJEFDIG IHNNCNLLPCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8143560", Offset = "0x8141F60", VA = "0x188143560")]
	private void LNPBBGHFHLF(int MDFLDMJKGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8143230", Offset = "0x8141C30", VA = "0x188143230", Slot = "15")]
	public bool BBABLNEPKHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x81431F0", Offset = "0x8141BF0", VA = "0x1881431F0", Slot = "16")]
	public bool ADFNHGAMFFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x81437B0", Offset = "0x81421B0", VA = "0x1881437B0")]
	private GCPPKJEFDIG MACBNCGICNB()
	{
		return default(GCPPKJEFDIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1EC94D0", Offset = "0x1EC7ED0", VA = "0x181EC94D0", Slot = "17")]
	public void KFNFDEOIAAG(bool JKHDONCCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8143770", Offset = "0x8142170", VA = "0x188143770", Slot = "12")]
	public void MABODPLKKAJ(int MDFLDMJKGCH, float HCHNJAALHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8143300", Offset = "0x8141D00", VA = "0x188143300", Slot = "10")]
	public void DLIJHFEHLKM(KJGMOLMOGDB BLKFHFCBEDC, bool FJOBDLEAALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8143550", Offset = "0x8141F50", VA = "0x188143550", Slot = "11")]
	public void KAJIFIOMKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8143500", Offset = "0x8141F00", VA = "0x188143500", Slot = "18")]
	public void JFFKGDHNHBG(Transform DFKFFPKHNCH, Vector3 FBLBGOKMNEP, Quaternion DIDFFGNCHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8143E60", Offset = "0x8142860", VA = "0x188143E60")]
	public JBNDMGCJPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BMLKKHECINI : LOGBNBAILEJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FLAILEAPNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BMLKKHECINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<OMAHFCAPHPN> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public List<OMAHFCAPHPN> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public FDLGIOOGFEJ<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public FDLGIOOGFEJ<HBFEKGFKAOO> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FLAILEAPNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x813DF10", Offset = "0x813C910", VA = "0x18813DF10")]
		internal PNBAKNHPHGJ IBGKDOMPBDJ(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public MFEMMJNIGFA BHCPGBBGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public HBFEKGFKAOO CAPDPCODOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private FDLGIOOGFEJ<HBFEKGFKAOO> EHDKDKHINJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private FDLGIOOGFEJ<Material[]> EBLKLAFDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Material[] CKNPCJJMAHH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JNOKJJEGOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EAIOHGIPLKL.BKMDKGNIEFL LLFGACNCJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return default(EAIOHGIPLKL.BKMDKGNIEFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x81392C0", Offset = "0x8137CC0", VA = "0x1881392C0")]
	public BMLKKHECINI(BEBMGMBEIIO FMALOMLAKBD, MFEMMJNIGFA OOHOHDFMEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x81380C0", Offset = "0x8136AC0", VA = "0x1881380C0", Slot = "6")]
	public override PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8138F70", Offset = "0x8137970", VA = "0x188138F70")]
	public PNBAKNHPHGJ PBKAANABJLC(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED, FDLGIOOGFEJ<Material[]> EBLKLAFDBNG, [Optional] FDLGIOOGFEJ<HBFEKGFKAOO> EAGIEAEEMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8138870", Offset = "0x8137270", VA = "0x188138870")]
	public (FDLGIOOGFEJ<Material[]>, FDLGIOOGFEJ<HBFEKGFKAOO>) MMLFAPEEAIH(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
	{
		return default((FDLGIOOGFEJ<Material[]>, FDLGIOOGFEJ<HBFEKGFKAOO>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8137F90", Offset = "0x8136990", VA = "0x188137F90", Slot = "7")]
	public override PJKGGLEPKFJ ANIFFNDAPAH(uint JLNNLJBBHIC, AvatarSkinnedMeshBoneOrderRemapsData JBJNEHDPKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8138660", Offset = "0x8137060", VA = "0x188138660")]
	public PJKGGLEPKFJ JHOACJHLMNF(GameObject BHLJGCDGLLN, uint JLNNLJBBHIC, bool FANGOCONHBG, bool NLEOAJJNCLP, AvatarSkinnedMeshBoneOrderRemapsData JBJNEHDPKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8138C00", Offset = "0x8137600", VA = "0x188138C00")]
	public static bool OJEGCCHBDIJ(Renderer[] GKDMMPNJCBF, string EMBNHENMAMI, [Out] Renderer EMMHLDMCNCC, [Out] Renderer CDJEGHNAACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8139270", Offset = "0x8137C70", VA = "0x188139270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8138570", Offset = "0x8136F70", VA = "0x188138570")]
	private (FDLGIOOGFEJ<HBFEKGFKAOO>, FDLGIOOGFEJ<Material[]>) CNPMOAJJPBA()
	{
		return default((FDLGIOOGFEJ<HBFEKGFKAOO>, FDLGIOOGFEJ<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8138640", Offset = "0x8137040", VA = "0x188138640")]
	[CompilerGenerated]
	private void GPBECMMMMJC(HBFEKGFKAOO AEAMJGPOBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
	[CompilerGenerated]
	private void OGBCAIJGEPJ(Material[] AEAMJGPOBKI)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, LBPAJMNCKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
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
		private Vector3 AHPMAIPJJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Vector3 NHLDNKNJFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Vector3 JIBAJJDKOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Matrix4x4 BAHPCCIMFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private bool BAMKOHHIAAK;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8136840", Offset = "0x8135240", VA = "0x188136840", Slot = "4")]
		public void UpdateController(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8136830", Offset = "0x8135230", VA = "0x188136830", Slot = "6")]
		public void SetEnabled(bool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x81363D0", Offset = "0x8134DD0", VA = "0x1881363D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8136F00", Offset = "0x8135900", VA = "0x188136F00")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IHCCCAONNEJ]
public struct EPNJLBLNLPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[ReadOnly]
	public HMCFDEEIKGA LJMLKFNGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[ReadOnly]
	public int JDJOBCEOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public IMDBBAIHNMF CIBKBDJMBHK;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x813CF90", Offset = "0x813B990", VA = "0x18813CF90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IHCCCAONNEJ]
[NativeContainer]
public struct IMDBBAIHNMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector3> KJGONNPBABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> DOHGNCCONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector4> FKOFOBNBDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector2> GMNFDCENOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> PIEJMAALAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> HJILCAJBBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> NCOPPNLNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Color> HFPELNKCLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> CPFKODKIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> PNLFJAMKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> PLCBBGENKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> OEJGIPEKOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> KIDGNEBDGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> ABDDOIDCPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> JBAMPAHCLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<BoneWeight> CKJAMKAMPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<int> HKENEGGNMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private bool ABCPPNJCCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JMIMGNNKING
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8142B70", Offset = "0x8141570", VA = "0x188142B70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8142BD0", Offset = "0x81415D0", VA = "0x188142BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IJEPFCODIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81422E0", Offset = "0x8140CE0", VA = "0x1881422E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x81429C0", Offset = "0x81413C0", VA = "0x1881429C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KKHDGMOBAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8142BE0", Offset = "0x81415E0", VA = "0x188142BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8142250", Offset = "0x8140C50", VA = "0x188142250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8142BF0", Offset = "0x81415F0", VA = "0x188142BF0")]
	public IMDBBAIHNMF(int DNNLLCOBDHH, int IPIDELNGPDP, int HCMPNECOHIM, int BKENDDNDLCL, Allocator POJKLAFAMOD, int IHOKHPIJHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8142260", Offset = "0x8140C60", VA = "0x188142260")]
	public void BOJHFKPLGDD(int FILGHJLFKAL, Vector3 ELPCBPJLJEF, Vector3 AMLMOHAGJJA, Vector4 JCAFCJGCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x81429D0", Offset = "0x81413D0", VA = "0x1881429D0")]
	public void MOHGEDKNFEP(int FILGHJLFKAL, BoneWeight BOBPGPAAOLB, NativeSlice<byte> GKJGONNIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x81428D0", Offset = "0x81412D0", VA = "0x1881428D0")]
	public Color JKCCCIAPCAF(int FILGHJLFKAL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8142BB0", Offset = "0x81415B0", VA = "0x188142BB0")]
	public void NHMDJAGANPG(int FILGHJLFKAL, Color HFDMMDBJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8142880", Offset = "0x8141280", VA = "0x188142880")]
	public void JBFLLLOBJED(byte COECLOPKNPG, int FILGHJLFKAL, Vector2 JMKACMMOGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x81422D0", Offset = "0x8140CD0", VA = "0x1881422D0")]
	public void DKMOBIGDBFE(int FILGHJLFKAL, int IFAMLBGMMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8142B80", Offset = "0x8141580", VA = "0x188142B80")]
	public bool NGEKCEHFDIM(int COECLOPKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x81428F0", Offset = "0x81412F0", VA = "0x1881428F0")]
	public void LHEHFAOPKFF(int FBFMMNLCIEN, int KIOPHNHDMKE, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x81421A0", Offset = "0x8140BA0", VA = "0x1881421A0")]
	public int[] ALKFKDNPLEE(int FBFMMNLCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x81427F0", Offset = "0x81411F0", VA = "0x1881427F0")]
	private NativeSlice<int> IHKLKFBIINK(int FBFMMNLCIEN)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81422F0", Offset = "0x8140CF0", VA = "0x1881422F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x81424A0", Offset = "0x8140EA0", VA = "0x1881424A0")]
	public Mesh EMKBECPNPMA([Optional] string MPONCKBONFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[NativeContainer]
[DefaultMember("Item")]
[IHCCCAONNEJ]
public struct HMCFDEEIKGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<Vector3> KJGONNPBABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<Vector3> DOHGNCCONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<Vector4> FKOFOBNBDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<Vector2> GMNFDCENOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<Vector2> PIEJMAALAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector2> HJILCAJBBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector2> NCOPPNLNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Color> HFPELNKCLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<int> LKIEBBHONJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<int> AOHKAHOAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<int> JIGIBLBICGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<int> BFDJGNNLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<bool> OOBMHEOBKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<int> OIIGNCDIDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> IEPKICNHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<BoneWeight> FNONCOGGOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private NativeArray<Matrix4x4> PEHEDAMCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private NativeArray<long> JGBEBNBIOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private NativeArray<byte> FGFLPACPNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private NativeArray<int> NCEFOPCKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private NativeArray<int> MCPOLIBPNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeArray<sbyte> JNBAOKKKGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeArray<byte> MCABNODCAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<int> IJHEKEHAOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool ABCPPNJCCKJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NKOFPMBEGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xF1BB40", Offset = "0xF1A540", VA = "0x180F1BB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int ICOCENKBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xD743D0", Offset = "0xD72DD0", VA = "0x180D743D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int FDJJDLNIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8140230", Offset = "0x813EC30", VA = "0x188140230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int PEJMECJCBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x813FCB0", Offset = "0x813E6B0", VA = "0x18813FCB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x813FCE0", Offset = "0x813E6E0", VA = "0x18813FCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int JMIMGNNKING
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8140260", Offset = "0x813EC60", VA = "0x188140260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8140280", Offset = "0x813EC80", VA = "0x188140280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GLFPGBMCDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x813FCC0", Offset = "0x813E6C0", VA = "0x18813FCC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8140220", Offset = "0x813EC20", VA = "0x188140220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public FFOICIGPDAP HNGNHLGNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x813FCD0", Offset = "0x813E6D0", VA = "0x18813FCD0")]
		get
		{
			return default(FFOICIGPDAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8140270", Offset = "0x813EC70", VA = "0x188140270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte HDNAHKNCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8140290", Offset = "0x813EC90", VA = "0x188140290")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x813FA30", Offset = "0x813E430", VA = "0x18813FA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OENKFFKEKOD EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x813FCF0", Offset = "0x813E6F0", VA = "0x18813FCF0")]
		get
		{
			return default(OENKFFKEKOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8140370", Offset = "0x813ED70", VA = "0x188140370")]
	public HMCFDEEIKGA(IList<Mesh> AGHGFLKJGKM, IList<Matrix4x4> NDEHPICJKCB, IList<bool> OOBMHEOBKLP, byte PCNKGECIAEF, IList<byte[]> GJDIBDDOOCP, IList<long> OGGHEAOGFBE, IList<bool> OBOEBDPLPBE, IList<int> OIIGNCDIDBK, IList<int> JMOCHABNFND, IList<int> JLABENOIGLA, Allocator POJKLAFAMOD, FFOICIGPDAP NPEMINJBBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x81402A0", Offset = "0x813ECA0", VA = "0x1881402A0")]
	public IMDBBAIHNMF PKACPABLLDB(Allocator POJKLAFAMOD)
	{
		return default(IMDBBAIHNMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x813FA40", Offset = "0x813E440", VA = "0x18813FA40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IHCCCAONNEJ]
public class BONJCBNKBMI : PELKIMAOJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8139330", Offset = "0x8137D30", VA = "0x188139330")]
	public HMCFDEEIKGA NFCEAKLCJBC()
	{
		return default(HMCFDEEIKGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8121C30", Offset = "0x8120630", VA = "0x188121C30")]
	public BONJCBNKBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OENKFFKEKOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<Vector3> KJGONNPBABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<Vector3> DOHGNCCONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<Vector4> FKOFOBNBDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeSlice<Vector2> GMNFDCENOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<Vector2> PIEJMAALAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector2> HJILCAJBBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector2> NCOPPNLNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Color> HFPELNKCLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<int> HPOGGBJGEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<int> BFDJGNNLJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<BoneWeight> FNONCOGGOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<byte> LEGLNKAKLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public int JOGNOEGGOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public Matrix4x4 HBNEEFJKGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public long PNGNADEGJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeSlice<byte> GKJGONNIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public bool HDHBEMALEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public int COKCFIFLNDN;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct GCKGBKNGHNK : IEquatable<GCKGBKNGHNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal readonly Material ADBOMPMBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal readonly DFPLNBIGNDB KNDOCFLOENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal readonly OKMDDDEAMIA AOJPHHFGJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	internal readonly BEBMGMBEIIO IALOGONDFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	internal readonly bool FIAGHDAACKO;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x813E700", Offset = "0x813D100", VA = "0x18813E700")]
	public GCKGBKNGHNK(Material POCHLMCAOAO, DFPLNBIGNDB PHICLGPIFCF, OKMDDDEAMIA KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x813E460", Offset = "0x813CE60", VA = "0x18813E460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x813E1C0", Offset = "0x813CBC0", VA = "0x18813E1C0", Slot = "4")]
	public bool Equals(GCKGBKNGHNK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x813E250", Offset = "0x813CC50", VA = "0x18813E250", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x813E350", Offset = "0x813CD50", VA = "0x18813E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, LAKPIFGCJOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[Header("Configuration")]
		[SerializeField]
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
		private EAJLGMHEHMA avatarBodyType;

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
		[Header("Arm Animation Controllers")]
		[SerializeField]
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
		private POODIKIDKFI DILJMENJHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private ELPBBPMJKFF EMNOBGHLNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private JPICLCPJPKE ODNJPJMHLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private JPICLCPJPKE IPBCHDGFNFK;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public POODIKIDKFI DHKBOAJFJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x8137E30", Offset = "0x8136830", VA = "0x188137E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ELPBBPMJKFF JPJEDPDEHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8137E80", Offset = "0x8136880", VA = "0x188137E80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public JPICLCPJPKE GBCMOACOJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8137ED0", Offset = "0x81368D0", VA = "0x188137ED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JPICLCPJPKE IEHADJDEGAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8137F20", Offset = "0x8136920", VA = "0x188137F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform HPEFFMPFLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8137F70", Offset = "0x8136970", VA = "0x188137F70", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public EAJLGMHEHMA NLLMOMBLFHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA938E0", Offset = "0xA922E0", VA = "0x180A938E0", Slot = "12")]
			get
			{
				return default(EAJLGMHEHMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8136F10", Offset = "0x8135910", VA = "0x188136F10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8137C90", Offset = "0x8136690", VA = "0x188137C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x81375A0", Offset = "0x8135FA0", VA = "0x1881375A0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8137C90", Offset = "0x8136690", VA = "0x188137C90", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x81371E0", Offset = "0x8135BE0", VA = "0x1881371E0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8137D40", Offset = "0x8136740", VA = "0x188137D40")]
		public void UpdatePostIKAnimControllers(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8137510", Offset = "0x8135F10", VA = "0x188137510")]
		private void DCIKIOAELBN(GameObject CEFJEHJNIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x81375E0", Offset = "0x8135FE0", VA = "0x1881375E0")]
		private POODIKIDKFI JGDCHIAPMCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8137950", Offset = "0x8136350", VA = "0x188137950")]
		private ELPBBPMJKFF LOHGNEILCIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8136F50", Offset = "0x8135950", VA = "0x188136F50")]
		private JPICLCPJPKE CJELPNCPCLB(PGJJMMOJPKN JMHLIIFGJJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8137E20", Offset = "0x8136820", VA = "0x188137E20")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CHCHOGCNLGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private MaterialPropertyBlock ONJLEAPMJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Color? KOBKFBOKCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Color? JDHCFDLCJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Color? NHAPCOAKACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Color? MBGEAALEMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Color MDFEMNJMGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Color CAKOHGGLPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Color ABEPKKJIEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float OLJGBDBNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2D EMPKJGMKMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2D LLLKOEOBBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Dictionary<GCKGBKNGHNK, int> MNAPONIFNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private DFPLNBIGNDB[] DPBICPLMCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private OKMDDDEAMIA[] EMPGDLJFELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Vector4[] ALOJNFJJGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Vector4[] IPCEJMJMLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Vector4[] JIOCAJDGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Vector4[] PLIOIJEEEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Vector4[] JIBHOCIAEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Vector4[] KGKEGFBFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private List<Texture2D> JMKNFHGLHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector4[] NPKMEFNDLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private List<Texture2D> GEKIBBCHDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private float[] DJFDDFMCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector4[] LBBDJJBFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private float[] LKNKDAHHMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public float[] LOHAFOMAFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private List<Texture2D> LNMELGCLEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private float[] KPBEKLIABCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private List<Texture2D> PBGDDHLPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector4[] FNPHKKEHMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private float[] MHPIKAKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector4[] DNOLGEMPHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public float[] BCHEPFCNCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Texture2DArray NGBMPNIINOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public Texture2DArray BDMNCPPDCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Texture2DArray JMNLHLMLOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Texture2DArray BPLGCEFFMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool GDKMGJOJJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private int OGGIFGLNJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private Vector2? BJNPCFJPEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private TextureFormat FLEDKMPPPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector2? GGJCCGDJKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private TextureFormat FAPEBLADPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Vector2? GKDKONJAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private TextureFormat IDGNAJJDHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Vector2? JFIFADIKIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private TextureFormat MGPPODFJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private bool JNAAJFKIBLB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int FFJCIALABBA;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int EKIIKLEOABH;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int LKJIBKNFCGE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int PLADPJDAJPG;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int JHLPNECFMLA;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int FBAKKMFEEAN;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int OGPILONJNOP;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int PPPJCIKDMCI;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int DOGNEHODABF;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int DMJNKOPAHPN;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int OPCCEFDIOLB;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int NMAAONNHBOI;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int LHOGHEONOOI;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int JNHFGJMMCMM;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int PCOEMDAINLI;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int NLCHKEBEDLG;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int NCLBJCPMLCJ;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int EKLHCMPAOEF;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int PEKCKMKLDAJ;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int BCIJBJJLDIF;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x813BB40", Offset = "0x813A540", VA = "0x18813BB40")]
	private CHCHOGCNLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x813BA80", Offset = "0x813A480", VA = "0x18813BA80")]
	public CHCHOGCNLGF(Color IEJOMNEKCHG, Color KIIPMICBDCC, Color BPBELJIDHLC, Color? LFCPLBKFNIG, Color? NBDIBOJDOOB, Color? IMAMFBCPBGL, Texture2D AKNKEEKGFII, Texture2D OCJHAOEPDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x813A3A0", Offset = "0x8138DA0", VA = "0x18813A3A0")]
	internal int DCNNIEPOFEK(Material DJBFPCKMDLE, DFPLNBIGNDB PHICLGPIFCF, OKMDDDEAMIA KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x813A310", Offset = "0x8138D10", VA = "0x18813A310")]
	private int DCNNIEPOFEK(GCKGBKNGHNK LNBCHJPEENA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x813A4B0", Offset = "0x8138EB0", VA = "0x18813A4B0")]
	internal int HIDECOEMJKB(Material DJBFPCKMDLE, Color MIBPJAMPLAH, Color EDBPCEOJKMK, Color AKPPCGLCPCE, Color NHNKCIMEAFC, Color NNJFMBEJFFJ, Texture2D HHDANPKFGOL, Vector4 IIPECCJLOFD, Texture2D BPPALADCHFD, Vector4 BKHMMDFBLEC, float NCGCMMNMHKO, float FDFPLGCAACO, Texture2D MGDDENOENGN, Vector4 JHAPIAHNFOI, float KOMGDMBLDIL, Texture2D IJMLFJDFONJ, Color EMKONIJNLBD, Vector4 AFOGCNEFBDH, DFPLNBIGNDB PHICLGPIFCF, OKMDDDEAMIA KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x813B330", Offset = "0x8139D30", VA = "0x18813B330")]
	private void NFKFFKPJGGG(List<Texture2D> JMKNFHGLHMN, [Out] Texture2DArray GPAFGKANDPG, [Out] Texture2DArray ELPCENKLENM, [Out] Texture2DArray IAELLFPDKEL, [Out] Texture2DArray MLMJOBINFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8139420", Offset = "0x8137E20", VA = "0x188139420")]
	public void AILPPPNKPPC(Shader DJKKEKFHDEI, Renderer BDBIAPPPJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8139620", Offset = "0x8138020", VA = "0x188139620")]
	private void CMBHFAKNLIL(Shader DJKKEKFHDEI, Renderer BDBIAPPPJPF, int DIJECNJBHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x813B4F0", Offset = "0x8139EF0", VA = "0x18813B4F0")]
	private Color PCKHJCOIFAB(Color IOJPOJCIHJG, DFPLNBIGNDB FLINNIHPCCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x813B080", Offset = "0x8139A80", VA = "0x18813B080")]
	private Color IHIAHJGHNIN(Color NIHIGICOEIN, DFPLNBIGNDB FLINNIHPCCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x813B1D0", Offset = "0x8139BD0", VA = "0x18813B1D0")]
	private bool KGDNJKPKMBO(Texture2D LBHMHFLGBHL, OKMDDDEAMIA OLKENKEHFAH, [Out] Texture2D LNEIGNFADLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8139570", Offset = "0x8137F70", VA = "0x188139570")]
	private void BDBDECFHGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x813A470", Offset = "0x8138E70", VA = "0x18813A470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LOGBNBAILEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public readonly BEBMGMBEIIO LNHNPADMGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	protected bool HPLMHMMBFJL;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool DPJLEAJLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB50B50", Offset = "0xB4F550", VA = "0x180B50B50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DBBHIEPLBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB50B30", Offset = "0xB4F530", VA = "0x180B50B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB50B40", Offset = "0xB4F540", VA = "0x180B50B40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual EAIOHGIPLKL.BKMDKGNIEFL PNGNADEGJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EAIOHGIPLKL.BKMDKGNIEFL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xDD00C0", Offset = "0xDCEAC0", VA = "0x180DD00C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool PNDINJLDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1550C40", Offset = "0x154F640", VA = "0x181550C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool DAFCCLKPABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x81456C0", Offset = "0x81440C0", VA = "0x1881456C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool GBGFKPDEBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x81456B0", Offset = "0x81440B0", VA = "0x1881456B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool MMMIKKJBPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x81456D0", Offset = "0x81440D0", VA = "0x1881456D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x81456F0", Offset = "0x81440F0", VA = "0x1881456F0")]
	protected LOGBNBAILEJ(BEBMGMBEIIO FMALOMLAKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract PJKGGLEPKFJ ANIFFNDAPAH(uint JLNNLJBBHIC, AvatarSkinnedMeshBoneOrderRemapsData JBJNEHDPKFF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GIMOHDLKMMD : KDGAONFOMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private AvatarSkinAssetItem NGAILDLBIJL;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x813EAB0", Offset = "0x813D4B0", VA = "0x18813EAB0")]
	public GIMOHDLKMMD(AvatarSkinAssetItem JOLJMFLMOFK, AvatarSkinAssetItem.DBFEJCMKAOG BBOEFLOEGFM, BEBMGMBEIIO HMKMCCAOOLE, [Optional] ALMOMBBBFFN? CJIJCCDDOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x813E840", Offset = "0x813D240", VA = "0x18813E840", Slot = "6")]
	public override PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HPBMDMPAIIF
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private static readonly int[] AGJNNLCFBPN;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static readonly int[] AHHAHMLCPNE;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] JFAMNPAJKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8141D50", Offset = "0x8140750", VA = "0x188141D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8141CC0", Offset = "0x81406C0", VA = "0x188141CC0")]
	public static int[] JJLGEICEGFM(bool OIGBNMEIOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8141C10", Offset = "0x8140610", VA = "0x188141C10")]
	public static int CEIFJNAAMGP(CNMJFAPGOOG MIILNOPAGIM, bool OIGBNMEIOIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8141DA0", Offset = "0x81407A0", VA = "0x188141DA0")]
	private static int NPCPHJNOFPH(CNMJFAPGOOG MIILNOPAGIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8141CA0", Offset = "0x81406A0", VA = "0x188141CA0")]
	private static int FANDICFJAFM(CNMJFAPGOOG MIILNOPAGIM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DHAGPDHFEPO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AEGIPFKOPPF : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public AEGIPFKOPPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x14ABFA0", Offset = "0x14AA9A0", VA = "0x1814ABFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8133E90", Offset = "0x8132890", VA = "0x188133E90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public static void CBIJJIIOMBM(string EGJGKBPPPFG, int JLNNLJBBHIC, long LLPODGJNJJG, long GHECLOFIMOE, long AAPPMGBAKIP, long KJGHAFBOEDK, long LGBJBMDAABJ, long NHELGEDGHGI, long AJGDKMGKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x813C040", Offset = "0x813AA40", VA = "0x18813C040")]
	public static NNFEFJFFOPD DLKNHMMOKHM(JobHandle HHLHJHLGGCP, bool AHMAOIGBKIM, bool LNMFALGDCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x813C130", Offset = "0x813AB30", VA = "0x18813C130")]
	[IteratorStateMachine(typeof(AEGIPFKOPPF))]
	private static IEnumerator<BHOPOIJKEJE> PIGHEMJKPAI(JobHandle OFBHFOIEGGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ECEPKDAMEOC
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum NDDBJDNKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int HNEDGBCMMFG;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int CEKJLAJLGGP;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly int JNPEDAJOKEN;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly int BLOOBNPOGHE;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly int MACIKEPDHIF;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly int DMENJPIIKNC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly int GPNGIBGDPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly int LLBNHDMLCDD;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly int CAOHGLOMLME;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly int FFGOGFGPNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int IOBONAEMAJL;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int IKOFPBDONCD;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x813C710", Offset = "0x813B110", VA = "0x18813C710")]
	public static bool LPBMLGDCJEB(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x813C780", Offset = "0x813B180", VA = "0x18813C780")]
	public static bool PLMMEJLKGHG(Material POCHLMCAOAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KDGAONFOMKB : LOGBNBAILEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class ELDMBFHKHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public FDLGIOOGFEJ<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public KDGAONFOMKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ELDMBFHKHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x813CA70", Offset = "0x813B470", VA = "0x18813CA70")]
		internal void CEGLDALKLFB(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x813CE50", Offset = "0x813B850", VA = "0x18813CE50")]
		internal void IBGKDOMPBDJ(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	protected AvatarSkinAssetItem FGKJAKOLNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	protected Material[] KHIKAHNLJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly AvatarSkinAssetItem.DBFEJCMKAOG NHCFHLFJMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly AssetReference BKCPNJPGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly ALMOMBBBFFN? OHPKHJJBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private SkinnedMeshRenderer[] DDKLJEGHCGN;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override EAIOHGIPLKL.BKMDKGNIEFL PNGNADEGJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EAIOHGIPLKL.BKMDKGNIEFL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA882F0", Offset = "0xA86CF0", VA = "0x180A882F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8144FD0", Offset = "0x81439D0", VA = "0x188144FD0")]
	public KDGAONFOMKB(AvatarSkinAssetItem.DBFEJCMKAOG BBOEFLOEGFM, AssetReference JJHGCOAMFAP, Material BMDJIKNHOIO, BEBMGMBEIIO HMKMCCAOOLE, EAIOHGIPLKL.BKMDKGNIEFL PAEKCGDBCGM = (EAIOHGIPLKL.BKMDKGNIEFL)0L, [Optional] ALMOMBBBFFN? CJIJCCDDOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8144EB0", Offset = "0x81438B0", VA = "0x188144EB0")]
	public KDGAONFOMKB(AvatarSkinAssetItem.DBFEJCMKAOG BBOEFLOEGFM, AssetReference JJHGCOAMFAP, Material BMDJIKNHOIO, EAIOHGIPLKL.BKMDKGNIEFL PAEKCGDBCGM = (EAIOHGIPLKL.BKMDKGNIEFL)0L, [Optional] ALMOMBBBFFN? CJIJCCDDOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8144C20", Offset = "0x8143620", VA = "0x188144C20", Slot = "6")]
	public override PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8144A10", Offset = "0x8143410", VA = "0x188144A10", Slot = "7")]
	public override PJKGGLEPKFJ ANIFFNDAPAH(uint JLNNLJBBHIC, AvatarSkinnedMeshBoneOrderRemapsData JBJNEHDPKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8144E40", Offset = "0x8143840", VA = "0x188144E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8144DF0", Offset = "0x81437F0", VA = "0x188144DF0")]
	protected void CJLCBOBBFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MNDFAHIBFIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private List<int> ELFJFHGGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private List<NPCPPEBDNKP> LFIEFKKGDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HashSet<Transform> KODCBFHFHAA;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x81484D0", Offset = "0x8146ED0", VA = "0x1881484D0")]
	public static MNDFAHIBFIB PHANMPCLMOA(Transform JCAFCJGCHAJ, Dictionary<Transform, OutfitType?> IENBDKECDDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x81481B0", Offset = "0x8146BB0", VA = "0x1881481B0")]
	private void NFPAGBKGKFM(Transform JCAFCJGCHAJ, BEBMGMBEIIO HMKMCCAOOLE, Dictionary<Transform, OutfitType?> IENBDKECDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8148020", Offset = "0x8146A20", VA = "0x188148020")]
	private void GOLMLKCFFJH(Transform JLFHELDPFBL, BEBMGMBEIIO HMKMCCAOOLE, bool IOICCNCJIKO, OutfitType? KMKIDDBNOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8147C30", Offset = "0x8146630", VA = "0x188147C30")]
	public GKMADNIGGJI CICOPJMNMFA(HashSet<string> FFKEFJEPHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8148660", Offset = "0x8147060", VA = "0x188148660")]
	public MNDFAHIBFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GKMADNIGGJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private List<NPCPPEBDNKP> LFIEFKKGDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private List<Matrix4x4> MLAAEIFKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Transform[] OFIBECIPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private Matrix4x4[] OOFJHHPGFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private Dictionary<OBBBBAPAAKF, int> OEBMLPONOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private List<IJONKGOFMMJ> LHPMJHPLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool NOEKDFCOJME;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x813F5A0", Offset = "0x813DFA0", VA = "0x18813F5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] JNKHFPFJKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x813EBB0", Offset = "0x813D5B0", VA = "0x18813EBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] MNHHBIMFOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x813F530", Offset = "0x813DF30", VA = "0x18813F530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x813F180", Offset = "0x813DB80", VA = "0x18813F180")]
	public void GOLMLKCFFJH(Transform JLFHELDPFBL, BEBMGMBEIIO HMKMCCAOOLE, OutfitType? KMKIDDBNOML, bool BCIJDGGEBJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x813EE10", Offset = "0x813D810", VA = "0x18813EE10")]
	private void GOLMLKCFFJH(Transform JLFHELDPFBL, BEBMGMBEIIO HMKMCCAOOLE, OutfitType? KMKIDDBNOML, bool BCIJDGGEBJN, Matrix4x4 PAAFFABBPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x813F380", Offset = "0x813DD80", VA = "0x18813F380")]
	public int HCLLDKHJMMA(OBBBBAPAAKF LNBCHJPEENA, bool GAPIEBLNDJA, [Optional] OutfitType? KMKIDDBNOML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x813F730", Offset = "0x813E130", VA = "0x18813F730")]
	public int NDGEANMFLDD(BEBMGMBEIIO HMKMCCAOOLE, [Optional] OutfitType? KMKIDDBNOML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x813ED20", Offset = "0x813D720", VA = "0x18813ED20")]
	public void GJOGNLCCADH(OBBBBAPAAKF LNBCHJPEENA, Matrix4x4 CJFEGBIIHKA, bool GAPIEBLNDJA = false, [Optional] OutfitType? KMKIDDBNOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x813F5E0", Offset = "0x813DFE0", VA = "0x18813F5E0")]
	public Matrix4x4 JDNPKPEHCGL(OBBBBAPAAKF LNBCHJPEENA, bool GAPIEBLNDJA, [Optional] OutfitType? KMKIDDBNOML)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1215A40", Offset = "0x1214440", VA = "0x181215A40")]
	public void FKEMPCNDOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x813F830", Offset = "0x813E230", VA = "0x18813F830")]
	public GKMADNIGGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct OBBBBAPAAKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public readonly string ENLABPNGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly BEBMGMBEIIO IALOGONDFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public readonly OutfitType? PANFNJGJEFA;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8148ED0", Offset = "0x81478D0", VA = "0x188148ED0")]
	public OBBBBAPAAKF(string JEGEMHIKDMI, BEBMGMBEIIO HMKMCCAOOLE, [Optional] OutfitType? KMKIDDBNOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8148E20", Offset = "0x8147820", VA = "0x188148E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8148CF0", Offset = "0x81476F0", VA = "0x188148CF0")]
	public bool FMOEJGBHBPC(OBBBBAPAAKF EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8148C50", Offset = "0x8147650", VA = "0x188148C50", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8148DB0", Offset = "0x81477B0", VA = "0x188148DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct IJONKGOFMMJ : IEquatable<IJONKGOFMMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public readonly BEBMGMBEIIO IALOGONDFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly OutfitType? EJNEJFABLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly int ECGFABPOAPP;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8142190", Offset = "0x8140B90", VA = "0x188142190")]
	public IJONKGOFMMJ(BEBMGMBEIIO HMKMCCAOOLE, int AJIHDMIJCME, [Optional] OutfitType? EBMFAHKPNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x81420C0", Offset = "0x8140AC0", VA = "0x1881420C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x731A330", Offset = "0x7318D30", VA = "0x18731A330")]
	public bool DELCCIBACGA(BEBMGMBEIIO HMKMCCAOOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8141FF0", Offset = "0x81409F0", VA = "0x188141FF0")]
	public bool FGLJDJHLEMJ(OutfitType? EBMFAHKPNLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8141EB0", Offset = "0x81408B0", VA = "0x188141EB0", Slot = "4")]
	public bool Equals(IJONKGOFMMJ EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8141F00", Offset = "0x8140900", VA = "0x188141F00", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8142070", Offset = "0x8140A70", VA = "0x188142070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct NPCPPEBDNKP : IEquatable<NPCPPEBDNKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly Transform POGMNONHMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public readonly bool FLIAMOCDFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly BEBMGMBEIIO PEMHHEPAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public readonly OutfitType? PANFNJGJEFA;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8148C00", Offset = "0x8147600", VA = "0x188148C00")]
	public NPCPPEBDNKP(Transform JLFHELDPFBL, bool IOICCNCJIKO, BEBMGMBEIIO LCECEPGGGOH, [Optional] OutfitType? FKOMLHBLBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x81489F0", Offset = "0x81473F0", VA = "0x1881489F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8148790", Offset = "0x8147190", VA = "0x188148790", Slot = "4")]
	public bool Equals(NPCPPEBDNKP EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8148890", Offset = "0x8147290", VA = "0x188148890", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8148970", Offset = "0x8147370", VA = "0x188148970", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x813E150", Offset = "0x813CB50", VA = "0x18813E150")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface JIAOPHGAFFH
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEPHJBHIIDF(Mesh HFCMFMCGELA, Matrix4x4 FAJKMJNBNAD, byte[] GKJGONNIFAP, bool KKIFBMMOHPF = false, EAIOHGIPLKL.BKMDKGNIEFL OJIPFBNOEHM = (EAIOHGIPLKL.BKMDKGNIEFL)0L, int OIIGNCDIDBK = -1, bool OOBMHEOBKLP = false);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOJIMFACMBK(Allocator POJKLAFAMOD, FFOICIGPDAP NPEMINJBBFN, byte PCNKGECIAEF, [Optional] IList<int> JMOCHABNFND, [Optional] IList<int> DMBIDKOHAAA);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct HBFEKGFKAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public readonly GameObject BHLJGCDGLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private readonly AvatarItemMaterial DBLGCJEFEBE;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	public HBFEKGFKAOO(GameObject BHLJGCDGLLN, AvatarItemMaterial DBLGCJEFEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x813F9A0", Offset = "0x813E3A0", VA = "0x18813F9A0")]
	public void INPGGJAIOKO(Material POCHLMCAOAO, int EHLCELNNEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KCDALBKCANC : BMPHKDMPHIM<Task<(GameObject, AvatarItemMaterial)>, HBFEKGFKAOO>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DPCPMFJEPPP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x813C1A0", Offset = "0x813ABA0", VA = "0x18813C1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x813C6A0", Offset = "0x813B0A0", VA = "0x18813C6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FDLGIOOGFEJ<GameObject> DBADGHAJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private FDLGIOOGFEJ<AvatarItemMaterial> BHADCLJIALP;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x81444E0", Offset = "0x8142EE0", VA = "0x1881444E0")]
	private KCDALBKCANC(Task<(GameObject, AvatarItemMaterial)> AIPCFMDLKCK, FDLGIOOGFEJ<GameObject> GHDKNDMNGGB, FDLGIOOGFEJ<AvatarItemMaterial> DNFJLPGDAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x81440D0", Offset = "0x8142AD0", VA = "0x1881440D0")]
	public static KCDALBKCANC OIDBKGGJJLH(AssetReference DJBNBMOIILJ, [Optional] AssetReference KDJCNODKLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8143E80", Offset = "0x8142880", VA = "0x188143E80", Slot = "11")]
	protected override HBFEKGFKAOO DMPOLIDGOED(Task<(GameObject, AvatarItemMaterial)> NMFOLLODJFD)
	{
		return default(HBFEKGFKAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8144050", Offset = "0x8142A50", VA = "0x188144050", Slot = "12")]
	protected override void IGPGEBAEPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8143F20", Offset = "0x8142920", VA = "0x188143F20")]
	[AsyncStateMachine(typeof(DPCPMFJEPPP))]
	private static Task<(GameObject, AvatarItemMaterial)> ECGDMONNMEG(Task<GameObject> LALLBCAPHHE, Task<AvatarItemMaterial> LAPKLENLFOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KCOFCKFNCBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LMPCBAKLOKL : BMPHKDMPHIM<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private FDLGIOOGFEJ<MaterialMapAsset> OFBHFOIEGGG;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x81455D0", Offset = "0x8143FD0", VA = "0x1881455D0")]
		public LMPCBAKLOKL(FDLGIOOGFEJ<MaterialMapAsset> OFBHFOIEGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8145100", Offset = "0x8143B00", VA = "0x188145100", Slot = "11")]
		protected override Material[] DMPOLIDGOED(Task<MaterialMapAsset> AIPCFMDLKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8145570", Offset = "0x8143F70", VA = "0x188145570", Slot = "12")]
		protected override void IGPGEBAEPBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class APOMJGOFFLM : BMPHKDMPHIM<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private List<FDLGIOOGFEJ<Material>> LNOBELKHMFL;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8134070", Offset = "0x8132A70", VA = "0x188134070")]
		public APOMJGOFFLM(Task<Material[]> AIPCFMDLKCK, List<FDLGIOOGFEJ<Material>> LNOBELKHMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8133EE0", Offset = "0x81328E0", VA = "0x188133EE0", Slot = "11")]
		protected override Material[] DMPOLIDGOED(Task<Material[]> NMFOLLODJFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8133F30", Offset = "0x8132930", VA = "0x188133F30", Slot = "12")]
		protected override void IGPGEBAEPBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8144570", Offset = "0x8142F70", VA = "0x188144570")]
	public static FDLGIOOGFEJ<Material[]> JPHHEAFJAIM(AssetReference[] FNJIOPBIFKJ)
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
		public enum AIBDABIPMHC
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
		public enum BJCIHDELOPC
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
		public enum PDCAJODPIPB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct MDKPHKCFMJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public readonly Material ADBOMPMBHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public readonly AIBDABIPMHC KNDOCFLOENM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly BJCIHDELOPC AOJPHHFGJFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly BEBMGMBEIIO IALOGONDFCM;

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x815CD10", Offset = "0x815B710", VA = "0x18815CD10")]
			public MDKPHKCFMJA(Material POCHLMCAOAO, AIBDABIPMHC PHICLGPIFCF, BJCIHDELOPC KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x815CAF0", Offset = "0x815B4F0", VA = "0x18815CAF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x815C9D0", Offset = "0x815B3D0", VA = "0x18815C9D0")]
			public bool FMOEJGBHBPC(MDKPHKCFMJA EFNHKCDKOGH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x815C8F0", Offset = "0x815B2F0", VA = "0x18815C8F0", Slot = "0")]
			public override bool Equals(object CEFJEHJNIAP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x815CA50", Offset = "0x815B450", VA = "0x18815CA50", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class FBDDJHALGOE : IComparable<FBDDJHALGOE>, IEquatable<FBDDJHALGOE>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public int ENBGFFOGAGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public PlayerAvatarDisplayBase GIDIGOEEAJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public IList<LCNONGDOOKP> EFDGLIKCEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public AvatarItemBodyType PNHHGBMHDIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public JPPAJFNEJPL NKMFMLLAMFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public bool AOHJMAHMKBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public bool IMCPOGLMBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public int[] CIJIIIPLHCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public float MCOLDCCMNAM;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8159D50", Offset = "0x8158750", VA = "0x188159D50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x8159C00", Offset = "0x8158600", VA = "0x188159C00", Slot = "4")]
			public int CompareTo(FBDDJHALGOE EFNHKCDKOGH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8159C30", Offset = "0x8158630", VA = "0x188159C30", Slot = "5")]
			public bool Equals(FBDDJHALGOE EFNHKCDKOGH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public FBDDJHALGOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class HGDLGJCKLEF
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class EHFBMNILJOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public readonly Mesh OGLBLDBDFOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public readonly Material[] DDPMGEFILOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public readonly Transform[] HCKGKGKAJCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public readonly Matrix4x4[] DCIKJKDFMLO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public readonly Transform ICHPLPDPJEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				public readonly bool DDLIKLOIALK;

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				protected EHFBMNILJOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x8159100", Offset = "0x8157B00", VA = "0x188159100")]
				public EHFBMNILJOL(Mesh HFCMFMCGELA, Material[] BIHBONHENIN, bool EFHBIOKGNLP, Transform[] GBBPMBIJIHO, Transform NLKIBDBPDEL, Matrix4x4[] FBCCIHOPEIA)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x8159040", Offset = "0x8157A40", VA = "0x188159040")]
				private EHFBMNILJOL(SkinnedMeshRenderer FHHDEFAFLFE, Material[] NPJLJMBGKDO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x81595B0", Offset = "0x8157FB0", VA = "0x1881595B0")]
				private EHFBMNILJOL(MeshRenderer FJFHDIJEPPP, Transform NLKIBDBPDEL, Material[] NPJLJMBGKDO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x8158D10", Offset = "0x8157710", VA = "0x188158D10")]
				public static EHFBMNILJOL MCHFIFBJONL(Renderer BDBIAPPPJPF, Material[] NPJLJMBGKDO)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public readonly BEBMGMBEIIO IALOGONDFCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public readonly Transform JDMOBCDGOKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public readonly bool KHDAMJKJEAO;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool DPJLEAJLMPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool DBBHIEPLBCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual EAIOHGIPLKL.BKMDKGNIEFL PNGNADEGJOI
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
				get
				{
					return default(EAIOHGIPLKL.BKMDKGNIEFL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool HDHBEMALEPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x815A170", Offset = "0x8158B70", VA = "0x18815A170")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x815A180", Offset = "0x8158B80", VA = "0x18815A180")]
			protected HGDLGJCKLEF(BEBMGMBEIIO HMKMCCAOOLE, Transform PJNFPAHEBPB, bool COMFOCNMDBJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED);

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract EHFBMNILJOL ANIFFNDAPAH(int JLNNLJBBHIC, PlayerHandBones EDKMOEHHGJI);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class AODJIGFKHIA : HGDLGJCKLEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected readonly BodyPartLODs DDKLJEGHCGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Material[] KHIKAHNLJMP;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8158470", Offset = "0x8156E70", VA = "0x188158470")]
			public AODJIGFKHIA(BEBMGMBEIIO HMKMCCAOOLE, BodyPartLODs IPMAGNDHOGB, Material BMDJIKNHOIO, [Optional] Transform PJNFPAHEBPB, bool COMFOCNMDBJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8158370", Offset = "0x8156D70", VA = "0x188158370", Slot = "7")]
			public override PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x81581B0", Offset = "0x8156BB0", VA = "0x1881581B0", Slot = "8")]
			public override EHFBMNILJOL ANIFFNDAPAH(int JLNNLJBBHIC, PlayerHandBones EDKMOEHHGJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x8158400", Offset = "0x8156E00", VA = "0x188158400", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class NIPGJPDOPEH : HGDLGJCKLEF
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool DPJLEAJLMPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool DBBHIEPLBCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x815FB60", Offset = "0x815E560", VA = "0x18815FB60", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public KOGDPHEMGGM HNECDENNDHB
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x815FC20", Offset = "0x815E620", VA = "0x18815FC20")]
			public NIPGJPDOPEH(BEBMGMBEIIO HMKMCCAOOLE, Transform PJNFPAHEBPB, KOGDPHEMGGM NLAKGFHHLCA, bool COMFOCNMDBJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x815FAD0", Offset = "0x815E4D0", VA = "0x18815FAD0", Slot = "7")]
			public override PNBAKNHPHGJ BIFILBHMPNL(List<OMAHFCAPHPN> FFDAALLHIJK, List<OMAHFCAPHPN> APDJMDNBEED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "8")]
			public override EHFBMNILJOL ANIFFNDAPAH(int JLNNLJBBHIC, PlayerHandBones EDKMOEHHGJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x815FBB0", Offset = "0x815E5B0", VA = "0x18815FBB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class IDJCIJNHGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum KMGOLJDDKGE
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
			public static readonly int DMNFCCJIPKE;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public static readonly int NHDAPIANENI;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public static readonly int JBGOKMDAGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected readonly PGJJMMOJPKN JMHLIIFGJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected readonly OBGDMMLHNGI APOJPKJNCBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected readonly Animator IBFGDLIGFEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected readonly Transform MKDFJMFFKIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Vector3 CFDPJLFJOJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly Transform MPENMMMIEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector3 BMBNPPCKOOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected bool HENJBBPAKKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected JPICLCPJPKE CHABHJEFLEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected bool PHKJCKBNFHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected float COGHOOGKNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected LIMEFMJFLAN<GCPPKJEFDIG> HNBHAMNBNNH;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public JPICLCPJPKE IIELJCKOPCN
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool JLFOLKFLBPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0xD3CDB0", Offset = "0xD3B7B0", VA = "0x180D3CDB0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0x815AA30", Offset = "0x8159430", VA = "0x18815AA30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool JHBJILKFCLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xA91C40", Offset = "0xA90640", VA = "0x180A91C40")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x815A960", Offset = "0x8159360", VA = "0x18815A960")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float PHMHLMINEEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xDD1980", Offset = "0xDD0380", VA = "0x180DD1980")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x815A6E0", Offset = "0x81590E0", VA = "0x18815A6E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public GCPPKJEFDIG OAEHBIFLJCH
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x815A820", Offset = "0x8159220", VA = "0x18815A820")]
				get
				{
					return default(GCPPKJEFDIG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x815AC30", Offset = "0x8159630", VA = "0x18815AC30")]
			public bool OCKIECLIFLM(GCPPKJEFDIG BGDHMJBAEBG, object DHNMCOFINFM, KMGOLJDDKGE BMCIDDEOPIC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x815A5E0", Offset = "0x8158FE0", VA = "0x18815A5E0")]
			public bool GHGOGKEAHBJ(object DHNMCOFINFM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x815B4A0", Offset = "0x8159EA0", VA = "0x18815B4A0")]
			protected IDJCIJNHGLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x815AEB0", Offset = "0x81598B0", VA = "0x18815AEB0")]
			public IDJCIJNHGLJ(PGJJMMOJPKN JMHLIIFGJJK, JPICLCPJPKE CFEAOPLIELK, Animator IBFGDLIGFEP, Transform MKDFJMFFKIO, Transform MPENMMMIEIM, Vector3 CFDPJLFJOJG, Vector3 BMBNPPCKOOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x815A860", Offset = "0x8159260", VA = "0x18815A860")]
			private void ILFLOAMBEBA(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x815A260", Offset = "0x8158C60", VA = "0x18815A260")]
			protected void CDEPJBDBBFM(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x815AD40", Offset = "0x8159740", VA = "0x18815AD40")]
			protected void OPFLFDEDLPI(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x815AB00", Offset = "0x8159500", VA = "0x18815AB00")]
			protected void MJAKEKKIBHM(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x815A470", Offset = "0x8158E70", VA = "0x18815A470")]
			protected void EGNIJBOFODE(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x815A580", Offset = "0x8158F80", VA = "0x18815A580")]
			protected void GFAPGAENMEI(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x815A210", Offset = "0x8158C10", VA = "0x18815A210")]
			protected void APDOPDPEOCC(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x815A910", Offset = "0x8159310", VA = "0x18815A910")]
			protected void JDEHLHOJLLP(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x815A350", Offset = "0x8158D50", VA = "0x18815A350")]
			protected void CPBCHICNLLI(ushort IPAIGFFKCJA, ushort PBAOPBGOBGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class NIKNHIFAFMB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public const int BAGFAAMJGLM = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected MaterialPropertyBlock ONJLEAPMJGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Color? KOBKFBOKCON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Color? NHAPCOAKACM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Color? MBGEAALEMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Color MDFEMNJMGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Color CAKOHGGLPDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Color ABEPKKJIEEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Texture2D EMPKJGMKMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Texture2D LLLKOEOBBOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Dictionary<MDKPHKCFMJA, int> MNAPONIFNJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected AIBDABIPMHC[] DPBICPLMCKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Vector4[] ALOJNFJJGHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Vector4[] IPCEJMJMLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Vector4[] JIOCAJDGPDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Vector4[] PLIOIJEEEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Vector4[] JIBHOCIAEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Vector4[] KGKEGFBFKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected List<Texture2D> JMKNFHGLHMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected Vector4[] NPKMEFNDLON;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected List<Texture2D> GEKIBBCHDGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected float[] DJFDDFMCIAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector4[] LBBDJJBFCPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected float[] LKNKDAHHMFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public float[] LOHAFOMAFNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected List<Texture2D> LNMELGCLEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected float[] KPBEKLIABCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected List<Texture2D> PBGDDHLPFMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector4[] FNPHKKEHMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected float[] MHPIKAKHPCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] DNOLGEMPHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public float[] BCHEPFCNCLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Texture2DArray NGBMPNIINOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Texture2DArray BDMNCPPDCPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Texture2DArray JMNLHLMLOAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Texture2DArray BPLGCEFFMAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool GDKMGJOJJPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected int OGGIFGLNJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected Vector2? BJNPCFJPEGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected TextureFormat FLEDKMPPPPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector2? GGJCCGDJKOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected TextureFormat FAPEBLADPNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected Vector2? GKDKONJAILM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected TextureFormat IDGNAJJDHKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected Vector2? JFIFADIKIJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected TextureFormat MGPPODFJPPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected bool JNAAJFKIBLB;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int FFJCIALABBA;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int EKIIKLEOABH;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int LKJIBKNFCGE;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int PLADPJDAJPG;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int JHLPNECFMLA;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int FBAKKMFEEAN;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int OGPILONJNOP;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int PPPJCIKDMCI;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int DOGNEHODABF;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int DMJNKOPAHPN;

			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected static int OPCCEFDIOLB;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int NMAAONNHBOI;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int LHOGHEONOOI;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int JNHFGJMMCMM;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int PCOEMDAINLI;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int NLCHKEBEDLG;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int NCLBJCPMLCJ;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int EKLHCMPAOEF;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int PEKCKMKLDAJ;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int BCIJBJJLDIF;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x815F580", Offset = "0x815DF80", VA = "0x18815F580")]
			protected NIKNHIFAFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x815FA40", Offset = "0x815E440", VA = "0x18815FA40")]
			public NIKNHIFAFMB(Color IEJOMNEKCHG, Color KIIPMICBDCC, Color BPBELJIDHLC, Color? LFCPLBKFNIG, Color? NBDIBOJDOOB, Color? IMAMFBCPBGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x815DEC0", Offset = "0x815C8C0", VA = "0x18815DEC0")]
			public int DCNNIEPOFEK(Material DJBFPCKMDLE, AIBDABIPMHC PHICLGPIFCF, BJCIHDELOPC KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x815DE30", Offset = "0x815C830", VA = "0x18815DE30")]
			public int DCNNIEPOFEK(MDKPHKCFMJA LNBCHJPEENA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x815E140", Offset = "0x815CB40", VA = "0x18815E140")]
			public int HIDECOEMJKB(Material DJBFPCKMDLE, Color MIBPJAMPLAH, Color EDBPCEOJKMK, Color AKPPCGLCPCE, Color NHNKCIMEAFC, Color NNJFMBEJFFJ, Texture2D HHDANPKFGOL, Vector4 IIPECCJLOFD, Texture2D BPPALADCHFD, Vector4 BKHMMDFBLEC, float NCGCMMNMHKO, float FDFPLGCAACO, Texture2D MGDDENOENGN, Vector4 JHAPIAHNFOI, float KOMGDMBLDIL, Texture2D IJMLFJDFONJ, float PMKOIGMJOKH, Color EMKONIJNLBD, Vector4 AFOGCNEFBDH, AIBDABIPMHC PHICLGPIFCF, BJCIHDELOPC KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x815EE40", Offset = "0x815D840", VA = "0x18815EE40")]
			protected void NFKFFKPJGGG([Out] Texture2DArray GPAFGKANDPG, [Out] Texture2DArray ELPCENKLENM, [Out] Texture2DArray IAELLFPDKEL, [Out] Texture2DArray MLMJOBINFIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x815D010", Offset = "0x815BA10", VA = "0x18815D010")]
			public void AILPPPNKPPC(PlayerAvatarDisplayBase MJEBNGAFHPL, Renderer BDBIAPPPJPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x815D310", Offset = "0x815BD10", VA = "0x18815D310")]
			protected void CMBHFAKNLIL(PlayerAvatarDisplayBase MJEBNGAFHPL, Renderer BDBIAPPPJPF, int DIJECNJBHJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x815F000", Offset = "0x815DA00", VA = "0x18815F000")]
			private Color PCKHJCOIFAB(Color IOJPOJCIHJG, AIBDABIPMHC FLINNIHPCCA)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x815DFF0", Offset = "0x815C9F0", VA = "0x18815DFF0")]
			private Color FOPKHEMDPLF(Color FOHILPECOCC, AIBDABIPMHC FLINNIHPCCA)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x815D280", Offset = "0x815BC80", VA = "0x18815D280")]
			protected void BDBDECFHGDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x815DFB0", Offset = "0x815C9B0", VA = "0x18815DFB0", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x81671E0", Offset = "0x8165BE0", VA = "0x1881671E0")]
			public void BKNELFBPBPE(BEBMGMBEIIO HMKMCCAOOLE, [Out] Transform PJFDNMGHMBL, [Out] Transform[] GBBPMBIJIHO)
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
		private sealed class GJGGBBKOHMD : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
			[DebuggerHidden]
			public GJGGBBKOHMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8159EA0", Offset = "0x81588A0", VA = "0x188159EA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x815A120", Offset = "0x8158B20", VA = "0x18815A120", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x815A070", Offset = "0x8158A70", VA = "0x18815A070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x815A070", Offset = "0x8158A70", VA = "0x18815A070", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class NPIEKCMIOFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public NPIEKCMIOFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x815FC90", Offset = "0x815E690", VA = "0x18815FC90")]
			internal bool ALGKEDCPACF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class DOEFAJELLOL : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public DOEFAJELLOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x8158970", Offset = "0x8157370", VA = "0x188158970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x8158CC0", Offset = "0x81576C0", VA = "0x188158CC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct KABNDKIHPPJ : IAsyncStateMachine
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
			public ALIGCGMOICI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x815BB70", Offset = "0x815A570", VA = "0x18815BB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x815BF10", Offset = "0x815A910", VA = "0x18815BF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class HLCCKOIBIEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public HLCCKOIBIEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x815A1E0", Offset = "0x8158BE0", VA = "0x18815A1E0")]
			internal bool GDELNMHJEBC(LCNONGDOOKP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class OAGKIHKDHEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public Func<DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public OAGKIHKDHEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x815FE20", Offset = "0x815E820", VA = "0x18815FE20")]
			internal (DAMMDADGLAC, DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>>) LCKLDCIIFLB(Dictionary<string, MFEMMJNIGFA> avatarItems)
			{
				return default((DAMMDADGLAC, DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x815FD70", Offset = "0x815E770", VA = "0x18815FD70")]
			internal DPMDGLGHBHJ<Dictionary<string, FDLGIOOGFEJ<Texture2D>>> DBJALMNMHHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x815FDE0", Offset = "0x815E7E0", VA = "0x18815FDE0")]
			internal void KLMFECLNLDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class KODGKPKGMIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public KODGKPKGMIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x815BF70", Offset = "0x815A970", VA = "0x18815BF70")]
			internal bool CPEEJAFCBMK(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct PLCKFGGEBFA : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x8160810", Offset = "0x815F210", VA = "0x188160810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x81609E0", Offset = "0x815F3E0", VA = "0x1881609E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int EBIKCDLJGPI;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int OOCFJPAGAMH;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static readonly int HCLPHFEPHLF;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int JKEGGKJHFJJ;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected static readonly int BCCHELBJMFJ;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected static readonly int JCIALLGGCOG;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] JNOHHFNGGBM;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected static readonly int[] MKKJGPECLED;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected static readonly int[] OHJOOOHEJGJ;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected static readonly int[] AJKDJNKFKHI;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] AHHIEDNFKJN;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int[] CDKHOCEHPJN;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static List<PlayerAvatarDisplayBase> GLGMFEINFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected DAOAHDPCGLG KJKBEPMMOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected bool JCCKNALHEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected bool HPMMENJOPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected static readonly int[] BOKJOOHBCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Dictionary<MDKPHKCFMJA, Material> IAKDOEIMIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Dictionary<MDKPHKCFMJA, Material> NCOCAILFBHI;

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
		protected Material EOJJNJPDLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected POODIKIDKFI GMNCGDCGJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private JPICLCPJPKE ODNJPJMHLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private JPICLCPJPKE IPBCHDGFNFK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Material BKEFBPCMCMH;

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
		protected FitMeshHemisphere BMCKFMNFCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected bool IKPNPBLGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected JNPBPAOBAGK CLOIHFEMNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool DKLLJGHHBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected AnchorParamsRestrictions NOBOKNNHFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool HIOCPALOLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Transform FJDHIJIMDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected bool LJNFCPBCAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected bool JJMKHFFNGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Vector3 DAOLMJJFLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Quaternion MBHJDDHMFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected Vector2 KFDIJAMKMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected FitMeshHemisphere HIJOBBJBMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[OICBHOIKJDP(MGLGMLBODOF.SelfAndChildren, false, false, false)]
		[SerializeField]
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
		protected Collider[] ADDICHAEIIP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Collider[] ELDLDAMCJLH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected IDJCIJNHGLJ[] FMILDHEJPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Dictionary<Renderer, NIKNHIFAFMB> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<Renderer, NIKNHIFAFMB> PCODDFAMBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected MNDFAHIBFIB JHOJPLKDELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected DAMMDADGLAC DGCIOMPFCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CNMJFAPGOOG DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected int MKJMGPEMNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected (bool isLodForced, int forcedLOD) LKFBLDEADAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected LIMEFMJFLAN<OBGDMMLHNGI> HNBHAMNBNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected bool PIBMDPAHFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Dictionary<LCNONGDOOKP, List<MDKPHKCFMJA>> BELJDMJEBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Dictionary<LCNONGDOOKP, List<MDKPHKCFMJA>> MKMPPOIJLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected readonly Dictionary<string, FDLGIOOGFEJ<Texture2D>> PMBJOGMAGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected readonly Dictionary<string, FDLGIOOGFEJ<Texture2D>> DHKLDOOPHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected bool NBJGAMJKJMO;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected static int EPIJGKAIBCA;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected static List<FBDDJHALGOE> LACJFONHOIF;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected static List<FBDDJHALGOE> DMEFBMBDLOH;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected static NNFEFJFFOPD ECACAJGBPGO;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected static Func<List<FBDDJHALGOE>, FBDDJHALGOE> DJLFFLMKNOG;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected static bool BIGHNOJFCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected Color? OOFBNFOKFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected bool NNGGIKDPJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color IKKGCAIDAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected Color PKJLGPOJNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color CKADCCEBAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected AvatarHairPattern AMFHGLMMFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected KOGDPHEMGGM FKIAHJHBJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected Color IJDONHLANLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected Color KEEGOBFACOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected AvatarHairPattern JBBHKELBFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected KOGDPHEMGGM OFLAEHHIDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected KOGDPHEMGGM MAKNNGMHLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Color PLGPBJGOLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private AdditionalFeetData LEJMJLNJEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected LCNONGDOOKP? MOCJGCPKBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected Texture EDLDBPFDOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected Color MINMKLHELBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected readonly IList<LCNONGDOOKP> BEHIHMEGPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected readonly IList<LCNONGDOOKP> IODECHOOPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private AvatarItemBodyType MLGGIMHOLFI;

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
		protected BALOCJGIMAO _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected PDCAJODPIPB FGIMDPNKPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected int[] DHHEBMFPAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected bool JOEOMLCOLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected int[] CKIPDMFELPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool DCAOFHJLDPJ;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly EAIOHGIPLKL.BKMDKGNIEFL HKEGBDGEFFN;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private static readonly EAIOHGIPLKL.BKMDKGNIEFL LPPCNHICGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected bool MOJDCKHCFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected NKOKBMFEAOJ BNHGNDFICCI;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string NPGJHEOCOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool JAFOLMIDBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD33040", Offset = "0xD31A40", VA = "0x180D33040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD32530", Offset = "0xD30F30", VA = "0x180D32530")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool AGJEFMNMNDD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool HHDJJEBBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x8156B50", Offset = "0x8155550", VA = "0x188156B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KDHMNLHIPCL
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool LHJOLDOEDGA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool BFKGNHDNOFN
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool AKMOADKHBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public POODIKIDKFI PNINANPDKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xBE9A80", Offset = "0xBE8480", VA = "0x180BE9A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8157330", Offset = "0x8155D30", VA = "0x188157330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JPICLCPJPKE GBCMOACOJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDA370", VA = "0x180BDB970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8157730", Offset = "0x8156130", VA = "0x188157730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public JPICLCPJPKE IEHADJDEGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xBF8800", Offset = "0xBF7200", VA = "0x180BF8800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x81579F0", Offset = "0x81563F0", VA = "0x1881579F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material KJKPLPIOKJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x814ACA0", Offset = "0x81496A0", VA = "0x18814ACA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material HJHMIIEFOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x814B1A0", Offset = "0x8149BA0", VA = "0x18814B1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool CHEDNBIMEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x24D9DC0", Offset = "0x24D87C0", VA = "0x1824D9DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase LOHGKGHCPAF
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xBF8A10", Offset = "0xBF7410", VA = "0x180BF8A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IDJCIJNHGLJ[] OJFKABAOBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x81566D0", Offset = "0x81550D0", VA = "0x1881566D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IDJCIJNHGLJ GDGILAJGHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8156D60", Offset = "0x8155760", VA = "0x188156D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public IDJCIJNHGLJ EBLNOOLGNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8156D90", Offset = "0x8155790", VA = "0x188156D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh HKKHPKDPLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB80830", VA = "0x180B81E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected MNDFAHIBFIB ODPPDDCHJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x814EBA0", Offset = "0x814D5A0", VA = "0x18814EBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected DAMMDADGLAC AJEBIEDPAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xBF94E0", Offset = "0xBF7EE0", VA = "0x180BF94E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x814E1E0", Offset = "0x814CBE0", VA = "0x18814E1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool LNMFALGDCKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool IHFLNMHFMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x8156D50", Offset = "0x8155750", VA = "0x188156D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int OGBJMLHOODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x134F430", Offset = "0x134DE30", VA = "0x18134F430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x8157940", Offset = "0x8156340", VA = "0x188157940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int GDGALFGGKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x8157680", Offset = "0x8156080", VA = "0x188157680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool NJPPINOGHNP
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] AAIDFMCGJMD
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x814D400", Offset = "0x814BE00", VA = "0x18814D400", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool AMBLBHGHNHF
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x814E160", Offset = "0x814CB60", VA = "0x18814E160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool FMDMKFHCGDE
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool OOMJHKEBBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8156DC0", Offset = "0x81557C0", VA = "0x188156DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8157C00", Offset = "0x8156600", VA = "0x188157C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> MCHIENPIMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x8156550", Offset = "0x8154F50", VA = "0x188156550")]
			[IteratorStateMachine(typeof(GJGGBBKOHMD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool GHGHOCPHKLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x8156D40", Offset = "0x8155740", VA = "0x188156D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x814DBB0", Offset = "0x814C5B0", VA = "0x18814DBB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public EAJLGMHEHMA BHILEGIKIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x81565D0", Offset = "0x8154FD0", VA = "0x1881565D0")]
			get
			{
				return default(EAJLGMHEHMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool HAPOCMDKLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8156A80", Offset = "0x8155480", VA = "0x188156A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static NNFEFJFFOPD LBLNJMFLAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8150160", Offset = "0x814EB60", VA = "0x188150160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x814CEF0", Offset = "0x814B8F0", VA = "0x18814CEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color NHAPCOAKACM
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x814EB50", Offset = "0x814D550", VA = "0x18814EB50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color MBGEAALEMOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8148FF0", Offset = "0x81479F0", VA = "0x188148FF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D PIAIGDKFHEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x814F2D0", Offset = "0x814DCD0", VA = "0x18814F2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color MDFEMNJMGHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x8156680", Offset = "0x8155080", VA = "0x188156680")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color CAKOHGGLPDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x814EBC0", Offset = "0x814D5C0", VA = "0x18814EBC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public KOGDPHEMGGM OGGHGHHJMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8156640", Offset = "0x8155040", VA = "0x188156640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D HBPCPAKOGDL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x814E570", Offset = "0x814CF70", VA = "0x18814E570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float IFLIIGFNCFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8156660", Offset = "0x8155060", VA = "0x188156660")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float CAAJOLBPABJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8156B30", Offset = "0x8155530", VA = "0x188156B30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool LNFMHCMJJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8156630", Offset = "0x8155030", VA = "0x188156630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x8157110", Offset = "0x8155B10", VA = "0x188157110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EOHDHJNNOEG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x81562B0", Offset = "0x8154CB0", VA = "0x1881562B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8156E70", Offset = "0x8155870", VA = "0x188156E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FEDGLLJHEGE
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8156210", Offset = "0x8154C10", VA = "0x188156210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8156DD0", Offset = "0x81557D0", VA = "0x188156DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MHHLIOGACHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x8156350", Offset = "0x8154D50", VA = "0x188156350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x8156F10", Offset = "0x8155910", VA = "0x188156F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EFDJBCPKKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x81563F0", Offset = "0x8154DF0", VA = "0x1881563F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8156FB0", Offset = "0x81559B0", VA = "0x188156FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<PGJJMMOJPKN, GCPPKJEFDIG> IEMDDPIJAOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8156490", Offset = "0x8154E90", VA = "0x188156490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8157050", Offset = "0x8155A50", VA = "0x188157050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8152A60", Offset = "0x8151460", VA = "0x188152A60")]
		public bool SetDeformation(bool JCCKNALHEPE, bool HPMMENJOPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8151340", Offset = "0x814FD40", VA = "0x188151340")]
		protected static Material OMJBNDOEIBC(Dictionary<MDKPHKCFMJA, Material> OGGPCFGNEEP, Material LJNLHHFMOBG, AIBDABIPMHC PHICLGPIFCF, BJCIHDELOPC KLOLBNIBGEI, BEBMGMBEIIO HMKMCCAOOLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x814B2E0", Offset = "0x8149CE0", VA = "0x18814B2E0")]
		protected void CNAFPLBOMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x814D4F0", Offset = "0x814BEF0", VA = "0x18814D4F0")]
		protected bool GIFHMOKHNHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x814D0C0", Offset = "0x814BAC0", VA = "0x18814D0C0")]
		protected void FKOBOEOMFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x814CE90", Offset = "0x814B890", VA = "0x18814CE90", Slot = "11")]
		protected virtual void FEONDFABCIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x81504E0", Offset = "0x814EEE0", VA = "0x1881504E0")]
		public int MeshesAtLODCount(int NDDBNJGGFJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x814BC40", Offset = "0x814A640", VA = "0x18814BC40")]
		protected static void DFNOJJPENOH(Dictionary<LCNONGDOOKP, List<MDKPHKCFMJA>> EKGECJENMCF, HGDLGJCKLEF EODNJOFAAPO, Material LJNLHHFMOBG, AIBDABIPMHC FLINNIHPCCA, BJCIHDELOPC OLKENKEHFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8149AE0", Offset = "0x81484E0", VA = "0x188149AE0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x814E670", Offset = "0x814D070", VA = "0x18814E670")]
		protected void IEABEFNIBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8151580", Offset = "0x814FF80", VA = "0x188151580")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
		protected virtual void NJJNGJCKFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x814F9B0", Offset = "0x814E3B0", VA = "0x18814F9B0")]
		protected static void LGJHGMCNCOH(List<Material> IMAHFCFLOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x814CD30", Offset = "0x814B730", VA = "0x18814CD30")]
		protected static void FEFBCKMODGC(Dictionary<MDKPHKCFMJA, Material> OGGPCFGNEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x814FAF0", Offset = "0x814E4F0", VA = "0x18814FAF0")]
		protected static void LKNINDGEEJG(Dictionary<Renderer, NIKNHIFAFMB> PHBIAEJAEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x814DBC0", Offset = "0x814C5C0", VA = "0x18814DBC0")]
		protected void HBOLNKJGBLE(SkinnedMeshRenderer[] GKDMMPNJCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x814C990", Offset = "0x814B390", VA = "0x18814C990")]
		protected void EMAANNBMJDJ(SkinnedMeshRenderer FHHDEFAFLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x814C8C0", Offset = "0x814B2C0", VA = "0x18814C8C0")]
		protected void EMAANNBMJDJ(MeshRenderer FJFHDIJEPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x814BF10", Offset = "0x814A910", VA = "0x18814BF10")]
		protected void DHAALHCEBKK(List<OMAHFCAPHPN> ACIGBHGAOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x814D710", Offset = "0x814C110", VA = "0x18814D710")]
		protected void GKAPACHIGDO(Dictionary<string, FDLGIOOGFEJ<Texture2D>> EKGECJENMCF, bool FOPOBAPEAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x814B290", Offset = "0x8149C90", VA = "0x18814B290")]
		protected void CDPCJAGNKLE(Dictionary<LCNONGDOOKP, List<MDKPHKCFMJA>> EKGECJENMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x814DA50", Offset = "0x814C450", VA = "0x18814DA50")]
		public float GetHandOpenClosedAxis(PGJJMMOJPKN JMHLIIFGJJK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8153300", Offset = "0x8151D00", VA = "0x188153300")]
		public void SetHandOpenClosedAxis(PGJJMMOJPKN JMHLIIFGJJK, float NOKMFBMEOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x814DA90", Offset = "0x814C490", VA = "0x18814DA90")]
		public GCPPKJEFDIG GetHandVisualState(PGJJMMOJPKN JMHLIIFGJJK)
		{
			return default(GCPPKJEFDIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8149220", Offset = "0x8147C20", VA = "0x188149220")]
		public bool AddHandVisualStateToken(PGJJMMOJPKN JMHLIIFGJJK, GCPPKJEFDIG BACJIMEEJGC, object DHNMCOFINFM, IDJCIJNHGLJ.KMGOLJDDKGE BMCIDDEOPIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8154B90", Offset = "0x8153590", VA = "0x188154B90")]
		public void SetWatchHand(PGJJMMOJPKN JMHLIIFGJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8154C50", Offset = "0x8153650", VA = "0x188154C50")]
		public void SetWatchHands(bool OBILEBPLFMJ, bool NOJKJNNBFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8152120", Offset = "0x8150B20", VA = "0x188152120")]
		public bool RemoveHandVisualStateToken(PGJJMMOJPKN JMHLIIFGJJK, object DHNMCOFINFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x814DB10", Offset = "0x814C510", VA = "0x18814DB10")]
		public bool GetThumbsUpActive(PGJJMMOJPKN JMHLIIFGJJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x81545A0", Offset = "0x8152FA0", VA = "0x1881545A0")]
		public void SetThumbsUpActive(PGJJMMOJPKN JMHLIIFGJJK, bool DDLNCPGBOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x814DAD0", Offset = "0x814C4D0", VA = "0x18814DAD0")]
		public bool GetHandshakeActive(PGJJMMOJPKN JMHLIIFGJJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8153350", Offset = "0x8151D50", VA = "0x188153350")]
		public void SetHandshakeActive(PGJJMMOJPKN JMHLIIFGJJK, bool DILLHFNFCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x814D3B0", Offset = "0x814BDB0", VA = "0x18814D3B0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8154A80", Offset = "0x8153480", VA = "0x188154A80")]
		public void SetUseClassicBeanHandScale(bool PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x814BA00", Offset = "0x814A400", VA = "0x18814BA00")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x814AEE0", Offset = "0x81498E0", VA = "0x18814AEE0")]
		private static void BMDBGBGGLEG(Scene FPJGDNNEOIB, LoadSceneMode JFFMBFIHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x814C4A0", Offset = "0x814AEA0", VA = "0x18814C4A0")]
		protected static void EEEMCHEIJMD(PlayerAvatarDisplayBase EGECGGPCBAB, List<FBDDJHALGOE> EAPLJEJCMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8151E40", Offset = "0x8150840", VA = "0x188151E40")]
		public PNBAKNHPHGJ Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x814B010", Offset = "0x8149A10", VA = "0x18814B010")]
		protected PNBAKNHPHGJ BNMOJELEKLK(bool PDKOBCHJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x814B070", Offset = "0x8149A70", VA = "0x18814B070", Slot = "13")]
		protected virtual PNBAKNHPHGJ BNMOJELEKLK(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, bool KBONCIJCCCC, bool PLCENPKIMNO, int[] KDNJBDMEDKN, bool PDKOBCHJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8150AB0", Offset = "0x814F4B0", VA = "0x188150AB0")]
		protected static PNBAKNHPHGJ OEPAKCGEMJN(FBDDJHALGOE AEOACEDPLKI, List<FBDDJHALGOE> EAPLJEJCMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x814DB50", Offset = "0x814C550", VA = "0x18814DB50")]
		[IteratorStateMachine(typeof(DOEFAJELLOL))]
		protected static IEnumerator<BHOPOIJKEJE> HAOEGKDFNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x814E380", Offset = "0x814CD80", VA = "0x18814E380")]
		protected static FBDDJHALGOE HLHHENNCAKF(List<FBDDJHALGOE> EAPLJEJCMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8152B70", Offset = "0x8151570", VA = "0x188152B70")]
		[AsyncStateMachine(typeof(KABNDKIHPPJ))]
		public Task SetFaceCustomizationSettings(ALIGCGMOICI OENIAJKILAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8154DB0", Offset = "0x81537B0", VA = "0x188154DB0")]
		public bool UpdateFaceAndBodyCustomizationSettings(ALIGCGMOICI OENIAJKILAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x814EC10", Offset = "0x814D610", VA = "0x18814EC10")]
		public void InitializeFaceFeatures(AvatarConfiguration IEIIEFANBEC, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x81542F0", Offset = "0x8152CF0", VA = "0x1881542F0")]
		public void SetTeamColors(Color? IMAMFBCPBGL, bool NCPMHMIIMFN, Color IHCDGMJGJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1517050", Offset = "0x1515A50", VA = "0x181517050")]
		private static void APMEFKEANFD(Material POCHLMCAOAO, Color PDKJBMPOMNC, params int[] KIJNOLKKEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x15181B0", Offset = "0x1516BB0", VA = "0x1815181B0")]
		private static void KJFGNMEAJFJ(Material POCHLMCAOAO, Texture PDKJBMPOMNC, params int[] KIJNOLKKEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x814C5A0", Offset = "0x814AFA0", VA = "0x18814C5A0")]
		protected void EFDKGOPBCLH(Material KDMOOJPGHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x814BB20", Offset = "0x814A520", VA = "0x18814BB20")]
		protected void DFFBNCNMHIP(Material KDMOOJPGHNH, Color FGHOGCMNIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x814ECF0", Offset = "0x814D6F0", VA = "0x18814ECF0")]
		protected void JAHMHKAKGHO(Material KDMOOJPGHNH, Color FGHOGCMNIPN, Color KAMEJFMCKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x814D190", Offset = "0x814BB90", VA = "0x18814D190")]
		protected void FPEGBCGAFBM(Material KDMOOJPGHNH, Texture2D GIAGKAKEOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8151D30", Offset = "0x8150730", VA = "0x188151D30")]
		protected void PKPBCGANNIA(Material KDMOOJPGHNH, Texture PNAAABBIKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x814CBD0", Offset = "0x814B5D0", VA = "0x18814CBD0")]
		protected void FCLEIFFOKBB(Action<NIKNHIFAFMB> GAOKFNOLAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x814FC50", Offset = "0x814E650", VA = "0x18814FC50")]
		protected void LLEECBJMOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8151B70", Offset = "0x8150570", VA = "0x188151B70")]
		protected void PILCPEAEBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x814F3D0", Offset = "0x814DDD0", VA = "0x18814F3D0")]
		protected void KKCEGMEPKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8149570", Offset = "0x8147F70", VA = "0x188149570")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x81524E0", Offset = "0x8150EE0", VA = "0x1881524E0")]
		public void SetBeardPrimaryColor([Optional] Color? MFDMABMEIGB, bool FEBFDBKAKMB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8152700", Offset = "0x8151100", VA = "0x188152700")]
		public void SetBeardSecondaryColor([Optional] Color? MFDMABMEIGB, bool FEBFDBKAKMB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x81523A0", Offset = "0x8150DA0", VA = "0x1881523A0")]
		public void SetBeardPattern([Optional] AvatarHairPattern KMOKEFHLOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8150640", Offset = "0x814F040", VA = "0x188150640")]
		private void NOHNJICFMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8151960", Offset = "0x8150360", VA = "0x188151960")]
		private bool PEDBHMIMGJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8152EE0", Offset = "0x81518E0", VA = "0x188152EE0")]
		public void SetHairPrimaryColor([Optional] Color? FLIAOMHODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x81530F0", Offset = "0x8151AF0", VA = "0x1881530F0")]
		public void SetHairSecondaryColor([Optional] Color? FLIAOMHODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8152DB0", Offset = "0x81517B0", VA = "0x188152DB0")]
		public void SetHairPattern([Optional] AvatarHairPattern KMOKEFHLOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8151FC0", Offset = "0x81509C0", VA = "0x188151FC0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x814E410", Offset = "0x814CE10", VA = "0x18814E410")]
		private bool HNEGJIPGLHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8154130", Offset = "0x8152B30", VA = "0x188154130")]
		public void SetSkinColor(Color IEJOMNEKCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x81545F0", Offset = "0x8152FF0", VA = "0x1881545F0")]
		public void SetUgcItemVisualOverrides(LCNONGDOOKP HIBMMEEDKDC, EAJLGMHEHMA LMJNBBKIBMJ, Texture LAFHFLNEKKE, Color BBIHAKBHCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x814BAD0", Offset = "0x814A4D0", VA = "0x18814BAD0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8152C70", Offset = "0x8151670", VA = "0x188152C70")]
		public bool SetFaceShape(AvatarFaceShape FHLDPPBLEDP, bool HMOLJENJODI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x814C820", Offset = "0x814B220", VA = "0x18814C820")]
		private void EGCAABNGKDE(CIDNHECLAKJ BNODGLHLEAK, float PDKJBMPOMNC, bool NGGIPNGCELD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x814C2A0", Offset = "0x814ACA0", VA = "0x18814C2A0")]
		private void ECDIIJEAMPM(IEEEHHNLHGA LHKBLMAPLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x814E4D0", Offset = "0x814CED0", VA = "0x18814E4D0")]
		private void HOMIMBIJDEJ(OEBHGMLHFGG GCKJJJCNODJ, float PDKJBMPOMNC, bool FLOPBBKIOMM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x814C200", Offset = "0x814AC00", VA = "0x18814C200")]
		private void DPBHMKNHIEE(BDONOFFGMKE IIDIBBIIPPI, float PDKJBMPOMNC, bool GFHOGDHFGAG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x814CAC0", Offset = "0x814B4C0", VA = "0x18814CAC0")]
		private void FAPGJLMOEHP(KFCJDDPMAGK FHOEFOFDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8151830", Offset = "0x8150230", VA = "0x188151830")]
		private void PEALNGHINFM(NBLCNAGLGBI LGMOMEABIHP, float PMCMNMFCGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8152920", Offset = "0x8151320", VA = "0x188152920")]
		public bool SetBodyShape(AvatarBodyShape LIJMKAGCHPL, bool HMOLJENJODI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8153FC0", Offset = "0x81529C0", VA = "0x188153FC0")]
		public bool SetNoseType(BALOCJGIMAO HLHJKHFOCLF, bool HMOLJENJODI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x81554A0", Offset = "0x8153EA0", VA = "0x1881554A0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8153FA0", Offset = "0x81529A0", VA = "0x188153FA0")]
		public bool SetHideEars(bool BHCNELNFDGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8153F90", Offset = "0x8152990", VA = "0x188153F90")]
		public bool SetHelmetHair(DAOAHDPCGLG LOPMFILCGJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x81539F0", Offset = "0x81523F0", VA = "0x1881539F0")]
		public void SetHatAnchorParameters(JNPBPAOBAGK LAFHHLDCDBJ, bool OEJIKKCEOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8154D20", Offset = "0x8153720", VA = "0x188154D20")]
		public void SetupDisplayLODs(PDCAJODPIPB EPFDPCIOOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x814F730", Offset = "0x814E130", VA = "0x18814F730")]
		protected int[] KMMBENNDJHN(PDCAJODPIPB EPFDPCIOOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x81540A0", Offset = "0x8152AA0", VA = "0x1881540A0")]
		public void SetOutfitSelections(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, bool PLCENPKIMNO, bool PDKOBCHJOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x81540E0", Offset = "0x8152AE0", VA = "0x1881540E0")]
		public void SetOutfitSelections(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, bool KBONCIJCCCC, bool PLCENPKIMNO, bool PDKOBCHJOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8154060", Offset = "0x8152A60", VA = "0x188154060")]
		public PNBAKNHPHGJ SetOutfitSelections(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, PDCAJODPIPB EPFDPCIOOCJ, bool KBONCIJCCCC, bool PLCENPKIMNO, bool HMOLJENJODI = false, bool PDKOBCHJOHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8151010", Offset = "0x814FA10", VA = "0x188151010", Slot = "14")]
		protected virtual PNBAKNHPHGJ OKJHLEOHAKH(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, bool KBONCIJCCCC, bool PLCENPKIMNO, PDCAJODPIPB EPFDPCIOOCJ, bool HMOLJENJODI, bool PDKOBCHJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x814E280", Offset = "0x814CC80", VA = "0x18814E280")]
		protected int[] HKNPPHKOIPE(PDCAJODPIPB EPFDPCIOOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "15")]
		protected virtual DAMMDADGLAC FJCEJPLBEDG(AvatarItemBodyType ILBCCMEBABC, Dictionary<string, MFEMMJNIGFA> IJBNMCPKADB, Dictionary<string, FDLGIOOGFEJ<Texture2D>> MCJAJLEIPCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x814FE90", Offset = "0x814E890", VA = "0x18814FE90", Slot = "16")]
		protected virtual PNBAKNHPHGJ LPCFCPOJIPH(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType OOGCMIEMDBA, bool KBONCIJCCCC, bool PLCENPKIMNO, int[] CIJIIIPLHCD, JPPAJFNEJPL KAFPDHHIBAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x814DCE0", Offset = "0x814C6E0", VA = "0x18814DCE0", Slot = "17")]
		protected virtual MFEMMJNIGFA HFDBLMBLLLN(KOGDPHEMGGM NLAKGFHHLCA, AvatarItemBodyType ILBCCMEBABC, BEBMGMBEIIO HMKMCCAOOLE, MFEMMJNIGFA CGOAHDMFGJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "18")]
		protected virtual MFEMMJNIGFA DHBLBLIMDIJ(AvatarItemBodyType ILBCCMEBABC, BEBMGMBEIIO HMKMCCAOOLE, GIJEHNOOKLE KPICELCLOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x814F050", Offset = "0x814DA50", VA = "0x18814F050")]
		protected void JLNDNBIHBDN(PKHBAFJFHAL EJBBAMIEIIL, EAIOHGIPLKL.BKMDKGNIEFL BMKEOFOGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8150A30", Offset = "0x814F430", VA = "0x188150A30")]
		protected void OEAMBOLDILA(PKHBAFJFHAL EJBBAMIEIIL, EAIOHGIPLKL.BKMDKGNIEFL BMKEOFOGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "19")]
		protected virtual PKHBAFJFHAL NHGKPFNMOBP(PKHBAFJFHAL EJBBAMIEIIL, HelmetHairStyle NHKNKFNDECF, bool EKLDENNLAJI, AvatarItemBodyType OOGCMIEMDBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8149C70", Offset = "0x8148670", VA = "0x188149C70")]
		protected PKHBAFJFHAL BAAIOKNKNHI(IList<LCNONGDOOKP> GKPGKJLKNPN, AvatarItemBodyType LIHAENHKHNI, bool PLCENPKIMNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x814B8E0", Offset = "0x814A2E0", VA = "0x18814B8E0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8151290", Offset = "0x814FC90", VA = "0x188151290")]
		protected void OLJCHBJLAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x81501B0", Offset = "0x814EBB0", VA = "0x1881501B0")]
		protected void MJLFEPKKDHB(Transform DMHJIACAIIM, IEnumerable<SkinnedMeshRenderer> OLDJNNCAOII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x814F8F0", Offset = "0x814E2F0", VA = "0x18814F8F0")]
		protected EAIOHGIPLKL.BKMDKGNIEFL LBODELNDNLP(EAIOHGIPLKL.BKMDKGNIEFL MPBKLKENAAN, BEBMGMBEIIO FMALOMLAKBD)
		{
			return default(EAIOHGIPLKL.BKMDKGNIEFL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x814F3C0", Offset = "0x814DDC0", VA = "0x18814F3C0")]
		protected void KFOPPPOEBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A4AEB0", Offset = "0x1A498B0", VA = "0x181A4AEB0")]
		protected void FDCEFBIAHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x814C0F0", Offset = "0x814AAF0", VA = "0x18814C0F0")]
		protected void DMKLNMBAEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8151A10", Offset = "0x8150410", VA = "0x188151A10")]
		[AsyncStateMachine(typeof(PLCKFGGEBFA))]
		protected Task PGOPBDKLMHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8150890", Offset = "0x814F290", VA = "0x188150890")]
		protected static AIBDABIPMHC OCHNMDOBJGN(HGDLGJCKLEF MCGJOOBMIIH, int EKNAJDDGFFK)
		{
			return default(AIBDABIPMHC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x81490D0", Offset = "0x8147AD0", VA = "0x1881490D0")]
		protected static BJCIHDELOPC ANKDLEOCNMA(HGDLGJCKLEF MCGJOOBMIIH, int EKNAJDDGFFK)
		{
			return default(BJCIHDELOPC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x81514A0", Offset = "0x814FEA0", VA = "0x1881514A0")]
		protected Transform OMNJOAGBPNO(BEBMGMBEIIO HMKMCCAOOLE, OutfitType KMKIDDBNOML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x814F0D0", Offset = "0x814DAD0", VA = "0x18814F0D0")]
		protected void JMKJEOAFHMA(int EHLCELNNEBG, Material POCHLMCAOAO, HGDLGJCKLEF MCGJOOBMIIH, [Out] Texture2D EHJNAGEEPBN, [Out] Vector4 JLJCHBGEHIO, [Out] Texture2D EHCJJKIENHJ, [Out] Texture2D LOFNHBMAAGC, [Out] Texture2D PEJLCHONCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x814D890", Offset = "0x814C290", VA = "0x18814D890")]
		protected void GOJFIHKPJKP(int EHLCELNNEBG, Material POCHLMCAOAO, HGDLGJCKLEF MCGJOOBMIIH, [Out] Color MIBPJAMPLAH, [Out] Color EDBPCEOJKMK, [Out] Color AKPPCGLCPCE, [Out] Color NHNKCIMEAFC, [Out] Color NNJFMBEJFFJ, [Out] Color EMKONIJNLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x814D9E0", Offset = "0x814C3E0", VA = "0x18814D9E0")]
		protected void GOPECBINBOL(Vector3 FLMJNMGJKCO, Quaternion MBCEPOHNHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x81533A0", Offset = "0x8151DA0", VA = "0x1881533A0")]
		public void SetHatAnchorParameters(JNPBPAOBAGK LAFHHLDCDBJ, AnchorParamsRestrictions MAICANHKGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x814B400", Offset = "0x8149E00", VA = "0x18814B400")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere BMCKFMNFCLB, Transform FJDHIJIMDMH, JNPBPAOBAGK LAFHHLDCDBJ, AnchorParamsRestrictions NOBOKNNHFOJ, [Out] Vector3 GDEEHHOMKPN, [Out] Quaternion IEBOBJIHNAD, [Out] JNPBPAOBAGK MJODLNCFOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8152230", Offset = "0x8150C30", VA = "0x188152230")]
		public void ResetHatAnchor(Vector2 CJJHEPPJNAN, Vector3 MIMOEDOJDPK, Vector3 OCOCOINKGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xBE9740", Offset = "0xBE8140", VA = "0x180BE9740")]
		public GMFBBCOCHKB GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x81493A0", Offset = "0x8147DA0", VA = "0x1881493A0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x81494E0", Offset = "0x8147EE0", VA = "0x1881494E0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8149310", Offset = "0x8147D10", VA = "0x188149310")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8154D50", Offset = "0x8153750", VA = "0x188154D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x814E9A0", Offset = "0x814D3A0", VA = "0x18814E9A0")]
		protected void IELAANJDIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8154B10", Offset = "0x8153510", VA = "0x188154B10")]
		public void SetWaitForUgcTextureLoads(bool DDONLPJNDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8154990", Offset = "0x8153390", VA = "0x188154990")]
		public void SetUgcTextureParameters(NKOKBMFEAOJ HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8155C00", Offset = "0x8154600", VA = "0x188155C00")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8151AE0", Offset = "0x81504E0", VA = "0x188151AE0")]
		[CompilerGenerated]
		private void PHKNBGDCJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8148FC0", Offset = "0x81479C0", VA = "0x188148FC0")]
		[CompilerGenerated]
		private void ADBMDPOEELJ(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8149040", Offset = "0x8147A40", VA = "0x188149040")]
		[CompilerGenerated]
		private void AHKGBMMMFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x81505A0", Offset = "0x814EFA0", VA = "0x1881505A0")]
		[CompilerGenerated]
		private void NAODOONBAEE(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x81514F0", Offset = "0x814FEF0", VA = "0x1881514F0")]
		[CompilerGenerated]
		private void OOEGIPPOMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x814EF20", Offset = "0x814D920", VA = "0x18814EF20")]
		[CompilerGenerated]
		private void JCIPPFCDOBP(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x814CA30", Offset = "0x814B430", VA = "0x18814CA30")]
		[CompilerGenerated]
		private void EPMLDECGNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x814EA70", Offset = "0x814D470", VA = "0x18814EA70")]
		[CompilerGenerated]
		private void IGCHNLMFBBJ(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x814EAC0", Offset = "0x814D4C0", VA = "0x18814EAC0")]
		[CompilerGenerated]
		private void IGDAAFPGKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8150FC0", Offset = "0x814F9C0", VA = "0x188150FC0")]
		[CompilerGenerated]
		private void OGEDFLJACIE(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x814EFC0", Offset = "0x814D9C0", VA = "0x18814EFC0")]
		[CompilerGenerated]
		private void JGJNGFMGCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x814D4D0", Offset = "0x814BED0", VA = "0x18814D4D0")]
		[CompilerGenerated]
		private void GHJBAJBFKEB(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x81507B0", Offset = "0x814F1B0", VA = "0x1881507B0")]
		[CompilerGenerated]
		internal static bool NPMGIICOMON(Transform IDLFDJCOMND, IEnumerable<SkinnedMeshRenderer> IHKAIBEMALA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x814D150", Offset = "0x814BB50", VA = "0x18814D150")]
		[CompilerGenerated]
		private void FLLEFCANGPJ(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x814D490", Offset = "0x814BE90", VA = "0x18814D490")]
		[CompilerGenerated]
		private void GEBBEILNJNM(NIKNHIFAFMB HFGPHHEBAGL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, DFEHPODJAJA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct PFKIGKAHANC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public ALIGCGMOICI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x8160520", Offset = "0x815EF20", VA = "0x188160520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x81607B0", Offset = "0x815F1B0", VA = "0x1881607B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct NEMKCIJPFJA : IAsyncStateMachine
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
			public EAJLGMHEHMA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x815CDD0", Offset = "0x815B7D0", VA = "0x18815CDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x815CFB0", Offset = "0x815B9B0", VA = "0x18815CFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct DBNDNOOPPDM : IAsyncStateMachine
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
			public EAJLGMHEHMA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x8158570", Offset = "0x8156F70", VA = "0x188158570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x8158710", Offset = "0x8157110", VA = "0x188158710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct LDLGEJHLECJ : IAsyncStateMachine
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
			public ALIGCGMOICI avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x815C6E0", Offset = "0x815B0E0", VA = "0x18815C6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x815C890", Offset = "0x815B290", VA = "0x18815C890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct IJJEBBKKMDE : IAsyncStateMachine
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
			public EAJLGMHEHMA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			private TaskAwaiter<ACMIPHPLPBE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x815B530", Offset = "0x8159F30", VA = "0x18815B530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x815B970", Offset = "0x815A370", VA = "0x18815B970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct PAGNJJFCCNL : IAsyncStateMachine
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
			public EAJLGMHEHMA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8160020", Offset = "0x815EA20", VA = "0x188160020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x8160440", Offset = "0x815EE40", VA = "0x188160440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected const float PGGOBBDPIGG = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected const int FCOOJDEKGIJ = 5;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private static readonly int ADBODAABJAF;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private static readonly int OBJBKPFFMKH;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly int IDIOKPHMPJL;

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
		protected static readonly Dictionary<CCLCKMEBCEM.KDAGINOPKID, int> MBOHCCFMADO;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> OINAPBOFGCF;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static readonly int IOCMKKJHDDO;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static readonly int GBAGOCMDEIB;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static readonly int CADMIBMCHHI;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static readonly int NFPHAGOHACA;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static readonly int CAGPPGDFBID;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 IKHAGKLOAMC;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 GGAPMHPGKNI;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected static Vector2 PINECEODLKJ;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected static Vector2 FBBHEHLPIAN;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static Vector2 AMCBMOMLAOE;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected static Vector2 AJLMNLONCDD;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static Vector2 EMENKMDANDD;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static Vector2 LLAHGNCLNHC;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static Vector2 FBEHLEDBJHJ;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static Vector2 PBEILJPKOBC;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static Vector2 EBFJCOGDJMI;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 OHJHEGNMKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[SerializeField]
		[Header("Rendering")]
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
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private EAJLGMHEHMA DFIMJFNCJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private FaceStyleSet MGOEOJMDAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected const int NMEKOCMDFJG = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected int GPIGOMPJGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected int EPGMFHBGNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected int DMODFMFKAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int ACKMECPIEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Vector2 OGNLMNMOKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float OBLNGOHCHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected float AIEFHIHDAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float PLDFBBOGHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected Vector2 GKHNJPHIOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float DFCDKHBNLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected float MGBNEMDJEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected float CPCFAMHFEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Vector2 GDACDMIBJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected float CNFDKKAGIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected float HFDGJFMEEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected float EPIOAGDHKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected Vector2 MJEBDGFCLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float KHGGFAHNFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected float FBMHEILBFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected float GLBJOBKCNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected List<SelectableFaceOption> ILOAOJCDDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected List<SelectableFaceOption> CBDPADJKPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected List<SelectableFaceOption> EANDFAKFNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected List<SelectableFaceOption> LBLCBDLJGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected Coroutine HKPLDMBPPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected int? PGNOJGKFLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected int OKJFKKIBMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected int BCIMBFDPCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected int BAFHEJPBBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected int OPFEPPGINGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected Sprite NAJBDNICIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected Sprite OMNDEPPDKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected Sprite LHEGMAAMIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected Sprite GOBKHCAINHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected bool KNBBOLLPFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected string EFAAFLFNJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected string OOMKLGLIMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected string FODENGMOOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected string FANINALKHLG;

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
		protected AvatarConfiguration IEIIEFANBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		protected ACMIPHPLPBE EFMJLFMAJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private readonly List<Material> BENGDILEKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		protected PFPLHGPNPBJ KKBCDLDAHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		protected Dictionary<string, int> AMCEHCMAALF;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet KAOEDFCJEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8166F30", Offset = "0x8165930", VA = "0x188166F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool HAAHJMNIMKO
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xB216B0", Offset = "0xB200B0", VA = "0x180B216B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xE3B6D0", Offset = "0xE3A0D0", VA = "0x180E3B6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool PKEJEDGMFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool FHDKBMHFJBN
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int AOBLMFOLBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8161150", Offset = "0x815FB50", VA = "0x188161150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer MDMAHKBNECF
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool AHKOLEJFGIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x26C37F0", Offset = "0x26C21F0", VA = "0x1826C37F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x26BAA30", Offset = "0x26B9430", VA = "0x1826BAA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] FHHCEKONNNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool OPLNKHDNHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8166F80", Offset = "0x8165980", VA = "0x188166F80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8167140", Offset = "0x8165B40", VA = "0x188167140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int HLMCDNAIHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8162FD0", Offset = "0x81619D0", VA = "0x188162FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int AIPLDIFOGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8161380", Offset = "0x815FD80", VA = "0x188161380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float MKHGKBJCJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8166F60", Offset = "0x8165960", VA = "0x188166F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8167120", Offset = "0x8165B20", VA = "0x188167120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public ELPBBPMJKFF JPJEDPDEHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xB48290", Offset = "0xB46C90", VA = "0x180B48290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xB45EC0", Offset = "0xB448C0", VA = "0x180B45EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public ACMIPHPLPBE MIKKNAGLCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xB82180", Offset = "0xB80B80", VA = "0x180B82180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x81670A0", Offset = "0x8165AA0", VA = "0x1881670A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption GHEDPAJACCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xB65470", Offset = "0xB63E70", VA = "0x180B65470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xBE9960", Offset = "0xBE8360", VA = "0x180BE9960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected PFPLHGPNPBJ HCCIOPNHFHL
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x8163C80", Offset = "0x8162680", VA = "0x188163C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ADJICPOIDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8166E80", Offset = "0x8165880", VA = "0x188166E80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8166FF0", Offset = "0x81659F0", VA = "0x188166FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8162ED0", Offset = "0x81618D0", VA = "0x188162ED0")]
		public void LocalPlayEmote(CCLCKMEBCEM.KDAGINOPKID ACFNFNFIICN, float DCLDEJHDEBP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8162860", Offset = "0x8161260", VA = "0x188162860")]
		public bool IsEmotePlaying(CCLCKMEBCEM.KDAGINOPKID ACFNFNFIICN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8164DB0", Offset = "0x81637B0", VA = "0x188164DB0")]
		public void SetIdleHappy(bool KIFPJLHFEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x81622B0", Offset = "0x8160CB0", VA = "0x1881622B0")]
		protected void ILBELCIBPKF(bool OLACGGAMEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x81614B0", Offset = "0x815FEB0", VA = "0x1881614B0")]
		protected void FCBCGECCDCD(bool KMCABDEFNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8162980", Offset = "0x8161380", VA = "0x188162980")]
		protected void JCNPCBFIAPE(BEBMGMBEIIO HMKMCCAOOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8162D70", Offset = "0x8161770", VA = "0x188162D70")]
		protected void KJFHCNKPBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8164480", Offset = "0x8162E80", VA = "0x188164480")]
		public void PlayExpression(int AOILHNNOCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x81643C0", Offset = "0x8162DC0", VA = "0x1881643C0")]
		protected void PPGNHGCNBPE(bool PDMMDJGHOKB, bool BAIMDHGBJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8162190", Offset = "0x8160B90", VA = "0x188162190")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType GHEIACCHMMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8162330", Offset = "0x8160D30", VA = "0x188162330")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration IEIIEFANBEC, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8164A50", Offset = "0x8163450", VA = "0x188164A50")]
		[AsyncStateMachine(typeof(PFKIGKAHANC))]
		public Task SetFaceSettings(ALIGCGMOICI OENIAJKILAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x8164B40", Offset = "0x8163540", VA = "0x188164B40")]
		[AsyncStateMachine(typeof(NEMKCIJPFJA))]
		public Task SetFaceSettings(int ANHMAJKENEI, int CPFNBFLDMEH, int COODJDFMLND, int IGJEAJAPHFF, EAJLGMHEHMA LMJNBBKIBMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x8164E30", Offset = "0x8163830", VA = "0x188164E30")]
		[AsyncStateMachine(typeof(DBNDNOOPPDM))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType GHEIACCHMMJ, int HPNCCBFLIPG, EAJLGMHEHMA LMJNBBKIBMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8163B00", Offset = "0x8162500", VA = "0x188163B00")]
		protected void NKJAEHFDFFK(FaceFeatureType GHEIACCHMMJ, ALMOMBBBFFN MIKJMOIJGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8161610", Offset = "0x8160010", VA = "0x188161610")]
		protected void FKPDCIFPDFE(FaceFeatureType GHEIACCHMMJ, int HPNCCBFLIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x8161FB0", Offset = "0x81609B0", VA = "0x188161FB0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8162C80", Offset = "0x8161680", VA = "0x188162C80")]
		[AsyncStateMachine(typeof(LDLGEJHLECJ))]
		protected Task JGNNJGDPFLI(ALIGCGMOICI OENIAJKILAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x81640C0", Offset = "0x8162AC0", VA = "0x1881640C0")]
		protected void PCPGILNLIJF(ALIGCGMOICI OENIAJKILAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8160FB0", Offset = "0x815F9B0", VA = "0x188160FB0")]
		protected static void BCPIOJIOBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x81629F0", Offset = "0x81613F0", VA = "0x1881629F0")]
		private void JGNCJJFEPAI(bool CAIKOIBCEFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8163030", Offset = "0x8161A30", VA = "0x188163030")]
		protected void NEEMEKKNCGH(FaceFeatureType GHEIACCHMMJ, Vector2 CJOAPJOBLHB, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x81644A0", Offset = "0x8162EA0", VA = "0x1881644A0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType GHEIACCHMMJ, Vector2 ECBMAIFLDLN, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8161D50", Offset = "0x8160750", VA = "0x188161D50")]
		protected void GAPPDAIMOBD(FaceFeatureType GHEIACCHMMJ, float JGELECMMAKP, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8160E30", Offset = "0x815F830", VA = "0x188160E30")]
		protected void BCNMPDHKEGG(FaceFeatureType GHEIACCHMMJ, float JCDLBIBEGAF, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x81613E0", Offset = "0x815FDE0", VA = "0x1881613E0")]
		protected void EHAIHMLAOKB(FaceFeatureType GHEIACCHMMJ, float COPCMABMCKC, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8164830", Offset = "0x8163230", VA = "0x188164830")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType GHEIACCHMMJ, float OCPHAOIDCAE, EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8161ED0", Offset = "0x81608D0", VA = "0x188161ED0")]
		[AsyncStateMachine(typeof(IJJEBBKKMDE))]
		protected Task GJBJLBDBHNP(EAJLGMHEHMA LMJNBBKIBMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8162650", Offset = "0x8161050", VA = "0x188162650")]
		public void InitializeFaceFeatureStyleSet(EAJLGMHEHMA LMJNBBKIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x81621D0", Offset = "0x8160BD0", VA = "0x1881621D0")]
		protected bool IKECIJJKNIE(string AGKDLPCACBM, [Out] int FILGHJLFKAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8160CF0", Offset = "0x815F6F0", VA = "0x188160CF0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8164F40", Offset = "0x8163940", VA = "0x188164F40", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8163EB0", Offset = "0x81628B0", VA = "0x188163EB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8165F30", Offset = "0x8164930", VA = "0x188165F30")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8161280", Offset = "0x815FC80", VA = "0x188161280")]
		[AsyncStateMachine(typeof(PAGNJJFCCNL))]
		public Task BuildFaceStyleAsyncIfChanged(EAJLGMHEHMA LMJNBBKIBMJ, bool HMOLJENJODI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8165840", Offset = "0x8164240", VA = "0x188165840")]
		public void UpdateFaceDisplays(bool GICLJFMLKCL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x81633C0", Offset = "0x8161DC0", VA = "0x1881633C0")]
		protected bool NHKMEMOOINO(bool GICLJFMLKCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x81655A0", Offset = "0x8163FA0", VA = "0x1881655A0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8164C70", Offset = "0x8163670", VA = "0x188164C70")]
		public void SetFaceSpriteIndices(string MCLGHNNOPDN, string PNIKMMLGDMO, string AFKGPEHHKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8164F50", Offset = "0x8163950", VA = "0x188164F50")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8165A60", Offset = "0x8164460", VA = "0x188165A60")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8165C50", Offset = "0x8164650", VA = "0x188165C50")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8162DE0", Offset = "0x81617E0", VA = "0x188162DE0")]
		protected void LNLDHAMBOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8160A40", Offset = "0x815F440", VA = "0x188160A40")]
		private void ALPPAIIAMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8163D00", Offset = "0x8162700", VA = "0x188163D00")]
		private void OPONEHGFLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8166C20", Offset = "0x8165620", VA = "0x188166C20")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "4")]
		private bool OELMCBECINB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct ONIJOEGDLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public string FAHMGKIDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public int BIKKNIIFDAP;
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
		private struct DNNHJIPFHJP : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x8158770", Offset = "0x8157170", VA = "0x188158770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct EPAFLGJJAPN : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x81596A0", Offset = "0x81580A0", VA = "0x1881596A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8159BA0", Offset = "0x81585A0", VA = "0x188159BA0", Slot = "5")]
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
		public EAJLGMHEHMA avatarBodyType;

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
		public DAOAHDPCGLG useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public JNPBPAOBAGK hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GMFBBCOCHKB HatAnchorRestrictions;

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
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private LAKPIFGCJOG HEGCEKNIMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[SerializeField]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private AnimatorOverrideController KPLFEIPANLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> LCEAGADENKJ;

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
		public readonly ONIJOEGDLMB[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public readonly (string, GCPPKJEFDIG)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		protected bool ABCPPNJCCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		protected Guid KBFGJPNAHFK;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		protected static Guid LPGBBNJCEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private POODIKIDKFI DILJMENJHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private ELPBBPMJKFF EMNOBGHLNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private JPICLCPJPKE ODNJPJMHLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private JPICLCPJPKE IPBCHDGFNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private AdditionalHatData HAIDNMPCLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private readonly Dictionary<GameObject, KOGDPHEMGGM> KFFAHLILLAA;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<GIJEHNOOKLE> IBBIOIEOENC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x816C330", Offset = "0x816AD30", VA = "0x18816C330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x816C970", Offset = "0x816B370", VA = "0x18816C970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool HNEGJIPGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x816C490", Offset = "0x816AE90", VA = "0x18816C490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool PEDBHMIMGJD
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x816C380", Offset = "0x816AD80", VA = "0x18816C380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase MJEBNGAFHPL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDA370", VA = "0x180BDB970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid OHLLILMLHHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x81683B0", Offset = "0x8166DB0", VA = "0x1881683B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, BEBMGMBEIIO)[] EJLJBEEDJEL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x816C5A0", Offset = "0x816AFA0", VA = "0x18816C5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x816A010", Offset = "0x8168A10", VA = "0x18816A010")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8168F60", Offset = "0x8167960", VA = "0x188168F60")]
		private IEnumerable<GameObject> KHKBEIPIFDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x816A530", Offset = "0x8168F30", VA = "0x18816A530")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x81678B0", Offset = "0x81662B0", VA = "0x1881678B0")]
		private void BEMEKFGINHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x14FBD30", Offset = "0x14FA730", VA = "0x1814FBD30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8168550", Offset = "0x8166F50", VA = "0x188168550")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x816A540", Offset = "0x8168F40", VA = "0x18816A540")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x816A350", Offset = "0x8168D50", VA = "0x18816A350")]
		public void ShowPose(AnimationClip DBMAHIKFILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x816A500", Offset = "0x8168F00", VA = "0x18816A500")]
		public void ShowPose(string CBKCMNNPKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x816A180", Offset = "0x8168B80", VA = "0x18816A180")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x816A020", Offset = "0x8168A20", VA = "0x18816A020")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x816B010", Offset = "0x8169A10", VA = "0x18816B010")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x816AE60", Offset = "0x8169860", VA = "0x18816AE60")]
		public void UpdateFaceAndBodyShapes(bool HMOLJENJODI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x816B420", Offset = "0x8169E20", VA = "0x18816B420")]
		public void UpdateNoseShape(BALOCJGIMAO HLHJKHFOCLF, bool HMOLJENJODI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x816B3F0", Offset = "0x8169DF0", VA = "0x18816B3F0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8168C50", Offset = "0x8167650", VA = "0x188168C50", Slot = "4")]
		protected virtual void JONLACACLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8168140", Offset = "0x8166B40", VA = "0x188168140", Slot = "5")]
		protected virtual void CAFLIOMLFDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8167450", Offset = "0x8165E50", VA = "0x188167450")]
		public void ApplyHatData(AdditionalHatData DLHHFHAMPIG, bool NHCOBDDICBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8167290", Offset = "0x8165C90", VA = "0x188167290")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x81677B0", Offset = "0x81661B0", VA = "0x1881677B0")]
		public void ApplyHatUVOverride(Vector2 ENOMKNEJDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x81676D0", Offset = "0x81660D0", VA = "0x1881676D0")]
		public void ApplyHatPositionAdjustment(Vector3 HDJKCAOINEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8167740", Offset = "0x8166140", VA = "0x188167740")]
		public void ApplyHatRotationAdjustment(Vector3 MPJGDEKMOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8167A70", Offset = "0x8166470", VA = "0x188167A70")]
		public LCNONGDOOKP BuildAvatarItemSelection(GameObject HNLIHPBHPHI, EAJLGMHEHMA ILBCCMEBABC, BEBMGMBEIIO DGMDJMAFLHN)
		{
			return default(LCNONGDOOKP);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8167B10", Offset = "0x8166510", VA = "0x188167B10")]
		public void BuildAvatar(bool HMOLJENJODI = false, bool NHCOBDDICBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x816A8A0", Offset = "0x81692A0", VA = "0x18816A8A0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x81673D0", Offset = "0x8165DD0", VA = "0x1881673D0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x816B240", Offset = "0x8169C40", VA = "0x18816B240")]
		public void UpdateHatAnchor(bool NHCOBDDICBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x816AF60", Offset = "0x8169960", VA = "0x18816AF60")]
		[AsyncStateMachine(typeof(DNNHJIPFHJP))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8169C70", Offset = "0x8168670", VA = "0x188169C70")]
		[AsyncStateMachine(typeof(EPAFLGJJAPN))]
		private Task OHCLGPDGKND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x8169D40", Offset = "0x8168740", VA = "0x188169D40")]
		private void OIHKEFLNMKM(FaceFeatureType NJDKDEBMHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8167820", Offset = "0x8166220", VA = "0x188167820")]
		private void BCHNMBEDCCB(FaceFeatureType NJDKDEBMHAP, [Out] float KPIAGHIPGIF, [Out] float MFMAOMFPOAO, [Out] float DILGPPEHCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x816AD20", Offset = "0x8169720", VA = "0x18816AD20")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x816B0A0", Offset = "0x8169AA0", VA = "0x18816B0A0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8169750", Offset = "0x8168150", VA = "0x188169750")]
		private void OBMDIPIMFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		private void IBBMHHKBMLK(KOGDPHEMGGM NLAKGFHHLCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		private void KINJILPLBAE(KOGDPHEMGGM NLAKGFHHLCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x81693D0", Offset = "0x8167DD0", VA = "0x1881693D0")]
		private void LGDNEEMEICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x816B4B0", Offset = "0x8169EB0", VA = "0x18816B4B0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x81684A0", Offset = "0x8166EA0", VA = "0x1881684A0")]
		[CompilerGenerated]
		private LCNONGDOOKP GGNFOFDKDBL((GameObject, BEBMGMBEIIO) EAMBFCCKGIE)
		{
			return default(LCNONGDOOKP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct LCNONGDOOKP
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class MOGCHKFDJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MOGCHKFDJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x815CD50", Offset = "0x815B750", VA = "0x18815CD50")]
		internal bool LKDOKDOGKIN(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private KOGDPHEMGGM CACMKCKFAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private BEBMGMBEIIO IPLHIADPICG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public KOGDPHEMGGM HNECDENNDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public BEBMGMBEIIO IALOGONDFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE765D0", Offset = "0xE74FD0", VA = "0x180E765D0")]
		get
		{
			return default(BEBMGMBEIIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string BNKJJMGGNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x815C330", Offset = "0x815AD30", VA = "0x18815C330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool IKDLFLCMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x815C070", Offset = "0x815AA70", VA = "0x18815C070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool ABPGJADIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x815C020", Offset = "0x815AA20", VA = "0x18815C020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1A64500", Offset = "0x1A62F00", VA = "0x181A64500")]
	public LCNONGDOOKP(KOGDPHEMGGM NLAKGFHHLCA, BEBMGMBEIIO HMKMCCAOOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x815C420", Offset = "0x815AE20", VA = "0x18815C420")]
	public bool NNIHAMFLIMP(OutfitType KFCIFPGKBGB, BEBMGMBEIIO OBMMLJDLFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x815C0C0", Offset = "0x815AAC0", VA = "0x18815C0C0")]
	public bool IOOHHJJMHMK(OutfitType KFCIFPGKBGB, BEBMGMBEIIO OBMMLJDLFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x815C4F0", Offset = "0x815AEF0", VA = "0x18815C4F0")]
	public bool PJCNMENCPMA(LCNONGDOOKP NCKJOPEEDGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class INPKJPEBCAP
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class PDDBEILAMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PDDBEILAMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x81604A0", Offset = "0x815EEA0", VA = "0x1881604A0")]
		internal bool LKDOKDOGKIN(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private KOGDPHEMGGM CACMKCKFAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private OELHEAEDEKH IPLHIADPICG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public KOGDPHEMGGM HNECDENNDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public OELHEAEDEKH IALOGONDFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
		get
		{
			return default(OELHEAEDEKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color CALPOELKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE3CED0", Offset = "0xE3B8D0", VA = "0x180E3CED0")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE3CD50", Offset = "0xE3B750", VA = "0x180E3CD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 MBCEPOHNHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE74430", Offset = "0xE72E30", VA = "0x180E74430")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE74570", Offset = "0xE72F70", VA = "0x180E74570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x815BB00", Offset = "0x815A500", VA = "0x18815BB00")]
	public INPKJPEBCAP(KOGDPHEMGGM NLAKGFHHLCA, OELHEAEDEKH HMKMCCAOOLE, Color EDNHAEBPHJD, Vector3 JCDLBIBEGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x815B9D0", Offset = "0x815A3D0", VA = "0x18815B9D0")]
	public bool PJCNMENCPMA(INPKJPEBCAP NCKJOPEEDGC)
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
