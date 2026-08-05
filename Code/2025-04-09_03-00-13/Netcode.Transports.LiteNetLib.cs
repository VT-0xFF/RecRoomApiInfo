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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ACBOFIPJCPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JNGIGKIEOBG
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
		private NetworkManager LMLGIBIBIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool IJMPDGHBMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, PKFJACOKBGM> LPMFDFNCLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private HNKCBLCMLIG EAOGPBDCEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch EJNKMIEDDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] AAOLNJGMLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JNGIGKIEOBG EPFKKHGPFIB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong GNHBJBODBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IPHKFFIDCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6B91F90", Offset = "0x6B91390", VA = "0x186B91F90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B91510", Offset = "0x6B90910", VA = "0x186B91510")]
		public void RecRoom_SetEncryptionInfo(ulong DKLNCJJDNBJ, byte[] DJBLFBEBKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B914F0", Offset = "0x6B908F0", VA = "0x186B914F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B912F0", Offset = "0x6B906F0", VA = "0x186B912F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B91E90", Offset = "0x6B91290", VA = "0x186B91E90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B91630", Offset = "0x6B90A30", VA = "0x186B91630", Slot = "6")]
		public override void Send(ulong PJOFMLFGDBO, ArraySegment<byte> HPMNBNLACCC, NetworkDelivery NEBFBIPMBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B914B0", Offset = "0x6B908B0", VA = "0x186B914B0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong PJOFMLFGDBO, [Out] ArraySegment<byte> DMDJHNIAOJN, [Out] float NIBDADFINKG)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B91920", Offset = "0x6B90D20", VA = "0x186B91920", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91DB0", Offset = "0x6B911B0", VA = "0x186B91DB0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B90A30", Offset = "0x6B8FE30", VA = "0x186B90A30", Slot = "11")]
		public override void DisconnectRemoteClient(ulong PJOFMLFGDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B90940", Offset = "0x6B8FD40", VA = "0x186B90940", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B90C70", Offset = "0x6B90070", VA = "0x186B90C70", Slot = "13")]
		public override ulong GetCurrentRtt(ulong PJOFMLFGDBO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B918B0", Offset = "0x6B90CB0", VA = "0x186B918B0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B90DF0", Offset = "0x6B901F0", VA = "0x186B90DF0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager LMLGIBIBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B913E0", Offset = "0x6B907E0", VA = "0x186B913E0")]
		private ENLKJEGHNDK PPPGLMHDKPL(NetworkDelivery HAFNBBNOLPO)
		{
			return default(ENLKJEGHNDK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B91230", Offset = "0x6B90630", VA = "0x186B91230", Slot = "16")]
		private void OEBDIDLMLEH(PKFJACOKBGM IAABMOEDKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B90BA0", Offset = "0x6B8FFA0", VA = "0x186B90BA0", Slot = "17")]
		private void GKOMPADGOPF(PKFJACOKBGM IAABMOEDKHJ, AFCGCNLODDE AFDNCEJMEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "18")]
		private void CONBPFJCDFM(IPEndPoint GPMGNDICFDJ, SocketError ANIJCKIJCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B91020", Offset = "0x6B90420", VA = "0x186B91020", Slot = "19")]
		private void MHFENLDCEFN(PKFJACOKBGM IAABMOEDKHJ, IGBOAOKMOPI HGFGHNJEEAJ, byte CIEAKAJDBIG, ENLKJEGHNDK FFCKLDKHINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B90D10", Offset = "0x6B90110", VA = "0x186B90D10")]
		private void HHHBLHLGCIJ(int MNDMOIHIBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "20")]
		private void BKLGBMHPLJP(IPEndPoint FHIIAMOAEHB, IGBOAOKMOPI HGFGHNJEEAJ, JLCMEGANLFF IHFKGHJIOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "21")]
		private void HMLFLJMIEFO(PKFJACOKBGM IAABMOEDKHJ, int JELKEJIHFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B90B40", Offset = "0x6B8FF40", VA = "0x186B90B40", Slot = "22")]
		private void ENBGBLGEDNG(JLOJOBBFHCG ANMDEHLLLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B90910", Offset = "0x6B8FD10", VA = "0x186B90910")]
		private ulong AJAFMDJGFFG(PKFJACOKBGM IAABMOEDKHJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91000", Offset = "0x6B90400", VA = "0x186B91000")]
		private static int JKLJJLHABDH(float PCFGHPNONAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B91EB0", Offset = "0x6B912B0", VA = "0x186B91EB0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EGAMCOMLAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly PKFJACOKBGM DMGLIFHBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<KADKJNFJFNA> GFHOPMDKPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int MBMGPIFODBB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B83390", Offset = "0x6B82790", VA = "0x186B83390")]
	protected EGAMCOMLAPH(PKFJACOKBGM IAABMOEDKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B832B0", Offset = "0x6B826B0", VA = "0x186B832B0")]
	public void HFPJPDLPCLC(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B83310", Offset = "0x6B82710", VA = "0x186B83310")]
	protected void OFAIIEBNPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B83270", Offset = "0x6B82670", VA = "0x186B83270")]
	public bool DDJJDAGNGLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OIJFCFCPEAK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PPHCBLOOFAF(KADKJNFJFNA GBLAOBBFOOI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum LPNOHOBOIGE
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JLOJOBBFHCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HNKCBLCMLIG MPONJGAKLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int OJJCNDCIAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal FHHLDIFLMKM GNBAPHLGHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint LAKEGCHCIIN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LPNOHOBOIGE DDFNFMDIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D2A50", Offset = "0x9D1E50", VA = "0x1809D2A50")]
		[CompilerGenerated]
		get
		{
			return default(LPNOHOBOIGE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCAA680", Offset = "0xCA9A80", VA = "0x180CAA680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FD10", Offset = "0x6B8F110", VA = "0x186B8FD10")]
	internal void OHFFFDOEDFA(FHHLDIFLMKM NKLLJHPBAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC80", Offset = "0x6B8F080", VA = "0x186B8FC80")]
	private bool KJHJNLCFAAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FD70", Offset = "0x6B8F170", VA = "0x186B8FD70")]
	internal JLOJOBBFHCG(IPEndPoint FHIIAMOAEHB, FHHLDIFLMKM NDBOILHHKAB, HNKCBLCMLIG DBNBJHEMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FCB0", Offset = "0x6B8F0B0", VA = "0x186B8FCB0")]
	public PKFJACOKBGM NCOLJFEPOON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JLCMEGANLFF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BNBGKDGLEAD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AFCGCNLODDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public BNBGKDGLEAD JBDKBGBKABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError KGKIINCPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public IGBOAOKMOPI JJGKPEEFMAC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ACBOFIPJCPO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIDCDPLHHMC(PKFJACOKBGM IAABMOEDKHJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEFBEIIOOHA(PKFJACOKBGM IAABMOEDKHJ, AFCGCNLODDE AFDNCEJMEEN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGJIOFACHLL(IPEndPoint GPMGNDICFDJ, SocketError ANIJCKIJCPN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCIPEHJKBPE(PKFJACOKBGM IAABMOEDKHJ, IGBOAOKMOPI HGFGHNJEEAJ, byte CIEAKAJDBIG, ENLKJEGHNDK FFCKLDKHINF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFNKOOEHJFL(IPEndPoint FHIIAMOAEHB, IGBOAOKMOPI HGFGHNJEEAJ, JLCMEGANLFF IHFKGHJIOCE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAOONAJBNPJ(PKFJACOKBGM IAABMOEDKHJ, int JELKEJIHFML);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGBLDAPJOOF(JLOJOBBFHCG ANMDEHLLLBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HIJCLMENIFB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGFMLKIAGNI(PKFJACOKBGM IAABMOEDKHJ, object ALCDDFEIMFD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FJENAOLJGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKLFHBOEAIF(ENLAOPDJMNP GBLAOBBFOOI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KOGHJFIHLFF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJKCKHHADBE(PKFJACOKBGM IAABMOEDKHJ, IPEndPoint DHDLHCNLKCF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FHHLDIFLMKM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int LBMJGNPKIFJ = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long OLMMABEIMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte FHCOPPGFALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] FHGKLHIDIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly JKEDBGGDMBH EEHHJHNNGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int KOKCPELNKEE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B85A70", Offset = "0x6B84E70", VA = "0x186B85A70")]
	private FHHLDIFLMKM(long BGGINHKEBDO, byte NINMDOKDMNE, int KJCJJFGLKEE, byte[] KKHCKBHHPJG, JKEDBGGDMBH HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B85610", Offset = "0x6B84A10", VA = "0x186B85610")]
	public static int EHPHJAPDBGP(KADKJNFJFNA GBLAOBBFOOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B85850", Offset = "0x6B84C50", VA = "0x186B85850")]
	public static FHHLDIFLMKM JAIPCLMMBGA(KADKJNFJFNA GBLAOBBFOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B85670", Offset = "0x6B84A70", VA = "0x186B85670")]
	public static KADKJNFJFNA IBMJBLNIPBK(EGJDBJHJPJD NOCMBGBHEDM, SocketAddress FHPFJLANGDE, long KMOHNFPIMHO, int KJCJJFGLKEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MHJOPEJFKEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long OLMMABEIMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte FHCOPPGFALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int KOKCPELNKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool GBBDHCBAKMD;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B92F90", Offset = "0x6B92390", VA = "0x186B92F90")]
	private MHJOPEJFKEI(long BGGINHKEBDO, byte NINMDOKDMNE, int PBKGCEIOFFH, bool JGBDPKJPAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B92E40", Offset = "0x6B92240", VA = "0x186B92E40")]
	public static MHJOPEJFKEI JAIPCLMMBGA(KADKJNFJFNA GBLAOBBFOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B92D50", Offset = "0x6B92150", VA = "0x186B92D50")]
	public static KADKJNFJFNA IBMJBLNIPBK(long KMOHNFPIMHO, byte BGHOAHNPNHJ, int OCLNLAGFOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B92C50", Offset = "0x6B92050", VA = "0x186B92C50")]
	public static KADKJNFJFNA CCJIHMNKFPF(PKFJACOKBGM IAABMOEDKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GGKCCMEAGKL
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BLOALLKEIHE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBFBLAHGBCB(IPEndPoint MLOPJFENFPC, IPEndPoint FHIIAMOAEHB, string HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COOLDODEGFA(IPEndPoint EEAPMOJCLND, GGKCCMEAGKL HAFNBBNOLPO, string HHGPJKKLNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CFOHKDKILPG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct LALIPLCHFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint COFDEGBJDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint LAKEGCHCIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string IFEMJINDLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HMPJEGFLGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint DKMFJIBEMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GGKCCMEAGKL KAFGKIIBACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string IFEMJINDLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class OGIDLEDJLPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint NAILMOEKKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IFEMJINDLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OGIDLEDJLPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class FGGCBFOMIHH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NAILMOEKKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint BHOPDAMMCBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IFEMJINDLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FGGCBFOMIHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class AGKNFPHFEGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IFEMJINDLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EIDHBMNBDNI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3680", Offset = "0x9B2A80", VA = "0x1809B3680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public AGKNFPHFEGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HNKCBLCMLIG MMCAJLPBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<LALIPLCHFLJ> ECFKJGMFCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<HMPJEGFLGIL> NKLLCABKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JKEDBGGDMBH LCINADJAAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EGJDBJHJPJD BCFEMPAIBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HJDKFEJKJNA GMDOLILGNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private BLOALLKEIHE DDGFOCHEDCJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int PELDGCJKOIJ = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool CMCAFNOOBEG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B82230", Offset = "0x6B81630", VA = "0x186B82230")]
	internal CFOHKDKILPG(HNKCBLCMLIG NFAIKPDMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B81F20", Offset = "0x6B81320", VA = "0x186B81F20")]
	internal void GBBBDDANJFH(IPEndPoint CAIMCAAHFBK, KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33FDAE0", Offset = "0x33FCEE0", VA = "0x1833FDAE0")]
	private void CBLPHADFEEI<T>(T GBLAOBBFOOI, IPEndPoint IGICHEAKAKH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B81D90", Offset = "0x6B81190", VA = "0x186B81D90")]
	private void FBFBLAHGBCB(OGIDLEDJLPD KGDGKKGKMBC, IPEndPoint CAIMCAAHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B81C30", Offset = "0x6B81030", VA = "0x186B81C30")]
	private void AHHACCDABKL(FGGCBFOMIHH KGDGKKGKMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B820A0", Offset = "0x6B814A0", VA = "0x186B820A0")]
	private void JKEPIBIKPJB(AGKNFPHFEGM KGDGKKGKMBC, IPEndPoint CAIMCAAHFBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ENLKJEGHNDK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DNHMOPIIEKB : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KNKGBOLKCON
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] EOAGAMMOAJA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int LEFCOCGFOOL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int EBAPBCJBEMN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IPNICCACDPC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B81310", Offset = "0x6B80710", VA = "0x186B81310")]
	public IPNICCACDPC(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KFKGFAGPDPO : IPNICCACDPC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B81310", Offset = "0x6B80710", VA = "0x186B81310")]
	public KFKGFAGPDPO(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NNCLICPHNIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CMPJAAFMDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHMPGBNBDKD(NNCLICPHNIJ DEBJGENBPIA, string IPAAOHHFILB, params object[] BPKDFLJLPAA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MALEOCFGMKJ
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static CMPJAAFMDCC KGAEDNPMLNE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object FLHGEAFEFNF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B92010", Offset = "0x6B91410", VA = "0x186B92010")]
	private static void FKLNOJNHLPL(NNCLICPHNIJ GBJPIBBDPNO, string IPAAOHHFILB, params object[] BPKDFLJLPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B92240", Offset = "0x6B91640", VA = "0x186B92240")]
	internal static void HMEFHBIKIBA(string IPAAOHHFILB, params object[] BPKDFLJLPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B922A0", Offset = "0x6B916A0", VA = "0x186B922A0")]
	internal static void JPKIGLJOPCH(string IPAAOHHFILB, params object[] BPKDFLJLPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B91FB0", Offset = "0x6B913B0", VA = "0x186B91FB0")]
	internal static void ADCNPHKKNBE(string IPAAOHHFILB, params object[] BPKDFLJLPAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HNGEAILFMHJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IGBOAOKMOPI : JKEDBGGDMBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private KADKJNFJFNA JAIAFDFJHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HNKCBLCMLIG FFLFCCNMOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NBPLBMIAGNK MMGPFFMFLII;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E770", Offset = "0x6B8DB70", VA = "0x186B8E770")]
	internal IGBOAOKMOPI(HNKCBLCMLIG HEKFIEJNOCO, NBPLBMIAGNK KLCAIGNGMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E650", Offset = "0x6B8DA50", VA = "0x186B8E650")]
	internal void HMCHDIIDHGE(KADKJNFJFNA GBLAOBBFOOI, int MCGBMGGADEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E6C0", Offset = "0x6B8DAC0", VA = "0x186B8E6C0")]
	internal void IONLDLIBPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E740", Offset = "0x6B8DB40", VA = "0x186B8E740")]
	public void JACGBLBHMPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NBPLBMIAGNK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PNJNJBCKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NBPLBMIAGNK HNICEFLLFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public PNJNJBCKEJA KAFGKIIBACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PKFJACOKBGM DMGLIFHBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint LAKEGCHCIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object GOLAJIEPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int LAAOGPCEOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError FLMJECNBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public BNBGKDGLEAD OCOKDAEHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public JLOJOBBFHCG FEKBLNLLMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public ENLKJEGHNDK NNFCNMFKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte BBKCFPMKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IGBOAOKMOPI HAKFBBHELLD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B92FE0", Offset = "0x6B923E0", VA = "0x186B92FE0")]
	public NBPLBMIAGNK(HNKCBLCMLIG HEKFIEJNOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HNKCBLCMLIG : IEnumerable<PKFJACOKBGM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class FIKKKEOELBF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6B85AE0", Offset = "0x6B84EE0", VA = "0x186B85AE0", Slot = "4")]
		public bool Equals(IPEndPoint MEAMPLHPPKP, IPEndPoint KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6708DB0", Offset = "0x67081B0", VA = "0x186708DB0", Slot = "5")]
		public int GetHashCode(IPEndPoint BLFGIKOAKOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FIKKKEOELBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct MGHDBGAJDLM : IEnumerator<PKFJACOKBGM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly PKFJACOKBGM CKHNDKJAAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private PKFJACOKBGM PFHKOPLHBHA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PKFJACOKBGM JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF3C00", Offset = "0xCF3000", VA = "0x180CF3C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF3C00", Offset = "0xCF3000", VA = "0x180CF3C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x18D2150", Offset = "0x18D1550", VA = "0x1818D2150")]
		public MGHDBGAJDLM(PKFJACOKBGM ICNDIBLBLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B92BB0", Offset = "0x6B91FB0", VA = "0x186B92BB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B92C00", Offset = "0x6B92000", VA = "0x186B92C00", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread PGGIDKKIBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool BCIDHJBDIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool HAPBLBAPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GNGFEMKCGJM DKJLOBNGLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent AMNCLCIJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<NBPLBMIAGNK> INJOCOJAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NBPLBMIAGNK> DKIAAOLDNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NBPLBMIAGNK DOEBAKNHECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ACBOFIPJCPO GFMLHDDGBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly HIJCLMENIFB AKEBEEAKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FJENAOLJGDO HLKLKHMCCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KOGHJFIHLFF PGNPPLKHNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, PKFJACOKBGM> LGBAFIGBKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, JLOJOBBFHCG> HKBLIANGPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, EDGJFADDDKE> AGOCPCLJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim PGPLPPPJBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private PKFJACOKBGM LBGDJNNMNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int CAHHIKIAFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<PKFJACOKBGM> LPJIPJAGFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private PKFJACOKBGM[] HGMNDGCMNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ILGFMKGKFLD BGAOFCLBOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int JIHCKCHLKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> NCFEGOEONFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte INIKLLDLENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object KOOJFOLKCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool JHOLBGBEHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool DLHAAOHOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int AEDLEAMPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int PFPELJLMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NPEPFAPDFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CJOHNMDIIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LJACECNAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool PNHDBPJEMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int IGNMFCPEJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int HNBFBPOHPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int KMCPNLIHDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool CMCAFNOOBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool OHCHKHIMFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FEBPMDEOLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool BBMAPPFKOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int LDHIMHAGNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int CBPFPLJJMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool GBOGOAJNIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly CFNPPLJMBBK ACNBPHFHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PKEDMBJGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly CFOHKDKILPG LDKIBIOILIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool AFEENHGAFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public HNGEAILFMHJ KEJFLLGBKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int ALAKPFDMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool DCPJJNPMLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool BEIPACCLHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool GMDEPNNIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool LLDCGEDGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private KADKJNFJFNA FMKIPNPMLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int OEFGLFAGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object CAOJKFEPCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KADKJNFJFNA CGIFDAPPGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int EJJPGFAIHFG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int ALMEPCELLAG = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int AOJBHPABLKK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private OFICCEDJJEN BLBMHPMLCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private OFICCEDJJEN NEPEOLEFLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread EEIEKJLDKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread EHBHPAGGNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint GIFBICHMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint IHIPANJDBKB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] HKNKHLMIMAD;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] MPPPOODFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<PHJJDDHBJDK, IPEndPoint> EAKIFLHCELA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress FIKDMMNGKJN;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool IDDMAFPPBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int ONPJFNCJFJO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HFIEHJEKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x134D3F0", Offset = "0x134C7F0", VA = "0x18134D3F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D27EB0", Offset = "0x1D272B0", VA = "0x181D27EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JHNDJMCEMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1455400", Offset = "0x1454800", VA = "0x181455400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1D280C0", Offset = "0x1D274C0", VA = "0x181D280C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte BNCGKJJPHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE60480", Offset = "0xE5F880", VA = "0x180E60480")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BIKHFCGLODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DA70", Offset = "0x6B8CE70", VA = "0x186B8DA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short PFONHEFMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A960", Offset = "0x6B89D60", VA = "0x186B8A960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C480", Offset = "0x6B8B880", VA = "0x186B8C480")]
	public void PIJAKIJOAGL(IPEndPoint GPMGNDICFDJ, byte[] DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B867F0", Offset = "0x6B85BF0", VA = "0x186B867F0")]
	public void ALHCLBPMBOD(IPEndPoint GPMGNDICFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B89260", Offset = "0x6B88660", VA = "0x186B89260")]
	private bool FNOHDNDFLNK(IPEndPoint GPMGNDICFDJ, [Out] PKFJACOKBGM IAABMOEDKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BB30", Offset = "0x6B8AF30", VA = "0x186B8BB30")]
	private void OIMMNJIAJAF(PKFJACOKBGM IAABMOEDKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B88940", Offset = "0x6B87D40", VA = "0x186B88940")]
	private void FAHMPMJJKNE(PKFJACOKBGM IAABMOEDKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C000", Offset = "0x6B8B400", VA = "0x186B8C000")]
	private void PDOGOPCAEID(PKFJACOKBGM IAABMOEDKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DFF0", Offset = "0x6B8D3F0", VA = "0x186B8DFF0")]
	public HNKCBLCMLIG(ACBOFIPJCPO DBNBJHEMMEG, [Optional] ILGFMKGKFLD BHGFBJGKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B89C40", Offset = "0x6B89040", VA = "0x186B89C40")]
	internal void IAAIIMKBGPA(PKFJACOKBGM EJDLALOLJCP, int JELKEJIHFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B89300", Offset = "0x6B88700", VA = "0x186B89300")]
	internal void GIAACEBCHGE(PKFJACOKBGM EJDLALOLJCP, object ALCDDFEIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B88420", Offset = "0x6B87820", VA = "0x186B88420")]
	internal void EBDNPECLCEN(PKFJACOKBGM IAABMOEDKHJ, BNBGKDGLEAD JKODLOFLBMK, SocketError LPMDJOHKCBA, KADKJNFJFNA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B87B30", Offset = "0x6B86F30", VA = "0x186B87B30")]
	private void CHGPKNBKFBM(PKFJACOKBGM IAABMOEDKHJ, BNBGKDGLEAD JKODLOFLBMK, SocketError LPMDJOHKCBA, bool HLPBIKLHEBD, byte[] HPMNBNLACCC, int HCJENEHBBIC, int ECKHNAPCKGD, KADKJNFJFNA JOKKIDPHPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A580", Offset = "0x6B89980", VA = "0x186B8A580")]
	private void INNCKJAAOCC(NBPLBMIAGNK.PNJNJBCKEJA HAFNBBNOLPO, [Optional] PKFJACOKBGM IAABMOEDKHJ, [Optional] IPEndPoint FHIIAMOAEHB, SocketError HLLDLKNABPD = SocketError.Success, int JELKEJIHFML = 0, BNBGKDGLEAD KLFNPGCHIMD = BNBGKDGLEAD.ConnectionFailed, [Optional] JLOJOBBFHCG OGELFDOFPPG, ENLKJEGHNDK FFCKLDKHINF = ENLKJEGHNDK.Unreliable, byte CIEAKAJDBIG = 0, [Optional] KADKJNFJFNA BFPIPIEFMCH, [Optional] object ALCDDFEIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B87310", Offset = "0x6B86710", VA = "0x186B87310")]
	private void BMLCGOBJODA(NBPLBMIAGNK KLCAIGNGMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B5F0", Offset = "0x6B8A9F0", VA = "0x186B8B5F0")]
	internal void MANLDAEDCHK(NBPLBMIAGNK KLCAIGNGMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B89350", Offset = "0x6B88750", VA = "0x186B89350")]
	private void HIFMDPIEDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B88620", Offset = "0x6B87A20", VA = "0x186B88620")]
	private void EPDHHDALKIC(int NBCEHGCJGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B89C90", Offset = "0x6B89090", VA = "0x186B89C90")]
	internal PKFJACOKBGM IFNEOBPJOMK(JLOJOBBFHCG ANMDEHLLLBJ, byte[] BGBKAFDDAFI, int HCJENEHBBIC, int BFBCILDCBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B870", Offset = "0x6B8AC70", VA = "0x186B8B870")]
	private int NGLJIIKINNH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AFE0", Offset = "0x6B8A3E0", VA = "0x186B8AFE0")]
	private void LKCFFBJHAJK(IPEndPoint FHIIAMOAEHB, PKFJACOKBGM IHAPDJGPJKO, FHHLDIFLMKM FLFMICOANKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C6A0", Offset = "0x6B8BAA0", VA = "0x186B8C6A0")]
	private void PJGGNPKNHMP(KADKJNFJFNA GBLAOBBFOOI, IPEndPoint FHIIAMOAEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B88120", Offset = "0x6B87520", VA = "0x186B88120")]
	internal void DMGOHBPJJFI(KADKJNFJFNA GBLAOBBFOOI, ENLKJEGHNDK AAGGEGLEHBG, byte CIEAKAJDBIG, int MCGBMGGADEA, PKFJACOKBGM EJDLALOLJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B891F0", Offset = "0x6B885F0", VA = "0x186B891F0")]
	public bool FMCLIDDFJAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B889A0", Offset = "0x6B87DA0", VA = "0x186B889A0")]
	public bool FMCLIDDFJAP(IPAddress DPOPLLLEKCJ, IPAddress DGFJDNIEHEM, int LBADMGPENPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B89170", Offset = "0x6B88570", VA = "0x186B89170")]
	public bool FMCLIDDFJAP(int LBADMGPENPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B87160", Offset = "0x6B86560", VA = "0x186B87160")]
	public void BIDBDDHDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B896A0", Offset = "0x6B88AA0", VA = "0x186B896A0")]
	public PKFJACOKBGM HMOHDJOHFAG(string KHGADHNAFJA, int LBADMGPENPB, string DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B89B60", Offset = "0x6B88F60", VA = "0x186B89B60")]
	public PKFJACOKBGM HMOHDJOHFAG(string KHGADHNAFJA, int LBADMGPENPB, EGJDBJHJPJD GEOBBHOELPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B89780", Offset = "0x6B88B80", VA = "0x186B89780")]
	public PKFJACOKBGM HMOHDJOHFAG(IPEndPoint IGICHEAKAKH, EGJDBJHJPJD GEOBBHOELPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AFD0", Offset = "0x6B8A3D0", VA = "0x186B8AFD0")]
	public void KGANBNOPCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AC80", Offset = "0x6B8A080", VA = "0x186B8AC80")]
	public void KGANBNOPCHG(bool MKDPCLPKNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BE80", Offset = "0x6B8B280", VA = "0x186B8BE80")]
	public void OKBMOCFBGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BF30", Offset = "0x6B8B330", VA = "0x186B8BF30")]
	public void OKBMOCFBGMB(byte[] HPMNBNLACCC, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B87AB0", Offset = "0x6B86EB0", VA = "0x186B87AB0")]
	public void CHGPKNBKFBM(PKFJACOKBGM IAABMOEDKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B87AF0", Offset = "0x6B86EF0", VA = "0x186B87AF0")]
	public void CHGPKNBKFBM(PKFJACOKBGM IAABMOEDKHJ, byte[] HPMNBNLACCC, int HCJENEHBBIC, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DE10", Offset = "0x6B8D210", VA = "0x186B8DE10", Slot = "4")]
	private IEnumerator<PKFJACOKBGM> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DEA0", Offset = "0x6B8D2A0", VA = "0x186B8DEA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B88460", Offset = "0x6B87860", VA = "0x186B88460")]
	private KADKJNFJFNA EIGANJBBJIG(IOILLJAICII MHALMOGKEGG, int MNDMOIHIBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B88540", Offset = "0x6B87940", VA = "0x186B88540")]
	private KADKJNFJFNA EIGANJBBJIG(IOILLJAICII MHALMOGKEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B8F0", Offset = "0x6B8ACF0", VA = "0x186B8B8F0")]
	internal KADKJNFJFNA OACDHACBIOK(int MNDMOIHIBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AA20", Offset = "0x6B89E20", VA = "0x186B8AA20")]
	internal void JJBPCGDCPNK(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DF30", Offset = "0x6B8D330", VA = "0x186B8DF30")]
	static HNKCBLCMLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x134D3F0", Offset = "0x134C7F0", VA = "0x18134D3F0")]
	private bool ECMLJIKMDCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B87FA0", Offset = "0x6B873A0", VA = "0x186B87FA0")]
	private void DFOGFPJNPKM(IPEndPoint LOHIEEKLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B490", Offset = "0x6B8A890", VA = "0x186B8B490")]
	private void LMNLJDMKGIJ(IPEndPoint LOHIEEKLIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C2D0", Offset = "0x6B8B6D0", VA = "0x186B8C2D0")]
	private bool PHHIICBHINL(SocketException BLCFGIAFKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B88400", Offset = "0x6B87800", VA = "0x186B88400")]
	private void DNPPFKLDOEL(GNGFEMKCGJM NFAIKPDMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A2B0", Offset = "0x6B896B0", VA = "0x186B8A2B0")]
	private void IMBHPNFBIMN(OFICCEDJJEN NFAIKPDMPFH, EndPoint ILCNEPDMPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DA90", Offset = "0x6B8CE90", VA = "0x186B8DA90")]
	private void POAMELOEOPG(object DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B889C0", Offset = "0x6B87DC0", VA = "0x186B889C0")]
	public bool FMCLIDDFJAP(IPAddress DPOPLLLEKCJ, IPAddress DGFJDNIEHEM, int LBADMGPENPB, bool CNLPBHIPPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B87F40", Offset = "0x6B87340", VA = "0x186B87F40")]
	internal int CPFPKNECDBG(KADKJNFJFNA GBLAOBBFOOI, IPEndPoint FHIIAMOAEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B87120", Offset = "0x6B86520", VA = "0x186B87120")]
	internal int BABBBMFBMHF(KADKJNFJFNA GBLAOBBFOOI, IPEndPoint FHIIAMOAEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B86940", Offset = "0x6B85D40", VA = "0x186B86940")]
	internal int BABBBMFBMHF(byte[] DAMFJFKKFBI, int HCJENEHBBIC, int BFBCILDCBHG, IPEndPoint FHIIAMOAEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B700", Offset = "0x6B8AB00", VA = "0x186B8B700")]
	internal void NEPONLILACJ(bool GOJIBGDKEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IOILLJAICII : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class KADKJNFJFNA
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int HLEKNLEDNMA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] GJMIKBMMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] AOLJCJGNJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int BFPJLGPCCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object GOLAJIEPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public KADKJNFJFNA HNICEFLLFFA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IOILLJAICII AMBFGADHIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FE40", Offset = "0x6B8F240", VA = "0x186B8FE40")]
		get
		{
			return default(IOILLJAICII);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B901E0", Offset = "0x6B8F5E0", VA = "0x186B901E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte FHCOPPGFALA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B900E0", Offset = "0x6B8F4E0", VA = "0x186B900E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B90350", Offset = "0x6B8F750", VA = "0x186B90350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort JCEIELCFMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FE70", Offset = "0x6B8F270", VA = "0x186B8FE70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FF70", Offset = "0x6B8F370", VA = "0x186B8FF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AKDIOOKHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6B900B0", Offset = "0x6B8F4B0", VA = "0x186B900B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte BCPEKHHGIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B901B0", Offset = "0x6B8F5B0", VA = "0x186B901B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B90220", Offset = "0x6B8F620", VA = "0x186B90220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort ELAEBJFCHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FF10", Offset = "0x6B8F310", VA = "0x186B8FF10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6B90170", Offset = "0x6B8F570", VA = "0x186B90170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort FPKEIPFLJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FDE0", Offset = "0x6B8F1E0", VA = "0x186B8FDE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FED0", Offset = "0x6B8F2D0", VA = "0x186B8FED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MCKECLHAGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6B90110", Offset = "0x6B8F510", VA = "0x186B90110")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B90390", Offset = "0x6B8F790", VA = "0x186B90390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B90400", Offset = "0x6B8F800", VA = "0x186B90400")]
	static KADKJNFJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B903D0", Offset = "0x6B8F7D0", VA = "0x186B903D0")]
	public void PJMGBNIGFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B906C0", Offset = "0x6B8FAC0", VA = "0x186B906C0")]
	public KADKJNFJFNA(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B90730", Offset = "0x6B8FB30", VA = "0x186B90730")]
	public KADKJNFJFNA(IOILLJAICII MHALMOGKEGG, int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B90040", Offset = "0x6B8F440", VA = "0x186B90040")]
	public static int JFMGPJGFHHK(IOILLJAICII MHALMOGKEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FFB0", Offset = "0x6B8F3B0", VA = "0x186B8FFB0")]
	public int JFMGPJGFHHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B90250", Offset = "0x6B8F650", VA = "0x186B90250")]
	public bool MLMFGGGPBJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum DNNNDHHINMO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum NIHMPKFALEM
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum ALFADNFAIIB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum NPCIIAIPIPI
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PKFJACOKBGM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NKLLGMKDAEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public KADKJNFJFNA[] JAFDFIIGEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int DHNHOJLPBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int FMCKMHAHADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte BCPEKHHGIAH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NKLLGMKDAEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void HIFBDBALKKA(ulong AMNGFHHBELB, int IBNGCPLLCLG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int JEIFNDGFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int LEGPLNBLBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int PKGMDKFIKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double KOCFPAPBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KHGFFNHOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int KHGKFHCKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int AFNAECDPDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch HPGLBPPAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int EHNEHIPONNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long MBJFAAEAHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object OLKKBNDPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal PKFJACOKBGM KEGBHIOKNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal PKFJACOKBGM NFIHLLOEEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<KADKJNFJFNA> IGACCGIAHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<EGAMCOMLAPH> BCMGKANINJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly EGAMCOMLAPH[] CBGEFMIPHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int DHEBGHNNNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int EMKMLNDKDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool NDCEGPJHPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int FCFPJPBAJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int ADJCLPMAKNN;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int MNJHLHPDLDH = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int DKEFIHHDLEJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object CJJICBDNIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int FBCFALOICJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, NKLLGMKDAEK> EDMFLHNEFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> MCLLKFHANOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly KADKJNFJFNA DDNMENOBKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int DBOGHEBPADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int DAKLAIGLGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint BKGJGENOBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int DFJPFHPGOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int ENCBKCDCLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long IHKKPLCFMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte FLAPKFELPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private DNNNDHHINMO DABGBIPIBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private KADKJNFJFNA PELKLMKHHMK;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int PLKDMJEHMGG = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int OFIIMCLJDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly KADKJNFJFNA FPNCCNECFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly KADKJNFJFNA AGADNAHILJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly KADKJNFJFNA CHCOGJPDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly KADKJNFJFNA CHAGOLLKFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private DNHMOPIIEKB OEMNLJLLFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HNKCBLCMLIG DMFMAGGAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int GEEBDAOOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object HBEAMEKJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly CFNPPLJMBBK ACNBPHFHMPO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte JHEJCFIPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAF02A0", Offset = "0xAEF6A0", VA = "0x180AF02A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6B93F60", Offset = "0x6B93360", VA = "0x186B93F60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CMBLMJCBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC20DF0", Offset = "0xC201F0", VA = "0x180C20DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DNNNDHHINMO PFOBHDDAEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAF02C0", Offset = "0xAEF6C0", VA = "0x180AF02C0")]
		get
		{
			return default(DNNNDHHINMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long MNJABAABCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AC0", Offset = "0x9B1EC0", VA = "0x1809B2AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ENCEKJGGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x14553D0", Offset = "0x14547D0", VA = "0x1814553D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D28180", Offset = "0x1D27580", VA = "0x181D28180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HCGMNAPCJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B96C00", Offset = "0x6B96000", VA = "0x186B96C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BNJIDICIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B9EE0", Offset = "0x9B92E0", VA = "0x1809B9EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double JADMKNPBPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x53089B0", Offset = "0x5307DB0", VA = "0x1853089B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HIFBDBALKKA KJPHMIALMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B94110", Offset = "0x6B93510", VA = "0x186B94110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B94480", Offset = "0x6B93880", VA = "0x186B94480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B974B0", Offset = "0x6B968B0", VA = "0x186B974B0")]
	internal PKFJACOKBGM(HNKCBLCMLIG JLEBCJGHEBM, IPEndPoint FHIIAMOAEHB, int NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B95E00", Offset = "0x6B95200", VA = "0x186B95E00")]
	internal void LANACFJFBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B95D90", Offset = "0x6B95190", VA = "0x186B95D90")]
	internal void KLFGICCBDLB(IPEndPoint MMNMKHLLLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B95070", Offset = "0x6B94470", VA = "0x186B95070")]
	internal void INOEDGIJCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B94040", Offset = "0x6B93440", VA = "0x186B94040")]
	private void CCDFAOBBENI(int PIIOIPHLHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B95DC0", Offset = "0x6B951C0", VA = "0x186B95DC0")]
	private void KLFMEKNNEEJ(int PDPMDNDKGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B95250", Offset = "0x6B94650", VA = "0x186B95250")]
	private EGAMCOMLAPH JLMKHPJBCLA(byte NMAOAJDPHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B97900", Offset = "0x6B96D00", VA = "0x186B97900")]
	internal PKFJACOKBGM(HNKCBLCMLIG JLEBCJGHEBM, IPEndPoint FHIIAMOAEHB, int NCJKGMLAKGH, byte BGHOAHNPNHJ, EGJDBJHJPJD NOCMBGBHEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B972D0", Offset = "0x6B966D0", VA = "0x186B972D0")]
	internal PKFJACOKBGM(HNKCBLCMLIG JLEBCJGHEBM, JLOJOBBFHCG ANMDEHLLLBJ, int NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B95020", Offset = "0x6B94420", VA = "0x186B95020")]
	internal void HANHIHOJDCE(FHHLDIFLMKM FIKKKOHJLJE, byte[] HPMNBNLACCC, int HCJENEHBBIC, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B94660", Offset = "0x6B93A60", VA = "0x186B94660")]
	internal bool EMJDNPLLKIE(MHJOPEJFKEI GBLAOBBFOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B94010", Offset = "0x6B93410", VA = "0x186B94010")]
	public void CBLPHADFEEI(byte[] HPMNBNLACCC, int HCJENEHBBIC, int BFBCILDCBHG, ENLKJEGHNDK FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B95FE0", Offset = "0x6B953E0", VA = "0x186B95FE0")]
	private void MKIKIGOEIDG(byte[] HPMNBNLACCC, int HCJENEHBBIC, int BFBCILDCBHG, byte CIEAKAJDBIG, ENLKJEGHNDK FFCKLDKHINF, object ALCDDFEIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B94530", Offset = "0x6B93930", VA = "0x186B94530")]
	public void DFAFKJLFMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B94580", Offset = "0x6B93980", VA = "0x186B94580")]
	internal ALFADNFAIIB EKOPBINGFEG(KADKJNFJFNA GBLAOBBFOOI)
	{
		return default(ALFADNFAIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B94D80", Offset = "0x6B94180", VA = "0x186B94D80")]
	internal void GCFECFAMAFB(EGAMCOMLAPH DOLLCJOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B946E0", Offset = "0x6B93AE0", VA = "0x186B946E0")]
	internal NPCIIAIPIPI EPLMEHCPNMH(byte[] HPMNBNLACCC, int HCJENEHBBIC, int BFBCILDCBHG, bool HLPBIKLHEBD)
	{
		return default(NPCIIAIPIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B94DE0", Offset = "0x6B941E0", VA = "0x186B94DE0")]
	private void GHGCOEEELHJ(int APNMKGPDCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B95400", Offset = "0x6B94800", VA = "0x186B95400")]
	internal void KJBOBOHPDDA(ENLKJEGHNDK AAGGEGLEHBG, KADKJNFJFNA ICNDIBLBLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B93A10", Offset = "0x6B92E10", VA = "0x186B93A10")]
	private void AAGFNNHHODN(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B949F0", Offset = "0x6B93DF0", VA = "0x186B949F0")]
	private void GBEDHEBCAGE(int JNFHMFBFJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B95E20", Offset = "0x6B95220", VA = "0x186B95E20")]
	internal NIHMPKFALEM LKCFFBJHAJK(FHHLDIFLMKM FLFMICOANKB)
	{
		return default(NIHMPKFALEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B96C10", Offset = "0x6B96010", VA = "0x186B96C10")]
	internal void PPHCBLOOFAF(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B95100", Offset = "0x6B94500", VA = "0x186B95100")]
	private void JKPFMNOMBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B94E20", Offset = "0x6B94220", VA = "0x186B94E20")]
	internal void GKMNNPJDDGE(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B96540", Offset = "0x6B95940", VA = "0x186B96540")]
	internal void ODNOMLGNGJI(int JNFHMFBFJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B941C0", Offset = "0x6B935C0", VA = "0x186B941C0")]
	internal void CPAAHFMGBJH(KADKJNFJFNA GBLAOBBFOOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CFNPPLJMBBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HFKPDNKNCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long MKKHGDELKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long BDCEPFKDHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long HFELLMAAIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long NMJFBLFDPJB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long GGKIEGEPIEC;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long BMPFKEFEDCA;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long GEBKEJPDAPB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long EODKKJCMLLO;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long IBEPKEKKAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long NLMEDCFDADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long BJNLILOICHD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long ILEMNBPOHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B815D0", Offset = "0x6B809D0", VA = "0x186B815D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EHPHPMNPAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B81740", Offset = "0x6B80B40", VA = "0x186B81740")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AFHOCAKPMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B81480", Offset = "0x6B80880", VA = "0x186B81480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GFNMJGGLCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B818E0", Offset = "0x6B80CE0", VA = "0x186B818E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long POLKBCHFMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B81640", Offset = "0x6B80A40", VA = "0x186B81640")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long ONNKFAIOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B81750", Offset = "0x6B80B50", VA = "0x186B81750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long DMEOBDNEOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B81490", Offset = "0x6B80890", VA = "0x186B81490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long JFPMNGDPMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B816F0", Offset = "0x6B80AF0", VA = "0x186B816F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DNHMOPIIEKB PLFDMCOJBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B81730", Offset = "0x6B80B30", VA = "0x186B81730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double JIDPMHHFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B814D0", Offset = "0x6B808D0", VA = "0x186B814D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B81650", Offset = "0x6B80A50", VA = "0x186B81650")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B815E0", Offset = "0x6B809E0", VA = "0x186B815E0")]
	public void ELCHHFPMGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B81890", Offset = "0x6B80C90", VA = "0x186B81890")]
	public void NCHEELHMBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B817D0", Offset = "0x6B80BD0", VA = "0x186B817D0")]
	public void MHBLCLPLMDD(long APBPMGFHLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B81690", Offset = "0x6B80A90", VA = "0x186B81690")]
	public void GCOPKBABPGN(long PPKLCPEBBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B81830", Offset = "0x6B80C30", VA = "0x186B81830")]
	public void MOAEPEPLICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B81760", Offset = "0x6B80B60", VA = "0x186B81760")]
	public void JKPJGEIPLKE(long OGGAOKFIHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B818F0", Offset = "0x6B80CF0", VA = "0x186B818F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B81530", Offset = "0x6B80930", VA = "0x186B81530")]
	public void CPDGCJIDPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CFNPPLJMBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NCBFCKKFACP
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> MCJGFLEOAGF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B93080", Offset = "0x6B92480", VA = "0x186B93080")]
	public static IPEndPoint EGGKNGIONBJ(string PCMIBPONCHM, int LBADMGPENPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B93390", Offset = "0x6B92790", VA = "0x186B93390")]
	public static IPAddress OODHPINLMOG(string PCMIBPONCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B93300", Offset = "0x6B92700", VA = "0x186B93300")]
	public static IPAddress OODHPINLMOG(string PCMIBPONCHM, AddressFamily EFACGDPKCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B932D0", Offset = "0x6B926D0", VA = "0x186B932D0")]
	internal static int MECHDHCLAOH(int JJEDHILDPJB, int ILHNGOAPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x37C89A0", Offset = "0x37C7DA0", VA = "0x1837C89A0")]
	internal static T[] ECOLBLFGOHH<T>(int ECKHNAPCKGD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BBGCBAMLAGF : EGAMCOMLAPH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BEDHHMHKBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private KADKJNFJFNA JAIAFDFJHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long IFKIJINNGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool ICHKPBCMBJE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6B81270", Offset = "0x6B80670", VA = "0x186B81270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6B81200", Offset = "0x6B80600", VA = "0x186B81200")]
		public void BECHPFCMIHE(KADKJNFJFNA GBLAOBBFOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6B81190", Offset = "0x6B80590", VA = "0x186B81190")]
		public bool ALNEHEAHCLI(long BKAEDIDGDFB, PKFJACOKBGM IAABMOEDKHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6B81220", Offset = "0x6B80620", VA = "0x186B81220")]
		public bool CJEMNCEDADJ(PKFJACOKBGM IAABMOEDKHJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly KADKJNFJFNA CJDJBKHOMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly BEDHHMHKBNE[] BMPMFPMHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly KADKJNFJFNA[] CMILICCGPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] GMPPBDEIONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int BDLJMLDLHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int KHIKDFIHPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int PHIHJFHJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int NBHDKDFINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool EEECCFHCJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly ENLKJEGHNDK MPHALFBJOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool EJOKOBMKBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int CAGCCHIPLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte IIPILJHMMMF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B80FC0", Offset = "0x6B803C0", VA = "0x186B80FC0")]
	public BBGCBAMLAGF(PKFJACOKBGM IAABMOEDKHJ, bool CBNABMLMFFP, byte NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B800D0", Offset = "0x6B7F4D0", VA = "0x186B800D0")]
	private void JOJIMOEECEH(KADKJNFJFNA GBLAOBBFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B80490", Offset = "0x6B7F890", VA = "0x186B80490", Slot = "4")]
	protected override bool OIJFCFCPEAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B80960", Offset = "0x6B7FD60", VA = "0x186B80960", Slot = "5")]
	public override bool PPHCBLOOFAF(KADKJNFJFNA GBLAOBBFOOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JDKDBJNOAFI : EGAMCOMLAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int COMPNCIPHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort KHIKDFIHPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool HCJGJBCEFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private KADKJNFJFNA IBCIBGKKGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly KADKJNFJFNA MGIJAGIPIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool BFILMCHADOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte IIPILJHMMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long CLFJMOOICNA;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EF60", Offset = "0x6B8E360", VA = "0x186B8EF60")]
	public JDKDBJNOAFI(PKFJACOKBGM IAABMOEDKHJ, bool FJDOELEJFNC, byte NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E7C0", Offset = "0x6B8DBC0", VA = "0x186B8E7C0", Slot = "4")]
	protected override bool OIJFCFCPEAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EC80", Offset = "0x6B8E080", VA = "0x186B8EC80", Slot = "5")]
	public override bool PPHCBLOOFAF(KADKJNFJFNA GBLAOBBFOOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BMIOIOJEFMO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct ANGJDBBECPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong GGEKBPEOFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double BDFFIGOAJJM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct IGAJHKILAPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int GBCNFBHKKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float CGHMPBNGJOI;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FAF0", Offset = "0x6B7EEF0", VA = "0x186B7FAF0")]
	private static void BBMEPABNJBM(byte[] DAMDACDIHDN, int HGHGCNDALFP, ulong HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6B81360", Offset = "0x6B80760", VA = "0x186B81360")]
	private static void BBMEPABNJBM(byte[] DAMDACDIHDN, int HGHGCNDALFP, int HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6B81320", Offset = "0x6B80720", VA = "0x186B81320")]
	public static void BBMEPABNJBM(byte[] DAMDACDIHDN, int HGHGCNDALFP, short HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6B813D0", Offset = "0x6B807D0", VA = "0x186B813D0")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, double FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6B813F0", Offset = "0x6B807F0", VA = "0x186B813F0")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B81320", Offset = "0x6B80720", VA = "0x186B81320")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, short FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B81320", Offset = "0x6B80720", VA = "0x186B81320")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, ushort FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B81360", Offset = "0x6B80760", VA = "0x186B81360")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6B81360", Offset = "0x6B80760", VA = "0x186B81360")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, uint FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B81470", Offset = "0x6B80870", VA = "0x186B81470")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B81470", Offset = "0x6B80870", VA = "0x186B81470")]
	public static void HPFBCDLFHLA(byte[] DHHEGLJJIIE, int GNPKFMEIDNL, ulong FFOEEMKIKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JKEDBGGDMBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] HFHDNFLLMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int MDOIOBKPHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int EDCAKMJBNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int CLAGJDKLGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] AOLJCJGNJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int BLJGCHIOGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JGNFLFMJDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F9C0", Offset = "0x6B8EDC0", VA = "0x186B8F9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KAPLEFKNPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2580690", Offset = "0x257FA90", VA = "0x182580690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BPEDEBFGAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F870", Offset = "0x6B8EC70", VA = "0x186B8F870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F880", Offset = "0x6B8EC80", VA = "0x186B8F880")]
	public void HMCHDIIDHGE(byte[] PEAMMFAMJGD, int HGHGCNDALFP, int EIGKGPGMJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public JKEDBGGDMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC20", Offset = "0x6B8F020", VA = "0x186B8FC20")]
	public JKEDBGGDMBH(byte[] PEAMMFAMJGD, int HGHGCNDALFP, int EIGKGPGMJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F6E0", Offset = "0x6B8EAE0", VA = "0x186B8F6E0")]
	public IPEndPoint EHOLAABGLOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F1B0", Offset = "0x6B8E5B0", VA = "0x186B8F1B0")]
	public byte KFCEHHHNDAJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F1B0", Offset = "0x6B8E5B0", VA = "0x186B8F1B0")]
	public sbyte BDEKEJPMBOK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x368F770", Offset = "0x368EB70", VA = "0x18368F770")]
	public T[] DCPNJJOBIAI<T>(ushort MNDMOIHIBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FA10", Offset = "0x6B8EE10", VA = "0x186B8FA10")]
	public bool[] MLAHCFAPPPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F8C0", Offset = "0x6B8ECC0", VA = "0x186B8F8C0")]
	public ushort[] ICACKOIGFPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F7B0", Offset = "0x6B8EBB0", VA = "0x186B8F7B0")]
	public short[] FBJEMCBBOAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F900", Offset = "0x6B8ED00", VA = "0x186B8F900")]
	public int[] JLFEGEABCDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FA50", Offset = "0x6B8EE50", VA = "0x186B8FA50")]
	public uint[] PBONCGGPBGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F980", Offset = "0x6B8ED80", VA = "0x186B8F980")]
	public float[] LMCLPLFGHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F830", Offset = "0x6B8EC30", VA = "0x186B8F830")]
	public double[] GNCPMAJMCJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F100", Offset = "0x6B8E500", VA = "0x186B8F100")]
	public long[] AJIPAAGAOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FA90", Offset = "0x6B8EE90", VA = "0x186B8FA90")]
	public ulong[] PIAKHPEBDGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FAD0", Offset = "0x6B8EED0", VA = "0x186B8FAD0")]
	public string[] PNMNBPMKMBJ(int HHBJDAMLGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F7F0", Offset = "0x6B8EBF0", VA = "0x186B8F7F0")]
	public bool GIAMNCBLEDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F1F0", Offset = "0x6B8E5F0", VA = "0x186B8F1F0")]
	public char GIBMDNKBLNG()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F1F0", Offset = "0x6B8E5F0", VA = "0x186B8F1F0")]
	public ushort BDPCFACBFGN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F360", Offset = "0x6B8E760", VA = "0x186B8F360")]
	public short DCOGAOJGAAF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F020", Offset = "0x6B8E420", VA = "0x186B8F020")]
	public long ADCKBBHNCLF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F140", Offset = "0x6B8E540", VA = "0x186B8F140")]
	public ulong ANDBFMMCFCE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F670", Offset = "0x6B8EA70", VA = "0x186B8F670")]
	public int DNJNEOGELJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F260", Offset = "0x6B8E660", VA = "0x186B8F260")]
	public uint CFHLDPJADCI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F3D0", Offset = "0x6B8E7D0", VA = "0x186B8F3D0")]
	public float DFBHFAHGHPN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F090", Offset = "0x6B8E490", VA = "0x186B8F090")]
	public double AILNPPNDMBO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F440", Offset = "0x6B8E840", VA = "0x186B8F440")]
	public string DKIEJMKIMKH(int NKOOKMNGKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F2F0", Offset = "0x6B8E6F0", VA = "0x186B8F2F0")]
	public ArraySegment<byte> DCBEOBHLBFG(int ECKHNAPCKGD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F940", Offset = "0x6B8ED40", VA = "0x186B8F940")]
	public sbyte[] KHPCCNNCIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F9D0", Offset = "0x6B8EDD0", VA = "0x186B8F9D0")]
	public byte[] MGLAGHDBGCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F2D0", Offset = "0x6B8E6D0", VA = "0x186B8F2D0")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EGJDBJHJPJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] HFHDNFLLMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int MDOIOBKPHMG;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int CMAJAKNBPMG = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool IDEBMLMBAEN;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding OAKLJIMLBAN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int MDHFAMFIKFC = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] KNBANOIEMBG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] EEHHJHNNGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6B841F0", Offset = "0x6B835F0", VA = "0x186B841F0")]
	public EGJDBJHJPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6B84150", Offset = "0x6B83550", VA = "0x186B84150")]
	public EGJDBJHJPJD(bool PAAJCHFLOMA, int CPAIHNEGGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6B83C10", Offset = "0x6B83010", VA = "0x186B83C10")]
	public static EGJDBJHJPJD HGJIPAECKHG(string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6B83B70", Offset = "0x6B82F70", VA = "0x186B83B70")]
	public void EKLAGPJDCKJ(int KDGGAJDGKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xC7D020", Offset = "0xC7C420", VA = "0x180C7D020")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6B837A0", Offset = "0x6B82BA0", VA = "0x186B837A0")]
	public void COIABCGPJOD(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6B835E0", Offset = "0x6B829E0", VA = "0x186B835E0")]
	public void COIABCGPJOD(double FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6B83840", Offset = "0x6B82C40", VA = "0x186B83840")]
	public void COIABCGPJOD(long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6B83840", Offset = "0x6B82C40", VA = "0x186B83840")]
	public void COIABCGPJOD(ulong FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6B83630", Offset = "0x6B82A30", VA = "0x186B83630")]
	public void COIABCGPJOD(int FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6B83630", Offset = "0x6B82A30", VA = "0x186B83630")]
	public void COIABCGPJOD(uint FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6B836C0", Offset = "0x6B82AC0", VA = "0x186B836C0")]
	public void COIABCGPJOD(char FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6B836C0", Offset = "0x6B82AC0", VA = "0x186B836C0")]
	public void COIABCGPJOD(ushort FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6B836C0", Offset = "0x6B82AC0", VA = "0x186B836C0")]
	public void COIABCGPJOD(short FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6B838F0", Offset = "0x6B82CF0", VA = "0x186B838F0")]
	public void COIABCGPJOD(sbyte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6B838F0", Offset = "0x6B82CF0", VA = "0x186B838F0")]
	public void COIABCGPJOD(byte FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6B83730", Offset = "0x6B82B30", VA = "0x186B83730")]
	public void COIABCGPJOD(byte[] HPMNBNLACCC, int HGHGCNDALFP, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B83430", Offset = "0x6B82830", VA = "0x186B83430")]
	public void KCBLNPPEGDJ(sbyte[] HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B83430", Offset = "0x6B82830", VA = "0x186B83430")]
	public void BPMFBDIDFCC(byte[] HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6B83890", Offset = "0x6B82C90", VA = "0x186B83890")]
	public void COIABCGPJOD(bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B83E30", Offset = "0x6B83230", VA = "0x186B83E30")]
	public void JKLLJAEBKML(Array MIMDNIFNNPJ, int PEPMKKECHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6B83F10", Offset = "0x6B83310", VA = "0x186B83F10")]
	public void JKLLJAEBKML(float[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6B83FF0", Offset = "0x6B833F0", VA = "0x186B83FF0")]
	public void JKLLJAEBKML(double[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6B83FF0", Offset = "0x6B833F0", VA = "0x186B83FF0")]
	public void JKLLJAEBKML(long[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B83FF0", Offset = "0x6B833F0", VA = "0x186B83FF0")]
	public void JKLLJAEBKML(ulong[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B83F10", Offset = "0x6B83310", VA = "0x186B83F10")]
	public void JKLLJAEBKML(int[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B83F10", Offset = "0x6B83310", VA = "0x186B83F10")]
	public void JKLLJAEBKML(uint[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B83C80", Offset = "0x6B83080", VA = "0x186B83C80")]
	public void JKLLJAEBKML(ushort[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B83C80", Offset = "0x6B83080", VA = "0x186B83C80")]
	public void JKLLJAEBKML(short[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B83430", Offset = "0x6B82830", VA = "0x186B83430")]
	public void JKLLJAEBKML(bool[] FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B83D60", Offset = "0x6B83160", VA = "0x186B83D60")]
	public void JKLLJAEBKML(string[] FFOEEMKIKJO, int LBFFJOGHEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6B83510", Offset = "0x6B82910", VA = "0x186B83510")]
	public void COIABCGPJOD(IPEndPoint GPMGNDICFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B83B60", Offset = "0x6B82F60", VA = "0x186B83B60")]
	public void COIABCGPJOD(string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6B83950", Offset = "0x6B82D50", VA = "0x186B83950")]
	public void COIABCGPJOD(string FFOEEMKIKJO, int NKOOKMNGKGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HJDKFEJKJNA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DJELDOFAPPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong GEEBDAOOGGP;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x66EFE80", Offset = "0x66EF280", VA = "0x1866EFE80")]
		static DJELDOFAPPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BNAKDPJBCAN(JKEDBGGDMBH HGFGHNJEEAJ, object ALCDDFEIMFD);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ICJOENPCOCB<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public HJDKFEJKJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ICJOENPCOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x49F33B0", Offset = "0x49F27B0", VA = "0x1849F33B0")]
		internal void JDMDDGALCKP(JKEDBGGDMBH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EADIEJCNIOB<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public HJDKFEJKJNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EADIEJCNIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4286540", Offset = "0x4285940", VA = "0x184286540")]
		internal void JDMDDGALCKP(JKEDBGGDMBH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly HJGJPMCDBNH MGIHDOGLKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, BNAKDPJBCAN> IMOABJHPJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly EGJDBJHJPJD IIMIIAPKINN;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6B865D0", Offset = "0x6B859D0", VA = "0x186B865D0")]
	public HJDKFEJKJNA(int HHBJDAMLGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x338C0B0", Offset = "0x338B4B0", VA = "0x18338C0B0", Slot = "4")]
	protected virtual ulong FIDKGFHBMMK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6B86420", Offset = "0x6B85820", VA = "0x186B86420", Slot = "5")]
	protected virtual BNAKDPJBCAN PNFLDCCCGLC(JKEDBGGDMBH HGFGHNJEEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3605210", Offset = "0x3604610", VA = "0x183605210", Slot = "6")]
	protected virtual void HDLGIOBFGJF<T>(EGJDBJHJPJD CEAJPINGICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B86550", Offset = "0x6B85950", VA = "0x186B86550")]
	public void POOCCJCFLIP(JKEDBGGDMBH HGFGHNJEEAJ, object ALCDDFEIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3605160", Offset = "0x3604560", VA = "0x183605160")]
	public void FEAAJMEOMKD<T>(EGJDBJHJPJD CEAJPINGICH, T GBLAOBBFOOI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6B863D0", Offset = "0x6B857D0", VA = "0x186B863D0")]
	public void ADJAHPCFALK(JKEDBGGDMBH HGFGHNJEEAJ, object ALCDDFEIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3605440", Offset = "0x3604840", VA = "0x183605440")]
	public void IPJEGFFIDGJ<T>(Action<T> AEOOOLJFJPM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3605280", Offset = "0x3604680", VA = "0x183605280")]
	public void IPJEGFFIDGJ<T, TUserData>(Action<T, TUserData> AEOOOLJFJPM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BJAPDKHPAMH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6B81310", Offset = "0x6B80710", VA = "0x186B81310")]
	public BJAPDKHPAMH(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HFOGPFDJENC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6B86370", Offset = "0x6B85770", VA = "0x186B86370")]
	public HFOGPFDJENC(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HJGJPMCDBNH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum JNJEEILNKHO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FJFDIOCEOBK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public JNJEEILNKHO KAFGKIIBACB;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x475FD70", Offset = "0x475F170", VA = "0x18475FD70", Slot = "4")]
		public virtual void BECHPFCMIHE(MethodInfo FJLELIFBHBA, MethodInfo KBACBJJADLC, JNJEEILNKHO HAFNBBNOLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void EGMCEHAAHMM(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DODJKOEPFPB(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		protected FJFDIOCEOBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class PECANMIKMGG<TClass, TProperty> : FJFDIOCEOBK<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> OJMCMLCKOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> MCHCOLKLGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> PHJCKNBCOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> CFJJCBJCCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> HLEEOFMEFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> KMPAIPJIBDB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5301780", Offset = "0x5300B80", VA = "0x185301780", Slot = "7")]
		public override void BIIKBJMPPII(TClass FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5302010", Offset = "0x5301410", VA = "0x185302010", Slot = "8")]
		public override void PKGJHHPHEMI(TClass FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5301BE0", Offset = "0x5300FE0", VA = "0x185301BE0", Slot = "9")]
		public override void EGMCEHAAHMM(TClass FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5301A20", Offset = "0x5300E20", VA = "0x185301A20", Slot = "10")]
		public override void DODJKOEPFPB(TClass FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5301F00", Offset = "0x5301300", VA = "0x185301F00")]
		protected TProperty[] NNGGIFLJKLP(TClass FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5301E80", Offset = "0x5301280", VA = "0x185301E80")]
		protected TProperty[] NCNMGDINMON(TClass FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x53005C0", Offset = "0x52FF9C0", VA = "0x1853005C0", Slot = "4")]
		public override void BECHPFCMIHE(MethodInfo FJLELIFBHBA, MethodInfo KBACBJJADLC, JNJEEILNKHO HAFNBBNOLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x48596A0", Offset = "0x4858AA0", VA = "0x1848596A0")]
		protected PECANMIKMGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class OAHNCPMHNMB<TClass, TProperty> : PECANMIKMGG<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void HFNOPKEABMC(JKEDBGGDMBH IEDBNFIMLNL, [Out] TProperty OHGBBILILLI);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GCCBIODFFGP(EGJDBJHJPJD AMDFBELLJOH, TProperty OHGBBILILLI);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5207C10", Offset = "0x5207010", VA = "0x185207C10", Slot = "5")]
		public override void DDCLNCKPBBO(TClass FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5207DD0", Offset = "0x52071D0", VA = "0x185207DD0", Slot = "6")]
		public override void FEAAJMEOMKD(TClass FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5207B50", Offset = "0x5206F50", VA = "0x185207B50", Slot = "7")]
		public override void BIIKBJMPPII(TClass FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5207E50", Offset = "0x5207250", VA = "0x185207E50", Slot = "8")]
		public override void PKGJHHPHEMI(TClass FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4A05010", Offset = "0x4A04410", VA = "0x184A05010")]
		protected OAHNCPMHNMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EBGCCGDPNOG<T> : PECANMIKMGG<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x428F610", Offset = "0x428EA10", VA = "0x18428F610", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x428F690", Offset = "0x428EA90", VA = "0x18428F690", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x428F590", Offset = "0x428E990", VA = "0x18428F590", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x428F700", Offset = "0x428EB00", VA = "0x18428F700", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public EBGCCGDPNOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BGGELGECACI<T> : PECANMIKMGG<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B520", Offset = "0x5F1A920", VA = "0x185F1B520", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x428F690", Offset = "0x428EA90", VA = "0x18428F690", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B4A0", Offset = "0x5F1A8A0", VA = "0x185F1B4A0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x428F700", Offset = "0x428EB00", VA = "0x18428F700", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public BGGELGECACI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class AFMMOIFLKAP<T> : PECANMIKMGG<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x480C4F0", Offset = "0x480B8F0", VA = "0x18480C4F0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x480C570", Offset = "0x480B970", VA = "0x18480C570", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x480C470", Offset = "0x480B870", VA = "0x18480C470", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x480C5E0", Offset = "0x480B9E0", VA = "0x18480C5E0", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public AFMMOIFLKAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class COGENFNNAJO<T> : PECANMIKMGG<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6485AC0", Offset = "0x6484EC0", VA = "0x186485AC0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x480C570", Offset = "0x480B970", VA = "0x18480C570", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6485A40", Offset = "0x6484E40", VA = "0x186485A40", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x480C5E0", Offset = "0x480B9E0", VA = "0x18480C5E0", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public COGENFNNAJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DHCJCJFIAHN<T> : PECANMIKMGG<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x66D7620", Offset = "0x66D6A20", VA = "0x1866D7620", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x62FA7E0", Offset = "0x62F9BE0", VA = "0x1862FA7E0", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x66D75A0", Offset = "0x66D69A0", VA = "0x1866D75A0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x50F39E0", Offset = "0x50F2DE0", VA = "0x1850F39E0", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public DHCJCJFIAHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CCAEIJMMPEI<T> : PECANMIKMGG<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x62FA760", Offset = "0x62F9B60", VA = "0x1862FA760", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x62FA7E0", Offset = "0x62F9BE0", VA = "0x1862FA7E0", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x62FA6E0", Offset = "0x62F9AE0", VA = "0x1862FA6E0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x50F39E0", Offset = "0x50F2DE0", VA = "0x1850F39E0", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public CCAEIJMMPEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CPOOJEPLJAC<T> : PECANMIKMGG<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50620C0", Offset = "0x50614C0", VA = "0x1850620C0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5062140", Offset = "0x5061540", VA = "0x185062140", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x64E2F90", Offset = "0x64E2390", VA = "0x1864E2F90", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x48FF120", Offset = "0x48FE520", VA = "0x1848FF120", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public CPOOJEPLJAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MKBFLFHAOHE<T> : PECANMIKMGG<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x50620C0", Offset = "0x50614C0", VA = "0x1850620C0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5062140", Offset = "0x5061540", VA = "0x185062140", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5062040", Offset = "0x5061440", VA = "0x185062040", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48FF120", Offset = "0x48FE520", VA = "0x1848FF120", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public MKBFLFHAOHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JCMEGFINIJP<T> : PECANMIKMGG<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8BC0", Offset = "0x4BF7FC0", VA = "0x184BF8BC0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8C40", Offset = "0x4BF8040", VA = "0x184BF8C40", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8B40", Offset = "0x4BF7F40", VA = "0x184BF8B40", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x428F700", Offset = "0x428EB00", VA = "0x18428F700", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public JCMEGFINIJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class NIGJMFCODFD<T> : PECANMIKMGG<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x50F38F0", Offset = "0x50F2CF0", VA = "0x1850F38F0", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x50F3970", Offset = "0x50F2D70", VA = "0x1850F3970", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x50F3870", Offset = "0x50F2C70", VA = "0x1850F3870", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x50F39E0", Offset = "0x50F2DE0", VA = "0x1850F39E0", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public NIGJMFCODFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HEMEPIJJIBD<T> : PECANMIKMGG<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x48FF030", Offset = "0x48FE430", VA = "0x1848FF030", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x48FF0B0", Offset = "0x48FE4B0", VA = "0x1848FF0B0", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x48FEFB0", Offset = "0x48FE3B0", VA = "0x1848FEFB0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x48FF120", Offset = "0x48FE520", VA = "0x1848FF120", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428EB70", VA = "0x18428F770")]
		public HEMEPIJJIBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class MEFIEAHLPBE<T> : OAHNCPMHNMB<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5057000", Offset = "0x5056400", VA = "0x185057000", Slot = "12")]
		protected override void GCCBIODFFGP(EGJDBJHJPJD AMDFBELLJOH, char OHGBBILILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5057030", Offset = "0x5056430", VA = "0x185057030", Slot = "11")]
		protected override void HFNOPKEABMC(JKEDBGGDMBH IEDBNFIMLNL, [Out] char OHGBBILILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x425AAD0", Offset = "0x4259ED0", VA = "0x18425AAD0")]
		public MEFIEAHLPBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class IBFJDIJDOFG<T> : OAHNCPMHNMB<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x49F1A70", Offset = "0x49F0E70", VA = "0x1849F1A70", Slot = "12")]
		protected override void GCCBIODFFGP(EGJDBJHJPJD AMDFBELLJOH, IPEndPoint OHGBBILILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x49F1AA0", Offset = "0x49F0EA0", VA = "0x1849F1AA0", Slot = "11")]
		protected override void HFNOPKEABMC(JKEDBGGDMBH IEDBNFIMLNL, [Out] IPEndPoint OHGBBILILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x425AAD0", Offset = "0x4259ED0", VA = "0x18425AAD0")]
		public IBFJDIJDOFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CGHPCGCFIHF<T> : PECANMIKMGG<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int BDPCFNBLIIA;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x63EDCF0", Offset = "0x63ED0F0", VA = "0x1863EDCF0")]
		public CGHPCGCFIHF(int NKOOKMNGKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x63EDB70", Offset = "0x63ECF70", VA = "0x1863EDB70", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x63EDBF0", Offset = "0x63ECFF0", VA = "0x1863EDBF0", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63EDAF0", Offset = "0x63ECEF0", VA = "0x1863EDAF0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x63EDC70", Offset = "0x63ED070", VA = "0x1863EDC70", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class DAGHOHJOEKH<T> : FJFDIOCEOBK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo AMBFGADHIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type APANIJNAHGC;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x66BCCC0", Offset = "0x66BC0C0", VA = "0x1866BCCC0")]
		public DAGHOHJOEKH(PropertyInfo MHALMOGKEGG, Type CLNLANDLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x66BCA30", Offset = "0x66BBE30", VA = "0x1866BCA30", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x66BCBB0", Offset = "0x66BBFB0", VA = "0x1866BCBB0", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x66BC9D0", Offset = "0x66BBDD0", VA = "0x1866BC9D0", Slot = "7")]
		public override void BIIKBJMPPII(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x66BCC60", Offset = "0x66BC060", VA = "0x1866BCC60", Slot = "8")]
		public override void PKGJHHPHEMI(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x66BCB50", Offset = "0x66BBF50", VA = "0x1866BCB50", Slot = "9")]
		public override void EGMCEHAAHMM(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x66BCAF0", Offset = "0x66BBEF0", VA = "0x1866BCAF0", Slot = "10")]
		public override void DODJKOEPFPB(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DLJAGJCJJCC<T> : DAGHOHJOEKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
		public DLJAGJCJJCC(PropertyInfo MHALMOGKEGG, Type CLNLANDLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x66FA360", Offset = "0x66F9760", VA = "0x1866FA360", Slot = "5")]
		public override void DDCLNCKPBBO(T FKJNKHNDGNB, JKEDBGGDMBH IEDBNFIMLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x66FA420", Offset = "0x66F9820", VA = "0x1866FA420", Slot = "6")]
		public override void FEAAJMEOMKD(T FKJNKHNDGNB, EGJDBJHJPJD AMDFBELLJOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HPPNCPOCFLK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static HPPNCPOCFLK<T> DNEPPKLGBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly FJFDIOCEOBK<T>[] JNFIKIGBIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int JLLGBDGHLMJ;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4946160", Offset = "0x4945560", VA = "0x184946160")]
		public HPPNCPOCFLK(List<FJFDIOCEOBK<T>> OGKONKEOJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x49460B0", Offset = "0x49454B0", VA = "0x1849460B0")]
		public void FEAAJMEOMKD(T BLFGIKOAKOL, EGJDBJHJPJD CEAJPINGICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4946000", Offset = "0x4945400", VA = "0x184946000")]
		public void DDCLNCKPBBO(T BLFGIKOAKOL, JKEDBGGDMBH HGFGHNJEEAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class EDJLEIGGPND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FJFDIOCEOBK<T> IOLMGDEDCOJ<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private EGJDBJHJPJD PPPPIKNLKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int DOAJACCIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, EDJLEIGGPND> CAHLFDIIMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B86750", Offset = "0x6B85B50", VA = "0x186B86750")]
	public HJGJPMCDBNH(int HHBJDAMLGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3605600", Offset = "0x3604A00", VA = "0x183605600")]
	private HPPNCPOCFLK<T> APIMFHCAMCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3401450", Offset = "0x3400850", VA = "0x183401450")]
	public void GEAMIGHEOPG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3606720", Offset = "0x3605B20", VA = "0x183606720")]
	public bool HFAEDKNMEEN<T>(JKEDBGGDMBH HGFGHNJEEAJ, T IGICHEAKAKH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x36067C0", Offset = "0x3605BC0", VA = "0x1836067C0")]
	public void PELCBGJOJPC<T>(EGJDBJHJPJD CEAJPINGICH, T BLFGIKOAKOL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ENLAOPDJMNP
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime PPPMHAMDEKM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] HAONEAHMEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BCDPFPBFEML IMEKIFEOGON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F50", Offset = "0x6B84350", VA = "0x186B84F50")]
		get
		{
			return default(BCDPFPBFEML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MPPKCJGGBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B844E0", Offset = "0x6B838E0", VA = "0x186B844E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B84920", Offset = "0x6B83D20", VA = "0x186B84920")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CMAKGDPDGBB GGJDAFKPKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B851B0", Offset = "0x6B845B0", VA = "0x186B851B0")]
		get
		{
			return default(CMAKGDPDGBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B84CB0", Offset = "0x6B840B0", VA = "0x186B84CB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MPFBLGKFGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B84CF0", Offset = "0x6B840F0", VA = "0x186B84CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint ABHGBKLBDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B84A30", Offset = "0x6B83E30", VA = "0x186B84A30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CKHKDHFAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B84FB0", Offset = "0x6B843B0", VA = "0x186B84FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? JKBDFJFEEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B84F80", Offset = "0x6B84380", VA = "0x186B84F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? OPHJLMOKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B84510", Offset = "0x6B83910", VA = "0x186B84510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B84FE0", Offset = "0x6B843E0", VA = "0x186B84FE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? LOHMPPCPNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xB52830", Offset = "0xB51C30", VA = "0x180B52830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xD2EB00", Offset = "0xD2DF00", VA = "0x180D2EB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B85240", Offset = "0x6B84640", VA = "0x186B85240")]
	public ENLAOPDJMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B85560", Offset = "0x6B84960", VA = "0x186B85560")]
	internal ENLAOPDJMNP(byte[] DHHEGLJJIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B84800", Offset = "0x6B83C00", VA = "0x186B84800")]
	public static ENLAOPDJMNP EDEFMBGGGEA(byte[] DHHEGLJJIIE, DateTime LLGOFMDFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B84AB0", Offset = "0x6B83EB0", VA = "0x186B84AB0")]
	internal void HPNENDDJFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B84300", Offset = "0x6B83700", VA = "0x186B84300")]
	private void BGJHFAJPJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B84600", Offset = "0x6B83A00", VA = "0x186B84600")]
	private DateTime? DJLGKIEHJPN(int HGHGCNDALFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B84D20", Offset = "0x6B84120", VA = "0x186B84D20")]
	private void KDPGMJNODKA(int HGHGCNDALFP, DateTime? FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B84960", Offset = "0x6B83D60", VA = "0x186B84960")]
	private ulong FKDFDFAOHOC(int HGHGCNDALFP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B84540", Offset = "0x6B83940", VA = "0x186B84540")]
	private void DGEHLFDGOGK(int HGHGCNDALFP, ulong FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B84270", Offset = "0x6B83670", VA = "0x186B84270")]
	private uint BECKNCNOINC(int HGHGCNDALFP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D6A0", Offset = "0x6A4CAA0", VA = "0x186A4D6A0")]
	private static uint KEGMBIOIKKF(uint MEAMPLHPPKP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B84EF0", Offset = "0x6B842F0", VA = "0x186B84EF0")]
	private static ulong KEGMBIOIKKF(ulong MEAMPLHPPKP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BCDPFPBFEML
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum CMAKGDPDGBB
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EDGJFADDDKE
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int DNPAINIMMJH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int NENDNMEKIIF = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int GMFEKHMFGOA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint MGJLKPEHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int JKAAMIPOLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int BIDBIDGJEDB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MAGBCNPLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B83170", Offset = "0x6B82570", VA = "0x186B83170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B83180", Offset = "0x6B82580", VA = "0x186B83180")]
	public bool CBLPHADFEEI(OFICCEDJJEN NFAIKPDMPFH, int GLBFMHKMALN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HEKPOHFLMBB : OFICCEDJJEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket NFAIKPDMPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly HNKCBLCMLIG JLEBCJGHEBM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short PFONHEFMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B86240", Offset = "0x6B85640", VA = "0x186B86240", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GPCOFEGEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B85B50", Offset = "0x6B84F50", VA = "0x186B85B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint COFDEGBJDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6B862A0", Offset = "0x6B856A0", VA = "0x186B862A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily HHLFMNPMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4E28710", Offset = "0x4E27B10", VA = "0x184E28710", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B862C0", Offset = "0x6B856C0", VA = "0x186B862C0")]
	public HEKPOHFLMBB(AddressFamily EFACGDPKCMH, HNKCBLCMLIG JLEBCJGHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B85C80", Offset = "0x6B85080", VA = "0x186B85C80", Slot = "8")]
	public bool GNEPPKHNKDD(IPEndPoint GPMGNDICFDJ, HNGEAILFMHJ CIOHMEGILBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B86260", Offset = "0x6B85660", VA = "0x186B86260", Slot = "9")]
	public int KLNGGLDFIMJ(byte[] DAMDACDIHDN, int HGHGCNDALFP, int MNDMOIHIBEI, IPEndPoint FHIIAMOAEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B85B70", Offset = "0x6B84F70", VA = "0x186B85B70", Slot = "10")]
	public int FKABPLOOHNF(byte[] DAMDACDIHDN, EndPoint FGADBCGBOGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B85C60", Offset = "0x6B85060", VA = "0x186B85C60", Slot = "11")]
	public void GINGEHMNEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface OFICCEDJJEN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short PFONHEFMGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int GPCOFEGEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint COFDEGBJDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily HHLFMNPMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNEPPKHNKDD(IPEndPoint GPMGNDICFDJ, HNGEAILFMHJ CIOHMEGILBI);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KLNGGLDFIMJ(byte[] DAMDACDIHDN, int HGHGCNDALFP, int MNDMOIHIBEI, IPEndPoint FHIIAMOAEHB);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FKABPLOOHNF(byte[] DAMDACDIHDN, EndPoint FHIIAMOAEHB);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GINGEHMNEFP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct PHJJDDHBJDK : IEquatable<PHJJDDHBJDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long HFIBAEBGIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long HIMLJFBPIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long CGDIKLEMILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int ONDMMGCCHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int DBJKLENBJDE;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6B93950", Offset = "0x6B92D50", VA = "0x186B93950")]
	public PHJJDDHBJDK(byte[] KHGADHNAFJA, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6B936E0", Offset = "0x6B92AE0", VA = "0x186B936E0")]
	public PHJJDDHBJDK(Span<byte> KHGADHNAFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9D2A50", Offset = "0x9D1E50", VA = "0x1809D2A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6B935F0", Offset = "0x6B929F0", VA = "0x186B935F0", Slot = "4")]
	public bool Equals(PHJJDDHBJDK KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6B93630", Offset = "0x6B92A30", VA = "0x186B93630", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HMNLIKLPBBO : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] NKCCHNDFMKK;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GNGFEMKCGJM
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void DGKEMKLAIHC(IPEndPoint KHGADHNAFJA, Span<byte> HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string IMMKJFPKODG = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int CFOHDIAGLCD = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int NDGFJANICBP = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<PHJJDDHBJDK, IPEndPoint> CMHCNIJPLDI;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static DGKEMKLAIHC IENINKMPLOP;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	internal void OHKLFDKACBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	internal void LEFELHFBJMB(IPEndPoint FHIIAMOAEHB, Span<byte> HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class ILGFMKGKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int BIKHFCGLODA;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
	protected ILGFMKGKFLD(int LJEPJGOBOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EENJEACFGLD(IPEndPoint GPMGNDICFDJ, byte[] HPMNBNLACCC, int HGHGCNDALFP, int BFBCILDCBHG);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CBPIFGKFNOO(IPEndPoint GPMGNDICFDJ, byte[] HPMNBNLACCC, int HGHGCNDALFP, int BFBCILDCBHG);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DNJLMEOKNJI : ILGFMKGKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] DJBLFBEBKGO;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator KMPIPACCLHH;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x26A31A0", Offset = "0x26A25A0", VA = "0x1826A31A0")]
	public DNJLMEOKNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6B82F70", Offset = "0x6B82370", VA = "0x186B82F70")]
	public void LMGDOLINILO(IPEndPoint GPMGNDICFDJ, byte[] DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6B82680", Offset = "0x6B81A80", VA = "0x186B82680")]
	public void APCIPABJFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6B82AC0", Offset = "0x6B81EC0", VA = "0x186B82AC0", Slot = "4")]
	public override void EENJEACFGLD(IPEndPoint GPMGNDICFDJ, byte[] HPMNBNLACCC, int HGHGCNDALFP, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6B82760", Offset = "0x6B81B60", VA = "0x186B82760", Slot = "5")]
	public override void CBPIFGKFNOO(IPEndPoint GPMGNDICFDJ, byte[] HPMNBNLACCC, int HGHGCNDALFP, int BFBCILDCBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct MCHMFAJJNFI
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void EKDOCOFAIPG([NoAlias] byte* CICJGFLDLAN, [NoAlias] byte* DJBLFBEBKGO, [NoAlias] byte* IMAKOGDPKFG, int BFBCILDCBHG);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class IEJEGOGPPBH
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr JKIHMMIKKLA;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr NKIPCAKCKGD;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6B97E60", Offset = "0x6B97260", VA = "0x186B97E60")]
		[BurstDiscard]
		private static void JLEHOHLGDMG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6B97F80", Offset = "0x6B97380", VA = "0x186B97F80")]
		private static IntPtr PDAHEBPHBOM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6B97B90", Offset = "0x6B96F90", VA = "0x186B97B90")]
		public static void CJDCHOGEOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		public static void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6B97C30", Offset = "0x6B97030", VA = "0x186B97C30")]
		public unsafe static void HKANHPMMIAO([NoAlias] byte* CICJGFLDLAN, [NoAlias] byte* DJBLFBEBKGO, [NoAlias] byte* IMAKOGDPKFG, int BFBCILDCBHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint DJBLFBEBKGO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint IMAKOGDPKFG[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint HMNINMMFBEH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint NADMJLAHBGD[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint PBNPKPFLCBB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint JAMOAIJBHPM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint MBMDDPJEGIJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint MFMCOFAJPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint NJJCBIMJHBH[8];

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6B923B0", Offset = "0x6B917B0", VA = "0x186B923B0")]
	private void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6B92B80", Offset = "0x6B91F80", VA = "0x186B92B80")]
	private uint PALGOEHAPCO(uint CHAOGBKCKEH, int CJLHLBOHHOG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FC80", Offset = "0x6B7F080", VA = "0x186B7FC80")]
	private void EDHFLDCCBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FEC0", Offset = "0x6B7F2C0", VA = "0x186B7FEC0")]
	private void OIHADHNAGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FD30", Offset = "0x6B7F130", VA = "0x186B7FD30")]
	private void EDOBLAPONCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FDC0", Offset = "0x6B7F1C0", VA = "0x186B7FDC0")]
	private void LMFELHAEGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6B92B20", Offset = "0x6B91F20", VA = "0x186B92B20")]
	private void MPNEDJIKBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6B92690", Offset = "0x6B91A90", VA = "0x186B92690")]
	private unsafe void KMAHEOANNGK(byte* CICJGFLDLAN, uint* DJBLFBEBKGO, uint* IMAKOGDPKFG, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6B92530", Offset = "0x6B91930", VA = "0x186B92530")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IMKGBFNNHFA([NoAlias] byte* CICJGFLDLAN, [NoAlias] byte* DJBLFBEBKGO, [NoAlias] byte* IMAKOGDPKFG, int BFBCILDCBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6B925B0", Offset = "0x6B919B0", VA = "0x186B925B0")]
	public static void IMKGBFNNHFA(Span<byte> CICJGFLDLAN, Span<byte> DJBLFBEBKGO, Span<byte> IMAKOGDPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6B92430", Offset = "0x6B91830", VA = "0x186B92430")]
	public static void ILDAHINFHOG(Span<byte> CICJGFLDLAN, Span<byte> DJBLFBEBKGO, Span<byte> IMAKOGDPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6B92AB0", Offset = "0x6B91EB0", VA = "0x186B92AB0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MCPJLJNOMEN([NoAlias] byte* CICJGFLDLAN, [NoAlias] byte* DJBLFBEBKGO, [NoAlias] byte* IMAKOGDPKFG, int BFBCILDCBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6B980D0", Offset = "0x6B974D0", VA = "0x186B980D0")]
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
