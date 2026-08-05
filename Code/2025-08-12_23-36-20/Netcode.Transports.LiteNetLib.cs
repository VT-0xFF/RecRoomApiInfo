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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, GKIDFGBAMGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum NKJFJFNELOK
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
		private NetworkManager GPIKGGCLCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool PIBFDLJLDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, KGIACAKCPNE> GECMOJIODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KMGBCLBLEDA IICIPBLEIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch MGFINEOIPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] LNAAIMFDFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NKJFJFNELOK HEADMAHPJNF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int GMFJOJNKCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7570010", Offset = "0x756EE10", VA = "0x187570010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong OCCGCCBBIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool ECGFMLIBKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x756FFF0", Offset = "0x756EDF0", VA = "0x18756FFF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x756F590", Offset = "0x756E390", VA = "0x18756F590")]
		public void RecRoom_SetEncryptionInfo(ulong FCDHEMLLCNJ, byte[] OPGJHIOADCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x756F570", Offset = "0x756E370", VA = "0x18756F570")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x756F440", Offset = "0x756E240", VA = "0x18756F440")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x756FEF0", Offset = "0x756ECF0", VA = "0x18756FEF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x756F6B0", Offset = "0x756E4B0", VA = "0x18756F6B0", Slot = "6")]
		public override void Send(ulong KDPNMEKECKM, ArraySegment<byte> KANAIIDGHCH, NetworkDelivery HJCJFJCHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x756F530", Offset = "0x756E330", VA = "0x18756F530", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong KDPNMEKECKM, [Out] ArraySegment<byte> OBBABGHFJAB, [Out] float KLBFFPEMNFI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x756F9A0", Offset = "0x756E7A0", VA = "0x18756F9A0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x756FD10", Offset = "0x756EB10", VA = "0x18756FD10", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x756EA50", Offset = "0x756D850", VA = "0x18756EA50", Slot = "11")]
		public override void DisconnectRemoteClient(ulong KDPNMEKECKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x756E960", Offset = "0x756D760", VA = "0x18756E960", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x756ED30", Offset = "0x756DB30", VA = "0x18756ED30", Slot = "13")]
		public override ulong GetCurrentRtt(ulong KDPNMEKECKM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x756F930", Offset = "0x756E730", VA = "0x18756F930", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x756EEE0", Offset = "0x756DCE0", VA = "0x18756EEE0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager GPIKGGCLCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x756EB60", Offset = "0x756D960", VA = "0x18756EB60")]
		private GBKOABEJGFL FMNDMPMPIJE(NetworkDelivery ADGMECOLKNH)
		{
			return default(GBKOABEJGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x756EDD0", Offset = "0x756DBD0", VA = "0x18756EDD0", Slot = "16")]
		private void IBHHMEKCGPD(KGIACAKCPNE BOOIFAKDGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x756EC30", Offset = "0x756DA30", VA = "0x18756EC30", Slot = "17")]
		private void GFBBHNFLBEA(KGIACAKCPNE BOOIFAKDGJD, GDOIJJEJCFA CMCDNLELHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "18")]
		private void JAFNGIMNJGD(IPEndPoint DHDNILPEIEL, SocketError ONJPINGICFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x756F230", Offset = "0x756E030", VA = "0x18756F230", Slot = "19")]
		private void MPDJJLEKACJ(KGIACAKCPNE BOOIFAKDGJD, BMGKNIHCGMK CCOEJPOOOPD, byte KGBEGEBGBCH, GBKOABEJGFL LIKPDHBANME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x756F150", Offset = "0x756DF50", VA = "0x18756F150")]
		private void LPFIDNLLNMM(int BCMFMCHGEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "20")]
		private void HKNLCINFJOM(IPEndPoint BHKCNNKIABO, BMGKNIHCGMK CCOEJPOOOPD, BHEFACJHKBN DHHBCOHIJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "21")]
		private void ICPFONIIAIC(KGIACAKCPNE BOOIFAKDGJD, int LPOLAAPPNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x756F0F0", Offset = "0x756DEF0", VA = "0x18756F0F0", Slot = "22")]
		private void JAFDOIDEOCK(NNKKMEIHOGJ FGKGCIHOGKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x756EEB0", Offset = "0x756DCB0", VA = "0x18756EEB0")]
		private ulong ICBBNKLNCJC(KGIACAKCPNE BOOIFAKDGJD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x756EE90", Offset = "0x756DC90", VA = "0x18756EE90")]
		private ulong ICBBNKLNCJC(ulong KDPNMEKECKM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x756E940", Offset = "0x756D740", VA = "0x18756E940")]
		private static int ABLNJFBDCJG(float KBODPDIPNAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x756FF10", Offset = "0x756ED10", VA = "0x18756FF10")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x756ED00", Offset = "0x756DB00", VA = "0x18756ED00")]
		[CompilerGenerated]
		private void GNEGLCMMBEM(ulong LMLLBLOGKHL, int CHOEGLKIOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x756ED00", Offset = "0x756DB00", VA = "0x18756ED00")]
		[CompilerGenerated]
		private void JLDKADLJLBA(ulong LMLLBLOGKHL, int CHOEGLKIOPP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class IKDMKKDDJPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly KGIACAKCPNE CPJOPMFIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<FOAMFGNOGDN> FGLJPMEHIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int BBPBHNJFCNG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HBDMJBOCKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x755F690", Offset = "0x755E490", VA = "0x18755F690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x755F760", Offset = "0x755E560", VA = "0x18755F760")]
	protected IKDMKKDDJPK(KGIACAKCPNE BOOIFAKDGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x755F5F0", Offset = "0x755E3F0", VA = "0x18755F5F0")]
	public void EMAAKDANGJG(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x755F6E0", Offset = "0x755E4E0", VA = "0x18755F6E0")]
	protected void LKDDKFBGHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x755F650", Offset = "0x755E450", VA = "0x18755F650")]
	public bool FFIHBJBLGON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CLHMGKIENNC();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MPCPLCBDBOD(FOAMFGNOGDN HAGKDCOOCAH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum FKCPJLKCJPN
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
public class NNKKMEIHOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KMGBCLBLEDA EEEKPEOGHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int DBKMKHOBGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HMAJGAENONK LHFDKAIHKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint DBECKFMCNFD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal FKCPJLKCJPN JOLJDOILEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
		[CompilerGenerated]
		get
		{
			return default(FKCPJLKCJPN);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7570520", Offset = "0x756F320", VA = "0x187570520")]
	internal void DPPNHECLANM(HMAJGAENONK GDFKLMMCHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7570580", Offset = "0x756F380", VA = "0x187570580")]
	private bool FGJCLPBHGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7570610", Offset = "0x756F410", VA = "0x187570610")]
	internal NNKKMEIHOGJ(IPEndPoint BHKCNNKIABO, HMAJGAENONK IEAOEAMOIBB, KMGBCLBLEDA GPIDHOODOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75705B0", Offset = "0x756F3B0", VA = "0x1875705B0")]
	public KGIACAKCPNE PNEMBKJBMDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BHEFACJHKBN
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AINCAPDFBOL
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
public struct GDOIJJEJCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public AINCAPDFBOL GPFMAAIKILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError ILLCINDDFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BMGKNIHCGMK KMPDMCNDCND;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GKIDFGBAMGE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJPBIGNMBIA(KGIACAKCPNE BOOIFAKDGJD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPHNFJHLKPA(KGIACAKCPNE BOOIFAKDGJD, GDOIJJEJCFA CMCDNLELHJK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJEGMAAMGJF(IPEndPoint DHDNILPEIEL, SocketError ONJPINGICFA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJMHKOADFNA(KGIACAKCPNE BOOIFAKDGJD, BMGKNIHCGMK CCOEJPOOOPD, byte KGBEGEBGBCH, GBKOABEJGFL LIKPDHBANME);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCKFNKGELDL(IPEndPoint BHKCNNKIABO, BMGKNIHCGMK CCOEJPOOOPD, BHEFACJHKBN DHHBCOHIJDI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMCKIAODMIN(KGIACAKCPNE BOOIFAKDGJD, int LPOLAAPPNAN);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDHDEFNIJKL(NNKKMEIHOGJ FGKGCIHOGKN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HDIINBHIFAB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHODFEOGPKL(KGIACAKCPNE BOOIFAKDGJD, object FPJFHBGIAMK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KNMBONKMKBK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCGNFOGHDJH(PPEFCLLACKB HAGKDCOOCAH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AEKIBPIDEEG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIECJDGHKCK(KGIACAKCPNE BOOIFAKDGJD, IPEndPoint MCKPABKBFAD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HMAJGAENONK
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int NIBKJLDKGOK = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long BADBCHDKAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EFIHCDMAAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] FOGKFNBEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly DCGACMCOLPK CFOLCKLFPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int KFJBICGHPDK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x755F4E0", Offset = "0x755E2E0", VA = "0x18755F4E0")]
	private HMAJGAENONK(long OKLPEBJNNOH, byte MHFDMLBMIKD, int DPODDKLLKHL, byte[] DGKJHEHPKPD, DCGACMCOLPK KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x755F2A0", Offset = "0x755E0A0", VA = "0x18755F2A0")]
	public static int GBEKELCGCMJ(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x755F080", Offset = "0x755DE80", VA = "0x18755F080")]
	public static HMAJGAENONK EBHBJKFKLJM(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x755F300", Offset = "0x755E100", VA = "0x18755F300")]
	public static FOAMFGNOGDN OALPFKGMMGL(IPOGMGNFPLP CIHNGCFPHCL, SocketAddress FKHCJBDKNPB, long NKCPFAIAJPP, int DPODDKLLKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class MJGEBODJPIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long BADBCHDKAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte EFIHCDMAAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int KFJBICGHPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool FMJAPPPHMNM;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75704D0", Offset = "0x756F2D0", VA = "0x1875704D0")]
	private MJGEBODJPIN(long OKLPEBJNNOH, byte MHFDMLBMIKD, int CPBGDKGNGOM, bool NKIPOIBLIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7570190", Offset = "0x756EF90", VA = "0x187570190")]
	public static MJGEBODJPIN EBHBJKFKLJM(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x75703E0", Offset = "0x756F1E0", VA = "0x1875703E0")]
	public static FOAMFGNOGDN OALPFKGMMGL(long NKCPFAIAJPP, byte BOFFJCMOFPM, int IEJGHIMGDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75702E0", Offset = "0x756F0E0", VA = "0x1875702E0")]
	public static FOAMFGNOGDN HJBGLGBNFKC(KGIACAKCPNE BOOIFAKDGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum OFAOLJBJFEP
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LFAKBOJONOP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHHHLBKELIP(IPEndPoint KFKHINHGLIM, IPEndPoint BHKCNNKIABO, string OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAKAOIKMNKB(IPEndPoint FOOKEGPBCFB, OFAOLJBJFEP ADGMECOLKNH, string OBGCPOCPFIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OKMNHGIFKEP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct INEFIFMABBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint MHEHJEFCKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint DBECKFMCNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string BIKAJNDLCFH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct GHHLEJJNGNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint PHCDIBKEEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OFAOLJBJFEP FOJLLEMFFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string BIKAJNDLCFH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class CNKFMEJNDBM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint IBPEOMHCIFD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string BIKAJNDLCFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CNKFMEJNDBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class DICGIKAGKEI
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint IBPEOMHCIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint KONJIKIKEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string BIKAJNDLCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DICGIKAGKEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class EFKHJKAJHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string BIKAJNDLCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NBKCOFGHIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EFKHJKAJHKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KMGBCLBLEDA HPCMCLKJMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<INEFIFMABBK> FJCJPHAJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<GHHLEJJNGNP> CEAHMIDCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DCGACMCOLPK BMGLAELFEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IPOGMGNFPLP BPLFIAAMHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CCMKIIOIDCA JECFCCNAPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private LFAKBOJONOP LJMIOJDBDPJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int BJAJLLBHIIH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool MKPABDGGPKK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75714F0", Offset = "0x75702F0", VA = "0x1875714F0")]
	internal OKMNHGIFKEP(KMGBCLBLEDA GHJLONHBGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7571370", Offset = "0x7570170", VA = "0x187571370")]
	internal void PFHAIEJBLJI(IPEndPoint PLCHIEBEJNF, FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4DC0", Offset = "0x3EB3BC0", VA = "0x183EB4DC0")]
	private void MGMFKKBBOJB<T>(T HAGKDCOOCAH, IPEndPoint BNIHAACOHPG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75711E0", Offset = "0x756FFE0", VA = "0x1875711E0")]
	private void NHHHLBKELIP(CNKFMEJNDBM CCKEAOAFBCF, IPEndPoint PLCHIEBEJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7571080", Offset = "0x756FE80", VA = "0x187571080")]
	private void GEABOJBLBKO(DICGIKAGKEI CCKEAOAFBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7570EE0", Offset = "0x756FCE0", VA = "0x187570EE0")]
	private void BKFHGCBLFLG(EFKHJKAJHKJ CCKEAOAFBCF, IPEndPoint PLCHIEBEJNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GBKOABEJGFL : byte
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
public enum FMACCDHKJAB : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GMADLMJHMMI
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] IJDMJIAOKBH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int PCMLEBEJEMA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int AAOPDMHDPNC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPAHJMNKFIH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x755C800", Offset = "0x755B600", VA = "0x18755C800")]
	public BPAHJMNKFIH(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BLJMEKFKALC : BPAHJMNKFIH
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x755C800", Offset = "0x755B600", VA = "0x18755C800")]
	public BLJMEKFKALC(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CBFHLHJGAEO
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
public interface BCDADPDHBHE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKDKMFIIBKK(CBFHLHJGAEO CAGGGJDLHBC, string PBHOCHKFEPH, params object[] NPIEBNDMCBK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class AOJONGJJDGI
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static BCDADPDHBHE IPOFGIEHDGE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object LAOHNJHHMDA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x755B230", Offset = "0x755A030", VA = "0x18755B230")]
	private static void MKAPNJBDMLI(CBFHLHJGAEO IALLCLKFNHA, string PBHOCHKFEPH, params object[] NPIEBNDMCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x755B1D0", Offset = "0x7559FD0", VA = "0x18755B1D0")]
	internal static void IMFBNEEINEJ(string PBHOCHKFEPH, params object[] NPIEBNDMCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x755B170", Offset = "0x7559F70", VA = "0x18755B170")]
	internal static void HHBNCBGFECL(string PBHOCHKFEPH, params object[] NPIEBNDMCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x755B110", Offset = "0x7559F10", VA = "0x18755B110")]
	internal static void CCGDBLAOLDI(string PBHOCHKFEPH, params object[] NPIEBNDMCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum EJJGIDCADKL
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BMGKNIHCGMK : DCGACMCOLPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private FOAMFGNOGDN KDCMKJGKKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly KMGBCLBLEDA DBEBHAEFHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JMABDABLBHC AJOOMKHENPN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x755C930", Offset = "0x755B730", VA = "0x18755C930")]
	internal BMGKNIHCGMK(KMGBCLBLEDA EKOKCFOMOOD, JMABDABLBHC IHIEAJGNFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x755C840", Offset = "0x755B640", VA = "0x18755C840")]
	internal void EDIFFADHALK(FOAMFGNOGDN HAGKDCOOCAH, int KHHHBKPBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x755C8B0", Offset = "0x755B6B0", VA = "0x18755C8B0")]
	internal void GHEGMFPDLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x755C810", Offset = "0x755B610", VA = "0x18755C810")]
	public void CNKMFDPFCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class JMABDABLBHC
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum CNBHJGECHFH
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
	public JMABDABLBHC PNHGDBJBEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public CNBHJGECHFH FOJLLEMFFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public KGIACAKCPNE CPJOPMFIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint DBECKFMCNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object CMFHOCBJIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int MNEOJLOHHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError MJPDMKNICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AINCAPDFBOL BCAIKGNMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NNKKMEIHOGJ KKDKNDNCLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public GBKOABEJGFL AJBNNAEHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte CCIOGODJFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly BMGKNIHCGMK JOOKKONGCHI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7561C80", Offset = "0x7560A80", VA = "0x187561C80")]
	public JMABDABLBHC(KMGBCLBLEDA EKOKCFOMOOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KMGBCLBLEDA : IEnumerable<KGIACAKCPNE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class DDIAMLEEBPJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x755DAE0", Offset = "0x755C8E0", VA = "0x18755DAE0", Slot = "4")]
		public bool Equals(IPEndPoint DBBMOEGPNPP, IPEndPoint COFKGIHGCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45D3360", Offset = "0x45D2160", VA = "0x1845D3360", Slot = "5")]
		public int GetHashCode(IPEndPoint ALGAKMGCCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DDIAMLEEBPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct ICIFELDIFPL : IEnumerator<KGIACAKCPNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly KGIACAKCPNE BOPPGLNKGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private KGIACAKCPNE ICBKMDBNDOE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KGIACAKCPNE BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB3C8B0", Offset = "0xB3B6B0", VA = "0x180B3C8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB3C8B0", Offset = "0xB3B6B0", VA = "0x180B3C8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1CD2D70", Offset = "0x1CD1B70", VA = "0x181CD2D70")]
		public ICIFELDIFPL(KGIACAKCPNE EFDFIDCNFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x755F550", Offset = "0x755E350", VA = "0x18755F550", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x755F5A0", Offset = "0x755E3A0", VA = "0x18755F5A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread PGNCNIMGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool MBHPPHPAMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool EDJHGCIOLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private DAFNOIADHGD GADKNIPPNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent EAIFMJMEOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<JMABDABLBHC> AJJGCABEPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<JMABDABLBHC> EBCGFCHNDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private JMABDABLBHC KAJDHPKLDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GKIDFGBAMGE DOFCCLCEAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly HDIINBHIFAB PBLGHKEMIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly KNMBONKMKBK GGDDDEMCJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly AEKIBPIDEEG INEDJLCOION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, KGIACAKCPNE> FMPNNCMHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, NNKKMEIHOGJ> HGCFDDLMBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, EHMPLNGPEEG> CNALCJCOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim ICHMIPLLDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private KGIACAKCPNE JONNKHCMAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int GIMKMLFGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<KGIACAKCPNE> CALNHLGKFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private KGIACAKCPNE[] MBLMPOBMOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GGEBBNPHPAD EDCGIOPDOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int ILFBLOOAOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> LHCPJFAJIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte HDCNDOBJDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object AIHGKKGLLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MHLIJEJGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool HFPLLKNFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int EDLDBFLEMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int JKFKNMCOAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int HLOGLLGOLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int DINELEFACBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool DCPGGOLBGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HHEBNNKBFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LLIAHGOAOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GPHNJLELKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int DHABNMBEIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool MKPABDGGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KJPAJLICEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool CBEJGCDEBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool JIAEMGHFKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int GPCCGDKJJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int KMJHMJGCGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool PCJMFNANBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly EEBICDPIGDI EGNGKBFBJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool DCKJOBHGEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly OKMNHGIFKEP DJHLGDGMMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool ADGEMLBGBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public EJJGIDCADKL OLIHADLPFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int BOAAHKPFBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool MJKNAHCCAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool DKAHKPAAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool DGCGIIAPCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool EPBJGIMBHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FOAMFGNOGDN LMDNHAJPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GBLDJKJOMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object DKGAJCJLEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private FOAMFGNOGDN PJHOGDHPHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int FKMMOJOFBFF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int HGNBOAHLJOD = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int DNPDNDJNJFK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private HOKDFJLIDLP DFMPBNHGBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private HOKDFJLIDLP AGJKMMKCPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread DEEAGHMDELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread EIJCJOJNIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint PCNEKHBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint NNLBFELCOBI;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] JHBNIMPFMHN;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] BADLCNEMKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<PAOCKGLGJCL, IPEndPoint> MEKOBKDGGNA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress NFKPKNBIDMP;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool NALAFPJNPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int ILJOHHKAGMD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PKJHPKDONAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC10B20", Offset = "0xC0F920", VA = "0x180C10B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC0C370", Offset = "0xC0B170", VA = "0x180C0C370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JPBCKOABCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1823240", Offset = "0x1822040", VA = "0x181823240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x21354F0", Offset = "0x21342F0", VA = "0x1821354F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte GKCEIKDHJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A80", Offset = "0x10B0880", VA = "0x1810B1A80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NMHMGOIDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x756BB00", Offset = "0x756A900", VA = "0x18756BB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short MHFAKLNGDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7568CC0", Offset = "0x7567AC0", VA = "0x187568CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KGIACAKCPNE.PCAGNOABLKK OCBMNONKHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x756D0E0", Offset = "0x756BEE0", VA = "0x18756D0E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x756A9F0", Offset = "0x75697F0", VA = "0x18756A9F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x756AD80", Offset = "0x7569B80", VA = "0x18756AD80")]
	public void FPMLIFIEBGN(IPEndPoint DHDNILPEIEL, byte[] OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x756BED0", Offset = "0x756ACD0", VA = "0x18756BED0")]
	public void JBFACKOKFGM(IPEndPoint DHDNILPEIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x756C2C0", Offset = "0x756B0C0", VA = "0x18756C2C0")]
	private bool KBIMOGEHGMG(IPEndPoint DHDNILPEIEL, [Out] KGIACAKCPNE BOOIFAKDGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x756B7C0", Offset = "0x756A5C0", VA = "0x18756B7C0")]
	private void HIKBGHIPMCN(KGIACAKCPNE BOOIFAKDGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x756BE70", Offset = "0x756AC70", VA = "0x18756BE70")]
	private void IMHDDDFCFJA(KGIACAKCPNE BOOIFAKDGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x756CC90", Offset = "0x756BA90", VA = "0x18756CC90")]
	private void OCOAFNKIPGE(KGIACAKCPNE BOOIFAKDGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x756E240", Offset = "0x756D040", VA = "0x18756E240")]
	public KMGBCLBLEDA(GKIDFGBAMGE GPIDHOODOPJ, [Optional] GGEBBNPHPAD BPFOJBFANIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x756C9D0", Offset = "0x756B7D0", VA = "0x18756C9D0")]
	internal void LLJMFCODDBL(KGIACAKCPNE HPOJEBECFAN, int LPOLAAPPNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x756C360", Offset = "0x756B160", VA = "0x18756C360")]
	internal void KILCAGJOPPP(KGIACAKCPNE HPOJEBECFAN, object FPJFHBGIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x756C020", Offset = "0x756AE20", VA = "0x18756C020")]
	internal void JFCIOCAJGMB(KGIACAKCPNE BOOIFAKDGJD, AINCAPDFBOL BCDABHDFJPD, SocketError BFLIGKFHGPA, FOAMFGNOGDN PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x756A420", Offset = "0x7569220", VA = "0x18756A420")]
	private void ELJLHOINOOI(KGIACAKCPNE BOOIFAKDGJD, AINCAPDFBOL BCDABHDFJPD, SocketError BFLIGKFHGPA, bool PPPGPLMAHNI, byte[] KANAIIDGHCH, int NBLNCONJINM, int FFKCBONKOOM, FOAMFGNOGDN PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x756DC80", Offset = "0x756CA80", VA = "0x18756DC80")]
	private void PNIPCLEGLOA(JMABDABLBHC.CNBHJGECHFH ADGMECOLKNH, [Optional] KGIACAKCPNE BOOIFAKDGJD, [Optional] IPEndPoint BHKCNNKIABO, SocketError KAFEFLDOPOC = SocketError.Success, int LPOLAAPPNAN = 0, AINCAPDFBOL ELFCDBMOHJB = AINCAPDFBOL.ConnectionFailed, [Optional] NNKKMEIHOGJ IKBKEHNGAAD, GBKOABEJGFL LIKPDHBANME = GBKOABEJGFL.Unreliable, byte KGBEGEBGBCH = 0, [Optional] FOAMFGNOGDN DJDHJDEAPMF, [Optional] object FPJFHBGIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x756B000", Offset = "0x7569E00", VA = "0x18756B000")]
	private void HCLDICOLECF(JMABDABLBHC IHIEAJGNFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x756CB80", Offset = "0x756B980", VA = "0x18756CB80")]
	internal void OANJFCEIJBC(JMABDABLBHC IHIEAJGNFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x756BB20", Offset = "0x756A920", VA = "0x18756BB20")]
	private void HLPILLOICHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x75668A0", Offset = "0x75656A0", VA = "0x1875668A0")]
	private void AANNNDKHLNE(int BPNEOOEMDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x756C3B0", Offset = "0x756B1B0", VA = "0x18756C3B0")]
	internal KGIACAKCPNE KPBLAOJMBIC(NNKKMEIHOGJ FGKGCIHOGKN, byte[] JGBBEIFCNIN, int NBLNCONJINM, int MCJGICKIGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x756A320", Offset = "0x7569120", VA = "0x18756A320")]
	private int EEBDDCPJJJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x756D460", Offset = "0x756C260", VA = "0x18756D460")]
	private void PLBGCLKEJOB(IPEndPoint BHKCNNKIABO, KGIACAKCPNE GPJOOFFFFCF, HMAJGAENONK PKNMMJHOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7566BC0", Offset = "0x75659C0", VA = "0x187566BC0")]
	private void ADGBCNMANAA(FOAMFGNOGDN HAGKDCOOCAH, IPEndPoint BHKCNNKIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x756AAA0", Offset = "0x75698A0", VA = "0x18756AAA0")]
	internal void FOCLBABDFAO(FOAMFGNOGDN HAGKDCOOCAH, GBKOABEJGFL BBGEIKGKENC, byte KGBEGEBGBCH, int KHHHBKPBPAB, KGIACAKCPNE HPOJEBECFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75697A0", Offset = "0x75685A0", VA = "0x1875697A0")]
	public bool DGOFKDGOMGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7569FD0", Offset = "0x7568DD0", VA = "0x187569FD0")]
	public bool DGOFKDGOMGH(IPAddress CFNBAOBFAHB, IPAddress OAKPDJKCADE, int LAMPHLPCBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7569720", Offset = "0x7568520", VA = "0x187569720")]
	public bool DGOFKDGOMGH(int LAMPHLPCBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7568550", Offset = "0x7567350", VA = "0x187568550")]
	public void BPFCKECLCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7568BE0", Offset = "0x75679E0", VA = "0x187568BE0")]
	public KGIACAKCPNE CCPHEEBLNBO(string NDPAACFPBHM, int LAMPHLPCBJB, string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7568B00", Offset = "0x7567900", VA = "0x187568B00")]
	public KGIACAKCPNE CCPHEEBLNBO(string NDPAACFPBHM, int LAMPHLPCBJB, IPOGMGNFPLP PNADBMINGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7568720", Offset = "0x7567520", VA = "0x187568720")]
	public KGIACAKCPNE CCPHEEBLNBO(IPEndPoint BNIHAACOHPG, IPOGMGNFPLP PNADBMINGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x756DC70", Offset = "0x756CA70", VA = "0x18756DC70")]
	public void PMKEICCMJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x756D910", Offset = "0x756C710", VA = "0x18756D910")]
	public void PMKEICCMJHA(bool JDNJHEMFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x756D030", Offset = "0x756BE30", VA = "0x18756D030")]
	public void PBDLCCMJLLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x756CF60", Offset = "0x756BD60", VA = "0x18756CF60")]
	public void PBDLCCMJLLL(byte[] KANAIIDGHCH, int NBLNCONJINM, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x756A3A0", Offset = "0x75691A0", VA = "0x18756A3A0")]
	public void ELJLHOINOOI(KGIACAKCPNE BOOIFAKDGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x756A3E0", Offset = "0x75691E0", VA = "0x18756A3E0")]
	public void ELJLHOINOOI(KGIACAKCPNE BOOIFAKDGJD, byte[] KANAIIDGHCH, int NBLNCONJINM, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x756E060", Offset = "0x756CE60", VA = "0x18756E060", Slot = "4")]
	private IEnumerator<KGIACAKCPNE> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x756E0F0", Offset = "0x756CEF0", VA = "0x18756E0F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x756A830", Offset = "0x7569630", VA = "0x18756A830")]
	private FOAMFGNOGDN ELKACKELGJD(ONMOAHKJMHJ HIGEDKBAGHN, int BCMFMCHGEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x756A910", Offset = "0x7569710", VA = "0x18756A910")]
	private FOAMFGNOGDN ELKACKELGJD(ONMOAHKJMHJ HIGEDKBAGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7567F90", Offset = "0x7566D90", VA = "0x187567F90")]
	internal FOAMFGNOGDN AJJAHNPJEKE(int BCMFMCHGEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x756C060", Offset = "0x756AE60", VA = "0x18756C060")]
	internal void JGICFBINAFD(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x756E180", Offset = "0x756CF80", VA = "0x18756E180")]
	static KMGBCLBLEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xC10B20", Offset = "0xC0F920", VA = "0x180C10B20")]
	private bool IKLOPDIDEHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x756A1A0", Offset = "0x7568FA0", VA = "0x18756A1A0")]
	private void DNPFHNGJGBD(IPEndPoint CBEGBMJLDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x756CA20", Offset = "0x756B820", VA = "0x18756CA20")]
	private void NLDJBLHEJFF(IPEndPoint CBEGBMJLDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7569FF0", Offset = "0x7568DF0", VA = "0x187569FF0")]
	private bool DHGCNOBBMAO(SocketException AACEGADBPKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7568700", Offset = "0x7567500", VA = "0x187568700")]
	private void CBNCJOCFHLF(DAFNOIADHGD GHJLONHBGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x756D190", Offset = "0x756BF90", VA = "0x18756D190")]
	private void PIKHBNJPIMN(HOKDFJLIDLP GHJLONHBGNB, EndPoint NJLJPAKDDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75681D0", Offset = "0x7566FD0", VA = "0x1875681D0")]
	private void ANKNKDJJMMC(object GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7569810", Offset = "0x7568610", VA = "0x187569810")]
	public bool DGOFKDGOMGH(IPAddress CFNBAOBFAHB, IPAddress OAKPDJKCADE, int LAMPHLPCBJB, bool GCFLCMHNKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x756AFA0", Offset = "0x7569DA0", VA = "0x18756AFA0")]
	internal int GGAJEAMINOC(FOAMFGNOGDN HAGKDCOOCAH, IPEndPoint BHKCNNKIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7568D80", Offset = "0x7567B80", VA = "0x187568D80")]
	internal int DAGFFBEDFHB(FOAMFGNOGDN HAGKDCOOCAH, IPEndPoint BHKCNNKIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7568DC0", Offset = "0x7567BC0", VA = "0x187568DC0")]
	internal int DAGFFBEDFHB(byte[] JDFCBBCKOGJ, int NBLNCONJINM, int MCJGICKIGFF, IPEndPoint BHKCNNKIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x75695A0", Offset = "0x75683A0", VA = "0x1875695A0")]
	internal void DAMEIMBELEK(bool FGGOLMFLCOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum ONMOAHKJMHJ : byte
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
internal sealed class FOAMFGNOGDN
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int OABDDHHGEDC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] LNFMOEJPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] DCIADAFKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int JODCAOMDJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object CMFHOCBJIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public FOAMFGNOGDN PNHGDBJBEGM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ONMOAHKJMHJ JCAIFGHKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x755EA50", Offset = "0x755D850", VA = "0x18755EA50")]
		get
		{
			return default(ONMOAHKJMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x755E580", Offset = "0x755D380", VA = "0x18755E580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EFIHCDMAAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x755E5F0", Offset = "0x755D3F0", VA = "0x18755E5F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x755EA10", Offset = "0x755D810", VA = "0x18755EA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort GPJIMHCNILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x755EA80", Offset = "0x755D880", VA = "0x18755EA80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x755E9D0", Offset = "0x755D7D0", VA = "0x18755E9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FDNKMMNABCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x755E5C0", Offset = "0x755D3C0", VA = "0x18755E5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte EGGEDMPFPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x755E550", Offset = "0x755D350", VA = "0x18755E550")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x755EAE0", Offset = "0x755D8E0", VA = "0x18755EAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort CDAAJPJOGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x755E770", Offset = "0x755D570", VA = "0x18755E770")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x755E700", Offset = "0x755D500", VA = "0x18755E700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort GMDCGPDMBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x755E6A0", Offset = "0x755D4A0", VA = "0x18755E6A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x755E660", Offset = "0x755D460", VA = "0x18755E660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort OBJPPBONPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x755EB10", Offset = "0x755D910", VA = "0x18755EB10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x755E620", Offset = "0x755D420", VA = "0x18755E620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x755EB70", Offset = "0x755D970", VA = "0x18755EB70")]
	static FOAMFGNOGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x755E740", Offset = "0x755D540", VA = "0x18755E740")]
	public void FFLJKLILGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x755EE30", Offset = "0x755DC30", VA = "0x18755EE30")]
	public FOAMFGNOGDN(int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x755EEA0", Offset = "0x755DCA0", VA = "0x18755EEA0")]
	public FOAMFGNOGDN(ONMOAHKJMHJ HIGEDKBAGHN, int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x755E8D0", Offset = "0x755D6D0", VA = "0x18755E8D0")]
	public static int KOHHDKBJANL(ONMOAHKJMHJ HIGEDKBAGHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x755E940", Offset = "0x755D740", VA = "0x18755E940")]
	public int KOHHDKBJANL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x755E7D0", Offset = "0x755D5D0", VA = "0x18755E7D0")]
	public bool JGBBCNHGFJF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum JMEOMKOHLBG : byte
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
internal enum MGECPOLPMCA
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
internal enum AMALHNEJHCL
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum JHLIMJMKNLL
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KGIACAKCPNE
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class DGFABBBLEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FOAMFGNOGDN[] JDEHGHKEDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int KMMIELNAJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int AOOCBLMCFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte EGGEDMPFPCL;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DGFABBBLEEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void PCAGNOABLKK(ulong LMLLBLOGKHL, int CHOEGLKIOPP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PGIDHLFJJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int CJNJNKBCPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int BPMMFFKCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double EEGALOBNIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int GLPFDLCBDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int DFFILMGFCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int IEMKCPKPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch EEIDGIDPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int GMCOGPHEDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long CCCGBGIDBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object NKKBBJOCCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal KGIACAKCPNE KAJKGHOGKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal KGIACAKCPNE AIGABFINKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<FOAMFGNOGDN> PLNIJFGPFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<IKDMKKDDJPK> EFLPEMJKDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly IKDMKKDDJPK[] LLLJENHLDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int IEGDBCLDBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int GAEHLJHMKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool KMLKNLGPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int BHMNHEGDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int DGBJCCKNLOL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int KBJKLLIMOKC = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int EKHMMBAEOOI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object CILNHCLCBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int AHCGKHFNBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, DGFABBBLEEI> GJJDLPNKKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> HNCMNDBOBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FOAMFGNOGDN FIDKAFKPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int OJBDLCFCFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int EOPJAMLEEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint NLIPBFFHAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int OIHIHMCAGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int BKGNEFBJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long HILHEEBCALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte HCGACNGMMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JMEOMKOHLBG HLOENGLOCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FOAMFGNOGDN IMFIABFAKHJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int PHJLEELHONN = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int JGBEOEFNFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FOAMFGNOGDN ILFKAAFKFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly FOAMFGNOGDN KBELDGPGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly FOAMFGNOGDN LEDFMNFOOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly FOAMFGNOGDN FODGDKBDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private FMACCDHKJAB LKAGKJEDMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly KMGBCLBLEDA AOAAHOKDOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int FBLHFPABBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object PKAGMDJPJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly EEBICDPIGDI EGNGKBFBJCG;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte HPLBBKBKIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB63390", Offset = "0xB62190", VA = "0x180B63390")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7562D00", Offset = "0x7561B00", VA = "0x187562D00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint IHIGEMMHMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB63620", Offset = "0xB62420", VA = "0x180B63620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public JMEOMKOHLBG EGDAJAHHDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB63190", Offset = "0xB61F90", VA = "0x180B63190")]
		get
		{
			return default(JMEOMKOHLBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long PGHKFFLIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xAA30F0", Offset = "0xAA1EF0", VA = "0x180AA30F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DHODCFMANAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1823240", Offset = "0x1822040", VA = "0x181823240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x21354F0", Offset = "0x21342F0", VA = "0x1821354F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LDJPMOBJONM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7562CF0", Offset = "0x7561AF0", VA = "0x187562CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GAHHHMOPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double GELBEBPBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A330", Offset = "0x2A09130", VA = "0x182A0A330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PCAGNOABLKK OCBMNONKHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75654E0", Offset = "0x75642E0", VA = "0x1875654E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7563180", Offset = "0x7561F80", VA = "0x187563180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7566450", Offset = "0x7565250", VA = "0x187566450")]
	internal KGIACAKCPNE(KMGBCLBLEDA CHPCAFIKGCE, IPEndPoint BHKCNNKIABO, int FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75644B0", Offset = "0x75632B0", VA = "0x1875644B0")]
	internal void KKKGEKCFNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75634F0", Offset = "0x75622F0", VA = "0x1875634F0")]
	internal void FLPLENBFBPJ(IPEndPoint INLGIBLDOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7562C60", Offset = "0x7561A60", VA = "0x187562C60")]
	internal void CLAHFNCHJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7563AC0", Offset = "0x75628C0", VA = "0x187563AC0")]
	private void ILMNFAKCIHH(int OFFOIOBJOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7563140", Offset = "0x7561F40", VA = "0x187563140")]
	private void ENIFHKBPNGL(int OPJKDGCEICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75645B0", Offset = "0x75633B0", VA = "0x1875645B0")]
	public int LKFLJGGJPPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75646C0", Offset = "0x75634C0", VA = "0x1875646C0")]
	public int LKFLJGGJPPC(byte KGBEGEBGBCH, bool FFGKBPEBMFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7563340", Offset = "0x7562140", VA = "0x187563340")]
	private IKDMKKDDJPK FCFHPDMPHEF(byte ENMBFMACLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75662C0", Offset = "0x75650C0", VA = "0x1875662C0")]
	internal KGIACAKCPNE(KMGBCLBLEDA CHPCAFIKGCE, IPEndPoint BHKCNNKIABO, int FMFDAFLDAAK, byte BOFFJCMOFPM, IPOGMGNFPLP CIHNGCFPHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75660E0", Offset = "0x7564EE0", VA = "0x1875660E0")]
	internal KGIACAKCPNE(KMGBCLBLEDA CHPCAFIKGCE, NNKKMEIHOGJ FGKGCIHOGKN, int FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7563270", Offset = "0x7562070", VA = "0x187563270")]
	internal void FAALDHHECGE(HMAJGAENONK LLPMMEBAMEN, byte[] KANAIIDGHCH, int NBLNCONJINM, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x75632C0", Offset = "0x75620C0", VA = "0x1875632C0")]
	internal bool FBHEMHJNJGK(MJGEBODJPIN HAGKDCOOCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75647E0", Offset = "0x75635E0", VA = "0x1875647E0")]
	public void MGMFKKBBOJB(byte[] KANAIIDGHCH, int NBLNCONJINM, int MCJGICKIGFF, GBKOABEJGFL PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7563EA0", Offset = "0x7562CA0", VA = "0x187563EA0")]
	private void KHLAJJHMNAB(byte[] KANAIIDGHCH, int NBLNCONJINM, int MCJGICKIGFF, byte KGBEGEBGBCH, GBKOABEJGFL LIKPDHBANME, object FPJFHBGIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7563520", Offset = "0x7562320", VA = "0x187563520")]
	public void GBGHIEODIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75644D0", Offset = "0x75632D0", VA = "0x1875644D0")]
	internal AMALHNEJHCL KNIBCAPOBHG(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return default(AMALHNEJHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7562C00", Offset = "0x7561A00", VA = "0x187562C00")]
	internal void BADIACCOKFC(IKDMKKDDJPK BHFLBALEEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7563B90", Offset = "0x7562990", VA = "0x187563B90")]
	internal JHLIMJMKNLL JMIMPNAJPIL(byte[] KANAIIDGHCH, int NBLNCONJINM, int MCJGICKIGFF, bool PPPGPLMAHNI)
	{
		return default(JHLIMJMKNLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7563230", Offset = "0x7562030", VA = "0x187563230")]
	private void EOMMOFHHNKH(int NPOLADMGAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7565590", Offset = "0x7564390", VA = "0x187565590")]
	internal void PJEBGEIDBIN(GBKOABEJGFL BBGEIKGKENC, FOAMFGNOGDN EFDFIDCNFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7563570", Offset = "0x7562370", VA = "0x187563570")]
	private void GJLDOKDOBJF(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7562DB0", Offset = "0x7561BB0", VA = "0x187562DB0")]
	private void EDGDOANNMAP(int GCGEIJPOBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7565F20", Offset = "0x7564D20", VA = "0x187565F20")]
	internal MGECPOLPMCA PLBGCLKEJOB(HMAJGAENONK PKNMMJHOHMI)
	{
		return default(MGECPOLPMCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7564960", Offset = "0x7563760", VA = "0x187564960")]
	internal void MPCPLCBDBOD(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7564810", Offset = "0x7563610", VA = "0x187564810")]
	private void MJJLEHPLJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7565020", Offset = "0x7563E20", VA = "0x187565020")]
	internal void NANOJGACNJG(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7562540", Offset = "0x7561340", VA = "0x187562540")]
	internal void AFCEEABIEMI(int GCGEIJPOBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7565220", Offset = "0x7564020", VA = "0x187565220")]
	internal void ONFDMLGCAEJ(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EEBICDPIGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long AFIPDKCNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long BDCPFEGMBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long DGKBKNAPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long EAJJKMIOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long FDFJOKPFKED;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long KJLMAGNFFKF;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long IADCMEFEAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long KJKCNGHEFGE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long BKCNHAEDMGG;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long EMNCAIILDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long MAOOFHFJGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long OPCCJGCJONL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long JMDCEFJFDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x755DD30", Offset = "0x755CB30", VA = "0x18755DD30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LPDMDDEBDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x755DD40", Offset = "0x755CB40", VA = "0x18755DD40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long DCNFNFBEBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x755DD60", Offset = "0x755CB60", VA = "0x18755DD60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long KCJDPPFDEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x755DD50", Offset = "0x755CB50", VA = "0x18755DD50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long LEICPCFGPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x755DE20", Offset = "0x755CC20", VA = "0x18755DE20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long DLNAIPMKBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x755DD70", Offset = "0x755CB70", VA = "0x18755DD70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long HGPNLCDMOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x755DDE0", Offset = "0x755CBE0", VA = "0x18755DDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long DPKLNPJCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x755DED0", Offset = "0x755CCD0", VA = "0x18755DED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private FMACCDHKJAB EMGMPDFFBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double NMPLOOIEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x755DB50", Offset = "0x755C950", VA = "0x18755DB50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x755DE30", Offset = "0x755CC30", VA = "0x18755DE30")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x755DE70", Offset = "0x755CC70", VA = "0x18755DE70")]
	public void LNKHKCIEMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x755DC80", Offset = "0x755CA80", VA = "0x18755DC80")]
	public void DGHBFLMDEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x755DD80", Offset = "0x755CB80", VA = "0x18755DD80")]
	public void JEFJIEMCJOC(long BGEJDMKJDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x755DCD0", Offset = "0x755CAD0", VA = "0x18755DCD0")]
	public void EALFBFIPLNI(long IACGLPPEECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x755DBB0", Offset = "0x755C9B0", VA = "0x18755DBB0")]
	public void CBOLHHFOFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x755DC10", Offset = "0x755CA10", VA = "0x18755DC10")]
	public void DALGKKOCHNB(long JNABFPNJHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x755DFB0", Offset = "0x755CDB0", VA = "0x18755DFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x755DF10", Offset = "0x755CD10", VA = "0x18755DF10")]
	public void MPPELEJJFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EEBICDPIGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JLBLDHHIGLN
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> PGOKEMGJMNP;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7561970", Offset = "0x7560770", VA = "0x187561970")]
	public static IPEndPoint JGEDAIOEHCC(string NMENAONGBJF, int LAMPHLPCBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75617A0", Offset = "0x75605A0", VA = "0x1875617A0")]
	public static IPAddress BPOJNMKBNBB(string NMENAONGBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7561710", Offset = "0x7560510", VA = "0x187561710")]
	public static IPAddress BPOJNMKBNBB(string NMENAONGBJF, AddressFamily MEILEIALBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7561BC0", Offset = "0x75609C0", VA = "0x187561BC0")]
	internal static int LDCHKGCHFJK(int GBPLPLFGAHK, int KNFECMPGFJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D725D0", Offset = "0x3D713D0", VA = "0x183D725D0")]
	internal static T[] IOGAKMOFNCI<T>(int FFKCBONKOOM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JEDJHKECIMN : IKDMKKDDJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct CKPLIPJKLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private FOAMFGNOGDN KDCMKJGKKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long DAENGDFLNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool NPFKKCEAEAP;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x755CDE0", Offset = "0x755BBE0", VA = "0x18755CDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x755CD50", Offset = "0x755BB50", VA = "0x18755CD50")]
		public void MHDKBDCHLCM(FOAMFGNOGDN HAGKDCOOCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x755CD70", Offset = "0x755BB70", VA = "0x18755CD70")]
		public bool NPGMMHLFNBC(long NDIHBLABBCI, KGIACAKCPNE BOOIFAKDGJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x755CD00", Offset = "0x755BB00", VA = "0x18755CD00")]
		public bool FMJEOCFJDAJ(KGIACAKCPNE BOOIFAKDGJD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly FOAMFGNOGDN KFILINJBKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly CKPLIPJKLAG[] HMEPIMGELHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FOAMFGNOGDN[] GIEFGKFHIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] KKILHDPEBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EKPIOAIPFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int KJHNHIDNDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int HELHAFHPIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int NCNJDJMCKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool IHLDNAAPOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly GBKOABEJGFL NNJOBFKPNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool CGBCPHBPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int JMMPKPDIAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte ELMOPHOHMGJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MGABMJHABCG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7560ED0", Offset = "0x755FCD0", VA = "0x187560ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7561540", Offset = "0x7560340", VA = "0x187561540")]
	public JEDJHKECIMN(KGIACAKCPNE BOOIFAKDGJD, bool FFGKBPEBMFN, byte FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7560B10", Offset = "0x755F910", VA = "0x187560B10")]
	private void DMIGCDKKGLB(FOAMFGNOGDN HAGKDCOOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7560640", Offset = "0x755F440", VA = "0x187560640", Slot = "4")]
	protected override bool CLHMGKIENNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7560EE0", Offset = "0x755FCE0", VA = "0x187560EE0", Slot = "5")]
	public override bool MPCPLCBDBOD(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class ODCOHGGBFLA : IKDMKKDDJPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int NDGGFFNDADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort KJHNHIDNDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool NNELFFFPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private FOAMFGNOGDN HIJICHCCINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly FOAMFGNOGDN BMLMAJFAPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool EBMECOABKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte ELMOPHOHMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long KANAGEIOPKE;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7570E20", Offset = "0x756FC20", VA = "0x187570E20")]
	public ODCOHGGBFLA(KGIACAKCPNE BOOIFAKDGJD, bool BNEKIFFJLCJ, byte FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7570680", Offset = "0x756F480", VA = "0x187570680", Slot = "4")]
	protected override bool CLHMGKIENNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7570B40", Offset = "0x756F940", VA = "0x187570B40", Slot = "5")]
	public override bool MPCPLCBDBOD(FOAMFGNOGDN HAGKDCOOCAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class ELHDPIDAKLD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct CLJDFKLOLOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong JFBKCMOKCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double NEAFKENPLNH;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct BCCMMLOPLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int COLNNBHJGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float KMLEFGJBHJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x755AF80", Offset = "0x7559D80", VA = "0x18755AF80")]
	private static void NJHEMMPFPIB(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, ulong KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x755E430", Offset = "0x755D230", VA = "0x18755E430")]
	private static void NJHEMMPFPIB(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, int KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x755E3F0", Offset = "0x755D1F0", VA = "0x18755E3F0")]
	public static void NJHEMMPFPIB(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, short KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x755E4B0", Offset = "0x755D2B0", VA = "0x18755E4B0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, double HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x755E4D0", Offset = "0x755D2D0", VA = "0x18755E4D0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x755E3F0", Offset = "0x755D1F0", VA = "0x18755E3F0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, short HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x755E3F0", Offset = "0x755D1F0", VA = "0x18755E3F0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, ushort HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x755E430", Offset = "0x755D230", VA = "0x18755E430")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x755E430", Offset = "0x755D230", VA = "0x18755E430")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, uint HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x755E4A0", Offset = "0x755D2A0", VA = "0x18755E4A0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x755E4A0", Offset = "0x755D2A0", VA = "0x18755E4A0")]
	public static void OKOKPEHAPAM(byte[] JICDOIHAMGB, int DOCKBMMINED, ulong HGMAIPELJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DCGACMCOLPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] OHJBKIGEIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int ONPCLHBMCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int IOKPMDOHIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int KEBLEJNDIPP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] DCIADAFKIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OFFGIOLNLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int AICNEJPIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x755D9F0", Offset = "0x755C7F0", VA = "0x18755D9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EFDOPJGJFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x296E310", Offset = "0x296D110", VA = "0x18296E310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int NKBMLJDACGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x755D690", Offset = "0x755C490", VA = "0x18755D690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x755CFF0", Offset = "0x755BDF0", VA = "0x18755CFF0")]
	public void EDIFFADHALK(byte[] MKPEOGPFEFH, int IBOFMHFOKKF, int DBBKEODKFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DCGACMCOLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x755DA80", Offset = "0x755C880", VA = "0x18755DA80")]
	public DCGACMCOLPK(byte[] MKPEOGPFEFH, int IBOFMHFOKKF, int DBBKEODKFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x755D3F0", Offset = "0x755C1F0", VA = "0x18755D3F0")]
	public IPEndPoint GOINAFLDJJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x755D070", Offset = "0x755BE70", VA = "0x18755D070")]
	public byte MDDOHNFOOIF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x755D070", Offset = "0x755BE70", VA = "0x18755D070")]
	public sbyte ENOFMBGNHII()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3B527E0", Offset = "0x3B515E0", VA = "0x183B527E0")]
	public T[] JMFPEBPABKD<T>(ushort BCMFMCHGEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x755D8D0", Offset = "0x755C6D0", VA = "0x18755D8D0")]
	public bool[] NGEGEAMJANJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x755CFB0", Offset = "0x755BDB0", VA = "0x18755CFB0")]
	public ushort[] DPEIOBDFMPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x755D5E0", Offset = "0x755C3E0", VA = "0x18755D5E0")]
	public short[] LBCPKKOBOKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x755DA00", Offset = "0x755C800", VA = "0x18755DA00")]
	public int[] PCFDIFKNEMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x755D4C0", Offset = "0x755C2C0", VA = "0x18755D4C0")]
	public uint[] HLLGOOACPKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x755D340", Offset = "0x755C140", VA = "0x18755D340")]
	public float[] FNNPFNJAAKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x755CEC0", Offset = "0x755BCC0", VA = "0x18755CEC0")]
	public double[] ALIJDJFOHPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x755D030", Offset = "0x755BE30", VA = "0x18755D030")]
	public long[] EKPCMIIAJLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x755CE80", Offset = "0x755BC80", VA = "0x18755CE80")]
	public ulong[] AIOJANGEKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x755D710", Offset = "0x755C510", VA = "0x18755D710")]
	public string[] MPHCGGMKCCH(int BLLKHJIIPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x755DA40", Offset = "0x755C840", VA = "0x18755DA40")]
	public bool PLEKPBHPCAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x755CF40", Offset = "0x755BD40", VA = "0x18755CF40")]
	public char DHFGPDOGAHK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x755CF40", Offset = "0x755BD40", VA = "0x18755CF40")]
	public ushort LEBNKPPHMCH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x755D620", Offset = "0x755C420", VA = "0x18755D620")]
	public short LBMNECBHDML()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x755D980", Offset = "0x755C780", VA = "0x18755D980")]
	public long OELFPMGLOPH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x755D500", Offset = "0x755C300", VA = "0x18755D500")]
	public ulong JGLGMHHDLKI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x755D380", Offset = "0x755C180", VA = "0x18755D380")]
	public int GHACNNDHHFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x755D6A0", Offset = "0x755C4A0", VA = "0x18755D6A0")]
	public uint MPHAOEFKCBB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x755D860", Offset = "0x755C660", VA = "0x18755D860")]
	public float NEPPAMAPMHG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x755D910", Offset = "0x755C710", VA = "0x18755D910")]
	public double NGMPADIEGGJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x755D0F0", Offset = "0x755BEF0", VA = "0x18755D0F0")]
	public string FKINCHBPOGG(int JLNDIGIGKPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x755D570", Offset = "0x755C370", VA = "0x18755D570")]
	public ArraySegment<byte> KABIHKINIOE(int FFKCBONKOOM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x755D0B0", Offset = "0x755BEB0", VA = "0x18755D0B0")]
	public sbyte[] FGHLICOLPGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x755CF00", Offset = "0x755BD00", VA = "0x18755CF00")]
	public byte[] CGAPMCMKKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x755D320", Offset = "0x755C120", VA = "0x18755D320")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IPOGMGNFPLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] OHJBKIGEIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int ONPCLHBMCKF;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int LEEGOMNHGPH = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool OLGOOANOBGF;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding CFIKMCHBLNA;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int OBLAFNJJCHL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] IJMFBKNONMI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] CFOLCKLFPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7560520", Offset = "0x755F320", VA = "0x187560520")]
	public IPOGMGNFPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75605A0", Offset = "0x755F3A0", VA = "0x1875605A0")]
	public IPOGMGNFPLP(bool GMIINADLPKO, int EJHCBOLOEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7560430", Offset = "0x755F230", VA = "0x187560430")]
	public static IPOGMGNFPLP OFHJNFCGDPP(string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x755F800", Offset = "0x755E600", VA = "0x18755F800")]
	public void CLDELHDPNBE(int EENPPNCKGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x29E7340", Offset = "0x29E6140", VA = "0x1829E7340")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x755FF40", Offset = "0x755ED40", VA = "0x18755FF40")]
	public void EABMBGJAKOI(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x755FAC0", Offset = "0x755E8C0", VA = "0x18755FAC0")]
	public void EABMBGJAKOI(double HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x755FEF0", Offset = "0x755ECF0", VA = "0x18755FEF0")]
	public void EABMBGJAKOI(long HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x755FEF0", Offset = "0x755ECF0", VA = "0x18755FEF0")]
	public void EABMBGJAKOI(ulong HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x755FE60", Offset = "0x755EC60", VA = "0x18755FE60")]
	public void EABMBGJAKOI(int HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x755FE60", Offset = "0x755EC60", VA = "0x18755FE60")]
	public void EABMBGJAKOI(uint HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x755FBE0", Offset = "0x755E9E0", VA = "0x18755FBE0")]
	public void EABMBGJAKOI(char HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x755FBE0", Offset = "0x755E9E0", VA = "0x18755FBE0")]
	public void EABMBGJAKOI(ushort HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x755FBE0", Offset = "0x755E9E0", VA = "0x18755FBE0")]
	public void EABMBGJAKOI(short HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x755F980", Offset = "0x755E780", VA = "0x18755F980")]
	public void EABMBGJAKOI(sbyte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x755F980", Offset = "0x755E780", VA = "0x18755F980")]
	public void EABMBGJAKOI(byte HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x755FB70", Offset = "0x755E970", VA = "0x18755FB70")]
	public void EABMBGJAKOI(byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x755F8A0", Offset = "0x755E6A0", VA = "0x18755F8A0")]
	public void ILBJGEGFENO(sbyte[] KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x755F8A0", Offset = "0x755E6A0", VA = "0x18755F8A0")]
	public void CONLBMHJNJJ(byte[] KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x755FB10", Offset = "0x755E910", VA = "0x18755FB10")]
	public void EABMBGJAKOI(bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7560350", Offset = "0x755F150", VA = "0x187560350")]
	public void ICGBOBCDMGA(Array FECLLLBAKJD, int KOKLLDOEGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75600C0", Offset = "0x755EEC0", VA = "0x1875600C0")]
	public void ICGBOBCDMGA(float[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x75601A0", Offset = "0x755EFA0", VA = "0x1875601A0")]
	public void ICGBOBCDMGA(double[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x75601A0", Offset = "0x755EFA0", VA = "0x1875601A0")]
	public void ICGBOBCDMGA(long[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x75601A0", Offset = "0x755EFA0", VA = "0x1875601A0")]
	public void ICGBOBCDMGA(ulong[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x75600C0", Offset = "0x755EEC0", VA = "0x1875600C0")]
	public void ICGBOBCDMGA(int[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x75600C0", Offset = "0x755EEC0", VA = "0x1875600C0")]
	public void ICGBOBCDMGA(uint[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x755FFE0", Offset = "0x755EDE0", VA = "0x18755FFE0")]
	public void ICGBOBCDMGA(ushort[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x755FFE0", Offset = "0x755EDE0", VA = "0x18755FFE0")]
	public void ICGBOBCDMGA(short[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x755F8A0", Offset = "0x755E6A0", VA = "0x18755F8A0")]
	public void ICGBOBCDMGA(bool[] HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7560280", Offset = "0x755F080", VA = "0x187560280")]
	public void ICGBOBCDMGA(string[] HGMAIPELJHM, int LPONNHKJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x755F9E0", Offset = "0x755E7E0", VA = "0x18755F9E0")]
	public void EABMBGJAKOI(IPEndPoint DHDNILPEIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x755FAB0", Offset = "0x755E8B0", VA = "0x18755FAB0")]
	public void EABMBGJAKOI(string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x755FC50", Offset = "0x755EA50", VA = "0x18755FC50")]
	public void EABMBGJAKOI(string HGMAIPELJHM, int JLNDIGIGKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CCMKIIOIDCA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class CCPLPKLIDKC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong FBLHFPABBMB;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DC20", Offset = "0x6C5CA20", VA = "0x186C5DC20")]
		static CCPLPKLIDKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void IBGJPNMBLOE(DCGACMCOLPK CCOEJPOOOPD, object FPJFHBGIAMK);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LJIENGNLGCE<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CCMKIIOIDCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LJIENGNLGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5698980", Offset = "0x5697780", VA = "0x185698980")]
		internal void JIHMOKDMHDC(DCGACMCOLPK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CDIGKFAFGOC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CCMKIIOIDCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CDIGKFAFGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6C621D0", Offset = "0x6C60FD0", VA = "0x186C621D0")]
		internal void JIHMOKDMHDC(DCGACMCOLPK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly LHKDLIILANF DIKLBKFIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, IBGJPNMBLOE> PBMODENCICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly IPOGMGNFPLP LLKIDPMCNHI;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x755CB80", Offset = "0x755B980", VA = "0x18755CB80")]
	public CCMKIIOIDCA(int BLLKHJIIPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3232CA0", Offset = "0x3231AA0", VA = "0x183232CA0", Slot = "4")]
	protected virtual ulong MLOMKNFOFNC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x755CA50", Offset = "0x755B850", VA = "0x18755CA50", Slot = "5")]
	protected virtual IBGJPNMBLOE GGADHGINIDB(DCGACMCOLPK CCOEJPOOOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3B00650", Offset = "0x3AFF450", VA = "0x183B00650", Slot = "6")]
	protected virtual void CINGCFPIENF<T>(IPOGMGNFPLP AOOOLDFNADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x755C980", Offset = "0x755B780", VA = "0x18755C980")]
	public void BLCEIHMKIHI(DCGACMCOLPK CCOEJPOOOPD, object FPJFHBGIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3B006C0", Offset = "0x3AFF4C0", VA = "0x183B006C0")]
	public void JKBMBEKOIPJ<T>(IPOGMGNFPLP AOOOLDFNADH, T HAGKDCOOCAH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x755CA00", Offset = "0x755B800", VA = "0x18755CA00")]
	public void EBBNHDFOCGC(DCGACMCOLPK CCOEJPOOOPD, object FPJFHBGIAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3B008D0", Offset = "0x3AFF6D0", VA = "0x183B008D0")]
	public void MOGBDDDJIEO<T>(Action<T> JPEFOKLICLO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B00750", Offset = "0x3AFF550", VA = "0x183B00750")]
	public void MOGBDDDJIEO<T, TUserData>(Action<T, TUserData> JPEFOKLICLO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FEFEADNNAPM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x755C800", Offset = "0x755B600", VA = "0x18755C800")]
	public FEFEADNNAPM(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class PIKEHEGKEFJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7571D60", Offset = "0x7570B60", VA = "0x187571D60")]
	public PIKEHEGKEFJ(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LHKDLIILANF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum MBDADCNJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class EHCFCPBIPHF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MBDADCNJAIH FOJLLEMFFFA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4A57420", Offset = "0x4A56220", VA = "0x184A57420", Slot = "4")]
		public virtual void MHDKBDCHLCM(MethodInfo IDJHOABHCMK, MethodInfo KNJDIJHGJPI, MBDADCNJAIH ADGMECOLKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HJOJJBCNALM(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AEPIPOMOJAN(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		protected EHCFCPBIPHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class AIADKMLBMCO<TClass, TProperty> : EHCFCPBIPHF<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> OPHEMDHEHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> GCCONIAANAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> PLMINKHOPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> CJGINKEKIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> EFHBHCCGBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> LDJJPINIELJ;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5299C60", Offset = "0x5298A60", VA = "0x185299C60", Slot = "7")]
		public override void DPPMINNKLEO(TClass HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x529AD20", Offset = "0x5299B20", VA = "0x18529AD20", Slot = "8")]
		public override void KBGNHKFKNBD(TClass HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x529A280", Offset = "0x5299080", VA = "0x18529A280", Slot = "9")]
		public override void HJOJJBCNALM(TClass HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5298D80", Offset = "0x5297B80", VA = "0x185298D80", Slot = "10")]
		public override void AEPIPOMOJAN(TClass HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x529AA60", Offset = "0x5299860", VA = "0x18529AA60")]
		protected TProperty[] IMDHBAPHNGE(TClass HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x52A0180", Offset = "0x529EF80", VA = "0x1852A0180")]
		protected TProperty[] MMBECHEGCMK(TClass HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x529F600", Offset = "0x529E400", VA = "0x18529F600", Slot = "4")]
		public override void MHDKBDCHLCM(MethodInfo IDJHOABHCMK, MethodInfo KNJDIJHGJPI, MBDADCNJAIH ADGMECOLKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x52A01F0", Offset = "0x529EFF0", VA = "0x1852A01F0")]
		protected AIADKMLBMCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class MMJGKOPPPNM<TClass, TProperty> : AIADKMLBMCO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CPENEJGKLFO(DCGACMCOLPK BIHPDMNFJGD, [Out] TProperty BHJOOPHJGGA);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void FFGOCCPLDFM(IPOGMGNFPLP GFOPEPPIPGD, TProperty BHJOOPHJGGA);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x58C5D50", Offset = "0x58C4B50", VA = "0x1858C5D50", Slot = "5")]
		public override void HKFLJHHOJDB(TClass HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x58C5E50", Offset = "0x58C4C50", VA = "0x1858C5E50", Slot = "6")]
		public override void JKBMBEKOIPJ(TClass HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x58C5CB0", Offset = "0x58C4AB0", VA = "0x1858C5CB0", Slot = "7")]
		public override void DPPMINNKLEO(TClass HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x58C5FD0", Offset = "0x58C4DD0", VA = "0x1858C5FD0", Slot = "8")]
		public override void KBGNHKFKNBD(TClass HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4F07070", Offset = "0x4F05E70", VA = "0x184F07070")]
		protected MMJGKOPPPNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class MIIIIOAELCC<T> : AIADKMLBMCO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x58B9AA0", Offset = "0x58B88A0", VA = "0x1858B9AA0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x508B410", Offset = "0x508A210", VA = "0x18508B410", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x58B9A30", Offset = "0x58B8830", VA = "0x1858B9A30", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x508B470", Offset = "0x508A270", VA = "0x18508B470", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public MIIIIOAELCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HFFKCFHAALL<T> : AIADKMLBMCO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x508B3A0", Offset = "0x508A1A0", VA = "0x18508B3A0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x508B410", Offset = "0x508A210", VA = "0x18508B410", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x508B330", Offset = "0x508A130", VA = "0x18508B330", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x508B470", Offset = "0x508A270", VA = "0x18508B470", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public HFFKCFHAALL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class KKNNLCHHKPM<T> : AIADKMLBMCO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x55EE890", Offset = "0x55ED690", VA = "0x1855EE890", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x55EE900", Offset = "0x55ED700", VA = "0x1855EE900", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x55EE820", Offset = "0x55ED620", VA = "0x1855EE820", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x55EE960", Offset = "0x55ED760", VA = "0x1855EE960", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public KKNNLCHHKPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class COAKFCBDCHE<T> : AIADKMLBMCO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D43A50", Offset = "0x6D42850", VA = "0x186D43A50", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x55EE900", Offset = "0x55ED700", VA = "0x1855EE900", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D439E0", Offset = "0x6D427E0", VA = "0x186D439E0", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x55EE960", Offset = "0x55ED760", VA = "0x1855EE960", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public COAKFCBDCHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CEOBLMKJGEA<T> : AIADKMLBMCO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C646E0", Offset = "0x6C634E0", VA = "0x186C646E0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x545D820", Offset = "0x545C620", VA = "0x18545D820", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C64670", Offset = "0x6C63470", VA = "0x186C64670", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x545D880", Offset = "0x545C680", VA = "0x18545D880", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public CEOBLMKJGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JEEMJMHCJMN<T> : AIADKMLBMCO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x545D7B0", Offset = "0x545C5B0", VA = "0x18545D7B0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x545D820", Offset = "0x545C620", VA = "0x18545D820", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x545D740", Offset = "0x545C540", VA = "0x18545D740", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x545D880", Offset = "0x545C680", VA = "0x18545D880", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public JEEMJMHCJMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AMILAPBLJEA<T> : AIADKMLBMCO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4542500", Offset = "0x4541300", VA = "0x184542500", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4542570", Offset = "0x4541370", VA = "0x184542570", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x547CFA0", Offset = "0x547BDA0", VA = "0x18547CFA0", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x45425D0", Offset = "0x45413D0", VA = "0x1845425D0", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public AMILAPBLJEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DHEHACKDLGI<T> : AIADKMLBMCO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4542500", Offset = "0x4541300", VA = "0x184542500", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4542570", Offset = "0x4541370", VA = "0x184542570", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4542490", Offset = "0x4541290", VA = "0x184542490", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x45425D0", Offset = "0x45413D0", VA = "0x1845425D0", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public DHEHACKDLGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CHOHBHMHGDF<T> : AIADKMLBMCO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BDC0", Offset = "0x6C6ABC0", VA = "0x186C6BDC0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BE30", Offset = "0x6C6AC30", VA = "0x186C6BE30", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BD50", Offset = "0x6C6AB50", VA = "0x186C6BD50", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x508B470", Offset = "0x508A270", VA = "0x18508B470", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public CHOHBHMHGDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PMELENFPOHL<T> : AIADKMLBMCO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0AFA0", Offset = "0x5C09DA0", VA = "0x185C0AFA0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0B010", Offset = "0x5C09E10", VA = "0x185C0B010", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0AF30", Offset = "0x5C09D30", VA = "0x185C0AF30", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x545D880", Offset = "0x545C680", VA = "0x18545D880", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public PMELENFPOHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class JOFDOHOEKBN<T> : AIADKMLBMCO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x54BCEB0", Offset = "0x54BBCB0", VA = "0x1854BCEB0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x54BCF20", Offset = "0x54BBD20", VA = "0x1854BCF20", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x54BCE40", Offset = "0x54BBC40", VA = "0x1854BCE40", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x45425D0", Offset = "0x45413D0", VA = "0x1845425D0", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4542630", Offset = "0x4541430", VA = "0x184542630")]
		public JOFDOHOEKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CEPBNANJNBC<T> : MMJGKOPPPNM<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C64780", Offset = "0x6C63580", VA = "0x186C64780", Slot = "12")]
		protected override void FFGOCCPLDFM(IPOGMGNFPLP GFOPEPPIPGD, char BHJOOPHJGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C64750", Offset = "0x6C63550", VA = "0x186C64750", Slot = "11")]
		protected override void CPENEJGKLFO(DCGACMCOLPK BIHPDMNFJGD, [Out] char BHJOOPHJGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x45B1FD0", Offset = "0x45B0DD0", VA = "0x1845B1FD0")]
		public CEPBNANJNBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DMJHCKHPPPM<T> : MMJGKOPPPNM<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x45B1FA0", Offset = "0x45B0DA0", VA = "0x1845B1FA0", Slot = "12")]
		protected override void FFGOCCPLDFM(IPOGMGNFPLP GFOPEPPIPGD, IPEndPoint BHJOOPHJGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x45B1F60", Offset = "0x45B0D60", VA = "0x1845B1F60", Slot = "11")]
		protected override void CPENEJGKLFO(DCGACMCOLPK BIHPDMNFJGD, [Out] IPEndPoint BHJOOPHJGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x45B1FD0", Offset = "0x45B0DD0", VA = "0x1845B1FD0")]
		public DMJHCKHPPPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FPMCGHLANMP<T> : AIADKMLBMCO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int LGBLDCBMKME;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4F35CE0", Offset = "0x4F34AE0", VA = "0x184F35CE0")]
		public FPMCGHLANMP(int JLNDIGIGKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F35B90", Offset = "0x4F34990", VA = "0x184F35B90", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4F35C00", Offset = "0x4F34A00", VA = "0x184F35C00", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F35B20", Offset = "0x4F34920", VA = "0x184F35B20", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F35C70", Offset = "0x4F34A70", VA = "0x184F35C70", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CPLHHLJLKAA<T> : EHCFCPBIPHF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo JCAIFGHKLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type ANCILOBJLOE;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E24F90", Offset = "0x6E23D90", VA = "0x186E24F90")]
		public CPLHHLJLKAA(PropertyInfo HIGEDKBAGHN, Type IEGBOCGAGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E24DC0", Offset = "0x6E23BC0", VA = "0x186E24DC0", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E24E80", Offset = "0x6E23C80", VA = "0x186E24E80", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E24D00", Offset = "0x6E23B00", VA = "0x186E24D00", Slot = "7")]
		public override void DPPMINNKLEO(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E24F30", Offset = "0x6E23D30", VA = "0x186E24F30", Slot = "8")]
		public override void KBGNHKFKNBD(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E24D60", Offset = "0x6E23B60", VA = "0x186E24D60", Slot = "9")]
		public override void HJOJJBCNALM(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E24CA0", Offset = "0x6E23AA0", VA = "0x186E24CA0", Slot = "10")]
		public override void AEPIPOMOJAN(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class CIEOHLAAABJ<T> : CPLHHLJLKAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4540BE0", Offset = "0x453F9E0", VA = "0x184540BE0")]
		public CIEOHLAAABJ(PropertyInfo HIGEDKBAGHN, Type IEGBOCGAGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C050", Offset = "0x6C6AE50", VA = "0x186C6C050", Slot = "5")]
		public override void HKFLJHHOJDB(T HOGKBLOKIOB, DCGACMCOLPK BIHPDMNFJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C110", Offset = "0x6C6AF10", VA = "0x186C6C110", Slot = "6")]
		public override void JKBMBEKOIPJ(T HOGKBLOKIOB, IPOGMGNFPLP GFOPEPPIPGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class JLDOFKFHDGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static JLDOFKFHDGJ<T> MOIOIMEFPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly EHCFCPBIPHF<T>[] IPPCLDIIBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int ALLJEIHMDNE;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x54B4C60", Offset = "0x54B3A60", VA = "0x1854B4C60")]
		public JLDOFKFHDGJ(List<EHCFCPBIPHF<T>> NEEKPMMLBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x54B4BB0", Offset = "0x54B39B0", VA = "0x1854B4BB0")]
		public void JKBMBEKOIPJ(T ALGAKMGCCLO, IPOGMGNFPLP AOOOLDFNADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x54B4B00", Offset = "0x54B3900", VA = "0x1854B4B00")]
		public void HKFLJHHOJDB(T ALGAKMGCCLO, DCGACMCOLPK CCOEJPOOOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class PBENKPGBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract EHCFCPBIPHF<T> DPMBHNJHJDJ<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private IPOGMGNFPLP ANPOEHPGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int FLALHNJFJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, PBENKPGBAOO> DDLDEBCEMAE;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x756E8A0", Offset = "0x756D6A0", VA = "0x18756E8A0")]
	public LHKDLIILANF(int BLLKHJIIPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC86D0", Offset = "0x3DC74D0", VA = "0x183DC86D0")]
	private JLDOFKFHDGJ<T> LPBOKFCLEOL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3B58990", Offset = "0x3B57790", VA = "0x183B58990")]
	public void FAIIODDINIJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9600", Offset = "0x3DC8400", VA = "0x183DC9600")]
	public bool PPEAGMPJINO<T>(DCGACMCOLPK CCOEJPOOOPD, T BNIHAACOHPG) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3DC95A0", Offset = "0x3DC83A0", VA = "0x183DC95A0")]
	public void OFACCHGGJAP<T>(IPOGMGNFPLP AOOOLDFNADH, T ALGAKMGCCLO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PPEFCLLACKB
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime IAIEAEJOHFC;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] MCNNDONHLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HGHLGAKPGMG OFMKNIKCNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x75727A0", Offset = "0x75715A0", VA = "0x1875727A0")]
		get
		{
			return default(HGHLGAKPGMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OCOAEDMDKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7572510", Offset = "0x7571310", VA = "0x187572510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7572060", Offset = "0x7570E60", VA = "0x187572060")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KAMKILDNFDE NPBANGNPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7572190", Offset = "0x7570F90", VA = "0x187572190")]
		get
		{
			return default(KAMKILDNFDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7572020", Offset = "0x7570E20", VA = "0x187572020")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NNAPJJHLPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x75721C0", Offset = "0x7570FC0", VA = "0x1875721C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint ACECIKFDPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7572BB0", Offset = "0x75719B0", VA = "0x187572BB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? HBGFGFIJAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7572C30", Offset = "0x7571A30", VA = "0x187572C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? PKDKJIDICMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x75720A0", Offset = "0x7570EA0", VA = "0x1875720A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? IGDKDKIGJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x75727D0", Offset = "0x75715D0", VA = "0x1875727D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7572800", Offset = "0x7571600", VA = "0x187572800")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? EPHHJBCMLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF589D0", Offset = "0xF577D0", VA = "0x180F589D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7572D90", Offset = "0x7571B90", VA = "0x187572D90")]
	public PPEFCLLACKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x75730B0", Offset = "0x7571EB0", VA = "0x1875730B0")]
	internal PPEFCLLACKB(byte[] JICDOIHAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x75723F0", Offset = "0x75711F0", VA = "0x1875723F0")]
	public static PPEFCLLACKB JHIAIHJEIDJ(byte[] JICDOIHAMGB, DateTime GLHHPNDFGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x75721F0", Offset = "0x7570FF0", VA = "0x1875721F0")]
	internal void HCNFMJGELMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x75729D0", Offset = "0x75717D0", VA = "0x1875729D0")]
	private void NHDNJPOEMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x75725A0", Offset = "0x75713A0", VA = "0x1875725A0")]
	private DateTime? KMNNJNNELPO(int IBOFMHFOKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7571E50", Offset = "0x7570C50", VA = "0x187571E50")]
	private void BFEBMEOELEB(int IBOFMHFOKKF, DateTime? HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7572C60", Offset = "0x7571A60", VA = "0x187572C60")]
	private ulong NJKIHCODJMA(int IBOFMHFOKKF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x75720D0", Offset = "0x7570ED0", VA = "0x1875720D0")]
	private void DBNNGBNLOHM(int IBOFMHFOKKF, ulong HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7571DC0", Offset = "0x7570BC0", VA = "0x187571DC0")]
	private uint AMOOBFLPPIG(int IBOFMHFOKKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7427380", Offset = "0x7426180", VA = "0x187427380")]
	private static uint KMEJFNEJMNF(uint DBBMOEGPNPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7572540", Offset = "0x7571340", VA = "0x187572540")]
	private static ulong KMEJFNEJMNF(ulong DBBMOEGPNPP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HGHLGAKPGMG
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
public enum KAMKILDNFDE
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class EHMPLNGPEEG
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int NDBIOLBBMMK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int MDGIPIALLCH = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int DDDIJHKOGLJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint HFPDDFAJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int IMGMEKPCBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int FCKIHNGONPH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CLBDHKIKEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x755E2F0", Offset = "0x755D0F0", VA = "0x18755E2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x755E300", Offset = "0x755D100", VA = "0x18755E300")]
	public bool MGMFKKBBOJB(HOKDFJLIDLP GHJLONHBGNB, int GJEDFMHCPFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class KDFOKCDKBME : HOKDFJLIDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket GHJLONHBGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly KMGBCLBLEDA CHPCAFIKGCE;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short MHFAKLNGDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x75622E0", Offset = "0x75610E0", VA = "0x1875622E0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int FNDOBMAENHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7562300", Offset = "0x7561100", VA = "0x187562300", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint MHEHJEFCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7562430", Offset = "0x7561230", VA = "0x187562430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily NIFACHMCCED
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5660270", Offset = "0x565F070", VA = "0x185660270", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7562490", Offset = "0x7561290", VA = "0x187562490")]
	public KDFOKCDKBME(AddressFamily MEILEIALBNC, KMGBCLBLEDA CHPCAFIKGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7561D20", Offset = "0x7560B20", VA = "0x187561D20", Slot = "8")]
	public bool AGPLLHHEDAC(IPEndPoint DHDNILPEIEL, EJJGIDCADKL LJFFPEHDJFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7562450", Offset = "0x7561250", VA = "0x187562450", Slot = "9")]
	public int NOHPOFDCIJN(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, int BCMFMCHGEKF, IPEndPoint BHKCNNKIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7562340", Offset = "0x7561140", VA = "0x187562340", Slot = "10")]
	public int JBHNFIDMGPO(byte[] ALPKAMHLIAF, EndPoint FNKFEIHANMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7562320", Offset = "0x7561120", VA = "0x187562320", Slot = "11")]
	public void HAOKAFOACHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface HOKDFJLIDLP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short MHFAKLNGDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int FNDOBMAENHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint MHEHJEFCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily NIFACHMCCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AGPLLHHEDAC(IPEndPoint DHDNILPEIEL, EJJGIDCADKL LJFFPEHDJFG);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int NOHPOFDCIJN(byte[] ALPKAMHLIAF, int IBOFMHFOKKF, int BCMFMCHGEKF, IPEndPoint BHKCNNKIABO);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JBHNFIDMGPO(byte[] ALPKAMHLIAF, EndPoint BHKCNNKIABO);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HAOKAFOACHG();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct PAOCKGLGJCL : IEquatable<PAOCKGLGJCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long MDOIOIIMEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long EPLCKBJBNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long LNKBNABHPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int BOLFLNBFLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int OPPFLDCBMMC;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7571CA0", Offset = "0x7570AA0", VA = "0x187571CA0")]
	public PAOCKGLGJCL(byte[] NDPAACFPBHM, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7571A30", Offset = "0x7570830", VA = "0x187571A30")]
	public PAOCKGLGJCL(Span<byte> NDPAACFPBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7571940", Offset = "0x7570740", VA = "0x187571940", Slot = "4")]
	public bool Equals(PAOCKGLGJCL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7571980", Offset = "0x7570780", VA = "0x187571980", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HOFNJIAMKMK : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] FNAMDLCJFFN;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DAFNOIADHGD
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void FJPCGEGLOEN(IPEndPoint NDPAACFPBHM, Span<byte> KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string KJBPJJGEMIL = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int PIKOEHPACAD = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int NJONCOELINF = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int KNHHMNPMIDN = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<PAOCKGLGJCL, IPEndPoint> MDOOABLGFGA;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static FJPCGEGLOEN BAMGNAKNIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int HKNPAOOHLEP;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	internal void HJIBHAOCHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	internal void NDEOCMMEGCD(IPEndPoint BHKCNNKIABO, Span<byte> KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class GGEBBNPHPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int NMHMGOIDBAH;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
	protected GGEBBNPHPAD(int FPBGLHIGILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OOMPKNPGMHO(IPEndPoint DHDNILPEIEL, byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void ANGJDLDDFCK(IPEndPoint DHDNILPEIEL, byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCJGICKIGFF);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BJEDOMANMCH : GGEBBNPHPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] OPGJHIOADCK;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator PEHLGNAODMH;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA2C0", Offset = "0x2AF90C0", VA = "0x182AFA2C0")]
	public BJEDOMANMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x755C150", Offset = "0x755AF50", VA = "0x18755C150")]
	public void KHPLNEOBKJP(IPEndPoint DHDNILPEIEL, byte[] OPGJHIOADCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x755C070", Offset = "0x755AE70", VA = "0x18755C070")]
	public void DONAHBHIPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x755C300", Offset = "0x755B100", VA = "0x18755C300", Slot = "4")]
	public override void OOMPKNPGMHO(IPEndPoint DHDNILPEIEL, byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x755BD10", Offset = "0x755AB10", VA = "0x18755BD10", Slot = "5")]
	public override void ANGJDLDDFCK(IPEndPoint DHDNILPEIEL, byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCJGICKIGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct BJABJLAAHCH
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void KAOBMMGENCD([NoAlias] byte* PAMEKPGAGAH, [NoAlias] byte* OPGJHIOADCK, [NoAlias] byte* OIIKNBEDDJC, int MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class GOJGMJHGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr INALKLMHNGC;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr GOBILIGGBPO;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x75735B0", Offset = "0x75723B0", VA = "0x1875735B0")]
		[BurstDiscard]
		private static void DEHFDKPNFGH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x75736D0", Offset = "0x75724D0", VA = "0x1875736D0")]
		private static IntPtr FIOOAGFKCGJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7573510", Offset = "0x7572310", VA = "0x187573510")]
		public static void AKAIBFLBHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public static void IEHCJBEIMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x75732E0", Offset = "0x75720E0", VA = "0x1875732E0")]
		public unsafe static void AHMKNKCPDKI([NoAlias] byte* PAMEKPGAGAH, [NoAlias] byte* OPGJHIOADCK, [NoAlias] byte* OIIKNBEDDJC, int MCJGICKIGFF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint OPGJHIOADCK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint OIIKNBEDDJC[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint JAPINGNAFMP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint EIMGEMDKBCJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint NNBNNEAGCIE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint NJAIAEHPIOB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint DIAOFOEBKJC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint KELDBPAFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint OLHLMPHEMHN[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x755BBF0", Offset = "0x755A9F0", VA = "0x18755BBF0")]
	private void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x755BCE0", Offset = "0x755AAE0", VA = "0x18755BCE0")]
	private uint MGDCGCFKBEH(uint MHBJBKNNPOK, int JBCIGBMHOPF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x755AED0", Offset = "0x7559CD0", VA = "0x18755AED0")]
	private void MOJEFJFOMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x755AB30", Offset = "0x7559930", VA = "0x18755AB30")]
	private void DOPAJMHIBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x755AD40", Offset = "0x7559B40", VA = "0x18755AD40")]
	private void GBEGACGFJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x755ADD0", Offset = "0x7559BD0", VA = "0x18755ADD0")]
	private void IIFPIEMGGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x755BB90", Offset = "0x755A990", VA = "0x18755BB90")]
	private void IGABBLOPGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x755B670", Offset = "0x755A470", VA = "0x18755B670")]
	private unsafe void FMPADMHCJGL(byte* PAMEKPGAGAH, uint* OPGJHIOADCK, uint* OIIKNBEDDJC, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x755B510", Offset = "0x755A310", VA = "0x18755B510")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DNHCOFHMNLA([NoAlias] byte* PAMEKPGAGAH, [NoAlias] byte* OPGJHIOADCK, [NoAlias] byte* OIIKNBEDDJC, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x755B590", Offset = "0x755A390", VA = "0x18755B590")]
	public static void DNHCOFHMNLA(Span<byte> PAMEKPGAGAH, Span<byte> OPGJHIOADCK, Span<byte> OIIKNBEDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x755BA90", Offset = "0x755A890", VA = "0x18755BA90")]
	public static void GPALNNKCPEL(Span<byte> PAMEKPGAGAH, Span<byte> OPGJHIOADCK, Span<byte> OIIKNBEDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x755BC70", Offset = "0x755AA70", VA = "0x18755BC70")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LMJLMFMCCNI([NoAlias] byte* PAMEKPGAGAH, [NoAlias] byte* OPGJHIOADCK, [NoAlias] byte* OIIKNBEDDJC, int MCJGICKIGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7573920", Offset = "0x7572720", VA = "0x187573920")]
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
