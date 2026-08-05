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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GKOONABBAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D80300", Offset = "0x5D7E900", VA = "0x185D80300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F860", Offset = "0x5D7DE60", VA = "0x185D7F860")]
		public void RecRoom_SetEncryptionInfo(ulong MFIHOJEMMGC, byte[] BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F840", Offset = "0x5D7DE40", VA = "0x185D7F840")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F710", Offset = "0x5D7DD10", VA = "0x185D7F710")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D80200", Offset = "0x5D7E800", VA = "0x185D80200")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FA00", Offset = "0x5D7E000", VA = "0x185D7FA00", Slot = "6")]
		public override void Send(ulong DEOBIPHBNIF, ArraySegment<byte> FHNKDHIILBL, NetworkDelivery IKNJBDGBLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F800", Offset = "0x5D7DE00", VA = "0x185D7F800", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DEOBIPHBNIF, [Out] ArraySegment<byte> HJCJCIIFPJE, [Out] float MCFMKMILGCG)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FCF0", Offset = "0x5D7E2F0", VA = "0x185D7FCF0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D80120", Offset = "0x5D7E720", VA = "0x185D80120", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EDD0", Offset = "0x5D7D3D0", VA = "0x185D7EDD0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DEOBIPHBNIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EC80", Offset = "0x5D7D280", VA = "0x185D7EC80", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F080", Offset = "0x5D7D680", VA = "0x185D7F080", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DEOBIPHBNIF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FC80", Offset = "0x5D7E280", VA = "0x185D7FC80", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F1E0", Offset = "0x5D7D7E0", VA = "0x185D7F1E0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FKNKLINCDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F640", Offset = "0x5D7DC40", VA = "0x185D7F640")]
		private ONLPMAFDLEL NOIACMBIAHL(NetworkDelivery PBLNJHEPKAE)
		{
			return default(ONLPMAFDLEL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F120", Offset = "0x5D7D720", VA = "0x185D7F120", Slot = "15")]
		private void IGJHJOJAHKP(GJJNOHJMHJD KGOCIKCGPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EF40", Offset = "0x5D7D540", VA = "0x185D7EF40", Slot = "16")]
		private void ENJIFBAEJOJ(GJJNOHJMHJD KGOCIKCGPIB, IPEPGCGBEOP OGCOHBKGJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "17")]
		private void GPJKDKFCDDO(IPEndPoint LCDHGKCOLJK, SocketError LAOJGCLBJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F3D0", Offset = "0x5D7D9D0", VA = "0x185D7F3D0", Slot = "18")]
		private void KIFIJJGKCDK(GJJNOHJMHJD KGOCIKCGPIB, EJFPGFCOCFL DHKLMNOOPAJ, byte MGENKCBPEBA, ONLPMAFDLEL MFCIKGBDNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EB80", Offset = "0x5D7D180", VA = "0x185D7EB80")]
		private void CNHEGOGBOEP(int ENCFHCJIMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "19")]
		private void POEEJHBBOHK(IPEndPoint EPALFHALBID, EJFPGFCOCFL DHKLMNOOPAJ, FKAGJILHNOD IPGIPDPIAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "20")]
		private void EMAFABICDNO(GJJNOHJMHJD KGOCIKCGPIB, int PKPMCCEMAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F5E0", Offset = "0x5D7DBE0", VA = "0x185D7F5E0", Slot = "21")]
		private void MAGDMDKIKFL(HCBIFCAIDKM BDMHFDNBPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F3A0", Offset = "0x5D7D9A0", VA = "0x185D7F3A0")]
		private ulong JFLGNJAKEJJ(GJJNOHJMHJD KGOCIKCGPIB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EC60", Offset = "0x5D7D260", VA = "0x185D7EC60")]
		private static int DNABFKGPIBK(float PJKHGIHPBDF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D80220", Offset = "0x5D7E820", VA = "0x185D80220")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D7EAE0", Offset = "0x5D7D0E0", VA = "0x185D7EAE0")]
	protected LMJOMFIMDAA(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EA80", Offset = "0x5D7D080", VA = "0x185D7EA80")]
	public void IEOIENOKJFM(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EA00", Offset = "0x5D7D000", VA = "0x185D7EA00")]
	protected void HJPMJOBKFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E9C0", Offset = "0x5D7CFC0", VA = "0x185D7E9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88AC00", Offset = "0x889200", VA = "0x18088AC00")]
		[CompilerGenerated]
		get
		{
			return default(MPJCPAMIBBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xADEB50", Offset = "0xADD150", VA = "0x180ADEB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D74410", Offset = "0x5D72A10", VA = "0x185D74410")]
	internal void OCMPGEMGNPA(CFJNGMMFNAF IDIALFHOGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D743E0", Offset = "0x5D729E0", VA = "0x185D743E0")]
	private bool LGOGJJDLHGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D74470", Offset = "0x5D72A70", VA = "0x185D74470")]
	internal HCBIFCAIDKM(IPEndPoint EPALFHALBID, CFJNGMMFNAF OFELNAOKDAB, LFIJFBNOPML FFNFEBMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D74380", Offset = "0x5D72980", VA = "0x185D74380")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6C6C0", Offset = "0x5D6ACC0", VA = "0x185D6C6C0")]
	private CFJNGMMFNAF(long HANIAMFLBLK, byte OMPPAAIJGLJ, int OJMEEMCEEJO, byte[] IOEJNIALNND, NNMHOFHLBFD FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C660", Offset = "0x5D6AC60", VA = "0x185D6C660")]
	public static int MLGKMKFJDCC(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C440", Offset = "0x5D6AA40", VA = "0x185D6C440")]
	public static CFJNGMMFNAF JNPKBMOLAOA(JICHPBPHCPJ FPDJEKLDODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C260", Offset = "0x5D6A860", VA = "0x185D6C260")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6C130", Offset = "0x5D6A730", VA = "0x185D6C130")]
	private BEJALNCKEJH(long HANIAMFLBLK, byte OMPPAAIJGLJ, int IOFGOGLLBEB, bool DEKHJJKPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BEE0", Offset = "0x5D6A4E0", VA = "0x185D6BEE0")]
	public static BEJALNCKEJH JNPKBMOLAOA(JICHPBPHCPJ FPDJEKLDODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BDF0", Offset = "0x5D6A3F0", VA = "0x185D6BDF0")]
	public static JICHPBPHCPJ BCLOGDKNCHM(long EAEGDDFGMOP, byte MKKPMEDNOEG, int BACIKEKFGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C030", Offset = "0x5D6A630", VA = "0x185D6C030")]
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
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
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
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EDIMCBJAPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x92FCA0", Offset = "0x92E2A0", VA = "0x18092FCA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x870440", Offset = "0x86EA40", VA = "0x180870440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6CD20", Offset = "0x5D6B320", VA = "0x185D6CD20")]
	internal CMPOFBNFMKN(LFIJFBNOPML GKIFPCFMELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C730", Offset = "0x5D6AD30", VA = "0x185D6C730")]
	internal void CBCIOJLEOJO(IPEndPoint GPNENHDLNJB, JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x292F670", Offset = "0x292DC70", VA = "0x18292F670")]
	private void JJLBJGACDAA<T>(T FPDJEKLDODH, IPEndPoint PKMPGPJICGL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C890", Offset = "0x5D6AE90", VA = "0x185D6C890")]
	private void FNOEPBKNDON(GCDCMCBMCOO PGAFBDKJIFH, IPEndPoint GPNENHDLNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D6CA20", Offset = "0x5D6B020", VA = "0x185D6CA20")]
	private void IAMELBBMPFP(PJGIEBKBAMC PGAFBDKJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D6CB80", Offset = "0x5D6B180", VA = "0x185D6CB80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D77880", Offset = "0x5D75E80", VA = "0x185D77880")]
	public KMPCCGNLMPM(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LCBHAADFFCI : KMPCCGNLMPM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D77880", Offset = "0x5D75E80", VA = "0x185D77880")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D803C0", Offset = "0x5D7E9C0", VA = "0x185D803C0")]
	private static void DACKKJPMHBI(DKNKKCEEGAK GFGIBKKAOHD, string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D80650", Offset = "0x5D7EC50", VA = "0x185D80650")]
	internal static void MIHDDBJAPFJ(string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D806B0", Offset = "0x5D7ECB0", VA = "0x185D806B0")]
	internal static void OMLNBGDCIBO(string KIBGJLLHGOJ, params object[] NENLABMEOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D805F0", Offset = "0x5D7EBF0", VA = "0x185D805F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6DC80", Offset = "0x5D6C280", VA = "0x185D6DC80")]
	internal EJFPGFCOCFL(LFIJFBNOPML MFNJBGPIIEN, IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DC10", Offset = "0x5D6C210", VA = "0x185D6DC10")]
	internal void OJMPAENKOFP(JICHPBPHCPJ FPDJEKLDODH, int OGBDMBHBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DB60", Offset = "0x5D6C160", VA = "0x185D6DB60")]
	internal void GEMCHGNIDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DBE0", Offset = "0x5D6C1E0", VA = "0x185D6DBE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D75580", Offset = "0x5D73B80", VA = "0x185D75580")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D769B0", Offset = "0x5D74FB0", VA = "0x185D769B0", Slot = "4")]
		public bool Equals(IPEndPoint OOALEDCPNBJ, IPEndPoint HDFOCKKCOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x584B940", Offset = "0x5849F40", VA = "0x18584B940", Slot = "5")]
		public int GetHashCode(IPEndPoint HBFCGFKGCAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D2170", Offset = "0x8D0770", VA = "0x1808D2170", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D2170", Offset = "0x8D0770", VA = "0x1808D2170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10DCA20", Offset = "0x10DB020", VA = "0x1810DCA20")]
		public GEAENLCPLOB(GJJNOHJMHJD EBPGHIDCOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EC20", Offset = "0x5D6D220", VA = "0x185D6EC20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EC70", Offset = "0x5D6D270", VA = "0x185D6EC70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xBDBB70", Offset = "0xBDA170", VA = "0x180BDBB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC8B210", Offset = "0xC89810", VA = "0x180C8B210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DJDBMGEOBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14DCF00", Offset = "0x14DB500", VA = "0x1814DCF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1802D30", Offset = "0x1801330", VA = "0x181802D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ANDEEMEMLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA44F70", Offset = "0xA43570", VA = "0x180A44F70")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ONDOMCJNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B320", Offset = "0x5D79920", VA = "0x185D7B320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short JABFIKAHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E0D0", Offset = "0x5D7C6D0", VA = "0x185D7E0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B940", Offset = "0x5D79F40", VA = "0x185D7B940")]
	public void MACAHMMOAAM(IPEndPoint LCDHGKCOLJK, byte[] BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AC40", Offset = "0x5D79240", VA = "0x185D7AC40")]
	public void KOIAFCACCEC(IPEndPoint LCDHGKCOLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D78C10", Offset = "0x5D77210", VA = "0x185D78C10")]
	private bool CCJIDNGMCKB(IPEndPoint LCDHGKCOLJK, [Out] GJJNOHJMHJD KGOCIKCGPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BDC0", Offset = "0x5D7A3C0", VA = "0x185D7BDC0")]
	private void MOLBMEBMIEO(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D79A50", Offset = "0x5D78050", VA = "0x185D79A50")]
	private void GBPOCCPBLDE(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A100", Offset = "0x5D78700", VA = "0x185D7A100")]
	private void HKHMNJFOEMJ(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E370", Offset = "0x5D7C970", VA = "0x185D7E370")]
	public LFIJFBNOPML(NMBHJBCIKOO FFNFEBMFPGM, [Optional] KGBCAJKLEKC CNEOEMMBFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D78BC0", Offset = "0x5D771C0", VA = "0x185D78BC0")]
	internal void BPMMHNCNGPG(GJJNOHJMHJD PKEPMOGPMJK, int PKPMCCEMAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D77BF0", Offset = "0x5D761F0", VA = "0x185D77BF0")]
	internal void AIJPJCAKALN(GJJNOHJMHJD PKEPMOGPMJK, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79010", Offset = "0x5D77610", VA = "0x185D79010")]
	internal void EHMKCAMNKEL(GJJNOHJMHJD KGOCIKCGPIB, BPBJDHGLKFK CLPBFEAPBCA, SocketError PPBCMFHDHJD, JICHPBPHCPJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D950", Offset = "0x5D7BF50", VA = "0x185D7D950")]
	private void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB, BPBJDHGLKFK CLPBFEAPBCA, SocketError PPBCMFHDHJD, bool BAKDLGCFEEB, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG, JICHPBPHCPJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79140", Offset = "0x5D77740", VA = "0x185D79140")]
	private void EODANKEBFDF(IFBEODGHCBF.CJFAJMANKHM PBLNJHEPKAE, [Optional] GJJNOHJMHJD KGOCIKCGPIB, [Optional] IPEndPoint EPALFHALBID, SocketError NIEIPBDODCM = SocketError.Success, int PKPMCCEMAFA = 0, BPBJDHGLKFK FMGPPMEOPCB = BPBJDHGLKFK.ConnectionFailed, [Optional] HCBIFCAIDKM LIGMAJIGLEC, ONLPMAFDLEL MFCIKGBDNHP = ONLPMAFDLEL.Unreliable, byte MGENKCBPEBA = 0, [Optional] JICHPBPHCPJ NLDBPMPJNFN, [Optional] object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C160", Offset = "0x5D7A760", VA = "0x185D7C160")]
	private void OABHEPOLHHD(IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B90", Offset = "0x5D78190", VA = "0x185D79B90")]
	internal void GLIABFEJOAA(IFBEODGHCBF DJLOOOABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A900", Offset = "0x5D78F00", VA = "0x185D7A900")]
	private void KNKFNCNBCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D79730", Offset = "0x5D77D30", VA = "0x185D79730")]
	private void GBPKBNGNKBA(int FANCJOIFAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DAB0", Offset = "0x5D7C0B0", VA = "0x185D7DAB0")]
	internal GJJNOHJMHJD PLEALMBFGNB(HCBIFCAIDKM BDMHFDNBPPE, byte[] BICMBICIBOO, int ODFMKGCLIGE, int DOIKAIEGGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DA30", Offset = "0x5D7C030", VA = "0x185D7DA30")]
	private int PJAMOMGPDPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D77C40", Offset = "0x5D76240", VA = "0x185D77C40")]
	private void BFKBALMJCJD(IPEndPoint EPALFHALBID, GJJNOHJMHJD MLOHIKMHOEC, CFJNGMMFNAF MPCJPLJMLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C920", Offset = "0x5D7AF20", VA = "0x185D7C920")]
	private void OEIIAKNCLPC(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D780A0", Offset = "0x5D766A0", VA = "0x185D780A0")]
	internal void BGKHMAKHJED(JICHPBPHCPJ FPDJEKLDODH, ONLPMAFDLEL HENFOAJPMCO, byte MGENKCBPEBA, int OGBDMBHBCCC, GJJNOHJMHJD PKEPMOGPMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D78380", Offset = "0x5D76980", VA = "0x185D78380")]
	public bool BKDEJNGAEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D78360", Offset = "0x5D76960", VA = "0x185D78360")]
	public bool BKDEJNGAEPP(IPAddress HBCNFILNODA, IPAddress PBMGBFLNOGP, int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D78B40", Offset = "0x5D77140", VA = "0x185D78B40")]
	public bool BKDEJNGAEPP(int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D79C90", Offset = "0x5D78290", VA = "0x185D79C90")]
	public void HCJDLNCKALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B240", Offset = "0x5D79840", VA = "0x185D7B240")]
	public GJJNOHJMHJD KPKNGIBLEHL(string FHOAFCBIOFF, int JCEBAOIBEAD, string BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AD90", Offset = "0x5D79390", VA = "0x185D7AD90")]
	public GJJNOHJMHJD KPKNGIBLEHL(string FHOAFCBIOFF, int JCEBAOIBEAD, FHIPOIAMPCO PEODDADPNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AE70", Offset = "0x5D79470", VA = "0x185D7AE70")]
	public GJJNOHJMHJD KPKNGIBLEHL(IPEndPoint PKMPGPJICGL, FHIPOIAMPCO PEODDADPNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D77BE0", Offset = "0x5D761E0", VA = "0x185D77BE0")]
	public void AAKANIGBLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D77890", Offset = "0x5D75E90", VA = "0x185D77890")]
	public void AAKANIGBLDP(bool NEMHLKJFNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A6E0", Offset = "0x5D78CE0", VA = "0x185D7A6E0")]
	public void JBADKAJNBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A7E0", Offset = "0x5D78DE0", VA = "0x185D7A7E0")]
	public void JBADKAJNBMK(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D8A0", Offset = "0x5D7BEA0", VA = "0x185D7D8A0")]
	public void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D7E0", Offset = "0x5D7BDE0", VA = "0x185D7D7E0")]
	public void OPBNLJMABKD(GJJNOHJMHJD KGOCIKCGPIB, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E190", Offset = "0x5D7C790", VA = "0x185D7E190", Slot = "4")]
	private IEnumerator<GJJNOHJMHJD> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E220", Offset = "0x5D7C820", VA = "0x185D7E220", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D78E40", Offset = "0x5D77440", VA = "0x185D78E40")]
	private JICHPBPHCPJ EEPFNGCHEFD(OHGHPKPFANP PDOOMGNBLHC, int ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D78F30", Offset = "0x5D77530", VA = "0x185D78F30")]
	private JICHPBPHCPJ EEPFNGCHEFD(OHGHPKPFANP PDOOMGNBLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79500", Offset = "0x5D77B00", VA = "0x185D79500")]
	internal JICHPBPHCPJ FNALCEKNAOM(int ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BB60", Offset = "0x5D7A160", VA = "0x185D7BB60")]
	internal void MJADMCMKELH(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E2B0", Offset = "0x5D7C8B0", VA = "0x185D7E2B0")]
	static LFIJFBNOPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBDBB70", Offset = "0xBDA170", VA = "0x180BDBB70")]
	private bool CJMHCJFHMME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79AA0", Offset = "0x5D780A0", VA = "0x185D79AA0")]
	private void GFIFBGILIPP(IPEndPoint CLAGGHDFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C080", Offset = "0x5D7A680", VA = "0x185D7C080")]
	private void NBCNFJODPDO(IPEndPoint CLAGGHDFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D78CA0", Offset = "0x5D772A0", VA = "0x185D78CA0")]
	private bool DEONAAENOME(SocketException CNGGKHFOGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D79E30", Offset = "0x5D78430", VA = "0x185D79E30")]
	private void HFAMHCBELAA(CDIEIPHKDLN GKIFPCFMELL, EndPoint LJBJJIDMEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A350", Offset = "0x5D78950", VA = "0x185D7A350")]
	private void IIPJKPCKEED(object NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D78390", Offset = "0x5D76990", VA = "0x185D78390")]
	public bool BKDEJNGAEPP(IPAddress HBCNFILNODA, IPAddress PBMGBFLNOGP, int JCEBAOIBEAD, bool LANKGDIMONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D790E0", Offset = "0x5D776E0", VA = "0x185D790E0")]
	internal int EKKJDDCBHCO(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B900", Offset = "0x5D79F00", VA = "0x185D7B900")]
	internal int LKLPLKPHKDK(JICHPBPHCPJ FPDJEKLDODH, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B340", Offset = "0x5D79940", VA = "0x185D7B340")]
	internal int LKLPLKPHKDK(byte[] NFOHONOFFAP, int ODFMKGCLIGE, int DOIKAIEGGLD, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D670", Offset = "0x5D7BC70", VA = "0x185D7D670")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D77260", Offset = "0x5D75860", VA = "0x185D77260")]
		get
		{
			return default(OHGHPKPFANP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D77370", Offset = "0x5D75970", VA = "0x185D77370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AIJGDFMHNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D77130", Offset = "0x5D75730", VA = "0x185D77130")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D773B0", Offset = "0x5D759B0", VA = "0x185D773B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort IEJLPCIEMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D76E00", Offset = "0x5D75400", VA = "0x185D76E00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D76F50", Offset = "0x5D75550", VA = "0x185D76F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CKLBAICIECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D76FD0", Offset = "0x5D755D0", VA = "0x185D76FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte AKLFMBMKGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D773F0", Offset = "0x5D759F0", VA = "0x185D773F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D77100", Offset = "0x5D75700", VA = "0x185D77100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LIMOEONGIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D76EF0", Offset = "0x5D754F0", VA = "0x185D76EF0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D76F90", Offset = "0x5D75590", VA = "0x185D76F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort BPDNJGGNBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D76E60", Offset = "0x5D75460", VA = "0x185D76E60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D772D0", Offset = "0x5D758D0", VA = "0x185D772D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort NLJIMJEOKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D77310", Offset = "0x5D75910", VA = "0x185D77310")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D77290", Offset = "0x5D75890", VA = "0x185D77290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D77420", Offset = "0x5D75A20", VA = "0x185D77420")]
	static JICHPBPHCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D76EC0", Offset = "0x5D754C0", VA = "0x185D76EC0")]
	public void BKLEHGECOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D77810", Offset = "0x5D75E10", VA = "0x185D77810")]
	public JICHPBPHCPJ(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D77700", Offset = "0x5D75D00", VA = "0x185D77700")]
	public JICHPBPHCPJ(OHGHPKPFANP PDOOMGNBLHC, int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D77160", Offset = "0x5D75760", VA = "0x185D77160")]
	public static int HPIOFFHFNFM(OHGHPKPFANP PDOOMGNBLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D771D0", Offset = "0x5D757D0", VA = "0x185D771D0")]
	public int HPIOFFHFNFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D77000", Offset = "0x5D75600", VA = "0x185D77000")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
		[Cpp2IlInjected.Address(RVA = "0xC1F080", Offset = "0xC1D680", VA = "0x180C1F080")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D70E40", Offset = "0x5D6F440", VA = "0x185D70E40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint HMIBJCFHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1D0", Offset = "0x8CD7D0", VA = "0x1808CF1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public IFENKPNKJAG EOHEKNOANHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x13144E0", Offset = "0x1312AE0", VA = "0x1813144E0")]
		get
		{
			return default(IFENKPNKJAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long PHKEIFGLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86F660", Offset = "0x86DC60", VA = "0x18086F660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HHNCAPOBIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCEE760", Offset = "0xCECD60", VA = "0x180CEE760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15DB540", Offset = "0x15D9B40", VA = "0x1815DB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int INMKFNGPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D71C50", Offset = "0x5D70250", VA = "0x185D71C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DOLOICAIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8723F0", Offset = "0x8709F0", VA = "0x1808723F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double GFNCDHJOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CE70", Offset = "0x1A5B470", VA = "0x181A5CE70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JLPOPDCPIPA BLMGHPILEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D71C60", Offset = "0x5D70260", VA = "0x185D71C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EFD0", Offset = "0x5D6D5D0", VA = "0x185D6EFD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D726A0", Offset = "0x5D70CA0", VA = "0x185D726A0")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, IPEndPoint EPALFHALBID, int BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D70CF0", Offset = "0x5D6F2F0", VA = "0x185D70CF0")]
	internal void MBNNEJHCHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D70D10", Offset = "0x5D6F310", VA = "0x185D70D10")]
	internal void MODEJJONMDO(IPEndPoint BFMGPKEKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F410", Offset = "0x5D6DA10", VA = "0x185D6F410")]
	internal void CMECJBNCNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D70550", Offset = "0x5D6EB50", VA = "0x185D70550")]
	private void KJHNADNLFPF(int JJBCOOHCLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D70EF0", Offset = "0x5D6F4F0", VA = "0x185D70EF0")]
	private void OBHENMLGFDC(int MCGCKADFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EE20", Offset = "0x5D6D420", VA = "0x185D6EE20")]
	private LMJOMFIMDAA AAHCABHNCIM(byte JPMDPHGDIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D72CE0", Offset = "0x5D712E0", VA = "0x185D72CE0")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, IPEndPoint EPALFHALBID, int BLCJLIJFBDL, byte MKKPMEDNOEG, FHIPOIAMPCO CHKPPDBFDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D72B00", Offset = "0x5D71100", VA = "0x185D72B00")]
	internal GJJNOHJMHJD(LFIJFBNOPML EDADOBCCCFL, HCBIFCAIDKM BDMHFDNBPPE, int BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D70D40", Offset = "0x5D6F340", VA = "0x185D70D40")]
	internal void NACDBEPMCDH(CFJNGMMFNAF PPEMCBLGBJK, byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FE10", Offset = "0x5D6E410", VA = "0x185D6FE10")]
	internal bool GIHCFIHPCKN(BEJALNCKEJH FPDJEKLDODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D70520", Offset = "0x5D6EB20", VA = "0x185D70520")]
	public void JJLBJGACDAA(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, ONLPMAFDLEL HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D71700", Offset = "0x5D6FD00", VA = "0x185D71700")]
	private void PFELOOIOBPH(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, byte MGENKCBPEBA, ONLPMAFDLEL MFCIKGBDNHP, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D70D90", Offset = "0x5D6F390", VA = "0x185D70D90")]
	public void NAHHOKAIFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FE90", Offset = "0x5D6E490", VA = "0x185D6FE90")]
	internal EIGPLHMDAGA HPGLAALGIBE(JICHPBPHCPJ FPDJEKLDODH)
	{
		return default(EIGPLHMDAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FF70", Offset = "0x5D6E570", VA = "0x185D6FF70")]
	internal void ICIGPCBBFIP(LMJOMFIMDAA FAJHEEIDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D709E0", Offset = "0x5D6EFE0", VA = "0x185D709E0")]
	internal FCLJIMPCIJN LLEEPCOAPIE(byte[] FHNKDHIILBL, int ODFMKGCLIGE, int DOIKAIEGGLD, bool BAKDLGCFEEB)
	{
		return default(FCLJIMPCIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D709A0", Offset = "0x5D6EFA0", VA = "0x185D709A0")]
	private void LFMAGHJNHEK(int NHFDPKDEEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D71D10", Offset = "0x5D70310", VA = "0x185D71D10")]
	internal void PPKALHECEDD(ONLPMAFDLEL HENFOAJPMCO, JICHPBPHCPJ EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FFD0", Offset = "0x5D6E5D0", VA = "0x185D6FFD0")]
	private void JCAAPBGNIIC(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D70620", Offset = "0x5D6EC20", VA = "0x185D70620")]
	private void LDEHBKEAMLO(int DGOHALMDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F080", Offset = "0x5D6D680", VA = "0x185D6F080")]
	internal CKCJFLIKINK BFKBALMJCJD(CFJNGMMFNAF MPCJPLJMLEG)
	{
		return default(CKCJFLIKINK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F760", Offset = "0x5D6DD60", VA = "0x185D6F760")]
	internal void FIKHNCAGBLE(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D715E0", Offset = "0x5D6FBE0", VA = "0x185D715E0")]
	private void PCFNOGHFOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F240", Offset = "0x5D6D840", VA = "0x185D6F240")]
	internal void BPDDHIKPMAA(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D70F30", Offset = "0x5D6F530", VA = "0x185D70F30")]
	internal void OMKLHJHPBJI(int DGOHALMDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F4A0", Offset = "0x5D6DAA0", VA = "0x185D6F4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D81650", Offset = "0x5D7FC50", VA = "0x185D81650")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EIDILKPOFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D81440", Offset = "0x5D7FA40", VA = "0x185D81440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PGDPPIBIOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D81540", Offset = "0x5D7FB40", VA = "0x185D81540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DDIHIBLBMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D81630", Offset = "0x5D7FC30", VA = "0x185D81630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AKFPOGMNGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D81670", Offset = "0x5D7FC70", VA = "0x185D81670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CLGGHGEIDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D81660", Offset = "0x5D7FC60", VA = "0x185D81660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DEBDAFBHIIF AELILFKMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D81620", Offset = "0x5D7FC20", VA = "0x185D81620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double IANHMAGNDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D81560", Offset = "0x5D7FB60", VA = "0x185D81560")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D815C0", Offset = "0x5D7FBC0", VA = "0x185D815C0")]
	public void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D81410", Offset = "0x5D7FA10", VA = "0x185D81410")]
	public void AFOIKDCGEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D81640", Offset = "0x5D7FC40", VA = "0x185D81640")]
	public void IBNGNIKABAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D81490", Offset = "0x5D7FA90", VA = "0x185D81490")]
	public void BBMHIALFIPE(long DJPBLJMFLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D81550", Offset = "0x5D7FB50", VA = "0x185D81550")]
	public void COJIGMCEMLL(long NAFDJBHIEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D81680", Offset = "0x5D7FC80", VA = "0x185D81680")]
	public void LFMKJGOIPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D81450", Offset = "0x5D7FA50", VA = "0x185D81450")]
	public void BANMMOLHEPL(long DBBIJBFGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D816B0", Offset = "0x5D7FCB0", VA = "0x185D816B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D814A0", Offset = "0x5D7FAA0", VA = "0x185D814A0")]
	public void BDBEOJILAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6B880", Offset = "0x5D69E80", VA = "0x185D6B880")]
	public static IPEndPoint FEPDDLIJCGD(string DOMGNDPKIOI, int JCEBAOIBEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BB90", Offset = "0x5D6A190", VA = "0x185D6BB90")]
	public static IPAddress NHOBLIEFHCA(string DOMGNDPKIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BB00", Offset = "0x5D6A100", VA = "0x185D6BB00")]
	public static IPAddress NHOBLIEFHCA(string DOMGNDPKIOI, AddressFamily FOEFNDNJIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BAD0", Offset = "0x5D6A0D0", VA = "0x185D6BAD0")]
	internal static int HHIKGIKLFCE(int BJENHFKIEMM, int MODONOEGFJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x31A62E0", Offset = "0x31A48E0", VA = "0x1831A62E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D6D250", Offset = "0x5D6B850", VA = "0x185D6D250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D1E0", Offset = "0x5D6B7E0", VA = "0x185D6D1E0")]
		public void IPJLDPAJHCH(JICHPBPHCPJ FPDJEKLDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D170", Offset = "0x5D6B770", VA = "0x185D6D170")]
		public bool HPCMHFHMIBC(long AAEDJKLCPHK, GJJNOHJMHJD KGOCIKCGPIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D200", Offset = "0x5D6B800", VA = "0x185D6D200")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D753B0", Offset = "0x5D739B0", VA = "0x185D753B0")]
	public HPOGIEBELNB(GJJNOHJMHJD KGOCIKCGPIB, bool CBNMEHHCHCO, byte BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D74FF0", Offset = "0x5D735F0", VA = "0x185D74FF0")]
	private void NCDOJPNDEIO(JICHPBPHCPJ FPDJEKLDODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D744E0", Offset = "0x5D72AE0", VA = "0x185D744E0", Slot = "4")]
	protected override bool CEJNEFCJAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D74990", Offset = "0x5D72F90", VA = "0x185D74990", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6DAA0", Offset = "0x5D6C0A0", VA = "0x185D6DAA0")]
	public DKDNLNKNHEN(GJJNOHJMHJD KGOCIKCGPIB, bool NLOGBFFANAN, byte BLCJLIJFBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D6D2F0", Offset = "0x5D6B8F0", VA = "0x185D6D2F0", Slot = "4")]
	protected override bool CEJNEFCJAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D6D790", Offset = "0x5D6BD90", VA = "0x185D6D790", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D6AB20", Offset = "0x5D69120", VA = "0x185D6AB20")]
	private static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, ulong FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ED00", Offset = "0x5D6D300", VA = "0x185D6ED00")]
	private static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ECC0", Offset = "0x5D6D2C0", VA = "0x185D6ECC0")]
	public static void PIHKDDFBAAG(byte[] EPBKIHMMALG, int ANNLKNNLIGI, short FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EDF0", Offset = "0x5D6D3F0", VA = "0x185D6EDF0")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, double CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ED70", Offset = "0x5D6D370", VA = "0x185D6ED70")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ECC0", Offset = "0x5D6D2C0", VA = "0x185D6ECC0")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, short CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ECC0", Offset = "0x5D6D2C0", VA = "0x185D6ECC0")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, ushort CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ED00", Offset = "0x5D6D300", VA = "0x185D6ED00")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ED00", Offset = "0x5D6D300", VA = "0x185D6ED00")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, uint CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EE10", Offset = "0x5D6D410", VA = "0x185D6EE10")]
	public static void FLMNMFLFAKE(byte[] JFDEDKFKPOF, int GEIGDPFELPO, long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EE10", Offset = "0x5D6D410", VA = "0x185D6EE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int PBPODOLIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CAPBDPELJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D80830", Offset = "0x5D7EE30", VA = "0x185D80830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KCHDCGEDEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EBB140", Offset = "0x1EB9740", VA = "0x181EBB140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KOCNONLLNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D81080", Offset = "0x5D7F680", VA = "0x185D81080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D81290", Offset = "0x5D7F890", VA = "0x185D81290")]
	public void OJMPAENKOFP(byte[] CHNGFEKJHON, int ANNLKNNLIGI, int APEEGJFCMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public NNMHOFHLBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D813B0", Offset = "0x5D7F9B0", VA = "0x185D813B0")]
	public NNMHOFHLBFD(byte[] CHNGFEKJHON, int ANNLKNNLIGI, int APEEGJFCMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D80FB0", Offset = "0x5D7F5B0", VA = "0x185D80FB0")]
	public IPEndPoint JNEMKKCGGHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D809E0", Offset = "0x5D7EFE0", VA = "0x185D809E0")]
	public byte EEILHGNFJNG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D809E0", Offset = "0x5D7EFE0", VA = "0x185D809E0")]
	public sbyte ECNMIMKCIMH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2C76550", Offset = "0x2C74B50", VA = "0x182C76550")]
	public T[] NMBFPKONGDL<T>(ushort ENCFHCJIMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D80EC0", Offset = "0x5D7F4C0", VA = "0x185D80EC0")]
	public bool[] IMJBCLHKLHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D80B50", Offset = "0x5D7F150", VA = "0x185D80B50")]
	public ushort[] FEAJIGOCGMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D80B90", Offset = "0x5D7F190", VA = "0x185D80B90")]
	public short[] FGEEKGBKNLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D80840", Offset = "0x5D7EE40", VA = "0x185D80840")]
	public int[] CHFAJNIKLCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D80880", Offset = "0x5D7EE80", VA = "0x185D80880")]
	public uint[] DEHOPNFAOOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D80F00", Offset = "0x5D7F500", VA = "0x185D80F00")]
	public float[] IOBOPMJJIFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D81090", Offset = "0x5D7F690", VA = "0x185D81090")]
	public double[] KNOHPBGADKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D808C0", Offset = "0x5D7EEC0", VA = "0x185D808C0")]
	public long[] DHODAHNDKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D811F0", Offset = "0x5D7F7F0", VA = "0x185D811F0")]
	public ulong[] NNOICNLKFOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D80A20", Offset = "0x5D7F020", VA = "0x185D80A20")]
	public string[] EJJNCOOOIOI(int IJMDJBPNMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D80C40", Offset = "0x5D7F240", VA = "0x185D80C40")]
	public bool FMPPONDNAHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D80900", Offset = "0x5D7EF00", VA = "0x185D80900")]
	public char DKFAKFNKKAJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D80900", Offset = "0x5D7EF00", VA = "0x185D80900")]
	public ushort EOKLPNGOJJM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D812D0", Offset = "0x5D7F8D0", VA = "0x185D812D0")]
	public short OOCDEPFFCOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D80970", Offset = "0x5D7EF70", VA = "0x185D80970")]
	public long DKOOJMMAHGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D81180", Offset = "0x5D7F780", VA = "0x185D81180")]
	public ulong NFMDAEMFKBJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D81340", Offset = "0x5D7F940", VA = "0x185D81340")]
	public int PNKBNFKILAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D807C0", Offset = "0x5D7EDC0", VA = "0x185D807C0")]
	public uint ADFOPKFLMDA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D80BD0", Offset = "0x5D7F1D0", VA = "0x185D80BD0")]
	public float FHNBEONOFBC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D80F40", Offset = "0x5D7F540", VA = "0x185D80F40")]
	public double JGIHLHMOOBG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D80C80", Offset = "0x5D7F280", VA = "0x185D80C80")]
	public string ILIHODLCKBO(int EFEECMADLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D810D0", Offset = "0x5D7F6D0", VA = "0x185D810D0")]
	public ArraySegment<byte> LLHOBCODMPO(int JPBPNOCHNLG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D81250", Offset = "0x5D7F850", VA = "0x185D81250")]
	public sbyte[] OCHHMGDJCKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D81140", Offset = "0x5D7F740", VA = "0x185D81140")]
	public byte[] MIEGIILKMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D81230", Offset = "0x5D7F830", VA = "0x185D81230")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EA00", Offset = "0x5D6D000", VA = "0x185D6EA00")]
	public FHIPOIAMPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EA80", Offset = "0x5D6D080", VA = "0x185D6EA80")]
	public FHIPOIAMPCO(bool BLPBNODEKLN, int FBDJBCBKPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E900", Offset = "0x5D6CF00", VA = "0x185D6E900")]
	public static FHIPOIAMPCO OENLPELEHEO(string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E410", Offset = "0x5D6CA10", VA = "0x185D6E410")]
	public void IPCGCOECNMO(int IACFIIENNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F34E30", Offset = "0x1F33430", VA = "0x181F34E30")]
	public void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DEE0", Offset = "0x5D6C4E0", VA = "0x185D6DEE0")]
	public void FENNLLMCFLA(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DF80", Offset = "0x5D6C580", VA = "0x185D6DF80")]
	public void FENNLLMCFLA(double CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DE80", Offset = "0x5D6C480", VA = "0x185D6DE80")]
	public void FENNLLMCFLA(long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DE80", Offset = "0x5D6C480", VA = "0x185D6DE80")]
	public void FENNLLMCFLA(ulong CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E030", Offset = "0x5D6C630", VA = "0x185D6E030")]
	public void FENNLLMCFLA(int CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E030", Offset = "0x5D6C630", VA = "0x185D6E030")]
	public void FENNLLMCFLA(uint CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DDB0", Offset = "0x5D6C3B0", VA = "0x185D6DDB0")]
	public void FENNLLMCFLA(char CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DDB0", Offset = "0x5D6C3B0", VA = "0x185D6DDB0")]
	public void FENNLLMCFLA(ushort CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DDB0", Offset = "0x5D6C3B0", VA = "0x185D6DDB0")]
	public void FENNLLMCFLA(short CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DE20", Offset = "0x5D6C420", VA = "0x185D6DE20")]
	public void FENNLLMCFLA(sbyte CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DE20", Offset = "0x5D6C420", VA = "0x185D6DE20")]
	public void FENNLLMCFLA(byte CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E2D0", Offset = "0x5D6C8D0", VA = "0x185D6E2D0")]
	public void FENNLLMCFLA(byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DCD0", Offset = "0x5D6C2D0", VA = "0x185D6DCD0")]
	public void BCLHPLKAKFB(sbyte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DCD0", Offset = "0x5D6C2D0", VA = "0x185D6DCD0")]
	public void IGBHKIEOMBG(byte[] FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DFD0", Offset = "0x5D6C5D0", VA = "0x185D6DFD0")]
	public void FENNLLMCFLA(bool CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E750", Offset = "0x5D6CD50", VA = "0x185D6E750")]
	public void NLLGHDPDLGO(Array HGHEGKPMBJK, int NPMMIKNCEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E670", Offset = "0x5D6CC70", VA = "0x185D6E670")]
	public void NLLGHDPDLGO(float[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E590", Offset = "0x5D6CB90", VA = "0x185D6E590")]
	public void NLLGHDPDLGO(double[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E590", Offset = "0x5D6CB90", VA = "0x185D6E590")]
	public void NLLGHDPDLGO(long[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E590", Offset = "0x5D6CB90", VA = "0x185D6E590")]
	public void NLLGHDPDLGO(ulong[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E670", Offset = "0x5D6CC70", VA = "0x185D6E670")]
	public void NLLGHDPDLGO(int[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E670", Offset = "0x5D6CC70", VA = "0x185D6E670")]
	public void NLLGHDPDLGO(uint[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E4B0", Offset = "0x5D6CAB0", VA = "0x185D6E4B0")]
	public void NLLGHDPDLGO(ushort[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E4B0", Offset = "0x5D6CAB0", VA = "0x185D6E4B0")]
	public void NLLGHDPDLGO(short[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DCD0", Offset = "0x5D6C2D0", VA = "0x185D6DCD0")]
	public void NLLGHDPDLGO(bool[] CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E830", Offset = "0x5D6CE30", VA = "0x185D6E830")]
	public void NLLGHDPDLGO(string[] CBAEIEAPLIH, int JBKNFKLJKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E340", Offset = "0x5D6C940", VA = "0x185D6E340")]
	public void FENNLLMCFLA(IPEndPoint LCDHGKCOLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DED0", Offset = "0x5D6C4D0", VA = "0x185D6DED0")]
	public void FENNLLMCFLA(string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E0C0", Offset = "0x5D6C6C0", VA = "0x185D6E0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42E45A0", Offset = "0x42E2BA0", VA = "0x1842E45A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DFDALCMHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x57D02E0", Offset = "0x57CE8E0", VA = "0x1857D02E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ANIGBJIHMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E77EB0", Offset = "0x3E764B0", VA = "0x183E77EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D76C20", Offset = "0x5D75220", VA = "0x185D76C20")]
	public IMOEMNIAFHJ(int IJMDJBPNMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x291A9C0", Offset = "0x2918FC0", VA = "0x18291A9C0", Slot = "4")]
	protected virtual ulong CLFMJDPOCEJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D76A20", Offset = "0x5D75020", VA = "0x185D76A20", Slot = "5")]
	protected virtual HDCMFDDAHFN IHADALGAAMP(NNMHOFHLBFD DHKLMNOOPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B35390", Offset = "0x2B33990", VA = "0x182B35390", Slot = "6")]
	protected virtual void KAOPFKGEJIN<T>(FHIPOIAMPCO OGONFGJBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D76B50", Offset = "0x5D75150", VA = "0x185D76B50")]
	public void KMBMEKKNIJH(NNMHOFHLBFD DHKLMNOOPAJ, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2B34F60", Offset = "0x2B33560", VA = "0x182B34F60")]
	public void BHGJGDNIHGJ<T>(FHIPOIAMPCO OGONFGJBIBI, T FPDJEKLDODH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D76BD0", Offset = "0x5D751D0", VA = "0x185D76BD0")]
	public void PGNFCFOMKHO(NNMHOFHLBFD DHKLMNOOPAJ, object JLANMLLPCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2B351D0", Offset = "0x2B337D0", VA = "0x182B351D0")]
	public void HKDHKBEFFFH<T>(Action<T> GOBHCHEIMNF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2B35010", Offset = "0x2B33610", VA = "0x182B35010")]
	public void HKDHKBEFFFH<T, TUserData>(Action<T, TUserData> GOBHCHEIMNF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NPCBJJLIPMK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D77880", Offset = "0x5D75E80", VA = "0x185D77880")]
	public NPCBJJLIPMK(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JBJDBLNBDJA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D76DA0", Offset = "0x5D753A0", VA = "0x185D76DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3835A60", Offset = "0x3834060", VA = "0x183835A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
		[Cpp2IlInjected.Address(RVA = "0x4679A60", Offset = "0x4678060", VA = "0x184679A60", Slot = "7")]
		public override void PHDDHLPGBGG(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4679600", Offset = "0x4677C00", VA = "0x184679600", Slot = "8")]
		public override void JAAHAEMPJFG(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4676C80", Offset = "0x4675280", VA = "0x184676C80", Slot = "9")]
		public override void BPGKPOBDFHK(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x467A080", Offset = "0x4678680", VA = "0x18467A080", Slot = "10")]
		public override void PJALKEJNJEF(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x46767F0", Offset = "0x4674DF0", VA = "0x1846767F0")]
		protected TProperty[] AOJFCGIDABE(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4676E40", Offset = "0x4675440", VA = "0x184676E40")]
		protected TProperty[] GAHCFCFGLKJ(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4678030", Offset = "0x4676630", VA = "0x184678030", Slot = "4")]
		public override void IPJLDPAJHCH(MethodInfo KJPMCPLMPEB, MethodInfo NJKFKHADMIO, LAPJKLPEEDE PBLNJHEPKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C388E0", Offset = "0x3C36EE0", VA = "0x183C388E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x582F800", Offset = "0x582DE00", VA = "0x18582F800", Slot = "5")]
		public override void JPBHPDIMEHI(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x582F550", Offset = "0x582DB50", VA = "0x18582F550", Slot = "6")]
		public override void BHGJGDNIHGJ(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x582F960", Offset = "0x582DF60", VA = "0x18582F960", Slot = "7")]
		public override void PHDDHLPGBGG(TClass BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x582F5E0", Offset = "0x582DBE0", VA = "0x18582F5E0", Slot = "8")]
		public override void JAAHAEMPJFG(TClass BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x383C380", Offset = "0x383A980", VA = "0x18383C380")]
		protected DLBOOBNKKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class JDBMJGOFBDP<T> : OJDLPPJLGBO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x406CC80", Offset = "0x406B280", VA = "0x18406CC80", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x406CC10", Offset = "0x406B210", VA = "0x18406CC10", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x406CD00", Offset = "0x406B300", VA = "0x18406CD00", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFF90", Offset = "0x3DBE590", VA = "0x183DBFF90", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public JDBMJGOFBDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OKPGAFEOPFO<T> : OJDLPPJLGBO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x46972E0", Offset = "0x46958E0", VA = "0x1846972E0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x406CC10", Offset = "0x406B210", VA = "0x18406CC10", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4697360", Offset = "0x4695960", VA = "0x184697360", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFF90", Offset = "0x3DBE590", VA = "0x183DBFF90", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public OKPGAFEOPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FOIEHPDMCLN<T> : OJDLPPJLGBO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C80E50", Offset = "0x3C7F450", VA = "0x183C80E50", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C80D70", Offset = "0x3C7F370", VA = "0x183C80D70", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C80ED0", Offset = "0x3C7F4D0", VA = "0x183C80ED0", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C80DE0", Offset = "0x3C7F3E0", VA = "0x183C80DE0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public FOIEHPDMCLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MCHGCOBBDJL<T> : OJDLPPJLGBO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x44B1C10", Offset = "0x44B0210", VA = "0x1844B1C10", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C80D70", Offset = "0x3C7F370", VA = "0x183C80D70", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x44B1C90", Offset = "0x44B0290", VA = "0x1844B1C90", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C80DE0", Offset = "0x3C7F3E0", VA = "0x183C80DE0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public MCHGCOBBDJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CEHFBLBMKJN<T> : OJDLPPJLGBO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x504D400", Offset = "0x504BA00", VA = "0x18504D400", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x478B3C0", Offset = "0x47899C0", VA = "0x18478B3C0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x504D480", Offset = "0x504BA80", VA = "0x18504D480", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x478B430", Offset = "0x4789A30", VA = "0x18478B430", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public CEHFBLBMKJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PMJBKLAKJNK<T> : OJDLPPJLGBO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x478B4A0", Offset = "0x4789AA0", VA = "0x18478B4A0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x478B3C0", Offset = "0x47899C0", VA = "0x18478B3C0", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x478B520", Offset = "0x4789B20", VA = "0x18478B520", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x478B430", Offset = "0x4789A30", VA = "0x18478B430", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public PMJBKLAKJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ALKAGDEOLKF<T> : OJDLPPJLGBO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D66EF0", Offset = "0x3D654F0", VA = "0x183D66EF0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D66E10", Offset = "0x3D65410", VA = "0x183D66E10", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D76050", Offset = "0x3D74650", VA = "0x183D76050", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D66E80", Offset = "0x3D65480", VA = "0x183D66E80", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public ALKAGDEOLKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AGJKCBHDJBK<T> : OJDLPPJLGBO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D66EF0", Offset = "0x3D654F0", VA = "0x183D66EF0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D66E10", Offset = "0x3D65410", VA = "0x183D66E10", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D66F70", Offset = "0x3D65570", VA = "0x183D66F70", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D66E80", Offset = "0x3D65480", VA = "0x183D66E80", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public AGJKCBHDJBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HEHDOGFAEEJ<T> : OJDLPPJLGBO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0000", Offset = "0x3DBE600", VA = "0x183DC0000", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFF20", Offset = "0x3DBE520", VA = "0x183DBFF20", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0080", Offset = "0x3DBE680", VA = "0x183DC0080", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFF90", Offset = "0x3DBE590", VA = "0x183DBFF90", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public HEHDOGFAEEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CFNDCPNEDFO<T> : OJDLPPJLGBO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x51525D0", Offset = "0x5150BD0", VA = "0x1851525D0", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5152560", Offset = "0x5150B60", VA = "0x185152560", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5152650", Offset = "0x5150C50", VA = "0x185152650", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x478B430", Offset = "0x4789A30", VA = "0x18478B430", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public CFNDCPNEDFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OOPGKPMBCGD<T> : OJDLPPJLGBO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x46AC690", Offset = "0x46AAC90", VA = "0x1846AC690", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x46AC620", Offset = "0x46AAC20", VA = "0x1846AC620", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46AC710", Offset = "0x46AAD10", VA = "0x1846AC710", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D66E80", Offset = "0x3D65480", VA = "0x183D66E80", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C80F50", Offset = "0x3C7F550", VA = "0x183C80F50")]
		public OOPGKPMBCGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KMPEAODOOAF<T> : DLBOOBNKKOK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x420FA20", Offset = "0x420E020", VA = "0x18420FA20", Slot = "12")]
		protected override void LMKHMNLHOPJ(FHIPOIAMPCO FHNDBKCMHNE, char FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x420FA50", Offset = "0x420E050", VA = "0x18420FA50", Slot = "11")]
		protected override void OPJGDGPPGBC(NNMHOFHLBFD LJNBPEFJOFE, [Out] char FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x382F950", Offset = "0x382DF50", VA = "0x18382F950")]
		public KMPEAODOOAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class EJMHPJGBDAD<T> : DLBOOBNKKOK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x382F8E0", Offset = "0x382DEE0", VA = "0x18382F8E0", Slot = "12")]
		protected override void LMKHMNLHOPJ(FHIPOIAMPCO FHNDBKCMHNE, IPEndPoint FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x382F910", Offset = "0x382DF10", VA = "0x18382F910", Slot = "11")]
		protected override void OPJGDGPPGBC(NNMHOFHLBFD LJNBPEFJOFE, [Out] IPEndPoint FPNKOEEAPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x382F950", Offset = "0x382DF50", VA = "0x18382F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x57CF550", Offset = "0x57CDB50", VA = "0x1857CF550")]
		public DDJGEJPOOCB(int EFEECMADLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x57CF450", Offset = "0x57CDA50", VA = "0x1857CF450", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x57CF350", Offset = "0x57CD950", VA = "0x1857CF350", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x57CF4D0", Offset = "0x57CDAD0", VA = "0x1857CF4D0", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x57CF3D0", Offset = "0x57CD9D0", VA = "0x1857CF3D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C1A480", Offset = "0x3C18A80", VA = "0x183C1A480")]
		public FCDCFIJCCMC(PropertyInfo PDOOMGNBLHC, Type JDHDMFHKEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A300", Offset = "0x3C18900", VA = "0x183C1A300", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A190", Offset = "0x3C18790", VA = "0x183C1A190", Slot = "6")]
		public override void BHGJGDNIHGJ(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A3C0", Offset = "0x3C189C0", VA = "0x183C1A3C0", Slot = "7")]
		public override void PHDDHLPGBGG(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A2A0", Offset = "0x3C188A0", VA = "0x183C1A2A0", Slot = "8")]
		public override void JAAHAEMPJFG(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A240", Offset = "0x3C18840", VA = "0x183C1A240", Slot = "9")]
		public override void BPGKPOBDFHK(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A420", Offset = "0x3C18A20", VA = "0x183C1A420", Slot = "10")]
		public override void PJALKEJNJEF(T BHNAKOCJEND, FHIPOIAMPCO FHNDBKCMHNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MPIJKEEANOD<T> : FCDCFIJCCMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
		public MPIJKEEANOD(PropertyInfo PDOOMGNBLHC, Type JDHDMFHKEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x44F2B90", Offset = "0x44F1190", VA = "0x1844F2B90", Slot = "5")]
		public override void JPBHPDIMEHI(T BHNAKOCJEND, NNMHOFHLBFD LJNBPEFJOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x44F2AE0", Offset = "0x44F10E0", VA = "0x1844F2AE0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x44D8A50", Offset = "0x44D7050", VA = "0x1844D8A50")]
		public MKMILMPIFIG(List<EKGJPBIFCMM<T>> GKNJNIIMAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x44D88F0", Offset = "0x44D6EF0", VA = "0x1844D88F0")]
		public void BHGJGDNIHGJ(T HBFCGFKGCAF, FHIPOIAMPCO OGONFGJBIBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x44D89A0", Offset = "0x44D6FA0", VA = "0x1844D89A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D80320", Offset = "0x5D7E920", VA = "0x185D80320")]
	public NFOJEBCFCII(int IJMDJBPNMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AAE0", Offset = "0x2C690E0", VA = "0x182C6AAE0")]
	private MKMILMPIFIG<T> MGFFLKJNLEL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28B4720", Offset = "0x28B2D20", VA = "0x1828B4720")]
	public void PIKNDMFIIPK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A9B0", Offset = "0x2C68FB0", VA = "0x182C6A9B0")]
	public bool JGNOLJBBCJA<T>(NNMHOFHLBFD DHKLMNOOPAJ, T PKMPGPJICGL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AA50", Offset = "0x2C69050", VA = "0x182C6AA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D75C80", Offset = "0x5D74280", VA = "0x185D75C80")]
		get
		{
			return default(AKGDOFIOCNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JMMLEFFCNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D76550", Offset = "0x5D74B50", VA = "0x185D76550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D76340", Offset = "0x5D74940", VA = "0x185D76340")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CCAIPACHFJO BDHIHHHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D75620", Offset = "0x5D73C20", VA = "0x185D75620")]
		get
		{
			return default(CCAIPACHFJO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D75D70", Offset = "0x5D74370", VA = "0x185D75D70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GMFHGCIIFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D76090", Offset = "0x5D74690", VA = "0x185D76090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint ECBCOPGNKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D760C0", Offset = "0x5D746C0", VA = "0x185D760C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? OICOPEHHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D76310", Offset = "0x5D74910", VA = "0x185D76310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? EALLBLCNKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D75850", Offset = "0x5D73E50", VA = "0x185D75850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KIDOOCCMKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D75880", Offset = "0x5D73E80", VA = "0x185D75880")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D76140", Offset = "0x5D74740", VA = "0x185D76140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? BOFMKIGHBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC3DCF0", Offset = "0xC3C2F0", VA = "0x180C3DCF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA87EB0", Offset = "0xA864B0", VA = "0x180A87EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D76690", Offset = "0x5D74C90", VA = "0x185D76690")]
	public IKMBDLIIODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D765E0", Offset = "0x5D74BE0", VA = "0x185D765E0")]
	internal IKMBDLIIODL(byte[] JFDEDKFKPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D75F70", Offset = "0x5D74570", VA = "0x185D75F70")]
	public static IKMBDLIIODL LEAIFBAEKOO(byte[] JFDEDKFKPOF, DateTime CLCPODPJKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D75650", Offset = "0x5D73C50", VA = "0x185D75650")]
	internal void AJEMCEEFMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D76380", Offset = "0x5D74980", VA = "0x185D76380")]
	private void PABIIOOGOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D75A80", Offset = "0x5D74080", VA = "0x185D75A80")]
	private DateTime? DBDNPJDLMAM(int ANNLKNNLIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D758B0", Offset = "0x5D73EB0", VA = "0x185D758B0")]
	private void DAMCGBJBLDK(int ANNLKNNLIGI, DateTime? CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D75DB0", Offset = "0x5D743B0", VA = "0x185D75DB0")]
	private ulong KECGPJBDHIP(int ANNLKNNLIGI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D75CB0", Offset = "0x5D742B0", VA = "0x185D75CB0")]
	private void EDHAHCCDHCH(int ANNLKNNLIGI, ulong CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D75E80", Offset = "0x5D74480", VA = "0x185D75E80")]
	private uint KGHEGIGPAIJ(int ANNLKNNLIGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5C40B00", Offset = "0x5C3F100", VA = "0x185C40B00")]
	private static uint KMACJGALJJF(uint OOALEDCPNBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D75F10", Offset = "0x5D74510", VA = "0x185D75F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D6EB20", Offset = "0x5D6D120", VA = "0x185D6EB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EB30", Offset = "0x5D6D130", VA = "0x185D6EB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D6B7B0", Offset = "0x5D69DB0", VA = "0x185D6B7B0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JFNLLHGILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B190", Offset = "0x5D69790", VA = "0x185D6B190", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint HKLCNAFFBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B1B0", Offset = "0x5D697B0", VA = "0x185D6B1B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily JCEINDDOKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x428FEE0", Offset = "0x428E4E0", VA = "0x18428FEE0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B7D0", Offset = "0x5D69DD0", VA = "0x185D6B7D0")]
	public ALFOJENEBME(AddressFamily FOEFNDNJIKH, LFIJFBNOPML EDADOBCCCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B1D0", Offset = "0x5D697D0", VA = "0x185D6B1D0", Slot = "8")]
	public bool LMECFMPNDAB(IPEndPoint LCDHGKCOLJK, MOHCKOKGADO JLDCMLDDPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B060", Offset = "0x5D69660", VA = "0x185D6B060", Slot = "9")]
	public int BBKEADJGPKP(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int ENCFHCJIMBE, IPEndPoint EPALFHALBID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B0A0", Offset = "0x5D696A0", VA = "0x185D6B0A0", Slot = "10")]
	public int DEGKOGJHDPP(byte[] EPBKIHMMALG, EndPoint IPICNGJDAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B790", Offset = "0x5D69D90", VA = "0x185D6B790", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D73A90", Offset = "0x5D72090", VA = "0x185D73A90")]
	public HAMHCMIEKGP(byte[] FHOAFCBIOFF, int CAEGCHDJOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x88AC00", Offset = "0x889200", VA = "0x18088AC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D73A50", Offset = "0x5D72050", VA = "0x185D73A50", Slot = "4")]
	public bool Equals(HAMHCMIEKGP LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5D739A0", Offset = "0x5D71FA0", VA = "0x185D739A0", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FDC4D0", Offset = "0x1FDAAD0", VA = "0x181FDC4D0")]
	public GLJPJNOIADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5D72F50", Offset = "0x5D71550", VA = "0x185D72F50")]
	public void MJPDOOHJOLK(IPEndPoint LCDHGKCOLJK, byte[] BHEIPBKEDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5D72E70", Offset = "0x5D71470", VA = "0x185D72E70")]
	public void LOKCKGMIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D73470", Offset = "0x5D71A70", VA = "0x185D73470", Slot = "4")]
	public override void PNCDIDBOKKN(IPEndPoint LCDHGKCOLJK, byte[] FHNKDHIILBL, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D73100", Offset = "0x5D71700", VA = "0x185D73100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D81F40", Offset = "0x5D80540", VA = "0x185D81F40")]
		[BurstDiscard]
		private static void NOFIFJJLNCO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D81AF0", Offset = "0x5D800F0", VA = "0x185D81AF0")]
		private static IntPtr HAOAIHDJJLG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D81C50", Offset = "0x5D80250", VA = "0x185D81C50")]
		public static void IBIOCCAHNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
		public static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5D81D00", Offset = "0x5D80300", VA = "0x185D81D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D740A0", Offset = "0x5D726A0", VA = "0x185D740A0")]
	private void FDHFDDAAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5D74190", Offset = "0x5D72790", VA = "0x185D74190")]
	private uint NHEIKNNJAFC(uint DCMJEJAEEHK, int AHDEPJPJAOA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AC10", Offset = "0x5D69210", VA = "0x185D6AC10")]
	private void BHACHGDABGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ACC0", Offset = "0x5D692C0", VA = "0x185D6ACC0")]
	private void HMDFIBADJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AED0", Offset = "0x5D694D0", VA = "0x185D6AED0")]
	private void NPAPDLKEDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AF60", Offset = "0x5D69560", VA = "0x185D6AF60")]
	private void PBCJHILOKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D74320", Offset = "0x5D72920", VA = "0x185D74320")]
	private void PKINGDDOMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5D73C80", Offset = "0x5D72280", VA = "0x185D73C80")]
	private unsafe void AMBLIEBNFNA(byte* CAEOKMPHFAO, uint* BHEIPBKEDLG, uint* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D741C0", Offset = "0x5D727C0", VA = "0x185D741C0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void PJODEBHCEPE([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D74240", Offset = "0x5D72840", VA = "0x185D74240")]
	public static void PJODEBHCEPE(Span<byte> CAEOKMPHFAO, Span<byte> BHEIPBKEDLG, Span<byte> PACDDAODFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D73B80", Offset = "0x5D72180", VA = "0x185D73B80")]
	public static void AHCNKBGPPNP(Span<byte> CAEOKMPHFAO, Span<byte> BHEIPBKEDLG, Span<byte> PACDDAODFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D74120", Offset = "0x5D72720", VA = "0x185D74120")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void HBIHOPGCGFD([NoAlias] byte* CAEOKMPHFAO, [NoAlias] byte* BHEIPBKEDLG, [NoAlias] byte* PACDDAODFBA, int DOIKAIEGGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D82070", Offset = "0x5D80670", VA = "0x185D82070")]
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
