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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LPAFDNOGIPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KLCLIMHBPIE
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
		private NetworkManager PEIOKPHLDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, NPEKJKMGMPI> BLONEGPJJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KHFEKMBMJMM CHJAKFMGONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] HLMDANABEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KLCLIMHBPIE ADECHCALKGM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong FIMJELFAANF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GCLHIPBAPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5FB4BB0", Offset = "0x5FB35B0", VA = "0x185FB4BB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4140", Offset = "0x5FB2B40", VA = "0x185FB4140")]
		public void RecRoom_SetEncryptionInfo(ulong EGEIKCINFFG, byte[] COMNIKKFEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4120", Offset = "0x5FB2B20", VA = "0x185FB4120")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3FF0", Offset = "0x5FB29F0", VA = "0x185FB3FF0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4AB0", Offset = "0x5FB34B0", VA = "0x185FB4AB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4260", Offset = "0x5FB2C60", VA = "0x185FB4260", Slot = "6")]
		public override void Send(ulong DDOIBEJDFIA, ArraySegment<byte> LNCKNHNHHDF, NetworkDelivery GPMFLBBKOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB40E0", Offset = "0x5FB2AE0", VA = "0x185FB40E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DDOIBEJDFIA, [Out] ArraySegment<byte> HDOCILHNNDE, [Out] float FNEPJGCKJKN)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4550", Offset = "0x5FB2F50", VA = "0x185FB4550", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB49D0", Offset = "0x5FB33D0", VA = "0x185FB49D0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB37E0", Offset = "0x5FB21E0", VA = "0x185FB37E0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DDOIBEJDFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3690", Offset = "0x5FB2090", VA = "0x185FB3690", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3B20", Offset = "0x5FB2520", VA = "0x185FB3B20", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DDOIBEJDFIA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FB44E0", Offset = "0x5FB2EE0", VA = "0x185FB44E0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3DD0", Offset = "0x5FB27D0", VA = "0x185FB3DD0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager PEIOKPHLDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3A30", Offset = "0x5FB2430", VA = "0x185FB3A30")]
		private CJILOMIABCN FLMJDBNGEJB(NetworkDelivery AOGCIMANLIJ)
		{
			return default(CJILOMIABCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FB34E0", Offset = "0x5FB1EE0", VA = "0x185FB34E0", Slot = "15")]
		private void AKLGDEBENJF(NPEKJKMGMPI JFHMFMFDGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FB35D0", Offset = "0x5FB1FD0", VA = "0x185FB35D0", Slot = "16")]
		private void CPMDGBDJCIG(NPEKJKMGMPI JFHMFMFDGHM, GOIHBGPPOMI NIPAMCEHFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "17")]
		private void IONMGGLPHOJ(IPEndPoint LEBCLLCAHFM, SocketError EPBIIJGBAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3BC0", Offset = "0x5FB25C0", VA = "0x185FB3BC0", Slot = "18")]
		private void HLMIAEBBFJG(NPEKJKMGMPI JFHMFMFDGHM, PMJMNNHLJIJ BPJDDKOBEGL, byte IMKAMGFFIOE, CJILOMIABCN LKKEKAHOHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3950", Offset = "0x5FB2350", VA = "0x185FB3950")]
		private void EMEBHCDMPAB(int ECFPAOHDFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "19")]
		private void PDDAFEJJNCA(IPEndPoint HEPLCJDILHD, PMJMNNHLJIJ BPJDDKOBEGL, CPBNNODAIFC BAEEJDJFGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "20")]
		private void IFPEIMIOIFH(NPEKJKMGMPI JFHMFMFDGHM, int MLOLOFBHMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3F90", Offset = "0x5FB2990", VA = "0x185FB3F90", Slot = "21")]
		private void JFJPKALKNFF(OIPEAAKJEIO MGBHCKLJEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB35A0", Offset = "0x5FB1FA0", VA = "0x185FB35A0")]
		private ulong BEPOJGMOAOG(NPEKJKMGMPI JFHMFMFDGHM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3B00", Offset = "0x5FB2500", VA = "0x185FB3B00")]
		private static int GLKIHOLKIFA(float PEDHHHMMIGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4AD0", Offset = "0x5FB34D0", VA = "0x185FB4AD0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OIMDKGEBKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NPEKJKMGMPI KNHAMOLCEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<EFCJOCFFEAD> NGOBAOPLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JNOCJMFKCMK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAB10", Offset = "0x5FB9510", VA = "0x185FBAB10")]
	protected OIMDKGEBKMD(NPEKJKMGMPI JFHMFMFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAAB0", Offset = "0x5FB94B0", VA = "0x185FBAAB0")]
	public void NKBGADKOEBP(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA9F0", Offset = "0x5FB93F0", VA = "0x185FBA9F0")]
	protected void JGFPDMHADOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAA70", Offset = "0x5FB9470", VA = "0x185FBAA70")]
	public bool JIGOGPNIMFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool BNOCDDJMCNO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LLLHBMOCCDP(EFCJOCFFEAD FKLAIPNBMOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KKMOJMABHGD
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
public class OIPEAAKJEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KHFEKMBMJMM MPINIAANAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int AJOIJOAACFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OCKOGKMEGEJ CINIGHMMEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint CHNGCCDBNGJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KKMOJMABHGD OADPIFCAHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4A0", Offset = "0x8AAEA0", VA = "0x1808AC4A0")]
		[CompilerGenerated]
		get
		{
			return default(KKMOJMABHGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD12EC0", Offset = "0xD118C0", VA = "0x180D12EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FBABB0", Offset = "0x5FB95B0", VA = "0x185FBABB0")]
	internal void BGKEOFMOJIF(OCKOGKMEGEJ OCBAFNAAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAC10", Offset = "0x5FB9610", VA = "0x185FBAC10")]
	private bool EKGNLLKIGEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FBACA0", Offset = "0x5FB96A0", VA = "0x185FBACA0")]
	internal OIPEAAKJEIO(IPEndPoint HEPLCJDILHD, OCKOGKMEGEJ IAEHJGEBPFH, KHFEKMBMJMM DCNJJNPNFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAC40", Offset = "0x5FB9640", VA = "0x185FBAC40")]
	public NPEKJKMGMPI HMAGBPACBLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CPBNNODAIFC
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EOIPIGILKML
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
public struct GOIHBGPPOMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public EOIPIGILKML BJAFKMIANGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError CMHKPAIFILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PMJMNNHLJIJ NJDIPLKDJNN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LPAFDNOGIPC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBBGOCIEIJD(NPEKJKMGMPI JFHMFMFDGHM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GODJJIONPON(NPEKJKMGMPI JFHMFMFDGHM, GOIHBGPPOMI NIPAMCEHFPJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNEGHPDKIDO(IPEndPoint LEBCLLCAHFM, SocketError EPBIIJGBAFP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGOFDHPLOOI(NPEKJKMGMPI JFHMFMFDGHM, PMJMNNHLJIJ BPJDDKOBEGL, byte IMKAMGFFIOE, CJILOMIABCN LKKEKAHOHNB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMKHCMGPNKK(IPEndPoint HEPLCJDILHD, PMJMNNHLJIJ BPJDDKOBEGL, CPBNNODAIFC BAEEJDJFGJM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOIEHMBBDHI(NPEKJKMGMPI JFHMFMFDGHM, int MLOLOFBHMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IFBBBJEHGGN(OIPEAAKJEIO MGBHCKLJEHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKNIIOEGLJP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJLMBAMCHDO(NPEKJKMGMPI JFHMFMFDGHM, object MODCINONAOK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KHFPBFEBKEK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMPJAEILAEI(HJMMBKEGCKA FKLAIPNBMOM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JAOEAHJKONC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNFFCFBGOEF(NPEKJKMGMPI JFHMFMFDGHM, IPEndPoint MEHHAODPLDO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OCKOGKMEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int DOFEKBBBFPF = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long NLJJADHGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte INMENHFBNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] JNDFHNGCKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DMCBPHNECOC EIPGALGMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int PLHFLOPGLPL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA560", Offset = "0x5FB8F60", VA = "0x185FBA560")]
	private OCKOGKMEGEJ(long JFEHBNHBBOL, byte BAALOOFADNB, int GMEDGMJCEEO, byte[] PFPLEEGLENE, DMCBPHNECOC LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA500", Offset = "0x5FB8F00", VA = "0x185FBA500")]
	public static int ONLDILKKADO(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA100", Offset = "0x5FB8B00", VA = "0x185FBA100")]
	public static OCKOGKMEGEJ MIDAIMBBAPA(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA320", Offset = "0x5FB8D20", VA = "0x185FBA320")]
	public static EFCJOCFFEAD OGEMIEGOHJG(PNDFGOJALGM DAEIDHGNKGG, SocketAddress IINPCBCNGJK, long PPAHFJBNMNP, int GMEDGMJCEEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LMJDDPBBHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long NLJJADHGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte INMENHFBNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int PLHFLOPGLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AAIAIIEAEIK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3490", Offset = "0x5FB1E90", VA = "0x185FB3490")]
	private LMJDDPBBHJL(long JFEHBNHBBOL, byte BAALOOFADNB, int ODLFOOGHKJD, bool HEGJLDMEBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3250", Offset = "0x5FB1C50", VA = "0x185FB3250")]
	public static LMJDDPBBHJL MIDAIMBBAPA(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB33A0", Offset = "0x5FB1DA0", VA = "0x185FB33A0")]
	public static EFCJOCFFEAD OGEMIEGOHJG(long PPAHFJBNMNP, byte GMKJNPMDACF, int BGCMAHIFNDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3150", Offset = "0x5FB1B50", VA = "0x185FB3150")]
	public static EFCJOCFFEAD HHHIEDELHMF(NPEKJKMGMPI JFHMFMFDGHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum IAPCFALNIOG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LKHCIFJBGFN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHJGOOLHNBE(IPEndPoint KODEPIFPLPN, IPEndPoint HEPLCJDILHD, string OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKKEAJKJHPB(IPEndPoint MHHGEKLBKFH, IAPCFALNIOG AOGCIMANLIJ, string OEELDHBFFAF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EPHFGONFDNO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct GKDFFEGKJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint AHODIBFKMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint CHNGCCDBNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string MFLEEFFMMGE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct ODOMJGPFAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint FIKBEKNOBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IAPCFALNIOG GPKIFFDGPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string MFLEEFFMMGE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class HACOEOFJADD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EBNPPPEMMNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string MFLEEFFMMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HACOEOFJADD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HKHBMCIEIPC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EBNPPPEMMNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint IEJFBADKOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string MFLEEFFMMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HKHBMCIEIPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HNNDFKBHCAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MFLEEFFMMGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MHIMOBNFNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88CDB0", Offset = "0x88B7B0", VA = "0x18088CDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HNNDFKBHCAP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KHFEKMBMJMM CJJNPNIAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<GKDFFEGKJMD> JLHNEGLFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<ODOMJGPFAFE> AOPLKBMGGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DMCBPHNECOC LMBGFFKNEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PNDFGOJALGM EAKPECNFJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ODMHGAGPJNE DBCDNMPCNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LKHCIFJBGFN JGKGMDEKCGB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int DAJGLGBAAPA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool NDJCGNBEFBN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA94F0", Offset = "0x5FA7EF0", VA = "0x185FA94F0")]
	internal EPHFGONFDNO(KHFEKMBMJMM IEGPABMPADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9080", Offset = "0x5FA7A80", VA = "0x185FA9080")]
	internal void ALAFPFEHNBJ(IPEndPoint FHFKBHPMPOL, EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4410", Offset = "0x2BD2E10", VA = "0x182BD4410")]
	private void HMDFNACJFJM<T>(T FKLAIPNBMOM, IPEndPoint CDHECNAFHCH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9360", Offset = "0x5FA7D60", VA = "0x185FA9360")]
	private void OHJGOOLHNBE(HACOEOFJADD FNGOOLGJAAN, IPEndPoint FHFKBHPMPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9200", Offset = "0x5FA7C00", VA = "0x185FA9200")]
	private void AOOOHPNDHFL(HKHBMCIEIPC FNGOOLGJAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8EE0", Offset = "0x5FA78E0", VA = "0x185FA8EE0")]
	private void AANMGAIAALC(HNNDFKBHCAP FNGOOLGJAAN, IPEndPoint FHFKBHPMPOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CJILOMIABCN : byte
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
public enum PNKBKJBMBKM : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AJKCIBLBJIM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] HFDMKOPCMIE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int AOBFANCLALP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int PIMELAFKNKI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LLFAHDKKFFL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3140", Offset = "0x5FB1B40", VA = "0x185FB3140")]
	public LLFAHDKKFFL(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OKFFPBJKOCD : LLFAHDKKFFL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3140", Offset = "0x5FB1B40", VA = "0x185FB3140")]
	public OKFFPBJKOCD(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PBNIFFAEGGP
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
public interface MJLNBGMJBAM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNKKPBGJHHE(PBNIFFAEGGP AOOIPMOHGIC, string OOCPPLNIOAJ, params object[] BBLLNFBCDFH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GOAGFPNMANE
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static MJLNBGMJBAM DDCLJNABADG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object NNCANJLGIAA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9AC0", Offset = "0x5FA84C0", VA = "0x185FA9AC0")]
	private static void CLIDGKLBPJA(PBNIFFAEGGP JOIGHAKACDM, string OOCPPLNIOAJ, params object[] BBLLNFBCDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9DB0", Offset = "0x5FA87B0", VA = "0x185FA9DB0")]
	internal static void OHIBMCGCHOF(string OOCPPLNIOAJ, params object[] BBLLNFBCDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9D50", Offset = "0x5FA8750", VA = "0x185FA9D50")]
	internal static void MADIPJNEDJO(string OOCPPLNIOAJ, params object[] BBLLNFBCDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9CF0", Offset = "0x5FA86F0", VA = "0x185FA9CF0")]
	internal static void KDCJNNEHMGA(string OOCPPLNIOAJ, params object[] BBLLNFBCDFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LIKNIGEELLL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PMJMNNHLJIJ : DMCBPHNECOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private EFCJOCFFEAD OOIIDPNHIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KHFEKMBMJMM OBOBEPFGKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OLBJKDHAHDG DDCDGCMBBIJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB680", Offset = "0x5FBA080", VA = "0x185FBB680")]
	internal PMJMNNHLJIJ(KHFEKMBMJMM PEDEFMGDCEP, OLBJKDHAHDG GBJFKAGIBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB590", Offset = "0x5FB9F90", VA = "0x185FBB590")]
	internal void JPKKADDJBHL(EFCJOCFFEAD FKLAIPNBMOM, int HKOFKDGHACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB600", Offset = "0x5FBA000", VA = "0x185FBB600")]
	internal void LLJPLGJJDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB560", Offset = "0x5FB9F60", VA = "0x185FBB560")]
	public void EMHLEAKAPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OLBJKDHAHDG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IPEGLKMLHED
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
	public OLBJKDHAHDG PNIOHMAODCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public IPEGLKMLHED GPKIFFDGPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NPEKJKMGMPI KNHAMOLCEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint CHNGCCDBNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object OEMMAOLPBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int PLNHFMNHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError EOMDBCPFIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public EOIPIGILKML JFMIFMIPBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public OIPEAAKJEIO DNOOHGIJINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public CJILOMIABCN ANIDBEGDGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte EEFCKFCNDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly PMJMNNHLJIJ PEKIKOLBCKB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAD10", Offset = "0x5FB9710", VA = "0x185FBAD10")]
	public OLBJKDHAHDG(KHFEKMBMJMM PEDEFMGDCEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KHFEKMBMJMM : IEnumerable<NPEKJKMGMPI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class KILAAAJAILL : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FB28D0", Offset = "0x5FB12D0", VA = "0x185FB28D0", Slot = "4")]
		public bool Equals(IPEndPoint OFCNMBDJPHM, IPEndPoint CONCKFNNMJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5AAF940", Offset = "0x5AAE340", VA = "0x185AAF940", Slot = "5")]
		public int GetHashCode(IPEndPoint FHFDEAHMMBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KILAAAJAILL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HNIOEFHIMEF : IEnumerator<NPEKJKMGMPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly NPEKJKMGMPI AAPIEPEOMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NPEKJKMGMPI ILMINLBKGPA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NPEKJKMGMPI EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1330680", Offset = "0x132F080", VA = "0x181330680")]
		public HNIOEFHIMEF(NPEKJKMGMPI DKCAIIDABEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB260", Offset = "0x5FA9C60", VA = "0x185FAB260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB2B0", Offset = "0x5FA9CB0", VA = "0x185FAB2B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread BFDDEEOGAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool KGGDKLNAINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent PFBLEOHFCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OLBJKDHAHDG> NDPOBJJCJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OLBJKDHAHDG> FCNDPJMFOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OLBJKDHAHDG ICMNAFHGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LPAFDNOGIPC EKHGFMKLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly JKNIIOEGLJP GAFLAGLDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KHFPBFEBKEK AHCJONADMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JAOEAHJKONC COPKFBBPIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, NPEKJKMGMPI> IPFGKGHBLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, OIPEAAKJEIO> BBAOEINHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, ECPGJDHIPMM> PCGMENBBMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JHHFOJHKCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NPEKJKMGMPI KLENCONNLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int BIPLBEFNNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NPEKJKMGMPI> FLEDIMOBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NPEKJKMGMPI[] OOIJBDLAEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PCLGHFAPDPK JKMNLGAFCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int FOEBKKALIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> JMCIDDJKHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte CNHPLJIIFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object MELJAMJHKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool FBMFOHOAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NEAMKNKGOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int FPODNOELNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int FFJFOCCLLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MJJEKOFCOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HAKOJAMCHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool HOODAFLJKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool DFBJDEJGPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int OFEKLBCFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FMCFDKMIJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int FPNHGKCHNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool NDJCGNBEFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool JLNKMFFGPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HHDJGBALMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool NJHEBKCDGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PJEOOHKOCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int IELHPGCHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool LNALOMNLEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly ONJKCAIKAHG KOKHEANHOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool ODEIEAKCOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly EPHFGONFDNO MGNGPPLNHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool BCBHKLLCLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LIKNIGEELLL AHHHCPFHLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int GKMAMIHAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KJMEGMPOKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool OHFIDLFICDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool NBEPHAKHLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool KJODDJFJNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private EFCJOCFFEAD CMACFPAMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int MCOPHHGBNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object FDIADOKBHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private EFCJOCFFEAD GLAPNGHKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NNILBGHCCHC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int NBJLBCGBBAL = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int IGKEAFCFNKN = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KFPKPJHMALK NCCIKIPIEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private KFPKPJHMALK KIAKONDJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DLFOAFCOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread APBIMBDKEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint KJGCMLPDBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint JILPCBEDPGI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] LLINIBHIGJP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] EJILCIFINOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<IEHBPHEMDDO, IPEndPoint> LHBLOBCIIAA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress ILIPOMAANJK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool DKBEOFDANFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int PKEOPPOJGOF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BNIILBIHELA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xED5430", Offset = "0xED3E30", VA = "0x180ED5430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ICOCPLPNPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x18149F0", Offset = "0x18133F0", VA = "0x1818149F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A370", Offset = "0x1B78D70", VA = "0x181B7A370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte BMLPCLIIKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC4C550", Offset = "0xC4AF50", VA = "0x180C4C550")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CFFHNEOOJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1BF0", Offset = "0x5FB05F0", VA = "0x185FB1BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short HNPOPPMCHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD670", Offset = "0x5FAC070", VA = "0x185FAD670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD730", Offset = "0x5FAC130", VA = "0x185FAD730")]
	public void DBEDPDGNIIM(IPEndPoint LEBCLLCAHFM, byte[] COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC6B0", Offset = "0x5FAB0B0", VA = "0x185FAC6B0")]
	public void BGKAAAKOEFD(IPEndPoint LEBCLLCAHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1AE0", Offset = "0x5FB04E0", VA = "0x185FB1AE0")]
	private bool OOBKIPEOOCE(IPEndPoint LEBCLLCAHFM, [Out] NPEKJKMGMPI JFHMFMFDGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE960", Offset = "0x5FAD360", VA = "0x185FAE960")]
	private void FFAIGJMIJHE(NPEKJKMGMPI JFHMFMFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE910", Offset = "0x5FAD310", VA = "0x185FAE910")]
	private void EPAEGFAKIFO(NPEKJKMGMPI JFHMFMFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC9D0", Offset = "0x5FAB3D0", VA = "0x185FAC9D0")]
	private void CAHJMHJKGLE(NPEKJKMGMPI JFHMFMFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2280", Offset = "0x5FB0C80", VA = "0x185FB2280")]
	public KHFEKMBMJMM(LPAFDNOGIPC DCNJJNPNFCO, [Optional] PCLGHFAPDPK DHCBNKJDFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF830", Offset = "0x5FAE230", VA = "0x185FAF830")]
	internal void HGLJDOLEEBI(NPEKJKMGMPI IHBECAIAGFK, int MLOLOFBHMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF980", Offset = "0x5FAE380", VA = "0x185FAF980")]
	internal void JOOHEDBBNKA(NPEKJKMGMPI IHBECAIAGFK, object MODCINONAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FABAD0", Offset = "0x5FAA4D0", VA = "0x185FABAD0")]
	internal void AEHEPNOFKEH(NPEKJKMGMPI JFHMFMFDGHM, EOIPIGILKML NOJDLJBPIDL, SocketError FDHEDIODGDH, EFCJOCFFEAD BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD580", Offset = "0x5FABF80", VA = "0x185FAD580")]
	private void CKNHBJFCFFM(NPEKJKMGMPI JFHMFMFDGHM, EOIPIGILKML NOJDLJBPIDL, SocketError FDHEDIODGDH, bool LCIPAAAOEPD, byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CMNDBGDABDM, EFCJOCFFEAD BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFAE0", Offset = "0x5FAE4E0", VA = "0x185FAFAE0")]
	private void KFOJDMDOKJI(OLBJKDHAHDG.IPEGLKMLHED AOGCIMANLIJ, [Optional] NPEKJKMGMPI JFHMFMFDGHM, [Optional] IPEndPoint HEPLCJDILHD, SocketError GHILOAGNIAE = SocketError.Success, int MLOLOFBHMCJ = 0, EOIPIGILKML FFMJKMFJAOA = EOIPIGILKML.ConnectionFailed, [Optional] OIPEAAKJEIO OEDEHKEFDDD, CJILOMIABCN LKKEKAHOHNB = CJILOMIABCN.Unreliable, byte IMKAMGFFIOE = 0, [Optional] EFCJOCFFEAD ELFMKIEJBHN, [Optional] object MODCINONAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FACC40", Offset = "0x5FAB640", VA = "0x185FACC40")]
	private void CICNMLBCHPA(OLBJKDHAHDG GBJFKAGIBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF9D0", Offset = "0x5FAE3D0", VA = "0x185FAF9D0")]
	internal void KCEHIHBJGPP(OLBJKDHAHDG GBJFKAGIBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FABD50", Offset = "0x5FAA750", VA = "0x185FABD50")]
	private void BFKALBJAEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FADDD0", Offset = "0x5FAC7D0", VA = "0x185FADDD0")]
	private void DKLICNNDPPO(int DHOBCOBMLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC090", Offset = "0x5FAAA90", VA = "0x185FAC090")]
	internal NPEKJKMGMPI BGGKOMMEAHC(OIPEAAKJEIO MGBHCKLJEHL, byte[] MNKDOLDLOOP, int ICLEKBDIINO, int CGDCIDKGGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1B70", Offset = "0x5FB0570", VA = "0x185FB1B70")]
	private int PCEJGJGOONC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FB1C10", Offset = "0x5FB0610", VA = "0x185FB1C10")]
	private void PPNPCLPFKME(IPEndPoint HEPLCJDILHD, NPEKJKMGMPI FMNKNDENAHG, OCKOGKMEGEJ ALHIKEBGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0D20", Offset = "0x5FAF720", VA = "0x185FB0D20")]
	private void MIOEKFKMHPG(EFCJOCFFEAD FKLAIPNBMOM, IPEndPoint HEPLCJDILHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE0F0", Offset = "0x5FACAF0", VA = "0x185FAE0F0")]
	internal void EECMODPJOMJ(EFCJOCFFEAD FKLAIPNBMOM, CJILOMIABCN KLDKDAMEMAD, byte IMKAMGFFIOE, int HKOFKDGHACM, NPEKJKMGMPI IHBECAIAGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0CB0", Offset = "0x5FAF6B0", VA = "0x185FB0CB0")]
	public bool MIKAPCLAFCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0C90", Offset = "0x5FAF690", VA = "0x185FB0C90")]
	public bool MIKAPCLAFCB(IPAddress MEOFGDCMJAF, IPAddress PPJPMNFLCEB, int FKLKJMACJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0460", Offset = "0x5FAEE60", VA = "0x185FB0460")]
	public bool MIKAPCLAFCB(int FKLKJMACJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE3D0", Offset = "0x5FACDD0", VA = "0x185FAE3D0")]
	public void EFMHLCFOOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB620", Offset = "0x5FAA020", VA = "0x185FAB620")]
	public NPEKJKMGMPI AEAICDJMNNP(string FAIAABCCDGM, int FKLKJMACJGM, string COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB540", Offset = "0x5FA9F40", VA = "0x185FAB540")]
	public NPEKJKMGMPI AEAICDJMNNP(string FAIAABCCDGM, int FKLKJMACJGM, PNDFGOJALGM GLKHFDBLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB700", Offset = "0x5FAA100", VA = "0x185FAB700")]
	public NPEKJKMGMPI AEAICDJMNNP(IPEndPoint CDHECNAFHCH, PNDFGOJALGM GLKHFDBLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0450", Offset = "0x5FAEE50", VA = "0x185FB0450")]
	public void MFPKDJMJBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0100", Offset = "0x5FAEB00", VA = "0x185FB0100")]
	public void MFPKDJMJBIO(bool DLJGFMHIIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD950", Offset = "0x5FAC350", VA = "0x185FAD950")]
	public void DIDIHMGAJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FADA50", Offset = "0x5FAC450", VA = "0x185FADA50")]
	public void DIDIHMGAJOO(byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD410", Offset = "0x5FABE10", VA = "0x185FAD410")]
	public void CKNHBJFCFFM(NPEKJKMGMPI JFHMFMFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD4C0", Offset = "0x5FABEC0", VA = "0x185FAD4C0")]
	public void CKNHBJFCFFM(NPEKJKMGMPI JFHMFMFDGHM, byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FB20A0", Offset = "0x5FB0AA0", VA = "0x185FB20A0", Slot = "4")]
	private IEnumerator<NPEKJKMGMPI> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2130", Offset = "0x5FB0B30", VA = "0x185FB2130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF480", Offset = "0x5FADE80", VA = "0x185FAF480")]
	private EFCJOCFFEAD GNFDFDMOGHK(GDEBAMHPGGC GDCGGGDDADM, int ECFPAOHDFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF3A0", Offset = "0x5FADDA0", VA = "0x185FAF3A0")]
	private EFCJOCFFEAD GNFDFDMOGHK(GDEBAMHPGGC GDCGGGDDADM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFEC0", Offset = "0x5FAE8C0", VA = "0x185FAFEC0")]
	internal EFCJOCFFEAD KJJNLHDOEBD(int ECFPAOHDFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FADB70", Offset = "0x5FAC570", VA = "0x185FADB70")]
	internal void DJNIMPCPFOA(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB21C0", Offset = "0x5FB0BC0", VA = "0x185FB21C0")]
	static KHFEKMBMJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30")]
	private bool IIKOPGKOKAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEC40", Offset = "0x5FAD640", VA = "0x185FAEC40")]
	private void FNGOOCOOHNF(IPEndPoint EHNDHDBJBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF880", Offset = "0x5FAE280", VA = "0x185FAF880")]
	private void HOOALCOJLHN(IPEndPoint EHNDHDBJBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FABBA0", Offset = "0x5FAA5A0", VA = "0x185FABBA0")]
	private bool AHINFCPGKGE(SocketException JCOJOLLOCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF560", Offset = "0x5FADF60", VA = "0x185FAF560")]
	private void HDBMPNPHKGL(KFPKPJHMALK IEGPABMPADG, EndPoint LPLBJFBAIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE580", Offset = "0x5FACF80", VA = "0x185FAE580")]
	private void EKGIEFKIPIG(object PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FB04E0", Offset = "0x5FAEEE0", VA = "0x185FB04E0")]
	public bool MIKAPCLAFCB(IPAddress MEOFGDCMJAF, IPAddress PPJPMNFLCEB, int FKLKJMACJGM, bool PCMKIGKMFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC970", Offset = "0x5FAB370", VA = "0x185FAC970")]
	internal int BPKPDEAILHJ(EFCJOCFFEAD FKLAIPNBMOM, IPEndPoint HEPLCJDILHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FAED50", Offset = "0x5FAD750", VA = "0x185FAED50")]
	internal int GDNFMDLGMIH(EFCJOCFFEAD FKLAIPNBMOM, IPEndPoint HEPLCJDILHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FAED90", Offset = "0x5FAD790", VA = "0x185FAED90")]
	internal int GDNFMDLGMIH(byte[] BBDGOIMNDJI, int ICLEKBDIINO, int CGDCIDKGGML, IPEndPoint HEPLCJDILHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC800", Offset = "0x5FAB200", VA = "0x185FAC800")]
	internal void BLMHNCKCEAF(bool CIMOGEJFKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GDEBAMHPGGC : byte
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
internal sealed class EFCJOCFFEAD
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HFBCENPDDIJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] MLFJBALLANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] HGGHEIEOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BKOAINILKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object OEMMAOLPBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public EFCJOCFFEAD PNIOHMAODCA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GDEBAMHPGGC HPBGPMGHMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8640", Offset = "0x5FA7040", VA = "0x185FA8640")]
		get
		{
			return default(GDEBAMHPGGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8480", Offset = "0x5FA6E80", VA = "0x185FA8480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte INMENHFBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8770", Offset = "0x5FA7170", VA = "0x185FA8770")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8500", Offset = "0x5FA6F00", VA = "0x185FA8500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GGPNBLCOJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8540", Offset = "0x5FA6F40", VA = "0x185FA8540")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8870", Offset = "0x5FA7270", VA = "0x185FA8870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IDKNCAIMGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA85A0", Offset = "0x5FA6FA0", VA = "0x185FA85A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HDHNPEBMDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FA88B0", Offset = "0x5FA72B0", VA = "0x185FA88B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8610", Offset = "0x5FA7010", VA = "0x185FA8610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort DIKNIJKAMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FA88E0", Offset = "0x5FA72E0", VA = "0x185FA88E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FA87A0", Offset = "0x5FA71A0", VA = "0x185FA87A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort LHMLELMNIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8A40", Offset = "0x5FA7440", VA = "0x185FA8A40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA84C0", Offset = "0x5FA6EC0", VA = "0x185FA84C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort HNPBKKGMAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5FA87E0", Offset = "0x5FA71E0", VA = "0x185FA87E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FA85D0", Offset = "0x5FA6FD0", VA = "0x185FA85D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8AA0", Offset = "0x5FA74A0", VA = "0x185FA8AA0")]
	static EFCJOCFFEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8840", Offset = "0x5FA7240", VA = "0x185FA8840")]
	public void LBGHNPJGJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8D60", Offset = "0x5FA7760", VA = "0x185FA8D60")]
	public EFCJOCFFEAD(int ECFPAOHDFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8DD0", Offset = "0x5FA77D0", VA = "0x185FA8DD0")]
	public EFCJOCFFEAD(GDEBAMHPGGC GDCGGGDDADM, int ECFPAOHDFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8940", Offset = "0x5FA7340", VA = "0x185FA8940")]
	public static int OOCGKMBCEJC(GDEBAMHPGGC GDCGGGDDADM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA89B0", Offset = "0x5FA73B0", VA = "0x185FA89B0")]
	public int OOCGKMBCEJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8670", Offset = "0x5FA7070", VA = "0x185FA8670")]
	public bool FKCBLLHCBJP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum ACBBJABLMNM : byte
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
internal enum EDHMFAAGOPO
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
internal enum HAOAPJFHOKD
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum LAMJGCBFJFP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NPEKJKMGMPI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KKEMEMIECEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EFCJOCFFEAD[] DLLOJFPCCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JNILANNAILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PCGGKBFIEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HDHNPEBMDDI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KKEMEMIECEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void FLOMOMPLELA(ulong OJONBCOMHKL, int PHFGECFDDLJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CJBFFEALGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HMKLGOJBAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int MHGOEGHKIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double OHNLNEOEAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int MIEFOAEBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int IKAENIEDDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OEJHLIMMMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch BIPHBCJADAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int NMMFFICNEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long BBMJEDPPAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object JOMBNBAMEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal NPEKJKMGMPI HHLKHHBDHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal NPEKJKMGMPI ECIOJHEBAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<EFCJOCFFEAD> NFNOPFJBHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OIMDKGEBKMD> DIIEBAHBGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OIMDKGEBKMD[] BNIMHJGPBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int BGCCIJIMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int JJPGJMCLIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool LKPNFFIOHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int AOFBHMHKNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int CDKJDNHMAOH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int KCHCGEDJMNJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int GKJGFFLFENH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DPMPGHFIKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int BBIIEHOILPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, KKEMEMIECEP> APKHGGKBCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BLPKEGIGGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly EFCJOCFFEAD FMMJJCEICOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int ALMEFLNCKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int FHOKABCLHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint GAPBIIHACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HAFPGJNAGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HHJKANNEMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long OFLCMGFPHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte PLGCFEMINLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ACBBJABLMNM NKEBGGEJLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EFCJOCFFEAD KNNMLANAFAK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int KNHMGLKALBP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int CEJHMCHDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EFCJOCFFEAD LANMJJGJJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly EFCJOCFFEAD MFFMPPEDEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly EFCJOCFFEAD FJHGDEKDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly EFCJOCFFEAD CALDHIBMBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PNKBKJBMBKM JJOJDGLNCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly KHFEKMBMJMM IPFANPBMCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int POAGINPHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object GONPCACAEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly ONJKCAIKAHG KOKHEANHOBI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OODHELPFCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xADBB70", Offset = "0xADA570", VA = "0x180ADBB70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5810", Offset = "0x5FB4210", VA = "0x185FB5810")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EIDJCPIDCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9CE9E0", Offset = "0x9CD3E0", VA = "0x1809CE9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ACBBJABLMNM INGFIEAMJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1577580", Offset = "0x1575F80", VA = "0x181577580")]
		get
		{
			return default(ACBBJABLMNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long JBAOHJLKADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x88EC10", Offset = "0x88D610", VA = "0x18088EC10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IBNGLMLIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xF16C10", Offset = "0xF15610", VA = "0x180F16C10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1816D40", Offset = "0x1815740", VA = "0x181816D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int GANBDJHDBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7AE0", Offset = "0x5FB64E0", VA = "0x185FB7AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KBLIAIOLGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x893070", Offset = "0x891A70", VA = "0x180893070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double JJIKAAODEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1DECE30", Offset = "0x1DEB830", VA = "0x181DECE30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FLOMOMPLELA GCMANBOLOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5760", Offset = "0x5FB4160", VA = "0x185FB5760")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6A00", Offset = "0x5FB5400", VA = "0x185FB6A00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8900", Offset = "0x5FB7300", VA = "0x185FB8900")]
	internal NPEKJKMGMPI(KHFEKMBMJMM MGEMKJJCPIA, IPEndPoint HEPLCJDILHD, int DNICIAANFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FB67A0", Offset = "0x5FB51A0", VA = "0x185FB67A0")]
	internal void FPPFFFALAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6AE0", Offset = "0x5FB54E0", VA = "0x185FB6AE0")]
	internal void ILGBNHKDNCP(IPEndPoint OGCBKMBGDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB67C0", Offset = "0x5FB51C0", VA = "0x185FB67C0")]
	internal void HEAGFKEKLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8490", Offset = "0x5FB6E90", VA = "0x185FB8490")]
	private void OONKGFHDGBG(int FKJNOKCKJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB58C0", Offset = "0x5FB42C0", VA = "0x185FB58C0")]
	private void DMPADHPCEFL(int IBFNMJEAEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6850", Offset = "0x5FB5250", VA = "0x185FB6850")]
	private OIMDKGEBKMD HEJFNKKCBJI(byte PMJJDLNJJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8D50", Offset = "0x5FB7750", VA = "0x185FB8D50")]
	internal NPEKJKMGMPI(KHFEKMBMJMM MGEMKJJCPIA, IPEndPoint HEPLCJDILHD, int DNICIAANFHD, byte GMKJNPMDACF, PNDFGOJALGM DAEIDHGNKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8720", Offset = "0x5FB7120", VA = "0x185FB8720")]
	internal NPEKJKMGMPI(KHFEKMBMJMM MGEMKJJCPIA, OIPEAAKJEIO MGBHCKLJEHL, int DNICIAANFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5900", Offset = "0x5FB4300", VA = "0x185FB5900")]
	internal void EDAKFKNDHGG(OCKOGKMEGEJ PHDBOEBLJAM, byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8360", Offset = "0x5FB6D60", VA = "0x185FB8360")]
	internal bool OGBHJOMOPEM(LMJDDPBBHJL FKLAIPNBMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6AB0", Offset = "0x5FB54B0", VA = "0x185FB6AB0")]
	public void HMDFNACJFJM(byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CGDCIDKGGML, CJILOMIABCN JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5950", Offset = "0x5FB4350", VA = "0x185FB5950")]
	private void EJHPFIOKOOP(byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CGDCIDKGGML, byte IMKAMGFFIOE, CJILOMIABCN LKKEKAHOHNB, object MODCINONAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FB83E0", Offset = "0x5FB6DE0", VA = "0x185FB83E0")]
	public void OODCFBMIICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7A00", Offset = "0x5FB6400", VA = "0x185FB7A00")]
	internal HAOAPJFHOKD MGOPHMAIBHP(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return default(HAOAPJFHOKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8300", Offset = "0x5FB6D00", VA = "0x185FB8300")]
	internal void NMACHDEKHDH(OIMDKGEBKMD BEENMDHJFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6CA0", Offset = "0x5FB56A0", VA = "0x185FB6CA0")]
	internal LAMJGCBFJFP KAEJBPFFOAN(byte[] LNCKNHNHHDF, int ICLEKBDIINO, int CGDCIDKGGML, bool LCIPAAAOEPD)
	{
		return default(LAMJGCBFJFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6C60", Offset = "0x5FB5660", VA = "0x185FB6C60")]
	private void JLLPFOKMNLH(int FCAKAKPLAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4DD0", Offset = "0x5FB37D0", VA = "0x185FB4DD0")]
	internal void BJOAHLFIKNF(CJILOMIABCN KLDKDAMEMAD, EFCJOCFFEAD DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7AF0", Offset = "0x5FB64F0", VA = "0x185FB7AF0")]
	private void NCKCPKDCLOH(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6FB0", Offset = "0x5FB59B0", VA = "0x185FB6FB0")]
	private void KIFEKGKAHBF(int CPLJOMEDMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8560", Offset = "0x5FB6F60", VA = "0x185FB8560")]
	internal EDHMFAAGOPO PPNPCLPFKME(OCKOGKMEGEJ ALHIKEBGBCI)
	{
		return default(EDHMFAAGOPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7340", Offset = "0x5FB5D40", VA = "0x185FB7340")]
	internal void LLLHBMOCCDP(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6B10", Offset = "0x5FB5510", VA = "0x185FB6B10")]
	private void JLIEONNIMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4BD0", Offset = "0x5FB35D0", VA = "0x185FB4BD0")]
	internal void ADPJOFOALFM(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5EB0", Offset = "0x5FB48B0", VA = "0x185FB5EB0")]
	internal void EOBPLEKHDDD(int CPLJOMEDMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8040", Offset = "0x5FB6A40", VA = "0x185FB8040")]
	internal void NCLNNJAIDCE(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class ONJKCAIKAHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long JMJKOHJNDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FOLKHKFJPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long CMGHIDBMDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long GOKODHMJBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long NFIJLLELKKM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long NLGPMOPEAAD;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long KICMGENMOKE;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long NHIJMCBNAMN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long OKNAEAEBALE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long GBJOFJPFBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long DEABDCAGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long HKJINKMMHFA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long JDLOGAAMCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB0E0", Offset = "0x5FB9AE0", VA = "0x185FBB0E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DINFMNALAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB150", Offset = "0x5FB9B50", VA = "0x185FBB150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BIHLOBPPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB160", Offset = "0x5FB9B60", VA = "0x185FBB160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long HJJLOELJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAE10", Offset = "0x5FB9810", VA = "0x185FBAE10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HJDEFMNBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB170", Offset = "0x5FB9B70", VA = "0x185FBB170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long AIENAAIADBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAFF0", Offset = "0x5FB99F0", VA = "0x185FBAFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long BGEDJAGMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB0A0", Offset = "0x5FB9AA0", VA = "0x185FBB0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long ACAKLKNLHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAEE0", Offset = "0x5FB98E0", VA = "0x185FBAEE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private PNKBKJBMBKM JJHDMAGDMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB180", Offset = "0x5FB9B80", VA = "0x185FBB180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double EIFEGGHOFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAE20", Offset = "0x5FB9820", VA = "0x185FBAE20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB190", Offset = "0x5FB9B90", VA = "0x185FBB190")]
	public void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAE80", Offset = "0x5FB9880", VA = "0x185FBAE80")]
	public void CDACAOKBFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB1D0", Offset = "0x5FB9BD0", VA = "0x185FBB1D0")]
	public void OCLJLLMKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB0F0", Offset = "0x5FB9AF0", VA = "0x185FBB0F0")]
	public void INKCEKDLJFG(long MEKIHBAOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF20", Offset = "0x5FB9920", VA = "0x185FBAF20")]
	public void EKKMIMCCAJH(long KFAJAKDONPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FBADB0", Offset = "0x5FB97B0", VA = "0x185FBADB0")]
	public void ADLODAAJIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF80", Offset = "0x5FB9980", VA = "0x185FBAF80")]
	public void FANPLMOGOLA(long LODOJBMCDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB220", Offset = "0x5FB9C20", VA = "0x185FBB220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB000", Offset = "0x5FB9A00", VA = "0x185FBB000")]
	public void GGNPKMDHDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public ONJKCAIKAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BEHIMGADHIB
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> GBFLHEFLGPM;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6BF0", Offset = "0x5FA55F0", VA = "0x185FA6BF0")]
	public static IPEndPoint DNILEJANHAP(string LEOAMIAMFLC, int FKLKJMACJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6990", Offset = "0x5FA5390", VA = "0x185FA6990")]
	public static IPAddress BNCLJEEEKMG(string LEOAMIAMFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6B60", Offset = "0x5FA5560", VA = "0x185FA6B60")]
	public static IPAddress BNCLJEEEKMG(string LEOAMIAMFLC, AddressFamily PLLGOIHKKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6E40", Offset = "0x5FA5840", VA = "0x185FA6E40")]
	internal static int LHNOADAALBI(int JBNMBJFJHGM, int GEFBPGNPGOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDFC0", Offset = "0x2AEC9C0", VA = "0x182AEDFC0")]
	internal static T[] NLJLIGACFLA<T>(int CMNDBGDABDM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OCCOMPOGFDP : OIMDKGEBKMD
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct FOEGBOHHOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private EFCJOCFFEAD OOIIDPNHIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long IAEIIPJEFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool OCNCEOAEIIO;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5FA9A20", Offset = "0x5FA8420", VA = "0x185FA9A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5FA9940", Offset = "0x5FA8340", VA = "0x185FA9940")]
		public void BDNFIJHBNDG(EFCJOCFFEAD FKLAIPNBMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5FA9960", Offset = "0x5FA8360", VA = "0x185FA9960")]
		public bool GKNKLIMFJLM(long MJJJIHPNGKM, NPEKJKMGMPI JFHMFMFDGHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5FA99D0", Offset = "0x5FA83D0", VA = "0x185FA99D0")]
		public bool ODPBLJHKGDP(NPEKJKMGMPI JFHMFMFDGHM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly EFCJOCFFEAD AOCKENJMFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly FOEGBOHHOLC[] CEFAGKMJLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly EFCJOCFFEAD[] KAJAMDIHGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] JMLGPLCAGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int LDLIEGBBMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int JOKNLMEOFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int KKBCPEKHGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int CELAPAMFBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool ACFKMHOOHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly CJILOMIABCN FKIHGDCEHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool PCHPOGBEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int LDIOPHGEJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte MKLOMDNDFIA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9F30", Offset = "0x5FB8930", VA = "0x185FB9F30")]
	public OCCOMPOGFDP(NPEKJKMGMPI JFHMFMFDGHM, bool IKAMCNHLAMJ, byte DNICIAANFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9510", Offset = "0x5FB7F10", VA = "0x185FB9510")]
	private void KIDHHCEEMML(EFCJOCFFEAD FKLAIPNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9040", Offset = "0x5FB7A40", VA = "0x185FB9040", Slot = "4")]
	protected override bool BNOCDDJMCNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FB98D0", Offset = "0x5FB82D0", VA = "0x185FB98D0", Slot = "5")]
	public override bool LLLHBMOCCDP(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class ANKOCGJNAKD : OIMDKGEBKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int MJOJMDFLEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort JOKNLMEOFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool FJFGGLEBHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private EFCJOCFFEAD KHJIMCOLAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly EFCJOCFFEAD CLBFMNGPFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool JOJLPJIIKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte MKLOMDNDFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long AJFHFBIOHMI;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5FA68D0", Offset = "0x5FA52D0", VA = "0x185FA68D0")]
	public ANKOCGJNAKD(NPEKJKMGMPI JFHMFMFDGHM, bool PAEBDAOGBEM, byte DNICIAANFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6130", Offset = "0x5FA4B30", VA = "0x185FA6130", Slot = "4")]
	protected override bool BNOCDDJMCNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5FA65F0", Offset = "0x5FA4FF0", VA = "0x185FA65F0", Slot = "5")]
	public override bool LLLHBMOCCDP(EFCJOCFFEAD FKLAIPNBMOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NPJKKMNDGMI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct CKCGJCGOCFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong ANINBOIMLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double BDJMJPDPBGB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct CONKGDDJFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int MLADPIFKAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float LPJIJIPCBBL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5FA53E0", Offset = "0x5FA3DE0", VA = "0x185FA53E0")]
	private static void PLOGPFAGAID(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, ulong LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EF0", Offset = "0x5FB78F0", VA = "0x185FB8EF0")]
	private static void PLOGPFAGAID(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, int LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F60", Offset = "0x5FB7960", VA = "0x185FB8F60")]
	public static void PLOGPFAGAID(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, short LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9020", Offset = "0x5FB7A20", VA = "0x185FB9020")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, double IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8FA0", Offset = "0x5FB79A0", VA = "0x185FB8FA0")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F60", Offset = "0x5FB7960", VA = "0x185FB8F60")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, short IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F60", Offset = "0x5FB7960", VA = "0x185FB8F60")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, ushort IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EF0", Offset = "0x5FB78F0", VA = "0x185FB8EF0")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EF0", Offset = "0x5FB78F0", VA = "0x185FB8EF0")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, uint IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EE0", Offset = "0x5FB78E0", VA = "0x185FB8EE0")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8EE0", Offset = "0x5FB78E0", VA = "0x185FB8EE0")]
	public static void DFPKBEAPMGP(byte[] MGCOGNAKONH, int BHLKMIGNPBH, ulong IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DMCBPHNECOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] DGNCMKLODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int IDEGLFGPFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int ODFAMADENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int LCFMEDEKJIF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] HGGHEIEOGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LADEECLJOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MPAFNKGBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7AA0", Offset = "0x5FA64A0", VA = "0x185FA7AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FCEJLCCMDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2044480", Offset = "0x2042E80", VA = "0x182044480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HACICPJIDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7AB0", Offset = "0x5FA64B0", VA = "0x185FA7AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7740", Offset = "0x5FA6140", VA = "0x185FA7740")]
	public void JPKKADDJBHL(byte[] FCLIEHCKPJG, int EDCGGCHLNEI, int HGMNKMFLLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DMCBPHNECOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7B00", Offset = "0x5FA6500", VA = "0x185FA7B00")]
	public DMCBPHNECOC(byte[] FCLIEHCKPJG, int EDCGGCHLNEI, int HGMNKMFLLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7630", Offset = "0x5FA6030", VA = "0x185FA7630")]
	public IPEndPoint JINLLDHBNNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA73F0", Offset = "0x5FA5DF0", VA = "0x185FA73F0")]
	public byte EAFOMBGJJLM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA73F0", Offset = "0x5FA5DF0", VA = "0x185FA73F0")]
	public sbyte NDBNAHAALAF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3920", Offset = "0x2BA2320", VA = "0x182BA3920")]
	public T[] AIBFPNJBLFA<T>(ushort ECFPAOHDFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7430", Offset = "0x5FA5E30", VA = "0x185FA7430")]
	public bool[] ECMFKFCABIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA73B0", Offset = "0x5FA5DB0", VA = "0x185FA73B0")]
	public ushort[] DNNACAAJPPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FA78B0", Offset = "0x5FA62B0", VA = "0x185FA78B0")]
	public short[] NBNCFHIHLOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7060", Offset = "0x5FA5A60", VA = "0x185FA7060")]
	public int[] BKNLONFOONK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7AC0", Offset = "0x5FA64C0", VA = "0x185FA7AC0")]
	public uint[] OPDKKIBHJGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7700", Offset = "0x5FA6100", VA = "0x185FA7700")]
	public float[] JKPBMCLKMFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7A40", Offset = "0x5FA6440", VA = "0x185FA7A40")]
	public double[] NJLPAHNPFAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7780", Offset = "0x5FA6180", VA = "0x185FA7780")]
	public long[] KLOBMLNJAII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5FA77C0", Offset = "0x5FA61C0", VA = "0x185FA77C0")]
	public ulong[] LLGHIMKCFEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5FA78F0", Offset = "0x5FA62F0", VA = "0x185FA78F0")]
	public string[] NIPLEOMLBFK(int PHGMDMIJNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6FB0", Offset = "0x5FA59B0", VA = "0x185FA6FB0")]
	public bool BGOJILMPPEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7550", Offset = "0x5FA5F50", VA = "0x185FA7550")]
	public char GOGDOCIMJNH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7550", Offset = "0x5FA5F50", VA = "0x185FA7550")]
	public ushort OGMCLPPDIHP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7840", Offset = "0x5FA6240", VA = "0x185FA7840")]
	public short NAOOMOCHEOM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7110", Offset = "0x5FA5B10", VA = "0x185FA7110")]
	public long DEIDOJLHEHH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6F40", Offset = "0x5FA5940", VA = "0x185FA6F40")]
	public ulong AHMPKHHAFHL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA74E0", Offset = "0x5FA5EE0", VA = "0x185FA74E0")]
	public int GGDBFJNBLOK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7470", Offset = "0x5FA5E70", VA = "0x185FA7470")]
	public uint EIOAIFBJIMD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5FA75C0", Offset = "0x5FA5FC0", VA = "0x185FA75C0")]
	public float HHCMKODEPKN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6FF0", Offset = "0x5FA59F0", VA = "0x185FA6FF0")]
	public double BKDFHAMEPJE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7180", Offset = "0x5FA5B80", VA = "0x185FA7180")]
	public string DIDEJAGADEK(int CIJNMEICJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5FA70A0", Offset = "0x5FA5AA0", VA = "0x185FA70A0")]
	public ArraySegment<byte> CLDNNGJFHEM(int CMNDBGDABDM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6F00", Offset = "0x5FA5900", VA = "0x185FA6F00")]
	public sbyte[] ACCCPOLMELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7800", Offset = "0x5FA6200", VA = "0x185FA7800")]
	public byte[] NAFKOLIEIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7A80", Offset = "0x5FA6480", VA = "0x185FA7A80")]
	public void ODPBLJHKGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PNDFGOJALGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] DGNCMKLODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int IDEGLFGPFAH;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int NHILEGHLAFA = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool CLOLBNEDEKL;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding MDOGNMNHALL;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int NAGBPLHFDIM = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] BKEDFPCNOPM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] EIPGALGMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC3F0", Offset = "0x5FBADF0", VA = "0x185FBC3F0")]
	public PNDFGOJALGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC470", Offset = "0x5FBAE70", VA = "0x185FBC470")]
	public PNDFGOJALGM(bool ALBLGLIKHCI, int COIGKPJCDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBC00", Offset = "0x5FBA600", VA = "0x185FBBC00")]
	public static PNDFGOJALGM KOPKNGNGIIM(string IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBC70", Offset = "0x5FBA670", VA = "0x185FBBC70")]
	public void LMCIEPCICBL(int JGGDILEBCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x20BD210", Offset = "0x20BBC10", VA = "0x1820BD210")]
	public void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC2D0", Offset = "0x5FBACD0", VA = "0x185FBC2D0")]
	public void PNFJGHINLKL(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD10", Offset = "0x5FBA710", VA = "0x185FBBD10")]
	public void PNFJGHINLKL(double IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBEC0", Offset = "0x5FBA8C0", VA = "0x185FBBEC0")]
	public void PNFJGHINLKL(long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBEC0", Offset = "0x5FBA8C0", VA = "0x185FBBEC0")]
	public void PNFJGHINLKL(ulong IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBDD0", Offset = "0x5FBA7D0", VA = "0x185FBBDD0")]
	public void PNFJGHINLKL(int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBDD0", Offset = "0x5FBA7D0", VA = "0x185FBBDD0")]
	public void PNFJGHINLKL(uint IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD60", Offset = "0x5FBA760", VA = "0x185FBBD60")]
	public void PNFJGHINLKL(char IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD60", Offset = "0x5FBA760", VA = "0x185FBBD60")]
	public void PNFJGHINLKL(ushort IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBD60", Offset = "0x5FBA760", VA = "0x185FBBD60")]
	public void PNFJGHINLKL(short IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBE60", Offset = "0x5FBA860", VA = "0x185FBBE60")]
	public void PNFJGHINLKL(sbyte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBE60", Offset = "0x5FBA860", VA = "0x185FBBE60")]
	public void PNFJGHINLKL(byte IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC130", Offset = "0x5FBAB30", VA = "0x185FBC130")]
	public void PNFJGHINLKL(byte[] LNCKNHNHHDF, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBB20", Offset = "0x5FBA520", VA = "0x185FBBB20")]
	public void COBGJGBCAJL(sbyte[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBB20", Offset = "0x5FBA520", VA = "0x185FBBB20")]
	public void MEBBLPGMOBP(byte[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC270", Offset = "0x5FBAC70", VA = "0x185FBC270")]
	public void PNFJGHINLKL(bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBA40", Offset = "0x5FBA440", VA = "0x185FBBA40")]
	public void CCCINOKEIOP(Array IPJMHDEBKGD, int OMNDIGOAANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB960", Offset = "0x5FBA360", VA = "0x185FBB960")]
	public void CCCINOKEIOP(float[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB880", Offset = "0x5FBA280", VA = "0x185FBB880")]
	public void CCCINOKEIOP(double[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB880", Offset = "0x5FBA280", VA = "0x185FBB880")]
	public void CCCINOKEIOP(long[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB880", Offset = "0x5FBA280", VA = "0x185FBB880")]
	public void CCCINOKEIOP(ulong[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB960", Offset = "0x5FBA360", VA = "0x185FBB960")]
	public void CCCINOKEIOP(int[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB960", Offset = "0x5FBA360", VA = "0x185FBB960")]
	public void CCCINOKEIOP(uint[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7A0", Offset = "0x5FBA1A0", VA = "0x185FBB7A0")]
	public void CCCINOKEIOP(ushort[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7A0", Offset = "0x5FBA1A0", VA = "0x185FBB7A0")]
	public void CCCINOKEIOP(short[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBB20", Offset = "0x5FBA520", VA = "0x185FBBB20")]
	public void CCCINOKEIOP(bool[] IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB6D0", Offset = "0x5FBA0D0", VA = "0x185FBB6D0")]
	public void CCCINOKEIOP(string[] IPHMAHBENGI, int BBAHOJJCGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC1A0", Offset = "0x5FBABA0", VA = "0x185FBC1A0")]
	public void PNFJGHINLKL(IPEndPoint LEBCLLCAHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBF10", Offset = "0x5FBA910", VA = "0x185FBBF10")]
	public void PNFJGHINLKL(string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBF20", Offset = "0x5FBA920", VA = "0x185FBBF20")]
	public void PNFJGHINLKL(string IPHMAHBENGI, int CIJNMEICJJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ODMHGAGPJNE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FFAJACFLNJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong POAGINPHPCH;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3DECA60", Offset = "0x3DEB460", VA = "0x183DECA60")]
		static FFAJACFLNJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BKBLCKKJNHK(DMCBPHNECOC BPJDDKOBEGL, object MODCINONAOK);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LJHLOBHJDGO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public ODMHGAGPJNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LJHLOBHJDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x449A010", Offset = "0x4498A10", VA = "0x18449A010")]
		internal void BFGBLNLFDCF(DMCBPHNECOC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FFAJILMPCOJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public ODMHGAGPJNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FFAJILMPCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3DECB90", Offset = "0x3DEB590", VA = "0x183DECB90")]
		internal void BFGBLNLFDCF(DMCBPHNECOC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly OFPKDPOOAFM JENOIKOMDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, BKBLCKKJNHK> PKPJIBPGFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly PNDFGOJALGM JAMEIMGPFGA;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA7D0", Offset = "0x5FB91D0", VA = "0x185FBA7D0")]
	public ODMHGAGPJNE(int PHGMDMIJNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF10E0", Offset = "0x2AEFAE0", VA = "0x182AF10E0", Slot = "4")]
	protected virtual ulong KMBIJGBPLOA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA650", Offset = "0x5FB9050", VA = "0x185FBA650", Slot = "5")]
	protected virtual BKBLCKKJNHK ILPGCCOECIC(DMCBPHNECOC BPJDDKOBEGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7A10", Offset = "0x2EF6410", VA = "0x182EF7A10", Slot = "6")]
	protected virtual void MFGKCFLKJED<T>(PNDFGOJALGM HJIMDHLCBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA5D0", Offset = "0x5FB8FD0", VA = "0x185FBA5D0")]
	public void IAJKAMLLEEO(DMCBPHNECOC BPJDDKOBEGL, object MODCINONAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7960", Offset = "0x2EF6360", VA = "0x182EF7960")]
	public void IMMKLNFIFBN<T>(PNDFGOJALGM HJIMDHLCBKF, T FKLAIPNBMOM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA780", Offset = "0x5FB9180", VA = "0x185FBA780")]
	public void KOGPLKAHGOA(DMCBPHNECOC BPJDDKOBEGL, object MODCINONAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2EF77A0", Offset = "0x2EF61A0", VA = "0x182EF77A0")]
	public void GFEAKDFOOPC<T>(Action<T> NCPMINIBGHP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2EF75E0", Offset = "0x2EF5FE0", VA = "0x182EF75E0")]
	public void GFEAKDFOOPC<T, TUserData>(Action<T, TUserData> NCPMINIBGHP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OOOFEKKHJHA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3140", Offset = "0x5FB1B40", VA = "0x185FB3140")]
	public OOOFEKKHJHA(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IHKCKEGDPPH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB4E0", Offset = "0x5FA9EE0", VA = "0x185FAB4E0")]
	public IHKCKEGDPPH(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OFPKDPOOAFM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum MGGHOLAPIJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FLGJGCLJHOG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MGGHOLAPIJG GPKIFFDGPEH;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3E014F0", Offset = "0x3DFFEF0", VA = "0x183E014F0", Slot = "4")]
		public virtual void BDNFIJHBNDG(MethodInfo GGKPAFANJNK, MethodInfo FCPLNLDDJBF, MGGHOLAPIJG AOGCIMANLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void OHDKIKOIFFI(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GIKNJMMBLOK(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected FLGJGCLJHOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FPOBKMCOHHK<TClass, TProperty> : FLGJGCLJHOG<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> HEFNPGOOMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> IHIPAOFHFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> AHPEDCPEOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> DEGNKPLCNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> OCLHJLHIFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> JPEIFEIADIE;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FFC0", Offset = "0x3E0E9C0", VA = "0x183E0FFC0", Slot = "7")]
		public override void FCMPFBJCJFD(TClass IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A9B0", Offset = "0x3E093B0", VA = "0x183E0A9B0", Slot = "8")]
		public override void ADEKFDODKKP(TClass IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E11840", Offset = "0x3E10240", VA = "0x183E11840", Slot = "9")]
		public override void OHDKIKOIFFI(TClass IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E10A40", Offset = "0x3E0F440", VA = "0x183E10A40", Slot = "10")]
		public override void GIKNJMMBLOK(TClass IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F730", Offset = "0x3E0E130", VA = "0x183E0F730")]
		protected TProperty[] BGEEOACMMLB(TClass IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F840", Offset = "0x3E0E240", VA = "0x183E0F840")]
		protected TProperty[] DCPDBAGHKCL(TClass IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CFD0", Offset = "0x3E0B9D0", VA = "0x183E0CFD0", Slot = "4")]
		public override void BDNFIJHBNDG(MethodInfo GGKPAFANJNK, MethodInfo FCPLNLDDJBF, MGGHOLAPIJG AOGCIMANLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5690", Offset = "0x3DC4090", VA = "0x183DC5690")]
		protected FPOBKMCOHHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DGLOHADCKHF<TClass, TProperty> : FPOBKMCOHHK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ADEIBGDBGNI(DMCBPHNECOC CLCPGILFJHI, [Out] TProperty HILDPDFMLFP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OJAOPGOPFAI(PNDFGOJALGM LPDFOBDDKHG, TProperty HILDPDFMLFP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5A95CD0", Offset = "0x5A946D0", VA = "0x185A95CD0", Slot = "5")]
		public override void FOKGFCGOOPP(TClass IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5A95E90", Offset = "0x5A94890", VA = "0x185A95E90", Slot = "6")]
		public override void IMMKLNFIFBN(TClass IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5A95C10", Offset = "0x5A94610", VA = "0x185A95C10", Slot = "7")]
		public override void FCMPFBJCJFD(TClass IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5A959D0", Offset = "0x5A943D0", VA = "0x185A959D0", Slot = "8")]
		public override void ADEKFDODKKP(TClass IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x40DA8A0", Offset = "0x40D92A0", VA = "0x1840DA8A0")]
		protected DGLOHADCKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class JJGOAEDEFLL<T> : FPOBKMCOHHK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42FB6B0", Offset = "0x42FA0B0", VA = "0x1842FB6B0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x42FB730", Offset = "0x42FA130", VA = "0x1842FB730", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x42FB630", Offset = "0x42FA030", VA = "0x1842FB630", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x42FB5C0", Offset = "0x42F9FC0", VA = "0x1842FB5C0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public JJGOAEDEFLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LFPHLACLPJG<T> : FPOBKMCOHHK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x448AE50", Offset = "0x4489850", VA = "0x18448AE50", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x42FB730", Offset = "0x42FA130", VA = "0x1842FB730", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x448ADD0", Offset = "0x44897D0", VA = "0x18448ADD0", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x42FB5C0", Offset = "0x42F9FC0", VA = "0x1842FB5C0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public LFPHLACLPJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class ICANKMCCIPH<T> : FPOBKMCOHHK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x40788C0", Offset = "0x40772C0", VA = "0x1840788C0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4078940", Offset = "0x4077340", VA = "0x184078940", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4078840", Offset = "0x4077240", VA = "0x184078840", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x40787D0", Offset = "0x40771D0", VA = "0x1840787D0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public ICANKMCCIPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class LFLCAKBOCKJ<T> : FPOBKMCOHHK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x448AD50", Offset = "0x4489750", VA = "0x18448AD50", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4078940", Offset = "0x4077340", VA = "0x184078940", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x448ACD0", Offset = "0x44896D0", VA = "0x18448ACD0", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x40787D0", Offset = "0x40771D0", VA = "0x1840787D0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public LFLCAKBOCKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class LHMABOJDDFE<T> : FPOBKMCOHHK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44969E0", Offset = "0x44953E0", VA = "0x1844969E0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4496A60", Offset = "0x4495460", VA = "0x184496A60", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4496960", Offset = "0x4495360", VA = "0x184496960", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAAB0", Offset = "0x3EC94B0", VA = "0x183ECAAB0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public LHMABOJDDFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DDAJGCNNIIF<T> : FPOBKMCOHHK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5A72690", Offset = "0x5A71090", VA = "0x185A72690", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4496A60", Offset = "0x4495460", VA = "0x184496A60", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5A72610", Offset = "0x5A71010", VA = "0x185A72610", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAAB0", Offset = "0x3EC94B0", VA = "0x183ECAAB0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public DDAJGCNNIIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CHMHLJMDBHD<T> : FPOBKMCOHHK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x39FD6D0", Offset = "0x39FC0D0", VA = "0x1839FD6D0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39FD750", Offset = "0x39FC150", VA = "0x1839FD750", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54D3460", Offset = "0x54D1E60", VA = "0x1854D3460", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x39FD5E0", Offset = "0x39FBFE0", VA = "0x1839FD5E0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public CHMHLJMDBHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EBCHFNELHGD<T> : FPOBKMCOHHK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x39FD6D0", Offset = "0x39FC0D0", VA = "0x1839FD6D0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x39FD750", Offset = "0x39FC150", VA = "0x1839FD750", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x39FD650", Offset = "0x39FC050", VA = "0x1839FD650", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x39FD5E0", Offset = "0x39FBFE0", VA = "0x1839FD5E0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public EBCHFNELHGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CNOJDFEOMJK<T> : FPOBKMCOHHK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x57A8400", Offset = "0x57A6E00", VA = "0x1857A8400", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x57A8480", Offset = "0x57A6E80", VA = "0x1857A8480", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x57A8380", Offset = "0x57A6D80", VA = "0x1857A8380", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x42FB5C0", Offset = "0x42F9FC0", VA = "0x1842FB5C0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public CNOJDFEOMJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class GFNELJMIMLK<T> : FPOBKMCOHHK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3ECABA0", Offset = "0x3EC95A0", VA = "0x183ECABA0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAC20", Offset = "0x3EC9620", VA = "0x183ECAC20", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAB20", Offset = "0x3EC9520", VA = "0x183ECAB20", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAAB0", Offset = "0x3EC94B0", VA = "0x183ECAAB0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public GFNELJMIMLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KKPEDCILDDC<T> : FPOBKMCOHHK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x43DE3B0", Offset = "0x43DCDB0", VA = "0x1843DE3B0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x43DE430", Offset = "0x43DCE30", VA = "0x1843DE430", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x43DE330", Offset = "0x43DCD30", VA = "0x1843DE330", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39FD5E0", Offset = "0x39FBFE0", VA = "0x1839FD5E0", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39FD7C0", Offset = "0x39FC1C0", VA = "0x1839FD7C0")]
		public KKPEDCILDDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FENKKNACIHI<T> : DGLOHADCKHF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89A0", Offset = "0x3DE73A0", VA = "0x183DE89A0", Slot = "12")]
		protected override void OJAOPGOPFAI(PNDFGOJALGM LPDFOBDDKHG, char HILDPDFMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8970", Offset = "0x3DE7370", VA = "0x183DE8970", Slot = "11")]
		protected override void ADEIBGDBGNI(DMCBPHNECOC CLCPGILFJHI, [Out] char HILDPDFMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
		public FENKKNACIHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JIDLIHAEHNE<T> : DGLOHADCKHF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x42FA950", Offset = "0x42F9350", VA = "0x1842FA950", Slot = "12")]
		protected override void OJAOPGOPFAI(PNDFGOJALGM LPDFOBDDKHG, IPEndPoint HILDPDFMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x42FA910", Offset = "0x42F9310", VA = "0x1842FA910", Slot = "11")]
		protected override void ADEIBGDBGNI(DMCBPHNECOC CLCPGILFJHI, [Out] IPEndPoint HILDPDFMLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
		public JIDLIHAEHNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class HNDNBEAPMFM<T> : FPOBKMCOHHK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int JLCEGPDJIJH;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3FCFA90", Offset = "0x3FCE490", VA = "0x183FCFA90")]
		public HNDNBEAPMFM(int CIJNMEICJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF990", Offset = "0x3FCE390", VA = "0x183FCF990", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3FCFA10", Offset = "0x3FCE410", VA = "0x183FCFA10", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF910", Offset = "0x3FCE310", VA = "0x183FCF910", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF890", Offset = "0x3FCE290", VA = "0x183FCF890", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class ODCMDCBBCOM<T> : FLGJGCLJHOG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo HPBGPMGHMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type JGJBEDCDIPG;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x48D8BF0", Offset = "0x48D75F0", VA = "0x1848D8BF0")]
		public ODCMDCBBCOM(PropertyInfo GDCGGGDDADM, Type ONDDGDAAPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x48D89C0", Offset = "0x48D73C0", VA = "0x1848D89C0", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x48D8AE0", Offset = "0x48D74E0", VA = "0x1848D8AE0", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x48D8960", Offset = "0x48D7360", VA = "0x1848D8960", Slot = "7")]
		public override void FCMPFBJCJFD(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x48D8900", Offset = "0x48D7300", VA = "0x1848D8900", Slot = "8")]
		public override void ADEKFDODKKP(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x48D8B90", Offset = "0x48D7590", VA = "0x1848D8B90", Slot = "9")]
		public override void OHDKIKOIFFI(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x48D8A80", Offset = "0x48D7480", VA = "0x1848D8A80", Slot = "10")]
		public override void GIKNJMMBLOK(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BECHPJJMOIM<T> : ODCMDCBBCOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
		public BECHPJJMOIM(PropertyInfo GDCGGGDDADM, Type ONDDGDAAPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x50AB060", Offset = "0x50A9A60", VA = "0x1850AB060", Slot = "5")]
		public override void FOKGFCGOOPP(T IALHACDMFOH, DMCBPHNECOC CLCPGILFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x50AB120", Offset = "0x50A9B20", VA = "0x1850AB120", Slot = "6")]
		public override void IMMKLNFIFBN(T IALHACDMFOH, PNDFGOJALGM LPDFOBDDKHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class JPNHCHEMLAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static JPNHCHEMLAG<T> GHBFIIGNNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly FLGJGCLJHOG<T>[] ELLCKAPMGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int BDABBILJIFB;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4311C10", Offset = "0x4310610", VA = "0x184311C10")]
		public JPNHCHEMLAG(List<FLGJGCLJHOG<T>> KPJKFGIGKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4311B60", Offset = "0x4310560", VA = "0x184311B60")]
		public void IMMKLNFIFBN(T FHFDEAHMMBI, PNDFGOJALGM HJIMDHLCBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4311AB0", Offset = "0x43104B0", VA = "0x184311AB0")]
		public void FOKGFCGOOPP(T FHFDEAHMMBI, DMCBPHNECOC BPJDDKOBEGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class OIMNMPFHPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FLGJGCLJHOG<T> GJMIFHLLDMF<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private PNDFGOJALGM ELLIAOFPOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int IMINDLDDDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, OIMNMPFHPLL> NLHKNELLPPG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA950", Offset = "0x5FB9350", VA = "0x185FBA950")]
	public OFPKDPOOAFM(int PHGMDMIJNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2F00C80", Offset = "0x2EFF680", VA = "0x182F00C80")]
	private JPNHCHEMLAG<T> EOFEAKOCANB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA270", Offset = "0x2AC8C70", VA = "0x182ACA270")]
	public void FBIMIMMHNIB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2F01DA0", Offset = "0x2F007A0", VA = "0x182F01DA0")]
	public bool MPIHBHFBPAP<T>(DMCBPHNECOC BPJDDKOBEGL, T CDHECNAFHCH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2F00BF0", Offset = "0x2EFF5F0", VA = "0x182F00BF0")]
	public void BBLOJHGNHMB<T>(PNDFGOJALGM HJIMDHLCBKF, T FHFDEAHMMBI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HJMMBKEGCKA
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime PNGOGGKJEKN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] FDOLFAKONLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALOIPEJHKLN CLOMKNEIGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FAAB80", Offset = "0x5FA9580", VA = "0x185FAAB80")]
		get
		{
			return default(ALOIPEJHKLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DLNKLMBFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA1E0", Offset = "0x5FA8BE0", VA = "0x185FAA1E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FAABB0", Offset = "0x5FA95B0", VA = "0x185FAABB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HAJHIINPABB OOFOACHKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA0F0", Offset = "0x5FA8AF0", VA = "0x185FAA0F0")]
		get
		{
			return default(HAJHIINPABB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FAABF0", Offset = "0x5FA95F0", VA = "0x185FAABF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JKEJIJEGDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FA9EC0", Offset = "0x5FA88C0", VA = "0x185FA9EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint NCKLOJBPKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA6C0", Offset = "0x5FA90C0", VA = "0x185FAA6C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? JKKENNAPOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA5C0", Offset = "0x5FA8FC0", VA = "0x185FAA5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? MDEAMGACAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FAAB50", Offset = "0x5FA9550", VA = "0x185FAAB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? CMOOFMFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FAAC30", Offset = "0x5FA9630", VA = "0x185FAAC30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FAA210", Offset = "0x5FA8C10", VA = "0x185FAA210")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? MDGBLIHICOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xCBC4E0", Offset = "0xCBAEE0", VA = "0x180CBC4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAF40", Offset = "0x5FA9940", VA = "0x185FAAF40")]
	public HJMMBKEGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAE90", Offset = "0x5FA9890", VA = "0x185FAAE90")]
	internal HJMMBKEGCKA(byte[] MGCOGNAKONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA9A0", Offset = "0x5FA93A0", VA = "0x185FAA9A0")]
	public static HJMMBKEGCKA JMLMJADBFEL(byte[] MGCOGNAKONH, DateTime DEKJHDDIKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA7A0", Offset = "0x5FA91A0", VA = "0x185FAA7A0")]
	internal void JGKCJPECGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA3E0", Offset = "0x5FA8DE0", VA = "0x185FAA3E0")]
	private void FGNNDPGLAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9EF0", Offset = "0x5FA88F0", VA = "0x185FA9EF0")]
	private DateTime? BACCKKOIMFC(int EDCGGCHLNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAC60", Offset = "0x5FA9660", VA = "0x185FAAC60")]
	private void OEAKFCFCIEI(int EDCGGCHLNEI, DateTime? IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA5F0", Offset = "0x5FA8FF0", VA = "0x185FAA5F0")]
	private ulong GDEIBCEOLMG(int EDCGGCHLNEI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA120", Offset = "0x5FA8B20", VA = "0x185FAA120")]
	private void CEEFOBANFLI(int EDCGGCHLNEI, ulong IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAAC0", Offset = "0x5FA94C0", VA = "0x185FAAAC0")]
	private uint KEPBHKEDDDD(int EDCGGCHLNEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A390", Offset = "0x5E78D90", VA = "0x185E7A390")]
	private static uint HHJEJCDLIAA(uint OFCNMBDJPHM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA740", Offset = "0x5FA9140", VA = "0x185FAA740")]
	private static ulong HHJEJCDLIAA(ulong OFCNMBDJPHM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ALOIPEJHKLN
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
public enum HAJHIINPABB
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ECPGJDHIPMM
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int NILDJAJJENJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int AKHMNMCDKKJ = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int HAGGFJAHNIE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint LOIJMCHHNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int NIHLDJCMIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int JAFLGCFGGFC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NBLPDBEMPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5FA8470", Offset = "0x5FA6E70", VA = "0x185FA8470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8380", Offset = "0x5FA6D80", VA = "0x185FA8380")]
	public bool HMDFNACJFJM(KFPKPJHMALK IEGPABMPADG, int EPEPMIIMOCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EBLMEIJPFNN : KFPKPJHMALK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket IEGPABMPADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly KHFEKMBMJMM MGEMKJJCPIA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short HNPOPPMCHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7B60", Offset = "0x5FA6560", VA = "0x185FA7B60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PDFNPOMGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7C90", Offset = "0x5FA6690", VA = "0x185FA7C90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint AHODIBFKMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5FA7C70", Offset = "0x5FA6670", VA = "0x185FA7C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily LJIKLBLBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4463560", Offset = "0x4461F60", VA = "0x184463560", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FA82D0", Offset = "0x5FA6CD0", VA = "0x185FA82D0")]
	public EBLMEIJPFNN(AddressFamily PLLGOIHKKBA, KHFEKMBMJMM MGEMKJJCPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7CB0", Offset = "0x5FA66B0", VA = "0x185FA7CB0", Slot = "8")]
	public bool IJLLOPOCCDO(IPEndPoint LEBCLLCAHFM, LIKNIGEELLL AOEIHIBDILO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8270", Offset = "0x5FA6C70", VA = "0x185FA8270", Slot = "9")]
	public int KIJOMJJGMFJ(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, int ECFPAOHDFEB, IPEndPoint HEPLCJDILHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7B80", Offset = "0x5FA6580", VA = "0x185FA7B80", Slot = "10")]
	public int DFBGJPGHLDD(byte[] FJOBMDHPMBB, EndPoint AKKFOAGIFAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA82B0", Offset = "0x5FA6CB0", VA = "0x185FA82B0", Slot = "11")]
	public void MHHBIBHPEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface KFPKPJHMALK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short HNPOPPMCHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int PDFNPOMGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint AHODIBFKMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily LJIKLBLBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJLLOPOCCDO(IPEndPoint LEBCLLCAHFM, LIKNIGEELLL AOEIHIBDILO);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KIJOMJJGMFJ(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, int ECFPAOHDFEB, IPEndPoint HEPLCJDILHD);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DFBGJPGHLDD(byte[] FJOBMDHPMBB, EndPoint HEPLCJDILHD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHHBIBHPEOL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct IEHBPHEMDDO : IEquatable<IEHBPHEMDDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long KGEDCAPMOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long OHALBKNEPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long OBGIJMFKCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int NOFOFABAFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int MGDFCBEEKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB3F0", Offset = "0x5FA9DF0", VA = "0x185FAB3F0")]
	public IEHBPHEMDDO(byte[] FAIAABCCDGM, int MFPKNGBBMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4A0", Offset = "0x8AAEA0", VA = "0x1808AC4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB300", Offset = "0x5FA9D00", VA = "0x185FAB300", Slot = "4")]
	public bool Equals(IEHBPHEMDDO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB340", Offset = "0x5FA9D40", VA = "0x185FAB340", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class IFPOLPLJPIH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] NPPHALLFDFB;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PCLGHFAPDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int CFFHNEOOJDB;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
	protected PCLGHFAPDPK(int CBJIGMHFNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AHJKDIIONEB(IPEndPoint LEBCLLCAHFM, byte[] LNCKNHNHHDF, int EDCGGCHLNEI, int CGDCIDKGGML);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CCFGEKMNNFI(IPEndPoint LEBCLLCAHFM, byte[] LNCKNHNHHDF, int EDCGGCHLNEI, int CGDCIDKGGML);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ADKENPJOCOB : PCLGHFAPDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] COMNIKKFEEB;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator BEFKNPGODIB;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x215DA20", Offset = "0x215C420", VA = "0x18215DA20")]
	public ADKENPJOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5D80", Offset = "0x5FA4780", VA = "0x185FA5D80")]
	public void GBCHMPGPMND(IPEndPoint LEBCLLCAHFM, byte[] COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5F30", Offset = "0x5FA4930", VA = "0x185FA5F30")]
	public void NFDHLIOBPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5570", Offset = "0x5FA3F70", VA = "0x185FA5570", Slot = "4")]
	public override void AHJKDIIONEB(IPEndPoint LEBCLLCAHFM, byte[] LNCKNHNHHDF, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5A20", Offset = "0x5FA4420", VA = "0x185FA5A20", Slot = "5")]
	public override void CCFGEKMNNFI(IPEndPoint LEBCLLCAHFM, byte[] LNCKNHNHHDF, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct LJBJFBOOMHC
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void DNOILGDANLI([NoAlias] byte* BJLJOCPKHKD, [NoAlias] byte* COMNIKKFEEB, [NoAlias] byte* BDEKCDBMEAJ, int CGDCIDKGGML);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class OHGNMIGNAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC8E0", Offset = "0x5FBB2E0", VA = "0x185FBC8E0")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCA00", Offset = "0x5FBB400", VA = "0x185FBCA00")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC840", Offset = "0x5FBB240", VA = "0x185FBC840")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC610", Offset = "0x5FBB010", VA = "0x185FBC610")]
		public unsafe static void CPLCIOOIDJC([NoAlias] byte* BJLJOCPKHKD, [NoAlias] byte* COMNIKKFEEB, [NoAlias] byte* BDEKCDBMEAJ, int CGDCIDKGGML)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint COMNIKKFEEB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint BDEKCDBMEAJ[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint FENFHEFOMAA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint KJJBKCCHFNI[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint GFAHIGLACIP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint BFDIBDHFDKD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint BAEEBAODNHL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint PCENNKONCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint KAGKOKIHDKE[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2B40", Offset = "0x5FB1540", VA = "0x185FB2B40")]
	private void NJEMNKBBDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2940", Offset = "0x5FB1340", VA = "0x185FB2940")]
	private uint AFNLCMLPJPG(uint NLEGDNPENLM, int JGGFKHLAKAG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5230", Offset = "0x5FA3C30", VA = "0x185FA5230")]
	private void LKDEMFINDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4F90", Offset = "0x5FA3990", VA = "0x185FA4F90")]
	private void BCECMGPPMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5FA51A0", Offset = "0x5FA3BA0", VA = "0x185FA51A0")]
	private void LHOPKBFOBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA52E0", Offset = "0x5FA3CE0", VA = "0x185FA52E0")]
	private void OPDFDMGIKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB29E0", Offset = "0x5FB13E0", VA = "0x185FB29E0")]
	private void DLKENPPCKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2D20", Offset = "0x5FB1720", VA = "0x185FB2D20")]
	private unsafe void OJCLNBDPOAB(byte* BJLJOCPKHKD, uint* COMNIKKFEEB, uint* BDEKCDBMEAJ, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2CA0", Offset = "0x5FB16A0", VA = "0x185FB2CA0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OGLLDNFPELG([NoAlias] byte* BJLJOCPKHKD, [NoAlias] byte* COMNIKKFEEB, [NoAlias] byte* BDEKCDBMEAJ, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2BC0", Offset = "0x5FB15C0", VA = "0x185FB2BC0")]
	public static void OGLLDNFPELG(Span<byte> BJLJOCPKHKD, Span<byte> COMNIKKFEEB, Span<byte> BDEKCDBMEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2A40", Offset = "0x5FB1440", VA = "0x185FB2A40")]
	public static void HBGJGLDGGDA(Span<byte> BJLJOCPKHKD, Span<byte> COMNIKKFEEB, Span<byte> BDEKCDBMEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2970", Offset = "0x5FB1370", VA = "0x185FB2970")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void CAMKCNHJHJK([NoAlias] byte* BJLJOCPKHKD, [NoAlias] byte* COMNIKKFEEB, [NoAlias] byte* BDEKCDBMEAJ, int CGDCIDKGGML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCB50", Offset = "0x5FBB550", VA = "0x185FBCB50")]
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
