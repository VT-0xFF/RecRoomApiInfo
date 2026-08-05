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
	public interface GJMXBPHDGRO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AQCUZQKRDBX(Type a, Type b);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object[] WGYICEFGHZE(object[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object[] VNBGVHDKBKL(object[] a, ParameterInfo[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface THRNSHIZZRL
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<bool> MNOXXIJXNBF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BRPVASTUVXG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZKEAOGVYOYX(object a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FNPECDSTJJF(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IDisposable YPKEGYFXJQU();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool AHLGDCPQCTZ();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HLGSIZBNURV(StringBuilder a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool FLCPKTADSRM(bool a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface RZOXWQLLXKJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool ATFDINOZHHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TXELKWRQCPY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CYAFZGEFHRF(object a);
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
	public interface SYVXMVIVSMY : HDXFMLHGFWA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ClientState JMOGAOLIVKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[CanBeNull]
		AWTHKFEHXLT XBEDGBSZWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[CanBeNull]
		Exception FVMFOCZHHWF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int BDUBWMRIMRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool BKHHWFVBFRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string, long> NXPMPDFOVRH;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ClientState, ClientState> XLPMIKKPUQJ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JBWIPJPYTPJ
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string, long> NXPMPDFOVRH;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<VZZVUJOFUEN> SEULJHVNYJA;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x993A200", Offset = "0x9938C00", VA = "0x18993A200", Slot = "4")]
		bool WDVHFRRPINS(NetworkEventCode a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface PGZUXXIKBWU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int JCXFDFGCCTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int QDJMMEDTCRH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		JNIVCIZIPSX JXZBVLEPNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int DFGAAQKITZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string SNLRDKYBUZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Func<string, string> OGJELKEBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<JNIVCIZIPSX> ABBOYDVOWWF;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SENIMATDESJ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[CanBeNull]
		JNIVCIZIPSX QPJFGSUGGOJ(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[CanBeNull]
		JNIVCIZIPSX LFTZYTJFMLB(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		JNIVCIZIPSX ENKLWSKEEBX(int a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<JNIVCIZIPSX> ZXOGAFLDDTP(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<JNIVCIZIPSX> YENVYXZQREK(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool EKOJRVGZPFD(JNIVCIZIPSX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface HQIVWAVMPUY
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action HEZLKODRXBM;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VQWJBICIWZF();
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface HDXFMLHGFWA
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		QOLRJJUHWXN TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface CCOMIRDRRSB
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		long JBCXXGEZEAI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long SGHGDBQEDHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int XIGGYNIAFOY();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface GIWROPIUCYR : RZOXWQLLXKJ, THRNSHIZZRL, JBWIPJPYTPJ, PGZUXXIKBWU, HQIVWAVMPUY, HDXFMLHGFWA, CCOMIRDRRSB
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int VXSCVTSQSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		int VIUXZCQAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float ZUNWQJOUNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float DMCYMRDMOQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool XXKVZJBOJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "26")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action IHCMQFWIZOM;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float KCLCQUXXBMW(bool a, int b = 1);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool MTDTBHVFAVD();

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void FRYZBTPERVH();

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OLHQCGTYEQJ();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void FKRUBDBENNS(List<object> a, int b);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void WWMLLCIZSYQ(int a, object b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void URXDBQZOSHP(object a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GRBHZXBBKBY();

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JKFGAUOOOFZ();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void HBDIHWPLQAC();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void XQIXCNAGDPI(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "18")]
		object Deserialize(NativeArray<byte> data);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int WUPATQAEFXK(VZZVUJOFUEN a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class YMVIVYMUDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string VFLVGMIMJTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Vector3 IWJEEIVKPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Quaternion TYYYGKBREIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Vector3 ZGYOETDZTFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int QVTSQWDZVLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CreationInstantiationParameters GKGJLUQDWFD;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x993D030", Offset = "0x993BA30", VA = "0x18993D030")]
		public object[] ITLXGYSIJOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public YMVIVYMUDJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
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
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class QOLRJJUHWXN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public DQCNOGDGYBL<VZZVUJOFUEN> CSFTJOZSSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DPMSWLVOVTK<VZZVUJOFUEN, BJJNNDTQGRE> LSXGMDXIJAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public BQUYOYJDJCS ETLLHWZIBWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public BQUYOYJDJCS XRENFGMRHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public DQCNOGDGYBL<DisconnectCause> BFKMDGTNBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BQUYOYJDJCS SMJOOBSENCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DQCNOGDGYBL<string> XNDGBOJLQLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DQCNOGDGYBL<Dictionary<string, object>> GCDEKJMXNCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DQCNOGDGYBL<DisconnectCause> PCJRRCFJWJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DPMSWLVOVTK<bool, bool> FNRJCZYIXZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BQUYOYJDJCS KMKABCGQFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BQUYOYJDJCS FADPNQKSXGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BQUYOYJDJCS DLOHPJIVUDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BQUYOYJDJCS XRJDFEIEHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public BQUYOYJDJCS CPPDZWXTICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DQCNOGDGYBL<JNIVCIZIPSX> LXNXHJKSNZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DPMSWLVOVTK<short, string> KEAWJLGHMGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public DQCNOGDGYBL<IDictionary<object, object>> KPMPYEUOFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DPMSWLVOVTK<short, string> WGONFTJPPTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public BQUYOYJDJCS LYTXHTWQENS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public DQCNOGDGYBL<JNIVCIZIPSX> GPXNHLRXCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DQCNOGDGYBL<JNIVCIZIPSX> AAKGSEOJUEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DQCNOGDGYBL<JNIVCIZIPSX> SOVZNRKTCXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DPMSWLVOVTK<JNIVCIZIPSX, IDictionary<object, object>> CDDVZAJLUIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public BQUYOYJDJCS XLNVTCWQDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BQUYOYJDJCS SXQMDHFFVTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DQCNOGDGYBL<DisconnectCause> JDBIGSBUKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DQCNOGDGYBL<DisconnectCause> HNGAGVGQAOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DQCNOGDGYBL<DisconnectCause> NCOJUIDDMKB;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x993B330", Offset = "0x9939D30", VA = "0x18993B330")]
		public QOLRJJUHWXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class YHGHLVNQMBX
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class PMPWZTAJYXQ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly YHGHLVNQMBX DFRZWVBQEQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private bool MLELKNOQAUT;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x993B2D0", Offset = "0x9939CD0", VA = "0x18993B2D0")]
			public PMPWZTAJYXQ(YHGHLVNQMBX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x993B230", Offset = "0x9939C30", VA = "0x18993B230", Slot = "1")]
			~PMPWZTAJYXQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x993B1A0", Offset = "0x9939BA0", VA = "0x18993B1A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x993B140", Offset = "0x9939B40", VA = "0x18993B140")]
			private void BRKNCCSWHSA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly object UUKLOIINGUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly object ZQCHYCXCUSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float QZEAFQKWACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float LNMWPLNJWHQ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public abstract bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public abstract float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float ZUNWQJOUNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD38680", Offset = "0xD37080", VA = "0x180D38680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x993CDC0", Offset = "0x993B7C0", VA = "0x18993CDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float DMCYMRDMOQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD24310", Offset = "0xD22D10", VA = "0x180D24310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x993C940", Offset = "0x993B340", VA = "0x18993C940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private OZHUFMCFCAS PHMFSFNIDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private OZHUFMCFCAS DXRKGTVUEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private SPOMUMEYDPM<Func<float>> GGDNVSMPTDD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private bool BFTNIOOHPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x25DC010", Offset = "0x25DAA10", VA = "0x1825DC010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<string, long> NXPMPDFOVRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x993CD50", Offset = "0x993B750", VA = "0x18993CD50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x993C820", Offset = "0x993B220", VA = "0x18993C820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> MNOXXIJXNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x993C890", Offset = "0x993B290", VA = "0x18993C890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x993C6E0", Offset = "0x993B0E0", VA = "0x18993C6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action IHCMQFWIZOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x993C640", Offset = "0x993B040", VA = "0x18993C640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x993C230", Offset = "0x993AC30", VA = "0x18993C230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action HEZLKODRXBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x993BC50", Offset = "0x993A650", VA = "0x18993BC50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x993BAB0", Offset = "0x993A4B0", VA = "0x18993BAB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FRYZBTPERVH();

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x993CED0", Offset = "0x993B8D0", VA = "0x18993CED0")]
		protected YHGHLVNQMBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x993C5C0", Offset = "0x993AFC0", VA = "0x18993C5C0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x993BF70", Offset = "0x993A970", VA = "0x18993BF70")]
		public void FNPECDSTJJF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x993BB50", Offset = "0x993A550", VA = "0x18993BB50")]
		public void BRPVASTUVXG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x993CE00", Offset = "0x993B800", VA = "0x18993CE00")]
		public void ZKEAOGVYOYX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x993CCC0", Offset = "0x993B6C0", VA = "0x18993CCC0")]
		public IDisposable YPKEGYFXJQU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x993BD50", Offset = "0x993A750", VA = "0x18993BD50", Slot = "10")]
		public virtual bool FLCPKTADSRM(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x993CAD0", Offset = "0x993B4D0", VA = "0x18993CAD0")]
		private bool VGFATZGKFUT([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x993CE40", Offset = "0x993B840", VA = "0x18993CE40")]
		private bool ZPZXIXUEPJS([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x993BA60", Offset = "0x993A460", VA = "0x18993BA60")]
		public bool AHLGDCPQCTZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x993C360", Offset = "0x993AD60", VA = "0x18993C360")]
		public void HLGSIZBNURV(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x993C090", Offset = "0x993AA90", VA = "0x18993C090")]
		private void FRMEHOBAGFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x993C790", Offset = "0x993B190", VA = "0x18993C790")]
		private void MMECUUNSQAE(Func<float> a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x993BCF0", Offset = "0x993A6F0", VA = "0x18993BCF0")]
		public void DCJELQNFFLW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x993C2D0", Offset = "0x993ACD0", VA = "0x18993C2D0")]
		public void GRBHZXBBKBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x993C5E0", Offset = "0x993AFE0", VA = "0x18993C5E0")]
		public void JKFGAUOOOFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x993CA30", Offset = "0x993B430", VA = "0x18993CA30")]
		private void USPPCOAEAIF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD24310", Offset = "0xD22D10", VA = "0x180D24310")]
		private float LPDASQDCFLF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD38680", Offset = "0xD37080", VA = "0x180D38680")]
		private float EKMJUKAWGAK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x993C980", Offset = "0x993B380", VA = "0x18993C980")]
		private void THDVPRKRJJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x993CC70", Offset = "0x993B670", VA = "0x18993CC70")]
		public void VQWJBICIWZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class YSIGIASXMLN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string SBWSHPHUALY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool YOLOBBKPXZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected internal bool RTQWCOYZVYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected internal int FQWVPBXVYVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected internal byte[] ROFKBNSZXDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected internal byte EPORCMMUNXH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly System.Random QLHZHCIFTAP;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x993D160", Offset = "0x993BB60", VA = "0x18993D160", Slot = "5")]
		public virtual bool DXWRRIULIUA(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x993D1E0", Offset = "0x993BBE0", VA = "0x18993D1E0", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x993D1A0", Offset = "0x993BBA0", VA = "0x18993D1A0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x993D220", Offset = "0x993BC20", VA = "0x18993D220")]
		protected internal void VQZGAVQPNPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x993D320", Offset = "0x993BD20", VA = "0x18993D320")]
		protected YSIGIASXMLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class NHCUNQTEFAS : YSIGIASXMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Socket PVVDKTQBLGE;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x993ABB0", Offset = "0x99395B0", VA = "0x18993ABB0", Slot = "5")]
		public override bool DXWRRIULIUA(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x993AE80", Offset = "0x9939880", VA = "0x18993AE80", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x993AE30", Offset = "0x9939830", VA = "0x18993AE30", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x993B060", Offset = "0x9939A60", VA = "0x18993B060")]
		public NHCUNQTEFAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZAPGNVXTQLA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string TGDROJCJTNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string QPXIKDAKYAO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string CVPZDRBCPOA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BPXXPXEWOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x993D670", Offset = "0x993C070", VA = "0x18993D670")]
		public ZAPGNVXTQLA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x993D560", Offset = "0x993BF60", VA = "0x18993D560")]
		private void UHNGTJAPLPK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x993D3D0", Offset = "0x993BDD0", VA = "0x18993D3D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x993D480", Offset = "0x993BE80", VA = "0x18993D480")]
		public string ToString(bool compact = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JXSCMBZWHVH
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static int YGWEALKCHQO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static bool RCLGEOIEZVJ;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static int UKLUCNOVCPJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static int WMDRSXNRRCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private ZAPGNVXTQLA SZCGBSNGACU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string COQSDWMFDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int JTZWNGFPGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int KVURNACSIRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Action<ZAPGNVXTQLA> KACTKKVEIBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private YSIGIASXMLN NIEHKMLCVGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<int> OTKDYBORLCQ;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LBKXPTTKEVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD66850", VA = "0x180D67E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD67E60", Offset = "0xD66860", VA = "0x180D67E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x993AB00", Offset = "0x9939500", VA = "0x18993AB00")]
		public JXSCMBZWHVH(ZAPGNVXTQLA a, Action<ZAPGNVXTQLA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x993A730", Offset = "0x9939130", VA = "0x18993A730")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x993A5B0", Offset = "0x9938FB0", VA = "0x18993A5B0")]
		public static string MUYSYOSUANQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x993A720", Offset = "0x9939120", VA = "0x18993A720")]
		protected internal void MWNLLAGSCST(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x993A2E0", Offset = "0x9938CE0", VA = "0x18993A2E0")]
		protected internal bool KNFGYITUOKF()
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
