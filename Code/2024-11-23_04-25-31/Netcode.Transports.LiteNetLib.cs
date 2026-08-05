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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, EEHIOBHJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DANBOFHLNEL
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
		private NetworkManager FNDCKHNLIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, HENNMOLOJAJ> MPIEDONKCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JBGMLHLIBMP ICOPLAGLJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] LIFDKEPHECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DANBOFHLNEL OMCJLGAHBIG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong FMBDJPLMOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GGHJENNMCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x61D0ED0", Offset = "0x61CF8D0", VA = "0x1861D0ED0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61D0460", Offset = "0x61CEE60", VA = "0x1861D0460")]
		public void RecRoom_SetEncryptionInfo(ulong JBFPCMFCFPB, byte[] PNABAFEIDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61D0440", Offset = "0x61CEE40", VA = "0x1861D0440")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61D0310", Offset = "0x61CED10", VA = "0x1861D0310")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61D0DD0", Offset = "0x61CF7D0", VA = "0x1861D0DD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61D0580", Offset = "0x61CEF80", VA = "0x1861D0580", Slot = "6")]
		public override void Send(ulong EPMKJGKDOID, ArraySegment<byte> GGEMPJLCHFC, NetworkDelivery ANNEMIFLHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61D0400", Offset = "0x61CEE00", VA = "0x1861D0400", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong EPMKJGKDOID, [Out] ArraySegment<byte> ELHNCLABHAD, [Out] float OMBBFNJIMOG)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61D0870", Offset = "0x61CF270", VA = "0x1861D0870", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61D0CF0", Offset = "0x61CF6F0", VA = "0x1861D0CF0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61CFB60", Offset = "0x61CE560", VA = "0x1861CFB60", Slot = "10")]
		public override void DisconnectRemoteClient(ulong EPMKJGKDOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61CFA10", Offset = "0x61CE410", VA = "0x1861CFA10", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61CFDA0", Offset = "0x61CE7A0", VA = "0x1861CFDA0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong EPMKJGKDOID)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61D0800", Offset = "0x61CF200", VA = "0x1861D0800", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61CFE40", Offset = "0x61CE840", VA = "0x1861CFE40", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FNDCKHNLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61CFCD0", Offset = "0x61CE6D0", VA = "0x1861CFCD0")]
		private LFKMBKBNABE EODFJBKOLEO(NetworkDelivery BKKHBFLPOHJ)
		{
			return default(LFKMBKBNABE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61CF950", Offset = "0x61CE350", VA = "0x1861CF950", Slot = "15")]
		private void BMBANEABOFP(HENNMOLOJAJ CEMOAFEDPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61CF890", Offset = "0x61CE290", VA = "0x1861CF890", Slot = "16")]
		private void BCAFJECHOKH(HENNMOLOJAJ CEMOAFEDPIC, FKOGJPCJJHG KDELKBJLNGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "17")]
		private void ONMGGKDAIDO(IPEndPoint KHDABGLLEML, SocketError PFLMBFBOJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61D0100", Offset = "0x61CEB00", VA = "0x1861D0100", Slot = "18")]
		private void OBHKPDCFNMI(HENNMOLOJAJ CEMOAFEDPIC, HEGNJDICDDD NIEHEDECLKP, byte FFPDHOIILCH, LFKMBKBNABE BBCPJBIHMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61D0000", Offset = "0x61CEA00", VA = "0x1861D0000")]
		private void LNMFNIHAKGD(int LEGDMNLNDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "19")]
		private void LOKPJDKAMOP(IPEndPoint LBMNBGDMOGK, HEGNJDICDDD NIEHEDECLKP, HCLOJHDINHD HNFHDKNEJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "20")]
		private void KGMIPEIIFOM(HENNMOLOJAJ CEMOAFEDPIC, int OBMOKNLDEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61CF830", Offset = "0x61CE230", VA = "0x1861CF830", Slot = "21")]
		private void BBHDKEFHNAB(AOKGJKFJMEK PGCEOMNLPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61CF800", Offset = "0x61CE200", VA = "0x1861CF800")]
		private ulong ACEJOLAHILC(HENNMOLOJAJ CEMOAFEDPIC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61D00E0", Offset = "0x61CEAE0", VA = "0x1861D00E0")]
		private static int NPCHPLFMDMF(float FPEHIEEJIAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61D0DF0", Offset = "0x61CF7F0", VA = "0x1861D0DF0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CEJJODFHGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HENNMOLOJAJ GOHEPGNJEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<KHJGNMGLKDL> IDABMJJNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int ENDAGKMGNMO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61BD210", Offset = "0x61BBC10", VA = "0x1861BD210")]
	protected CEJJODFHGAD(HENNMOLOJAJ CEMOAFEDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61BD130", Offset = "0x61BBB30", VA = "0x1861BD130")]
	public void KEPONFEJMGF(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61BD190", Offset = "0x61BBB90", VA = "0x1861BD190")]
	protected void MHDIIOMNLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61BD0F0", Offset = "0x61BBAF0", VA = "0x1861BD0F0")]
	public bool JCHEHIDIFBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MNAHOGFBOBP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool KOAHEPCIPFO(KHJGNMGLKDL MFLBDDIDFME);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KLJHFHCEDHE
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
public class AOKGJKFJMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JBGMLHLIBMP FLCFDKKOFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int OKDJHMKGNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EJABAFEDOJC HPJHFLOEJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IFOJKCDHBAB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KLJHFHCEDHE GFNJMOCKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C70", Offset = "0x8D3670", VA = "0x1808D4C70")]
		[CompilerGenerated]
		get
		{
			return default(KLJHFHCEDHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x92C950", Offset = "0x92B350", VA = "0x18092C950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61BC800", Offset = "0x61BB200", VA = "0x1861BC800")]
	internal void NJONPFBODIE(EJABAFEDOJC DKPDDFIHHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61BC7D0", Offset = "0x61BB1D0", VA = "0x1861BC7D0")]
	private bool MNLDFABNPMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61BC860", Offset = "0x61BB260", VA = "0x1861BC860")]
	internal AOKGJKFJMEK(IPEndPoint LBMNBGDMOGK, EJABAFEDOJC DBCEDHNNNDN, JBGMLHLIBMP JDEHDHNEPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61BC770", Offset = "0x61BB170", VA = "0x1861BC770")]
	public HENNMOLOJAJ IAAGDDIKOMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HCLOJHDINHD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FCHPAHLFIMN
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
public struct FKOGJPCJJHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FCHPAHLFIMN NHKDNEENCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BBLKIAGIHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HEGNJDICDDD FDDPCEHFKCM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EEHIOBHJBDP
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDHOGBFPCBE(HENNMOLOJAJ CEMOAFEDPIC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BODJJODPLBP(HENNMOLOJAJ CEMOAFEDPIC, FKOGJPCJJHG KDELKBJLNGP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECAJAJLJIEH(IPEndPoint KHDABGLLEML, SocketError PFLMBFBOJGG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMFDALJICKB(HENNMOLOJAJ CEMOAFEDPIC, HEGNJDICDDD NIEHEDECLKP, byte FFPDHOIILCH, LFKMBKBNABE BBCPJBIHMDE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNACFIPFCNK(IPEndPoint LBMNBGDMOGK, HEGNJDICDDD NIEHEDECLKP, HCLOJHDINHD HNFHDKNEJKO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFBOKENNAAJ(HENNMOLOJAJ CEMOAFEDPIC, int OBMOKNLDEAG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBEDPEPIDMG(AOKGJKFJMEK PGCEOMNLPAE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FFDICMHPOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCGEPAKBHPD(HENNMOLOJAJ CEMOAFEDPIC, object LADCACNCGMH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELNDDJNOOEK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAIFIIEDNLJ(IFILGIJLBIJ MFLBDDIDFME);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DLCJBNDKGHM
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAONCFGNBME(HENNMOLOJAJ CEMOAFEDPIC, IPEndPoint AOJECOGCCEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EJABAFEDOJC
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FKKGGEKOFPK = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long GDPIKDGEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EKGHCDFKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] PEGEFICKFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FALGAJAMAFA DKIFFIMODLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int LBCEFGIPFAL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61BEB20", Offset = "0x61BD520", VA = "0x1861BEB20")]
	private EJABAFEDOJC(long PMKMKKLELII, byte KEDINGDCKCI, int FKHJJLCBKFN, byte[] JPOJPENOOMO, FALGAJAMAFA GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61BE8A0", Offset = "0x61BD2A0", VA = "0x1861BE8A0")]
	public static int DEMMIKKKCIM(KHJGNMGLKDL MFLBDDIDFME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61BE900", Offset = "0x61BD300", VA = "0x1861BE900")]
	public static EJABAFEDOJC EAKFFEJBEHI(KHJGNMGLKDL MFLBDDIDFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61BE6C0", Offset = "0x61BD0C0", VA = "0x1861BE6C0")]
	public static KHJGNMGLKDL CFCBHENPACM(FNDHBIMBGAI KNAGOGDLHGB, SocketAddress FHHFJGAFDIM, long MMNLHNCCOEC, int FKHJJLCBKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LLGBPCFPEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long GDPIKDGEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte EKGHCDFKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int LBCEFGIPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool ALHKEEKIFMC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61CF7B0", Offset = "0x61CE1B0", VA = "0x1861CF7B0")]
	private LLGBPCFPEBA(long PMKMKKLELII, byte KEDINGDCKCI, int OHIHICJCBDH, bool APCAIGNMFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61CF660", Offset = "0x61CE060", VA = "0x1861CF660")]
	public static LLGBPCFPEBA EAKFFEJBEHI(KHJGNMGLKDL MFLBDDIDFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61CF570", Offset = "0x61CDF70", VA = "0x1861CF570")]
	public static KHJGNMGLKDL CFCBHENPACM(long MMNLHNCCOEC, byte KGMMMDNLBIH, int MAMPHNGCAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61CF470", Offset = "0x61CDE70", VA = "0x1861CF470")]
	public static KHJGNMGLKDL AJFNGNBAHBN(HENNMOLOJAJ CEMOAFEDPIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FNIOOKEDIOE
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JLPBDHJKHGD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOKKAJNJAIK(IPEndPoint CHNPCHGDMMC, IPEndPoint LBMNBGDMOGK, string AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMOHEDDMPOP(IPEndPoint JBIIAPKAAND, FNIOOKEDIOE BKKHBFLPOHJ, string AICEIDIHFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MLDDBPJMEEI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct GHEOKIBHAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HBOGINIMHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint IFOJKCDHBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string NMEFDPMOOJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HELKDOEHCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint MMEGEHFLCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FNIOOKEDIOE DLLABFENMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string NMEFDPMOOJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class NCLKALLLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint AKEHMGKIBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string NMEFDPMOOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NCLKALLLGOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class DNDJMJGIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint AKEHMGKIBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GAHCJKADPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NMEFDPMOOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DNDJMJGIEHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HJNMEJHKHKC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NMEFDPMOOJD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GNHAAIHJMBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B6BA0", VA = "0x1808B81A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HJNMEJHKHKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JBGMLHLIBMP KLADFIDBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<GHEOKIBHAGK> DOCAOCNOGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<HELKDOEHCPH> BKGLDNFAIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FALGAJAMAFA EOJAHJCPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FNDHBIMBGAI OPBEMFACNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FKLDGAJINNK CNFJEAMPLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private JLPBDHJKHGD NIKFBJLIHPE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int MCOPHEKHJNI = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool OOGPAEBBECM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61D1FF0", Offset = "0x61D09F0", VA = "0x1861D1FF0")]
	internal MLDDBPJMEEI(JBGMLHLIBMP OBINFJLIHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61D1B70", Offset = "0x61D0570", VA = "0x1861D1B70")]
	internal void CFDOAEAEAJK(IPEndPoint KBEOAFCIGBE, KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2FE2E20", Offset = "0x2FE1820", VA = "0x182FE2E20")]
	private void OBPNLDALOGD<T>(T MFLBDDIDFME, IPEndPoint PCFKCJNPKCO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61D19E0", Offset = "0x61D03E0", VA = "0x1861D19E0")]
	private void AOKKAJNJAIK(NCLKALLLGOB LFAIDJBLINK, IPEndPoint KBEOAFCIGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61D1E90", Offset = "0x61D0890", VA = "0x1861D1E90")]
	private void LHPGGBBNCMH(DNDJMJGIEHL LFAIDJBLINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61D1CF0", Offset = "0x61D06F0", VA = "0x1861D1CF0")]
	private void IGMBJCOANBP(HJNMEJHKHKC LFAIDJBLINK, IPEndPoint KBEOAFCIGBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LFKMBKBNABE : byte
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
public enum BOLAAGGIHHJ : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DGGPNGCIBEB
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] DNNDCJIPOOI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int GGMAHOFBBCA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int OHDLOCFLLAI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FKCDCLFELDP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61BF7F0", Offset = "0x61BE1F0", VA = "0x1861BF7F0")]
	public FKCDCLFELDP(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PHNPJKOIKGL : FKCDCLFELDP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61BF7F0", Offset = "0x61BE1F0", VA = "0x1861BF7F0")]
	public PHNPJKOIKGL(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CDNMPPCPPJG
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
public interface GCIKCPAICBN
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIGHGBAOLAL(CDNMPPCPPJG BBLLECPFLID, string JBIHOCOCJKD, params object[] LPLPEHNKFMM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LBMDHPLHALK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static GCIKCPAICBN AEPMLHIOKHB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MBJDOPPEHNJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61CF190", Offset = "0x61CDB90", VA = "0x1861CF190")]
	private static void ONGHOKKOCIF(CDNMPPCPPJG HMAGFKIKOFJ, string JBIHOCOCJKD, params object[] LPLPEHNKFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61CF0D0", Offset = "0x61CDAD0", VA = "0x1861CF0D0")]
	internal static void BPCHNAGGBNA(string JBIHOCOCJKD, params object[] LPLPEHNKFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61CF070", Offset = "0x61CDA70", VA = "0x1861CF070")]
	internal static void AGCLDDOEJLE(string JBIHOCOCJKD, params object[] LPLPEHNKFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61CF130", Offset = "0x61CDB30", VA = "0x1861CF130")]
	internal static void JGKLMGGBCAO(string JBIHOCOCJKD, params object[] LPLPEHNKFMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FLKIAPGLKIP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HEGNJDICDDD : FALGAJAMAFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KHJGNMGLKDL PBDFEGDJENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JBGMLHLIBMP BAMKJKJJJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JAMAJHNDINB BCHNFANEBHG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61C0AE0", Offset = "0x61BF4E0", VA = "0x1861C0AE0")]
	internal HEGNJDICDDD(JBGMLHLIBMP PLJBPLDMFHL, JAMAJHNDINB JBPJIGBJHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61C0A70", Offset = "0x61BF470", VA = "0x1861C0A70")]
	internal void POOBHAENAOC(KHJGNMGLKDL MFLBDDIDFME, int DEBBLMMPFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61C09C0", Offset = "0x61BF3C0", VA = "0x1861C09C0")]
	internal void EANHFHGOGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61C0A40", Offset = "0x61BF440", VA = "0x1861C0A40")]
	public void GHACBLHAGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JAMAJHNDINB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum LEDDLOKDCAB
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
	public JAMAJHNDINB CKLAOGMBBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public LEDDLOKDCAB DLLABFENMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public HENNMOLOJAJ GOHEPGNJEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint IFOJKCDHBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object FJEOLDIJGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int DLOALCECMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JNLKNHBDOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public FCHPAHLFIMN OCILLMLPHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public AOKGJKFJMEK DIFDPCAIICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public LFKMBKBNABE GBHNLCJODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte CNHFNGAGFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HEGNJDICDDD DLIHLJKBFMA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61C6A50", Offset = "0x61C5450", VA = "0x1861C6A50")]
	public JAMAJHNDINB(JBGMLHLIBMP PLJBPLDMFHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JBGMLHLIBMP : IEnumerable<HENNMOLOJAJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class IKOODGABAPH : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61C69E0", Offset = "0x61C53E0", VA = "0x1861C69E0", Slot = "4")]
		public bool Equals(IPEndPoint PMBJFHIMJKC, IPEndPoint HBABDGBANAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5C98790", Offset = "0x5C97190", VA = "0x185C98790", Slot = "5")]
		public int GetHashCode(IPEndPoint BBNKFKDCOLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IKOODGABAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct PBJGDALJPAK : IEnumerator<HENNMOLOJAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly HENNMOLOJAJ NMPHBBIHPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private HENNMOLOJAJ FGJDFEGPNFP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HENNMOLOJAJ MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9577A0", Offset = "0x9561A0", VA = "0x1809577A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9577A0", Offset = "0x9561A0", VA = "0x1809577A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x14387C0", Offset = "0x14371C0", VA = "0x1814387C0")]
		public PBJGDALJPAK(HENNMOLOJAJ CGOKOAJMBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61D35F0", Offset = "0x61D1FF0", VA = "0x1861D35F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61D3640", Offset = "0x61D2040", VA = "0x1861D3640", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread KHPIOCCNFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool HFOKAKICAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent PHLBLADIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JAMAJHNDINB> OBPAFBFHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JAMAJHNDINB> CJOBKNAAKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JAMAJHNDINB BBDPDLBHLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly EEHIOBHJBDP GGDAMKMNDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FFDICMHPOFJ DJFHHJOLDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ELNDDJNOOEK MJFBDLBDEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DLCJBNDKGHM EECFNPILJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, HENNMOLOJAJ> FDNJEJPANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, AOKGJKFJMEK> BBFIKOGHAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, CIDCFHHJGHH> ANBHBIOCOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim DHCPPKADNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private HENNMOLOJAJ AGEMOHNJNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int PIGBALEJLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<HENNMOLOJAJ> NNKLKIHJKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HENNMOLOJAJ[] LCHFOIMLMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KKDMKKEJOPE NEEKOMAMJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int IBBMNCHNFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> DAMEGEINMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte HOCGOKEBFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LGDDLNMECMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool NOPBNECLPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool HOJPJCMEOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LNNADEAHHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int IDIJHCBLAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JOEIHCAKEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FFHPLGDGCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool JEKPCPKKEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool PAGDEPJEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KHAGDOGCFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NNPCMLHCGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int HEPBNMDFNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool OOGPAEBBECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool LGHHJFIJBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool JFKOPNENCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool DCCDLLMOLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LFLJMHAACBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GEBPPMHCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FEELJAFJMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KCKBFOLHDPK MOIKKBMGAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool DNKAFLNHIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly MLDDBPJMEEI OOJLDLIOGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool AKPFMHBJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public FLKIAPGLKIP IDCDDHJKKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int BMPKMCIBEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool JEMINLLGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool BKFAAPPOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool BKNIMHMHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BPMNCJCMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private KHJGNMGLKDL KGDLLODAKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int MDDAHPLBHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object NBCMAEHGODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KHJGNMGLKDL HLAJOHCGIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int DNBNBNDDEDC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int PAIAMKOPLMK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int CLAKHCFLKGA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JOMEBMIPEPA ECMHLAJCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private JOMEBMIPEPA KFJDEKEGKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread LMCNGEEPNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread INCMDGCOENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CNKICNGILNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NLHOPOCCKEI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] JELFHANPJFA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] BELBKCKHEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<MLJKJCMHOPE, IPEndPoint> GMMPEOKKOLD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress PMIDMNHNIMP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MBLJPFEOHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int CIEFEFLOLCP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FIKBHKFDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF3AEE0", Offset = "0xF398E0", VA = "0x180F3AEE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xFC7910", Offset = "0xFC6310", VA = "0x180FC7910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CFGOOHGOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19754F0", Offset = "0x1973EF0", VA = "0x1819754F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1BB88F0", Offset = "0x1BB72F0", VA = "0x181BB88F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte AKNPGOEMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD32C50", Offset = "0xD31650", VA = "0x180D32C50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FKNHJDGCLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61C72A0", Offset = "0x61C5CA0", VA = "0x1861C72A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short PJHAFGJJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61C7B20", Offset = "0x61C6520", VA = "0x1861C7B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61C7310", Offset = "0x61C5D10", VA = "0x1861C7310")]
	public void CANDMBKMFCC(IPEndPoint KHDABGLLEML, byte[] PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61CAE30", Offset = "0x61C9830", VA = "0x1861CAE30")]
	public void IHMCHOJOMGC(IPEndPoint KHDABGLLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61CC710", Offset = "0x61CB110", VA = "0x1861CC710")]
	private bool OGFMIHNPHPP(IPEndPoint KHDABGLLEML, [Out] HENNMOLOJAJ CEMOAFEDPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61C9C40", Offset = "0x61C8640", VA = "0x1861C9C40")]
	private void HFGHKOBLDNJ(HENNMOLOJAJ CEMOAFEDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61C72C0", Offset = "0x61C5CC0", VA = "0x1861C72C0")]
	private void BOHOOLFKNJK(HENNMOLOJAJ CEMOAFEDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61CB5B0", Offset = "0x61C9FB0", VA = "0x1861CB5B0")]
	private void JMHOKPEBHJL(HENNMOLOJAJ CEMOAFEDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61CD810", Offset = "0x61CC210", VA = "0x1861CD810")]
	public JBGMLHLIBMP(EEHIOBHJBDP JDEHDHNEPGO, [Optional] KKDMKKEJOPE FMHHABICDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61C7250", Offset = "0x61C5C50", VA = "0x1861C7250")]
	internal void BEIOIBAMMFE(HENNMOLOJAJ AELJIICBAAG, int OBMOKNLDEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61C79C0", Offset = "0x61C63C0", VA = "0x1861C79C0")]
	internal void DDOHHHMOADC(HENNMOLOJAJ AELJIICBAAG, object LADCACNCGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61C9FA0", Offset = "0x61C89A0", VA = "0x1861C9FA0")]
	internal void HMODPEJLOPM(HENNMOLOJAJ CEMOAFEDPIC, FCHPAHLFIMN OMJKCNAHEJC, SocketError LOAGJACOFFD, KHJGNMGLKDL JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61CC2F0", Offset = "0x61CACF0", VA = "0x1861CC2F0")]
	private void NECOECAFLGK(HENNMOLOJAJ CEMOAFEDPIC, FCHPAHLFIMN OMJKCNAHEJC, SocketError LOAGJACOFFD, bool DEDPJAGPBOL, byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int FPDJICFHLGM, KHJGNMGLKDL JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61C6E70", Offset = "0x61C5870", VA = "0x1861C6E70")]
	private void BDPOHFBGCBD(JAMAJHNDINB.LEDDLOKDCAB BKKHBFLPOHJ, [Optional] HENNMOLOJAJ CEMOAFEDPIC, [Optional] IPEndPoint LBMNBGDMOGK, SocketError IJKGJPCAEHK = SocketError.Success, int OBMOKNLDEAG = 0, FCHPAHLFIMN FOGAHEDIDLA = FCHPAHLFIMN.ConnectionFailed, [Optional] AOKGJKFJMEK LNCKMJANHPL, LFKMBKBNABE BBCPJBIHMDE = LFKMBKBNABE.Unreliable, byte FFPDHOIILCH = 0, [Optional] KHJGNMGLKDL MNPECLPDLGB, [Optional] object LADCACNCGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61C8820", Offset = "0x61C7220", VA = "0x1861C8820")]
	private void EPMEPKIJHPC(JAMAJHNDINB JBPJIGBJHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61C7A10", Offset = "0x61C6410", VA = "0x1861C7A10")]
	internal void DEIHCIKNPLA(JAMAJHNDINB JBPJIGBJHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61C8200", Offset = "0x61C6C00", VA = "0x1861C8200")]
	private void EHGNILBHOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61C9040", Offset = "0x61C7A40", VA = "0x1861C9040")]
	private void FNFOJMEPKHL(int PBMKIHPJBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61C7BE0", Offset = "0x61C65E0", VA = "0x1861C7BE0")]
	internal HENNMOLOJAJ DMNAPEEIGIJ(AOKGJKFJMEK PGCEOMNLPAE, byte[] KHLNHFKLFJD, int CIFAFIDMMAE, int JGKAMGBGMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61C9F20", Offset = "0x61C8920", VA = "0x1861C9F20")]
	private int HJAOOEIEIKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61C7530", Offset = "0x61C5F30", VA = "0x1861C7530")]
	private void CEKPJAPJOIH(IPEndPoint LBMNBGDMOGK, HENNMOLOJAJ DEJNHFOAOIM, EJABAFEDOJC JEIHPKCHNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61CA070", Offset = "0x61C8A70", VA = "0x1861CA070")]
	private void IHCMLMMAKDE(KHJGNMGLKDL MFLBDDIDFME, IPEndPoint LBMNBGDMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61C8540", Offset = "0x61C6F40", VA = "0x1861C8540")]
	internal void EKAJHCPOFKM(KHJGNMGLKDL MFLBDDIDFME, LFKMBKBNABE PCBJKLALPOG, byte FFPDHOIILCH, int DEBBLMMPFPN, HENNMOLOJAJ AELJIICBAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61CD540", Offset = "0x61CBF40", VA = "0x1861CD540")]
	public bool PMHKFLKJGHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61CD520", Offset = "0x61CBF20", VA = "0x1861CD520")]
	public bool PMHKFLKJGHI(IPAddress KBAAEMLJKEI, IPAddress EDAOJAFIMHM, int AJIDDAEJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61CD5B0", Offset = "0x61CBFB0", VA = "0x1861CD5B0")]
	public bool PMHKFLKJGHI(int AJIDDAEJHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61CB400", Offset = "0x61C9E00", VA = "0x1861CB400")]
	public void INJALBDAGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61C9730", Offset = "0x61C8130", VA = "0x1861C9730")]
	public HENNMOLOJAJ GGHMBDHPJHG(string DOLPOJJLONL, int AJIDDAEJHAF, string PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61C9810", Offset = "0x61C8210", VA = "0x1861C9810")]
	public HENNMOLOJAJ GGHMBDHPJHG(string DOLPOJJLONL, int AJIDDAEJHAF, FNDHBIMBGAI FBOEJFPIMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61C9360", Offset = "0x61C7D60", VA = "0x1861C9360")]
	public HENNMOLOJAJ GGHMBDHPJHG(IPEndPoint PCFKCJNPKCO, FNDHBIMBGAI FBOEJFPIMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61CC8A0", Offset = "0x61CB2A0", VA = "0x1861CC8A0")]
	public void OJLNFIHNJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61CC8B0", Offset = "0x61CB2B0", VA = "0x1861CC8B0")]
	public void OJLNFIHNJLA(bool EOECNGLAEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61CB0A0", Offset = "0x61C9AA0", VA = "0x1861CB0A0")]
	public void IJKHJPBGEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61CAF80", Offset = "0x61C9980", VA = "0x1861CAF80")]
	public void IJKHJPBGEAC(byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61CC4A0", Offset = "0x61CAEA0", VA = "0x1861CC4A0")]
	public void NECOECAFLGK(HENNMOLOJAJ CEMOAFEDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61CC3E0", Offset = "0x61CADE0", VA = "0x1861CC3E0")]
	public void NECOECAFLGK(HENNMOLOJAJ CEMOAFEDPIC, byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61CD630", Offset = "0x61CC030", VA = "0x1861CD630", Slot = "4")]
	private IEnumerator<HENNMOLOJAJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61CD6C0", Offset = "0x61CC0C0", VA = "0x1861CD6C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61CC630", Offset = "0x61CB030", VA = "0x1861CC630")]
	private KHJGNMGLKDL OFHJJLJCBNI(EGAJKINHEGP JKKOEFMEAMD, int LEGDMNLNDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61CC550", Offset = "0x61CAF50", VA = "0x1861CC550")]
	private KHJGNMGLKDL OFHJJLJCBNI(EGAJKINHEGP JKKOEFMEAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61C9A00", Offset = "0x61C8400", VA = "0x1861C9A00")]
	internal KHJGNMGLKDL GOPPBPIGGAD(int LEGDMNLNDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61CB1A0", Offset = "0x61C9BA0", VA = "0x1861CB1A0")]
	internal void IKDAKDDGLDL(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61CD750", Offset = "0x61CC150", VA = "0x1861CD750")]
	static JBGMLHLIBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xF3AEE0", Offset = "0xF398E0", VA = "0x180F3AEE0")]
	private bool HBBOBABEAJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61C98F0", Offset = "0x61C82F0", VA = "0x1861C98F0")]
	private void GKBPDMMHJCO(IPEndPoint OLMEFBAJBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61CC7A0", Offset = "0x61CB1A0", VA = "0x1861CC7A0")]
	private void OINFACBAOCG(IPEndPoint OLMEFBAJBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61CBE70", Offset = "0x61CA870", VA = "0x1861CBE70")]
	private bool NANBIBHHKHC(SocketException AENFONOHPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61CC020", Offset = "0x61CAA20", VA = "0x1861CC020")]
	private void NCJOFEPEOBN(JOMEBMIPEPA OBINFJLIHFF, EndPoint LKMPGNFJJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61C6AF0", Offset = "0x61C54F0", VA = "0x1861C6AF0")]
	private void BCBEEHDADFC(object DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD70", Offset = "0x61CB770", VA = "0x1861CCD70")]
	public bool PMHKFLKJGHI(IPAddress KBAAEMLJKEI, IPAddress EDAOJAFIMHM, int AJIDDAEJHAF, bool FAEGEAOHMDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61C8FE0", Offset = "0x61C79E0", VA = "0x1861C8FE0")]
	internal int FALDBCAENBC(KHJGNMGLKDL MFLBDDIDFME, IPEndPoint LBMNBGDMOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61CB820", Offset = "0x61CA220", VA = "0x1861CB820")]
	internal int LJNALONJDLN(KHJGNMGLKDL MFLBDDIDFME, IPEndPoint LBMNBGDMOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61CB860", Offset = "0x61CA260", VA = "0x1861CB860")]
	internal int LJNALONJDLN(byte[] FCMDIEEAPHD, int CIFAFIDMMAE, int JGKAMGBGMHI, IPEndPoint LBMNBGDMOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61CCC00", Offset = "0x61CB600", VA = "0x1861CCC00")]
	internal void PKPJIFDIECA(bool JMPKNENIION)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum EGAJKINHEGP : byte
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
internal sealed class KHJGNMGLKDL
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MGADDLJLONJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DCPBDLIIKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IHGIEGMHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int HOGPONPHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object FJEOLDIJGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public KHJGNMGLKDL CKLAOGMBBLC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EGAJKINHEGP HIFFIALDCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61CE740", Offset = "0x61CD140", VA = "0x1861CE740")]
		get
		{
			return default(EGAJKINHEGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61CE700", Offset = "0x61CD100", VA = "0x1861CE700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte EKGHCDFKIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x61CE6D0", Offset = "0x61CD0D0", VA = "0x1861CE6D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61CE940", Offset = "0x61CD340", VA = "0x1861CE940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort CKMAILMFIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61CE8E0", Offset = "0x61CD2E0", VA = "0x1861CE8E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61CEAF0", Offset = "0x61CD4F0", VA = "0x1861CEAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BLFONMLHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61CE7A0", Offset = "0x61CD1A0", VA = "0x1861CE7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte NLOMPKBNIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61CE870", Offset = "0x61CD270", VA = "0x1861CE870")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61CE770", Offset = "0x61CD170", VA = "0x1861CE770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort DAIIPBBHKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61CE670", Offset = "0x61CD070", VA = "0x1861CE670")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61CE8A0", Offset = "0x61CD2A0", VA = "0x1861CE8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JIJAEGIIOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61CE810", Offset = "0x61CD210", VA = "0x1861CE810")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61CE7D0", Offset = "0x61CD1D0", VA = "0x1861CE7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort EJMLLPHFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x61CE610", Offset = "0x61CD010", VA = "0x1861CE610")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x61CEAB0", Offset = "0x61CD4B0", VA = "0x1861CEAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61CEC30", Offset = "0x61CD630", VA = "0x1861CEC30")]
	static KHJGNMGLKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61CEA80", Offset = "0x61CD480", VA = "0x1861CEA80")]
	public void JNEHOMPEAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61CEEF0", Offset = "0x61CD8F0", VA = "0x1861CEEF0")]
	public KHJGNMGLKDL(int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61CEF60", Offset = "0x61CD960", VA = "0x1861CEF60")]
	public KHJGNMGLKDL(EGAJKINHEGP JKKOEFMEAMD, int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61CE980", Offset = "0x61CD380", VA = "0x1861CE980")]
	public static int JMPFMPJIBBF(EGAJKINHEGP JKKOEFMEAMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61CE9F0", Offset = "0x61CD3F0", VA = "0x1861CE9F0")]
	public int JMPFMPJIBBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61CEB30", Offset = "0x61CD530", VA = "0x1861CEB30")]
	public bool OEBFLOGGGDC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum BHKEFCCCAOG : byte
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
internal enum ECKOMICMIAK
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
internal enum KKOGPBPFCKI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum FKOJCFDKBLD
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HENNMOLOJAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KMMDOEGAGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KHJGNMGLKDL[] MGEJNGKKFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int IOGDPLAIGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int HMCIBBKBNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte NLOMPKBNIJF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KMMDOEGAGGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void DDPHPAEKCDG(ulong EIEFAGNACEK, int EJINFGMOGEL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int JIJLCKKMIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int JNAEBNKKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int CAEINCKFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double JOBLCNJIFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int LCAPLIGBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int PAAFKPEAIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int BCNGNPLADBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch MPAMBGKPOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MIDNDDOCMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long MJCMEJCJPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object GLJEDHPDGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal HENNMOLOJAJ FLDIFCKNLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal HENNMOLOJAJ EFONAOCPCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<KHJGNMGLKDL> FJPNDKLOIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CEJJODFHGAD> ODILIMPHJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CEJJODFHGAD[] GFNCFMGHJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int LHLBBMADMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int EOCHGPOKDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool JKDPOPKAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int IHNPGEIAHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int BKGDOGFDKNE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int NHIHBLHMNAP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int DBJCJGIBPPC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object KHMGGGHEPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KKHAMBIPCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, KMMDOEGAGGJ> JDLNBGGOFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> GHPONECIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KHJGNMGLKDL AIFGNKMECKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GGJNDFNNOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int EHEBFMCGFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint HABGOHLOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LNOECCPILHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int IMMFGAIPMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long LLLDJHHCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte EBHPOPGPBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private BHKEFCCCAOG GEIGCJMGINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KHJGNMGLKDL AGNPLGPNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int APEGLBMODAD = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int KLBECAMJKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly KHJGNMGLKDL NFFCDBMENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KHJGNMGLKDL HPMKIIGHNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KHJGNMGLKDL IMPFCMAIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly KHJGNMGLKDL MLDIDNOIANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BOLAAGGIHHJ DGKDNPENIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly JBGMLHLIBMP JBCBJKBLNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int PGOLDFNFDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object GEPAFFHBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KCKBFOLHDPK MOIKKBMGAEI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte HAANLIMBEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBE9130", Offset = "0xBE7B30", VA = "0x180BE9130")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61C4350", Offset = "0x61C2D50", VA = "0x1861C4350")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint AAAALKBHIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x97E8C0", Offset = "0x97D2C0", VA = "0x18097E8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BHKEFCCCAOG EJKPGMIODMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x167CAD0", Offset = "0x167B4D0", VA = "0x18167CAD0")]
		get
		{
			return default(BHKEFCCCAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long NODDBONICMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5370", VA = "0x1808B6970")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ENEBEKABGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1008CA0", Offset = "0x10076A0", VA = "0x181008CA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19178B0", Offset = "0x19162B0", VA = "0x1819178B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CONMACEHIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x61C14A0", Offset = "0x61BFEA0", VA = "0x1861C14A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JPHNCALIADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFB0", Offset = "0x8BA9B0", VA = "0x1808BBFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double FCFKNFFOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4412CE0", Offset = "0x44116E0", VA = "0x184412CE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DDPHPAEKCDG FENFDAIEGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61C13F0", Offset = "0x61BFDF0", VA = "0x1861C13F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61C3F30", Offset = "0x61C2930", VA = "0x1861C3F30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61C4680", Offset = "0x61C3080", VA = "0x1861C4680")]
	internal HENNMOLOJAJ(JBGMLHLIBMP PFOEGFDHCKH, IPEndPoint LBMNBGDMOGK, int CMEADPACGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x61C4400", Offset = "0x61C2E00", VA = "0x1861C4400")]
	internal void NJPPJHLEOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61C4650", Offset = "0x61C3050", VA = "0x1861C4650")]
	internal void PGCMFMBEBEG(IPEndPoint BAANJMLPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61C1360", Offset = "0x61BFD60", VA = "0x1861C1360")]
	internal void FHAMLIDFGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61C0BB0", Offset = "0x61BF5B0", VA = "0x1861C0BB0")]
	private void BHJOPHDKGNJ(int OLIIEBPKHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61C1320", Offset = "0x61BFD20", VA = "0x1861C1320")]
	private void FELIPKNCNOE(int CGGBNAEANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61C2C00", Offset = "0x61C1600", VA = "0x1861C2C00")]
	private CEJJODFHGAD KNIPBPNMDLN(byte DLAFBLPELJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x61C4CB0", Offset = "0x61C36B0", VA = "0x1861C4CB0")]
	internal HENNMOLOJAJ(JBGMLHLIBMP PFOEGFDHCKH, IPEndPoint LBMNBGDMOGK, int CMEADPACGME, byte KGMMMDNLBIH, FNDHBIMBGAI KNAGOGDLHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x61C4AD0", Offset = "0x61C34D0", VA = "0x1861C4AD0")]
	internal HENNMOLOJAJ(JBGMLHLIBMP PFOEGFDHCKH, AOKGJKFJMEK PGCEOMNLPAE, int CMEADPACGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x61C3E00", Offset = "0x61C2800", VA = "0x1861C3E00")]
	internal void LECOAOBOJCG(EJABAFEDOJC NKLAGAEINAL, byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x61C0B30", Offset = "0x61BF530", VA = "0x1861C0B30")]
	internal bool ALNJKGDBPMG(LLGBPCFPEBA MFLBDDIDFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x61C4420", Offset = "0x61C2E20", VA = "0x1861C4420")]
	public void OBPNLDALOGD(byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int JGKAMGBGMHI, LFKMBKBNABE JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61C26A0", Offset = "0x61C10A0", VA = "0x1861C26A0")]
	private void KJHBIIBFMGI(byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int JGKAMGBGMHI, byte FFPDHOIILCH, LFKMBKBNABE BBCPJBIHMDE, object LADCACNCGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x61C1A00", Offset = "0x61C0400", VA = "0x1861C1A00")]
	public void HGCKJDIICOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x61C3E50", Offset = "0x61C2850", VA = "0x1861C3E50")]
	internal KKOGPBPFCKI LEPIBCDAFIB(KHJGNMGLKDL MFLBDDIDFME)
	{
		return default(KKOGPBPFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x61C3FE0", Offset = "0x61C29E0", VA = "0x1861C3FE0")]
	internal void LFMDKLKNMIB(CEJJODFHGAD HIMNPBPGIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61C4040", Offset = "0x61C2A40", VA = "0x1861C4040")]
	internal FKOJCFDKBLD MBEDIEFBJDD(byte[] GGEMPJLCHFC, int CIFAFIDMMAE, int JGKAMGBGMHI, bool DEDPJAGPBOL)
	{
		return default(FKOJCFDKBLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x61C23A0", Offset = "0x61C0DA0", VA = "0x1861C23A0")]
	private void HOEHOECPBDL(int PPIHIMPJDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x61C3470", Offset = "0x61C1E70", VA = "0x1861C3470")]
	internal void LBBBJNDLAGA(LFKMBKBNABE PCBJKLALPOG, KHJGNMGLKDL CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61C14B0", Offset = "0x61BFEB0", VA = "0x1861C14B0")]
	private void GBJCIFBPABA(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61C0E40", Offset = "0x61BF840", VA = "0x1861C0E40")]
	private void EAFJDAJMDMN(int OFFHKGFMEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61C0C80", Offset = "0x61BF680", VA = "0x1861C0C80")]
	internal ECKOMICMIAK CEKPJAPJOIH(EJABAFEDOJC JEIHPKCHNEN)
	{
		return default(ECKOMICMIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61C2DB0", Offset = "0x61C17B0", VA = "0x1861C2DB0")]
	internal void KOAHEPCIPFO(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61C11D0", Offset = "0x61BFBD0", VA = "0x1861C11D0")]
	private void ECAKBDNCPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61C4450", Offset = "0x61C2E50", VA = "0x1861C4450")]
	internal void PBNIIHGLGOL(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61C1AB0", Offset = "0x61C04B0", VA = "0x1861C1AB0")]
	internal void HIEHKMNLIKI(int OFFHKGFMEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61C23E0", Offset = "0x61C0DE0", VA = "0x1861C23E0")]
	internal void IFJBMPJGPEI(KHJGNMGLKDL MFLBDDIDFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KCKBFOLHDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KDLBKKGADLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long PIHLLCFJIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long KGHEFDMNOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LFBJAJIFEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long BMAEECONBML;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long KGAIPNBDOAB;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long ODJJCOCHLOH;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long IOAGODGEJNE;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long DNPIALNAOPD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long PFCBJHLHEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long NIKADBGDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GLNGDIIDHAP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NFNGIIENOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61CDE60", Offset = "0x61CC860", VA = "0x1861CDE60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GIPOBDOMHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61CE1F0", Offset = "0x61CCBF0", VA = "0x1861CE1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LIKLKCGOGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61CDF50", Offset = "0x61CC950", VA = "0x1861CDF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FJGOGCICHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61CE0B0", Offset = "0x61CCAB0", VA = "0x1861CE0B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long JELJFEBGCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61CE060", Offset = "0x61CCA60", VA = "0x1861CE060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long DIJCDGDEJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61CE200", Offset = "0x61CCC00", VA = "0x1861CE200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long ALAJKFAHNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61CDF10", Offset = "0x61CC910", VA = "0x1861CDF10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long JICEIKKJALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61CDFC0", Offset = "0x61CC9C0", VA = "0x1861CDFC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private BOLAAGGIHHJ JBABLKHPIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61CE210", Offset = "0x61CCC10", VA = "0x1861CE210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double CPJABKPAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61CE000", Offset = "0x61CCA00", VA = "0x1861CE000")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x61CE070", Offset = "0x61CCA70", VA = "0x1861CE070")]
	public void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x61CE130", Offset = "0x61CCB30", VA = "0x1861CE130")]
	public void KIKPIKJIJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x61CE220", Offset = "0x61CCC20", VA = "0x1861CE220")]
	public void OGOFLKCBMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x61CDF60", Offset = "0x61CC960", VA = "0x1861CDF60")]
	public void BICKDNBPHPJ(long FNNPCBILEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61CE190", Offset = "0x61CCB90", VA = "0x1861CE190")]
	public void LILLEMCGOJM(long ALOCHLHEHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61CE270", Offset = "0x61CCC70", VA = "0x1861CE270")]
	public void PIPPKCJEINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x61CE0C0", Offset = "0x61CCAC0", VA = "0x1861CE0C0")]
	public void JFFHLCFJIJK(long ELEBKGDNGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61CE2D0", Offset = "0x61CCCD0", VA = "0x1861CE2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61CDE70", Offset = "0x61CC870", VA = "0x1861CDE70")]
	public void AILJIELAKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KCKBFOLHDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NKIMHJBCIAP
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> JDACNAMEPCB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61D27B0", Offset = "0x61D11B0", VA = "0x1861D27B0")]
	public static IPEndPoint FBCFADKFBFH(string JOIGMFOFMLO, int AJIDDAEJHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x61D2A90", Offset = "0x61D1490", VA = "0x1861D2A90")]
	public static IPAddress OGKLPBIILDG(string JOIGMFOFMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61D2A00", Offset = "0x61D1400", VA = "0x1861D2A00")]
	public static IPAddress OGKLPBIILDG(string JOIGMFOFMLO, AddressFamily CGLKJFJHONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61D2780", Offset = "0x61D1180", VA = "0x1861D2780")]
	internal static int ACOFJHEOGAE(int KPMHICJIICL, int KKKOPPBCANH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x304EE00", Offset = "0x304D800", VA = "0x18304EE00")]
	internal static T[] KHODOAFPOPJ<T>(int FPDJICFHLGM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DMFMLNAKFPL : CEJJODFHGAD
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct CENLKAGHPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KHJGNMGLKDL PBDFEGDJENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long FCNOELBMEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool DJPALBIBJBE;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61BD390", Offset = "0x61BBD90", VA = "0x1861BD390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61BD300", Offset = "0x61BBD00", VA = "0x1861BD300")]
		public void IGMCENCOPJL(KHJGNMGLKDL MFLBDDIDFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61BD320", Offset = "0x61BBD20", VA = "0x1861BD320")]
		public bool MMGDNPBHJGH(long LGHDLACJOLK, HENNMOLOJAJ CEMOAFEDPIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61BD2B0", Offset = "0x61BBCB0", VA = "0x1861BD2B0")]
		public bool CFGGIHGKNGN(HENNMOLOJAJ CEMOAFEDPIC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly KHJGNMGLKDL OEJDMGPIOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly CENLKAGHPHB[] IFKPNMEOMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly KHJGNMGLKDL[] DIJGHEMDLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] JNCNBHKCAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int AELJFDCMKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int JDKLMKBHGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int JGLBBDJGJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int PKOHLJJEONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool ENKEFAMCCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly LFKMBKBNABE KJALHBAKMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool DKEKDPGMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int LLCCKGDCCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte LFBKPPDOILJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61BE4F0", Offset = "0x61BCEF0", VA = "0x1861BE4F0")]
	public DMFMLNAKFPL(HENNMOLOJAJ CEMOAFEDPIC, bool NGPPHJODDGG, byte CMEADPACGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61BD600", Offset = "0x61BC000", VA = "0x1861BD600")]
	private void BJIGDMHKKJJ(KHJGNMGLKDL MFLBDDIDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61BE020", Offset = "0x61BCA20", VA = "0x1861BE020", Slot = "4")]
	protected override bool MNAHOGFBOBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61BD9C0", Offset = "0x61BC3C0", VA = "0x1861BD9C0", Slot = "5")]
	public override bool KOAHEPCIPFO(KHJGNMGLKDL MFLBDDIDFME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OMKELAOMGFH : CEJJODFHGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int AMBGIIAMJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort JDKLMKBHGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool NBEDCBECLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private KHJGNMGLKDL JLHOLBKEOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly KHJGNMGLKDL BKPMCAFLFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool MFEDHEAKJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte LFBKPPDOILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long NAABOIDPJFH;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61D3530", Offset = "0x61D1F30", VA = "0x1861D3530")]
	public OMKELAOMGFH(HENNMOLOJAJ CEMOAFEDPIC, bool KAJIFPJHPHM, byte CMEADPACGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61D3070", Offset = "0x61D1A70", VA = "0x1861D3070", Slot = "4")]
	protected override bool MNAHOGFBOBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61D2D90", Offset = "0x61D1790", VA = "0x1861D2D90", Slot = "5")]
	public override bool KOAHEPCIPFO(KHJGNMGLKDL MFLBDDIDFME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NFNALHIFBLC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct PBGHACEBLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong NKEBEDAACGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double HAOEGPPPEBJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OADEMBGPJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int MCIADGHGOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float KDMHLDHONJB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61BC680", Offset = "0x61BB080", VA = "0x1861BC680")]
	private static void APPDACFBNHL(byte[] GNKEDFJBDMM, int FDHHGENAMHL, ulong GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61D2660", Offset = "0x61D1060", VA = "0x1861D2660")]
	private static void APPDACFBNHL(byte[] GNKEDFJBDMM, int FDHHGENAMHL, int GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61D2620", Offset = "0x61D1020", VA = "0x1861D2620")]
	public static void APPDACFBNHL(byte[] GNKEDFJBDMM, int FDHHGENAMHL, short GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x61D2760", Offset = "0x61D1160", VA = "0x1861D2760")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, double PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61D26E0", Offset = "0x61D10E0", VA = "0x1861D26E0")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61D2620", Offset = "0x61D1020", VA = "0x1861D2620")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, short PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61D2620", Offset = "0x61D1020", VA = "0x1861D2620")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, ushort PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61D2660", Offset = "0x61D1060", VA = "0x1861D2660")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61D2660", Offset = "0x61D1060", VA = "0x1861D2660")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, uint PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61D26D0", Offset = "0x61D10D0", VA = "0x1861D26D0")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61D26D0", Offset = "0x61D10D0", VA = "0x1861D26D0")]
	public static void EMIKABEGNPO(byte[] FFGGPAIGPAA, int FMCLGEDFPEP, ulong PKCLPFEIPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FALGAJAMAFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] CIOOIMGPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int IHJMIEGJIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int IJOMHOOINON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int ILFAGIGEOEF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] IHGIEGMHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JAJLOKMCIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PEOCOICDDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61BF1A0", Offset = "0x61BDBA0", VA = "0x1861BF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AFNFBIDCJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2191800", Offset = "0x2190200", VA = "0x182191800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KFLKHIJOPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61BF670", Offset = "0x61BE070", VA = "0x1861BF670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61BF750", Offset = "0x61BE150", VA = "0x1861BF750")]
	public void POOBHAENAOC(byte[] NEELBFFPDOA, int FDHHGENAMHL, int EHHKECBLJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FALGAJAMAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61BF790", Offset = "0x61BE190", VA = "0x1861BF790")]
	public FALGAJAMAFA(byte[] NEELBFFPDOA, int FDHHGENAMHL, int EHHKECBLJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61BF680", Offset = "0x61BE080", VA = "0x1861BF680")]
	public IPEndPoint PJEFDLPGOMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61BF350", Offset = "0x61BDD50", VA = "0x1861BF350")]
	public byte IMEKDMGANBH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x61BF350", Offset = "0x61BDD50", VA = "0x1861BF350")]
	public sbyte MJFJBAHNGGP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDB8C0", Offset = "0x2EDA2C0", VA = "0x182EDB8C0")]
	public T[] NBKOGBBGEFE<T>(ushort LEGDMNLNDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61BF0F0", Offset = "0x61BDAF0", VA = "0x1861BF0F0")]
	public bool[] FGJBOJPNGGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x61BEE80", Offset = "0x61BD880", VA = "0x1861BEE80")]
	public ushort[] EMCFBPCLOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61BEBD0", Offset = "0x61BD5D0", VA = "0x1861BEBD0")]
	public short[] AJAPPPCDBEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61BED90", Offset = "0x61BD790", VA = "0x1861BED90")]
	public int[] CONEFBONJEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61BF390", Offset = "0x61BDD90", VA = "0x1861BF390")]
	public uint[] JPFBNEKHDBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61BF310", Offset = "0x61BDD10", VA = "0x1861BF310")]
	public float[] IGONNIBGNPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61BF260", Offset = "0x61BDC60", VA = "0x1861BF260")]
	public double[] HMIIGLJGAFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61BEB90", Offset = "0x61BD590", VA = "0x1861BEB90")]
	public long[] AEELBGJNHEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61BEE40", Offset = "0x61BD840", VA = "0x1861BEE40")]
	public ulong[] EANBHEHIKAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61BF4B0", Offset = "0x61BDEB0", VA = "0x1861BF4B0")]
	public string[] LDLPGKBKLGO(int LHGPHLDLIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x61BEC10", Offset = "0x61BD610", VA = "0x1861BEC10")]
	public bool ALIAOAINHJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61BF130", Offset = "0x61BDB30", VA = "0x1861BF130")]
	public char FIGIIENJEKF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x61BF130", Offset = "0x61BDB30", VA = "0x1861BF130")]
	public ushort FKBBOKKAMJM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61BED20", Offset = "0x61BD720", VA = "0x1861BED20")]
	public short CJNPGEFJAHO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61BF440", Offset = "0x61BDE40", VA = "0x1861BF440")]
	public long LBHOMBOHPCA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61BF2A0", Offset = "0x61BDCA0", VA = "0x1861BF2A0")]
	public ulong HMNHNNFEJFA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x61BEC50", Offset = "0x61BD650", VA = "0x1861BEC50")]
	public int BIHENOJNHPE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61BF3D0", Offset = "0x61BDDD0", VA = "0x1861BF3D0")]
	public uint KKLINHIPLMN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x61BF1F0", Offset = "0x61BDBF0", VA = "0x1861BF1F0")]
	public float HKBKEAAHDCP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61BEDD0", Offset = "0x61BD7D0", VA = "0x1861BEDD0")]
	public double CPMNBHNIKAK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61BEEC0", Offset = "0x61BD8C0", VA = "0x1861BEEC0")]
	public string FEKDNLKELGI(int FGAJAFBGABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61BF600", Offset = "0x61BE000", VA = "0x1861BF600")]
	public ArraySegment<byte> MEJOAHAEDBM(int FPDJICFHLGM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61BECC0", Offset = "0x61BD6C0", VA = "0x1861BECC0")]
	public sbyte[] BKFFJCIGGOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61BF1B0", Offset = "0x61BDBB0", VA = "0x1861BF1B0")]
	public byte[] HBKMFEKPKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61BED00", Offset = "0x61BD700", VA = "0x1861BED00")]
	public void CFGGIHGKNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FNDHBIMBGAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] CIOOIMGPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int IHJMIEGJIFF;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int CINFKBCAPLE = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool HHIPKGFENLB;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding OPFBGPLDNOE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int NHGFPENPEPK = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] GPCBGJEACKO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] DKIFFIMODLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x61C0940", Offset = "0x61BF340", VA = "0x1861C0940")]
	public FNDHBIMBGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x61C08A0", Offset = "0x61BF2A0", VA = "0x1861C08A0")]
	public FNDHBIMBGAI(bool MEPAKKOAHGM, int OAHDPNJJBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x61BFB80", Offset = "0x61BE580", VA = "0x1861BFB80")]
	public static FNDHBIMBGAI BOEFBNGHAIG(string PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x61BFBF0", Offset = "0x61BE5F0", VA = "0x1861BFBF0")]
	public void GKPLEDLFDBC(int HJKFPLCCIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x220A7F0", Offset = "0x22091F0", VA = "0x18220A7F0")]
	public void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x61C02A0", Offset = "0x61BECA0", VA = "0x1861C02A0")]
	public void NLGFCELMCMK(float PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61C03F0", Offset = "0x61BEDF0", VA = "0x1861C03F0")]
	public void NLGFCELMCMK(double PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x61C03A0", Offset = "0x61BEDA0", VA = "0x1861C03A0")]
	public void NLGFCELMCMK(long PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x61C03A0", Offset = "0x61BEDA0", VA = "0x1861C03A0")]
	public void NLGFCELMCMK(ulong PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x61C0440", Offset = "0x61BEE40", VA = "0x1861C0440")]
	public void NLGFCELMCMK(int PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x61C0440", Offset = "0x61BEE40", VA = "0x1861C0440")]
	public void NLGFCELMCMK(uint PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x61C0230", Offset = "0x61BEC30", VA = "0x1861C0230")]
	public void NLGFCELMCMK(char PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61C0230", Offset = "0x61BEC30", VA = "0x1861C0230")]
	public void NLGFCELMCMK(ushort PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x61C0230", Offset = "0x61BEC30", VA = "0x1861C0230")]
	public void NLGFCELMCMK(short PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x61C0340", Offset = "0x61BED40", VA = "0x1861C0340")]
	public void NLGFCELMCMK(sbyte PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61C0340", Offset = "0x61BED40", VA = "0x1861C0340")]
	public void NLGFCELMCMK(byte PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61C01C0", Offset = "0x61BEBC0", VA = "0x1861C01C0")]
	public void NLGFCELMCMK(byte[] GGEMPJLCHFC, int FDHHGENAMHL, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x61BFF30", Offset = "0x61BE930", VA = "0x1861BFF30")]
	public void ICAEBEKCLAP(sbyte[] GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x61BFF30", Offset = "0x61BE930", VA = "0x1861BFF30")]
	public void MGNABIDKMOE(byte[] GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61C07B0", Offset = "0x61BF1B0", VA = "0x1861C07B0")]
	public void NLGFCELMCMK(bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61C0010", Offset = "0x61BEA10", VA = "0x1861C0010")]
	public void HIDHAOBGFBB(Array NHDPJAPCEID, int FFJFAGCJJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x61BFD70", Offset = "0x61BE770", VA = "0x1861BFD70")]
	public void HIDHAOBGFBB(float[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x61BFE50", Offset = "0x61BE850", VA = "0x1861BFE50")]
	public void HIDHAOBGFBB(double[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x61BFE50", Offset = "0x61BE850", VA = "0x1861BFE50")]
	public void HIDHAOBGFBB(long[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x61BFE50", Offset = "0x61BE850", VA = "0x1861BFE50")]
	public void HIDHAOBGFBB(ulong[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x61BFD70", Offset = "0x61BE770", VA = "0x1861BFD70")]
	public void HIDHAOBGFBB(int[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x61BFD70", Offset = "0x61BE770", VA = "0x1861BFD70")]
	public void HIDHAOBGFBB(uint[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x61BFC90", Offset = "0x61BE690", VA = "0x1861BFC90")]
	public void HIDHAOBGFBB(ushort[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61BFC90", Offset = "0x61BE690", VA = "0x1861BFC90")]
	public void HIDHAOBGFBB(short[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61BFF30", Offset = "0x61BE930", VA = "0x1861BFF30")]
	public void HIDHAOBGFBB(bool[] PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x61C00F0", Offset = "0x61BEAF0", VA = "0x1861C00F0")]
	public void HIDHAOBGFBB(string[] PKCLPFEIPFH, int GJHJAMBCECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x61C06E0", Offset = "0x61BF0E0", VA = "0x1861C06E0")]
	public void NLGFCELMCMK(IPEndPoint KHDABGLLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61C0810", Offset = "0x61BF210", VA = "0x1861C0810")]
	public void NLGFCELMCMK(string PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61C04D0", Offset = "0x61BEED0", VA = "0x1861C04D0")]
	public void NLGFCELMCMK(string PKCLPFEIPFH, int FGAJAFBGABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FKLDGAJINNK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PABGJHFEJBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong PGOLDFNFDHI;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4B4CEC0", Offset = "0x4B4B8C0", VA = "0x184B4CEC0")]
		static PABGJHFEJBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BLDGOIOMMNF(FALGAJAMAFA NIEHEDECLKP, object LADCACNCGMH);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EMOIEFGNGML<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public FKLDGAJINNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EMOIEFGNGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3B83EE0", Offset = "0x3B828E0", VA = "0x183B83EE0")]
		internal void MCHEPCPEJBG(FALGAJAMAFA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LJCCJFNIIDF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public FKLDGAJINNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LJCCJFNIIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4672460", Offset = "0x4670E60", VA = "0x184672460")]
		internal void MCHEPCPEJBG(FALGAJAMAFA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly OBPOGFOKIEN HNIGFBINHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, BLDGOIOMMNF> PLEHBEAKAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly FNDHBIMBGAI NBEFPIEDIGJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61BFA00", Offset = "0x61BE400", VA = "0x1861BFA00")]
	public FKLDGAJINNK(int LHGPHLDLIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDAA0", Offset = "0x2CDC4A0", VA = "0x182CDDAA0", Slot = "4")]
	protected virtual ulong EEAKDHELBKJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61BF8D0", Offset = "0x61BE2D0", VA = "0x1861BF8D0", Slot = "5")]
	protected virtual BLDGOIOMMNF PLMOLDJAEFJ(FALGAJAMAFA NIEHEDECLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1F10", Offset = "0x2EE0910", VA = "0x182EE1F10", Slot = "6")]
	protected virtual void CHIJKIPCDPI<T>(FNDHBIMBGAI KPBMLLGEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x61BF850", Offset = "0x61BE250", VA = "0x1861BF850")]
	public void GNKOLLGOHBH(FALGAJAMAFA NIEHEDECLKP, object LADCACNCGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1F80", Offset = "0x2EE0980", VA = "0x182EE1F80")]
	public void GGHBGBAFMCN<T>(FNDHBIMBGAI KPBMLLGEOOP, T MFLBDDIDFME) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61BF800", Offset = "0x61BE200", VA = "0x1861BF800")]
	public void FJGFODNCAPD(FALGAJAMAFA NIEHEDECLKP, object LADCACNCGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2EE21F0", Offset = "0x2EE0BF0", VA = "0x182EE21F0")]
	public void NPCDCBENKJM<T>(Action<T> GHKCHOHGBLC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2030", Offset = "0x2EE0A30", VA = "0x182EE2030")]
	public void NPCDCBENKJM<T, TUserData>(Action<T, TUserData> GHKCHOHGBLC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class JDADECDLCLK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x61BF7F0", Offset = "0x61BE1F0", VA = "0x1861BF7F0")]
	public JDADECDLCLK(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PMDGCGHNGOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61D3690", Offset = "0x61D2090", VA = "0x1861D3690")]
	public PMDGCGHNGOC(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OBPOGFOKIEN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KONLOEKBFMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class AAIIDGKGLMA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public KONLOEKBFMG DLLABFENMHB;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4079F20", Offset = "0x4078920", VA = "0x184079F20", Slot = "4")]
		public virtual void IGMCENCOPJL(MethodInfo ILGBHHAOBDH, MethodInfo ODFFLDNKDIN, KONLOEKBFMG BKKHBFLPOHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void DDIJFIDEHAE(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PPGCMNEILBJ(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected AAIIDGKGLMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CLNPEINAMBC<TClass, TProperty> : AAIIDGKGLMA<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> HCBHIMJLDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> FFEJEHBDOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> FJLLDCDFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> CFGDEFEGAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> IOFKLIIGGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> EMMFAKJJLHM;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x56F0730", Offset = "0x56EF130", VA = "0x1856F0730", Slot = "7")]
		public override void EJPEEDFJBMG(TClass LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x56F6170", Offset = "0x56F4B70", VA = "0x1856F6170", Slot = "8")]
		public override void OBIIKBCNIGN(TClass LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x56EF770", Offset = "0x56EE170", VA = "0x1856EF770", Slot = "9")]
		public override void DDIJFIDEHAE(TClass LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x56F6CD0", Offset = "0x56F56D0", VA = "0x1856F6CD0", Slot = "10")]
		public override void PPGCMNEILBJ(TClass LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x56F5960", Offset = "0x56F4360", VA = "0x1856F5960")]
		protected TProperty[] IJHMFNLALMA(TClass LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x56F0D50", Offset = "0x56EF750", VA = "0x1856F0D50")]
		protected TProperty[] EMEEPMFCKON(TClass LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x56F0DD0", Offset = "0x56EF7D0", VA = "0x1856F0DD0", Slot = "4")]
		public override void IGMCENCOPJL(MethodInfo ILGBHHAOBDH, MethodInfo ODFFLDNKDIN, KONLOEKBFMG BKKHBFLPOHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4B731F0", Offset = "0x4B71BF0", VA = "0x184B731F0")]
		protected CLNPEINAMBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class MHAEOAPLKEG<TClass, TProperty> : CLNPEINAMBC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CPOFCEKPJID(FALGAJAMAFA ECOIDHGKBHK, [Out] TProperty IGPPPMLCMBA);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KDDKNPFEHDF(FNDHBIMBGAI KJGNJHANGFM, TProperty IGPPPMLCMBA);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x48B8400", Offset = "0x48B6E00", VA = "0x1848B8400", Slot = "5")]
		public override void BBLIDPIOLCP(TClass LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x48B86B0", Offset = "0x48B70B0", VA = "0x1848B86B0", Slot = "6")]
		public override void GGHBGBAFMCN(TClass LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x48B8560", Offset = "0x48B6F60", VA = "0x1848B8560", Slot = "7")]
		public override void EJPEEDFJBMG(TClass LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x48B8800", Offset = "0x48B7200", VA = "0x1848B8800", Slot = "8")]
		public override void OBIIKBCNIGN(TClass LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x426C0B0", Offset = "0x426AAB0", VA = "0x18426C0B0")]
		protected MHAEOAPLKEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class NDJPCAMLHFG<T> : CLNPEINAMBC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x492C190", Offset = "0x492AB90", VA = "0x18492C190", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x492C290", Offset = "0x492AC90", VA = "0x18492C290", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x492C210", Offset = "0x492AC10", VA = "0x18492C210", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x41956A0", Offset = "0x41940A0", VA = "0x1841956A0", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public NDJPCAMLHFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class ONMLLBCFELG<T> : CLNPEINAMBC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4ABDE90", Offset = "0x4ABC890", VA = "0x184ABDE90", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x492C290", Offset = "0x492AC90", VA = "0x18492C290", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4ABDF10", Offset = "0x4ABC910", VA = "0x184ABDF10", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x41956A0", Offset = "0x41940A0", VA = "0x1841956A0", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public ONMLLBCFELG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BHGNKANBJOH<T> : CLNPEINAMBC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x528DD00", Offset = "0x528C700", VA = "0x18528DD00", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x493B8B0", Offset = "0x493A2B0", VA = "0x18493B8B0", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x528DD80", Offset = "0x528C780", VA = "0x18528DD80", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x493B920", Offset = "0x493A320", VA = "0x18493B920", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public BHGNKANBJOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NEOHFKEEJGF<T> : CLNPEINAMBC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x493B7B0", Offset = "0x493A1B0", VA = "0x18493B7B0", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x493B8B0", Offset = "0x493A2B0", VA = "0x18493B8B0", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x493B830", Offset = "0x493A230", VA = "0x18493B830", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x493B920", Offset = "0x493A320", VA = "0x18493B920", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public NEOHFKEEJGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OPKLDPJKEJP<T> : CLNPEINAMBC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4ABE440", Offset = "0x4ABCE40", VA = "0x184ABE440", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4ABE540", Offset = "0x4ABCF40", VA = "0x184ABE540", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4ABE4C0", Offset = "0x4ABCEC0", VA = "0x184ABE4C0", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x40C3780", Offset = "0x40C2180", VA = "0x1840C3780", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public OPKLDPJKEJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CDLIEILACDB<T> : CLNPEINAMBC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x540AB20", Offset = "0x5409520", VA = "0x18540AB20", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4ABE540", Offset = "0x4ABCF40", VA = "0x184ABE540", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x540ABA0", Offset = "0x54095A0", VA = "0x18540ABA0", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x40C3780", Offset = "0x40C2180", VA = "0x1840C3780", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public CDLIEILACDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PBLNFHIGFNL<T> : CLNPEINAMBC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4037580", Offset = "0x4035F80", VA = "0x184037580", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4037680", Offset = "0x4036080", VA = "0x184037680", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B53710", Offset = "0x4B52110", VA = "0x184B53710", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F14210", Offset = "0x3F12C10", VA = "0x183F14210", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public PBLNFHIGFNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class FPEGGGNBFOF<T> : CLNPEINAMBC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4037580", Offset = "0x4035F80", VA = "0x184037580", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4037680", Offset = "0x4036080", VA = "0x184037680", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4037600", Offset = "0x4036000", VA = "0x184037600", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F14210", Offset = "0x3F12C10", VA = "0x183F14210", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public FPEGGGNBFOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HMNLLPOIPOF<T> : CLNPEINAMBC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4195530", Offset = "0x4193F30", VA = "0x184195530", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4195630", Offset = "0x4194030", VA = "0x184195630", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x41955B0", Offset = "0x4193FB0", VA = "0x1841955B0", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x41956A0", Offset = "0x41940A0", VA = "0x1841956A0", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public HMNLLPOIPOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class AHPNIMPMKAH<T> : CLNPEINAMBC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x40C3610", Offset = "0x40C2010", VA = "0x1840C3610", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x40C3710", Offset = "0x40C2110", VA = "0x1840C3710", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x40C3690", Offset = "0x40C2090", VA = "0x1840C3690", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x40C3780", Offset = "0x40C2180", VA = "0x1840C3780", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public AHPNIMPMKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FCBPDCJIKDP<T> : CLNPEINAMBC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F140A0", Offset = "0x3F12AA0", VA = "0x183F140A0", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F141A0", Offset = "0x3F12BA0", VA = "0x183F141A0", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F14120", Offset = "0x3F12B20", VA = "0x183F14120", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F14210", Offset = "0x3F12C10", VA = "0x183F14210", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D1E0", Offset = "0x3B8BBE0", VA = "0x183B8D1E0")]
		public FCBPDCJIKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NBGBBKCBAHJ<T> : MHAEOAPLKEG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x490E4F0", Offset = "0x490CEF0", VA = "0x18490E4F0", Slot = "12")]
		protected override void KDDKNPFEHDF(FNDHBIMBGAI KJGNJHANGFM, char IGPPPMLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x490E4C0", Offset = "0x490CEC0", VA = "0x18490E4C0", Slot = "11")]
		protected override void CPOFCEKPJID(FALGAJAMAFA ECOIDHGKBHK, [Out] char IGPPPMLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EA60", Offset = "0x3B8D460", VA = "0x183B8EA60")]
		public NBGBBKCBAHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class MCBBBMEIKIH<T> : MHAEOAPLKEG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4879360", Offset = "0x4877D60", VA = "0x184879360", Slot = "12")]
		protected override void KDDKNPFEHDF(FNDHBIMBGAI KJGNJHANGFM, IPEndPoint IGPPPMLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4879320", Offset = "0x4877D20", VA = "0x184879320", Slot = "11")]
		protected override void CPOFCEKPJID(FALGAJAMAFA ECOIDHGKBHK, [Out] IPEndPoint IGPPPMLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EA60", Offset = "0x3B8D460", VA = "0x183B8EA60")]
		public MCBBBMEIKIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class MGDIKJEEPFM<T> : CLNPEINAMBC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int JKNMKAMNAEB;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x48B12B0", Offset = "0x48AFCB0", VA = "0x1848B12B0")]
		public MGDIKJEEPFM(int FGAJAFBGABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x48B10B0", Offset = "0x48AFAB0", VA = "0x1848B10B0", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x48B11B0", Offset = "0x48AFBB0", VA = "0x1848B11B0", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x48B1130", Offset = "0x48AFB30", VA = "0x1848B1130", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x48B1230", Offset = "0x48AFC30", VA = "0x1848B1230", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class DJKFNGOFEBL<T> : AAIIDGKGLMA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo HIFFIALDCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type HMBPCDHFAHB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C888B0", Offset = "0x5C872B0", VA = "0x185C888B0")]
		public DJKFNGOFEBL(PropertyInfo JKKOEFMEAMD, Type EBMMIFDFENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C885C0", Offset = "0x5C86FC0", VA = "0x185C885C0", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5C88740", Offset = "0x5C87140", VA = "0x185C88740", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5C886E0", Offset = "0x5C870E0", VA = "0x185C886E0", Slot = "7")]
		public override void EJPEEDFJBMG(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5C887F0", Offset = "0x5C871F0", VA = "0x185C887F0", Slot = "8")]
		public override void OBIIKBCNIGN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5C88680", Offset = "0x5C87080", VA = "0x185C88680", Slot = "9")]
		public override void DDIJFIDEHAE(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C88850", Offset = "0x5C87250", VA = "0x185C88850", Slot = "10")]
		public override void PPGCMNEILBJ(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class LJFFICFIOCD<T> : DJKFNGOFEBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FB70D0", Offset = "0x3FB5AD0", VA = "0x183FB70D0")]
		public LJFFICFIOCD(PropertyInfo JKKOEFMEAMD, Type EBMMIFDFENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4672580", Offset = "0x4670F80", VA = "0x184672580", Slot = "5")]
		public override void BBLIDPIOLCP(T LCFLNPONHMN, FALGAJAMAFA ECOIDHGKBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4672640", Offset = "0x4671040", VA = "0x184672640", Slot = "6")]
		public override void GGHBGBAFMCN(T LCFLNPONHMN, FNDHBIMBGAI KJGNJHANGFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class DFHEBAEGNEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static DFHEBAEGNEG<T> JOLICDCBKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly AAIIDGKGLMA<T>[] IHLHPGOLLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int KGIMMEFMAOP;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C83390", Offset = "0x5C81D90", VA = "0x185C83390")]
		public DFHEBAEGNEG(List<AAIIDGKGLMA<T>> HPCENLNFCHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C832E0", Offset = "0x5C81CE0", VA = "0x185C832E0")]
		public void GGHBGBAFMCN(T BBNKFKDCOLP, FNDHBIMBGAI KPBMLLGEOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C83230", Offset = "0x5C81C30", VA = "0x185C83230")]
		public void BBLIDPIOLCP(T BBNKFKDCOLP, FALGAJAMAFA NIEHEDECLKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class AEFJEJDADIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract AAIIDGKGLMA<T> KJCABELIABF<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private FNDHBIMBGAI HMMPEBPMNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int OLOAKANCNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, AEFJEJDADIK> HEGPJBMJHNK;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61D2CF0", Offset = "0x61D16F0", VA = "0x1861D2CF0")]
	public OBPOGFOKIEN(int LHGPHLDLIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3074570", Offset = "0x3072F70", VA = "0x183074570")]
	private DFHEBAEGNEG<T> JGCFJNODNCG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2D282F0", Offset = "0x2D26CF0", VA = "0x182D282F0")]
	public void KFMGLABNFNG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3074440", Offset = "0x3072E40", VA = "0x183074440")]
	public bool DLDAMIHNNNK<T>(FALGAJAMAFA NIEHEDECLKP, T PCFKCJNPKCO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x30744E0", Offset = "0x3072EE0", VA = "0x1830744E0")]
	public void HLGBFIEHJDG<T>(FNDHBIMBGAI KPBMLLGEOOP, T BBNKFKDCOLP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IFILGIJLBIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime KHGEDJAIKAG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] GLGMFKHNMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MFBCDFAHODB DGADMAJHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x61C5820", Offset = "0x61C4220", VA = "0x1861C5820")]
		get
		{
			return default(MFBCDFAHODB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BFCKPCIAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x61C5DE0", Offset = "0x61C47E0", VA = "0x1861C5DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61C6310", Offset = "0x61C4D10", VA = "0x1861C6310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OMHAGBFMDBC BALMKFGADML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x61C5A50", Offset = "0x61C4450", VA = "0x1861C5A50")]
		get
		{
			return default(OMHAGBFMDBC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61C6100", Offset = "0x61C4B00", VA = "0x1861C6100")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FEEIDDCAPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61C60D0", Offset = "0x61C4AD0", VA = "0x1861C60D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint NLEHGOPDLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x61C6140", Offset = "0x61C4B40", VA = "0x1861C6140")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? JGPKAGLEOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x61C5B50", Offset = "0x61C4550", VA = "0x1861C5B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DEFCDBCIMII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x61C5B80", Offset = "0x61C4580", VA = "0x1861C5B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? JDAFOPAHHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x61C62E0", Offset = "0x61C4CE0", VA = "0x1861C62E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x61C6350", Offset = "0x61C4D50", VA = "0x1861C6350")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? LONMHEFKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x97E910", Offset = "0x97D310", VA = "0x18097E910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x97EA30", Offset = "0x97D430", VA = "0x18097EA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x61C66C0", Offset = "0x61C50C0", VA = "0x1861C66C0")]
	public IFILGIJLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x61C6610", Offset = "0x61C5010", VA = "0x1861C6610")]
	internal IFILGIJLBIJ(byte[] FFGGPAIGPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x61C61C0", Offset = "0x61C4BC0", VA = "0x1861C61C0")]
	public static IFILGIJLBIJ KLBKINCMOOB(byte[] FFGGPAIGPAA, DateTime CLNGMKDEGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x61C5ED0", Offset = "0x61C48D0", VA = "0x1861C5ED0")]
	internal void JBKGHBLBPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x61C5640", Offset = "0x61C4040", VA = "0x1861C5640")]
	private void BANGGBMAFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x61C5850", Offset = "0x61C4250", VA = "0x1861C5850")]
	private DateTime? BHLDMHNIKPD(int FDHHGENAMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x61C5BB0", Offset = "0x61C45B0", VA = "0x1861C5BB0")]
	private void GLOGBCIILHC(int FDHHGENAMHL, DateTime? PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x61C5A80", Offset = "0x61C4480", VA = "0x1861C5A80")]
	private ulong DNBLNGLBHCE(int FDHHGENAMHL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x61C5E10", Offset = "0x61C4810", VA = "0x1861C5E10")]
	private void IBDCPNNIDNM(int FDHHGENAMHL, ulong PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x61C6520", Offset = "0x61C4F20", VA = "0x1861C6520")]
	private uint OFAOIGIECOD(int FDHHGENAMHL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6091620", Offset = "0x6090020", VA = "0x186091620")]
	private static uint HCHJHGNHLJD(uint PMBJFHIMJKC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x61C5D80", Offset = "0x61C4780", VA = "0x1861C5D80")]
	private static ulong HCHJHGNHLJD(ulong PMBJFHIMJKC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MFBCDFAHODB
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum OMHAGBFMDBC
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class CIDCFHHJGHH
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int GPNPPDAOKEE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int CDLAEHOOCFK = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int MGODLAJKGCB = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint EMHHNONFCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int GPJCIEKONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int FOLEEMNOLCB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KNCMDEHOCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x61BD520", Offset = "0x61BBF20", VA = "0x1861BD520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x61BD430", Offset = "0x61BBE30", VA = "0x1861BD430")]
	public bool OBPNLDALOGD(JOMEBMIPEPA OBINFJLIHFF, int FADJNLBACEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class BHJDILFHMBF : JOMEBMIPEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket OBINFJLIHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly JBGMLHLIBMP PFOEGFDHCKH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short PJHAFGJJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61BC8D0", Offset = "0x61BB2D0", VA = "0x1861BC8D0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DNBLHMOPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x61BCA20", Offset = "0x61BB420", VA = "0x1861BCA20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint HBOGINIMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x61BC910", Offset = "0x61BB310", VA = "0x1861BC910", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily OELFMJDMIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x463F370", Offset = "0x463DD70", VA = "0x18463F370", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x61BD040", Offset = "0x61BBA40", VA = "0x1861BD040")]
	public BHJDILFHMBF(AddressFamily CGLKJFJHONI, JBGMLHLIBMP PFOEGFDHCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x61BCA40", Offset = "0x61BB440", VA = "0x1861BCA40", Slot = "8")]
	public bool OFGCIOEHJDJ(IPEndPoint KHDABGLLEML, FLKIAPGLKIP EGCJMNBGMFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x61BD000", Offset = "0x61BBA00", VA = "0x1861BD000", Slot = "9")]
	public int PBLOCCGEJIG(byte[] GNKEDFJBDMM, int FDHHGENAMHL, int LEGDMNLNDAK, IPEndPoint LBMNBGDMOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61BC930", Offset = "0x61BB330", VA = "0x1861BC930", Slot = "10")]
	public int KCDANMPEOPE(byte[] GNKEDFJBDMM, EndPoint DGEIIKMPLFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61BC8F0", Offset = "0x61BB2F0", VA = "0x1861BC8F0", Slot = "11")]
	public void IBFEFEHLHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface JOMEBMIPEPA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short PJHAFGJJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int DNBLHMOPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint HBOGINIMHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily OELFMJDMIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFGCIOEHJDJ(IPEndPoint KHDABGLLEML, FLKIAPGLKIP EGCJMNBGMFE);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PBLOCCGEJIG(byte[] GNKEDFJBDMM, int FDHHGENAMHL, int LEGDMNLNDAK, IPEndPoint LBMNBGDMOGK);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KCDANMPEOPE(byte[] GNKEDFJBDMM, EndPoint LBMNBGDMOGK);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBFEFEHLHNE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct MLJKJCMHOPE : IEquatable<MLJKJCMHOPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long LOMLNBENENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long OPEECFDKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long FBMCEJMFMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int JBJIAGAJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int FCCKPKHKGPB;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x61D2530", Offset = "0x61D0F30", VA = "0x1861D2530")]
	public MLJKJCMHOPE(byte[] DOLPOJJLONL, int PKNKJMGFDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C70", Offset = "0x8D3670", VA = "0x1808D4C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x61D2440", Offset = "0x61D0E40", VA = "0x1861D2440", Slot = "4")]
	public bool Equals(MLJKJCMHOPE GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x61D2480", Offset = "0x61D0E80", VA = "0x1861D2480", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class DFKNGPCCBOO : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] EPEKFFPLDHA;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class KKDMKKEJOPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int FKNHJDGCLNA;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
	protected KKDMKKEJOPE(int LJDFMJFFHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DLPGBJJOMPG(IPEndPoint KHDABGLLEML, byte[] GGEMPJLCHFC, int FDHHGENAMHL, int JGKAMGBGMHI);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CNHEJPPOBDG(IPEndPoint KHDABGLLEML, byte[] GGEMPJLCHFC, int FDHHGENAMHL, int JGKAMGBGMHI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MENFBPOKAKP : KKDMKKEJOPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] PNABAFEIDND;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator AHBACAMHOAN;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x22AEE40", Offset = "0x22AD840", VA = "0x1822AEE40")]
	public MENFBPOKAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x61D17E0", Offset = "0x61D01E0", VA = "0x1861D17E0")]
	public void LGBGBFCFLBC(IPEndPoint KHDABGLLEML, byte[] PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x61D0EF0", Offset = "0x61CF8F0", VA = "0x1861D0EF0")]
	public void AFHELLOEIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61D1330", Offset = "0x61CFD30", VA = "0x1861D1330", Slot = "4")]
	public override void DLPGBJJOMPG(IPEndPoint KHDABGLLEML, byte[] GGEMPJLCHFC, int FDHHGENAMHL, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x61D0FD0", Offset = "0x61CF9D0", VA = "0x1861D0FD0", Slot = "5")]
	public override void CNHEJPPOBDG(IPEndPoint KHDABGLLEML, byte[] GGEMPJLCHFC, int FDHHGENAMHL, int JGKAMGBGMHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct IFDDFFAKHEP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void JLKEAHPCHOK([NoAlias] byte* GKJPDIEOABI, [NoAlias] byte* PNABAFEIDND, [NoAlias] byte* KOJKLFJACNB, int JGKAMGBGMHI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class MNFHCEBBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr AKIGLNJDJIN;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr ANBPBHJGJFO;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x61D3B70", Offset = "0x61D2570", VA = "0x1861D3B70")]
		[BurstDiscard]
		private static void KEHGOLEFHHC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x61D37F0", Offset = "0x61D21F0", VA = "0x1861D37F0")]
		private static IntPtr BAMLOHECMNL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x61D3C90", Offset = "0x61D2690", VA = "0x1861D3C90")]
		public static void NMGGIIPGNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
		public static void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x61D3940", Offset = "0x61D2340", VA = "0x1861D3940")]
		public unsafe static void GHJBKJMLHEK([NoAlias] byte* GKJPDIEOABI, [NoAlias] byte* PNABAFEIDND, [NoAlias] byte* KOJKLFJACNB, int JGKAMGBGMHI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint PNABAFEIDND[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint KOJKLFJACNB[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint LBGNHGNIINA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint CIKLJLNDIAE[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint MEPCDDEIAIC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint GPKCEPGDKKK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint GPDKGGBPPAD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint DJJGLFEPPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint KCCCBGLBFAM[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x61C5400", Offset = "0x61C3E00", VA = "0x1861C5400")]
	private void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x61C53D0", Offset = "0x61C3DD0", VA = "0x1861C53D0")]
	private uint EIGMGFJAOBC(uint KGHNFJGNNEO, int FKNCPKFPJJK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x61BC230", Offset = "0x61BAC30", VA = "0x1861BC230")]
	private void DJIOGCMCHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x61BC470", Offset = "0x61BAE70", VA = "0x1861BC470")]
	private void MNKELPDIHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x61BC3E0", Offset = "0x61BADE0", VA = "0x1861BC3E0")]
	private void MEFGIHIFHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x61BC2E0", Offset = "0x61BACE0", VA = "0x1861BC2E0")]
	private void KIELGNJLAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x61C55E0", Offset = "0x61C3FE0", VA = "0x1861C55E0")]
	private void NNGGKNHCGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x61C4E40", Offset = "0x61C3840", VA = "0x1861C4E40")]
	private unsafe void ADNEHJOCEBO(byte* GKJPDIEOABI, uint* PNABAFEIDND, uint* KOJKLFJACNB, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x61C5480", Offset = "0x61C3E80", VA = "0x1861C5480")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IPFHKHBMKBI([NoAlias] byte* GKJPDIEOABI, [NoAlias] byte* PNABAFEIDND, [NoAlias] byte* KOJKLFJACNB, int JGKAMGBGMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x61C5500", Offset = "0x61C3F00", VA = "0x1861C5500")]
	public static void IPFHKHBMKBI(Span<byte> GKJPDIEOABI, Span<byte> PNABAFEIDND, Span<byte> KOJKLFJACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x61C52D0", Offset = "0x61C3CD0", VA = "0x1861C52D0")]
	public static void EGGDDDNJNPM(Span<byte> GKJPDIEOABI, Span<byte> PNABAFEIDND, Span<byte> KOJKLFJACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x61C5260", Offset = "0x61C3C60", VA = "0x1861C5260")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BMKNDJDGAGK([NoAlias] byte* GKJPDIEOABI, [NoAlias] byte* PNABAFEIDND, [NoAlias] byte* KOJKLFJACNB, int JGKAMGBGMHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61D3D30", Offset = "0x61D2730", VA = "0x1861D3D30")]
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
