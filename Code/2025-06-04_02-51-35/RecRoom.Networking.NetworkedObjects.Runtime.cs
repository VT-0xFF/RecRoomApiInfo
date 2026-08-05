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
public interface IIIGLAPOELD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHHAELIDKCJ(Type AKPDMGOIEDL, Type NOOEHPICJIL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object[] CIAGECMNKFC(object[] BCFONMIPDMB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object[] MDBGGLCHGLA(object[] BCFONMIPDMB, ParameterInfo[] HAEONHKJHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OGBKAHNOBEK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> EJEPCCBJHDM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKFMEBGGOJE(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJNNEJBGKEF(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBDNLEKAKLI(object KAJENDFCCBJ, bool FNEFOMNCPLE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable MKMBKKBGLLD();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CPICCLCEOMC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDALKJLLCNI(StringBuilder LOJNECLIFBG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CMPPLPPEKLH(bool MJPIJENDBIH, [Out] string MEBFHJECJFA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EOGNLCLMPEC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GDFMPGDCPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LNJGFMPIPIM CPEFBJOENED
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HJDFJHLAAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJMMGFNOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ONAKMGNIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ACMAJMJJHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KACIJDMIGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object KALNNAODLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HGBBLNGEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LNJGFMPIPIM, LNJGFMPIPIM> GMDGALNAHJE;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOBOHHJAHJK();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CNIEPACJKGF();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HDJCBGHIHJK(string LEDBCIOHIBH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BFCHMHAIHIL();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ADGNIENDMBN(object JAKNJANFBGK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NMFABPNHMKD
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
public interface LNJGFMPIPIM : ANCMLMHJJCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NMFABPNHMKD PCFJJFOLGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[CanBeNull]
	NPAEOLAKJHE HJOHBMLGKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KACIJDMIGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HJDFJHLAAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IJMMGFNOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LKAMGBDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	[CanBeNull]
	Exception EEGCECDGEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BHAIMDIJALH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GIEJBAAOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<string, long> BPKKKAIGFBP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NMFABPNHMKD, NMFABPNHMKD> KFDFOEGPFIA;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EINHJDEHCCO
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string, long> BPKKKAIGFBP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IIBEMPIBOEO> DOPODGBLLMN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HPFHOOPLKHJ(byte IDIIIALCIOG, object BMKIAGNKJFP, IKNIODLHFBI OLAJFDBFNIB, IFLICBOELMF CNCFGMMNIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NDPGEKOEOMO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EIGONBNGIIK AAIEKHMDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EMFDHCEPDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int IIJBNKMEAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EIGONBNGIIK HEIMHINEGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int IKFFONJFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string CJGMCHMOACD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Func<string, string> GFOEAMLKCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<EIGONBNGIIK> NCFLGNMOMLP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EDIANKPHPNC(string HPANEBBHGAC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[CanBeNull]
	EIGONBNGIIK CJBMKANACPI(int NLAPHBJBIHF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[CanBeNull]
	EIGONBNGIIK IFCONGIFOKK(int DJKBOHPOLAF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EIGONBNGIIK LAGBMLCMEAH(int NLAPHBJBIHF);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<EIGONBNGIIK> DGELPEKBPOK(bool PLGNMPAKDLM = false);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IReadOnlyList<EIGONBNGIIK> MNKPIGMNFNJ(bool PLGNMPAKDLM = false);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool PEEGCCOCKCL(EIGONBNGIIK LAGPABGGGFK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OCMCHKKDNBL
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action GFDMFONDBGB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACEPGCLAPLF();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ANCMLMHJJCG
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	APHIGGECGKN HMOOOMALDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EPIHHCLCIAM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string NFMGLPHFHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	long PACAPBOGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long DBJELONEBAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DOAHLBBMAHP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIFHCLNMNON : EOGNLCLMPEC, OGBKAHNOBEK, EINHJDEHCCO, NDPGEKOEOMO, OCMCHKKDNBL, ANCMLMHJJCG, EPIHHCLCIAM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float BPMJCKFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int KICKEIMNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int KCIICHKPAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	int DLELEGJFPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int DJHBOCLICNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float LMAKPODLLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float HAEFOCMILIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PAGCGONHNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	BFMOKJLHFFM NFHEEFGPOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	double KFGDBBGOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int PCIAIMFFOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NIODOHDPHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FCCLEOELHIE;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	float ICCKDGADBNE(bool AAJMDKCHNPM, int DPBGHJOIDCH = 1);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PKJDOPGOPLB();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHBIFGIMGGK();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FADEOOEHCNL();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DEMMGMMEHMI(List<object> NFJJCCDFOPE, int COEFDMIBPJJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BGKOEDAOPHI(int FMJAILJAADG, object NPLHFNMEMBD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GIKJDHNPMOC(IDictionary<object, object> JKBGANBHBMG, int FIOLDALLLFF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OMPGFIJBHFK();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KHNMFFEDDJM();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ODOIMBABJOK();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GJCNJFECIPF(object HPLLAPMNIJF, NativeList<byte> IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	object OLFGCACBCKJ(NativeArray<byte> IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int FBDEKCHJIBC(IIBEMPIBOEO NPLHFNMEMBD);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LOGBAJOOEIF(string BIOCLFBKCKD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BFMOKJLHFFM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GJPIKJNPJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FNABANLJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IReadOnlyList<(string code, int ping)> LBBJBAKIJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLHJNINLLBM(Action BKEHHNPBGMF, string JKCMEFAMHBA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KFGMHEKKOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public string INNDOKKJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Vector3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Quaternion FAABMGBBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Vector3 HDBDMJCJIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public int NGCCBDJOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public APNNOCBGIPF NHPIBOCMLAD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80A0FC0", Offset = "0x809F7C0", VA = "0x1880A0FC0")]
	public object[] CDCGFHMOACO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KFGMHEKKOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum NCGNCPFHELC
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
public class APHIGGECGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LBOAOFAOKMM<IIBEMPIBOEO> HPHHOAKCEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public EGCONEOAIAE<IIBEMPIBOEO, IKNIODLHFBI> MLOCOJIGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public KECNPIDOCPH DMEPMPNGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public KECNPIDOCPH HFKLDCELBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LBOAOFAOKMM<NCGNCPFHELC> AEMAIBFBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KECNPIDOCPH EGILKPCINHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public LBOAOFAOKMM<string> IJHIHNLOCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public LBOAOFAOKMM<Dictionary<string, object>> LDALLHCKILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public LBOAOFAOKMM<NCGNCPFHELC> KMHMOEKNHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public EGCONEOAIAE<bool, bool> MIJJMJJDEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public KECNPIDOCPH JLKAFBHEIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KECNPIDOCPH ILLOFFIKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public KECNPIDOCPH HJNCKCFFMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public KECNPIDOCPH FBHAGBAIGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public KECNPIDOCPH MEPBCOKKCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LBOAOFAOKMM<EIGONBNGIIK> HPMAHJHAFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public EGCONEOAIAE<short, string> DBOIBMDFDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LBOAOFAOKMM<IDictionary<object, object>> IJAKKFJIKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public EGCONEOAIAE<short, string> HDBDKCMEACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public KECNPIDOCPH ACNGFEGBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public LBOAOFAOKMM<EIGONBNGIIK> FJIJMHMMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public LBOAOFAOKMM<EIGONBNGIIK> LKMJELFLHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public LBOAOFAOKMM<EIGONBNGIIK> DCPNBMADGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public EGCONEOAIAE<EIGONBNGIIK, IDictionary<object, object>> HLDECGNAENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public KECNPIDOCPH NCAIBDKLPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public KECNPIDOCPH OALOKHBEGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public LBOAOFAOKMM<NCGNCPFHELC> EFFNBOAHFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public LBOAOFAOKMM<NCGNCPFHELC> LKJJEKDJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public LBOAOFAOKMM<NCGNCPFHELC> NHGDGEHOPHL;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x809E9A0", Offset = "0x809D1A0", VA = "0x18809E9A0")]
	public APHIGGECGKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HMNJDIHBEIB
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x80A0D30", Offset = "0x809F530", VA = "0x1880A0D30")]
	public static bool MOLHIIBOMCL(this EOGNLCLMPEC HIMAJMMCBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x80A0C60", Offset = "0x809F460", VA = "0x1880A0C60")]
	public static bool KDONDFMKFKI(this EOGNLCLMPEC HIMAJMMCBPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class FAFDHONEADA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class IJJFPBAOHOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly FAFDHONEADA JADIKJJBPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool LKNCKMOIEPH;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80A0F60", Offset = "0x809F760", VA = "0x1880A0F60")]
		public IJJFPBAOHOI(FAFDHONEADA JADIKJJBPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80A0EC0", Offset = "0x809F6C0", VA = "0x1880A0EC0", Slot = "1")]
		~IJJFPBAOHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80A0DD0", Offset = "0x809F5D0", VA = "0x1880A0DD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80A0E60", Offset = "0x809F660", VA = "0x1880A0E60")]
		private void FEELOCGDKCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly object EIOBKLBKGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly object AFHPKBJOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float CKLGNKOLCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float PCPDLPLBCAE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool HGBBLNGEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract float BPMJCKFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float LMAKPODLLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA75240", Offset = "0xA73A40", VA = "0x180A75240")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80A0470", Offset = "0x809EC70", VA = "0x1880A0470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float HAEFOCMILIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xF23040", Offset = "0xF21840", VA = "0x180F23040")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x80A0AA0", Offset = "0x809F2A0", VA = "0x1880A0AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract LNJGFMPIPIM CPEFBJOENED
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private BFPHHCAGGHH GALAEDBFFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BFPHHCAGGHH LCFDILCCGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private IJCFLIBNNJN<Func<float>> KBMCFNEJJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool DJPGKIILLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x17FD4B0", Offset = "0x17FBCB0", VA = "0x1817FD4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool PPEAIFALEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80A0150", Offset = "0x809E950", VA = "0x1880A0150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected bool CNPEEHHPPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x80A0A60", Offset = "0x809F260", VA = "0x1880A0A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<string, long> BPKKKAIGFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x809FAA0", Offset = "0x809E2A0", VA = "0x18809FAA0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80A0610", Offset = "0x809EE10", VA = "0x1880A0610")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> EJEPCCBJHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80A0740", Offset = "0x809EF40", VA = "0x1880A0740")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80A0920", Offset = "0x809F120", VA = "0x1880A0920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FCCLEOELHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80A0880", Offset = "0x809F080", VA = "0x1880A0880")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x809FB10", Offset = "0x809E310", VA = "0x18809FB10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action GFDMFONDBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x809FBB0", Offset = "0x809E3B0", VA = "0x18809FBB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x809F790", Offset = "0x809DF90", VA = "0x18809F790")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void PHBIFGIMGGK();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80A0AE0", Offset = "0x809F2E0", VA = "0x1880A0AE0")]
	protected FAFDHONEADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80A0450", Offset = "0x809EC50", VA = "0x1880A0450")]
	public void IEAMPCKAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x809FC50", Offset = "0x809E450", VA = "0x18809FC50")]
	public void EBDNLEKAKLI(object KAJENDFCCBJ, bool FNEFOMNCPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x809F690", Offset = "0x809DE90", VA = "0x18809F690")]
	public void AKFMEBGGOJE(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80A0410", Offset = "0x809EC10", VA = "0x1880A0410")]
	public void GJNNEJBGKEF(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80A07F0", Offset = "0x809EFF0", VA = "0x1880A07F0")]
	public IDisposable MKMBKKBGLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x809F830", Offset = "0x809E030", VA = "0x18809F830", Slot = "10")]
	public virtual bool CMPPLPPEKLH(bool MJPIJENDBIH, [Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x809FD70", Offset = "0x809E570", VA = "0x18809FD70")]
	private bool FGGOBJPEONF([Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80A00C0", Offset = "0x809E8C0", VA = "0x1880A00C0")]
	private bool FIPHONPDJGF([Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x809FA50", Offset = "0x809E250", VA = "0x18809FA50")]
	public bool CPICCLCEOMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x80A01A0", Offset = "0x809E9A0", VA = "0x1880A01A0")]
	public void GDALKJLLCNI(StringBuilder LOJNECLIFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x809FF10", Offset = "0x809E710", VA = "0x18809FF10")]
	private void FHMAHCPBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x809F600", Offset = "0x809DE00", VA = "0x18809F600")]
	private void AIPBEDFIJBP(Func<float> DKLIBJDMAKJ, object KAJENDFCCBJ, int IAOOMFIBPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x80A06E0", Offset = "0x809EEE0", VA = "0x1880A06E0")]
	public void LCFCPHOABCO(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x80A09D0", Offset = "0x809F1D0", VA = "0x1880A09D0")]
	public void OMPGFIJBHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x80A0680", Offset = "0x809EE80", VA = "0x1880A0680")]
	public void KHNMFFEDDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x80A04B0", Offset = "0x809ECB0", VA = "0x1880A04B0")]
	private void INKODNKDJLH(float MDFBIFEKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xF23040", Offset = "0xF21840", VA = "0x180F23040")]
	private float JACNKPHAIKB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA75240", Offset = "0xA73A40", VA = "0x180A75240")]
	private float GOMPMNBNKBB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80A0560", Offset = "0x809ED60", VA = "0x1880A0560")]
	private void JEKONAKOEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x809F5B0", Offset = "0x809DDB0", VA = "0x18809F5B0")]
	public void ACEPGCLAPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NHHIPJDCLLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public string OHOIOBPHPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool JGFCIHKIPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected internal bool KAMDJHCBJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected internal int IOIOKFGHKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected internal byte[] HCNPJBCKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected internal byte KHMOBCGCEGB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly System.Random LJMPHBFJKCN;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80A1100", Offset = "0x809F900", VA = "0x1880A1100", Slot = "5")]
	public virtual bool DFJGHAEAALP(string DILPDMKFIOF, int DBMMIMBCKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80A1220", Offset = "0x809FA20", VA = "0x1880A1220", Slot = "6")]
	public virtual bool JLAOHGECAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80A1150", Offset = "0x809F950", VA = "0x1880A1150", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80A11A0", Offset = "0x809F9A0", VA = "0x1880A11A0")]
	protected internal void HNPKBJNJFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80A12F0", Offset = "0x809FAF0", VA = "0x1880A12F0")]
	protected NHHIPJDCLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NLGAAKNKEMD : NHHIPJDCLLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private Socket MHDOEOHJKGN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80A13A0", Offset = "0x809FBA0", VA = "0x1880A13A0", Slot = "5")]
	public override bool DFJGHAEAALP(string DILPDMKFIOF, int DBMMIMBCKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80A1640", Offset = "0x809FE40", VA = "0x1880A1640", Slot = "6")]
	public override bool JLAOHGECAKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74114C0", Offset = "0x740FCC0", VA = "0x1874114C0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80A1830", Offset = "0x80A0030", VA = "0x1880A1830")]
	public NLGAAKNKEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DANLLIAIGOI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GJKKOAKOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string ENLGPBHMMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string DKKCNACOBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PPDIPEJJCED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x809F490", Offset = "0x809DC90", VA = "0x18809F490")]
	public DANLLIAIGOI(string EOKPMGGJEMH, string PKOADNLIJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x809F2C0", Offset = "0x809DAC0", VA = "0x18809F2C0")]
	private void MEMHAPKOFHJ(string BNAEFKCMDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x809F3D0", Offset = "0x809DBD0", VA = "0x18809F3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x809F1D0", Offset = "0x809D9D0", VA = "0x18809F1D0")]
	public string JGMGAPAIAFA(bool HMAIBMFCIPN = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PHIAKPFJEBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static int KKPOLOCGLJA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static bool EKFEPGMDIAO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static int NOMPINFEDGO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static int OFOBFALMFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private DANLLIAIGOI INGLBOFLLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private string FEEOFMIKCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int MBHPNIIPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int JFCHCPBBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Action<DANLLIAIGOI> NNNPEIPPFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NHHIPJDCLLF MIICEEIDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<int> MFEIHEKPGLB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JLAOHGECAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80A2150", Offset = "0x80A0950", VA = "0x1880A2150")]
	public PHIAKPFJEBJ(DANLLIAIGOI INGLBOFLLDF, Action<DANLLIAIGOI> MMIKPKJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D70", Offset = "0x80A0570", VA = "0x1880A1D70")]
	public bool IDHAAILNKGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80A1920", Offset = "0x80A0120", VA = "0x1880A1920")]
	public static string DDLILKPIIED(string CDJNNDLDCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80A1910", Offset = "0x80A0110", VA = "0x1880A1910")]
	protected internal void CHFOJJOJJKF(object MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80A1AA0", Offset = "0x80A02A0", VA = "0x1880A1AA0")]
	protected internal bool FGOIBHEFHIP()
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
