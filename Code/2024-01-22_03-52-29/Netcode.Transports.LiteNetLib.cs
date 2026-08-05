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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FFAFAFDEFGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KJHHKAMJEHN
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
		private NetworkManager KKGFPIAINOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ELDEAFMKIFJ> JBOIDKMKIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NJOMLOBNNBL BDNMMCKEHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] AMBPJNLAJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KJHHKAMJEHN HHDCPGODAFI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong JOLFKFKDBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool PBIGCIGLHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x54D7420", Offset = "0x54D6820", VA = "0x1854D7420", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x54D6920", Offset = "0x54D5D20", VA = "0x1854D6920")]
		public void RecRoom_SetEncryptionInfo(ulong NADBCOLODMM, byte[] CONEAMPCFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x54D6900", Offset = "0x54D5D00", VA = "0x1854D6900")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x54D67A0", Offset = "0x54D5BA0", VA = "0x1854D67A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x54D7320", Offset = "0x54D6720", VA = "0x1854D7320")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x54D6B20", Offset = "0x54D5F20", VA = "0x1854D6B20", Slot = "6")]
		public override void Send(ulong CFLCIDJGEPC, ArraySegment<byte> GMLIPIALCHN, NetworkDelivery IKNCAEEFAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x54D68C0", Offset = "0x54D5CC0", VA = "0x1854D68C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong CFLCIDJGEPC, [Out] ArraySegment<byte> JFKHFDHADBL, [Out] float BNPOHKDDAJL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54D6E10", Offset = "0x54D6210", VA = "0x1854D6E10", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x54D7240", Offset = "0x54D6640", VA = "0x1854D7240", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x54D61C0", Offset = "0x54D55C0", VA = "0x1854D61C0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong CFLCIDJGEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x54D6070", Offset = "0x54D5470", VA = "0x1854D6070", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x54D6330", Offset = "0x54D5730", VA = "0x1854D6330", Slot = "12")]
		public override ulong GetCurrentRtt(ulong CFLCIDJGEPC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x54D6DA0", Offset = "0x54D61A0", VA = "0x1854D6DA0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x54D65E0", Offset = "0x54D59E0", VA = "0x1854D65E0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager KKGFPIAINOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x54D5C40", Offset = "0x54D5040", VA = "0x1854D5C40")]
		private CEHBFOLFJCE AEJIDDMAIAM(NetworkDelivery KHENBEDBKDI)
		{
			return default(CEHBFOLFJCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x54D5D10", Offset = "0x54D5110", VA = "0x1854D5D10", Slot = "15")]
		private void BAJBOGAGFKL(ELDEAFMKIFJ PAECIDMLBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x54D5F30", Offset = "0x54D5330", VA = "0x1854D5F30", Slot = "16")]
		private void DDNBGDGKKMG(ELDEAFMKIFJ PAECIDMLBNB, BJMCHEGDHIJ JBJONOHPCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "17")]
		private void PDIOKCJICOH(IPEndPoint JAHNDKCJALJ, SocketError OPLGIOJPLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54D63D0", Offset = "0x54D57D0", VA = "0x1854D63D0", Slot = "18")]
		private void HPLNACDBHAJ(ELDEAFMKIFJ PAECIDMLBNB, DBBPDLELENO MAACBPKBLAG, byte EIDJFLMGGPA, CEHBFOLFJCE FLAOLKPEEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54D5E50", Offset = "0x54D5250", VA = "0x1854D5E50")]
		private void BPCGLEPMEPA(int KKEOKHMHDHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "19")]
		private void BFGFDNJFJPE(IPEndPoint MEAEICACBON, DBBPDLELENO MAACBPKBLAG, BPLJCFCDKCD JJLGGFMMKGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "20")]
		private void LCJFPAAJHFP(ELDEAFMKIFJ PAECIDMLBNB, int LDPOIJPJELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54D5DD0", Offset = "0x54D51D0", VA = "0x1854D5DD0", Slot = "21")]
		private void BIAPGGNADCD(ECNPAAMNCCJ MGFKAMLOFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x54D6890", Offset = "0x54D5C90", VA = "0x1854D6890")]
		private ulong PCBNJABFLBF(ELDEAFMKIFJ PAECIDMLBNB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x54D5E30", Offset = "0x54D5230", VA = "0x1854D5E30")]
		private static int BLNKIJONLHA(float PPLAIKBLALP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54D7340", Offset = "0x54D6740", VA = "0x1854D7340")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OBPNOEKIFCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ELDEAFMKIFJ IPCDNOMANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<MJNGDMKOIHM> LOKPIEKHLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int MOKFBOKNBNP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54E02D0", Offset = "0x54DF6D0", VA = "0x1854E02D0")]
	protected OBPNOEKIFCC(ELDEAFMKIFJ PAECIDMLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54E0270", Offset = "0x54DF670", VA = "0x1854E0270")]
	public void DNIEKHEOEFM(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54E01F0", Offset = "0x54DF5F0", VA = "0x1854E01F0")]
	protected void DLPIGOIHPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x54E01B0", Offset = "0x54DF5B0", VA = "0x1854E01B0")]
	public bool BBJCNGGFJKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ECEFLFPPLLD();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CFKPMBLLPKA(MJNGDMKOIHM DKEJJMMAPEH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum MNEKMBHBMNE
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
public class ECNPAAMNCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NJOMLOBNNBL PNGPIBJMENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int MMOENNDMMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NABOEGPLHJA GEKJPLNLGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint PKEALHKADJI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal MNEKMBHBMNE NJIHDNKAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E80", Offset = "0x7B8280", VA = "0x1807B8E80")]
		[CompilerGenerated]
		get
		{
			return default(MNEKMBHBMNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C5160", Offset = "0x8C4560", VA = "0x1808C5160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x54CDB20", Offset = "0x54CCF20", VA = "0x1854CDB20")]
	internal void HHNCMFMMJAM(NABOEGPLHJA ONBJOIGIBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x54CDA90", Offset = "0x54CCE90", VA = "0x1854CDA90")]
	private bool CAMNKFGPMDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x54CDB80", Offset = "0x54CCF80", VA = "0x1854CDB80")]
	internal ECNPAAMNCCJ(IPEndPoint MEAEICACBON, NABOEGPLHJA DDBGPJILKMK, NJOMLOBNNBL IBMIOMMKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x54CDAC0", Offset = "0x54CCEC0", VA = "0x1854CDAC0")]
	public ELDEAFMKIFJ ECJPFLLDCIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BPLJCFCDKCD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AENNDFMMBCC
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
public struct BJMCHEGDHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public AENNDFMMBCC ENDGMKOMELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError MLMPEAOINNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DBBPDLELENO OEKLCNEFPOB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FFAFAFDEFGC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJILIIBNDAO(ELDEAFMKIFJ PAECIDMLBNB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MONPEBFMJNK(ELDEAFMKIFJ PAECIDMLBNB, BJMCHEGDHIJ JBJONOHPCOK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHGPPCDJFLN(IPEndPoint JAHNDKCJALJ, SocketError OPLGIOJPLFF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGBLCGLMEPM(ELDEAFMKIFJ PAECIDMLBNB, DBBPDLELENO MAACBPKBLAG, byte EIDJFLMGGPA, CEHBFOLFJCE FLAOLKPEEMK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDJEEIEDOGK(IPEndPoint MEAEICACBON, DBBPDLELENO MAACBPKBLAG, BPLJCFCDKCD JJLGGFMMKGA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBBLEKLFMNH(ELDEAFMKIFJ PAECIDMLBNB, int LDPOIJPJELN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDBEGGMONBP(ECNPAAMNCCJ MGFKAMLOFJH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CBOICOHBPBA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKBFGBBGFID(ELDEAFMKIFJ PAECIDMLBNB, object CONPKEPKLCH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAJEHDLALJC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONFGAOIBAAE(JLPBIDAFGPP DKEJJMMAPEH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AKNCHBAKLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFPGALOLFGF(ELDEAFMKIFJ PAECIDMLBNB, IPEndPoint KGPHCJBPGPN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NABOEGPLHJA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int GPILKNPMLKG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long FMJAOIBJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte BPKEJDMBEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] EDKANHKFFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MNLPDEICHPD LGDPHHJAFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int MNAANOMJOHC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x54D9170", Offset = "0x54D8570", VA = "0x1854D9170")]
	private NABOEGPLHJA(long AMFKIKBEHAN, byte KCLJPNJJHGI, int NLDMFIFGFAP, byte[] BDAAKBDCPPO, MNLPDEICHPD GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x54D8D10", Offset = "0x54D8110", VA = "0x1854D8D10")]
	public static int DHIKMINCNKL(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x54D8F50", Offset = "0x54D8350", VA = "0x1854D8F50")]
	public static NABOEGPLHJA OPBKCOKLHOL(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54D8D70", Offset = "0x54D8170", VA = "0x1854D8D70")]
	public static MJNGDMKOIHM KFKBJMNHPJI(CABDOBDNBBH KALKCFOBLEE, SocketAddress JGNCDKJAECJ, long DPCOPPEGOHJ, int NLDMFIFGFAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LAPADDABKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long FMJAOIBJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte BPKEJDMBEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int MNAANOMJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool ENFIJCKCLPK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x54D5BF0", Offset = "0x54D4FF0", VA = "0x1854D5BF0")]
	private LAPADDABKCI(long AMFKIKBEHAN, byte KCLJPNJJHGI, int MNNOPDDEPGG, bool EDJBFODEKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x54D5AA0", Offset = "0x54D4EA0", VA = "0x1854D5AA0")]
	public static LAPADDABKCI OPBKCOKLHOL(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x54D59B0", Offset = "0x54D4DB0", VA = "0x1854D59B0")]
	public static MJNGDMKOIHM KFKBJMNHPJI(long DPCOPPEGOHJ, byte KIJCPOJPPMA, int KCJNDLGKFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x54D58B0", Offset = "0x54D4CB0", VA = "0x1854D58B0")]
	public static MJNGDMKOIHM FIAFNOOLIGO(ELDEAFMKIFJ PAECIDMLBNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ABEBAHGEAFA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OMFCAHCCOMK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKELFBHKKOP(IPEndPoint ILCBEAEJENG, IPEndPoint MEAEICACBON, string KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHDKJIGLEDP(IPEndPoint NCNEBJNBLLL, ABEBAHGEAFA KHENBEDBKDI, string KNOHBODGPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HJHMGBPKLEG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KIJHMDPJEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint EJKFHJILCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint PKEALHKADJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string GPJHEAJLCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DKNNOIPMJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint NPOHDAJJHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ABEBAHGEAFA IIJIPCLFFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string GPJHEAJLCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class PHEGFLFILBC
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint AOMCBEMKPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GPJHEAJLCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PHEGFLFILBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class GKPHJBOCMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint AOMCBEMKPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint CGKDFGOLAPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GPJHEAJLCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GKPHJBOCMHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MNBDLGCBCGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GPJHEAJLCIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KBDGMBHKMFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792D10", VA = "0x180793910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MNBDLGCBCGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NJOMLOBNNBL JHMKIKDHHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<KIJHMDPJEHN> GIHONCPGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DKNNOIPMJEJ> PGBGDDEINMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MNLPDEICHPD GJOHMHDNOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CABDOBDNBBH EKOMABKOIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PBCMAGHFCAP DAKPFJPLICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private OMFCAHCCOMK HEFDDBNFMPI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int EFCGNKGOPAD = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool IGABDPPADNO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x54D3AF0", Offset = "0x54D2EF0", VA = "0x1854D3AF0")]
	internal HJHMGBPKLEG(NJOMLOBNNBL PFHAHHMJGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x54D3660", Offset = "0x54D2A60", VA = "0x1854D3660")]
	internal void FLIGOBAPKLM(IPEndPoint DLNFJMEIHCE, MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x261BB80", Offset = "0x261AF80", VA = "0x18261BB80")]
	private void BMCAACKFALF<T>(T DKEJJMMAPEH, IPEndPoint GOOANMNBGEP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x54D37C0", Offset = "0x54D2BC0", VA = "0x1854D37C0")]
	private void HKELFBHKKOP(PHEGFLFILBC LOMMKNPHHNK, IPEndPoint DLNFJMEIHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x54D3500", Offset = "0x54D2900", VA = "0x1854D3500")]
	private void BDJIIGLGIKA(GKPHJBOCMHJ LOMMKNPHHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x54D3950", Offset = "0x54D2D50", VA = "0x1854D3950")]
	private void IKMLMCNHCHF(MNBDLGCBCGN LOMMKNPHHNK, IPEndPoint DLNFJMEIHCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CEHBFOLFJCE : byte
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
public enum LPOEGFPEGEN : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JOPCECANDPM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] AIKNHHBPBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int KLOBPIALHCN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int DLFFCFNEBHC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CHHGEAHJFNL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54CD0A0", Offset = "0x54CC4A0", VA = "0x1854CD0A0")]
	public CHHGEAHJFNL(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FBAEPMKJEKN : CHHGEAHJFNL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x54CD0A0", Offset = "0x54CC4A0", VA = "0x1854CD0A0")]
	public FBAEPMKJEKN(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EPDJFOKKMMH
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
public interface LDBNOBKKNHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOOONKFBOJM(EPDJFOKKMMH KKDOPNDIFNM, string LNCBDEONNFN, params object[] CNLJFDAGKBD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CBJPLDJAKFG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static LDBNOBKKNHJ BIPJNOLLEBP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object ENAFNNLFPPI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x54CC7F0", Offset = "0x54CBBF0", VA = "0x1854CC7F0")]
	private static void IOGLLCKFDHK(EPDJFOKKMMH DPIGKBHMLAD, string LNCBDEONNFN, params object[] CNLJFDAGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x54CC6D0", Offset = "0x54CBAD0", VA = "0x1854CC6D0")]
	internal static void GLJOFFMJHKP(string LNCBDEONNFN, params object[] CNLJFDAGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x54CC730", Offset = "0x54CBB30", VA = "0x1854CC730")]
	internal static void GLMOCIAGJBJ(string LNCBDEONNFN, params object[] CNLJFDAGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54CC790", Offset = "0x54CBB90", VA = "0x1854CC790")]
	internal static void HBOPBGKGJML(string LNCBDEONNFN, params object[] CNLJFDAGKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum GAGIOMFLELC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DBBPDLELENO : MNLPDEICHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private MJNGDMKOIHM IADILLPFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly NJOMLOBNNBL LLBPAHEEBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OKMKPMMDAIG DCBOMGFJHPP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54CD1D0", Offset = "0x54CC5D0", VA = "0x1854CD1D0")]
	internal DBBPDLELENO(NJOMLOBNNBL GPNCNDIBNOH, OKMKPMMDAIG NDBBAACHBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54CD160", Offset = "0x54CC560", VA = "0x1854CD160")]
	internal void LFDHFMGFIHA(MJNGDMKOIHM DKEJJMMAPEH, int IMBINAPMIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54CD0B0", Offset = "0x54CC4B0", VA = "0x1854CD0B0")]
	internal void FMADNHFELGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54CD130", Offset = "0x54CC530", VA = "0x1854CD130")]
	public void HEEIGJLAPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OKMKPMMDAIG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IOLNLIBMBGK
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
	public OKMKPMMDAIG PBNNGCBPFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public IOLNLIBMBGK IIJIPCLFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ELDEAFMKIFJ IPCDNOMANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint PKEALHKADJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object GPJFJENJHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int CNBPIIFEBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError GDAJBOIADBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public AENNDFMMBCC OOBJDCLKFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public ECNPAAMNCCJ PHBNJFDIKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public CEHBFOLFJCE HGNPCHPICHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte BAOEFICGDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly DBBPDLELENO JDIAECJKCCN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54E0950", Offset = "0x54DFD50", VA = "0x1854E0950")]
	public OKMKPMMDAIG(NJOMLOBNNBL GPNCNDIBNOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NJOMLOBNNBL : IEnumerable<ELDEAFMKIFJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class ODFNABLACHC : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x54E0370", Offset = "0x54DF770", VA = "0x1854E0370", Slot = "4")]
		public bool Equals(IPEndPoint FHDILOGEHPC, IPEndPoint ICKJJDCCMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4FC05A0", Offset = "0x4FBF9A0", VA = "0x184FC05A0", Slot = "5")]
		public int GetHashCode(IPEndPoint DFFBALIDCLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ODFNABLACHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct MFHIAPCKLDB : IEnumerator<ELDEAFMKIFJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly ELDEAFMKIFJ JCEGLPJEOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ELDEAFMKIFJ NPMPGAJLIAG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ELDEAFMKIFJ POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8860F0", VA = "0x180886CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xE9EBB0", Offset = "0xE9DFB0", VA = "0x180E9EBB0")]
		public MFHIAPCKLDB(ELDEAFMKIFJ GIFLIOHDCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x54D7440", Offset = "0x54D6840", VA = "0x1854D7440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x54D7490", Offset = "0x54D6890", VA = "0x1854D7490", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread LCMOCNLOFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool MEMOBGJKMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent IJNHHGDIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OKMKPMMDAIG> GKPBLGCGDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OKMKPMMDAIG> MCLCAALEJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OKMKPMMDAIG FNBPMLINONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FFAFAFDEFGC GDIBDEEHKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CBOICOHBPBA CFKIJHDLOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly GAJEHDLALJC LGCDPAAMAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AKNCHBAKLNJ JCIMMBGKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, ELDEAFMKIFJ> FHGJOMLJPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, ECNPAAMNCCJ> GCCFGONMCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, HOEPEOCBIFO> LAKDKMNHNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim NEDJELFONHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ELDEAFMKIFJ MFLEIEPMPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int CDEHHKOJKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ELDEAFMKIFJ> LJGGBIBHOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ELDEAFMKIFJ[] GIHDAEFODOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HINEDBPOBIK PNJCIFJAOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int OIKDAJCOJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NNJJNPOECNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte LKOIECENDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object GBFIKCNNMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool ABDCBJODHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool LMJLAHDFBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int MBLKMECHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int NIGDMGJKJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int COJAJJLFKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HKFMOAMPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GFAJHONEBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool JKLGBCDGBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CFJCADCIKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CAKJINMLNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int DIMDCEOPBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool IGABDPPADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool NIICELLHGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ENKICACIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool CEFNKHMNPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PKIPMMPAKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int OADIEOOLOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool KFIGDPDBBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly CBNAINCGKNA OEMOHHFPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool DEFNKGIHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HJHMGBPKLEG ECOPIHGOGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool CIMNBHNGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public GAGIOMFLELC GCLPEIHDHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int JPPOPHANIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KGJEBGNOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool JFMCGHJPIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GCAKAMJBPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool JKPECMHHIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private MJNGDMKOIHM NFBAEIDFGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int AHINJNJBHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object BJCBPHKJPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MJNGDMKOIHM JCFADOEKLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MDPKDBLOAGF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int PLHGOEJPOBL = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int OJACDCCHCIG = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HFEKCBBOMAJ LBINNHPDIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private HFEKCBBOMAJ GLFCBAFGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread BDLECFBKDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NNEDBKEGGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint KEIEKDNCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint IGDANHIHINA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] KKHEDBNHMBH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] AIINPDGODNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<KPLJADDJLIH, IPEndPoint> ONFGOKPBFHH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress CLPIHLLMFAP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool APFNGIPMCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int JCPPACDNCID;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ILJPHGMNCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BE0", Offset = "0x9D4FE0", VA = "0x1809D5BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA63C60", Offset = "0xA63060", VA = "0x180A63C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OPPDBJFPJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x155B440", Offset = "0x155A840", VA = "0x18155B440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x155A270", Offset = "0x1559670", VA = "0x18155A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte KIIIAMNANCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84BCC0", Offset = "0x84B0C0", VA = "0x18084BCC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KCHICBGLMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54DA420", Offset = "0x54D9820", VA = "0x1854DA420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short JCKEBFMGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x54DD620", Offset = "0x54DCA20", VA = "0x1854DD620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54DA380", Offset = "0x54D9780", VA = "0x1854DA380")]
	public void CJIAIIBICJL(IPEndPoint JAHNDKCJALJ, byte[] CONEAMPCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54DF2F0", Offset = "0x54DE6F0", VA = "0x1854DF2F0")]
	public void OJBBCHCEGPA(IPEndPoint JAHNDKCJALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x54DF730", Offset = "0x54DEB30", VA = "0x1854DF730")]
	private bool POJGKMBGBOM(IPEndPoint JAHNDKCJALJ, [Out] ELDEAFMKIFJ PAECIDMLBNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x54DAC50", Offset = "0x54DA050", VA = "0x1854DAC50")]
	private void EODNNLLODOI(ELDEAFMKIFJ PAECIDMLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x54DCF50", Offset = "0x54DC350", VA = "0x1854DCF50")]
	private void LMGKLIIHOIE(ELDEAFMKIFJ PAECIDMLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x54DB960", Offset = "0x54DAD60", VA = "0x1854DB960")]
	private void GGFGLJACGLM(ELDEAFMKIFJ PAECIDMLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x54DFB60", Offset = "0x54DEF60", VA = "0x1854DFB60")]
	public NJOMLOBNNBL(FFAFAFDEFGC IBMIOMMKLEK, [Optional] HINEDBPOBIK HNBHCJKPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54DAC00", Offset = "0x54DA000", VA = "0x1854DAC00")]
	internal void EENKIIEKDND(ELDEAFMKIFJ LIONCIHEDJP, int LDPOIJPJELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54DF6E0", Offset = "0x54DEAE0", VA = "0x1854DF6E0")]
	internal void PNLOCBKNNAA(ELDEAFMKIFJ LIONCIHEDJP, object CONPKEPKLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54DF8B0", Offset = "0x54DECB0", VA = "0x1854DF8B0")]
	internal void PPFEHEHPDBN(ELDEAFMKIFJ PAECIDMLBNB, AENNDFMMBCC IEEIJMDMOOP, SocketError MMJHEJPHCBC, MJNGDMKOIHM FILLDNNEIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54DA1F0", Offset = "0x54D95F0", VA = "0x1854DA1F0")]
	private void CJANACBHLCA(ELDEAFMKIFJ PAECIDMLBNB, AENNDFMMBCC IEEIJMDMOOP, SocketError MMJHEJPHCBC, bool LHIOHICKLJF, byte[] GMLIPIALCHN, int ANFKDBDICOO, int GNHCGOJHAJG, MJNGDMKOIHM FILLDNNEIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x54DD6E0", Offset = "0x54DCAE0", VA = "0x1854DD6E0")]
	private void MNKLOCCBEEM(OKMKPMMDAIG.IOLNLIBMBGK KHENBEDBKDI, [Optional] ELDEAFMKIFJ PAECIDMLBNB, [Optional] IPEndPoint MEAEICACBON, SocketError FDMBHCEFJHD = SocketError.Success, int LDPOIJPJELN = 0, AENNDFMMBCC DHFHEPJIMCD = AENNDFMMBCC.ConnectionFailed, [Optional] ECNPAAMNCCJ MFEGICCPECI, CEHBFOLFJCE FLAOLKPEEMK = CEHBFOLFJCE.Unreliable, byte EIDJFLMGGPA = 0, [Optional] MJNGDMKOIHM NECOLHCPEKH, [Optional] object CONPKEPKLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x54DA440", Offset = "0x54D9840", VA = "0x1854DA440")]
	private void DNKPAIOKBIN(OKMKPMMDAIG NDBBAACHBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54DF5E0", Offset = "0x54DE9E0", VA = "0x1854DF5E0")]
	internal void PDMOEIHFAHL(OKMKPMMDAIG NDBBAACHBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54DB5A0", Offset = "0x54DA9A0", VA = "0x1854DB5A0")]
	private void FFDLPEBKNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x54DCFA0", Offset = "0x54DC3A0", VA = "0x1854DCFA0")]
	private void MAOCAFGELML(int IJGAHIFOFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x54DDAA0", Offset = "0x54DCEA0", VA = "0x1854DDAA0")]
	internal ELDEAFMKIFJ NEFLEAMDDOJ(ECNPAAMNCCJ MGFKAMLOFJH, byte[] EIKNFOAONIH, int ANFKDBDICOO, int OGHJPGGPGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x54DB8E0", Offset = "0x54DACE0", VA = "0x1854DB8E0")]
	private int FNIGFMMDMJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x54DB140", Offset = "0x54DA540", VA = "0x1854DB140")]
	private void FEPHBILDCNE(IPEndPoint MEAEICACBON, ELDEAFMKIFJ ILLGHKCNDIA, NABOEGPLHJA JFHLDCJEKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x54D93E0", Offset = "0x54D87E0", VA = "0x1854D93E0")]
	private void CAMLPMIMIJE(MJNGDMKOIHM DKEJJMMAPEH, IPEndPoint MEAEICACBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x54DE650", Offset = "0x54DDA50", VA = "0x1854DE650")]
	internal void NHOBCHDPBDI(MJNGDMKOIHM DKEJJMMAPEH, CEHBFOLFJCE BMBPKGHMAGL, byte EIDJFLMGGPA, int IMBINAPMIHH, ELDEAFMKIFJ LIONCIHEDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x54DF2E0", Offset = "0x54DE6E0", VA = "0x1854DF2E0")]
	public bool OFAAPPLMKAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x54DEB00", Offset = "0x54DDF00", VA = "0x1854DEB00")]
	public bool OFAAPPLMKAM(IPAddress EIKFFIIBFBD, IPAddress CPMKNMJENLK, int HKGKDHIIFJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x54DEA80", Offset = "0x54DDE80", VA = "0x1854DEA80")]
	public bool OFAAPPLMKAM(int HKGKDHIIFJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x54DF440", Offset = "0x54DE840", VA = "0x1854DF440")]
	public void OOGCLBJEDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x54DE570", Offset = "0x54DD970", VA = "0x1854DE570")]
	public ELDEAFMKIFJ NFJLPBPHCAN(string LBCMLBDKDMC, int HKGKDHIIFJP, string CONEAMPCFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x54DE0C0", Offset = "0x54DD4C0", VA = "0x1854DE0C0")]
	public ELDEAFMKIFJ NFJLPBPHCAN(string LBCMLBDKDMC, int HKGKDHIIFJP, CABDOBDNBBH KLHKDJLNHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x54DE1A0", Offset = "0x54DD5A0", VA = "0x1854DE1A0")]
	public ELDEAFMKIFJ NFJLPBPHCAN(IPEndPoint GOOANMNBGEP, CABDOBDNBBH KLHKDJLNHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x54DD610", Offset = "0x54DCA10", VA = "0x1854DD610")]
	public void MDMPOIPPKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x54DD2C0", Offset = "0x54DC6C0", VA = "0x1854DD2C0")]
	public void MDMPOIPPKCE(bool IGNIFNAPHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x54DC200", Offset = "0x54DB600", VA = "0x1854DC200")]
	public void JPDIIDBKLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x54DC300", Offset = "0x54DB700", VA = "0x1854DC300")]
	public void JPDIIDBKLMC(byte[] GMLIPIALCHN, int ANFKDBDICOO, int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x54DA2D0", Offset = "0x54D96D0", VA = "0x1854DA2D0")]
	public void CJANACBHLCA(ELDEAFMKIFJ PAECIDMLBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x54DA130", Offset = "0x54D9530", VA = "0x1854DA130")]
	public void CJANACBHLCA(ELDEAFMKIFJ PAECIDMLBNB, byte[] GMLIPIALCHN, int ANFKDBDICOO, int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x54DF980", Offset = "0x54DED80", VA = "0x1854DF980", Slot = "4")]
	private IEnumerator<ELDEAFMKIFJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x54DFA10", Offset = "0x54DEE10", VA = "0x1854DFA10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x54DBCA0", Offset = "0x54DB0A0", VA = "0x1854DBCA0")]
	private MJNGDMKOIHM HCOJPLMAFLF(FJJLMDPHFPM JAOOJJKNLDO, int KKEOKHMHDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x54DBD90", Offset = "0x54DB190", VA = "0x1854DBD90")]
	private MJNGDMKOIHM HCOJPLMAFLF(FJJLMDPHFPM JAOOJJKNLDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54DAF10", Offset = "0x54DA310", VA = "0x1854DAF10")]
	internal MJNGDMKOIHM EPNNGMKIHOO(int KKEOKHMHDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54DC6F0", Offset = "0x54DBAF0", VA = "0x1854DC6F0")]
	internal void LANLNAEMCML(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x54DFAA0", Offset = "0x54DEEA0", VA = "0x1854DFAA0")]
	static NJOMLOBNNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9D5BE0", Offset = "0x9D4FE0", VA = "0x1809D5BE0")]
	private bool PEEHDGOMBAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x54DF7C0", Offset = "0x54DEBC0", VA = "0x1854DF7C0")]
	private void PPEAAIOPEHI(IPEndPoint LKJONNCOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x54DBBC0", Offset = "0x54DAFC0", VA = "0x1854DBBC0")]
	private void GONLCEKKAEL(IPEndPoint LKJONNCOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x54D91E0", Offset = "0x54D85E0", VA = "0x1854D91E0")]
	private bool BJBDLFHEODI(SocketException EAIHDKDABHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x54DC420", Offset = "0x54DB820", VA = "0x1854DC420")]
	private void KMANHMJEJFI(HFEKCBBOMAJ PFHAHHMJGOC, EndPoint CNFDBPANMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x54DBE70", Offset = "0x54DB270", VA = "0x1854DBE70")]
	private void ILCNJIHMMHP(object ADCHACEKJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54DEB20", Offset = "0x54DDF20", VA = "0x1854DEB20")]
	public bool OFAAPPLMKAM(IPAddress EIKFFIIBFBD, IPAddress CPMKNMJENLK, int HKGKDHIIFJP, bool OCNINOAPOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x54D9380", Offset = "0x54D8780", VA = "0x1854D9380")]
	internal int BJLJOGHBAJC(MJNGDMKOIHM DKEJJMMAPEH, IPEndPoint MEAEICACBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x54DC950", Offset = "0x54DBD50", VA = "0x1854DC950")]
	internal int LGMDBNPAJFJ(MJNGDMKOIHM DKEJJMMAPEH, IPEndPoint MEAEICACBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54DC990", Offset = "0x54DBD90", VA = "0x1854DC990")]
	internal int LGMDBNPAJFJ(byte[] AGOKDCAFCLN, int ANFKDBDICOO, int OGHJPGGPGJL, IPEndPoint MEAEICACBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x54DE910", Offset = "0x54DDD10", VA = "0x1854DE910")]
	internal void NJPCBAINKAH(bool MDAHEHINJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FJJLMDPHFPM : byte
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
internal sealed class MJNGDMKOIHM
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HIJMOJPOENJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DDACKJKPLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IDELBEPJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int KKKENMPFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object GPJFJENJHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public MJNGDMKOIHM PBNNGCBPFCN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FJJLMDPHFPM EGPAEBHJNII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x54D75B0", Offset = "0x54D69B0", VA = "0x1854D75B0")]
		get
		{
			return default(FJJLMDPHFPM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54D7A60", Offset = "0x54D6E60", VA = "0x1854D7A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte BPKEJDMBEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x54D7890", Offset = "0x54D6C90", VA = "0x1854D7890")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x54D74E0", Offset = "0x54D68E0", VA = "0x1854D74E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort EEAGADOPHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x54D78C0", Offset = "0x54D6CC0", VA = "0x1854D78C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54D75E0", Offset = "0x54D69E0", VA = "0x1854D75E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BPACFPIIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x54D7760", Offset = "0x54D6B60", VA = "0x1854D7760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HDDDDDFKGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x54D7AD0", Offset = "0x54D6ED0", VA = "0x1854D7AD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x54D7520", Offset = "0x54D6920", VA = "0x1854D7520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LNFOCIFOFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x54D7550", Offset = "0x54D6950", VA = "0x1854D7550")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x54D7A20", Offset = "0x54D6E20", VA = "0x1854D7A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort KNNCNMAPDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x54D7920", Offset = "0x54D6D20", VA = "0x1854D7920")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x54D7720", Offset = "0x54D6B20", VA = "0x1854D7720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort GDNKEJGGFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x54D7980", Offset = "0x54D6D80", VA = "0x1854D7980")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x54D79E0", Offset = "0x54D6DE0", VA = "0x1854D79E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x54D7B00", Offset = "0x54D6F00", VA = "0x1854D7B00")]
	static MJNGDMKOIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x54D7AA0", Offset = "0x54D6EA0", VA = "0x1854D7AA0")]
	public void NOHKFDKEHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54D7EF0", Offset = "0x54D72F0", VA = "0x1854D7EF0")]
	public MJNGDMKOIHM(int KKEOKHMHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x54D7DE0", Offset = "0x54D71E0", VA = "0x1854D7DE0")]
	public MJNGDMKOIHM(FJJLMDPHFPM JAOOJJKNLDO, int KKEOKHMHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x54D7620", Offset = "0x54D6A20", VA = "0x1854D7620")]
	public static int BOMDKCAPKJE(FJJLMDPHFPM JAOOJJKNLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x54D7690", Offset = "0x54D6A90", VA = "0x1854D7690")]
	public int BOMDKCAPKJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x54D7790", Offset = "0x54D6B90", VA = "0x1854D7790")]
	public bool FDFPJNOPEFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum EMDAIPCNOAM : byte
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
internal enum NINCBNFDKHA
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
internal enum LAOCHKJNODB
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum NDFBAADFDED
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ELDEAFMKIFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class DPHINPNMPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public MJNGDMKOIHM[] ABCGKIONAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int ANHIICBNAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PLOGEOEFMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HDDDDDFKGNE;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public DPHINPNMPJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void MMPJEMKEGOM(ulong BLDJEAIDOAF, int HNLGFMEPHBO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CPBAPPOPOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int BLLOKKAMNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int AEKMNLCONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double LMEPGJMJLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int ICMLNMHDLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int HNLIJDMCJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int ANDANMPPPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch LOICGJMKKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int IJECNMLDAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long ICDBAPOFFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object LDNDJFHBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal ELDEAFMKIFJ JIIKDONJKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal ELDEAFMKIFJ LGDAJAJNOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<MJNGDMKOIHM> LIPDBKLIKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OBPNOEKIFCC> PKGBIAEEPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OBPNOEKIFCC[] BEOCHDGMOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int JIEAKNPGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int KPGCGHFMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool BDKJCAKBKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int HMOPAIANFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int EFJPLJJIPKH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int BDEJPGJNEIG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MHGHNDNNDLE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object BLIHCJPMGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int FJJMMIEGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, DPHINPNMPJI> LONONNFMIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> MIEJEAGFKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MJNGDMKOIHM JLJGJJJMLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int FCEMCHHHJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int ELKEFFJCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint GEGOECGJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int MGHIGAGJGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HLKPFJGFPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long GIEEDPJAANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BBPILONKDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private EMDAIPCNOAM MAIAHFEMINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MJNGDMKOIHM EHCHGGEDLJE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int PNGJLOCGIKP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HCNCBLHADIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly MJNGDMKOIHM MJDEJCHPFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly MJNGDMKOIHM MDENOANBGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MJNGDMKOIHM AKHMMMIGEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MJNGDMKOIHM BFHJOFIJMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LPOEGFPEGEN CPPPBKMFJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly NJOMLOBNNBL MHMFJCHIBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int POIIBGFPHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object JKCPAKKBIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CBNAINCGKNA OEMOHHFPOIE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte KMBELGBHMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA11D60", Offset = "0xA11160", VA = "0x180A11D60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x54CE2A0", Offset = "0x54CD6A0", VA = "0x1854CE2A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint FKJJHPMIBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C28A0", Offset = "0x8C1CA0", VA = "0x1808C28A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EMDAIPCNOAM FMAEFNFJMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1577380", Offset = "0x1576780", VA = "0x181577380")]
		get
		{
			return default(EMDAIPCNOAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long JBBCOBJPFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x795580", Offset = "0x794980", VA = "0x180795580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PACDHMFKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC73D0", Offset = "0xAC67D0", VA = "0x180AC73D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x139A400", Offset = "0x1399800", VA = "0x18139A400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DEAEJOKOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x54CFB00", Offset = "0x54CEF00", VA = "0x1854CFB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JCMCAHFHKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A0110", Offset = "0x79F510", VA = "0x1807A0110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BFGAEIIAJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1755D80", Offset = "0x1755180", VA = "0x181755D80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MMPJEMKEGOM CLCOKPJNAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x54D13C0", Offset = "0x54D07C0", VA = "0x1854D13C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x54CF520", Offset = "0x54CE920", VA = "0x1854CF520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54D1470", Offset = "0x54D0870", VA = "0x1854D1470")]
	internal ELDEAFMKIFJ(NJOMLOBNNBL EEFGCKAKOEK, IPEndPoint MEAEICACBON, int NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x54CEA80", Offset = "0x54CDE80", VA = "0x1854CEA80")]
	internal void CKENEOEMNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x54CF5D0", Offset = "0x54CE9D0", VA = "0x1854CF5D0")]
	internal void HDNJLHCIPBL(IPEndPoint CMLGMMAIMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x54CEE20", Offset = "0x54CE220", VA = "0x1854CEE20")]
	internal void DPCOKIPECBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x54CF600", Offset = "0x54CEA00", VA = "0x1854CF600")]
	private void HGOFIONMBFD(int FEPKBGDKNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x54CF060", Offset = "0x54CE460", VA = "0x1854CF060")]
	private void EHELPMHOGGE(int INHPMBMFDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x54CEEB0", Offset = "0x54CE2B0", VA = "0x1854CEEB0")]
	private OBPNOEKIFCC EFFPLIDIJNP(byte AHCPHJCJKJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54D1AB0", Offset = "0x54D0EB0", VA = "0x1854D1AB0")]
	internal ELDEAFMKIFJ(NJOMLOBNNBL EEFGCKAKOEK, IPEndPoint MEAEICACBON, int NONJEEALACK, byte KIJCPOJPPMA, CABDOBDNBBH KALKCFOBLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x54D18D0", Offset = "0x54D0CD0", VA = "0x1854D18D0")]
	internal ELDEAFMKIFJ(NJOMLOBNNBL EEFGCKAKOEK, ECNPAAMNCCJ MGFKAMLOFJH, int NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x54CE380", Offset = "0x54CD780", VA = "0x1854CE380")]
	internal void CCMMCGKIPOJ(NABOEGPLHJA MOKDLMNNALB, byte[] GMLIPIALCHN, int ANFKDBDICOO, int OGHJPGGPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x54D1340", Offset = "0x54D0740", VA = "0x1854D1340")]
	internal bool NODEFEPPOEP(LAPADDABKCI DKEJJMMAPEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x54CE350", Offset = "0x54CD750", VA = "0x1854CE350")]
	public void BMCAACKFALF(byte[] GMLIPIALCHN, int ANFKDBDICOO, int OGHJPGGPGJL, CEHBFOLFJCE LOBGHAGLKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x54D04E0", Offset = "0x54CF8E0", VA = "0x1854D04E0")]
	private void KFFDLKDCJED(byte[] GMLIPIALCHN, int ANFKDBDICOO, int OGHJPGGPGJL, byte EIDJFLMGGPA, CEHBFOLFJCE FLAOLKPEEMK, object CONPKEPKLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x54D0C60", Offset = "0x54D0060", VA = "0x1854D0C60")]
	public void LJMAFPLGJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x54D0D10", Offset = "0x54D0110", VA = "0x1854D0D10")]
	internal LAOCHKJNODB NHIBLGGKLAF(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return default(LAOCHKJNODB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54D0A30", Offset = "0x54CFE30", VA = "0x1854D0A30")]
	internal void LFDGIBKBBOD(OBPNOEKIFCC EKEJEFECLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x54CF7F0", Offset = "0x54CEBF0", VA = "0x1854CF7F0")]
	internal NDFBAADFDED IDDCHKBAOLP(byte[] GMLIPIALCHN, int ANFKDBDICOO, int OGHJPGGPGJL, bool LHIOHICKLJF)
	{
		return default(NDFBAADFDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x54D04A0", Offset = "0x54CF8A0", VA = "0x1854D04A0")]
	private void KDJMMBJOACJ(int DMJOOOFECHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x54CFB10", Offset = "0x54CEF10", VA = "0x1854CFB10")]
	internal void KCOAKIEGMLB(CEHBFOLFJCE BMBPKGHMAGL, MJNGDMKOIHM GIFLIOHDCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54D0DF0", Offset = "0x54D01F0", VA = "0x1854D0DF0")]
	private void NHJNKOADJPL(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x54CEAA0", Offset = "0x54CDEA0", VA = "0x1854CEAA0")]
	private void DDDBIBHJIHC(int IILLPFGJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x54CF360", Offset = "0x54CE760", VA = "0x1854CF360")]
	internal NINCBNFDKHA FEPHBILDCNE(NABOEGPLHJA JFHLDCJEKME)
	{
		return default(NINCBNFDKHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x54CE3D0", Offset = "0x54CD7D0", VA = "0x1854CE3D0")]
	internal void CFKPMBLLPKA(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54CF6D0", Offset = "0x54CEAD0", VA = "0x1854CF6D0")]
	private void HJDBPAFBOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x54D0A90", Offset = "0x54CFE90", VA = "0x1854D0A90")]
	internal void LGKAEPBFDDC(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x54CDBF0", Offset = "0x54CCFF0", VA = "0x1854CDBF0")]
	internal void AKOCPLJFKLG(int IILLPFGJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x54CF0A0", Offset = "0x54CE4A0", VA = "0x1854CF0A0")]
	internal void EMGLADAKHPO(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CBNAINCGKNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PPEOLGHBHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NNBKKMLJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long AFFMJIBLIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DPILEAACICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long AHBEEIJBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long AKDLGFBFDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long KCKMKJJGEEP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long HAKKIKPGAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x54CCC70", Offset = "0x54CC070", VA = "0x1854CCC70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long IADNBGGOGED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x54CCC90", Offset = "0x54CC090", VA = "0x1854CCC90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long NIIDHKEPBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x54CCB40", Offset = "0x54CBF40", VA = "0x1854CCB40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long PAMBMNNIMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x54CCCD0", Offset = "0x54CC0D0", VA = "0x1854CCCD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CHFBOMPAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x54CCCE0", Offset = "0x54CC0E0", VA = "0x1854CCCE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IJIKEJKEEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x54CCB30", Offset = "0x54CBF30", VA = "0x1854CCB30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private LPOEGFPEGEN IJJDINFLGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19A5440", Offset = "0x19A4840", VA = "0x1819A5440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double JCNAINNJMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x54CCCF0", Offset = "0x54CC0F0", VA = "0x1854CCCF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x54CCAD0", Offset = "0x54CBED0", VA = "0x1854CCAD0")]
	public void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54CCB50", Offset = "0x54CBF50", VA = "0x1854CCB50")]
	public void DHBHNPBJHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54CCD50", Offset = "0x54CC150", VA = "0x1854CCD50")]
	public void PGCCDPHHEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x54CCC80", Offset = "0x54CC080", VA = "0x1854CCC80")]
	public void FJLLAGDFPFL(long CEOMEJGMDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x54CCBC0", Offset = "0x54CBFC0", VA = "0x1854CCBC0")]
	public void EGPFJILIALK(long LFBPLMFBFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x54CCCA0", Offset = "0x54CC0A0", VA = "0x1854CCCA0")]
	public void MDFPHEEDCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x54CCB80", Offset = "0x54CBF80", VA = "0x1854CCB80")]
	public void EGFIJOCALON(long OGNFKBKBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x54CCD60", Offset = "0x54CC160", VA = "0x1854CCD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x54CCBD0", Offset = "0x54CBFD0", VA = "0x1854CCBD0")]
	public void FCAAGKMGNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public CBNAINCGKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OHHBACKJGOL
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JFKOCFAJAAG;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x54E0670", Offset = "0x54DFA70", VA = "0x1854E0670")]
	public static IPEndPoint NLFABHLMPAN(string PBCLLPCMFHG, int HKGKDHIIFJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x54E0470", Offset = "0x54DF870", VA = "0x1854E0470")]
	public static IPAddress CJHGLHGLJJO(string PBCLLPCMFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x54E03E0", Offset = "0x54DF7E0", VA = "0x1854E03E0")]
	public static IPAddress CJHGLHGLJJO(string PBCLLPCMFHG, AddressFamily DDPLIIOJLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54E0640", Offset = "0x54DFA40", VA = "0x1854E0640")]
	internal static int JNJABIBHFHD(int OGEDDLPEGMG, int CAMJLAEPJEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27891F0", Offset = "0x27885F0", VA = "0x1827891F0")]
	internal static T[] LFHEOGEIOMG<T>(int GNHCGOJHAJG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FBGPOOHBPOP : OBPNOEKIFCC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct HMCGIEMCEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private MJNGDMKOIHM IADILLPFKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long PHNKNILEKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool FAMEOAHHJKL;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x54D4020", Offset = "0x54D3420", VA = "0x1854D4020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x54D3F40", Offset = "0x54D3340", VA = "0x1854D3F40")]
		public void AFJDDCCJNFG(MJNGDMKOIHM DKEJJMMAPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x54D3F60", Offset = "0x54D3360", VA = "0x1854D3F60")]
		public bool DIKNPGNLMJN(long HAOJPBKMLBP, ELDEAFMKIFJ PAECIDMLBNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x54D3FD0", Offset = "0x54D33D0", VA = "0x1854D3FD0")]
		public bool EKABOMHIFDI(ELDEAFMKIFJ PAECIDMLBNB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MJNGDMKOIHM LOBLDJKBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly HMCGIEMCEGC[] HHEKMNFEHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly MJNGDMKOIHM[] ICGNJPKIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] AEBGLHBKPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int ABLHJAHJEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int EPMDKPCIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int CFDLDINBBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int AFNABCEHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool IICFCPMGAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly CEHBFOLFJCE FDEFFGDJICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool BIJLKMCNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int PBLNKKGPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte NNLHDIPDPPK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x54D2B10", Offset = "0x54D1F10", VA = "0x1854D2B10")]
	public FBGPOOHBPOP(ELDEAFMKIFJ PAECIDMLBNB, bool JCGODKPBOII, byte NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54D2750", Offset = "0x54D1B50", VA = "0x1854D2750")]
	private void PEOLFJIDIOJ(MJNGDMKOIHM DKEJJMMAPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x54D22A0", Offset = "0x54D16A0", VA = "0x1854D22A0", Slot = "4")]
	protected override bool ECEFLFPPLLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x54D1C40", Offset = "0x54D1040", VA = "0x1854D1C40", Slot = "5")]
	public override bool CFKPMBLLPKA(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DFCNGLHBELG : OBPNOEKIFCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int LIKHBGEDMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort EPMDKPCIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool LCDBKCIJDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private MJNGDMKOIHM DCIOLEBFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly MJNGDMKOIHM EOGFEAAICGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool BKOBODGHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte NNLHDIPDPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long IKNGIFGJOHA;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x54CD9D0", Offset = "0x54CCDD0", VA = "0x1854CD9D0")]
	public DFCNGLHBELG(ELDEAFMKIFJ PAECIDMLBNB, bool JHCFJCNBNLE, byte NONJEEALACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x54CD530", Offset = "0x54CC930", VA = "0x1854CD530", Slot = "4")]
	protected override bool ECEFLFPPLLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x54CD220", Offset = "0x54CC620", VA = "0x1854CD220", Slot = "5")]
	public override bool CFKPMBLLPKA(MJNGDMKOIHM DKEJJMMAPEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MPAFGJEGNHN
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EHBCABOAHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong LBKOPBCEKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double MIPEPNNGFPK;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FDMOFNOFOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int CMEAPAJFIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float APLPPPOGFJM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x54CAAD0", Offset = "0x54C9ED0", VA = "0x1854CAAD0")]
	private static void KBPFCLJNKPO(byte[] NKGLIMPLOMB, int EIJFICIEABK, ulong GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BE0", Offset = "0x54D7FE0", VA = "0x1854D8BE0")]
	private static void KBPFCLJNKPO(byte[] NKGLIMPLOMB, int EIJFICIEABK, int GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x54D8C50", Offset = "0x54D8050", VA = "0x1854D8C50")]
	public static void KBPFCLJNKPO(byte[] NKGLIMPLOMB, int EIJFICIEABK, short GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BC0", Offset = "0x54D7FC0", VA = "0x1854D8BC0")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, double PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x54D8C90", Offset = "0x54D8090", VA = "0x1854D8C90")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x54D8C50", Offset = "0x54D8050", VA = "0x1854D8C50")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, short PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x54D8C50", Offset = "0x54D8050", VA = "0x1854D8C50")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, ushort PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BE0", Offset = "0x54D7FE0", VA = "0x1854D8BE0")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, int PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BE0", Offset = "0x54D7FE0", VA = "0x1854D8BE0")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, uint PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BB0", Offset = "0x54D7FB0", VA = "0x1854D8BB0")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, long PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BB0", Offset = "0x54D7FB0", VA = "0x1854D8BB0")]
	public static void ABBFCEHLIEO(byte[] KLMLFNDOPAB, int PNHIOPPHDJO, ulong PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MNLPDEICHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] LPJCKAJGIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int GDHBMFOOKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int BKLHNAFPECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int BLKIIKCJHBO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] IDELBEPJPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int PMAKBAAPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DCMJICJNFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x54D8030", Offset = "0x54D7430", VA = "0x1854D8030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MFLPGIPCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B160", Offset = "0x1C4A560", VA = "0x181C4B160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MMKBCKCBBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x54D8040", Offset = "0x54D7440", VA = "0x1854D8040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x54D8680", Offset = "0x54D7A80", VA = "0x1854D8680")]
	public void LFDHFMGFIHA(byte[] GDMGHBDKKDG, int EIJFICIEABK, int DBGOKGDJMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MNLPDEICHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x54D8B50", Offset = "0x54D7F50", VA = "0x1854D8B50")]
	public MNLPDEICHPD(byte[] GDMGHBDKKDG, int EIJFICIEABK, int DBGOKGDJMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x54D7F60", Offset = "0x54D7360", VA = "0x1854D7F60")]
	public IPEndPoint ACNGIJLHOCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x54D8290", Offset = "0x54D7690", VA = "0x1854D8290")]
	public byte NODKGKGCGJB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x54D8290", Offset = "0x54D7690", VA = "0x1854D8290")]
	public sbyte ENLJGFGCPJC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5C90", Offset = "0x26F5090", VA = "0x1826F5C90")]
	public T[] GOGMLDPNJIL<T>(ushort KKEOKHMHDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54D8730", Offset = "0x54D7B30", VA = "0x1854D8730")]
	public bool[] MIIHKAMNJBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x54D8B10", Offset = "0x54D7F10", VA = "0x1854D8B10")]
	public ushort[] PJHJMECAAOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x54D8520", Offset = "0x54D7920", VA = "0x1854D8520")]
	public short[] IPDLEDAAJCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x54D8400", Offset = "0x54D7800", VA = "0x1854D8400")]
	public int[] HIAEHKBACOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54D8230", Offset = "0x54D7630", VA = "0x1854D8230")]
	public uint[] EFMAJPGBPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54D8180", Offset = "0x54D7580", VA = "0x1854D8180")]
	public float[] DDMLHDEMCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54D83C0", Offset = "0x54D77C0", VA = "0x1854D83C0")]
	public double[] HHKAAMACANG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54D8AD0", Offset = "0x54D7ED0", VA = "0x1854D8AD0")]
	public long[] PEJNANPGONF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54D8340", Offset = "0x54D7740", VA = "0x1854D8340")]
	public ulong[] FINNNHIHMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54D8050", Offset = "0x54D7450", VA = "0x1854D8050")]
	public string[] CMAPPJPPBBD(int INGEICKKPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54D8560", Offset = "0x54D7960", VA = "0x1854D8560")]
	public bool JCGGJKHJKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54D8440", Offset = "0x54D7840", VA = "0x1854D8440")]
	public char HOPJEJJJKAO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54D8440", Offset = "0x54D7840", VA = "0x1854D8440")]
	public ushort HLAGKLBLEBG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x54D87E0", Offset = "0x54D7BE0", VA = "0x1854D87E0")]
	public short MOPCOGOIIJL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x54D84B0", Offset = "0x54D78B0", VA = "0x1854D84B0")]
	public long IMKNJADEOLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x54D82D0", Offset = "0x54D76D0", VA = "0x1854D82D0")]
	public ulong FAJOEOJKOBP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x54D86C0", Offset = "0x54D7AC0", VA = "0x1854D86C0")]
	public int LOMBFIDNAFA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54D85A0", Offset = "0x54D79A0", VA = "0x1854D85A0")]
	public uint JEKMGAOAGII()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54D8610", Offset = "0x54D7A10", VA = "0x1854D8610")]
	public float KKMJEJBFGIF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x54D81C0", Offset = "0x54D75C0", VA = "0x1854D81C0")]
	public double EFLFOIEPPHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54D8890", Offset = "0x54D7C90", VA = "0x1854D8890")]
	public string OPADAFFJLAP(int GHHLCKKCGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x54D8770", Offset = "0x54D7B70", VA = "0x1854D8770")]
	public ArraySegment<byte> MKDLCEBHMFG(int GNHCGOJHAJG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x54D8380", Offset = "0x54D7780", VA = "0x1854D8380")]
	public sbyte[] FLHGFEOGLAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54D8850", Offset = "0x54D7C50", VA = "0x1854D8850")]
	public byte[] NDMGKEAPFFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54D8270", Offset = "0x54D7670", VA = "0x1854D8270")]
	public void EKABOMHIFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CABDOBDNBBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] LPJCKAJGIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int GDHBMFOOKML;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int CECCABOKOHB = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool KBNPCIDHNLK;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding AKGELDCEONA;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int DIMNGJHIGMA = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] OHGCLDEIMCD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] LGDPHHJAFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x54CC5B0", Offset = "0x54CB9B0", VA = "0x1854CC5B0")]
	public CABDOBDNBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x54CC630", Offset = "0x54CBA30", VA = "0x1854CC630")]
	public CABDOBDNBBH(bool MHANDGHAIPH, int GHAAJJFMCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x54CC060", Offset = "0x54CB460", VA = "0x1854CC060")]
	public static CABDOBDNBBH HHONAPGANOA(string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54CBFC0", Offset = "0x54CB3C0", VA = "0x1854CBFC0")]
	public void CPINIKMOMAP(int DMNOACHOKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4A70", Offset = "0x1CC3E70", VA = "0x181CC4A70")]
	public void AIKIIHKLAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x54CBAA0", Offset = "0x54CAEA0", VA = "0x1854CBAA0")]
	public void AKJBJGODEPP(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x54CBA50", Offset = "0x54CAE50", VA = "0x1854CBA50")]
	public void AKJBJGODEPP(double PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x54CBE90", Offset = "0x54CB290", VA = "0x1854CBE90")]
	public void AKJBJGODEPP(long PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x54CBE90", Offset = "0x54CB290", VA = "0x1854CBE90")]
	public void AKJBJGODEPP(ulong PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x54CB8E0", Offset = "0x54CACE0", VA = "0x1854CB8E0")]
	public void AKJBJGODEPP(int PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x54CB8E0", Offset = "0x54CACE0", VA = "0x1854CB8E0")]
	public void AKJBJGODEPP(uint PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x54CB9E0", Offset = "0x54CADE0", VA = "0x1854CB9E0")]
	public void AKJBJGODEPP(char PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x54CB9E0", Offset = "0x54CADE0", VA = "0x1854CB9E0")]
	public void AKJBJGODEPP(ushort PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x54CB9E0", Offset = "0x54CADE0", VA = "0x1854CB9E0")]
	public void AKJBJGODEPP(short PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x54CB880", Offset = "0x54CAC80", VA = "0x1854CB880")]
	public void AKJBJGODEPP(sbyte PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x54CB880", Offset = "0x54CAC80", VA = "0x1854CB880")]
	public void AKJBJGODEPP(byte PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x54CB970", Offset = "0x54CAD70", VA = "0x1854CB970")]
	public void AKJBJGODEPP(byte[] GMLIPIALCHN, int EIJFICIEABK, int OGHJPGGPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x54CBEE0", Offset = "0x54CB2E0", VA = "0x1854CBEE0")]
	public void CIEJDKLJBPP(sbyte[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x54CBEE0", Offset = "0x54CB2E0", VA = "0x1854CBEE0")]
	public void OEEMGKPJFIE(byte[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x54CBC20", Offset = "0x54CB020", VA = "0x1854CBC20")]
	public void AKJBJGODEPP(bool PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x54CC360", Offset = "0x54CB760", VA = "0x1854CC360")]
	public void JGEBBIMCKOC(Array AMDPKINKLFK, int EFBEMMJJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x54CC280", Offset = "0x54CB680", VA = "0x1854CC280")]
	public void JGEBBIMCKOC(float[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54CC1A0", Offset = "0x54CB5A0", VA = "0x1854CC1A0")]
	public void JGEBBIMCKOC(double[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x54CC1A0", Offset = "0x54CB5A0", VA = "0x1854CC1A0")]
	public void JGEBBIMCKOC(long[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x54CC1A0", Offset = "0x54CB5A0", VA = "0x1854CC1A0")]
	public void JGEBBIMCKOC(ulong[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x54CC280", Offset = "0x54CB680", VA = "0x1854CC280")]
	public void JGEBBIMCKOC(int[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54CC280", Offset = "0x54CB680", VA = "0x1854CC280")]
	public void JGEBBIMCKOC(uint[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x54CC440", Offset = "0x54CB840", VA = "0x1854CC440")]
	public void JGEBBIMCKOC(ushort[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x54CC440", Offset = "0x54CB840", VA = "0x1854CC440")]
	public void JGEBBIMCKOC(short[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x54CBEE0", Offset = "0x54CB2E0", VA = "0x1854CBEE0")]
	public void JGEBBIMCKOC(bool[] PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x54CC0D0", Offset = "0x54CB4D0", VA = "0x1854CC0D0")]
	public void JGEBBIMCKOC(string[] PAHKKNONPEO, int BLAADLALBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54CBB40", Offset = "0x54CAF40", VA = "0x1854CBB40")]
	public void AKJBJGODEPP(IPEndPoint JAHNDKCJALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x54CBC10", Offset = "0x54CB010", VA = "0x1854CBC10")]
	public void AKJBJGODEPP(string PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x54CBC80", Offset = "0x54CB080", VA = "0x1854CBC80")]
	public void AKJBJGODEPP(string PAHKKNONPEO, int GHHLCKKCGDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PBCMAGHFCAP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class NGNPKMIDBPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong POIIBGFPHFI;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3E925A0", Offset = "0x3E919A0", VA = "0x183E925A0")]
		static NGNPKMIDBPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void EFOEKDHKHCP(MNLPDEICHPD MAACBPKBLAG, object CONPKEPKLCH);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LIGJEOGOIOK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PBCMAGHFCAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LIGJEOGOIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B8D0", Offset = "0x3C2ACD0", VA = "0x183C2B8D0")]
		internal void NHBFLIONKIH(MNLPDEICHPD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MFEFPGAPMIK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public PBCMAGHFCAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MFEFPGAPMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E02880", Offset = "0x3E01C80", VA = "0x183E02880")]
		internal void NHBFLIONKIH(MNLPDEICHPD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly JJHOANPGHHF HDLHKGDIEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, EFOEKDHKHCP> PHGLCGJNGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly CABDOBDNBBH PHNPGMOPLIK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x54E0BF0", Offset = "0x54DFFF0", VA = "0x1854E0BF0")]
	public PBCMAGHFCAP(int INGEICKKPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x245A920", Offset = "0x2459D20", VA = "0x18245A920", Slot = "4")]
	protected virtual ulong PCGKAGLEPIH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x54E0A70", Offset = "0x54DFE70", VA = "0x1854E0A70", Slot = "5")]
	protected virtual EFOEKDHKHCP OMKOAPAMHGB(MNLPDEICHPD MAACBPKBLAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2794300", Offset = "0x2793700", VA = "0x182794300", Slot = "6")]
	protected virtual void GIHIIJKBMLL<T>(CABDOBDNBBH FJHMPBLBMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54E09F0", Offset = "0x54DFDF0", VA = "0x1854E09F0")]
	public void BDOKONDEOAI(MNLPDEICHPD MAACBPKBLAG, object CONPKEPKLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2794370", Offset = "0x2793770", VA = "0x182794370")]
	public void MHFGNJJJAHD<T>(CABDOBDNBBH FJHMPBLBMAF, T DKEJJMMAPEH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x54E0BA0", Offset = "0x54DFFA0", VA = "0x1854E0BA0")]
	public void OOEPAOIGFHA(MNLPDEICHPD MAACBPKBLAG, object CONPKEPKLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2794180", Offset = "0x2793580", VA = "0x182794180")]
	public void CIIMOENKKGB<T>(Action<T> MKPKGJCOJCD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2794000", Offset = "0x2793400", VA = "0x182794000")]
	public void CIIMOENKKGB<T, TUserData>(Action<T, TUserData> MKPKGJCOJCD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LMECLAEFDLN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x54CD0A0", Offset = "0x54CC4A0", VA = "0x1854CD0A0")]
	public LMECLAEFDLN(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ADJPHEDNBEP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x54CABC0", Offset = "0x54C9FC0", VA = "0x1854CABC0")]
	public ADJPHEDNBEP(string AGOKDCAFCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JJHOANPGHHF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum MCIDODKKOPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class MLPEKEMGOAA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public MCIDODKKOPC IIJIPCLFFOA;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F750", Offset = "0x3E0EB50", VA = "0x183E0F750", Slot = "4")]
		public virtual void AFJDDCCJNFG(MethodInfo LLMFLBKJEOJ, MethodInfo LHGPDJCPAJP, MCIDODKKOPC KHENBEDBKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GBAFPPGCBJG(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JCJKCLBMGBG(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		protected MLPEKEMGOAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GNEDGJMCKDF<TClass, TProperty> : MLPEKEMGOAA<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> CPNNCPLGABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> KPNIIOFOACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> IPMJGMNCKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> NLLJIDNGODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> HHKHBMNCCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> GFHKPKFNPNO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x37C3F80", Offset = "0x37C3380", VA = "0x1837C3F80", Slot = "7")]
		public override void CHLOJGPHBEB(TClass PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x37C6590", Offset = "0x37C5990", VA = "0x1837C6590", Slot = "8")]
		public override void LDHNHICOPLI(TClass PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x37C4AE0", Offset = "0x37C3EE0", VA = "0x1837C4AE0", Slot = "9")]
		public override void GBAFPPGCBJG(TClass PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x37C5B10", Offset = "0x37C4F10", VA = "0x1837C5B10", Slot = "10")]
		public override void JCJKCLBMGBG(TClass PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x37C6830", Offset = "0x37C5C30", VA = "0x1837C6830")]
		protected TProperty[] LIHMJHDKNFI(TClass PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x37C5100", Offset = "0x37C4500", VA = "0x1837C5100")]
		protected TProperty[] HDKAMNJIIJK(TClass PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x37C17C0", Offset = "0x37C0BC0", VA = "0x1837C17C0", Slot = "4")]
		public override void AFJDDCCJNFG(MethodInfo LLMFLBKJEOJ, MethodInfo LHGPDJCPAJP, MCIDODKKOPC KHENBEDBKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3672410", Offset = "0x3671810", VA = "0x183672410")]
		protected GNEDGJMCKDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class LGMNDCIOHCP<TClass, TProperty> : GNEDGJMCKDF<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KMHMCDLHAIG(MNLPDEICHPD LFEGGLDFJIF, [Out] TProperty OCPJGGBCFMH);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void HNHOCKFPCGN(CABDOBDNBBH GMIOCALJPJN, TProperty OCPJGGBCFMH);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C13A60", Offset = "0x3C12E60", VA = "0x183C13A60", Slot = "5")]
		public override void AIILFPAFKIJ(TClass PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C13DE0", Offset = "0x3C131E0", VA = "0x183C13DE0", Slot = "6")]
		public override void MHFGNJJJAHD(TClass PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C13B60", Offset = "0x3C12F60", VA = "0x183C13B60", Slot = "7")]
		public override void CHLOJGPHBEB(TClass PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C13D40", Offset = "0x3C13140", VA = "0x183C13D40", Slot = "8")]
		public override void LDHNHICOPLI(TClass PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x392F210", Offset = "0x392E610", VA = "0x18392F210")]
		protected LGMNDCIOHCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class CMABDIBAOFP<T> : GNEDGJMCKDF<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4F00", Offset = "0x4BB4300", VA = "0x184BB4F00", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC670", Offset = "0x3AEBA70", VA = "0x183AEC670", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4F70", Offset = "0x4BB4370", VA = "0x184BB4F70", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC610", Offset = "0x3AEBA10", VA = "0x183AEC610", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public CMABDIBAOFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class JOBDKIKOJGC<T> : GNEDGJMCKDF<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC530", Offset = "0x3AEB930", VA = "0x183AEC530", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC670", Offset = "0x3AEBA70", VA = "0x183AEC670", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC5A0", Offset = "0x3AEB9A0", VA = "0x183AEC5A0", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC610", Offset = "0x3AEBA10", VA = "0x183AEC610", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public JOBDKIKOJGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BCBNBJJJLOL<T> : GNEDGJMCKDF<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x46C2BC0", Offset = "0x46C1FC0", VA = "0x1846C2BC0", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3EB94F0", Offset = "0x3EB88F0", VA = "0x183EB94F0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x46C2C30", Offset = "0x46C2030", VA = "0x1846C2C30", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9490", Offset = "0x3EB8890", VA = "0x183EB9490", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public BCBNBJJJLOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NMNEAECCBLC<T> : GNEDGJMCKDF<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EB93B0", Offset = "0x3EB87B0", VA = "0x183EB93B0", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EB94F0", Offset = "0x3EB88F0", VA = "0x183EB94F0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9420", Offset = "0x3EB8820", VA = "0x183EB9420", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9490", Offset = "0x3EB8890", VA = "0x183EB9490", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public NMNEAECCBLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IBFNOLKDMCN<T> : GNEDGJMCKDF<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x38C8AB0", Offset = "0x38C7EB0", VA = "0x1838C8AB0", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x38C8BF0", Offset = "0x38C7FF0", VA = "0x1838C8BF0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x38C8B20", Offset = "0x38C7F20", VA = "0x1838C8B20", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x38C8B90", Offset = "0x38C7F90", VA = "0x1838C8B90", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public IBFNOLKDMCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OECJDBLIHHP<T> : GNEDGJMCKDF<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BE20", Offset = "0x3F8B220", VA = "0x183F8BE20", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x38C8BF0", Offset = "0x38C7FF0", VA = "0x1838C8BF0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BE90", Offset = "0x3F8B290", VA = "0x183F8BE90", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x38C8B90", Offset = "0x38C7F90", VA = "0x1838C8B90", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public OECJDBLIHHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class KDOJODIIFMH<T> : GNEDGJMCKDF<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB10", Offset = "0x3B2EF10", VA = "0x183B2FB10", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FBF0", Offset = "0x3B2EFF0", VA = "0x183B2FBF0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB80", Offset = "0x3B2EF80", VA = "0x183B2FB80", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x374FBB0", Offset = "0x374EFB0", VA = "0x18374FBB0", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public KDOJODIIFMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class DBFJABHHNMB<T> : GNEDGJMCKDF<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB10", Offset = "0x3B2EF10", VA = "0x183B2FB10", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FBF0", Offset = "0x3B2EFF0", VA = "0x183B2FBF0", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F8A420", Offset = "0x4F89820", VA = "0x184F8A420", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x374FBB0", Offset = "0x374EFB0", VA = "0x18374FBB0", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public DBFJABHHNMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class MJPJBCLDCGN<T> : GNEDGJMCKDF<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C480", Offset = "0x3E0B880", VA = "0x183E0C480", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C560", Offset = "0x3E0B960", VA = "0x183E0C560", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C4F0", Offset = "0x3E0B8F0", VA = "0x183E0C4F0", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC610", Offset = "0x3AEBA10", VA = "0x183AEC610", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public MJPJBCLDCGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MNKEEONNFEM<T> : GNEDGJMCKDF<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E18360", Offset = "0x3E17760", VA = "0x183E18360", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E18440", Offset = "0x3E17840", VA = "0x183E18440", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E183D0", Offset = "0x3E177D0", VA = "0x183E183D0", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x38C8B90", Offset = "0x38C7F90", VA = "0x1838C8B90", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public MNKEEONNFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class AIPCAFDOHND<T> : GNEDGJMCKDF<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x374FAD0", Offset = "0x374EED0", VA = "0x18374FAD0", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x374FC10", Offset = "0x374F010", VA = "0x18374FC10", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x374FB40", Offset = "0x374EF40", VA = "0x18374FB40", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x374FBB0", Offset = "0x374EFB0", VA = "0x18374FBB0", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32F05B0", Offset = "0x32EF9B0", VA = "0x1832F05B0")]
		public AIPCAFDOHND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HCGKOHHOOLP<T> : LGMNDCIOHCP<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3808560", Offset = "0x3807960", VA = "0x183808560", Slot = "12")]
		protected override void HNHOCKFPCGN(CABDOBDNBBH GMIOCALJPJN, char OCPJGGBCFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3808590", Offset = "0x3807990", VA = "0x183808590", Slot = "11")]
		protected override void KMHMCDLHAIG(MNLPDEICHPD LFEGGLDFJIF, [Out] char OCPJGGBCFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x36B9820", Offset = "0x36B8C20", VA = "0x1836B9820")]
		public HCGKOHHOOLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KFPGIBPKJGC<T> : LGMNDCIOHCP<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3B36F80", Offset = "0x3B36380", VA = "0x183B36F80", Slot = "12")]
		protected override void HNHOCKFPCGN(CABDOBDNBBH GMIOCALJPJN, IPEndPoint OCPJGGBCFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B36FB0", Offset = "0x3B363B0", VA = "0x183B36FB0", Slot = "11")]
		protected override void KMHMCDLHAIG(MNLPDEICHPD LFEGGLDFJIF, [Out] IPEndPoint OCPJGGBCFMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x36B9820", Offset = "0x36B8C20", VA = "0x1836B9820")]
		public KFPGIBPKJGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BINCEDOJNHH<T> : GNEDGJMCKDF<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int CAHOFAOPFIO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x470E8C0", Offset = "0x470DCC0", VA = "0x18470E8C0")]
		public BINCEDOJNHH(int GHHLCKKCGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x470E700", Offset = "0x470DB00", VA = "0x18470E700", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x470E850", Offset = "0x470DC50", VA = "0x18470E850", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x470E770", Offset = "0x470DB70", VA = "0x18470E770", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x470E7E0", Offset = "0x470DBE0", VA = "0x18470E7E0", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class LOMAAEELNCB<T> : MLPEKEMGOAA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo EGPAEBHJNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type KCIGHBLMGLO;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C45FE0", Offset = "0x3C453E0", VA = "0x183C45FE0")]
		public LOMAAEELNCB(PropertyInfo JAOOJJKNLDO, Type FABCLOHKJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C45CF0", Offset = "0x3C450F0", VA = "0x183C45CF0", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C45F30", Offset = "0x3C45330", VA = "0x183C45F30", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C45DB0", Offset = "0x3C451B0", VA = "0x183C45DB0", Slot = "7")]
		public override void CHLOJGPHBEB(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C45ED0", Offset = "0x3C452D0", VA = "0x183C45ED0", Slot = "8")]
		public override void LDHNHICOPLI(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C45E10", Offset = "0x3C45210", VA = "0x183C45E10", Slot = "9")]
		public override void GBAFPPGCBJG(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C45E70", Offset = "0x3C45270", VA = "0x183C45E70", Slot = "10")]
		public override void JCJKCLBMGBG(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class JCAAJPJMDND<T> : LOMAAEELNCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x32BE040", Offset = "0x32BD440", VA = "0x1832BE040")]
		public JCAAJPJMDND(PropertyInfo JAOOJJKNLDO, Type FABCLOHKJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9680", Offset = "0x3AA8A80", VA = "0x183AA9680", Slot = "5")]
		public override void AIILFPAFKIJ(T PLMEDPGBOKH, MNLPDEICHPD LFEGGLDFJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9740", Offset = "0x3AA8B40", VA = "0x183AA9740", Slot = "6")]
		public override void MHFGNJJJAHD(T PLMEDPGBOKH, CABDOBDNBBH GMIOCALJPJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GLFKCNHPMEI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static GLFKCNHPMEI<T> OKALMGBNAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly MLPEKEMGOAA<T>[] KIJOBJGJNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int DBHMHBJKMMG;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x37BB080", Offset = "0x37BA480", VA = "0x1837BB080")]
		public GLFKCNHPMEI(List<MLPEKEMGOAA<T>> DCNPGEOLCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x37BAFD0", Offset = "0x37BA3D0", VA = "0x1837BAFD0")]
		public void MHFGNJJJAHD(T DFFBALIDCLL, CABDOBDNBBH FJHMPBLBMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x37BAF20", Offset = "0x37BA320", VA = "0x1837BAF20")]
		public void AIILFPAFKIJ(T DFFBALIDCLL, MNLPDEICHPD MAACBPKBLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NJFJJDLEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract MLPEKEMGOAA<T> LBFOALNGCEO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private CABDOBDNBBH NEDJELLHJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int COKMFEJKGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, NJFJJDLEAOJ> GPGILIJABLF;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x54D41C0", Offset = "0x54D35C0", VA = "0x1854D41C0")]
	public JJHOANPGHHF(int INGEICKKPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x266BFF0", Offset = "0x266B3F0", VA = "0x18266BFF0")]
	private GLFKCNHPMEI<T> NKCLLCHHEPL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x23F1C10", Offset = "0x23F1010", VA = "0x1823F1C10")]
	public void OAIKDCNGOPG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x266BF10", Offset = "0x266B310", VA = "0x18266BF10")]
	public bool BOEOGBDBLGM<T>(MNLPDEICHPD MAACBPKBLAG, T GOOANMNBGEP) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x266BF90", Offset = "0x266B390", VA = "0x18266BF90")]
	public void GOGJDIDOEDD<T>(CABDOBDNBBH FJHMPBLBMAF, T DFFBALIDCLL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JLPBIDAFGPP
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime KEGJHAAMPJH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GGCDCPOOPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HMOODFHFJNG FPDHAOGLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x54D4940", Offset = "0x54D3D40", VA = "0x1854D4940")]
		get
		{
			return default(HMOODFHFJNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OOJJHAPMJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x54D4970", Offset = "0x54D3D70", VA = "0x1854D4970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x54D4C00", Offset = "0x54D4000", VA = "0x1854D4C00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IOPBDOJCONH KJAMDHPFLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x54D4CB0", Offset = "0x54D40B0", VA = "0x1854D4CB0")]
		get
		{
			return default(IOPBDOJCONH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x54D4C40", Offset = "0x54D4040", VA = "0x1854D4C40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PGJANKPKFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x54D4910", Offset = "0x54D3D10", VA = "0x1854D4910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint HPKNAFCKNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x54D4CE0", Offset = "0x54D40E0", VA = "0x1854D4CE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? JCDGIKBILCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x54D4260", Offset = "0x54D3660", VA = "0x1854D4260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? AGBNABOEGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x54D4C80", Offset = "0x54D4080", VA = "0x1854D4C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KBLFFGJCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x54D48E0", Offset = "0x54D3CE0", VA = "0x1854D48E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x54D4D60", Offset = "0x54D4160", VA = "0x1854D4D60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? EBHEBHPPGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA31A50", Offset = "0xA30E50", VA = "0x180A31A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88E060", Offset = "0x88D460", VA = "0x18088E060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54D5220", Offset = "0x54D4620", VA = "0x1854D5220")]
	public JLPBIDAFGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54D5540", Offset = "0x54D4940", VA = "0x1854D5540")]
	internal JLPBIDAFGPP(byte[] KLMLFNDOPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54D4700", Offset = "0x54D3B00", VA = "0x1854D4700")]
	public static JLPBIDAFGPP CKKDHOELNJN(byte[] KLMLFNDOPAB, DateTime HFBPFKOJAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54D4F30", Offset = "0x54D4330", VA = "0x1854D4F30")]
	internal void NLCGHEPDJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54D4290", Offset = "0x54D3690", VA = "0x1854D4290")]
	private void CDMEBLNJFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54D4A00", Offset = "0x54D3E00", VA = "0x1854D4A00")]
	private DateTime? IOCOLIGMEBA(int EIJFICIEABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54D4530", Offset = "0x54D3930", VA = "0x1854D4530")]
	private void CKFDKJNAMPL(int EIJFICIEABK, DateTime? PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54D4460", Offset = "0x54D3860", VA = "0x1854D4460")]
	private ulong CFHIGOJPGEJ(int EIJFICIEABK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x54D4820", Offset = "0x54D3C20", VA = "0x1854D4820")]
	private void FGFKCPOMEJO(int EIJFICIEABK, ulong PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x54D5130", Offset = "0x54D4530", VA = "0x1854D5130")]
	private uint OGLKOLKHOFD(int EIJFICIEABK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x53BA720", Offset = "0x53B9B20", VA = "0x1853BA720")]
	private static uint ICDHNDCBPMN(uint FHDILOGEHPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x54D49A0", Offset = "0x54D3DA0", VA = "0x1854D49A0")]
	private static ulong ICDHNDCBPMN(ulong FHDILOGEHPC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HMOODFHFJNG
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
public enum IOPBDOJCONH
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HOEPEOCBIFO
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int CNBIEEHEEPL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int MMJBLFIEHLG = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int NNJPONDCENJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint KENMHOJBHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int BNPJKLAABCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int ICFJDKFHFIM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool AEFCJOJEPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x54D41B0", Offset = "0x54D35B0", VA = "0x1854D41B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x54D40C0", Offset = "0x54D34C0", VA = "0x1854D40C0")]
	public bool BMCAACKFALF(HFEKCBBOMAJ PFHAHHMJGOC, int HKJHKEPHGIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HCFFGLDDJPP : HFEKCBBOMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket PFHAHHMJGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly NJOMLOBNNBL EEFGCKAKOEK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short JCKEBFMGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x54D2E70", Offset = "0x54D2270", VA = "0x1854D2E70", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int IGLCJCLKFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x54D2E30", Offset = "0x54D2230", VA = "0x1854D2E30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint EJKFHJILCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x54D2D20", Offset = "0x54D2120", VA = "0x1854D2D20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily FNDEKHIFFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BE0B30", Offset = "0x3BDFF30", VA = "0x183BE0B30", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x54D3450", Offset = "0x54D2850", VA = "0x1854D3450")]
	public HCFFGLDDJPP(AddressFamily DDPLIIOJLAE, NJOMLOBNNBL EEFGCKAKOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x54D2E90", Offset = "0x54D2290", VA = "0x1854D2E90", Slot = "8")]
	public bool MLJCLENBDAL(IPEndPoint JAHNDKCJALJ, GAGIOMFLELC KLHOPPAIPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x54D2CE0", Offset = "0x54D20E0", VA = "0x1854D2CE0", Slot = "9")]
	public int ACBGDLEEINL(byte[] NKGLIMPLOMB, int EIJFICIEABK, int KKEOKHMHDHC, IPEndPoint MEAEICACBON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x54D2D40", Offset = "0x54D2140", VA = "0x1854D2D40", Slot = "10")]
	public int BKHNLAAEMPK(byte[] NKGLIMPLOMB, EndPoint JBHAOLEEGLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x54D2E50", Offset = "0x54D2250", VA = "0x1854D2E50", Slot = "11")]
	public void HLCJNINLFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface HFEKCBBOMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short JCKEBFMGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int IGLCJCLKFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint EJKFHJILCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily FNDEKHIFFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLJCLENBDAL(IPEndPoint JAHNDKCJALJ, GAGIOMFLELC KLHOPPAIPBN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int ACBGDLEEINL(byte[] NKGLIMPLOMB, int EIJFICIEABK, int KKEOKHMHDHC, IPEndPoint MEAEICACBON);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BKHNLAAEMPK(byte[] NKGLIMPLOMB, EndPoint MEAEICACBON);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLCJNINLFGH();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct KPLJADDJLIH : IEquatable<KPLJADDJLIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long OOJFFFNBJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long KPDFGBECDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long NAHKBEOBJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int FKKBBONFFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int NJKELHMJDPC;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x54D57C0", Offset = "0x54D4BC0", VA = "0x1854D57C0")]
	public KPLJADDJLIH(byte[] LBCMLBDKDMC, int KGNBNCBDIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E80", Offset = "0x7B8280", VA = "0x1807B8E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x54D5780", Offset = "0x54D4B80", VA = "0x1854D5780", Slot = "4")]
	public bool Equals(KPLJADDJLIH JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x54D56D0", Offset = "0x54D4AD0", VA = "0x1854D56D0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JCOFDMDMHJI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] CBNHBKKFFNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HINEDBPOBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int KCHICBGLMLA;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
	protected HINEDBPOBIK(int DGEEEEIKNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LOEPPLPLKDM(IPEndPoint JAHNDKCJALJ, byte[] GMLIPIALCHN, int EIJFICIEABK, int OGHJPGGPGJL);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JJCNDDLGHFK(IPEndPoint JAHNDKCJALJ, byte[] GMLIPIALCHN, int EIJFICIEABK, int OGHJPGGPGJL);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ANKIICGJFKG : HINEDBPOBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider GHEPOIPMNBI;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator NPAOCLGPMFG;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x54CB860", Offset = "0x54CAC60", VA = "0x1854CB860")]
	public ANKIICGJFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x54CB0A0", Offset = "0x54CA4A0", VA = "0x1854CB0A0")]
	public void LFIBLNEKKPA(IPEndPoint JAHNDKCJALJ, byte[] CONEAMPCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x54CAC20", Offset = "0x54CA020", VA = "0x1854CAC20")]
	public void ECAPFPJILPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x54CB770", Offset = "0x54CAB70", VA = "0x1854CB770")]
	private byte[] NFPBDBACIDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x54CB2E0", Offset = "0x54CA6E0", VA = "0x1854CB2E0", Slot = "4")]
	public override void LOEPPLPLKDM(IPEndPoint JAHNDKCJALJ, byte[] GMLIPIALCHN, int EIJFICIEABK, int OGHJPGGPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x54CAD00", Offset = "0x54CA100", VA = "0x1854CAD00", Slot = "5")]
	public override void JJCNDDLGHFK(IPEndPoint JAHNDKCJALJ, byte[] GMLIPIALCHN, int EIJFICIEABK, int OGHJPGGPGJL)
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
