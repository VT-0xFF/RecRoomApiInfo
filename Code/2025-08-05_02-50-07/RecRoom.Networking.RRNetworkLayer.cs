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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83E7330", Offset = "0x83E6730", VA = "0x1883E7330", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2353DC0", Offset = "0x23531C0", VA = "0x182353DC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83F3C30", Offset = "0x83F3030", VA = "0x1883F3C30")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83F4280", Offset = "0x83F3680", VA = "0x1883F4280")]
		private void NKKCCHCKNGM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83F44F0", Offset = "0x83F38F0", VA = "0x1883F44F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83F45A0", Offset = "0x83F39A0", VA = "0x1883F45A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HBMGPOBGJDL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly AKNCNLDICPO JFINDLBKLHM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AKNCNLDICPO PEPNLHMFEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83E3300", Offset = "0x83E2700", VA = "0x1883E3300")]
		get
		{
			return default(AKNCNLDICPO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GJDKMMFJGAF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView EFNLEGLOEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KGGCLGEMPKG AGEBCLPKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GBBAKMGPICD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(FEELMLJGPOK LAHHGNKBOAL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(BLIANEDIPNN LFDKNECEJEF, FEELMLJGPOK LAHHGNKBOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PJJDBJDGPAN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GINIEOJBPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMEEOHFMKKG(BLIANEDIPNN LFDKNECEJEF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGFNGGGAAON(BLIANEDIPNN LFDKNECEJEF, FEELMLJGPOK LAHHGNKBOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface BBHKAKMPHLO : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAGBOPIEMBE(GJDKMMFJGAF DFLECBMHKHI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDMOJFMGAAL(GJDKMMFJGAF DFLECBMHKHI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEPJKPKHGPB(CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMGGOOJKNPC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHJIGHLODPD(object FCGKHKJBFED);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BLIANEDIPNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CEOKNCPDLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public uint AMIAKHABEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public double ECDMAEBCPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int LPPONMBEHED;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BAHIMABJJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<(ViewId, KGGCLGEMPKG), PJJDBJDGPAN> PGKALGILDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<GJDKMMFJGAF> IIIMECJJGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<(ViewId, KGGCLGEMPKG)> NJAFGAOBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int AJMILABALGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool OKGNONIDIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MemoryStream EKMDEAPBKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FEELMLJGPOK ENNLFLNGFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FEELMLJGPOK CHPDPEKPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] FAHJLFFEPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private float HFHDPLFPKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int FKDCIEMFMCI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83D3620", Offset = "0x83D2A20", VA = "0x1883D3620")]
	public BAHIMABJJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C20", Offset = "0x83D2020", VA = "0x1883D2C20")]
	public void GEPJKPKHGPB(CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83D35D0", Offset = "0x83D29D0", VA = "0x1883D35D0")]
	public void OMGGOOJKNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83D31F0", Offset = "0x83D25F0", VA = "0x1883D31F0")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83D2CC0", Offset = "0x83D20C0", VA = "0x1883D2CC0")]
	public bool KOBMLIBBKBO(GJDKMMFJGAF DFLECBMHKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83D2380", Offset = "0x83D1780", VA = "0x1883D2380")]
	public bool CBDHBFLGDII(GJDKMMFJGAF DFLECBMHKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83D2160", Offset = "0x83D1560", VA = "0x1883D2160")]
	private PJJDBJDGPAN BANILOLAJBD(ViewId MIMIGBMDBGE, KGGCLGEMPKG DKCGGAHOLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C10", Offset = "0x83D2010", VA = "0x1883D2C10")]
	public void FKIPNCBPAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C40", Offset = "0x83D2040", VA = "0x1883D2C40")]
	private void IDHACJPHIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83D2CA0", Offset = "0x83D20A0", VA = "0x1883D2CA0")]
	private void JOOELBKECJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83D2860", Offset = "0x83D1C60", VA = "0x1883D2860")]
	public bool DNOEJEFFCKN(FastBufferWriter HNNLPFDFOLO, int HENPCBPHHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83D24B0", Offset = "0x83D18B0", VA = "0x1883D24B0")]
	public void DGFNGGGAAON(BLIANEDIPNN LFDKNECEJEF, FastBufferReader BPCOJLPPMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class DHGOODMCNOL : PJJDBJDGPAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GJDKMMFJGAF DBBADHDBIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private uint MINEDGIACAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int LCPLKAFNCNG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GINIEOJBPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public DHGOODMCNOL(GJDKMMFJGAF DBBADHDBIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83DF690", Offset = "0x83DEA90", VA = "0x1883DF690", Slot = "5")]
	public bool HMEEOHFMKKG(BLIANEDIPNN LFDKNECEJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83DF5B0", Offset = "0x83DE9B0", VA = "0x1883DF5B0", Slot = "6")]
	public void DGFNGGGAAON(BLIANEDIPNN LFDKNECEJEF, FEELMLJGPOK LAHHGNKBOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HKJEDHDPEIL : PJJDBJDGPAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ViewId MIMIGBMDBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int LCPLKAFNCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private uint MINEDGIACAJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GINIEOJBPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C27330", Offset = "0x1C26730", VA = "0x181C27330")]
	public HKJEDHDPEIL(ViewId MIMIGBMDBGE, CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83E35A0", Offset = "0x83E29A0", VA = "0x1883E35A0", Slot = "5")]
	public bool HMEEOHFMKKG(BLIANEDIPNN LFDKNECEJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83E33C0", Offset = "0x83E27C0", VA = "0x1883E33C0", Slot = "6")]
	public void DGFNGGGAAON(BLIANEDIPNN LFDKNECEJEF, FEELMLJGPOK LAHHGNKBOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DIKKBLPPDJG
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83DFCA0", Offset = "0x83DF0A0", VA = "0x1883DFCA0")]
	public static void COFPFOKABJF(this LPDMMEHBJGN DBDCHOIHLLL, FEELMLJGPOK HGBMJLIBGGN, ViewId HFJHENFIDEF, bool HAGDMPNHAKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83DF7A0", Offset = "0x83DEBA0", VA = "0x1883DF7A0")]
	public static void BOMFJKJDMGF(this LPDMMEHBJGN DBDCHOIHLLL, FEELMLJGPOK HGBMJLIBGGN, bool HAGDMPNHAKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83DFE60", Offset = "0x83DF260", VA = "0x1883DFE60")]
	public static LPDMMEHBJGN DGFNGGGAAON(FEELMLJGPOK HGBMJLIBGGN, ViewId HFJHENFIDEF, bool HAGDMPNHAKO = true)
	{
		return default(LPDMMEHBJGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83DFFD0", Offset = "0x83DF3D0", VA = "0x1883DFFD0")]
	public static void JEJPOHMFKID(this LPDMMEHBJGN DBDCHOIHLLL, FEELMLJGPOK HGBMJLIBGGN, bool HAGDMPNHAKO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RegisterService(typeof(BBHKAKMPHLO), new string[] { })]
public class LBMNPOIFGNC : BBHKAKMPHLO, INetworkUpdateSystem, OJJHPFNNLMN, LLJNOAGPADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly AKNCNLDICPO PDCIPPKAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private BAHIMABJJCA OLEABGCFMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private uint POODLEBLODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float NELBIACGALO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83E60C0", Offset = "0x83E54C0", VA = "0x1883E60C0", Slot = "4")]
	public void AAGBOPIEMBE(GJDKMMFJGAF DFLECBMHKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83E67D0", Offset = "0x83E5BD0", VA = "0x1883E67D0", Slot = "5")]
	public void FDMOJFMGAAL(GJDKMMFJGAF DFLECBMHKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83E6F00", Offset = "0x83E6300", VA = "0x1883E6F00", Slot = "10")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83E7060", Offset = "0x83E6460", VA = "0x1883E7060", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage FADFMJPMION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83E61E0", Offset = "0x83E55E0", VA = "0x1883E61E0")]
	private void DJGIIOPFPKD(uint KKLIMLPCHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83E69D0", Offset = "0x83E5DD0", VA = "0x1883E69D0", Slot = "6")]
	public void GEPJKPKHGPB(CFFCGEADBGP.PMDHHBLABCA BCMEKIBMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83E70E0", Offset = "0x83E64E0", VA = "0x1883E70E0", Slot = "7")]
	public void OMGGOOJKNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83E6A00", Offset = "0x83E5E00", VA = "0x1883E6A00", Slot = "8")]
	public void HHJIGHLODPD(object EGMDPKHDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83E6B80", Offset = "0x83E5F80", VA = "0x1883E6B80")]
	private void IGLCHAOGPNA(APFDEDCIGGF EGMDPKHDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83E6A60", Offset = "0x83E5E60", VA = "0x1883E6A60", Slot = "11")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83E7140", Offset = "0x83E6540", VA = "0x1883E7140")]
	public LBMNPOIFGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NCCKFBKKIJH : PJJDBJDGPAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float PNGFDOEDPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int LCPLKAFNCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint MINEDGIACAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KGGCLGEMPKG AJCGGIFBOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public BLIANEDIPNN BDPBNLDKGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int HIIDDDDPINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] JPDKEDNFOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BLIANEDIPNN MBMOJDCFPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HDNNEJBFOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private byte[] HOEHJONCPLD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GINIEOJBPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83E7B90", Offset = "0x83E6F90", VA = "0x1883E7B90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83E8080", Offset = "0x83E7480", VA = "0x1883E8080")]
	public NCCKFBKKIJH(KGGCLGEMPKG AJCGGIFBOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83E7D70", Offset = "0x83E7170", VA = "0x1883E7D70", Slot = "5")]
	public bool HMEEOHFMKKG(BLIANEDIPNN LFDKNECEJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83E7BC0", Offset = "0x83E6FC0", VA = "0x1883E7BC0", Slot = "6")]
	public void DGFNGGGAAON(BLIANEDIPNN LFDKNECEJEF, FEELMLJGPOK LAHHGNKBOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83E7F70", Offset = "0x83E7370", VA = "0x1883E7F70")]
	internal DHGOODMCNOL IJGDENCAAOG(GJDKMMFJGAF DFLECBMHKHI, FEELMLJGPOK HGBMJLIBGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83E7DB0", Offset = "0x83E71B0", VA = "0x1883E7DB0")]
	private static void HNHMJDGBMFP(DHGOODMCNOL HECCBIHPCBD, FEELMLJGPOK HGBMJLIBGGN, BLIANEDIPNN CEJJMKBNPIP, byte[] JCGBEKOGKKD, int OHGBOHCKDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[RegisterService(typeof(JGDMFMHKLPH), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class JGDMFMHKLPH : LJOIGAFBBOC, OJJHPFNNLMN, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Hashtable BDMMBGNFEGC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Hashtable KMNMIDLOOJA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Hashtable HKMEPOEGCDC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly MIAGGALJIMC CKBAEMOHCPL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly MIAGGALJIMC AEFKLDLHNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly MIAGGALJIMC BODIAJONEFN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly MIAGGALJIMC HCNPGMPNNNN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly MIAGGALJIMC NGBLAHKIPAF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int OMDMGBJCGAD;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83E5AD0", Offset = "0x83E4ED0", VA = "0x1883E5AD0", Slot = "4")]
	public bool POLHNEDIEFA(FJHICBFJMJJ FGEMBJJOPFK, bool FDNKNICIBCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83E4DC0", Offset = "0x83E41C0", VA = "0x1883E4DC0", Slot = "5")]
	public int KBCPMOGJJMD(FJHICBFJMJJ[] PHPPOCOCCLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83E4AB0", Offset = "0x83E3EB0", VA = "0x1883E4AB0", Slot = "6")]
	public bool HBFIIJIOKKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83E57C0", Offset = "0x83E4BC0", VA = "0x1883E57C0", Slot = "7")]
	public bool MHNJBGHABEG(int MIMIGBMDBGE, int MNLGMOODKHI, bool LNHPDGGCMGB, GameObject JBJNKCGNJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83E48C0", Offset = "0x83E3CC0", VA = "0x1883E48C0", Slot = "8")]
	public void EKEFDCLFPEN(int MNLGMOODKHI, [Optional] int? EGFPIGCIONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83E40C0", Offset = "0x83E34C0", VA = "0x1883E40C0", Slot = "9")]
	public bool DLLDIACHNMJ(APFDEDCIGGF FCGKHKJBFED, [Out] FJHICBFJMJJ CGEBCMMMPAJ, bool GOAPNIKDJPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83E3DD0", Offset = "0x83E31D0", VA = "0x1883E3DD0", Slot = "10")]
	public bool DGAKPOBGIGE(APFDEDCIGGF FCGKHKJBFED, [Out] int AGCHPGICICC, [Out] FJHICBFJMJJ[] PHPPOCOCCLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83E5260", Offset = "0x83E4660", VA = "0x1883E5260", Slot = "11")]
	public bool MEIFICHGCFF(APFDEDCIGGF FCGKHKJBFED, [Out] int MNLGMOODKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83E4B40", Offset = "0x83E3F40", VA = "0x1883E4B40", Slot = "12")]
	public void IEJKOOKEDED(APFDEDCIGGF FCGKHKJBFED, [Out] int BBLCHDACEHN, [Out] int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83E39E0", Offset = "0x83E2DE0", VA = "0x1883E39E0", Slot = "13")]
	public void AMPMFABDBDA(int AGCHPGICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83E3CB0", Offset = "0x83E30B0", VA = "0x1883E3CB0", Slot = "14")]
	public void DEBBLKFLJLK(int AGCHPGICICC, int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83E4810", Offset = "0x83E3C10", VA = "0x1883E4810", Slot = "15")]
	public void EEDPGJNFAFA(int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83E5A00", Offset = "0x83E4E00", VA = "0x1883E5A00", Slot = "16")]
	public void PKAIOCKKHFO(int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83E3B40", Offset = "0x83E2F40", VA = "0x1883E3B40", Slot = "17")]
	public void BDCKCPEPFPC(int AGCHPGICICC, int MNLGMOODKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83E5380", Offset = "0x83E4780", VA = "0x1883E5380")]
	private static void MGBCKEAGOOO(FJHICBFJMJJ FGEMBJJOPFK, Hashtable CJNJJHEGLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83E4230", Offset = "0x83E3630", VA = "0x1883E4230")]
	private static bool DLLDIACHNMJ(Hashtable CJNJJHEGLDB, NELIJLIGAOD DOCPCJOAHCL, [Out] FJHICBFJMJJ CGEBCMMMPAJ, bool GOAPNIKDJPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83E5180", Offset = "0x83E4580", VA = "0x1883E5180")]
	private static int MBPGOMKEING()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83E5960", Offset = "0x83E4D60", VA = "0x1883E5960", Slot = "18")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83E4D20", Offset = "0x83E4120", VA = "0x1883E4D20", Slot = "19")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JGDMFMHKLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(GMJDDLKMNIC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class GMJDDLKMNIC : PGOPCDBDLJH, OJJHPFNNLMN, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Hashtable CHJEMBPHBIL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Hashtable HKKIJGHPBCH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static MIAGGALJIMC GNPBKBCOFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly MIAGGALJIMC KKJJCGFKOBA;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83E2A00", Offset = "0x83E1E00", VA = "0x1883E2A00", Slot = "4")]
	public void NKDGOKGFBBN(ViewId MIMIGBMDBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83E2600", Offset = "0x83E1A00", VA = "0x1883E2600", Slot = "5")]
	public bool NBLJOADNIPL(APFDEDCIGGF FCGKHKJBFED, [Out] ViewId MIMIGBMDBGE, [Out] string LLDFMPKDACF, [Out] int NEHLPBKBLMN, [Out] object[] NODDCIHHMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83E2AF0", Offset = "0x83E1EF0", VA = "0x1883E2AF0", Slot = "6")]
	public void OABMENFBOHB(ViewId BPHIDAEMDAO, string LLDFMPKDACF, ONIAKPOCCMO LONCINEFKEG, NELIJLIGAOD NICGPJDLKCM, GJABJKJIDKJ KOONHGMCMGC, object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83E2560", Offset = "0x83E1960", VA = "0x1883E2560", Slot = "8")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83E2960", Offset = "0x83E1D60", VA = "0x1883E2960", Slot = "7")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GMJDDLKMNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JCBMALLJADA
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83E3950", Offset = "0x83E2D50", VA = "0x1883E3950")]
	public static NELIJLIGAOD JODCCNCAPDC(this NNAECDFEPDN BDBJAOEOBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83E3900", Offset = "0x83E2D00", VA = "0x1883E3900")]
	public static NNAECDFEPDN CANFMDJDFJG(this NELIJLIGAOD NICGPJDLKCM)
	{
		return default(NNAECDFEPDN);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, GKPIBMLINMG, LEAENBOEFMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<GDMDNPBCKBN> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId ADBOMMHDMIF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83ECF30", Offset = "0x83EC330", VA = "0x1883ECF30")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId PPIHJGPLKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83ECF30", Offset = "0x83EC330", VA = "0x1883ECF30", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView PKMDJAGDKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83ECFB0", Offset = "0x83EC3B0", VA = "0x1883ECFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView EFNLEGLOEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83ECFB0", Offset = "0x83EC3B0", VA = "0x1883ECFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NELIJLIGAOD HENFGPOKIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83ED0B0", Offset = "0x83EC4B0", VA = "0x1883ED0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NELIJLIGAOD CCGANJILKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83ED410", Offset = "0x83EC810", VA = "0x1883ED410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KAHKIMLDDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83ED210", Offset = "0x83EC610", VA = "0x1883ED210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EAEEBJNAGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83ED380", Offset = "0x83EC780", VA = "0x1883ED380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EIHCHEAEPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83ECE60", Offset = "0x83EC260", VA = "0x1883ECE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DGKKAAJELEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83ED140", Offset = "0x83EC540", VA = "0x1883ED140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GAJKCHMENCK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83ECE60", Offset = "0x83EC260", VA = "0x1883ECE60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NIMEKEBDGII
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83ECEE0", Offset = "0x83EC2E0", VA = "0x1883ECEE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string PKIHKDOIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83ED020", Offset = "0x83EC420", VA = "0x1883ED020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CNDENEEKMHB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x83ECDE0", Offset = "0x83EC1E0", VA = "0x1883ECDE0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<NELIJLIGAOD> EDIJNMCHABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83ECCB0", Offset = "0x83EC0B0", VA = "0x1883ECCB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83ED4A0", Offset = "0x83EC8A0", VA = "0x1883ED4A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83ECC10", Offset = "0x83EC010", VA = "0x1883ECC10")]
		public bool WasSpawnedForPlayer(int AAIBAMBDBMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76CFD20", Offset = "0x76CF120", VA = "0x1876CFD20")]
		private void IJGMNAIEFMO(RRNetworkView PCKIEOGDDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83EC7F0", Offset = "0x83EBBF0", VA = "0x1883EC7F0", Slot = "9")]
		public void RegisterDestroyHandler(GDMDNPBCKBN IGJIAOCAHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83ECA40", Offset = "0x83EBE40", VA = "0x1883ECA40", Slot = "10")]
		public void UnregisterDestroyHandler(GDMDNPBCKBN IGJIAOCAHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83EC7D0", Offset = "0x83EBBD0", VA = "0x1883EC7D0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GGLJICGJNPP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void KPAOPIEOEEI([In] FJHICBFJMJJ FGEMBJJOPFK, bool FAPCIJDLIMG, bool CJNJJHEGLDB, bool OMBCDAEENCG);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void HBIOMMNGAJJ(GameObject MLLLHKPDMHN);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void DDLCFPBBHAA(GameObject MLLLHKPDMHN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void NIPNDCHMIHG(RRNetworkView BPHIDAEMDAO, string LLDFMPKDACF, NELIJLIGAOD IDDLNDPPHII, ONIAKPOCCMO? NJJNDJLGDNH, bool AIALIMJGGNO, GJABJKJIDKJ GENIGHCEGHH, object[] FGEMBJJOPFK, string JNBCCJCHJJN);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void JOHKBODIDLF(RRNetworkView BPHIDAEMDAO, string LLDFMPKDACF, NELIJLIGAOD IDDLNDPPHII, ONIAKPOCCMO? NJJNDJLGDNH, bool AIALIMJGGNO, GJABJKJIDKJ GENIGHCEGHH, object[] FGEMBJJOPFK, string JNBCCJCHJJN);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void APBIJIPAJLM(RRNetworkView BPHIDAEMDAO, string LLDFMPKDACF, object[] NODDCIHHMPD, string MEKGCGCLJOB);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void GOBHIACJELI(RRNetworkView BPHIDAEMDAO, NELIJLIGAOD ODEAKJECIDL);

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CompilerGenerated]
	private static HBIOMMNGAJJ FGKGMDIANEN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event KPAOPIEOEEI JDABBHBGOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83E11F0", Offset = "0x83E05F0", VA = "0x1883E11F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83E18A0", Offset = "0x83E0CA0", VA = "0x1883E18A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event HBIOMMNGAJJ IEIGHJECLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83E1FF0", Offset = "0x83E13F0", VA = "0x1883E1FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83E1540", Offset = "0x83E0940", VA = "0x1883E1540")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event DDLCFPBBHAA DKMFFIPMKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83E1DB0", Offset = "0x83E11B0", VA = "0x1883E1DB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83E1E70", Offset = "0x83E1270", VA = "0x1883E1E70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event DDLCFPBBHAA PDEEMGEHLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83E1A20", Offset = "0x83E0E20", VA = "0x1883E1A20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83E24A0", Offset = "0x83E18A0", VA = "0x1883E24A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event NIPNDCHMIHG HLOPDOJMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83E20B0", Offset = "0x83E14B0", VA = "0x1883E20B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83E1750", Offset = "0x83E0B50", VA = "0x1883E1750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event JOHKBODIDLF NJFAEKPKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83E23E0", Offset = "0x83E17E0", VA = "0x1883E23E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83E1690", Offset = "0x83E0A90", VA = "0x1883E1690")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event APBIJIPAJLM AHDNALEDBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83E1130", Offset = "0x83E0530", VA = "0x1883E1130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83E1CF0", Offset = "0x83E10F0", VA = "0x1883E1CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event GOBHIACJELI LDLAJPAPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F30", Offset = "0x83E1330", VA = "0x1883E1F30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83E1AE0", Offset = "0x83E0EE0", VA = "0x1883E1AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event GOBHIACJELI AEJJDBPNHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83E1370", Offset = "0x83E0770", VA = "0x1883E1370")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83E1960", Offset = "0x83E0D60", VA = "0x1883E1960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x83E12B0", Offset = "0x83E06B0", VA = "0x1883E12B0")]
	public static void AJMPIJMKEHI([In] FJHICBFJMJJ FGEMBJJOPFK, bool FAPCIJDLIMG, bool CJNJJHEGLDB, bool OMBCDAEENCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x83E1810", Offset = "0x83E0C10", VA = "0x1883E1810")]
	public static void GBHHCHDLMMO(GameObject MLLLHKPDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x83E2200", Offset = "0x83E1600", VA = "0x1883E2200")]
	public static void NMCEPIFIODP(GameObject MLLLHKPDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83E2170", Offset = "0x83E1570", VA = "0x1883E2170")]
	public static void MKPIKGEHNHF(GameObject MLLLHKPDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83E1600", Offset = "0x83E0A00", VA = "0x1883E1600")]
	public static void CLGCNJGNGPI(GameObject MLLLHKPDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83E1BA0", Offset = "0x83E0FA0", VA = "0x1883E1BA0")]
	public static void JHLNHDOJOBG(RRNetworkView BPHIDAEMDAO, string LLDFMPKDACF, NELIJLIGAOD IDDLNDPPHII, ONIAKPOCCMO? NJJNDJLGDNH, bool AIALIMJGGNO, GJABJKJIDKJ GENIGHCEGHH, object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x83E2290", Offset = "0x83E1690", VA = "0x1883E2290")]
	public static void OHCGNINNOPH(RRNetworkView BPHIDAEMDAO, string LLDFMPKDACF, int LPHMKIDGKPA, object[] NODDCIHHMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x83E1430", Offset = "0x83E0830", VA = "0x1883E1430")]
	public static void BKCKEIGHHPO(int MIMIGBMDBGE, int BDBJAOEOBNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IGPMFLJCBMG
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x83E3850", Offset = "0x83E2C50", VA = "0x1883E3850")]
	[CanBeNull]
	private static bool PCCILNKGBOP(ViewId CLNGGGMIBPI, [Out] RRNetworkView BPHIDAEMDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83E3770", Offset = "0x83E2B70", VA = "0x1883E3770")]
	[CanBeNull]
	public static Component OEJLJIMEGHD(this ViewId BPHIDAEMDAO, Type OFINMLLNFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D00B00", Offset = "0x3CFFF00", VA = "0x183D00B00")]
	[CanBeNull]
	public static T OEJLJIMEGHD<T>(this ViewId BPHIDAEMDAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D00B00", Offset = "0x3CFFF00", VA = "0x183D00B00")]
	[CanBeNull]
	public static T LDNIALDJBEA<T>(this ViewId BPHIDAEMDAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D00B50", Offset = "0x3CFFF50", VA = "0x183D00B50")]
	public static bool NDDEBMKCHHP<T>(this ViewId BPHIDAEMDAO, [Out] T HJBCDFKDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x83E36A0", Offset = "0x83E2AA0", VA = "0x1883E36A0")]
	[CanBeNull]
	public static RRNetworkView AIIHEEONGEI(this ViewId BPHIDAEMDAO)
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
		private static RRNetworkHandler CDEDDCLKCCJ;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler NKAKNKMIPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x83ED5D0", Offset = "0x83EC9D0", VA = "0x1883ED5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83ED7A0", Offset = "0x83ECBA0", VA = "0x1883ED7A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83ED760", Offset = "0x83ECB60", VA = "0x1883ED760")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[RegisterService(typeof(DDIDOCHEHEP), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public sealed class DDIDOCHEHEP : FBEKAFINLKK, OJJHPFNNLMN, LLJNOAGPADG, NGBDAEKMHIJ, JLKFIOACBKP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HMIJNAPHMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HMIJNAPHMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83E35E0", Offset = "0x83E29E0", VA = "0x1883E35E0")]
		internal object OGDEPJFABGB((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AKNCNLDICPO OBFKLHHGMEI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static AKNCNLDICPO JBOPEKOAIJC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Dictionary<int, HashSet<int>> JLBFKCDDNIN;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Dictionary<int, int> POGEMCJGLFP;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<(GameObject GameObject, int ParentCount)> LHMMPELEKAG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<GameObject> KCDFLAFPPCP;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static List<int> MEKDPEHNCLI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<RRNetworkView> LMHLJCNHNPI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly MIAGGALJIMC HCNPGMPNNNN;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly MIAGGALJIMC NGBLAHKIPAF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x83DE3B0", Offset = "0x83DD7B0", VA = "0x1883DE3B0", Slot = "8")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x83DBCD0", Offset = "0x83DB0D0", VA = "0x1883DBCD0", Slot = "9")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x83DC790", Offset = "0x83DBB90", VA = "0x1883DC790", Slot = "10")]
	public void InitExternal(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83D9F60", Offset = "0x83D9360", VA = "0x1883D9F60", Slot = "11")]
	public void FIHIOOONHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x83DA130", Offset = "0x83D9530", VA = "0x1883DA130")]
	private void GAFJKEFFPEI(OIAMFOGHGKN JGIKKNIAOGF, OIAMFOGHGKN JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x83DC960", Offset = "0x83DBD60", VA = "0x1883DC960")]
	private void JELKAMGDPBM(KKACDBJFHBD HGPOFFAPEIK, KKACDBJFHBD ONKLIGADCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x83DEFE0", Offset = "0x83DE3E0", VA = "0x1883DEFE0")]
	public GameObject PIMMNMKGNEA(string HDNPPEBJPAE, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, Vector3 MJHAIBCGLLD, ViewId MIMIGBMDBGE, NALOKHDCBNN FGEMBJJOPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83D93B0", Offset = "0x83D87B0", VA = "0x1883D93B0")]
	public GameObject DMGGHFBMBEM(string HDNPPEBJPAE, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float MJHAIBCGLLD, object[] FGEMBJJOPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x83D7DF0", Offset = "0x83D71F0", VA = "0x1883D7DF0")]
	public GameObject CAHFMOHHDGE(string HDNPPEBJPAE, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, Vector3 MJHAIBCGLLD, ViewId BPHIDAEMDAO, NALOKHDCBNN FGEMBJJOPFK, bool OMBCDAEENCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x83DCA60", Offset = "0x83DBE60", VA = "0x1883DCA60")]
	public GameObject JKNOEJCPBHO(FJHICBFJMJJ FGEMBJJOPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x83D6EF0", Offset = "0x83D62F0", VA = "0x1883D6EF0", Slot = "6")]
	public void AJMHIHPALLL(GameObject MLLLHKPDMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x83DCA90", Offset = "0x83DBE90", VA = "0x1883DCA90")]
	public void JPJLHMKIKGP(GameObject JBJNKCGNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x83DCB00", Offset = "0x83DBF00", VA = "0x1883DCB00", Slot = "7")]
	public void KCAFOPCBJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x83DA250", Offset = "0x83D9650", VA = "0x1883DA250", Slot = "4")]
	public GameObject[] GFCDECFFEEP(IList<NDENGIDCCAL> EILMPOKFKPI, bool HANMOHJBAKO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x83DB6B0", Offset = "0x83DAAB0", VA = "0x1883DB6B0", Slot = "5")]
	public void HCLAPDBNOKJ(List<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x83D7B50", Offset = "0x83D6F50", VA = "0x1883D7B50")]
	public void BKPGLOLNBGO(GameObject JBJNKCGNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x83DC050", Offset = "0x83DB450", VA = "0x1883DC050")]
	private void IGLCHAOGPNA(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x83D7C30", Offset = "0x83D7030", VA = "0x1883D7C30")]
	private void BPFEMAEAFON(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x83D9CA0", Offset = "0x83D90A0", VA = "0x1883D9CA0")]
	private void FCEHOCNCDAI(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83DDA40", Offset = "0x83DCE40", VA = "0x1883DDA40")]
	private void KCMOJLAINEH(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83DC350", Offset = "0x83DB750", VA = "0x1883DC350")]
	private void IIPLGELBGHA(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x83DA580", Offset = "0x83D9980", VA = "0x1883DA580")]
	private void GJIFFIFENPJ(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x83DDD30", Offset = "0x83DD130", VA = "0x1883DDD30")]
	private void LHGPEDNFIJK(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83D99A0", Offset = "0x83D8DA0", VA = "0x1883D99A0")]
	private GameObject ENDPLNILACA(string BHECMNLMABG, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, Vector3 MJHAIBCGLLD, byte JFINDLBKLHM = 0, [Optional] object[] NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x83DE8E0", Offset = "0x83DDCE0", VA = "0x1883DE8E0")]
	private GameObject PDNFIMIHOCP(FJHICBFJMJJ FGEMBJJOPFK, bool FAPCIJDLIMG = false, bool CJNJJHEGLDB = false, bool OMBCDAEENCG = true, bool AIACKGCNGPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x83DC710", Offset = "0x83DBB10", VA = "0x1883DC710")]
	private static GameObject IPNDDIFOLMK(string BHECMNLMABG, bool KILFLOOHGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x83D6F00", Offset = "0x83D6300", VA = "0x1883D6F00")]
	private static GameObject ALKHMDFNFPH(GameObject MKFMLBCIMEB, FJHICBFJMJJ FGEMBJJOPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83D9B90", Offset = "0x83D8F90", VA = "0x1883D9B90")]
	private static void FALMDDCHKDE(GameObject MLLLHKPDMHN, RRNetworkView BPHIDAEMDAO, [In] FJHICBFJMJJ FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83D7270", Offset = "0x83D6670", VA = "0x1883D7270")]
	private GameObject[] ALNNPFAHAGP(IList<NDENGIDCCAL> EILMPOKFKPI, bool HANMOHJBAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x83D9060", Offset = "0x83D8460", VA = "0x1883D9060")]
	private GameObject[] DCBCHKNEDLJ(FJHICBFJMJJ[] PHPPOCOCCLH, int AGCHPGICICC, NELIJLIGAOD NICGPJDLKCM, GameObject[] PDECKINNPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83D9550", Offset = "0x83D8950", VA = "0x1883D9550")]
	private GameObject EBJCIKLGFIE([In] FJHICBFJMJJ FGEMBJJOPFK, GameObject MKFMLBCIMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x76A5370", Offset = "0x76A4770", VA = "0x1876A5370")]
	private static bool PMBDJBMADBL(bool FAPCIJDLIMG, bool OMBCDAEENCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x83D8080", Offset = "0x83D7480", VA = "0x1883D8080")]
	private void CCNBMHEGLOD(IEnumerable<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83DCB10", Offset = "0x83DBF10", VA = "0x1883DCB10")]
	private void KCGNCPJBEHO(GameObject MLLLHKPDMHN, bool AIACKGCNGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83D6AF0", Offset = "0x83D5EF0", VA = "0x1883D6AF0")]
	private static void ACBHGGKIBKE(IEnumerable<GameObject> DANOFMKBICK, List<(GameObject GameObject, int ParentCount)> CNFCBIONGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83D7110", Offset = "0x83D6510", VA = "0x1883D7110")]
	private void ALNIIOIFGJI(int MNLGMOODKHI, int AGCHPGICICC, bool AIACKGCNGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83D9310", Offset = "0x83D8710", VA = "0x1883D9310")]
	private static int DCNCEPMJCFO(int MNLGMOODKHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83DE880", Offset = "0x83DDC80", VA = "0x1883DE880")]
	private void OPHGGOLPKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83DB160", Offset = "0x83DA560", VA = "0x1883DB160")]
	private void HCKMLKGMFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83DE820", Offset = "0x83DDC20", VA = "0x1883DE820")]
	private static int OHDFJDFBPNN(int NFFMNPGKHGB, bool OMBCDAEENCG = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x83D8F80", Offset = "0x83D8380", VA = "0x1883D8F80")]
	private static int[] DAHGNIIABPI(int ENBKFFNHFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x83D7A50", Offset = "0x83D6E50", VA = "0x1883D7A50")]
	private static int[] BJAHCACKBJA(int CCGANJILKHA, int ENBKFFNHFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x83D9960", Offset = "0x83D8D60", VA = "0x1883D9960")]
	private void EMGLLADPJOK(NELIJLIGAOD JKLJPPBAIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x83DA980", Offset = "0x83D9D80", VA = "0x1883DA980")]
	private void HCDGHBODJGN(NELIJLIGAOD NICGPJDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x83D8CA0", Offset = "0x83D80A0", VA = "0x1883D8CA0")]
	private void CFFFNHHLBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x83DBA90", Offset = "0x83DAE90", VA = "0x1883DBA90")]
	private void IBFGHIFOEAD(NELIJLIGAOD NICGPJDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83D94B0", Offset = "0x83D88B0", VA = "0x1883D94B0")]
	private static void DOLNBNDFAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83DE720", Offset = "0x83DDB20", VA = "0x1883DE720")]
	private void OGHKAKIGOHH(int[] KAFOFKAMACI, int GODCOOIDHAC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DDIDOCHEHEP()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(NOAFGGNGONC), new string[] { "Photon" })]
public class NOAFGGNGONC : OJJHPFNNLMN, LLJNOAGPADG, LKOOGNDAAHO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct AKNFEHEBJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly MethodInfo JFFHLEEGICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Func<MonoBehaviour, object> JHIELHEPCMO;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
		public AKNFEHEBJHJ(MethodInfo JFFHLEEGICJ, [Optional] Func<MonoBehaviour, object> JHIELHEPCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x76BA6E0", Offset = "0x76B9AE0", VA = "0x1876BA6E0")]
		public object CENPNAJCFHF(MonoBehaviour EHFAIEMJOCA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AMEACPFDAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AMEACPFDAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83D2090", Offset = "0x83D1490", VA = "0x1883D2090")]
		internal AKNFEHEBJHJ GJGKMJPNDPM(MethodInfo methodInfo)
		{
			return default(AKNFEHEBJHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4A672D0", Offset = "0x4A666D0", VA = "0x184A672D0")]
		internal object ANELDDJKHNB(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IAEPNHGECGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IAEPNHGECGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76BA690", Offset = "0x76B9A90", VA = "0x1876BA690")]
		internal AKNFEHEBJHJ DALEDGFKING(MethodInfo methodInfo)
		{
			return default(AKNFEHEBJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NCKIHFILBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NCKIHFILBGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x83E80F0", Offset = "0x83E74F0", VA = "0x1883E80F0")]
		internal bool IFLMCLBEDIH(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Dictionary<string, int> NBCFMBDPCMN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static List<string> JOMFMGCJEHF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static int JPMFGMAABHG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Stopwatch PDMMKFFKEIA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Dictionary<MethodInfo, ParameterInfo[]> LLADJOOEJLK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<Type, List<AKNFEHEBJHJ>> IFOOELAKFNE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x83EB920", Offset = "0x83EAD20", VA = "0x1883EB920", Slot = "4")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x83EA700", Offset = "0x83E9B00", VA = "0x1883EA700", Slot = "5")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x83EAC10", Offset = "0x83EA010", VA = "0x1883EAC10")]
	public static bool KBMEPOBLGBO(string LLDFMPKDACF, [Out] int KNKCLEADDFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x83EB730", Offset = "0x83EAB30", VA = "0x1883EB730")]
	public static bool LOLEOJDMPFH(int KNKCLEADDFP, [Out] string LLDFMPKDACF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x83EA850", Offset = "0x83E9C50", VA = "0x1883EA850")]
	private void IGLCHAOGPNA(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x83E8130", Offset = "0x83E7530", VA = "0x1883E8130", Slot = "9")]
	public string ABBAHPKHAGE(APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x83EBE70", Offset = "0x83EB270", VA = "0x1883EBE70", Slot = "8")]
	public void NKDGOKGFBBN(ViewId MIMIGBMDBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x83EACA0", Offset = "0x83EA0A0", VA = "0x1883EACA0", Slot = "6")]
	public void KDHAGGMBMAP(ViewId BPHIDAEMDAO, string LLDFMPKDACF, NELIJLIGAOD NICGPJDLKCM, GJABJKJIDKJ GENIGHCEGHH, params object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x83EAD70", Offset = "0x83EA170", VA = "0x1883EAD70", Slot = "7")]
	public void KDHAGGMBMAP(ViewId BPHIDAEMDAO, string LLDFMPKDACF, ONIAKPOCCMO NJJNDJLGDNH, GJABJKJIDKJ GENIGHCEGHH, params object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83EADA0", Offset = "0x83EA1A0", VA = "0x1883EADA0")]
	private void KDHAGGMBMAP(ViewId BPHIDAEMDAO, string LLDFMPKDACF, ONIAKPOCCMO NJJNDJLGDNH, NELIJLIGAOD NICGPJDLKCM, GJABJKJIDKJ GENIGHCEGHH, params object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x83E8160", Offset = "0x83E7560", VA = "0x1883E8160")]
	private void AGIINKBNDFK(ViewId MIMIGBMDBGE, string LLDFMPKDACF, NELIJLIGAOD KEJCMKLNFBJ, int NEHLPBKBLMN, object[] NODDCIHHMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x83EB270", Offset = "0x83EA670", VA = "0x1883EB270")]
	private static void KFIJKOIEFLP(AKNFEHEBJHJ GAAAFGHGFFJ, MonoBehaviour BOCFMAAMLON, object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x83E9BE0", Offset = "0x83E8FE0", VA = "0x1883E9BE0")]
	private static bool DBCINNFGEFD(ParameterInfo[] HDGNEFKIGAI, Type[] GJONNGALAIK, [Out] bool KCGOOGNJLJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x83E9E10", Offset = "0x83E9210", VA = "0x1883E9E10")]
	private List<AKNFEHEBJHJ> EJJBODECCOM(MonoBehaviour BOCFMAAMLON, Type KDLFHCLCHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x83EB820", Offset = "0x83EAC20", VA = "0x1883EB820")]
	private static IEnumerable<MethodInfo> MLEHJOGCEAN(Type IIHAKBEOLJD, Type LFCCDBHKGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB00", Offset = "0x83E9F00", VA = "0x1883EAB00")]
	public static ParameterInfo[] JCCKDKFPOEK(MethodInfo CCJNCKNOIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NOAFGGNGONC()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x83ED870", Offset = "0x83ECC70", VA = "0x1883ED870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83ED7E0", Offset = "0x83ECBE0", VA = "0x1883ED7E0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, CEBAJGBFBNL, BODNLDOFCKL, HJLMOCPJLCP, DOMLIJNADCE, HGOBNKPBAEB
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum JKDNJGAGEAC
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class JKDHHJHIPML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public JKDHHJHIPML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x83E5F10", Offset = "0x83E5310", VA = "0x1883E5F10")]
			internal bool FMBENHBKPLF(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<int, RRNetworkView> PDJBPHMINHI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static MIAGGALJIMC ANMBPEKHLMF;

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
		private bool GCBHMHKLKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal bool NENJFCFMNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public JKDNJGAGEAC hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool OONHLMEFJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool OHNHHPFBELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int JHDDMPODHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool CNFGOIMCIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int NBFLCEDAGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NELIJLIGAOD CCGANJILKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NELIJLIGAOD CMMGBAOJNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool? CFFPJJNALIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool PGMPHIJIGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool CMECDDENGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal MonoBehaviour[] EBKJLGECMBK;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly AKNCNLDICPO OGKKFOPBPJJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId PPIHJGPLKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x83F1F00", Offset = "0x83F1300", VA = "0x1883F1F00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId JNIGAHJGKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x83F1F00", Offset = "0x83F1300", VA = "0x1883F1F00", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId ADBOMMHDMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x83F1F00", Offset = "0x83F1300", VA = "0x1883F1F00")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int BDLKOJBCBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OMIIPFHCLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ViewId EFLNODHLDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x83F1D70", Offset = "0x83F1170", VA = "0x1883F1D70")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool LNHPDGGCMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KAIGLCLJDCH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x83F1D80", Offset = "0x83F1180", VA = "0x1883F1D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool JILHDIJKLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IJNLFICLOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int KPLLPHLMPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83F1D10", Offset = "0x83F1110", VA = "0x1883F1D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NELIJLIGAOD CHBFNEOBGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x83F1F10", Offset = "0x83F1310", VA = "0x1883F1F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NELIJLIGAOD GFEJFFIDAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83F1CE0", Offset = "0x83F10E0", VA = "0x1883F1CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public NELIJLIGAOD HENFGPOKIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x83F1CE0", Offset = "0x83F10E0", VA = "0x1883F1CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public NELIJLIGAOD HKJJGFHGHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x83F1CE0", Offset = "0x83F10E0", VA = "0x1883F1CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool FKPOPIAHLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x83F1E50", Offset = "0x83F1250", VA = "0x1883F1E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int CMHGOMOMECH
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x83F1D40", Offset = "0x83F1140", VA = "0x1883F1D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public object[] BLJALAHEEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KAHKIMLDDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x83F1F40", Offset = "0x83F1340", VA = "0x1883F1F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CKNKNPCDGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x83F1ED0", Offset = "0x83F12D0", VA = "0x1883F1ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool LFPFNEMDNPA
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xE6C760", Offset = "0xE6BB60", VA = "0x180E6C760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xFD7F10", Offset = "0xFD7310", VA = "0x180FD7F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OLDGACHJNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xCF96D0", Offset = "0xCF8AD0", VA = "0x180CF96D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CGKGGHJNECP
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83F1B80", Offset = "0x83F0F80", VA = "0x1883F1B80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x83F2100", Offset = "0x83F1500", VA = "0x1883F2100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<NELIJLIGAOD> BHGHLFJONKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x83EDB40", Offset = "0x83ECF40", VA = "0x1883EDB40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x83EE820", Offset = "0x83EDC20", VA = "0x1883EE820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<NELIJLIGAOD> KJLNLMKLMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83EDB40", Offset = "0x83ECF40", VA = "0x1883EDB40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83EE820", Offset = "0x83EDC20", VA = "0x1883EE820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> CBJPAMHAMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83EF7F0", Offset = "0x83EEBF0", VA = "0x1883EF7F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83EEAD0", Offset = "0x83EDED0", VA = "0x1883EEAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> MPMCEPACFGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83EF7F0", Offset = "0x83EEBF0", VA = "0x1883EF7F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x83EEAD0", Offset = "0x83EDED0", VA = "0x1883EEAD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> OIPCHLGCIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x83F1C30", Offset = "0x83F1030", VA = "0x1883F1C30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x83F21B0", Offset = "0x83F15B0", VA = "0x1883F21B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action LOFPKPKPJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x83F1AD0", Offset = "0x83F0ED0", VA = "0x1883F1AD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x83F2050", Offset = "0x83F1450", VA = "0x1883F2050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83F1900", Offset = "0x83F0D00", VA = "0x1883F1900")]
		public static bool TryGetNetworkView(int MIMIGBMDBGE, [Out] RRNetworkView BPHIDAEMDAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83EE300", Offset = "0x83ED700", VA = "0x1883EE300")]
		public static RRNetworkView Find(int MIMIGBMDBGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83EE620", Offset = "0x83EDA20", VA = "0x1883EE620")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int DMBIMOMMAHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83EE5B0", Offset = "0x83ED9B0", VA = "0x1883EE5B0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83EFD60", Offset = "0x83EF160", VA = "0x1883EFD60")]
		public static bool RemoveNetworkView(RRNetworkView BPHIDAEMDAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83EFB30", Offset = "0x83EEF30", VA = "0x1883EFB30")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83EF4A0", Offset = "0x83EE8A0", VA = "0x1883EF4A0")]
		public static void OnPlayerJoinedRoom(NELIJLIGAOD BAGOGLDAACB, List<int> KAFOFKAMACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83EE760", Offset = "0x83EDB60", VA = "0x1883EE760")]
		public static RRNetworkView Get(Component FCIHIIPNCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83EE7C0", Offset = "0x83EDBC0", VA = "0x1883EE7C0")]
		public static RRNetworkView Get(GameObject GPNCLOFEHLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83EF020", Offset = "0x83EE420", VA = "0x1883EF020")]
		private void LKODJLLPMOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x83EE200", Offset = "0x83ED600", VA = "0x1883EE200")]
		public bool CreatedBy(NELIJLIGAOD NICGPJDLKCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x83F1710", Offset = "0x83F0B10", VA = "0x1883F1710")]
		public void TransferOwnership(int LMDKACKDEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x83F16B0", Offset = "0x83F0AB0", VA = "0x1883F16B0")]
		public void TransferOwnership(NELIJLIGAOD ODEAKJECIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x83EEC20", Offset = "0x83EE020", VA = "0x1883EEC20", Slot = "4")]
		public void Initialize(ViewId LPOADEEILAO, ViewId FJKHJKAHEMG, Dictionary<int, object> JAIKDDBMDJG, NNAECDFEPDN CCGANJILKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x83EEDA0", Offset = "0x83EE1A0", VA = "0x1883EEDA0")]
		public void Initialize(ViewId LPOADEEILAO, ViewId FJKHJKAHEMG, object[] NMEJHGKBECA, NNAECDFEPDN CCGANJILKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x83EDAE0", Offset = "0x83ECEE0", VA = "0x1883EDAE0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x83EE8D0", Offset = "0x83EDCD0", VA = "0x1883EE8D0")]
		private void HOHFBIIFKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2040B20", Offset = "0x203FF20", VA = "0x182040B20")]
		internal void GOHAPDFMEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83EEF60", Offset = "0x83EE360", VA = "0x1883EEF60", Slot = "6")]
		private void KDPBJGDKACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x83EF8A0", Offset = "0x83EECA0", VA = "0x1883EF8A0")]
		internal bool PHCABFBKDLG(RRNetworkView AEPIEKMLECF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x83EF300", Offset = "0x83EE700", VA = "0x1883EF300")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x83EE550", Offset = "0x83ED950", VA = "0x1883EE550")]
		internal void GKELINOEDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x83EEF50", Offset = "0x83EE350", VA = "0x1883EEF50")]
		private void JEFDOLPBCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83EF100", Offset = "0x83EE500", VA = "0x1883EF100")]
		internal void NBPNHPLFFHF(NELIJLIGAOD ODEAKJECIDL, int LMDKACKDEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x83EFCC0", Offset = "0x83EF0C0", VA = "0x1883EFCC0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83EFDE0", Offset = "0x83EF1E0", VA = "0x1883EFDE0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x83EEB80", Offset = "0x83EDF80", VA = "0x1883EEB80")]
		private void IPFEKECOJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x83ED9F0", Offset = "0x83ECDF0", VA = "0x1883ED9F0")]
		private void AEKODCCILAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83EFAA0", Offset = "0x83EEEA0", VA = "0x1883EFAA0")]
		public void RPC(string LLDFMPKDACF, ONIAKPOCCMO NJJNDJLGDNH, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83EFA10", Offset = "0x83EEE10", VA = "0x1883EFA10")]
		public void RPC(string LLDFMPKDACF, NELIJLIGAOD IDDLNDPPHII, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83EFD10", Offset = "0x83EF110", VA = "0x1883EFD10")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83EDF10", Offset = "0x83ED310", VA = "0x1883EDF10", Slot = "8")]
		public void Bake(JHFFNIJDHNE HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83EE280", Offset = "0x83ED680", VA = "0x1883EE280")]
		private static void DMDBCGEIOAM(NELIJLIGAOD GHOBDALFLGI, [Out] NELIJLIGAOD KHKEJCOHPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83EDBF0", Offset = "0x83ECFF0", VA = "0x1883EDBF0")]
		private static void BFBGJGPALDF(RRNetworkView PKMDJAGDKFA, Delegate GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83EF1C0", Offset = "0x83EE5C0", VA = "0x1883EF1C0")]
		private static DBOHBCPJIND NCDIICCEINP(RRNetworkView PKMDJAGDKFA)
		{
			return default(DBOHBCPJIND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x83EE390", Offset = "0x83ED790", VA = "0x1883EE390")]
		private static void GCOPIKDEGCO(RRNetworkView PKMDJAGDKFA, Delegate GAAAFGHGFFJ, NELIJLIGAOD NGAJCILJMBG, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x83EE470", Offset = "0x83ED870", VA = "0x1883EE470")]
		private static void GCOPIKDEGCO(RRNetworkView PKMDJAGDKFA, Delegate GAAAFGHGFFJ, ONIAKPOCCMO NGAJCILJMBG, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83EEE00", Offset = "0x83EE200", VA = "0x1883EEE00")]
		private static void JDLHIFEFLDC(RRNetworkView PKMDJAGDKFA, Delegate GAAAFGHGFFJ, ONIAKPOCCMO NGAJCILJMBG, MBDIBBJHIMM GPDFPMNBDOO, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83EF910", Offset = "0x83EED10", VA = "0x1883EF910")]
		public void RPCBuffered(string LLDFMPKDACF, ONIAKPOCCMO NJJNDJLGDNH, MBDIBBJHIMM GENIGHCEGHH, params object[] FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83EF260", Offset = "0x83EE660", VA = "0x1883EF260")]
		private static bool NOGNMKNOOMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83F0290", Offset = "0x83EF690", VA = "0x1883F0290", Slot = "26")]
		public void RpcAll(DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3F80D20", Offset = "0x3F80120", VA = "0x183F80D20", Slot = "9")]
		public void RpcAll<T1>(DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3F80570", Offset = "0x3F7F970", VA = "0x183F80570", Slot = "10")]
		public void RpcAll<T1, T2>(DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3F82A00", Offset = "0x3F81E00", VA = "0x183F82A00", Slot = "27")]
		public void RpcAll<T1, T2, T3>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3F80790", Offset = "0x3F7FB90", VA = "0x183F80790", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F823B0", Offset = "0x3F817B0", VA = "0x183F823B0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3F82F00", Offset = "0x3F82300", VA = "0x183F82F00", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3F839F0", Offset = "0x3F82DF0", VA = "0x183F839F0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3F884B0", Offset = "0x3F878B0", VA = "0x183F884B0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3F833B0", Offset = "0x3F827B0", VA = "0x183F833B0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3F817A0", Offset = "0x3F80BA0", VA = "0x183F817A0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E3F0", Offset = "0x3F8D7F0", VA = "0x183F8E3F0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D900", Offset = "0x3F8CD00", VA = "0x183F8D900", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CD30", Offset = "0x3F8C130", VA = "0x183F8CD30", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3F80EB0", Offset = "0x3F802B0", VA = "0x183F80EB0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83F0400", Offset = "0x83EF800", VA = "0x1883F0400", Slot = "36")]
		public void RpcAll(DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3F85C00", Offset = "0x3F85000", VA = "0x183F85C00", Slot = "37")]
		public void RpcAll<T1>(DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3F866A0", Offset = "0x3F85AA0", VA = "0x183F866A0", Slot = "38")]
		public void RpcAll<T1, T2>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3F82090", Offset = "0x3F81490", VA = "0x183F82090", Slot = "39")]
		public void RpcAll<T1, T2, T3>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3F919E0", Offset = "0x3F90DE0", VA = "0x183F919E0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F911A0", Offset = "0x3F905A0", VA = "0x183F911A0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F90E30", Offset = "0x3F90230", VA = "0x183F90E30", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F903C0", Offset = "0x3F8F7C0", VA = "0x183F903C0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F8FF90", Offset = "0x3F8F390", VA = "0x183F8FF90", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3F8F710", Offset = "0x3F8EB10", VA = "0x183F8F710", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E900", Offset = "0x3F8DD00", VA = "0x183F8E900", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3F8DE90", Offset = "0x3F8D290", VA = "0x183F8DE90", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D330", Offset = "0x3F8C730", VA = "0x183F8D330", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C6F0", Offset = "0x3F8BAF0", VA = "0x183F8C6F0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C040", Offset = "0x3F8B440", VA = "0x183F8C040", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83F0030", Offset = "0x83EF430", VA = "0x1883F0030", Slot = "51")]
		public void RpcAllViaServer(DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F80460", Offset = "0x3F7F860", VA = "0x183F80460", Slot = "52")]
		public void RpcAllViaServer<T1>(DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A9C0", Offset = "0x3F79DC0", VA = "0x183F7A9C0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FEE0", Offset = "0x3F7F2E0", VA = "0x183F7FEE0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FB20", Offset = "0x3F7EF20", VA = "0x183F7FB20", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F450", Offset = "0x3F7E850", VA = "0x183F7F450", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EEF0", Offset = "0x3F7E2F0", VA = "0x183F7EEF0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E8F0", Offset = "0x3F7DCF0", VA = "0x183F7E8F0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E5A0", Offset = "0x3F7D9A0", VA = "0x183F7E5A0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DEB0", Offset = "0x3F7D2B0", VA = "0x183F7DEB0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D330", Offset = "0x3F7C730", VA = "0x183F7D330", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CAB0", Offset = "0x3F7BEB0", VA = "0x183F7CAB0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C620", Offset = "0x3F7BA20", VA = "0x183F7C620", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BCA0", Offset = "0x3F7B0A0", VA = "0x183F7BCA0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B270", Offset = "0x3F7A670", VA = "0x183F7B270", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83F0160", Offset = "0x83EF560", VA = "0x1883F0160", Slot = "65")]
		public void RpcAllViaServer(DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3F80350", Offset = "0x3F7F750", VA = "0x183F80350", Slot = "66")]
		public void RpcAllViaServer<T1>(DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F801F0", Offset = "0x3F7F5F0", VA = "0x183F801F0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FD30", Offset = "0x3F7F130", VA = "0x183F7FD30", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F910", Offset = "0x3F7ED10", VA = "0x183F7F910", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F6B0", Offset = "0x3F7EAB0", VA = "0x183F7F6B0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F1A0", Offset = "0x3F7E5A0", VA = "0x183F7F1A0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EBF0", Offset = "0x3F7DFF0", VA = "0x183F7EBF0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E250", Offset = "0x3F7D650", VA = "0x183F7E250", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DB10", Offset = "0x3F7CF10", VA = "0x183F7DB10", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D720", Offset = "0x3F7CB20", VA = "0x183F7D720", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F7CEF0", Offset = "0x3F7C2F0", VA = "0x183F7CEF0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C190", Offset = "0x3F7B590", VA = "0x183F7C190", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B7B0", Offset = "0x3F7ABB0", VA = "0x183F7B7B0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F7AD30", Offset = "0x3F7A130", VA = "0x183F7AD30", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x83F0F50", Offset = "0x83F0350", VA = "0x1883F0F50", Slot = "80")]
		public void RpcOthers(DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB4F0", Offset = "0x3FBA8F0", VA = "0x183FBB4F0", Slot = "15")]
		public void RpcOthers<T1>(DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3FBBDF0", Offset = "0x3FBB1F0", VA = "0x183FBBDF0", Slot = "81")]
		public void RpcOthers<T1, T2>(DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB270", Offset = "0x3FBA670", VA = "0x183FBB270", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3FC2430", Offset = "0x3FC1830", VA = "0x183FC2430", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1F80", Offset = "0x3FC1380", VA = "0x183FC1F80", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3FBCBA0", Offset = "0x3FBBFA0", VA = "0x183FBCBA0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1440", Offset = "0x3FC0840", VA = "0x183FC1440", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0DB0", Offset = "0x3FC01B0", VA = "0x183FC0DB0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0680", Offset = "0x3FBFA80", VA = "0x183FC0680", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3FBFEB0", Offset = "0x3FBF2B0", VA = "0x183FBFEB0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3FBF640", Offset = "0x3FBEA40", VA = "0x183FBF640", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE860", Offset = "0x3FBDC60", VA = "0x183FBE860", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3FBDE40", Offset = "0x3FBD240", VA = "0x183FBDE40", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD8D0", Offset = "0x3FBCCD0", VA = "0x183FBD8D0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x83F10A0", Offset = "0x83F04A0", VA = "0x1883F10A0", Slot = "93")]
		public void RpcOthers(DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3FBBB30", Offset = "0x3FBAF30", VA = "0x183FBBB30", Slot = "94")]
		public void RpcOthers<T1>(DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB940", Offset = "0x3FBAD40", VA = "0x183FBB940", Slot = "95")]
		public void RpcOthers<T1, T2>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3040", Offset = "0x3FC2440", VA = "0x183FC3040", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB650", Offset = "0x3FBAA50", VA = "0x183FBB650", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3FBC300", Offset = "0x3FBB700", VA = "0x183FBC300", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3FBC650", Offset = "0x3FBBA50", VA = "0x183FBC650", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1120", Offset = "0x3FC0520", VA = "0x183FC1120", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0A40", Offset = "0x3FBFE40", VA = "0x183FC0A40", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3FC02C0", Offset = "0x3FBF6C0", VA = "0x183FC02C0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3FBFAA0", Offset = "0x3FBEEA0", VA = "0x183FBFAA0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3FBF1E0", Offset = "0x3FBE5E0", VA = "0x183FBF1E0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FBED20", Offset = "0x3FBE120", VA = "0x183FBED20", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE350", Offset = "0x3FBD750", VA = "0x183FBE350", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD360", Offset = "0x3FBC760", VA = "0x183FBD360", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x83F0A40", Offset = "0x83EFE40", VA = "0x1883F0A40", Slot = "108")]
		public void RpcMaster(DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FA57B0", Offset = "0x3FA4BB0", VA = "0x183FA57B0", Slot = "109")]
		public void RpcMaster<T1>(DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5B60", Offset = "0x3FA4F60", VA = "0x183FA5B60", Slot = "17")]
		public void RpcMaster<T1, T2>(DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3FA54E0", Offset = "0x3FA48E0", VA = "0x183FA54E0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5180", Offset = "0x3FA4580", VA = "0x183FA5180", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9240", Offset = "0x3FA8640", VA = "0x183FA9240", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB6C0", Offset = "0x3FAAAC0", VA = "0x183FAB6C0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1880", Offset = "0x3FB0C80", VA = "0x183FB1880", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1070", Offset = "0x3FB0470", VA = "0x183FB1070", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0790", Offset = "0x3FAFB90", VA = "0x183FB0790", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3FA89F0", Offset = "0x3FA7DF0", VA = "0x183FA89F0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3FA75F0", Offset = "0x3FA69F0", VA = "0x183FA75F0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FAE850", Offset = "0x3FADC50", VA = "0x183FAE850", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3FADC60", Offset = "0x3FAD060", VA = "0x183FADC60", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FAC8E0", Offset = "0x3FABCE0", VA = "0x183FAC8E0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x83F0BD0", Offset = "0x83EFFD0", VA = "0x1883F0BD0", Slot = "122")]
		public void RpcMaster(DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5960", Offset = "0x3FA4D60", VA = "0x183FA5960", Slot = "123")]
		public void RpcMaster<T1>(DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6600", Offset = "0x3FA5A00", VA = "0x183FA6600", Slot = "124")]
		public void RpcMaster<T1, T2>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5DB0", Offset = "0x3FA51B0", VA = "0x183FA5DB0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3FB2980", Offset = "0x3FB1D80", VA = "0x183FB2980", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9C80", Offset = "0x3FA9080", VA = "0x183FA9C80", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1C40", Offset = "0x3FB1040", VA = "0x183FB1C40", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1480", Offset = "0x3FB0880", VA = "0x183FB1480", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0C00", Offset = "0x3FB0000", VA = "0x183FB0C00", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3FB02C0", Offset = "0x3FAF6C0", VA = "0x183FB02C0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3FAFD90", Offset = "0x3FAF190", VA = "0x183FAFD90", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF330", Offset = "0x3FAE730", VA = "0x183FAF330", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3FAE260", Offset = "0x3FAD660", VA = "0x183FAE260", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD610", Offset = "0x3FACA10", VA = "0x183FAD610", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3FACF50", Offset = "0x3FAC350", VA = "0x183FACF50", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x83F0630", Offset = "0x83EFA30", VA = "0x1883F0630", Slot = "137")]
		public void RpcAuthority(DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F98A50", Offset = "0x3F97E50", VA = "0x183F98A50", Slot = "138")]
		public void RpcAuthority<T1>(DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F99860", Offset = "0x3F98C60", VA = "0x183F99860", Slot = "139")]
		public void RpcAuthority<T1, T2>(DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A010", Offset = "0x3F99410", VA = "0x183F9A010", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F99520", Offset = "0x3F98920", VA = "0x183F99520", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D5A0", Offset = "0x3F9C9A0", VA = "0x183F9D5A0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3CD0", Offset = "0x3FA30D0", VA = "0x183FA3CD0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3900", Offset = "0x3FA2D00", VA = "0x183FA3900", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3FA2C30", Offset = "0x3FA2030", VA = "0x183FA2C30", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3FA22C0", Offset = "0x3FA16C0", VA = "0x183FA22C0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1890", Offset = "0x3FA0C90", VA = "0x183FA1890", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1340", Offset = "0x3FA0740", VA = "0x183FA1340", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D9B0", Offset = "0x3F9CDB0", VA = "0x183F9D9B0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F570", Offset = "0x3F9E970", VA = "0x183F9F570", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F9E820", Offset = "0x3F9DC20", VA = "0x183F9E820", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83F07E0", Offset = "0x83EFBE0", VA = "0x1883F07E0", Slot = "152")]
		public void RpcAuthority(DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B830", Offset = "0x3F9AC30", VA = "0x183F9B830", Slot = "153")]
		public void RpcAuthority<T1>(DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B200", Offset = "0x3F9A600", VA = "0x183F9B200", Slot = "154")]
		public void RpcAuthority<T1, T2>(DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F9ACF0", Offset = "0x3F9A0F0", VA = "0x183F9ACF0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A510", Offset = "0x3F99910", VA = "0x183F9A510", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FA43F0", Offset = "0x3FA37F0", VA = "0x183FA43F0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4030", Offset = "0x3FA3430", VA = "0x183FA4030", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3FA34E0", Offset = "0x3FA28E0", VA = "0x183FA34E0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3060", Offset = "0x3FA2460", VA = "0x183FA3060", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FA2750", Offset = "0x3FA1B50", VA = "0x183FA2750", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1D80", Offset = "0x3FA1180", VA = "0x183FA1D80", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3FA0DA0", Offset = "0x3FA01A0", VA = "0x183FA0DA0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3FA01F0", Offset = "0x3F9F5F0", VA = "0x183FA01F0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F9FB90", Offset = "0x3F9EF90", VA = "0x183F9FB90", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F9EEA0", Offset = "0x3F9E2A0", VA = "0x183F9EEA0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x83F14B0", Offset = "0x83F08B0", VA = "0x1883F14B0", Slot = "18")]
		public void RpcPlayer(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4520", Offset = "0x3FC3920", VA = "0x183FC4520", Slot = "19")]
		public void RpcPlayer<T1>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5480", Offset = "0x3FC4880", VA = "0x183FC5480", Slot = "20")]
		public void RpcPlayer<T1, T2>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4E90", Offset = "0x3FC4290", VA = "0x183FC4E90", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3FC46F0", Offset = "0x3FC3AF0", VA = "0x183FC46F0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8FC0", Offset = "0x3FC83C0", VA = "0x183FC8FC0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8B50", Offset = "0x3FC7F50", VA = "0x183FC8B50", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3FC93B0", Offset = "0x3FC87B0", VA = "0x183FC93B0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9880", Offset = "0x3FC8C80", VA = "0x183FC9880", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF870", Offset = "0x3FCEC70", VA = "0x183FCF870", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3FCE930", Offset = "0x3FCDD30", VA = "0x183FCE930", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NELIJLIGAOD NICGPJDLKCM, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5D70", Offset = "0x3FC5170", VA = "0x183FC5D70", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NELIJLIGAOD NICGPJDLKCM, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3FCD240", Offset = "0x3FCC640", VA = "0x183FCD240", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NELIJLIGAOD NICGPJDLKCM, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCC10", Offset = "0x3FCC010", VA = "0x183FCCC10", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(NELIJLIGAOD NICGPJDLKCM, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FCBF00", Offset = "0x3FCB300", VA = "0x183FCBF00", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NELIJLIGAOD NICGPJDLKCM, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x83F11F0", Offset = "0x83F05F0", VA = "0x1883F11F0", Slot = "176")]
		public void RpcPlayer(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4A90", Offset = "0x3FC3E90", VA = "0x183FC4A90", Slot = "177")]
		public void RpcPlayer<T1>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5A80", Offset = "0x3FC4E80", VA = "0x183FC5A80", Slot = "24")]
		public void RpcPlayer<T1, T2>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5700", Offset = "0x3FC4B00", VA = "0x183FC5700", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3FC75C0", Offset = "0x3FC69C0", VA = "0x183FC75C0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1510", Offset = "0x3FD0910", VA = "0x183FD1510", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0DD0", Offset = "0x3FD01D0", VA = "0x183FD0DD0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3FD05D0", Offset = "0x3FCF9D0", VA = "0x183FD05D0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0140", Offset = "0x3FCF540", VA = "0x183FD0140", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(NELIJLIGAOD NICGPJDLKCM, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF380", Offset = "0x3FCE780", VA = "0x183FCF380", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NELIJLIGAOD NICGPJDLKCM, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3FCEE30", Offset = "0x3FCE230", VA = "0x183FCEE30", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(NELIJLIGAOD NICGPJDLKCM, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDE20", Offset = "0x3FCD220", VA = "0x183FCDE20", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(NELIJLIGAOD NICGPJDLKCM, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3FCD800", Offset = "0x3FCCC00", VA = "0x183FCD800", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(NELIJLIGAOD NICGPJDLKCM, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3FCC590", Offset = "0x3FCB990", VA = "0x183FCC590", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(NELIJLIGAOD NICGPJDLKCM, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4EE0", Offset = "0x3FD42E0", VA = "0x183FD4EE0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(NELIJLIGAOD NICGPJDLKCM, NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x83EFF90", Offset = "0x83EF390", VA = "0x1883EFF90", Slot = "189")]
		public void RpcAllBuffered(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A780", Offset = "0x3F79B80", VA = "0x183F7A780", Slot = "190")]
		public void RpcAllBuffered<T1>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A4A0", Offset = "0x3F798A0", VA = "0x183F7A4A0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A2E0", Offset = "0x3F796E0", VA = "0x183F7A2E0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3F79D00", Offset = "0x3F79100", VA = "0x183F79D00", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3F79AA0", Offset = "0x3F78EA0", VA = "0x183F79AA0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3F792E0", Offset = "0x3F786E0", VA = "0x183F792E0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3F78FE0", Offset = "0x3F783E0", VA = "0x183F78FE0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3F78620", Offset = "0x3F77A20", VA = "0x183F78620", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3F78270", Offset = "0x3F77670", VA = "0x183F78270", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3F77AC0", Offset = "0x3F76EC0", VA = "0x183F77AC0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MBDIBBJHIMM GENIGHCEGHH, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3F77270", Offset = "0x3F76670", VA = "0x183F77270", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MBDIBBJHIMM GENIGHCEGHH, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3F76980", Offset = "0x3F75D80", VA = "0x183F76980", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MBDIBBJHIMM GENIGHCEGHH, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3F75AE0", Offset = "0x3F74EE0", VA = "0x183F75AE0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MBDIBBJHIMM GENIGHCEGHH, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3F75590", Offset = "0x3F74990", VA = "0x183F75590", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MBDIBBJHIMM GENIGHCEGHH, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEF0", Offset = "0x83EF2F0", VA = "0x1883EFEF0", Slot = "204")]
		public void RpcAllBuffered(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A8A0", Offset = "0x3F79CA0", VA = "0x183F7A8A0", Slot = "205")]
		public void RpcAllBuffered<T1>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A610", Offset = "0x3F79A10", VA = "0x183F7A610", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A120", Offset = "0x3F79520", VA = "0x183F7A120", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3F79F10", Offset = "0x3F79310", VA = "0x183F79F10", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3F79840", Offset = "0x3F78C40", VA = "0x183F79840", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3F79590", Offset = "0x3F78990", VA = "0x183F79590", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3F78CE0", Offset = "0x3F780E0", VA = "0x183F78CE0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3F78980", Offset = "0x3F77D80", VA = "0x183F78980", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3F77EC0", Offset = "0x3F772C0", VA = "0x183F77EC0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MBDIBBJHIMM GENIGHCEGHH, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3F776C0", Offset = "0x3F76AC0", VA = "0x183F776C0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MBDIBBJHIMM GENIGHCEGHH, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3F76E20", Offset = "0x3F76220", VA = "0x183F76E20", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MBDIBBJHIMM GENIGHCEGHH, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F764E0", Offset = "0x3F758E0", VA = "0x183F764E0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MBDIBBJHIMM GENIGHCEGHH, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3F75FE0", Offset = "0x3F753E0", VA = "0x183F75FE0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MBDIBBJHIMM GENIGHCEGHH, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3F75040", Offset = "0x3F74440", VA = "0x183F75040", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MBDIBBJHIMM GENIGHCEGHH, NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x83F0E10", Offset = "0x83F0210", VA = "0x1883F0E10", Slot = "219")]
		public void RpcOthersBuffered(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.DDCBMAHHLAL GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB150", Offset = "0x3FBA550", VA = "0x183FBB150", Slot = "220")]
		public void RpcOthersBuffered<T1>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.AKNEPFJEEEJ<T1> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3FBAD50", Offset = "0x3FBA150", VA = "0x183FBAD50", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JMEHJBDMAOD<T1, T2> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA9D0", Offset = "0x3FB9DD0", VA = "0x183FBA9D0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, T3> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA7C0", Offset = "0x3FB9BC0", VA = "0x183FBA7C0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, T4> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA350", Offset = "0x3FB9750", VA = "0x183FBA350", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, T5> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9E40", Offset = "0x3FB9240", VA = "0x183FB9E40", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, T6> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9890", Offset = "0x3FB8C90", VA = "0x183FB9890", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, T7> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8ED0", Offset = "0x3FB82D0", VA = "0x183FB8ED0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, T8> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8770", Offset = "0x3FB7B70", VA = "0x183FB8770", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, T9> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7F70", Offset = "0x3FB7370", VA = "0x183FB7F70", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MBDIBBJHIMM GENIGHCEGHH, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7B20", Offset = "0x3FB6F20", VA = "0x183FB7B20", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MBDIBBJHIMM GENIGHCEGHH, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7230", Offset = "0x3FB6630", VA = "0x183FB7230", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MBDIBBJHIMM GENIGHCEGHH, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6390", Offset = "0x3FB5790", VA = "0x183FB6390", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MBDIBBJHIMM GENIGHCEGHH, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5E40", Offset = "0x3FB5240", VA = "0x183FB5E40", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MBDIBBJHIMM GENIGHCEGHH, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x83F0EB0", Offset = "0x83F02B0", VA = "0x1883F0EB0", Slot = "234")]
		public void RpcOthersBuffered(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.AKNEPFJEEEJ<DBOHBCPJIND> GAAAFGHGFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB030", Offset = "0x3FBA430", VA = "0x183FBB030", Slot = "235")]
		public void RpcOthersBuffered<T1>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JMEHJBDMAOD<T1, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3FBAEC0", Offset = "0x3FBA2C0", VA = "0x183FBAEC0", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JIKIGENGBEJ<T1, T2, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3FBAB90", Offset = "0x3FB9F90", VA = "0x183FBAB90", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.KPIIHDNPKLC<T1, T2, T3, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA5B0", Offset = "0x3FB99B0", VA = "0x183FBA5B0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LOOBIGIANDD<T1, T2, T3, T4, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA0F0", Offset = "0x3FB94F0", VA = "0x183FBA0F0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.JJHHJBFHAML<T1, T2, T3, T4, T5, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9B90", Offset = "0x3FB8F90", VA = "0x183FB9B90", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.LCDHOCCJHKH<T1, T2, T3, T4, T5, T6, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9590", Offset = "0x3FB8990", VA = "0x183FB9590", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.OHMLJFGELOB<T1, T2, T3, T4, T5, T6, T7, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9230", Offset = "0x3FB8630", VA = "0x183FB9230", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MBDIBBJHIMM GENIGHCEGHH, DCCJBFDGODD.FBAFNNAPPKL<T1, T2, T3, T4, T5, T6, T7, T8, DBOHBCPJIND> GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8B20", Offset = "0x3FB7F20", VA = "0x183FB8B20", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MBDIBBJHIMM GENIGHCEGHH, KIFDBCLMIJI GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8370", Offset = "0x3FB7770", VA = "0x183FB8370", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MBDIBBJHIMM GENIGHCEGHH, AFKPDAIDPCM GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3FB76D0", Offset = "0x3FB6AD0", VA = "0x183FB76D0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MBDIBBJHIMM GENIGHCEGHH, NIBAABJKKOO GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6D90", Offset = "0x3FB6190", VA = "0x183FB6D90", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MBDIBBJHIMM GENIGHCEGHH, BCGKBJGMCGD GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6890", Offset = "0x3FB5C90", VA = "0x183FB6890", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MBDIBBJHIMM GENIGHCEGHH, DEOENKJBGHF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3FB58F0", Offset = "0x3FB4CF0", VA = "0x183FB58F0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MBDIBBJHIMM GENIGHCEGHH, NDOCCCLEDFF GAAAFGHGFFJ, T1 BADJHCKOHBN, T2 CHJAPFIIKJO, T3 DJFGPEGAJKH, T4 DJFBPCKDOMA, T5 IKICNBECEEH, T6 GOHLFPHEJDO, T7 DNLKMEABDHK, T8 ACCCKJBLJJH, T9 OLMACKAKBLL, T10 KCIBENLCJMK, T11 NOJHMBAAHAB, T12 PCDBMINDHJL, T13 PAILIOLJMKL, T14 AJIIJKLEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x83EDF80", Offset = "0x83ED380", VA = "0x1883EDF80", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x83EE1A0", Offset = "0x83ED5A0", VA = "0x1883EE1A0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2092C70", Offset = "0x2092070", VA = "0x182092C70")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CCAJJBJFMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x83D3C20", Offset = "0x83D3020", VA = "0x1883D3C20")]
	private static bool EPMCNAFDMCE(ViewId CLNGGGMIBPI, [Out] RRNetworkView BPHIDAEMDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F9D0", Offset = "0x3A9EDD0", VA = "0x183A9F9D0")]
	[CanBeNull]
	public static T JPLBDMNAAOK<T>(this ViewId MIMIGBMDBGE)
	{
		return (T)null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LMBBEHNLIPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public NELIJLIGAOD[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LMBBEHNLIPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x83E72B0", Offset = "0x83E66B0", VA = "0x1883E72B0")]
			internal int NDDPMGHFOCM(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x83E7220", Offset = "0x83E6620", VA = "0x1883E7220")]
			internal void FMGLBBMJLBE(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly AKNCNLDICPO CCLJCJDJCOE;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static NELIJLIGAOD[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int BGKLAOKGEEM;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x83F24A0", Offset = "0x83F18A0", VA = "0x1883F24A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x83F29D0", Offset = "0x83F1DD0", VA = "0x1883F29D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x83F2DA0", Offset = "0x83F21A0", VA = "0x1883F2DA0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x83F2E20", Offset = "0x83F2220", VA = "0x1883F2E20")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x83F28E0", Offset = "0x83F1CE0", VA = "0x1883F28E0")]
		private void BOLKLEKFCKP(NELIJLIGAOD BAGOGLDAACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x83F28E0", Offset = "0x83F1CE0", VA = "0x1883F28E0")]
		private void HCDGHBODJGN(NELIJLIGAOD PBHGJPECGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x83F28F0", Offset = "0x83F1CF0", VA = "0x1883F28F0")]
		private void NHCAJAMBKAE(NELIJLIGAOD IDDLNDPPHII, IDictionary<object, object> IAJKDBGHJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x83F2350", Offset = "0x83F1750", VA = "0x1883F2350")]
		public static void AssignPlayerNumbers(int BBLMLANBEMB, int FIEHGCKCIAJ, Func<int, int> IOCKFGIDDDG, Action<int, int> ODOANJOODEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x83F2ED0", Offset = "0x83F22D0", VA = "0x1883F2ED0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x83F2260", Offset = "0x83F1660", VA = "0x1883F2260")]
		private void ADPFHJMOKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA7FA80", Offset = "0xA7EE80", VA = "0x180A7FA80")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PPKFEAIFEMB
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x83EC1E0", Offset = "0x83EB5E0", VA = "0x1883EC1E0")]
	public static int CCPEBOJEPDE(this NELIJLIGAOD NICGPJDLKCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x83EC380", Offset = "0x83EB780", VA = "0x1883EC380")]
	public static void KELIGOPDHMC(this NELIJLIGAOD NICGPJDLKCM, int NEGFLHPAGGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MLJIAGHGBEP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void IAMOGHEFAJE(Hashtable GALOKDCMNPH);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void OFHODKJFKFC(NELIJLIGAOD NICGPJDLKCM, Hashtable GALOKDCMNPH);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event IAMOGHEFAJE GIBLMLFLLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x83E7AD0", Offset = "0x83E6ED0", VA = "0x1883E7AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x83E7890", Offset = "0x83E6C90", VA = "0x1883E7890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event IAMOGHEFAJE FOHNJPPCBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x83E7A10", Offset = "0x83E6E10", VA = "0x1883E7A10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x83E7710", Offset = "0x83E6B10", VA = "0x1883E7710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event OFHODKJFKFC BDAJKGIKGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x83E77D0", Offset = "0x83E6BD0", VA = "0x1883E77D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x83E7650", Offset = "0x83E6A50", VA = "0x1883E7650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event OFHODKJFKFC GKBBIAGIBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x83E7590", Offset = "0x83E6990", VA = "0x1883E7590")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x83E7950", Offset = "0x83E6D50", VA = "0x1883E7950")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class BNBBMKHFIJC
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int PLPHBFHAHFF;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int IACHKJIAIOB;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int GDFEJNEELBO;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x83D3840", Offset = "0x83D2C40", VA = "0x1883D3840")]
	public static void FFPGOMEMILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x83D3890", Offset = "0x83D2C90", VA = "0x1883D3890")]
	public static void GANMLDCDONM(int[] EDJPJKIIBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x83D3970", Offset = "0x83D2D70", VA = "0x1883D3970")]
	public static int OHDFJDFBPNN(int NFFMNPGKHGB, bool OMBCDAEENCG = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RegisterService(typeof(CIHCBBCHIAC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class CIHCBBCHIAC : LJOIGAFBBOC, OJJHPFNNLMN, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly Dictionary<object, object> BDMMBGNFEGC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Dictionary<object, object> KMNMIDLOOJA;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly Dictionary<object, object> HKMEPOEGCDC;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly MIAGGALJIMC CKBAEMOHCPL;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly MIAGGALJIMC AEFKLDLHNOJ;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly MIAGGALJIMC BODIAJONEFN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly MIAGGALJIMC HCNPGMPNNNN;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly MIAGGALJIMC NGBLAHKIPAF;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int OMDMGBJCGAD;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x83D64D0", Offset = "0x83D58D0", VA = "0x1883D64D0", Slot = "18")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x83D5680", Offset = "0x83D4A80", VA = "0x1883D5680", Slot = "19")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x83D6690", Offset = "0x83D5A90", VA = "0x1883D6690", Slot = "4")]
	public bool POLHNEDIEFA(FJHICBFJMJJ FGEMBJJOPFK, bool FDNKNICIBCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x83D5720", Offset = "0x83D4B20", VA = "0x1883D5720", Slot = "5")]
	public int KBCPMOGJJMD(FJHICBFJMJJ[] PHPPOCOCCLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x83D5390", Offset = "0x83D4790", VA = "0x1883D5390", Slot = "6")]
	public bool HBFIIJIOKKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x83D6300", Offset = "0x83D5700", VA = "0x1883D6300", Slot = "7")]
	public bool MHNJBGHABEG(int MIMIGBMDBGE, int MNLGMOODKHI, bool LNHPDGGCMGB, GameObject JBJNKCGNJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x83D5160", Offset = "0x83D4560", VA = "0x1883D5160", Slot = "8")]
	public void EKEFDCLFPEN(int MNLGMOODKHI, [Optional] int? EGFPIGCIONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x83D4650", Offset = "0x83D3A50", VA = "0x1883D4650", Slot = "9")]
	public bool DLLDIACHNMJ(APFDEDCIGGF FCGKHKJBFED, [Out] FJHICBFJMJJ CGEBCMMMPAJ, bool GOAPNIKDJPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x83D4300", Offset = "0x83D3700", VA = "0x1883D4300", Slot = "10")]
	public bool DGAKPOBGIGE(APFDEDCIGGF FCGKHKJBFED, [Out] int AGCHPGICICC, [Out] FJHICBFJMJJ[] PHPPOCOCCLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x83D5C30", Offset = "0x83D5030", VA = "0x1883D5C30", Slot = "11")]
	public bool MEIFICHGCFF(APFDEDCIGGF FCGKHKJBFED, [Out] int MNLGMOODKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x83D5420", Offset = "0x83D4820", VA = "0x1883D5420", Slot = "12")]
	public void IEJKOOKEDED(APFDEDCIGGF FCGKHKJBFED, [Out] int BBLCHDACEHN, [Out] int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x83D3CE0", Offset = "0x83D30E0", VA = "0x1883D3CE0", Slot = "13")]
	public void AMPMFABDBDA(int AGCHPGICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x83D4090", Offset = "0x83D3490", VA = "0x1883D4090", Slot = "14")]
	public void DEBBLKFLJLK(int AGCHPGICICC, int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x83D5070", Offset = "0x83D4470", VA = "0x1883D5070", Slot = "15")]
	public void EEDPGJNFAFA(int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x83D6570", Offset = "0x83D5970", VA = "0x1883D6570", Slot = "16")]
	public void PKAIOCKKHFO(int[] FGDJFLNEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x83D3EC0", Offset = "0x83D32C0", VA = "0x1883D3EC0", Slot = "17")]
	public void BDCKCPEPFPC(int AGCHPGICICC, int MNLGMOODKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x83D5D90", Offset = "0x83D5190", VA = "0x1883D5D90")]
	private static void MGBCKEAGOOO(FJHICBFJMJJ FGEMBJJOPFK, Dictionary<object, object> CJNJJHEGLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x83D47C0", Offset = "0x83D3BC0", VA = "0x1883D47C0")]
	private static bool DLLDIACHNMJ(Dictionary<object, object> CJNJJHEGLDB, NELIJLIGAOD DOCPCJOAHCL, [Out] FJHICBFJMJJ CGEBCMMMPAJ, bool GOAPNIKDJPF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x83D4210", Offset = "0x83D3610", VA = "0x1883D4210")]
	private static bool DFGGJMALCJL(int MNLGMOODKHI, FJHICBFJMJJ CJNJJHEGLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x83D5B50", Offset = "0x83D4F50", VA = "0x1883D5B50")]
	private static int MBPGOMKEING()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CIHCBBCHIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(EEMLBENAOJN), new string[] { })]
public class EEMLBENAOJN : PGOPCDBDLJH, OJJHPFNNLMN, LLJNOAGPADG
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static Hashtable CHJEMBPHBIL;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static Hashtable HKKIJGHPBCH;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static MIAGGALJIMC GNPBKBCOFNJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly MIAGGALJIMC KKJJCGFKOBA;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x83E0390", Offset = "0x83DF790", VA = "0x1883E0390", Slot = "8")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x83E0790", Offset = "0x83DFB90", VA = "0x1883E0790", Slot = "7")]
	public void NCJJIBEJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x83E0830", Offset = "0x83DFC30", VA = "0x1883E0830", Slot = "4")]
	public void NKDGOKGFBBN(ViewId MIMIGBMDBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x83E0430", Offset = "0x83DF830", VA = "0x1883E0430", Slot = "5")]
	public bool NBLJOADNIPL(APFDEDCIGGF FCGKHKJBFED, [Out] ViewId MIMIGBMDBGE, [Out] string LLDFMPKDACF, [Out] int NEHLPBKBLMN, [Out] object[] NODDCIHHMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x83E0920", Offset = "0x83DFD20", VA = "0x1883E0920", Slot = "6")]
	public void OABMENFBOHB(ViewId BPHIDAEMDAO, string LLDFMPKDACF, ONIAKPOCCMO LONCINEFKEG, NELIJLIGAOD NICGPJDLKCM, GJABJKJIDKJ KOONHGMCMGC, object[] FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EEMLBENAOJN()
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
