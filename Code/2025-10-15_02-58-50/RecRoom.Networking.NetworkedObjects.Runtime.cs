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
	public interface LUQYOCSEHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HKHZNWNTGFE(Type a, Type b);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object[] AXKFITBXSVR(object[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object[] QRFVRNZBGPM(object[] a, ParameterInfo[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RIEHQAGCECW
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<bool> XGSQZCTPVZI;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RJGRQRTAVHB(object a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DUTPBBDBADC(object a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KEKFVGJMUAK(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IDisposable VAJEAEQSJBH();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OHMQPICSRKU();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MSNEZOEDQKA(StringBuilder a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HKCVXLISXLJ(bool a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LHVRLQQVSQU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool QQMEGTADUQL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		RBETLIDWDVR TRVLDQDOWHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool YZSDVXYZDAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool EBZAJFLGPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool BSHEGRJNMKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool ISOPISRYMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object PVLYZHTYGFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool NRNTSANFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<RBETLIDWDVR, RBETLIDWDVR> RHRSFMZGMFF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LMRVREPCZQK();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool LeaveRoom();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool IWWMMBRGHWJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool UNQAQYEWZGY(object a);
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
	public interface RBETLIDWDVR : KKWQOVLPYQB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ClientState RQKQVQYYWSU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[CanBeNull]
		ABWHXVJVLPE AOUAOBTSYDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool YZSDVXYZDAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool EBZAJFLGPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool UPWIKWEKFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[CanBeNull]
		Exception UFINETWLPOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int YYOAFZCTOHR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool AGZUDIRMHYE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<string, long> CNAPRNIOBHI;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<ClientState, ClientState> UQDIBZWPYZM;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BPNYDMHEGGI
	{
		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<string, long> CNAPRNIOBHI;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<PQDMMRYYGHS> NPEUFGMMXVN;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RaiseEvent(byte eventCode, object eventContent, ZPXXLQJTGDJ raiseEventOptions, RRNetworkDelivery networkDelivery);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface RXEEQWARQDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		LZEYQUPSRUQ GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int CFJQWSGKLER
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		int REILCMUTBRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		LZEYQUPSRUQ FFTPZTDYYMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int HLUOFLCBKHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string XNOSUSNTGNW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Func<string, string> KPIVEISJAML
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action<LZEYQUPSRUQ> GVVOLKWYSVM;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void TCGAFZPNYYG(string a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[CanBeNull]
		LZEYQUPSRUQ RMOHZMDEGFK(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[CanBeNull]
		LZEYQUPSRUQ QZOOCSSOTEG(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "13")]
		LZEYQUPSRUQ ZVRIZSNDDOY(int a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<LZEYQUPSRUQ> SLZEQDKDLFW(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<LZEYQUPSRUQ> QIDBEPWWMTZ(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool XEXQTEGNXOE(LZEYQUPSRUQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface SARRWXEQYHH
	{
		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action EAULIOISHHN;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QODSXISIZSC();
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KKWQOVLPYQB
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ZPMZXUEDLIU HGXHCIEEHMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface UNHZSCQNBPS
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string FSRDKZBWKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		long JOEXIQXLLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long FEFDZBSAJUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int KZONMQEIIDP();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface RZNZAUAZENO : LHVRLQQVSQU, RIEHQAGCECW, BPNYDMHEGGI, RXEEQWARQDP, SARRWXEQYHH, KKWQOVLPYQB, UNHZSCQNBPS
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float ARWVOPQWQEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int DAKOSDDBMSH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int JBVUXQRHUMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int FRGAMLCORDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int PHZTBKPXKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float MISOPQMSEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float KGHTHINGSGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool QDURDVTJFRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		double ZZXWEPDGXLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int JESLADALABS
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool VMCSTYVXSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "27")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action UCSSLWNFATJ;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float COWRICCYMWV(bool a, int b = 1);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KFGVJADWQCY();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RDPPNQPWMNC();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XLMXGWKZHIM();

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MFVMRTWDNFR(List<object> a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LBUMCAPOIND(int a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void EHKQPQBBYKM(object a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AGPRWREAHLF();

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void FIRWFXOCWYK();

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void XTENLXJOVMP();

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void HPFTFJWMZQX(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		object Deserialize(NativeArray<byte> data);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int HPXBGWAUHLR(PQDMMRYYGHS a);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void SBQIBJGZCLE(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface LHMCHOKAAHI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HWBSQPITHTV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string YINFDZMFMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Vector3 YJGZPHQQOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Quaternion BSVMTQBEROR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Vector3 XQMDWVHUFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int ROLOTXHHWXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CreationInstantiationParameters RDMKXUERMTK;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85804F0", Offset = "0x857F2F0", VA = "0x1885804F0")]
		public object[] KRGJDEXAEIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public HWBSQPITHTV()
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
	public class ZPMZXUEDLIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public YVFAYFMDPIA<PQDMMRYYGHS> HFNZCKUGKUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public YVUVPZTVRQB<PQDMMRYYGHS, ZPXXLQJTGDJ> CSTTLFDCNWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public VYROOIAXTCX OFNMSVILLZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VYROOIAXTCX PSLDTFFJKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public YVFAYFMDPIA<DisconnectCause> BJVZVHJAPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public VYROOIAXTCX SCDSTRWLITZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public YVFAYFMDPIA<string> MDDTLQFJJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public YVFAYFMDPIA<Dictionary<string, object>> AZWSMMLDHXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public YVFAYFMDPIA<DisconnectCause> PPVQKOLOUYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public YVUVPZTVRQB<bool, bool> MZXPLRKALZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public VYROOIAXTCX XJTIPPVCPGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public VYROOIAXTCX RDELOBACSYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public VYROOIAXTCX DIQICDKATAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public VYROOIAXTCX EGNZIIYEQDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public VYROOIAXTCX QSKMPRPGBYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public YVFAYFMDPIA<LZEYQUPSRUQ> UVPCWQOZBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public YVUVPZTVRQB<short, string> VKFSYIJPMDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public YVFAYFMDPIA<IDictionary<object, object>> GWGDLGJGMHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public YVUVPZTVRQB<short, string> NRUCBQQQYIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public VYROOIAXTCX DWWIUWDUCNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public YVFAYFMDPIA<LZEYQUPSRUQ> TRUNSBWQEQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public YVFAYFMDPIA<LZEYQUPSRUQ> WXRHYVVMZPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public YVFAYFMDPIA<LZEYQUPSRUQ> TEWAASZEXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public YVUVPZTVRQB<LZEYQUPSRUQ, IDictionary<object, object>> ELSZLQIRKES;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public VYROOIAXTCX KSLGXQDPQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public VYROOIAXTCX SBDNDHJJEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public YVFAYFMDPIA<DisconnectCause> QWAIESCWQBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public YVFAYFMDPIA<DisconnectCause> AUOFEMQPSGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public YVFAYFMDPIA<DisconnectCause> YTSTPZMGVPU;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8581DF0", Offset = "0x8580BF0", VA = "0x188581DF0")]
		public ZPMZXUEDLIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RZSRSMZGIQX
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85806F0", Offset = "0x857F4F0", VA = "0x1885806F0")]
		public static bool VWLXHFNUTEG(this LHVRLQQVSQU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8580620", Offset = "0x857F420", VA = "0x188580620")]
		public static bool RUIATQVJROM(this LHVRLQQVSQU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class GPGVOGUVSTQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class XHLBTLRVJAZ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly GPGVOGUVSTQ KDLCLBFDZTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private bool RKZVTHIHIQI;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8580E90", Offset = "0x857FC90", VA = "0x188580E90")]
			public XHLBTLRVJAZ(GPGVOGUVSTQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8580D90", Offset = "0x857FB90", VA = "0x188580D90", Slot = "1")]
			~XHLBTLRVJAZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8580D00", Offset = "0x857FB00", VA = "0x188580D00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8580E30", Offset = "0x857FC30", VA = "0x188580E30")]
			private void MLPDGFMOTDH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly object WQVBBBAWBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly object VTVQOSAQBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float YRHHXMJUQBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float GPWBAPHNVKF;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public abstract bool NRNTSANFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public abstract float ARWVOPQWQEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float MISOPQMSEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x857EFA0", Offset = "0x857DDA0", VA = "0x18857EFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float KGHTHINGSGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAFFA60", Offset = "0xAFE860", VA = "0x180AFFA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x857F480", Offset = "0x857E280", VA = "0x18857F480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public abstract RBETLIDWDVR TRVLDQDOWHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private NTWXEAAFYGD GQVENYHBFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private NTWXEAAFYGD QLAALFVCKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private NQNQZWLKRCV<Func<float>> XZRYAGUVDTM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool GCRXQENRVXV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2581320", Offset = "0x2580120", VA = "0x182581320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected bool ZBWJRQJOMSP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x857F690", Offset = "0x857E490", VA = "0x18857F690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected bool APJBVTKFNYY
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x857EFE0", Offset = "0x857DDE0", VA = "0x18857EFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<string, long> CNAPRNIOBHI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x857F3F0", Offset = "0x857E1F0", VA = "0x18857F3F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8580320", Offset = "0x857F120", VA = "0x188580320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> XGSQZCTPVZI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x857F120", Offset = "0x857DF20", VA = "0x18857F120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8580000", Offset = "0x857EE00", VA = "0x188580000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action UCSSLWNFATJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x857FE60", Offset = "0x857EC60", VA = "0x18857FE60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8580150", Offset = "0x857EF50", VA = "0x188580150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action EAULIOISHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x85801F0", Offset = "0x857EFF0", VA = "0x1885801F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x857FBD0", Offset = "0x857E9D0", VA = "0x18857FBD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void RDPPNQPWMNC();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8580390", Offset = "0x857F190", VA = "0x188580390")]
		protected GPGVOGUVSTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x857F460", Offset = "0x857E260", VA = "0x18857F460")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x857F4C0", Offset = "0x857E2C0", VA = "0x18857F4C0")]
		public void KEKFVGJMUAK(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x857FF00", Offset = "0x857ED00", VA = "0x18857FF00")]
		public void RJGRQRTAVHB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x857F020", Offset = "0x857DE20", VA = "0x18857F020")]
		public void DUTPBBDBADC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8580290", Offset = "0x857F090", VA = "0x188580290")]
		public IDisposable VAJEAEQSJBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x857F1D0", Offset = "0x857DFD0", VA = "0x18857F1D0", Slot = "10")]
		public virtual bool HKCVXLISXLJ(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x857F6E0", Offset = "0x857E4E0", VA = "0x18857F6E0")]
		private bool MAWKHITNTDY([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x857F880", Offset = "0x857E680", VA = "0x18857F880")]
		private bool MLYWGTHBNLR([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x857FB80", Offset = "0x857E980", VA = "0x18857FB80")]
		public bool OHMQPICSRKU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x857F910", Offset = "0x857E710", VA = "0x18857F910")]
		public void MSNEZOEDQKA(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x857FC70", Offset = "0x857EA70", VA = "0x18857FC70")]
		private void PWSDGTRDYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x857EF10", Offset = "0x857DD10", VA = "0x18857EF10")]
		private void CBFEHWLTEGT(Func<float> a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x857F060", Offset = "0x857DE60", VA = "0x18857F060")]
		public void ECKDXVLZSYN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x857EE80", Offset = "0x857DC80", VA = "0x18857EE80")]
		public void AGPRWREAHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x857F0C0", Offset = "0x857DEC0", VA = "0x18857F0C0")]
		public void FIRWFXOCWYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85800B0", Offset = "0x857EEB0", VA = "0x1885800B0")]
		private void THJLZOVPLFW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAFFA60", Offset = "0xAFE860", VA = "0x180AFFA60")]
		private float XMEQXWUBNGS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180")]
		private float URDVGYUAXKB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x857F5E0", Offset = "0x857E3E0", VA = "0x18857F5E0")]
		private void KGORXOMRDWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x857FE10", Offset = "0x857EC10", VA = "0x18857FE10")]
		public void QODSXISIZSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class YYDVOBTXBPW : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string UMADRPGZFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool BDSFUDVRXZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected internal bool AQTYMTCJNWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected internal int TZWEYZWACWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected internal byte[] YAUKPAZYAKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected internal byte RHLZOSZTUVE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly System.Random VPWJRKNANIA;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8581C00", Offset = "0x8580A00", VA = "0x188581C00", Slot = "5")]
		public virtual bool TCZUUEHPORP(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8581BC0", Offset = "0x85809C0", VA = "0x188581BC0", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8581B80", Offset = "0x8580980", VA = "0x188581B80", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8581C40", Offset = "0x8580A40", VA = "0x188581C40")]
		protected internal void YXKPQQSUPQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8581D40", Offset = "0x8580B40", VA = "0x188581D40")]
		protected YYDVOBTXBPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class VEPTAEFRWOP : YYDVOBTXBPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Socket URMMVJDDBJB;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85809A0", Offset = "0x857F7A0", VA = "0x1885809A0", Slot = "5")]
		public override bool TCZUUEHPORP(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85807C0", Offset = "0x857F5C0", VA = "0x1885807C0", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7882970", Offset = "0x7881770", VA = "0x187882970", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8580C20", Offset = "0x857FA20", VA = "0x188580C20")]
		public VEPTAEFRWOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class YDNLSMTAMEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string OEZDCDKLODA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string EATDLXEXYWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string TLEUDTTUNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int HEDAHUEJYAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7140", Offset = "0xAA5F40", VA = "0x180AA7140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8581190", Offset = "0x857FF90", VA = "0x188581190")]
		public YDNLSMTAMEH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8580EF0", Offset = "0x857FCF0", VA = "0x188580EF0")]
		private void GDEMKPRJRTD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8581000", Offset = "0x857FE00", VA = "0x188581000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85810B0", Offset = "0x857FEB0", VA = "0x1885810B0")]
		public string ToString(bool compact = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class YDUUEKZSUXC
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static int LZJOQOIKVSF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static bool JCDHTACJDMU;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static int PZNQOKRXCRG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static int PTYWNWYNJWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private YDNLSMTAMEH OUEPLFHYQOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string BMCPBVUTQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int SMDEDKUJBQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int AJTDVFUMUON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Action<YDNLSMTAMEH> ZGVTDPQTJJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private YYDVOBTXBPW BBFPRIJHIQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<int> IHJQTPLWDGP;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FDAQQYSEFMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCB7060", Offset = "0xCB5E60", VA = "0x180CB7060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCB7050", Offset = "0xCB5E50", VA = "0x180CB7050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8581AD0", Offset = "0x85808D0", VA = "0x188581AD0")]
		public YDUUEKZSUXC(YDNLSMTAMEH a, Action<YDNLSMTAMEH> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85816F0", Offset = "0x85804F0", VA = "0x1885816F0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8581580", Offset = "0x8580380", VA = "0x188581580")]
		public static string IXZDZQQKVUX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8581A40", Offset = "0x8580840", VA = "0x188581A40")]
		protected internal void ZEACAECKKHS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85812B0", Offset = "0x85800B0", VA = "0x1885812B0")]
		protected internal bool GKWPDPIPNZM()
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
