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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, FLKMGHOIJKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum LKDEHGIPJMF
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
		private NetworkManager KCNFDFMBIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool FJMPFHAIFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, COPDBAFMNDG> ACOHFAFEIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FAANBDMGAOE ODMFMHBMPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch JAKNFIEIKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] CKHIGFIEGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LKDEHGIPJMF HKBLLNPAMFO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int MKMNPIONIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76AA790", Offset = "0x76A8D90", VA = "0x1876AA790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong LPCOLODKGBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool KJCOEAMBIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x76AA770", Offset = "0x76A8D70", VA = "0x1876AA770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76A9D60", Offset = "0x76A8360", VA = "0x1876A9D60")]
		public void RecRoom_SetEncryptionInfo(ulong ELOMICEJECG, byte[] HAELBKGFDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76A9D40", Offset = "0x76A8340", VA = "0x1876A9D40")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76A9C10", Offset = "0x76A8210", VA = "0x1876A9C10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76AA670", Offset = "0x76A8C70", VA = "0x1876AA670")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76A9E80", Offset = "0x76A8480", VA = "0x1876A9E80", Slot = "6")]
		public override void Send(ulong NCJELIFCHMF, ArraySegment<byte> CDDIADBJAOB, NetworkDelivery GGMODFBCKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76A9D00", Offset = "0x76A8300", VA = "0x1876A9D00", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong NCJELIFCHMF, [Out] ArraySegment<byte> JFAOAIPNPMB, [Out] float LBEJBCDEPKK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76AA170", Offset = "0x76A8770", VA = "0x1876AA170", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76AA490", Offset = "0x76A8A90", VA = "0x1876AA490", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76A9570", Offset = "0x76A7B70", VA = "0x1876A9570", Slot = "11")]
		public override void DisconnectRemoteClient(ulong NCJELIFCHMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76A9480", Offset = "0x76A7A80", VA = "0x1876A9480", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76A9810", Offset = "0x76A7E10", VA = "0x1876A9810", Slot = "13")]
		public override ulong GetCurrentRtt(ulong NCJELIFCHMF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76AA100", Offset = "0x76A8700", VA = "0x1876AA100", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76A98B0", Offset = "0x76A7EB0", VA = "0x1876A98B0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager KCNFDFMBIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76A9680", Offset = "0x76A7C80", VA = "0x1876A9680")]
		private HGNPKCIIDKI ECJCEDIEKDP(NetworkDelivery GPEIAHGICNA)
		{
			return default(HGNPKCIIDKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76A9750", Offset = "0x76A7D50", VA = "0x1876A9750", Slot = "16")]
		private void GBOLFKEKLLI(COPDBAFMNDG JFKKNFAPEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76A9B40", Offset = "0x76A8140", VA = "0x1876A9B40", Slot = "17")]
		private void OADMOFMPKDA(COPDBAFMNDG JFKKNFAPEJA, ANEEAFJMKMG HHAFMNOCBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "18")]
		private void DOGHHLNCKMB(IPEndPoint KDLIEGAJHCH, SocketError DIEEELDMMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76A9270", Offset = "0x76A7870", VA = "0x1876A9270", Slot = "19")]
		private void CDBFMLAIJJA(COPDBAFMNDG JFKKNFAPEJA, LCHIFGIMJGL KLIAOPJFDOK, byte CBEMAPNODAM, HGNPKCIIDKI OACKPIGJEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76A9170", Offset = "0x76A7770", VA = "0x1876A9170")]
		private void AJPHDKCDHJA(int KCJLCGFEBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "20")]
		private void EKDHJLCNHBL(IPEndPoint COJCMFPOMJH, LCHIFGIMJGL KLIAOPJFDOK, FKEGHHLMCIP MFJHLNGCAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
		private void PCPDPHMPAJK(COPDBAFMNDG JFKKNFAPEJA, int LAJPNCFCBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76A9110", Offset = "0x76A7710", VA = "0x1876A9110", Slot = "22")]
		private void AINCNOIJCDA(LHFJBKJEAML KOKMGKHMMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76A9AE0", Offset = "0x76A80E0", VA = "0x1876A9AE0")]
		private ulong JEPPIPIBKNJ(COPDBAFMNDG JFKKNFAPEJA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76A9AC0", Offset = "0x76A80C0", VA = "0x1876A9AC0")]
		private ulong JEPPIPIBKNJ(ulong NCJELIFCHMF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76A9250", Offset = "0x76A7850", VA = "0x1876A9250")]
		private static int BJADOIKILJD(float OEDPOHDPEIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76AA690", Offset = "0x76A8C90", VA = "0x1876AA690")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76A9B10", Offset = "0x76A8110", VA = "0x1876A9B10")]
		[CompilerGenerated]
		private void KKJKAPNEMPN(ulong EJGGEOLBHED, int CNPPIADJIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76A9B10", Offset = "0x76A8110", VA = "0x1876A9B10")]
		[CompilerGenerated]
		private void LEPBPPPAENC(ulong EJGGEOLBHED, int CNPPIADJIIE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class CNALIECIBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly COPDBAFMNDG DHBOKIIMNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<JKIHAHACKII> AHHLHFHNGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int IMOHHKLGILO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DHPDEPHMFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76952A0", Offset = "0x76938A0", VA = "0x1876952A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76953D0", Offset = "0x76939D0", VA = "0x1876953D0")]
	protected CNALIECIBJE(COPDBAFMNDG JFKKNFAPEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7695370", Offset = "0x7693970", VA = "0x187695370")]
	public void ICMHOPOMGAD(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76952F0", Offset = "0x76938F0", VA = "0x1876952F0")]
	protected void EPAFKKCIBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7695260", Offset = "0x7693860", VA = "0x187695260")]
	public bool AGCBELCACDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MPLGPIKHLLM();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HMDHLJEPMHL(JKIHAHACKII EABADIPHAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum NHAHHNKDAAE
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
public class LHFJBKJEAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FAANBDMGAOE KGAPLONHDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int NEJMPDEBNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal AOEMOODKFPL FKABLAGMLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint AGLLFHHGHKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal NHAHHNKDAAE KPNDEMDNCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
		[CompilerGenerated]
		get
		{
			return default(NHAHHNKDAAE);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEF9A80", Offset = "0xEF8080", VA = "0x180EF9A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76A5D20", Offset = "0x76A4320", VA = "0x1876A5D20")]
	internal void GEAMJNCEOIH(AOEMOODKFPL HIIEJIGCPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76A5CF0", Offset = "0x76A42F0", VA = "0x1876A5CF0")]
	private bool BOOANGPAOHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76A5DE0", Offset = "0x76A43E0", VA = "0x1876A5DE0")]
	internal LHFJBKJEAML(IPEndPoint COJCMFPOMJH, AOEMOODKFPL BFFNLIECMBG, FAANBDMGAOE BOGGDLFCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76A5D80", Offset = "0x76A4380", VA = "0x1876A5D80")]
	public COPDBAFMNDG HCAKAGMGBPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FKEGHHLMCIP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum EIMJBEPECGK
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
public struct ANEEAFJMKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public EIMJBEPECGK ALMLPEDEKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError ONNBDDNJIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LCHIFGIMJGL PDLHEDKHKBG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FLKMGHOIJKB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCCMJIFEOCF(COPDBAFMNDG JFKKNFAPEJA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEMKGKHDIOE(COPDBAFMNDG JFKKNFAPEJA, ANEEAFJMKMG HHAFMNOCBGF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKEKHGAIGGE(IPEndPoint KDLIEGAJHCH, SocketError DIEEELDMMKH);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKKGALDEAGE(COPDBAFMNDG JFKKNFAPEJA, LCHIFGIMJGL KLIAOPJFDOK, byte CBEMAPNODAM, HGNPKCIIDKI OACKPIGJEEH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLDOMAKLCKG(IPEndPoint COJCMFPOMJH, LCHIFGIMJGL KLIAOPJFDOK, FKEGHHLMCIP MFJHLNGCAFN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJCCDPNDCEF(COPDBAFMNDG JFKKNFAPEJA, int LAJPNCFCBKM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHODLBLEBOJ(LHFJBKJEAML KOKMGKHMMEE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EKDEEBFADCN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOENHAHFDGM(COPDBAFMNDG JFKKNFAPEJA, object IGBHFHKMLJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MFMPDMNOGHF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGCCLKLCJHL(LKGJCANLNCK EABADIPHAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LJMCLMCGDFL
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKHBPLOIPCI(COPDBAFMNDG JFKKNFAPEJA, IPEndPoint AALILCPNJNN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class AOEMOODKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int LEMOIEEJCNB = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long OCDPDJGDKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte IMKBGBBBCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] PKEBJPEHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly BPJEGEDPHKP BJOBNNFAMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int HONEOAEIBHP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7693CF0", Offset = "0x76922F0", VA = "0x187693CF0")]
	private AOEMOODKFPL(long MJKPKGDKKKI, byte ABHANOPIJOJ, int BJCKBJFHLNJ, byte[] ELACAKGLOKI, BPJEGEDPHKP CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7693890", Offset = "0x7691E90", VA = "0x187693890")]
	public static int CGCBLMLELBM(JKIHAHACKII EABADIPHAGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7693AD0", Offset = "0x76920D0", VA = "0x187693AD0")]
	public static AOEMOODKFPL PGBJFBDLFNK(JKIHAHACKII EABADIPHAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76938F0", Offset = "0x7691EF0", VA = "0x1876938F0")]
	public static JKIHAHACKII KEGFJNPAEOG(LNFIIKFFJAM IKGJEPBOAPH, SocketAddress ONDKJCMAPED, long GODLDJGAFMD, int BJCKBJFHLNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class ECDEJILFLAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long OCDPDJGDKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte IMKBGBBBCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int HONEOAEIBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool JDJDOLOJDGE;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x769ABB0", Offset = "0x76991B0", VA = "0x18769ABB0")]
	private ECDEJILFLAC(long MJKPKGDKKKI, byte ABHANOPIJOJ, int IEALEDEJKCA, bool KPKKOMCGMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x769AA60", Offset = "0x7699060", VA = "0x18769AA60")]
	public static ECDEJILFLAC PGBJFBDLFNK(JKIHAHACKII EABADIPHAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x769A870", Offset = "0x7698E70", VA = "0x18769A870")]
	public static JKIHAHACKII KEGFJNPAEOG(long GODLDJGAFMD, byte IOOBIHKBJKN, int DPKEAFHHOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x769A960", Offset = "0x7698F60", VA = "0x18769A960")]
	public static JKIHAHACKII LPEMCLLDMEO(COPDBAFMNDG JFKKNFAPEJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum GMOBPGFJJKI
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FACOCDEPFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGJIHIEGCA(IPEndPoint EPNCLMFDOIM, IPEndPoint COJCMFPOMJH, string INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAKJDIFLGKG(IPEndPoint JINJIPHODAJ, GMOBPGFJJKI GPEIAHGICNA, string INEEADCBMPK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GHKNENBGFGF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LPELBHDAEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint OFBEMFPJOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint AGLLFHHGHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string FMBEFCNGHJG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct LNGJKAECPGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint GKOGFONLGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GMOBPGFJJKI HIKNDMJOAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string FMBEFCNGHJG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class CHMKENJKDMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint AGHKJMFMHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string FMBEFCNGHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CHMKENJKDMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HJJACKFOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint AGHKJMFMHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint BCONPACKAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string FMBEFCNGHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HJJACKFOKJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HAKBCGBJPMF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string FMBEFCNGHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NHNGFIEIELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HAKBCGBJPMF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FAANBDMGAOE MLIFAPEJLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<LPELBHDAEFC> DHNNONDMHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<LNGJKAECPGP> MCLOOKBPDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly BPJEGEDPHKP DEEMAHFJPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly LNFIIKFFJAM FEKBOBEEBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EEIBFKOHJDN ONKEHDBOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private FACOCDEPFLB KGJINKENIAK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int BDAMADILGAH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool JEILLJLNKHM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76A3EB0", Offset = "0x76A24B0", VA = "0x1876A3EB0")]
	internal GHKNENBGFGF(FAANBDMGAOE HALFOOJPGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76A3B90", Offset = "0x76A2190", VA = "0x1876A3B90")]
	internal void LBACHBDDOBD(IPEndPoint COACBPJHCBP, JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC010", Offset = "0x3DDA610", VA = "0x183DDC010")]
	private void JOIKNHFPCOF<T>(T EABADIPHAGE, IPEndPoint AMMKGILEHBG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76A38A0", Offset = "0x76A1EA0", VA = "0x1876A38A0")]
	private void EKGJIHIEGCA(CHMKENJKDMA IELKACLLKFA, IPEndPoint COACBPJHCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76A3A30", Offset = "0x76A2030", VA = "0x1876A3A30")]
	private void FIJEJBDNLAC(HJJACKFOKJP IELKACLLKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76A3D10", Offset = "0x76A2310", VA = "0x1876A3D10")]
	private void MENNGKHNMNJ(HAKBCGBJPMF IELKACLLKFA, IPEndPoint COACBPJHCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HGNPKCIIDKI : byte
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
public enum MLLKKOCIFMP : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NOKBMFAGJKL
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] OLKCGDMGDOK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int CKFJEMIIAGN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int EGLGJJEFJDK;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IKDAHBJOOHN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x76949D0", Offset = "0x7692FD0", VA = "0x1876949D0")]
	public IKDAHBJOOHN(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNOJNPECMEC : IKDAHBJOOHN
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x76949D0", Offset = "0x7692FD0", VA = "0x1876949D0")]
	public KNOJNPECMEC(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GIAJLIOILPD
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
public interface CGECNCAFLDN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHAOCJEICJJ(GIAJLIOILPD MPMOCCNHIAL, string DPCMOBNBPGE, params object[] PNGANGECEEL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KAAEDFDLGAO
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static CGECNCAFLDN PDLNLBKNECD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object LBMOOBBDAMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76A57D0", Offset = "0x76A3DD0", VA = "0x1876A57D0")]
	private static void NLDEIACOMOF(GIAJLIOILPD BHGGMJMAIKE, string DPCMOBNBPGE, params object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76A5770", Offset = "0x76A3D70", VA = "0x1876A5770")]
	internal static void LJJFMFANJGK(string DPCMOBNBPGE, params object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76A5710", Offset = "0x76A3D10", VA = "0x1876A5710")]
	internal static void HNNMCKMJJMA(string DPCMOBNBPGE, params object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76A5A00", Offset = "0x76A4000", VA = "0x1876A5A00")]
	internal static void OBBKJPOODFE(string DPCMOBNBPGE, params object[] PNGANGECEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum LOFBOENKDCN
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LCHIFGIMJGL : BPJEGEDPHKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private JKIHAHACKII JAGFMEFELJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly FAANBDMGAOE FABEMAFLPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly PPOPONFOCKH NJLGDDHLJJH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76A5CA0", Offset = "0x76A42A0", VA = "0x1876A5CA0")]
	internal LCHIFGIMJGL(FAANBDMGAOE IHEHADIIJNO, PPOPONFOCKH AHMCHECBFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76A5C00", Offset = "0x76A4200", VA = "0x1876A5C00")]
	internal void MODJDBJJPOE(JKIHAHACKII EABADIPHAGE, int BDMENFNNBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x76A5B80", Offset = "0x76A4180", VA = "0x1876A5B80")]
	internal void MKEEMAOADGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76A5C70", Offset = "0x76A4270", VA = "0x1876A5C70")]
	public void OKELGKNAHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class PPOPONFOCKH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum BLGFDGKNDGL
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
	public PPOPONFOCKH ELAEOJCGHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public BLGFDGKNDGL HIKNDMJOAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public COPDBAFMNDG DHBOKIIMNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint AGLLFHHGHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object HAAFAKKFDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int DNFJFOAHFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError HPHGKJJLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EIMJBEPECGK NFIGNEEFJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public LHFJBKJEAML NLDKPIDNPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public HGNPKCIIDKI JKOHBKAOBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte ICEJGKCJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly LCHIFGIMJGL OALNJCEEBHI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x76AB8F0", Offset = "0x76A9EF0", VA = "0x1876AB8F0")]
	public PPOPONFOCKH(FAANBDMGAOE IHEHADIIJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FAANBDMGAOE : IEnumerable<COPDBAFMNDG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class LALIHIDKMKK : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x76A5B10", Offset = "0x76A4110", VA = "0x1876A5B10", Slot = "4")]
		public bool Equals(IPEndPoint GBNAKFLHCOE, IPEndPoint ODEKEFJCIIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4689190", Offset = "0x4687790", VA = "0x184689190", Slot = "5")]
		public int GetHashCode(IPEndPoint MPIDDJPOOMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LALIHIDKMKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct EKFLBNKFDAI : IEnumerator<COPDBAFMNDG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly COPDBAFMNDG DPAHNGBLGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private COPDBAFMNDG MDJJNACIHFA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public COPDBAFMNDG MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB562D0", Offset = "0xB548D0", VA = "0x180B562D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB562D0", Offset = "0xB548D0", VA = "0x180B562D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D41C80", Offset = "0x1D40280", VA = "0x181D41C80")]
		public EKFLBNKFDAI(COPDBAFMNDG OKHLJECLMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x769AF80", Offset = "0x7699580", VA = "0x18769AF80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x769AFD0", Offset = "0x76995D0", VA = "0x18769AFD0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread LIAPLLDJENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool KJODOCBJEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool NGGNODPJOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BHKIEIBLLNJ MFGFDNKLHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent DIHNHPLHFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<PPOPONFOCKH> HEBHPAOEPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<PPOPONFOCKH> HAHMINCKOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private PPOPONFOCKH EBIHGBFFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FLKMGHOIJKB CJIAPPAHIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EKDEEBFADCN FOJCDDMLEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MFMPDMNOGHF KNJLAKCIMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly LJMCLMCGDFL FONLLHPBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, COPDBAFMNDG> NMJFMMIDACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, LHFJBKJEAML> DPBNEGHIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, OINMHEOKEIH> ADOECNHDAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim AENNKDCCECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private COPDBAFMNDG ENGEEFGALLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int MPLHHKPHPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<COPDBAFMNDG> LIJMIBNNHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private COPDBAFMNDG[] ONNJLNLCDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly CEFHDEKOHOL AOJMCINMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int MDAMOHAFIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> NDFFDMODGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte NPKAJHPAJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object GKNBHIMMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FLJEAPFJKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool IKGGFIFENPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int JHCHNDMIMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int HIODEKALNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int DNADGMMIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int OHINAIIICGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool EJLEICJIBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool NKHNALBECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JJIPBANEIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int KBKCFIPNNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int IPAFDFELDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool JEILLJLNKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool DALKMNGJGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool JEFNHNOGJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool AGIGMNGIHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int FJFFJOMECPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int ABCJOMFDGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool FCIMKNALFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly DKMCNDIFPEJ PJHHMHKIICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KOKKHMEMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly GHKNENBGFGF OELBNIAFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool OJHJMLEEKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public LOFBOENKDCN LBFBLBOALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int KONHEFFDNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool EKHBFCOLOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool PPEKKBEGCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool FLLNNDMKHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool HFEBFIBFKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JKIHAHACKII OGCEDAKLOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int JCJFHLHEDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object AJMJJFCCBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private JKIHAHACKII IIICCIIMBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int IBJJFHBIMFP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int AGGHNPJNLPI = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int ENIDFKHGBIB = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private GLOEEIFMNNH GNFJGCODLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private GLOEEIFMNNH FGHDBNEGGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread EPOKLHKBNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread BDGIIFGDCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint KMBMCNGMNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint IOONPJOAOMB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] JGBNKBOKIFF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] EGDJKGIMAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<JBELONJGPCK, IPEndPoint> EPNACKDOGNF;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress OBCDCOIBDKG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool INFLCCHHBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int IHIMOOPANCF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GLELAOKEOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xC21F40", Offset = "0xC20540", VA = "0x180C21F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC225F0", Offset = "0xC20BF0", VA = "0x180C225F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FLAEFOOBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x187D9C0", Offset = "0x187BFC0", VA = "0x18187D9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x22F8FF0", Offset = "0x22F75F0", VA = "0x1822F8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte DHHPDKCFLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10E1D40", Offset = "0x10E0340", VA = "0x1810E1D40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EJJMPAMBHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x769DB60", Offset = "0x769C160", VA = "0x18769DB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short FMNBOHNEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x769CC20", Offset = "0x769B220", VA = "0x18769CC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event COPDBAFMNDG.EHBBAFKDEIA MIMCJELOADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x769B060", Offset = "0x7699660", VA = "0x18769B060")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x769B5C0", Offset = "0x7699BC0", VA = "0x18769B5C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x769FE40", Offset = "0x769E440", VA = "0x18769FE40")]
	public void KMHADHJKBAK(IPEndPoint KDLIEGAJHCH, byte[] HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x769B670", Offset = "0x7699C70", VA = "0x18769B670")]
	public void BEGMOKJPHDB(IPEndPoint KDLIEGAJHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76A00C0", Offset = "0x769E6C0", VA = "0x1876A00C0")]
	private bool LBMEHMGKHFG(IPEndPoint KDLIEGAJHCH, [Out] COPDBAFMNDG JFKKNFAPEJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x769E2C0", Offset = "0x769C8C0", VA = "0x18769E2C0")]
	private void JHAPDKAFGEF(COPDBAFMNDG JFKKNFAPEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x769C400", Offset = "0x769AA00", VA = "0x18769C400")]
	private void CFBDBLGBCHL(COPDBAFMNDG JFKKNFAPEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x769E600", Offset = "0x769CC00", VA = "0x18769E600")]
	private void JLJPPLEPIED(COPDBAFMNDG JFKKNFAPEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76A29E0", Offset = "0x76A0FE0", VA = "0x1876A29E0")]
	public FAANBDMGAOE(FLKMGHOIJKB BOGGDLFCPCM, [Optional] CEFHDEKOHOL FGFCIFJIEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x769CCE0", Offset = "0x769B2E0", VA = "0x18769CCE0")]
	internal void FCAOHDBPKCF(COPDBAFMNDG PJCHMDEBFEB, int LAJPNCFCBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x769C3B0", Offset = "0x769A9B0", VA = "0x18769C3B0")]
	internal void CDMGJOHAAJA(COPDBAFMNDG PJCHMDEBFEB, object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x769B020", Offset = "0x7699620", VA = "0x18769B020")]
	internal void AFAINIKCDCK(COPDBAFMNDG JFKKNFAPEJA, EIMJBEPECGK LEILDDGFOJJ, SocketError IDEHKKHLCJP, JKIHAHACKII CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x769D370", Offset = "0x769B970", VA = "0x18769D370")]
	private void HEHMIFHDCPL(COPDBAFMNDG JFKKNFAPEJA, EIMJBEPECGK LEILDDGFOJJ, SocketError IDEHKKHLCJP, bool AKKFOJDOENB, byte[] CDDIADBJAOB, int GHOFJOJMCOI, int LMJBLNOIBOL, JKIHAHACKII CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76A0B70", Offset = "0x769F170", VA = "0x1876A0B70")]
	private void MPEPJKMLGPA(PPOPONFOCKH.BLGFDGKNDGL GPEIAHGICNA, [Optional] COPDBAFMNDG JFKKNFAPEJA, [Optional] IPEndPoint COJCMFPOMJH, SocketError AKOJIFEHEJB = SocketError.Success, int LAJPNCFCBKM = 0, EIMJBEPECGK PBMFDDLEJPK = EIMJBEPECGK.ConnectionFailed, [Optional] LHFJBKJEAML JOLCHKMBAIN, HGNPKCIIDKI OACKPIGJEEH = HGNPKCIIDKI.Unreliable, byte CBEMAPNODAM = 0, [Optional] JKIHAHACKII ANMJOIGNEME, [Optional] object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x769C460", Offset = "0x769AA60", VA = "0x18769C460")]
	private void COIAJJFGGGH(PPOPONFOCKH AHMCHECBFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x769E1B0", Offset = "0x769C7B0", VA = "0x18769E1B0")]
	internal void JBADGMEGLNH(PPOPONFOCKH AHMCHECBFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76A0F50", Offset = "0x769F550", VA = "0x1876A0F50")]
	private void NHCDGIOIGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76A1AB0", Offset = "0x76A00B0", VA = "0x1876A1AB0")]
	private void PGGEGJNJMOB(int NFFPFHPPFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76A0160", Offset = "0x769E760", VA = "0x1876A0160")]
	internal COPDBAFMNDG LCENBHFCECH(LHFJBKJEAML KOKMGKHMMEE, byte[] BJKMGOPLOHC, int GHOFJOJMCOI, int NODGHDHCBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x76A0780", Offset = "0x769ED80", VA = "0x1876A0780")]
	private int LPCEINGMIFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x769DD00", Offset = "0x769C300", VA = "0x18769DD00")]
	private void JAGLCHMCGMD(IPEndPoint COJCMFPOMJH, COPDBAFMNDG KHHMKEPMDKL, AOEMOODKFPL CPEFBJCADDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x769EA70", Offset = "0x769D070", VA = "0x18769EA70")]
	private void KCLFMKDNFMP(JKIHAHACKII EABADIPHAGE, IPEndPoint COJCMFPOMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x769B2E0", Offset = "0x76998E0", VA = "0x18769B2E0")]
	internal void AOGKGJLEONJ(JKIHAHACKII EABADIPHAGE, HGNPKCIIDKI HEPPOGGJMKL, byte CBEMAPNODAM, int BDMENFNNBLF, COPDBAFMNDG PJCHMDEBFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76A2000", Offset = "0x76A0600", VA = "0x1876A2000")]
	public bool PLMAAMEONBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76A2010", Offset = "0x76A0610", VA = "0x1876A2010")]
	public bool PLMAAMEONBL(IPAddress IKLHMCGCLBP, IPAddress BDEHNPFJMOG, int GCNAAGHBADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76A1F80", Offset = "0x76A0580", VA = "0x1876A1F80")]
	public bool PLMAAMEONBL(int GCNAAGHBADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x769D000", Offset = "0x769B600", VA = "0x18769D000")]
	public void GJHOOFOCBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76A1680", Offset = "0x769FC80", VA = "0x1876A1680")]
	public COPDBAFMNDG NOEFOBHBBMA(string KBIGEJLMJNE, int GCNAAGHBADN, string HAELBKGFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76A1760", Offset = "0x769FD60", VA = "0x1876A1760")]
	public COPDBAFMNDG NOEFOBHBBMA(string KBIGEJLMJNE, int GCNAAGHBADN, LNFIIKFFJAM OEOPFCDGNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76A12A0", Offset = "0x769F8A0", VA = "0x1876A12A0")]
	public COPDBAFMNDG NOEFOBHBBMA(IPEndPoint AMMKGILEHBG, LNFIIKFFJAM OEOPFCDGNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76A0800", Offset = "0x769EE00", VA = "0x1876A0800")]
	public void MBDDDNAIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76A0810", Offset = "0x769EE10", VA = "0x1876A0810")]
	public void MBDDDNAIIMI(bool DBLMNKDPPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x769D1B0", Offset = "0x769B7B0", VA = "0x18769D1B0")]
	public void HAOHKOJOFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x769D260", Offset = "0x769B860", VA = "0x18769D260")]
	public void HAOHKOJOFJE(byte[] CDDIADBJAOB, int GHOFJOJMCOI, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x769D330", Offset = "0x769B930", VA = "0x18769D330")]
	public void HEHMIFHDCPL(COPDBAFMNDG JFKKNFAPEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x769D780", Offset = "0x769BD80", VA = "0x18769D780")]
	public void HEHMIFHDCPL(COPDBAFMNDG JFKKNFAPEJA, byte[] CDDIADBJAOB, int GHOFJOJMCOI, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76A2800", Offset = "0x76A0E00", VA = "0x1876A2800", Slot = "4")]
	private IEnumerator<COPDBAFMNDG> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76A2890", Offset = "0x76A0E90", VA = "0x1876A2890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x769B110", Offset = "0x7699710", VA = "0x18769B110")]
	private JKIHAHACKII AJPDPBBCECO(NDHBGNDOINO GBIEIIJCCOO, int KCJLCGFEBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x769B200", Offset = "0x7699800", VA = "0x18769B200")]
	private JKIHAHACKII AJPDPBBCECO(NDHBGNDOINO GBIEIIJCCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x769C160", Offset = "0x769A760", VA = "0x18769C160")]
	internal JKIHAHACKII CBFKDKLGOCH(int KCJLCGFEBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76A1840", Offset = "0x769FE40", VA = "0x1876A1840")]
	internal void OMFEKHDBILF(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76A2920", Offset = "0x76A0F20", VA = "0x1876A2920")]
	static FAANBDMGAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xC21F40", Offset = "0xC20540", VA = "0x180C21F40")]
	private bool DIBGFNJPLKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x769BFE0", Offset = "0x769A5E0", VA = "0x18769BFE0")]
	private void BHPAFBEIBDH(IPEndPoint MNLHBGJCKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x769E900", Offset = "0x769CF00", VA = "0x18769E900")]
	private void KCAHBKCMBBA(IPEndPoint MNLHBGJCKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x76A1DD0", Offset = "0x76A03D0", VA = "0x1876A1DD0")]
	private bool PINFOALPEDH(SocketException BGIFIJLJEDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x769E8E0", Offset = "0x769CEE0", VA = "0x18769E8E0")]
	private void JONNIEBGMLH(BHKIEIBLLNJ HALFOOJPGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x769CD30", Offset = "0x769B330", VA = "0x18769CD30")]
	private void FIMBCJEKNBI(GLOEEIFMNNH HALFOOJPGDJ, EndPoint EPKBNNFEKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x769D7C0", Offset = "0x769BDC0", VA = "0x18769D7C0")]
	private void HGKPIEOFIKF(object HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76A2030", Offset = "0x76A0630", VA = "0x1876A2030")]
	public bool PLMAAMEONBL(IPAddress IKLHMCGCLBP, IPAddress BDEHNPFJMOG, int GCNAAGHBADN, bool PFHNEHKAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76A0060", Offset = "0x769E660", VA = "0x1876A0060")]
	internal int KNLADPCMPGF(JKIHAHACKII EABADIPHAGE, IPEndPoint COJCMFPOMJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x769B7C0", Offset = "0x7699DC0", VA = "0x18769B7C0")]
	internal int BELDIEPEPCL(JKIHAHACKII EABADIPHAGE, IPEndPoint COJCMFPOMJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x769B800", Offset = "0x7699E00", VA = "0x18769B800")]
	internal int BELDIEPEPCL(byte[] GKNICJPCIJJ, int GHOFJOJMCOI, int NODGHDHCBPE, IPEndPoint COJCMFPOMJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x769DB80", Offset = "0x769C180", VA = "0x18769DB80")]
	internal void IAFEODFKKOA(bool DFPMIMKFGNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum NDHBGNDOINO : byte
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
internal sealed class JKIHAHACKII
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int GBCJLMMOMJA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] AEHDOEBPKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] APBNEADAOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int FMLOJENFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object HAAFAKKFDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public JKIHAHACKII ELAEOJCGHPG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NDHBGNDOINO CLBHDAJPKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76A50E0", Offset = "0x76A36E0", VA = "0x1876A50E0")]
		get
		{
			return default(NDHBGNDOINO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76A4EC0", Offset = "0x76A34C0", VA = "0x1876A4EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte IMKBGBBBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76A50B0", Offset = "0x76A36B0", VA = "0x1876A50B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x76A4F40", Offset = "0x76A3540", VA = "0x1876A4F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort AMNNHFIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x76A5210", Offset = "0x76A3810", VA = "0x1876A5210")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76A4E50", Offset = "0x76A3450", VA = "0x1876A4E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PMONCHBCIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76A4D90", Offset = "0x76A3390", VA = "0x1876A4D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte LONOODDDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x76A4E90", Offset = "0x76A3490", VA = "0x1876A4E90")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76A4FE0", Offset = "0x76A35E0", VA = "0x1876A4FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort FKAKDANEBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76A4F80", Offset = "0x76A3580", VA = "0x1876A4F80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76A5270", Offset = "0x76A3870", VA = "0x1876A5270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort MOLDLKKNCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x76A5010", Offset = "0x76A3610", VA = "0x1876A5010")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76A5070", Offset = "0x76A3670", VA = "0x1876A5070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort KGLHEFMKOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x76A4DC0", Offset = "0x76A33C0", VA = "0x1876A4DC0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76A4F00", Offset = "0x76A3500", VA = "0x1876A4F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76A52B0", Offset = "0x76A38B0", VA = "0x1876A52B0")]
	static JKIHAHACKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76A4E20", Offset = "0x76A3420", VA = "0x1876A4E20")]
	public void EJLFBGKHHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76A56A0", Offset = "0x76A3CA0", VA = "0x1876A56A0")]
	public JKIHAHACKII(int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76A5590", Offset = "0x76A3B90", VA = "0x1876A5590")]
	public JKIHAHACKII(NDHBGNDOINO GBIEIIJCCOO, int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76A4D20", Offset = "0x76A3320", VA = "0x1876A4D20")]
	public static int ABEPFALPDDN(NDHBGNDOINO GBIEIIJCCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x76A4C90", Offset = "0x76A3290", VA = "0x1876A4C90")]
	public int ABEPFALPDDN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76A5110", Offset = "0x76A3710", VA = "0x1876A5110")]
	public bool OKNJMCBJEFD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum FODFNDGFGAB : byte
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
internal enum EEPEEDAFCIM
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
internal enum GJKLEHNFMPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum HAHBEELKNPP
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class COPDBAFMNDG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MPIDJEMKKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JKIHAHACKII[] LNMJJIFPAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int CBFIFJPAIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int NLLHDEBAKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte LONOODDDDOB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MPIDJEMKKKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void EHBBAFKDEIA(ulong EJGGEOLBHED, int CNPPIADJIIE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PGOMKAAEJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MABOJHFIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int OENIEFNEKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double MLOMAPOPCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int CACGPJEIIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int HOOJCJJPENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int PNLCJCOFAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch IBNFLNBGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int LEFCIFCBHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long FPILOBGGHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object NPMNMPIDONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal COPDBAFMNDG IHKPKGDIPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal COPDBAFMNDG CCGGPDIHMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<JKIHAHACKII> IMCOIKAMHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<CNALIECIBJE> GIOMJNHAIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly CNALIECIBJE[] JGCFOMDFLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int EOGKOMMPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MEIEBIDEMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool POPFBEBOPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int PAONPAABMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int LCKABCFPJPD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int JFHJFLANHKO = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int PMEOFDMGEJO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object ANOEFGEAAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int GPNMGAFJLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, MPIDJEMKKKP> IBMKNCKNCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> BPHJKHONMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly JKIHAHACKII IBELGIBDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int OEOPOMMOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int NEBBKMHDJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint FBEHLBEGPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JCMEJALDHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int KOJALGAFGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long FANFHEJCFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte OEMPNIMLEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private FODFNDGFGAB IFGKILCNHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private JKIHAHACKII ANFIIOPMEFO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int JCMOIFDKPNC = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int BDGOBDCPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly JKIHAHACKII MHPIABBMFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly JKIHAHACKII KDNHCCAEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly JKIHAHACKII OLOOCJLLCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly JKIHAHACKII JHBIGLDAKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private MLLKKOCIFMP CJEGEDOHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly FAANBDMGAOE AODHLBDJKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int HMNNHOPLICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object JCLFDLINOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly DKMCNDIFPEJ PJHHMHKIICP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte PJGGIEKLOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB78BC0", Offset = "0xB771C0", VA = "0x180B78BC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7696370", Offset = "0x7694970", VA = "0x187696370")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint EEILHJLKIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB78FC0", Offset = "0xB775C0", VA = "0x180B78FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public FODFNDGFGAB JBAGBONBAGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB78FB0", Offset = "0xB775B0", VA = "0x180B78FB0")]
		get
		{
			return default(FODFNDGFGAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long MLBAFNIKNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAEEA0", Offset = "0xAAD4A0", VA = "0x180AAEEA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AOIEMFOCIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x187D9C0", Offset = "0x187BFC0", VA = "0x18187D9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x22F8FF0", Offset = "0x22F75F0", VA = "0x1822F8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int CFMINDMEKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7699020", Offset = "0x7697620", VA = "0x187699020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JNMIHDIEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double BOOBFPHDCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A90810", Offset = "0x2A8EE10", VA = "0x182A90810")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EHBBAFKDEIA MIMCJELOADL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7695E30", Offset = "0x7694430", VA = "0x187695E30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7695FC0", Offset = "0x76945C0", VA = "0x187695FC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7699210", Offset = "0x7697810", VA = "0x187699210")]
	internal COPDBAFMNDG(FAANBDMGAOE DFLCMKMEKPL, IPEndPoint COJCMFPOMJH, int NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7698C80", Offset = "0x7697280", VA = "0x187698C80")]
	internal void NDPFGBMIJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7695470", Offset = "0x7693A70", VA = "0x187695470")]
	internal void ADKPKDNJPPH(IPEndPoint ELHEADCNCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7697A50", Offset = "0x7696050", VA = "0x187697A50")]
	internal void IOOMJJOHOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7696D30", Offset = "0x7695330", VA = "0x187696D30")]
	private void GMOAFDAEOLP(int OAFJNDJAEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7696330", Offset = "0x7694930", VA = "0x187696330")]
	private void DCLLCCCKBPM(int JIHGDFOGCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7698F10", Offset = "0x7697510", VA = "0x187698F10")]
	public int OKDDLIBDDCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7698DF0", Offset = "0x76973F0", VA = "0x187698DF0")]
	public int OKDDLIBDDCB(byte CBEMAPNODAM, bool AMLENJIIIHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76978A0", Offset = "0x7695EA0", VA = "0x1876978A0")]
	private CNALIECIBJE IOKMMLNILPM(byte IFMKBBDLCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7699670", Offset = "0x7697C70", VA = "0x187699670")]
	internal COPDBAFMNDG(FAANBDMGAOE DFLCMKMEKPL, IPEndPoint COJCMFPOMJH, int NMILEMOAODL, byte IOOBIHKBJKN, LNFIIKFFJAM IKGJEPBOAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7699030", Offset = "0x7697630", VA = "0x187699030")]
	internal COPDBAFMNDG(FAANBDMGAOE DFLCMKMEKPL, LHFJBKJEAML KOKMGKHMMEE, int NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7696E00", Offset = "0x7695400", VA = "0x187696E00")]
	internal void HHDJNLKGKEH(AOEMOODKFPL PGAEFIMNJJG, byte[] CDDIADBJAOB, int GHOFJOJMCOI, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7697820", Offset = "0x7695E20", VA = "0x187697820")]
	internal bool IGBPJKNNGKH(ECDEJILFLAC EABADIPHAGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7698640", Offset = "0x7696C40", VA = "0x187698640")]
	public void JOIKNHFPCOF(byte[] CDDIADBJAOB, int GHOFJOJMCOI, int NODGHDHCBPE, HGNPKCIIDKI PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7698030", Offset = "0x7696630", VA = "0x187698030")]
	private void JOCDBMJAOAB(byte[] CDDIADBJAOB, int GHOFJOJMCOI, int NODGHDHCBPE, byte CBEMAPNODAM, HGNPKCIIDKI OACKPIGJEEH, object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7698670", Offset = "0x7696C70", VA = "0x187698670")]
	public void LILDAAPKGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7695EE0", Offset = "0x76944E0", VA = "0x187695EE0")]
	internal GJKLEHNFMPJ AMKEJBOBKEM(JKIHAHACKII EABADIPHAGE)
	{
		return default(GJKLEHNFMPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7698C20", Offset = "0x7697220", VA = "0x187698C20")]
	internal void LMMFPILHAPK(CNALIECIBJE GFKFDPPGPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7696E50", Offset = "0x7695450", VA = "0x187696E50")]
	internal HAHBEELKNPP HKNFANDLNIO(byte[] CDDIADBJAOB, int GHOFJOJMCOI, int NODGHDHCBPE, bool AKKFOJDOENB)
	{
		return default(HAHBEELKNPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7696420", Offset = "0x7694A20", VA = "0x187696420")]
	private void EDCGKDINICN(int FOFFJEBEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x76954A0", Offset = "0x7693AA0", VA = "0x1876954A0")]
	internal void AFFJFLHHJBD(HGNPKCIIDKI HEPPOGGJMKL, JKIHAHACKII OKHLJECLMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76986C0", Offset = "0x7696CC0", VA = "0x1876986C0")]
	private void LMFGAOPBOOK(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7697CA0", Offset = "0x76962A0", VA = "0x187697CA0")]
	private void JHLPIEODOLF(int KJDBPOBDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7697AE0", Offset = "0x76960E0", VA = "0x187697AE0")]
	internal EEPEEDAFCIM JAGLCHMCGMD(AOEMOODKFPL CPEFBJCADDD)
	{
		return default(EEPEEDAFCIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7697160", Offset = "0x7695760", VA = "0x187697160")]
	internal void HMDHLJEPMHL(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7698CA0", Offset = "0x76972A0", VA = "0x187698CA0")]
	private void NIINPNIKDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7696460", Offset = "0x7694A60", VA = "0x187696460")]
	internal void EHKHBAFJBEP(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7696670", Offset = "0x7694C70", VA = "0x187696670")]
	internal void FPGILMIKMIA(int KJDBPOBDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7696070", Offset = "0x7694670", VA = "0x187696070")]
	internal void BIEEOBLDOHG(JKIHAHACKII EABADIPHAGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DKMCNDIFPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long FLPEMBENCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long KBGFNAHGLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long FKDANHLGJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long HPMDIBDIOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GAONENCMJLG;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long MNPHFNLHOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long ADHGHIJPJEC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long OIJPAFGMBHP;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long AAPMGJGKMPA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long FIJGKHNAIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long KOPIHBPOFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long JMHCGLLCIEA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BDDAPKDJEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x769A0F0", Offset = "0x76986F0", VA = "0x18769A0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ENNEHMHLMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x769A2B0", Offset = "0x76988B0", VA = "0x18769A2B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long GBNECLCPICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x769A520", Offset = "0x7698B20", VA = "0x18769A520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long KFNKBIIPMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x769A240", Offset = "0x7698840", VA = "0x18769A240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long MPGAHDIFOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x769A510", Offset = "0x7698B10", VA = "0x18769A510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long BPLKBHJAIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x769A3D0", Offset = "0x76989D0", VA = "0x18769A3D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long FOKKADPEJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x769A100", Offset = "0x7698700", VA = "0x18769A100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long BFMKFLAIGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x769A320", Offset = "0x7698920", VA = "0x18769A320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MLLKKOCIFMP JJMJKNCAFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1402CE0", Offset = "0x14012E0", VA = "0x181402CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double BMMOJHEBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x769A140", Offset = "0x7698740", VA = "0x18769A140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x769A450", Offset = "0x7698A50", VA = "0x18769A450")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x769A250", Offset = "0x7698850", VA = "0x18769A250")]
	public void FNLDHBCFNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x769A0A0", Offset = "0x76986A0", VA = "0x18769A0A0")]
	public void ADDCMEBAKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x769A360", Offset = "0x7698960", VA = "0x18769A360")]
	public void HFNPCKGNNEB(long IIPOHGCDIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x769A3E0", Offset = "0x76989E0", VA = "0x18769A3E0")]
	public void IKADKLHNAJF(long DAMBCKLKKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x769A2C0", Offset = "0x76988C0", VA = "0x18769A2C0")]
	public void GIHIMAFJOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x769A490", Offset = "0x7698A90", VA = "0x18769A490")]
	public void JNIDLGFENGB(long PGONDPBGNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x769A530", Offset = "0x7698B30", VA = "0x18769A530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x769A1A0", Offset = "0x76987A0", VA = "0x18769A1A0")]
	public void DGPHMEIKGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DKMCNDIFPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HBHNGPHCCNJ
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> NGKDEHFMGEN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x76A4590", Offset = "0x76A2B90", VA = "0x1876A4590")]
	public static IPEndPoint LCOHDFPIIMG(string HCAFPLNNBFD, int GCNAAGHBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76A4330", Offset = "0x76A2930", VA = "0x1876A4330")]
	public static IPAddress HFGMCLALMAG(string HCAFPLNNBFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x76A4500", Offset = "0x76A2B00", VA = "0x1876A4500")]
	public static IPAddress HFGMCLALMAG(string HCAFPLNNBFD, AddressFamily JBGKCNBEJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x76A4300", Offset = "0x76A2900", VA = "0x1876A4300")]
	internal static int EGGMIJOBHIE(int BEAKDBAIFPN, int KMAOCFJIBGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7F80", Offset = "0x3DE6580", VA = "0x183DE7F80")]
	internal static T[] JGLJHDJFJED<T>(int LMJBLNOIBOL) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LIGPIAFAFOH : CNALIECIBJE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct PCOGAFELLII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private JKIHAHACKII JAGFMEFELJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long IHOBGDIELDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool PIOPJIDDEFM;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x76AB850", Offset = "0x76A9E50", VA = "0x1876AB850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x76AB830", Offset = "0x76A9E30", VA = "0x1876AB830")]
		public void HAKAIDJFGEI(JKIHAHACKII EABADIPHAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76AB770", Offset = "0x76A9D70", VA = "0x1876AB770")]
		public bool COLDMELHOND(long NFOFONOBILD, COPDBAFMNDG JFKKNFAPEJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76AB7E0", Offset = "0x76A9DE0", VA = "0x1876AB7E0")]
		public bool ELFNJAKNOMA(COPDBAFMNDG JFKKNFAPEJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly JKIHAHACKII MNAPBAHKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly PCOGAFELLII[] MCAKOPEMKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly JKIHAHACKII[] AKOOODLFMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] GEJLIHHINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int GGBNBMOJOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int MBLGOPNNBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int FGDANGBKGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int KFGABPBMJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool EILHKIBLGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly HGNPKCIIDKI AOFCHHACLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool HBEFIEHBGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int IPNEPALJBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte AIIIPOEACNE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BHLHOMPCPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E50", Offset = "0x76A4450", VA = "0x1876A5E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76A6D50", Offset = "0x76A5350", VA = "0x1876A6D50")]
	public LIGPIAFAFOH(COPDBAFMNDG JFKKNFAPEJA, bool AMLENJIIIHJ, byte NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76A6990", Offset = "0x76A4F90", VA = "0x1876A6990")]
	private void NOKFJGOAKFI(JKIHAHACKII EABADIPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x76A64C0", Offset = "0x76A4AC0", VA = "0x1876A64C0", Slot = "4")]
	protected override bool MPLGPIKHLLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76A5E60", Offset = "0x76A4460", VA = "0x1876A5E60", Slot = "5")]
	public override bool HMDHLJEPMHL(JKIHAHACKII EABADIPHAGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FKOPFEBGMBI : CNALIECIBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int CKCMNFEAPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort MBLGOPNNBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool OILMLLPCHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private JKIHAHACKII NEMIBLPMMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly JKIHAHACKII MAGNBFLOLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool APCKJMBIIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte AIIIPOEACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long HIJMPIFLEAC;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x76A37E0", Offset = "0x76A1DE0", VA = "0x1876A37E0")]
	public FKOPFEBGMBI(COPDBAFMNDG JFKKNFAPEJA, bool CABKJKKNCBK, byte NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x76A3320", Offset = "0x76A1920", VA = "0x1876A3320", Slot = "4")]
	protected override bool MPLGPIKHLLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76A3040", Offset = "0x76A1640", VA = "0x1876A3040", Slot = "5")]
	public override bool HMDHLJEPMHL(JKIHAHACKII EABADIPHAGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class MLLJIMOOFNH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KKGMNKFJCKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong GBMGHKMMNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double OFCGOBCBLDC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct MKPMMOKNOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int MDKEKONGNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float CPFGIOBJFEN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x76937A0", Offset = "0x7691DA0", VA = "0x1876937A0")]
	private static void PAMCGKMFIPN(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, ulong CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x76AA9F0", Offset = "0x76A8FF0", VA = "0x1876AA9F0")]
	private static void PAMCGKMFIPN(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x76AA920", Offset = "0x76A8F20", VA = "0x1876AA920")]
	public static void PAMCGKMFIPN(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, short CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x76AAA60", Offset = "0x76A9060", VA = "0x1876AAA60")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, double KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x76AA970", Offset = "0x76A8F70", VA = "0x1876AA970")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x76AA920", Offset = "0x76A8F20", VA = "0x1876AA920")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, short KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76AA920", Offset = "0x76A8F20", VA = "0x1876AA920")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, ushort KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x76AA9F0", Offset = "0x76A8FF0", VA = "0x1876AA9F0")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76AA9F0", Offset = "0x76A8FF0", VA = "0x1876AA9F0")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, uint KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x76AA960", Offset = "0x76A8F60", VA = "0x1876AA960")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x76AA960", Offset = "0x76A8F60", VA = "0x1876AA960")]
	public static void JLCEPLIEOML(byte[] EIJIDGHNNNL, int NDMFOILAFKD, ulong KOPHBHGIACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BPJEGEDPHKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] NAGACDOJNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int GGCEEAPMIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int NHONDFCMDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int FLKHGFGGEKC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] APBNEADAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PAGMJKIBHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int INHNMMICDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76945D0", Offset = "0x7692BD0", VA = "0x1876945D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HAPDKAEJDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x29F8480", Offset = "0x29F6A80", VA = "0x1829F8480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int NLBMCPDFPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7693DE0", Offset = "0x76923E0", VA = "0x187693DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7694590", Offset = "0x7692B90", VA = "0x187694590")]
	public void MODJDBJJPOE(byte[] NGOJMGCIOHB, int PIOCNHLFCNE, int PKBFJNIOFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public BPJEGEDPHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7694970", Offset = "0x7692F70", VA = "0x187694970")]
	public BPJEGEDPHKP(byte[] NGOJMGCIOHB, int PIOCNHLFCNE, int PKBFJNIOFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7694390", Offset = "0x7692990", VA = "0x187694390")]
	public IPEndPoint IIFGHGKOAGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7693FF0", Offset = "0x76925F0", VA = "0x187693FF0")]
	public byte HALMHOFEDJH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7693FF0", Offset = "0x76925F0", VA = "0x187693FF0")]
	public sbyte CDIOMAIHHGO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3B736A0", Offset = "0x3B71CA0", VA = "0x183B736A0")]
	public T[] DMDGBBKMFEG<T>(ushort KCJLCGFEBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7694310", Offset = "0x7692910", VA = "0x187694310")]
	public bool[] GNJMHFFECKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7693DA0", Offset = "0x76923A0", VA = "0x187693DA0")]
	public ushort[] AEICFJCLJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x76942D0", Offset = "0x76928D0", VA = "0x1876942D0")]
	public short[] GAADDGFCHFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x76944A0", Offset = "0x7692AA0", VA = "0x1876944A0")]
	public int[] JHBINKKEOJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7694290", Offset = "0x7692890", VA = "0x187694290")]
	public uint[] FOMHBDFCCLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7693F40", Offset = "0x7692540", VA = "0x187693F40")]
	public float[] BKJAEAIKEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7694210", Offset = "0x7692810", VA = "0x187694210")]
	public double[] FHHHOMHLPIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7694460", Offset = "0x7692A60", VA = "0x187694460")]
	public long[] JBEBEBCHLNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x76944E0", Offset = "0x7692AE0", VA = "0x1876944E0")]
	public ulong[] MKEFKFFLJCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7694030", Offset = "0x7692630", VA = "0x187694030")]
	public string[] DJJAJMMIPFF(int GOFGKHPEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7694250", Offset = "0x7692850", VA = "0x187694250")]
	public bool FJBICNAHDCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7693E60", Offset = "0x7692460", VA = "0x187693E60")]
	public char BJINMCDFFOH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7693E60", Offset = "0x7692460", VA = "0x187693E60")]
	public ushort IDHPDFBOAHH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7693F80", Offset = "0x7692580", VA = "0x187693F80")]
	public short BNBKJABPLIK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7694520", Offset = "0x7692B20", VA = "0x187694520")]
	public long MMOPFEFLEPC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7693ED0", Offset = "0x76924D0", VA = "0x187693ED0")]
	public ulong BJJIPMEAOEO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7693DF0", Offset = "0x76923F0", VA = "0x187693DF0")]
	public int BFKBMPCOKDL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76945E0", Offset = "0x7692BE0", VA = "0x1876945E0")]
	public uint NBBNMHNCDNF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7694180", Offset = "0x7692780", VA = "0x187694180")]
	public float DMBOAIOMFIE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7694900", Offset = "0x7692F00", VA = "0x187694900")]
	public double ODNEBCGGMFC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7694650", Offset = "0x7692C50", VA = "0x187694650")]
	public string NDDCEMAKOME(int GEBBEMBFDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7694890", Offset = "0x7692E90", VA = "0x187694890")]
	public ArraySegment<byte> NOIDECCIFLG(int LMJBLNOIBOL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7694350", Offset = "0x7692950", VA = "0x187694350")]
	public sbyte[] IEGKPAJMBKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7693D60", Offset = "0x7692360", VA = "0x187693D60")]
	public byte[] ACJIDHFGAAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x76941F0", Offset = "0x76927F0", VA = "0x1876941F0")]
	public void ELFNJAKNOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LNFIIKFFJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] NAGACDOJNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int GGCEEAPMIDB;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int CEALHGIMFKA = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool OHADDFALFKE;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding BLIEPOAEDLH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int MCDNKGDFNMA = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] OLKIEMHMEML;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] BJOBNNFAMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x76A9090", Offset = "0x76A7690", VA = "0x1876A9090")]
	public LNFIIKFFJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76A8FF0", Offset = "0x76A75F0", VA = "0x1876A8FF0")]
	public LNFIIKFFJAM(bool DIJPNDMOMNM, int JPBAHANKFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x76A82C0", Offset = "0x76A68C0", VA = "0x1876A82C0")]
	public static LNFIIKFFJAM EEMMNOIKIGH(string KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x76A8410", Offset = "0x76A6A10", VA = "0x1876A8410")]
	public void HDFAPJABOEI(int AKLCFBNOHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2A71C30", Offset = "0x2A70230", VA = "0x182A71C30")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76A8E10", Offset = "0x76A7410", VA = "0x1876A8E10")]
	public void MDDNMEPHFHA(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x76A8EB0", Offset = "0x76A74B0", VA = "0x1876A8EB0")]
	public void MDDNMEPHFHA(double KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x76A8C80", Offset = "0x76A7280", VA = "0x1876A8C80")]
	public void MDDNMEPHFHA(long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x76A8C80", Offset = "0x76A7280", VA = "0x1876A8C80")]
	public void MDDNMEPHFHA(ulong KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x76A89E0", Offset = "0x76A6FE0", VA = "0x1876A89E0")]
	public void MDDNMEPHFHA(int KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76A89E0", Offset = "0x76A6FE0", VA = "0x1876A89E0")]
	public void MDDNMEPHFHA(uint KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x76A8970", Offset = "0x76A6F70", VA = "0x1876A8970")]
	public void MDDNMEPHFHA(char KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x76A8970", Offset = "0x76A6F70", VA = "0x1876A8970")]
	public void MDDNMEPHFHA(ushort KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x76A8970", Offset = "0x76A6F70", VA = "0x1876A8970")]
	public void MDDNMEPHFHA(short KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x76A8F00", Offset = "0x76A7500", VA = "0x1876A8F00")]
	public void MDDNMEPHFHA(sbyte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x76A8F00", Offset = "0x76A7500", VA = "0x1876A8F00")]
	public void MDDNMEPHFHA(byte KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x76A8CD0", Offset = "0x76A72D0", VA = "0x1876A8CD0")]
	public void MDDNMEPHFHA(byte[] CDDIADBJAOB, int PIOCNHLFCNE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x76A8330", Offset = "0x76A6930", VA = "0x1876A8330")]
	public void FONGLFGBEOG(sbyte[] CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x76A8330", Offset = "0x76A6930", VA = "0x1876A8330")]
	public void OIMJPBPDCPE(byte[] CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x76A8910", Offset = "0x76A6F10", VA = "0x1876A8910")]
	public void MDDNMEPHFHA(bool KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x76A8740", Offset = "0x76A6D40", VA = "0x1876A8740")]
	public void LEDKJHPLPMJ(Array MDIMFHGEOCP, int AGLLONMGNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76A84B0", Offset = "0x76A6AB0", VA = "0x1876A84B0")]
	public void LEDKJHPLPMJ(float[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x76A8590", Offset = "0x76A6B90", VA = "0x1876A8590")]
	public void LEDKJHPLPMJ(double[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x76A8590", Offset = "0x76A6B90", VA = "0x1876A8590")]
	public void LEDKJHPLPMJ(long[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76A8590", Offset = "0x76A6B90", VA = "0x1876A8590")]
	public void LEDKJHPLPMJ(ulong[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76A84B0", Offset = "0x76A6AB0", VA = "0x1876A84B0")]
	public void LEDKJHPLPMJ(int[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x76A84B0", Offset = "0x76A6AB0", VA = "0x1876A84B0")]
	public void LEDKJHPLPMJ(uint[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x76A8820", Offset = "0x76A6E20", VA = "0x1876A8820")]
	public void LEDKJHPLPMJ(ushort[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x76A8820", Offset = "0x76A6E20", VA = "0x1876A8820")]
	public void LEDKJHPLPMJ(short[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x76A8330", Offset = "0x76A6930", VA = "0x1876A8330")]
	public void LEDKJHPLPMJ(bool[] KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76A8670", Offset = "0x76A6C70", VA = "0x1876A8670")]
	public void LEDKJHPLPMJ(string[] KOPHBHGIACG, int NMNKBHOFGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x76A8D40", Offset = "0x76A7340", VA = "0x1876A8D40")]
	public void MDDNMEPHFHA(IPEndPoint KDLIEGAJHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76A8900", Offset = "0x76A6F00", VA = "0x1876A8900")]
	public void MDDNMEPHFHA(string KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76A8A70", Offset = "0x76A7070", VA = "0x1876A8A70")]
	public void MDDNMEPHFHA(string KOPHBHGIACG, int GEBBEMBFDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EEIBFKOHJDN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class HKEIIOHPPPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong HMNNHOPLICJ;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x516C5C0", Offset = "0x516ABC0", VA = "0x18516C5C0")]
		static HKEIIOHPPPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void PIGKMAKDOHM(BPJEGEDPHKP KLIAOPJFDOK, object IGBHFHKMLJJ);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OAGFPELLOKG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public EEIBFKOHJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OAGFPELLOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F3B0", Offset = "0x5B8D9B0", VA = "0x185B8F3B0")]
		internal void OKCHMBECLMF(BPJEGEDPHKP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IKCDOBCCDGK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public EEIBFKOHJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IKCDOBCCDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x529B950", Offset = "0x5299F50", VA = "0x18529B950")]
		internal void OKCHMBECLMF(BPJEGEDPHKP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly DCGACCGAIJH KBIJEAEMICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, PIGKMAKDOHM> GIOCHFEEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly LNFIIKFFJAM LOJCGFCOCFP;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x769AE00", Offset = "0x7699400", VA = "0x18769AE00")]
	public EEIBFKOHJDN(int GOFGKHPEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3B54480", Offset = "0x3B52A80", VA = "0x183B54480", Slot = "4")]
	protected virtual ulong KKPBLEHEELE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x769AC00", Offset = "0x7699200", VA = "0x18769AC00", Slot = "5")]
	protected virtual PIGKMAKDOHM GKCEPBCIGGC(BPJEGEDPHKP KLIAOPJFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3C4AD50", Offset = "0x3C49350", VA = "0x183C4AD50", Slot = "6")]
	protected virtual void CKFAOFKDAFI<T>(LNFIIKFFJAM CKPHLHCIFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x769AD30", Offset = "0x7699330", VA = "0x18769AD30")]
	public void MNIJGKIHKHH(BPJEGEDPHKP KLIAOPJFDOK, object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B0C0", Offset = "0x3C496C0", VA = "0x183C4B0C0")]
	public void OMIKOFLNMMP<T>(LNFIIKFFJAM CKPHLHCIFLA, T EABADIPHAGE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x769ADB0", Offset = "0x76993B0", VA = "0x18769ADB0")]
	public void PAIGAFJECNO(BPJEGEDPHKP KLIAOPJFDOK, object IGBHFHKMLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C4AF40", Offset = "0x3C49540", VA = "0x183C4AF40")]
	public void DEMIIDPLNED<T>(Action<T> IBIPDJGNCIG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C4ADC0", Offset = "0x3C493C0", VA = "0x183C4ADC0")]
	public void DEMIIDPLNED<T, TUserData>(Action<T, TUserData> IBIPDJGNCIG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CEGOEBDAGOB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x76949D0", Offset = "0x7692FD0", VA = "0x1876949D0")]
	public CEGOEBDAGOB(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CEKEGJGJMEB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x76949E0", Offset = "0x7692FE0", VA = "0x1876949E0")]
	public CEKEGJGJMEB(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DCGACCGAIJH
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum IOFLIMCAJPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class DFMBOBLBLLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public IOFLIMCAJPM HIKNDMJOAGH;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x464D0C0", Offset = "0x464B6C0", VA = "0x18464D0C0", Slot = "4")]
		public virtual void HAKAIDJFGEI(MethodInfo JCIHHMKHECJ, MethodInfo JJLPEEIOMIO, IOFLIMCAJPM GPEIAHGICNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IKHKOJBIIKE(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GAAEACEIOKP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		protected DFMBOBLBLLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class EIBMPLHPBFI<TClass, TProperty> : DFMBOBLBLLN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> KKFBMEIGGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> GLPJKEDMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> LOBEGBJBENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> GBCMALPLGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> PABMCDANKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> NKJCPFHOFNK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4B49800", Offset = "0x4B47E00", VA = "0x184B49800", Slot = "7")]
		public override void FBMDDAJADBJ(TClass GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4B49100", Offset = "0x4B47700", VA = "0x184B49100", Slot = "8")]
		public override void CHNNJMPFCBN(TClass GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4B4F620", Offset = "0x4B4DC20", VA = "0x184B4F620", Slot = "9")]
		public override void IKHKOJBIIKE(TClass GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4B4A1C0", Offset = "0x4B487C0", VA = "0x184B4A1C0", Slot = "10")]
		public override void GAAEACEIOKP(TClass GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4B49D40", Offset = "0x4B48340", VA = "0x184B49D40")]
		protected TProperty[] FPOLGMBAINC(TClass GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4B4FFC0", Offset = "0x4B4E5C0", VA = "0x184B4FFC0")]
		protected TProperty[] NOHCCMNBCDD(TClass GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4B4B520", Offset = "0x4B49B20", VA = "0x184B4B520", Slot = "4")]
		public override void HAKAIDJFGEI(MethodInfo JCIHHMKHECJ, MethodInfo JJLPEEIOMIO, IOFLIMCAJPM GPEIAHGICNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4B50030", Offset = "0x4B4E630", VA = "0x184B50030")]
		protected EIBMPLHPBFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class OFBBPJEMIGB<TClass, TProperty> : EIBMPLHPBFI<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KALPPNAHEBF(BPJEGEDPHKP OCNJDNNPAAP, [Out] TProperty HKDHKPOCFPE);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void HPBPLEDMDDD(LNFIIKFFJAM KCJIIGKAPGH, TProperty HKDHKPOCFPE);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC070", Offset = "0x5BAA670", VA = "0x185BAC070", Slot = "5")]
		public override void LOKAKHLJJDB(TClass GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC160", Offset = "0x5BAA760", VA = "0x185BAC160", Slot = "6")]
		public override void OMIKOFLNMMP(TClass GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5BABF50", Offset = "0x5BAA550", VA = "0x185BABF50", Slot = "7")]
		public override void FBMDDAJADBJ(TClass GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5BABD70", Offset = "0x5BAA370", VA = "0x185BABD70", Slot = "8")]
		public override void CHNNJMPFCBN(TClass GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x52AED10", Offset = "0x52AD310", VA = "0x1852AED10")]
		protected OFBBPJEMIGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class FAIEIKPNCAO<T> : EIBMPLHPBFI<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4FE42B0", Offset = "0x4FE28B0", VA = "0x184FE42B0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE4320", Offset = "0x4FE2920", VA = "0x184FE4320", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4FE4240", Offset = "0x4FE2840", VA = "0x184FE4240", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4FE41E0", Offset = "0x4FE27E0", VA = "0x184FE41E0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public FAIEIKPNCAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class CGEOGLBIHFO<T> : EIBMPLHPBFI<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D90", Offset = "0x6F87390", VA = "0x186F88D90", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4FE4320", Offset = "0x4FE2920", VA = "0x184FE4320", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D20", Offset = "0x6F87320", VA = "0x186F88D20", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FE41E0", Offset = "0x4FE27E0", VA = "0x184FE41E0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public CGEOGLBIHFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class GPANODKLFCE<T> : EIBMPLHPBFI<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x51073B0", Offset = "0x51059B0", VA = "0x1851073B0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x50EEB10", Offset = "0x50ED110", VA = "0x1850EEB10", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5107340", Offset = "0x5105940", VA = "0x185107340", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x50EE9D0", Offset = "0x50ECFD0", VA = "0x1850EE9D0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public GPANODKLFCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GFJCGILNGEM<T> : EIBMPLHPBFI<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x50EEAA0", Offset = "0x50ED0A0", VA = "0x1850EEAA0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x50EEB10", Offset = "0x50ED110", VA = "0x1850EEB10", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50EEA30", Offset = "0x50ED030", VA = "0x1850EEA30", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x50EE9D0", Offset = "0x50ECFD0", VA = "0x1850EE9D0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public GFJCGILNGEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NEJMNBLMNOC<T> : EIBMPLHPBFI<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5A79860", Offset = "0x5A77E60", VA = "0x185A79860", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x50F9F40", Offset = "0x50F8540", VA = "0x1850F9F40", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A797F0", Offset = "0x5A77DF0", VA = "0x185A797F0", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x50F9E00", Offset = "0x50F8400", VA = "0x1850F9E00", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public NEJMNBLMNOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class GKBBKDBCAON<T> : EIBMPLHPBFI<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x50F9ED0", Offset = "0x50F84D0", VA = "0x1850F9ED0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x50F9F40", Offset = "0x50F8540", VA = "0x1850F9F40", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x50F9E60", Offset = "0x50F8460", VA = "0x1850F9E60", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50F9E00", Offset = "0x50F8400", VA = "0x1850F9E00", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public GKBBKDBCAON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class BJNIKELDCIF<T> : EIBMPLHPBFI<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9C40", Offset = "0x4FF8240", VA = "0x184FF9C40", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9CB0", Offset = "0x4FF82B0", VA = "0x184FF9CB0", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8570", Offset = "0x6AF6B70", VA = "0x186AF8570", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9B70", Offset = "0x4FF8170", VA = "0x184FF9B70", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public BJNIKELDCIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FFFHOGDPNOG<T> : EIBMPLHPBFI<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9C40", Offset = "0x4FF8240", VA = "0x184FF9C40", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9CB0", Offset = "0x4FF82B0", VA = "0x184FF9CB0", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9BD0", Offset = "0x4FF81D0", VA = "0x184FF9BD0", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9B70", Offset = "0x4FF8170", VA = "0x184FF9B70", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public FFFHOGDPNOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MLKIOPLNGFE<T> : EIBMPLHPBFI<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C1E0", Offset = "0x5A1A7E0", VA = "0x185A1C1E0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C250", Offset = "0x5A1A850", VA = "0x185A1C250", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C170", Offset = "0x5A1A770", VA = "0x185A1C170", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FE41E0", Offset = "0x4FE27E0", VA = "0x184FE41E0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public MLKIOPLNGFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GLGGKBCFAIN<T> : EIBMPLHPBFI<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x50FCDF0", Offset = "0x50FB3F0", VA = "0x1850FCDF0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x50FCE60", Offset = "0x50FB460", VA = "0x1850FCE60", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x50FCD80", Offset = "0x50FB380", VA = "0x1850FCD80", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x50F9E00", Offset = "0x50F8400", VA = "0x1850F9E00", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public GLGGKBCFAIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class MBFAGCAHPGD<T> : EIBMPLHPBFI<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x59F10F0", Offset = "0x59EF6F0", VA = "0x1859F10F0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x59F1160", Offset = "0x59EF760", VA = "0x1859F1160", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x59F1080", Offset = "0x59EF680", VA = "0x1859F1080", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9B70", Offset = "0x4FF8170", VA = "0x184FF9B70", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F07F0", VA = "0x1845F21F0")]
		public MBFAGCAHPGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ENOOICLPANN<T> : OFBBPJEMIGB<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B6DCA0", Offset = "0x4B6C2A0", VA = "0x184B6DCA0", Slot = "12")]
		protected override void HPBPLEDMDDD(LNFIIKFFJAM KCJIIGKAPGH, char HKDHKPOCFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B6DCD0", Offset = "0x4B6C2D0", VA = "0x184B6DCD0", Slot = "11")]
		protected override void KALPPNAHEBF(BPJEGEDPHKP OCNJDNNPAAP, [Out] char HKDHKPOCFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
		public ENOOICLPANN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BBMIANAHBCD<T> : OFBBPJEMIGB<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A210", Offset = "0x6A08810", VA = "0x186A0A210", Slot = "12")]
		protected override void HPBPLEDMDDD(LNFIIKFFJAM KCJIIGKAPGH, IPEndPoint HKDHKPOCFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A240", Offset = "0x6A08840", VA = "0x186A0A240", Slot = "11")]
		protected override void KALPPNAHEBF(BPJEGEDPHKP OCNJDNNPAAP, [Out] IPEndPoint HKDHKPOCFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
		public BBMIANAHBCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class MIAHOCPKPGI<T> : EIBMPLHPBFI<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int OGLAMKFPIHO;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5A16DA0", Offset = "0x5A153A0", VA = "0x185A16DA0")]
		public MIAHOCPKPGI(int GEBBEMBFDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5A16CC0", Offset = "0x5A152C0", VA = "0x185A16CC0", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5A16D30", Offset = "0x5A15330", VA = "0x185A16D30", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5A16C50", Offset = "0x5A15250", VA = "0x185A16C50", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5A16BE0", Offset = "0x5A151E0", VA = "0x185A16BE0", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class AHBLIAPKMCK<T> : DFMBOBLBLLN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo CLBHDAJPKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type CBPEGPFKLHK;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5411D70", Offset = "0x5410370", VA = "0x185411D70")]
		public AHBLIAPKMCK(PropertyInfo GBIEIIJCCOO, Type OCIIABCKJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5411C00", Offset = "0x5410200", VA = "0x185411C00", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5411CC0", Offset = "0x54102C0", VA = "0x185411CC0", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5411AE0", Offset = "0x54100E0", VA = "0x185411AE0", Slot = "7")]
		public override void FBMDDAJADBJ(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5411A80", Offset = "0x5410080", VA = "0x185411A80", Slot = "8")]
		public override void CHNNJMPFCBN(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5411BA0", Offset = "0x54101A0", VA = "0x185411BA0", Slot = "9")]
		public override void IKHKOJBIIKE(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5411B40", Offset = "0x5410140", VA = "0x185411B40", Slot = "10")]
		public override void GAAEACEIOKP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class IEECHBBPPHB<T> : AHBLIAPKMCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
		public IEECHBBPPHB(PropertyInfo GBIEIIJCCOO, Type OCIIABCKJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x525E630", Offset = "0x525CC30", VA = "0x18525E630", Slot = "5")]
		public override void LOKAKHLJJDB(T GHPAGMFKKIL, BPJEGEDPHKP OCNJDNNPAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x525E6F0", Offset = "0x525CCF0", VA = "0x18525E6F0", Slot = "6")]
		public override void OMIKOFLNMMP(T GHPAGMFKKIL, LNFIIKFFJAM KCJIIGKAPGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class ILAFGDCFKAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static ILAFGDCFKAN<T> EHBCEBDHHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly DFMBOBLBLLN<T>[] OKCJIEFCKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int BNMNOPNDPPO;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x529BC70", Offset = "0x529A270", VA = "0x18529BC70")]
		public ILAFGDCFKAN(List<DFMBOBLBLLN<T>> LDDPMLENMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x529BBC0", Offset = "0x529A1C0", VA = "0x18529BBC0")]
		public void OMIKOFLNMMP(T MPIDDJPOOMJ, LNFIIKFFJAM CKPHLHCIFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x529BB10", Offset = "0x529A110", VA = "0x18529BB10")]
		public void LOKAKHLJJDB(T MPIDDJPOOMJ, BPJEGEDPHKP KLIAOPJFDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class ELABHBGMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract DFMBOBLBLLN<T> HBAOOBIPNDD<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private LNFIIKFFJAM FDFMMIEAOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int NKCEOHEFLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, ELABHBGMLEE> IIIAGMDPNFA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7699800", Offset = "0x7697E00", VA = "0x187699800")]
	public DCGACCGAIJH(int GOFGKHPEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3C207E0", Offset = "0x3C1EDE0", VA = "0x183C207E0")]
	private ILAFGDCFKAN<T> AOKPNNAMBCM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3C21750", Offset = "0x3C1FD50", VA = "0x183C21750")]
	public void NCEHDCEOICJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3C216D0", Offset = "0x3C1FCD0", VA = "0x183C216D0")]
	public bool LPNJIHLFELG<T>(BPJEGEDPHKP KLIAOPJFDOK, T AMMKGILEHBG) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3C20780", Offset = "0x3C1ED80", VA = "0x183C20780")]
	public void ANHNANMIGBP<T>(LNFIIKFFJAM CKPHLHCIFLA, T MPIDDJPOOMJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LKGJCANLNCK
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime AIIOAPGJAAB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] PNDPDEALCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HIGPAOMHCFC OHLEOHLOLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x76A7460", Offset = "0x76A5A60", VA = "0x1876A7460")]
		get
		{
			return default(HIGPAOMHCFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HBIEBDJGKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x76A76A0", Offset = "0x76A5CA0", VA = "0x1876A76A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x76A7170", Offset = "0x76A5770", VA = "0x1876A7170")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FFBLDKBLOGA CHOHNONGBII
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x76A71B0", Offset = "0x76A57B0", VA = "0x1876A71B0")]
		get
		{
			return default(FFBLDKBLOGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x76A6FB0", Offset = "0x76A55B0", VA = "0x1876A6FB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NOAPNJEBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x76A6F80", Offset = "0x76A5580", VA = "0x1876A6F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint FEFKGICDMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x76A73E0", Offset = "0x76A59E0", VA = "0x1876A73E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? ACDKIKDIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x76A7E60", Offset = "0x76A6460", VA = "0x1876A7E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? NPJOEBPFDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x76A7490", Offset = "0x76A5A90", VA = "0x1876A7490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? ANEGGIENFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x76A6FF0", Offset = "0x76A55F0", VA = "0x1876A6FF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x76A76D0", Offset = "0x76A5CD0", VA = "0x1876A76D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? FNAONNADCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF85D30", Offset = "0xF84330", VA = "0x180F85D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x76A7EF0", Offset = "0x76A64F0", VA = "0x1876A7EF0")]
	public LKGJCANLNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x76A8210", Offset = "0x76A6810", VA = "0x1876A8210")]
	internal LKGJCANLNCK(byte[] EIJIDGHNNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x76A7D40", Offset = "0x76A6340", VA = "0x1876A7D40")]
	public static LKGJCANLNCK OCLMLCKKHPB(byte[] EIJIDGHNNNL, DateTime CCDEGNIJMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x76A7B40", Offset = "0x76A6140", VA = "0x1876A7B40")]
	internal void NDANBGHMHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x76A74C0", Offset = "0x76A5AC0", VA = "0x1876A74C0")]
	private void JLEPNLEMOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x76A71E0", Offset = "0x76A57E0", VA = "0x1876A71E0")]
	private DateTime? HNPLFFKIDHM(int PIOCNHLFCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x76A7970", Offset = "0x76A5F70", VA = "0x1876A7970")]
	private void MHDLKOALPAB(int PIOCNHLFCNE, DateTime? KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A78A0", Offset = "0x76A5EA0", VA = "0x1876A78A0")]
	private ulong MBLEMOJPKAG(int PIOCNHLFCNE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x76A70B0", Offset = "0x76A56B0", VA = "0x1876A70B0")]
	private void ECGGCKPDDIL(int PIOCNHLFCNE, ulong KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x76A7020", Offset = "0x76A5620", VA = "0x1876A7020")]
	private uint DJJFEBJMMLG(int PIOCNHLFCNE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x755E810", Offset = "0x755CE10", VA = "0x18755E810")]
	private static uint APHPHMFJFIC(uint GBNAKFLHCOE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x76A6F20", Offset = "0x76A5520", VA = "0x1876A6F20")]
	private static ulong APHPHMFJFIC(ulong GBNAKFLHCOE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HIGPAOMHCFC
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
public enum FFBLDKBLOGA
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class OINMHEOKEIH
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int LNBNGPKGBNL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int ANAJCJPIGDB = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int CKMFMHHNCMH = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint AHMHFKCINCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int MNFNKIJFNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int CDGCKCBOEOM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JBFHAEJIMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x76AAB60", Offset = "0x76A9160", VA = "0x1876AAB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x76AAB70", Offset = "0x76A9170", VA = "0x1876AAB70")]
	public bool JOIKNHFPCOF(GLOEEIFMNNH HALFOOJPGDJ, int HBAPMMDKJDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class CFPFGMPOAOD : GLOEEIFMNNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket HALFOOJPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly FAANBDMGAOE DFLCMKMEKPL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short FMNBOHNEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7694AA0", Offset = "0x76930A0", VA = "0x187694AA0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JNCDGEPGFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7694BB0", Offset = "0x76931B0", VA = "0x187694BB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint OFBEMFPJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7694A40", Offset = "0x7693040", VA = "0x187694A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily GCDHDEGCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x32B7830", Offset = "0x32B5E30", VA = "0x1832B7830", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x76951B0", Offset = "0x76937B0", VA = "0x1876951B0")]
	public CFPFGMPOAOD(AddressFamily JBGKCNBEJAJ, FAANBDMGAOE DFLCMKMEKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7694BD0", Offset = "0x76931D0", VA = "0x187694BD0", Slot = "8")]
	public bool MMPGBEGMDMF(IPEndPoint KDLIEGAJHCH, LOFBOENKDCN EDJJCAOFHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7694A60", Offset = "0x7693060", VA = "0x187694A60", Slot = "9")]
	public int DKGJAJACAAI(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int KCJLCGFEBMJ, IPEndPoint COJCMFPOMJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7694AC0", Offset = "0x76930C0", VA = "0x187694AC0", Slot = "10")]
	public int IBBJPLDDPAA(byte[] DNGAEEFBGGO, EndPoint KAAGIKAKHGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7695190", Offset = "0x7693790", VA = "0x187695190", Slot = "11")]
	public void PADDBFOKNKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface GLOEEIFMNNH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short FMNBOHNEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int JNCDGEPGFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint OFBEMFPJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily GCDHDEGCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMPGBEGMDMF(IPEndPoint KDLIEGAJHCH, LOFBOENKDCN EDJJCAOFHMO);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DKGJAJACAAI(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int KCJLCGFEBMJ, IPEndPoint COJCMFPOMJH);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IBBJPLDDPAA(byte[] DNGAEEFBGGO, EndPoint COJCMFPOMJH);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PADDBFOKNKF();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct JBELONJGPCK : IEquatable<JBELONJGPCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long ADOEFDNLOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long PNDAAECDFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long ONJBFGPKIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int KDPKONNGMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int IANIMFHANMF;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x76A4960", Offset = "0x76A2F60", VA = "0x1876A4960")]
	public JBELONJGPCK(byte[] KBIGEJLMJNE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x76A4A20", Offset = "0x76A3020", VA = "0x1876A4A20")]
	public JBELONJGPCK(Span<byte> KBIGEJLMJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x76A4920", Offset = "0x76A2F20", VA = "0x1876A4920", Slot = "4")]
	public bool Equals(JBELONJGPCK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x76A4870", Offset = "0x76A2E70", VA = "0x1876A4870", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class AMKHJAMPMMP : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] OFNDLDCGEKG;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BHKIEIBLLNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void KCMLOIHBNPL(IPEndPoint KBIGEJLMJNE, Span<byte> CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string CGMCNMLMLOH = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int NEJAFOEIKDH = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int OOBKHEEJOGC = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int KMLLCBIHOGB = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<JBELONJGPCK, IPEndPoint> EAGGOHAIANG;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static KCMLOIHBNPL NMAJCFMNFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int ABAKDJHBBKE;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	internal void MAFPJCCGDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	internal void JCNILHDAHFE(IPEndPoint COJCMFPOMJH, Span<byte> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class CEFHDEKOHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int EJJMPAMBHNI;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
	protected CEFHDEKOHOL(int GIEPELEDCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LANAAEOMLOO(IPEndPoint KDLIEGAJHCH, byte[] CDDIADBJAOB, int PIOCNHLFCNE, int NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GOOIOHGLMJI(IPEndPoint KDLIEGAJHCH, byte[] CDDIADBJAOB, int PIOCNHLFCNE, int NODGHDHCBPE);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class OPOLHEEBICK : CEFHDEKOHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] HAELBKGFDIJ;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator OJMNGCMEIJH;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB00", Offset = "0x2B7C100", VA = "0x182B7DB00")]
	public OPOLHEEBICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x76AB560", Offset = "0x76A9B60", VA = "0x1876AB560")]
	public void PBMGKFIBLNE(IPEndPoint KDLIEGAJHCH, byte[] HAELBKGFDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x76AB480", Offset = "0x76A9A80", VA = "0x1876AB480")]
	public void LPJPIGOIOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76AAFD0", Offset = "0x76A95D0", VA = "0x1876AAFD0", Slot = "4")]
	public override void LANAAEOMLOO(IPEndPoint KDLIEGAJHCH, byte[] CDDIADBJAOB, int PIOCNHLFCNE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x76AAC60", Offset = "0x76A9260", VA = "0x1876AAC60", Slot = "5")]
	public override void GOOIOHGLMJI(IPEndPoint KDLIEGAJHCH, byte[] CDDIADBJAOB, int PIOCNHLFCNE, int NODGHDHCBPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct DIDAONDANLL
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void APJJEAOMNPL([NoAlias] byte* DGNJIIDPDOO, [NoAlias] byte* HAELBKGFDIJ, [NoAlias] byte* NDNDEIOBHIE, int NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class NECMAGGPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x76ABC20", Offset = "0x76AA220", VA = "0x1876ABC20")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x76AC040", Offset = "0x76AA640", VA = "0x1876AC040")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x76ABF90", Offset = "0x76AA590", VA = "0x1876ABF90")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x76ABD50", Offset = "0x76AA350", VA = "0x1876ABD50")]
		public unsafe static void MJPLNPACNDN([NoAlias] byte* DGNJIIDPDOO, [NoAlias] byte* HAELBKGFDIJ, [NoAlias] byte* NDNDEIOBHIE, int NODGHDHCBPE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint HAELBKGFDIJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint NDNDEIOBHIE[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint EFHAOGEMIMH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint PFANFGINMIF[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint LCNEDGJMBEH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint OANCIKAKMOF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint IKGEBBPOFCA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint DCCPNBMKFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint GHFIGNBKOCG[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7699A30", Offset = "0x7698030", VA = "0x187699A30")]
	private void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x76998A0", Offset = "0x7697EA0", VA = "0x1876998A0")]
	private uint AFJIEOPJEOD(uint KMDIJJMODFC, int NNNBFANLILN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7693340", Offset = "0x7691940", VA = "0x187693340")]
	private void MAFOMKMOGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x76933F0", Offset = "0x76919F0", VA = "0x1876933F0")]
	private void MBEALFEFHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x76932B0", Offset = "0x76918B0", VA = "0x1876932B0")]
	private void IHAAIOFJBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7693600", Offset = "0x7691C00", VA = "0x187693600")]
	private void MNLJFEFNLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x76998D0", Offset = "0x7697ED0", VA = "0x1876998D0")]
	private void AGMAEBKNNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7699B20", Offset = "0x7698120", VA = "0x187699B20")]
	private unsafe void MMJGFGEELGB(byte* DGNJIIDPDOO, uint* HAELBKGFDIJ, uint* NDNDEIOBHIE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x769A020", Offset = "0x7698620", VA = "0x18769A020")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void POGEKBOGAOO([NoAlias] byte* DGNJIIDPDOO, [NoAlias] byte* HAELBKGFDIJ, [NoAlias] byte* NDNDEIOBHIE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7699F40", Offset = "0x7698540", VA = "0x187699F40")]
	public static void POGEKBOGAOO(Span<byte> DGNJIIDPDOO, Span<byte> HAELBKGFDIJ, Span<byte> NDNDEIOBHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7699930", Offset = "0x7697F30", VA = "0x187699930")]
	public static void APPFAACAIAM(Span<byte> DGNJIIDPDOO, Span<byte> HAELBKGFDIJ, Span<byte> NDNDEIOBHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7699AB0", Offset = "0x76980B0", VA = "0x187699AB0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LPEBHDCCMGP([NoAlias] byte* DGNJIIDPDOO, [NoAlias] byte* HAELBKGFDIJ, [NoAlias] byte* NDNDEIOBHIE, int NODGHDHCBPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x76AC1A0", Offset = "0x76AA7A0", VA = "0x1876AC1A0")]
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
