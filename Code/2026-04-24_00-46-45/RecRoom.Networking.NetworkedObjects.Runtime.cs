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
	public interface TLNYEWXUWJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SXLOMBZSFQX(Type a, Type b);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object[] MGGCRSKHCHK(object[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object[] XFNQCZXHXZT(object[] a, ParameterInfo[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface OVUDHFSVZRB
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<bool> APLDAFRMQEV;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VCAFYOPHPLM(object a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ONRJPIAEEZP(object a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OKDEVSBNZER(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IDisposable ZPCVZNJGWPU();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JIKJXUHEVCR();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DKGWDHIKBCF(StringBuilder a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OLQSPBNMLRS(bool a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YRPMRISBKYH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		MBQGRUSTSMG HVFSCIYSEVL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool QQRCZTPFXJT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool LIKRKGEZCXY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool NIENSSSWZOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool MHRLKDKFJFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CWUQNUAQLNK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Disconnect();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CJSGBGRNYOJ(object a);
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
	public interface MBQGRUSTSMG : IIPEJBWGEEG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ClientState BRKXBFWXXDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[CanBeNull]
		IPBRLYOLLKP IQUODMNVGQA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[CanBeNull]
		Exception JVGADPCADZV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int NGXSHPBPAZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool TDVIXFHHCQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string, long> KKXLLNVMPWX;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<ClientState, ClientState> KTPKXQEJUPV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface UKZZMHQCVUV
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<string, long> KKXLLNVMPWX;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<EPOORIVUAQX> RORSLVKDMWI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8E60", Offset = "0x9AC7860", VA = "0x189AC8E60", Slot = "4")]
		bool UNRAXFIHVPM(NetworkEventCode a, object b, CBEOKZVPQNC c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UNRAXFIHVPM(byte a, object b, CBEOKZVPQNC c, RRNetworkDelivery d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface MHGHLMUDRDA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int ASBNOAGXZWU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int YYNMKBWUOFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		KDSOOWCXYNX DUOYZNQYDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int HJYMWYSJKZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string ZPTLXARQHRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Func<string, string> HLHSFRELYDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<KDSOOWCXYNX> NGUPMDHOFVZ;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XEHMGHSTIXN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[CanBeNull]
		KDSOOWCXYNX XAAYHUMVZMX(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[CanBeNull]
		KDSOOWCXYNX BRTYMRMESFT(int a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		KDSOOWCXYNX WGNWTBDNSVF(int a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<KDSOOWCXYNX> MZFIPIOGGNB(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<KDSOOWCXYNX> TUMWMCJPUGI(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool RDQCPBLTDHR(KDSOOWCXYNX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface KQABBQLSHCW
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action IKJTVBUTQAY;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MJCXUVNHEKJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IIPEJBWGEEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ALKDGZAAFQB USEWHVWKZZN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface OTYHDSTJRSP
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string URTSTMCGUSD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		long SOVOAOQMNNY
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		long LQZYSRGQDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PCGTYUOJXFM();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface GXLSEMXVYCP : YRPMRISBKYH, OVUDHFSVZRB, UKZZMHQCVUV, MHGHLMUDRDA, KQABBQLSHCW, IIPEJBWGEEG, OTYHDSTJRSP
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		float ATVZYPZCQHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int HCAAXHXVIGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ETQSHMXPUGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		int SXPHRTFQALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int GRJBIWSAUJT
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float OUSVAUIPMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float GIOIIFXUVJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool POMPKSSGJRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		double QKEZKBPMOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int VBVCSSKGYYH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool NQNCGBDWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "26")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action PGLIHSJELYO;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float MIIAHZRXNCI(bool a, int b = 1);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CCOQBHMCJAT();

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DYIVQXTDRGP();

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EEISTHFQUKH();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NKSAWRSTASC(List<object> a, int b);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void IPFJYEMGWPE(int a, object b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MTEGJMGQCTN(object a, int b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RODYEKNJPHO();

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void MSECPSXIJHT();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void KCVBXOSSSDS();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void NZJDRENIZKU(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "18")]
		object Deserialize(NativeArray<byte> data);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "19")]
		int MNTKOONLCOG(EPOORIVUAQX a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DYUPRJOGCEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string IMQUJZVTZBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Vector3 XTMYEBRZEWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Quaternion MNYYIPRVPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Vector3 OHFXQNDZZMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int KKOXFBNDMNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CreationInstantiationParameters EPSOZMEJDKD;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6330", Offset = "0x9AC4D30", VA = "0x189AC6330")]
		public object[] AUSBRSUPZJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DYUPRJOGCEW()
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
	public class ALKDGZAAFQB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public VEFRPOSZNGH<EPOORIVUAQX> DLQGUEWZEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public VEKYMVMWWRQ<EPOORIVUAQX, CBEOKZVPQNC> MJQAWDZPCAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public JOLHGBMRDLK UILYAIANEQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public JOLHGBMRDLK SPIRBDZYICY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public VEFRPOSZNGH<DisconnectCause> SWIDLBQBKCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JOLHGBMRDLK FHQGNVZJSKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public VEFRPOSZNGH<string> SMKDULJJVHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public VEFRPOSZNGH<Dictionary<string, object>> WPBQPDPCVQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public VEFRPOSZNGH<DisconnectCause> BPCIXIYHOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public VEKYMVMWWRQ<bool, bool> IPZLYWYVFRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JOLHGBMRDLK GCFYIZYTGRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JOLHGBMRDLK SOKOTRPRPVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public JOLHGBMRDLK FLSJHALDVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public JOLHGBMRDLK PCXBRAOXELZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public JOLHGBMRDLK XGRMUGZRFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public VEFRPOSZNGH<KDSOOWCXYNX> CTDQSQOWNWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public VEKYMVMWWRQ<short, string> SALUKBIKNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public VEFRPOSZNGH<IDictionary<object, object>> GVITIOVFGWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public VEKYMVMWWRQ<short, string> IUANJIHIWNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public JOLHGBMRDLK OMTMZJIHRXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public VEFRPOSZNGH<KDSOOWCXYNX> GPGGCUNLRZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public VEFRPOSZNGH<KDSOOWCXYNX> ODATWBQXKEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public VEFRPOSZNGH<KDSOOWCXYNX> BHDJONTOSQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public VEKYMVMWWRQ<KDSOOWCXYNX, IDictionary<object, object>> VKLUGPUXYLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JOLHGBMRDLK HNWBCKCEFHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JOLHGBMRDLK CJXSENEAPVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public VEFRPOSZNGH<DisconnectCause> YJBMLDDNRDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public VEFRPOSZNGH<DisconnectCause> THQILJSVMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public VEFRPOSZNGH<DisconnectCause> KICKGQVBSUD;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5C00", Offset = "0x9AC4600", VA = "0x189AC5C00")]
		public ALKDGZAAFQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class NNENUQXQVWX
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class FZXZWFYKTWU : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly NNENUQXQVWX CLSEPWFIRIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private bool JHVCKNKMFHD;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6B90", Offset = "0x9AC5590", VA = "0x189AC6B90")]
			public FZXZWFYKTWU(NNENUQXQVWX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6AF0", Offset = "0x9AC54F0", VA = "0x189AC6AF0", Slot = "1")]
			~FZXZWFYKTWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6A00", Offset = "0x9AC5400", VA = "0x189AC6A00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6A90", Offset = "0x9AC5490", VA = "0x189AC6A90")]
			private void FZZVURSNXUC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly object HRBHSBLBOSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly object AOGOHNTXVFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float RBWNUJWIHJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private float KBTVCCTXJJC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public abstract bool MHRLKDKFJFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public abstract float ATVZYPZCQHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float OUSVAUIPMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD68AE0", Offset = "0xD674E0", VA = "0x180D68AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6FB0", Offset = "0x9AC59B0", VA = "0x189AC6FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float GIOIIFXUVJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD67C20", Offset = "0xD66620", VA = "0x180D67C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7440", Offset = "0x9AC5E40", VA = "0x189AC7440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public abstract MBQGRUSTSMG HVFSCIYSEVL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private HFGUPORPTXK YTVMAUFZZAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private HFGUPORPTXK OLJIIWLFOQP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private QXQDNGXEBQE<Func<float>> XJEQOZMXXID
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private bool QYFKBTAKCWU
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x261DE10", Offset = "0x261C810", VA = "0x18261DE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<string, long> KKXLLNVMPWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7C80", Offset = "0x9AC6680", VA = "0x189AC7C80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AC74F0", Offset = "0x9AC5EF0", VA = "0x189AC74F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> APLDAFRMQEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7EB0", Offset = "0x9AC68B0", VA = "0x189AC7EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7850", Offset = "0x9AC6250", VA = "0x189AC7850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action PGLIHSJELYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9AC77B0", Offset = "0x9AC61B0", VA = "0x189AC77B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9AC8300", Offset = "0x9AC6D00", VA = "0x189AC8300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action IKJTVBUTQAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7E10", Offset = "0x9AC6810", VA = "0x189AC7E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7F60", Offset = "0x9AC6960", VA = "0x189AC7F60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DYIVQXTDRGP();

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8430", Offset = "0x9AC6E30", VA = "0x189AC8430")]
		protected NNENUQXQVWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7480", Offset = "0x9AC5E80", VA = "0x189AC7480")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7900", Offset = "0x9AC6300", VA = "0x189AC7900")]
		public void OKDEVSBNZER(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8000", Offset = "0x9AC6A00", VA = "0x189AC8000")]
		public void VCAFYOPHPLM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7C40", Offset = "0x9AC6640", VA = "0x189AC7C40")]
		public void ONRJPIAEEZP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9AC83A0", Offset = "0x9AC6DA0", VA = "0x189AC83A0")]
		public IDisposable ZPCVZNJGWPU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7A20", Offset = "0x9AC6420", VA = "0x189AC7A20", Slot = "10")]
		public virtual bool OLQSPBNMLRS(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7560", Offset = "0x9AC5F60", VA = "0x189AC7560")]
		private bool MIUDZZIHFHT([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7CF0", Offset = "0x9AC66F0", VA = "0x189AC7CF0")]
		private bool RJCFUDDVGOG([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC74A0", Offset = "0x9AC5EA0", VA = "0x189AC74A0")]
		public bool JIKJXUHEVCR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7080", Offset = "0x9AC5A80", VA = "0x189AC7080")]
		public void DKGWDHIKBCF(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8100", Offset = "0x9AC6B00", VA = "0x189AC8100")]
		private void VDTMCOSSWZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6FF0", Offset = "0x9AC59F0", VA = "0x189AC6FF0")]
		private void BWUVBBLYDPQ(Func<float> a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9AC82A0", Offset = "0x9AC6CA0", VA = "0x189AC82A0")]
		public void XPGPEUCMRVU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7D80", Offset = "0x9AC6780", VA = "0x189AC7D80")]
		public void RODYEKNJPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7750", Offset = "0x9AC6150", VA = "0x189AC7750")]
		public void MSECPSXIJHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9AC72F0", Offset = "0x9AC5CF0", VA = "0x189AC72F0")]
		private void EYLKYWKIREH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD67C20", Offset = "0xD66620", VA = "0x180D67C20")]
		private float IYNNTUBSJFH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD68AE0", Offset = "0xD674E0", VA = "0x180D68AE0")]
		private float PPJZOHXFRWI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7390", Offset = "0x9AC5D90", VA = "0x189AC7390")]
		private void FLLAHNLCJPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7700", Offset = "0x9AC6100", VA = "0x189AC7700")]
		public void MJCXUVNHEKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class ZPXSTIJFYJH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string HSLTFEZNEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool GBKKSDAORPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected internal bool JPPQADVIBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected internal int XNKLKAISHTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected internal byte[] FVOALFZNHSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected internal byte TGWTSUOAFKD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly System.Random JHYZXRBFJLP;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9040", Offset = "0x9AC7A40", VA = "0x189AC9040", Slot = "5")]
		public virtual bool XFXSQEHDVTM(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8F80", Offset = "0x9AC7980", VA = "0x189AC8F80", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8F40", Offset = "0x9AC7940", VA = "0x189AC8F40", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8FC0", Offset = "0x9AC79C0", VA = "0x189AC8FC0")]
		protected internal void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9100", Offset = "0x9AC7B00", VA = "0x189AC9100")]
		protected ZPXSTIJFYJH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class EFHTECQCSMQ : ZPXSTIJFYJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Socket ZCKYORKVYZM;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9AC66A0", Offset = "0x9AC50A0", VA = "0x189AC66A0", Slot = "5")]
		public override bool XFXSQEHDVTM(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9AC64C0", Offset = "0x9AC4EC0", VA = "0x189AC64C0", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6470", Offset = "0x9AC4E70", VA = "0x189AC6470", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6920", Offset = "0x9AC5320", VA = "0x189AC6920")]
		public EFHTECQCSMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class IUEGYBSSIRW
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string OMUTIOYQJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string PLIMKLJSJFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string DJZSGQRVUCW
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int HWSGRRKOMCS
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD1BA20", Offset = "0xD1A420", VA = "0x180D1BA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E90", Offset = "0x9AC5890", VA = "0x189AC6E90")]
		public IUEGYBSSIRW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6BF0", Offset = "0x9AC55F0", VA = "0x189AC6BF0")]
		private void PJFRSXERRJA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6D00", Offset = "0x9AC5700", VA = "0x189AC6D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6DB0", Offset = "0x9AC57B0", VA = "0x189AC6DB0")]
		public string ToString(bool compact = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PEFGGOXOIGX
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static int DFJPJJXAVEM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static bool UDSCUKTAOLX;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static int QEHRFCFGLOB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static int MYJTMJVMDYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IUEGYBSSIRW MCBDFBXTVOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string XBYOFPSKLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int PHGINMWXKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int TEXAQLVZNYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Action<IUEGYBSSIRW> XWBFGDCFITN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ZPXSTIJFYJH WELWXCEIFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<int> OHIRGORURTA;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PQICWMXHYQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xDA45E0", Offset = "0xDA2FE0", VA = "0x180DA45E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8DB0", Offset = "0x9AC77B0", VA = "0x189AC8DB0")]
		public PEFGGOXOIGX(IUEGYBSSIRW a, Action<IUEGYBSSIRW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9AC89D0", Offset = "0x9AC73D0", VA = "0x189AC89D0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8590", Offset = "0x9AC6F90", VA = "0x189AC8590")]
		public static string KHABIXWMXCI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8D20", Offset = "0x9AC7720", VA = "0x189AC8D20")]
		protected internal void ZNWYSGSLNFT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8700", Offset = "0x9AC7100", VA = "0x189AC8700")]
		protected internal bool QIZQJAJGLYL()
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
