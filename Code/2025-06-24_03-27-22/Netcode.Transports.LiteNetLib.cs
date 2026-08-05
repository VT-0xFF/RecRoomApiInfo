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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, PHPJBBAGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EAOPHKLILKK
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
		private NetworkManager CNDBCJMBMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool AMHJNFKIKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, KAEGNCMEHCB> APCBGFLFPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GPACDFNOKNB NMDCFABOKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch AODMBEIBBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] GCHGKHGAJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EAOPHKLILKK KAICBNOAHLN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int KGHKOKDKGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6FFE640", Offset = "0x6FFD240", VA = "0x186FFE640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong LGMJMCOBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool KMCEJPAPDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FFE620", Offset = "0x6FFD220", VA = "0x186FFE620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDBC0", Offset = "0x6FFC7C0", VA = "0x186FFDBC0")]
		public void RecRoom_SetEncryptionInfo(ulong KBGGDEGOBHM, byte[] MEPFFFGIFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDBA0", Offset = "0x6FFC7A0", VA = "0x186FFDBA0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDA50", Offset = "0x6FFC650", VA = "0x186FFDA50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE520", Offset = "0x6FFD120", VA = "0x186FFE520")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDCE0", Offset = "0x6FFC8E0", VA = "0x186FFDCE0", Slot = "6")]
		public override void Send(ulong KPGHEBOCEPO, ArraySegment<byte> PEDMEJIDLNB, NetworkDelivery BEDJDEFGICN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDB60", Offset = "0x6FFC760", VA = "0x186FFDB60", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong KPGHEBOCEPO, [Out] ArraySegment<byte> ADKJHPADFOA, [Out] float IMBMKDILJGL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDFD0", Offset = "0x6FFCBD0", VA = "0x186FFDFD0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE340", Offset = "0x6FFCF40", VA = "0x186FFE340", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD0B0", Offset = "0x6FFBCB0", VA = "0x186FFD0B0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong KPGHEBOCEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCFC0", Offset = "0x6FFBBC0", VA = "0x186FFCFC0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD2A0", Offset = "0x6FFBEA0", VA = "0x186FFD2A0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong KPGHEBOCEPO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDF60", Offset = "0x6FFCB60", VA = "0x186FFDF60", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD470", Offset = "0x6FFC070", VA = "0x186FFD470", Slot = "15")]
		public override void Initialize([Optional] NetworkManager CNDBCJMBMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD8C0", Offset = "0x6FFC4C0", VA = "0x186FFD8C0")]
		private OKHEPOOFMJN LGGHLHHNNPC(NetworkDelivery OPOPAMPKKGD)
		{
			return default(OKHEPOOFMJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD990", Offset = "0x6FFC590", VA = "0x186FFD990", Slot = "16")]
		private void OFCLNDOBILG(KAEGNCMEHCB HBIMLLJMPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD340", Offset = "0x6FFBF40", VA = "0x186FFD340", Slot = "17")]
		private void HECHPLPGDAH(KAEGNCMEHCB HBIMLLJMPAF, AMDGCCGDPEE NMMLOBCJBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "18")]
		private void CMFNGDDBMOF(IPEndPoint FKNLGOMGPIA, SocketError NEDMAHJGGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD680", Offset = "0x6FFC280", VA = "0x186FFD680", Slot = "19")]
		private void KMOMDKHJJID(KAEGNCMEHCB HBIMLLJMPAF, ODCFCHKGELL EENAIFHJAJK, byte LAGHNKAFMPJ, OKHEPOOFMJN BBHELNKHCAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD1C0", Offset = "0x6FFBDC0", VA = "0x186FFD1C0")]
		private void ECKKPLLDEGK(int DKFJGBGJGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "20")]
		private void GANKKKAOOGO(IPEndPoint NFMNGDEHOOH, ODCFCHKGELL EENAIFHJAJK, CJAFNEOIKKF MHLKIFLELDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "21")]
		private void FMHLCDHFJPF(KAEGNCMEHCB HBIMLLJMPAF, int GHDGEKIIHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD410", Offset = "0x6FFC010", VA = "0x186FFD410", Slot = "22")]
		private void IAOHKCBEBPG(JCFOMECONKL BJAGJMJPKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCF90", Offset = "0x6FFBB90", VA = "0x186FFCF90")]
		private ulong CLEJECOFAEB(KAEGNCMEHCB HBIMLLJMPAF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCF70", Offset = "0x6FFBB70", VA = "0x186FFCF70")]
		private ulong CLEJECOFAEB(ulong KPGHEBOCEPO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDB40", Offset = "0x6FFC740", VA = "0x186FFDB40")]
		private static int PLCOGHHBCKP(float KLCDLOHEBCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE540", Offset = "0x6FFD140", VA = "0x186FFE540")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD890", Offset = "0x6FFC490", VA = "0x186FFD890")]
		[CompilerGenerated]
		private void LEFPFMIKNND(ulong LJKBAJGEHMG, int CCPCBEPJGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD890", Offset = "0x6FFC490", VA = "0x186FFD890")]
		[CompilerGenerated]
		private void KPJLPHFMCFH(ulong LJKBAJGEHMG, int CCPCBEPJGKF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class KNOOFHJLCEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly KAEGNCMEHCB OGNKGOMDPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<HMPLINEPJOI> CEGBIIMACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int BLEOFJMJILJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NGLLENGLKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB9C0", Offset = "0x6FFA5C0", VA = "0x186FFB9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBAD0", Offset = "0x6FFA6D0", VA = "0x186FFBAD0")]
	protected KNOOFHJLCEF(KAEGNCMEHCB HBIMLLJMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB960", Offset = "0x6FFA560", VA = "0x186FFB960")]
	public void CLJGHECPCDK(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBA50", Offset = "0x6FFA650", VA = "0x186FFBA50")]
	protected void NLKPLIJMBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBA10", Offset = "0x6FFA610", VA = "0x186FFBA10")]
	public bool KBAJOEJIIJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool JNEHMHPPPOP();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MBLLPCCNDIE(HMPLINEPJOI KKAHKDEHCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum JOBOOOMLMBL
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JCFOMECONKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly GPACDFNOKNB HKILIPIFKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int MDPAKBDDGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal PLLECAOFDLK JEFPJJBHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint IAONEEMBDAA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal JOBOOOMLMBL BFGAMFNDOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA45B00", Offset = "0xA44700", VA = "0x180A45B00")]
		[CompilerGenerated]
		get
		{
			return default(JOBOOOMLMBL);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE09120", Offset = "0xE07D20", VA = "0x180E09120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF70A0", Offset = "0x6FF5CA0", VA = "0x186FF70A0")]
	internal void PLBBEKKGPCJ(PLLECAOFDLK JLCFBPDCAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7070", Offset = "0x6FF5C70", VA = "0x186FF7070")]
	private bool LEIJFDGAMPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7100", Offset = "0x6FF5D00", VA = "0x186FF7100")]
	internal JCFOMECONKL(IPEndPoint NFMNGDEHOOH, PLLECAOFDLK IKCDFPLHPKN, GPACDFNOKNB PEGKFBCABCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7010", Offset = "0x6FF5C10", VA = "0x186FF7010")]
	public KAEGNCMEHCB JCCMMFMLMJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CJAFNEOIKKF
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JMKODDJPIGC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AMDGCCGDPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public JMKODDJPIGC MBLBEAOIAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError FNNCEHJCEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ODCFCHKGELL NMHOIFADEED;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHPJBBAGKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOJANMAIBEG(KAEGNCMEHCB HBIMLLJMPAF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHNIENLBDLC(KAEGNCMEHCB HBIMLLJMPAF, AMDGCCGDPEE NMMLOBCJBPF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGOCGEAOENH(IPEndPoint FKNLGOMGPIA, SocketError NEDMAHJGGLO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLJKLBCENAO(KAEGNCMEHCB HBIMLLJMPAF, ODCFCHKGELL EENAIFHJAJK, byte LAGHNKAFMPJ, OKHEPOOFMJN BBHELNKHCAL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLEGOCEMELJ(IPEndPoint NFMNGDEHOOH, ODCFCHKGELL EENAIFHJAJK, CJAFNEOIKKF MHLKIFLELDG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHFOBENPDOC(KAEGNCMEHCB HBIMLLJMPAF, int GHDGEKIIHBK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGFINEMOMPK(JCFOMECONKL BJAGJMJPKHA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OADCNDAKALP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMKCHPNKBLB(KAEGNCMEHCB HBIMLLJMPAF, object GJJLHHDMOLL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNFDCJKJPDP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEJFHJDNHDI(IFNNDCINHPE KKAHKDEHCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EPPKICKBPHB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPPKONJDEPK(KAEGNCMEHCB HBIMLLJMPAF, IPEndPoint JINEEFHAKIN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PLLECAOFDLK
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int LOJKCNFGCEI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long ENKOFDJKMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte APJIDEMHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] DMBNKIMIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly CCLMBIGNGDK PBCJADGOGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int AJPGOJGCKIN;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7000AD0", Offset = "0x6FFF6D0", VA = "0x187000AD0")]
	private PLLECAOFDLK(long GGKKJFKPBCO, byte PHOEAPONKOK, int EAOPNGFGOCP, byte[] ICAGPCMGHIK, CCLMBIGNGDK PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7000890", Offset = "0x6FFF490", VA = "0x187000890")]
	public static int ICPKJDIDHOA(HMPLINEPJOI KKAHKDEHCEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7000670", Offset = "0x6FFF270", VA = "0x187000670")]
	public static PLLECAOFDLK HEEDPFHBNBE(HMPLINEPJOI KKAHKDEHCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70008F0", Offset = "0x6FFF4F0", VA = "0x1870008F0")]
	public static HMPLINEPJOI KFIOFMEMLFL(PEECOIMOPMN OLGMDLALGML, SocketAddress DHIAHIOIJHP, long LDKDMDGJJCP, int EAOPNGFGOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class BBHPADEKNEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long ENKOFDJKMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte APJIDEMHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int AJPGOJGCKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool ONDBJFPJLGP;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9E70", Offset = "0x6FE8A70", VA = "0x186FE9E70")]
	private BBHPADEKNEL(long GGKKJFKPBCO, byte PHOEAPONKOK, int ELJIEMEKCON, bool LGIGHNLMHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C30", Offset = "0x6FE8830", VA = "0x186FE9C30")]
	public static BBHPADEKNEL HEEDPFHBNBE(HMPLINEPJOI KKAHKDEHCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9D80", Offset = "0x6FE8980", VA = "0x186FE9D80")]
	public static HMPLINEPJOI KFIOFMEMLFL(long LDKDMDGJJCP, byte HNFGAPOAKHO, int KLBMJIODCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9B30", Offset = "0x6FE8730", VA = "0x186FE9B30")]
	public static HMPLINEPJOI CPHFLCCADEH(KAEGNCMEHCB HBIMLLJMPAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum IFEIFKAFBHC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BJCJKKLIFNL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNICINELECD(IPEndPoint OFGCGGAGNBA, IPEndPoint NFMNGDEHOOH, string HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGCPAAOJED(IPEndPoint DELDNECENOI, IFEIFKAFBHC OPOPAMPKKGD, string HEDGIMBCGHA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OCIHMPBCCKL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PJGMNONGEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint PEPJNMCHJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint IAONEEMBDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string KCBLNLMAMKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct JBLMFKCPPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint JGMOEDIFCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IFEIFKAFBHC JKOHHHGJLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string KCBLNLMAMKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HIEJKHKLIIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NENNAFADNKP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KCBLNLMAMKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HIEJKHKLIIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HCMIMHMAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint NENNAFADNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint CKBGAOAPLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string KCBLNLMAMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HCMIMHMAPOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class JNPOMHIMGIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string KCBLNLMAMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GBJLAJHJHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB30", Offset = "0xA1D730", VA = "0x180A1EB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JNPOMHIMGIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GPACDFNOKNB KJNKJDMIEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<PJGMNONGEFH> GFEPDMEIGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<JBLMFKCPPGK> ELEPJGEAINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CCLMBIGNGDK ONMMFIGKCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PEECOIMOPMN IEDIBINELOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly LCLFBOIFPHL AHBIKDECNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private BJCJKKLIFNL GGPEFJMNGHA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int AFAKJBGFMPG = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool JFJKNJOLKII;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF1D0", Offset = "0x6FFDDD0", VA = "0x186FFF1D0")]
	internal OCIHMPBCCKL(GPACDFNOKNB DFJFKOOJMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEEF0", Offset = "0x6FFDAF0", VA = "0x186FFEEF0")]
	internal void PNODEGJJMNI(IPEndPoint AGPKFIINEGH, HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C68560", Offset = "0x3C67160", VA = "0x183C68560")]
	private void CJJJNINAOAN<T>(T KKAHKDEHCEI, IPEndPoint MDKAAPLMLKG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEBC0", Offset = "0x6FFD7C0", VA = "0x186FFEBC0")]
	private void JNICINELECD(HIEJKHKLIIA HGBNKACONIG, IPEndPoint AGPKFIINEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF070", Offset = "0x6FFDC70", VA = "0x186FFF070")]
	private void POFDLONPCPH(HCMIMHMAPOP HGBNKACONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFED50", Offset = "0x6FFD950", VA = "0x186FFED50")]
	private void MOGAPJPOGJH(JNPOMHIMGIG HGBNKACONIG, IPEndPoint AGPKFIINEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OKHEPOOFMJN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum BNCNBOMJDKK : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FACKDPAOOAE
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] OGJPJGIPJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int HCICHNLKNDH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int KDDCLCHPMMB;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BFPAJMNEPJG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9EC0", Offset = "0x6FE8AC0", VA = "0x186FE9EC0")]
	public BFPAJMNEPJG(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HJMFAJDNCIN : BFPAJMNEPJG
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9EC0", Offset = "0x6FE8AC0", VA = "0x186FE9EC0")]
	public HJMFAJDNCIN(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CHBFMCPGEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OKLJJCICMKB
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOIFPOJABLC(CHBFMCPGEFO KCFJEBAGEKB, string KMCLKBGAPBL, params object[] FABPHEFJGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MMHMDCKMCKK
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static OKLJJCICMKB ACCFNKGCLKD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object MPABBIIDJNM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE880", Offset = "0x6FFD480", VA = "0x186FFE880")]
	private static void OABJOPABICF(CHBFMCPGEFO FPLMINMAMGH, string KMCLKBGAPBL, params object[] FABPHEFJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEAB0", Offset = "0x6FFD6B0", VA = "0x186FFEAB0")]
	internal static void OENCLJDECCM(string KMCLKBGAPBL, params object[] FABPHEFJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE7C0", Offset = "0x6FFD3C0", VA = "0x186FFE7C0")]
	internal static void CGGIGNMFIEJ(string KMCLKBGAPBL, params object[] FABPHEFJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE820", Offset = "0x6FFD420", VA = "0x186FFE820")]
	internal static void LNMMCOINJMP(string KMCLKBGAPBL, params object[] FABPHEFJGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum IJCAAMAFGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ODCFCHKGELL : CCLMBIGNGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private HMPLINEPJOI LHFIJIEMKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly GPACDFNOKNB NBGNFGMCPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FLCFFPMAMPE JAILJBAGKBM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF740", Offset = "0x6FFE340", VA = "0x186FFF740")]
	internal ODCFCHKGELL(GPACDFNOKNB GMBCCEAGHDM, FLCFFPMAMPE CCCPMLIFCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF6A0", Offset = "0x6FFE2A0", VA = "0x186FFF6A0")]
	internal void ECFBMOFMCFE(HMPLINEPJOI KKAHKDEHCEI, int CDAANOBHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF620", Offset = "0x6FFE220", VA = "0x186FFF620")]
	internal void DCLBGBDGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF710", Offset = "0x6FFE310", VA = "0x186FFF710")]
	public void LKOGHFHIGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class FLCFFPMAMPE
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum OKPONGGMHNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public FLCFFPMAMPE FOKPOJPOLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public OKPONGGMHNP JKOHHHGJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public KAEGNCMEHCB OGNKGOMDPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint IAONEEMBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object IDJNJOJICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int EJILPCEPKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError LCNJOLKJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public JMKODDJPIGC INDCNPBKCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public JCFOMECONKL PIJJMILIMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public OKHEPOOFMJN MKBLLJDLEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte BMLGDEDGOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly ODCFCHKGELL MIOOJHBBPGL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBDC0", Offset = "0x6FEA9C0", VA = "0x186FEBDC0")]
	public FLCFFPMAMPE(GPACDFNOKNB GMBCCEAGHDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GPACDFNOKNB : IEnumerable<KAEGNCMEHCB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class KBFICNMLLPF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB4D0", Offset = "0x6FFA0D0", VA = "0x186FFB4D0", Slot = "4")]
		public bool Equals(IPEndPoint KFGAJBKADFK, IPEndPoint FEABMDLFEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x42EAA30", Offset = "0x42E9630", VA = "0x1842EAA30", Slot = "5")]
		public int GetHashCode(IPEndPoint KDKJDFFGNJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KBFICNMLLPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PNEGHDGMFLO : IEnumerator<KAEGNCMEHCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly KAEGNCMEHCB HKNALGBMEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private KAEGNCMEHCB FFNIDGAPNFE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KAEGNCMEHCB FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1B70AE0", Offset = "0x1B6F6E0", VA = "0x181B70AE0")]
		public PNEGHDGMFLO(KAEGNCMEHCB MBEDIGACNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7000B40", Offset = "0x6FFF740", VA = "0x187000B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7000B90", Offset = "0x6FFF790", VA = "0x187000B90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread PIEMEPPOPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool KHOCLEGODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool MNFMAIDFNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CEOMMLEAOJI BELBLHOEFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent FPKHLNIHGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<FLCFFPMAMPE> NIOPJPPEAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<FLCFFPMAMPE> CBPBNJBAGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private FLCFFPMAMPE FKABMPABPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PHPJBBAGKMF DHALHBKDPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly OADCNDAKALP FKPIBMLHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly LNFDCJKJPDP EPMLFIOMEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly EPPKICKBPHB LBIOFBOPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, KAEGNCMEHCB> FDBPHDMAPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, JCFOMECONKL> EMEAKBLBDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, CMMGDONKDMB> EMAPNABOLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim PMLEPFPNPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private KAEGNCMEHCB PKFOAJMJBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int LDPLGBIDFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<KAEGNCMEHCB> GAOMBOLHGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private KAEGNCMEHCB[] AINDAOBJDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly APDNDEEGOJL AFLDMDMCCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int GFMMKLMOMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> PNEBPEPPPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte HLEKHMAFGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object HKMGPNLACDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BNOBNDBCEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool LGGELPDGHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NKLJEEJIIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BFCALEDAPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int IHIKEEMEEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int NGLGBDOIBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KLDOPEFEMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool IOJMINBKAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JFHNFEMEMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int DKPHOOJKFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int GCCDKBCANOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool JFJKNJOLKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HNMLMLAPMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool PCECFLGJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool NAPMIMIPADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int HBFMNGAHJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int MFFDBPPFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool CGJCIOIJJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly AHJIJJJEGME IODDJCCJLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool JDAJAHIGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly OCIHMPBCCKL LNPKEBEBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool HIGCDHNNEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public IJCAAMAFGHD KJOJJPFLDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int HFALHLLJDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool HNGPAGDGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool BDJFLKFFKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool HHEEIKNHBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool LLGABLAMPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HMPLINEPJOI IEKLKLJLOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int EOPEHODMLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object HELHIPENBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private HMPLINEPJOI CNNBNIJLKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int NIMCOOLGIMP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int JLLCKKNEHKD = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int KCGAJMDBHNL = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private MNOCKIBOFGI BJJCDAFPHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private MNOCKIBOFGI ANNDCHMMEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread PPLMIJJJMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread JOIHCIKBPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint HCIKGKHNKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint IBLHBNIMEOC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] GMMIMPEBCJM;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] LCHFNAMEGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<KKCCMADHNEJ, IPEndPoint> HFONLIDGOEI;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress CNCBHHOCKDL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool PPMEOBBEPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int HDEKPEOIBOH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KDMKLIMPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB45EB0", Offset = "0xB44AB0", VA = "0x180B45EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB479D0", Offset = "0xB465D0", VA = "0x180B479D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LFEBBICDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x16BA5F0", Offset = "0x16B91F0", VA = "0x1816BA5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x210A1A0", Offset = "0x2108DA0", VA = "0x18210A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte AFFJIDPDCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xFB2090", Offset = "0xFB0C90", VA = "0x180FB2090")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NALHEENOFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDB90", Offset = "0x6FEC790", VA = "0x186FEDB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short PDDMMGHIHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2870", Offset = "0x6FF1470", VA = "0x186FF2870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KAEGNCMEHCB.GAHOCMGKMDN NFNLMCAPCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2A80", Offset = "0x6FF1680", VA = "0x186FF2A80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2970", Offset = "0x6FF1570", VA = "0x186FF2970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1C40", Offset = "0x6FF0840", VA = "0x186FF1C40")]
	public void LNLLEBPHMMI(IPEndPoint FKNLGOMGPIA, byte[] MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6FF26D0", Offset = "0x6FF12D0", VA = "0x186FF26D0")]
	public void MLLGHGPPOEB(IPEndPoint FKNLGOMGPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2E00", Offset = "0x6FF1A00", VA = "0x186FF2E00")]
	private bool OKPFKMHHGIP(IPEndPoint FKNLGOMGPIA, [Out] KAEGNCMEHCB HBIMLLJMPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC80", Offset = "0x6FED880", VA = "0x186FEEC80")]
	private void HFHANEALKDK(KAEGNCMEHCB HBIMLLJMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC20", Offset = "0x6FED820", VA = "0x186FEEC20")]
	private void GKEHNJCFJPB(KAEGNCMEHCB HBIMLLJMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2B30", Offset = "0x6FF1730", VA = "0x186FF2B30")]
	private void OKJPJOLDOGD(KAEGNCMEHCB HBIMLLJMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3960", Offset = "0x6FF2560", VA = "0x186FF3960")]
	public GPACDFNOKNB(PHPJBBAGKMF PEGKFBCABCL, [Optional] APDNDEEGOJL LHLLEOMJDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2120", Offset = "0x6FF0D20", VA = "0x186FF2120")]
	internal void MBOBNEGFHNA(KAEGNCMEHCB LLDLIMPNOMK, int GHDGEKIIHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2820", Offset = "0x6FF1420", VA = "0x186FF2820")]
	internal void MNAIDOJBKBH(KAEGNCMEHCB LLDLIMPNOMK, object GJJLHHDMOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2930", Offset = "0x6FF1530", VA = "0x186FF2930")]
	internal void MPBMDPBKHJI(KAEGNCMEHCB HBIMLLJMPAF, JMKODDJPIGC HGJBCNEJGLD, SocketError PAKFEIAOJOB, HMPLINEPJOI AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC910", Offset = "0x6FEB510", VA = "0x186FEC910")]
	private void BIHLAENKBMO(KAEGNCMEHCB HBIMLLJMPAF, JMKODDJPIGC HGJBCNEJGLD, SocketError PAKFEIAOJOB, bool JMDCPKFBLOI, byte[] PEDMEJIDLNB, int EILAIOEPAPK, int DPOOEAFKIHD, HMPLINEPJOI AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF22F0", Offset = "0x6FF0EF0", VA = "0x186FF22F0")]
	private void MJLFKDHNKMJ(FLCFFPMAMPE.OKPONGGMHNP OPOPAMPKKGD, [Optional] KAEGNCMEHCB HBIMLLJMPAF, [Optional] IPEndPoint NFMNGDEHOOH, SocketError ECHOOMPBJHE = SocketError.Success, int GHDGEKIIHBK = 0, JMKODDJPIGC BBLMBHCGAAD = JMKODDJPIGC.ConnectionFailed, [Optional] JCFOMECONKL DIAJAIMCMEO, OKHEPOOFMJN BBHELNKHCAL = OKHEPOOFMJN.Unreliable, byte LAGHNKAFMPJ = 0, [Optional] HMPLINEPJOI FFKJEOIOEDJ, [Optional] object GJJLHHDMOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2EA0", Offset = "0x6FF1AA0", VA = "0x186FF2EA0")]
	private void OLCJFHHOPPA(FLCFFPMAMPE CCCPMLIFCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3670", Offset = "0x6FF2270", VA = "0x186FF3670")]
	internal void PNGHOAKJIBL(FLCFFPMAMPE CCCPMLIFCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDBB0", Offset = "0x6FEC7B0", VA = "0x186FEDBB0")]
	private void FCKMAACKJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE520", Offset = "0x6FED120", VA = "0x186FEE520")]
	private void GBMMIEKOGDJ(int KPNCBGKAIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF00", Offset = "0x6FECB00", VA = "0x186FEDF00")]
	internal KAEGNCMEHCB GADDCBKJIMG(JCFOMECONKL BJAGJMJPKHA, byte[] HMEFEPAAFAG, int EILAIOEPAPK, int FMOIHNPEKPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1310", Offset = "0x6FEFF10", VA = "0x186FF1310")]
	private int KLADCBEFGGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FF15D0", Offset = "0x6FF01D0", VA = "0x186FF15D0")]
	private void LGFCHKHBECO(IPEndPoint NFMNGDEHOOH, KAEGNCMEHCB FOGAPJPBEKP, PLLECAOFDLK KDPDBGBLMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FEFD90", Offset = "0x6FEE990", VA = "0x186FEFD90")]
	private void KIEHJILHKBC(HMPLINEPJOI KKAHKDEHCEI, IPEndPoint NFMNGDEHOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6FED090", Offset = "0x6FEBC90", VA = "0x186FED090")]
	internal void DIDBMGIPFEB(HMPLINEPJOI KKAHKDEHCEI, OKHEPOOFMJN JHBFLLOMAIH, byte LAGHNKAFMPJ, int CDAANOBHILI, KAEGNCMEHCB LLDLIMPNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF540", Offset = "0x6FEE140", VA = "0x186FEF540")]
	public bool KDHJHGHKFGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF5B0", Offset = "0x6FEE1B0", VA = "0x186FEF5B0")]
	public bool KDHJHGHKFGC(IPAddress LNHKFNKNPCJ, IPAddress ELALHPFLLLH, int KBGHICMAIBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF4C0", Offset = "0x6FEE0C0", VA = "0x186FEF4C0")]
	public bool KDHJHGHKFGC(int KBGHICMAIBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1160", Offset = "0x6FEFD60", VA = "0x186FF1160")]
	public void KIOMNFDHKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBFC0", Offset = "0x6FEABC0", VA = "0x186FEBFC0")]
	public KAEGNCMEHCB ABFPHFHKACH(string JOABIEDGONG, int KBGHICMAIBF, string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC0A0", Offset = "0x6FEACA0", VA = "0x186FEC0A0")]
	public KAEGNCMEHCB ABFPHFHKACH(string JOABIEDGONG, int KBGHICMAIBF, PEECOIMOPMN GMBGIBBBBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC180", Offset = "0x6FEAD80", VA = "0x186FEC180")]
	public KAEGNCMEHCB ABFPHFHKACH(IPEndPoint MDKAAPLMLKG, PEECOIMOPMN GMBGIBBBBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6FECD20", Offset = "0x6FEB920", VA = "0x186FECD20")]
	public void DABNHEKODGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6FECD30", Offset = "0x6FEB930", VA = "0x186FECD30")]
	public void DABNHEKODGF(bool LEHHJNJJBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC710", Offset = "0x6FEB310", VA = "0x186FEC710")]
	public void BGJAKKNCDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC7C0", Offset = "0x6FEB3C0", VA = "0x186FEC7C0")]
	public void BGJAKKNCDDM(byte[] PEDMEJIDLNB, int EILAIOEPAPK, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC890", Offset = "0x6FEB490", VA = "0x186FEC890")]
	public void BIHLAENKBMO(KAEGNCMEHCB HBIMLLJMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC8D0", Offset = "0x6FEB4D0", VA = "0x186FEC8D0")]
	public void BIHLAENKBMO(KAEGNCMEHCB HBIMLLJMPAF, byte[] PEDMEJIDLNB, int EILAIOEPAPK, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3780", Offset = "0x6FF2380", VA = "0x186FF3780", Slot = "4")]
	private IEnumerator<KAEGNCMEHCB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3810", Offset = "0x6FF2410", VA = "0x186FF3810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1B60", Offset = "0x6FF0760", VA = "0x186FF1B60")]
	private HMPLINEPJOI LIGEDBHICHE(DMFCKHGCLIL NMCGBFDKCMK, int DKFJGBGJGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1A80", Offset = "0x6FF0680", VA = "0x186FF1A80")]
	private HMPLINEPJOI LIGEDBHICHE(DMFCKHGCLIL NMCGBFDKCMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1390", Offset = "0x6FEFF90", VA = "0x186FF1390")]
	internal HMPLINEPJOI LBFBFMOGKDL(int DKFJGBGJGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE840", Offset = "0x6FED440", VA = "0x186FEE840")]
	internal void GJGEEOPPANP(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6FF38A0", Offset = "0x6FF24A0", VA = "0x186FF38A0")]
	static GPACDFNOKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB45EB0", Offset = "0xB44AB0", VA = "0x180B45EB0")]
	private bool LMKOJHJBBGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2170", Offset = "0x6FF0D70", VA = "0x186FF2170")]
	private void MCNLKJPIMNH(IPEndPoint KCJMDHFFKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF360", Offset = "0x6FEDF60", VA = "0x186FEF360")]
	private void JGMNIAEHDJD(IPEndPoint KCJMDHFFKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC560", Offset = "0x6FEB160", VA = "0x186FEC560")]
	private bool BBBKOLPOPFL(SocketException DFLKFAIHDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF340", Offset = "0x6FEDF40", VA = "0x186FEF340")]
	private void INEDKNLFNOD(CEOMMLEAOJI DFJFKOOJMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1E60", Offset = "0x6FF0A60", VA = "0x186FF1E60")]
	private void LPJHNNIEBFE(MNOCKIBOFGI DFJFKOOJMLF, EndPoint ABMMGBCPLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEFC0", Offset = "0x6FEDBC0", VA = "0x186FEEFC0")]
	private void IMGOJLMDDDM(object DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF5D0", Offset = "0x6FEE1D0", VA = "0x186FEF5D0")]
	public bool KDHJHGHKFGC(IPAddress LNHKFNKNPCJ, IPAddress ELALHPFLLLH, int KBGHICMAIBF, bool HICJNJDALDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2A20", Offset = "0x6FF1620", VA = "0x186FF2A20")]
	internal int NMFFLLOGCLK(HMPLINEPJOI KKAHKDEHCEI, IPEndPoint NFMNGDEHOOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDB50", Offset = "0x6FEC750", VA = "0x186FEDB50")]
	internal int ELHCCOFNJJC(HMPLINEPJOI KKAHKDEHCEI, IPEndPoint NFMNGDEHOOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FED370", Offset = "0x6FEBF70", VA = "0x186FED370")]
	internal int ELHCCOFNJJC(byte[] FNFIPKNHEOF, int EILAIOEPAPK, int FMOIHNPEKPL, IPEndPoint NFMNGDEHOOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEAA0", Offset = "0x6FED6A0", VA = "0x186FEEAA0")]
	internal void GKDLAGPNEJJ(bool FNCFHBDAABH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum DMFCKHGCLIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class HMPLINEPJOI
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int CIEIIOMHJNK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] FIFPEMGPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] PIFDNJHAEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int LEKJCANHPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object IDJNJOJICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public HMPLINEPJOI FOKPOJPOLHO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DMFCKHGCLIL FFIINAPJLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5460", Offset = "0x6FF4060", VA = "0x186FF5460")]
		get
		{
			return default(DMFCKHGCLIL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5490", Offset = "0x6FF4090", VA = "0x186FF5490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte APJIDEMHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5500", Offset = "0x6FF4100", VA = "0x186FF5500")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF55A0", Offset = "0x6FF41A0", VA = "0x186FF55A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort FOIGKPPDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5230", Offset = "0x6FF3E30", VA = "0x186FF5230")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5610", Offset = "0x6FF4210", VA = "0x186FF5610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DPAJBDFLGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF54D0", Offset = "0x6FF40D0", VA = "0x186FF54D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte ENNGMBOGNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF55E0", Offset = "0x6FF41E0", VA = "0x186FF55E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5430", Offset = "0x6FF4030", VA = "0x186FF5430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PDPDMCPICAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5650", Offset = "0x6FF4250", VA = "0x186FF5650")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF51F0", Offset = "0x6FF3DF0", VA = "0x186FF51F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort OEPICJILFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5390", Offset = "0x6FF3F90", VA = "0x186FF5390")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF53F0", Offset = "0x6FF3FF0", VA = "0x186FF53F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort CCDPBONJNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5090", Offset = "0x6FF3C90", VA = "0x186FF5090")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5530", Offset = "0x6FF4130", VA = "0x186FF5530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF56B0", Offset = "0x6FF42B0", VA = "0x186FF56B0")]
	static HMPLINEPJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5570", Offset = "0x6FF4170", VA = "0x186FF5570")]
	public void MNMEJENAANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5970", Offset = "0x6FF4570", VA = "0x186FF5970")]
	public HMPLINEPJOI(int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF59E0", Offset = "0x6FF45E0", VA = "0x186FF59E0")]
	public HMPLINEPJOI(DMFCKHGCLIL NMCGBFDKCMK, int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF50F0", Offset = "0x6FF3CF0", VA = "0x186FF50F0")]
	public static int CDKICJIPGAM(DMFCKHGCLIL NMCGBFDKCMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5160", Offset = "0x6FF3D60", VA = "0x186FF5160")]
	public int CDKICJIPGAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5290", Offset = "0x6FF3E90", VA = "0x186FF5290")]
	public bool EBMEMKHCFPC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum IJDKCJLIHDC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum CDKLLDIKNNA
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum NLMFPPFOKID
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum BOCJACEFJLD
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KAEGNCMEHCB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MEOJPEFFOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public HMPLINEPJOI[] GNOFJGOAKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int IMEFMIHABHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int HIEEDMKGOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte ENNGMBOGNDF;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MEOJPEFFOBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void GAHOCMGKMDN(ulong LJKBAJGEHMG, int CCPCBEPJGKF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int HEHOBPKKLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int LFNBANHJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int BLDPNNABIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double DBOHHBILEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int ENCHDLFOPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int HBBMGOPCILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int EJAPFMDGMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch KJMCOECJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int MALAOJDLBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long KAOGKDCNFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object JMEIOIPCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal KAEGNCMEHCB OKPDAFMGPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal KAEGNCMEHCB ANJBOMACBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<HMPLINEPJOI> DLPMOFBBBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<KNOOFHJLCEF> IPOPDLCBPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly KNOOFHJLCEF[] CNJGAJIILAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int BNCKPNFIDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int IGGEAANADEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool IKIHGMFNAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int OGPHPEGLOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int KABBEODJCHF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int JNDOFCBOHCE = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int GCNBJOAHAJA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object ANPGNOPFEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IIMJPDGPHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, MEOJPEFFOBG> BDLEFMAHFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> HOLCAHBPIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly HMPLINEPJOI GKLLNFMNGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BEFHHCAMBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int KHNOJAPCOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint GCOONMDJLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int BFAFICGNJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int BOOBJCNNCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long LCKBLJBOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte CHGDJOMLEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private IJDKCJLIHDC DICFCHPFLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private HMPLINEPJOI MKINFIDIPNN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int LJNHDPHKDNL = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int HHPMKIJDAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly HMPLINEPJOI HBPCBOFIOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly HMPLINEPJOI IDNOFDIOIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly HMPLINEPJOI FLCEOKONGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly HMPLINEPJOI DDFAAKDJKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private BNCNBOMJDKK DJOBHNDFLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly GPACDFNOKNB BGHJGLFBKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int PAAINMNNDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object MOELDIBJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly AHJIJJJEGME IODDJCCJLEK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte GOEJPKEADAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9A2C0", Offset = "0xA98EC0", VA = "0x180A9A2C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF75A0", Offset = "0x6FF61A0", VA = "0x186FF75A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint AFCKKFFBPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0D0", Offset = "0xA98CD0", VA = "0x180A9A0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IJDKCJLIHDC AKHKFEAHMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA9A090", Offset = "0xA98C90", VA = "0x180A9A090")]
		get
		{
			return default(IJDKCJLIHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long KENJOFGBBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2A510", Offset = "0xA29110", VA = "0x180A2A510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DHNAEGDIENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x16BA5F0", Offset = "0x16B91F0", VA = "0x1816BA5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x210A1A0", Offset = "0x2108DA0", VA = "0x18210A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EFNBJCCMEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8080", Offset = "0x6FF6C80", VA = "0x186FF8080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int LLLAEGPKBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC96C30", Offset = "0xC95830", VA = "0x180C96C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double CPBBMKOJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x51FE9B0", Offset = "0x51FD5B0", VA = "0x1851FE9B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GAHOCMGKMDN NFNLMCAPCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAC10", Offset = "0x6FF9810", VA = "0x186FFAC10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9B10", Offset = "0x6FF8710", VA = "0x186FF9B10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB080", Offset = "0x6FF9C80", VA = "0x186FFB080")]
	internal KAEGNCMEHCB(GPACDFNOKNB FLNIMFPPELG, IPEndPoint NFMNGDEHOOH, int ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9AF0", Offset = "0x6FF86F0", VA = "0x186FF9AF0")]
	internal void MIDHCKNGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9AC0", Offset = "0x6FF86C0", VA = "0x186FF9AC0")]
	internal void MGIDLPPLCGP(IPEndPoint GHMDLIAOPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8E60", Offset = "0x6FF7A60", VA = "0x186FF8E60")]
	internal void JDGNGDEFMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8D90", Offset = "0x6FF7990", VA = "0x186FF8D90")]
	private void JBHPPIALAAI(int EKKDIACILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8C70", Offset = "0x6FF7870", VA = "0x186FF8C70")]
	private void IIIIFCHFFBE(int LDCNIELFALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7290", Offset = "0x6FF5E90", VA = "0x186FF7290")]
	public int BEDNMAINNAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7170", Offset = "0x6FF5D70", VA = "0x186FF7170")]
	public int BEDNMAINNAK(byte LAGHNKAFMPJ, bool OMODBFEALBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8AC0", Offset = "0x6FF76C0", VA = "0x186FF8AC0")]
	private KNOOFHJLCEF IEDFGFOBKGL(byte IFAMDLCCFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAEF0", Offset = "0x6FF9AF0", VA = "0x186FFAEF0")]
	internal KAEGNCMEHCB(GPACDFNOKNB FLNIMFPPELG, IPEndPoint NFMNGDEHOOH, int ALPNKEJICNA, byte HNFGAPOAKHO, PEECOIMOPMN OLGMDLALGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD10", Offset = "0x6FF9910", VA = "0x186FFAD10")]
	internal KAEGNCMEHCB(GPACDFNOKNB FLNIMFPPELG, JCFOMECONKL BJAGJMJPKHA, int ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9A70", Offset = "0x6FF8670", VA = "0x186FF9A70")]
	internal void MFHKAEEHFLC(PLLECAOFDLK BIJCJLPNIFK, byte[] PEDMEJIDLNB, int EILAIOEPAPK, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7680", Offset = "0x6FF6280", VA = "0x186FF7680")]
	internal bool EGAOFEKNOBI(BBHPADEKNEL KKAHKDEHCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7650", Offset = "0x6FF6250", VA = "0x186FF7650")]
	public void CJJJNINAOAN(byte[] PEDMEJIDLNB, int EILAIOEPAPK, int FMOIHNPEKPL, OKHEPOOFMJN LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7760", Offset = "0x6FF6360", VA = "0x186FF7760")]
	private void GDDNDBEFINL(byte[] PEDMEJIDLNB, int EILAIOEPAPK, int FMOIHNPEKPL, byte LAGHNKAFMPJ, OKHEPOOFMJN BBHELNKHCAL, object GJJLHHDMOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFACC0", Offset = "0x6FF98C0", VA = "0x186FFACC0")]
	public void PNOPLHJACOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8CB0", Offset = "0x6FF78B0", VA = "0x186FF8CB0")]
	internal NLMFPPFOKID INMOLHJBPEP(HMPLINEPJOI KKAHKDEHCEI)
	{
		return default(NLMFPPFOKID);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7700", Offset = "0x6FF6300", VA = "0x186FF7700")]
	internal void EKLFKMHPMIO(KNOOFHJLCEF NLILDHLPHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7D70", Offset = "0x6FF6970", VA = "0x186FF7D70")]
	internal BOCJACEFJLD HDGGKGECLNF(byte[] PEDMEJIDLNB, int EILAIOEPAPK, int FMOIHNPEKPL, bool JMDCPKFBLOI)
	{
		return default(BOCJACEFJLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9A30", Offset = "0x6FF8630", VA = "0x186FF9A30")]
	private void MDBJDACPKBA(int GJIJIMNBOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA280", Offset = "0x6FF8E80", VA = "0x186FFA280")]
	internal void ODEDNHIJJLE(OKHEPOOFMJN JHBFLLOMAIH, HMPLINEPJOI MBEDIGACNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8570", Offset = "0x6FF7170", VA = "0x186FF8570")]
	private void IBKPPLLIBPL(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF81E0", Offset = "0x6FF6DE0", VA = "0x186FF81E0")]
	private void HPGNAOCBMJH(int DJGAODFCDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8EF0", Offset = "0x6FF7AF0", VA = "0x186FF8EF0")]
	internal CDKLLDIKNNA LGFCHKHBECO(PLLECAOFDLK KDPDBGBLMCI)
	{
		return default(CDKLLDIKNNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9370", Offset = "0x6FF7F70", VA = "0x186FF9370")]
	internal void MBLLPCCNDIE(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8090", Offset = "0x6FF6C90", VA = "0x186FF8090")]
	private void HOGLADEONLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF73A0", Offset = "0x6FF5FA0", VA = "0x186FF73A0")]
	internal void CAALJGPBLBI(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9BC0", Offset = "0x6FF87C0", VA = "0x186FF9BC0")]
	internal void NJCBLGMIGNH(int DJGAODFCDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF90B0", Offset = "0x6FF7CB0", VA = "0x186FF90B0")]
	internal void LKDKPJNHKPM(HMPLINEPJOI KKAHKDEHCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class AHJIJJJEGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long LKPHIBCAFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long KCHLOHJFHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long BEILIIMIOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long ALIJHPONHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long JPKNKBJCKNA;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long KDPDODOBOCI;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long IKFJAAOPKHC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long GIAPLIMENDJ;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long NNAFHCEIPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long HDEHHNFELNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long ABGPEAGEOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long PCCNLANEFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long GMFIGAEHHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8C20", Offset = "0x6FE7820", VA = "0x186FE8C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EKJIJJDJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8BA0", Offset = "0x6FE77A0", VA = "0x186FE8BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long IPOEIKDBPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8D30", Offset = "0x6FE7930", VA = "0x186FE8D30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NADIEGEBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8B80", Offset = "0x6FE7780", VA = "0x186FE8B80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long MKHJFPGOLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8B90", Offset = "0x6FE7790", VA = "0x186FE8B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long AJDIDFDLBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8E30", Offset = "0x6FE7A30", VA = "0x186FE8E30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long LBHHGHEPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8CF0", Offset = "0x6FE78F0", VA = "0x186FE8CF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long MPMCMBLKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8EB0", Offset = "0x6FE7AB0", VA = "0x186FE8EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private BNCNBOMJDKK BAPINHPKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8BB0", Offset = "0x6FE77B0", VA = "0x186FE8BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double JCHIAJLCGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8C90", Offset = "0x6FE7890", VA = "0x186FE8C90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8DF0", Offset = "0x6FE79F0", VA = "0x186FE8DF0")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8D90", Offset = "0x6FE7990", VA = "0x186FE8D90")]
	public void NCFMEPCFJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8D40", Offset = "0x6FE7940", VA = "0x186FE8D40")]
	public void LNLACGHCJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8BC0", Offset = "0x6FE77C0", VA = "0x186FE8BC0")]
	public void EIECMFGLGCO(long KHDFAKKDEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8EF0", Offset = "0x6FE7AF0", VA = "0x186FE8EF0")]
	public void ODMKOKIEPGF(long GHMFEHDCCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8C30", Offset = "0x6FE7830", VA = "0x186FE8C30")]
	public void KFGMHBMCACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8E40", Offset = "0x6FE7A40", VA = "0x186FE8E40")]
	public void NNANAIDNKAM(long DPAEPFAFDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8FF0", Offset = "0x6FE7BF0", VA = "0x186FE8FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8F50", Offset = "0x6FE7B50", VA = "0x186FE8F50")]
	public void PGOBBNNEAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public AHJIJJJEGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CPIFPLFHHGH
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> APMKCLLPJJM;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAC90", Offset = "0x6FE9890", VA = "0x186FEAC90")]
	public static IPEndPoint FECBINFJNIN(string MMHNGKFHJGJ, int KBGHICMAIBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF70", Offset = "0x6FE9B70", VA = "0x186FEAF70")]
	public static IPAddress JLDAKMOLNNA(string MMHNGKFHJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAEE0", Offset = "0x6FE9AE0", VA = "0x186FEAEE0")]
	public static IPAddress JLDAKMOLNNA(string MMHNGKFHJGJ, AddressFamily LJNIMOMCPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB140", Offset = "0x6FE9D40", VA = "0x186FEB140")]
	internal static int KEEHBMHAJNA(int CKKOCCIOHBG, int NDMHPENFPCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x38AE2D0", Offset = "0x38ACED0", VA = "0x1838AE2D0")]
	internal static T[] DPJEEIDNPIB<T>(int DPOOEAFKIHD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HGCHDFMKBJM : KNOOFHJLCEF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct HOPKFFDMNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private HMPLINEPJOI LHFIJIEMKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long CACCJCLJHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool GBFJFGAFEBG;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5BD0", Offset = "0x6FF47D0", VA = "0x186FF5BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5AF0", Offset = "0x6FF46F0", VA = "0x186FF5AF0")]
		public void GFFHNKPMBNJ(HMPLINEPJOI KKAHKDEHCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B10", Offset = "0x6FF4710", VA = "0x186FF5B10")]
		public bool HMIDMDKAHOA(long CHNONDHAGOC, KAEGNCMEHCB HBIMLLJMPAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B80", Offset = "0x6FF4780", VA = "0x186FF5B80")]
		public bool ILJKHADAMOK(KAEGNCMEHCB HBIMLLJMPAF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly HMPLINEPJOI CFJBMMBMIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly HOPKFFDMNDL[] BGADNOIIPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly HMPLINEPJOI[] JPAGMLDBBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] ABACIPMIPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int PNHOKNPIPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int GLDMFJLFDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int MBNOCBAONAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int MLNDPJFMJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool PCMOPOJFAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly OKHEPOOFMJN JPAGDCADFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool EJCHKCMKMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int PJBBFHKNCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte EDEKFLIBLLA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PBMKOFLPEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4380", Offset = "0x6FF2F80", VA = "0x186FF4380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4EC0", Offset = "0x6FF3AC0", VA = "0x186FF4EC0")]
	public HGCHDFMKBJM(KAEGNCMEHCB HBIMLLJMPAF, bool OMODBFEALBB, byte ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3FC0", Offset = "0x6FF2BC0", VA = "0x186FF3FC0")]
	private void FLCLDBFGCHN(HMPLINEPJOI KKAHKDEHCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4390", Offset = "0x6FF2F90", VA = "0x186FF4390", Slot = "4")]
	protected override bool JNEHMHPPPOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4860", Offset = "0x6FF3460", VA = "0x186FF4860", Slot = "5")]
	public override bool MBLLPCCNDIE(HMPLINEPJOI KKAHKDEHCEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LIPADHDMGKJ : KNOOFHJLCEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int HKABOECAHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort GLDMFJLFDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool COGEPMGGKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private HMPLINEPJOI CKBEMBMJAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly HMPLINEPJOI CDEOGGOCKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool AIEILFBPFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte EDEKFLIBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long GGAHFHNLKHB;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCEB0", Offset = "0x6FFBAB0", VA = "0x186FFCEB0")]
	public LIPADHDMGKJ(KAEGNCMEHCB HBIMLLJMPAF, bool NOKPILMLOPP, byte ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC710", Offset = "0x6FFB310", VA = "0x186FFC710", Slot = "4")]
	protected override bool JNEHMHPPPOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCBD0", Offset = "0x6FFB7D0", VA = "0x186FFCBD0", Slot = "5")]
	public override bool MBLLPCCNDIE(HMPLINEPJOI KKAHKDEHCEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GBCMADGOOEM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct DIJNJEJPNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong OAKMHOJHMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double OFEPONPIKBP;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct HHLFPJAILIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int AFJDFAOEPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float PPHBCCJFMKN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6FE89F0", Offset = "0x6FE75F0", VA = "0x186FE89F0")]
	private static void FHLCKAPKBDA(byte[] DPMBBHPEMOM, int KPHEINADMCH, ulong PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBEA0", Offset = "0x6FEAAA0", VA = "0x186FEBEA0")]
	private static void FHLCKAPKBDA(byte[] DPMBBHPEMOM, int KPHEINADMCH, int PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE60", Offset = "0x6FEAA60", VA = "0x186FEBE60")]
	public static void FHLCKAPKBDA(byte[] DPMBBHPEMOM, int KPHEINADMCH, short PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF20", Offset = "0x6FEAB20", VA = "0x186FEBF20")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, double OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF40", Offset = "0x6FEAB40", VA = "0x186FEBF40")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE60", Offset = "0x6FEAA60", VA = "0x186FEBE60")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, short OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE60", Offset = "0x6FEAA60", VA = "0x186FEBE60")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, ushort OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBEA0", Offset = "0x6FEAAA0", VA = "0x186FEBEA0")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBEA0", Offset = "0x6FEAAA0", VA = "0x186FEBEA0")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, uint OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF10", Offset = "0x6FEAB10", VA = "0x186FEBF10")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF10", Offset = "0x6FEAB10", VA = "0x186FEBF10")]
	public static void IBECKKLOFIC(byte[] OEOOBGJGDIH, int DPCFFPEBOPM, ulong OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CCLMBIGNGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] DGEOKDEKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int FHDLFLNDEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int BFKJAFPPPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int OEIOBBJBIAL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] PIFDNJHAEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int EIMCMOPCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PLMLPCKDPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA870", Offset = "0x6FE9470", VA = "0x186FEA870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJHEKFLFHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27FB8B0", Offset = "0x27FA4B0", VA = "0x1827FB8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DLIOHMMIFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA820", Offset = "0x6FE9420", VA = "0x186FEA820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA1B0", Offset = "0x6FE8DB0", VA = "0x186FEA1B0")]
	public void ECFBMOFMCFE(byte[] GBEGHJIHKEG, int KPHEINADMCH, int PHONMCNKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CCLMBIGNGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAB30", Offset = "0x6FE9730", VA = "0x186FEAB30")]
	public CCLMBIGNGDK(byte[] GBEGHJIHKEG, int KPHEINADMCH, int PHONMCNKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0E0", Offset = "0x6FE8CE0", VA = "0x186FEA0E0")]
	public IPEndPoint EBMEHHJJBOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA230", Offset = "0x6FE8E30", VA = "0x186FEA230")]
	public byte GOFCOOPFKOF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA230", Offset = "0x6FE8E30", VA = "0x186FEA230")]
	public sbyte EJLOAJPMLEJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3894DA0", Offset = "0x38939A0", VA = "0x183894DA0")]
	public T[] MCAPACKHMAE<T>(ushort DKFJGBGJGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA060", Offset = "0x6FE8C60", VA = "0x186FEA060")]
	public bool[] CPLOMPHDFPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAA80", Offset = "0x6FE9680", VA = "0x186FEAA80")]
	public ushort[] NPDLFECMPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9FB0", Offset = "0x6FE8BB0", VA = "0x186FE9FB0")]
	public short[] CGIHEFDOFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA1F0", Offset = "0x6FE8DF0", VA = "0x186FEA1F0")]
	public int[] EHLJPNFIGFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA2E0", Offset = "0x6FE8EE0", VA = "0x186FEA2E0")]
	public uint[] GEFONGHJLNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA7E0", Offset = "0x6FE93E0", VA = "0x186FEA7E0")]
	public float[] KJCFHEFEAEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAA40", Offset = "0x6FE9640", VA = "0x186FEAA40")]
	public double[] NNJDOCEPHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA320", Offset = "0x6FE8F20", VA = "0x186FEA320")]
	public long[] GHOBIBJLENP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9F70", Offset = "0x6FE8B70", VA = "0x186FE9F70")]
	public ulong[] AMHPIDJDJEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA880", Offset = "0x6FE9480", VA = "0x186FEA880")]
	public string[] MJHEODPAHCF(int NDIDAIAJHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9F30", Offset = "0x6FE8B30", VA = "0x186FE9F30")]
	public bool ACNGCKDNHMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA3D0", Offset = "0x6FE8FD0", VA = "0x186FEA3D0")]
	public char MPOBLMMAKPC()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA3D0", Offset = "0x6FE8FD0", VA = "0x186FEA3D0")]
	public ushort HNGOMCCANND()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA270", Offset = "0x6FE8E70", VA = "0x186FEA270")]
	public short FLLJJGEPDKK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAAC0", Offset = "0x6FE96C0", VA = "0x186FEAAC0")]
	public long OOCMDGNGBNN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA440", Offset = "0x6FE9040", VA = "0x186FEA440")]
	public ulong IFAJIJJBLIG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA770", Offset = "0x6FE9370", VA = "0x186FEA770")]
	public int KAGOMEGHHGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA700", Offset = "0x6FE9300", VA = "0x186FEA700")]
	public uint JOKFLCONONC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9FF0", Offset = "0x6FE8BF0", VA = "0x186FE9FF0")]
	public float COGGEGPPMHD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA9D0", Offset = "0x6FE95D0", VA = "0x186FEA9D0")]
	public double NCOAPALFMIN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA4D0", Offset = "0x6FE90D0", VA = "0x186FEA4D0")]
	public string JIKNCHCLKGE(int CHEPOIJLLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA360", Offset = "0x6FE8F60", VA = "0x186FEA360")]
	public ArraySegment<byte> GMIJMGOAIDM(int DPOOEAFKIHD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0A0", Offset = "0x6FE8CA0", VA = "0x186FEA0A0")]
	public sbyte[] CPPNDAOICNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA830", Offset = "0x6FE9430", VA = "0x186FEA830")]
	public byte[] LFJFGGNPLGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA4B0", Offset = "0x6FE90B0", VA = "0x186FEA4B0")]
	public void ILJKHADAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PEECOIMOPMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] DGEOKDEKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int FHDLFLNDEPI;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int DBCADFNDPGH = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool IDDBONEDEFB;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding FBOMENKLEFP;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int HPHMMNKMJJC = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] GBFDACOIKGG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] PBCJADGOGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int COFHLHAAMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7000550", Offset = "0x6FFF150", VA = "0x187000550")]
	public PEECOIMOPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x70005D0", Offset = "0x6FFF1D0", VA = "0x1870005D0")]
	public PEECOIMOPMN(bool BBGFMEMDBMK, int HELGDKGLAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7000010", Offset = "0x6FFEC10", VA = "0x187000010")]
	public static PEECOIMOPMN LCCEDDHEGGF(string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF830", Offset = "0x6FFE430", VA = "0x186FFF830")]
	public void CEDIMIMGFIO(int ICICAMAEDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2874F50", Offset = "0x2873B50", VA = "0x182874F50")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFA10", Offset = "0x6FFE610", VA = "0x186FFFA10")]
	public void ECKMJMPEBHC(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFEE0", Offset = "0x6FFEAE0", VA = "0x186FFFEE0")]
	public void ECKMJMPEBHC(double OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFAC0", Offset = "0x6FFE6C0", VA = "0x186FFFAC0")]
	public void ECKMJMPEBHC(long OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFAC0", Offset = "0x6FFE6C0", VA = "0x186FFFAC0")]
	public void ECKMJMPEBHC(ulong OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFBE0", Offset = "0x6FFE7E0", VA = "0x186FFFBE0")]
	public void ECKMJMPEBHC(int OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFBE0", Offset = "0x6FFE7E0", VA = "0x186FFFBE0")]
	public void ECKMJMPEBHC(uint OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF9A0", Offset = "0x6FFE5A0", VA = "0x186FFF9A0")]
	public void ECKMJMPEBHC(char OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF9A0", Offset = "0x6FFE5A0", VA = "0x186FFF9A0")]
	public void ECKMJMPEBHC(ushort OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF9A0", Offset = "0x6FFE5A0", VA = "0x186FFF9A0")]
	public void ECKMJMPEBHC(short OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF940", Offset = "0x6FFE540", VA = "0x186FFF940")]
	public void ECKMJMPEBHC(sbyte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF940", Offset = "0x6FFE540", VA = "0x186FFF940")]
	public void ECKMJMPEBHC(byte OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF8D0", Offset = "0x6FFE4D0", VA = "0x186FFF8D0")]
	public void ECKMJMPEBHC(byte[] PEDMEJIDLNB, int KPHEINADMCH, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFF30", Offset = "0x6FFEB30", VA = "0x186FFFF30")]
	public void LHLDILJLDNM(sbyte[] PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFF30", Offset = "0x6FFEB30", VA = "0x186FFFF30")]
	public void HLPDIDECLNL(byte[] PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFC70", Offset = "0x6FFE870", VA = "0x186FFFC70")]
	public void ECKMJMPEBHC(bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7000160", Offset = "0x6FFED60", VA = "0x187000160")]
	public void OJILKLPPAAK(Array FDMCBAIJLPI, int FCKKNAJNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7000080", Offset = "0x6FFEC80", VA = "0x187000080")]
	public void OJILKLPPAAK(float[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7000240", Offset = "0x6FFEE40", VA = "0x187000240")]
	public void OJILKLPPAAK(double[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7000240", Offset = "0x6FFEE40", VA = "0x187000240")]
	public void OJILKLPPAAK(long[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7000240", Offset = "0x6FFEE40", VA = "0x187000240")]
	public void OJILKLPPAAK(ulong[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7000080", Offset = "0x6FFEC80", VA = "0x187000080")]
	public void OJILKLPPAAK(int[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7000080", Offset = "0x6FFEC80", VA = "0x187000080")]
	public void OJILKLPPAAK(uint[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7000320", Offset = "0x6FFEF20", VA = "0x187000320")]
	public void OJILKLPPAAK(ushort[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7000320", Offset = "0x6FFEF20", VA = "0x187000320")]
	public void OJILKLPPAAK(short[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFF30", Offset = "0x6FFEB30", VA = "0x186FFFF30")]
	public void OJILKLPPAAK(bool[] OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7000400", Offset = "0x6FFF000", VA = "0x187000400")]
	public void OJILKLPPAAK(string[] OOHGFGHCOAJ, int NNIKNNAAPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFB10", Offset = "0x6FFE710", VA = "0x186FFFB10")]
	public void ECKMJMPEBHC(IPEndPoint FKNLGOMGPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFAB0", Offset = "0x6FFE6B0", VA = "0x186FFFAB0")]
	public void ECKMJMPEBHC(string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFCD0", Offset = "0x6FFE8D0", VA = "0x186FFFCD0")]
	public void ECKMJMPEBHC(string OOHGFGHCOAJ, int CHEPOIJLLIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class LCLFBOIFPHL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class EHHNAAHPCGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong PAAINMNNDIB;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x472C9F0", Offset = "0x472B5F0", VA = "0x18472C9F0")]
		static EHHNAAHPCGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void AIJPMDNMNDA(CCLMBIGNGDK EENAIFHJAJK, object GJJLHHDMOLL);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IKENDOIIMGF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public LCLFBOIFPHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IKENDOIIMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D2C0", Offset = "0x4E7BEC0", VA = "0x184E7D2C0")]
		internal void IPGINMFGLBF(CCLMBIGNGDK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class EGCMEHPAKJK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public LCLFBOIFPHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EGCMEHPAKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x47207C0", Offset = "0x471F3C0", VA = "0x1847207C0")]
		internal void IPGINMFGLBF(CCLMBIGNGDK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly OLAJDOFILEC JHEKBKKFGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, AIJPMDNMNDA> FEHFJJAMJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly PEECOIMOPMN EILEOOHLNIN;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBD70", Offset = "0x6FFA970", VA = "0x186FFBD70")]
	public LCLFBOIFPHL(int NDIDAIAJHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30311F0", Offset = "0x302FDF0", VA = "0x1830311F0", Slot = "4")]
	protected virtual ulong KNIBOKHELAP<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBB70", Offset = "0x6FFA770", VA = "0x186FFBB70", Slot = "5")]
	protected virtual AIJPMDNMNDA BKBDHMHCPHO(CCLMBIGNGDK EENAIFHJAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FB10", Offset = "0x3B6E710", VA = "0x183B6FB10", Slot = "6")]
	protected virtual void FHNDIHJLNDO<T>(PEECOIMOPMN JKKEKKKNJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBCF0", Offset = "0x6FFA8F0", VA = "0x186FFBCF0")]
	public void LGEAMCLHCJG(CCLMBIGNGDK EENAIFHJAJK, object GJJLHHDMOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FB80", Offset = "0x3B6E780", VA = "0x183B6FB80")]
	public void MOPDAHIFEJI<T>(PEECOIMOPMN JKKEKKKNJIN, T KKAHKDEHCEI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBCA0", Offset = "0x6FFA8A0", VA = "0x186FFBCA0")]
	public void IJILDHGJAMN(CCLMBIGNGDK EENAIFHJAJK, object GJJLHHDMOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FD90", Offset = "0x3B6E990", VA = "0x183B6FD90")]
	public void MPJOGAJMGAI<T>(Action<T> EFPDMODIFFA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B6FC10", Offset = "0x3B6E810", VA = "0x183B6FC10")]
	public void MPJOGAJMGAI<T, TUserData>(Action<T, TUserData> EFPDMODIFFA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GFMFPMEOBMI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9EC0", Offset = "0x6FE8AC0", VA = "0x186FE9EC0")]
	public GFMFPMEOBMI(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BGEOOCFEBLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9ED0", Offset = "0x6FE8AD0", VA = "0x186FE9ED0")]
	public BGEOOCFEBLF(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OLAJDOFILEC
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum KIELINIIEBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class HNBNBALHIFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public KIELINIIEBP JKOHHHGJLLP;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4DB83D0", Offset = "0x4DB6FD0", VA = "0x184DB83D0", Slot = "4")]
		public virtual void GFFHNKPMBNJ(MethodInfo FHHJANJIINJ, MethodInfo CKEFAPKKADE, KIELINIIEBP OPOPAMPKKGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void OPFADOFAFDI(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void EEMMEPILIBB(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		protected HNBNBALHIFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class GLLOKDMKJKM<TClass, TProperty> : HNBNBALHIFL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> ADPFPFNFHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> MCKNLNDNFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> MMCKGKJPKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> MKCKCLIBJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> GIGIDJDGGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> NHBEGLKADAN;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4D24B70", Offset = "0x4D23770", VA = "0x184D24B70", Slot = "7")]
		public override void ADDBIAADCML(TClass OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4D261C0", Offset = "0x4D24DC0", VA = "0x184D261C0", Slot = "8")]
		public override void GEJPIDJOHHF(TClass OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4D2B660", Offset = "0x4D2A260", VA = "0x184D2B660", Slot = "9")]
		public override void OPFADOFAFDI(TClass OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4D259E0", Offset = "0x4D245E0", VA = "0x184D259E0", Slot = "10")]
		public override void EEMMEPILIBB(TClass OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4D2AF50", Offset = "0x4D29B50", VA = "0x184D2AF50")]
		protected TProperty[] NPJBGOKAOBK(TClass OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4D24FD0", Offset = "0x4D23BD0", VA = "0x184D24FD0")]
		protected TProperty[] AGGMJDNPAJH(TClass OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4D26700", Offset = "0x4D25300", VA = "0x184D26700", Slot = "4")]
		public override void GFFHNKPMBNJ(MethodInfo FHHJANJIINJ, MethodInfo CKEFAPKKADE, KIELINIIEBP OPOPAMPKKGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4D2BBA0", Offset = "0x4D2A7A0", VA = "0x184D2BBA0")]
		protected GLLOKDMKJKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class HLGNGGANMBO<TClass, TProperty> : GLLOKDMKJKM<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void MEPAMHFMHOE(CCLMBIGNGDK DGCKGHIBLHO, [Out] TProperty CMEMKMDBEMF);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PGFMFHKCBEC(PEECOIMOPMN GPNALACCLJE, TProperty CMEMKMDBEMF);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4D70", Offset = "0x4DB3970", VA = "0x184DB4D70", Slot = "5")]
		public override void JBMIJPIPMMA(TClass OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4E70", Offset = "0x4DB3A70", VA = "0x184DB4E70", Slot = "6")]
		public override void MOPDAHIFEJI(TClass OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4AF0", Offset = "0x4DB36F0", VA = "0x184DB4AF0", Slot = "7")]
		public override void ADDBIAADCML(TClass OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4DB4CD0", Offset = "0x4DB38D0", VA = "0x184DB4CD0", Slot = "8")]
		public override void GEJPIDJOHHF(TClass OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x47034F0", Offset = "0x47020F0", VA = "0x1847034F0")]
		protected HLGNGGANMBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class POHJJNCDOPA<T> : GLLOKDMKJKM<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x57E8EF0", Offset = "0x57E7AF0", VA = "0x1857E8EF0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5657310", Offset = "0x5655F10", VA = "0x185657310", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x57E8E90", Offset = "0x57E7A90", VA = "0x1857E8E90", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x54C15F0", Offset = "0x54C01F0", VA = "0x1854C15F0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public POHJJNCDOPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class OBGELGFHCID<T> : GLLOKDMKJKM<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x56572B0", Offset = "0x5655EB0", VA = "0x1856572B0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5657310", Offset = "0x5655F10", VA = "0x185657310", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5657250", Offset = "0x5655E50", VA = "0x185657250", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x54C15F0", Offset = "0x54C01F0", VA = "0x1854C15F0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public OBGELGFHCID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JENICNJKKKK<T> : GLLOKDMKJKM<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x50F7150", Offset = "0x50F5D50", VA = "0x1850F7150", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x471CBD0", Offset = "0x471B7D0", VA = "0x18471CBD0", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x50F70F0", Offset = "0x50F5CF0", VA = "0x1850F70F0", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x471CB20", Offset = "0x471B720", VA = "0x18471CB20", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public JENICNJKKKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EEABJOHJJKA<T> : GLLOKDMKJKM<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x471CB70", Offset = "0x471B770", VA = "0x18471CB70", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x471CBD0", Offset = "0x471B7D0", VA = "0x18471CBD0", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x471CAC0", Offset = "0x471B6C0", VA = "0x18471CAC0", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x471CB20", Offset = "0x471B720", VA = "0x18471CB20", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public EEABJOHJJKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class IMNAGBENEHO<T> : GLLOKDMKJKM<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E822C0", Offset = "0x4E80EC0", VA = "0x184E822C0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E82320", Offset = "0x4E80F20", VA = "0x184E82320", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E82210", Offset = "0x4E80E10", VA = "0x184E82210", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E82270", Offset = "0x4E80E70", VA = "0x184E82270", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public IMNAGBENEHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NDJHEOLNKHG<T> : GLLOKDMKJKM<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x551DDF0", Offset = "0x551C9F0", VA = "0x18551DDF0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E82320", Offset = "0x4E80F20", VA = "0x184E82320", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x551DD90", Offset = "0x551C990", VA = "0x18551DD90", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E82270", Offset = "0x4E80E70", VA = "0x184E82270", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public NDJHEOLNKHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class GBLLJFCOMNP<T> : GLLOKDMKJKM<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x42A0300", Offset = "0x429EF00", VA = "0x1842A0300", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x42A0360", Offset = "0x429EF60", VA = "0x1842A0360", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D05F70", Offset = "0x4D04B70", VA = "0x184D05F70", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42A02B0", Offset = "0x429EEB0", VA = "0x1842A02B0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public GBLLJFCOMNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DHDNDLDGNKN<T> : GLLOKDMKJKM<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x42A0300", Offset = "0x429EF00", VA = "0x1842A0300", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x42A0360", Offset = "0x429EF60", VA = "0x1842A0360", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x42A0250", Offset = "0x429EE50", VA = "0x1842A0250", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x42A02B0", Offset = "0x429EEB0", VA = "0x1842A02B0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public DHDNDLDGNKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MIOMDHJNOKM<T> : GLLOKDMKJKM<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x54C1640", Offset = "0x54C0240", VA = "0x1854C1640", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x54C16A0", Offset = "0x54C02A0", VA = "0x1854C16A0", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x54C1590", Offset = "0x54C0190", VA = "0x1854C1590", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x54C15F0", Offset = "0x54C01F0", VA = "0x1854C15F0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public MIOMDHJNOKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PIILEAFMPKP<T> : GLLOKDMKJKM<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x57D2B80", Offset = "0x57D1780", VA = "0x1857D2B80", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x57D2BE0", Offset = "0x57D17E0", VA = "0x1857D2BE0", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x57D2B20", Offset = "0x57D1720", VA = "0x1857D2B20", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E82270", Offset = "0x4E80E70", VA = "0x184E82270", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public PIILEAFMPKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KNGFJDKHOAF<T> : GLLOKDMKJKM<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x51FF300", Offset = "0x51FDF00", VA = "0x1851FF300", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x51FF360", Offset = "0x51FDF60", VA = "0x1851FF360", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x51FF2A0", Offset = "0x51FDEA0", VA = "0x1851FF2A0", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x42A02B0", Offset = "0x429EEB0", VA = "0x1842A02B0", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x42A03B0", Offset = "0x429EFB0", VA = "0x1842A03B0")]
		public KNGFJDKHOAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class NOLOMENNNOH<T> : HLGNGGANMBO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x554C2B0", Offset = "0x554AEB0", VA = "0x18554C2B0", Slot = "12")]
		protected override void PGFMFHKCBEC(PEECOIMOPMN GPNALACCLJE, char CMEMKMDBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x554C280", Offset = "0x554AE80", VA = "0x18554C280", Slot = "11")]
		protected override void MEPAMHFMHOE(CCLMBIGNGDK DGCKGHIBLHO, [Out] char CMEMKMDBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
		public NOLOMENNNOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DNMLOBLMEBM<T> : HLGNGGANMBO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x42D1070", Offset = "0x42CFC70", VA = "0x1842D1070", Slot = "12")]
		protected override void PGFMFHKCBEC(PEECOIMOPMN GPNALACCLJE, IPEndPoint CMEMKMDBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x42D1030", Offset = "0x42CFC30", VA = "0x1842D1030", Slot = "11")]
		protected override void MEPAMHFMHOE(CCLMBIGNGDK DGCKGHIBLHO, [Out] IPEndPoint CMEMKMDBEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
		public DNMLOBLMEBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JLLHJPMLCOH<T> : GLLOKDMKJKM<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int HAGDGOKPANO;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x510EA70", Offset = "0x510D670", VA = "0x18510EA70")]
		public JLLHJPMLCOH(int CHEPOIJLLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x510E9A0", Offset = "0x510D5A0", VA = "0x18510E9A0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x510EA10", Offset = "0x510D610", VA = "0x18510EA10", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x510E8D0", Offset = "0x510D4D0", VA = "0x18510E8D0", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x510E940", Offset = "0x510D540", VA = "0x18510E940", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class OMGBGFAOJOK<T> : HNBNBALHIFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo FFIINAPJLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type OAKFDJGCDGL;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x56873B0", Offset = "0x5685FB0", VA = "0x1856873B0")]
		public OMGBGFAOJOK(PropertyInfo NMCGBFDKCMK, Type MMBLNNOBCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x56871E0", Offset = "0x5685DE0", VA = "0x1856871E0", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x56872A0", Offset = "0x5685EA0", VA = "0x1856872A0", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x56870C0", Offset = "0x5685CC0", VA = "0x1856870C0", Slot = "7")]
		public override void ADDBIAADCML(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5687180", Offset = "0x5685D80", VA = "0x185687180", Slot = "8")]
		public override void GEJPIDJOHHF(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5687350", Offset = "0x5685F50", VA = "0x185687350", Slot = "9")]
		public override void OPFADOFAFDI(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5687120", Offset = "0x5685D20", VA = "0x185687120", Slot = "10")]
		public override void EEMMEPILIBB(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class OFFIEIJLJPH<T> : OMGBGFAOJOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
		public OFFIEIJLJPH(PropertyInfo NMCGBFDKCMK, Type MMBLNNOBCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x565F480", Offset = "0x565E080", VA = "0x18565F480", Slot = "5")]
		public override void JBMIJPIPMMA(T OHLFKLLLDJN, CCLMBIGNGDK DGCKGHIBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x565F540", Offset = "0x565E140", VA = "0x18565F540", Slot = "6")]
		public override void MOPDAHIFEJI(T OHLFKLLLDJN, PEECOIMOPMN GPNALACCLJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class APHOOMALMEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static APHOOMALMEK<T> LBPNLDGACAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly HNBNBALHIFL<T>[] CLBPHFKECPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int BGKGAEHFPMC;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x516A490", Offset = "0x5169090", VA = "0x18516A490")]
		public APHOOMALMEK(List<HNBNBALHIFL<T>> EKKJPBFANHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x516A3E0", Offset = "0x5168FE0", VA = "0x18516A3E0")]
		public void MOPDAHIFEJI(T KDKJDFFGNJJ, PEECOIMOPMN JKKEKKKNJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x516A330", Offset = "0x5168F30", VA = "0x18516A330")]
		public void JBMIJPIPMMA(T KDKJDFFGNJJ, CCLMBIGNGDK EENAIFHJAJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class PJCDFFPCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HNBNBALHIFL<T> LBDBFELEJGA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private PEECOIMOPMN GKHKMMIGIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int GPOAPGAKOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, PJCDFFPCPBJ> AJMJOBNIKKB;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF790", Offset = "0x6FFE390", VA = "0x186FFF790")]
	public OLAJDOFILEC(int NDIDAIAJHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3C75540", Offset = "0x3C74140", VA = "0x183C75540")]
	private APHOOMALMEK<T> CHNFGCCPBLK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x304D6C0", Offset = "0x304C2C0", VA = "0x18304D6C0")]
	public void KHPGHNAFBFC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3C76410", Offset = "0x3C75010", VA = "0x183C76410")]
	public bool EBAGJKMAFHO<T>(CCLMBIGNGDK EENAIFHJAJK, T MDKAAPLMLKG) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3C754E0", Offset = "0x3C740E0", VA = "0x183C754E0")]
	public void BLPDEIDOFHH<T>(PEECOIMOPMN JKKEKKKNJIN, T KDKJDFFGNJJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IFNNDCINHPE
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime AKNPCKIBGIA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] HKPAGKDIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GJJOJNNGBJE FPIODHLKIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6310", Offset = "0x6FF4F10", VA = "0x186FF6310")]
		get
		{
			return default(GJJOJNNGBJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HBPCOPGIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF62B0", Offset = "0x6FF4EB0", VA = "0x186FF62B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6750", Offset = "0x6FF5350", VA = "0x186FF6750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NNEELPBGJLF FLCFCMKJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6250", Offset = "0x6FF4E50", VA = "0x186FF6250")]
		get
		{
			return default(NNEELPBGJLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6BA0", Offset = "0x6FF57A0", VA = "0x186FF6BA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int EHKPCDHDKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF62E0", Offset = "0x6FF4EE0", VA = "0x186FF62E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint CDFEEKNJDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6410", Offset = "0x6FF5010", VA = "0x186FF6410")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KEFHEHDJEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6690", Offset = "0x6FF5290", VA = "0x186FF6690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? MGPHOKLOIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6490", Offset = "0x6FF5090", VA = "0x186FF6490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? GNFBNHFNIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6280", Offset = "0x6FF4E80", VA = "0x186FF6280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF69D0", Offset = "0x6FF55D0", VA = "0x186FF69D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? JEBPPDIMMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xE6E540", Offset = "0xE6D140", VA = "0x180E6E540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6CF0", Offset = "0x6FF58F0", VA = "0x186FF6CF0")]
	public IFNNDCINHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6C40", Offset = "0x6FF5840", VA = "0x186FF6C40")]
	internal IFNNDCINHPE(byte[] OEOOBGJGDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6790", Offset = "0x6FF5390", VA = "0x186FF6790")]
	public static IFNNDCINHPE KLFOHHEJLMH(byte[] OEOOBGJGDIH, DateTime FMCPABGDACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5E70", Offset = "0x6FF4A70", VA = "0x186FF5E70")]
	internal void AHNLDCOJIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6070", Offset = "0x6FF4C70", VA = "0x186FF6070")]
	private void BCNFALMCJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5C70", Offset = "0x6FF4870", VA = "0x186FF5C70")]
	private DateTime? ABJKGJGCFNF(int KPHEINADMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF64C0", Offset = "0x6FF50C0", VA = "0x186FF64C0")]
	private void HONNPNHEBPI(int KPHEINADMCH, DateTime? OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6340", Offset = "0x6FF4F40", VA = "0x186FF6340")]
	private ulong FIDKPAJBOIO(int KPHEINADMCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6910", Offset = "0x6FF5510", VA = "0x186FF6910")]
	private void LFGNEEFOJDA(int KPHEINADMCH, ulong OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6FF66C0", Offset = "0x6FF52C0", VA = "0x186FF66C0")]
	private uint KDDKLPEKKOH(int KPHEINADMCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4F50", Offset = "0x6EB3B50", VA = "0x186EB4F50")]
	private static uint KOFOGPCKPGE(uint KFGAJBKADFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6FF68B0", Offset = "0x6FF54B0", VA = "0x186FF68B0")]
	private static ulong KOFOGPCKPGE(ulong KFGAJBKADFK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum GJJOJNNGBJE
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum NNEELPBGJLF
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class CMMGDONKDMB
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int LHFKMDBECEB = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int MFNNMFODNGM = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int NCJMGFEHALO = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint MGONPBDOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int AHPFHOIGFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int NNICACDGHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CIFBFJFLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAC80", Offset = "0x6FE9880", VA = "0x186FEAC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAB90", Offset = "0x6FE9790", VA = "0x186FEAB90")]
	public bool CJJJNINAOAN(MNOCKIBOFGI DFJFKOOJMLF, int COICELPPBEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class LFBBEDFALHH : MNOCKIBOFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket DFJFKOOJMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly GPACDFNOKNB FLNIMFPPELG;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short PDDMMGHIHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC620", Offset = "0x6FFB220", VA = "0x186FFC620", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JCIEJCALLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBFE0", Offset = "0x6FFABE0", VA = "0x186FFBFE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint PEPJNMCHJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC640", Offset = "0x6FFB240", VA = "0x186FFC640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily ACBBHNONONL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x526CB40", Offset = "0x526B740", VA = "0x18526CB40", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC660", Offset = "0x6FFB260", VA = "0x186FFC660")]
	public LFBBEDFALHH(AddressFamily LJNIMOMCPBK, GPACDFNOKNB FLNIMFPPELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC000", Offset = "0x6FFAC00", VA = "0x186FFC000", Slot = "8")]
	public bool KGAKCOIMIFA(IPEndPoint FKNLGOMGPIA, IJCAAMAFGHD NFPDOOGJNGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC5E0", Offset = "0x6FFB1E0", VA = "0x186FFC5E0", Slot = "9")]
	public int KPMIOPDBHLJ(byte[] DPMBBHPEMOM, int KPHEINADMCH, int DKFJGBGJGBG, IPEndPoint NFMNGDEHOOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBEF0", Offset = "0x6FFAAF0", VA = "0x186FFBEF0", Slot = "10")]
	public int EMJKNOHDFAA(byte[] DPMBBHPEMOM, EndPoint ONAPENINNKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC5C0", Offset = "0x6FFB1C0", VA = "0x186FFC5C0", Slot = "11")]
	public void KIJLNBIPOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface MNOCKIBOFGI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short PDDMMGHIHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int JCIEJCALLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint PEPJNMCHJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily ACBBHNONONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KGAKCOIMIFA(IPEndPoint FKNLGOMGPIA, IJCAAMAFGHD NFPDOOGJNGL);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KPMIOPDBHLJ(byte[] DPMBBHPEMOM, int KPHEINADMCH, int DKFJGBGJGBG, IPEndPoint NFMNGDEHOOH);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EMJKNOHDFAA(byte[] DPMBBHPEMOM, EndPoint NFMNGDEHOOH);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIJLNBIPOKM();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct KKCCMADHNEJ : IEquatable<KKCCMADHNEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long IAGKNBMEHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long PHGBACHAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long FLKBFLHKCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int DGNLGENHMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int DNHEHKFHPOL;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB630", Offset = "0x6FFA230", VA = "0x186FFB630")]
	public KKCCMADHNEJ(byte[] JOABIEDGONG, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB6F0", Offset = "0x6FFA2F0", VA = "0x186FFB6F0")]
	public KKCCMADHNEJ(Span<byte> JOABIEDGONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA45B00", Offset = "0xA44700", VA = "0x180A45B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB540", Offset = "0x6FFA140", VA = "0x186FFB540", Slot = "4")]
	public bool Equals(KKCCMADHNEJ GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB580", Offset = "0x6FFA180", VA = "0x186FFB580", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class OONAIDLFJOK : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] KHBFKANOMFF;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CEOMMLEAOJI
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void JGJAHNGPPGL(IPEndPoint JOABIEDGONG, Span<byte> PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string KCBOHNMCEHB = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int IJPCGNBFHIL = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int PFADEDCPILE = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static Dictionary<KKCCMADHNEJ, IPEndPoint> PNCPIHIDFAD;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static JGJAHNGPPGL JLNICCNABKN;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	internal void MBLBIAPPAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	internal void PGAGPGGNPGM(IPEndPoint NFMNGDEHOOH, Span<byte> PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class APDNDEEGOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly int NALHEENOFGJ;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
	protected APDNDEEGOJL(int IOAMNNGGPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DPAHJNDBKJH(IPEndPoint FKNLGOMGPIA, byte[] PEDMEJIDLNB, int KPHEINADMCH, int FMOIHNPEKPL);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GMLGBJNILGP(IPEndPoint FKNLGOMGPIA, byte[] PEDMEJIDLNB, int KPHEINADMCH, int FMOIHNPEKPL);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FAJNLHGLDAL : APDNDEEGOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private byte[] MEPFFFGIFGB;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly RandomNumberGenerator GLLFCNDHION;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x294DBC0", Offset = "0x294C7C0", VA = "0x18294DBC0")]
	public FAJNLHGLDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBAE0", Offset = "0x6FEA6E0", VA = "0x186FEBAE0")]
	public void HLPMPDFMKGN(IPEndPoint FKNLGOMGPIA, byte[] MEPFFFGIFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBC90", Offset = "0x6FEA890", VA = "0x186FEBC90")]
	public void POOLPHIIIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB2D0", Offset = "0x6FE9ED0", VA = "0x186FEB2D0", Slot = "4")]
	public override void DPAHJNDBKJH(IPEndPoint FKNLGOMGPIA, byte[] PEDMEJIDLNB, int KPHEINADMCH, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB780", Offset = "0x6FEA380", VA = "0x186FEB780", Slot = "5")]
	public override void GMLGBJNILGP(IPEndPoint FKNLGOMGPIA, byte[] PEDMEJIDLNB, int KPHEINADMCH, int FMOIHNPEKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct BBGPODPDAME
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void NOJIJJEODBI([NoAlias] byte* FAOGNHPCPPP, [NoAlias] byte* MEPFFFGIFGB, [NoAlias] byte* MPNDMGLMJPC, int FMOIHNPEKPL);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class DAJMFCJNLJD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static IntPtr IHOCLMFCMLD;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static IntPtr HIKNDJCOGKA;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7000D60", Offset = "0x6FFF960", VA = "0x187000D60")]
		[BurstDiscard]
		private static void EIPJJKFEDKH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7000E80", Offset = "0x6FFFA80", VA = "0x187000E80")]
		private static IntPtr IOMECBKMMLP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7001200", Offset = "0x6FFFE00", VA = "0x187001200")]
		public static void NFBACOONCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		public static void LEIJOMGLGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7000FD0", Offset = "0x6FFFBD0", VA = "0x187000FD0")]
		public unsafe static void JMCDHFFLEOJ([NoAlias] byte* FAOGNHPCPPP, [NoAlias] byte* MEPFFFGIFGB, [NoAlias] byte* MPNDMGLMJPC, int FMOIHNPEKPL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint MEPFFFGIFGB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint MPNDMGLMJPC[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint HMGHAGDADOB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint LDAICGHEPLG[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint AAFKNHEKFJL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint OMOINMJHGPG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint LAOCNDJKPAK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private uint GJEHBKOELAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint DCOGAJOPHKB[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9AB0", Offset = "0x6FE86B0", VA = "0x186FE9AB0")]
	private void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9A10", Offset = "0x6FE8610", VA = "0x186FE9A10")]
	private uint IIMHEEIABOH(uint GCKEIIMJEBO, int BCDABGMEFFB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE85A0", Offset = "0x6FE71A0", VA = "0x186FE85A0")]
	private void AEOHEGLKGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE87E0", Offset = "0x6FE73E0", VA = "0x186FE87E0")]
	private void MEEJCBJCOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8750", Offset = "0x6FE7350", VA = "0x186FE8750")]
	private void JDKPPEIJBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8650", Offset = "0x6FE7250", VA = "0x186FE8650")]
	private void JAHDNNFJNIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9490", Offset = "0x6FE8090", VA = "0x186FE9490")]
	private void BEDPLLMLMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FE95F0", Offset = "0x6FE81F0", VA = "0x186FE95F0")]
	private unsafe void HHCIODJLNEL(byte* FAOGNHPCPPP, uint* MEPFFFGIFGB, uint* MPNDMGLMJPC, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9330", Offset = "0x6FE7F30", VA = "0x186FE9330")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void ANNMNIJLNBF([NoAlias] byte* FAOGNHPCPPP, [NoAlias] byte* MEPFFFGIFGB, [NoAlias] byte* MPNDMGLMJPC, int FMOIHNPEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6FE93B0", Offset = "0x6FE7FB0", VA = "0x186FE93B0")]
	public static void ANNMNIJLNBF(Span<byte> FAOGNHPCPPP, Span<byte> MEPFFFGIFGB, Span<byte> MPNDMGLMJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6FE94F0", Offset = "0x6FE80F0", VA = "0x186FE94F0")]
	public static void CKEHPIBNDIB(Span<byte> FAOGNHPCPPP, Span<byte> MEPFFFGIFGB, Span<byte> MPNDMGLMJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9A40", Offset = "0x6FE8640", VA = "0x186FE9A40")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KCIELJIJHIA([NoAlias] byte* FAOGNHPCPPP, [NoAlias] byte* MEPFFFGIFGB, [NoAlias] byte* MPNDMGLMJPC, int FMOIHNPEKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x70013A0", Offset = "0x6FFFFA0", VA = "0x1870013A0")]
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
