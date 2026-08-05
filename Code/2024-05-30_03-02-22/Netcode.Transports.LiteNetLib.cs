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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, AFKCNIAGNPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum CMLEBJPJMLF
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
		private NetworkManager NDKDMDDOBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, PMJLINAOGAP> IKLMANBHIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MOJDEKGGLPB KKCPFBODEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] EPNIGAFFOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CMLEBJPJMLF FGPMDEEKGMN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ADFJEHDHBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LGHIJFJJJDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x585F420", Offset = "0x585E620", VA = "0x18585F420", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x585E920", Offset = "0x585DB20", VA = "0x18585E920")]
		public void RecRoom_SetEncryptionInfo(ulong PBONOBOOPJM, byte[] MNOIAMGNLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x585E900", Offset = "0x585DB00", VA = "0x18585E900")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x585E700", Offset = "0x585D900", VA = "0x18585E700")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x585F320", Offset = "0x585E520", VA = "0x18585F320")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x585EB20", Offset = "0x585DD20", VA = "0x18585EB20", Slot = "6")]
		public override void Send(ulong NBANNMCADJI, ArraySegment<byte> JLJKEBMIIPF, NetworkDelivery BMEKDEFDKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x585E8C0", Offset = "0x585DAC0", VA = "0x18585E8C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong NBANNMCADJI, [Out] ArraySegment<byte> EIAKFCMMIEA, [Out] float IGOENCMJOPA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x585EE10", Offset = "0x585E010", VA = "0x18585EE10", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x585F240", Offset = "0x585E440", VA = "0x18585F240", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x585DFA0", Offset = "0x585D1A0", VA = "0x18585DFA0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong NBANNMCADJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x585DE50", Offset = "0x585D050", VA = "0x18585DE50", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x585E250", Offset = "0x585D450", VA = "0x18585E250", Slot = "12")]
		public override ulong GetCurrentRtt(ulong NBANNMCADJI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x585EDA0", Offset = "0x585DFA0", VA = "0x18585EDA0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x585E2F0", Offset = "0x585D4F0", VA = "0x18585E2F0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager NDKDMDDOBON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x585E7F0", Offset = "0x585D9F0", VA = "0x18585E7F0")]
		private IPEEAIEOMNN PHKKOKEGDPG(NetworkDelivery HHJOOHJDNNM)
		{
			return default(IPEEAIEOMNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x585E640", Offset = "0x585D840", VA = "0x18585E640", Slot = "15")]
		private void NLHPBIBIEBH(PMJLINAOGAP GIHJEDKNBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x585E110", Offset = "0x585D310", VA = "0x18585E110", Slot = "16")]
		private void EDOAODCDPOL(PMJLINAOGAP GIHJEDKNBCL, BLIKNJCPKMH LHEDICJHJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "17")]
		private void OIGPJNMFAPC(IPEndPoint FOKMNNFMLKF, SocketError DDIFLNMBPHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x585DC40", Offset = "0x585CE40", VA = "0x18585DC40", Slot = "18")]
		private void AKJCEDCCJPP(PMJLINAOGAP GIHJEDKNBCL, ODHKEBPNFAM LAAOMLILGHH, byte GMBNAMKIDOB, IPEEAIEOMNN PPAGKBBDJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x585E4E0", Offset = "0x585D6E0", VA = "0x18585E4E0")]
		private void MJMPKKGEPFF(int AGHIAPEPFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "19")]
		private void EPNLEJDALKL(IPEndPoint MPFJJIBOHHB, ODHKEBPNFAM LAAOMLILGHH, OFFOAEOGBJK BPBNEGCHNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "20")]
		private void MNHNHGADLJP(PMJLINAOGAP GIHJEDKNBCL, int GFOGKFCDAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x585E5E0", Offset = "0x585D7E0", VA = "0x18585E5E0", Slot = "21")]
		private void NDCAHBGBBPD(LPACMGBLCKC DAFMLJPHFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x585E4B0", Offset = "0x585D6B0", VA = "0x18585E4B0")]
		private ulong KGHJLFHKJHC(PMJLINAOGAP GIHJEDKNBCL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x585E5C0", Offset = "0x585D7C0", VA = "0x18585E5C0")]
		private static int NCALPAGOCLC(float CNDFBLFAGOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x585F340", Offset = "0x585E540", VA = "0x18585F340")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class KPHOEKKIACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PMJLINAOGAP DHLJBNFEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<PEFBOOHKJGB> BDDJHCGPGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int CJCPEIIBNLH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x585D570", Offset = "0x585C770", VA = "0x18585D570")]
	protected KPHOEKKIACJ(PMJLINAOGAP GIHJEDKNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x585D510", Offset = "0x585C710", VA = "0x18585D510")]
	public void KPJFPINLGED(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x585D490", Offset = "0x585C690", VA = "0x18585D490")]
	protected void IOEDKDLADPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x585D450", Offset = "0x585C650", VA = "0x18585D450")]
	public bool AJPGEHAOEIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool JNLELHIMOCK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MBMJKNBBPOI(PEFBOOHKJGB OEDGBABNEEC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum ACKLOFMNJNF
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
public class LPACMGBLCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MOJDEKGGLPB PKOOFKPPCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int IHOEPCLOIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LABMFDKNPJB DLEKKHAMLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint ONFGPGPEEMI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal ACKLOFMNJNF HLEOGFEMLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D10", Offset = "0x7EFF10", VA = "0x1807F0D10")]
		[CompilerGenerated]
		get
		{
			return default(ACKLOFMNJNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA18EF0", Offset = "0xA180F0", VA = "0x180A18EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x585DB70", Offset = "0x585CD70", VA = "0x18585DB70")]
	internal void NPIIPFKHDHA(LABMFDKNPJB FGPHPCCKFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x585DB40", Offset = "0x585CD40", VA = "0x18585DB40")]
	private bool BLPGABJHDFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x585DBD0", Offset = "0x585CDD0", VA = "0x18585DBD0")]
	internal LPACMGBLCKC(IPEndPoint MPFJJIBOHHB, LABMFDKNPJB ANCFEDEJLLK, MOJDEKGGLPB EBKJNJIBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x585DAE0", Offset = "0x585CCE0", VA = "0x18585DAE0")]
	public PMJLINAOGAP BFKLGGLMBEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OFFOAEOGBJK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JEFDKPLDBJF
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
public struct BLIKNJCPKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JEFDKPLDBJF CAEFBHPAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError NIENCBAALKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public ODHKEBPNFAM CDOENDKPFKI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AFKCNIAGNPE
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHEIHMADDDN(PMJLINAOGAP GIHJEDKNBCL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHJONEMHENB(PMJLINAOGAP GIHJEDKNBCL, BLIKNJCPKMH LHEDICJHJKO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIGIOKBMMLB(IPEndPoint FOKMNNFMLKF, SocketError DDIFLNMBPHC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKKABGHDPJP(PMJLINAOGAP GIHJEDKNBCL, ODHKEBPNFAM LAAOMLILGHH, byte GMBNAMKIDOB, IPEEAIEOMNN PPAGKBBDJCD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAAKLJJOEFE(IPEndPoint MPFJJIBOHHB, ODHKEBPNFAM LAAOMLILGHH, OFFOAEOGBJK BPBNEGCHNHG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNADBGGEPFJ(PMJLINAOGAP GIHJEDKNBCL, int GFOGKFCDAEB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPFPPNOJBKM(LPACMGBLCKC DAFMLJPHFGN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLHFGCOLJEG
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKLELGAMCLK(PMJLINAOGAP GIHJEDKNBCL, object EDJJHIAHIIN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MLHJCEJGDAB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDGJMEOAPCP(JIEKBKFMHHM OEDGBABNEEC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OFEMPJGNDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPHADKGHIIK(PMJLINAOGAP GIHJEDKNBCL, IPEndPoint IFKGHJGNJAF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LABMFDKNPJB
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int LFCFAJDMAEI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long IOGJDMHOFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte NLHLGNFFDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] EFGDAOBCCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly JKIKOOAKOPB GICDCDBMPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int HLCHGADIJKG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x585DA70", Offset = "0x585CC70", VA = "0x18585DA70")]
	private LABMFDKNPJB(long NKNNFJEBPDK, byte ECKJALNOGOH, int LMABLLHEJEF, byte[] ABDJCBIFDFN, JKIKOOAKOPB JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x585D7F0", Offset = "0x585C9F0", VA = "0x18585D7F0")]
	public static int KCKHCLOODPF(PEFBOOHKJGB OEDGBABNEEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x585D850", Offset = "0x585CA50", VA = "0x18585D850")]
	public static LABMFDKNPJB LNHAMLBHEEL(PEFBOOHKJGB OEDGBABNEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x585D610", Offset = "0x585C810", VA = "0x18585D610")]
	public static PEFBOOHKJGB FHFKDPKJPPM(JNPMGEAGNCH NHNNPBEMHGE, SocketAddress CBCODAJAHAE, long AFJLFGKNKHB, int LMABLLHEJEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MJNPHABLLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long IOGJDMHOFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte NLHLGNFFDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int HLCHGADIJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool LLJKGLIIMBD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x585FC60", Offset = "0x585EE60", VA = "0x18585FC60")]
	private MJNPHABLLEM(long NKNNFJEBPDK, byte ECKJALNOGOH, int MMIMKMMMEPE, bool KNGLFNAGAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x585FB10", Offset = "0x585ED10", VA = "0x18585FB10")]
	public static MJNPHABLLEM LNHAMLBHEEL(PEFBOOHKJGB OEDGBABNEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x585F920", Offset = "0x585EB20", VA = "0x18585F920")]
	public static PEFBOOHKJGB FHFKDPKJPPM(long AFJLFGKNKHB, byte KLIBIAGFBMG, int MFPENHANCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x585FA10", Offset = "0x585EC10", VA = "0x18585FA10")]
	public static PEFBOOHKJGB LFCHNGFPPGA(PMJLINAOGAP GIHJEDKNBCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum EGKOKHMLLFP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HDNJBAHECGI
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJFKHPFDLGO(IPEndPoint NNFHBDFJOEP, IPEndPoint MPFJJIBOHHB, string CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLGLLCKNLNF(IPEndPoint AFPAOJDBNCM, EGKOKHMLLFP HHJOOHJDNNM, string CEFPPEHCFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BHGOBAFEHAL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BLCNKKPJNCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint GHANPKKPPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint ONFGPGPEEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string OAHBNCBFAHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FLPLBPDPMOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JPINACHNGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EGKOKHMLLFP GADMEDLKBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string OAHBNCBFAHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class EGPDDDMABLI
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint NKEMMPPOLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string OAHBNCBFAHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EGPDDDMABLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class NBCLJMMIFDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NKEMMPPOLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint JOIGGIMKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string OAHBNCBFAHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public NBCLJMMIFDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HOEDGADICDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OAHBNCBFAHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CNFLIBLJECF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7CC960", Offset = "0x7CBB60", VA = "0x1807CC960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HOEDGADICDM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MOJDEKGGLPB NGBHCJHBICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<BLCNKKPJNCF> MHOCNLJINAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<FLPLBPDPMOC> JFKHBJCHPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JKIKOOAKOPB DGKIDMKLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JNPMGEAGNCH EBNBHOMMNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MAIGJAEKJON HOIKALHGOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private HDNJBAHECGI ABNEMDDAGBG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int MLFFEDDNJJL = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool PKCOCLNGILN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x58577F0", Offset = "0x58569F0", VA = "0x1858577F0")]
	internal BHGOBAFEHAL(MOJDEKGGLPB FCBCDAJNPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5857220", Offset = "0x5856420", VA = "0x185857220")]
	internal void AEHEAGODFKN(IPEndPoint BLPKDCMMMBJ, PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2775500", Offset = "0x2774700", VA = "0x182775500")]
	private void KMNJICOONBA<T>(T OEDGBABNEEC, IPEndPoint FMEDEJNEJHJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5857670", Offset = "0x5856870", VA = "0x185857670")]
	private void OJFKHPFDLGO(EGPDDDMABLI EAHONOBCHPM, IPEndPoint BLPKDCMMMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5857510", Offset = "0x5856710", VA = "0x185857510")]
	private void MFCONEOBEFN(NBCLJMMIFDG EAHONOBCHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5857380", Offset = "0x5856580", VA = "0x185857380")]
	private void HNKMBFDGAPF(HOEDGADICDM EAHONOBCHPM, IPEndPoint BLPKDCMMMBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IPEEAIEOMNN : byte
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
public enum IFNGJJOOCMH : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EKFLNCOILAF
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] MNOCOIIKBHI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int LIINKECGEBB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int PJMPOIFOEEN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CNGGPLGJBIH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5857CE0", Offset = "0x5856EE0", VA = "0x185857CE0")]
	public CNGGPLGJBIH(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IGIKCIICCFA : CNGGPLGJBIH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5857CE0", Offset = "0x5856EE0", VA = "0x185857CE0")]
	public IGIKCIICCFA(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NEJDIEBAMBN
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
public interface KHKIGLEMGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJNPAEILLGF(NEJDIEBAMBN JMMNCBCPEMF, string DIDBPNGGKDB, params object[] NEAMBEFDODM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MOANFGIJMJG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static KHKIGLEMGPP FMCEINGDOJH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PEGEGGAOMGE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x585FCB0", Offset = "0x585EEB0", VA = "0x18585FCB0")]
	private static void CJDBMHPCJFP(NEJDIEBAMBN HPNAHFIJMLD, string DIDBPNGGKDB, params object[] NEAMBEFDODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x585FF40", Offset = "0x585F140", VA = "0x18585FF40")]
	internal static void HOFNJMIEBCM(string DIDBPNGGKDB, params object[] NEAMBEFDODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x585FFA0", Offset = "0x585F1A0", VA = "0x18585FFA0")]
	internal static void LMGKOHKBJCC(string DIDBPNGGKDB, params object[] NEAMBEFDODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x585FEE0", Offset = "0x585F0E0", VA = "0x18585FEE0")]
	internal static void GLILFEIIFFA(string DIDBPNGGKDB, params object[] NEAMBEFDODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FGCPKOKHDOJ
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ODHKEBPNFAM : JKIKOOAKOPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PEFBOOHKJGB FIBANMJCHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MOJDEKGGLPB OOCBMCPDOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JMPINDOFMIE MCPPBAJNFBI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5867F80", Offset = "0x5867180", VA = "0x185867F80")]
	internal ODHKEBPNFAM(MOJDEKGGLPB LJOFMHFOMJI, JMPINDOFMIE KJHKIAEMFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5867EE0", Offset = "0x58670E0", VA = "0x185867EE0")]
	internal void KIAELKLGKLH(PEFBOOHKJGB OEDGBABNEEC, int OGFAPAKDJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5867E60", Offset = "0x5867060", VA = "0x185867E60")]
	internal void GOLLLLDLCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5867F50", Offset = "0x5867150", VA = "0x185867F50")]
	public void LHLKMIAGCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JMPINDOFMIE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum KGICLBBKNNM
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
	public JMPINDOFMIE DNHMKPKJANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public KGICLBBKNNM GADMEDLKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public PMJLINAOGAP DHLJBNFEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint ONFGPGPEEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object DAKJEKLCIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int ODCAPKEAPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError DPIOMGOKFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public JEFDKPLDBJF MNKPIEAJGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public LPACMGBLCKC LLKIFNOBBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public IPEEAIEOMNN LOCEJCFNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PFAIACAJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly ODHKEBPNFAM MJIGHODEMDB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x585C4C0", Offset = "0x585B6C0", VA = "0x18585C4C0")]
	public JMPINDOFMIE(MOJDEKGGLPB LJOFMHFOMJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MOJDEKGGLPB : IEnumerable<PMJLINAOGAP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class BCCHOBDICKO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x58571B0", Offset = "0x58563B0", VA = "0x1858571B0", Slot = "4")]
		public bool Equals(IPEndPoint DCHJALFCEJF, IPEndPoint JFJIMNMJLJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x53518D0", Offset = "0x5350AD0", VA = "0x1853518D0", Slot = "5")]
		public int GetHashCode(IPEndPoint CDJAKLIPEBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public BCCHOBDICKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct BJLIIDJDFPJ : IEnumerator<PMJLINAOGAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly PMJLINAOGAP MNBANBDNHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PMJLINAOGAP DDDENNGBNLE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PMJLINAOGAP NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1013810", Offset = "0x1012A10", VA = "0x181013810")]
		public BJLIIDJDFPJ(PMJLINAOGAP DBMDKHEIDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5857C40", Offset = "0x5856E40", VA = "0x185857C40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5857C90", Offset = "0x5856E90", VA = "0x185857C90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread IPOOEJLILPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool ECMHCACANKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent IPOMFALDIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JMPINDOFMIE> MICGELOKDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JMPINDOFMIE> GAKKHKACGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JMPINDOFMIE CBNHCJIDIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AFKCNIAGNPE NBPLLKCMHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PLHFGCOLJEG GONIKOJBHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MLHJCEJGDAB ALJPBKJIHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OFEMPJGNDMD BBHHEKKGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, PMJLINAOGAP> AAAKJJEILAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, LPACMGBLCKC> NAAEDGCFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, AHCHHMBFLLN> LMNLCOMAEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim EOAHBGJFJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private PMJLINAOGAP EJKGMBPCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int NAGHDMNGEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PMJLINAOGAP> MAMAJILKMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PMJLINAOGAP[] PLHNJJPENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MPOLPKKFCNE JLMLJCABHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int OHLAAPACOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> CLBPCHHPIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte EIHOHIOLOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object GPDAJAMGEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool FFNEAKFDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool JFHLNKCHBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int PGKMLJGNIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int OJDEPILDONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CNFLPKILMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ACGJKLKCFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool FLIGJJDKDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool APFIDNKBOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int FBPABJBALEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int KGDMFBMOMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int LNFDGNCPCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool PKCOCLNGILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool PFFOOJIGEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool DJHNKEBAHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HNFFIKFNGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EMNAHAIBFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int AKGJNOJCFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool NFOIDFFJBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly AHMPFGFADEF MLBHEINEJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool PFLDHJJPDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly BHGOBAFEHAL JPNMMCAENBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GDAEMGDLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public FGCPKOKHDOJ OIFAINOHOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int KKIDINJMCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KAPLHDEGOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool OLMPLKDMOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool DKHKOBPJKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FDKIECMOHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PEFBOOHKJGB MLAIPFCHBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int OBMEAHIAIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object ENJHONDPDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PEFBOOHKJGB EDBPCFNGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int CMJEBHMMLBL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int DOHBEJEIAOO = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int EKAEGKJHHIA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GGLJHHEOHIK DMIFMBGOIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private GGLJHHEOHIK ONNJHNEOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DJIBOEBKLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread MKMNJKKBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CIAOECFIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint JDJFLMOHJNO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] FGIPKPFACLA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] DIEJHBHDJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<ACPNIOLOBGJ, IPEndPoint> LGFDNMGDAFG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress EOMICCJNHPC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool BEJCFOFMOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int DPDLMHOKOBG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HAAEPIPLPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB1DC30", Offset = "0xB1CE30", VA = "0x180B1DC30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xBCD530", Offset = "0xBCC730", VA = "0x180BCD530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NKONEKMCHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1406330", Offset = "0x1405530", VA = "0x181406330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x172E220", Offset = "0x172D420", VA = "0x18172E220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte DMFHLCFGMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9658F0", Offset = "0x964AF0", VA = "0x1809658F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CILMBPNJALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x58604B0", Offset = "0x585F6B0", VA = "0x1858604B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short BCOMNBMLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x58635C0", Offset = "0x58627C0", VA = "0x1858635C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x58623B0", Offset = "0x58615B0", VA = "0x1858623B0")]
	public void GAEFOOJJGFB(IPEndPoint FOKMNNFMLKF, byte[] MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58639D0", Offset = "0x5862BD0", VA = "0x1858639D0")]
	public void JNEECFODAPH(IPEndPoint FOKMNNFMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5860420", Offset = "0x585F620", VA = "0x185860420")]
	private bool BJMMNBJNBFN(IPEndPoint FOKMNNFMLKF, [Out] PMJLINAOGAP GIHJEDKNBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5864510", Offset = "0x5863710", VA = "0x185864510")]
	private void KLGLHOIFCMD(PMJLINAOGAP GIHJEDKNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x58667B0", Offset = "0x58659B0", VA = "0x1858667B0")]
	private void PLCGNIBCCJJ(PMJLINAOGAP GIHJEDKNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5864E40", Offset = "0x5864040", VA = "0x185864E40")]
	private void MNPJDMKMIMM(PMJLINAOGAP GIHJEDKNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5866A30", Offset = "0x5865C30", VA = "0x185866A30")]
	public MOJDEKGGLPB(AFKCNIAGNPE EBKJNJIBOOD, [Optional] MPOLPKKFCNE HDABLKMJIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5866800", Offset = "0x5865A00", VA = "0x185866800")]
	internal void PPHFMBIFIJF(PMJLINAOGAP NCHCJDGBLJL, int GFOGKFCDAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x58603D0", Offset = "0x585F5D0", VA = "0x1858603D0")]
	internal void AHPHACKEHNK(PMJLINAOGAP NCHCJDGBLJL, object EDJJHIAHIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x58604D0", Offset = "0x585F6D0", VA = "0x1858604D0")]
	internal void CPDNOJNBDOE(PMJLINAOGAP GIHJEDKNBCL, JEFDKPLDBJF NCKBEFBPNFM, SocketError DDKOPCLLADH, PEFBOOHKJGB IECLDFDHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5863D70", Offset = "0x5862F70", VA = "0x185863D70")]
	private void KAPHNLCPEME(PMJLINAOGAP GIHJEDKNBCL, JEFDKPLDBJF NCKBEFBPNFM, SocketError DDKOPCLLADH, bool LBPGAAMAJKE, byte[] JLJKEBMIIPF, int IFNAKMJKBID, int BIFLOKBJAPK, PEFBOOHKJGB IECLDFDHFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x58650A0", Offset = "0x58642A0", VA = "0x1858650A0")]
	private void NAJLBCNAENF(JMPINDOFMIE.KGICLBBKNNM HHJOOHJDNNM, [Optional] PMJLINAOGAP GIHJEDKNBCL, [Optional] IPEndPoint MPFJJIBOHHB, SocketError OKBICCAPMDI = SocketError.Success, int GFOGKFCDAEB = 0, JEFDKPLDBJF HEGIMDICILK = JEFDKPLDBJF.ConnectionFailed, [Optional] LPACMGBLCKC ALPHNAGGMMJ, IPEEAIEOMNN PPAGKBBDJCD = IPEEAIEOMNN.Unreliable, byte GMBNAMKIDOB = 0, [Optional] PEFBOOHKJGB LEGBBGHLHEC, [Optional] object EDJJHIAHIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5866000", Offset = "0x5865200", VA = "0x185866000")]
	private void PHFBPHKKHIB(JMPINDOFMIE KJHKIAEMFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x58624B0", Offset = "0x58616B0", VA = "0x1858624B0")]
	internal void GOLGHAKELML(JMPINDOFMIE KJHKIAEMFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5862E20", Offset = "0x5862020", VA = "0x185862E20")]
	private void HHNGHIHLBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x58600B0", Offset = "0x585F2B0", VA = "0x1858600B0")]
	private void AGFBNCFKAEE(int PCNMIDNAIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5860860", Offset = "0x585FA60", VA = "0x185860860")]
	internal PMJLINAOGAP DHOHFNBGPFB(LPACMGBLCKC DAFMLJPHFGN, byte[] JIHFIODCHIB, int IFNAKMJKBID, int MKCBFIBLIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5862330", Offset = "0x5861530", VA = "0x185862330")]
	private int FJEANPOJMIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5863160", Offset = "0x5862360", VA = "0x185863160")]
	private void HOGOPPFPMHI(IPEndPoint MPFJJIBOHHB, PMJLINAOGAP NIDFHFDHFMJ, LABMFDKNPJB BBGOLDBGNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5861280", Offset = "0x5860480", VA = "0x185861280")]
	private void EDKDMFDDJNP(PEFBOOHKJGB OEDGBABNEEC, IPEndPoint MPFJJIBOHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x58605A0", Offset = "0x585F7A0", VA = "0x1858605A0")]
	internal void DGIJIEPAAGJ(PEFBOOHKJGB OEDGBABNEEC, IPEEAIEOMNN IAFFDCPPJFN, byte GMBNAMKIDOB, int OGFAPAKDJCH, PMJLINAOGAP NCHCJDGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5862E10", Offset = "0x5862010", VA = "0x185862E10")]
	public bool HHGMBCMBJBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5862630", Offset = "0x5861830", VA = "0x185862630")]
	public bool HHGMBCMBJBG(IPAddress JJCNJGCLLLH, IPAddress JFMNNHOIINM, int IFCDCDHKHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58625B0", Offset = "0x58617B0", VA = "0x1858625B0")]
	public bool HHGMBCMBJBG(int IFCDCDHKHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5863B20", Offset = "0x5862D20", VA = "0x185863B20")]
	public void KAABJGEMOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5865540", Offset = "0x5864740", VA = "0x185865540")]
	public PMJLINAOGAP NEKLOJMPNDI(string OGAJAFJJDGG, int IFCDCDHKHNE, string MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5865460", Offset = "0x5864660", VA = "0x185865460")]
	public PMJLINAOGAP NEKLOJMPNDI(string OGAJAFJJDGG, int IFCDCDHKHNE, JNPMGEAGNCH GIHMDNFDGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5865620", Offset = "0x5864820", VA = "0x185865620")]
	public PMJLINAOGAP NEKLOJMPNDI(IPEndPoint FMEDEJNEJHJ, JNPMGEAGNCH GIHMDNFDGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5862320", Offset = "0x5861520", VA = "0x185862320")]
	public void ELDEMCCAJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5861FD0", Offset = "0x58611D0", VA = "0x185861FD0")]
	public void ELDEMCCAJPF(bool MMCELGDNOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5865B90", Offset = "0x5864D90", VA = "0x185865B90")]
	public void NLFPAPJLBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5865C90", Offset = "0x5864E90", VA = "0x185865C90")]
	public void NLFPAPJLBPM(byte[] JLJKEBMIIPF, int IFNAKMJKBID, int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5863CC0", Offset = "0x5862EC0", VA = "0x185863CC0")]
	public void KAPHNLCPEME(PMJLINAOGAP GIHJEDKNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5863E50", Offset = "0x5863050", VA = "0x185863E50")]
	public void KAPHNLCPEME(PMJLINAOGAP GIHJEDKNBCL, byte[] JLJKEBMIIPF, int IFNAKMJKBID, int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5866850", Offset = "0x5865A50", VA = "0x185866850", Slot = "4")]
	private IEnumerator<PMJLINAOGAP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58668E0", Offset = "0x5865AE0", VA = "0x1858668E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5860F60", Offset = "0x5860160", VA = "0x185860F60")]
	private PEFBOOHKJGB DJAMNABPODK(IDJBDPEDFEK EHMJOHOMDOD, int AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5860E80", Offset = "0x5860080", VA = "0x185860E80")]
	private PEFBOOHKJGB DJAMNABPODK(IDJBDPEDFEK EHMJOHOMDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5861050", Offset = "0x5860250", VA = "0x185861050")]
	internal PEFBOOHKJGB ECGPGFOOBNF(int AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5863770", Offset = "0x5862970", VA = "0x185863770")]
	internal void JMCHAMLPIHJ(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5866970", Offset = "0x5865B70", VA = "0x185866970")]
	static MOJDEKGGLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xB1DC30", Offset = "0xB1CE30", VA = "0x180B1DC30")]
	private bool FHMOGPBMCEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5863680", Offset = "0x5862880", VA = "0x185863680")]
	private void JIFEPNJCGAN(IPEndPoint ODKMCDCPFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5865F20", Offset = "0x5865120", VA = "0x185865F20")]
	private void OPCDPCGABBP(IPEndPoint ODKMCDCPFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x58659F0", Offset = "0x5864BF0", VA = "0x1858659F0")]
	private bool NHODMKOMLEI(SocketException ILHGKPBGFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x58647E0", Offset = "0x58639E0", VA = "0x1858647E0")]
	private void LIPIKAJKJBP(GGLJHHEOHIK FCBCDAJNPDB, EndPoint BONOFHILGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5864AB0", Offset = "0x5863CB0", VA = "0x185864AB0")]
	private void MBLBIPMJIND(object JLPFJEBDMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5862650", Offset = "0x5861850", VA = "0x185862650")]
	public bool HHGMBCMBJBG(IPAddress JJCNJGCLLLH, IPAddress JFMNNHOIINM, int IFCDCDHKHNE, bool GGALNBFDLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5862450", Offset = "0x5861650", VA = "0x185862450")]
	internal int GJDOMHAFCAG(PEFBOOHKJGB OEDGBABNEEC, IPEndPoint MPFJJIBOHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x58644D0", Offset = "0x58636D0", VA = "0x1858644D0")]
	internal int KDFHIMBCACA(PEFBOOHKJGB OEDGBABNEEC, IPEndPoint MPFJJIBOHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5863F10", Offset = "0x5863110", VA = "0x185863F10")]
	internal int KDFHIMBCACA(byte[] PPGBBBOBJLN, int IFNAKMJKBID, int MKCBFIBLIDD, IPEndPoint MPFJJIBOHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5865DB0", Offset = "0x5864FB0", VA = "0x185865DB0")]
	internal void NLNNOHGOMGL(bool BCNKANJBGIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IDJBDPEDFEK : byte
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
internal sealed class PEFBOOHKJGB
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int KHOELAMLDGP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] OAMIHNEDPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IGAGEOJMBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BGCPNAGJMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object DAKJEKLCIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public PEFBOOHKJGB DNHMKPKJANF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IDJBDPEDFEK DADKHEMCEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x58681E0", Offset = "0x58673E0", VA = "0x1858681E0")]
		get
		{
			return default(IDJBDPEDFEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x58680A0", Offset = "0x58672A0", VA = "0x1858680A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte NLHLGNFFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5868240", Offset = "0x5867440", VA = "0x185868240")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x58682F0", Offset = "0x58674F0", VA = "0x1858682F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GGMJEBHOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5868010", Offset = "0x5867210", VA = "0x185868010")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5868270", Offset = "0x5867470", VA = "0x185868270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GNOLKOODIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5868070", Offset = "0x5867270", VA = "0x185868070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte JKGCIMHELFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5868210", Offset = "0x5867410", VA = "0x185868210")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58685C0", Offset = "0x58677C0", VA = "0x1858685C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort PLICGOEJJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5868500", Offset = "0x5867700", VA = "0x185868500")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5867FD0", Offset = "0x58671D0", VA = "0x185867FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort NBGKBGFOLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5868330", Offset = "0x5867530", VA = "0x185868330")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x58682B0", Offset = "0x58674B0", VA = "0x1858682B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DPADDAECLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5868560", Offset = "0x5867760", VA = "0x185868560")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5868390", Offset = "0x5867590", VA = "0x185868390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x58685F0", Offset = "0x58677F0", VA = "0x1858685F0")]
	static PEFBOOHKJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x58683D0", Offset = "0x58675D0", VA = "0x1858683D0")]
	public void MBJACAHGMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58688D0", Offset = "0x5867AD0", VA = "0x1858688D0")]
	public PEFBOOHKJGB(int AGHIAPEPFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5868940", Offset = "0x5867B40", VA = "0x185868940")]
	public PEFBOOHKJGB(IDJBDPEDFEK EHMJOHOMDOD, int AGHIAPEPFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5868490", Offset = "0x5867690", VA = "0x185868490")]
	public static int MDHICBDOLGI(IDJBDPEDFEK EHMJOHOMDOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5868400", Offset = "0x5867600", VA = "0x185868400")]
	public int MDHICBDOLGI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x58680E0", Offset = "0x58672E0", VA = "0x1858680E0")]
	public bool CMKPBMNAKOL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OHGANFPCIPI : byte
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
internal enum PKKFIBECIGH
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
internal enum JJBOHDFPHDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OCCFEONNIHG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PMJLINAOGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CDHMMCCJDKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PEFBOOHKJGB[] DACMIIBENEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NPIMJAGEKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int JFIDLFKLBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte JKGCIMHELFI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public CDHMMCCJDKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void CBKBIDGDALO(ulong NEOKNNOAHOJ, int HPKDKADOICB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int GMLDFMOHMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int EFFBALGOCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int NKGOLFPCKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double BMLDFJAFHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int AAPMDNLBMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int FLCLMGEHFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OGMJBBNOPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch JGPKLPANPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HDGLGIJAKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long HOFAEDJJBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object PPBOADGJACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal PMJLINAOGAP MNOOOABBABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal PMJLINAOGAP GLJFFPHKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<PEFBOOHKJGB> DADCGELOLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<KPHOEKKIACJ> OGPEAMCHMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly KPHOEKKIACJ[] KCGHFGBJMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int OFAEFJPIPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int MDCIODLBLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool LBEFNJOLIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int EKKGHKJKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int GPFGHJEBKLB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DMGCLFMNHID = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int FMJLBFLNJLC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object ACLLDOFHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PHPPECNOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, CDHMMCCJDKP> ILDBLBGJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> JJNPCKPDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PEFBOOHKJGB AEHOJHLPPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HNAIMNKBLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int HFNFFLOKHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint MOHBKKKDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int DDADDPILDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int MLFCICAIGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long NAMNBCFHHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte NODJOOJKPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OHGANFPCIPI HOLIBBBGALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PEFBOOHKJGB MPEHDIBCGDM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int IDMPNCNGCHE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IGFCHJFCPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly PEFBOOHKJGB NFGBKDMCFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly PEFBOOHKJGB KACJNCFGLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly PEFBOOHKJGB JANEOCMIFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly PEFBOOHKJGB GDJHNAFAPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private IFNGJJOOCMH ENNGNLFGHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly MOJDEKGGLPB EHDADHGIDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int ALHOENKOJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object DFNPLFFBNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly AHMPFGFADEF MLBHEINEJBG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte BGLBBIDMMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB60BE0", Offset = "0xB5FDE0", VA = "0x180B60BE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x586ABC0", Offset = "0x5869DC0", VA = "0x18586ABC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint IMHGADCLLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83C3E0", VA = "0x18083D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OHGANFPCIPI ALMGLNPNPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x174ACF0", Offset = "0x1749EF0", VA = "0x18174ACF0")]
		get
		{
			return default(OHGANFPCIPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long AHPEGEBFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BA0", Offset = "0x7D5DA0", VA = "0x1807D6BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FGCIBGBBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xC10540", Offset = "0xC0F740", VA = "0x180C10540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x150B730", Offset = "0x150A930", VA = "0x18150B730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CHLEPCDCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x586ADB0", Offset = "0x5869FB0", VA = "0x18586ADB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MNNMJIMOLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8620", Offset = "0x7D7820", VA = "0x1807D8620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double OFJLCPFKEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x19880F0", Offset = "0x19872F0", VA = "0x1819880F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CBKBIDGDALO KDOFFDPIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x586BF40", Offset = "0x586B140", VA = "0x18586BF40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x586A5D0", Offset = "0x58697D0", VA = "0x18586A5D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x586C2F0", Offset = "0x586B4F0", VA = "0x18586C2F0")]
	internal PMJLINAOGAP(MOJDEKGGLPB NCOADHKDEEP, IPEndPoint MPFJJIBOHHB, int IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x586AC70", Offset = "0x5869E70", VA = "0x18586AC70")]
	internal void IHILDLOLNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5868AA0", Offset = "0x5867CA0", VA = "0x185868AA0")]
	internal void CCGFABMOABF(IPEndPoint KENKACBKDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x586B120", Offset = "0x586A320", VA = "0x18586B120")]
	internal void LGEKFOLFIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x586BDC0", Offset = "0x586AFC0", VA = "0x18586BDC0")]
	private void MIINGFEGJEF(int JHCOPIGCEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x586A590", Offset = "0x5869790", VA = "0x18586A590")]
	private void GGCIJGIMKOF(int KMLCLOJILIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5868AD0", Offset = "0x5867CD0", VA = "0x185868AD0")]
	private KPHOEKKIACJ CFOGBMMJKMG(byte EBLANDPJDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x586C930", Offset = "0x586BB30", VA = "0x18586C930")]
	internal PMJLINAOGAP(MOJDEKGGLPB NCOADHKDEEP, IPEndPoint MPFJJIBOHHB, int IFAFPBGLEJO, byte KLIBIAGFBMG, JNPMGEAGNCH NHNNPBEMHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x586C750", Offset = "0x586B950", VA = "0x18586C750")]
	internal PMJLINAOGAP(MOJDEKGGLPB NCOADHKDEEP, LPACMGBLCKC DAFMLJPHFGN, int IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5868A50", Offset = "0x5867C50", VA = "0x185868A50")]
	internal void CAGJIAJBEMN(LABMFDKNPJB KDCOBGMGAFD, byte[] JLJKEBMIIPF, int IFNAKMJKBID, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x586B0A0", Offset = "0x586A2A0", VA = "0x18586B0A0")]
	internal bool LEAONIDHBIG(MJNPHABLLEM OEDGBABNEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x586ADC0", Offset = "0x5869FC0", VA = "0x18586ADC0")]
	public void KMNJICOONBA(byte[] JLJKEBMIIPF, int IFNAKMJKBID, int MKCBFIBLIDD, IPEEAIEOMNN PPBCABJPHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5869FE0", Offset = "0x58691E0", VA = "0x185869FE0")]
	private void FFBOCCHFLLE(byte[] JLJKEBMIIPF, int IFNAKMJKBID, int MKCBFIBLIDD, byte GMBNAMKIDOB, IPEEAIEOMNN PPAGKBBDJCD, object EDJJHIAHIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x586BE90", Offset = "0x586B090", VA = "0x18586BE90")]
	public void MMHOIBBPFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x586AFC0", Offset = "0x586A1C0", VA = "0x18586AFC0")]
	internal JJBOHDFPHDJ LBOKNOBIDJI(PEFBOOHKJGB OEDGBABNEEC)
	{
		return default(JJBOHDFPHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x586A530", Offset = "0x5869730", VA = "0x18586A530")]
	internal void FLAMHDPHEPI(KPHOEKKIACJ KINMAPDAFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5868C80", Offset = "0x5867E80", VA = "0x185868C80")]
	internal OCCFEONNIHG CNFIFJFPOBI(byte[] JLJKEBMIIPF, int IFNAKMJKBID, int MKCBFIBLIDD, bool LBPGAAMAJKE)
	{
		return default(OCCFEONNIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x586C2B0", Offset = "0x586B4B0", VA = "0x18586C2B0")]
	private void PFDNBPADKCK(int FBAPCLPKHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5869640", Offset = "0x5868840", VA = "0x185869640")]
	internal void EHBOFDDKEAI(IPEEAIEOMNN IAFFDCPPJFN, PEFBOOHKJGB DBMDKHEIDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x586B860", Offset = "0x586AA60", VA = "0x18586B860")]
	private void MEKJNJHFHIF(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x586A680", Offset = "0x5869880", VA = "0x18586A680")]
	private void HMOMMLKLGEL(int ADBEIAHCPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x586AA00", Offset = "0x5869C00", VA = "0x18586AA00")]
	internal PKKFIBECIGH HOGOPPFPMHI(LABMFDKNPJB BBGOLDBGNIF)
	{
		return default(PKKFIBECIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x586B1B0", Offset = "0x586A3B0", VA = "0x18586B1B0")]
	internal void MBMJKNBBPOI(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x586AC90", Offset = "0x5869E90", VA = "0x18586AC90")]
	private void IKMPJKLANDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x586ADF0", Offset = "0x5869FF0", VA = "0x18586ADF0")]
	internal void LALPKNGDACG(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5868F90", Offset = "0x5868190", VA = "0x185868F90")]
	internal void DBKEHPIBNHN(int ADBEIAHCPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x586BFF0", Offset = "0x586B1F0", VA = "0x18586BFF0")]
	internal void PCMCJCOLAJD(PEFBOOHKJGB OEDGBABNEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class AHMPFGFADEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long ODIEENADDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long IOBGELPAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long EKMCDJJIMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long KDNFANKFDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HMMKKHABFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long KPIGLJBEIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long IDNMADNDFNP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long GDLLEDBCEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5856C50", Offset = "0x5855E50", VA = "0x185856C50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EOPCOAPIFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5856C60", Offset = "0x5855E60", VA = "0x185856C60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PCAHCLAHDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5856E40", Offset = "0x5856040", VA = "0x185856E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long AGOOOBFCLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5856E20", Offset = "0x5856020", VA = "0x185856E20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MIMNHKCHGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5856D60", Offset = "0x5855F60", VA = "0x185856D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PNEJCBNEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5856D50", Offset = "0x5855F50", VA = "0x185856D50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private IFNGJJOOCMH FOMPJBPBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5856C10", Offset = "0x5855E10", VA = "0x185856C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double PNPPPCGGEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5856CA0", Offset = "0x5855EA0", VA = "0x185856CA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5856BB0", Offset = "0x5855DB0", VA = "0x185856BB0")]
	public void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5856C70", Offset = "0x5855E70", VA = "0x185856C70")]
	public void LANNJLMFGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5856E30", Offset = "0x5856030", VA = "0x185856E30")]
	public void PDCCCJNBIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5856D40", Offset = "0x5855F40", VA = "0x185856D40")]
	public void NBECHIIONOE(long JPHPMHKFHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5856D70", Offset = "0x5855F70", VA = "0x185856D70")]
	public void OAPOLPPHAPN(long EBCAGKCPLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5856C20", Offset = "0x5855E20", VA = "0x185856C20")]
	public void GKMPOMFBFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5856D00", Offset = "0x5855F00", VA = "0x185856D00")]
	public void MBCBFFBGJJI(long EOCIFOFIJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5856E50", Offset = "0x5856050", VA = "0x185856E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5856D80", Offset = "0x5855F80", VA = "0x185856D80")]
	public void OJCGAAIJFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AHMPFGFADEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NHNHKJAGMKP
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> FECCFLPOFAA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58678F0", Offset = "0x5866AF0", VA = "0x1858678F0")]
	public static IPEndPoint DGIGFNAALKO(string CINKHPPKGHC, int IFCDCDHKHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5867C00", Offset = "0x5866E00", VA = "0x185867C00")]
	public static IPAddress OMIJBMKNIFF(string CINKHPPKGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5867B70", Offset = "0x5866D70", VA = "0x185867B70")]
	public static IPAddress OMIJBMKNIFF(string CINKHPPKGHC, AddressFamily GAIDBNJAOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5867B40", Offset = "0x5866D40", VA = "0x185867B40")]
	internal static int MKODAKBIOCK(int HCAEMJDNKJE, int PIKKHJJOOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6270", Offset = "0x2AC5470", VA = "0x182AC6270")]
	internal static T[] PGHNAMMMBJA<T>(int BIFLOKBJAPK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HLCMGJNOJAD : KPHOEKKIACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DPEGKBDMLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private PEFBOOHKJGB FIBANMJCHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long MMNCFGHNCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool KBCAFAMFDJK;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5857DD0", Offset = "0x5856FD0", VA = "0x185857DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5857D40", Offset = "0x5856F40", VA = "0x185857D40")]
		public void ICOEADAEIAE(PEFBOOHKJGB OEDGBABNEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5857D60", Offset = "0x5856F60", VA = "0x185857D60")]
		public bool LOPHDCEHABG(long HJNBFIECMFA, PMJLINAOGAP GIHJEDKNBCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5857CF0", Offset = "0x5856EF0", VA = "0x185857CF0")]
		public bool BFDHFEEMFPE(PMJLINAOGAP GIHJEDKNBCL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly PEFBOOHKJGB MIMFBCPEKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DPEGKBDMLNA[] MKPNJJIOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly PEFBOOHKJGB[] KKIHMHEBIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] DJOPPBHIMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int EENGIMNBOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int ONNGOPJEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int LEKCOMDMOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int DNDGKJBODKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KAPCEHMGAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly IPEEAIEOMNN KNAIGPAKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool JIJFDHCFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int CDPFALPMBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte CKLJIIHONKI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5859A90", Offset = "0x5858C90", VA = "0x185859A90")]
	public HLCMGJNOJAD(PMJLINAOGAP GIHJEDKNBCL, bool KFOLLOKGELO, byte IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x58596D0", Offset = "0x58588D0", VA = "0x1858596D0")]
	private void ODBADAIPHAK(PEFBOOHKJGB OEDGBABNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5858BC0", Offset = "0x5857DC0", VA = "0x185858BC0", Slot = "4")]
	protected override bool JNLELHIMOCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5859070", Offset = "0x5858270", VA = "0x185859070", Slot = "5")]
	public override bool MBMJKNBBPOI(PEFBOOHKJGB OEDGBABNEEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NEMAKPGENIM : KPHOEKKIACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int IJJIOCHGBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort ONNGOPJEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool DIHJCCEICJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PEFBOOHKJGB BKPKDPNAEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly PEFBOOHKJGB EHPGNOKGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool MFOKGHKGNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte CKLJIIHONKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long ODIAGLMGBPL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5867830", Offset = "0x5866A30", VA = "0x185867830")]
	public NEMAKPGENIM(PMJLINAOGAP GIHJEDKNBCL, bool LPMELAHMCKG, byte IFAFPBGLEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5867080", Offset = "0x5866280", VA = "0x185867080", Slot = "4")]
	protected override bool JNLELHIMOCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5867520", Offset = "0x5866720", VA = "0x185867520", Slot = "5")]
	public override bool MBMJKNBBPOI(PEFBOOHKJGB OEDGBABNEEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MCOPKIDICAJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct GIHPPDPCEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong FMPFAOGOAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double HPMEHLIHBAK;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JKFADBFEILB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int PDJDMEJHGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float JGIKLHEHEPH;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x58567E0", Offset = "0x58559E0", VA = "0x1858567E0")]
	private static void CGMBBBONGAF(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, ulong JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x585F7C0", Offset = "0x585E9C0", VA = "0x18585F7C0")]
	private static void CGMBBBONGAF(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, int JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x585F830", Offset = "0x585EA30", VA = "0x18585F830")]
	public static void CGMBBBONGAF(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, short JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x585F870", Offset = "0x585EA70", VA = "0x18585F870")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, double HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x585F8A0", Offset = "0x585EAA0", VA = "0x18585F8A0")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x585F830", Offset = "0x585EA30", VA = "0x18585F830")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, short HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x585F830", Offset = "0x585EA30", VA = "0x18585F830")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, ushort HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x585F7C0", Offset = "0x585E9C0", VA = "0x18585F7C0")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x585F7C0", Offset = "0x585E9C0", VA = "0x18585F7C0")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, uint HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x585F890", Offset = "0x585EA90", VA = "0x18585F890")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x585F890", Offset = "0x585EA90", VA = "0x18585F890")]
	public static void DPMDMOPEJHG(byte[] PGPEJDBBJED, int CJICFAPMKCE, ulong HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JKIKOOAKOPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] NCAIBNBKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int GMJCAHEMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int EEFEAPDJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int HCNANDFONAC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] IGAGEOJMBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int ENDBKCDCKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GPGCEOMDGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x585C1F0", Offset = "0x585B3F0", VA = "0x18585C1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HJLOIDBAJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6DB0", Offset = "0x1DC5FB0", VA = "0x181DC6DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GGCPDDFKPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x585B8B0", Offset = "0x585AAB0", VA = "0x18585B8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x585C140", Offset = "0x585B340", VA = "0x18585C140")]
	public void KIAELKLGKLH(byte[] GNIGPOPNBEB, int CFPEDCFCDGK, int OIAOHGKBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public JKIKOOAKOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x585C460", Offset = "0x585B660", VA = "0x18585C460")]
	public JKIKOOAKOPB(byte[] GNIGPOPNBEB, int CFPEDCFCDGK, int OIAOHGKBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x585BA80", Offset = "0x585AC80", VA = "0x18585BA80")]
	public IPEndPoint FJMOCEANBEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x585C420", Offset = "0x585B620", VA = "0x18585C420")]
	public byte OIKFEDAGLBN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x585C420", Offset = "0x585B620", VA = "0x18585C420")]
	public sbyte PLDCBPCKALC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29F4B90", Offset = "0x29F3D90", VA = "0x1829F4B90")]
	public T[] FHOCPBLAHPM<T>(ushort AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x585BC00", Offset = "0x585AE00", VA = "0x18585BC00")]
	public bool[] FMPDGPCOIAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x585B870", Offset = "0x585AA70", VA = "0x18585B870")]
	public ushort[] AANCEKFOPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x585B990", Offset = "0x585AB90", VA = "0x18585B990")]
	public short[] EJPAFNBIDMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x585C330", Offset = "0x585B530", VA = "0x18585C330")]
	public int[] NHDFEIMLKGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x585BEF0", Offset = "0x585B0F0", VA = "0x18585BEF0")]
	public uint[] IFODGABEGDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x585BA40", Offset = "0x585AC40", VA = "0x18585BA40")]
	public float[] FBDDJJOOCLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x585C2B0", Offset = "0x585B4B0", VA = "0x18585C2B0")]
	public double[] MDEAJPEJCDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x585B8E0", Offset = "0x585AAE0", VA = "0x18585B8E0")]
	public long[] DFPNAMLLCGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x585C270", Offset = "0x585B470", VA = "0x18585C270")]
	public ulong[] MCIFCOHAFNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x585BFA0", Offset = "0x585B1A0", VA = "0x18585BFA0")]
	public string[] JLBJEHCKPPP(int KFOJBOBDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x585C2F0", Offset = "0x585B4F0", VA = "0x18585C2F0")]
	public bool MLHHCEHDOKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x585BF30", Offset = "0x585B130", VA = "0x18585BF30")]
	public char JEFMPKAFJPK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x585BF30", Offset = "0x585B130", VA = "0x18585BF30")]
	public ushort POJCDMBJJHF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x585C200", Offset = "0x585B400", VA = "0x18585C200")]
	public short LLONCMOEFIG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x585B9D0", Offset = "0x585ABD0", VA = "0x18585B9D0")]
	public long EKLPDOKCFHL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x585C180", Offset = "0x585B380", VA = "0x18585C180")]
	public ulong KPCPGFLKLDP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x585BC40", Offset = "0x585AE40", VA = "0x18585BC40")]
	public int GNFJPCIMLDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x585B920", Offset = "0x585AB20", VA = "0x18585B920")]
	public uint DHEHGODPPDO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x585C0D0", Offset = "0x585B2D0", VA = "0x18585C0D0")]
	public float KFCJPHKJCHD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x585C3B0", Offset = "0x585B5B0", VA = "0x18585C3B0")]
	public double OEMIGCMGKKF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x585BCB0", Offset = "0x585AEB0", VA = "0x18585BCB0")]
	public string IFAAGBJOGJD(int EONMMHJJMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x585BB90", Offset = "0x585AD90", VA = "0x18585BB90")]
	public ArraySegment<byte> FLOPKPPOBNH(int BIFLOKBJAPK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x585C370", Offset = "0x585B570", VA = "0x18585C370")]
	public sbyte[] OEACLNDJCOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x585BB50", Offset = "0x585AD50", VA = "0x18585BB50")]
	public byte[] FKCHOIFMCMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x585B8C0", Offset = "0x585AAC0", VA = "0x18585B8C0")]
	public void BFDHFEEMFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JNPMGEAGNCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] NCAIBNBKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int GMJCAHEMMIH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int ICLGFKBKEIG = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool DBPPFEPOOKN;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding INJKMMEHEJM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int OBJLOOPBAEM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] LAHHANDKJMO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] GICDCDBMPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x585D290", Offset = "0x585C490", VA = "0x18585D290")]
	public JNPMGEAGNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x585D310", Offset = "0x585C510", VA = "0x18585D310")]
	public JNPMGEAGNCH(bool LPIAOKFADKD, int NPNCPALHHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x585D190", Offset = "0x585C390", VA = "0x18585D190")]
	public static JNPMGEAGNCH POBPEDAOJCH(string HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x585CA90", Offset = "0x585BC90", VA = "0x18585CA90")]
	public void HNLBBLNBENN(int AEEIDPFNOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1E416B0", Offset = "0x1E408B0", VA = "0x181E416B0")]
	public void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x585CC90", Offset = "0x585BE90", VA = "0x18585CC90")]
	public void IDKKJFMPLAK(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x585CD90", Offset = "0x585BF90", VA = "0x18585CD90")]
	public void IDKKJFMPLAK(double HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x585D000", Offset = "0x585C200", VA = "0x18585D000")]
	public void IDKKJFMPLAK(long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x585D000", Offset = "0x585C200", VA = "0x18585D000")]
	public void IDKKJFMPLAK(ulong HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x585CB90", Offset = "0x585BD90", VA = "0x18585CB90")]
	public void IDKKJFMPLAK(int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x585CB90", Offset = "0x585BD90", VA = "0x18585CB90")]
	public void IDKKJFMPLAK(uint HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x585CC20", Offset = "0x585BE20", VA = "0x18585CC20")]
	public void IDKKJFMPLAK(char HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x585CC20", Offset = "0x585BE20", VA = "0x18585CC20")]
	public void IDKKJFMPLAK(ushort HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x585CC20", Offset = "0x585BE20", VA = "0x18585CC20")]
	public void IDKKJFMPLAK(short HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x585CB30", Offset = "0x585BD30", VA = "0x18585CB30")]
	public void IDKKJFMPLAK(sbyte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x585CB30", Offset = "0x585BD30", VA = "0x18585CB30")]
	public void IDKKJFMPLAK(byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x585D120", Offset = "0x585C320", VA = "0x18585D120")]
	public void IDKKJFMPLAK(byte[] JLJKEBMIIPF, int CFPEDCFCDGK, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x585C560", Offset = "0x585B760", VA = "0x18585C560")]
	public void DEIHNMLFODF(sbyte[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x585C560", Offset = "0x585B760", VA = "0x18585C560")]
	public void FLFAHOEHCFI(byte[] JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x585CD30", Offset = "0x585BF30", VA = "0x18585CD30")]
	public void IDKKJFMPLAK(bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x585C9B0", Offset = "0x585BBB0", VA = "0x18585C9B0")]
	public void FFGLKHHPANG(Array LCMJHGDLFJG, int FPLBFBMGMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x585C800", Offset = "0x585BA00", VA = "0x18585C800")]
	public void FFGLKHHPANG(float[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x585C640", Offset = "0x585B840", VA = "0x18585C640")]
	public void FFGLKHHPANG(double[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x585C640", Offset = "0x585B840", VA = "0x18585C640")]
	public void FFGLKHHPANG(long[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x585C640", Offset = "0x585B840", VA = "0x18585C640")]
	public void FFGLKHHPANG(ulong[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x585C800", Offset = "0x585BA00", VA = "0x18585C800")]
	public void FFGLKHHPANG(int[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x585C800", Offset = "0x585BA00", VA = "0x18585C800")]
	public void FFGLKHHPANG(uint[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x585C720", Offset = "0x585B920", VA = "0x18585C720")]
	public void FFGLKHHPANG(ushort[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x585C720", Offset = "0x585B920", VA = "0x18585C720")]
	public void FFGLKHHPANG(short[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x585C560", Offset = "0x585B760", VA = "0x18585C560")]
	public void FFGLKHHPANG(bool[] HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x585C8E0", Offset = "0x585BAE0", VA = "0x18585C8E0")]
	public void FFGLKHHPANG(string[] HLCKBKFCMPI, int BAJEMKNFOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x585D050", Offset = "0x585C250", VA = "0x18585D050")]
	public void IDKKJFMPLAK(IPEndPoint FOKMNNFMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x585CFF0", Offset = "0x585C1F0", VA = "0x18585CFF0")]
	public void IDKKJFMPLAK(string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x585CDE0", Offset = "0x585BFE0", VA = "0x18585CDE0")]
	public void IDKKJFMPLAK(string HLCKBKFCMPI, int EONMMHJJMND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MAIGJAEKJON
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JNFOMBEIGEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong ALHOENKOJHK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3D90010", Offset = "0x3D8F210", VA = "0x183D90010")]
		static JNFOMBEIGEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KGFACOFMOMN(JKIKOOAKOPB LAAOMLILGHH, object EDJJHIAHIIN);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ICBKEAGDJMN<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public MAIGJAEKJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public ICBKEAGDJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3B04560", Offset = "0x3B03760", VA = "0x183B04560")]
		internal void CDKAFJJIFDH(JKIKOOAKOPB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DBPGFIONNBK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public MAIGJAEKJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public DBPGFIONNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x531F070", Offset = "0x531E270", VA = "0x18531F070")]
		internal void CDKAFJJIFDH(JKIKOOAKOPB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly KPBMHMINKMO KNMGDCBMMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, KGFACOFMOMN> IENJGAFLLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly JNPMGEAGNCH NFGBNHMKGJG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x585F640", Offset = "0x585E840", VA = "0x18585F640")]
	public MAIGJAEKJON(int KFOJBOBDGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	protected virtual ulong OIIKICEDKGE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x585F510", Offset = "0x585E710", VA = "0x18585F510", Slot = "5")]
	protected virtual KGFACOFMOMN JEGFEJAGGDK(JKIKOOAKOPB LAAOMLILGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A59130", Offset = "0x2A58330", VA = "0x182A59130", Slot = "6")]
	protected virtual void GDMFCPIHKDH<T>(JNPMGEAGNCH AELHGGJOBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x585F440", Offset = "0x585E640", VA = "0x18585F440")]
	public void BJOPBOIDEMF(JKIKOOAKOPB LAAOMLILGHH, object EDJJHIAHIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A58DA0", Offset = "0x2A57FA0", VA = "0x182A58DA0")]
	public void CBGODNINDBA<T>(JNPMGEAGNCH AELHGGJOBCK, T OEDGBABNEEC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x585F4C0", Offset = "0x585E6C0", VA = "0x18585F4C0")]
	public void GNEIMBMLDNJ(JKIKOOAKOPB LAAOMLILGHH, object EDJJHIAHIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A58FB0", Offset = "0x2A581B0", VA = "0x182A58FB0")]
	public void DNIGJALPJOE<T>(Action<T> HANIOLDMBBC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A58E30", Offset = "0x2A58030", VA = "0x182A58E30")]
	public void DNIGJALPJOE<T, TUserData>(Action<T, TUserData> HANIOLDMBBC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HAPCPOBMJML : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5857CE0", Offset = "0x5856EE0", VA = "0x185857CE0")]
	public HAPCPOBMJML(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IJCGDPAGHNE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5859C60", Offset = "0x5858E60", VA = "0x185859C60")]
	public IJCGDPAGHNE(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class KPBMHMINKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LLNNHDNDNMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BINDHBIHMMH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LLNNHDNDNMC GADMEDLKBAN;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4A5DF70", Offset = "0x4A5D170", VA = "0x184A5DF70", Slot = "4")]
		public virtual void ICOEADAEIAE(MethodInfo AKJCJEBOIPA, MethodInfo EIGJGCODHKD, LLNNHDNDNMC HHJOOHJDNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FOPLGAHIDFE(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DLDNKGMOCLA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected BINDHBIHMMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class OMOCHGGMOCP<TClass, TProperty> : BINDHBIHMMH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> OLLCPDPCPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> KICFJHJEJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> CMKAJELCHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> HDNBFGMAEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> IPPCNGMEDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> DHLIMMOFIEJ;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x42AB540", Offset = "0x42AA740", VA = "0x1842AB540", Slot = "7")]
		public override void BPGBEJHKJLD(TClass KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x42B1BD0", Offset = "0x42B0DD0", VA = "0x1842B1BD0", Slot = "8")]
		public override void PLEIGGNGKEJ(TClass KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x42ACB20", Offset = "0x42ABD20", VA = "0x1842ACB20", Slot = "9")]
		public override void FOPLGAHIDFE(TClass KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x42ABD20", Offset = "0x42AAF20", VA = "0x1842ABD20", Slot = "10")]
		public override void DLDNKGMOCLA(TClass KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x42B1AE0", Offset = "0x42B0CE0", VA = "0x1842B1AE0")]
		protected TProperty[] MPAEDCHMLBG(TClass KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x42B1A70", Offset = "0x42B0C70", VA = "0x1842B1A70")]
		protected TProperty[] LBNEMAEOHNN(TClass KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x42B0430", Offset = "0x42AF630", VA = "0x1842B0430", Slot = "4")]
		public override void ICOEADAEIAE(MethodInfo AKJCJEBOIPA, MethodInfo EIGJGCODHKD, LLNNHDNDNMC HHJOOHJDNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3574120", Offset = "0x3573320", VA = "0x183574120")]
		protected OMOCHGGMOCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class GNLIPIPENKN<TClass, TProperty> : OMOCHGGMOCP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void DKJLOLEAHPB(JKIKOOAKOPB EHGBCDPMKNC, [Out] TProperty MCNKJLHLIPF);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void LBIMGHMHAMP(JNPMGEAGNCH EDEGHDPMPJM, TProperty MCNKJLHLIPF);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39E8840", Offset = "0x39E7A40", VA = "0x1839E8840", Slot = "5")]
		public override void CPFOEAHENHM(TClass KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39E8760", Offset = "0x39E7960", VA = "0x1839E8760", Slot = "6")]
		public override void CBGODNINDBA(TClass KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39E8620", Offset = "0x39E7820", VA = "0x1839E8620", Slot = "7")]
		public override void BPGBEJHKJLD(TClass KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39E89E0", Offset = "0x39E7BE0", VA = "0x1839E89E0", Slot = "8")]
		public override void PLEIGGNGKEJ(TClass KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x39E8A80", Offset = "0x39E7C80", VA = "0x1839E8A80")]
		protected GNLIPIPENKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EPEPJIOKIDC<T> : OMOCHGGMOCP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35A6190", Offset = "0x35A5390", VA = "0x1835A6190", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35A6140", Offset = "0x35A5340", VA = "0x1835A6140", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35A60E0", Offset = "0x35A52E0", VA = "0x1835A60E0", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x35A61F0", Offset = "0x35A53F0", VA = "0x1835A61F0", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public EPEPJIOKIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class KDMILOKBDDL<T> : OMOCHGGMOCP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BEB0", Offset = "0x3E4B0B0", VA = "0x183E4BEB0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x35A6140", Offset = "0x35A5340", VA = "0x1835A6140", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BE50", Offset = "0x3E4B050", VA = "0x183E4BE50", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x35A61F0", Offset = "0x35A53F0", VA = "0x1835A61F0", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public KDMILOKBDDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class JFIIFBPOLLG<T> : OMOCHGGMOCP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3CF41B0", Offset = "0x3CF33B0", VA = "0x183CF41B0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4160", Offset = "0x3CF3360", VA = "0x183CF4160", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4100", Offset = "0x3CF3300", VA = "0x183CF4100", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4210", Offset = "0x3CF3410", VA = "0x183CF4210", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public JFIIFBPOLLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class PFGFICCACBN<T> : OMOCHGGMOCP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x43AF2C0", Offset = "0x43AE4C0", VA = "0x1843AF2C0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4160", Offset = "0x3CF3360", VA = "0x183CF4160", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x43AF260", Offset = "0x43AE460", VA = "0x1843AF260", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4210", Offset = "0x3CF3410", VA = "0x183CF4210", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public PFGFICCACBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JHPIDEGGFAE<T> : OMOCHGGMOCP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D54FD0", Offset = "0x3D541D0", VA = "0x183D54FD0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F80", Offset = "0x3D54180", VA = "0x183D54F80", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F20", Offset = "0x3D54120", VA = "0x183D54F20", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3A51210", Offset = "0x3A50410", VA = "0x183A51210", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public JHPIDEGGFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DFFCJBPACAL<T> : OMOCHGGMOCP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5328B90", Offset = "0x5327D90", VA = "0x185328B90", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F80", Offset = "0x3D54180", VA = "0x183D54F80", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5328B30", Offset = "0x5327D30", VA = "0x185328B30", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3A51210", Offset = "0x3A50410", VA = "0x183A51210", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public DFFCJBPACAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class EPHFOCPJODK<T> : OMOCHGGMOCP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E00", Offset = "0x35A6000", VA = "0x1835A6E00", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x35A6DB0", Offset = "0x35A5FB0", VA = "0x1835A6DB0", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x35A6D50", Offset = "0x35A5F50", VA = "0x1835A6D50", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E60", Offset = "0x35A6060", VA = "0x1835A6E60", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public EPHFOCPJODK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class LIGELKMLFMM<T> : OMOCHGGMOCP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E00", Offset = "0x35A6000", VA = "0x1835A6E00", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x35A6DB0", Offset = "0x35A5FB0", VA = "0x1835A6DB0", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F56A50", Offset = "0x3F55C50", VA = "0x183F56A50", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E60", Offset = "0x35A6060", VA = "0x1835A6E60", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public LIGELKMLFMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AMPEGFLMIFE<T> : OMOCHGGMOCP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D64510", Offset = "0x3D63710", VA = "0x183D64510", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D644C0", Offset = "0x3D636C0", VA = "0x183D644C0", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D64460", Offset = "0x3D63660", VA = "0x183D64460", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x35A61F0", Offset = "0x35A53F0", VA = "0x1835A61F0", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public AMPEGFLMIFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HMEPGABOOKI<T> : OMOCHGGMOCP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A511B0", Offset = "0x3A503B0", VA = "0x183A511B0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A51160", Offset = "0x3A50360", VA = "0x183A51160", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A51100", Offset = "0x3A50300", VA = "0x183A51100", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A51210", Offset = "0x3A50410", VA = "0x183A51210", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public HMEPGABOOKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class DLGDEOADOMC<T> : OMOCHGGMOCP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x53413A0", Offset = "0x53405A0", VA = "0x1853413A0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5341350", Offset = "0x5340550", VA = "0x185341350", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x53412F0", Offset = "0x53404F0", VA = "0x1853412F0", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E60", Offset = "0x35A6060", VA = "0x1835A6E60", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x35A6240", Offset = "0x35A5440", VA = "0x1835A6240")]
		public DLGDEOADOMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class GEJBPLFOOPN<T> : GNLIPIPENKN<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39C5DD0", Offset = "0x39C4FD0", VA = "0x1839C5DD0", Slot = "12")]
		protected override void LBIMGHMHAMP(JNPMGEAGNCH EDEGHDPMPJM, char MCNKJLHLIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39C5DA0", Offset = "0x39C4FA0", VA = "0x1839C5DA0", Slot = "11")]
		protected override void DKJLOLEAHPB(JKIKOOAKOPB EHGBCDPMKNC, [Out] char MCNKJLHLIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39A3A60", Offset = "0x39A2C60", VA = "0x1839A3A60")]
		public GEJBPLFOOPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BIDPLBPAPFO<T> : GNLIPIPENKN<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4A5DCC0", Offset = "0x4A5CEC0", VA = "0x184A5DCC0", Slot = "12")]
		protected override void LBIMGHMHAMP(JNPMGEAGNCH EDEGHDPMPJM, IPEndPoint MCNKJLHLIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A5DC80", Offset = "0x4A5CE80", VA = "0x184A5DC80", Slot = "11")]
		protected override void DKJLOLEAHPB(JKIKOOAKOPB EHGBCDPMKNC, [Out] IPEndPoint MCNKJLHLIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x39A3A60", Offset = "0x39A2C60", VA = "0x1839A3A60")]
		public BIDPLBPAPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class PECIKEPNKMB<T> : OMOCHGGMOCP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int PMHNOLDNAEI;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43ADA10", Offset = "0x43ACC10", VA = "0x1843ADA10")]
		public PECIKEPNKMB(int EONMMHJJMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x43AD940", Offset = "0x43ACB40", VA = "0x1843AD940", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x43AD8E0", Offset = "0x43ACAE0", VA = "0x1843AD8E0", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x43AD870", Offset = "0x43ACA70", VA = "0x1843AD870", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x43AD9B0", Offset = "0x43ACBB0", VA = "0x1843AD9B0", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OCEFKIIGMKM<T> : BINDHBIHMMH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo DADKHEMCEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type NIJPEHFEPDH;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x42831F0", Offset = "0x42823F0", VA = "0x1842831F0")]
		public OCEFKIIGMKM(PropertyInfo EHMJOHOMDOD, Type ACJMJIIBALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4283010", Offset = "0x4282210", VA = "0x184283010", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4282F60", Offset = "0x4282160", VA = "0x184282F60", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4282F00", Offset = "0x4282100", VA = "0x184282F00", Slot = "7")]
		public override void BPGBEJHKJLD(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4283190", Offset = "0x4282390", VA = "0x184283190", Slot = "8")]
		public override void PLEIGGNGKEJ(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4283130", Offset = "0x4282330", VA = "0x184283130", Slot = "9")]
		public override void FOPLGAHIDFE(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x42830D0", Offset = "0x42822D0", VA = "0x1842830D0", Slot = "10")]
		public override void DLDNKGMOCLA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class NNJFJEADFGH<T> : OCEFKIIGMKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x355FB60", Offset = "0x355ED60", VA = "0x18355FB60")]
		public NNJFJEADFGH(PropertyInfo EHMJOHOMDOD, Type ACJMJIIBALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x41CFED0", Offset = "0x41CF0D0", VA = "0x1841CFED0", Slot = "5")]
		public override void CPFOEAHENHM(T KPIOBABCHMA, JKIKOOAKOPB EHGBCDPMKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x41CFE20", Offset = "0x41CF020", VA = "0x1841CFE20", Slot = "6")]
		public override void CBGODNINDBA(T KPIOBABCHMA, JNPMGEAGNCH EDEGHDPMPJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class FKOLJGMECBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static FKOLJGMECBO<T> LNFBMICMFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly BINDHBIHMMH<T>[] HMOMOEPELGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int NKPPFBOIJNM;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3919F50", Offset = "0x3919150", VA = "0x183919F50")]
		public FKOLJGMECBO(List<BINDHBIHMMH<T>> BCKHGABHJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3919DF0", Offset = "0x3918FF0", VA = "0x183919DF0")]
		public void CBGODNINDBA(T CDJAKLIPEBF, JNPMGEAGNCH AELHGGJOBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3919EA0", Offset = "0x39190A0", VA = "0x183919EA0")]
		public void CPFOEAHENHM(T CDJAKLIPEBF, JKIKOOAKOPB LAAOMLILGHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class LOKKOHADLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BINDHBIHMMH<T> JIBGFLOLNJM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private JNPMGEAGNCH HFOGEBDEIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int HOKBLEEKJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, LOKKOHADLMC> DNMDJEMLDCE;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x585D3B0", Offset = "0x585C5B0", VA = "0x18585D3B0")]
	public KPBMHMINKMO(int KFOJBOBDGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BFA0", Offset = "0x2A2B1A0", VA = "0x182A2BFA0")]
	private FKOLJGMECBO<T> LDHMONAFHMB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x295B330", Offset = "0x295A530", VA = "0x18295B330")]
	public void FLGJIGKCNJL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BF20", Offset = "0x2A2B120", VA = "0x182A2BF20")]
	public bool IHPADLGFHBL<T>(JKIKOOAKOPB LAAOMLILGHH, T FMEDEJNEJHJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BEC0", Offset = "0x2A2B0C0", VA = "0x182A2BEC0")]
	public void GKNEHCEDNDE<T>(JNPMGEAGNCH AELHGGJOBCK, T CDJAKLIPEBF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JIEKBKFMHHM
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime HGCJBOCPCLO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] CGNJCNCEFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ENMAOFOKJPA DOLJPDHDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x585A520", Offset = "0x5859720", VA = "0x18585A520")]
		get
		{
			return default(ENMAOFOKJPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int NGIIOEAJBON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x585AAB0", Offset = "0x5859CB0", VA = "0x18585AAB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x585A2E0", Offset = "0x58594E0", VA = "0x18585A2E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KMJKGIIBGCB NHOMBPKJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x585A4F0", Offset = "0x58596F0", VA = "0x18585A4F0")]
		get
		{
			return default(KMJKGIIBGCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x585AA70", Offset = "0x5859C70", VA = "0x18585AA70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PIOLCNJPOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x585AB10", Offset = "0x5859D10", VA = "0x18585AB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint MJCKGIBJNON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x585ABA0", Offset = "0x5859DA0", VA = "0x18585ABA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? BLHJJPFDPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5859CF0", Offset = "0x5858EF0", VA = "0x185859CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? OLMPDIDCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5859CC0", Offset = "0x5858EC0", VA = "0x185859CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? AHNLFEDJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x585AAE0", Offset = "0x5859CE0", VA = "0x18585AAE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x585A040", Offset = "0x5859240", VA = "0x18585A040")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? FDMDHBBJLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9D0310", Offset = "0x9CF510", VA = "0x1809D0310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x585AD30", Offset = "0x5859F30", VA = "0x18585AD30")]
	public JIEKBKFMHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x585AC80", Offset = "0x5859E80", VA = "0x18585AC80")]
	internal JIEKBKFMHHM(byte[] PGPEJDBBJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x585A750", Offset = "0x5859950", VA = "0x18585A750")]
	public static JIEKBKFMHHM KINLILPMGNL(byte[] PGPEJDBBJED, DateTime PCNPFCLENFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x585A870", Offset = "0x5859A70", VA = "0x18585A870")]
	internal void MACCMAACCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5859D20", Offset = "0x5858F20", VA = "0x185859D20")]
	private void CEGPBDMKCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x585A550", Offset = "0x5859750", VA = "0x18585A550")]
	private DateTime? KGJGPOAMAOK(int CFPEDCFCDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x585A320", Offset = "0x5859520", VA = "0x18585A320")]
	private void HPIMMFCIDOM(int CFPEDCFCDGK, DateTime? HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x585A210", Offset = "0x5859410", VA = "0x18585A210")]
	private ulong HAKGIPCNOLE(int CFPEDCFCDGK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5859EF0", Offset = "0x58590F0", VA = "0x185859EF0")]
	private void CKIJPIOPOCP(int CFPEDCFCDGK, ulong HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5859FB0", Offset = "0x58591B0", VA = "0x185859FB0")]
	private uint CMJOLHPLDHE(int CFPEDCFCDGK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5728C30", Offset = "0x5727E30", VA = "0x185728C30")]
	private static uint PGENAHEJLPO(uint DCHJALFCEJF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x585AB40", Offset = "0x5859D40", VA = "0x18585AB40")]
	private static ulong PGENAHEJLPO(ulong DCHJALFCEJF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ENMAOFOKJPA
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
public enum KMJKGIIBGCB
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class AHCHHMBFLLN
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int FFKELLONCPF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int MGGMFKIBHNL = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int NIDDAGMIOGM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint GCBMGKOJDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int MOIGJEJFFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int JDKLBGDHODK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LJMGGCLANJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5856AB0", Offset = "0x5855CB0", VA = "0x185856AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5856AC0", Offset = "0x5855CC0", VA = "0x185856AC0")]
	public bool KMNJICOONBA(GGLJHHEOHIK FCBCDAJNPDB, int BAPODJDPLNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JINHPBEIKDA : GGLJHHEOHIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket FCBCDAJNPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly MOJDEKGGLPB NCOADHKDEEP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short BCOMNBMLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x585B760", Offset = "0x585A960", VA = "0x18585B760", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int AOPHBOKMMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x585B070", Offset = "0x585A270", VA = "0x18585B070", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint GHANPKKPPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x585B050", Offset = "0x585A250", VA = "0x18585B050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily CENOBFJJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BC50", Offset = "0x3F1AE50", VA = "0x183F1BC50", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x585B7C0", Offset = "0x585A9C0", VA = "0x18585B7C0")]
	public JINHPBEIKDA(AddressFamily GAIDBNJAOAP, MOJDEKGGLPB NCOADHKDEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x585B1A0", Offset = "0x585A3A0", VA = "0x18585B1A0", Slot = "8")]
	public bool IOHGGACLKAB(IPEndPoint FOKMNNFMLKF, FGCPKOKHDOJ MKNHKJOBGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x585B780", Offset = "0x585A980", VA = "0x18585B780", Slot = "9")]
	public int OPKOONAGIAA(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, int AGHIAPEPFJE, IPEndPoint MPFJJIBOHHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x585B0B0", Offset = "0x585A2B0", VA = "0x18585B0B0", Slot = "10")]
	public int INBMDDFNMEM(byte[] OPMKPGEDLGD, EndPoint LFKHNOKIDCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x585B090", Offset = "0x585A290", VA = "0x18585B090", Slot = "11")]
	public void IDHHKFFFJDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface GGLJHHEOHIK
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short BCOMNBMLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int AOPHBOKMMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint GHANPKKPPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily CENOBFJJAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IOHGGACLKAB(IPEndPoint FOKMNNFMLKF, FGCPKOKHDOJ MKNHKJOBGLI);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int OPKOONAGIAA(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, int AGHIAPEPFJE, IPEndPoint MPFJJIBOHHB);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int INBMDDFNMEM(byte[] OPMKPGEDLGD, EndPoint MPFJJIBOHHB);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDHHKFFFJDD();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct ACPNIOLOBGJ : IEquatable<ACPNIOLOBGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long JGLCAONBHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long OHBJCJNOOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long MAEBADHCDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int NPACICMPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int NOFLBHPKHEM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x58569C0", Offset = "0x5855BC0", VA = "0x1858569C0")]
	public ACPNIOLOBGJ(byte[] OGAJAFJJDGG, int KENACFHCIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D10", Offset = "0x7EFF10", VA = "0x1807F0D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5856980", Offset = "0x5855B80", VA = "0x185856980", Slot = "4")]
	public bool Equals(ACPNIOLOBGJ JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x58568D0", Offset = "0x5855AD0", VA = "0x1858568D0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class OBDPFLFAFKI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] DPPPEDFDFMG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class MPOLPKKFCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int CILMBPNJALC;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
	protected MPOLPKKFCNE(int FAOJDKENNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EDNHLDJJCCE(IPEndPoint FOKMNNFMLKF, byte[] JLJKEBMIIPF, int CFPEDCFCDGK, int MKCBFIBLIDD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void KCGECINKGEE(IPEndPoint FOKMNNFMLKF, byte[] JLJKEBMIIPF, int CFPEDCFCDGK, int MKCBFIBLIDD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FOHKBLFJPJI : MPOLPKKFCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider DLDGNDPJMJJ;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator NLKPEDANALC;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5858BA0", Offset = "0x5857DA0", VA = "0x185858BA0")]
	public FOHKBLFJPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5858480", Offset = "0x5857680", VA = "0x185858480")]
	public void JMHMIMFJFBJ(IPEndPoint FOKMNNFMLKF, byte[] MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5858A60", Offset = "0x5857C60", VA = "0x185858A60")]
	public void PKGCBCIMILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5857F50", Offset = "0x5857150", VA = "0x185857F50")]
	private byte[] BLIIMLNFOKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5857FE0", Offset = "0x58571E0", VA = "0x185857FE0", Slot = "4")]
	public override void EDNHLDJJCCE(IPEndPoint FOKMNNFMLKF, byte[] JLJKEBMIIPF, int CFPEDCFCDGK, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x58586C0", Offset = "0x58578C0", VA = "0x1858586C0", Slot = "5")]
	public override void KCGECINKGEE(IPEndPoint FOKMNNFMLKF, byte[] JLJKEBMIIPF, int CFPEDCFCDGK, int MKCBFIBLIDD)
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
