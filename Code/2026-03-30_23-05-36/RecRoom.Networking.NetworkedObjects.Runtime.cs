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
	public interface UEDVAHKWDQA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BFUDTMQTHHP(Type a, Type b);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object[] FYXCCMKTEEO(object[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object[] PEFFYZGDTUL(object[] a, ParameterInfo[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface PNZGNGABSLX
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<bool> QVGJKKTHXHF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JSYAHNXKGPG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XEXABNAEXWL(object a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YDODHJJBNBB(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IDisposable QSATNWMXTEI();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool QYTHADADKGX();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NELTLASXXHB(StringBuilder a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JNOBISVJTJM(bool a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YOXQBXBVMWJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		NMWOLULISIU CAVGFSGAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool FGMRXODRKSD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool KVOUUGVQXBS
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool YJBGXUVBMVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ZXAOFJZIORO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JBSWEGEPCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool SJGQRTWVLUG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DLFEYYPJBZJ(object a);
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
	public interface NMWOLULISIU : UBUTFHKMXRW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ClientState VHKQTZCUSOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[CanBeNull]
		KGEHLOHZDIF MXGWLWGZCTU
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool ZXAOFJZIORO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[CanBeNull]
		Exception XPXCHWEKYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int QXYBEWMZTEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool VYRFQJLORHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string, long> ERRQXASZPRL;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ClientState, ClientState> HFCOERJPGDP;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface WYCBYIUFMBN
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string, long> ERRQXASZPRL;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<XQAWTLZFHQF> TYXPSASLVYK;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x861FDF0", Offset = "0x861EBF0", VA = "0x18861FDF0", Slot = "4")]
		bool VJXINGPMQSM(NetworkEventCode a, object b, BFNGJDNRMXE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool VJXINGPMQSM(byte a, object b, BFNGJDNRMXE c, RRNetworkDelivery d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface NJOAPPRHACM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		VPDKWOIWOKH FPSVGSDUQWG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int JIIFABEYYSO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int XRZBBCWRXLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		VPDKWOIWOKH XJNTGLSKVAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int ELAWKGOOFXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string VIGTCHTUOMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Func<string, string> ZESILIZXVHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<VPDKWOIWOKH> BJBUFDNFZJP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QCVLGNILOCV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[CanBeNull]
		VPDKWOIWOKH BFGOGTNAATT(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[CanBeNull]
		VPDKWOIWOKH LENIFIEQFVN(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		VPDKWOIWOKH QPDZYZVUJCF(int a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<VPDKWOIWOKH> TCQTZIVDCKB(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<VPDKWOIWOKH> SLXIJYMWBGS(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool HKYKTRWNBPL(VPDKWOIWOKH a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface TXBATSGEESM
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action LEFJQERGJVQ;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HDAUYQNSRWD();
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UBUTFHKMXRW
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		XLEOHGCTFCX AXWNTMOWDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XWBILNNSBSV
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string OBLVSIZHUAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		long SBOEJWJVIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long NFZYKYPTHHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JQNIPVFSGWY();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface OLPMYWFCPDT : YOXQBXBVMWJ, PNZGNGABSLX, WYCBYIUFMBN, NJOAPPRHACM, TXBATSGEESM, UBUTFHKMXRW, XWBILNNSBSV
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		float HFQUATRYBVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int FVMYAJFTKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int OHVMEOMTZFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		int CZTWRHSAPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int OVZWFRYPUGH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float JGOJVPVHQDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float DHUYSBKQZZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool ZWFYNGQPKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		double GHQGUQBAJXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int PKBGQGHWHZL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool KLLVSIWGTUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "26")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action RZBUDLHTYUY;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float LRGJOQXKJBA(bool a, int b = 1);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EQFSPYQIINX();

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BIFNCNESWEB();

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WICYVNMTDQJ();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SOVUYAYOTUY(List<object> a, int b);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OPJWRULYLHS(int a, object b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GPCGKAPLBWJ(object a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void XAPNKGCZBKG();

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void WELRDNCWWHR();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FWJKRSTFZWO();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ZLPVCWRAQLQ(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "18")]
		object Deserialize(NativeArray<byte> data);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int KQLKIVAPQVG(XQAWTLZFHQF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NREMRRGPTYQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string WMOAMTEWGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Vector3 IIYQCROBXLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Quaternion LPLELFIJVOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Vector3 ZMJUOEPVXPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int IXGPZMQMAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CreationInstantiationParameters NLSDOCJQZKB;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x861EAA0", Offset = "0x861D8A0", VA = "0x18861EAA0")]
		public object[] CVXGVBLTWFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NREMRRGPTYQ()
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
	public class XLEOHGCTFCX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public OPVLFDQAAOV<XQAWTLZFHQF> PWGQWIEAIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OPFQNJIHYGU<XQAWTLZFHQF, BFNGJDNRMXE> FWHCJVZJGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public KMRHHFCXZOG OFONJDLWTFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KMRHHFCXZOG FBZPIMXFMSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OPVLFDQAAOV<DisconnectCause> JDOUZMXFREL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KMRHHFCXZOG LKKGYEDTTXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public OPVLFDQAAOV<string> CMJHLIXVTJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OPVLFDQAAOV<Dictionary<string, object>> FTBNIBXVZIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OPVLFDQAAOV<DisconnectCause> FMWGUPJEBYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OPFQNJIHYGU<bool, bool> KRRHSWTVBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KMRHHFCXZOG IYTXYIFZQGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KMRHHFCXZOG HVUJKPUPIQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KMRHHFCXZOG BLABCKTMVOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KMRHHFCXZOG XEDGFZYFIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KMRHHFCXZOG XYYWTRBBKXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OPVLFDQAAOV<VPDKWOIWOKH> AAVEPJHXLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OPFQNJIHYGU<short, string> UPJIJBWCEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OPVLFDQAAOV<IDictionary<object, object>> NLNVWDYVDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OPFQNJIHYGU<short, string> VEZMWZTAOZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KMRHHFCXZOG WJMFDTJNHVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public OPVLFDQAAOV<VPDKWOIWOKH> TXZHHLKMBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OPVLFDQAAOV<VPDKWOIWOKH> IVMPMTJVXNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OPVLFDQAAOV<VPDKWOIWOKH> VPQVMBWTFRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OPFQNJIHYGU<VPDKWOIWOKH, IDictionary<object, object>> GWDLFVQCWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public KMRHHFCXZOG GXGIJXJZOUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KMRHHFCXZOG DSCBVGYUQFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OPVLFDQAAOV<DisconnectCause> SJMHOXSOEXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OPVLFDQAAOV<DisconnectCause> WHOTNMSTFLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OPVLFDQAAOV<DisconnectCause> GNPFLSLBZHH;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x861FED0", Offset = "0x861ECD0", VA = "0x18861FED0")]
		public XLEOHGCTFCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class JIUIZBNOZDT
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class HMCUTEUDILM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly JIUIZBNOZDT IOXHUKLSSBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private bool BRKISHTLOGT;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x861D200", Offset = "0x861C000", VA = "0x18861D200")]
			public HMCUTEUDILM(JIUIZBNOZDT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x861D100", Offset = "0x861BF00", VA = "0x18861D100", Slot = "1")]
			~HMCUTEUDILM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x861D070", Offset = "0x861BE70", VA = "0x18861D070", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x861D1A0", Offset = "0x861BFA0", VA = "0x18861D1A0")]
			private void UOTXAMRPRSM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly object OQBYJPNELTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly object SYRRZBSPPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float QXOZYGVYZHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float IFHDAOMEQDE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public abstract bool JBSWEGEPCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public abstract float HFQUATRYBVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float JGOJVPVHQDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB1F710", Offset = "0xB1E510", VA = "0x180B1F710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x861D400", Offset = "0x861C200", VA = "0x18861D400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float DHUYSBKQZZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB27C60", Offset = "0xB26A60", VA = "0x180B27C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x861E5F0", Offset = "0x861D3F0", VA = "0x18861E5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract NMWOLULISIU CAVGFSGAPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private ZCWEIRQKNNA TOHBQPXJEZP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private ZCWEIRQKNNA GIEHWVULKUV
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private PUANTRCQHKC<Func<float>> YUGBLLPXVWR
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private bool IONYIXYJIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x23AAC90", Offset = "0x23A9A90", VA = "0x1823AAC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<string, long> ERRQXASZPRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x861D440", Offset = "0x861C240", VA = "0x18861D440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x861D600", Offset = "0x861C400", VA = "0x18861D600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> QVGJKKTHXHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x861E240", Offset = "0x861D040", VA = "0x18861E240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x861D4B0", Offset = "0x861C2B0", VA = "0x18861D4B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action RZBUDLHTYUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x861DC30", Offset = "0x861CA30", VA = "0x18861DC30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x861DB00", Offset = "0x861C900", VA = "0x18861DB00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action LEFJQERGJVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x861E630", Offset = "0x861D430", VA = "0x18861E630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x861D560", Offset = "0x861C360", VA = "0x18861D560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BIFNCNESWEB();

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x861E6D0", Offset = "0x861D4D0", VA = "0x18861E6D0")]
		protected JIUIZBNOZDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x861D7C0", Offset = "0x861C5C0", VA = "0x18861D7C0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x861E420", Offset = "0x861D220", VA = "0x18861E420")]
		public void YDODHJJBNBB(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x861DA00", Offset = "0x861C800", VA = "0x18861DA00")]
		public void JSYAHNXKGPG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x861E3E0", Offset = "0x861D1E0", VA = "0x18861E3E0")]
		public void XEXABNAEXWL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x861E160", Offset = "0x861CF60", VA = "0x18861E160")]
		public IDisposable QSATNWMXTEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x861D7E0", Offset = "0x861C5E0", VA = "0x18861D7E0", Slot = "10")]
		public virtual bool JNOBISVJTJM(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x861D260", Offset = "0x861C060", VA = "0x18861D260")]
		private bool ARCSGTRTMFZ([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x861DCD0", Offset = "0x861CAD0", VA = "0x18861DCD0")]
		private bool LOHETSNCUDO([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x861E1F0", Offset = "0x861CFF0", VA = "0x18861E1F0")]
		public bool QYTHADADKGX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x861DD60", Offset = "0x861CB60", VA = "0x18861DD60")]
		public void NELTLASXXHB(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x861DFC0", Offset = "0x861CDC0", VA = "0x18861DFC0")]
		private void QFSSOSRUPSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x861DBA0", Offset = "0x861C9A0", VA = "0x18861DBA0")]
		private void LGGGNVYYFXG(Func<float> a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x861D760", Offset = "0x861C560", VA = "0x18861D760")]
		public void IWPSKBQIOOQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x861E350", Offset = "0x861D150", VA = "0x18861E350")]
		public void XAPNKGCZBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x861E2F0", Offset = "0x861D0F0", VA = "0x18861E2F0")]
		public void WELRDNCWWHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x861D6C0", Offset = "0x861C4C0", VA = "0x18861D6C0")]
		private void HIDXIVHUUMR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB27C60", Offset = "0xB26A60", VA = "0x180B27C60")]
		private float TWLKRDLEGEL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB1F710", Offset = "0xB1E510", VA = "0x180B1F710")]
		private float AJCKEULGFJY()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x861E540", Offset = "0x861D340", VA = "0x18861E540")]
		private void YIWOQKODVMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x861D670", Offset = "0x861C470", VA = "0x18861D670")]
		public void HDAUYQNSRWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class JLHVJJRMRNJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string ETTNISRHEQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool WKRGRGRRGTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected internal bool KHJSJQIEQGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected internal int DMLJZLNFPRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected internal byte[] GXEYNHGRSCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected internal byte SMRIWUIPGUF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly System.Random ALIMCTIOUUH;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x861E8B0", Offset = "0x861D6B0", VA = "0x18861E8B0", Slot = "5")]
		public virtual bool GNQIZKAPMKA(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x861E870", Offset = "0x861D670", VA = "0x18861E870", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x861E830", Offset = "0x861D630", VA = "0x18861E830", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x861E8F0", Offset = "0x861D6F0", VA = "0x18861E8F0")]
		protected internal void NRKVJJKJWDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x861E9F0", Offset = "0x861D7F0", VA = "0x18861E9F0")]
		protected JLHVJJRMRNJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class OWZVOMHLQHE : JLHVJJRMRNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Socket TJLDXZLUPYE;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x861EE00", Offset = "0x861DC00", VA = "0x18861EE00", Slot = "5")]
		public override bool GNQIZKAPMKA(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x861EC20", Offset = "0x861DA20", VA = "0x18861EC20", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x861EBD0", Offset = "0x861D9D0", VA = "0x18861EBD0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x861F080", Offset = "0x861DE80", VA = "0x18861F080")]
		public OWZVOMHLQHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class SOWVCOOLILE
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string JRVMTAFMXQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string TXMBJDFXTJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string AIIJWVWQUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int SPTLEQVNWEI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAD3A90", Offset = "0xAD2890", VA = "0x180AD3A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x861FCD0", Offset = "0x861EAD0", VA = "0x18861FCD0")]
		public SOWVCOOLILE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x861FA30", Offset = "0x861E830", VA = "0x18861FA30")]
		private void OOFNKLEBOXS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x861FB40", Offset = "0x861E940", VA = "0x18861FB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x861FBF0", Offset = "0x861E9F0", VA = "0x18861FBF0")]
		public string ToString(bool compact = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PFKYRIJOHFT
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static int PILWOANHANM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static bool PQZRYLCSIPN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static int HORPOLPRJOD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static int LKXYCGUHKGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private SOWVCOOLILE EPVVCOYZRGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string SJXQNKITDWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int IVVTPATGGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int WSPTXXVPBVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Action<SOWVCOOLILE> YFFTFJIXNGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private JLHVJJRMRNJ ZPVLWTTVBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<int> TIUOZDATSZS;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool SSDWACUPITS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB5E570", Offset = "0xB5D370", VA = "0x180B5E570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB5E580", Offset = "0xB5D380", VA = "0x180B5E580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x861F980", Offset = "0x861E780", VA = "0x18861F980")]
		public PFKYRIJOHFT(SOWVCOOLILE a, Action<SOWVCOOLILE> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x861F5B0", Offset = "0x861E3B0", VA = "0x18861F5B0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x861F160", Offset = "0x861DF60", VA = "0x18861F160")]
		public static string HKUUHIUMZLU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x861F5A0", Offset = "0x861E3A0", VA = "0x18861F5A0")]
		protected internal void STACOVRVGED(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x861F2D0", Offset = "0x861E0D0", VA = "0x18861F2D0")]
		protected internal bool NUSGYRGVDCV()
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
