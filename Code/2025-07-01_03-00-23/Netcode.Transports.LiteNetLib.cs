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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CHJPKLPJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum FGHAKMBEOLE
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
		private NetworkManager IPIKGHELDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HGKKKCDCDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, DFHPBFDPENO> BCFMFAOCFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PMACGOELMPL NEJHDLFEJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch NGCKADMALCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] GAGMJINLKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private FGHAKMBEOLE MMMJFFKEKJJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int NJAFEICLIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x71C6010", Offset = "0x71C4610", VA = "0x1871C6010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ADGCCEAKFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool GFADCEIHOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x71C5FF0", Offset = "0x71C45F0", VA = "0x1871C5FF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71C55E0", Offset = "0x71C3BE0", VA = "0x1871C55E0")]
		public void RecRoom_SetEncryptionInfo(ulong NACECFGBPJP, byte[] BLIBAMJKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71C55C0", Offset = "0x71C3BC0", VA = "0x1871C55C0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71C5440", Offset = "0x71C3A40", VA = "0x1871C5440")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71C5EF0", Offset = "0x71C44F0", VA = "0x1871C5EF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71C5700", Offset = "0x71C3D00", VA = "0x1871C5700", Slot = "6")]
		public override void Send(ulong AIEJLCEJPCJ, ArraySegment<byte> ACJFHCNBBBO, NetworkDelivery MEBINLALCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71C5580", Offset = "0x71C3B80", VA = "0x1871C5580", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong AIEJLCEJPCJ, [Out] ArraySegment<byte> INCLIAEIKDJ, [Out] float BIAIELFLHBD)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71C59F0", Offset = "0x71C3FF0", VA = "0x1871C59F0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71C5D10", Offset = "0x71C4310", VA = "0x1871C5D10", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71C4B00", Offset = "0x71C3100", VA = "0x1871C4B00", Slot = "11")]
		public override void DisconnectRemoteClient(ulong AIEJLCEJPCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71C4A10", Offset = "0x71C3010", VA = "0x1871C4A10", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71C4C10", Offset = "0x71C3210", VA = "0x1871C4C10", Slot = "13")]
		public override ulong GetCurrentRtt(ulong AIEJLCEJPCJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71C5980", Offset = "0x71C3F80", VA = "0x1871C5980", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71C4D70", Offset = "0x71C3370", VA = "0x1871C4D70", Slot = "15")]
		public override void Initialize([Optional] NetworkManager IPIKGHELDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71C5290", Offset = "0x71C3890", VA = "0x1871C5290")]
		private IMLMJHJKBHO MFMHCNKNBOA(NetworkDelivery JLPANLJHHFI)
		{
			return default(IMLMJHJKBHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71C4CB0", Offset = "0x71C32B0", VA = "0x1871C4CB0", Slot = "16")]
		private void HBGLIKCIHIH(DFHPBFDPENO IKAPODCCKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71C4F80", Offset = "0x71C3580", VA = "0x1871C4F80", Slot = "17")]
		private void JKCNDGKELKP(DFHPBFDPENO IKAPODCCKHJ, PGKHLDENCPP CGCDMNJEMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "18")]
		private void JEKCCLIOJCJ(IPEndPoint DOEPIOCFAJN, SocketError JJKFAFHMLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71C5050", Offset = "0x71C3650", VA = "0x1871C5050", Slot = "19")]
		private void KEMNFJLOFFI(DFHPBFDPENO IKAPODCCKHJ, IMENGHKNBCB KMBIKKJCMFN, byte NPLFHHNNOKH, IMLMJHJKBHO BJJOGJJCHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71C5360", Offset = "0x71C3960", VA = "0x1871C5360")]
		private void NLBHMNIDIIE(int GPNBMIDFKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "20")]
		private void DHBMJDEOFLJ(IPEndPoint LGOHOCOFJAE, IMENGHKNBCB KMBIKKJCMFN, NCJMJJCEHCJ INKIBKIOMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "21")]
		private void CIBACPAKPCM(DFHPBFDPENO IKAPODCCKHJ, int EJDMKKLPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71C49B0", Offset = "0x71C2FB0", VA = "0x1871C49B0", Slot = "22")]
		private void CNKBIGDCGFM(GNCALAHPPNN IPMGANOCOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71C5550", Offset = "0x71C3B50", VA = "0x1871C5550")]
		private ulong PJIHDNAFIKO(DFHPBFDPENO IKAPODCCKHJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71C5530", Offset = "0x71C3B30", VA = "0x1871C5530")]
		private ulong PJIHDNAFIKO(ulong AIEJLCEJPCJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71C4990", Offset = "0x71C2F90", VA = "0x1871C4990")]
		private static int CCOIHGIDMOL(float BKONJIDKCPP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71C5F10", Offset = "0x71C4510", VA = "0x1871C5F10")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71C5260", Offset = "0x71C3860", VA = "0x1871C5260")]
		[CompilerGenerated]
		private void LMEGNFJHPOI(ulong PCMOENLPNAD, int CEHBJKMKFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71C5260", Offset = "0x71C3860", VA = "0x1871C5260")]
		[CompilerGenerated]
		private void PAHCGGJFKOJ(ulong PCMOENLPNAD, int CEHBJKMKFHD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class DCPFMAJCFFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly DFHPBFDPENO GOFOLKECEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<IKELELGNOHO> IIIGPILPGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int GGHLDJDCJJO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EEIHIJMLJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71BA470", Offset = "0x71B8A70", VA = "0x1871BA470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71BA500", Offset = "0x71B8B00", VA = "0x1871BA500")]
	protected DCPFMAJCFFN(DFHPBFDPENO IKAPODCCKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71BA390", Offset = "0x71B8990", VA = "0x1871BA390")]
	public void AEGIBPBGCPD(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71BA3F0", Offset = "0x71B89F0", VA = "0x1871BA3F0")]
	protected void AFCHPNDEDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71BA4C0", Offset = "0x71B8AC0", VA = "0x1871BA4C0")]
	public bool NBDCJIDCKNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OOGAPMFGHGD();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool DHLNBEEONFM(IKELELGNOHO PIDNHILCPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum KCKIGBNPOIN
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
public class GNCALAHPPNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PMACGOELMPL MGNMPGOJNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int OKABPIHECBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal GANJBMHHMHF NAMEANONKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint ONGLPBLMKJE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal KCKIGBNPOIN ILBKEFOPONE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
		[CompilerGenerated]
		get
		{
			return default(KCKIGBNPOIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71C0410", Offset = "0x71BEA10", VA = "0x1871C0410")]
	internal void HACHCBKLBFE(GANJBMHHMHF DGNFADENAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71C0470", Offset = "0x71BEA70", VA = "0x1871C0470")]
	private bool KAIPPKAKOPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71C04A0", Offset = "0x71BEAA0", VA = "0x1871C04A0")]
	internal GNCALAHPPNN(IPEndPoint LGOHOCOFJAE, GANJBMHHMHF NOFFKOIFMDH, PMACGOELMPL LOKOFEBDGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71C03B0", Offset = "0x71BE9B0", VA = "0x1871C03B0")]
	public DFHPBFDPENO AGJGPLDJFBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NCJMJJCEHCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum ABAJJINJJFG
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
public struct PGKHLDENCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ABAJJINJJFG FLGNDLECDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError EBBJKDAHNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public IMENGHKNBCB MIIEGFIGINK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CHJPKLPJAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDOFKMFLGHO(DFHPBFDPENO IKAPODCCKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGIEGGKFHKI(DFHPBFDPENO IKAPODCCKHJ, PGKHLDENCPP CGCDMNJEMEE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHFLHCPJMMO(IPEndPoint DOEPIOCFAJN, SocketError JJKFAFHMLCE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMLPCOOFDKE(DFHPBFDPENO IKAPODCCKHJ, IMENGHKNBCB KMBIKKJCMFN, byte NPLFHHNNOKH, IMLMJHJKBHO BJJOGJJCHBK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBOPIIMHBHJ(IPEndPoint LGOHOCOFJAE, IMENGHKNBCB KMBIKKJCMFN, NCJMJJCEHCJ INKIBKIOMOC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENOKFDGGCJJ(DFHPBFDPENO IKAPODCCKHJ, int EJDMKKLPIOL);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOFDOBJGJEK(GNCALAHPPNN IPMGANOCOKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IJHAIEGGJMI
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLCOLMEEBBD(DFHPBFDPENO IKAPODCCKHJ, object NHHCIFGFJME);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NCFGGDMPFEG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHKJBPPDOPK(LGAFHJOBFBC PIDNHILCPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MHCLJNBKKNN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNFPECNEEEN(DFHPBFDPENO IKAPODCCKHJ, IPEndPoint IKPAOCBCNEN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class GANJBMHHMHF
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int HOKAPNMGNOD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long CNJJDBJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte KGHMCCOKGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] FMBDJIEJMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IPGCCOEBOLB IKFGCCPLOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int KACPFIDPDCG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71BF030", Offset = "0x71BD630", VA = "0x1871BF030")]
	private GANJBMHHMHF(long LIJAGDMEFID, byte AFPGOCJEGAP, int OHGBPBLOAKN, byte[] LMOCKNJIFOL, IPGCCOEBOLB ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71BEDB0", Offset = "0x71BD3B0", VA = "0x1871BEDB0")]
	public static int LJMNGPDJBNK(IKELELGNOHO PIDNHILCPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71BEE10", Offset = "0x71BD410", VA = "0x1871BEE10")]
	public static GANJBMHHMHF NHEEIAHADLN(IKELELGNOHO PIDNHILCPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71BEBD0", Offset = "0x71BD1D0", VA = "0x1871BEBD0")]
	public static IKELELGNOHO DINGKLICFDL(NELEEECPCFG IBCCEAIDLNJ, SocketAddress JGKHIFEGHKM, long KGNGNHNEMJH, int OHGBPBLOAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class NJJMGDPHKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long CNJJDBJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte KGHMCCOKGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int KACPFIDPDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool PJCBNJJHKNL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71C8CA0", Offset = "0x71C72A0", VA = "0x1871C8CA0")]
	private NJJMGDPHKIH(long LIJAGDMEFID, byte AFPGOCJEGAP, int CMOPGDONBMK, bool BENDFHIGLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71C8B50", Offset = "0x71C7150", VA = "0x1871C8B50")]
	public static NJJMGDPHKIH NHEEIAHADLN(IKELELGNOHO PIDNHILCPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71C8960", Offset = "0x71C6F60", VA = "0x1871C8960")]
	public static IKELELGNOHO DINGKLICFDL(long KGNGNHNEMJH, byte IJJIODNDIKI, int KNBJPGOCNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71C8A50", Offset = "0x71C7050", VA = "0x1871C8A50")]
	public static IKELELGNOHO MAMLDKEDAJN(DFHPBFDPENO IKAPODCCKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum KMMKMMHKFNH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BOLOAJJKDJI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIJLCKLCBHD(IPEndPoint INKMJBNAICL, IPEndPoint LGOHOCOFJAE, string DKFMAIJGPFL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNLMOBLLKOD(IPEndPoint JBGAFIPPNKC, KMMKMMHKFNH JLPANLJHHFI, string DKFMAIJGPFL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NAOGGGACNEG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NCFNKJBLAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint APHIJAJJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint ONGLPBLMKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string JMHGIAHOODA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct EJKLABAGJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint HIBJHMGAJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KMMKMMHKFNH AKEHBOGGIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string JMHGIAHOODA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class GGJKKGKBKDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint HCIJALAEAKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string JMHGIAHOODA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GGJKKGKBKDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class ABCMNNDHNOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint HCIJALAEAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint GACNPJEOEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string JMHGIAHOODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ABCMNNDHNOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class FHPMOLAPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string JMHGIAHOODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LJEDPNKOKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FHPMOLAPJIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PMACGOELMPL MCKPPCBLCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<NCFNKJBLAFO> EMGFEJJEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<EJKLABAGJKI> BPPOJCEFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly IPGCCOEBOLB LGAHLJLEOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly NELEEECPCFG GGDIHBMFLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JPNDDJCKEHJ KLLPHFPPCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private BOLOAJJKDJI LLDBACMEINN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int DGAGLBHDDJH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool PLAAIBPAJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71C7570", Offset = "0x71C5B70", VA = "0x1871C7570")]
	internal NAOGGGACNEG(PMACGOELMPL GLACGOPPINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71C70D0", Offset = "0x71C56D0", VA = "0x1871C70D0")]
	internal void EGMJLEJCPMG(IPEndPoint DEEEPINPNDB, IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C84480", Offset = "0x3C82A80", VA = "0x183C84480")]
	private void CKFDMMPHCBO<T>(T PIDNHILCPKF, IPEndPoint OKOGHNMMGGB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71C73E0", Offset = "0x71C59E0", VA = "0x1871C73E0")]
	private void PIJLCKLCBHD(GGJKKGKBKDG CHICIHEOMFO, IPEndPoint DEEEPINPNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71C6F70", Offset = "0x71C5570", VA = "0x1871C6F70")]
	private void BJPDPPCEMFC(ABCMNNDHNOI CHICIHEOMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71C7250", Offset = "0x71C5850", VA = "0x1871C7250")]
	private void JCFHMGKFBEF(FHPMOLAPJIG CHICIHEOMFO, IPEndPoint DEEEPINPNDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IMLMJHJKBHO : byte
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
public enum PPGEOGCJEGJ : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NEAJKEGFIAO
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] FOOOJBCHKGK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int FBDNCDGABAJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int EHMFCCCFIND;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KOHBDIGCMFG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFBE0", VA = "0x1871C15E0")]
	public KOHBDIGCMFG(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HHJLFIKILON : KOHBDIGCMFG
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFBE0", VA = "0x1871C15E0")]
	public HHJLFIKILON(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum ELFIPOEJPOD
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
public interface GNGICFHNKIC
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDKFIBAKHHC(ELFIPOEJPOD LGANFDFFIKF, string IKLHNGEBLBJ, params object[] MMCAOMENGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class AKCKAEGKACF
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static GNGICFHNKIC KAMIMBJFPOM;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object INDABPPMHNI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x71B9F90", Offset = "0x71B8590", VA = "0x1871B9F90")]
	private static void GGAGJEMIOAE(ELFIPOEJPOD OKLFGMOJJKH, string IKLHNGEBLBJ, params object[] MMCAOMENGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71BA220", Offset = "0x71B8820", VA = "0x1871BA220")]
	internal static void MJPGGBIIMHA(string IKLHNGEBLBJ, params object[] MMCAOMENGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x71BA280", Offset = "0x71B8880", VA = "0x1871BA280")]
	internal static void PCOJCJJHKKN(string IKLHNGEBLBJ, params object[] MMCAOMENGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71BA1C0", Offset = "0x71B87C0", VA = "0x1871BA1C0")]
	internal static void MFDPMPBLJOC(string IKLHNGEBLBJ, params object[] MMCAOMENGOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum DCJMLEABKIE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IMENGHKNBCB : IPGCCOEBOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private IKELELGNOHO CINEHJIGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PMACGOELMPL GDOOEAFGPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DMKOFKFBHMH EBDMBBDGECP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71C25B0", Offset = "0x71C0BB0", VA = "0x1871C25B0")]
	internal IMENGHKNBCB(PMACGOELMPL MIPDPIDNIBN, DMKOFKFBHMH EIAEFJKKDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71C2540", Offset = "0x71C0B40", VA = "0x1871C2540")]
	internal void MLPGHPKOPHJ(IKELELGNOHO PIDNHILCPKF, int OFKJKOJHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71C24C0", Offset = "0x71C0AC0", VA = "0x1871C24C0")]
	internal void MAPEHJMPDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71C2490", Offset = "0x71C0A90", VA = "0x1871C2490")]
	public void HEPPOJFGNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class DMKOFKFBHMH
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum LODOJALOGKP
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
	public DMKOFKFBHMH KCBIGOIHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LODOJALOGKP AKEHBOGGIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public DFHPBFDPENO GOFOLKECEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint ONGLPBLMKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object FHCGAELHEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int PJOOKHCJPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError EHCDCKLHAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public ABAJJINJJFG CFIBBIJCLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public GNCALAHPPNN PPOHCONGDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public IMLMJHJKBHO IAKIEKNABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte NMEJNNFADDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly IMENGHKNBCB GFDNFJGNDOL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71BEA90", Offset = "0x71BD090", VA = "0x1871BEA90")]
	public DMKOFKFBHMH(PMACGOELMPL MIPDPIDNIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMACGOELMPL : IEnumerable<DFHPBFDPENO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class NBBLHFGIJBJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x71C79C0", Offset = "0x71C5FC0", VA = "0x1871C79C0", Slot = "4")]
		public bool Equals(IPEndPoint POMHCCBBBGD, IPEndPoint JKKMGDMGNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D48F20", Offset = "0x6D47520", VA = "0x186D48F20", Slot = "5")]
		public int GetHashCode(IPEndPoint ODCICEDDLMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NBBLHFGIJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PIMAHPAACCP : IEnumerator<DFHPBFDPENO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly DFHPBFDPENO HNPAEAEAJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private DFHPBFDPENO LFGBJGMCBII;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DFHPBFDPENO CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1BC98A0", Offset = "0x1BC7EA0", VA = "0x181BC98A0")]
		public PIMAHPAACCP(DFHPBFDPENO CMGKLEEINPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71C9DF0", Offset = "0x71C83F0", VA = "0x1871C9DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71C9E40", Offset = "0x71C8440", VA = "0x1871C9E40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread NCHJOPNCAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool JFCOIBJMIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool NOCBPGCCNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private EBALMMNEJNA EEEAILDHIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent AHGMDHJHNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<DMKOFKFBHMH> PBFKPIGFAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<DMKOFKFBHMH> COJHELDLPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DMKOFKFBHMH DLIALHLOOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CHJPKLPJAHC ENFPBPKLIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IJHAIEGGJMI AIKNPJHKMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly NCFGGDMPFEG BHNDDAKEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MHCLJNBKKNN AKPLBHGMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, DFHPBFDPENO> ONLJCAPMHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, GNCALAHPPNN> KKPJNDCJPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, PDOFCNJNKAP> LIHBADFMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim BDELCMHBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private DFHPBFDPENO HABGAPCIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int MIDPFIONGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<DFHPBFDPENO> IBODNOFJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private DFHPBFDPENO[] CAMCMDBIDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly MJCGHCHLIBH HMLLFMJLHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int JJDBOGDOJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> ELMKNKEKPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte DCCKGNLINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object ACPAGDGDABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool PNCFKELLHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool MHHLFIIBJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BBNJHEKMDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int PHJAFEDDFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int HGPFMJPDMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int EELDKCMIBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool FNLJPEPDBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HEHPCBIKJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int CNAFPODNNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HCDLLIHKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int JKFBNHJKAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool PLAAIBPAJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool BBIKJJMDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool DNMDHACHLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool IGPACPIKCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int CBFEFHOLEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int AAPPLLNGJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool DJEFFEPKCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly NPPCLPIMHDC LJMBKHDAHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NEOPNBHFBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly NAOGGGACNEG DHNJICDAHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool EIOKEIFCAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public DCJMLEABKIE ECIOONCOFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int DDGCLBHOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool PGCMKHHAEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool CMPDJKHAFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool CMCOCACKFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool BCGHOHCPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IKELELGNOHO EPHDEGCIEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int ILDHDBFGAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object NCMCLLNGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private IKELELGNOHO NANJPCFNCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int KHPJMPFEHIJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int NELLEPEHEJN = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int PADGJFNKIDO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private JBBHAGIDBCB LANJGAAEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JBBHAGIDBCB LJLACHGKNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread NAOGHDBLLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread AGGINNOJEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint MCEDPGDJDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint LMBCLNEHCFC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] HAMJBFMEPEH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] MMMCKIKODMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<HJFCLKNIBIB, IPEndPoint> FMMHPHKPAMM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress HNGHOCGAIIF;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool ECFIENEFPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int CPMFEEBIOOP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GGFFJMFFOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB5BFA0", Offset = "0xB5A5A0", VA = "0x180B5BFA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB604D0", Offset = "0xB5EAD0", VA = "0x180B604D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BJACCPMDHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x16FE0F0", Offset = "0x16FC6F0", VA = "0x1816FE0F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2011770", Offset = "0x200FD70", VA = "0x182011770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte LGEGLJDEEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xFCD950", Offset = "0xFCBF50", VA = "0x180FCD950")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PLFEOBLPMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71CE440", Offset = "0x71CCA40", VA = "0x1871CE440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short OOAFNABDOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71CB9A0", Offset = "0x71C9FA0", VA = "0x1871CB9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DFHPBFDPENO.CHKBAMBDCIE LLKMPFEJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71CBA60", Offset = "0x71CA060", VA = "0x1871CBA60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71CFB80", Offset = "0x71CE180", VA = "0x1871CFB80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71CBE80", Offset = "0x71CA480", VA = "0x1871CBE80")]
	public void FEJNGFLCJIB(IPEndPoint DOEPIOCFAJN, byte[] BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71D09A0", Offset = "0x71CEFA0", VA = "0x1871D09A0")]
	public void NFNGGPGIIAM(IPEndPoint DOEPIOCFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71CB620", Offset = "0x71C9C20", VA = "0x1871CB620")]
	private bool EBAIAGFEHPO(IPEndPoint DOEPIOCFAJN, [Out] DFHPBFDPENO IKAPODCCKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x71D1190", Offset = "0x71CF790", VA = "0x1871D1190")]
	private void PBJNJBPIIMH(DFHPBFDPENO IKAPODCCKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x71CC0A0", Offset = "0x71CA6A0", VA = "0x1871CC0A0")]
	private void FLPCNIAOCBC(DFHPBFDPENO IKAPODCCKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71CE160", Offset = "0x71CC760", VA = "0x1871CE160")]
	private void IHLKCGGIAOJ(DFHPBFDPENO IKAPODCCKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71D1830", Offset = "0x71CFE30", VA = "0x1871D1830")]
	public PMACGOELMPL(CHJPKLPJAHC LOKOFEBDGAL, [Optional] MJCGHCHLIBH LADHOHGKGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71CF090", Offset = "0x71CD690", VA = "0x1871CF090")]
	internal void JIKOFLGMMNK(DFHPBFDPENO MEHPKJCGEEP, int EJDMKKLPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71CFFD0", Offset = "0x71CE5D0", VA = "0x1871CFFD0")]
	internal void KFEHDIIOCJH(DFHPBFDPENO MEHPKJCGEEP, object NHHCIFGFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71D0250", Offset = "0x71CE850", VA = "0x1871D0250")]
	internal void LPLLGKOAKMK(DFHPBFDPENO IKAPODCCKHJ, ABAJJINJJFG CIOGCOOPLBM, SocketError FJJGCICOFMK, IKELELGNOHO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x71CEC80", Offset = "0x71CD280", VA = "0x1871CEC80")]
	private void JEPNIBEICAP(DFHPBFDPENO IKAPODCCKHJ, ABAJJINJJFG CIOGCOOPLBM, SocketError FJJGCICOFMK, bool KKBNDFNEENM, byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int FOAMCIPOLAA, IKELELGNOHO FLDOIECLDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71D0410", Offset = "0x71CEA10", VA = "0x1871D0410")]
	private void NBFCJOMANCL(DMKOFKFBHMH.LODOJALOGKP JLPANLJHHFI, [Optional] DFHPBFDPENO IKAPODCCKHJ, [Optional] IPEndPoint LGOHOCOFJAE, SocketError AMNMJKOJOJL = SocketError.Success, int EJDMKKLPIOL = 0, ABAJJINJJFG JKCHCPCEGAD = ABAJJINJJFG.ConnectionFailed, [Optional] GNCALAHPPNN GMAPAENDENB, IMLMJHJKBHO BJJOGJJCHBK = IMLMJHJKBHO.Unreliable, byte NPLFHHNNOKH = 0, [Optional] IKELELGNOHO JLKPDMDFGAP, [Optional] object NHHCIFGFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71CE460", Offset = "0x71CCA60", VA = "0x1871CE460")]
	private void IKNKAMJICKF(DMKOFKFBHMH EIAEFJKKDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71CFA70", Offset = "0x71CE070", VA = "0x1871CFA70")]
	internal void JLINPPGCJDM(DMKOFKFBHMH EIAEFJKKDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x71CCA40", Offset = "0x71CB040", VA = "0x1871CCA40")]
	private void HCKEGNHHAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71CC100", Offset = "0x71CA700", VA = "0x1871CC100")]
	private void FOCFOLEKCFE(int KNIFHHDELAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71CC420", Offset = "0x71CAA20", VA = "0x1871CC420")]
	internal DFHPBFDPENO GJKJHMMPLPC(GNCALAHPPNN IPMGANOCOKF, byte[] EJGLPAIIMJP, int BKJCDJJKAFA, int PHABMFMJBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71CAE80", Offset = "0x71C9480", VA = "0x1871CAE80")]
	private int CBCMINKCJAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x71CB170", Offset = "0x71C9770", VA = "0x1871CB170")]
	private void DMKEABMJPCM(IPEndPoint LGOHOCOFJAE, DFHPBFDPENO KJBPAMJFJMH, GANJBMHHMHF HECIAOJAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71CCD90", Offset = "0x71CB390", VA = "0x1871CCD90")]
	private void IHAJJNFEHCE(IKELELGNOHO PIDNHILCPKF, IPEndPoint LGOHOCOFJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71CB6C0", Offset = "0x71C9CC0", VA = "0x1871CB6C0")]
	internal void EEFJLIEJEKB(IKELELGNOHO PIDNHILCPKF, IMLMJHJKBHO PBFMFMMGIGC, byte NPLFHHNNOKH, int OFKJKOJHCMF, DFHPBFDPENO MEHPKJCGEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71CAE70", Offset = "0x71C9470", VA = "0x1871CAE70")]
	public bool BNJPFDALMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71CADD0", Offset = "0x71C93D0", VA = "0x1871CADD0")]
	public bool BNJPFDALMCI(IPAddress DHBAGKOFILJ, IPAddress MFNEOOHNONL, int LMJGOBCMGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71CADF0", Offset = "0x71C93F0", VA = "0x1871CADF0")]
	public bool BNJPFDALMCI(int LMJGOBCMGBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71D07F0", Offset = "0x71CEDF0", VA = "0x1871D07F0")]
	public void NFJEFEGNOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71CA350", Offset = "0x71C8950", VA = "0x1871CA350")]
	public DFHPBFDPENO AJCHJADPAEI(string GFKHACLJBMJ, int LMJGOBCMGBL, string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71CA270", Offset = "0x71C8870", VA = "0x1871CA270")]
	public DFHPBFDPENO AJCHJADPAEI(string GFKHACLJBMJ, int LMJGOBCMGBL, NELEEECPCFG HJEDMOICLPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71C9E90", Offset = "0x71C8490", VA = "0x1871C9E90")]
	public DFHPBFDPENO AJCHJADPAEI(IPEndPoint OKOGHNMMGGB, NELEEECPCFG HJEDMOICLPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x71CBE70", Offset = "0x71CA470", VA = "0x1871CBE70")]
	public void ELHJEAOCKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71CBB10", Offset = "0x71CA110", VA = "0x1871CBB10")]
	public void ELHJEAOCKOJ(bool KIIMBFLCHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x71D0D40", Offset = "0x71CF340", VA = "0x1871D0D40")]
	public void NNJLHANPJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x71D0DF0", Offset = "0x71CF3F0", VA = "0x1871D0DF0")]
	public void NNJLHANPJOB(byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71CEC00", Offset = "0x71CD200", VA = "0x1871CEC00")]
	public void JEPNIBEICAP(DFHPBFDPENO IKAPODCCKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71CEC40", Offset = "0x71CD240", VA = "0x1871CEC40")]
	public void JEPNIBEICAP(DFHPBFDPENO IKAPODCCKHJ, byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x71D1650", Offset = "0x71CFC50", VA = "0x1871D1650", Slot = "4")]
	private IEnumerator<DFHPBFDPENO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71D16E0", Offset = "0x71CFCE0", VA = "0x1871D16E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x71D0160", Offset = "0x71CE760", VA = "0x1871D0160")]
	private IKELELGNOHO KMGOBCGFCHC(PECJKLGIHCO PJAMOIBNMIO, int GPNBMIDFKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x71D0080", Offset = "0x71CE680", VA = "0x1871D0080")]
	private IKELELGNOHO KMGOBCGFCHC(PECJKLGIHCO PJAMOIBNMIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x71D0AF0", Offset = "0x71CF0F0", VA = "0x1871D0AF0")]
	internal IKELELGNOHO NHNAKPCMHGD(int GPNBMIDFKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71CAF00", Offset = "0x71C9500", VA = "0x1871CAF00")]
	internal void DKDHCDDAOIK(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x71D1770", Offset = "0x71CFD70", VA = "0x1871D1770")]
	static PMACGOELMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB5BFA0", Offset = "0xB5A5A0", VA = "0x180B5BFA0")]
	private bool JNHKEEAMOLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71D0290", Offset = "0x71CE890", VA = "0x1871D0290")]
	private void MCJLOEHJKAI(IPEndPoint KHKKGHJBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71CF900", Offset = "0x71CDF00", VA = "0x1871CF900")]
	private void JLCOFJDFCMD(IPEndPoint KHKKGHJBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x71CA450", Offset = "0x71C8A50", VA = "0x1871CA450")]
	private bool BDMJKMOAOBN(SocketException CGONOPBDIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71CA430", Offset = "0x71C8A30", VA = "0x1871CA430")]
	private void ANOMCBMAJIP(EBALMMNEJNA GLACGOPPINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x71D0EC0", Offset = "0x71CF4C0", VA = "0x1871D0EC0")]
	private void OGMLCMLIIBK(JBBHAGIDBCB GLACGOPPINA, EndPoint KHJELCOGMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x71CFC30", Offset = "0x71CE230", VA = "0x1871CFC30")]
	private void JNIDPEIMODN(object DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71CA600", Offset = "0x71C8C00", VA = "0x1871CA600")]
	public bool BNJPFDALMCI(IPAddress DHBAGKOFILJ, IPAddress MFNEOOHNONL, int LMJGOBCMGBL, bool LJEBKADJHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71D0020", Offset = "0x71CE620", VA = "0x1871D0020")]
	internal int KFPEFBBOFJH(IKELELGNOHO PIDNHILCPKF, IPEndPoint LGOHOCOFJAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71CF8C0", Offset = "0x71CDEC0", VA = "0x1871CF8C0")]
	internal int JJBHHMMILCD(IKELELGNOHO PIDNHILCPKF, IPEndPoint LGOHOCOFJAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71CF0E0", Offset = "0x71CD6E0", VA = "0x1871CF0E0")]
	internal int JJBHHMMILCD(byte[] CJIMOMNMAGD, int BKJCDJJKAFA, int PHABMFMJBEC, IPEndPoint LGOHOCOFJAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x71D14D0", Offset = "0x71CFAD0", VA = "0x1871D14D0")]
	internal void PKOEGGBCJHJ(bool BJDKBMABNOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum PECJKLGIHCO : byte
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
internal sealed class IKELELGNOHO
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int GCDOBPNBABF;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] JCCPCDAGOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] PHFLJEAEBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int GBKBNOBKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object FHCGAELHEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public IKELELGNOHO KCBIGOIHHPC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PECJKLGIHCO LPNDDFLMCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x71C1D70", Offset = "0x71C0370", VA = "0x1871C1D70")]
		get
		{
			return default(PECJKLGIHCO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x71C1F90", Offset = "0x71C0590", VA = "0x1871C1F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte KGHMCCOKGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71C1C40", Offset = "0x71C0240", VA = "0x1871C1C40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71C1F50", Offset = "0x71C0550", VA = "0x1871C1F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort EENJMOOLKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x71C1C70", Offset = "0x71C0270", VA = "0x1871C1C70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A10", Offset = "0x71C0010", VA = "0x1871C1A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HNOFKLAGANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x71C1AB0", Offset = "0x71C00B0", VA = "0x1871C1AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte HHALOLBOBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A50", Offset = "0x71C0050", VA = "0x1871C1A50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x71C1DA0", Offset = "0x71C03A0", VA = "0x1871C1DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort EBDPPANBCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71C1FD0", Offset = "0x71C05D0", VA = "0x1871C1FD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x71C1DD0", Offset = "0x71C03D0", VA = "0x1871C1DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort HBKICPONNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71C1CD0", Offset = "0x71C02D0", VA = "0x1871C1CD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x71C1D30", Offset = "0x71C0330", VA = "0x1871C1D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort ACFCJEJCMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x71C1AE0", Offset = "0x71C00E0", VA = "0x1871C1AE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x71C1F10", Offset = "0x71C0510", VA = "0x1871C1F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x71C2030", Offset = "0x71C0630", VA = "0x1871C2030")]
	static IKELELGNOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x71C1A80", Offset = "0x71C0080", VA = "0x1871C1A80")]
	public void BLBKCFJLDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71C2310", Offset = "0x71C0910", VA = "0x1871C2310")]
	public IKELELGNOHO(int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x71C2380", Offset = "0x71C0980", VA = "0x1871C2380")]
	public IKELELGNOHO(PECJKLGIHCO PJAMOIBNMIO, int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x71C1EA0", Offset = "0x71C04A0", VA = "0x1871C1EA0")]
	public static int MIBMMEANFPB(PECJKLGIHCO PJAMOIBNMIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x71C1E10", Offset = "0x71C0410", VA = "0x1871C1E10")]
	public int MIBMMEANFPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x71C1B40", Offset = "0x71C0140", VA = "0x1871C1B40")]
	public bool ENAHLLCECKK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum BOIFJNDNGIB : byte
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
internal enum EALIMHMGAPI
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
internal enum APHNKKMKJBL
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum DJLGDIPPEOE
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DFHPBFDPENO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MGJDDBBNFOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IKELELGNOHO[] DLJNNPCPAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int NLNJHENMHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int MBNOGDEKMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte HHALOLBOBGB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MGJDDBBNFOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void CHKBAMBDCIE(ulong PCMOENLPNAD, int CEHBJKMKFHD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int HOCPBMGGCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int OANODGMGIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int CAKJBLINEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double PKCBEGMCBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int NOPNDEJNPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int EKIFKHBLAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int AMNOLACBFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch KGOGNJNKPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int FILBCAJLAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long PLOHAOIPGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object CCJNFKIENHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal DFHPBFDPENO FFHABNFDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal DFHPBFDPENO PDLBIMLLLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<IKELELGNOHO> DDOJGMFEDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<DCPFMAJCFFN> ABPMOPPCCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly DCPFMAJCFFN[] MKCPNPJHMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int PJFPLEPKNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int ADFDJHNCLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool JCHECBIJDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int DOJAAJFGOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int BFPCPODFGFK;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int EFDDOONMMOA = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int ANDHAJAGNAM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object EIGOMHFOGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KNNDNEEPPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, MGJDDBBNFOJ> JCBBHJPOBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> AANDJHDEKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly IKELELGNOHO BOMBNCMKAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BMFLKDABHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int GJOLIBCPNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint LPGBKAHELFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EBGLLOPBLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int LGEILJBBIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long DGBNJOLDJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte AIIIPLMHMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private BOIFJNDNGIB CJLHBDFIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private IKELELGNOHO ODHMPGOEJOI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int NJLBDLHMONH = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int EBDEGCLKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly IKELELGNOHO HHAJIIKDLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly IKELELGNOHO ADDGINIPKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly IKELELGNOHO DDKPDPLEHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly IKELELGNOHO AHFPGGHLHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private PPGEOGCJEGJ FGCHDCGKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly PMACGOELMPL CLGPBCPINEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int NJJOPPIMCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object HBHKBGCHJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly NPPCLPIMHDC LJMBKHDAHJL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte DHMNOBMLKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB6EA40", Offset = "0xB6D040", VA = "0x180B6EA40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71BA5A0", Offset = "0x71B8BA0", VA = "0x1871BA5A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint CHNJLGIMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAD80D0", Offset = "0xAD66D0", VA = "0x180AD80D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BOIFJNDNGIB DGAMEMKHKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xC59430", Offset = "0xC57A30", VA = "0x180C59430")]
		get
		{
			return default(BOIFJNDNGIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long CDOOKFBJMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA51ED0", Offset = "0xA504D0", VA = "0x180A51ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LFLBFFGIEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x16FE0F0", Offset = "0x16FC6F0", VA = "0x1816FE0F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2011770", Offset = "0x200FD70", VA = "0x182011770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EMEMOJLPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x71BE150", Offset = "0x71BC750", VA = "0x1871BE150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EPNPHBPJCME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double OMDFOCIFFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x56A6F00", Offset = "0x56A5500", VA = "0x1856A6F00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CHKBAMBDCIE LLKMPFEJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71BB5E0", Offset = "0x71B9BE0", VA = "0x1871BB5E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x71BCE70", Offset = "0x71BB470", VA = "0x1871BCE70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71BE4D0", Offset = "0x71BCAD0", VA = "0x1871BE4D0")]
	internal DFHPBFDPENO(PMACGOELMPL JKLBGILINCL, IPEndPoint LGOHOCOFJAE, int HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71BD8C0", Offset = "0x71BBEC0", VA = "0x1871BD8C0")]
	internal void MKLCNDCCODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71BB690", Offset = "0x71B9C90", VA = "0x1871BB690")]
	internal void EHAHFKAPAEA(IPEndPoint LEIHIDFAANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x71BD8E0", Offset = "0x71BBEE0", VA = "0x1871BD8E0")]
	internal void MPBGPHGAMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x71BAC40", Offset = "0x71B9240", VA = "0x1871BAC40")]
	private void CMAELBDEHGK(int PLICAFHPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x71BB8F0", Offset = "0x71B9EF0", VA = "0x1871BB8F0")]
	private void FKBOHJBGMAG(int OBAIAODBPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71BB6C0", Offset = "0x71B9CC0", VA = "0x1871BB6C0")]
	public int FEIGLLKLMKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x71BB7D0", Offset = "0x71B9DD0", VA = "0x1871BB7D0")]
	public int FEIGLLKLMKJ(byte NPLFHHNNOKH, bool FIKNOCICAAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71BD9C0", Offset = "0x71BBFC0", VA = "0x1871BD9C0")]
	private DCPFMAJCFFN NFELEPJKOJP(byte JAENDMHBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x71BE160", Offset = "0x71BC760", VA = "0x1871BE160")]
	internal DFHPBFDPENO(PMACGOELMPL JKLBGILINCL, IPEndPoint LGOHOCOFJAE, int HLIPPIOIAJK, byte IJJIODNDIKI, NELEEECPCFG IBCCEAIDLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x71BE2F0", Offset = "0x71BC8F0", VA = "0x1871BE2F0")]
	internal DFHPBFDPENO(PMACGOELMPL JKLBGILINCL, GNCALAHPPNN IPMGANOCOKF, int HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x71BAD10", Offset = "0x71B9310", VA = "0x1871BAD10")]
	internal void COGPMNCILIN(GANJBMHHMHF AFFMGCPAMIE, byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x71BCF20", Offset = "0x71BB520", VA = "0x1871BCF20")]
	internal bool MAGBMJBAGKL(NJJMGDPHKIH PIDNHILCPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x71BAC10", Offset = "0x71B9210", VA = "0x1871BAC10")]
	public void CKFDMMPHCBO(byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int PHABMFMJBEC, IMLMJHJKBHO PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x71BD2B0", Offset = "0x71BB8B0", VA = "0x1871BD2B0")]
	private void MJJFLLBAHCO(byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int PHABMFMJBEC, byte NPLFHHNNOKH, IMLMJHJKBHO BJJOGJJCHBK, object NHHCIFGFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x71BD970", Offset = "0x71BBF70", VA = "0x1871BD970")]
	public void MPKFLLBBFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x71BC410", Offset = "0x71BAA10", VA = "0x1871BC410")]
	internal APHNKKMKJBL HCNCGEEIJCM(IKELELGNOHO PIDNHILCPKF)
	{
		return default(APHNKKMKJBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71BABB0", Offset = "0x71B91B0", VA = "0x1871BABB0")]
	internal void BIPPEEAJFNL(DCPFMAJCFFN FBIPBHBBCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71BCFA0", Offset = "0x71BB5A0", VA = "0x1871BCFA0")]
	internal DJLGDIPPEOE MJEEKGHHABE(byte[] ACJFHCNBBBO, int BKJCDJJKAFA, int PHABMFMJBEC, bool KKBNDFNEENM)
	{
		return default(DJLGDIPPEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71BDF00", Offset = "0x71BC500", VA = "0x1871BDF00")]
	private void NKMGNPKGEPC(int DDKBDNGLIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x71BB930", Offset = "0x71B9F30", VA = "0x1871BB930")]
	internal void GGEBNFFKFKN(IMLMJHJKBHO PBFMFMMGIGC, IKELELGNOHO CMGKLEEINPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x71BA650", Offset = "0x71B8C50", VA = "0x1871BA650")]
	private void ANAMPDIGNIB(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x71BDB70", Offset = "0x71BC170", VA = "0x1871BDB70")]
	private void NGGLMNGLGBI(int OGJBAEEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x71BB420", Offset = "0x71B9A20", VA = "0x1871BB420")]
	internal EALIMHMGAPI DMKEABMJPCM(GANJBMHHMHF HECIAOJAGHK)
	{
		return default(EALIMHMGAPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x71BAD60", Offset = "0x71B9360", VA = "0x1871BAD60")]
	internal void DHLNBEEONFM(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x71BC2C0", Offset = "0x71BA8C0", VA = "0x1871BC2C0")]
	private void GMDJCOGLMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x71BDF40", Offset = "0x71BC540", VA = "0x1871BDF40")]
	internal void PJCLINHLLHA(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x71BC7B0", Offset = "0x71BADB0", VA = "0x1871BC7B0")]
	internal void IEMAIHNOLMJ(int OGJBAEEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x71BC4F0", Offset = "0x71BAAF0", VA = "0x1871BC4F0")]
	internal void ICADGFKBOAL(IKELELGNOHO PIDNHILCPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class NPPCLPIMHDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long OAINPGPPNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long CBPJEIHAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long KJECDDCLGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JOGNALFBDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long BIGKONPALAG;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long JIHLBCPPOLO;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long ECDHOJFFCDE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long GPPBPMIICAE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long BPAMOCMCBOK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long PLIJEBAGDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long PBAPIDFNAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long GGJJCACEDLF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BNFLNAIAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x71C90D0", Offset = "0x71C76D0", VA = "0x1871C90D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long PNNOEFJDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x71C8F40", Offset = "0x71C7540", VA = "0x1871C8F40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long OEBKILOIEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x71C8ED0", Offset = "0x71C74D0", VA = "0x1871C8ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NPKBHOEBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x71C90C0", Offset = "0x71C76C0", VA = "0x1871C90C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long GEIHLAMIKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x71C8EC0", Offset = "0x71C74C0", VA = "0x1871C8EC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long NKBMOIJINJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x71C9180", Offset = "0x71C7780", VA = "0x1871C9180")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long BMLCCFBLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x71C9140", Offset = "0x71C7740", VA = "0x1871C9140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long EMOLGGCJKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x71C8FD0", Offset = "0x71C75D0", VA = "0x1871C8FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private PPGEOGCJEGJ DCBHFPHJGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double JLPNPBECNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x71C90E0", Offset = "0x71C76E0", VA = "0x1871C90E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x71C9010", Offset = "0x71C7610", VA = "0x1871C9010")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x71C8EE0", Offset = "0x71C74E0", VA = "0x1871C8EE0")]
	public void GGMLKNPAAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x71C8D60", Offset = "0x71C7360", VA = "0x1871C8D60")]
	public void BLEFAMLCPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x71C9050", Offset = "0x71C7650", VA = "0x1871C9050")]
	public void MLHPDIFCDCI(long BDJNJHDIHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x71C8E50", Offset = "0x71C7450", VA = "0x1871C8E50")]
	public void FJDONDGGGEG(long IOOFHAOJFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x71C8D00", Offset = "0x71C7300", VA = "0x1871C8D00")]
	public void AJOMIBFFJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x71C8F50", Offset = "0x71C7550", VA = "0x1871C8F50")]
	public void JIKJPMNNJGM(long DKJHKBBCBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x71C9190", Offset = "0x71C7790", VA = "0x1871C9190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71C8DB0", Offset = "0x71C73B0", VA = "0x1871C8DB0")]
	public void EMLBDAKPDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NPPCLPIMHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MGCKENAMHJE
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> ELAJPMLKBEE;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71C61D0", Offset = "0x71C47D0", VA = "0x1871C61D0")]
	public static IPEndPoint GLEOCJGMFFB(string KOBNJLJKAJB, int LMJGOBCMGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x71C6420", Offset = "0x71C4A20", VA = "0x1871C6420")]
	public static IPAddress NBOKKCDOLBA(string KOBNJLJKAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x71C65F0", Offset = "0x71C4BF0", VA = "0x1871C65F0")]
	public static IPAddress NBOKKCDOLBA(string KOBNJLJKAJB, AddressFamily KGPNHDGJPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x71C61A0", Offset = "0x71C47A0", VA = "0x1871C61A0")]
	internal static int EBMGKCBDJHP(int PCAHEALIIOG, int DAJHIGHJODM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C12A00", Offset = "0x3C11000", VA = "0x183C12A00")]
	internal static T[] FHALEAJKJKM<T>(int FOAMCIPOLAA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HEBJBANIDGO : DCPFMAJCFFN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct AJJBHPPNEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IKELELGNOHO CINEHJIGHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long DPECDPMEJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool LJLJAKEPAKP;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x71B9EF0", Offset = "0x71B84F0", VA = "0x1871B9EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x71B9ED0", Offset = "0x71B84D0", VA = "0x1871B9ED0")]
		public void PNLBMDNIIGG(IKELELGNOHO PIDNHILCPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x71B9E10", Offset = "0x71B8410", VA = "0x1871B9E10")]
		public bool BENHBAGKPLP(long IFOFMMNOBPH, DFHPBFDPENO IKAPODCCKHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x71B9E80", Offset = "0x71B8480", VA = "0x1871B9E80")]
		public bool HHCEOPNNHLH(DFHPBFDPENO IKAPODCCKHJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly IKELELGNOHO PADFBDMPNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly AJJBHPPNEIH[] HNKHJHCDHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly IKELELGNOHO[] FIBPBLGNDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] FFIKPCGFNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int DPJDAPLCCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int BHMNOLBKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int HFCLEKEKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int GDIEPFBFLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool HCHGIMDMNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly IMLMJHJKBHO PELDPLAAMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool KHKPIPKEPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int NKMBDECLKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte AJDGNFGNEBA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LOBIKLOMBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x71C0510", Offset = "0x71BEB10", VA = "0x1871C0510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x71C1410", Offset = "0x71BFA10", VA = "0x1871C1410")]
	public HEBJBANIDGO(DFHPBFDPENO IKAPODCCKHJ, bool FIKNOCICAAA, byte HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x71C0B80", Offset = "0x71BF180", VA = "0x1871C0B80")]
	private void LEEKAELJPLC(IKELELGNOHO PIDNHILCPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x71C0F40", Offset = "0x71BF540", VA = "0x1871C0F40", Slot = "4")]
	protected override bool OOGAPMFGHGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x71C0520", Offset = "0x71BEB20", VA = "0x1871C0520", Slot = "5")]
	public override bool DHLNBEEONFM(IKELELGNOHO PIDNHILCPKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MIECBCFCAEP : DCPFMAJCFFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int BHIPCEGDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort BHMNOLBKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool AKALAAPNNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private IKELELGNOHO JCECLDJDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly IKELELGNOHO IKLNOADMFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool CGELILBNJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte AJDGNFGNEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long AACCIAJHBBD;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x71C6EB0", Offset = "0x71C54B0", VA = "0x1871C6EB0")]
	public MIECBCFCAEP(DFHPBFDPENO IKAPODCCKHJ, bool BLPMPIBJKLP, byte HLIPPIOIAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x71C69F0", Offset = "0x71C4FF0", VA = "0x1871C69F0", Slot = "4")]
	protected override bool OOGAPMFGHGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x71C6710", Offset = "0x71C4D10", VA = "0x1871C6710", Slot = "5")]
	public override bool DHLNBEEONFM(IKELELGNOHO PIDNHILCPKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DKMGDCCGMEM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OFOMLIDKIPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong INEOJOBEEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double FLPDIHGICAF;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct BMMHCNFLLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int AMLFPEKNIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float BPEBIIJGKAA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x71B97D0", Offset = "0x71B7DD0", VA = "0x1871B97D0")]
	private static void NAPOMDLIOKI(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, ulong ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x71BE9A0", Offset = "0x71BCFA0", VA = "0x1871BE9A0")]
	private static void NAPOMDLIOKI(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, int ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x71BE930", Offset = "0x71BCF30", VA = "0x1871BE930")]
	public static void NAPOMDLIOKI(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, short ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x71BE980", Offset = "0x71BCF80", VA = "0x1871BE980")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, double KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x71BEA10", Offset = "0x71BD010", VA = "0x1871BEA10")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x71BE930", Offset = "0x71BCF30", VA = "0x1871BE930")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, short KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x71BE930", Offset = "0x71BCF30", VA = "0x1871BE930")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, ushort KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x71BE9A0", Offset = "0x71BCFA0", VA = "0x1871BE9A0")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x71BE9A0", Offset = "0x71BCFA0", VA = "0x1871BE9A0")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, uint KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x71BE970", Offset = "0x71BCF70", VA = "0x1871BE970")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x71BE970", Offset = "0x71BCF70", VA = "0x1871BE970")]
	public static void ILHJENAMLIF(byte[] IHNKIKDOAOB, int IGHNHCKLCCN, ulong KKGBKLFKCPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IPGCCOEBOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] ACKBIKMHOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int EEKHCPACJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int EMMMPLILDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int LJIHCNFOHMI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] PHFLJEAEBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LJNCEMFLEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DCDMBANMNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x71C2720", Offset = "0x71C0D20", VA = "0x1871C2720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KIOJGDFKOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x285A470", Offset = "0x2858A70", VA = "0x18285A470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FBHALKNDJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x71C2EA0", Offset = "0x71C14A0", VA = "0x1871C2EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x71C2FA0", Offset = "0x71C15A0", VA = "0x1871C2FA0")]
	public void MLPGHPKOPHJ(byte[] INCFEGIJJJL, int MOBKDJHFHDL, int EKEEDNKENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IPGCCOEBOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x71C3210", Offset = "0x71C1810", VA = "0x1871C3210")]
	public IPGCCOEBOLB(byte[] INCFEGIJJJL, int MOBKDJHFHDL, int EKEEDNKENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x71C3090", Offset = "0x71C1690", VA = "0x1871C3090")]
	public IPEndPoint OJFPLJGFHBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x71C2AA0", Offset = "0x71C10A0", VA = "0x1871C2AA0")]
	public byte GNNEMNPPMBN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x71C2AA0", Offset = "0x71C10A0", VA = "0x1871C2AA0")]
	public sbyte JCJODPLIAGE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3B85EE0", Offset = "0x3B844E0", VA = "0x183B85EE0")]
	public T[] CPDNNJAOHAB<T>(ushort GPNBMIDFKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x71C2670", Offset = "0x71C0C70", VA = "0x1871C2670")]
	public bool[] BEFGGAAJBBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x71C27E0", Offset = "0x71C0DE0", VA = "0x1871C27E0")]
	public ushort[] ENLPLJAKKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x71C2820", Offset = "0x71C0E20", VA = "0x1871C2820")]
	public short[] FHAAOMBIMNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x71C3050", Offset = "0x71C1650", VA = "0x1871C3050")]
	public int[] ODJFFPFHEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x71C2AE0", Offset = "0x71C10E0", VA = "0x1871C2AE0")]
	public uint[] HCPOAEAOPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x71C3160", Offset = "0x71C1760", VA = "0x1871C3160")]
	public float[] OKIBMPLKLEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x71C2BB0", Offset = "0x71C11B0", VA = "0x1871C2BB0")]
	public double[] HNDMBLJKNHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x71C28A0", Offset = "0x71C0EA0", VA = "0x1871C28A0")]
	public long[] FPNDHPEBCGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x71C2EB0", Offset = "0x71C14B0", VA = "0x1871C2EB0")]
	public ulong[] LDJBCPIDKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x71C2950", Offset = "0x71C0F50", VA = "0x1871C2950")]
	public string[] GKGNJJJMOEG(int EPBBNMMDAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x71C2EF0", Offset = "0x71C14F0", VA = "0x1871C2EF0")]
	public bool LFGBDKDJGDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x71C2F30", Offset = "0x71C1530", VA = "0x1871C2F30")]
	public char LILEFHALMJP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x71C2F30", Offset = "0x71C1530", VA = "0x1871C2F30")]
	public ushort NAMMPJEIHBJ()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x71C2B40", Offset = "0x71C1140", VA = "0x1871C2B40")]
	public short HHDINLFCMJB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x71C2600", Offset = "0x71C0C00", VA = "0x1871C2600")]
	public long BBAIDKGOOGA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x71C2BF0", Offset = "0x71C11F0", VA = "0x1871C2BF0")]
	public ulong HPFHADOENHL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x71C31A0", Offset = "0x71C17A0", VA = "0x1871C31A0")]
	public int PLDLILDNDAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x71C26B0", Offset = "0x71C0CB0", VA = "0x1871C26B0")]
	public uint BPCIMMILCDI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x71C2770", Offset = "0x71C0D70", VA = "0x1871C2770")]
	public float ELJMFNPPGMA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x71C2FE0", Offset = "0x71C15E0", VA = "0x1871C2FE0")]
	public double NLJFKJEFJDE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x71C2C60", Offset = "0x71C1260", VA = "0x1871C2C60")]
	public string IEOBNAPBHHA(int HLHNCCLDLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x71C28E0", Offset = "0x71C0EE0", VA = "0x1871C28E0")]
	public ArraySegment<byte> GFNFBINLLNK(int FOAMCIPOLAA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x71C2730", Offset = "0x71C0D30", VA = "0x1871C2730")]
	public sbyte[] EDNKDBAFIHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x71C2860", Offset = "0x71C0E60", VA = "0x1871C2860")]
	public byte[] FIOFKJOJFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x71C2B20", Offset = "0x71C1120", VA = "0x1871C2B20")]
	public void HHCEOPNNHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NELEEECPCFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] ACKBIKMHOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int EEKHCPACJOC;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int HKCGMKALFMD = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool ENEFHJBLIJD;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding JKHFJIFOBAB;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int NKCEFIALBCE = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] MMEKMLJBKFH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] IKFGCCPLOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x71C88E0", Offset = "0x71C6EE0", VA = "0x1871C88E0")]
	public NELEEECPCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x71C8840", Offset = "0x71C6E40", VA = "0x1871C8840")]
	public NELEEECPCFG(bool IILLANHLODG, int LCFKPCLCBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x71C8250", Offset = "0x71C6850", VA = "0x1871C8250")]
	public static NELEEECPCFG ILNEICOLLHJ(string KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x71C8710", Offset = "0x71C6D10", VA = "0x1871C8710")]
	public void LIKODKLEKMO(int AOAPAPHIJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x28D3CA0", Offset = "0x28D22A0", VA = "0x1828D3CA0")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x71C8150", Offset = "0x71C6750", VA = "0x1871C8150")]
	public void IBACKDMNHGE(float KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71C7E30", Offset = "0x71C6430", VA = "0x1871C7E30")]
	public void IBACKDMNHGE(double KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x71C7E80", Offset = "0x71C6480", VA = "0x1871C7E80")]
	public void IBACKDMNHGE(long KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x71C7E80", Offset = "0x71C6480", VA = "0x1871C7E80")]
	public void IBACKDMNHGE(ulong KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x71C7BF0", Offset = "0x71C61F0", VA = "0x1871C7BF0")]
	public void IBACKDMNHGE(int KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71C7BF0", Offset = "0x71C61F0", VA = "0x1871C7BF0")]
	public void IBACKDMNHGE(uint KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71C7D50", Offset = "0x71C6350", VA = "0x1871C7D50")]
	public void IBACKDMNHGE(char KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71C7D50", Offset = "0x71C6350", VA = "0x1871C7D50")]
	public void IBACKDMNHGE(ushort KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x71C7D50", Offset = "0x71C6350", VA = "0x1871C7D50")]
	public void IBACKDMNHGE(short KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x71C7DD0", Offset = "0x71C63D0", VA = "0x1871C7DD0")]
	public void IBACKDMNHGE(sbyte KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x71C7DD0", Offset = "0x71C63D0", VA = "0x1871C7DD0")]
	public void IBACKDMNHGE(byte KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x71C80E0", Offset = "0x71C66E0", VA = "0x1871C80E0")]
	public void IBACKDMNHGE(byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x71C7B10", Offset = "0x71C6110", VA = "0x1871C7B10")]
	public void MCHACKBJJOC(sbyte[] ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x71C7B10", Offset = "0x71C6110", VA = "0x1871C7B10")]
	public void FHBNAPNHPJH(byte[] ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x71C81F0", Offset = "0x71C67F0", VA = "0x1871C81F0")]
	public void IBACKDMNHGE(bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x71C82C0", Offset = "0x71C68C0", VA = "0x1871C82C0")]
	public void LFIFAAHJBFN(Array BNCKDHIBPEL, int NLDHFNKHPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71C8560", Offset = "0x71C6B60", VA = "0x1871C8560")]
	public void LFIFAAHJBFN(float[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x71C8480", Offset = "0x71C6A80", VA = "0x1871C8480")]
	public void LFIFAAHJBFN(double[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x71C8480", Offset = "0x71C6A80", VA = "0x1871C8480")]
	public void LFIFAAHJBFN(long[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x71C8480", Offset = "0x71C6A80", VA = "0x1871C8480")]
	public void LFIFAAHJBFN(ulong[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x71C8560", Offset = "0x71C6B60", VA = "0x1871C8560")]
	public void LFIFAAHJBFN(int[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x71C8560", Offset = "0x71C6B60", VA = "0x1871C8560")]
	public void LFIFAAHJBFN(uint[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x71C83A0", Offset = "0x71C69A0", VA = "0x1871C83A0")]
	public void LFIFAAHJBFN(ushort[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x71C83A0", Offset = "0x71C69A0", VA = "0x1871C83A0")]
	public void LFIFAAHJBFN(short[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x71C7B10", Offset = "0x71C6110", VA = "0x1871C7B10")]
	public void LFIFAAHJBFN(bool[] KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71C8640", Offset = "0x71C6C40", VA = "0x1871C8640")]
	public void LFIFAAHJBFN(string[] KKGBKLFKCPO, int BLNLEAHOOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x71C7C80", Offset = "0x71C6280", VA = "0x1871C7C80")]
	public void IBACKDMNHGE(IPEndPoint DOEPIOCFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x71C7DC0", Offset = "0x71C63C0", VA = "0x1871C7DC0")]
	public void IBACKDMNHGE(string KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x71C7ED0", Offset = "0x71C64D0", VA = "0x1871C7ED0")]
	public void IBACKDMNHGE(string KKGBKLFKCPO, int HLHNCCLDLKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JPNDDJCKEHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class PDCBGPHHJFH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong NJJOPPIMCLB;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x58B2110", Offset = "0x58B0710", VA = "0x1858B2110")]
		static PDCBGPHHJFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void BIHNJGFFABJ(IPGCCOEBOLB KMBIKKJCMFN, object NHHCIFGFJME);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EKBKJGGLDPK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public JPNDDJCKEHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EKBKJGGLDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x478E250", Offset = "0x478C850", VA = "0x18478E250")]
		internal void NGNGCADOOHE(IPGCCOEBOLB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GJGFGFOBHFB<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public JPNDDJCKEHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GJGFGFOBHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4D611A0", Offset = "0x4D5F7A0", VA = "0x184D611A0")]
		internal void NGNGCADOOHE(IPGCCOEBOLB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly EBPBGHKCGNL ECFKNCPNIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, BIHNJGFFABJ> GOPMCOMOLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly NELEEECPCFG KLCPBFMHHDI;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x71C3470", Offset = "0x71C1A70", VA = "0x1871C3470")]
	public JPNDDJCKEHJ(int EPBBNMMDAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x30B49D0", Offset = "0x30B2FD0", VA = "0x1830B49D0", Slot = "4")]
	protected virtual ulong ECHILGPGPHJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x71C3340", Offset = "0x71C1940", VA = "0x1871C3340", Slot = "5")]
	protected virtual BIHNJGFFABJ GAHLGODGBMM(IPGCCOEBOLB KMBIKKJCMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5560", Offset = "0x3BA3B60", VA = "0x183BA5560", Slot = "6")]
	protected virtual void JFBPOBIIHCI<T>(NELEEECPCFG DCGAFNKBAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x71C32C0", Offset = "0x71C18C0", VA = "0x1871C32C0")]
	public void DKKBJHALDFC(IPGCCOEBOLB KMBIKKJCMFN, object NHHCIFGFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3BA54D0", Offset = "0x3BA3AD0", VA = "0x183BA54D0")]
	public void JEEPEEKFONJ<T>(NELEEECPCFG DCGAFNKBAGF, T PIDNHILCPKF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x71C3270", Offset = "0x71C1870", VA = "0x1871C3270")]
	public void CBIHONCLAPM(IPGCCOEBOLB KMBIKKJCMFN, object NHHCIFGFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5750", Offset = "0x3BA3D50", VA = "0x183BA5750")]
	public void OIHPNPNPJEL<T>(Action<T> DBHCEAKBBAL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3BA55D0", Offset = "0x3BA3BD0", VA = "0x183BA55D0")]
	public void OIHPNPNPJEL<T, TUserData>(Action<T, TUserData> DBHCEAKBBAL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HHMIHOIOMAH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x71C15E0", Offset = "0x71BFBE0", VA = "0x1871C15E0")]
	public HHMIHOIOMAH(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class AFJOPDDJKEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x71B9DB0", Offset = "0x71B83B0", VA = "0x1871B9DB0")]
	public AFJOPDDJKEA(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EBPBGHKCGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum JJJKFJNBMOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class HGNALFGOGHJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public JJJKFJNBMOP AKEHBOGGIOP;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4DF4220", Offset = "0x4DF2820", VA = "0x184DF4220", Slot = "4")]
		public virtual void PNLBMDNIIGG(MethodInfo BHJHBIJLDIE, MethodInfo IOGHHCACAAP, JJJKFJNBMOP JLPANLJHHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LMEJAAGPJAF(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FMAAAAKKLIJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		protected HGNALFGOGHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class PNLCEPBMMMN<TClass, TProperty> : HGNALFGOGHJ<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> MFJIBPCHCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> FJDIDMJAEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> ENHJKNGADHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> OECEMCDBCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> GOCDJAHFBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> NJLNHJHBECM;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58F9680", Offset = "0x58F7C80", VA = "0x1858F9680", Slot = "7")]
		public override void NHEGCCENOEI(TClass AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x58F7690", Offset = "0x58F5C90", VA = "0x1858F7690", Slot = "8")]
		public override void GGDKMIIHCOO(TClass AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x58F8CE0", Offset = "0x58F72E0", VA = "0x1858F8CE0", Slot = "9")]
		public override void LMEJAAGPJAF(TClass AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x58F7310", Offset = "0x58F5910", VA = "0x1858F7310", Slot = "10")]
		public override void FMAAAAKKLIJ(TClass AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x58F6A30", Offset = "0x58F5030", VA = "0x1858F6A30")]
		protected TProperty[] CDMDDCJELFB(TClass AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x58F81F0", Offset = "0x58F67F0", VA = "0x1858F81F0")]
		protected TProperty[] JIAPCINCEOE(TClass AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x58FBBA0", Offset = "0x58FA1A0", VA = "0x1858FBBA0", Slot = "4")]
		public override void PNLBMDNIIGG(MethodInfo BHJHBIJLDIE, MethodInfo IOGHHCACAAP, JJJKFJNBMOP JLPANLJHHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x58FE3E0", Offset = "0x58FC9E0", VA = "0x1858FE3E0")]
		protected PNLCEPBMMMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class JLGJBJFEBEJ<TClass, TProperty> : PNLCEPBMMMN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CGOHDPHEFII(IPGCCOEBOLB GBHEJJJMLLO, [Out] TProperty GFPKJDONICH);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void CBALJIFPFNN(NELEEECPCFG DOHMFBHGBFB, TProperty GFPKJDONICH);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51DBE60", Offset = "0x51DA460", VA = "0x1851DBE60", Slot = "5")]
		public override void CLPAOECJHKG(TClass AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51DC0A0", Offset = "0x51DA6A0", VA = "0x1851DC0A0", Slot = "6")]
		public override void JEEPEEKFONJ(TClass AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x51DC220", Offset = "0x51DA820", VA = "0x1851DC220", Slot = "7")]
		public override void NHEGCCENOEI(TClass AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x51DC000", Offset = "0x51DA600", VA = "0x1851DC000", Slot = "8")]
		public override void GGDKMIIHCOO(TClass AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4BF2250", Offset = "0x4BF0850", VA = "0x184BF2250")]
		protected JLGJBJFEBEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class CICAIFJOPIL<T> : PNLCEPBMMMN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x67A7840", Offset = "0x67A5E40", VA = "0x1867A7840", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6151B30", Offset = "0x6150130", VA = "0x186151B30", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x67A78B0", Offset = "0x67A5EB0", VA = "0x1867A78B0", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6151AD0", Offset = "0x61500D0", VA = "0x186151AD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public CICAIFJOPIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BFHFLIBGJAP<T> : PNLCEPBMMMN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6151A60", Offset = "0x6150060", VA = "0x186151A60", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6151B30", Offset = "0x6150130", VA = "0x186151B30", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6151B90", Offset = "0x6150190", VA = "0x186151B90", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6151AD0", Offset = "0x61500D0", VA = "0x186151AD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public BFHFLIBGJAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MBONBAAKEKE<T> : PNLCEPBMMMN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x55FE710", Offset = "0x55FCD10", VA = "0x1855FE710", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x55FE7E0", Offset = "0x55FCDE0", VA = "0x1855FE7E0", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x55FE840", Offset = "0x55FCE40", VA = "0x1855FE840", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x55FE780", Offset = "0x55FCD80", VA = "0x1855FE780", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public MBONBAAKEKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DCJANHGJAPA<T> : PNLCEPBMMMN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC120", Offset = "0x6CBA720", VA = "0x186CBC120", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x55FE7E0", Offset = "0x55FCDE0", VA = "0x1855FE7E0", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC190", Offset = "0x6CBA790", VA = "0x186CBC190", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x55FE780", Offset = "0x55FCD80", VA = "0x1855FE780", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public DCJANHGJAPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NMCFJHFDDNC<T> : PNLCEPBMMMN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x569EDE0", Offset = "0x569D3E0", VA = "0x18569EDE0", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E27E30", Offset = "0x4E26430", VA = "0x184E27E30", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x569EE50", Offset = "0x569D450", VA = "0x18569EE50", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E27DD0", Offset = "0x4E263D0", VA = "0x184E27DD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public NMCFJHFDDNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class HOFAMEHJCMB<T> : PNLCEPBMMMN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E27D60", Offset = "0x4E26360", VA = "0x184E27D60", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E27E30", Offset = "0x4E26430", VA = "0x184E27E30", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E27E90", Offset = "0x4E26490", VA = "0x184E27E90", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E27DD0", Offset = "0x4E263D0", VA = "0x184E27DD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public HOFAMEHJCMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class DIBMHIEAIFF<T> : PNLCEPBMMMN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E69B70", Offset = "0x4E68170", VA = "0x184E69B70", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E69C40", Offset = "0x4E68240", VA = "0x184E69C40", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CDCB00", Offset = "0x6CDB100", VA = "0x186CDCB00", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E69BE0", Offset = "0x4E681E0", VA = "0x184E69BE0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public DIBMHIEAIFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AIAMOAMKEFJ<T> : PNLCEPBMMMN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E69B70", Offset = "0x4E68170", VA = "0x184E69B70", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E69C40", Offset = "0x4E68240", VA = "0x184E69C40", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E69CA0", Offset = "0x4E682A0", VA = "0x184E69CA0", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E69BE0", Offset = "0x4E681E0", VA = "0x184E69BE0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public AIAMOAMKEFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DKBCFMJLKPM<T> : PNLCEPBMMMN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D15A50", Offset = "0x6D14050", VA = "0x186D15A50", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D15AC0", Offset = "0x6D140C0", VA = "0x186D15AC0", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D15B20", Offset = "0x6D14120", VA = "0x186D15B20", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6151AD0", Offset = "0x61500D0", VA = "0x186151AD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public DKBCFMJLKPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PGNENHFPCLP<T> : PNLCEPBMMMN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x58DA900", Offset = "0x58D8F00", VA = "0x1858DA900", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x58DA970", Offset = "0x58D8F70", VA = "0x1858DA970", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x58DA9D0", Offset = "0x58D8FD0", VA = "0x1858DA9D0", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E27DD0", Offset = "0x4E263D0", VA = "0x184E27DD0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public PGNENHFPCLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KNDDIBINOIK<T> : PNLCEPBMMMN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x52E1320", Offset = "0x52DF920", VA = "0x1852E1320", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x52E1390", Offset = "0x52DF990", VA = "0x1852E1390", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x52E13F0", Offset = "0x52DF9F0", VA = "0x1852E13F0", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4E69BE0", Offset = "0x4E681E0", VA = "0x184E69BE0", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
		public KNDDIBINOIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class FFDAEELNHHD<T> : JLGJBJFEBEJ<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C038E0", Offset = "0x4C01EE0", VA = "0x184C038E0", Slot = "12")]
		protected override void CBALJIFPFNN(NELEEECPCFG DOHMFBHGBFB, char GFPKJDONICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4C03910", Offset = "0x4C01F10", VA = "0x184C03910", Slot = "11")]
		protected override void CGOHDPHEFII(IPGCCOEBOLB GBHEJJJMLLO, [Out] char GFPKJDONICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
		public FFDAEELNHHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FKCNMAHGCKK<T> : JLGJBJFEBEJ<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4C52530", Offset = "0x4C50B30", VA = "0x184C52530", Slot = "12")]
		protected override void CBALJIFPFNN(NELEEECPCFG DOHMFBHGBFB, IPEndPoint GFPKJDONICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4C52560", Offset = "0x4C50B60", VA = "0x184C52560", Slot = "11")]
		protected override void CGOHDPHEFII(IPGCCOEBOLB GBHEJJJMLLO, [Out] IPEndPoint GFPKJDONICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
		public FKCNMAHGCKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class AGCDJLEBNEA<T> : PNLCEPBMMMN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int BGJOCPILGOM;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E68550", Offset = "0x4E66B50", VA = "0x184E68550")]
		public AGCDJLEBNEA(int HLHNCCLDLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E68390", Offset = "0x4E66990", VA = "0x184E68390", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E68470", Offset = "0x4E66A70", VA = "0x184E68470", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E684E0", Offset = "0x4E66AE0", VA = "0x184E684E0", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E68400", Offset = "0x4E66A00", VA = "0x184E68400", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DJBEPNLKLBM<T> : HGNALFGOGHJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo LPNDDFLMCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type AKMEOHBEJKA;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D130E0", Offset = "0x6D116E0", VA = "0x186D130E0")]
		public DJBEPNLKLBM(PropertyInfo PJAMOIBNMIO, Type MINJJHHFPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D12DF0", Offset = "0x6D113F0", VA = "0x186D12DF0", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D12F70", Offset = "0x6D11570", VA = "0x186D12F70", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D13080", Offset = "0x6D11680", VA = "0x186D13080", Slot = "7")]
		public override void NHEGCCENOEI(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D12F10", Offset = "0x6D11510", VA = "0x186D12F10", Slot = "8")]
		public override void GGDKMIIHCOO(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D13020", Offset = "0x6D11620", VA = "0x186D13020", Slot = "9")]
		public override void LMEJAAGPJAF(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D12EB0", Offset = "0x6D114B0", VA = "0x186D12EB0", Slot = "10")]
		public override void FMAAAAKKLIJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class MPFIENDFOEK<T> : DJBEPNLKLBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
		public MPFIENDFOEK(PropertyInfo PJAMOIBNMIO, Type MINJJHHFPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x561E080", Offset = "0x561C680", VA = "0x18561E080", Slot = "5")]
		public override void CLPAOECJHKG(T AONBJJGKKLK, IPGCCOEBOLB GBHEJJJMLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x561E140", Offset = "0x561C740", VA = "0x18561E140", Slot = "6")]
		public override void JEEPEEKFONJ(T AONBJJGKKLK, NELEEECPCFG DOHMFBHGBFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class IJAJGKCMLGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static IJAJGKCMLGD<T> FNIBPMLJKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly HGNALFGOGHJ<T>[] MCJBABOADEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int DHDCFNGPJKM;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4F68AB0", Offset = "0x4F670B0", VA = "0x184F68AB0")]
		public IJAJGKCMLGD(List<HGNALFGOGHJ<T>> JAEDMLKOCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4F68A00", Offset = "0x4F67000", VA = "0x184F68A00")]
		public void JEEPEEKFONJ(T ODCICEDDLMB, NELEEECPCFG DCGAFNKBAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F68950", Offset = "0x4F66F50", VA = "0x184F68950")]
		public void CLPAOECJHKG(T ODCICEDDLMB, IPGCCOEBOLB KMBIKKJCMFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class KEDFDPBHCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HGNALFGOGHJ<T> KBGIPADPFGF<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private NELEEECPCFG AMIIICBBCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int HEDCFFHBAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, KEDFDPBHCKE> KFHJKJDIIKG;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x71BEB30", Offset = "0x71BD130", VA = "0x1871BEB30")]
	public EBPBGHKCGNL(int EPBBNMMDAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x39B92F0", Offset = "0x39B78F0", VA = "0x1839B92F0")]
	private IJAJGKCMLGD<T> HIOALCIGOOG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x38CF8C0", Offset = "0x38CDEC0", VA = "0x1838CF8C0")]
	public void CCHHFLKMKEK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x39B9270", Offset = "0x39B7870", VA = "0x1839B9270")]
	public bool FJJOMODMCLM<T>(IPGCCOEBOLB KMBIKKJCMFN, T OKOGHNMMGGB) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x39BA1E0", Offset = "0x39B87E0", VA = "0x1839BA1E0")]
	public void LGGJGPOGIBH<T>(NELEEECPCFG DCGAFNKBAGF, T ODCICEDDLMB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LGAFHJOBFBC
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime APLLBOBOKPP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] CJCOMMBGCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BJIABAKFECA CNEDFKPJNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x71C35F0", Offset = "0x71C1BF0", VA = "0x1871C35F0")]
		get
		{
			return default(BJIABAKFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ICBHIBMEHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x71C3B90", Offset = "0x71C2190", VA = "0x1871C3B90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x71C38F0", Offset = "0x71C1EF0", VA = "0x1871C38F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GJPOOPHFAIM IMPLNDBOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x71C3BC0", Offset = "0x71C21C0", VA = "0x1871C3BC0")]
		get
		{
			return default(GJPOOPHFAIM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x71C4400", Offset = "0x71C2A00", VA = "0x1871C4400")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int EGEOEKOLEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x71C3FF0", Offset = "0x71C25F0", VA = "0x1871C3FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint KAHKLINFHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x71C3D70", Offset = "0x71C2370", VA = "0x1871C3D70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? ECIDNKNNONH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x71C3620", Offset = "0x71C1C20", VA = "0x1871C3620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? KGCEIKCHLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x71C43D0", Offset = "0x71C29D0", VA = "0x1871C43D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? BGMLDJHACGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x71C3D40", Offset = "0x71C2340", VA = "0x1871C3D40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x71C4200", Offset = "0x71C2800", VA = "0x1871C4200")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? KHAAPAEFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x71C4670", Offset = "0x71C2C70", VA = "0x1871C4670")]
	public LGAFHJOBFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x71C45C0", Offset = "0x71C2BC0", VA = "0x1871C45C0")]
	internal LGAFHJOBFBC(byte[] IHNKIKDOAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x71C4440", Offset = "0x71C2A40", VA = "0x1871C4440")]
	public static LGAFHJOBFBC PNNDDGFNMHL(byte[] IHNKIKDOAOB, DateTime BPINPAHPHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x71C3DF0", Offset = "0x71C23F0", VA = "0x1871C3DF0")]
	internal void MGMNMFKKAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x71C4020", Offset = "0x71C2620", VA = "0x1871C4020")]
	private void NGDDOBGEOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x71C3990", Offset = "0x71C1F90", VA = "0x1871C3990")]
	private DateTime? GPOLFADAKOL(int MOBKDJHFHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x71C3720", Offset = "0x71C1D20", VA = "0x1871C3720")]
	private void GGFJOCMFGKA(int MOBKDJHFHDL, DateTime? KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x71C3650", Offset = "0x71C1C50", VA = "0x1871C3650")]
	private ulong BNMEIPOAOMP(int MOBKDJHFHDL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x71C3C80", Offset = "0x71C2280", VA = "0x1871C3C80")]
	private void KEGPAKNNMDH(int MOBKDJHFHDL, ulong KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x71C3BF0", Offset = "0x71C21F0", VA = "0x1871C3BF0")]
	private uint JINADODNOPA(int MOBKDJHFHDL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x70853C0", Offset = "0x70839C0", VA = "0x1870853C0")]
	private static uint GMIPHKJONPH(uint POMHCCBBBGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x71C3930", Offset = "0x71C1F30", VA = "0x1871C3930")]
	private static ulong GMIPHKJONPH(ulong POMHCCBBBGD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BJIABAKFECA
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
public enum GJPOOPHFAIM
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class PDOFCNJNKAP
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int EHGHKHODJEJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int LKDGALEMNNP = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int LKNKCHDDJCL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint DJOLDLKLFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int NBJCIMJMCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int LKHBMCDBKJD;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GGCANOBGBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x71C9DE0", Offset = "0x71C83E0", VA = "0x1871C9DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x71C9CF0", Offset = "0x71C82F0", VA = "0x1871C9CF0")]
	public bool CKFDMMPHCBO(JBBHAGIDBCB GLACGOPPINA, int PHDJLKIIBIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class OEBHAGICLLM : JBBHAGIDBCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket GLACGOPPINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly PMACGOELMPL JKLBGILINCL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short OOAFNABDOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x71C9AB0", Offset = "0x71C80B0", VA = "0x1871C9AB0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LJEPKNFFGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x71C9A90", Offset = "0x71C8090", VA = "0x1871C9A90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint APHIJAJJBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x71C9C20", Offset = "0x71C8220", VA = "0x1871C9C20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily LBMCCIKMGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5365C20", Offset = "0x5364220", VA = "0x185365C20", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x71C9C40", Offset = "0x71C8240", VA = "0x1871C9C40")]
	public OEBHAGICLLM(AddressFamily KGPNHDGJPJM, PMACGOELMPL JKLBGILINCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x71C94D0", Offset = "0x71C7AD0", VA = "0x1871C94D0", Slot = "8")]
	public bool ADPDNJEODFC(IPEndPoint DOEPIOCFAJN, DCJMLEABKIE PFICHBGCLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x71C9BE0", Offset = "0x71C81E0", VA = "0x1871C9BE0", Slot = "9")]
	public int LLLGENJGLBK(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, int GPNBMIDFKMK, IPEndPoint LGOHOCOFJAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x71C9AF0", Offset = "0x71C80F0", VA = "0x1871C9AF0", Slot = "10")]
	public int JDHJEIACFOB(byte[] LBNJMEGEAHB, EndPoint JJMLMFHCDGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x71C9AD0", Offset = "0x71C80D0", VA = "0x1871C9AD0", Slot = "11")]
	public void IGPBFLLIGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface JBBHAGIDBCB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short OOAFNABDOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int LJEPKNFFGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint APHIJAJJBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily LBMCCIKMGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ADPDNJEODFC(IPEndPoint DOEPIOCFAJN, DCJMLEABKIE PFICHBGCLLI);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LLLGENJGLBK(byte[] LBNJMEGEAHB, int MOBKDJHFHDL, int GPNBMIDFKMK, IPEndPoint LGOHOCOFJAE);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JDHJEIACFOB(byte[] LBNJMEGEAHB, EndPoint LGOHOCOFJAE);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGPBFLLIGOC();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct HJFCLKNIBIB : IEquatable<HJFCLKNIBIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long KGENIEGCKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long OIEFPNANEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long LJBMBJIJDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int BHAMMLDODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int CNMGOGIJFHB;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x71C16E0", Offset = "0x71BFCE0", VA = "0x1871C16E0")]
	public HJFCLKNIBIB(byte[] GFKHACLJBMJ, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x71C17A0", Offset = "0x71BFDA0", VA = "0x1871C17A0")]
	public HJFCLKNIBIB(Span<byte> GFKHACLJBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x71C16A0", Offset = "0x71BFCA0", VA = "0x1871C16A0", Slot = "4")]
	public bool Equals(HJFCLKNIBIB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x71C15F0", Offset = "0x71BFBF0", VA = "0x1871C15F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class MMOLGFOGBIC : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] LBEFFAJPGCG;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EBALMMNEJNA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void FINGKMKHFEC(IPEndPoint GFKHACLJBMJ, Span<byte> ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string BKKKDLIMECP = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int FLIGLMMNCOJ = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int LDOKKNMPFKL = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int PGJDFFHOKKO = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<HJFCLKNIBIB, IPEndPoint> NLBJDEKEGHA;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static FINGKMKHFEC GDNKCCMPOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int GLIHBMFCABC;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	internal void MBHCNFPMHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	internal void DNHBPADEGDO(IPEndPoint LGOHOCOFJAE, Span<byte> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class MJCGHCHLIBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int PLFEOBLPMIF;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
	protected MJCGHCHLIBH(int FMANEIECOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CFGDIIOHPHP(IPEndPoint DOEPIOCFAJN, byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int PHABMFMJBEC);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GPHDLIFDCCE(IPEndPoint DOEPIOCFAJN, byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int PHABMFMJBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GGPOBAOIAIN : MJCGHCHLIBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] BLIBAMJKLIA;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator IJAKMPFNFAE;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x29A8710", Offset = "0x29A6D10", VA = "0x1829A8710")]
	public GGPOBAOIAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x71C01A0", Offset = "0x71BE7A0", VA = "0x1871C01A0")]
	public void ILGJCLMHNIP(IPEndPoint DOEPIOCFAJN, byte[] BLIBAMJKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x71C00C0", Offset = "0x71BE6C0", VA = "0x1871C00C0")]
	public void HLBJIKBBNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x71BF8A0", Offset = "0x71BDEA0", VA = "0x1871BF8A0", Slot = "4")]
	public override void CFGDIIOHPHP(IPEndPoint DOEPIOCFAJN, byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x71BFD50", Offset = "0x71BE350", VA = "0x1871BFD50", Slot = "5")]
	public override void GPHDLIFDCCE(IPEndPoint DOEPIOCFAJN, byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int PHABMFMJBEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct GBIEDHIBJKL
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void PHHJALIKLJB([NoAlias] byte* IFNLMBIPGEL, [NoAlias] byte* BLIBAMJKLIA, [NoAlias] byte* BHALCEFPLLH, int PHABMFMJBEC);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class PNGLHGPPNDK
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr MMCEJNHBNPA;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr NGDILKBOGAG;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x71D2570", Offset = "0x71D0B70", VA = "0x1871D2570")]
		[BurstDiscard]
		private static void MAEIHCAOPLK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71D2410", Offset = "0x71D0A10", VA = "0x1871D2410")]
		private static IntPtr KMKEMENHKNJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x71D2360", Offset = "0x71D0960", VA = "0x1871D2360")]
		public static void IJHFBEDELIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public static void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x71D2120", Offset = "0x71D0720", VA = "0x1871D2120")]
		public unsafe static void GHDKDALNEMC([NoAlias] byte* IFNLMBIPGEL, [NoAlias] byte* BLIBAMJKLIA, [NoAlias] byte* BHALCEFPLLH, int PHABMFMJBEC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint BLIBAMJKLIA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint BHALCEFPLLH[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint NKDCKPJDCMB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint HEHODBHGOJH[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint PNLJHGEFDBM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint OCDLGMFGMDL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint LGOCLCHMHPA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint EBANPLEHOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint HIGNMJCHGEJ[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x71BF720", Offset = "0x71BDD20", VA = "0x1871BF720")]
	private void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x71BF6F0", Offset = "0x71BDCF0", VA = "0x1871BF6F0")]
	private uint IIACGIPMJEN(uint JIJNMCDLDDE, int CDANPLOBMID)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x71B98C0", Offset = "0x71B7EC0", VA = "0x1871B98C0")]
	private void KKGGPCOKAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x71B9B00", Offset = "0x71B8100", VA = "0x1871B9B00")]
	private void ODHBAILLPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x71B9A70", Offset = "0x71B8070", VA = "0x1871B9A70")]
	private void MDAHGMFPAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x71B9970", Offset = "0x71B7F70", VA = "0x1871B9970")]
	private void LIOKGNOMBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x71BF270", Offset = "0x71BD870", VA = "0x1871BF270")]
	private void EDNHJMJBJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x71BF2D0", Offset = "0x71BD8D0", VA = "0x1871BF2D0")]
	private unsafe void GKLHKIEEGML(byte* IFNLMBIPGEL, uint* BLIBAMJKLIA, uint* BHALCEFPLLH, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x71BF1F0", Offset = "0x71BD7F0", VA = "0x1871BF1F0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void CBLKCAPEAPH([NoAlias] byte* IFNLMBIPGEL, [NoAlias] byte* BLIBAMJKLIA, [NoAlias] byte* BHALCEFPLLH, int PHABMFMJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x71BF110", Offset = "0x71BD710", VA = "0x1871BF110")]
	public static void CBLKCAPEAPH(Span<byte> IFNLMBIPGEL, Span<byte> BLIBAMJKLIA, Span<byte> BHALCEFPLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x71BF7A0", Offset = "0x71BDDA0", VA = "0x1871BF7A0")]
	public static void NOAPMMOLLMH(Span<byte> IFNLMBIPGEL, Span<byte> BLIBAMJKLIA, Span<byte> BHALCEFPLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x71BF0A0", Offset = "0x71BD6A0", VA = "0x1871BF0A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BJHEABIBHKK([NoAlias] byte* IFNLMBIPGEL, [NoAlias] byte* BLIBAMJKLIA, [NoAlias] byte* BHALCEFPLLH, int PHABMFMJBEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x71D26A0", Offset = "0x71D0CA0", VA = "0x1871D26A0")]
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
