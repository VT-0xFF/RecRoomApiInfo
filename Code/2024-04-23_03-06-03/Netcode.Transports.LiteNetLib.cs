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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JAAJPNADGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DEDPLFJHBMN
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
		private NetworkManager ALDOIHBLONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, JLBCPMFLKFB> IKLBIDHHODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HHECMMHOLNJ FPLDOAKNBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] MFFONNNIPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DEDPLFJHBMN CINKBHGDKGN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong KGCMGABJDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool FJDFGOMCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x57395F0", Offset = "0x57385F0", VA = "0x1857395F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5738AF0", Offset = "0x5737AF0", VA = "0x185738AF0")]
		public void RecRoom_SetEncryptionInfo(ulong DKOOCCPCICO, byte[] OHNEPKBBADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5738AD0", Offset = "0x5737AD0", VA = "0x185738AD0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5738880", Offset = "0x5737880", VA = "0x185738880")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57394F0", Offset = "0x57384F0", VA = "0x1857394F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5738CF0", Offset = "0x5737CF0", VA = "0x185738CF0", Slot = "6")]
		public override void Send(ulong BLOMNAHFAAO, ArraySegment<byte> GPKMLHOONCL, NetworkDelivery KMJGJEJIFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5738A90", Offset = "0x5737A90", VA = "0x185738A90", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BLOMNAHFAAO, [Out] ArraySegment<byte> KKAPFENLPIM, [Out] float JCPKANGOKFK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5738FE0", Offset = "0x5737FE0", VA = "0x185738FE0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5739410", Offset = "0x5738410", VA = "0x185739410", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5737F60", Offset = "0x5736F60", VA = "0x185737F60", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BLOMNAHFAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5737E10", Offset = "0x5736E10", VA = "0x185737E10", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57382E0", Offset = "0x57372E0", VA = "0x1857382E0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BLOMNAHFAAO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5738F70", Offset = "0x5737F70", VA = "0x185738F70", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5738380", Offset = "0x5737380", VA = "0x185738380", Slot = "14")]
		public override void Initialize([Optional] NetworkManager ALDOIHBLONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5738620", Offset = "0x5737620", VA = "0x185738620")]
		private CMFIFFBKKLG NAGGCBNAFDB(NetworkDelivery KBCNAJKPHNL)
		{
			return default(CMFIFFBKKLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57389D0", Offset = "0x57379D0", VA = "0x1857389D0", Slot = "15")]
		private void PHIILHAIPLB(JLBCPMFLKFB MIBCBPLHPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5738740", Offset = "0x5737740", VA = "0x185738740", Slot = "16")]
		private void ONBBJJAFJLP(JLBCPMFLKFB MIBCBPLHPHA, DGMPNAGAODG AFKHDEACMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "17")]
		private void DPCEIDEMELC(IPEndPoint JDAACDGBFKP, SocketError AOJBOKHLOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57380D0", Offset = "0x57370D0", VA = "0x1857380D0", Slot = "18")]
		private void GCNOLOPLEEC(JLBCPMFLKFB MIBCBPLHPHA, DJKDPFKLGHG AMMJOMFBDDI, byte DAHMHMCDONI, CMFIFFBKKLG IJNEKDBEHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5738540", Offset = "0x5737540", VA = "0x185738540")]
		private void KJCIEHCPKME(int GFFAGBDKDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "19")]
		private void GIMOGIBGLDN(IPEndPoint EPNBDIJBNOB, DJKDPFKLGHG AMMJOMFBDDI, KOEODAKOAOM GIHFGIAHBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "20")]
		private void CBGFNBJEGLJ(JLBCPMFLKFB MIBCBPLHPHA, int FGOMAPNAGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5738970", Offset = "0x5737970", VA = "0x185738970", Slot = "21")]
		private void PFLDJJLLLBD(KFDHFMKMOHC MJJCOLDOFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57386F0", Offset = "0x57376F0", VA = "0x1857386F0")]
		private ulong NJHAKLAIBHG(JLBCPMFLKFB MIBCBPLHPHA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5738720", Offset = "0x5737720", VA = "0x185738720")]
		private static int NJLKNHHNHCL(float FHPCLBOOPLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5739510", Offset = "0x5738510", VA = "0x185739510")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class NJCOHANEGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly JLBCPMFLKFB IJOOEAABNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<GKBCCADNJJF> DIIGAKBNKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int GCEODJOFKLN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x573A920", Offset = "0x5739920", VA = "0x18573A920")]
	protected NJCOHANEGMH(JLBCPMFLKFB MIBCBPLHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x573A800", Offset = "0x5739800", VA = "0x18573A800")]
	public void DJNECBCMGPH(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x573A8A0", Offset = "0x57398A0", VA = "0x18573A8A0")]
	protected void OJBAILEJMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x573A860", Offset = "0x5739860", VA = "0x18573A860")]
	public bool JHDEDCGIGLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool LDGKCMPHMLN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DKPMDMNLEAN(GKBCCADNJJF IHMKCIBBNJE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum GPENJKPPECB
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
public class KFDHFMKMOHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HHECMMHOLNJ NLLGJEDOKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int ADIJPIJNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GMOMBACJCNK AGNDADMODEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint JHLBODLDNKB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GPENJKPPECB MIFKFNANLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E88A0", Offset = "0x7E78A0", VA = "0x1807E88A0")]
		[CompilerGenerated]
		get
		{
			return default(GPENJKPPECB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96EC80", Offset = "0x96DC80", VA = "0x18096EC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5737BB0", Offset = "0x5736BB0", VA = "0x185737BB0")]
	internal void EJHENGOPBEG(GMOMBACJCNK NKMMPJENDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5737C10", Offset = "0x5736C10", VA = "0x185737C10")]
	private bool ENGGKMONPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5737CA0", Offset = "0x5736CA0", VA = "0x185737CA0")]
	internal KFDHFMKMOHC(IPEndPoint EPNBDIJBNOB, GMOMBACJCNK FBAGOOHOCAN, HHECMMHOLNJ KDLHKPDFNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5737C40", Offset = "0x5736C40", VA = "0x185737C40")]
	public JLBCPMFLKFB NHOKNEBBDLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KOEODAKOAOM
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IOPGFBNCDPG
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
public struct DGMPNAGAODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IOPGFBNCDPG LGOGJGECCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BHIBHMICLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DJKDPFKLGHG INNHDMDKPBD;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JAAJPNADGGD
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLIJFDPNLCO(JLBCPMFLKFB MIBCBPLHPHA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDLJGFKLEKC(JLBCPMFLKFB MIBCBPLHPHA, DGMPNAGAODG AFKHDEACMPG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOBFGIOBDKI(IPEndPoint JDAACDGBFKP, SocketError AOJBOKHLOMF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIGNNGIFALP(JLBCPMFLKFB MIBCBPLHPHA, DJKDPFKLGHG AMMJOMFBDDI, byte DAHMHMCDONI, CMFIFFBKKLG IJNEKDBEHFJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPFKDCEAELH(IPEndPoint EPNBDIJBNOB, DJKDPFKLGHG AMMJOMFBDDI, KOEODAKOAOM GIHFGIAHBFB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEGHFNJMEII(JLBCPMFLKFB MIBCBPLHPHA, int FGOMAPNAGEG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEBADIHEGMC(KFDHFMKMOHC MJJCOLDOFAC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NOOPHOLCPIA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNOMBCIMJGG(JLBCPMFLKFB MIBCBPLHPHA, object KLJIOLNCIAP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BCGLGLANMCO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGANOODCOEC(PDFEIJCLMCB IHMKCIBBNJE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CCPMKLCGIFL
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPJLNKNEHK(JLBCPMFLKFB MIBCBPLHPHA, IPEndPoint DJEKFFMFMGK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GMOMBACJCNK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int LHCDIODDGPO = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long EIHJEDLJHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte OGKGAOODLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] BKHNCFJADPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly CJLJIEMEPBC IKNEHLGBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int MFMMMAGJOLG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x572A120", Offset = "0x5729120", VA = "0x18572A120")]
	private GMOMBACJCNK(long OGCKOGLMOFG, byte JADGEBIIANO, int OJJIOPECNPL, byte[] IBMJGKAEGCB, CJLJIEMEPBC GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x572A0C0", Offset = "0x57290C0", VA = "0x18572A0C0")]
	public static int NGNIIICABKJ(GKBCCADNJJF IHMKCIBBNJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5729CC0", Offset = "0x5728CC0", VA = "0x185729CC0")]
	public static GMOMBACJCNK JDGKELMOCDN(GKBCCADNJJF IHMKCIBBNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5729EE0", Offset = "0x5728EE0", VA = "0x185729EE0")]
	public static GKBCCADNJJF LDBCNIMHLJJ(IHBNLNFGKDN AOCGPAGJEMK, SocketAddress LJADBEGNILK, long EFMFPOOIHMO, int OJJIOPECNPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JDHHPCDEPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long EIHJEDLJHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte OGKGAOODLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int MFMMMAGJOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JOHIGGKKIOF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57334E0", Offset = "0x57324E0", VA = "0x1857334E0")]
	private JDHHPCDEPNA(long OGCKOGLMOFG, byte JADGEBIIANO, int KKLDIGCPDCE, bool KDMEHEBIMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57332A0", Offset = "0x57322A0", VA = "0x1857332A0")]
	public static JDHHPCDEPNA JDGKELMOCDN(GKBCCADNJJF IHMKCIBBNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57333F0", Offset = "0x57323F0", VA = "0x1857333F0")]
	public static GKBCCADNJJF LDBCNIMHLJJ(long EFMFPOOIHMO, byte DOOPGPLFLIF, int KNPDEJPFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57331A0", Offset = "0x57321A0", VA = "0x1857331A0")]
	public static GKBCCADNJJF FIHBLKPAKKK(JLBCPMFLKFB MIBCBPLHPHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum EFCHELFDFLO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MJOLEOKMNLG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMCGLNDAAEP(IPEndPoint DLFPFBIBOJE, IPEndPoint EPNBDIJBNOB, string KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMHOLIHJJIK(IPEndPoint ELKHEAPJOBL, EFCHELFDFLO KBCNAJKPHNL, string KONODCHOCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HLOGNOGCFEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NFBCPONPJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint DENLEKMDCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint JHLBODLDNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string NIOCJKBAALO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HLLCIOGAPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OMGFFEOMEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EFCHELFDFLO PFOKGBDCIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string NIOCJKBAALO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class DGKLJHNMFGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint PFBPHCKGDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string NIOCJKBAALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DGKLJHNMFGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class GELHKJAGBIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint PFBPHCKGDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint KAPAJCELLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NIOCJKBAALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GELHKJAGBIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class DOFBANDAMJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NIOCJKBAALO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FIKGGPIJJMC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C35C0", Offset = "0x7C25C0", VA = "0x1807C35C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DOFBANDAMJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HHECMMHOLNJ EIHEEFHPPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<NFBCPONPJGO> PMFAMFDLEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<HLLCIOGAPFC> ENENKKKOLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CJLJIEMEPBC BAPAOANGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IHBNLNFGKDN DLKLCBIPLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PKNCHKNJMCJ BOIHLGPNPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MJOLEOKMNLG DBJNONOABHI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int NGDECAJHMJI = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DGHGCBIFAFL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5731D20", Offset = "0x5730D20", VA = "0x185731D20")]
	internal HLOGNOGCFEJ(HHECMMHOLNJ HIDDFJJHELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5731A20", Offset = "0x5730A20", VA = "0x185731A20")]
	internal void OJEKCBIAEFL(IPEndPoint LJLLBHLBIFJ, GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28ED280", Offset = "0x28EC280", VA = "0x1828ED280")]
	private void JADFDOLIOJB<T>(T IHMKCIBBNJE, IPEndPoint AOHFGFEGDPB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5731730", Offset = "0x5730730", VA = "0x185731730")]
	private void BMCGLNDAAEP(DGKLJHNMFGP HIMMBGNFGNJ, IPEndPoint LJLLBHLBIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57318C0", Offset = "0x57308C0", VA = "0x1857318C0")]
	private void DBNANFGJLLK(GELHKJAGBIG HIMMBGNFGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5731B80", Offset = "0x5730B80", VA = "0x185731B80")]
	private void PFEKBAOPOKC(DOFBANDAMJO HIMMBGNFGNJ, IPEndPoint LJLLBHLBIFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CMFIFFBKKLG : byte
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
public enum NOPHOIEAIAE : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IPKDMMKLKKC
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] AINHNOPEGDO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int PDHBIEIJGLI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int IAIAMEFHJKL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KOFKCDBOKIJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5727570", Offset = "0x5726570", VA = "0x185727570")]
	public KOFKCDBOKIJ(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ADLLMGLHOEL : KOFKCDBOKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5727570", Offset = "0x5726570", VA = "0x185727570")]
	public ADLLMGLHOEL(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum GGLFDCDFPLE
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
public interface HINBILKPIML
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGEKAIHADMI(GGLFDCDFPLE FHAIKNGJHJA, string BKPGNLGJMIO, params object[] JMCMGAGCLNF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OEINFJAKNOA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static HINBILKPIML BBPDHMGDNLJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object ANCDHNELFJN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x573AA20", Offset = "0x5739A20", VA = "0x18573AA20")]
	private static void GHLEDLDIIBA(GGLFDCDFPLE OJOJBKHFKCM, string BKPGNLGJMIO, params object[] JMCMGAGCLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x573AC50", Offset = "0x5739C50", VA = "0x18573AC50")]
	internal static void KBAGBPAMNIG(string BKPGNLGJMIO, params object[] JMCMGAGCLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x573A9C0", Offset = "0x57399C0", VA = "0x18573A9C0")]
	internal static void FKPCBADAHNF(string BKPGNLGJMIO, params object[] JMCMGAGCLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x573ACB0", Offset = "0x5739CB0", VA = "0x18573ACB0")]
	internal static void NDBOCOPAAEE(string BKPGNLGJMIO, params object[] JMCMGAGCLNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HOPEPGBIHOH
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DJKDPFKLGHG : CJLJIEMEPBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private GKBCCADNJJF OBNAFHNNJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HHECMMHOLNJ AIEKOELOBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JNMHMBJDDHC CBGAGNCKKCK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57284E0", Offset = "0x57274E0", VA = "0x1857284E0")]
	internal DJKDPFKLGHG(HHECMMHOLNJ PGDDBCEFICD, JNMHMBJDDHC MHDBIKHNMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57283C0", Offset = "0x57273C0", VA = "0x1857283C0")]
	internal void AKABBPKAELO(GKBCCADNJJF IHMKCIBBNJE, int CPJBAHGBDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5728460", Offset = "0x5727460", VA = "0x185728460")]
	internal void OGIJLMMBPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5728430", Offset = "0x5727430", VA = "0x185728430")]
	public void NEHCAPJIIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JNMHMBJDDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GDMJNFMFPIG
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
	public JNMHMBJDDHC IINBOPDCMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GDMJNFMFPIG PFOKGBDCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JLBCPMFLKFB IJOOEAABNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint JHLBODLDNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object EIHHKIMHAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int LMHLGHGGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError GIDKEBMCOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IOPGFBNCDPG OGKHBMJAKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public KFDHFMKMOHC FAJCHCDOHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public CMFIFFBKKLG FCIDAJPHGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte NMHOEKKHPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly DJKDPFKLGHG AKKPONOPOGI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57375A0", Offset = "0x57365A0", VA = "0x1857375A0")]
	public JNMHMBJDDHC(HHECMMHOLNJ PGDDBCEFICD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HHECMMHOLNJ : IEnumerable<JLBCPMFLKFB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class APNBOKAHLPJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5727580", Offset = "0x5726580", VA = "0x185727580", Slot = "4")]
		public bool Equals(IPEndPoint DLGLHFDHDLB, IPEndPoint ANLBKHHFCFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5227690", Offset = "0x5226690", VA = "0x185227690", Slot = "5")]
		public int GetHashCode(IPEndPoint KDEEPMDJGFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public APNBOKAHLPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KKJODHBDPAB : IEnumerator<JLBCPMFLKFB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly JLBCPMFLKFB DEACIPCOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JLBCPMFLKFB NFGFMHPJAFC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JLBCPMFLKFB DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x90DA20", Offset = "0x90CA20", VA = "0x18090DA20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x90DA20", Offset = "0x90CA20", VA = "0x18090DA20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF87F80", Offset = "0xF86F80", VA = "0x180F87F80")]
		public KKJODHBDPAB(JLBCPMFLKFB FBGJMCPJFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5737D10", Offset = "0x5736D10", VA = "0x185737D10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5737D60", Offset = "0x5736D60", VA = "0x185737D60", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread OLPHFGCGMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool NNKFEPAMDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent BDFPKAABPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JNMHMBJDDHC> OKKMIOGBPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JNMHMBJDDHC> FCEPFKMOPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JNMHMBJDDHC LHCKDKPCFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JAAJPNADGGD KGLNBBGEFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NOOPHOLCPIA CAPHDKJOIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly BCGLGLANMCO LKLGLHNGEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CCPMKLCGIFL AMMFEFPDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, JLBCPMFLKFB> PBIPOHGKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, KFDHFMKMOHC> ILLEIKIHPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, HNIJJJHNHOE> OLLCCFMLLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JGFDGPBPFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JLBCPMFLKFB OCLGMLBIDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int MJECONIOFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<JLBCPMFLKFB> MNDLLGGFEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JLBCPMFLKFB[] CFCBELCJFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FJNPDEENIOE AKAPBOGJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int JAFBLHGKLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> BJJOCEKCEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte JCAEOKDNCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object DFECHONHKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool FBEPCHJDLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool GKEHLCBMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BDJJKIOIDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KKBIJNFPBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CDIIICJNLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ICOFPFNCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool MPOCMKFMBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool EKGAJKKELPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NKIALANMCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HDLHAIOMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int HKFIFHBGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DGHGCBIFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool JGGJCOEEOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool NLEINKDGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool OJDGPGGCPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PCBFABKBNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NMLMMCDHLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool BDJBLIGENBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly HGHAFCCEOIC KMPLKENJIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool PHHHPAHCJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HLOGNOGCFEJ NNDDHKHFAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool IHNFGCBAHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public HOPEPGBIHOH NDBOBENCMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int DNPCLIOCPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KGOHNLMDAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NPFOAMEIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OPJBIGGFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FHGCAIMGCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private GKBCCADNJJF MNBDGGDLNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int DPJLHNHKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object JKLICONAKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private GKBCCADNJJF CNJJDAMKPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KCKFNJKINIE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int NCLGODIJJNA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int IECEAKLHAHA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GPFGJLMNEEA APAILOCCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private GPFGJLMNEEA MMCHCJJMEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OKHHFLFFODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread AFIAGBGILAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint NCMPNPLCGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint GCBDIILNGDM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] DOLONIFPAHA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] HDNAPHAABIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<ADBMJPDJNBA, IPEndPoint> PFDENPMNLEP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress PEECIKIAPBA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MJHKCLIMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int PEOMCEIBGLF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PPAJOLLJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA693F0", Offset = "0xA683F0", VA = "0x180A693F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB33B10", Offset = "0xB32B10", VA = "0x180B33B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LHFFFFGPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x133A380", Offset = "0x1339380", VA = "0x18133A380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x165A290", Offset = "0x1659290", VA = "0x18165A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte DLOAAEOBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D60D0", Offset = "0x8D50D0", VA = "0x1808D60D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HEPMGIGGBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x572F660", Offset = "0x572E660", VA = "0x18572F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short MNIEJONPPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5730080", Offset = "0x572F080", VA = "0x185730080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x572EB40", Offset = "0x572DB40", VA = "0x18572EB40")]
	public void JMFCHPGAMPN(IPEndPoint JDAACDGBFKP, byte[] OHNEPKBBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x572A7D0", Offset = "0x57297D0", VA = "0x18572A7D0")]
	public void ALDLGLBCKGE(IPEndPoint JDAACDGBFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x572DF70", Offset = "0x572CF70", VA = "0x18572DF70")]
	private bool HCGBCMGMOGJ(IPEndPoint JDAACDGBFKP, [Out] JLBCPMFLKFB MIBCBPLHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x572D8E0", Offset = "0x572C8E0", VA = "0x18572D8E0")]
	private void GAABEKINDJE(JLBCPMFLKFB MIBCBPLHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x572E000", Offset = "0x572D000", VA = "0x18572E000")]
	private void HDGHDLLLFAL(JLBCPMFLKFB MIBCBPLHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x572B1B0", Offset = "0x572A1B0", VA = "0x18572B1B0")]
	private void BJIIBEBJPKC(JLBCPMFLKFB MIBCBPLHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57310E0", Offset = "0x57300E0", VA = "0x1857310E0")]
	public HHECMMHOLNJ(JAAJPNADGGD KDLHKPDFNBA, [Optional] FJNPDEENIOE KOLAKBJIHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x572A780", Offset = "0x5729780", VA = "0x18572A780")]
	internal void ABBDPFHIFPH(JLBCPMFLKFB AAJFAHMGHMH, int FGOMAPNAGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x572CBC0", Offset = "0x572BBC0", VA = "0x18572CBC0")]
	internal void EJOFABCBAPF(JLBCPMFLKFB AAJFAHMGHMH, object KLJIOLNCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x572B0E0", Offset = "0x572A0E0", VA = "0x18572B0E0")]
	internal void BFLOOAGGJHD(JLBCPMFLKFB MIBCBPLHPHA, IOPGFBNCDPG KDLIPBNGNPF, SocketError CNPMIHFGCGA, GKBCCADNJJF LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x572E050", Offset = "0x572D050", VA = "0x18572E050")]
	private void ICEENCCKFNA(JLBCPMFLKFB MIBCBPLHPHA, IOPGFBNCDPG KDLIPBNGNPF, SocketError CNPMIHFGCGA, bool CLNMAALIOEC, byte[] GPKMLHOONCL, int GGOAAGPAMNC, int MJMIIGGLEFB, GKBCCADNJJF LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x572F2A0", Offset = "0x572E2A0", VA = "0x18572F2A0")]
	private void MDJIDDHMCHN(JNMHMBJDDHC.GDMJNFMFPIG KBCNAJKPHNL, [Optional] JLBCPMFLKFB MIBCBPLHPHA, [Optional] IPEndPoint EPNBDIJBNOB, SocketError GOHOCIPCMMC = SocketError.Success, int FGOMAPNAGEG = 0, IOPGFBNCDPG OFMMCKMDEFP = IOPGFBNCDPG.ConnectionFailed, [Optional] KFDHFMKMOHC BGNMNDDKPMH, CMFIFFBKKLG IJNEKDBEHFJ = CMFIFFBKKLG.Unreliable, byte DAHMHMCDONI = 0, [Optional] GKBCCADNJJF GNIAODACNBN, [Optional] object KLJIOLNCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5730140", Offset = "0x572F140", VA = "0x185730140")]
	private void OHKMFCPHCAK(JNMHMBJDDHC MHDBIKHNMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x572DE70", Offset = "0x572CE70", VA = "0x18572DE70")]
	internal void GNOHKLLNOPP(JNMHMBJDDHC MHDBIKHNMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x572CC10", Offset = "0x572BC10", VA = "0x18572CC10")]
	private void FDLBIJIPOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x572E600", Offset = "0x572D600", VA = "0x18572E600")]
	private void JILIDAPHONG(int MHAMEDCGBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x572A920", Offset = "0x5729920", VA = "0x18572A920")]
	internal JLBCPMFLKFB AMKIAGDEDGE(KFDHFMKMOHC MJJCOLDOFAC, byte[] KJEJLJGEMOF, int GGOAAGPAMNC, int GOKGFKKLOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x572BA80", Offset = "0x572AA80", VA = "0x18572BA80")]
	private int DDILNMDOIBA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x572EE40", Offset = "0x572DE40", VA = "0x18572EE40")]
	private void MBCBMCBIJOA(IPEndPoint EPNBDIJBNOB, JLBCPMFLKFB AIAFFAOGFAG, GMOMBACJCNK DDBDJDHJABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x572BE70", Offset = "0x572AE70", VA = "0x18572BE70")]
	private void DNHOHNLLGDA(GKBCCADNJJF IHMKCIBBNJE, IPEndPoint EPNBDIJBNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5730C40", Offset = "0x572FC40", VA = "0x185730C40")]
	internal void PPEMEGADGFM(GKBCCADNJJF IHMKCIBBNJE, CMFIFFBKKLG FDOLBLEEEEH, byte DAHMHMCDONI, int CPJBAHGBDPJ, JLBCPMFLKFB AAJFAHMGHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x572F680", Offset = "0x572E680", VA = "0x18572F680")]
	public bool MLLCENNIMJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x572F710", Offset = "0x572E710", VA = "0x18572F710")]
	public bool MLLCENNIMJA(IPAddress LNKONONJNFE, IPAddress KLJAIHDDBIO, int HEABAAFBNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x572F690", Offset = "0x572E690", VA = "0x18572F690")]
	public bool MLLCENNIMJA(int HEABAAFBNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x572AF40", Offset = "0x5729F40", VA = "0x18572AF40")]
	public void ANBEIEEKEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x572B8C0", Offset = "0x572A8C0", VA = "0x18572B8C0")]
	public JLBCPMFLKFB CELJINEJEMP(string GLMBIGBGDNH, int HEABAAFBNMN, string OHNEPKBBADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x572B9A0", Offset = "0x572A9A0", VA = "0x18572B9A0")]
	public JLBCPMFLKFB CELJINEJEMP(string GLMBIGBGDNH, int HEABAAFBNMN, IHBNLNFGKDN OBBIIHBNFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x572B4F0", Offset = "0x572A4F0", VA = "0x18572B4F0")]
	public JLBCPMFLKFB CELJINEJEMP(IPEndPoint AOHFGFEGDPB, IHBNLNFGKDN OBBIIHBNFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x572E5F0", Offset = "0x572D5F0", VA = "0x18572E5F0")]
	public void IFOEKJDGKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x572E2A0", Offset = "0x572D2A0", VA = "0x18572E2A0")]
	public void IFOEKJDGKBL(bool LMNCLHBDFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x572E920", Offset = "0x572D920", VA = "0x18572E920")]
	public void JKLGMPNIEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x572EA20", Offset = "0x572DA20", VA = "0x18572EA20")]
	public void JKLGMPNIEBA(byte[] GPKMLHOONCL, int GGOAAGPAMNC, int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x572E1F0", Offset = "0x572D1F0", VA = "0x18572E1F0")]
	public void ICEENCCKFNA(JLBCPMFLKFB MIBCBPLHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x572E130", Offset = "0x572D130", VA = "0x18572E130")]
	public void ICEENCCKFNA(JLBCPMFLKFB MIBCBPLHPHA, byte[] GPKMLHOONCL, int GGOAAGPAMNC, int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5730F00", Offset = "0x572FF00", VA = "0x185730F00", Slot = "4")]
	private IEnumerator<JLBCPMFLKFB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5730F90", Offset = "0x572FF90", VA = "0x185730F90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5730B50", Offset = "0x572FB50", VA = "0x185730B50")]
	private GKBCCADNJJF PIOAHEFDLGA(DDDOFGDLFEL GFNKMDBLDFI, int GFFAGBDKDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5730A70", Offset = "0x572FA70", VA = "0x185730A70")]
	private GKBCCADNJJF PIOAHEFDLGA(DDDOFGDLFEL GFNKMDBLDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x572BB60", Offset = "0x572AB60", VA = "0x18572BB60")]
	internal GKBCCADNJJF DHDLKCIANGE(int GFFAGBDKDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x572EBE0", Offset = "0x572DBE0", VA = "0x18572EBE0")]
	internal void LNLPJEEAMMF(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5731020", Offset = "0x5730020", VA = "0x185731020")]
	static HHECMMHOLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA693F0", Offset = "0xA683F0", VA = "0x180A693F0")]
	private bool ODMLOOGJPKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x572B400", Offset = "0x572A400", VA = "0x18572B400")]
	private void BOLAMPLKHGA(IPEndPoint HABEJLMBNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x572BD90", Offset = "0x572AD90", VA = "0x18572BD90")]
	private void DLEGFOPMOFD(IPEndPoint HABEJLMBNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x572FEE0", Offset = "0x572EEE0", VA = "0x18572FEE0")]
	private bool NHBIGCCDOKC(SocketException DNFOGIGBCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x572DBA0", Offset = "0x572CBA0", VA = "0x18572DBA0")]
	private void GILGABOLOED(GPFGJLMNEEA HIDDFJJHELM, EndPoint ELAHHKPHCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x572D550", Offset = "0x572C550", VA = "0x18572D550")]
	private void FGNIKILDBPA(object DKOKOEEPCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x572F730", Offset = "0x572E730", VA = "0x18572F730")]
	public bool MLLCENNIMJA(IPAddress LNKONONJNFE, IPAddress KLJAIHDDBIO, int HEABAAFBNMN, bool JOPPCLEPDEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x572BB00", Offset = "0x572AB00", VA = "0x18572BB00")]
	internal int DELKOHBGNLH(GKBCCADNJJF IHMKCIBBNJE, IPEndPoint EPNBDIJBNOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x572D510", Offset = "0x572C510", VA = "0x18572D510")]
	internal int FGMBFDOJDGM(GKBCCADNJJF IHMKCIBBNJE, IPEndPoint EPNBDIJBNOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x572CF50", Offset = "0x572BF50", VA = "0x18572CF50")]
	internal int FGMBFDOJDGM(byte[] JJJNODJJIFK, int GGOAAGPAMNC, int GOKGFKKLOOJ, IPEndPoint EPNBDIJBNOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5730900", Offset = "0x572F900", VA = "0x185730900")]
	internal void OPHILMGKMNP(bool GODIPKNFCLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum DDDOFGDLFEL : byte
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
internal sealed class GKBCCADNJJF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int DCNKHKODOGH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] FDHDMLFLFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IJJLGHNLPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BMODBHJLIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object EIHHKIMHAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public GKBCCADNJJF IINBOPDCMHG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DDDOFGDLFEL KIFNBOBEBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5729730", Offset = "0x5728730", VA = "0x185729730")]
		get
		{
			return default(DDDOFGDLFEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x57294B0", Offset = "0x57284B0", VA = "0x1857294B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte OGKGAOODLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5729550", Offset = "0x5728550", VA = "0x185729550")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x57295B0", Offset = "0x57285B0", VA = "0x1857295B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort IPHMAKJGNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x57294F0", Offset = "0x57284F0", VA = "0x1857294F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x57296F0", Offset = "0x57286F0", VA = "0x1857296F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool APPJHPGDBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5729240", Offset = "0x5728240", VA = "0x185729240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte CAONDIEBPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x57293E0", Offset = "0x57283E0", VA = "0x1857293E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x57293B0", Offset = "0x57283B0", VA = "0x1857293B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort MBCNGNAOFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5729410", Offset = "0x5728410", VA = "0x185729410")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5729650", Offset = "0x5728650", VA = "0x185729650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort NNMPMIICOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x57295F0", Offset = "0x57285F0", VA = "0x1857295F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5729270", Offset = "0x5728270", VA = "0x185729270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort LHGLLALMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5729690", Offset = "0x5728690", VA = "0x185729690")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5729470", Offset = "0x5728470", VA = "0x185729470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5729860", Offset = "0x5728860", VA = "0x185729860")]
	static GKBCCADNJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5729580", Offset = "0x5728580", VA = "0x185729580")]
	public void HGGFHIEJLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5729C50", Offset = "0x5728C50", VA = "0x185729C50")]
	public GKBCCADNJJF(int GFFAGBDKDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5729B40", Offset = "0x5728B40", VA = "0x185729B40")]
	public GKBCCADNJJF(DDDOFGDLFEL GFNKMDBLDFI, int GFFAGBDKDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5729760", Offset = "0x5728760", VA = "0x185729760")]
	public static int LPCEPEHFANG(DDDOFGDLFEL GFNKMDBLDFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x57297D0", Offset = "0x57287D0", VA = "0x1857297D0")]
	public int LPCEPEHFANG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x57292B0", Offset = "0x57282B0", VA = "0x1857292B0")]
	public bool BJBFGAINKIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum LJCFPDDNGAE : byte
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
internal enum IPKELFNFNIB
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
internal enum AELKKJNPOBD
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IDDFHJGKIFI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JLBCPMFLKFB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GOFANBHMLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GKBCCADNJJF[] FBMANEBMEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int ACIJNGEGKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int FIFMGLEEHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte CAONDIEBPCL;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GOFANBHMLNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void EIPHAPCMBIO(ulong POBDDKPNJIL, int MBPOMJDGHDI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int JDCMAOANKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int NKLADMPDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int AEKGJMDLGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double CELGHKADHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int ECDENNDPPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int FPHLJCPBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int DHBKHCLFOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch KPAMMPEGIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int BJDGNFLMNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PBOJBOMGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object EFDFAPEJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal JLBCPMFLKFB DKKJGFCEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal JLBCPMFLKFB JCPMMBFBCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<GKBCCADNJJF> CKEHPLHBIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<NJCOHANEGMH> KNILEDAEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly NJCOHANEGMH[] GDAHNNOAHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int KLJMFLADNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int ACDGOBMGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool MBKGLGBNLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int JBEFHMEKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HONPPEOFJLA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CDECJOBILAJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int EBLMEFEJEGB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object FCKKFBNGIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int IEINNJAHNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GOFANBHMLNF> CLJKFLNFCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> KCLNGAPLGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly GKBCCADNJJF DCBILNMGMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GMDIGIFNAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int OHAEBODEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint LLDABCCPAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LFPIOFDLECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KECFDFCLKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long BAOELGLOOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FFNGKLMBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private LJCFPDDNGAE DNHCBECHMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GKBCCADNJJF JODAHPDCPPB;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int DDCNICBHEDJ = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int POHOIKELEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GKBCCADNJJF AFFKPPOFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly GKBCCADNJJF NLHLIBNLOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly GKBCCADNJJF LKIFLPAEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly GKBCCADNJJF CMCFJFKFEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private NOPHOIEAIAE OHKNPNJMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly HHECMMHOLNJ LHEPOKDGPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int MNFBEPHEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object FEICJBKNNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HGHAFCCEOIC KMPLKENJIPC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte NMHBDMHNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA7ED0", Offset = "0xAA6ED0", VA = "0x180AA7ED0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5734F70", Offset = "0x5733F70", VA = "0x185734F70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint BEGFHBBCHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DF280", Offset = "0x8DE280", VA = "0x1808DF280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LJCFPDDNGAE LJNEHLPAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16775F0", Offset = "0x16765F0", VA = "0x1816775F0")]
		get
		{
			return default(LJCFPDDNGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long GCBOCOJIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E50", Offset = "0x7C8E50", VA = "0x1807C9E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IFLHJOOGMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB77440", Offset = "0xB76440", VA = "0x180B77440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1489C30", Offset = "0x1488C30", VA = "0x181489C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KHCECGDKKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x57367D0", Offset = "0x57357D0", VA = "0x1857367D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HHIDBFGOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D00D0", Offset = "0x7CF0D0", VA = "0x1807D00D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CLDPFBGHOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x18AB610", Offset = "0x18AA610", VA = "0x1818AB610")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EIPHAPCMBIO LPGBFDHPBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5733F70", Offset = "0x5732F70", VA = "0x185733F70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5735A50", Offset = "0x5734A50", VA = "0x185735A50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5737140", Offset = "0x5736140", VA = "0x185737140")]
	internal JLBCPMFLKFB(HHECMMHOLNJ IJFMIGCKMBH, IPEndPoint EPNBDIJBNOB, int JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5734140", Offset = "0x5733140", VA = "0x185734140")]
	internal void CCMFHEFAMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x57367E0", Offset = "0x57357E0", VA = "0x1857367E0")]
	internal void OBDAOCFBOLK(IPEndPoint LPDGKGIBBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5736740", Offset = "0x5735740", VA = "0x185736740")]
	internal void NINHPHLAMKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5736670", Offset = "0x5735670", VA = "0x185736670")]
	private void MIBJHLHBPPI(int KMINHFNHNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5733C20", Offset = "0x5732C20", VA = "0x185733C20")]
	private void ADONMAGHOBH(int IMEKBIHEFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5734DC0", Offset = "0x5733DC0", VA = "0x185734DC0")]
	private NJCOHANEGMH DGIGGHLCFJP(byte MNONMOOEFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5736DD0", Offset = "0x5735DD0", VA = "0x185736DD0")]
	internal JLBCPMFLKFB(HHECMMHOLNJ IJFMIGCKMBH, IPEndPoint EPNBDIJBNOB, int JKEKANKKCCC, byte DOOPGPLFLIF, IHBNLNFGKDN AOCGPAGJEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5736F60", Offset = "0x5735F60", VA = "0x185736F60")]
	internal JLBCPMFLKFB(HHECMMHOLNJ IJFMIGCKMBH, KFDHFMKMOHC MJJCOLDOFAC, int JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5736380", Offset = "0x5735380", VA = "0x185736380")]
	internal void LGLFOIPKAEK(GMOMBACJCNK HOLKOKIALFO, byte[] GPKMLHOONCL, int GGOAAGPAMNC, int GOKGFKKLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5735BB0", Offset = "0x5734BB0", VA = "0x185735BB0")]
	internal bool GJKJDHEGJME(JDHHPCDEPNA IHMKCIBBNJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5736350", Offset = "0x5735350", VA = "0x185736350")]
	public void JADFDOLIOJB(byte[] GPKMLHOONCL, int GGOAAGPAMNC, int GOKGFKKLOOJ, CMFIFFBKKLG CACELMJJEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5735C30", Offset = "0x5734C30", VA = "0x185735C30")]
	private void HJEKGFDNGCL(byte[] GPKMLHOONCL, int GGOAAGPAMNC, int GOKGFKKLOOJ, byte DAHMHMCDONI, CMFIFFBKKLG IJNEKDBEHFJ, object KLJIOLNCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5735B00", Offset = "0x5734B00", VA = "0x185735B00")]
	public void FBLADMIHENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5736590", Offset = "0x5735590", VA = "0x185736590")]
	internal AELKKJNPOBD MDMIEHFKADP(GKBCCADNJJF IHMKCIBBNJE)
	{
		return default(AELKKJNPOBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5736D70", Offset = "0x5735D70", VA = "0x185736D70")]
	internal void PPIOEIDINLC(NJCOHANEGMH HPDODIFEOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5733C60", Offset = "0x5732C60", VA = "0x185733C60")]
	internal IDDFHJGKIFI ANKBBBNNNLO(byte[] GPKMLHOONCL, int GGOAAGPAMNC, int GOKGFKKLOOJ, bool CLNMAALIOEC)
	{
		return default(IDDFHJGKIFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5733BE0", Offset = "0x5732BE0", VA = "0x185733BE0")]
	private void ACJKBPCMEEK(int EBPEIBPDNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5734160", Offset = "0x5733160", VA = "0x185734160")]
	internal void CHALJHGNBBL(CMFIFFBKKLG FDOLBLEEEEH, GKBCCADNJJF FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5736810", Offset = "0x5735810", VA = "0x185736810")]
	private void OCNGIPJGDNN(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x57356D0", Offset = "0x57346D0", VA = "0x1857356D0")]
	private void EFBIMELLIKC(int EFPELNMKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57363D0", Offset = "0x57353D0", VA = "0x1857363D0")]
	internal IPKELFNFNIB MBCBMCBIJOA(GMOMBACJCNK DDBDJDHJABK)
	{
		return default(IPKELFNFNIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5735020", Offset = "0x5734020", VA = "0x185735020")]
	internal void DKPMDMNLEAN(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5734020", Offset = "0x5733020", VA = "0x185734020")]
	private void CBFIJENJFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5736180", Offset = "0x5735180", VA = "0x185736180")]
	internal void HPFCNAMLPBC(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5733530", Offset = "0x5732530", VA = "0x185733530")]
	internal void ACILEHIEJCJ(int EFPELNMKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5734B00", Offset = "0x5733B00", VA = "0x185734B00")]
	internal void CKOECMIPLAN(GKBCCADNJJF IHMKCIBBNJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HGHAFCCEOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PHFKOHJPEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GAFBBOLDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long MPBPMPMMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DDIPOMKKALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long CHIAADKCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long GIKAKIJCLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long COJEFMDFAAE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FFPGCELEMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x572A3B0", Offset = "0x57293B0", VA = "0x18572A3B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DOGAJOAFADK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x572A340", Offset = "0x5729340", VA = "0x18572A340")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long ENPDALOAKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x572A400", Offset = "0x5729400", VA = "0x18572A400")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NLPHHKPFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x572A2F0", Offset = "0x57292F0", VA = "0x18572A2F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long DLEOCAOANLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x572A2D0", Offset = "0x57292D0", VA = "0x18572A2D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NKDNMMLNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x572A220", Offset = "0x5729220", VA = "0x18572A220")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private NOPHOIEAIAE CAIOHINNJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1B0B4A0", Offset = "0x1B0A4A0", VA = "0x181B0B4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double NCJNHHGMPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x572A190", Offset = "0x5729190", VA = "0x18572A190")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x572A350", Offset = "0x5729350", VA = "0x18572A350")]
	public void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x572A1F0", Offset = "0x57291F0", VA = "0x18572A1F0")]
	public void BEIBAINCNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x572A3C0", Offset = "0x57293C0", VA = "0x18572A3C0")]
	public void MONBHCJFCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x572A410", Offset = "0x5729410", VA = "0x18572A410")]
	public void POKJIAFBOOB(long MPJHDLIKEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x572A2E0", Offset = "0x57292E0", VA = "0x18572A2E0")]
	public void DFHJENDDELO(long OMCCEKGNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x572A3D0", Offset = "0x57293D0", VA = "0x18572A3D0")]
	public void OABMKIIIKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x572A300", Offset = "0x5729300", VA = "0x18572A300")]
	public void JCBKNGOGFBO(long PFCNPJKEIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x572A420", Offset = "0x5729420", VA = "0x18572A420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x572A230", Offset = "0x5729230", VA = "0x18572A230")]
	public void BNBIBJOKPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public HGHAFCCEOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KCHFJAFJPKB
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> PJBJMEGFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5737640", Offset = "0x5736640", VA = "0x185737640")]
	public static IPEndPoint FKGMODIDFOF(string JCNNGGICEAP, int HEABAAFBNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5737890", Offset = "0x5736890", VA = "0x185737890")]
	public static IPAddress KLEMGCBMNEL(string JCNNGGICEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5737A60", Offset = "0x5736A60", VA = "0x185737A60")]
	public static IPAddress KLEMGCBMNEL(string JCNNGGICEAP, AddressFamily ALPLJJEHKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5737AF0", Offset = "0x5736AF0", VA = "0x185737AF0")]
	internal static int NEPFJJAICHA(int BPBOBEOJCCL, int DPOJJABGFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x294E130", Offset = "0x294D130", VA = "0x18294E130")]
	internal static T[] PLFBLHDEJHP<T>(int MJMIIGGLEFB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PHGONBKFPNP : NJCOHANEGMH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BMJMEIPOLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private GKBCCADNJJF OBNAFHNNJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long JCMKBEFDBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool MEDIOGJAOHP;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x57276D0", Offset = "0x57266D0", VA = "0x1857276D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x57275F0", Offset = "0x57265F0", VA = "0x1857275F0")]
		public void CPHLHCOPMDI(GKBCCADNJJF IHMKCIBBNJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5727610", Offset = "0x5726610", VA = "0x185727610")]
		public bool EOPOBIHNHMH(long NMIEKNEGIHF, JLBCPMFLKFB MIBCBPLHPHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5727680", Offset = "0x5726680", VA = "0x185727680")]
		public bool HCLIMFMHPCF(JLBCPMFLKFB MIBCBPLHPHA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly GKBCCADNJJF HKBJLKGGGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly BMJMEIPOLMJ[] HDOCJPBKNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly GKBCCADNJJF[] NFJJLIBODJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] NEMDAGMPKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int GJBHHEFBCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CMPKMMNNMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int DCFOJCIKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int BBBCLAPBADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool BJFGIDBEAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly CMFIFFBKKLG BJHGJFIEIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool DKCFBABJDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int GFNEIFNNGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte NJBAEEEGHNN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x573D020", Offset = "0x573C020", VA = "0x18573D020")]
	public PHGONBKFPNP(JLBCPMFLKFB MIBCBPLHPHA, bool MPGLKIJLKLH, byte JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x573CC60", Offset = "0x573BC60", VA = "0x18573CC60")]
	private void PKJMOGENLGL(GKBCCADNJJF IHMKCIBBNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x573C7B0", Offset = "0x573B7B0", VA = "0x18573C7B0", Slot = "4")]
	protected override bool LDGKCMPHMLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x573C150", Offset = "0x573B150", VA = "0x18573C150", Slot = "5")]
	public override bool DKPMDMNLEAN(GKBCCADNJJF IHMKCIBBNJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MMBGHPMOIFG : NJCOHANEGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int AEHBANGPKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort CMPKMMNNMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool KNCONDNEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GKBCCADNJJF JKCLGHKMJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly GKBCCADNJJF FCNKJECAHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool JHDOAEBJOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte NJBAEEEGHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long ACOJKFPBPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x573A740", Offset = "0x5739740", VA = "0x18573A740")]
	public MMBGHPMOIFG(JLBCPMFLKFB MIBCBPLHPHA, bool NOAKCCHMPNL, byte JKEKANKKCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x573A2A0", Offset = "0x57392A0", VA = "0x18573A2A0", Slot = "4")]
	protected override bool LDGKCMPHMLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5739F90", Offset = "0x5738F90", VA = "0x185739F90", Slot = "5")]
	public override bool DKPMDMNLEAN(GKBCCADNJJF IHMKCIBBNJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MCHAMDNCDKG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MICNBJPICKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong KJMENFMIDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double EPOCOFMLFLG;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct BLDPHPMNEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int NFOLLGHMJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float OHOAGIOEGHF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x57272A0", Offset = "0x57262A0", VA = "0x1857272A0")]
	private static void LMOOFPDBJGL(byte[] IDAJCEMIFPD, int NGKDOMEFDDB, ulong GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5739E30", Offset = "0x5738E30", VA = "0x185739E30")]
	private static void LMOOFPDBJGL(byte[] IDAJCEMIFPD, int NGKDOMEFDDB, int GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5739EA0", Offset = "0x5738EA0", VA = "0x185739EA0")]
	public static void LMOOFPDBJGL(byte[] IDAJCEMIFPD, int NGKDOMEFDDB, short GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5739EF0", Offset = "0x5738EF0", VA = "0x185739EF0")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, double LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5739F10", Offset = "0x5738F10", VA = "0x185739F10")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5739EA0", Offset = "0x5738EA0", VA = "0x185739EA0")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, short LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5739EA0", Offset = "0x5738EA0", VA = "0x185739EA0")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, ushort LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5739E30", Offset = "0x5738E30", VA = "0x185739E30")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5739E30", Offset = "0x5738E30", VA = "0x185739E30")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, uint LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5739EE0", Offset = "0x5738EE0", VA = "0x185739EE0")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, long LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5739EE0", Offset = "0x5738EE0", VA = "0x185739EE0")]
	public static void PCDDOGFLIPI(byte[] MFPMCBPILCI, int GOABEOHPNBP, ulong LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CJLJIEMEPBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] GBOCLODMIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int PCKENFKIIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int LCHLNBNHOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int FJNFCCABCNN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] IJJLGHNLPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int KHBEMKCFIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HBFJDKBJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5727950", Offset = "0x5726950", VA = "0x185727950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ANFHIGGFMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DE10", Offset = "0x1D5CE10", VA = "0x181D5DE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IDJGPOGBCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5728310", Offset = "0x5727310", VA = "0x185728310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x57277F0", Offset = "0x57267F0", VA = "0x1857277F0")]
	public void AKABBPKAELO(byte[] KEHDHCINJMM, int NGKDOMEFDDB, int IGFHHBKBDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CJLJIEMEPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5728360", Offset = "0x5727360", VA = "0x185728360")]
	public CJLJIEMEPBC(byte[] KEHDHCINJMM, int NGKDOMEFDDB, int IGFHHBKBDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5727960", Offset = "0x5726960", VA = "0x185727960")]
	public IPEndPoint DABPOAJPPCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5727AF0", Offset = "0x5726AF0", VA = "0x185727AF0")]
	public byte FJMBDNKBOGD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5727AF0", Offset = "0x5726AF0", VA = "0x185727AF0")]
	public sbyte FMGIEGAOOKA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2719460", Offset = "0x2718460", VA = "0x182719460")]
	public T[] GFDJNDGHBNP<T>(ushort GFFAGBDKDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5727770", Offset = "0x5726770", VA = "0x185727770")]
	public bool[] ADFPBEIJOCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5728130", Offset = "0x5727130", VA = "0x185728130")]
	public ushort[] LOFHGNNPAOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x57281E0", Offset = "0x57271E0", VA = "0x1857281E0")]
	public short[] MFEHPAOHHOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5727A30", Offset = "0x5726A30", VA = "0x185727A30")]
	public int[] EKFLJLEAMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x57277B0", Offset = "0x57267B0", VA = "0x1857277B0")]
	public uint[] AFEPFKAJJFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5727910", Offset = "0x5726910", VA = "0x185727910")]
	public float[] BLNAFBGOCPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5728320", Offset = "0x5727320", VA = "0x185728320")]
	public double[] OLCHKNLGHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5728290", Offset = "0x5727290", VA = "0x185728290")]
	public long[] NEIPBNKJAIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5727C80", Offset = "0x5726C80", VA = "0x185727C80")]
	public ulong[] GMKJEBIFDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5727CE0", Offset = "0x5726CE0", VA = "0x185727CE0")]
	public string[] KBIEEHFOMOJ(int EICGBLNKPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5727A70", Offset = "0x5726A70", VA = "0x185727A70")]
	public bool EPLDKMGEDOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5727C10", Offset = "0x5726C10", VA = "0x185727C10")]
	public char GOCLHIHFLEJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5727C10", Offset = "0x5726C10", VA = "0x185727C10")]
	public ushort GKFGAONLBOE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5728220", Offset = "0x5727220", VA = "0x185728220")]
	public short MHOLNDFCLLC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5727E10", Offset = "0x5726E10", VA = "0x185727E10")]
	public long KEHGKJHLPLD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5727B30", Offset = "0x5726B30", VA = "0x185727B30")]
	public ulong GELPONHIOPI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5728170", Offset = "0x5727170", VA = "0x185728170")]
	public int MADAOFJEGDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5727BA0", Offset = "0x5726BA0", VA = "0x185727BA0")]
	public uint GINAFFJKALI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x57278A0", Offset = "0x57268A0", VA = "0x1857278A0")]
	public float APMAMJLOIBA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5727830", Offset = "0x5726830", VA = "0x185727830")]
	public double ANEJBPLKAII()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5727EF0", Offset = "0x5726EF0", VA = "0x185727EF0")]
	public string LBPMHLPDAAM(int JBBBKAGKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5727E80", Offset = "0x5726E80", VA = "0x185727E80")]
	public ArraySegment<byte> LAJHGCEAKJO(int MJMIIGGLEFB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x57282D0", Offset = "0x57272D0", VA = "0x1857282D0")]
	public sbyte[] OIFDALLANNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5727AB0", Offset = "0x5726AB0", VA = "0x185727AB0")]
	public byte[] FGFHNGENONK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5727CC0", Offset = "0x5726CC0", VA = "0x185727CC0")]
	public void HCLIMFMHPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IHBNLNFGKDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] GBOCLODMIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int PCKENFKIIGN;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int DIHOENBGLAB = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool EELGKFHLACB;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding GJDHFPDINPJ;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int NHNKONAEGDA = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] CIBOECIMFGN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] IKNEHLGBAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5732FA0", Offset = "0x5731FA0", VA = "0x185732FA0")]
	public IHBNLNFGKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5733020", Offset = "0x5732020", VA = "0x185733020")]
	public IHBNLNFGKDN(bool ENKDJLHKGJI, int PNHLBDOFLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5732EA0", Offset = "0x5731EA0", VA = "0x185732EA0")]
	public static IHBNLNFGKDN NMLCAOBGJAC(string LDGMLLMKHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5732270", Offset = "0x5731270", VA = "0x185732270")]
	public void BHOCGPIOMNA(int KPCMEOJHBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7AF0", Offset = "0x1DD6AF0", VA = "0x181DD7AF0")]
	public void KNIDJLMEEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5732840", Offset = "0x5731840", VA = "0x185732840")]
	public void MNDAFJCGNHM(float LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5732AF0", Offset = "0x5731AF0", VA = "0x185732AF0")]
	public void MNDAFJCGNHM(double LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5732DF0", Offset = "0x5731DF0", VA = "0x185732DF0")]
	public void MNDAFJCGNHM(long LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5732DF0", Offset = "0x5731DF0", VA = "0x185732DF0")]
	public void MNDAFJCGNHM(ulong LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5732CE0", Offset = "0x5731CE0", VA = "0x185732CE0")]
	public void MNDAFJCGNHM(int LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5732CE0", Offset = "0x5731CE0", VA = "0x185732CE0")]
	public void MNDAFJCGNHM(uint LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5732D70", Offset = "0x5731D70", VA = "0x185732D70")]
	public void MNDAFJCGNHM(char LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5732D70", Offset = "0x5731D70", VA = "0x185732D70")]
	public void MNDAFJCGNHM(ushort LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5732D70", Offset = "0x5731D70", VA = "0x185732D70")]
	public void MNDAFJCGNHM(short LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5732B40", Offset = "0x5731B40", VA = "0x185732B40")]
	public void MNDAFJCGNHM(sbyte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5732B40", Offset = "0x5731B40", VA = "0x185732B40")]
	public void MNDAFJCGNHM(byte LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5732C70", Offset = "0x5731C70", VA = "0x185732C70")]
	public void MNDAFJCGNHM(byte[] GPKMLHOONCL, int NGKDOMEFDDB, int GOKGFKKLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x57325B0", Offset = "0x57315B0", VA = "0x1857325B0")]
	public void HJEKGAKHMMJ(sbyte[] GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x57325B0", Offset = "0x57315B0", VA = "0x1857325B0")]
	public void EEEONBIOGGJ(byte[] GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5732E40", Offset = "0x5731E40", VA = "0x185732E40")]
	public void MNDAFJCGNHM(bool LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5732690", Offset = "0x5731690", VA = "0x185732690")]
	public void CFGINLAHAIL(Array FHFGIJNAOCM, int GBJALOMCCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x57324D0", Offset = "0x57314D0", VA = "0x1857324D0")]
	public void CFGINLAHAIL(float[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x57323F0", Offset = "0x57313F0", VA = "0x1857323F0")]
	public void CFGINLAHAIL(double[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x57323F0", Offset = "0x57313F0", VA = "0x1857323F0")]
	public void CFGINLAHAIL(long[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x57323F0", Offset = "0x57313F0", VA = "0x1857323F0")]
	public void CFGINLAHAIL(ulong[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x57324D0", Offset = "0x57314D0", VA = "0x1857324D0")]
	public void CFGINLAHAIL(int[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x57324D0", Offset = "0x57314D0", VA = "0x1857324D0")]
	public void CFGINLAHAIL(uint[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5732310", Offset = "0x5731310", VA = "0x185732310")]
	public void CFGINLAHAIL(ushort[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5732310", Offset = "0x5731310", VA = "0x185732310")]
	public void CFGINLAHAIL(short[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x57325B0", Offset = "0x57315B0", VA = "0x1857325B0")]
	public void CFGINLAHAIL(bool[] LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5732770", Offset = "0x5731770", VA = "0x185732770")]
	public void CFGINLAHAIL(string[] LDGMLLMKHLF, int BIJFDHDDBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5732BA0", Offset = "0x5731BA0", VA = "0x185732BA0")]
	public void MNDAFJCGNHM(IPEndPoint JDAACDGBFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5732DE0", Offset = "0x5731DE0", VA = "0x185732DE0")]
	public void MNDAFJCGNHM(string LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x57328E0", Offset = "0x57318E0", VA = "0x1857328E0")]
	public void MNDAFJCGNHM(string LDGMLLMKHLF, int JBBBKAGKNMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PKNCHKNJMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BEAJIBFPMJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong MNFBEPHEHHF;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x48ED980", Offset = "0x48EC980", VA = "0x1848ED980")]
		static BEAJIBFPMJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void EEJCFPJGNKN(CJLJIEMEPBC AMMJOMFBDDI, object KLJIOLNCIAP);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CPGPEFKFBMN<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PKNCHKNJMCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CPGPEFKFBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x50454A0", Offset = "0x50444A0", VA = "0x1850454A0")]
		internal void CBBMOBHLCEN(CJLJIEMEPBC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CNCDCBAAMEE<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public PKNCHKNJMCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CNCDCBAAMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x503D1C0", Offset = "0x503C1C0", VA = "0x18503D1C0")]
		internal void CBBMOBHLCEN(CJLJIEMEPBC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly GAAJEBLODMO GHNMEFANPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, EEJCFPJGNKN> ELDILFFPGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly IHBNLNFGKDN EKGGICIEHGE;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x573D3F0", Offset = "0x573C3F0", VA = "0x18573D3F0")]
	public PKNCHKNJMCJ(int EICGBLNKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x26BA1C0", Offset = "0x26B91C0", VA = "0x1826BA1C0", Slot = "4")]
	protected virtual ulong CILKAOPHKOO<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x573D1F0", Offset = "0x573C1F0", VA = "0x18573D1F0", Slot = "5")]
	protected virtual EEJCFPJGNKN BHLHKGDALAA(CJLJIEMEPBC AMMJOMFBDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A55D50", Offset = "0x2A54D50", VA = "0x182A55D50", Slot = "6")]
	protected virtual void OLIDCFPGFFH<T>(IHBNLNFGKDN BPEIDAMPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x573D320", Offset = "0x573C320", VA = "0x18573D320")]
	public void CBAFGIAPOOO(CJLJIEMEPBC AMMJOMFBDDI, object KLJIOLNCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A55CC0", Offset = "0x2A54CC0", VA = "0x182A55CC0")]
	public void JBODEMHGHEN<T>(IHBNLNFGKDN BPEIDAMPHFE, T IHMKCIBBNJE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x573D3A0", Offset = "0x573C3A0", VA = "0x18573D3A0")]
	public void LPNIIHCBNNK(CJLJIEMEPBC AMMJOMFBDDI, object KLJIOLNCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A55B40", Offset = "0x2A54B40", VA = "0x182A55B40")]
	public void CMHCNKIPFNH<T>(Action<T> AOKOFCDKFPP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A559C0", Offset = "0x2A549C0", VA = "0x182A559C0")]
	public void CMHCNKIPFNH<T, TUserData>(Action<T, TUserData> AOKOFCDKFPP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IKOIIFCOJIO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5727570", Offset = "0x5726570", VA = "0x185727570")]
	public IKOIIFCOJIO(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KNENFJOMLFI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5737DB0", Offset = "0x5736DB0", VA = "0x185737DB0")]
	public KNENFJOMLFI(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class GAAJEBLODMO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LEGIGKHIJDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class JFGNEOMJHBC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LEGIGKHIJDC PFOKGBDCIEP;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE190", Offset = "0x3CCD190", VA = "0x183CCE190", Slot = "4")]
		public virtual void CPHLHCOPMDI(MethodInfo OOJDIFEADBC, MethodInfo LCLKAMNLACD, LEGIGKHIJDC KBCNAJKPHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FNDEIHBJGGC(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CAMGGFFFDHO(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		protected JFGNEOMJHBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class AMDNEPODMPN<TClass, TProperty> : JFGNEOMJHBC<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> OBLEFOIKFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> GBBOFACFOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> FFFDHPEAKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> BNEKFEMENGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> GCIGLJDIJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> GAKKBNAJGIO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DF80", Offset = "0x3B6CF80", VA = "0x183B6DF80", Slot = "7")]
		public override void FDIHFHFNEDF(TClass BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F9E0", Offset = "0x3B6E9E0", VA = "0x183B6F9E0", Slot = "8")]
		public override void MCLOCMHAAHP(TClass BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3B6EAE0", Offset = "0x3B6DAE0", VA = "0x183B6EAE0", Slot = "9")]
		public override void FNDEIHBJGGC(TClass BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3B68A40", Offset = "0x3B67A40", VA = "0x183B68A40", Slot = "10")]
		public override void CAMGGFFFDHO(TClass BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F560", Offset = "0x3B6E560", VA = "0x183B6F560")]
		protected TProperty[] GABADGMFCNL(TClass BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3B68810", Offset = "0x3B67810", VA = "0x183B68810")]
		protected TProperty[] AKBMKNNCELN(TClass BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6AAE0", Offset = "0x3B69AE0", VA = "0x183B6AAE0", Slot = "4")]
		public override void CPHLHCOPMDI(MethodInfo OOJDIFEADBC, MethodInfo LCLKAMNLACD, LEGIGKHIJDC KBCNAJKPHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3B701C0", Offset = "0x3B6F1C0", VA = "0x183B701C0")]
		protected AMDNEPODMPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class EEMFBCMOIFC<TClass, TProperty> : AMDNEPODMPN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CMKEGDNDJBN(CJLJIEMEPBC HOBDDCFEELG, [Out] TProperty KDKGANDJCKH);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void CAFKGNKCANH(IHBNLNFGKDN PKFDHNAJKPJ, TProperty KDKGANDJCKH);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x34E8A60", Offset = "0x34E7A60", VA = "0x1834E8A60", Slot = "5")]
		public override void CDGJENMFNJM(TClass BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x34E8D10", Offset = "0x34E7D10", VA = "0x1834E8D10", Slot = "6")]
		public override void JBODEMHGHEN(TClass BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x34E8B60", Offset = "0x34E7B60", VA = "0x1834E8B60", Slot = "7")]
		public override void FDIHFHFNEDF(TClass BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x34E8D80", Offset = "0x34E7D80", VA = "0x1834E8D80", Slot = "8")]
		public override void MCLOCMHAAHP(TClass BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x34E8EC0", Offset = "0x34E7EC0", VA = "0x1834E8EC0")]
		protected EEMFBCMOIFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LBKOMIIFJEE<T> : AMDNEPODMPN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B790", Offset = "0x3E1A790", VA = "0x183E1B790", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B870", Offset = "0x3E1A870", VA = "0x183E1B870", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B800", Offset = "0x3E1A800", VA = "0x183E1B800", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B8D0", Offset = "0x3E1A8D0", VA = "0x183E1B8D0", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public LBKOMIIFJEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BHMFLMPEBBF<T> : AMDNEPODMPN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x48FD310", Offset = "0x48FC310", VA = "0x1848FD310", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B870", Offset = "0x3E1A870", VA = "0x183E1B870", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x48FD380", Offset = "0x48FC380", VA = "0x1848FD380", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B8D0", Offset = "0x3E1A8D0", VA = "0x183E1B8D0", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public BHMFLMPEBBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class OLFEAMLJHBK<T> : AMDNEPODMPN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x41E5720", Offset = "0x41E4720", VA = "0x1841E5720", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x38A63B0", Offset = "0x38A53B0", VA = "0x1838A63B0", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x41E5790", Offset = "0x41E4790", VA = "0x1841E5790", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x38A6410", Offset = "0x38A5410", VA = "0x1838A6410", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public OLFEAMLJHBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class FMKPLFHDILM<T> : AMDNEPODMPN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x38A62D0", Offset = "0x38A52D0", VA = "0x1838A62D0", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x38A63B0", Offset = "0x38A53B0", VA = "0x1838A63B0", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x38A6340", Offset = "0x38A5340", VA = "0x1838A6340", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x38A6410", Offset = "0x38A5410", VA = "0x1838A6410", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public FMKPLFHDILM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JKBPLLICBDD<T> : AMDNEPODMPN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF41E0", Offset = "0x3CF31E0", VA = "0x183CF41E0", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF42C0", Offset = "0x3CF32C0", VA = "0x183CF42C0", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4250", Offset = "0x3CF3250", VA = "0x183CF4250", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4320", Offset = "0x3CF3320", VA = "0x183CF4320", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public JKBPLLICBDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class PDKDLBHFPOC<T> : AMDNEPODMPN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4282610", Offset = "0x4281610", VA = "0x184282610", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF42C0", Offset = "0x3CF32C0", VA = "0x183CF42C0", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4282680", Offset = "0x4281680", VA = "0x184282680", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4320", Offset = "0x3CF3320", VA = "0x183CF4320", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public PDKDLBHFPOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BLNAMADGLAI<T> : AMDNEPODMPN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEB20", Offset = "0x3CCDB20", VA = "0x183CCEB20", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC00", Offset = "0x3CCDC00", VA = "0x183CCEC00", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x491D7D0", Offset = "0x491C7D0", VA = "0x18491D7D0", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC60", Offset = "0x3CCDC60", VA = "0x183CCEC60", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public BLNAMADGLAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class JGIOIACDIJL<T> : AMDNEPODMPN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEB20", Offset = "0x3CCDB20", VA = "0x183CCEB20", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC00", Offset = "0x3CCDC00", VA = "0x183CCEC00", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEB90", Offset = "0x3CCDB90", VA = "0x183CCEB90", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC60", Offset = "0x3CCDC60", VA = "0x183CCEC60", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public JGIOIACDIJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PGKNCLBGKFE<T> : AMDNEPODMPN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4288730", Offset = "0x4287730", VA = "0x184288730", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4288810", Offset = "0x4287810", VA = "0x184288810", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x42887A0", Offset = "0x42877A0", VA = "0x1842887A0", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B8D0", Offset = "0x3E1A8D0", VA = "0x183E1B8D0", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public PGKNCLBGKFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CPACLJOIGPF<T> : AMDNEPODMPN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5045100", Offset = "0x5044100", VA = "0x185045100", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x50451E0", Offset = "0x50441E0", VA = "0x1850451E0", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5045170", Offset = "0x5044170", VA = "0x185045170", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4320", Offset = "0x3CF3320", VA = "0x183CF4320", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public CPACLJOIGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JHBLBJLPGBM<T> : AMDNEPODMPN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEF90", Offset = "0x3CCDF90", VA = "0x183CCEF90", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF070", Offset = "0x3CCE070", VA = "0x183CCF070", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF000", Offset = "0x3CCE000", VA = "0x183CCF000", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC60", Offset = "0x3CCDC60", VA = "0x183CCEC60", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x38A6470", Offset = "0x38A5470", VA = "0x1838A6470")]
		public JHBLBJLPGBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NFDHMOJEMOM<T> : EEMFBCMOIFC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x40B8EA0", Offset = "0x40B7EA0", VA = "0x1840B8EA0", Slot = "12")]
		protected override void CAFKGNKCANH(IHBNLNFGKDN PKFDHNAJKPJ, char KDKGANDJCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x40B8ED0", Offset = "0x40B7ED0", VA = "0x1840B8ED0", Slot = "11")]
		protected override void CMKEGDNDJBN(CJLJIEMEPBC HOBDDCFEELG, [Out] char KDKGANDJCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A02DA0", Offset = "0x3A01DA0", VA = "0x183A02DA0")]
		public NFDHMOJEMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class HNHIKKIONJB<T> : EEMFBCMOIFC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A44350", Offset = "0x3A43350", VA = "0x183A44350", Slot = "12")]
		protected override void CAFKGNKCANH(IHBNLNFGKDN PKFDHNAJKPJ, IPEndPoint KDKGANDJCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A44380", Offset = "0x3A43380", VA = "0x183A44380", Slot = "11")]
		protected override void CMKEGDNDJBN(CJLJIEMEPBC HOBDDCFEELG, [Out] IPEndPoint KDKGANDJCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A02DA0", Offset = "0x3A01DA0", VA = "0x183A02DA0")]
		public HNHIKKIONJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BGEOMFHKNCD<T> : AMDNEPODMPN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int GOPMMBABBJP;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x48F5CE0", Offset = "0x48F4CE0", VA = "0x1848F5CE0")]
		public BGEOMFHKNCD(int JBBBKAGKNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x48F5B20", Offset = "0x48F4B20", VA = "0x1848F5B20", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x48F5C00", Offset = "0x48F4C00", VA = "0x1848F5C00", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x48F5B90", Offset = "0x48F4B90", VA = "0x1848F5B90", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x48F5C70", Offset = "0x48F4C70", VA = "0x1848F5C70", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class CAPEHLFBBHC<T> : JFGNEOMJHBC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo KIFNBOBEBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type PPOJNBILICE;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCE30", Offset = "0x4BDBE30", VA = "0x184BDCE30")]
		public CAPEHLFBBHC(PropertyInfo GFNKMDBLDFI, Type NKJFIAEPAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCBA0", Offset = "0x4BDBBA0", VA = "0x184BDCBA0", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCD20", Offset = "0x4BDBD20", VA = "0x184BDCD20", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCC60", Offset = "0x4BDBC60", VA = "0x184BDCC60", Slot = "7")]
		public override void FDIHFHFNEDF(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCDD0", Offset = "0x4BDBDD0", VA = "0x184BDCDD0", Slot = "8")]
		public override void MCLOCMHAAHP(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCCC0", Offset = "0x4BDBCC0", VA = "0x184BDCCC0", Slot = "9")]
		public override void FNDEIHBJGGC(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BDCB40", Offset = "0x4BDBB40", VA = "0x184BDCB40", Slot = "10")]
		public override void CAMGGFFFDHO(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class AOBDKMABMIP<T> : CAPEHLFBBHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x350A000", Offset = "0x3509000", VA = "0x18350A000")]
		public AOBDKMABMIP(PropertyInfo GFNKMDBLDFI, Type NKJFIAEPAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B73490", Offset = "0x3B72490", VA = "0x183B73490", Slot = "5")]
		public override void CDGJENMFNJM(T BHBKNHMFCNN, CJLJIEMEPBC HOBDDCFEELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B73550", Offset = "0x3B72550", VA = "0x183B73550", Slot = "6")]
		public override void JBODEMHGHEN(T BHBKNHMFCNN, IHBNLNFGKDN PKFDHNAJKPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class PCPDLKCPCGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static PCPDLKCPCGH<T> AFPJCELPLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly JFGNEOMJHBC<T>[] FAPFAADEFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int NFHNKCNNLHM;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4281A90", Offset = "0x4280A90", VA = "0x184281A90")]
		public PCPDLKCPCGH(List<JFGNEOMJHBC<T>> KPABGOPKMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x42819E0", Offset = "0x42809E0", VA = "0x1842819E0")]
		public void JBODEMHGHEN(T KDEEPMDJGFD, IHBNLNFGKDN BPEIDAMPHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4281930", Offset = "0x4280930", VA = "0x184281930")]
		public void CDGJENMFNJM(T KDEEPMDJGFD, CJLJIEMEPBC AMMJOMFBDDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class KHAGOJFJOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JFGNEOMJHBC<T> HBEPMKJLJFA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private IHBNLNFGKDN HKIMEDMPJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int GAPLHGAIPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, KHAGOJFJOPO> DBEGDMDHKKH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x57291A0", Offset = "0x57281A0", VA = "0x1857291A0")]
	public GAAJEBLODMO(int EICGBLNKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28B4D50", Offset = "0x28B3D50", VA = "0x1828B4D50")]
	private PCPDLKCPCGH<T> IMCFEMMCKIO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2717A20", Offset = "0x2716A20", VA = "0x182717A20")]
	public void GGEFLGLPFBG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28B5C40", Offset = "0x28B4C40", VA = "0x1828B5C40")]
	public bool OMCMMHECHCJ<T>(CJLJIEMEPBC AMMJOMFBDDI, T AOHFGFEGDPB) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28B4CF0", Offset = "0x28B3CF0", VA = "0x1828B4CF0")]
	public void AFIENNPCBKD<T>(IHBNLNFGKDN BPEIDAMPHFE, T KDEEPMDJGFD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PDFEIJCLMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime GMDNPEJKODJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] FMOACKBLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NMLGJCHNHNE JDACOMNHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x573B170", Offset = "0x573A170", VA = "0x18573B170")]
		get
		{
			return default(NMLGJCHNHNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BJENNKJHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x573BB30", Offset = "0x573AB30", VA = "0x18573BB30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x573B1A0", Offset = "0x573A1A0", VA = "0x18573B1A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MLEIEAHMINH JPEPPDNFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x573B560", Offset = "0x573A560", VA = "0x18573B560")]
		get
		{
			return default(MLEIEAHMINH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x573BBC0", Offset = "0x573ABC0", VA = "0x18573BBC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ODGAAGMDAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x573B330", Offset = "0x573A330", VA = "0x18573B330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint FJNBDPKFMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x573B2B0", Offset = "0x573A2B0", VA = "0x18573B2B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? KPFNLNOELMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x573B360", Offset = "0x573A360", VA = "0x18573B360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? FELGDCKMEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x573B050", Offset = "0x573A050", VA = "0x18573B050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? EBEONFEGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x573B140", Offset = "0x573A140", VA = "0x18573B140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x573B960", Offset = "0x573A960", VA = "0x18573B960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? KBJDNKNPEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AD0", Offset = "0xAE5AD0", VA = "0x180AE6AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x913D50", Offset = "0x912D50", VA = "0x180913D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x573BD80", Offset = "0x573AD80", VA = "0x18573BD80")]
	public PDFEIJCLMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x573C0A0", Offset = "0x573B0A0", VA = "0x18573C0A0")]
	internal PDFEIJCLMCB(byte[] MFPMCBPILCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x573BC00", Offset = "0x573AC00", VA = "0x18573BC00")]
	public static PDFEIJCLMCB POJBPDDDALJ(byte[] MFPMCBPILCI, DateTime CGGKHMFIOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x573B590", Offset = "0x573A590", VA = "0x18573B590")]
	internal void LEGCFDLGNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x573B390", Offset = "0x573A390", VA = "0x18573B390")]
	private void JJFPAILHPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x573ADC0", Offset = "0x5739DC0", VA = "0x18573ADC0")]
	private DateTime? AOJJAJKDHNG(int NGKDOMEFDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x573B790", Offset = "0x573A790", VA = "0x18573B790")]
	private void MABFFLKDKOG(int NGKDOMEFDDB, DateTime? LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x573B1E0", Offset = "0x573A1E0", VA = "0x18573B1E0")]
	private ulong IHPILLDICAE(int NGKDOMEFDDB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x573B080", Offset = "0x573A080", VA = "0x18573B080")]
	private void EJDECAAJLGH(int NGKDOMEFDDB, ulong LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x573AFC0", Offset = "0x5739FC0", VA = "0x18573AFC0")]
	private uint CNBNLEGANKK(int NGKDOMEFDDB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5609A90", Offset = "0x5608A90", VA = "0x185609A90")]
	private static uint PFLAIMKGNDJ(uint DLGLHFDHDLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x573BB60", Offset = "0x573AB60", VA = "0x18573BB60")]
	private static ulong PFLAIMKGNDJ(ulong DLGLHFDHDLB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum NMLGJCHNHNE
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
public enum MLEIEAHMINH
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HNIJJJHNHOE
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int AIHDJEKOHGA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int EMEMEBDEHLM = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int OEKPLKOCMDH = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint GKPMGBHBJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int EIGAADDPMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int IBAOCBFDOKP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KELDDGBMHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5732260", Offset = "0x5731260", VA = "0x185732260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5732170", Offset = "0x5731170", VA = "0x185732170")]
	public bool JADFDOLIOJB(GPFGJLMNEEA HIDDFJJHELM, int DLFOHOFCHIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MBGBJMOIPLF : GPFGJLMNEEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket HIDDFJJHELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly HHECMMHOLNJ IJFMIGCKMBH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short MNIEJONPPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5739760", Offset = "0x5738760", VA = "0x185739760", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HKEOHANDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5739650", Offset = "0x5738650", VA = "0x185739650", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint DENLEKMDCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5739D60", Offset = "0x5738D60", VA = "0x185739D60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily CFINEPJBMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E08AB0", Offset = "0x3E07AB0", VA = "0x183E08AB0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5739D80", Offset = "0x5738D80", VA = "0x185739D80")]
	public MBGBJMOIPLF(AddressFamily ALPLJJEHKBC, HHECMMHOLNJ IJFMIGCKMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x57397A0", Offset = "0x57387A0", VA = "0x1857397A0", Slot = "8")]
	public bool PEIKPFILFDP(IPEndPoint JDAACDGBFKP, HOPEPGBIHOH AJBDDAGFMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5739610", Offset = "0x5738610", VA = "0x185739610", Slot = "9")]
	public int GAJGLEAIFIB(byte[] IDAJCEMIFPD, int NGKDOMEFDDB, int GFFAGBDKDAI, IPEndPoint EPNBDIJBNOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5739670", Offset = "0x5738670", VA = "0x185739670", Slot = "10")]
	public int KJGKKOMLPGF(byte[] IDAJCEMIFPD, EndPoint MGGBMILIKBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5739780", Offset = "0x5738780", VA = "0x185739780", Slot = "11")]
	public void OFONGOABAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface GPFGJLMNEEA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short MNIEJONPPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int HKEOHANDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint DENLEKMDCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily CFINEPJBMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PEIKPFILFDP(IPEndPoint JDAACDGBFKP, HOPEPGBIHOH AJBDDAGFMMI);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int GAJGLEAIFIB(byte[] IDAJCEMIFPD, int NGKDOMEFDDB, int GFFAGBDKDAI, IPEndPoint EPNBDIJBNOB);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KJGKKOMLPGF(byte[] IDAJCEMIFPD, EndPoint EPNBDIJBNOB);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFONGOABAED();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct ADBMJPDJNBA : IEquatable<ADBMJPDJNBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long AGEAGMKIKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long CEAEGBLNFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long MADPELNOACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int BBPLNCMPJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int KGJHNKFHEDO;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5727480", Offset = "0x5726480", VA = "0x185727480")]
	public ADBMJPDJNBA(byte[] GLMBIGBGDNH, int PNFCFJCJFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E88A0", Offset = "0x7E78A0", VA = "0x1807E88A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5727440", Offset = "0x5726440", VA = "0x185727440", Slot = "4")]
	public bool Equals(ADBMJPDJNBA JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5727390", Offset = "0x5726390", VA = "0x185727390", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class PNIIDCJEDAJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] NLPONMFMLIE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FJNPDEENIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int HEPMGIGGBIO;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
	protected FJNPDEENIOE(int JKGFKEICKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IJFHAMAHLKC(IPEndPoint JDAACDGBFKP, byte[] GPKMLHOONCL, int NGKDOMEFDDB, int GOKGFKKLOOJ);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JEDNOLEMIHM(IPEndPoint JDAACDGBFKP, byte[] GPKMLHOONCL, int NGKDOMEFDDB, int GOKGFKKLOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ELMEOPPJGMN : FJNPDEENIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider JEPFNLDPFII;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator ADCECCLBHFL;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5729180", Offset = "0x5728180", VA = "0x185729180")]
	public ELMEOPPJGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5728530", Offset = "0x5727530", VA = "0x185728530")]
	public void ADFLIFJPBEC(IPEndPoint JDAACDGBFKP, byte[] OHNEPKBBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5728800", Offset = "0x5727800", VA = "0x185728800")]
	public void HMJDHEPBKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5728770", Offset = "0x5727770", VA = "0x185728770")]
	private byte[] DPGFPANOFDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x57288E0", Offset = "0x57278E0", VA = "0x1857288E0", Slot = "4")]
	public override void IJFHAMAHLKC(IPEndPoint JDAACDGBFKP, byte[] GPKMLHOONCL, int NGKDOMEFDDB, int GOKGFKKLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5728D80", Offset = "0x5727D80", VA = "0x185728D80", Slot = "5")]
	public override void JEDNOLEMIHM(IPEndPoint JDAACDGBFKP, byte[] GPKMLHOONCL, int NGKDOMEFDDB, int GOKGFKKLOOJ)
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
