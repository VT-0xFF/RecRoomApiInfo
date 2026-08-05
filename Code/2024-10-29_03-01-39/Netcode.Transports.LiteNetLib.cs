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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BGJCNFLKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum FAEJNDAPFGM
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
		private NetworkManager APHBNGOFJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, PIMJAPMNFFF> INBJPHKHIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FGKGMOGMHDC PFKDPDLAHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NANDFMLLKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FAEJNDAPFGM CJPINMFILFD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong EJANGENCOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IFDJPFECKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x62ADA50", Offset = "0x62ACA50", VA = "0x1862ADA50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62ACFE0", Offset = "0x62ABFE0", VA = "0x1862ACFE0")]
		public void RecRoom_SetEncryptionInfo(ulong OMMJPGKNJPL, byte[] MLAECOMLIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62ACFC0", Offset = "0x62ABFC0", VA = "0x1862ACFC0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62ACE90", Offset = "0x62ABE90", VA = "0x1862ACE90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62AD950", Offset = "0x62AC950", VA = "0x1862AD950")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62AD100", Offset = "0x62AC100", VA = "0x1862AD100", Slot = "6")]
		public override void Send(ulong JGJCMENHAMP, ArraySegment<byte> CONAFKKIHKL, NetworkDelivery GJBEEMEGCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62ACF80", Offset = "0x62ABF80", VA = "0x1862ACF80", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong JGJCMENHAMP, [Out] ArraySegment<byte> NDBAHEIEDNL, [Out] float PBEIHIEFHNH)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62AD3F0", Offset = "0x62AC3F0", VA = "0x1862AD3F0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62AD870", Offset = "0x62AC870", VA = "0x1862AD870", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62AC560", Offset = "0x62AB560", VA = "0x1862AC560", Slot = "10")]
		public override void DisconnectRemoteClient(ulong JGJCMENHAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62AC410", Offset = "0x62AB410", VA = "0x1862AC410", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62AC870", Offset = "0x62AB870", VA = "0x1862AC870", Slot = "12")]
		public override ulong GetCurrentRtt(ulong JGJCMENHAMP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x62AD380", Offset = "0x62AC380", VA = "0x1862AD380", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62AC910", Offset = "0x62AB910", VA = "0x1862AC910", Slot = "14")]
		public override void Initialize([Optional] NetworkManager APHBNGOFJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62ACDC0", Offset = "0x62ABDC0", VA = "0x1862ACDC0")]
		private BFBHMELCEGO OCHKGAABIDG(NetworkDelivery PFCMGBLCCPJ)
		{
			return default(BFBHMELCEGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x62AC7B0", Offset = "0x62AB7B0", VA = "0x1862AC7B0", Slot = "15")]
		private void FJFOCAAGMAL(PIMJAPMNFFF OAFCCOHNLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62ACD00", Offset = "0x62ABD00", VA = "0x1862ACD00", Slot = "16")]
		private void MJFLKCEJDDP(PIMJAPMNFFF OAFCCOHNLKK, HIKOMOJFNEO LNELMJHNNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "17")]
		private void PGAKCFNGGBI(IPEndPoint DNDHMKHNPGC, SocketError MLIPJOGBHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62ACAD0", Offset = "0x62ABAD0", VA = "0x1862ACAD0", Slot = "18")]
		private void JCADFCNPFEN(PIMJAPMNFFF OAFCCOHNLKK, GJCLAFLBFIB EEKHIEJPCBE, byte KFHLCDIGPBB, BFBHMELCEGO EJCAEKLNGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62AC6D0", Offset = "0x62AB6D0", VA = "0x1862AC6D0")]
		private void EKLEANEBEHC(int MLDINGBBEHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "19")]
		private void MEMPDPDBEEO(IPEndPoint MCHFMPKJCEL, GJCLAFLBFIB EEKHIEJPCBE, JDDNPFDFMDP OONCMOFOHFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "20")]
		private void CCKGILKNALC(PIMJAPMNFFF OAFCCOHNLKK, int MCAJJOHBJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62AC380", Offset = "0x62AB380", VA = "0x1862AC380", Slot = "21")]
		private void BDPJOGCOHIE(GADLKNIPMJM ONMEAHDGGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62AC3E0", Offset = "0x62AB3E0", VA = "0x1862AC3E0")]
		private ulong DLHAGOBCEBG(PIMJAPMNFFF OAFCCOHNLKK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62ACCE0", Offset = "0x62ABCE0", VA = "0x1862ACCE0")]
		private static int JFAFDDGICLL(float OPFDDHFIGGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62AD970", Offset = "0x62AC970", VA = "0x1862AD970")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CINHLFPOFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PIMJAPMNFFF OOODDODFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<GJKPGHKCPAN> MBLIANOAGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NJBJOGILKAF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x629FD20", Offset = "0x629ED20", VA = "0x18629FD20")]
	protected CINHLFPOFAD(PIMJAPMNFFF OAFCCOHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x629FC00", Offset = "0x629EC00", VA = "0x18629FC00")]
	public void FEJGGDAANHE(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x629FC60", Offset = "0x629EC60", VA = "0x18629FC60")]
	protected void FKIFANHLGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x629FCE0", Offset = "0x629ECE0", VA = "0x18629FCE0")]
	public bool OHBFPHADBNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OOFPFEMBJGP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PENAEBGOMCJ(GJKPGHKCPAN DOGNCNMPHPI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum JEKLLPDIBJG
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
public class GADLKNIPMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FGKGMOGMHDC GCPBMJGPCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JAPGIEMEBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal BKCDPOJHDKA HOOKADNODKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint ACIMBPHCLHN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JEKLLPDIBJG KDONPBPDNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAC0", Offset = "0x8DCAC0", VA = "0x1808DDAC0")]
		[CompilerGenerated]
		get
		{
			return default(JEKLLPDIBJG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C7130", Offset = "0x9C6130", VA = "0x1809C7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62A7EA0", Offset = "0x62A6EA0", VA = "0x1862A7EA0")]
	internal void NKPIHAJDJOI(BKCDPOJHDKA GIHHDGCJBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62A7E10", Offset = "0x62A6E10", VA = "0x1862A7E10")]
	private bool GNANBPOGDGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62A7F00", Offset = "0x62A6F00", VA = "0x1862A7F00")]
	internal GADLKNIPMJM(IPEndPoint MCHFMPKJCEL, BKCDPOJHDKA PADLFCEBEFI, FGKGMOGMHDC EDPOEFODAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62A7E40", Offset = "0x62A6E40", VA = "0x1862A7E40")]
	public PIMJAPMNFFF KDDEGEJMIEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JDDNPFDFMDP
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OMAKAOCALGD
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
public struct HIKOMOJFNEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OMAKAOCALGD IIHJFLDNEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError MDKFFLBHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GJCLAFLBFIB IKLBHMMFKBM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BGJCNFLKBNB
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGJKNHGIPIL(PIMJAPMNFFF OAFCCOHNLKK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDOOJMLDNHM(PIMJAPMNFFF OAFCCOHNLKK, HIKOMOJFNEO LNELMJHNNBN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFCILECOBEP(IPEndPoint DNDHMKHNPGC, SocketError MLIPJOGBHMN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBLKOGMMLHA(PIMJAPMNFFF OAFCCOHNLKK, GJCLAFLBFIB EEKHIEJPCBE, byte KFHLCDIGPBB, BFBHMELCEGO EJCAEKLNGJP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNNMICNDNOP(IPEndPoint MCHFMPKJCEL, GJCLAFLBFIB EEKHIEJPCBE, JDDNPFDFMDP OONCMOFOHFE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFAHJEJIGBN(PIMJAPMNFFF OAFCCOHNLKK, int MCAJJOHBJMM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFAACOAAAME(GADLKNIPMJM ONMEAHDGGOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJFHEBAFAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLAKOKPPMAE(PIMJAPMNFFF OAFCCOHNLKK, object JDEPBMOPKHE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJBCLKJGEJB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECILDJKFMPH(BLGGONKOCOH DOGNCNMPHPI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NMCBAMLMBGE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLELGGPIKGC(PIMJAPMNFFF OAFCCOHNLKK, IPEndPoint KJHDKHAKALA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BKCDPOJHDKA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int EPPKPEDGDHP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long PNIMPDAHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte NIHNOJEMDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] GJMALNIGOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly GGNKJMOIFFB CKGGEHCOAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int HMJGDPHOIEE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x629DCC0", Offset = "0x629CCC0", VA = "0x18629DCC0")]
	private BKCDPOJHDKA(long IOFOGCOJGNF, byte AHPIHGKMLMP, int NAJNBMNONGI, byte[] LIMAPKKEMCE, GGNKJMOIFFB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x629D860", Offset = "0x629C860", VA = "0x18629D860")]
	public static int BLJHDLOFCHH(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x629D8C0", Offset = "0x629C8C0", VA = "0x18629D8C0")]
	public static BKCDPOJHDKA JCJODPFFKPO(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x629DAE0", Offset = "0x629CAE0", VA = "0x18629DAE0")]
	public static GJKPGHKCPAN LEEHKMHDKFC(MCIJLHENOLO DKIABIIOKPJ, SocketAddress PAOPPEAPDON, long NBOOKJCOEHB, int NAJNBMNONGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LFIDFLKJEFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long PNIMPDAHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte NIHNOJEMDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int HMJGDPHOIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool KLHGDICEBMP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62AC330", Offset = "0x62AB330", VA = "0x1862AC330")]
	private LFIDFLKJEFE(long IOFOGCOJGNF, byte AHPIHGKMLMP, int KLKLBENOIGP, bool JHLCHIGEIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62ABFF0", Offset = "0x62AAFF0", VA = "0x1862ABFF0")]
	public static LFIDFLKJEFE JCJODPFFKPO(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62AC140", Offset = "0x62AB140", VA = "0x1862AC140")]
	public static GJKPGHKCPAN LEEHKMHDKFC(long NBOOKJCOEHB, byte GFGMIHJGNEM, int IANKAMKEOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62AC230", Offset = "0x62AB230", VA = "0x1862AC230")]
	public static GJKPGHKCPAN NKDOEPHBCIL(PIMJAPMNFFF OAFCCOHNLKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum CLBHBPGDJML
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BMNAFNLJIAH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEGLHLBIOOC(IPEndPoint AKEFPOLIHLD, IPEndPoint MCHFMPKJCEL, string NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJGIIKHEKAJ(IPEndPoint HJKEAKFNKJN, CLBHBPGDJML PFCMGBLCCPJ, string NANMDIJGGLP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HACBLAKMOGD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JHBLBPGPKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint INIJGGBDGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint ACIMBPHCLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string FMPODIFCDLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BKNJHIBDBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint ODGHNFLIMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CLBHBPGDJML BFKMCKBKOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string FMPODIFCDLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class AHLBPNNLMAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EEMJBMBAGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string FMPODIFCDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AHLBPNNLMAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class MGFMIHJODAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EEMJBMBAGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint KJMKGGELPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FMPODIFCDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MGFMIHJODAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class EDMBOFBAJGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FMPODIFCDLB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NNFIHOHBEEC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8BC650", Offset = "0x8BB650", VA = "0x1808BC650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EDMBOFBAJGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FGKGMOGMHDC DKLJFMHIEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<JHBLBPGPKPH> HCANOHEPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BKNJHIBDBAK> OODNFDNLIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GGNKJMOIFFB IHLDPJADIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MCIJLHENOLO GCBAMIMNILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CANIAEGAPDO EEDCNIMHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BMNAFNLJIAH JEKENIEFFPF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int DLABKNHNPAE = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool EAGGJKIFMKJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62A9EC0", Offset = "0x62A8EC0", VA = "0x1862A9EC0")]
	internal HACBLAKMOGD(FGKGMOGMHDC JIGACHAEDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62A9D40", Offset = "0x62A8D40", VA = "0x1862A9D40")]
	internal void MDGFEADBKDK(IPEndPoint DGINFHGLHBP, GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F89590", Offset = "0x2F88590", VA = "0x182F89590")]
	private void JFEIIEKCNDG<T>(T DOGNCNMPHPI, IPEndPoint CECLKDDLGFE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62A98B0", Offset = "0x62A88B0", VA = "0x1862A98B0")]
	private void AEGLHLBIOOC(AHLBPNNLMAF AKHAOEGEMOD, IPEndPoint DGINFHGLHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62A9BE0", Offset = "0x62A8BE0", VA = "0x1862A9BE0")]
	private void KBBLLEKHBGA(MGFMIHJODAL AKHAOEGEMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62A9A40", Offset = "0x62A8A40", VA = "0x1862A9A40")]
	private void EFOONMJAODL(EDMBOFBAJGM AKHAOEGEMOD, IPEndPoint DGINFHGLHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BFBHMELCEGO : byte
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
public enum DHIHKFPDOMM : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JJHPHLDHPGE
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] NAFMNOEDFLH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int HADHNLGPEJA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int FHIKEAJPOMF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KEGFMCPFCHD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x629C7D0", Offset = "0x629B7D0", VA = "0x18629C7D0")]
	public KEGFMCPFCHD(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AFDADLAGHAM : KEGFMCPFCHD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x629C7D0", Offset = "0x629B7D0", VA = "0x18629C7D0")]
	public AFDADLAGHAM(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IAGKGLIDGOC
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
public interface CEKKCJOAOLD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHLOLEJCLIE(IAGKGLIDGOC GAMNIEOKDIE, string DIENLBCMIGK, params object[] NABJMDALPIF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LAHEMPJDMJH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static CEKKCJOAOLD KFMNNBGBLAA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MHNIKECDBFO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62ABBF0", Offset = "0x62AABF0", VA = "0x1862ABBF0")]
	private static void ALLBGDFDJDE(IAGKGLIDGOC EHIJANGGHCI, string DIENLBCMIGK, params object[] NABJMDALPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62ABE20", Offset = "0x62AAE20", VA = "0x1862ABE20")]
	internal static void EOPPEDEFOIC(string DIENLBCMIGK, params object[] NABJMDALPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62ABE80", Offset = "0x62AAE80", VA = "0x1862ABE80")]
	internal static void KNEDFBBLLLA(string DIENLBCMIGK, params object[] NABJMDALPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x62ABEE0", Offset = "0x62AAEE0", VA = "0x1862ABEE0")]
	internal static void NAPLJHGPMHI(string DIENLBCMIGK, params object[] NABJMDALPIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum OECEFAHLDMI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GJCLAFLBFIB : GGNKJMOIFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private GJKPGHKCPAN GLNDJBOGBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FGKGMOGMHDC FHMDLBMEAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GAPMFHMCPGA IKDPBOOHBCF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62A8E00", Offset = "0x62A7E00", VA = "0x1862A8E00")]
	internal GJCLAFLBFIB(FGKGMOGMHDC PMNMDCCMPDH, GAPMFHMCPGA LBPBKOMAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62A8D10", Offset = "0x62A7D10", VA = "0x1862A8D10")]
	internal void HCBHMLKCLOA(GJKPGHKCPAN DOGNCNMPHPI, int AFCCLBGKNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62A8D80", Offset = "0x62A7D80", VA = "0x1862A8D80")]
	internal void NGNMCJGNLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62A8CE0", Offset = "0x62A7CE0", VA = "0x1862A8CE0")]
	public void FAOFMPNIANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GAPMFHMCPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IJINMAHFBKB
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
	public GAPMFHMCPGA CENFMIKPMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public IJINMAHFBKB BFKMCKBKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public PIMJAPMNFFF OOODDODFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint ACIMBPHCLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object HNFGNAPMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int CFKLEJGKDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JOGEJILDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public OMAKAOCALGD NGFCPNCAEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public GADLKNIPMJM MAPMPHCOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public BFBHMELCEGO GCGIMBOEOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte MPBLLOMMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly GJCLAFLBFIB LAFGABFLEDG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62A7F70", Offset = "0x62A6F70", VA = "0x1862A7F70")]
	public GAPMFHMCPGA(FGKGMOGMHDC PMNMDCCMPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FGKGMOGMHDC : IEnumerable<PIMJAPMNFFF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class GCAPPEFPIMO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62A8010", Offset = "0x62A7010", VA = "0x1862A8010", Slot = "4")]
		public bool Equals(IPEndPoint GOCMFEAMGHO, IPEndPoint AEFHGLLPABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB900", Offset = "0x5DDA900", VA = "0x185DDB900", Slot = "5")]
		public int GetHashCode(IPEndPoint IFPBFCLBBDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GCAPPEFPIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct COPIGINBFAN : IEnumerator<PIMJAPMNFFF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly PIMJAPMNFFF MHNFJPGMDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PIMJAPMNFFF NAOBFGGLKDK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PIMJAPMNFFF OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9EF2D0", Offset = "0x9EE2D0", VA = "0x1809EF2D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9EF2D0", Offset = "0x9EE2D0", VA = "0x1809EF2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x14EB3F0", Offset = "0x14EA3F0", VA = "0x1814EB3F0")]
		public COPIGINBFAN(PIMJAPMNFFF NLBDJHPCOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x629FF20", Offset = "0x629EF20", VA = "0x18629FF20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x629FF70", Offset = "0x629EF70", VA = "0x18629FF70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread JGHOCELDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool HJKNLIEDJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CFDEHOLDDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GAPMFHMCPGA> LILJGCBBBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GAPMFHMCPGA> IMLFDKCPDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GAPMFHMCPGA HLCNOFCPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BGJCNFLKBNB ECNPJAGCGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly EJFHEBAFAHC CGBPBCKAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly GJBCLKJGEJB KNGMPFGMEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NMCBAMLMBGE OJFMNPPHGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, PIMJAPMNFFF> ICPLNHBJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, GADLKNIPMJM> MDOEBDNGJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, EHAIBGLEAGH> OCIHKONGFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JLFDJOOJEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private PIMJAPMNFFF KPGBMKKOKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int NIILIJPNPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PIMJAPMNFFF> CDMEANJMIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PIMJAPMNFFF[] FOKEGFNEDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PAPDDKDIHGG MACNNJOMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int EPCJMOGJHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> GECFFEOAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte EONMBHGPINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object PFMDJKDBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool HOAAGIJBILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool CFCOLBBPEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DDEHGOFOBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int BFCPPLPBNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MFJDKBHAOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int PHBKMFOJIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool CMENLBCEJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FABAGKBANKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int BHNPKEMIHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int PCDAICAKPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int KHOKPFGPMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EAGGJKIFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool CDJABMBPFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PILKAKBIMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool EDBNDPLPLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int DFDCKACPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HCMKEJFLIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool OMBMDAJHNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly CIBPHNAONCJ LDCPBHLKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KGBHKIJNGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HACBLAKMOGD KFOGCOJKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PKENCPEDBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public OECEFAHLDMI MMDBJGHKAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int JLNACMKMJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GBGNNJLOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FECHPBOCPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool LJJCJPEGHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FKMAANGMNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private GJKPGHKCPAN HLKFDDDEJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int IAHNEBACAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object NNKOGJOJJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private GJKPGHKCPAN EDFCKCPIMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int IOCMHKBIPNO;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int OPLEMLKLNBO = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int OOJGAIEOEGP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LLGFBDKCMFK HPMEKGNDHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LLGFBDKCMFK FIJKDBFMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OCFHBDFPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread OOANIHJLKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint BACJPFACNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DHPNJEOMGGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] COLCNFPHJGB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] ELMOAPIKCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<EDLMMOEIIEK, IPEndPoint> JHDBDMLAIAP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress PCBHADGJGID;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool GHDPOHMFDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int BAEADJMNBPC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EHMHFJIAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xFD3C70", Offset = "0xFD2C70", VA = "0x180FD3C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1080DD0", Offset = "0x107FDD0", VA = "0x181080DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EGOIGANAOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D640", Offset = "0x1A8C640", VA = "0x181A8D640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF6A0", Offset = "0x1DFE6A0", VA = "0x181DFF6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte IJMODKOPLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x957F50", Offset = "0x956F50", VA = "0x180957F50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KJANDEDJAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62A64F0", Offset = "0x62A54F0", VA = "0x1862A64F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short LHOEIENBCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62A5F10", Offset = "0x62A4F10", VA = "0x1862A5F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62A2580", Offset = "0x62A1580", VA = "0x1862A2580")]
	public void ECAMCIJFHHN(IPEndPoint DNDHMKHNPGC, byte[] MLAECOMLIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62A5630", Offset = "0x62A4630", VA = "0x1862A5630")]
	public void KMMHMFAJPKC(IPEndPoint DNDHMKHNPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62A3570", Offset = "0x62A2570", VA = "0x1862A3570")]
	private bool GGDFGGMJIFN(IPEndPoint DNDHMKHNPGC, [Out] PIMJAPMNFFF OAFCCOHNLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62A5FD0", Offset = "0x62A4FD0", VA = "0x1862A5FD0")]
	private void MLJCMFBFHCC(PIMJAPMNFFF OAFCCOHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62A5A60", Offset = "0x62A4A60", VA = "0x1862A5A60")]
	private void LCINJOHFLKI(PIMJAPMNFFF OAFCCOHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62A3980", Offset = "0x62A2980", VA = "0x1862A3980")]
	private void GLBEHDKPOHM(PIMJAPMNFFF OAFCCOHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62A77C0", Offset = "0x62A67C0", VA = "0x1862A77C0")]
	public FGKGMOGMHDC(BGJCNFLKBNB EDPOEFODAOJ, [Optional] PAPDDKDIHGG OOJJDNOCAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62A3BF0", Offset = "0x62A2BF0", VA = "0x1862A3BF0")]
	internal void GNINBOHIPJG(PIMJAPMNFFF EBIIBKJLJDL, int MCAJJOHBJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62A2A60", Offset = "0x62A1A60", VA = "0x1862A2A60")]
	internal void FEIICILAPGI(PIMJAPMNFFF EBIIBKJLJDL, object JDEPBMOPKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62A6420", Offset = "0x62A5420", VA = "0x1862A6420")]
	internal void NNNDLPDCLAP(PIMJAPMNFFF OAFCCOHNLKK, OMAKAOCALGD BMAADIIMEEA, SocketError FDJICDDOGCL, GJKPGHKCPAN POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62A3480", Offset = "0x62A2480", VA = "0x1862A3480")]
	private void GEDNMMEHJJH(PIMJAPMNFFF OAFCCOHNLKK, OMAKAOCALGD BMAADIIMEEA, SocketError FDJICDDOGCL, bool OCPABOGIINL, byte[] CONAFKKIHKL, int NOAHCMMOGGC, int DCEOMHJEBBP, GJKPGHKCPAN POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62A5AB0", Offset = "0x62A4AB0", VA = "0x1862A5AB0")]
	private void LCJLOBMEIPB(GAPMFHMCPGA.IJINMAHFBKB PFCMGBLCCPJ, [Optional] PIMJAPMNFFF OAFCCOHNLKK, [Optional] IPEndPoint MCHFMPKJCEL, SocketError HPCOEPBBODK = SocketError.Success, int MCAJJOHBJMM = 0, OMAKAOCALGD LHLIGLMGMDN = OMAKAOCALGD.ConnectionFailed, [Optional] GADLKNIPMJM HIHKIPJDIDA, BFBHMELCEGO EJCAEKLNGJP = BFBHMELCEGO.Unreliable, byte KFHLCDIGPBB = 0, [Optional] GJKPGHKCPAN HEAIMOFJIOD, [Optional] object JDEPBMOPKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62A1DB0", Offset = "0x62A0DB0", VA = "0x1862A1DB0")]
	private void EBPEKNBNGCB(GAPMFHMCPGA LBPBKOMAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62A3200", Offset = "0x62A2200", VA = "0x1862A3200")]
	internal void GDMKIIIPKIL(GAPMFHMCPGA LBPBKOMAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62A4E30", Offset = "0x62A3E30", VA = "0x1862A4E30")]
	private void IOMBIFKEBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62A3D50", Offset = "0x62A2D50", VA = "0x1862A3D50")]
	private void HGJENPEHIEN(int AIDIKNEICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62A6EC0", Offset = "0x62A5EC0", VA = "0x1862A6EC0")]
	internal PIMJAPMNFFF PGGAFCEMDJD(GADLKNIPMJM ONMEAHDGGOB, byte[] BHOAIDIIADC, int NOAHCMMOGGC, int CDEEBECPNGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62A5E90", Offset = "0x62A4E90", VA = "0x1862A5E90")]
	private int LJDLGNJAGND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62A0D00", Offset = "0x629FD00", VA = "0x1862A0D00")]
	private void CPLDLDNDKFK(IPEndPoint MCHFMPKJCEL, PIMJAPMNFFF EIBIHDMOEAK, BKCDPOJHDKA CMKCDBLFPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x62A4070", Offset = "0x62A3070", VA = "0x1862A4070")]
	private void HLNPBGGPNCM(GJKPGHKCPAN DOGNCNMPHPI, IPEndPoint MCHFMPKJCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62A5780", Offset = "0x62A4780", VA = "0x1862A5780")]
	internal void KNIFKKNOPHE(GJKPGHKCPAN DOGNCNMPHPI, BFBHMELCEGO CMOJICEFOMB, byte KFHLCDIGPBB, int AFCCLBGKNDL, PIMJAPMNFFF EBIIBKJLJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62A1510", Offset = "0x62A0510", VA = "0x1862A1510")]
	public bool DMGNCFFGIOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62A14F0", Offset = "0x62A04F0", VA = "0x1862A14F0")]
	public bool DMGNCFFGIOF(IPAddress OIONIBPAKHA, IPAddress MJECIHJGJNP, int FBADOLDPNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62A1580", Offset = "0x62A0580", VA = "0x1862A1580")]
	public bool DMGNCFFGIOF(int FBADOLDPNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62A6B60", Offset = "0x62A5B60", VA = "0x1862A6B60")]
	public void OGLEKNPOCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62A3120", Offset = "0x62A2120", VA = "0x1862A3120")]
	public PIMJAPMNFFF FLKMHKLONNH(string GEBCKJCKLDG, int FBADOLDPNBJ, string MLAECOMLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62A3040", Offset = "0x62A2040", VA = "0x1862A3040")]
	public PIMJAPMNFFF FLKMHKLONNH(string GEBCKJCKLDG, int FBADOLDPNBJ, MCIJLHENOLO PBNHAELOOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62A2C70", Offset = "0x62A1C70", VA = "0x1862A2C70")]
	public PIMJAPMNFFF FLKMHKLONNH(IPEndPoint CECLKDDLGFE, MCIJLHENOLO PBNHAELOOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62A14E0", Offset = "0x62A04E0", VA = "0x1862A14E0")]
	public void DLOEAOFKNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62A1190", Offset = "0x62A0190", VA = "0x1862A1190")]
	public void DLOEAOFKNPE(bool NCJCIELGEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62A53B0", Offset = "0x62A43B0", VA = "0x1862A53B0")]
	public void JLIILNDLLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62A54B0", Offset = "0x62A44B0", VA = "0x1862A54B0")]
	public void JLIILNDLLKH(byte[] CONAFKKIHKL, int NOAHCMMOGGC, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62A33D0", Offset = "0x62A23D0", VA = "0x1862A33D0")]
	public void GEDNMMEHJJH(PIMJAPMNFFF OAFCCOHNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62A3310", Offset = "0x62A2310", VA = "0x1862A3310")]
	public void GEDNMMEHJJH(PIMJAPMNFFF OAFCCOHNLKK, byte[] CONAFKKIHKL, int NOAHCMMOGGC, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62A75E0", Offset = "0x62A65E0", VA = "0x1862A75E0", Slot = "4")]
	private IEnumerator<PIMJAPMNFFF> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62A7670", Offset = "0x62A6670", VA = "0x1862A7670", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62A2B90", Offset = "0x62A1B90", VA = "0x1862A2B90")]
	private GJKPGHKCPAN FGKJEGLEAFE(GNBDCNMKMGL EDBGKLDPNAK, int MLDINGBBEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62A2AB0", Offset = "0x62A1AB0", VA = "0x1862A2AB0")]
	private GJKPGHKCPAN FGKJEGLEAFE(GNBDCNMKMGL EDBGKLDPNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62A5170", Offset = "0x62A4170", VA = "0x1862A5170")]
	internal GJKPGHKCPAN JBCOFMHLMOA(int MLDINGBBEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62A0AA0", Offset = "0x629FAA0", VA = "0x1862A0AA0")]
	internal void BOMLNMMANAH(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62A7700", Offset = "0x62A6700", VA = "0x1862A7700")]
	static FGKGMOGMHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xFD3C70", Offset = "0xFD2C70", VA = "0x180FD3C70")]
	private bool DPEGCPBDAHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62A3C40", Offset = "0x62A2C40", VA = "0x1862A3C40")]
	private void GPPOIJMBFJA(IPEndPoint IIBLMEFDJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62A74E0", Offset = "0x62A64E0", VA = "0x1862A74E0")]
	private void PJGDINBHMOH(IPEndPoint IIBLMEFDJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62A6D10", Offset = "0x62A5D10", VA = "0x1862A6D10")]
	private bool PACEBFPIGEM(SocketException BKFPPGLJAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62A27A0", Offset = "0x62A17A0", VA = "0x1862A27A0")]
	private void EOJCKGAFHAA(LLGFBDKCMFK JIGACHAEDFM, EndPoint MKAJBHLPEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62A3600", Offset = "0x62A2600", VA = "0x1862A3600")]
	private void GKHDENGBJHM(object LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62A1600", Offset = "0x62A0600", VA = "0x1862A1600")]
	public bool DMGNCFFGIOF(IPAddress OIONIBPAKHA, IPAddress MJECIHJGJNP, int FBADOLDPNBJ, bool ODHNAIAGIOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x62A55D0", Offset = "0x62A45D0", VA = "0x1862A55D0")]
	internal int KFAIGAKBDCH(GJKPGHKCPAN DOGNCNMPHPI, IPEndPoint MCHFMPKJCEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62A6510", Offset = "0x62A5510", VA = "0x1862A6510")]
	internal int OGEBNDNAKJF(GJKPGHKCPAN DOGNCNMPHPI, IPEndPoint MCHFMPKJCEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x62A6550", Offset = "0x62A5550", VA = "0x1862A6550")]
	internal int OGEBNDNAKJF(byte[] ABHPFCOODAJ, int NOAHCMMOGGC, int CDEEBECPNGB, IPEndPoint MCHFMPKJCEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x62A62B0", Offset = "0x62A52B0", VA = "0x1862A62B0")]
	internal void NGMNCNIHILD(bool JCDIJCIPIBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GNBDCNMKMGL : byte
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
internal sealed class GJKPGHKCPAN
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MCONHJOFMNI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] EADCFDOLILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] DMAMDGLECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int IIJOJMFBBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object HNFGNAPMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public GJKPGHKCPAN CENFMIKPMMF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GNBDCNMKMGL GMABJBJABLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62A90E0", Offset = "0x62A80E0", VA = "0x1862A90E0")]
		get
		{
			return default(GNBDCNMKMGL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62A8E50", Offset = "0x62A7E50", VA = "0x1862A8E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte NIHNOJEMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62A8ED0", Offset = "0x62A7ED0", VA = "0x1862A8ED0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62A9430", Offset = "0x62A8430", VA = "0x1862A9430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LBIPCMLLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62A9370", Offset = "0x62A8370", VA = "0x1862A9370")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62A8FA0", Offset = "0x62A7FA0", VA = "0x1862A8FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HDEFPDPHHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62A91A0", Offset = "0x62A81A0", VA = "0x1862A91A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte DLOCPPBNNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62A9110", Offset = "0x62A8110", VA = "0x1862A9110")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62A9170", Offset = "0x62A8170", VA = "0x1862A9170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort ALNBAFDNLID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62A8F00", Offset = "0x62A7F00", VA = "0x1862A8F00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62A8F60", Offset = "0x62A7F60", VA = "0x1862A8F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort NFPKBOFBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62A93D0", Offset = "0x62A83D0", VA = "0x1862A93D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62A8E90", Offset = "0x62A7E90", VA = "0x1862A8E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PDEGNLOAGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62A91D0", Offset = "0x62A81D0", VA = "0x1862A91D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62A9230", Offset = "0x62A8230", VA = "0x1862A9230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62A9470", Offset = "0x62A8470", VA = "0x1862A9470")]
	static GJKPGHKCPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62A9140", Offset = "0x62A8140", VA = "0x1862A9140")]
	public void JCKJNHBMMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62A9730", Offset = "0x62A8730", VA = "0x1862A9730")]
	public GJKPGHKCPAN(int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62A97A0", Offset = "0x62A87A0", VA = "0x1862A97A0")]
	public GJKPGHKCPAN(GNBDCNMKMGL EDBGKLDPNAK, int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62A9070", Offset = "0x62A8070", VA = "0x1862A9070")]
	public static int FGNOABAKAJL(GNBDCNMKMGL EDBGKLDPNAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62A8FE0", Offset = "0x62A7FE0", VA = "0x1862A8FE0")]
	public int FGNOABAKAJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x62A9270", Offset = "0x62A8270", VA = "0x1862A9270")]
	public bool LLPJPACAGCA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum BIIELFIOHEO : byte
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
internal enum FAMBENIHLCF
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
internal enum FKLDNAMCBJC
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum GAKHEOMPMCI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PIMJAPMNFFF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KEGPLHIFJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GJKPGHKCPAN[] IKIGJHMBFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int OPEGDLOKIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int HKIFCMGPJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte DLOCPPBNNCH;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KEGPLHIFJKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void GGNPMIEKCBG(ulong MFOFPAAJCGL, int IHCBCJMBJIL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int LBIJKNBJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int PMPINNGFMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int HAAPCKMDCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double PDLCGCEDCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int IFNEHKNIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int LNFLPCCKNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int INGCPOPKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch LGOANMICIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FHACMNGNBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long HEMAEKIKLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object HMDKMJODAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal PIMJAPMNFFF GEAABPAOABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal PIMJAPMNFFF POFEHKHPLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<GJKPGHKCPAN> DGPIFJJAPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CINHLFPOFAD> EKDKPACNCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CINHLFPOFAD[] NAJFBNHHFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int KKADEDMGHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int MLEIKODOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool GCOODOOKAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int HNCAEHCCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int GMBMIBFAAPN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int IDAPKKIOPBO = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int DKBDFIJFIFI = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object JGLOADOABLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int ILCHPGAFLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, KEGPLHIFJKM> JHONIKLFAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> GMDOIJMDLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly GJKPGHKCPAN GNKGDNAHPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GMDDPAGCFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int NDLOMKCAKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint JJPGEIPMPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KDGGBJNLBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int LGBBJENLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long OKHIGLOCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte DGPBJHNJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private BIIELFIOHEO HEANEMBBGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GJKPGHKCPAN ILLLHAHFJLP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NDAAOPCAFGE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int GCAFONEIFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GJKPGHKCPAN EIMBDCNFHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly GJKPGHKCPAN KAHECBADHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly GJKPGHKCPAN LHMEJONPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly GJKPGHKCPAN IEJFLFPGIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DHIHKFPDOMM ABNHGFLAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly FGKGMOGMHDC CHNEPIHEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int CCDGLKPMLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object BECHEKENDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CIBPHNAONCJ LDCPBHLKLEF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OCOKPOLOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC91F20", Offset = "0xC90F20", VA = "0x180C91F20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x62B0F40", Offset = "0x62AFF40", VA = "0x1862B0F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint FJAJHJMDADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x93E360", Offset = "0x93D360", VA = "0x18093E360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BIIELFIOHEO CMFAAPCHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1756240", Offset = "0x1755240", VA = "0x181756240")]
		get
		{
			return default(BIIELFIOHEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long PPJGJKJCFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA60", Offset = "0x8BDA60", VA = "0x1808BEA60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int ANHDJDAMOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x10C2AD0", Offset = "0x10C1AD0", VA = "0x1810C2AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19A8DD0", Offset = "0x19A7DD0", VA = "0x1819A8DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LCBDDCAEELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x62B0640", Offset = "0x62AF640", VA = "0x1862B0640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LONGNBNPPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C3EE0", VA = "0x1808C4EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double GBFAFDNHNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x41DD250", Offset = "0x41DC250", VA = "0x1841DD250")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GGNPMIEKCBG EMNGAHKAMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x62AF5A0", Offset = "0x62AE5A0", VA = "0x1862AF5A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62B1020", Offset = "0x62B0020", VA = "0x1862B1020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62B3300", Offset = "0x62B2300", VA = "0x1862B3300")]
	internal PIMJAPMNFFF(FGKGMOGMHDC AJEAPENHOGJ, IPEndPoint MCHFMPKJCEL, int JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x62AFFF0", Offset = "0x62AEFF0", VA = "0x1862AFFF0")]
	internal void BNBDGLONFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x62B0FF0", Offset = "0x62AFFF0", VA = "0x1862B0FF0")]
	internal void ELHNJKLNHLI(IPEndPoint GONKGCPAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62B27C0", Offset = "0x62B17C0", VA = "0x1862B27C0")]
	internal void LPDAIBAHOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62B1730", Offset = "0x62B0730", VA = "0x1862B1730")]
	private void JEEOJNAJDEM(int PAPFFGAJMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62AF440", Offset = "0x62AE440", VA = "0x1862AF440")]
	private void ABKKKAJPGBA(int NODAEOEHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62B0490", Offset = "0x62AF490", VA = "0x1862B0490")]
	private CINHLFPOFAD DGDLJFNCADN(byte GGBBONMHPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62B3170", Offset = "0x62B2170", VA = "0x1862B3170")]
	internal PIMJAPMNFFF(FGKGMOGMHDC AJEAPENHOGJ, IPEndPoint MCHFMPKJCEL, int JHCIODFGPNM, byte GFGMIHJGNEM, MCIJLHENOLO DKIABIIOKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62B2F90", Offset = "0x62B1F90", VA = "0x1862B2F90")]
	internal PIMJAPMNFFF(FGKGMOGMHDC AJEAPENHOGJ, GADLKNIPMJM ONMEAHDGGOB, int JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62B2710", Offset = "0x62B1710", VA = "0x1862B2710")]
	internal void KJNMIDJIJKI(BKCDPOJHDKA CNNEMACPAEA, byte[] CONAFKKIHKL, int NOAHCMMOGGC, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62B2F10", Offset = "0x62B1F10", VA = "0x1862B2F10")]
	internal bool PKIOFPMBNGF(LFIDFLKJEFE DOGNCNMPHPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62B1800", Offset = "0x62B0800", VA = "0x1862B1800")]
	public void JFEIIEKCNDG(byte[] CONAFKKIHKL, int NOAHCMMOGGC, int CDEEBECPNGB, BFBHMELCEGO HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x62AF700", Offset = "0x62AE700", VA = "0x1862AF700")]
	private void BCIPGLOAHBE(byte[] CONAFKKIHKL, int NOAHCMMOGGC, int CDEEBECPNGB, byte KFHLCDIGPBB, BFBHMELCEGO EJCAEKLNGJP, object JDEPBMOPKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62AF650", Offset = "0x62AE650", VA = "0x1862AF650")]
	public void APIJKEPFGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62AF4C0", Offset = "0x62AE4C0", VA = "0x1862AF4C0")]
	internal FKLDNAMCBJC AICKOFNADGH(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return default(FKLDNAMCBJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62B2760", Offset = "0x62B1760", VA = "0x1862B2760")]
	internal void LBPGIOBHMFO(CINHLFPOFAD HDNCDHDOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62B10D0", Offset = "0x62B00D0", VA = "0x1862B10D0")]
	internal GAKHEOMPMCI GMODJNLCOIN(byte[] CONAFKKIHKL, int NOAHCMMOGGC, int CDEEBECPNGB, bool OCPABOGIINL)
	{
		return default(GAKHEOMPMCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x62AF480", Offset = "0x62AE480", VA = "0x1862AF480")]
	private void AHMDNLPFCHF(int JIFCBHHLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62B1D80", Offset = "0x62B0D80", VA = "0x1862B1D80")]
	internal void JLIEMNOGCEG(BFBHMELCEGO CMOJICEFOMB, GJKPGHKCPAN NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62B1830", Offset = "0x62B0830", VA = "0x1862B1830")]
	private void JHBEPNFHJNP(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x62AFC60", Offset = "0x62AEC60", VA = "0x1862AFC60")]
	private void BMJODPIGGKO(int MLPBAIIBHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62B02D0", Offset = "0x62AF2D0", VA = "0x1862B02D0")]
	internal FAMBENIHLCF CPLDLDNDKFK(BKCDPOJHDKA CMKCDBLFPPB)
	{
		return default(FAMBENIHLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62B2850", Offset = "0x62B1850", VA = "0x1862B2850")]
	internal void PENAEBGOMCJ(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62B13E0", Offset = "0x62B03E0", VA = "0x1862B13E0")]
	private void HCLGINKFHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62B1530", Offset = "0x62B0530", VA = "0x1862B1530")]
	internal void HDKNKOMEKCF(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62B0650", Offset = "0x62AF650", VA = "0x1862B0650")]
	internal void ECKIEDCBBJB(int MLPBAIIBHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62B0010", Offset = "0x62AF010", VA = "0x1862B0010")]
	internal void CCHBEOCCHGL(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CIBPHNAONCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KKGIBHNNFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FKFDMKBIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long BFAAKNOIFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IOLEGKHALNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long FBLKEFGLDNB;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long EIHFLFCKNJG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long MNHAGEBBKMB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long PJDEFJBKLFP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long MIOIDMNKGKI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long CBIAJAHJLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long CJBHABEHKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CHEGIDIEOAB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long GPKJMFLGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x629F6B0", Offset = "0x629E6B0", VA = "0x18629F6B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EOJPCMLAMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x629F7B0", Offset = "0x629E7B0", VA = "0x18629F7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AILDBGMNHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x629F5D0", Offset = "0x629E5D0", VA = "0x18629F5D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long OADENHBJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x629F700", Offset = "0x629E700", VA = "0x18629F700")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AAAPEJBMECN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x629F810", Offset = "0x629E810", VA = "0x18629F810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long GCEKAJCFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x629F5E0", Offset = "0x629E5E0", VA = "0x18629F5E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long AMJIPKGAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x629F6C0", Offset = "0x629E6C0", VA = "0x18629F6C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long DNCHHKBEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x629F880", Offset = "0x629E880", VA = "0x18629F880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DHIHKFPDOMM BGHGLDOFJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x629F4B0", Offset = "0x629E4B0", VA = "0x18629F4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double ODHBPGOKLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x629F570", Offset = "0x629E570", VA = "0x18629F570")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x629F530", Offset = "0x629E530", VA = "0x18629F530")]
	public void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x629F450", Offset = "0x629E450", VA = "0x18629F450")]
	public void AHIBCJOAGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x629F7C0", Offset = "0x629E7C0", VA = "0x18629F7C0")]
	public void LIHLAMJEPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x629F820", Offset = "0x629E820", VA = "0x18629F820")]
	public void OFDDMPIEPDK(long DAFLGKGOJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x629F650", Offset = "0x629E650", VA = "0x18629F650")]
	public void HBOBOLKGGHI(long EAJKBECAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x629F5F0", Offset = "0x629E5F0", VA = "0x18629F5F0")]
	public void EBAHJOJANHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x629F4C0", Offset = "0x629E4C0", VA = "0x18629F4C0")]
	public void BMAOFHGIJNN(long HCJFIHAAEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x629F8C0", Offset = "0x629E8C0", VA = "0x18629F8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x629F710", Offset = "0x629E710", VA = "0x18629F710")]
	public void JCEDEFBNLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public CIBPHNAONCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JOKDOEMONEH
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> GBKINIHENBA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x62AA5C0", Offset = "0x62A95C0", VA = "0x1862AA5C0")]
	public static IPEndPoint CAONDGNGBGI(string DGMKKBOMEBG, int FBADOLDPNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x62AA8A0", Offset = "0x62A98A0", VA = "0x1862AA8A0")]
	public static IPAddress CNDMCBALELK(string DGMKKBOMEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62AA810", Offset = "0x62A9810", VA = "0x1862AA810")]
	public static IPAddress CNDMCBALELK(string DGMKKBOMEBG, AddressFamily PKGLFFEGANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x62AAA70", Offset = "0x62A9A70", VA = "0x1862AAA70")]
	internal static int HGGGGIALFJC(int GLFMODFGNDD, int BDJMFCBAEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3006E00", Offset = "0x3005E00", VA = "0x183006E00")]
	internal static T[] MALKHAEEFMB<T>(int DCEOMHJEBBP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KAOKHLLKPJH : CINHLFPOFAD
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct IKHLGLIBLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private GJKPGHKCPAN GLNDJBOGBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long CNNPGPKLDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool KKHEJHGPGLL;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62AA450", Offset = "0x62A9450", VA = "0x1862AA450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62AA370", Offset = "0x62A9370", VA = "0x1862AA370")]
		public void BCCFFCEEHAG(GJKPGHKCPAN DOGNCNMPHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62AA3E0", Offset = "0x62A93E0", VA = "0x1862AA3E0")]
		public bool NEPHDHFHOMK(long IPKDBCAIOEA, PIMJAPMNFFF OAFCCOHNLKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62AA390", Offset = "0x62A9390", VA = "0x1862AA390")]
		public bool EGPGCHCMHIK(PIMJAPMNFFF OAFCCOHNLKK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly GJKPGHKCPAN GDKDMCLBDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly IKHLGLIBLJJ[] IFCBHMEHJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly GJKPGHKCPAN[] MCDGBBEGHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] CIOLEKCIDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int DCIJCFEEGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int IEHFJMPMPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int BCHGGDNDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int HOFFKMMDAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool PGFIOJAMFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly BFBHMELCEGO DOOBLIOJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool GNDHKHJPAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int OJPGABBABAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte JJJOOIGJELG;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x62ABA20", Offset = "0x62AAA20", VA = "0x1862ABA20")]
	public KAOKHLLKPJH(PIMJAPMNFFF OAFCCOHNLKK, bool OLBJOCBFMNI, byte JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x62AAB30", Offset = "0x62A9B30", VA = "0x1862AAB30")]
	private void AABMJFKLAJK(GJKPGHKCPAN DOGNCNMPHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62AAEF0", Offset = "0x62A9EF0", VA = "0x1862AAEF0", Slot = "4")]
	protected override bool OOFPFEMBJGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62AB3C0", Offset = "0x62AA3C0", VA = "0x1862AB3C0", Slot = "5")]
	public override bool PENAEBGOMCJ(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BCLCFLJFBEC : CINHLFPOFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int OFMEDDFHBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort IEHFJMPMPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool ENCOBPOGMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private GJKPGHKCPAN OMPCLAOKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly GJKPGHKCPAN MONKOMKKCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool LELJMNMAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte JJJOOIGJELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long IECPOCLFMKF;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x629D7A0", Offset = "0x629C7A0", VA = "0x18629D7A0")]
	public BCLCFLJFBEC(PIMJAPMNFFF OAFCCOHNLKK, bool FOGCMPFKLHB, byte JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x629D000", Offset = "0x629C000", VA = "0x18629D000", Slot = "4")]
	protected override bool OOFPFEMBJGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x629D4C0", Offset = "0x629C4C0", VA = "0x18629D4C0", Slot = "5")]
	public override bool PENAEBGOMCJ(GJKPGHKCPAN DOGNCNMPHPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CJOLPJFNMFI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct FEDPJNCGLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong DECMPJJEFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double CHFIPJELNFJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KPHDIADFOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int AOEENBKDAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float GMJLONODIGN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x629C1F0", Offset = "0x629B1F0", VA = "0x18629C1F0")]
	private static void LJDBGIKBCLN(byte[] CNIEHBMANDE, int OFDADLBABBI, ulong CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x629FE90", Offset = "0x629EE90", VA = "0x18629FE90")]
	private static void LJDBGIKBCLN(byte[] CNIEHBMANDE, int OFDADLBABBI, int CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x629FE50", Offset = "0x629EE50", VA = "0x18629FE50")]
	public static void LJDBGIKBCLN(byte[] CNIEHBMANDE, int OFDADLBABBI, short CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x629FF00", Offset = "0x629EF00", VA = "0x18629FF00")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, double BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x629FDC0", Offset = "0x629EDC0", VA = "0x18629FDC0")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, float BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x629FE50", Offset = "0x629EE50", VA = "0x18629FE50")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, short BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x629FE50", Offset = "0x629EE50", VA = "0x18629FE50")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, ushort BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x629FE90", Offset = "0x629EE90", VA = "0x18629FE90")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, int BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x629FE90", Offset = "0x629EE90", VA = "0x18629FE90")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, uint BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x629FE40", Offset = "0x629EE40", VA = "0x18629FE40")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, long BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x629FE40", Offset = "0x629EE40", VA = "0x18629FE40")]
	public static void KMHGDNIGFAK(byte[] HPKNAAFAALO, int KECPKLHBJEB, ulong BJDKOHEGDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GGNKJMOIFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] GKCMKFABJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int FMFDLKKDJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int DBNHHKNKJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int DKAHJOAIDAP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] DMAMDGLECBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int BGNGMOBNCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DECAPNJPJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62A8A90", Offset = "0x62A7A90", VA = "0x1862A8A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HELAHOMNCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x21FFFE0", Offset = "0x21FEFE0", VA = "0x1821FFFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DKBEJDGIOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62A8850", Offset = "0x62A7850", VA = "0x1862A8850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x62A8510", Offset = "0x62A7510", VA = "0x1862A8510")]
	public void HCBHMLKCLOA(byte[] LNLOCMMGLOB, int OFDADLBABBI, int NFGJODDKLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public GGNKJMOIFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62A8C80", Offset = "0x62A7C80", VA = "0x1862A8C80")]
	public GGNKJMOIFFB(byte[] LNLOCMMGLOB, int OFDADLBABBI, int NFGJODDKLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x62A8780", Offset = "0x62A7780", VA = "0x1862A8780")]
	public IPEndPoint IJPCMBMEGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x62A8AE0", Offset = "0x62A7AE0", VA = "0x1862A8AE0")]
	public byte LHKFCLDEKFL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x62A8AE0", Offset = "0x62A7AE0", VA = "0x1862A8AE0")]
	public sbyte NBLCFBDLAJK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2F80FC0", Offset = "0x2F7FFC0", VA = "0x182F80FC0")]
	public T[] GCKBMLNKIDP<T>(ushort MLDINGBBEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x62A8920", Offset = "0x62A7920", VA = "0x1862A8920")]
	public bool[] JKBPILBDMPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x62A88E0", Offset = "0x62A78E0", VA = "0x1862A88E0")]
	public ushort[] JJDPMEOFKKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x62A88A0", Offset = "0x62A78A0", VA = "0x1862A88A0")]
	public short[] JDICJLKKBBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x62A84D0", Offset = "0x62A74D0", VA = "0x1862A84D0")]
	public int[] FLBKDFHNGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x62A8860", Offset = "0x62A7860", VA = "0x1862A8860")]
	public uint[] JBKKOLEBIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x62A8C40", Offset = "0x62A7C40", VA = "0x1862A8C40")]
	public float[] PAEOIEKODKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62A89A0", Offset = "0x62A79A0", VA = "0x1862A89A0")]
	public double[] JPIOOFOLAKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62A8960", Offset = "0x62A7960", VA = "0x1862A8960")]
	public long[] JKCLNICDCJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62A8AA0", Offset = "0x62A7AA0", VA = "0x1862A8AA0")]
	public ulong[] LFGMKHHFMDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x62A80F0", Offset = "0x62A70F0", VA = "0x1862A80F0")]
	public string[] AJOCNPJDIDP(int KEKNPNGOBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62A8A50", Offset = "0x62A7A50", VA = "0x1862A8A50")]
	public bool KMPCDLALIDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62A8240", Offset = "0x62A7240", VA = "0x1862A8240")]
	public char FKHDLCPDDIF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x62A8240", Offset = "0x62A7240", VA = "0x1862A8240")]
	public ushort BAMMDOLJPDE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x62A8080", Offset = "0x62A7080", VA = "0x1862A8080")]
	public short AACAJGLDOGC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x62A8420", Offset = "0x62A7420", VA = "0x1862A8420")]
	public long ELBFHELBDAA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62A8390", Offset = "0x62A7390", VA = "0x1862A8390")]
	public ulong EEFGLILDIJE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62A8320", Offset = "0x62A7320", VA = "0x1862A8320")]
	public int BMPHLONGLIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x62A89E0", Offset = "0x62A79E0", VA = "0x1862A89E0")]
	public uint KBEMJKFCLJN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x62A8B60", Offset = "0x62A7B60", VA = "0x1862A8B60")]
	public float NDFLDJCHAFE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x62A82B0", Offset = "0x62A72B0", VA = "0x1862A82B0")]
	public double BEPFMJGNMMF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62A8550", Offset = "0x62A7550", VA = "0x1862A8550")]
	public string ICHIBGMGCOL(int FDICHMHOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x62A8BD0", Offset = "0x62A7BD0", VA = "0x1862A8BD0")]
	public ArraySegment<byte> OMIEDCNILJL(int DCEOMHJEBBP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62A8490", Offset = "0x62A7490", VA = "0x1862A8490")]
	public sbyte[] FFCHIFCCGLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62A8B20", Offset = "0x62A7B20", VA = "0x1862A8B20")]
	public byte[] MCMPHJDKAAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62A8400", Offset = "0x62A7400", VA = "0x1862A8400")]
	public void EGPGCHCMHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MCIJLHENOLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] GKCMKFABJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FMFDLKKDJHO;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int FEPPOBELBFD = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool CJDLMLMGFCE;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding LPFIFHHBFNM;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int EDPPOCOHIJE = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] FBPLEODJNIJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] CKGGEHCOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x62AF280", Offset = "0x62AE280", VA = "0x1862AF280")]
	public MCIJLHENOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x62AF300", Offset = "0x62AE300", VA = "0x1862AF300")]
	public MCIJLHENOLO(bool GDPCBKCKLLF, int NLJNCIJOKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x62AE640", Offset = "0x62AD640", VA = "0x1862AE640")]
	public static MCIJLHENOLO DEDACNKCDHG(string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x62AED10", Offset = "0x62ADD10", VA = "0x1862AED10")]
	public void GIPGNLHBEAK(int PCNLEGBOOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2278FA0", Offset = "0x2277FA0", VA = "0x182278FA0")]
	public void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x62AE970", Offset = "0x62AD970", VA = "0x1862AE970")]
	public void FLMPMLADNPC(float BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x62AE910", Offset = "0x62AD910", VA = "0x1862AE910")]
	public void FLMPMLADNPC(double BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x62AE720", Offset = "0x62AD720", VA = "0x1862AE720")]
	public void FLMPMLADNPC(long BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x62AE720", Offset = "0x62AD720", VA = "0x1862AE720")]
	public void FLMPMLADNPC(ulong BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x62AEC20", Offset = "0x62ADC20", VA = "0x1862AEC20")]
	public void FLMPMLADNPC(int BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x62AEC20", Offset = "0x62ADC20", VA = "0x1862AEC20")]
	public void FLMPMLADNPC(uint BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x62AE6B0", Offset = "0x62AD6B0", VA = "0x1862AE6B0")]
	public void FLMPMLADNPC(char BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62AE6B0", Offset = "0x62AD6B0", VA = "0x1862AE6B0")]
	public void FLMPMLADNPC(ushort BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62AE6B0", Offset = "0x62AD6B0", VA = "0x1862AE6B0")]
	public void FLMPMLADNPC(short BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x62AE8B0", Offset = "0x62AD8B0", VA = "0x1862AE8B0")]
	public void FLMPMLADNPC(sbyte BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x62AE8B0", Offset = "0x62AD8B0", VA = "0x1862AE8B0")]
	public void FLMPMLADNPC(byte BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x62AE770", Offset = "0x62AD770", VA = "0x1862AE770")]
	public void FLMPMLADNPC(byte[] CONAFKKIHKL, int OFDADLBABBI, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x62AE560", Offset = "0x62AD560", VA = "0x1862AE560")]
	public void BNBFNPKHHNH(sbyte[] CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x62AE560", Offset = "0x62AD560", VA = "0x1862AE560")]
	public void NCOFHEKMOAE(byte[] CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x62AECB0", Offset = "0x62ADCB0", VA = "0x1862AECB0")]
	public void FLMPMLADNPC(bool BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x62AEE90", Offset = "0x62ADE90", VA = "0x1862AEE90")]
	public void NHOEAIELJOE(Array MKNDJGDIGHE, int FMDEIJDHPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x62AEDB0", Offset = "0x62ADDB0", VA = "0x1862AEDB0")]
	public void NHOEAIELJOE(float[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x62AF050", Offset = "0x62AE050", VA = "0x1862AF050")]
	public void NHOEAIELJOE(double[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x62AF050", Offset = "0x62AE050", VA = "0x1862AF050")]
	public void NHOEAIELJOE(long[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x62AF050", Offset = "0x62AE050", VA = "0x1862AF050")]
	public void NHOEAIELJOE(ulong[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x62AEDB0", Offset = "0x62ADDB0", VA = "0x1862AEDB0")]
	public void NHOEAIELJOE(int[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x62AEDB0", Offset = "0x62ADDB0", VA = "0x1862AEDB0")]
	public void NHOEAIELJOE(uint[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF70", Offset = "0x62ADF70", VA = "0x1862AEF70")]
	public void NHOEAIELJOE(ushort[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF70", Offset = "0x62ADF70", VA = "0x1862AEF70")]
	public void NHOEAIELJOE(short[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x62AE560", Offset = "0x62AD560", VA = "0x1862AE560")]
	public void NHOEAIELJOE(bool[] BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x62AF130", Offset = "0x62AE130", VA = "0x1862AF130")]
	public void NHOEAIELJOE(string[] BJDKOHEGDOK, int FLLDNPIIBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x62AE7E0", Offset = "0x62AD7E0", VA = "0x1862AE7E0")]
	public void FLMPMLADNPC(IPEndPoint DNDHMKHNPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x62AE960", Offset = "0x62AD960", VA = "0x1862AE960")]
	public void FLMPMLADNPC(string BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x62AEA10", Offset = "0x62ADA10", VA = "0x1862AEA10")]
	public void FLMPMLADNPC(string BJDKOHEGDOK, int FDICHMHOOJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CANIAEGAPDO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DJIFKCFKJJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong CCDGLKPMLLI;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7D10", Offset = "0x5DB6D10", VA = "0x185DB7D10")]
		static DJIFKCFKJJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void CGDHFPDNFOL(GGNKJMOIFFB EEKHIEJPCBE, object JDEPBMOPKHE);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NONCBLMKHKG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CANIAEGAPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NONCBLMKHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x49FFBE0", Offset = "0x49FEBE0", VA = "0x1849FFBE0")]
		internal void KIIIPHCIHLP(GGNKJMOIFFB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LHBFJGDOLNB<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CANIAEGAPDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LHBFJGDOLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4746510", Offset = "0x4745510", VA = "0x184746510")]
		internal void KIIIPHCIHLP(GGNKJMOIFFB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MNCGDLGADIM BFPMJALHFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, CGDHFPDNFOL> BCKFDNOLEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly MCIJLHENOLO EINFHDAOCLG;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x629F2D0", Offset = "0x629E2D0", VA = "0x18629F2D0")]
	public CANIAEGAPDO(int KEKNPNGOBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2D055A0", Offset = "0x2D045A0", VA = "0x182D055A0", Slot = "4")]
	protected virtual ulong INCBCCNBIKG<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x629F120", Offset = "0x629E120", VA = "0x18629F120", Slot = "5")]
	protected virtual CGDHFPDNFOL GMCFPHLDBGO(GGNKJMOIFFB EEKHIEJPCBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2D60510", Offset = "0x2D5F510", VA = "0x182D60510", Slot = "6")]
	protected virtual void POMPAMHEBNN<T>(MCIJLHENOLO FOJCOMJJHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x629F250", Offset = "0x629E250", VA = "0x18629F250")]
	public void LJHDFELIKAO(GGNKJMOIFFB EEKHIEJPCBE, object JDEPBMOPKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2D600E0", Offset = "0x2D5F0E0", VA = "0x182D600E0")]
	public void LILBNEHPPBF<T>(MCIJLHENOLO FOJCOMJJHIM, T DOGNCNMPHPI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x629F0D0", Offset = "0x629E0D0", VA = "0x18629F0D0")]
	public void DHLMHCPMAOI(GGNKJMOIFFB EEKHIEJPCBE, object JDEPBMOPKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2D60350", Offset = "0x2D5F350", VA = "0x182D60350")]
	public void OGNNMFAECDM<T>(Action<T> AGNNPGGMPBO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2D60190", Offset = "0x2D5F190", VA = "0x182D60190")]
	public void OGNNMFAECDM<T, TUserData>(Action<T, TUserData> AGNNPGGMPBO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FALABFPMOAI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x629C7D0", Offset = "0x629B7D0", VA = "0x18629C7D0")]
	public FALABFPMOAI(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HANEELGKAKA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x62AA310", Offset = "0x62A9310", VA = "0x1862AA310")]
	public HANEELGKAKA(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MNCGDLGADIM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum GENCFPGHEBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class EAANIAOJKHK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GENCFPGHEBL BFKMCKBKOAJ;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C550", Offset = "0x3C3B550", VA = "0x183C3C550", Slot = "4")]
		public virtual void BCCFFCEEHAG(MethodInfo LDJIDEAGBNF, MethodInfo IPIAPGDJOIH, GENCFPGHEBL PFCMGBLCCPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KEDCILBCIGJ(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CAKDOOCBOHB(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		protected EAANIAOJKHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MNPOEDNNFIE<TClass, TProperty> : EAANIAOJKHK<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> KJDHCAFJGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> BIKCENGCMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> AMLCNMIPIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> DNPLEIOLDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> IIOGEDMJFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> NFEFBECKGLG;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x496E3D0", Offset = "0x496D3D0", VA = "0x18496E3D0", Slot = "7")]
		public override void MNMNABLDODO(TClass FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x496D170", Offset = "0x496C170", VA = "0x18496D170", Slot = "8")]
		public override void DKHBDIDLDCN(TClass FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x496D4F0", Offset = "0x496C4F0", VA = "0x18496D4F0", Slot = "9")]
		public override void KEDCILBCIGJ(TClass FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x496C7D0", Offset = "0x496B7D0", VA = "0x18496C7D0", Slot = "10")]
		public override void CAKDOOCBOHB(TClass FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x496EB50", Offset = "0x496DB50", VA = "0x18496EB50")]
		protected TProperty[] PKHNCKGNNAP(TClass FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x496EAD0", Offset = "0x496DAD0", VA = "0x18496EAD0")]
		protected TProperty[] PHEDDAOKOBD(TClass FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4967D60", Offset = "0x4966D60", VA = "0x184967D60", Slot = "4")]
		public override void BCCFFCEEHAG(MethodInfo LDJIDEAGBNF, MethodInfo IPIAPGDJOIH, GENCFPGHEBL PFCMGBLCCPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4212E30", Offset = "0x4211E30", VA = "0x184212E30")]
		protected MNPOEDNNFIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class IAPPOPFFACE<TClass, TProperty> : MNPOEDNNFIE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void EBCNKJHDBAJ(GGNKJMOIFFB AAGDOBFBLJM, [Out] TProperty CENBBDOHHKB);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PNFHIAAFDPN(MCIJLHENOLO LMLEEJBFLHI, TProperty CENBBDOHHKB);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x42E44A0", Offset = "0x42E34A0", VA = "0x1842E44A0", Slot = "5")]
		public override void MLANHIECOMM(TClass FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x42E4370", Offset = "0x42E3370", VA = "0x1842E4370", Slot = "6")]
		public override void LILBNEHPPBF(TClass FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x42E4540", Offset = "0x42E3540", VA = "0x1842E4540", Slot = "7")]
		public override void MNMNABLDODO(TClass FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x42E4160", Offset = "0x42E3160", VA = "0x1842E4160", Slot = "8")]
		public override void DKHBDIDLDCN(TClass FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42E46C0", Offset = "0x42E36C0", VA = "0x1842E46C0")]
		protected IAPPOPFFACE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LMCJPCABMHC<T> : MNPOEDNNFIE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x475EA70", Offset = "0x475DA70", VA = "0x18475EA70", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x41D7060", Offset = "0x41D6060", VA = "0x1841D7060", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x475EAF0", Offset = "0x475DAF0", VA = "0x18475EAF0", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x41D6FF0", Offset = "0x41D5FF0", VA = "0x1841D6FF0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public LMCJPCABMHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HBKLDNALAND<T> : MNPOEDNNFIE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x41D70D0", Offset = "0x41D60D0", VA = "0x1841D70D0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x41D7060", Offset = "0x41D6060", VA = "0x1841D7060", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x41D7150", Offset = "0x41D6150", VA = "0x1841D7150", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x41D6FF0", Offset = "0x41D5FF0", VA = "0x1841D6FF0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public HBKLDNALAND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class CEOIDKHGFJO<T> : MNPOEDNNFIE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5713EE0", Offset = "0x5712EE0", VA = "0x185713EE0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4017B30", Offset = "0x4016B30", VA = "0x184017B30", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5713F60", Offset = "0x5712F60", VA = "0x185713F60", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4017AC0", Offset = "0x4016AC0", VA = "0x184017AC0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public CEOIDKHGFJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class FMDIGAGLMEH<T> : MNPOEDNNFIE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4017BA0", Offset = "0x4016BA0", VA = "0x184017BA0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4017B30", Offset = "0x4016B30", VA = "0x184017B30", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4017C20", Offset = "0x4016C20", VA = "0x184017C20", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4017AC0", Offset = "0x4016AC0", VA = "0x184017AC0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public FMDIGAGLMEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NBNLGLNANOC<T> : MNPOEDNNFIE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x49C5110", Offset = "0x49C4110", VA = "0x1849C5110", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x492AB90", Offset = "0x4929B90", VA = "0x18492AB90", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x49C5190", Offset = "0x49C4190", VA = "0x1849C5190", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x492AB20", Offset = "0x4929B20", VA = "0x18492AB20", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public NBNLGLNANOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class MABOJLKMKLE<T> : MNPOEDNNFIE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x492AC00", Offset = "0x4929C00", VA = "0x18492AC00", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x492AB90", Offset = "0x4929B90", VA = "0x18492AB90", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x492AC80", Offset = "0x4929C80", VA = "0x18492AC80", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x492AB20", Offset = "0x4929B20", VA = "0x18492AB20", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public MABOJLKMKLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JFIKMPPPCNL<T> : MNPOEDNNFIE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4579C20", Offset = "0x4578C20", VA = "0x184579C20", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4579BB0", Offset = "0x4578BB0", VA = "0x184579BB0", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4579CA0", Offset = "0x4578CA0", VA = "0x184579CA0", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4579B40", Offset = "0x4578B40", VA = "0x184579B40", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public JFIKMPPPCNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class KDABOINGPON<T> : MNPOEDNNFIE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4579C20", Offset = "0x4578C20", VA = "0x184579C20", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4579BB0", Offset = "0x4578BB0", VA = "0x184579BB0", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x466DF10", Offset = "0x466CF10", VA = "0x18466DF10", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4579B40", Offset = "0x4578B40", VA = "0x184579B40", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public KDABOINGPON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DIHHIIKHOEO<T> : MNPOEDNNFIE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B40", Offset = "0x5DB6B40", VA = "0x185DB7B40", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7AD0", Offset = "0x5DB6AD0", VA = "0x185DB7AD0", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7BC0", Offset = "0x5DB6BC0", VA = "0x185DB7BC0", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x41D6FF0", Offset = "0x41D5FF0", VA = "0x1841D6FF0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public DIHHIIKHOEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class ODPAGNCPIIO<T> : MNPOEDNNFIE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4AF20A0", Offset = "0x4AF10A0", VA = "0x184AF20A0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4AF2030", Offset = "0x4AF1030", VA = "0x184AF2030", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4AF2120", Offset = "0x4AF1120", VA = "0x184AF2120", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x492AB20", Offset = "0x4929B20", VA = "0x18492AB20", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public ODPAGNCPIIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CBIBPGEBLMA<T> : MNPOEDNNFIE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5707640", Offset = "0x5706640", VA = "0x185707640", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x57075D0", Offset = "0x57065D0", VA = "0x1857075D0", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x57076C0", Offset = "0x57066C0", VA = "0x1857076C0", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4579B40", Offset = "0x4578B40", VA = "0x184579B40", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4017CA0", Offset = "0x4016CA0", VA = "0x184017CA0")]
		public CBIBPGEBLMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class JAPBFJMPMPK<T> : IAPPOPFFACE<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x453C9F0", Offset = "0x453B9F0", VA = "0x18453C9F0", Slot = "12")]
		protected override void PNFHIAAFDPN(MCIJLHENOLO LMLEEJBFLHI, char CENBBDOHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x453C9C0", Offset = "0x453B9C0", VA = "0x18453C9C0", Slot = "11")]
		protected override void EBCNKJHDBAJ(GGNKJMOIFFB AAGDOBFBLJM, [Out] char CENBBDOHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
		public JAPBFJMPMPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BJLKDLBNFKL<T> : IAPPOPFFACE<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x53528F0", Offset = "0x53518F0", VA = "0x1853528F0", Slot = "12")]
		protected override void PNFHIAAFDPN(MCIJLHENOLO LMLEEJBFLHI, IPEndPoint CENBBDOHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x53528B0", Offset = "0x53518B0", VA = "0x1853528B0", Slot = "11")]
		protected override void EBCNKJHDBAJ(GGNKJMOIFFB AAGDOBFBLJM, [Out] IPEndPoint CENBBDOHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
		public BJLKDLBNFKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FOKKHFOFPBF<T> : MNPOEDNNFIE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int EIPAOALCKIA;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x401CDB0", Offset = "0x401BDB0", VA = "0x18401CDB0")]
		public FOKKHFOFPBF(int FDICHMHOOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x401CCB0", Offset = "0x401BCB0", VA = "0x18401CCB0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x401CC30", Offset = "0x401BC30", VA = "0x18401CC30", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x401CD30", Offset = "0x401BD30", VA = "0x18401CD30", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x401CBB0", Offset = "0x401BBB0", VA = "0x18401CBB0", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HDIJHIEDDLN<T> : EAANIAOJKHK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo GMABJBJABLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type MHHHKPHJDFE;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x41DDCD0", Offset = "0x41DCCD0", VA = "0x1841DDCD0")]
		public HDIJHIEDDLN(PropertyInfo EDBGKLDPNAK, Type GACLELKGPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x41DDBB0", Offset = "0x41DCBB0", VA = "0x1841DDBB0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x41DDB00", Offset = "0x41DCB00", VA = "0x1841DDB00", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x41DDC70", Offset = "0x41DCC70", VA = "0x1841DDC70", Slot = "7")]
		public override void MNMNABLDODO(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x41DDA40", Offset = "0x41DCA40", VA = "0x1841DDA40", Slot = "8")]
		public override void DKHBDIDLDCN(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x41DDAA0", Offset = "0x41DCAA0", VA = "0x1841DDAA0", Slot = "9")]
		public override void KEDCILBCIGJ(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x41DD9E0", Offset = "0x41DC9E0", VA = "0x1841DD9E0", Slot = "10")]
		public override void CAKDOOCBOHB(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class AOCEDOMPECK<T> : HDIJHIEDDLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
		public AOCEDOMPECK(PropertyInfo EDBGKLDPNAK, Type GACLELKGPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x43E4DC0", Offset = "0x43E3DC0", VA = "0x1843E4DC0", Slot = "5")]
		public override void MLANHIECOMM(T FAPOHGFNGEP, GGNKJMOIFFB AAGDOBFBLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x43E4D10", Offset = "0x43E3D10", VA = "0x1843E4D10", Slot = "6")]
		public override void LILBNEHPPBF(T FAPOHGFNGEP, MCIJLHENOLO LMLEEJBFLHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MNAJCMNLKPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static MNAJCMNLKPJ<T> LONLOOPDCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly EAANIAOJKHK<T>[] MFOKCGHFEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int HEGEDGOKPGP;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4966720", Offset = "0x4965720", VA = "0x184966720")]
		public MNAJCMNLKPJ(List<EAANIAOJKHK<T>> NALPLPKCMNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x49665C0", Offset = "0x49655C0", VA = "0x1849665C0")]
		public void LILBNEHPPBF(T IFPBFCLBBDP, MCIJLHENOLO FOJCOMJJHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4966670", Offset = "0x4965670", VA = "0x184966670")]
		public void MLANHIECOMM(T IFPBFCLBBDP, GGNKJMOIFFB EEKHIEJPCBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class BEOCJMHKNDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract EAANIAOJKHK<T> KIJHOBDIGPJ<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private MCIJLHENOLO NDPOKAFCHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int FEMGBKOHPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, BEOCJMHKNDC> FCDPNIJIMJF;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x62AF3A0", Offset = "0x62AE3A0", VA = "0x1862AF3A0")]
	public MNCGDLGADIM(int KEKNPNGOBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x308AF10", Offset = "0x3089F10", VA = "0x18308AF10")]
	private MNAJCMNLKPJ<T> IDDBDJEIGDO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E9A0", Offset = "0x2D5D9A0", VA = "0x182D5E9A0")]
	public void EPIGOBOFFNL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x308C030", Offset = "0x308B030", VA = "0x18308C030")]
	public bool OGCNNFLPKKP<T>(GGNKJMOIFFB EEKHIEJPCBE, T CECLKDDLGFE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x308AE80", Offset = "0x3089E80", VA = "0x18308AE80")]
	public void EKFEJLFJOKC<T>(MCIJLHENOLO FOJCOMJJHIM, T IFPBFCLBBDP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BLGGONKOCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime GIKJHBGIAEA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] GLNPAKJPEFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DKAHJPCAKNL FNNGNCENALI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x629DEC0", Offset = "0x629CEC0", VA = "0x18629DEC0")]
		get
		{
			return default(DKAHJPCAKNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MLFJMLNDEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x629DE00", Offset = "0x629CE00", VA = "0x18629DE00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x629E1E0", Offset = "0x629D1E0", VA = "0x18629E1E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public AFPLENPCMKN NKLBOBJCAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x629E1B0", Offset = "0x629D1B0", VA = "0x18629E1B0")]
		get
		{
			return default(AFPLENPCMKN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x629DEF0", Offset = "0x629CEF0", VA = "0x18629DEF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int IODPCFKKJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x629EA40", Offset = "0x629DA40", VA = "0x18629EA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint HKPFBGPKCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x629E130", Offset = "0x629D130", VA = "0x18629E130")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KFNNFGCEJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x629E840", Offset = "0x629D840", VA = "0x18629E840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? JEFPLHDJGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x629EC70", Offset = "0x629DC70", VA = "0x18629EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? JEHPAEHKJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x629DE90", Offset = "0x629CE90", VA = "0x18629DE90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x629E870", Offset = "0x629D870", VA = "0x18629E870")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? OPPDJMFCLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA172A0", Offset = "0xA162A0", VA = "0x180A172A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x629EDB0", Offset = "0x629DDB0", VA = "0x18629EDB0")]
	public BLGGONKOCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x629ED00", Offset = "0x629DD00", VA = "0x18629ED00")]
	internal BLGGONKOCOH(byte[] HPKNAAFAALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x629E220", Offset = "0x629D220", VA = "0x18629E220")]
	public static BLGGONKOCOH LCCMBIBCLGJ(byte[] HPKNAAFAALO, DateTime PABGILBLKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x629EA70", Offset = "0x629DA70", VA = "0x18629EA70")]
	internal void PNHIDPLJALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x629E5D0", Offset = "0x629D5D0", VA = "0x18629E5D0")]
	private void MJLNOBALGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x629DF30", Offset = "0x629CF30", VA = "0x18629DF30")]
	private DateTime? IDFJIFGHIFP(int OFDADLBABBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x629E400", Offset = "0x629D400", VA = "0x18629E400")]
	private void LKFHLJPPEBM(int OFDADLBABBI, DateTime? BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x629DD30", Offset = "0x629CD30", VA = "0x18629DD30")]
	private ulong ABFCKGBMBCF(int OFDADLBABBI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x629E340", Offset = "0x629D340", VA = "0x18629E340")]
	private void LCIMGGPDDOI(int OFDADLBABBI, ulong BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x629E7B0", Offset = "0x629D7B0", VA = "0x18629E7B0")]
	private uint MMKAIIKCJMO(int OFDADLBABBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6171D20", Offset = "0x6170D20", VA = "0x186171D20")]
	private static uint DINMAMFFHNI(uint GOCMFEAMGHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x629DE30", Offset = "0x629CE30", VA = "0x18629DE30")]
	private static ulong DINMAMFFHNI(ulong GOCMFEAMGHO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DKAHJPCAKNL
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum AFPLENPCMKN
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EHAIBGLEAGH
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int JCCEOOOLGLD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int MJOGNHIFOIA = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int MJGEOJANKHK = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint CGACOCELJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int BHAGKJPMKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int GJEDIDLMADC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EFPGKMNPGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x62A0A90", Offset = "0x629FA90", VA = "0x1862A0A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x62A09A0", Offset = "0x629F9A0", VA = "0x1862A09A0")]
	public bool JFEIIEKCNDG(LLGFBDKCMFK JIGACHAEDFM, int JEKIPNBIBLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AMFGADIGKHL : LLGFBDKCMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket JIGACHAEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly FGKGMOGMHDC AJEAPENHOGJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short LHOEIENBCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x629CDE0", Offset = "0x629BDE0", VA = "0x18629CDE0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DMCFPGFHHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x629CDC0", Offset = "0x629BDC0", VA = "0x18629CDC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint INIJGGBDGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x629C7E0", Offset = "0x629B7E0", VA = "0x18629C7E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily PDOLAPKGOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x47037E0", Offset = "0x47027E0", VA = "0x1847037E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x629CF50", Offset = "0x629BF50", VA = "0x18629CF50")]
	public AMFGADIGKHL(AddressFamily PKGLFFEGANA, FGKGMOGMHDC AJEAPENHOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x629C800", Offset = "0x629B800", VA = "0x18629C800", Slot = "8")]
	public bool CFINIAAEIHM(IPEndPoint DNDHMKHNPGC, OECEFAHLDMI IAPBJCBLGAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x629CE20", Offset = "0x629BE20", VA = "0x18629CE20", Slot = "9")]
	public int OCFEKEBAMLK(byte[] CNIEHBMANDE, int OFDADLBABBI, int MLDINGBBEHA, IPEndPoint MCHFMPKJCEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x629CE60", Offset = "0x629BE60", VA = "0x18629CE60", Slot = "10")]
	public int OPEKKKGNIGO(byte[] CNIEHBMANDE, EndPoint ANCJDIDANPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x629CE00", Offset = "0x629BE00", VA = "0x18629CE00", Slot = "11")]
	public void MLGNEBMMJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LLGFBDKCMFK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short LHOEIENBCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int DMCFPGFHHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint INIJGGBDGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily PDOLAPKGOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CFINIAAEIHM(IPEndPoint DNDHMKHNPGC, OECEFAHLDMI IAPBJCBLGAL);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int OCFEKEBAMLK(byte[] CNIEHBMANDE, int OFDADLBABBI, int MLDINGBBEHA, IPEndPoint MCHFMPKJCEL);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OPEKKKGNIGO(byte[] CNIEHBMANDE, EndPoint MCHFMPKJCEL);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MLGNEBMMJNO();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct EDLMMOEIIEK : IEquatable<EDLMMOEIIEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long GOANAHIIKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long EEOOGBFANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long KIJEIBPFDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int GKJOLDHMJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int AHCALOJNMKP;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x62A08B0", Offset = "0x629F8B0", VA = "0x1862A08B0")]
	public EDLMMOEIIEK(byte[] GEBCKJCKLDG, int MMJMDLDFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8DDAC0", Offset = "0x8DCAC0", VA = "0x1808DDAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x62A07C0", Offset = "0x629F7C0", VA = "0x1862A07C0", Slot = "4")]
	public bool Equals(EDLMMOEIIEK DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x62A0800", Offset = "0x629F800", VA = "0x1862A0800", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JJBMNEECOGB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] PHHCPKJBHOH;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PAPDDKDIHGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int KJANDEDJAGH;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
	protected PAPDDKDIHGG(int MNHIBDPLEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LGCGMBJEBPE(IPEndPoint DNDHMKHNPGC, byte[] CONAFKKIHKL, int OFDADLBABBI, int CDEEBECPNGB);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AKJJCPPINPC(IPEndPoint DNDHMKHNPGC, byte[] CONAFKKIHKL, int OFDADLBABBI, int CDEEBECPNGB);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MAOGIICNBOD : PAPDDKDIHGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] MLAECOMLIEC;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator LOOHFEBPNEB;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x231A530", Offset = "0x2319530", VA = "0x18231A530")]
	public MAOGIICNBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x62AE360", Offset = "0x62AD360", VA = "0x1862AE360")]
	public void OKNBFPBDPKJ(IPEndPoint DNDHMKHNPGC, byte[] MLAECOMLIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x62ADDD0", Offset = "0x62ACDD0", VA = "0x1862ADDD0")]
	public void FFDEJPMBDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x62ADEB0", Offset = "0x62ACEB0", VA = "0x1862ADEB0", Slot = "4")]
	public override void LGCGMBJEBPE(IPEndPoint DNDHMKHNPGC, byte[] CONAFKKIHKL, int OFDADLBABBI, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x62ADA70", Offset = "0x62ACA70", VA = "0x1862ADA70", Slot = "5")]
	public override void AKJJCPPINPC(IPEndPoint DNDHMKHNPGC, byte[] CONAFKKIHKL, int OFDADLBABBI, int CDEEBECPNGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct DBLMNJEOHKI
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void MBMGMBOGMDM([NoAlias] byte* AFHGBDIMKDL, [NoAlias] byte* MLAECOMLIEC, [NoAlias] byte* CGPFAMLHABP, int CDEEBECPNGB);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class EEOMMHEJBMA
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x62B3750", Offset = "0x62B2750", VA = "0x1862B3750")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x62B3B40", Offset = "0x62B2B40", VA = "0x1862B3B40")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x62B3870", Offset = "0x62B2870", VA = "0x1862B3870")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x62B3910", Offset = "0x62B2910", VA = "0x1862B3910")]
		public unsafe static void IJNFOBHJKBL([NoAlias] byte* AFHGBDIMKDL, [NoAlias] byte* MLAECOMLIEC, [NoAlias] byte* CGPFAMLHABP, int CDEEBECPNGB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint MLAECOMLIEC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint CGPFAMLHABP[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint AOFILDCCLBB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint KDPBOFJJGBN[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint HKJIGIIADDC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint DDPJMAIPFCC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint BKFIBINAKMJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint GBLCHCBIMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint JOJLBBNBHLF[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x629FFF0", Offset = "0x629EFF0", VA = "0x18629FFF0")]
	private void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x629FFC0", Offset = "0x629EFC0", VA = "0x18629FFC0")]
	private uint BBEDHBBOADJ(uint DEGBNBIJGGI, int GKPONCEMOCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x629C580", Offset = "0x629B580", VA = "0x18629C580")]
	private void MLEHDPEAKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x629C370", Offset = "0x629B370", VA = "0x18629C370")]
	private void MFHPEJHJDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x629C2E0", Offset = "0x629B2E0", VA = "0x18629C2E0")]
	private void ADEJPHDIKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x629C630", Offset = "0x629B630", VA = "0x18629C630")]
	private void OABEPAKBBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x62A06F0", Offset = "0x629F6F0", VA = "0x1862A06F0")]
	private void PBKHDLPDOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x62A0070", Offset = "0x629F070", VA = "0x1862A0070")]
	private unsafe void EADOHPOLDAD(byte* AFHGBDIMKDL, uint* MLAECOMLIEC, uint* CGPFAMLHABP, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x62A0670", Offset = "0x629F670", VA = "0x1862A0670")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NHMNMOHDOGE([NoAlias] byte* AFHGBDIMKDL, [NoAlias] byte* MLAECOMLIEC, [NoAlias] byte* CGPFAMLHABP, int CDEEBECPNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x62A0590", Offset = "0x629F590", VA = "0x1862A0590")]
	public static void NHMNMOHDOGE(Span<byte> AFHGBDIMKDL, Span<byte> MLAECOMLIEC, Span<byte> CGPFAMLHABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x62A0490", Offset = "0x629F490", VA = "0x1862A0490")]
	public static void HFPLGHIPLHD(Span<byte> AFHGBDIMKDL, Span<byte> MLAECOMLIEC, Span<byte> CGPFAMLHABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x62A0750", Offset = "0x629F750", VA = "0x1862A0750")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void PFJIGIEOPIP([NoAlias] byte* AFHGBDIMKDL, [NoAlias] byte* MLAECOMLIEC, [NoAlias] byte* CGPFAMLHABP, int CDEEBECPNGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x62B3D90", Offset = "0x62B2D90", VA = "0x1862B3D90")]
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
