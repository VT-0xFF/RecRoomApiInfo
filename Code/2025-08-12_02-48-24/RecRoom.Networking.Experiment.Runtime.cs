using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.ObjectModel;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_Experiment_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8557200", Offset = "0x8555800", VA = "0x188557200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IGIBKNHNEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFOKLBENAMF(NEIKMBGDPOI MHCCEBNBPPI, bool NNIGHJGEHLI = false);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IEILOHJCFOA(NEIKMBGDPOI[] HJEHIGNFBAG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OKAAMDAIJDH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKOLKEDLFIH(int KBEDHBMNMBE, int IKKJDEFHNPG, bool IBPIAPBNIAJ, GameObject EGMHLHLEIMH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNCAANECNNF(int IKKJDEFHNPG, [Optional] int? NPNKAOIDCOF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LKGLENCEHFP(CHPJIJKJKGB KJOIOABMAMH, [Out] NEIKMBGDPOI NMLIHNPKKOC, bool CADLGBPCAME = true);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NCOLMIKDCIJ(CHPJIJKJKGB KJOIOABMAMH, [Out] int MNAFGCEMEEM, [Out] NEIKMBGDPOI[] HJEHIGNFBAG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GHJAEOMKJMN(CHPJIJKJKGB KJOIOABMAMH, [Out] int IKKJDEFHNPG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JHLFHLIJEBA(CHPJIJKJKGB KJOIOABMAMH, [Out] int ALINLKPMGAH, [Out] int[] EEIGGAFCBHD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPANPIHEBMP(int MNAFGCEMEEM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONLMPLKECMN(int MNAFGCEMEEM, int[] EEIGGAFCBHD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEDJCHCNMNL(int[] EEIGGAFCBHD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JEGBAHLGNDI(int[] EEIGGAFCBHD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DEOOJKPBMCF(int MNAFGCEMEEM, int IKKJDEFHNPG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GCFHAFGKHAO
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMBAFDFMGBJ(ViewId KBEDHBMNMBE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAFENLOFKEH(CHPJIJKJKGB KJOIOABMAMH, [Out] ViewId KBEDHBMNMBE, [Out] string BKCBMFPHNNL, [Out] int EPEOJKACHKK, [Out] object[] ILLMINLDJKA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGEDGCODPIB(ViewId MLCJICFBOOE, string BKCBMFPHNNL, MACNHJCIMEN DPONGBBHBGJ, NGPBJJLAELK LIOICDJHFAF, DIFLOFIPONG PDONCLMEOCB, object[] MHCCEBNBPPI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AEDHCEKEBGP : KIEDMBBPLID, PEBBLHDFNJB, IHOMGAAKIDD, GHBOMOEIGMI, PLJJNBNKAJM, OAHNADCCNFB, ACCCLNDIMKL, OMDFKADEOCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private KIEDMBBPLID JLPNFFMIFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8554730", Offset = "0x8552D30", VA = "0x188554730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float AFDLACMHOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8553000", Offset = "0x8551600", VA = "0x188553000", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GFLGHICANHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8554140", Offset = "0x8552740", VA = "0x188554140", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NHEOBENMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8555A60", Offset = "0x8554060", VA = "0x188555A60", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AFDCIABHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8551D50", Offset = "0x8550350", VA = "0x188551D50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GKJDFAIICOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8554020", Offset = "0x8552620", VA = "0x188554020", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float NGKLGJLLMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85541C0", Offset = "0x85527C0", VA = "0x1885541C0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float CCPCECPKCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85549C0", Offset = "0x8552FC0", VA = "0x1885549C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HHGBCIBDBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8553E10", Offset = "0x8552410", VA = "0x188553E10", Slot = "26")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ABINFPFCBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8553320", Offset = "0x8551920", VA = "0x188553320", Slot = "28")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IHOGNOIAEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85558C0", Offset = "0x8553EC0", VA = "0x1885558C0", Slot = "29")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool APADGJALKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85538D0", Offset = "0x8551ED0", VA = "0x1885538D0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MMKDKBFCKLN LCNLNHJBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8553B10", Offset = "0x8552110", VA = "0x188553B10", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MEJHHDKJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85536A0", Offset = "0x8551CA0", VA = "0x1885536A0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IAMEOEJGNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8552520", Offset = "0x8550B20", VA = "0x188552520", Slot = "37")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MAGADPHIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8553510", Offset = "0x8551B10", VA = "0x188553510", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8552190", Offset = "0x8550790", VA = "0x188552190", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JPIECMJBAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8553EA0", Offset = "0x85524A0", VA = "0x188553EA0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KKFDDIOIMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8553590", Offset = "0x8551B90", VA = "0x188553590", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public object MMAIMMNFDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85559D0", Offset = "0x8553FD0", VA = "0x1885559D0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BDKNEFFGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85552C0", Offset = "0x85538C0", VA = "0x1885552C0", Slot = "44")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8554CD0", Offset = "0x85532D0", VA = "0x188554CD0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NGPBJJLAELK OAPPNOICBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8554360", Offset = "0x8552960", VA = "0x188554360", Slot = "66")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GHCAKFCNHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8555AE0", Offset = "0x85540E0", VA = "0x188555AE0", Slot = "67")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PIODOJJFMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8554DE0", Offset = "0x85533E0", VA = "0x188554DE0", Slot = "68")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NGPBJJLAELK IKMIMHKGALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8551C50", Offset = "0x8550250", VA = "0x188551C50", Slot = "69")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8553F20", Offset = "0x8552520", VA = "0x188553F20", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GCMKNPCOFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85525F0", Offset = "0x8550BF0", VA = "0x1885525F0", Slot = "71")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string BPDBCDHIKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85537C0", Offset = "0x8551DC0", VA = "0x1885537C0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Func<string, string> NPAFNDAMIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8554520", Offset = "0x8552B20", VA = "0x188554520", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OCAMIHHAAOC BDDIMPKCHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85525A0", Offset = "0x8550BA0", VA = "0x1885525A0", Slot = "84")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PKPOJCHMJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8554E60", Offset = "0x8553460", VA = "0x188554E60", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8552B50", Offset = "0x8551150", VA = "0x188552B50", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NPENCHFJKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8554EE0", Offset = "0x85534E0", VA = "0x188554EE0", Slot = "85")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long INOCOIMCOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8552370", Offset = "0x8550970", VA = "0x188552370", Slot = "86")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long KNLLCMNJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8553FA0", Offset = "0x85525A0", VA = "0x188553FA0", Slot = "87")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JOBCKNMFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8552870", Offset = "0x8550E70", VA = "0x188552870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8552910", Offset = "0x8550F10", VA = "0x188552910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MMKDKBFCKLN, MMKDKBFCKLN> OOOCLHHPKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8555B60", Offset = "0x8554160", VA = "0x188555B60", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8554470", Offset = "0x8552A70", VA = "0x188554470", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<bool> DCMGDLMPEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8554FD0", Offset = "0x85535D0", VA = "0x188554FD0", Slot = "50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8553270", Offset = "0x8551870", VA = "0x188553270", Slot = "51")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, long> IBBIFAOMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8552220", Offset = "0x8550820", VA = "0x188552220", Slot = "59")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8555080", Offset = "0x8553680", VA = "0x188555080", Slot = "60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<CHPJIJKJKGB> ACBJLHPIFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8553720", Offset = "0x8551D20", VA = "0x188553720", Slot = "61")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85539D0", Offset = "0x8551FD0", VA = "0x1885539D0", Slot = "62")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<NGPBJJLAELK> IGFDBOAGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85522D0", Offset = "0x85508D0", VA = "0x1885522D0", Slot = "64")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85540A0", Offset = "0x85526A0", VA = "0x1885540A0", Slot = "65")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action BJACNDOPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8554800", Offset = "0x8552E00", VA = "0x188554800", Slot = "81")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8553A70", Offset = "0x8552070", VA = "0x188553A70", Slot = "82")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8552F10", Offset = "0x8551510", VA = "0x188552F10")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	internal static void EBJPFNJLIPM(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8555E90", Offset = "0x8554490", VA = "0x188555E90")]
	[Preserve]
	public AEDHCEKEBGP([OEKMEJFDAAI(null)] HHLGCMPIMBB EFOIJBMGMIM, [OEKMEJFDAAI(null)] NEMLCBMHGIP GBOIHCDNCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8552BE0", Offset = "0x85511E0", VA = "0x188552BE0", Slot = "89")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8555340", Offset = "0x8553940", VA = "0x188555340")]
	private void OAOLKNPOKEM(KIEDMBBPLID LOFIHGCFCMO, KIEDMBBPLID EONKHEGMMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x13194B0", Offset = "0x1317AB0", VA = "0x1813194B0")]
	private void FIEJFLLAILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8552DF0", Offset = "0x85513F0", VA = "0x188552DF0")]
	private void EAGIPAHHKPO(MMKDKBFCKLN LOBLEEIEILH, MMKDKBFCKLN FCNLPJMKEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xE43890", Offset = "0xE41E90", VA = "0x180E43890")]
	private void ELOMFMBFNAC(bool KBANPHBGLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25148D0", Offset = "0x2512ED0", VA = "0x1825148D0")]
	private void BOGPGHDBAFC(string EHLAHNIAPLD, long DLDMPFNLNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x106E0C0", Offset = "0x106C6C0", VA = "0x18106E0C0")]
	private void DFOEGFLKNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8553410", Offset = "0x8551A10", VA = "0x188553410", Slot = "57")]
	public void EPHOGCLEHAD(StringBuilder CMJJBNMOOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8553B90", Offset = "0x8552190", VA = "0x188553B90", Slot = "14")]
	public void GOAHLBMPNHA(List<object> AHJLBOEGGKN, int JNIDLJHCIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85548A0", Offset = "0x8552EA0", VA = "0x1885548A0", Slot = "16")]
	public void LGCJPLGPLNH(object PAEBKOFLOKP, int PDIOIHNCAEJ, bool CDOLEBNLLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8554AE0", Offset = "0x85530E0", VA = "0x188554AE0", Slot = "20")]
	public void MJCOCGPFLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8555940", Offset = "0x8553F40", VA = "0x188555940", Slot = "49")]
	public bool OKLEACNGNFK(object NJEBFJLPMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8554630", Offset = "0x8552C30", VA = "0x188554630", Slot = "22")]
	public object KJBCLIOBDIC(NativeArray<byte> DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8551DD0", Offset = "0x85503D0", VA = "0x188551DD0", Slot = "23")]
	public int BFLGAOMHNOK(CHPJIJKJKGB KJOIOABMAMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8555C10", Offset = "0x8554210", VA = "0x188555C10", Slot = "48")]
	public void PHBPELHDHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85557C0", Offset = "0x8553DC0", VA = "0x1885557C0", Slot = "15")]
	public void ODHCBGKJJFN(int DAIJJKOJCMN, object KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8554770", Offset = "0x8552D70", VA = "0x188554770", Slot = "76")]
	public NGPBJJLAELK KLDJLJMBHHG(int PPFHIIIBKME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8555130", Offset = "0x8553730", VA = "0x188555130", Slot = "75")]
	public NGPBJJLAELK NMHMCNCPOEA(int IDKCKOGGANG, bool GGGHBCEIGOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85543E0", Offset = "0x85529E0", VA = "0x1885543E0", Slot = "77")]
	public NGPBJJLAELK JJEEMFCIDCM(int IDKCKOGGANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8554B60", Offset = "0x8553160", VA = "0x188554B60", Slot = "56")]
	public bool MJIAHIBEFHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8551BD0", Offset = "0x85501D0", VA = "0x188551BD0", Slot = "11")]
	public bool ABIDCBNNEHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8553610", Offset = "0x8551C10", VA = "0x188553610", Slot = "78")]
	public IReadOnlyList<NGPBJJLAELK> FGDABJGJJBC(bool GGGHBCEIGOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8551FF0", Offset = "0x85505F0", VA = "0x188551FF0", Slot = "79")]
	public IReadOnlyList<NGPBJJLAELK> BMLHPLDLDAC(bool GGGHBCEIGOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8552770", Offset = "0x8550D70", VA = "0x188552770", Slot = "47")]
	public bool DDKIOCOJLDN(string KANDKBIHINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85542E0", Offset = "0x85528E0", VA = "0x1885542E0", Slot = "46")]
	public bool JBLJNKHNCMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8553D10", Offset = "0x8552310", VA = "0x188553D10", Slot = "58")]
	public bool HKNFGLLKIAB(bool AFJPNKCAFDI, [Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8554D60", Offset = "0x8553360", VA = "0x188554D60", Slot = "13")]
	public void MLCJOEIGBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85531F0", Offset = "0x85517F0", VA = "0x1885531F0", Slot = "55")]
	public IDisposable EIKMABELFHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85523F0", Offset = "0x85509F0", VA = "0x1885523F0", Slot = "63")]
	public bool CHCMJNJMDMG(byte GJJLANCEJBK, object LNABMKFANGL, CHACOCKEPKK LMNKFGMNAHO, JHMEBNDKBLP CEOGGMLLKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8553950", Offset = "0x8551F50", VA = "0x188553950", Slot = "83")]
	public void GGLIHOHLIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8555D10", Offset = "0x8554310", VA = "0x188555D10", Slot = "12")]
	public void PJGIIEKFJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8552080", Offset = "0x8550680", VA = "0x188552080", Slot = "21")]
	public void CAELEDFILEL(object NDBJJGOPOFO, NativeList<byte> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85530F0", Offset = "0x85516F0", VA = "0x1885530F0", Slot = "38")]
	public void EGMEGBNLAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8553C90", Offset = "0x8552290", VA = "0x188553C90", Slot = "18")]
	public void HEIFINPIJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8551CD0", Offset = "0x85502D0", VA = "0x188551CD0", Slot = "19")]
	public void ADLLBBCPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8555230", Offset = "0x8553830", VA = "0x188555230", Slot = "80")]
	public bool NNAAOLGCKFJ(NGPBJJLAELK BNAOJNEHPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8551F60", Offset = "0x8550560", VA = "0x188551F60", Slot = "52")]
	public void BKLMPIOOIKI(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8552670", Offset = "0x8550C70", VA = "0x188552670", Slot = "54")]
	public void CODOJPMJADP(object HNGIMMGBLII, bool KBANPHBGLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8552AC0", Offset = "0x85510C0", VA = "0x188552AC0", Slot = "53")]
	public void DKLGBEJLGCD(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8551ED0", Offset = "0x85504D0", VA = "0x188551ED0", Slot = "27")]
	public void BGLHDNKIKAB(string HNKHNANEKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8555D90", Offset = "0x8554390", VA = "0x188555D90", Slot = "10")]
	public float PPEACOGNPMH(bool BADOJEHPALK, int JENOKFKPGKP = 1)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85529B0", Offset = "0x8550FB0", VA = "0x1885529B0", Slot = "74")]
	public void DFOMBCBJJAK(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8555C90", Offset = "0x8554290", VA = "0x188555C90", Slot = "88")]
	public int PIPEDLIMKBB()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CBPMHCNIKJL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Photon,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	GameServer
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.Application)]
public interface HHLGCMPIMBB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ServiceLifetime(Lifetime.Application)]
public interface NEMLCBMHGIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OJGLBPDNHJE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static CBPMHCNIKJL IBCBPDPBIDM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static CBPMHCNIKJL FFCINMPMMDP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool EKLGAEFPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8556440", Offset = "0x8554A40", VA = "0x188556440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static CBPMHCNIKJL ADNKGEGMMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8556790", Offset = "0x8554D90", VA = "0x188556790")]
		get
		{
			return default(CBPMHCNIKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static KIEDMBBPLID COHLPAHBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8556740", Offset = "0x8554D40", VA = "0x188556740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85564A0", Offset = "0x8554AA0", VA = "0x1885564A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static KIEDMBBPLID BFPMCBCBMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8556EA0", Offset = "0x85554A0", VA = "0x188556EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8556620", Offset = "0x8554C20", VA = "0x188556620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static KIEDMBBPLID JLPNFFMIFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8556B50", Offset = "0x8555150", VA = "0x188556B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static IGIBKNHNEBP IHIJDJENCED
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85568F0", Offset = "0x8554EF0", VA = "0x1885568F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8556F60", Offset = "0x8555560", VA = "0x188556F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static IGIBKNHNEBP HJMKLPEMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8556E50", Offset = "0x8555450", VA = "0x188556E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85563D0", Offset = "0x85549D0", VA = "0x1885563D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static IGIBKNHNEBP ELJMCIKMFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8556FD0", Offset = "0x85555D0", VA = "0x188556FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static GCFHAFGKHAO JHDKLMPCCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8556270", Offset = "0x8554870", VA = "0x188556270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8556EF0", Offset = "0x85554F0", VA = "0x188556EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static GCFHAFGKHAO GJEIHPHOEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8556220", Offset = "0x8554820", VA = "0x188556220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8556DE0", Offset = "0x85553E0", VA = "0x188556DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static GCFHAFGKHAO NMCMKFBLPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85562C0", Offset = "0x85548C0", VA = "0x1885562C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event Action<KIEDMBBPLID, KIEDMBBPLID> OAOLKNPOKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85567E0", Offset = "0x8554DE0", VA = "0x1885567E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8556510", Offset = "0x8554B10", VA = "0x188556510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85570E0", Offset = "0x85556E0", VA = "0x1885570E0")]
	static OJGLBPDNHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8556C60", Offset = "0x8555260", VA = "0x188556C60")]
	public static void LJDCNOCKLGC(HHLGCMPIMBB EFOIJBMGMIM, NEMLCBMHGIP GBOIHCDNCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85569E0", Offset = "0x8554FE0", VA = "0x1885569E0")]
	public static void KJDJJLKBPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8556690", Offset = "0x8554C90", VA = "0x188556690")]
	private static void HIAKFOJNGJD(CBPMHCNIKJL ABLBOMJODIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8556940", Offset = "0x8554F40", VA = "0x188556940")]
	private static void KENEPKLEPFA(IDPNLIFOOCM MDPJENFHHBN)
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
