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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LKGPKNACPLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum MDPBBHGCMIN
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
		private NetworkManager IBNFHGFPHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, HCDPBHEBNAM> EDIMAJLPLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GFLHNGHENMJ PGEDNHOLNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] HANGNOPEDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MDPBBHGCMIN DFCCEPFPFOK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong PPMMMKIODIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LPAJIBNIJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5471730", Offset = "0x5470130", VA = "0x185471730", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5470C30", Offset = "0x546F630", VA = "0x185470C30")]
		public void RecRoom_SetEncryptionInfo(ulong GBJDBAGDEIC, byte[] KCGLPAPOILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5470C10", Offset = "0x546F610", VA = "0x185470C10")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5470AE0", Offset = "0x546F4E0", VA = "0x185470AE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5471630", Offset = "0x5470030", VA = "0x185471630")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5470E30", Offset = "0x546F830", VA = "0x185470E30", Slot = "6")]
		public override void Send(ulong EMIGCANIBKN, ArraySegment<byte> MFNOAEFOKBK, NetworkDelivery CPAHFAKOHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5470BD0", Offset = "0x546F5D0", VA = "0x185470BD0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong EMIGCANIBKN, [Out] ArraySegment<byte> MBIDFLHPHHK, [Out] float CBDFIFEPAGI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5471120", Offset = "0x546FB20", VA = "0x185471120", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5471550", Offset = "0x546FF50", VA = "0x185471550", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x54702B0", Offset = "0x546ECB0", VA = "0x1854702B0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong EMIGCANIBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5470160", Offset = "0x546EB60", VA = "0x185470160", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5470420", Offset = "0x546EE20", VA = "0x185470420", Slot = "12")]
		public override ulong GetCurrentRtt(ulong EMIGCANIBKN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x54710B0", Offset = "0x546FAB0", VA = "0x1854710B0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x54704C0", Offset = "0x546EEC0", VA = "0x1854704C0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager IBNFHGFPHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5470680", Offset = "0x546F080", VA = "0x185470680")]
		private IOEEEHGENGG LGEBEEGNIBE(NetworkDelivery ADAMDPHPFAA)
		{
			return default(IOEEEHGENGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5470830", Offset = "0x546F230", VA = "0x185470830", Slot = "15")]
		private void LPIJKBKAGKM(HCDPBHEBNAM GLIKINPODDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5470970", Offset = "0x546F370", VA = "0x185470970", Slot = "16")]
		private void NIPFIHMJMBK(HCDPBHEBNAM GLIKINPODDE, JGHFJMNEOJI EGNKPPJBEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "17")]
		private void DPIKIFPHLBN(IPEndPoint KFCOPHOBJAH, SocketError POFIHOCOBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x546FF50", Offset = "0x546E950", VA = "0x18546FF50", Slot = "18")]
		private void ACAMJGLPACD(HCDPBHEBNAM GLIKINPODDE, AMFOOEGOHHD AGGHEBELANL, byte MKANAEEDIDP, IOEEEHGENGG JMBPHHFKIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5470750", Offset = "0x546F150", VA = "0x185470750")]
		private void LNIKPEOGGAI(int BFFGCOIILMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "19")]
		private void OPCLENGOKJK(IPEndPoint GCKDCFJJNCA, AMFOOEGOHHD AGGHEBELANL, JPMAPIIONBE AKKEKGOPELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "20")]
		private void IDENBOPKHOK(HCDPBHEBNAM GLIKINPODDE, int OOMLDPCMFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54708F0", Offset = "0x546F2F0", VA = "0x1854708F0", Slot = "21")]
		private void MFMFIKKNMBD(BGPOCCGFKMO NCCHHGAPAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5470AB0", Offset = "0x546F4B0", VA = "0x185470AB0")]
		private ulong OHFCMNEIHBC(HCDPBHEBNAM GLIKINPODDE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5470950", Offset = "0x546F350", VA = "0x185470950")]
		private static int MGNPCIJKFKD(float EDBFKNKJGAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5471650", Offset = "0x5470050", VA = "0x185471650")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class DJKNDCCDAAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HCDPBHEBNAM CPOEEIFAJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<KEFCKNFBIHJ> MDBBCECNCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int CHACINJKJGD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5460AB0", Offset = "0x545F4B0", VA = "0x185460AB0")]
	protected DJKNDCCDAAP(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54609D0", Offset = "0x545F3D0", VA = "0x1854609D0")]
	public void BNJANPFPDAC(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5460A30", Offset = "0x545F430", VA = "0x185460A30")]
	protected void DCCFFEPIIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5460990", Offset = "0x545F390", VA = "0x185460990")]
	public bool BCILONNFAKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool HEBAGJFNPEE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DHLBMFPHDMA(KEFCKNFBIHJ IBJGFCKNNLM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BPPNKGMHBNA
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
public class BGPOCCGFKMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GFLHNGHENMJ NBOJAIMJMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int MPKOBLNKGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FBBBFEJEENM NGFJCMFGAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint DOLDJKKAAMF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BPPNKGMHBNA GBBOJIONADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6D0", Offset = "0x7CE0D0", VA = "0x1807CF6D0")]
		[CompilerGenerated]
		get
		{
			return default(BPPNKGMHBNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C30E0", Offset = "0x8C1AE0", VA = "0x1808C30E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x545E800", Offset = "0x545D200", VA = "0x18545E800")]
	internal void GLDDENDOIPI(FBBBFEJEENM HOIEDEIMFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x545E770", Offset = "0x545D170", VA = "0x18545E770")]
	private bool DMPBJAONHJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x545E860", Offset = "0x545D260", VA = "0x18545E860")]
	internal BGPOCCGFKMO(IPEndPoint GCKDCFJJNCA, FBBBFEJEENM GGKADAMCPEH, GFLHNGHENMJ AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x545E7A0", Offset = "0x545D1A0", VA = "0x18545E7A0")]
	public HCDPBHEBNAM FPDJPLOCACC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JPMAPIIONBE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NFIEKLFADMD
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
public struct JGHFJMNEOJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NFIEKLFADMD LCGCKJJNGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError HKCHJKAJENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public AMFOOEGOHHD DILGEIDINAA;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKGPKNACPLE
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICJMNCAKHCI(HCDPBHEBNAM GLIKINPODDE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPCCMGAAAOD(HCDPBHEBNAM GLIKINPODDE, JGHFJMNEOJI EGNKPPJBEBK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLOGPJHEAEE(IPEndPoint KFCOPHOBJAH, SocketError POFIHOCOBEA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGNCALBPHBC(HCDPBHEBNAM GLIKINPODDE, AMFOOEGOHHD AGGHEBELANL, byte MKANAEEDIDP, IOEEEHGENGG JMBPHHFKIJL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLLMKNIHNKD(IPEndPoint GCKDCFJJNCA, AMFOOEGOHHD AGGHEBELANL, JPMAPIIONBE AKKEKGOPELO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJMGOKKCADH(HCDPBHEBNAM GLIKINPODDE, int OOMLDPCMFAD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DICBNEECLMN(BGPOCCGFKMO NCCHHGAPAOP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AKJDLLJKIGA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIOMEKMKOPK(HCDPBHEBNAM GLIKINPODDE, object MFIBKFGAANK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AFNMBHMJCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAPOKPDLHON(PDDNOBKGNGD IBJGFCKNNLM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FEHGOKAAOFL
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDIPOJECEPH(HCDPBHEBNAM GLIKINPODDE, IPEndPoint KJJHPECNKJG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FBBBFEJEENM
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int AAFFADOIFJH = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long IJGLIKAIHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte PCOAODPJEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] FFMHJMBGPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly OMNJGEPLANP IHMOEAABGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int CIOMLILHLIG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5462450", Offset = "0x5460E50", VA = "0x185462450")]
	private FBBBFEJEENM(long DNJCOCPACIM, byte APODCNGHBHE, int MJOMEKCECMJ, byte[] PEJJHDCLILD, OMNJGEPLANP MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5462210", Offset = "0x5460C10", VA = "0x185462210")]
	public static int KCALPKBKJCA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5461FF0", Offset = "0x54609F0", VA = "0x185461FF0")]
	public static FBBBFEJEENM KBCLNJDNDDF(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5462270", Offset = "0x5460C70", VA = "0x185462270")]
	public static KEFCKNFBIHJ LCKFAAPPBGK(CDFPBCFPMJN COEDIFFEGLE, SocketAddress HLBHENHGOCE, long CFLLFMALDLN, int MJOMEKCECMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OEOHFHKAABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long IJGLIKAIHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte PCOAODPJEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int CIOMLILHLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool HNDNLMOEBNH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5471B90", Offset = "0x5470590", VA = "0x185471B90")]
	private OEOHFHKAABN(long DNJCOCPACIM, byte APODCNGHBHE, int OJDDHLPBKBJ, bool PMHJFAOLOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5471950", Offset = "0x5470350", VA = "0x185471950")]
	public static OEOHFHKAABN KBCLNJDNDDF(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5471AA0", Offset = "0x54704A0", VA = "0x185471AA0")]
	public static KEFCKNFBIHJ LCKFAAPPBGK(long CFLLFMALDLN, byte BEHHHOJDGCN, int HHGPIDCFDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5471850", Offset = "0x5470250", VA = "0x185471850")]
	public static KEFCKNFBIHJ CMGLMPOFEEE(HCDPBHEBNAM GLIKINPODDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum MEFIHGKMOOO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FJAEEOBHHHO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFAAKOOFELI(IPEndPoint KDIIHGDHENF, IPEndPoint GCKDCFJJNCA, string FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEEKHOBGMOP(IPEndPoint LGJBOBOINED, MEFIHGKMOOO ADAMDPHPFAA, string FACMOGNGACN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CHOBNLNOGEM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KANGJDANGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint ONLFINDBKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint DOLDJKKAAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string DNFKPHMCMAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NHJLBCOIBJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint HPENPOGNIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MEFIHGKMOOO MIOIDKGGEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string DNFKPHMCMAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class PHJHHMFBKJB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint LFGNPFBPGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string DNFKPHMCMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public PHJHHMFBKJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class EOHOKANBMNL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint LFGNPFBPGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint BBABMPCNMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string DNFKPHMCMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public EOHOKANBMNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KGFFOAOFEOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DNFKPHMCMAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MGOLKDMFCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0180", Offset = "0x7AEB80", VA = "0x1807B0180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public KGFFOAOFEOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GFLHNGHENMJ PNEGNKKBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<KANGJDANGGH> HABFFMOBBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<NHJLBCOIBJF> ICBJMCLJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly OMNJGEPLANP EKEFKGBPKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CDFPBCFPMJN JMMPKGDDHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly OFBPKAEALKE CGBFDAOMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private FJAEEOBHHHO EBMKMGBGHCM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BOCNLINGBGI = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool MJDHHBJHEOO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x545FDB0", Offset = "0x545E7B0", VA = "0x18545FDB0")]
	internal CHOBNLNOGEM(GFLHNGHENMJ NEFKGNHBBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x545F7C0", Offset = "0x545E1C0", VA = "0x18545F7C0")]
	internal void BELMHPCLOBA(IPEndPoint HNAOINDKOLD, KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2508B50", Offset = "0x2507550", VA = "0x182508B50")]
	private void FKGJJAKJIGI<T>(T IBJGFCKNNLM, IPEndPoint DAPOBFHGAGK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x545FAC0", Offset = "0x545E4C0", VA = "0x18545FAC0")]
	private void GFAAKOOFELI(PHJHHMFBKJB BLEAPEKBGDJ, IPEndPoint HNAOINDKOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x545FC50", Offset = "0x545E650", VA = "0x18545FC50")]
	private void PDHLKHKCBBI(EOHOKANBMNL BLEAPEKBGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x545F920", Offset = "0x545E320", VA = "0x18545F920")]
	private void CMNEFBNMLKH(KGFFOAOFEOK BLEAPEKBGDJ, IPEndPoint HNAOINDKOLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IOEEEHGENGG : byte
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
public enum BMBEIJLLJKJ : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GOJBGMFKBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] MALEGPLGPBO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int NBCLOPADNJM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int ICPCGNLHGNG;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GFJCDFAAJKJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54624C0", Offset = "0x5460EC0", VA = "0x1854624C0")]
	public GFJCDFAAJKJ(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPIHGECALLJ : GFJCDFAAJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x54624C0", Offset = "0x5460EC0", VA = "0x1854624C0")]
	public MPIHGECALLJ(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NICHMLMHCGP
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
public interface KLCEMKEFNFB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BELLIHJPCLI(NICHMLMHCGP FNELMHIJBBO, string ADLBCEDEBAN, params object[] AHLEFKCGEBC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FACBKKPNNIA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static KLCEMKEFNFB ENPIOLNGFOJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object DMMHKCPDJIH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5461D10", Offset = "0x5460710", VA = "0x185461D10")]
	private static void PACIBCOANIN(NICHMLMHCGP FEBNGAKIGLJ, string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5461BF0", Offset = "0x54605F0", VA = "0x185461BF0")]
	internal static void ABBPGHKEHBD(string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5461C50", Offset = "0x5460650", VA = "0x185461C50")]
	internal static void BNGNPJCCKGI(string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5461CB0", Offset = "0x54606B0", VA = "0x185461CB0")]
	internal static void NOFFACKMPPM(string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum EJGELFBDALL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AMFOOEGOHHD : OMNJGEPLANP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KEFCKNFBIHJ ILGAHBEBFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GFLHNGHENMJ CPCPGCCEHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIAOJOHAIJL BHFCNHABIDH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x545E720", Offset = "0x545D120", VA = "0x18545E720")]
	internal AMFOOEGOHHD(GFLHNGHENMJ FKFIJGNHDJN, CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x545E600", Offset = "0x545D000", VA = "0x18545E600")]
	internal void BEIPIIOOKPA(KEFCKNFBIHJ IBJGFCKNNLM, int AFOBJMAFFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x545E670", Offset = "0x545D070", VA = "0x18545E670")]
	internal void JEJKCPGGBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x545E6F0", Offset = "0x545D0F0", VA = "0x18545E6F0")]
	public void KPAABCDMDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CIAOJOHAIJL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum DHCPJKFLKLD
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
	public CIAOJOHAIJL OBADPIAFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public DHCPJKFLKLD MIOIDKGGEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public HCDPBHEBNAM CPOEEIFAJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint DOLDJKKAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object OAEMGIMOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int HABAKCDCMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError HGDINIPMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NFIEKLFADMD JMONOBCJDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public BGPOCCGFKMO GAPLCEKGLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public IOEEEHGENGG NHEPNHBAABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte CHAMMLOMGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly AMFOOEGOHHD JADIGDCPDEA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5460200", Offset = "0x545EC00", VA = "0x185460200")]
	public CIAOJOHAIJL(GFLHNGHENMJ FKFIJGNHDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GFLHNGHENMJ : IEnumerable<HCDPBHEBNAM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JAJFPNKGNJM : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x546F280", Offset = "0x546DC80", VA = "0x18546F280", Slot = "4")]
		public bool Equals(IPEndPoint LGHEBJJLAGD, IPEndPoint FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F32A80", Offset = "0x4F31480", VA = "0x184F32A80", Slot = "5")]
		public int GetHashCode(IPEndPoint MBCPMMHPENP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public JAJFPNKGNJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct MFFPKNIHLAP : IEnumerator<HCDPBHEBNAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly HCDPBHEBNAM DOLHHCPCDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private HCDPBHEBNAM ALKFEALNJEN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HCDPBHEBNAM FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B580", VA = "0x18088CB80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B580", VA = "0x18088CB80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xEAFFA0", Offset = "0xEAE9A0", VA = "0x180EAFFA0")]
		public MFFPKNIHLAP(HCDPBHEBNAM BILHHBDBFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5471750", Offset = "0x5470150", VA = "0x185471750", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x54717A0", Offset = "0x54701A0", VA = "0x1854717A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread EGNLKHEHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool ADDDOIODDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OPLLOMCFCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CIAOJOHAIJL> EBIHPJDNOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CIAOJOHAIJL> IKOEJOLGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CIAOJOHAIJL JIOFHIOGLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LKGPKNACPLE DBLGAJGDMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AKJDLLJKIGA DMBLFBNHFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AFNMBHMJCKC AAOJJPLIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FEHGOKAAOFL KNAOKPMDCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, HCDPBHEBNAM> ANIDPEMPGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, BGPOCCGFKMO> EFOFKOBOALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, HAHOHKBDHHJ> LKEGMGLGKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim GIOHPNMLKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private HCDPBHEBNAM DCHNCOHPNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OEHAJAEBOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<HCDPBHEBNAM> KGOLFECMDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HCDPBHEBNAM[] HFJAODIEIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BONKOBAKMKJ HEPHJBEGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int GECLENMEFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> FKKMHFMLBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte EONPPHPHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object IBJJIEOGIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool CIOKAMNMNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool OLCCMIBLNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int JADELADNMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int CPPBGJCNEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int GIBMICEBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int NFFKBFIAAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool MFKGGMMBLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NIEBCONJGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IAJHILEHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GIMGMKPFLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MMILFMPOLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MJDHHBJHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool OBJKLNLIMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool OOFCAKIAPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool AAGLKIEBKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MKBIJMBPBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int LCACPCDBLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool MMCNBPDMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly IKACAIMPOAM GAJOIMDMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HIEOMHGOHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly CHOBNLNOGEM EICEAHAFOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HEFGJLLIGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public EJGELFBDALL GCDKOKLBIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int JMBEKCPFHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MCHHAJPIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NKGEJHHNLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool CKEGJHDEAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool GPFGNICCKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private KEFCKNFBIHJ BOHMILEBEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int HOPAOEAPGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object CNOMHHNNICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KEFCKNFBIHJ IOFJPMNMOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int AGKNDILADEE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int FBGEFHGFNCB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int ACJEENCGJML = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LKMLIBJHIGP OGHDOAPFOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LKMLIBJHIGP MFADOLAMFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OOJBIEKLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread GHNHCJBDHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ECBIKNNGJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint FHIPDIFEIKA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] CFNDPMJEEPK;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] LBFCKHGBIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<KHHJJMPCIPL, IPEndPoint> BGNMFPNCGEB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress HJBNKBAECOA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool FDLLANBJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GDCENMOLEAN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KOHMLPMIGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9E40D0", Offset = "0x9E2AD0", VA = "0x1809E40D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA70CB0", Offset = "0xA6F6B0", VA = "0x180A70CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MNNPGJOKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1563710", Offset = "0x1562110", VA = "0x181563710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1562250", Offset = "0x1560C50", VA = "0x181562250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte MBKPFAIGMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GHKCAMAKAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5465050", Offset = "0x5463A50", VA = "0x185465050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short EBGKDIHLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5464640", Offset = "0x5463040", VA = "0x185464640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5468380", Offset = "0x5466D80", VA = "0x185468380")]
	public void NMBCNHBOJKK(IPEndPoint KFCOPHOBJAH, byte[] KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54624D0", Offset = "0x5460ED0", VA = "0x1854624D0")]
	public void ACIENIMDFCL(IPEndPoint KFCOPHOBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5467360", Offset = "0x5465D60", VA = "0x185467360")]
	private bool MOHHDCKDCJG(IPEndPoint KFCOPHOBJAH, [Out] HCDPBHEBNAM GLIKINPODDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5465EE0", Offset = "0x54648E0", VA = "0x185465EE0")]
	private void KJABBDCPIFA(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5466C10", Offset = "0x5465610", VA = "0x185466C10")]
	private void LPGELDBAAMM(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5465070", Offset = "0x5463A70", VA = "0x185465070")]
	private void INBNENCCHOO(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5468E50", Offset = "0x5467850", VA = "0x185468E50")]
	public GFLHNGHENMJ(LKGPKNACPLE AHCFJOOAJDA, [Optional] BONKOBAKMKJ BBKPAAAPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54627C0", Offset = "0x54611C0", VA = "0x1854627C0")]
	internal void BBGJHCKKMOB(HCDPBHEBNAM IGIPDAOEAAG, int OOMLDPCMFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5464320", Offset = "0x5462D20", VA = "0x185464320")]
	internal void FADGDNBENIM(HCDPBHEBNAM IGIPDAOEAAG, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5468880", Offset = "0x5467280", VA = "0x185468880")]
	internal void PDCALGGONNE(HCDPBHEBNAM GLIKINPODDE, NFIEKLFADMD LCAIGDLPJAO, SocketError JLNKKACNALG, KEFCKNFBIHJ IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5462920", Offset = "0x5461320", VA = "0x185462920")]
	private void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE, NFIEKLFADMD LCAIGDLPJAO, SocketError JLNKKACNALG, bool DBCFABNBIEE, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN, KEFCKNFBIHJ IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5467800", Offset = "0x5466200", VA = "0x185467800")]
	private void NKCDKBAABOM(CIAOJOHAIJL.DHCPJKFLKLD ADAMDPHPFAA, [Optional] HCDPBHEBNAM GLIKINPODDE, [Optional] IPEndPoint GCKDCFJJNCA, SocketError FBHHDJPJBFB = SocketError.Success, int OOMLDPCMFAD = 0, NFIEKLFADMD LOGMNPDIOOH = NFIEKLFADMD.ConnectionFailed, [Optional] BGPOCCGFKMO CLFMBEDGAEF, IOEEEHGENGG JMBPHHFKIJL = IOEEEHGENGG.Unreliable, byte MKANAEEDIDP = 0, [Optional] KEFCKNFBIHJ NHOELIICHML, [Optional] object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5467BC0", Offset = "0x54665C0", VA = "0x185467BC0")]
	private void NKCEEFLHMGC(CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5462AC0", Offset = "0x54614C0", VA = "0x185462AC0")]
	internal void BPJEBFNJFIE(CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5463FE0", Offset = "0x54629E0", VA = "0x185463FE0")]
	private void ENOHKAABGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5468950", Offset = "0x5467350", VA = "0x185468950")]
	private void PJEGLFHHBFK(int OKLKBJMFIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5466C60", Offset = "0x5465660", VA = "0x185466C60")]
	internal HCDPBHEBNAM MKNJCLBMBCN(BGPOCCGFKMO NCCHHGAPAOP, byte[] CANMKPABOFF, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5467780", Offset = "0x5466180", VA = "0x185467780")]
	private int NGIFCACOMAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5468420", Offset = "0x5466E20", VA = "0x185468420")]
	private void OGJBGCLGADI(IPEndPoint GCKDCFJJNCA, HCDPBHEBNAM IPFPNNKKPHF, FBBBFEJEENM GNNOCJPDEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5462BC0", Offset = "0x54615C0", VA = "0x185462BC0")]
	private void CFHOJGDKPKD(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x54663C0", Offset = "0x5464DC0", VA = "0x1854663C0")]
	internal void LDCDJBEJICK(KEFCKNFBIHJ IBJGFCKNNLM, IOEEEHGENGG BGNMKGIOBCO, byte MKANAEEDIDP, int AFOBJMAFFAG, HCDPBHEBNAM IGIPDAOEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x54656F0", Offset = "0x54640F0", VA = "0x1854656F0")]
	public bool KDHLPBFNFLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5465700", Offset = "0x5464100", VA = "0x185465700")]
	public bool KDHLPBFNFLJ(IPAddress AGILPBIAGHK, IPAddress BMPAGOECPMO, int MLNIMFJMHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5465670", Offset = "0x5464070", VA = "0x185465670")]
	public bool KDHLPBFNFLJ(int MLNIMFJMHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5462620", Offset = "0x5461020", VA = "0x185462620")]
	public void AEPCFCLDMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5466680", Offset = "0x5465080", VA = "0x185466680")]
	public HCDPBHEBNAM LGCFNOIAFCG(string PNNLDDMFPIB, int MLNIMFJMHMP, string KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5466B30", Offset = "0x5465530", VA = "0x185466B30")]
	public HCDPBHEBNAM LGCFNOIAFCG(string PNNLDDMFPIB, int MLNIMFJMHMP, CDFPBCFPMJN ELDMJKGECIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5466760", Offset = "0x5465160", VA = "0x185466760")]
	public HCDPBHEBNAM LGCFNOIAFCG(IPEndPoint DAPOBFHGAGK, CDFPBCFPMJN ELDMJKGECIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5463910", Offset = "0x5462310", VA = "0x185463910")]
	public void CICOGPEPCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5463920", Offset = "0x5462320", VA = "0x185463920")]
	public void CICOGPEPCAK(bool JAHLBNIJJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x54662C0", Offset = "0x5464CC0", VA = "0x1854662C0")]
	public void KOMFHBJEKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x54661A0", Offset = "0x5464BA0", VA = "0x1854661A0")]
	public void KOMFHBJEKBF(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5462870", Offset = "0x5461270", VA = "0x185462870")]
	public void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5462A00", Offset = "0x5461400", VA = "0x185462A00")]
	public void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5468C70", Offset = "0x5467670", VA = "0x185468C70", Slot = "4")]
	private IEnumerator<HCDPBHEBNAM> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5468D00", Offset = "0x5467700", VA = "0x185468D00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5463D50", Offset = "0x5462750", VA = "0x185463D50")]
	private KEFCKNFBIHJ DAPALDCCKMA(CBOCHKONLFN EEAABMKADCD, int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5463C70", Offset = "0x5462670", VA = "0x185463C70")]
	private KEFCKNFBIHJ DAPALDCCKMA(CBOCHKONLFN EEAABMKADCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54652D0", Offset = "0x5463CD0", VA = "0x1854652D0")]
	internal KEFCKNFBIHJ JFMLOJEFIIF(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5464DF0", Offset = "0x54637F0", VA = "0x185464DF0")]
	internal void IBAEABODDCP(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5468D90", Offset = "0x5467790", VA = "0x185468D90")]
	static GFLHNGHENMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9E40D0", Offset = "0x9E2AD0", VA = "0x1809E40D0")]
	private bool MANBOABLAAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5464700", Offset = "0x5463100", VA = "0x185464700")]
	private void HAGEBCPHFGL(IPEndPoint NALFMDIKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5467280", Offset = "0x5465C80", VA = "0x185467280")]
	private void MKPDEDFIAJO(IPEndPoint NALFMDIKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5463E40", Offset = "0x5462840", VA = "0x185463E40")]
	private bool DECMANMEDIM(SocketException MEIELCKPCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5464370", Offset = "0x5462D70", VA = "0x185464370")]
	private void FDLHCBAHGOH(LKMLIBJHIGP NEFKGNHBBKH, EndPoint CAHOFEMBOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x54673F0", Offset = "0x5465DF0", VA = "0x1854673F0")]
	private void NBKCMGILAPI(object ILNNMFPHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5465720", Offset = "0x5464120", VA = "0x185465720")]
	public bool KDHLPBFNFLJ(IPAddress AGILPBIAGHK, IPAddress BMPAGOECPMO, int MLNIMFJMHMP, bool FBFFIKNMKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5462810", Offset = "0x5461210", VA = "0x185462810")]
	internal int BFLDIOODAFD(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x54647F0", Offset = "0x54631F0", VA = "0x1854647F0")]
	internal int HFPPBMAGOKK(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5464830", Offset = "0x5463230", VA = "0x185464830")]
	internal int HFPPBMAGOKK(byte[] DCKDMGKGDFN, int AJOMPGHNEBN, int CBKFAHCFHJN, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5465500", Offset = "0x5463F00", VA = "0x185465500")]
	internal void JPPNNNKAFGF(bool HDDOJGPFLDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum CBOCHKONLFN : byte
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
internal sealed class KEFCKNFBIHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int GKFBONGIDHO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] BGGDENHIHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] LKCIJDOBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int DPKBEHGMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object OAEMGIMOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public KEFCKNFBIHJ OBADPIAFNKI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CBOCHKONLFN APPLNFODMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x546F8E0", Offset = "0x546E2E0", VA = "0x18546F8E0")]
		get
		{
			return default(CBOCHKONLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x546F490", Offset = "0x546DE90", VA = "0x18546F490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PCOAODPJEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x546F840", Offset = "0x546E240", VA = "0x18546F840")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x546F350", Offset = "0x546DD50", VA = "0x18546F350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort NGENBDAGHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x546F6A0", Offset = "0x546E0A0", VA = "0x18546F6A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x546F500", Offset = "0x546DF00", VA = "0x18546F500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NKPBJGEIJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x546F670", Offset = "0x546E070", VA = "0x18546F670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PMKPLPHMLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x546F4D0", Offset = "0x546DED0", VA = "0x18546F4D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x546F540", Offset = "0x546DF40", VA = "0x18546F540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort INEBIBCAODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x546F7E0", Offset = "0x546E1E0", VA = "0x18546F7E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x546F760", Offset = "0x546E160", VA = "0x18546F760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort PIHNHFHOMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x546F700", Offset = "0x546E100", VA = "0x18546F700")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x546F8A0", Offset = "0x546E2A0", VA = "0x18546F8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JGFLILCOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x546F2F0", Offset = "0x546DCF0", VA = "0x18546F2F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x546F7A0", Offset = "0x546E1A0", VA = "0x18546F7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x546F910", Offset = "0x546E310", VA = "0x18546F910")]
	static KEFCKNFBIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x546F870", Offset = "0x546E270", VA = "0x18546F870")]
	public void MFLJCAFOPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x546FBF0", Offset = "0x546E5F0", VA = "0x18546FBF0")]
	public KEFCKNFBIHJ(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x546FC60", Offset = "0x546E660", VA = "0x18546FC60")]
	public KEFCKNFBIHJ(CBOCHKONLFN EEAABMKADCD, int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x546F570", Offset = "0x546DF70", VA = "0x18546F570")]
	public static int FIEJMPMJCDE(CBOCHKONLFN EEAABMKADCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x546F5E0", Offset = "0x546DFE0", VA = "0x18546F5E0")]
	public int FIEJMPMJCDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x546F390", Offset = "0x546DD90", VA = "0x18546F390")]
	public bool DMMNDDMJJHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum AFDEBIKJOOJ : byte
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
internal enum PFPHHIMKGHK
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
internal enum GJDKEOLBJML
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OHADMGKJHGG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HCDPBHEBNAM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class ECDADCAJCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KEFCKNFBIHJ[] JDOGKBBIAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JAONIFKPPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int OAPKMNPCJME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte PMKPLPHMLOI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ECDADCAJCKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void NOMHFKPFLGB(ulong OBFILFEHIJG, int EICDEMIJLGL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int ENIBCMKDCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int LHNHNABKAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int MBNICKOMMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double AFDLCGLNLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int AJGLILFHCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int NDJJLAEDPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int APCBMNDBGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch HCGPDGBPJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int BBIIJDMOMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PKMBALGICEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object JKGONGBDIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal HCDPBHEBNAM PKFFPCEIBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal HCDPBHEBNAM AMJKNNBEKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<KEFCKNFBIHJ> BFPLGIAIIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<DJKNDCCDAAP> IIPHJHNBLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DJKNDCCDAAP[] NMIJMLLKPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int DMOCIJGCCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int JCNMBLKIKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool HJFEEJADEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int CAMLJAEFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int ABLDDJABDMB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CPGFGJFODOE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int GPHKJJDLJBO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DFBFNPGKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PHONBJIAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, ECDADCAJCKO> JDBCKLFNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> JKLJODBJFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KEFCKNFBIHJ PDALKACEBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int NNLNOEKDGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int LNEDPMDDENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint KNOBOHNJDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KEFMDHDGKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int JDGNEIGLFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long FHCIEIEMPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte LJGKJCENHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private AFDEBIKJOOJ JIIGDMDFCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KEFCKNFBIHJ HMHJBGPCKCN;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int KAAOEODJIPN = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EENMJGBCFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly KEFCKNFBIHJ OMAJPGAIOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KEFCKNFBIHJ LJLDFCGPJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KEFCKNFBIHJ FPEFIGLNKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly KEFCKNFBIHJ MEIEAEMIABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private BMBEIJLLJKJ ABKBCJKFCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GFLHNGHENMJ KGOIGMALHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int OFPLNGFPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object KKJAKAANDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly IKACAIMPOAM GAJOIMDMIBN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte DCBBBCDILAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA90", Offset = "0xA0B490", VA = "0x180A0CA90")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5469A70", Offset = "0x5468470", VA = "0x185469A70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CBKCOOHDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FC970", Offset = "0x7FB370", VA = "0x1807FC970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AFDEBIKJOOJ NPLEIFJAGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x157F210", Offset = "0x157DC10", VA = "0x18157F210")]
		get
		{
			return default(AFDEBIKJOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long FBEENFCDCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A69B0", Offset = "0x7A53B0", VA = "0x1807A69B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OMPBCOPDONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAD0140", Offset = "0xACEB40", VA = "0x180AD0140")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x13BB9B0", Offset = "0x13BA3B0", VA = "0x1813BB9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BPBOLLNNICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x546CAC0", Offset = "0x546B4C0", VA = "0x18546CAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DNEOOFIDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B71C0", Offset = "0x7B5BC0", VA = "0x1807B71C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LJOEBDDCHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1779640", Offset = "0x1778040", VA = "0x181779640")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NOMHFKPFLGB PBCNMMMOACI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x546B0B0", Offset = "0x5469AB0", VA = "0x18546B0B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x546C150", Offset = "0x546AB50", VA = "0x18546C150")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x546D240", Offset = "0x546BC40", VA = "0x18546D240")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, IPEndPoint GCKDCFJJNCA, int PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x546B550", Offset = "0x5469F50", VA = "0x18546B550")]
	internal void FLMPOCJPIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x546CE20", Offset = "0x546B820", VA = "0x18546CE20")]
	internal void NCDOKNNENHN(IPEndPoint HAPMIGLDOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x54697E0", Offset = "0x54681E0", VA = "0x1854697E0")]
	internal void AJCDPKDLEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x546B570", Offset = "0x5469F70", VA = "0x18546B570")]
	private void GCMDNHBCGOL(int BOLFFCBEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x546B4E0", Offset = "0x5469EE0", VA = "0x18546B4E0")]
	private void FGOCEOAIKOD(int NFNLFIHDCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x546C260", Offset = "0x546AC60", VA = "0x18546C260")]
	private DJKNDCCDAAP JJCEAKILDOL(byte MCGKIOCGDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x546D6A0", Offset = "0x546C0A0", VA = "0x18546D6A0")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, IPEndPoint GCKDCFJJNCA, int PDDHPPHOJPD, byte BEHHHOJDGCN, CDFPBCFPMJN COEDIFFEGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x546D060", Offset = "0x546BA60", VA = "0x18546D060")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, BGPOCCGFKMO NCCHHGAPAOP, int PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x546CE50", Offset = "0x546B850", VA = "0x18546CE50")]
	internal void NLCNKFPDDFE(FBBBFEJEENM FKIKJCAIDDG, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x546B640", Offset = "0x546A040", VA = "0x18546B640")]
	internal bool HIDHDOLJPBE(OEOHFHKAABN IBJGFCKNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x546B520", Offset = "0x5469F20", VA = "0x18546B520")]
	public void FKGJJAKJIGI(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, IOEEEHGENGG HKFMBOCPCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x546B980", Offset = "0x546A380", VA = "0x18546B980")]
	private void ILALJFNMJAN(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, byte MKANAEEDIDP, IOEEEHGENGG JMBPHHFKIJL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x546BED0", Offset = "0x546A8D0", VA = "0x18546BED0")]
	public void INLCIDLJOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5469870", Offset = "0x5468270", VA = "0x185469870")]
	internal GJDKEOLBJML BEBNIGIOEPL(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(GJDKEOLBJML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x546C200", Offset = "0x546AC00", VA = "0x18546C200")]
	internal void JGNPCLGEFEJ(DJKNDCCDAAP MECCDHEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x546CAD0", Offset = "0x546B4D0", VA = "0x18546CAD0")]
	internal OHADMGKJHGG MCHNBGCAHOP(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, bool DBCFABNBIEE)
	{
		return default(OHADMGKJHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x546CDE0", Offset = "0x546B7E0", VA = "0x18546CDE0")]
	private void MEGDEDEEMAL(int FFACAENDEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5469B20", Offset = "0x5468520", VA = "0x185469B20")]
	internal void DDNOCOHKMLI(IOEEEHGENGG BGNMKGIOBCO, KEFCKNFBIHJ BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x546AB60", Offset = "0x5469560", VA = "0x18546AB60")]
	private void DJBGMJFLGNA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x546B160", Offset = "0x5469B60", VA = "0x18546B160")]
	private void FECLHKONONO(int PLEPJKNDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x546CEA0", Offset = "0x546B8A0", VA = "0x18546CEA0")]
	internal PFPHHIMKGHK OGJBGCLGADI(FBBBFEJEENM GNNOCJPDEHL)
	{
		return default(PFPHHIMKGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x546A4B0", Offset = "0x5468EB0", VA = "0x18546A4B0")]
	internal void DHLBMFPHDMA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5469950", Offset = "0x5468350", VA = "0x185469950")]
	private void CAHFMEBCOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x546BF80", Offset = "0x546A980", VA = "0x18546BF80")]
	internal void JFFLBOLCACM(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x546C410", Offset = "0x546AE10", VA = "0x18546C410")]
	internal void JPBFJKJIHMJ(int PLEPJKNDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x546B6C0", Offset = "0x546A0C0", VA = "0x18546B6C0")]
	internal void ICMDNPDMPKE(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class IKACAIMPOAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long IFOCAGPDHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EHACCLFJLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long PNINGEKPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IPGFPMOGHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long OIENLLPEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long FAHHLCOEJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long GMCCMIHFOHN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long AAIEPCJGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x546EE30", Offset = "0x546D830", VA = "0x18546EE30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DKODLOLEALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x546EF20", Offset = "0x546D920", VA = "0x18546EF20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long MNKPACCDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x546EDD0", Offset = "0x546D7D0", VA = "0x18546EDD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NAFKLEMDECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x546EF30", Offset = "0x546D930", VA = "0x18546EF30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long ODPLNMCGMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x546EEA0", Offset = "0x546D8A0", VA = "0x18546EEA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PABLPHHFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x546EDC0", Offset = "0x546D7C0", VA = "0x18546EDC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BMBEIJLLJKJ ELCNFNODIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19EA110", Offset = "0x19E8B10", VA = "0x1819EA110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double GLBOEOHEBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x546ED60", Offset = "0x546D760", VA = "0x18546ED60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x546EE40", Offset = "0x546D840", VA = "0x18546EE40")]
	public void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x546EEB0", Offset = "0x546D8B0", VA = "0x18546EEB0")]
	public void KFGADACCPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x546EF10", Offset = "0x546D910", VA = "0x18546EF10")]
	public void LICGFCBDLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x546ECB0", Offset = "0x546D6B0", VA = "0x18546ECB0")]
	public void ADCJKKLJCHG(long NJHHEBOBHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x546EDE0", Offset = "0x546D7E0", VA = "0x18546EDE0")]
	public void GBJKGEFJEJP(long DMPIFFMKJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x546EEE0", Offset = "0x546D8E0", VA = "0x18546EEE0")]
	public void KHLKEELBLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x546EDF0", Offset = "0x546D7F0", VA = "0x18546EDF0")]
	public void JGBCCGBEJOD(long DCDCGAGLEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x546EF40", Offset = "0x546D940", VA = "0x18546EF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x546ECC0", Offset = "0x546D6C0", VA = "0x18546ECC0")]
	public void ALAAMONHPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public IKACAIMPOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CIPNBCFCANM
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> MLBIPAALKDP;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5460530", Offset = "0x545EF30", VA = "0x185460530")]
	public static IPEndPoint LIPIDDOKJHM(string IFCDDPLOGKP, int MLNIMFJMHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x54602D0", Offset = "0x545ECD0", VA = "0x1854602D0")]
	public static IPAddress HNNAKEFMCEK(string IFCDDPLOGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x54604A0", Offset = "0x545EEA0", VA = "0x1854604A0")]
	public static IPAddress HNNAKEFMCEK(string IFCDDPLOGKP, AddressFamily NCFCOAFMKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54602A0", Offset = "0x545ECA0", VA = "0x1854602A0")]
	internal static int ACFCJFKFAJC(int OBKHJBKAEPG, int CFHBMAENKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2508E60", Offset = "0x2507860", VA = "0x182508E60")]
	internal static T[] BDLBBHDGEHD<T>(int DPBEIPGOMHN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EKFEGIAFPHK : DJKNDCCDAAP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DFDGAIADBID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private KEFCKNFBIHJ ILGAHBEBFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long NHFEBAPGOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool JEHADDDAEPF;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x54608F0", Offset = "0x545F2F0", VA = "0x1854608F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x54608D0", Offset = "0x545F2D0", VA = "0x1854608D0")]
		public void OHCMDEDMAIL(KEFCKNFBIHJ IBJGFCKNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5460810", Offset = "0x545F210", VA = "0x185460810")]
		public bool FLCEDJFFPOD(long DNHAFMNPMOH, HCDPBHEBNAM GLIKINPODDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5460880", Offset = "0x545F280", VA = "0x185460880")]
		public bool NJLBNDAIMDB(HCDPBHEBNAM GLIKINPODDE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly KEFCKNFBIHJ EPCAFAHONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DFDGAIADBID[] JPMEHCIJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly KEFCKNFBIHJ[] JNLGNKGIACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] KCINCGNPBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int JDPBAJAKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int KJHAOHAAJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KJIAOBKLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int FHKGBKGILAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool PDGPKDJEJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly IOEEEHGENGG BBAIAPHAMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool PABJFLLEJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int KKGKHBMFHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte FNBMCJIEFLD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5461A20", Offset = "0x5460420", VA = "0x185461A20")]
	public EKFEGIAFPHK(HCDPBHEBNAM GLIKINPODDE, bool GICIKCLEFNH, byte PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5460B50", Offset = "0x545F550", VA = "0x185460B50")]
	private void BMNOLNKCMAB(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5461570", Offset = "0x545FF70", VA = "0x185461570", Slot = "4")]
	protected override bool HEBAGJFNPEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5460F10", Offset = "0x545F910", VA = "0x185460F10", Slot = "5")]
	public override bool DHLBMFPHDMA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class ABLFOHMIHME : DJKNDCCDAAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int POGIDKFMHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort KJHAOHAAJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool HMOINMAOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private KEFCKNFBIHJ KBPMAOJOOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly KEFCKNFBIHJ PJHAEDEBMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool GJCPGOPIKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte FNBMCJIEFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long IBGGNNOCIJL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x545E540", Offset = "0x545CF40", VA = "0x18545E540")]
	public ABLFOHMIHME(HCDPBHEBNAM GLIKINPODDE, bool OLKPNDPKFKK, byte PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x545E0A0", Offset = "0x545CAA0", VA = "0x18545E0A0", Slot = "4")]
	protected override bool HEBAGJFNPEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x545DD90", Offset = "0x545C790", VA = "0x18545DD90", Slot = "5")]
	public override bool DHLBMFPHDMA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GIPAKMEKOJA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct DGNADADDBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong BJMIBLIIJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double GBJNCEDHCJL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FFPDOFFONBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int NPLMGIFAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float HLHJBKEOJFM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x545DCA0", Offset = "0x545C6A0", VA = "0x18545DCA0")]
	private static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, ulong MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54694E0", Offset = "0x5467EE0", VA = "0x1854694E0")]
	private static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, int MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x54694A0", Offset = "0x5467EA0", VA = "0x1854694A0")]
	public static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, short MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5469550", Offset = "0x5467F50", VA = "0x185469550")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5469580", Offset = "0x5467F80", VA = "0x185469580")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x54694A0", Offset = "0x5467EA0", VA = "0x1854694A0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x54694A0", Offset = "0x5467EA0", VA = "0x1854694A0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x54694E0", Offset = "0x5467EE0", VA = "0x1854694E0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x54694E0", Offset = "0x5467EE0", VA = "0x1854694E0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5469570", Offset = "0x5467F70", VA = "0x185469570")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5469570", Offset = "0x5467F70", VA = "0x185469570")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, ulong FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OMNJGEPLANP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] DMMDIHJBCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int NJKNFOPGAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int NOCPAKOGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int ECHLIODCGFG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] LKCIJDOBALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LPFBGOGKFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JPFDNIJNJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5471F60", Offset = "0x5470960", VA = "0x185471F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FCNONBIHDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C95650", Offset = "0x1C94050", VA = "0x181C95650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MPHJKNKCPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5472430", Offset = "0x5470E30", VA = "0x185472430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x54720F0", Offset = "0x5470AF0", VA = "0x1854720F0")]
	public void BEIPIIOOKPA(byte[] JIBNFGIMNPP, int ABOMIAEBHEB, int LNAFOHAJKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public OMNJGEPLANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5472B50", Offset = "0x5471550", VA = "0x185472B50")]
	public OMNJGEPLANP(byte[] JIBNFGIMNPP, int ABOMIAEBHEB, int LNAFOHAJKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5471F70", Offset = "0x5470970", VA = "0x185471F70")]
	public IPEndPoint AKDGFDDMFLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x54720B0", Offset = "0x5470AB0", VA = "0x1854720B0")]
	public byte GMIGKIAKAAD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x54720B0", Offset = "0x5470AB0", VA = "0x1854720B0")]
	public sbyte BCNBAGMAFGP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27EF000", Offset = "0x27EDA00", VA = "0x1827EF000")]
	public T[] EHLJPJFOLMC<T>(ushort BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5472B10", Offset = "0x5471510", VA = "0x185472B10")]
	public bool[] PGPGJCGMPNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5472A40", Offset = "0x5471440", VA = "0x185472A40")]
	public ushort[] NAPBKGFKBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5472340", Offset = "0x5470D40", VA = "0x185472340")]
	public short[] FNHOKLPNHKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5472290", Offset = "0x5470C90", VA = "0x185472290")]
	public int[] EMIKBANIKJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5472690", Offset = "0x5471090", VA = "0x185472690")]
	public uint[] JBNMPCDPDED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5472990", Offset = "0x5471390", VA = "0x185472990")]
	public float[] LPBBADDOFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5472570", Offset = "0x5470F70", VA = "0x185472570")]
	public double[] HAAEGLGJCJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5472950", Offset = "0x5471350", VA = "0x185472950")]
	public long[] JMNFJMACNEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5472250", Offset = "0x5470C50", VA = "0x185472250")]
	public ulong[] DHLNIFKELJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5472440", Offset = "0x5470E40", VA = "0x185472440")]
	public string[] GOGJHEOECMO(int OHDEANMFEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5472210", Offset = "0x5470C10", VA = "0x185472210")]
	public bool DCDIKILNOBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54723C0", Offset = "0x5470DC0", VA = "0x1854723C0")]
	public char GIPGHKLHFEE()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54723C0", Offset = "0x5470DC0", VA = "0x1854723C0")]
	public ushort OIIDKPDMDOB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x54722D0", Offset = "0x5470CD0", VA = "0x1854722D0")]
	public short FJDIPPMDIEA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5472130", Offset = "0x5470B30", VA = "0x185472130")]
	public long BGIEHNEBIFL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5472AA0", Offset = "0x54714A0", VA = "0x185472AA0")]
	public ulong OOFHIHPOJGC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5472040", Offset = "0x5470A40", VA = "0x185472040")]
	public int ANHENDGAJPK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54729D0", Offset = "0x54713D0", VA = "0x1854729D0")]
	public uint NAIKALMDHGG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54721A0", Offset = "0x5470BA0", VA = "0x1854721A0")]
	public float BMHHHJKCGAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x54725B0", Offset = "0x5470FB0", VA = "0x1854725B0")]
	public double HEJKJOHENJF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54726D0", Offset = "0x54710D0", VA = "0x1854726D0")]
	public string JCIPMJBINMH(int HPAEJNPCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5472620", Offset = "0x5471020", VA = "0x185472620")]
	public ArraySegment<byte> HLAHBOLAANF(int DPBEIPGOMHN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5472380", Offset = "0x5470D80", VA = "0x185472380")]
	public sbyte[] GHGMFDMOKGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5472910", Offset = "0x5471310", VA = "0x185472910")]
	public byte[] JKCENPDFNNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5472A80", Offset = "0x5471480", VA = "0x185472A80")]
	public void NJLBNDAIMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CDFPBCFPMJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] DMMDIHJBCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int NJKNFOPGAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int JFJDHJNBIHB = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool JONPIEOACEP;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding FHGDLONLLDP;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int JKBMNJBLHOI = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] JHJHHGPPHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] IHMOEAABGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x545F6A0", Offset = "0x545E0A0", VA = "0x18545F6A0")]
	public CDFPBCFPMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x545F720", Offset = "0x545E120", VA = "0x18545F720")]
	public CDFPBCFPMJN(bool PGDDLOIAJIH, int BIMOGKLBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x545F150", Offset = "0x545DB50", VA = "0x18545F150")]
	public static CDFPBCFPMJN NIFBMJKLADJ(string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x545EA50", Offset = "0x545D450", VA = "0x18545EA50")]
	public void BDPCBDCKLCM(int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EF60", Offset = "0x1D0D960", VA = "0x181D0EF60")]
	public void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x545EBD0", Offset = "0x545D5D0", VA = "0x18545EBD0")]
	public void DLPKKGHALBO(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x545F100", Offset = "0x545DB00", VA = "0x18545F100")]
	public void DLPKKGHALBO(double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x545EEA0", Offset = "0x545D8A0", VA = "0x18545EEA0")]
	public void DLPKKGHALBO(long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x545EEA0", Offset = "0x545D8A0", VA = "0x18545EEA0")]
	public void DLPKKGHALBO(ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x545EDB0", Offset = "0x545D7B0", VA = "0x18545EDB0")]
	public void DLPKKGHALBO(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x545EDB0", Offset = "0x545D7B0", VA = "0x18545EDB0")]
	public void DLPKKGHALBO(uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x545ED40", Offset = "0x545D740", VA = "0x18545ED40")]
	public void DLPKKGHALBO(char FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x545ED40", Offset = "0x545D740", VA = "0x18545ED40")]
	public void DLPKKGHALBO(ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x545ED40", Offset = "0x545D740", VA = "0x18545ED40")]
	public void DLPKKGHALBO(short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x545EE40", Offset = "0x545D840", VA = "0x18545EE40")]
	public void DLPKKGHALBO(sbyte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x545EE40", Offset = "0x545D840", VA = "0x18545EE40")]
	public void DLPKKGHALBO(byte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x545EC70", Offset = "0x545D670", VA = "0x18545EC70")]
	public void DLPKKGHALBO(byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x545E970", Offset = "0x545D370", VA = "0x18545E970")]
	public void CPGKNLMJLCN(sbyte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x545E970", Offset = "0x545D370", VA = "0x18545E970")]
	public void BDNGGMPMBPK(byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x545ECE0", Offset = "0x545D6E0", VA = "0x18545ECE0")]
	public void DLPKKGHALBO(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x545F2A0", Offset = "0x545DCA0", VA = "0x18545F2A0")]
	public void PCIJOEPBJDO(Array LDHKIFPGEBO, int LAHMMIFMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x545F380", Offset = "0x545DD80", VA = "0x18545F380")]
	public void PCIJOEPBJDO(float[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x545F1C0", Offset = "0x545DBC0", VA = "0x18545F1C0")]
	public void PCIJOEPBJDO(double[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x545F1C0", Offset = "0x545DBC0", VA = "0x18545F1C0")]
	public void PCIJOEPBJDO(long[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x545F1C0", Offset = "0x545DBC0", VA = "0x18545F1C0")]
	public void PCIJOEPBJDO(ulong[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x545F380", Offset = "0x545DD80", VA = "0x18545F380")]
	public void PCIJOEPBJDO(int[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x545F380", Offset = "0x545DD80", VA = "0x18545F380")]
	public void PCIJOEPBJDO(uint[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x545F460", Offset = "0x545DE60", VA = "0x18545F460")]
	public void PCIJOEPBJDO(ushort[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x545F460", Offset = "0x545DE60", VA = "0x18545F460")]
	public void PCIJOEPBJDO(short[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x545E970", Offset = "0x545D370", VA = "0x18545E970")]
	public void PCIJOEPBJDO(bool[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x545F540", Offset = "0x545DF40", VA = "0x18545F540")]
	public void PCIJOEPBJDO(string[] FDFHGIHHGHO, int JABCANLAIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x545EAF0", Offset = "0x545D4F0", VA = "0x18545EAF0")]
	public void DLPKKGHALBO(IPEndPoint KFCOPHOBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x545EBC0", Offset = "0x545D5C0", VA = "0x18545EBC0")]
	public void DLPKKGHALBO(string FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x545EEF0", Offset = "0x545D8F0", VA = "0x18545EEF0")]
	public void DLPKKGHALBO(string FDFHGIHHGHO, int HPAEJNPCJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OFBPKAEALKE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class OOIFDFFCAAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong OFPLNGFPNOG;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3F36D10", Offset = "0x3F35710", VA = "0x183F36D10")]
		static OOIFDFFCAAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void LNLMIGLPODB(OMNJGEPLANP AGGHEBELANL, object MFIBKFGAANK);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CBNFLMHKHHN<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public OFBPKAEALKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CBNFLMHKHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4856040", Offset = "0x4854A40", VA = "0x184856040")]
		internal void NLGKGKJIDEK(OMNJGEPLANP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FGPINJNJPDJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OFBPKAEALKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public FGPINJNJPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x35B3950", Offset = "0x35B2350", VA = "0x1835B3950")]
		internal void NLGKGKJIDEK(OMNJGEPLANP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BKKCPGNDHLH IPGFPGBMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, LNLMIGLPODB> FBEGLLNPHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly CDFPBCFPMJN MFONAJEAODH;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5471DE0", Offset = "0x54707E0", VA = "0x185471DE0")]
	public OFBPKAEALKE(int OHDEANMFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2508AE0", Offset = "0x25074E0", VA = "0x182508AE0", Slot = "4")]
	protected virtual ulong AOEJBCJDJGM<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5471CB0", Offset = "0x54706B0", VA = "0x185471CB0", Slot = "5")]
	protected virtual LNLMIGLPODB OLCFNJGCLMK(OMNJGEPLANP AGGHEBELANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27DC150", Offset = "0x27DAB50", VA = "0x1827DC150", Slot = "6")]
	protected virtual void DALMBAMGPMJ<T>(CDFPBCFPMJN NADLGELBCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5471C30", Offset = "0x5470630", VA = "0x185471C30")]
	public void GLLAGINBJNG(OMNJGEPLANP AGGHEBELANL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27DC4C0", Offset = "0x27DAEC0", VA = "0x1827DC4C0")]
	public void POJMGPDPHDM<T>(CDFPBCFPMJN NADLGELBCMH, T IBJGFCKNNLM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5471BE0", Offset = "0x54705E0", VA = "0x185471BE0")]
	public void AJIEKJPBJJH(OMNJGEPLANP AGGHEBELANL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27DC340", Offset = "0x27DAD40", VA = "0x1827DC340")]
	public void HACFJPCHIEA<T>(Action<T> AABCBJKLFOF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27DC1C0", Offset = "0x27DABC0", VA = "0x1827DC1C0")]
	public void HACFJPCHIEA<T, TUserData>(Action<T, TUserData> AABCBJKLFOF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LABIPDPJAAD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x54624C0", Offset = "0x5460EC0", VA = "0x1854624C0")]
	public LABIPDPJAAD(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NPCCOCACOGJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x54717F0", Offset = "0x54701F0", VA = "0x1854717F0")]
	public NPCCOCACOGJ(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BKKCPGNDHLH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum ABAPKHBFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FCNCCLBKGEH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public ABAPKHBFEEA MIOIDKGGEJK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x35A1D50", Offset = "0x35A0750", VA = "0x1835A1D50", Slot = "4")]
		public virtual void OHCMDEDMAIL(MethodInfo IPELOFEOHEJ, MethodInfo MFIGOHDLPEK, ABAPKHBFEEA ADAMDPHPFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GMJJOLHKHMH(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DCLFOCLPNJP(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		protected FCNCCLBKGEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class EJDLIOJPPEP<TClass, TProperty> : FCNCCLBKGEH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> APLGOHKJMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> KHGPEAPPDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> FBCGPCACCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> GFNAEHDBNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> FLBCEPMJPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> DGPNBKCCEDD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3224EA0", Offset = "0x32238A0", VA = "0x183224EA0", Slot = "7")]
		public override void DOLOECNGIFP(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3223EE0", Offset = "0x32228E0", VA = "0x183223EE0", Slot = "8")]
		public override void DHPLJLPDCPE(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3225F40", Offset = "0x3224940", VA = "0x183225F40", Slot = "9")]
		public override void GMJJOLHKHMH(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3223380", Offset = "0x3221D80", VA = "0x183223380", Slot = "10")]
		public override void DCLFOCLPNJP(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3226100", Offset = "0x3224B00", VA = "0x183226100")]
		protected TProperty[] JNMLNGFCMEH(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3223310", Offset = "0x3221D10", VA = "0x183223310")]
		protected TProperty[] AOFJBCDJJPH(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3226200", Offset = "0x3224C00", VA = "0x183226200", Slot = "4")]
		public override void OHCMDEDMAIL(MethodInfo IPELOFEOHEJ, MethodInfo MFIGOHDLPEK, ABAPKHBFEEA ADAMDPHPFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x322ACC0", Offset = "0x32296C0", VA = "0x18322ACC0")]
		protected EJDLIOJPPEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class MMMJKEPLNNH<TClass, TProperty> : EJDLIOJPPEP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PGEDECGFPJA(OMNJGEPLANP FEDGKNJBNJN, [Out] TProperty LGONKMCLPLM);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void LFHEIOOFJFB(CDFPBCFPMJN LKDONMJJPCN, TProperty LGONKMCLPLM);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDAE0", Offset = "0x3DCC4E0", VA = "0x183DCDAE0", Slot = "5")]
		public override void MBGBGOCHAHN(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDC50", Offset = "0x3DCC650", VA = "0x183DCDC50", Slot = "6")]
		public override void POJMGPDPHDM(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD9A0", Offset = "0x3DCC3A0", VA = "0x183DCD9A0", Slot = "7")]
		public override void DOLOECNGIFP(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD900", Offset = "0x3DCC300", VA = "0x183DCD900", Slot = "8")]
		public override void DHPLJLPDCPE(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x35C8DA0", Offset = "0x35C77A0", VA = "0x1835C8DA0")]
		protected MMMJKEPLNNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FIBGAGDEHAI<T> : EJDLIOJPPEP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35B5C70", Offset = "0x35B4670", VA = "0x1835B5C70", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35B5CE0", Offset = "0x35B46E0", VA = "0x1835B5CE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x35B5C00", Offset = "0x35B4600", VA = "0x1835B5C00", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x35A5390", Offset = "0x35A3D90", VA = "0x1835A5390", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public FIBGAGDEHAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BOFKACEKKMN<T> : EJDLIOJPPEP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x466DE80", Offset = "0x466C880", VA = "0x18466DE80", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x35B5CE0", Offset = "0x35B46E0", VA = "0x1835B5CE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x466DE10", Offset = "0x466C810", VA = "0x18466DE10", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x35A5390", Offset = "0x35A3D90", VA = "0x1835A5390", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public BOFKACEKKMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FGCLMJIHIGD<T> : EJDLIOJPPEP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x35A7670", Offset = "0x35A6070", VA = "0x1835A7670", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x35A76E0", Offset = "0x35A60E0", VA = "0x1835A76E0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x35A7600", Offset = "0x35A6000", VA = "0x1835A7600", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35A75A0", Offset = "0x35A5FA0", VA = "0x1835A75A0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public FGCLMJIHIGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OEDOBFHOBNM<T> : EJDLIOJPPEP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F216A0", Offset = "0x3F200A0", VA = "0x183F216A0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35A76E0", Offset = "0x35A60E0", VA = "0x1835A76E0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F21630", Offset = "0x3F20030", VA = "0x183F21630", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x35A75A0", Offset = "0x35A5FA0", VA = "0x1835A75A0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public OEDOBFHOBNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EAPILHHOFED<T> : EJDLIOJPPEP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x32014D0", Offset = "0x31FFED0", VA = "0x1832014D0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3201540", Offset = "0x31FFF40", VA = "0x183201540", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3201460", Offset = "0x31FFE60", VA = "0x183201460", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3201400", Offset = "0x31FFE00", VA = "0x183201400", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public EAPILHHOFED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EFMBOEHJJMF<T> : EJDLIOJPPEP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x320ED20", Offset = "0x320D720", VA = "0x18320ED20", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3201540", Offset = "0x31FFF40", VA = "0x183201540", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x320ECB0", Offset = "0x320D6B0", VA = "0x18320ECB0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3201400", Offset = "0x31FFE00", VA = "0x183201400", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public EFMBOEHJJMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CGFBDIJMNLL<T> : EJDLIOJPPEP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3814330", Offset = "0x3812D30", VA = "0x183814330", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x38143A0", Offset = "0x3812DA0", VA = "0x1838143A0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4941EC0", Offset = "0x49408C0", VA = "0x184941EC0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3814260", Offset = "0x3812C60", VA = "0x183814260", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public CGFBDIJMNLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class IOKPEDPAMJC<T> : EJDLIOJPPEP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3814330", Offset = "0x3812D30", VA = "0x183814330", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x38143A0", Offset = "0x3812DA0", VA = "0x1838143A0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x38142C0", Offset = "0x3812CC0", VA = "0x1838142C0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3814260", Offset = "0x3812C60", VA = "0x183814260", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public IOKPEDPAMJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FEJHPADINKH<T> : EJDLIOJPPEP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x35A5460", Offset = "0x35A3E60", VA = "0x1835A5460", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x35A54D0", Offset = "0x35A3ED0", VA = "0x1835A54D0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x35A53F0", Offset = "0x35A3DF0", VA = "0x1835A53F0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x35A5390", Offset = "0x35A3D90", VA = "0x1835A5390", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public FEJHPADINKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LMMFCGNDJMP<T> : EJDLIOJPPEP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F070", Offset = "0x3B9DA70", VA = "0x183B9F070", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F0E0", Offset = "0x3B9DAE0", VA = "0x183B9F0E0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F000", Offset = "0x3B9DA00", VA = "0x183B9F000", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3201400", Offset = "0x31FFE00", VA = "0x183201400", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public LMMFCGNDJMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MGJDJMBEKBH<T> : EJDLIOJPPEP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D97FE0", Offset = "0x3D969E0", VA = "0x183D97FE0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D98050", Offset = "0x3D96A50", VA = "0x183D98050", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D97F70", Offset = "0x3D96970", VA = "0x183D97F70", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3814260", Offset = "0x3812C60", VA = "0x183814260", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32015A0", Offset = "0x31FFFA0", VA = "0x1832015A0")]
		public MGJDJMBEKBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CMGPCHKBGJN<T> : MMMJKEPLNNH<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A22250", Offset = "0x4A20C50", VA = "0x184A22250", Slot = "12")]
		protected override void LFHEIOOFJFB(CDFPBCFPMJN LKDONMJJPCN, char LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4A22280", Offset = "0x4A20C80", VA = "0x184A22280", Slot = "11")]
		protected override void PGEDECGFPJA(OMNJGEPLANP FEDGKNJBNJN, [Out] char LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x35C27B0", Offset = "0x35C11B0", VA = "0x1835C27B0")]
		public CMGPCHKBGJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class PIMHKNFNHML<T> : MMMJKEPLNNH<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x400CE90", Offset = "0x400B890", VA = "0x18400CE90", Slot = "12")]
		protected override void LFHEIOOFJFB(CDFPBCFPMJN LKDONMJJPCN, IPEndPoint LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x400CEC0", Offset = "0x400B8C0", VA = "0x18400CEC0", Slot = "11")]
		protected override void PGEDECGFPJA(OMNJGEPLANP FEDGKNJBNJN, [Out] IPEndPoint LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x35C27B0", Offset = "0x35C11B0", VA = "0x1835C27B0")]
		public PIMHKNFNHML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FLNCCLDNKDC<T> : EJDLIOJPPEP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int CKPEOBOIPOM;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x35C1BD0", Offset = "0x35C05D0", VA = "0x1835C1BD0")]
		public FLNCCLDNKDC(int HPAEJNPCJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x35C1AF0", Offset = "0x35C04F0", VA = "0x1835C1AF0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x35C1B60", Offset = "0x35C0560", VA = "0x1835C1B60", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x35C1A80", Offset = "0x35C0480", VA = "0x1835C1A80", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x35C1A10", Offset = "0x35C0410", VA = "0x1835C1A10", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JOFECBOFOCB<T> : FCNCCLBKGEH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo APPLNFODMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type EACAPKMEFLN;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A372F0", Offset = "0x3A35CF0", VA = "0x183A372F0")]
		public JOFECBOFOCB(PropertyInfo EEAABMKADCD, Type NKHHDFAIIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A37180", Offset = "0x3A35B80", VA = "0x183A37180", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A37240", Offset = "0x3A35C40", VA = "0x183A37240", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A370C0", Offset = "0x3A35AC0", VA = "0x183A370C0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A37060", Offset = "0x3A35A60", VA = "0x183A37060", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A37120", Offset = "0x3A35B20", VA = "0x183A37120", Slot = "9")]
		public override void GMJJOLHKHMH(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A37000", Offset = "0x3A35A00", VA = "0x183A37000", Slot = "10")]
		public override void DCLFOCLPNJP(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BMIBLBACEFL<T> : JOFECBOFOCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x372BFC0", Offset = "0x372A9C0", VA = "0x18372BFC0")]
		public BMIBLBACEFL(PropertyInfo EEAABMKADCD, Type NKHHDFAIIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x46684C0", Offset = "0x4666EC0", VA = "0x1846684C0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4668580", Offset = "0x4666F80", VA = "0x184668580", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class BPPAIPECAKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static BPPAIPECAKN<T> MEGHANKAOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly FCNCCLBKGEH<T>[] ENPGMEAIHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int PBGJDFGKLFL;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4670D80", Offset = "0x466F780", VA = "0x184670D80")]
		public BPPAIPECAKN(List<FCNCCLBKGEH<T>> CILLNINJFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4670CD0", Offset = "0x466F6D0", VA = "0x184670CD0")]
		public void POJMGPDPHDM(T MBCPMMHPENP, CDFPBCFPMJN NADLGELBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4670C20", Offset = "0x466F620", VA = "0x184670C20")]
		public void MBGBGOCHAHN(T MBCPMMHPENP, OMNJGEPLANP AGGHEBELANL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class EHEBLNCNHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FCNCCLBKGEH<T> JNDPLHMHPON<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private CDFPBCFPMJN JFIIBFJKCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int JKPADBEOAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, EHEBLNCNHEG> DKEDOCLJHMP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x545E8D0", Offset = "0x545D2D0", VA = "0x18545E8D0")]
	public BKKCPGNDHLH(int OHDEANMFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x248D8F0", Offset = "0x248C2F0", VA = "0x18248D8F0")]
	private BPPAIPECAKN<T> ENGOFDINFCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x248E840", Offset = "0x248D240", VA = "0x18248E840")]
	public void LIBHGHNAKIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x248D870", Offset = "0x248C270", VA = "0x18248D870")]
	public bool AFFCBAMFOKP<T>(OMNJGEPLANP AGGHEBELANL, T DAPOBFHGAGK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x248E7E0", Offset = "0x248D1E0", VA = "0x18248E7E0")]
	public void LENOCDGJGPN<T>(CDFPBCFPMJN NADLGELBCMH, T MBCPMMHPENP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PDDNOBKGNGD
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime NCBGBDBCFGM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] OOMNBKACKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HDJCEBAOBLN JHNHEBNLDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x54737F0", Offset = "0x54721F0", VA = "0x1854737F0")]
		get
		{
			return default(HDJCEBAOBLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int MJGPMBIPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5472C30", Offset = "0x5471630", VA = "0x185472C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5473780", Offset = "0x5472180", VA = "0x185473780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DFFGJFALMKI KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5473350", Offset = "0x5471D50", VA = "0x185473350")]
		get
		{
			return default(DFFGJFALMKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x54733B0", Offset = "0x5471DB0", VA = "0x1854733B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KEDMPCJKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x54738E0", Offset = "0x54722E0", VA = "0x1854738E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint AECGDNFAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5472BB0", Offset = "0x54715B0", VA = "0x185472BB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? PCLMMIJBDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x54737C0", Offset = "0x54721C0", VA = "0x1854737C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? BCFIGHLFLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5473150", Offset = "0x5471B50", VA = "0x185473150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CEDBHPMAJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5473380", Offset = "0x5471D80", VA = "0x185473380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5472C60", Offset = "0x5471660", VA = "0x185472C60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? KKBPLAHHFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA29FA0", Offset = "0xA289A0", VA = "0x180A29FA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x898720", Offset = "0x897120", VA = "0x180898720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5473C20", Offset = "0x5472620", VA = "0x185473C20")]
	public PDDNOBKGNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5473B70", Offset = "0x5472570", VA = "0x185473B70")]
	internal PDDNOBKGNGD(byte[] PEBEDGMMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5472E30", Offset = "0x5471830", VA = "0x185472E30")]
	public static PDDNOBKGNGD BHHFOJICACA(byte[] PEBEDGMMHMC, DateTime CIFIOPIECHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5472F50", Offset = "0x5471950", VA = "0x185472F50")]
	internal void BMEDGLAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54734C0", Offset = "0x5471EC0", VA = "0x1854734C0")]
	private void IBFMIJPEFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5473910", Offset = "0x5472310", VA = "0x185473910")]
	private DateTime? MMCCDKKODFE(int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5473180", Offset = "0x5471B80", VA = "0x185473180")]
	private void DJILNNCJBNI(int ABOMIAEBHEB, DateTime? FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54733F0", Offset = "0x5471DF0", VA = "0x1854733F0")]
	private ulong HAMIKKKCBHF(int ABOMIAEBHEB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5473820", Offset = "0x5472220", VA = "0x185473820")]
	private void LNFAMIFIKJI(int ABOMIAEBHEB, ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5473690", Offset = "0x5472090", VA = "0x185473690")]
	private uint IOKOPFJMKEE(int ABOMIAEBHEB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5340860", Offset = "0x533F260", VA = "0x185340860")]
	private static uint KIHJHIBOBKA(uint LGHEBJJLAGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5473720", Offset = "0x5472120", VA = "0x185473720")]
	private static ulong KIHJHIBOBKA(ulong LGHEBJJLAGD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HDJCEBAOBLN
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
public enum DFFGJFALMKI
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HAHOHKBDHHJ
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int KKPPFHKFLNN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int NOGBJMKIAOM = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int OJMOAFFJKHG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint LAOJBLKLCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int BBIFAKKOILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int LJKKMDLGFNO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BDNMEFFGIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x54696E0", Offset = "0x54680E0", VA = "0x1854696E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x54696F0", Offset = "0x54680F0", VA = "0x1854696F0")]
	public bool FKGJJAKJIGI(LKMLIBJHIGP NEFKGNHBBKH, int BEBEFOHACKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HFHAGJCLOHC : LKMLIBJHIGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket NEFKGNHBBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GFLHNGHENMJ MKEENDPKKKF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short EBGKDIHLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x546D870", Offset = "0x546C270", VA = "0x18546D870", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int AGNMFHLCHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x546DE90", Offset = "0x546C890", VA = "0x18546DE90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint ONLFINDBKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x546D830", Offset = "0x546C230", VA = "0x18546D830", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily AHMHGNPKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B32B90", Offset = "0x3B31590", VA = "0x183B32B90", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x546DFA0", Offset = "0x546C9A0", VA = "0x18546DFA0")]
	public HFHAGJCLOHC(AddressFamily NCFCOAFMKAG, GFLHNGHENMJ MKEENDPKKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x546D8D0", Offset = "0x546C2D0", VA = "0x18546D8D0", Slot = "8")]
	public bool LLGNCOAICJE(IPEndPoint KFCOPHOBJAH, EJGELFBDALL KGFBICHDELG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x546D890", Offset = "0x546C290", VA = "0x18546D890", Slot = "9")]
	public int LHKLOONHCGP(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, int BFFGCOIILMK, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x546DEB0", Offset = "0x546C8B0", VA = "0x18546DEB0", Slot = "10")]
	public int POIKAEFEICL(byte[] BGIIPDEPEFH, EndPoint IIHBLKHJCFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x546D850", Offset = "0x546C250", VA = "0x18546D850", Slot = "11")]
	public void FIBHFOKNPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LKMLIBJHIGP
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short EBGKDIHLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int AGNMFHLCHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint ONLFINDBKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily AHMHGNPKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLGNCOAICJE(IPEndPoint KFCOPHOBJAH, EJGELFBDALL KGFBICHDELG);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LHKLOONHCGP(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, int BFFGCOIILMK, IPEndPoint GCKDCFJJNCA);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int POIKAEFEICL(byte[] BGIIPDEPEFH, EndPoint GCKDCFJJNCA);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FIBHFOKNPCD();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct KHHJJMPCIPL : IEquatable<KHHJJMPCIPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long FALJNFLAGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long PNCADCJMNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long CALNLCBDABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int JDGDHIBJBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int PHGFPAAFLBO;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x546FE60", Offset = "0x546E860", VA = "0x18546FE60")]
	public KHHJJMPCIPL(byte[] PNNLDDMFPIB, int JKBIJPKDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6D0", Offset = "0x7CE0D0", VA = "0x1807CF6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x546FE20", Offset = "0x546E820", VA = "0x18546FE20", Slot = "4")]
	public bool Equals(KHHJJMPCIPL AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x546FD70", Offset = "0x546E770", VA = "0x18546FD70", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class DDPJAOAEAEN : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] KCPNFAMOADI;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BONKOBAKMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int GHKCAMAKAPP;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
	protected BONKOBAKMKJ(int GNHKCACOFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EIIDOCGEBJP(IPEndPoint KFCOPHOBJAH, byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NEIIBKLJEMB(IPEndPoint KFCOPHOBJAH, byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IGMNGLPEMEG : BONKOBAKMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider HPMJBPPFNCL;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator MPLBDDONHBF;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x546EC90", Offset = "0x546D690", VA = "0x18546EC90")]
	public IGMNGLPEMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x546E4E0", Offset = "0x546CEE0", VA = "0x18546E4E0")]
	public void HDNPPDGOCNJ(IPEndPoint KFCOPHOBJAH, byte[] KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x546E720", Offset = "0x546D120", VA = "0x18546E720")]
	public void HGJFECBDAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x546EBA0", Offset = "0x546D5A0", VA = "0x18546EBA0")]
	private byte[] OAEKIDDOEIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x546E050", Offset = "0x546CA50", VA = "0x18546E050", Slot = "4")]
	public override void EIIDOCGEBJP(IPEndPoint KFCOPHOBJAH, byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x546E800", Offset = "0x546D200", VA = "0x18546E800", Slot = "5")]
	public override void NEIIBKLJEMB(IPEndPoint KFCOPHOBJAH, byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN)
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
