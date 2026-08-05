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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LPAJIBNIJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x53FC240", Offset = "0x53FB640", VA = "0x1853FC240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53FB740", Offset = "0x53FAB40", VA = "0x1853FB740")]
		public void RecRoom_SetEncryptionInfo(ulong GBJDBAGDEIC, byte[] KCGLPAPOILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53FB720", Offset = "0x53FAB20", VA = "0x1853FB720")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53FB5F0", Offset = "0x53FA9F0", VA = "0x1853FB5F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x53FC140", Offset = "0x53FB540", VA = "0x1853FC140")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x53FB940", Offset = "0x53FAD40", VA = "0x1853FB940", Slot = "6")]
		public override void Send(ulong EMIGCANIBKN, ArraySegment<byte> MFNOAEFOKBK, NetworkDelivery CPAHFAKOHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x53FB6E0", Offset = "0x53FAAE0", VA = "0x1853FB6E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong EMIGCANIBKN, [Out] ArraySegment<byte> MBIDFLHPHHK, [Out] float CBDFIFEPAGI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x53FBC30", Offset = "0x53FB030", VA = "0x1853FBC30", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x53FC060", Offset = "0x53FB460", VA = "0x1853FC060", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x53FADC0", Offset = "0x53FA1C0", VA = "0x1853FADC0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong EMIGCANIBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x53FAC70", Offset = "0x53FA070", VA = "0x1853FAC70", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x53FAF30", Offset = "0x53FA330", VA = "0x1853FAF30", Slot = "12")]
		public override ulong GetCurrentRtt(ulong EMIGCANIBKN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x53FBBC0", Offset = "0x53FAFC0", VA = "0x1853FBBC0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x53FAFD0", Offset = "0x53FA3D0", VA = "0x1853FAFD0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager IBNFHGFPHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x53FB190", Offset = "0x53FA590", VA = "0x1853FB190")]
		private IOEEEHGENGG LGEBEEGNIBE(NetworkDelivery ADAMDPHPFAA)
		{
			return default(IOEEEHGENGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x53FB340", Offset = "0x53FA740", VA = "0x1853FB340", Slot = "15")]
		private void LPIJKBKAGKM(HCDPBHEBNAM GLIKINPODDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x53FB480", Offset = "0x53FA880", VA = "0x1853FB480", Slot = "16")]
		private void NIPFIHMJMBK(HCDPBHEBNAM GLIKINPODDE, JGHFJMNEOJI EGNKPPJBEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "17")]
		private void DPIKIFPHLBN(IPEndPoint KFCOPHOBJAH, SocketError POFIHOCOBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x53FAA60", Offset = "0x53F9E60", VA = "0x1853FAA60", Slot = "18")]
		private void ACAMJGLPACD(HCDPBHEBNAM GLIKINPODDE, AMFOOEGOHHD AGGHEBELANL, byte MKANAEEDIDP, IOEEEHGENGG JMBPHHFKIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53FB260", Offset = "0x53FA660", VA = "0x1853FB260")]
		private void LNIKPEOGGAI(int BFFGCOIILMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "19")]
		private void OPCLENGOKJK(IPEndPoint GCKDCFJJNCA, AMFOOEGOHHD AGGHEBELANL, JPMAPIIONBE AKKEKGOPELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "20")]
		private void IDENBOPKHOK(HCDPBHEBNAM GLIKINPODDE, int OOMLDPCMFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53FB400", Offset = "0x53FA800", VA = "0x1853FB400", Slot = "21")]
		private void MFMFIKKNMBD(BGPOCCGFKMO NCCHHGAPAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53FB5C0", Offset = "0x53FA9C0", VA = "0x1853FB5C0")]
		private ulong OHFCMNEIHBC(HCDPBHEBNAM GLIKINPODDE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53FB460", Offset = "0x53FA860", VA = "0x1853FB460")]
		private static int MGNPCIJKFKD(float EDBFKNKJGAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53FC160", Offset = "0x53FB560", VA = "0x1853FC160")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EB5C0", Offset = "0x53EA9C0", VA = "0x1853EB5C0")]
	protected DJKNDCCDAAP(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x53EB4E0", Offset = "0x53EA8E0", VA = "0x1853EB4E0")]
	public void BNJANPFPDAC(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53EB540", Offset = "0x53EA940", VA = "0x1853EB540")]
	protected void DCCFFEPIIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53EB4A0", Offset = "0x53EA8A0", VA = "0x1853EB4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C56D0", Offset = "0x7C4AD0", VA = "0x1807C56D0")]
		[CompilerGenerated]
		get
		{
			return default(BPPNKGMHBNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B8520", Offset = "0x8B7920", VA = "0x1808B8520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53E9310", Offset = "0x53E8710", VA = "0x1853E9310")]
	internal void GLDDENDOIPI(FBBBFEJEENM HOIEDEIMFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53E9280", Offset = "0x53E8680", VA = "0x1853E9280")]
	private bool DMPBJAONHJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53E9370", Offset = "0x53E8770", VA = "0x1853E9370")]
	internal BGPOCCGFKMO(IPEndPoint GCKDCFJJNCA, FBBBFEJEENM GGKADAMCPEH, GFLHNGHENMJ AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53E92B0", Offset = "0x53E86B0", VA = "0x1853E92B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53ECF60", Offset = "0x53EC360", VA = "0x1853ECF60")]
	private FBBBFEJEENM(long DNJCOCPACIM, byte APODCNGHBHE, int MJOMEKCECMJ, byte[] PEJJHDCLILD, OMNJGEPLANP MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53ECD20", Offset = "0x53EC120", VA = "0x1853ECD20")]
	public static int KCALPKBKJCA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53ECB00", Offset = "0x53EBF00", VA = "0x1853ECB00")]
	public static FBBBFEJEENM KBCLNJDNDDF(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53ECD80", Offset = "0x53EC180", VA = "0x1853ECD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x53FC6A0", Offset = "0x53FBAA0", VA = "0x1853FC6A0")]
	private OEOHFHKAABN(long DNJCOCPACIM, byte APODCNGHBHE, int OJDDHLPBKBJ, bool PMHJFAOLOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53FC460", Offset = "0x53FB860", VA = "0x1853FC460")]
	public static OEOHFHKAABN KBCLNJDNDDF(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53FC5B0", Offset = "0x53FB9B0", VA = "0x1853FC5B0")]
	public static KEFCKNFBIHJ LCKFAAPPBGK(long CFLLFMALDLN, byte BEHHHOJDGCN, int HHGPIDCFDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53FC360", Offset = "0x53FB760", VA = "0x1853FC360")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MGOLKDMFCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A5580", VA = "0x1807A6180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EA8C0", Offset = "0x53E9CC0", VA = "0x1853EA8C0")]
	internal CHOBNLNOGEM(GFLHNGHENMJ NEFKGNHBBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53EA2D0", Offset = "0x53E96D0", VA = "0x1853EA2D0")]
	internal void BELMHPCLOBA(IPEndPoint HNAOINDKOLD, KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2490B00", Offset = "0x248FF00", VA = "0x182490B00")]
	private void FKGJJAKJIGI<T>(T IBJGFCKNNLM, IPEndPoint DAPOBFHGAGK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53EA5D0", Offset = "0x53E99D0", VA = "0x1853EA5D0")]
	private void GFAAKOOFELI(PHJHHMFBKJB BLEAPEKBGDJ, IPEndPoint HNAOINDKOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x53EA760", Offset = "0x53E9B60", VA = "0x1853EA760")]
	private void PDHLKHKCBBI(EOHOKANBMNL BLEAPEKBGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53EA430", Offset = "0x53E9830", VA = "0x1853EA430")]
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
	[Cpp2IlInjected.Address(RVA = "0x53ECFD0", Offset = "0x53EC3D0", VA = "0x1853ECFD0")]
	public GFJCDFAAJKJ(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPIHGECALLJ : GFJCDFAAJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53ECFD0", Offset = "0x53EC3D0", VA = "0x1853ECFD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EC820", Offset = "0x53EBC20", VA = "0x1853EC820")]
	private static void PACIBCOANIN(NICHMLMHCGP FEBNGAKIGLJ, string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x53EC700", Offset = "0x53EBB00", VA = "0x1853EC700")]
	internal static void ABBPGHKEHBD(string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53EC760", Offset = "0x53EBB60", VA = "0x1853EC760")]
	internal static void BNGNPJCCKGI(string ADLBCEDEBAN, params object[] AHLEFKCGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x53EC7C0", Offset = "0x53EBBC0", VA = "0x1853EC7C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53E9230", Offset = "0x53E8630", VA = "0x1853E9230")]
	internal AMFOOEGOHHD(GFLHNGHENMJ FKFIJGNHDJN, CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x53E9110", Offset = "0x53E8510", VA = "0x1853E9110")]
	internal void BEIPIIOOKPA(KEFCKNFBIHJ IBJGFCKNNLM, int AFOBJMAFFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x53E9180", Offset = "0x53E8580", VA = "0x1853E9180")]
	internal void JEJKCPGGBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x53E9200", Offset = "0x53E8600", VA = "0x1853E9200")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EAD10", Offset = "0x53EA110", VA = "0x1853EAD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F9D90", Offset = "0x53F9190", VA = "0x1853F9D90", Slot = "4")]
		public bool Equals(IPEndPoint LGHEBJJLAGD, IPEndPoint FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5810", Offset = "0x4EC4C10", VA = "0x184EC5810", Slot = "5")]
		public int GetHashCode(IPEndPoint MBCPMMHPENP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
			[Cpp2IlInjected.Address(RVA = "0x8829F0", Offset = "0x881DF0", VA = "0x1808829F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8829F0", Offset = "0x881DF0", VA = "0x1808829F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xEA00C0", Offset = "0xE9F4C0", VA = "0x180EA00C0")]
		public MFFPKNIHLAP(HCDPBHEBNAM BILHHBDBFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x53FC260", Offset = "0x53FB660", VA = "0x1853FC260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x53FC2B0", Offset = "0x53FB6B0", VA = "0x1853FC2B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D8A10", Offset = "0x9D7E10", VA = "0x1809D8A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA652B0", Offset = "0xA646B0", VA = "0x180A652B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MNNPGJOKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x154E6D0", Offset = "0x154DAD0", VA = "0x18154E6D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x154D210", Offset = "0x154C610", VA = "0x18154D210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte MBKPFAIGMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x846AD0", Offset = "0x845ED0", VA = "0x180846AD0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GHKCAMAKAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x53EFB60", Offset = "0x53EEF60", VA = "0x1853EFB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short EBGKDIHLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x53EF150", Offset = "0x53EE550", VA = "0x1853EF150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53F2E90", Offset = "0x53F2290", VA = "0x1853F2E90")]
	public void NMBCNHBOJKK(IPEndPoint KFCOPHOBJAH, byte[] KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x53ECFE0", Offset = "0x53EC3E0", VA = "0x1853ECFE0")]
	public void ACIENIMDFCL(IPEndPoint KFCOPHOBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53F1E70", Offset = "0x53F1270", VA = "0x1853F1E70")]
	private bool MOHHDCKDCJG(IPEndPoint KFCOPHOBJAH, [Out] HCDPBHEBNAM GLIKINPODDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x53F09F0", Offset = "0x53EFDF0", VA = "0x1853F09F0")]
	private void KJABBDCPIFA(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x53F1720", Offset = "0x53F0B20", VA = "0x1853F1720")]
	private void LPGELDBAAMM(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x53EFB80", Offset = "0x53EEF80", VA = "0x1853EFB80")]
	private void INBNENCCHOO(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x53F3960", Offset = "0x53F2D60", VA = "0x1853F3960")]
	public GFLHNGHENMJ(LKGPKNACPLE AHCFJOOAJDA, [Optional] BONKOBAKMKJ BBKPAAAPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x53ED2D0", Offset = "0x53EC6D0", VA = "0x1853ED2D0")]
	internal void BBGJHCKKMOB(HCDPBHEBNAM IGIPDAOEAAG, int OOMLDPCMFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53EEE30", Offset = "0x53EE230", VA = "0x1853EEE30")]
	internal void FADGDNBENIM(HCDPBHEBNAM IGIPDAOEAAG, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53F3390", Offset = "0x53F2790", VA = "0x1853F3390")]
	internal void PDCALGGONNE(HCDPBHEBNAM GLIKINPODDE, NFIEKLFADMD LCAIGDLPJAO, SocketError JLNKKACNALG, KEFCKNFBIHJ IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53ED430", Offset = "0x53EC830", VA = "0x1853ED430")]
	private void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE, NFIEKLFADMD LCAIGDLPJAO, SocketError JLNKKACNALG, bool DBCFABNBIEE, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN, KEFCKNFBIHJ IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x53F2310", Offset = "0x53F1710", VA = "0x1853F2310")]
	private void NKCDKBAABOM(CIAOJOHAIJL.DHCPJKFLKLD ADAMDPHPFAA, [Optional] HCDPBHEBNAM GLIKINPODDE, [Optional] IPEndPoint GCKDCFJJNCA, SocketError FBHHDJPJBFB = SocketError.Success, int OOMLDPCMFAD = 0, NFIEKLFADMD LOGMNPDIOOH = NFIEKLFADMD.ConnectionFailed, [Optional] BGPOCCGFKMO CLFMBEDGAEF, IOEEEHGENGG JMBPHHFKIJL = IOEEEHGENGG.Unreliable, byte MKANAEEDIDP = 0, [Optional] KEFCKNFBIHJ NHOELIICHML, [Optional] object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x53F26D0", Offset = "0x53F1AD0", VA = "0x1853F26D0")]
	private void NKCEEFLHMGC(CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x53ED5D0", Offset = "0x53EC9D0", VA = "0x1853ED5D0")]
	internal void BPJEBFNJFIE(CIAOJOHAIJL JMAEDHHMGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x53EEAF0", Offset = "0x53EDEF0", VA = "0x1853EEAF0")]
	private void ENOHKAABGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x53F3460", Offset = "0x53F2860", VA = "0x1853F3460")]
	private void PJEGLFHHBFK(int OKLKBJMFIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x53F1770", Offset = "0x53F0B70", VA = "0x1853F1770")]
	internal HCDPBHEBNAM MKNJCLBMBCN(BGPOCCGFKMO NCCHHGAPAOP, byte[] CANMKPABOFF, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x53F2290", Offset = "0x53F1690", VA = "0x1853F2290")]
	private int NGIFCACOMAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x53F2F30", Offset = "0x53F2330", VA = "0x1853F2F30")]
	private void OGJBGCLGADI(IPEndPoint GCKDCFJJNCA, HCDPBHEBNAM IPFPNNKKPHF, FBBBFEJEENM GNNOCJPDEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x53ED6D0", Offset = "0x53ECAD0", VA = "0x1853ED6D0")]
	private void CFHOJGDKPKD(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x53F0ED0", Offset = "0x53F02D0", VA = "0x1853F0ED0")]
	internal void LDCDJBEJICK(KEFCKNFBIHJ IBJGFCKNNLM, IOEEEHGENGG BGNMKGIOBCO, byte MKANAEEDIDP, int AFOBJMAFFAG, HCDPBHEBNAM IGIPDAOEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x53F0200", Offset = "0x53EF600", VA = "0x1853F0200")]
	public bool KDHLPBFNFLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53F0210", Offset = "0x53EF610", VA = "0x1853F0210")]
	public bool KDHLPBFNFLJ(IPAddress AGILPBIAGHK, IPAddress BMPAGOECPMO, int MLNIMFJMHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x53F0180", Offset = "0x53EF580", VA = "0x1853F0180")]
	public bool KDHLPBFNFLJ(int MLNIMFJMHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x53ED130", Offset = "0x53EC530", VA = "0x1853ED130")]
	public void AEPCFCLDMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x53F1190", Offset = "0x53F0590", VA = "0x1853F1190")]
	public HCDPBHEBNAM LGCFNOIAFCG(string PNNLDDMFPIB, int MLNIMFJMHMP, string KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x53F1640", Offset = "0x53F0A40", VA = "0x1853F1640")]
	public HCDPBHEBNAM LGCFNOIAFCG(string PNNLDDMFPIB, int MLNIMFJMHMP, CDFPBCFPMJN ELDMJKGECIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x53F1270", Offset = "0x53F0670", VA = "0x1853F1270")]
	public HCDPBHEBNAM LGCFNOIAFCG(IPEndPoint DAPOBFHGAGK, CDFPBCFPMJN ELDMJKGECIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x53EE420", Offset = "0x53ED820", VA = "0x1853EE420")]
	public void CICOGPEPCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x53EE430", Offset = "0x53ED830", VA = "0x1853EE430")]
	public void CICOGPEPCAK(bool JAHLBNIJJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x53F0DD0", Offset = "0x53F01D0", VA = "0x1853F0DD0")]
	public void KOMFHBJEKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x53F0CB0", Offset = "0x53F00B0", VA = "0x1853F0CB0")]
	public void KOMFHBJEKBF(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x53ED380", Offset = "0x53EC780", VA = "0x1853ED380")]
	public void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x53ED510", Offset = "0x53EC910", VA = "0x1853ED510")]
	public void BIEMAMBJIPL(HCDPBHEBNAM GLIKINPODDE, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x53F3780", Offset = "0x53F2B80", VA = "0x1853F3780", Slot = "4")]
	private IEnumerator<HCDPBHEBNAM> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x53F3810", Offset = "0x53F2C10", VA = "0x1853F3810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x53EE860", Offset = "0x53EDC60", VA = "0x1853EE860")]
	private KEFCKNFBIHJ DAPALDCCKMA(CBOCHKONLFN EEAABMKADCD, int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53EE780", Offset = "0x53EDB80", VA = "0x1853EE780")]
	private KEFCKNFBIHJ DAPALDCCKMA(CBOCHKONLFN EEAABMKADCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53EFDE0", Offset = "0x53EF1E0", VA = "0x1853EFDE0")]
	internal KEFCKNFBIHJ JFMLOJEFIIF(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53EF900", Offset = "0x53EED00", VA = "0x1853EF900")]
	internal void IBAEABODDCP(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53F38A0", Offset = "0x53F2CA0", VA = "0x1853F38A0")]
	static GFLHNGHENMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9D8A10", Offset = "0x9D7E10", VA = "0x1809D8A10")]
	private bool MANBOABLAAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53EF210", Offset = "0x53EE610", VA = "0x1853EF210")]
	private void HAGEBCPHFGL(IPEndPoint NALFMDIKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53F1D90", Offset = "0x53F1190", VA = "0x1853F1D90")]
	private void MKPDEDFIAJO(IPEndPoint NALFMDIKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53EE950", Offset = "0x53EDD50", VA = "0x1853EE950")]
	private bool DECMANMEDIM(SocketException MEIELCKPCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53EEE80", Offset = "0x53EE280", VA = "0x1853EEE80")]
	private void FDLHCBAHGOH(LKMLIBJHIGP NEFKGNHBBKH, EndPoint CAHOFEMBOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53F1F00", Offset = "0x53F1300", VA = "0x1853F1F00")]
	private void NBKCMGILAPI(object ILNNMFPHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x53F0230", Offset = "0x53EF630", VA = "0x1853F0230")]
	public bool KDHLPBFNFLJ(IPAddress AGILPBIAGHK, IPAddress BMPAGOECPMO, int MLNIMFJMHMP, bool FBFFIKNMKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53ED320", Offset = "0x53EC720", VA = "0x1853ED320")]
	internal int BFLDIOODAFD(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x53EF300", Offset = "0x53EE700", VA = "0x1853EF300")]
	internal int HFPPBMAGOKK(KEFCKNFBIHJ IBJGFCKNNLM, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x53EF340", Offset = "0x53EE740", VA = "0x1853EF340")]
	internal int HFPPBMAGOKK(byte[] DCKDMGKGDFN, int AJOMPGHNEBN, int CBKFAHCFHJN, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53F0010", Offset = "0x53EF410", VA = "0x1853F0010")]
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
		[Cpp2IlInjected.Address(RVA = "0x53FA3F0", Offset = "0x53F97F0", VA = "0x1853FA3F0")]
		get
		{
			return default(CBOCHKONLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x53F9FA0", Offset = "0x53F93A0", VA = "0x1853F9FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PCOAODPJEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x53FA350", Offset = "0x53F9750", VA = "0x1853FA350")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x53F9E60", Offset = "0x53F9260", VA = "0x1853F9E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort NGENBDAGHON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x53FA1B0", Offset = "0x53F95B0", VA = "0x1853FA1B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x53FA010", Offset = "0x53F9410", VA = "0x1853FA010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NKPBJGEIJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53FA180", Offset = "0x53F9580", VA = "0x1853FA180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PMKPLPHMLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53F9FE0", Offset = "0x53F93E0", VA = "0x1853F9FE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x53FA050", Offset = "0x53F9450", VA = "0x1853FA050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort INEBIBCAODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53FA2F0", Offset = "0x53F96F0", VA = "0x1853FA2F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x53FA270", Offset = "0x53F9670", VA = "0x1853FA270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort PIHNHFHOMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53FA210", Offset = "0x53F9610", VA = "0x1853FA210")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53FA3B0", Offset = "0x53F97B0", VA = "0x1853FA3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JGFLILCOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x53F9E00", Offset = "0x53F9200", VA = "0x1853F9E00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x53FA2B0", Offset = "0x53F96B0", VA = "0x1853FA2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x53FA420", Offset = "0x53F9820", VA = "0x1853FA420")]
	static KEFCKNFBIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x53FA380", Offset = "0x53F9780", VA = "0x1853FA380")]
	public void MFLJCAFOPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x53FA700", Offset = "0x53F9B00", VA = "0x1853FA700")]
	public KEFCKNFBIHJ(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x53FA770", Offset = "0x53F9B70", VA = "0x1853FA770")]
	public KEFCKNFBIHJ(CBOCHKONLFN EEAABMKADCD, int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x53FA080", Offset = "0x53F9480", VA = "0x1853FA080")]
	public static int FIEJMPMJCDE(CBOCHKONLFN EEAABMKADCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x53FA0F0", Offset = "0x53F94F0", VA = "0x1853FA0F0")]
	public int FIEJMPMJCDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x53F9EA0", Offset = "0x53F92A0", VA = "0x1853F9EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA013D0", Offset = "0xA007D0", VA = "0x180A013D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x53F4580", Offset = "0x53F3980", VA = "0x1853F4580")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CBKCOOHDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BC0", Offset = "0x7F1FC0", VA = "0x1807F2BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AFDEBIKJOOJ NPLEIFJAGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x156A110", Offset = "0x1569510", VA = "0x18156A110")]
		get
		{
			return default(AFDEBIKJOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long FBEENFCDCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79C9B0", Offset = "0x79BDB0", VA = "0x18079C9B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OMPBCOPDONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC4650", Offset = "0xAC3A50", VA = "0x180AC4650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x13A6CA0", Offset = "0x13A60A0", VA = "0x1813A6CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BPBOLLNNICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x53F75D0", Offset = "0x53F69D0", VA = "0x1853F75D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DNEOOFIDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7AC5C0", VA = "0x1807AD1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LJOEBDDCHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1765680", Offset = "0x1764A80", VA = "0x181765680")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NOMHFKPFLGB PBCNMMMOACI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x53F5BC0", Offset = "0x53F4FC0", VA = "0x1853F5BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x53F6C60", Offset = "0x53F6060", VA = "0x1853F6C60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x53F7D50", Offset = "0x53F7150", VA = "0x1853F7D50")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, IPEndPoint GCKDCFJJNCA, int PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x53F6060", Offset = "0x53F5460", VA = "0x1853F6060")]
	internal void FLMPOCJPIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53F7930", Offset = "0x53F6D30", VA = "0x1853F7930")]
	internal void NCDOKNNENHN(IPEndPoint HAPMIGLDOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x53F42F0", Offset = "0x53F36F0", VA = "0x1853F42F0")]
	internal void AJCDPKDLEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x53F6080", Offset = "0x53F5480", VA = "0x1853F6080")]
	private void GCMDNHBCGOL(int BOLFFCBEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53F5FF0", Offset = "0x53F53F0", VA = "0x1853F5FF0")]
	private void FGOCEOAIKOD(int NFNLFIHDCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x53F6D70", Offset = "0x53F6170", VA = "0x1853F6D70")]
	private DJKNDCCDAAP JJCEAKILDOL(byte MCGKIOCGDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x53F81B0", Offset = "0x53F75B0", VA = "0x1853F81B0")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, IPEndPoint GCKDCFJJNCA, int PDDHPPHOJPD, byte BEHHHOJDGCN, CDFPBCFPMJN COEDIFFEGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x53F7B70", Offset = "0x53F6F70", VA = "0x1853F7B70")]
	internal HCDPBHEBNAM(GFLHNGHENMJ MKEENDPKKKF, BGPOCCGFKMO NCCHHGAPAOP, int PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x53F7960", Offset = "0x53F6D60", VA = "0x1853F7960")]
	internal void NLCNKFPDDFE(FBBBFEJEENM FKIKJCAIDDG, byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x53F6150", Offset = "0x53F5550", VA = "0x1853F6150")]
	internal bool HIDHDOLJPBE(OEOHFHKAABN IBJGFCKNNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x53F6030", Offset = "0x53F5430", VA = "0x1853F6030")]
	public void FKGJJAKJIGI(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, IOEEEHGENGG HKFMBOCPCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x53F6490", Offset = "0x53F5890", VA = "0x1853F6490")]
	private void ILALJFNMJAN(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, byte MKANAEEDIDP, IOEEEHGENGG JMBPHHFKIJL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x53F69E0", Offset = "0x53F5DE0", VA = "0x1853F69E0")]
	public void INLCIDLJOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x53F4380", Offset = "0x53F3780", VA = "0x1853F4380")]
	internal GJDKEOLBJML BEBNIGIOEPL(KEFCKNFBIHJ IBJGFCKNNLM)
	{
		return default(GJDKEOLBJML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x53F6D10", Offset = "0x53F6110", VA = "0x1853F6D10")]
	internal void JGNPCLGEFEJ(DJKNDCCDAAP MECCDHEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x53F75E0", Offset = "0x53F69E0", VA = "0x1853F75E0")]
	internal OHADMGKJHGG MCHNBGCAHOP(byte[] MFNOAEFOKBK, int AJOMPGHNEBN, int CBKFAHCFHJN, bool DBCFABNBIEE)
	{
		return default(OHADMGKJHGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x53F78F0", Offset = "0x53F6CF0", VA = "0x1853F78F0")]
	private void MEGDEDEEMAL(int FFACAENDEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x53F4630", Offset = "0x53F3A30", VA = "0x1853F4630")]
	internal void DDNOCOHKMLI(IOEEEHGENGG BGNMKGIOBCO, KEFCKNFBIHJ BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x53F5670", Offset = "0x53F4A70", VA = "0x1853F5670")]
	private void DJBGMJFLGNA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x53F5C70", Offset = "0x53F5070", VA = "0x1853F5C70")]
	private void FECLHKONONO(int PLEPJKNDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x53F79B0", Offset = "0x53F6DB0", VA = "0x1853F79B0")]
	internal PFPHHIMKGHK OGJBGCLGADI(FBBBFEJEENM GNNOCJPDEHL)
	{
		return default(PFPHHIMKGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x53F4FC0", Offset = "0x53F43C0", VA = "0x1853F4FC0")]
	internal void DHLBMFPHDMA(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x53F4460", Offset = "0x53F3860", VA = "0x1853F4460")]
	private void CAHFMEBCOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x53F6A90", Offset = "0x53F5E90", VA = "0x1853F6A90")]
	internal void JFFLBOLCACM(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x53F6F20", Offset = "0x53F6320", VA = "0x1853F6F20")]
	internal void JPBFJKJIHMJ(int PLEPJKNDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x53F61D0", Offset = "0x53F55D0", VA = "0x1853F61D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F9940", Offset = "0x53F8D40", VA = "0x1853F9940")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DKODLOLEALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x53F9A30", Offset = "0x53F8E30", VA = "0x1853F9A30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long MNKPACCDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x53F98E0", Offset = "0x53F8CE0", VA = "0x1853F98E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NAFKLEMDECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x53F9A40", Offset = "0x53F8E40", VA = "0x1853F9A40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long ODPLNMCGMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x53F99B0", Offset = "0x53F8DB0", VA = "0x1853F99B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PABLPHHFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x53F98D0", Offset = "0x53F8CD0", VA = "0x1853F98D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BMBEIJLLJKJ ELCNFNODIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19D1600", Offset = "0x19D0A00", VA = "0x1819D1600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double GLBOEOHEBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x53F9870", Offset = "0x53F8C70", VA = "0x1853F9870")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x53F9950", Offset = "0x53F8D50", VA = "0x1853F9950")]
	public void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x53F99C0", Offset = "0x53F8DC0", VA = "0x1853F99C0")]
	public void KFGADACCPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x53F9A20", Offset = "0x53F8E20", VA = "0x1853F9A20")]
	public void LICGFCBDLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53F97C0", Offset = "0x53F8BC0", VA = "0x1853F97C0")]
	public void ADCJKKLJCHG(long NJHHEBOBHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x53F98F0", Offset = "0x53F8CF0", VA = "0x1853F98F0")]
	public void GBJKGEFJEJP(long DMPIFFMKJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x53F99F0", Offset = "0x53F8DF0", VA = "0x1853F99F0")]
	public void KHLKEELBLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x53F9900", Offset = "0x53F8D00", VA = "0x1853F9900")]
	public void JGBCCGBEJOD(long DCDCGAGLEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x53F9A50", Offset = "0x53F8E50", VA = "0x1853F9A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x53F97D0", Offset = "0x53F8BD0", VA = "0x1853F97D0")]
	public void ALAAMONHPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EB040", Offset = "0x53EA440", VA = "0x1853EB040")]
	public static IPEndPoint LIPIDDOKJHM(string IFCDDPLOGKP, int MLNIMFJMHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x53EADE0", Offset = "0x53EA1E0", VA = "0x1853EADE0")]
	public static IPAddress HNNAKEFMCEK(string IFCDDPLOGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x53EAFB0", Offset = "0x53EA3B0", VA = "0x1853EAFB0")]
	public static IPAddress HNNAKEFMCEK(string IFCDDPLOGKP, AddressFamily NCFCOAFMKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x53EADB0", Offset = "0x53EA1B0", VA = "0x1853EADB0")]
	internal static int ACFCJFKFAJC(int OBKHJBKAEPG, int CFHBMAENKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2490E10", Offset = "0x2490210", VA = "0x182490E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x53EB400", Offset = "0x53EA800", VA = "0x1853EB400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x53EB3E0", Offset = "0x53EA7E0", VA = "0x1853EB3E0")]
		public void OHCMDEDMAIL(KEFCKNFBIHJ IBJGFCKNNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x53EB320", Offset = "0x53EA720", VA = "0x1853EB320")]
		public bool FLCEDJFFPOD(long DNHAFMNPMOH, HCDPBHEBNAM GLIKINPODDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x53EB390", Offset = "0x53EA790", VA = "0x1853EB390")]
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
	[Cpp2IlInjected.Address(RVA = "0x53EC530", Offset = "0x53EB930", VA = "0x1853EC530")]
	public EKFEGIAFPHK(HCDPBHEBNAM GLIKINPODDE, bool GICIKCLEFNH, byte PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x53EB660", Offset = "0x53EAA60", VA = "0x1853EB660")]
	private void BMNOLNKCMAB(KEFCKNFBIHJ IBJGFCKNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x53EC080", Offset = "0x53EB480", VA = "0x1853EC080", Slot = "4")]
	protected override bool HEBAGJFNPEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53EBA20", Offset = "0x53EAE20", VA = "0x1853EBA20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x53E9050", Offset = "0x53E8450", VA = "0x1853E9050")]
	public ABLFOHMIHME(HCDPBHEBNAM GLIKINPODDE, bool OLKPNDPKFKK, byte PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x53E8BB0", Offset = "0x53E7FB0", VA = "0x1853E8BB0", Slot = "4")]
	protected override bool HEBAGJFNPEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x53E88A0", Offset = "0x53E7CA0", VA = "0x1853E88A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x53E87B0", Offset = "0x53E7BB0", VA = "0x1853E87B0")]
	private static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, ulong MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FF0", Offset = "0x53F33F0", VA = "0x1853F3FF0")]
	private static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, int MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FB0", Offset = "0x53F33B0", VA = "0x1853F3FB0")]
	public static void CFAGIOFAKNE(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, short MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x53F4060", Offset = "0x53F3460", VA = "0x1853F4060")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x53F4090", Offset = "0x53F3490", VA = "0x1853F4090")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FB0", Offset = "0x53F33B0", VA = "0x1853F3FB0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FB0", Offset = "0x53F33B0", VA = "0x1853F3FB0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FF0", Offset = "0x53F33F0", VA = "0x1853F3FF0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x53F3FF0", Offset = "0x53F33F0", VA = "0x1853F3FF0")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x53F4080", Offset = "0x53F3480", VA = "0x1853F4080")]
	public static void NDINFEBECJN(byte[] PEBEDGMMHMC, int DAGOHCNFGEF, long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x53F4080", Offset = "0x53F3480", VA = "0x1853F4080")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LPFBGOGKFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JPFDNIJNJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x53FCA70", Offset = "0x53FBE70", VA = "0x1853FCA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FCNONBIHDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C7B980", Offset = "0x1C7AD80", VA = "0x181C7B980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MPHJKNKCPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x53FCF40", Offset = "0x53FC340", VA = "0x1853FCF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x53FCC00", Offset = "0x53FC000", VA = "0x1853FCC00")]
	public void BEIPIIOOKPA(byte[] JIBNFGIMNPP, int ABOMIAEBHEB, int LNAFOHAJKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public OMNJGEPLANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x53FD660", Offset = "0x53FCA60", VA = "0x1853FD660")]
	public OMNJGEPLANP(byte[] JIBNFGIMNPP, int ABOMIAEBHEB, int LNAFOHAJKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x53FCA80", Offset = "0x53FBE80", VA = "0x1853FCA80")]
	public IPEndPoint AKDGFDDMFLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x53FCBC0", Offset = "0x53FBFC0", VA = "0x1853FCBC0")]
	public byte GMIGKIAKAAD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53FCBC0", Offset = "0x53FBFC0", VA = "0x1853FCBC0")]
	public sbyte BCNBAGMAFGP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2798FD0", Offset = "0x27983D0", VA = "0x182798FD0")]
	public T[] EHLJPJFOLMC<T>(ushort BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x53FD620", Offset = "0x53FCA20", VA = "0x1853FD620")]
	public bool[] PGPGJCGMPNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x53FD550", Offset = "0x53FC950", VA = "0x1853FD550")]
	public ushort[] NAPBKGFKBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x53FCE50", Offset = "0x53FC250", VA = "0x1853FCE50")]
	public short[] FNHOKLPNHKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x53FCDA0", Offset = "0x53FC1A0", VA = "0x1853FCDA0")]
	public int[] EMIKBANIKJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x53FD1A0", Offset = "0x53FC5A0", VA = "0x1853FD1A0")]
	public uint[] JBNMPCDPDED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x53FD4A0", Offset = "0x53FC8A0", VA = "0x1853FD4A0")]
	public float[] LPBBADDOFJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x53FD080", Offset = "0x53FC480", VA = "0x1853FD080")]
	public double[] HAAEGLGJCJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x53FD460", Offset = "0x53FC860", VA = "0x1853FD460")]
	public long[] JMNFJMACNEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x53FCD60", Offset = "0x53FC160", VA = "0x1853FCD60")]
	public ulong[] DHLNIFKELJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x53FCF50", Offset = "0x53FC350", VA = "0x1853FCF50")]
	public string[] GOGJHEOECMO(int OHDEANMFEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53FCD20", Offset = "0x53FC120", VA = "0x1853FCD20")]
	public bool DCDIKILNOBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x53FCED0", Offset = "0x53FC2D0", VA = "0x1853FCED0")]
	public char GIPGHKLHFEE()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x53FCED0", Offset = "0x53FC2D0", VA = "0x1853FCED0")]
	public ushort OIIDKPDMDOB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x53FCDE0", Offset = "0x53FC1E0", VA = "0x1853FCDE0")]
	public short FJDIPPMDIEA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x53FCC40", Offset = "0x53FC040", VA = "0x1853FCC40")]
	public long BGIEHNEBIFL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x53FD5B0", Offset = "0x53FC9B0", VA = "0x1853FD5B0")]
	public ulong OOFHIHPOJGC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x53FCB50", Offset = "0x53FBF50", VA = "0x1853FCB50")]
	public int ANHENDGAJPK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x53FD4E0", Offset = "0x53FC8E0", VA = "0x1853FD4E0")]
	public uint NAIKALMDHGG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53FCCB0", Offset = "0x53FC0B0", VA = "0x1853FCCB0")]
	public float BMHHHJKCGAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53FD0C0", Offset = "0x53FC4C0", VA = "0x1853FD0C0")]
	public double HEJKJOHENJF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x53FD1E0", Offset = "0x53FC5E0", VA = "0x1853FD1E0")]
	public string JCIPMJBINMH(int HPAEJNPCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x53FD130", Offset = "0x53FC530", VA = "0x1853FD130")]
	public ArraySegment<byte> HLAHBOLAANF(int DPBEIPGOMHN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x53FCE90", Offset = "0x53FC290", VA = "0x1853FCE90")]
	public sbyte[] GHGMFDMOKGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x53FD420", Offset = "0x53FC820", VA = "0x1853FD420")]
	public byte[] JKCENPDFNNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x53FD590", Offset = "0x53FC990", VA = "0x1853FD590")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x53EA1B0", Offset = "0x53E95B0", VA = "0x1853EA1B0")]
	public CDFPBCFPMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x53EA230", Offset = "0x53E9630", VA = "0x1853EA230")]
	public CDFPBCFPMJN(bool PGDDLOIAJIH, int BIMOGKLBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x53E9C60", Offset = "0x53E9060", VA = "0x1853E9C60")]
	public static CDFPBCFPMJN NIFBMJKLADJ(string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x53E9560", Offset = "0x53E8960", VA = "0x1853E9560")]
	public void BDPCBDCKLCM(int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5290", Offset = "0x1CF4690", VA = "0x181CF5290")]
	public void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x53E96E0", Offset = "0x53E8AE0", VA = "0x1853E96E0")]
	public void DLPKKGHALBO(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x53E9C10", Offset = "0x53E9010", VA = "0x1853E9C10")]
	public void DLPKKGHALBO(double FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x53E99B0", Offset = "0x53E8DB0", VA = "0x1853E99B0")]
	public void DLPKKGHALBO(long FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x53E99B0", Offset = "0x53E8DB0", VA = "0x1853E99B0")]
	public void DLPKKGHALBO(ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x53E98C0", Offset = "0x53E8CC0", VA = "0x1853E98C0")]
	public void DLPKKGHALBO(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x53E98C0", Offset = "0x53E8CC0", VA = "0x1853E98C0")]
	public void DLPKKGHALBO(uint FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x53E9850", Offset = "0x53E8C50", VA = "0x1853E9850")]
	public void DLPKKGHALBO(char FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x53E9850", Offset = "0x53E8C50", VA = "0x1853E9850")]
	public void DLPKKGHALBO(ushort FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x53E9850", Offset = "0x53E8C50", VA = "0x1853E9850")]
	public void DLPKKGHALBO(short FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x53E9950", Offset = "0x53E8D50", VA = "0x1853E9950")]
	public void DLPKKGHALBO(sbyte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x53E9950", Offset = "0x53E8D50", VA = "0x1853E9950")]
	public void DLPKKGHALBO(byte FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x53E9780", Offset = "0x53E8B80", VA = "0x1853E9780")]
	public void DLPKKGHALBO(byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x53E9480", Offset = "0x53E8880", VA = "0x1853E9480")]
	public void CPGKNLMJLCN(sbyte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x53E9480", Offset = "0x53E8880", VA = "0x1853E9480")]
	public void BDNGGMPMBPK(byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x53E97F0", Offset = "0x53E8BF0", VA = "0x1853E97F0")]
	public void DLPKKGHALBO(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x53E9DB0", Offset = "0x53E91B0", VA = "0x1853E9DB0")]
	public void PCIJOEPBJDO(Array LDHKIFPGEBO, int LAHMMIFMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x53E9E90", Offset = "0x53E9290", VA = "0x1853E9E90")]
	public void PCIJOEPBJDO(float[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x53E9CD0", Offset = "0x53E90D0", VA = "0x1853E9CD0")]
	public void PCIJOEPBJDO(double[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x53E9CD0", Offset = "0x53E90D0", VA = "0x1853E9CD0")]
	public void PCIJOEPBJDO(long[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x53E9CD0", Offset = "0x53E90D0", VA = "0x1853E9CD0")]
	public void PCIJOEPBJDO(ulong[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x53E9E90", Offset = "0x53E9290", VA = "0x1853E9E90")]
	public void PCIJOEPBJDO(int[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x53E9E90", Offset = "0x53E9290", VA = "0x1853E9E90")]
	public void PCIJOEPBJDO(uint[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x53E9F70", Offset = "0x53E9370", VA = "0x1853E9F70")]
	public void PCIJOEPBJDO(ushort[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x53E9F70", Offset = "0x53E9370", VA = "0x1853E9F70")]
	public void PCIJOEPBJDO(short[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x53E9480", Offset = "0x53E8880", VA = "0x1853E9480")]
	public void PCIJOEPBJDO(bool[] FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53EA050", Offset = "0x53E9450", VA = "0x1853EA050")]
	public void PCIJOEPBJDO(string[] FDFHGIHHGHO, int JABCANLAIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x53E9600", Offset = "0x53E8A00", VA = "0x1853E9600")]
	public void DLPKKGHALBO(IPEndPoint KFCOPHOBJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x53E96D0", Offset = "0x53E8AD0", VA = "0x1853E96D0")]
	public void DLPKKGHALBO(string FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x53E9A00", Offset = "0x53E8E00", VA = "0x1853E9A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F01F40", Offset = "0x3F01340", VA = "0x183F01F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CBNFLMHKHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x478CF80", Offset = "0x478C380", VA = "0x18478CF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FGPINJNJPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3588850", Offset = "0x3587C50", VA = "0x183588850")]
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
	[Cpp2IlInjected.Address(RVA = "0x53FC8F0", Offset = "0x53FBCF0", VA = "0x1853FC8F0")]
	public OFBPKAEALKE(int OHDEANMFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2490A90", Offset = "0x248FE90", VA = "0x182490A90", Slot = "4")]
	protected virtual ulong AOEJBCJDJGM<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x53FC7C0", Offset = "0x53FBBC0", VA = "0x1853FC7C0", Slot = "5")]
	protected virtual LNLMIGLPODB OLCFNJGCLMK(OMNJGEPLANP AGGHEBELANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2786150", Offset = "0x2785550", VA = "0x182786150", Slot = "6")]
	protected virtual void DALMBAMGPMJ<T>(CDFPBCFPMJN NADLGELBCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53FC740", Offset = "0x53FBB40", VA = "0x1853FC740")]
	public void GLLAGINBJNG(OMNJGEPLANP AGGHEBELANL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27864C0", Offset = "0x27858C0", VA = "0x1827864C0")]
	public void POJMGPDPHDM<T>(CDFPBCFPMJN NADLGELBCMH, T IBJGFCKNNLM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x53FC6F0", Offset = "0x53FBAF0", VA = "0x1853FC6F0")]
	public void AJIEKJPBJJH(OMNJGEPLANP AGGHEBELANL, object MFIBKFGAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2786340", Offset = "0x2785740", VA = "0x182786340")]
	public void HACFJPCHIEA<T>(Action<T> AABCBJKLFOF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27861C0", Offset = "0x27855C0", VA = "0x1827861C0")]
	public void HACFJPCHIEA<T, TUserData>(Action<T, TUserData> AABCBJKLFOF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LABIPDPJAAD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x53ECFD0", Offset = "0x53EC3D0", VA = "0x1853ECFD0")]
	public LABIPDPJAAD(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NPCCOCACOGJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x53FC300", Offset = "0x53FB700", VA = "0x1853FC300")]
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
		[Cpp2IlInjected.Address(RVA = "0x3576CB0", Offset = "0x35760B0", VA = "0x183576CB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x31F5640", Offset = "0x31F4A40", VA = "0x1831F5640", Slot = "7")]
		public override void DOLOECNGIFP(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x31F4680", Offset = "0x31F3A80", VA = "0x1831F4680", Slot = "8")]
		public override void DHPLJLPDCPE(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x31F66E0", Offset = "0x31F5AE0", VA = "0x1831F66E0", Slot = "9")]
		public override void GMJJOLHKHMH(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x31F3B20", Offset = "0x31F2F20", VA = "0x1831F3B20", Slot = "10")]
		public override void DCLFOCLPNJP(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x31F68A0", Offset = "0x31F5CA0", VA = "0x1831F68A0")]
		protected TProperty[] JNMLNGFCMEH(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x31F3AB0", Offset = "0x31F2EB0", VA = "0x1831F3AB0")]
		protected TProperty[] AOFJBCDJJPH(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x31F69A0", Offset = "0x31F5DA0", VA = "0x1831F69A0", Slot = "4")]
		public override void OHCMDEDMAIL(MethodInfo IPELOFEOHEJ, MethodInfo MFIGOHDLPEK, ABAPKHBFEEA ADAMDPHPFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x31FB460", Offset = "0x31FA860", VA = "0x1831FB460")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D976B0", Offset = "0x3D96AB0", VA = "0x183D976B0", Slot = "5")]
		public override void MBGBGOCHAHN(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D97820", Offset = "0x3D96C20", VA = "0x183D97820", Slot = "6")]
		public override void POJMGPDPHDM(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3D97570", Offset = "0x3D96970", VA = "0x183D97570", Slot = "7")]
		public override void DOLOECNGIFP(TClass FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D974D0", Offset = "0x3D968D0", VA = "0x183D974D0", Slot = "8")]
		public override void DHPLJLPDCPE(TClass FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x359BFC0", Offset = "0x359B3C0", VA = "0x18359BFC0")]
		protected MMMJKEPLNNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FIBGAGDEHAI<T> : EJDLIOJPPEP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x358AB70", Offset = "0x3589F70", VA = "0x18358AB70", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x358ABE0", Offset = "0x3589FE0", VA = "0x18358ABE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x358AB00", Offset = "0x3589F00", VA = "0x18358AB00", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x357A2F0", Offset = "0x35796F0", VA = "0x18357A2F0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public FIBGAGDEHAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BOFKACEKKMN<T> : EJDLIOJPPEP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x462AF70", Offset = "0x462A370", VA = "0x18462AF70", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x358ABE0", Offset = "0x3589FE0", VA = "0x18358ABE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x462AF00", Offset = "0x462A300", VA = "0x18462AF00", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x357A2F0", Offset = "0x35796F0", VA = "0x18357A2F0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public BOFKACEKKMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FGCLMJIHIGD<T> : EJDLIOJPPEP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x357C2E0", Offset = "0x357B6E0", VA = "0x18357C2E0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x357C350", Offset = "0x357B750", VA = "0x18357C350", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x357C270", Offset = "0x357B670", VA = "0x18357C270", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x357C210", Offset = "0x357B610", VA = "0x18357C210", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public FGCLMJIHIGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OEDOBFHOBNM<T> : EJDLIOJPPEP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC990", Offset = "0x3EEBD90", VA = "0x183EEC990", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x357C350", Offset = "0x357B750", VA = "0x18357C350", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC920", Offset = "0x3EEBD20", VA = "0x183EEC920", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x357C210", Offset = "0x357B610", VA = "0x18357C210", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public OEDOBFHOBNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EAPILHHOFED<T> : EJDLIOJPPEP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x31D1C70", Offset = "0x31D1070", VA = "0x1831D1C70", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x31D1CE0", Offset = "0x31D10E0", VA = "0x1831D1CE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x31D1C00", Offset = "0x31D1000", VA = "0x1831D1C00", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x31D1BA0", Offset = "0x31D0FA0", VA = "0x1831D1BA0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public EAPILHHOFED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EFMBOEHJJMF<T> : EJDLIOJPPEP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x31DF4C0", Offset = "0x31DE8C0", VA = "0x1831DF4C0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x31D1CE0", Offset = "0x31D10E0", VA = "0x1831D1CE0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x31DF450", Offset = "0x31DE850", VA = "0x1831DF450", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x31D1BA0", Offset = "0x31D0FA0", VA = "0x1831D1BA0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public EFMBOEHJJMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CGFBDIJMNLL<T> : EJDLIOJPPEP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x37DAF10", Offset = "0x37DA310", VA = "0x1837DAF10", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x37DAF80", Offset = "0x37DA380", VA = "0x1837DAF80", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x487B9F0", Offset = "0x487ADF0", VA = "0x18487B9F0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37DAE40", Offset = "0x37DA240", VA = "0x1837DAE40", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public CGFBDIJMNLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class IOKPEDPAMJC<T> : EJDLIOJPPEP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x37DAF10", Offset = "0x37DA310", VA = "0x1837DAF10", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x37DAF80", Offset = "0x37DA380", VA = "0x1837DAF80", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x37DAEA0", Offset = "0x37DA2A0", VA = "0x1837DAEA0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x37DAE40", Offset = "0x37DA240", VA = "0x1837DAE40", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public IOKPEDPAMJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FEJHPADINKH<T> : EJDLIOJPPEP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x357A3C0", Offset = "0x35797C0", VA = "0x18357A3C0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x357A430", Offset = "0x3579830", VA = "0x18357A430", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x357A350", Offset = "0x3579750", VA = "0x18357A350", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x357A2F0", Offset = "0x35796F0", VA = "0x18357A2F0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public FEJHPADINKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LMMFCGNDJMP<T> : EJDLIOJPPEP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F420", Offset = "0x3B6E820", VA = "0x183B6F420", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F490", Offset = "0x3B6E890", VA = "0x183B6F490", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F3B0", Offset = "0x3B6E7B0", VA = "0x183B6F3B0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x31D1BA0", Offset = "0x31D0FA0", VA = "0x1831D1BA0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public LMMFCGNDJMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MGJDJMBEKBH<T> : EJDLIOJPPEP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D51E40", Offset = "0x3D51240", VA = "0x183D51E40", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D51EB0", Offset = "0x3D512B0", VA = "0x183D51EB0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D51DD0", Offset = "0x3D511D0", VA = "0x183D51DD0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x37DAE40", Offset = "0x37DA240", VA = "0x1837DAE40", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x31D1D40", Offset = "0x31D1140", VA = "0x1831D1D40")]
		public MGJDJMBEKBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CMGPCHKBGJN<T> : MMMJKEPLNNH<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x49638C0", Offset = "0x4962CC0", VA = "0x1849638C0", Slot = "12")]
		protected override void LFHEIOOFJFB(CDFPBCFPMJN LKDONMJJPCN, char LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x49638F0", Offset = "0x4962CF0", VA = "0x1849638F0", Slot = "11")]
		protected override void PGEDECGFPJA(OMNJGEPLANP FEDGKNJBNJN, [Out] char LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x35959D0", Offset = "0x3594DD0", VA = "0x1835959D0")]
		public CMGPCHKBGJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class PIMHKNFNHML<T> : MMMJKEPLNNH<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8E90", Offset = "0x3FC8290", VA = "0x183FC8E90", Slot = "12")]
		protected override void LFHEIOOFJFB(CDFPBCFPMJN LKDONMJJPCN, IPEndPoint LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8EC0", Offset = "0x3FC82C0", VA = "0x183FC8EC0", Slot = "11")]
		protected override void PGEDECGFPJA(OMNJGEPLANP FEDGKNJBNJN, [Out] IPEndPoint LGONKMCLPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x35959D0", Offset = "0x3594DD0", VA = "0x1835959D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3594DF0", Offset = "0x35941F0", VA = "0x183594DF0")]
		public FLNCCLDNKDC(int HPAEJNPCJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3594D10", Offset = "0x3594110", VA = "0x183594D10", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3594D80", Offset = "0x3594180", VA = "0x183594D80", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3594CA0", Offset = "0x35940A0", VA = "0x183594CA0", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3594C30", Offset = "0x3594030", VA = "0x183594C30", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A0C550", Offset = "0x3A0B950", VA = "0x183A0C550")]
		public JOFECBOFOCB(PropertyInfo EEAABMKADCD, Type NKHHDFAIIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C3E0", Offset = "0x3A0B7E0", VA = "0x183A0C3E0", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C4A0", Offset = "0x3A0B8A0", VA = "0x183A0C4A0", Slot = "6")]
		public override void POJMGPDPHDM(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C320", Offset = "0x3A0B720", VA = "0x183A0C320", Slot = "7")]
		public override void DOLOECNGIFP(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C2C0", Offset = "0x3A0B6C0", VA = "0x183A0C2C0", Slot = "8")]
		public override void DHPLJLPDCPE(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C380", Offset = "0x3A0B780", VA = "0x183A0C380", Slot = "9")]
		public override void GMJJOLHKHMH(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C260", Offset = "0x3A0B660", VA = "0x183A0C260", Slot = "10")]
		public override void DCLFOCLPNJP(T FHOALAKLICK, CDFPBCFPMJN LKDONMJJPCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BMIBLBACEFL<T> : JOFECBOFOCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
		public BMIBLBACEFL(PropertyInfo EEAABMKADCD, Type NKHHDFAIIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x461D870", Offset = "0x461CC70", VA = "0x18461D870", Slot = "5")]
		public override void MBGBGOCHAHN(T FHOALAKLICK, OMNJGEPLANP FEDGKNJBNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x461D930", Offset = "0x461CD30", VA = "0x18461D930", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x462DE70", Offset = "0x462D270", VA = "0x18462DE70")]
		public BPPAIPECAKN(List<FCNCCLBKGEH<T>> CILLNINJFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x462DDC0", Offset = "0x462D1C0", VA = "0x18462DDC0")]
		public void POJMGPDPHDM(T MBCPMMHPENP, CDFPBCFPMJN NADLGELBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x462DD10", Offset = "0x462D110", VA = "0x18462DD10")]
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
	[Cpp2IlInjected.Address(RVA = "0x53E93E0", Offset = "0x53E87E0", VA = "0x1853E93E0")]
	public BKKCPGNDHLH(int OHDEANMFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x243BEE0", Offset = "0x243B2E0", VA = "0x18243BEE0")]
	private BPPAIPECAKN<T> ENGOFDINFCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x243CE30", Offset = "0x243C230", VA = "0x18243CE30")]
	public void LIBHGHNAKIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x243BE60", Offset = "0x243B260", VA = "0x18243BE60")]
	public bool AFFCBAMFOKP<T>(OMNJGEPLANP AGGHEBELANL, T DAPOBFHGAGK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x243CDD0", Offset = "0x243C1D0", VA = "0x18243CDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
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
		[Cpp2IlInjected.Address(RVA = "0x53FE300", Offset = "0x53FD700", VA = "0x1853FE300")]
		get
		{
			return default(HDJCEBAOBLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int MJGPMBIPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x53FD740", Offset = "0x53FCB40", VA = "0x1853FD740")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x53FE290", Offset = "0x53FD690", VA = "0x1853FE290")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DFFGJFALMKI KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x53FDE60", Offset = "0x53FD260", VA = "0x1853FDE60")]
		get
		{
			return default(DFFGJFALMKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x53FDEC0", Offset = "0x53FD2C0", VA = "0x1853FDEC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KEDMPCJKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x53FE3F0", Offset = "0x53FD7F0", VA = "0x1853FE3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint AECGDNFAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x53FD6C0", Offset = "0x53FCAC0", VA = "0x1853FD6C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? PCLMMIJBDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x53FE2D0", Offset = "0x53FD6D0", VA = "0x1853FE2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? BCFIGHLFLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x53FDC60", Offset = "0x53FD060", VA = "0x1853FDC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CEDBHPMAJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x53FDE90", Offset = "0x53FD290", VA = "0x1853FDE90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x53FD770", Offset = "0x53FCB70", VA = "0x1853FD770")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? KKBPLAHHFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88D310", Offset = "0x88C710", VA = "0x18088D310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x53FE730", Offset = "0x53FDB30", VA = "0x1853FE730")]
	public PDDNOBKGNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x53FE680", Offset = "0x53FDA80", VA = "0x1853FE680")]
	internal PDDNOBKGNGD(byte[] PEBEDGMMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x53FD940", Offset = "0x53FCD40", VA = "0x1853FD940")]
	public static PDDNOBKGNGD BHHFOJICACA(byte[] PEBEDGMMHMC, DateTime CIFIOPIECHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x53FDA60", Offset = "0x53FCE60", VA = "0x1853FDA60")]
	internal void BMEDGLAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x53FDFD0", Offset = "0x53FD3D0", VA = "0x1853FDFD0")]
	private void IBFMIJPEFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x53FE420", Offset = "0x53FD820", VA = "0x1853FE420")]
	private DateTime? MMCCDKKODFE(int ABOMIAEBHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x53FDC90", Offset = "0x53FD090", VA = "0x1853FDC90")]
	private void DJILNNCJBNI(int ABOMIAEBHEB, DateTime? FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x53FDF00", Offset = "0x53FD300", VA = "0x1853FDF00")]
	private ulong HAMIKKKCBHF(int ABOMIAEBHEB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x53FE330", Offset = "0x53FD730", VA = "0x1853FE330")]
	private void LNFAMIFIKJI(int ABOMIAEBHEB, ulong FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x53FE1A0", Offset = "0x53FD5A0", VA = "0x1853FE1A0")]
	private uint IOKOPFJMKEE(int ABOMIAEBHEB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x52D87F0", Offset = "0x52D7BF0", VA = "0x1852D87F0")]
	private static uint KIHJHIBOBKA(uint LGHEBJJLAGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x53FE230", Offset = "0x53FD630", VA = "0x1853FE230")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F41F0", Offset = "0x53F35F0", VA = "0x1853F41F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x53F4200", Offset = "0x53F3600", VA = "0x1853F4200")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F8380", Offset = "0x53F7780", VA = "0x1853F8380", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int AGNMFHLCHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x53F89A0", Offset = "0x53F7DA0", VA = "0x1853F89A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint ONLFINDBKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x53F8340", Offset = "0x53F7740", VA = "0x1853F8340", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily AHMHGNPKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B02DE0", Offset = "0x3B021E0", VA = "0x183B02DE0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x53F8AB0", Offset = "0x53F7EB0", VA = "0x1853F8AB0")]
	public HFHAGJCLOHC(AddressFamily NCFCOAFMKAG, GFLHNGHENMJ MKEENDPKKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x53F83E0", Offset = "0x53F77E0", VA = "0x1853F83E0", Slot = "8")]
	public bool LLGNCOAICJE(IPEndPoint KFCOPHOBJAH, EJGELFBDALL KGFBICHDELG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x53F83A0", Offset = "0x53F77A0", VA = "0x1853F83A0", Slot = "9")]
	public int LHKLOONHCGP(byte[] BGIIPDEPEFH, int ABOMIAEBHEB, int BFFGCOIILMK, IPEndPoint GCKDCFJJNCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x53F89C0", Offset = "0x53F7DC0", VA = "0x1853F89C0", Slot = "10")]
	public int POIKAEFEICL(byte[] BGIIPDEPEFH, EndPoint IIHBLKHJCFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x53F8360", Offset = "0x53F7760", VA = "0x1853F8360", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x53FA970", Offset = "0x53F9D70", VA = "0x1853FA970")]
	public KHHJJMPCIPL(byte[] PNNLDDMFPIB, int JKBIJPKDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C56D0", Offset = "0x7C4AD0", VA = "0x1807C56D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53FA930", Offset = "0x53F9D30", VA = "0x1853FA930", Slot = "4")]
	public bool Equals(KHHJJMPCIPL AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x53FA880", Offset = "0x53F9C80", VA = "0x1853FA880", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
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
	[Cpp2IlInjected.Address(RVA = "0x53F97A0", Offset = "0x53F8BA0", VA = "0x1853F97A0")]
	public IGMNGLPEMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x53F8FF0", Offset = "0x53F83F0", VA = "0x1853F8FF0")]
	public void HDNPPDGOCNJ(IPEndPoint KFCOPHOBJAH, byte[] KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x53F9230", Offset = "0x53F8630", VA = "0x1853F9230")]
	public void HGJFECBDAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x53F96B0", Offset = "0x53F8AB0", VA = "0x1853F96B0")]
	private byte[] OAEKIDDOEIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x53F8B60", Offset = "0x53F7F60", VA = "0x1853F8B60", Slot = "4")]
	public override void EIIDOCGEBJP(IPEndPoint KFCOPHOBJAH, byte[] MFNOAEFOKBK, int ABOMIAEBHEB, int CBKFAHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x53F9310", Offset = "0x53F8710", VA = "0x1853F9310", Slot = "5")]
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
