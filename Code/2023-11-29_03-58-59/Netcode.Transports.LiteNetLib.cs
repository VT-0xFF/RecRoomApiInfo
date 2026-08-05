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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JOBIBOEAAKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum ABOAFJKOBMJ
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
		private NetworkManager LHHODACHEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, MBFHHKAOMLO> GCICHPHDNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DDKFPBIOIHC KIPFNLBECIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] DFJAELILAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ABOAFJKOBMJ IEJBDHMEEBL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong NOCKEFOPOIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool INKENINLDLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5341EF0", Offset = "0x53412F0", VA = "0x185341EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53413F0", Offset = "0x53407F0", VA = "0x1853413F0")]
		public void RecRoom_SetEncryptionInfo(ulong FEELILKLEAK, byte[] MIMFBLPNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53413D0", Offset = "0x53407D0", VA = "0x1853413D0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53412A0", Offset = "0x53406A0", VA = "0x1853412A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5341DF0", Offset = "0x53411F0", VA = "0x185341DF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x53415F0", Offset = "0x53409F0", VA = "0x1853415F0", Slot = "6")]
		public override void Send(ulong BANBPKAHABN, ArraySegment<byte> KKOACPFFAML, NetworkDelivery GPKJDAHLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5341390", Offset = "0x5340790", VA = "0x185341390", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BANBPKAHABN, [Out] ArraySegment<byte> LJIMLOGOIHA, [Out] float AGJOFLENHPE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x53418E0", Offset = "0x5340CE0", VA = "0x1853418E0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5341D10", Offset = "0x5341110", VA = "0x185341D10", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5340770", Offset = "0x533FB70", VA = "0x185340770", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BANBPKAHABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5340620", Offset = "0x533FA20", VA = "0x185340620", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5340DF0", Offset = "0x53401F0", VA = "0x185340DF0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BANBPKAHABN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5341870", Offset = "0x5340C70", VA = "0x185341870", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5340E90", Offset = "0x5340290", VA = "0x185340E90", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LHHODACHEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x53408E0", Offset = "0x533FCE0", VA = "0x1853408E0")]
		private CGCAAOCEKOI FDFNKJAMHGC(NetworkDelivery LFLAEPCPMDG)
		{
			return default(CGCAAOCEKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5340A10", Offset = "0x533FE10", VA = "0x185340A10", Slot = "15")]
		private void FOOKEJAAJGO(MBFHHKAOMLO NFIGEELACAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5341080", Offset = "0x5340480", VA = "0x185341080", Slot = "16")]
		private void MPFAEHBGOPO(MBFHHKAOMLO NFIGEELACAJ, NIHMDLKNDEN GHCLCEEBOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "17")]
		private void JBBFJCOOLNK(IPEndPoint KMGGGJHMHEB, SocketError JDCEKOPCGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5340AF0", Offset = "0x533FEF0", VA = "0x185340AF0", Slot = "18")]
		private void GLGILPNFMDC(MBFHHKAOMLO NFIGEELACAJ, FDAJJNFDMKE PCDAGGPDBLK, byte PNEOBPJEKBM, CGCAAOCEKOI GGOPGAAHOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53411C0", Offset = "0x53405C0", VA = "0x1853411C0")]
		private void NCNBMIAKHMA(int PEGIIHFIAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "19")]
		private void PGPAMJKBPED(IPEndPoint DKGJPPOHNMF, FDAJJNFDMKE PCDAGGPDBLK, OHPGFAMCBKK DGDDOCPFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "20")]
		private void JJCLJDGDLMO(MBFHHKAOMLO NFIGEELACAJ, int OBABBKHBBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53409B0", Offset = "0x533FDB0", VA = "0x1853409B0", Slot = "21")]
		private void FIPNBMPAKLN(DOLMKPFKDFF JAFMNEFDFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5341050", Offset = "0x5340450", VA = "0x185341050")]
		private ulong JMMGAKBELPK(MBFHHKAOMLO NFIGEELACAJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5340AD0", Offset = "0x533FED0", VA = "0x185340AD0")]
		private static int GAMBONFFMFH(float IODAOFLOKJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5341E10", Offset = "0x5341210", VA = "0x185341E10")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EAKJPGEDAHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly MBFHHKAOMLO JBCICNINBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<EABIGJPJJNH> FDOMKLAMJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JMMJCFAFPDE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x533DA90", Offset = "0x533CE90", VA = "0x18533DA90")]
	protected EAKJPGEDAHB(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x533D9B0", Offset = "0x533CDB0", VA = "0x18533D9B0")]
	public void KEOOEAIFIIG(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x533DA10", Offset = "0x533CE10", VA = "0x18533DA10")]
	protected void LBAKPADBKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x533D970", Offset = "0x533CD70", VA = "0x18533D970")]
	public bool DIDCGABDCHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool PKOCPKGMFEI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool KBIKGIDCIKC(EABIGJPJJNH CJFNEMBIFNC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KDLNHCDFFII
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
public class DOLMKPFKDFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DDKFPBIOIHC IGABCALPMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int DBGKEHMFKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal AEKJIIPHCAI GOLLLNAFLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint POBINAMDDAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KDLNHCDFFII DGBIOOCKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x798BA0", VA = "0x1807997A0")]
		[CompilerGenerated]
		get
		{
			return default(KDLNHCDFFII);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x896530", Offset = "0x895930", VA = "0x180896530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x533CD90", Offset = "0x533C190", VA = "0x18533CD90")]
	internal void AKFCIABPLAP(AEKJIIPHCAI IHECEOOLPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x533CE50", Offset = "0x533C250", VA = "0x18533CE50")]
	private bool JPIMCHLABNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x533CE80", Offset = "0x533C280", VA = "0x18533CE80")]
	internal DOLMKPFKDFF(IPEndPoint DKGJPPOHNMF, AEKJIIPHCAI CMACENCBHOP, DDKFPBIOIHC NLMJPNNDBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x533CDF0", Offset = "0x533C1F0", VA = "0x18533CDF0")]
	public MBFHHKAOMLO JBHAIMHNDKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OHPGFAMCBKK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PAICNPLCKLN
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
public struct NIHMDLKNDEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public PAICNPLCKLN MHLGDMABIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError OOHCBAFDAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FDAJJNFDMKE DGAJPDPMAKJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JOBIBOEAAKM
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIGMABJEAPP(MBFHHKAOMLO NFIGEELACAJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKFIMEBFCDG(MBFHHKAOMLO NFIGEELACAJ, NIHMDLKNDEN GHCLCEEBOLC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKCEMIAIKDE(IPEndPoint KMGGGJHMHEB, SocketError JDCEKOPCGOG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFODNODGKMJ(MBFHHKAOMLO NFIGEELACAJ, FDAJJNFDMKE PCDAGGPDBLK, byte PNEOBPJEKBM, CGCAAOCEKOI GGOPGAAHOAO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOLGHMMDKAM(IPEndPoint DKGJPPOHNMF, FDAJJNFDMKE PCDAGGPDBLK, OHPGFAMCBKK DGDDOCPFDKL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDLEIJCABIH(MBFHHKAOMLO NFIGEELACAJ, int OBABBKHBBFD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNLCELJONOK(DOLMKPFKDFF JAFMNEFDFCM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AHOBJIKIIPG
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJEOCDJLDOJ(MBFHHKAOMLO NFIGEELACAJ, object HFKPLAJAIIK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LGBGJPDCNCI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBIOJKJPFLB(MDIOLJJNKAE CJFNEMBIFNC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CPEBKPDMIIO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHAGCBKDKGL(MBFHHKAOMLO NFIGEELACAJ, IPEndPoint MILAAEKLBFM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class AEKJIIPHCAI
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int IGDGFLMNAPL = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long DMDFPHHDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte PFBHLMHBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] JDOKELDECNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DGEBGJIOIGP CEKPCFBCLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int FKNLHFPEHIH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5333C10", Offset = "0x5333010", VA = "0x185333C10")]
	private AEKJIIPHCAI(long BPGACHNMGKF, byte IGJOLFKAFKP, int LNNMEKKDHOB, byte[] NDEGHLACJGH, DGEBGJIOIGP KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53339D0", Offset = "0x5332DD0", VA = "0x1853339D0")]
	public static int IIGKNCHELLK(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53337B0", Offset = "0x5332BB0", VA = "0x1853337B0")]
	public static AEKJIIPHCAI BELPAJLKCCE(EABIGJPJJNH CJFNEMBIFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5333A30", Offset = "0x5332E30", VA = "0x185333A30")]
	public static EABIGJPJJNH LGIJNAEDLKN(NKDDHCBCMJM KIGIDKIPANO, SocketAddress NNJNLGCEPFJ, long FNKKECBMMKF, int LNNMEKKDHOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class EGLDJIKDDOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long DMDFPHHDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte PFBHLMHBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int FKNLHFPEHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JPPOIOMCGCD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x533DE70", Offset = "0x533D270", VA = "0x18533DE70")]
	private EGLDJIKDDOM(long BPGACHNMGKF, byte IGJOLFKAFKP, int DOBGDFBOPOJ, bool ECKHLDKBODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x533DB30", Offset = "0x533CF30", VA = "0x18533DB30")]
	public static EGLDJIKDDOM BELPAJLKCCE(EABIGJPJJNH CJFNEMBIFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x533DD80", Offset = "0x533D180", VA = "0x18533DD80")]
	public static EABIGJPJJNH LGIJNAEDLKN(long FNKKECBMMKF, byte NCKLKKGDGPC, int IAIGHICCIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x533DC80", Offset = "0x533D080", VA = "0x18533DC80")]
	public static EABIGJPJJNH FACAKPDPIAN(MBFHHKAOMLO NFIGEELACAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct NGGODIIJNNH : IEquatable<NGGODIIJNNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long MNAGFPOOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long MPNJPEDMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long HNFPDGGCDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int JHCAPNPPPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int MHMFAICDNNM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5347E40", Offset = "0x5347240", VA = "0x185347E40")]
	public NGGODIIJNNH(byte[] PDCKLNFEACL, int LFJAKODBOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x798BA0", VA = "0x1807997A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5347D50", Offset = "0x5347150", VA = "0x185347D50", Slot = "4")]
	public bool Equals(NGGODIIJNNH LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5347D90", Offset = "0x5347190", VA = "0x185347D90", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EMDAJKFJDMJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] MNHIBPAJBBJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x533DEC0", Offset = "0x533D2C0", VA = "0x18533DEC0")]
	public EMDAJKFJDMJ(byte[] PDCKLNFEACL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class OGMCNIEDLHP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class ENBFCHIDFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x533E2B0", Offset = "0x533D6B0", VA = "0x18533E2B0")]
		public static extern int GNCHDIDPCFI(IntPtr ENJHLLMJPMA, [In][Out] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [Out] byte[] JKKPDONKFPC, [In][Out] int DKPPBHPCFGL);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x533E1D0", Offset = "0x533D5D0", VA = "0x18533E1D0")]
		internal static extern int ADJPFGDGCHI(IntPtr ENJHLLMJPMA, [In] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [In] byte[] JKKPDONKFPC, [In] int DKPPBHPCFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class HJINJJLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x533F820", Offset = "0x533EC20", VA = "0x18533F820")]
		public static extern int GNCHDIDPCFI(IntPtr ENJHLLMJPMA, [In][Out] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [Out] byte[] JKKPDONKFPC, [In][Out] int DKPPBHPCFGL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x533F740", Offset = "0x533EB40", VA = "0x18533F740")]
		internal static extern int ADJPFGDGCHI(IntPtr ENJHLLMJPMA, [In] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [In] byte[] JKKPDONKFPC, [In] int DKPPBHPCFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool INKENINLDLG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool AKHGGLMBBNM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> CBNFBMJMFID;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5349E30", Offset = "0x5349230", VA = "0x185349E30")]
	static OGMCNIEDLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x53499C0", Offset = "0x5348DC0", VA = "0x1853499C0")]
	public static int CANJIEBNFLK(IntPtr ENJHLLMJPMA, byte[] IDHADLKCFHE, int LFJAKODBOBM, byte[] JKKPDONKFPC, int DKPPBHPCFGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5349BB0", Offset = "0x5348FB0", VA = "0x185349BB0")]
	public static int GCGOLGGBICM(IntPtr ENJHLLMJPMA, byte[] IDHADLKCFHE, int LFJAKODBOBM, byte[] JKKPDONKFPC, int DKPPBHPCFGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5349D40", Offset = "0x5349140", VA = "0x185349D40")]
	public static SocketError GENMELAMDEK()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5349A70", Offset = "0x5348E70", VA = "0x185349A70")]
	public static SocketException FPHMNNJBNCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5349910", Offset = "0x5348D10", VA = "0x185349910")]
	public static short AMPELOFIMJN(IPEndPoint DKGJPPOHNMF)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KEAECPGEOMD
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ANCBFKDAONM
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBHMEKDIMEE(IPEndPoint NHMGDIKCJEM, IPEndPoint DKGJPPOHNMF, string NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHLKNGNILKE(IPEndPoint ENFPOJLGKJL, KEAECPGEOMD LFLAEPCPMDG, string NOEAHPPKHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class MIJGPCPCCCN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct OEECACJAEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint AJEPNNLJNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint POBINAMDDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string INBGIIILFEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct BIACKCLFCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint DKKNFLGKJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KEAECPGEOMD MELBEGGEDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string INBGIIILFEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JGGKPPGCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint ONFDEOAMHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string INBGIIILFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JGGKPPGCEGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class IGEIEDHIPND
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ONFDEOAMHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LGIBFLLINPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string INBGIIILFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public IGEIEDHIPND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class AJEOABCNDGK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string INBGIIILFEK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IILBAMHGBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F2620", VA = "0x1807F3220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x77FF70", Offset = "0x77F370", VA = "0x18077FF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public AJEOABCNDGK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly DDKFPBIOIHC AMMKFNDIGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<OEECACJAEPD> GCBIBIMOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<BIACKCLFCEL> GMFJELIFOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DGEBGJIOIGP JAANMGNNBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NKDDHCBCMJM ADDIOLHEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DDFFMHHHNBO NDBKPDNMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private ANCBFKDAONM CADCKBLKJAD;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int FJENEPMLHFB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool MLJDOOLPODK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5347770", Offset = "0x5346B70", VA = "0x185347770")]
	internal MIJGPCPCCCN(DDKFPBIOIHC HAECPOBJMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5347610", Offset = "0x5346A10", VA = "0x185347610")]
	internal void NFPEHHKCLFG(IPEndPoint CPGFHNAONPN, EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25A8170", Offset = "0x25A7570", VA = "0x1825A8170")]
	private void HAKPDOBLJOI<T>(T CJFNEMBIFNC, IPEndPoint OPJDDCOPPHE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5347160", Offset = "0x5346560", VA = "0x185347160")]
	private void FBHMEKDIMEE(JGGKPPGCEGG CJAPEBOFGGF, IPEndPoint CPGFHNAONPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x53472F0", Offset = "0x53466F0", VA = "0x1853472F0")]
	private void HKJGKMLCIBO(IGEIEDHIPND CJAPEBOFGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5347470", Offset = "0x5346870", VA = "0x185347470")]
	private void IABIMOPBHJO(AJEOABCNDGK CJAPEBOFGGF, IPEndPoint CPGFHNAONPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CGCAAOCEKOI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class POOOBCOLILA
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] NJCHCCJJBHP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int EMAIPOBICMN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int ANLAIGLIFEK;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OALAJIADGGL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x533E490", Offset = "0x533D890", VA = "0x18533E490")]
	public OALAJIADGGL(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EPLHFKEOKKL : OALAJIADGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x533E490", Offset = "0x533D890", VA = "0x18533E490")]
	public EPLHFKEOKKL(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum JGAEBDFKEJC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JHCGJPKGKPH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIOLEMFBLHG(JGAEBDFKEJC LHCNAECDNAC, string DFBAIJNHOKM, params object[] IFILEFKNBLN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LOAIHBGLNAJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static JHCGJPKGKPH BCDHEODCPDC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object AMKEIJELNPK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5340280", Offset = "0x533F680", VA = "0x185340280")]
	private static void GBFCDLJKNAJ(JGAEBDFKEJC LDJGOHMFEAN, string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5340510", Offset = "0x533F910", VA = "0x185340510")]
	internal static void IEHNPCAIDII(string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53404B0", Offset = "0x533F8B0", VA = "0x1853404B0")]
	internal static void HDPDCMILEMC(string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5340220", Offset = "0x533F620", VA = "0x185340220")]
	internal static void BALMLPJOGFE(string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum HMAHKMICBEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FDAJJNFDMKE : DGEBGJIOIGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EABIGJPJJNH FIOJPPHGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DDKFPBIOIHC BEMKGICBLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly GBBBEBGIGKD JNHKMNICDBD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x533E5C0", Offset = "0x533D9C0", VA = "0x18533E5C0")]
	internal FDAJJNFDMKE(DDKFPBIOIHC CHJDMKIKGKN, GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x533E4A0", Offset = "0x533D8A0", VA = "0x18533E4A0")]
	internal void EHKKJFMCKKD(EABIGJPJJNH CJFNEMBIFNC, int NDHNOKCKBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x533E510", Offset = "0x533D910", VA = "0x18533E510")]
	internal void IAEJOKPMJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x533E590", Offset = "0x533D990", VA = "0x18533E590")]
	public void KLLGEFNOEFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class GBBBEBGIGKD
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum ILMJJAAMNJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GBBBEBGIGKD JGBDDJFAKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public ILMJJAAMNJB MELBEGGEDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public MBFHHKAOMLO JBCICNINBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint POBINAMDDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object BGACBJMEBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int KADICEFHPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError ALDFCLBILLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public PAICNPLCKLN MDDCONHFCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public DOLMKPFKDFF HIHLLEIGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public CGCAAOCEKOI PGKKNHDPLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte OMOEJDDEHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly FDAJJNFDMKE NMHOAOPAHAM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x533F6A0", Offset = "0x533EAA0", VA = "0x18533F6A0")]
	public GBBBEBGIGKD(DDKFPBIOIHC CHJDMKIKGKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DDKFPBIOIHC : IEnumerable<MBFHHKAOMLO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class JIDOPAMGHFD : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x533F960", Offset = "0x533ED60", VA = "0x18533F960", Slot = "4")]
		public bool Equals(IPEndPoint OPHKAEHAFCM, IPEndPoint CLGLFIMLHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF420", Offset = "0x4DEE820", VA = "0x184DEF420", Slot = "5")]
		public int GetHashCode(IPEndPoint ECLCDMJMICA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JIDOPAMGHFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ENOPAMJKIDI : IEnumerator<MBFHHKAOMLO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly MBFHHKAOMLO GFOAELAOOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private MBFHHKAOMLO NMJIFKGEADC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MBFHHKAOMLO ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8348F0", Offset = "0x833CF0", VA = "0x1808348F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8348F0", Offset = "0x833CF0", VA = "0x1808348F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE60260", Offset = "0xE5F660", VA = "0x180E60260")]
		public ENOPAMJKIDI(MBFHHKAOMLO ENFHPFLKGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x533E3F0", Offset = "0x533D7F0", VA = "0x18533E3F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x533E440", Offset = "0x533D840", VA = "0x18533E440", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread OCJEFPEAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool ACGODKJHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent NMBDBGDBLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<GBBBEBGIGKD> IENKCEODNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<GBBBEBGIGKD> LJMFIMCAOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private GBBBEBGIGKD BJOMAPIOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JOBIBOEAAKM OPEFILAEBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly AHOBJIKIIPG KLAHAKEOMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LGBGJPDCNCI BEAAEJPEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CPEBKPDMIIO BDANFHPMMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, MBFHHKAOMLO> DJJLNNHLNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, DOLMKPFKDFF> GBPAPDOFJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, MOEFJMPCNNC> DDAOLBKGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim BNFEHPLCIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MBFHHKAOMLO OECOPGLGEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int GCFKBIGBAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<MBFHHKAOMLO> FAIPNBGFLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private MBFHHKAOMLO[] PNFHOEBENDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HCBCNDHGJCG DHIFKAFNHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int LLGNGPCODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> KMJLHMENLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte IGBEPAPGOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object HCODIDNEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool AEACMDNNEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool BPGFDLKLHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int PMMPEIJHMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int MFIBNHLBGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LBPMPFKDAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LMIPJMIDKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool GFLGMHOIGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int BKKJNNEOAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int BENGNGMLLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int KFKGGLKHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool MLJDOOLPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool LCGBMDFPNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EMGPLGNLJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool KICBFLMMOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int BCDKEPOBKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int OCFCMBAFLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool OLEOIKCCHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly BAHHEPHHJPM MDBEFHJPLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool MOBOOAAPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly MIJGPCPCCCN HIOLPGNIPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool HBLCNIEKKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public HMAHKMICBEJ DOPJODOHKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int MMCBHGBJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool ILCFHAIOCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool JGACPHMHJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool AKOEIAMFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool IDPLKPPCLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private EABIGJPJJNH EHHAOLHENEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int ALGLEGPEPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object NOKNJKIEDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int FJFLCPGBNFB;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int LGONFFOHBBH = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket NELJNAADLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket NMEGILLONPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread HKKOJCPKOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread JCKBIAAKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint BJCDDILMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint DHIBHJPEGGK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] DJHJHDHLPDF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] KMADFOAPOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<NGGODIIJNNH, IPEndPoint> LFOINEFJBLA;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int MGMBDOFDCKN = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress MPIKPMIKEHK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool ELBMAJPFPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int OGMJBLGKBKK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GCFKBPIFMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x12521E0", Offset = "0x12515E0", VA = "0x1812521E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x12521F0", Offset = "0x12515F0", VA = "0x1812521F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OFPCGGMFOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x150EB70", Offset = "0x150DF70", VA = "0x18150EB70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x150D830", Offset = "0x150CC30", VA = "0x18150D830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte BIBIPPLJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81DF50", Offset = "0x81D350", VA = "0x18081DF50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BEENBIGLANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5339870", Offset = "0x5338C70", VA = "0x185339870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short DFMKLENAGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5339C70", Offset = "0x5339070", VA = "0x185339C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5339BD0", Offset = "0x5338FD0", VA = "0x185339BD0")]
	public void MLFJDMFEPJA(IPEndPoint KMGGGJHMHEB, byte[] MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x53347C0", Offset = "0x5333BC0", VA = "0x1853347C0")]
	public void ANPFNDKBBAA(IPEndPoint KMGGGJHMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5334F30", Offset = "0x5334330", VA = "0x185334F30")]
	private bool BFMFBOKKLFI(IPEndPoint KMGGGJHMHEB, [Out] MBFHHKAOMLO NFIGEELACAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5335D00", Offset = "0x5335100", VA = "0x185335D00")]
	private void FGCJEDOJLOA(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5339F00", Offset = "0x5339300", VA = "0x185339F00")]
	private void ONOLPICOBCG(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5339CA0", Offset = "0x53390A0", VA = "0x185339CA0")]
	private void NOAKDKMGPJI(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x533BAF0", Offset = "0x533AEF0", VA = "0x18533BAF0")]
	public DDKFPBIOIHC(JOBIBOEAAKM NLMJPNNDBFP, [Optional] HCBCNDHGJCG BBLPAOBDPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53368D0", Offset = "0x5335CD0", VA = "0x1853368D0")]
	internal void HCLDEFOKGEA(MBFHHKAOMLO BDKDGEJLOML, int OBABBKHBBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5337510", Offset = "0x5336910", VA = "0x185337510")]
	internal void KLJLBLEKALB(MBFHHKAOMLO BDKDGEJLOML, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5337350", Offset = "0x5336750", VA = "0x185337350")]
	internal void KIIJIPBCNJL(MBFHHKAOMLO NFIGEELACAJ, PAICNPLCKLN BKBNKNNDEMK, SocketError KNCMNHNMJAJ, EABIGJPJJNH LHEBENHACBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x533B0E0", Offset = "0x533A4E0", VA = "0x18533B0E0")]
	private void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ, PAICNPLCKLN BKBNKNNDEMK, SocketError KNCMNHNMJAJ, bool EHGFADNFMAI, byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK, EABIGJPJJNH LHEBENHACBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5334FC0", Offset = "0x53343C0", VA = "0x185334FC0")]
	private void BJNNPEFHPCJ(GBBBEBGIGKD.ILMJJAAMNJB LFLAEPCPMDG, [Optional] MBFHHKAOMLO NFIGEELACAJ, [Optional] IPEndPoint DKGJPPOHNMF, SocketError FIBEPNMHCEG = SocketError.Success, int OBABBKHBBFD = 0, PAICNPLCKLN FIBPMOHCFCA = PAICNPLCKLN.ConnectionFailed, [Optional] DOLMKPFKDFF EFBGJGEMOJH, CGCAAOCEKOI GGOPGAAHOAO = CGCAAOCEKOI.Unreliable, byte PNEOBPJEKBM = 0, [Optional] EABIGJPJJNH OEBGJOAODCP, [Optional] object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5337560", Offset = "0x5336960", VA = "0x185337560")]
	private void LCDFHNAOBCG(GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5336390", Offset = "0x5335790", VA = "0x185336390")]
	internal void FPIFCDIAIAM(GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5339890", Offset = "0x5338C90", VA = "0x185339890")]
	private void MKFLOKFFOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x533B280", Offset = "0x533A680", VA = "0x18533B280")]
	private void PJJEDGPIFFE(int MOJBPAPPGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5334910", Offset = "0x5333D10", VA = "0x185334910")]
	internal MBFHHKAOMLO BEDLBICHNLJ(DOLMKPFKDFF JAFMNEFDFCM, byte[] AAPPFGIPNPP, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5336850", Offset = "0x5335C50", VA = "0x185336850")]
	private int GIHBEGNHGOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5337D20", Offset = "0x5337120", VA = "0x185337D20")]
	private void LFHDIBDKEDH(IPEndPoint DKGJPPOHNMF, MBFHHKAOMLO IHJMFPKIIPD, AEKJIIPHCAI HCPJIGHJGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5339F50", Offset = "0x5339350", VA = "0x185339F50")]
	private void OOAEGPMFEEM(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5337090", Offset = "0x5336490", VA = "0x185337090")]
	internal void JIGFNDNAEMC(EABIGJPJJNH CJFNEMBIFNC, CGCAAOCEKOI EHEJGNENLFE, byte PNEOBPJEKBM, int NDHNOKCKBLN, MBFHHKAOMLO BDKDGEJLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5338EB0", Offset = "0x53382B0", VA = "0x185338EB0")]
	public bool MBHHAMKDCLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5338E10", Offset = "0x5338210", VA = "0x185338E10")]
	public bool MBHHAMKDCLO(IPAddress OIKAMDOOCNI, IPAddress HPENDKNEAIA, int NFEOBLPIHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5338E30", Offset = "0x5338230", VA = "0x185338E30")]
	public bool MBHHAMKDCLO(int NFEOBLPIHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53366B0", Offset = "0x5335AB0", VA = "0x1853366B0")]
	public void GFCBLFIFIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53359D0", Offset = "0x5334DD0", VA = "0x1853359D0")]
	public MBFHHKAOMLO EAEPFHCKGOK(string PDCKLNFEACL, int NFEOBLPIHMD, string MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53358F0", Offset = "0x5334CF0", VA = "0x1853358F0")]
	public MBFHHKAOMLO EAEPFHCKGOK(string PDCKLNFEACL, int NFEOBLPIHMD, NKDDHCBCMJM ACHMHCBDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5335520", Offset = "0x5334920", VA = "0x185335520")]
	public MBFHHKAOMLO EAEPFHCKGOK(IPEndPoint OPJDDCOPPHE, NKDDHCBCMJM ACHMHCBDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5334490", Offset = "0x5333890", VA = "0x185334490")]
	public void AHNKAFMKLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53344A0", Offset = "0x53338A0", VA = "0x1853344A0")]
	public void AHNKAFMKLLA(bool LPILLENMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5336490", Offset = "0x5335890", VA = "0x185336490")]
	public void FPPJBGIMPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5336590", Offset = "0x5335990", VA = "0x185336590")]
	public void FPPJBGIMPBL(byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x533B030", Offset = "0x533A430", VA = "0x18533B030")]
	public void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x533B1C0", Offset = "0x533A5C0", VA = "0x18533B1C0")]
	public void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ, byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x533B910", Offset = "0x533AD10", VA = "0x18533B910", Slot = "4")]
	private IEnumerator<MBFHHKAOMLO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x533B9A0", Offset = "0x533ADA0", VA = "0x18533B9A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5336EC0", Offset = "0x53362C0", VA = "0x185336EC0")]
	private EABIGJPJJNH IKAFCAEJFOB(GOIJKDIBLPA PGPOOACGDAP, int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5336FB0", Offset = "0x53363B0", VA = "0x185336FB0")]
	private EABIGJPJJNH IKAFCAEJFOB(GOIJKDIBLPA PGPOOACGDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53360A0", Offset = "0x53354A0", VA = "0x1853360A0")]
	internal EABIGJPJJNH FNBGLOKCGJN(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53396A0", Offset = "0x5338AA0", VA = "0x1853396A0")]
	internal void MGGHNHCDAHE(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x533BA30", Offset = "0x533AE30", VA = "0x18533BA30")]
	static DDKFPBIOIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x12521E0", Offset = "0x12515E0", VA = "0x1812521E0")]
	private bool KLNEECJHJNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5337420", Offset = "0x5336820", VA = "0x185337420")]
	private void KJHBJDMMIAO(IPEndPoint JBJCJAFFLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5335FC0", Offset = "0x53353C0", VA = "0x185335FC0")]
	private void FKFJIJOAOJD(IPEndPoint JBJCJAFFLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5335380", Offset = "0x5334780", VA = "0x185335380")]
	private bool CHANKPLOPJI(SocketException LLKMJCLKBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5335AB0", Offset = "0x5334EB0", VA = "0x185335AB0")]
	private void EFMEANDJCCN(Socket HAECPOBJMFG, EndPoint DKAIADCGGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x533ACA0", Offset = "0x533A0A0", VA = "0x18533ACA0")]
	private void OONMHCFOKBA(object IFHMBCKBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x533B5A0", Offset = "0x533A9A0", VA = "0x18533B5A0")]
	private void PMKEMPELAGH(object IFHMBCKBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5338EC0", Offset = "0x53382C0", VA = "0x185338EC0")]
	public bool MBHHAMKDCLO(IPAddress OIKAMDOOCNI, IPAddress HPENDKNEAIA, int NFEOBLPIHMD, bool ABPDBCNKNFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5336920", Offset = "0x5335D20", VA = "0x185336920")]
	private bool HKJCPCICEFJ(Socket HAECPOBJMFG, IPEndPoint JBJCJAFFLMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5339810", Offset = "0x5338C10", VA = "0x185339810")]
	internal int MHEGCJAIBDK(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5338180", Offset = "0x5337580", VA = "0x185338180")]
	internal int MAIAOHHALCN(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53381C0", Offset = "0x53375C0", VA = "0x1853381C0")]
	internal int MAIAOHHALCN(byte[] KCFFPPIEBHH, int DFOEGCCLIEM, int HKIFHAEDDHO, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5336260", Offset = "0x5335660", VA = "0x185336260")]
	internal void FOBAEPJENNO(bool FLIOLKFJDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum GOIJKDIBLPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class EABIGJPJJNH
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int GGIJFJPMNMF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] DMCLGDGPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] ENNLKMBGKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int DIHNPGKKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object BGACBJMEBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public EABIGJPJJNH JGBDDJFAKIG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GOIJKDIBLPA ALLHHEPEDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x533D090", Offset = "0x533C490", VA = "0x18533D090")]
		get
		{
			return default(GOIJKDIBLPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x533D050", Offset = "0x533C450", VA = "0x18533D050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PFBHLMHBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x533D3A0", Offset = "0x533C7A0", VA = "0x18533D3A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x533D1F0", Offset = "0x533C5F0", VA = "0x18533D1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort HBEFCFMAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x533CFC0", Offset = "0x533C3C0", VA = "0x18533CFC0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x533D230", Offset = "0x533C630", VA = "0x18533D230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool APPBGIKMLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x533D370", Offset = "0x533C770", VA = "0x18533D370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte AEKJOCKIIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x533CEF0", Offset = "0x533C2F0", VA = "0x18533CEF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x533D020", Offset = "0x533C420", VA = "0x18533D020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CBCNACKABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x533D410", Offset = "0x533C810", VA = "0x18533D410")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x533D470", Offset = "0x533C870", VA = "0x18533D470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort DIKKDMPMGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x533CF20", Offset = "0x533C320", VA = "0x18533CF20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x533D3D0", Offset = "0x533C7D0", VA = "0x18533D3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PNFPHAAJBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x533D4B0", Offset = "0x533C8B0", VA = "0x18533D4B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x533CF80", Offset = "0x533C380", VA = "0x18533CF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x533D510", Offset = "0x533C910", VA = "0x18533D510")]
	static EABIGJPJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x533D1C0", Offset = "0x533C5C0", VA = "0x18533D1C0")]
	public void IECJLKJFIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x533D900", Offset = "0x533CD00", VA = "0x18533D900")]
	public EABIGJPJJNH(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x533D7F0", Offset = "0x533CBF0", VA = "0x18533D7F0")]
	public EABIGJPJJNH(GOIJKDIBLPA PGPOOACGDAP, int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x533D270", Offset = "0x533C670", VA = "0x18533D270")]
	public static int KKCCBCAGJEK(GOIJKDIBLPA PGPOOACGDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x533D2E0", Offset = "0x533C6E0", VA = "0x18533D2E0")]
	public int KKCCBCAGJEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x533D0C0", Offset = "0x533C4C0", VA = "0x18533D0C0")]
	public bool HBPFCAMOKIP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum LEDHEMIFPIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum NAJLNJAOHDF
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal enum HHBNCOMLHPG
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum GIBOAGFBANP
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MBFHHKAOMLO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FCHOJFAKFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public EABIGJPJJNH[] OKOENEDKPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int EGBEIMIMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int OIKENEBFGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte AEKJOCKIIOL;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public FCHOJFAKFED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void OPDHKDPOEOL(ulong LBCGEPANECI, int ELAAGFDOPKO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int CPNLPIJKKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int PMKPNCKBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BPMGECNCKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double GOLHGPLOKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int LCPJDKAEOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int NHOGGPDIBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch GLJGNGDEMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int FDDFBLHOAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long ELJKOJKFOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object CPOOJBKFKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal MBFHHKAOMLO BDMDEMFGHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal MBFHHKAOMLO ENOCCIEFNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<EABIGJPJJNH> BHEBNLEPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<EAKJPGEDAHB> PMAPKKBPHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly EAKJPGEDAHB[] NHLIHKMNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int IBNNPGLCBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int BBJBKDAKGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool FLGHGENLBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int GCCAMIJNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int DELLPPLBJLF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int LPIOGDIKMOJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int HNIFCODNBDA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object DMGDLCDGAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int KNBJLEAMPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, FCHOJFAKFED> FPDJMJCDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> NFOGLBMJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EABIGJPJJNH KMEGBHKJJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int CMBNCEGEAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JGGJAEFCGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint OCJBBAAOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int KHCAEMEFLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int DJGDKLGKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long ABLLOCNBLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte BPMOKFDJAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private LEDHEMIFPIE CLHHKCPJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private EABIGJPJJNH CBFJIDPOBPE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int LJAENBAMMOM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int DALKBAPLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly EABIGJPJJNH BOMGKIBLEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly EABIGJPJJNH JKJJLODPBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly EABIGJPJJNH DHMBMLKMIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly EABIGJPJJNH JAIJNFPGCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly DDKFPBIOIHC MGDLCLGDECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int KHHBGPLFKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object ENOOCCJMAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly BAHHEPHHJPM MDBEFHJPLEC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte ABDONPLPFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81D340", VA = "0x18081DF40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5343990", Offset = "0x5342D90", VA = "0x185343990")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint NLOJBHCJMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9641E0", Offset = "0x9635E0", VA = "0x1809641E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LEDHEMIFPIE HOPDNHNGGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1074A10", Offset = "0x1073E10", VA = "0x181074A10")]
		get
		{
			return default(LEDHEMIFPIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KOGLDDCFKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92EFA0", Offset = "0x92E3A0", VA = "0x18092EFA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EGEMAMDNEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x150EB80", Offset = "0x150DF80", VA = "0x18150EB80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x150DAA0", Offset = "0x150CEA0", VA = "0x18150DAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HJNMHIHBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5343980", Offset = "0x5342D80", VA = "0x185343980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GOOPDCBAJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78F4E0", Offset = "0x78E8E0", VA = "0x18078F4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double OAIFCACADBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1701F50", Offset = "0x1701350", VA = "0x181701F50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OPDHKDPOEOL LEFACEJIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5342400", Offset = "0x5341800", VA = "0x185342400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5342350", Offset = "0x5341750", VA = "0x185342350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5345600", Offset = "0x5344A00", VA = "0x185345600")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, IPEndPoint DKGJPPOHNMF, int EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5343960", Offset = "0x5342D60", VA = "0x185343960")]
	internal void IGEBCEBNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5344A90", Offset = "0x5343E90", VA = "0x185344A90")]
	internal void LPKIOMJOJKF(IPEndPoint JEFEIGCMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5343870", Offset = "0x5342C70", VA = "0x185343870")]
	internal void FEHLKCMPDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5341F10", Offset = "0x5341310", VA = "0x185341F10")]
	private void AAKCEOCFKNP(int MEIHADHNHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5343930", Offset = "0x5342D30", VA = "0x185343930")]
	private void HEJGGDIDKMF(int PANPJCNOPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5345450", Offset = "0x5344850", VA = "0x185345450")]
	private EAKJPGEDAHB OJGPOKFAADO(byte DMMFKFNAHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5345A60", Offset = "0x5344E60", VA = "0x185345A60")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, IPEndPoint DKGJPPOHNMF, int EPDCALNHKAP, byte NCKLKKGDGPC, NKDDHCBCMJM KIGIDKIPANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5345BF0", Offset = "0x5344FF0", VA = "0x185345BF0")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, DOLMKPFKDFF JAFMNEFDFCM, int EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5343A40", Offset = "0x5342E40", VA = "0x185343A40")]
	internal void KAHKKMHFFMM(AEKJIIPHCAI BFLBBAPGDDN, byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5342660", Offset = "0x5341A60", VA = "0x185342660")]
	internal bool CKEHFCJFEFA(EGLDJIKDDOM CJFNEMBIFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5343900", Offset = "0x5342D00", VA = "0x185343900")]
	public void HAKPDOBLJOI(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, CGCAAOCEKOI AHMINIDFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5342D50", Offset = "0x5342150", VA = "0x185342D50")]
	private void ECBJPHBEAFN(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, byte PNEOBPJEKBM, CGCAAOCEKOI GGOPGAAHOAO, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x53441A0", Offset = "0x53435A0", VA = "0x1853441A0")]
	public void KKINBLMALBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5342C70", Offset = "0x5342070", VA = "0x185342C70")]
	internal HHBNCOMLHPG EALEMFAGCIH(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(HHBNCOMLHPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5344140", Offset = "0x5343540", VA = "0x185344140")]
	internal void KCBCBONMEDL(EAKJPGEDAHB KBDDHPFEGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53432A0", Offset = "0x53426A0", VA = "0x1853432A0")]
	internal GIBOAGFBANP ECEOCBLDGMJ(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, bool EHGFADNFMAI)
	{
		return default(GIBOAGFBANP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5342C30", Offset = "0x5342030", VA = "0x185342C30")]
	private void DAFIJGDMBHP(int JHBFBNPKEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5344AC0", Offset = "0x5343EC0", VA = "0x185344AC0")]
	internal void NIOHJHNCILM(CGCAAOCEKOI EHEJGNENLFE, EABIGJPJJNH ENFHPFLKGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x53426E0", Offset = "0x5341AE0", VA = "0x1853426E0")]
	private void CPIICBOINLM(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5341FE0", Offset = "0x53413E0", VA = "0x185341FE0")]
	private void AINEABDLBHH(int EMIPGAHFJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5344250", Offset = "0x5343650", VA = "0x185344250")]
	internal NAJLNJAOHDF LFHDIBDKEDH(AEKJIIPHCAI HCPJIGHJGKK)
	{
		return default(NAJLNJAOHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5343A90", Offset = "0x5342E90", VA = "0x185343A90")]
	internal void KBIKGIDCIKC(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5344990", Offset = "0x5343D90", VA = "0x185344990")]
	private void LNFOCOHHJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53424B0", Offset = "0x53418B0", VA = "0x1853424B0")]
	internal void CHHOPOLFNEM(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5344410", Offset = "0x5343810", VA = "0x185344410")]
	internal void LFKJJNEOHNN(int EMIPGAHFJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x53435B0", Offset = "0x53429B0", VA = "0x1853435B0")]
	internal void EMJJFOCLIAC(EABIGJPJJNH CJFNEMBIFNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BAHHEPHHJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long JDCFJLDNENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long CHFJJOCGNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long ADJECGOEIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long BBOOGAFBBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long PJEOPKGDMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long DFHCOLDFOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5333CE0", Offset = "0x53330E0", VA = "0x185333CE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KAHMDEGLBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5333D10", Offset = "0x5333110", VA = "0x185333D10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LHHCHNGIAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5333D20", Offset = "0x5333120", VA = "0x185333D20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KMGDBPFOGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5333D00", Offset = "0x5333100", VA = "0x185333D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long JCPKCAGLEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5333D80", Offset = "0x5333180", VA = "0x185333D80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CBJNNFGPPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5333D90", Offset = "0x5333190", VA = "0x185333D90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5333D70", Offset = "0x5333170", VA = "0x185333D70")]
	public void IKKBIKDCDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5333D50", Offset = "0x5333150", VA = "0x185333D50")]
	public void HAHINIKAEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5333D30", Offset = "0x5333130", VA = "0x185333D30")]
	public void DDOHGIJBKPP(long IOMBAJNIHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5333D60", Offset = "0x5333160", VA = "0x185333D60")]
	public void HKLJEKOHBAO(long GOOAOGEGPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5333D40", Offset = "0x5333140", VA = "0x185333D40")]
	public void EHKIPPBGOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5333CF0", Offset = "0x53330F0", VA = "0x185333CF0")]
	public void AODHBKCNDPM(long DCHEHJFMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5333DE0", Offset = "0x53331E0", VA = "0x185333DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BAHHEPHHJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LBAIHFGCHJP
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> GGOAIKEFNEN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x533FCB0", Offset = "0x533F0B0", VA = "0x18533FCB0")]
	public static IPEndPoint FHKKINCJILO(string IKNBFHIDGJH, int NFEOBLPIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x533FF30", Offset = "0x533F330", VA = "0x18533FF30")]
	public static IPAddress PBIHPDOHBLH(string IKNBFHIDGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5340100", Offset = "0x533F500", VA = "0x185340100")]
	public static IPAddress PBIHPDOHBLH(string IKNBFHIDGJH, AddressFamily JCMCHPIEFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x533FF00", Offset = "0x533F300", VA = "0x18533FF00")]
	internal static int JDBEHMNDNCA(int LJGBMIIMMGB, int KOGDJLCHGNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2581010", Offset = "0x2580410", VA = "0x182581010")]
	internal static T[] HEJHNPNHKOL<T>(int APAKJDHFMCK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class FIHFLDJHICF : EAKJPGEDAHB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KODJAAEGIEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EABIGJPJJNH FIOJPPHGALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long GFBHCJNBDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool BIGJMJGOFJJ;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x533FC10", Offset = "0x533F010", VA = "0x18533FC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x533FB80", Offset = "0x533EF80", VA = "0x18533FB80")]
		public void IOFGIHBGGGP(EABIGJPJJNH CJFNEMBIFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x533FBA0", Offset = "0x533EFA0", VA = "0x18533FBA0")]
		public bool KGNCBAFCJHF(long JOANGLMKMAI, MBFHHKAOMLO NFIGEELACAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x533FB30", Offset = "0x533EF30", VA = "0x18533FB30")]
		public bool ILNOFIHDCKG(MBFHHKAOMLO NFIGEELACAJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly EABIGJPJJNH GACKOJFPGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly KODJAAEGIEI[] FJFKEEOEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly EABIGJPJJNH[] NDEMKCAHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] OCKLHLFMMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int PBKHCAOCFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int BKEFFAFINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int NNFMLKFPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int FDDGCCAMEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool BEGLNABNFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly CGCAAOCEKOI BCBCDKKDFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool FJNHLBEFBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int EJNAIHDJNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte AOOPELMPBJK;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x533F4D0", Offset = "0x533E8D0", VA = "0x18533F4D0")]
	public FIHFLDJHICF(MBFHHKAOMLO NFIGEELACAJ, bool CCCLBENIDIJ, byte EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x533E610", Offset = "0x533DA10", VA = "0x18533E610")]
	private void DLOGDMFENHJ(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x533F020", Offset = "0x533E420", VA = "0x18533F020", Slot = "4")]
	protected override bool PKOCPKGMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x533E9C0", Offset = "0x533DDC0", VA = "0x18533E9C0", Slot = "5")]
	public override bool KBIKGIDCIKC(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class OGNEMFPGBCC : EAKJPGEDAHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int FKPADNCCBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort BKEFFAFINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool AIOPBACGAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private EABIGJPJJNH EMPCBNBOEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly EABIGJPJJNH FHMEMEGDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool CAIELBNJGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte AOOPELMPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long DJKCPJKKGCA;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x534ABE0", Offset = "0x5349FE0", VA = "0x18534ABE0")]
	public OGNEMFPGBCC(MBFHHKAOMLO NFIGEELACAJ, bool EAHLMFCLMJM, byte EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x534A770", Offset = "0x5349B70", VA = "0x18534A770", Slot = "4")]
	protected override bool PKOCPKGMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x534A490", Offset = "0x5349890", VA = "0x18534A490", Slot = "5")]
	public override bool KBIKGIDCIKC(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KJDCAFGCLGG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct LPMJJJBJLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong FCPFBIBFDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double FILJJOBJOOL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct BHCGOEPBJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int FHODMFDAKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float CBCGODBIHAD;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5333620", Offset = "0x5332A20", VA = "0x185333620")]
	private static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, ulong KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x533FA50", Offset = "0x533EE50", VA = "0x18533FA50")]
	private static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, int KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x533FAE0", Offset = "0x533EEE0", VA = "0x18533FAE0")]
	public static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, short KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x533FAC0", Offset = "0x533EEC0", VA = "0x18533FAC0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x533F9D0", Offset = "0x533EDD0", VA = "0x18533F9D0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x533FAE0", Offset = "0x533EEE0", VA = "0x18533FAE0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x533FAE0", Offset = "0x533EEE0", VA = "0x18533FAE0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x533FA50", Offset = "0x533EE50", VA = "0x18533FA50")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x533FA50", Offset = "0x533EE50", VA = "0x18533FA50")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x533FB20", Offset = "0x533EF20", VA = "0x18533FB20")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x533FB20", Offset = "0x533EF20", VA = "0x18533FB20")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, ulong NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DGEBGJIOIGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] GGMGCHKNJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int PFDFFCDCFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int JOEMDEFKAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int PMFMOENILEK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] ENNLKMBGKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GLCEBJJPFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x896540", Offset = "0x895940", VA = "0x180896540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GBHEDPLGOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x533CCE0", Offset = "0x533C0E0", VA = "0x18533CCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ECEGCMEACIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB2B0", Offset = "0x1BFA6B0", VA = "0x181BFB2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CFNAGIEDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x533C140", Offset = "0x533B540", VA = "0x18533C140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x533C450", Offset = "0x533B850", VA = "0x18533C450")]
	public void EHKKJFMCKKD(byte[] HFLNDIDMJFD, int ELJAGIMMLLH, int NHHADKDNGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DGEBGJIOIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x533CD30", Offset = "0x533C130", VA = "0x18533CD30")]
	public DGEBGJIOIGP(byte[] HFLNDIDMJFD, int ELJAGIMMLLH, int NHHADKDNGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x533CAA0", Offset = "0x533BEA0", VA = "0x18533CAA0")]
	public IPEndPoint KFBDJCPBEOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x533C2E0", Offset = "0x533B6E0", VA = "0x18533C2E0")]
	public byte CHCNGBCKDJK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x533C2E0", Offset = "0x533B6E0", VA = "0x18533C2E0")]
	public sbyte MKPDABGPDGA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x23759A0", Offset = "0x2374DA0", VA = "0x1823759A0")]
	public T[] PPBOMBOJOII<T>(ushort PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x533C540", Offset = "0x533B940", VA = "0x18533C540")]
	public bool[] GPBHCNKKEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x533CC20", Offset = "0x533C020", VA = "0x18533CC20")]
	public ushort[] MONGNNIKCAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x533C1C0", Offset = "0x533B5C0", VA = "0x18533C1C0")]
	public short[] AMDHOIBLDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x533CC60", Offset = "0x533C060", VA = "0x18533CC60")]
	public int[] NFDAOFGIBOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x533CBE0", Offset = "0x533BFE0", VA = "0x18533CBE0")]
	public uint[] MJFJABFPCNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x533C3D0", Offset = "0x533B7D0", VA = "0x18533C3D0")]
	public float[] DAMBOKHFOKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x533C490", Offset = "0x533B890", VA = "0x18533C490")]
	public double[] EKMEFOHCCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x533CCA0", Offset = "0x533C0A0", VA = "0x18533CCA0")]
	public long[] OAGMDCNMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x533C410", Offset = "0x533B810", VA = "0x18533C410")]
	public ulong[] EFEDGLPADKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x533C630", Offset = "0x533BA30", VA = "0x18533C630")]
	public string[] HPMGHCCCEHI(int NEHBDOKIPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x533C390", Offset = "0x533B790", VA = "0x18533C390")]
	public bool DALMPAODNLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x533C150", Offset = "0x533B550", VA = "0x18533C150")]
	public char NEFEDLJJGDD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x533C150", Offset = "0x533B550", VA = "0x18533C150")]
	public ushort ACNFNAMHNJP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x533C5C0", Offset = "0x533B9C0", VA = "0x18533C5C0")]
	public short HMOHDCKBHDD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x533C200", Offset = "0x533B600", VA = "0x18533C200")]
	public long BFMFDOELOPE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x533CA30", Offset = "0x533BE30", VA = "0x18533CA30")]
	public ulong KBJFCKNBAEM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x533CB70", Offset = "0x533BF70", VA = "0x18533CB70")]
	public int KPMFIHDNFCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x533C270", Offset = "0x533B670", VA = "0x18533C270")]
	public uint BKPGELIKEEH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x533C4D0", Offset = "0x533B8D0", VA = "0x18533C4D0")]
	public float GIBNMALDPGA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x533C320", Offset = "0x533B720", VA = "0x18533C320")]
	public double CHPKKDEALDC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x533C7F0", Offset = "0x533BBF0", VA = "0x18533C7F0")]
	public string JKACOHPGJEJ(int MEHPPAAAOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x533C760", Offset = "0x533BB60", VA = "0x18533C760")]
	public ArraySegment<byte> IIBGOPJFIFN(int APAKJDHFMCK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x533C580", Offset = "0x533B980", VA = "0x18533C580")]
	public sbyte[] HDGFEPMCDBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x533CCF0", Offset = "0x533C0F0", VA = "0x18533CCF0")]
	public byte[] PHBDDGICODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x533C7D0", Offset = "0x533BBD0", VA = "0x18533C7D0")]
	public void ILNOFIHDCKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NKDDHCBCMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] GGMGCHKNJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int PFDFFCDCFIP;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int IKHJJMLKJEM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool CCFHPHFEPLE;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding FKDGKHGBMDI;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int FCHPKALNCDM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] JGHMGLCPLKA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] CEKPCFBCLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NAHNDBFADBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x53497F0", Offset = "0x5348BF0", VA = "0x1853497F0")]
	public NKDDHCBCMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5349870", Offset = "0x5348C70", VA = "0x185349870")]
	public NKDDHCBCMJM(bool ELJFLBDLKNH, int LJFEOIBMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5348BA0", Offset = "0x5347FA0", VA = "0x185348BA0")]
	public static NKDDHCBCMJM BDKOICDHAKE(string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5348C10", Offset = "0x5348010", VA = "0x185348C10")]
	public void DCBAEJHLKEC(int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C74BB0", Offset = "0x1C73FB0", VA = "0x181C74BB0")]
	public void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5349270", Offset = "0x5348670", VA = "0x185349270")]
	public void KKEPNBBHLIP(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5349150", Offset = "0x5348550", VA = "0x185349150")]
	public void KKEPNBBHLIP(double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5349090", Offset = "0x5348490", VA = "0x185349090")]
	public void KKEPNBBHLIP(long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5349090", Offset = "0x5348490", VA = "0x185349090")]
	public void KKEPNBBHLIP(ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5348CB0", Offset = "0x53480B0", VA = "0x185348CB0")]
	public void KKEPNBBHLIP(int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5348CB0", Offset = "0x53480B0", VA = "0x185348CB0")]
	public void KKEPNBBHLIP(uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x53490E0", Offset = "0x53484E0", VA = "0x1853490E0")]
	public void KKEPNBBHLIP(char NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x53490E0", Offset = "0x53484E0", VA = "0x1853490E0")]
	public void KKEPNBBHLIP(ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x53490E0", Offset = "0x53484E0", VA = "0x1853490E0")]
	public void KKEPNBBHLIP(short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5348FB0", Offset = "0x53483B0", VA = "0x185348FB0")]
	public void KKEPNBBHLIP(sbyte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5348FB0", Offset = "0x53483B0", VA = "0x185348FB0")]
	public void KKEPNBBHLIP(byte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5349010", Offset = "0x5348410", VA = "0x185349010")]
	public void KKEPNBBHLIP(byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5348AC0", Offset = "0x5347EC0", VA = "0x185348AC0")]
	public void ALCHFNHKBBK(sbyte[] KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5348AC0", Offset = "0x5347EC0", VA = "0x185348AC0")]
	public void GCKIPCOAJNP(byte[] KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5348D40", Offset = "0x5348140", VA = "0x185348D40")]
	public void KKEPNBBHLIP(bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x53495A0", Offset = "0x53489A0", VA = "0x1853495A0")]
	public void MEJCIOGFACM(Array AGOLNOEJENC, int HICGFJOONML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x53494C0", Offset = "0x53488C0", VA = "0x1853494C0")]
	public void MEJCIOGFACM(float[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5349680", Offset = "0x5348A80", VA = "0x185349680")]
	public void MEJCIOGFACM(double[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5349680", Offset = "0x5348A80", VA = "0x185349680")]
	public void MEJCIOGFACM(long[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5349680", Offset = "0x5348A80", VA = "0x185349680")]
	public void MEJCIOGFACM(ulong[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x53494C0", Offset = "0x53488C0", VA = "0x1853494C0")]
	public void MEJCIOGFACM(int[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53494C0", Offset = "0x53488C0", VA = "0x1853494C0")]
	public void MEJCIOGFACM(uint[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x53493E0", Offset = "0x53487E0", VA = "0x1853493E0")]
	public void MEJCIOGFACM(ushort[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x53493E0", Offset = "0x53487E0", VA = "0x1853493E0")]
	public void MEJCIOGFACM(short[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5348AC0", Offset = "0x5347EC0", VA = "0x185348AC0")]
	public void MEJCIOGFACM(bool[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5349310", Offset = "0x5348710", VA = "0x185349310")]
	public void MEJCIOGFACM(string[] NMENOOMOOJP, int IJAMBAIAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x53491A0", Offset = "0x53485A0", VA = "0x1853491A0")]
	public void KKEPNBBHLIP(IPEndPoint KMGGGJHMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5349080", Offset = "0x5348480", VA = "0x185349080")]
	public void KKEPNBBHLIP(string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5348DA0", Offset = "0x53481A0", VA = "0x185348DA0")]
	public void KKEPNBBHLIP(string NMENOOMOOJP, int MEHPPAAAOIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class DDFFMHHHNBO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class MAGOBMMIEHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong KHHBGPLFKOB;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C98830", Offset = "0x3C97C30", VA = "0x183C98830")]
		static MAGOBMMIEHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void BDIBHGAKGDK(DGEBGJIOIGP PCDAGGPDBLK, object HFKPLAJAIIK);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class CDKKHKLDFCB<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public DDFFMHHHNBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public CDKKHKLDFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4728D40", Offset = "0x4728140", VA = "0x184728D40")]
		internal void LGAGJDBPAPB(DGEBGJIOIGP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OOANNGNJAOF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public DDFFMHHHNBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OOANNGNJAOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B1A0", Offset = "0x3E1A5A0", VA = "0x183E1B1A0")]
		internal void LGAGJDBPAPB(DGEBGJIOIGP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly NFEPFPCPJLE DHDIIBBHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, BDIBHGAKGDK> DKLCFMMBBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NKDDHCBCMJM OBMFIAJMOOH;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5334310", Offset = "0x5333710", VA = "0x185334310")]
	public DDFFMHHHNBO(int NEHBDOKIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	protected virtual ulong MGFEGGGILHG<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5334190", Offset = "0x5333590", VA = "0x185334190", Slot = "5")]
	protected virtual BDIBHGAKGDK MDMAIMENJOA(DGEBGJIOIGP PCDAGGPDBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2374B30", Offset = "0x2373F30", VA = "0x182374B30", Slot = "6")]
	protected virtual void DLICNGMGGED<T>(NKDDHCBCMJM EKCFHKIKCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5334110", Offset = "0x5333510", VA = "0x185334110")]
	public void AELFKILMHMA(DGEBGJIOIGP PCDAGGPDBLK, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2374EA0", Offset = "0x23742A0", VA = "0x182374EA0")]
	public void OMAJEIBBGKE<T>(NKDDHCBCMJM EKCFHKIKCOP, T CJFNEMBIFNC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x53342C0", Offset = "0x53336C0", VA = "0x1853342C0")]
	public void PHICKBDHDOM(DGEBGJIOIGP PCDAGGPDBLK, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2374D20", Offset = "0x2374120", VA = "0x182374D20")]
	public void DPFOGHNHCNP<T>(Action<T> BEDDIJBHPBG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2374BA0", Offset = "0x2373FA0", VA = "0x182374BA0")]
	public void DPFOGHNHCNP<T, TUserData>(Action<T, TUserData> BEDDIJBHPBG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GOALPJBOOFN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x533E490", Offset = "0x533D890", VA = "0x18533E490")]
	public GOALPJBOOFN(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AOPIJDLMGMH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5333C80", Offset = "0x5333080", VA = "0x185333C80")]
	public AOPIJDLMGMH(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NFEPFPCPJLE
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum BJFAPIMJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class GKOPMMNDAIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public BJFAPIMJDFD MELBEGGEDAJ;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3551BF0", Offset = "0x3550FF0", VA = "0x183551BF0", Slot = "4")]
		public virtual void IOFGIHBGGGP(MethodInfo OCMFCGPEJIA, MethodInfo MKFMMFFKLPJ, BJFAPIMJDFD LFLAEPCPMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void OIDIPBCAJNM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MDHAJPHGILI(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		protected GKOPMMNDAIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class IMKLMBNMCPA<TClass, TProperty> : GKOPMMNDAIE<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> CNHAMHPHKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> IONGHGCHHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> MDHDGFHOHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> LCNNNIILJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> NAOGFLPBIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> FOEKJDCJONC;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3765920", Offset = "0x3764D20", VA = "0x183765920", Slot = "7")]
		public override void KMOLNJMFJNB(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x375FFD0", Offset = "0x375F3D0", VA = "0x18375FFD0", Slot = "8")]
		public override void EDEGJCBPJGA(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3766C60", Offset = "0x3766060", VA = "0x183766C60", Slot = "9")]
		public override void OIDIPBCAJNM(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37663A0", Offset = "0x37657A0", VA = "0x1837663A0", Slot = "10")]
		public override void MDHAJPHGILI(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3760580", Offset = "0x375F980", VA = "0x183760580")]
		protected TProperty[] HIBADHNMLEJ(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3760510", Offset = "0x375F910", VA = "0x183760510")]
		protected TProperty[] EIIJOBBMLIK(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3763A40", Offset = "0x3762E40", VA = "0x183763A40", Slot = "4")]
		public override void IOFGIHBGGGP(MethodInfo OCMFCGPEJIA, MethodInfo MKFMMFFKLPJ, BJFAPIMJDFD LFLAEPCPMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x35885F0", Offset = "0x35879F0", VA = "0x1835885F0")]
		protected IMKLMBNMCPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class GCDICLOBCEK<TClass, TProperty> : IMKLMBNMCPA<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void FHKBANAAACP(DGEBGJIOIGP BCPCCCLDBKN, [Out] TProperty BNFBAEJHPCK);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void MHGHEMBAOKP(NKDDHCBCMJM IKENEDAFBLJ, TProperty BNFBAEJHPCK);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3528970", Offset = "0x3527D70", VA = "0x183528970", Slot = "5")]
		public override void FHJDGHDGGLM(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3528B30", Offset = "0x3527F30", VA = "0x183528B30", Slot = "6")]
		public override void OMAJEIBBGKE(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x35289F0", Offset = "0x3527DF0", VA = "0x1835289F0", Slot = "7")]
		public override void KMOLNJMFJNB(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x35287B0", Offset = "0x3527BB0", VA = "0x1835287B0", Slot = "8")]
		public override void EDEGJCBPJGA(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3528C10", Offset = "0x3528010", VA = "0x183528C10")]
		protected GCDICLOBCEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IECLGIPPDNN<T> : IMKLMBNMCPA<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x373F2D0", Offset = "0x373E6D0", VA = "0x18373F2D0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x373F3B0", Offset = "0x373E7B0", VA = "0x18373F3B0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x373F340", Offset = "0x373E740", VA = "0x18373F340", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x373F270", Offset = "0x373E670", VA = "0x18373F270", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public IECLGIPPDNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OBHNGPFMDMJ<T> : IMKLMBNMCPA<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8100", Offset = "0x3DE7500", VA = "0x183DE8100", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x373F3B0", Offset = "0x373E7B0", VA = "0x18373F3B0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8170", Offset = "0x3DE7570", VA = "0x183DE8170", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x373F270", Offset = "0x373E670", VA = "0x18373F270", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public OBHNGPFMDMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class EIBHEGCBFON<T> : IMKLMBNMCPA<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x30F7DC0", Offset = "0x30F71C0", VA = "0x1830F7DC0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x30F7EA0", Offset = "0x30F72A0", VA = "0x1830F7EA0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x30F7E30", Offset = "0x30F7230", VA = "0x1830F7E30", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x30F7D60", Offset = "0x30F7160", VA = "0x1830F7D60", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public EIBHEGCBFON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class IKHGDIBCIMN<T> : IMKLMBNMCPA<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x375C550", Offset = "0x375B950", VA = "0x18375C550", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x30F7EA0", Offset = "0x30F72A0", VA = "0x1830F7EA0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x375C5C0", Offset = "0x375B9C0", VA = "0x18375C5C0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x30F7D60", Offset = "0x30F7160", VA = "0x1830F7D60", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public IKHGDIBCIMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DHBGPLGHDGO<T> : IMKLMBNMCPA<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF420", Offset = "0x4DCE820", VA = "0x184DCF420", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F24490", Offset = "0x3F23890", VA = "0x183F24490", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF490", Offset = "0x4DCE890", VA = "0x184DCF490", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x397A400", Offset = "0x3979800", VA = "0x18397A400", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public DHBGPLGHDGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class POCPNAENGOG<T> : IMKLMBNMCPA<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F243B0", Offset = "0x3F237B0", VA = "0x183F243B0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F24490", Offset = "0x3F23890", VA = "0x183F24490", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F24420", Offset = "0x3F23820", VA = "0x183F24420", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x397A400", Offset = "0x3979800", VA = "0x18397A400", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public POCPNAENGOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JHPIODHCALM<T> : IMKLMBNMCPA<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3468120", Offset = "0x3467520", VA = "0x183468120", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3468200", Offset = "0x3467600", VA = "0x183468200", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38FE5C0", Offset = "0x38FD9C0", VA = "0x1838FE5C0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x34680C0", Offset = "0x34674C0", VA = "0x1834680C0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public JHPIODHCALM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FHEBHDPGFAB<T> : IMKLMBNMCPA<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3468120", Offset = "0x3467520", VA = "0x183468120", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3468200", Offset = "0x3467600", VA = "0x183468200", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3468190", Offset = "0x3467590", VA = "0x183468190", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x34680C0", Offset = "0x34674C0", VA = "0x1834680C0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public FHEBHDPGFAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CBBOIIFDECE<T> : IMKLMBNMCPA<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x471D810", Offset = "0x471CC10", VA = "0x18471D810", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x471D8F0", Offset = "0x471CCF0", VA = "0x18471D8F0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x471D880", Offset = "0x471CC80", VA = "0x18471D880", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x373F270", Offset = "0x373E670", VA = "0x18373F270", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public CBBOIIFDECE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KFMJGFNNACA<T> : IMKLMBNMCPA<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x397A460", Offset = "0x3979860", VA = "0x18397A460", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x397A540", Offset = "0x3979940", VA = "0x18397A540", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x397A4D0", Offset = "0x39798D0", VA = "0x18397A4D0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x397A400", Offset = "0x3979800", VA = "0x18397A400", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public KFMJGFNNACA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JHJKNFFOHIH<T> : IMKLMBNMCPA<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x38F2720", Offset = "0x38F1B20", VA = "0x1838F2720", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x38F2800", Offset = "0x38F1C00", VA = "0x1838F2800", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x38F2790", Offset = "0x38F1B90", VA = "0x1838F2790", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x34680C0", Offset = "0x34674C0", VA = "0x1834680C0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x30F7F00", Offset = "0x30F7300", VA = "0x1830F7F00")]
		public JHJKNFFOHIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CFEAOGGFBJK<T> : GCDICLOBCEK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4806EE0", Offset = "0x48062E0", VA = "0x184806EE0", Slot = "12")]
		protected override void MHGHEMBAOKP(NKDDHCBCMJM IKENEDAFBLJ, char BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4806EB0", Offset = "0x48062B0", VA = "0x184806EB0", Slot = "11")]
		protected override void FHKBANAAACP(DGEBGJIOIGP BCPCCCLDBKN, [Out] char BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x35D01C0", Offset = "0x35CF5C0", VA = "0x1835D01C0")]
		public CFEAOGGFBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JJKEKODCPFD<T> : GCDICLOBCEK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3905540", Offset = "0x3904940", VA = "0x183905540", Slot = "12")]
		protected override void MHGHEMBAOKP(NKDDHCBCMJM IKENEDAFBLJ, IPEndPoint BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3905500", Offset = "0x3904900", VA = "0x183905500", Slot = "11")]
		protected override void FHKBANAAACP(DGEBGJIOIGP BCPCCCLDBKN, [Out] IPEndPoint BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x35D01C0", Offset = "0x35CF5C0", VA = "0x1835D01C0")]
		public JJKEKODCPFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class KPEGBEAMELL<T> : IMKLMBNMCPA<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int IBGFKIEEPCO;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39F4400", Offset = "0x39F3800", VA = "0x1839F4400")]
		public KPEGBEAMELL(int MEHPPAAAOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39F42B0", Offset = "0x39F36B0", VA = "0x1839F42B0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39F4390", Offset = "0x39F3790", VA = "0x1839F4390", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39F4320", Offset = "0x39F3720", VA = "0x1839F4320", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39F4240", Offset = "0x39F3640", VA = "0x1839F4240", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class MOKEAFNCLJC<T> : GKOPMMNDAIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo ALLHHEPEDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type IGLDLKBBHLL;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1580", Offset = "0x3CE0980", VA = "0x183CE1580")]
		public MOKEAFNCLJC(PropertyInfo PGPOOACGDAP, Type DICJBAPHIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE12F0", Offset = "0x3CE06F0", VA = "0x183CE12F0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CE14D0", Offset = "0x3CE08D0", VA = "0x183CE14D0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE13B0", Offset = "0x3CE07B0", VA = "0x183CE13B0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1290", Offset = "0x3CE0690", VA = "0x183CE1290", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1470", Offset = "0x3CE0870", VA = "0x183CE1470", Slot = "9")]
		public override void OIDIPBCAJNM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1410", Offset = "0x3CE0810", VA = "0x183CE1410", Slot = "10")]
		public override void MDHAJPHGILI(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class JHMFJPBOEED<T> : MOKEAFNCLJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529A70", VA = "0x18352A670")]
		public JHMFJPBOEED(PropertyInfo PGPOOACGDAP, Type DICJBAPHIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x38F2860", Offset = "0x38F1C60", VA = "0x1838F2860", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x38F2920", Offset = "0x38F1D20", VA = "0x1838F2920", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class DFBJJEBBBLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static DFBJJEBBBLA<T> NMGLFNHIICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly GKOPMMNDAIE<T>[] DHDJOBCPAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int OAEKOEJOFBH;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB270", Offset = "0x4DBA670", VA = "0x184DBB270")]
		public DFBJJEBBBLA(List<GKOPMMNDAIE<T>> CPJKDNEAKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB1C0", Offset = "0x4DBA5C0", VA = "0x184DBB1C0")]
		public void OMAJEIBBGKE(T ECLCDMJMICA, NKDDHCBCMJM EKCFHKIKCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB110", Offset = "0x4DBA510", VA = "0x184DBB110")]
		public void FHJDGHDGGLM(T ECLCDMJMICA, DGEBGJIOIGP PCDAGGPDBLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class DIEABFMCKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract GKOPMMNDAIE<T> EHGHEBAOCHM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private NKDDHCBCMJM MFBPNCDGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int KOHDCOLJDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, DIEABFMCKMD> GELJAMJOMHP;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5347CB0", Offset = "0x53470B0", VA = "0x185347CB0")]
	public NFEPFPCPJLE(int NEHBDOKIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x26272E0", Offset = "0x26266E0", VA = "0x1826272E0")]
	private DFBJJEBBBLA<T> OEAAMNDBLNN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x234C640", Offset = "0x234BA40", VA = "0x18234C640")]
	public void CNJGKMHEDKP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2627260", Offset = "0x2626660", VA = "0x182627260")]
	public bool JKMDPBEAKHM<T>(DGEBGJIOIGP PCDAGGPDBLK, T OPJDDCOPPHE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2627200", Offset = "0x2626600", VA = "0x182627200")]
	public void ALIOEPOJFBC<T>(NKDDHCBCMJM EKCFHKIKCOP, T ECLCDMJMICA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MDIOLJJNKAE
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime NDMIPGAAHLN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] OEHOAEJJBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PINOHCJJCLL HDCNEFBKFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x53468F0", Offset = "0x5345CF0", VA = "0x1853468F0")]
		get
		{
			return default(PINOHCJJCLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MAPOGMAIFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5346420", Offset = "0x5345820", VA = "0x185346420")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x53468B0", Offset = "0x5345CB0", VA = "0x1853468B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DLHIOCMKPGG DDCNFEIPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x53463F0", Offset = "0x53457F0", VA = "0x1853463F0")]
		get
		{
			return default(DLHIOCMKPGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5346B20", Offset = "0x5345F20", VA = "0x185346B20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BONABOCNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5346880", Offset = "0x5345C80", VA = "0x185346880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint DJDEGMKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5346480", Offset = "0x5345880", VA = "0x185346480")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? DNBPAKILOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5345E90", Offset = "0x5345290", VA = "0x185345E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? NLDHMJJHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5346450", Offset = "0x5345850", VA = "0x185346450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? AFOHPAGCCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5345EC0", Offset = "0x53452C0", VA = "0x185345EC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x53466B0", Offset = "0x5345AB0", VA = "0x1853466B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KANPAOECABN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x839C80", Offset = "0x839080", VA = "0x180839C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5346E40", Offset = "0x5346240", VA = "0x185346E40")]
	public MDIOLJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5346D90", Offset = "0x5346190", VA = "0x185346D90")]
	internal MDIOLJJNKAE(byte[] HPGJIANHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5346590", Offset = "0x5345990", VA = "0x185346590")]
	public static MDIOLJJNKAE LMIHCCKEHFK(byte[] HPGJIANHJNN, DateTime JKIPGBBKHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5346920", Offset = "0x5345D20", VA = "0x185346920")]
	internal void MHCNKOCBNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5345FC0", Offset = "0x53453C0", VA = "0x185345FC0")]
	private void FGGPCFFCIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5346190", Offset = "0x5345590", VA = "0x185346190")]
	private DateTime? GANLCDJNLGM(int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5346B60", Offset = "0x5345F60", VA = "0x185346B60")]
	private void PANDPCJCIAK(int ELJAGIMMLLH, DateTime? NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5345EF0", Offset = "0x53452F0", VA = "0x185345EF0")]
	private ulong FBAPLEMDPFD(int ELJAGIMMLLH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5345DD0", Offset = "0x53451D0", VA = "0x185345DD0")]
	private void CLFAJDIPEGH(int ELJAGIMMLLH, ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5346500", Offset = "0x5345900", VA = "0x185346500")]
	private uint JKBNGNLAFIE(int ELJAGIMMLLH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x52235E0", Offset = "0x52229E0", VA = "0x1852235E0")]
	private static uint GBMKHIAGFEJ(uint OPHKAEHAFCM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5346390", Offset = "0x5345790", VA = "0x185346390")]
	private static ulong GBMKHIAGFEJ(ulong OPHKAEHAFCM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum PINOHCJJCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum DLHIOCMKPGG
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class MOEFJMPCNNC
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int OMMJDGCHPKP = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int CJBIKIPLEEC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int FBFNKAACKFL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint PEFNHOLLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int HOGJBJHFJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int OKGJFHAAHMN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KGJNMBBJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5347CA0", Offset = "0x53470A0", VA = "0x185347CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5347BC0", Offset = "0x5346FC0", VA = "0x185347BC0")]
	public bool HAKPDOBLJOI(Socket HAECPOBJMFG, int EMHCHPDFFJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HCBCNDHGJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int BEENBIGLANE;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
	protected HCBCNDHGJCG(int FCPJJNJHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CODDIAFHJLO(IPEndPoint KMGGGJHMHEB, byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GGLEBNGEAEP(IPEndPoint KMGGGJHMHEB, byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NHJPFOCPAGP : HCBCNDHGJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider DCGIBBKNOOF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator BCFIBKFJGJC;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5348AA0", Offset = "0x5347EA0", VA = "0x185348AA0")]
	public NHJPFOCPAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5348720", Offset = "0x5347B20", VA = "0x185348720")]
	public void KPBJNPJOOEK(IPEndPoint KMGGGJHMHEB, byte[] MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5348960", Offset = "0x5347D60", VA = "0x185348960")]
	public void MCGENHPFHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5348690", Offset = "0x5347A90", VA = "0x185348690")]
	private byte[] KOFIHODFCEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5347F30", Offset = "0x5347330", VA = "0x185347F30", Slot = "4")]
	public override void CODDIAFHJLO(IPEndPoint KMGGGJHMHEB, byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x53482F0", Offset = "0x53476F0", VA = "0x1853482F0", Slot = "5")]
	public override void GGLEBNGEAEP(IPEndPoint KMGGGJHMHEB, byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO)
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
