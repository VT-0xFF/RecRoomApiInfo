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
			[Cpp2IlInjected.Address(RVA = "0x5341E10", Offset = "0x5341210", VA = "0x185341E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5341310", Offset = "0x5340710", VA = "0x185341310")]
		public void RecRoom_SetEncryptionInfo(ulong FEELILKLEAK, byte[] MIMFBLPNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53412F0", Offset = "0x53406F0", VA = "0x1853412F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53411C0", Offset = "0x53405C0", VA = "0x1853411C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5341D10", Offset = "0x5341110", VA = "0x185341D10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5341510", Offset = "0x5340910", VA = "0x185341510", Slot = "6")]
		public override void Send(ulong BANBPKAHABN, ArraySegment<byte> KKOACPFFAML, NetworkDelivery GPKJDAHLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x53412B0", Offset = "0x53406B0", VA = "0x1853412B0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BANBPKAHABN, [Out] ArraySegment<byte> LJIMLOGOIHA, [Out] float AGJOFLENHPE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5341800", Offset = "0x5340C00", VA = "0x185341800", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5341C30", Offset = "0x5341030", VA = "0x185341C30", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5340690", Offset = "0x533FA90", VA = "0x185340690", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BANBPKAHABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5340540", Offset = "0x533F940", VA = "0x185340540", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5340D10", Offset = "0x5340110", VA = "0x185340D10", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BANBPKAHABN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5341790", Offset = "0x5340B90", VA = "0x185341790", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5340DB0", Offset = "0x53401B0", VA = "0x185340DB0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LHHODACHEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5340800", Offset = "0x533FC00", VA = "0x185340800")]
		private CGCAAOCEKOI FDFNKJAMHGC(NetworkDelivery LFLAEPCPMDG)
		{
			return default(CGCAAOCEKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5340930", Offset = "0x533FD30", VA = "0x185340930", Slot = "15")]
		private void FOOKEJAAJGO(MBFHHKAOMLO NFIGEELACAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5340FA0", Offset = "0x53403A0", VA = "0x185340FA0", Slot = "16")]
		private void MPFAEHBGOPO(MBFHHKAOMLO NFIGEELACAJ, NIHMDLKNDEN GHCLCEEBOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "17")]
		private void JBBFJCOOLNK(IPEndPoint KMGGGJHMHEB, SocketError JDCEKOPCGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5340A10", Offset = "0x533FE10", VA = "0x185340A10", Slot = "18")]
		private void GLGILPNFMDC(MBFHHKAOMLO NFIGEELACAJ, FDAJJNFDMKE PCDAGGPDBLK, byte PNEOBPJEKBM, CGCAAOCEKOI GGOPGAAHOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53410E0", Offset = "0x53404E0", VA = "0x1853410E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53408D0", Offset = "0x533FCD0", VA = "0x1853408D0", Slot = "21")]
		private void FIPNBMPAKLN(DOLMKPFKDFF JAFMNEFDFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5340F70", Offset = "0x5340370", VA = "0x185340F70")]
		private ulong JMMGAKBELPK(MBFHHKAOMLO NFIGEELACAJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53409F0", Offset = "0x533FDF0", VA = "0x1853409F0")]
		private static int GAMBONFFMFH(float IODAOFLOKJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5341D30", Offset = "0x5341130", VA = "0x185341D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x533D9B0", Offset = "0x533CDB0", VA = "0x18533D9B0")]
	protected EAKJPGEDAHB(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x533D8D0", Offset = "0x533CCD0", VA = "0x18533D8D0")]
	public void KEOOEAIFIIG(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x533D930", Offset = "0x533CD30", VA = "0x18533D930")]
	protected void LBAKPADBKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x533D890", Offset = "0x533CC90", VA = "0x18533D890")]
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
		[Cpp2IlInjected.Address(RVA = "0x896570", Offset = "0x895970", VA = "0x180896570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x533CCB0", Offset = "0x533C0B0", VA = "0x18533CCB0")]
	internal void AKFCIABPLAP(AEKJIIPHCAI IHECEOOLPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x533CD70", Offset = "0x533C170", VA = "0x18533CD70")]
	private bool JPIMCHLABNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x533CDA0", Offset = "0x533C1A0", VA = "0x18533CDA0")]
	internal DOLMKPFKDFF(IPEndPoint DKGJPPOHNMF, AEKJIIPHCAI CMACENCBHOP, DDKFPBIOIHC NLMJPNNDBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x533CD10", Offset = "0x533C110", VA = "0x18533CD10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5333B30", Offset = "0x5332F30", VA = "0x185333B30")]
	private AEKJIIPHCAI(long BPGACHNMGKF, byte IGJOLFKAFKP, int LNNMEKKDHOB, byte[] NDEGHLACJGH, DGEBGJIOIGP KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53338F0", Offset = "0x5332CF0", VA = "0x1853338F0")]
	public static int IIGKNCHELLK(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53336D0", Offset = "0x5332AD0", VA = "0x1853336D0")]
	public static AEKJIIPHCAI BELPAJLKCCE(EABIGJPJJNH CJFNEMBIFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5333950", Offset = "0x5332D50", VA = "0x185333950")]
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
	[Cpp2IlInjected.Address(RVA = "0x533DD90", Offset = "0x533D190", VA = "0x18533DD90")]
	private EGLDJIKDDOM(long BPGACHNMGKF, byte IGJOLFKAFKP, int DOBGDFBOPOJ, bool ECKHLDKBODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x533DA50", Offset = "0x533CE50", VA = "0x18533DA50")]
	public static EGLDJIKDDOM BELPAJLKCCE(EABIGJPJJNH CJFNEMBIFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x533DCA0", Offset = "0x533D0A0", VA = "0x18533DCA0")]
	public static EABIGJPJJNH LGIJNAEDLKN(long FNKKECBMMKF, byte NCKLKKGDGPC, int IAIGHICCIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x533DBA0", Offset = "0x533CFA0", VA = "0x18533DBA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5347D60", Offset = "0x5347160", VA = "0x185347D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5347C70", Offset = "0x5347070", VA = "0x185347C70", Slot = "4")]
	public bool Equals(NGGODIIJNNH LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5347CB0", Offset = "0x53470B0", VA = "0x185347CB0", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x533DDE0", Offset = "0x533D1E0", VA = "0x18533DDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x533E1D0", Offset = "0x533D5D0", VA = "0x18533E1D0")]
		public static extern int GNCHDIDPCFI(IntPtr ENJHLLMJPMA, [In][Out] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [Out] byte[] JKKPDONKFPC, [In][Out] int DKPPBHPCFGL);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x533E0F0", Offset = "0x533D4F0", VA = "0x18533E0F0")]
		internal static extern int ADJPFGDGCHI(IntPtr ENJHLLMJPMA, [In] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [In] byte[] JKKPDONKFPC, [In] int DKPPBHPCFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class HJINJJLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x533F740", Offset = "0x533EB40", VA = "0x18533F740")]
		public static extern int GNCHDIDPCFI(IntPtr ENJHLLMJPMA, [In][Out] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [Out] byte[] JKKPDONKFPC, [In][Out] int DKPPBHPCFGL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x533F660", Offset = "0x533EA60", VA = "0x18533F660")]
		internal static extern int ADJPFGDGCHI(IntPtr ENJHLLMJPMA, [In] byte[] IDHADLKCFHE, [In] int LFJAKODBOBM, [In] SocketFlags NGMIJMHIACL, [In] byte[] JKKPDONKFPC, [In] int DKPPBHPCFGL);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool INKENINLDLG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool AKHGGLMBBNM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> CBNFBMJMFID;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5349D50", Offset = "0x5349150", VA = "0x185349D50")]
	static OGMCNIEDLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x53498E0", Offset = "0x5348CE0", VA = "0x1853498E0")]
	public static int CANJIEBNFLK(IntPtr ENJHLLMJPMA, byte[] IDHADLKCFHE, int LFJAKODBOBM, byte[] JKKPDONKFPC, int DKPPBHPCFGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5349AD0", Offset = "0x5348ED0", VA = "0x185349AD0")]
	public static int GCGOLGGBICM(IntPtr ENJHLLMJPMA, byte[] IDHADLKCFHE, int LFJAKODBOBM, byte[] JKKPDONKFPC, int DKPPBHPCFGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5349C60", Offset = "0x5349060", VA = "0x185349C60")]
	public static SocketError GENMELAMDEK()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5349990", Offset = "0x5348D90", VA = "0x185349990")]
	public static SocketException FPHMNNJBNCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5349830", Offset = "0x5348C30", VA = "0x185349830")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5347690", Offset = "0x5346A90", VA = "0x185347690")]
	internal MIJGPCPCCCN(DDKFPBIOIHC HAECPOBJMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5347530", Offset = "0x5346930", VA = "0x185347530")]
	internal void NFPEHHKCLFG(IPEndPoint CPGFHNAONPN, EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25A8200", Offset = "0x25A7600", VA = "0x1825A8200")]
	private void HAKPDOBLJOI<T>(T CJFNEMBIFNC, IPEndPoint OPJDDCOPPHE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5347080", Offset = "0x5346480", VA = "0x185347080")]
	private void FBHMEKDIMEE(JGGKPPGCEGG CJAPEBOFGGF, IPEndPoint CPGFHNAONPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5347210", Offset = "0x5346610", VA = "0x185347210")]
	private void HKJGKMLCIBO(IGEIEDHIPND CJAPEBOFGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5347390", Offset = "0x5346790", VA = "0x185347390")]
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
	[Cpp2IlInjected.Address(RVA = "0x533E3B0", Offset = "0x533D7B0", VA = "0x18533E3B0")]
	public OALAJIADGGL(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EPLHFKEOKKL : OALAJIADGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x533E3B0", Offset = "0x533D7B0", VA = "0x18533E3B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53401A0", Offset = "0x533F5A0", VA = "0x1853401A0")]
	private static void GBFCDLJKNAJ(JGAEBDFKEJC LDJGOHMFEAN, string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5340430", Offset = "0x533F830", VA = "0x185340430")]
	internal static void IEHNPCAIDII(string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53403D0", Offset = "0x533F7D0", VA = "0x1853403D0")]
	internal static void HDPDCMILEMC(string DFBAIJNHOKM, params object[] IFILEFKNBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5340140", Offset = "0x533F540", VA = "0x185340140")]
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
	[Cpp2IlInjected.Address(RVA = "0x533E4E0", Offset = "0x533D8E0", VA = "0x18533E4E0")]
	internal FDAJJNFDMKE(DDKFPBIOIHC CHJDMKIKGKN, GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x533E3C0", Offset = "0x533D7C0", VA = "0x18533E3C0")]
	internal void EHKKJFMCKKD(EABIGJPJJNH CJFNEMBIFNC, int NDHNOKCKBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x533E430", Offset = "0x533D830", VA = "0x18533E430")]
	internal void IAEJOKPMJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x533E4B0", Offset = "0x533D8B0", VA = "0x18533E4B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x533F5C0", Offset = "0x533E9C0", VA = "0x18533F5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x533F880", Offset = "0x533EC80", VA = "0x18533F880", Slot = "4")]
		public bool Equals(IPEndPoint OPHKAEHAFCM, IPEndPoint CLGLFIMLHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DEF340", Offset = "0x4DEE740", VA = "0x184DEF340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x834930", Offset = "0x833D30", VA = "0x180834930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x834930", Offset = "0x833D30", VA = "0x180834930", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE60310", Offset = "0xE5F710", VA = "0x180E60310")]
		public ENOPAMJKIDI(MBFHHKAOMLO ENFHPFLKGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x533E310", Offset = "0x533D710", VA = "0x18533E310", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x533E360", Offset = "0x533D760", VA = "0x18533E360", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1252290", Offset = "0x1251690", VA = "0x181252290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x12522A0", Offset = "0x12516A0", VA = "0x1812522A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OFPCGGMFOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x150EC20", Offset = "0x150E020", VA = "0x18150EC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x150D8E0", Offset = "0x150CCE0", VA = "0x18150D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte BIBIPPLJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81DF80", Offset = "0x81D380", VA = "0x18081DF80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BEENBIGLANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5339790", Offset = "0x5338B90", VA = "0x185339790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short DFMKLENAGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5339B90", Offset = "0x5338F90", VA = "0x185339B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5339AF0", Offset = "0x5338EF0", VA = "0x185339AF0")]
	public void MLFJDMFEPJA(IPEndPoint KMGGGJHMHEB, byte[] MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x53346E0", Offset = "0x5333AE0", VA = "0x1853346E0")]
	public void ANPFNDKBBAA(IPEndPoint KMGGGJHMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5334E50", Offset = "0x5334250", VA = "0x185334E50")]
	private bool BFMFBOKKLFI(IPEndPoint KMGGGJHMHEB, [Out] MBFHHKAOMLO NFIGEELACAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5335C20", Offset = "0x5335020", VA = "0x185335C20")]
	private void FGCJEDOJLOA(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5339E20", Offset = "0x5339220", VA = "0x185339E20")]
	private void ONOLPICOBCG(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5339BC0", Offset = "0x5338FC0", VA = "0x185339BC0")]
	private void NOAKDKMGPJI(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x533BA10", Offset = "0x533AE10", VA = "0x18533BA10")]
	public DDKFPBIOIHC(JOBIBOEAAKM NLMJPNNDBFP, [Optional] HCBCNDHGJCG BBLPAOBDPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53367F0", Offset = "0x5335BF0", VA = "0x1853367F0")]
	internal void HCLDEFOKGEA(MBFHHKAOMLO BDKDGEJLOML, int OBABBKHBBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5337430", Offset = "0x5336830", VA = "0x185337430")]
	internal void KLJLBLEKALB(MBFHHKAOMLO BDKDGEJLOML, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5337270", Offset = "0x5336670", VA = "0x185337270")]
	internal void KIIJIPBCNJL(MBFHHKAOMLO NFIGEELACAJ, PAICNPLCKLN BKBNKNNDEMK, SocketError KNCMNHNMJAJ, EABIGJPJJNH LHEBENHACBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x533B000", Offset = "0x533A400", VA = "0x18533B000")]
	private void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ, PAICNPLCKLN BKBNKNNDEMK, SocketError KNCMNHNMJAJ, bool EHGFADNFMAI, byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK, EABIGJPJJNH LHEBENHACBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5334EE0", Offset = "0x53342E0", VA = "0x185334EE0")]
	private void BJNNPEFHPCJ(GBBBEBGIGKD.ILMJJAAMNJB LFLAEPCPMDG, [Optional] MBFHHKAOMLO NFIGEELACAJ, [Optional] IPEndPoint DKGJPPOHNMF, SocketError FIBEPNMHCEG = SocketError.Success, int OBABBKHBBFD = 0, PAICNPLCKLN FIBPMOHCFCA = PAICNPLCKLN.ConnectionFailed, [Optional] DOLMKPFKDFF EFBGJGEMOJH, CGCAAOCEKOI GGOPGAAHOAO = CGCAAOCEKOI.Unreliable, byte PNEOBPJEKBM = 0, [Optional] EABIGJPJJNH OEBGJOAODCP, [Optional] object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5337480", Offset = "0x5336880", VA = "0x185337480")]
	private void LCDFHNAOBCG(GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x53362B0", Offset = "0x53356B0", VA = "0x1853362B0")]
	internal void FPIFCDIAIAM(GBBBEBGIGKD MLBPICOABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x53397B0", Offset = "0x5338BB0", VA = "0x1853397B0")]
	private void MKFLOKFFOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x533B1A0", Offset = "0x533A5A0", VA = "0x18533B1A0")]
	private void PJJEDGPIFFE(int MOJBPAPPGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5334830", Offset = "0x5333C30", VA = "0x185334830")]
	internal MBFHHKAOMLO BEDLBICHNLJ(DOLMKPFKDFF JAFMNEFDFCM, byte[] AAPPFGIPNPP, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5336770", Offset = "0x5335B70", VA = "0x185336770")]
	private int GIHBEGNHGOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5337C40", Offset = "0x5337040", VA = "0x185337C40")]
	private void LFHDIBDKEDH(IPEndPoint DKGJPPOHNMF, MBFHHKAOMLO IHJMFPKIIPD, AEKJIIPHCAI HCPJIGHJGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5339E70", Offset = "0x5339270", VA = "0x185339E70")]
	private void OOAEGPMFEEM(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5336FB0", Offset = "0x53363B0", VA = "0x185336FB0")]
	internal void JIGFNDNAEMC(EABIGJPJJNH CJFNEMBIFNC, CGCAAOCEKOI EHEJGNENLFE, byte PNEOBPJEKBM, int NDHNOKCKBLN, MBFHHKAOMLO BDKDGEJLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5338DD0", Offset = "0x53381D0", VA = "0x185338DD0")]
	public bool MBHHAMKDCLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5338D30", Offset = "0x5338130", VA = "0x185338D30")]
	public bool MBHHAMKDCLO(IPAddress OIKAMDOOCNI, IPAddress HPENDKNEAIA, int NFEOBLPIHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5338D50", Offset = "0x5338150", VA = "0x185338D50")]
	public bool MBHHAMKDCLO(int NFEOBLPIHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53365D0", Offset = "0x53359D0", VA = "0x1853365D0")]
	public void GFCBLFIFIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53358F0", Offset = "0x5334CF0", VA = "0x1853358F0")]
	public MBFHHKAOMLO EAEPFHCKGOK(string PDCKLNFEACL, int NFEOBLPIHMD, string MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5335810", Offset = "0x5334C10", VA = "0x185335810")]
	public MBFHHKAOMLO EAEPFHCKGOK(string PDCKLNFEACL, int NFEOBLPIHMD, NKDDHCBCMJM ACHMHCBDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5335440", Offset = "0x5334840", VA = "0x185335440")]
	public MBFHHKAOMLO EAEPFHCKGOK(IPEndPoint OPJDDCOPPHE, NKDDHCBCMJM ACHMHCBDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53343B0", Offset = "0x53337B0", VA = "0x1853343B0")]
	public void AHNKAFMKLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53343C0", Offset = "0x53337C0", VA = "0x1853343C0")]
	public void AHNKAFMKLLA(bool LPILLENMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53363B0", Offset = "0x53357B0", VA = "0x1853363B0")]
	public void FPPJBGIMPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53364B0", Offset = "0x53358B0", VA = "0x1853364B0")]
	public void FPPJBGIMPBL(byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x533AF50", Offset = "0x533A350", VA = "0x18533AF50")]
	public void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x533B0E0", Offset = "0x533A4E0", VA = "0x18533B0E0")]
	public void PGBEHBMMCKF(MBFHHKAOMLO NFIGEELACAJ, byte[] KKOACPFFAML, int DFOEGCCLIEM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x533B830", Offset = "0x533AC30", VA = "0x18533B830", Slot = "4")]
	private IEnumerator<MBFHHKAOMLO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x533B8C0", Offset = "0x533ACC0", VA = "0x18533B8C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5336DE0", Offset = "0x53361E0", VA = "0x185336DE0")]
	private EABIGJPJJNH IKAFCAEJFOB(GOIJKDIBLPA PGPOOACGDAP, int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5336ED0", Offset = "0x53362D0", VA = "0x185336ED0")]
	private EABIGJPJJNH IKAFCAEJFOB(GOIJKDIBLPA PGPOOACGDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5335FC0", Offset = "0x53353C0", VA = "0x185335FC0")]
	internal EABIGJPJJNH FNBGLOKCGJN(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53395C0", Offset = "0x53389C0", VA = "0x1853395C0")]
	internal void MGGHNHCDAHE(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x533B950", Offset = "0x533AD50", VA = "0x18533B950")]
	static DDKFPBIOIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1252290", Offset = "0x1251690", VA = "0x181252290")]
	private bool KLNEECJHJNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5337340", Offset = "0x5336740", VA = "0x185337340")]
	private void KJHBJDMMIAO(IPEndPoint JBJCJAFFLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5335EE0", Offset = "0x53352E0", VA = "0x185335EE0")]
	private void FKFJIJOAOJD(IPEndPoint JBJCJAFFLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x53352A0", Offset = "0x53346A0", VA = "0x1853352A0")]
	private bool CHANKPLOPJI(SocketException LLKMJCLKBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53359D0", Offset = "0x5334DD0", VA = "0x1853359D0")]
	private void EFMEANDJCCN(Socket HAECPOBJMFG, EndPoint DKAIADCGGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x533ABC0", Offset = "0x5339FC0", VA = "0x18533ABC0")]
	private void OONMHCFOKBA(object IFHMBCKBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x533B4C0", Offset = "0x533A8C0", VA = "0x18533B4C0")]
	private void PMKEMPELAGH(object IFHMBCKBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5338DE0", Offset = "0x53381E0", VA = "0x185338DE0")]
	public bool MBHHAMKDCLO(IPAddress OIKAMDOOCNI, IPAddress HPENDKNEAIA, int NFEOBLPIHMD, bool ABPDBCNKNFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5336840", Offset = "0x5335C40", VA = "0x185336840")]
	private bool HKJCPCICEFJ(Socket HAECPOBJMFG, IPEndPoint JBJCJAFFLMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5339730", Offset = "0x5338B30", VA = "0x185339730")]
	internal int MHEGCJAIBDK(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x53380A0", Offset = "0x53374A0", VA = "0x1853380A0")]
	internal int MAIAOHHALCN(EABIGJPJJNH CJFNEMBIFNC, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53380E0", Offset = "0x53374E0", VA = "0x1853380E0")]
	internal int MAIAOHHALCN(byte[] KCFFPPIEBHH, int DFOEGCCLIEM, int HKIFHAEDDHO, IPEndPoint DKGJPPOHNMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5336180", Offset = "0x5335580", VA = "0x185336180")]
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
		[Cpp2IlInjected.Address(RVA = "0x533CFB0", Offset = "0x533C3B0", VA = "0x18533CFB0")]
		get
		{
			return default(GOIJKDIBLPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x533CF70", Offset = "0x533C370", VA = "0x18533CF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PFBHLMHBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x533D2C0", Offset = "0x533C6C0", VA = "0x18533D2C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x533D110", Offset = "0x533C510", VA = "0x18533D110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort HBEFCFMAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x533CEE0", Offset = "0x533C2E0", VA = "0x18533CEE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x533D150", Offset = "0x533C550", VA = "0x18533D150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool APPBGIKMLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x533D290", Offset = "0x533C690", VA = "0x18533D290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte AEKJOCKIIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x533CE10", Offset = "0x533C210", VA = "0x18533CE10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x533CF40", Offset = "0x533C340", VA = "0x18533CF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CBCNACKABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x533D330", Offset = "0x533C730", VA = "0x18533D330")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x533D390", Offset = "0x533C790", VA = "0x18533D390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort DIKKDMPMGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x533CE40", Offset = "0x533C240", VA = "0x18533CE40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x533D2F0", Offset = "0x533C6F0", VA = "0x18533D2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PNFPHAAJBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x533D3D0", Offset = "0x533C7D0", VA = "0x18533D3D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x533CEA0", Offset = "0x533C2A0", VA = "0x18533CEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x533D430", Offset = "0x533C830", VA = "0x18533D430")]
	static EABIGJPJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x533D0E0", Offset = "0x533C4E0", VA = "0x18533D0E0")]
	public void IECJLKJFIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x533D820", Offset = "0x533CC20", VA = "0x18533D820")]
	public EABIGJPJJNH(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x533D710", Offset = "0x533CB10", VA = "0x18533D710")]
	public EABIGJPJJNH(GOIJKDIBLPA PGPOOACGDAP, int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x533D190", Offset = "0x533C590", VA = "0x18533D190")]
	public static int KKCCBCAGJEK(GOIJKDIBLPA PGPOOACGDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x533D200", Offset = "0x533C600", VA = "0x18533D200")]
	public int KKCCBCAGJEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x533CFE0", Offset = "0x533C3E0", VA = "0x18533CFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81DF70", Offset = "0x81D370", VA = "0x18081DF70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x53438B0", Offset = "0x5342CB0", VA = "0x1853438B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint NLOJBHCJMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x964290", Offset = "0x963690", VA = "0x180964290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LEDHEMIFPIE HOPDNHNGGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1074AC0", Offset = "0x1073EC0", VA = "0x181074AC0")]
		get
		{
			return default(LEDHEMIFPIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KOGLDDCFKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92F050", Offset = "0x92E450", VA = "0x18092F050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EGEMAMDNEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x150EC30", Offset = "0x150E030", VA = "0x18150EC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x150DB50", Offset = "0x150CF50", VA = "0x18150DB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HJNMHIHBCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x53438A0", Offset = "0x5342CA0", VA = "0x1853438A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1702000", Offset = "0x1701400", VA = "0x181702000")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OPDHKDPOEOL LEFACEJIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5342320", Offset = "0x5341720", VA = "0x185342320")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5342270", Offset = "0x5341670", VA = "0x185342270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5345520", Offset = "0x5344920", VA = "0x185345520")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, IPEndPoint DKGJPPOHNMF, int EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5343880", Offset = "0x5342C80", VA = "0x185343880")]
	internal void IGEBCEBNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x53449B0", Offset = "0x5343DB0", VA = "0x1853449B0")]
	internal void LPKIOMJOJKF(IPEndPoint JEFEIGCMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5343790", Offset = "0x5342B90", VA = "0x185343790")]
	internal void FEHLKCMPDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5341E30", Offset = "0x5341230", VA = "0x185341E30")]
	private void AAKCEOCFKNP(int MEIHADHNHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5343850", Offset = "0x5342C50", VA = "0x185343850")]
	private void HEJGGDIDKMF(int PANPJCNOPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5345370", Offset = "0x5344770", VA = "0x185345370")]
	private EAKJPGEDAHB OJGPOKFAADO(byte DMMFKFNAHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5345980", Offset = "0x5344D80", VA = "0x185345980")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, IPEndPoint DKGJPPOHNMF, int EPDCALNHKAP, byte NCKLKKGDGPC, NKDDHCBCMJM KIGIDKIPANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5345B10", Offset = "0x5344F10", VA = "0x185345B10")]
	internal MBFHHKAOMLO(DDKFPBIOIHC DEJEGIHJBNB, DOLMKPFKDFF JAFMNEFDFCM, int EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5343960", Offset = "0x5342D60", VA = "0x185343960")]
	internal void KAHKKMHFFMM(AEKJIIPHCAI BFLBBAPGDDN, byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5342580", Offset = "0x5341980", VA = "0x185342580")]
	internal bool CKEHFCJFEFA(EGLDJIKDDOM CJFNEMBIFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5343820", Offset = "0x5342C20", VA = "0x185343820")]
	public void HAKPDOBLJOI(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, CGCAAOCEKOI AHMINIDFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5342C70", Offset = "0x5342070", VA = "0x185342C70")]
	private void ECBJPHBEAFN(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, byte PNEOBPJEKBM, CGCAAOCEKOI GGOPGAAHOAO, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x53440C0", Offset = "0x53434C0", VA = "0x1853440C0")]
	public void KKINBLMALBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5342B90", Offset = "0x5341F90", VA = "0x185342B90")]
	internal HHBNCOMLHPG EALEMFAGCIH(EABIGJPJJNH CJFNEMBIFNC)
	{
		return default(HHBNCOMLHPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5344060", Offset = "0x5343460", VA = "0x185344060")]
	internal void KCBCBONMEDL(EAKJPGEDAHB KBDDHPFEGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53431C0", Offset = "0x53425C0", VA = "0x1853431C0")]
	internal GIBOAGFBANP ECEOCBLDGMJ(byte[] KKOACPFFAML, int DFOEGCCLIEM, int HKIFHAEDDHO, bool EHGFADNFMAI)
	{
		return default(GIBOAGFBANP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5342B50", Offset = "0x5341F50", VA = "0x185342B50")]
	private void DAFIJGDMBHP(int JHBFBNPKEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x53449E0", Offset = "0x5343DE0", VA = "0x1853449E0")]
	internal void NIOHJHNCILM(CGCAAOCEKOI EHEJGNENLFE, EABIGJPJJNH ENFHPFLKGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5342600", Offset = "0x5341A00", VA = "0x185342600")]
	private void CPIICBOINLM(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5341F00", Offset = "0x5341300", VA = "0x185341F00")]
	private void AINEABDLBHH(int EMIPGAHFJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5344170", Offset = "0x5343570", VA = "0x185344170")]
	internal NAJLNJAOHDF LFHDIBDKEDH(AEKJIIPHCAI HCPJIGHJGKK)
	{
		return default(NAJLNJAOHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x53439B0", Offset = "0x5342DB0", VA = "0x1853439B0")]
	internal void KBIKGIDCIKC(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x53448B0", Offset = "0x5343CB0", VA = "0x1853448B0")]
	private void LNFOCOHHJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53423D0", Offset = "0x53417D0", VA = "0x1853423D0")]
	internal void CHHOPOLFNEM(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5344330", Offset = "0x5343730", VA = "0x185344330")]
	internal void LFKJJNEOHNN(int EMIPGAHFJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x53434D0", Offset = "0x53428D0", VA = "0x1853434D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5333C00", Offset = "0x5333000", VA = "0x185333C00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KAHMDEGLBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5333C30", Offset = "0x5333030", VA = "0x185333C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LHHCHNGIAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5333C40", Offset = "0x5333040", VA = "0x185333C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KMGDBPFOGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5333C20", Offset = "0x5333020", VA = "0x185333C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long JCPKCAGLEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5333CA0", Offset = "0x53330A0", VA = "0x185333CA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CBJNNFGPPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5333CB0", Offset = "0x53330B0", VA = "0x185333CB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5333C90", Offset = "0x5333090", VA = "0x185333C90")]
	public void IKKBIKDCDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5333C70", Offset = "0x5333070", VA = "0x185333C70")]
	public void HAHINIKAEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5333C50", Offset = "0x5333050", VA = "0x185333C50")]
	public void DDOHGIJBKPP(long IOMBAJNIHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5333C80", Offset = "0x5333080", VA = "0x185333C80")]
	public void HKLJEKOHBAO(long GOOAOGEGPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5333C60", Offset = "0x5333060", VA = "0x185333C60")]
	public void EHKIPPBGOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5333C10", Offset = "0x5333010", VA = "0x185333C10")]
	public void AODHBKCNDPM(long DCHEHJFMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5333D00", Offset = "0x5333100", VA = "0x185333D00", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x533FBD0", Offset = "0x533EFD0", VA = "0x18533FBD0")]
	public static IPEndPoint FHKKINCJILO(string IKNBFHIDGJH, int NFEOBLPIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x533FE50", Offset = "0x533F250", VA = "0x18533FE50")]
	public static IPAddress PBIHPDOHBLH(string IKNBFHIDGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5340020", Offset = "0x533F420", VA = "0x185340020")]
	public static IPAddress PBIHPDOHBLH(string IKNBFHIDGJH, AddressFamily JCMCHPIEFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x533FE20", Offset = "0x533F220", VA = "0x18533FE20")]
	internal static int JDBEHMNDNCA(int LJGBMIIMMGB, int KOGDJLCHGNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x25810A0", Offset = "0x25804A0", VA = "0x1825810A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x533FB30", Offset = "0x533EF30", VA = "0x18533FB30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x533FAA0", Offset = "0x533EEA0", VA = "0x18533FAA0")]
		public void IOFGIHBGGGP(EABIGJPJJNH CJFNEMBIFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x533FAC0", Offset = "0x533EEC0", VA = "0x18533FAC0")]
		public bool KGNCBAFCJHF(long JOANGLMKMAI, MBFHHKAOMLO NFIGEELACAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x533FA50", Offset = "0x533EE50", VA = "0x18533FA50")]
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
	[Cpp2IlInjected.Address(RVA = "0x533F3F0", Offset = "0x533E7F0", VA = "0x18533F3F0")]
	public FIHFLDJHICF(MBFHHKAOMLO NFIGEELACAJ, bool CCCLBENIDIJ, byte EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x533E530", Offset = "0x533D930", VA = "0x18533E530")]
	private void DLOGDMFENHJ(EABIGJPJJNH CJFNEMBIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x533EF40", Offset = "0x533E340", VA = "0x18533EF40", Slot = "4")]
	protected override bool PKOCPKGMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x533E8E0", Offset = "0x533DCE0", VA = "0x18533E8E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x534AB00", Offset = "0x5349F00", VA = "0x18534AB00")]
	public OGNEMFPGBCC(MBFHHKAOMLO NFIGEELACAJ, bool EAHLMFCLMJM, byte EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x534A690", Offset = "0x5349A90", VA = "0x18534A690", Slot = "4")]
	protected override bool PKOCPKGMFEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x534A3B0", Offset = "0x53497B0", VA = "0x18534A3B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5333540", Offset = "0x5332940", VA = "0x185333540")]
	private static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, ulong KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x533F970", Offset = "0x533ED70", VA = "0x18533F970")]
	private static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, int KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x533FA00", Offset = "0x533EE00", VA = "0x18533FA00")]
	public static void NNOGOHFFEHC(byte[] PNJHGINLCID, int ELJAGIMMLLH, short KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x533F9E0", Offset = "0x533EDE0", VA = "0x18533F9E0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x533F8F0", Offset = "0x533ECF0", VA = "0x18533F8F0")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x533FA00", Offset = "0x533EE00", VA = "0x18533FA00")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x533FA00", Offset = "0x533EE00", VA = "0x18533FA00")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x533F970", Offset = "0x533ED70", VA = "0x18533F970")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x533F970", Offset = "0x533ED70", VA = "0x18533F970")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x533FA40", Offset = "0x533EE40", VA = "0x18533FA40")]
	public static void BKJAGJEBDAE(byte[] HPGJIANHJNN, int HHKMAFFMIKG, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x533FA40", Offset = "0x533EE40", VA = "0x18533FA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GBHEDPLGOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x533CC00", Offset = "0x533C000", VA = "0x18533CC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ECEGCMEACIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB4A0", Offset = "0x1BFA8A0", VA = "0x181BFB4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CFNAGIEDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x533C060", Offset = "0x533B460", VA = "0x18533C060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x533C370", Offset = "0x533B770", VA = "0x18533C370")]
	public void EHKKJFMCKKD(byte[] HFLNDIDMJFD, int ELJAGIMMLLH, int NHHADKDNGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DGEBGJIOIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x533CC50", Offset = "0x533C050", VA = "0x18533CC50")]
	public DGEBGJIOIGP(byte[] HFLNDIDMJFD, int ELJAGIMMLLH, int NHHADKDNGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x533C9C0", Offset = "0x533BDC0", VA = "0x18533C9C0")]
	public IPEndPoint KFBDJCPBEOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x533C200", Offset = "0x533B600", VA = "0x18533C200")]
	public byte CHCNGBCKDJK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x533C200", Offset = "0x533B600", VA = "0x18533C200")]
	public sbyte MKPDABGPDGA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2375A50", Offset = "0x2374E50", VA = "0x182375A50")]
	public T[] PPBOMBOJOII<T>(ushort PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x533C460", Offset = "0x533B860", VA = "0x18533C460")]
	public bool[] GPBHCNKKEDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x533CB40", Offset = "0x533BF40", VA = "0x18533CB40")]
	public ushort[] MONGNNIKCAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x533C0E0", Offset = "0x533B4E0", VA = "0x18533C0E0")]
	public short[] AMDHOIBLDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x533CB80", Offset = "0x533BF80", VA = "0x18533CB80")]
	public int[] NFDAOFGIBOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x533CB00", Offset = "0x533BF00", VA = "0x18533CB00")]
	public uint[] MJFJABFPCNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x533C2F0", Offset = "0x533B6F0", VA = "0x18533C2F0")]
	public float[] DAMBOKHFOKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x533C3B0", Offset = "0x533B7B0", VA = "0x18533C3B0")]
	public double[] EKMEFOHCCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x533CBC0", Offset = "0x533BFC0", VA = "0x18533CBC0")]
	public long[] OAGMDCNMBAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x533C330", Offset = "0x533B730", VA = "0x18533C330")]
	public ulong[] EFEDGLPADKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x533C550", Offset = "0x533B950", VA = "0x18533C550")]
	public string[] HPMGHCCCEHI(int NEHBDOKIPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x533C2B0", Offset = "0x533B6B0", VA = "0x18533C2B0")]
	public bool DALMPAODNLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x533C070", Offset = "0x533B470", VA = "0x18533C070")]
	public char NEFEDLJJGDD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x533C070", Offset = "0x533B470", VA = "0x18533C070")]
	public ushort ACNFNAMHNJP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x533C4E0", Offset = "0x533B8E0", VA = "0x18533C4E0")]
	public short HMOHDCKBHDD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x533C120", Offset = "0x533B520", VA = "0x18533C120")]
	public long BFMFDOELOPE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x533C950", Offset = "0x533BD50", VA = "0x18533C950")]
	public ulong KBJFCKNBAEM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x533CA90", Offset = "0x533BE90", VA = "0x18533CA90")]
	public int KPMFIHDNFCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x533C190", Offset = "0x533B590", VA = "0x18533C190")]
	public uint BKPGELIKEEH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x533C3F0", Offset = "0x533B7F0", VA = "0x18533C3F0")]
	public float GIBNMALDPGA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x533C240", Offset = "0x533B640", VA = "0x18533C240")]
	public double CHPKKDEALDC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x533C710", Offset = "0x533BB10", VA = "0x18533C710")]
	public string JKACOHPGJEJ(int MEHPPAAAOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x533C680", Offset = "0x533BA80", VA = "0x18533C680")]
	public ArraySegment<byte> IIBGOPJFIFN(int APAKJDHFMCK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x533C4A0", Offset = "0x533B8A0", VA = "0x18533C4A0")]
	public sbyte[] HDGFEPMCDBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x533CC10", Offset = "0x533C010", VA = "0x18533CC10")]
	public byte[] PHBDDGICODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x533C6F0", Offset = "0x533BAF0", VA = "0x18533C6F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5349710", Offset = "0x5348B10", VA = "0x185349710")]
	public NKDDHCBCMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5349790", Offset = "0x5348B90", VA = "0x185349790")]
	public NKDDHCBCMJM(bool ELJFLBDLKNH, int LJFEOIBMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5348AC0", Offset = "0x5347EC0", VA = "0x185348AC0")]
	public static NKDDHCBCMJM BDKOICDHAKE(string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5348B30", Offset = "0x5347F30", VA = "0x185348B30")]
	public void DCBAEJHLKEC(int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C74DA0", Offset = "0x1C741A0", VA = "0x181C74DA0")]
	public void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5349190", Offset = "0x5348590", VA = "0x185349190")]
	public void KKEPNBBHLIP(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5349070", Offset = "0x5348470", VA = "0x185349070")]
	public void KKEPNBBHLIP(double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5348FB0", Offset = "0x53483B0", VA = "0x185348FB0")]
	public void KKEPNBBHLIP(long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5348FB0", Offset = "0x53483B0", VA = "0x185348FB0")]
	public void KKEPNBBHLIP(ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5348BD0", Offset = "0x5347FD0", VA = "0x185348BD0")]
	public void KKEPNBBHLIP(int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5348BD0", Offset = "0x5347FD0", VA = "0x185348BD0")]
	public void KKEPNBBHLIP(uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5349000", Offset = "0x5348400", VA = "0x185349000")]
	public void KKEPNBBHLIP(char NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5349000", Offset = "0x5348400", VA = "0x185349000")]
	public void KKEPNBBHLIP(ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5349000", Offset = "0x5348400", VA = "0x185349000")]
	public void KKEPNBBHLIP(short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5348ED0", Offset = "0x53482D0", VA = "0x185348ED0")]
	public void KKEPNBBHLIP(sbyte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5348ED0", Offset = "0x53482D0", VA = "0x185348ED0")]
	public void KKEPNBBHLIP(byte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5348F30", Offset = "0x5348330", VA = "0x185348F30")]
	public void KKEPNBBHLIP(byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53489E0", Offset = "0x5347DE0", VA = "0x1853489E0")]
	public void ALCHFNHKBBK(sbyte[] KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x53489E0", Offset = "0x5347DE0", VA = "0x1853489E0")]
	public void GCKIPCOAJNP(byte[] KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5348C60", Offset = "0x5348060", VA = "0x185348C60")]
	public void KKEPNBBHLIP(bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x53494C0", Offset = "0x53488C0", VA = "0x1853494C0")]
	public void MEJCIOGFACM(Array AGOLNOEJENC, int HICGFJOONML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x53493E0", Offset = "0x53487E0", VA = "0x1853493E0")]
	public void MEJCIOGFACM(float[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x53495A0", Offset = "0x53489A0", VA = "0x1853495A0")]
	public void MEJCIOGFACM(double[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53495A0", Offset = "0x53489A0", VA = "0x1853495A0")]
	public void MEJCIOGFACM(long[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x53495A0", Offset = "0x53489A0", VA = "0x1853495A0")]
	public void MEJCIOGFACM(ulong[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x53493E0", Offset = "0x53487E0", VA = "0x1853493E0")]
	public void MEJCIOGFACM(int[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53493E0", Offset = "0x53487E0", VA = "0x1853493E0")]
	public void MEJCIOGFACM(uint[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5349300", Offset = "0x5348700", VA = "0x185349300")]
	public void MEJCIOGFACM(ushort[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5349300", Offset = "0x5348700", VA = "0x185349300")]
	public void MEJCIOGFACM(short[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x53489E0", Offset = "0x5347DE0", VA = "0x1853489E0")]
	public void MEJCIOGFACM(bool[] NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5349230", Offset = "0x5348630", VA = "0x185349230")]
	public void MEJCIOGFACM(string[] NMENOOMOOJP, int IJAMBAIAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x53490C0", Offset = "0x53484C0", VA = "0x1853490C0")]
	public void KKEPNBBHLIP(IPEndPoint KMGGGJHMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5348FA0", Offset = "0x53483A0", VA = "0x185348FA0")]
	public void KKEPNBBHLIP(string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5348CC0", Offset = "0x53480C0", VA = "0x185348CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C99CD0", Offset = "0x3C990D0", VA = "0x183C99CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x472A160", Offset = "0x4729560", VA = "0x18472A160")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1C5C0", Offset = "0x3E1B9C0", VA = "0x183E1C5C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5334230", Offset = "0x5333630", VA = "0x185334230")]
	public DDFFMHHHNBO(int NEHBDOKIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
	protected virtual ulong MGFEGGGILHG<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x53340B0", Offset = "0x53334B0", VA = "0x1853340B0", Slot = "5")]
	protected virtual BDIBHGAKGDK MDMAIMENJOA(DGEBGJIOIGP PCDAGGPDBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2374BE0", Offset = "0x2373FE0", VA = "0x182374BE0", Slot = "6")]
	protected virtual void DLICNGMGGED<T>(NKDDHCBCMJM EKCFHKIKCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5334030", Offset = "0x5333430", VA = "0x185334030")]
	public void AELFKILMHMA(DGEBGJIOIGP PCDAGGPDBLK, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2374F50", Offset = "0x2374350", VA = "0x182374F50")]
	public void OMAJEIBBGKE<T>(NKDDHCBCMJM EKCFHKIKCOP, T CJFNEMBIFNC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x53341E0", Offset = "0x53335E0", VA = "0x1853341E0")]
	public void PHICKBDHDOM(DGEBGJIOIGP PCDAGGPDBLK, object HFKPLAJAIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2374DD0", Offset = "0x23741D0", VA = "0x182374DD0")]
	public void DPFOGHNHCNP<T>(Action<T> BEDDIJBHPBG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2374C50", Offset = "0x2374050", VA = "0x182374C50")]
	public void DPFOGHNHCNP<T, TUserData>(Action<T, TUserData> BEDDIJBHPBG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GOALPJBOOFN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x533E3B0", Offset = "0x533D7B0", VA = "0x18533E3B0")]
	public GOALPJBOOFN(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AOPIJDLMGMH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5333BA0", Offset = "0x5332FA0", VA = "0x185333BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3574040", Offset = "0x3573440", VA = "0x183574040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37642B0", Offset = "0x37636B0", VA = "0x1837642B0", Slot = "7")]
		public override void KMOLNJMFJNB(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x37612E0", Offset = "0x37606E0", VA = "0x1837612E0", Slot = "8")]
		public override void EDEGJCBPJGA(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3764E10", Offset = "0x3764210", VA = "0x183764E10", Slot = "9")]
		public override void OIDIPBCAJNM(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37648D0", Offset = "0x3763CD0", VA = "0x1837648D0", Slot = "10")]
		public override void MDHAJPHGILI(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37615F0", Offset = "0x37609F0", VA = "0x1837615F0")]
		protected TProperty[] HIBADHNMLEJ(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3761580", Offset = "0x3760980", VA = "0x183761580")]
		protected TProperty[] EIIJOBBMLIK(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3762DF0", Offset = "0x37621F0", VA = "0x183762DF0", Slot = "4")]
		public override void IOFGIHBGGGP(MethodInfo OCMFCGPEJIA, MethodInfo MKFMMFFKLPJ, BJFAPIMJDFD LFLAEPCPMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x35886C0", Offset = "0x3587AC0", VA = "0x1835886C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x352A060", Offset = "0x3529460", VA = "0x18352A060", Slot = "5")]
		public override void FHJDGHDGGLM(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x352A220", Offset = "0x3529620", VA = "0x18352A220", Slot = "6")]
		public override void OMAJEIBBGKE(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x352A0E0", Offset = "0x35294E0", VA = "0x18352A0E0", Slot = "7")]
		public override void KMOLNJMFJNB(TClass EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3529EA0", Offset = "0x35292A0", VA = "0x183529EA0", Slot = "8")]
		public override void EDEGJCBPJGA(TClass EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x352A300", Offset = "0x3529700", VA = "0x18352A300")]
		protected GCDICLOBCEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IECLGIPPDNN<T> : IMKLMBNMCPA<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3740880", Offset = "0x373FC80", VA = "0x183740880", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3740960", Offset = "0x373FD60", VA = "0x183740960", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x37408F0", Offset = "0x373FCF0", VA = "0x1837408F0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3740820", Offset = "0x373FC20", VA = "0x183740820", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public IECLGIPPDNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OBHNGPFMDMJ<T> : IMKLMBNMCPA<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9550", Offset = "0x3DE8950", VA = "0x183DE9550", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3740960", Offset = "0x373FD60", VA = "0x183740960", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE95C0", Offset = "0x3DE89C0", VA = "0x183DE95C0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3740820", Offset = "0x373FC20", VA = "0x183740820", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public OBHNGPFMDMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class EIBHEGCBFON<T> : IMKLMBNMCPA<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x30F93B0", Offset = "0x30F87B0", VA = "0x1830F93B0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x30F9490", Offset = "0x30F8890", VA = "0x1830F9490", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x30F9420", Offset = "0x30F8820", VA = "0x1830F9420", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x30F9350", Offset = "0x30F8750", VA = "0x1830F9350", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public EIBHEGCBFON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class IKHGDIBCIMN<T> : IMKLMBNMCPA<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x375DB00", Offset = "0x375CF00", VA = "0x18375DB00", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x30F9490", Offset = "0x30F8890", VA = "0x1830F9490", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x375DB70", Offset = "0x375CF70", VA = "0x18375DB70", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x30F9350", Offset = "0x30F8750", VA = "0x1830F9350", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public IKHGDIBCIMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DHBGPLGHDGO<T> : IMKLMBNMCPA<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF340", Offset = "0x4DCE740", VA = "0x184DCF340", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F258B0", Offset = "0x3F24CB0", VA = "0x183F258B0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DCF3B0", Offset = "0x4DCE7B0", VA = "0x184DCF3B0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x397B8F0", Offset = "0x397ACF0", VA = "0x18397B8F0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public DHBGPLGHDGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class POCPNAENGOG<T> : IMKLMBNMCPA<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F257D0", Offset = "0x3F24BD0", VA = "0x183F257D0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F258B0", Offset = "0x3F24CB0", VA = "0x183F258B0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F25840", Offset = "0x3F24C40", VA = "0x183F25840", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x397B8F0", Offset = "0x397ACF0", VA = "0x18397B8F0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public POCPNAENGOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JHPIODHCALM<T> : IMKLMBNMCPA<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3469870", Offset = "0x3468C70", VA = "0x183469870", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3469950", Offset = "0x3468D50", VA = "0x183469950", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38FFB70", Offset = "0x38FEF70", VA = "0x1838FFB70", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3469810", Offset = "0x3468C10", VA = "0x183469810", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public JHPIODHCALM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FHEBHDPGFAB<T> : IMKLMBNMCPA<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3469870", Offset = "0x3468C70", VA = "0x183469870", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3469950", Offset = "0x3468D50", VA = "0x183469950", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x34698E0", Offset = "0x3468CE0", VA = "0x1834698E0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3469810", Offset = "0x3468C10", VA = "0x183469810", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public FHEBHDPGFAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CBBOIIFDECE<T> : IMKLMBNMCPA<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x471EC30", Offset = "0x471E030", VA = "0x18471EC30", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x471ED10", Offset = "0x471E110", VA = "0x18471ED10", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x471ECA0", Offset = "0x471E0A0", VA = "0x18471ECA0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3740820", Offset = "0x373FC20", VA = "0x183740820", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public CBBOIIFDECE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KFMJGFNNACA<T> : IMKLMBNMCPA<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x397B950", Offset = "0x397AD50", VA = "0x18397B950", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x397BA30", Offset = "0x397AE30", VA = "0x18397BA30", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x397B9C0", Offset = "0x397ADC0", VA = "0x18397B9C0", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x397B8F0", Offset = "0x397ACF0", VA = "0x18397B8F0", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public KFMJGFNNACA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JHJKNFFOHIH<T> : IMKLMBNMCPA<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x38F3CD0", Offset = "0x38F30D0", VA = "0x1838F3CD0", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x38F3DB0", Offset = "0x38F31B0", VA = "0x1838F3DB0", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x38F3D40", Offset = "0x38F3140", VA = "0x1838F3D40", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3469810", Offset = "0x3468C10", VA = "0x183469810", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x30F94F0", Offset = "0x30F88F0", VA = "0x1830F94F0")]
		public JHJKNFFOHIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CFEAOGGFBJK<T> : GCDICLOBCEK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4808300", Offset = "0x4807700", VA = "0x184808300", Slot = "12")]
		protected override void MHGHEMBAOKP(NKDDHCBCMJM IKENEDAFBLJ, char BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x48082D0", Offset = "0x48076D0", VA = "0x1848082D0", Slot = "11")]
		protected override void FHKBANAAACP(DGEBGJIOIGP BCPCCCLDBKN, [Out] char BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x35D1830", Offset = "0x35D0C30", VA = "0x1835D1830")]
		public CFEAOGGFBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JJKEKODCPFD<T> : GCDICLOBCEK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3906AF0", Offset = "0x3905EF0", VA = "0x183906AF0", Slot = "12")]
		protected override void MHGHEMBAOKP(NKDDHCBCMJM IKENEDAFBLJ, IPEndPoint BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3906AB0", Offset = "0x3905EB0", VA = "0x183906AB0", Slot = "11")]
		protected override void FHKBANAAACP(DGEBGJIOIGP BCPCCCLDBKN, [Out] IPEndPoint BNFBAEJHPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x35D1830", Offset = "0x35D0C30", VA = "0x1835D1830")]
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
		[Cpp2IlInjected.Address(RVA = "0x39F5870", Offset = "0x39F4C70", VA = "0x1839F5870")]
		public KPEGBEAMELL(int MEHPPAAAOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39F5720", Offset = "0x39F4B20", VA = "0x1839F5720", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39F5800", Offset = "0x39F4C00", VA = "0x1839F5800", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39F5790", Offset = "0x39F4B90", VA = "0x1839F5790", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39F56B0", Offset = "0x39F4AB0", VA = "0x1839F56B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CE2A20", Offset = "0x3CE1E20", VA = "0x183CE2A20")]
		public MOKEAFNCLJC(PropertyInfo PGPOOACGDAP, Type DICJBAPHIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2790", Offset = "0x3CE1B90", VA = "0x183CE2790", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2970", Offset = "0x3CE1D70", VA = "0x183CE2970", Slot = "6")]
		public override void OMAJEIBBGKE(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2850", Offset = "0x3CE1C50", VA = "0x183CE2850", Slot = "7")]
		public override void KMOLNJMFJNB(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2730", Offset = "0x3CE1B30", VA = "0x183CE2730", Slot = "8")]
		public override void EDEGJCBPJGA(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2910", Offset = "0x3CE1D10", VA = "0x183CE2910", Slot = "9")]
		public override void OIDIPBCAJNM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CE28B0", Offset = "0x3CE1CB0", VA = "0x183CE28B0", Slot = "10")]
		public override void MDHAJPHGILI(T EKDMABPBMOK, NKDDHCBCMJM IKENEDAFBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class JHMFJPBOEED<T> : MOKEAFNCLJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x352BD60", Offset = "0x352B160", VA = "0x18352BD60")]
		public JHMFJPBOEED(PropertyInfo PGPOOACGDAP, Type DICJBAPHIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x38F3E10", Offset = "0x38F3210", VA = "0x1838F3E10", Slot = "5")]
		public override void FHJDGHDGGLM(T EKDMABPBMOK, DGEBGJIOIGP BCPCCCLDBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x38F3ED0", Offset = "0x38F32D0", VA = "0x1838F3ED0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DBB190", Offset = "0x4DBA590", VA = "0x184DBB190")]
		public DFBJJEBBBLA(List<GKOPMMNDAIE<T>> CPJKDNEAKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB0E0", Offset = "0x4DBA4E0", VA = "0x184DBB0E0")]
		public void OMAJEIBBGKE(T ECLCDMJMICA, NKDDHCBCMJM EKCFHKIKCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB030", Offset = "0x4DBA430", VA = "0x184DBB030")]
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
	[Cpp2IlInjected.Address(RVA = "0x5347BD0", Offset = "0x5346FD0", VA = "0x185347BD0")]
	public NFEPFPCPJLE(int NEHBDOKIPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2627370", Offset = "0x2626770", VA = "0x182627370")]
	private DFBJJEBBBLA<T> OEAAMNDBLNN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x234C6F0", Offset = "0x234BAF0", VA = "0x18234C6F0")]
	public void CNJGKMHEDKP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x26272F0", Offset = "0x26266F0", VA = "0x1826272F0")]
	public bool JKMDPBEAKHM<T>(DGEBGJIOIGP PCDAGGPDBLK, T OPJDDCOPPHE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2627290", Offset = "0x2626690", VA = "0x182627290")]
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
		[Cpp2IlInjected.Address(RVA = "0x5346810", Offset = "0x5345C10", VA = "0x185346810")]
		get
		{
			return default(PINOHCJJCLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MAPOGMAIFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5346340", Offset = "0x5345740", VA = "0x185346340")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x53467D0", Offset = "0x5345BD0", VA = "0x1853467D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DLHIOCMKPGG DDCNFEIPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5346310", Offset = "0x5345710", VA = "0x185346310")]
		get
		{
			return default(DLHIOCMKPGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5346A40", Offset = "0x5345E40", VA = "0x185346A40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BONABOCNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x53467A0", Offset = "0x5345BA0", VA = "0x1853467A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint DJDEGMKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x53463A0", Offset = "0x53457A0", VA = "0x1853463A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? DNBPAKILOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5345DB0", Offset = "0x53451B0", VA = "0x185345DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? NLDHMJJHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5346370", Offset = "0x5345770", VA = "0x185346370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? AFOHPAGCCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5345DE0", Offset = "0x53451E0", VA = "0x185345DE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x53465D0", Offset = "0x53459D0", VA = "0x1853465D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KANPAOECABN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x839CC0", Offset = "0x8390C0", VA = "0x180839CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5346D60", Offset = "0x5346160", VA = "0x185346D60")]
	public MDIOLJJNKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5346CB0", Offset = "0x53460B0", VA = "0x185346CB0")]
	internal MDIOLJJNKAE(byte[] HPGJIANHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x53464B0", Offset = "0x53458B0", VA = "0x1853464B0")]
	public static MDIOLJJNKAE LMIHCCKEHFK(byte[] HPGJIANHJNN, DateTime JKIPGBBKHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5346840", Offset = "0x5345C40", VA = "0x185346840")]
	internal void MHCNKOCBNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5345EE0", Offset = "0x53452E0", VA = "0x185345EE0")]
	private void FGGPCFFCIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x53460B0", Offset = "0x53454B0", VA = "0x1853460B0")]
	private DateTime? GANLCDJNLGM(int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5346A80", Offset = "0x5345E80", VA = "0x185346A80")]
	private void PANDPCJCIAK(int ELJAGIMMLLH, DateTime? NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5345E10", Offset = "0x5345210", VA = "0x185345E10")]
	private ulong FBAPLEMDPFD(int ELJAGIMMLLH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5345CF0", Offset = "0x53450F0", VA = "0x185345CF0")]
	private void CLFAJDIPEGH(int ELJAGIMMLLH, ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5346420", Offset = "0x5345820", VA = "0x185346420")]
	private uint JKBNGNLAFIE(int ELJAGIMMLLH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5223500", Offset = "0x5222900", VA = "0x185223500")]
	private static uint GBMKHIAGFEJ(uint OPHKAEHAFCM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x53462B0", Offset = "0x53456B0", VA = "0x1853462B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5347BC0", Offset = "0x5346FC0", VA = "0x185347BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5347AE0", Offset = "0x5346EE0", VA = "0x185347AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53489C0", Offset = "0x5347DC0", VA = "0x1853489C0")]
	public NHJPFOCPAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5348640", Offset = "0x5347A40", VA = "0x185348640")]
	public void KPBJNPJOOEK(IPEndPoint KMGGGJHMHEB, byte[] MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5348880", Offset = "0x5347C80", VA = "0x185348880")]
	public void MCGENHPFHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53485B0", Offset = "0x53479B0", VA = "0x1853485B0")]
	private byte[] KOFIHODFCEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5347E50", Offset = "0x5347250", VA = "0x185347E50", Slot = "4")]
	public override void CODDIAFHJLO(IPEndPoint KMGGGJHMHEB, byte[] KKOACPFFAML, int ELJAGIMMLLH, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5348210", Offset = "0x5347610", VA = "0x185348210", Slot = "5")]
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
