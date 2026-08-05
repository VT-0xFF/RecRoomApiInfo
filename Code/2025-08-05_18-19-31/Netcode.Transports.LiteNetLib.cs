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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, GEKJOCOCACN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum AHAILEBIKNL
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
		private NetworkManager JPBBFLOHEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HBDHHDKCLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, JPDHKDFBPEM> MKNKOPECHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DIIGLGJHGPM JEKLFCMHGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch NDNBPENJKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] MEDNEJMPKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private AHAILEBIKNL AAAAMGOFOOO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int MACHKCJDCPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x747EC50", Offset = "0x747E050", VA = "0x18747EC50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong EIMIABPCHEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool OBMMLFJFDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x747EC30", Offset = "0x747E030", VA = "0x18747EC30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x747E220", Offset = "0x747D620", VA = "0x18747E220")]
		public void RecRoom_SetEncryptionInfo(ulong MCICFNBGNIC, byte[] PEENICAIFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x747E200", Offset = "0x747D600", VA = "0x18747E200")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x747DDF0", Offset = "0x747D1F0", VA = "0x18747DDF0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x747EB30", Offset = "0x747DF30", VA = "0x18747EB30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x747E340", Offset = "0x747D740", VA = "0x18747E340", Slot = "6")]
		public override void Send(ulong ICAMGPAGGAL, ArraySegment<byte> NGIAGNLBILI, NetworkDelivery EPGOGDPFPAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x747E1C0", Offset = "0x747D5C0", VA = "0x18747E1C0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong ICAMGPAGGAL, [Out] ArraySegment<byte> JPPAFNCCIMK, [Out] float KKIKBNFDJKK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x747E630", Offset = "0x747DA30", VA = "0x18747E630", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x747E950", Offset = "0x747DD50", VA = "0x18747E950", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x747D8D0", Offset = "0x747CCD0", VA = "0x18747D8D0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong ICAMGPAGGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x747D7E0", Offset = "0x747CBE0", VA = "0x18747D7E0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x747D9E0", Offset = "0x747CDE0", VA = "0x18747D9E0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong ICAMGPAGGAL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x747E5C0", Offset = "0x747D9C0", VA = "0x18747E5C0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x747DB00", Offset = "0x747CF00", VA = "0x18747DB00", Slot = "15")]
		public override void Initialize([Optional] NetworkManager JPBBFLOHEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x747DEE0", Offset = "0x747D2E0", VA = "0x18747DEE0")]
		private JMKGIGLLEFA PJDAEIDAKOO(NetworkDelivery IIHAKBEOLJD)
		{
			return default(JMKGIGLLEFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x747D600", Offset = "0x747CA00", VA = "0x18747D600", Slot = "16")]
		private void CGKJGJPGBPB(JPDHKDFBPEM BMFGBCBGJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x747D710", Offset = "0x747CB10", VA = "0x18747D710", Slot = "17")]
		private void DDHPPNEKABK(JPDHKDFBPEM BMFGBCBGJLK, GDNKAJDPONM OLICNONOBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "18")]
		private void AAKJOMMLENA(IPEndPoint AICHGLEJCCE, SocketError KNGPGOEIMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x747DFB0", Offset = "0x747D3B0", VA = "0x18747DFB0", Slot = "19")]
		private void PLDKPHCBHPK(JPDHKDFBPEM BMFGBCBGJLK, JOFIFFMHNAK BPCOJLPPMNI, byte EEMMEGGJNHG, JMKGIGLLEFA MOJDMNEKBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x747DD10", Offset = "0x747D110", VA = "0x18747DD10")]
		private void LKFPJKHAOBM(int MPDDFCCPIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "20")]
		private void HJNOLNDEENI(IPEndPoint BLBPEFEEMBP, JOFIFFMHNAK BPCOJLPPMNI, OEEDNGMIHEN GKFMCKLNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "21")]
		private void KAGIOHEKOPM(JPDHKDFBPEM BMFGBCBGJLK, int NNNIOLLBCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x747DA80", Offset = "0x747CE80", VA = "0x18747DA80", Slot = "22")]
		private void HGFGBJFBDHE(KAHAPKIADEA IDLJGJGIGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x747D6C0", Offset = "0x747CAC0", VA = "0x18747D6C0")]
		private ulong CLLFINPPFHC(JPDHKDFBPEM BMFGBCBGJLK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x747D6F0", Offset = "0x747CAF0", VA = "0x18747D6F0")]
		private ulong CLLFINPPFHC(ulong ICAMGPAGGAL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x747DAE0", Offset = "0x747CEE0", VA = "0x18747DAE0")]
		private static int HPJBPJIOLIG(float OLCPEFOMCCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x747EB50", Offset = "0x747DF50", VA = "0x18747EB50")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x747D5D0", Offset = "0x747C9D0", VA = "0x18747D5D0")]
		[CompilerGenerated]
		private void AKPBAKMNLCJ(ulong ADFKJFBKIOD, int PPALLFJCGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x747D5D0", Offset = "0x747C9D0", VA = "0x18747D5D0")]
		[CompilerGenerated]
		private void IMBAHEGAMDN(ulong ADFKJFBKIOD, int PPALLFJCGHB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class MFKKNMCOJDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly JPDHKDFBPEM PKECPIKOHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<AHBJDEHMAFN> JLKAKJHDMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int HCOAIFONDLG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ENOIFBKINGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x747F5D0", Offset = "0x747E9D0", VA = "0x18747F5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x747F740", Offset = "0x747EB40", VA = "0x18747F740")]
	protected MFKKNMCOJDJ(JPDHKDFBPEM BMFGBCBGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x747F6E0", Offset = "0x747EAE0", VA = "0x18747F6E0")]
	public void OKEPKFNGFGM(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x747F660", Offset = "0x747EA60", VA = "0x18747F660")]
	protected void LLBCAKLOPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x747F620", Offset = "0x747EA20", VA = "0x18747F620")]
	public bool DLHELDPHJAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CLBCNAGJFIM();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MFKLNNLLNLM(AHBJDEHMAFN EOFGGNOHAMG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum PFILPIBEKFD
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
public class KAHAPKIADEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DIIGLGJHGPM JFOCKDMNALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int GFHCJJOAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal AMOHCNEACNM DBCKOLBNGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint OIIEHMMKFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal PFILPIBEKFD OMMOIDMJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
		[CompilerGenerated]
		get
		{
			return default(PFILPIBEKFD);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE9A000", Offset = "0xE99400", VA = "0x180E9A000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x747C160", Offset = "0x747B560", VA = "0x18747C160")]
	internal void GHMNNCAOFIJ(AMOHCNEACNM KOJBEOKKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x747C130", Offset = "0x747B530", VA = "0x18747C130")]
	private bool EINOOCFHGJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x747C220", Offset = "0x747B620", VA = "0x18747C220")]
	internal KAHAPKIADEA(IPEndPoint BLBPEFEEMBP, AMOHCNEACNM HJPIHCPOCKM, DIIGLGJHGPM GKNBMKFDKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x747C1C0", Offset = "0x747B5C0", VA = "0x18747C1C0")]
	public JPDHKDFBPEM JIJFLOIHMPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OEEDNGMIHEN
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum CAOKNNBMCOG
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
public struct GDNKAJDPONM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public CAOKNNBMCOG MEOJHBDOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError MLFCFNBCEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JOFIFFMHNAK CKCHEBCJJOL;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GEKJOCOCACN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JALABJKMADK(JPDHKDFBPEM BMFGBCBGJLK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOMJPKJLAHN(JPDHKDFBPEM BMFGBCBGJLK, GDNKAJDPONM OLICNONOBAH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHIADLPKEOA(IPEndPoint AICHGLEJCCE, SocketError KNGPGOEIMPM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAFPMLALMCL(JPDHKDFBPEM BMFGBCBGJLK, JOFIFFMHNAK BPCOJLPPMNI, byte EEMMEGGJNHG, JMKGIGLLEFA MOJDMNEKBMB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEAMJFKGFHK(IPEndPoint BLBPEFEEMBP, JOFIFFMHNAK BPCOJLPPMNI, OEEDNGMIHEN GKFMCKLNDPA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKCGJLLCHBH(JPDHKDFBPEM BMFGBCBGJLK, int NNNIOLLBCAH);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOKDPGJLOBL(KAHAPKIADEA IDLJGJGIGEG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JGCAKDDPDMM
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNMAGEHKKJG(JPDHKDFBPEM BMFGBCBGJLK, object OGHIOOJNKFP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EBGJGHJANMH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNIPFOOELOC(IIEPOFAMCFL EOFGGNOHAMG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IBIIOFFAJCM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBNHHAKAHKB(JPDHKDFBPEM BMFGBCBGJLK, IPEndPoint JEGKHKLHFJB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class AMOHCNEACNM
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int NMEEIBEDIFD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long LMIOGGDFMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte APJANHCODDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] AGGFCGPHIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ONKOLICEPIK NMPPAMCHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int CKOFOALDGKJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x746A040", Offset = "0x7469440", VA = "0x18746A040")]
	private AMOHCNEACNM(long GMHJINHNDPN, byte LOIECDFDLMH, int HNIIKCBNMGN, byte[] FJMEFAONIGP, ONKOLICEPIK NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7469E00", Offset = "0x7469200", VA = "0x187469E00")]
	public static int HFIKIBHJLKI(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7469BE0", Offset = "0x7468FE0", VA = "0x187469BE0")]
	public static AMOHCNEACNM CGDKBONIBAJ(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7469E60", Offset = "0x7469260", VA = "0x187469E60")]
	public static AHBJDEHMAFN NFIEOBHJIOH(ELHAPKDCOID PCIPMPOFEPF, SocketAddress JKAKDOCECOF, long DJMNHBEMIOM, int HNIIKCBNMGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class PCNKKDODJGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long LMIOGGDFMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte APJANHCODDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int CKOFOALDGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool DKECJMHHFLN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7480790", Offset = "0x747FB90", VA = "0x187480790")]
	private PCNKKDODJGO(long GMHJINHNDPN, byte LOIECDFDLMH, int JBNGOOHBKKC, bool LPKKDBNIDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7480450", Offset = "0x747F850", VA = "0x187480450")]
	public static PCNKKDODJGO CGDKBONIBAJ(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74806A0", Offset = "0x747FAA0", VA = "0x1874806A0")]
	public static AHBJDEHMAFN NFIEOBHJIOH(long DJMNHBEMIOM, byte HCGANHHDNJF, int MLGMKGJGJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74805A0", Offset = "0x747F9A0", VA = "0x1874805A0")]
	public static AHBJDEHMAFN LMFBLPFHHEA(JPDHKDFBPEM BMFGBCBGJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum BCIBMHJCEGP
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FCFCDOHABCI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDEBOBEGMGI(IPEndPoint ACMKIBMHPCH, IPEndPoint BLBPEFEEMBP, string MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJFJHOAGKJP(IPEndPoint LMPOFJGAMHB, BCIBMHJCEGP IIHAKBEOLJD, string MONGIMOHLAO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class POAFINNJLMO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HJAIDCICLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint LHCOCICCINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint OIIEHMMKFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string CKBDJOFGFBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct MNADHPEJCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint LPLFCOFGFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BCIBMHJCEGP GBFFBDIJNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string CKBDJOFGFBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class LGEPOCLACBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GOFBHOPOBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CKBDJOFGFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LGEPOCLACBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HCPKIIPNLLI
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint GOFBHOPOBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint CAMHEEJIDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string CKBDJOFGFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HCPKIIPNLLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class AHLFNOPEPMD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CKBDJOFGFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OGPLGNDMIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AHLFNOPEPMD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DIIGLGJHGPM IPKGOFDMDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<HJAIDCICLNM> NKLNKFAEGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<MNADHPEJCKA> MDIAPNCBONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly ONKOLICEPIK HMPLAGIDHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly ELHAPKDCOID AEIGFFIDKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CHCGFJEGLOP CLOAGMBKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private FCFCDOHABCI NOHKANNKJJE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int NPONJBNNMHA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool ADLBJKAIPHF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7480DD0", Offset = "0x74801D0", VA = "0x187480DD0")]
	internal POAFINNJLMO(DIIGLGJHGPM JKGDCCDNGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7480C50", Offset = "0x7480050", VA = "0x187480C50")]
	internal void IIAFIOJJEAE(IPEndPoint IKOIFAFOODK, AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3ED43F0", Offset = "0x3ED37F0", VA = "0x183ED43F0")]
	private void OFFKLMLFJJD<T>(T EOFGGNOHAMG, IPEndPoint NJJNDJLGDNH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74807E0", Offset = "0x747FBE0", VA = "0x1874807E0")]
	private void BDEBOBEGMGI(LGEPOCLACBL GCNGOCFBAKN, IPEndPoint IKOIFAFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7480AF0", Offset = "0x747FEF0", VA = "0x187480AF0")]
	private void IHKMOPMDJOL(HCPKIIPNLLI GCNGOCFBAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7480960", Offset = "0x747FD60", VA = "0x187480960")]
	private void HODGKFMKINI(AHLFNOPEPMD GCNGOCFBAKN, IPEndPoint IKOIFAFOODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JMKGIGLLEFA : byte
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
public enum GIPPLKKFFMP : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CBAOIALMNED
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] KHACFILANMP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int NPGNCLBCDPG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int CHGGMDPEPMF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FOBCGOKNGAC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7475220", Offset = "0x7474620", VA = "0x187475220")]
	public FOBCGOKNGAC(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAAOKBHBMKE : FOBCGOKNGAC
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7475220", Offset = "0x7474620", VA = "0x187475220")]
	public JAAOKBHBMKE(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HAIAFMBOLHA
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
public interface JAMFLKGCIFG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCCFEFIHCAC(HAIAFMBOLHA BNKADMBFHOB, string BPHJBCALMCO, params object[] PHAOHJHLKGO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DOKCABCEDDD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static JAMFLKGCIFG MOCEKADIEPK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object OILPMMCBICP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7472D10", Offset = "0x7472110", VA = "0x187472D10")]
	private static void NGNKLBEHENM(HAIAFMBOLHA KDOJFGEEHGG, string BPHJBCALMCO, params object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7472CB0", Offset = "0x74720B0", VA = "0x187472CB0")]
	internal static void NFPEIKNLKBI(string BPHJBCALMCO, params object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7472C50", Offset = "0x7472050", VA = "0x187472C50")]
	internal static void NANKFBEHFOG(string BPHJBCALMCO, params object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7472BF0", Offset = "0x7471FF0", VA = "0x187472BF0")]
	internal static void JFHAPMAMLHI(string BPHJBCALMCO, params object[] PHAOHJHLKGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum OGDHFNNIIGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JOFIFFMHNAK : ONKOLICEPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private AHBJDEHMAFN CIICNBDNFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly DIIGLGJHGPM MINBOAEILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LDMMDLJMJEP DPEJMBMFGLC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7477D30", Offset = "0x7477130", VA = "0x187477D30")]
	internal JOFIFFMHNAK(DIIGLGJHGPM JPGAFCLKGNM, LDMMDLJMJEP FLOCCDKNNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7477C90", Offset = "0x7477090", VA = "0x187477C90")]
	internal void EBAKALAAKOG(AHBJDEHMAFN EOFGGNOHAMG, int EPIIHIPEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7477C10", Offset = "0x7477010", VA = "0x187477C10")]
	internal void DOJOAJMJKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7477D00", Offset = "0x7477100", VA = "0x187477D00")]
	public void JKAPHJMLKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class LDMMDLJMJEP
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum NFDHDHMBHCB
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
	public LDMMDLJMJEP BKPAKGNHJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NFDHDHMBHCB GBFFBDIJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public JPDHKDFBPEM PKECPIKOHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint OIIEHMMKFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object INFOBOPGJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int FACAAALEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError DPIHOPJEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public CAOKNNBMCOG AHEMBNFOPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public KAHAPKIADEA BCKAMDPCKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public JMKGIGLLEFA PCAPNKPPKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte JFHNCCGJGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly JOFIFFMHNAK DOOKMAOEDML;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x747D430", Offset = "0x747C830", VA = "0x18747D430")]
	public LDMMDLJMJEP(DIIGLGJHGPM JPGAFCLKGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DIIGLGJHGPM : IEnumerable<JPDHKDFBPEM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class CFBNPFGHFIE : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x746A2F0", Offset = "0x74696F0", VA = "0x18746A2F0", Slot = "4")]
		public bool Equals(IPEndPoint FNBJHADJBNG, IPEndPoint MODFPFNICHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4572C90", Offset = "0x4572090", VA = "0x184572C90", Slot = "5")]
		public int GetHashCode(IPEndPoint DEJGDIIDCDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CFBNPFGHFIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct ALLOKGBBMEN : IEnumerator<JPDHKDFBPEM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly JPDHKDFBPEM JOFFBLHDGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private JPDHKDFBPEM JKDNCCJLFMN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JPDHKDFBPEM FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C95CD0", Offset = "0x1C950D0", VA = "0x181C95CD0")]
		public ALLOKGBBMEN(JPDHKDFBPEM AOECCAAAEOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7469B40", Offset = "0x7468F40", VA = "0x187469B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7469B90", Offset = "0x7468F90", VA = "0x187469B90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread HLCHMJFDJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool OODECMMOBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool DNMDOPDHDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NFNKGACIAMG PCOOBLDKGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent FGIOHECKHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<LDMMDLJMJEP> PKHMEEAIJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<LDMMDLJMJEP> PFACNLLJMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private LDMMDLJMJEP FOMCILGMBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GEKJOCOCACN OMDAMPAGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JGCAKDDPDMM GIFDIBHIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly EBGJGHJANMH MFPKIJKKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IBIIOFFAJCM DMBLNEKGLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, JPDHKDFBPEM> GPKCAOEAGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, KAHAPKIADEA> AMPHDHDNOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, LOBNKPDFNNP> GDICBCLNOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim EIGFGNNFNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private JPDHKDFBPEM EGFGJAJIJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int CCLINJEALFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<JPDHKDFBPEM> OKANIPDLJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private JPDHKDFBPEM[] DILHJHKGOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JELIJAKONPH NJFOFHELICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int KGODAFKCKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> HBJBFBHLJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte HEBODEAIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object KDODPKAEFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MMHAKPMJMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool FNECBBPMCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HNLIPGPPPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BJBNDKECKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int GKAIJMEHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int DOKJNFKKIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool NHLAOEHEODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool GGNLHGHBMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LLPLBCKPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HKLJKIAJDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int BBFEOECPJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool ADLBJKAIPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool IPFIDNONLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool JLDJHAJCDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool AIBIPHNMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int EBBIOELKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int JHFJHCKEAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool MFDPABCPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly MBDBFEHGCNL AEAIMDFJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool DFDJEIDFDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly POAFINNJLMO CPKJOEJAHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool BEMMFMMFMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public OGDHFNNIIGJ LOLMOANKAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int PKFHLLAJPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool PJLGALEJELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool GOHMPJHBNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool EAFPPHBOFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool MPNGBFJLCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AHBJDEHMAFN PGDJCCFFLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BHOMPEEPFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object FONJBOODHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private AHBJDEHMAFN BDNFACOGPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int JDAHEELAKOF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int LIJBPKAPMLJ = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int DBOCBPHBMMJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private FINNEFHNFGG HLLMMHFLBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private FINNEFHNFGG LHMJAJAGCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread OHINJGJOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread AHHPJOLJJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint EFLLFFJDCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint OFOBFCCODIG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] KFKDMNDOBLC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] OGJHJJEIGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<DIOFOHJMLOE, IPEndPoint> ABJFBDGEGEH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress JEIEPFHOCFL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool LKNIMEMDNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int PADJOEBMAAC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KBDDIGGMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBCF8F0", Offset = "0xBCECF0", VA = "0x180BCF8F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBD07B0", Offset = "0xBCFBB0", VA = "0x180BD07B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BHABBHCAMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x17E1E70", Offset = "0x17E1270", VA = "0x1817E1E70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20F4660", Offset = "0x20F3A60", VA = "0x1820F4660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte HIJOJPKKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1073BA0", Offset = "0x1072FA0", VA = "0x181073BA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HLIBBEEIONM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x746F2D0", Offset = "0x746E6D0", VA = "0x18746F2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short CCPHKFOCPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x746F780", Offset = "0x746EB80", VA = "0x18746F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JPDHKDFBPEM.GGIHBIAPBEJ HLHPGMBMOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x746FC80", Offset = "0x746F080", VA = "0x18746FC80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x746C050", Offset = "0x746B450", VA = "0x18746C050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x746BE30", Offset = "0x746B230", VA = "0x18746BE30")]
	public void DDKNAHJKKBM(IPEndPoint AICHGLEJCCE, byte[] PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7470930", Offset = "0x746FD30", VA = "0x187470930")]
	public void NMPMOBEENOJ(IPEndPoint AICHGLEJCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x746F230", Offset = "0x746E630", VA = "0x18746F230")]
	private bool IELHJLPBNDH(IPEndPoint AICHGLEJCCE, [Out] JPDHKDFBPEM BMFGBCBGJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7471120", Offset = "0x7470520", VA = "0x187471120")]
	private void OLCPGHHCDHN(JPDHKDFBPEM BMFGBCBGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x746FD30", Offset = "0x746F130", VA = "0x18746FD30")]
	private void LAGBFBOCOLG(JPDHKDFBPEM BMFGBCBGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x746DEF0", Offset = "0x746D2F0", VA = "0x18746DEF0")]
	private void FKBNBFNBBII(JPDHKDFBPEM BMFGBCBGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7472170", Offset = "0x7471570", VA = "0x187472170")]
	public DIIGLGJHGPM(GEKJOCOCACN GKNBMKFDKOP, [Optional] JELIJAKONPH IBILKMDIAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x746E1D0", Offset = "0x746D5D0", VA = "0x18746E1D0")]
	internal void FLLHMHDOIGD(JPDHKDFBPEM IMHGCFMODGF, int NNNIOLLBCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x746E2A0", Offset = "0x746D6A0", VA = "0x18746E2A0")]
	internal void GCKOLLMLPDM(JPDHKDFBPEM IMHGCFMODGF, object OGHIOOJNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7471F50", Offset = "0x7471350", VA = "0x187471F50")]
	internal void PKPFINMIDPF(JPDHKDFBPEM BMFGBCBGJLK, CAOKNNBMCOG HBHJOPNAJMN, SocketError DJCMECEJLCK, AHBJDEHMAFN FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x746BA10", Offset = "0x746AE10", VA = "0x18746BA10")]
	private void CMCOFFGCKOO(JPDHKDFBPEM BMFGBCBGJLK, CAOKNNBMCOG HBHJOPNAJMN, SocketError DJCMECEJLCK, bool KBIBIFOFAKG, byte[] NGIAGNLBILI, int FEMDGHMCLCC, int PPNAGMANAKJ, AHBJDEHMAFN FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x746E2F0", Offset = "0x746D6F0", VA = "0x18746E2F0")]
	private void GGMEDKMKOPA(LDMMDLJMJEP.NFDHDHMBHCB IIHAKBEOLJD, [Optional] JPDHKDFBPEM BMFGBCBGJLK, [Optional] IPEndPoint BLBPEFEEMBP, SocketError FCDCKNGNLFJ = SocketError.Success, int NNNIOLLBCAH = 0, CAOKNNBMCOG EJHBOPEMJMA = CAOKNNBMCOG.ConnectionFailed, [Optional] KAHAPKIADEA DKFILNBNFMI, JMKGIGLLEFA MOJDMNEKBMB = JMKGIGLLEFA.Unreliable, byte EEMMEGGJNHG = 0, [Optional] AHBJDEHMAFN LJFALPLMEJO, [Optional] object OGHIOOJNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x746E6D0", Offset = "0x746DAD0", VA = "0x18746E6D0")]
	private void HDELGENHEIO(LDMMDLJMJEP FLOCCDKNNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x746F2F0", Offset = "0x746E6F0", VA = "0x18746F2F0")]
	internal void IFKMAJOLDEA(LDMMDLJMJEP FLOCCDKNNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7471460", Offset = "0x7470860", VA = "0x187471460")]
	private void PAGBBFDDBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7470610", Offset = "0x746FA10", VA = "0x187470610")]
	private void MIFPBGAOMNO(int CIEALGJJAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7471930", Offset = "0x7470D30", VA = "0x187471930")]
	internal JPDHKDFBPEM PFGHGIIGJHH(KAHAPKIADEA IDLJGJGIGEG, byte[] GBAEJHCHJIE, int FEMDGHMCLCC, int COONBEDHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x746E220", Offset = "0x746D620", VA = "0x18746E220")]
	private int FNCBMCKFNFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x746C100", Offset = "0x746B500", VA = "0x18746C100")]
	private void EKEJNLLKJIE(IPEndPoint BLBPEFEEMBP, JPDHKDFBPEM HHJMINHDKOJ, AMOHCNEACNM JAKGGDPMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x746C5B0", Offset = "0x746B9B0", VA = "0x18746C5B0")]
	private void EOCCHJNKLGO(AHBJDEHMAFN EOFGGNOHAMG, IPEndPoint BLBPEFEEMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x746DC10", Offset = "0x746D010", VA = "0x18746DC10")]
	internal void FJGPEKDOOGA(AHBJDEHMAFN EOFGGNOHAMG, JMKGIGLLEFA GAAAFGHGFFJ, byte EEMMEGGJNHG, int EPIIHIPEJFF, JPDHKDFBPEM IMHGCFMODGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x746A780", Offset = "0x7469B80", VA = "0x18746A780")]
	public bool BCIEBGDAIDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x746AFE0", Offset = "0x746A3E0", VA = "0x18746AFE0")]
	public bool BCIEBGDAIDM(IPAddress PBHFICHIIBB, IPAddress IECBCJIPMAC, int OLAKHHHFHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x746AF60", Offset = "0x746A360", VA = "0x18746AF60")]
	public bool BCIEBGDAIDM(int OLAKHHHFHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7470F70", Offset = "0x7470370", VA = "0x187470F70")]
	public void OIICJNGKGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x746B000", Offset = "0x746A400", VA = "0x18746B000")]
	public JPDHKDFBPEM BNHIMEOLFPN(string KKANHCDLFID, int OLAKHHHFHOH, string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x746B4C0", Offset = "0x746A8C0", VA = "0x18746B4C0")]
	public JPDHKDFBPEM BNHIMEOLFPN(string KKANHCDLFID, int OLAKHHHFHOH, ELHAPKDCOID GPEJGKHIFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x746B0E0", Offset = "0x746A4E0", VA = "0x18746B0E0")]
	public JPDHKDFBPEM BNHIMEOLFPN(IPEndPoint NJJNDJLGDNH, ELHAPKDCOID GPEJGKHIFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7470C00", Offset = "0x7470000", VA = "0x187470C00")]
	public void ODFHFAFBGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7470C10", Offset = "0x7470010", VA = "0x187470C10")]
	public void ODFHFAFBGGG(bool DANMPDLEGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x746B5A0", Offset = "0x746A9A0", VA = "0x18746B5A0")]
	public void BPFGKGOHJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x746B650", Offset = "0x746AA50", VA = "0x18746B650")]
	public void BPFGKGOHJHC(byte[] NGIAGNLBILI, int FEMDGHMCLCC, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x746B990", Offset = "0x746AD90", VA = "0x18746B990")]
	public void CMCOFFGCKOO(JPDHKDFBPEM BMFGBCBGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x746B9D0", Offset = "0x746ADD0", VA = "0x18746B9D0")]
	public void CMCOFFGCKOO(JPDHKDFBPEM BMFGBCBGJLK, byte[] NGIAGNLBILI, int FEMDGHMCLCC, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7471F90", Offset = "0x7471390", VA = "0x187471F90", Slot = "4")]
	private IEnumerator<JPDHKDFBPEM> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7472020", Offset = "0x7471420", VA = "0x187472020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x746F400", Offset = "0x746E800", VA = "0x18746F400")]
	private AHBJDEHMAFN IIFMKNAHOON(PKCGONCCGGD NBOAFDFPIEI, int MPDDFCCPIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x746F4F0", Offset = "0x746E8F0", VA = "0x18746F4F0")]
	private AHBJDEHMAFN IIFMKNAHOON(PKCGONCCGGD NBOAFDFPIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x746B720", Offset = "0x746AB20", VA = "0x18746B720")]
	internal AHBJDEHMAFN CBLGKGJCOHA(int MPDDFCCPIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x746D9A0", Offset = "0x746CDA0", VA = "0x18746D9A0")]
	internal void FBFCJGDKMNH(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74720B0", Offset = "0x74714B0", VA = "0x1874720B0")]
	static DIIGLGJHGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBCF8F0", Offset = "0xBCECF0", VA = "0x180BCF8F0")]
	private bool IABJMOAGIIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7470A80", Offset = "0x746FE80", VA = "0x187470A80")]
	private void NPHDFKNMIHI(IPEndPoint OEAOFLACJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x746F840", Offset = "0x746EC40", VA = "0x18746F840")]
	private void KAGLGOHHCLF(IPEndPoint OEAOFLACJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x746F5D0", Offset = "0x746E9D0", VA = "0x18746F5D0")]
	private bool JHGKCEEBHAL(SocketException DGLGDFPJBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x746B970", Offset = "0x746AD70", VA = "0x18746B970")]
	private void CLKIGEFFNBN(NFNKGACIAMG JKGDCCDNGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x746F9B0", Offset = "0x746EDB0", VA = "0x18746F9B0")]
	private void KEEEDOKALCK(FINNEFHNFGG JKGDCCDNGMG, EndPoint GNABJPGDIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x746EE90", Offset = "0x746E290", VA = "0x18746EE90")]
	private void HLPJKDPJCOE(object JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x746A790", Offset = "0x7469B90", VA = "0x18746A790")]
	public bool BCIEBGDAIDM(IPAddress PBHFICHIIBB, IPAddress IECBCJIPMAC, int OLAKHHHFHOH, bool INLLGKPJCLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x74705B0", Offset = "0x746F9B0", VA = "0x1874705B0")]
	internal int MAEENADICPD(AHBJDEHMAFN EOFGGNOHAMG, IPEndPoint BLBPEFEEMBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x746FD90", Offset = "0x746F190", VA = "0x18746FD90")]
	internal int LEMLDJEMHOG(AHBJDEHMAFN EOFGGNOHAMG, IPEndPoint BLBPEFEEMBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x746FDD0", Offset = "0x746F1D0", VA = "0x18746FDD0")]
	internal int LEMLDJEMHOG(byte[] AFDNIPHJHMO, int FEMDGHMCLCC, int COONBEDHJNN, IPEndPoint BLBPEFEEMBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74717B0", Offset = "0x7470BB0", VA = "0x1874717B0")]
	internal void PBKBNEPBEIP(bool KEEABNMEAFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum PKCGONCCGGD : byte
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
internal sealed class AHBJDEHMAFN
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int BAAPJDKIJJG;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] NLCFGMGDODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] AACLLAMFAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int GDGDNNAMJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object INFOBOPGJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AHBJDEHMAFN BKPAKGNHJLP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PKCGONCCGGD DECDJGINCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7469200", Offset = "0x7468600", VA = "0x187469200")]
		get
		{
			return default(PKCGONCCGGD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7469600", Offset = "0x7468A00", VA = "0x187469600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte APJANHCODDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7469520", Offset = "0x7468920", VA = "0x187469520")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7469550", Offset = "0x7468950", VA = "0x187469550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort HLFACIGAIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7469260", Offset = "0x7468660", VA = "0x187469260")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7469640", Offset = "0x7468A40", VA = "0x187469640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AAHPALNCDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7469680", Offset = "0x7468A80", VA = "0x187469680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte MEMNFJOJAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74695D0", Offset = "0x74689D0", VA = "0x1874695D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74696B0", Offset = "0x7468AB0", VA = "0x1874696B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort EBCNHNELLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7469320", Offset = "0x7468720", VA = "0x187469320")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74691C0", Offset = "0x74685C0", VA = "0x1874691C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort EAFAILNAHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74692C0", Offset = "0x74686C0", VA = "0x1874692C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7469480", Offset = "0x7468880", VA = "0x187469480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort OOONLLHNIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x74694C0", Offset = "0x74688C0", VA = "0x1874694C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7469590", Offset = "0x7468990", VA = "0x187469590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74696E0", Offset = "0x7468AE0", VA = "0x1874696E0")]
	static AHBJDEHMAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7469230", Offset = "0x7468630", VA = "0x187469230")]
	public void BIEHCMDDCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74699C0", Offset = "0x7468DC0", VA = "0x1874699C0")]
	public AHBJDEHMAFN(int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7469A30", Offset = "0x7468E30", VA = "0x187469A30")]
	public AHBJDEHMAFN(PKCGONCCGGD NBOAFDFPIEI, int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x74690C0", Offset = "0x74684C0", VA = "0x1874690C0")]
	public static int AFAJKANINJC(PKCGONCCGGD NBOAFDFPIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7469130", Offset = "0x7468530", VA = "0x187469130")]
	public int AFAJKANINJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7469380", Offset = "0x7468780", VA = "0x187469380")]
	public bool GLMGLGJKPOH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum BBCFNJFHOED : byte
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
internal enum OKLIGECGBBJ
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
internal enum FELHBPOMHNA
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum LIHPDBFFDFP
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JPDHKDFBPEM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class OHFOEOCDAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AHBJDEHMAFN[] EIJFEBDLPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int IIMPEIEMDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int LDOCKAFLPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte MEMNFJOJAMJ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OHFOEOCDAIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void GGIHBIAPBEJ(ulong ADFKJFBKIOD, int PPALLFJCGHB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int OMCIOJNEOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KBOFGIKOHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int EKEJDLHMPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double NAEGKGDIOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int EJEHBDLKICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int BFIBKBEOHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int CDHINBGHCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch FPOKLDPIAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int CBFMOKACOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long KJJINAHHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object EBMIIJKOPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal JPDHKDFBPEM HOAKIIHLBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal JPDHKDFBPEM BBOHOPHKPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<AHBJDEHMAFN> BBAHOABKIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<MFKKNMCOJDJ> KEOEBHDIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly MFKKNMCOJDJ[] JIECOELGDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int MFLGKJCJNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MGNPLGJFBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool JCEAPLFNOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int CPGFGGGFCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int CHLEBNAECLL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int PLICJNLGNFJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int FHFOKGFFCHF = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object JPCLCHDDPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LNJHBCEGLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, OHFOEOCDAIK> HGANEBFACLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> MCFKKEKLMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly AHBJDEHMAFN LJFIMLMGEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int CKELNBCIAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int NPAJNAEMJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint EEDMCKDMEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JCENKKJHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int FJOEDPGEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long DEPBOHJJGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte OLNFDFJNJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private BBCFNJFHOED LIPMDHDFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private AHBJDEHMAFN JDJICLNIJKJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int OOICNENEHDL = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int LEKLHJCECDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly AHBJDEHMAFN CADGOFMLJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly AHBJDEHMAFN MHPIFJPHKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly AHBJDEHMAFN CFMDIIANLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly AHBJDEHMAFN DKBMHJLKCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private GIPPLKKFFMP JHOCHFLNOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly DIIGLGJHGPM DPMLGKDMPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int NGBODNHEHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object HKDCHEDCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly MBDBFEHGCNL AEAIMDFJODN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte MLHCBAKHFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED00", Offset = "0xB1E100", VA = "0x180B1ED00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x747B8B0", Offset = "0x747ACB0", VA = "0x18747B8B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint PLEACJLIHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED20", Offset = "0xB1E120", VA = "0x180B1ED20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BBCFNJFHOED BAELBCBMCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB1F100", Offset = "0xB1E500", VA = "0x180B1F100")]
		get
		{
			return default(BBCFNJFHOED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long ODFKAPEJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA76C20", Offset = "0xA76020", VA = "0x180A76C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GOOIJOOMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x17E1E70", Offset = "0x17E1270", VA = "0x1817E1E70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20F4660", Offset = "0x20F3A60", VA = "0x1820F4660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int INACIMDKLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x74792B0", Offset = "0x74786B0", VA = "0x1874792B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DBMABAEGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double OMHDPKPJJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x57F1360", Offset = "0x57F0760", VA = "0x1857F1360")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GGIHBIAPBEJ HLHPGMBMOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x747A030", Offset = "0x7479430", VA = "0x18747A030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7478F70", Offset = "0x7478370", VA = "0x187478F70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x747B960", Offset = "0x747AD60", VA = "0x18747B960")]
	internal JPDHKDFBPEM(DIIGLGJHGPM EDEEMAKNLDH, IPEndPoint BLBPEFEEMBP, int CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x747AB90", Offset = "0x7479F90", VA = "0x18747AB90")]
	internal void NDHBMJIFIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74785A0", Offset = "0x74779A0", VA = "0x1874785A0")]
	internal void DDFECMCNJPH(IPEndPoint JLELPKGIMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7478150", Offset = "0x7477550", VA = "0x187478150")]
	internal void BPCEMGBJABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7479020", Offset = "0x7478420", VA = "0x187479020")]
	private void EJMNENADEKD(int ICNNLEBHMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x74792C0", Offset = "0x74786C0", VA = "0x1874792C0")]
	private void GDGLHNCEGFE(int FPCKEDDOILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7477F20", Offset = "0x7477320", VA = "0x187477F20")]
	public int BPAKDMGFDCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7478030", Offset = "0x7477430", VA = "0x187478030")]
	public int BPAKDMGFDCA(byte EEMMEGGJNHG, bool MMODDHOEDDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74783F0", Offset = "0x74777F0", VA = "0x1874783F0")]
	private MFKKNMCOJDJ CNBKCDPOEFE(byte PFKMHLGKANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x747BFA0", Offset = "0x747B3A0", VA = "0x18747BFA0")]
	internal JPDHKDFBPEM(DIIGLGJHGPM EDEEMAKNLDH, IPEndPoint BLBPEFEEMBP, int CLNGGGMIBPI, byte HCGANHHDNJF, ELHAPKDCOID PCIPMPOFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x747BDC0", Offset = "0x747B1C0", VA = "0x18747BDC0")]
	internal JPDHKDFBPEM(DIIGLGJHGPM EDEEMAKNLDH, KAHAPKIADEA IDLJGJGIGEG, int CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7479F60", Offset = "0x7479360", VA = "0x187479F60")]
	internal void JMBIFOCBNCD(AMOHCNEACNM PMEPDMCEJIP, byte[] NGIAGNLBILI, int FEMDGHMCLCC, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7479FB0", Offset = "0x74793B0", VA = "0x187479FB0")]
	internal bool KBNLLLOIKOA(PCNKKDODJGO EOFGGNOHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x747ABB0", Offset = "0x7479FB0", VA = "0x18747ABB0")]
	public void OFFKLMLFJJD(byte[] NGIAGNLBILI, int FEMDGHMCLCC, int COONBEDHJNN, JMKGIGLLEFA LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x747B2A0", Offset = "0x747A6A0", VA = "0x18747B2A0")]
	private void OOMEGJFKIEJ(byte[] NGIAGNLBILI, int FEMDGHMCLCC, int COONBEDHJNN, byte EEMMEGGJNHG, JMKGIGLLEFA MOJDMNEKBMB, object OGHIOOJNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7477ED0", Offset = "0x74772D0", VA = "0x187477ED0")]
	public void BNEJFADOIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x747A0E0", Offset = "0x74794E0", VA = "0x18747A0E0")]
	internal FELHBPOMHNA LLDIMHJENHN(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return default(FELHBPOMHNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7479300", Offset = "0x7478700", VA = "0x187479300")]
	internal void GNKMFDAPFLD(MFKKNMCOJDJ KOIMDLHEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x747A1C0", Offset = "0x74795C0", VA = "0x18747A1C0")]
	internal LIHPDBFFDFP MEJGLJIGBBE(byte[] NGIAGNLBILI, int FEMDGHMCLCC, int COONBEDHJNN, bool KBIBIFOFAKG)
	{
		return default(LIHPDBFFDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7479360", Offset = "0x7478760", VA = "0x187479360")]
	private void HCJKJFHFMHE(int MHFEGDAIKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x74785D0", Offset = "0x74779D0", VA = "0x1874785D0")]
	internal void DPKNBAIJFDL(JMKGIGLLEFA GAAAFGHGFFJ, AHBJDEHMAFN AOECCAAAEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x74799F0", Offset = "0x7478DF0", VA = "0x1874799F0")]
	private void JCGEGOKLCGC(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x74793A0", Offset = "0x74787A0", VA = "0x1874793A0")]
	private void HDMJNMIIGNN(int HBFJOJKDNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x74790F0", Offset = "0x74784F0", VA = "0x1874790F0")]
	internal OKLIGECGBBJ EKEJNLLKJIE(AMOHCNEACNM JAKGGDPMAJB)
	{
		return default(OKLIGECGBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x747A4D0", Offset = "0x74798D0", VA = "0x18747A4D0")]
	internal void MFKLNNLLNLM(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7477D80", Offset = "0x7477180", VA = "0x187477D80")]
	private void AMEFBBIOKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74781E0", Offset = "0x74775E0", VA = "0x1874781E0")]
	internal void CLLMFMGFPDL(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x747ABE0", Offset = "0x7479FE0", VA = "0x18747ABE0")]
	internal void OGELNPLKAMN(int HBFJOJKDNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7479730", Offset = "0x7478B30", VA = "0x187479730")]
	internal void IPBAOIKIGME(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class MBDBFEHGCNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long DABDFBNDAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long LICPPDKAKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long AHACHJAMPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long MFMOAMLKGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GDIIMOGMIAB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long BGHHMDEFLDN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long NFJFPMLIOAN;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long KCGBMBFCFEA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long IOEFBBJODIP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long JFBNLBPNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long MNMODMMCOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long JMMHGECCFMO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long NEMCHHMIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x747F170", Offset = "0x747E570", VA = "0x18747F170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LDABOOGBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x747EDE0", Offset = "0x747E1E0", VA = "0x18747EDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long KPMLFMCGMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x747F250", Offset = "0x747E650", VA = "0x18747F250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IKHFCJOGMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x747EED0", Offset = "0x747E2D0", VA = "0x18747EED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long GCINNEFBLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x747F0B0", Offset = "0x747E4B0", VA = "0x18747F0B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long JNIEMGHDFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x747F260", Offset = "0x747E660", VA = "0x18747F260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long LACEAAPMOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x747EDF0", Offset = "0x747E1F0", VA = "0x18747EDF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long DKHDHPOLPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x747F000", Offset = "0x747E400", VA = "0x18747F000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private GIPPLKKFFMP NMOCEAEFDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double JLMEDDGINOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x747F1F0", Offset = "0x747E5F0", VA = "0x18747F1F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x747EE30", Offset = "0x747E230", VA = "0x18747EE30")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x747EE70", Offset = "0x747E270", VA = "0x18747EE70")]
	public void CPKGIMIHBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x747F0C0", Offset = "0x747E4C0", VA = "0x18747F0C0")]
	public void KKFGDDBNMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x747F040", Offset = "0x747E440", VA = "0x18747F040")]
	public void HADEAKKDDII(long KAJJGJEKCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x747F180", Offset = "0x747E580", VA = "0x18747F180")]
	public void NCIHPNCGMFN(long OBJFGPBJIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x747F110", Offset = "0x747E510", VA = "0x18747F110")]
	public void LFPDOIEOBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x747EEE0", Offset = "0x747E2E0", VA = "0x18747EEE0")]
	public void EGAOGOLDMKA(long ANLINBBIIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x747F270", Offset = "0x747E670", VA = "0x18747F270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x747EF60", Offset = "0x747E360", VA = "0x18747EF60")]
	public void FBPCIKIDHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MBDBFEHGCNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JLEJJKFAKNA
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> HNAKKECPBEK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74776A0", Offset = "0x7476AA0", VA = "0x1874776A0")]
	public static IPEndPoint GMCNCBFPMEL(string PDMGIJENKEF, int OLAKHHHFHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x74778F0", Offset = "0x7476CF0", VA = "0x1874778F0")]
	public static IPAddress JPCGIMCEIKJ(string PDMGIJENKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7477AC0", Offset = "0x7476EC0", VA = "0x187477AC0")]
	public static IPAddress JPCGIMCEIKJ(string PDMGIJENKEF, AddressFamily MGDDGHLGCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7477B50", Offset = "0x7476F50", VA = "0x187477B50")]
	internal static int KBOJLMBBLND(int NKADLMBACPN, int KMBHGPAJLKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D55AB0", Offset = "0x3D54EB0", VA = "0x183D55AB0")]
	internal static T[] NMOICDCIBDO<T>(int PPNAGMANAKJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HJNOAEFFKPO : MFKKNMCOJDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct KNDBAOJIECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private AHBJDEHMAFN CIICNBDNFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long EDOMAEMECNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool ALAJLMNCCFJ;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x747C370", Offset = "0x747B770", VA = "0x18747C370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x747C2E0", Offset = "0x747B6E0", VA = "0x18747C2E0")]
		public void IPJPKJAMFMN(AHBJDEHMAFN EOFGGNOHAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x747C300", Offset = "0x747B700", VA = "0x18747C300")]
		public bool MFFBNFELIIH(long DDNEMGEJNEH, JPDHKDFBPEM BMFGBCBGJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x747C290", Offset = "0x747B690", VA = "0x18747C290")]
		public bool HBLMHKLDBPD(JPDHKDFBPEM BMFGBCBGJLK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly AHBJDEHMAFN GMOFBEEHDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly KNDBAOJIECD[] JGNGEODIJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly AHBJDEHMAFN[] CMFCLKOHBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] GIJPJDJKAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EIHBLCGDGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int MBIDGJKNILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int OFCEHPBHDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int EHAHFJBMKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool PKHJEKOODAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly JMKGIGLLEFA GLPPMNDIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool DHOJKHCJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int KLJJBMKADLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte NHMIEJAJDBO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JOEENGEEMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7475700", Offset = "0x7474B00", VA = "0x187475700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7476130", Offset = "0x7475530", VA = "0x187476130")]
	public HJNOAEFFKPO(JPDHKDFBPEM BMFGBCBGJLK, bool MMODDHOEDDN, byte CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7475710", Offset = "0x7474B10", VA = "0x187475710")]
	private void GCJGGGCFFKP(AHBJDEHMAFN EOFGGNOHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7475230", Offset = "0x7474630", VA = "0x187475230", Slot = "4")]
	protected override bool CLBCNAGJFIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7475AD0", Offset = "0x7474ED0", VA = "0x187475AD0", Slot = "5")]
	public override bool MFKLNNLLNLM(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FLNLHJAEEKM : MFKKNMCOJDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int HHNIIPKIPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort MBIDGJKNILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool HLJOEPBGPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private AHBJDEHMAFN OBEMBFNNOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly AHBJDEHMAFN KMMJKEODMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool JPIANNHBOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte NHMIEJAJDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long OHHEANKIHII;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7474640", Offset = "0x7473A40", VA = "0x187474640")]
	public FLNLHJAEEKM(JPDHKDFBPEM BMFGBCBGJLK, bool GJDBEIGBLBC, byte CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7473EA0", Offset = "0x74732A0", VA = "0x187473EA0", Slot = "4")]
	protected override bool CLBCNAGJFIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7474360", Offset = "0x7473760", VA = "0x187474360", Slot = "5")]
	public override bool MFKLNNLLNLM(AHBJDEHMAFN EOFGGNOHAMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BOIHMHDGNJH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct IOPIJHGNJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong LLDFNKHADHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double OFAGKGOPOLB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct BIPABJOHKNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int DPINFLMLCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float EBOJPCNNAON;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7468AE0", Offset = "0x7467EE0", VA = "0x187468AE0")]
	private static void IPHALEOANBA(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, ulong NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x746A0F0", Offset = "0x74694F0", VA = "0x18746A0F0")]
	private static void IPHALEOANBA(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, int NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x746A0B0", Offset = "0x74694B0", VA = "0x18746A0B0")]
	public static void IPHALEOANBA(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, short NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x746A160", Offset = "0x7469560", VA = "0x18746A160")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, double CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x746A190", Offset = "0x7469590", VA = "0x18746A190")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x746A0B0", Offset = "0x74694B0", VA = "0x18746A0B0")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, short CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x746A0B0", Offset = "0x74694B0", VA = "0x18746A0B0")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, ushort CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x746A0F0", Offset = "0x74694F0", VA = "0x18746A0F0")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x746A0F0", Offset = "0x74694F0", VA = "0x18746A0F0")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, uint CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x746A180", Offset = "0x7469580", VA = "0x18746A180")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, long CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x746A180", Offset = "0x7469580", VA = "0x18746A180")]
	public static void CDNNBEFEGOH(byte[] FGHKEPJEKFP, int FDIBAFEDFOG, ulong CBMEHPPMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ONKOLICEPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] HEEDNJCIPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int KBLKOCDALAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int FOIDJMOAIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int EJNIHPEFECG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] AACLLAMFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DMIGCAIBNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int BPCGKKODNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x747FEC0", Offset = "0x747F2C0", VA = "0x18747FEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EIOKBFFFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x294D3D0", Offset = "0x294C7D0", VA = "0x18294D3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int LHGBFMKPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x747FF10", Offset = "0x747F310", VA = "0x18747FF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x747FC80", Offset = "0x747F080", VA = "0x18747FC80")]
	public void EBAKALAAKOG(byte[] NHDOFIDIKGL, int FDIDNNCIDHK, int INLHALEBBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ONKOLICEPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74803F0", Offset = "0x747F7F0", VA = "0x1874803F0")]
	public ONKOLICEPIK(byte[] NHDOFIDIKGL, int FDIDNNCIDHK, int INLHALEBBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x747FF90", Offset = "0x747F390", VA = "0x18747FF90")]
	public IPEndPoint MADDMKPCNLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x747FDB0", Offset = "0x747F1B0", VA = "0x18747FDB0")]
	public byte LIBKHBBPEHG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x747FDB0", Offset = "0x747F1B0", VA = "0x18747FDB0")]
	public sbyte GLMDOCKFAAL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC10E0", Offset = "0x3EC04E0", VA = "0x183EC10E0")]
	public T[] DEAKFMGPGNF<T>(ushort MPDDFCCPIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x747FE80", Offset = "0x747F280", VA = "0x18747FE80")]
	public bool[] IPPDLCBHNFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x747FC00", Offset = "0x747F000", VA = "0x18747FC00")]
	public ushort[] DMCIEAGGOAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x747FED0", Offset = "0x747F2D0", VA = "0x18747FED0")]
	public short[] KHKEADDHEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x747F850", Offset = "0x747EC50", VA = "0x18747F850")]
	public int[] ABHELLDFMFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x747FB50", Offset = "0x747EF50", VA = "0x18747FB50")]
	public uint[] DIBHILCAEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x747FB10", Offset = "0x747EF10", VA = "0x18747FB10")]
	public float[] DBPIHHHEHPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x747FA60", Offset = "0x747EE60", VA = "0x18747FA60")]
	public double[] BJLJNCLMKEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x747F890", Offset = "0x747EC90", VA = "0x18747F890")]
	public long[] ALBJEEMINKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x747FD70", Offset = "0x747F170", VA = "0x18747FD70")]
	public ulong[] FFHBHFHNCNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x747F910", Offset = "0x747ED10", VA = "0x18747F910")]
	public string[] BHDOBLKPMGP(int OIBOBLFOAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x747FC40", Offset = "0x747F040", VA = "0x18747FC40")]
	public bool DPJJBHENMIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x747FB90", Offset = "0x747EF90", VA = "0x18747FB90")]
	public char DKLFBPKGDGJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x747FB90", Offset = "0x747EF90", VA = "0x18747FB90")]
	public ushort FLCMLIDOFCK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x747F7E0", Offset = "0x747EBE0", VA = "0x18747F7E0")]
	public short AAIHNNNKLKI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x747FAA0", Offset = "0x747EEA0", VA = "0x18747FAA0")]
	public long CHIJGOHCKKP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x747FCC0", Offset = "0x747F0C0", VA = "0x18747FCC0")]
	public ulong ECFKJEFJOLJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x747FF20", Offset = "0x747F320", VA = "0x18747FF20")]
	public int LNCPBNNHJLB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x74800D0", Offset = "0x747F4D0", VA = "0x1874800D0")]
	public uint PAIMKEPHEFC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7480380", Offset = "0x747F780", VA = "0x187480380")]
	public float PNHLGHOMBOC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7480060", Offset = "0x747F460", VA = "0x187480060")]
	public double MLHAGFDFOJG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7480140", Offset = "0x747F540", VA = "0x187480140")]
	public string PJCBHMFMFID(int LADMEHMLHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x747FE10", Offset = "0x747F210", VA = "0x18747FE10")]
	public ArraySegment<byte> HFIFEHKMICC(int PPNAGMANAKJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x747F8D0", Offset = "0x747ECD0", VA = "0x18747F8D0")]
	public sbyte[] APDNHCKGGEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x747FD30", Offset = "0x747F130", VA = "0x18747FD30")]
	public byte[] ENEPINBFCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x747FDF0", Offset = "0x747F1F0", VA = "0x18747FDF0")]
	public void HBLMHKLDBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ELHAPKDCOID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] HEEDNJCIPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int KBLKOCDALAD;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int EDPNIMMEEAL = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool MJPFLGLNMKL;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding CDANHFPBDAI;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int PDPNCACKAKP = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] FPOOEFKGOLL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] NMPPAMCHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7473D80", Offset = "0x7473180", VA = "0x187473D80")]
	public ELHAPKDCOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7473E00", Offset = "0x7473200", VA = "0x187473E00")]
	public ELHAPKDCOID(bool OCEKNMKFAEO, int DFFAJGNICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7473C80", Offset = "0x7473080", VA = "0x187473C80")]
	public static ELHAPKDCOID MKFOPNFNPDF(string CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74736B0", Offset = "0x7472AB0", VA = "0x1874736B0")]
	public void GAGLLHICJMC(int OMIFOFFGBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x29C7710", Offset = "0x29C6B10", VA = "0x1829C7710")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7473610", Offset = "0x7472A10", VA = "0x187473610")]
	public void BBIGMOGOBDN(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7473460", Offset = "0x7472860", VA = "0x187473460")]
	public void BBIGMOGOBDN(double CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7473340", Offset = "0x7472740", VA = "0x187473340")]
	public void BBIGMOGOBDN(long CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7473340", Offset = "0x7472740", VA = "0x187473340")]
	public void BBIGMOGOBDN(ulong CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x74734B0", Offset = "0x74728B0", VA = "0x1874734B0")]
	public void BBIGMOGOBDN(int CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x74734B0", Offset = "0x74728B0", VA = "0x1874734B0")]
	public void BBIGMOGOBDN(uint CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7473050", Offset = "0x7472450", VA = "0x187473050")]
	public void BBIGMOGOBDN(char CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7473050", Offset = "0x7472450", VA = "0x187473050")]
	public void BBIGMOGOBDN(ushort CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7473050", Offset = "0x7472450", VA = "0x187473050")]
	public void BBIGMOGOBDN(short CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7473400", Offset = "0x7472800", VA = "0x187473400")]
	public void BBIGMOGOBDN(sbyte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7473400", Offset = "0x7472800", VA = "0x187473400")]
	public void BBIGMOGOBDN(byte CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x74732D0", Offset = "0x74726D0", VA = "0x1874732D0")]
	public void BBIGMOGOBDN(byte[] NGIAGNLBILI, int FDIDNNCIDHK, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7473BA0", Offset = "0x7472FA0", VA = "0x187473BA0")]
	public void KDKOFILBKMC(sbyte[] NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7473BA0", Offset = "0x7472FA0", VA = "0x187473BA0")]
	public void LPAHGOHIHKK(byte[] NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74733A0", Offset = "0x74727A0", VA = "0x1874733A0")]
	public void BBIGMOGOBDN(bool CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7473910", Offset = "0x7472D10", VA = "0x187473910")]
	public void IIOILGMDGED(Array OLEJLIDKEEL, int FHNAJMAIGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74739F0", Offset = "0x7472DF0", VA = "0x1874739F0")]
	public void IIOILGMDGED(float[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7473750", Offset = "0x7472B50", VA = "0x187473750")]
	public void IIOILGMDGED(double[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7473750", Offset = "0x7472B50", VA = "0x187473750")]
	public void IIOILGMDGED(long[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7473750", Offset = "0x7472B50", VA = "0x187473750")]
	public void IIOILGMDGED(ulong[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x74739F0", Offset = "0x7472DF0", VA = "0x1874739F0")]
	public void IIOILGMDGED(int[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x74739F0", Offset = "0x7472DF0", VA = "0x1874739F0")]
	public void IIOILGMDGED(uint[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7473830", Offset = "0x7472C30", VA = "0x187473830")]
	public void IIOILGMDGED(ushort[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7473830", Offset = "0x7472C30", VA = "0x187473830")]
	public void IIOILGMDGED(short[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7473BA0", Offset = "0x7472FA0", VA = "0x187473BA0")]
	public void IIOILGMDGED(bool[] CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7473AD0", Offset = "0x7472ED0", VA = "0x187473AD0")]
	public void IIOILGMDGED(string[] CBMEHPPMEEA, int AFNICDJDAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7473540", Offset = "0x7472940", VA = "0x187473540")]
	public void BBIGMOGOBDN(IPEndPoint AICHGLEJCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7473390", Offset = "0x7472790", VA = "0x187473390")]
	public void BBIGMOGOBDN(string CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x74730C0", Offset = "0x74724C0", VA = "0x1874730C0")]
	public void BBIGMOGOBDN(string CBMEHPPMEEA, int LADMEHMLHKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CHCGFJEGLOP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class JEJBEJPJMLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong NGBODNHEHKM;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5308150", Offset = "0x5307550", VA = "0x185308150")]
		static JEJBEJPJMLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void BGHDMIIHKKK(ONKOLICEPIK BPCOJLPPMNI, object OGHIOOJNKFP);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FHBCJKFHKBJ<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CHCGFJEGLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FHBCJKFHKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4E90A30", Offset = "0x4E8FE30", VA = "0x184E90A30")]
		internal void MLIDOAKPAJG(ONKOLICEPIK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class LKJJMMPNHIC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CHCGFJEGLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LKJJMMPNHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x551AB80", Offset = "0x5519F80", VA = "0x18551AB80")]
		internal void MLIDOAKPAJG(ONKOLICEPIK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly DAMMCACPBEB EFBJEOLCGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, BGHDMIIHKKK> EDPMNEIDBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly ELHAPKDCOID HIAKJAHPMFM;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x746A560", Offset = "0x7469960", VA = "0x18746A560")]
	public CHCGFJEGLOP(int OIBOBLFOAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DB00", Offset = "0x3A3CF00", VA = "0x183A3DB00", Slot = "4")]
	protected virtual ulong CJGHENMPGKH<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x746A360", Offset = "0x7469760", VA = "0x18746A360", Slot = "5")]
	protected virtual BGHDMIIHKKK HDJAPBFCPJM(ONKOLICEPIK BPCOJLPPMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA86E0", Offset = "0x3AA7AE0", VA = "0x183AA86E0", Slot = "6")]
	protected virtual void OFJKPFKMMDM<T>(ELHAPKDCOID HNNLPFDFOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x746A490", Offset = "0x7469890", VA = "0x18746A490")]
	public void IKJMMJKAMKC(ONKOLICEPIK BPCOJLPPMNI, object OGHIOOJNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8350", Offset = "0x3AA7750", VA = "0x183AA8350")]
	public void FIAMOLGPIJD<T>(ELHAPKDCOID HNNLPFDFOLO, T EOFGGNOHAMG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x746A510", Offset = "0x7469910", VA = "0x18746A510")]
	public void KHDFGCBDFBN(ONKOLICEPIK BPCOJLPPMNI, object OGHIOOJNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8560", Offset = "0x3AA7960", VA = "0x183AA8560")]
	public void NCLFCNENBEP<T>(Action<T> IFFOBKJAPGL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3AA83E0", Offset = "0x3AA77E0", VA = "0x183AA83E0")]
	public void NCLFCNENBEP<T, TUserData>(Action<T, TUserData> IFFOBKJAPGL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ILNPNLIGOME : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7475220", Offset = "0x7474620", VA = "0x187475220")]
	public ILNPNLIGOME(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EGCHFCCHGOG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7472FF0", Offset = "0x74723F0", VA = "0x187472FF0")]
	public EGCHFCCHGOG(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DAMMCACPBEB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum OHLNNEIDHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MIMMCNKJLIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public OHLNNEIDHHJ GBFFBDIJNIN;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x577EF40", Offset = "0x577E340", VA = "0x18577EF40", Slot = "4")]
		public virtual void IPJPKJAMFMN(MethodInfo CJHGEDCFDLG, MethodInfo CMDECDEICGM, OHLNNEIDHHJ IIHAKBEOLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IFJOAKPEMOD(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FELLFPIBJDD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		protected MIMMCNKJLIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class NOFPHOGGOLE<TClass, TProperty> : MIMMCNKJLIE<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> OFDNLAECPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> DCOPNJMJABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> HMNCEKIEPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> GFNMLOIPJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> NDJNLKFABGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> GBEIBCECCOM;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5842330", Offset = "0x5841730", VA = "0x185842330", Slot = "7")]
		public override void LAOJLCJAFIH(TClass CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5842950", Offset = "0x5841D50", VA = "0x185842950", Slot = "8")]
		public override void PFGKMPPOFLL(TClass CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x583D050", Offset = "0x583C450", VA = "0x18583D050", Slot = "9")]
		public override void IFJOAKPEMOD(TClass CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x583C1E0", Offset = "0x583B5E0", VA = "0x18583C1E0", Slot = "10")]
		public override void FELLFPIBJDD(TClass CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5841C20", Offset = "0x5841020", VA = "0x185841C20")]
		protected TProperty[] JDPEOMJMEGB(TClass CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x583C800", Offset = "0x583BC00", VA = "0x18583C800")]
		protected TProperty[] FIMLFHPCEBO(TClass CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5840B70", Offset = "0x583FF70", VA = "0x185840B70", Slot = "4")]
		public override void IPJPKJAMFMN(MethodInfo CJHGEDCFDLG, MethodInfo CMDECDEICGM, OHLNNEIDHHJ IIHAKBEOLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x58433D0", Offset = "0x58427D0", VA = "0x1858433D0")]
		protected NOFPHOGGOLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class KDEMAJOEPEC<TClass, TProperty> : NOFPHOGGOLE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void FBBHCMMMFPB(ONKOLICEPIK GDOMDKGJNLG, [Out] TProperty GIOFFEIGMHD);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OKMNLIFFEHM(ELHAPKDCOID DJODONHGGOL, TProperty GIOFFEIGMHD);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5434BC0", Offset = "0x5433FC0", VA = "0x185434BC0", Slot = "5")]
		public override void LJMMIIDCAAL(TClass CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5434990", Offset = "0x5433D90", VA = "0x185434990", Slot = "6")]
		public override void FIAMOLGPIJD(TClass CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5434AA0", Offset = "0x5433EA0", VA = "0x185434AA0", Slot = "7")]
		public override void LAOJLCJAFIH(TClass CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5434C40", Offset = "0x5434040", VA = "0x185434C40", Slot = "8")]
		public override void PFGKMPPOFLL(TClass CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B060", Offset = "0x4F5A460", VA = "0x184F5B060")]
		protected KDEMAJOEPEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class IGOBHIKGKEL<T> : NOFPHOGGOLE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x50D2270", Offset = "0x50D1670", VA = "0x1850D2270", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7E60", Offset = "0x4FE7260", VA = "0x184FE7E60", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x50D2210", Offset = "0x50D1610", VA = "0x1850D2210", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7F70", Offset = "0x4FE7370", VA = "0x184FE7F70", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public IGOBHIKGKEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HNHFEJAACIH<T> : NOFPHOGGOLE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7F10", Offset = "0x4FE7310", VA = "0x184FE7F10", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7E60", Offset = "0x4FE7260", VA = "0x184FE7E60", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7EB0", Offset = "0x4FE72B0", VA = "0x184FE7EB0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7F70", Offset = "0x4FE7370", VA = "0x184FE7F70", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public HNHFEJAACIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EGBINMCJEEH<T> : NOFPHOGGOLE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49D0990", Offset = "0x49CFD90", VA = "0x1849D0990", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x49D08E0", Offset = "0x49CFCE0", VA = "0x1849D08E0", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x49D0930", Offset = "0x49CFD30", VA = "0x1849D0930", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x49D09F0", Offset = "0x49CFDF0", VA = "0x1849D09F0", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public EGBINMCJEEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class IMDDEKNFHCL<T> : NOFPHOGGOLE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x50F0310", Offset = "0x50EF710", VA = "0x1850F0310", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x49D08E0", Offset = "0x49CFCE0", VA = "0x1849D08E0", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50F02B0", Offset = "0x50EF6B0", VA = "0x1850F02B0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x49D09F0", Offset = "0x49CFDF0", VA = "0x1849D09F0", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public IMDDEKNFHCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class JOKGBEGPLDN<T> : NOFPHOGGOLE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5384CE0", Offset = "0x53840E0", VA = "0x185384CE0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5384C30", Offset = "0x5384030", VA = "0x185384C30", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5384C80", Offset = "0x5384080", VA = "0x185384C80", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5384D40", Offset = "0x5384140", VA = "0x185384D40", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public JOKGBEGPLDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class KGKPDFPDMFC<T> : NOFPHOGGOLE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x544E300", Offset = "0x544D700", VA = "0x18544E300", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5384C30", Offset = "0x5384030", VA = "0x185384C30", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x544E2A0", Offset = "0x544D6A0", VA = "0x18544E2A0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5384D40", Offset = "0x5384140", VA = "0x185384D40", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public KGKPDFPDMFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class CIDHALCNFPC<T> : NOFPHOGGOLE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x45372B0", Offset = "0x45366B0", VA = "0x1845372B0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4537200", Offset = "0x4536600", VA = "0x184537200", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D76430", Offset = "0x6D75830", VA = "0x186D76430", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4537310", Offset = "0x4536710", VA = "0x184537310", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public CIDHALCNFPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DCIGLIIHGHH<T> : NOFPHOGGOLE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x45372B0", Offset = "0x45366B0", VA = "0x1845372B0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4537200", Offset = "0x4536600", VA = "0x184537200", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4537250", Offset = "0x4536650", VA = "0x184537250", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4537310", Offset = "0x4536710", VA = "0x184537310", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public DCIGLIIHGHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PPKIDNHKLDC<T> : NOFPHOGGOLE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A0D0", Offset = "0x5B394D0", VA = "0x185B3A0D0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A020", Offset = "0x5B39420", VA = "0x185B3A020", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A070", Offset = "0x5B39470", VA = "0x185B3A070", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FE7F70", Offset = "0x4FE7370", VA = "0x184FE7F70", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public PPKIDNHKLDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CKGIGLLABHJ<T> : NOFPHOGGOLE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D80210", Offset = "0x6D7F610", VA = "0x186D80210", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D80160", Offset = "0x6D7F560", VA = "0x186D80160", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D801B0", Offset = "0x6D7F5B0", VA = "0x186D801B0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5384D40", Offset = "0x5384140", VA = "0x185384D40", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public CKGIGLLABHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AMBAIMCFPHG<T> : NOFPHOGGOLE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x52BBF20", Offset = "0x52BB320", VA = "0x1852BBF20", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x52BBE70", Offset = "0x52BB270", VA = "0x1852BBE70", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x52BBEC0", Offset = "0x52BB2C0", VA = "0x1852BBEC0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4537310", Offset = "0x4536710", VA = "0x184537310", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x44EDC80", Offset = "0x44ED080", VA = "0x1844EDC80")]
		public AMBAIMCFPHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JPIMKPIODIC<T> : KDEMAJOEPEC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5389A80", Offset = "0x5388E80", VA = "0x185389A80", Slot = "12")]
		protected override void OKMNLIFFEHM(ELHAPKDCOID DJODONHGGOL, char GIOFFEIGMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5389A50", Offset = "0x5388E50", VA = "0x185389A50", Slot = "11")]
		protected override void FBBHCMMMFPB(ONKOLICEPIK GDOMDKGJNLG, [Out] char GIOFFEIGMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
		public JPIMKPIODIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JBFDDHINHIH<T> : KDEMAJOEPEC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x53032C0", Offset = "0x53026C0", VA = "0x1853032C0", Slot = "12")]
		protected override void OKMNLIFFEHM(ELHAPKDCOID DJODONHGGOL, IPEndPoint GIOFFEIGMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5303280", Offset = "0x5302680", VA = "0x185303280", Slot = "11")]
		protected override void FBBHCMMMFPB(ONKOLICEPIK GDOMDKGJNLG, [Out] IPEndPoint GIOFFEIGMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
		public JBFDDHINHIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class KFLFDPPALND<T> : NOFPHOGGOLE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int HLMALLJDAMN;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5447DA0", Offset = "0x54471A0", VA = "0x185447DA0")]
		public KFLFDPPALND(int LADMEHMLHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5447CD0", Offset = "0x54470D0", VA = "0x185447CD0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5447C00", Offset = "0x5447000", VA = "0x185447C00", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5447C60", Offset = "0x5447060", VA = "0x185447C60", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5447D40", Offset = "0x5447140", VA = "0x185447D40", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KANLAPFGCPG<T> : MIMMCNKJLIE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo DECDJGINCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type NBFFAIKCBBM;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5431820", Offset = "0x5430C20", VA = "0x185431820")]
		public KANLAPFGCPG(PropertyInfo NBOAFDFPIEI, Type BFNAOJPNIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5431700", Offset = "0x5430B00", VA = "0x185431700", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5431590", Offset = "0x5430990", VA = "0x185431590", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x54316A0", Offset = "0x5430AA0", VA = "0x1854316A0", Slot = "7")]
		public override void LAOJLCJAFIH(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x54317C0", Offset = "0x5430BC0", VA = "0x1854317C0", Slot = "8")]
		public override void PFGKMPPOFLL(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5431640", Offset = "0x5430A40", VA = "0x185431640", Slot = "9")]
		public override void IFJOAKPEMOD(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5431530", Offset = "0x5430930", VA = "0x185431530", Slot = "10")]
		public override void FELLFPIBJDD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class NDKAJGLKJBA<T> : KANLAPFGCPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1B60", Offset = "0x4EA0F60", VA = "0x184EA1B60")]
		public NDKAJGLKJBA(PropertyInfo NBOAFDFPIEI, Type BFNAOJPNIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x57EF8B0", Offset = "0x57EECB0", VA = "0x1857EF8B0", Slot = "5")]
		public override void LJMMIIDCAAL(T CMBPAHFCABG, ONKOLICEPIK GDOMDKGJNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x57EF800", Offset = "0x57EEC00", VA = "0x1857EF800", Slot = "6")]
		public override void FIAMOLGPIJD(T CMBPAHFCABG, ELHAPKDCOID DJODONHGGOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class LMFFDMLBGEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static LMFFDMLBGEC<T> NKAKNKMIPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly MIMMCNKJLIE<T>[] DCOPMOHJFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int JGAANILPIGN;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x551F9F0", Offset = "0x551EDF0", VA = "0x18551F9F0")]
		public LMFFDMLBGEC(List<MIMMCNKJLIE<T>> ELOPFIKBOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x551F890", Offset = "0x551EC90", VA = "0x18551F890")]
		public void FIAMOLGPIJD(T DEJGDIIDCDN, ELHAPKDCOID HNNLPFDFOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x551F940", Offset = "0x551ED40", VA = "0x18551F940")]
		public void LJMMIIDCAAL(T DEJGDIIDCDN, ONKOLICEPIK BPCOJLPPMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class ADANNAIKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract MIMMCNKJLIE<T> DIJAEKOIPED<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private ELHAPKDCOID GHMDCNHGAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int FEPEIBLCIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, ADANNAIKBAO> OIOFMKEKPAA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x746A6E0", Offset = "0x7469AE0", VA = "0x18746A6E0")]
	public DAMMCACPBEB(int OIBOBLFOAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3B04E20", Offset = "0x3B04220", VA = "0x183B04E20")]
	private LMFFDMLBGEC<T> OPKDADJJPDI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x31E7FF0", Offset = "0x31E73F0", VA = "0x1831E7FF0")]
	public void AAGBOPIEMBE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3B04DA0", Offset = "0x3B041A0", VA = "0x183B04DA0")]
	public bool DGFNGGGAAON<T>(ONKOLICEPIK BPCOJLPPMNI, T NJJNDJLGDNH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3B04D40", Offset = "0x3B04140", VA = "0x183B04D40")]
	public void COFPFOKABJF<T>(ELHAPKDCOID HNNLPFDFOLO, T DEJGDIIDCDN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IIEPOFAMCFL
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime LMPBKJDMANH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] HDPPPCEMLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HBBJFJJMCLM EPNPCCGDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7476700", Offset = "0x7475B00", VA = "0x187476700")]
		get
		{
			return default(HBBJFJJMCLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HMFLKKGPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x74766A0", Offset = "0x7475AA0", VA = "0x1874766A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7476FC0", Offset = "0x74763C0", VA = "0x187476FC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KMPAHAOMHCI JCKDHHDDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7477000", Offset = "0x7476400", VA = "0x187477000")]
		get
		{
			return default(KMPAHAOMHCI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7476760", Offset = "0x7475B60", VA = "0x187476760")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int ENALBPEFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x74766D0", Offset = "0x7475AD0", VA = "0x1874766D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint BPHHHFGGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7476C40", Offset = "0x7476040", VA = "0x187476C40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? CKAFAKPBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7476980", Offset = "0x7475D80", VA = "0x187476980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? KIDOPIHOBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7476CC0", Offset = "0x74760C0", VA = "0x187476CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? KPCACDDHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7476730", Offset = "0x7475B30", VA = "0x187476730")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7476300", Offset = "0x7475700", VA = "0x187476300")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? EBEHIILEDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2E0", Offset = "0xF1A6E0", VA = "0x180F1B2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x74772D0", Offset = "0x74766D0", VA = "0x1874772D0")]
	public IIEPOFAMCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x74775F0", Offset = "0x74769F0", VA = "0x1874775F0")]
	internal IIEPOFAMCFL(byte[] FGHKEPJEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x74767A0", Offset = "0x7475BA0", VA = "0x1874767A0")]
	public static IIEPOFAMCFL DFNJKFFNBDD(byte[] FGHKEPJEKFP, DateTime IIHKELPHNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7476A40", Offset = "0x7475E40", VA = "0x187476A40")]
	internal void IICJDMMGBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7477030", Offset = "0x7476430", VA = "0x187477030")]
	private void PBLIIDDDFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7476DC0", Offset = "0x74761C0", VA = "0x187476DC0")]
	private DateTime? MGBDEMDDCBO(int FDIDNNCIDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x74764D0", Offset = "0x74758D0", VA = "0x1874764D0")]
	private void AOANJKHFLAE(int FDIDNNCIDHK, DateTime? CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7476CF0", Offset = "0x74760F0", VA = "0x187476CF0")]
	private ulong JPLPLCDHKEL(int FDIDNNCIDHK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x74768C0", Offset = "0x7475CC0", VA = "0x1874768C0")]
	private void DLLHIONBFFG(int FDIDNNCIDHK, ulong CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74769B0", Offset = "0x7475DB0", VA = "0x1874769B0")]
	private uint GCILKJFLMCP(int FDIDNNCIDHK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7333A60", Offset = "0x7332E60", VA = "0x187333A60")]
	private static uint PFIGDGMCIFL(uint FNBJHADJBNG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7477210", Offset = "0x7476610", VA = "0x187477210")]
	private static ulong PFIGDGMCIFL(ulong FNBJHADJBNG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HBBJFJJMCLM
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
public enum KMPAHAOMHCI
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class LOBNKPDFNNP
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int NPGFLKLFOGN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int CMOHHDNKOBK = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int NKAKIJMBDPC = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint AJPGHAAEGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int FGMOJNGEBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int EBNKIEPHBON;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BHCBBJMJCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x747D4D0", Offset = "0x747C8D0", VA = "0x18747D4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x747D4E0", Offset = "0x747C8E0", VA = "0x18747D4E0")]
	public bool OFFKLMLFJJD(FINNEFHNFGG JKGDCCDNGMG, int GIKDKPMHFDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class KPBPAJPBBFP : FINNEFHNFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket JKGDCCDNGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly DIIGLGJHGPM EDEEMAKNLDH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short CCPHKFOCPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x747CD60", Offset = "0x747C160", VA = "0x18747CD60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JCJMNLAEJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x747CD00", Offset = "0x747C100", VA = "0x18747CD00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint LHCOCICCINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x747CD40", Offset = "0x747C140", VA = "0x18747CD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily IPBGPLKGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x54D62B0", Offset = "0x54D56B0", VA = "0x1854D62B0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x747D380", Offset = "0x747C780", VA = "0x18747D380")]
	public KPBPAJPBBFP(AddressFamily MGDDGHLGCBB, DIIGLGJHGPM EDEEMAKNLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x747CDC0", Offset = "0x747C1C0", VA = "0x18747CDC0", Slot = "8")]
	public bool PLEIJOGKIPN(IPEndPoint AICHGLEJCCE, OGDHFNNIIGJ DNDFJDHKHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x747CD80", Offset = "0x747C180", VA = "0x18747CD80", Slot = "9")]
	public int KDPFHINJAGO(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, int MPDDFCCPIOM, IPEndPoint BLBPEFEEMBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x747CC10", Offset = "0x747C010", VA = "0x18747CC10", Slot = "10")]
	public int GPGMKNEEJLH(byte[] JCGBEKOGKKD, EndPoint OBNEEDCEJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x747CD20", Offset = "0x747C120", VA = "0x18747CD20", Slot = "11")]
	public void IDEBDANELKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface FINNEFHNFGG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short CCPHKFOCPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int JCJMNLAEJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint LHCOCICCINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily IPBGPLKGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PLEIJOGKIPN(IPEndPoint AICHGLEJCCE, OGDHFNNIIGJ DNDFJDHKHEI);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KDPFHINJAGO(byte[] JCGBEKOGKKD, int FDIDNNCIDHK, int MPDDFCCPIOM, IPEndPoint BLBPEFEEMBP);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GPGMKNEEJLH(byte[] JCGBEKOGKKD, EndPoint BLBPEFEEMBP);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDEBDANELKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct DIOFOHJMLOE : IEquatable<DIOFOHJMLOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long DDFBKCCHCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long BCLFFIHKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long HNGDPMKGOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int NKPNBLPBOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int AHHOGGJHMHP;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x74728C0", Offset = "0x7471CC0", VA = "0x1874728C0")]
	public DIOFOHJMLOE(byte[] KKANHCDLFID, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7472980", Offset = "0x7471D80", VA = "0x187472980")]
	public DIOFOHJMLOE(Span<byte> KKANHCDLFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7472880", Offset = "0x7471C80", VA = "0x187472880", Slot = "4")]
	public bool Equals(DIOFOHJMLOE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x74727D0", Offset = "0x7471BD0", VA = "0x1874727D0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class KOJNMLONIMG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] HAJIDCOBKMB;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NFNKGACIAMG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void BGCHDHLGFFE(IPEndPoint KKANHCDLFID, Span<byte> NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string CHLCFHFFDKD = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int ABPECMNPKCN = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int NKEOJJOJIAH = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int BDNINLAKNEC = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<DIOFOHJMLOE, IPEndPoint> BPNJAGHHCJC;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static BGCHDHLGFFE OLKPCCDEOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int FPCCBIHHIKG;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	internal void EPMEGLJFGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	internal void DPBEHFJINLO(IPEndPoint BLBPEFEEMBP, Span<byte> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class JELIJAKONPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int HLIBBEEIONM;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
	protected JELIJAKONPH(int OJKHBANNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KCENPNDJNME(IPEndPoint AICHGLEJCCE, byte[] NGIAGNLBILI, int FDIDNNCIDHK, int COONBEDHJNN);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MNHIPOOFNIB(IPEndPoint AICHGLEJCCE, byte[] NGIAGNLBILI, int FDIDNNCIDHK, int COONBEDHJNN);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FMPKHIOEPEO : JELIJAKONPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] PEENICAIFOP;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator DEKJMGIAMIB;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2AA68D0", Offset = "0x2AA5CD0", VA = "0x182AA68D0")]
	public FMPKHIOEPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x74747E0", Offset = "0x7473BE0", VA = "0x1874747E0")]
	public void HNDBDLCNKIG(IPEndPoint AICHGLEJCCE, byte[] PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7474700", Offset = "0x7473B00", VA = "0x187474700")]
	public void GAAOGDAOGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7474990", Offset = "0x7473D90", VA = "0x187474990", Slot = "4")]
	public override void KCENPNDJNME(IPEndPoint AICHGLEJCCE, byte[] NGIAGNLBILI, int FDIDNNCIDHK, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7474E50", Offset = "0x7474250", VA = "0x187474E50", Slot = "5")]
	public override void MNHIPOOFNIB(IPEndPoint AICHGLEJCCE, byte[] NGIAGNLBILI, int FDIDNNCIDHK, int COONBEDHJNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct KNKMEHHNBCM
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void DNKJFNNLLOJ([NoAlias] byte* OJNIHIKBHCN, [NoAlias] byte* PEENICAIFOP, [NoAlias] byte* MBOANGPECML, int COONBEDHJNN);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class ALIAPOLILBD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr HPJFLJENJDL;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr AODMAGCCLDI;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x74815F0", Offset = "0x74809F0", VA = "0x1874815F0")]
		[BurstDiscard]
		private static void DIFBDHEDBIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7481720", Offset = "0x7480B20", VA = "0x187481720")]
		private static IntPtr EACHEBCOIGC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7481880", Offset = "0x7480C80", VA = "0x187481880")]
		public static void NIDJFIGBKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public static void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x74813B0", Offset = "0x74807B0", VA = "0x1874813B0")]
		public unsafe static void COEOEEINBLF([NoAlias] byte* OJNIHIKBHCN, [NoAlias] byte* PEENICAIFOP, [NoAlias] byte* MBOANGPECML, int COONBEDHJNN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint PEENICAIFOP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint MBOANGPECML[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint JPPEPKOPNMB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint IIGANJONPDE[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint CEOGEGBDLBD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint OBEOCFHGKCP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint FJAIOBILGDO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint NLNIKECGKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint OCIGECIELML[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x747C440", Offset = "0x747B840", VA = "0x18747C440")]
	private void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x747C410", Offset = "0x747B810", VA = "0x18747C410")]
	private uint CLFOJPMCOMI(uint EMOJJIEJAKM, int EMJFEBGJAHC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7469010", Offset = "0x7468410", VA = "0x187469010")]
	private void PFECCFFLPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7468D70", Offset = "0x7468170", VA = "0x187468D70")]
	private void HDBDLDPDGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7468F80", Offset = "0x7468380", VA = "0x187468F80")]
	private void OIECPEJJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7468C70", Offset = "0x7468070", VA = "0x187468C70")]
	private void CEINFFAANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x747C720", Offset = "0x747BB20", VA = "0x18747C720")]
	private void HDALAHNEAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x747C780", Offset = "0x747BB80", VA = "0x18747C780")]
	private unsafe void KPEPKFNCMOJ(byte* OJNIHIKBHCN, uint* PEENICAIFOP, uint* MBOANGPECML, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x747C5A0", Offset = "0x747B9A0", VA = "0x18747C5A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DOFPJDPIKCL([NoAlias] byte* OJNIHIKBHCN, [NoAlias] byte* PEENICAIFOP, [NoAlias] byte* MBOANGPECML, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x747C4C0", Offset = "0x747B8C0", VA = "0x18747C4C0")]
	public static void DOFPJDPIKCL(Span<byte> OJNIHIKBHCN, Span<byte> PEENICAIFOP, Span<byte> MBOANGPECML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x747C620", Offset = "0x747BA20", VA = "0x18747C620")]
	public static void GPONKGPPNMC(Span<byte> OJNIHIKBHCN, Span<byte> PEENICAIFOP, Span<byte> MBOANGPECML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x747CBA0", Offset = "0x747BFA0", VA = "0x18747CBA0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LPKEEBOPIHC([NoAlias] byte* OJNIHIKBHCN, [NoAlias] byte* PEENICAIFOP, [NoAlias] byte* MBOANGPECML, int COONBEDHJNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7481A30", Offset = "0x7480E30", VA = "0x187481A30")]
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
