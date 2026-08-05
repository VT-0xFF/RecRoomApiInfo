using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Core.DataStructures.Tokens;
using RecRoom.DataLayer;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures.Tokens;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface FUPHZSXQDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XXXKPBOFHSB(Type a, Type b);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object[] UHHOHOTXGSK(object[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object[] YJLUKAXTQJF(object[] a, ParameterInfo[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface YYJRECEXABT
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<bool> GFNIWAZSETB;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ESPPUDNRXWU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YSYMROYVZSD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WPFPYICZCPR(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IDisposable UNFJHZGXGQE();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PWIPBWNAETF();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GGVVZGHSXWT(StringBuilder a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JPBOSRAIWOW(bool a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface WFDZJXBVAKR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool YJMAWCMYMZE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		LULDBTLWMMU NAABVCHULKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool FDXUTTWQDHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool SZNGBOTGQRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object HCYXBXXAGJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool RWMSFILBLUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<LULDBTLWMMU, LULDBTLWMMU> QUKBVYNYZRQ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ENVEPPLLZCH();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool LeaveRoom();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool PJGOPJVAVGC(string a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool TOQCODXOKCT(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum ClientState
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
	public interface LULDBTLWMMU : GNTZBYSJAKA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ClientState IWTSUTKKYDN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[CanBeNull]
		VMUJRLNJPHP AVUADSSKXTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool FDXUTTWQDHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool FKRHGRNAQOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[CanBeNull]
		Exception UJTZQSJUDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int JEDOTRPWTAG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool PNGCCEKMCGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<string, long> EXUPCMEPHGZ;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<ClientState, ClientState> PVQSHXBGUBT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface QEFSHYPRWFN
	{
		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<string, long> EXUPCMEPHGZ;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<KMNYUBYLMOF> JADLUJHYKBU;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery networkDelivery);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface HICUPWZNCRO
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int CEQSIFBJLUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		int NKGCJSYPLDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		LRIABUPBGVB OJYVFBFKHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int FSLGJJKUOVC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string VFFMJFAUHPP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Func<string, string> TWHAMMEMUFY
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action<LRIABUPBGVB> AOECWXLSHVX;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OIWJOOSVADD(string a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[CanBeNull]
		LRIABUPBGVB DNCAMOEVDPX(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[CanBeNull]
		LRIABUPBGVB SFXJGGUGRGT(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "13")]
		LRIABUPBGVB NFVPIIQPSWR(int a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<LRIABUPBGVB> JHFUMHTVXIR(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<LRIABUPBGVB> SCHANGSOPCC(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool EYHVMJXQPTD(LRIABUPBGVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JXTMYJLBPME
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action HVLIAXACQNU;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AHOKYVLRRAH();
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GNTZBYSJAKA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		LBZZZSNEOUH SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface HAMVSMTRQPP
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string DPCDTBVKSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		long JUEMVLWLMBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long GYAGCJOQOFV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MLWORJOZBWE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LRJLKNGLINT : WFDZJXBVAKR, YYJRECEXABT, QEFSHYPRWFN, HICUPWZNCRO, JXTMYJLBPME, GNTZBYSJAKA, HAMVSMTRQPP
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float LNQEKLSZPSF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int WKQPIRWOUFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int NSVJDHNRQKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int IZCIEUZNMTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int EFRFNSNEUAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float BNQFWXFCOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float LVWGEFOQOKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool WNXGPUBIYSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		double QMXCMFRZYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int XAFLDETVPRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool VAZDZMRSDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "27")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action KUBXIASYVZK;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float YMZRYPUBVMK(bool a, int b = 1);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KFKCHGZLITT();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JBQIZXOFPVL();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ZZUUNNXCDTT();

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JQQZCDDFVPK(List<object> a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void HMXABJOURQA(int a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void CFNECTYJAQJ(object a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void WMUJSUCSANU();

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void XHTQMBHYGTZ();

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void QDCEVCMUVNA();

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void KYZOGDONURM(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		object Deserialize(NativeArray<byte> data);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int CZGRFBDRIQI(KMNYUBYLMOF a);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void WBZLUGCPMXF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface MLYNHFFEFAJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class OSIQXZBIXOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string DTFWPVUUEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Vector3 DSBMUQQWNYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Quaternion VBLUIXJXMKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Vector3 ZZGGBTRPGMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int ERFODNTORMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CreationInstantiationParameters HEXVXDPJSQZ;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86041C0", Offset = "0x86027C0", VA = "0x1886041C0")]
		public object[] UYNLOSJACEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OSIQXZBIXOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum DisconnectCause
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
	public class LBZZZSNEOUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public YQBTYEHUFCJ<KMNYUBYLMOF> QSGFYLMGWEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public YPLZGKACCUI<KMNYUBYLMOF, KAUBEGREKJA> UINMCSLOUQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public ENIVEIKFIDY JBTPNMVEVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public ENIVEIKFIDY BXGQVZACVMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public YQBTYEHUFCJ<DisconnectCause> CDLISPOHASD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ENIVEIKFIDY TSBIYQQNBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public YQBTYEHUFCJ<string> IBHTDGLLADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public YQBTYEHUFCJ<Dictionary<string, object>> ECLLHWWGYBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public YQBTYEHUFCJ<DisconnectCause> MQAOAORDXWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public YPLZGKACCUI<bool, bool> SXBZIWSPQPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public ENIVEIKFIDY CKFIQPDJPDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ENIVEIKFIDY FJKDIKTDFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ENIVEIKFIDY ETUPZTWQHPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public ENIVEIKFIDY DCHWBNONEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public ENIVEIKFIDY VBIFLCCIDBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public YQBTYEHUFCJ<LRIABUPBGVB> LMCQDGIENKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public YPLZGKACCUI<short, string> YKUPOXUKPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public YQBTYEHUFCJ<IDictionary<object, object>> YPZASIIFZVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public YPLZGKACCUI<short, string> BEVOWEBYYSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ENIVEIKFIDY JICYLJYLXLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public YQBTYEHUFCJ<LRIABUPBGVB> KQRYEVUGVVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public YQBTYEHUFCJ<LRIABUPBGVB> LCLFWBKBKNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public YQBTYEHUFCJ<LRIABUPBGVB> AAUOOIBGYVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public YPLZGKACCUI<LRIABUPBGVB, IDictionary<object, object>> HIYSKFYFFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public ENIVEIKFIDY DYTWQPFWVOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ENIVEIKFIDY GCXLIDPIKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public YQBTYEHUFCJ<DisconnectCause> GGMDUOBTPSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public YQBTYEHUFCJ<DisconnectCause> MYFFSSKNAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public YQBTYEHUFCJ<DisconnectCause> FZNHYTXZFHX;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8603A90", Offset = "0x8602090", VA = "0x188603A90")]
		public LBZZZSNEOUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class SWYQQJDGKQY
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8604E80", Offset = "0x8603480", VA = "0x188604E80")]
		public static bool RFLZYGKXCPJ(this WFDZJXBVAKR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8604DB0", Offset = "0x86033B0", VA = "0x188604DB0")]
		public static bool MXVTYUYMFWZ(this WFDZJXBVAKR a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class ZIVUGZRFOJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class RREUWXTBUIK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly ZIVUGZRFOJL CZTINXUHIVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private bool MFRVCTFDCZV;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8604490", Offset = "0x8602A90", VA = "0x188604490")]
			public RREUWXTBUIK(ZIVUGZRFOJL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8604390", Offset = "0x8602990", VA = "0x188604390", Slot = "1")]
			~RREUWXTBUIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8604300", Offset = "0x8602900", VA = "0x188604300", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8604430", Offset = "0x8602A30", VA = "0x188604430")]
			private void TSMCTNTROSI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly object XIYGRHTDXSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly object GIJKTPBHAVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float PAFBQWAHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float MNWMYEEOHNU;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public abstract bool RWMSFILBLUR
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public abstract float LNQEKLSZPSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float BNQFWXFCOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAFB210", Offset = "0xAF9810", VA = "0x180AFB210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8606200", Offset = "0x8604800", VA = "0x188606200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float LVWGEFOQOKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAFA720", Offset = "0xAF8D20", VA = "0x180AFA720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8605360", Offset = "0x8603960", VA = "0x188605360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public abstract LULDBTLWMMU NAABVCHULKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private ZCBRZWUWSEW BXWYIWKQVQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private ZCBRZWUWSEW HYPVJHNXFHL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private NNJJTMKQPQG<Func<float>> UDVGQGUJIOV
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool BKWDFTFDPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x256DC40", Offset = "0x256C240", VA = "0x18256DC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected bool YUQUCYVMHLW
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86054B0", Offset = "0x8603AB0", VA = "0x1886054B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected bool EZQWYDZMZPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8605D40", Offset = "0x8604340", VA = "0x188605D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<string, long> EXUPCMEPHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8605440", Offset = "0x8603A40", VA = "0x188605440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8606370", Offset = "0x8604970", VA = "0x188606370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> GFNIWAZSETB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8605A70", Offset = "0x8604070", VA = "0x188605A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x86063E0", Offset = "0x86049E0", VA = "0x1886063E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action KUBXIASYVZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x86053A0", Offset = "0x86039A0", VA = "0x1886053A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8605500", Offset = "0x8603B00", VA = "0x188605500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action HVLIAXACQNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x86055A0", Offset = "0x8603BA0", VA = "0x1886055A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8606240", Offset = "0x8604840", VA = "0x188606240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JBQIZXOFPVL();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8606810", Offset = "0x8604E10", VA = "0x188606810")]
		protected ZIVUGZRFOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8605A50", Offset = "0x8604050", VA = "0x188605A50")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8606520", Offset = "0x8604B20", VA = "0x188606520")]
		public void WPFPYICZCPR(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8605640", Offset = "0x8603C40", VA = "0x188605640")]
		public void ESPPUDNRXWU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86066A0", Offset = "0x8604CA0", VA = "0x1886066A0")]
		public void YSYMROYVZSD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86062E0", Offset = "0x86048E0", VA = "0x1886062E0")]
		public IDisposable UNFJHZGXGQE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8605B20", Offset = "0x8604120", VA = "0x188605B20", Slot = "10")]
		public virtual bool JPBOSRAIWOW(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8605D80", Offset = "0x8604380", VA = "0x188605D80")]
		private bool NKXIPKGBUTN([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8605F20", Offset = "0x8604520", VA = "0x188605F20")]
		private bool PCRBWBYBAXO([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8606010", Offset = "0x8604610", VA = "0x188606010")]
		public bool PWIPBWNAETF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8605740", Offset = "0x8603D40", VA = "0x188605740")]
		public void GGVVZGHSXWT(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8606060", Offset = "0x8604660", VA = "0x188606060")]
		private void QXAJACYZKUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8606780", Offset = "0x8604D80", VA = "0x188606780")]
		private void ZOFFAOLMSYI(Func<float> a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8605FB0", Offset = "0x86045B0", VA = "0x188605FB0")]
		public void PDVBHWLZYRC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8606490", Offset = "0x8604A90", VA = "0x188606490")]
		public void WMUJSUCSANU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8606640", Offset = "0x8604C40", VA = "0x188606640")]
		public void XHTQMBHYGTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86066E0", Offset = "0x8604CE0", VA = "0x1886066E0")]
		private void ZLIGBFYXQOF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAFA720", Offset = "0xAF8D20", VA = "0x180AFA720")]
		private float AAIZTLTAXZF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAFB210", Offset = "0xAF9810", VA = "0x180AFB210")]
		private float CSCSUYBKQXA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86059A0", Offset = "0x8603FA0", VA = "0x1886059A0")]
		private void ICHGRLOHYOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8605310", Offset = "0x8603910", VA = "0x188605310")]
		public void AHOKYVLRRAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class AAJBHCHDHWP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string TAMRHVSSZCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool WVVGWNLHHMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected internal bool TRWHLYJDMLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected internal int FFXQIJNNRLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected internal byte[] BNFJZDSCMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected internal byte FMNKVZZTRDD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly System.Random ZAEKLHQFLKX;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86033F0", Offset = "0x86019F0", VA = "0x1886033F0", Slot = "5")]
		public virtual bool FWRRGAXNOOQ(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8603330", Offset = "0x8601930", VA = "0x188603330", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86032F0", Offset = "0x86018F0", VA = "0x1886032F0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8603370", Offset = "0x8601970", VA = "0x188603370")]
		protected internal void FTYJJGFKYMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86034A0", Offset = "0x8601AA0", VA = "0x1886034A0")]
		protected AAJBHCHDHWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CDDOPGCFURQ : AAJBHCHDHWP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Socket QEDBAIOUTYE;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8603730", Offset = "0x8601D30", VA = "0x188603730", Slot = "5")]
		public override bool FWRRGAXNOOQ(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8603550", Offset = "0x8601B50", VA = "0x188603550", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x79210A0", Offset = "0x791F6A0", VA = "0x1879210A0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86039B0", Offset = "0x8601FB0", VA = "0x1886039B0")]
		public CDDOPGCFURQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class TDXBNBJOQUS
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string JCAQGEWAOFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string OAZKOBFRGIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string UEFSGPGKSSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int NPHMGURULWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7780", Offset = "0xAA5D80", VA = "0x180AA7780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86051F0", Offset = "0x86037F0", VA = "0x1886051F0")]
		public TDXBNBJOQUS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8604F50", Offset = "0x8603550", VA = "0x188604F50")]
		private void NHBFKZLPHXO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8605060", Offset = "0x8603660", VA = "0x188605060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8605110", Offset = "0x8603710", VA = "0x188605110")]
		public string ToString(bool compact = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RUHCCLCSNHX
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static int MVOSTLIJCFU;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static bool APYHRSCWQID;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static int NRQPNUDJTPB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static int KZYOJEJWFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TDXBNBJOQUS YAQFXREWAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string VMFGRIDFSFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int XBKTMEBQZLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int FQNBXEDPBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Action<TDXBNBJOQUS> KTJUZIWMGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private AAJBHCHDHWP GPFLORTNGVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<int> RADTDHEFPPS;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool SCIZNHLCZJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCB5810", Offset = "0xCB3E10", VA = "0x180CB5810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8604D00", Offset = "0x8603300", VA = "0x188604D00")]
		public RUHCCLCSNHX(TDXBNBJOQUS a, Action<TDXBNBJOQUS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8604940", Offset = "0x8602F40", VA = "0x188604940")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8604500", Offset = "0x8602B00", VA = "0x188604500")]
		public static string DDXOOLLFTYC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86044F0", Offset = "0x8602AF0", VA = "0x1886044F0")]
		protected internal void CJKZGEUUBIH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8604670", Offset = "0x8602C70", VA = "0x188604670")]
		protected internal bool SJQBMQQJLLL()
		{
			return default(bool);
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
