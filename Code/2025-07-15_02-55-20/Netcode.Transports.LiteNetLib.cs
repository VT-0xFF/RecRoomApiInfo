using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JKLLNGCGDEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DCPDNONNLCB
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Client
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Tooltip("The port to listen on (if server) or connect to (if client)")]
		public ushort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("The address to connect to as client; ignored if server")]
		public string Address;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Tooltip("Interval between ping packets used for detecting latency and checking connection, in seconds")]
		public float PingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Tooltip("Maximum duration for a connection to survive without receiving packets, in seconds")]
		public float DisconnectTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Delay between connection attempts, in seconds")]
		public float ReconnectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Tooltip("Maximum connection attempts before client stops and reports a disconnection")]
		public int MaxConnectAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Tooltip("Size of default buffer for decoding incoming packets, in bytes")]
		public int MessageBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Tooltip("Simulated chance for a packet to be \"lost\", from 0 (no simulation) to 100 percent")]
		public int SimulatePacketLossChance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Tooltip("Simulated minimum additional latency for packets in milliseconds (0 for no simulation)")]
		public int SimulateMinLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Tooltip("Simulated maximum additional latency for packets in milliseconds (0 for no simulation")]
		public int SimulateMaxLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NetworkManager FLGEEOEDEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool OLCDIACPFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, EHJDCPEOLPB> BEGCHIJACDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LENLHPOGELP EJLCOKFPPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch EMDFIOJDNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] GFDPIFGOEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DCPDNONNLCB BJNFJMDHMEN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LIIBIPBEHHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x72F2760", Offset = "0x72F1360", VA = "0x1872F2760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong KBJAHBFJCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool FHGACLBGEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x72F2740", Offset = "0x72F1340", VA = "0x1872F2740", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72F1D30", Offset = "0x72F0930", VA = "0x1872F1D30")]
		public void RecRoom_SetEncryptionInfo(ulong EAEHOLHBAMA, byte[] DHCHBFGMFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72F1D10", Offset = "0x72F0910", VA = "0x1872F1D10")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72F1B10", Offset = "0x72F0710", VA = "0x1872F1B10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72F2640", Offset = "0x72F1240", VA = "0x1872F2640")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72F1E50", Offset = "0x72F0A50", VA = "0x1872F1E50", Slot = "6")]
		public override void Send(ulong DNMDEMHKFBL, ArraySegment<byte> CBCNBAPLLJM, NetworkDelivery INKBHAKGFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72F1CD0", Offset = "0x72F08D0", VA = "0x1872F1CD0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong DNMDEMHKFBL, [Out] ArraySegment<byte> HGBKIACHBFM, [Out] float BLFBCINHIHJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72F2140", Offset = "0x72F0D40", VA = "0x1872F2140", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72F2460", Offset = "0x72F1060", VA = "0x1872F2460", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72F12E0", Offset = "0x72EFEE0", VA = "0x1872F12E0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong DNMDEMHKFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72F11F0", Offset = "0x72EFDF0", VA = "0x1872F11F0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72F14E0", Offset = "0x72F00E0", VA = "0x1872F14E0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong DNMDEMHKFBL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72F20D0", Offset = "0x72F0CD0", VA = "0x1872F20D0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72F15E0", Offset = "0x72F01E0", VA = "0x1872F15E0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager FLGEEOEDEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72F1C00", Offset = "0x72F0800", VA = "0x1872F1C00")]
		private ODEFHFNLPFJ PIBJEEHLJJC(NetworkDelivery MDCDODCGNEK)
		{
			return default(ODEFHFNLPFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72F1A50", Offset = "0x72F0650", VA = "0x1872F1A50", Slot = "16")]
		private void MNPFBNCHNFA(EHJDCPEOLPB CJMDLLLLCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72F13F0", Offset = "0x72EFFF0", VA = "0x1872F13F0", Slot = "17")]
		private void EGEKIOHAKPC(EHJDCPEOLPB CJMDLLLLCJC, IBIJNAKKJLE EGANIBHILOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "18")]
		private void JAKNJEDLCHE(IPEndPoint FAGBGHMGAGM, SocketError NGADKOGGGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72F17F0", Offset = "0x72F03F0", VA = "0x1872F17F0", Slot = "19")]
		private void KJPGHILNNCG(EHJDCPEOLPB CJMDLLLLCJC, PFAKCKHICJF NOIAIJBDKGG, byte NCDHHICKMEH, ODEFHFNLPFJ BIKDOIKIEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72F1110", Offset = "0x72EFD10", VA = "0x1872F1110")]
		private void DNLLIHKEJCD(int PFHGPMHBODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "20")]
		private void HIHONIEJHOM(IPEndPoint BBAJNEGBECM, PFAKCKHICJF NOIAIJBDKGG, KCCGELHLLOA COFHLKAKKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "21")]
		private void PFLJKBGOBPA(EHJDCPEOLPB CJMDLLLLCJC, int MGGNGJOFOKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72F1580", Offset = "0x72F0180", VA = "0x1872F1580", Slot = "22")]
		private void ILOEMNLDDFJ(MHKMICAPHEF HPBJFJONIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72F1A00", Offset = "0x72F0600", VA = "0x1872F1A00")]
		private ulong MMHLFFEFEDL(EHJDCPEOLPB CJMDLLLLCJC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72F1A30", Offset = "0x72F0630", VA = "0x1872F1A30")]
		private ulong MMHLFFEFEDL(ulong DNMDEMHKFBL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72F14C0", Offset = "0x72F00C0", VA = "0x1872F14C0")]
		private static int FGFJOAHGGEA(float DJMONOPAJCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72F2660", Offset = "0x72F1260", VA = "0x1872F2660")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72F10E0", Offset = "0x72EFCE0", VA = "0x1872F10E0")]
		[CompilerGenerated]
		private void BOMEEOEIHOF(ulong NICIBBIBJBB, int AIBJBMIJKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72F10E0", Offset = "0x72EFCE0", VA = "0x1872F10E0")]
		[CompilerGenerated]
		private void BLMGHNKLNBF(ulong NICIBBIBJBB, int AIBJBMIJKLL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class DIFMMHENBKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly EHJDCPEOLPB OCNGKFHBDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<CDIJOLAENCA> OFFPMGMPOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int OLIGHKJDEEF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KDCGHJCGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72E1000", Offset = "0x72DFC00", VA = "0x1872E1000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72E1050", Offset = "0x72DFC50", VA = "0x1872E1050")]
	protected DIFMMHENBKI(EHJDCPEOLPB CJMDLLLLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F60", Offset = "0x72DFB60", VA = "0x1872E0F60")]
	public void BGNMGNAEPIO(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72E0EE0", Offset = "0x72DFAE0", VA = "0x1872E0EE0")]
	protected void AJKHMAGKBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72E0FC0", Offset = "0x72DFBC0", VA = "0x1872E0FC0")]
	public bool CBAMLDMHGDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool NJCFLMOPFML();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DPHMDENAJAC(CDIJOLAENCA BDIEGLLGOOG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum BEGCCMKECKC
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MHKMICAPHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LENLHPOGELP IJHOKCELNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int KCJBNOACJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal OKOOIBEKEDA GCONCIDGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint GGIAPNEDONL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal BEGCCMKECKC OPEMLHGCENF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA85600", Offset = "0xA84200", VA = "0x180A85600")]
		[CompilerGenerated]
		get
		{
			return default(BEGCCMKECKC);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE7F020", Offset = "0xE7DC20", VA = "0x180E7F020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72F28F0", Offset = "0x72F14F0", VA = "0x1872F28F0")]
	internal void BMFPBOEHPDE(OKOOIBEKEDA DLBIEIIEFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72F29B0", Offset = "0x72F15B0", VA = "0x1872F29B0")]
	private bool GDADLNNMPHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72F29E0", Offset = "0x72F15E0", VA = "0x1872F29E0")]
	internal MHKMICAPHEF(IPEndPoint BBAJNEGBECM, OKOOIBEKEDA IPEKEGOFIOD, LENLHPOGELP PGCJAKGCANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72F2950", Offset = "0x72F1550", VA = "0x1872F2950")]
	public EHJDCPEOLPB DEBDAKLIION()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KCCGELHLLOA
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IHLIJOGCDHA
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IBIJNAKKJLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public IHLIJOGCDHA IKIPDLHLEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError MFGPIJJBINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PFAKCKHICJF BDFCECMMPEM;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKLLNGCGDEO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOKAKFIHCFE(EHJDCPEOLPB CJMDLLLLCJC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DANOPJHBNDC(EHJDCPEOLPB CJMDLLLLCJC, IBIJNAKKJLE EGANIBHILOO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNNODDBBJBJ(IPEndPoint FAGBGHMGAGM, SocketError NGADKOGGGBL);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFGGELKIHAL(EHJDCPEOLPB CJMDLLLLCJC, PFAKCKHICJF NOIAIJBDKGG, byte NCDHHICKMEH, ODEFHFNLPFJ BIKDOIKIEOG);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DICBJILLNML(IPEndPoint BBAJNEGBECM, PFAKCKHICJF NOIAIJBDKGG, KCCGELHLLOA COFHLKAKKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKIPPPKODEL(EHJDCPEOLPB CJMDLLLLCJC, int MGGNGJOFOKC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLHPNHNGBMA(MHKMICAPHEF HPBJFJONIPC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLEBBEPEIFP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOFPJNNMAPM(EHJDCPEOLPB CJMDLLLLCJC, object BBAEJJFNOAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CEMPPCPHIFI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANKBNJIMFMH(OOLGGJEDPLG BDIEGLLGOOG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PNPHDCECKAO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOMKNGENPCF(EHJDCPEOLPB CJMDLLLLCJC, IPEndPoint LKOHBGGIGLA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OKOOIBEKEDA
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int KMGJNLINECG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long EMJJNADOEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EIMDFDBFOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] AGAGJGNFNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly OKKHGFHCGGE OHABHFNOKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int KJLKPFHMGIC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72F51E0", Offset = "0x72F3DE0", VA = "0x1872F51E0")]
	private OKOOIBEKEDA(long OLPIILGBFHI, byte CGHNCAONFFL, int ILPOHEPFNOO, byte[] IGKHMCHKEAC, OKKHGFHCGGE CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72F5180", Offset = "0x72F3D80", VA = "0x1872F5180")]
	public static int NKPLKEDBAGH(CDIJOLAENCA BDIEGLLGOOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D80", Offset = "0x72F3980", VA = "0x1872F4D80")]
	public static OKOOIBEKEDA FPCPALDJBKC(CDIJOLAENCA BDIEGLLGOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72F4FA0", Offset = "0x72F3BA0", VA = "0x1872F4FA0")]
	public static CDIJOLAENCA MHGNNCNEKOJ(KENBNDKADMN HEHKMPOFJKK, SocketAddress EDDGDBCDCAF, long LAOBANAOOLD, int ILPOHEPFNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class AGKEPFOOFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long EMJJNADOEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte EIMDFDBFOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int KJLKPFHMGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool MJFFFLLJILN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72DF3B0", Offset = "0x72DDFB0", VA = "0x1872DF3B0")]
	private AGKEPFOOFOL(long OLPIILGBFHI, byte CGHNCAONFFL, int NOLMLKIPOPA, bool OGHIAFHFKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72DF070", Offset = "0x72DDC70", VA = "0x1872DF070")]
	public static AGKEPFOOFOL FPCPALDJBKC(CDIJOLAENCA BDIEGLLGOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72DF2C0", Offset = "0x72DDEC0", VA = "0x1872DF2C0")]
	public static CDIJOLAENCA MHGNNCNEKOJ(long LAOBANAOOLD, byte JHOGPMAIGLH, int MLLGAOJNDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72DF1C0", Offset = "0x72DDDC0", VA = "0x1872DF1C0")]
	public static CDIJOLAENCA GOOAKHPLBCE(EHJDCPEOLPB CJMDLLLLCJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum FFFEMDPDJMO
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KLKODCECBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDPMCOKPJCP(IPEndPoint AMAJOEMEPLK, IPEndPoint BBAJNEGBECM, string DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDLBDAPDNOO(IPEndPoint FDLDIIMODMN, FFFEMDPDJMO MDCDODCGNEK, string DANCOEFIHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PJMJEHPAPLH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct EEAOFHCNPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint OIEBGAMGEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint GGIAPNEDONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string EALJMBJMFLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct EGIKNEBOGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint LLHOOBJJJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FFFEMDPDJMO GJCIAOMMHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string EALJMBJMFLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class DCOONNILPDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint LCNFEJLKOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string EALJMBJMFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DCOONNILPDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MICKINKOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint LCNFEJLKOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint MBCGBOBHPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EALJMBJMFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MICKINKOEPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class BMHNMJPCEKC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string EALJMBJMFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CGPDCBFOLJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BMHNMJPCEKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LENLHPOGELP HDOJBGFJKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<EEAOFHCNPAO> DMODDCFGOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<EGIKNEBOGBP> MMIENOFGKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly OKKHGFHCGGE FPIBBIPLIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KENBNDKADMN NLFKCLPBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NGCMNOBLNEP DKFOEHJDMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private KLKODCECBLD AKKCDFDMAJP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int PKNMJOGGPHH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool MAAAHEGNOKE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72F6D70", Offset = "0x72F5970", VA = "0x1872F6D70")]
	internal PJMJEHPAPLH(LENLHPOGELP NJPJMMCBKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72F6A60", Offset = "0x72F5660", VA = "0x1872F6A60")]
	internal void FMNOCEOGMLF(IPEndPoint OHPKJMHBIBA, CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E16EB0", Offset = "0x3E15AB0", VA = "0x183E16EB0")]
	private void BDGMCGKPGAG<T>(T BDIEGLLGOOG, IPEndPoint ADGCHNLKFKK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72F6BE0", Offset = "0x72F57E0", VA = "0x1872F6BE0")]
	private void GDPMCOKPJCP(DCOONNILPDF PAOIHJLBMGE, IPEndPoint OHPKJMHBIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72F6900", Offset = "0x72F5500", VA = "0x1872F6900")]
	private void CGLAMNDNFAF(MICKINKOEPH PAOIHJLBMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72F6760", Offset = "0x72F5360", VA = "0x1872F6760")]
	private void ADOGENOCLKK(BMHNMJPCEKC PAOIHJLBMGE, IPEndPoint OHPKJMHBIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum ODEFHFNLPFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CDAPJPGEJMA : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KBOMNHOEDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] JAHHAMICDPC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int NONNNOPEONA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int MDFDEPMNNKF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DNALEJHFHBE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DF270", VA = "0x1872E0670")]
	public DNALEJHFHBE(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CGMCKKBBJPM : DNALEJHFHBE
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DF270", VA = "0x1872E0670")]
	public CGMCKKBBJPM(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GKKGFDLGKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ABDBPGDCEAM
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCBEEIPOLCP(GKKGFDLGKPI FINOFDAMOCP, string JIBDMFNCFIM, params object[] AHEPAEIEJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GNDNBAFDEBO
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static ABDBPGDCEAM LDNJJPLOFMM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object BOJJKHNBIII;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72E6850", Offset = "0x72E5450", VA = "0x1872E6850")]
	private static void OOJBDCAHJPE(GKKGFDLGKPI EPLJIACICJF, string JIBDMFNCFIM, params object[] AHEPAEIEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72E6A80", Offset = "0x72E5680", VA = "0x1872E6A80")]
	internal static void PGBPHCOFCJM(string JIBDMFNCFIM, params object[] AHEPAEIEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72E67F0", Offset = "0x72E53F0", VA = "0x1872E67F0")]
	internal static void DHMHKHGKHNO(string JIBDMFNCFIM, params object[] AHEPAEIEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72E6AE0", Offset = "0x72E56E0", VA = "0x1872E6AE0")]
	internal static void POBNOECGCPF(string JIBDMFNCFIM, params object[] AHEPAEIEJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum DLBPJDNPOMM
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PFAKCKHICJF : OKKHGFHCGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private CDIJOLAENCA IDICKOGOIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly LENLHPOGELP LKAPCHDCFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JLFJDHBFOOP CMHOELFHFJH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72F6710", Offset = "0x72F5310", VA = "0x1872F6710")]
	internal PFAKCKHICJF(LENLHPOGELP GHKGDJLGKOB, JLFJDHBFOOP DAKAAKLHCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72F6670", Offset = "0x72F5270", VA = "0x1872F6670")]
	internal void EEAMEIMDIKO(CDIJOLAENCA BDIEGLLGOOG, int HEOADPALNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72F65F0", Offset = "0x72F51F0", VA = "0x1872F65F0")]
	internal void EAIJLDEEAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72F66E0", Offset = "0x72F52E0", VA = "0x1872F66E0")]
	public void MNKAEELDLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class JLFJDHBFOOP
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum BEPBJJLOEKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public JLFJDHBFOOP LELGPBLLFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public BEPBJJLOEKP GJCIAOMMHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public EHJDCPEOLPB OCNGKFHBDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint GGIAPNEDONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object BJLGODPGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int KEKPGDJOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError JLKIKJKNKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public IHLIJOGCDHA FJDPPGBFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public MHKMICAPHEF BCCCLFKNNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public ODEFHFNLPFJ FHEIOLAFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte HONBIKLGCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly PFAKCKHICJF KCNFBHKGMKI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72E7FE0", Offset = "0x72E6BE0", VA = "0x1872E7FE0")]
	public JLFJDHBFOOP(LENLHPOGELP GHKGDJLGKOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LENLHPOGELP : IEnumerable<EHJDCPEOLPB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class JNDBHHANCGB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72E8080", Offset = "0x72E6C80", VA = "0x1872E8080", Slot = "4")]
		public bool Equals(IPEndPoint LGCEHLADNJC, IPEndPoint LFHMHCKODDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4488ED0", Offset = "0x4487AD0", VA = "0x184488ED0", Slot = "5")]
		public int GetHashCode(IPEndPoint KOJLNGLNBMH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JNDBHHANCGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct JEHFPNBCAEE : IEnumerator<EHJDCPEOLPB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly EHJDCPEOLPB FHCAODABPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private EHJDCPEOLPB IGECNDLKLBG;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EHJDCPEOLPB ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D80", Offset = "0xAF2980", VA = "0x180AF3D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D80", Offset = "0xAF2980", VA = "0x180AF3D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C414D0", Offset = "0x1C400D0", VA = "0x181C414D0")]
		public JEHFPNBCAEE(EHJDCPEOLPB BOOEFKPMNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72E7F40", Offset = "0x72E6B40", VA = "0x1872E7F40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72E7F90", Offset = "0x72E6B90", VA = "0x1872E7F90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread NCJDFNGJOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool PBMGCGMHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool CDCAFHKFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private HBBJDPKMINI FEKIKIGOMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent MJFJLLCGAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<JLFJDHBFOOP> NGOKIDFNAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<JLFJDHBFOOP> LOFIJKCINMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private JLFJDHBFOOP COBHFANMHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JKLLNGCGDEO CGKMKKKABJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LLEBBEPEIFP OJAHDMAEJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CEMPPCPHIFI FBNPMDLLFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PNPHDCECKAO DDCEOCAODMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, EHJDCPEOLPB> DMBLDPBFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, MHKMICAPHEF> FEHADMMCNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, JAKKJBOBONN> NGHHAOIBDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim DDKJOJELFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EHJDCPEOLPB NELAPPEGLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int AFDCEEDDPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<EHJDCPEOLPB> CPKMLCCGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private EHJDCPEOLPB[] NJKBJGILJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FDIAJAAKIMI FKALGPECPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int NHKEBEJJBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> HOJKFGHOENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte CGPPIPMAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object BJBEGBHLIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NANBHLFCPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool NELLDHKHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DPIJNJIANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int PGIALIOHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int NNDKBFPLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int CNEHCLGOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool IKNLFGJDPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool CKOBAOCHMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KACADALBHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int JDAFHCPGOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int BNBAAKLMFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool MAAAHEGNOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LGALOMEEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool CECBFHCHCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool BGDEABGGODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int DLFDGDMDALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int DKOGKDLDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool CNLONNJJFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly CFPHKKJEKPJ KKAEBNEBDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KBDIFGPPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly PJMJEHPAPLH JPGKGKPNLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool LDHBEMFFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public DLBPJDNPOMM CNDBIBNEKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int BPKKKKPADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool MBGCICBLLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool IEMLKJBCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool KJAFIGGDHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool BFKODEPNFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CDIJOLAENCA FJCFECIEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int LLLECMKEECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object NDELILJCEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private CDIJOLAENCA HLNIIOCEELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int AJOKLLHJLPE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int BHAAADOILBE = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int OFJAHJEKPHA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private BPHIGACOOAN BPIJGDOHFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private BPHIGACOOAN MDLIALANDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread BEPEPPJCBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread JMENKEDGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint FEFMPHIMILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint IGGKKLOFKIA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] COEOOMAFGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] MFJAPPGBBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<GKMDMEDLIKN, IPEndPoint> KOINCPOHGAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress OECCHCCBIDB;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool IHAHIALENKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int NOCFMDNMNHL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KPMGDFMAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBBAA00", Offset = "0xBB9600", VA = "0x180BBAA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBB9440", Offset = "0xBB8040", VA = "0x180BB9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MDBFALOOCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1771330", Offset = "0x176FF30", VA = "0x181771330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x209C640", Offset = "0x209B240", VA = "0x18209C640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte OFDOHJJPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1023A10", Offset = "0x1022610", VA = "0x181023A10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AELBLFFKGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72F0540", Offset = "0x72EF140", VA = "0x1872F0540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short LKAAKHEEKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72ECD00", Offset = "0x72EB900", VA = "0x1872ECD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EHJDCPEOLPB.ABBGPAEMLLM FHCKGHHKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72EFF10", Offset = "0x72EEB10", VA = "0x1872EFF10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72E9270", Offset = "0x72E7E70", VA = "0x1872E9270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72EF1D0", Offset = "0x72EDDD0", VA = "0x1872EF1D0")]
	public void KIJEOMMEKCE(IPEndPoint FAGBGHMGAGM, byte[] DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72F0560", Offset = "0x72EF160", VA = "0x1872F0560")]
	public void OJBMEDJNOCM(IPEndPoint FAGBGHMGAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72EC130", Offset = "0x72EAD30", VA = "0x1872EC130")]
	private bool GIJMDCBGGFN(IPEndPoint FAGBGHMGAGM, [Out] EHJDCPEOLPB CJMDLLLLCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72EB230", Offset = "0x72E9E30", VA = "0x1872EB230")]
	private void EICOIDBLMAD(EHJDCPEOLPB CJMDLLLLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72EF8A0", Offset = "0x72EE4A0", VA = "0x1872EF8A0")]
	private void MCAIMJKFOMC(EHJDCPEOLPB CJMDLLLLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72EE1B0", Offset = "0x72ECDB0", VA = "0x1872EE1B0")]
	private void JHGIAIFOPEF(EHJDCPEOLPB CJMDLLLLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72F09E0", Offset = "0x72EF5E0", VA = "0x1872F09E0")]
	public LENLHPOGELP(JKLLNGCGDEO PGCJAKGCANN, [Optional] FDIAJAAKIMI CHHOBCIGLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72EFB70", Offset = "0x72EE770", VA = "0x1872EFB70")]
	internal void MMMFOHFLCCE(EHJDCPEOLPB ONMCANCDKNP, int MGGNGJOFOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72F04F0", Offset = "0x72EF0F0", VA = "0x1872F04F0")]
	internal void OFDKAEBMCIE(EHJDCPEOLPB ONMCANCDKNP, object BBAEJJFNOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72F07C0", Offset = "0x72EF3C0", VA = "0x1872F07C0")]
	internal void PLJIGLCPKPG(EHJDCPEOLPB CJMDLLLLCJC, IHLIJOGCDHA LENOHNAJDNM, SocketError OEEOLEPOBAD, CDIJOLAENCA CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72E9CF0", Offset = "0x72E88F0", VA = "0x1872E9CF0")]
	private void BPDBJBMAKNH(EHJDCPEOLPB CJMDLLLLCJC, IHLIJOGCDHA LENOHNAJDNM, SocketError OEEOLEPOBAD, bool GPAPPOJDLEG, byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int NKGPOLKDIPE, CDIJOLAENCA CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72EA310", Offset = "0x72E8F10", VA = "0x1872EA310")]
	private void CEEAJIKHMGF(JLFJDHBFOOP.BEPBJJLOEKP MDCDODCGNEK, [Optional] EHJDCPEOLPB CJMDLLLLCJC, [Optional] IPEndPoint BBAJNEGBECM, SocketError MIAAKMICKJF = SocketError.Success, int MGGNGJOFOKC = 0, IHLIJOGCDHA OEBPMIDBLMN = IHLIJOGCDHA.ConnectionFailed, [Optional] MHKMICAPHEF MJJGEPDDBOH, ODEFHFNLPFJ BIKDOIKIEOG = ODEFHFNLPFJ.Unreliable, byte NCDHHICKMEH = 0, [Optional] CDIJOLAENCA OJLHOEENIFL, [Optional] object BBAEJJFNOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72EC530", Offset = "0x72EB130", VA = "0x1872EC530")]
	private void HFDAONHEIOH(JLFJDHBFOOP DAKAAKLHCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72F06B0", Offset = "0x72EF2B0", VA = "0x1872F06B0")]
	internal void PHHGJNMCKFD(JLFJDHBFOOP DAKAAKLHCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72EFBC0", Offset = "0x72EE7C0", VA = "0x1872EFBC0")]
	private void NAKMPBMFENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72EAF10", Offset = "0x72E9B10", VA = "0x1872EAF10")]
	private void EEFIAGCHGNH(int CCHMMLFHEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72EBB10", Offset = "0x72EA710", VA = "0x1872EBB10")]
	internal EHJDCPEOLPB FIHDHAGAMGN(MHKMICAPHEF HPBJFJONIPC, byte[] PFNEEIMOOAA, int LJEEMMFNMLE, int LBLBECEIAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72EC1D0", Offset = "0x72EADD0", VA = "0x1872EC1D0")]
	private int GJLFGHDHMBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72EF3F0", Offset = "0x72EDFF0", VA = "0x1872EF3F0")]
	private void LOBBIKMDBHG(IPEndPoint BBAJNEGBECM, EHJDCPEOLPB OMPPPMEEFEB, OKOOIBEKEDA AGKAMGNBGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72ECDC0", Offset = "0x72EB9C0", VA = "0x1872ECDC0")]
	private void JDFBMPFBHKA(CDIJOLAENCA BDIEGLLGOOG, IPEndPoint BBAJNEGBECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72E9320", Offset = "0x72E7F20", VA = "0x1872E9320")]
	internal void AEPDOIFKBOM(CDIJOLAENCA BDIEGLLGOOG, ODEFHFNLPFJ OBAAMCMFDIE, byte NCDHHICKMEH, int HEOADPALNEC, EHJDCPEOLPB ONMCANCDKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72EE500", Offset = "0x72ED100", VA = "0x1872EE500")]
	public bool JLODMKOIAML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72EE4E0", Offset = "0x72ED0E0", VA = "0x1872EE4E0")]
	public bool JLODMKOIAML(IPAddress JNNMEMLOJCL, IPAddress MNEMIEKCMLN, int HONLGADKEPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72EECE0", Offset = "0x72ED8E0", VA = "0x1872EECE0")]
	public bool JLODMKOIAML(int HONLGADKEPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x72E9600", Offset = "0x72E8200", VA = "0x1872E9600")]
	public void AIMHPKOMBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72EB650", Offset = "0x72EA250", VA = "0x1872EB650")]
	public EHJDCPEOLPB FACHHNALIEO(string IHJNIKBKIPL, int HONLGADKEPI, string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72EB570", Offset = "0x72EA170", VA = "0x1872EB570")]
	public EHJDCPEOLPB FACHHNALIEO(string IHJNIKBKIPL, int HONLGADKEPI, KENBNDKADMN IIHDDCGDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72EB730", Offset = "0x72EA330", VA = "0x1872EB730")]
	public EHJDCPEOLPB FACHHNALIEO(IPEndPoint ADGCHNLKFKK, KENBNDKADMN IIHDDCGDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72E9B10", Offset = "0x72E8710", VA = "0x1872E9B10")]
	public void AKGEMMIDJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72E97B0", Offset = "0x72E83B0", VA = "0x1872E97B0")]
	public void AKGEMMIDJHK(bool HHMNNIIMJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72EC480", Offset = "0x72EB080", VA = "0x1872EC480")]
	public void GPACODAKEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72EC3B0", Offset = "0x72EAFB0", VA = "0x1872EC3B0")]
	public void GPACODAKEEP(byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72EA110", Offset = "0x72E8D10", VA = "0x1872EA110")]
	public void BPDBJBMAKNH(EHJDCPEOLPB CJMDLLLLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72EA150", Offset = "0x72E8D50", VA = "0x1872EA150")]
	public void BPDBJBMAKNH(EHJDCPEOLPB CJMDLLLLCJC, byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72F0800", Offset = "0x72EF400", VA = "0x1872F0800", Slot = "4")]
	private IEnumerator<EHJDCPEOLPB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72F0890", Offset = "0x72EF490", VA = "0x1872F0890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72E9C00", Offset = "0x72E8800", VA = "0x1872E9C00")]
	private CDIJOLAENCA AMCHGICELAK(LBDNGFGLAKH ABMJBIODBLM, int PFHGPMHBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72E9B20", Offset = "0x72E8720", VA = "0x1872E9B20")]
	private CDIJOLAENCA AMCHGICELAK(LBDNGFGLAKH ABMJBIODBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72E9020", Offset = "0x72E7C20", VA = "0x1872E9020")]
	internal CDIJOLAENCA AEBJDHBKLFB(int PFHGPMHBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72EF900", Offset = "0x72EE500", VA = "0x1872EF900")]
	internal void MEFFDLONNCD(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x72F0920", Offset = "0x72EF520", VA = "0x1872F0920")]
	static LENLHPOGELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBBAA00", Offset = "0xBB9600", VA = "0x180BBAA00")]
	private bool GCFADFNMKCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72F0350", Offset = "0x72EEF50", VA = "0x1872F0350")]
	private void OBDDOGIFJLA(IPEndPoint CBINNJJCJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72EC250", Offset = "0x72EAE50", VA = "0x1872EC250")]
	private void GKDBEEMEKIL(IPEndPoint CBINNJJCJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72EED60", Offset = "0x72ED960", VA = "0x1872EED60")]
	private bool JNFHDNGAFFN(SocketException EBNIDHCOLMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72F04D0", Offset = "0x72EF0D0", VA = "0x1872F04D0")]
	private void OBPJLMPPHNA(HBBJDPKMINI NJPJMMCBKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72EEF10", Offset = "0x72EDB10", VA = "0x1872EEF10")]
	private void KBDPKCCCCFC(BPHIGACOOAN NJPJMMCBKLK, EndPoint KEIKGKDJAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72EFFC0", Offset = "0x72EEBC0", VA = "0x1872EFFC0")]
	private void OBCGKFFJCCG(object EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72EE510", Offset = "0x72ED110", VA = "0x1872EE510")]
	public bool JLODMKOIAML(IPAddress JNNMEMLOJCL, IPAddress MNEMIEKCMLN, int HONLGADKEPI, bool NKDGGJOCCNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72EE480", Offset = "0x72ED080", VA = "0x1872EE480")]
	internal int JIBLMPDDCEP(CDIJOLAENCA BDIEGLLGOOG, IPEndPoint BBAJNEGBECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72EA6F0", Offset = "0x72E92F0", VA = "0x1872EA6F0")]
	internal int CPKJFPJJAFC(CDIJOLAENCA BDIEGLLGOOG, IPEndPoint BBAJNEGBECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72EA730", Offset = "0x72E9330", VA = "0x1872EA730")]
	internal int CPKJFPJJAFC(byte[] HLMEMBFCHLD, int LJEEMMFNMLE, int LBLBECEIAEC, IPEndPoint BBAJNEGBECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72EA190", Offset = "0x72E8D90", VA = "0x1872EA190")]
	internal void CBLBBJKCMFF(bool DIOLIKLAIGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum LBDNGFGLAKH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CDIJOLAENCA
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int BLPAFKIMHHI;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] LGAKKGOJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] JPDOHCCOIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int FEOFCNGFMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object BJLGODPGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public CDIJOLAENCA LELGPBLLFFP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LBDNGFGLAKH NPHIEHLHIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72DF7F0", Offset = "0x72DE3F0", VA = "0x1872DF7F0")]
		get
		{
			return default(LBDNGFGLAKH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72DF530", Offset = "0x72DE130", VA = "0x1872DF530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EIMDFDBFOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72DF490", Offset = "0x72DE090", VA = "0x1872DF490")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72DF770", Offset = "0x72DE370", VA = "0x1872DF770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort FIAGIKGIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72DF5A0", Offset = "0x72DE1A0", VA = "0x1872DF5A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72DF7B0", Offset = "0x72DE3B0", VA = "0x1872DF7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KKAPLCFFHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72DF500", Offset = "0x72DE100", VA = "0x1872DF500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte PMHIMBFFNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72DF570", Offset = "0x72DE170", VA = "0x1872DF570")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72DF460", Offset = "0x72DE060", VA = "0x1872DF460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort FHECPABIDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72DF640", Offset = "0x72DE240", VA = "0x1872DF640")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72DF6D0", Offset = "0x72DE2D0", VA = "0x1872DF6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort FJLGJCBPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72DF400", Offset = "0x72DE000", VA = "0x1872DF400")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72DF600", Offset = "0x72DE200", VA = "0x1872DF600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort KFBEKAANINE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72DF710", Offset = "0x72DE310", VA = "0x1872DF710")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72DF4C0", Offset = "0x72DE0C0", VA = "0x1872DF4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72DFA20", Offset = "0x72DE620", VA = "0x1872DFA20")]
	static CDIJOLAENCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x72DF6A0", Offset = "0x72DE2A0", VA = "0x1872DF6A0")]
	public void IMNPKFEOLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72DFD00", Offset = "0x72DE900", VA = "0x1872DFD00")]
	public CDIJOLAENCA(int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72DFD70", Offset = "0x72DE970", VA = "0x1872DFD70")]
	public CDIJOLAENCA(LBDNGFGLAKH ABMJBIODBLM, int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x72DF920", Offset = "0x72DE520", VA = "0x1872DF920")]
	public static int PNDBIDNKMFJ(LBDNGFGLAKH ABMJBIODBLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x72DF990", Offset = "0x72DE590", VA = "0x1872DF990")]
	public int PNDBIDNKMFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72DF820", Offset = "0x72DE420", VA = "0x1872DF820")]
	public bool PBHODLMKOII()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum KLNKFKOEGEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum BKFPELJCKCP
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum MJMJGLDDMLM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum MIOFCEHALIE
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EHJDCPEOLPB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class AJNHAPAPPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CDIJOLAENCA[] OKHMBHDCOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int DHEPLHDHKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int JILJODGKHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte PMHIMBFFNNM;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AJNHAPAPPMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void ABBGPAEMLLM(ulong NICIBBIBJBB, int AIBJBMIJKLL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PFNJOLBNLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int EHPNLGHDLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int ICAPIOJKAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double OOGLPOCDKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int NGKFOOLBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int AFOEJLDPFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int DAJAJADBCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch PHILANIDBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int ALLPCKGABKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long HPKIKMFELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object NPDJEBLMFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal EHJDCPEOLPB AEEPJNIGCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal EHJDCPEOLPB OLNGIAEJIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<CDIJOLAENCA> CICNPKGLEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<DIFMMHENBKI> MDHBAHJOOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly DIFMMHENBKI[] JJHEAOGFLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int LHINBOEGJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int AIEFOGFFLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool DDGKBAICCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int LPJHJBFJPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int BOOHPCJOIMN;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int JPEKIANMBNL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int ODOEGBCKHGH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object LFEMLIIMGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NOKELHAKHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, AJNHAPAPPMB> OLAJLDBADKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> CKMACMFOCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly CDIJOLAENCA FLGAGPBHIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BNEGFFOPKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int KHDIEFHKJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint DFLMNOBBPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int MKMHJFADJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int DBEBCHKAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long KFFIANNJPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte COKKPKJBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private KLNKFKOEGEO MJMOEBLINFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private CDIJOLAENCA IOCLGMNHAGK;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int DCHJOGCLDHM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int IJMOHAAJHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly CDIJOLAENCA JDOFGJIHBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly CDIJOLAENCA BAAHBNGGKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly CDIJOLAENCA DBFOPPCINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly CDIJOLAENCA BPCKGMAJMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private CDAPJPGEJMA EFPHNACNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly LENLHPOGELP PHADIDLONKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int CKHNJNJFACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object KHMIPOHMNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly CFPHKKJEKPJ KKAEBNEBDAC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte HNLCJNLIACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB0C810", Offset = "0xB0B410", VA = "0x180B0C810")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72E3180", Offset = "0x72E1D80", VA = "0x1872E3180")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint OFKPDCCIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA20", Offset = "0xB0B620", VA = "0x180B0CA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public KLNKFKOEGEO NCODAMFAMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA00", Offset = "0xB0B600", VA = "0x180B0CA00")]
		get
		{
			return default(KLNKFKOEGEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long PDBOKJJGGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA65C50", Offset = "0xA64850", VA = "0x180A65C50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DJGMGDPJOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1771330", Offset = "0x176FF30", VA = "0x181771330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x209C640", Offset = "0x209B240", VA = "0x18209C640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int OOLICIDKIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72E38A0", Offset = "0x72E24A0", VA = "0x1872E38A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int ENMDLIADJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD050B0", Offset = "0xD03CB0", VA = "0x180D050B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double POCIBEJNMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x48F5FB0", Offset = "0x48F4BB0", VA = "0x1848F5FB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ABBGPAEMLLM FHCKGHHKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72E4280", Offset = "0x72E2E80", VA = "0x1872E4280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72E1400", Offset = "0x72E0000", VA = "0x1872E1400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72E5040", Offset = "0x72E3C40", VA = "0x1872E5040")]
	internal EHJDCPEOLPB(LENLHPOGELP DMOHAAMGLGF, IPEndPoint BBAJNEGBECM, int OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72E2C80", Offset = "0x72E1880", VA = "0x1872E2C80")]
	internal void EDDAGMMJEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72E14F0", Offset = "0x72E00F0", VA = "0x1872E14F0")]
	internal void BBLHBMLIJII(IPEndPoint EJOJFFFDLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72E2CE0", Offset = "0x72E18E0", VA = "0x1872E2CE0")]
	internal void FGHBLOALAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72E3230", Offset = "0x72E1E30", VA = "0x1872E3230")]
	private void IPFFGNPHCDI(int ELBNDKFOGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72E14B0", Offset = "0x72E00B0", VA = "0x1872E14B0")]
	private void AIPLEFDKGEG(int GOACLEKBLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72E3F70", Offset = "0x72E2B70", VA = "0x1872E3F70")]
	public int MPHBHOPAJPL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72E4080", Offset = "0x72E2C80", VA = "0x1872E4080")]
	public int MPHBHOPAJPL(byte NCDHHICKMEH, bool HGJCBDNIMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72E27E0", Offset = "0x72E13E0", VA = "0x1872E27E0")]
	private DIFMMHENBKI DPIKAGINGKA(byte DFLLFMHMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72E4EB0", Offset = "0x72E3AB0", VA = "0x1872E4EB0")]
	internal EHJDCPEOLPB(LENLHPOGELP DMOHAAMGLGF, IPEndPoint BBAJNEGBECM, int OIBGADINDDP, byte JHOGPMAIGLH, KENBNDKADMN HEHKMPOFJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72E4CD0", Offset = "0x72E38D0", VA = "0x1872E4CD0")]
	internal EHJDCPEOLPB(LENLHPOGELP DMOHAAMGLGF, MHKMICAPHEF HPBJFJONIPC, int OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72E1550", Offset = "0x72E0150", VA = "0x1872E1550")]
	internal void CEBPMLNKMEI(OKOOIBEKEDA NCIHJCFDACH, byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72E4200", Offset = "0x72E2E00", VA = "0x1872E4200")]
	internal bool NDEHHLDPONM(AGKEPFOOFOL BDIEGLLGOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72E1520", Offset = "0x72E0120", VA = "0x1872E1520")]
	public void BDGMCGKPGAG(byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int LBLBECEIAEC, ODEFHFNLPFJ ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72E1B10", Offset = "0x72E0710", VA = "0x1872E1B10")]
	private void DCHDFNPGOOG(byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int LBLBECEIAEC, byte NCDHHICKMEH, ODEFHFNLPFJ BIKDOIKIEOG, object BBAEJJFNOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72E3690", Offset = "0x72E2290", VA = "0x1872E3690")]
	public void LBEFNIAHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72E2990", Offset = "0x72E1590", VA = "0x1872E2990")]
	internal MJMJGLDDMLM EAMKKJEPMNC(CDIJOLAENCA BDIEGLLGOOG)
	{
		return default(MJMJGLDDMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72E41A0", Offset = "0x72E2DA0", VA = "0x1872E41A0")]
	internal void NBKAKLBHAHG(DIFMMHENBKI DPNGEAJJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72E10F0", Offset = "0x72DFCF0", VA = "0x1872E10F0")]
	internal MIOFCEHALIE ADJALNBAGNA(byte[] CBCNBAPLLJM, int LJEEMMFNMLE, int LBLBECEIAEC, bool GPAPPOJDLEG)
	{
		return default(MIOFCEHALIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72E2CA0", Offset = "0x72E18A0", VA = "0x1872E2CA0")]
	private void EHABFMLBFMO(int JMODGFGFNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72E4330", Offset = "0x72E2F30", VA = "0x1872E4330")]
	internal void PLDJJCNKHBC(ODEFHFNLPFJ OBAAMCMFDIE, CDIJOLAENCA BOOEFKPMNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72E15A0", Offset = "0x72E01A0", VA = "0x1872E15A0")]
	private void DAADLCMKCKA(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72E3300", Offset = "0x72E1F00", VA = "0x1872E3300")]
	private void JACBGJAJALN(int EOLAIOLLEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72E36E0", Offset = "0x72E22E0", VA = "0x1872E36E0")]
	internal BKFPELJCKCP LOBBIKMDBHG(OKOOIBEKEDA AGKAMGNBGJO)
	{
		return default(BKFPELJCKCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72E2120", Offset = "0x72E0D20", VA = "0x1872E2120")]
	internal void DPHMDENAJAC(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E3030", Offset = "0x72E1C30", VA = "0x1872E3030")]
	private void HKDONMBNEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72E2A70", Offset = "0x72E1670", VA = "0x1872E2A70")]
	internal void EBAFGBAAJDJ(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x72E38B0", Offset = "0x72E24B0", VA = "0x1872E38B0")]
	internal void MONBEGLCAAD(int EOLAIOLLEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x72E2D70", Offset = "0x72E1970", VA = "0x1872E2D70")]
	internal void GPBMLNAGFHO(CDIJOLAENCA BDIEGLLGOOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class CFPHKKJEKPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long HPCHFHMBIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long JBOBGHDFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long CDGAOFGGLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long KGDNOIOPKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CBPONCCKECI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long EOAAEKOLDNB;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long ONGMMALOGLF;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long FDEBBGMLEAO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long PKKGCJEMHLC;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long LJLFIMHDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long MGKBEMGACAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long INJKMELHMPE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long KPIAFGKGHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72E0190", Offset = "0x72DED90", VA = "0x1872E0190")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long JHLINMEIJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72E00B0", Offset = "0x72DECB0", VA = "0x1872E00B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CKDOOIDFKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x72E0200", Offset = "0x72DEE00", VA = "0x1872E0200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long MHEBMHLKJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72E0040", Offset = "0x72DEC40", VA = "0x1872E0040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long KJOHLPPPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72E0170", Offset = "0x72DED70", VA = "0x1872E0170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long PLHPJKAOHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72E0180", Offset = "0x72DED80", VA = "0x1872E0180")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long MEHCCCDGEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72E02D0", Offset = "0x72DEED0", VA = "0x1872E02D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long IJMFNPNDGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72DFF60", Offset = "0x72DEB60", VA = "0x1872DFF60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private CDAPJPGEJMA DDHAIGEFMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x13462C0", Offset = "0x1344EC0", VA = "0x1813462C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double AHILOMCNANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x72DFE80", Offset = "0x72DEA80", VA = "0x1872DFE80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x72E0130", Offset = "0x72DED30", VA = "0x1872E0130")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x72E01A0", Offset = "0x72DEDA0", VA = "0x1872E01A0")]
	public void OCGEDCOJCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72E0210", Offset = "0x72DEE10", VA = "0x1872E0210")]
	public void PBJGNFEIIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72E00C0", Offset = "0x72DECC0", VA = "0x1872E00C0")]
	public void HEPFPMAOKIA(long LEJAIPKKKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x72E0260", Offset = "0x72DEE60", VA = "0x1872E0260")]
	public void PGJCFOEOHLE(long LICGENMKNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72E0050", Offset = "0x72DEC50", VA = "0x1872E0050")]
	public void GAKAPAJJACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72DFEE0", Offset = "0x72DEAE0", VA = "0x1872DFEE0")]
	public void AMEAJOHBBAL(long PJFIOEHCJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72E0310", Offset = "0x72DEF10", VA = "0x1872E0310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72DFFA0", Offset = "0x72DEBA0", VA = "0x1872DFFA0")]
	public void ELKALKANACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CFPHKKJEKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FLFNNAIKKDI
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> FKAIJFKFCJN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72E5D30", Offset = "0x72E4930", VA = "0x1872E5D30")]
	public static IPEndPoint MAONPMKANIE(string LHFMOGIELNG, int HONLGADKEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72E6010", Offset = "0x72E4C10", VA = "0x1872E6010")]
	public static IPAddress PDIBHAKDEBO(string LHFMOGIELNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x72E5F80", Offset = "0x72E4B80", VA = "0x1872E5F80")]
	public static IPAddress PDIBHAKDEBO(string LHFMOGIELNG, AddressFamily ILBEDIMPIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72E5D00", Offset = "0x72E4900", VA = "0x1872E5D00")]
	internal static int CJELPACLBKA(int CJBOKIOODME, int OPNADHMLMLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C29BF0", Offset = "0x3C287F0", VA = "0x183C29BF0")]
	internal static T[] OMFDIBGMEHD<T>(int NKGPOLKDIPE) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JDOMHCIFLFA : DIFMMHENBKI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct GPDCJPHFJEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private CDIJOLAENCA IDICKOGOIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long BMHPNHEBIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool FGGBHNGEJGJ;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72E6CD0", Offset = "0x72E58D0", VA = "0x1872E6CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C60", Offset = "0x72E5860", VA = "0x1872E6C60")]
		public void CBACPPGGEHG(CDIJOLAENCA BDIEGLLGOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72E6BF0", Offset = "0x72E57F0", VA = "0x1872E6BF0")]
		public bool BLBBAGBOKMM(long KBAPJIBEOOI, EHJDCPEOLPB CJMDLLLLCJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72E6C80", Offset = "0x72E5880", VA = "0x1872E6C80")]
		public bool HAGLLFMPLGJ(EHJDCPEOLPB CJMDLLLLCJC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly CDIJOLAENCA POGLEJGOFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly GPDCJPHFJEP[] IDOOHCGHLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly CDIJOLAENCA[] JFBBIFLCKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] DNNIAILBKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EFAFBONBGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int NDKKJJINNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int DILJHHDKHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int NDFPMHAKKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool HMBHKNDKJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly ODEFHFNLPFJ DJMPINHLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool NEJCMMMPNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int DABLLKPDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte HMCGMCNOGEK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LMABLCKFILM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x72E7890", Offset = "0x72E6490", VA = "0x1872E7890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72E7D70", Offset = "0x72E6970", VA = "0x1872E7D70")]
	public JDOMHCIFLFA(EHJDCPEOLPB CJMDLLLLCJC, bool HGJCBDNIMAP, byte OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72E74D0", Offset = "0x72E60D0", VA = "0x1872E74D0")]
	private void FBNLDPKCEDD(CDIJOLAENCA BDIEGLLGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72E78A0", Offset = "0x72E64A0", VA = "0x1872E78A0", Slot = "4")]
	protected override bool NJCFLMOPFML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x72E6E70", Offset = "0x72E5A70", VA = "0x1872E6E70", Slot = "5")]
	public override bool DPHMDENAJAC(CDIJOLAENCA BDIEGLLGOOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class DFEHMMHMJFI : DIFMMHENBKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int KDLJGCLFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort NDKKJJINNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool EIKEKEBICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private CDIJOLAENCA BONPKGKEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly CDIJOLAENCA GNFKODAPOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool CJOAACFGBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte HMCGMCNOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long OLNHNAHFBAB;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72E0E20", Offset = "0x72DFA20", VA = "0x1872E0E20")]
	public DFEHMMHMJFI(EHJDCPEOLPB CJMDLLLLCJC, bool PPIPMBMEHLK, byte OIBGADINDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72E0960", Offset = "0x72DF560", VA = "0x1872E0960", Slot = "4")]
	protected override bool NJCFLMOPFML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72E0680", Offset = "0x72DF280", VA = "0x1872E0680", Slot = "5")]
	public override bool DPHMDENAJAC(CDIJOLAENCA BDIEGLLGOOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GEFIFEHOCHN
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JPKIKHGIHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong GFCPNCKJDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double AFACJFCJFJL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct PCIHMNNLHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int AOGEBGHCMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float LKGGPBKOGFK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72DEEE0", Offset = "0x72DDAE0", VA = "0x1872DEEE0")]
	private static void BHPJEKNOAAI(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, ulong CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72E6270", Offset = "0x72E4E70", VA = "0x1872E6270")]
	private static void BHPJEKNOAAI(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, int CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72E62E0", Offset = "0x72E4EE0", VA = "0x1872E62E0")]
	public static void BHPJEKNOAAI(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, short CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72E63B0", Offset = "0x72E4FB0", VA = "0x1872E63B0")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, double BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72E6330", Offset = "0x72E4F30", VA = "0x1872E6330")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72E62E0", Offset = "0x72E4EE0", VA = "0x1872E62E0")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, short BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72E62E0", Offset = "0x72E4EE0", VA = "0x1872E62E0")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, ushort BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72E6270", Offset = "0x72E4E70", VA = "0x1872E6270")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72E6270", Offset = "0x72E4E70", VA = "0x1872E6270")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, uint BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72E6320", Offset = "0x72E4F20", VA = "0x1872E6320")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72E6320", Offset = "0x72E4F20", VA = "0x1872E6320")]
	public static void HPNDCGFHDON(byte[] LNEJCNPADCI, int FAHOKHGHPIJ, ulong BKMPCFIAHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OKKHGFHCGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] MJDJLDLPFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int MAKAGLDHKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int ONHAPMLGJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int MOOGBCKKPEP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] JPDOHCCOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GGFAIGCOFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int LJPMEDOEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72F4C60", Offset = "0x72F3860", VA = "0x1872F4C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GDMEJEJDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28E0DA0", Offset = "0x28DF9A0", VA = "0x1828E0DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FJPCKPECNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72F4890", Offset = "0x72F3490", VA = "0x1872F4890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72F4440", Offset = "0x72F3040", VA = "0x1872F4440")]
	public void EEAMEIMDIKO(byte[] NDMEBHICHPO, int HDEKJKJDEIC, int OBMOHOEHALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public OKKHGFHCGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D20", Offset = "0x72F3920", VA = "0x1872F4D20")]
	public OKKHGFHCGGE(byte[] NDMEBHICHPO, int HDEKJKJDEIC, int OBMOHOEHALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x72F4B50", Offset = "0x72F3750", VA = "0x1872F4B50")]
	public IPEndPoint MONEGGIAIIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x72F4480", Offset = "0x72F3080", VA = "0x1872F4480")]
	public byte PEOCEANNKCL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4480", Offset = "0x72F3080", VA = "0x1872F4480")]
	public sbyte EKCLDOAMBBC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3E018C0", Offset = "0x3E004C0", VA = "0x183E018C0")]
	public T[] FPAEIAKPPKJ<T>(ushort PFHGPMHBODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72F4230", Offset = "0x72F2E30", VA = "0x1872F4230")]
	public bool[] CHFCJAOOKBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C20", Offset = "0x72F3820", VA = "0x1872F4C20")]
	public ushort[] NMLPKOCKJCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72F4A30", Offset = "0x72F3630", VA = "0x1872F4A30")]
	public short[] KPJIPICNCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72F48C0", Offset = "0x72F34C0", VA = "0x1872F48C0")]
	public int[] HANABKJLPPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72F4900", Offset = "0x72F3500", VA = "0x1872F4900")]
	public uint[] ICHAFKEGIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x72F4CE0", Offset = "0x72F38E0", VA = "0x1872F4CE0")]
	public float[] PKGLIOBBKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72F41F0", Offset = "0x72F2DF0", VA = "0x1872F41F0")]
	public double[] BLLMFLKMHDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72F42B0", Offset = "0x72F2EB0", VA = "0x1872F42B0")]
	public long[] DBOEKMFPKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72F49B0", Offset = "0x72F35B0", VA = "0x1872F49B0")]
	public ulong[] JFEFKPPLPHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72F4740", Offset = "0x72F3340", VA = "0x1872F4740")]
	public string[] FLPEDBEHOOH(int LLIPFGCNMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72F4270", Offset = "0x72F2E70", VA = "0x1872F4270")]
	public bool CLCPILEFEGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72F43D0", Offset = "0x72F2FD0", VA = "0x1872F43D0")]
	public char ECCILCMPJHD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x72F43D0", Offset = "0x72F2FD0", VA = "0x1872F43D0")]
	public ushort NHEFAACDFOM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C70", Offset = "0x72F3870", VA = "0x1872F4C70")]
	public short PGOIMNPIFKK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4A70", Offset = "0x72F3670", VA = "0x1872F4A70")]
	public long LAPGEGDJHBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72F4180", Offset = "0x72F2D80", VA = "0x1872F4180")]
	public ulong BHBEDAILLOB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72F4AE0", Offset = "0x72F36E0", VA = "0x1872F4AE0")]
	public int MGLLFAFCJDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72F42F0", Offset = "0x72F2EF0", VA = "0x1872F42F0")]
	public uint DFBNPLOAEED()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72F4110", Offset = "0x72F2D10", VA = "0x1872F4110")]
	public float BFCMMMIGKJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x72F4360", Offset = "0x72F2F60", VA = "0x1872F4360")]
	public double DOEECHIEDMD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x72F4500", Offset = "0x72F3100", VA = "0x1872F4500")]
	public string FIHKHAPHEHN(int OLOHHHFGBJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x72F4940", Offset = "0x72F3540", VA = "0x1872F4940")]
	public ArraySegment<byte> JFDHDKFIGON(int NKGPOLKDIPE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x72F44C0", Offset = "0x72F30C0", VA = "0x1872F44C0")]
	public sbyte[] FFPEHKLKNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x72F49F0", Offset = "0x72F35F0", VA = "0x1872F49F0")]
	public byte[] KEOKAICIBOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x72F48A0", Offset = "0x72F34A0", VA = "0x1872F48A0")]
	public void HAGLLFMPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KENBNDKADMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] MJDJLDLPFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int MAKAGLDHKJH;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int PMOCAAFHAHF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool HEMMEDNIJHH;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding EHEBIGAPBGD;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int IEINLFBIMEK = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] LDEJMANBJKN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] OHABHFNOKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x72E8F00", Offset = "0x72E7B00", VA = "0x1872E8F00")]
	public KENBNDKADMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x72E8F80", Offset = "0x72E7B80", VA = "0x1872E8F80")]
	public KENBNDKADMN(bool OMIOGJMICFL, int MFJGHGFKOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x72E8E00", Offset = "0x72E7A00", VA = "0x1872E8E00")]
	public static KENBNDKADMN LGHJCEIFAIK(string BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x72E8910", Offset = "0x72E7510", VA = "0x1872E8910")]
	public void FBKALEFKLLC(int HEOJCLMFPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x295AC50", Offset = "0x2959850", VA = "0x18295AC50")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72E84B0", Offset = "0x72E70B0", VA = "0x1872E84B0")]
	public void CDNDLOFBHAB(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x72E8320", Offset = "0x72E6F20", VA = "0x1872E8320")]
	public void CDNDLOFBHAB(double BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x72E8550", Offset = "0x72E7150", VA = "0x1872E8550")]
	public void CDNDLOFBHAB(long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x72E8550", Offset = "0x72E7150", VA = "0x1872E8550")]
	public void CDNDLOFBHAB(ulong BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72E8880", Offset = "0x72E7480", VA = "0x1872E8880")]
	public void CDNDLOFBHAB(int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72E8880", Offset = "0x72E7480", VA = "0x1872E8880")]
	public void CDNDLOFBHAB(uint BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72E82B0", Offset = "0x72E6EB0", VA = "0x1872E82B0")]
	public void CDNDLOFBHAB(char BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72E82B0", Offset = "0x72E6EB0", VA = "0x1872E82B0")]
	public void CDNDLOFBHAB(ushort BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72E82B0", Offset = "0x72E6EB0", VA = "0x1872E82B0")]
	public void CDNDLOFBHAB(short BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x72E8450", Offset = "0x72E7050", VA = "0x1872E8450")]
	public void CDNDLOFBHAB(sbyte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72E8450", Offset = "0x72E7050", VA = "0x1872E8450")]
	public void CDNDLOFBHAB(byte BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x72E85A0", Offset = "0x72E71A0", VA = "0x1872E85A0")]
	public void CDNDLOFBHAB(byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72E81D0", Offset = "0x72E6DD0", VA = "0x1872E81D0")]
	public void CCGNOHCNNOC(sbyte[] CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x72E81D0", Offset = "0x72E6DD0", VA = "0x1872E81D0")]
	public void EGHIGHMNNDD(byte[] CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72E8610", Offset = "0x72E7210", VA = "0x1872E8610")]
	public void CDNDLOFBHAB(bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72E8B70", Offset = "0x72E7770", VA = "0x1872E8B70")]
	public void KBAKGMNJHGB(Array JPLCDDPKPCC, int FMFMGJOIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72E89B0", Offset = "0x72E75B0", VA = "0x1872E89B0")]
	public void KBAKGMNJHGB(float[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72E8C50", Offset = "0x72E7850", VA = "0x1872E8C50")]
	public void KBAKGMNJHGB(double[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72E8C50", Offset = "0x72E7850", VA = "0x1872E8C50")]
	public void KBAKGMNJHGB(long[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72E8C50", Offset = "0x72E7850", VA = "0x1872E8C50")]
	public void KBAKGMNJHGB(ulong[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72E89B0", Offset = "0x72E75B0", VA = "0x1872E89B0")]
	public void KBAKGMNJHGB(int[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72E89B0", Offset = "0x72E75B0", VA = "0x1872E89B0")]
	public void KBAKGMNJHGB(uint[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72E8A90", Offset = "0x72E7690", VA = "0x1872E8A90")]
	public void KBAKGMNJHGB(ushort[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72E8A90", Offset = "0x72E7690", VA = "0x1872E8A90")]
	public void KBAKGMNJHGB(short[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72E81D0", Offset = "0x72E6DD0", VA = "0x1872E81D0")]
	public void KBAKGMNJHGB(bool[] BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72E8D30", Offset = "0x72E7930", VA = "0x1872E8D30")]
	public void KBAKGMNJHGB(string[] BKMPCFIAHIG, int FNHMLELDLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72E8370", Offset = "0x72E6F70", VA = "0x1872E8370")]
	public void CDNDLOFBHAB(IPEndPoint FAGBGHMGAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72E8440", Offset = "0x72E7040", VA = "0x1872E8440")]
	public void CDNDLOFBHAB(string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x72E8670", Offset = "0x72E7270", VA = "0x1872E8670")]
	public void CDNDLOFBHAB(string BKMPCFIAHIG, int OLOHHHFGBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NGCMNOBLNEP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class KBDBALJAOGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong CKHNJNJFACM;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5391630", Offset = "0x5390230", VA = "0x185391630")]
		static KBDBALJAOGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void OGNGALPFNNC(OKKHGFHCGGE NOIAIJBDKGG, object BBAEJJFNOAN);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OODGPEIKDEO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public NGCMNOBLNEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OODGPEIKDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x588CFC0", Offset = "0x588BBC0", VA = "0x18588CFC0")]
		internal void CIEFPPEDBNF(OKKHGFHCGGE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NKHGABHNHNF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public NGCMNOBLNEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NKHGABHNHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x571DC90", Offset = "0x571C890", VA = "0x18571DC90")]
		internal void CIEFPPEDBNF(OKKHGFHCGGE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly LNGLBIIMNBH NFAOMBJANIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, OGNGALPFNNC> FPEGGAOLMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly KENBNDKADMN KJOOMLMCFEM;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x72F3F90", Offset = "0x72F2B90", VA = "0x1872F3F90")]
	public NGCMNOBLNEP(int LLIPFGCNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3187AB0", Offset = "0x31866B0", VA = "0x183187AB0", Slot = "4")]
	protected virtual ulong IKOOFLBAMID<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x72F3E10", Offset = "0x72F2A10", VA = "0x1872F3E10", Slot = "5")]
	protected virtual OGNGALPFNNC NIGOOAAJDGK(OKKHGFHCGGE NOIAIJBDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5D60", Offset = "0x3DC4960", VA = "0x183DC5D60", Slot = "6")]
	protected virtual void JIIBMHLFCHK<T>(KENBNDKADMN HDDCOPOMJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72F3D90", Offset = "0x72F2990", VA = "0x1872F3D90")]
	public void NECMGDIPAOA(OKKHGFHCGGE NOIAIJBDKGG, object BBAEJJFNOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5DD0", Offset = "0x3DC49D0", VA = "0x183DC5DD0")]
	public void KJONDBHMIMN<T>(KENBNDKADMN HDDCOPOMJML, T BDIEGLLGOOG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x72F3F40", Offset = "0x72F2B40", VA = "0x1872F3F40")]
	public void PAHKIAPAGFM(OKKHGFHCGGE NOIAIJBDKGG, object BBAEJJFNOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5BE0", Offset = "0x3DC47E0", VA = "0x183DC5BE0")]
	public void FOPCGLFKFON<T>(Action<T> EJABIBCIMBI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5A60", Offset = "0x3DC4660", VA = "0x183DC5A60")]
	public void FOPCGLFKFON<T, TUserData>(Action<T, TUserData> EJABIBCIMBI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OFJKLKNLKDF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DF270", VA = "0x1872E0670")]
	public OFJKLKNLKDF(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FLCEOPKAGGP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72E5CA0", Offset = "0x72E48A0", VA = "0x1872E5CA0")]
	public FLCEOPKAGGP(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LNGLBIIMNBH
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum AOLGBJGBAJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class DLJMNMCCFCI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AOLGBJGBAJD GJCIAOMMHGH;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x44755A0", Offset = "0x44741A0", VA = "0x1844755A0", Slot = "4")]
		public virtual void CBACPPGGEHG(MethodInfo BCJDJFMFPAG, MethodInfo LHPBGEFCBOM, AOLGBJGBAJD MDCDODCGNEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FFKIPFJAHFC(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KPMPPHDDOHE(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		protected DLJMNMCCFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DJLNCNJDKGO<TClass, TProperty> : DLJMNMCCFCI<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> CHGOJKPJGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> LGBHKOMMDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> KHPLHDPIFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> DIALGLDKDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> GEBAKALFDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> IAJBKKHICFE;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4470120", Offset = "0x446ED20", VA = "0x184470120", Slot = "7")]
		public override void FIJHIIAMFKP(TClass DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x446EB40", Offset = "0x446D740", VA = "0x18446EB40", Slot = "8")]
		public override void EFKEIFJANHP(TClass DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x446F860", Offset = "0x446E460", VA = "0x18446F860", Slot = "9")]
		public override void FFKIPFJAHFC(TClass DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4470D70", Offset = "0x446F970", VA = "0x184470D70", Slot = "10")]
		public override void KPMPPHDDOHE(TClass DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4470820", Offset = "0x446F420", VA = "0x184470820")]
		protected TProperty[] JCPLMJGNFNH(TClass DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x44712B0", Offset = "0x446FEB0", VA = "0x1844712B0")]
		protected TProperty[] LJKJAEBIBJP(TClass DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x446BEC0", Offset = "0x446AAC0", VA = "0x18446BEC0", Slot = "4")]
		public override void CBACPPGGEHG(MethodInfo BCJDJFMFPAG, MethodInfo LHPBGEFCBOM, AOLGBJGBAJD MDCDODCGNEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4471320", Offset = "0x446FF20", VA = "0x184471320")]
		protected DJLNCNJDKGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class CEALECLOJDK<TClass, TProperty> : DJLNCNJDKGO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PFDPPGAEIJO(OKKHGFHCGGE KFNDMAAELJD, [Out] TProperty HGJFLILNCHH);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void JMELIEAGDON(KENBNDKADMN PBIHGFKMLJE, TProperty HGJFLILNCHH);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6A71CB0", Offset = "0x6A708B0", VA = "0x186A71CB0", Slot = "5")]
		public override void HEHDBFMCKCL(TClass DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6A71DB0", Offset = "0x6A709B0", VA = "0x186A71DB0", Slot = "6")]
		public override void KJONDBHMIMN(TClass DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6A71C10", Offset = "0x6A70810", VA = "0x186A71C10", Slot = "7")]
		public override void FIJHIIAMFKP(TClass DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6A71AD0", Offset = "0x6A706D0", VA = "0x186A71AD0", Slot = "8")]
		public override void EFKEIFJANHP(TClass DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF0A0", Offset = "0x4EADCA0", VA = "0x184EAF0A0")]
		protected CEALECLOJDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BCJJBCBFLMA<T> : DJLNCNJDKGO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6335680", Offset = "0x6334280", VA = "0x186335680", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x56704C0", Offset = "0x566F0C0", VA = "0x1856704C0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6335620", Offset = "0x6334220", VA = "0x186335620", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x56703B0", Offset = "0x566EFB0", VA = "0x1856703B0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public BCJJBCBFLMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class MFGOIBKEPJG<T> : DJLNCNJDKGO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5670460", Offset = "0x566F060", VA = "0x185670460", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x56704C0", Offset = "0x566F0C0", VA = "0x1856704C0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5670400", Offset = "0x566F000", VA = "0x185670400", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x56703B0", Offset = "0x566EFB0", VA = "0x1856703B0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public MFGOIBKEPJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MBBKGGLBIGO<T> : DJLNCNJDKGO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x564AC90", Offset = "0x5649890", VA = "0x18564AC90", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x564ACF0", Offset = "0x56498F0", VA = "0x18564ACF0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x564AC30", Offset = "0x5649830", VA = "0x18564AC30", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x564ABE0", Offset = "0x56497E0", VA = "0x18564ABE0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public MBBKGGLBIGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BGNMNCBECHO<T> : DJLNCNJDKGO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x64337D0", Offset = "0x64323D0", VA = "0x1864337D0", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x564ACF0", Offset = "0x56498F0", VA = "0x18564ACF0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6433770", Offset = "0x6432370", VA = "0x186433770", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x564ABE0", Offset = "0x56497E0", VA = "0x18564ABE0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public BGNMNCBECHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class ONOJAPMILDG<T> : DJLNCNJDKGO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x588CF60", Offset = "0x588BB60", VA = "0x18588CF60", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x505B040", Offset = "0x5059C40", VA = "0x18505B040", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x588CF00", Offset = "0x588BB00", VA = "0x18588CF00", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F26EB0", Offset = "0x4F25AB0", VA = "0x184F26EB0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public ONOJAPMILDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class IADKILIJIKI<T> : DJLNCNJDKGO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x505AFE0", Offset = "0x5059BE0", VA = "0x18505AFE0", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x505B040", Offset = "0x5059C40", VA = "0x18505B040", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x505AF80", Offset = "0x5059B80", VA = "0x18505AF80", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F26EB0", Offset = "0x4F25AB0", VA = "0x184F26EB0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public IADKILIJIKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class NGKECGMMLKH<T> : DJLNCNJDKGO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x564C580", Offset = "0x564B180", VA = "0x18564C580", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x564C5E0", Offset = "0x564B1E0", VA = "0x18564C5E0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x570C420", Offset = "0x570B020", VA = "0x18570C420", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x517D110", Offset = "0x517BD10", VA = "0x18517D110", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public NGKECGMMLKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class MCEENHOJAAA<T> : DJLNCNJDKGO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x564C580", Offset = "0x564B180", VA = "0x18564C580", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x564C5E0", Offset = "0x564B1E0", VA = "0x18564C5E0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x564C520", Offset = "0x564B120", VA = "0x18564C520", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x517D110", Offset = "0x517BD10", VA = "0x18517D110", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public MCEENHOJAAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MNCLCLBFGJD<T> : DJLNCNJDKGO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x56A61D0", Offset = "0x56A4DD0", VA = "0x1856A61D0", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x56A6230", Offset = "0x56A4E30", VA = "0x1856A6230", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x56A6170", Offset = "0x56A4D70", VA = "0x1856A6170", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x56703B0", Offset = "0x566EFB0", VA = "0x1856703B0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public MNCLCLBFGJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GOFMLMGKFED<T> : DJLNCNJDKGO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F26F60", Offset = "0x4F25B60", VA = "0x184F26F60", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F26FC0", Offset = "0x4F25BC0", VA = "0x184F26FC0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F26F00", Offset = "0x4F25B00", VA = "0x184F26F00", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4F26EB0", Offset = "0x4F25AB0", VA = "0x184F26EB0", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public GOFMLMGKFED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AJIEDMBJEAD<T> : DJLNCNJDKGO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x517D1C0", Offset = "0x517BDC0", VA = "0x18517D1C0", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x517D220", Offset = "0x517BE20", VA = "0x18517D220", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x517D160", Offset = "0x517BD60", VA = "0x18517D160", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x517D110", Offset = "0x517BD10", VA = "0x18517D110", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x48B94F0", Offset = "0x48B80F0", VA = "0x1848B94F0")]
		public AJIEDMBJEAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BMELMFLDNMC<T> : CEALECLOJDK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x66F8590", Offset = "0x66F7190", VA = "0x1866F8590", Slot = "12")]
		protected override void JMELIEAGDON(KENBNDKADMN PBIHGFKMLJE, char HGJFLILNCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x66F85C0", Offset = "0x66F71C0", VA = "0x1866F85C0", Slot = "11")]
		protected override void PFDPPGAEIJO(OKKHGFHCGGE KFNDMAAELJD, [Out] char HGJFLILNCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4893BE0", Offset = "0x48927E0", VA = "0x184893BE0")]
		public BMELMFLDNMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class PDCCAEIKCOI<T> : CEALECLOJDK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x59BE210", Offset = "0x59BCE10", VA = "0x1859BE210", Slot = "12")]
		protected override void JMELIEAGDON(KENBNDKADMN PBIHGFKMLJE, IPEndPoint HGJFLILNCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x59BE240", Offset = "0x59BCE40", VA = "0x1859BE240", Slot = "11")]
		protected override void PFDPPGAEIJO(OKKHGFHCGGE KFNDMAAELJD, [Out] IPEndPoint HGJFLILNCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4893BE0", Offset = "0x48927E0", VA = "0x184893BE0")]
		public PDCCAEIKCOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JEEKOOIGHEK<T> : DJLNCNJDKGO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int GMHDAGIMNEF;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x52C7B20", Offset = "0x52C6720", VA = "0x1852C7B20")]
		public JEEKOOIGHEK(int OLOHHHFGBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x52C7A50", Offset = "0x52C6650", VA = "0x1852C7A50", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x52C7AC0", Offset = "0x52C66C0", VA = "0x1852C7AC0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x52C79E0", Offset = "0x52C65E0", VA = "0x1852C79E0", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x52C7980", Offset = "0x52C6580", VA = "0x1852C7980", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class ABKPPLDCPLM<T> : DLJMNMCCFCI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo NPHIEHLHIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type ONIENPDOKKI;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DA70", Offset = "0x4F6C670", VA = "0x184F6DA70")]
		public ABKPPLDCPLM(PropertyInfo ABMJBIODBLM, Type IEPCGNNBPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D8A0", Offset = "0x4F6C4A0", VA = "0x184F6D8A0", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D960", Offset = "0x4F6C560", VA = "0x184F6D960", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D840", Offset = "0x4F6C440", VA = "0x184F6D840", Slot = "7")]
		public override void FIJHIIAMFKP(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D780", Offset = "0x4F6C380", VA = "0x184F6D780", Slot = "8")]
		public override void EFKEIFJANHP(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D7E0", Offset = "0x4F6C3E0", VA = "0x184F6D7E0", Slot = "9")]
		public override void FFKIPFJAHFC(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DA10", Offset = "0x4F6C610", VA = "0x184F6DA10", Slot = "10")]
		public override void KPMPPHDDOHE(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class GGHMGEBDOMG<T> : ABKPPLDCPLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
		public GGHMGEBDOMG(PropertyInfo ABMJBIODBLM, Type IEPCGNNBPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4E95720", Offset = "0x4E94320", VA = "0x184E95720", Slot = "5")]
		public override void HEHDBFMCKCL(T DNAPAMOIIMF, OKKHGFHCGGE KFNDMAAELJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4E957E0", Offset = "0x4E943E0", VA = "0x184E957E0", Slot = "6")]
		public override void KJONDBHMIMN(T DNAPAMOIIMF, KENBNDKADMN PBIHGFKMLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class JECNEOFLJCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static JECNEOFLJCO<T> MFAGMJBMEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly DLJMNMCCFCI<T>[] HNONPPLGBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int NPCCHDODINH;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x52C78F0", Offset = "0x52C64F0", VA = "0x1852C78F0")]
		public JECNEOFLJCO(List<DLJMNMCCFCI<T>> MIKJEAGINEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x52C7840", Offset = "0x52C6440", VA = "0x1852C7840")]
		public void KJONDBHMIMN(T KOJLNGLNBMH, KENBNDKADMN HDDCOPOMJML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x52C7790", Offset = "0x52C6390", VA = "0x1852C7790")]
		public void HEHDBFMCKCL(T KOJLNGLNBMH, OKKHGFHCGGE NOIAIJBDKGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class LEIJEJOKBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract DLJMNMCCFCI<T> LGFPFICEOKK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private KENBNDKADMN CHAPDINDKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int OMPANALLOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, LEIJEJOKBCM> DINGBMPFBKO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72F1040", Offset = "0x72EFC40", VA = "0x1872F1040")]
	public LNGLBIIMNBH(int LLIPFGCNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D315F0", Offset = "0x3D301F0", VA = "0x183D315F0")]
	private JECNEOFLJCO<T> FFFJNGCPMKE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x39C0AA0", Offset = "0x39BF6A0", VA = "0x1839C0AA0")]
	public void AMHLLDBNIFP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3D324E0", Offset = "0x3D310E0", VA = "0x183D324E0")]
	public bool GLDNKJDIMCO<T>(OKKHGFHCGGE NOIAIJBDKGG, T ADGCHNLKFKK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D32560", Offset = "0x3D31160", VA = "0x183D32560")]
	public void PBHGMJKEMBG<T>(KENBNDKADMN HDDCOPOMJML, T KOJLNGLNBMH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OOLGGJEDPLG
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime AGBDCKHFCFB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] KIBMAPOIMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KFNEJHELOPF BANHMLOBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x72F60D0", Offset = "0x72F4CD0", VA = "0x1872F60D0")]
		get
		{
			return default(KFNEJHELOPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BKJEFAMPNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x72F5450", Offset = "0x72F4050", VA = "0x1872F5450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x72F5F00", Offset = "0x72F4B00", VA = "0x1872F5F00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OAOJNOAABJI BFKHBBHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x72F5FD0", Offset = "0x72F4BD0", VA = "0x1872F5FD0")]
		get
		{
			return default(OAOJNOAABJI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x72F6180", Offset = "0x72F4D80", VA = "0x1872F6180")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int FNKJHOBNMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x72F5FA0", Offset = "0x72F4BA0", VA = "0x1872F5FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint HDAIDOICCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x72F6100", Offset = "0x72F4D00", VA = "0x1872F6100")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? HGDINKKGHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x72F5DB0", Offset = "0x72F49B0", VA = "0x1872F5DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? KPJFKCACNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x72F5420", Offset = "0x72F4020", VA = "0x1872F5420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? DDBFKLJCCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x72F5BB0", Offset = "0x72F47B0", VA = "0x1872F5BB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x72F5BE0", Offset = "0x72F47E0", VA = "0x1872F5BE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? DOHGIMCADCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xEFF350", Offset = "0xEFDF50", VA = "0x180EFF350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72F6220", Offset = "0x72F4E20", VA = "0x1872F6220")]
	public OOLGGJEDPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72F6540", Offset = "0x72F5140", VA = "0x1872F6540")]
	internal OOLGGJEDPLG(byte[] LNEJCNPADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x72F5DE0", Offset = "0x72F49E0", VA = "0x1872F5DE0")]
	public static OOLGGJEDPLG JNAJHIOKDFD(byte[] LNEJCNPADCI, DateTime NMMFCFGNPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x72F5740", Offset = "0x72F4340", VA = "0x1872F5740")]
	internal void EBKBPFHBFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72F5940", Offset = "0x72F4540", VA = "0x1872F5940")]
	private void GFBLJIBKEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x72F5480", Offset = "0x72F4080", VA = "0x1872F5480")]
	private DateTime? BDLCPJBGBJB(int HDEKJKJDEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x72F5250", Offset = "0x72F3E50", VA = "0x1872F5250")]
	private void AIEEMONHFHH(int HDEKJKJDEIC, DateTime? BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x72F6000", Offset = "0x72F4C00", VA = "0x1872F6000")]
	private ulong OFBJAFBNBBE(int HDEKJKJDEIC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x72F5680", Offset = "0x72F4280", VA = "0x1872F5680")]
	private void BKPCKNHMKKD(int HDEKJKJDEIC, ulong BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x72F5B20", Offset = "0x72F4720", VA = "0x1872F5B20")]
	private uint GLPHCDBMNHM(int HDEKJKJDEIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x71A9D80", Offset = "0x71A8980", VA = "0x1871A9D80")]
	private static uint LCJHGHFFCOD(uint LGCEHLADNJC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x72F5F40", Offset = "0x72F4B40", VA = "0x1872F5F40")]
	private static ulong LCJHGHFFCOD(ulong LGCEHLADNJC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum KFNEJHELOPF
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum OAOJNOAABJI
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class JAKKJBOBONN
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int MLNFCPKADIN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int OCGDAJPMJGL = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int LHGOEAMEMCM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint LLFMKOGEDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int ACFKAHAHMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int LPNKKPBPIFH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NDMNNFDHECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x72E6E60", Offset = "0x72E5A60", VA = "0x1872E6E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x72E6D70", Offset = "0x72E5970", VA = "0x1872E6D70")]
	public bool BDGMCGKPGAG(BPHIGACOOAN NJPJMMCBKLK, int HCMFNJGJPMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class NEPHFGPCDHA : BPHIGACOOAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket NJPJMMCBKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly LENLHPOGELP DMOHAAMGLGF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short LKAAKHEEKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x72F3C80", Offset = "0x72F2880", VA = "0x1872F3C80", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int GJBOFHGMEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x72F3C60", Offset = "0x72F2860", VA = "0x1872F3C60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint OIEBGAMGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x72F3CA0", Offset = "0x72F28A0", VA = "0x1872F3CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily PDDHLMEOCDH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x543F110", Offset = "0x543DD10", VA = "0x18543F110", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x72F3CE0", Offset = "0x72F28E0", VA = "0x1872F3CE0")]
	public NEPHFGPCDHA(AddressFamily ILBEDIMPIPL, LENLHPOGELP DMOHAAMGLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x72F36A0", Offset = "0x72F22A0", VA = "0x1872F36A0", Slot = "8")]
	public bool DKKEMHOKDPK(IPEndPoint FAGBGHMGAGM, DLBPJDNPOMM GOHGKPMMIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x72F3660", Offset = "0x72F2260", VA = "0x1872F3660", Slot = "9")]
	public int BAKCCFOHKAP(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, int PFHGPMHBODB, IPEndPoint BBAJNEGBECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x72F3570", Offset = "0x72F2170", VA = "0x1872F3570", Slot = "10")]
	public int ACBOOPOPPMG(byte[] HAPOFGGDNGL, EndPoint DFMJDPDNPNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x72F3CC0", Offset = "0x72F28C0", VA = "0x1872F3CC0", Slot = "11")]
	public void JPNNLGMBIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface BPHIGACOOAN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short LKAAKHEEKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int GJBOFHGMEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint OIEBGAMGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily PDDHLMEOCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DKKEMHOKDPK(IPEndPoint FAGBGHMGAGM, DLBPJDNPOMM GOHGKPMMIJN);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int BAKCCFOHKAP(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, int PFHGPMHBODB, IPEndPoint BBAJNEGBECM);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ACBOOPOPPMG(byte[] HAPOFGGDNGL, EndPoint BBAJNEGBECM);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JPNNLGMBIEA();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct GKMDMEDLIKN : IEquatable<GKMDMEDLIKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long MBKPNCEALEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long GNKFKNGILHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long KNLLMEEICPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int EDHDALJLFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int GHNDHAAABOL;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72E6730", Offset = "0x72E5330", VA = "0x1872E6730")]
	public GKMDMEDLIKN(byte[] IHJNIKBKIPL, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72E64C0", Offset = "0x72E50C0", VA = "0x1872E64C0")]
	public GKMDMEDLIKN(Span<byte> IHJNIKBKIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA85600", Offset = "0xA84200", VA = "0x180A85600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72E63D0", Offset = "0x72E4FD0", VA = "0x1872E63D0", Slot = "4")]
	public bool Equals(GKMDMEDLIKN IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72E6410", Offset = "0x72E5010", VA = "0x1872E6410", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DDMPJDMIHMO : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] PEBFHDFOEHM;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HBBJDPKMINI
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void FMJDGDIOPAA(IPEndPoint IHJNIKBKIPL, Span<byte> CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string NMIDMBBPOMD = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int NGKFNBAHFJH = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int EBFPIEKDHIG = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int HICEBCBILAL = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<GKMDMEDLIKN, IPEndPoint> NEKMDDMIFCK;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static FMJDGDIOPAA IAHHLFKDNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int LGFAOHHEGHH;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	internal void AMHJEGKOIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	internal void AFBIKLMHHHL(IPEndPoint BBAJNEGBECM, Span<byte> CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class FDIAJAAKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int AELBLFFKGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
	protected FDIAJAAKIMI(int JCFJPAFHLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJODPDIMLCI(IPEndPoint FAGBGHMGAGM, byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LBLBECEIAEC);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NOCHIBHHPIK(IPEndPoint FAGBGHMGAGM, byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LBLBECEIAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MJDNAKECKKE : FDIAJAAKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] DHCHBFGMFFD;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator PPAMCOMLCOG;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C2C0", Offset = "0x2A3AEC0", VA = "0x182A3C2C0")]
	public MJDNAKECKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72F2F10", Offset = "0x72F1B10", VA = "0x1872F2F10")]
	public void DBINPFHMPBI(IPEndPoint FAGBGHMGAGM, byte[] DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x72F30C0", Offset = "0x72F1CC0", VA = "0x1872F30C0")]
	public void KGBNFPAFPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x72F2A50", Offset = "0x72F1650", VA = "0x1872F2A50", Slot = "4")]
	public override void BJODPDIMLCI(IPEndPoint FAGBGHMGAGM, byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x72F31A0", Offset = "0x72F1DA0", VA = "0x1872F31A0", Slot = "5")]
	public override void NOCHIBHHPIK(IPEndPoint FAGBGHMGAGM, byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LBLBECEIAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct FCPJODPOPGF
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void KPGGNMKFKFO([NoAlias] byte* JGABFPOPJDL, [NoAlias] byte* DHCHBFGMFFD, [NoAlias] byte* GCDBNHMGLCM, int LBLBECEIAEC);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class GAFPPALHHOH
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr ALPIIJJKLJP;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr BHMOHNHIGJE;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x72F7590", Offset = "0x72F6190", VA = "0x1872F7590")]
		[BurstDiscard]
		private static void KDBLHCOCILN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x72F76C0", Offset = "0x72F62C0", VA = "0x1872F76C0")]
		private static IntPtr MIDDNKBGAGL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x72F7820", Offset = "0x72F6420", VA = "0x1872F7820")]
		public static void NOMIPIDOBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		public static void BFHPBJMBKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x72F7350", Offset = "0x72F5F50", VA = "0x1872F7350")]
		public unsafe static void JMBILAAMFIC([NoAlias] byte* JGABFPOPJDL, [NoAlias] byte* DHCHBFGMFFD, [NoAlias] byte* GCDBNHMGLCM, int LBLBECEIAEC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint DHCHBFGMFFD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint GCDBNHMGLCM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint CDNNMOICKKA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint CKBNPDMKBJK[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint HKKJDFCJKDM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint EJCJGHNEODI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint FIEOLDDMGIP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint IEGPDANNCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint DJAGGMPPAPH[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x72E5670", Offset = "0x72E4270", VA = "0x1872E5670")]
	private void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x72E5C70", Offset = "0x72E4870", VA = "0x1872E5C70")]
	private uint OOCGBIGIKIC(uint DNDKHMOJDEM, int CHJDNJBAAFA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x72DECA0", Offset = "0x72DD8A0", VA = "0x1872DECA0")]
	private void HMOIEHFCGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x72DEA90", Offset = "0x72DD690", VA = "0x1872DEA90")]
	private void EIPEJPLBHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x72DED50", Offset = "0x72DD950", VA = "0x1872DED50")]
	private void JDIGHEABBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x72DEDE0", Offset = "0x72DD9E0", VA = "0x1872DEDE0")]
	private void NAAENOOOEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72E5610", Offset = "0x72E4210", VA = "0x1872E5610")]
	private void FJOOFEEHFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x72E56F0", Offset = "0x72E42F0", VA = "0x1872E56F0")]
	private unsafe void KCHCFCJAECK(byte* JGABFPOPJDL, uint* DHCHBFGMFFD, uint* GCDBNHMGLCM, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x72E5B10", Offset = "0x72E4710", VA = "0x1872E5B10")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NFGMODHPFGI([NoAlias] byte* JGABFPOPJDL, [NoAlias] byte* DHCHBFGMFFD, [NoAlias] byte* GCDBNHMGLCM, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x72E5B90", Offset = "0x72E4790", VA = "0x1872E5B90")]
	public static void NFGMODHPFGI(Span<byte> JGABFPOPJDL, Span<byte> DHCHBFGMFFD, Span<byte> GCDBNHMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x72E54A0", Offset = "0x72E40A0", VA = "0x1872E54A0")]
	public static void CGLADIPFLAO(Span<byte> JGABFPOPJDL, Span<byte> DHCHBFGMFFD, Span<byte> GCDBNHMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72E55A0", Offset = "0x72E41A0", VA = "0x1872E55A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DHPHMHGNNFE([NoAlias] byte* JGABFPOPJDL, [NoAlias] byte* DHCHBFGMFFD, [NoAlias] byte* GCDBNHMGLCM, int LBLBECEIAEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x72F79D0", Offset = "0x72F65D0", VA = "0x1872F79D0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
