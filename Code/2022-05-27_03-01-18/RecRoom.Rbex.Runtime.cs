using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal sealed class BLDIODNEAOB : DACPDMBGPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CollisionDetectionMode PINLLAKELAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D570", Offset = "0x4C2C570", VA = "0x184C2D570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CollisionDetectionMode JAMHBLMPMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D890", Offset = "0x4C2C890", VA = "0x184C2D890", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D590", Offset = "0x4C2C590", VA = "0x184C2D590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A0", Offset = "0x74D8A0", VA = "0x18074E8A0")]
	public BLDIODNEAOB(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D7D0", Offset = "0x4C2C7D0", VA = "0x184C2D7D0", Slot = "6")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D4F0", Offset = "0x4C2C4F0", VA = "0x184C2D4F0", Slot = "9")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D7C0", Offset = "0x4C2C7C0", VA = "0x184C2D7C0", Slot = "7")]
	public void LGAGNBHFCAA(bool HJEABJADGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D880", Offset = "0x4C2C880", VA = "0x184C2D880", Slot = "8")]
	public void PDMJDAAAJBO(bool HJEABJADGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D6C0", Offset = "0x4C2C6C0", VA = "0x184C2D6C0", Slot = "10")]
	public bool GHEBCMCFGJO(Vector3 KPOIJLOIPHI, out RaycastHit KKEBIOGHELE, float NFELGDCJCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D600", Offset = "0x4C2C600", VA = "0x184C2D600")]
	private void GAOPODFPNNO(bool HJEABJADGML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal sealed class JEKKAELLOGE : BKFGHNIFDHH, IDisposable, LFLPBCCFHNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const int MNDHCLKJNLH = 350;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static global::MCGJMOJJLCM<JEKKAELLOGE> JLFIAKCBMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LLPLNOLCMOF CPDFHFAKJFA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LLPLNOLCMOF FIAMHFGMOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4C34750", Offset = "0x4C33750", VA = "0x184C34750", Slot = "6")]
		get
		{
			return default(LLPLNOLCMOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4C345A0", Offset = "0x4C335A0", VA = "0x184C345A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Transform BKIDHFGJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4C34680", Offset = "0x4C33680", VA = "0x184C34680", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BPMBKPKAHEP, BPMBKPKAHEP> DGPPKIECLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4C34500", Offset = "0x4C33500", VA = "0x184C34500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C346B0", Offset = "0x4C336B0", VA = "0x184C346B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C34B50", Offset = "0x4C33B50", VA = "0x184C34B50")]
	public JEKKAELLOGE(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C34840", Offset = "0x4C33840", VA = "0x184C34840", Slot = "8")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C34440", Offset = "0x4C33440", VA = "0x184C34440", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C343E0", Offset = "0x4C333E0", VA = "0x184C343E0", Slot = "11")]
	private void BELACKPDNIF(BPMBKPKAHEP DAMCPPPOBFG, BPMBKPKAHEP NIFLHKLJENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "12")]
	private void HCJICOHKLJO(bool HFAAMFMLEIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FFBPMIOHDFK : GCEGDENAHGA
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FA30", Offset = "0x4C2EA30", VA = "0x184C2FA30", Slot = "4")]
	public CPFCAKAKMGE NBKKFOMJBLM(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FB00", Offset = "0x4C2EB00", VA = "0x184C2FB00", Slot = "5")]
	public BKIDOPKLFIH OABPHAJBKEJ(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F3A0", Offset = "0x4C2E3A0", VA = "0x184C2F3A0", Slot = "6")]
	public HCOHFMJCLEO DCIPAGNNKNI(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F650", Offset = "0x4C2E650", VA = "0x184C2F650", Slot = "7")]
	public EJENCAPKIPE HGGDNPLIDHJ(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F6C0", Offset = "0x4C2E6C0", VA = "0x184C2F6C0", Slot = "8")]
	public CFOJFFJAHMJ JKOIHMCKLEI(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F790", Offset = "0x4C2E790", VA = "0x184C2F790", Slot = "9")]
	public BKFGHNIFDHH KMDMBENJGCB(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FBC0", Offset = "0x4C2EBC0", VA = "0x184C2FBC0", Slot = "10")]
	public JLADLEKBDPF PMALGINGEGA(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F730", Offset = "0x4C2E730", VA = "0x184C2F730", Slot = "11")]
	public MMNFEMPELFO JLGILMOOOBN(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F4B0", Offset = "0x4C2E4B0", VA = "0x184C2F4B0", Slot = "12")]
	public DACPDMBGPPJ FKOKIEGEEAO(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F450", Offset = "0x4C2E450", VA = "0x184C2F450", Slot = "13")]
	public BGJFFHEKMNC FHGGOFGEPPD(AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F960", Offset = "0x4C2E960", VA = "0x184C2F960")]
	public IFLELGHIJNH LLBDCCGKPFL(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F800", Offset = "0x4C2E800", VA = "0x184C2F800")]
	public BMDLBHMMNBF LADOHFCPHFK(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F510", Offset = "0x4C2E510", VA = "0x184C2F510")]
	public MNBONILMFGF KNBMNEGGIFJ(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F880", Offset = "0x4C2E880", VA = "0x184C2F880")]
	public CNLFLFCLBLJ LKPHMMGDCIP(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F5D0", Offset = "0x4C2E5D0", VA = "0x184C2F5D0")]
	public OMONPNPPGCB GBHANFKIONJ(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public FFBPMIOHDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F960", Offset = "0x4C2E960", VA = "0x184C2F960", Slot = "14")]
	private IFLELGHIJNH PDAIPHJMDMF(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F800", Offset = "0x4C2E800", VA = "0x184C2F800", Slot = "15")]
	private BMDLBHMMNBF OIKAFJBLLFM(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F510", Offset = "0x4C2E510", VA = "0x184C2F510", Slot = "16")]
	private MNBONILMFGF FLPELKLBDDL(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F880", Offset = "0x4C2E880", VA = "0x184C2F880", Slot = "17")]
	private CNLFLFCLBLJ OICLLLHFNAG(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F5D0", Offset = "0x4C2E5D0", VA = "0x184C2F5D0", Slot = "18")]
	private OMONPNPPGCB OFNKBIEGOIF(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class KGGPMJHBEBI : MMNFEMPELFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D570", Offset = "0x4C2C570", VA = "0x184C2D570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GAPABACMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4C36750", Offset = "0x4C35750", VA = "0x184C36750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PJEDPGIPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4C36BD0", Offset = "0x4C35BD0", VA = "0x184C36BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private AEIBLGMLJHO ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4C367A0", Offset = "0x4C357A0", VA = "0x184C367A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A0", Offset = "0x74D8A0", VA = "0x18074E8A0")]
	public KGGPMJHBEBI(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C36C30", Offset = "0x4C35C30", VA = "0x184C36C30", Slot = "4")]
	public void OFBKEPKKEAA(Vector3 LLLNICPNHJM, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C367F0", Offset = "0x4C357F0", VA = "0x184C367F0")]
	private void IMBKFDOJFCJ(Vector3 LLLNICPNHJM, ForceMode MNFPKFEPHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4C36D80", Offset = "0x4C35D80", VA = "0x184C36D80", Slot = "5")]
	public void OGNIENPHKHC(Vector3 LLLNICPNHJM, Vector3 MMBOHLJHNFP, ForceMode MNFPKFEPHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C36410", Offset = "0x4C35410", VA = "0x184C36410", Slot = "6")]
	public void ALJAACHOFOH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C36560", Offset = "0x4C35560", VA = "0x184C36560")]
	private void CAEPEJPNAFG(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4C369E0", Offset = "0x4C359E0", VA = "0x184C369E0", Slot = "7")]
	public void MLHINKACOKH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal sealed class FBOJDFIKBAL : BGJFFHEKMNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool FMKFLFKHCHK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FECOABKLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D5110", Offset = "0x7D4110", VA = "0x1807D5110", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F280", Offset = "0x4C2E280", VA = "0x184C2F280", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A0", Offset = "0x74D8A0", VA = "0x18074E8A0")]
	public FBOJDFIKBAL(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F250", Offset = "0x4C2E250", VA = "0x184C2F250", Slot = "6")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F330", Offset = "0x4C2E330", VA = "0x184C2F330", Slot = "7")]
	public void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal sealed class BNBCMDMAMLN : CPFCAKAKMGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly List<AEIBLGMLJHO> MIHDIFPIMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private AEIBLGMLJHO PFOHKHPLBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private AEIBLGMLJHO COLFLONKFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Transform CNFAIADKFIF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Transform DNMPFDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DF10", Offset = "0x4C2CF10", VA = "0x184C2DF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AEIBLGMLJHO ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB40", Offset = "0x5A9B40", VA = "0x1805AAB40", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DB40", Offset = "0x4C2CB40", VA = "0x184C2DB40", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AEIBLGMLJHO MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5AAD40", Offset = "0x5A9D40", VA = "0x1805AAD40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IReadOnlyList<AEIBLGMLJHO> BOKHLLHODJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A20", Offset = "0x5B0A20", VA = "0x1805B1A20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NJBFGGDILLL CHEJJFMAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DB50", Offset = "0x4C2CB50", VA = "0x184C2DB50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2E2E0", Offset = "0x4C2D2E0", VA = "0x184C2E2E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NJBFGGDILLL ELHEEPAJOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EC50", Offset = "0x4C2DC50", VA = "0x184C2EC50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DF40", Offset = "0x4C2CF40", VA = "0x184C2DF40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FNMMNACHGCD NCCHIGBNHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EBB0", Offset = "0x4C2DBB0", VA = "0x184C2EBB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4C2E1A0", Offset = "0x4C2D1A0", VA = "0x184C2E1A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action IJGBHBCENDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DAA0", Offset = "0x4C2CAA0", VA = "0x184C2DAA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F080", Offset = "0x4C2E080", VA = "0x184C2F080", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action JEBMHBGOGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DFE0", Offset = "0x4C2CFE0", VA = "0x184C2DFE0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EF50", Offset = "0x4C2DF50", VA = "0x184C2EF50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<AEIBLGMLJHO> KEEFFJAAPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4C2E240", Offset = "0x4C2D240", VA = "0x184C2E240", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EB10", Offset = "0x4C2DB10", VA = "0x184C2EB10", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<AEIBLGMLJHO> NBINHOIEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4C2ECF0", Offset = "0x4C2DCF0", VA = "0x184C2ECF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DD50", Offset = "0x4C2CD50", VA = "0x184C2DD50", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action DDJABKLJDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4C2E080", Offset = "0x4C2D080", VA = "0x184C2E080", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4C2DE70", Offset = "0x4C2CE70", VA = "0x184C2DE70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<AEIBLGMLJHO> DNPOGDIOMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EE10", Offset = "0x4C2DE10", VA = "0x184C2EE10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2EEB0", Offset = "0x4C2DEB0", VA = "0x184C2EEB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F1B0", Offset = "0x4C2E1B0", VA = "0x184C2F1B0")]
	public BNBCMDMAMLN(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2E120", Offset = "0x4C2D120", VA = "0x184C2E120", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4C2E380", Offset = "0x4C2D380", VA = "0x184C2E380", Slot = "26")]
	public void FBBBMCEDGND(AEIBLGMLJHO GLGDDCPCPHI, bool ICDGPDEJIFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DBF0", Offset = "0x4C2CBF0", VA = "0x184C2DBF0")]
	private void BEJGPGDHLPC(AEIBLGMLJHO POFIMHOJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D930", Offset = "0x4C2C930", VA = "0x184C2D930")]
	private void AHLLAADOACG(AEIBLGMLJHO POFIMHOJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EFF0", Offset = "0x4C2DFF0", VA = "0x184C2EFF0")]
	private void PIKGIEPOAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EAD0", Offset = "0x4C2DAD0", VA = "0x184C2EAD0")]
	private void KBJIHJPGHDD(AEIBLGMLJHO POFIMHOJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EA30", Offset = "0x4C2DA30", VA = "0x184C2EA30")]
	private void JCKLOIMIJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4C2E890", Offset = "0x4C2D890", VA = "0x184C2E890")]
	private void FBLNLLFDGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2E940", Offset = "0x4C2D940", VA = "0x184C2E940")]
	private void FIHMAOBADMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2ED90", Offset = "0x4C2DD90", VA = "0x184C2ED90")]
	private void MLADKEOGKBF(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DDF0", Offset = "0x4C2CDF0", VA = "0x184C2DDF0")]
	private void BOBAGBKIAFM(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F120", Offset = "0x4C2E120", VA = "0x184C2F120")]
	[CompilerGenerated]
	private object PLFBABFIIGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class PPNGCDFIMKK
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A450", Offset = "0x4C39450", VA = "0x184C3A450")]
	public static BNBCMDMAMLN NDKKBKHHFGO(this AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal sealed class KEIGKGMDKJK : HCOHFMJCLEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly global::AJNMEGICPOE<AEIBLGMLJHO> PMAFIOKJDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool BGIHANGMPGF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 PBGBIPKCOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4C362E0", Offset = "0x4C352E0", VA = "0x184C362E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 EAMFHHDGJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4C35E20", Offset = "0x4C34E20", VA = "0x184C35E20", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Vector3 CFJIGACBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4C36200", Offset = "0x4C35200", VA = "0x184C36200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private AEIBLGMLJHO LILPNPMALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4C36150", Offset = "0x4C35150", VA = "0x184C36150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4C36380", Offset = "0x4C35380", VA = "0x184C36380")]
	public KEIGKGMDKJK(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4C36310", Offset = "0x4C35310", VA = "0x184C36310", Slot = "6")]
	public void PGAANOHAHKD(AEIBLGMLJHO COLFLONKFJK, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4C35B20", Offset = "0x4C34B20", VA = "0x184C35B20", Slot = "7")]
	public void CFGNFHGKJFM(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C35B80", Offset = "0x4C34B80", VA = "0x184C35B80")]
	private Vector3 FIPKBEPLDID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C35870", Offset = "0x4C34870", VA = "0x184C35870")]
	private void ACCCKPCNBBA(AEIBLGMLJHO LHFBIMIDGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class JONDLKCPBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C35810", Offset = "0x4C34810", VA = "0x184C35810")]
	public static KEIGKGMDKJK AGJLCNEBJMM(this AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal sealed class OPOLLPLPGOI : CNLFLFCLBLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OverridableVector3 LELJLHBIFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OverridableVector3 DLJHICNIEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private float CNBOEEAGALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float EHMGJOGOHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 HPAALLLKFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Vector3? BGIAEEPDMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Quaternion? JEJPLMDBAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool APPOPAEPIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private bool JNDIFPAEGII;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 ANELBGALDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xFC9990", Offset = "0xFC8990", VA = "0x180FC9990", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4C38A50", Offset = "0x4C37A50", VA = "0x184C38A50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 KLLJAJEBCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4C38980", Offset = "0x4C37980", VA = "0x184C38980", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float FMCFFGEPOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA38840", Offset = "0xA37840", VA = "0x180A38840", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C384A0", Offset = "0x4C374A0", VA = "0x184C384A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float KCBHEIFILHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC29BC0", Offset = "0xC28BC0", VA = "0x180C29BC0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4C381D0", Offset = "0x4C371D0", VA = "0x184C381D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 APKAFFDMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4C38020", Offset = "0x4C37020", VA = "0x184C38020", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C397E0", Offset = "0x4C387E0", VA = "0x184C397E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Quaternion BOFLKLGKLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C383A0", Offset = "0x4C373A0", VA = "0x184C383A0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4C38860", Offset = "0x4C37860", VA = "0x184C38860", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C920", Offset = "0x4C2B920", VA = "0x184C2C920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event NJBFGGDILLL GMCPGGLGIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4C381F0", Offset = "0x4C371F0", VA = "0x184C381F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4C38130", Offset = "0x4C37130", VA = "0x184C38130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4C39DA0", Offset = "0x4C38DA0", VA = "0x184C39DA0")]
	public OPOLLPLPGOI(AEIBLGMLJHO ODADBIKNJND, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C39A60", Offset = "0x4C38A60", VA = "0x184C39A60", Slot = "17")]
	public void OHOKLBPGIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4C39630", Offset = "0x4C38630", VA = "0x184C39630", Slot = "16")]
	public void KBLHPHBMFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C37FB0", Offset = "0x4C36FB0", VA = "0x184C37FB0", Slot = "19")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4C39B60", Offset = "0x4C38B60", VA = "0x184C39B60", Slot = "20")]
	public void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4C39900", Offset = "0x4C38900", VA = "0x184C39900", Slot = "18")]
	public void NELMFEMAOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4C38560", Offset = "0x4C37560", VA = "0x184C38560", Slot = "21")]
	public void FBOEBNMIJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4C38A50", Offset = "0x4C37A50", VA = "0x184C38A50")]
	private void PBKIICFAJPD(Vector3 MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C39990", Offset = "0x4C38990", VA = "0x184C39990")]
	private Vector3 NKDNMKINPBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4C384A0", Offset = "0x4C374A0", VA = "0x184C384A0")]
	private void FAENGLFGKCC(float MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C381D0", Offset = "0x4C371D0", VA = "0x184C381D0")]
	private void BNKOENPBEOJ(float MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4C38290", Offset = "0x4C37290", VA = "0x184C38290")]
	private Vector3 DFIDHHBJGKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4C397E0", Offset = "0x4C387E0", VA = "0x184C397E0")]
	private void NDBHIKEOGEG(Vector3 MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C396E0", Offset = "0x4C386E0", VA = "0x184C396E0")]
	private Quaternion KBNKPJLONJN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4C38860", Offset = "0x4C37860", VA = "0x184C38860")]
	private void HPHMDAKGODP(Quaternion MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C38A70", Offset = "0x4C37A70", VA = "0x184C38A70")]
	private void JHJDAOKPHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C38AD0", Offset = "0x4C37AD0", VA = "0x184C38AD0")]
	private (float, Vector3) JHJDAOKPHJB(Rigidbody NNFDFIIIKEG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class HFCEECBNMFA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4C30AC0", Offset = "0x4C2FAC0", VA = "0x184C30AC0")]
	public static OPOLLPLPGOI GNNJFLGNEHL(this AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class PBKODCGGCOF : MNBONILMFGF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string BBPLLKBOOEC = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HEFIGJJHMHM CADIMCNMJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CEACPNGPPAA GNAONFGGOGG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MPJPOIIEDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x27FCFA0", Offset = "0x27FBFA0", VA = "0x1827FCFA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CEACPNGPPAA JJAAGIFGIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5AA1A0", Offset = "0x5A91A0", VA = "0x1805AA1A0", Slot = "5")]
		get
		{
			return default(CEACPNGPPAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A350", Offset = "0x4C39350", VA = "0x184C3A350")]
	public PBKODCGGCOF(AEIBLGMLJHO ODADBIKNJND, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A180", Offset = "0x4C39180", VA = "0x184C3A180", Slot = "6")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C39E60", Offset = "0x4C38E60", VA = "0x184C39E60")]
	private bool CEJGDHJLDED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A230", Offset = "0x4C39230", VA = "0x184C3A230", Slot = "7")]
	public void NNJOFJMIFIO(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A150", Offset = "0x4C39150", VA = "0x184C3A150", Slot = "8")]
	public void LHCNGBFPAGE(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A040", Offset = "0x4C39040", VA = "0x184C3A040", Slot = "11")]
	public void KDJFIBHOFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A260", Offset = "0x4C39260", VA = "0x184C3A260")]
	private void OGJPBJPBIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4C39EE0", Offset = "0x4C38EE0", VA = "0x184C39EE0")]
	private void FOEINMMDBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A000", Offset = "0x4C39000", VA = "0x184C3A000", Slot = "10")]
	public void IHLDDFKLKNI(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4C39FC0", Offset = "0x4C38FC0", VA = "0x184C39FC0", Slot = "9")]
	public void HBNGEJGNNKF(AEIBLGMLJHO ODADBIKNJND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal sealed class GPMEFEIFJLI : JLADLEKBDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly HEFIGJJHMHM GLAANCJMNDH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool GAPABACMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4C30660", Offset = "0x4C2F660", VA = "0x184C30660", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HEFIGJJHMHM ICKPNMGKCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event NJBFGGDILLL PBBADIGNAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4C308C0", Offset = "0x4C2F8C0", VA = "0x184C308C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4C30960", Offset = "0x4C2F960", VA = "0x184C30960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4C30A40", Offset = "0x4C2FA40", VA = "0x184C30A40")]
	public GPMEFEIFJLI(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4C306F0", Offset = "0x4C2F6F0", VA = "0x184C306F0", Slot = "11")]
	public IDisposable DNIKOMBPJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C308B0", Offset = "0x4C2F8B0", VA = "0x184C308B0", Slot = "8")]
	public void FCLOEGJOFID(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C30A00", Offset = "0x4C2FA00", VA = "0x184C30A00", Slot = "9")]
	public void IANCHMPKOOJ(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4C307B0", Offset = "0x4C2F7B0", VA = "0x184C307B0", Slot = "10")]
	public void EMOEBLKBOKN(object GJGFJFLAGKH, bool HIFDCGBPAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4C305E0", Offset = "0x4C2F5E0", VA = "0x184C305E0", Slot = "12")]
	public void ABIFPODBGBO(Rigidbody JAMHIIPJAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4C30A10", Offset = "0x4C2FA10", VA = "0x184C30A10", Slot = "13")]
	public void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class JKKFALAGDPE : BMDLBHMMNBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PhotonView EIEAMNMLFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PMJKMJIEKHB;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool AFGNPOLAKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4C35340", Offset = "0x4C34340", VA = "0x184C35340", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GPIKFDFPDME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C03E0", Offset = "0x6BF3E0", VA = "0x1806C03E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event NJBFGGDILLL CLPLJFHLIAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C35120", Offset = "0x4C34120", VA = "0x184C35120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4C351C0", Offset = "0x4C341C0", VA = "0x184C351C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4C357C0", Offset = "0x4C347C0", VA = "0x184C357C0")]
	public JKKFALAGDPE(AEIBLGMLJHO ODADBIKNJND, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C356A0", Offset = "0x4C346A0", VA = "0x184C356A0", Slot = "8")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4C35260", Offset = "0x4C34260", VA = "0x184C35260", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C34F90", Offset = "0x4C33F90", VA = "0x184C34F90", Slot = "9")]
	public void CFKPHJEGAEL(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C35510", Offset = "0x4C34510", VA = "0x184C35510", Slot = "10")]
	public void MFDLLPODPJE(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C35360", Offset = "0x4C34360", VA = "0x184C35360")]
	private void FLPDOHOGGBG(PhotonView BNCCAJIBBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C34B90", Offset = "0x4C33B90", VA = "0x184C34B90")]
	private void APFCIHPFJLK(RigidbodyEx LLNAFONBCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4C34CA0", Offset = "0x4C33CA0", VA = "0x184C34CA0")]
	private void BFBJAPOGHBA(PhotonView LLIHJHKILDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class PDLGLHMIJMB
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4C3A3F0", Offset = "0x4C393F0", VA = "0x184C3A3F0")]
	public static JKKFALAGDPE CFDAJAGOOKI(this AEIBLGMLJHO LJPBABKCCCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KJNPAPOOLKM : OMONPNPPGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RigidbodyConstraints LPIINFMLBFE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DPIBCLGFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAF2CF0", Offset = "0xAF1CF0", VA = "0x180AF2CF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A13D0", Offset = "0x8A03D0", VA = "0x1808A13D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MLHEMMHNDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB41A90", Offset = "0xB40A90", VA = "0x180B41A90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB41AA0", Offset = "0xB40AA0", VA = "0x180B41AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public RigidbodyConstraints LMGAABBMOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5AA180", Offset = "0x5A9180", VA = "0x1805AA180", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4C37E60", Offset = "0x4C36E60", VA = "0x184C37E60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C37F60", Offset = "0x4C36F60", VA = "0x184C37F60")]
	public KJNPAPOOLKM(AEIBLGMLJHO ODADBIKNJND, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C37E30", Offset = "0x4C36E30", VA = "0x184C37E30", Slot = "9")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4C37F30", Offset = "0x4C36F30", VA = "0x184C37F30", Slot = "10")]
	public void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class FJIJMILOKDP : EJENCAPKIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private float ODKIAOMFHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private float NFMLBJJHAGD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float KNLMFJCADLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D20", Offset = "0x7E0D20", VA = "0x1807E1D20", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C2FD80", Offset = "0x4C2ED80", VA = "0x184C2FD80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float FMNBHDELBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D70", Offset = "0x7E0D70", VA = "0x1807E1D70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C2FCC0", Offset = "0x4C2ECC0", VA = "0x184C2FCC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF10", Offset = "0x4C2EF10", VA = "0x184C2FF10")]
	public FJIJMILOKDP(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FC70", Offset = "0x4C2EC70", VA = "0x184C2FC70", Slot = "8")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FE40", Offset = "0x4C2EE40", VA = "0x184C2FE40", Slot = "9")]
	public void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class AJIMMOMAFLP : CFOJFFJAHMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private const int OFDBLHJIHPB = 10;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private const float DCMDMDCDGCI = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const float PAADEEEIICD = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private const float OJKFECPEOLI = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private bool HGNILBAAIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool EFNIEMFBAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int NFBIHFHAMML;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C920", Offset = "0x4C2B920", VA = "0x184C2C920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PKFDFNNGOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CB10", Offset = "0x4C2BB10", VA = "0x184C2CB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool BFOHGCAKKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D410", Offset = "0x4C2C410", VA = "0x184C2D410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private AEIBLGMLJHO ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CCC0", Offset = "0x4C2BCC0", VA = "0x184C2CCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool PJEDPGIPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4C2D3B0", Offset = "0x4C2C3B0", VA = "0x184C2D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event NJBFGGDILLL PLKBEADGEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CB80", Offset = "0x4C2BB80", VA = "0x184C2CB80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CC20", Offset = "0x4C2BC20", VA = "0x184C2CC20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D430", Offset = "0x4C2C430", VA = "0x184C2D430")]
	public AJIMMOMAFLP(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D350", Offset = "0x4C2C350", VA = "0x184C2D350", Slot = "6")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CF50", Offset = "0x4C2BF50", VA = "0x184C2CF50", Slot = "8")]
	public void KOMEPDEDOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D220", Offset = "0x4C2C220", VA = "0x184C2D220", Slot = "7")]
	public bool MCCGEAMADBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CEE0", Offset = "0x4C2BEE0", VA = "0x184C2CEE0", Slot = "9")]
	public void JJALBGIIMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C940", Offset = "0x4C2B940", VA = "0x184C2C940", Slot = "11")]
	public void CAABJKLKHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CF60", Offset = "0x4C2BF60", VA = "0x184C2CF60", Slot = "10")]
	public void LOAAMLOLGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CD20", Offset = "0x4C2BD20", VA = "0x184C2CD20")]
	private bool IHCPONOBKNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C9A0", Offset = "0x4C2B9A0", VA = "0x184C2C9A0")]
	private void CAJIOGLFGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal sealed class KHFCNMECHHO : IFLELGHIJNH
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private const string NFMLEFLPGNK = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HEFIGJJHMHM PACIDCHMNNP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool PJEDPGIPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C36BD0", Offset = "0x4C35BD0", VA = "0x184C36BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4C37D90", Offset = "0x4C36D90", VA = "0x184C37D90")]
	public KHFCNMECHHO(AEIBLGMLJHO ODADBIKNJND, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4C37810", Offset = "0x4C36810", VA = "0x184C37810", Slot = "5")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4C36F90", Offset = "0x4C35F90", VA = "0x184C36F90", Slot = "6")]
	public void AAPCKKPMJNF(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C37670", Offset = "0x4C36670", VA = "0x184C37670", Slot = "7")]
	public void FDCNBPBEKFN(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4C37A60", Offset = "0x4C36A60", VA = "0x184C37A60", Slot = "8")]
	public void OKKHIPFPINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4C378B0", Offset = "0x4C368B0", VA = "0x184C378B0", Slot = "9")]
	public void OBJALADCLIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4C37530", Offset = "0x4C36530", VA = "0x184C37530", Slot = "10")]
	public void DBGAKPJFHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C36FC0", Offset = "0x4C35FC0", VA = "0x184C36FC0", Slot = "11")]
	public void BMCPLEHKLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C376A0", Offset = "0x4C366A0", VA = "0x184C376A0")]
	private void GPNFHBICLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C373C0", Offset = "0x4C363C0", VA = "0x184C373C0")]
	private void CIAIEEPPPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal sealed class HJFGHEDGEMD : BKIDOPKLFIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HEFIGJJHMHM EAIAKOIABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private float LEAEDAHEINC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KKEOHJDMHIP GLHNMPBGAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F20", Offset = "0x6BFF20", VA = "0x1806C0F20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public AJCLHOOPLOC LMKDKHDNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Vector3 CFJIGACBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4C33390", Offset = "0x4C32390", VA = "0x184C33390", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4C32670", Offset = "0x4C31670", VA = "0x184C32670", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Vector3 OEOJOHNDIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4C32730", Offset = "0x4C31730", VA = "0x184C32730", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4C33A90", Offset = "0x4C32A90", VA = "0x184C33A90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Vector3 IJGGMOJFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4C340D0", Offset = "0x4C330D0", VA = "0x184C340D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4C31F70", Offset = "0x4C30F70", VA = "0x184C31F70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 ILLDDNALEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4C33AC0", Offset = "0x4C32AC0", VA = "0x184C33AC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4C31970", Offset = "0x4C30970", VA = "0x184C31970", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float JODOAENFNFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D90", Offset = "0x7E0D90", VA = "0x1807E1D90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4C319A0", Offset = "0x4C309A0", VA = "0x184C319A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HBLAJIEGBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2160", Offset = "0x2BE1160", VA = "0x182BE2160", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MMNFEMPELFO JPKNHIGAFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x20E87C0", Offset = "0x20E77C0", VA = "0x1820E87C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool BFOHGCAKKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C34240", Offset = "0x4C33240", VA = "0x184C34240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4C34260", Offset = "0x4C33260", VA = "0x184C34260")]
	public HJFGHEDGEMD(AEIBLGMLJHO ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C32030", Offset = "0x4C31030", VA = "0x184C32030", Slot = "19")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C31F10", Offset = "0x4C30F10", VA = "0x184C31F10", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C316B0", Offset = "0x4C306B0", VA = "0x184C316B0", Slot = "28")]
	public void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2449700", Offset = "0x2448700", VA = "0x182449700", Slot = "20")]
	public void PLGGNGHCELI(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x24496C0", Offset = "0x24486C0", VA = "0x1824496C0", Slot = "31")]
	public void CBDFLDOEPOO(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C31D10", Offset = "0x4C30D10", VA = "0x184C31D10", Slot = "36")]
	public Vector3 CPDIMFBFBPE(Vector3 LLHKOBABGGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C31B40", Offset = "0x4C30B40", VA = "0x184C31B40", Slot = "35")]
	public Vector3 CNMINICNHLK(Vector3 IABJHJFPLHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4C32030", Offset = "0x4C31030", VA = "0x184C32030", Slot = "27")]
	public void ECCIOFLKMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4C31780", Offset = "0x4C30780", VA = "0x184C31780", Slot = "25")]
	public void AIGOLPKKNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4C325F0", Offset = "0x4C315F0", VA = "0x184C325F0", Slot = "24")]
	public void HPMGENALDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C32870", Offset = "0x4C31870", VA = "0x184C32870", Slot = "34")]
	public void JGDPGHPLKLA(Vector3 MAGGBOLPGED, Vector3 FJMHENEGDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C32400", Offset = "0x4C31400", VA = "0x184C32400", Slot = "33")]
	public void FEFKEAJPEFD(Vector3 FLPGDMJPJPH, Vector3 ADEBMGCPPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4C32460", Offset = "0x4C31460", VA = "0x184C32460", Slot = "32")]
	public void HCIPICHIHBH(Vector3 JDJFHALHPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4C31110", Offset = "0x4C30110", VA = "0x184C31110", Slot = "22")]
	public void ABEEBPLIFEA(ENMDGGCMFEF CLEKICONGLN, Vector3 GIEAKCJOHIN, float HIKEGMECLGH, float IEHPBBOMHHE = 8f, float ONHGEMGNKEA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4C33500", Offset = "0x4C32500", VA = "0x184C33500", Slot = "21")]
	public void LNCCOHNNAMI(MEGEFDHFDAK KDOGIANPDPD, Vector3 ALCNBHKOJFB, float JADPBIIHDDO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4C320E0", Offset = "0x4C310E0", VA = "0x184C320E0", Slot = "23")]
	[Obsolete]
	public void EOOGJEMKBBG(MEGEFDHFDAK KDOGIANPDPD, Vector3 GAGPEDAKPHG, float DGFCHFNDFJH = 7f, float DJPDJPMBIOA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4C31A60", Offset = "0x4C30A60", VA = "0x184C31A60", Slot = "30")]
	public Vector3 CAJFGELPMLG(Vector3 BOMOCCPALHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C33260", Offset = "0x4C32260", VA = "0x184C33260", Slot = "29")]
	public Vector3 KNKICBHBCPH(Vector3 LFOOCDGHHHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C31800", Offset = "0x4C30800", VA = "0x184C31800", Slot = "26")]
	public void APFJCMEMKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C319A0", Offset = "0x4C309A0", VA = "0x184C319A0")]
	private void BNKINFPJCDD(float MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C32AA0", Offset = "0x4C31AA0", VA = "0x184C32AA0")]
	private void JJDFFLNDALA(Vector3 ALCNBHKOJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C33F90", Offset = "0x4C32F90", VA = "0x184C33F90")]
	private Vector3 OFFNADFLCPP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C33C10", Offset = "0x4C32C10", VA = "0x184C33C10")]
	private void ODKMOCBIDJA(Vector3 IABJHJFPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C32C30", Offset = "0x4C31C30", VA = "0x184C32C30")]
	private Vector3 JKBHIHMIIEM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C33720", Offset = "0x4C32720", VA = "0x184C33720")]
	private void MGDIMAADKMO(Vector3 MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C32D80", Offset = "0x4C31D80", VA = "0x184C32D80")]
	private void KDBHAJCHEAL(Vector3 IABJHJFPLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4C318C0", Offset = "0x4C308C0", VA = "0x184C318C0")]
	private void BHPJDCNHINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IIIGDNBGCJE
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public const string LJAKEDHNLKB = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const float CKCLMMABOPJ = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public const float OPFHFNPIGME = 0f;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public const float PHHGCJGGBIB = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public IIIGDNBGCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void NJBFGGDILLL(RigidbodyEx OLFJJFHLBCM);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public delegate void FNMMNACHGCD(RigidbodyEx OLFJJFHLBCM, bool ICDGPDEJIFG = false);
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ENMDGGCMFEF
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ADDITIVE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	OVERRIDE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	REFLECTIVE
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CEACPNGPPAA
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MEGEFDHFDAK
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	ADDITIVE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	OVERRIDE,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	REFLECTIVE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DACPDMBGPPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CollisionDetectionMode JAMHBLMPMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGAGNBHFCAA(bool HJEABJADGML);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDMJDAAAJBO(bool HJEABJADGML);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GHEBCMCFGJO(Vector3 KPOIJLOIPHI, out RaycastHit KKEBIOGHELE, float NFELGDCJCGA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BKFGHNIFDHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LLPLNOLCMOF FIAMHFGMOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BPMBKPKAHEP, BPMBKPKAHEP> DGPPKIECLMC;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIPOHLLKLDO();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GCEGDENAHGA
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPFCAKAKMGE NBKKFOMJBLM(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKIDOPKLFIH OABPHAJBKEJ(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCOHFMJCLEO DCIPAGNNKNI(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJENCAPKIPE HGGDNPLIDHJ(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CFOJFFJAHMJ JKOIHMCKLEI(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BKFGHNIFDHH KMDMBENJGCB(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JLADLEKBDPF PMALGINGEGA(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMNFEMPELFO JLGILMOOOBN(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DACPDMBGPPJ FKOKIEGEEAO(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BGJFFHEKMNC FHGGOFGEPPD(AEIBLGMLJHO LJPBABKCCCE);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IFLELGHIJNH LLBDCCGKPFL(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BMDLBHMMNBF LADOHFCPHFK(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MNBONILMFGF KNBMNEGGIFJ(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CNLFLFCLBLJ LKPHMMGDCIP(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OMONPNPPGCB GBHANFKIONJ(AEIBLGMLJHO LJPBABKCCCE, in ELEIGJIBPJF OGNHKENMEGF);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MMNFEMPELFO
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFBKEPKKEAA(Vector3 LLLNICPNHJM, ForceMode MNFPKFEPHPN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGNIENPHKHC(Vector3 LLLNICPNHJM, Vector3 MMBOHLJHNFP, ForceMode MNFPKFEPHPN);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALJAACHOFOH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLHINKACOKH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BGJFFHEKMNC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool FECOABKLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CPFCAKAKMGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IReadOnlyList<AEIBLGMLJHO> BOKHLLHODJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AEIBLGMLJHO MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AEIBLGMLJHO ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NJBFGGDILLL CHEJJFMAEPE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NJBFGGDILLL ELHEEPAJOBB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event FNMMNACHGCD NCCHIGBNHKJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action IJGBHBCENDB;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action JEBMHBGOGEB;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<AEIBLGMLJHO> KEEFFJAAPLH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AEIBLGMLJHO> NBINHOIEEMB;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action DDJABKLJDNI;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action<AEIBLGMLJHO> DNPOGDIOMLO;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FBBBMCEDGND(AEIBLGMLJHO GLGDDCPCPHI, bool ICDGPDEJIFG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HCOHFMJCLEO
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Vector3 PBGBIPKCOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 EAMFHHDGJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGAANOHAHKD(AEIBLGMLJHO COLFLONKFJK, object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFGNFHGKJFM(object GJGFJFLAGKH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CNLFLFCLBLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 ANELBGALDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 KLLJAJEBCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	float FMCFFGEPOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float KCBHEIFILHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 APKAFFDMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Quaternion BOFLKLGKLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event NJBFGGDILLL GMCPGGLGIIH;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KBLHPHBMFKK();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OHOKLBPGIGF();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NELMFEMAOIA();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FBOEBNMIJDB();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MNBONILMFGF
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool MPJPOIIEDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CEACPNGPPAA JJAAGIFGIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNJOFJMIFIO(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LHCNGBFPAGE(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBNGEJGNNKF(AEIBLGMLJHO ODADBIKNJND);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IHLDDFKLKNI(AEIBLGMLJHO ODADBIKNJND);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KDJFIBHOFKD();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JLADLEKBDPF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GAPABACMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	HEFIGJJHMHM ICKPNMGKCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event NJBFGGDILLL PBBADIGNAMD;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCLOEGJOFID(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IANCHMPKOOJ(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMOEBLKBOKN(object GJGFJFLAGKH, bool HIFDCGBPAGL);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable DNIKOMBPJLK();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ABIFPODBGBO(Rigidbody JAMHIIPJAEG);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BMDLBHMMNBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AFGNPOLAKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GPIKFDFPDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event NJBFGGDILLL CLPLJFHLIAG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFKPHJEGAEL(AEIBLGMLJHO COLFLONKFJK);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MFDLLPODPJE(AEIBLGMLJHO COLFLONKFJK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OMONPNPPGCB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DPIBCLGFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool MLHEMMHNDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	RigidbodyConstraints LMGAABBMOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EJENCAPKIPE
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float KNLMFJCADLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float FMNBHDELBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDKDCCJFFNA(Rigidbody IEGOIAJCKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KCOMJMFIEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KKDOCLJLNDH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CFOJFFJAHMJ
{
	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event NJBFGGDILLL PLKBEADGEKF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCCGEAMADBP();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOMEPDEDOAA();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJALBGIIMDL();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOAAMLOLGHM();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CAABJKLKHKC();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IFLELGHIJNH
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAPCKKPMJNF(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDCNBPBEKFN(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKKHIPFPINE();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBJALADCLIH();

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBGAKPJFHLJ();

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMCPLEHKLAO();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BKIDOPKLFIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	KKEOHJDMHIP GLHNMPBGAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	AJCLHOOPLOC LMKDKHDNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 CFJIGACBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 OEOJOHNDIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 IJGGMOJFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 ILLDDNALEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float JODOAENFNFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HBLAJIEGBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MIPOHLLKLDO();

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PLGGNGHCELI(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LNCCOHNNAMI(MEGEFDHFDAK KDOGIANPDPD, Vector3 ALCNBHKOJFB, float JADPBIIHDDO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ABEEBPLIFEA(ENMDGGCMFEF CLEKICONGLN, Vector3 GIEAKCJOHIN, float HIKEGMECLGH, float IEHPBBOMHHE = 8f, float ONHGEMGNKEA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EOOGJEMKBBG(MEGEFDHFDAK KDOGIANPDPD, Vector3 GAGPEDAKPHG, float DGFCHFNDFJH = 7f, float DJPDJPMBIOA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HPMGENALDEC();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AIGOLPKKNCG();

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void APFJCMEMKKH();

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ECCIOFLKMIP();

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ABIFPODBGBO(Rigidbody IEGOIAJCKEJ);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KNKICBHBCPH(Vector3 LFOOCDGHHHN);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 CAJFGELPMLG(Vector3 BOMOCCPALHJ);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CBDFLDOEPOO(object GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HCIPICHIHBH(Vector3 JDJFHALHPAF);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FEFKEAJPEFD(Vector3 FLPGDMJPJPH, Vector3 ADEBMGCPPDB);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void JGDPGHPLKLA(Vector3 MAGGBOLPGED, Vector3 FJMHENEGDMN);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CNMINICNHLK(Vector3 IABJHJFPLHJ);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 CPDIMFBFBPE(Vector3 LLHKOBABGGA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LBFONAPDEBN
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	GCEGDENAHGA JMJMPJKOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CJNLCOMJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLMMHHLGEDM(string IOBNDAKOHMA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AJCLHOOPLOC
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NONMNNAMOIO(Vector3 AFADDONNLMA);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGDIMAADKMO(Vector3 LFOOCDGHHHN);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLHKDMLCKDL(Vector3 AFADDONNLMA);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBMDIEPAHFA(Vector3 LFOOCDGHHHN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KKEOHJDMHIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CHKBBBHNDBK();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JKBHIHMIIEM();
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private AEIBLGMLJHO IEKKIEKEIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[GCFOCDOKEGD(BHKPCKHAKLF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[GCFOCDOKEGD(BHKPCKHAKLF.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private CEACPNGPPAA physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		internal AEIBLGMLJHO EEDHOBCEABH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x4C3BBA0", Offset = "0x4C3ABA0", VA = "0x184C3BBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public IReadOnlyList<RigidbodyEx> BOKHLLHODJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x558440", Offset = "0x557440", VA = "0x180558440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x6A9B90", Offset = "0x6A8B90", VA = "0x1806A9B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public RigidbodyEx FBCNCLOIDAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D640", Offset = "0x4C3C640", VA = "0x184C3D640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public RigidbodyEx MPLJPEEIIFF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D5B0", Offset = "0x4C3C5B0", VA = "0x184C3D5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public RigidbodyEx COLFLONKFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E180", Offset = "0x4C3D180", VA = "0x184C3E180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F8E0", Offset = "0x4C3E8E0", VA = "0x184C3F8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Transform LKPJCFODAGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x850FA0", Offset = "0x84FFA0", VA = "0x180850FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform KBPJGIPCCCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x850FA0", Offset = "0x84FFA0", VA = "0x180850FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public LLPLNOLCMOF FIAMHFGMOKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D330", Offset = "0x4C3C330", VA = "0x184C3D330")]
			get
			{
				return default(LLPLNOLCMOF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EC80", Offset = "0x4C3DC80", VA = "0x184C3EC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool AFGNPOLAKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D890", Offset = "0x4C3C890", VA = "0x184C3D890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool GPIKFDFPDME
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D420", Offset = "0x4C3C420", VA = "0x184C3D420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public KKEOHJDMHIP GLHNMPBGAPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D820", Offset = "0x4C3C820", VA = "0x184C3D820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EEF0", Offset = "0x4C3DEF0", VA = "0x184C3EEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AJCLHOOPLOC LMKDKHDNGPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D7B0", Offset = "0x4C3C7B0", VA = "0x184C3D7B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EE70", Offset = "0x4C3DE70", VA = "0x184C3EE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool HBLAJIEGBLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D700", Offset = "0x4C3C700", VA = "0x184C3D700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Rigidbody GPCFLMGDOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D770", Offset = "0x4C3C770", VA = "0x184C3D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool DPIBCLGFEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D4D0", Offset = "0x4C3C4D0", VA = "0x184C3D4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C3ED70", Offset = "0x4C3DD70", VA = "0x184C3ED70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float EHMGJOGOHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E110", Offset = "0x4C3D110", VA = "0x184C3E110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float CNBOEEAGALB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E0A0", Offset = "0x4C3D0A0", VA = "0x184C3E0A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F860", Offset = "0x4C3E860", VA = "0x184C3F860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public float ODKIAOMFHJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DAB0", Offset = "0x4C3CAB0", VA = "0x184C3DAB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F1F0", Offset = "0x4C3E1F0", VA = "0x184C3F1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public float NFMLBJJHAGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D900", Offset = "0x4C3C900", VA = "0x184C3D900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EF70", Offset = "0x4C3DF70", VA = "0x184C3EF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool FMKFLFKHCHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E500", Offset = "0x4C3D500", VA = "0x184C3E500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FCC0", Offset = "0x4C3ECC0", VA = "0x184C3FCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 HPAALLLKFGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DEB0", Offset = "0x4C3CEB0", VA = "0x184C3DEB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F560", Offset = "0x4C3E560", VA = "0x184C3F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 IJODAAONIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E670", Offset = "0x4C3D670", VA = "0x184C3E670")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public CollisionDetectionMode LONAOIHDLFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D9D0", Offset = "0x4C3C9D0", VA = "0x184C3D9D0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F0F0", Offset = "0x4C3E0F0", VA = "0x184C3F0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public float JODOAENFNFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D540", Offset = "0x4C3C540", VA = "0x184C3D540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EDF0", Offset = "0x4C3DDF0", VA = "0x184C3EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public RigidbodyConstraints LPIINFMLBFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DA40", Offset = "0x4C3CA40", VA = "0x184C3DA40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F170", Offset = "0x4C3E170", VA = "0x184C3F170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 DDGOFGEDIPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E210", Offset = "0x4C3D210", VA = "0x184C3E210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 NKMGLGNLIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E210", Offset = "0x4C3D210", VA = "0x184C3E210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FB40", Offset = "0x4C3EB40", VA = "0x184C3FB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float LEIGKBIMFBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DFB0", Offset = "0x4C3CFB0", VA = "0x184C3DFB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F660", Offset = "0x4C3E660", VA = "0x184C3F660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float OMDHACCDCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E470", Offset = "0x4C3D470", VA = "0x184C3E470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FC70", Offset = "0x4C3EC70", VA = "0x184C3FC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Quaternion DJEJPDOPEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E2D0", Offset = "0x4C3D2D0", VA = "0x184C3E2D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F970", Offset = "0x4C3E970", VA = "0x184C3F970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Quaternion EHNBGDOHIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E2D0", Offset = "0x4C3D2D0", VA = "0x184C3E2D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F970", Offset = "0x4C3E970", VA = "0x184C3F970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 DDGKIOFCHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E380", Offset = "0x4C3D380", VA = "0x184C3E380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FA50", Offset = "0x4C3EA50", VA = "0x184C3FA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion DCOBICIGACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E400", Offset = "0x4C3D400", VA = "0x184C3E400")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FAD0", Offset = "0x4C3EAD0", VA = "0x184C3FAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector3 BOMOCCPALHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E570", Offset = "0x4C3D570", VA = "0x184C3E570")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FD40", Offset = "0x4C3ED40", VA = "0x184C3FD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 IABJHJFPLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E040", Offset = "0x4C3D040", VA = "0x184C3E040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F760", Offset = "0x4C3E760", VA = "0x184C3F760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 LFOOCDGHHHN
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D970", Offset = "0x4C3C970", VA = "0x184C3D970")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EFF0", Offset = "0x4C3DFF0", VA = "0x184C3EFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector3 ADEBMGCPPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DE50", Offset = "0x4C3CE50", VA = "0x184C3DE50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F460", Offset = "0x4C3E460", VA = "0x184C3F460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 BGIAEEPDMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DCE0", Offset = "0x4C3CCE0", VA = "0x184C3DCE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F360", Offset = "0x4C3E360", VA = "0x184C3F360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Quaternion JEJPLMDBAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DBF0", Offset = "0x4C3CBF0", VA = "0x184C3DBF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F270", Offset = "0x4C3E270", VA = "0x184C3F270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 BJNCGIPJGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E7D0", Offset = "0x4C3D7D0", VA = "0x184C3E7D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Vector3 LEBMIBKGPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E6D0", Offset = "0x4C3D6D0", VA = "0x184C3E6D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool HJEABJADGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DDE0", Offset = "0x4C3CDE0", VA = "0x184C3DDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool BFOHGCAKKAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D490", Offset = "0x4C3C490", VA = "0x184C3D490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool CGLAFKJAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D3A0", Offset = "0x4C3C3A0", VA = "0x184C3D3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool IPBDKIOJDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D3A0", Offset = "0x4C3C3A0", VA = "0x184C3D3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool AENPEFHKOMO
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D220", Offset = "0x4C3C220", VA = "0x184C3D220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool PFMBNPIHJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x4C3DB20", Offset = "0x4C3CB20", VA = "0x184C3DB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event NJBFGGDILLL GIFOHBCBFJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D120", Offset = "0x4C3C120", VA = "0x184C3D120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EB80", Offset = "0x4C3DB80", VA = "0x184C3EB80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event FNMMNACHGCD PDEHJJPBDDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D0A0", Offset = "0x4C3C0A0", VA = "0x184C3D0A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EB00", Offset = "0x4C3DB00", VA = "0x184C3EB00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event NJBFGGDILLL CHEJJFMAEPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3CDD0", Offset = "0x4C3BDD0", VA = "0x184C3CDD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E830", Offset = "0x4C3D830", VA = "0x184C3E830")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event NJBFGGDILLL ELHEEPAJOBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x4C3CE50", Offset = "0x4C3BE50", VA = "0x184C3CE50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E8B0", Offset = "0x4C3D8B0", VA = "0x184C3E8B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event NJBFGGDILLL AJBOLMHAKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x4C3CFA0", Offset = "0x4C3BFA0", VA = "0x184C3CFA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EA00", Offset = "0x4C3DA00", VA = "0x184C3EA00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<BPMBKPKAHEP, BPMBKPKAHEP> DGPPKIECLMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x4C3CF20", Offset = "0x4C3BF20", VA = "0x184C3CF20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E980", Offset = "0x4C3D980", VA = "0x184C3E980")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event NJBFGGDILLL EHOGMJOLFEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D020", Offset = "0x4C3C020", VA = "0x184C3D020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EA80", Offset = "0x4C3DA80", VA = "0x184C3EA80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event NJBFGGDILLL GOACCDJBJKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D1A0", Offset = "0x4C3C1A0", VA = "0x184C3D1A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x4C3EC00", Offset = "0x4C3DC00", VA = "0x184C3EC00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event NJBFGGDILLL MPEIJIDECFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x4C3CED0", Offset = "0x4C3BED0", VA = "0x184C3CED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x4C3E930", Offset = "0x4C3D930", VA = "0x184C3E930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
		internal void JIADGHLCGPN(AEIBLGMLJHO LJPBABKCCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B1D0", Offset = "0x4C3A1D0", VA = "0x184C3B1D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BBA0", Offset = "0x4C3ABA0", VA = "0x184C3BBA0")]
		private AEIBLGMLJHO OJLNNKBFLAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B630", Offset = "0x4C3A630", VA = "0x184C3B630")]
		private void GELLHDINKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B4C0", Offset = "0x4C3A4C0", VA = "0x184C3B4C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BF00", Offset = "0x4C3AF00", VA = "0x184C3BF00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B5A0", Offset = "0x4C3A5A0", VA = "0x184C3B5A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BFF0", Offset = "0x4C3AFF0", VA = "0x184C3BFF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C060", Offset = "0x4C3B060", VA = "0x184C3C060")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A630", Offset = "0x4C39630", VA = "0x184C3A630")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C0D0", Offset = "0x4C3B0D0", VA = "0x184C3C0D0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B530", Offset = "0x4C3A530", VA = "0x184C3B530")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BE90", Offset = "0x4C3AE90", VA = "0x184C3BE90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C9A0", Offset = "0x4C3B9A0", VA = "0x184C3C9A0")]
		public void SetParent(RigidbodyEx MPHFKGJNMOK, bool ICDGPDEJIFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C450", Offset = "0x4C3B450", VA = "0x184C3C450")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BBD0", Offset = "0x4C3ABD0", VA = "0x184C3BBD0")]
		public bool IsRigidbodyAncestor(RigidbodyEx DHLJLIIENHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BC60", Offset = "0x4C3AC60", VA = "0x184C3BC60")]
		public bool IsRigidbodyDescendant(RigidbodyEx NDDFDPGBACN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A8F0", Offset = "0x4C398F0", VA = "0x184C3A8F0")]
		public void AddInterpolationRestriction(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C150", Offset = "0x4C3B150", VA = "0x184C3C150")]
		public void RemoveInterpolationRestriction(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B300", Offset = "0x4C3A300", VA = "0x184C3B300")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A970", Offset = "0x4C39970", VA = "0x184C3A970")]
		public void AddKinematic(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C1D0", Offset = "0x4C3B1D0", VA = "0x184C3C1D0")]
		public void RemoveKinematic(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C910", Offset = "0x4C3B910", VA = "0x184C3C910")]
		public void SetKinematic(object GJGFJFLAGKH, bool HIFDCGBPAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C890", Offset = "0x4C3B890", VA = "0x184C3C890")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LADDCJJFLID, Quaternion BDAGFGHEDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C720", Offset = "0x4C3B720", VA = "0x184C3C720")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PPIBJFLHAEN, Quaternion NACPDMDPHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BA70", Offset = "0x4C3AA70", VA = "0x184C3BA70")]
		public Vector3 GetConstrainedVelocity(Vector3 BOMOCCPALHJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B940", Offset = "0x4C3A940", VA = "0x184C3B940")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LFOOCDGHHHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A7E0", Offset = "0x4C397E0", VA = "0x184C3A7E0")]
		public void AddForce(Vector3 LLLNICPNHJM, ForceMode MNFPKFEPHPN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A6B0", Offset = "0x4C396B0", VA = "0x184C3A6B0")]
		public void AddForceAtPosition(Vector3 LLLNICPNHJM, Vector3 MMBOHLJHNFP, ForceMode MNFPKFEPHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AB00", Offset = "0x4C39B00", VA = "0x184C3AB00")]
		public void AddTorque(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A9F0", Offset = "0x4C399F0", VA = "0x184C3A9F0")]
		public void AddRelativeTorque(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4C3CCA0", Offset = "0x4C3BCA0", VA = "0x184C3CCA0")]
		public Vector3 WorldToLocalVelocity(Vector3 LLHKOBABGGA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BD60", Offset = "0x4C3AD60", VA = "0x184C3BD60")]
		public Vector3 LocalToWorldVelocity(Vector3 IABJHJFPLHJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B4C0", Offset = "0x4C3A4C0", VA = "0x184C3B4C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B450", Offset = "0x4C3A450", VA = "0x184C3B450")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B3E0", Offset = "0x4C3A3E0", VA = "0x184C3B3E0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B370", Offset = "0x4C3A370", VA = "0x184C3B370")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C5F0", Offset = "0x4C3B5F0", VA = "0x184C3C5F0")]
		public void ResetVelocityWorldSpace(Vector3 MAGGBOLPGED, Vector3 FJMHENEGDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C4C0", Offset = "0x4C3B4C0", VA = "0x184C3C4C0")]
		public void ResetVelocityLocalSpace(Vector3 FLPGDMJPJPH, Vector3 ADEBMGCPPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C350", Offset = "0x4C3B350", VA = "0x184C3C350")]
		public void ResetLinearVelocityLocalSpace(Vector3 FLPGDMJPJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4C3CB10", Offset = "0x4C3BB10", VA = "0x184C3CB10")]
		public bool SweepTest(Vector3 KPOIJLOIPHI, out RaycastHit KKEBIOGHELE, float NFELGDCJCGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4C3BCF0", Offset = "0x4C3ACF0", VA = "0x184C3BCF0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4C3CAA0", Offset = "0x4C3BAA0", VA = "0x184C3CAA0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4C3CC30", Offset = "0x4C3BC30", VA = "0x184C3CC30")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AC10", Offset = "0x4C39C10", VA = "0x184C3AC10")]
		public void AddUnityRigidbody(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C250", Offset = "0x4C3B250", VA = "0x184C3C250")]
		public void RemoveUnityRigidbody(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AF60", Offset = "0x4C39F60", VA = "0x184C3AF60")]
		public void ApplyForceVelocityChange(ENMDGGCMFEF CLEKICONGLN, Vector3 GIEAKCJOHIN, float HIKEGMECLGH, float IEHPBBOMHHE = 8f, float ONHGEMGNKEA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AE40", Offset = "0x4C39E40", VA = "0x184C3AE40")]
		public void ApplyAngularVelocityChange(MEGEFDHFDAK KDOGIANPDPD, Vector3 ALCNBHKOJFB, float JADPBIIHDDO = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B0A0", Offset = "0x4C3A0A0", VA = "0x184C3B0A0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MEGEFDHFDAK KDOGIANPDPD, Vector3 GAGPEDAKPHG, float DGFCHFNDFJH = 7f, float DJPDJPMBIOA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AD90", Offset = "0x4C39D90", VA = "0x184C3AD90")]
		public bool AllowedScaleChange(float ODCJOFMMCJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4C3AC90", Offset = "0x4C39C90", VA = "0x184C3AC90")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx EOILPJDJJHG, object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x4C3C2D0", Offset = "0x4C3B2D0", VA = "0x184C3C2D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GJGFJFLAGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BKDAMIGBCDD
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D470", Offset = "0x4C2C470", VA = "0x184C2D470")]
	public static AEIBLGMLJHO EEDHOBCEABH(this RigidbodyEx ODADBIKNJND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ELEIGJIBPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Rigidbody IEGOIAJCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public PhotonView EIEAMNMLFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public OverridableVector3 LELJLHBIFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public OverridableVector3 DLJHICNIEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CEACPNGPPAA GNAONFGGOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public bool JCKPCGIIAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool JBJJAHILHFM;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AEIBLGMLJHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly LBFONAPDEBN PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly CPFCAKAKMGE DIJEEHPJEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly MNBONILMFGF BIENNNIPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	internal readonly BMDLBHMMNBF BJKHEMPOLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	internal readonly BKIDOPKLFIH BOMOCCPALHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal readonly HCOHFMJCLEO KFJPLBBNMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal readonly CNLFLFCLBLJ KDIIHHOHMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal readonly EJENCAPKIPE HEJAPHAJDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal readonly BGJFFHEKMNC ODGAHHODEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal readonly CFOJFFJAHMJ JBCHHNNGOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal readonly BKFGHNIFDHH HDDJEIAEGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal readonly JLADLEKBDPF MIFKIJJMIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal readonly MMNFEMPELFO LLLNICPNHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal readonly OMONPNPPGCB NLBEBFCOMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal readonly IFLELGHIJNH IEGOIAJCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal readonly DACPDMBGPPJ BKKHBMFMKOP;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public RigidbodyEx MJGODMJGDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x69DF60", Offset = "0x69CF60", VA = "0x18069DF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x93E2B0", Offset = "0x93D2B0", VA = "0x18093E2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GameObject DFNCPJOEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x69DFA0", Offset = "0x69CFA0", VA = "0x18069DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x78AA30", Offset = "0x789A30", VA = "0x18078AA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Transform DNMPFDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4C278A0", Offset = "0x4C268A0", VA = "0x184C278A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HEFIGJJHMHM PKOFMMODOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4C26DA0", Offset = "0x4C25DA0", VA = "0x184C26DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	internal Rigidbody GPCFLMGDOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4C27430", Offset = "0x4C26430", VA = "0x184C27430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEIBLGMLJHO ANDKMGNGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4C29980", Offset = "0x4C28980", VA = "0x184C29980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4C27170", Offset = "0x4C26170", VA = "0x184C27170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IReadOnlyList<AEIBLGMLJHO> BOKHLLHODJM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4C285A0", Offset = "0x4C275A0", VA = "0x184C285A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public AEIBLGMLJHO MPLJPEEIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4C29BB0", Offset = "0x4C28BB0", VA = "0x184C29BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool PJEDPGIPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B6E0", Offset = "0x4C2A6E0", VA = "0x184C2B6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool AFGNPOLAKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4C28090", Offset = "0x4C27090", VA = "0x184C28090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool GPIKFDFPDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4C2ADE0", Offset = "0x4C29DE0", VA = "0x184C2ADE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KKEOHJDMHIP GLHNMPBGAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x4C26C30", Offset = "0x4C25C30", VA = "0x184C26C30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x4C281F0", Offset = "0x4C271F0", VA = "0x184C281F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public AJCLHOOPLOC LMKDKHDNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B250", Offset = "0x4C2A250", VA = "0x184C2B250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A820", Offset = "0x4C29820", VA = "0x184C2A820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public float JODOAENFNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x4C273E0", Offset = "0x4C263E0", VA = "0x184C273E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4C29A20", Offset = "0x4C28A20", VA = "0x184C29A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Vector3 OEOJOHNDIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x4C29DC0", Offset = "0x4C28DC0", VA = "0x184C29DC0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B4E0", Offset = "0x4C2A4E0", VA = "0x184C2B4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Vector3 ILLDDNALEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B5B0", Offset = "0x4C2A5B0", VA = "0x184C2B5B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x4C274E0", Offset = "0x4C264E0", VA = "0x184C274E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Vector3 CFJIGACBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A880", Offset = "0x4C29880", VA = "0x184C2A880")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4C29AE0", Offset = "0x4C28AE0", VA = "0x184C29AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 IJGGMOJFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BE00", Offset = "0x4C2AE00", VA = "0x184C2BE00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x4C27F70", Offset = "0x4C26F70", VA = "0x184C27F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool CGLAFKJAFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4C27850", Offset = "0x4C26850", VA = "0x184C27850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool IPBDKIOJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B080", Offset = "0x4C2A080", VA = "0x184C2B080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool AENPEFHKOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A6E0", Offset = "0x4C296E0", VA = "0x184C2A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool HBLAJIEGBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AA20", Offset = "0x4C29A20", VA = "0x184C2AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 PBGBIPKCOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BA60", Offset = "0x4C2AA60", VA = "0x184C2BA60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 EAMFHHDGJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4C291A0", Offset = "0x4C281A0", VA = "0x184C291A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 ANELBGALDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x4C28D20", Offset = "0x4C27D20", VA = "0x184C28D20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4C298B0", Offset = "0x4C288B0", VA = "0x184C298B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 KLLJAJEBCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4C293B0", Offset = "0x4C283B0", VA = "0x184C293B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FMCFFGEPOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AF30", Offset = "0x4C29F30", VA = "0x184C2AF30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KCBHEIFILHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B730", Offset = "0x4C2A730", VA = "0x184C2B730")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4C28BF0", Offset = "0x4C27BF0", VA = "0x184C28BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 APKAFFDMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4C26FF0", Offset = "0x4C25FF0", VA = "0x184C26FF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A950", Offset = "0x4C29950", VA = "0x184C2A950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Quaternion BOFLKLGKLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4C27D20", Offset = "0x4C26D20", VA = "0x184C27D20")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4C29270", Offset = "0x4C28270", VA = "0x184C29270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public float KNLMFJCADLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C220", Offset = "0x4C2B220", VA = "0x184C2C220")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BBF0", Offset = "0x4C2ABF0", VA = "0x184C2BBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public float FMNBHDELBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BB30", Offset = "0x4C2AB30", VA = "0x184C2BB30")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B2F0", Offset = "0x4C2A2F0", VA = "0x184C2B2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FECOABKLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C28AB0", Offset = "0x4C27AB0", VA = "0x184C28AB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C270C0", Offset = "0x4C260C0", VA = "0x184C270C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LLPLNOLCMOF FIAMHFGMOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A280", Offset = "0x4C29280", VA = "0x184C2A280")]
		get
		{
			return default(LLPLNOLCMOF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C28360", Offset = "0x4C27360", VA = "0x184C28360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GAPABACMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C27CD0", Offset = "0x4C26CD0", VA = "0x184C27CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Transform LKPJCFODAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C278A0", Offset = "0x4C268A0", VA = "0x184C278A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Transform KBPJGIPCCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x4C278A0", Offset = "0x4C268A0", VA = "0x184C278A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Vector3 GFKNHPMGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4C28E60", Offset = "0x4C27E60", VA = "0x184C28E60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4C26C80", Offset = "0x4C25C80", VA = "0x184C26C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float IMLFIDCDOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A2D0", Offset = "0x4C292D0", VA = "0x184C2A2D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A0F0", Offset = "0x4C290F0", VA = "0x184C2A0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float OFAPNIJEGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C28DF0", Offset = "0x4C27DF0", VA = "0x184C28DF0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B350", Offset = "0x4C2A350", VA = "0x184C2B350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Quaternion DIPDIIJOOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4C27280", Offset = "0x4C26280", VA = "0x184C27280")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4C282B0", Offset = "0x4C272B0", VA = "0x184C282B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Vector3 MBCJLOPELPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C29580", Offset = "0x4C28580", VA = "0x184C29580")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4C271D0", Offset = "0x4C261D0", VA = "0x184C271D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Quaternion DDDMJFBIFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C276F0", Offset = "0x4C266F0", VA = "0x184C276F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B860", Offset = "0x4C2A860", VA = "0x184C2B860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public RigidbodyConstraints LMGAABBMOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B8B0", Offset = "0x4C2A8B0", VA = "0x184C2B8B0")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AC80", Offset = "0x4C29C80", VA = "0x184C2AC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool DPIBCLGFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x4C281A0", Offset = "0x4C271A0", VA = "0x184C281A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x4C27740", Offset = "0x4C26740", VA = "0x184C27740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public CollisionDetectionMode JAMHBLMPMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C270", Offset = "0x4C2B270", VA = "0x184C2C270")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4C278D0", Offset = "0x4C268D0", VA = "0x184C278D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool BFOHGCAKKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BED0", Offset = "0x4C2AED0", VA = "0x184C2BED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event NJBFGGDILLL CHEJJFMAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4C27220", Offset = "0x4C26220", VA = "0x184C27220")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4C285F0", Offset = "0x4C275F0", VA = "0x184C285F0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event NJBFGGDILLL ELHEEPAJOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AA70", Offset = "0x4C29A70", VA = "0x184C2AA70")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4C27A20", Offset = "0x4C26A20", VA = "0x184C27A20")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event FNMMNACHGCD NCCHIGBNHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A7C0", Offset = "0x4C297C0", VA = "0x184C2A7C0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4C280E0", Offset = "0x4C270E0", VA = "0x184C280E0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event NJBFGGDILLL CLPLJFHLIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4C27B70", Offset = "0x4C26B70", VA = "0x184C27B70")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4C27C70", Offset = "0x4C26C70", VA = "0x184C27C70")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NJBFGGDILLL AJBOLMHAKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2BDA0", Offset = "0x4C2ADA0", VA = "0x184C2BDA0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4C28140", Offset = "0x4C27140", VA = "0x184C28140")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NJBFGGDILLL PLKBEADGEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C28720", Offset = "0x4C27720", VA = "0x184C28720")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x4C296A0", Offset = "0x4C286A0", VA = "0x184C296A0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event Action<BPMBKPKAHEP, BPMBKPKAHEP> DGPPKIECLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x4C28250", Offset = "0x4C27250", VA = "0x184C28250")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x4C29EF0", Offset = "0x4C28EF0", VA = "0x184C29EF0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NJBFGGDILLL HADKDKGGPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C26E60", Offset = "0x4C25E60", VA = "0x184C26E60")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C27F10", Offset = "0x4C26F10", VA = "0x184C27F10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event NJBFGGDILLL MPEIJIDECFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x4C2B1B0", Offset = "0x4C2A1B0", VA = "0x184C2B1B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D20", Offset = "0x4C28D20", VA = "0x184C29D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C2C0", Offset = "0x4C2B2C0", VA = "0x184C2C2C0")]
	public AEIBLGMLJHO(GameObject NIKGFIPEJKD, RigidbodyEx JFOCLBPBFMK, LBFONAPDEBN PJEAKFPHIGK, in ELEIGJIBPJF OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4C27E40", Offset = "0x4C26E40", VA = "0x184C27E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A340", Offset = "0x4C29340", VA = "0x184C2A340")]
	private void KLPIBEMFDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4C28EF0", Offset = "0x4C27EF0", VA = "0x184C28EF0")]
	private void GAPBJEDPDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AF80", Offset = "0x4C29F80", VA = "0x184C2AF80")]
	public void MIPOHLLKLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4C28040", Offset = "0x4C27040", VA = "0x184C28040")]
	public void MPPPHOIAOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4C27E40", Offset = "0x4C26E40", VA = "0x184C27E40")]
	public void IECOMKFBGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x4C29340", Offset = "0x4C28340", VA = "0x184C29340")]
	public void GFBMFMEHLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4C28650", Offset = "0x4C27650", VA = "0x184C28650")]
	public void FBBBMCEDGND(AEIBLGMLJHO MPHFKGJNMOK, bool ICDGPDEJIFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x4C29E90", Offset = "0x4C28E90", VA = "0x184C29E90")]
	public void JEABAHHIMMI(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x4C29F50", Offset = "0x4C28F50", VA = "0x184C29F50")]
	public void JFDOBKJCOBG(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4C27A80", Offset = "0x4C26A80", VA = "0x184C27A80")]
	public Vector3 CPDIMFBFBPE(Vector3 LLHKOBABGGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4C27930", Offset = "0x4C26930", VA = "0x184C27930")]
	public Vector3 CNMINICNHLK(Vector3 IABJHJFPLHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4C28040", Offset = "0x4C27040", VA = "0x184C28040")]
	public void ECCIOFLKMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x4C26EC0", Offset = "0x4C25EC0", VA = "0x184C26EC0")]
	public void AIGOLPKKNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x4C299D0", Offset = "0x4C289D0", VA = "0x184C299D0")]
	public void HPMGENALDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x4C29FB0", Offset = "0x4C28FB0", VA = "0x184C29FB0")]
	public void JGDPGHPLKLA(Vector3 MAGGBOLPGED, Vector3 FJMHENEGDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4C28B00", Offset = "0x4C27B00", VA = "0x184C28B00")]
	public void FEFKEAJPEFD(Vector3 FLPGDMJPJPH, Vector3 ADEBMGCPPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4C295D0", Offset = "0x4C285D0", VA = "0x184C295D0")]
	public void HCIPICHIHBH(Vector3 JDJFHALHPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4C26B10", Offset = "0x4C25B10", VA = "0x184C26B10")]
	public void ABEEBPLIFEA(ENMDGGCMFEF CLEKICONGLN, Vector3 GIEAKCJOHIN, float HIKEGMECLGH, float IEHPBBOMHHE = 8f, float ONHGEMGNKEA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4C2ACE0", Offset = "0x4C29CE0", VA = "0x184C2ACE0")]
	public void LNCCOHNNAMI(MEGEFDHFDAK KDOGIANPDPD, Vector3 ALCNBHKOJFB, float JADPBIIHDDO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4C28490", Offset = "0x4C27490", VA = "0x184C28490")]
	[Obsolete]
	public void EOOGJEMKBBG(MEGEFDHFDAK KDOGIANPDPD, Vector3 GAGPEDAKPHG, float DGFCHFNDFJH = 7f, float DJPDJPMBIOA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4C27600", Offset = "0x4C26600", VA = "0x184C27600")]
	public Vector3 CAJFGELPMLG(Vector3 MPHFKGJNMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A5F0", Offset = "0x4C295F0", VA = "0x184C2A5F0")]
	public Vector3 KNKICBHBCPH(Vector3 MPHFKGJNMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4C27120", Offset = "0x4C26120", VA = "0x184C27120")]
	public void APFJCMEMKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4C27310", Offset = "0x4C26310", VA = "0x184C27310")]
	public void BICGFOGLLDF(AEIBLGMLJHO EOILPJDJJHG, object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A590", Offset = "0x4C29590", VA = "0x184C2A590")]
	public void KNDMIGPPLHE(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C2BA10", Offset = "0x4C2AA10", VA = "0x184C2BA10")]
	public void OHOKLBPGIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A230", Offset = "0x4C29230", VA = "0x184C2A230")]
	public void KBLHPHBMFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B2A0", Offset = "0x4C2A2A0", VA = "0x184C2B2A0")]
	public void NELMFEMAOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AE30", Offset = "0x4C29E30", VA = "0x184C2AE30")]
	public bool MCCGEAMADBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A0A0", Offset = "0x4C290A0", VA = "0x184C2A0A0")]
	public void JJALBGIIMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C275B0", Offset = "0x4C265B0", VA = "0x184C275B0")]
	public void CAABJKLKHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C27DF0", Offset = "0x4C26DF0", VA = "0x184C27DF0")]
	public IDisposable DNIKOMBPJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4C287D0", Offset = "0x4C277D0", VA = "0x184C287D0")]
	public void FCLOEGJOFID(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4C29A80", Offset = "0x4C28A80", VA = "0x184C29A80")]
	public void IANCHMPKOOJ(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4C28420", Offset = "0x4C27420", VA = "0x184C28420")]
	public void EMOEBLKBOKN(object GJGFJFLAGKH, bool HIFDCGBPAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AB50", Offset = "0x4C29B50", VA = "0x184C2AB50")]
	public void LLMGCIDKGGO(Vector3 LADDCJJFLID, Quaternion BDAGFGHEDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4C2BC50", Offset = "0x4C2AC50", VA = "0x184C2BC50")]
	public void PHHDCCJAKHD(Vector3 PPIBJFLHAEN, Quaternion NACPDMDPHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4C2BFC0", Offset = "0x4C2AFC0", VA = "0x184C2BFC0")]
	private static bool PNBPNMPGAGH(float EFLKOMHEDPO, float KEGKBOAIGOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C040", Offset = "0x4C2B040", VA = "0x184C2C040")]
	public bool PNBPNMPGAGH(float ODCJOFMMCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A1D0", Offset = "0x4C291D0", VA = "0x184C2A1D0")]
	public void JJJFHJIPKKB(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B680", Offset = "0x4C2A680", VA = "0x184C2B680")]
	public void NPINLMLHHID(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C26AB0", Offset = "0x4C25AB0", VA = "0x184C26AB0")]
	public void AAPCKKPMJNF(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C28830", Offset = "0x4C27830", VA = "0x184C28830")]
	public void FDCNBPBEKFN(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B780", Offset = "0x4C2A780", VA = "0x184C2B780")]
	public void OFBKEPKKEAA(Vector3 LLLNICPNHJM, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B900", Offset = "0x4C2A900", VA = "0x184C2B900")]
	public void OGNIENPHKHC(Vector3 LLLNICPNHJM, Vector3 MMBOHLJHNFP, ForceMode MNFPKFEPHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C26F10", Offset = "0x4C25F10", VA = "0x184C26F10")]
	public void ALJAACHOFOH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B0D0", Offset = "0x4C2A0D0", VA = "0x184C2B0D0")]
	public void MLHINKACOKH(Vector3 KPOGFMDOFJO, ForceMode MNFPKFEPHPN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C29480", Offset = "0x4C28480", VA = "0x184C29480")]
	public bool GHEBCMCFGJO(Vector3 KPOIJLOIPHI, out RaycastHit KKEBIOGHELE, float NFELGDCJCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2BB80", Offset = "0x4C2AB80", VA = "0x184C2BB80")]
	private void OMMDOMIIFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4C28C50", Offset = "0x4C27C50", VA = "0x184C28C50")]
	private void FJJBPBNHIHI(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C0D0", Offset = "0x4C2B0D0", VA = "0x184C2C0D0")]
	private void POKCAKEENJH(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4C29820", Offset = "0x4C28820", VA = "0x184C29820")]
	private void HJHAJOFHKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4C27BD0", Offset = "0x4C26BD0", VA = "0x184C27BD0")]
	private void DCFPMAKPLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AAD0", Offset = "0x4C29AD0", VA = "0x184C2AAD0")]
	private void LIINBKOLGFO(AEIBLGMLJHO POFIMHOJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4C277A0", Offset = "0x4C267A0", VA = "0x184C277A0")]
	private void CFKPHJEGAEL(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AE80", Offset = "0x4C29E80", VA = "0x184C2AE80")]
	private void MFDLLPODPJE(AEIBLGMLJHO COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C00", Offset = "0x4C28C00", VA = "0x184C29C00")]
	private void IKDBAHHKPPF(RigidbodyEx COLFLONKFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C28890", Offset = "0x4C27890", VA = "0x184C28890")]
	private void FDNFDHECAEN(RigidbodyEx ODADBIKNJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4C29190", Offset = "0x4C28190", VA = "0x184C29190")]
	internal void GCBIGEDKMLM(float AHOFCNMPEEI, Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C28780", Offset = "0x4C27780", VA = "0x184C28780")]
	public void FBOEBNMIJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C29700", Offset = "0x4C28700", VA = "0x184C29700")]
	[Conditional("UNITY_EDITOR")]
	private void HGPNPPBGAGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class GFJAHGMHIPP
{
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4C304D0", Offset = "0x4C2F4D0", VA = "0x184C304D0")]
	public static AEIBLGMLJHO KMHDHFCPOEI(this AEIBLGMLJHO ODADBIKNJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4C30590", Offset = "0x4C2F590", VA = "0x184C30590")]
	public static bool OFJOKHDHHNN(this AEIBLGMLJHO ODADBIKNJND, AEIBLGMLJHO DHLJLIIENHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4C30480", Offset = "0x4C2F480", VA = "0x184C30480")]
	public static bool DKAOMDJDAFF(this AEIBLGMLJHO ODADBIKNJND, AEIBLGMLJHO NDDFDPGBACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C30580", Offset = "0x4C2F580", VA = "0x184C30580")]
	public static RigidbodyEx MJGODMJGDFL(this AEIBLGMLJHO EEDHOBCEABH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class HLMFADEFBNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly AEIBLGMLJHO ODADBIKNJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool ECMCAACONHH;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C34350", Offset = "0x4C33350", VA = "0x184C34350")]
	public HLMFADEFBNA(AEIBLGMLJHO LNGICMIIKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4C342F0", Offset = "0x4C332F0", VA = "0x184C342F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static DMENMFODFLB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int AFOJFFGNBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int JFAACFAFGKE;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A4B0", Offset = "0x4C394B0", VA = "0x184C3A4B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A4F0", Offset = "0x4C394F0", VA = "0x184C3A4F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A4D0", Offset = "0x4C394D0", VA = "0x184C3A4D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EPAKPJCIEHE, [Optional] UnityEngine.Object GCLGODGIPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EPAKPJCIEHE, [Optional] UnityEngine.Object GCLGODGIPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x4C3A5D0", Offset = "0x4C395D0", VA = "0x184C3A5D0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AHPKHAHBAOG
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C6E0", Offset = "0x4C2B6E0", VA = "0x184C2C6E0")]
	public static void OMBHFKNBNII(this Rigidbody IINNKCFJHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C7A0", Offset = "0x4C2B7A0", VA = "0x184C2C7A0")]
	public static void OMBHFKNBNII(this Rigidbody IINNKCFJHGG, Vector3 BGIAEEPDMJA, Quaternion JEJPLMDBAFC, Vector3 MDLONJLMJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C5E0", Offset = "0x4C2B5E0", VA = "0x184C2C5E0")]
	public static void GHGOMFLAIJL(Vector3 BOMOCCPALHJ, Vector3 EPFFFFCNKLI, out Vector3 JHMECHIKHKA, out Vector3 AJBDMADOONI)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4C30B20", Offset = "0x4C2FB20", VA = "0x184C30B20")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4C30C20", Offset = "0x4C2FC20", VA = "0x184C30C20")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
