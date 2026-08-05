using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86343F0", Offset = "0x8632DF0", VA = "0x1886343F0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2402EF0", Offset = "0x24018F0", VA = "0x182402EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x863EA40", Offset = "0x863D440", VA = "0x18863EA40")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x863E7C0", Offset = "0x863D1C0", VA = "0x18863E7C0")]
		private void HGLHGGKJMAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x863F1B0", Offset = "0x863DBB0", VA = "0x18863F1B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x863F260", Offset = "0x863DC60", VA = "0x18863F260")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HGMFILBCFJF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly OLFEOKKCIEG CAEHNKCPHDD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OLFEOKKCIEG GAJABCGFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86307E0", Offset = "0x862F1E0", VA = "0x1886307E0")]
		get
		{
			return default(OLFEOKKCIEG);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DOEDDNCNEFK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView NCDGODKJFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DLCNPCDELOH PPHKMDGABID
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PDONHGKFOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(EPKNBIBIKMN MEAGDKOKFKJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(OIEMEKIANLJ IMPJJOAFALF, EPKNBIBIKMN MEAGDKOKFKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GIJGIOOPMGO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EOBEJLMGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPFCJCDIGLB(OIEMEKIANLJ IMPJJOAFALF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEOAOCFGODA(OIEMEKIANLJ IMPJJOAFALF, EPKNBIBIKMN MEAGDKOKFKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface OMIIGPKMMIE : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFFNLBFBLBL(DOEDDNCNEFK HKBMPGFJKIO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJGBLGDOBGN(DOEDDNCNEFK HKBMPGFJKIO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBBEAMBLPCO(NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFBBEBHLMCP();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCPHLCOPFHF(object PPGGMEFFGDH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OIEMEKIANLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KLADJKIHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public uint MACFNHFKGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public double IAIBCFFCGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int LHNFCPPIILN;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CGPDOKOFIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<(ViewId, DLCNPCDELOH), GIJGIOOPMGO> CDGOEKLMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<DOEDDNCNEFK> GKJKJOCODBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<(ViewId, DLCNPCDELOH)> NJHLOEMEDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int COAHDMGCAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool PNBIMDNKJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MemoryStream GGOPKBBAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EPKNBIBIKMN DBPEHONOOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EPKNBIBIKMN BKAJIFOJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] GGPDBAPOPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private float CDPOEDBJAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HKPGAMOFAME;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86292D0", Offset = "0x8627CD0", VA = "0x1886292D0")]
	public CGPDOKOFIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8628A00", Offset = "0x8627400", VA = "0x188628A00")]
	public void KBBEAMBLPCO(NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8628410", Offset = "0x8626E10", VA = "0x188628410")]
	public void DFBBEBHLMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8628030", Offset = "0x8626A30", VA = "0x188628030")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8628460", Offset = "0x8626E60", VA = "0x188628460")]
	public bool HMDNMGBNKIA(DOEDDNCNEFK HKBMPGFJKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8628DF0", Offset = "0x86277F0", VA = "0x188628DF0")]
	public bool MCKODPOBNPM(DOEDDNCNEFK HKBMPGFJKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8627E10", Offset = "0x8626810", VA = "0x188627E10")]
	private GIJGIOOPMGO BCIIJHKKDBH(ViewId KKGECNGDNCM, DLCNPCDELOH OBCPCCKJEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8628DE0", Offset = "0x86277E0", VA = "0x188628DE0")]
	public void LOEOCLDBKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8628980", Offset = "0x8627380", VA = "0x188628980")]
	private void IPIGLAIANIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86289E0", Offset = "0x86273E0", VA = "0x1886289E0")]
	private void JFBEKMPJDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8628F20", Offset = "0x8627920", VA = "0x188628F20")]
	public bool PMLMIJIBEGH(FastBufferWriter EAPDKLFLMNB, int DNDMEOJGMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8628A20", Offset = "0x8627420", VA = "0x188628A20")]
	public void LEOAOCFGODA(OIEMEKIANLJ IMPJJOAFALF, FastBufferReader DIKMKPGIBMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class EIBPPGFBJPP : GIJGIOOPMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DOEDDNCNEFK LMMCBFJPJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private uint DKBPFFMFJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int HGHCHHDDLCF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EOBEJLMGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public EIBPPGFBJPP(DOEDDNCNEFK LMMCBFJPJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x862D510", Offset = "0x862BF10", VA = "0x18862D510", Slot = "5")]
	public bool JPFCJCDIGLB(OIEMEKIANLJ IMPJJOAFALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x862D620", Offset = "0x862C020", VA = "0x18862D620", Slot = "6")]
	public void LEOAOCFGODA(OIEMEKIANLJ IMPJJOAFALF, EPKNBIBIKMN MEAGDKOKFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BNKKHLGKPNJ : GIJGIOOPMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ViewId KKGECNGDNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int HGHCHHDDLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private uint DKBPFFMFJOD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EOBEJLMGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1CCD4B0", Offset = "0x1CCBEB0", VA = "0x181CCD4B0")]
	public BNKKHLGKPNJ(ViewId KKGECNGDNCM, NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8627BF0", Offset = "0x86265F0", VA = "0x188627BF0", Slot = "5")]
	public bool JPFCJCDIGLB(OIEMEKIANLJ IMPJJOAFALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8627C30", Offset = "0x8626630", VA = "0x188627C30", Slot = "6")]
	public void LEOAOCFGODA(OIEMEKIANLJ IMPJJOAFALF, EPKNBIBIKMN MEAGDKOKFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HLNLMJJIEFO
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8631250", Offset = "0x862FC50", VA = "0x188631250")]
	public static void GCGCKFHBJPB(this OFEHKIPCPMO PPCJDKFDHGK, EPKNBIBIKMN ACJPGAEKCFJ, ViewId IJNPIDPIBFP, bool JFMHHBHCLPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8631580", Offset = "0x862FF80", VA = "0x188631580")]
	public static void LMBNAAMPGJO(this OFEHKIPCPMO PPCJDKFDHGK, EPKNBIBIKMN ACJPGAEKCFJ, bool JFMHHBHCLPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8631410", Offset = "0x862FE10", VA = "0x188631410")]
	public static OFEHKIPCPMO LEOAOCFGODA(EPKNBIBIKMN ACJPGAEKCFJ, ViewId IJNPIDPIBFP, bool JFMHHBHCLPN = true)
	{
		return default(OFEHKIPCPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8630E90", Offset = "0x862F890", VA = "0x188630E90")]
	public static void BELDGBMGANG(this OFEHKIPCPMO PPCJDKFDHGK, EPKNBIBIKMN ACJPGAEKCFJ, bool JFMHHBHCLPN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RegisterService(typeof(OMIIGPKMMIE), new string[] { })]
public class MOFNFLEENBI : OMIIGPKMMIE, INetworkUpdateSystem, KHLGOMKJGNC, AOOPFNOOKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OLFEOKKCIEG KIHKOINJAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private CGPDOKOFIJO OEANDEEGDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private uint DKOMEKIGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float ALPLPHAFNKE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8635090", Offset = "0x8633A90", VA = "0x188635090", Slot = "4")]
	public void NFFNLBFBLBL(DOEDDNCNEFK HKBMPGFJKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8634E00", Offset = "0x8633800", VA = "0x188634E00", Slot = "5")]
	public void JJGBLGDOBGN(DOEDDNCNEFK HKBMPGFJKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8634CA0", Offset = "0x86336A0", VA = "0x188634CA0", Slot = "10")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86351B0", Offset = "0x8633BB0", VA = "0x1886351B0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage HODNJDDHKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86346B0", Offset = "0x86330B0", VA = "0x1886346B0")]
	private void GNHDPEEEPCA(uint OEDBLFKGGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8635000", Offset = "0x8633A00", VA = "0x188635000", Slot = "6")]
	public void KBBEAMBLPCO(NCPBAICODHG.NJKHMKFBJAO OFBHLJOIIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8634650", Offset = "0x8633050", VA = "0x188634650", Slot = "7")]
	public void DFBBEBHLMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8635030", Offset = "0x8633A30", VA = "0x188635030", Slot = "8")]
	public void MCPHLCOPFHF(object DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8635350", Offset = "0x8633D50", VA = "0x188635350")]
	private void PKMPDMLOBCO(PJCAKALKNLJ DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8635230", Offset = "0x8633C30", VA = "0x188635230", Slot = "11")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86356D0", Offset = "0x86340D0", VA = "0x1886356D0")]
	public MOFNFLEENBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LLIBJMADCAC : GIJGIOOPMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float ACMCPKNMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int HGHCHHDDLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint DKBPFFMFJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DLCNPCDELOH DGNKMOCEJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OIEMEKIANLJ JHFNAABOKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int DFEFNNAKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] PKGAIKHKOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OIEMEKIANLJ LAKPONDEGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int MNGHBNJCJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private byte[] CCFKPFOMAJB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EOBEJLMGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8634350", Offset = "0x8632D50", VA = "0x188634350", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8634380", Offset = "0x8632D80", VA = "0x188634380")]
	public LLIBJMADCAC(DLCNPCDELOH DGNKMOCEJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8633E80", Offset = "0x8632880", VA = "0x188633E80", Slot = "5")]
	public bool JPFCJCDIGLB(OIEMEKIANLJ IMPJJOAFALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8633EC0", Offset = "0x86328C0", VA = "0x188633EC0", Slot = "6")]
	public void LEOAOCFGODA(OIEMEKIANLJ IMPJJOAFALF, EPKNBIBIKMN MEAGDKOKFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8634240", Offset = "0x8632C40", VA = "0x188634240")]
	internal EIBPPGFBJPP MGCALIEEOBP(DOEDDNCNEFK HKBMPGFJKIO, EPKNBIBIKMN ACJPGAEKCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8634070", Offset = "0x8632A70", VA = "0x188634070")]
	private static void MBBPCMFNFOH(EIBPPGFBJPP NENFFHKENFC, EPKNBIBIKMN ACJPGAEKCFJ, OIEMEKIANLJ HJMNJNADFIH, byte[] FPGJFOLEKAK, int KEDDEALNKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[RegisterService(typeof(APFHFNGGCEC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class APFHFNGGCEC : IFIABHDCDBH, KHLGOMKJGNC, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Hashtable GBPOFDBNPOG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Hashtable GLOIJCICAJD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Hashtable NPFECLGPLLP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly LAAOOMKIIJB GNIJJJAPCHL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly LAAOOMKIIJB NKNLLIDANDI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly LAAOOMKIIJB ENGNAOKNMBE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly LAAOOMKIIJB AGBDMOCOKDC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly LAAOOMKIIJB JFAHKAOMNJK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int ILGBEBEMAHN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86255E0", Offset = "0x8623FE0", VA = "0x1886255E0", Slot = "4")]
	public bool ABICFCCFGAK(FOMKHJAPMGP PDCLAJMPOEB, bool LMDPJKFMLNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86261D0", Offset = "0x8624BD0", VA = "0x1886261D0", Slot = "5")]
	public int FPKNBAIALHE(FOMKHJAPMGP[] IOEHEADJOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86268D0", Offset = "0x86252D0", VA = "0x1886268D0", Slot = "6")]
	public bool HHBNOGOOBCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8625D50", Offset = "0x8624750", VA = "0x188625D50", Slot = "7")]
	public bool BIEMGBIJIOD(int KKGECNGDNCM, int PJENDFDCMFL, bool OMAFHDNEAEA, GameObject FNCBMCHNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8625720", Offset = "0x8624120", VA = "0x188625720", Slot = "8")]
	public void AGIAFAJEAGA(int PJENDFDCMFL, [Optional] int? DMAKEJIPNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8627380", Offset = "0x8625D80", VA = "0x188627380", Slot = "9")]
	public bool MJFEBBMKDFC(PJCAKALKNLJ PPGGMEFFGDH, [Out] FOMKHJAPMGP CBEIPIMBCNA, bool FOONDBEGLJE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8625EF0", Offset = "0x86248F0", VA = "0x188625EF0", Slot = "10")]
	public bool EKGBEOOILKE(PJCAKALKNLJ PPGGMEFFGDH, [Out] int IPBPEAPNMBB, [Out] FOMKHJAPMGP[] IOEHEADJOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8626B20", Offset = "0x8625520", VA = "0x188626B20", Slot = "11")]
	public bool JJAFDGPIIIH(PJCAKALKNLJ PPGGMEFFGDH, [Out] int PJENDFDCMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8626590", Offset = "0x8624F90", VA = "0x188626590", Slot = "12")]
	public void GHDAPJPLPLB(PJCAKALKNLJ PPGGMEFFGDH, [Out] int BNNHPLJFOJF, [Out] int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8626770", Offset = "0x8625170", VA = "0x188626770", Slot = "13")]
	public void GJIKKNGKEIK(int IPBPEAPNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8626960", Offset = "0x8625360", VA = "0x188626960", Slot = "14")]
	public void IGFFPOFFLMK(int IPBPEAPNMBB, int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8626D10", Offset = "0x8625710", VA = "0x188626D10", Slot = "15")]
	public void MBOGAKJHPIG(int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8626C40", Offset = "0x8625640", VA = "0x188626C40", Slot = "16")]
	public void KHFNGAPLLAP(int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86275D0", Offset = "0x8625FD0", VA = "0x1886275D0", Slot = "17")]
	public void NHENFMBGPBJ(int IPBPEAPNMBB, int PJENDFDCMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8625910", Offset = "0x8624310", VA = "0x188625910")]
	private static void BDFNFJFOENI(FOMKHJAPMGP PDCLAJMPOEB, Hashtable JEHLBHIDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8626DC0", Offset = "0x86257C0", VA = "0x188626DC0")]
	private static bool MJFEBBMKDFC(Hashtable JEHLBHIDJMM, FNAEIBBBBBE HAFACPIKFEN, [Out] FOMKHJAPMGP CBEIPIMBCNA, bool FOONDBEGLJE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86274F0", Offset = "0x8625EF0", VA = "0x1886274F0")]
	private static int NAENCDJBCBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8626A80", Offset = "0x8625480", VA = "0x188626A80", Slot = "18")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8627740", Offset = "0x8626140", VA = "0x188627740", Slot = "19")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public APFHFNGGCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(OLPNEAPPLFP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class OLPNEAPPLFP : JIFLOEMDFOM, KHLGOMKJGNC, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Hashtable PPKFECGBKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Hashtable LKJLHNPPDCG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static LAAOOMKIIJB EINFGOAOPPA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly LAAOOMKIIJB DDJNALDCPOF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86360A0", Offset = "0x8634AA0", VA = "0x1886360A0", Slot = "4")]
	public void GKONPDCLPGE(ViewId KKGECNGDNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8635D60", Offset = "0x8634760", VA = "0x188635D60", Slot = "5")]
	public bool BAOHFAAIMDB(PJCAKALKNLJ PPGGMEFFGDH, [Out] ViewId KKGECNGDNCM, [Out] string KNLFOCHNGKB, [Out] int CFIKDBJJGEI, [Out] object[] DNEDADEPKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8636230", Offset = "0x8634C30", VA = "0x188636230", Slot = "6")]
	public void JFDGCNNBOID(ViewId DMJMJBPOHHC, string KNLFOCHNGKB, OEEBEBBCIPN FDIPMKBDLPJ, FNAEIBBBBBE BLHNDOLLIDD, DOFJGODPLMD LAGDHLHACKC, object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x86368C0", Offset = "0x86352C0", VA = "0x1886368C0", Slot = "8")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8636190", Offset = "0x8634B90", VA = "0x188636190", Slot = "7")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OLPNEAPPLFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OCNGNCHGEHM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8635BD0", Offset = "0x86345D0", VA = "0x188635BD0")]
	public static FNAEIBBBBBE HNDIAJOIPDM(this AFPDBFALGFB MCNJLDELGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8635B80", Offset = "0x8634580", VA = "0x188635B80")]
	public static AFPDBFALGFB CPKGOHBHLLG(this FNAEIBBBBBE BLHNDOLLIDD)
	{
		return default(AFPDBFALGFB);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, KOCBELMMLEE, MEDDKFIHEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<LCOGLBFMOJP> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId ABEEHEHPPIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8637A30", Offset = "0x8636430", VA = "0x188637A30")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId LDMJPMEJPAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8637A30", Offset = "0x8636430", VA = "0x188637A30", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView GDCMHMJHJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8637AB0", Offset = "0x86364B0", VA = "0x188637AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView NCDGODKJFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8637AB0", Offset = "0x86364B0", VA = "0x188637AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FNAEIBBBBBE LKLIOKBPBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8637BB0", Offset = "0x86365B0", VA = "0x188637BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FNAEIBBBBBE HJCIABFMGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8637F10", Offset = "0x8636910", VA = "0x188637F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OIENONFCDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8637D10", Offset = "0x8636710", VA = "0x188637D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OECMCNABLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8637E80", Offset = "0x8636880", VA = "0x188637E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LPNDACAGONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8637960", Offset = "0x8636360", VA = "0x188637960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HKCFJHNHKGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8637C40", Offset = "0x8636640", VA = "0x188637C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JLMGBOEIMAL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8637960", Offset = "0x8636360", VA = "0x188637960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool JODFPGCPBBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x86379E0", Offset = "0x86363E0", VA = "0x1886379E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string CMLGDDAABND
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8637B20", Offset = "0x8636520", VA = "0x188637B20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IFLJKFOMMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86378E0", Offset = "0x86362E0", VA = "0x1886378E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FNAEIBBBBBE> AFHMEAJOABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86377B0", Offset = "0x86361B0", VA = "0x1886377B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8637FA0", Offset = "0x86369A0", VA = "0x188637FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8637710", Offset = "0x8636110", VA = "0x188637710")]
		public bool WasSpawnedForPlayer(int BEJKELFNOMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78F1C50", Offset = "0x78F0650", VA = "0x1878F1C50")]
		private void NIIFBBBENEH(RRNetworkView HBELCFIJGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8637340", Offset = "0x8635D40", VA = "0x188637340", Slot = "9")]
		public void RegisterDestroyHandler(LCOGLBFMOJP OIAJENBJKKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8637540", Offset = "0x8635F40", VA = "0x188637540", Slot = "10")]
		public void UnregisterDestroyHandler(LCOGLBFMOJP OIAJENBJKKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8637320", Offset = "0x8635D20", VA = "0x188637320", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KCHHLMGNAAC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void BICGOBGALFH([In] FOMKHJAPMGP PDCLAJMPOEB, bool IPONPCAJKMF, bool JEHLBHIDJMM, bool CBDAAGJDOIC);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void LDNBJHCCAMB(GameObject CFNIACIFDFN);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void IGOJJCIOILK(GameObject CFNIACIFDFN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void LKJFEALKAGG(RRNetworkView DMJMJBPOHHC, string KNLFOCHNGKB, FNAEIBBBBBE GPHPGLDNHJA, OEEBEBBCIPN? JFBLIPHGGPK, bool NGFLADGLNJG, DOFJGODPLMD BGHMDDMEAIE, object[] PDCLAJMPOEB, string OBCBKHBDFEC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void LAGDMGKPCHN(RRNetworkView DMJMJBPOHHC, string KNLFOCHNGKB, FNAEIBBBBBE GPHPGLDNHJA, OEEBEBBCIPN? JFBLIPHGGPK, bool NGFLADGLNJG, DOFJGODPLMD BGHMDDMEAIE, object[] PDCLAJMPOEB, string OBCBKHBDFEC);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void NBHLEMPBEPD(RRNetworkView DMJMJBPOHHC, string KNLFOCHNGKB, object[] DNEDADEPKEO, string HOHGLGJIIEJ);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void BODOMJFHCGH(RRNetworkView DMJMJBPOHHC, FNAEIBBBBBE HMNEOGGCNMA);

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CompilerGenerated]
	private static LDNBJHCCAMB NDOGCKDABFF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event BICGOBGALFH CKBHCBFGGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8632D80", Offset = "0x8631780", VA = "0x188632D80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8633740", Offset = "0x8632140", VA = "0x188633740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event LDNBJHCCAMB JEDCMAFINPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8632E40", Offset = "0x8631840", VA = "0x188632E40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8633260", Offset = "0x8631C60", VA = "0x188633260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event IGOJJCIOILK PNGLHGDNBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8632F00", Offset = "0x8631900", VA = "0x188632F00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86331A0", Offset = "0x8631BA0", VA = "0x1886331A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event IGOJJCIOILK MBFCAMDEJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8632900", Offset = "0x8631300", VA = "0x188632900")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8633910", Offset = "0x8632310", VA = "0x188633910")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event LKJFEALKAGG EDIGJNGKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8632A80", Offset = "0x8631480", VA = "0x188632A80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8632C00", Offset = "0x8631600", VA = "0x188632C00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event LAGDMGKPCHN BHEMLBODILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8632B40", Offset = "0x8631540", VA = "0x188632B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86329C0", Offset = "0x86313C0", VA = "0x1886329C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event NBHLEMPBEPD CFLHPNLANEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86333E0", Offset = "0x8631DE0", VA = "0x1886333E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8633C70", Offset = "0x8632670", VA = "0x188633C70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event BODOMJFHCGH BIGOLKIHBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86334A0", Offset = "0x8631EA0", VA = "0x1886334A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8633050", Offset = "0x8631A50", VA = "0x188633050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event BODOMJFHCGH JLEAAFGAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8633A60", Offset = "0x8632460", VA = "0x188633A60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8632CC0", Offset = "0x86316C0", VA = "0x188632CC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8633320", Offset = "0x8631D20", VA = "0x188633320")]
	public static void IPEMMACJKHB([In] FOMKHJAPMGP PDCLAJMPOEB, bool IPONPCAJKMF, bool JEHLBHIDJMM, bool CBDAAGJDOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8633110", Offset = "0x8631B10", VA = "0x188633110")]
	public static void GFPCDJKCDED(GameObject CFNIACIFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8632FC0", Offset = "0x86319C0", VA = "0x188632FC0")]
	public static void ENLABNFFCLJ(GameObject CFNIACIFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x86336B0", Offset = "0x86320B0", VA = "0x1886336B0")]
	public static void KIGLNJDJJCL(GameObject CFNIACIFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x86339D0", Offset = "0x86323D0", VA = "0x1886339D0")]
	public static void NEKLKOAKFKE(GameObject CFNIACIFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8633B20", Offset = "0x8632520", VA = "0x188633B20")]
	public static void OKJKKGKJIHD(RRNetworkView DMJMJBPOHHC, string KNLFOCHNGKB, FNAEIBBBBBE GPHPGLDNHJA, OEEBEBBCIPN? JFBLIPHGGPK, bool NGFLADGLNJG, DOFJGODPLMD BGHMDDMEAIE, object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8633560", Offset = "0x8631F60", VA = "0x188633560")]
	public static void KGPADKDJBPK(RRNetworkView DMJMJBPOHHC, string KNLFOCHNGKB, int NHEFEIHPIJP, object[] DNEDADEPKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8633800", Offset = "0x8632200", VA = "0x188633800")]
	public static void MIIGOGLINIO(int KKGECNGDNCM, int MCNJLDELGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PLIOMHEJKDL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8637120", Offset = "0x8635B20", VA = "0x188637120")]
	[CanBeNull]
	private static bool BKDKPBFMECH(ViewId NMAIBBDGPCD, [Out] RRNetworkView DMJMJBPOHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8637240", Offset = "0x8635C40", VA = "0x188637240")]
	[CanBeNull]
	public static Component PIKPONILHMM(this ViewId DMJMJBPOHHC, Type NNJKEIMHIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F86260", Offset = "0x3F84C60", VA = "0x183F86260")]
	[CanBeNull]
	public static T PIKPONILHMM<T>(this ViewId DMJMJBPOHHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F86260", Offset = "0x3F84C60", VA = "0x183F86260")]
	[CanBeNull]
	public static T LDGBBDFJEOJ<T>(this ViewId DMJMJBPOHHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F861F0", Offset = "0x3F84BF0", VA = "0x183F861F0")]
	public static bool BMJEGMKFOJI<T>(this ViewId DMJMJBPOHHC, [Out] T GGIKEMCHAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x86371D0", Offset = "0x8635BD0", VA = "0x1886371D0")]
	[CanBeNull]
	public static RRNetworkView GPMINPMEDJC(this ViewId DMJMJBPOHHC)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler GMFHHDBKLAN;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler FLGHCDNLMND
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x86380D0", Offset = "0x8636AD0", VA = "0x1886380D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86382A0", Offset = "0x8636CA0", VA = "0x1886382A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8638260", Offset = "0x8636C60", VA = "0x188638260")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[RegisterService(typeof(AEMEOIPMHEM), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public sealed class AEMEOIPMHEM : ABLAGFHEFPK, KHLGOMKJGNC, AOOPFNOOKFO, DPIGDIPFEHO, MCFIHMMPFIH, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IEGLNCEJAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IEGLNCEJAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8631A80", Offset = "0x8630480", VA = "0x188631A80")]
		internal object PADPGGGKCNN((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static OLFEOKKCIEG PCOLNAOGJHE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static OLFEOKKCIEG AIPAFAEOPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[DependsOn]
	private ABMDHNICAJN LNPGGGNACHB;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Dictionary<int, HashSet<int>> NOJFIJBAGEA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Dictionary<int, int> JJBJKAGGCMI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<(GameObject GameObject, int ParentCount)> AIHEIOJHPAA;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly List<GameObject> AELDPBEAMOD;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static List<int> JIJJHADCBMM;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly List<RRNetworkView> MHDKKHMKPDP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly LAAOOMKIIJB AGBDMOCOKDC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly LAAOOMKIIJB JFAHKAOMNJK;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8621860", Offset = "0x8620260", VA = "0x188621860", Slot = "8")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8624920", Offset = "0x8623320", VA = "0x188624920", Slot = "9")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8622030", Offset = "0x8620A30", VA = "0x188622030", Slot = "10")]
	public void InitExternal(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x861E5A0", Offset = "0x861CFA0", VA = "0x18861E5A0", Slot = "11")]
	public void DAHLKNACIHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8624FA0", Offset = "0x86239A0", VA = "0x188624FA0")]
	private void PKPBLAFDOEO(DMACAFBGIPF IMMJMCGACAN, DMACAFBGIPF IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8623950", Offset = "0x8622350", VA = "0x188623950")]
	private void KNCEAGIFNPA(BJKLMHEPCLO LBMFMPNPGLN, BJKLMHEPCLO PGFLNHHCJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8621BD0", Offset = "0x86205D0", VA = "0x188621BD0")]
	public GameObject IJNDADCOGOP(string IELIBBNCJAC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, Vector3 NIAMAMNMMFM, ViewId KKGECNGDNCM, HCBPGOEJGIG PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x861CD80", Offset = "0x861B780", VA = "0x18861CD80")]
	public GameObject BLLHBIMLIFO(string IELIBBNCJAC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float NIAMAMNMMFM, object[] PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8624450", Offset = "0x8622E50", VA = "0x188624450")]
	public GameObject OCIILNHEDMC(string IELIBBNCJAC, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, Vector3 NIAMAMNMMFM, ViewId DMJMJBPOHHC, HCBPGOEJGIG PDCLAJMPOEB, bool CBDAAGJDOIC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x861E980", Offset = "0x861D380", VA = "0x18861E980")]
	public GameObject DPKGPOMHEBC(FOMKHJAPMGP PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x861EA00", Offset = "0x861D400", VA = "0x18861EA00", Slot = "6")]
	public void ECIHNEKPGLI(GameObject CFNIACIFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8623C80", Offset = "0x8622680", VA = "0x188623C80")]
	public void LPKIGMOAEKE(GameObject FNCBMCHNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8621520", Offset = "0x861FF20", VA = "0x188621520", Slot = "7")]
	public void IAGPAADKLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8621530", Offset = "0x861FF30", VA = "0x188621530", Slot = "4")]
	public GameObject[] IFFCAGBPNFP(IList<EAGDCAGBMFM> FOEBBIIMICK, bool EIEGIFOGKCM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x861FA80", Offset = "0x861E480", VA = "0x18861FA80", Slot = "5")]
	public void GBLHNMPIAJH(List<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8620480", Offset = "0x861EE80", VA = "0x188620480")]
	public void GMMFDOPNAOL(GameObject FNCBMCHNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8624CA0", Offset = "0x86236A0", VA = "0x188624CA0")]
	private void PKMPDMLOBCO(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x861C960", Offset = "0x861B360", VA = "0x18861C960")]
	private void AAKDDBLJBGA(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x861CB20", Offset = "0x861B520", VA = "0x18861CB20")]
	private void BJGCBLBNFOC(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8621DA0", Offset = "0x86207A0", VA = "0x188621DA0")]
	private void INHNICBPLAH(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8620D50", Offset = "0x861F750", VA = "0x188620D50")]
	private void HGKOLKDIKKP(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8623A90", Offset = "0x8622490", VA = "0x188623A90")]
	private void LHOCMAEFIHM(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x861FE60", Offset = "0x861E860", VA = "0x18861FE60")]
	private void GINFAHPDFJM(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x861E3B0", Offset = "0x861CDB0", VA = "0x18861E3B0")]
	private GameObject CNIDFGLDEPN(string PKKNHBLDAJM, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, Vector3 NIAMAMNMMFM, byte CAEHNKCPHDD = 0, [Optional] object[] BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x861EFF0", Offset = "0x861D9F0", VA = "0x18861EFF0")]
	private GameObject FEJJNHAHOPE(FOMKHJAPMGP PDCLAJMPOEB, bool IPONPCAJKMF = false, bool JEHLBHIDJMM = false, bool CBDAAGJDOIC = true, bool FOKIMNPMNKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8622200", Offset = "0x8620C00", VA = "0x188622200")]
	private static GameObject KADKGPDDGBE(string PKKNHBLDAJM, bool HJPDIGGMPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x861E770", Offset = "0x861D170", VA = "0x18861E770")]
	private static GameObject DPGLNBJNNPI(GameObject IGAKMAMDNNB, FOMKHJAPMGP PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8624100", Offset = "0x8622B00", VA = "0x188624100")]
	private static void MNBMCKPENFG(GameObject CFNIACIFDFN, RRNetworkView DMJMJBPOHHC, [In] FOMKHJAPMGP PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8620560", Offset = "0x861EF60", VA = "0x188620560")]
	private GameObject[] HBJHIPDGDFC(IList<EAGDCAGBMFM> FOEBBIIMICK, bool EIEGIFOGKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x861F6F0", Offset = "0x861E0F0", VA = "0x18861F6F0")]
	private GameObject[] FEKBLEBFIHO(FOMKHJAPMGP[] IOEHEADJOPP, int IPBPEAPNMBB, FNAEIBBBBBE BLHNDOLLIDD, GameObject[] CFJBLJPGPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8623CF0", Offset = "0x86226F0", VA = "0x188623CF0")]
	private GameObject MAHNMHFAGFI([In] FOMKHJAPMGP PDCLAJMPOEB, GameObject IGAKMAMDNNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x78C5580", Offset = "0x78C3F80", VA = "0x1878C5580")]
	private static bool CLBMCEPBMJP(bool IPONPCAJKMF, bool CBDAAGJDOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8622280", Offset = "0x8620C80", VA = "0x188622280")]
	private void KGLMKFDIPLJ(IEnumerable<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x861CF20", Offset = "0x861B920", VA = "0x18861CF20")]
	private void CCMELMEOEBE(GameObject CFNIACIFDFN, bool FOKIMNPMNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x861DF40", Offset = "0x861C940", VA = "0x18861DF40")]
	private static void CHNKFJJJNMA(IEnumerable<GameObject> HPHBGOPLEGA, List<(GameObject GameObject, int ParentCount)> PAJMHIFDIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86242F0", Offset = "0x8622CF0", VA = "0x1886242F0")]
	private void OBIFFFAPLHH(int PJENDFDCMFL, int IPBPEAPNMBB, bool FOKIMNPMNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x861F9E0", Offset = "0x861E3E0", VA = "0x18861F9E0")]
	private static int FOOHGEIMBED(int PJENDFDCMFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x861EA10", Offset = "0x861D410", VA = "0x18861EA10")]
	private void EGFHGCDKFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x861EA70", Offset = "0x861D470", VA = "0x18861EA70")]
	private void EHKBIHCKFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x861E350", Offset = "0x861CD50", VA = "0x18861E350")]
	private static int CKKAHIMFIJJ(int EDOPHOBKPIO, bool CBDAAGJDOIC = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8624210", Offset = "0x8622C10", VA = "0x188624210")]
	private static int[] OAEHKFAKFHB(int DAOPNFFLKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8621420", Offset = "0x861FE20", VA = "0x188621420")]
	private static int[] IADBADKBEFK(int HJCIABFMGKM, int DAOPNFFLKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8623A50", Offset = "0x8622450", VA = "0x188623A50")]
	private void LBGOLLLEDMC(FNAEIBBBBBE ABEOEBEFJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8622EA0", Offset = "0x86218A0", VA = "0x188622EA0")]
	private void KKKPFDHNPLE(FNAEIBBBBBE BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8621140", Offset = "0x861FB40", VA = "0x188621140")]
	private void HOOIGJBADFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x86246E0", Offset = "0x86230E0", VA = "0x1886246E0")]
	private void OLKOKPGEMDB(FNAEIBBBBBE BLHNDOLLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x861CE80", Offset = "0x861B880", VA = "0x18861CE80")]
	private static void CAKIAOANGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x861DE40", Offset = "0x861C840", VA = "0x18861DE40")]
	private void CHEODNAMGGN(int[] JLEGIKFAFDO, int FMAGHNIAHGO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x861E9B0", Offset = "0x861D3B0", VA = "0x18861E9B0", Slot = "12")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1366D10", Offset = "0x1365710", VA = "0x181366D10", Slot = "13")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AEMEOIPMHEM()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[RegisterService(typeof(DFBKAKFNOEN), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class DFBKAKFNOEN : KHLGOMKJGNC, AOOPFNOOKFO, POOPEGGKFKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct NENCBGKFIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly MethodInfo JLANFEIMAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Func<MonoBehaviour, object> GJFONNFKMHC;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
		public NENCBGKFIKN(MethodInfo JLANFEIMAPL, [Optional] Func<MonoBehaviour, object> GJFONNFKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x78D7E80", Offset = "0x78D6880", VA = "0x1878D7E80")]
		public object AMFKEPLEMGI(MonoBehaviour ADDGCIKIFEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AMBPAMGMHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AMBPAMGMHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8625510", Offset = "0x8623F10", VA = "0x188625510")]
		internal NENCBGKFIKN IADFJABFOBN(MethodInfo methodInfo)
		{
			return default(NENCBGKFIKN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB310", Offset = "0x4BA9D10", VA = "0x184BAB310")]
		internal object INFNPKDMDBH(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NBNGBPPEJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NBNGBPPEJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x78DB1B0", Offset = "0x78D9BB0", VA = "0x1878DB1B0")]
		internal NENCBGKFIKN AODAKCJFBCI(MethodInfo methodInfo)
		{
			return default(NENCBGKFIKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OEPJEFOPHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OEPJEFOPHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8635D20", Offset = "0x8634720", VA = "0x188635D20")]
		internal bool DDFGEOPNOLO(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static Dictionary<string, int> LGAPIOEEKKG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static List<string> MDLMECOHPFG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static int JMJCOBKHBGO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Stopwatch JCMBLFHCEOH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Dictionary<MethodInfo, ParameterInfo[]> NBPDPHFBCGI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly Dictionary<Type, List<NENCBGKFIKN>> CGAFHCOMCCB;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x862A000", Offset = "0x8628A00", VA = "0x18862A000", Slot = "4")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x862CE70", Offset = "0x862B870", VA = "0x18862CE70", Slot = "5")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x862CDE0", Offset = "0x862B7E0", VA = "0x18862CDE0")]
	public static bool PBJJEJAPCDE(string KNLFOCHNGKB, [Out] int GKMEBGGGANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x862CBE0", Offset = "0x862B5E0", VA = "0x18862CBE0")]
	public static bool OAFHOPBEMBD(int GKMEBGGGANC, [Out] string KNLFOCHNGKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x862CFD0", Offset = "0x862B9D0", VA = "0x18862CFD0")]
	private void PKMPDMLOBCO(PJCAKALKNLJ PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x86295F0", Offset = "0x8627FF0", VA = "0x1886295F0", Slot = "9")]
	public string FCFBEHKDHEM(PJCAKALKNLJ PPGGMEFFGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8629620", Offset = "0x8628020", VA = "0x188629620", Slot = "8")]
	public void GKONPDCLPGE(ViewId KKGECNGDNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x862AC90", Offset = "0x8629690", VA = "0x18862AC90", Slot = "6")]
	public void JNJIBDFHCBN(ViewId DMJMJBPOHHC, string KNLFOCHNGKB, FNAEIBBBBBE BLHNDOLLIDD, DOFJGODPLMD BGHMDDMEAIE, params object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x862A780", Offset = "0x8629180", VA = "0x18862A780", Slot = "7")]
	public void JNJIBDFHCBN(ViewId DMJMJBPOHHC, string KNLFOCHNGKB, OEEBEBBCIPN JFBLIPHGGPK, DOFJGODPLMD BGHMDDMEAIE, params object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x862A7B0", Offset = "0x86291B0", VA = "0x18862A7B0")]
	private void JNJIBDFHCBN(ViewId DMJMJBPOHHC, string KNLFOCHNGKB, OEEBEBBCIPN JFBLIPHGGPK, FNAEIBBBBBE BLHNDOLLIDD, DOFJGODPLMD BGHMDDMEAIE, params object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x862B220", Offset = "0x8629C20", VA = "0x18862B220")]
	private void LOLHCBGCJPJ(ViewId KKGECNGDNCM, string KNLFOCHNGKB, FNAEIBBBBBE FPJMIEGHFGE, int CFIKDBJJGEI, object[] DNEDADEPKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x862AD60", Offset = "0x8629760", VA = "0x18862AD60")]
	private static void LFPLPEEBIIL(NENCBGKFIKN PECFHCNLPEO, MonoBehaviour IAFDCPDKLIK, object[] ALHCDLPBNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x862A550", Offset = "0x8628F50", VA = "0x18862A550")]
	private static bool JFBGGCMLPFO(ParameterInfo[] ABNFBDGILDP, Type[] FLONDMLPDJO, [Out] bool JCOCHBNDBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8629700", Offset = "0x8628100", VA = "0x188629700")]
	private List<NENCBGKFIKN> ICBEINEFOJE(MonoBehaviour IAFDCPDKLIK, Type ALAGEBBOOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x86294F0", Offset = "0x8627EF0", VA = "0x1886294F0")]
	private static IEnumerable<MethodInfo> BFKEKKPEJBF(Type DGNODDPLLPC, Type PINPINJHHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x862CCD0", Offset = "0x862B6D0", VA = "0x18862CCD0")]
	public static ParameterInfo[] OALOBMFIMGJ(MethodInfo AOLCNGNJEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DFBKAKFNOEN()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8638370", Offset = "0x8636D70", VA = "0x188638370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86382E0", Offset = "0x8636CE0", VA = "0x1886382E0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, CBOAJDJACOO, DCMHOMBMKKH, KMKAGIJGPBM, ONOGEDAKJOF, LPDALFKAMFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(ABMDHNICAJN), new string[] { })]
		internal class NDHMJCPLIMH : KHLGOMKJGNC, AOOPFNOOKFO, ABMDHNICAJN
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Dictionary<int, RRNetworkView> BONCOJIPPDM;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8635AE0", Offset = "0x86344E0", VA = "0x188635AE0", Slot = "4")]
			public void IHHLMHPBLNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8635AE0", Offset = "0x86344E0", VA = "0x188635AE0", Slot = "5")]
			public void PFOGGBNCDDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x86357B0", Offset = "0x86341B0", VA = "0x1886357B0", Slot = "6")]
			public void BHBJOFIDFKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public NDHMJCPLIMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum HEDMIFFABFD
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class AHHBKMOBOFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public AHHBKMOBOFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x86254B0", Offset = "0x8623EB0", VA = "0x1886254B0")]
			internal bool NIDPGLBMCCN(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static LAAOOMKIIJB NNCNCNMACNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool IECAFNECKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal bool NBLPPANAIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HEDMIFFABFD hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool KHJOBPJHKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool KLOCADOICOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int KDDFIIJDCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool AMCJGELCGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FBEPDAFOFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private FNAEIBBBBBE HJCIABFMGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private FNAEIBBBBBE GJPIGBNKABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool? MCODKAHIEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool NHCKKMOEDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool BKLNGLIBFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal MonoBehaviour[] CBEMDCKOGAM;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly OLFEOKKCIEG NECOKKLKJNB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> BONCOJIPPDM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8639D30", Offset = "0x8638730", VA = "0x188639D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId LDMJPMEJPAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x863CAE0", Offset = "0x863B4E0", VA = "0x18863CAE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId EJHDKFBCJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x863CAE0", Offset = "0x863B4E0", VA = "0x18863CAE0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId ABEEHEHPPIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x863CAE0", Offset = "0x863B4E0", VA = "0x18863CAE0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int IHIJHHJANBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int FNJPEKCHNKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId APKHJEOIEHD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x863C950", Offset = "0x863B350", VA = "0x18863C950")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OMAFHDNEAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HHPCKBIICLM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x863C960", Offset = "0x863B360", VA = "0x18863C960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool IKJEHOACONI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int HPKOPKBKFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MDIKDAGAPKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x863C8F0", Offset = "0x863B2F0", VA = "0x18863C8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public FNAEIBBBBBE AHFGKNCNHPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x863CAF0", Offset = "0x863B4F0", VA = "0x18863CAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public FNAEIBBBBBE LLFDEIHHJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x863C8C0", Offset = "0x863B2C0", VA = "0x18863C8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public FNAEIBBBBBE LKLIOKBPBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x863C8C0", Offset = "0x863B2C0", VA = "0x18863C8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public FNAEIBBBBBE DEFHGNGBABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x863C8C0", Offset = "0x863B2C0", VA = "0x18863C8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ANIMLNCJHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x863CA30", Offset = "0x863B430", VA = "0x18863CA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int HKMEMHBNADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x863C920", Offset = "0x863B320", VA = "0x18863C920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] NHHMCBEEPCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OIENONFCDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x863CB20", Offset = "0x863B520", VA = "0x18863CB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool PJFFIBOGHOG
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x863CAB0", Offset = "0x863B4B0", VA = "0x18863CAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JCPKGNGOBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1050500", Offset = "0x104EF00", VA = "0x181050500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DCJPCDJNIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CKOINILLNOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x863C760", Offset = "0x863B160", VA = "0x18863C760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x863CCE0", Offset = "0x863B6E0", VA = "0x18863CCE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<FNAEIBBBBBE> MBANPDDEEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8639EC0", Offset = "0x86388C0", VA = "0x188639EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x863A420", Offset = "0x8638E20", VA = "0x18863A420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<FNAEIBBBBBE> FLKNCGOPCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8639EC0", Offset = "0x86388C0", VA = "0x188639EC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x863A420", Offset = "0x8638E20", VA = "0x18863A420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> BCCMIJKMLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8638C20", Offset = "0x8637620", VA = "0x188638C20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8638D50", Offset = "0x8637750", VA = "0x188638D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> DOHAFOHAPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8638C20", Offset = "0x8637620", VA = "0x188638C20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8638D50", Offset = "0x8637750", VA = "0x188638D50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> OIOKEACEDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x863C810", Offset = "0x863B210", VA = "0x18863C810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x863CD90", Offset = "0x863B790", VA = "0x18863CD90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OEBBCBIKLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x863C6B0", Offset = "0x863B0B0", VA = "0x18863C6B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x863CC30", Offset = "0x863B630", VA = "0x18863CC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x863C520", Offset = "0x863AF20", VA = "0x18863C520")]
		public static bool TryGetNetworkView(int KKGECNGDNCM, [Out] RRNetworkView DMJMJBPOHHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8638FD0", Offset = "0x86379D0", VA = "0x188638FD0")]
		public static RRNetworkView Find(int KKGECNGDNCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8639140", Offset = "0x8637B40", VA = "0x188639140")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int AKCNDIOJIBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8639090", Offset = "0x8637A90", VA = "0x188639090")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x863A950", Offset = "0x8639350", VA = "0x18863A950")]
		public static bool RemoveNetworkView(RRNetworkView DMJMJBPOHHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x863A6F0", Offset = "0x86390F0", VA = "0x18863A6F0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x863A0B0", Offset = "0x8638AB0", VA = "0x18863A0B0")]
		public static void OnPlayerJoinedRoom(FNAEIBBBBBE PEEGJOGDPIP, List<int> JLEGIKFAFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x86392B0", Offset = "0x8637CB0", VA = "0x1886392B0")]
		public static RRNetworkView Get(Component ADKKEOFFDMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8639310", Offset = "0x8637D10", VA = "0x188639310")]
		public static RRNetworkView Get(GameObject OJCBKNNGHDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8639370", Offset = "0x8637D70", VA = "0x188639370")]
		private void HCNDKNLIFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8638BA0", Offset = "0x86375A0", VA = "0x188638BA0")]
		public bool CreatedBy(FNAEIBBBBBE BLHNDOLLIDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x863C330", Offset = "0x863AD30", VA = "0x18863C330")]
		public void TransferOwnership(int JFDNDLBOPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x863C2D0", Offset = "0x863ACD0", VA = "0x18863C2D0")]
		public void TransferOwnership(FNAEIBBBBBE HMNEOGGCNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8639A80", Offset = "0x8638480", VA = "0x188639A80", Slot = "4")]
		public void Initialize(ViewId GHGGKMHIAAG, ViewId MHNDBFICHGL, Dictionary<int, object> DDMHDBLMGFA, AFPDBFALGFB HJCIABFMGKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8639C00", Offset = "0x8638600", VA = "0x188639C00")]
		public void Initialize(ViewId GHGGKMHIAAG, ViewId MHNDBFICHGL, object[] PEGLBLICPNE, AFPDBFALGFB HJCIABFMGKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x86384F0", Offset = "0x8636EF0", VA = "0x1886384F0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8639810", Offset = "0x8638210", VA = "0x188639810")]
		private void ICNHMDOAAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x20F3CA0", Offset = "0x20F26A0", VA = "0x1820F3CA0")]
		internal void LBPKICBAHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8638760", Offset = "0x8637160", VA = "0x188638760", Slot = "6")]
		private void BMFCBAIOBPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8639C60", Offset = "0x8638660", VA = "0x188639C60")]
		internal bool JJBMPGGIICE(RRNetworkView BDMIHGHPDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8639F70", Offset = "0x8638970", VA = "0x188639F70")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8639CD0", Offset = "0x86386D0", VA = "0x188639CD0")]
		internal void KFADLMFICHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8638FC0", Offset = "0x86379C0", VA = "0x188638FC0")]
		private void FODPEBPKCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x86386A0", Offset = "0x86370A0", VA = "0x1886386A0")]
		internal void BICILFMEIEP(FNAEIBBBBBE HMNEOGGCNMA, int JFDNDLBOPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x863A8B0", Offset = "0x86392B0", VA = "0x18863A8B0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x863AA00", Offset = "0x8639400", VA = "0x18863AA00")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8639450", Offset = "0x8637E50", VA = "0x188639450")]
		private void IAFDNDEPAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86387C0", Offset = "0x86371C0", VA = "0x1886387C0")]
		private void BMMKDBMDEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x863A5D0", Offset = "0x8638FD0", VA = "0x18863A5D0")]
		public void RPC(string KNLFOCHNGKB, OEEBEBBCIPN JFBLIPHGGPK, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x863A660", Offset = "0x8639060", VA = "0x18863A660")]
		public void RPC(string KNLFOCHNGKB, FNAEIBBBBBE GPHPGLDNHJA, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x863A900", Offset = "0x8639300", VA = "0x18863A900")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86388B0", Offset = "0x86372B0", VA = "0x1886388B0", Slot = "8")]
		public void Bake(DMCPBIKBILF IJNPIDPIBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8638CD0", Offset = "0x86376D0", VA = "0x188638CD0")]
		private static void FBAFFJNDHII(FNAEIBBBBBE NBPOBGMPFAH, [Out] FNAEIBBBBBE AFLHBKMHOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86394F0", Offset = "0x8637EF0", VA = "0x1886394F0")]
		private static void ICAEDDJGNJM(RRNetworkView GDCMHMJHJOG, Delegate PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8639D80", Offset = "0x8638780", VA = "0x188639D80")]
		private static MEEBGCNEDOD NJKFEIBBAMK(RRNetworkView GDCMHMJHJOG)
		{
			return default(MEEBGCNEDOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8638EE0", Offset = "0x86378E0", VA = "0x188638EE0")]
		private static void FJPCBBIIJMG(RRNetworkView GDCMHMJHJOG, Delegate PECFHCNLPEO, FNAEIBBBBBE FAIFHNCJOIL, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8638E00", Offset = "0x8637800", VA = "0x188638E00")]
		private static void FJPCBBIIJMG(RRNetworkView GDCMHMJHJOG, Delegate PECFHCNLPEO, OEEBEBBCIPN FAIFHNCJOIL, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8638550", Offset = "0x8636F50", VA = "0x188638550")]
		private static void BAGMHEAKMHB(RRNetworkView GDCMHMJHJOG, Delegate PECFHCNLPEO, OEEBEBBCIPN FAIFHNCJOIL, ENJPIAJPKHC MKLLDJAABKC, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x863A4D0", Offset = "0x8638ED0", VA = "0x18863A4D0")]
		public void RPCBuffered(string KNLFOCHNGKB, OEEBEBBCIPN JFBLIPHGGPK, ENJPIAJPKHC BGHMDDMEAIE, params object[] PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8639E20", Offset = "0x8638820", VA = "0x188639E20")]
		private static bool NMFCKCAAMEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x863B0E0", Offset = "0x8639AE0", VA = "0x18863B0E0", Slot = "26")]
		public void RpcAll(AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4034DE0", Offset = "0x40337E0", VA = "0x184034DE0", Slot = "9")]
		public void RpcAll<T1>(AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4034660", Offset = "0x4033060", VA = "0x184034660", Slot = "10")]
		public void RpcAll<T1, T2>(AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4036A60", Offset = "0x4035460", VA = "0x184036A60", Slot = "27")]
		public void RpcAll<T1, T2, T3>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4034870", Offset = "0x4033270", VA = "0x184034870", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4034220", Offset = "0x4032C20", VA = "0x184034220", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4036F60", Offset = "0x4035960", VA = "0x184036F60", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4033CF0", Offset = "0x40326F0", VA = "0x184033CF0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x403BA80", Offset = "0x403A480", VA = "0x18403BA80", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4037400", Offset = "0x4035E00", VA = "0x184037400", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4035840", Offset = "0x4034240", VA = "0x184035840", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4041270", Offset = "0x403FC70", VA = "0x184041270", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4040760", Offset = "0x403F160", VA = "0x184040760", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4040190", Offset = "0x403EB90", VA = "0x184040190", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4034F70", Offset = "0x4033970", VA = "0x184034F70", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x863AEB0", Offset = "0x86398B0", VA = "0x18863AEB0", Slot = "36")]
		public void RpcAll(AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4039A40", Offset = "0x4038440", VA = "0x184039A40", Slot = "37")]
		public void RpcAll<T1>(AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x403A640", Offset = "0x4039040", VA = "0x18403A640", Slot = "38")]
		public void RpcAll<T1, T2>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4036110", Offset = "0x4034B10", VA = "0x184036110", Slot = "39")]
		public void RpcAll<T1, T2, T3>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4044A20", Offset = "0x4043420", VA = "0x184044A20", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4044720", Offset = "0x4043120", VA = "0x184044720", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4044100", Offset = "0x4042B00", VA = "0x184044100", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4043A40", Offset = "0x4042440", VA = "0x184043A40", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4042EF0", Offset = "0x40418F0", VA = "0x184042EF0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4042A70", Offset = "0x4041470", VA = "0x184042A70", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4041CB0", Offset = "0x40406B0", VA = "0x184041CB0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4041770", Offset = "0x4040170", VA = "0x184041770", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4040CC0", Offset = "0x403F6C0", VA = "0x184040CC0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x403FB70", Offset = "0x403E570", VA = "0x18403FB70", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x403EEB0", Offset = "0x403D8B0", VA = "0x18403EEB0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x863AC50", Offset = "0x8639650", VA = "0x18863AC50", Slot = "51")]
		public void RpcAllViaServer(AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4076560", Offset = "0x4074F60", VA = "0x184076560", Slot = "52")]
		public void RpcAllViaServer<T1>(AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4070E70", Offset = "0x406F870", VA = "0x184070E70", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x40760F0", Offset = "0x4074AF0", VA = "0x1840760F0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4075D40", Offset = "0x4074740", VA = "0x184075D40", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x40756A0", Offset = "0x40740A0", VA = "0x1840756A0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4075180", Offset = "0x4073B80", VA = "0x184075180", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4074EA0", Offset = "0x40738A0", VA = "0x184074EA0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4074560", Offset = "0x4072F60", VA = "0x184074560", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4073E60", Offset = "0x4072860", VA = "0x184073E60", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x40736C0", Offset = "0x40720C0", VA = "0x1840736C0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x40732A0", Offset = "0x4071CA0", VA = "0x1840732A0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4072A10", Offset = "0x4071410", VA = "0x184072A10", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x40720E0", Offset = "0x4070AE0", VA = "0x1840720E0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4071700", Offset = "0x4070100", VA = "0x184071700", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x863AD80", Offset = "0x8639780", VA = "0x18863AD80", Slot = "65")]
		public void RpcAllViaServer(AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4076660", Offset = "0x4075060", VA = "0x184076660", Slot = "66")]
		public void RpcAllViaServer<T1>(AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x40762A0", Offset = "0x4074CA0", VA = "0x1840762A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4075F40", Offset = "0x4074940", VA = "0x184075F40", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4075B40", Offset = "0x4074540", VA = "0x184075B40", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x40758F0", Offset = "0x40742F0", VA = "0x1840758F0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4075410", Offset = "0x4073E10", VA = "0x184075410", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4074BC0", Offset = "0x40735C0", VA = "0x184074BC0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4074890", Offset = "0x4073290", VA = "0x184074890", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x40741E0", Offset = "0x4072BE0", VA = "0x1840741E0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4073A90", Offset = "0x4072490", VA = "0x184073A90", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4072E80", Offset = "0x4071880", VA = "0x184072E80", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x40725A0", Offset = "0x4070FA0", VA = "0x1840725A0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4071C20", Offset = "0x4070620", VA = "0x184071C20", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x40711E0", Offset = "0x406FBE0", VA = "0x1840711E0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x863BB70", Offset = "0x863A570", VA = "0x18863BB70", Slot = "80")]
		public void RpcOthers(AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x40989A0", Offset = "0x40973A0", VA = "0x1840989A0", Slot = "15")]
		public void RpcOthers<T1>(AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4099250", Offset = "0x4097C50", VA = "0x184099250", Slot = "81")]
		public void RpcOthers<T1, T2>(AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4098720", Offset = "0x4097120", VA = "0x184098720", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x409F3D0", Offset = "0x409DDD0", VA = "0x18409F3D0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x409F160", Offset = "0x409DB60", VA = "0x18409F160", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4099FB0", Offset = "0x40989B0", VA = "0x184099FB0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x409E350", Offset = "0x409CD50", VA = "0x18409E350", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x409DC90", Offset = "0x409C690", VA = "0x18409DC90", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x409D8E0", Offset = "0x409C2E0", VA = "0x18409D8E0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x409CD50", Offset = "0x409B750", VA = "0x18409CD50", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x409C910", Offset = "0x409B310", VA = "0x18409C910", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x409C040", Offset = "0x409AA40", VA = "0x18409C040", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x409B1D0", Offset = "0x4099BD0", VA = "0x18409B1D0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x409AC90", Offset = "0x4099690", VA = "0x18409AC90", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x863BCC0", Offset = "0x863A6C0", VA = "0x18863BCC0", Slot = "93")]
		public void RpcOthers(AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4098FB0", Offset = "0x40979B0", VA = "0x184098FB0", Slot = "94")]
		public void RpcOthers<T1>(AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4098DD0", Offset = "0x40977D0", VA = "0x184098DD0", Slot = "95")]
		public void RpcOthers<T1, T2>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x40A0380", Offset = "0x409ED80", VA = "0x1840A0380", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4098AF0", Offset = "0x40974F0", VA = "0x184098AF0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4099740", Offset = "0x4098140", VA = "0x184099740", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4099A80", Offset = "0x4098480", VA = "0x184099A80", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x409E660", Offset = "0x409D060", VA = "0x18409E660", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x409DFF0", Offset = "0x409C9F0", VA = "0x18409DFF0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x409D530", Offset = "0x409BF30", VA = "0x18409D530", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x409D140", Offset = "0x409BB40", VA = "0x18409D140", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x409C4D0", Offset = "0x409AED0", VA = "0x18409C4D0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x409BBB0", Offset = "0x409A5B0", VA = "0x18409BBB0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x409B6C0", Offset = "0x409A0C0", VA = "0x18409B6C0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x409A750", Offset = "0x4099150", VA = "0x18409A750", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x863B660", Offset = "0x863A060", VA = "0x18863B660", Slot = "108")]
		public void RpcMaster(AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4083360", Offset = "0x4081D60", VA = "0x184083360", Slot = "109")]
		public void RpcMaster<T1>(AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x40836F0", Offset = "0x40820F0", VA = "0x1840836F0", Slot = "17")]
		public void RpcMaster<T1, T2>(AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4082AB0", Offset = "0x40814B0", VA = "0x184082AB0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4082D50", Offset = "0x4081750", VA = "0x184082D50", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4086D60", Offset = "0x4085760", VA = "0x184086D60", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4089130", Offset = "0x4087B30", VA = "0x184089130", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x408ECC0", Offset = "0x408D6C0", VA = "0x18408ECC0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x408E470", Offset = "0x408CE70", VA = "0x18408E470", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x408DB60", Offset = "0x408C560", VA = "0x18408DB60", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4086530", Offset = "0x4084F30", VA = "0x184086530", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4085160", Offset = "0x4083B60", VA = "0x184085160", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x408C1B0", Offset = "0x408ABB0", VA = "0x18408C1B0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x408AFD0", Offset = "0x40899D0", VA = "0x18408AFD0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x408A990", Offset = "0x4089390", VA = "0x18408A990", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x863B7F0", Offset = "0x863A1F0", VA = "0x18863B7F0", Slot = "122")]
		public void RpcMaster(AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4083500", Offset = "0x4081F00", VA = "0x184083500", Slot = "123")]
		public void RpcMaster<T1>(AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4084390", Offset = "0x4082D90", VA = "0x184084390", Slot = "124")]
		public void RpcMaster<T1, T2>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4083940", Offset = "0x4082340", VA = "0x184083940", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x40903B0", Offset = "0x408EDB0", VA = "0x1840903B0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4087780", Offset = "0x4086180", VA = "0x184087780", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x408F780", Offset = "0x408E180", VA = "0x18408F780", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x408F060", Offset = "0x408DA60", VA = "0x18408F060", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x408E870", Offset = "0x408D270", VA = "0x18408E870", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x408DFC0", Offset = "0x408C9C0", VA = "0x18408DFC0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x408D1A0", Offset = "0x408BBA0", VA = "0x18408D1A0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x408C720", Offset = "0x408B120", VA = "0x18408C720", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x408BBE0", Offset = "0x408A5E0", VA = "0x18408BBE0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x408B5B0", Offset = "0x4089FB0", VA = "0x18408B5B0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x408A300", Offset = "0x4088D00", VA = "0x18408A300", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x863B250", Offset = "0x8639C50", VA = "0x18863B250", Slot = "137")]
		public void RpcAuthority(AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4076B60", Offset = "0x4075560", VA = "0x184076B60", Slot = "138")]
		public void RpcAuthority<T1>(AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4078410", Offset = "0x4076E10", VA = "0x184078410", Slot = "139")]
		public void RpcAuthority<T1, T2>(AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4078BC0", Offset = "0x40775C0", VA = "0x184078BC0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x40780E0", Offset = "0x4076AE0", VA = "0x1840780E0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4076760", Offset = "0x4075160", VA = "0x184076760", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x407EA30", Offset = "0x407D430", VA = "0x18407EA30", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x407DED0", Offset = "0x407C8D0", VA = "0x18407DED0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x407D660", Offset = "0x407C060", VA = "0x18407D660", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x407CD30", Offset = "0x407B730", VA = "0x18407CD30", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x407C860", Offset = "0x407B260", VA = "0x18407C860", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x407B890", Offset = "0x407A290", VA = "0x18407B890", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4076D20", Offset = "0x4075720", VA = "0x184076D20", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x407A730", Offset = "0x4079130", VA = "0x18407A730", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4079400", Offset = "0x4077E00", VA = "0x184079400", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x863B400", Offset = "0x8639E00", VA = "0x18863B400", Slot = "152")]
		public void RpcAuthority(AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4080DA0", Offset = "0x407F7A0", VA = "0x184080DA0", Slot = "153")]
		public void RpcAuthority<T1>(AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4080250", Offset = "0x407EC50", VA = "0x184080250", Slot = "154")]
		public void RpcAuthority<T1, T2>(AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x407F950", Offset = "0x407E350", VA = "0x18407F950", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x407F3D0", Offset = "0x407DDD0", VA = "0x18407F3D0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x407F080", Offset = "0x407DA80", VA = "0x18407F080", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x407E680", Offset = "0x407D080", VA = "0x18407E680", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x407E280", Offset = "0x407CC80", VA = "0x18407E280", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x407DA70", Offset = "0x407C470", VA = "0x18407DA70", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x407D1A0", Offset = "0x407BBA0", VA = "0x18407D1A0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x407C340", Offset = "0x407AD40", VA = "0x18407C340", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x407BDC0", Offset = "0x407A7C0", VA = "0x18407BDC0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x407B2B0", Offset = "0x4079CB0", VA = "0x18407B2B0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x407A0F0", Offset = "0x4078AF0", VA = "0x18407A0F0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4079A50", Offset = "0x4078450", VA = "0x184079A50", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x863BE10", Offset = "0x863A810", VA = "0x18863BE10", Slot = "18")]
		public void RpcPlayer(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x40A1630", Offset = "0x40A0030", VA = "0x1840A1630", Slot = "19")]
		public void RpcPlayer<T1>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x40A2560", Offset = "0x40A0F60", VA = "0x1840A2560", Slot = "20")]
		public void RpcPlayer<T1, T2>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x40A1F90", Offset = "0x40A0990", VA = "0x1840A1F90", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x40A1800", Offset = "0x40A0200", VA = "0x1840A1800", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x40A5DA0", Offset = "0x40A47A0", VA = "0x1840A5DA0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x40A5940", Offset = "0x40A4340", VA = "0x1840A5940", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x40A6180", Offset = "0x40A4B80", VA = "0x1840A6180", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x40A6640", Offset = "0x40A5040", VA = "0x1840A6640", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x40ACB00", Offset = "0x40AB500", VA = "0x1840ACB00", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x40ABC20", Offset = "0x40AA620", VA = "0x1840ABC20", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FNAEIBBBBBE BLHNDOLLIDD, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x40A2E20", Offset = "0x40A1820", VA = "0x1840A2E20", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FNAEIBBBBBE BLHNDOLLIDD, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x40AABB0", Offset = "0x40A95B0", VA = "0x1840AABB0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FNAEIBBBBBE BLHNDOLLIDD, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x40A9FC0", Offset = "0x40A89C0", VA = "0x1840A9FC0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FNAEIBBBBBE BLHNDOLLIDD, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x40A9300", Offset = "0x40A7D00", VA = "0x1840A9300", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(FNAEIBBBBBE BLHNDOLLIDD, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x863C010", Offset = "0x863AA10", VA = "0x18863C010", Slot = "176")]
		public void RpcPlayer(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x40A1B90", Offset = "0x40A0590", VA = "0x1840A1B90", Slot = "177")]
		public void RpcPlayer<T1>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x40A2B40", Offset = "0x40A1540", VA = "0x1840A2B40", Slot = "24")]
		public void RpcPlayer<T1, T2>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x40A27D0", Offset = "0x40A11D0", VA = "0x1840A27D0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x40A4600", Offset = "0x40A3000", VA = "0x1840A4600", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x40AE730", Offset = "0x40AD130", VA = "0x1840AE730", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x40AE010", Offset = "0x40ACA10", VA = "0x1840AE010", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x40ADBF0", Offset = "0x40AC5F0", VA = "0x1840ADBF0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x40AD3B0", Offset = "0x40ABDB0", VA = "0x1840AD3B0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(FNAEIBBBBBE BLHNDOLLIDD, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x40AC630", Offset = "0x40AB030", VA = "0x1840AC630", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(FNAEIBBBBBE BLHNDOLLIDD, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x40AC100", Offset = "0x40AAB00", VA = "0x1840AC100", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FNAEIBBBBBE BLHNDOLLIDD, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x40AB690", Offset = "0x40AA090", VA = "0x1840AB690", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FNAEIBBBBBE BLHNDOLLIDD, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x40AA5C0", Offset = "0x40A8FC0", VA = "0x1840AA5C0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FNAEIBBBBBE BLHNDOLLIDD, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x40A9970", Offset = "0x40A8370", VA = "0x1840A9970", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FNAEIBBBBBE BLHNDOLLIDD, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x40A8C40", Offset = "0x40A7640", VA = "0x1840A8C40", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(FNAEIBBBBBE BLHNDOLLIDD, JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x863AB10", Offset = "0x8639510", VA = "0x18863AB10", Slot = "189")]
		public void RpcAllBuffered(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4033AB0", Offset = "0x40324B0", VA = "0x184033AB0", Slot = "190")]
		public void RpcAllBuffered<T1>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4033940", Offset = "0x4032340", VA = "0x184033940", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4070980", Offset = "0x406F380", VA = "0x184070980", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4070560", Offset = "0x406EF60", VA = "0x184070560", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x40700C0", Offset = "0x406EAC0", VA = "0x1840700C0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x406FB80", Offset = "0x406E580", VA = "0x18406FB80", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x406F5A0", Offset = "0x406DFA0", VA = "0x18406F5A0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x406F260", Offset = "0x406DC60", VA = "0x18406F260", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x406E800", Offset = "0x406D200", VA = "0x18406E800", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x406E420", Offset = "0x406CE20", VA = "0x18406E420", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ENJPIAJPKHC BGHMDDMEAIE, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x406DC10", Offset = "0x406C610", VA = "0x18406DC10", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ENJPIAJPKHC BGHMDDMEAIE, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x406D360", Offset = "0x406BD60", VA = "0x18406D360", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ENJPIAJPKHC BGHMDDMEAIE, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x406CA10", Offset = "0x406B410", VA = "0x18406CA10", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ENJPIAJPKHC BGHMDDMEAIE, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x406C020", Offset = "0x406AA20", VA = "0x18406C020", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ENJPIAJPKHC BGHMDDMEAIE, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x863ABB0", Offset = "0x86395B0", VA = "0x18863ABB0", Slot = "204")]
		public void RpcAllBuffered(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4033BD0", Offset = "0x40325D0", VA = "0x184033BD0", Slot = "205")]
		public void RpcAllBuffered<T1>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4070D00", Offset = "0x406F700", VA = "0x184070D00", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4070B40", Offset = "0x406F540", VA = "0x184070B40", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4070770", Offset = "0x406F170", VA = "0x184070770", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4070310", Offset = "0x406ED10", VA = "0x184070310", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x406FE20", Offset = "0x406E820", VA = "0x18406FE20", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x406F890", Offset = "0x406E290", VA = "0x18406F890", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x406EF20", Offset = "0x406D920", VA = "0x18406EF20", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x406EB90", Offset = "0x406D590", VA = "0x18406EB90", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ENJPIAJPKHC BGHMDDMEAIE, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x406E040", Offset = "0x406CA40", VA = "0x18406E040", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ENJPIAJPKHC BGHMDDMEAIE, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x406D7E0", Offset = "0x406C1E0", VA = "0x18406D7E0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ENJPIAJPKHC BGHMDDMEAIE, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x406CEE0", Offset = "0x406B8E0", VA = "0x18406CEE0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ENJPIAJPKHC BGHMDDMEAIE, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x406C540", Offset = "0x406AF40", VA = "0x18406C540", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ENJPIAJPKHC BGHMDDMEAIE, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x406BB00", Offset = "0x406A500", VA = "0x18406BB00", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ENJPIAJPKHC BGHMDDMEAIE, JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x863BAD0", Offset = "0x863A4D0", VA = "0x18863BAD0", Slot = "219")]
		public void RpcOthersBuffered(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NONGGHPNGPP PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x40984E0", Offset = "0x4096EE0", VA = "0x1840984E0", Slot = "220")]
		public void RpcOthersBuffered<T1>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.ODCHKHELOON<T1> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4098200", Offset = "0x4096C00", VA = "0x184098200", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OEOFEEHLMIC<T1, T2> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4097E80", Offset = "0x4096880", VA = "0x184097E80", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, T3> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4097A60", Offset = "0x4096460", VA = "0x184097A60", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, T4> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x40975C0", Offset = "0x4095FC0", VA = "0x1840975C0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, T5> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4097080", Offset = "0x4095A80", VA = "0x184097080", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, T6> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4096AA0", Offset = "0x40954A0", VA = "0x184096AA0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, T7> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4096760", Offset = "0x4095160", VA = "0x184096760", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, T8> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4095D00", Offset = "0x4094700", VA = "0x184095D00", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, T9> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4095920", Offset = "0x4094320", VA = "0x184095920", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ENJPIAJPKHC BGHMDDMEAIE, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4094CE0", Offset = "0x40936E0", VA = "0x184094CE0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ENJPIAJPKHC BGHMDDMEAIE, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x40943E0", Offset = "0x4092DE0", VA = "0x1840943E0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ENJPIAJPKHC BGHMDDMEAIE, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4093F10", Offset = "0x4092910", VA = "0x184093F10", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ENJPIAJPKHC BGHMDDMEAIE, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4093520", Offset = "0x4091F20", VA = "0x184093520", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ENJPIAJPKHC BGHMDDMEAIE, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x863BA30", Offset = "0x863A430", VA = "0x18863BA30", Slot = "234")]
		public void RpcOthersBuffered(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.ODCHKHELOON<MEEBGCNEDOD> PECFHCNLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x4098600", Offset = "0x4097000", VA = "0x184098600", Slot = "235")]
		public void RpcOthersBuffered<T1>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OEOFEEHLMIC<T1, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4098370", Offset = "0x4096D70", VA = "0x184098370", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OHKBPFBNFEB<T1, T2, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4098040", Offset = "0x4096A40", VA = "0x184098040", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.NPLOFDLEAKE<T1, T2, T3, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4097C70", Offset = "0x4096670", VA = "0x184097C70", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.EGLPDDEFBFM<T1, T2, T3, T4, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4097810", Offset = "0x4096210", VA = "0x184097810", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.PBOLLNDKLPA<T1, T2, T3, T4, T5, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x4097320", Offset = "0x4095D20", VA = "0x184097320", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.KLGHEGFAOMN<T1, T2, T3, T4, T5, T6, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4096D90", Offset = "0x4095790", VA = "0x184096D90", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.LOFCEAPKMCO<T1, T2, T3, T4, T5, T6, T7, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4096420", Offset = "0x4094E20", VA = "0x184096420", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(ENJPIAJPKHC BGHMDDMEAIE, AEKFLOMDHLC.OINHCIEHDOK<T1, T2, T3, T4, T5, T6, T7, T8, MEEBGCNEDOD> PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4096090", Offset = "0x4094A90", VA = "0x184096090", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ENJPIAJPKHC BGHMDDMEAIE, JOMCACMFPJC PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4095540", Offset = "0x4093F40", VA = "0x184095540", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ENJPIAJPKHC BGHMDDMEAIE, PGFLGLJELHM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x4095110", Offset = "0x4093B10", VA = "0x184095110", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ENJPIAJPKHC BGHMDDMEAIE, AACAFOMEBMF PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4094860", Offset = "0x4093260", VA = "0x184094860", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ENJPIAJPKHC BGHMDDMEAIE, IJNHPJDMEEL PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4093A40", Offset = "0x4092440", VA = "0x184093A40", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ENJPIAJPKHC BGHMDDMEAIE, IFCGKGMKKGI PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4093000", Offset = "0x4091A00", VA = "0x184093000", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ENJPIAJPKHC BGHMDDMEAIE, JFPBMFGELNM PECFHCNLPEO, T1 ILMHPEGPAPB, T2 EKDFIOKKJLE, T3 GFBDFDPKFCM, T4 BOICDBGMLJL, T5 EKBOBFGNAIA, T6 HLILFHOCJID, T7 ICBCHGDFKAN, T8 DBCCPENBOEA, T9 PGMGPMFJGKF, T10 GLMFCIAJONL, T11 AAFNIBJDIMO, T12 OIMMOGCAEPO, T13 GFEPGGHJEKF, T14 KAJMJFFODJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8638920", Offset = "0x8637320", VA = "0x188638920", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8638B40", Offset = "0x8637540", VA = "0x188638B40", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2145090", Offset = "0x2143A90", VA = "0x182145090")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class OCOLMGODBCM
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8635C60", Offset = "0x8634660", VA = "0x188635C60")]
	private static bool CEMEFAFKDGM(ViewId NMAIBBDGPCD, [Out] RRNetworkView DMJMJBPOHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3F45CB0", Offset = "0x3F446B0", VA = "0x183F45CB0")]
	[CanBeNull]
	public static T NNKIKIALHKD<T>(this ViewId KKGECNGDNCM)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BKLIHHKILAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public FNAEIBBBBBE[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public BKLIHHKILAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8627B70", Offset = "0x8626570", VA = "0x188627B70")]
			internal int DCGDMACOKJI(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8627AE0", Offset = "0x86264E0", VA = "0x188627AE0")]
			internal void DBHGFMJEFPH(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static readonly OLFEOKKCIEG JHGFKLHHPJD;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static FNAEIBBBBBE[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		internal int EKPFOPOJLAF;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x863D080", Offset = "0x863BA80", VA = "0x18863D080")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x863D5C0", Offset = "0x863BFC0", VA = "0x18863D5C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x863D990", Offset = "0x863C390", VA = "0x18863D990")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x863DA10", Offset = "0x863C410", VA = "0x18863DA10")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x863D5B0", Offset = "0x863BFB0", VA = "0x18863D5B0")]
		private void NEEKIOCMJCC(FNAEIBBBBBE PEEGJOGDPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x863D5B0", Offset = "0x863BFB0", VA = "0x18863D5B0")]
		private void KKKPFDHNPLE(FNAEIBBBBBE DIJBLMOBAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x863CE40", Offset = "0x863B840", VA = "0x18863CE40")]
		private void AGHHHLIBECA(FNAEIBBBBBE GPHPGLDNHJA, IDictionary<object, object> FELKPADLKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x863CF30", Offset = "0x863B930", VA = "0x18863CF30")]
		public static void AssignPlayerNumbers(int AGBAEIBCDLN, int KCHAFLFGFIF, Func<int, int> FLFOBEIIHBI, Action<int, int> MEELJECODJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x863DAC0", Offset = "0x863C4C0", VA = "0x18863DAC0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x863D4C0", Offset = "0x863BEC0", VA = "0x18863D4C0")]
		private void CJMPHDPKPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xABE750", Offset = "0xABD150", VA = "0x180ABE750")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HLEBDAHCNOM
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8630C70", Offset = "0x862F670", VA = "0x188630C70")]
	public static int LFBKNMAPADH(this FNAEIBBBBBE BLHNDOLLIDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x86308A0", Offset = "0x862F2A0", VA = "0x1886308A0")]
	public static void DPHDFJFPLAJ(this FNAEIBBBBBE BLHNDOLLIDD, int GAIMEOHIPMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PGNNADKFAJN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void MHLGBJONDNM(Hashtable PIBAONGDHJH);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate void LEDFLBGIHFF(FNAEIBBBBBE BLHNDOLLIDD, Hashtable PIBAONGDHJH);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event MHLGBJONDNM CEGIJFPLHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8636FA0", Offset = "0x86359A0", VA = "0x188636FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8636BE0", Offset = "0x86355E0", VA = "0x188636BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event MHLGBJONDNM KIEMLDOPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8636E20", Offset = "0x8635820", VA = "0x188636E20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8636EE0", Offset = "0x86358E0", VA = "0x188636EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event LEDFLBGIHFF IEOFEOAFNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8636CA0", Offset = "0x86356A0", VA = "0x188636CA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8637060", Offset = "0x8635A60", VA = "0x188637060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event LEDFLBGIHFF MFBGOEBJKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8636B20", Offset = "0x8635520", VA = "0x188636B20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8636D60", Offset = "0x8635760", VA = "0x188636D60")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class HFMAJGOOOHA
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int PKDGADBBLKO;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int NACEAJOAFHN;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int EKAAJJEDKGL;

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x8630790", Offset = "0x862F190", VA = "0x188630790")]
	public static void GGMBOALODKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x8630400", Offset = "0x862EE00", VA = "0x188630400")]
	public static void CDCMDALLIHN(int[] HKDIPDCBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x86304E0", Offset = "0x862EEE0", VA = "0x1886304E0")]
	public static int CKKAHIMFIJJ(int EDOPHOBKPIO, bool CBDAAGJDOIC = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(ENNOOIJMGLD), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class ENNOOIJMGLD : IFIABHDCDBH, KHLGOMKJGNC, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Dictionary<object, object> GBPOFDBNPOG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly Dictionary<object, object> GLOIJCICAJD;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly Dictionary<object, object> NPFECLGPLLP;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly LAAOOMKIIJB GNIJJJAPCHL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly LAAOOMKIIJB NKNLLIDANDI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly LAAOOMKIIJB ENGNAOKNMBE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly LAAOOMKIIJB AGBDMOCOKDC;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly LAAOOMKIIJB JFAHKAOMNJK;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int ILGBEBEMAHN;

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x862F000", Offset = "0x862DA00", VA = "0x18862F000", Slot = "18")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x8630040", Offset = "0x862EA40", VA = "0x188630040", Slot = "19")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x862D700", Offset = "0x862C100", VA = "0x18862D700", Slot = "4")]
	public bool ABICFCCFGAK(FOMKHJAPMGP PDCLAJMPOEB, bool LMDPJKFMLNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x862E4F0", Offset = "0x862CEF0", VA = "0x18862E4F0", Slot = "5")]
	public int FPKNBAIALHE(FOMKHJAPMGP[] IOEHEADJOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x862EDF0", Offset = "0x862D7F0", VA = "0x18862EDF0", Slot = "6")]
	public bool HHBNOGOOBCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x862DFE0", Offset = "0x862C9E0", VA = "0x18862DFE0", Slot = "7")]
	public bool BIEMGBIJIOD(int KKGECNGDNCM, int PJENDFDCMFL, bool OMAFHDNEAEA, GameObject FNCBMCHNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x862D840", Offset = "0x862C240", VA = "0x18862D840", Slot = "8")]
	public void AGIAFAJEAGA(int PJENDFDCMFL, [Optional] int? DMAKEJIPNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x862F400", Offset = "0x862DE00", VA = "0x18862F400", Slot = "9")]
	public bool MJFEBBMKDFC(PJCAKALKNLJ PPGGMEFFGDH, [Out] FOMKHJAPMGP CBEIPIMBCNA, bool FOONDBEGLJE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x862E1B0", Offset = "0x862CBB0", VA = "0x18862E1B0", Slot = "10")]
	public bool EKGBEOOILKE(PJCAKALKNLJ PPGGMEFFGDH, [Out] int IPBPEAPNMBB, [Out] FOMKHJAPMGP[] IOEHEADJOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x862F0A0", Offset = "0x862DAA0", VA = "0x18862F0A0", Slot = "11")]
	public bool JJAFDGPIIIH(PJCAKALKNLJ PPGGMEFFGDH, [Out] int PJENDFDCMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x862E910", Offset = "0x862D310", VA = "0x18862E910", Slot = "12")]
	public void GHDAPJPLPLB(PJCAKALKNLJ PPGGMEFFGDH, [Out] int BNNHPLJFOJF, [Out] int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x862EC10", Offset = "0x862D610", VA = "0x18862EC10", Slot = "13")]
	public void GJIKKNGKEIK(int IPBPEAPNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x862EE80", Offset = "0x862D880", VA = "0x18862EE80", Slot = "14")]
	public void IGFFPOFFLMK(int IPBPEAPNMBB, int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x862F310", Offset = "0x862DD10", VA = "0x18862F310", Slot = "15")]
	public void MBOGAKJHPIG(int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x862F1F0", Offset = "0x862DBF0", VA = "0x18862F1F0", Slot = "16")]
	public void KHFNGAPLLAP(int[] BGFPEGMNFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x862FE70", Offset = "0x862E870", VA = "0x18862FE70", Slot = "17")]
	public void NHENFMBGPBJ(int IPBPEAPNMBB, int PJENDFDCMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x862DA70", Offset = "0x862C470", VA = "0x18862DA70")]
	private static void BDFNFJFOENI(FOMKHJAPMGP PDCLAJMPOEB, Dictionary<object, object> JEHLBHIDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x862F570", Offset = "0x862DF70", VA = "0x18862F570")]
	private static bool MJFEBBMKDFC(Dictionary<object, object> JEHLBHIDJMM, FNAEIBBBBBE HAFACPIKFEN, [Out] FOMKHJAPMGP CBEIPIMBCNA, bool FOONDBEGLJE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x862EB70", Offset = "0x862D570", VA = "0x18862EB70")]
	private static bool GJBDKJMDFDG(int PJENDFDCMFL, FOMKHJAPMGP JEHLBHIDJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x862FD90", Offset = "0x862E790", VA = "0x18862FD90")]
	private static int NAENCDJBCBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ENNOOIJMGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(JHPLKPCJBCH), new string[] { })]
public class JHPLKPCJBCH : JIFLOEMDFOM, KHLGOMKJGNC, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static Hashtable PPKFECGBKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static Hashtable LKJLHNPPDCG;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static LAAOOMKIIJB EINFGOAOPPA;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly LAAOOMKIIJB DDJNALDCPOF;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x86326A0", Offset = "0x86310A0", VA = "0x1886326A0", Slot = "8")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8631F70", Offset = "0x8630970", VA = "0x188631F70", Slot = "7")]
	public void IHHLMHPBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8631E80", Offset = "0x8630880", VA = "0x188631E80", Slot = "4")]
	public void GKONPDCLPGE(ViewId KKGECNGDNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x8631B40", Offset = "0x8630540", VA = "0x188631B40", Slot = "5")]
	public bool BAOHFAAIMDB(PJCAKALKNLJ PPGGMEFFGDH, [Out] ViewId KKGECNGDNCM, [Out] string KNLFOCHNGKB, [Out] int CFIKDBJJGEI, [Out] object[] DNEDADEPKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x8632010", Offset = "0x8630A10", VA = "0x188632010", Slot = "6")]
	public void JFDGCNNBOID(ViewId DMJMJBPOHHC, string KNLFOCHNGKB, OEEBEBBCIPN FDIPMKBDLPJ, FNAEIBBBBBE BLHNDOLLIDD, DOFJGODPLMD LAGDHLHACKC, object[] PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JHPLKPCJBCH()
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
