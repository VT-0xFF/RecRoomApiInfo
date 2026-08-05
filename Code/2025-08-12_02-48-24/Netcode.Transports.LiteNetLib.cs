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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OHMIBIKDNLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum NKJEIBEJGEH
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
		private NetworkManager EPAMHNPMLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ADJMBJFADKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, NFJLBNDHHEJ> MKCKEFBJKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IEAGFOENGPO DNGGLKPGCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch MONLFACNMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] CKHBDOKNEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NKJEIBEJGEH AKIAOOCNKIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int MGHEKAMLKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7627D80", Offset = "0x7626380", VA = "0x187627D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong GKNIBKLLALG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool DCCCCNPNIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7627D60", Offset = "0x7626360", VA = "0x187627D60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7627350", Offset = "0x7625950", VA = "0x187627350")]
		public void RecRoom_SetEncryptionInfo(ulong MDMKGFKLILH, byte[] HFLDIIIPBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7627330", Offset = "0x7625930", VA = "0x187627330")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7627200", Offset = "0x7625800", VA = "0x187627200")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7627C60", Offset = "0x7626260", VA = "0x187627C60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7627470", Offset = "0x7625A70", VA = "0x187627470", Slot = "6")]
		public override void Send(ulong AFJLFPJABFP, ArraySegment<byte> DAJAOHIJHHL, NetworkDelivery DMLKLEMLGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76272F0", Offset = "0x76258F0", VA = "0x1876272F0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong AFJLFPJABFP, [Out] ArraySegment<byte> KMJEOGEJMHB, [Out] float GGPFOEBILIA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7627760", Offset = "0x7625D60", VA = "0x187627760", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7627A80", Offset = "0x7626080", VA = "0x187627A80", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7626820", Offset = "0x7624E20", VA = "0x187626820", Slot = "11")]
		public override void DisconnectRemoteClient(ulong AFJLFPJABFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7626730", Offset = "0x7624D30", VA = "0x187626730", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76269A0", Offset = "0x7624FA0", VA = "0x1876269A0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong AFJLFPJABFP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76276F0", Offset = "0x7625CF0", VA = "0x1876276F0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7626B10", Offset = "0x7625110", VA = "0x187626B10", Slot = "15")]
		public override void Initialize([Optional] NetworkManager EPAMHNPMLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7626A40", Offset = "0x7625040", VA = "0x187626A40")]
		private LFBAPKFNLCH IOEMAGCDPBM(NetworkDelivery EHLAHNIAPLD)
		{
			return default(LFBAPKFNLCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7626D80", Offset = "0x7625380", VA = "0x187626D80", Slot = "16")]
		private void LALNGACDLJH(NFJLBNDHHEJ LJADDECHGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7627130", Offset = "0x7625730", VA = "0x187627130", Slot = "17")]
		private void NMMHEHNJIMA(NFJLBNDHHEJ LJADDECHGEI, GOEBCPFMAFJ DCOBKKEELJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "18")]
		private void HOOHEEOAMEH(IPEndPoint NPCGBPKNKJM, SocketError PJLNOFHJDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7626F20", Offset = "0x7625520", VA = "0x187626F20", Slot = "19")]
		private void NHODDGFBNNN(NFJLBNDHHEJ LJADDECHGEI, CMIKOLPIJAD EMPLJNKCONI, byte GGOMLHLCBDL, LFBAPKFNLCH JCBKIHOKMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7626E40", Offset = "0x7625440", VA = "0x187626E40")]
		private void LKLNJPLGHCO(int MLMBLBFOLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "20")]
		private void AOAAKMPLKMN(IPEndPoint ACGMABMGGIC, CMIKOLPIJAD EMPLJNKCONI, DPOLDMPMIDD OIDGPPJPELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "21")]
		private void DNCLFFFKMNN(NFJLBNDHHEJ LJADDECHGEI, int JBAOKIPNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7626D20", Offset = "0x7625320", VA = "0x187626D20", Slot = "22")]
		private void JILPNEBDBND(CKKMAMOBJJA MLCIBEJGDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7626950", Offset = "0x7624F50", VA = "0x187626950")]
		private ulong FCAMKBCOAJE(NFJLBNDHHEJ LJADDECHGEI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7626930", Offset = "0x7624F30", VA = "0x187626930")]
		private ulong FCAMKBCOAJE(ulong AFJLFPJABFP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7626980", Offset = "0x7624F80", VA = "0x187626980")]
		private static int FEKJFEOOHFP(float AEKHJIAHDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7627C80", Offset = "0x7626280", VA = "0x187627C80")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7626700", Offset = "0x7624D00", VA = "0x187626700")]
		[CompilerGenerated]
		private void AKMOCLJNDMK(ulong PICJBHIOFEI, int IICFFMNEHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7626700", Offset = "0x7624D00", VA = "0x187626700")]
		[CompilerGenerated]
		private void FBKDKKLJHBH(ulong PICJBHIOFEI, int IICFFMNEHKK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class KMAKCNBMDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly NFJLBNDHHEJ IKGCLBNDGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<COEJBMDFDGK> DEKJFKJFCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int KGBFIDCHNPF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OOJDGHJBFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7625AE0", Offset = "0x76240E0", VA = "0x187625AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7625C10", Offset = "0x7624210", VA = "0x187625C10")]
	protected KMAKCNBMDPK(NFJLBNDHHEJ LJADDECHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7625BB0", Offset = "0x76241B0", VA = "0x187625BB0")]
	public void LKDABJDLLPB(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7625B30", Offset = "0x7624130", VA = "0x187625B30")]
	protected void GEMHFMOINBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7625AA0", Offset = "0x76240A0", VA = "0x187625AA0")]
	public bool BBIDOKLLBGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool AMEFLGHOOIF();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AJHCCPFMGGH(COEJBMDFDGK KJKMHJABJDF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum AIPFLMNGPNL
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
public class CKKMAMOBJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IEAGFOENGPO BCOHMHEAAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int IJOJKMBMHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal JKJLCCFLEOH EMNPCLLMEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint OPFIFMNKPDM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal AIPFLMNGPNL AJMNBCHCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
		[CompilerGenerated]
		get
		{
			return default(AIPFLMNGPNL);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEDCE80", Offset = "0xEDB480", VA = "0x180EDCE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7617650", Offset = "0x7615C50", VA = "0x187617650")]
	internal void GDPNGGCJCLF(JKJLCCFLEOH HIIAEFJKHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76176B0", Offset = "0x7615CB0", VA = "0x1876176B0")]
	private bool PDFFLLAPMLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76176E0", Offset = "0x7615CE0", VA = "0x1876176E0")]
	internal CKKMAMOBJJA(IPEndPoint ACGMABMGGIC, JKJLCCFLEOH CDMADIBJLGI, IEAGFOENGPO APJDOJOFNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76175F0", Offset = "0x7615BF0", VA = "0x1876175F0")]
	public NFJLBNDHHEJ DNNGBJIFDHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DPOLDMPMIDD
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum BBEFKGJDEMA
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
public struct GOEBCPFMAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BBEFKGJDEMA BECIJFAAEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError MAIMNGMKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CMIKOLPIJAD GGDJNMGAACO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OHMIBIKDNLN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMELFPBNGNM(NFJLBNDHHEJ LJADDECHGEI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHECGEKMNLG(NFJLBNDHHEJ LJADDECHGEI, GOEBCPFMAFJ DCOBKKEELJK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCHNBFILGHM(IPEndPoint NPCGBPKNKJM, SocketError PJLNOFHJDNG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABKFLJLECGJ(NFJLBNDHHEJ LJADDECHGEI, CMIKOLPIJAD EMPLJNKCONI, byte GGOMLHLCBDL, LFBAPKFNLCH JCBKIHOKMDK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLOGCJOBJMC(IPEndPoint ACGMABMGGIC, CMIKOLPIJAD EMPLJNKCONI, DPOLDMPMIDD OIDGPPJPELM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPEGHGNIIPJ(NFJLBNDHHEJ LJADDECHGEI, int JBAOKIPNIID);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPFKDLCLHMC(CKKMAMOBJJA MLCIBEJGDFC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FFGNCBBEOHB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKOAGKJPOAG(NFJLBNDHHEJ LJADDECHGEI, object JMMNGKHPIEI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AMMHMHNOBBL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLGPFABCFEM(JLDDFINDMBO KJKMHJABJDF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HMBIFCMKEBG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCBPIFAKHKA(NFJLBNDHHEJ LJADDECHGEI, IPEndPoint FIMBJIHLPPL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JKJLCCFLEOH
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int NLNHBALBNHD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long PDIDKNFKGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte DGPLEHHGJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] GFMOJEBDDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly BLMJBPKEHLN AIJFAAIOPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int GKAIGIHCONG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7622A00", Offset = "0x7621000", VA = "0x187622A00")]
	private JKJLCCFLEOH(long KBCJILFKLMH, byte LEJLKFAAEOC, int DLICMGKJENE, byte[] JMHPHAOFJGA, BLMJBPKEHLN DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7622780", Offset = "0x7620D80", VA = "0x187622780")]
	public static int GBPFPNFIMMG(COEJBMDFDGK KJKMHJABJDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x76227E0", Offset = "0x7620DE0", VA = "0x1876227E0")]
	public static JKJLCCFLEOH OLMOAIHLKEB(COEJBMDFDGK KJKMHJABJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76225A0", Offset = "0x7620BA0", VA = "0x1876225A0")]
	public static COEJBMDFDGK EPAKDGKKJNE(FBDJBJOODID LJOCKEPNDEK, SocketAddress MNEPNKOCFJJ, long HFMEHMLGNGB, int DLICMGKJENE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class ACBOKNNOLCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long PDIDKNFKGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte DGPLEHHGJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int GKAIGIHCONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool KCOPJPMBJDO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7615300", Offset = "0x7613900", VA = "0x187615300")]
	private ACBOKNNOLCP(long KBCJILFKLMH, byte LEJLKFAAEOC, int GDNEDICMHHH, bool EPCKGHCMFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76151B0", Offset = "0x76137B0", VA = "0x1876151B0")]
	public static ACBOKNNOLCP OLMOAIHLKEB(COEJBMDFDGK KJKMHJABJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7614FC0", Offset = "0x76135C0", VA = "0x187614FC0")]
	public static COEJBMDFDGK EPAKDGKKJNE(long HFMEHMLGNGB, byte CGIBKJCEEPB, int DDJOPBNGHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76150B0", Offset = "0x76136B0", VA = "0x1876150B0")]
	public static COEJBMDFDGK NNEAOHLMACO(NFJLBNDHHEJ LJADDECHGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum OHEDAOBLJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GFDEBDNHENE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEACBFMPGNM(IPEndPoint HFJPNFLBNPK, IPEndPoint ACGMABMGGIC, string HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGEKCOEFPNK(IPEndPoint LBGMJALLLCI, OHEDAOBLJAL EHLAHNIAPLD, string HNGIMMGBLII);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LOMICEOFGMK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FIHEAJFIMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint MCMAODGLPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint OPFIFMNKPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string CBGNCAEJLOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct HHIILKMOMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint IHMHPHNIKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OHEDAOBLJAL MONFNOPPPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string CBGNCAEJLOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class CCDBJBBOBIC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint AFBJHFMFJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CBGNCAEJLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CCDBJBBOBIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class GPJPCFGGNPI
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint AFBJHFMFJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint ONFBHFDMOMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CBGNCAEJLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GPJPCFGGNPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class FIMNNJFOMHB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CBGNCAEJLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool COENOKAFEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FIMNNJFOMHB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IEAGFOENGPO IACNGMAHGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<FIHEAJFIMEP> CHBPMDPOMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<HHIILKMOMAN> KGGNGEFPLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly BLMJBPKEHLN CGCNFHIGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FBDJBJOODID HCKMIAPJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NKMJEENOLOJ BNGBBLHLLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private GFDEBDNHENE HFOKAMIIDCC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int JNFNKLODEKK = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool GPCKAPPGBAA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76262B0", Offset = "0x76248B0", VA = "0x1876262B0")]
	internal LOMICEOFGMK(IEAGFOENGPO KGBIPOLKOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7625E10", Offset = "0x7624410", VA = "0x187625E10")]
	internal void GIHOKNLABAO(IPEndPoint BEPHJNNPNPG, COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AB20", Offset = "0x3E89120", VA = "0x183E8AB20")]
	private void NMMCFIGJEED<T>(T KJKMHJABJDF, IPEndPoint LKEAKCADNOO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7625F90", Offset = "0x7624590", VA = "0x187625F90")]
	private void NEACBFMPGNM(CCDBJBBOBIC KNKOOHFDGPH, IPEndPoint BEPHJNNPNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7625CB0", Offset = "0x76242B0", VA = "0x187625CB0")]
	private void BCFDGDHPDGO(GPJPCFGGNPI KNKOOHFDGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7626120", Offset = "0x7624720", VA = "0x187626120")]
	private void NMIHOBGNCFC(FIMNNJFOMHB KNKOOHFDGPH, IPEndPoint BEPHJNNPNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LFBAPKFNLCH : byte
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
public enum PBCDAOFJMJL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OPHGCDBBLAA
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] JHGHJAGPCCA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int CCHEGOCKDDO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int FJKINBDDEFH;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NBNHIHEMGAP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7615B70", Offset = "0x7614170", VA = "0x187615B70")]
	public NBNHIHEMGAP(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AMCEJNJHOFO : NBNHIHEMGAP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7615B70", Offset = "0x7614170", VA = "0x187615B70")]
	public AMCEJNJHOFO(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum JLFBDBHOHMC
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
public interface LGNMIHHPNCA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFEGDHICAPG(JLFBDBHOHMC JFPIGDOMMNL, string IAKFGDELOKN, params object[] KGIPMLMDBBA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class CILIBAHFFDP
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static LGNMIHHPNCA ANOANIDMAHD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object LBJFEKKGEEP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76172B0", Offset = "0x76158B0", VA = "0x1876172B0")]
	private static void LNFKFAIOJPC(JLFBDBHOHMC AOIDGANHHJD, string IAKFGDELOKN, params object[] KGIPMLMDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76171F0", Offset = "0x76157F0", VA = "0x1876171F0")]
	internal static void FHFMBPDDNDN(string IAKFGDELOKN, params object[] KGIPMLMDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7617250", Offset = "0x7615850", VA = "0x187617250")]
	internal static void GLLECHEEAPB(string IAKFGDELOKN, params object[] KGIPMLMDBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76174E0", Offset = "0x7615AE0", VA = "0x1876174E0")]
	internal static void MIMPCPDCMJM(string IAKFGDELOKN, params object[] KGIPMLMDBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum CGALCMLEFDB
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CMIKOLPIJAD : BLMJBPKEHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private COEJBMDFDGK BHOGDNKPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEAGFOENGPO IGGJINLLIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly KCPAMDNBBKF CILFKMGIAJN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7617870", Offset = "0x7615E70", VA = "0x187617870")]
	internal CMIKOLPIJAD(IEAGFOENGPO BIAJFLEJGFD, KCPAMDNBBKF OKPCNKDLIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7617750", Offset = "0x7615D50", VA = "0x187617750")]
	internal void CMNEJBHHIOO(COEJBMDFDGK KJKMHJABJDF, int EBKIKKEDHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x76177F0", Offset = "0x7615DF0", VA = "0x1876177F0")]
	internal void NOAPAJEOBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76177C0", Offset = "0x7615DC0", VA = "0x1876177C0")]
	public void HHIAPGBGEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class KCPAMDNBBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum NHLDCBPFHKG
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
	public KCPAMDNBBKF PELAIAPNCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NHLDCBPFHKG MONFNOPPPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NFJLBNDHHEJ IKGCLBNDGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint OPFIFMNKPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object CIPGDJNCLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int JKFNGHLAKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError NNGFDELEFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public BBEFKGJDEMA MMLMDOIPCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public CKKMAMOBJJA MMHEAGONLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public LFBAPKFNLCH CIEHNAFJMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte PJBDJEIJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly CMIKOLPIJAD NPIHIEMMGFM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7623E10", Offset = "0x7622410", VA = "0x187623E10")]
	public KCPAMDNBBKF(IEAGFOENGPO BIAJFLEJGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IEAGFOENGPO : IEnumerable<NFJLBNDHHEJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class GGEDJHNNNPA : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7619730", Offset = "0x7617D30", VA = "0x187619730", Slot = "4")]
		public bool Equals(IPEndPoint POMPNNDHCKO, IPEndPoint JLAHKMCOIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45DEB90", Offset = "0x45DD190", VA = "0x1845DEB90", Slot = "5")]
		public int GetHashCode(IPEndPoint NDBJJGOPOFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GGEDJHNNNPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct BJCENEGOHAC : IEnumerator<NFJLBNDHHEJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly NFJLBNDHHEJ HMANOGEOOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private NFJLBNDHHEJ OIFJHDKBHFC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NFJLBNDHHEJ MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB41580", Offset = "0xB3FB80", VA = "0x180B41580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1CE8E70", Offset = "0x1CE7470", VA = "0x181CE8E70")]
		public BJCENEGOHAC(NFJLBNDHHEJ JHCGOEHIHDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7615CE0", Offset = "0x76142E0", VA = "0x187615CE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7615D30", Offset = "0x7614330", VA = "0x187615D30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread PPENEKLJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CFDEJJPNIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool INBPNFBCIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private LLKGOCAGJAA HKNHJEAEKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent ABKNNGOLECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<KCPAMDNBBKF> PIGMPBNJHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<KCPAMDNBBKF> PMBJGBOAPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private KCPAMDNBBKF FIOKBCCEBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly OHMIBIKDNLN BPJOMADKAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FFGNCBBEOHB BLMCPJPHIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AMMHMHNOBBL FENDGFALADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly HMBIFCMKEBG PBDHHHHFLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, NFJLBNDHHEJ> EMIMGOELMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, CKKMAMOBJJA> FJKIFLAOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, MACDIBENICD> PDPEKIFFEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim NHPBNNNJOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private NFJLBNDHHEJ KNLLDIGAJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int CDBCEFIEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<NFJLBNDHHEJ> PPPEPAGKFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NFJLBNDHHEJ[] BNOJJCDEOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KDIFMELOCKD EDJEAANGEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int HJBIOOMLBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> JIEKNGEHKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte ONPDBGMEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object HEEAAMMMEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool EAEIPALNGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool JKNGKNHKBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FGJMBOGJBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int FHEFKHCGFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int FNACPCPNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int NMHPFOMOCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HBBBJHJLNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool BICELAJIDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KOAIEHJGMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int MMEHELFADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int DLEGIJMICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool GPCKAPPGBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool CNCDCFCGION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool MEEPIGEBHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool HEAICEAJCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int HMDNCNJGJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int DGJGACPAKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool EIKHAAGALAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly OBNDKDBIDMO IINLDEGNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KEMNANLHJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly LOMICEOFGMK CAFDAGEFMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool HLDCOJDJKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public CGALCMLEFDB JJPLOOLHHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int EJEOABMEGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool FBHBLCEINIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool OOAKAKMPHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool CIAOHNGDIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool GABJHLCCGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private COEJBMDFDGK MMBKNMMPPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int ECOENBCEOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object LNAJAFGJHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private COEJBMDFDGK GOGIOADHCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int GPJGJLGNPMO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int OCCJNLHFHPK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int IEJCMPMPJBO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IGDNAEKMOLA JMEKDACNPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IGDNAEKMOLA NLPPFAOJJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread PAOGDPACCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread DJIFMLGGLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint CIALFPMGMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint PDHFAHCPCCD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] OMGCINGIHEF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] LLBKCFCDPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<GDBPCIBCJOC, IPEndPoint> IKOCBPLNABP;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress KOOAGMLLDLG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool BFPJGPJMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int BHFIGEPAEJP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AAJCEAMCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC01300", Offset = "0xBFF900", VA = "0x180C01300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC0BED0", Offset = "0xC0A4D0", VA = "0x180C0BED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GEONOKKDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1830B90", Offset = "0x182F190", VA = "0x181830B90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x214C1B0", Offset = "0x214A7B0", VA = "0x18214C1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte DEKPFCGHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10B7D80", Offset = "0x10B6380", VA = "0x1810B7D80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int KONPEIPIHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x761D7D0", Offset = "0x761BDD0", VA = "0x18761D7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short HCCMKFMFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7620190", Offset = "0x761E790", VA = "0x187620190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NFJLBNDHHEJ.BNNKLBOJHOG AKPMNNANOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x761F860", Offset = "0x761DE60", VA = "0x18761F860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x761D850", Offset = "0x761BE50", VA = "0x18761D850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x761BB80", Offset = "0x761A180", VA = "0x18761BB80")]
	public void DBCEDMEAOCK(IPEndPoint NPCGBPKNKJM, byte[] HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x761DC50", Offset = "0x761C250", VA = "0x18761DC50")]
	public void FPFCBCEFAGF(IPEndPoint NPCGBPKNKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x761A570", Offset = "0x7618B70", VA = "0x18761A570")]
	private bool ADALIMMLCFC(IPEndPoint NPCGBPKNKJM, [Out] NFJLBNDHHEJ LJADDECHGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7621040", Offset = "0x761F640", VA = "0x187621040")]
	private void NCDLEPJFIPJ(NFJLBNDHHEJ LJADDECHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x761D7F0", Offset = "0x761BDF0", VA = "0x18761D7F0")]
	private void EPIAMGAOGEM(NFJLBNDHHEJ LJADDECHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x761E6C0", Offset = "0x761CCC0", VA = "0x18761E6C0")]
	private void GOLOLCDNLCP(NFJLBNDHHEJ LJADDECHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7621F40", Offset = "0x7620540", VA = "0x187621F40")]
	public IEAGFOENGPO(OHMIBIKDNLN APJDOJOFNPK, [Optional] KDIFMELOCKD BLDOKDNGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7620960", Offset = "0x761EF60", VA = "0x187620960")]
	internal void MDPNCEMPNIE(NFJLBNDHHEJ MFPKEEMOAPD, int JBAOKIPNIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7621380", Offset = "0x761F980", VA = "0x187621380")]
	internal void NDDMMHKFBHF(NFJLBNDHHEJ MFPKEEMOAPD, object JMMNGKHPIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x761D190", Offset = "0x761B790", VA = "0x18761D190")]
	internal void DOPCDNCBIIJ(NFJLBNDHHEJ LJADDECHGEI, BBEFKGJDEMA DAAMNHJEIGF, SocketError KHDHHJIKMFE, COEJBMDFDGK KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7620540", Offset = "0x761EB40", VA = "0x187620540")]
	private void MDKEKJJJJAE(NFJLBNDHHEJ LJADDECHGEI, BBEFKGJDEMA DAAMNHJEIGF, SocketError KHDHHJIKMFE, bool MKJGBAFLMBJ, byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FEEKNNBMJMM, COEJBMDFDGK KJOIOABMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x761ABB0", Offset = "0x76191B0", VA = "0x18761ABB0")]
	private void ANCNIONLOMD(KCPAMDNBBKF.NHLDCBPFHKG EHLAHNIAPLD, [Optional] NFJLBNDHHEJ LJADDECHGEI, [Optional] IPEndPoint ACGMABMGGIC, SocketError DCHHIMINIKN = SocketError.Success, int JBAOKIPNIID = 0, BBEFKGJDEMA IJJCDGGJELP = BBEFKGJDEMA.ConnectionFailed, [Optional] CKKMAMOBJJA JFFPCPGMCDC, LFBAPKFNLCH JCBKIHOKMDK = LFBAPKFNLCH.Unreliable, byte GGOMLHLCBDL = 0, [Optional] COEJBMDFDGK FKFFJMDHIDB, [Optional] object JMMNGKHPIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x761DF20", Offset = "0x761C520", VA = "0x18761DF20")]
	private void GNKLHDPNNPE(KCPAMDNBBKF OKPCNKDLIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x761BA70", Offset = "0x761A070", VA = "0x18761BA70")]
	internal void DBAPNEJLGBD(KCPAMDNBBKF OKPCNKDLIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x761D900", Offset = "0x761BF00", VA = "0x18761D900")]
	private void FNKFEPDFNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7620D20", Offset = "0x761F320", VA = "0x187620D20")]
	private void MNPENFCPGHI(int CACGMMJFJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x761E9A0", Offset = "0x761CFA0", VA = "0x18761E9A0")]
	internal NFJLBNDHHEJ HCNIEEGCADC(CKKMAMOBJJA MLCIBEJGDFC, byte[] GLPDHONFMFH, int NEIBMENBNPA, int FODNOPLPBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7621B70", Offset = "0x7620170", VA = "0x187621B70")]
	private int PHGGDGIJFMA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x761B160", Offset = "0x7619760", VA = "0x18761B160")]
	private void BJHDHFNGAAP(IPEndPoint ACGMABMGGIC, NFJLBNDHHEJ CIBOPKEPGFN, JKJLCCFLEOH IHPFEPKMFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x761BDA0", Offset = "0x761A3A0", VA = "0x18761BDA0")]
	private void DKLMAMKMPHJ(COEJBMDFDGK KJKMHJABJDF, IPEndPoint ACGMABMGGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x761B790", Offset = "0x7619D90", VA = "0x18761B790")]
	internal void CLOPPAAHLBB(COEJBMDFDGK KJKMHJABJDF, LFBAPKFNLCH GMJJMMCAFFM, byte GGOMLHLCBDL, int EBKIKKEDHPP, NFJLBNDHHEJ MFPKEEMOAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7620180", Offset = "0x761E780", VA = "0x187620180")]
	public bool JKGHENBEODP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x761F910", Offset = "0x761DF10", VA = "0x18761F910")]
	public bool JKGHENBEODP(IPAddress NOICLIMEDFM, IPAddress BFDGHAAHHIL, int DJOEAGDKAGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7620100", Offset = "0x761E700", VA = "0x187620100")]
	public bool JKGHENBEODP(int DJOEAGDKAGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7621770", Offset = "0x761FD70", VA = "0x187621770")]
	public void NPDNLOKLELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x761A9F0", Offset = "0x7618FF0", VA = "0x18761A9F0")]
	public NFJLBNDHHEJ AFPBJEJDAOH(string GOOIAGHPJCD, int DJOEAGDKAGH, string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x761AAD0", Offset = "0x76190D0", VA = "0x18761AAD0")]
	public NFJLBNDHHEJ AFPBJEJDAOH(string GOOIAGHPJCD, int DJOEAGDKAGH, FBDJBJOODID PEIMIIPDHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x761A610", Offset = "0x7618C10", VA = "0x18761A610")]
	public NFJLBNDHHEJ AFPBJEJDAOH(IPEndPoint LKEAKCADNOO, FBDJBJOODID PEIMIIPDHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76209B0", Offset = "0x761EFB0", VA = "0x1876209B0")]
	public void MNEFMGBPPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76209C0", Offset = "0x761EFC0", VA = "0x1876209C0")]
	public void MNEFMGBPPHF(bool EELPFEPDMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x761D1D0", Offset = "0x761B7D0", VA = "0x18761D1D0")]
	public void EEGGJEGDFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x761D280", Offset = "0x761B880", VA = "0x18761D280")]
	public void EEGGJEGDFGG(byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7620500", Offset = "0x761EB00", VA = "0x187620500")]
	public void MDKEKJJJJAE(NFJLBNDHHEJ LJADDECHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76204C0", Offset = "0x761EAC0", VA = "0x1876204C0")]
	public void MDKEKJJJJAE(NFJLBNDHHEJ LJADDECHGEI, byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7621D60", Offset = "0x7620360", VA = "0x187621D60", Slot = "4")]
	private IEnumerator<NFJLBNDHHEJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7621DF0", Offset = "0x76203F0", VA = "0x187621DF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x761B070", Offset = "0x7619670", VA = "0x18761B070")]
	private COEJBMDFDGK BCIHIIHNAFF(OBEEJKKLDCB BJBANDBIGLN, int MLMBLBFOLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x761AF90", Offset = "0x7619590", VA = "0x18761AF90")]
	private COEJBMDFDGK BCIHIIHNAFF(OBEEJKKLDCB BJBANDBIGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7621920", Offset = "0x761FF20", VA = "0x187621920")]
	internal COEJBMDFDGK PFJHBKEHLPL(int MLMBLBFOLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7620250", Offset = "0x761E850", VA = "0x187620250")]
	internal void MDABLOOMMJN(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7621E80", Offset = "0x7620480", VA = "0x187621E80")]
	static IEAGFOENGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xC01300", Offset = "0xBFF900", VA = "0x180C01300")]
	private bool MBMNEAKACJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x761DDA0", Offset = "0x761C3A0", VA = "0x18761DDA0")]
	private void GIEACEILJIM(IPEndPoint OLCIPNMCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7621BF0", Offset = "0x76201F0", VA = "0x187621BF0")]
	private void PMHJJCECIFE(IPEndPoint OLCIPNMCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x761D350", Offset = "0x761B950", VA = "0x18761D350")]
	private bool EELINIKIPDB(SocketException JLPOJCLEBPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x761EFC0", Offset = "0x761D5C0", VA = "0x18761EFC0")]
	private void HIFIHFJBFCI(LLKGOCAGJAA KGBIPOLKOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x761D500", Offset = "0x761BB00", VA = "0x18761D500")]
	private void EGHPLACONDO(IGDNAEKMOLA KGBIPOLKOGM, EndPoint LFHBNOGGJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76213D0", Offset = "0x761F9D0", VA = "0x1876213D0")]
	private void NFAFDEDAFKP(object BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x761F930", Offset = "0x761DF30", VA = "0x18761F930")]
	public bool JKGHENBEODP(IPAddress NOICLIMEDFM, IPAddress BFDGHAAHHIL, int DJOEAGDKAGH, bool LGKOGGAMCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x761EFE0", Offset = "0x761D5E0", VA = "0x18761EFE0")]
	internal int HPAHMFBNGDK(COEJBMDFDGK KJKMHJABJDF, IPEndPoint ACGMABMGGIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x761F820", Offset = "0x761DE20", VA = "0x18761F820")]
	internal int IJELFBNBPAK(COEJBMDFDGK KJKMHJABJDF, IPEndPoint ACGMABMGGIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x761F040", Offset = "0x761D640", VA = "0x18761F040")]
	internal int IJELFBNBPAK(byte[] IFEHDCDCFPK, int NEIBMENBNPA, int FODNOPLPBPI, IPEndPoint ACGMABMGGIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x761B610", Offset = "0x7619C10", VA = "0x18761B610")]
	internal void BJLKHPACHLG(bool MGJLGCBNIPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum OBEEJKKLDCB : byte
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
internal sealed class COEJBMDFDGK
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int ONENFPEOCBH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] NCAMFPILJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] BKCOPAPLPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int OJPHAFPPPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object CIPGDJNCLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public COEJBMDFDGK PELAIAPNCNJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public OBEEJKKLDCB LPHPDCKDOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7617BB0", Offset = "0x76161B0", VA = "0x187617BB0")]
		get
		{
			return default(OBEEJKKLDCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7617E30", Offset = "0x7616430", VA = "0x187617E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte DGPLEHHGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7617E70", Offset = "0x7616470", VA = "0x187617E70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7617EA0", Offset = "0x76164A0", VA = "0x187617EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort BAHFPIOCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x76179C0", Offset = "0x7615FC0", VA = "0x1876179C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7617C40", Offset = "0x7616240", VA = "0x187617C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AJAAIKDJOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76178C0", Offset = "0x7615EC0", VA = "0x1876178C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte KOCLNIIALEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7617E00", Offset = "0x7616400", VA = "0x187617E00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76178F0", Offset = "0x7615EF0", VA = "0x1876178F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DKIELOLOKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7617BE0", Offset = "0x76161E0", VA = "0x187617BE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7617920", Offset = "0x7615F20", VA = "0x187617920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort EJLLCGECMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7617B50", Offset = "0x7616150", VA = "0x187617B50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7617CC0", Offset = "0x76162C0", VA = "0x187617CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort HBBJGFPLLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7617960", Offset = "0x7615F60", VA = "0x187617960")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7617C80", Offset = "0x7616280", VA = "0x187617C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7617EE0", Offset = "0x76164E0", VA = "0x187617EE0")]
	static COEJBMDFDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7617A20", Offset = "0x7616020", VA = "0x187617A20")]
	public void GDKOMCDFKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76181C0", Offset = "0x76167C0", VA = "0x1876181C0")]
	public COEJBMDFDGK(int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7618230", Offset = "0x7616830", VA = "0x187618230")]
	public COEJBMDFDGK(OBEEJKKLDCB BJBANDBIGLN, int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7617D90", Offset = "0x7616390", VA = "0x187617D90")]
	public static int NLJCGCBEHCG(OBEEJKKLDCB BJBANDBIGLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7617D00", Offset = "0x7616300", VA = "0x187617D00")]
	public int NLJCGCBEHCG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7617A50", Offset = "0x7616050", VA = "0x187617A50")]
	public bool GFBNHBOPLJO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum MDIGBDMEBON : byte
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
internal enum DGNIOOPHNEJ
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
internal enum EIGJJPCBDGM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum IDCHJJPIHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NFJLBNDHHEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MCLDPHIMHFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public COEJBMDFDGK[] EEGAPEEGMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int GLJHDGEDKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int NIACOGMONNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte KOCLNIIALEE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MCLDPHIMHFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void BNNKLBOJHOG(ulong PICJBHIOFEI, int IICFFMNEHKK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int EHFAHCGDEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FHLHADMNPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int AINAHDCEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double DCBHKAOLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int HEHFBCLIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int CGFJJNHGMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int GMNNNCGAODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch CMBCCLBDKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int BHDGFADKNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long BIDGNMFIJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object LMMKFPDBKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal NFJLBNDHHEJ LGEOHKMEPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal NFJLBNDHHEJ JNJEBAIJLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<COEJBMDFDGK> CBDKBAOLPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<KMAKCNBMDPK> ALEGJBMKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly KMAKCNBMDPK[] HEPKFODEEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int AEAECIGMHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int FHGKACIGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool KNCHPINHGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int FPPAHEFPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int JGPJEGMAHCN;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int PIEHILGNGHL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int BBCAFGIPDMN = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object OBKKLDKKDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int DNMGKADGPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, MCLDPHIMHFH> ACANEJBGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> FOHGNHCMIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly COEJBMDFDGK PBDNICDOFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int KJAMHNGOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int IOPFCIAODGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint ECFHCADDMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int CEFMJGKELNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int PHFKEPLIEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long DFFGHNIAFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte GDIDKOIBPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private MDIGBDMEBON IMPODBDJPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private COEJBMDFDGK OPKECOMIGHE;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int HIMEFABJBEH = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int JGABNNDFDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly COEJBMDFDGK CKDDAGCNLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly COEJBMDFDGK MGGLDEFPMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly COEJBMDFDGK GCEPEIIBFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly COEJBMDFDGK GKLOMEBCDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private PBCDAOFJMJL MOLHFFPBJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly IEAGFOENGPO NEBCKCMOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int AFPIOPNCMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object MKNFAJBBNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly OBNDKDBIDMO IINLDEGNKOD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte ICIOODKFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB66250", Offset = "0xB64850", VA = "0x180B66250")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7629300", Offset = "0x7627900", VA = "0x187629300")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint FACGFNJGOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB66200", Offset = "0xB64800", VA = "0x180B66200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MDIGBDMEBON NEJKDAIILDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB65E20", Offset = "0xB64420", VA = "0x180B65E20")]
		get
		{
			return default(MDIGBDMEBON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long BMNIKDABAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA9F130", Offset = "0xA9D730", VA = "0x180A9F130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GKBMDIMEFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1830B90", Offset = "0x182F190", VA = "0x181830B90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x214C1B0", Offset = "0x214A7B0", VA = "0x18214C1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LDCLJKCHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x762A880", Offset = "0x7628E80", VA = "0x18762A880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int NBLDOOPCJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double IALOCKEKLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A216E0", Offset = "0x2A1FCE0", VA = "0x182A216E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BNNKLBOJHOG AKPMNNANOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x762A530", Offset = "0x7628B30", VA = "0x18762A530")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7629920", Offset = "0x7627F20", VA = "0x187629920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x762BCF0", Offset = "0x762A2F0", VA = "0x18762BCF0")]
	internal NFJLBNDHHEJ(IEAGFOENGPO DOILLNCNPKA, IPEndPoint ACGMABMGGIC, int JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7628990", Offset = "0x7626F90", VA = "0x187628990")]
	internal void BPFGEPPGCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x762BCC0", Offset = "0x762A2C0", VA = "0x18762BCC0")]
	internal void PHMBDLEFHGK(IPEndPoint CABIJDDJPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x762A640", Offset = "0x7628C40", VA = "0x18762A640")]
	internal void JMHDPDFOLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7628BE0", Offset = "0x76271E0", VA = "0x187628BE0")]
	private void DILOBIPFBII(int LAHLPAGONJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76292C0", Offset = "0x76278C0", VA = "0x1876292C0")]
	private void EKFHBODHPMO(int EKCDOAHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x762BB60", Offset = "0x762A160", VA = "0x18762BB60")]
	public int PHAEAOLPBJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x762BA40", Offset = "0x762A040", VA = "0x18762BA40")]
	public int PHAEAOLPBJE(byte GGOMLHLCBDL, bool LDPKPBPGLAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x762A6D0", Offset = "0x7628CD0", VA = "0x18762A6D0")]
	private KMAKCNBMDPK KLDJAJFEEHA(byte IEODBGLFEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x762C330", Offset = "0x762A930", VA = "0x18762C330")]
	internal NFJLBNDHHEJ(IEAGFOENGPO DOILLNCNPKA, IPEndPoint ACGMABMGGIC, int JIEJOKBHEMF, byte CGIBKJCEEPB, FBDJBJOODID LJOCKEPNDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x762C150", Offset = "0x762A750", VA = "0x18762C150")]
	internal NFJLBNDHHEJ(IEAGFOENGPO DOILLNCNPKA, CKKMAMOBJJA MLCIBEJGDFC, int JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x762A4A0", Offset = "0x7628AA0", VA = "0x18762A4A0")]
	internal void IHELMDKJAMF(JKJLCCFLEOH BHMMAIHFDLF, byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x762A420", Offset = "0x7628A20", VA = "0x18762A420")]
	internal bool GJCOAPFPBOC(ACBOKNNOLCP KJKMHJABJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x762B440", Offset = "0x7629A40", VA = "0x18762B440")]
	public void NMMCFIGJEED(byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FODNOPLPBPI, LFBAPKFNLCH EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7628CB0", Offset = "0x76272B0", VA = "0x187628CB0")]
	private void EBPMKDOKMAI(byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FODNOPLPBPI, byte GGOMLHLCBDL, LFBAPKFNLCH JCBKIHOKMDK, object JMMNGKHPIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x762BC70", Offset = "0x762A270", VA = "0x18762BC70")]
	public void PHBPELHDHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76289B0", Offset = "0x7626FB0", VA = "0x1876289B0")]
	internal EIGJJPCBDGM CMPNDMOHDJE(COEJBMDFDGK KJKMHJABJDF)
	{
		return default(EIGJJPCBDGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x762A5E0", Offset = "0x7628BE0", VA = "0x18762A5E0")]
	internal void JDHLHLIJCFC(KMAKCNBMDPK CNDNKIKDKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x762B730", Offset = "0x7629D30", VA = "0x18762B730")]
	internal IDCHJJPIHNC OFPJDHHLIFJ(byte[] DAJAOHIJHHL, int NEIBMENBNPA, int FODNOPLPBPI, bool MKJGBAFLMBJ)
	{
		return default(IDCHJJPIHNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x762A4F0", Offset = "0x7628AF0", VA = "0x18762A4F0")]
	private void IJHPAGNIFFB(int EBALGDBBNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x762AAA0", Offset = "0x76290A0", VA = "0x18762AAA0")]
	internal void NMENMKBOFDJ(LFBAPKFNLCH GMJJMMCAFFM, COEJBMDFDGK JHCGOEHIHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76293B0", Offset = "0x76279B0", VA = "0x1876293B0")]
	private void EPIMDECFPOB(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x762A090", Offset = "0x7628690", VA = "0x18762A090")]
	private void GBCDMGBONON(int KNMJNADDDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x76287D0", Offset = "0x7626DD0", VA = "0x1876287D0")]
	internal DGNIOOPHNEJ BJHDHFNGAAP(JKJLCCFLEOH IHPFEPKMFAO)
	{
		return default(DGNIOOPHNEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7628110", Offset = "0x7626710", VA = "0x187628110")]
	internal void AJHCCPFMGGH(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7628A90", Offset = "0x7627090", VA = "0x187628A90")]
	private void DIKAIKLFICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x762A890", Offset = "0x7628E90", VA = "0x18762A890")]
	internal void LMGBKLABKBD(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76299D0", Offset = "0x7627FD0", VA = "0x1876299D0")]
	internal void FLHPFKIPOFF(int KNMJNADDDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x762B470", Offset = "0x7629A70", VA = "0x18762B470")]
	internal void OBDMJMEIAFH(COEJBMDFDGK KJKMHJABJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OBNDKDBIDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long OKDBDPMKDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long NIGKICJMMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long KLENIJJGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JMLNCLKNHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long FGBNPBMFJOE;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long GPGFDEHALCL;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long JFEIDFOMEBC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long OKGEMGGBEHP;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long KAGPLDIMKJF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long EDLPFKCKMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long AHNKEFMANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long IBKNBADEOFE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AJLIMJAILCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x762CBA0", Offset = "0x762B1A0", VA = "0x18762CBA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DCAOPKNMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x762CCC0", Offset = "0x762B2C0", VA = "0x18762CCC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HGHAPDBFBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x762C9C0", Offset = "0x762AFC0", VA = "0x18762C9C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HLCCMAIJDOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x762C9B0", Offset = "0x762AFB0", VA = "0x18762C9B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long KBPHFPELGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x762C890", Offset = "0x762AE90", VA = "0x18762C890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long NIMNNEKAMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x762CC10", Offset = "0x762B210", VA = "0x18762CC10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long LKBFHAEKJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x762CAC0", Offset = "0x762B0C0", VA = "0x18762CAC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long IAKAAMHCPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x762C8A0", Offset = "0x762AEA0", VA = "0x18762C8A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private PBCDAOFJMJL NFJMFAKFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double BOCEOICKKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x762CBB0", Offset = "0x762B1B0", VA = "0x18762CBB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x762CB60", Offset = "0x762B160", VA = "0x18762CB60")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x762CB00", Offset = "0x762B100", VA = "0x18762CB00")]
	public void IBBEBHBIINP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x762C840", Offset = "0x762AE40", VA = "0x18762C840")]
	public void AAHODFKDJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x762CA50", Offset = "0x762B050", VA = "0x18762CA50")]
	public void FFDEENCGGEG(long GADBFBBDBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x762C940", Offset = "0x762AF40", VA = "0x18762C940")]
	public void BBIEFDGBFGH(long OBAPLEDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x762C8E0", Offset = "0x762AEE0", VA = "0x18762C8E0")]
	public void ANFEHKIFCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x762C9D0", Offset = "0x762AFD0", VA = "0x18762C9D0")]
	public void EDCNFDANIDA(long AEKPGDHCBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x762CCD0", Offset = "0x762B2D0", VA = "0x18762CCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x762CC20", Offset = "0x762B220", VA = "0x18762CC20")]
	public void NMNMPFDMAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OBNDKDBIDMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HLBIPGGPKPP
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> LJHOPEFDGLN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76197A0", Offset = "0x7617DA0", VA = "0x1876197A0")]
	public static IPEndPoint FJEEDKCGJGN(string AOHMIEGOAJF, int DJOEAGDKAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76199F0", Offset = "0x7617FF0", VA = "0x1876199F0")]
	public static IPAddress JKAGEJIBELN(string AOHMIEGOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7619BC0", Offset = "0x76181C0", VA = "0x187619BC0")]
	public static IPAddress JKAGEJIBELN(string AOHMIEGOAJF, AddressFamily MLFKHCAILCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7619C50", Offset = "0x7618250", VA = "0x187619C50")]
	internal static int JNOIAFONFHG(int BLJPJDOGJFG, int JALMNPEBCOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3DDED50", Offset = "0x3DDD350", VA = "0x183DDED50")]
	internal static T[] PNGFDFMIKMP<T>(int FEEKNNBMJMM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KKCADKIGLAN : KMAKCNBMDPK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct GAODDFBFNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private COEJBMDFDGK BHOGDNKPHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long INCHAHDMLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool KIPFCBIBFMA;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7619270", Offset = "0x7617870", VA = "0x187619270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7619250", Offset = "0x7617850", VA = "0x187619250")]
		public void PNHKIAJGEDI(COEJBMDFDGK KJKMHJABJDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7619190", Offset = "0x7617790", VA = "0x187619190")]
		public bool DAMADMPIFAM(long LECEFMDDLMN, NFJLBNDHHEJ LJADDECHGEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7619200", Offset = "0x7617800", VA = "0x187619200")]
		public bool OOIGDCNPPFG(NFJLBNDHHEJ LJADDECHGEI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly COEJBMDFDGK OEFLGJLIJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly GAODDFBFNHL[] BHIGEONOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly COEJBMDFDGK[] AMMMINHELDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] HABBEKNIEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int KGGGFCNONKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int PEEPHDJDIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int JMDEHMBMBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int FGNNDCDONCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool NODFMIFGFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly LFBAPKFNLCH KMKAGJJECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool KEJNDMFMKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int DPLLMGGHLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte MFKEMOGOFKD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KFDELJFPAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76258C0", Offset = "0x7623EC0", VA = "0x1876258C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76258D0", Offset = "0x7623ED0", VA = "0x1876258D0")]
	public KKCADKIGLAN(NFJLBNDHHEJ LJADDECHGEI, bool LDPKPBPGLAP, byte JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7625500", Offset = "0x7623B00", VA = "0x187625500")]
	private void BJILKOFAMPA(COEJBMDFDGK KJKMHJABJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7625030", Offset = "0x7623630", VA = "0x187625030", Slot = "4")]
	protected override bool AMEFLGHOOIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76249D0", Offset = "0x7622FD0", VA = "0x1876249D0", Slot = "5")]
	public override bool AJHCCPFMGGH(COEJBMDFDGK KJKMHJABJDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HPLMCFHPNBF : KMAKCNBMDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int BNMJJMKNCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort PEEPHDJDIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool HMJEGCLFLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private COEJBMDFDGK GGJAJCHKPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly COEJBMDFDGK CBNDEDIEEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool OIDNHFBJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte MFKEMOGOFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long JMCBCDOIIDF;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x761A4B0", Offset = "0x7618AB0", VA = "0x18761A4B0")]
	public HPLMCFHPNBF(NFJLBNDHHEJ LJADDECHGEI, bool OLEHEIMJCED, byte JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7619FF0", Offset = "0x76185F0", VA = "0x187619FF0", Slot = "4")]
	protected override bool AMEFLGHOOIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7619D10", Offset = "0x7618310", VA = "0x187619D10", Slot = "5")]
	public override bool AJHCCPFMGGH(COEJBMDFDGK KJKMHJABJDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BDFKFAAENAJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct MKLFMCOMNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong JIKJLDFNMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double GHGNHPMAGJO;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct GLFMPLPMBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int FBCAFPHMMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float JNENPEFHNJL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x76149E0", Offset = "0x7612FE0", VA = "0x1876149E0")]
	private static void PIAMHEGNAAO(byte[] COEFMBJKIKA, int EFCGAKGCCGN, ulong DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7615C70", Offset = "0x7614270", VA = "0x187615C70")]
	private static void PIAMHEGNAAO(byte[] COEFMBJKIKA, int EFCGAKGCCGN, int DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7615B80", Offset = "0x7614180", VA = "0x187615B80")]
	public static void PIAMHEGNAAO(byte[] COEFMBJKIKA, int EFCGAKGCCGN, short DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7615C50", Offset = "0x7614250", VA = "0x187615C50")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, double FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7615BC0", Offset = "0x76141C0", VA = "0x187615BC0")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7615B80", Offset = "0x7614180", VA = "0x187615B80")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, short FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7615B80", Offset = "0x7614180", VA = "0x187615B80")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, ushort FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7615C70", Offset = "0x7614270", VA = "0x187615C70")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7615C70", Offset = "0x7614270", VA = "0x187615C70")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, uint FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7615C40", Offset = "0x7614240", VA = "0x187615C40")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7615C40", Offset = "0x7614240", VA = "0x187615C40")]
	public static void EJNCGMALMNC(byte[] NCMOHOAIBBB, int JNIDLJHCIED, ulong FKMNCAKIOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BLMJBPKEHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] NGCMHHMAMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int CLFJEJEKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int CKIOPDDALJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int AEOCDGDNAKN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] BKCOPAPLPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BDMKEFFPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PAFOPAFHEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7616430", Offset = "0x7614A30", VA = "0x187616430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KIDGBFLDGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x298D6B0", Offset = "0x298BCB0", VA = "0x18298D6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DMNJDDFKOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x76160F0", Offset = "0x76146F0", VA = "0x1876160F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x76161D0", Offset = "0x76147D0", VA = "0x1876161D0")]
	public void CMNEJBHHIOO(byte[] LBHNPIBFMBH, int EFCGAKGCCGN, int BBHLFEHECGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BLMJBPKEHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7616990", Offset = "0x7614F90", VA = "0x187616990")]
	public BLMJBPKEHLN(byte[] LBHNPIBFMBH, int EFCGAKGCCGN, int BBHLFEHECGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7616100", Offset = "0x7614700", VA = "0x187616100")]
	public IPEndPoint CMGBPFNLCJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7616440", Offset = "0x7614A40", VA = "0x187616440")]
	public byte IDJJJOPBKKO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7616440", Offset = "0x7614A40", VA = "0x187616440")]
	public sbyte NFHMDMGHGFG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3B26FD0", Offset = "0x3B255D0", VA = "0x183B26FD0")]
	public T[] LBDKFMMMDGO<T>(ushort MLMBLBFOLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7616280", Offset = "0x7614880", VA = "0x187616280")]
	public bool[] FGGMBHMPBBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7616680", Offset = "0x7614C80", VA = "0x187616680")]
	public ushort[] KLLMMJIIOAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7616370", Offset = "0x7614970", VA = "0x187616370")]
	public short[] HAECLKMLAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x76163B0", Offset = "0x76149B0", VA = "0x1876163B0")]
	public int[] HCHMJDCBAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7616950", Offset = "0x7614F50", VA = "0x187616950")]
	public uint[] PLHCHPCDCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x76162C0", Offset = "0x76148C0", VA = "0x1876162C0")]
	public float[] GCOJICCHNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7615D80", Offset = "0x7614380", VA = "0x187615D80")]
	public double[] BACHOEAFBBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x76167A0", Offset = "0x7614DA0", VA = "0x1876167A0")]
	public long[] MGECOJBEJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x76160B0", Offset = "0x76146B0", VA = "0x1876160B0")]
	public ulong[] BLNJPDOEJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7616530", Offset = "0x7614B30", VA = "0x187616530")]
	public string[] KHPEKLGOLDD(int KJGKGKKLBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x76163F0", Offset = "0x76149F0", VA = "0x1876163F0")]
	public bool HHKGHPGANPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76167E0", Offset = "0x7614DE0", VA = "0x1876167E0")]
	public char MIGAHJKFDHH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x76167E0", Offset = "0x7614DE0", VA = "0x1876167E0")]
	public ushort OEFCPEBOPHE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7616210", Offset = "0x7614810", VA = "0x187616210")]
	public short ECDNMMOIJOA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7616850", Offset = "0x7614E50", VA = "0x187616850")]
	public long OIKGPPJLLJN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76168E0", Offset = "0x7614EE0", VA = "0x1876168E0")]
	public ulong PALADDGCACH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7615DC0", Offset = "0x76143C0", VA = "0x187615DC0")]
	public int BFKOPJPKKEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7616730", Offset = "0x7614D30", VA = "0x187616730")]
	public uint MFPIKLICEHO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7616300", Offset = "0x7614900", VA = "0x187616300")]
	public float GHLJBFNGJAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x76166C0", Offset = "0x7614CC0", VA = "0x1876166C0")]
	public double LOHLBGKCDOE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7615E70", Offset = "0x7614470", VA = "0x187615E70")]
	public string BIOEEPCDPBO(int JMNJIFILGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x76164C0", Offset = "0x7614AC0", VA = "0x1876164C0")]
	public ArraySegment<byte> KHHENLCMMFC(int FEEKNNBMJMM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7615E30", Offset = "0x7614430", VA = "0x187615E30")]
	public sbyte[] BHLDIKBOKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7616480", Offset = "0x7614A80", VA = "0x187616480")]
	public byte[] KGNKMLAPFFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x76168C0", Offset = "0x7614EC0", VA = "0x1876168C0")]
	public void OOIGDCNPPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FBDJBJOODID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] NGCMHHMAMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int CLFJEJEKEIB;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int ECEIOGBNGLL = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool PLMCKMIACLM;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding OAJAPOCEMNM;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int INLCJHGNGOP = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] FFHHIIAELDO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7619070", Offset = "0x7617670", VA = "0x187619070")]
	public FBDJBJOODID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76190F0", Offset = "0x76176F0", VA = "0x1876190F0")]
	public FBDJBJOODID(bool MIKHEFGJOCL, int CDENPAFGPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7618F70", Offset = "0x7617570", VA = "0x187618F70")]
	public static FBDJBJOODID OJFOBNBEBIL(string FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7618A80", Offset = "0x7617080", VA = "0x187618A80")]
	public void EFHDHJIIPGJ(int OFLMIJCDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2A07020", Offset = "0x2A05620", VA = "0x182A07020")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76189E0", Offset = "0x7616FE0", VA = "0x1876189E0")]
	public void ANDNCHLBHFM(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7618570", Offset = "0x7616B70", VA = "0x187618570")]
	public void ANDNCHLBHFM(double FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7618520", Offset = "0x7616B20", VA = "0x187618520")]
	public void ANDNCHLBHFM(long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7618520", Offset = "0x7616B20", VA = "0x187618520")]
	public void ANDNCHLBHFM(ulong FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7618490", Offset = "0x7616A90", VA = "0x187618490")]
	public void ANDNCHLBHFM(int FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7618490", Offset = "0x7616A90", VA = "0x187618490")]
	public void ANDNCHLBHFM(uint FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7618420", Offset = "0x7616A20", VA = "0x187618420")]
	public void ANDNCHLBHFM(char FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7618420", Offset = "0x7616A20", VA = "0x187618420")]
	public void ANDNCHLBHFM(ushort FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7618420", Offset = "0x7616A20", VA = "0x187618420")]
	public void ANDNCHLBHFM(short FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x76187D0", Offset = "0x7616DD0", VA = "0x1876187D0")]
	public void ANDNCHLBHFM(sbyte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x76187D0", Offset = "0x7616DD0", VA = "0x1876187D0")]
	public void ANDNCHLBHFM(byte FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7618890", Offset = "0x7616E90", VA = "0x187618890")]
	public void ANDNCHLBHFM(byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7618340", Offset = "0x7616940", VA = "0x187618340")]
	public void ADLMEHMKAIG(sbyte[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7618340", Offset = "0x7616940", VA = "0x187618340")]
	public void AMGFPKCAMIM(byte[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7618830", Offset = "0x7616E30", VA = "0x187618830")]
	public void ANDNCHLBHFM(bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7618DC0", Offset = "0x76173C0", VA = "0x187618DC0")]
	public void LHIOEJAMBIJ(Array OBACHLEFMJL, int DFLFBIAGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7618C00", Offset = "0x7617200", VA = "0x187618C00")]
	public void LHIOEJAMBIJ(float[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7618CE0", Offset = "0x76172E0", VA = "0x187618CE0")]
	public void LHIOEJAMBIJ(double[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7618CE0", Offset = "0x76172E0", VA = "0x187618CE0")]
	public void LHIOEJAMBIJ(long[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7618CE0", Offset = "0x76172E0", VA = "0x187618CE0")]
	public void LHIOEJAMBIJ(ulong[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7618C00", Offset = "0x7617200", VA = "0x187618C00")]
	public void LHIOEJAMBIJ(int[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7618C00", Offset = "0x7617200", VA = "0x187618C00")]
	public void LHIOEJAMBIJ(uint[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7618B20", Offset = "0x7617120", VA = "0x187618B20")]
	public void LHIOEJAMBIJ(ushort[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7618B20", Offset = "0x7617120", VA = "0x187618B20")]
	public void LHIOEJAMBIJ(short[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7618340", Offset = "0x7616940", VA = "0x187618340")]
	public void LHIOEJAMBIJ(bool[] FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7618EA0", Offset = "0x76174A0", VA = "0x187618EA0")]
	public void LHIOEJAMBIJ(string[] FKMNCAKIOFK, int GIBEIBCFDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7618910", Offset = "0x7616F10", VA = "0x187618910")]
	public void ANDNCHLBHFM(IPEndPoint NPCGBPKNKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7618900", Offset = "0x7616F00", VA = "0x187618900")]
	public void ANDNCHLBHFM(string FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76185C0", Offset = "0x7616BC0", VA = "0x1876185C0")]
	public void ANDNCHLBHFM(string FKMNCAKIOFK, int JMNJIFILGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NKMJEENOLOJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class KKIOHKMGKHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong AFPIOPNCMPM;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x55FA5D0", Offset = "0x55F8BD0", VA = "0x1855FA5D0")]
		static KKIOHKMGKHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void NHDDKIAJIJM(BLMJBPKEHLN EMPLJNKCONI, object JMMNGKHPIEI);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JHEADPPCENH<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public NKMJEENOLOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JHEADPPCENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x54B5DB0", Offset = "0x54B43B0", VA = "0x1854B5DB0")]
		internal void JDFPCGJNBHL(BLMJBPKEHLN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GFAGDHCKLCD<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public NKMJEENOLOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GFAGDHCKLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBF0", Offset = "0x4FDE1F0", VA = "0x184FDFBF0")]
		internal void JDFPCGJNBHL(BLMJBPKEHLN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly MNGINCBGODP GKNFMNDGGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, NHDDKIAJIJM> BNMCJJEONJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly FBDJBJOODID KDAJCGFECFK;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x762C6C0", Offset = "0x762ACC0", VA = "0x18762C6C0")]
	public NKMJEENOLOJ(int KJGKGKKLBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x32A3D30", Offset = "0x32A2330", VA = "0x1832A3D30", Slot = "4")]
	protected virtual ulong FIHPIGMFPJJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x762C540", Offset = "0x762AB40", VA = "0x18762C540", Slot = "5")]
	protected virtual NHDDKIAJIJM PFIFKEMCLFD(BLMJBPKEHLN EMPLJNKCONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3F19570", Offset = "0x3F17B70", VA = "0x183F19570", Slot = "6")]
	protected virtual void GOFLKDKMCOP<T>(FBDJBJOODID ENKMBIEHHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x762C4C0", Offset = "0x762AAC0", VA = "0x18762C4C0")]
	public void EIEKGDMEBMK(BLMJBPKEHLN EMPLJNKCONI, object JMMNGKHPIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3F198E0", Offset = "0x3F17EE0", VA = "0x183F198E0")]
	public void OFCKLKGLICM<T>(FBDJBJOODID ENKMBIEHHDM, T KJKMHJABJDF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x762C670", Offset = "0x762AC70", VA = "0x18762C670")]
	public void POAIEKGCGFM(BLMJBPKEHLN EMPLJNKCONI, object JMMNGKHPIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3F19760", Offset = "0x3F17D60", VA = "0x183F19760")]
	public void INKFCFPFCNP<T>(Action<T> AIAIFFHNHHF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3F195E0", Offset = "0x3F17BE0", VA = "0x183F195E0")]
	public void INKFCFPFCNP<T, TUserData>(Action<T, TUserData> AIAIFFHNHHF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FAGMMOHEPFG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7615B70", Offset = "0x7614170", VA = "0x187615B70")]
	public FAGMMOHEPFG(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NEGDDBAPNMM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x76280B0", Offset = "0x76266B0", VA = "0x1876280B0")]
	public NEGDDBAPNMM(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MNGINCBGODP
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum EEOIPKDNPEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class ELJBJCNGGAG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public EEOIPKDNPEE MONFNOPPPGA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4A86820", Offset = "0x4A84E20", VA = "0x184A86820", Slot = "4")]
		public virtual void PNHKIAJGEDI(MethodInfo DBNPMPBJAEL, MethodInfo EMBEPGBDIGB, EEOIPKDNPEE EHLAHNIAPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HOLBMIBBCGH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HKACEBKCBLM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		protected ELJBJCNGGAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class MHNAAHLCNGE<TClass, TProperty> : ELJBJCNGGAG<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> LAPFHMIPFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> LLJLPNPJJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> GGFMNDHNCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> LPKMOEMIHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> LPHJOJEJJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> FKCGNGLJKDO;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5967A10", Offset = "0x5966010", VA = "0x185967A10", Slot = "7")]
		public override void KAEPDHGKCNH(TClass KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x59655A0", Offset = "0x5963BA0", VA = "0x1859655A0", Slot = "8")]
		public override void BCEPBIGCHBH(TClass KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5967230", Offset = "0x5965830", VA = "0x185967230", Slot = "9")]
		public override void HOLBMIBBCGH(TClass KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5966350", Offset = "0x5964950", VA = "0x185966350", Slot = "10")]
		public override void HKACEBKCBLM(TClass KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5965B50", Offset = "0x5964150", VA = "0x185965B50")]
		protected TProperty[] DABCFJEKEAO(TClass KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5965AE0", Offset = "0x59640E0", VA = "0x185965AE0")]
		protected TProperty[] BGJMFFMCPIO(TClass KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x596A0F0", Offset = "0x59686F0", VA = "0x18596A0F0", Slot = "4")]
		public override void PNHKIAJGEDI(MethodInfo DBNPMPBJAEL, MethodInfo EMBEPGBDIGB, EEOIPKDNPEE EHLAHNIAPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x596C930", Offset = "0x596AF30", VA = "0x18596C930")]
		protected MHNAAHLCNGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class INKJDPPMAEF<TClass, TProperty> : MHNAAHLCNGE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OAKKIGGFLFH(BLMJBPKEHLN FIECNFDCBKN, [Out] TProperty PHIDBOOKGIO);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void BMAFPDBEJKH(FBDJBJOODID EDHBJBGECMO, TProperty PHIDBOOKGIO);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5276460", Offset = "0x5274A60", VA = "0x185276460", Slot = "5")]
		public override void ABOOHALKFOP(TClass KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5276850", Offset = "0x5274E50", VA = "0x185276850", Slot = "6")]
		public override void OFCKLKGLICM(TClass KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5276740", Offset = "0x5274D40", VA = "0x185276740", Slot = "7")]
		public override void KAEPDHGKCNH(TClass KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5276560", Offset = "0x5274B60", VA = "0x185276560", Slot = "8")]
		public override void BCEPBIGCHBH(TClass KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x52768C0", Offset = "0x5274EC0", VA = "0x1852768C0")]
		protected INKJDPPMAEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class FNFBONIACPF<T> : MHNAAHLCNGE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D600", Offset = "0x4F4BC00", VA = "0x184F4D600", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D740", Offset = "0x4F4BD40", VA = "0x184F4D740", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D6D0", Offset = "0x4F4BCD0", VA = "0x184F4D6D0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D670", Offset = "0x4F4BC70", VA = "0x184F4D670", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public FNFBONIACPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class OIMEPGHLFDF<T> : MHNAAHLCNGE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5B6CA30", Offset = "0x5B6B030", VA = "0x185B6CA30", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D740", Offset = "0x4F4BD40", VA = "0x184F4D740", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B6CAA0", Offset = "0x5B6B0A0", VA = "0x185B6CAA0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D670", Offset = "0x4F4BC70", VA = "0x184F4D670", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public OIMEPGHLFDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class IAMGLNBNMGM<T> : MHNAAHLCNGE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5215D30", Offset = "0x5214330", VA = "0x185215D30", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x459F5E0", Offset = "0x459DBE0", VA = "0x18459F5E0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5215DA0", Offset = "0x52143A0", VA = "0x185215DA0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x459F510", Offset = "0x459DB10", VA = "0x18459F510", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public IAMGLNBNMGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DCPDDCNONKO<T> : MHNAAHLCNGE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x459F4A0", Offset = "0x459DAA0", VA = "0x18459F4A0", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x459F5E0", Offset = "0x459DBE0", VA = "0x18459F5E0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x459F570", Offset = "0x459DB70", VA = "0x18459F570", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x459F510", Offset = "0x459DB10", VA = "0x18459F510", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public DCPDDCNONKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PEDLOPFJDEO<T> : MHNAAHLCNGE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C64E30", Offset = "0x5C63430", VA = "0x185C64E30", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E8C0", Offset = "0x4A4CEC0", VA = "0x184A4E8C0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C64EA0", Offset = "0x5C634A0", VA = "0x185C64EA0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E7F0", Offset = "0x4A4CDF0", VA = "0x184A4E7F0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public PEDLOPFJDEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ECGGMGIINJH<T> : MHNAAHLCNGE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E780", Offset = "0x4A4CD80", VA = "0x184A4E780", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E8C0", Offset = "0x4A4CEC0", VA = "0x184A4E8C0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E850", Offset = "0x4A4CE50", VA = "0x184A4E850", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E7F0", Offset = "0x4A4CDF0", VA = "0x184A4E7F0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public ECGGMGIINJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class GIEGGMOKLBI<T> : MHNAAHLCNGE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF470", Offset = "0x4FEDA70", VA = "0x184FEF470", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF5B0", Offset = "0x4FEDBB0", VA = "0x184FEF5B0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF540", Offset = "0x4FEDB40", VA = "0x184FEF540", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF4E0", Offset = "0x4FEDAE0", VA = "0x184FEF4E0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public GIEGGMOKLBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class NPMIBKLJCOA<T> : MHNAAHLCNGE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF470", Offset = "0x4FEDA70", VA = "0x184FEF470", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF5B0", Offset = "0x4FEDBB0", VA = "0x184FEF5B0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B610", Offset = "0x5A29C10", VA = "0x185A2B610", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF4E0", Offset = "0x4FEDAE0", VA = "0x184FEF4E0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public NPMIBKLJCOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class KMLAFLKKNOC<T> : MHNAAHLCNGE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x560A230", Offset = "0x5608830", VA = "0x18560A230", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x560A310", Offset = "0x5608910", VA = "0x18560A310", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x560A2A0", Offset = "0x56088A0", VA = "0x18560A2A0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D670", Offset = "0x4F4BC70", VA = "0x184F4D670", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public KMLAFLKKNOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NMHIGEJKMGH<T> : MHNAAHLCNGE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x59FEB50", Offset = "0x59FD150", VA = "0x1859FEB50", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x59FEC30", Offset = "0x59FD230", VA = "0x1859FEC30", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x59FEBC0", Offset = "0x59FD1C0", VA = "0x1859FEBC0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E7F0", Offset = "0x4A4CDF0", VA = "0x184A4E7F0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public NMHIGEJKMGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NMJMHMMGDFG<T> : MHNAAHLCNGE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x59FEDD0", Offset = "0x59FD3D0", VA = "0x1859FEDD0", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x59FEEB0", Offset = "0x59FD4B0", VA = "0x1859FEEB0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x59FEE40", Offset = "0x59FD440", VA = "0x1859FEE40", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF4E0", Offset = "0x4FEDAE0", VA = "0x184FEF4E0", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x459F640", Offset = "0x459DC40", VA = "0x18459F640")]
		public NMJMHMMGDFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JBNIGACIGLK<T> : INKJDPPMAEF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x549D8C0", Offset = "0x549BEC0", VA = "0x18549D8C0", Slot = "12")]
		protected override void BMAFPDBEJKH(FBDJBJOODID EDHBJBGECMO, char PHIDBOOKGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x549D8F0", Offset = "0x549BEF0", VA = "0x18549D8F0", Slot = "11")]
		protected override void OAKKIGGFLFH(BLMJBPKEHLN FIECNFDCBKN, [Out] char PHIDBOOKGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
		public JBNIGACIGLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FDHFBLLDHKL<T> : INKJDPPMAEF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F24910", Offset = "0x4F22F10", VA = "0x184F24910", Slot = "12")]
		protected override void BMAFPDBEJKH(FBDJBJOODID EDHBJBGECMO, IPEndPoint PHIDBOOKGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F24940", Offset = "0x4F22F40", VA = "0x184F24940", Slot = "11")]
		protected override void OAKKIGGFLFH(BLMJBPKEHLN FIECNFDCBKN, [Out] IPEndPoint PHIDBOOKGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
		public FDHFBLLDHKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class AAJKPDPGDNI<T> : MHNAAHLCNGE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int NGHHJGOLKGA;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x51D3CB0", Offset = "0x51D22B0", VA = "0x1851D3CB0")]
		public AAJKPDPGDNI(int JMNJIFILGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x51D3AF0", Offset = "0x51D20F0", VA = "0x1851D3AF0", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x51D3C40", Offset = "0x51D2240", VA = "0x1851D3C40", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x51D3BD0", Offset = "0x51D21D0", VA = "0x1851D3BD0", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x51D3B60", Offset = "0x51D2160", VA = "0x1851D3B60", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DOOLFMDJPPF<T> : ELJBJCNGGAG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo LPHPDCKDOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type PMBMBONEGEC;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x45CF790", Offset = "0x45CDD90", VA = "0x1845CF790")]
		public DOOLFMDJPPF(PropertyInfo BJBANDBIGLN, Type FKPJCFEPGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x45CF4A0", Offset = "0x45CDAA0", VA = "0x1845CF4A0", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x45CF6E0", Offset = "0x45CDCE0", VA = "0x1845CF6E0", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x45CF680", Offset = "0x45CDC80", VA = "0x1845CF680", Slot = "7")]
		public override void KAEPDHGKCNH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x45CF560", Offset = "0x45CDB60", VA = "0x1845CF560", Slot = "8")]
		public override void BCEPBIGCHBH(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x45CF620", Offset = "0x45CDC20", VA = "0x1845CF620", Slot = "9")]
		public override void HOLBMIBBCGH(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x45CF5C0", Offset = "0x45CDBC0", VA = "0x1845CF5C0", Slot = "10")]
		public override void HKACEBKCBLM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class AEGOKCMIEFM<T> : DOOLFMDJPPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
		public AEGOKCMIEFM(PropertyInfo BJBANDBIGLN, Type FKPJCFEPGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x53E6150", Offset = "0x53E4750", VA = "0x1853E6150", Slot = "5")]
		public override void ABOOHALKFOP(T KIOPGPIBPMO, BLMJBPKEHLN FIECNFDCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x53E6210", Offset = "0x53E4810", VA = "0x1853E6210", Slot = "6")]
		public override void OFCKLKGLICM(T KIOPGPIBPMO, FBDJBJOODID EDHBJBGECMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class LGKBLJCJGOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static LGKBLJCJGOB<T> DOBPPELCKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly ELJBJCNGGAG<T>[] NGIOHBLDJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int BKCBLJBJNHI;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x57191F0", Offset = "0x57177F0", VA = "0x1857191F0")]
		public LGKBLJCJGOB(List<ELJBJCNGGAG<T>> ACLDELLMGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5719140", Offset = "0x5717740", VA = "0x185719140")]
		public void OFCKLKGLICM(T NDBJJGOPOFO, FBDJBJOODID ENKMBIEHHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5719090", Offset = "0x5717690", VA = "0x185719090")]
		public void ABOOHALKFOP(T NDBJJGOPOFO, BLMJBPKEHLN EMPLJNKCONI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class MELOMNIAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ELJBJCNGGAG<T> JLOHDPKHFGN<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private FBDJBJOODID EIMHDOPGPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int NIKJFLPBGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, MELOMNIAHLC> FCEBNNBNKKO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7628010", Offset = "0x7626610", VA = "0x187628010")]
	public MNGINCBGODP(int KJGKGKKLBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE7B0", Offset = "0x3EACDB0", VA = "0x183EAE7B0")]
	private LGKBLJCJGOB<T> LNMDAGFNCGL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3B85080", Offset = "0x3B83680", VA = "0x183B85080")]
	public void CBPAAEAGBMC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE730", Offset = "0x3EACD30", VA = "0x183EAE730")]
	public bool KJBCLIOBDIC<T>(BLMJBPKEHLN EMPLJNKCONI, T LKEAKCADNOO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE6D0", Offset = "0x3EACCD0", VA = "0x183EAE6D0")]
	public void CAELEDFILEL<T>(FBDJBJOODID ENKMBIEHHDM, T NDBJJGOPOFO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JLDDFINDMBO
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime NIGDMKJKMON;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] GMLHBIBFKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GHEKJCFJEKG NHFJJDKEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7623360", Offset = "0x7621960", VA = "0x187623360")]
		get
		{
			return default(GHEKJCFJEKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LKMNNIBADKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x76230F0", Offset = "0x76216F0", VA = "0x1876230F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x76233C0", Offset = "0x76219C0", VA = "0x1876233C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IAKCHLMGMKG KAJJANDGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x76231F0", Offset = "0x76217F0", VA = "0x1876231F0")]
		get
		{
			return default(IAKCHLMGMKG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7622EB0", Offset = "0x76214B0", VA = "0x187622EB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int AEFJNIBELOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7622B30", Offset = "0x7621130", VA = "0x187622B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint HACJJLEICFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x76232E0", Offset = "0x76218E0", VA = "0x1876232E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? GEBFMHFEMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7622A70", Offset = "0x7621070", VA = "0x187622A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? BGCAAHCHLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7623390", Offset = "0x7621990", VA = "0x187623390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? EHFFCEDNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7622E80", Offset = "0x7621480", VA = "0x187622E80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x76235D0", Offset = "0x7621BD0", VA = "0x1876235D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? JKGPLGOAFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF5B270", Offset = "0xF59870", VA = "0x180F5B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7623A40", Offset = "0x7622040", VA = "0x187623A40")]
	public JLDDFINDMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7623D60", Offset = "0x7622360", VA = "0x187623D60")]
	internal JLDDFINDMBO(byte[] NCMOHOAIBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7622D60", Offset = "0x7621360", VA = "0x187622D60")]
	public static JLDDFINDMBO EFLLHBOHBLF(byte[] NCMOHOAIBBB, DateTime OLNKBNNEDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7622EF0", Offset = "0x76214F0", VA = "0x187622EF0")]
	internal void GINDGBEIAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7623800", Offset = "0x7621E00", VA = "0x187623800")]
	private void PDEMCBLCJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7622B60", Offset = "0x7621160", VA = "0x187622B60")]
	private DateTime? DGEDDHLJBIA(int EFCGAKGCCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7623400", Offset = "0x7621A00", VA = "0x187623400")]
	private void NPHINFJLEKI(int EFCGAKGCCGN, DateTime? FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7623120", Offset = "0x7621720", VA = "0x187623120")]
	private ulong HHNAGEIHMAC(int EFCGAKGCCGN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7623220", Offset = "0x7621820", VA = "0x187623220")]
	private void HOMAJHDJNGD(int EFCGAKGCCGN, ulong FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7622AA0", Offset = "0x76210A0", VA = "0x187622AA0")]
	private uint BACHBCOOAON(int EFCGAKGCCGN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x74DFC10", Offset = "0x74DE210", VA = "0x1874DFC10")]
	private static uint OOFCNJGAMDD(uint POMPNNDHCKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x76237A0", Offset = "0x7621DA0", VA = "0x1876237A0")]
	private static ulong OOFCNJGAMDD(ulong POMPNNDHCKO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum GHEKJCFJEKG
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
public enum IAKCHLMGMKG
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class MACDIBENICD
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int BHKBCCLEMJI = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int GPAKCGGELDC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int AEBDNMENNIG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint OEHAABIKDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int HFOLGEOEAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int EHCCPBEJKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KLNIFGAADCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7628000", Offset = "0x7626600", VA = "0x187628000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7627F10", Offset = "0x7626510", VA = "0x187627F10")]
	public bool NMMCFIGJEED(IGDNAEKMOLA KGBIPOLKOGM, int FLCAFPMKFLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class AKDEHANBANM : IGDNAEKMOLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket KGBIPOLKOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly IEAGFOENGPO DOILLNCNPKA;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short HCCMKFMFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x76154E0", Offset = "0x7613AE0", VA = "0x1876154E0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DJNOMGDAKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x76154A0", Offset = "0x7613AA0", VA = "0x1876154A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint MCMAODGLPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7615480", Offset = "0x7613A80", VA = "0x187615480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily MBELOPBHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x566E970", Offset = "0x566CF70", VA = "0x18566E970", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7615AC0", Offset = "0x76140C0", VA = "0x187615AC0")]
	public AKDEHANBANM(AddressFamily MLFKHCAILCO, IEAGFOENGPO DOILLNCNPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7615500", Offset = "0x7613B00", VA = "0x187615500", Slot = "8")]
	public bool KIPLJGOJDFG(IPEndPoint NPCGBPKNKJM, CGALCMLEFDB DAACDKOOLPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7615350", Offset = "0x7613950", VA = "0x187615350", Slot = "9")]
	public int CDPLFKPHBME(byte[] COEFMBJKIKA, int EFCGAKGCCGN, int MLMBLBFOLPC, IPEndPoint ACGMABMGGIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7615390", Offset = "0x7613990", VA = "0x187615390", Slot = "10")]
	public int DFCOJOBEFAM(byte[] COEFMBJKIKA, EndPoint GFBNKBBMCFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76154C0", Offset = "0x7613AC0", VA = "0x1876154C0", Slot = "11")]
	public void HBFHKNLBLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface IGDNAEKMOLA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short HCCMKFMFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int DJNOMGDAKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint MCMAODGLPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily MBELOPBHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KIPLJGOJDFG(IPEndPoint NPCGBPKNKJM, CGALCMLEFDB DAACDKOOLPE);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CDPLFKPHBME(byte[] COEFMBJKIKA, int EFCGAKGCCGN, int MLMBLBFOLPC, IPEndPoint ACGMABMGGIC);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DFCOJOBEFAM(byte[] COEFMBJKIKA, EndPoint ACGMABMGGIC);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBFHKNLBLAL();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct GDBPCIBCJOC : IEquatable<GDBPCIBCJOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long AEINEMONIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long CIDMMKBGHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long OFJFIKFBPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int LKICONBJJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int AGNPMGPOHFA;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7619400", Offset = "0x7617A00", VA = "0x187619400")]
	public GDBPCIBCJOC(byte[] GOOIAGHPJCD, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x76194C0", Offset = "0x7617AC0", VA = "0x1876194C0")]
	public GDBPCIBCJOC(Span<byte> GOOIAGHPJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7619310", Offset = "0x7617910", VA = "0x187619310", Slot = "4")]
	public bool Equals(GDBPCIBCJOC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7619350", Offset = "0x7617950", VA = "0x187619350", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class FIGCOFBDBAH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] EOEIMALIMMB;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LLKGOCAGJAA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void IMMIBEOJAEJ(IPEndPoint GOOIAGHPJCD, Span<byte> DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string DKHLOEPIIAA = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int EFMJGKPJJCD = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int HBBNJDMIJPI = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int PJENJNBKPFL = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<GDBPCIBCJOC, IPEndPoint> BCDPCPEKPMH;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static IMMIBEOJAEJ HIMPEFELOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int KFHDPKEHLGF;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	internal void BLOBNDIANPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	internal void IECDCJNBOEH(IPEndPoint ACGMABMGGIC, Span<byte> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class KDIFMELOCKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int KONPEIPIHAF;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
	protected KDIFMELOCKD(int DJAKFJLDFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BLEDMKAJNEH(IPEndPoint NPCGBPKNKJM, byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CJBGAEKLMCN(IPEndPoint NPCGBPKNKJM, byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int FODNOPLPBPI);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KJKPEMBGNFD : KDIFMELOCKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] HFLDIIIPBCG;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator GDEPHHGIJKH;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2B14040", Offset = "0x2B12640", VA = "0x182B14040")]
	public KJKPEMBGNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x76246E0", Offset = "0x7622CE0", VA = "0x1876246E0")]
	public void CKFPNJDIBIF(IPEndPoint NPCGBPKNKJM, byte[] HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7624890", Offset = "0x7622E90", VA = "0x187624890")]
	public void DGEENGJAJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7623EB0", Offset = "0x76224B0", VA = "0x187623EB0", Slot = "4")]
	public override void BLEDMKAJNEH(IPEndPoint NPCGBPKNKJM, byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7624370", Offset = "0x7622970", VA = "0x187624370", Slot = "5")]
	public override void CJBGAEKLMCN(IPEndPoint NPCGBPKNKJM, byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int FODNOPLPBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct CCPLALGEDMH
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void FECKKHCNJKC([NoAlias] byte* KEHDIKDEFPM, [NoAlias] byte* HFLDIIIPBCG, [NoAlias] byte* KKEHPNGBDHB, int FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class JDOOMKMHKOO
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr IOFMJDDMIFL;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr JIJKCKPDECI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x762D7F0", Offset = "0x762BDF0", VA = "0x18762D7F0")]
		[BurstDiscard]
		private static void OEJNNOHHIMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x762D3A0", Offset = "0x762B9A0", VA = "0x18762D3A0")]
		private static IntPtr FEMEBLDCLLL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x762D740", Offset = "0x762BD40", VA = "0x18762D740")]
		public static void MPIBIMONAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x762D500", Offset = "0x762BB00", VA = "0x18762D500")]
		public unsafe static void JKGEGDFKKNG([NoAlias] byte* KEHDIKDEFPM, [NoAlias] byte* HFLDIIIPBCG, [NoAlias] byte* KKEHPNGBDHB, int FODNOPLPBPI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint HFLDIIIPBCG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint KKEHPNGBDHB[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint MPNFLKFDIME[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint KGGDLLPAKCG[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint LDOJIJGJLPK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint CEPCIHMNPOA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint DCIOCPGLJAJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint EILABKHFCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint ANEMBPECCCL[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7616FE0", Offset = "0x76155E0", VA = "0x187616FE0")]
	private void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x76171C0", Offset = "0x76157C0", VA = "0x1876171C0")]
	private uint OCPADBLIIAL(uint EFGJHINBPCN, int HIJEGMKCLKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7614DE0", Offset = "0x76133E0", VA = "0x187614DE0")]
	private void INGBDJEMJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7614BD0", Offset = "0x76131D0", VA = "0x187614BD0")]
	private void FDPMGKDEEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7614E90", Offset = "0x7613490", VA = "0x187614E90")]
	private void PPNLDLKBFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7614AD0", Offset = "0x76130D0", VA = "0x187614AD0")]
	private void ACFKGPIOMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7617160", Offset = "0x7615760", VA = "0x187617160")]
	private void LPMGNEPCHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7616BC0", Offset = "0x76151C0", VA = "0x187616BC0")]
	private unsafe void GELGGCLKJBK(byte* KEHDIKDEFPM, uint* HFLDIIIPBCG, uint* KKEHPNGBDHB, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7616A60", Offset = "0x7615060", VA = "0x187616A60")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FFMGFFMHGGL([NoAlias] byte* KEHDIKDEFPM, [NoAlias] byte* HFLDIIIPBCG, [NoAlias] byte* KKEHPNGBDHB, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7616AE0", Offset = "0x76150E0", VA = "0x187616AE0")]
	public static void FFMGFFMHGGL(Span<byte> KEHDIKDEFPM, Span<byte> HFLDIIIPBCG, Span<byte> KKEHPNGBDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7617060", Offset = "0x7615660", VA = "0x187617060")]
	public static void JKMBNKMDBCM(Span<byte> KEHDIKDEFPM, Span<byte> HFLDIIIPBCG, Span<byte> KKEHPNGBDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x76169F0", Offset = "0x7614FF0", VA = "0x1876169F0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void AGCFFHAKKPM([NoAlias] byte* KEHDIKDEFPM, [NoAlias] byte* HFLDIIIPBCG, [NoAlias] byte* KKEHPNGBDHB, int FODNOPLPBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x762D920", Offset = "0x762BF20", VA = "0x18762D920")]
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
