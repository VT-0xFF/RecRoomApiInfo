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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NPNLBEBCIBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BMJILKHHBIK
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
		private NetworkManager GPDKFHJONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, JMJJNGBJEJG> LJHJDBELLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MGLHKOFGJDN BKGOPPEFBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] HBMOFOOAAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BMJILKHHBIK JAEJBBGJMMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ELHCFMAGHJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool HIKDACFBGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x606B4F0", Offset = "0x606A6F0", VA = "0x18606B4F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x606AA80", Offset = "0x6069C80", VA = "0x18606AA80")]
		public void RecRoom_SetEncryptionInfo(ulong KNDBADIAEMH, byte[] CPBLLDDDHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x606AA60", Offset = "0x6069C60", VA = "0x18606AA60")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x606A930", Offset = "0x6069B30", VA = "0x18606A930")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x606B3F0", Offset = "0x606A5F0", VA = "0x18606B3F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x606ABA0", Offset = "0x6069DA0", VA = "0x18606ABA0", Slot = "6")]
		public override void Send(ulong HPBBJDJELKG, ArraySegment<byte> LJIEGDEDOHM, NetworkDelivery FGKGOKBIKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x606AA20", Offset = "0x6069C20", VA = "0x18606AA20", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong HPBBJDJELKG, [Out] ArraySegment<byte> EGCKKGGNFOO, [Out] float LBNLGGDNNAO)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x606AE90", Offset = "0x606A090", VA = "0x18606AE90", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x606B310", Offset = "0x606A510", VA = "0x18606B310", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x606A0F0", Offset = "0x60692F0", VA = "0x18606A0F0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong HPBBJDJELKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6069FA0", Offset = "0x60691A0", VA = "0x186069FA0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x606A290", Offset = "0x6069490", VA = "0x18606A290", Slot = "12")]
		public override ulong GetCurrentRtt(ulong HPBBJDJELKG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x606AE20", Offset = "0x606A020", VA = "0x18606AE20", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x606A330", Offset = "0x6069530", VA = "0x18606A330", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GPDKFHJONML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x606A780", Offset = "0x6069980", VA = "0x18606A780")]
		private DCCHNLODCEF MFGGGPKIFFJ(NetworkDelivery EIHDAHDDDEG)
		{
			return default(DCCHNLODCEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6069E20", Offset = "0x6069020", VA = "0x186069E20", Slot = "15")]
		private void DFLEKMHKDCK(JMJJNGBJEJG LAAMGLCFDJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6069EE0", Offset = "0x60690E0", VA = "0x186069EE0", Slot = "16")]
		private void DGLBFHGGDGJ(JMJJNGBJEJG LAAMGLCFDJO, KDKJECELBPG GANACDICHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "17")]
		private void PHFABPEFEKF(IPEndPoint DAHLFLPLKGO, SocketError ANLCFIHPKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x606A570", Offset = "0x6069770", VA = "0x18606A570", Slot = "18")]
		private void MFBLHIFGMAK(JMJJNGBJEJG LAAMGLCFDJO, JIBEHMNLPEM IDGMLEGKFGC, byte KJOOGCGGCHD, DCCHNLODCEF JAPJPIODHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x606A850", Offset = "0x6069A50", VA = "0x18606A850")]
		private void NLPGOMPIAOK(int JAICOMOJIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "19")]
		private void FIPFANGNDGM(IPEndPoint JPODFMICAIM, JIBEHMNLPEM IDGMLEGKFGC, DPDDFCNMPDK HOPMJJMJBFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "20")]
		private void DHNIMBFEKDP(JMJJNGBJEJG LAAMGLCFDJO, int LIDJHLPOCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x606A510", Offset = "0x6069710", VA = "0x18606A510", Slot = "21")]
		private void LHKHGPHPNON(FIGDNAGCEOK LGIKLBJKNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x606A260", Offset = "0x6069460", VA = "0x18606A260")]
		private ulong EEGHNHODOOH(JMJJNGBJEJG LAAMGLCFDJO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x606A4F0", Offset = "0x60696F0", VA = "0x18606A4F0")]
		private static int JIPHFMDFDOD(float NPIKCMPEMNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x606B410", Offset = "0x606A610", VA = "0x18606B410")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CPEBDFEMNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly JMJJNGBJEJG CADLANCEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<JKKGMDDOGFM> OHPDFCJFLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int MICCHFAEIFJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x605F8C0", Offset = "0x605EAC0", VA = "0x18605F8C0")]
	protected CPEBDFEMNJC(JMJJNGBJEJG LAAMGLCFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x605F820", Offset = "0x605EA20", VA = "0x18605F820")]
	public void ECNJILJAMCJ(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x605F7A0", Offset = "0x605E9A0", VA = "0x18605F7A0")]
	protected void CEJCIBHKMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x605F880", Offset = "0x605EA80", VA = "0x18605F880")]
	public bool NIKGAMDBPIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool HIKILPJCGDF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool POJDABCONDK(JKKGMDDOGFM CLDNMMCBJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BELMBHNKPEF
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
public class FIGDNAGCEOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MGLHKOFGJDN MPECLJCNPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int ELBOHJNOPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OAKDOFMGDGF ICKGAEKIFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint MKFKNCNNFGH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BELMBHNKPEF ILLIBKDLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BD900", Offset = "0x8BCB00", VA = "0x1808BD900")]
		[CompilerGenerated]
		get
		{
			return default(BELMBHNKPEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD92360", Offset = "0xD91560", VA = "0x180D92360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60628F0", Offset = "0x6061AF0", VA = "0x1860628F0")]
	internal void EHCAHPODECA(OAKDOFMGDGF EPEMMPLKCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60628C0", Offset = "0x6061AC0", VA = "0x1860628C0")]
	private bool BMHLKBDIPAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60629B0", Offset = "0x6061BB0", VA = "0x1860629B0")]
	internal FIGDNAGCEOK(IPEndPoint JPODFMICAIM, OAKDOFMGDGF JMFFIPDAPGI, MGLHKOFGJDN LFJEHCDEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6062950", Offset = "0x6061B50", VA = "0x186062950")]
	public JMJJNGBJEJG GNLFLEMDJEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DPDDFCNMPDK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EPBGFNJFGBO
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
public struct KDKJECELBPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public EPBGFNJFGBO DLMMDCDNGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError LLIPPMHEDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JIBEHMNLPEM IKHOLFEFICG;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPNLBEBCIBH
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGKCKPDDIGA(JMJJNGBJEJG LAAMGLCFDJO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPNBFMHPFPB(JMJJNGBJEJG LAAMGLCFDJO, KDKJECELBPG GANACDICHGL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGKLICBJAKG(IPEndPoint DAHLFLPLKGO, SocketError ANLCFIHPKGN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPHNFJDDFNO(JMJJNGBJEJG LAAMGLCFDJO, JIBEHMNLPEM IDGMLEGKFGC, byte KJOOGCGGCHD, DCCHNLODCEF JAPJPIODHIF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEDFDKMCJJI(IPEndPoint JPODFMICAIM, JIBEHMNLPEM IDGMLEGKFGC, DPDDFCNMPDK HOPMJJMJBFK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGKCEJMJOBH(JMJJNGBJEJG LAAMGLCFDJO, int LIDJHLPOCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJOBDNGIELP(FIGDNAGCEOK LGIKLBJKNEM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DNPCOHGODPK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGAIBALNOFP(JMJJNGBJEJG LAAMGLCFDJO, object OPKOIMHEIFO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HBHEGPFGHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOIDDPIAJOL(EGBMLNAOCPB CLDNMMCBJOD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MMIJKNANNPL
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMDBCIBMJKF(JMJJNGBJEJG LAAMGLCFDJO, IPEndPoint EEBKGALAIJM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OAKDOFMGDGF
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int LEMNBMFOBOE = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long BPJOLDHILNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte MMGNJBFIJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] DDJGNDLOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IDOAANBGOOP OMAPODLEEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int AJBCHAADCKI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60743B0", Offset = "0x60735B0", VA = "0x1860743B0")]
	private OAKDOFMGDGF(long CLEAIEIPFLN, byte KBMDONLGFCD, int HHKIGJBGGKF, byte[] ADGOMPBEOFD, IDOAANBGOOP LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6074350", Offset = "0x6073550", VA = "0x186074350")]
	public static int PIMGGOOEHLL(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6073F50", Offset = "0x6073150", VA = "0x186073F50")]
	public static OAKDOFMGDGF CKOOPNFLGFG(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6074170", Offset = "0x6073370", VA = "0x186074170")]
	public static JKKGMDDOGFM FINFABOBDFF(MCFHHMFNFDI NHEDALCGFAJ, SocketAddress HLLIAOPKFEI, long MJAKHGCOJJI, int HHKIGJBGGKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class DFDCOCMMJMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long BPJOLDHILNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte MMGNJBFIJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int AJBCHAADCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool MBKAMENMOBB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x605FCA0", Offset = "0x605EEA0", VA = "0x18605FCA0")]
	private DFDCOCMMJMB(long CLEAIEIPFLN, byte KBMDONLGFCD, int HPKNKCALLGM, bool GHMPEGDCABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x605F960", Offset = "0x605EB60", VA = "0x18605F960")]
	public static DFDCOCMMJMB CKOOPNFLGFG(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x605FAB0", Offset = "0x605ECB0", VA = "0x18605FAB0")]
	public static JKKGMDDOGFM FINFABOBDFF(long MJAKHGCOJJI, byte ADJKAPDDPHC, int AFHMBGBAEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x605FBA0", Offset = "0x605EDA0", VA = "0x18605FBA0")]
	public static JKKGMDDOGFM NGHHHPKADLI(JMJJNGBJEJG LAAMGLCFDJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DFDGJBCANDA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MNBCPLBPEHD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFIILIPOEKO(IPEndPoint IAMEDLMHBLN, IPEndPoint JPODFMICAIM, string NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJNLIALNBNL(IPEndPoint GFKDGJFMFOH, DFDGJBCANDA EIHDAHDDDEG, string NIOIDOPDJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HPIEFHDMHDM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JODEFLELIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint JKAJIPEPPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint MKFKNCNNFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string HKBIDKOHGID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BHHOGCLOOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint GIBKCBAMHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DFDGJBCANDA DGMPJMIJKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string HKBIDKOHGID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class EKKDDKCBBBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint GOEHCKMJFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string HKBIDKOHGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EKKDDKCBBBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PMENCFKFBIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GOEHCKMJFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint CMIMPBMLGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string HKBIDKOHGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public PMENCFKFBIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class GFBKPNJKIGA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HKBIDKOHGID
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DPCAAGEOCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x899F30", Offset = "0x899130", VA = "0x180899F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GFBKPNJKIGA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MGLHKOFGJDN BENEKJMHGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<JODEFLELIBN> GDLPKEINJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BHHOGCLOOAM> ELJAOHKEDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IDOAANBGOOP LEEEAJNNIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MCFHHMFNFDI KLNKJNGDMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DODBKCDDPFA FFGDBEEOFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MNBCPLBPEHD DKDGOOOIMHE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int IEHMKOGDKOI = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HDELEMPEHGE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60637D0", Offset = "0x60629D0", VA = "0x1860637D0")]
	internal HPIEFHDMHDM(MGLHKOFGJDN OBJOJDEEBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60631D0", Offset = "0x60623D0", VA = "0x1860631D0")]
	internal void HEIAIOJGBOO(IPEndPoint EEEDLEMOAJA, JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E38E70", Offset = "0x2E38070", VA = "0x182E38E70")]
	private void BMCLHNPMEKP<T>(T CLDNMMCBJOD, IPEndPoint LCMBJJGJCLO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6063640", Offset = "0x6062840", VA = "0x186063640")]
	private void PFIILIPOEKO(EKKDDKCBBBL LCKMJLLJJMJ, IPEndPoint EEEDLEMOAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60634E0", Offset = "0x60626E0", VA = "0x1860634E0")]
	private void NMGLMPFNPPD(PMENCFKFBIG LCKMJLLJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6063350", Offset = "0x6062550", VA = "0x186063350")]
	private void MHAHBDBDAKG(GFBKPNJKIGA LCKMJLLJJMJ, IPEndPoint EEEDLEMOAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DCCHNLODCEF : byte
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
public enum FDILPGAJHBN : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FMEHBOAFMDO
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] EGFFAIOKKBH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int POIIOCBJAKP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HIECBBABKBF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FNMCKMMEGKC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x605EFE0", Offset = "0x605E1E0", VA = "0x18605EFE0")]
	public FNMCKMMEGKC(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BGIJCICINKI : FNMCKMMEGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x605EFE0", Offset = "0x605E1E0", VA = "0x18605EFE0")]
	public BGIJCICINKI(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FAKKONDCJOJ
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
public interface KKHCCPNLOJO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPLANDDNPMC(FAKKONDCJOJ PFEKJKNNANJ, string JGFIBJEOOPG, params object[] KLDEANCBDEG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KOJPKPAKICG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static KKHCCPNLOJO CBMNIBGALGI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object KDILLAAFFHK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6069A20", Offset = "0x6068C20", VA = "0x186069A20")]
	private static void BLKLPKACGDL(FAKKONDCJOJ ECKJKFJLCOM, string JGFIBJEOOPG, params object[] KLDEANCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6069CB0", Offset = "0x6068EB0", VA = "0x186069CB0")]
	internal static void LFCLBIKFNCE(string JGFIBJEOOPG, params object[] KLDEANCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6069C50", Offset = "0x6068E50", VA = "0x186069C50")]
	internal static void GOJPAABFFNJ(string JGFIBJEOOPG, params object[] KLDEANCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6069D10", Offset = "0x6068F10", VA = "0x186069D10")]
	internal static void MBIKOKKNFEN(string JGFIBJEOOPG, params object[] KLDEANCBDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum OOCNIGLJNKI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JIBEHMNLPEM : IDOAANBGOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JKKGMDDOGFM CJCJJLBOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MGLHKOFGJDN ENGKDFKKMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JIIDMFBDLLL AMIIPEOJHKM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6064BC0", Offset = "0x6063DC0", VA = "0x186064BC0")]
	internal JIBEHMNLPEM(MGLHKOFGJDN CAKLHAFGFAN, JIIDMFBDLLL BCAJFLJCEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6064B20", Offset = "0x6063D20", VA = "0x186064B20")]
	internal void OFEHPKLMJFH(JKKGMDDOGFM CLDNMMCBJOD, int OEFFGGHJEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6064AA0", Offset = "0x6063CA0", VA = "0x186064AA0")]
	internal void BJIBAKCMBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6064B90", Offset = "0x6063D90", VA = "0x186064B90")]
	public void PAHBODGIHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JIIDMFBDLLL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ELLMFBJGCGB
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
	public JIIDMFBDLLL KDADLGIOJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public ELLMFBJGCGB DGMPJMIJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JMJJNGBJEJG CADLANCEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint MKFKNCNNFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object KFECDPLBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int BPCONJHFOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError MDLLENIBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public EPBGFNJFGBO HCKLMPBHCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public FIGDNAGCEOK BDIEIPGBPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public DCCHNLODCEF GJEJPILHCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte FNEDHJHNHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly JIBEHMNLPEM POAKKHEBJLJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6064C10", Offset = "0x6063E10", VA = "0x186064C10")]
	public JIIDMFBDLLL(MGLHKOFGJDN CAKLHAFGFAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MGLHKOFGJDN : IEnumerable<JMJJNGBJEJG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class HOGEOFLAFNB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6063160", Offset = "0x6062360", VA = "0x186063160", Slot = "4")]
		public bool Equals(IPEndPoint AKHPALIKFFK, IPEndPoint PGLPHKNNCEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5B594B0", Offset = "0x5B586B0", VA = "0x185B594B0", Slot = "5")]
		public int GetHashCode(IPEndPoint JMJAOKJJFGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HOGEOFLAFNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct IOJBFMHDDAF : IEnumerator<JMJJNGBJEJG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly JMJJNGBJEJG MDAHEKCCBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JMJJNGBJEJG DEFMIIHMGHG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JMJJNGBJEJG HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD10", Offset = "0x8FAF10", VA = "0x1808FBD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD10", Offset = "0x8FAF10", VA = "0x1808FBD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x13ADC30", Offset = "0x13ACE30", VA = "0x1813ADC30")]
		public IOJBFMHDDAF(JMJJNGBJEJG HBNAJMHMLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6064880", Offset = "0x6063A80", VA = "0x186064880", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60648D0", Offset = "0x6063AD0", VA = "0x1860648D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread INHBHNJMHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool OCCFMOHPEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent JLJDEOAMBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JIIDMFBDLLL> JGEABOILMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JIIDMFBDLLL> HKFDFANPALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JIIDMFBDLLL KJFEFGFPLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NPNLBEBCIBH KPBNEALOLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly DNPCOHGODPK KFEDCIOIJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HBHEGPFGHEF EPFJAFJFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MMIJKNANNPL OGKKBAMJHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, JMJJNGBJEJG> JBCPLCILGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, FIGDNAGCEOK> EMDBPLPANAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, GKJLEMIMIDP> HNFLDCJPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JFDIFDJFGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JMJJNGBJEJG HIGMFLANLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int IGMPFKBHJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<JMJJNGBJEJG> MNFCBFIKKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JMJJNGBJEJG[] NNAJDBJGNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CFNHJNJOHDL NCIFEODKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int GPHNLADACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> KEKFGLPFKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte LLNPJGJNIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object GMJCIAJCCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool JJNEFELDOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool PIDBIJKAPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BOBJCJNIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int JDKGPGEKDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MKGCHEMOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int MDMAJOBIPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool AHDLKOLMCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool IJCDPHADNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GEFHANLAAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int AECFAOMBPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int KMJMFIPBFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HDELEMPEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool MIBNMKBFABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MHDHBFHOAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HMBAFCCFCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int BOMEAEOIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HAAPMJJNFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EEAEGKBEMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly BMNOPABJICA OAFMFDMNDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool AOPCLEFCBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HPIEFHDMHDM MCAINIKHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LGONAMADEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public OOCNIGLJNKI FFAOCDKONBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int GBGJOFBIOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NDLDCOECHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool HIBNLJGHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KBGCGKNBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool EBNIKOCOLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private JKKGMDDOGFM AFBNDDLKGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int DOIADNKPFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object LFDJFADKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private JKKGMDDOGFM MKPFFAIBNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int GMPFAGGOBKA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int GEKGNJONDKD = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int COBEEKKPJKN = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OIFOOKIAMCN AKBEFDEFMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private OIFOOKIAMCN PNPDJJHPLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread PLAODKNBJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NJMOHJNELGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CCIPFEGGGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint EFEALJBLILL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] PAIIMOPIBHF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] POHJLKKPAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<ONBBGFFCNMN, IPEndPoint> HNJMNJODMHA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress CKNIOMJPHMP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MMEOICBGAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int LABANBIAMNC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DOKOEBLMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE9D4D0", Offset = "0xE9C6D0", VA = "0x180E9D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xF45B80", Offset = "0xF44D80", VA = "0x180F45B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JBEPIHGMPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1959990", Offset = "0x1958B90", VA = "0x181959990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1C984A0", Offset = "0x1C976A0", VA = "0x181C984A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte CLIENDDLGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xCA93F0", Offset = "0xCA85F0", VA = "0x180CA93F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NNJHIHJOONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6071FA0", Offset = "0x60711A0", VA = "0x186071FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FNGMGFAEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x606ECE0", Offset = "0x606DEE0", VA = "0x18606ECE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x606D060", Offset = "0x606C260", VA = "0x18606D060")]
	public void CNMCMDNLFNJ(IPEndPoint DAHLFLPLKGO, byte[] CPBLLDDDHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x606C350", Offset = "0x606B550", VA = "0x18606C350")]
	public void ABPOEOILCCM(IPEndPoint DAHLFLPLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6070330", Offset = "0x606F530", VA = "0x186070330")]
	private bool JMNHEHPLFOL(IPEndPoint DAHLFLPLKGO, [Out] JMJJNGBJEJG LAAMGLCFDJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6072840", Offset = "0x6071A40", VA = "0x186072840")]
	private void OPNBEALBHOG(JMJJNGBJEJG LAAMGLCFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x606D300", Offset = "0x606C500", VA = "0x18606D300")]
	private void EJPDBFKDDKK(JMJJNGBJEJG LAAMGLCFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x606EA70", Offset = "0x606DC70", VA = "0x18606EA70")]
	private void HHLGPPFLCGE(JMJJNGBJEJG LAAMGLCFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6073060", Offset = "0x6072260", VA = "0x186073060")]
	public MGLHKOFGJDN(NPNLBEBCIBH LFJEHCDEGID, [Optional] CFNHJNJOHDL CDNLAABLGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x606C4A0", Offset = "0x606B6A0", VA = "0x18606C4A0")]
	internal void ANPADCDGNBJ(JMJJNGBJEJG NHKLPPAOKAH, int LIDJHLPOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6071DE0", Offset = "0x6070FE0", VA = "0x186071DE0")]
	internal void MGBHCLKPNFP(JMJJNGBJEJG NHKLPPAOKAH, object OPKOIMHEIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6072770", Offset = "0x6071970", VA = "0x186072770")]
	internal void OLOCMPCHDEJ(JMJJNGBJEJG LAAMGLCFDJO, EPBGFNJFGBO HJGNFPCEHLP, SocketError FMCEAGBBPID, JKKGMDDOGFM LCGCLNOIDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6072510", Offset = "0x6071710", VA = "0x186072510")]
	private void NMHINPBLCBJ(JMJJNGBJEJG LAAMGLCFDJO, EPBGFNJFGBO HJGNFPCEHLP, SocketError FMCEAGBBPID, bool PLHFEDHICDP, byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int NDEFEFEFLCE, JKKGMDDOGFM LCGCLNOIDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6070F90", Offset = "0x6070190", VA = "0x186070F90")]
	private void KLHCMLENOJO(JIIDMFBDLLL.ELLMFBJGCGB EIHDAHDDDEG, [Optional] JMJJNGBJEJG LAAMGLCFDJO, [Optional] IPEndPoint JPODFMICAIM, SocketError KHDINAFJCNH = SocketError.Success, int LIDJHLPOCDJ = 0, EPBGFNJFGBO BAMNNMLDCNB = EPBGFNJFGBO.ConnectionFailed, [Optional] FIGDNAGCEOK KKHPGOFFDDA, DCCHNLODCEF JAPJPIODHIF = DCCHNLODCEF.Unreliable, byte KJOOGCGGCHD = 0, [Optional] JKKGMDDOGFM KFNBIFOABBN, [Optional] object OPKOIMHEIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x606DD30", Offset = "0x606CF30", VA = "0x18606DD30")]
	private void GNBFJLHBKHE(JIIDMFBDLLL BCAJFLJCEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x606DA00", Offset = "0x606CC00", VA = "0x18606DA00")]
	internal void FGOLOJANELF(JIIDMFBDLLL BCAJFLJCEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6071FC0", Offset = "0x60711C0", VA = "0x186071FC0")]
	private void NFIPJIAAKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x606D6E0", Offset = "0x606C8E0", VA = "0x18606D6E0")]
	private void EONHHPKBHFC(int PMAKBDJNHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6070970", Offset = "0x606FB70", VA = "0x186070970")]
	internal JMJJNGBJEJG KEKEDOAJPBF(FIGDNAGCEOK LGIKLBJKNEM, byte[] GFLKMCMHOIO, int NJJFLJLDLKI, int KOHJFMFCHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x606D280", Offset = "0x606C480", VA = "0x18606D280")]
	private int DFGPFJCPJAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x606E5E0", Offset = "0x606D7E0", VA = "0x18606E5E0")]
	private void HGGFNNFCMNH(IPEndPoint JPODFMICAIM, JMJJNGBJEJG HLIADEAHOJF, OAKDOFMGDGF HDLLGPDBLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x606EDA0", Offset = "0x606DFA0", VA = "0x18606EDA0")]
	private void JBDEJKJPKCB(JKKGMDDOGFM CLDNMMCBJOD, IPEndPoint JPODFMICAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6070690", Offset = "0x606F890", VA = "0x186070690")]
	internal void JPLFCKOHIEN(JKKGMDDOGFM CLDNMMCBJOD, DCCHNLODCEF HMFENIGMBOJ, byte KJOOGCGGCHD, int OEFFGGHJEPD, JMJJNGBJEJG NHKLPPAOKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6071CD0", Offset = "0x6070ED0", VA = "0x186071CD0")]
	public bool LJGFOBFFBED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6071D40", Offset = "0x6070F40", VA = "0x186071D40")]
	public bool LJGFOBFFBED(IPAddress KNPDNFMPDPG, IPAddress INKLKBKJKCP, int EOAIGCCJHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6071D60", Offset = "0x6070F60", VA = "0x186071D60")]
	public bool LJGFOBFFBED(int EOAIGCCJHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6071370", Offset = "0x6070570", VA = "0x186071370")]
	public void LFMNCDHGFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x606FB60", Offset = "0x606ED60", VA = "0x18606FB60")]
	public JMJJNGBJEJG JGBDOGLDOBI(string ADCIGFAONIK, int EOAIGCCJHHM, string CPBLLDDDHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x606FC40", Offset = "0x606EE40", VA = "0x18606FC40")]
	public JMJJNGBJEJG JGBDOGLDOBI(string ADCIGFAONIK, int EOAIGCCJHHM, MCFHHMFNFDI CGAIAKAMDEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x606FD20", Offset = "0x606EF20", VA = "0x18606FD20")]
	public JMJJNGBJEJG JGBDOGLDOBI(IPEndPoint LCMBJJGJCLO, MCFHHMFNFDI CGAIAKAMDEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6072E70", Offset = "0x6072070", VA = "0x186072E70")]
	public void PNAEENCKMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6072B20", Offset = "0x6071D20", VA = "0x186072B20")]
	public void PNAEENCKMLL(bool HKOKBAOELKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x606DB10", Offset = "0x606CD10", VA = "0x18606DB10")]
	public void FIBCDBGAKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x606DC10", Offset = "0x606CE10", VA = "0x18606DC10")]
	public void FIBCDBGAKKE(byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6072600", Offset = "0x6071800", VA = "0x186072600")]
	public void NMHINPBLCBJ(JMJJNGBJEJG LAAMGLCFDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60726B0", Offset = "0x60718B0", VA = "0x1860726B0")]
	public void NMHINPBLCBJ(JMJJNGBJEJG LAAMGLCFDJO, byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6072E80", Offset = "0x6072080", VA = "0x186072E80", Slot = "4")]
	private IEnumerator<JMJJNGBJEJG> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6072F10", Offset = "0x6072110", VA = "0x186072F10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x606CDA0", Offset = "0x606BFA0", VA = "0x18606CDA0")]
	private JKKGMDDOGFM BBBCOBAHEFF(BBNMMPNCAJL BAEKDMBADGA, int JAICOMOJIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x606CE80", Offset = "0x606C080", VA = "0x18606CE80")]
	private JKKGMDDOGFM BBBCOBAHEFF(BBNMMPNCAJL BAEKDMBADGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60700F0", Offset = "0x606F2F0", VA = "0x1860700F0")]
	internal JKKGMDDOGFM JJLMJPEOOPF(int JAICOMOJIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x606C4F0", Offset = "0x606B6F0", VA = "0x18606C4F0")]
	internal void BAAHBMMLPCM(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6072FA0", Offset = "0x60721A0", VA = "0x186072FA0")]
	static MGLHKOFGJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE9D4D0", Offset = "0xE9C6D0", VA = "0x180E9D4D0")]
	private bool GAJGBHCNAPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x606E4D0", Offset = "0x606D6D0", VA = "0x18606E4D0")]
	private void HBPJHIFOHOL(IPEndPoint NKHAIGDMHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x606CF60", Offset = "0x606C160", VA = "0x18606CF60")]
	private void BFNNHEPOOOC(IPEndPoint NKHAIGDMHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6072360", Offset = "0x6071560", VA = "0x186072360")]
	private bool NLBHDFKFBGD(SocketException JIAKIFPLAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60703C0", Offset = "0x606F5C0", VA = "0x1860703C0")]
	private void JOJJDMACKJL(OIFOOKIAMCN OBJOJDEEBHO, EndPoint HJPCCOBODJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x606D350", Offset = "0x606C550", VA = "0x18606D350")]
	private void ENJGPLEANLC(object NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6071520", Offset = "0x6070720", VA = "0x186071520")]
	public bool LJGFOBFFBED(IPAddress KNPDNFMPDPG, IPAddress INKLKBKJKCP, int EOAIGCCJHHM, bool IADAPDAHCPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6072300", Offset = "0x6071500", VA = "0x186072300")]
	internal int NKONEPNMDDM(JKKGMDDOGFM CLDNMMCBJOD, IPEndPoint JPODFMICAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x606C750", Offset = "0x606B950", VA = "0x18606C750")]
	internal int BANJPKINFJA(JKKGMDDOGFM CLDNMMCBJOD, IPEndPoint JPODFMICAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x606C790", Offset = "0x606B990", VA = "0x18606C790")]
	internal int BANJPKINFJA(byte[] ADNFLGLLNKI, int NJJFLJLDLKI, int KOHJFMFCHKH, IPEndPoint JPODFMICAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6071E30", Offset = "0x6071030", VA = "0x186071E30")]
	internal void MKNBNONFJBL(bool PNKNJNGEGFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum BBNMMPNCAJL : byte
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
internal sealed class JKKGMDDOGFM
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int NFBKCJMIGGC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] HFDMFDOMFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] HPHMLCALPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int NCANLJNAAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object KFECDPLBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public JKKGMDDOGFM KDADLGIOJFB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BBNMMPNCAJL PMLJKHBIJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60652A0", Offset = "0x60644A0", VA = "0x1860652A0")]
		get
		{
			return default(BBNMMPNCAJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60650F0", Offset = "0x60642F0", VA = "0x1860650F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MMGNJBFIJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6064EF0", Offset = "0x60640F0", VA = "0x186064EF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6064CE0", Offset = "0x6063EE0", VA = "0x186064CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort EGKKBPIBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6064FB0", Offset = "0x60641B0", VA = "0x186064FB0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6064EB0", Offset = "0x60640B0", VA = "0x186064EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DMGPAOMKDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6064F20", Offset = "0x6064120", VA = "0x186064F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte KCOEHEIFOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6065270", Offset = "0x6064470", VA = "0x186065270")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6064CB0", Offset = "0x6063EB0", VA = "0x186064CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort KDLJBKEAGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6065090", Offset = "0x6064290", VA = "0x186065090")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6065050", Offset = "0x6064250", VA = "0x186065050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort IMCHKEMKCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6064D20", Offset = "0x6063F20", VA = "0x186064D20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6065010", Offset = "0x6064210", VA = "0x186065010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort INDOMNLBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6064F50", Offset = "0x6064150", VA = "0x186064F50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6065230", Offset = "0x6064430", VA = "0x186065230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60652D0", Offset = "0x60644D0", VA = "0x1860652D0")]
	static JKKGMDDOGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6064D80", Offset = "0x6063F80", VA = "0x186064D80")]
	public void CPBIJCGKMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6065590", Offset = "0x6064790", VA = "0x186065590")]
	public JKKGMDDOGFM(int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6065600", Offset = "0x6064800", VA = "0x186065600")]
	public JKKGMDDOGFM(BBNMMPNCAJL BAEKDMBADGA, int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6065130", Offset = "0x6064330", VA = "0x186065130")]
	public static int LGLGDGJNMDL(BBNMMPNCAJL BAEKDMBADGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60651A0", Offset = "0x60643A0", VA = "0x1860651A0")]
	public int LGLGDGJNMDL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6064DB0", Offset = "0x6063FB0", VA = "0x186064DB0")]
	public bool DLOEPNOBKCN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum LBGPOOOHGPH : byte
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
internal enum AEFECEJHJCO
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
internal enum OPLHDDOPCFH
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum HFBJCMFFEHK
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JMJJNGBJEJG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class OPGHJOIMNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JKKGMDDOGFM[] GDPCLBGCKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int FOIKPNJBHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int IBJHFDEJEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte KCOEHEIFOGE;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OPGHJOIMNHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void NBBEJIDPAKI(ulong LJFCNNGBBCP, int HIMCBGFHEMN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CCIAJJGKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int ANKAOFABLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DBKHMMFPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double ABOPAKFCCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BDHLFPNPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int AOEBHOCPMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int IGHNJANBEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch PCHKDMNPNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DPOHKBIPLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long JCAMDKMGBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object NIELGBAFBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal JMJJNGBJEJG KIENLJPKOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal JMJJNGBJEJG ICFIILAHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<JKKGMDDOGFM> NPOCLFEOOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CPEBDFEMNJC> FLHHDHIOKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CPEBDFEMNJC[] MOLNLGPDLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int JOHLMKIDCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int MIMOCLAAKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool NBIJGGHGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int IGABBBLELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int PPOBPCDFKHP;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DLLAPGLHOBK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int IENMMMFCKFF = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object JPPBBFCNCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int HPBBEPJPFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, OPGHJOIMNHD> HJCEOIJFHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CENBAIBBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly JKKGMDDOGFM IHFBGPIPHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int JGNICFLFBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int IMLGIBDCGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint OIDPILAKKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int GOGINMBBAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int OGPOENPAOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long NFAAKJEKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BHDELFKMING;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private LBGPOOOHGPH APFIKIEOHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JKKGMDDOGFM FNLBNLJIANG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int CAPEMIAEKGN = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IOBKOFHCGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly JKKGMDDOGFM PGHGPILLBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly JKKGMDDOGFM CHHKONLDMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly JKKGMDDOGFM BEFIMMHJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly JKKGMDDOGFM NKKFIDJLLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FDILPGAJHBN ILEFDICLFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly MGLHKOFGJDN FBPAOPEDOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int CCBOBDNNGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object EJJPJGMAEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly BMNOPABJICA OAFMFDMNDPM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte LCLHECPBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB67720", Offset = "0xB66920", VA = "0x180B67720")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6068A90", Offset = "0x6067C90", VA = "0x186068A90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint AECJAKIHLLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EDFC0", Offset = "0x8ED1C0", VA = "0x1808EDFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LBGPOOOHGPH FAONHANGHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x15FC020", Offset = "0x15FB220", VA = "0x1815FC020")]
		get
		{
			return default(LBGPOOOHGPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long OGIDNJKEGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x899440", Offset = "0x898640", VA = "0x180899440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KNELLHNPCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xF88020", Offset = "0xF87220", VA = "0x180F88020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1892AF0", Offset = "0x1891CF0", VA = "0x181892AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int AAJHKMPKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6066C30", Offset = "0x6065E30", VA = "0x186066C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ANBIEADAHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5090", Offset = "0x8A4290", VA = "0x1808A5090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double IFAIGLMEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4493F00", Offset = "0x4493100", VA = "0x184493F00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NBBEJIDPAKI EEOJDHFDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60689E0", Offset = "0x6067BE0", VA = "0x1860689E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6067DE0", Offset = "0x6066FE0", VA = "0x186067DE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x60695D0", Offset = "0x60687D0", VA = "0x1860695D0")]
	internal JMJJNGBJEJG(MGLHKOFGJDN GEHNKKAJDKI, IPEndPoint JPODFMICAIM, int MHMAFIBKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60666C0", Offset = "0x60658C0", VA = "0x1860666C0")]
	internal void CJEDLKHIBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60686F0", Offset = "0x60678F0", VA = "0x1860686F0")]
	internal void NLDLGNJFGKM(IPEndPoint ECEAMPDIHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60671A0", Offset = "0x60663A0", VA = "0x1860671A0")]
	internal void GBJEODLGMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6065710", Offset = "0x6064910", VA = "0x186065710")]
	private void AIEEDGPBGIB(int BGOGAKNPMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6066680", Offset = "0x6065880", VA = "0x186066680")]
	private void CIOLKJLNLDF(int BLIOPEGMLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6068540", Offset = "0x6067740", VA = "0x186068540")]
	private CPEBDFEMNJC LLLFKAEAEDA(byte JJIKJNIEJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6069440", Offset = "0x6068640", VA = "0x186069440")]
	internal JMJJNGBJEJG(MGLHKOFGJDN GEHNKKAJDKI, IPEndPoint JPODFMICAIM, int MHMAFIBKDFF, byte ADJKAPDDPHC, MCFHHMFNFDI NHEDALCGFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6069260", Offset = "0x6068460", VA = "0x186069260")]
	internal JMJJNGBJEJG(MGLHKOFGJDN GEHNKKAJDKI, FIGDNAGCEOK LGIKLBJKNEM, int MHMAFIBKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6067B20", Offset = "0x6066D20", VA = "0x186067B20")]
	internal void GJMJABHBBFH(OAKDOFMGDGF EMPLIBDFNKE, byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6068090", Offset = "0x6067290", VA = "0x186068090")]
	internal bool LBFBCHCKHMP(DFDCOCMMJMB CLDNMMCBJOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x60662C0", Offset = "0x60654C0", VA = "0x1860662C0")]
	public void BMCLHNPMEKP(byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int KOHJFMFCHKH, DCCHNLODCEF PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6066C40", Offset = "0x6065E40", VA = "0x186066C40")]
	private void EBEKLAEBCAK(byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int KOHJFMFCHKH, byte KJOOGCGGCHD, DCCHNLODCEF JAPJPIODHIF, object OPKOIMHEIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6067D30", Offset = "0x6066F30", VA = "0x186067D30")]
	public void JEGJEMOENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6068420", Offset = "0x6067620", VA = "0x186068420")]
	internal OPLHDDOPCFH LHJAKBFFGGD(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return default(OPLHDDOPCFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6068B40", Offset = "0x6067D40", VA = "0x186068B40")]
	internal void PLIKCKNEOEO(CPEBDFEMNJC EAMAODJNFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6068110", Offset = "0x6067310", VA = "0x186068110")]
	internal HFBJCMFFEHK LCMKKAECBFG(byte[] LJIEGDEDOHM, int NJJFLJLDLKI, int KOHJFMFCHKH, bool PLHFEDHICDP)
	{
		return default(HFBJCMFFEHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6068500", Offset = "0x6067700", VA = "0x186068500")]
	private void LKIJOKHHNDE(int DEAKOLNCDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60657E0", Offset = "0x60649E0", VA = "0x1860657E0")]
	internal void BDJAKCBPJGH(DCCHNLODCEF HMFENIGMBOJ, JKKGMDDOGFM HBNAJMHMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x60666E0", Offset = "0x60658E0", VA = "0x1860666E0")]
	private void COOJGLPLCOC(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x60662F0", Offset = "0x60654F0", VA = "0x1860662F0")]
	private void BNFNMOPAFKA(int GCFLAEHGPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6067B70", Offset = "0x6066D70", VA = "0x186067B70")]
	internal AEFECEJHJCO HGGFNNFCMNH(OAKDOFMGDGF HDLLGPDBLJI)
	{
		return default(AEFECEJHJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6068BA0", Offset = "0x6067DA0", VA = "0x186068BA0")]
	internal void POJDABCONDK(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6066170", Offset = "0x6065370", VA = "0x186066170")]
	private void BKJPIFPLNOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6067E90", Offset = "0x6067090", VA = "0x186067E90")]
	internal void KOKOHCDGCHK(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6067230", Offset = "0x6066430", VA = "0x186067230")]
	internal void GEGAIMNPNFH(int GCFLAEHGPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6068720", Offset = "0x6067920", VA = "0x186068720")]
	internal void NMGNPEBFODM(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BMNOPABJICA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long FEJHBEAINBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long KMFHCKGIIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long LGMLHNGPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long GEJAICDKFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long LDLPDFMJMCH;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long JDLFIHPNCFH;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long DGHCNOEIGJK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long OBFNDGAFINK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long JILLELBDDPE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long KHKEJELBNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JFBNPEGHFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GOKDDOKNKGB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long KMGFOIDGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x605F2D0", Offset = "0x605E4D0", VA = "0x18605F2D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long NPCJCGCONHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x605F260", Offset = "0x605E460", VA = "0x18605F260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long CGDAOHPOFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x605F140", Offset = "0x605E340", VA = "0x18605F140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EGCAKMKFMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x605F330", Offset = "0x605E530", VA = "0x18605F330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long KMNEEFCEFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x605F0D0", Offset = "0x605E2D0", VA = "0x18605F0D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IEPLMJDENAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x605F250", Offset = "0x605E450", VA = "0x18605F250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long MALCEGLMBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x605EFF0", Offset = "0x605E1F0", VA = "0x18605EFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long FMBDCBNOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x605F2F0", Offset = "0x605E4F0", VA = "0x18605F2F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private FDILPGAJHBN PCJJKMOJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x605F2E0", Offset = "0x605E4E0", VA = "0x18605F2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double GEMMINPHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x605F1F0", Offset = "0x605E3F0", VA = "0x18605F1F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x605F030", Offset = "0x605E230", VA = "0x18605F030")]
	public void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x605F3B0", Offset = "0x605E5B0", VA = "0x18605F3B0")]
	public void PCALEBPJHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x605F410", Offset = "0x605E610", VA = "0x18605F410")]
	public void PNIDAEKFKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x605F270", Offset = "0x605E470", VA = "0x18605F270")]
	public void LFIFJBNGAIA(long NPOBIDANKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x605F070", Offset = "0x605E270", VA = "0x18605F070")]
	public void ANCNFCNKJPK(long FPBIEIKBAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x605F0E0", Offset = "0x605E2E0", VA = "0x18605F0E0")]
	public void DDBOJDHODCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x605F340", Offset = "0x605E540", VA = "0x18605F340")]
	public void ODCJLPBFNPD(long ONJFLKDKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x605F460", Offset = "0x605E660", VA = "0x18605F460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x605F150", Offset = "0x605E350", VA = "0x18605F150")]
	public void FELCDFFGIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public BMNOPABJICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GENINMCPAAG
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> MHHCLEJKKBP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6062D80", Offset = "0x6061F80", VA = "0x186062D80")]
	public static IPEndPoint OFOBDKONJOH(string MGGLGJIAGLK, int EOAIGCCJHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6062BB0", Offset = "0x6061DB0", VA = "0x186062BB0")]
	public static IPAddress MMPIFPMBINO(string MGGLGJIAGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6062B20", Offset = "0x6061D20", VA = "0x186062B20")]
	public static IPAddress MMPIFPMBINO(string MGGLGJIAGLK, AddressFamily DDBKNNHPBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6062AF0", Offset = "0x6061CF0", VA = "0x186062AF0")]
	internal static int HHBDCFJHGIP(int HJNIMKHKKCA, int JMFINLEJMNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E09F80", Offset = "0x2E09180", VA = "0x182E09F80")]
	internal static T[] ECLIPECJBBO<T>(int NDEFEFEFLCE) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BBEDHOLIAHL : CPEBDFEMNJC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct JENKHHLKJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private JKKGMDDOGFM CJCJJLBOGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long LFJLFOMPJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool DDCMBABFNDD;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6064A00", Offset = "0x6063C00", VA = "0x186064A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6064970", Offset = "0x6063B70", VA = "0x186064970")]
		public void BPKFIOLMIPE(JKKGMDDOGFM CLDNMMCBJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6064990", Offset = "0x6063B90", VA = "0x186064990")]
		public bool LHOKBBFHPPP(long APBIDGEPJOJ, JMJJNGBJEJG LAAMGLCFDJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6064920", Offset = "0x6063B20", VA = "0x186064920")]
		public bool AODHOHPPLKC(JMJJNGBJEJG LAAMGLCFDJO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly JKKGMDDOGFM LIOEMCBAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly JENKHHLKJML[] GGOFAMHIKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly JKKGMDDOGFM[] GELAFGNLCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] CJGCNNMEKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int MIGJOBOICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int GICMMHPHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int DKNHCGOFCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int EKDAOHKBFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool INJGCCEMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DCCHNLODCEF CIAJKEHMCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool OJOEONFIKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int NCOCOIHBIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte EDPNPFMPMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x605EE10", Offset = "0x605E010", VA = "0x18605EE10")]
	public BBEDHOLIAHL(JMJJNGBJEJG LAAMGLCFDJO, bool MNGPMJKGLKE, byte MHMAFIBKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x605E3F0", Offset = "0x605D5F0", VA = "0x18605E3F0")]
	private void JMGJANKECCJ(JKKGMDDOGFM CLDNMMCBJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x605DF20", Offset = "0x605D120", VA = "0x18605DF20", Slot = "4")]
	protected override bool HIKILPJCGDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x605E7B0", Offset = "0x605D9B0", VA = "0x18605E7B0", Slot = "5")]
	public override bool POJDABCONDK(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EOCIFBBGDLJ : CPEBDFEMNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int PCCBDMOKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort GICMMHPHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool NCDFKIFMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private JKKGMDDOGFM BCEAGDHCELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly JKKGMDDOGFM DCKFAIIGEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool EGJDAPHOGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte EDPNPFMPMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long GDCBFCABDCO;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6062800", Offset = "0x6061A00", VA = "0x186062800")]
	public EOCIFBBGDLJ(JMJJNGBJEJG LAAMGLCFDJO, bool GOGPGGEPGHC, byte MHMAFIBKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6062060", Offset = "0x6061260", VA = "0x186062060", Slot = "4")]
	protected override bool HIKILPJCGDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6062520", Offset = "0x6061720", VA = "0x186062520", Slot = "5")]
	public override bool POJDABCONDK(JKKGMDDOGFM CLDNMMCBJOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EGLMCPJAGAF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct HBKMNDPDHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong OAMFNEECGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double JJKDKGCHHBJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GKEICCNCDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int JEKONGNKJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float AKFCODEDOFL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x605D0C0", Offset = "0x605C2C0", VA = "0x18605D0C0")]
	private static void NCPKMKOHOLN(byte[] GJBDDGHNJBG, int ECDKJELMFBH, ulong LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6061FF0", Offset = "0x60611F0", VA = "0x186061FF0")]
	private static void NCPKMKOHOLN(byte[] GJBDDGHNJBG, int ECDKJELMFBH, int LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6061F10", Offset = "0x6061110", VA = "0x186061F10")]
	public static void NCPKMKOHOLN(byte[] GJBDDGHNJBG, int ECDKJELMFBH, short LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6061FD0", Offset = "0x60611D0", VA = "0x186061FD0")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, double JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6061F50", Offset = "0x6061150", VA = "0x186061F50")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, float JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6061F10", Offset = "0x6061110", VA = "0x186061F10")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, short JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6061F10", Offset = "0x6061110", VA = "0x186061F10")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, ushort JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6061FF0", Offset = "0x60611F0", VA = "0x186061FF0")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, int JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6061FF0", Offset = "0x60611F0", VA = "0x186061FF0")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, uint JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6061F00", Offset = "0x6061100", VA = "0x186061F00")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, long JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6061F00", Offset = "0x6061100", VA = "0x186061F00")]
	public static void JFLINBFAOMN(byte[] IFEDAAIOIBA, int GFHPFKLIAOK, ulong JECHHBGMFLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IDOAANBGOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] DIFBOAKKIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int KCNEFFPHFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int IJFJMPNIJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int INECJFBJBAK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] HPHMLCALPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AJMDINJLDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LCHNKAEELMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60642D0", Offset = "0x60634D0", VA = "0x1860642D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LHOBAFHJBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2100FE0", Offset = "0x21001E0", VA = "0x182100FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int IPLJDBBCKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6064710", Offset = "0x6063910", VA = "0x186064710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6064720", Offset = "0x6063920", VA = "0x186064720")]
	public void OFEHPKLMJFH(byte[] KLCFDAPKGEC, int ECDKJELMFBH, int KCIDCNBFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public IDOAANBGOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6064820", Offset = "0x6063A20", VA = "0x186064820")]
	public IDOAANBGOOP(byte[] KLCFDAPKGEC, int ECDKJELMFBH, int KCIDCNBFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6063FB0", Offset = "0x60631B0", VA = "0x186063FB0")]
	public IPEndPoint DOCDIBINLGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6064290", Offset = "0x6063490", VA = "0x186064290")]
	public byte JGAODBOAHAN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6064290", Offset = "0x6063490", VA = "0x186064290")]
	public sbyte MHFHHNHPNDM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E44D50", Offset = "0x2E43F50", VA = "0x182E44D50")]
	public T[] JELINGAJKBB<T>(ushort JAICOMOJIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6063C20", Offset = "0x6062E20", VA = "0x186063C20")]
	public bool[] ADCEBLGKLKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60647E0", Offset = "0x60639E0", VA = "0x1860647E0")]
	public ushort[] PLPNGONNPPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6063F00", Offset = "0x6063100", VA = "0x186063F00")]
	public short[] DKPDFJCMIJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60647A0", Offset = "0x60639A0", VA = "0x1860647A0")]
	public int[] PHKMGCHOEHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6063DD0", Offset = "0x6062FD0", VA = "0x186063DD0")]
	public uint[] CMEEDLJPMGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6064170", Offset = "0x6063370", VA = "0x186064170")]
	public float[] GCBMJIGMMIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6064080", Offset = "0x6063280", VA = "0x186064080")]
	public double[] EFENHPCMENB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6064760", Offset = "0x6063960", VA = "0x186064760")]
	public long[] ONPBMMLFNIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6063E10", Offset = "0x6063010", VA = "0x186063E10")]
	public ulong[] DCPKKAJCKMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6063C60", Offset = "0x6062E60", VA = "0x186063C60")]
	public string[] AFOHMFOPDOI(int LKOCFIIELMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6063E50", Offset = "0x6063050", VA = "0x186063E50")]
	public bool DIIMKIFMFAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6064390", Offset = "0x6063590", VA = "0x186064390")]
	public char OAHJFJELMBO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6064390", Offset = "0x6063590", VA = "0x186064390")]
	public ushort LMJDIBOEINE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6064400", Offset = "0x6063600", VA = "0x186064400")]
	public short MIMPMDJFLBG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60642E0", Offset = "0x60634E0", VA = "0x1860642E0")]
	public long KDGIKHKDDEC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6064470", Offset = "0x6063670", VA = "0x186064470")]
	public ulong NBHCFKPCCML()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6063E90", Offset = "0x6063090", VA = "0x186063E90")]
	public int DKNKFAHACGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6064220", Offset = "0x6063420", VA = "0x186064220")]
	public uint IKABAKKJPJA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x60641B0", Offset = "0x60633B0", VA = "0x1860641B0")]
	public float IBDMJFNHGGA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6064100", Offset = "0x6063300", VA = "0x186064100")]
	public double FDFKNOEIJKN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x60644E0", Offset = "0x60636E0", VA = "0x1860644E0")]
	public string NGJGIFGOJDN(int HMDMPLFHGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6063F40", Offset = "0x6063140", VA = "0x186063F40")]
	public ArraySegment<byte> DLJIBNPHBOC(int NDEFEFEFLCE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60640C0", Offset = "0x60632C0", VA = "0x1860640C0")]
	public sbyte[] EKJJJLOAOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6064350", Offset = "0x6063550", VA = "0x186064350")]
	public byte[] KGIHCEKMNGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6063DB0", Offset = "0x6062FB0", VA = "0x186063DB0")]
	public void AODHOHPPLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MCFHHMFNFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] DIFBOAKKIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int KCNEFFPHFAC;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int FOIEEMCPLDP = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool FFKEOHKFGLK;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding NJECBIDBPLN;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int BANHKEAHNJE = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] HANFBNIIDAI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] OMAPODLEEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x606C230", Offset = "0x606B430", VA = "0x18606C230")]
	public MCFHHMFNFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x606C2B0", Offset = "0x606B4B0", VA = "0x18606C2B0")]
	public MCFHHMFNFDI(bool APKBNMFEDLA, int CDKPEPLOKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x606C0A0", Offset = "0x606B2A0", VA = "0x18606C0A0")]
	public static MCFHHMFNFDI OGFEBIGACBF(string JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x606C110", Offset = "0x606B310", VA = "0x18606C110")]
	public void PCNBLJOGGJH(int IOKDJCHFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2179E30", Offset = "0x2179030", VA = "0x182179E30")]
	public void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x606B560", Offset = "0x606A760", VA = "0x18606B560")]
	public void BDAAJHINKJM(float JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x606B510", Offset = "0x606A710", VA = "0x18606B510")]
	public void BDAAJHINKJM(double JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x606B600", Offset = "0x606A800", VA = "0x18606B600")]
	public void BDAAJHINKJM(long JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x606B600", Offset = "0x606A800", VA = "0x18606B600")]
	public void BDAAJHINKJM(ulong JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x606B790", Offset = "0x606A990", VA = "0x18606B790")]
	public void BDAAJHINKJM(int JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x606B790", Offset = "0x606A990", VA = "0x18606B790")]
	public void BDAAJHINKJM(uint JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x606B6C0", Offset = "0x606A8C0", VA = "0x18606B6C0")]
	public void BDAAJHINKJM(char JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x606B6C0", Offset = "0x606A8C0", VA = "0x18606B6C0")]
	public void BDAAJHINKJM(ushort JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x606B6C0", Offset = "0x606A8C0", VA = "0x18606B6C0")]
	public void BDAAJHINKJM(short JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x606B730", Offset = "0x606A930", VA = "0x18606B730")]
	public void BDAAJHINKJM(sbyte JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x606B730", Offset = "0x606A930", VA = "0x18606B730")]
	public void BDAAJHINKJM(byte JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x606B650", Offset = "0x606A850", VA = "0x18606B650")]
	public void BDAAJHINKJM(byte[] LJIEGDEDOHM, int ECDKJELMFBH, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x606BB70", Offset = "0x606AD70", VA = "0x18606BB70")]
	public void CHDNFNMOOEB(sbyte[] LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x606BB70", Offset = "0x606AD70", VA = "0x18606BB70")]
	public void FBJGCONEANF(byte[] LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x606B820", Offset = "0x606AA20", VA = "0x18606B820")]
	public void BDAAJHINKJM(bool JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x606BFC0", Offset = "0x606B1C0", VA = "0x18606BFC0")]
	public void HPMCPHJOCAI(Array GBOPNMLEACH, int NIDAFKHOIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x606BD30", Offset = "0x606AF30", VA = "0x18606BD30")]
	public void HPMCPHJOCAI(float[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x606BEE0", Offset = "0x606B0E0", VA = "0x18606BEE0")]
	public void HPMCPHJOCAI(double[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x606BEE0", Offset = "0x606B0E0", VA = "0x18606BEE0")]
	public void HPMCPHJOCAI(long[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x606BEE0", Offset = "0x606B0E0", VA = "0x18606BEE0")]
	public void HPMCPHJOCAI(ulong[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x606BD30", Offset = "0x606AF30", VA = "0x18606BD30")]
	public void HPMCPHJOCAI(int[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x606BD30", Offset = "0x606AF30", VA = "0x18606BD30")]
	public void HPMCPHJOCAI(uint[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x606BC50", Offset = "0x606AE50", VA = "0x18606BC50")]
	public void HPMCPHJOCAI(ushort[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x606BC50", Offset = "0x606AE50", VA = "0x18606BC50")]
	public void HPMCPHJOCAI(short[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x606BB70", Offset = "0x606AD70", VA = "0x18606BB70")]
	public void HPMCPHJOCAI(bool[] JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x606BE10", Offset = "0x606B010", VA = "0x18606BE10")]
	public void HPMCPHJOCAI(string[] JECHHBGMFLN, int JGIIJMDCPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x606BA90", Offset = "0x606AC90", VA = "0x18606BA90")]
	public void BDAAJHINKJM(IPEndPoint DAHLFLPLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x606BB60", Offset = "0x606AD60", VA = "0x18606BB60")]
	public void BDAAJHINKJM(string JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x606B880", Offset = "0x606AA80", VA = "0x18606B880")]
	public void BDAAJHINKJM(string JECHHBGMFLN, int HMDMPLFHGJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DODBKCDDPFA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class KLBGLDILIKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong CCBOBDNNGDH;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x44B9620", Offset = "0x44B8820", VA = "0x1844B9620")]
		static KLBGLDILIKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void MKKGHCJFCBH(IDOAANBGOOP IDGMLEGKFGC, object OPKOIMHEIFO);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AFMPJNIGFJF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public DODBKCDDPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AFMPJNIGFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3F329C0", Offset = "0x3F31BC0", VA = "0x183F329C0")]
		internal void OOLNBHEBDOG(IDOAANBGOOP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OLNPAJEJFAO<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public DODBKCDDPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OLNPAJEJFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x497E620", Offset = "0x497D820", VA = "0x18497E620")]
		internal void OOLNBHEBDOG(IDOAANBGOOP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly NCDKOMECHJJ JBMKEPJKLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, MKKGHCJFCBH> BLIEPNBJIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly MCFHHMFNFDI BDECEIPLKLM;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x605FEF0", Offset = "0x605F0F0", VA = "0x18605FEF0")]
	public DODBKCDDPFA(int LKOCFIIELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C4C0", Offset = "0x2C6B6C0", VA = "0x182C6C4C0", Slot = "4")]
	protected virtual ulong KJCPPKHAIKE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x605FD70", Offset = "0x605EF70", VA = "0x18605FD70", Slot = "5")]
	protected virtual MKKGHCJFCBH NIMMAPBGKFM(IDOAANBGOOP IDGMLEGKFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C020", Offset = "0x2C6B220", VA = "0x182C6C020", Slot = "6")]
	protected virtual void EPDNDFHHDKL<T>(MCFHHMFNFDI MIOAACOLOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x605FCF0", Offset = "0x605EEF0", VA = "0x18605FCF0")]
	public void BLANCLEOBMK(IDOAANBGOOP IDGMLEGKFGC, object OPKOIMHEIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C090", Offset = "0x2C6B290", VA = "0x182C6C090")]
	public void FGHBHDAKNDG<T>(MCFHHMFNFDI MIOAACOLOAF, T CLDNMMCBJOD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x605FEA0", Offset = "0x605F0A0", VA = "0x18605FEA0")]
	public void OIFIAAPCBJP(IDOAANBGOOP IDGMLEGKFGC, object OPKOIMHEIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C300", Offset = "0x2C6B500", VA = "0x182C6C300")]
	public void KEAHEIFINPL<T>(Action<T> DDDLMEPPDFG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C140", Offset = "0x2C6B340", VA = "0x182C6C140")]
	public void KEAHEIFINPL<T, TUserData>(Action<T, TUserData> DDDLMEPPDFG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OGGECMICBFP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x605EFE0", Offset = "0x605E1E0", VA = "0x18605EFE0")]
	public OGGECMICBFP(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ANJKKLLIELC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x605DEC0", Offset = "0x605D0C0", VA = "0x18605DEC0")]
	public ANJKKLLIELC(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NCDKOMECHJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum HPPGMALPPFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class HCNBKLGBJOC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public HPPGMALPPFD DGMPJMIJKHO;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4010640", Offset = "0x400F840", VA = "0x184010640", Slot = "4")]
		public virtual void BPKFIOLMIPE(MethodInfo KFNKJEBLNCD, MethodInfo OBFIPOOBPIP, HPPGMALPPFD EIHDAHDDDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LBOCMAHCNID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CBCJBDABIFK(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected HCNBKLGBJOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class NGLBLMOKMMB<TClass, TProperty> : HCNBKLGBJOC<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> HLLLIEFNFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> PBDFOJIHPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> FOEBIJDPDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> JGDLOHPNJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> ODNDNNIMNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> JGFAGNADOKG;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x482FBC0", Offset = "0x482EDC0", VA = "0x18482FBC0", Slot = "7")]
		public override void BGDOBNNGEJF(TClass DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x482FAE0", Offset = "0x482ECE0", VA = "0x18482FAE0", Slot = "8")]
		public override void ACPCBDDGFIP(TClass DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4830320", Offset = "0x482F520", VA = "0x184830320", Slot = "9")]
		public override void LBOCMAHCNID(TClass DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4830240", Offset = "0x482F440", VA = "0x184830240", Slot = "10")]
		public override void CBCJBDABIFK(TClass DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x482F9D0", Offset = "0x482EBD0", VA = "0x18482F9D0")]
		protected TProperty[] ACHDEJHCPNP(TClass DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4830400", Offset = "0x482F600", VA = "0x184830400")]
		protected TProperty[] NDEPLNNGPBL(TClass DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x482FCA0", Offset = "0x482EEA0", VA = "0x18482FCA0", Slot = "4")]
		public override void BPKFIOLMIPE(MethodInfo KFNKJEBLNCD, MethodInfo OBFIPOOBPIP, HPPGMALPPFD EIHDAHDDDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3FC2C10", Offset = "0x3FC1E10", VA = "0x183FC2C10")]
		protected NGLBLMOKMMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class HOHEIOFAFHK<TClass, TProperty> : NGLBLMOKMMB<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void DDNAAAFBCFE(IDOAANBGOOP KHFLFLECNEB, [Out] TProperty GIAODHPPLJH);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void COLNPKDDPHB(MCFHHMFNFDI ANMJILICOFJ, TProperty GIAODHPPLJH);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x404D1E0", Offset = "0x404C3E0", VA = "0x18404D1E0", Slot = "5")]
		public override void OMCAHAFDGID(TClass DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x404D0E0", Offset = "0x404C2E0", VA = "0x18404D0E0", Slot = "6")]
		public override void FGHBHDAKNDG(TClass DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x404CF60", Offset = "0x404C160", VA = "0x18404CF60", Slot = "7")]
		public override void BGDOBNNGEJF(TClass DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x404CDE0", Offset = "0x404BFE0", VA = "0x18404CDE0", Slot = "8")]
		public override void ACPCBDDGFIP(TClass DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3AF63F0", Offset = "0x3AF55F0", VA = "0x183AF63F0")]
		protected HOHEIOFAFHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class CJAPLIHFHGF<T> : NGLBLMOKMMB<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x57C4890", Offset = "0x57C3A90", VA = "0x1857C4890", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F60810", Offset = "0x3F5FA10", VA = "0x183F60810", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x57C4810", Offset = "0x57C3A10", VA = "0x1857C4810", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F60720", Offset = "0x3F5F920", VA = "0x183F60720", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public CJAPLIHFHGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class GEDNLIAGHLD<T> : NGLBLMOKMMB<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F60880", Offset = "0x3F5FA80", VA = "0x183F60880", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F60810", Offset = "0x3F5FA10", VA = "0x183F60810", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F60790", Offset = "0x3F5F990", VA = "0x183F60790", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F60720", Offset = "0x3F5F920", VA = "0x183F60720", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public GEDNLIAGHLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class LJGNPHFKHPB<T> : NGLBLMOKMMB<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4556C10", Offset = "0x4555E10", VA = "0x184556C10", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4556BA0", Offset = "0x4555DA0", VA = "0x184556BA0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4556B20", Offset = "0x4555D20", VA = "0x184556B20", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4556AB0", Offset = "0x4555CB0", VA = "0x184556AB0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public LJGNPHFKHPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DJPPFCHJFED<T> : NGLBLMOKMMB<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5B33F00", Offset = "0x5B33100", VA = "0x185B33F00", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4556BA0", Offset = "0x4555DA0", VA = "0x184556BA0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5B33E80", Offset = "0x5B33080", VA = "0x185B33E80", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4556AB0", Offset = "0x4555CB0", VA = "0x184556AB0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public DJPPFCHJFED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class HAICOOKJGLA<T> : NGLBLMOKMMB<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2330", Offset = "0x3FF1530", VA = "0x183FF2330", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF22C0", Offset = "0x3FF14C0", VA = "0x183FF22C0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2240", Offset = "0x3FF1440", VA = "0x183FF2240", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3FF21D0", Offset = "0x3FF13D0", VA = "0x183FF21D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public HAICOOKJGLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class KKIOLFHJPLK<T> : NGLBLMOKMMB<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x44B8830", Offset = "0x44B7A30", VA = "0x1844B8830", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF22C0", Offset = "0x3FF14C0", VA = "0x183FF22C0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44B87B0", Offset = "0x44B79B0", VA = "0x1844B87B0", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3FF21D0", Offset = "0x3FF13D0", VA = "0x183FF21D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public KKIOLFHJPLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class HCDJHIKLBMG<T> : NGLBLMOKMMB<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4010330", Offset = "0x400F530", VA = "0x184010330", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x40102C0", Offset = "0x400F4C0", VA = "0x1840102C0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4010240", Offset = "0x400F440", VA = "0x184010240", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x40101D0", Offset = "0x400F3D0", VA = "0x1840101D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public HCDJHIKLBMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HPIBJPOJLGJ<T> : NGLBLMOKMMB<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4010330", Offset = "0x400F530", VA = "0x184010330", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x40102C0", Offset = "0x400F4C0", VA = "0x1840102C0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4055450", Offset = "0x4054650", VA = "0x184055450", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40101D0", Offset = "0x400F3D0", VA = "0x1840101D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public HPIBJPOJLGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KPJJLLAADGI<T> : NGLBLMOKMMB<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x44C8BE0", Offset = "0x44C7DE0", VA = "0x1844C8BE0", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x44C8B70", Offset = "0x44C7D70", VA = "0x1844C8B70", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x44C8AF0", Offset = "0x44C7CF0", VA = "0x1844C8AF0", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F60720", Offset = "0x3F5F920", VA = "0x183F60720", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public KPJJLLAADGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OOJOHBBJJFI<T> : NGLBLMOKMMB<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x49B9990", Offset = "0x49B8B90", VA = "0x1849B9990", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x49B9920", Offset = "0x49B8B20", VA = "0x1849B9920", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x49B98A0", Offset = "0x49B8AA0", VA = "0x1849B98A0", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FF21D0", Offset = "0x3FF13D0", VA = "0x183FF21D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public OOJOHBBJJFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JMJJCELAEEI<T> : NGLBLMOKMMB<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x438BBD0", Offset = "0x438ADD0", VA = "0x18438BBD0", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x438BB60", Offset = "0x438AD60", VA = "0x18438BB60", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x438BAE0", Offset = "0x438ACE0", VA = "0x18438BAE0", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x40101D0", Offset = "0x400F3D0", VA = "0x1840101D0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA10", Offset = "0x3F5AC10", VA = "0x183F5BA10")]
		public JMJJCELAEEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class IDCIIHCLKON<T> : HOHEIOFAFHK<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4107490", Offset = "0x4106690", VA = "0x184107490", Slot = "12")]
		protected override void COLNPKDDPHB(MCFHHMFNFDI ANMJILICOFJ, char GIAODHPPLJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41074C0", Offset = "0x41066C0", VA = "0x1841074C0", Slot = "11")]
		protected override void DDNAAAFBCFE(IDOAANBGOOP KHFLFLECNEB, [Out] char GIAODHPPLJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E91950", Offset = "0x3E90B50", VA = "0x183E91950")]
		public IDCIIHCLKON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class AAHPPGDPJNK<T> : HOHEIOFAFHK<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD740", Offset = "0x3EFC940", VA = "0x183EFD740", Slot = "12")]
		protected override void COLNPKDDPHB(MCFHHMFNFDI ANMJILICOFJ, IPEndPoint GIAODHPPLJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD770", Offset = "0x3EFC970", VA = "0x183EFD770", Slot = "11")]
		protected override void DDNAAAFBCFE(IDOAANBGOOP KHFLFLECNEB, [Out] IPEndPoint GIAODHPPLJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E91950", Offset = "0x3E90B50", VA = "0x183E91950")]
		public AAHPPGDPJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class LKAIOFADOHD<T> : NGLBLMOKMMB<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int BPABMNHODGD;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4558CC0", Offset = "0x4557EC0", VA = "0x184558CC0")]
		public LKAIOFADOHD(int HMDMPLFHGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4558C40", Offset = "0x4557E40", VA = "0x184558C40", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4558BC0", Offset = "0x4557DC0", VA = "0x184558BC0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4558B40", Offset = "0x4557D40", VA = "0x184558B40", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4558AC0", Offset = "0x4557CC0", VA = "0x184558AC0", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class EDPOEBEKEAO<T> : HCNBKLGBJOC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo PMLJKHBIJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type LDMGJMOMHFO;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC450", Offset = "0x3ACB650", VA = "0x183ACC450")]
		public EDPOEBEKEAO(PropertyInfo BAEKDMBADGA, Type KFHIPAOFIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC390", Offset = "0x3ACB590", VA = "0x183ACC390", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC280", Offset = "0x3ACB480", VA = "0x183ACC280", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC1C0", Offset = "0x3ACB3C0", VA = "0x183ACC1C0", Slot = "7")]
		public override void BGDOBNNGEJF(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC160", Offset = "0x3ACB360", VA = "0x183ACC160", Slot = "8")]
		public override void ACPCBDDGFIP(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC330", Offset = "0x3ACB530", VA = "0x183ACC330", Slot = "9")]
		public override void LBOCMAHCNID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC220", Offset = "0x3ACB420", VA = "0x183ACC220", Slot = "10")]
		public override void CBCJBDABIFK(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CPHEPOIPMKL<T> : EDPOEBEKEAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
		public CPHEPOIPMKL(PropertyInfo BAEKDMBADGA, Type KFHIPAOFIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x58AA4A0", Offset = "0x58A96A0", VA = "0x1858AA4A0", Slot = "5")]
		public override void OMCAHAFDGID(T DIAJKFKHGKN, IDOAANBGOOP KHFLFLECNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x58AA3F0", Offset = "0x58A95F0", VA = "0x1858AA3F0", Slot = "6")]
		public override void FGHBHDAKNDG(T DIAJKFKHGKN, MCFHHMFNFDI ANMJILICOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class PFHPEPEIEAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static PFHPEPEIEAI<T> FAKOKDPOOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly HCNBKLGBJOC<T>[] LJJKNPDLAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int HHFGIDCANNJ;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4A8FD50", Offset = "0x4A8EF50", VA = "0x184A8FD50")]
		public PFHPEPEIEAI(List<HCNBKLGBJOC<T>> HCDIFIFIGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4A8FBF0", Offset = "0x4A8EDF0", VA = "0x184A8FBF0")]
		public void FGHBHDAKNDG(T JMJAOKJJFGJ, MCFHHMFNFDI MIOAACOLOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4A8FCA0", Offset = "0x4A8EEA0", VA = "0x184A8FCA0")]
		public void OMCAHAFDGID(T JMJAOKJJFGJ, IDOAANBGOOP IDGMLEGKFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NBBDGBGACHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HCNBKLGBJOC<T> PLOCNKMCLIO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private MCFHHMFNFDI GIEKANADNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int JKCCOMCBDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, NBBDGBGACHB> KHAPKJLMFMP;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6073EB0", Offset = "0x60730B0", VA = "0x186073EB0")]
	public NCDKOMECHJJ(int LKOCFIIELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2F78C20", Offset = "0x2F77E20", VA = "0x182F78C20")]
	private PFHPEPEIEAI<T> JOAIHMFGIDG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6350", Offset = "0x2BA5550", VA = "0x182BA6350")]
	public void ALGAFMBJNNP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2F78B80", Offset = "0x2F77D80", VA = "0x182F78B80")]
	public bool GBKBNNNFJGC<T>(IDOAANBGOOP IDGMLEGKFGC, T LCMBJJGJCLO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2F79D40", Offset = "0x2F78F40", VA = "0x182F79D40")]
	public void LMOHAAKIFFE<T>(MCFHHMFNFDI MIOAACOLOAF, T JMJAOKJJFGJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EGBMLNAOCPB
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime KADNGIKHDCD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] CFJMCMGLFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MGKEPMEDHLE OGEJHIGNFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60615F0", Offset = "0x60607F0", VA = "0x1860615F0")]
		get
		{
			return default(MGKEPMEDHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int HJPGNHLGNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6060FF0", Offset = "0x60601F0", VA = "0x186060FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6061620", Offset = "0x6060820", VA = "0x186061620")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PBHIJAFAKAF NEBHOAGDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60615C0", Offset = "0x60607C0", VA = "0x1860615C0")]
		get
		{
			return default(PBHIJAFAKAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6061890", Offset = "0x6060A90", VA = "0x186061890")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PDPHMFMPMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6061AA0", Offset = "0x6060CA0", VA = "0x186061AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint DFFIIBBIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6060BC0", Offset = "0x605FDC0", VA = "0x186060BC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? ONHPEHBFEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6060C40", Offset = "0x605FE40", VA = "0x186060C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? COJIEGDHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6060D30", Offset = "0x605FF30", VA = "0x186060D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? DPOKFFPCOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6061860", Offset = "0x6060A60", VA = "0x186061860")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60618D0", Offset = "0x6060AD0", VA = "0x1860618D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? JEHPGIPDDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x90B430", Offset = "0x90A630", VA = "0x18090B430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x90B550", Offset = "0x90A750", VA = "0x18090B550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6061B30", Offset = "0x6060D30", VA = "0x186061B30")]
	public EGBMLNAOCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6061E50", Offset = "0x6061050", VA = "0x186061E50")]
	internal EGBMLNAOCPB(byte[] IFEDAAIOIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6061200", Offset = "0x6060400", VA = "0x186061200")]
	public static EGBMLNAOCPB GPJGPMOPFNI(byte[] IFEDAAIOIBA, DateTime HMHJEECGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6061660", Offset = "0x6060860", VA = "0x186061660")]
	internal void LHEBOMKDCMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6061020", Offset = "0x6060220", VA = "0x186061020")]
	private void GFBHLJOOFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6060D60", Offset = "0x605FF60", VA = "0x186060D60")]
	private DateTime? ELOIIJGBLEA(int ECDKJELMFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6061320", Offset = "0x6060520", VA = "0x186061320")]
	private void IPMEBGPKLDC(int ECDKJELMFBH, DateTime? JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x60614F0", Offset = "0x60606F0", VA = "0x1860614F0")]
	private ulong JIHGBOMAJCG(int ECDKJELMFBH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6060C70", Offset = "0x605FE70", VA = "0x186060C70")]
	private void DLCONIDIPCP(int ECDKJELMFBH, ulong JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6060F60", Offset = "0x6060160", VA = "0x186060F60")]
	private uint EPJCBFBJLAG(int ECDKJELMFBH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F32A70", Offset = "0x5F31C70", VA = "0x185F32A70")]
	private static uint BCLJKDOCJHB(uint AKHPALIKFFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6060B60", Offset = "0x605FD60", VA = "0x186060B60")]
	private static ulong BCLJKDOCJHB(ulong AKHPALIKFFK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MGKEPMEDHLE
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
public enum PBHIJAFAKAF
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GKJLEMIMIDP
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int GFBLGDNHLFN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int FLMAIDBPDCP = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int IGKBHLNMPHN = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint ELLGGKBJBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int FLIEMOJJCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int MCBNPANMMBK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JELEIHMEPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6063150", Offset = "0x6062350", VA = "0x186063150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6063060", Offset = "0x6062260", VA = "0x186063060")]
	public bool BMCLHNPMEKP(OIFOOKIAMCN OBJOJDEEBHO, int APFBMHLAJIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AINDFMMGJEL : OIFOOKIAMCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket OBJOJDEEBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly MGLHKOFGJDN GEHNKKAJDKI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short FNGMGFAEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x605DCE0", Offset = "0x605CEE0", VA = "0x18605DCE0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PCHNJMHEOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x605D6A0", Offset = "0x605C8A0", VA = "0x18605D6A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint JKAJIPEPPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x605DDF0", Offset = "0x605CFF0", VA = "0x18605DDF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily GPPMJFGHBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x451C860", Offset = "0x451BA60", VA = "0x18451C860", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x605DE10", Offset = "0x605D010", VA = "0x18605DE10")]
	public AINDFMMGJEL(AddressFamily DDBKNNHPBKM, MGLHKOFGJDN GEHNKKAJDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x605D6C0", Offset = "0x605C8C0", VA = "0x18605D6C0", Slot = "8")]
	public bool BGGBANEFEJF(IPEndPoint DAHLFLPLKGO, OOCNIGLJNKI GLIAFILOPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x605DCA0", Offset = "0x605CEA0", VA = "0x18605DCA0", Slot = "9")]
	public int HFPODIMKHKD(byte[] GJBDDGHNJBG, int ECDKJELMFBH, int JAICOMOJIGD, IPEndPoint JPODFMICAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x605DD00", Offset = "0x605CF00", VA = "0x18605DD00", Slot = "10")]
	public int LCMPEIBNOJH(byte[] GJBDDGHNJBG, EndPoint LLJFCCKPNKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x605DC80", Offset = "0x605CE80", VA = "0x18605DC80", Slot = "11")]
	public void ECKEJAKCCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface OIFOOKIAMCN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short FNGMGFAEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int PCHNJMHEOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint JKAJIPEPPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily GPPMJFGHBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BGGBANEFEJF(IPEndPoint DAHLFLPLKGO, OOCNIGLJNKI GLIAFILOPMG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HFPODIMKHKD(byte[] GJBDDGHNJBG, int ECDKJELMFBH, int JAICOMOJIGD, IPEndPoint JPODFMICAIM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LCMPEIBNOJH(byte[] GJBDDGHNJBG, EndPoint JPODFMICAIM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECKEJAKCCJH();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct ONBBGFFCNMN : IEquatable<ONBBGFFCNMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long FEEPIJHBCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long FEDBAMOONAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long OJGFDHABMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int DKEONNFDBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int CNKNNICPKGL;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6074510", Offset = "0x6073710", VA = "0x186074510")]
	public ONBBGFFCNMN(byte[] ADCIGFAONIK, int MMOGIILMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8BD900", Offset = "0x8BCB00", VA = "0x1808BD900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x60744D0", Offset = "0x60736D0", VA = "0x1860744D0", Slot = "4")]
	public bool Equals(ONBBGFFCNMN KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6074420", Offset = "0x6073620", VA = "0x186074420", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class OMOMGHLADEH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] IMGJEFJEPLA;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CFNHJNJOHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int NNJHIHJOONK;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
	protected CFNHJNJOHDL(int HCEKGDACCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EHOHINCPNBK(IPEndPoint DAHLFLPLKGO, byte[] LJIEGDEDOHM, int ECDKJELMFBH, int KOHJFMFCHKH);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DCFCNGJFPKB(IPEndPoint DAHLFLPLKGO, byte[] LJIEGDEDOHM, int ECDKJELMFBH, int KOHJFMFCHKH);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ECMHJMEGLBK : CFNHJNJOHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] CPBLLDDDHEE;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator EBHLDPNIIGP;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x221CD60", Offset = "0x221BF60", VA = "0x18221CD60")]
	public ECMHJMEGLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6060960", Offset = "0x605FB60", VA = "0x186060960")]
	public void EKBJDAGFIGL(IPEndPoint DAHLFLPLKGO, byte[] CPBLLDDDHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6060070", Offset = "0x605F270", VA = "0x186060070")]
	public void BANINNLNPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x60604B0", Offset = "0x605F6B0", VA = "0x1860604B0", Slot = "4")]
	public override void EHOHINCPNBK(IPEndPoint DAHLFLPLKGO, byte[] LJIEGDEDOHM, int ECDKJELMFBH, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6060150", Offset = "0x605F350", VA = "0x186060150", Slot = "5")]
	public override void DCFCNGJFPKB(IPEndPoint DAHLFLPLKGO, byte[] LJIEGDEDOHM, int ECDKJELMFBH, int KOHJFMFCHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct MMEKBEGHNOH
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void OAGIDJHPMMH([NoAlias] byte* HOPJCOJKLPB, [NoAlias] byte* CPBLLDDDHEE, [NoAlias] byte* ECJDABJMEFF, int KOHJFMFCHKH);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class MDDGMECJCML
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6074A20", Offset = "0x6073C20", VA = "0x186074A20")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6074830", Offset = "0x6073A30", VA = "0x186074830")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6074980", Offset = "0x6073B80", VA = "0x186074980")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6074600", Offset = "0x6073800", VA = "0x186074600")]
		public unsafe static void BAPLBLGGGFM([NoAlias] byte* HOPJCOJKLPB, [NoAlias] byte* CPBLLDDDHEE, [NoAlias] byte* ECJDABJMEFF, int KOHJFMFCHKH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint CPBLLDDDHEE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint ECJDABJMEFF[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint NPBHEEMOAED[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint OFJPNFBDCGI[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint HOIHHGDFEFL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint LHOGLHGIDPA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint OBGNLNKDPLL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint JNFFNOHDMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint JDCFDPCBAEM[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x60736B0", Offset = "0x60728B0", VA = "0x1860736B0")]
	private void AKMCCPCKADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6073B50", Offset = "0x6072D50", VA = "0x186073B50")]
	private uint KEANCLIGHFO(uint IGDCKHODAOC, int PFDCIDAHIKG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x605D5F0", Offset = "0x605C7F0", VA = "0x18605D5F0")]
	private void PEMDNDFGOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x605D350", Offset = "0x605C550", VA = "0x18605D350")]
	private void HLCLBGHJCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x605D560", Offset = "0x605C760", VA = "0x18605D560")]
	private void MLMCHLDGNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x605D250", Offset = "0x605C450", VA = "0x18605D250")]
	private void BOBNAFBHPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6073CF0", Offset = "0x6072EF0", VA = "0x186073CF0")]
	private void NCNPHDPANCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6073730", Offset = "0x6072930", VA = "0x186073730")]
	private unsafe void FLLNKCCKONP(byte* HOPJCOJKLPB, uint* CPBLLDDDHEE, uint* ECJDABJMEFF, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6073E30", Offset = "0x6073030", VA = "0x186073E30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NKEJDKODIIF([NoAlias] byte* HOPJCOJKLPB, [NoAlias] byte* CPBLLDDDHEE, [NoAlias] byte* ECJDABJMEFF, int KOHJFMFCHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6073D50", Offset = "0x6072F50", VA = "0x186073D50")]
	public static void NKEJDKODIIF(Span<byte> HOPJCOJKLPB, Span<byte> CPBLLDDDHEE, Span<byte> ECJDABJMEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6073BF0", Offset = "0x6072DF0", VA = "0x186073BF0")]
	public static void LHMNMOKMJPD(Span<byte> HOPJCOJKLPB, Span<byte> CPBLLDDDHEE, Span<byte> ECJDABJMEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6073B80", Offset = "0x6072D80", VA = "0x186073B80")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LGHFFCCJEBJ([NoAlias] byte* HOPJCOJKLPB, [NoAlias] byte* CPBLLDDDHEE, [NoAlias] byte* ECJDABJMEFF, int KOHJFMFCHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6074C40", Offset = "0x6073E40", VA = "0x186074C40")]
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
