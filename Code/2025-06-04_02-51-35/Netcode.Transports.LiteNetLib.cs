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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CEAANODABEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JOHJGCGFIFJ
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
		private NetworkManager DALEPMPADKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GCDCCHOALAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, IBADCALEOIN> OGGDAKNENKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DKFAECCGDKF ALLJDLKNPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch FOOHOMPDGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] CBHCLHKINCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JOHJGCGFIFJ PJJOFNBKODA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int FKIKDEKEFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x720ADB0", Offset = "0x72095B0", VA = "0x18720ADB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong KAFOLOODLBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool LLGDHJGNHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x720AD90", Offset = "0x7209590", VA = "0x18720AD90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x720A330", Offset = "0x7208B30", VA = "0x18720A330")]
		public void RecRoom_SetEncryptionInfo(ulong KHNIEFGEDEF, byte[] MNMCNOJCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x720A310", Offset = "0x7208B10", VA = "0x18720A310")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x720A1E0", Offset = "0x72089E0", VA = "0x18720A1E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x720AC90", Offset = "0x7209490", VA = "0x18720AC90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x720A450", Offset = "0x7208C50", VA = "0x18720A450", Slot = "6")]
		public override void Send(ulong MAGIPLDDFJB, ArraySegment<byte> IMINNNCPCJF, NetworkDelivery EMKJMMHEHBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x720A2D0", Offset = "0x7208AD0", VA = "0x18720A2D0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong MAGIPLDDFJB, [Out] ArraySegment<byte> OILJBDLKBKC, [Out] float GEPDILJHKID)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x720A740", Offset = "0x7208F40", VA = "0x18720A740", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x720AAB0", Offset = "0x72092B0", VA = "0x18720AAB0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7209820", Offset = "0x7208020", VA = "0x187209820", Slot = "11")]
		public override void DisconnectRemoteClient(ulong MAGIPLDDFJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7209730", Offset = "0x7207F30", VA = "0x187209730", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7209A70", Offset = "0x7208270", VA = "0x187209A70", Slot = "13")]
		public override ulong GetCurrentRtt(ulong MAGIPLDDFJB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x720A6D0", Offset = "0x7208ED0", VA = "0x18720A6D0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7209CC0", Offset = "0x72084C0", VA = "0x187209CC0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager DALEPMPADKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7209BF0", Offset = "0x72083F0", VA = "0x187209BF0")]
		private CMBBKPPDBMC IKOBIBICFOE(NetworkDelivery CEPGAJKBPDM)
		{
			return default(CMBBKPPDBMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7209990", Offset = "0x7208190", VA = "0x187209990", Slot = "16")]
		private void FIOFGMGBDCG(IBADCALEOIN AONNECHAJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7209ED0", Offset = "0x72086D0", VA = "0x187209ED0", Slot = "17")]
		private void JHFPPEOEFPP(IBADCALEOIN AONNECHAJFA, HJFEBOEDKMC HBMHOADLJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "18")]
		private void DKABMFPPCOK(IPEndPoint FHKNBKEGLKC, SocketError NJDFOCODCJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7209FD0", Offset = "0x72087D0", VA = "0x187209FD0", Slot = "19")]
		private void OMKGIHEOFCL(IBADCALEOIN AONNECHAJFA, POPBGHDJKBD JEPFPDOKDAD, byte HLICEIHBHCF, CMBBKPPDBMC JIHPHHEILOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7209B10", Offset = "0x7208310", VA = "0x187209B10")]
		private void ICEEKFCGFDP(int GGIJOHIPOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
		private void KKBNDOABPHE(IPEndPoint FOLKAOGOLAI, POPBGHDJKBD JEPFPDOKDAD, HLDOHDCCCIC DOEMBJJOFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "21")]
		private void BPFGHOAMKHM(IBADCALEOIN AONNECHAJFA, int BKGNPMKMKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7209930", Offset = "0x7208130", VA = "0x187209930", Slot = "22")]
		private void FEKJJELEEOF(ICBNKOFNEEI FLPDPHNPDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7209FA0", Offset = "0x72087A0", VA = "0x187209FA0")]
		private ulong MINMHLBKAEB(IBADCALEOIN AONNECHAJFA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7209A50", Offset = "0x7208250", VA = "0x187209A50")]
		private static int FMIHDMJOFJA(float AFBFHAPCPPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x720ACB0", Offset = "0x72094B0", VA = "0x18720ACB0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class OELHGOBDGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly IBADCALEOIN PKOKMINIPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<BNGJDGDAELF> LNGMKMLJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int HHLGEPCAKBB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MJPGOMIGPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x720DE10", Offset = "0x720C610", VA = "0x18720DE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x720DE60", Offset = "0x720C660", VA = "0x18720DE60")]
	protected OELHGOBDGEC(IBADCALEOIN AONNECHAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x720DDB0", Offset = "0x720C5B0", VA = "0x18720DDB0")]
	public void FIDDLIHEHAP(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x720DD30", Offset = "0x720C530", VA = "0x18720DD30")]
	protected void EPNKCALNHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x720DCF0", Offset = "0x720C4F0", VA = "0x18720DCF0")]
	public bool AOMGBBLONDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool KFKBGJMPBCA();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AEBNGBIGMJE(BNGJDGDAELF OJCCIFECMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum KEMBGOEHHFK
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
public class ICBNKOFNEEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DKFAECCGDKF PBDGMMKLGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int EBOCGHHOPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal LADHGLLGEMC ILNOJEBLGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint LKHJDOKAMHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal KEMBGOEHHFK EOJDHIBJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
		[CompilerGenerated]
		get
		{
			return default(KEMBGOEHHFK);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7206990", Offset = "0x7205190", VA = "0x187206990")]
	internal void DNPMHAEHNKP(LADHGLLGEMC JNJKMNGNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7206A50", Offset = "0x7205250", VA = "0x187206A50")]
	private bool NOOKICIOCDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7206A80", Offset = "0x7205280", VA = "0x187206A80")]
	internal ICBNKOFNEEI(IPEndPoint FOLKAOGOLAI, LADHGLLGEMC ICLJIJBJCPJ, DKFAECCGDKF NAHFLHINHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72069F0", Offset = "0x72051F0", VA = "0x1872069F0")]
	public IBADCALEOIN FHGAANEKBGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HLDOHDCCCIC
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum NGIPFEBMDLC
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
public struct HJFEBOEDKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NGIPFEBMDLC JOFMIGJJLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError INHJOMNEHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public POPBGHDJKBD EAAHOHAFDCK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CEAANODABEL
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKCKINLDLCC(IBADCALEOIN AONNECHAJFA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBLBCCAPBIO(IBADCALEOIN AONNECHAJFA, HJFEBOEDKMC HBMHOADLJHP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDMLOLJHMIM(IPEndPoint FHKNBKEGLKC, SocketError NJDFOCODCJP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDNKGBEAKDI(IBADCALEOIN AONNECHAJFA, POPBGHDJKBD JEPFPDOKDAD, byte HLICEIHBHCF, CMBBKPPDBMC JIHPHHEILOB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACIJFPIJDHE(IPEndPoint FOLKAOGOLAI, POPBGHDJKBD JEPFPDOKDAD, HLDOHDCCCIC DOEMBJJOFCC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGJDJFGMOHG(IBADCALEOIN AONNECHAJFA, int BKGNPMKMKIO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GPCJIBDOHNH(ICBNKOFNEEI FLPDPHNPDPK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGPLDGNEPBN
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKLODGCGAEP(IBADCALEOIN AONNECHAJFA, object IHFHALOOKJH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KKDNOKIKEMD
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHDJHBOHDF(GKDILCOOINK OJCCIFECMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DDIHFHBKELO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJNPFMACJKD(IBADCALEOIN AONNECHAJFA, IPEndPoint KLMDGLJJDMG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LADHGLLGEMC
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int IDPGLNJIKHF = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long FEHGNLBJNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte GNCNLNACCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] HAOHDDJDIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly JENGFOBOAEM KFMKJLCMCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int BHJILMFCLMG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7209650", Offset = "0x7207E50", VA = "0x187209650")]
	private LADHGLLGEMC(long EDIJKKCOBAJ, byte BAIFLHECOHC, int MIKNGKGCFKJ, byte[] HJBIBDKEPMM, JENGFOBOAEM IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72091F0", Offset = "0x72079F0", VA = "0x1872091F0")]
	public static int CEOFMDIIPMM(BNGJDGDAELF OJCCIFECMAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7209250", Offset = "0x7207A50", VA = "0x187209250")]
	public static LADHGLLGEMC JPMGKHEPDOD(BNGJDGDAELF OJCCIFECMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7209470", Offset = "0x7207C70", VA = "0x187209470")]
	public static BNGJDGDAELF LGKJMJMHCLC(IDEOABGMLEB HBBEGGIOCIM, SocketAddress MMGLDNBFAFL, long PAGJBFKMNOD, int MIKNGKGCFKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class NHPHJDDBNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long FEHGNLBJNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte GNCNLNACCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int BHJILMFCLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool CFDBAMEDICN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x720D440", Offset = "0x720BC40", VA = "0x18720D440")]
	private NHPHJDDBNHL(long EDIJKKCOBAJ, byte BAIFLHECOHC, int OBNOAFGJIMC, bool CABFFDIDOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x720D100", Offset = "0x720B900", VA = "0x18720D100")]
	public static NHPHJDDBNHL JPMGKHEPDOD(BNGJDGDAELF OJCCIFECMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x720D250", Offset = "0x720BA50", VA = "0x18720D250")]
	public static BNGJDGDAELF LGKJMJMHCLC(long PAGJBFKMNOD, byte PFCPKKEFELJ, int HOCEOBNLBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x720D340", Offset = "0x720BB40", VA = "0x18720D340")]
	public static BNGJDGDAELF MBPGJIGJHPO(IBADCALEOIN AONNECHAJFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum ACAJEEFHEDB
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MOIBFKIBLPE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIBPNGEIGIF(IPEndPoint FOEPJHLGHGB, IPEndPoint FOLKAOGOLAI, string KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHJCMIJEHK(IPEndPoint PPOGAPKMNOJ, ACAJEEFHEDB CEPGAJKBPDM, string KAJENDFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EMCHMDBJIGN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MMPCIICGDNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint EJGAANGNPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint LKHJDOKAMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string HHKMJGAKFPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct JHEMMOOJOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint FLPNLKGICFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ACAJEEFHEDB PBNBGAHIAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string HHKMJGAKFPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class DHDFADCCPPE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint KLAKKFBHJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string HHKMJGAKFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DHDFADCCPPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class LPBIFDPPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint KLAKKFBHJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint OFJKMKKJDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HHKMJGAKFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LPBIFDPPLCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class FPFDOBOBLAB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string HHKMJGAKFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PNOJNBLNPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FPFDOBOBLAB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DKFAECCGDKF JCICHLEAOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<MMPCIICGDNI> JCIKALCNNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<JHEMMOOJOJF> ALMALHGDOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly JENGFOBOAEM DJMFOPDJCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IDEOABGMLEB BLPNDANFLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly MFEIBPLKBNA KFIAJAEBOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private MOIBFKIBLPE FNBDAMGIPBJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int PGMJNBJKPKJ = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool KINPIMKGOCC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72008C0", Offset = "0x71FF0C0", VA = "0x1872008C0")]
	internal EMCHMDBJIGN(DKFAECCGDKF JGEKKGJKHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72002D0", Offset = "0x71FEAD0", VA = "0x1872002D0")]
	internal void CCJINFABBIE(IPEndPoint ACBGAFMADGG, BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3849860", Offset = "0x3848060", VA = "0x183849860")]
	private void GGJCANIPOHP<T>(T OJCCIFECMAB, IPEndPoint OLBBKGLINIK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72005E0", Offset = "0x71FEDE0", VA = "0x1872005E0")]
	private void MIBPNGEIGIF(DHDFADCCPPE GPGGEEKHCOP, IPEndPoint ACBGAFMADGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7200760", Offset = "0x71FEF60", VA = "0x187200760")]
	private void OBKGICLGAOP(LPBIFDPPLCD GPGGEEKHCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7200450", Offset = "0x71FEC50", VA = "0x187200450")]
	private void KNKHKAJHBEA(FPFDOBOBLAB GPGGEEKHCOP, IPEndPoint ACBGAFMADGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CMBBKPPDBMC : byte
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
public enum PHGEEFFCCJB : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KEDJEIABOGI
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] BCADANINBBC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int CEEOKNOFGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int MPEPBCMFIGA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AJKNCGNJCEM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x71F69F0", Offset = "0x71F51F0", VA = "0x1871F69F0")]
	public AJKNCGNJCEM(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JBHJNKKPCPI : AJKNCGNJCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71F69F0", Offset = "0x71F51F0", VA = "0x1871F69F0")]
	public JBHJNKKPCPI(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum MFEANHIBPLM
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
public interface IJOCEADJGKM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIBNCDDFHKP(MFEANHIBPLM KAKLHNDEIKE, string FIBFJHPJKOF, params object[] JALDLFHONHH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NDOBIOHCBJN
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static IJOCEADJGKM ICEFMMKHECM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object GPKAPFEOFOG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x720CD60", Offset = "0x720B560", VA = "0x18720CD60")]
	private static void HICGLCDALJB(MFEANHIBPLM JOODIEKJMPC, string FIBFJHPJKOF, params object[] JALDLFHONHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x720CFF0", Offset = "0x720B7F0", VA = "0x18720CFF0")]
	internal static void NBNKGJOKMPD(string FIBFJHPJKOF, params object[] JALDLFHONHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x720CD00", Offset = "0x720B500", VA = "0x18720CD00")]
	internal static void BOAEIECCGCM(string FIBFJHPJKOF, params object[] JALDLFHONHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x720CF90", Offset = "0x720B790", VA = "0x18720CF90")]
	internal static void HLEECCOLIHN(string FIBFJHPJKOF, params object[] JALDLFHONHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum OJHJFNCDLFP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class POPBGHDJKBD : JENGFOBOAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private BNGJDGDAELF KPCBEADOCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly DKFAECCGDKF HDIEMNLDDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IFNBOHCEKAG AAEOBGIHGHF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x720E7D0", Offset = "0x720CFD0", VA = "0x18720E7D0")]
	internal POPBGHDJKBD(DKFAECCGDKF EGOJLGMOLFK, IFNBOHCEKAG GPLJMGHJPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x720E6B0", Offset = "0x720CEB0", VA = "0x18720E6B0")]
	internal void ABFKDPPIPDG(BNGJDGDAELF OJCCIFECMAB, int EOOMGDMELLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x720E750", Offset = "0x720CF50", VA = "0x18720E750")]
	internal void EBKMOJHEMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x720E720", Offset = "0x720CF20", VA = "0x18720E720")]
	public void CGCPBJDDMGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class IFNBOHCEKAG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum POGIBPBBIJC
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
	public IFNBOHCEKAG ALDBJLLBKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public POGIBPBBIJC PBNBGAHIAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IBADCALEOIN PKOKMINIPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint LKHJDOKAMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object OCIAPEPIAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int LHCMGBBBEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError OKFHJDBBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NGIPFEBMDLC EMMOJALPNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public ICBNKOFNEEI IKJGAPDHFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public CMBBKPPDBMC GGDCPAHBOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte MLCEHEMOMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly POPBGHDJKBD MHJBEHCBEKI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7207930", Offset = "0x7206130", VA = "0x187207930")]
	public IFNBOHCEKAG(DKFAECCGDKF EGOJLGMOLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DKFAECCGDKF : IEnumerable<IBADCALEOIN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class LMPGHOMKBCJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72096C0", Offset = "0x7207EC0", VA = "0x1872096C0", Slot = "4")]
		public bool Equals(IPEndPoint BDGPJOKJNIL, IPEndPoint HDAFCDJNHAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EBE0", Offset = "0x6D6D3E0", VA = "0x186D6EBE0", Slot = "5")]
		public int GetHashCode(IPEndPoint HPLLAPMNIJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LMPGHOMKBCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CDKBMEKCBOO : IEnumerator<IBADCALEOIN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly IBADCALEOIN IKNLPIPFLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private IBADCALEOIN CLDNICALBEI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IBADCALEOIN EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AEE100", Offset = "0x1AEC900", VA = "0x181AEE100")]
		public CDKBMEKCBOO(IBADCALEOIN LNKCJPMONLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x71F7CE0", Offset = "0x71F64E0", VA = "0x1871F7CE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71F7D30", Offset = "0x71F6530", VA = "0x1871F7D30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread GAAFCHAHJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool FOJJPGLPJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool LJKEFFFAPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private KNIFLBKECKF GAGEIMOCKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent FPIOPKKLCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<IFNBOHCEKAG> BGIBDINLKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<IFNBOHCEKAG> MHBBKLDEGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IFNBOHCEKAG FGGBHDLNLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CEAANODABEL PNDLEPCBOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly AGPLDGNEPBN LBNFPGKNKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly KKDNOKIKEMD OOINIIBKBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly DDIHFHBKELO NEIEEBDAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, IBADCALEOIN> PIJOCPBACBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, ICBNKOFNEEI> LNCCILAELOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, AAKDMFJKLEE> MBHBHGGNDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim OCHANJFFPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IBADCALEOIN CGCJOBNPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int JILKBBLCBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<IBADCALEOIN> BAKDHPMECML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private IBADCALEOIN[] KOHPNMJLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JGMBMFCAODI BFIIPMENHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int AMMEKKLDCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> PKPJLMONNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte FNGFNABBMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object NILFMIBNJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool LDEADDLPGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool EDNMLFCECFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int KGLNGCGODPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int LKCKPLNOEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int IDKPKOMCMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int KGCLPEMEMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HDCIKEIOMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool FGIHEBLHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int GKOGFAOPMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BPGAPCDJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int IKLNBMDICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool KINPIMKGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JPCPGEPPGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool DLAEIPPNINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool DGMNLOEAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int NJCOPLGOOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int KCPGJCPIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool JCLDJBAGJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly OHNPBNEMKMG FKDCBKNJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool LGPJAJKPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly EMCHMDBJIGN CAJMJDMHEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool HEIMCCJCIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public OJHJFNCDLFP LPNCNJGFLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int JFGLCNHNFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool PPPPNABIPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool MHCIFEPMANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool BMAOPFDOAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool JNNAEPNHPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BNGJDGDAELF HCLCOKDFING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BJGJBFHMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object NOFCAEAEPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private BNGJDGDAELF FNCGDIMLBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CAAMJFANJLI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int LLEAGNFOEEH = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int DOHPHHKMLON = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NHHHPNJEMBE BGCLODEOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NHHHPNJEMBE LBJJCOMOHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread MFHPHPKNPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread KCLHEOEPHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint ALDHBFKOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint CKAEOFDGKAA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] ALJLNOMDAIL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] BIMFMMGNMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<FGPLJMAMDME, IPEndPoint> BKHBEIPKCOI;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress KPCHLNKGGBL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool KBDMIDJDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int LHAEKADPLCK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CDOKICCNJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB2B610", Offset = "0xB29E10", VA = "0x180B2B610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB30780", Offset = "0xB2EF80", VA = "0x180B30780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GKGCMNPDMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x165A170", Offset = "0x1658970", VA = "0x18165A170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F41C60", Offset = "0x1F40460", VA = "0x181F41C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte DHAMDKLFOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xF77E80", Offset = "0xF76680", VA = "0x180F77E80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FCMIGDKHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x71FEBF0", Offset = "0x71FD3F0", VA = "0x1871FEBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short OOIOAAOBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71FA7F0", Offset = "0x71F8FF0", VA = "0x1871FA7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IBADCALEOIN.HLPKHDOPMGG MKHKDPAFMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71FF660", Offset = "0x71FDE60", VA = "0x1871FF660")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71FA680", Offset = "0x71F8E80", VA = "0x1871FA680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71F92B0", Offset = "0x71F7AB0", VA = "0x1871F92B0")]
	public void BOOPIMFIMNP(IPEndPoint FHKNBKEGLKC, byte[] MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x71FDE80", Offset = "0x71FC680", VA = "0x1871FDE80")]
	public void JHCAJNJABLL(IPEndPoint FHKNBKEGLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71F91C0", Offset = "0x71F79C0", VA = "0x1871F91C0")]
	private bool BGMFAMKBAIM(IPEndPoint FHKNBKEGLKC, [Out] IBADCALEOIN AONNECHAJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71F94D0", Offset = "0x71F7CD0", VA = "0x1871F94D0")]
	private void CEDPIKDOBBH(IBADCALEOIN AONNECHAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71FF710", Offset = "0x71FDF10", VA = "0x1871FF710")]
	private void NJDOMEOHMJH(IBADCALEOIN AONNECHAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71FA3B0", Offset = "0x71F8BB0", VA = "0x1871FA3B0")]
	private void EHPMHBBBCDJ(IBADCALEOIN AONNECHAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x71FFC70", Offset = "0x71FE470", VA = "0x1871FFC70")]
	public DKFAECCGDKF(CEAANODABEL NAHFLHINHBF, [Optional] JGMBMFCAODI LKANPGICAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x71F9C70", Offset = "0x71F8470", VA = "0x1871F9C70")]
	internal void DAJHBAGNNAE(IBADCALEOIN JGENAPFAMJD, int BKGNPMKMKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71F9260", Offset = "0x71F7A60", VA = "0x1871F9260")]
	internal void BJHOHAKIMPE(IBADCALEOIN JGENAPFAMJD, object IHFHALOOKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71FA750", Offset = "0x71F8F50", VA = "0x1871FA750")]
	internal void FHFNAFFPOGF(IBADCALEOIN AONNECHAJFA, NGIPFEBMDLC BEPEOMJMPKF, SocketError MPCGOEOMLKJ, BNGJDGDAELF NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71FF210", Offset = "0x71FDA10", VA = "0x1871FF210")]
	private void NFOLHDKFKGA(IBADCALEOIN AONNECHAJFA, NGIPFEBMDLC BEPEOMJMPKF, SocketError MPCGOEOMLKJ, bool IBCIAMDAPFE, byte[] IMINNNCPCJF, int BAGLBFCLNDM, int FMGALNGIOGC, BNGJDGDAELF NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71FEC10", Offset = "0x71FD410", VA = "0x1871FEC10")]
	private void LEPPOHLFLBH(IFNBOHCEKAG.POGIBPBBIJC CEPGAJKBPDM, [Optional] IBADCALEOIN AONNECHAJFA, [Optional] IPEndPoint FOLKAOGOLAI, SocketError ALIHNDLFCFH = SocketError.Success, int BKGNPMKMKIO = 0, NGIPFEBMDLC JJMEPOGCAOF = NGIPFEBMDLC.ConnectionFailed, [Optional] ICBNKOFNEEI KFIIPEHPAKJ, CMBBKPPDBMC JIHPHHEILOB = CMBBKPPDBMC.Unreliable, byte HLICEIHBHCF = 0, [Optional] BNGJDGDAELF MFKHLFJBGLO, [Optional] object IHFHALOOKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71F8550", Offset = "0x71F6D50", VA = "0x1871F8550")]
	private void ACDKKNHNAGM(IFNBOHCEKAG GPLJMGHJPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x71FD850", Offset = "0x71FC050", VA = "0x1871FD850")]
	internal void IJFALBFODIB(IFNBOHCEKAG GPLJMGHJPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71FC420", Offset = "0x71FAC20", VA = "0x1871FC420")]
	private void HFIDBIGFLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71FF770", Offset = "0x71FDF70", VA = "0x1871FF770")]
	private void NKLJIOMJODG(int CMNLMEEHEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71FAA30", Offset = "0x71F9230", VA = "0x1871FAA30")]
	internal IBADCALEOIN HDFKOFHPJGC(ICBNKOFNEEI FLPDPHNPDPK, byte[] GDLOKGKIMLM, int BAGLBFCLNDM, int AEPPOMGGPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x71FEFF0", Offset = "0x71FD7F0", VA = "0x1871FEFF0")]
	private int LFKCFBCCCMA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71F8D10", Offset = "0x71F7510", VA = "0x1871F8D10")]
	private void ADLOAHEAOEN(IPEndPoint FOLKAOGOLAI, IBADCALEOIN KFFOGDALJEE, LADHGLLGEMC KHPHOGGKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71FB050", Offset = "0x71F9850", VA = "0x1871FB050")]
	private void HFDJGLJFAOC(BNGJDGDAELF OJCCIFECMAB, IPEndPoint FOLKAOGOLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71F9990", Offset = "0x71F8190", VA = "0x1871F9990")]
	internal void CIMIJIPMCPP(BNGJDGDAELF OJCCIFECMAB, CMBBKPPDBMC LMGEPDDDDPA, byte HLICEIHBHCF, int EOOMGDMELLN, IBADCALEOIN JGENAPFAMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x71FD7C0", Offset = "0x71FBFC0", VA = "0x1871FD7C0")]
	public bool IDHAAILNKGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71FD830", Offset = "0x71FC030", VA = "0x1871FD830")]
	public bool IDHAAILNKGM(IPAddress MEEGGLOFEKJ, IPAddress ICGLABGHMJB, int DBMMIMBCKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71FCF90", Offset = "0x71FB790", VA = "0x1871FCF90")]
	public bool IDHAAILNKGM(int DBMMIMBCKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71FDCD0", Offset = "0x71FC4D0", VA = "0x1871FDCD0")]
	public void INBPHGJFHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71FDFD0", Offset = "0x71FC7D0", VA = "0x1871FDFD0")]
	public IBADCALEOIN KAAAKEEMNFB(string PKOADNLIJDK, int DBMMIMBCKMG, string MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71FE490", Offset = "0x71FCC90", VA = "0x1871FE490")]
	public IBADCALEOIN KAAAKEEMNFB(string PKOADNLIJDK, int DBMMIMBCKMG, IDEOABGMLEB MHLOMKNLKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71FE0B0", Offset = "0x71FC8B0", VA = "0x1871FE0B0")]
	public IBADCALEOIN KAAAKEEMNFB(IPEndPoint OLBBKGLINIK, IDEOABGMLEB MHLOMKNLKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71FD960", Offset = "0x71FC160", VA = "0x1871FD960")]
	public void IKPCEGHDCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71FD970", Offset = "0x71FC170", VA = "0x1871FD970")]
	public void IKPCEGHDCEL(bool IOBBBDBPNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71F98E0", Offset = "0x71F80E0", VA = "0x1871F98E0")]
	public void CHCMHDJKEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x71F9810", Offset = "0x71F8010", VA = "0x1871F9810")]
	public void CHCMHDJKEHO(byte[] IMINNNCPCJF, int BAGLBFCLNDM, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71FF620", Offset = "0x71FDE20", VA = "0x1871FF620")]
	public void NFOLHDKFKGA(IBADCALEOIN AONNECHAJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x71FF1D0", Offset = "0x71FD9D0", VA = "0x1871FF1D0")]
	public void NFOLHDKFKGA(IBADCALEOIN AONNECHAJFA, byte[] IMINNNCPCJF, int BAGLBFCLNDM, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x71FFA90", Offset = "0x71FE290", VA = "0x1871FFA90", Slot = "4")]
	private IEnumerator<IBADCALEOIN> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71FFB20", Offset = "0x71FE320", VA = "0x1871FFB20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71F9CC0", Offset = "0x71F84C0", VA = "0x1871F9CC0")]
	private BNGJDGDAELF DJBHMCPIBLH(PDJMAAKAOLC JMHMMNHPIAF, int GGIJOHIPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x71F9DA0", Offset = "0x71F85A0", VA = "0x1871F9DA0")]
	private BNGJDGDAELF DJBHMCPIBLH(PDJMAAKAOLC JMHMMNHPIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71FE570", Offset = "0x71FCD70", VA = "0x1871FE570")]
	internal BNGJDGDAELF KDAHNMOHMAM(int GGIJOHIPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x71F82F0", Offset = "0x71F6AF0", VA = "0x1871F82F0")]
	internal void ABKPGGKGMAP(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x71FFBB0", Offset = "0x71FE3B0", VA = "0x1871FFBB0")]
	static DKFAECCGDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xB2B610", Offset = "0xB29E10", VA = "0x180B2B610")]
	private bool ALIOKCOAJKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71FEA70", Offset = "0x71FD270", VA = "0x1871FEA70")]
	private void LDBPHMILLMH(IPEndPoint KAOKNIJPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x71FF070", Offset = "0x71FD870", VA = "0x1871FF070")]
	private void MPKLKLABJKP(IPEndPoint KAOKNIJPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x71F9E80", Offset = "0x71F8680", VA = "0x1871F9E80")]
	private bool DJCNMBLAEIC(SocketException FKONJEEEEJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71FA730", Offset = "0x71F8F30", VA = "0x1871FA730")]
	private void FADNCBLHDAO(KNIFLBKECKF JGEKKGJKHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71FE7B0", Offset = "0x71FCFB0", VA = "0x1871FE7B0")]
	private void KFOIAJPKIKI(NHHHPNJEMBE JGEKKGJKHAO, EndPoint BPILCNGMEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x71FA030", Offset = "0x71F8830", VA = "0x1871FA030")]
	private void DKFDBBJBNLK(object OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71FD010", Offset = "0x71FB810", VA = "0x1871FD010")]
	public bool IDHAAILNKGM(IPAddress MEEGGLOFEKJ, IPAddress ICGLABGHMJB, int DBMMIMBCKMG, bool MDDCAHNCNAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71FA790", Offset = "0x71F8F90", VA = "0x1871FA790")]
	internal int FIIDBBIBJLB(BNGJDGDAELF OJCCIFECMAB, IPEndPoint FOLKAOGOLAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71FC770", Offset = "0x71FAF70", VA = "0x1871FC770")]
	internal int HPKMILOBGLD(BNGJDGDAELF OJCCIFECMAB, IPEndPoint FOLKAOGOLAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71FC7B0", Offset = "0x71FAFB0", VA = "0x1871FC7B0")]
	internal int HPKMILOBGLD(byte[] ILBALOOKKCP, int BAGLBFCLNDM, int AEPPOMGGPKB, IPEndPoint FOLKAOGOLAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71FA8B0", Offset = "0x71F90B0", VA = "0x1871FA8B0")]
	internal void GMJNGLEJGHF(bool PAFGBAKIEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum PDJMAAKAOLC : byte
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
internal sealed class BNGJDGDAELF
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int KJGMLNCICNL;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] BOLBDHMALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] AIJGJIKEMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int AMAGOKKEMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object OCIAPEPIAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public BNGJDGDAELF ALDBJLLBKEI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PDJMAAKAOLC CKNFHIOIFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x71F6B10", Offset = "0x71F5310", VA = "0x1871F6B10")]
		get
		{
			return default(PDJMAAKAOLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71F6A40", Offset = "0x71F5240", VA = "0x1871F6A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte GNCNLNACCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71F6AB0", Offset = "0x71F52B0", VA = "0x1871F6AB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x71F6CD0", Offset = "0x71F54D0", VA = "0x1871F6CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort ELNIKIBLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x71F6E80", Offset = "0x71F5680", VA = "0x1871F6E80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71F6FE0", Offset = "0x71F57E0", VA = "0x1871F6FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HLDMGJIEHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71F6A80", Offset = "0x71F5280", VA = "0x1871F6A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte HABCFLIKFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x71F6E50", Offset = "0x71F5650", VA = "0x1871F6E50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x71F6CA0", Offset = "0x71F54A0", VA = "0x1871F6CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort IFDEIBEGCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71F6D10", Offset = "0x71F5510", VA = "0x1871F6D10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71F6DD0", Offset = "0x71F55D0", VA = "0x1871F6DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort PPLPELNMNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71F6D70", Offset = "0x71F5570", VA = "0x1871F6D70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71F6E10", Offset = "0x71F5610", VA = "0x1871F6E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort LBJNDFFLHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71F6B40", Offset = "0x71F5340", VA = "0x1871F6B40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71F6A00", Offset = "0x71F5200", VA = "0x1871F6A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x71F7020", Offset = "0x71F5820", VA = "0x1871F7020")]
	static BNGJDGDAELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x71F6AE0", Offset = "0x71F52E0", VA = "0x1871F6AE0")]
	public void EKJNFJNGOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x71F72E0", Offset = "0x71F5AE0", VA = "0x1871F72E0")]
	public BNGJDGDAELF(int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x71F7350", Offset = "0x71F5B50", VA = "0x1871F7350")]
	public BNGJDGDAELF(PDJMAAKAOLC JMHMMNHPIAF, int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x71F6F70", Offset = "0x71F5770", VA = "0x1871F6F70")]
	public static int OMOOCDBNPBD(PDJMAAKAOLC JMHMMNHPIAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71F6EE0", Offset = "0x71F56E0", VA = "0x1871F6EE0")]
	public int OMOOCDBNPBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x71F6BA0", Offset = "0x71F53A0", VA = "0x1871F6BA0")]
	public bool HAGFALCKAON()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum MOLKINBPOIE : byte
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
internal enum AFOOHKMHHBJ
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
internal enum JADJAPAFALP
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum HFPFBGCFEOM
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class IBADCALEOIN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class CGDCGECHOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BNGJDGDAELF[] GOOLNAMKLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int AJEFMBKBGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int AEMPMHLPGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte HABCFLIKFIL;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CGDCGECHOEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void HLPKHDOPMGG(ulong NLFNMCOODLL, int DALKEJMJPPE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PHHLCGEDNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DCGDPDIBKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int MPPBGPBBJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double EBAMBGGJPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int HNPEDJNCGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int LJFNKADHJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int HECPMBDPCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch PCKABNNGGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int GLKOAADDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long KFHOOAFFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object KBIIFIIDLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal IBADCALEOIN DJBDALAEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal IBADCALEOIN LPDGPOCNOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<BNGJDGDAELF> IOLGJMEAMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<OELHGOBDGEC> GIECKJAKAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly OELHGOBDGEC[] KHJEADMEGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int GGJHIKJEKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int JNKOBMICODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool FIOLDKBIEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int NKIAOHOKKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int EMOCFOPKFMP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int NGFCANCIDPD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int PHMMEOCIFLE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object APOAPDCIOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HBBLALEEPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, CGDCGECHOEB> MKPEGHNPIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> NHLIIANBONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly BNGJDGDAELF GDGAMPKGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int ACMMPEJCKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int NJJLNJPIKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint DCMCEEHLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HAOEFJGLKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int NJCAIDFGOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long KEENINPGAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte MHMNCMCNFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private MOLKINBPOIE NHFNNLNJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BNGJDGDAELF ELBMOAGGEPA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int FIBONCLCDEG = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int INIDFOMJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly BNGJDGDAELF KPENFCCMCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BNGJDGDAELF FPBOEOJFFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly BNGJDGDAELF EEEJICEDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly BNGJDGDAELF DAECLIMAFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private PHGEEFFCCJB LEFDBBDHHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly DKFAECCGDKF PGILBJJNIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int FIOOAILODJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object DBKNDJMEDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly OHNPBNEMKMG FKDCBKNJIAE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte EIEJNKGDBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xB42260", Offset = "0xB40A60", VA = "0x180B42260")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7205360", Offset = "0x7203B60", VA = "0x187205360")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint HFPAAMLCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MOLKINBPOIE FGCEKEMPHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xC2BB30", Offset = "0xC2A330", VA = "0x180C2BB30")]
		get
		{
			return default(MOLKINBPOIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long JFNCJALFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7D0", Offset = "0xA29FD0", VA = "0x180A2B7D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NFPOGFIIPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x165A170", Offset = "0x1658970", VA = "0x18165A170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F41C60", Offset = "0x1F40460", VA = "0x181F41C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PPDIPEJJCED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7203C90", Offset = "0x7202490", VA = "0x187203C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int NCGEJICINJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double IGGPJKLKEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x51C9120", Offset = "0x51C7920", VA = "0x1851C9120")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event HLPKHDOPMGG MKHKDPAFMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7205DA0", Offset = "0x72045A0", VA = "0x187205DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7203BE0", Offset = "0x72023E0", VA = "0x187203BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7206540", Offset = "0x7204D40", VA = "0x187206540")]
	internal IBADCALEOIN(DKFAECCGDKF OANENIBHPBG, IPEndPoint FOLKAOGOLAI, int EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7205F70", Offset = "0x7204770", VA = "0x187205F70")]
	internal void PJNAEBNOBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7202F30", Offset = "0x7201730", VA = "0x187202F30")]
	internal void AHDCBDJJLGF(IPEndPoint GHKNLOEOHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7206140", Offset = "0x7204940", VA = "0x187206140")]
	internal void POKIKBNEBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7205E50", Offset = "0x7204650", VA = "0x187205E50")]
	private void ONHECDIOJDN(int AHLNMJIBIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7204710", Offset = "0x7202F10", VA = "0x187204710")]
	private void JLBJJPFGHID(int GOCBPLOODFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72039B0", Offset = "0x72021B0", VA = "0x1872039B0")]
	public int DOCAJNGLIAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7203AC0", Offset = "0x72022C0", VA = "0x187203AC0")]
	public int DOCAJNGLIAC(byte HLICEIHBHCF, bool KJBMKPNLELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7205F90", Offset = "0x7204790", VA = "0x187205F90")]
	private OELHGOBDGEC PKAOBOEAMCP(byte BIJFLLMPINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72061D0", Offset = "0x72049D0", VA = "0x1872061D0")]
	internal IBADCALEOIN(DKFAECCGDKF OANENIBHPBG, IPEndPoint FOLKAOGOLAI, int EBHOIBHGECB, byte PFCPKKEFELJ, IDEOABGMLEB HBBEGGIOCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7206360", Offset = "0x7204B60", VA = "0x187206360")]
	internal IBADCALEOIN(DKFAECCGDKF OANENIBHPBG, ICBNKOFNEEI FLPDPHNPDPK, int EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7205F20", Offset = "0x7204720", VA = "0x187205F20")]
	internal void PBHPIAIHBJN(LADHGLLGEMC DGOBLMPGFLI, byte[] IMINNNCPCJF, int BAGLBFCLNDM, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7202630", Offset = "0x7200E30", VA = "0x187202630")]
	internal bool AAFKENANDNB(NHPHJDDBNHL OJCCIFECMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7203EA0", Offset = "0x72026A0", VA = "0x187203EA0")]
	public void GGJCANIPOHP(byte[] IMINNNCPCJF, int BAGLBFCLNDM, int AEPPOMGGPKB, CMBBKPPDBMC OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7203FB0", Offset = "0x72027B0", VA = "0x187203FB0")]
	private void HHMONHELFNK(byte[] IMINNNCPCJF, int BAGLBFCLNDM, int AEPPOMGGPKB, byte HLICEIHBHCF, CMBBKPPDBMC JIHPHHEILOB, object IHFHALOOKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7203260", Offset = "0x7201A60", VA = "0x187203260")]
	public void BFCHMHAIHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7203ED0", Offset = "0x72026D0", VA = "0x187203ED0")]
	internal JADJAPAFALP GKLJBFIGEKB(BNGJDGDAELF OJCCIFECMAB)
	{
		return default(JADJAPAFALP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7203950", Offset = "0x7202150", VA = "0x187203950")]
	internal void CJEDFHPCJNE(OELHGOBDGEC EMCANDPJKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7203640", Offset = "0x7201E40", VA = "0x187203640")]
	internal HFPFBGCFEOM CGBDIFECOAG(byte[] IMINNNCPCJF, int BAGLBFCLNDM, int AEPPOMGGPKB, bool IBCIAMDAPFE)
	{
		return default(HFPFBGCFEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7202F60", Offset = "0x7201760", VA = "0x187202F60")]
	private void AOKMJCAMEPF(int LABDKAIBLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7205410", Offset = "0x7203C10", VA = "0x187205410")]
	internal void NGHCFDGPJNO(CMBBKPPDBMC LMGEPDDDDPA, BNGJDGDAELF LNKCJPMONLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7204E10", Offset = "0x7203610", VA = "0x187204E10")]
	private void KNBBHNEIMBK(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72032B0", Offset = "0x7201AB0", VA = "0x1872032B0")]
	private void CFPJDONKPFN(int JGHFILFLDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72026B0", Offset = "0x7200EB0", VA = "0x1872026B0")]
	internal AFOOHKMHHBJ ADLOAHEAOEN(LADHGLLGEMC KHPHOGGKFGB)
	{
		return default(AFOOHKMHHBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7202870", Offset = "0x7201070", VA = "0x187202870")]
	internal void AEBNGBIGMJE(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72045C0", Offset = "0x7202DC0", VA = "0x1872045C0")]
	private void IOJANOJHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7203CA0", Offset = "0x72024A0", VA = "0x187203CA0")]
	internal void FIMCJELKCIM(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7204750", Offset = "0x7202F50", VA = "0x187204750")]
	internal void JNHFKCNMNLI(int JGHFILFLDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7202FA0", Offset = "0x72017A0", VA = "0x187202FA0")]
	internal void BBDBCEHKHFO(BNGJDGDAELF OJCCIFECMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OHNPBNEMKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long MHHBOIJONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long NMCNIJKJKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long HBBEDNLFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long KNLHFHAKBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long HIILHFAGMON;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long HIBPMLHKHNE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long PLJADOJGEOE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long GFAOENJCOMA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long MMEADCOLHBB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long FBGJNFDODJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long IBLMLDEAJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long IMLHABOIAMC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long OCEGFBFCPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x720E030", Offset = "0x720C830", VA = "0x18720E030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long IIHOCOAANAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x720DF60", Offset = "0x720C760", VA = "0x18720DF60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long DOAJDHLHJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x720E0A0", Offset = "0x720C8A0", VA = "0x18720E0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long DHCBMFCAFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x720E170", Offset = "0x720C970", VA = "0x18720E170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long KDJOCFIDAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x720E1D0", Offset = "0x720C9D0", VA = "0x18720E1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long PLJOIHLPCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x720E1C0", Offset = "0x720C9C0", VA = "0x18720E1C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long PHFELKIBOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x720E240", Offset = "0x720CA40", VA = "0x18720E240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long OJICAOFJAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x720E330", Offset = "0x720CB30", VA = "0x18720E330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private PHGEEFFCCJB BOMCDBFPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double FAKEDPDPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x720E110", Offset = "0x720C910", VA = "0x18720E110")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x720E180", Offset = "0x720C980", VA = "0x18720E180")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x720E0B0", Offset = "0x720C8B0", VA = "0x18720E0B0")]
	public void HOFIPEGFLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x720DF70", Offset = "0x720C770", VA = "0x18720DF70")]
	public void BHPLDFBHJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x720DF00", Offset = "0x720C700", VA = "0x18720DF00")]
	public void ADENJDKGBNH(long IKFBPFKLANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x720E040", Offset = "0x720C840", VA = "0x18720E040")]
	public void DHCLNDDLGEN(long IFOGBEOJKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x720E1E0", Offset = "0x720C9E0", VA = "0x18720E1E0")]
	public void OPECMGHPIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x720DFC0", Offset = "0x720C7C0", VA = "0x18720DFC0")]
	public void BKEJMJAEOKI(long PEKIAENMLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x720E370", Offset = "0x720CB70", VA = "0x18720E370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x720E280", Offset = "0x720CA80", VA = "0x18720E280")]
	public void PCLJBJKOABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OHNPBNEMKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CNJBOIHLOPI
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> KPJJOGEHLGM;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x71F8010", Offset = "0x71F6810", VA = "0x1871F8010")]
	public static IPEndPoint OBIPEFODCPG(string BMIADOEMLIJ, int DBMMIMBCKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71F7D80", Offset = "0x71F6580", VA = "0x1871F7D80")]
	public static IPAddress CBFBFFNKGHD(string BMIADOEMLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x71F7F50", Offset = "0x71F6750", VA = "0x1871F7F50")]
	public static IPAddress CBFBFFNKGHD(string BMIADOEMLIJ, AddressFamily HIIAMCDFPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71F7FE0", Offset = "0x71F67E0", VA = "0x1871F7FE0")]
	internal static int FDJIOMGMFMH(int KFILABNLKDI, int CKNNJHFPAKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x37BC960", Offset = "0x37BB160", VA = "0x1837BC960")]
	internal static T[] CKNIDAIBCIK<T>(int FMGALNGIOGC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class MHINACEJKEF : OELHGOBDGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct MIMPIMMNJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private BNGJDGDAELF KPCBEADOCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long BFOFAKGDMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool PLBCHIBBCPH;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x720C460", Offset = "0x720AC60", VA = "0x18720C460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x720C440", Offset = "0x720AC40", VA = "0x18720C440")]
		public void HNPKBJNJFKN(BNGJDGDAELF OJCCIFECMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x720C3D0", Offset = "0x720ABD0", VA = "0x18720C3D0")]
		public bool GFFCLMAPAJI(long HADMPNPAJDI, IBADCALEOIN AONNECHAJFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x720C380", Offset = "0x720AB80", VA = "0x18720C380")]
		public bool CGGBONADGHB(IBADCALEOIN AONNECHAJFA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly BNGJDGDAELF JLNKOOHLJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly MIMPIMMNJOB[] FPOBKANCGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly BNGJDGDAELF[] ENHHGBOMGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] JJJDCNLBPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HDDECALIECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int EIMPBNEDOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int OFOMNCDKACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int KGCMJAEGFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool MPKOJFGACAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly CMBBKPPDBMC GEJAMCHOPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool PPJPNLEJIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int GNJMCKHNPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte OLFANAMMLBO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DFDLACCLIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x720BCD0", Offset = "0x720A4D0", VA = "0x18720BCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x720C1B0", Offset = "0x720A9B0", VA = "0x18720C1B0")]
	public MHINACEJKEF(IBADCALEOIN AONNECHAJFA, bool KJBMKPNLELB, byte EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x720B910", Offset = "0x720A110", VA = "0x18720B910")]
	private void ENNHPLHGNFO(BNGJDGDAELF OJCCIFECMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x720BCE0", Offset = "0x720A4E0", VA = "0x18720BCE0", Slot = "4")]
	protected override bool KFKBGJMPBCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x720B2B0", Offset = "0x7209AB0", VA = "0x18720B2B0", Slot = "5")]
	public override bool AEBNGBIGMJE(BNGJDGDAELF OJCCIFECMAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OADEDAIGEEJ : OELHGOBDGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int GGKNEHJHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort EIMPBNEDOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool BMDAOPAHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private BNGJDGDAELF EBNLOBCJMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly BNGJDGDAELF JCPNJOEFAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool BBHECGEAPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte OLFANAMMLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long IJOAANJDENG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x720DC30", Offset = "0x720C430", VA = "0x18720DC30")]
	public OADEDAIGEEJ(IBADCALEOIN AONNECHAJFA, bool GOEPDCDPIOJ, byte EBHOIBHGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x720D770", Offset = "0x720BF70", VA = "0x18720D770", Slot = "4")]
	protected override bool KFKBGJMPBCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x720D490", Offset = "0x720BC90", VA = "0x18720D490", Slot = "5")]
	public override bool AEBNGBIGMJE(BNGJDGDAELF OJCCIFECMAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FPMKPGLHHPN
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NKIFAEDEHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong DKOKKFFACII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double KIAKCHEEFGC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct JJCIGKBFFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int INOJEOMFCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float GGPEKLODEIB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x71F6270", Offset = "0x71F4A70", VA = "0x1871F6270")]
	private static void MAAAJEADIJO(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, ulong IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7201130", Offset = "0x71FF930", VA = "0x187201130")]
	private static void MAAAJEADIJO(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, int IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72011A0", Offset = "0x71FF9A0", VA = "0x1872011A0")]
	public static void MAAAJEADIJO(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, short IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72011F0", Offset = "0x71FF9F0", VA = "0x1872011F0")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, double MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7201210", Offset = "0x71FFA10", VA = "0x187201210")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72011A0", Offset = "0x71FF9A0", VA = "0x1872011A0")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, short MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72011A0", Offset = "0x71FF9A0", VA = "0x1872011A0")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, ushort MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7201130", Offset = "0x71FF930", VA = "0x187201130")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7201130", Offset = "0x71FF930", VA = "0x187201130")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, uint MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72011E0", Offset = "0x71FF9E0", VA = "0x1872011E0")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72011E0", Offset = "0x71FF9E0", VA = "0x1872011E0")]
	public static void KNLKPLHJJFB(byte[] LLNMEIMBBLB, int COEFDMIBPJJ, ulong MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JENGFOBOAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] IKHGGPKDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int IPCCOJCJJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int OBPBGJKJING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int HDNEJNPLFBP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] AIJGJIKEMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OLPPLHOFPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KOFGIMILMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7208510", Offset = "0x7206D10", VA = "0x187208510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool COKIGABFPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x275E650", Offset = "0x275CE50", VA = "0x18275E650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int EJKNAECEJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72080C0", Offset = "0x72068C0", VA = "0x1872080C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x72079D0", Offset = "0x72061D0", VA = "0x1872079D0")]
	public void ABFKDPPIPDG(byte[] BJNLPCOGDLM, int BJCMHPBMOOK, int IPMFMAODLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JENGFOBOAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x72085D0", Offset = "0x7206DD0", VA = "0x1872085D0")]
	public JENGFOBOAEM(byte[] BJNLPCOGDLM, int BJCMHPBMOOK, int IPMFMAODLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7207FB0", Offset = "0x72067B0", VA = "0x187207FB0")]
	public IPEndPoint EEFEIOLMCHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7208080", Offset = "0x7206880", VA = "0x187208080")]
	public byte KIPDEHGLBLA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7208080", Offset = "0x7206880", VA = "0x187208080")]
	public sbyte ELEBKKILDIL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A5A290", Offset = "0x3A58A90", VA = "0x183A5A290")]
	public T[] NBDKHNKNGAN<T>(ushort GGIJOHIPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7208110", Offset = "0x7206910", VA = "0x187208110")]
	public bool[] HCOMHHJEOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7208520", Offset = "0x7206D20", VA = "0x187208520")]
	public ushort[] PFGPOAFCECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x72080D0", Offset = "0x72068D0", VA = "0x1872080D0")]
	public short[] GJEHAJABOMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72082B0", Offset = "0x7206AB0", VA = "0x1872082B0")]
	public int[] KGONNAAEGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7208230", Offset = "0x7206A30", VA = "0x187208230")]
	public uint[] JKGFKAFJHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72082F0", Offset = "0x7206AF0", VA = "0x1872082F0")]
	public float[] LEOMDIPEENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72084D0", Offset = "0x7206CD0", VA = "0x1872084D0")]
	public double[] NPIKJDJCNJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7208490", Offset = "0x7206C90", VA = "0x187208490")]
	public long[] NFEMGMKFIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7207A80", Offset = "0x7206280", VA = "0x187207A80")]
	public ulong[] AMPFIFDAKPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7207B30", Offset = "0x7206330", VA = "0x187207B30")]
	public string[] CCCGIGBMMPD(int EHFKGNAOPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7208370", Offset = "0x7206B70", VA = "0x187208370")]
	public bool MGLIHAFBMBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7207AC0", Offset = "0x72062C0", VA = "0x187207AC0")]
	public char BCAJCNKGEFH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7207AC0", Offset = "0x72062C0", VA = "0x187207AC0")]
	public ushort BLMNNDOIFDA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7207F40", Offset = "0x7206740", VA = "0x187207F40")]
	public short EDCLCJKBOIK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7208420", Offset = "0x7206C20", VA = "0x187208420")]
	public long NECIIMPGFKF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7208560", Offset = "0x7206D60", VA = "0x187208560")]
	public ulong PIEEPPLACMO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7208150", Offset = "0x7206950", VA = "0x187208150")]
	public int IAEMHOLDODD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7207EB0", Offset = "0x72066B0", VA = "0x187207EB0")]
	public uint CDCCFIGCJKI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72083B0", Offset = "0x7206BB0", VA = "0x1872083B0")]
	public float NBKMMHCNNGA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7207A10", Offset = "0x7206210", VA = "0x187207A10")]
	public double ADAKHDLMJPC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7207C80", Offset = "0x7206480", VA = "0x187207C80")]
	public string CCOKPJIMHCN(int HEEBLPDLFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72081C0", Offset = "0x72069C0", VA = "0x1872081C0")]
	public ArraySegment<byte> IBOBBKCPNNN(int FMGALNGIOGC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7208270", Offset = "0x7206A70", VA = "0x187208270")]
	public sbyte[] JOAPLGEANGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7208330", Offset = "0x7206B30", VA = "0x187208330")]
	public byte[] MEJFNDJFLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7207F20", Offset = "0x7206720", VA = "0x187207F20")]
	public void CGGBONADGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IDEOABGMLEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] IKHGGPKDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int IPCCOJCJJPF;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int JNMPMKOMAHC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool OFHAHLMCOGK;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding NPMEBDCFAMC;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int OIIHLPCNLOL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] AFNJHCFJHGL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7207810", Offset = "0x7206010", VA = "0x187207810")]
	public IDEOABGMLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7207890", Offset = "0x7206090", VA = "0x187207890")]
	public IDEOABGMLEB(bool KPJAKIFMNGK, int NLHAKEAJCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7206BD0", Offset = "0x72053D0", VA = "0x187206BD0")]
	public static IDEOABGMLEB ECGKFGLHAIM(string MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7207090", Offset = "0x7205890", VA = "0x187207090")]
	public void OFMPCOOOKMP(int DPJLINPFFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x27D79C0", Offset = "0x27D61C0", VA = "0x1827D79C0")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x72076F0", Offset = "0x7205EF0", VA = "0x1872076F0")]
	public void PEMLFLBPELO(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x72076A0", Offset = "0x7205EA0", VA = "0x1872076A0")]
	public void PEMLFLBPELO(double MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7207510", Offset = "0x7205D10", VA = "0x187207510")]
	public void PEMLFLBPELO(long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7207510", Offset = "0x7205D10", VA = "0x187207510")]
	public void PEMLFLBPELO(ulong MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7207130", Offset = "0x7205930", VA = "0x187207130")]
	public void PEMLFLBPELO(int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7207130", Offset = "0x7205930", VA = "0x187207130")]
	public void PEMLFLBPELO(uint MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x72075C0", Offset = "0x7205DC0", VA = "0x1872075C0")]
	public void PEMLFLBPELO(char MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72075C0", Offset = "0x7205DC0", VA = "0x1872075C0")]
	public void PEMLFLBPELO(ushort MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72075C0", Offset = "0x7205DC0", VA = "0x1872075C0")]
	public void PEMLFLBPELO(short MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7207640", Offset = "0x7205E40", VA = "0x187207640")]
	public void PEMLFLBPELO(sbyte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7207640", Offset = "0x7205E40", VA = "0x187207640")]
	public void PEMLFLBPELO(byte MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72073D0", Offset = "0x7205BD0", VA = "0x1872073D0")]
	public void PEMLFLBPELO(byte[] IMINNNCPCJF, int BJCMHPBMOOK, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7206AF0", Offset = "0x72052F0", VA = "0x187206AF0")]
	public void EAICKHHKOAD(sbyte[] IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7206AF0", Offset = "0x72052F0", VA = "0x187206AF0")]
	public void KOHKNJMEKPF(byte[] IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7207560", Offset = "0x7205D60", VA = "0x187207560")]
	public void PEMLFLBPELO(bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7206FB0", Offset = "0x72057B0", VA = "0x187206FB0")]
	public void IKLLKFIFNMD(Array ICDCMPCFFIM, int DCNEPCIEAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7206E00", Offset = "0x7205600", VA = "0x187206E00")]
	public void IKLLKFIFNMD(float[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7206D20", Offset = "0x7205520", VA = "0x187206D20")]
	public void IKLLKFIFNMD(double[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7206D20", Offset = "0x7205520", VA = "0x187206D20")]
	public void IKLLKFIFNMD(long[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7206D20", Offset = "0x7205520", VA = "0x187206D20")]
	public void IKLLKFIFNMD(ulong[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7206E00", Offset = "0x7205600", VA = "0x187206E00")]
	public void IKLLKFIFNMD(int[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7206E00", Offset = "0x7205600", VA = "0x187206E00")]
	public void IKLLKFIFNMD(uint[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7206C40", Offset = "0x7205440", VA = "0x187206C40")]
	public void IKLLKFIFNMD(ushort[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7206C40", Offset = "0x7205440", VA = "0x187206C40")]
	public void IKLLKFIFNMD(short[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7206AF0", Offset = "0x72052F0", VA = "0x187206AF0")]
	public void IKLLKFIFNMD(bool[] MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7206EE0", Offset = "0x72056E0", VA = "0x187206EE0")]
	public void IKLLKFIFNMD(string[] MGONBEDEDON, int ABGDMKIIMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7207440", Offset = "0x7205C40", VA = "0x187207440")]
	public void PEMLFLBPELO(IPEndPoint FHKNBKEGLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7207630", Offset = "0x7205E30", VA = "0x187207630")]
	public void PEMLFLBPELO(string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72071C0", Offset = "0x72059C0", VA = "0x1872071C0")]
	public void PEMLFLBPELO(string MGONBEDEDON, int HEEBLPDLFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MFEIBPLKBNA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class BDBHGGJEHKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong FIOOAILODJA;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6163780", Offset = "0x6161F80", VA = "0x186163780")]
		static BDBHGGJEHKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void LJLFEKKMBEP(JENGFOBOAEM JEPFPDOKDAD, object IHFHALOOKJH);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LIKPNKFIDEN<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public MFEIBPLKBNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LIKPNKFIDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5302F50", Offset = "0x5301750", VA = "0x185302F50")]
		internal void GIIBDAJDFDE(JENGFOBOAEM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ILAHADMPFFL<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public MFEIBPLKBNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ILAHADMPFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4E89D30", Offset = "0x4E88530", VA = "0x184E89D30")]
		internal void GIIBDAJDFDE(JENGFOBOAEM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly AGGIAKECAGA NLMGFFNJKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, LJLFEKKMBEP> ACGGPGOFOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly IDEOABGMLEB DHLJHOKHIFL;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x720B130", Offset = "0x7209930", VA = "0x18720B130")]
	public MFEIBPLKBNA(int EHFKGNAOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x37945B0", Offset = "0x3792DB0", VA = "0x1837945B0", Slot = "4")]
	protected virtual ulong DJNHGKFEPKL<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x720B000", Offset = "0x7209800", VA = "0x18720B000", Slot = "5")]
	protected virtual LJLFEKKMBEP KIDJEBPBODE(JENGFOBOAEM JEPFPDOKDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB7F0", Offset = "0x3AC9FF0", VA = "0x183ACB7F0", Slot = "6")]
	protected virtual void FIJEGOPEMGH<T>(IDEOABGMLEB LFDMHEHCHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x720AF30", Offset = "0x7209730", VA = "0x18720AF30")]
	public void AKBDONOLFJJ(JENGFOBOAEM JEPFPDOKDAD, object IHFHALOOKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB860", Offset = "0x3ACA060", VA = "0x183ACB860")]
	public void NGNIADILBPN<T>(IDEOABGMLEB LFDMHEHCHCC, T OJCCIFECMAB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x720AFB0", Offset = "0x72097B0", VA = "0x18720AFB0")]
	public void IEHFLLHIFKC(JENGFOBOAEM JEPFPDOKDAD, object IHFHALOOKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB630", Offset = "0x3AC9E30", VA = "0x183ACB630")]
	public void CIBCJHHLLKE<T>(Action<T> GIGKOPCKGNN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3ACB470", Offset = "0x3AC9C70", VA = "0x183ACB470")]
	public void CIBCJHHLLKE<T, TUserData>(Action<T, TUserData> GIGKOPCKGNN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MMLBKPICLAN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x71F69F0", Offset = "0x71F51F0", VA = "0x1871F69F0")]
	public MMLBKPICLAN(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CCIEBKFLAME : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x71F7460", Offset = "0x71F5C60", VA = "0x1871F7460")]
	public CCIEBKFLAME(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AGGIAKECAGA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum EDPANAGJCCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FFMBEAPGHLO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public EDPANAGJCCF PBNBGAHIAOD;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9D90", Offset = "0x4BA8590", VA = "0x184BA9D90", Slot = "4")]
		public virtual void HNPKBJNJFKN(MethodInfo NNLLNDFICEH, MethodInfo KKAHJHIOJBP, EDPANAGJCCF CEPGAJKBPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void CHJAAFEHHPO(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void OKKOEFEEMHN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		protected FFMBEAPGHLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class NLKHABODOJA<TClass, TProperty> : FFMBEAPGHLO<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> POACHPNEDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> FLBMFHHDIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> CFIAMFDFLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> GMGEIIBGPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> LLOKPHGLKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> HPJCBNMHJNG;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x55DE1E0", Offset = "0x55DC9E0", VA = "0x1855DE1E0", Slot = "7")]
		public override void OOBPPGMBJMH(TClass EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x55D6BA0", Offset = "0x55D53A0", VA = "0x1855D6BA0", Slot = "8")]
		public override void AEOJMFCDNDC(TClass EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x55D8180", Offset = "0x55D6980", VA = "0x1855D8180", Slot = "9")]
		public override void CHJAAFEHHPO(TClass EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55DD5A0", Offset = "0x55DBDA0", VA = "0x1855DD5A0", Slot = "10")]
		public override void OKKOEFEEMHN(TClass EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x55DCDF0", Offset = "0x55DB5F0", VA = "0x1855DCDF0")]
		protected TProperty[] INFLPDPJDKH(TClass EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x55DCF00", Offset = "0x55DB700", VA = "0x1855DCF00")]
		protected TProperty[] MPPEOMLMKKE(TClass EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x55D8E00", Offset = "0x55D7600", VA = "0x1855D8E00", Slot = "4")]
		public override void HNPKBJNJFKN(MethodInfo NNLLNDFICEH, MethodInfo KKAHJHIOJBP, EDPANAGJCCF CEPGAJKBPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55DE640", Offset = "0x55DCE40", VA = "0x1855DE640")]
		protected NLKHABODOJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class FIOFGCDLLJI<TClass, TProperty> : NLKHABODOJA<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void JGEDHDJBGIH(JENGFOBOAEM NLCEHLDPLPE, [Out] TProperty GAGBGDAOHBH);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IKEMAGCIICN(IDEOABGMLEB JFOFHMLAJFN, TProperty GAGBGDAOHBH);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE4F0", Offset = "0x4BACCF0", VA = "0x184BAE4F0", Slot = "5")]
		public override void CDCGONEOHDP(TClass EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE590", Offset = "0x4BACD90", VA = "0x184BAE590", Slot = "6")]
		public override void NGNIADILBPN(TClass EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE770", Offset = "0x4BACF70", VA = "0x184BAE770", Slot = "7")]
		public override void OOBPPGMBJMH(TClass EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE2D0", Offset = "0x4BACAD0", VA = "0x184BAE2D0", Slot = "8")]
		public override void AEOJMFCDNDC(TClass EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE830", Offset = "0x4BAD030", VA = "0x184BAE830")]
		protected FIOFGCDLLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class ADNBGFOMAAL<T> : NLKHABODOJA<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E270", Offset = "0x4D0CA70", VA = "0x184D0E270", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E2F0", Offset = "0x4D0CAF0", VA = "0x184D0E2F0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E360", Offset = "0x4D0CB60", VA = "0x184D0E360", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E200", Offset = "0x4D0CA00", VA = "0x184D0E200", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public ADNBGFOMAAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class COBDAOMMOEF<T> : NLKHABODOJA<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68859A0", Offset = "0x68841A0", VA = "0x1868859A0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E2F0", Offset = "0x4D0CAF0", VA = "0x184D0E2F0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6885A20", Offset = "0x6884220", VA = "0x186885A20", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E200", Offset = "0x4D0CA00", VA = "0x184D0E200", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public COBDAOMMOEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class BMDBEMCLMCO<T> : NLKHABODOJA<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x617CF20", Offset = "0x617B720", VA = "0x18617CF20", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x50DC0E0", Offset = "0x50DA8E0", VA = "0x1850DC0E0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x617CFA0", Offset = "0x617B7A0", VA = "0x18617CFA0", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x50DBFF0", Offset = "0x50DA7F0", VA = "0x1850DBFF0", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public BMDBEMCLMCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JMPIFONNNCD<T> : NLKHABODOJA<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DA860", VA = "0x1850DC060", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x50DC0E0", Offset = "0x50DA8E0", VA = "0x1850DC0E0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x50DC150", Offset = "0x50DA950", VA = "0x1850DC150", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x50DBFF0", Offset = "0x50DA7F0", VA = "0x1850DBFF0", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public JMPIFONNNCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class BOMANAIGDAG<T> : NLKHABODOJA<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6282340", Offset = "0x6280B40", VA = "0x186282340", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5539340", Offset = "0x5537B40", VA = "0x185539340", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62823C0", Offset = "0x6280BC0", VA = "0x1862823C0", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5539250", Offset = "0x5537A50", VA = "0x185539250", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public BOMANAIGDAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MFMKEIMMLPG<T> : NLKHABODOJA<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x55392C0", Offset = "0x5537AC0", VA = "0x1855392C0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5539340", Offset = "0x5537B40", VA = "0x185539340", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x55393B0", Offset = "0x5537BB0", VA = "0x1855393B0", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5539250", Offset = "0x5537A50", VA = "0x185539250", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public MFMKEIMMLPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class IOEBJEBMDLO<T> : NLKHABODOJA<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E91FC0", Offset = "0x4E907C0", VA = "0x184E91FC0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E92040", Offset = "0x4E90840", VA = "0x184E92040", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4E920B0", Offset = "0x4E908B0", VA = "0x184E920B0", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E91F50", Offset = "0x4E90750", VA = "0x184E91F50", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public IOEBJEBMDLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JDALIAFHIFA<T> : NLKHABODOJA<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E91FC0", Offset = "0x4E907C0", VA = "0x184E91FC0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E92040", Offset = "0x4E90840", VA = "0x184E92040", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x50A8800", Offset = "0x50A7000", VA = "0x1850A8800", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E91F50", Offset = "0x4E90750", VA = "0x184E91F50", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public JDALIAFHIFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OCAHIKLEKFG<T> : NLKHABODOJA<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5725D70", Offset = "0x5724570", VA = "0x185725D70", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5725DF0", Offset = "0x57245F0", VA = "0x185725DF0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5725E60", Offset = "0x5724660", VA = "0x185725E60", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E200", Offset = "0x4D0CA00", VA = "0x184D0E200", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public OCAHIKLEKFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MMIALFIMEPC<T> : NLKHABODOJA<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x554E2E0", Offset = "0x554CAE0", VA = "0x18554E2E0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x554E360", Offset = "0x554CB60", VA = "0x18554E360", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x554E3D0", Offset = "0x554CBD0", VA = "0x18554E3D0", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5539250", Offset = "0x5537A50", VA = "0x185539250", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public MMIALFIMEPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class LNOBHEAJDDB<T> : NLKHABODOJA<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5338480", Offset = "0x5336C80", VA = "0x185338480", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5338500", Offset = "0x5336D00", VA = "0x185338500", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5338570", Offset = "0x5336D70", VA = "0x185338570", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E91F50", Offset = "0x4E90750", VA = "0x184E91F50", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
		public LNOBHEAJDDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BCGHELPDLOD<T> : FIOFGCDLLJI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x61627C0", Offset = "0x6160FC0", VA = "0x1861627C0", Slot = "12")]
		protected override void IKEMAGCIICN(IDEOABGMLEB JFOFHMLAJFN, char GAGBGDAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x61627F0", Offset = "0x6160FF0", VA = "0x1861627F0", Slot = "11")]
		protected override void JGEDHDJBGIH(JENGFOBOAEM NLCEHLDPLPE, [Out] char GAGBGDAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
		public BCGHELPDLOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CBKGFDDKACH<T> : FIOFGCDLLJI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x65B4490", Offset = "0x65B2C90", VA = "0x1865B4490", Slot = "12")]
		protected override void IKEMAGCIICN(IDEOABGMLEB JFOFHMLAJFN, IPEndPoint GAGBGDAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x65B44C0", Offset = "0x65B2CC0", VA = "0x1865B44C0", Slot = "11")]
		protected override void JGEDHDJBGIH(JENGFOBOAEM NLCEHLDPLPE, [Out] IPEndPoint GAGBGDAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
		public CBKGFDDKACH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class AJCPEDIDMAA<T> : NLKHABODOJA<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int CECAOODPAGG;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4D249D0", Offset = "0x4D231D0", VA = "0x184D249D0")]
		public AJCPEDIDMAA(int HEEBLPDLFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4D24850", Offset = "0x4D23050", VA = "0x184D24850", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4D248D0", Offset = "0x4D230D0", VA = "0x184D248D0", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4D24950", Offset = "0x4D23150", VA = "0x184D24950", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4D247D0", Offset = "0x4D22FD0", VA = "0x184D247D0", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BCIHMOGDGGI<T> : FFMBEAPGHLO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo CKNFHIOIFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type MGKPOCIMMOM;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6162E70", Offset = "0x6161670", VA = "0x186162E70")]
		public BCIHMOGDGGI(PropertyInfo JMHMMNHPIAF, Type GMKHFLICHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6162BE0", Offset = "0x61613E0", VA = "0x186162BE0", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6162D00", Offset = "0x6161500", VA = "0x186162D00", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6162E10", Offset = "0x6161610", VA = "0x186162E10", Slot = "7")]
		public override void OOBPPGMBJMH(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6162B80", Offset = "0x6161380", VA = "0x186162B80", Slot = "8")]
		public override void AEOJMFCDNDC(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6162CA0", Offset = "0x61614A0", VA = "0x186162CA0", Slot = "9")]
		public override void CHJAAFEHHPO(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6162DB0", Offset = "0x61615B0", VA = "0x186162DB0", Slot = "10")]
		public override void OKKOEFEEMHN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class INPIDNLLJPC<T> : BCIHMOGDGGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
		public INPIDNLLJPC(PropertyInfo JMHMMNHPIAF, Type GMKHFLICHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4E91070", Offset = "0x4E8F870", VA = "0x184E91070", Slot = "5")]
		public override void CDCGONEOHDP(T EKLFFJJCIJM, JENGFOBOAEM NLCEHLDPLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E91130", Offset = "0x4E8F930", VA = "0x184E91130", Slot = "6")]
		public override void NGNIADILBPN(T EKLFFJJCIJM, IDEOABGMLEB JFOFHMLAJFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class OFDECKOHEFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static OFDECKOHEFO<T> HPECEAELCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly FFMBEAPGHLO<T>[] HBHAKGAJDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int FIDGBHEFLEL;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x572A200", Offset = "0x5728A00", VA = "0x18572A200")]
		public OFDECKOHEFO(List<FFMBEAPGHLO<T>> KDLHEALCLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x572A150", Offset = "0x5728950", VA = "0x18572A150")]
		public void NGNIADILBPN(T HPLLAPMNIJF, IDEOABGMLEB LFDMHEHCHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x572A0A0", Offset = "0x57288A0", VA = "0x18572A0A0")]
		public void CDCGONEOHDP(T HPLLAPMNIJF, JENGFOBOAEM JEPFPDOKDAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class FDHIMJBGJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FFMBEAPGHLO<T> CEJDCFFPPDB<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private IDEOABGMLEB AAGCKEJFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int NHKIGNAGOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, FDHIMJBGJMN> PDMKCMLBPPI;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x71F6950", Offset = "0x71F5150", VA = "0x1871F6950")]
	public AGGIAKECAGA(int EHFKGNAOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x41E92C0", Offset = "0x41E7AC0", VA = "0x1841E92C0")]
	private OFDECKOHEFO<T> KOLDGFNCJFH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C80", Offset = "0x37F5480", VA = "0x1837F6C80")]
	public void KELFLPPCOLM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x41EA3E0", Offset = "0x41E8BE0", VA = "0x1841EA3E0")]
	public bool OLFGCACBCKJ<T>(JENGFOBOAEM JEPFPDOKDAD, T OLBBKGLINIK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x41E9230", Offset = "0x41E7A30", VA = "0x1841E9230")]
	public void GJCNJFECIPF<T>(IDEOABGMLEB LFDMHEHCHCC, T HPLLAPMNIJF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GKDILCOOINK
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime HLLKLIDLINA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] AOILIDFNCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FBEHPFIJAHO FELINFEJBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7202060", Offset = "0x7200860", VA = "0x187202060")]
		get
		{
			return default(FBEHPFIJAHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BFHKGKFPNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7201490", Offset = "0x71FFC90", VA = "0x187201490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7202090", Offset = "0x7200890", VA = "0x187202090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public EOLPAHPMCAJ NGLHCFCPFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7201920", Offset = "0x7200120", VA = "0x187201920")]
		get
		{
			return default(EOLPAHPMCAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7201950", Offset = "0x7200150", VA = "0x187201950")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int GOAAKAFIAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7201990", Offset = "0x7200190", VA = "0x187201990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint DBJJMNHAIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7201AE0", Offset = "0x72002E0", VA = "0x187201AE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? NJJALCKEEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x72018C0", Offset = "0x72000C0", VA = "0x1872018C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? JDAGMLDOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x72018F0", Offset = "0x72000F0", VA = "0x1872018F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? NODJLNJCHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7201890", Offset = "0x7200090", VA = "0x187201890")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7201C20", Offset = "0x7200420", VA = "0x187201C20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? INCCCOKDKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7202260", Offset = "0x7200A60", VA = "0x187202260")]
	public GKDILCOOINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7202580", Offset = "0x7200D80", VA = "0x187202580")]
	internal GKDILCOOINK(byte[] LLNMEIMBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72019C0", Offset = "0x72001C0", VA = "0x1872019C0")]
	public static GKDILCOOINK IAHIKBECFNG(byte[] LLNMEIMBBLB, DateTime OCEJNIPDFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7201290", Offset = "0x71FFA90", VA = "0x187201290")]
	internal void AIMDPFNLDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7201DF0", Offset = "0x72005F0", VA = "0x187201DF0")]
	private void KHIHDOLEHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7201690", Offset = "0x71FFE90", VA = "0x187201690")]
	private DateTime? DGGJMKDFOPK(int BJCMHPBMOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x72014C0", Offset = "0x71FFCC0", VA = "0x1872014C0")]
	private void CCHPNIMGCNH(int BJCMHPBMOOK, DateTime? MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7202130", Offset = "0x7200930", VA = "0x187202130")]
	private ulong OPDPJKIDKOL(int BJCMHPBMOOK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7201B60", Offset = "0x7200360", VA = "0x187201B60")]
	private void KENEFNDLCFI(int BJCMHPBMOOK, ulong MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7201FD0", Offset = "0x72007D0", VA = "0x187201FD0")]
	private uint KLEDALFLKKH(int BJCMHPBMOOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x70C2E80", Offset = "0x70C1680", VA = "0x1870C2E80")]
	private static uint NHEBOFHEHNO(uint BDGPJOKJNIL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x72020D0", Offset = "0x72008D0", VA = "0x1872020D0")]
	private static ulong NHEBOFHEHNO(ulong BDGPJOKJNIL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum FBEHPFIJAHO
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
public enum EOLPAHPMCAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class AAKDMFJKLEE
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int NFOHABMCKPD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int KBDPJMPJIAF = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int KHGOKHLCMFD = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint GPKAMJNLGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int ONHFFLINKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int MMAFIAIEKLO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JMFIGJKNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x71F6940", Offset = "0x71F5140", VA = "0x1871F6940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x71F6850", Offset = "0x71F5050", VA = "0x1871F6850")]
	public bool GGJCANIPOHP(NHHHPNJEMBE JGEKKGJKHAO, int BPMPOGGBGJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class CCJFHHLCOEF : NHHHPNJEMBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket JGEKKGJKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly DKFAECCGDKF OANENIBHPBG;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short OOIOAAOBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x71F7AC0", Offset = "0x71F62C0", VA = "0x1871F7AC0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DMPCGLABEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x71F74E0", Offset = "0x71F5CE0", VA = "0x1871F74E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint EJGAANGNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x71F74C0", Offset = "0x71F5CC0", VA = "0x1871F74C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily CLIGLBMJIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5242E60", Offset = "0x5241660", VA = "0x185242E60", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x71F7C30", Offset = "0x71F6430", VA = "0x1871F7C30")]
	public CCJFHHLCOEF(AddressFamily HIIAMCDFPMM, DKFAECCGDKF OANENIBHPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x71F7500", Offset = "0x71F5D00", VA = "0x1871F7500", Slot = "8")]
	public bool BEIICNIBHBO(IPEndPoint FHKNBKEGLKC, OJHJFNCDLFP FALMMFCAAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x71F7BF0", Offset = "0x71F63F0", VA = "0x1871F7BF0", Slot = "9")]
	public int OCNNFCJKAPB(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, int GGIJOHIPOOO, IPEndPoint FOLKAOGOLAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x71F7B00", Offset = "0x71F6300", VA = "0x1871F7B00", Slot = "10")]
	public int MILMKGLLDDH(byte[] FLHFCEEIHBP, EndPoint FBNCEAFDEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x71F7AE0", Offset = "0x71F62E0", VA = "0x1871F7AE0", Slot = "11")]
	public void LCKJLOMJHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface NHHHPNJEMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short OOIOAAOBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int DMPCGLABEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint EJGAANGNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily CLIGLBMJIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BEIICNIBHBO(IPEndPoint FHKNBKEGLKC, OJHJFNCDLFP FALMMFCAAFN);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int OCNNFCJKAPB(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, int GGIJOHIPOOO, IPEndPoint FOLKAOGOLAI);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MILMKGLLDDH(byte[] FLHFCEEIHBP, EndPoint FOLKAOGOLAI);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCKJLOMJHIB();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct FGPLJMAMDME : IEquatable<FGPLJMAMDME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long FCDFKIEBNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long AABJDKNLFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long JELPKKNJACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int HIEGMBJCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int KEHPNGAINAP;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7200E00", Offset = "0x71FF600", VA = "0x187200E00")]
	public FGPLJMAMDME(byte[] PKOADNLIJDK, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7200EC0", Offset = "0x71FF6C0", VA = "0x187200EC0")]
	public FGPLJMAMDME(Span<byte> PKOADNLIJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7200D10", Offset = "0x71FF510", VA = "0x187200D10", Slot = "4")]
	public bool Equals(FGPLJMAMDME KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7200D50", Offset = "0x71FF550", VA = "0x187200D50", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class NDAPFMDFJCL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] HOPHGJGFACF;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KNIFLBKECKF
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void EOHMEEIGHON(IPEndPoint PKOADNLIJDK, Span<byte> IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string GCMINCOBOLL = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int BDDHBLLBCPE = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int DHFMKGDDDBJ = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static Dictionary<FGPLJMAMDME, IPEndPoint> GKLOJLPEBLJ;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static EOHMEEIGHON HHAGONCMLNO;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	internal void POBOPNALGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	internal void IODGHGGNMKG(IPEndPoint FOLKAOGOLAI, Span<byte> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class JGMBMFCAODI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly int FCMIGDKHDPK;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
	protected JGMBMFCAODI(int DOFLPNFCIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void MLDGOOJDLHK(IPEndPoint FHKNBKEGLKC, byte[] IMINNNCPCJF, int BJCMHPBMOOK, int AEPPOMGGPKB);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DCMCBOKEOFH(IPEndPoint FHKNBKEGLKC, byte[] IMINNNCPCJF, int BJCMHPBMOOK, int AEPPOMGGPKB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KIGGBDAEKGP : JGMBMFCAODI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private byte[] MNMCNOJCKAF;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly RandomNumberGenerator HBPAIGGHLJD;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x28B1450", Offset = "0x28AFC50", VA = "0x1828B1450")]
	public KIGGBDAEKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7208B40", Offset = "0x7207340", VA = "0x187208B40")]
	public void HBIPDPMIIAI(IPEndPoint FHKNBKEGLKC, byte[] MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7208700", Offset = "0x7206F00", VA = "0x187208700")]
	public void ACIGIOADKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7208CF0", Offset = "0x72074F0", VA = "0x187208CF0", Slot = "4")]
	public override void MLDGOOJDLHK(IPEndPoint FHKNBKEGLKC, byte[] IMINNNCPCJF, int BJCMHPBMOOK, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x72087E0", Offset = "0x7206FE0", VA = "0x1872087E0", Slot = "5")]
	public override void DCMCBOKEOFH(IPEndPoint FHKNBKEGLKC, byte[] IMINNNCPCJF, int BJCMHPBMOOK, int AEPPOMGGPKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct NCFOHODLDGI
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void NEADHJHPJKK([NoAlias] byte* HKLHBHBOONN, [NoAlias] byte* MNMCNOJCKAF, [NoAlias] byte* CHKEGCFAMGH, int AEPPOMGGPKB);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class AJDBECFONMC
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static IntPtr JOMDIPMJNHC;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static IntPtr KFAFPPPPOAD;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x720E9A0", Offset = "0x720D1A0", VA = "0x18720E9A0")]
		[BurstDiscard]
		private static void DHBLBMDKKDE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x720ED90", Offset = "0x720D590", VA = "0x18720ED90")]
		private static IntPtr PPIJBKPFCOE()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x720ECF0", Offset = "0x720D4F0", VA = "0x18720ECF0")]
		public static void HOOKDKFGPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		public static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x720EAC0", Offset = "0x720D2C0", VA = "0x18720EAC0")]
		public unsafe static void DMJBMMIBENB([NoAlias] byte* HKLHBHBOONN, [NoAlias] byte* MNMCNOJCKAF, [NoAlias] byte* CHKEGCFAMGH, int AEPPOMGGPKB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint MNMCNOJCKAF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint CHKEGCFAMGH[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint AOMELCAKMNF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint HDHDEPBFBGI[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint MMLCBPABFPD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint BBGEPHCNACE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint FPOHPOJHOJH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private uint HMLOBPALJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint NJNCNBNNFHN[8];

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x720CB80", Offset = "0x720B380", VA = "0x18720CB80")]
	private void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x720CB50", Offset = "0x720B350", VA = "0x18720CB50")]
	private uint KFIMAAAPLGB(uint KENANDNBOGI, int KCJGAKLGBDK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x71F67A0", Offset = "0x71F4FA0", VA = "0x1871F67A0")]
	private void GNOMHLPEBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x71F6400", Offset = "0x71F4C00", VA = "0x1871F6400")]
	private void BLDNOEPCPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x71F6610", Offset = "0x71F4E10", VA = "0x1871F6610")]
	private void CPDJPCHNNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x71F66A0", Offset = "0x71F4EA0", VA = "0x1871F66A0")]
	private void DCBNDDGKLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x720C920", Offset = "0x720B120", VA = "0x18720C920")]
	private void DKKIJNIDEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x720C500", Offset = "0x720AD00", VA = "0x18720C500")]
	private unsafe void AEHMJMGIIFM(byte* HKLHBHBOONN, uint* MNMCNOJCKAF, uint* CHKEGCFAMGH, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x720C9F0", Offset = "0x720B1F0", VA = "0x18720C9F0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void HBOHFNFGKAH([NoAlias] byte* HKLHBHBOONN, [NoAlias] byte* MNMCNOJCKAF, [NoAlias] byte* CHKEGCFAMGH, int AEPPOMGGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x720CA70", Offset = "0x720B270", VA = "0x18720CA70")]
	public static void HBOHFNFGKAH(Span<byte> HKLHBHBOONN, Span<byte> MNMCNOJCKAF, Span<byte> CHKEGCFAMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x720CC00", Offset = "0x720B400", VA = "0x18720CC00")]
	public static void PIOCMLDLAFF(Span<byte> HKLHBHBOONN, Span<byte> MNMCNOJCKAF, Span<byte> CHKEGCFAMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x720C980", Offset = "0x720B180", VA = "0x18720C980")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FBNKHNJHJEK([NoAlias] byte* HKLHBHBOONN, [NoAlias] byte* MNMCNOJCKAF, [NoAlias] byte* CHKEGCFAMGH, int AEPPOMGGPKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x720EFE0", Offset = "0x720D7E0", VA = "0x18720EFE0")]
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
