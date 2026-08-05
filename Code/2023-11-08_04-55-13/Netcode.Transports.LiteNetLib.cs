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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DGBNHAMPMEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BEDJLHFJOMF
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
		private NetworkManager FCGHMMMMOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, PNCGEDHJLNP> MCIFIMNAHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IFCELBAHMCA NOALNIINIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] JGGJNPJFMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BEDJLHFJOMF HGDEINAKDBI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ADKLGMIHDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool DBLHBCFHBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5327590", Offset = "0x5326390", VA = "0x185327590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5326A90", Offset = "0x5325890", VA = "0x185326A90")]
		public void RecRoom_SetEncryptionInfo(ulong EJHHNKLKNEN, byte[] GAMCILOFBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5326A70", Offset = "0x5325870", VA = "0x185326A70")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5326940", Offset = "0x5325740", VA = "0x185326940")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5327490", Offset = "0x5326290", VA = "0x185327490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5326C90", Offset = "0x5325A90", VA = "0x185326C90", Slot = "6")]
		public override void Send(ulong LLPAAOLCJKC, ArraySegment<byte> KNAIEKIJLBC, NetworkDelivery BDACLMKPDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5326A30", Offset = "0x5325830", VA = "0x185326A30", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong LLPAAOLCJKC, [Out] ArraySegment<byte> IPHMLIFNKFM, [Out] float MHELLGNLGNF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5326F80", Offset = "0x5325D80", VA = "0x185326F80", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x53273B0", Offset = "0x53261B0", VA = "0x1853273B0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5325E70", Offset = "0x5324C70", VA = "0x185325E70", Slot = "10")]
		public override void DisconnectRemoteClient(ulong LLPAAOLCJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5325D20", Offset = "0x5324B20", VA = "0x185325D20", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x53260A0", Offset = "0x5324EA0", VA = "0x1853260A0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong LLPAAOLCJKC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5326F10", Offset = "0x5325D10", VA = "0x185326F10", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5326210", Offset = "0x5325010", VA = "0x185326210", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FCGHMMMMOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5326140", Offset = "0x5324F40", VA = "0x185326140")]
		private NCCHOAHOLAA HBIKJBJPLLL(NetworkDelivery AOPDMLJGEMB)
		{
			return default(NCCHOAHOLAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5325FE0", Offset = "0x5324DE0", VA = "0x185325FE0", Slot = "15")]
		private void GKCEMMDJDGI(PNCGEDHJLNP PMILFPOBAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x53264D0", Offset = "0x53252D0", VA = "0x1853264D0", Slot = "16")]
		private void NAPDPAFLAID(PNCGEDHJLNP PMILFPOBAIB, EEEDHCNMJFO BGHPLJALHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "17")]
		private void IBACFMPLKHP(IPEndPoint HGPCKOKGCHD, SocketError DKNBKAAENCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5326610", Offset = "0x5325410", VA = "0x185326610", Slot = "18")]
		private void OJLJEHMCPGI(PNCGEDHJLNP PMILFPOBAIB, HMHBAIJGCOP EIFCDBMOGEN, byte PBAOMBJLIJI, NCCHOAHOLAA LCBFKEGHKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53263F0", Offset = "0x53251F0", VA = "0x1853263F0")]
		private void LFCOIAIJAIC(int ICPPKLAMHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "19")]
		private void AFAPELMPJBB(IPEndPoint GPIMOJELPAM, HMHBAIJGCOP EIFCDBMOGEN, PLMEDGOHFIO MONGHLBAOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "20")]
		private void NCIOFGFCMHJ(PNCGEDHJLNP PMILFPOBAIB, int LCAOMLPPNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5325CC0", Offset = "0x5324AC0", VA = "0x185325CC0", Slot = "21")]
		private void DBLBLHKDDIM(MPFPPHBICHM MGDLKMJIAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5326910", Offset = "0x5325710", VA = "0x185326910")]
		private ulong OMEPFKBMCGI(PNCGEDHJLNP PMILFPOBAIB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53263D0", Offset = "0x53251D0", VA = "0x1853263D0")]
		private static int JEJGGGPNPII(float IGPHDAEBEMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53274B0", Offset = "0x53262B0", VA = "0x1853274B0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class HINNOFFKILL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PNCGEDHJLNP LIEMOOGAIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<EFGCGHDPMKK> ACLLANOEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KENOKFIAPOJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x531C570", Offset = "0x531B370", VA = "0x18531C570")]
	protected HINNOFFKILL(PNCGEDHJLNP PMILFPOBAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x531C450", Offset = "0x531B250", VA = "0x18531C450")]
	public void AJKKBOMFLDN(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x531C4B0", Offset = "0x531B2B0", VA = "0x18531C4B0")]
	protected void ALAOMGCEPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x531C530", Offset = "0x531B330", VA = "0x18531C530")]
	public bool GALNMBPGNHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool NHCCNMOAIGJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool BPFCJFEIGHH(EFGCGHDPMKK BCPDNOKLBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum PBEKKPHAJDM
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
public class MPFPPHBICHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IFCELBAHMCA HKGKGAOKPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int ADKJPEHFELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MLJBHFKPGHB KDPFLFOEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IOBKLKJAMBN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PBEKKPHAJDM BOEMLEMFLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x797590", Offset = "0x796390", VA = "0x180797590")]
		[CompilerGenerated]
		get
		{
			return default(PBEKKPHAJDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x863AA0", Offset = "0x8628A0", VA = "0x180863AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5327D30", Offset = "0x5326B30", VA = "0x185327D30")]
	internal void OLBKKFBEKIP(MLJBHFKPGHB LBHFFAFEAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5327CA0", Offset = "0x5326AA0", VA = "0x185327CA0")]
	private bool AJCHIFPFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5327D90", Offset = "0x5326B90", VA = "0x185327D90")]
	internal MPFPPHBICHM(IPEndPoint GPIMOJELPAM, MLJBHFKPGHB KKEFEECFPEI, IFCELBAHMCA PJBPBPIPFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5327CD0", Offset = "0x5326AD0", VA = "0x185327CD0")]
	public PNCGEDHJLNP OFAFPIHLDNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PLMEDGOHFIO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GMDJNAGNEME
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
public struct EEEDHCNMJFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GMDJNAGNEME HEDNCBAGEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BGIAGFMNMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HMHBAIJGCOP MPLILJBCGMI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DGBNHAMPMEP
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAJBEEGMPPM(PNCGEDHJLNP PMILFPOBAIB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJKLEACEFBM(PNCGEDHJLNP PMILFPOBAIB, EEEDHCNMJFO BGHPLJALHMH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCANNPAAEBA(IPEndPoint HGPCKOKGCHD, SocketError DKNBKAAENCC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMPBNFBEHNO(PNCGEDHJLNP PMILFPOBAIB, HMHBAIJGCOP EIFCDBMOGEN, byte PBAOMBJLIJI, NCCHOAHOLAA LCBFKEGHKFI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHIBLIEJMBI(IPEndPoint GPIMOJELPAM, HMHBAIJGCOP EIFCDBMOGEN, PLMEDGOHFIO MONGHLBAOFH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJPPAINEBEH(PNCGEDHJLNP PMILFPOBAIB, int LCAOMLPPNHO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DIBLLMALBJM(MPFPPHBICHM MGDLKMJIAPA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFDIEDMKDIN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDBKPILMCKF(PNCGEDHJLNP PMILFPOBAIB, object LJDEIIANADH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BHANFGAHMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNOFKKPCMLH(DBKGEEBKAJK BCPDNOKLBDD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BIKFGMDMKCF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFLAINLBGGF(PNCGEDHJLNP PMILFPOBAIB, IPEndPoint ELLCIBBGBGD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MLJBHFKPGHB
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int BGMKABOOCGP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long KECNHLGLOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DDMAKCHKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NDDIHOBPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly GCJAGDGDKPI AEDKPPANMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int KKBIDGJPHIM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5327C30", Offset = "0x5326A30", VA = "0x185327C30")]
	private MLJBHFKPGHB(long HILPMHDCGAJ, byte BAKIIKGNIHF, int APAPEJEHLCD, byte[] EGNOFANOBFF, GCJAGDGDKPI KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53279F0", Offset = "0x53267F0", VA = "0x1853279F0")]
	public static int EDPNJDDIDKA(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53277D0", Offset = "0x53265D0", VA = "0x1853277D0")]
	public static MLJBHFKPGHB BGFFEKINHAL(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5327A50", Offset = "0x5326850", VA = "0x185327A50")]
	public static EFGCGHDPMKK NJJCGPFMDDO(FNAHOPJDFFA ALCADFBCFAC, SocketAddress APALBHNNJGJ, long ADJDBDLPMNK, int APAPEJEHLCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PKIFGHFNEPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long KECNHLGLOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte DDMAKCHKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int KKBIDGJPHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AOGHAAJBJLC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5328140", Offset = "0x5326F40", VA = "0x185328140")]
	private PKIFGHFNEPP(long HILPMHDCGAJ, byte BAKIIKGNIHF, int NFJEHBKKLGO, bool PABMDBNPKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5327F00", Offset = "0x5326D00", VA = "0x185327F00")]
	public static PKIFGHFNEPP BGFFEKINHAL(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5328050", Offset = "0x5326E50", VA = "0x185328050")]
	public static EFGCGHDPMKK NJJCGPFMDDO(long ADJDBDLPMNK, byte HGJGJLNIJOD, int DBMKJDDJHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5327E00", Offset = "0x5326C00", VA = "0x185327E00")]
	public static EFGCGHDPMKK AKLNBMAALDL(PNCGEDHJLNP PMILFPOBAIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct DOFHKABNHJC : IEquatable<DOFHKABNHJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long EOLJPFJJOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long DCNJIJJPNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long KBDDBBEOLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int CKIAMNBBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int KEEKNFOBADM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5318720", Offset = "0x5317520", VA = "0x185318720")]
	public DOFHKABNHJC(byte[] CGKDIHKHNOK, int JLOGILGGBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x797590", Offset = "0x796390", VA = "0x180797590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5318630", Offset = "0x5317430", VA = "0x185318630", Slot = "4")]
	public bool Equals(DOFHKABNHJC LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5318670", Offset = "0x5317470", VA = "0x185318670", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BCKGAGBJEBB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] MGFOFDOKAAJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5315000", Offset = "0x5313E00", VA = "0x185315000")]
	public BCKGAGBJEBB(byte[] CGKDIHKHNOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class CBHOLFBCHCA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class KDLKHBLNCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5325310", Offset = "0x5324110", VA = "0x185325310")]
		public static extern int CMMGCFHAKAM(IntPtr PDDFCKGBHHG, [In][Out] byte[] ALBNFONPBLI, [In] int JLOGILGGBPF, [In] SocketFlags KPAADPNNIHD, [Out] byte[] IGOOCDEGONE, [In][Out] int PNILFHFAHHL);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5325230", Offset = "0x5324030", VA = "0x185325230")]
		internal static extern int AAIEBEHMAOG(IntPtr PDDFCKGBHHG, [In] byte[] ALBNFONPBLI, [In] int JLOGILGGBPF, [In] SocketFlags KPAADPNNIHD, [In] byte[] IGOOCDEGONE, [In] int PNILFHFAHHL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class MFGKFEOLJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5327690", Offset = "0x5326490", VA = "0x185327690")]
		public static extern int CMMGCFHAKAM(IntPtr PDDFCKGBHHG, [In][Out] byte[] ALBNFONPBLI, [In] int JLOGILGGBPF, [In] SocketFlags KPAADPNNIHD, [Out] byte[] IGOOCDEGONE, [In][Out] int PNILFHFAHHL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x53275B0", Offset = "0x53263B0", VA = "0x1853275B0")]
		internal static extern int AAIEBEHMAOG(IntPtr PDDFCKGBHHG, [In] byte[] ALBNFONPBLI, [In] int JLOGILGGBPF, [In] SocketFlags KPAADPNNIHD, [In] byte[] IGOOCDEGONE, [In] int PNILFHFAHHL);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool DBLHBCFHBLK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool HCDHMFNFAAO;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> NEIKABNBDMD;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53167A0", Offset = "0x53155A0", VA = "0x1853167A0")]
	static CBHOLFBCHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5316560", Offset = "0x5315360", VA = "0x185316560")]
	public static int HALIKCEOCOH(IntPtr PDDFCKGBHHG, byte[] ALBNFONPBLI, int JLOGILGGBPF, byte[] IGOOCDEGONE, int PNILFHFAHHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5316610", Offset = "0x5315410", VA = "0x185316610")]
	public static int PBNHHKBAOBM(IntPtr PDDFCKGBHHG, byte[] ALBNFONPBLI, int JLOGILGGBPF, byte[] IGOOCDEGONE, int PNILFHFAHHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5316280", Offset = "0x5315080", VA = "0x185316280")]
	public static SocketError DALKLNGBDKC()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5316370", Offset = "0x5315170", VA = "0x185316370")]
	public static SocketException DOKAFKNLGAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x53164B0", Offset = "0x53152B0", VA = "0x1853164B0")]
	public static short GODCDKBIKHJ(IPEndPoint GPIMOJELPAM)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PGNLMFEFIBK
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MHBEJHHPLIG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKOIGHPGABG(IPEndPoint HHEMHDONHGH, IPEndPoint GPIMOJELPAM, string HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPPPJOAHHAH(IPEndPoint LGOKCIADKBB, PGNLMFEFIBK AOPDMLJGEMB, string HOBAPMCPFML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class BGPNEPJEPGO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct LBIIPPMFDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint CFBFFOOMPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint IOBKLKJAMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string IDCBGCHLKGB;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct DMMPPDNKMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint BKJPGJJALBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PGNLMFEFIBK OIIFFAPKJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string IDCBGCHLKGB;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class ANLBNINAPCG
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint GIGMNAAMOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IDCBGCHLKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public ANLBNINAPCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class EGHBDPBJKPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GIGMNAAMOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint EDNHHMOICDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IDCBGCHLKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public EGHBDPBJKPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class ILKGMDGOICO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IDCBGCHLKGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OHOJCLBFIJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7717F0", Offset = "0x7705F0", VA = "0x1807717F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public ILKGMDGOICO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly IFCELBAHMCA POPGFEEOAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<LBIIPPMFDOG> EKNNDHEJEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<DMMPPDNKMPN> IPGFDLCPOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly GCJAGDGDKPI KKGFLKNEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FNAHOPJDFFA OFNALGMFACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FIDIGKINNCN FLEKPNFDGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private MHBEJHHPLIG KFLNABLOJNP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int GOOLFLKNIOC = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool MEEMOOOLJAH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5315D50", Offset = "0x5314B50", VA = "0x185315D50")]
	internal BGPNEPJEPGO(IFCELBAHMCA ABGOLONJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5315BF0", Offset = "0x53149F0", VA = "0x185315BF0")]
	internal void LOAGBCICFDN(IPEndPoint HGJIPKGOILF, EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x22A2530", Offset = "0x22A1330", VA = "0x1822A2530")]
	private void DBJDOEAFMEN<T>(T BCPDNOKLBDD, IPEndPoint PODCKBKAANA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5315A60", Offset = "0x5314860", VA = "0x185315A60")]
	private void HKOIGHPGABG(ANLBNINAPCG FONKFDNEOLE, IPEndPoint HGJIPKGOILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5315740", Offset = "0x5314540", VA = "0x185315740")]
	private void DBMCLGMFNEI(EGHBDPBJKPB FONKFDNEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53158C0", Offset = "0x53146C0", VA = "0x1853158C0")]
	private void DINPFBBJANC(ILKGMDGOICO FONKFDNEOLE, IPEndPoint HGJIPKGOILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NCCHOAHOLAA : byte
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
public static class BOHNNOEDDKL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] OPEDKGLAHMK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int GIGOOMCENLG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int MNGGBDOCAKG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AAACAKPAENO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5314A80", Offset = "0x5313880", VA = "0x185314A80")]
	public AAACAKPAENO(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ABMOFELAGKO : AAACAKPAENO
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5314A80", Offset = "0x5313880", VA = "0x185314A80")]
	public ABMOFELAGKO(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum MGECJLIMGPI
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
public interface CGBPEJGCHBG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBJNHDKILFD(MGECJLIMGPI POGHILFEMND, string MPLLGADEBOG, params object[] BONEGMDLPMG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DBIMDAPOGIG
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static CGBPEJGCHBG GPFMDIGGDBG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object FNMJBHFLMFH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5316EA0", Offset = "0x5315CA0", VA = "0x185316EA0")]
	private static void AOFLMMHFEHL(MGECJLIMGPI GNBKPGDFOBP, string MPLLGADEBOG, params object[] BONEGMDLPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5317190", Offset = "0x5315F90", VA = "0x185317190")]
	internal static void LHGMLELNLGJ(string MPLLGADEBOG, params object[] BONEGMDLPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53170D0", Offset = "0x5315ED0", VA = "0x1853170D0")]
	internal static void EFOCADKIOIB(string MPLLGADEBOG, params object[] BONEGMDLPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5317130", Offset = "0x5315F30", VA = "0x185317130")]
	internal static void GENIMEIFDLJ(string MPLLGADEBOG, params object[] BONEGMDLPMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DELJFKABBDE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class HMHBAIJGCOP : GCJAGDGDKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EFGCGHDPMKK MGJACPADMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IFCELBAHMCA HCHINBGCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly HCGLMLFHNPG BEECGGDDHJL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x531C730", Offset = "0x531B530", VA = "0x18531C730")]
	internal HMHBAIJGCOP(IFCELBAHMCA LBHKILDBCNO, HCGLMLFHNPG CAMMNCKJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x531C610", Offset = "0x531B410", VA = "0x18531C610")]
	internal void BLFHEMDMGBA(EFGCGHDPMKK BCPDNOKLBDD, int HKNEKNMEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x531C680", Offset = "0x531B480", VA = "0x18531C680")]
	internal void BNFMCLDEOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x531C700", Offset = "0x531B500", VA = "0x18531C700")]
	public void DFNANFENNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class HCGLMLFHNPG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum ACDHEOHKCLH
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
	public HCGLMLFHNPG PFPABELFGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public ACDHEOHKCLH OIIFFAPKJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public PNCGEDHJLNP LIEMOOGAIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint IOBKLKJAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object JACJMACKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MFNBNKINOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError LPAMDEAAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public GMDJNAGNEME FCNIPCKJGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public MPFPPHBICHM PAJFEPGJODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NCCHOAHOLAA KMCOKGFIPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte FBBBPCCFOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly HMHBAIJGCOP EMHMENDBDDP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x531C3B0", Offset = "0x531B1B0", VA = "0x18531C3B0")]
	public HCGLMLFHNPG(IFCELBAHMCA LBHKILDBCNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IFCELBAHMCA : IEnumerable<PNCGEDHJLNP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class HMIOADBIGNI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x531C780", Offset = "0x531B580", VA = "0x18531C780", Slot = "4")]
		public bool Equals(IPEndPoint GPMOHKANAAB, IPEndPoint GGKPCMCCKDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DD3890", Offset = "0x4DD2690", VA = "0x184DD3890", Slot = "5")]
		public int GetHashCode(IPEndPoint KANAGAAAGHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public HMIOADBIGNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct JEDHOBMECGE : IEnumerator<PNCGEDHJLNP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly PNCGEDHJLNP COJPFGIMBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private PNCGEDHJLNP DGBHBKNLDJF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PNCGEDHJLNP POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7FF8E0", Offset = "0x7FE6E0", VA = "0x1807FF8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FF8E0", Offset = "0x7FE6E0", VA = "0x1807FF8E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE28B00", Offset = "0xE27900", VA = "0x180E28B00")]
		public JEDHOBMECGE(PNCGEDHJLNP JAHBPEHPOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5325190", Offset = "0x5323F90", VA = "0x185325190", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53251E0", Offset = "0x5323FE0", VA = "0x1853251E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread AAAMNBNEFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool NPBFFJKPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent ECEAHODIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<HCGLMLFHNPG> EOFFFLKDEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<HCGLMLFHNPG> CDGLGELIGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private HCGLMLFHNPG POJGFDHNLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DGBNHAMPMEP MKENFMNMCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IFDIEDMKDIN CFDMEAANLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly BHANFGAHMCP CCNKDGEFLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly BIKFGMDMKCF NGGBKOAEGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, PNCGEDHJLNP> MMPOEDNIGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, MPFPPHBICHM> CHJNFOOGMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, FFHEGJPOGAA> HNBNEFMDKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim PIDDFCAFHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private PNCGEDHJLNP BKGPBALGCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int OGNPDLIBKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<PNCGEDHJLNP> MGMPKPNNDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private PNCGEDHJLNP[] EIJAHLCAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GFCOICCGHBC LNPDJJJCHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int AKKDGJOCHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> LNEBPPNMHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte FKBHGABPPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object DPJLCCNIECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool OCNKIIJPDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool BOOMOFPGLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int JFEIHECIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CKNKDOEPGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int OGMDFOGJHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool GKGBPNMMEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LOHODENADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int BMFDLFALBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int OKAIPABIMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int MCOMMFCJGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool MEEMOOOLJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool KJFOAMJECOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool IBMLEJGJBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool JFLNGCHHLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int DOKGFNDLEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int LJGGCNCONPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool PEIEAKPKFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly BFFHPMJOHPL FCCDEEELGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool CHFHOLFENGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly BGPNEPJEPGO LHMCPABMCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NGMKCPAFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public DELJFKABBDE HGAIDLNIPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int MLHKBBANFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool KDCCMJGJBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool OINBPLKBPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool LDNMCMAJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool BBLOFKOGAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private EFGCGHDPMKK IELNPJLMCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int OJIFLJCCKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object NOILODJBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int IDFEFKOKJKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int FFEAMDOCKDF = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket ABFOBGPLHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket BBHLNLPAPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread GMBEENALLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread GBCACGFMFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint EIEEKGNMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint OHIMOCJILHM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] EEAGJKBEPPH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] LFHELOHABCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<DOFHKABNHJC, IPEndPoint> GBPJCGHINOA;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int NLDLABAFHMP = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress CGOJCCHLLBH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool MPJBNAMOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int OBDEJFKHAJB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FHPCPPDCLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1218ED0", Offset = "0x1217CD0", VA = "0x181218ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1218EE0", Offset = "0x1217CE0", VA = "0x181218EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OHFIHJJGIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x14D61A0", Offset = "0x14D4FA0", VA = "0x1814D61A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x14D5CC0", Offset = "0x14D4AC0", VA = "0x1814D5CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ILKFPPJLICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E8920", Offset = "0x7E7720", VA = "0x1807E8920")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JOHAIBHDGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5320DE0", Offset = "0x531FBE0", VA = "0x185320DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short NPFJBNHGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5322CF0", Offset = "0x5321AF0", VA = "0x185322CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x531FD90", Offset = "0x531EB90", VA = "0x18531FD90")]
	public void ICOLCNEINCA(IPEndPoint HGPCKOKGCHD, byte[] GAMCILOFBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x531CF00", Offset = "0x531BD00", VA = "0x18531CF00")]
	public void BCHKCJMPMGA(IPEndPoint HGPCKOKGCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5320FD0", Offset = "0x531FDD0", VA = "0x185320FD0")]
	private bool KOAKNFDOKFJ(IPEndPoint HGPCKOKGCHD, [Out] PNCGEDHJLNP PMILFPOBAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x53239B0", Offset = "0x53227B0", VA = "0x1853239B0")]
	private void PNJLEDAIOAA(PNCGEDHJLNP PMILFPOBAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5322710", Offset = "0x5321510", VA = "0x185322710")]
	private void PBGFLBAIKNC(PNCGEDHJLNP PMILFPOBAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5320B80", Offset = "0x531F980", VA = "0x185320B80")]
	private void JJKKNFJFKOL(PNCGEDHJLNP PMILFPOBAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5323E50", Offset = "0x5322C50", VA = "0x185323E50")]
	public IFCELBAHMCA(DGBNHAMPMEP PJBPBPIPFHJ, [Optional] GFCOICCGHBC OLJEBFKPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x531D130", Offset = "0x531BF30", VA = "0x18531D130")]
	internal void CEIKEOJBCPI(PNCGEDHJLNP EPNIAEMHJEA, int LCAOMLPPNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5322470", Offset = "0x5321270", VA = "0x185322470")]
	internal void OCICNFDELGG(PNCGEDHJLNP EPNIAEMHJEA, object LJDEIIANADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x531DC10", Offset = "0x531CA10", VA = "0x18531DC10")]
	internal void EKKKNHPODJK(PNCGEDHJLNP PMILFPOBAIB, GMDJNAGNEME HGDPOIIJHAL, SocketError MAPLOBJCNBF, EFGCGHDPMKK IKMBJNHMLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x531F6F0", Offset = "0x531E4F0", VA = "0x18531F6F0")]
	private void FPBFIACCAPH(PNCGEDHJLNP PMILFPOBAIB, GMDJNAGNEME HGDPOIIJHAL, SocketError MAPLOBJCNBF, bool OOFPOBCGECA, byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int PDNIMDHODLH, EFGCGHDPMKK IKMBJNHMLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5321160", Offset = "0x531FF60", VA = "0x185321160")]
	private void LPELMEJGAFL(HCGLMLFHNPG.ACDHEOHKCLH AOPDMLJGEMB, [Optional] PNCGEDHJLNP PMILFPOBAIB, [Optional] IPEndPoint GPIMOJELPAM, SocketError NPEPKMIBJLK = SocketError.Success, int LCAOMLPPNHO = 0, GMDJNAGNEME HJAKHGGEEKH = GMDJNAGNEME.ConnectionFailed, [Optional] MPFPPHBICHM LKKOFNBDFPG, NCCHOAHOLAA LCBFKEGHKFI = NCCHOAHOLAA.Unreliable, byte PBAOMBJLIJI = 0, [Optional] EFGCGHDPMKK CBHFKAHIFJM, [Optional] object LJDEIIANADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5321980", Offset = "0x5320780", VA = "0x185321980")]
	private void MPFIDANPCFJ(HCGLMLFHNPG CAMMNCKJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5321060", Offset = "0x531FE60", VA = "0x185321060")]
	internal void LHMPDJPLHCL(HCGLMLFHNPG CAMMNCKJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x531D180", Offset = "0x531BF80", VA = "0x18531D180")]
	private void CNHAIAOLFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x531CBE0", Offset = "0x531B9E0", VA = "0x18531CBE0")]
	private void BBLOGAOLLCG(int EPBLCKJKIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x531E050", Offset = "0x531CE50", VA = "0x18531E050")]
	internal PNCGEDHJLNP ENDLFLFPDOP(MPFPPHBICHM MGDLKMJIAPA, byte[] PPKCMOPOCLB, int EIJIJLGPLFO, int ELGJIDFGJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x531D4C0", Offset = "0x531C2C0", VA = "0x18531D4C0")]
	private int DFPJOFDCFNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x531E890", Offset = "0x531D690", VA = "0x18531E890")]
	private void FIODNMDFIKM(IPEndPoint GPIMOJELPAM, PNCGEDHJLNP AKIDDNEGBHD, MLJBHFKPGHB PEAJFOCFPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x531FE30", Offset = "0x531EC30", VA = "0x18531FE30")]
	private void IHMEHJDLAMM(EFGCGHDPMKK BCPDNOKLBDD, IPEndPoint GPIMOJELPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x53216C0", Offset = "0x53204C0", VA = "0x1853216C0")]
	internal void MKCGAJJMGDL(EFGCGHDPMKK BCPDNOKLBDD, NCCHOAHOLAA LGJFHHINKLP, byte PBAOMBJLIJI, int HKNEKNMEAIK, PNCGEDHJLNP EPNIAEMHJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x531ED90", Offset = "0x531DB90", VA = "0x18531ED90")]
	public bool FKBNENBLEJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x531ECF0", Offset = "0x531DAF0", VA = "0x18531ECF0")]
	public bool FKBNENBLEJE(IPAddress EGMOOMFOPBA, IPAddress JDBEDJBGOMD, int EEOKFEAOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x531ED10", Offset = "0x531DB10", VA = "0x18531ED10")]
	public bool FKBNENBLEJE(int EEOKFEAOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x531FBF0", Offset = "0x531E9F0", VA = "0x18531FBF0")]
	public void HIBIHECBOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5322B30", Offset = "0x5321930", VA = "0x185322B30")]
	public PNCGEDHJLNP PBOHHHALCIA(string CGKDIHKHNOK, int EEOKFEAOFPE, string GAMCILOFBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5322C10", Offset = "0x5321A10", VA = "0x185322C10")]
	public PNCGEDHJLNP PBOHHHALCIA(string CGKDIHKHNOK, int EEOKFEAOFPE, FNAHOPJDFFA GOLGGDGBOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5322760", Offset = "0x5321560", VA = "0x185322760")]
	public PNCGEDHJLNP PBOHHHALCIA(IPEndPoint PODCKBKAANA, FNAHOPJDFFA GOLGGDGBOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x531F7D0", Offset = "0x531E5D0", VA = "0x18531F7D0")]
	public void GGDFNKIBDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x531F7E0", Offset = "0x531E5E0", VA = "0x18531F7E0")]
	public void GGDFNKIBDKM(bool LHLNCGDEMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x531E670", Offset = "0x531D470", VA = "0x18531E670")]
	public void FICKINBICJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x531E770", Offset = "0x531D570", VA = "0x18531E770")]
	public void FICKINBICJL(byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int PDNIMDHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x531F640", Offset = "0x531E440", VA = "0x18531F640")]
	public void FPBFIACCAPH(PNCGEDHJLNP PMILFPOBAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x531F580", Offset = "0x531E380", VA = "0x18531F580")]
	public void FPBFIACCAPH(PNCGEDHJLNP PMILFPOBAIB, byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int PDNIMDHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5323C70", Offset = "0x5322A70", VA = "0x185323C70", Slot = "4")]
	private IEnumerator<PNCGEDHJLNP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5323D00", Offset = "0x5322B00", VA = "0x185323D00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5320EE0", Offset = "0x531FCE0", VA = "0x185320EE0")]
	private EFGCGHDPMKK KBNHCHMOIIL(DJOGNABHLDB NEBGFGPEMHL, int ICPPKLAMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5320E00", Offset = "0x531FC00", VA = "0x185320E00")]
	private EFGCGHDPMKK KBNHCHMOIIL(DJOGNABHLDB NEBGFGPEMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5322140", Offset = "0x5320F40", VA = "0x185322140")]
	internal EFGCGHDPMKK NGDLIKPGKMD(int ICPPKLAMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5322300", Offset = "0x5321100", VA = "0x185322300")]
	internal void NLNJDKDNGJE(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5323D90", Offset = "0x5322B90", VA = "0x185323D90")]
	static IFCELBAHMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1218ED0", Offset = "0x1217CD0", VA = "0x181218ED0")]
	private bool AOBMNHPEBOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x531FB00", Offset = "0x531E900", VA = "0x18531FB00")]
	private void HHCNJPJEFEA(IPEndPoint DAJCHOIHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x531D050", Offset = "0x531BE50", VA = "0x18531D050")]
	private void BMLHKHDIFGJ(IPEndPoint DAJCHOIHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5321520", Offset = "0x5320320", VA = "0x185321520")]
	private bool MDDHHOLBGDP(SocketException OLGCAAMGCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53224C0", Offset = "0x53212C0", VA = "0x1853224C0")]
	private void OKBPBGPFODO(Socket ABGOLONJNJG, EndPoint KLHAFJCHPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x531C7F0", Offset = "0x531B5F0", VA = "0x18531C7F0")]
	private void ANPIIJHDBAG(object BHDPLHMNJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x531DCE0", Offset = "0x531CAE0", VA = "0x18531DCE0")]
	private void ENAOGALADHH(object BHDPLHMNJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x531EDA0", Offset = "0x531DBA0", VA = "0x18531EDA0")]
	public bool FKBNENBLEJE(IPAddress EGMOOMFOPBA, IPAddress JDBEDJBGOMD, int EEOKFEAOFPE, bool OFLPEDOEEOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x531D540", Offset = "0x531C340", VA = "0x18531D540")]
	private bool ECBHOHDHHII(Socket ABGOLONJNJG, IPEndPoint DAJCHOIHCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x531CB80", Offset = "0x531B980", VA = "0x18531CB80")]
	internal int APDDNJFHDJA(EFGCGHDPMKK BCPDNOKLBDD, IPEndPoint GPIMOJELPAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5323970", Offset = "0x5322770", VA = "0x185323970")]
	internal int PIPODBODKAF(EFGCGHDPMKK BCPDNOKLBDD, IPEndPoint GPIMOJELPAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5322D20", Offset = "0x5321B20", VA = "0x185322D20")]
	internal int PIPODBODKAF(byte[] KHIFMDJDLEG, int EIJIJLGPLFO, int ELGJIDFGJJH, IPEndPoint GPIMOJELPAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x531DAE0", Offset = "0x531C8E0", VA = "0x18531DAE0")]
	internal void ECKDKHEHEGL(bool KLCGBIHBLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum DJOGNABHLDB : byte
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
internal sealed class EFGCGHDPMKK
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int IAIKIADFBJA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] DFKCBIHBMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] ACKHIANPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int BMGCJGPBFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object JACJMACKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public EFGCGHDPMKK PFPABELFGLC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DJOGNABHLDB DGMNHBLODHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5318A40", Offset = "0x5317840", VA = "0x185318A40")]
		get
		{
			return default(DJOGNABHLDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x53188C0", Offset = "0x53176C0", VA = "0x1853188C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DDMAKCHKOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5318C70", Offset = "0x5317A70", VA = "0x185318C70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5318900", Offset = "0x5317700", VA = "0x185318900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort JBKMEDMONIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5318A70", Offset = "0x5317870", VA = "0x185318A70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5318810", Offset = "0x5317610", VA = "0x185318810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DFMPNNBDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5318DA0", Offset = "0x5317BA0", VA = "0x185318DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HPNOPDEAJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5318890", Offset = "0x5317690", VA = "0x185318890")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5318D70", Offset = "0x5317B70", VA = "0x185318D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GHHNNBCCAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5318AD0", Offset = "0x53178D0", VA = "0x185318AD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5318B30", Offset = "0x5317930", VA = "0x185318B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JLHIACBBLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5318DD0", Offset = "0x5317BD0", VA = "0x185318DD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5318850", Offset = "0x5317650", VA = "0x185318850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DBHHELOGPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5318CE0", Offset = "0x5317AE0", VA = "0x185318CE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5318CA0", Offset = "0x5317AA0", VA = "0x185318CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5318E30", Offset = "0x5317C30", VA = "0x185318E30")]
	static EFGCGHDPMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5318D40", Offset = "0x5317B40", VA = "0x185318D40")]
	public void JKNBNHAHNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5319110", Offset = "0x5317F10", VA = "0x185319110")]
	public EFGCGHDPMKK(int ICPPKLAMHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5319180", Offset = "0x5317F80", VA = "0x185319180")]
	public EFGCGHDPMKK(DJOGNABHLDB NEBGFGPEMHL, int ICPPKLAMHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53189D0", Offset = "0x53177D0", VA = "0x1853189D0")]
	public static int ELHMNMAMBDG(DJOGNABHLDB NEBGFGPEMHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5318940", Offset = "0x5317740", VA = "0x185318940")]
	public int ELHMNMAMBDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5318B70", Offset = "0x5317970", VA = "0x185318B70")]
	public bool IBODOIHMGIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum FFPPBFLFFPN : byte
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
internal enum EPDKFGDHNHO
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
internal enum NEFHNELCGHI
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum EKLHFGMCKPK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PNCGEDHJLNP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MCGPLNONBDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public EFGCGHDPMKK[] CCOCCMKJINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int HKGHPCDEMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int HEDFKLOOOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte HPNOPDEAJDK;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MCGPLNONBDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void CHKJDBIEPJC(ulong FPEMIDHLJMK, int LNCALMGAJOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int KLBPOEKIPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int GEJKPGKPDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int IACBFNDHELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double GJELCPPNBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int LMELPLNFEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int BKGHLFFPLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch EFKAJDCHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int HLICFOJFBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long MELJJHGPBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object IGGPILOEGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal PNCGEDHJLNP DANPPNHNIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal PNCGEDHJLNP GAPFOEEIAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<EFGCGHDPMKK> CBODMGKHDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<HINNOFFKILL> NNAEGNLAPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly HINNOFFKILL[] DOFGAPCLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int KHNAJBMKJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int BHGEBDLCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool LHBGDDNDAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int OFIOPNOEDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int CCEOBIMLGMD;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int IPOMHDDLJOB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int GCJLPLOCPPO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object LHPHDOAIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int KJGHLKIIDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, MCGPLNONBDH> GLNAPHPKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> CBNIHEHFDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EFGCGHDPMKK AOHMNAMNPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int NIIDJEPFGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LNCKEMBFMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint BKLOALCFMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int EGMMAHFMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int MFNFJJOMCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long DFEDCPIDNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte LEBDCFDOGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private FFPPBFLFFPN CHMKKBIFHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private EFGCGHDPMKK LOFLKHDLGAO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int FKCAJGNBBBM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int NDLBILLDBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly EFGCGHDPMKK CNMPDAOOAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly EFGCGHDPMKK FEMMCDCJOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly EFGCGHDPMKK DKELBPNMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly EFGCGHDPMKK BGDAMIGCDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly IFCELBAHMCA PNNMCMMBOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int EDMBHINBAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object MKNLNDEFHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly BFFHPMJOHPL FCCDEEELGEK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte JBOCBFOOGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E8910", Offset = "0x7E7710", VA = "0x1807E8910")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5329B30", Offset = "0x5328930", VA = "0x185329B30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ALENGJKDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x90AC80", Offset = "0x909A80", VA = "0x18090AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FFPPBFLFFPN IGLHKBLAGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x103B920", Offset = "0x103A720", VA = "0x18103B920")]
		get
		{
			return default(FFPPBFLFFPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long GMGBKMIMCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90AC90", Offset = "0x909A90", VA = "0x18090AC90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FIIGLOGCFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14D61B0", Offset = "0x14D4FB0", VA = "0x1814D61B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x14D51B0", Offset = "0x14D3FB0", VA = "0x1814D51B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DEHOKKIAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5328190", Offset = "0x5326F90", VA = "0x185328190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JKMAGGAIKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78D2D0", Offset = "0x78C0D0", VA = "0x18078D2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double IPJBLCBOMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x16C7380", Offset = "0x16C6180", VA = "0x1816C7380")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CHKJDBIEPJC ILGIOPLKONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x532B450", Offset = "0x532A250", VA = "0x18532B450")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x532A790", Offset = "0x5329590", VA = "0x18532A790")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x532B880", Offset = "0x532A680", VA = "0x18532B880")]
	internal PNCGEDHJLNP(IFCELBAHMCA IFPKOJCJNIO, IPEndPoint GPIMOJELPAM, int JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x532B500", Offset = "0x532A300", VA = "0x18532B500")]
	internal void NLLHLMKOPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5328B80", Offset = "0x5327980", VA = "0x185328B80")]
	internal void BNPKCNKJOGJ(IPEndPoint HMMCNAPAKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5329360", Offset = "0x5328160", VA = "0x185329360")]
	internal void DKFAKMNAIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5329290", Offset = "0x5328090", VA = "0x185329290")]
	private void DJABEIJFOCI(int OEJOPKIPCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5329B00", Offset = "0x5328900", VA = "0x185329B00")]
	private void HJIEFICNBCB(int KBNPNMHFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x532A8C0", Offset = "0x53296C0", VA = "0x18532A8C0")]
	private HINNOFFKILL LIAOEIMOELN(byte JOEPNNKIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x532BCE0", Offset = "0x532AAE0", VA = "0x18532BCE0")]
	internal PNCGEDHJLNP(IFCELBAHMCA IFPKOJCJNIO, IPEndPoint GPIMOJELPAM, int JPODHBJFPKM, byte HGJGJLNIJOD, FNAHOPJDFFA ALCADFBCFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x532BE70", Offset = "0x532AC70", VA = "0x18532BE70")]
	internal PNCGEDHJLNP(IFCELBAHMCA IFPKOJCJNIO, MPFPPHBICHM MGDLKMJIAPA, int JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5328B30", Offset = "0x5327930", VA = "0x185328B30")]
	internal void BKGODHBELIE(MLJBHFKPGHB FPPOOMDABPG, byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x532A840", Offset = "0x5329640", VA = "0x18532A840")]
	internal bool KPCMGKIJNBE(PKIFGHFNEPP BCPDNOKLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5329260", Offset = "0x5328060", VA = "0x185329260")]
	public void DBJDOEAFMEN(byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int ELGJIDFGJJH, NCCHOAHOLAA INHBNHHKMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5329BE0", Offset = "0x53289E0", VA = "0x185329BE0")]
	private void JLKPJNHNNOA(byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int ELGJIDFGJJH, byte PBAOMBJLIJI, NCCHOAHOLAA LCBFKEGHKFI, object LJDEIIANADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x532B090", Offset = "0x5329E90", VA = "0x18532B090")]
	public void NGBGKLPONKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x532A130", Offset = "0x5328F30", VA = "0x18532A130")]
	internal NEFHNELCGHI KCLDGFAHIOG(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return default(NEFHNELCGHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x532B820", Offset = "0x532A620", VA = "0x18532B820")]
	internal void PGMHOAIAEPE(HINNOFFKILL EBPLCGPEIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x532B140", Offset = "0x5329F40", VA = "0x18532B140")]
	internal EKLHFGMCKPK NHPEOMCCOND(byte[] KNAIEKIJLBC, int EIJIJLGPLFO, int ELGJIDFGJJH, bool OOFPOBCGECA)
	{
		return default(EKLHFGMCKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x532B7E0", Offset = "0x532A5E0", VA = "0x18532B7E0")]
	private void OOECDHLKBII(int GOOAEBFNHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x53281A0", Offset = "0x5326FA0", VA = "0x1853281A0")]
	internal void BJMJDDHCCCM(NCCHOAHOLAA LGJFHHINKLP, EFGCGHDPMKK JAHBPEHPOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x53293F0", Offset = "0x53281F0", VA = "0x1853293F0")]
	private void EJKNIMNKONC(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x532AD20", Offset = "0x5329B20", VA = "0x18532AD20")]
	private void MEIHHLHLALN(int JCDLMCEAGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5329940", Offset = "0x5328740", VA = "0x185329940")]
	internal EPDKFGDHNHO FIODNMDFIKM(MLJBHFKPGHB PEAJFOCFPGF)
	{
		return default(EPDKFGDHNHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5328BB0", Offset = "0x53279B0", VA = "0x185328BB0")]
	internal void BPFCJFEIGHH(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x532AA70", Offset = "0x5329870", VA = "0x18532AA70")]
	private void LKJHDBGFGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x532AB70", Offset = "0x5329970", VA = "0x18532AB70")]
	internal void MALEGDPIDEA(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x532A210", Offset = "0x5329010", VA = "0x18532A210")]
	internal void KHHFOFCHJNL(int JCDLMCEAGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x532B520", Offset = "0x532A320", VA = "0x18532B520")]
	internal void OJKHCNMMGJP(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BFFHPMJOHPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long BCCOIPBEJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long AOHPKCJFIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LAHPILIOFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long CFMJBOEPKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long HKCIOIPAPON;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MMNLKMGOGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53153A0", Offset = "0x53141A0", VA = "0x1853153A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DJBKNNPEEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53153F0", Offset = "0x53141F0", VA = "0x1853153F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long EPNIFDCEFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5315380", Offset = "0x5314180", VA = "0x185315380")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NNAHGABLAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x53153B0", Offset = "0x53141B0", VA = "0x1853153B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long JMNHILDIAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53153C0", Offset = "0x53141C0", VA = "0x1853153C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long JABEMLJKKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5315320", Offset = "0x5314120", VA = "0x185315320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x53153E0", Offset = "0x53141E0", VA = "0x1853153E0")]
	public void MJIOIHPDBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5315370", Offset = "0x5314170", VA = "0x185315370")]
	public void BJIBLABAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x53153D0", Offset = "0x53141D0", VA = "0x1853153D0")]
	public void MFKJPGBOADM(long PFPEGFKNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5315310", Offset = "0x5314110", VA = "0x185315310")]
	public void AABOFMHHOGN(long EBLGGEBAFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5315390", Offset = "0x5314190", VA = "0x185315390")]
	public void FBOOPBNBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5315400", Offset = "0x5314200", VA = "0x185315400")]
	public void PAKLPABEAPI(long PGLBINOFKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5315410", Offset = "0x5314210", VA = "0x185315410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public BFFHPMJOHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AMFINIGDDAE
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> KBDLDPFMMJD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5314AC0", Offset = "0x53138C0", VA = "0x185314AC0")]
	public static IPEndPoint HFNLKOEIGIO(string KBNENPHINOG, int EEOKFEAOFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5314D10", Offset = "0x5313B10", VA = "0x185314D10")]
	public static IPAddress LKIGEBNIEPL(string KBNENPHINOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5314EE0", Offset = "0x5313CE0", VA = "0x185314EE0")]
	public static IPAddress LKIGEBNIEPL(string KBNENPHINOG, AddressFamily FANJCEJGIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5314A90", Offset = "0x5313890", VA = "0x185314A90")]
	internal static int FAFDDHJKIJI(int JGOCNJGMCOP, int BPMKGPGNAHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B11D60", Offset = "0x2B10B60", VA = "0x182B11D60")]
	internal static T[] NCDHOBCNOMA<T>(int PDNIMDHODLH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GPOEPOHGHHL : HINNOFFKILL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GLHDHKPGKGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EFGCGHDPMKK MGJACPADMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long MFKCFAFMGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool AGOJJBCPPIH;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x531B280", Offset = "0x531A080", VA = "0x18531B280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x531B1F0", Offset = "0x5319FF0", VA = "0x18531B1F0")]
		public void PDINACCMPJM(EFGCGHDPMKK BCPDNOKLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x531B210", Offset = "0x531A010", VA = "0x18531B210")]
		public bool PFIEEANPFNI(long NPFIEDLBONG, PNCGEDHJLNP PMILFPOBAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x531B1A0", Offset = "0x5319FA0", VA = "0x18531B1A0")]
		public bool LPNBJONBLDG(PNCGEDHJLNP PMILFPOBAIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly EFGCGHDPMKK DAJLJIIBPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly GLHDHKPGKGO[] GPJMJFMMCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly EFGCGHDPMKK[] LPFMONAEJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] MAGOBKPALGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int EAEKPOIOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int FGDMIKLDFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int IFELOHPIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int DJBAJOINHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool OFCIMLIJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly NCCHOAHOLAA CNHEAGPBDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool OGNFABKELGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int KGIBJMIDADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte ENCEIJDIAFO;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x531C1E0", Offset = "0x531AFE0", VA = "0x18531C1E0")]
	public GPOEPOHGHHL(PNCGEDHJLNP PMILFPOBAIB, bool DCECBIOKPAB, byte JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x531B980", Offset = "0x531A780", VA = "0x18531B980")]
	private void LJBGBIHGGOL(EFGCGHDPMKK BCPDNOKLBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x531BD30", Offset = "0x531AB30", VA = "0x18531BD30", Slot = "4")]
	protected override bool NHCCNMOAIGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x531B320", Offset = "0x531A120", VA = "0x18531B320", Slot = "5")]
	public override bool BPFCJFEIGHH(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class KGDMCLCHKJB : HINNOFFKILL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int ALDLJJKJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort FGDMIKLDFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool GHEHEMJNAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private EFGCGHDPMKK MKHBDBGHBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly EFGCGHDPMKK CBIJDOEDKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool AJLGCMLNBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte ENCEIJDIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long HNMIBPPBNAO;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5325BA0", Offset = "0x53249A0", VA = "0x185325BA0")]
	public KGDMCLCHKJB(PNCGEDHJLNP PMILFPOBAIB, bool PDIJANDPELK, byte JPODHBJFPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5325730", Offset = "0x5324530", VA = "0x185325730", Slot = "4")]
	protected override bool NHCCNMOAIGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5325450", Offset = "0x5324250", VA = "0x185325450", Slot = "5")]
	public override bool BPFCJFEIGHH(EFGCGHDPMKK BCPDNOKLBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IOCILAIJAAM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct JPIDFGDICAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong IJLFNFAIDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double AFKICMICOKB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct ABDOMDMMIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int EMMLLNLEPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float PBJGMCLPNEA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5314990", Offset = "0x5313790", VA = "0x185314990")]
	private static void LFHBHGLNGMH(byte[] BNFLLCFHIAN, int PLIILJHILHI, ulong KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x53250A0", Offset = "0x5323EA0", VA = "0x1853250A0")]
	private static void LFHBHGLNGMH(byte[] BNFLLCFHIAN, int PLIILJHILHI, int KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5325030", Offset = "0x5323E30", VA = "0x185325030")]
	public static void LFHBHGLNGMH(byte[] BNFLLCFHIAN, int PLIILJHILHI, short KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5325070", Offset = "0x5323E70", VA = "0x185325070")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, double PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5325110", Offset = "0x5323F10", VA = "0x185325110")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5325030", Offset = "0x5323E30", VA = "0x185325030")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, short PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5325030", Offset = "0x5323E30", VA = "0x185325030")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, ushort PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x53250A0", Offset = "0x5323EA0", VA = "0x1853250A0")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53250A0", Offset = "0x5323EA0", VA = "0x1853250A0")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, uint PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5325090", Offset = "0x5323E90", VA = "0x185325090")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, long PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5325090", Offset = "0x5323E90", VA = "0x185325090")]
	public static void HJAEDBNGHDF(byte[] EHLPPEEOBND, int FNPACLAMELJ, ulong PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GCJAGDGDKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] CNPMALOCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int IOHANKBOJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int GJCBHPFAFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int DAJCPPFGIEH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] ACKHIANPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GLEHHCFBEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HOAPLCCCOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x531B040", Offset = "0x5319E40", VA = "0x18531B040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PPDBFFPBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BE8E70", Offset = "0x1BE7C70", VA = "0x181BE8E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int BOEMOGDPJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x531A6B0", Offset = "0x53194B0", VA = "0x18531A6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x531A6C0", Offset = "0x53194C0", VA = "0x18531A6C0")]
	public void BLFHEMDMGBA(byte[] KFIJLJLHGLL, int PLIILJHILHI, int BGNDPMCADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GCJAGDGDKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x531B140", Offset = "0x5319F40", VA = "0x18531B140")]
	public GCJAGDGDKPI(byte[] KFIJLJLHGLL, int PLIILJHILHI, int BGNDPMCADAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x531AE50", Offset = "0x5319C50", VA = "0x18531AE50")]
	public IPEndPoint IHDOOFIJNLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x531AFA0", Offset = "0x5319DA0", VA = "0x18531AFA0")]
	public byte LCJIJJAJNGJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x531AFA0", Offset = "0x5319DA0", VA = "0x18531AFA0")]
	public sbyte NMNMDHPKCJO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x24EEDB0", Offset = "0x24EDBB0", VA = "0x1824EEDB0")]
	public T[] HLCEKFOPBHM<T>(ushort ICPPKLAMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x531A920", Offset = "0x5319720", VA = "0x18531A920")]
	public bool[] EAKMKLLKJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x531AF60", Offset = "0x5319D60", VA = "0x18531AF60")]
	public ushort[] KOEJEIOHNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x531A670", Offset = "0x5319470", VA = "0x18531A670")]
	public short[] ADOHMCKPLOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x531B000", Offset = "0x5319E00", VA = "0x18531B000")]
	public int[] MDFBDADFGHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x531A8E0", Offset = "0x53196E0", VA = "0x18531A8E0")]
	public uint[] DPICAFNAOLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x531A630", Offset = "0x5319430", VA = "0x18531A630")]
	public float[] ADFECBBHPHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x531AF20", Offset = "0x5319D20", VA = "0x18531AF20")]
	public double[] IMMDIEMNOKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x531ABD0", Offset = "0x53199D0", VA = "0x18531ABD0")]
	public long[] HOMFGEEMDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x531AAB0", Offset = "0x53198B0", VA = "0x18531AAB0")]
	public ulong[] GLJJNDCALOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x531A7B0", Offset = "0x53195B0", VA = "0x18531A7B0")]
	public string[] CMKNDBHGMCD(int HNNEOOJCAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x531B100", Offset = "0x5319F00", VA = "0x18531B100")]
	public bool PMEGFALBEOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x531A550", Offset = "0x5319350", VA = "0x18531A550")]
	public char ABOJBPDDEGK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x531A550", Offset = "0x5319350", VA = "0x18531A550")]
	public ushort JAJLHPCPINN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x531B050", Offset = "0x5319E50", VA = "0x18531B050")]
	public short NMLDPNJCDLF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x531AB60", Offset = "0x5319960", VA = "0x18531AB60")]
	public long HMNOBHGLOKC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x531AA40", Offset = "0x5319840", VA = "0x18531AA40")]
	public ulong FLNBENAMFLJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x531AAF0", Offset = "0x53198F0", VA = "0x18531AAF0")]
	public int GPODIHINJLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x531A960", Offset = "0x5319760", VA = "0x18531A960")]
	public uint EDNJCJAEBEC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x531A9D0", Offset = "0x53197D0", VA = "0x18531A9D0")]
	public float FFBEBGPKNOJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x531A740", Offset = "0x5319540", VA = "0x18531A740")]
	public double CJGMAKFJGDJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x531AC10", Offset = "0x5319A10", VA = "0x18531AC10")]
	public string IFFDNOEFKNK(int EHMLDAMGILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x531A5C0", Offset = "0x53193C0", VA = "0x18531A5C0")]
	public ArraySegment<byte> ACLLILKBFPF(int PDNIMDHODLH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x531B0C0", Offset = "0x5319EC0", VA = "0x18531B0C0")]
	public sbyte[] OJPMGFDDEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x531A700", Offset = "0x5319500", VA = "0x18531A700")]
	public byte[] BPNLNMCKIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x531AFE0", Offset = "0x5319DE0", VA = "0x18531AFE0")]
	public void LPNBJONBLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FNAHOPJDFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] CNPMALOCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int IOHANKBOJNM;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int PHLPDAKGIBJ = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool FJAEFLFJPIL;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding JHCFDDALIGD;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int PBNOOMBNMII = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] BOEGIDDJEPB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] AEDKPPANMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DLGHEHGPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x531A430", Offset = "0x5319230", VA = "0x18531A430")]
	public FNAHOPJDFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x531A4B0", Offset = "0x53192B0", VA = "0x18531A4B0")]
	public FNAHOPJDFFA(bool IGHBIIMMBOG, int BLINFEPNMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5319CD0", Offset = "0x5318AD0", VA = "0x185319CD0")]
	public static FNAHOPJDFFA MOHAOMMHEEG(string PHPDIJICBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x53197E0", Offset = "0x53185E0", VA = "0x1853197E0")]
	public void LGCDPCNIFBL(int JHFHHOIEMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C62770", Offset = "0x1C61570", VA = "0x181C62770")]
	public void KICOEKABIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x531A300", Offset = "0x5319100", VA = "0x18531A300")]
	public void POHCMJOFOLB(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5319FE0", Offset = "0x5318DE0", VA = "0x185319FE0")]
	public void POHCMJOFOLB(double PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5319EB0", Offset = "0x5318CB0", VA = "0x185319EB0")]
	public void POHCMJOFOLB(long PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5319EB0", Offset = "0x5318CB0", VA = "0x185319EB0")]
	public void POHCMJOFOLB(ulong PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5319DB0", Offset = "0x5318BB0", VA = "0x185319DB0")]
	public void POHCMJOFOLB(int PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5319DB0", Offset = "0x5318BB0", VA = "0x185319DB0")]
	public void POHCMJOFOLB(uint PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5319D40", Offset = "0x5318B40", VA = "0x185319D40")]
	public void POHCMJOFOLB(char PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5319D40", Offset = "0x5318B40", VA = "0x185319D40")]
	public void POHCMJOFOLB(ushort PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5319D40", Offset = "0x5318B40", VA = "0x185319D40")]
	public void POHCMJOFOLB(short PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x531A240", Offset = "0x5319040", VA = "0x18531A240")]
	public void POHCMJOFOLB(sbyte PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x531A240", Offset = "0x5319040", VA = "0x18531A240")]
	public void POHCMJOFOLB(byte PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5319E40", Offset = "0x5318C40", VA = "0x185319E40")]
	public void POHCMJOFOLB(byte[] KNAIEKIJLBC, int PLIILJHILHI, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5319700", Offset = "0x5318500", VA = "0x185319700")]
	public void GJKGPOHIJBP(sbyte[] KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5319700", Offset = "0x5318500", VA = "0x185319700")]
	public void NBBNKJBGCNH(byte[] KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x531A2A0", Offset = "0x53190A0", VA = "0x18531A2A0")]
	public void POHCMJOFOLB(bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5319A30", Offset = "0x5318830", VA = "0x185319A30")]
	public void LGCLOPHHICM(Array OGDGMNJCAGC, int PHGOAONOGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5319880", Offset = "0x5318680", VA = "0x185319880")]
	public void LGCLOPHHICM(float[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5319B10", Offset = "0x5318910", VA = "0x185319B10")]
	public void LGCLOPHHICM(double[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5319B10", Offset = "0x5318910", VA = "0x185319B10")]
	public void LGCLOPHHICM(long[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5319B10", Offset = "0x5318910", VA = "0x185319B10")]
	public void LGCLOPHHICM(ulong[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5319880", Offset = "0x5318680", VA = "0x185319880")]
	public void LGCLOPHHICM(int[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5319880", Offset = "0x5318680", VA = "0x185319880")]
	public void LGCLOPHHICM(uint[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5319BF0", Offset = "0x53189F0", VA = "0x185319BF0")]
	public void LGCLOPHHICM(ushort[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5319BF0", Offset = "0x53189F0", VA = "0x185319BF0")]
	public void LGCLOPHHICM(short[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5319700", Offset = "0x5318500", VA = "0x185319700")]
	public void LGCLOPHHICM(bool[] PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5319960", Offset = "0x5318760", VA = "0x185319960")]
	public void LGCLOPHHICM(string[] PHPDIJICBJO, int DBAENCJIAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5319F10", Offset = "0x5318D10", VA = "0x185319F10")]
	public void POHCMJOFOLB(IPEndPoint HGPCKOKGCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5319F00", Offset = "0x5318D00", VA = "0x185319F00")]
	public void POHCMJOFOLB(string PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x531A030", Offset = "0x5318E30", VA = "0x18531A030")]
	public void POHCMJOFOLB(string PHPDIJICBJO, int EHMLDAMGILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FIDIGKINNCN
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class HJLCKFLCEOO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong EDMBHINBAGN;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3657220", Offset = "0x3656020", VA = "0x183657220")]
		static HJLCKFLCEOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void ADJDGFNKOAM(GCJAGDGDKPI EIFCDBMOGEN, object LJDEIIANADH);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NOFGAHNOFCI<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public FIDIGKINNCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public NOFGAHNOFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3D30B20", Offset = "0x3D2F920", VA = "0x183D30B20")]
		internal void PHOPOJDDDNJ(GCJAGDGDKPI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class HAGPFDJCOBG<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public FIDIGKINNCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public HAGPFDJCOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3623240", Offset = "0x3622040", VA = "0x183623240")]
		internal void PHOPOJDDDNJ(GCJAGDGDKPI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly CCHPFCLNCGP IIAEMKCOBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, ADJDGFNKOAM> NMNONIDJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly FNAHOPJDFFA OKDIEEPDJGL;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5319580", Offset = "0x5318380", VA = "0x185319580")]
	public FIDIGKINNCN(int HNNEOOJCAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A58C0", VA = "0x1822A6AC0", Slot = "4")]
	protected virtual ulong HKPJOOBEHHC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5319450", Offset = "0x5318250", VA = "0x185319450", Slot = "5")]
	protected virtual ADJDGFNKOAM NMPIKEGKDJH(GCJAGDGDKPI EIFCDBMOGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x24C6850", Offset = "0x24C5650", VA = "0x1824C6850", Slot = "6")]
	protected virtual void CDONONOGGHD<T>(FNAHOPJDFFA NEGHIHACAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5319380", Offset = "0x5318180", VA = "0x185319380")]
	public void BLNPIAAEKCO(GCJAGDGDKPI EIFCDBMOGEN, object LJDEIIANADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x24C68C0", Offset = "0x24C56C0", VA = "0x1824C68C0")]
	public void FDCGHODCMHC<T>(FNAHOPJDFFA NEGHIHACAHG, T BCPDNOKLBDD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5319400", Offset = "0x5318200", VA = "0x185319400")]
	public void DPFFFMFKJML(GCJAGDGDKPI EIFCDBMOGEN, object LJDEIIANADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x24C6AD0", Offset = "0x24C58D0", VA = "0x1824C6AD0")]
	public void HNFFHDMCHGK<T>(Action<T> DPBFLEKJIIG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x24C6950", Offset = "0x24C5750", VA = "0x1824C6950")]
	public void HNFFHDMCHGK<T, TUserData>(Action<T, TUserData> DPBFLEKJIIG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CBPLJKMBBCK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5314A80", Offset = "0x5313880", VA = "0x185314A80")]
	public CBPLJKMBBCK(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class LDEONEJBEAI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5325C60", Offset = "0x5324A60", VA = "0x185325C60")]
	public LDEONEJBEAI(string KHIFMDJDLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CCHPFCLNCGP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum LMKOIJOEDGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class IILOBHJMOLF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public LMKOIJOEDGD OIIFFAPKJEG;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x375A190", Offset = "0x3758F90", VA = "0x18375A190", Slot = "4")]
		public virtual void PDINACCMPJM(MethodInfo BDELFPJOGPA, MethodInfo POENNLALFNK, LMKOIJOEDGD AOPDMLJGEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JINHADDMGLL(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DBNOBJNEDPA(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		protected IILOBHJMOLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class GFNHNMPGGKJ<TClass, TProperty> : IILOBHJMOLF<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> JJBAKFPFDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> DLKJOBOFHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> PIOPFAELKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> MNHLIJMGFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> IMHHPPBHBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> AMNGFJCLLCK;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x35BB5F0", Offset = "0x35BA3F0", VA = "0x1835BB5F0", Slot = "7")]
		public override void AGDNKPOPEKD(TClass LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x35BE160", Offset = "0x35BCF60", VA = "0x1835BE160", Slot = "8")]
		public override void NHILOPALGGK(TClass LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35BD600", Offset = "0x35BC400", VA = "0x1835BD600", Slot = "9")]
		public override void JINHADDMGLL(TClass LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35BCA10", Offset = "0x35BB810", VA = "0x1835BCA10", Slot = "10")]
		public override void DBNOBJNEDPA(TClass LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35BCBD0", Offset = "0x35BB9D0", VA = "0x1835BCBD0")]
		protected TProperty[] EGAKDBEINHK(TClass LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x35BCCD0", Offset = "0x35BBAD0", VA = "0x1835BCCD0")]
		protected TProperty[] HEFFNKGECBK(TClass LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x35C0680", Offset = "0x35BF480", VA = "0x1835C0680", Slot = "4")]
		public override void PDINACCMPJM(MethodInfo BDELFPJOGPA, MethodInfo POENNLALFNK, LMKOIJOEDGD AOPDMLJGEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x35C2EC0", Offset = "0x35C1CC0", VA = "0x1835C2EC0")]
		protected GFNHNMPGGKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class JMIJLFACHMO<TClass, TProperty> : GFNHNMPGGKJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void DDADNJBDBCD(GCJAGDGDKPI OLDPDBPDEBC, [Out] TProperty HICAGFPLJOE);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OJFIOOEELAK(FNAHOPJDFFA KHMJGMFIADM, TProperty HICAGFPLJOE);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39C5960", Offset = "0x39C4760", VA = "0x1839C5960", Slot = "5")]
		public override void KIKHHJIJDCP(TClass LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x39C5870", Offset = "0x39C4670", VA = "0x1839C5870", Slot = "6")]
		public override void FDCGHODCMHC(TClass LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39C5760", Offset = "0x39C4560", VA = "0x1839C5760", Slot = "7")]
		public override void AGDNKPOPEKD(TClass LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39C5A80", Offset = "0x39C4880", VA = "0x1839C5A80", Slot = "8")]
		public override void NHILOPALGGK(TClass LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x30FAEF0", Offset = "0x30F9CF0", VA = "0x1830FAEF0")]
		protected JMIJLFACHMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OHEILBJDFHJ<T> : GFNHNMPGGKJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5570", Offset = "0x3DE4370", VA = "0x183DE5570", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x30FF000", Offset = "0x30FDE00", VA = "0x1830FF000", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5500", Offset = "0x3DE4300", VA = "0x183DE5500", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x30FF0D0", Offset = "0x30FDED0", VA = "0x1830FF0D0", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public OHEILBJDFHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EOEAEBGJOFJ<T> : GFNHNMPGGKJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x30FF060", Offset = "0x30FDE60", VA = "0x1830FF060", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x30FF000", Offset = "0x30FDE00", VA = "0x1830FF000", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x30FEF90", Offset = "0x30FDD90", VA = "0x1830FEF90", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x30FF0D0", Offset = "0x30FDED0", VA = "0x1830FF0D0", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public EOEAEBGJOFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PKPCNIFFMBL<T> : GFNHNMPGGKJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF560", Offset = "0x3EFE360", VA = "0x183EFF560", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFE90", Offset = "0x3EDEC90", VA = "0x183EDFE90", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF4F0", Offset = "0x3EFE2F0", VA = "0x183EFF4F0", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFF60", Offset = "0x3EDED60", VA = "0x183EDFF60", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public PKPCNIFFMBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class PELMGNDJOHB<T> : GFNHNMPGGKJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFEF0", Offset = "0x3EDECF0", VA = "0x183EDFEF0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFE90", Offset = "0x3EDEC90", VA = "0x183EDFE90", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFE20", Offset = "0x3EDEC20", VA = "0x183EDFE20", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFF60", Offset = "0x3EDED60", VA = "0x183EDFF60", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public PELMGNDJOHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class GHOHFOFENMI<T> : GFNHNMPGGKJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x35CCDD0", Offset = "0x35CBBD0", VA = "0x1835CCDD0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x35CCD70", Offset = "0x35CBB70", VA = "0x1835CCD70", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x35CCD00", Offset = "0x35CBB00", VA = "0x1835CCD00", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x35CCE40", Offset = "0x35CBC40", VA = "0x1835CCE40", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public GHOHFOFENMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MPDKCOJOKNJ<T> : GFNHNMPGGKJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC89C0", Offset = "0x3CC77C0", VA = "0x183CC89C0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x35CCD70", Offset = "0x35CBB70", VA = "0x1835CCD70", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8950", Offset = "0x3CC7750", VA = "0x183CC8950", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x35CCE40", Offset = "0x35CBC40", VA = "0x1835CCE40", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public MPDKCOJOKNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HCJJMIDEANG<T> : GFNHNMPGGKJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x362C1D0", Offset = "0x362AFD0", VA = "0x18362C1D0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x362C170", Offset = "0x362AF70", VA = "0x18362C170", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x362C100", Offset = "0x362AF00", VA = "0x18362C100", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x362C240", Offset = "0x362B040", VA = "0x18362C240", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public HCJJMIDEANG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NBCGKEIGHEO<T> : GFNHNMPGGKJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x362C1D0", Offset = "0x362AFD0", VA = "0x18362C1D0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x362C170", Offset = "0x362AF70", VA = "0x18362C170", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFA50", Offset = "0x3CFE850", VA = "0x183CFFA50", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x362C240", Offset = "0x362B040", VA = "0x18362C240", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public NBCGKEIGHEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KFEGPLALDAH<T> : GFNHNMPGGKJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A35860", Offset = "0x3A34660", VA = "0x183A35860", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3A35800", Offset = "0x3A34600", VA = "0x183A35800", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A35790", Offset = "0x3A34590", VA = "0x183A35790", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x30FF0D0", Offset = "0x30FDED0", VA = "0x1830FF0D0", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public KFEGPLALDAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NKCGDIKGOOG<T> : GFNHNMPGGKJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FE30", Offset = "0x3D1EC30", VA = "0x183D1FE30", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FDD0", Offset = "0x3D1EBD0", VA = "0x183D1FDD0", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FD60", Offset = "0x3D1EB60", VA = "0x183D1FD60", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x35CCE40", Offset = "0x35CBC40", VA = "0x1835CCE40", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public NKCGDIKGOOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class NNKNGFOBFCL<T> : GFNHNMPGGKJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E8B0", Offset = "0x3D2D6B0", VA = "0x183D2E8B0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E850", Offset = "0x3D2D650", VA = "0x183D2E850", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E7E0", Offset = "0x3D2D5E0", VA = "0x183D2E7E0", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x362C240", Offset = "0x362B040", VA = "0x18362C240", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x30FF130", Offset = "0x30FDF30", VA = "0x1830FF130")]
		public NNKNGFOBFCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class OEBAFMNHGGN<T> : JMIJLFACHMO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEDD0", Offset = "0x3DDDBD0", VA = "0x183DDEDD0", Slot = "12")]
		protected override void OJFIOOEELAK(FNAHOPJDFFA KHMJGMFIADM, char HICAGFPLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEDA0", Offset = "0x3DDDBA0", VA = "0x183DDEDA0", Slot = "11")]
		protected override void DDADNJBDBCD(GCJAGDGDKPI OLDPDBPDEBC, [Out] char HICAGFPLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x35DDEA0", Offset = "0x35DCCA0", VA = "0x1835DDEA0")]
		public OEBAFMNHGGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class JKELPGNGPHJ<T> : JMIJLFACHMO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39B89F0", Offset = "0x39B77F0", VA = "0x1839B89F0", Slot = "12")]
		protected override void OJFIOOEELAK(FNAHOPJDFFA KHMJGMFIADM, IPEndPoint HICAGFPLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39B89B0", Offset = "0x39B77B0", VA = "0x1839B89B0", Slot = "11")]
		protected override void DDADNJBDBCD(GCJAGDGDKPI OLDPDBPDEBC, [Out] IPEndPoint HICAGFPLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x35DDEA0", Offset = "0x35DCCA0", VA = "0x1835DDEA0")]
		public JKELPGNGPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class FJECJIHPGIE<T> : GFNHNMPGGKJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int KAOCOJCLFPP;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3455EB0", Offset = "0x3454CB0", VA = "0x183455EB0")]
		public FJECJIHPGIE(int EHMLDAMGILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3455DD0", Offset = "0x3454BD0", VA = "0x183455DD0", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3455D60", Offset = "0x3454B60", VA = "0x183455D60", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3455CF0", Offset = "0x3454AF0", VA = "0x183455CF0", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3455E40", Offset = "0x3454C40", VA = "0x183455E40", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class KHPDAEPAGII<T> : IILOBHJMOLF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo DGMNHBLODHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type KDBFAPJMECO;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A6B0", Offset = "0x3A394B0", VA = "0x183A3A6B0")]
		public KHPDAEPAGII(PropertyInfo NEBGFGPEMHL, Type MJELFNJNADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A590", Offset = "0x3A39390", VA = "0x183A3A590", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A480", Offset = "0x3A39280", VA = "0x183A3A480", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A3C0", Offset = "0x3A391C0", VA = "0x183A3A3C0", Slot = "7")]
		public override void AGDNKPOPEKD(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A650", Offset = "0x3A39450", VA = "0x183A3A650", Slot = "8")]
		public override void NHILOPALGGK(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A530", Offset = "0x3A39330", VA = "0x183A3A530", Slot = "9")]
		public override void JINHADDMGLL(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A420", Offset = "0x3A39220", VA = "0x183A3A420", Slot = "10")]
		public override void DBNOBJNEDPA(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class MGFEOMNEAHF<T> : KHPDAEPAGII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x30D9270", Offset = "0x30D8070", VA = "0x1830D9270")]
		public MGFEOMNEAHF(PropertyInfo NEBGFGPEMHL, Type MJELFNJNADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4B60", Offset = "0x3CA3960", VA = "0x183CA4B60", Slot = "5")]
		public override void KIKHHJIJDCP(T LODLPCOBLHE, GCJAGDGDKPI OLDPDBPDEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4AB0", Offset = "0x3CA38B0", VA = "0x183CA4AB0", Slot = "6")]
		public override void FDCGHODCMHC(T LODLPCOBLHE, FNAHOPJDFFA KHMJGMFIADM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class IHHGFCDHIBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static IHHGFCDHIBF<T> ANGIAPALHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly IILOBHJMOLF<T>[] ICIPMEDDCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int OLGLFKLNDPL;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3755AA0", Offset = "0x37548A0", VA = "0x183755AA0")]
		public IHHGFCDHIBF(List<IILOBHJMOLF<T>> PLPIDMPBDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3755940", Offset = "0x3754740", VA = "0x183755940")]
		public void FDCGHODCMHC(T KANAGAAAGHJ, FNAHOPJDFFA NEGHIHACAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x37559F0", Offset = "0x37547F0", VA = "0x1837559F0")]
		public void KIKHHJIJDCP(T KANAGAAAGHJ, GCJAGDGDKPI EIFCDBMOGEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class ILEIFOFLHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract IILOBHJMOLF<T> HFNEOIKDHBA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private FNAHOPJDFFA PPMIOOLKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int BCNHHMCJDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, ILEIFOFLHHB> OGOBJIMHJNA;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5316E00", Offset = "0x5315C00", VA = "0x185316E00")]
	public CCHPFCLNCGP(int HNNEOOJCAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2311490", Offset = "0x2310290", VA = "0x182311490")]
	private IHHGFCDHIBF<T> PHHEAFLCELB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22A0EB0", Offset = "0x229FCB0", VA = "0x1822A0EB0")]
	public void EEHFKNGNNHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x23113B0", Offset = "0x23101B0", VA = "0x1823113B0")]
	public bool LKNPCKIALBL<T>(GCJAGDGDKPI EIFCDBMOGEN, T PODCKBKAANA) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2311430", Offset = "0x2310230", VA = "0x182311430")]
	public void OJBJHHLKILJ<T>(FNAHOPJDFFA NEGHIHACAHG, T KANAGAAAGHJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DBKGEEBKAJK
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime MECNKDPIJLG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] NGEBBFABDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public HLOKKLEMOHC OGLBMFOLJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x53181D0", Offset = "0x5316FD0", VA = "0x1853181D0")]
		get
		{
			return default(HLOKKLEMOHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int JCAPJALFFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5317F80", Offset = "0x5316D80", VA = "0x185317F80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5317F40", Offset = "0x5316D40", VA = "0x185317F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MPEEDLJCAID EBIEGFGAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5317B90", Offset = "0x5316990", VA = "0x185317B90")]
		get
		{
			return default(MPEEDLJCAID);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x53174F0", Offset = "0x53162F0", VA = "0x1853174F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KMJFGFDNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5317E80", Offset = "0x5316C80", VA = "0x185317E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint ILBKMEHOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x53172A0", Offset = "0x53160A0", VA = "0x1853172A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? PKLLJAIIGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5317730", Offset = "0x5316530", VA = "0x185317730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? DBNFAGANGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x53181A0", Offset = "0x5316FA0", VA = "0x1853181A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? NEKEJNBNAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5317B60", Offset = "0x5316960", VA = "0x185317B60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5317760", Offset = "0x5316560", VA = "0x185317760")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? ECABGANICGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x806370", Offset = "0x805170", VA = "0x180806370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5318310", Offset = "0x5317110", VA = "0x185318310")]
	public DBKGEEBKAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5318260", Offset = "0x5317060", VA = "0x185318260")]
	internal DBKGEEBKAJK(byte[] EHLPPEEOBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5318080", Offset = "0x5316E80", VA = "0x185318080")]
	public static DBKGEEBKAJK NFHFMIMBEPO(byte[] EHLPPEEOBND, DateTime HIIDJJELAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5317530", Offset = "0x5316330", VA = "0x185317530")]
	internal void BKJGJGFPEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5317320", Offset = "0x5316120", VA = "0x185317320")]
	private void BEKLGJEPCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5317C80", Offset = "0x5316A80", VA = "0x185317C80")]
	private DateTime? IIBPKJPPJNE(int PLIILJHILHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5317990", Offset = "0x5316790", VA = "0x185317990")]
	private void DCCOCJKPGBI(int PLIILJHILHI, DateTime? PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5317FB0", Offset = "0x5316DB0", VA = "0x185317FB0")]
	private ulong NFHEAFHMEEJ(int PLIILJHILHI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5317BC0", Offset = "0x53169C0", VA = "0x185317BC0")]
	private void GMCOOBIAHPI(int PLIILJHILHI, ulong PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5317EB0", Offset = "0x5316CB0", VA = "0x185317EB0")]
	private uint KMGKNAMKOKC(int PLIILJHILHI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x52048B0", Offset = "0x52036B0", VA = "0x1852048B0")]
	private static uint CDCMLFGEONG(uint GPMOHKANAAB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5317930", Offset = "0x5316730", VA = "0x185317930")]
	private static ulong CDCMLFGEONG(ulong GPMOHKANAAB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum HLOKKLEMOHC
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
public enum MPEEDLJCAID
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class FFHEGJPOGAA
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int PCOBMBOAHEF = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int LBKIMGBEEDC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int GGONALDKEAL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint NAENMOAPNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int EOGKHKFMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int OFHAGKDOHKD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PPNKPIHIKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5319290", Offset = "0x5318090", VA = "0x185319290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x53192A0", Offset = "0x53180A0", VA = "0x1853192A0")]
	public bool DBJDOEAFMEN(Socket ABGOLONJNJG, int MMMBHMDFODK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GFCOICCGHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int JOHAIBHDGCP;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x77AE60", Offset = "0x779C60", VA = "0x18077AE60")]
	protected GFCOICCGHBC(int NEICCIKHJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OBAOBLLHPGF(IPEndPoint HGPCKOKGCHD, byte[] KNAIEKIJLBC, int PLIILJHILHI, int ELGJIDFGJJH);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JIDGHJLDKAF(IPEndPoint HGPCKOKGCHD, byte[] KNAIEKIJLBC, int PLIILJHILHI, int ELGJIDFGJJH);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IFDFLNGMLJH : GFCOICCGHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider HOADDFIFCEF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator BNOADAIDHJA;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5325010", Offset = "0x5323E10", VA = "0x185325010")]
	public IFDFLNGMLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x53244A0", Offset = "0x53232A0", VA = "0x1853244A0")]
	public void DHDMEHLFGKB(IPEndPoint HGPCKOKGCHD, byte[] GAMCILOFBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x53246E0", Offset = "0x53234E0", VA = "0x1853246E0")]
	public void FJJOLAHGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53247C0", Offset = "0x53235C0", VA = "0x1853247C0")]
	private byte[] GDJOHNLEADE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5324BF0", Offset = "0x53239F0", VA = "0x185324BF0", Slot = "4")]
	public override void OBAOBLLHPGF(IPEndPoint HGPCKOKGCHD, byte[] KNAIEKIJLBC, int PLIILJHILHI, int ELGJIDFGJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5324850", Offset = "0x5323650", VA = "0x185324850", Slot = "5")]
	public override void JIDGHJLDKAF(IPEndPoint HGPCKOKGCHD, byte[] KNAIEKIJLBC, int PLIILJHILHI, int ELGJIDFGJJH)
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
