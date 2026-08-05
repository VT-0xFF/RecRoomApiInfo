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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MEKMCJKGCDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KNGGMMAOGKB
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
		private NetworkManager BBEGNGBJGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, EEDPDLABFOF> CNHAAKOCAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FBMHJFGFNCJ DBDOJMHBPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] GJFCDBLABFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KNGGMMAOGKB DJODMPFBMKK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong GFOKJCILFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NOCHMJIJPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x54A03A0", Offset = "0x549F1A0", VA = "0x1854A03A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x549F8A0", Offset = "0x549E6A0", VA = "0x18549F8A0")]
		public void RecRoom_SetEncryptionInfo(ulong EEKIKHMKIIL, byte[] IDGIKKEFDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x549F880", Offset = "0x549E680", VA = "0x18549F880")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x549F750", Offset = "0x549E550", VA = "0x18549F750")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x54A02A0", Offset = "0x549F0A0", VA = "0x1854A02A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x549FAA0", Offset = "0x549E8A0", VA = "0x18549FAA0", Slot = "6")]
		public override void Send(ulong NOGNFBAHHGM, ArraySegment<byte> HKPHNGEBIED, NetworkDelivery MLLEIALHAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x549F840", Offset = "0x549E640", VA = "0x18549F840", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong NOGNFBAHHGM, [Out] ArraySegment<byte> PLFMLOLFNID, [Out] float OEEAPNLBGAP)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x549FD90", Offset = "0x549EB90", VA = "0x18549FD90", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x54A01C0", Offset = "0x549EFC0", VA = "0x1854A01C0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x549EE50", Offset = "0x549DC50", VA = "0x18549EE50", Slot = "10")]
		public override void DisconnectRemoteClient(ulong NOGNFBAHHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x549ED00", Offset = "0x549DB00", VA = "0x18549ED00", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x549F200", Offset = "0x549E000", VA = "0x18549F200", Slot = "12")]
		public override ulong GetCurrentRtt(ulong NOGNFBAHHGM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x549FD20", Offset = "0x549EB20", VA = "0x18549FD20", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x549F380", Offset = "0x549E180", VA = "0x18549F380", Slot = "14")]
		public override void Initialize([Optional] NetworkManager BBEGNGBJGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x549F660", Offset = "0x549E460", VA = "0x18549F660")]
		private DNKEDLKDAGH KOMEONHACDA(NetworkDelivery HJCFEPLFGPG)
		{
			return default(DNKEDLKDAGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x549F5A0", Offset = "0x549E3A0", VA = "0x18549F5A0", Slot = "15")]
		private void JLDIGLHLKKJ(EEDPDLABFOF ELDJHJDLPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x549EBC0", Offset = "0x549D9C0", VA = "0x18549EBC0", Slot = "16")]
		private void DNGJCMLOLCG(EEDPDLABFOF ELDJHJDLPHP, EEMAIOMONLP LMAPGGALFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "17")]
		private void BPJPCGFPPEE(IPEndPoint KGPOHANMDNH, SocketError AEIJDMKCHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x549EFF0", Offset = "0x549DDF0", VA = "0x18549EFF0", Slot = "18")]
		private void FOPBOJDOONG(EEDPDLABFOF ELDJHJDLPHP, DBGMNMNLDGN NCEKPOKKHOM, byte HDCDNNPIHBN, DNKEDLKDAGH MCLAOJANFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x549F2A0", Offset = "0x549E0A0", VA = "0x18549F2A0")]
		private void HECICECLGHD(int GENDLFFGOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "19")]
		private void KGGBPIIMMII(IPEndPoint IPGJBHHALFK, DBGMNMNLDGN NCEKPOKKHOM, DFIGLHLBIGG OMAFMFMHALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "20")]
		private void PGKHOHGKPAE(EEDPDLABFOF ELDJHJDLPHP, int JILCAIEEJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x549F540", Offset = "0x549E340", VA = "0x18549F540", Slot = "21")]
		private void JFENDBCBEPN(DICHPJNCPLK NNOFNOIFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x549EFC0", Offset = "0x549DDC0", VA = "0x18549EFC0")]
		private ulong FAOIMEKKFCA(EEDPDLABFOF ELDJHJDLPHP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x549F730", Offset = "0x549E530", VA = "0x18549F730")]
		private static int MBEAOBMGOLE(float JILOLFHINNI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54A02C0", Offset = "0x549F0C0", VA = "0x1854A02C0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OGJLDCDCBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly EEDPDLABFOF DDFLDKHKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<CPECEJGCPPF> JOHCIPALHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PNKDHPHHMNK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54A1F00", Offset = "0x54A0D00", VA = "0x1854A1F00")]
	protected OGJLDCDCBIK(EEDPDLABFOF ELDJHJDLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54A1E20", Offset = "0x54A0C20", VA = "0x1854A1E20")]
	public void OEDNDMKNBGE(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54A1E80", Offset = "0x54A0C80", VA = "0x1854A1E80")]
	protected void PMIAHDJEDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x54A1DE0", Offset = "0x54A0BE0", VA = "0x1854A1DE0")]
	public bool JFCMNGIGGJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool BKMMIEDNCEF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DHNHCMJHFAA(CPECEJGCPPF LPKKDKFHMNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum HHINOPKNICE
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
public class DICHPJNCPLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FBMHJFGFNCJ EAOFEGEILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int DKMJNJKFKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OJIEBPPKHEN DDPDKFHDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint EAGKLLNIJDL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HHINOPKNICE IKDDLOFKIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B6700", Offset = "0x7B5500", VA = "0x1807B6700")]
		[CompilerGenerated]
		get
		{
			return default(HHINOPKNICE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF90", Offset = "0x8BDD90", VA = "0x1808BEF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x548F8D0", Offset = "0x548E6D0", VA = "0x18548F8D0")]
	internal void BHBFOGAGKEO(OJIEBPPKHEN AHMOJMJFAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x548F990", Offset = "0x548E790", VA = "0x18548F990")]
	private bool PJFEGAOMFFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x548F9C0", Offset = "0x548E7C0", VA = "0x18548F9C0")]
	internal DICHPJNCPLK(IPEndPoint IPGJBHHALFK, OJIEBPPKHEN CJOJNAEOCHL, FBMHJFGFNCJ BILJBAHMODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x548F930", Offset = "0x548E730", VA = "0x18548F930")]
	public EEDPDLABFOF DPPMAMBILPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DFIGLHLBIGG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EBNLNMFJBAL
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
public struct EEMAIOMONLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public EBNLNMFJBAL FHDMLBEAFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError JPANGCNHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DBGMNMNLDGN DOMNLDLIMHF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MEKMCJKGCDP
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADECKCFAOBL(EEDPDLABFOF ELDJHJDLPHP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEIKFDODFCM(EEDPDLABFOF ELDJHJDLPHP, EEMAIOMONLP LMAPGGALFND);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJHNDAIFOEJ(IPEndPoint KGPOHANMDNH, SocketError AEIJDMKCHEN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFJCNCMPAPD(EEDPDLABFOF ELDJHJDLPHP, DBGMNMNLDGN NCEKPOKKHOM, byte HDCDNNPIHBN, DNKEDLKDAGH MCLAOJANFMG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCNCIBFAIGC(IPEndPoint IPGJBHHALFK, DBGMNMNLDGN NCEKPOKKHOM, DFIGLHLBIGG OMAFMFMHALG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFGKDAPJLNM(EEDPDLABFOF ELDJHJDLPHP, int JILCAIEEJLO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKNFOJONJNE(DICHPJNCPLK NNOFNOIFPML);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LMEALPKIHCI
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AACABOMNAID(EEDPDLABFOF ELDJHJDLPHP, object NIOJNJHNOHI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DJLFBDIDLJN
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKINEBCANIA(OMLINKCOMGA LPKKDKFHMNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HENBGEIEHEE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POIBNEALGFA(EEDPDLABFOF ELDJHJDLPHP, IPEndPoint AAFNIKHLINB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OJIEBPPKHEN
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int BBCPHPIEFHA = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long HLKLMKILBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte GLPHDCFHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] LAPHLCLGAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NNCKABODGAF LHCDIJPGOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int CKHKHEJFEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x54A2C20", Offset = "0x54A1A20", VA = "0x1854A2C20")]
	private OJIEBPPKHEN(long KAGNOEIJCNA, byte FOOHEKKHAFE, int ELLEDDADJFH, byte[] EIFMJLMALJN, NNCKABODGAF HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x54A29E0", Offset = "0x54A17E0", VA = "0x1854A29E0")]
	public static int IFOCEAGGJLM(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x54A27C0", Offset = "0x54A15C0", VA = "0x1854A27C0")]
	public static OJIEBPPKHEN EDDABFFCILD(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54A2A40", Offset = "0x54A1840", VA = "0x1854A2A40")]
	public static CPECEJGCPPF JKLEGKMJKKC(GLEGAEPNCOB JGAPNEKHOIG, SocketAddress DCOEOACJAKD, long NGNDIKLDCPI, int ELLEDDADJFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class IJBCDPFGCDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long HLKLMKILBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte GLPHDCFHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int CKHKHEJFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool KNPJJFEKFDO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x549DCC0", Offset = "0x549CAC0", VA = "0x18549DCC0")]
	private IJBCDPFGCDH(long KAGNOEIJCNA, byte FOOHEKKHAFE, int DIMLGNCPKMB, bool CCGNNGGMPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x549DA80", Offset = "0x549C880", VA = "0x18549DA80")]
	public static IJBCDPFGCDH EDDABFFCILD(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x549DBD0", Offset = "0x549C9D0", VA = "0x18549DBD0")]
	public static CPECEJGCPPF JKLEGKMJKKC(long NGNDIKLDCPI, byte KGMIKPIEKBD, int PFDKKCJPBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x549D980", Offset = "0x549C780", VA = "0x18549D980")]
	public static CPECEJGCPPF DIEOHAGLJNJ(EEDPDLABFOF ELDJHJDLPHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum OBOPDHJPIIG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AKLBFPNMHIJ
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBAODGNFFON(IPEndPoint MFPLFBJEBCH, IPEndPoint IPGJBHHALFK, string CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAMCDPLLAGA(IPEndPoint BKIILFLOAJF, OBOPDHJPIIG HJCFEPLFGPG, string CGFEMNMBCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EMNJLCHLJCC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IEOIMLOBLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint BELKAJOPNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint EAGKLLNIJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string ICKCHNHLJOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NIHOCADFPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OCIEGMIEDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OBOPDHJPIIG MCBKDNIENIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string ICKCHNHLJOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MFPOMOJDNEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint PGIBIHCFFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ICKCHNHLJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MFPOMOJDNEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class LLMHADBPFEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint PGIBIHCFFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LIFFFJNMBHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ICKCHNHLJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public LLMHADBPFEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class LKEKPPPMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ICKCHNHLJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HEGNMOKDOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x796F10", Offset = "0x795D10", VA = "0x180796F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public LKEKPPPMPOM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FBMHJFGFNCJ FMJOJEHPDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<IEOIMLOBLNH> HFJOBEICAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<NIHOCADFPMI> CKBIPOHAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NNCKABODGAF JLJKFLECMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GLEGAEPNCOB CPPMMKALAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly OFDGNHEGKOG FIMKJGOLFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AKLBFPNMHIJ NLDFPOBCEBH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int HOGPOPAEAEO = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool AFELDLIODAA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5495310", Offset = "0x5494110", VA = "0x185495310")]
	internal EMNJLCHLJCC(FBMHJFGFNCJ KJGEKKNGFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x54951B0", Offset = "0x5493FB0", VA = "0x1854951B0")]
	internal void HHEEFCDNPBG(IPEndPoint LCEJALAHOCE, CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24904C0", Offset = "0x248F2C0", VA = "0x1824904C0")]
	private void AGCJFLKCPCG<T>(T LPKKDKFHMNJ, IPEndPoint KEENMLGJEKM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5494D20", Offset = "0x5493B20", VA = "0x185494D20")]
	private void CBAODGNFFON(MFPOMOJDNEE MPIGDAIIMIE, IPEndPoint LCEJALAHOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5495050", Offset = "0x5493E50", VA = "0x185495050")]
	private void GAPOCIJAOME(LLMHADBPFEH MPIGDAIIMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5494EB0", Offset = "0x5493CB0", VA = "0x185494EB0")]
	private void FCGDNJJPOMK(LKEKPPPMPOM MPIGDAIIMIE, IPEndPoint LCEJALAHOCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DNKEDLKDAGH : byte
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
public enum NHEDHENOGKD : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JIJIKHABHDG
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] NMDNENPIGGA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int GJIKDHNEIFP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int NNHFLPBMDFB;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JBJJGKGNHBD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x549DD10", Offset = "0x549CB10", VA = "0x18549DD10")]
	public JBJJGKGNHBD(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KPPEAJKIKNO : JBJJGKGNHBD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x549DD10", Offset = "0x549CB10", VA = "0x18549DD10")]
	public KPPEAJKIKNO(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EMHJBCKIJFC
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
public interface DLCLGJLJJAC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKMPCGANNDL(EMHJBCKIJFC LMOMPGJCGNE, string ELALCBMPIFC, params object[] DJELKPGJPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FLFOLNMAPCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static DLCLGJLJJAC FOAEKLAOBJP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PKMDNHFFOJA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x549C7F0", Offset = "0x549B5F0", VA = "0x18549C7F0")]
	private static void FHOFCFIBKCI(EMHJBCKIJFC PCNBCCCGGJL, string ELALCBMPIFC, params object[] DJELKPGJPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x549C730", Offset = "0x549B530", VA = "0x18549C730")]
	internal static void CMJIMMBCFIE(string ELALCBMPIFC, params object[] DJELKPGJPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x549C790", Offset = "0x549B590", VA = "0x18549C790")]
	internal static void EAFLHICIIIJ(string ELALCBMPIFC, params object[] DJELKPGJPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x549CA20", Offset = "0x549B820", VA = "0x18549CA20")]
	internal static void MOBLEEMNGMF(string ELALCBMPIFC, params object[] DJELKPGJPKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum PKJCBAJDOIC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DBGMNMNLDGN : NNCKABODGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private CPECEJGCPPF KMANHGOMDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FBMHJFGFNCJ MKOANNDALKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JEPODEEPINI NPCGFAHCMCA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x548EC20", Offset = "0x548DA20", VA = "0x18548EC20")]
	internal DBGMNMNLDGN(FBMHJFGFNCJ OMCPJFGHGNL, JEPODEEPINI KLJFPJBIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x548EB80", Offset = "0x548D980", VA = "0x18548EB80")]
	internal void BMKOHILHGDE(CPECEJGCPPF LPKKDKFHMNJ, int EADNGLDLHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x548EB00", Offset = "0x548D900", VA = "0x18548EB00")]
	internal void AEIPBPGBJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x548EBF0", Offset = "0x548D9F0", VA = "0x18548EBF0")]
	public void OEIBDEFKCKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JEPODEEPINI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum AAEAPKAGHEH
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
	public JEPODEEPINI PAEFCMFOLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AAEAPKAGHEH MCBKDNIENIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public EEDPDLABFOF DDFLDKHKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint EAGKLLNIJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object LDPFKPNPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int EGDIBEDDEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError ELEDICNCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public EBNLNMFJBAL MILIMOCKLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public DICHPJNCPLK DCLEKHPDEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public DNKEDLKDAGH GPDGJMKLPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte HAGNCGEAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly DBGMNMNLDGN LDECEAOCIHI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x549DD20", Offset = "0x549CB20", VA = "0x18549DD20")]
	public JEPODEEPINI(FBMHJFGFNCJ OMCPJFGHGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FBMHJFGFNCJ : IEnumerable<EEDPDLABFOF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class BFHNMIKBDHA : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x548E010", Offset = "0x548CE10", VA = "0x18548E010", Slot = "4")]
		public bool Equals(IPEndPoint PCOMFHJKLCD, IPEndPoint EANLPGFBDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F81290", Offset = "0x4F80090", VA = "0x184F81290", Slot = "5")]
		public int GetHashCode(IPEndPoint FGANJEAKCMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public BFHNMIKBDHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct AIPBBAEHMCJ : IEnumerator<EEDPDLABFOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly EEDPDLABFOF FMDHIMKNLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private EEDPDLABFOF MIPAMJAALBB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EEDPDLABFOF GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x885000", Offset = "0x883E00", VA = "0x180885000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x885000", Offset = "0x883E00", VA = "0x180885000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xE8C3B0", Offset = "0xE8B1B0", VA = "0x180E8C3B0")]
		public AIPBBAEHMCJ(EEDPDLABFOF EAEODAPHCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x548DF70", Offset = "0x548CD70", VA = "0x18548DF70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x548DFC0", Offset = "0x548CDC0", VA = "0x18548DFC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread ANNLPFEPJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool IOEDJFCFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OMBKHEIMKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JEPODEEPINI> AHDJGPLLDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JEPODEEPINI> OIPOJECKBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JEPODEEPINI NPMAMGFJJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MEKMCJKGCDP EAOGLCDIMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LMEALPKIHCI GCGPFGBEENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DJLFBDIDLJN EHMMENGIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HENBGEIEHEE OMDAKCMOPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, EEDPDLABFOF> CLLMAHBCGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, DICHPJNCPLK> MFKELKHDPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, PLGMFGCIIOP> GNPDPCPCNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim KMPCGPIAJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EEDPDLABFOF JKOAHNPLOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int ADFNBBFGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<EEDPDLABFOF> FJNPPBDKLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EEDPDLABFOF[] AFEGFLJJDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HOBNCOGCDPL DCDEPNICLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int OEEJMIFBFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> IGDBKFBDLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte KGIFEHFEMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LAGCJKJGFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool PCFHJHHHLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool GACDNBDNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int OGAGFHFHJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int DBDAEDDADDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LDDHEHNBNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GIMGGKMDFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DHNBMBHEMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool ALJFAKNCFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IBBIHGCNIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DMLBAALAFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BEKOCPKEEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool AFELDLIODAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool HPLHLDHMPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool NGJLMEIFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool DBBKMGJLFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int ADLKGANBAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int MIGABDIHGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool OFDAHFIAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KOFLJFNIABB DHJHELKPBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LALCELBCPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly EMNJLCHLJCC FANDLMHGGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool JNCNMHEBKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public PKJCBAJDOIC BDICJCKNLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PPIILHEEPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MFMNJMNLOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool LGELJBKEGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool PPAIAPNDFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool PMJKLJEHACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private CPECEJGCPPF PLOGLPKIHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int FGFACBHNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object AEAMDOPLLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CPECEJGCPPF BBCEEEEHGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KKEEGCCALNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BPAMOLGKMIA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DPBIBOCKHFJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private ENOLHDPFEJM IEDCIMEFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ENOLHDPFEJM PIDLLKEHPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread NHENKNNFCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread GMIHMMANKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ENECEMCFALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint MOLHIKDNCMF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] IMAIIHFHKCN;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] JPEBJCDCPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NLHPJIKFNHD, IPEndPoint> IHKNLOPJBIC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress OJEPPMFADAG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool JCIEGMJKKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int BHCOPFALFFP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IAINFIANPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3B20", Offset = "0x9D2920", VA = "0x1809D3B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA620C0", Offset = "0xA60EC0", VA = "0x180A620C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FAKJEDKAILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1556410", Offset = "0x1555210", VA = "0x181556410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15552D0", Offset = "0x15540D0", VA = "0x1815552D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PJFNFPNOCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x849CC0", Offset = "0x848AC0", VA = "0x180849CC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OFLIHLJAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5498ED0", Offset = "0x5497CD0", VA = "0x185498ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short MGJDHIGHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5498BA0", Offset = "0x54979A0", VA = "0x185498BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5498500", Offset = "0x5497300", VA = "0x185498500")]
	public void IHPBNKLIPLK(IPEndPoint KGPOHANMDNH, byte[] IDGIKKEFDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54994C0", Offset = "0x54982C0", VA = "0x1854994C0")]
	public void MEIEDJGBAAD(IPEndPoint KGPOHANMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5495A20", Offset = "0x5494820", VA = "0x185495A20")]
	private bool ABLPEOCIPDB(IPEndPoint KGPOHANMDNH, [Out] EEDPDLABFOF ELDJHJDLPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5495760", Offset = "0x5494560", VA = "0x185495760")]
	private void AANLEMGMIJE(EEDPDLABFOF ELDJHJDLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5497A70", Offset = "0x5496870", VA = "0x185497A70")]
	private void HAEFEEAPDPB(EEDPDLABFOF ELDJHJDLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5496A20", Offset = "0x5495820", VA = "0x185496A20")]
	private void EDLDNOKPACL(EEDPDLABFOF ELDJHJDLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x549C0E0", Offset = "0x549AEE0", VA = "0x18549C0E0")]
	public FBMHJFGFNCJ(MEKMCJKGCDP BILJBAHMODH, [Optional] HOBNCOGCDPL CIPCMPILJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5498C60", Offset = "0x5497A60", VA = "0x185498C60")]
	internal void JLLCHOOBOJO(EEDPDLABFOF FCOBGJCIGIE, int JILCAIEEJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x549AD20", Offset = "0x5499B20", VA = "0x18549AD20")]
	internal void OKPKOKHAIAA(EEDPDLABFOF FCOBGJCIGIE, object NIOJNJHNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5499610", Offset = "0x5498410", VA = "0x185499610")]
	internal void MLIGANKMNLA(EEDPDLABFOF ELDJHJDLPHP, EBNLNMFJBAL LEMNLAKPKCD, SocketError MAOJLPKAKIM, CPECEJGCPPF LMNOBACJGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x549B090", Offset = "0x5499E90", VA = "0x18549B090")]
	private void PEOJMGIJNGA(EEDPDLABFOF ELDJHJDLPHP, EBNLNMFJBAL LEMNLAKPKCD, SocketError MAOJLPKAKIM, bool OEPPFJFNIGI, byte[] HKPHNGEBIED, int GMKGLLAPKMM, int KGLOPMIHJGF, CPECEJGCPPF LMNOBACJGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5495B10", Offset = "0x5494910", VA = "0x185495B10")]
	private void BDMIPCCCNGO(JEPODEEPINI.AAEAPKAGHEH HJCFEPLFGPG, [Optional] EEDPDLABFOF ELDJHJDLPHP, [Optional] IPEndPoint IPGJBHHALFK, SocketError IKGCGCBNPCH = SocketError.Success, int JILCAIEEJLO = 0, EBNLNMFJBAL FAEOEPDPKMO = EBNLNMFJBAL.ConnectionFailed, [Optional] DICHPJNCPLK JJBHAPBHMGJ, DNKEDLKDAGH MCLAOJANFMG = DNKEDLKDAGH.Unreliable, byte HDCDNNPIHBN = 0, [Optional] CPECEJGCPPF OAGDMBLJBAF, [Optional] object NIOJNJHNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x549B2E0", Offset = "0x549A0E0", VA = "0x18549B2E0")]
	private void PEPJADNFEDA(JEPODEEPINI KLJFPJBIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54993C0", Offset = "0x54981C0", VA = "0x1854993C0")]
	internal void LLFMLDKBPNL(JEPODEEPINI KLJFPJBIHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5496150", Offset = "0x5494F50", VA = "0x185496150")]
	private void EBEDAEAGHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x549AD70", Offset = "0x5499B70", VA = "0x18549AD70")]
	private void PBHPGBCGHJK(int OCPGNGBCLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5496F40", Offset = "0x5495D40", VA = "0x185496F40")]
	internal EEDPDLABFOF FDMIEBLPGLJ(DICHPJNCPLK NNOFNOIFPML, byte[] MNOBDJGNNNB, int GMKGLLAPKMM, int GENFKPIGLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5497560", Offset = "0x5496360", VA = "0x185497560")]
	private int FJKMMLJLHEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x549BAA0", Offset = "0x549A8A0", VA = "0x18549BAA0")]
	private void PGMHFCMHMAG(IPEndPoint IPGJBHHALFK, EEDPDLABFOF MKCOJHJCPMJ, OJIEBPPKHEN DKHLGFIODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5499AA0", Offset = "0x54988A0", VA = "0x185499AA0")]
	private void OHBJBGNNOOC(CPECEJGCPPF LPKKDKFHMNJ, IPEndPoint IPGJBHHALFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5496C80", Offset = "0x5495A80", VA = "0x185496C80")]
	internal void EPPHDHEPKBF(CPECEJGCPPF LPKKDKFHMNJ, DNKEDLKDAGH KNLAPEDDOJE, byte HDCDNNPIHBN, int EADNGLDLHKD, EEDPDLABFOF FCOBGJCIGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5497AE0", Offset = "0x54968E0", VA = "0x185497AE0")]
	public bool HKKNIOFHBCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5497AC0", Offset = "0x54968C0", VA = "0x185497AC0")]
	public bool HKKNIOFHBCA(IPAddress EIOCMKPMBFM, IPAddress GFLNFPIACPF, int MKCKGPODNBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x54982B0", Offset = "0x54970B0", VA = "0x1854982B0")]
	public bool HKKNIOFHBCA(int MKCKGPODNBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5495ED0", Offset = "0x5494CD0", VA = "0x185495ED0")]
	public void BPPNEBMLDPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5496940", Offset = "0x5495740", VA = "0x185496940")]
	public EEDPDLABFOF EBOONLOPHKJ(string CFJMKBIDFBN, int MKCKGPODNBI, string IDGIKKEFDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5496860", Offset = "0x5495660", VA = "0x185496860")]
	public EEDPDLABFOF EBOONLOPHKJ(string CFJMKBIDFBN, int MKCKGPODNBI, GLEGAEPNCOB CFAGJGFPDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5496490", Offset = "0x5495290", VA = "0x185496490")]
	public EEDPDLABFOF EBOONLOPHKJ(IPEndPoint KEENMLGJEKM, GLEGAEPNCOB CFAGJGFPDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5499060", Offset = "0x5497E60", VA = "0x185499060")]
	public void LGOAPCHIGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5499070", Offset = "0x5497E70", VA = "0x185499070")]
	public void LGOAPCHIGOJ(bool NLKFAMEOCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5498DD0", Offset = "0x5497BD0", VA = "0x185498DD0")]
	public void JPJNJGMIAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5498CB0", Offset = "0x5497AB0", VA = "0x185498CB0")]
	public void JPJNJGMIAAH(byte[] HKPHNGEBIED, int GMKGLLAPKMM, int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x549B170", Offset = "0x5499F70", VA = "0x18549B170")]
	public void PEOJMGIJNGA(EEDPDLABFOF ELDJHJDLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x549B220", Offset = "0x549A020", VA = "0x18549B220")]
	public void PEOJMGIJNGA(EEDPDLABFOF ELDJHJDLPHP, byte[] HKPHNGEBIED, int GMKGLLAPKMM, int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x549BF00", Offset = "0x549AD00", VA = "0x18549BF00", Slot = "4")]
	private IEnumerator<EEDPDLABFOF> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x549BF90", Offset = "0x549AD90", VA = "0x18549BF90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5498410", Offset = "0x5497210", VA = "0x185498410")]
	private CPECEJGCPPF IEDKHNJBEPH(FKFCJLKACKM LEDLMNEPNJE, int GENDLFFGOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5498330", Offset = "0x5497130", VA = "0x185498330")]
	private CPECEJGCPPF IEDKHNJBEPH(FKFCJLKACKM LEDLMNEPNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5497840", Offset = "0x5496640", VA = "0x185497840")]
	internal CPECEJGCPPF FPBKBAELEKJ(int GENDLFFGOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54975E0", Offset = "0x54963E0", VA = "0x1854975E0")]
	internal void FOKDBMHCJFM(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x549C020", Offset = "0x549AE20", VA = "0x18549C020")]
	static FBMHJFGFNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9D3B20", Offset = "0x9D2920", VA = "0x1809D3B20")]
	private bool DABADEKAIJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x54996E0", Offset = "0x54984E0", VA = "0x1854996E0")]
	private void NFONIEEOCJN(IPEndPoint DHDAMDANLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5496070", Offset = "0x5494E70", VA = "0x185496070")]
	private void DPDGBMEGBDI(IPEndPoint DHDAMDANLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x549AB80", Offset = "0x5499980", VA = "0x18549AB80")]
	private bool OKLGKDLMBFF(SocketException ANBLKCIIIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x54997D0", Offset = "0x54985D0", VA = "0x1854997D0")]
	private void NICOAALFDFP(ENOLHDPFEJM KJGEKKNGFPF, EndPoint JFLPGMAPCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x549A7F0", Offset = "0x54995F0", VA = "0x18549A7F0")]
	private void OHJGGEENLDP(object AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5497AF0", Offset = "0x54968F0", VA = "0x185497AF0")]
	public bool HKKNIOFHBCA(IPAddress EIOCMKPMBFM, IPAddress GFLNFPIACPF, int MKCKGPODNBI, bool CHMEGLLPDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5495AB0", Offset = "0x54948B0", VA = "0x185495AB0")]
	internal int ALOHEELAFNA(CPECEJGCPPF LPKKDKFHMNJ, IPEndPoint IPGJBHHALFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x54985A0", Offset = "0x54973A0", VA = "0x1854985A0")]
	internal int JEJAAFLHOFH(CPECEJGCPPF LPKKDKFHMNJ, IPEndPoint IPGJBHHALFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54985E0", Offset = "0x54973E0", VA = "0x1854985E0")]
	internal int JEJAAFLHOFH(byte[] EKPMNNKLPFJ, int GMKGLLAPKMM, int GENFKPIGLNJ, IPEndPoint IPGJBHHALFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5498EF0", Offset = "0x5497CF0", VA = "0x185498EF0")]
	internal void LELPIDBMGGC(bool DKPNIDICLKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FKFCJLKACKM : byte
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
internal sealed class CPECEJGCPPF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MGIJFJFHLHC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] OOEPPFGHNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] ODBJMPHIIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int ELGBHPFJHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object LDPFKPNPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public CPECEJGCPPF PAEFCMFOLCB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FKFCJLKACKM LOLLLJHDCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x548E2B0", Offset = "0x548D0B0", VA = "0x18548E2B0")]
		get
		{
			return default(FKFCJLKACKM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x548E530", Offset = "0x548D330", VA = "0x18548E530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte GLPHDCFHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x548E1C0", Offset = "0x548CFC0", VA = "0x18548E1C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x548E600", Offset = "0x548D400", VA = "0x18548E600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MJGAMFAPHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x548E1F0", Offset = "0x548CFF0", VA = "0x18548E1F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x548E410", Offset = "0x548D210", VA = "0x18548E410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PIJFBDGMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x548E570", Offset = "0x548D370", VA = "0x18548E570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte MCGMKENPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x548E670", Offset = "0x548D470", VA = "0x18548E670")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x548E640", Offset = "0x548D440", VA = "0x18548E640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort DKLIBIDMGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x548E250", Offset = "0x548D050", VA = "0x18548E250")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x548E450", Offset = "0x548D250", VA = "0x18548E450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort BADLKEMELKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x548E5A0", Offset = "0x548D3A0", VA = "0x18548E5A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x548E080", Offset = "0x548CE80", VA = "0x18548E080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort LNBGFAICIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x548E490", Offset = "0x548D290", VA = "0x18548E490")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x548E4F0", Offset = "0x548D2F0", VA = "0x18548E4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x548E6A0", Offset = "0x548D4A0", VA = "0x18548E6A0")]
	static CPECEJGCPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x548E2E0", Offset = "0x548D0E0", VA = "0x18548E2E0")]
	public void EFHMNJBHMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x548EA90", Offset = "0x548D890", VA = "0x18548EA90")]
	public CPECEJGCPPF(int GENDLFFGOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x548E980", Offset = "0x548D780", VA = "0x18548E980")]
	public CPECEJGCPPF(FKFCJLKACKM LEDLMNEPNJE, int GENDLFFGOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x548E310", Offset = "0x548D110", VA = "0x18548E310")]
	public static int FNCNAHJKBFD(FKFCJLKACKM LEDLMNEPNJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x548E380", Offset = "0x548D180", VA = "0x18548E380")]
	public int FNCNAHJKBFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x548E0C0", Offset = "0x548CEC0", VA = "0x18548E0C0")]
	public bool ACJEBNFICMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum NBNNFHKLJPB : byte
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
internal enum AMNOLMBCICN
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
internal enum OABEABKMJLJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum BNEBMIIBKDA
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EEDPDLABFOF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BNCFJDBJGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CPECEJGCPPF[] HCLMIKCMDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int EKDGEIAGHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int AKANPHGDOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte MCGMKENPIKG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public BNCFJDBJGGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void GJAHLIAFBOF(ulong MMJOJHKHHPP, int EPBOBPGDFIP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int ABMPCBPDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int AOCDAPKAJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int PGPIKDKMJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FKODIMEFBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BFBBKAAOEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GHPMDEHPCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int CILKAMOGCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GBEOHGJAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int AAIKLOJGOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long EJFBLKOOLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object NOLPOLKHFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal EEDPDLABFOF AOFFLFJEEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal EEDPDLABFOF LLFPGGCHIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<CPECEJGCPPF> MHIAOKADFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OGJLDCDCBIK> NCBBBAIGIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OGJLDCDCBIK[] DBGLCMHCJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int FFFNJLDJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int LCKAHHFMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool AKJBFFIACOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int KFHMMPCNMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int POHJNPEKGMM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int OMPGINBOCOC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int HMMKIMDNPIP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object PPIGFNGMOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MJKAGDJEFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, BNCFJDBJGGA> GLJJJIADGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> NIJGHKGJCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CPECEJGCPPF IAOLNCNPDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int EIEBEFEOJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int PMFEPKJCHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint AEOJPHJCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CKGBHACBIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int MODPJMPABOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long FOOAIPBDBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte LDHOEINOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NBNNFHKLJPB NNLHDLNPNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private CPECEJGCPPF OEOEOLKDECG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int CPJBKNLHMNI = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LAABOKCNIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly CPECEJGCPPF IDKAOBHGDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly CPECEJGCPPF GANEHGJGIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly CPECEJGCPPF LPLIFFJJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly CPECEJGCPPF PAEIIEPKOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private NHEDHENOGKD CNDBPLEMDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly FBMHJFGFNCJ NGHOLCGEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int JOMDFJHIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object LHNEPAFBPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KOFLJFNIABB DHJHELKPBCL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte EFHDJAEHHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA105D0", Offset = "0xA0F3D0", VA = "0x180A105D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5493800", Offset = "0x5492600", VA = "0x185493800")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint LIJCNCOHEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C17A0", Offset = "0x8C05A0", VA = "0x1808C17A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NBNNFHKLJPB MOCFAPHPDDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1571CA0", Offset = "0x1570AA0", VA = "0x181571CA0")]
		get
		{
			return default(NBNNFHKLJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KBHBHOLOGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79C8E0", Offset = "0x79B6E0", VA = "0x18079C8E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JGIFJIOMGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC5310", Offset = "0xAC4110", VA = "0x180AC5310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1394AA0", Offset = "0x13938A0", VA = "0x181394AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PCPPNPPGELI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x54918F0", Offset = "0x54906F0", VA = "0x1854918F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NGAOHOHAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x79E110", Offset = "0x79CF10", VA = "0x18079E110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double PAHGGAFAMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x174BCE0", Offset = "0x174AAE0", VA = "0x18174BCE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GJAHLIAFBOF NIHMGFFINCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5493920", Offset = "0x5492720", VA = "0x185493920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5492860", Offset = "0x5491660", VA = "0x185492860")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5494760", Offset = "0x5493560", VA = "0x185494760")]
	internal EEDPDLABFOF(FBMHJFGFNCJ KNCNCNKFNDE, IPEndPoint IPGJBHHALFK, int JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x54938B0", Offset = "0x54926B0", VA = "0x1854938B0")]
	internal void LPJEBCHGDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5492910", Offset = "0x5491710", VA = "0x185492910")]
	internal void ENHBHOEAKBO(IPEndPoint NMOPIMFDCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5492040", Offset = "0x5490E40", VA = "0x185492040")]
	internal void DCPDOPKGEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5491F70", Offset = "0x5490D70", VA = "0x185491F70")]
	private void CNGOEGGJKDD(int HJEGIHKOMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5492A20", Offset = "0x5491820", VA = "0x185492A20")]
	private void GBODALMKKBB(int FHCPFDBOIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5490DB0", Offset = "0x548FBB0", VA = "0x185490DB0")]
	private OGJLDCDCBIK ALLAOKBEMHH(byte ACEFEPBEAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54943F0", Offset = "0x54931F0", VA = "0x1854943F0")]
	internal EEDPDLABFOF(FBMHJFGFNCJ KNCNCNKFNDE, IPEndPoint IPGJBHHALFK, int JDEPDKNELPP, byte KGMIKPIEKBD, GLEGAEPNCOB JGAPNEKHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5494580", Offset = "0x5493380", VA = "0x185494580")]
	internal EEDPDLABFOF(FBMHJFGFNCJ KNCNCNKFNDE, DICHPJNCPLK NNOFNOIFPML, int JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x54938D0", Offset = "0x54926D0", VA = "0x1854938D0")]
	internal void MCIMFOFPALH(OJIEBPPKHEN IOHABLIHFFP, byte[] HKPHNGEBIED, int GMKGLLAPKMM, int GENFKPIGLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5492940", Offset = "0x5491740", VA = "0x185492940")]
	internal bool FEEIENPHJMC(IJBCDPFGCDH LPKKDKFHMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5490BB0", Offset = "0x548F9B0", VA = "0x185490BB0")]
	public void AGCJFLKCPCG(byte[] HKPHNGEBIED, int GMKGLLAPKMM, int GENFKPIGLNJ, DNKEDLKDAGH EAELIKKMFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x54939D0", Offset = "0x54927D0", VA = "0x1854939D0")]
	private void OIAJBFFNOHC(byte[] HKPHNGEBIED, int GMKGLLAPKMM, int GENFKPIGLNJ, byte HDCDNNPIHBN, DNKEDLKDAGH MCLAOJANFMG, object NIOJNJHNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5492D20", Offset = "0x5491B20", VA = "0x185492D20")]
	public void JPAKGBADCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5492780", Offset = "0x5491580", VA = "0x185492780")]
	internal OABEABKMJLJ EAKBCJPEGIM(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return default(OABEABKMJLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54929C0", Offset = "0x54917C0", VA = "0x1854929C0")]
	internal void GAOBGJKCMHA(OGJLDCDCBIK EEDJCDMLKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x54940E0", Offset = "0x5492EE0", VA = "0x1854940E0")]
	internal BNEBMIIBKDA PJKFNLCNBOE(byte[] HKPHNGEBIED, int GMKGLLAPKMM, int GENFKPIGLNJ, bool OEPPFJFNIGI)
	{
		return default(BNEBMIIBKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5490B70", Offset = "0x548F970", VA = "0x185490B70")]
	private void ACLKFLKHJIA(int ABEGALCBPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5490F60", Offset = "0x548FD60", VA = "0x185490F60")]
	internal void BFDBKNFKBJP(DNKEDLKDAGH KNLAPEDDOJE, CPECEJGCPPF EAEODAPHCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5491900", Offset = "0x5490700", VA = "0x185491900")]
	private void CGHHIEPGBIN(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5493480", Offset = "0x5492280", VA = "0x185493480")]
	private void LJGCDCCCGKO(int BLFDEPDEIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5493F20", Offset = "0x5492D20", VA = "0x185493F20")]
	internal AMNOLMBCICN PGMHFCMHMAG(OJIEBPPKHEN DKHLGFIODBA)
	{
		return default(AMNOLMBCICN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x54920D0", Offset = "0x5490ED0", VA = "0x1854920D0")]
	internal void DHNHCMJHFAA(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5491E50", Offset = "0x5490C50", VA = "0x185491E50")]
	private void CJGGCMLJBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5490BE0", Offset = "0x548F9E0", VA = "0x185490BE0")]
	internal void AJGFGHIELGG(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5492DD0", Offset = "0x5491BD0", VA = "0x185492DD0")]
	internal void KBHDIJCCCPP(int BLFDEPDEIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5492A60", Offset = "0x5491860", VA = "0x185492A60")]
	internal void JBOBMHHGOIO(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KOFLJFNIABB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long IIPKCDOFLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long CNDDBMIIENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long PMMFOKAFJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long JCHOPDAONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long ILINMCNCBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long DOMNGPADJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long AMGBEAHILCN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FDJLGDIGFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x549E5B0", Offset = "0x549D3B0", VA = "0x18549E5B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long BCPHPOGBOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x549E500", Offset = "0x549D300", VA = "0x18549E500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long DGMHHLOEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x549E690", Offset = "0x549D490", VA = "0x18549E690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ADDEJBKLELN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x549E440", Offset = "0x549D240", VA = "0x18549E440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long KJGHJGEGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x549E680", Offset = "0x549D480", VA = "0x18549E680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PDGNHMJMNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x549E510", Offset = "0x549D310", VA = "0x18549E510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private NHEDHENOGKD JFFDHNDAAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x199D2D0", Offset = "0x199C0D0", VA = "0x18199D2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double DAIJAIFDGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x549E5C0", Offset = "0x549D3C0", VA = "0x18549E5C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x549E520", Offset = "0x549D320", VA = "0x18549E520")]
	public void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x549E580", Offset = "0x549D380", VA = "0x18549E580")]
	public void KKJIIAFFAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x549E670", Offset = "0x549D470", VA = "0x18549E670")]
	public void NPOPPHIJHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x549E4F0", Offset = "0x549D2F0", VA = "0x18549E4F0")]
	public void FJJKPKDELFM(long HJNPAHCCODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x549E660", Offset = "0x549D460", VA = "0x18549E660")]
	public void NOEELPHIGLN(long JBJFNJBFMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x549E410", Offset = "0x549D210", VA = "0x18549E410")]
	public void BEKAICABCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x549E620", Offset = "0x549D420", VA = "0x18549E620")]
	public void MHJFGMKEKBB(long DNCBKJJDBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x549E6A0", Offset = "0x549D4A0", VA = "0x18549E6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x549E450", Offset = "0x549D250", VA = "0x18549E450")]
	public void EHJCAEHLBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public KOFLJFNIABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KAALMEFJHMM
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JNBIMEKKGKE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x549E130", Offset = "0x549CF30", VA = "0x18549E130")]
	public static IPEndPoint MGNBDJFCKJB(string EPNLADJLPDP, int MKCKGPODNBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x549DF60", Offset = "0x549CD60", VA = "0x18549DF60")]
	public static IPAddress MBGIKOPAPMP(string EPNLADJLPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x549DED0", Offset = "0x549CCD0", VA = "0x18549DED0")]
	public static IPAddress MBGIKOPAPMP(string EPNLADJLPDP, AddressFamily NHPJDKJMFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x549DEA0", Offset = "0x549CCA0", VA = "0x18549DEA0")]
	internal static int EGEMDPGIKFF(int KIFKFEJEPBF, int NHNGJFEFIDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x261A260", Offset = "0x2619060", VA = "0x18261A260")]
	internal static T[] FJGAIAPLAGG<T>(int KGLOPMIHJGF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DLDLICEIKJA : OGJLDCDCBIK
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct LPBENKKOAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CPECEJGCPPF KMANHGOMDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long CJBOBCCOJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool MEBFEJIEMNN;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x549EB20", Offset = "0x549D920", VA = "0x18549EB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x549EAB0", Offset = "0x549D8B0", VA = "0x18549EAB0")]
		public void FFIHNOCNALB(CPECEJGCPPF LPKKDKFHMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x549EA40", Offset = "0x549D840", VA = "0x18549EA40")]
		public bool CKOMHJHDKBJ(long MJLIPMGCMFA, EEDPDLABFOF ELDJHJDLPHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x549EAD0", Offset = "0x549D8D0", VA = "0x18549EAD0")]
		public bool LJNFEICKFHE(EEDPDLABFOF ELDJHJDLPHP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly CPECEJGCPPF CCFKCHIPMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly LPBENKKOAGD[] HEJHMHODOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly CPECEJGCPPF[] COBGLCCCLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] HCIGFBKKMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int NBKAAICDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int NHDFCEDDOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int FOMIFBEFLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int CLFFPFOGGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool IFJCELFIHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DNKEDLKDAGH BBJABDJAKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool NDPJNIHICLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int GBGGPFDLIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte EPKLMPKDNFJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5490900", Offset = "0x548F700", VA = "0x185490900")]
	public DLDLICEIKJA(EEDPDLABFOF ELDJHJDLPHP, bool GADIFIOOODD, byte JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x548FEE0", Offset = "0x548ECE0", VA = "0x18548FEE0")]
	private void BPNNHACHLON(CPECEJGCPPF LPKKDKFHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x548FA30", Offset = "0x548E830", VA = "0x18548FA30", Slot = "4")]
	protected override bool BKMMIEDNCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x54902A0", Offset = "0x548F0A0", VA = "0x1854902A0", Slot = "5")]
	public override bool DHNHCMJHFAA(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OEMLAHJDOJN : OGJLDCDCBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int PHBAKLKPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort NHDFCEDDOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool BMFKIMOLBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private CPECEJGCPPF JIOHCHGFAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly CPECEJGCPPF JJMMJELNEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool IFIPGJPCKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte EPKLMPKDNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long NFILPPEINAO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x54A19A0", Offset = "0x54A07A0", VA = "0x1854A19A0")]
	public OEMLAHJDOJN(EEDPDLABFOF ELDJHJDLPHP, bool BEGCMCFIMFA, byte JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x54A11F0", Offset = "0x549FFF0", VA = "0x1854A11F0", Slot = "4")]
	protected override bool BKMMIEDNCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x54A1690", Offset = "0x54A0490", VA = "0x1854A1690", Slot = "5")]
	public override bool DHNHCMJHFAA(CPECEJGCPPF LPKKDKFHMNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EFAEPABFFMO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct BKOPPJIAEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong KAIOEAMGOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double DOGDLEGOOJB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct PDEJCHPOPIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int CNPBGINAJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float BFOBGPPEOEK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x548DDE0", Offset = "0x548CBE0", VA = "0x18548DDE0")]
	private static void KIMEJBLIGOF(byte[] FHEAENNOLNB, int PNNJJHFFONP, ulong HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5494C10", Offset = "0x5493A10", VA = "0x185494C10")]
	private static void KIMEJBLIGOF(byte[] FHEAENNOLNB, int PNNJJHFFONP, int HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5494BC0", Offset = "0x54939C0", VA = "0x185494BC0")]
	public static void KIMEJBLIGOF(byte[] FHEAENNOLNB, int PNNJJHFFONP, short HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5494D00", Offset = "0x5493B00", VA = "0x185494D00")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, double MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5494C80", Offset = "0x5493A80", VA = "0x185494C80")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5494BC0", Offset = "0x54939C0", VA = "0x185494BC0")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, short MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5494BC0", Offset = "0x54939C0", VA = "0x185494BC0")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, ushort MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5494C10", Offset = "0x5493A10", VA = "0x185494C10")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, int MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5494C10", Offset = "0x5493A10", VA = "0x185494C10")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, uint MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5494C00", Offset = "0x5493A00", VA = "0x185494C00")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, long MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5494C00", Offset = "0x5493A00", VA = "0x185494C00")]
	public static void DOLHJFCLJIG(byte[] IJBHMPFLJAK, int MIMLCMKCBBJ, ulong MBDKMNBCLGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NNCKABODGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] DFEKEJNPLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int CLGKLHPKGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int GGOEIAHBJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int OEEPEGHGJPO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] ODBJMPHIIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JKOOBCFPGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HMOPMLJPKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x54A0CB0", Offset = "0x549FAB0", VA = "0x1854A0CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PEJLEBKEHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C42850", Offset = "0x1C41650", VA = "0x181C42850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BDPMDGNPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x54A0E00", Offset = "0x549FC00", VA = "0x1854A0E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x54A06C0", Offset = "0x549F4C0", VA = "0x1854A06C0")]
	public void BMKOHILHGDE(byte[] LGDFGELLOEL, int PNNJJHFFONP, int DICKPCOBHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public NNCKABODGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x54A1190", Offset = "0x549FF90", VA = "0x1854A1190")]
	public NNCKABODGAF(byte[] LGDFGELLOEL, int PNNJJHFFONP, int DICKPCOBHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x54A0B30", Offset = "0x549F930", VA = "0x1854A0B30")]
	public IPEndPoint IAOAAEJFCCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x54A0800", Offset = "0x549F600", VA = "0x1854A0800")]
	public byte FACEANKGBMK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x54A0800", Offset = "0x549F600", VA = "0x1854A0800")]
	public sbyte MAEKKGGBAMB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2717750", Offset = "0x2716550", VA = "0x182717750")]
	public T[] HIKENFPABLP<T>(ushort GENDLFFGOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54A07C0", Offset = "0x549F5C0", VA = "0x1854A07C0")]
	public bool[] EBINBECEEDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x54A0680", Offset = "0x549F480", VA = "0x1854A0680")]
	public ushort[] BCNLCAIEMOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x54A0700", Offset = "0x549F500", VA = "0x1854A0700")]
	public short[] BNLOKFEMEMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x54A1150", Offset = "0x549FF50", VA = "0x1854A1150")]
	public int[] PKPNLJMINPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54A0C00", Offset = "0x549FA00", VA = "0x1854A0C00")]
	public uint[] IJMNLDKKLHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54A0DA0", Offset = "0x549FBA0", VA = "0x1854A0DA0")]
	public float[] LBDPKJCLMKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54A0E10", Offset = "0x549FC10", VA = "0x1854A0E10")]
	public double[] MGFAMANLKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54A10D0", Offset = "0x549FED0", VA = "0x1854A10D0")]
	public long[] NMBAJIPOEDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54A1090", Offset = "0x549FE90", VA = "0x1854A1090")]
	public ulong[] NEGKDEOKKIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54A0990", Offset = "0x549F790", VA = "0x1854A0990")]
	public string[] HKFADLPAEJP(int IKNAHFOECIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54A0780", Offset = "0x549F580", VA = "0x1854A0780")]
	public bool DMDKMGANOEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54A0920", Offset = "0x549F720", VA = "0x1854A0920")]
	public char GIGGAFCAAJJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54A0920", Offset = "0x549F720", VA = "0x1854A0920")]
	public ushort JICHKMACAPF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x54A08B0", Offset = "0x549F6B0", VA = "0x1854A08B0")]
	public short GAMFLCLHLGI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x54A0840", Offset = "0x549F640", VA = "0x1854A0840")]
	public long FBIIHOFANDP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x54A05A0", Offset = "0x549F3A0", VA = "0x1854A05A0")]
	public ulong AEHPKLHCPPF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x54A0610", Offset = "0x549F410", VA = "0x1854A0610")]
	public int BAHEEFFLCCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54A0D30", Offset = "0x549FB30", VA = "0x1854A0D30")]
	public uint JPOOMDFPEIA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54A0C40", Offset = "0x549FA40", VA = "0x1854A0C40")]
	public float IKCLGALBPDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x54A0AC0", Offset = "0x549F8C0", VA = "0x1854A0AC0")]
	public double HKPAHANLJPA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54A0E50", Offset = "0x549FC50", VA = "0x1854A0E50")]
	public string MKNIFAHBAMC(int OGHEMJNHBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x54A0CC0", Offset = "0x549FAC0", VA = "0x1854A0CC0")]
	public ArraySegment<byte> JCLDICDKBOE(int KGLOPMIHJGF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x54A0740", Offset = "0x549F540", VA = "0x1854A0740")]
	public sbyte[] CMEOJKGPMOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54A1110", Offset = "0x549FF10", VA = "0x1854A1110")]
	public byte[] ODIJGPINGIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54A0DE0", Offset = "0x549FBE0", VA = "0x1854A0DE0")]
	public void LJNFEICKFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GLEGAEPNCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] DFEKEJNPLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int CLGKLHPKGGK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int CNJNJOHJLED = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool DBIDEAHKLJL;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding CFJNEOIAHHI;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int OJMFEEHJBLG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] MABEEIHMDEO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] LHCDIJPGOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x549D900", Offset = "0x549C700", VA = "0x18549D900")]
	public GLEGAEPNCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x549D860", Offset = "0x549C660", VA = "0x18549D860")]
	public GLEGAEPNCOB(bool MCOALDDGIHH, int IPEKJJDNEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x549D100", Offset = "0x549BF00", VA = "0x18549D100")]
	public static GLEGAEPNCOB FHOPBBIBLHC(string MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x549CB30", Offset = "0x549B930", VA = "0x18549CB30")]
	public void CIHPOFIEHGH(int BKOECBHHAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBC160", Offset = "0x1CBAF60", VA = "0x181CBC160")]
	public void KGLPDGAIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x549D6C0", Offset = "0x549C4C0", VA = "0x18549D6C0")]
	public void KEKONOMDKNC(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x549D380", Offset = "0x549C180", VA = "0x18549D380")]
	public void KEKONOMDKNC(double MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x549D2D0", Offset = "0x549C0D0", VA = "0x18549D2D0")]
	public void KEKONOMDKNC(long MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x549D2D0", Offset = "0x549C0D0", VA = "0x18549D2D0")]
	public void KEKONOMDKNC(ulong MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x549D1E0", Offset = "0x549BFE0", VA = "0x18549D1E0")]
	public void KEKONOMDKNC(int MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x549D1E0", Offset = "0x549BFE0", VA = "0x18549D1E0")]
	public void KEKONOMDKNC(uint MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x549D170", Offset = "0x549BF70", VA = "0x18549D170")]
	public void KEKONOMDKNC(char MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x549D170", Offset = "0x549BF70", VA = "0x18549D170")]
	public void KEKONOMDKNC(ushort MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x549D170", Offset = "0x549BF70", VA = "0x18549D170")]
	public void KEKONOMDKNC(short MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x549D320", Offset = "0x549C120", VA = "0x18549D320")]
	public void KEKONOMDKNC(sbyte MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x549D320", Offset = "0x549C120", VA = "0x18549D320")]
	public void KEKONOMDKNC(byte MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x549D760", Offset = "0x549C560", VA = "0x18549D760")]
	public void KEKONOMDKNC(byte[] HKPHNGEBIED, int PNNJJHFFONP, int GENFKPIGLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x549CE60", Offset = "0x549BC60", VA = "0x18549CE60")]
	public void OFFFEHIMNFK(sbyte[] HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x549CE60", Offset = "0x549BC60", VA = "0x18549CE60")]
	public void NBLHBAFMHAN(byte[] HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x549D270", Offset = "0x549C070", VA = "0x18549D270")]
	public void KEKONOMDKNC(bool MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x549D020", Offset = "0x549BE20", VA = "0x18549D020")]
	public void ECDFHCNMFPM(Array AOLOLCLABDH, int IKHEMCKALLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x549CF40", Offset = "0x549BD40", VA = "0x18549CF40")]
	public void ECDFHCNMFPM(float[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x549CBD0", Offset = "0x549B9D0", VA = "0x18549CBD0")]
	public void ECDFHCNMFPM(double[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x549CBD0", Offset = "0x549B9D0", VA = "0x18549CBD0")]
	public void ECDFHCNMFPM(long[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x549CBD0", Offset = "0x549B9D0", VA = "0x18549CBD0")]
	public void ECDFHCNMFPM(ulong[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x549CF40", Offset = "0x549BD40", VA = "0x18549CF40")]
	public void ECDFHCNMFPM(int[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x549CF40", Offset = "0x549BD40", VA = "0x18549CF40")]
	public void ECDFHCNMFPM(uint[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x549CCB0", Offset = "0x549BAB0", VA = "0x18549CCB0")]
	public void ECDFHCNMFPM(ushort[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x549CCB0", Offset = "0x549BAB0", VA = "0x18549CCB0")]
	public void ECDFHCNMFPM(short[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x549CE60", Offset = "0x549BC60", VA = "0x18549CE60")]
	public void ECDFHCNMFPM(bool[] MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x549CD90", Offset = "0x549BB90", VA = "0x18549CD90")]
	public void ECDFHCNMFPM(string[] MBDKMNBCLGF, int JLGHFJGIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x549D3D0", Offset = "0x549C1D0", VA = "0x18549D3D0")]
	public void KEKONOMDKNC(IPEndPoint KGPOHANMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x549D6B0", Offset = "0x549C4B0", VA = "0x18549D6B0")]
	public void KEKONOMDKNC(string MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x549D4A0", Offset = "0x549C2A0", VA = "0x18549D4A0")]
	public void KEKONOMDKNC(string MBDKMNBCLGF, int OGHEMJNHBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OFDGNHEGKOG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class KNKKEEPHDOO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong JOMDFJHIGDD;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA830", Offset = "0x3AB9630", VA = "0x183ABA830")]
		static KNKKEEPHDOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BMLLFBMOACM(NNCKABODGAF NCEKPOKKHOM, object NIOJNJHNOHI);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ADPPPGDMJHH<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public OFDGNHEGKOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public ADPPPGDMJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x368AC60", Offset = "0x3689A60", VA = "0x18368AC60")]
		internal void JONLANPCNMJ(NNCKABODGAF reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LBMCMLCIFGN<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OFDGNHEGKOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public LBMCMLCIFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3B2CB70", Offset = "0x3B2B970", VA = "0x183B2CB70")]
		internal void JONLANPCNMJ(NNCKABODGAF reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly ECNGKFHFDPM LMECEABKJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, BMLLFBMOACM> IIPMCKNMJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly GLEGAEPNCOB BOGOMAIIHPP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x54A1C60", Offset = "0x54A0A60", VA = "0x1854A1C60")]
	public OFDGNHEGKOG(int IKNAHFOECIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x23975F0", Offset = "0x23963F0", VA = "0x1823975F0", Slot = "4")]
	protected virtual ulong DCBFCOIMKOP<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x54A1AB0", Offset = "0x54A08B0", VA = "0x1854A1AB0", Slot = "5")]
	protected virtual BMLLFBMOACM CPCIAENNCBN(NNCKABODGAF NCEKPOKKHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2739770", Offset = "0x2738570", VA = "0x182739770", Slot = "6")]
	protected virtual void CKIJBPMGNMM<T>(GLEGAEPNCOB KALGFOLCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54A1BE0", Offset = "0x54A09E0", VA = "0x1854A1BE0")]
	public void HJBDAPIBDDD(NNCKABODGAF NCEKPOKKHOM, object NIOJNJHNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2739AE0", Offset = "0x27388E0", VA = "0x182739AE0")]
	public void LEKJKGMHOOK<T>(GLEGAEPNCOB KALGFOLCEKF, T LPKKDKFHMNJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x54A1A60", Offset = "0x54A0860", VA = "0x1854A1A60")]
	public void BLPDIJNFFFL(NNCKABODGAF NCEKPOKKHOM, object NIOJNJHNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2739960", Offset = "0x2738760", VA = "0x182739960")]
	public void FACGDNPLEJC<T>(Action<T> MGLFMMMDEIO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27397E0", Offset = "0x27385E0", VA = "0x1827397E0")]
	public void FACGDNPLEJC<T, TUserData>(Action<T, TUserData> MGLFMMMDEIO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PHAKPKNFAFJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x549DD10", Offset = "0x549CB10", VA = "0x18549DD10")]
	public PHAKPKNFAFJ(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LLLDHKEGMHL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x549E9E0", Offset = "0x549D7E0", VA = "0x18549E9E0")]
	public LLLDHKEGMHL(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ECNGKFHFDPM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum DBMNBMEPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BDFNJEOOFJM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public DBMNBMEPIPM MCBKDNIENIP;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4676130", Offset = "0x4674F30", VA = "0x184676130", Slot = "4")]
		public virtual void FFIHNOCNALB(MethodInfo EODCPPIAOCH, MethodInfo IBBBOFLHOBK, DBMNBMEPIPM HJCFEPLFGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void PEDKAILGBKG(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HAJGHKBEONM(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		protected BDFNJEOOFJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class ECCFBAMBFMM<TClass, TProperty> : BDFNJEOOFJM<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> JIAHAOCMEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> DGBGCJJAGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> MBCIECFNENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> MIABJLLBMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> CBPAAABAOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> GAPAJHBIELP;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3237270", Offset = "0x3236070", VA = "0x183237270", Slot = "7")]
		public override void KIJPLMNBAAF(TClass DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3237430", Offset = "0x3236230", VA = "0x183237430", Slot = "8")]
		public override void NGABPDPGHPA(TClass DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3237A50", Offset = "0x3236850", VA = "0x183237A50", Slot = "9")]
		public override void PEDKAILGBKG(TClass DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3236EF0", Offset = "0x3235CF0", VA = "0x183236EF0", Slot = "10")]
		public override void HAJGHKBEONM(TClass DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3235530", Offset = "0x3234330", VA = "0x183235530")]
		protected TProperty[] CADPDAPCJPL(TClass DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x32354C0", Offset = "0x32342C0", VA = "0x1832354C0")]
		protected TProperty[] AEOLOMPPJKE(TClass DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x32361B0", Offset = "0x3234FB0", VA = "0x1832361B0", Slot = "4")]
		public override void FFIHNOCNALB(MethodInfo EODCPPIAOCH, MethodInfo IBBBOFLHOBK, DBMNBMEPIPM HJCFEPLFGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3237B30", Offset = "0x3236930", VA = "0x183237B30")]
		protected ECCFBAMBFMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class FHKMMOFMNOG<TClass, TProperty> : ECCFBAMBFMM<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ADAFOEMCMJD(NNCKABODGAF CBMBPKNBJOB, [Out] TProperty HADBBBNBLBM);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IKCGBPNMPCO(GLEGAEPNCOB PCGLBNPPNBP, TProperty HADBBBNBLBM);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3600490", Offset = "0x35FF290", VA = "0x183600490", Slot = "5")]
		public override void ABPDDJNPFKA(TClass DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3600740", Offset = "0x35FF540", VA = "0x183600740", Slot = "6")]
		public override void LEKJKGMHOOK(TClass DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3600630", Offset = "0x35FF430", VA = "0x183600630", Slot = "7")]
		public override void KIJPLMNBAAF(TClass DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x36007B0", Offset = "0x35FF5B0", VA = "0x1836007B0", Slot = "8")]
		public override void NGABPDPGHPA(TClass DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x36008F0", Offset = "0x35FF6F0", VA = "0x1836008F0")]
		protected FHKMMOFMNOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class HANDKCKOIGE<T> : ECCFBAMBFMM<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3731250", Offset = "0x3730050", VA = "0x183731250", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3731330", Offset = "0x3730130", VA = "0x183731330", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37312C0", Offset = "0x37300C0", VA = "0x1837312C0", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3731390", Offset = "0x3730190", VA = "0x183731390", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public HANDKCKOIGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HPMPOIMOPIG<T> : ECCFBAMBFMM<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3761C90", Offset = "0x3760A90", VA = "0x183761C90", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3731330", Offset = "0x3730130", VA = "0x183731330", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3761D00", Offset = "0x3760B00", VA = "0x183761D00", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3731390", Offset = "0x3730190", VA = "0x183731390", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public HPMPOIMOPIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class CEICNLONGNA<T> : ECCFBAMBFMM<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x47FD200", Offset = "0x47FC000", VA = "0x1847FD200", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x35E4F00", Offset = "0x35E3D00", VA = "0x1835E4F00", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x47FD270", Offset = "0x47FC070", VA = "0x1847FD270", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35E4F60", Offset = "0x35E3D60", VA = "0x1835E4F60", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public CEICNLONGNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class FDLMBBIAIBB<T> : ECCFBAMBFMM<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x35E4E20", Offset = "0x35E3C20", VA = "0x1835E4E20", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35E4F00", Offset = "0x35E3D00", VA = "0x1835E4F00", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x35E4E90", Offset = "0x35E3C90", VA = "0x1835E4E90", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x35E4F60", Offset = "0x35E3D60", VA = "0x1835E4F60", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public FDLMBBIAIBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EOECJKNBCJD<T> : ECCFBAMBFMM<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x329D4E0", Offset = "0x329C2E0", VA = "0x18329D4E0", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x329D5C0", Offset = "0x329C3C0", VA = "0x18329D5C0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x329D550", Offset = "0x329C350", VA = "0x18329D550", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public EOECJKNBCJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class AAOHJOIPLID<T> : ECCFBAMBFMM<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x367AF00", Offset = "0x3679D00", VA = "0x18367AF00", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x329D5C0", Offset = "0x329C3C0", VA = "0x18329D5C0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x367AF70", Offset = "0x3679D70", VA = "0x18367AF70", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public AAOHJOIPLID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class FHDABKHOANK<T> : ECCFBAMBFMM<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x35FF850", Offset = "0x35FE650", VA = "0x1835FF850", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x35FF930", Offset = "0x35FE730", VA = "0x1835FF930", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x35FF8C0", Offset = "0x35FE6C0", VA = "0x1835FF8C0", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x35FF990", Offset = "0x35FE790", VA = "0x1835FF990", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public FHDABKHOANK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class LOJABAOFPBC<T> : ECCFBAMBFMM<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x35FF850", Offset = "0x35FE650", VA = "0x1835FF850", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x35FF930", Offset = "0x35FE730", VA = "0x1835FF930", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B7C870", Offset = "0x3B7B670", VA = "0x183B7C870", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x35FF990", Offset = "0x35FE790", VA = "0x1835FF990", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public LOJABAOFPBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PNDENKADLFG<T> : ECCFBAMBFMM<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4052DB0", Offset = "0x4051BB0", VA = "0x184052DB0", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4052E90", Offset = "0x4051C90", VA = "0x184052E90", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4052E20", Offset = "0x4051C20", VA = "0x184052E20", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3731390", Offset = "0x3730190", VA = "0x183731390", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public PNDENKADLFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DFEIHPPLJMH<T> : ECCFBAMBFMM<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F44810", Offset = "0x4F43610", VA = "0x184F44810", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4F448F0", Offset = "0x4F436F0", VA = "0x184F448F0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F44880", Offset = "0x4F43680", VA = "0x184F44880", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public DFEIHPPLJMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KBHDDJIPFPP<T> : ECCFBAMBFMM<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A89CD0", Offset = "0x3A88AD0", VA = "0x183A89CD0", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A89DB0", Offset = "0x3A88BB0", VA = "0x183A89DB0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A89D40", Offset = "0x3A88B40", VA = "0x183A89D40", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x35FF990", Offset = "0x35FE790", VA = "0x1835FF990", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C480", VA = "0x18329D680")]
		public KBHDDJIPFPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class OHEIEOCBBIM<T> : FHKMMOFMNOG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3880", Offset = "0x3EF2680", VA = "0x183EF3880", Slot = "12")]
		protected override void IKCGBPNMPCO(GLEGAEPNCOB PCGLBNPPNBP, char HADBBBNBLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3850", Offset = "0x3EF2650", VA = "0x183EF3850", Slot = "11")]
		protected override void ADAFOEMCMJD(NNCKABODGAF CBMBPKNBJOB, [Out] char HADBBBNBLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x36AFCE0", Offset = "0x36AEAE0", VA = "0x1836AFCE0")]
		public OHEIEOCBBIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BHNNKDBDFOP<T> : FHKMMOFMNOG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x46A8390", Offset = "0x46A7190", VA = "0x1846A8390", Slot = "12")]
		protected override void IKCGBPNMPCO(GLEGAEPNCOB PCGLBNPPNBP, IPEndPoint HADBBBNBLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x46A8350", Offset = "0x46A7150", VA = "0x1846A8350", Slot = "11")]
		protected override void ADAFOEMCMJD(NNCKABODGAF CBMBPKNBJOB, [Out] IPEndPoint HADBBBNBLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x36AFCE0", Offset = "0x36AEAE0", VA = "0x1836AFCE0")]
		public BHNNKDBDFOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JOEPJILJGNO<T> : ECCFBAMBFMM<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int PFFHBHOKNDG;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A48EC0", Offset = "0x3A47CC0", VA = "0x183A48EC0")]
		public JOEPJILJGNO(int OGHEMJNHBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A48D00", Offset = "0x3A47B00", VA = "0x183A48D00", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A48DE0", Offset = "0x3A47BE0", VA = "0x183A48DE0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A48D70", Offset = "0x3A47B70", VA = "0x183A48D70", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A48E50", Offset = "0x3A47C50", VA = "0x183A48E50", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FNNADLKCHKA<T> : BDFNJEOOFJM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo LOLLLJHDCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type MKFFJJHJDHL;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x36239B0", Offset = "0x36227B0", VA = "0x1836239B0")]
		public FNNADLKCHKA(PropertyInfo LEDLMNEPNJE, Type PLOAHKLGKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x36236C0", Offset = "0x36224C0", VA = "0x1836236C0", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3623840", Offset = "0x3622640", VA = "0x183623840", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x36237E0", Offset = "0x36225E0", VA = "0x1836237E0", Slot = "7")]
		public override void KIJPLMNBAAF(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x36238F0", Offset = "0x36226F0", VA = "0x1836238F0", Slot = "8")]
		public override void NGABPDPGHPA(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3623950", Offset = "0x3622750", VA = "0x183623950", Slot = "9")]
		public override void PEDKAILGBKG(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3623780", Offset = "0x3622580", VA = "0x183623780", Slot = "10")]
		public override void HAJGHKBEONM(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class JBHPELCBJLO<T> : FNNADLKCHKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
		public JBHPELCBJLO(PropertyInfo LEDLMNEPNJE, Type PLOAHKLGKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39A5810", Offset = "0x39A4610", VA = "0x1839A5810", Slot = "5")]
		public override void ABPDDJNPFKA(T DFLJIJDOMLH, NNCKABODGAF CBMBPKNBJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39A58D0", Offset = "0x39A46D0", VA = "0x1839A58D0", Slot = "6")]
		public override void LEKJKGMHOOK(T DFLJIJDOMLH, GLEGAEPNCOB PCGLBNPPNBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class KJLOBEDBGMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static KJLOBEDBGMF<T> CEIKCOHBGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly BDFNJEOOFJM<T>[] FDDIMJINCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int HEHFLJCNFIL;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9EC0", Offset = "0x3AA8CC0", VA = "0x183AA9EC0")]
		public KJLOBEDBGMF(List<BDFNJEOOFJM<T>> ICHOBOEDDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9E10", Offset = "0x3AA8C10", VA = "0x183AA9E10")]
		public void LEKJKGMHOOK(T FGANJEAKCMA, GLEGAEPNCOB KALGFOLCEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9D60", Offset = "0x3AA8B60", VA = "0x183AA9D60")]
		public void ABPDDJNPFKA(T FGANJEAKCMA, NNCKABODGAF NCEKPOKKHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class JLBINPDPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BDFNJEOOFJM<T> NAKCAFGMIJA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private GLEGAEPNCOB MDNCAKOCEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int LNFMBNJKJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, JLBINPDPMCM> AIIDPOLICMD;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5490AD0", Offset = "0x548F8D0", VA = "0x185490AD0")]
	public ECNGKFHFDPM(int IKNAHFOECIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2489270", Offset = "0x2488070", VA = "0x182489270")]
	private KJLOBEDBGMF<T> MJFLDCLIJHA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2489260", Offset = "0x2488060", VA = "0x182489260")]
	public void JOJFLFCPNKF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x24891E0", Offset = "0x2487FE0", VA = "0x1824891E0")]
	public bool HONCKFFEJNK<T>(NNCKABODGAF NCEKPOKKHOM, T KEENMLGJEKM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x248A160", Offset = "0x2488F60", VA = "0x18248A160")]
	public void OKNECDBNGHE<T>(GLEGAEPNCOB KALGFOLCEKF, T FGANJEAKCMA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OMLINKCOMGA
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime IHHGLBKGPCM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] CLMPJBAAMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DNBDFCNFDGE DKNCKAMKELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x54A3840", Offset = "0x54A2640", VA = "0x1854A3840")]
		get
		{
			return default(DNBDFCNFDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int AFMJCAFOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x54A3870", Offset = "0x54A2670", VA = "0x1854A3870")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x54A2D90", Offset = "0x54A1B90", VA = "0x1854A2D90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEMHHAMANBP MCFEFCOMAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x54A2D60", Offset = "0x54A1B60", VA = "0x1854A2D60")]
		get
		{
			return default(IEMHHAMANBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x54A3460", Offset = "0x54A2260", VA = "0x1854A3460")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int LMEEDBFANLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x54A3930", Offset = "0x54A2730", VA = "0x1854A3930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint IIIBKMOJOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x54A34D0", Offset = "0x54A22D0", VA = "0x1854A34D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? BFGFODGGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x54A3BC0", Offset = "0x54A29C0", VA = "0x1854A3BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? DDCNDOCHNND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x54A3260", Offset = "0x54A2060", VA = "0x1854A3260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? LKJNLNGDDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x54A34A0", Offset = "0x54A22A0", VA = "0x1854A34A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x54A3550", Offset = "0x54A2350", VA = "0x1854A3550")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DKFGFAFBBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA302A0", Offset = "0xA2F0A0", VA = "0x180A302A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88EDE0", Offset = "0x88DBE0", VA = "0x18088EDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54A3C50", Offset = "0x54A2A50", VA = "0x1854A3C50")]
	public OMLINKCOMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54A3F70", Offset = "0x54A2D70", VA = "0x1854A3F70")]
	internal OMLINKCOMGA(byte[] IJBHMPFLJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54A3720", Offset = "0x54A2520", VA = "0x1854A3720")]
	public static OMLINKCOMGA KMJINCOCGFE(byte[] IJBHMPFLJAK, DateTime JHELLJMCDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54A2FA0", Offset = "0x54A1DA0", VA = "0x1854A2FA0")]
	internal void DEJNKNGMEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54A2DD0", Offset = "0x54A1BD0", VA = "0x1854A2DD0")]
	private void CAPKKDJPJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54A39C0", Offset = "0x54A27C0", VA = "0x1854A39C0")]
	private DateTime? PGLLPHACEFJ(int PNNJJHFFONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54A3290", Offset = "0x54A2090", VA = "0x1854A3290")]
	private void GBILGBHACPE(int PNNJJHFFONP, DateTime? MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54A2C90", Offset = "0x54A1A90", VA = "0x1854A2C90")]
	private ulong ADFEDHENBGO(int PNNJJHFFONP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x54A31A0", Offset = "0x54A1FA0", VA = "0x1854A31A0")]
	private void DMKAIEDNPOA(int PNNJJHFFONP, ulong MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x54A38A0", Offset = "0x54A26A0", VA = "0x1854A38A0")]
	private uint MGCCNPLFGCO(int PNNJJHFFONP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x537DB80", Offset = "0x537C980", VA = "0x18537DB80")]
	private static uint OPJDPFIANGB(uint PCOMFHJKLCD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x54A3960", Offset = "0x54A2760", VA = "0x1854A3960")]
	private static ulong OPJDPFIANGB(ulong PCOMFHJKLCD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DNBDFCNFDGE
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
public enum IEMHHAMANBP
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class PLGMFGCIIOP
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int IMNMCDEFIEK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int CKNHCGONPGI = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int KFGPGDEPHFF = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint FGNPKBLHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int BNCPGCPAADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int PEEMBIDGDCI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HHCEHLBMNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x54A4110", Offset = "0x54A2F10", VA = "0x1854A4110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x54A4020", Offset = "0x54A2E20", VA = "0x1854A4020")]
	public bool AGCJFLKCPCG(ENOLHDPFEJM KJGEKKNGFPF, int HKAMOIHPHHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class OIJPMCFDGEO : ENOLHDPFEJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket KJGEKKNGFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly FBMHJFGFNCJ KNCNCNKFNDE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short MGJDHIGHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x54A1FE0", Offset = "0x54A0DE0", VA = "0x1854A1FE0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BHCBAFDPEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x54A1FC0", Offset = "0x54A0DC0", VA = "0x1854A1FC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint BELKAJOPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x54A1FA0", Offset = "0x54A0DA0", VA = "0x1854A1FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily EKHGHHMNOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B194A0", Offset = "0x3B182A0", VA = "0x183B194A0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x54A2710", Offset = "0x54A1510", VA = "0x1854A2710")]
	public OIJPMCFDGEO(AddressFamily NHPJDKJMFPO, FBMHJFGFNCJ KNCNCNKFNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x54A2110", Offset = "0x54A0F10", VA = "0x1854A2110", Slot = "8")]
	public bool LENBOJOKPOO(IPEndPoint KGPOHANMDNH, PKJCBAJDOIC IDDHHCAAOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x54A26D0", Offset = "0x54A14D0", VA = "0x1854A26D0", Slot = "9")]
	public int NJFEEOEKLFJ(byte[] FHEAENNOLNB, int PNNJJHFFONP, int GENDLFFGOMM, IPEndPoint IPGJBHHALFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x54A2020", Offset = "0x54A0E20", VA = "0x1854A2020", Slot = "10")]
	public int KOMGPOJKOKJ(byte[] FHEAENNOLNB, EndPoint ANPCDIGPILJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x54A2000", Offset = "0x54A0E00", VA = "0x1854A2000", Slot = "11")]
	public void JIEJGNBDHFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface ENOLHDPFEJM
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short MGJDHIGHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int BHCBAFDPEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint BELKAJOPNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily EKHGHHMNOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LENBOJOKPOO(IPEndPoint KGPOHANMDNH, PKJCBAJDOIC IDDHHCAAOBA);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int NJFEEOEKLFJ(byte[] FHEAENNOLNB, int PNNJJHFFONP, int GENDLFFGOMM, IPEndPoint IPGJBHHALFK);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KOMGPOJKOKJ(byte[] FHEAENNOLNB, EndPoint IPGJBHHALFK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIEJGNBDHFM();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NLHPJIKFNHD : IEquatable<NLHPJIKFNHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long LMMFDMLJAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long HNNIDAHJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long AGBHKKDAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int FHCMODIGHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int PKDMGAHKFPL;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x54A04B0", Offset = "0x549F2B0", VA = "0x1854A04B0")]
	public NLHPJIKFNHD(byte[] CFJMKBIDFBN, int PMCOLPPJCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B6700", Offset = "0x7B5500", VA = "0x1807B6700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x54A03C0", Offset = "0x549F1C0", VA = "0x1854A03C0", Slot = "4")]
	public bool Equals(NLHPJIKFNHD GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x54A0400", Offset = "0x549F200", VA = "0x1854A0400", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class BNHDOGFCIKO : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] BCPPHCENOJH;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HOBNCOGCDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int OFLIHLJAEID;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
	protected HOBNCOGCDPL(int FOIFFGGEHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EIEDDOJJBKH(IPEndPoint KGPOHANMDNH, byte[] HKPHNGEBIED, int PNNJJHFFONP, int GENFKPIGLNJ);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AAPFCBCACAG(IPEndPoint KGPOHANMDNH, byte[] HKPHNGEBIED, int PNNJJHFFONP, int GENFKPIGLNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DCFKMDACABH : HOBNCOGCDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider AHJDFJAEGEP;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator GECDPHEGMLE;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x548F8B0", Offset = "0x548E6B0", VA = "0x18548F8B0")]
	public DCFKMDACABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x548F180", Offset = "0x548DF80", VA = "0x18548F180")]
	public void DOIJOIIHNCP(IPEndPoint KGPOHANMDNH, byte[] IDGIKKEFDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x548F0A0", Offset = "0x548DEA0", VA = "0x18548F0A0")]
	public void CFNGGHACODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x548F010", Offset = "0x548DE10", VA = "0x18548F010")]
	private byte[] BGMCJEABFLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x548F3C0", Offset = "0x548E1C0", VA = "0x18548F3C0", Slot = "4")]
	public override void EIEDDOJJBKH(IPEndPoint KGPOHANMDNH, byte[] HKPHNGEBIED, int PNNJJHFFONP, int GENFKPIGLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x548EC70", Offset = "0x548DA70", VA = "0x18548EC70", Slot = "5")]
	public override void AAPFCBCACAG(IPEndPoint KGPOHANMDNH, byte[] HKPHNGEBIED, int PNNJJHFFONP, int GENFKPIGLNJ)
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
