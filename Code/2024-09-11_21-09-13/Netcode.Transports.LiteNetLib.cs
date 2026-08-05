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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, INFNLCKMAGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KPAPLNPFIKO
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
		private NetworkManager NOOIFLLDEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, JOGDCLPCEJA> KIAGLPPJFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HLFOIBHLJDH ACFAMNPFOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] GMCIMEINCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KPAPLNPFIKO MMBFNEPFLMH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong MICAONDOEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool KHBJKPODHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5F98030", Offset = "0x5F96630", VA = "0x185F98030", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F97540", Offset = "0x5F95B40", VA = "0x185F97540")]
		public void RecRoom_SetEncryptionInfo(ulong BGPCLPJDOEK, byte[] LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F97520", Offset = "0x5F95B20", VA = "0x185F97520")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F973F0", Offset = "0x5F959F0", VA = "0x185F973F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F97F30", Offset = "0x5F96530", VA = "0x185F97F30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F976E0", Offset = "0x5F95CE0", VA = "0x185F976E0", Slot = "6")]
		public override void Send(ulong OFOOJDCGKBP, ArraySegment<byte> JGCMECODHDI, NetworkDelivery DMADOKHGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F974E0", Offset = "0x5F95AE0", VA = "0x185F974E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong OFOOJDCGKBP, [Out] ArraySegment<byte> AJFODGMHKJN, [Out] float LAAOEDLAGIL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F979D0", Offset = "0x5F95FD0", VA = "0x185F979D0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F97E50", Offset = "0x5F96450", VA = "0x185F97E50", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F96B50", Offset = "0x5F95150", VA = "0x185F96B50", Slot = "10")]
		public override void DisconnectRemoteClient(ulong OFOOJDCGKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F96A00", Offset = "0x5F95000", VA = "0x185F96A00", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F96FB0", Offset = "0x5F955B0", VA = "0x185F96FB0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong OFOOJDCGKBP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F97960", Offset = "0x5F95F60", VA = "0x185F97960", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F97050", Offset = "0x5F95650", VA = "0x185F97050", Slot = "14")]
		public override void Initialize([Optional] NetworkManager NOOIFLLDEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F972F0", Offset = "0x5F958F0", VA = "0x185F972F0")]
		private FLBEBOIBIEG LJIILGAGDEO(NetworkDelivery JLAAKHANEHC)
		{
			return default(FLBEBOIBIEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F97210", Offset = "0x5F95810", VA = "0x185F97210", Slot = "15")]
		private void KGJFHPMFOAH(JOGDCLPCEJA OCLFKCJGOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F96860", Offset = "0x5F94E60", VA = "0x185F96860", Slot = "16")]
		private void BGMAALBNAGF(JOGDCLPCEJA OCLFKCJGOOI, HMPEKLHFEPB JLLJKHHBMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "17")]
		private void IIPLLMKDFNJ(IPEndPoint COCCJPGAHOG, SocketError ANMOGHNPGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F96DA0", Offset = "0x5F953A0", VA = "0x185F96DA0", Slot = "18")]
		private void GJLJPGFLGEC(JOGDCLPCEJA OCLFKCJGOOI, ILDGMMKKEBF JEAKAGANOAM, byte OCDNIEKJOID, FLBEBOIBIEG ILLOHCPKDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F96CC0", Offset = "0x5F952C0", VA = "0x185F96CC0")]
		private void FBNHGBNBGPJ(int BHEAFIOEIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "19")]
		private void KPNBPONCDHA(IPEndPoint EGIABGNOHCN, ILDGMMKKEBF JEAKAGANOAM, PIJPONMJECP KEOIKFMHEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "20")]
		private void IGOLPMCMLLO(JOGDCLPCEJA OCLFKCJGOOI, int MCMKEGBLLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F969A0", Offset = "0x5F94FA0", VA = "0x185F969A0", Slot = "21")]
		private void DMDCIMMCAKE(CLINOKNLAOH NEKCFCOLDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F973C0", Offset = "0x5F959C0", VA = "0x185F973C0")]
		private ulong LLPENPCFCBD(JOGDCLPCEJA OCLFKCJGOOI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F972D0", Offset = "0x5F958D0", VA = "0x185F972D0")]
		private static int KOCAEGFMDOB(float GMOGAEOJHDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F97F50", Offset = "0x5F96550", VA = "0x185F97F50")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CPNFNHHIPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly JOGDCLPCEJA MEBCEBEAMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<IGCJLPHBJAJ> BPEGIKAFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KPJEFKBFEAO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F84130", Offset = "0x5F82730", VA = "0x185F84130")]
	protected CPNFNHHIPJF(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F84010", Offset = "0x5F82610", VA = "0x185F84010")]
	public void BAEPNCDLGCC(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F840B0", Offset = "0x5F826B0", VA = "0x185F840B0")]
	protected void JEIKEDDBDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F84070", Offset = "0x5F82670", VA = "0x185F84070")]
	public bool ILHCPEICCGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OEBPFPLLJIE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AOMMBBLGMIA(IGCJLPHBJAJ BHIJKPOILFM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum MFEFKNHHAOA
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
public class CLINOKNLAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HLFOIBHLJDH DCAHLMMJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FIKFMFHDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal AGJIJHGCHHI OKNFNMBIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint FAFKCIEBIHF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal MFEFKNHHAOA OAGMCANLNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCB0", Offset = "0x8AC2B0", VA = "0x1808ADCB0")]
		[CompilerGenerated]
		get
		{
			return default(MFEFKNHHAOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF60", Offset = "0xC69560", VA = "0x180C6AF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F83F10", Offset = "0x5F82510", VA = "0x185F83F10")]
	internal void BEAGHLMGBOP(AGJIJHGCHHI ECLCCAMNGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F83F70", Offset = "0x5F82570", VA = "0x185F83F70")]
	private bool OINEHLCBEDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F83FA0", Offset = "0x5F825A0", VA = "0x185F83FA0")]
	internal CLINOKNLAOH(IPEndPoint EGIABGNOHCN, AGJIJHGCHHI DFOBGICAKNO, HLFOIBHLJDH MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F83EB0", Offset = "0x5F824B0", VA = "0x185F83EB0")]
	public JOGDCLPCEJA AHKCAIBOMCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PIJPONMJECP
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DOGAPDHDCBD
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
public struct HMPEKLHFEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DOGAPDHDCBD FDKEDIHHBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError OANLLGOGBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public ILDGMMKKEBF LHFLNMHHHLL;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface INFNLCKMAGO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDIABMMIKAF(JOGDCLPCEJA OCLFKCJGOOI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEMPLFOIKKA(JOGDCLPCEJA OCLFKCJGOOI, HMPEKLHFEPB JLLJKHHBMNL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PELLBJNHGDG(IPEndPoint COCCJPGAHOG, SocketError ANMOGHNPGHI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDGDHFEDJLB(JOGDCLPCEJA OCLFKCJGOOI, ILDGMMKKEBF JEAKAGANOAM, byte OCDNIEKJOID, FLBEBOIBIEG ILLOHCPKDKP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNBOICJGHDM(IPEndPoint EGIABGNOHCN, ILDGMMKKEBF JEAKAGANOAM, PIJPONMJECP KEOIKFMHEJA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLALKHPAMLM(JOGDCLPCEJA OCLFKCJGOOI, int MCMKEGBLLJK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHKBAIMENNF(CLINOKNLAOH NEKCFCOLDAN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KCOEIAMONFN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JALCAIKJKCD(JOGDCLPCEJA OCLFKCJGOOI, object KHBHLJCCBLL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BHFJFHPCAPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLOLHLEBABA(IOKBCLOJJIH BHIJKPOILFM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LOMGLGIIOND
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGBMMFACOEH(JOGDCLPCEJA OCLFKCJGOOI, IPEndPoint OIIHLGCFAEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class AGJIJHGCHHI
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NDHJGAPHNKI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long JOGNHGOFMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte KJNAFDPHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] GGAPNBEMLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly PKILOIGDLDE MJHCHFCOEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int NDHGBABFOGA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F82EA0", Offset = "0x5F814A0", VA = "0x185F82EA0")]
	private AGJIJHGCHHI(long MHHMDJHKBNO, byte KJMJNHPDCNL, int IDOMJKBDODC, byte[] FKLHBANDIHB, PKILOIGDLDE JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F82A40", Offset = "0x5F81040", VA = "0x185F82A40")]
	public static int HNLPHMBKAJN(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F82AA0", Offset = "0x5F810A0", VA = "0x185F82AA0")]
	public static AGJIJHGCHHI NEGJMOMMHNA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F82CC0", Offset = "0x5F812C0", VA = "0x185F82CC0")]
	public static IGCJLPHBJAJ NMMPCDKDGGK(GDDHLOJHPLL IKOHIFBJJII, SocketAddress KNKNBEOJCBH, long FBHCKPAOFFE, int IDOMJKBDODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BFFDFNKPPGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long JOGNHGOFMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte KJNAFDPHDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int NDHGBABFOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool ELHPNEABLHK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F83E60", Offset = "0x5F82460", VA = "0x185F83E60")]
	private BFFDFNKPPGC(long MHHMDJHKBNO, byte KJMJNHPDCNL, int NECEDJFMDLL, bool NAPNNFCDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F83C20", Offset = "0x5F82220", VA = "0x185F83C20")]
	public static BFFDFNKPPGC NEGJMOMMHNA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F83D70", Offset = "0x5F82370", VA = "0x185F83D70")]
	public static IGCJLPHBJAJ NMMPCDKDGGK(long FBHCKPAOFFE, byte ELLIJBJPLIA, int AMDPOGMBLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F83B20", Offset = "0x5F82120", VA = "0x185F83B20")]
	public static IGCJLPHBJAJ EKGFBDMMLGA(JOGDCLPCEJA OCLFKCJGOOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum EDBKCGGEPCG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NOKBBFBPPEF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGENDMNMLGM(IPEndPoint AMNGJIMABMB, IPEndPoint EGIABGNOHCN, string FLLNLBHFENG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPEKCDAJBMM(IPEndPoint ONLDPPFDCAE, EDBKCGGEPCG JLAAKHANEHC, string FLLNLBHFENG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FLHPMHGGOIG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NMLMKEGENEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint FJGIOONILLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint FAFKCIEBIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string EMEGGONDJAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct JNLNBBBMENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint IJJDDIPONPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EDBKCGGEPCG EMAFAACIGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string EMEGGONDJAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class JKBHFCOFILD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EEKALMLFLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string EMEGGONDJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JKBHFCOFILD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class KPFNLEACGOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EEKALMLFLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GCEKNMCHJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EMEGGONDJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KPFNLEACGOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HPFANNGDJEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EMEGGONDJAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool COHFPGMKEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1320", VA = "0x1809F2D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88CEA0", VA = "0x18088E8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HPFANNGDJEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HLFOIBHLJDH NMJJBPEEHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<NMLMKEGENEL> HAHICFMADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<JNLNBBBMENJ> PANGJFIONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PKILOIGDLDE APKCJGODHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GDDHLOJHPLL LEFMHNKNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GHDPNEGIGIO JEHAEGBDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NOKBBFBPPEF DICGNIBGIKC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int KKNILOBNAEK = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool NOKGAHNNOKG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F85810", Offset = "0x5F83E10", VA = "0x185F85810")]
	internal FLHPMHGGOIG(HLFOIBHLJDH PHJMMALGKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F85520", Offset = "0x5F83B20", VA = "0x185F85520")]
	internal void JGOBEPNEFAP(IPEndPoint AMPFOHOIFFB, IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEE70", Offset = "0x2CAD470", VA = "0x182CAEE70")]
	private void OKFDICIBJAH<T>(T BHIJKPOILFM, IPEndPoint LLMCGMPLMBL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F85680", Offset = "0x5F83C80", VA = "0x185F85680")]
	private void KGENDMNMLGM(JKBHFCOFILD EIMIIALLGDD, IPEndPoint AMPFOHOIFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F85220", Offset = "0x5F83820", VA = "0x185F85220")]
	private void FKAPNOCLCOI(KPFNLEACGOI EIMIIALLGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F85380", Offset = "0x5F83980", VA = "0x185F85380")]
	private void GBDFMJFGGHG(HPFANNGDJEA EIMIIALLGDD, IPEndPoint AMPFOHOIFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum FLBEBOIBIEG : byte
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
public enum MAMADBLBPMI : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AHJACFOCPJN
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] GKJNDCPBHCF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int GFBIIODLAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int NHEABGBGMKB;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DELDNCFJLHH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5F841D0", Offset = "0x5F827D0", VA = "0x185F841D0")]
	public DELDNCFJLHH(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OCALCONDLKL : DELDNCFJLHH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F841D0", Offset = "0x5F827D0", VA = "0x185F841D0")]
	public OCALCONDLKL(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MDPIOBEDKDP
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
public interface DKJNJOALNJE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGKNCMNDBEA(MDPIOBEDKDP DKIIACHLPCD, string KLNAGGGGPDK, params object[] AAAOIGBEBAB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EAGENOFBANJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static DKJNJOALNJE GFCNKKBKPJG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object EFDPCDDAIIF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F84EF0", Offset = "0x5F834F0", VA = "0x185F84EF0")]
	private static void NCKBDMJHFHB(MDPIOBEDKDP NJBLKCIKLOM, string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F84E90", Offset = "0x5F83490", VA = "0x185F84E90")]
	internal static void KIAOPGHDFBF(string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F84E30", Offset = "0x5F83430", VA = "0x185F84E30")]
	internal static void EMLCJEKGMMG(string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F84DD0", Offset = "0x5F833D0", VA = "0x185F84DD0")]
	internal static void DGIDDAPCBLK(string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum EGNDMCLNBPC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ILDGMMKKEBF : PKILOIGDLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private IGCJLPHBJAJ FPFOIPDHLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HLFOIBHLJDH NNIMIJHEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PNDEKBPIPKK PADHCEFPLKN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FC40", Offset = "0x5F8E240", VA = "0x185F8FC40")]
	internal ILDGMMKKEBF(HLFOIBHLJDH EHABNPPLNPG, PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FBD0", Offset = "0x5F8E1D0", VA = "0x185F8FBD0")]
	internal void MPOJAPNIAAF(IGCJLPHBJAJ BHIJKPOILFM, int POIDBEGOOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FB20", Offset = "0x5F8E120", VA = "0x185F8FB20")]
	internal void GNIIHDBKDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FBA0", Offset = "0x5F8E1A0", VA = "0x185F8FBA0")]
	public void LLLICJBGOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class PNDEKBPIPKK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum CKCHCKLDLJB
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
	public PNDEKBPIPKK FBNLOBKJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public CKCHCKLDLJB EMAFAACIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JOGDCLPCEJA MEBCEBEAMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint FAFKCIEBIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object FGBAFOAKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int NOJJPKHFCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JNCFHGENFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DOGAPDHDCBD BBGLOJHBBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public CLINOKNLAOH CIDAIDEGPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FLBEBOIBIEG OLHGEBIJEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PHPHEHGMDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly ILDGMMKKEBF NJNOKOPEPJC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F996C0", Offset = "0x5F97CC0", VA = "0x185F996C0")]
	public PNDEKBPIPKK(HLFOIBHLJDH EHABNPPLNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HLFOIBHLJDH : IEnumerable<JOGDCLPCEJA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LNCGPJPPFPH : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F96280", Offset = "0x5F94880", VA = "0x185F96280", Slot = "4")]
		public bool Equals(IPEndPoint NCPIGLMANIM, IPEndPoint DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5A7C250", Offset = "0x5A7A850", VA = "0x185A7C250", Slot = "5")]
		public int GetHashCode(IPEndPoint GHMNBJIOGAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public LNCGPJPPFPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct IDLCHMOFILA : IEnumerator<JOGDCLPCEJA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly JOGDCLPCEJA DGBPPCEHFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JOGDCLPCEJA BHCMDIBGAOL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JOGDCLPCEJA JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA40F60", Offset = "0xA3F560", VA = "0x180A40F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA40F60", Offset = "0xA3F560", VA = "0x180A40F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x12768D0", Offset = "0x1274ED0", VA = "0x1812768D0")]
		public IDLCHMOFILA(JOGDCLPCEJA FDIIPKGGJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F020", Offset = "0x5F8D620", VA = "0x185F8F020", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F070", Offset = "0x5F8D670", VA = "0x185F8F070", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread LANFPEMBOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool OCDGNDIMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CKECLAMLKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<PNDEKBPIPKK> JPKMIKGKBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<PNDEKBPIPKK> GCEPDHPOKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private PNDEKBPIPKK HPBEMNIPBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly INFNLCKMAGO PFCIKGFAPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KCOEIAMONFN EBCMPECDBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly BHFJFHPCAPJ BBMGPFEOADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LOMGLGIIOND JFFJKMMLGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, JOGDCLPCEJA> NDFHMIGJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, CLINOKNLAOH> BMLKFHCHHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, DENOEGJPMGD> POMDCKCNJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim NIDFBFFPIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JOGDCLPCEJA PLNMONLDCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int EAGGEABPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<JOGDCLPCEJA> EHIOJINEINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JOGDCLPCEJA[] MEBADLNMPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HDIHHAICNED DMLMIKMJILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int HHPMNNGFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NKDPHBDCHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte JCOEJAGAJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object FAHNPPMLNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool CHAMOPAHMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool IOADKCEKCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BPINMDBNKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HECMILDMCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int NIMDJIIICGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int AJLHHELJOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DONAFLCBAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool PEKDGMDKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KPNOCGELJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BMHOBHFCLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int CFCJIJJAEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool NOKGAHNNOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool CEEDMOFPELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool LCJCDNPPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool ILGMMEGMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FBFFNHFMPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int LEIBEHGMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool DMPHECHMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly NIACNHDDOGI CEBGHKGAHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JBDDIGBOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly FLHPMHGGOIG CHIJIFBLLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LLOPDIJAEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public EGNDMCLNBPC NMJMDIDDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int LKFKLKBHMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool PPIICCPEJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool IOOPKKKLILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KPMKCIBEJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NFNBNDKIIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IGCJLPHBJAJ CDLCBAIBMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int OMCEINIOKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object HPEGJFHCANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IGCJLPHBJAJ NBLOMCKFGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int GLJDPNOIKOL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int CIFEILFNCIK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int PMGKPPBDHGH = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JOBHENAPCGO DLLKCLBKAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private JOBHENAPCGO GDFHAPGJDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread LIBKEHMHCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread PFOHDMMFEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint BKFPAEELGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint PAFNJIGCCPK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] CBNOCHEFEKD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] BHEPEPNOCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<OBIAOFNCOGA, IPEndPoint> DCKLMOIDPHC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress LMJFAJGHPID;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool GIJMGIKOIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int ELIEAPFPICO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FEKDELNPDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD738B0", VA = "0x180D752B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE15FA0", Offset = "0xE145A0", VA = "0x180E15FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PDPABHKKELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1703E40", Offset = "0x1702440", VA = "0x181703E40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1A590B0", Offset = "0x1A576B0", VA = "0x181A590B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NOIBAOKDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB84F60", Offset = "0xB83560", VA = "0x180B84F60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BGIMGMBHJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DFD0", Offset = "0x5F8C5D0", VA = "0x185F8DFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short NJLHEFKPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A290", Offset = "0x5F88890", VA = "0x185F8A290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A500", Offset = "0x5F88B00", VA = "0x185F8A500")]
	public void KEAFDPELHLA(IPEndPoint COCCJPGAHOG, byte[] LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A3B0", Offset = "0x5F889B0", VA = "0x185F8A3B0")]
	public void JNALPNDJKLH(IPEndPoint COCCJPGAHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F894A0", Offset = "0x5F87AA0", VA = "0x185F894A0")]
	private bool HANIDKBOEIK(IPEndPoint COCCJPGAHOG, [Out] JOGDCLPCEJA OCLFKCJGOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F897D0", Offset = "0x5F87DD0", VA = "0x185F897D0")]
	private void HIBGFMBEDCC(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F87B70", Offset = "0x5F86170", VA = "0x185F87B70")]
	private void DGHHPKIMHCF(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F89530", Offset = "0x5F87B30", VA = "0x185F89530")]
	private void HBIFLGMHAFC(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E1D0", Offset = "0x5F8C7D0", VA = "0x185F8E1D0")]
	public HLFOIBHLJDH(INFNLCKMAGO MMPLGKEGKLF, [Optional] HDIHHAICNED DLFHNONAFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F87E50", Offset = "0x5F86450", VA = "0x185F87E50")]
	internal void EHELCBIMBCM(JOGDCLPCEJA LKNCMAPCPIK, int MCMKEGBLLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5F89780", Offset = "0x5F87D80", VA = "0x185F89780")]
	internal void HIALKOBGDGL(JOGDCLPCEJA LKNCMAPCPIK, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A720", Offset = "0x5F88D20", VA = "0x185F8A720")]
	internal void KIFLGAAJJCA(JOGDCLPCEJA OCLFKCJGOOI, DOGAPDHDCBD ONIANAELCBB, SocketError DDDKKMJBCNK, IGCJLPHBJAJ GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B000", Offset = "0x5F89600", VA = "0x185F8B000")]
	private void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI, DOGAPDHDCBD ONIANAELCBB, SocketError DDDKKMJBCNK, bool LENLJCDCMCG, byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG, IGCJLPHBJAJ GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F890E0", Offset = "0x5F876E0", VA = "0x185F890E0")]
	private void GHHEPHIGPCE(PNDEKBPIPKK.CKCHCKLDLJB JLAAKHANEHC, [Optional] JOGDCLPCEJA OCLFKCJGOOI, [Optional] IPEndPoint EGIABGNOHCN, SocketError JPKBMOOHKJG = SocketError.Success, int MCMKEGBLLJK = 0, DOGAPDHDCBD APBKCKKPFJJ = DOGAPDHDCBD.ConnectionFailed, [Optional] CLINOKNLAOH OFOCEJKBBKO, FLBEBOIBIEG ILLOHCPKDKP = FLBEBOIBIEG.Unreliable, byte OCDNIEKJOID = 0, [Optional] IGCJLPHBJAJ KHBGHAKEMLD, [Optional] object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D200", Offset = "0x5F8B800", VA = "0x185F8D200")]
	private void ONOEOEPJIGH(PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F87640", Offset = "0x5F85C40", VA = "0x185F87640")]
	internal void ALMPCACNLFA(PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F8BE10", Offset = "0x5F8A410", VA = "0x185F8BE10")]
	private void MLJHDIMLDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F87EA0", Offset = "0x5F864A0", VA = "0x185F87EA0")]
	private void EOGFDOILJKK(int HIDIFLAJJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D9C0", Offset = "0x5F8BFC0", VA = "0x185F8D9C0")]
	internal JOGDCLPCEJA OPOJEMIDANO(CLINOKNLAOH NEKCFCOLDAN, byte[] DNNJHFOGMMB, int OENMMCMOJOM, int KHMKAEGDPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A7F0", Offset = "0x5F88DF0", VA = "0x185F8A7F0")]
	private int KNEIPABGPEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AA30", Offset = "0x5F89030", VA = "0x185F8AA30")]
	private void KPAKFLFCLGO(IPEndPoint EGIABGNOHCN, JOGDCLPCEJA FDDIMNCICJM, AGJIJHGCHHI AMHKGLCFDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F8C370", Offset = "0x5F8A970", VA = "0x185F8C370")]
	private void NEBGEPDLAKC(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5F878B0", Offset = "0x5F85EB0", VA = "0x185F878B0")]
	internal void CNLIKCPIJOK(IGCJLPHBJAJ BHIJKPOILFM, FLBEBOIBIEG PDJPHJMJIMF, byte OCDNIEKJOID, int POIDBEGOOBB, JOGDCLPCEJA LKNCMAPCPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B280", Offset = "0x5F89880", VA = "0x185F8B280")]
	public bool LHKIFFPBGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B2F0", Offset = "0x5F898F0", VA = "0x185F8B2F0")]
	public bool LHKIFFPBGID(IPAddress IPEIJMCGJDA, IPAddress DJLNPGPGLAG, int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B310", Offset = "0x5F89910", VA = "0x185F8B310")]
	public bool LHKIFFPBGID(int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B0E0", Offset = "0x5F896E0", VA = "0x185F8B0E0")]
	public void LCOPDAEKBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5F89000", Offset = "0x5F87600", VA = "0x185F89000")]
	public JOGDCLPCEJA FFBLMBKMLDC(string LKGIJLGOFHC, int EHGIOJOEILB, string LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5F88F20", Offset = "0x5F87520", VA = "0x185F88F20")]
	public JOGDCLPCEJA FFBLMBKMLDC(string LKGIJLGOFHC, int EHGIOJOEILB, GDDHLOJHPLL GEAGHEFCPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F88B50", Offset = "0x5F87150", VA = "0x185F88B50")]
	public JOGDCLPCEJA FFBLMBKMLDC(IPEndPoint LLMCGMPLMBL, GDDHLOJHPLL GEAGHEFCPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5F887F0", Offset = "0x5F86DF0", VA = "0x185F887F0")]
	public void FCHFEKGILOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5F88800", Offset = "0x5F86E00", VA = "0x185F88800")]
	public void FCHFEKGILOJ(bool PLDDDMMFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5F8C270", Offset = "0x5F8A870", VA = "0x185F8C270")]
	public void MNOKOMIABBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5F8C150", Offset = "0x5F8A750", VA = "0x185F8C150")]
	public void MNOKOMIABBH(byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AE90", Offset = "0x5F89490", VA = "0x185F8AE90")]
	public void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5F8AF40", Offset = "0x5F89540", VA = "0x185F8AF40")]
	public void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI, byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5F8DFF0", Offset = "0x5F8C5F0", VA = "0x185F8DFF0", Slot = "4")]
	private IEnumerator<JOGDCLPCEJA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E080", Offset = "0x5F8C680", VA = "0x185F8E080", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A870", Offset = "0x5F88E70", VA = "0x185F8A870")]
	private IGCJLPHBJAJ KNICJKNINNE(OIMCJEHFCHC PKFJNPAMFMB, int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A950", Offset = "0x5F88F50", VA = "0x185F8A950")]
	private IGCJLPHBJAJ KNICJKNINNE(OIMCJEHFCHC PKFJNPAMFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F89E10", Offset = "0x5F88410", VA = "0x185F89E10")]
	internal IGCJLPHBJAJ IIDDFCFAHDL(int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A040", Offset = "0x5F88640", VA = "0x185F8A040")]
	internal void IKDECFPBCHC(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E110", Offset = "0x5F8C710", VA = "0x185F8E110")]
	static HLFOIBHLJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD738B0", VA = "0x180D752B0")]
	private bool OKKHPAEKBNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5F87D60", Offset = "0x5F86360", VA = "0x185F87D60")]
	private void EEPNOLAHLOK(IPEndPoint KDJIDLOGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5F8D120", Offset = "0x5F8B720", VA = "0x185F8D120")]
	private void OKOKCHLDCLO(IPEndPoint KDJIDLOGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5F87BC0", Offset = "0x5F861C0", VA = "0x185F87BC0")]
	private bool DLBIIHAJHBB(SocketException NJACFNFHNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5F8BB40", Offset = "0x5F8A140", VA = "0x185F8BB40")]
	private void MGNKCLCBDCL(JOBHENAPCGO PHJMMALGKEF, EndPoint MCDMDDJGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5F89A90", Offset = "0x5F88090", VA = "0x185F89A90")]
	private void IFCEMMAFDOE(object FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5F8B390", Offset = "0x5F89990", VA = "0x185F8B390")]
	public bool LHKIFFPBGID(IPAddress IPEIJMCGJDA, IPAddress DJLNPGPGLAG, int EHGIOJOEILB, bool GOHLJLFJLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5F8A350", Offset = "0x5F88950", VA = "0x185F8A350")]
	internal int JHDJEDJJAMJ(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5F881C0", Offset = "0x5F867C0", VA = "0x185F881C0")]
	internal int FAPPIALKEHC(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5F88200", Offset = "0x5F86800", VA = "0x185F88200")]
	internal int FAPPIALKEHC(byte[] KFAOBDLOMDC, int OENMMCMOJOM, int KHMKAEGDPPG, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5F87740", Offset = "0x5F85D40", VA = "0x185F87740")]
	internal void BKHDOBMNBDG(bool NNAHGOJAKNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum OIMCJEHFCHC : byte
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
internal sealed class IGCJLPHBJAJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int BFBPMPFADKI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] CIMCFMFAEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] FPFBBABGHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int KHAEIGABOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object FGBAFOAKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public IGCJLPHBJAJ FBNLOBKJFGM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public OIMCJEHFCHC LEMGFKOPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F300", Offset = "0x5F8D900", VA = "0x185F8F300")]
		get
		{
			return default(OIMCJEHFCHC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F440", Offset = "0x5F8DA40", VA = "0x185F8F440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte KJNAFDPHDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F4B0", Offset = "0x5F8DAB0", VA = "0x185F8F4B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F0F0", Offset = "0x5F8D6F0", VA = "0x185F8F0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort FCPPJJAFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F3E0", Offset = "0x5F8D9E0", VA = "0x185F8F3E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F3A0", Offset = "0x5F8D9A0", VA = "0x185F8F3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DEDAIJKOPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F0C0", Offset = "0x5F8D6C0", VA = "0x185F8F0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte MFIFIOHFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F480", Offset = "0x5F8DA80", VA = "0x185F8F480")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F130", Offset = "0x5F8D730", VA = "0x185F8F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort MLLICFCDPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F580", Offset = "0x5F8DB80", VA = "0x185F8F580")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F160", Offset = "0x5F8D760", VA = "0x185F8F160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort IOFDHNPKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F1A0", Offset = "0x5F8D7A0", VA = "0x185F8F1A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F540", Offset = "0x5F8DB40", VA = "0x185F8F540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MNCANGGAINI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F4E0", Offset = "0x5F8DAE0", VA = "0x185F8F4E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F330", Offset = "0x5F8D930", VA = "0x185F8F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F6E0", Offset = "0x5F8DCE0", VA = "0x185F8F6E0")]
	static IGCJLPHBJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F370", Offset = "0x5F8D970", VA = "0x185F8F370")]
	public void IHDJJCCPIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F9A0", Offset = "0x5F8DFA0", VA = "0x185F8F9A0")]
	public IGCJLPHBJAJ(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FA10", Offset = "0x5F8E010", VA = "0x185F8FA10")]
	public IGCJLPHBJAJ(OIMCJEHFCHC PKFJNPAMFMB, int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F290", Offset = "0x5F8D890", VA = "0x185F8F290")]
	public static int CGPDOBLCFAJ(OIMCJEHFCHC PKFJNPAMFMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F200", Offset = "0x5F8D800", VA = "0x185F8F200")]
	public int CGPDOBLCFAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F8F5E0", Offset = "0x5F8DBE0", VA = "0x185F8F5E0")]
	public bool PEEPLDCGABI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum CLGEGONOGBM : byte
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
internal enum DBGEGJIDFGD
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
internal enum KNENCLHDBIH
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OEBEBCMIDBO
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JOGDCLPCEJA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GPHCDMBNOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IGCJLPHBJAJ[] FHDOEKHCACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NKMDIFNEEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int GOLOHKOOMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte MFIFIOHFDLH;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GPHCDMBNOGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void JPLEHMNCBLA(ulong GCFBPDKMDOG, int NHKCICPFGHI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int HDDPGGFIFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int POIHEABMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int AANACKPGFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FMAKNGODHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KJCFAJIIHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GDLEANHENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int IPMENPPBJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GBJGCCMOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MEALFKLKHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FHGMCPMHGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object MDNGPMJOCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal JOGDCLPCEJA BGGMKHOMAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal JOGDCLPCEJA LCNOIHIDGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<IGCJLPHBJAJ> LJFNDHELEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CPNFNHHIPJF> OAFDOJLPAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CPNFNHHIPJF[] LKEOPHNCGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int PCMDLMLAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int OOOELPFILFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool LHOEIJGLCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int MBEAEDHBCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int FIPHFPJFEME;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int FGDMKIJBDGB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int KCEJKKPCAHM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object NLCEKIMIOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int JOPNLPJNOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GPHCDMBNOGJ> GLMJPECJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BECJPGFNKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly IGCJLPHBJAJ GMPPJBNGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int DAPDBHMCOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int DNDBHNGDLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint IDEOGDDGJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int BPHOAFPJGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int FCEMPOFFIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long PONIOOEBKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte LEANJFFJKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private CLGEGONOGBM MIIAJICKIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IGCJLPHBJAJ KDPKOHJFNGK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int KJKDGLEFOEE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LMNHGAFDNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly IGCJLPHBJAJ MDLMAFEGOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly IGCJLPHBJAJ LAOFMOJJOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly IGCJLPHBJAJ GNPBOMDJOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly IGCJLPHBJAJ HEBIGEEJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private MAMADBLBPMI LPHHIDOIPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly HLFOIBHLJDH LLKPCEGGMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int OMPMKCIPJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object PJLBCIMELMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly NIACNHDDOGI CEBGHKGAHNN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte POCGFBJFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA20A80", Offset = "0xA1F080", VA = "0x180A20A80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5F91C20", Offset = "0x5F90220", VA = "0x185F91C20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CKKEHAMMEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x93DC90", Offset = "0x93C290", VA = "0x18093DC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CLGEGONOGBM HGNDMOEAIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C8E40", VA = "0x1814CA840")]
		get
		{
			return default(CLGEGONOGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HNGOPFBLGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x885E50", Offset = "0x884450", VA = "0x180885E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GGAHCEIMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xE581F0", Offset = "0xE567F0", VA = "0x180E581F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1782740", Offset = "0x1780D40", VA = "0x181782740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BONKGLCOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5F93B60", Offset = "0x5F92160", VA = "0x185F93B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DJGLPOPOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x895290", Offset = "0x893890", VA = "0x180895290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double DHBAIBIIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D430", Offset = "0x1C9BA30", VA = "0x181C9D430")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JPLEHMNCBLA LONAGNAJMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F93D70", Offset = "0x5F92370", VA = "0x185F93D70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5F94990", Offset = "0x5F92F90", VA = "0x185F94990")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F94A40", Offset = "0x5F93040", VA = "0x185F94A40")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, IPEndPoint EGIABGNOHCN, int MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F92F50", Offset = "0x5F91550", VA = "0x185F92F50")]
	internal void KCMNNCKPOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F94960", Offset = "0x5F92F60", VA = "0x185F94960")]
	internal void PAOCEBJBIOP(IPEndPoint IPBFGDOPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F916D0", Offset = "0x5F8FCD0", VA = "0x185F916D0")]
	internal void BCLGGANCDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5F91B50", Offset = "0x5F90150", VA = "0x185F91B50")]
	private void CPKFNBKLMEF(int KLCOPGDKFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F94920", Offset = "0x5F92F20", VA = "0x185F94920")]
	private void ONGAACBOJAO(int KIFLDCBDHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F939B0", Offset = "0x5F91FB0", VA = "0x185F939B0")]
	private CPNFNHHIPJF LBLAJOINPKI(byte LBBGOBFOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F95070", Offset = "0x5F93670", VA = "0x185F95070")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, IPEndPoint EGIABGNOHCN, int MCAKFNPAKIL, byte ELLIJBJPLIA, GDDHLOJHPLL IKOHIFBJJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5F94E90", Offset = "0x5F93490", VA = "0x185F94E90")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, CLINOKNLAOH NEKCFCOLDAN, int MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F947B0", Offset = "0x5F92DB0", VA = "0x185F947B0")]
	internal void NFAOJHHDFBC(AGJIJHGCHHI AODBHOIDBHJ, byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F92F70", Offset = "0x5F91570", VA = "0x185F92F70")]
	internal bool KEMHMIINLOF(BFFDFNKPPGC BHIJKPOILFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F948F0", Offset = "0x5F92EF0", VA = "0x185F948F0")]
	public void OKFDICIBJAH(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, FLBEBOIBIEG CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5F92040", Offset = "0x5F90640", VA = "0x185F92040")]
	private void GFGFFFLLHOM(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, byte OCDNIEKJOID, FLBEBOIBIEG ILLOHCPKDKP, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5F94840", Offset = "0x5F92E40", VA = "0x185F94840")]
	public void OBAKEPHIELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F91760", Offset = "0x5F8FD60", VA = "0x185F91760")]
	internal KNENCLHDBIH BFKOFNGOIDC(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(KNENCLHDBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F92850", Offset = "0x5F90E50", VA = "0x185F92850")]
	internal void IOAABEBGHCC(CPNFNHHIPJF CLBPLOJAIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F91840", Offset = "0x5F8FE40", VA = "0x185F91840")]
	internal OEBEBCMIDBO CNJPPBMNIGO(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, bool LENLJCDCMCG)
	{
		return default(OEBEBCMIDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5F94800", Offset = "0x5F92E00", VA = "0x185F94800")]
	private void NPDNCKLNPCK(int PCIBJDLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F93E20", Offset = "0x5F92420", VA = "0x185F93E20")]
	internal void NDBMCDNNGFL(FLBEBOIBIEG PDJPHJMJIMF, IGCJLPHBJAJ FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F92A00", Offset = "0x5F91000", VA = "0x185F92A00")]
	private void JOFDANFCKEO(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F91CD0", Offset = "0x5F902D0", VA = "0x185F91CD0")]
	private void FPEHEADPFNL(int BKOJCILPMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5F937F0", Offset = "0x5F91DF0", VA = "0x185F937F0")]
	internal DBGEGJIDFGD KPAKFLFCLGO(AGJIJHGCHHI AMHKGLCFDLB)
	{
		return default(DBGEGJIDFGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F91020", Offset = "0x5F8F620", VA = "0x185F91020")]
	internal void AOMMBBLGMIA(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F928B0", Offset = "0x5F90EB0", VA = "0x185F928B0")]
	private void JINMINIJHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F93B70", Offset = "0x5F92170", VA = "0x185F93B70")]
	internal void LNLAFCKPMAI(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F92FF0", Offset = "0x5F915F0", VA = "0x185F92FF0")]
	internal void KOLHFLEMELG(int BKOJCILPMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F92590", Offset = "0x5F90B90", VA = "0x185F92590")]
	internal void IMMIDNFOAGD(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NIACNHDDOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long ENEPFBCLHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long DFKAAMIJIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long AEFGNLPHKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DLCDODMPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long JALHIDBIJEG;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long ELBENDPELBA;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long EEJDGADBMBP;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long JIMAGBCEGFI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long OBFBHJBKIEK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long HGMGLOOJGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JCLKPMMALGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long LNFHFOJACEL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MLAGFJDBIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F98310", Offset = "0x5F96910", VA = "0x185F98310")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GFBGPJCJLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5F984A0", Offset = "0x5F96AA0", VA = "0x185F984A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long ELNBEBIDGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F98050", Offset = "0x5F96650", VA = "0x185F98050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long BCPKKLBOLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F98200", Offset = "0x5F96800", VA = "0x185F98200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long EACEMFIJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F984B0", Offset = "0x5F96AB0", VA = "0x185F984B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long OGHPCKJCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5F98320", Offset = "0x5F96920", VA = "0x185F98320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long CCLKOLFICJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F981C0", Offset = "0x5F967C0", VA = "0x185F981C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long EIIOODBDALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5F98060", Offset = "0x5F96660", VA = "0x185F98060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MAMADBLBPMI KNFHGHGODGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5F983F0", Offset = "0x5F969F0", VA = "0x185F983F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double DCEDGAHLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5F98440", Offset = "0x5F96A40", VA = "0x185F98440")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F98400", Offset = "0x5F96A00", VA = "0x185F98400")]
	public void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F982B0", Offset = "0x5F968B0", VA = "0x185F982B0")]
	public void JBOIJIHDHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5F98170", Offset = "0x5F96770", VA = "0x185F98170")]
	public void GDNHBPAMHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F98330", Offset = "0x5F96930", VA = "0x185F98330")]
	public void KHBAPPACMOO(long JDEPFGEKEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F98110", Offset = "0x5F96710", VA = "0x185F98110")]
	public void EKPIHMNHCEE(long NMAFMPBJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F98390", Offset = "0x5F96990", VA = "0x185F98390")]
	public void KILAFPFKHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F980A0", Offset = "0x5F966A0", VA = "0x185F980A0")]
	public void DNFBEIKJOEJ(long OPFBMGDJKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F984C0", Offset = "0x5F96AC0", VA = "0x185F984C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F98210", Offset = "0x5F96810", VA = "0x185F98210")]
	public void IDPEMJCPACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public NIACNHDDOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LNCILMNFPMP
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> EJFPFBHGMOO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F962F0", Offset = "0x5F948F0", VA = "0x185F962F0")]
	public static IPEndPoint AOMAGPBJPJA(string PMHDCFBHNIM, int EHGIOJOEILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F96540", Offset = "0x5F94B40", VA = "0x185F96540")]
	public static IPAddress ECKLGJEFMBN(string PMHDCFBHNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F96710", Offset = "0x5F94D10", VA = "0x185F96710")]
	public static IPAddress ECKLGJEFMBN(string PMHDCFBHNIM, AddressFamily AIADLOOADGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F967A0", Offset = "0x5F94DA0", VA = "0x185F967A0")]
	internal static int KLFKDJENMPA(int HELKFKEKCOK, int AKPJMLDDHEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D7D990", Offset = "0x2D7BF90", VA = "0x182D7D990")]
	internal static T[] CHGLFPIDPPJ<T>(int FIGHABPEBPG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LBFGCCNJJJC : CPNFNHHIPJF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct ALCIDEBBMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private IGCJLPHBJAJ FPFOIPDHLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long IFKHDLOJLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool PDJLAJBNJOO;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5F83920", Offset = "0x5F81F20", VA = "0x185F83920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F83840", Offset = "0x5F81E40", VA = "0x185F83840")]
		public void AMLGEKNOMHA(IGCJLPHBJAJ BHIJKPOILFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F83860", Offset = "0x5F81E60", VA = "0x185F83860")]
		public bool LAPIIOBGIPI(long AINNCKMHEPN, JOGDCLPCEJA OCLFKCJGOOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F838D0", Offset = "0x5F81ED0", VA = "0x185F838D0")]
		public bool MPAAPCHGDCP(JOGDCLPCEJA OCLFKCJGOOI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly IGCJLPHBJAJ BCMPBHHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly ALCIDEBBMBP[] JEKBCOGNDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly IGCJLPHBJAJ[] GLJMMBIGKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] CFKEKMIICCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int AIOMAIAIKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int OKJLMCLEJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int LJHJDPKJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int BEPGBIHFKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool PGCKABFHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FLBEBOIBIEG HIKCIDIFEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool JJEKLKNABMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int DAHHLAFNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte JIHOIDIGFOB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F960B0", Offset = "0x5F946B0", VA = "0x185F960B0")]
	public LBFGCCNJJJC(JOGDCLPCEJA OCLFKCJGOOI, bool KKMBPOPPCGC, byte MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F95860", Offset = "0x5F93E60", VA = "0x185F95860")]
	private void OANPBEFNKPI(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F95C00", Offset = "0x5F94200", VA = "0x185F95C00", Slot = "4")]
	protected override bool OEBPFPLLJIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F95200", Offset = "0x5F93800", VA = "0x185F95200", Slot = "5")]
	public override bool AOMMBBLGMIA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class AGNCEELJCGC : CPNFNHHIPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int EEECIPHAFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort OKJLMCLEJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool KLDAFCPFDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private IGCJLPHBJAJ JBGJABCGJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly IGCJLPHBJAJ OPKGOIMAICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool EPCLIMFICPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte JIHOIDIGFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long AHDNKKNGCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5F836B0", Offset = "0x5F81CB0", VA = "0x185F836B0")]
	public AGNCEELJCGC(JOGDCLPCEJA OCLFKCJGOOI, bool CNHIBLBICFI, byte MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5F831F0", Offset = "0x5F817F0", VA = "0x185F831F0", Slot = "4")]
	protected override bool OEBPFPLLJIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5F82F10", Offset = "0x5F81510", VA = "0x185F82F10", Slot = "5")]
	public override bool AOMMBBLGMIA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BEBBJOHMMPM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OFFNBHPMKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong OEMAGMPLPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double BHJKPMNGJMF;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct IMONIFCCBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int LPGCOKPFJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float PBKAPDGGDON;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5F82460", Offset = "0x5F80A60", VA = "0x185F82460")]
	private static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, ulong JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5F83AB0", Offset = "0x5F820B0", VA = "0x185F83AB0")]
	private static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5F83A60", Offset = "0x5F82060", VA = "0x185F83A60")]
	public static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, short JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5F839C0", Offset = "0x5F81FC0", VA = "0x185F839C0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, double KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5F839E0", Offset = "0x5F81FE0", VA = "0x185F839E0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F83A60", Offset = "0x5F82060", VA = "0x185F83A60")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, short KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5F83A60", Offset = "0x5F82060", VA = "0x185F83A60")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, ushort KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5F83AB0", Offset = "0x5F820B0", VA = "0x185F83AB0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5F83AB0", Offset = "0x5F820B0", VA = "0x185F83AB0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, uint KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5F83AA0", Offset = "0x5F820A0", VA = "0x185F83AA0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F83AA0", Offset = "0x5F820A0", VA = "0x185F83AA0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, ulong KLABJGGMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PKILOIGDLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] JBPNOBDOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int KKONDJDNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int DHFJAJNIHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int CILCHLPEBKF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] FPFBBABGHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NENGGNJJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EMKELOPEICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5F98CB0", Offset = "0x5F972B0", VA = "0x185F98CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DGEOHMJGPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FBADB0", Offset = "0x1FB93B0", VA = "0x181FBADB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PBPFFLDOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F99460", Offset = "0x5F97A60", VA = "0x185F99460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5F99570", Offset = "0x5F97B70", VA = "0x185F99570")]
	public void MPOJAPNIAAF(byte[] MKLJJBDOOGE, int IEHCONIHMPO, int GIJEEPMKODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public PKILOIGDLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5F99660", Offset = "0x5F97C60", VA = "0x185F99660")]
	public PKILOIGDLDE(byte[] MKLJJBDOOGE, int IEHCONIHMPO, int GIJEEPMKODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5F99270", Offset = "0x5F97870", VA = "0x185F99270")]
	public IPEndPoint JBPNHLBJJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D80", Offset = "0x5F97380", VA = "0x185F98D80")]
	public byte NPLMJCMCJKF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D80", Offset = "0x5F97380", VA = "0x185F98D80")]
	public sbyte DALFHDIOHIM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E67280", Offset = "0x2E65880", VA = "0x182E67280")]
	public T[] EDODIKJEPFD<T>(ushort BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5F98FA0", Offset = "0x5F975A0", VA = "0x185F98FA0")]
	public bool[] ENIDKJGJEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D40", Offset = "0x5F97340", VA = "0x185F98D40")]
	public ushort[] BGECFKLCFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5F990D0", Offset = "0x5F976D0", VA = "0x185F990D0")]
	public short[] GBNMEANACMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5F995B0", Offset = "0x5F97BB0", VA = "0x185F995B0")]
	public int[] NDDKCNCAIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F99110", Offset = "0x5F97710", VA = "0x185F99110")]
	public uint[] GGHHHFMAIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F99090", Offset = "0x5F97690", VA = "0x185F99090")]
	public float[] FMOPHLHDCIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D00", Offset = "0x5F97300", VA = "0x185F98D00")]
	public double[] ADCKLMJDDHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5F99050", Offset = "0x5F97650", VA = "0x185F99050")]
	public long[] FDGHBJAFHPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F99230", Offset = "0x5F97830", VA = "0x185F99230")]
	public ulong[] IOHELNEEHGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5F98E70", Offset = "0x5F97470", VA = "0x185F98E70")]
	public string[] EIPBNLCCILP(int LOJCKNMLPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5F98E30", Offset = "0x5F97430", VA = "0x185F98E30")]
	public bool EIFNAAKGFFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5F99150", Offset = "0x5F97750", VA = "0x185F99150")]
	public char GONLCMGFPMP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5F99150", Offset = "0x5F97750", VA = "0x185F99150")]
	public ushort IGNPEAKMHHC()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5F993F0", Offset = "0x5F979F0", VA = "0x185F993F0")]
	public short KPJBALKOLAF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5F991C0", Offset = "0x5F977C0", VA = "0x185F991C0")]
	public long HCEANOIHCHK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5F98FE0", Offset = "0x5F975E0", VA = "0x185F98FE0")]
	public ulong FCKMKKPEOAI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F995F0", Offset = "0x5F97BF0", VA = "0x185F995F0")]
	public int OAOEEFCMBOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5F994E0", Offset = "0x5F97AE0", VA = "0x185F994E0")]
	public uint MHBCIAHHBLM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F99470", Offset = "0x5F97A70", VA = "0x185F99470")]
	public float MFDIJFDHPGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F99340", Offset = "0x5F97940", VA = "0x185F99340")]
	public double JFHDKAKELCP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F98A80", Offset = "0x5F97080", VA = "0x185F98A80")]
	public string ABBOAADIAKE(int DOBHOIOIHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F98DC0", Offset = "0x5F973C0", VA = "0x185F98DC0")]
	public ArraySegment<byte> EIFLJIGOKFP(int FIGHABPEBPG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F993B0", Offset = "0x5F979B0", VA = "0x185F993B0")]
	public sbyte[] KILFGEFPNCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F98CC0", Offset = "0x5F972C0", VA = "0x185F98CC0")]
	public byte[] ACHECFPMIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5F99550", Offset = "0x5F97B50", VA = "0x185F99550")]
	public void MPAAPCHGDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GDDHLOJHPLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] JBPNOBDOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int KKONDJDNPAO;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int NGCMKBDHEJO = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool PPDPACNCELB;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding EBLKEBEOCBI;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int MINIMMCOONJ = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] OMMLELPJAGA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] MJHCHFCOEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5F86980", Offset = "0x5F84F80", VA = "0x185F86980")]
	public GDDHLOJHPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5F86A00", Offset = "0x5F85000", VA = "0x185F86A00")]
	public GDDHLOJHPLL(bool HLLIEAEAPND, int ELEBLFBMJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5F86890", Offset = "0x5F84E90", VA = "0x185F86890")]
	public static GDDHLOJHPLL PEHDMGJNKEM(string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5F867F0", Offset = "0x5F84DF0", VA = "0x185F867F0")]
	public void NCDLHGPFAJE(int IEHKAGPEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x20342F0", Offset = "0x20328F0", VA = "0x1820342F0")]
	public void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5F86550", Offset = "0x5F84B50", VA = "0x185F86550")]
	public void HHOJKOPNNFC(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5F865F0", Offset = "0x5F84BF0", VA = "0x185F865F0")]
	public void HHOJKOPNNFC(double KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5F86220", Offset = "0x5F84820", VA = "0x185F86220")]
	public void HHOJKOPNNFC(long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5F86220", Offset = "0x5F84820", VA = "0x185F86220")]
	public void HHOJKOPNNFC(ulong KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5F86190", Offset = "0x5F84790", VA = "0x185F86190")]
	public void HHOJKOPNNFC(int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5F86190", Offset = "0x5F84790", VA = "0x185F86190")]
	public void HHOJKOPNNFC(uint KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5F86270", Offset = "0x5F84870", VA = "0x185F86270")]
	public void HHOJKOPNNFC(char KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5F86270", Offset = "0x5F84870", VA = "0x185F86270")]
	public void HHOJKOPNNFC(ushort KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5F86270", Offset = "0x5F84870", VA = "0x185F86270")]
	public void HHOJKOPNNFC(short KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5F862E0", Offset = "0x5F848E0", VA = "0x185F862E0")]
	public void HHOJKOPNNFC(sbyte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5F862E0", Offset = "0x5F848E0", VA = "0x185F862E0")]
	public void HHOJKOPNNFC(byte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5F86720", Offset = "0x5F84D20", VA = "0x185F86720")]
	public void HHOJKOPNNFC(byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5F85C60", Offset = "0x5F84260", VA = "0x185F85C60")]
	public void CEIIPIGOIBK(sbyte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5F85C60", Offset = "0x5F84260", VA = "0x185F85C60")]
	public void GFNLFAEFDEB(byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5F86790", Offset = "0x5F84D90", VA = "0x185F86790")]
	public void HHOJKOPNNFC(bool KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F85FD0", Offset = "0x5F845D0", VA = "0x185F85FD0")]
	public void DFJOIBDEJEB(Array OLFJJNHNEOC, int CBNJMEBNJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F85E20", Offset = "0x5F84420", VA = "0x185F85E20")]
	public void DFJOIBDEJEB(float[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F85D40", Offset = "0x5F84340", VA = "0x185F85D40")]
	public void DFJOIBDEJEB(double[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5F85D40", Offset = "0x5F84340", VA = "0x185F85D40")]
	public void DFJOIBDEJEB(long[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F85D40", Offset = "0x5F84340", VA = "0x185F85D40")]
	public void DFJOIBDEJEB(ulong[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5F85E20", Offset = "0x5F84420", VA = "0x185F85E20")]
	public void DFJOIBDEJEB(int[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5F85E20", Offset = "0x5F84420", VA = "0x185F85E20")]
	public void DFJOIBDEJEB(uint[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5F860B0", Offset = "0x5F846B0", VA = "0x185F860B0")]
	public void DFJOIBDEJEB(ushort[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5F860B0", Offset = "0x5F846B0", VA = "0x185F860B0")]
	public void DFJOIBDEJEB(short[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5F85C60", Offset = "0x5F84260", VA = "0x185F85C60")]
	public void DFJOIBDEJEB(bool[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5F85F00", Offset = "0x5F84500", VA = "0x185F85F00")]
	public void DFJOIBDEJEB(string[] KLABJGGMBGH, int LHLAMDPNODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5F86650", Offset = "0x5F84C50", VA = "0x185F86650")]
	public void HHOJKOPNNFC(IPEndPoint COCCJPGAHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5F86640", Offset = "0x5F84C40", VA = "0x185F86640")]
	public void HHOJKOPNNFC(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F86340", Offset = "0x5F84940", VA = "0x185F86340")]
	public void HHOJKOPNNFC(string KLABJGGMBGH, int DOBHOIOIHAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GHDPNEGIGIO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class EKFLIANCAJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong OMPMKCIPJEE;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3965210", Offset = "0x3963810", VA = "0x183965210")]
		static EKFLIANCAJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BPPMFMKMAGB(PKILOIGDLDE JEAKAGANOAM, object KHBHLJCCBLL);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NEDFPECCBCC<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public GHDPNEGIGIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NEDFPECCBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4707620", Offset = "0x4705C20", VA = "0x184707620")]
		internal void NFFAGJICLOM(PKILOIGDLDE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LIKCNONKGCI<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public GHDPNEGIGIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public LIKCNONKGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x43FD930", Offset = "0x43FBF30", VA = "0x1843FD930")]
		internal void NFFAGJICLOM(PKILOIGDLDE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly OAGLOFGPGJB DBBJODNBLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, BPPMFMKMAGB> EDHCKKIDLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly GDDHLOJHPLL IFHDHGLOFFJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5F86CA0", Offset = "0x5F852A0", VA = "0x185F86CA0")]
	public GHDPNEGIGIO(int LOJCKNMLPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C8C0", Offset = "0x2A0AEC0", VA = "0x182A0C8C0", Slot = "4")]
	protected virtual ulong IEIANCELHGK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5F86B20", Offset = "0x5F85120", VA = "0x185F86B20", Slot = "5")]
	protected virtual BPPMFMKMAGB JBILEDMMMIE(PKILOIGDLDE JEAKAGANOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD9C0", Offset = "0x2CBBFC0", VA = "0x182CBD9C0", Slot = "6")]
	protected virtual void CHEHIACHMPP<T>(GDDHLOJHPLL NFLODIHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5F86AA0", Offset = "0x5F850A0", VA = "0x185F86AA0")]
	public void IABHIPJBNIM(PKILOIGDLDE JEAKAGANOAM, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDDB0", Offset = "0x2CBC3B0", VA = "0x182CBDDB0")]
	public void GMAKAKDGBAO<T>(GDDHLOJHPLL NFLODIHODLH, T BHIJKPOILFM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5F86C50", Offset = "0x5F85250", VA = "0x185F86C50")]
	public void LLIFKAJEMLF(PKILOIGDLDE JEAKAGANOAM, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDBF0", Offset = "0x2CBC1F0", VA = "0x182CBDBF0")]
	public void FBELDPGCPDF<T>(Action<T> MLJIACDBHFH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDA30", Offset = "0x2CBC030", VA = "0x182CBDA30")]
	public void FBELDPGCPDF<T, TUserData>(Action<T, TUserData> MLJIACDBHFH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ECGLAELGPHM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5F841D0", Offset = "0x5F827D0", VA = "0x185F841D0")]
	public ECGLAELGPHM(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FLEPOIGDNBJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5F851C0", Offset = "0x5F837C0", VA = "0x185F851C0")]
	public FLEPOIGDNBJ(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OAGLOFGPGJB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum MFLEMJFBBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class ACIANJCOFEI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MFLEMJFBBLJ EMAFAACIGEH;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CE20", Offset = "0x3D8B420", VA = "0x183D8CE20", Slot = "4")]
		public virtual void AMLGEKNOMHA(MethodInfo NBJFCJLOEFB, MethodInfo AOINJBCMIHF, MFLEMJFBBLJ JLAAKHANEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HAOEIECHALI(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void BJBIFECFJFH(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		protected ACIANJCOFEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CILLPCCIEME<TClass, TProperty> : ACIANJCOFEI<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> ICMICFDMBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> MCDODCNNPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> BCIALFCBLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> EEBODFHMGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> EKNDANKDAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> IHICMNAPEHE;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x55AFF40", Offset = "0x55AE540", VA = "0x1855AFF40", Slot = "7")]
		public override void GHBCPJJLPGK(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x55B1710", Offset = "0x55AFD10", VA = "0x1855B1710", Slot = "8")]
		public override void KOEEPLGHGJB(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x55B0C60", Offset = "0x55AF260", VA = "0x1855B0C60", Slot = "9")]
		public override void HAOEIECHALI(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x55AEFE0", Offset = "0x55AD5E0", VA = "0x1855AEFE0", Slot = "10")]
		public override void BJBIFECFJFH(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x55B0F00", Offset = "0x55AF500", VA = "0x1855B0F00")]
		protected TProperty[] ICAJGCKCIDM(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x55AF7C0", Offset = "0x55ADDC0", VA = "0x1855AF7C0")]
		protected TProperty[] EPKLLLGNKGM(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x55AB240", Offset = "0x55A9840", VA = "0x1855AB240", Slot = "4")]
		public override void AMLGEKNOMHA(MethodInfo NBJFCJLOEFB, MethodInfo AOINJBCMIHF, MFLEMJFBBLJ JLAAKHANEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F58FE0", Offset = "0x3F575E0", VA = "0x183F58FE0")]
		protected CILLPCCIEME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ENIFPDMDOPI<TClass, TProperty> : CILLPCCIEME<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KCBIGHDDOGB(PKILOIGDLDE CGJIPKMEOFC, [Out] TProperty OLLAHGLHFDA);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void NMBCLGAHMDP(GDDHLOJHPLL BPBILCHNBCA, TProperty OLLAHGLHFDA);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3986C00", Offset = "0x3985200", VA = "0x183986C00", Slot = "5")]
		public override void GAPGEIOILGP(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3986EB0", Offset = "0x39854B0", VA = "0x183986EB0", Slot = "6")]
		public override void GMAKAKDGBAO(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3986D60", Offset = "0x3985360", VA = "0x183986D60", Slot = "7")]
		public override void GHBCPJJLPGK(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3987000", Offset = "0x3985600", VA = "0x183987000", Slot = "8")]
		public override void KOEEPLGHGJB(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x39870C0", Offset = "0x39856C0", VA = "0x1839870C0")]
		protected ENIFPDMDOPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class NKABCFIODPI<T> : CILLPCCIEME<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4726B30", Offset = "0x4725130", VA = "0x184726B30", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3E89820", Offset = "0x3E87E20", VA = "0x183E89820", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4726BB0", Offset = "0x47251B0", VA = "0x184726BB0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3E89890", Offset = "0x3E87E90", VA = "0x183E89890", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public NKABCFIODPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HLHMMAHLJON<T> : CILLPCCIEME<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3E89720", Offset = "0x3E87D20", VA = "0x183E89720", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E89820", Offset = "0x3E87E20", VA = "0x183E89820", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3E897A0", Offset = "0x3E87DA0", VA = "0x183E897A0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E89890", Offset = "0x3E87E90", VA = "0x183E89890", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public HLHMMAHLJON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class GLBAFLIBEAH<T> : CILLPCCIEME<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3DF52C0", Offset = "0x3DF38C0", VA = "0x183DF52C0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DF53C0", Offset = "0x3DF39C0", VA = "0x183DF53C0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5340", Offset = "0x3DF3940", VA = "0x183DF5340", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5430", Offset = "0x3DF3A30", VA = "0x183DF5430", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public GLBAFLIBEAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DGPBBDKGIJF<T> : CILLPCCIEME<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5A57A40", Offset = "0x5A56040", VA = "0x185A57A40", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF53C0", Offset = "0x3DF39C0", VA = "0x183DF53C0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5A57AC0", Offset = "0x5A560C0", VA = "0x185A57AC0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5430", Offset = "0x3DF3A30", VA = "0x183DF5430", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public DGPBBDKGIJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CGBLGMGAFOG<T> : CILLPCCIEME<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x54C4590", Offset = "0x54C2B90", VA = "0x1854C4590", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x472E430", Offset = "0x472CA30", VA = "0x18472E430", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x54C4610", Offset = "0x54C2C10", VA = "0x1854C4610", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E921F0", Offset = "0x3E907F0", VA = "0x183E921F0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public CGBLGMGAFOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NMDKPPMNNFO<T> : CILLPCCIEME<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x472E330", Offset = "0x472C930", VA = "0x18472E330", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x472E430", Offset = "0x472CA30", VA = "0x18472E430", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x472E3B0", Offset = "0x472C9B0", VA = "0x18472E3B0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E921F0", Offset = "0x3E907F0", VA = "0x183E921F0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public NMDKPPMNNFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class KCENHFCDOJD<T> : CILLPCCIEME<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E692A0", Offset = "0x3E678A0", VA = "0x183E692A0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E693A0", Offset = "0x3E679A0", VA = "0x183E693A0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x433B8B0", Offset = "0x4339EB0", VA = "0x18433B8B0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E69410", Offset = "0x3E67A10", VA = "0x183E69410", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public KCENHFCDOJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HBNLNCIJLGC<T> : CILLPCCIEME<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E692A0", Offset = "0x3E678A0", VA = "0x183E692A0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E693A0", Offset = "0x3E679A0", VA = "0x183E693A0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E69320", Offset = "0x3E67920", VA = "0x183E69320", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E69410", Offset = "0x3E67A10", VA = "0x183E69410", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public HBNLNCIJLGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CKONHKHDKPJ<T> : CILLPCCIEME<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x56B1990", Offset = "0x56AFF90", VA = "0x1856B1990", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x56B1A90", Offset = "0x56B0090", VA = "0x1856B1A90", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x56B1A10", Offset = "0x56B0010", VA = "0x1856B1A10", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E89890", Offset = "0x3E87E90", VA = "0x183E89890", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public CKONHKHDKPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HOOPCCOJLJI<T> : CILLPCCIEME<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E92080", Offset = "0x3E90680", VA = "0x183E92080", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E92180", Offset = "0x3E90780", VA = "0x183E92180", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E92100", Offset = "0x3E90700", VA = "0x183E92100", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E921F0", Offset = "0x3E907F0", VA = "0x183E921F0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public HOOPCCOJLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NEACBDLCGHD<T> : CILLPCCIEME<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x47071C0", Offset = "0x47057C0", VA = "0x1847071C0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x47072C0", Offset = "0x47058C0", VA = "0x1847072C0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4707240", Offset = "0x4705840", VA = "0x184707240", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E69410", Offset = "0x3E67A10", VA = "0x183E69410", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCEA0", Offset = "0x3DDB4A0", VA = "0x183DDCEA0")]
		public NEACBDLCGHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BIMDKHKMJGH<T> : ENIFPDMDOPI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x50977B0", Offset = "0x5095DB0", VA = "0x1850977B0", Slot = "12")]
		protected override void NMBCLGAHMDP(GDDHLOJHPLL BPBILCHNBCA, char OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5097780", Offset = "0x5095D80", VA = "0x185097780", Slot = "11")]
		protected override void KCBIGHDDOGB(PKILOIGDLDE CGJIPKMEOFC, [Out] char OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A200", Offset = "0x3D88800", VA = "0x183D8A200")]
		public BIMDKHKMJGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class MFGJNIAHCKE<T> : ENIFPDMDOPI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x468FE60", Offset = "0x468E460", VA = "0x18468FE60", Slot = "12")]
		protected override void NMBCLGAHMDP(GDDHLOJHPLL BPBILCHNBCA, IPEndPoint OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x468FE20", Offset = "0x468E420", VA = "0x18468FE20", Slot = "11")]
		protected override void KCBIGHDDOGB(PKILOIGDLDE CGJIPKMEOFC, [Out] IPEndPoint OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A200", Offset = "0x3D88800", VA = "0x183D8A200")]
		public MFGJNIAHCKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KNLDJPEIECA<T> : CILLPCCIEME<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int LNHGDJKJLFB;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x436F2F0", Offset = "0x436D8F0", VA = "0x18436F2F0")]
		public KNLDJPEIECA(int DOBHOIOIHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x436F0F0", Offset = "0x436D6F0", VA = "0x18436F0F0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x436F1F0", Offset = "0x436D7F0", VA = "0x18436F1F0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x436F170", Offset = "0x436D770", VA = "0x18436F170", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x436F270", Offset = "0x436D870", VA = "0x18436F270", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OOACMFCFDEP<T> : ACIANJCOFEI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo LEMGFKOPIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type BJMMOGDMDIN;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x48361B0", Offset = "0x48347B0", VA = "0x1848361B0")]
		public OOACMFCFDEP(PropertyInfo PKFJNPAMFMB, Type HNOODGILILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4835F20", Offset = "0x4834520", VA = "0x184835F20", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4836040", Offset = "0x4834640", VA = "0x184836040", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4835FE0", Offset = "0x48345E0", VA = "0x184835FE0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4836150", Offset = "0x4834750", VA = "0x184836150", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x48360F0", Offset = "0x48346F0", VA = "0x1848360F0", Slot = "9")]
		public override void HAOEIECHALI(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4835EC0", Offset = "0x48344C0", VA = "0x184835EC0", Slot = "10")]
		public override void BJBIFECFJFH(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FHPJNDCKILL<T> : OOACMFCFDEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
		public FHPJNDCKILL(PropertyInfo PKFJNPAMFMB, Type HNOODGILILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D23610", Offset = "0x3D21C10", VA = "0x183D23610", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D236D0", Offset = "0x3D21CD0", VA = "0x183D236D0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class FPIJGDNPHNC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static FPIJGDNPHNC<T> DFEEMNKDOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly ACIANJCOFEI<T>[] DAJPDNMEDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int INPCNHHOMKG;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D41190", Offset = "0x3D3F790", VA = "0x183D41190")]
		public FPIJGDNPHNC(List<ACIANJCOFEI<T>> LFHCNPKDJNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D410E0", Offset = "0x3D3F6E0", VA = "0x183D410E0")]
		public void GMAKAKDGBAO(T GHMNBJIOGAM, GDDHLOJHPLL NFLODIHODLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D41030", Offset = "0x3D3F630", VA = "0x183D41030")]
		public void GAPGEIOILGP(T GHMNBJIOGAM, PKILOIGDLDE JEAKAGANOAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class AMGCPBMMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ACIANJCOFEI<T> PBGHNKGJFJB<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private GDDHLOJHPLL MEHAIAOMDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int ILPGDPHPPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, AMGCPBMMDEB> MJAJABJPAHG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F98800", Offset = "0x5F96E00", VA = "0x185F98800")]
	public OAGLOFGPGJB(int LOJCKNMLPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A460", Offset = "0x2E38A60", VA = "0x182E3A460")]
	private FPIJGDNPHNC<T> OJLHALDDCEP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A11D90", Offset = "0x2A10390", VA = "0x182A11D90")]
	public void JJJMHPMEAIK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A3C0", Offset = "0x2E389C0", VA = "0x182E3A3C0")]
	public bool CENBFOHJAFB<T>(PKILOIGDLDE JEAKAGANOAM, T LLMCGMPLMBL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A330", Offset = "0x2E38930", VA = "0x182E3A330")]
	public void AMCHBAGBIFH<T>(GDDHLOJHPLL NFLODIHODLH, T GHMNBJIOGAM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IOKBCLOJJIH
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime FKIBCBDFKLC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] LLPJDGLJBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CDOFKNGAHHG HDMPNOOKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FD30", Offset = "0x5F8E330", VA = "0x185F8FD30")]
		get
		{
			return default(CDOFKNGAHHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PIGIHDPANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FD60", Offset = "0x5F8E360", VA = "0x185F8FD60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FC90", Offset = "0x5F8E290", VA = "0x185F8FC90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KGCAFEIIDLI EMGADGGKFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FCD0", Offset = "0x5F8E2D0", VA = "0x185F8FCD0")]
		get
		{
			return default(KGCAFEIIDLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F901F0", Offset = "0x5F8E7F0", VA = "0x185F901F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FPOMJLHMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F908E0", Offset = "0x5F8EEE0", VA = "0x185F908E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint CACMOODPKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F90B70", Offset = "0x5F8F170", VA = "0x185F90B70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? FHECLHLDILE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FD00", Offset = "0x5F8E300", VA = "0x185F8FD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? NKNIOCLJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5F90430", Offset = "0x5F8EA30", VA = "0x185F90430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KGABLCBDBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F90B40", Offset = "0x5F8F140", VA = "0x185F90B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F90970", Offset = "0x5F8EF70", VA = "0x185F90970")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? ENFIOPIAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC16FA0", Offset = "0xC155A0", VA = "0x180C16FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5F90D00", Offset = "0x5F8F300", VA = "0x185F90D00")]
	public IOKBCLOJJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F90C50", Offset = "0x5F8F250", VA = "0x185F90C50")]
	internal IOKBCLOJJIH(byte[] CNGBPDKMHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F90460", Offset = "0x5F8EA60", VA = "0x185F90460")]
	public static IOKBCLOJJIH GAHLIHALLKP(byte[] CNGBPDKMHBB, DateTime NJNIMMDEFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F90230", Offset = "0x5F8E830", VA = "0x185F90230")]
	internal void EMLIELIPOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FF60", Offset = "0x5F8E560", VA = "0x185F8FF60")]
	private void DHGFMPDNCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F906E0", Offset = "0x5F8ECE0", VA = "0x185F906E0")]
	private DateTime? GLOJKIKEPCL(int IEHCONIHMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FD90", Offset = "0x5F8E390", VA = "0x185F8FD90")]
	private void DFEJIOCEMFN(int IEHCONIHMPO, DateTime? KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F90580", Offset = "0x5F8EB80", VA = "0x185F90580")]
	private ulong GLKLILFPPJI(int IEHCONIHMPO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F90130", Offset = "0x5F8E730", VA = "0x185F90130")]
	private void DIHDNKBLFJB(int IEHCONIHMPO, ulong KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5F90650", Offset = "0x5F8EC50", VA = "0x185F90650")]
	private uint GLLNBDOANIG(int IEHCONIHMPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E57E10", Offset = "0x5E56410", VA = "0x185E57E10")]
	private static uint KMCANCFIHCE(uint NCPIGLMANIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F90910", Offset = "0x5F8EF10", VA = "0x185F90910")]
	private static ulong KMCANCFIHCE(ulong NCPIGLMANIM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CDOFKNGAHHG
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
public enum KGCAFEIIDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DENOEGJPMGD
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int NPLPCCNDGDB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int GDDHAENMDJD = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int POBENKGMPJJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint DMNEBILMBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int ANNEHNNGNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int HHNJEHKPAFI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ICOPMAJKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5F841E0", Offset = "0x5F827E0", VA = "0x185F841E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F841F0", Offset = "0x5F827F0", VA = "0x185F841F0")]
	public bool OKFDICIBJAH(JOBHENAPCGO PHJMMALGKEF, int IMAGIDBPDMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GLHHNMMBJKD : JOBHENAPCGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket PHJMMALGKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly HLFOIBHLJDH JMOCLHPHNIC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short NJLHEFKPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5F87570", Offset = "0x5F85B70", VA = "0x185F87570", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ODLECPPFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5F86E80", Offset = "0x5F85480", VA = "0x185F86E80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FJGIOONILLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5F86F90", Offset = "0x5F85590", VA = "0x185F86F90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily CBIHBJBAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x43C4240", Offset = "0x43C2840", VA = "0x1843C4240", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F87590", Offset = "0x5F85B90", VA = "0x185F87590")]
	public GLHHNMMBJKD(AddressFamily AIADLOOADGL, HLFOIBHLJDH JMOCLHPHNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F86FB0", Offset = "0x5F855B0", VA = "0x185F86FB0", Slot = "8")]
	public bool GOHMKFMJHOE(IPEndPoint COCCJPGAHOG, EGNDMCLNBPC MCKMIFDDEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F86E40", Offset = "0x5F85440", VA = "0x185F86E40", Slot = "9")]
	public int BBDFKCGAMMI(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int BHEAFIOEIAD, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F86EA0", Offset = "0x5F854A0", VA = "0x185F86EA0", Slot = "10")]
	public int EMDCFNEBBEI(byte[] DJOHOLIEOKK, EndPoint BANBMMLEDBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F86E20", Offset = "0x5F85420", VA = "0x185F86E20", Slot = "11")]
	public void ALHHDKKNANM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface JOBHENAPCGO
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short NJLHEFKPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int ODLECPPFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint FJGIOONILLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily CBIHBJBAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GOHMKFMJHOE(IPEndPoint COCCJPGAHOG, EGNDMCLNBPC MCKMIFDDEMM);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int BBDFKCGAMMI(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int BHEAFIOEIAD, IPEndPoint EGIABGNOHCN);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EMDCFNEBBEI(byte[] DJOHOLIEOKK, EndPoint EGIABGNOHCN);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALHHDKKNANM();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct OBIAOFNCOGA : IEquatable<OBIAOFNCOGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long EACFOOCHDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long NFDMCAAFKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long HEOCBNFGCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int EHCOFIIIEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int BAACBLPPBNC;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5F98990", Offset = "0x5F96F90", VA = "0x185F98990")]
	public OBIAOFNCOGA(byte[] LKGIJLGOFHC, int PMAKCKDPHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCB0", Offset = "0x8AC2B0", VA = "0x1808ADCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5F98950", Offset = "0x5F96F50", VA = "0x185F98950", Slot = "4")]
	public bool Equals(OBIAOFNCOGA PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5F988A0", Offset = "0x5F96EA0", VA = "0x185F988A0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CEHPBIMAONI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] FDBDOGHNKMC;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HDIHHAICNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int BGIMGMBHJLO;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
	protected HDIHHAICNED(int FCBDKDKJAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FOJGGGEDOPP(IPEndPoint COCCJPGAHOG, byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PLLLNKMECLH(IPEndPoint COCCJPGAHOG, byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DFKAHLHIEOD : HDIHHAICNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] LFOBGDLOPID;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator HBLFMHCLICG;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x20DB2D0", Offset = "0x20D98D0", VA = "0x1820DB2D0")]
	public DFKAHLHIEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5F842E0", Offset = "0x5F828E0", VA = "0x185F842E0")]
	public void EBACJEABAPF(IPEndPoint COCCJPGAHOG, byte[] LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5F84940", Offset = "0x5F82F40", VA = "0x185F84940")]
	public void LPIFMBCCONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5F84490", Offset = "0x5F82A90", VA = "0x185F84490", Slot = "4")]
	public override void FOJGGGEDOPP(IPEndPoint COCCJPGAHOG, byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5F84A20", Offset = "0x5F83020", VA = "0x185F84A20", Slot = "5")]
	public override void PLLLNKMECLH(IPEndPoint COCCJPGAHOG, byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct HMECEDNBIMK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void LFEHDGCPNJD([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class HBEJBLEIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A30", Offset = "0x5F98030", VA = "0x185F99A30")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5F99B50", Offset = "0x5F98150", VA = "0x185F99B50")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5F99760", Offset = "0x5F97D60", VA = "0x185F99760")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5F99800", Offset = "0x5F97E00", VA = "0x185F99800")]
		public unsafe static void FJEDBGMGJGG([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint LFOBGDLOPID[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint BPFOOPFJNMI[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint JDPBIBBPLHP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint AOLMGPJOLLD[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint CHCAAEMPOLG[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint FNPCGINFKMA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint FDHFLBOAOJP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint INJFLGHEHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint MDMEKHGOPKN[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EA80", Offset = "0x5F8D080", VA = "0x185F8EA80")]
	private void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E820", Offset = "0x5F8CE20", VA = "0x185F8E820")]
	private uint DPPFNNEHAEI(uint LEKEIHPCIEI, int GNHPOGJPDFJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5F82680", Offset = "0x5F80C80", VA = "0x185F82680")]
	private void FHDGGLGJPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5F82830", Offset = "0x5F80E30", VA = "0x185F82830")]
	private void PJGJOCFIFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5F825F0", Offset = "0x5F80BF0", VA = "0x185F825F0")]
	private void DCEPFKJGEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5F82730", Offset = "0x5F80D30", VA = "0x185F82730")]
	private void JDJDODMMEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E850", Offset = "0x5F8CE50", VA = "0x185F8E850")]
	private void EKGOJCJOOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EB00", Offset = "0x5F8D100", VA = "0x185F8EB00")]
	private unsafe void LPHEHNOIJFA(byte* FFLOFEAGGMO, uint* LFOBGDLOPID, uint* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E990", Offset = "0x5F8CF90", VA = "0x185F8E990")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void GKMCHNPBOCM([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5F8E8B0", Offset = "0x5F8CEB0", VA = "0x185F8E8B0")]
	public static void GKMCHNPBOCM(Span<byte> FFLOFEAGGMO, Span<byte> LFOBGDLOPID, Span<byte> BPFOOPFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EF20", Offset = "0x5F8D520", VA = "0x185F8EF20")]
	public static void OAAAHKBIHCA(Span<byte> FFLOFEAGGMO, Span<byte> LFOBGDLOPID, Span<byte> BPFOOPFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EA10", Offset = "0x5F8D010", VA = "0x185F8EA10")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KOAHKIGHNDJ([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5F99DA0", Offset = "0x5F983A0", VA = "0x185F99DA0")]
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
