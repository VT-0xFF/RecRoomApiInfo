using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPMAOKJOOME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APEOJDPGBEH(Type HFMIHGBNCHP, Type PCNGKBMKCAF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object[] JDNOBBJCCJF(object[] GKCLNKEHGLO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object[] DKIHMCIMLFF(object[] GKCLNKEHGLO, ParameterInfo[] OGFOKOMFKEC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHOMGAAKIDD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> DCMGDLMPEAN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKLMPIOOIKI(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKLGBEJLGCD(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CODOJPMJADP(object HNGIMMGBLII, bool KBANPHBGLCA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable EIKMABELFHO();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MJIAHIBEFHN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPHOGCLEHAD(StringBuilder CMJJBNMOOMI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HKNFGLLKIAB(bool AFJPNKCAFDI, [Out] string GJJJIJGCEEO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PEBBLHDFNJB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool APADGJALKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MMKDKBFCKLN LCNLNHJBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MEJHHDKJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IAMEOEJGNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MAGADPHIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JPIECMJBAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KKFDDIOIMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object MMAIMMNFDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BDKNEFFGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MMKDKBFCKLN, MMKDKBFCKLN> OOOCLHHPKAE;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGMEGBNLAKF();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool JBLJNKHNCMK();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DDKIOCOJLDN(string KANDKBIHINL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PHBPELHDHLN();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OKLEACNGNFK(object NJEBFJLPMKO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NBOLPBCNBAN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	PeerCreated = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Authenticating = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Authenticated = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	JoiningLobby = 3,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	JoinedLobby = 4,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	DisconnectingFromMasterServer = 5,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Obsolete("Renamed to DisconnectingFromMasterServer")]
	DisconnectingFromMasterserver = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	ConnectingToGameServer = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Obsolete("Renamed to ConnectingToGameServer")]
	ConnectingToGameserver = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	ConnectedToGameServer = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Obsolete("Renamed to ConnectedToGameServer")]
	ConnectedToGameserver = 7,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Joining = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Joined = 9,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Leaving = 10,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	DisconnectingFromGameServer = 11,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Obsolete("Renamed to DisconnectingFromGameServer")]
	DisconnectingFromGameserver = 11,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ConnectingToMasterServer = 12,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Obsolete("Renamed to ConnectingToMasterServer.")]
	ConnectingToMasterserver = 12,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Disconnecting = 13,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Disconnected = 14,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ConnectedToMasterServer = 15,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[Obsolete("Renamed to ConnectedToMasterServer.")]
	ConnectedToMasterserver = 15,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[Obsolete("Renamed to ConnectedToMasterServer.")]
	ConnectedToMaster = 15,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ConnectingToNameServer = 16,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ConnectedToNameServer = 17,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DisconnectingFromNameServer = 18,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ConnectWithFallbackProtocol = 19
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMKDKBFCKLN : ACCCLNDIMKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NBOLPBCNBAN IDLGCGGPBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[CanBeNull]
	MBDOPJJBOKP JJJIPAHBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KKFDDIOIMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MEJHHDKJPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IAMEOEJGNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PLICMJMCMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	[CanBeNull]
	Exception NEPODDKMEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int PKKKNMNDOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OLKAABCPOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<string, long> IBBIFAOMBAK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NBOLPBCNBAN, NBOLPBCNBAN> GHCMCONCAEI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GHBOMOEIGMI
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string, long> IBBIFAOMBAK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CHPJIJKJKGB> ACBJLHPIFPG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CHCMJNJMDMG(byte GJJLANCEJBK, object LNABMKFANGL, CHACOCKEPKK LMNKFGMNAHO, JHMEBNDKBLP CEOGGMLLKMM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PLJJNBNKAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NGPBJJLAELK OAPPNOICBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int GHCAKFCNHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PIODOJJFMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NGPBJJLAELK IKMIMHKGALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int GCMKNPCOFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string BPDBCDHIKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Func<string, string> NPAFNDAMIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<NGPBJJLAELK> IGFDBOAGOKE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DFOMBCBJJAK(string DJFMCHMDHGK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[CanBeNull]
	NGPBJJLAELK NMHMCNCPOEA(int IDKCKOGGANG, bool GGGHBCEIGOD = false);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[CanBeNull]
	NGPBJJLAELK KLDJLJMBHHG(int PPFHIIIBKME);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NGPBJJLAELK JJEEMFCIDCM(int IDKCKOGGANG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<NGPBJJLAELK> FGDABJGJJBC(bool GGGHBCEIGOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyList<NGPBJJLAELK> BMLHPLDLDAC(bool GGGHBCEIGOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NNAAOLGCKFJ(NGPBJJLAELK BNAOJNEHPML);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OAHNADCCNFB
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BJACNDOPMBO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGLIHOHLIMI();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ACCCLNDIMKL
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OCAMIHHAAOC BDDIMPKCHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OMDFKADEOCE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string NPENCHFJKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	long INOCOIMCOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long KNLLCMNJADG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PIPEDLIMKBB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIEDMBBPLID : PEBBLHDFNJB, IHOMGAAKIDD, GHBOMOEIGMI, PLJJNBNKAJM, OAHNADCCNFB, ACCCLNDIMKL, OMDFKADEOCE
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float AFDLACMHOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int GFLGHICANHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int NHEOBENMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	int AFDCIABHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int GKJDFAIICOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float NGKLGJLLMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float CCPCECPKCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool HHGBCIBDBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	double ABINFPFCBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int IHOGNOIAEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PKPOJCHMJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "27")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action JOBCKNMFHBL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	float PPEACOGNPMH(bool BADOJEHPALK, int JENOKFKPGKP = 1);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ABIDCBNNEHC();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJGIIEKFJOD();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLCJOEIGBFO();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GOAHLBMPNHA(List<object> AHJLBOEGGKN, int JNIDLJHCIED);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODHCBGKJJFN(int DAIJJKOJCMN, object KJOIOABMAMH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGCJPLGPLNH(object PAEBKOFLOKP, int PDIOIHNCAEJ, bool CDOLEBNLLDK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HEIFINPIJKE();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADLLBBCPHPG();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MJCOCGPFLNH();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CAELEDFILEL(object NDBJJGOPOFO, NativeList<byte> DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	object KJBCLIOBDIC(NativeArray<byte> DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int BFLGAOMHNOK(CHPJIJKJKGB KJOIOABMAMH);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BGLHDNKIKAB(string HNKHNANEKAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OLKCBGFPPFA
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CIOENMFOBPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public string DCKJGHKPAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Vector3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Quaternion NEMGOCEHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Vector3 PFMPFEHANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public int FOPLEKDGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DDNEFPADLOB FJEPMMDBOCD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8565650", Offset = "0x8563C50", VA = "0x188565650")]
	public object[] MNLJGDNCOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CIOENMFOBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum IBGCELDEKPH
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ExceptionOnConnect,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Exception,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ServerTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ClientTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DisconnectByServerLogic,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	DisconnectByServerReasonUnknown,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	InvalidAuthentication,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	CustomAuthenticationFailed,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	AuthenticationTicketExpired,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	MaxCcuReached,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	InvalidRegion,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OperationNotAllowedInCurrentState,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	DisconnectByClientLogic,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Authentication_UnknownError
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OCAMIHHAAOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GJIKMKGBNOL<CHPJIJKJKGB> BIIIEILGHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NCECCJAFPPJ<CHPJIJKJKGB, CHACOCKEPKK> JHALDDBLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HBPNKKOKOOA EAAGKAKELHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public HBPNKKOKOOA DNLGFDFMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GJIKMKGBNOL<IBGCELDEKPH> LNGFJDFFDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HBPNKKOKOOA EOCKGGHMDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public GJIKMKGBNOL<string> JAHLIFJPCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public GJIKMKGBNOL<Dictionary<string, object>> FNHMJNHNEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GJIKMKGBNOL<IBGCELDEKPH> AKHLOPDJMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NCECCJAFPPJ<bool, bool> BEOHGCEACML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public HBPNKKOKOOA IFLGHOGBOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public HBPNKKOKOOA MCCMPJHLJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public HBPNKKOKOOA HACGHKKKFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public HBPNKKOKOOA AMJAHEOOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HBPNKKOKOOA KKEDNAFPBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GJIKMKGBNOL<NGPBJJLAELK> HPJDKKNJPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NCECCJAFPPJ<short, string> JPMCJLEMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GJIKMKGBNOL<IDictionary<object, object>> JMPBNDAEPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NCECCJAFPPJ<short, string> BGJHGBJEMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public HBPNKKOKOOA KBNGKPOMAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GJIKMKGBNOL<NGPBJJLAELK> APFBMIOCBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GJIKMKGBNOL<NGPBJJLAELK> FBDJAMKDMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public GJIKMKGBNOL<NGPBJJLAELK> KKIIOIJBCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NCECCJAFPPJ<NGPBJJLAELK, IDictionary<object, object>> OHNJMMEEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public HBPNKKOKOOA LDMODLPMMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HBPNKKOKOOA CLHFPIEBLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public GJIKMKGBNOL<IBGCELDEKPH> POGFKFEAIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GJIKMKGBNOL<IBGCELDEKPH> NEJMPPACCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public GJIKMKGBNOL<IBGCELDEKPH> ALNEOJFMKDP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8567EB0", Offset = "0x85664B0", VA = "0x188567EB0")]
	public OCAMIHHAAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FCJNOHJOIGN
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8565860", Offset = "0x8563E60", VA = "0x188565860")]
	public static bool MJKJNFIDPBF(this PEBBLHDFNJB EFNKHPEGBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8565790", Offset = "0x8563D90", VA = "0x188565790")]
	public static bool HHFCIIKNNCB(this PEBBLHDFNJB EFNKHPEGBLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JNMOMFEKJFG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class GNLNCBFMICA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly JNMOMFEKJFG MOEANGBLGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool OPDBEINFGEH;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85663C0", Offset = "0x85649C0", VA = "0x1885663C0")]
		public GNLNCBFMICA(JNMOMFEKJFG MOEANGBLGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85662C0", Offset = "0x85648C0", VA = "0x1885662C0", Slot = "1")]
		~GNLNCBFMICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8566230", Offset = "0x8564830", VA = "0x188566230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8566360", Offset = "0x8564960", VA = "0x188566360")]
		private void HIKINCJDCAG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly object MKCOMDFFJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly object PGJOGFMONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float EJBJCKEGCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float LNHKHDNCKMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract bool BDKNEFFGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract float AFDLACMHOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float NGKLGJLLMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EC0", Offset = "0xAF14C0", VA = "0x180AF2EC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85678B0", Offset = "0x8565EB0", VA = "0x1885678B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float CCPCECPKCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFC0", Offset = "0xAEC5C0", VA = "0x180AEDFC0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8567B60", Offset = "0x8566160", VA = "0x188567B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract MMKDKBFCKLN LCNLNHJBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JHDOLFBOEBO EFFLDLMJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private JHDOLFBOEBO OEAJIMDHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private BJGHJEFJAHK<Func<float>> AIBHBHDMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MPIEAPPHEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x19F82A0", Offset = "0x19F68A0", VA = "0x1819F82A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected bool DDINJMJMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8567310", Offset = "0x8565910", VA = "0x188567310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected bool APBKEOGOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8567130", Offset = "0x8565730", VA = "0x188567130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<string, long> IBBIFAOMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8566A70", Offset = "0x8565070", VA = "0x188566A70")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8567CC0", Offset = "0x85662C0", VA = "0x188567CC0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> DCMGDLMPEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8567C10", Offset = "0x8566210", VA = "0x188567C10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8566E10", Offset = "0x8565410", VA = "0x188566E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action JOBCKNMFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8566C00", Offset = "0x8565200", VA = "0x188566C00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8566CA0", Offset = "0x85652A0", VA = "0x188566CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action BJACNDOPMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85678F0", Offset = "0x8565EF0", VA = "0x1885678F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85673B0", Offset = "0x85659B0", VA = "0x1885673B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void PJGIIEKFJOD();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8567D30", Offset = "0x8566330", VA = "0x188567D30")]
	protected JNMOMFEKJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8567BA0", Offset = "0x85661A0", VA = "0x188567BA0")]
	public void LJDCNOCKLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8566AE0", Offset = "0x85650E0", VA = "0x188566AE0")]
	public void CODOJPMJADP(object HNGIMMGBLII, bool KBANPHBGLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8566910", Offset = "0x8564F10", VA = "0x188566910")]
	public void BKLMPIOOIKI(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8566D40", Offset = "0x8565340", VA = "0x188566D40")]
	public void DKLGBEJLGCD(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8566D80", Offset = "0x8565380", VA = "0x188566D80")]
	public IDisposable EIKMABELFHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85674E0", Offset = "0x8565AE0", VA = "0x1885674E0", Slot = "10")]
	public virtual bool HKNFGLLKIAB(bool AFJPNKCAFDI, [Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8567170", Offset = "0x8565770", VA = "0x188567170")]
	private bool FDJJOOOALFN([Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8567A40", Offset = "0x8566040", VA = "0x188567A40")]
	private bool LEPJNHNGJEP([Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8567BC0", Offset = "0x85661C0", VA = "0x188567BC0")]
	public bool MJIAHIBEFHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8566EC0", Offset = "0x85654C0", VA = "0x188566EC0")]
	public void EPHOGCLEHAD(StringBuilder CMJJBNMOOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8567700", Offset = "0x8565D00", VA = "0x188567700")]
	private void HPFELFIOPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8567AD0", Offset = "0x85660D0", VA = "0x188567AD0")]
	private void LICBLMLOFGM(Func<float> GKIMHIIHEMK, object HNGIMMGBLII, int DLELGMMBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8566A10", Offset = "0x8565010", VA = "0x188566A10")]
	public void BOFGLELOPOA(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8567450", Offset = "0x8565A50", VA = "0x188567450")]
	public void HEIFINPIJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8566800", Offset = "0x8564E00", VA = "0x188566800")]
	public void ADLLBBCPHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8566860", Offset = "0x8564E60", VA = "0x188566860")]
	private void AHNKBHLCLKL(float BEJCNBKHBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAEDFC0", Offset = "0xAEC5C0", VA = "0x180AEDFC0")]
	private float MPENNEAGLMF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAF2EC0", Offset = "0xAF14C0", VA = "0x180AF2EC0")]
	private float KPIOBJGAAHG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8567990", Offset = "0x8565F90", VA = "0x188567990")]
	private void LDNOLCNHFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8567360", Offset = "0x8565960", VA = "0x188567360")]
	public void GGLIHOHLIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OOHMJBNLIGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string NDNJEGJAEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool CGKBNNBEAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected internal bool CLGPAOLLKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected internal int GHNEOBOILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected internal byte[] JMDGPFFLBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected internal byte NNLKJKDBKLP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly System.Random OOIIAOJNOGK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85686E0", Offset = "0x8566CE0", VA = "0x1885686E0", Slot = "5")]
	public virtual bool DCNBIOANFLL(string ANJABEIMGJA, int DJOEAGDKAGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8568780", Offset = "0x8566D80", VA = "0x188568780", Slot = "6")]
	public virtual bool PEDCLIKEGJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8568730", Offset = "0x8566D30", VA = "0x188568730", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x85687D0", Offset = "0x8566DD0", VA = "0x1885687D0")]
	protected internal void PNHKIAJGEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85688D0", Offset = "0x8566ED0", VA = "0x1885688D0")]
	protected OOHMJBNLIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CIJCJBNIOGI : OOHMJBNLIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private Socket KOGCOEOJDHM;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x85650E0", Offset = "0x85636E0", VA = "0x1885650E0", Slot = "5")]
	public override bool DCNBIOANFLL(string ANJABEIMGJA, int DJOEAGDKAGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8565380", Offset = "0x8563980", VA = "0x188565380", Slot = "6")]
	public override bool PEDCLIKEGJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x78306A0", Offset = "0x782ECA0", VA = "0x1878306A0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8565570", Offset = "0x8563B70", VA = "0x188565570")]
	public CIJCJBNIOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDNHAKOCGFM
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string GNNJIEAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string EPFHADGGGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string PAHEAOFBKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LDCLJKCHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA30", Offset = "0xA9E030", VA = "0x180A9FA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x85666E0", Offset = "0x8564CE0", VA = "0x1885666E0")]
	public HDNHAKOCGFM(string KBFPIDKMNOD, string GOOIAGHPJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8566420", Offset = "0x8564A20", VA = "0x188566420")]
	private void AFOFGBEBDLJ(string CPPBEDNJJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8566620", Offset = "0x8564C20", VA = "0x188566620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8566530", Offset = "0x8564B30", VA = "0x188566530")]
	public string EHIKPBILGFC(bool CICODHMPEBI = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FMKMKFPEJHB
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static int KIIFBEFCHMO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static bool LBNFGDEOJKL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static int BCDBJGIEHCO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static int GLJJPEGGNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HDNHAKOCGFM JCCIIJDLPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private string PLGEJMOJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int GAGIPNGKOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int FOHLHPNCGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Action<HDNHAKOCGFM> FHMHKHFJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private OOHMJBNLIGD NMOFDACDHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<int> OKABCNKGLMF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PEDCLIKEGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8566180", Offset = "0x8564780", VA = "0x188566180")]
	public FMKMKFPEJHB(HDNHAKOCGFM JCCIIJDLPKK, Action<HDNHAKOCGFM> LJPNCOIGGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8565D90", Offset = "0x8564390", VA = "0x188565D90")]
	public bool JKGHENBEODP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8565940", Offset = "0x8563F40", VA = "0x188565940")]
	public static string GPBNPHGENGA(string JPBFPLCLGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8565930", Offset = "0x8563F30", VA = "0x188565930")]
	protected internal void CCKOMBKCDMC(object HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8565AC0", Offset = "0x85640C0", VA = "0x188565AC0")]
	protected internal bool GPJOFMEMOIN()
	{
		return default(bool);
	}
}
namespace Cpp2IlInjected;

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
