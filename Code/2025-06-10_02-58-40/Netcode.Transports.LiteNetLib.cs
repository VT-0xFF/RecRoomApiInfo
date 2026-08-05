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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JDNBMNHMFAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum CPPKPFBDPLL
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
		private NetworkManager DMNAILPFDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool EANCBEDLBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, ICMBPOHFOHO> NMJDMEIJBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MCPGJBDJLKO MMLBDABHCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch JFKIKKOAHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] GKFNOEFJBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CPPKPFBDPLL NMIMHMPBKFP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LFKNNAHLAIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6E96140", Offset = "0x6E95340", VA = "0x186E96140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong MPBCHCHKKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool DBJPPOKKIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6E96120", Offset = "0x6E95320", VA = "0x186E96120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E956C0", Offset = "0x6E948C0", VA = "0x186E956C0")]
		public void RecRoom_SetEncryptionInfo(ulong FBCNBFEPLJK, byte[] MHDODBCCAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E956A0", Offset = "0x6E948A0", VA = "0x186E956A0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E95550", Offset = "0x6E94750", VA = "0x186E95550")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E96020", Offset = "0x6E95220", VA = "0x186E96020")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E957E0", Offset = "0x6E949E0", VA = "0x186E957E0", Slot = "6")]
		public override void Send(ulong JFOBNAKMELF, ArraySegment<byte> CAIGHLKIDBF, NetworkDelivery JEGBKLOLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E95660", Offset = "0x6E94860", VA = "0x186E95660", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong JFOBNAKMELF, [Out] ArraySegment<byte> EKFBEBELGHJ, [Out] float JBMEMIJPGFE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E95AD0", Offset = "0x6E94CD0", VA = "0x186E95AD0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E95E40", Offset = "0x6E95040", VA = "0x186E95E40", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E94BE0", Offset = "0x6E93DE0", VA = "0x186E94BE0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong JFOBNAKMELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E94AF0", Offset = "0x6E93CF0", VA = "0x186E94AF0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E94CF0", Offset = "0x6E93EF0", VA = "0x186E94CF0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong JFOBNAKMELF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E95A60", Offset = "0x6E94C60", VA = "0x186E95A60", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E94FA0", Offset = "0x6E941A0", VA = "0x186E94FA0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager DMNAILPFDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E95480", Offset = "0x6E94680", VA = "0x186E95480")]
		private OIPIMLNJHDO LPAMFAKCEDP(NetworkDelivery GDHKDBJPDLG)
		{
			return default(OIPIMLNJHDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E951B0", Offset = "0x6E943B0", VA = "0x186E951B0", Slot = "16")]
		private void JLNLMJBPEBO(ICMBPOHFOHO MCIFBLKNMLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E94D90", Offset = "0x6E93F90", VA = "0x186E94D90", Slot = "17")]
		private void HALHKOMCKEP(ICMBPOHFOHO MCIFBLKNMLG, GLCOCMHGDNB PEBFFNICEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "18")]
		private void CCCLNLGNADJ(IPEndPoint APGOGLNACOE, SocketError CAEEMKMKLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E95270", Offset = "0x6E94470", VA = "0x186E95270", Slot = "19")]
		private void KEAPPIPKNDL(ICMBPOHFOHO MCIFBLKNMLG, IOHNJPMHHGO GBOEOLHFKIL, byte OEPNMLKLPLK, OIPIMLNJHDO AGNJIECFLMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E94E60", Offset = "0x6E94060", VA = "0x186E94E60")]
		private void ILMNMBALGCE(int GCFCAGDGDIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "20")]
		private void LOEGAGHFHAN(IPEndPoint OLPMLELCFJJ, IOHNJPMHHGO GBOEOLHFKIL, JMENOFOLLDM CDBGHOOKDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "21")]
		private void JIOGEHKNCBC(ICMBPOHFOHO MCIFBLKNMLG, int ELLLLOJOHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E94F40", Offset = "0x6E94140", VA = "0x186E94F40", Slot = "22")]
		private void IMKMKNGEIML(HELPJFGFHAC IKFDGIFGHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E94AC0", Offset = "0x6E93CC0", VA = "0x186E94AC0")]
		private ulong ADEFGGKCNCF(ICMBPOHFOHO MCIFBLKNMLG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E95640", Offset = "0x6E94840", VA = "0x186E95640")]
		private static int PHCCKJELHDH(float GKFLGCPHKEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E96040", Offset = "0x6E95240", VA = "0x186E96040")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class OOEIBEFFCJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly ICMBPOHFOHO BFEGGONKOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<GADDDHPCIGD> NIOPAFGFJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int COPABILHEFI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IDOPDDLIGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E800", Offset = "0x6E9DA00", VA = "0x186E9E800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E850", Offset = "0x6E9DA50", VA = "0x186E9E850")]
	protected OOEIBEFFCJN(ICMBPOHFOHO MCIFBLKNMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E760", Offset = "0x6E9D960", VA = "0x186E9E760")]
	public void FPEMDBHLDCC(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E6E0", Offset = "0x6E9D8E0", VA = "0x186E9E6E0")]
	protected void ACHJPLLLECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E7C0", Offset = "0x6E9D9C0", VA = "0x186E9E7C0")]
	public bool LLJIILLCDNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool DJJKIONEAJG();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HBCGHOFAGNA(GADDDHPCIGD LLAAFLHMHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum OAJGAGJIDNM
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
public class HELPJFGFHAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly MCPGJBDJLKO FMIJNJJLICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int LODILOLHFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BNOKKAHDJLA KEMDLMKPDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint CCAOFGBOAEG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal OAJGAGJIDNM FAFJLKPDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA29CC0", Offset = "0xA28EC0", VA = "0x180A29CC0")]
		[CompilerGenerated]
		get
		{
			return default(OAJGAGJIDNM);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDCB700", Offset = "0xDCA900", VA = "0x180DCB700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D240", Offset = "0x6E8C440", VA = "0x186E8D240")]
	internal void IOALAPGONJP(BNOKKAHDJLA DNBKNDLHBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D210", Offset = "0x6E8C410", VA = "0x186E8D210")]
	private bool IHGKEIOLANG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D300", Offset = "0x6E8C500", VA = "0x186E8D300")]
	internal HELPJFGFHAC(IPEndPoint OLPMLELCFJJ, BNOKKAHDJLA IIBBEGPOAKC, MCPGJBDJLKO KIAPDCBHAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D2A0", Offset = "0x6E8C4A0", VA = "0x186E8D2A0")]
	public ICMBPOHFOHO MPKAMKCBPHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JMENOFOLLDM
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum FOOIANCCMPA
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
public struct GLCOCMHGDNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FOOIANCCMPA IMONCHOMGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError PPKKPMGMPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IOHNJPMHHGO DHMBCEIGBEN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JDNBMNHMFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAGGOGFDDOB(ICMBPOHFOHO MCIFBLKNMLG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFCLPJMFNBF(ICMBPOHFOHO MCIFBLKNMLG, GLCOCMHGDNB PEBFFNICEMC);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDJKIHLNKMJ(IPEndPoint APGOGLNACOE, SocketError CAEEMKMKLOL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNMIGAJCFFJ(ICMBPOHFOHO MCIFBLKNMLG, IOHNJPMHHGO GBOEOLHFKIL, byte OEPNMLKLPLK, OIPIMLNJHDO AGNJIECFLMD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKOJNLPIKBP(IPEndPoint OLPMLELCFJJ, IOHNJPMHHGO GBOEOLHFKIL, JMENOFOLLDM CDBGHOOKDCC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IABMBNKOLOM(ICMBPOHFOHO MCIFBLKNMLG, int ELLLLOJOHAC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHDOLOJBMJI(HELPJFGFHAC IKFDGIFGHKP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HANLLFGCINB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INAINPIPLFE(ICMBPOHFOHO MCIFBLKNMLG, object GCCFFOHCPGM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GMOJDJENCHH
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEBMNJFINJP(LBOIHMBNECE LLAAFLHMHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PDJIOPFBJOE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHLIEMLIABM(ICMBPOHFOHO MCIFBLKNMLG, IPEndPoint MDKHBBKHPGI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BNOKKAHDJLA
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int LJFCBODNCKO = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long CEKAMLFDFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EPFEOMHPPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] BCGLKFFNJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly GIGJCJOPBCG OCEAHOAJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int CCBPPEHJKKJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E88FC0", Offset = "0x6E881C0", VA = "0x186E88FC0")]
	private BNOKKAHDJLA(long BFOPGCHJDHH, byte OPAFAMILEBH, int MNPNHJICMND, byte[] HOBABCOOEJN, GIGJCJOPBCG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E88D80", Offset = "0x6E87F80", VA = "0x186E88D80")]
	public static int MHACFODCFAA(GADDDHPCIGD LLAAFLHMHNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E88B60", Offset = "0x6E87D60", VA = "0x186E88B60")]
	public static BNOKKAHDJLA GLBLBKGNJMJ(GADDDHPCIGD LLAAFLHMHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E88DE0", Offset = "0x6E87FE0", VA = "0x186E88DE0")]
	public static GADDDHPCIGD NNFOOCPHCLA(IDLIFIOADPE IPJEOECKOCI, SocketAddress DEPCJHAPPBC, long DBDOCBHHKCN, int MNPNHJICMND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class NJEJILAOAPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long CEKAMLFDFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte EPFEOMHPPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int CCBPPEHJKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool NNEJBOHDLHM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E690", Offset = "0x6E9D890", VA = "0x186E9E690")]
	private NJEJILAOAPB(long BFOPGCHJDHH, byte OPAFAMILEBH, int BICLIGEIDMA, bool EECGMJHPMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E350", Offset = "0x6E9D550", VA = "0x186E9E350")]
	public static NJEJILAOAPB GLBLBKGNJMJ(GADDDHPCIGD LLAAFLHMHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E5A0", Offset = "0x6E9D7A0", VA = "0x186E9E5A0")]
	public static GADDDHPCIGD NNFOOCPHCLA(long DBDOCBHHKCN, byte HAIKNPOIIHF, int IJELCOBBGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E4A0", Offset = "0x6E9D6A0", VA = "0x186E9E4A0")]
	public static GADDDHPCIGD LBABFKLJONF(ICMBPOHFOHO MCIFBLKNMLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum FJJFGNKJFBC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface INENOMDGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMECELPPIME(IPEndPoint JBLOBBCGPGB, IPEndPoint OLPMLELCFJJ, string CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLPGPPJBEJG(IPEndPoint DCDPLIKIOKE, FJJFGNKJFBC GDHKDBJPDLG, string CCLFNPCGNED);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EINKEPAGMHL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FCNDGJGKEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint OKDHIJKJDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint CCAOFGBOAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string KIHNHODFIPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct GIHFICFKAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint KPBBCIFHEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FJJFGNKJFBC BGLOFMKFAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string KIHNHODFIPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class KFKNHJENNEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NNMKIDLPGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KIHNHODFIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KFKNHJENNEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CKHCGMKJAGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint NNMKIDLPGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint CEEHLDGCBDB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string KIHNHODFIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CKHCGMKJAGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class ALIAJJGEEBD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string KIHNHODFIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NLKAPILNCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA04160", Offset = "0xA03360", VA = "0x180A04160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ALIAJJGEEBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MCPGJBDJLKO KIEGIDLGCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<FCNDGJGKEKB> ECDPJOJJLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<GIHFICFKAGJ> AEPIAEFCCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly GIGJCJOPBCG GPAOAHLHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IDLIFIOADPE LIJBOFMPHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly KKOAGABJBOJ DKADNONNDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private INENOMDGLMC NOHBODCEDOI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int OJHCGABPBEC = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool PBHONFCKIMB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A0D0", Offset = "0x6E892D0", VA = "0x186E8A0D0")]
	internal EINKEPAGMHL(MCPGJBDJLKO PHELJHIHIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E89C50", Offset = "0x6E88E50", VA = "0x186E89C50")]
	internal void IJLGKBJGPLJ(IPEndPoint AANMPFNCICH, GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x388E1C0", Offset = "0x388D3C0", VA = "0x18388E1C0")]
	private void HEKPIJMPPOA<T>(T LLAAFLHMHNL, IPEndPoint LBPEJPMBIKP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E89AC0", Offset = "0x6E88CC0", VA = "0x186E89AC0")]
	private void EMECELPPIME(KFKNHJENNEE LNGKKKOKLIH, IPEndPoint AANMPFNCICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E89F70", Offset = "0x6E89170", VA = "0x186E89F70")]
	private void MMGJCNOLDIP(CKHCGMKJAGC LNGKKKOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E89DD0", Offset = "0x6E88FD0", VA = "0x186E89DD0")]
	private void MECENCACMKE(ALIAJJGEEBD LNGKKKOKLIH, IPEndPoint AANMPFNCICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OIPIMLNJHDO : byte
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
public enum NNFGAFAJKHA : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FLLNOPFDFNB
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] PLGJMMAENDE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int DNDLPMBEKFP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int INAGJPFJEGD;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NPGPCGOAJII : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E88150", Offset = "0x6E87350", VA = "0x186E88150")]
	public NPGPCGOAJII(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AHLPHIHHIPC : NPGPCGOAJII
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E88150", Offset = "0x6E87350", VA = "0x186E88150")]
	public AHLPHIHHIPC(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum EMFEJBEDCMC
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
public interface NNCCDEAHEAD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGHFHLKHHGH(EMFEJBEDCMC ENPJMGEGPJN, string EBPGPJLLHDI, params object[] CCEPNMMABPI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class ICPEJFDHCJB
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static NNCCDEAHEAD PCEDNKEFGMD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object MPAAEOLILFJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E91750", Offset = "0x6E90950", VA = "0x186E91750")]
	private static void MDBEKAFKFBE(EMFEJBEDCMC PFOKAAABKFN, string EBPGPJLLHDI, params object[] CCEPNMMABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E91980", Offset = "0x6E90B80", VA = "0x186E91980")]
	internal static void MNIBELPHMJM(string EBPGPJLLHDI, params object[] CCEPNMMABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E916F0", Offset = "0x6E908F0", VA = "0x186E916F0")]
	internal static void IEPCNPIFNPB(string EBPGPJLLHDI, params object[] CCEPNMMABPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E919E0", Offset = "0x6E90BE0", VA = "0x186E919E0")]
	internal static void OADKJPENNOK(string EBPGPJLLHDI, params object[] CCEPNMMABPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum AEELGGNHGML
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IOHNJPMHHGO : GIGJCJOPBCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private GADDDHPCIGD NMPOAHKHJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly MCPGJBDJLKO CJKPDNEHABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FPGLPLLIKLO MKDCBIKNPDP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E92A50", Offset = "0x6E91C50", VA = "0x186E92A50")]
	internal IOHNJPMHHGO(MCPGJBDJLKO OBHJPIMFHEM, FPGLPLLIKLO INMBPJOALLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E92930", Offset = "0x6E91B30", VA = "0x186E92930")]
	internal void HHELLKIELAO(GADDDHPCIGD LLAAFLHMHNL, int JOOHGDDDKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E929D0", Offset = "0x6E91BD0", VA = "0x186E929D0")]
	internal void IAACIJODOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E929A0", Offset = "0x6E91BA0", VA = "0x186E929A0")]
	public void HIGNPHOLJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class FPGLPLLIKLO
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum DGJGNPALCGO
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
	public FPGLPLLIKLO DDDBGJONBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public DGJGNPALCGO BGLOFMKFAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public ICMBPOHFOHO BFEGGONKOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint CCAOFGBOAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object MMIEFPAAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int DGEANGEHICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError FJJNPHLLEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FOOIANCCMPA HPHBIHIPDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public HELPJFGFHAC FFGHENNNGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public OIPIMLNJHDO DILDJMDODAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte AOLPLNLGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly IOHNJPMHHGO HPAKNHOPIBB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B950", Offset = "0x6E8AB50", VA = "0x186E8B950")]
	public FPGLPLLIKLO(MCPGJBDJLKO OBHJPIMFHEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MCPGJBDJLKO : IEnumerable<ICMBPOHFOHO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class AOIJBKMOGHI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E88580", Offset = "0x6E87780", VA = "0x186E88580", Slot = "4")]
		public bool Equals(IPEndPoint HGCMPGNMMIB, IPEndPoint PIALGICKFLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4242AF0", Offset = "0x4241CF0", VA = "0x184242AF0", Slot = "5")]
		public int GetHashCode(IPEndPoint KFMNDOMPAMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AOIJBKMOGHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct DHNNGNHNDKH : IEnumerator<ICMBPOHFOHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ICMBPOHFOHO EFALNGJKPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private ICMBPOHFOHO OKPJGGBHILE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ICMBPOHFOHO FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xDFAF60", Offset = "0xDFA160", VA = "0x180DFAF60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xDFAF60", Offset = "0xDFA160", VA = "0x180DFAF60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AF0620", Offset = "0x1AEF820", VA = "0x181AF0620")]
		public DHNNGNHNDKH(ICMBPOHFOHO AGIIBANJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E89980", Offset = "0x6E88B80", VA = "0x186E89980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E899D0", Offset = "0x6E88BD0", VA = "0x186E899D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread KBCJIPNPJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CKBBEONOBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool HCBLMCFMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NDAHCHKAKOP NFDIAEMOOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent ALDGKILDMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<FPGLPLLIKLO> KGJAGPJCAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<FPGLPLLIKLO> GLMHAKBPCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private FPGLPLLIKLO DHEGCFIHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JDNBMNHMFAP BALGKNIHINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly HANLLFGCINB MANLEFPPBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly GMOJDJENCHH OKOKHBIHLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PDJIOPFBJOE KCCFEDIIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, ICMBPOHFOHO> GBMHCFKJNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, HELPJFGFHAC> OFBJGOLJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, JIHEECNEFAF> BJELEEAGFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim CNCAEAJAHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ICMBPOHFOHO IFJMFCMKOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int GBBNFLBOONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<ICMBPOHFOHO> KPBBLOJHPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private ICMBPOHFOHO[] EKMCJJHFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly LENCKLFFFPL MFMNBADMPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int OLFJPEAHJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> LHKCNLGKBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte OPHPGAJCMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object NHKCHDANIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MCLINACMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool KGMDMIFKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int PBNCEJJNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int LKGHLCPMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int GGIJMMLMGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int AIBFHNAEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool EJGKOOAGKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool IMGBGKMPIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KGAHGIJPEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PCNPONCGJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int JOFKAIBHICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool PBHONFCKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JECGBFBMHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool KACBNKJGDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool NDLLKGDMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int EAFEOFNBENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int FAIDKIPNECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool DANHONIMBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly DBGLAGEDAJM GHEIDNPPPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GFGIDOJPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly EINKEPAGMHL KFIJFNHHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool KMLIKCDLIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public AEELGGNHGML LGNPPEOOEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int HHLIECACNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool OPBOAPDANEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool KJMKLFONKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool AIOILIMCEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool LKIMGILMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GADDDHPCIGD BMHKDKKNIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int OJIGDAEHDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object PMGGCJEHCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private GADDDHPCIGD ACMEFGMALOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DPMENBLOJOF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int OPIDAPMCCEG = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int DAAIDGKMOKC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private FPFHFMAKKDE PBBPKFPEKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private FPFHFMAKKDE AFPCCOCGCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread NICCDIGCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread JOHKBBKMNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint BBMCFEGCIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint BPJAJOMFMFM;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] DAEAGCOJFIK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] HNIFCPGPJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<ALPNFGFBCDG, IPEndPoint> LIJEKBINBAB;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress AOHKLGKFPIA;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool EOFCJCDGNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int BHPELNONOOB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FPAOJODCBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB0DAA0", Offset = "0xB0CCA0", VA = "0x180B0DAA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB06CA0", Offset = "0xB05EA0", VA = "0x180B06CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FEHLIJKMOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1650320", Offset = "0x164F520", VA = "0x181650320")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E520", Offset = "0x1F3D720", VA = "0x181F3E520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte FMPDBDHIKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xF538C0", Offset = "0xF52AC0", VA = "0x180F538C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AKFDFFNLOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E962C0", Offset = "0x6E954C0", VA = "0x186E962C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short HPPDIMCGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E9CCB0", Offset = "0x6E9BEB0", VA = "0x186E9CCB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ICMBPOHFOHO.EIIMJLILFII DIMKAEJDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E9D690", Offset = "0x6E9C890", VA = "0x186E9D690")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C840", Offset = "0x6E9BA40", VA = "0x186E9C840")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C8F0", Offset = "0x6E9BAF0", VA = "0x186E9C8F0")]
	public void MLCFOACMAOO(IPEndPoint APGOGLNACOE, byte[] MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A7E0", Offset = "0x6E999E0", VA = "0x186E9A7E0")]
	public void GHJKMDGKKKP(IPEndPoint APGOGLNACOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B430", Offset = "0x6E9A630", VA = "0x186E9B430")]
	private bool IACDJEOLLFI(IPEndPoint APGOGLNACOE, [Out] ICMBPOHFOHO MCIFBLKNMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E981D0", Offset = "0x6E973D0", VA = "0x186E981D0")]
	private void DIFMPBLDNKL(ICMBPOHFOHO MCIFBLKNMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E969D0", Offset = "0x6E95BD0", VA = "0x186E969D0")]
	private void CAPNLOMLOPH(ICMBPOHFOHO MCIFBLKNMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E99900", Offset = "0x6E98B00", VA = "0x186E99900")]
	private void DPNICBEEAEL(ICMBPOHFOHO MCIFBLKNMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DC90", Offset = "0x6E9CE90", VA = "0x186E9DC90")]
	public MCPGJBDJLKO(JDNBMNHMFAP KIAPDCBHAGL, [Optional] LENCKLFFFPL KIOFGDMNHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CD70", Offset = "0x6E9BF70", VA = "0x186E9CD70")]
	internal void OPFCGDBBPLA(ICMBPOHFOHO DHJECJFJEBL, int ELLLLOJOHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B3E0", Offset = "0x6E9A5E0", VA = "0x186E9B3E0")]
	internal void HNAIHKPAELF(ICMBPOHFOHO DHJECJFJEBL, object GCCFFOHCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A5E0", Offset = "0x6E997E0", VA = "0x186E9A5E0")]
	internal void GBCIELIKNEI(ICMBPOHFOHO MCIFBLKNMLG, FOOIANCCMPA GBBFGBIIOBJ, SocketError ABOEIJFHOOG, GADDDHPCIGD ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E973F0", Offset = "0x6E965F0", VA = "0x186E973F0")]
	private void CPOEGHHINNC(ICMBPOHFOHO MCIFBLKNMLG, FOOIANCCMPA GBBFGBIIOBJ, SocketError ABOEIJFHOOG, bool IKLDNLEDLAC, byte[] CAIGHLKIDBF, int EIGANLKFLHL, int OCEHNHGKKJH, GADDDHPCIGD ODLIDIMANGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E9BE10", Offset = "0x6E9B010", VA = "0x186E9BE10")]
	private void JCBIFFJMOEM(FPGLPLLIKLO.DGJGNPALCGO GDHKDBJPDLG, [Optional] ICMBPOHFOHO MCIFBLKNMLG, [Optional] IPEndPoint OLPMLELCFJJ, SocketError LKKKAKAHAFI = SocketError.Success, int ELLLLOJOHAC = 0, FOOIANCCMPA IFMNLMPILOO = FOOIANCCMPA.ConnectionFailed, [Optional] HELPJFGFHAC JNMLFGPFACO, OIPIMLNJHDO AGNJIECFLMD = OIPIMLNJHDO.Unreliable, byte OEPNMLKLPLK = 0, [Optional] GADDDHPCIGD KIDDJELFCKN, [Optional] object GCCFFOHCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B650", Offset = "0x6E9A850", VA = "0x186E9B650")]
	private void IKGDLMBMCLB(FPGLPLLIKLO INMBPJOALLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C450", Offset = "0x6E9B650", VA = "0x186E9C450")]
	internal void LFGOANGHDJN(FPGLPLLIKLO INMBPJOALLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E96360", Offset = "0x6E95560", VA = "0x186E96360")]
	private void BCHLGOIKFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E966B0", Offset = "0x6E958B0", VA = "0x186E966B0")]
	private void BEAAGHIEOLK(int ELKJKBNDECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E97850", Offset = "0x6E96A50", VA = "0x186E97850")]
	internal ICMBPOHFOHO DCOPICMOEKB(HELPJFGFHAC IKFDGIFGHKP, byte[] AHMGHCGFMFO, int EIGANLKFLHL, int CLBDAFJFHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E962E0", Offset = "0x6E954E0", VA = "0x186E962E0")]
	private int AJKPLCFHFOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AF30", Offset = "0x6E9A130", VA = "0x186E9AF30")]
	private void HDBPEDKNNIB(IPEndPoint OLPMLELCFJJ, ICMBPOHFOHO HAOBLJPMCME, BNOKKAHDJLA EHDAEMNGGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E98510", Offset = "0x6E97710", VA = "0x186E98510")]
	private void DKBKCBNGCDI(GADDDHPCIGD LLAAFLHMHNL, IPEndPoint OLPMLELCFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C560", Offset = "0x6E9B760", VA = "0x186E9C560")]
	internal void LMKGJCACPFF(GADDDHPCIGD LLAAFLHMHNL, OIPIMLNJHDO HHDOKFFBPDP, byte OEPNMLKLPLK, int JOOHGDDDKMC, ICMBPOHFOHO DHJECJFJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D620", Offset = "0x6E9C820", VA = "0x186E9D620")]
	public bool PDKHLGCCMGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D600", Offset = "0x6E9C800", VA = "0x186E9D600")]
	public bool PDKHLGCCMGJ(IPAddress BENJMPADJJD, IPAddress BAIKAICEMKO, int NIKPMGAMICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CDC0", Offset = "0x6E9BFC0", VA = "0x186E9CDC0")]
	public bool PDKHLGCCMGJ(int NIKPMGAMICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E98020", Offset = "0x6E97220", VA = "0x186E98020")]
	public void DGIKIOIOFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AD70", Offset = "0x6E99F70", VA = "0x186E9AD70")]
	public ICMBPOHFOHO HDAGGGDMJEH(string LLDMMKAFIPA, int NIKPMGAMICH, string MHDODBCCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AE50", Offset = "0x6E9A050", VA = "0x186E9AE50")]
	public ICMBPOHFOHO HDAGGGDMJEH(string LLDMMKAFIPA, int NIKPMGAMICH, IDLIFIOADPE GDMNBFHPBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A990", Offset = "0x6E99B90", VA = "0x186E9A990")]
	public ICMBPOHFOHO HDAGGGDMJEH(IPEndPoint LBPEJPMBIKP, IDLIFIOADPE GDMNBFHPBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DAA0", Offset = "0x6E9CCA0", VA = "0x186E9DAA0")]
	public void PPEMLMAHDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E9D740", Offset = "0x6E9C940", VA = "0x186E9D740")]
	public void PPEMLMAHDBI(bool AJJKAONHHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A530", Offset = "0x6E99730", VA = "0x186E9A530")]
	public void GACAAENPKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A460", Offset = "0x6E99660", VA = "0x186E9A460")]
	public void GACAAENPKAE(byte[] CAIGHLKIDBF, int EIGANLKFLHL, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E97810", Offset = "0x6E96A10", VA = "0x186E97810")]
	public void CPOEGHHINNC(ICMBPOHFOHO MCIFBLKNMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E973B0", Offset = "0x6E965B0", VA = "0x186E973B0")]
	public void CPOEGHHINNC(ICMBPOHFOHO MCIFBLKNMLG, byte[] CAIGHLKIDBF, int EIGANLKFLHL, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DAB0", Offset = "0x6E9CCB0", VA = "0x186E9DAB0", Slot = "4")]
	private IEnumerator<ICMBPOHFOHO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DB40", Offset = "0x6E9CD40", VA = "0x186E9DB40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A620", Offset = "0x6E99820", VA = "0x186E9A620")]
	private GADDDHPCIGD GCEOMEIEGAG(GDONLLNCIHG MEGAJPAELNI, int GCFCAGDGDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A700", Offset = "0x6E99900", VA = "0x186E9A700")]
	private GADDDHPCIGD GCEOMEIEGAG(GDONLLNCIHG MEGAJPAELNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A220", Offset = "0x6E99420", VA = "0x186E9A220")]
	internal GADDDHPCIGD ELOEJHEGMEE(int GCFCAGDGDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E9C1F0", Offset = "0x6E9B3F0", VA = "0x186E9C1F0")]
	internal void JNAPIBGDAPL(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DBD0", Offset = "0x6E9CDD0", VA = "0x186E9DBD0")]
	static MCPGJBDJLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xB0DAA0", Offset = "0xB0CCA0", VA = "0x180B0DAA0")]
	private bool GDGBNFIFMKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CB30", Offset = "0x6E9BD30", VA = "0x186E9CB30")]
	private void NGJNCMGGEPG(IPEndPoint EICOLHPBOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E96A30", Offset = "0x6E95C30", VA = "0x186E96A30")]
	private void CDIBBBDELCL(IPEndPoint EICOLHPBOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E97E70", Offset = "0x6E97070", VA = "0x186E97E70")]
	private bool DFDMBLABNHE(SocketException JNDFFCAMALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CB10", Offset = "0x6E9BD10", VA = "0x186E9CB10")]
	private void NFEEPHKKLNM(NDAHCHKAKOP PHELJHIHIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E99BD0", Offset = "0x6E98DD0", VA = "0x186E99BD0")]
	private void EAIKDLIACNM(FPFHFMAKKDE PHELJHIHIMJ, EndPoint NIDAIGMBPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E99EA0", Offset = "0x6E990A0", VA = "0x186E99EA0")]
	private void ELCAACLECHK(object CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9CE40", Offset = "0x6E9C040", VA = "0x186E9CE40")]
	public bool PDKHLGCCMGJ(IPAddress BENJMPADJJD, IPAddress BAIKAICEMKO, int NIKPMGAMICH, bool MCLLKLCEGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A930", Offset = "0x6E99B30", VA = "0x186E9A930")]
	internal int GJBLFHMCIIK(GADDDHPCIGD LLAAFLHMHNL, IPEndPoint OLPMLELCFJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E96B90", Offset = "0x6E95D90", VA = "0x186E96B90")]
	internal int CGIHCOLPILD(GADDDHPCIGD LLAAFLHMHNL, IPEndPoint OLPMLELCFJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E96BD0", Offset = "0x6E95DD0", VA = "0x186E96BD0")]
	internal int CGIHCOLPILD(byte[] NPEJLHCJPAI, int EIGANLKFLHL, int CLBDAFJFHFB, IPEndPoint OLPMLELCFJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E9B4D0", Offset = "0x6E9A6D0", VA = "0x186E9B4D0")]
	internal void IBOMLJBDLOD(bool EDDIDEBMJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum GDONLLNCIHG : byte
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
internal sealed class GADDDHPCIGD
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int BLCLIDAJNDN;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] POIMILENPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] NGPJMFBDAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int BBPOBHNIEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object MMIEFPAAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public GADDDHPCIGD DDDBGJONBHF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GDONLLNCIHG DJMDDAMJOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BD80", Offset = "0x6E8AF80", VA = "0x186E8BD80")]
		get
		{
			return default(GDONLLNCIHG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BD40", Offset = "0x6E8AF40", VA = "0x186E8BD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EPFEOMHPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BDB0", Offset = "0x6E8AFB0", VA = "0x186E8BDB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BA30", Offset = "0x6E8AC30", VA = "0x186E8BA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort JEFNMKBJBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BF70", Offset = "0x6E8B170", VA = "0x186E8BF70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BC00", Offset = "0x6E8AE00", VA = "0x186E8BC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IMAGNLICJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BBD0", Offset = "0x6E8ADD0", VA = "0x186E8BBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte NHAOELDEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BB40", Offset = "0x6E8AD40", VA = "0x186E8BB40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BB10", Offset = "0x6E8AD10", VA = "0x186E8BB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort GLJOKAAJNLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BB70", Offset = "0x6E8AD70", VA = "0x186E8BB70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BAD0", Offset = "0x6E8ACD0", VA = "0x186E8BAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort FLBPNAADCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BA70", Offset = "0x6E8AC70", VA = "0x186E8BA70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B9F0", Offset = "0x6E8ABF0", VA = "0x186E8B9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort MPIOCJMNOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BE10", Offset = "0x6E8B010", VA = "0x186E8BE10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BFD0", Offset = "0x6E8B1D0", VA = "0x186E8BFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C010", Offset = "0x6E8B210", VA = "0x186E8C010")]
	static GADDDHPCIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BDE0", Offset = "0x6E8AFE0", VA = "0x186E8BDE0")]
	public void KGPJEOOAAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C2D0", Offset = "0x6E8B4D0", VA = "0x186E8C2D0")]
	public GADDDHPCIGD(int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C340", Offset = "0x6E8B540", VA = "0x186E8C340")]
	public GADDDHPCIGD(GDONLLNCIHG MEGAJPAELNI, int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BE70", Offset = "0x6E8B070", VA = "0x186E8BE70")]
	public static int LJGDDBAMIKG(GDONLLNCIHG MEGAJPAELNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BEE0", Offset = "0x6E8B0E0", VA = "0x186E8BEE0")]
	public int LJGDDBAMIKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BC40", Offset = "0x6E8AE40", VA = "0x186E8BC40")]
	public bool EEKDMDNDHJF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum EKGOPHKDNGA : byte
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
internal enum FPCLHPHGIBJ
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
internal enum PBNMADNJEJN
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum CADKHOPEACG
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class ICMBPOHFOHO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NGGFNKEJLHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GADDDHPCIGD[] ICAHMAPHPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int EJMPJPIJPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int OGIBHONBELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte NHAOELDEPDA;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NGGFNKEJLHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void EIIMJLILFII(ulong JDGLDBNIPPO, int PAABGBAPCNA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int DKOEPEKEBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KEJMAHLIPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int CIICJAKHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double JNDLAJLFCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int CNGJOPBODNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int GGAENAGCIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int BGKAGBIDEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch PONCAGCMILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int PFNJLEHNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long MBJCIBCIILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object LEJAJJEMGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal ICMBPOHFOHO MKOBLJLDAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal ICMBPOHFOHO LFKMLNDBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<GADDDHPCIGD> KFICCEDDFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<OOEIBEFFCJN> PKPAEMFEMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly OOEIBEFFCJN[] MHIGDJNGFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int GEAJIJFILHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int OMFLLGDAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool GMGPNDNPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int BNJCCOGBDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int CKDGKAECNOL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int FKPFNLKCKBK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int MIOLNPGLFMJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object OPDFCFKCDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int FOJEAJDPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, NGGFNKEJLHD> OAJLPHOGPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> ELODIEJDBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly GADDDHPCIGD EKMENIPAKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HBKFOCGBFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int GCGBDEICPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint KNIJJJFJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LFOMONAJGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int LIOLOKNBNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long FINEIMADOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte EDEPJDNPEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private EKGOPHKDNGA CHIMCOMJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private GADDDHPCIGD LKFJOONHPEC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int AIAPIIBBEOE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int DMOPOCOOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly GADDDHPCIGD DLPEBNLOCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly GADDDHPCIGD EENLDDDIOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly GADDDHPCIGD FJJFJOFNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly GADDDHPCIGD CADGPAHMDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NNFGAFAJKHA BAKCPPLBPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly MCPGJBDJLKO ICPAEGGOGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int HHPKMABLCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object CEGNDFCFEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly DBGLAGEDAJM GHEIDNPPPHK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte GLAPLMLCJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xB1C090", Offset = "0xB1B290", VA = "0x180B1C090")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F320", Offset = "0x6E8E520", VA = "0x186E8F320")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint KCKPBPLBJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA90A30", Offset = "0xA8FC30", VA = "0x180A90A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EKGOPHKDNGA BHOMBMOFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xC067E0", Offset = "0xC059E0", VA = "0x180C067E0")]
		get
		{
			return default(EKGOPHKDNGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long DFMKDGILDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA071D0", Offset = "0xA063D0", VA = "0x180A071D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BJNGDAEJILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1650320", Offset = "0x164F520", VA = "0x181650320")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E520", Offset = "0x1F3D720", VA = "0x181F3E520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int NNHGHOBJFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E8D700", Offset = "0x6E8C900", VA = "0x186E8D700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JFABBGLEDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xC535A0", Offset = "0xC527A0", VA = "0x180C535A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double EEHMAJNMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67D0A00", Offset = "0x67CFC00", VA = "0x1867D0A00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EIIMJLILFII DIMKAEJDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E90E40", Offset = "0x6E90040", VA = "0x186E90E40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E90C40", Offset = "0x6E8FE40", VA = "0x186E90C40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E90F30", Offset = "0x6E90130", VA = "0x186E90F30")]
	internal ICMBPOHFOHO(MCPGJBDJLKO FEPADGDKGCG, IPEndPoint OLPMLELCFJJ, int APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F0D0", Offset = "0x6E8E2D0", VA = "0x186E8F0D0")]
	internal void DEMBGHCEFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E903F0", Offset = "0x6E8F5F0", VA = "0x186E903F0")]
	internal void JMMJFDIEDPL(IPEndPoint NBJGELLEEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E90420", Offset = "0x6E8F620", VA = "0x186E90420")]
	internal void KCBPKOPFNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E904B0", Offset = "0x6E8F6B0", VA = "0x186E904B0")]
	private void KFLAJEEKFKB(int HPCNMNJKFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E90EF0", Offset = "0x6E900F0", VA = "0x186E90EF0")]
	private void PPJAEPJNDKJ(int CLBLHPBKONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F0F0", Offset = "0x6E8E2F0", VA = "0x186E8F0F0")]
	public int DJDPEIINDDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F200", Offset = "0x6E8E400", VA = "0x186E8F200")]
	public int DJDPEIINDDG(byte OEPNMLKLPLK, bool MDHAECHIBOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E8EF20", Offset = "0x6E8E120", VA = "0x186E8EF20")]
	private OOEIBEFFCJN CPCDOMFGFFB(byte CIAPLOIMNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E91560", Offset = "0x6E90760", VA = "0x186E91560")]
	internal ICMBPOHFOHO(MCPGJBDJLKO FEPADGDKGCG, IPEndPoint OLPMLELCFJJ, int APBCLGNDGBE, byte HAIKNPOIIHF, IDLIFIOADPE IPJEOECKOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E91380", Offset = "0x6E90580", VA = "0x186E91380")]
	internal ICMBPOHFOHO(MCPGJBDJLKO FEPADGDKGCG, HELPJFGFHAC IKFDGIFGHKP, int APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F740", Offset = "0x6E8E940", VA = "0x186E8F740")]
	internal void EOHAIIHBCPP(BNOKKAHDJLA DJPLPDLGHOF, byte[] CAIGHLKIDBF, int EIGANLKFLHL, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E900F0", Offset = "0x6E8F2F0", VA = "0x186E900F0")]
	internal bool HDNJILNEKHD(NJEJILAOAPB LLAAFLHMHNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E90170", Offset = "0x6E8F370", VA = "0x186E90170")]
	public void HEKPIJMPPOA(byte[] CAIGHLKIDBF, int EIGANLKFLHL, int CLBDAFJFHFB, OIPIMLNJHDO AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D750", Offset = "0x6E8C950", VA = "0x186E8D750")]
	private void BFEDEHCIPEL(byte[] CAIGHLKIDBF, int EIGANLKFLHL, int CLBDAFJFHFB, byte OEPNMLKLPLK, OIPIMLNJHDO AGNJIECFLMD, object GCCFFOHCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E903A0", Offset = "0x6E8F5A0", VA = "0x186E903A0")]
	public void IOGJEEFFPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F790", Offset = "0x6E8E990", VA = "0x186E8F790")]
	internal PBNMADNJEJN FKMJBAEBFJB(GADDDHPCIGD LLAAFLHMHNL)
	{
		return default(PBNMADNJEJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F3D0", Offset = "0x6E8E5D0", VA = "0x186E8F3D0")]
	internal void ELBCBABCFGP(OOEIBEFFCJN BOFJJFBILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F430", Offset = "0x6E8E630", VA = "0x186E8F430")]
	internal CADKHOPEACG EMBODHNOPDE(byte[] CAIGHLKIDBF, int EIGANLKFLHL, int CLBDAFJFHFB, bool IKLDNLEDLAC)
	{
		return default(CADKHOPEACG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D710", Offset = "0x6E8C910", VA = "0x186E8D710")]
	private void BDMJIKHGEEH(int INNPLKHGGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E580", Offset = "0x6E8D780", VA = "0x186E8E580")]
	internal void CLGPGGOKMGN(OIPIMLNJHDO HHDOKFFBPDP, GADDDHPCIGD AGIIBANJIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E020", Offset = "0x6E8D220", VA = "0x186E8E020")]
	private void CANFMENJENL(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D370", Offset = "0x6E8C570", VA = "0x186E8D370")]
	private void AIIDACOJJBJ(int IDFEGEHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FF30", Offset = "0x6E8F130", VA = "0x186E8FF30")]
	internal FPCLHPHGIBJ HDBPEDKNNIB(BNOKKAHDJLA EHDAEMNGGAP)
	{
		return default(FPCLHPHGIBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E8F870", Offset = "0x6E8EA70", VA = "0x186E8F870")]
	internal void HBCGHOFAGNA(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E90CF0", Offset = "0x6E8FEF0", VA = "0x186E90CF0")]
	private void OHEAPHCOFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E901A0", Offset = "0x6E8F3A0", VA = "0x186E901A0")]
	internal void IJFKJFCNNOP(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E90580", Offset = "0x6E8F780", VA = "0x186E90580")]
	internal void KJFMNLEBHBJ(int IDFEGEHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DD60", Offset = "0x6E8CF60", VA = "0x186E8DD60")]
	internal void BGKDNEOHMMM(GADDDHPCIGD LLAAFLHMHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DBGLAGEDAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long APDJLOEHPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long GMBALMFPJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long NABGOINKOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long ADEPBLBGJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CJAMIFBKJJL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long CIIOOGCKDHK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long IKGOMHKCAGE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long JLEAPLAHAMM;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long NEDMAMGKLBP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long IKEGPLHJEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long MDHPMJCANNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long KEOCHLHMKHP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FECBJKHKFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E893F0", Offset = "0x6E885F0", VA = "0x186E893F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long AAAOJFIEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E892F0", Offset = "0x6E884F0", VA = "0x186E892F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long LEFJGNHDDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E89590", Offset = "0x6E88790", VA = "0x186E89590")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LPDJOHAPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E89400", Offset = "0x6E88600", VA = "0x186E89400")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long BENMHIGMJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E89610", Offset = "0x6E88810", VA = "0x186E89610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long HDNEHMDKCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E894B0", Offset = "0x6E886B0", VA = "0x186E894B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long PHPJKGOOJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E89410", Offset = "0x6E88610", VA = "0x186E89410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long CPOLMEEEMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E89210", Offset = "0x6E88410", VA = "0x186E89210")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private NNFGAFAJKHA LAGFFOBJIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E89520", Offset = "0x6E88720", VA = "0x186E89520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double KCPFDPELOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E89450", Offset = "0x6E88650", VA = "0x186E89450")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E892B0", Offset = "0x6E884B0", VA = "0x186E892B0")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E894C0", Offset = "0x6E886C0", VA = "0x186E894C0")]
	public void LIONKDAPKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E89300", Offset = "0x6E88500", VA = "0x186E89300")]
	public void HIEFELBHEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E891B0", Offset = "0x6E883B0", VA = "0x186E891B0")]
	public void BGJNHFIFHDH(long EAMHANACMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E89530", Offset = "0x6E88730", VA = "0x186E89530")]
	public void NBNPLHFFMFL(long LKDGEAIAEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E89250", Offset = "0x6E88450", VA = "0x186E89250")]
	public void DGAOIFPBLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E895A0", Offset = "0x6E887A0", VA = "0x186E895A0")]
	public void OKJFLCKGAFA(long ILIBABGIEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E89620", Offset = "0x6E88820", VA = "0x186E89620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E89350", Offset = "0x6E88550", VA = "0x186E89350")]
	public void HODMLAOIHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DBGLAGEDAJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BCLGHPLPBKI
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> OECBCDDALCN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E88880", Offset = "0x6E87A80", VA = "0x186E88880")]
	public static IPEndPoint PMJBOOCPBKM(string PGNGJAIMLGG, int NIKPMGAMICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E88680", Offset = "0x6E87880", VA = "0x186E88680")]
	public static IPAddress FLBJNHOGDCM(string PGNGJAIMLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E885F0", Offset = "0x6E877F0", VA = "0x186E885F0")]
	public static IPAddress FLBJNHOGDCM(string PGNGJAIMLGG, AddressFamily MNIGNEFKCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E88850", Offset = "0x6E87A50", VA = "0x186E88850")]
	internal static int FMKJPGANBCN(int KACABKJBKLK, int LGBMMPNMMGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3788C70", Offset = "0x3787E70", VA = "0x183788C70")]
	internal static T[] GFICHKOBNHL<T>(int OCEHNHGKKJH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ADAFEHOPCPL : OOEIBEFFCJN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct BOGMMJGOCND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private GADDDHPCIGD NMPOAHKHJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long BPNLNPPBJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool IOBHEFACNJA;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6E89110", Offset = "0x6E88310", VA = "0x186E89110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6E89030", Offset = "0x6E88230", VA = "0x186E89030")]
		public void IJDFNMPLFGP(GADDDHPCIGD LLAAFLHMHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E89050", Offset = "0x6E88250", VA = "0x186E89050")]
		public bool KGDEFDPELGA(long GFNHPMDGFHA, ICMBPOHFOHO MCIFBLKNMLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E890C0", Offset = "0x6E882C0", VA = "0x186E890C0")]
		public bool OLKFAGPLGGN(ICMBPOHFOHO MCIFBLKNMLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GADDDHPCIGD KELOOFAKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly BOGMMJGOCND[] NLPNBPGKONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly GADDDHPCIGD[] LOKEKKCEEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] NPFCNIHLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HPOFAAJBPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int CBKFHCEKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int ECDAEMENBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int LOEEGECFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool JCHCIFFFHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly OIPIMLNJHDO CPBCGGJKPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool DFLLLJBFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int NBJPAIMIHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte GEGMIEHMEBE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HPAODEGONMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E87BB0", Offset = "0x6E86DB0", VA = "0x186E87BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E87F80", Offset = "0x6E87180", VA = "0x186E87F80")]
	public ADAFEHOPCPL(ICMBPOHFOHO MCIFBLKNMLG, bool MDHAECHIBOI, byte APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E87BC0", Offset = "0x6E86DC0", VA = "0x186E87BC0")]
	private void PCKMBLECNPB(GADDDHPCIGD LLAAFLHMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E87080", Offset = "0x6E86280", VA = "0x186E87080", Slot = "4")]
	protected override bool DJJKIONEAJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E87550", Offset = "0x6E86750", VA = "0x186E87550", Slot = "5")]
	public override bool HBCGHOFAGNA(GADDDHPCIGD LLAAFLHMHNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FCMPNKBEAEH : OOEIBEFFCJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int OEEBLMOPAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort CBKFHCEKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool NGKOLGDILEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private GADDDHPCIGD AEKELEJDFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly GADDDHPCIGD FBPDLPKFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool OLCJOIOMPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte GEGMIEHMEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long KKFNDGDNKKN;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B7C0", Offset = "0x6E8A9C0", VA = "0x186E8B7C0")]
	public FCMPNKBEAEH(ICMBPOHFOHO MCIFBLKNMLG, bool HGNDLDCIIGJ, byte APBCLGNDGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B020", Offset = "0x6E8A220", VA = "0x186E8B020", Slot = "4")]
	protected override bool DJJKIONEAJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E8B4E0", Offset = "0x6E8A6E0", VA = "0x186E8B4E0", Slot = "5")]
	public override bool HBCGHOFAGNA(GADDDHPCIGD LLAAFLHMHNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HBLJICADPEJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NMPHCGIJNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong GAHIHCHHHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double NHLAPEPDMIK;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct EAABMFFLHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int GAHBDHKJIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float FAABAOALAMC;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E86AA0", Offset = "0x6E85CA0", VA = "0x186E86AA0")]
	private static void JIOOIEEIOID(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, ulong CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0F0", Offset = "0x6E8C2F0", VA = "0x186E8D0F0")]
	private static void JIOOIEEIOID(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, int CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0B0", Offset = "0x6E8C2B0", VA = "0x186E8D0B0")]
	public static void JIOOIEEIOID(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, short CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D160", Offset = "0x6E8C360", VA = "0x186E8D160")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, double KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D190", Offset = "0x6E8C390", VA = "0x186E8D190")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0B0", Offset = "0x6E8C2B0", VA = "0x186E8D0B0")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, short KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0B0", Offset = "0x6E8C2B0", VA = "0x186E8D0B0")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, ushort KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0F0", Offset = "0x6E8C2F0", VA = "0x186E8D0F0")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D0F0", Offset = "0x6E8C2F0", VA = "0x186E8D0F0")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, uint KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D180", Offset = "0x6E8C380", VA = "0x186E8D180")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D180", Offset = "0x6E8C380", VA = "0x186E8D180")]
	public static void GFLHHLMAOAH(byte[] DJMFMHNIFDE, int KOKMPCAPCJD, ulong KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GIGJCJOPBCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] FCHBBBIIPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int MNDHAPNMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int FPHKFDMLPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int FAFHPFJEEJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] NGPJMFBDAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HKPOKDMLPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int ANCBNODFHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C9F0", Offset = "0x6E8BBF0", VA = "0x186E8C9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DJBKJPECICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2778730", Offset = "0x2777930", VA = "0x182778730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int EAFHLFKGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C920", Offset = "0x6E8BB20", VA = "0x186E8C920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C9B0", Offset = "0x6E8BBB0", VA = "0x186E8C9B0")]
	public void HHELLKIELAO(byte[] MLMPPNLIAEF, int GJBFKFHLHKP, int FOKJKCDCBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GIGJCJOPBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E8D050", Offset = "0x6E8C250", VA = "0x186E8D050")]
	public GIGJCJOPBCG(byte[] MLMPPNLIAEF, int GJBFKFHLHKP, int FOKJKCDCBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CCF0", Offset = "0x6E8BEF0", VA = "0x186E8CCF0")]
	public IPEndPoint OLBNBHGFPLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C710", Offset = "0x6E8B910", VA = "0x186E8C710")]
	public byte CGPEICBOMBO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C710", Offset = "0x6E8B910", VA = "0x186E8C710")]
	public sbyte FPANPNAEKFB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A07EE0", Offset = "0x3A070E0", VA = "0x183A07EE0")]
	public T[] HDDBJEBENOG<T>(ushort GCFCAGDGDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C870", Offset = "0x6E8BA70", VA = "0x186E8C870")]
	public bool[] ECMFHNOKPCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C930", Offset = "0x6E8BB30", VA = "0x186E8C930")]
	public ushort[] GHPLCAAGFFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CCB0", Offset = "0x6E8BEB0", VA = "0x186E8CCB0")]
	public short[] ODFOEDNIMJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CAE0", Offset = "0x6E8BCE0", VA = "0x186E8CAE0")]
	public int[] MALNIDFAJMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C750", Offset = "0x6E8B950", VA = "0x186E8C750")]
	public uint[] CKIMEHCOIAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C970", Offset = "0x6E8BB70", VA = "0x186E8C970")]
	public float[] GLPDOALDIAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CC00", Offset = "0x6E8BE00", VA = "0x186E8CC00")]
	public double[] OBLBNAHGHAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C6D0", Offset = "0x6E8B8D0", VA = "0x186E8C6D0")]
	public long[] CDOEPLNHPDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C450", Offset = "0x6E8B650", VA = "0x186E8C450")]
	public ulong[] AICJHHKOEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C580", Offset = "0x6E8B780", VA = "0x186E8C580")]
	public string[] CCCGJOOJOPA(int PABDPLOIAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C540", Offset = "0x6E8B740", VA = "0x186E8C540")]
	public bool BDLKADGHCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C800", Offset = "0x6E8BA00", VA = "0x186E8C800")]
	public char PGHNNBFOEDO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C800", Offset = "0x6E8BA00", VA = "0x186E8C800")]
	public ushort DMLAHDECMCF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C8B0", Offset = "0x6E8BAB0", VA = "0x186E8C8B0")]
	public short EPABKIJKMMN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CC40", Offset = "0x6E8BE40", VA = "0x186E8CC40")]
	public long OCPCKMDPLJA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CB90", Offset = "0x6E8BD90", VA = "0x186E8CB90")]
	public ulong NNHOEKNONAI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C490", Offset = "0x6E8B690", VA = "0x186E8C490")]
	public int AKGHOIPMPDH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CB20", Offset = "0x6E8BD20", VA = "0x186E8CB20")]
	public uint NCCPMIBMJEL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C790", Offset = "0x6E8B990", VA = "0x186E8C790")]
	public float DILGGDLCEJF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CA00", Offset = "0x6E8BC00", VA = "0x186E8CA00")]
	public double HMHHNKHHPOD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CE20", Offset = "0x6E8C020", VA = "0x186E8CE20")]
	public string POIECIFKOOP(int CLCGGINKCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CA70", Offset = "0x6E8BC70", VA = "0x186E8CA70")]
	public ArraySegment<byte> IMIKIEJLHME(int OCEHNHGKKJH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CDE0", Offset = "0x6E8BFE0", VA = "0x186E8CDE0")]
	public sbyte[] PJFEFCGAHEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6E8C500", Offset = "0x6E8B700", VA = "0x186E8C500")]
	public byte[] BBANALPGCDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E8CDC0", Offset = "0x6E8BFC0", VA = "0x186E8CDC0")]
	public void OLKFAGPLGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IDLIFIOADPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] FCHBBBIIPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int MNDHAPNMOJJ;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int GALPNLJKKFF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool PCNODBFMKGK;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding EOKFKNIHOLH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int HIJECLGGFHN = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] PDLKNJBFHND;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] OCEAHOAJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E928B0", Offset = "0x6E91AB0", VA = "0x186E928B0")]
	public IDLIFIOADPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E92810", Offset = "0x6E91A10", VA = "0x186E92810")]
	public IDLIFIOADPE(bool LKOBEFICHNI, int OCGAHFPGGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E91B90", Offset = "0x6E90D90", VA = "0x186E91B90")]
	public static IDLIFIOADPE EDBCKBKCNGE(string KJIOHKMJAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E91AF0", Offset = "0x6E90CF0", VA = "0x186E91AF0")]
	public void EBFFNLFBADN(int IPOAODEDPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x27F1F60", Offset = "0x27F1160", VA = "0x1827F1F60")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E926F0", Offset = "0x6E918F0", VA = "0x186E926F0")]
	public void KOIKFALHPDA(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E92140", Offset = "0x6E91340", VA = "0x186E92140")]
	public void KOIKFALHPDA(double KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E923A0", Offset = "0x6E915A0", VA = "0x186E923A0")]
	public void KOIKFALHPDA(long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E923A0", Offset = "0x6E915A0", VA = "0x186E923A0")]
	public void KOIKFALHPDA(ulong KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E923F0", Offset = "0x6E915F0", VA = "0x186E923F0")]
	public void KOIKFALHPDA(int KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E923F0", Offset = "0x6E915F0", VA = "0x186E923F0")]
	public void KOIKFALHPDA(uint KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E92330", Offset = "0x6E91530", VA = "0x186E92330")]
	public void KOIKFALHPDA(char KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E92330", Offset = "0x6E91530", VA = "0x186E92330")]
	public void KOIKFALHPDA(ushort KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6E92330", Offset = "0x6E91530", VA = "0x186E92330")]
	public void KOIKFALHPDA(short KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E92200", Offset = "0x6E91400", VA = "0x186E92200")]
	public void KOIKFALHPDA(sbyte KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6E92200", Offset = "0x6E91400", VA = "0x186E92200")]
	public void KOIKFALHPDA(byte KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E92190", Offset = "0x6E91390", VA = "0x186E92190")]
	public void KOIKFALHPDA(byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E92050", Offset = "0x6E91250", VA = "0x186E92050")]
	public void IOCFGPFFELB(sbyte[] CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E92050", Offset = "0x6E91250", VA = "0x186E92050")]
	public void IJEPHHJDNFJ(byte[] CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E92480", Offset = "0x6E91680", VA = "0x186E92480")]
	public void KOIKFALHPDA(bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E91CE0", Offset = "0x6E90EE0", VA = "0x186E91CE0")]
	public void EDHICGPGEBD(Array MFKIFEAAJCA, int GIFNGEODOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E91DC0", Offset = "0x6E90FC0", VA = "0x186E91DC0")]
	public void EDHICGPGEBD(float[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E91F70", Offset = "0x6E91170", VA = "0x186E91F70")]
	public void EDHICGPGEBD(double[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E91F70", Offset = "0x6E91170", VA = "0x186E91F70")]
	public void EDHICGPGEBD(long[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E91F70", Offset = "0x6E91170", VA = "0x186E91F70")]
	public void EDHICGPGEBD(ulong[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E91DC0", Offset = "0x6E90FC0", VA = "0x186E91DC0")]
	public void EDHICGPGEBD(int[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E91DC0", Offset = "0x6E90FC0", VA = "0x186E91DC0")]
	public void EDHICGPGEBD(uint[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E91C00", Offset = "0x6E90E00", VA = "0x186E91C00")]
	public void EDHICGPGEBD(ushort[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E91C00", Offset = "0x6E90E00", VA = "0x186E91C00")]
	public void EDHICGPGEBD(short[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E92050", Offset = "0x6E91250", VA = "0x186E92050")]
	public void EDHICGPGEBD(bool[] KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E91EA0", Offset = "0x6E910A0", VA = "0x186E91EA0")]
	public void EDHICGPGEBD(string[] KJIOHKMJAPE, int DMKMFMGKMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E92260", Offset = "0x6E91460", VA = "0x186E92260")]
	public void KOIKFALHPDA(IPEndPoint APGOGLNACOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E92130", Offset = "0x6E91330", VA = "0x186E92130")]
	public void KOIKFALHPDA(string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E924E0", Offset = "0x6E916E0", VA = "0x186E924E0")]
	public void KOIKFALHPDA(string KJIOHKMJAPE, int CLCGGINKCCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class KKOAGABJBOJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class OKPHONIIGMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong HHPKMABLCHL;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x561CFE0", Offset = "0x561C1E0", VA = "0x18561CFE0")]
		static OKPHONIIGMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void GMBDOJMLLCN(GIGJCJOPBCG GBOEOLHFKIL, object GCCFFOHCPGM);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NPIIPDGBOKG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public KKOAGABJBOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NPIIPDGBOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x54AF960", Offset = "0x54AEB60", VA = "0x1854AF960")]
		internal void MHPPKBHAEDO(GIGJCJOPBCG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KEKGKMEDKOP<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public KKOAGABJBOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KEKGKMEDKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x512B430", Offset = "0x512A630", VA = "0x18512B430")]
		internal void MHPPKBHAEDO(GIGJCJOPBCG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly DOKIEKCJOGA KCOLEPAMAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, GMBDOJMLLCN> ONMNDKCEPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly IDLIFIOADPE AEADNFJIGHM;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6E935A0", Offset = "0x6E927A0", VA = "0x186E935A0")]
	public KKOAGABJBOJ(int PABDPLOIAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2FA65A0", Offset = "0x2FA57A0", VA = "0x182FA65A0", Slot = "4")]
	protected virtual ulong IBADHDKCCFI<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6E93470", Offset = "0x6E92670", VA = "0x186E93470", Slot = "5")]
	protected virtual GMBDOJMLLCN PGDNLAGOCEF(GIGJCJOPBCG GBOEOLHFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB89C0", Offset = "0x3AB7BC0", VA = "0x183AB89C0", Slot = "6")]
	protected virtual void HKHPNEEOCHE<T>(IDLIFIOADPE HLPFOKGJOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6E933A0", Offset = "0x6E925A0", VA = "0x186E933A0")]
	public void GHNOMJMOAGM(GIGJCJOPBCG GBOEOLHFKIL, object GCCFFOHCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8930", Offset = "0x3AB7B30", VA = "0x183AB8930")]
	public void BOGBGKANOGB<T>(IDLIFIOADPE HLPFOKGJOHH, T LLAAFLHMHNL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E93420", Offset = "0x6E92620", VA = "0x186E93420")]
	public void JJGILBJBGPC(GIGJCJOPBCG GBOEOLHFKIL, object GCCFFOHCPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB87B0", Offset = "0x3AB79B0", VA = "0x183AB87B0")]
	public void AKMLJCMMOPA<T>(Action<T> LPMENGOACGM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8630", Offset = "0x3AB7830", VA = "0x183AB8630")]
	public void AKMLJCMMOPA<T, TUserData>(Action<T, TUserData> LPMENGOACGM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PIBAMEPDKLF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E88150", Offset = "0x6E87350", VA = "0x186E88150")]
	public PIBAMEPDKLF(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NFLOCBLLEMF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E2F0", Offset = "0x6E9D4F0", VA = "0x186E9E2F0")]
	public NFLOCBLLEMF(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DOKIEKCJOGA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum MMPLOGJOHHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class NCOLNGHHAEB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MMPLOGJOHHL BGLOFMKFAEA;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5475180", Offset = "0x5474380", VA = "0x185475180", Slot = "4")]
		public virtual void IJDFNMPLFGP(MethodInfo MMJKMDHLBAC, MethodInfo EEMNMPHPAPK, MMPLOGJOHHL GDHKDBJPDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void DLILCGICIOD(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void BELKEMFMAAM(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		protected NCOLNGHHAEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ADALKFIOPNL<TClass, TProperty> : NCOLNGHHAEB<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> EMFFBJBNCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> FBPHFNDLJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> JEOKBHPJLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> OGAEBMIIBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> IEINCBFCMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> CBDOEIEFCMB;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4E46C10", Offset = "0x4E45E10", VA = "0x184E46C10", Slot = "7")]
		public override void PDOPENAAMAJ(TClass ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4E473F0", Offset = "0x4E465F0", VA = "0x184E473F0", Slot = "8")]
		public override void PEBNODPIBGN(TClass ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4E41AF0", Offset = "0x4E40CF0", VA = "0x184E41AF0", Slot = "9")]
		public override void DLILCGICIOD(TClass ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4E40660", Offset = "0x4E3F860", VA = "0x184E40660", Slot = "10")]
		public override void BELKEMFMAAM(TClass ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4E465E0", Offset = "0x4E457E0", VA = "0x184E465E0")]
		protected TProperty[] OHEBHJLKOPF(TClass ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4E411C0", Offset = "0x4E403C0", VA = "0x184E411C0")]
		protected TProperty[] CDANOADLDDO(TClass ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E428B0", Offset = "0x4E41AB0", VA = "0x184E428B0", Slot = "4")]
		public override void IJDFNMPLFGP(MethodInfo MMJKMDHLBAC, MethodInfo EEMNMPHPAPK, MMPLOGJOHHL GDHKDBJPDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4E47D90", Offset = "0x4E46F90", VA = "0x184E47D90")]
		protected ADALKFIOPNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class OGNNKHGFFGL<TClass, TProperty> : ADALKFIOPNL<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void DJIMHKMFDOF(GIGJCJOPBCG EJNMHOGNAED, [Out] TProperty GCDFKAHICKK);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void BCKDOCKHJPB(IDLIFIOADPE MPPBNBGNIHH, TProperty GCDFKAHICKK);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5615610", Offset = "0x5614810", VA = "0x185615610", Slot = "5")]
		public override void NNHKGDAPOLJ(TClass ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5615520", Offset = "0x5614720", VA = "0x185615520", Slot = "6")]
		public override void BOGBGKANOGB(TClass ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5615730", Offset = "0x5614930", VA = "0x185615730", Slot = "7")]
		public override void PDOPENAAMAJ(TClass ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x56157D0", Offset = "0x56149D0", VA = "0x1856157D0", Slot = "8")]
		public override void PEBNODPIBGN(TClass ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x464FDA0", Offset = "0x464EFA0", VA = "0x18464FDA0")]
		protected OGNNKHGFFGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class MHFEHHOOGMC<T> : ADALKFIOPNL<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5419B10", Offset = "0x5418D10", VA = "0x185419B10", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x46E9860", Offset = "0x46E8A60", VA = "0x1846E9860", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5419B70", Offset = "0x5418D70", VA = "0x185419B70", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x46E9970", Offset = "0x46E8B70", VA = "0x1846E9970", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public MHFEHHOOGMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class ENNJPPHCKLG<T> : ADALKFIOPNL<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x46E98B0", Offset = "0x46E8AB0", VA = "0x1846E98B0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x46E9860", Offset = "0x46E8A60", VA = "0x1846E9860", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x46E9910", Offset = "0x46E8B10", VA = "0x1846E9910", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x46E9970", Offset = "0x46E8B70", VA = "0x1846E9970", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public ENNJPPHCKLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class PJHEIDHOLNH<T> : ADALKFIOPNL<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x56F5D20", Offset = "0x56F4F20", VA = "0x1856F5D20", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x56F5CD0", Offset = "0x56F4ED0", VA = "0x1856F5CD0", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x56F5D80", Offset = "0x56F4F80", VA = "0x1856F5D80", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x56F5DE0", Offset = "0x56F4FE0", VA = "0x1856F5DE0", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public PJHEIDHOLNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CBAIJBPAEMH<T> : ADALKFIOPNL<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x65EDDF0", Offset = "0x65ECFF0", VA = "0x1865EDDF0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x56F5CD0", Offset = "0x56F4ED0", VA = "0x1856F5CD0", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x65EDE50", Offset = "0x65ED050", VA = "0x1865EDE50", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x56F5DE0", Offset = "0x56F4FE0", VA = "0x1856F5DE0", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public CBAIJBPAEMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DBCPBIGJBLD<T> : ADALKFIOPNL<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x41FE890", Offset = "0x41FDA90", VA = "0x1841FE890", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x41FE840", Offset = "0x41FDA40", VA = "0x1841FE840", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x41FE8F0", Offset = "0x41FDAF0", VA = "0x1841FE8F0", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x41FE950", Offset = "0x41FDB50", VA = "0x1841FE950", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public DBCPBIGJBLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JPKNGAKAHHO<T> : ADALKFIOPNL<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5084370", Offset = "0x5083570", VA = "0x185084370", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41FE840", Offset = "0x41FDA40", VA = "0x1841FE840", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x50843D0", Offset = "0x50835D0", VA = "0x1850843D0", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41FE950", Offset = "0x41FDB50", VA = "0x1841FE950", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public JPKNGAKAHHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AGICJPPDONO<T> : ADALKFIOPNL<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E532B0", Offset = "0x4E524B0", VA = "0x184E532B0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E53260", Offset = "0x4E52460", VA = "0x184E53260", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4E53310", Offset = "0x4E52510", VA = "0x184E53310", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E53370", Offset = "0x4E52570", VA = "0x184E53370", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public AGICJPPDONO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PEOGFBOICFJ<T> : ADALKFIOPNL<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E532B0", Offset = "0x4E524B0", VA = "0x184E532B0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E53260", Offset = "0x4E52460", VA = "0x184E53260", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x56E6800", Offset = "0x56E5A00", VA = "0x1856E6800", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E53370", Offset = "0x4E52570", VA = "0x184E53370", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public PEOGFBOICFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class IJGJGMDDPHG<T> : ADALKFIOPNL<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2100", Offset = "0x4DF1300", VA = "0x184DF2100", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DF20B0", Offset = "0x4DF12B0", VA = "0x184DF20B0", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2160", Offset = "0x4DF1360", VA = "0x184DF2160", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x46E9970", Offset = "0x46E8B70", VA = "0x1846E9970", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public IJGJGMDDPHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BJHGHDMJIKK<T> : ADALKFIOPNL<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x619BDA0", Offset = "0x619AFA0", VA = "0x18619BDA0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x619BD50", Offset = "0x619AF50", VA = "0x18619BD50", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x619BE00", Offset = "0x619B000", VA = "0x18619BE00", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x41FE950", Offset = "0x41FDB50", VA = "0x1841FE950", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public BJHGHDMJIKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class JMGAMFNMNML<T> : ADALKFIOPNL<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x50774D0", Offset = "0x50766D0", VA = "0x1850774D0", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5077480", Offset = "0x5076680", VA = "0x185077480", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5077530", Offset = "0x5076730", VA = "0x185077530", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E53370", Offset = "0x4E52570", VA = "0x184E53370", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x41FE9A0", Offset = "0x41FDBA0", VA = "0x1841FE9A0")]
		public JMGAMFNMNML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class FOCCPDEKAIC<T> : OGNNKHGFFGL<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4B44690", Offset = "0x4B43890", VA = "0x184B44690", Slot = "12")]
		protected override void BCKDOCKHJPB(IDLIFIOADPE MPPBNBGNIHH, char GCDFKAHICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B446C0", Offset = "0x4B438C0", VA = "0x184B446C0", Slot = "11")]
		protected override void DJIMHKMFDOF(GIGJCJOPBCG EJNMHOGNAED, [Out] char GCDFKAHICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x462DEB0", Offset = "0x462D0B0", VA = "0x18462DEB0")]
		public FOCCPDEKAIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FFCLBGMPABG<T> : OGNNKHGFFGL<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B31200", Offset = "0x4B30400", VA = "0x184B31200", Slot = "12")]
		protected override void BCKDOCKHJPB(IDLIFIOADPE MPPBNBGNIHH, IPEndPoint GCDFKAHICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B31230", Offset = "0x4B30430", VA = "0x184B31230", Slot = "11")]
		protected override void DJIMHKMFDOF(GIGJCJOPBCG EJNMHOGNAED, [Out] IPEndPoint GCDFKAHICKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x462DEB0", Offset = "0x462D0B0", VA = "0x18462DEB0")]
		public FFCLBGMPABG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HMBGOEMCDGP<T> : ADALKFIOPNL<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int JIBMPMJBKLN;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1C40", Offset = "0x4CB0E40", VA = "0x184CB1C40")]
		public HMBGOEMCDGP(int CLCGGINKCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1B00", Offset = "0x4CB0D00", VA = "0x184CB1B00", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1AA0", Offset = "0x4CB0CA0", VA = "0x184CB1AA0", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1B70", Offset = "0x4CB0D70", VA = "0x184CB1B70", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1BE0", Offset = "0x4CB0DE0", VA = "0x184CB1BE0", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class IABEDAOMIKF<T> : NCOLNGHHAEB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo DJMDDAMJOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type JBDBFLEIIIN;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4DA15D0", Offset = "0x4DA07D0", VA = "0x184DA15D0")]
		public IABEDAOMIKF(PropertyInfo MEGAJPAELNI, Type JOMCMDJHLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1450", Offset = "0x4DA0650", VA = "0x184DA1450", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1340", Offset = "0x4DA0540", VA = "0x184DA1340", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1510", Offset = "0x4DA0710", VA = "0x184DA1510", Slot = "7")]
		public override void PDOPENAAMAJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1570", Offset = "0x4DA0770", VA = "0x184DA1570", Slot = "8")]
		public override void PEBNODPIBGN(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4DA13F0", Offset = "0x4DA05F0", VA = "0x184DA13F0", Slot = "9")]
		public override void DLILCGICIOD(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4DA12E0", Offset = "0x4DA04E0", VA = "0x184DA12E0", Slot = "10")]
		public override void BELKEMFMAAM(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class PEJFOLGINPB<T> : IABEDAOMIKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
		public PEJFOLGINPB(PropertyInfo MEGAJPAELNI, Type JOMCMDJHLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x56E6660", Offset = "0x56E5860", VA = "0x1856E6660", Slot = "5")]
		public override void NNHKGDAPOLJ(T ICMPNEPBEEM, GIGJCJOPBCG EJNMHOGNAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x56E65B0", Offset = "0x56E57B0", VA = "0x1856E65B0", Slot = "6")]
		public override void BOGBGKANOGB(T ICMPNEPBEEM, IDLIFIOADPE MPPBNBGNIHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class CGOLCNCLNPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static CGOLCNCLNPF<T> AIBLJDBPKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly NCOLNGHHAEB<T>[] OKBLIHFJGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int LIJAJBMHMKB;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67948E0", Offset = "0x6793AE0", VA = "0x1867948E0")]
		public CGOLCNCLNPF(List<NCOLNGHHAEB<T>> JEENALOHCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6794780", Offset = "0x6793980", VA = "0x186794780")]
		public void BOGBGKANOGB(T KFMNDOMPAMC, IDLIFIOADPE HLPFOKGJOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6794830", Offset = "0x6793A30", VA = "0x186794830")]
		public void NNHKGDAPOLJ(T KFMNDOMPAMC, GIGJCJOPBCG GBOEOLHFKIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class IFLCCFINJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract NCOLNGHHAEB<T> AFHCIICHJIO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private IDLIFIOADPE FNPEBFCFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int EHIOOFNFHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, IFLCCFINJFK> AKIFHLCABPJ;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E89A20", Offset = "0x6E88C20", VA = "0x186E89A20")]
	public DOKIEKCJOGA(int PABDPLOIAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3869190", Offset = "0x3868390", VA = "0x183869190")]
	private CGOLCNCLNPF<T> OPALOGOLFKK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3788D40", Offset = "0x3787F40", VA = "0x183788D40")]
	public void ELDCOJNOKAJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x38690B0", Offset = "0x38682B0", VA = "0x1838690B0")]
	public bool BHIBMPPAILM<T>(GIGJCJOPBCG GBOEOLHFKIL, T LBPEJPMBIKP) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3869130", Offset = "0x3868330", VA = "0x183869130")]
	public void ELKKKBEIKKA<T>(IDLIFIOADPE HLPFOKGJOHH, T KFMNDOMPAMC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LBOIHMBNECE
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime LPCFFGPGGLE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] JMDPAHCFOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CBMLCGKNCJF GLLLINAKPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E94590", Offset = "0x6E93790", VA = "0x186E94590")]
		get
		{
			return default(CBMLCGKNCJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int PMCILHPMELI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E93F30", Offset = "0x6E93130", VA = "0x186E93F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E94650", Offset = "0x6E93850", VA = "0x186E94650")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PPNAHLIOCKM LAJMHHDELAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E93A30", Offset = "0x6E92C30", VA = "0x186E93A30")]
		get
		{
			return default(PPNAHLIOCKM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E93A60", Offset = "0x6E92C60", VA = "0x186E93A60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JEGCMHFNGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E939A0", Offset = "0x6E92BA0", VA = "0x186E939A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint CPBCNBIIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E93720", Offset = "0x6E92920", VA = "0x186E93720")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? GHDHBDENELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E94210", Offset = "0x6E93410", VA = "0x186E94210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? HBBFPAKDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E94410", Offset = "0x6E93610", VA = "0x186E94410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? OLKOMDNHAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E94560", Offset = "0x6E93760", VA = "0x186E94560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E93B60", Offset = "0x6E92D60", VA = "0x186E93B60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? EJHFIBLKJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xE31390", Offset = "0xE30590", VA = "0x180E31390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E947A0", Offset = "0x6E939A0", VA = "0x186E947A0")]
	public LBOIHMBNECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E946F0", Offset = "0x6E938F0", VA = "0x186E946F0")]
	internal LBOIHMBNECE(byte[] DJMFMHNIFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E94440", Offset = "0x6E93640", VA = "0x186E94440")]
	public static LBOIHMBNECE NPNINPOCKEB(byte[] DJMFMHNIFDE, DateTime FFNNEOKDCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E93D30", Offset = "0x6E92F30", VA = "0x186E93D30")]
	internal void HIIKKPKPOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E94030", Offset = "0x6E93230", VA = "0x186E94030")]
	private void IMIBCKNMCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E937A0", Offset = "0x6E929A0", VA = "0x186E937A0")]
	private DateTime? DNLADEJGENA(int GJBFKFHLHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E94240", Offset = "0x6E93440", VA = "0x186E94240")]
	private void LDKIIFPCEPB(int GJBFKFHLHKP, DateTime? KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E93F60", Offset = "0x6E93160", VA = "0x186E93F60")]
	private ulong IKPMFPFNALJ(int GJBFKFHLHKP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E93AA0", Offset = "0x6E92CA0", VA = "0x186E93AA0")]
	private void FEDOLHCKGNO(int GJBFKFHLHKP, ulong KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E945C0", Offset = "0x6E937C0", VA = "0x186E945C0")]
	private uint PMGBKDGIDNE(int GJBFKFHLHKP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D52E80", Offset = "0x6D52080", VA = "0x186D52E80")]
	private static uint EJIEJGNLKNJ(uint HGCMPGNMMIB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E939D0", Offset = "0x6E92BD0", VA = "0x186E939D0")]
	private static ulong EJIEJGNLKNJ(ulong HGCMPGNMMIB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum CBMLCGKNCJF
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
public enum PPNAHLIOCKM
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class JIHEECNEFAF
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int FMFHHAIMGKM = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int ACCOAIFPKGC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int GPCEFGJNMGI = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint CCAFHBHDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int OCHJFLPPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int EEJOOCICIFM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OFBGNIPJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6E92B90", Offset = "0x6E91D90", VA = "0x186E92B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6E92AA0", Offset = "0x6E91CA0", VA = "0x186E92AA0")]
	public bool HEKPIJMPPOA(FPFHFMAKKDE PHELJHIHIMJ, int MGFEHNJFHAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class PBDECPJHJNM : FPFHFMAKKDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket PHELJHIHIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly MCPGJBDJLKO FEPADGDKGCG;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short HPPDIMCGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F040", Offset = "0x6E9E240", VA = "0x186E9F040", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int HGCGFCBEOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EFE0", Offset = "0x6E9E1E0", VA = "0x186E9EFE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint OKDHIJKJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6E9EFC0", Offset = "0x6E9E1C0", VA = "0x186E9EFC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily EBIMAHIDNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x51C8A10", Offset = "0x51C7C10", VA = "0x1851C8A10", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F060", Offset = "0x6E9E260", VA = "0x186E9F060")]
	public PBDECPJHJNM(AddressFamily MNIGNEFKCEM, MCPGJBDJLKO FEPADGDKGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EA00", Offset = "0x6E9DC00", VA = "0x186E9EA00", Slot = "8")]
	public bool GCFFPOGDJGB(IPEndPoint APGOGLNACOE, AEELGGNHGML IEAIEIDPEPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F000", Offset = "0x6E9E200", VA = "0x186E9F000", Slot = "9")]
	public int LCDDNNFCANA(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, int GCFCAGDGDIN, IPEndPoint OLPMLELCFJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E8F0", Offset = "0x6E9DAF0", VA = "0x186E9E8F0", Slot = "10")]
	public int BHKBLLHCKHA(byte[] DLBFFDJEFBK, EndPoint JNOJPPLDJON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E9E0", Offset = "0x6E9DBE0", VA = "0x186E9E9E0", Slot = "11")]
	public void DMNEHONCPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface FPFHFMAKKDE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short HPPDIMCGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int HGCGFCBEOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint OKDHIJKJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily EBIMAHIDNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GCFFPOGDJGB(IPEndPoint APGOGLNACOE, AEELGGNHGML IEAIEIDPEPI);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LCDDNNFCANA(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, int GCFCAGDGDIN, IPEndPoint OLPMLELCFJJ);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BHKBLLHCKHA(byte[] DLBFFDJEFBK, EndPoint OLPMLELCFJJ);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMNEHONCPCP();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct ALPNFGFBCDG : IEquatable<ALPNFGFBCDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long NJIIKJJPEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long AEBFOINIOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long DNJMLEGINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int GHMMIFKCIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int HONAIMGBDFK;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6E88250", Offset = "0x6E87450", VA = "0x186E88250")]
	public ALPNFGFBCDG(byte[] LLDMMKAFIPA, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6E88310", Offset = "0x6E87510", VA = "0x186E88310")]
	public ALPNFGFBCDG(Span<byte> LLDMMKAFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA29CC0", Offset = "0xA28EC0", VA = "0x180A29CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6E88210", Offset = "0x6E87410", VA = "0x186E88210", Slot = "4")]
	public bool Equals(ALPNFGFBCDG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6E88160", Offset = "0x6E87360", VA = "0x186E88160", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DHEMJNPJFMK : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] DJHGHIKOEFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NDAHCHKAKOP
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void LEMAPNIAOAE(IPEndPoint LLDMMKAFIPA, Span<byte> CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string EHDKEMKJHJG = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int AHCGFKJNFFH = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int PHMBMBOHMPL = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static Dictionary<ALPNFGFBCDG, IPEndPoint> MJAAPDKODJI;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static LEMAPNIAOAE JCDCCFEHGEN;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	internal void LIEBMJNFOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	internal void NMBOIGPBKAM(IPEndPoint OLPMLELCFJJ, Span<byte> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class LENCKLFFFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public readonly int AKFDFFNLOGO;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
	protected LENCKLFFFPL(int EEFBMKAGHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PNNBNKAIELI(IPEndPoint APGOGLNACOE, byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int CLBDAFJFHFB);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CBNJKAOKOPI(IPEndPoint APGOGLNACOE, byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int CLBDAFJFHFB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class EKGJCMHFEGO : LENCKLFFFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private byte[] MHDODBCCAJB;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly RandomNumberGenerator ILOEBFICMAP;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x28CB970", Offset = "0x28CAB70", VA = "0x1828CB970")]
	public EKGJCMHFEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A960", Offset = "0x6E89B60", VA = "0x186E8A960")]
	public void GACAOBCHBDO(IPEndPoint APGOGLNACOE, byte[] MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A880", Offset = "0x6E89A80", VA = "0x186E8A880")]
	public void CCIJILMJLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6E8AB10", Offset = "0x6E89D10", VA = "0x186E8AB10", Slot = "4")]
	public override void PNNBNKAIELI(IPEndPoint APGOGLNACOE, byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A520", Offset = "0x6E89720", VA = "0x186E8A520", Slot = "5")]
	public override void CBNJKAOKOPI(IPEndPoint APGOGLNACOE, byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int CLBDAFJFHFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct KHDFEDAFFKF
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void KLMLDBMIEEN([NoAlias] byte* OPKGDPHOEMI, [NoAlias] byte* MHDODBCCAJB, [NoAlias] byte* GPMKMKJADKJ, int CLBDAFJFHFB);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class JNHBLKKNGLP
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static IntPtr BOGHJHFAEAB;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private static IntPtr OIKCOOANJLF;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F6B0", Offset = "0x6E9E8B0", VA = "0x186E9F6B0")]
		[BurstDiscard]
		private static void MBMEIFHEKDB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F560", Offset = "0x6E9E760", VA = "0x186E9F560")]
		private static IntPtr HEMEPPFGJHH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F290", Offset = "0x6E9E490", VA = "0x186E9F290")]
		public static void BNEPLFKNHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		public static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F330", Offset = "0x6E9E530", VA = "0x186E9F330")]
		public unsafe static void CLNGLIDPKMF([NoAlias] byte* OPKGDPHOEMI, [NoAlias] byte* MHDODBCCAJB, [NoAlias] byte* GPMKMKJADKJ, int CLBDAFJFHFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint MHDODBCCAJB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint GPMKMKJADKJ[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint OMDPBLNGKPA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint BAGMEHAHCFM[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint AJMCIAOLJAG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint OGOACAJDPDG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint GGDKIHDHNGI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private uint JEAAFNNBABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint IIOHDNMHIHG[8];

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6E92BA0", Offset = "0x6E91DA0", VA = "0x186E92BA0")]
	private void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6E92C20", Offset = "0x6E91E20", VA = "0x186E92C20")]
	private uint ECADPGCJCEE(uint JIKDBGFICJD, int MIPKGJBPBDC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6E86ED0", Offset = "0x6E860D0", VA = "0x186E86ED0")]
	private void LFNMENPAKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6E86C30", Offset = "0x6E85E30", VA = "0x186E86C30")]
	private void KAEAIGJDJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6E86E40", Offset = "0x6E86040", VA = "0x186E86E40")]
	private void LFBOHOIBCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6E86F80", Offset = "0x6E86180", VA = "0x186E86F80")]
	private void NLDFHBCBAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6E93170", Offset = "0x6E92370", VA = "0x186E93170")]
	private void HKBADJDFCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6E92C50", Offset = "0x6E91E50", VA = "0x186E92C50")]
	private unsafe void GMHPLOHDCLC(byte* OPKGDPHOEMI, uint* MHDODBCCAJB, uint* GPMKMKJADKJ, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6E931D0", Offset = "0x6E923D0", VA = "0x186E931D0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LFKNMGIMAAG([NoAlias] byte* OPKGDPHOEMI, [NoAlias] byte* MHDODBCCAJB, [NoAlias] byte* GPMKMKJADKJ, int CLBDAFJFHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6E93250", Offset = "0x6E92450", VA = "0x186E93250")]
	public static void LFKNMGIMAAG(Span<byte> OPKGDPHOEMI, Span<byte> MHDODBCCAJB, Span<byte> GPMKMKJADKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6E93070", Offset = "0x6E92270", VA = "0x186E93070")]
	public static void HIBGGMLGMEN(Span<byte> OPKGDPHOEMI, Span<byte> MHDODBCCAJB, Span<byte> GPMKMKJADKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6E93330", Offset = "0x6E92530", VA = "0x186E93330")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NNLLIDPKIFH([NoAlias] byte* OPKGDPHOEMI, [NoAlias] byte* MHDODBCCAJB, [NoAlias] byte* GPMKMKJADKJ, int CLBDAFJFHFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F8D0", Offset = "0x6E9EAD0", VA = "0x186E9F8D0")]
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
