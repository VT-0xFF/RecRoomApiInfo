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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NMBHJBCIKOO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DLJEGHJCBIM
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
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
		private NetworkManager FKNKLINCDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, GJJNOHJMHJD> KAIEMLKNHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LFIJFBNOPML CDCDACJGNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] PDPHGBHENKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DLJEGHJCBIM HHCJCAAGJFF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong BBAAKCDAFIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GKOONABBAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5DA8F10", Offset = "0x5DA7F10", VA = "0x185DA8F10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8470", Offset = "0x5DA7470", VA = "0x185DA8470")]
		public void RecRoom_SetEncryptionInfo(ulong MFIHOJEMMGC, byte[] BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8450", Offset = "0x5DA7450", VA = "0x185DA8450")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8320", Offset = "0x5DA7320", VA = "0x185DA8320")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8E10", Offset = "0x5DA7E10", VA = "0x185DA8E10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8610", Offset = "0x5DA7610", VA = "0x185DA8610", Slot = "6")]
		public override void Send(ulong DEOBIPHBNIF, ArraySegment<byte> FHNKDHIILBL, NetworkDelivery IKNJBDGBLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8410", Offset = "0x5DA7410", VA = "0x185DA8410", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DEOBIPHBNIF, [Out] ArraySegment<byte> HJCJCIIFPJE, [Out] float MCFMKMILGCG)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8900", Offset = "0x5DA7900", VA = "0x185DA8900", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8D30", Offset = "0x5DA7D30", VA = "0x185DA8D30", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA79E0", Offset = "0x5DA69E0", VA = "0x185DA79E0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DEOBIPHBNIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7890", Offset = "0x5DA6890", VA = "0x185DA7890", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7C90", Offset = "0x5DA6C90", VA = "0x185DA7C90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DEOBIPHBNIF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8890", Offset = "0x5DA7890", VA = "0x185DA8890", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7DF0", Offset = "0x5DA6DF0", VA = "0x185DA7DF0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FKNKLINCDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8250", Offset = "0x5DA7250", VA = "0x185DA8250")]
		private ONLPMAFDLEL NOIACMBIAHL(NetworkDelivery PBLNJHEPKAE)
		{
			return default(ONLPMAFDLEL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7D30", Offset = "0x5DA6D30", VA = "0x185DA7D30", Slot = "15")]
		private void IGJHJOJAHKP(GJJNOHJMHJD KGOCIKCGPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7B50", Offset = "0x5DA6B50", VA = "0x185DA7B50", Slot = "16")]
		private void ENJIFBAEJOJ(GJJNOHJMHJD KGOCIKCGPIB, IPEPGCGBEOP OGCOHBKGJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "17")]
		private void GPJKDKFCDDO(IPEndPoint LCDHGKCOLJK, SocketError LAOJGCLBJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7FE0", Offset = "0x5DA6FE0", VA = "0x185DA7FE0", Slot = "18")]
		private void KIFIJJGKCDK(GJJNOHJMHJD KGOCIKCGPIB, EJFPGFCOCFL DHKLMNOOPAJ, byte MGENKCBPEBA, ONLPMAFDLEL MFCIKGBDNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7790", Offset = "0x5DA6790", VA = "0x185DA7790")]
		private void CNHEGOGBOEP(int ENCFHCJIMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "19")]
		private void POEEJHBBOHK(IPEndPoint EPALFHALBID, EJFPGFCOCFL DHKLMNOOPAJ, FKAGJILHNOD IPGIPDPIAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "20")]
		private void EMAFABICDNO(GJJNOHJMHJD KGOCIKCGPIB, int PKPMCCEMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA81F0", Offset = "0x5DA71F0", VA = "0x185DA81F0", Slot = "21")]
		private void MAGDMDKIKFL(HCBIFCAIDKM BDMHFDNBPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7FB0", Offset = "0x5DA6FB0", VA = "0x185DA7FB0")]
		private ulong JFLGNJAKEJJ(GJJNOHJMHJD KGOCIKCGPIB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7870", Offset = "0x5DA6870", VA = "0x185DA7870")]
		private static int DNABFKGPIBK(float PJKHGIHPBDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8E30", Offset = "0x5DA7E30", VA = "0x185DA8E30")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class LMJOMFIMDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GJJNOHJMHJD HPJPKKJJPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<JICHPBPHCPJ> NOHHEGIPFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PIEPJMDPGMO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA76F0", Offset = "0x5DA66F0", VA = "0x185DA76F0")]
	protected LMJOMFIMDAA(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7690", Offset = "0x5DA6690", VA = "0x185DA7690")]
	public void IEOIENOKJFM(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7610", Offset = "0x5DA6610", VA = "0x185DA7610")]
	protected void HJPMJOBKFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DA75D0", Offset = "0x5DA65D0", VA = "0x185DA75D0")]
	public bool FBBBEBDLCLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CEJNEFCJAIE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool FIKHNCAGBLE(JICHPBPHCPJ FPDJEKLDODH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum MPJCPAMIBBA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HCBIFCAIDKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LFIJFBNOPML KGDAJMOAMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int DFAPJDLLMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CFJNGMMFNAF LBBNDFEBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint GCBBCLBCGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal MPJCPAMIBBA NIANODPPPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88DC00", Offset = "0x88CC00", VA = "0x18088DC00")]
		[CompilerGenerated]
		get
		{
			return default(MPJCPAMIBBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE1EE0", Offset = "0xAE0EE0", VA = "0x180AE1EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D020", Offset = "0x5D9C020", VA = "0x185D9D020")]
	internal void OCMPGEMGNPA(CFJNGMMFNAF IDIALFHOGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CFF0", Offset = "0x5D9BFF0", VA = "0x185D9CFF0")]
	private bool LGOGJJDLHGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D080", Offset = "0x5D9C080", VA = "0x185D9D080")]
	internal HCBIFCAIDKM(IPEndPoint EPALFHALBID, CFJNGMMFNAF OFELNAOKDAB, LFIJFBNOPML FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CF90", Offset = "0x5D9BF90", VA = "0x185D9CF90")]
	public GJJNOHJMHJD APKOFNNACEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FKAGJILHNOD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BPBJDHGLKFK
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IPEPGCGBEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public BPBJDHGLKFK EEOAOJFPDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError HHDFBFNGEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EJFPGFCOCFL BPBCDFFLDKH;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMBHJBCIKOO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHHEMPNDPLF(GJJNOHJMHJD KGOCIKCGPIB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFEMICFBCAO(GJJNOHJMHJD KGOCIKCGPIB, IPEPGCGBEOP OGCOHBKGJKO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGADIJNJFKO(IPEndPoint LCDHGKCOLJK, SocketError LAOJGCLBJJO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDOBDLMJFBG(GJJNOHJMHJD KGOCIKCGPIB, EJFPGFCOCFL DHKLMNOOPAJ, byte MGENKCBPEBA, ONLPMAFDLEL MFCIKGBDNHP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJJJIFJNOGN(IPEndPoint EPALFHALBID, EJFPGFCOCFL DHKLMNOOPAJ, FKAGJILHNOD IPGIPDPIAID);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENONFLCMJEH(GJJNOHJMHJD KGOCIKCGPIB, int PKPMCCEMAFA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJBFCLIGNGC(HCBIFCAIDKM BDMHFDNBPPE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ELCEFABAJDC
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BELAOOCBACL(GJJNOHJMHJD KGOCIKCGPIB, object JLANMLLPCND);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OIMAMAEILDF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFJCIABJJFN(IKMBDLIIODL FPDJEKLDODH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LALJOJNJDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCGPBDDJAPH(GJJNOHJMHJD KGOCIKCGPIB, IPEndPoint LNOMCCILMHP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CFJNGMMFNAF
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int GCPEIKFMJCG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long ONDKLIANDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte AIJGDFMHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] BJPEBNLGJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NNMHOFHLBFD MEEFJAOGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int IKIIIECFGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D952D0", Offset = "0x5D942D0", VA = "0x185D952D0")]
	private CFJNGMMFNAF(long HANIAMFLBLK, byte OMPPAAIJGLJ, int OJMEEMCEEJO, byte[] IOEJNIALNND, NNMHOFHLBFD FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D95270", Offset = "0x5D94270", VA = "0x185D95270")]
	public static int MLGKMKFJDCC(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D95050", Offset = "0x5D94050", VA = "0x185D95050")]
	public static CFJNGMMFNAF JNPKBMOLAOA(JICHPBPHCPJ FPDJEKLDODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D94E70", Offset = "0x5D93E70", VA = "0x185D94E70")]
	public static JICHPBPHCPJ BCLOGDKNCHM(FHIPOIAMPCO CHKPPDBFDPC, SocketAddress AHLAJIOLDFD, long EAEGDDFGMOP, int OJMEEMCEEJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BEJALNCKEJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long ONDKLIANDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte AIJGDFMHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int IKIIIECFGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool LEEKOADNKNG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D94D40", Offset = "0x5D93D40", VA = "0x185D94D40")]
	private BEJALNCKEJH(long HANIAMFLBLK, byte OMPPAAIJGLJ, int IOFGOGLLBEB, bool DEKHJJKPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D94AF0", Offset = "0x5D93AF0", VA = "0x185D94AF0")]
	public static BEJALNCKEJH JNPKBMOLAOA(JICHPBPHCPJ FPDJEKLDODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D94A00", Offset = "0x5D93A00", VA = "0x185D94A00")]
	public static JICHPBPHCPJ BCLOGDKNCHM(long EAEGDDFGMOP, byte MKKPMEDNOEG, int BACIKEKFGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D94C40", Offset = "0x5D93C40", VA = "0x185D94C40")]
	public static JICHPBPHCPJ MOOHPPDKMEE(GJJNOHJMHJD KGOCIKCGPIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BCCCKCMDJFD
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NNJCJLAHJMF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNOEPBKNDON(IPEndPoint AJFFDEDBBFA, IPEndPoint EPALFHALBID, string OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDLOAMFPBFI(IPEndPoint MLLPFPGFNOC, BCCCKCMDJFD PBLNJHEPKAE, string OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CMPOFBNFMKN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct HKPCHEFGLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HKLCNAFFBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint GCBBCLBCGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string EANNOFDJPJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KLDPPOAFLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JHEJDGHIMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BCCCKCMDJFD MDBCEFGBENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string EANNOFDJPJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class GCDCMCBMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint GIGAFGPJIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string EANNOFDJPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public GCDCMCBMCOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PJGIEBKBAMC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GIGAFGPJIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint PPHLCHHNMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EANNOFDJPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public PJGIEBKBAMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CLEJPNHDHOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EANNOFDJPJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EDIMCBJAPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x932C30", Offset = "0x931C30", VA = "0x180932C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x873440", Offset = "0x872440", VA = "0x180873440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public CLEJPNHDHOM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LFIJFBNOPML LMADIHGEODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<HKPCHEFGLJF> IJDJCLNBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<KLDPPOAFLLO> OAMPJMPOHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NNMHOFHLBFD CLBBGOMNMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FHIPOIAMPCO PFKMNEHCOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly IMOEMNIAFHJ GNEBDGKGKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NNJCJLAHJMF PMFCALJILGL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int NAGPEFECJHA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HPEBOGJHMBC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D95930", Offset = "0x5D94930", VA = "0x185D95930")]
	internal CMPOFBNFMKN(LFIJFBNOPML GKIFPCFMELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D95340", Offset = "0x5D94340", VA = "0x185D95340")]
	internal void CBCIOJLEOJO(IPEndPoint GPNENHDLNJB, JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x293FFC0", Offset = "0x293EFC0", VA = "0x18293FFC0")]
	private void JJLBJGACDAA<T>(T FPDJEKLDODH, IPEndPoint PKMPGPJICGL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D954A0", Offset = "0x5D944A0", VA = "0x185D954A0")]
	private void FNOEPBKNDON(GCDCMCBMCOO PGAFBDKJIFH, IPEndPoint GPNENHDLNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D95630", Offset = "0x5D94630", VA = "0x185D95630")]
	private void IAMELBBMPFP(PJGIEBKBAMC PGAFBDKJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D95790", Offset = "0x5D94790", VA = "0x185D95790")]
	private void NPNCJKLMFKH(CLEJPNHDHOM PGAFBDKJIFH, IPEndPoint GPNENHDLNJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ONLPMAFDLEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DEBDAFBHIIF : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CAAEELJGANH
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] CEBICIFCJBC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int FFFGKDOCNKO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int GFOEILCJGDJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KMPCCGNLMPM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0490", Offset = "0x5D9F490", VA = "0x185DA0490")]
	public KMPCCGNLMPM(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LCBHAADFFCI : KMPCCGNLMPM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0490", Offset = "0x5D9F490", VA = "0x185DA0490")]
	public LCBHAADFFCI(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DKNKKCEEGAK
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JPEIKJADNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLBNOAOPDNG(DKNKKCEEGAK LEKBLIFLCLN, string KIBGJLLHGOJ, params object[] NENLABMEOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NHEOFMELBLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static JPEIKJADNPI KFJGENPDIPH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object EGIONBGHOLK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8FD0", Offset = "0x5DA7FD0", VA = "0x185DA8FD0")]
	private static void DACKKJPMHBI(DKNKKCEEGAK GFGIBKKAOHD, string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9260", Offset = "0x5DA8260", VA = "0x185DA9260")]
	internal static void MIHDDBJAPFJ(string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DA92C0", Offset = "0x5DA82C0", VA = "0x185DA92C0")]
	internal static void OMLNBGDCIBO(string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9200", Offset = "0x5DA8200", VA = "0x185DA9200")]
	internal static void KDPODNCPLPJ(string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MOHCKOKGADO
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EJFPGFCOCFL : NNMHOFHLBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JICHPBPHCPJ KJPAMFEEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LFIJFBNOPML NNKBHNMFCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IFBEODGHCBF ANIBMPPDIJO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D96890", Offset = "0x5D95890", VA = "0x185D96890")]
	internal EJFPGFCOCFL(LFIJFBNOPML MFNJBGPIIEN, IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D96820", Offset = "0x5D95820", VA = "0x185D96820")]
	internal void OJMPAENKOFP(JICHPBPHCPJ FPDJEKLDODH, int OGBDMBHBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D96770", Offset = "0x5D95770", VA = "0x185D96770")]
	internal void GEMCHGNIDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D967F0", Offset = "0x5D957F0", VA = "0x185D967F0")]
	public void HEGLCBGHIJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class IFBEODGHCBF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum CJFAJMANKHM
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public IFBEODGHCBF AOODDNLKEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public CJFAJMANKHM MDBCEFGBENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GJJNOHJMHJD HPJPKKJJPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint GCBBCLBCGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object GBMLFDPBMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GONEEHKNFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError MOEMFHOLLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public BPBJDHGLKFK PAGILJOFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public HCBIFCAIDKM MEMKEJFOIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public ONLPMAFDLEL AJHGFIDNKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte DDIDGDDKGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly EJFPGFCOCFL CMFENCAMBGM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E190", Offset = "0x5D9D190", VA = "0x185D9E190")]
	public IFBEODGHCBF(LFIJFBNOPML MFNJBGPIIEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LFIJFBNOPML : IEnumerable<GJJNOHJMHJD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class IMEBEGGJJOB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D9F5C0", Offset = "0x5D9E5C0", VA = "0x185D9F5C0", Slot = "4")]
		public bool Equals(IPEndPoint OOALEDCPNBJ, IPEndPoint HDFOCKKCOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5873D30", Offset = "0x5872D30", VA = "0x185873D30", Slot = "5")]
		public int GetHashCode(IPEndPoint HBFCGFKGCAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public IMEBEGGJJOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct GEAENLCPLOB : IEnumerator<GJJNOHJMHJD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly GJJNOHJMHJD BGNIPDPPICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GJJNOHJMHJD ADMMOBBFKGB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GJJNOHJMHJD NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EC0", Offset = "0x8D3EC0", VA = "0x1808D4EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EC0", Offset = "0x8D3EC0", VA = "0x1808D4EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10E5070", Offset = "0x10E4070", VA = "0x1810E5070")]
		public GEAENLCPLOB(GJJNOHJMHJD EBPGHIDCOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D97830", Offset = "0x5D96830", VA = "0x185D97830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D97880", Offset = "0x5D96880", VA = "0x185D97880", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MCLOCPMIMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool IKJKOIEPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CDOGKOJCLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<IFBEODGHCBF> NBIBEALMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<IFBEODGHCBF> GMGHIAGHBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IFBEODGHCBF ABIMOCDJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NMBHJBCIKOO AOEMDNMGJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ELCEFABAJDC MONPDEFPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OIMAMAEILDF NFNEOMJGCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LALJOJNJDAI FCLEFPFHMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, GJJNOHJMHJD> NEJKMEJELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, HCBIFCAIDKM> EGPJCPDMGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, FNKDGJCKHCP> MLKNDJKNPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JBHIOLNHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GJJNOHJMHJD AICNEMOGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int EMLFOPFFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<GJJNOHJMHJD> NLHEPAJLEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GJJNOHJMHJD[] LNACMAEKCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KGBCAJKLEKC PNPJJNGHELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int HCABODFNDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> KJMLAFLPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte NEGACFEOMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LBFLGMJDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool MMDCKAGKJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool KFEFMFLEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int IDOCIMNNPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int BMCNDJONNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int AMMLKPJILPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int LGPPGLEFEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool NMLICCEIPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool HIMBDJCMLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IEBILLONKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FAFGPLHIAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MAIJGKJKNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HPEBOGJHMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool HGPPBDBFHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool IHAFFDFABBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool EHIOHAAOODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int GPADHIDNDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BCEHEKHCNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool JGDPNCHKDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly PKJIFAGNCBA BPJJHKNOBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HLLJMINFPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly CMPOFBNFMKN CNNOJGIJLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HJICPAFMJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public MOHCKOKGADO FBALBIOCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int AJNLNGKEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool EPPABKEFABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool EIPIIBENKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KIOCBLHBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NLJJOBAFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private JICHPBPHCPJ MAPPNCHLCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int AELOBOJGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object HJEPIFMEPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private JICHPBPHCPJ MJMOACFMJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int AJAIKOPDGEM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BBKDCMHNCIC = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DHONGOKMGME = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CDIEIPHKDLN PMBGELPEKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private CDIEIPHKDLN LLCCMMIBDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread GCEDJJJLLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread GMKCBHBFHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint OMMDJCCIGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint BPBNCAPEKCC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] PECAFGCONAE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] FENKONBBGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<HAMHCMIEKGP, IPEndPoint> MNCIOFFMEDD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress FNMJKJMFIAE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool DCLCOPCIMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int LAPLFLDNBKE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PJNMNHJLKND
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBE1A20", Offset = "0xBE0A20", VA = "0x180BE1A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC910F0", Offset = "0xC900F0", VA = "0x180C910F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DJDBMGEOBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14E4D50", Offset = "0x14E3D50", VA = "0x1814E4D50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1813360", Offset = "0x1812360", VA = "0x181813360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ANDEEMEMLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA49410", Offset = "0xA48410", VA = "0x180A49410")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ONDOMCJNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3F30", Offset = "0x5DA2F30", VA = "0x185DA3F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short JABFIKAHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6CE0", Offset = "0x5DA5CE0", VA = "0x185DA6CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4550", Offset = "0x5DA3550", VA = "0x185DA4550")]
	public void MACAHMMOAAM(IPEndPoint LCDHGKCOLJK, byte[] BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3850", Offset = "0x5DA2850", VA = "0x185DA3850")]
	public void KOIAFCACCEC(IPEndPoint LCDHGKCOLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1820", Offset = "0x5DA0820", VA = "0x185DA1820")]
	private bool CCJIDNGMCKB(IPEndPoint LCDHGKCOLJK, [Out] GJJNOHJMHJD KGOCIKCGPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DA49D0", Offset = "0x5DA39D0", VA = "0x185DA49D0")]
	private void MOLBMEBMIEO(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2660", Offset = "0x5DA1660", VA = "0x185DA2660")]
	private void GBPOCCPBLDE(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2D10", Offset = "0x5DA1D10", VA = "0x185DA2D10")]
	private void HKHMNJFOEMJ(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6F80", Offset = "0x5DA5F80", VA = "0x185DA6F80")]
	public LFIJFBNOPML(NMBHJBCIKOO FFNFEBMFPGM, [Optional] KGBCAJKLEKC CNEOEMMBFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA17D0", Offset = "0x5DA07D0", VA = "0x185DA17D0")]
	internal void BPMMHNCNGPG(GJJNOHJMHJD PKEPMOGPMJK, int PKPMCCEMAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0800", Offset = "0x5D9F800", VA = "0x185DA0800")]
	internal void AIJPJCAKALN(GJJNOHJMHJD PKEPMOGPMJK, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1C20", Offset = "0x5DA0C20", VA = "0x185DA1C20")]
	internal void EHMKCAMNKEL(GJJNOHJMHJD KGOCIKCGPIB, BPBJDHGLKFK CLPBFEAPBCA, SocketError PPBCMFHDHJD, JICHPBPHCPJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6560", Offset = "0x5DA5560", VA = "0x185DA6560")]
	private void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB, BPBJDHGLKFK CLPBFEAPBCA, SocketError PPBCMFHDHJD, bool BAKDLGCFEEB, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG, JICHPBPHCPJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1D50", Offset = "0x5DA0D50", VA = "0x185DA1D50")]
	private void EODANKEBFDF(IFBEODGHCBF.CJFAJMANKHM PBLNJHEPKAE, [Optional] GJJNOHJMHJD KGOCIKCGPIB, [Optional] IPEndPoint EPALFHALBID, SocketError NIEIPBDODCM = SocketError.Success, int PKPMCCEMAFA = 0, BPBJDHGLKFK FMGPPMEOPCB = BPBJDHGLKFK.ConnectionFailed, [Optional] HCBIFCAIDKM LIGMAJIGLEC, ONLPMAFDLEL MFCIKGBDNHP = ONLPMAFDLEL.Unreliable, byte MGENKCBPEBA = 0, [Optional] JICHPBPHCPJ NLDBPMPJNFN, [Optional] object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4D70", Offset = "0x5DA3D70", VA = "0x185DA4D70")]
	private void OABHEPOLHHD(IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DA27A0", Offset = "0x5DA17A0", VA = "0x185DA27A0")]
	internal void GLIABFEJOAA(IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3510", Offset = "0x5DA2510", VA = "0x185DA3510")]
	private void KNKFNCNBCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2340", Offset = "0x5DA1340", VA = "0x185DA2340")]
	private void GBPKBNGNKBA(int FANCJOIFAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DA66C0", Offset = "0x5DA56C0", VA = "0x185DA66C0")]
	internal GJJNOHJMHJD PLEALMBFGNB(HCBIFCAIDKM BDMHFDNBPPE, byte[] BICMBICIBOO, int ODFMKGCLIGE, int DOIKAIEGGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6640", Offset = "0x5DA5640", VA = "0x185DA6640")]
	private int PJAMOMGPDPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0850", Offset = "0x5D9F850", VA = "0x185DA0850")]
	private void BFKBALMJCJD(IPEndPoint EPALFHALBID, GJJNOHJMHJD MLOHIKMHOEC, CFJNGMMFNAF MPCJPLJMLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5530", Offset = "0x5DA4530", VA = "0x185DA5530")]
	private void OEIIAKNCLPC(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0CB0", Offset = "0x5D9FCB0", VA = "0x185DA0CB0")]
	internal void BGKHMAKHJED(JICHPBPHCPJ FPDJEKLDODH, ONLPMAFDLEL HENFOAJPMCO, byte MGENKCBPEBA, int OGBDMBHBCCC, GJJNOHJMHJD PKEPMOGPMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0F90", Offset = "0x5D9FF90", VA = "0x185DA0F90")]
	public bool BKDEJNGAEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0F70", Offset = "0x5D9FF70", VA = "0x185DA0F70")]
	public bool BKDEJNGAEPP(IPAddress HBCNFILNODA, IPAddress PBMGBFLNOGP, int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1750", Offset = "0x5DA0750", VA = "0x185DA1750")]
	public bool BKDEJNGAEPP(int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA28A0", Offset = "0x5DA18A0", VA = "0x185DA28A0")]
	public void HCJDLNCKALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3E50", Offset = "0x5DA2E50", VA = "0x185DA3E50")]
	public GJJNOHJMHJD KPKNGIBLEHL(string FHOAFCBIOFF, int JCEBAOIBEAD, string BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA39A0", Offset = "0x5DA29A0", VA = "0x185DA39A0")]
	public GJJNOHJMHJD KPKNGIBLEHL(string FHOAFCBIOFF, int JCEBAOIBEAD, FHIPOIAMPCO PEODDADPNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3A80", Offset = "0x5DA2A80", VA = "0x185DA3A80")]
	public GJJNOHJMHJD KPKNGIBLEHL(IPEndPoint PKMPGPJICGL, FHIPOIAMPCO PEODDADPNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5DA07F0", Offset = "0x5D9F7F0", VA = "0x185DA07F0")]
	public void AAKANIGBLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5DA04A0", Offset = "0x5D9F4A0", VA = "0x185DA04A0")]
	public void AAKANIGBLDP(bool NEMHLKJFNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5DA32F0", Offset = "0x5DA22F0", VA = "0x185DA32F0")]
	public void JBADKAJNBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5DA33F0", Offset = "0x5DA23F0", VA = "0x185DA33F0")]
	public void JBADKAJNBMK(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5DA64B0", Offset = "0x5DA54B0", VA = "0x185DA64B0")]
	public void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5DA63F0", Offset = "0x5DA53F0", VA = "0x185DA63F0")]
	public void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6DA0", Offset = "0x5DA5DA0", VA = "0x185DA6DA0", Slot = "4")]
	private IEnumerator<GJJNOHJMHJD> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6E30", Offset = "0x5DA5E30", VA = "0x185DA6E30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1A50", Offset = "0x5DA0A50", VA = "0x185DA1A50")]
	private JICHPBPHCPJ EEPFNGCHEFD(OHGHPKPFANP PDOOMGNBLHC, int ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1B40", Offset = "0x5DA0B40", VA = "0x185DA1B40")]
	private JICHPBPHCPJ EEPFNGCHEFD(OHGHPKPFANP PDOOMGNBLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2110", Offset = "0x5DA1110", VA = "0x185DA2110")]
	internal JICHPBPHCPJ FNALCEKNAOM(int ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4770", Offset = "0x5DA3770", VA = "0x185DA4770")]
	internal void MJADMCMKELH(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6EC0", Offset = "0x5DA5EC0", VA = "0x185DA6EC0")]
	static LFIJFBNOPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBE1A20", Offset = "0xBE0A20", VA = "0x180BE1A20")]
	private bool CJMHCJFHMME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA26B0", Offset = "0x5DA16B0", VA = "0x185DA26B0")]
	private void GFIFBGILIPP(IPEndPoint CLAGGHDFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4C90", Offset = "0x5DA3C90", VA = "0x185DA4C90")]
	private void NBCNFJODPDO(IPEndPoint CLAGGHDFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DA18B0", Offset = "0x5DA08B0", VA = "0x185DA18B0")]
	private bool DEONAAENOME(SocketException CNGGKHFOGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2A40", Offset = "0x5DA1A40", VA = "0x185DA2A40")]
	private void HFAMHCBELAA(CDIEIPHKDLN GKIFPCFMELL, EndPoint LJBJJIDMEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DA2F60", Offset = "0x5DA1F60", VA = "0x185DA2F60")]
	private void IIPJKPCKEED(object NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0FA0", Offset = "0x5D9FFA0", VA = "0x185DA0FA0")]
	public bool BKDEJNGAEPP(IPAddress HBCNFILNODA, IPAddress PBMGBFLNOGP, int JCEBAOIBEAD, bool LANKGDIMONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1CF0", Offset = "0x5DA0CF0", VA = "0x185DA1CF0")]
	internal int EKKJDDCBHCO(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4510", Offset = "0x5DA3510", VA = "0x185DA4510")]
	internal int LKLPLKPHKDK(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3F50", Offset = "0x5DA2F50", VA = "0x185DA3F50")]
	internal int LKLPLKPHKDK(byte[] NFOHONOFFAP, int ODFMKGCLIGE, int DOIKAIEGGLD, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6280", Offset = "0x5DA5280", VA = "0x185DA6280")]
	internal void OFENDFAJKCJ(bool IBEKCEJAHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum OHGHPKPFANP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class JICHPBPHCPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MIGGLJAPPPO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] JEBHNBDMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] MNDFPFJOAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int PMILGDKKIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object GBMLFDPBMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public JICHPBPHCPJ AOODDNLKEHF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public OHGHPKPFANP HBCOLPMCOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FE70", Offset = "0x5D9EE70", VA = "0x185D9FE70")]
		get
		{
			return default(OHGHPKPFANP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FF80", Offset = "0x5D9EF80", VA = "0x185D9FF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AIJGDFMHNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FD40", Offset = "0x5D9ED40", VA = "0x185D9FD40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FFC0", Offset = "0x5D9EFC0", VA = "0x185D9FFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort IEJLPCIEMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FA10", Offset = "0x5D9EA10", VA = "0x185D9FA10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FB60", Offset = "0x5D9EB60", VA = "0x185D9FB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CKLBAICIECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FBE0", Offset = "0x5D9EBE0", VA = "0x185D9FBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte AKLFMBMKGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0000", Offset = "0x5D9F000", VA = "0x185DA0000")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FD10", Offset = "0x5D9ED10", VA = "0x185D9FD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LIMOEONGIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FB00", Offset = "0x5D9EB00", VA = "0x185D9FB00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FBA0", Offset = "0x5D9EBA0", VA = "0x185D9FBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort BPDNJGGNBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FA70", Offset = "0x5D9EA70", VA = "0x185D9FA70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FEE0", Offset = "0x5D9EEE0", VA = "0x185D9FEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort NLJIMJEOKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FF20", Offset = "0x5D9EF20", VA = "0x185D9FF20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FEA0", Offset = "0x5D9EEA0", VA = "0x185D9FEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0030", Offset = "0x5D9F030", VA = "0x185DA0030")]
	static JICHPBPHCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FAD0", Offset = "0x5D9EAD0", VA = "0x185D9FAD0")]
	public void BKLEHGECOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0420", Offset = "0x5D9F420", VA = "0x185DA0420")]
	public JICHPBPHCPJ(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0310", Offset = "0x5D9F310", VA = "0x185DA0310")]
	public JICHPBPHCPJ(OHGHPKPFANP PDOOMGNBLHC, int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FD70", Offset = "0x5D9ED70", VA = "0x185D9FD70")]
	public static int HPIOFFHFNFM(OHGHPKPFANP PDOOMGNBLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FDE0", Offset = "0x5D9EDE0", VA = "0x185D9FDE0")]
	public int HPIOFFHFNFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D9FC10", Offset = "0x5D9EC10", VA = "0x185D9FC10")]
	public bool FLCOFIJHBAO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum IFENKPNKJAG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum CKCJFLIKINK
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum EIGPLHMDAGA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum FCLJIMPCIJN
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GJJNOHJMHJD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NMHEPOEOBMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JICHPBPHCPJ[] BACGNCOPKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int AMFOHEMBDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PDIELHEHPPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte AKLFMBMKGAE;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public NMHEPOEOBMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void JLPOPDCPIPA(ulong HHFBAHGMGCH, int GDNDKANKBCB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int NOKODJAEMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int BFEAEOEDJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LIIMMLOJCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double ENHEFODHEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int EGFDFPLHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int DDFFEEAKBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int NOGNGEEEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GFDJAAFFLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int AMLGHEPDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long GEOLIKIOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object HPJPABBGHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal GJJNOHJMHJD JNAFHJNJOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal GJJNOHJMHJD JBFJFEJFLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<JICHPBPHCPJ> JJFNBCADEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<LMJOMFIMDAA> HJPGMDIEAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly LMJOMFIMDAA[] KCPCGMJGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int LLCHFKDIMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int DEIGMCKHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool NEFJDKPBMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int PEGJMHCFJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int NGLCDMEFFIH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int OGJKPDKLJPE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int PNALHIMLPKP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object KGKDMIHKKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int HPOODIHKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, NMHEPOEOBMP> ADCGAMACIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> FMNCMBAINJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly JICHPBPHCPJ BNEDMDPOKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HPELKJMMMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int PPKIKDLIHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint ANLGOLHKEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int EFEPMNIMOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HCDGHDCPHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long KNKKOJDDFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte NJBBOCMMCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IFENKPNKJAG PHKIONNMLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JICHPBPHCPJ MNOMKCBHGKL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int JDGBDCDAFMO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int CMMEOCHOECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly JICHPBPHCPJ AFLLIKMKOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly JICHPBPHCPJ IIEPAGOBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly JICHPBPHCPJ AJNLBFGNGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly JICHPBPHCPJ PJOMNKAPJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DEBDAFBHIIF GOLCIDBPJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LFIJFBNOPML IBEOGJLABOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int FDMEMBGGBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object CFHELBLJIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly PKJIFAGNCBA BPJJHKNOBJB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte BFOCBBHAODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC24F60", Offset = "0xC23F60", VA = "0x180C24F60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D99A50", Offset = "0x5D98A50", VA = "0x185D99A50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint HMIBJCFHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F20", Offset = "0x8D0F20", VA = "0x1808D1F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public IFENKPNKJAG EOHEKNOANHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x131BC10", Offset = "0x131AC10", VA = "0x18131BC10")]
		get
		{
			return default(IFENKPNKJAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long PHKEIFGLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x872660", Offset = "0x871660", VA = "0x180872660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HHNCAPOBIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCF48B0", Offset = "0xCF38B0", VA = "0x180CF48B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15E3890", Offset = "0x15E2890", VA = "0x1815E3890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int INMKFNGPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A860", Offset = "0x5D99860", VA = "0x185D9A860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DOLOICAIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8753F0", Offset = "0x8743F0", VA = "0x1808753F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double GFNCDHJOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A69240", Offset = "0x1A68240", VA = "0x181A69240")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JLPOPDCPIPA BLMGHPILEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A870", Offset = "0x5D99870", VA = "0x185D9A870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D97BE0", Offset = "0x5D96BE0", VA = "0x185D97BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D9B2B0", Offset = "0x5D9A2B0", VA = "0x185D9B2B0")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, IPEndPoint EPALFHALBID, int BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D99900", Offset = "0x5D98900", VA = "0x185D99900")]
	internal void MBNNEJHCHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D99920", Offset = "0x5D98920", VA = "0x185D99920")]
	internal void MODEJJONMDO(IPEndPoint BFMGPKEKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D98020", Offset = "0x5D97020", VA = "0x185D98020")]
	internal void CMECJBNCNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D99160", Offset = "0x5D98160", VA = "0x185D99160")]
	private void KJHNADNLFPF(int JJBCOOHCLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D99B00", Offset = "0x5D98B00", VA = "0x185D99B00")]
	private void OBHENMLGFDC(int MCGCKADFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D97A30", Offset = "0x5D96A30", VA = "0x185D97A30")]
	private LMJOMFIMDAA AAHCABHNCIM(byte JPMDPHGDIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D9B8F0", Offset = "0x5D9A8F0", VA = "0x185D9B8F0")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, IPEndPoint EPALFHALBID, int BLCJLIJFBDL, byte MKKPMEDNOEG, FHIPOIAMPCO CHKPPDBFDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D9B710", Offset = "0x5D9A710", VA = "0x185D9B710")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, HCBIFCAIDKM BDMHFDNBPPE, int BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D99950", Offset = "0x5D98950", VA = "0x185D99950")]
	internal void NACDBEPMCDH(CFJNGMMFNAF PPEMCBLGBJK, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D98A20", Offset = "0x5D97A20", VA = "0x185D98A20")]
	internal bool GIHCFIHPCKN(BEJALNCKEJH FPDJEKLDODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D99130", Offset = "0x5D98130", VA = "0x185D99130")]
	public void JJLBJGACDAA(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, ONLPMAFDLEL HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D9A310", Offset = "0x5D99310", VA = "0x185D9A310")]
	private void PFELOOIOBPH(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, byte MGENKCBPEBA, ONLPMAFDLEL MFCIKGBDNHP, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D999A0", Offset = "0x5D989A0", VA = "0x185D999A0")]
	public void NAHHOKAIFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D98AA0", Offset = "0x5D97AA0", VA = "0x185D98AA0")]
	internal EIGPLHMDAGA HPGLAALGIBE(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(EIGPLHMDAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D98B80", Offset = "0x5D97B80", VA = "0x185D98B80")]
	internal void ICIGPCBBFIP(LMJOMFIMDAA FAJHEEIDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D995F0", Offset = "0x5D985F0", VA = "0x185D995F0")]
	internal FCLJIMPCIJN LLEEPCOAPIE(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, bool BAKDLGCFEEB)
	{
		return default(FCLJIMPCIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D995B0", Offset = "0x5D985B0", VA = "0x185D995B0")]
	private void LFMAGHJNHEK(int NHFDPKDEEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D9A920", Offset = "0x5D99920", VA = "0x185D9A920")]
	internal void PPKALHECEDD(ONLPMAFDLEL HENFOAJPMCO, JICHPBPHCPJ EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D98BE0", Offset = "0x5D97BE0", VA = "0x185D98BE0")]
	private void JCAAPBGNIIC(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D99230", Offset = "0x5D98230", VA = "0x185D99230")]
	private void LDEHBKEAMLO(int DGOHALMDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D97C90", Offset = "0x5D96C90", VA = "0x185D97C90")]
	internal CKCJFLIKINK BFKBALMJCJD(CFJNGMMFNAF MPCJPLJMLEG)
	{
		return default(CKCJFLIKINK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D98370", Offset = "0x5D97370", VA = "0x185D98370")]
	internal void FIKHNCAGBLE(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D9A1F0", Offset = "0x5D991F0", VA = "0x185D9A1F0")]
	private void PCFNOGHFOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D97E50", Offset = "0x5D96E50", VA = "0x185D97E50")]
	internal void BPDDHIKPMAA(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D99B40", Offset = "0x5D98B40", VA = "0x185D99B40")]
	internal void OMKLHJHPBJI(int DGOHALMDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D980B0", Offset = "0x5D970B0", VA = "0x185D980B0")]
	internal void EFAECDLFJEB(JICHPBPHCPJ FPDJEKLDODH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PKJIFAGNCBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PBOIEBMPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long JGEKLOEKMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long NKINEDFJJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LKAEFOJDHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long OECFHLBMLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long APMIDELMPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long PNEICIMMFLA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long DOGEHHCDHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA260", Offset = "0x5DA9260", VA = "0x185DAA260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EIDILKPOFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA050", Offset = "0x5DA9050", VA = "0x185DAA050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PGDPPIBIOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA150", Offset = "0x5DA9150", VA = "0x185DAA150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DDIHIBLBMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA240", Offset = "0x5DA9240", VA = "0x185DAA240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AKFPOGMNGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA280", Offset = "0x5DA9280", VA = "0x185DAA280")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CLGGHGEIDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA270", Offset = "0x5DA9270", VA = "0x185DAA270")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DEBDAFBHIIF AELILFKMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA230", Offset = "0x5DA9230", VA = "0x185DAA230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double IANHMAGNDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA170", Offset = "0x5DA9170", VA = "0x185DAA170")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA1D0", Offset = "0x5DA91D0", VA = "0x185DAA1D0")]
	public void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA020", Offset = "0x5DA9020", VA = "0x185DAA020")]
	public void AFOIKDCGEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA250", Offset = "0x5DA9250", VA = "0x185DAA250")]
	public void IBNGNIKABAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA0A0", Offset = "0x5DA90A0", VA = "0x185DAA0A0")]
	public void BBMHIALFIPE(long DJPBLJMFLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA160", Offset = "0x5DA9160", VA = "0x185DAA160")]
	public void COJIGMCEMLL(long NAFDJBHIEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA290", Offset = "0x5DA9290", VA = "0x185DAA290")]
	public void LFMKJGOIPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA060", Offset = "0x5DA9060", VA = "0x185DAA060")]
	public void BANMMOLHEPL(long DBBIJBFGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA2C0", Offset = "0x5DA92C0", VA = "0x185DAA2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA0B0", Offset = "0x5DA90B0", VA = "0x185DAA0B0")]
	public void BDBEOJILAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public PKJIFAGNCBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ANKFNMGDEJC
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JJLJLLMNDAJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D94490", Offset = "0x5D93490", VA = "0x185D94490")]
	public static IPEndPoint FEPDDLIJCGD(string DOMGNDPKIOI, int JCEBAOIBEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D947A0", Offset = "0x5D937A0", VA = "0x185D947A0")]
	public static IPAddress NHOBLIEFHCA(string DOMGNDPKIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D94710", Offset = "0x5D93710", VA = "0x185D94710")]
	public static IPAddress NHOBLIEFHCA(string DOMGNDPKIOI, AddressFamily FOEFNDNJIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D946E0", Offset = "0x5D936E0", VA = "0x185D946E0")]
	internal static int HHIKGIKLFCE(int BJENHFKIEMM, int MODONOEGFJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x31C0A10", Offset = "0x31BFA10", VA = "0x1831C0A10")]
	internal static T[] MCCLBOIDBAL<T>(int JPBPNOCHNLG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HPOGIEBELNB : LMJOMFIMDAA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DGKMEAIBMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private JICHPBPHCPJ KJPAMFEEHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long MGOHIPBMJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool NJFNOADEBKK;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D95E60", Offset = "0x5D94E60", VA = "0x185D95E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D95DF0", Offset = "0x5D94DF0", VA = "0x185D95DF0")]
		public void IPJLDPAJHCH(JICHPBPHCPJ FPDJEKLDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D95D80", Offset = "0x5D94D80", VA = "0x185D95D80")]
		public bool HPCMHFHMIBC(long AAEDJKLCPHK, GJJNOHJMHJD KGOCIKCGPIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D95E10", Offset = "0x5D94E10", VA = "0x185D95E10")]
		public bool OAIAOCAHOEL(GJJNOHJMHJD KGOCIKCGPIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly JICHPBPHCPJ OLIFFGJGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DGKMEAIBMIJ[] FNLBMENHDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly JICHPBPHCPJ[] MANHEGIFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] KJDJEFGLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int LDDFBKMKBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int JOOPCNIFCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int GPGFIKJFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int KLLJJLKJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool DHPLGAJECDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly ONLPMAFDLEL KPMAHDLPLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool KOFHIOICPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int JMNGICIMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte CPHBDPKAAJB;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DFC0", Offset = "0x5D9CFC0", VA = "0x185D9DFC0")]
	public HPOGIEBELNB(GJJNOHJMHJD KGOCIKCGPIB, bool CBNMEHHCHCO, byte BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DC00", Offset = "0x5D9CC00", VA = "0x185D9DC00")]
	private void NCDOJPNDEIO(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D0F0", Offset = "0x5D9C0F0", VA = "0x185D9D0F0", Slot = "4")]
	protected override bool CEJNEFCJAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D5A0", Offset = "0x5D9C5A0", VA = "0x185D9D5A0", Slot = "5")]
	public override bool FIKHNCAGBLE(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DKDNLNKNHEN : LMJOMFIMDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EBPLDLGFFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort JOOPCNIFCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool PCHNDLGPKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private JICHPBPHCPJ BDMHCLEANGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly JICHPBPHCPJ OIGNJIBFOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool PHNEJCOHMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte CPHBDPKAAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long FFGEOKIKMEI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D966B0", Offset = "0x5D956B0", VA = "0x185D966B0")]
	public DKDNLNKNHEN(GJJNOHJMHJD KGOCIKCGPIB, bool NLOGBFFANAN, byte BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D95F00", Offset = "0x5D94F00", VA = "0x185D95F00", Slot = "4")]
	protected override bool CEJNEFCJAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D963A0", Offset = "0x5D953A0", VA = "0x185D963A0", Slot = "5")]
	public override bool FIKHNCAGBLE(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GHMFOIMEOBE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct IOOCGFEDLAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong BCKJEANKENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double FEJPJGLNBAM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KEGJALHFKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int HHIBDBNFAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float DAIFEMHKDBG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5D93730", Offset = "0x5D92730", VA = "0x185D93730")]
	private static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, ulong FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D97910", Offset = "0x5D96910", VA = "0x185D97910")]
	private static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D978D0", Offset = "0x5D968D0", VA = "0x185D978D0")]
	public static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, short FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D97A00", Offset = "0x5D96A00", VA = "0x185D97A00")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, double CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D97980", Offset = "0x5D96980", VA = "0x185D97980")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D978D0", Offset = "0x5D968D0", VA = "0x185D978D0")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, short CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D978D0", Offset = "0x5D968D0", VA = "0x185D978D0")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, ushort CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D97910", Offset = "0x5D96910", VA = "0x185D97910")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D97910", Offset = "0x5D96910", VA = "0x185D97910")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, uint CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D97A20", Offset = "0x5D96A20", VA = "0x185D97A20")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D97A20", Offset = "0x5D96A20", VA = "0x185D97A20")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, ulong CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NNMHOFHLBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] CDDNPCEBPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int BNDIJLNGDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int KMHIHBHHLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int OGDPIIPFCNH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] MNDFPFJOAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int PBPODOLIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CAPBDPELJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9440", Offset = "0x5DA8440", VA = "0x185DA9440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KCHDCGEDEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EC8B20", Offset = "0x1EC7B20", VA = "0x181EC8B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KOCNONLLNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9C90", Offset = "0x5DA8C90", VA = "0x185DA9C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9EA0", Offset = "0x5DA8EA0", VA = "0x185DA9EA0")]
	public void OJMPAENKOFP(byte[] CHNGFEKJHON, int ANNLKNNLIGI, int APEEGJFCMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public NNMHOFHLBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9FC0", Offset = "0x5DA8FC0", VA = "0x185DA9FC0")]
	public NNMHOFHLBFD(byte[] CHNGFEKJHON, int ANNLKNNLIGI, int APEEGJFCMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9BC0", Offset = "0x5DA8BC0", VA = "0x185DA9BC0")]
	public IPEndPoint JNEMKKCGGHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5DA95F0", Offset = "0x5DA85F0", VA = "0x185DA95F0")]
	public byte EEILHGNFJNG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA95F0", Offset = "0x5DA85F0", VA = "0x185DA95F0")]
	public sbyte ECNMIMKCIMH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F9C0", Offset = "0x2C8E9C0", VA = "0x182C8F9C0")]
	public T[] NMBFPKONGDL<T>(ushort ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9AD0", Offset = "0x5DA8AD0", VA = "0x185DA9AD0")]
	public bool[] IMJBCLHKLHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9760", Offset = "0x5DA8760", VA = "0x185DA9760")]
	public ushort[] FEAJIGOCGMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA97A0", Offset = "0x5DA87A0", VA = "0x185DA97A0")]
	public short[] FGEEKGBKNLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9450", Offset = "0x5DA8450", VA = "0x185DA9450")]
	public int[] CHFAJNIKLCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9490", Offset = "0x5DA8490", VA = "0x185DA9490")]
	public uint[] DEHOPNFAOOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9B10", Offset = "0x5DA8B10", VA = "0x185DA9B10")]
	public float[] IOBOPMJJIFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9CA0", Offset = "0x5DA8CA0", VA = "0x185DA9CA0")]
	public double[] KNOHPBGADKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DA94D0", Offset = "0x5DA84D0", VA = "0x185DA94D0")]
	public long[] DHODAHNDKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9E00", Offset = "0x5DA8E00", VA = "0x185DA9E00")]
	public ulong[] NNOICNLKFOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9630", Offset = "0x5DA8630", VA = "0x185DA9630")]
	public string[] EJJNCOOOIOI(int IJMDJBPNMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9850", Offset = "0x5DA8850", VA = "0x185DA9850")]
	public bool FMPPONDNAHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9510", Offset = "0x5DA8510", VA = "0x185DA9510")]
	public char DKFAKFNKKAJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9510", Offset = "0x5DA8510", VA = "0x185DA9510")]
	public ushort EOKLPNGOJJM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9EE0", Offset = "0x5DA8EE0", VA = "0x185DA9EE0")]
	public short OOCDEPFFCOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9580", Offset = "0x5DA8580", VA = "0x185DA9580")]
	public long DKOOJMMAHGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9D90", Offset = "0x5DA8D90", VA = "0x185DA9D90")]
	public ulong NFMDAEMFKBJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9F50", Offset = "0x5DA8F50", VA = "0x185DA9F50")]
	public int PNKBNFKILAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA93D0", Offset = "0x5DA83D0", VA = "0x185DA93D0")]
	public uint ADFOPKFLMDA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA97E0", Offset = "0x5DA87E0", VA = "0x185DA97E0")]
	public float FHNBEONOFBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9B50", Offset = "0x5DA8B50", VA = "0x185DA9B50")]
	public double JGIHLHMOOBG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9890", Offset = "0x5DA8890", VA = "0x185DA9890")]
	public string ILIHODLCKBO(int EFEECMADLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9CE0", Offset = "0x5DA8CE0", VA = "0x185DA9CE0")]
	public ArraySegment<byte> LLHOBCODMPO(int JPBPNOCHNLG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9E60", Offset = "0x5DA8E60", VA = "0x185DA9E60")]
	public sbyte[] OCHHMGDJCKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9D50", Offset = "0x5DA8D50", VA = "0x185DA9D50")]
	public byte[] MIEGIILKMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9E40", Offset = "0x5DA8E40", VA = "0x185DA9E40")]
	public void OAIAOCAHOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FHIPOIAMPCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] CDDNPCEBPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int BNDIJLNGDOL;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int BKEECGHOFIC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool CLLNAMBKHIN;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding PNFJGAAALDF;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int FBFMMGBEICD = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] EGKLCEIIEHM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] MEEFJAOGPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5D97610", Offset = "0x5D96610", VA = "0x185D97610")]
	public FHIPOIAMPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5D97690", Offset = "0x5D96690", VA = "0x185D97690")]
	public FHIPOIAMPCO(bool BLPBNODEKLN, int FBDJBCBKPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D97510", Offset = "0x5D96510", VA = "0x185D97510")]
	public static FHIPOIAMPCO OENLPELEHEO(string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D97020", Offset = "0x5D96020", VA = "0x185D97020")]
	public void IPCGCOECNMO(int IACFIIENNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F42810", Offset = "0x1F41810", VA = "0x181F42810")]
	public void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D96AF0", Offset = "0x5D95AF0", VA = "0x185D96AF0")]
	public void FENNLLMCFLA(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5D96B90", Offset = "0x5D95B90", VA = "0x185D96B90")]
	public void FENNLLMCFLA(double CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D96A90", Offset = "0x5D95A90", VA = "0x185D96A90")]
	public void FENNLLMCFLA(long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D96A90", Offset = "0x5D95A90", VA = "0x185D96A90")]
	public void FENNLLMCFLA(ulong CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D96C40", Offset = "0x5D95C40", VA = "0x185D96C40")]
	public void FENNLLMCFLA(int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D96C40", Offset = "0x5D95C40", VA = "0x185D96C40")]
	public void FENNLLMCFLA(uint CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D969C0", Offset = "0x5D959C0", VA = "0x185D969C0")]
	public void FENNLLMCFLA(char CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D969C0", Offset = "0x5D959C0", VA = "0x185D969C0")]
	public void FENNLLMCFLA(ushort CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D969C0", Offset = "0x5D959C0", VA = "0x185D969C0")]
	public void FENNLLMCFLA(short CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D96A30", Offset = "0x5D95A30", VA = "0x185D96A30")]
	public void FENNLLMCFLA(sbyte CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D96A30", Offset = "0x5D95A30", VA = "0x185D96A30")]
	public void FENNLLMCFLA(byte CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D96EE0", Offset = "0x5D95EE0", VA = "0x185D96EE0")]
	public void FENNLLMCFLA(byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D968E0", Offset = "0x5D958E0", VA = "0x185D968E0")]
	public void BCLHPLKAKFB(sbyte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D968E0", Offset = "0x5D958E0", VA = "0x185D968E0")]
	public void IGBHKIEOMBG(byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D96BE0", Offset = "0x5D95BE0", VA = "0x185D96BE0")]
	public void FENNLLMCFLA(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D97360", Offset = "0x5D96360", VA = "0x185D97360")]
	public void NLLGHDPDLGO(Array HGHEGKPMBJK, int NPMMIKNCEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D97280", Offset = "0x5D96280", VA = "0x185D97280")]
	public void NLLGHDPDLGO(float[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D971A0", Offset = "0x5D961A0", VA = "0x185D971A0")]
	public void NLLGHDPDLGO(double[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D971A0", Offset = "0x5D961A0", VA = "0x185D971A0")]
	public void NLLGHDPDLGO(long[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D971A0", Offset = "0x5D961A0", VA = "0x185D971A0")]
	public void NLLGHDPDLGO(ulong[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D97280", Offset = "0x5D96280", VA = "0x185D97280")]
	public void NLLGHDPDLGO(int[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D97280", Offset = "0x5D96280", VA = "0x185D97280")]
	public void NLLGHDPDLGO(uint[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D970C0", Offset = "0x5D960C0", VA = "0x185D970C0")]
	public void NLLGHDPDLGO(ushort[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D970C0", Offset = "0x5D960C0", VA = "0x185D970C0")]
	public void NLLGHDPDLGO(short[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D968E0", Offset = "0x5D958E0", VA = "0x185D968E0")]
	public void NLLGHDPDLGO(bool[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D97440", Offset = "0x5D96440", VA = "0x185D97440")]
	public void NLLGHDPDLGO(string[] CBAEIEAPLIH, int JBKNFKLJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D96F50", Offset = "0x5D95F50", VA = "0x185D96F50")]
	public void FENNLLMCFLA(IPEndPoint LCDHGKCOLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D96AE0", Offset = "0x5D95AE0", VA = "0x185D96AE0")]
	public void FENNLLMCFLA(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D96CD0", Offset = "0x5D95CD0", VA = "0x185D96CD0")]
	public void FENNLLMCFLA(string CBAEIEAPLIH, int EFEECMADLHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IMOEMNIAFHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LPOGLGJGDDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong FDMEMBGGBHO;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x43131F0", Offset = "0x43121F0", VA = "0x1843131F0")]
		static LPOGLGJGDDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void HDCMFDDAHFN(NNMHOFHLBFD DHKLMNOOPAJ, object JLANMLLPCND);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DFDALCMHFKD<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public IMOEMNIAFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public DFDALCMHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x57F8450", Offset = "0x57F7450", VA = "0x1857F8450")]
		internal void OEICBGFEFIP(NNMHOFHLBFD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ANIGBJIHMNM<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public IMOEMNIAFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public ANIGBJIHMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E83760", Offset = "0x3E82760", VA = "0x183E83760")]
		internal void OEICBGFEFIP(NNMHOFHLBFD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NFOJEBCFCII OPOMJOLGMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, HDCMFDDAHFN> DPMGKJNKONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FHIPOIAMPCO AILAPDLNANF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F830", Offset = "0x5D9E830", VA = "0x185D9F830")]
	public IMOEMNIAFHJ(int IJMDJBPNMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x292B2C0", Offset = "0x292A2C0", VA = "0x18292B2C0", Slot = "4")]
	protected virtual ulong CLFMJDPOCEJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F630", Offset = "0x5D9E630", VA = "0x185D9F630", Slot = "5")]
	protected virtual HDCMFDDAHFN IHADALGAAMP(NNMHOFHLBFD DHKLMNOOPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B4E160", Offset = "0x2B4D160", VA = "0x182B4E160", Slot = "6")]
	protected virtual void KAOPFKGEJIN<T>(FHIPOIAMPCO OGONFGJBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F760", Offset = "0x5D9E760", VA = "0x185D9F760")]
	public void KMBMEKKNIJH(NNMHOFHLBFD DHKLMNOOPAJ, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DD30", Offset = "0x2B4CD30", VA = "0x182B4DD30")]
	public void BHGJGDNIHGJ<T>(FHIPOIAMPCO OGONFGJBIBI, T FPDJEKLDODH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F7E0", Offset = "0x5D9E7E0", VA = "0x185D9F7E0")]
	public void PGNFCFOMKHO(NNMHOFHLBFD DHKLMNOOPAJ, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DFA0", Offset = "0x2B4CFA0", VA = "0x182B4DFA0")]
	public void HKDHKBEFFFH<T>(Action<T> GOBHCHEIMNF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2B4DDE0", Offset = "0x2B4CDE0", VA = "0x182B4DDE0")]
	public void HKDHKBEFFFH<T, TUserData>(Action<T, TUserData> GOBHCHEIMNF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NPCBJJLIPMK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA0490", Offset = "0x5D9F490", VA = "0x185DA0490")]
	public NPCBJJLIPMK(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JBJDBLNBDJA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F9B0", Offset = "0x5D9E9B0", VA = "0x185D9F9B0")]
	public JBJDBLNBDJA(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NFOJEBCFCII
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LAPJKLPEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class EKGJPBIFCMM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LAPJKLPEEDE MDBCEFGBENA;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x38503F0", Offset = "0x384F3F0", VA = "0x1838503F0", Slot = "4")]
		public virtual void IPJLDPAJHCH(MethodInfo KJPMCPLMPEB, MethodInfo NJKFKHADMIO, LAPJKLPEEDE PBLNJHEPKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void BPGKPOBDFHK(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PJALKEJNJEF(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		protected EKGJPBIFCMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class OJDLPPJLGBO<TClass, TProperty> : EKGJPBIFCMM<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> NEMHMLOIMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> EIABNFGBDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> BDKHNHFGIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> DHFINFPDCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> INDINJBKPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> KKIGGBLDAHH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x46AF270", Offset = "0x46AE270", VA = "0x1846AF270", Slot = "7")]
		public override void PHDDHLPGBGG(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x46AE470", Offset = "0x46AD470", VA = "0x1846AE470", Slot = "8")]
		public override void JAAHAEMPJFG(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x46A8EC0", Offset = "0x46A7EC0", VA = "0x1846A8EC0", Slot = "9")]
		public override void BPGKPOBDFHK(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x46AFEB0", Offset = "0x46AEEB0", VA = "0x1846AFEB0", Slot = "10")]
		public override void PJALKEJNJEF(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x46A84F0", Offset = "0x46A74F0", VA = "0x1846A84F0")]
		protected TProperty[] AOJFCGIDABE(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x46A9160", Offset = "0x46A8160", VA = "0x1846A9160")]
		protected TProperty[] GAHCFCFGLKJ(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x46AC630", Offset = "0x46AB630", VA = "0x1846AC630", Slot = "4")]
		public override void IPJLDPAJHCH(MethodInfo KJPMCPLMPEB, MethodInfo NJKFKHADMIO, LAPJKLPEEDE PBLNJHEPKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C53240", Offset = "0x3C52240", VA = "0x183C53240")]
		protected OJDLPPJLGBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DLBOOBNKKOK<TClass, TProperty> : OJDLPPJLGBO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OPJGDGPPGBC(NNMHOFHLBFD LJNBPEFJOFE, [Out] TProperty FPNKOEEAPPG);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void LMKHMNLHOPJ(FHIPOIAMPCO FHNDBKCMHNE, TProperty FPNKOEEAPPG);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5857970", Offset = "0x5856970", VA = "0x185857970", Slot = "5")]
		public override void JPBHPDIMEHI(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x58576C0", Offset = "0x58566C0", VA = "0x1858576C0", Slot = "6")]
		public override void BHGJGDNIHGJ(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5857AD0", Offset = "0x5856AD0", VA = "0x185857AD0", Slot = "7")]
		public override void PHDDHLPGBGG(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5857750", Offset = "0x5856750", VA = "0x185857750", Slot = "8")]
		public override void JAAHAEMPJFG(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3856D10", Offset = "0x3855D10", VA = "0x183856D10")]
		protected DLBOOBNKKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class JDBMJGOFBDP<T> : OJDLPPJLGBO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x408A4B0", Offset = "0x40894B0", VA = "0x18408A4B0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x408A440", Offset = "0x4089440", VA = "0x18408A440", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x408A530", Offset = "0x4089530", VA = "0x18408A530", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B40", Offset = "0x3DD5B40", VA = "0x183DD6B40", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public JDBMJGOFBDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OKPGAFEOPFO<T> : OJDLPPJLGBO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x46B7200", Offset = "0x46B6200", VA = "0x1846B7200", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x408A440", Offset = "0x4089440", VA = "0x18408A440", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x46B7280", Offset = "0x46B6280", VA = "0x1846B7280", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B40", Offset = "0x3DD5B40", VA = "0x183DD6B40", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public OKPGAFEOPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FOIEHPDMCLN<T> : OJDLPPJLGBO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BA10", Offset = "0x3C9AA10", VA = "0x183C9BA10", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B930", Offset = "0x3C9A930", VA = "0x183C9B930", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BA90", Offset = "0x3C9AA90", VA = "0x183C9BA90", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B9A0", Offset = "0x3C9A9A0", VA = "0x183C9B9A0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public FOIEHPDMCLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MCHGCOBBDJL<T> : OJDLPPJLGBO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x44D19F0", Offset = "0x44D09F0", VA = "0x1844D19F0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B930", Offset = "0x3C9A930", VA = "0x183C9B930", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x44D1A70", Offset = "0x44D0A70", VA = "0x1844D1A70", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B9A0", Offset = "0x3C9A9A0", VA = "0x183C9B9A0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public MCHGCOBBDJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CEHFBLBMKJN<T> : OJDLPPJLGBO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x50609C0", Offset = "0x505F9C0", VA = "0x1850609C0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x47B0870", Offset = "0x47AF870", VA = "0x1847B0870", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5060A40", Offset = "0x505FA40", VA = "0x185060A40", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x47B08E0", Offset = "0x47AF8E0", VA = "0x1847B08E0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public CEHFBLBMKJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PMJBKLAKJNK<T> : OJDLPPJLGBO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x47B0950", Offset = "0x47AF950", VA = "0x1847B0950", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x47B0870", Offset = "0x47AF870", VA = "0x1847B0870", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x47B09D0", Offset = "0x47AF9D0", VA = "0x1847B09D0", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x47B08E0", Offset = "0x47AF8E0", VA = "0x1847B08E0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public PMJBKLAKJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ALKAGDEOLKF<T> : OJDLPPJLGBO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D77BA0", Offset = "0x3D76BA0", VA = "0x183D77BA0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D77AC0", Offset = "0x3D76AC0", VA = "0x183D77AC0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A1A0", Offset = "0x3E791A0", VA = "0x183E7A1A0", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D77B30", Offset = "0x3D76B30", VA = "0x183D77B30", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public ALKAGDEOLKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AGJKCBHDJBK<T> : OJDLPPJLGBO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D77BA0", Offset = "0x3D76BA0", VA = "0x183D77BA0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D77AC0", Offset = "0x3D76AC0", VA = "0x183D77AC0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D77C20", Offset = "0x3D76C20", VA = "0x183D77C20", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D77B30", Offset = "0x3D76B30", VA = "0x183D77B30", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public AGJKCBHDJBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HEHDOGFAEEJ<T> : OJDLPPJLGBO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6BB0", Offset = "0x3DD5BB0", VA = "0x183DD6BB0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6AD0", Offset = "0x3DD5AD0", VA = "0x183DD6AD0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6C30", Offset = "0x3DD5C30", VA = "0x183DD6C30", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B40", Offset = "0x3DD5B40", VA = "0x183DD6B40", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public HEHDOGFAEEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CFNDCPNEDFO<T> : OJDLPPJLGBO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x51666A0", Offset = "0x51656A0", VA = "0x1851666A0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5166630", Offset = "0x5165630", VA = "0x185166630", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5166720", Offset = "0x5165720", VA = "0x185166720", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x47B08E0", Offset = "0x47AF8E0", VA = "0x1847B08E0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public CFNDCPNEDFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OOPGKPMBCGD<T> : OJDLPPJLGBO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x46CC5B0", Offset = "0x46CB5B0", VA = "0x1846CC5B0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x46CC540", Offset = "0x46CB540", VA = "0x1846CC540", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46CC630", Offset = "0x46CB630", VA = "0x1846CC630", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D77B30", Offset = "0x3D76B30", VA = "0x183D77B30", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BB10", Offset = "0x3C9AB10", VA = "0x183C9BB10")]
		public OOPGKPMBCGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KMPEAODOOAF<T> : DLBOOBNKKOK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x422DEE0", Offset = "0x422CEE0", VA = "0x18422DEE0", Slot = "12")]
		protected override void LMKHMNLHOPJ(FHIPOIAMPCO FHNDBKCMHNE, char FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x422DF10", Offset = "0x422CF10", VA = "0x18422DF10", Slot = "11")]
		protected override void OPJGDGPPGBC(NNMHOFHLBFD LJNBPEFJOFE, [Out] char FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x384A2E0", Offset = "0x38492E0", VA = "0x18384A2E0")]
		public KMPEAODOOAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class EJMHPJGBDAD<T> : DLBOOBNKKOK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x384A270", Offset = "0x3849270", VA = "0x18384A270", Slot = "12")]
		protected override void LMKHMNLHOPJ(FHIPOIAMPCO FHNDBKCMHNE, IPEndPoint FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x384A2A0", Offset = "0x38492A0", VA = "0x18384A2A0", Slot = "11")]
		protected override void OPJGDGPPGBC(NNMHOFHLBFD LJNBPEFJOFE, [Out] IPEndPoint FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x384A2E0", Offset = "0x38492E0", VA = "0x18384A2E0")]
		public EJMHPJGBDAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DDJGEJPOOCB<T> : OJDLPPJLGBO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int JIKPDBPEOOP;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x57F76C0", Offset = "0x57F66C0", VA = "0x1857F76C0")]
		public DDJGEJPOOCB(int EFEECMADLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x57F75C0", Offset = "0x57F65C0", VA = "0x1857F75C0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x57F74C0", Offset = "0x57F64C0", VA = "0x1857F74C0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x57F7640", Offset = "0x57F6640", VA = "0x1857F7640", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x57F7540", Offset = "0x57F6540", VA = "0x1857F7540", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FCDCFIJCCMC<T> : EKGJPBIFCMM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo HBCOLPMCOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type JEALHJEKAKA;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C35540", Offset = "0x3C34540", VA = "0x183C35540")]
		public FCDCFIJCCMC(PropertyInfo PDOOMGNBLHC, Type JDHDMFHKEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C353C0", Offset = "0x3C343C0", VA = "0x183C353C0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C35250", Offset = "0x3C34250", VA = "0x183C35250", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C35480", Offset = "0x3C34480", VA = "0x183C35480", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C35360", Offset = "0x3C34360", VA = "0x183C35360", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C35300", Offset = "0x3C34300", VA = "0x183C35300", Slot = "9")]
		public override void BPGKPOBDFHK(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C354E0", Offset = "0x3C344E0", VA = "0x183C354E0", Slot = "10")]
		public override void PJALKEJNJEF(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MPIJKEEANOD<T> : FCDCFIJCCMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3800EE0", Offset = "0x37FFEE0", VA = "0x183800EE0")]
		public MPIJKEEANOD(PropertyInfo PDOOMGNBLHC, Type JDHDMFHKEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4513380", Offset = "0x4512380", VA = "0x184513380", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x45132D0", Offset = "0x45122D0", VA = "0x1845132D0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MKMILMPIFIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static MKMILMPIFIG<T> IBMHAACFGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly EKGJPBIFCMM<T>[] EPKKEFFHPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int EEHNIBJJGCF;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x44F9240", Offset = "0x44F8240", VA = "0x1844F9240")]
		public MKMILMPIFIG(List<EKGJPBIFCMM<T>> GKNJNIIMAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x44F90E0", Offset = "0x44F80E0", VA = "0x1844F90E0")]
		public void BHGJGDNIHGJ(T HBFCGFKGCAF, FHIPOIAMPCO OGONFGJBIBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x44F9190", Offset = "0x44F8190", VA = "0x1844F9190")]
		public void JPBHPDIMEHI(T HBFCGFKGCAF, NNMHOFHLBFD DHKLMNOOPAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class HBBPLGIHIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract EKGJPBIFCMM<T> BDJJCDMMBKL<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private FHIPOIAMPCO AELHBACGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int CPMFJEMNFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, HBBPLGIHIJL> KFJAAKAGCDN;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8F30", Offset = "0x5DA7F30", VA = "0x185DA8F30")]
	public NFOJEBCFCII(int IJMDJBPNMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C83F50", Offset = "0x2C82F50", VA = "0x182C83F50")]
	private MKMILMPIFIG<T> MGFFLKJNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28C3BE0", Offset = "0x28C2BE0", VA = "0x1828C3BE0")]
	public void PIKNDMFIIPK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C83E20", Offset = "0x2C82E20", VA = "0x182C83E20")]
	public bool JGNOLJBBCJA<T>(NNMHOFHLBFD DHKLMNOOPAJ, T PKMPGPJICGL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C83EC0", Offset = "0x2C82EC0", VA = "0x182C83EC0")]
	public void KLDBPIDHOEH<T>(FHIPOIAMPCO OGONFGJBIBI, T HBFCGFKGCAF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IKMBDLIIODL
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime NCJLAHPJFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] IJMFHKAOEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AKGDOFIOCNL MHGBNCMDANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D9E890", Offset = "0x5D9D890", VA = "0x185D9E890")]
		get
		{
			return default(AKGDOFIOCNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JMMLEFFCNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D9F160", Offset = "0x5D9E160", VA = "0x185D9F160")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D9EF50", Offset = "0x5D9DF50", VA = "0x185D9EF50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CCAIPACHFJO BDHIHHHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D9E230", Offset = "0x5D9D230", VA = "0x185D9E230")]
		get
		{
			return default(CCAIPACHFJO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D9E980", Offset = "0x5D9D980", VA = "0x185D9E980")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GMFHGCIIFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ECA0", Offset = "0x5D9DCA0", VA = "0x185D9ECA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint ECBCOPGNKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ECD0", Offset = "0x5D9DCD0", VA = "0x185D9ECD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? OICOPEHHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D9EF20", Offset = "0x5D9DF20", VA = "0x185D9EF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? EALLBLCNKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D9E460", Offset = "0x5D9D460", VA = "0x185D9E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KIDOOCCMKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D9E490", Offset = "0x5D9D490", VA = "0x185D9E490")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ED50", Offset = "0x5D9DD50", VA = "0x185D9ED50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? BOFMKIGHBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D140", Offset = "0xA8C140", VA = "0x180A8D140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F2A0", Offset = "0x5D9E2A0", VA = "0x185D9F2A0")]
	public IKMBDLIIODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D9F1F0", Offset = "0x5D9E1F0", VA = "0x185D9F1F0")]
	internal IKMBDLIIODL(byte[] JFDEDKFKPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EB80", Offset = "0x5D9DB80", VA = "0x185D9EB80")]
	public static IKMBDLIIODL LEAIFBAEKOO(byte[] JFDEDKFKPOF, DateTime CLCPODPJKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E260", Offset = "0x5D9D260", VA = "0x185D9E260")]
	internal void AJEMCEEFMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EF90", Offset = "0x5D9DF90", VA = "0x185D9EF90")]
	private void PABIIOOGOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E690", Offset = "0x5D9D690", VA = "0x185D9E690")]
	private DateTime? DBDNPJDLMAM(int ANNLKNNLIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E4C0", Offset = "0x5D9D4C0", VA = "0x185D9E4C0")]
	private void DAMCGBJBLDK(int ANNLKNNLIGI, DateTime? CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E9C0", Offset = "0x5D9D9C0", VA = "0x185D9E9C0")]
	private ulong KECGPJBDHIP(int ANNLKNNLIGI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E8C0", Offset = "0x5D9D8C0", VA = "0x185D9E8C0")]
	private void EDHAHCCDHCH(int ANNLKNNLIGI, ulong CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EA90", Offset = "0x5D9DA90", VA = "0x185D9EA90")]
	private uint KGHEGIGPAIJ(int ANNLKNNLIGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5C69710", Offset = "0x5C68710", VA = "0x185C69710")]
	private static uint KMACJGALJJF(uint OOALEDCPNBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EB20", Offset = "0x5D9DB20", VA = "0x185D9EB20")]
	private static ulong KMACJGALJJF(ulong OOALEDCPNBJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum AKGDOFIOCNL
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum CCAIPACHFJO
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class FNKDGJCKHCP
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int GDILDIPCHME = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int NLMPIGAKHOA = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int PCJOMJEJGBG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint DCKHBMNPHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int NACLPIMMLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int KNIPIHDEKKC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OJFJAFHPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D97730", Offset = "0x5D96730", VA = "0x185D97730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D97740", Offset = "0x5D96740", VA = "0x185D97740")]
	public bool JJLBJGACDAA(CDIEIPHKDLN GKIFPCFMELL, int IKBJFKDEOPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class ALFOJENEBME : CDIEIPHKDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket GKIFPCFMELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LFIJFBNOPML EDADOBCCCFL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short JABFIKAHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D943C0", Offset = "0x5D933C0", VA = "0x185D943C0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JFNLLHGILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D93DA0", Offset = "0x5D92DA0", VA = "0x185D93DA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint HKLCNAFFBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D93DC0", Offset = "0x5D92DC0", VA = "0x185D93DC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily JCEINDDOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x42AF5E0", Offset = "0x42AE5E0", VA = "0x1842AF5E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D943E0", Offset = "0x5D933E0", VA = "0x185D943E0")]
	public ALFOJENEBME(AddressFamily FOEFNDNJIKH, LFIJFBNOPML EDADOBCCCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D93DE0", Offset = "0x5D92DE0", VA = "0x185D93DE0", Slot = "8")]
	public bool LMECFMPNDAB(IPEndPoint LCDHGKCOLJK, MOHCKOKGADO JLDCMLDDPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D93C70", Offset = "0x5D92C70", VA = "0x185D93C70", Slot = "9")]
	public int BBKEADJGPKP(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int ENCFHCJIMBE, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D93CB0", Offset = "0x5D92CB0", VA = "0x185D93CB0", Slot = "10")]
	public int DEGKOGJHDPP(byte[] EPBKIHMMALG, EndPoint IPICNGJDAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D943A0", Offset = "0x5D933A0", VA = "0x185D943A0", Slot = "11")]
	public void LPAPGLEBNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface CDIEIPHKDLN
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short JABFIKAHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int JFNLLHGILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint HKLCNAFFBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily JCEINDDOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LMECFMPNDAB(IPEndPoint LCDHGKCOLJK, MOHCKOKGADO JLDCMLDDPID);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int BBKEADJGPKP(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int ENCFHCJIMBE, IPEndPoint EPALFHALBID);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DEGKOGJHDPP(byte[] EPBKIHMMALG, EndPoint EPALFHALBID);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPAPGLEBNBK();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct HAMHCMIEKGP : IEquatable<HAMHCMIEKGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long LMEMIDODFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long KHPEPDEHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long JAJLHKBHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int KDAMAPCMNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int NFHBLMHAOKM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C6A0", Offset = "0x5D9B6A0", VA = "0x185D9C6A0")]
	public HAMHCMIEKGP(byte[] FHOAFCBIOFF, int CAEGCHDJOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x88DC00", Offset = "0x88CC00", VA = "0x18088DC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C660", Offset = "0x5D9B660", VA = "0x185D9C660", Slot = "4")]
	public bool Equals(HAMHCMIEKGP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C5B0", Offset = "0x5D9B5B0", VA = "0x185D9C5B0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class KLBFIOBMDAE : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] PHDLEJBMENG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class KGBCAJKLEKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int ONDOMCJNAOJ;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
	protected KGBCAJKLEKC(int CLPEIFLMGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PNCDIDBOKKN(IPEndPoint LCDHGKCOLJK, byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NJGNIFDLHFI(IPEndPoint LCDHGKCOLJK, byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GLJPJNOIADD : KGBCAJKLEKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private byte[] BHEIPBKEDLG;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator POGNDDGLNOK;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9EB0", Offset = "0x1FE8EB0", VA = "0x181FE9EB0")]
	public GLJPJNOIADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9BB60", Offset = "0x5D9AB60", VA = "0x185D9BB60")]
	public void MJPDOOHJOLK(IPEndPoint LCDHGKCOLJK, byte[] BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5D9BA80", Offset = "0x5D9AA80", VA = "0x185D9BA80")]
	public void LOKCKGMIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C080", Offset = "0x5D9B080", VA = "0x185D9C080", Slot = "4")]
	public override void PNCDIDBOKKN(IPEndPoint LCDHGKCOLJK, byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D9BD10", Offset = "0x5D9AD10", VA = "0x185D9BD10", Slot = "5")]
	public override void NJGNIFDLHFI(IPEndPoint LCDHGKCOLJK, byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct HBKBHAHGEOP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void NPKDPBMHHNE([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class PCFAHJPCGOI
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static IntPtr BPKOLIJJMAN;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static IntPtr MFDPPNGDIKB;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAB50", Offset = "0x5DA9B50", VA = "0x185DAAB50")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA700", Offset = "0x5DA9700", VA = "0x185DAA700")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA860", Offset = "0x5DA9860", VA = "0x185DAA860")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA910", Offset = "0x5DA9910", VA = "0x185DAA910")]
		public unsafe static void NGOOLELHLHP([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private unsafe fixed uint BHEIPBKEDLG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private unsafe fixed uint PACDDAODFBA[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private unsafe fixed uint PNPJBFAPBAL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private unsafe fixed uint HIBICNKCMKG[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private unsafe fixed uint IBFNHAKPAMO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint DLJBODKEDKN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint CJBBBGELDJN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private uint JPDGANKEDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint KPEPPJDBMBI[8];

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CCB0", Offset = "0x5D9BCB0", VA = "0x185D9CCB0")]
	private void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CDA0", Offset = "0x5D9BDA0", VA = "0x185D9CDA0")]
	private uint NHEIKNNJAFC(uint DCMJEJAEEHK, int AHDEPJPJAOA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D93820", Offset = "0x5D92820", VA = "0x185D93820")]
	private void BHACHGDABGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D938D0", Offset = "0x5D928D0", VA = "0x185D938D0")]
	private void HMDFIBADJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D93AE0", Offset = "0x5D92AE0", VA = "0x185D93AE0")]
	private void NPAPDLKEDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D93B70", Offset = "0x5D92B70", VA = "0x185D93B70")]
	private void PBCJHILOKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CF30", Offset = "0x5D9BF30", VA = "0x185D9CF30")]
	private void PKINGDDOMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C890", Offset = "0x5D9B890", VA = "0x185D9C890")]
	private unsafe void AMBLIEBNFNA(byte* CAEOKMPHFAO, uint* BHEIPBKEDLG, uint* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CDD0", Offset = "0x5D9BDD0", VA = "0x185D9CDD0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void PJODEBHCEPE([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CE50", Offset = "0x5D9BE50", VA = "0x185D9CE50")]
	public static void PJODEBHCEPE(Span<byte> CAEOKMPHFAO, Span<byte> BHEIPBKEDLG, Span<byte> PACDDAODFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C790", Offset = "0x5D9B790", VA = "0x185D9C790")]
	public static void AHCNKBGPPNP(Span<byte> CAEOKMPHFAO, Span<byte> BHEIPBKEDLG, Span<byte> PACDDAODFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CD30", Offset = "0x5D9BD30", VA = "0x185D9CD30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void HBIHOPGCGFD([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAC80", Offset = "0x5DA9C80", VA = "0x185DAAC80")]
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
