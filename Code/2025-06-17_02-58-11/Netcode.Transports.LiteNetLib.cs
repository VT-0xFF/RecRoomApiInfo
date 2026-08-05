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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, PJOGNKOKOGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum AFCDFLMDABK
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
		private NetworkManager CDCKGPOILHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HIHPLOJFJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, JAFNNIHKJIF> NADMKABJDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GEHOJLIEFBO EGJBLEIIJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch MKMKIOLEHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] ENNIFHOHFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private AFCDFLMDABK ODHBMDNPLNL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int OJPJIOCDBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6F7FFE0", Offset = "0x6F7E9E0", VA = "0x186F7FFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong NNKKPKNEEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool FFHJFPNNJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F7FFC0", Offset = "0x6F7E9C0", VA = "0x186F7FFC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F560", Offset = "0x6F7DF60", VA = "0x186F7F560")]
		public void RecRoom_SetEncryptionInfo(ulong OFICLKOJGKK, byte[] KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F540", Offset = "0x6F7DF40", VA = "0x186F7F540")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F410", Offset = "0x6F7DE10", VA = "0x186F7F410")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FEC0", Offset = "0x6F7E8C0", VA = "0x186F7FEC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F680", Offset = "0x6F7E080", VA = "0x186F7F680", Slot = "6")]
		public override void Send(ulong KKNDHFCJJOK, ArraySegment<byte> HPGIDELCODH, NetworkDelivery OCCEGDPHEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F500", Offset = "0x6F7DF00", VA = "0x186F7F500", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong KKNDHFCJJOK, [Out] ArraySegment<byte> MGDBGDNLMCM, [Out] float OLBHKOOMNHC)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F970", Offset = "0x6F7E370", VA = "0x186F7F970", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FCE0", Offset = "0x6F7E6E0", VA = "0x186F7FCE0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EDC0", Offset = "0x6F7D7C0", VA = "0x186F7EDC0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong KKNDHFCJJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ECD0", Offset = "0x6F7D6D0", VA = "0x186F7ECD0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EF00", Offset = "0x6F7D900", VA = "0x186F7EF00", Slot = "13")]
		public override ulong GetCurrentRtt(ulong KKNDHFCJJOK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F900", Offset = "0x6F7E300", VA = "0x186F7F900", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F0C0", Offset = "0x6F7DAC0", VA = "0x186F7F0C0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager CDCKGPOILHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EFA0", Offset = "0x6F7D9A0", VA = "0x186F7EFA0")]
		private DPLFLBMIAKL IBECPNPKOPD(NetworkDelivery HHCAOFMCNLG)
		{
			return default(DPLFLBMIAKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EA00", Offset = "0x6F7D400", VA = "0x186F7EA00", Slot = "16")]
		private void AOCKMOBKNCL(JAFNNIHKJIF PIODJLCLADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E930", Offset = "0x6F7D330", VA = "0x186F7E930", Slot = "17")]
		private void ABGBBJHCKEJ(JAFNNIHKJIF PIODJLCLADE, EMIEGACEOLN MFPOJHNGIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "18")]
		private void DNPBADOIDNB(IPEndPoint MCOAFFEFDEH, SocketError IMFABIHOLDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EAC0", Offset = "0x6F7D4C0", VA = "0x186F7EAC0", Slot = "19")]
		private void DJKONCOIDPG(JAFNNIHKJIF PIODJLCLADE, JCAFDKGOIMA LJMOCEGEAFH, byte NJCGNNAMNFP, DPLFLBMIAKL EFIHPGJDAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F2D0", Offset = "0x6F7DCD0", VA = "0x186F7F2D0")]
		private void MHEJGHDJPJB(int OPKPFANIILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		private void CFKLGDLGBJM(IPEndPoint NMNBMPFGKHL, JCAFDKGOIMA LJMOCEGEAFH, MPBLPFJPFJP HHPGEEEEHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
		private void DAEJIHGLGBK(JAFNNIHKJIF PIODJLCLADE, int GFGJIHILACE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F3B0", Offset = "0x6F7DDB0", VA = "0x186F7F3B0", Slot = "22")]
		private void NANKNMKJGAI(GKCOANHLFMJ OHOKHLNBDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F090", Offset = "0x6F7DA90", VA = "0x186F7F090")]
		private ulong IMNEEMNGGMC(JAFNNIHKJIF PIODJLCLADE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F070", Offset = "0x6F7DA70", VA = "0x186F7F070")]
		private ulong IMNEEMNGGMC(ulong KKNDHFCJJOK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E910", Offset = "0x6F7D310", VA = "0x186F7E910")]
		private static int AAACJDNLEBN(float CAJJAMECEFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FEE0", Offset = "0x6F7E8E0", VA = "0x186F7FEE0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EED0", Offset = "0x6F7D8D0", VA = "0x186F7EED0")]
		[CompilerGenerated]
		private void ILDOGKACGAC(ulong KGNADHAIFFM, int OOPMNLKKOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EED0", Offset = "0x6F7D8D0", VA = "0x186F7EED0")]
		[CompilerGenerated]
		private void GJOCICGCHKH(ulong KGNADHAIFFM, int OOPMNLKKOHL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class ABDIDPFAGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly JAFNNIHKJIF HHDEKHAJCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<ECBJOFNCPPJ> DEOIPGENOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int HEHCDGAPPEN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JBPGGGKPGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C430", Offset = "0x6F6AE30", VA = "0x186F6C430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C560", Offset = "0x6F6AF60", VA = "0x186F6C560")]
	protected ABDIDPFAGKH(JAFNNIHKJIF PIODJLCLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C480", Offset = "0x6F6AE80", VA = "0x186F6C480")]
	public void KGLFEPOMBEL(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C4E0", Offset = "0x6F6AEE0", VA = "0x186F6C4E0")]
	protected void ODLHHGLILOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C3F0", Offset = "0x6F6ADF0", VA = "0x186F6C3F0")]
	public bool FPOPGENJIJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool GAHEIFIMFEI();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PMCCCBFOLKD(ECBJOFNCPPJ MNIANIFFOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum LDANBPKIIMO
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
public class GKCOANHLFMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly GEHOJLIEFBO KOMJFILJBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FHOLNEMGGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ECJHLMKHFIJ MDOKPLFKACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint HDPJIEJEOLP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal LDANBPKIIMO JONELKFDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA32DA0", Offset = "0xA317A0", VA = "0x180A32DA0")]
		[CompilerGenerated]
		get
		{
			return default(LDANBPKIIMO);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDF8840", Offset = "0xDF7240", VA = "0x180DF8840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F76D70", Offset = "0x6F75770", VA = "0x186F76D70")]
	internal void GIJIMEJLIAG(ECJHLMKHFIJ ADOLLPLAPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F76DD0", Offset = "0x6F757D0", VA = "0x186F76DD0")]
	private bool JGDMOOMPIJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F76E00", Offset = "0x6F75800", VA = "0x186F76E00")]
	internal GKCOANHLFMJ(IPEndPoint NMNBMPFGKHL, ECJHLMKHFIJ AICPKIAOMOM, GEHOJLIEFBO AOKEDFLEBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F76D10", Offset = "0x6F75710", VA = "0x186F76D10")]
	public JAFNNIHKJIF EMPNPAKMLLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MPBLPFJPFJP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum LFNMINIDGHK
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
public struct EMIEGACEOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LFNMINIDGHK ICDMDOEMECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError MCDLFAHCDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JCAFDKGOIMA HFMFFHLLHIG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PJOGNKOKOGF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLEJBFNCJLH(JAFNNIHKJIF PIODJLCLADE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIICDOEHEEN(JAFNNIHKJIF PIODJLCLADE, EMIEGACEOLN MFPOJHNGIFC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGBCLGNEMAC(IPEndPoint MCOAFFEFDEH, SocketError IMFABIHOLDC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFMIFLFCMIN(JAFNNIHKJIF PIODJLCLADE, JCAFDKGOIMA LJMOCEGEAFH, byte NJCGNNAMNFP, DPLFLBMIAKL EFIHPGJDAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAGCNNEOHIM(IPEndPoint NMNBMPFGKHL, JCAFDKGOIMA LJMOCEGEAFH, MPBLPFJPFJP HHPGEEEEHGL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNBFJJNMHMP(JAFNNIHKJIF PIODJLCLADE, int GFGJIHILACE);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCIACMNMMCJ(GKCOANHLFMJ OHOKHLNBDDB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BAJJFBJEANP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGFAMGGLGKN(JAFNNIHKJIF PIODJLCLADE, object IOIPIHCJNEI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IKEMHDHFAFB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHHDPLBPCAI(CHNAELELIEO MNIANIFFOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FOIKIILDDNA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICDLCHMKPAA(JAFNNIHKJIF PIODJLCLADE, IPEndPoint DDBDGFAKGDG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class ECJHLMKHFIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int DKLOLDPLGCK = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long FBJGICFJIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte CJKHELIOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] OGJGBGMAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly NAKMIGIEJPJ JLKLNDPHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int NJGNPDFOANJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EA10", Offset = "0x6F6D410", VA = "0x186F6EA10")]
	private ECJHLMKHFIJ(long ELIIDHEPFGN, byte AIKGIOKGAPP, int MBIJJAIIOHD, byte[] DDNBAEDMHAI, NAKMIGIEJPJ HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E5B0", Offset = "0x6F6CFB0", VA = "0x186F6E5B0")]
	public static int BHFOHJLLPGI(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E610", Offset = "0x6F6D010", VA = "0x186F6E610")]
	public static ECJHLMKHFIJ JFDEOGGNDED(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E830", Offset = "0x6F6D230", VA = "0x186F6E830")]
	public static ECBJOFNCPPJ NHELOBFHEPO(PIIHAKCBOBG ADPMCINGMNI, SocketAddress MGCNLNMBEON, long GDCCDMGCOBK, int MBIJJAIIOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class KCFGFPFNNON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long FBJGICFJIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte CJKHELIOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int NJGNPDFOANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool GHNIBPMENJF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D620", Offset = "0x6F7C020", VA = "0x186F7D620")]
	private KCFGFPFNNON(long ELIIDHEPFGN, byte AIKGIOKGAPP, int AOJKKCOCHAE, bool MHLMHADLEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D2E0", Offset = "0x6F7BCE0", VA = "0x186F7D2E0")]
	public static KCFGFPFNNON JFDEOGGNDED(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D530", Offset = "0x6F7BF30", VA = "0x186F7D530")]
	public static ECBJOFNCPPJ NHELOBFHEPO(long GDCCDMGCOBK, byte NCOJDPKOKOD, int LEIKAPGINLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D430", Offset = "0x6F7BE30", VA = "0x186F7D430")]
	public static ECBJOFNCPPJ LEJBLODANIM(JAFNNIHKJIF PIODJLCLADE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum ALPGONJFAMG
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NKMOLBFNAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PACFLOGBDEP(IPEndPoint JAOBBDDBMLC, IPEndPoint NMNBMPFGKHL, string BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOAFHPDGMJK(IPEndPoint ENCAPOAFMII, ALPGONJFAMG HHCAOFMCNLG, string BECBHDDLOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HPMAIIFMKIH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NFBBNIECPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint GLPNFCNMLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint HDPJIEJEOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string MPLMKKLDHKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct ICEAENCMLFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint EPFHIAFGJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ALPGONJFAMG GLEDFKBBOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string MPLMKKLDHKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class ANCONDFPAEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint IOJLAAKEAGF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string MPLMKKLDHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ANCONDFPAEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HHIMIDEGAMD
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint IOJLAAKEAGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint BAIICIIPILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string MPLMKKLDHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HHIMIDEGAMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NFEFEOCGPOH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string MPLMKKLDHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ODLAAGHFJML
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA129F0", Offset = "0xA113F0", VA = "0x180A129F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NFEFEOCGPOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GEHOJLIEFBO IFKEEHGGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<NFBBNIECPJJ> POCEAFFJCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<ICEAENCMLFK> JFDAPNKKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NAKMIGIEJPJ KDBGJPCKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PIIHAKCBOBG MNBMALDCILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly HFCHNFAIOEA OIOBEMCOAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NKMOLBFNAJG OIFFOCMOCCE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int NLNKPOHAELE = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool LKEICBPOCOL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F77D60", Offset = "0x6F76760", VA = "0x186F77D60")]
	internal HPMAIIFMKIH(GEHOJLIEFBO IGDAJGLONHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F77BE0", Offset = "0x6F765E0", VA = "0x186F77BE0")]
	internal void POKBOAHBHOO(IPEndPoint ADOFGJKAHKM, ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E3B0", Offset = "0x3A8CDB0", VA = "0x183A8E3B0")]
	private void OOFIDCNAHBJ<T>(T MNIANIFFOKJ, IPEndPoint DKLAGICAOGN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F77A50", Offset = "0x6F76450", VA = "0x186F77A50")]
	private void PACFLOGBDEP(ANCONDFPAEH OCPKAOPEDKL, IPEndPoint ADOFGJKAHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F77760", Offset = "0x6F76160", VA = "0x186F77760")]
	private void GFIJCKDDAJD(HHIMIDEGAMD OCPKAOPEDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F778C0", Offset = "0x6F762C0", VA = "0x186F778C0")]
	private void LBLLINICCAC(NFEFEOCGPOH OCPKAOPEDKL, IPEndPoint ADOFGJKAHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DPLFLBMIAKL : byte
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
public enum ALAPBDHPHJD : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EOBEOHBNPCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] NBKPGEAJLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int HBJOIPBDMKA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int CBPDPGBOBOJ;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MKNBDKADEPK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C600", Offset = "0x6F6B000", VA = "0x186F6C600")]
	public MKNBDKADEPK(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NICBHDECMOA : MKNBDKADEPK
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C600", Offset = "0x6F6B000", VA = "0x186F6C600")]
	public NICBHDECMOA(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum OJPHPHLAOKO
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
public interface IMHKMLIEKJA
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JENFBODEAAL(OJPHPHLAOKO FPDFCKBHCAM, string JDGADODOANI, params object[] MPEOAHOICFG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MBCBNIAJPGA
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static IMHKMLIEKJA PIGEBFNHIKA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object ONEDJHPALCP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F801C0", Offset = "0x6F7EBC0", VA = "0x186F801C0")]
	private static void FFNDLDELIDF(OJPHPHLAOKO LNIILOGBLBC, string JDGADODOANI, params object[] MPEOAHOICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F803F0", Offset = "0x6F7EDF0", VA = "0x186F803F0")]
	internal static void HBGLIOBKAMC(string JDGADODOANI, params object[] MPEOAHOICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F80450", Offset = "0x6F7EE50", VA = "0x186F80450")]
	internal static void MIJHOEOAMNI(string JDGADODOANI, params object[] MPEOAHOICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F80160", Offset = "0x6F7EB60", VA = "0x186F80160")]
	internal static void EAOEBCIANDD(string JDGADODOANI, params object[] MPEOAHOICFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum BCMPAOOCDOP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JCAFDKGOIMA : NAKMIGIEJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private ECBJOFNCPPJ DCPBNMDBOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly GEHOJLIEFBO GFNGBMELEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IKBILMGIBLP PLEEPFKGIAD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D290", Offset = "0x6F7BC90", VA = "0x186F7D290")]
	internal JCAFDKGOIMA(GEHOJLIEFBO BPDOIFAEGPF, IKBILMGIBLP ANLKELNPHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D220", Offset = "0x6F7BC20", VA = "0x186F7D220")]
	internal void LNCJJCHJEBH(ECBJOFNCPPJ MNIANIFFOKJ, int JOPGEGLPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D170", Offset = "0x6F7BB70", VA = "0x186F7D170")]
	internal void GDDKJJFAOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D1F0", Offset = "0x6F7BBF0", VA = "0x186F7D1F0")]
	public void LEDBBJMCMMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class IKBILMGIBLP
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum AMPKBOGAJOL
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
	public IKBILMGIBLP HMMJEOMFOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public AMPKBOGAJOL GLEDFKBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public JAFNNIHKJIF HHDEKHAJCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint HDPJIEJEOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object BNJICAHCDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int GGPFOIBOGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError DNBLHKMCPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public LFNMINIDGHK GJALIAEAENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public GKCOANHLFMJ LLKHHAODDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public DPLFLBMIAKL CALJIILDIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte FPBPHMDPBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly JCAFDKGOIMA GBKFHNDBAFG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F78250", Offset = "0x6F76C50", VA = "0x186F78250")]
	public IKBILMGIBLP(GEHOJLIEFBO BPDOIFAEGPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GEHOJLIEFBO : IEnumerable<JAFNNIHKJIF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class KFINJLIMLGO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D670", Offset = "0x6F7C070", VA = "0x186F7D670", Slot = "4")]
		public bool Equals(IPEndPoint CBPCNABIALH, IPEndPoint CBOHEKOGGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4269FF0", Offset = "0x42689F0", VA = "0x184269FF0", Slot = "5")]
		public int GetHashCode(IPEndPoint OJDHMKOBKLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KFINJLIMLGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct IHLDEGLHPIB : IEnumerator<JAFNNIHKJIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly JAFNNIHKJIF GADIDAGLGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private JAFNNIHKJIF NOFLNAICJMK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JAFNNIHKJIF NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA85B50", Offset = "0xA84550", VA = "0x180A85B50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA85B50", Offset = "0xA84550", VA = "0x180A85B50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C3A0", Offset = "0x1B5ADA0", VA = "0x181B5C3A0")]
		public IHLDEGLHPIB(JAFNNIHKJIF ADAFNPDOCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F781B0", Offset = "0x6F76BB0", VA = "0x186F781B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F78200", Offset = "0x6F76C00", VA = "0x186F78200", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread JCBDKELOEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool BDOKFKDJABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool OAAJLDPJBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private EEGPGLHDKAE KKEPEMFBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent NIHALGFLPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<IKBILMGIBLP> GFMGDEFNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<IKBILMGIBLP> OMFCPILOEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IKBILMGIBLP IINLHIBJEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PJOGNKOKOGF IDAKLOPJLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BAJJFBJEANP GIIFMBMAJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IKEMHDHFAFB EMGDPIOJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly FOIKIILDDNA FFPKLGDFJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, JAFNNIHKJIF> NODNIGOPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, GKCOANHLFMJ> LBGMFEPIKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, DFKKJMBNPDL> BDCAHKOFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim MCCPDMEBPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private JAFNNIHKJIF NOOHOINNOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int HPHNAKOLMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<JAFNNIHKJIF> IGDCEMLLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private JAFNNIHKJIF[] POHIFNJBDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly DFCPKDKAKJI GOKDGKEDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int HBNFGECFDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> KGENMPKDGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte LOBNPEFKGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object EKGBEIPJMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool JBKDCEBLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool MPPGEICCKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LNNADCMKNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GBCAOECIDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int BNJMBPJDKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int FHFNMJIMJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HNGKJDLOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool JEOBDCLMGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FJFGGINBFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NNHHIECOAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int DODIMNAKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool LKEICBPOCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HMDPFFNPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool HAFEHLFDAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool HANJGCJJGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int ABMMCKNGJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int LHCKMOFECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool AAGJDKIBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly OBNPCADABGP HALDKJFHHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool HDIELHPJICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly HPMAIIFMKIH DEKCDEIPNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool DBJFOFIOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public BCMPAOOCDOP MHGEBBNHLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int OJLOJIIAJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool HNGDNEANJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool BLFNJGOGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool NGOGKIILLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool LDKBNFGKCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private ECBJOFNCPPJ BNDOODMALCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KDBGFLNGKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object ABBDLEBNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private ECBJOFNCPPJ AEJKEMEPBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int IFIAPIIEMGI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int GJGMPOECBHD = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int POHMMNGNFMK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private CHIICCBAAFB PHKJHMIJCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private CHIICCBAAFB OIMCMOFPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread FFACNEAKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread HPEGGMEKHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint CAHKJOHBAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint HHLOCDKGMOF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] DOBPBCEFHDD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] GAIFMCJMDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<ONACIDFGNID, IPEndPoint> MBJENDPBICH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress AJHEEOLCJBM;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool GFJGCMHOMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int ABEMMJMCHGI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PKFPHGEBEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB3B000", Offset = "0xB39A00", VA = "0x180B3B000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB2C400", Offset = "0xB2AE00", VA = "0x180B2C400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HLJMFOEKOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x169D610", Offset = "0x169C010", VA = "0x18169D610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20E5E00", Offset = "0x20E4800", VA = "0x1820E5E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte LMBHFCIDAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xF9E1F0", Offset = "0xF9CBF0", VA = "0x180F9E1F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NFBDNLLCOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F764B0", Offset = "0x6F74EB0", VA = "0x186F764B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short GDGIMGFCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FFD0", Offset = "0x6F6E9D0", VA = "0x186F6FFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JAFNNIHKJIF.DLJADEIMGAF AIGFNPCCNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FF20", Offset = "0x6F6E920", VA = "0x186F6FF20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F704C0", Offset = "0x6F6EEC0", VA = "0x186F704C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73980", Offset = "0x6F72380", VA = "0x186F73980")]
	public void JJOJAGBIHFO(IPEndPoint MCOAFFEFDEH, byte[] KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FB90", Offset = "0x6F6E590", VA = "0x186F6FB90")]
	public void BANDBMGJLIP(IPEndPoint MCOAFFEFDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F70570", Offset = "0x6F6EF70", VA = "0x186F70570")]
	private bool DONPLKDHIHN(IPEndPoint MCOAFFEFDEH, [Out] JAFNNIHKJIF PIODJLCLADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F70A20", Offset = "0x6F6F420", VA = "0x186F70A20")]
	private void FHAKIBMBGHD(JAFNNIHKJIF PIODJLCLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F75050", Offset = "0x6F73A50", VA = "0x186F75050")]
	private void NAKECNOILLM(JAFNNIHKJIF PIODJLCLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F370", Offset = "0x6F6DD70", VA = "0x186F6F370")]
	private void AJJFBGEPGAE(JAFNNIHKJIF PIODJLCLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F766B0", Offset = "0x6F750B0", VA = "0x186F766B0")]
	public GEHOJLIEFBO(PJOGNKOKOGF AOKEDFLEBJH, [Optional] DFCPKDKAKJI JCLIJMBDLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F74320", Offset = "0x6F72D20", VA = "0x186F74320")]
	internal void KFDMMPMFJHI(JAFNNIHKJIF BMOIKNNGPLI, int GFGJIHILACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F70470", Offset = "0x6F6EE70", VA = "0x186F70470")]
	internal void DCJKNEAJMKM(JAFNNIHKJIF BMOIKNNGPLI, object IOIPIHCJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F70D60", Offset = "0x6F6F760", VA = "0x186F70D60")]
	internal void GFMBFFLEAJO(JAFNNIHKJIF PIODJLCLADE, LFNMINIDGHK CHGJGNFMEJJ, SocketError PJMDOIHOLCA, ECBJOFNCPPJ JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EED0", Offset = "0x6F6D8D0", VA = "0x186F6EED0")]
	private void AIDAHNCNPAI(JAFNNIHKJIF PIODJLCLADE, LFNMINIDGHK CHGJGNFMEJJ, SocketError PJMDOIHOLCA, bool BOOINJJDCOC, byte[] HPGIDELCODH, int HKECPJKDGLJ, int IMCIONKBBCL, ECBJOFNCPPJ JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F70090", Offset = "0x6F6EA90", VA = "0x186F70090")]
	private void CFACKCGNAPH(IKBILMGIBLP.AMPKBOGAJOL HHCAOFMCNLG, [Optional] JAFNNIHKJIF PIODJLCLADE, [Optional] IPEndPoint NMNBMPFGKHL, SocketError IPOOJEEDJGK = SocketError.Success, int GFGJIHILACE = 0, LFNMINIDGHK MBIJNBIPEGB = LFNMINIDGHK.ConnectionFailed, [Optional] GKCOANHLFMJ HLHPDMCDANE, DPLFLBMIAKL EFIHPGJDAGJ = DPLFLBMIAKL.Unreliable, byte NJCGNNAMNFP = 0, [Optional] ECBJOFNCPPJ FMEDJAAGADI, [Optional] object IOIPIHCJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F748B0", Offset = "0x6F732B0", VA = "0x186F748B0")]
	private void LOLEFINGPLK(IKBILMGIBLP ANLKELNPHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F750B0", Offset = "0x6F73AB0", VA = "0x186F750B0")]
	internal void NHJIDCGBCMK(IKBILMGIBLP ANLKELNPHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F71110", Offset = "0x6F6FB10", VA = "0x186F71110")]
	private void HAOOPNFACEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F74530", Offset = "0x6F72F30", VA = "0x186F74530")]
	private void KNBFGIIIGPB(int MGNNCFKBACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73360", Offset = "0x6F71D60", VA = "0x186F73360")]
	internal JAFNNIHKJIF JGNCPNPCBNN(GKCOANHLFMJ OHOKHLNBDDB, byte[] LPPODDDPGLI, int HKECPJKDGLJ, int EIJGIDNMHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ECD0", Offset = "0x6F6D6D0", VA = "0x186F6ECD0")]
	private int ACHADFDKEHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F73E70", Offset = "0x6F72870", VA = "0x186F73E70")]
	private void KCJDDJMNALK(IPEndPoint NMNBMPFGKHL, JAFNNIHKJIF BAONIFLBEHK, ECJHLMKHFIJ BPHKMKECJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F71750", Offset = "0x6F70150", VA = "0x186F71750")]
	private void ILDMDDBECMN(ECBJOFNCPPJ MNIANIFFOKJ, IPEndPoint NMNBMPFGKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F761D0", Offset = "0x6F74BD0", VA = "0x186F761D0")]
	internal void PENOJLDEDEI(ECBJOFNCPPJ MNIANIFFOKJ, DPLFLBMIAKL PAANMNLCKIA, byte NJCGNNAMNFP, int JOPGEGLPHFM, JAFNNIHKJIF BMOIKNNGPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F751C0", Offset = "0x6F73BC0", VA = "0x186F751C0")]
	public bool OAPJNMIFIFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F75A70", Offset = "0x6F74470", VA = "0x186F75A70")]
	public bool OAPJNMIFIFA(IPAddress FJILBDNCEEN, IPAddress KPOOCBHGOOL, int DFABKDKFFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F75230", Offset = "0x6F73C30", VA = "0x186F75230")]
	public bool OAPJNMIFIFA(int DFABKDKFFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F9E0", Offset = "0x6F6E3E0", VA = "0x186F6F9E0")]
	public void APNNKIICGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F75E70", Offset = "0x6F74870", VA = "0x186F75E70")]
	public JAFNNIHKJIF ODKPFIKGMKC(string KJPOKAJCMFP, int DFABKDKFFBP, string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6F75F50", Offset = "0x6F74950", VA = "0x186F75F50")]
	public JAFNNIHKJIF ODKPFIKGMKC(string KJPOKAJCMFP, int DFABKDKFFBP, PIIHAKCBOBG DPGKIGICJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F75A90", Offset = "0x6F74490", VA = "0x186F75A90")]
	public JAFNNIHKJIF ODKPFIKGMKC(IPEndPoint DKLAGICAOGN, PIIHAKCBOBG DPGKIGICJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F70DA0", Offset = "0x6F6F7A0", VA = "0x186F70DA0")]
	public void GPBACMFGIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6F70DB0", Offset = "0x6F6F7B0", VA = "0x186F70DB0")]
	public void GPBACMFGIMM(bool PADJCPDPKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F715D0", Offset = "0x6F6FFD0", VA = "0x186F715D0")]
	public void HPMBBCJPAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F71680", Offset = "0x6F70080", VA = "0x186F71680")]
	public void HPMBBCJPAOC(byte[] HPGIDELCODH, int HKECPJKDGLJ, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F330", Offset = "0x6F6DD30", VA = "0x186F6F330")]
	public void AIDAHNCNPAI(JAFNNIHKJIF PIODJLCLADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F2F0", Offset = "0x6F6DCF0", VA = "0x186F6F2F0")]
	public void AIDAHNCNPAI(JAFNNIHKJIF PIODJLCLADE, byte[] HPGIDELCODH, int HKECPJKDGLJ, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F764D0", Offset = "0x6F74ED0", VA = "0x186F764D0", Slot = "4")]
	private IEnumerator<JAFNNIHKJIF> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F76560", Offset = "0x6F74F60", VA = "0x186F76560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F74450", Offset = "0x6F72E50", VA = "0x186F74450")]
	private ECBJOFNCPPJ KKNONPAJAND(JKDLDEMCDII MLCOAPMDJJE, int OPKPFANIILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F74370", Offset = "0x6F72D70", VA = "0x186F74370")]
	private ECBJOFNCPPJ KKNONPAJAND(JKDLDEMCDII MLCOAPMDJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FCE0", Offset = "0x6F6E6E0", VA = "0x186F6FCE0")]
	internal ECBJOFNCPPJ BDFPABEBOHB(int OPKPFANIILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F70610", Offset = "0x6F6F010", VA = "0x186F70610")]
	internal void EAJHDOPIIEN(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F765F0", Offset = "0x6F74FF0", VA = "0x186F765F0")]
	static GEHOJLIEFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB3B000", Offset = "0xB39A00", VA = "0x180B3B000")]
	private bool GPPPGPEDKMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ED50", Offset = "0x6F6D750", VA = "0x186F6ED50")]
	private void AFDPCJLPCNF(IPEndPoint OAOIOLGEEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F71460", Offset = "0x6F6FE60", VA = "0x186F71460")]
	private void HFDGFINCBOG(IPEndPoint OAOIOLGEEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F70870", Offset = "0x6F6F270", VA = "0x186F70870")]
	private bool FEOCECBHBIL(SocketException AGKNBEAOFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F761B0", Offset = "0x6F74BB0", VA = "0x186F761B0")]
	private void OPMLDLEMINL(EEGPGLHDKAE IGDAJGLONHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73BA0", Offset = "0x6F725A0", VA = "0x186F73BA0")]
	private void JLPJEMFOOIO(CHIICCBAAFB IGDAJGLONHG, EndPoint MABDMIHBPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F650", Offset = "0x6F6E050", VA = "0x186F6F650")]
	private void AMBJIADPABH(object LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F752B0", Offset = "0x6F73CB0", VA = "0x186F752B0")]
	public bool OAPJNMIFIFA(IPAddress FJILBDNCEEN, IPAddress KPOOCBHGOOL, int DFABKDKFFBP, bool OEKDDPOFPPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F74850", Offset = "0x6F73250", VA = "0x186F74850")]
	internal int LMBNIBOLBGO(ECBJOFNCPPJ MNIANIFFOKJ, IPEndPoint NMNBMPFGKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F73320", Offset = "0x6F71D20", VA = "0x186F73320")]
	internal int INCAJIJEBPA(ECBJOFNCPPJ MNIANIFFOKJ, IPEndPoint NMNBMPFGKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F72B40", Offset = "0x6F71540", VA = "0x186F72B40")]
	internal int INCAJIJEBPA(byte[] IJOJGNJMCGP, int HKECPJKDGLJ, int EIJGIDNMHGP, IPEndPoint NMNBMPFGKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F76030", Offset = "0x6F74A30", VA = "0x186F76030")]
	internal void OFJNODCLCGK(bool IMIFJGLLPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum JKDLDEMCDII : byte
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
internal sealed class ECBJOFNCPPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int APJCOFKDGHJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] IJFDOEIMJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] MALFENNEKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int HMADEMCLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object BNJICAHCDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public ECBJOFNCPPJ HMMJEOMFOEB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JKDLDEMCDII GAGMDOKLKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DFF0", Offset = "0x6F6C9F0", VA = "0x186F6DFF0")]
		get
		{
			return default(JKDLDEMCDII);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DD90", Offset = "0x6F6C790", VA = "0x186F6DD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte CJKHELIOLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E020", Offset = "0x6F6CA20", VA = "0x186F6E020")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DCF0", Offset = "0x6F6C6F0", VA = "0x186F6DCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort PDMHKLCACMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E110", Offset = "0x6F6CB10", VA = "0x186F6E110")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DF10", Offset = "0x6F6C910", VA = "0x186F6DF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CPDGDILJHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DCC0", Offset = "0x6F6C6C0", VA = "0x186F6DCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte JJEFGFEABMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DF50", Offset = "0x6F6C950", VA = "0x186F6DF50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DF80", Offset = "0x6F6C980", VA = "0x186F6DF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort AJLJGPNJLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DD30", Offset = "0x6F6C730", VA = "0x186F6DD30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DFB0", Offset = "0x6F6C9B0", VA = "0x186F6DFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort FJIGDBAGKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E0B0", Offset = "0x6F6CAB0", VA = "0x186F6E0B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DB80", Offset = "0x6F6C580", VA = "0x186F6DB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort OAKNCGGKMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E050", Offset = "0x6F6CA50", VA = "0x186F6E050")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DED0", Offset = "0x6F6C8D0", VA = "0x186F6DED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E170", Offset = "0x6F6CB70", VA = "0x186F6E170")]
	static ECBJOFNCPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DB50", Offset = "0x6F6C550", VA = "0x186F6DB50")]
	public void AEMEFFOMCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E430", Offset = "0x6F6CE30", VA = "0x186F6E430")]
	public ECBJOFNCPPJ(int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E4A0", Offset = "0x6F6CEA0", VA = "0x186F6E4A0")]
	public ECBJOFNCPPJ(JKDLDEMCDII MLCOAPMDJJE, int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DDD0", Offset = "0x6F6C7D0", VA = "0x186F6DDD0")]
	public static int ENLDOIJPKGG(JKDLDEMCDII MLCOAPMDJJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DE40", Offset = "0x6F6C840", VA = "0x186F6DE40")]
	public int ENLDOIJPKGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DBC0", Offset = "0x6F6C5C0", VA = "0x186F6DBC0")]
	public bool CLPLNFEMHHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum FDCFGMBPJJK : byte
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
internal enum JHEODCIEJKD
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
internal enum FGGIIAECFMG
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum EPBLKEGJDCF
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JAFNNIHKJIF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MPFBCMNEICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ECBJOFNCPPJ[] NGHHDAGONMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int DKIEPFFKMGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int EJELPKHJIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte JJEFGFEABMK;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MPFBCMNEICN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void DLJADEIMGAF(ulong KGNADHAIFFM, int OOPMNLKKOHL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int IFHAHNPAEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int AABAOMMJBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int CJCEIEHGHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double FPMBIHPPIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int HKHILNHHDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int BJAIPCGLHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int MNLFLEIAINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch NHDMJFOIALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int BLHGFHMPPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long LELLHGOCPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object GDFKHMMAELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal JAFNNIHKJIF DNNADOEIOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal JAFNNIHKJIF JCPPKNCMMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<ECBJOFNCPPJ> AHJMLKCJMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<ABDIDPFAGKH> ADOHDCDHHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly ABDIDPFAGKH[] OAJEDLGLIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int BODDLDOEFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PJIBBHCKCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool KPHHIEHHCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int OIPIOFPICJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int DBBKCBBFDBA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int MKBJFOMPPME = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int HPCGGGEMJBB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object NADMPIKGPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int FPPICBDPNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, MPFBCMNEICN> CFIBJLMFJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> CKFPOGABGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly ECBJOFNCPPJ OBPIFHEOKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int NANOAIDDCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int GGHLAJJPHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint JACJCNCJMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int FGLEAAAMEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int OLPMKBFGGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long LBJEAJLKGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte CLCECEFFIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private FDCFGMBPJJK JCBKJNEFEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private ECBJOFNCPPJ HAMIKKILIHF;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int MGBIEILFBHF = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int JGLHOCICBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly ECBJOFNCPPJ LCCENGGDMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly ECBJOFNCPPJ ADEKPHAGJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly ECBJOFNCPPJ IMHLPOBOFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly ECBJOFNCPPJ DBLHNJGOODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private ALAPBDHPHJD ENCNCCHHJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly GEHOJLIEFBO HIDCFDLGIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int KIJDDDGOGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object IOJNCMCCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly OBNPCADABGP HALDKJFHHGA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte OAJHJGNAIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA86DB0", Offset = "0xA857B0", VA = "0x180A86DB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A600", Offset = "0x6F79000", VA = "0x186F7A600")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint FFEKNKJHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public FDCFGMBPJJK ONOGDMLFFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA86DC0", Offset = "0xA857C0", VA = "0x180A86DC0")]
		get
		{
			return default(FDCFGMBPJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long MGEHDFGBNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0D440", Offset = "0xA0BE40", VA = "0x180A0D440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int OODDLALDLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x169D610", Offset = "0x169C010", VA = "0x18169D610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20E5E00", Offset = "0x20E4800", VA = "0x1820E5E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PGNNPNLGAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A710", Offset = "0x6F79110", VA = "0x186F7A710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int FGBLNKEDCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC82E30", Offset = "0xC81830", VA = "0x180C82E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double EOIIICBINBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x529D020", Offset = "0x529BA20", VA = "0x18529D020")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DLJADEIMGAF AIGFNPCCNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F79330", Offset = "0x6F77D30", VA = "0x186F79330")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F79550", Offset = "0x6F77F50", VA = "0x186F79550")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CB40", Offset = "0x6F7B540", VA = "0x186F7CB40")]
	internal JAFNNIHKJIF(GEHOJLIEFBO IGPHHGFDIEA, IPEndPoint NMNBMPFGKHL, int KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A6F0", Offset = "0x6F790F0", VA = "0x186F7A6F0")]
	internal void HIICMPOCEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F79D10", Offset = "0x6F78710", VA = "0x186F79D10")]
	internal void EKKFPBOFDGD(IPEndPoint JPDHBCDCJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F793E0", Offset = "0x6F77DE0", VA = "0x186F793E0")]
	internal void CJFADANJCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BC40", Offset = "0x6F7A640", VA = "0x186F7BC40")]
	private void LFIEOEMIGPF(int AAAHOEJCJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AEF0", Offset = "0x6F798F0", VA = "0x186F7AEF0")]
	private void KGEHJOHAOKM(int AFFHJFAGPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F79220", Offset = "0x6F77C20", VA = "0x186F79220")]
	public int BDBMFBKODPA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F79100", Offset = "0x6F77B00", VA = "0x186F79100")]
	public int BDBMFBKODPA(byte NJCGNNAMNFP, bool ENFCPNMGANC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F79B60", Offset = "0x6F78560", VA = "0x186F79B60")]
	private ABDIDPFAGKH EHKNNHPJIHN(byte IDANDMAPNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C9B0", Offset = "0x6F7B3B0", VA = "0x186F7C9B0")]
	internal JAFNNIHKJIF(GEHOJLIEFBO IGPHHGFDIEA, IPEndPoint NMNBMPFGKHL, int KHNIMGKFPOO, byte NCOJDPKOKOD, PIIHAKCBOBG ADPMCINGMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CF90", Offset = "0x6F7B990", VA = "0x186F7CF90")]
	internal JAFNNIHKJIF(GEHOJLIEFBO IGPHHGFDIEA, GKCOANHLFMJ OHOKHLNBDDB, int KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD90", Offset = "0x6F7A790", VA = "0x186F7BD90")]
	internal void MNGMJGAHGFA(ECJHLMKHFIJ DPAIHLAIILO, byte[] HPGIDELCODH, int HKECPJKDGLJ, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD10", Offset = "0x6F7A710", VA = "0x186F7BD10")]
	internal bool LNBJIMCGDPN(KCFGFPFNNON MNIANIFFOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BDE0", Offset = "0x6F7A7E0", VA = "0x186F7BDE0")]
	public void OOFIDCNAHBJ(byte[] HPGIDELCODH, int HKECPJKDGLJ, int EIJGIDNMHGP, DPLFLBMIAKL LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A720", Offset = "0x6F79120", VA = "0x186F7A720")]
	private void IIMIOAEOIBH(byte[] HPGIDELCODH, int HKECPJKDGLJ, int EIJGIDNMHGP, byte NJCGNNAMNFP, DPLFLBMIAKL EFIHPGJDAGJ, object IOIPIHCJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B1F0", Offset = "0x6F79BF0", VA = "0x186F7B1F0")]
	public void KJDHDFALAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F79470", Offset = "0x6F77E70", VA = "0x186F79470")]
	internal FGGIIAECFMG DHKJICKDNIM(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return default(FGGIIAECFMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BBE0", Offset = "0x6F7A5E0", VA = "0x186F7BBE0")]
	internal void KPPNJOHBECO(ABDIDPFAGKH HLFGMKBGEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F78DF0", Offset = "0x6F777F0", VA = "0x186F78DF0")]
	internal EPBLKEGJDCF AMMNDEIHGDJ(byte[] HPGIDELCODH, int HKECPJKDGLJ, int EIJGIDNMHGP, bool BOOINJJDCOC)
	{
		return default(EPBLKEGJDCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A6B0", Offset = "0x6F790B0", VA = "0x186F7A6B0")]
	private void HIHIBOPHCDP(int JOFEPLOOBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B240", Offset = "0x6F79C40", VA = "0x186F7B240")]
	internal void KLHEKPGDJKB(DPLFLBMIAKL PAANMNLCKIA, ECBJOFNCPPJ ADAFNPDOCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F79600", Offset = "0x6F78000", VA = "0x186F79600")]
	private void EBLNMLPMEJJ(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C620", Offset = "0x6F7B020", VA = "0x186F7C620")]
	private void PNMJPHHGJFB(int HMAHKNFCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AD30", Offset = "0x6F79730", VA = "0x186F7AD30")]
	internal JHEODCIEJKD KCJDDJMNALK(ECJHLMKHFIJ BPHKMKECJKG)
	{
		return default(JHEODCIEJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BF60", Offset = "0x6F7A960", VA = "0x186F7BF60")]
	internal void PMCCCBFOLKD(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE10", Offset = "0x6F7A810", VA = "0x186F7BE10")]
	private void OOHKCDMDBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F79D40", Offset = "0x6F78740", VA = "0x186F79D40")]
	internal void FHINGOJAJMK(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F79F40", Offset = "0x6F78940", VA = "0x186F79F40")]
	internal void FPILOHDMIEH(int HMAHKNFCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AF30", Offset = "0x6F79930", VA = "0x186F7AF30")]
	internal void KHIJNPIHHAK(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OBNPCADABGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long JNGIGNLDOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long KDHFJEGNJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long KOPLALGKEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long FBEEALMIIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long NAGPDHBDMMI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long ANJILJKIFJO;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long BLPCDFBBCAD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long FBKKFENCAIO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long IGLBOHMOHGL;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long OGGCCEJJFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long DFKPJLLFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long ENDJEACMGEE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long NFLBHIPOOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F81AD0", Offset = "0x6F804D0", VA = "0x186F81AD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FBLGDDNLMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DB0", Offset = "0x6F807B0", VA = "0x186F81DB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CGJIEJPBGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F81A10", Offset = "0x6F80410", VA = "0x186F81A10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long ECIKIMLNOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F81E20", Offset = "0x6F80820", VA = "0x186F81E20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long EPIBOLHBPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F81A00", Offset = "0x6F80400", VA = "0x186F81A00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long LGLMPABICJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DC0", Offset = "0x6F807C0", VA = "0x186F81DC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long BIAPPBJIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F81D10", Offset = "0x6F80710", VA = "0x186F81D10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long HNNMJPDFLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DE0", Offset = "0x6F807E0", VA = "0x186F81DE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private ALAPBDHPHJD JFBEOHEPGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DD0", Offset = "0x6F807D0", VA = "0x186F81DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double MLGEPCJLMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F81A70", Offset = "0x6F80470", VA = "0x186F81A70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F819C0", Offset = "0x6F803C0", VA = "0x186F819C0")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F81B80", Offset = "0x6F80580", VA = "0x186F81B80")]
	public void DIBOANOEAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F81A20", Offset = "0x6F80420", VA = "0x186F81A20")]
	public void BMGFGALIHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F81BE0", Offset = "0x6F805E0", VA = "0x186F81BE0")]
	public void EHMIPEOBBBE(long FHJHNBMDFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F81D50", Offset = "0x6F80750", VA = "0x186F81D50")]
	public void HCBDGBJBPFH(long PDJEDMBDIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F81CB0", Offset = "0x6F806B0", VA = "0x186F81CB0")]
	public void GELFEGODMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6F81C40", Offset = "0x6F80640", VA = "0x186F81C40")]
	public void EOMEIIGDPKB(long GLDNGMGNOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F81E30", Offset = "0x6F80830", VA = "0x186F81E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6F81AE0", Offset = "0x6F804E0", VA = "0x186F81AE0")]
	public void CKKMMCHAKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OBNPCADABGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GOKDIBMKOJE
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> EFJNFMHJJFH;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F770D0", Offset = "0x6F75AD0", VA = "0x186F770D0")]
	public static IPEndPoint NJMGGNOKEEO(string MOOPFCCOKHG, int DFABKDKFFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F76F00", Offset = "0x6F75900", VA = "0x186F76F00")]
	public static IPAddress BAFJEMKEKDK(string MOOPFCCOKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F76E70", Offset = "0x6F75870", VA = "0x186F76E70")]
	public static IPAddress BAFJEMKEKDK(string MOOPFCCOKHG, AddressFamily DFEBDDJMECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F77320", Offset = "0x6F75D20", VA = "0x186F77320")]
	internal static int OOCLMNPBNMC(int MNMJKFOHHHE, int LMMABDJIADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3A78CE0", Offset = "0x3A776E0", VA = "0x183A78CE0")]
	internal static T[] CFEAJBKBLKM<T>(int IMCIONKBBCL) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KFKENEJCHCO : ABDIDPFAGKH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct EJKHCPGFNGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private ECBJOFNCPPJ DCPBNMDBOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long PMEAPAOAIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool PNKPNDKIKFG;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB60", Offset = "0x6F6D560", VA = "0x186F6EB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EAF0", Offset = "0x6F6D4F0", VA = "0x186F6EAF0")]
		public void JBAOHJPBOCM(ECBJOFNCPPJ MNIANIFFOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EA80", Offset = "0x6F6D480", VA = "0x186F6EA80")]
		public bool IDEEAFPLCHO(long HAGDKDAABGH, JAFNNIHKJIF PIODJLCLADE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB10", Offset = "0x6F6D510", VA = "0x186F6EB10")]
		public bool MPMJEFEEPDP(JAFNNIHKJIF PIODJLCLADE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ECBJOFNCPPJ MFIAMNALNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly EJKHCPGFNGC[] EBMAACJKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly ECBJOFNCPPJ[] NEHMLGPLBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] PHJDIBHHBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int IPFIHINKFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int PANFKLPGEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int GNGJBPKGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int IBLKFFPBCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool PHMJDOKALPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly DPLFLBMIAKL FGNELOJHMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool EEDAFJEBFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int IGANIHMGHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte IMMBDAHMIPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DFDMNKPOKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DBB0", Offset = "0x6F7C5B0", VA = "0x186F7DBB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E5E0", Offset = "0x6F7CFE0", VA = "0x186F7E5E0")]
	public KFKENEJCHCO(JAFNNIHKJIF PIODJLCLADE, bool ENFCPNMGANC, byte KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DBC0", Offset = "0x6F7C5C0", VA = "0x186F7DBC0")]
	private void OJCKMJPAFIO(ECBJOFNCPPJ MNIANIFFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D6E0", Offset = "0x6F7C0E0", VA = "0x186F7D6E0", Slot = "4")]
	protected override bool GAHEIFIMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DF80", Offset = "0x6F7C980", VA = "0x186F7DF80", Slot = "5")]
	public override bool PMCCCBFOLKD(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PAADEJHIKMN : ABDIDPFAGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int LCIKLPNLLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort PANFKLPGEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool BAEAOMDOFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private ECBJOFNCPPJ FEJCNAICLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly ECBJOFNCPPJ CBFHGHOJBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool DBCDBAMBFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte IMMBDAHMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long LIIJMBGIEID;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F82DB0", Offset = "0x6F817B0", VA = "0x186F82DB0")]
	public PAADEJHIKMN(JAFNNIHKJIF PIODJLCLADE, bool GDMDGDKJEAJ, byte KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F82610", Offset = "0x6F81010", VA = "0x186F82610", Slot = "4")]
	protected override bool GAHEIFIMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6F82AD0", Offset = "0x6F814D0", VA = "0x186F82AD0", Slot = "5")]
	public override bool PMCCCBFOLKD(ECBJOFNCPPJ MNIANIFFOKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LHEGHPPMJDL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KBPBLMGOKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong IKNJJHFJEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double GMLBAHMCPNA;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct KEAJMBDKAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int AODLDAIPEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float MLBAONEPDKO;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BE10", Offset = "0x6F6A810", VA = "0x186F6BE10")]
	private static void LEHGDLDIJDC(byte[] NNHDOHEKGEG, int BACDJHJBLPL, ulong HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E7B0", Offset = "0x6F7D1B0", VA = "0x186F7E7B0")]
	private static void LEHGDLDIJDC(byte[] NNHDOHEKGEG, int BACDJHJBLPL, int HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E820", Offset = "0x6F7D220", VA = "0x186F7E820")]
	public static void LEHGDLDIJDC(byte[] NNHDOHEKGEG, int BACDJHJBLPL, short HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E870", Offset = "0x6F7D270", VA = "0x186F7E870")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, double PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E890", Offset = "0x6F7D290", VA = "0x186F7E890")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E820", Offset = "0x6F7D220", VA = "0x186F7E820")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, short PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E820", Offset = "0x6F7D220", VA = "0x186F7E820")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, ushort PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E7B0", Offset = "0x6F7D1B0", VA = "0x186F7E7B0")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E7B0", Offset = "0x6F7D1B0", VA = "0x186F7E7B0")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, uint PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E860", Offset = "0x6F7D260", VA = "0x186F7E860")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E860", Offset = "0x6F7D260", VA = "0x186F7E860")]
	public static void CIDLNIPLHKK(byte[] OKLLDHNGOMI, int OBKGKEGIECO, ulong PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NAKMIGIEJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] NCKMCOFLEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int FKDPDJLFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int DMKFBAAFNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int MFCCCIIGLLE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] MALFENNEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HCGGJNLKLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DIIICGBLNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6F81890", Offset = "0x6F80290", VA = "0x186F81890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LPCMOPMOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27C3E30", Offset = "0x27C2830", VA = "0x1827C3E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FAOIPODHNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6F81450", Offset = "0x6F7FE50", VA = "0x186F81450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F81550", Offset = "0x6F7FF50", VA = "0x186F81550")]
	public void LNCJJCHJEBH(byte[] CHCCOOMJKLJ, int BACDJHJBLPL, int DGGCKOAIJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public NAKMIGIEJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F81960", Offset = "0x6F80360", VA = "0x186F81960")]
	public NAKMIGIEJPJ(byte[] CHCCOOMJKLJ, int BACDJHJBLPL, int DGGCKOAIJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F81130", Offset = "0x6F7FB30", VA = "0x186F81130")]
	public IPEndPoint EGBMNHKOOBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F80DA0", Offset = "0x6F7F7A0", VA = "0x186F80DA0")]
	public byte IFOGPFEJINK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F80DA0", Offset = "0x6F7F7A0", VA = "0x186F80DA0")]
	public sbyte BHKCIMALNCA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4D00", Offset = "0x3BB3700", VA = "0x183BB4D00")]
	public T[] LCOGMHJKIFL<T>(ushort OPKPFANIILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F814A0", Offset = "0x6F7FEA0", VA = "0x186F814A0")]
	public bool[] KGENAOALKAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F818E0", Offset = "0x6F802E0", VA = "0x186F818E0")]
	public ushort[] POKGKGPECNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F81460", Offset = "0x6F7FE60", VA = "0x186F81460")]
	public short[] JONOJMCGCBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6F80D60", Offset = "0x6F7F760", VA = "0x186F80D60")]
	public int[] APGKGBNCDHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6F81920", Offset = "0x6F80320", VA = "0x186F81920")]
	public uint[] PPJEJPOPOEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F81200", Offset = "0x6F7FC00", VA = "0x186F81200")]
	public float[] ENBPDMNHFII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F80DE0", Offset = "0x6F7F7E0", VA = "0x186F80DE0")]
	public double[] COIICNHNIDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F812F0", Offset = "0x6F7FCF0", VA = "0x186F812F0")]
	public long[] GPBLAFKEGAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F81240", Offset = "0x6F7FC40", VA = "0x186F81240")]
	public ulong[] ENCFLMBAGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F81590", Offset = "0x6F7FF90", VA = "0x186F81590")]
	public string[] MGAKMHDAMCO(int GLPAMFONIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6F817E0", Offset = "0x6F801E0", VA = "0x186F817E0")]
	public bool NCFJCMFAIOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6F813E0", Offset = "0x6F7FDE0", VA = "0x186F813E0")]
	public char IKCLJBEAJAG()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6F813E0", Offset = "0x6F7FDE0", VA = "0x186F813E0")]
	public ushort JOGLNPDJPOG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6F810C0", Offset = "0x6F7FAC0", VA = "0x186F810C0")]
	public short EGBEIFBHGCO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6F81770", Offset = "0x6F80170", VA = "0x186F81770")]
	public long MPODGEFHBBE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6F80E20", Offset = "0x6F7F820", VA = "0x186F80E20")]
	public ulong DJKCCMMKMKN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6F816E0", Offset = "0x6F800E0", VA = "0x186F816E0")]
	public int MJMDKPOHKJH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6F814E0", Offset = "0x6F7FEE0", VA = "0x186F814E0")]
	public uint KMILDMMPJDH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6F81280", Offset = "0x6F7FC80", VA = "0x186F81280")]
	public float GENDHKLLGJN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6F81820", Offset = "0x6F80220", VA = "0x186F81820")]
	public double OMOLFAGPGHH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6F80E90", Offset = "0x6F7F890", VA = "0x186F80E90")]
	public string EBACJPNJKAA(int GDNCKEELMHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6F81330", Offset = "0x6F7FD30", VA = "0x186F81330")]
	public ArraySegment<byte> HECHMJJEKNN(int IMCIONKBBCL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6F818A0", Offset = "0x6F802A0", VA = "0x186F818A0")]
	public sbyte[] PNLLJGEGLDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6F813A0", Offset = "0x6F7FDA0", VA = "0x186F813A0")]
	public byte[] IFCGBKBNCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6F81750", Offset = "0x6F80150", VA = "0x186F81750")]
	public void MPMJEFEEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PIIHAKCBOBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] NCKMCOFLEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int FKDPDJLFLFN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int AKLKMCILMON = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool HHIMOFAJCKI;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding IGIHGBPNGGE;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int JMOFDONOJLI = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] EBECELGNLHD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] JLKLNDPHPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6F83C30", Offset = "0x6F82630", VA = "0x186F83C30")]
	public PIIHAKCBOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6F83B90", Offset = "0x6F82590", VA = "0x186F83B90")]
	public PIIHAKCBOBG(bool MAKKOKLECHP, int PAMDGLNNCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6F82E70", Offset = "0x6F81870", VA = "0x186F82E70")]
	public static PIIHAKCBOBG DJLEDOMIFPC(string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6F83620", Offset = "0x6F82020", VA = "0x186F83620")]
	public void KCMGPDKLBFF(int FPOEBBHABIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x283D780", Offset = "0x283C180", VA = "0x18283D780")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6F83570", Offset = "0x6F81F70", VA = "0x186F83570")]
	public void FLDLMMOBDIP(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6F833E0", Offset = "0x6F81DE0", VA = "0x186F833E0")]
	public void FLDLMMOBDIP(double PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6F82FC0", Offset = "0x6F819C0", VA = "0x186F82FC0")]
	public void FLDLMMOBDIP(long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6F82FC0", Offset = "0x6F819C0", VA = "0x186F82FC0")]
	public void FLDLMMOBDIP(ulong PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F830E0", Offset = "0x6F81AE0", VA = "0x186F830E0")]
	public void FLDLMMOBDIP(int PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6F830E0", Offset = "0x6F81AE0", VA = "0x186F830E0")]
	public void FLDLMMOBDIP(uint PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6F83010", Offset = "0x6F81A10", VA = "0x186F83010")]
	public void FLDLMMOBDIP(char PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6F83010", Offset = "0x6F81A10", VA = "0x186F83010")]
	public void FLDLMMOBDIP(ushort PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6F83010", Offset = "0x6F81A10", VA = "0x186F83010")]
	public void FLDLMMOBDIP(short PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6F83080", Offset = "0x6F81A80", VA = "0x186F83080")]
	public void FLDLMMOBDIP(sbyte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F83080", Offset = "0x6F81A80", VA = "0x186F83080")]
	public void FLDLMMOBDIP(byte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F83430", Offset = "0x6F81E30", VA = "0x186F83430")]
	public void FLDLMMOBDIP(byte[] HPGIDELCODH, int BACDJHJBLPL, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EE0", Offset = "0x6F818E0", VA = "0x186F82EE0")]
	public void FFFDJDCNBHN(sbyte[] HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EE0", Offset = "0x6F818E0", VA = "0x186F82EE0")]
	public void OBGFAOBJEKI(byte[] HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F83170", Offset = "0x6F81B70", VA = "0x186F83170")]
	public void FLDLMMOBDIP(bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83880", Offset = "0x6F82280", VA = "0x186F83880")]
	public void LKOOKMGMKNA(Array ABLCJNGADLL, int OBBPJGJPKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6F83960", Offset = "0x6F82360", VA = "0x186F83960")]
	public void LKOOKMGMKNA(float[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6F837A0", Offset = "0x6F821A0", VA = "0x186F837A0")]
	public void LKOOKMGMKNA(double[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6F837A0", Offset = "0x6F821A0", VA = "0x186F837A0")]
	public void LKOOKMGMKNA(long[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F837A0", Offset = "0x6F821A0", VA = "0x186F837A0")]
	public void LKOOKMGMKNA(ulong[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F83960", Offset = "0x6F82360", VA = "0x186F83960")]
	public void LKOOKMGMKNA(int[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F83960", Offset = "0x6F82360", VA = "0x186F83960")]
	public void LKOOKMGMKNA(uint[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F836C0", Offset = "0x6F820C0", VA = "0x186F836C0")]
	public void LKOOKMGMKNA(ushort[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F836C0", Offset = "0x6F820C0", VA = "0x186F836C0")]
	public void LKOOKMGMKNA(short[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EE0", Offset = "0x6F818E0", VA = "0x186F82EE0")]
	public void LKOOKMGMKNA(bool[] PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F83A40", Offset = "0x6F82440", VA = "0x186F83A40")]
	public void LKOOKMGMKNA(string[] PCDAHJCDHHF, int KFDDHLPBPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6F834A0", Offset = "0x6F81EA0", VA = "0x186F834A0")]
	public void FLDLMMOBDIP(IPEndPoint MCOAFFEFDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6F83610", Offset = "0x6F82010", VA = "0x186F83610")]
	public void FLDLMMOBDIP(string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6F831D0", Offset = "0x6F81BD0", VA = "0x186F831D0")]
	public void FLDLMMOBDIP(string PCDAHJCDHHF, int GDNCKEELMHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HFCHNFAIOEA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class LHLLABGPEEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong KIJDDDGOGCE;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x528AF20", Offset = "0x5289920", VA = "0x18528AF20")]
		static LHLLABGPEEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void FEPADGGDJHK(NAKMIGIEJPJ LJMOCEGEAFH, object IOIPIHCJNEI);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NEFJJPCPANH<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public HFCHNFAIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NEFJJPCPANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x54FEF10", Offset = "0x54FD910", VA = "0x1854FEF10")]
		internal void MMAGLDADJFI(NAKMIGIEJPJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DCLOFCDACGM<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public HFCHNFAIOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DCLOFCDACGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA160", Offset = "0x6AD8B60", VA = "0x186ADA160")]
		internal void MMAGLDADJFI(NAKMIGIEJPJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly CJHDEPNMIOF DJHJOEJALHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, FEPADGGDJHK> BINLGMDGAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly PIIHAKCBOBG HKLICDFJENF;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6F775E0", Offset = "0x6F75FE0", VA = "0x186F775E0")]
	public HFCHNFAIOEA(int GLPAMFONIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3002660", Offset = "0x3001060", VA = "0x183002660", Slot = "4")]
	protected virtual ulong ADDNLGDBAPC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6F77460", Offset = "0x6F75E60", VA = "0x186F77460", Slot = "5")]
	protected virtual FEPADGGDJHK KHBFPOBEIGA(NAKMIGIEJPJ LJMOCEGEAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D430", Offset = "0x3A7BE30", VA = "0x183A7D430", Slot = "6")]
	protected virtual void PKONNHCIDEE<T>(PIIHAKCBOBG EDJIMCINKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6F773E0", Offset = "0x6F75DE0", VA = "0x186F773E0")]
	public void HEBKDDAIGIE(NAKMIGIEJPJ LJMOCEGEAFH, object IOIPIHCJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D3A0", Offset = "0x3A7BDA0", VA = "0x183A7D3A0")]
	public void EDMCADMCJAO<T>(PIIHAKCBOBG EDJIMCINKFD, T MNIANIFFOKJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6F77590", Offset = "0x6F75F90", VA = "0x186F77590")]
	public void LOLOLJIOPAI(NAKMIGIEJPJ LJMOCEGEAFH, object IOIPIHCJNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D220", Offset = "0x3A7BC20", VA = "0x183A7D220")]
	public void DHKEHFHGMNL<T>(Action<T> CBLOEHACIHG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D0A0", Offset = "0x3A7BAA0", VA = "0x183A7D0A0")]
	public void DHKEHFHGMNL<T, TUserData>(Action<T, TUserData> CBLOEHACIHG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AJIOMCDAKEF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C600", Offset = "0x6F6B000", VA = "0x186F6C600")]
	public AJIOMCDAKEF(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OLAMGDJJMHJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6F82190", Offset = "0x6F80B90", VA = "0x186F82190")]
	public OLAMGDJJMHJ(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class CJHDEPNMIOF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum LEFMPEDLEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class JLONNAGIMBI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public LEFMPEDLEIG GLEDFKBBOKL;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x50AB5A0", Offset = "0x50A9FA0", VA = "0x1850AB5A0", Slot = "4")]
		public virtual void JBAOHJPBOCM(MethodInfo OAMHFMKINHL, MethodInfo GCAKIJADMCH, LEFMPEDLEIG HHCAOFMCNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ECFNKOEAGNH(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JIMJHOIGMML(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		protected JLONNAGIMBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BFBMOKMAPHJ<TClass, TProperty> : JLONNAGIMBI<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> BMKMLPJGLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> BGEGJILHCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> OLJMNDCMLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> GNJDECACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> HAFJLOFLJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> FNFJDOFGGOK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x602D680", Offset = "0x602C080", VA = "0x18602D680", Slot = "7")]
		public override void FMAAEEIFGOD(TClass BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x602C6C0", Offset = "0x602B0C0", VA = "0x18602C6C0", Slot = "8")]
		public override void ENNMFIJAMCB(TClass BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x602BFC0", Offset = "0x602A9C0", VA = "0x18602BFC0", Slot = "9")]
		public override void ECFNKOEAGNH(TClass BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60325D0", Offset = "0x6030FD0", VA = "0x1860325D0", Slot = "10")]
		public override void JIMJHOIGMML(TClass BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6032B10", Offset = "0x6031510", VA = "0x186032B10")]
		protected TProperty[] LPAJBOLJFAO(TClass BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x602B4D0", Offset = "0x6029ED0", VA = "0x18602B4D0")]
		protected TProperty[] DEJDBGMNIHH(TClass BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x602F8C0", Offset = "0x602E2C0", VA = "0x18602F8C0", Slot = "4")]
		public override void JBAOHJPBOCM(MethodInfo OAMHFMKINHL, MethodInfo GCAKIJADMCH, LEFMPEDLEIG HHCAOFMCNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6032C00", Offset = "0x6031600", VA = "0x186032C00")]
		protected BFBMOKMAPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class KKIJFPJNGAI<TClass, TProperty> : BFBMOKMAPHJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CFCIJOBOCED(NAKMIGIEJPJ FGEFHKAEIPE, [Out] TProperty NOGDOCFGMID);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void NHAJDONNPCG(PIIHAKCBOBG KEOEKIBOANH, TProperty NOGDOCFGMID);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51CEF50", Offset = "0x51CD950", VA = "0x1851CEF50", Slot = "5")]
		public override void NHDANIJBDLK(TClass BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51CEBE0", Offset = "0x51CD5E0", VA = "0x1851CEBE0", Slot = "6")]
		public override void EDMCADMCJAO(TClass BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x51CED90", Offset = "0x51CD790", VA = "0x1851CED90", Slot = "7")]
		public override void FMAAEEIFGOD(TClass BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x51CEC50", Offset = "0x51CD650", VA = "0x1851CEC50", Slot = "8")]
		public override void ENNMFIJAMCB(TClass BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x467DD70", Offset = "0x467C770", VA = "0x18467DD70")]
		protected KKIJFPJNGAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class PDOEIJAAOLL<T> : BFBMOKMAPHJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5759AD0", Offset = "0x57584D0", VA = "0x185759AD0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5759A20", Offset = "0x5758420", VA = "0x185759A20", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5759A70", Offset = "0x5758470", VA = "0x185759A70", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x50C9240", Offset = "0x50C7C40", VA = "0x1850C9240", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public PDOEIJAAOLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PGEIPGMEPJE<T> : BFBMOKMAPHJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x57615E0", Offset = "0x575FFE0", VA = "0x1857615E0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5759A20", Offset = "0x5758420", VA = "0x185759A20", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5761580", Offset = "0x575FF80", VA = "0x185761580", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x50C9240", Offset = "0x50C7C40", VA = "0x1850C9240", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public PGEIPGMEPJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class KCFHAKFNAJO<T> : BFBMOKMAPHJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5180510", Offset = "0x517EF10", VA = "0x185180510", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BC30", Offset = "0x4B3A630", VA = "0x184B3BC30", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x51804B0", Offset = "0x517EEB0", VA = "0x1851804B0", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BC80", Offset = "0x4B3A680", VA = "0x184B3BC80", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public KCFHAKFNAJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class FGKIPEDKLIH<T> : BFBMOKMAPHJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BD30", Offset = "0x4B3A730", VA = "0x184B3BD30", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BC30", Offset = "0x4B3A630", VA = "0x184B3BC30", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BCD0", Offset = "0x4B3A6D0", VA = "0x184B3BCD0", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BC80", Offset = "0x4B3A680", VA = "0x184B3BC80", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public FGKIPEDKLIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EEMAJGKKMFO<T> : BFBMOKMAPHJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x468EA80", Offset = "0x468D480", VA = "0x18468EA80", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x468E980", Offset = "0x468D380", VA = "0x18468E980", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x468EA20", Offset = "0x468D420", VA = "0x18468EA20", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x468E9D0", Offset = "0x468D3D0", VA = "0x18468E9D0", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public EEMAJGKKMFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class FJOJCGGAPNL<T> : BFBMOKMAPHJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4B4C290", Offset = "0x4B4AC90", VA = "0x184B4C290", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x468E980", Offset = "0x468D380", VA = "0x18468E980", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4B4C230", Offset = "0x4B4AC30", VA = "0x184B4C230", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x468E9D0", Offset = "0x468D3D0", VA = "0x18468E9D0", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public FJOJCGGAPNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MGHNJAEDFHB<T> : BFBMOKMAPHJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x547E430", Offset = "0x547CE30", VA = "0x18547E430", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x547E330", Offset = "0x547CD30", VA = "0x18547E330", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x547E3D0", Offset = "0x547CDD0", VA = "0x18547E3D0", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x547E380", Offset = "0x547CD80", VA = "0x18547E380", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public MGHNJAEDFHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DGNBGOLMFIG<T> : BFBMOKMAPHJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x547E430", Offset = "0x547CE30", VA = "0x18547E430", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x547E330", Offset = "0x547CD30", VA = "0x18547E330", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFE40", Offset = "0x6AEE840", VA = "0x186AEFE40", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x547E380", Offset = "0x547CD80", VA = "0x18547E380", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public DGNBGOLMFIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class JOLKFGCAMNP<T> : BFBMOKMAPHJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x50C92F0", Offset = "0x50C7CF0", VA = "0x1850C92F0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x50C91F0", Offset = "0x50C7BF0", VA = "0x1850C91F0", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x50C9290", Offset = "0x50C7C90", VA = "0x1850C9290", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x50C9240", Offset = "0x50C7C40", VA = "0x1850C9240", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public JOLKFGCAMNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BGJCDLLNMPM<T> : BFBMOKMAPHJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x610E5D0", Offset = "0x610CFD0", VA = "0x18610E5D0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x610E520", Offset = "0x610CF20", VA = "0x18610E520", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x610E570", Offset = "0x610CF70", VA = "0x18610E570", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x468E9D0", Offset = "0x468D3D0", VA = "0x18468E9D0", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public BGJCDLLNMPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NPAMKAJOGHJ<T> : BFBMOKMAPHJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5554D80", Offset = "0x5553780", VA = "0x185554D80", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5554CD0", Offset = "0x55536D0", VA = "0x185554CD0", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5554D20", Offset = "0x5553720", VA = "0x185554D20", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x547E380", Offset = "0x547CD80", VA = "0x18547E380", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x468EAE0", Offset = "0x468D4E0", VA = "0x18468EAE0")]
		public NPAMKAJOGHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JGMOFMIICAB<T> : KKIJFPJNGAI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5097330", Offset = "0x5095D30", VA = "0x185097330", Slot = "12")]
		protected override void NHAJDONNPCG(PIIHAKCBOBG KEOEKIBOANH, char NOGDOCFGMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5097300", Offset = "0x5095D00", VA = "0x185097300", Slot = "11")]
		protected override void CFCIJOBOCED(NAKMIGIEJPJ FGEFHKAEIPE, [Out] char NOGDOCFGMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
		public JGMOFMIICAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JDBHPAJPCFI<T> : KKIJFPJNGAI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x50556B0", Offset = "0x50540B0", VA = "0x1850556B0", Slot = "12")]
		protected override void NHAJDONNPCG(PIIHAKCBOBG KEOEKIBOANH, IPEndPoint NOGDOCFGMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5055670", Offset = "0x5054070", VA = "0x185055670", Slot = "11")]
		protected override void CFCIJOBOCED(NAKMIGIEJPJ FGEFHKAEIPE, [Out] IPEndPoint NOGDOCFGMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
		public JDBHPAJPCFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class LDPHFELDCAO<T> : BFBMOKMAPHJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int DOHKCFDOGEM;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5278E20", Offset = "0x5277820", VA = "0x185278E20")]
		public LDPHFELDCAO(int GDNCKEELMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5278DB0", Offset = "0x52777B0", VA = "0x185278DB0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5278C80", Offset = "0x5277680", VA = "0x185278C80", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5278D40", Offset = "0x5277740", VA = "0x185278D40", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5278CE0", Offset = "0x52776E0", VA = "0x185278CE0", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FIEBBOEAABB<T> : JLONNAGIMBI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo GAGMDOKLKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type CPOIPEOHOMF;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B41770", Offset = "0x4B40170", VA = "0x184B41770")]
		public FIEBBOEAABB(PropertyInfo MLCOAPMDJJE, Type NOKPPDOGAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B416B0", Offset = "0x4B400B0", VA = "0x184B416B0", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B414E0", Offset = "0x4B3FEE0", VA = "0x184B414E0", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4B415F0", Offset = "0x4B3FFF0", VA = "0x184B415F0", Slot = "7")]
		public override void FMAAEEIFGOD(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B41590", Offset = "0x4B3FF90", VA = "0x184B41590", Slot = "8")]
		public override void ENNMFIJAMCB(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4B41480", Offset = "0x4B3FE80", VA = "0x184B41480", Slot = "9")]
		public override void ECFNKOEAGNH(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B41650", Offset = "0x4B40050", VA = "0x184B41650", Slot = "10")]
		public override void JIMJHOIGMML(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JHGGMNNFBOC<T> : FIEBBOEAABB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
		public JHGGMNNFBOC(PropertyInfo MLCOAPMDJJE, Type NOKPPDOGAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5097520", Offset = "0x5095F20", VA = "0x185097520", Slot = "5")]
		public override void NHDANIJBDLK(T BCBLKIEHGLA, NAKMIGIEJPJ FGEFHKAEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5097470", Offset = "0x5095E70", VA = "0x185097470", Slot = "6")]
		public override void EDMCADMCJAO(T BCBLKIEHGLA, PIIHAKCBOBG KEOEKIBOANH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class ALDPACJJMEB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static ALDPACJJMEB<T> FDCAMNOGINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly JLONNAGIMBI<T>[] FKIICBFMLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int INEJKAEEBOJ;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4F71880", Offset = "0x4F70280", VA = "0x184F71880")]
		public ALDPACJJMEB(List<JLONNAGIMBI<T>> HOHMEPEPPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4F71720", Offset = "0x4F70120", VA = "0x184F71720")]
		public void EDMCADMCJAO(T OJDHMKOBKLD, PIIHAKCBOBG EDJIMCINKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F717D0", Offset = "0x4F701D0", VA = "0x184F717D0")]
		public void NHDANIJBDLK(T OJDHMKOBKLD, NAKMIGIEJPJ LJMOCEGEAFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class AGJLLKLMOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JLONNAGIMBI<T> IBPMNADNGOO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private PIIHAKCBOBG IFDEBKDBDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int GHDHGJGDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, AGJLLKLMOBA> CGCAIBJCCGK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D9B0", Offset = "0x6F6C3B0", VA = "0x186F6D9B0")]
	public CJHDEPNMIOF(int GLPAMFONIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3851110", Offset = "0x384FB10", VA = "0x183851110")]
	private ALDPACJJMEB<T> FPAPPJDDBGB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D20", Offset = "0x2FF0720", VA = "0x182FF1D20")]
	public void EPIAMCEAEFP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3851FE0", Offset = "0x38509E0", VA = "0x183851FE0")]
	public bool PGEPBAPICDN<T>(NAKMIGIEJPJ LJMOCEGEAFH, T DKLAGICAOGN) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3852060", Offset = "0x3850A60", VA = "0x183852060")]
	public void PGPOMLMDCHO<T>(PIIHAKCBOBG EDJIMCINKFD, T OJDHMKOBKLD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CHNAELELIEO
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime GDFJNMLLEOE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] FPKHFIMGCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KFJGLFGBJDO NLPLIJFMADL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D110", Offset = "0x6F6BB10", VA = "0x186F6D110")]
		get
		{
			return default(KFJGLFGBJDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int PFAFMALDBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D140", Offset = "0x6F6BB40", VA = "0x186F6D140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D260", Offset = "0x6F6BC60", VA = "0x186F6D260")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public OBBBBBJBICM BCKGFBFOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D170", Offset = "0x6F6BB70", VA = "0x186F6D170")]
		get
		{
			return default(OBBBBBJBICM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CD90", Offset = "0x6F6B790", VA = "0x186F6CD90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int LCBILGFBNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CE00", Offset = "0x6F6B800", VA = "0x186F6CE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint DDKJCMCHGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D2A0", Offset = "0x6F6BCA0", VA = "0x186F6D2A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KHMKNHDFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CB00", Offset = "0x6F6B500", VA = "0x186F6CB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? JDCDOEOBFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CDD0", Offset = "0x6F6B7D0", VA = "0x186F6CDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? IFLPKOLEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CE30", Offset = "0x6F6B830", VA = "0x186F6CE30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D3B0", Offset = "0x6F6BDB0", VA = "0x186F6D3B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? CNBKLFLMNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xE5DBD0", Offset = "0xE5C5D0", VA = "0x180E5DBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D5E0", Offset = "0x6F6BFE0", VA = "0x186F6D5E0")]
	public CHNAELELIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D900", Offset = "0x6F6C300", VA = "0x186F6D900")]
	internal CHNAELELIEO(byte[] OKLLDHNGOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C7E0", Offset = "0x6F6B1E0", VA = "0x186F6C7E0")]
	public static CHNAELELIEO BBILJCCCJGM(byte[] OKLLDHNGOMI, DateTime OMOFNLFAKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CB90", Offset = "0x6F6B590", VA = "0x186F6CB90")]
	internal void EMPKDOPLKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CF30", Offset = "0x6F6B930", VA = "0x186F6CF30")]
	private void KIOHKDGGMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C900", Offset = "0x6F6B300", VA = "0x186F6C900")]
	private DateTime? DKLOHEFMCGJ(int BACDJHJBLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C610", Offset = "0x6F6B010", VA = "0x186F6C610")]
	private void APCGBFGAJPN(int BACDJHJBLPL, DateTime? PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CE60", Offset = "0x6F6B860", VA = "0x186F6CE60")]
	private ulong KILHEEDLEHE(int BACDJHJBLPL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D1A0", Offset = "0x6F6BBA0", VA = "0x186F6D1A0")]
	private void NMBOKHNOKCO(int BACDJHJBLPL, ulong PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D320", Offset = "0x6F6BD20", VA = "0x186F6D320")]
	private uint OPKFOAJFHDP(int BACDJHJBLPL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6E37F60", Offset = "0x6E36960", VA = "0x186E37F60")]
	private static uint EHJFEKLHIJL(uint CBPCNABIALH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CB30", Offset = "0x6F6B530", VA = "0x186F6CB30")]
	private static ulong EHJFEKLHIJL(ulong CBPCNABIALH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum KFJGLFGBJDO
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
public enum OBBBBBJBICM
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class DFKKJMBNPDL
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int KNMHPKKAFDN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int ICBGCIFGDBE = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int EMGEJLEHGAM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint EAJGHGJBLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int AALKOKFOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int AELAEAGONAO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HLNJDBOFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DA50", Offset = "0x6F6C450", VA = "0x186F6DA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DA60", Offset = "0x6F6C460", VA = "0x186F6DA60")]
	public bool OOFIDCNAHBJ(CHIICCBAAFB IGDAJGLONHG, int FDFNAMJJMBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class PMCAEOOPIIL : CHIICCBAAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket IGDAJGLONHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly GEHOJLIEFBO IGPHHGFDIEA;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short GDGIMGFCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F83CD0", Offset = "0x6F826D0", VA = "0x186F83CD0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int FFOLMBIDMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F842F0", Offset = "0x6F82CF0", VA = "0x186F842F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint GLPNFCNMLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F84310", Offset = "0x6F82D10", VA = "0x186F84310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily HIFEBJIAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x525F9B0", Offset = "0x525E3B0", VA = "0x18525F9B0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6F84420", Offset = "0x6F82E20", VA = "0x186F84420")]
	public PMCAEOOPIIL(AddressFamily DFEBDDJMECE, GEHOJLIEFBO IGPHHGFDIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F83CF0", Offset = "0x6F826F0", VA = "0x186F83CF0", Slot = "8")]
	public bool FBCDJAMPDKE(IPEndPoint MCOAFFEFDEH, BCMPAOOCDOP KKBBGELFIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6F842B0", Offset = "0x6F82CB0", VA = "0x186F842B0", Slot = "9")]
	public int GEFLAFHPCOJ(byte[] NNHDOHEKGEG, int BACDJHJBLPL, int OPKPFANIILK, IPEndPoint NMNBMPFGKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84330", Offset = "0x6F82D30", VA = "0x186F84330", Slot = "10")]
	public int KHCPNPCGEAA(byte[] NNHDOHEKGEG, EndPoint MKLEIPCFODM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F83CB0", Offset = "0x6F826B0", VA = "0x186F83CB0", Slot = "11")]
	public void ACECGDGGDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface CHIICCBAAFB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short GDGIMGFCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int FFOLMBIDMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint GLPNFCNMLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily HIFEBJIAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FBCDJAMPDKE(IPEndPoint MCOAFFEFDEH, BCMPAOOCDOP KKBBGELFIOI);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int GEFLAFHPCOJ(byte[] NNHDOHEKGEG, int BACDJHJBLPL, int OPKPFANIILK, IPEndPoint NMNBMPFGKHL);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KHCPNPCGEAA(byte[] NNHDOHEKGEG, EndPoint NMNBMPFGKHL);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ACECGDGGDNM();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct ONACIDFGNID : IEquatable<ONACIDFGNID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long NCKDLDHHKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long BDJLFFNNCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long FGDGGLEEMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int KNLHGHBDJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int PGNODNGEPID;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F822E0", Offset = "0x6F80CE0", VA = "0x186F822E0")]
	public ONACIDFGNID(byte[] KJPOKAJCMFP, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F823A0", Offset = "0x6F80DA0", VA = "0x186F823A0")]
	public ONACIDFGNID(Span<byte> KJPOKAJCMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA32DA0", Offset = "0xA317A0", VA = "0x180A32DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F821F0", Offset = "0x6F80BF0", VA = "0x186F821F0", Slot = "4")]
	public bool Equals(ONACIDFGNID NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F82230", Offset = "0x6F80C30", VA = "0x186F82230", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class IMKCJNPAIPH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] OEHEPEMEEFO;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EEGPGLHDKAE
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void OJHNBLMJLMH(IPEndPoint KJPOKAJCMFP, Span<byte> HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string ENIIEBMCIAJ = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int JFCBNJKEKMM = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int CIDPCHKECDC = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static Dictionary<ONACIDFGNID, IPEndPoint> FCAKKNAHPEF;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static OJHNBLMJLMH OMEPLPFBFMG;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	internal void FPIGPHMAAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	internal void BBDMBIOAFCN(IPEndPoint NMNBMPFGKHL, Span<byte> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class DFCPKDKAKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly int NFBDNLLCOAG;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
	protected DFCPKDKAKJI(int MCPKLCLJENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OJAGFEMMIIH(IPEndPoint MCOAFFEFDEH, byte[] HPGIDELCODH, int BACDJHJBLPL, int EIJGIDNMHGP);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FNHOEONFOIG(IPEndPoint MCOAFFEFDEH, byte[] HPGIDELCODH, int BACDJHJBLPL, int EIJGIDNMHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IKLBDIAADOL : DFCPKDKAKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private byte[] KJNEHANBOBO;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly RandomNumberGenerator BGPKLEHBMGF;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x29189A0", Offset = "0x29173A0", VA = "0x1829189A0")]
	public IKLBDIAADOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F78730", Offset = "0x6F77130", VA = "0x186F78730")]
	public void MMJAAPFAJCH(IPEndPoint MCOAFFEFDEH, byte[] KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F78650", Offset = "0x6F77050", VA = "0x186F78650")]
	public void JBJECDFJEDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6F788E0", Offset = "0x6F772E0", VA = "0x186F788E0", Slot = "4")]
	public override void OJAGFEMMIIH(IPEndPoint MCOAFFEFDEH, byte[] HPGIDELCODH, int BACDJHJBLPL, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6F782F0", Offset = "0x6F76CF0", VA = "0x186F782F0", Slot = "5")]
	public override void FNHOEONFOIG(IPEndPoint MCOAFFEFDEH, byte[] HPGIDELCODH, int BACDJHJBLPL, int EIJGIDNMHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct MGBBMEGIBBN
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void LDLPCOMPOEL([NoAlias] byte* DMJEEALFMDH, [NoAlias] byte* KJNEHANBOBO, [NoAlias] byte* JCHHCDJGMLD, int EIJGIDNMHGP);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class HNEPKBIIJGD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static IntPtr CIOIILDPBBN;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static IntPtr KPMEPDNDFLM;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F84650", Offset = "0x6F83050", VA = "0x186F84650")]
		[BurstDiscard]
		private static void AOJAHPIGLNM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F84810", Offset = "0x6F83210", VA = "0x186F84810")]
		private static IntPtr LNICGLPJFIM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84770", Offset = "0x6F83170", VA = "0x186F84770")]
		public static void LLALFBBLOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void DBILOAODCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84960", Offset = "0x6F83360", VA = "0x186F84960")]
		public unsafe static void LPGMHIBJMOO([NoAlias] byte* DMJEEALFMDH, [NoAlias] byte* KJNEHANBOBO, [NoAlias] byte* JCHHCDJGMLD, int EIJGIDNMHGP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint KJNEHANBOBO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint JCHHCDJGMLD[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint ALEPHIPBPMK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint DHEPNFPEBEP[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint MBFPHCBBODB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint LCEEINDMFED[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint LEICGEANJEC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private uint ECKAMLHNBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint FEGNDEJPMLD[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6F80560", Offset = "0x6F7EF60", VA = "0x186F80560")]
	private void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6F806B0", Offset = "0x6F7F0B0", VA = "0x186F806B0")]
	private uint HNDAJADDIBH(uint GEHEADBMGDC, int LIJGJDKILNK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BF90", Offset = "0x6F6A990", VA = "0x186F6BF90")]
	private void LEPNLCLLMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C140", Offset = "0x6F6AB40", VA = "0x186F6C140")]
	private void PPPKECGDPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BF00", Offset = "0x6F6A900", VA = "0x186F6BF00")]
	private void CMBMALBKPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C040", Offset = "0x6F6AA40", VA = "0x186F6C040")]
	private void NIMJLFAJCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F805E0", Offset = "0x6F7EFE0", VA = "0x186F805E0")]
	private void ANCLOEIJAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F806E0", Offset = "0x6F7F0E0", VA = "0x186F806E0")]
	private unsafe void LHHODJAMPAA(byte* DMJEEALFMDH, uint* KJNEHANBOBO, uint* JCHHCDJGMLD, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F80CE0", Offset = "0x6F7F6E0", VA = "0x186F80CE0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void ODMMCFNBNGG([NoAlias] byte* DMJEEALFMDH, [NoAlias] byte* KJNEHANBOBO, [NoAlias] byte* JCHHCDJGMLD, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F80C00", Offset = "0x6F7F600", VA = "0x186F80C00")]
	public static void ODMMCFNBNGG(Span<byte> DMJEEALFMDH, Span<byte> KJNEHANBOBO, Span<byte> JCHHCDJGMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F80B00", Offset = "0x6F7F500", VA = "0x186F80B00")]
	public static void NCNCMABJKPF(Span<byte> DMJEEALFMDH, Span<byte> KJNEHANBOBO, Span<byte> JCHHCDJGMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F80640", Offset = "0x6F7F040", VA = "0x186F80640")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DBGNIHBELDP([NoAlias] byte* DMJEEALFMDH, [NoAlias] byte* KJNEHANBOBO, [NoAlias] byte* JCHHCDJGMLD, int EIJGIDNMHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F84C90", Offset = "0x6F83690", VA = "0x186F84C90")]
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
