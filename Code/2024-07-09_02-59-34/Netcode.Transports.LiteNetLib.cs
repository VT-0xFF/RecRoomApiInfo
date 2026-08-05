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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OOFKPFAOENE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum FIKCCDJPGBB
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
		private NetworkManager JLJMCBLENMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, NNHAJAKHPFK> KJCNBKCMPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CIJNMCMKNBG CHOCLIBCELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NJDAGMJOKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FIKCCDJPGBB GPPEDFBANID;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong OIAIGCOMPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool DCFILOLNOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4DF0", Offset = "0x5DF39F0", VA = "0x185DF4DF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4350", Offset = "0x5DF2F50", VA = "0x185DF4350")]
		public void RecRoom_SetEncryptionInfo(ulong OLEOAMBFGFN, byte[] NCMHANGAILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4330", Offset = "0x5DF2F30", VA = "0x185DF4330")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4200", Offset = "0x5DF2E00", VA = "0x185DF4200")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4CF0", Offset = "0x5DF38F0", VA = "0x185DF4CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DF44F0", Offset = "0x5DF30F0", VA = "0x185DF44F0", Slot = "6")]
		public override void Send(ulong CKOADLAGGBG, ArraySegment<byte> JGFKFMMOAJO, NetworkDelivery KJBAHLBAMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF42F0", Offset = "0x5DF2EF0", VA = "0x185DF42F0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong CKOADLAGGBG, [Out] ArraySegment<byte> BHGBMMFNCAD, [Out] float NGLDBPKINLA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF47E0", Offset = "0x5DF33E0", VA = "0x185DF47E0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4C10", Offset = "0x5DF3810", VA = "0x185DF4C10", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3A20", Offset = "0x5DF2620", VA = "0x185DF3A20", Slot = "10")]
		public override void DisconnectRemoteClient(ulong CKOADLAGGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF38D0", Offset = "0x5DF24D0", VA = "0x185DF38D0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3BB0", Offset = "0x5DF27B0", VA = "0x185DF3BB0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong CKOADLAGGBG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4770", Offset = "0x5DF3370", VA = "0x185DF4770", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3C80", Offset = "0x5DF2880", VA = "0x185DF3C80", Slot = "14")]
		public override void Initialize([Optional] NetworkManager JLJMCBLENMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3F20", Offset = "0x5DF2B20", VA = "0x185DF3F20")]
		private OFEMBKGMFKD MEILCEMHDEM(NetworkDelivery HGPIKDLKBHO)
		{
			return default(OFEMBKGMFKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DF37B0", Offset = "0x5DF23B0", VA = "0x185DF37B0", Slot = "15")]
		private void COADNFOLPHH(NNHAJAKHPFK AAGOLLMKAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3670", Offset = "0x5DF2270", VA = "0x185DF3670", Slot = "16")]
		private void BEPKFNCMAAI(NNHAJAKHPFK AAGOLLMKAJP, DEFDGDNELIC IJJIGJDEFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "17")]
		private void FNBMJJJKMJK(IPEndPoint FAEJLEDMPLE, SocketError NHPGLEICPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3FF0", Offset = "0x5DF2BF0", VA = "0x185DF3FF0", Slot = "18")]
		private void MKBDJOOPOEE(NNHAJAKHPFK AAGOLLMKAJP, LBKNHAPHOPP KLAPEMMBNLL, byte NPPDAIGALOA, OFEMBKGMFKD LFOGDECEADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3E40", Offset = "0x5DF2A40", VA = "0x185DF3E40")]
		private void KBIMODLDINM(int INGCLKPLIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "19")]
		private void CCGKDLGKPEJ(IPEndPoint CIPACILOHCP, LBKNHAPHOPP KLAPEMMBNLL, HJIEIIIIMEK PONNJPECLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "20")]
		private void NBBBIFEJHIM(NNHAJAKHPFK AAGOLLMKAJP, int CFKIFLCNLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3870", Offset = "0x5DF2470", VA = "0x185DF3870", Slot = "21")]
		private void DADNDPIFFND(EBKGICKINOI KAIGMLIOMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3C50", Offset = "0x5DF2850", VA = "0x185DF3C50")]
		private ulong IJCNAECPGII(NNHAJAKHPFK AAGOLLMKAJP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3B90", Offset = "0x5DF2790", VA = "0x185DF3B90")]
		private static int GIDIGPPNACC(float JACNKEDDJOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4D10", Offset = "0x5DF3910", VA = "0x185DF4D10")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class FOOCPOFDAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NNHAJAKHPFK LPHONNFGEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<PBLGDIDDGJE> ADDKGLNNPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KEGCJCMFNMO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF04D0", Offset = "0x5DEF0D0", VA = "0x185DF04D0")]
	protected FOOCPOFDAMO(NNHAJAKHPFK AAGOLLMKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0470", Offset = "0x5DEF070", VA = "0x185DF0470")]
	public void OPFABIFHBHK(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DF03B0", Offset = "0x5DEEFB0", VA = "0x185DF03B0")]
	protected void AKJPLANJJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0430", Offset = "0x5DEF030", VA = "0x185DF0430")]
	public bool NENEEFPMBFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool DILENIHJFPP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PHNOOBFLIAN(PBLGDIDDGJE HKPDNKBBCGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CBPENIOIABN
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
public class EBKGICKINOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CIJNMCMKNBG LMNAIDJLMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int BCCCCNMFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GDKBBOKMIBP MPHIJEBBFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint EDFLHOIEJBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CBPENIOIABN AANGCDILCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88E1E0", Offset = "0x88CDE0", VA = "0x18088E1E0")]
		[CompilerGenerated]
		get
		{
			return default(CBPENIOIABN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAE5E30", Offset = "0xAE4A30", VA = "0x180AE5E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF790", Offset = "0x5DEE390", VA = "0x185DEF790")]
	internal void OLHHLBKKGAI(GDKBBOKMIBP OICPCEIMBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF760", Offset = "0x5DEE360", VA = "0x185DEF760")]
	private bool GPCDLDGIDIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF7F0", Offset = "0x5DEE3F0", VA = "0x185DEF7F0")]
	internal EBKGICKINOI(IPEndPoint CIPACILOHCP, GDKBBOKMIBP LJMICJJMHJL, CIJNMCMKNBG OGEMOEEFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF700", Offset = "0x5DEE300", VA = "0x185DEF700")]
	public NNHAJAKHPFK AGBCDJIBEDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HJIEIIIIMEK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GEKLEBJEAJC
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
public struct DEFDGDNELIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GEKLEBJEAJC ECAPIDFBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError DEEPNPNGDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LBKNHAPHOPP DPMJIEOBBNF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OOFKPFAOENE
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDNGGPNMOCA(NNHAJAKHPFK AAGOLLMKAJP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGLHDOIOHNI(NNHAJAKHPFK AAGOLLMKAJP, DEFDGDNELIC IJJIGJDEFIF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBCMLOGNAMK(IPEndPoint FAEJLEDMPLE, SocketError NHPGLEICPPH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEOFKGKFNAL(NNHAJAKHPFK AAGOLLMKAJP, LBKNHAPHOPP KLAPEMMBNLL, byte NPPDAIGALOA, OFEMBKGMFKD LFOGDECEADO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJIHHOCGPCB(IPEndPoint CIPACILOHCP, LBKNHAPHOPP KLAPEMMBNLL, HJIEIIIIMEK PONNJPECLLD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJEPLCBLCMA(NNHAJAKHPFK AAGOLLMKAJP, int CFKIFLCNLFB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALPDDDHCFCO(EBKGICKINOI KAIGMLIOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KIDBFGPJHDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFOIALCCEPK(NNHAJAKHPFK AAGOLLMKAJP, object LJJFNBLNDJA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JAKJPIBLOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJOOLKILHPP(BDKMLJIAEMJ HKPDNKBBCGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MGHHDIBMPHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMGLPIJMBKF(NNHAJAKHPFK AAGOLLMKAJP, IPEndPoint GFOBOHFPGJG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GDKBBOKMIBP
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NKKJMMHLKGM = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long LDMGJPNNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte AOCDGJHLMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] KEFIOJLLOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KENAAEANNFC COKNLHIJAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int GHAGNINEPKC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0BB0", Offset = "0x5DEF7B0", VA = "0x185DF0BB0")]
	private GDKBBOKMIBP(long BPECPGCOPAL, byte IEMBLMMDFLO, int IDIEOFKIGBL, byte[] JMCHMEJOKIL, KENAAEANNFC JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0750", Offset = "0x5DEF350", VA = "0x185DF0750")]
	public static int GKMNMHFGNOG(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0990", Offset = "0x5DEF590", VA = "0x185DF0990")]
	public static GDKBBOKMIBP PILMDHCMJNC(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DF07B0", Offset = "0x5DEF3B0", VA = "0x185DF07B0")]
	public static PBLGDIDDGJE KEIGFNEJILI(DLNEILKCFGG ECDNJGGLKCB, SocketAddress OILJPMBFFCL, long GHCDJPJLABM, int IDIEOFKIGBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class ODDLJAGJMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long LDMGJPNNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte AOCDGJHLMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int GHAGNINEPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool FNCAIPLNNPK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAAD0", Offset = "0x5DF96D0", VA = "0x185DFAAD0")]
	private ODDLJAGJMLC(long BPECPGCOPAL, byte IEMBLMMDFLO, int EMCPNGDDIGA, bool GFBJLECGNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA980", Offset = "0x5DF9580", VA = "0x185DFA980")]
	public static ODDLJAGJMLC PILMDHCMJNC(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA890", Offset = "0x5DF9490", VA = "0x185DFA890")]
	public static PBLGDIDDGJE KEIGFNEJILI(long GHCDJPJLABM, byte GFHBDELLOFI, int GDPKGIMGJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA790", Offset = "0x5DF9390", VA = "0x185DFA790")]
	public static PBLGDIDDGJE HMFEIKNJCGA(NNHAJAKHPFK AAGOLLMKAJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum LHFANOLPDMI
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FJGKNALMGJO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPEJPHEOHJB(IPEndPoint FDBJMHEMFKD, IPEndPoint CIPACILOHCP, string GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJJFHAKPBLC(IPEndPoint LMNHFLCHMAN, LHFANOLPDMI HGPIKDLKBHO, string GBENACPKFNA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PFJBAOAIKKL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KOABKEIJOAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint ICNJDENOGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint EDFLHOIEJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string LBCCJNPCCPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GCDNIPPEJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JDOBIDBCOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LHFANOLPDMI DOJGHAOJFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LBCCJNPCCPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class BPNGMINCFKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint LGDHAOMACFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LBCCJNPCCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BPNGMINCFKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BKLBNFJGKMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint LGDHAOMACFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint MAMKDODIDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LBCCJNPCCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BKLBNFJGKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class JFKIHBFEGIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LBCCJNPCCPI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MLLOKFGNHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x933850", Offset = "0x932450", VA = "0x180933850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x873D60", Offset = "0x872960", VA = "0x180873D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JFKIHBFEGIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CIJNMCMKNBG OHIKMIBGGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<KOABKEIJOAK> LMJKIHEJBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<GCDNIPPEJEN> ECMKCKBIHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KENAAEANNFC FKFBMEIKPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DLNEILKCFGG BMBEEHIGIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PLAIPKJEALF COOMEHGBNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private FJGKNALMGJO EBBAPGEIOMF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int KIDLJGLHNBN = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DPDAANPGGEK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC170", Offset = "0x5DFAD70", VA = "0x185DFC170")]
	internal PFJBAOAIKKL(CIJNMCMKNBG BFGOPJAIDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBEB0", Offset = "0x5DFAAB0", VA = "0x185DFBEB0")]
	internal void LJKCPGJBGMF(IPEndPoint BFJOMKHBHGB, PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CE51A0", Offset = "0x2CE3DA0", VA = "0x182CE51A0")]
	private void PKGOHKCFCEC<T>(T HKPDNKBBCGJ, IPEndPoint EEOLDJILHGA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBBA0", Offset = "0x5DFA7A0", VA = "0x185DFBBA0")]
	private void CPEJPHEOHJB(BPNGMINCFKB GAIKHLNHFOH, IPEndPoint BFJOMKHBHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC010", Offset = "0x5DFAC10", VA = "0x185DFC010")]
	private void MBDDHPINODO(BKLBNFJGKMA GAIKHLNHFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBD20", Offset = "0x5DFA920", VA = "0x185DFBD20")]
	private void JCPGIJJGANO(JFKIHBFEGIA GAIKHLNHFOH, IPEndPoint BFJOMKHBHGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OFEMBKGMFKD : byte
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
public enum BKILFAJFABA : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BPAIBFHFILC
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] ILGDKMMBHHC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int DHPGEFMGGIC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int AJANIKHDEMD;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JLDLBBGCNIA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE61A0", VA = "0x185DE75A0")]
	public JLDLBBGCNIA(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CEBMMNGGFEE : JLDLBBGCNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE61A0", VA = "0x185DE75A0")]
	public CEBMMNGGFEE(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PHHNAGCEELP
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
public interface DLIMJKEFGGH
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCAKCOKEBPE(PHHNAGCEELP BDLFBJECBPK, string GBJCJEFDEPC, params object[] OHIOFOHNMPI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KADGPADJNOA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static DLIMJKEFGGH HFKLDFIJMOI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object BLFMNAPEPPO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1390", Offset = "0x5DEFF90", VA = "0x185DF1390")]
	private static void IEKANDNINOE(PHHNAGCEELP KKPEMMGJOAK, string GBJCJEFDEPC, params object[] OHIOFOHNMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1620", Offset = "0x5DF0220", VA = "0x185DF1620")]
	internal static void LLLAGAMLBBM(string GBJCJEFDEPC, params object[] OHIOFOHNMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1330", Offset = "0x5DEFF30", VA = "0x185DF1330")]
	internal static void BMAAMDCNFKB(string GBJCJEFDEPC, params object[] OHIOFOHNMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DF15C0", Offset = "0x5DF01C0", VA = "0x185DF15C0")]
	internal static void IKKBOICIMGE(string GBJCJEFDEPC, params object[] OHIOFOHNMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum JCKKHAMLNNJ
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LBKNHAPHOPP : KENAAEANNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PBLGDIDDGJE AMLHGEAGLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CIJNMCMKNBG ECBKCNEIHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BOMOIKPFHNK OFHDCBHIECP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2600", Offset = "0x5DF1200", VA = "0x185DF2600")]
	internal LBKNHAPHOPP(CIJNMCMKNBG DMMHPLIIKDJ, BOMOIKPFHNK PDAGNJOLBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2510", Offset = "0x5DF1110", VA = "0x185DF2510")]
	internal void JEILPOMBDNE(PBLGDIDDGJE HKPDNKBBCGJ, int IPFJCIKCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2580", Offset = "0x5DF1180", VA = "0x185DF2580")]
	internal void NDMLKADBLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF24E0", Offset = "0x5DF10E0", VA = "0x185DF24E0")]
	public void IMOABABIOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BOMOIKPFHNK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum HFCEJOIOECN
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
	public BOMOIKPFHNK LMJDMBCGCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public HFCEJOIOECN DOJGHAOJFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NNHAJAKHPFK LPHONNFGEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint EDFLHOIEJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object BMFJPFCAKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int CLAOOKDFBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError MCOEAEDPPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public GEKLEBJEAJC NACPCJABEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public EBKGICKINOI FLOGIAJIKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public OFEMBKGMFKD LMMHDMNKJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte DIAOHGEHMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly LBKNHAPHOPP PHKEJBCPKHA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7420", Offset = "0x5DE6020", VA = "0x185DE7420")]
	public BOMOIKPFHNK(CIJNMCMKNBG DMMHPLIIKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CIJNMCMKNBG : IEnumerable<NNHAJAKHPFK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class BEFFOPFLDHJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7310", Offset = "0x5DE5F10", VA = "0x185DE7310", Slot = "4")]
		public bool Equals(IPEndPoint KIGIELEFAKI, IPEndPoint DKINGMIONNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58EF010", Offset = "0x58EDC10", VA = "0x1858EF010", Slot = "5")]
		public int GetHashCode(IPEndPoint APKAFMDACKK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BEFFOPFLDHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct BLELBCDOAMH : IEnumerator<NNHAJAKHPFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly NNHAJAKHPFK NMPIEFFGPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NNHAJAKHPFK PFDNNBEIIDF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NNHAJAKHPFK KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E70", Offset = "0x8D5A70", VA = "0x1808D6E70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E70", Offset = "0x8D5A70", VA = "0x1808D6E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10EB680", Offset = "0x10EA280", VA = "0x1810EB680")]
		public BLELBCDOAMH(NNHAJAKHPFK GJCPBEAOKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7380", Offset = "0x5DE5F80", VA = "0x185DE7380", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE73D0", Offset = "0x5DE5FD0", VA = "0x185DE73D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread CDGGGHHAEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool ACNNJJDLEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent HMBNGFIPGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<BOMOIKPFHNK> FIHLOOOFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<BOMOIKPFHNK> ELAHFLLILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private BOMOIKPFHNK DKLDMFMDPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OOFKPFAOENE JJLCFKMEBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KIDBFGPJHDJ JAFHFIJPFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JAKJPIBLOGD MCHGEOPAOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MGHHDIBMPHJ KACEINCIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, NNHAJAKHPFK> NBNNGGFEHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, EBKGICKINOI> CPHAHKBICHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, HEGBCHAPNFG> EIBCCGNAJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LGBALPHIMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NNHAJAKHPFK LMODMGAEOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int AOEPAKFOAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NNHAJAKHPFK> BFANCAMIMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NNHAJAKHPFK[] FFCNBCGEAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BNEFNHMDDMN CNIAANPCJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int KCLJJLPLCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> BNBOIFMHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte OOOHBLKMMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object AKKOIEKNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool DPFGLMCLDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool MLAPIOLIFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NCCNGCCAOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int NPDAHGMCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int PHJLGIGOOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GNPLEAPCHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DMFECCNNCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool HNCAADBMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LKFILDKKIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BGLNECGLDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int NLKAIKPKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DPDAANPGGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool DKFNDBFCLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PLKHEBNFEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool PNBNJACLICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int OLPAMAAHGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int FGOAPCNODOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool NAPHOALLHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly ONGEMBKOHNB OJOCJNMIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool OOEPCBJGLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly PFJBAOAIKKL PAOLPCFHFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool AFPLBLGFALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public JCKKHAMLNNJ BDABFFEEDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int KDBKGIDDLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MIJFPGELGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MENIOCPMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GJNHLBAKOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FEPNBPBFNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PBLGDIDDGJE MEHJDINMFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int AAMKNPHMHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object PNPAPIFCKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PBLGDIDDGJE GMLBGMHAOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NBDNDHHMCFN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int HPDEBKBADAK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int COEIEJGAPOF = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AAGFFAMHKAB CPIONMIHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private AAGFFAMHKAB JCBKDBGPFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DMEJDCPECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread JFCMNFCACOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint OCENLEMLPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint GOILEHPBPGN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] HHFFOPIABFO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] DNGENJCEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<FPGGOOMBPJN, IPEndPoint> MNJCKNCIIDJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress JNHBCBOLMBF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool IGCPAELDHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int NDIKEGIJIDE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NLJIDBOIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBE63C0", Offset = "0xBE4FC0", VA = "0x180BE63C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC94FC0", Offset = "0xC93BC0", VA = "0x180C94FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HLHCELLGPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14EBE40", Offset = "0x14EAA40", VA = "0x1814EBE40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x181C5C0", Offset = "0x181B1C0", VA = "0x18181C5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte IFOPJOEMAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4D7C0", Offset = "0xA4C3C0", VA = "0x180A4D7C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKDNIDACIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA920", Offset = "0x5DE9520", VA = "0x185DEA920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short EPIIMDLLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE85A0", Offset = "0x5DE71A0", VA = "0x185DE85A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC600", Offset = "0x5DEB200", VA = "0x185DEC600")]
	public void NJELNLANCOC(IPEndPoint FAEJLEDMPLE, byte[] NCMHANGAILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC900", Offset = "0x5DEB500", VA = "0x185DEC900")]
	public void OHEEFALOHLA(IPEndPoint FAEJLEDMPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDA20", Offset = "0x5DEC620", VA = "0x185DEDA20")]
	private bool OOOGABKBMBB(IPEndPoint FAEJLEDMPLE, [Out] NNHAJAKHPFK AAGOLLMKAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA940", Offset = "0x5DE9540", VA = "0x185DEA940")]
	private void IAACMLJFJPH(NNHAJAKHPFK AAGOLLMKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75B0", Offset = "0x5DE61B0", VA = "0x185DE75B0")]
	private void ACHMANKNLGC(NNHAJAKHPFK AAGOLLMKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDAB0", Offset = "0x5DEC6B0", VA = "0x185DEDAB0")]
	private void PAOJEDJNMJJ(NNHAJAKHPFK AAGOLLMKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE080", Offset = "0x5DECC80", VA = "0x185DEE080")]
	public CIJNMCMKNBG(OOFKPFAOENE OGEMOEEFNGD, [Optional] BNEFNHMDDMN JPMAPEJFEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7600", Offset = "0x5DE6200", VA = "0x185DE7600")]
	internal void AEIGPHOHMIG(NNHAJAKHPFK OFLGNJIOLCL, int CFKIFLCNLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE87D0", Offset = "0x5DE73D0", VA = "0x185DE87D0")]
	internal void DNFKBFLPGCP(NNHAJAKHPFK OFLGNJIOLCL, object LJJFNBLNDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8180", Offset = "0x5DE6D80", VA = "0x185DE8180")]
	internal void CBBPFLGKJPD(NNHAJAKHPFK AAGOLLMKAJP, GEKLEBJEAJC GLMDIHNLEBJ, SocketError ONEHKEGNHCO, PBLGDIDDGJE JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE84C0", Offset = "0x5DE70C0", VA = "0x185DE84C0")]
	private void COHHLDEHIGO(NNHAJAKHPFK AAGOLLMKAJP, GEKLEBJEAJC GLMDIHNLEBJ, SocketError ONEHKEGNHCO, bool FPPHGAIAECP, byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int LLHINFJPPOH, PBLGDIDDGJE JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBF90", Offset = "0x5DEAB90", VA = "0x185DEBF90")]
	private void LGLOBNFLMOE(BOMOIKPFHNK.HFCEJOIOECN HGPIKDLKBHO, [Optional] NNHAJAKHPFK AAGOLLMKAJP, [Optional] IPEndPoint CIPACILOHCP, SocketError INPPILAHLCC = SocketError.Success, int CFKIFLCNLFB = 0, GEKLEBJEAJC BNGJGOHGCOF = GEKLEBJEAJC.ConnectionFailed, [Optional] EBKGICKINOI LJDKKDJFECN, OFEMBKGMFKD LFOGDECEADO = OFEMBKGMFKD.Unreliable, byte NPPDAIGALOA = 0, [Optional] PBLGDIDDGJE EMELDBKCFLM, [Optional] object LJJFNBLNDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DECA50", Offset = "0x5DEB650", VA = "0x185DECA50")]
	private void OJJEMLPILJD(BOMOIKPFHNK PDAGNJOLBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8250", Offset = "0x5DE6E50", VA = "0x185DE8250")]
	internal void CBICIBGLHID(BOMOIKPFHNK PDAGNJOLBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBC50", Offset = "0x5DEA850", VA = "0x185DEBC50")]
	private void KJNGPKKHDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA210", Offset = "0x5DE8E10", VA = "0x185DEA210")]
	private void FIIOPKKAMPE(int PFBMBIFHEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DED400", Offset = "0x5DEC000", VA = "0x185DED400")]
	internal NNHAJAKHPFK ONHIKCOLBEC(EBKGICKINOI KAIGMLIOMBJ, byte[] DJPKGGGKGIF, int CNNPCLMHBKN, int AEGGIAICNFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC580", Offset = "0x5DEB180", VA = "0x185DEC580")]
	private int NCLEECFCPBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB200", Offset = "0x5DE9E00", VA = "0x185DEB200")]
	private void IMNMFAJBMHM(IPEndPoint CIPACILOHCP, NNHAJAKHPFK LKNNODIGOOA, GDKBBOKMIBP GAIMHEGKEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DE93D0", Offset = "0x5DE7FD0", VA = "0x185DE93D0")]
	private void FDOMGKGJFKL(PBLGDIDDGJE HKPDNKBBCGJ, IPEndPoint CIPACILOHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8DB0", Offset = "0x5DE79B0", VA = "0x185DE8DB0")]
	internal void ECFDACEBOMH(PBLGDIDDGJE HKPDNKBBCGJ, OFEMBKGMFKD DPAALAGLLAK, byte NPPDAIGALOA, int IPFJCIKCJPK, NNHAJAKHPFK OFLGNJIOLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8150", Offset = "0x5DE6D50", VA = "0x185DE8150")]
	public bool CBAJJELMFPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8160", Offset = "0x5DE6D60", VA = "0x185DE8160")]
	public bool CBAJJELMFPM(IPAddress AANCMOGNPPB, IPAddress ICILGBDNEOO, int IKPNOAEKCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE80D0", Offset = "0x5DE6CD0", VA = "0x185DE80D0")]
	public bool CBAJJELMFPM(int IKPNOAEKCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDD00", Offset = "0x5DEC900", VA = "0x185DEDD00")]
	public void PGPCJIKPPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8900", Offset = "0x5DE7500", VA = "0x185DE8900")]
	public NNHAJAKHPFK DPGIKAAPJLL(string OCLHDMKBGBG, int IKPNOAEKCNK, string NCMHANGAILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8820", Offset = "0x5DE7420", VA = "0x185DE8820")]
	public NNHAJAKHPFK DPGIKAAPJLL(string OCLHDMKBGBG, int IKPNOAEKCNK, DLNEILKCFGG HOONMCLAPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE89E0", Offset = "0x5DE75E0", VA = "0x185DE89E0")]
	public NNHAJAKHPFK DPGIKAAPJLL(IPEndPoint EEOLDJILHGA, DLNEILKCFGG HOONMCLAPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5DE93C0", Offset = "0x5DE7FC0", VA = "0x185DE93C0")]
	public void EJFADHOCDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9070", Offset = "0x5DE7C70", VA = "0x185DE9070")]
	public void EJFADHOCDFA(bool OFDLPCENMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA820", Offset = "0x5DE9420", VA = "0x185DEA820")]
	public void GCOEAAMNFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA700", Offset = "0x5DE9300", VA = "0x185DEA700")]
	public void GCOEAAMNFGG(byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int LLHINFJPPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8410", Offset = "0x5DE7010", VA = "0x185DE8410")]
	public void COHHLDEHIGO(NNHAJAKHPFK AAGOLLMKAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8350", Offset = "0x5DE6F50", VA = "0x185DE8350")]
	public void COHHLDEHIGO(NNHAJAKHPFK AAGOLLMKAJP, byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int LLHINFJPPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDEA0", Offset = "0x5DECAA0", VA = "0x185DEDEA0", Slot = "4")]
	private IEnumerator<NNHAJAKHPFK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDF30", Offset = "0x5DECB30", VA = "0x185DEDF30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA530", Offset = "0x5DE9130", VA = "0x185DEA530")]
	private PBLGDIDDGJE GBAAFENPOAA(LAOCNHKGJNI LPPIGHILDBI, int INGCLKPLIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA620", Offset = "0x5DE9220", VA = "0x185DEA620")]
	private PBLGDIDDGJE GBAAFENPOAA(LAOCNHKGJNI LPPIGHILDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC350", Offset = "0x5DEAF50", VA = "0x185DEC350")]
	internal PBLGDIDDGJE MEKCIJDAOGH(int INGCLKPLIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB660", Offset = "0x5DEA260", VA = "0x185DEB660")]
	internal void INAGNANMANO(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDFC0", Offset = "0x5DECBC0", VA = "0x185DEDFC0")]
	static CIJNMCMKNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBE63C0", Offset = "0xBE4FC0", VA = "0x180BE63C0")]
	private bool DJLGOGBINMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA120", Offset = "0x5DE8D20", VA = "0x185DEA120")]
	private void FFLFLMLDJIJ(IPEndPoint PKLECPBEKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC820", Offset = "0x5DEB420", VA = "0x185DEC820")]
	private void NJPLMBLGMGK(IPEndPoint PKLECPBEKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DED260", Offset = "0x5DEBE60", VA = "0x185DED260")]
	private bool OLODFFOPKHH(SocketException GKFNJIBGPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7650", Offset = "0x5DE6250", VA = "0x185DE7650")]
	private void AJNANDGALMG(AAGFFAMHKAB BFGOPJAIDBD, EndPoint PBKFOKLDEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8C0", Offset = "0x5DEA4C0", VA = "0x185DEB8C0")]
	private void KGGHJFMJMGH(object FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7920", Offset = "0x5DE6520", VA = "0x185DE7920")]
	public bool CBAJJELMFPM(IPAddress AANCMOGNPPB, IPAddress ICILGBDNEOO, int IKPNOAEKCNK, bool BHOMFJCHGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5DED200", Offset = "0x5DEBE00", VA = "0x185DED200")]
	internal int OJLLCGKBGKN(PBLGDIDDGJE HKPDNKBBCGJ, IPEndPoint CIPACILOHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB1C0", Offset = "0x5DE9DC0", VA = "0x185DEB1C0")]
	internal int IIDPCIMAHCJ(PBLGDIDDGJE HKPDNKBBCGJ, IPEndPoint CIPACILOHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC00", Offset = "0x5DE9800", VA = "0x185DEAC00")]
	internal int IIDPCIMAHCJ(byte[] NKAJDDICLFH, int CNNPCLMHBKN, int AEGGIAICNFC, IPEndPoint CIPACILOHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8660", Offset = "0x5DE7260", VA = "0x185DE8660")]
	internal void DFGECNNLCJF(bool EBEHICFGJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LAOCNHKGJNI : byte
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
internal sealed class PBLGDIDDGJE
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MOIPJMCPBAK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] PEJLOOOLEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] OIKJIBKAOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int FODIPBCKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object BMFJPFCAKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public PBLGDIDDGJE LMJDMBCGCBD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LAOCNHKGJNI GLGENIGAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB320", Offset = "0x5DF9F20", VA = "0x185DFB320")]
		get
		{
			return default(LAOCNHKGJNI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB700", Offset = "0x5DFA300", VA = "0x185DFB700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AOCDGJHLMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB180", Offset = "0x5DF9D80", VA = "0x185DFB180")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB220", Offset = "0x5DF9E20", VA = "0x185DFB220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort KHDHODNOKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB660", Offset = "0x5DFA260", VA = "0x185DFB660")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB520", Offset = "0x5DFA120", VA = "0x185DFB520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LDJOBMBKMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB1B0", Offset = "0x5DF9DB0", VA = "0x185DFB1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LOIMPHLIIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB4C0", Offset = "0x5DFA0C0", VA = "0x185DFB4C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB4F0", Offset = "0x5DFA0F0", VA = "0x185DFB4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort COHGPFBIHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB120", Offset = "0x5DF9D20", VA = "0x185DFB120")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB6C0", Offset = "0x5DFA2C0", VA = "0x185DFB6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort PKNLJGFJECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB2C0", Offset = "0x5DF9EC0", VA = "0x185DFB2C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB1E0", Offset = "0x5DF9DE0", VA = "0x185DFB1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort IHCBDOIILMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB260", Offset = "0x5DF9E60", VA = "0x185DFB260")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB350", Offset = "0x5DF9F50", VA = "0x185DFB350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB740", Offset = "0x5DFA340", VA = "0x185DFB740")]
	static PBLGDIDDGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB390", Offset = "0x5DF9F90", VA = "0x185DFB390")]
	public void FMDMAFMHFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBA20", Offset = "0x5DFA620", VA = "0x185DFBA20")]
	public PBLGDIDDGJE(int INGCLKPLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBA90", Offset = "0x5DFA690", VA = "0x185DFBA90")]
	public PBLGDIDDGJE(LAOCNHKGJNI LPPIGHILDBI, int INGCLKPLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB3C0", Offset = "0x5DF9FC0", VA = "0x185DFB3C0")]
	public static int HMEAABBIDEH(LAOCNHKGJNI LPPIGHILDBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB430", Offset = "0x5DFA030", VA = "0x185DFB430")]
	public int HMEAABBIDEH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB560", Offset = "0x5DFA160", VA = "0x185DFB560")]
	public bool LAEDGFLAGKA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum GECNEJJICPO : byte
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
internal enum MIJNBGHPENE
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
internal enum KCPNECGJLHA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum PBLKMDBOHIA
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NNHAJAKHPFK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class EFMLDBOJNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PBLGDIDDGJE[] JPMKOPEPEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int LGBFNEJGDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PCMAELALBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte LOIMPHLIIJN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EFMLDBOJNBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void DOBKLPDGFPI(ulong MLACCANNMBG, int FIIDDHHPPMF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int APNHDEPLBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int IGDOGOPPONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int HLPGGKAIPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double JCCEIAPIPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BLDDBPJKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int IMMENCLBBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int EFCMIAPDEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch PLNMCKMIFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KKFNKHBPDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long CANNJPGOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object CNMAJCBELOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal NNHAJAKHPFK FNBCFOJPHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal NNHAJAKHPFK FLDNCKMFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<PBLGDIDDGJE> MKIHOLBHOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<FOOCPOFDAMO> EMFMLJCNOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FOOCPOFDAMO[] PJEJOMLFJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int FCJKFHIEEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int HPMJIMJELJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool DEADOAIPJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int EFBPDDHBHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int MOPHMAJGIBM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int FHIJCDFLLEL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int JFGCJGEJIEG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object CKKMBHGOBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KNIKDGJKJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, EFMLDBOJNBK> CJDFDFOMHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> DGGEKBOHGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PBLGDIDDGJE OMFNCKACKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int IPPECEICJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int EHEHAMPJLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint INMFEJCOOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KMDJALAFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int JGEEJEGDHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long MLNJNLJOLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte IMCIHENLHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GECNEJJICPO BNLHMHNPBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PBLGDIDDGJE MLGNJLDGLGH;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int ONIADGPPMLI = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int FGMFHBFMFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly PBLGDIDDGJE MLBCLBFILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly PBLGDIDDGJE NGNOPADDGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly PBLGDIDDGJE CAEEGLJGLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly PBLGDIDDGJE DCJFHMEDCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BKILFAJFABA MANBKLMCFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly CIJNMCMKNBG BIEBPODMNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int ALHLDKPOGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object KKHBCJDPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly ONGEMBKOHNB OJOCJNMIPOL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte NBPMEKPAMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC296C0", Offset = "0xC282C0", VA = "0x180C296C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DF7620", Offset = "0x5DF6220", VA = "0x185DF7620")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DEBNAHPNIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E3BD0", Offset = "0x8E27D0", VA = "0x1808E3BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GECNEJJICPO FPIILDHGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1322940", Offset = "0x1321540", VA = "0x181322940")]
		get
		{
			return default(GECNEJJICPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KECFALFPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86BCF0", Offset = "0x86A8F0", VA = "0x18086BCF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KMHBONKMLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCF94C0", Offset = "0xCF80C0", VA = "0x180CF94C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15EB550", Offset = "0x15EA150", VA = "0x1815EB550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LPLPEIIJNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DF77A0", Offset = "0x5DF63A0", VA = "0x185DF77A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JEIIPOPHFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x875460", Offset = "0x874060", VA = "0x180875460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double IIMKICJGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E310", Offset = "0x1A8CF10", VA = "0x181A8E310")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DOBKLPDGFPI OKAOMCGBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6F30", Offset = "0x5DF5B30", VA = "0x185DF6F30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF92E0", Offset = "0x5DF7EE0", VA = "0x185DF92E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9FC0", Offset = "0x5DF8BC0", VA = "0x185DF9FC0")]
	internal NNHAJAKHPFK(CIJNMCMKNBG IGOBJJICIOE, IPEndPoint CIPACILOHCP, int CABAGOHBNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF68F0", Offset = "0x5DF54F0", VA = "0x185DF68F0")]
	internal void BACPFPJEBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8C70", Offset = "0x5DF7870", VA = "0x185DF8C70")]
	internal void NKFGMJKFNFN(IPEndPoint BGEPMAKCCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7A40", Offset = "0x5DF6640", VA = "0x185DF7A40")]
	internal void JPNDJHMLMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF76D0", Offset = "0x5DF62D0", VA = "0x185DF76D0")]
	private void FNOACPGCDFF(int DJECAGOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8C30", Offset = "0x5DF7830", VA = "0x185DF8C30")]
	private void MJKDEJFGFKC(int KEADNKCHCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6950", Offset = "0x5DF5550", VA = "0x185DF6950")]
	private FOOCPOFDAMO DAKDBJFJBAK(byte BBKKKIFBKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA600", Offset = "0x5DF9200", VA = "0x185DFA600")]
	internal NNHAJAKHPFK(CIJNMCMKNBG IGOBJJICIOE, IPEndPoint CIPACILOHCP, int CABAGOHBNFK, byte GFHBDELLOFI, DLNEILKCFGG ECDNJGGLKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA420", Offset = "0x5DF9020", VA = "0x185DFA420")]
	internal NNHAJAKHPFK(CIJNMCMKNBG IGOBJJICIOE, EBKGICKINOI KAIGMLIOMBJ, int CABAGOHBNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF77B0", Offset = "0x5DF63B0", VA = "0x185DF77B0")]
	internal void HLNHDBGFCDE(GDKBBOKMIBP KAHJHGPIBFB, byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7800", Offset = "0x5DF6400", VA = "0x185DF7800")]
	internal bool IFINPGAHLDJ(ODDLJAGJMLC HKPDNKBBCGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9F90", Offset = "0x5DF8B90", VA = "0x185DF9F90")]
	public void PKGOHKCFCEC(byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int AEGGIAICNFC, OFEMBKGMFKD GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9390", Offset = "0x5DF7F90", VA = "0x185DF9390")]
	private void PDEFJNANOCK(byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int AEGGIAICNFC, byte NPPDAIGALOA, OFEMBKGMFKD LFOGDECEADO, object LJJFNBLNDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8470", Offset = "0x5DF7070", VA = "0x185DF8470")]
	public void LGCHJKLOFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6FE0", Offset = "0x5DF5BE0", VA = "0x185DF6FE0")]
	internal KCPNECGJLHA EPMGELMNNLL(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return default(KCPNECGJLHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8BD0", Offset = "0x5DF77D0", VA = "0x185DF8BD0")]
	internal void MGNDNEGNJMC(FOOCPOFDAMO AMOMOHPFHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6B00", Offset = "0x5DF5700", VA = "0x185DF6B00")]
	internal PBLKMDBOHIA DJCOONKILFE(byte[] JGFKFMMOAJO, int CNNPCLMHBKN, int AEGGIAICNFC, bool FPPHGAIAECP)
	{
		return default(PBLKMDBOHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6910", Offset = "0x5DF5510", VA = "0x185DF6910")]
	private void BEGAEIEBCEG(int KAJJGDGINIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7AD0", Offset = "0x5DF66D0", VA = "0x185DF7AD0")]
	internal void KIGJCPLBGLG(OFEMBKGMFKD DPAALAGLLAK, PBLGDIDDGJE GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF70C0", Offset = "0x5DF5CC0", VA = "0x185DF70C0")]
	private void FAHOLNKPPLB(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8CA0", Offset = "0x5DF78A0", VA = "0x185DF8CA0")]
	private void NNMJHJLCHCL(int GFJHAHMFGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7880", Offset = "0x5DF6480", VA = "0x185DF7880")]
	internal MIJNBGHPENE IMNMFAJBMHM(GDKBBOKMIBP GAIMHEGKEDH)
	{
		return default(MIJNBGHPENE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF98E0", Offset = "0x5DF84E0", VA = "0x185DF98E0")]
	internal void PHNOOBFLIAN(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6E10", Offset = "0x5DF5A10", VA = "0x185DF6E10")]
	private void EFLAKFMHLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6720", Offset = "0x5DF5320", VA = "0x185DF6720")]
	internal void ADIAPKACFKP(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8520", Offset = "0x5DF7120", VA = "0x185DF8520")]
	internal void LMJHDDPLKGM(int GFJHAHMFGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9020", Offset = "0x5DF7C20", VA = "0x185DF9020")]
	internal void OIEFPHBIHFK(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class ONGEMBKOHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long LFANFGOBOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NNGBFMDDKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HHLIFCCPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LAHBNHJGFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long LGKJLBEHKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long MDJCOKOOJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long BJOIHJJGFAN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long HGCIILJEAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DFABC0", Offset = "0x5DF97C0", VA = "0x185DFABC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DKOJMGCPMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB50", Offset = "0x5DF9750", VA = "0x185DFAB50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long MBILIJCBEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DFABD0", Offset = "0x5DF97D0", VA = "0x185DFABD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NBHCEODODFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD80", Offset = "0x5DF9980", VA = "0x185DFAD80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long PJMGKNMIANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD60", Offset = "0x5DF9960", VA = "0x185DFAD60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long JHCGIHIKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB20", Offset = "0x5DF9720", VA = "0x185DFAB20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BKILFAJFABA BEOFHCBDDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD70", Offset = "0x5DF9970", VA = "0x185DFAD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double OMKBGEIKFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB60", Offset = "0x5DF9760", VA = "0x185DFAB60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD00", Offset = "0x5DF9900", VA = "0x185DFAD00")]
	public void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD90", Offset = "0x5DF9990", VA = "0x185DFAD90")]
	public void OOBMPMEHGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAB30", Offset = "0x5DF9730", VA = "0x185DFAB30")]
	public void AKBCFOJGGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DFACC0", Offset = "0x5DF98C0", VA = "0x185DFACC0")]
	public void JKKOHDNBCFI(long FHMLAKAOGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAB40", Offset = "0x5DF9740", VA = "0x185DFAB40")]
	public void AMDDPJKHDAD(long LAJFLPPGINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFACD0", Offset = "0x5DF98D0", VA = "0x185DFACD0")]
	public void KJAEEBHABDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAC80", Offset = "0x5DF9880", VA = "0x185DFAC80")]
	public void FMKIOADPLAH(long NFPPGJJNAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFADC0", Offset = "0x5DF99C0", VA = "0x185DFADC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFABE0", Offset = "0x5DF97E0", VA = "0x185DFABE0")]
	public void DPPJGLLLPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ONGEMBKOHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JENDAMHDIJI
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> ICAGJICCDLO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1050", Offset = "0x5DEFC50", VA = "0x185DF1050")]
	public static IPEndPoint PEEEBGLBJDN(string EOJCJOFNHEI, int IKPNOAEKCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DC0", Offset = "0x5DEF9C0", VA = "0x185DF0DC0")]
	public static IPAddress JOCHKHPCMGA(string EOJCJOFNHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0F90", Offset = "0x5DEFB90", VA = "0x185DF0F90")]
	public static IPAddress JOCHKHPCMGA(string EOJCJOFNHEI, AddressFamily ICNCLGLMBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1020", Offset = "0x5DEFC20", VA = "0x185DF1020")]
	internal static int NBAMGKDANDK(int JALOEOGFLND, int FDJEFDFGBFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CC80", Offset = "0x2B9B880", VA = "0x182B9CC80")]
	internal static T[] GLCMHFEKIEA<T>(int LLHINFJPPOH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NCHBOABJBOF : FOOCPOFDAMO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DOPNNKFPHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private PBLGDIDDGJE AMLHGEAGLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long PHGLMGCMCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool NOENDIIPNGG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF660", Offset = "0x5DEE260", VA = "0x185DEF660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF640", Offset = "0x5DEE240", VA = "0x185DEF640")]
		public void KCBMKHLALEF(PBLGDIDDGJE HKPDNKBBCGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF5D0", Offset = "0x5DEE1D0", VA = "0x185DEF5D0")]
		public bool COOEDJEJCAC(long EEKPCPEPHMO, NNHAJAKHPFK AAGOLLMKAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF580", Offset = "0x5DEE180", VA = "0x185DEF580")]
		public bool AFPCPCPKMJJ(NNHAJAKHPFK AAGOLLMKAJP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly PBLGDIDDGJE GBNCAOBELNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DOPNNKFPHCI[] GIDHJAGELLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly PBLGDIDDGJE[] PFEBNEPGMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] HHANHFCIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int PJKDLHKFJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int LENKLCLKIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KGGFNPNKKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int INBNLPEEEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool HIDECJOFANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly OFEMBKGMFKD IJBLFGFGBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool FGKBCDJJOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int CAEOIODKFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte BKILFCCJNPO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6550", Offset = "0x5DF5150", VA = "0x185DF6550")]
	public NCHBOABJBOF(NNHAJAKHPFK AAGOLLMKAJP, bool HNFMICGIMFJ, byte CABAGOHBNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5B30", Offset = "0x5DF4730", VA = "0x185DF5B30")]
	private void JHBEBLFCIJN(PBLGDIDDGJE HKPDNKBBCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5680", Offset = "0x5DF4280", VA = "0x185DF5680", Slot = "4")]
	protected override bool DILENIHJFPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5EF0", Offset = "0x5DF4AF0", VA = "0x185DF5EF0", Slot = "5")]
	public override bool PHNOOBFLIAN(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MIFMBBLJMFN : FOOCPOFDAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int NAEMKKFKKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort LENKLCLKIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool JDLCMBMLCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PBLGDIDDGJE JOCLIIKNNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly PBLGDIDDGJE FFMJCHMFKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool PNCAIGAKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte BKILFCCJNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long KFELCKGGGBA;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5DF55C0", Offset = "0x5DF41C0", VA = "0x185DF55C0")]
	public MIFMBBLJMFN(NNHAJAKHPFK AAGOLLMKAJP, bool FPHIGNJFNDD, byte CABAGOHBNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4E10", Offset = "0x5DF3A10", VA = "0x185DF4E10", Slot = "4")]
	protected override bool DILENIHJFPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5DF52B0", Offset = "0x5DF3EB0", VA = "0x185DF52B0", Slot = "5")]
	public override bool PHNOOBFLIAN(PBLGDIDDGJE HKPDNKBBCGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KCADCFOPNGB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OBMGGGNNEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong JGCAMJCOPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double LDFMDHNNOCO;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FEMFKEKBFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int BFCHCGLEEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float PLMHFGAGLGG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5A40", Offset = "0x5DE4640", VA = "0x185DE5A40")]
	private static void CHJFMKFLJMN(byte[] EBPAODHLEDO, int JEHLDDEOFLK, ulong JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1730", Offset = "0x5DF0330", VA = "0x185DF1730")]
	private static void CHJFMKFLJMN(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17A0", Offset = "0x5DF03A0", VA = "0x185DF17A0")]
	public static void CHJFMKFLJMN(byte[] EBPAODHLEDO, int JEHLDDEOFLK, short JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17F0", Offset = "0x5DF03F0", VA = "0x185DF17F0")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, double IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1810", Offset = "0x5DF0410", VA = "0x185DF1810")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17A0", Offset = "0x5DF03A0", VA = "0x185DF17A0")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, short IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17A0", Offset = "0x5DF03A0", VA = "0x185DF17A0")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, ushort IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1730", Offset = "0x5DF0330", VA = "0x185DF1730")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1730", Offset = "0x5DF0330", VA = "0x185DF1730")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, uint IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17E0", Offset = "0x5DF03E0", VA = "0x185DF17E0")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, long IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17E0", Offset = "0x5DF03E0", VA = "0x185DF17E0")]
	public static void NPJGKAPFKIA(byte[] GABEBEKDBIP, int IPBPNCHALEF, ulong IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KENAAEANNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] LIOJMKFGCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int OALLMFOOPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int CFOADIMALCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int OLIBCIFPPJL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] OIKJIBKAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int FMBGCJCIGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GENGCFGBCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DF22D0", Offset = "0x5DF0ED0", VA = "0x185DF22D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EJPCKEJMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1ED7DA0", Offset = "0x1ED69A0", VA = "0x181ED7DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GFDKIHJCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1DE0", Offset = "0x5DF09E0", VA = "0x185DF1DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1E60", Offset = "0x5DF0A60", VA = "0x185DF1E60")]
	public void JEILPOMBDNE(byte[] LNMFGKOJMJG, int JEHLDDEOFLK, int KFMODJMPJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KENAAEANNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2480", Offset = "0x5DF1080", VA = "0x185DF2480")]
	public KENAAEANNFC(byte[] LNMFGKOJMJG, int JEHLDDEOFLK, int KFMODJMPJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1EA0", Offset = "0x5DF0AA0", VA = "0x185DF1EA0")]
	public IPEndPoint JHJMAIAIPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B80", Offset = "0x5DF0780", VA = "0x185DF1B80")]
	public byte IIJIDJFLANH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B80", Offset = "0x5DF0780", VA = "0x185DF1B80")]
	public sbyte EAEIIPHLLNI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE980", Offset = "0x2BED580", VA = "0x182BEE980")]
	public T[] CKIAHENEBFF<T>(ushort INGCLKPLIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1CB0", Offset = "0x5DF08B0", VA = "0x185DF1CB0")]
	public bool[] GCEKLEBMHNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1C70", Offset = "0x5DF0870", VA = "0x185DF1C70")]
	public ushort[] FCJGKNPLHHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1BC0", Offset = "0x5DF07C0", VA = "0x185DF1BC0")]
	public short[] EAFNLKDBMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1890", Offset = "0x5DF0490", VA = "0x185DF1890")]
	public int[] ACGBCIHBKNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A60", Offset = "0x5DF0660", VA = "0x185DF1A60")]
	public uint[] BMOBJENIJEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DF22E0", Offset = "0x5DF0EE0", VA = "0x185DF22E0")]
	public float[] LJNPPNNEMAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DF18F0", Offset = "0x5DF04F0", VA = "0x185DF18F0")]
	public double[] AGALHMJNFEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D30", Offset = "0x5DF0930", VA = "0x185DF1D30")]
	public long[] HBOONFJDMHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2360", Offset = "0x5DF0F60", VA = "0x185DF2360")]
	public ulong[] NIGKFPJNBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1930", Offset = "0x5DF0530", VA = "0x185DF1930")]
	public string[] ANGKOJBBJCA(int LDICLKJAGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1CF0", Offset = "0x5DF08F0", VA = "0x185DF1CF0")]
	public bool HAFFGMJLJHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D70", Offset = "0x5DF0970", VA = "0x185DF1D70")]
	public char HCPPFNGJACA()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D70", Offset = "0x5DF0970", VA = "0x185DF1D70")]
	public ushort KBENIEOFAOF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2410", Offset = "0x5DF1010", VA = "0x185DF2410")]
	public short PBFJLJBFFJN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1DF0", Offset = "0x5DF09F0", VA = "0x185DF1DF0")]
	public long IGDGCCNBPNG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1C00", Offset = "0x5DF0800", VA = "0x185DF1C00")]
	public ulong EGJCELFPGMB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2260", Offset = "0x5DF0E60", VA = "0x185DF2260")]
	public int LAJLGAFCPHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1AA0", Offset = "0x5DF06A0", VA = "0x185DF1AA0")]
	public uint CMHPJHILFGE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B10", Offset = "0x5DF0710", VA = "0x185DF1B10")]
	public float DIJEEIGOEIG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF23A0", Offset = "0x5DF0FA0", VA = "0x185DF23A0")]
	public double NNGMCOJPAGH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1FE0", Offset = "0x5DF0BE0", VA = "0x185DF1FE0")]
	public string JNBJCJAKELJ(int IJGENGGMLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F70", Offset = "0x5DF0B70", VA = "0x185DF1F70")]
	public ArraySegment<byte> JMGIBFHEMHJ(int LLHINFJPPOH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2220", Offset = "0x5DF0E20", VA = "0x185DF2220")]
	public sbyte[] KALPGMAEBFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2320", Offset = "0x5DF0F20", VA = "0x185DF2320")]
	public byte[] LNMBJLJIPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DF18D0", Offset = "0x5DF04D0", VA = "0x185DF18D0")]
	public void AFPCPCPKMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DLNEILKCFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] LIOJMKFGCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int OALLMFOOPAM;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int JGCCNJDIDFC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool FPJCNBJDPNP;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding BCCHFLAEHCI;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int LKJMLHHOPFM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] NCAEHKLLGGO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] COKNLHIJAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF460", Offset = "0x5DEE060", VA = "0x185DEF460")]
	public DLNEILKCFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF4E0", Offset = "0x5DEE0E0", VA = "0x185DEF4E0")]
	public DLNEILKCFGG(bool ONANEGOIJBI, int CDAFLBMNCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF360", Offset = "0x5DEDF60", VA = "0x185DEF360")]
	public static DLNEILKCFGG NEGMFGLKDFD(string IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEC60", Offset = "0x5DED860", VA = "0x185DEEC60")]
	public void LKNBAOMHKID(int FJFOOKJDMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F51F20", Offset = "0x1F50B20", VA = "0x181F51F20")]
	public void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF1E0", Offset = "0x5DEDDE0", VA = "0x185DEF1E0")]
	public void MAJCFOCKPCD(float IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF140", Offset = "0x5DEDD40", VA = "0x185DEF140")]
	public void MAJCFOCKPCD(double IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF190", Offset = "0x5DEDD90", VA = "0x185DEF190")]
	public void MAJCFOCKPCD(long IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF190", Offset = "0x5DEDD90", VA = "0x185DEF190")]
	public void MAJCFOCKPCD(ulong IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5DEED00", Offset = "0x5DED900", VA = "0x185DEED00")]
	public void MAJCFOCKPCD(int IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DEED00", Offset = "0x5DED900", VA = "0x185DEED00")]
	public void MAJCFOCKPCD(uint IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFA0", Offset = "0x5DEDBA0", VA = "0x185DEEFA0")]
	public void MAJCFOCKPCD(char IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFA0", Offset = "0x5DEDBA0", VA = "0x185DEEFA0")]
	public void MAJCFOCKPCD(ushort IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFA0", Offset = "0x5DEDBA0", VA = "0x185DEEFA0")]
	public void MAJCFOCKPCD(short IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF0E0", Offset = "0x5DEDCE0", VA = "0x185DEF0E0")]
	public void MAJCFOCKPCD(sbyte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF0E0", Offset = "0x5DEDCE0", VA = "0x185DEF0E0")]
	public void MAJCFOCKPCD(byte IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF010", Offset = "0x5DEDC10", VA = "0x185DEF010")]
	public void MAJCFOCKPCD(byte[] JGFKFMMOAJO, int JEHLDDEOFLK, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE730", Offset = "0x5DED330", VA = "0x185DEE730")]
	public void GPJHLGAGMPJ(sbyte[] JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE730", Offset = "0x5DED330", VA = "0x185DEE730")]
	public void CACKOILLNMM(byte[] JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF080", Offset = "0x5DEDC80", VA = "0x185DEF080")]
	public void MAJCFOCKPCD(bool IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEAB0", Offset = "0x5DED6B0", VA = "0x185DEEAB0")]
	public void HDHDCINOFDC(Array EEOPKPJBOEH, int FOMDDHMHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE810", Offset = "0x5DED410", VA = "0x185DEE810")]
	public void HDHDCINOFDC(float[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE8F0", Offset = "0x5DED4F0", VA = "0x185DEE8F0")]
	public void HDHDCINOFDC(double[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE8F0", Offset = "0x5DED4F0", VA = "0x185DEE8F0")]
	public void HDHDCINOFDC(long[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE8F0", Offset = "0x5DED4F0", VA = "0x185DEE8F0")]
	public void HDHDCINOFDC(ulong[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE810", Offset = "0x5DED410", VA = "0x185DEE810")]
	public void HDHDCINOFDC(int[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE810", Offset = "0x5DED410", VA = "0x185DEE810")]
	public void HDHDCINOFDC(uint[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE9D0", Offset = "0x5DED5D0", VA = "0x185DEE9D0")]
	public void HDHDCINOFDC(ushort[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE9D0", Offset = "0x5DED5D0", VA = "0x185DEE9D0")]
	public void HDHDCINOFDC(short[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE730", Offset = "0x5DED330", VA = "0x185DEE730")]
	public void HDHDCINOFDC(bool[] IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEB90", Offset = "0x5DED790", VA = "0x185DEEB90")]
	public void HDHDCINOFDC(string[] IIPLJLPCLBC, int AIHHIOLHAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF280", Offset = "0x5DEDE80", VA = "0x185DEF280")]
	public void MAJCFOCKPCD(IPEndPoint FAEJLEDMPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF350", Offset = "0x5DEDF50", VA = "0x185DEF350")]
	public void MAJCFOCKPCD(string IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DEED90", Offset = "0x5DED990", VA = "0x185DEED90")]
	public void MAJCFOCKPCD(string IIPLJLPCLBC, int IJGENGGMLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PLAIPKJEALF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class NBPHPJEPGDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong ALHLDKPOGOP;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x44DC900", Offset = "0x44DB500", VA = "0x1844DC900")]
		static NBPHPJEPGDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void IALBGBPBGPN(KENAAEANNFC KLAPEMMBNLL, object LJJFNBLNDJA);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CIFBMPAMKMA<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PLAIPKJEALF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CIFBMPAMKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x55887C0", Offset = "0x55873C0", VA = "0x1855887C0")]
		internal void PDBGPPEIPKN(KENAAEANNFC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JGCDGOCABGG<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public PLAIPKJEALF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JGCDGOCABGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40900B0", Offset = "0x408ECB0", VA = "0x1840900B0")]
		internal void PDBGPPEIPKN(KENAAEANNFC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly IJJIFADADLN AFLEBIIAMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, IALBGBPBGPN> GMJICJPODLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly DLNEILKCFGG JJPOAPPFGMC;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC7C0", Offset = "0x5DFB3C0", VA = "0x185DFC7C0")]
	public PLAIPKJEALF(int LDICLKJAGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x28F19D0", Offset = "0x28F05D0", VA = "0x1828F19D0", Slot = "4")]
	protected virtual ulong KGOBMAMCKGM<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC690", Offset = "0x5DFB290", VA = "0x185DFC690", Slot = "5")]
	protected virtual IALBGBPBGPN ONIGNIGECCD(KENAAEANNFC KLAPEMMBNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7A40", Offset = "0x2CE6640", VA = "0x182CE7A40", Slot = "6")]
	protected virtual void BFPDHDLBDHK<T>(DLNEILKCFGG PNCAPBLIAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC5C0", Offset = "0x5DFB1C0", VA = "0x185DFC5C0")]
	public void EFHPOPFEDMO(KENAAEANNFC KLAPEMMBNLL, object LJJFNBLNDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7AB0", Offset = "0x2CE66B0", VA = "0x182CE7AB0")]
	public void FMNMLKOLAAI<T>(DLNEILKCFGG PNCAPBLIAKM, T HKPDNKBBCGJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC640", Offset = "0x5DFB240", VA = "0x185DFC640")]
	public void HGDDPCBBFIN(KENAAEANNFC KLAPEMMBNLL, object LJJFNBLNDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D20", Offset = "0x2CE6920", VA = "0x182CE7D20")]
	public void JKCJCILGMDJ<T>(Action<T> HFABAKACKAI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7B60", Offset = "0x2CE6760", VA = "0x182CE7B60")]
	public void JKCJCILGMDJ<T, TUserData>(Action<T, TUserData> HFABAKACKAI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DLIIAFJPHJM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE61A0", VA = "0x185DE75A0")]
	public DLIIAFJPHJM(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CLHPOMDMHOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE6D0", Offset = "0x5DED2D0", VA = "0x185DEE6D0")]
	public CLHPOMDMHOD(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class IJJIFADADLN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum PLCCHJELBCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class EAGDEEDFPJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public PLCCHJELBCN DOJGHAOJFFO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3822940", Offset = "0x3821540", VA = "0x183822940", Slot = "4")]
		public virtual void KCBMKHLALEF(MethodInfo MLLNHAIIIHM, MethodInfo KNFGKIKKKIO, PLCCHJELBCN HGPIKDLKBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IDABKBOEDFG(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ODLNGAEEFOO(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		protected EAGDEEDFPJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GKEJPFMHHID<TClass, TProperty> : EAGDEEDFPJK<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> LIPCLCJDOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> BPFDAIPHEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> MFKFHCILBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> HMGHCHHEFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> BGDHIGFCEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> OEBFFIBIMFI;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F910", Offset = "0x3D4E510", VA = "0x183D4F910", Slot = "7")]
		public override void GLCIAMPLLHB(TClass BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E870", Offset = "0x3D4D470", VA = "0x183D4E870", Slot = "8")]
		public override void EKDBEALPEBB(TClass BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4FC30", Offset = "0x3D4E830", VA = "0x183D4FC30", Slot = "9")]
		public override void IDABKBOEDFG(TClass BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3D557B0", Offset = "0x3D543B0", VA = "0x183D557B0", Slot = "10")]
		public override void ODLNGAEEFOO(TClass BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D55320", Offset = "0x3D53F20", VA = "0x183D55320")]
		protected TProperty[] NJILGLGDFBD(TClass BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4FBB0", Offset = "0x3D4E7B0", VA = "0x183D4FBB0")]
		protected TProperty[] HKJOPIPDKHE(TClass BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3D51ED0", Offset = "0x3D50AD0", VA = "0x183D51ED0", Slot = "4")]
		public override void KCBMKHLALEF(MethodInfo MLLNHAIIIHM, MethodInfo KNFGKIKKKIO, PLCCHJELBCN HGPIKDLKBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D55F90", Offset = "0x3D54B90", VA = "0x183D55F90")]
		protected GKEJPFMHHID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DEHDELGLKCH<TClass, TProperty> : GKEJPFMHHID<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void BJNNNBKNIMP(KENAAEANNFC GKPLDDEPNGI, [Out] TProperty NBGPBPLKMIE);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void EJCHGCNOLHK(DLNEILKCFGG PHAJGFLHIGP, TProperty NBGPBPLKMIE);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5891790", Offset = "0x5890390", VA = "0x185891790", Slot = "5")]
		public override void MHDEAGHKGFJ(TClass BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5891450", Offset = "0x5890050", VA = "0x185891450", Slot = "6")]
		public override void FMNMLKOLAAI(TClass BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5891570", Offset = "0x5890170", VA = "0x185891570", Slot = "7")]
		public override void GLCIAMPLLHB(TClass BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5891390", Offset = "0x588FF90", VA = "0x185891390", Slot = "8")]
		public override void EKDBEALPEBB(TClass BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2080", Offset = "0x3ED0C80", VA = "0x183ED2080")]
		protected DEHDELGLKCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EIEPDHLENKO<T> : GKEJPFMHHID<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3848120", Offset = "0x3846D20", VA = "0x183848120", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3848030", Offset = "0x3846C30", VA = "0x183848030", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x38480A0", Offset = "0x3846CA0", VA = "0x1838480A0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3847FC0", Offset = "0x3846BC0", VA = "0x183847FC0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public EIEPDHLENKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class GJEJFHJMGJH<T> : GKEJPFMHHID<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DCA0", Offset = "0x3D4C8A0", VA = "0x183D4DCA0", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3848030", Offset = "0x3846C30", VA = "0x183848030", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DC20", Offset = "0x3D4C820", VA = "0x183D4DC20", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3847FC0", Offset = "0x3846BC0", VA = "0x183847FC0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public GJEJFHJMGJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KKJLMCONBKD<T> : GKEJPFMHHID<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x41B6A60", Offset = "0x41B5660", VA = "0x1841B6A60", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3D565C0", Offset = "0x3D551C0", VA = "0x183D565C0", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x41B69E0", Offset = "0x41B55E0", VA = "0x1841B69E0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3D56550", Offset = "0x3D55150", VA = "0x183D56550", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public KKJLMCONBKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class GKGCJKJDJGM<T> : GKEJPFMHHID<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3D566B0", Offset = "0x3D552B0", VA = "0x183D566B0", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3D565C0", Offset = "0x3D551C0", VA = "0x183D565C0", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D56630", Offset = "0x3D55230", VA = "0x183D56630", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3D56550", Offset = "0x3D55150", VA = "0x183D56550", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public GKGCJKJDJGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class AICHGFPFDLC<T> : GKEJPFMHHID<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D14320", Offset = "0x3D12F20", VA = "0x183D14320", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFE40", Offset = "0x3CEEA40", VA = "0x183CEFE40", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D142A0", Offset = "0x3D12EA0", VA = "0x183D142A0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x384B1F0", Offset = "0x3849DF0", VA = "0x18384B1F0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public AICHGFPFDLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class AFMDMPLAEAE<T> : GKEJPFMHHID<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFF30", Offset = "0x3CEEB30", VA = "0x183CEFF30", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFE40", Offset = "0x3CEEA40", VA = "0x183CEFE40", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFEB0", Offset = "0x3CEEAB0", VA = "0x183CEFEB0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x384B1F0", Offset = "0x3849DF0", VA = "0x18384B1F0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public AFMDMPLAEAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AEAAHFIHADL<T> : GKEJPFMHHID<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA880", Offset = "0x3CE9480", VA = "0x183CEA880", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA790", Offset = "0x3CE9390", VA = "0x183CEA790", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA800", Offset = "0x3CE9400", VA = "0x183CEA800", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA720", Offset = "0x3CE9320", VA = "0x183CEA720", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public AEAAHFIHADL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class GKKNOHEAIPC<T> : GKEJPFMHHID<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA880", Offset = "0x3CE9480", VA = "0x183CEA880", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA790", Offset = "0x3CE9390", VA = "0x183CEA790", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D569C0", Offset = "0x3D555C0", VA = "0x183D569C0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA720", Offset = "0x3CE9320", VA = "0x183CEA720", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public GKKNOHEAIPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class NLFHFNIFECE<T> : GKEJPFMHHID<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x452B790", Offset = "0x452A390", VA = "0x18452B790", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x452B6A0", Offset = "0x452A2A0", VA = "0x18452B6A0", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x452B710", Offset = "0x452A310", VA = "0x18452B710", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3847FC0", Offset = "0x3846BC0", VA = "0x183847FC0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public NLFHFNIFECE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class EJMALADKEPN<T> : GKEJPFMHHID<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x384B350", Offset = "0x3849F50", VA = "0x18384B350", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x384B260", Offset = "0x3849E60", VA = "0x18384B260", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x384B2D0", Offset = "0x3849ED0", VA = "0x18384B2D0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x384B1F0", Offset = "0x3849DF0", VA = "0x18384B1F0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public EJMALADKEPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MFJLCPENKOE<T> : GKEJPFMHHID<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4489390", Offset = "0x4487F90", VA = "0x184489390", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x44892A0", Offset = "0x4487EA0", VA = "0x1844892A0", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4489310", Offset = "0x4487F10", VA = "0x184489310", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA720", Offset = "0x3CE9320", VA = "0x183CEA720", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x38481A0", Offset = "0x3846DA0", VA = "0x1838481A0")]
		public MFJLCPENKOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HOCLJHBLPJJ<T> : DEHDELGLKCH<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA020", Offset = "0x3DE8C20", VA = "0x183DEA020", Slot = "12")]
		protected override void EJCHGCNOLHK(DLNEILKCFGG PHAJGFLHIGP, char NBGPBPLKMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9FF0", Offset = "0x3DE8BF0", VA = "0x183DE9FF0", Slot = "11")]
		protected override void BJNNNBKNIMP(KENAAEANNFC GKPLDDEPNGI, [Out] char NBGPBPLKMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x384AB60", Offset = "0x3849760", VA = "0x18384AB60")]
		public HOCLJHBLPJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JJMPOJDOIHO<T> : DEHDELGLKCH<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x40C7C30", Offset = "0x40C6830", VA = "0x1840C7C30", Slot = "12")]
		protected override void EJCHGCNOLHK(DLNEILKCFGG PHAJGFLHIGP, IPEndPoint NBGPBPLKMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x40C7BF0", Offset = "0x40C67F0", VA = "0x1840C7BF0", Slot = "11")]
		protected override void BJNNNBKNIMP(KENAAEANNFC GKPLDDEPNGI, [Out] IPEndPoint NBGPBPLKMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x384AB60", Offset = "0x3849760", VA = "0x18384AB60")]
		public JJMPOJDOIHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class ABGPEEIFMHM<T> : GKEJPFMHHID<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int NBEIAKMGEPP;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3CE57A0", Offset = "0x3CE43A0", VA = "0x183CE57A0")]
		public ABGPEEIFMHM(int IJGENGGMLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5720", Offset = "0x3CE4320", VA = "0x183CE5720", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5620", Offset = "0x3CE4220", VA = "0x183CE5620", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE56A0", Offset = "0x3CE42A0", VA = "0x183CE56A0", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CE55A0", Offset = "0x3CE41A0", VA = "0x183CE55A0", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GIHFHCNNOHH<T> : EAGDEEDFPJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo GLGENIGAEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type GEPKCONAFPO;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DB20", Offset = "0x3D4C720", VA = "0x183D4DB20")]
		public GIHFHCNNOHH(PropertyInfo LPPIGHILDBI, Type EIFCIABEDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DA00", Offset = "0x3D4C600", VA = "0x183D4DA00", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D890", Offset = "0x3D4C490", VA = "0x183D4D890", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D940", Offset = "0x3D4C540", VA = "0x183D4D940", Slot = "7")]
		public override void GLCIAMPLLHB(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D830", Offset = "0x3D4C430", VA = "0x183D4D830", Slot = "8")]
		public override void EKDBEALPEBB(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D9A0", Offset = "0x3D4C5A0", VA = "0x183D4D9A0", Slot = "9")]
		public override void IDABKBOEDFG(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DAC0", Offset = "0x3D4C6C0", VA = "0x183D4DAC0", Slot = "10")]
		public override void ODLNGAEEFOO(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BCINNHCADOI<T> : GIHFHCNNOHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
		public BCINNHCADOI(PropertyInfo LPPIGHILDBI, Type EIFCIABEDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E65320", Offset = "0x4E63F20", VA = "0x184E65320", Slot = "5")]
		public override void MHDEAGHKGFJ(T BHOJAIHNBBP, KENAAEANNFC GKPLDDEPNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4E65270", Offset = "0x4E63E70", VA = "0x184E65270", Slot = "6")]
		public override void FMNMLKOLAAI(T BHOJAIHNBBP, DLNEILKCFGG PHAJGFLHIGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NDJELCPONJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static NDJELCPONJM<T> NKKNEDDGFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly EAGDEEDFPJK<T>[] JLGCOOFOJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int ADDMJFELALC;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x44E0F10", Offset = "0x44DFB10", VA = "0x1844E0F10")]
		public NDJELCPONJM(List<EAGDEEDFPJK<T>> FDMHFHEMCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x44E0DB0", Offset = "0x44DF9B0", VA = "0x1844E0DB0")]
		public void FMNMLKOLAAI(T APKAFMDACKK, DLNEILKCFGG PNCAPBLIAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x44E0E60", Offset = "0x44DFA60", VA = "0x1844E0E60")]
		public void MHDEAGHKGFJ(T APKAFMDACKK, KENAAEANNFC KLAPEMMBNLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class FHLKDMEBBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract EAGDEEDFPJK<T> OIPGNBHOLEB<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private DLNEILKCFGG JNNFODOEMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int KIEBLKFPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, FHLKDMEBBDG> NBMNODONAAI;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0D20", Offset = "0x5DEF920", VA = "0x185DF0D20")]
	public IJJIFADADLN(int LDICLKJAGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A3A0", Offset = "0x2B78FA0", VA = "0x182B7A3A0")]
	private NDJELCPONJM<T> IEINOHMJJIL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x29E12A0", Offset = "0x29DFEA0", VA = "0x1829E12A0")]
	public void NGMFPPEDCJG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A300", Offset = "0x2B78F00", VA = "0x182B7A300")]
	public bool GCPIDJEBGBI<T>(KENAAEANNFC KLAPEMMBNLL, T EEOLDJILHGA) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A270", Offset = "0x2B78E70", VA = "0x182B7A270")]
	public void CJJBNJOFCID<T>(DLNEILKCFGG PNCAPBLIAKM, T APKAFMDACKK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BDKMLJIAEMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime CIFBNPDEANM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] OGDFFAONEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BBHKLJGFGDE MJPEHPEGAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6560", Offset = "0x5DE5160", VA = "0x185DE6560")]
		get
		{
			return default(BBHKLJGFGDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BAKNGFNCHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5FE0", Offset = "0x5DE4BE0", VA = "0x185DE5FE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6590", Offset = "0x5DE5190", VA = "0x185DE6590")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LPGMCNHKPPK LJNIKPKCBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE66D0", Offset = "0x5DE52D0", VA = "0x185DE66D0")]
		get
		{
			return default(LPGMCNHKPPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6CD0", Offset = "0x5DE58D0", VA = "0x185DE6CD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BHAOGIJEFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE65D0", Offset = "0x5DE51D0", VA = "0x185DE65D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint ALCDHGAMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6C50", Offset = "0x5DE5850", VA = "0x185DE6C50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? MCJLIFBMPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6210", Offset = "0x5DE4E10", VA = "0x185DE6210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KBNCDIIDJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6530", Offset = "0x5DE5130", VA = "0x185DE6530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? IGOKIKODLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6AD0", Offset = "0x5DE56D0", VA = "0x185DE6AD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6240", Offset = "0x5DE4E40", VA = "0x185DE6240")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? FEBKBPJAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC487C0", Offset = "0xC473C0", VA = "0x180C487C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA93E70", Offset = "0xA92A70", VA = "0x180A93E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6FF0", Offset = "0x5DE5BF0", VA = "0x185DE6FF0")]
	public BDKMLJIAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6F40", Offset = "0x5DE5B40", VA = "0x185DE6F40")]
	internal BDKMLJIAEMJ(byte[] GABEBEKDBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6410", Offset = "0x5DE5010", VA = "0x185DE6410")]
	public static BDKMLJIAEMJ GDJDIJGPGLM(byte[] GABEBEKDBIP, DateTime LOJGKOPIFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6010", Offset = "0x5DE4C10", VA = "0x185DE6010")]
	internal void AHPIMFOJHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6900", Offset = "0x5DE5500", VA = "0x185DE6900")]
	private void KMBLPJFKCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6700", Offset = "0x5DE5300", VA = "0x185DE6700")]
	private DateTime? KJIMFKAMFPO(int JEHLDDEOFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6D10", Offset = "0x5DE5910", VA = "0x185DE6D10")]
	private void PKJNGMFNLFL(int JEHLDDEOFLK, DateTime? IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6600", Offset = "0x5DE5200", VA = "0x185DE6600")]
	private ulong JFLLEOBODHB(int JEHLDDEOFLK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6B00", Offset = "0x5DE5700", VA = "0x185DE6B00")]
	private void MEODEAJDBPM(int JEHLDDEOFLK, ulong IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6BC0", Offset = "0x5DE57C0", VA = "0x185DE6BC0")]
	private uint NIEEIFAEBOE(int JEHLDDEOFLK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB530", Offset = "0x5CBA130", VA = "0x185CBB530")]
	private static uint AAHNPOENIHG(uint KIGIELEFAKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5F80", Offset = "0x5DE4B80", VA = "0x185DE5F80")]
	private static ulong AAHNPOENIHG(ulong KIGIELEFAKI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BBHKLJGFGDE
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
public enum LPGMCNHKPPK
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HEGBCHAPNFG
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int OIKMPANCKPK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int KBACHNNBMGE = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int LNCFJHJJMDE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint GGNMNIDPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int MBKLGAIADGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int LEKNAJKOJIO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PONMNADPLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF0C20", Offset = "0x5DEF820", VA = "0x185DF0C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0C30", Offset = "0x5DEF830", VA = "0x185DF0C30")]
	public bool PKGOHKCFCEC(AAGFFAMHKAB BFGOPJAIDBD, int GHOMDKPGIGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class LOMNCDKNLIA : AAGFFAMHKAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket BFGOPJAIDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly CIJNMCMKNBG IGOBJJICIOE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short EPIIMDLLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3430", Offset = "0x5DF2030", VA = "0x185DF3430", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int CHMHCDJAMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2E50", Offset = "0x5DF1A50", VA = "0x185DF2E50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint ICNJDENOGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DF34B0", Offset = "0x5DF20B0", VA = "0x185DF34B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily DIKHIBPEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x42334D0", Offset = "0x42320D0", VA = "0x1842334D0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF35C0", Offset = "0x5DF21C0", VA = "0x185DF35C0")]
	public LOMNCDKNLIA(AddressFamily ICNCLGLMBEN, CIJNMCMKNBG IGOBJJICIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2E70", Offset = "0x5DF1A70", VA = "0x185DF2E70", Slot = "8")]
	public bool ALENKPIDPNA(IPEndPoint FAEJLEDMPLE, JCKKHAMLNNJ LNGPIDCCCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3470", Offset = "0x5DF2070", VA = "0x185DF3470", Slot = "9")]
	public int FJPJJADIHCA(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int INGCLKPLIOP, IPEndPoint CIPACILOHCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF34D0", Offset = "0x5DF20D0", VA = "0x185DF34D0", Slot = "10")]
	public int HAMGMNABIBF(byte[] EBPAODHLEDO, EndPoint DJJDPFAKDPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3450", Offset = "0x5DF2050", VA = "0x185DF3450", Slot = "11")]
	public void DMPPIGLEJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface AAGFFAMHKAB
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short EPIIMDLLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int CHMHCDJAMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint ICNJDENOGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily DIKHIBPEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ALENKPIDPNA(IPEndPoint FAEJLEDMPLE, JCKKHAMLNNJ LNGPIDCCCJA);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FJPJJADIHCA(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int INGCLKPLIOP, IPEndPoint CIPACILOHCP);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HAMGMNABIBF(byte[] EBPAODHLEDO, EndPoint CIPACILOHCP);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMPPIGLEJDL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct FPGGOOMBPJN : IEquatable<FPGGOOMBPJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long DBNAGBGMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long CJIJLPJKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long GONPKFHICCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int AAEJJBEHOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int DNMJCBBJIHL;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0660", Offset = "0x5DEF260", VA = "0x185DF0660")]
	public FPGGOOMBPJN(byte[] OCLHDMKBGBG, int DCDAPNMJCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x88E1E0", Offset = "0x88CDE0", VA = "0x18088E1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0620", Offset = "0x5DEF220", VA = "0x185DF0620", Slot = "4")]
	public bool Equals(FPGGOOMBPJN HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0570", Offset = "0x5DEF170", VA = "0x185DF0570", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AGAMLNJCOJL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] HNEINBIOILF;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BNEFNHMDDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int AKDNIDACIDF;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
	protected BNEFNHMDDMN(int EEKBILFMDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GLHBFOEEALC(IPEndPoint FAEJLEDMPLE, byte[] JGFKFMMOAJO, int JEHLDDEOFLK, int AEGGIAICNFC);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void BLNEAHHCCJM(IPEndPoint FAEJLEDMPLE, byte[] JGFKFMMOAJO, int JEHLDDEOFLK, int AEGGIAICNFC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EEGHCBHLHGI : BNEFNHMDDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private byte[] NCMHANGAILD;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator BHLNFGIGMJI;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1480", Offset = "0x1FF0080", VA = "0x181FF1480")]
	public EEGHCBHLHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFBD0", Offset = "0x5DEE7D0", VA = "0x185DEFBD0")]
	public void DNKAIDINKPP(IPEndPoint FAEJLEDMPLE, byte[] NCMHANGAILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0270", Offset = "0x5DEEE70", VA = "0x185DF0270")]
	public void PIBGDFENCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD80", Offset = "0x5DEE980", VA = "0x185DEFD80", Slot = "4")]
	public override void GLHBFOEEALC(IPEndPoint FAEJLEDMPLE, byte[] JGFKFMMOAJO, int JEHLDDEOFLK, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF860", Offset = "0x5DEE460", VA = "0x185DEF860", Slot = "5")]
	public override void BLNEAHHCCJM(IPEndPoint FAEJLEDMPLE, byte[] JGFKFMMOAJO, int JEHLDDEOFLK, int AEGGIAICNFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct LEJEEJHDNJN
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void EALJBGNFGMF([NoAlias] byte* LBILKFEEJBC, [NoAlias] byte* NCMHANGAILD, [NoAlias] byte* POMJMGOPKML, int AEGGIAICNFC);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KEEMPICCJGL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static IntPtr JBGMOOMNIEP;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static IntPtr AFBHENNGDKD;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCA40", Offset = "0x5DFB640", VA = "0x185DFCA40")]
		[BurstDiscard]
		private static void BNNMBKBAGDF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCE60", Offset = "0x5DFBA60", VA = "0x185DFCE60")]
		private static IntPtr IFGFBHDOBGD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCB70", Offset = "0x5DFB770", VA = "0x185DFCB70")]
		public static void FHFKIAGEPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
		public static void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCC20", Offset = "0x5DFB820", VA = "0x185DFCC20")]
		public unsafe static void HEONFGBJNMF([NoAlias] byte* LBILKFEEJBC, [NoAlias] byte* NCMHANGAILD, [NoAlias] byte* POMJMGOPKML, int AEGGIAICNFC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private unsafe fixed uint NCMHANGAILD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private unsafe fixed uint POMJMGOPKML[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private unsafe fixed uint CNOCHHDLNEI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private unsafe fixed uint DIKMFJCKAJK[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private unsafe fixed uint AKHNNOMDGNJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint BAOLDMNKNNA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint DPNBLHGEMAF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private uint ODEOCHPIPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint GPEEPFKJJKI[8];

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2CA0", Offset = "0x5DF18A0", VA = "0x185DF2CA0")]
	private void LEJCELDJPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D20", Offset = "0x5DF1920", VA = "0x185DF2D20")]
	private uint OLJADECNHFF(uint CCBJGKKCAKF, int DJMPINLBHFM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5B30", Offset = "0x5DE4730", VA = "0x185DE5B30")]
	private void CMEEJFGBLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5CE0", Offset = "0x5DE48E0", VA = "0x185DE5CE0")]
	private void FGDIKJEPNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5EF0", Offset = "0x5DE4AF0", VA = "0x185DE5EF0")]
	private void GNDBENDLJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5BE0", Offset = "0x5DE47E0", VA = "0x185DE5BE0")]
	private void EHOILFHOOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2650", Offset = "0x5DF1250", VA = "0x185DF2650")]
	private void AJCOBLEPEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF26B0", Offset = "0x5DF12B0", VA = "0x185DF26B0")]
	private unsafe void GCEMJLFGJCG(byte* LBILKFEEJBC, uint* NCMHANGAILD, uint* POMJMGOPKML, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2AD0", Offset = "0x5DF16D0", VA = "0x185DF2AD0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void GPLFJEDKNBB([NoAlias] byte* LBILKFEEJBC, [NoAlias] byte* NCMHANGAILD, [NoAlias] byte* POMJMGOPKML, int AEGGIAICNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2B50", Offset = "0x5DF1750", VA = "0x185DF2B50")]
	public static void GPLFJEDKNBB(Span<byte> LBILKFEEJBC, Span<byte> NCMHANGAILD, Span<byte> POMJMGOPKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D50", Offset = "0x5DF1950", VA = "0x185DF2D50")]
	public static void PHJGFDNEPLI(Span<byte> LBILKFEEJBC, Span<byte> NCMHANGAILD, Span<byte> POMJMGOPKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2C30", Offset = "0x5DF1830", VA = "0x185DF2C30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LCOLIBGHBIC([NoAlias] byte* LBILKFEEJBC, [NoAlias] byte* NCMHANGAILD, [NoAlias] byte* POMJMGOPKML, int AEGGIAICNFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCFC0", Offset = "0x5DFBBC0", VA = "0x185DFCFC0")]
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
