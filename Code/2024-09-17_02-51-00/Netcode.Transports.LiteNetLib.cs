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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool KHBJKPODHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x607B790", Offset = "0x607A190", VA = "0x18607B790", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x607AD20", Offset = "0x6079720", VA = "0x18607AD20")]
		public void RecRoom_SetEncryptionInfo(ulong BGPCLPJDOEK, byte[] LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x607AD00", Offset = "0x6079700", VA = "0x18607AD00")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x607ABD0", Offset = "0x60795D0", VA = "0x18607ABD0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x607B690", Offset = "0x607A090", VA = "0x18607B690")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x607AE40", Offset = "0x6079840", VA = "0x18607AE40", Slot = "6")]
		public override void Send(ulong OFOOJDCGKBP, ArraySegment<byte> JGCMECODHDI, NetworkDelivery DMADOKHGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x607ACC0", Offset = "0x60796C0", VA = "0x18607ACC0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong OFOOJDCGKBP, [Out] ArraySegment<byte> AJFODGMHKJN, [Out] float LAAOEDLAGIL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x607B130", Offset = "0x6079B30", VA = "0x18607B130", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x607B5B0", Offset = "0x6079FB0", VA = "0x18607B5B0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x607A330", Offset = "0x6078D30", VA = "0x18607A330", Slot = "10")]
		public override void DisconnectRemoteClient(ulong OFOOJDCGKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x607A1E0", Offset = "0x6078BE0", VA = "0x18607A1E0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x607A790", Offset = "0x6079190", VA = "0x18607A790", Slot = "12")]
		public override ulong GetCurrentRtt(ulong OFOOJDCGKBP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x607B0C0", Offset = "0x6079AC0", VA = "0x18607B0C0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x607A830", Offset = "0x6079230", VA = "0x18607A830", Slot = "14")]
		public override void Initialize([Optional] NetworkManager NOOIFLLDEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x607AAD0", Offset = "0x60794D0", VA = "0x18607AAD0")]
		private FLBEBOIBIEG LJIILGAGDEO(NetworkDelivery JLAAKHANEHC)
		{
			return default(FLBEBOIBIEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x607A9F0", Offset = "0x60793F0", VA = "0x18607A9F0", Slot = "15")]
		private void KGJFHPMFOAH(JOGDCLPCEJA OCLFKCJGOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x607A0A0", Offset = "0x6078AA0", VA = "0x18607A0A0", Slot = "16")]
		private void BGMAALBNAGF(JOGDCLPCEJA OCLFKCJGOOI, HMPEKLHFEPB JLLJKHHBMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "17")]
		private void IIPLLMKDFNJ(IPEndPoint COCCJPGAHOG, SocketError ANMOGHNPGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x607A580", Offset = "0x6078F80", VA = "0x18607A580", Slot = "18")]
		private void GJLJPGFLGEC(JOGDCLPCEJA OCLFKCJGOOI, ILDGMMKKEBF JEAKAGANOAM, byte OCDNIEKJOID, FLBEBOIBIEG ILLOHCPKDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x607A4A0", Offset = "0x6078EA0", VA = "0x18607A4A0")]
		private void FBNHGBNBGPJ(int BHEAFIOEIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "19")]
		private void KPNBPONCDHA(IPEndPoint EGIABGNOHCN, ILDGMMKKEBF JEAKAGANOAM, PIJPONMJECP KEOIKFMHEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "20")]
		private void IGOLPMCMLLO(JOGDCLPCEJA OCLFKCJGOOI, int MCMKEGBLLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x607A180", Offset = "0x6078B80", VA = "0x18607A180", Slot = "21")]
		private void DMDCIMMCAKE(CLINOKNLAOH NEKCFCOLDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x607ABA0", Offset = "0x60795A0", VA = "0x18607ABA0")]
		private ulong LLPENPCFCBD(JOGDCLPCEJA OCLFKCJGOOI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x607AAB0", Offset = "0x60794B0", VA = "0x18607AAB0")]
		private static int KOCAEGFMDOB(float GMOGAEOJHDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x607B6B0", Offset = "0x607A0B0", VA = "0x18607B6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6067880", Offset = "0x6066280", VA = "0x186067880")]
	protected CPNFNHHIPJF(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6067760", Offset = "0x6066160", VA = "0x186067760")]
	public void BAEPNCDLGCC(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6067800", Offset = "0x6066200", VA = "0x186067800")]
	protected void JEIKEDDBDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60677C0", Offset = "0x60661C0", VA = "0x1860677C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BFCB0", Offset = "0x8BE6B0", VA = "0x1808BFCB0")]
		[CompilerGenerated]
		get
		{
			return default(MFEFKNHHAOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD234B0", Offset = "0xD21EB0", VA = "0x180D234B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6067660", Offset = "0x6066060", VA = "0x186067660")]
	internal void BEAGHLMGBOP(AGJIJHGCHHI ECLCCAMNGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60676C0", Offset = "0x60660C0", VA = "0x1860676C0")]
	private bool OINEHLCBEDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60676F0", Offset = "0x60660F0", VA = "0x1860676F0")]
	internal CLINOKNLAOH(IPEndPoint EGIABGNOHCN, AGJIJHGCHHI DFOBGICAKNO, HLFOIBHLJDH MMPLGKEGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6067600", Offset = "0x6066000", VA = "0x186067600")]
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
	[Cpp2IlInjected.Address(RVA = "0x60665F0", Offset = "0x6064FF0", VA = "0x1860665F0")]
	private AGJIJHGCHHI(long MHHMDJHKBNO, byte KJMJNHPDCNL, int IDOMJKBDODC, byte[] FKLHBANDIHB, PKILOIGDLDE JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6066190", Offset = "0x6064B90", VA = "0x186066190")]
	public static int HNLPHMBKAJN(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60661F0", Offset = "0x6064BF0", VA = "0x1860661F0")]
	public static AGJIJHGCHHI NEGJMOMMHNA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6066410", Offset = "0x6064E10", VA = "0x186066410")]
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
	[Cpp2IlInjected.Address(RVA = "0x60675B0", Offset = "0x6065FB0", VA = "0x1860675B0")]
	private BFFDFNKPPGC(long MHHMDJHKBNO, byte KJMJNHPDCNL, int NECEDJFMDLL, bool NAPNNFCDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6067370", Offset = "0x6065D70", VA = "0x186067370")]
	public static BFFDFNKPPGC NEGJMOMMHNA(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60674C0", Offset = "0x6065EC0", VA = "0x1860674C0")]
	public static IGCJLPHBJAJ NMMPCDKDGGK(long FBHCKPAOFFE, byte ELLIJBJPLIA, int AMDPOGMBLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6067270", Offset = "0x6065C70", VA = "0x186067270")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
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
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool COHFPGMKEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8A08A0", Offset = "0x89F2A0", VA = "0x1808A08A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6068F60", Offset = "0x6067960", VA = "0x186068F60")]
	internal FLHPMHGGOIG(HLFOIBHLJDH PHJMMALGKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6068C70", Offset = "0x6067670", VA = "0x186068C70")]
	internal void JGOBEPNEFAP(IPEndPoint AMPFOHOIFFB, IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D96E40", Offset = "0x2D95840", VA = "0x182D96E40")]
	private void OKFDICIBJAH<T>(T BHIJKPOILFM, IPEndPoint LLMCGMPLMBL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6068DD0", Offset = "0x60677D0", VA = "0x186068DD0")]
	private void KGENDMNMLGM(JKBHFCOFILD EIMIIALLGDD, IPEndPoint AMPFOHOIFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6068970", Offset = "0x6067370", VA = "0x186068970")]
	private void FKAPNOCLCOI(KPFNLEACGOI EIMIIALLGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6068AD0", Offset = "0x60674D0", VA = "0x186068AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6067920", Offset = "0x6066320", VA = "0x186067920")]
	public DELDNCFJLHH(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OCALCONDLKL : DELDNCFJLHH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6067920", Offset = "0x6066320", VA = "0x186067920")]
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
	[Cpp2IlInjected.Address(RVA = "0x6068640", Offset = "0x6067040", VA = "0x186068640")]
	private static void NCKBDMJHFHB(MDPIOBEDKDP NJBLKCIKLOM, string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60685E0", Offset = "0x6066FE0", VA = "0x1860685E0")]
	internal static void KIAOPGHDFBF(string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6068580", Offset = "0x6066F80", VA = "0x186068580")]
	internal static void EMLCJEKGMMG(string KLNAGGGGPDK, params object[] AAAOIGBEBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6068520", Offset = "0x6066F20", VA = "0x186068520")]
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
	[Cpp2IlInjected.Address(RVA = "0x6073390", Offset = "0x6071D90", VA = "0x186073390")]
	internal ILDGMMKKEBF(HLFOIBHLJDH EHABNPPLNPG, PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6073320", Offset = "0x6071D20", VA = "0x186073320")]
	internal void MPOJAPNIAAF(IGCJLPHBJAJ BHIJKPOILFM, int POIDBEGOOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6073270", Offset = "0x6071C70", VA = "0x186073270")]
	internal void GNIIHDBKDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60732F0", Offset = "0x6071CF0", VA = "0x1860732F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x607CE20", Offset = "0x607B820", VA = "0x18607CE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6079AC0", Offset = "0x60784C0", VA = "0x186079AC0", Slot = "4")]
		public bool Equals(IPEndPoint NCPIGLMANIM, IPEndPoint DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5B64B00", Offset = "0x5B63500", VA = "0x185B64B00", Slot = "5")]
		public int GetHashCode(IPEndPoint GHMNBJIOGAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1342860", Offset = "0x1341260", VA = "0x181342860")]
		public IDLCHMOFILA(JOGDCLPCEJA FDIIPKGGJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6072770", Offset = "0x6071170", VA = "0x186072770", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60727C0", Offset = "0x60711C0", VA = "0x1860727C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xE2DA50", Offset = "0xE2C450", VA = "0x180E2DA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xEE9100", Offset = "0xEE7B00", VA = "0x180EE9100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PDPABHKKELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x182A950", Offset = "0x1829350", VA = "0x18182A950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1B91E70", Offset = "0x1B90870", VA = "0x181B91E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NOIBAOKDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC53E10", Offset = "0xC52810", VA = "0x180C53E10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BGIMGMBHJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6071720", Offset = "0x6070120", VA = "0x186071720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short NJLHEFKPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x606D9E0", Offset = "0x606C3E0", VA = "0x18606D9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x606DC50", Offset = "0x606C650", VA = "0x18606DC50")]
	public void KEAFDPELHLA(IPEndPoint COCCJPGAHOG, byte[] LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x606DB00", Offset = "0x606C500", VA = "0x18606DB00")]
	public void JNALPNDJKLH(IPEndPoint COCCJPGAHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x606CBF0", Offset = "0x606B5F0", VA = "0x18606CBF0")]
	private bool HANIDKBOEIK(IPEndPoint COCCJPGAHOG, [Out] JOGDCLPCEJA OCLFKCJGOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x606CF20", Offset = "0x606B920", VA = "0x18606CF20")]
	private void HIBGFMBEDCC(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x606B2C0", Offset = "0x6069CC0", VA = "0x18606B2C0")]
	private void DGHHPKIMHCF(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x606CC80", Offset = "0x606B680", VA = "0x18606CC80")]
	private void HBIFLGMHAFC(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6071920", Offset = "0x6070320", VA = "0x186071920")]
	public HLFOIBHLJDH(INFNLCKMAGO MMPLGKEGKLF, [Optional] HDIHHAICNED DLFHNONAFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x606B5A0", Offset = "0x6069FA0", VA = "0x18606B5A0")]
	internal void EHELCBIMBCM(JOGDCLPCEJA LKNCMAPCPIK, int MCMKEGBLLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x606CED0", Offset = "0x606B8D0", VA = "0x18606CED0")]
	internal void HIALKOBGDGL(JOGDCLPCEJA LKNCMAPCPIK, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x606DE70", Offset = "0x606C870", VA = "0x18606DE70")]
	internal void KIFLGAAJJCA(JOGDCLPCEJA OCLFKCJGOOI, DOGAPDHDCBD ONIANAELCBB, SocketError DDDKKMJBCNK, IGCJLPHBJAJ GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x606E750", Offset = "0x606D150", VA = "0x18606E750")]
	private void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI, DOGAPDHDCBD ONIANAELCBB, SocketError DDDKKMJBCNK, bool LENLJCDCMCG, byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG, IGCJLPHBJAJ GIEOAGIJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x606C830", Offset = "0x606B230", VA = "0x18606C830")]
	private void GHHEPHIGPCE(PNDEKBPIPKK.CKCHCKLDLJB JLAAKHANEHC, [Optional] JOGDCLPCEJA OCLFKCJGOOI, [Optional] IPEndPoint EGIABGNOHCN, SocketError JPKBMOOHKJG = SocketError.Success, int MCMKEGBLLJK = 0, DOGAPDHDCBD APBKCKKPFJJ = DOGAPDHDCBD.ConnectionFailed, [Optional] CLINOKNLAOH OFOCEJKBBKO, FLBEBOIBIEG ILLOHCPKDKP = FLBEBOIBIEG.Unreliable, byte OCDNIEKJOID = 0, [Optional] IGCJLPHBJAJ KHBGHAKEMLD, [Optional] object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6070950", Offset = "0x606F350", VA = "0x186070950")]
	private void ONOEOEPJIGH(PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x606AD90", Offset = "0x6069790", VA = "0x18606AD90")]
	internal void ALMPCACNLFA(PNDEKBPIPKK KNAJJHHNHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x606F560", Offset = "0x606DF60", VA = "0x18606F560")]
	private void MLJHDIMLDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x606B5F0", Offset = "0x6069FF0", VA = "0x18606B5F0")]
	private void EOGFDOILJKK(int HIDIFLAJJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6071110", Offset = "0x606FB10", VA = "0x186071110")]
	internal JOGDCLPCEJA OPOJEMIDANO(CLINOKNLAOH NEKCFCOLDAN, byte[] DNNJHFOGMMB, int OENMMCMOJOM, int KHMKAEGDPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x606DF40", Offset = "0x606C940", VA = "0x18606DF40")]
	private int KNEIPABGPEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x606E180", Offset = "0x606CB80", VA = "0x18606E180")]
	private void KPAKFLFCLGO(IPEndPoint EGIABGNOHCN, JOGDCLPCEJA FDDIMNCICJM, AGJIJHGCHHI AMHKGLCFDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x606FAC0", Offset = "0x606E4C0", VA = "0x18606FAC0")]
	private void NEBGEPDLAKC(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x606B000", Offset = "0x6069A00", VA = "0x18606B000")]
	internal void CNLIKCPIJOK(IGCJLPHBJAJ BHIJKPOILFM, FLBEBOIBIEG PDJPHJMJIMF, byte OCDNIEKJOID, int POIDBEGOOBB, JOGDCLPCEJA LKNCMAPCPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x606E9D0", Offset = "0x606D3D0", VA = "0x18606E9D0")]
	public bool LHKIFFPBGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x606EA40", Offset = "0x606D440", VA = "0x18606EA40")]
	public bool LHKIFFPBGID(IPAddress IPEIJMCGJDA, IPAddress DJLNPGPGLAG, int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x606EA60", Offset = "0x606D460", VA = "0x18606EA60")]
	public bool LHKIFFPBGID(int EHGIOJOEILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x606E830", Offset = "0x606D230", VA = "0x18606E830")]
	public void LCOPDAEKBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x606C750", Offset = "0x606B150", VA = "0x18606C750")]
	public JOGDCLPCEJA FFBLMBKMLDC(string LKGIJLGOFHC, int EHGIOJOEILB, string LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x606C670", Offset = "0x606B070", VA = "0x18606C670")]
	public JOGDCLPCEJA FFBLMBKMLDC(string LKGIJLGOFHC, int EHGIOJOEILB, GDDHLOJHPLL GEAGHEFCPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x606C2A0", Offset = "0x606ACA0", VA = "0x18606C2A0")]
	public JOGDCLPCEJA FFBLMBKMLDC(IPEndPoint LLMCGMPLMBL, GDDHLOJHPLL GEAGHEFCPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x606BF40", Offset = "0x606A940", VA = "0x18606BF40")]
	public void FCHFEKGILOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x606BF50", Offset = "0x606A950", VA = "0x18606BF50")]
	public void FCHFEKGILOJ(bool PLDDDMMFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x606F9C0", Offset = "0x606E3C0", VA = "0x18606F9C0")]
	public void MNOKOMIABBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x606F8A0", Offset = "0x606E2A0", VA = "0x18606F8A0")]
	public void MNOKOMIABBH(byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x606E5E0", Offset = "0x606CFE0", VA = "0x18606E5E0")]
	public void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x606E690", Offset = "0x606D090", VA = "0x18606E690")]
	public void KPBPFJAOEAJ(JOGDCLPCEJA OCLFKCJGOOI, byte[] JGCMECODHDI, int OENMMCMOJOM, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6071740", Offset = "0x6070140", VA = "0x186071740", Slot = "4")]
	private IEnumerator<JOGDCLPCEJA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60717D0", Offset = "0x60701D0", VA = "0x1860717D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x606DFC0", Offset = "0x606C9C0", VA = "0x18606DFC0")]
	private IGCJLPHBJAJ KNICJKNINNE(OIMCJEHFCHC PKFJNPAMFMB, int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x606E0A0", Offset = "0x606CAA0", VA = "0x18606E0A0")]
	private IGCJLPHBJAJ KNICJKNINNE(OIMCJEHFCHC PKFJNPAMFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x606D560", Offset = "0x606BF60", VA = "0x18606D560")]
	internal IGCJLPHBJAJ IIDDFCFAHDL(int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x606D790", Offset = "0x606C190", VA = "0x18606D790")]
	internal void IKDECFPBCHC(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6071860", Offset = "0x6070260", VA = "0x186071860")]
	static HLFOIBHLJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE2DA50", Offset = "0xE2C450", VA = "0x180E2DA50")]
	private bool OKKHPAEKBNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x606B4B0", Offset = "0x6069EB0", VA = "0x18606B4B0")]
	private void EEPNOLAHLOK(IPEndPoint KDJIDLOGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6070870", Offset = "0x606F270", VA = "0x186070870")]
	private void OKOKCHLDCLO(IPEndPoint KDJIDLOGKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x606B310", Offset = "0x6069D10", VA = "0x18606B310")]
	private bool DLBIIHAJHBB(SocketException NJACFNFHNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x606F290", Offset = "0x606DC90", VA = "0x18606F290")]
	private void MGNKCLCBDCL(JOBHENAPCGO PHJMMALGKEF, EndPoint MCDMDDJGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x606D1E0", Offset = "0x606BBE0", VA = "0x18606D1E0")]
	private void IFCEMMAFDOE(object FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x606EAE0", Offset = "0x606D4E0", VA = "0x18606EAE0")]
	public bool LHKIFFPBGID(IPAddress IPEIJMCGJDA, IPAddress DJLNPGPGLAG, int EHGIOJOEILB, bool GOHLJLFJLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x606DAA0", Offset = "0x606C4A0", VA = "0x18606DAA0")]
	internal int JHDJEDJJAMJ(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x606B910", Offset = "0x606A310", VA = "0x18606B910")]
	internal int FAPPIALKEHC(IGCJLPHBJAJ BHIJKPOILFM, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x606B950", Offset = "0x606A350", VA = "0x18606B950")]
	internal int FAPPIALKEHC(byte[] KFAOBDLOMDC, int OENMMCMOJOM, int KHMKAEGDPPG, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x606AE90", Offset = "0x6069890", VA = "0x18606AE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6072A50", Offset = "0x6071450", VA = "0x186072A50")]
		get
		{
			return default(OIMCJEHFCHC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6072B90", Offset = "0x6071590", VA = "0x186072B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte KJNAFDPHDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6072C00", Offset = "0x6071600", VA = "0x186072C00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6072840", Offset = "0x6071240", VA = "0x186072840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort FCPPJJAFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6072B30", Offset = "0x6071530", VA = "0x186072B30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6072AF0", Offset = "0x60714F0", VA = "0x186072AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DEDAIJKOPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6072810", Offset = "0x6071210", VA = "0x186072810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte MFIFIOHFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6072BD0", Offset = "0x60715D0", VA = "0x186072BD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6072880", Offset = "0x6071280", VA = "0x186072880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort MLLICFCDPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6072CD0", Offset = "0x60716D0", VA = "0x186072CD0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60728B0", Offset = "0x60712B0", VA = "0x1860728B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort IOFDHNPKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x60728F0", Offset = "0x60712F0", VA = "0x1860728F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6072C90", Offset = "0x6071690", VA = "0x186072C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MNCANGGAINI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6072C30", Offset = "0x6071630", VA = "0x186072C30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6072A80", Offset = "0x6071480", VA = "0x186072A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6072E30", Offset = "0x6071830", VA = "0x186072E30")]
	static IGCJLPHBJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6072AC0", Offset = "0x60714C0", VA = "0x186072AC0")]
	public void IHDJJCCPIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x60730F0", Offset = "0x6071AF0", VA = "0x1860730F0")]
	public IGCJLPHBJAJ(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6073160", Offset = "0x6071B60", VA = "0x186073160")]
	public IGCJLPHBJAJ(OIMCJEHFCHC PKFJNPAMFMB, int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60729E0", Offset = "0x60713E0", VA = "0x1860729E0")]
	public static int CGPDOBLCFAJ(OIMCJEHFCHC PKFJNPAMFMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6072950", Offset = "0x6071350", VA = "0x186072950")]
	public int CGPDOBLCFAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6072D30", Offset = "0x6071730", VA = "0x186072D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAEF980", Offset = "0xAEE380", VA = "0x180AEF980")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6075370", Offset = "0x6073D70", VA = "0x186075370")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CKKEHAMMEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9E1440", Offset = "0x9DFE40", VA = "0x1809E1440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CLGEGONOGBM HGNDMOEAIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x158C930", Offset = "0x158B330", VA = "0x18158C930")]
		get
		{
			return default(CLGEGONOGBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HNGOPFBLGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x897E50", Offset = "0x896850", VA = "0x180897E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GGAHCEIMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xF2B350", Offset = "0xF29D50", VA = "0x180F2B350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x182B2C0", Offset = "0x1829CC0", VA = "0x18182B2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BONKGLCOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60773A0", Offset = "0x6075DA0", VA = "0x1860773A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DJGLPOPOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A7290", Offset = "0x8A5C90", VA = "0x1808A7290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double DHBAIBIIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1DF23E0", Offset = "0x1DF0DE0", VA = "0x181DF23E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JPLEHMNCBLA LONAGNAJMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60775B0", Offset = "0x6075FB0", VA = "0x1860775B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60781D0", Offset = "0x6076BD0", VA = "0x1860781D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6078280", Offset = "0x6076C80", VA = "0x186078280")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, IPEndPoint EGIABGNOHCN, int MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60766A0", Offset = "0x60750A0", VA = "0x1860766A0")]
	internal void KCMNNCKPOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60781A0", Offset = "0x6076BA0", VA = "0x1860781A0")]
	internal void PAOCEBJBIOP(IPEndPoint IPBFGDOPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6074E20", Offset = "0x6073820", VA = "0x186074E20")]
	internal void BCLGGANCDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x60752A0", Offset = "0x6073CA0", VA = "0x1860752A0")]
	private void CPKFNBKLMEF(int KLCOPGDKFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6078160", Offset = "0x6076B60", VA = "0x186078160")]
	private void ONGAACBOJAO(int KIFLDCBDHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60771F0", Offset = "0x6075BF0", VA = "0x1860771F0")]
	private CPNFNHHIPJF LBLAJOINPKI(byte LBBGOBFOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60788B0", Offset = "0x60772B0", VA = "0x1860788B0")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, IPEndPoint EGIABGNOHCN, int MCAKFNPAKIL, byte ELLIJBJPLIA, GDDHLOJHPLL IKOHIFBJJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x60786D0", Offset = "0x60770D0", VA = "0x1860786D0")]
	internal JOGDCLPCEJA(HLFOIBHLJDH JMOCLHPHNIC, CLINOKNLAOH NEKCFCOLDAN, int MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6077FF0", Offset = "0x60769F0", VA = "0x186077FF0")]
	internal void NFAOJHHDFBC(AGJIJHGCHHI AODBHOIDBHJ, byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60766C0", Offset = "0x60750C0", VA = "0x1860766C0")]
	internal bool KEMHMIINLOF(BFFDFNKPPGC BHIJKPOILFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6078130", Offset = "0x6076B30", VA = "0x186078130")]
	public void OKFDICIBJAH(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, FLBEBOIBIEG CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6075790", Offset = "0x6074190", VA = "0x186075790")]
	private void GFGFFFLLHOM(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, byte OCDNIEKJOID, FLBEBOIBIEG ILLOHCPKDKP, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6078080", Offset = "0x6076A80", VA = "0x186078080")]
	public void OBAKEPHIELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6074EB0", Offset = "0x60738B0", VA = "0x186074EB0")]
	internal KNENCLHDBIH BFKOFNGOIDC(IGCJLPHBJAJ BHIJKPOILFM)
	{
		return default(KNENCLHDBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6075FA0", Offset = "0x60749A0", VA = "0x186075FA0")]
	internal void IOAABEBGHCC(CPNFNHHIPJF CLBPLOJAIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6074F90", Offset = "0x6073990", VA = "0x186074F90")]
	internal OEBEBCMIDBO CNJPPBMNIGO(byte[] JGCMECODHDI, int OENMMCMOJOM, int KHMKAEGDPPG, bool LENLJCDCMCG)
	{
		return default(OEBEBCMIDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6078040", Offset = "0x6076A40", VA = "0x186078040")]
	private void NPDNCKLNPCK(int PCIBJDLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6077660", Offset = "0x6076060", VA = "0x186077660")]
	internal void NDBMCDNNGFL(FLBEBOIBIEG PDJPHJMJIMF, IGCJLPHBJAJ FDIIPKGGJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6076150", Offset = "0x6074B50", VA = "0x186076150")]
	private void JOFDANFCKEO(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6075420", Offset = "0x6073E20", VA = "0x186075420")]
	private void FPEHEADPFNL(int BKOJCILPMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6077030", Offset = "0x6075A30", VA = "0x186077030")]
	internal DBGEGJIDFGD KPAKFLFCLGO(AGJIJHGCHHI AMHKGLCFDLB)
	{
		return default(DBGEGJIDFGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6074770", Offset = "0x6073170", VA = "0x186074770")]
	internal void AOMMBBLGMIA(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6076000", Offset = "0x6074A00", VA = "0x186076000")]
	private void JINMINIJHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60773B0", Offset = "0x6075DB0", VA = "0x1860773B0")]
	internal void LNLAFCKPMAI(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6076740", Offset = "0x6075140", VA = "0x186076740")]
	internal void KOLHFLEMELG(int BKOJCILPMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6075CE0", Offset = "0x60746E0", VA = "0x186075CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x607BA70", Offset = "0x607A470", VA = "0x18607BA70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GFBGPJCJLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x607BC00", Offset = "0x607A600", VA = "0x18607BC00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long ELNBEBIDGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x607B7B0", Offset = "0x607A1B0", VA = "0x18607B7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long BCPKKLBOLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x607B960", Offset = "0x607A360", VA = "0x18607B960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long EACEMFIJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x607BC10", Offset = "0x607A610", VA = "0x18607BC10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long OGHPCKJCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x607BA80", Offset = "0x607A480", VA = "0x18607BA80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long CCLKOLFICJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x607B920", Offset = "0x607A320", VA = "0x18607B920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long EIIOODBDALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x607B7C0", Offset = "0x607A1C0", VA = "0x18607B7C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MAMADBLBPMI KNFHGHGODGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x607BB50", Offset = "0x607A550", VA = "0x18607BB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double DCEDGAHLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x607BBA0", Offset = "0x607A5A0", VA = "0x18607BBA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x607BB60", Offset = "0x607A560", VA = "0x18607BB60")]
	public void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x607BA10", Offset = "0x607A410", VA = "0x18607BA10")]
	public void JBOIJIHDHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x607B8D0", Offset = "0x607A2D0", VA = "0x18607B8D0")]
	public void GDNHBPAMHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x607BA90", Offset = "0x607A490", VA = "0x18607BA90")]
	public void KHBAPPACMOO(long JDEPFGEKEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x607B870", Offset = "0x607A270", VA = "0x18607B870")]
	public void EKPIHMNHCEE(long NMAFMPBJBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x607BAF0", Offset = "0x607A4F0", VA = "0x18607BAF0")]
	public void KILAFPFKHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x607B800", Offset = "0x607A200", VA = "0x18607B800")]
	public void DNFBEIKJOEJ(long OPFBMGDJKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x607BC20", Offset = "0x607A620", VA = "0x18607BC20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x607B970", Offset = "0x607A370", VA = "0x18607B970")]
	public void IDPEMJCPACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6079B30", Offset = "0x6078530", VA = "0x186079B30")]
	public static IPEndPoint AOMAGPBJPJA(string PMHDCFBHNIM, int EHGIOJOEILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6079D80", Offset = "0x6078780", VA = "0x186079D80")]
	public static IPAddress ECKLGJEFMBN(string PMHDCFBHNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6079F50", Offset = "0x6078950", VA = "0x186079F50")]
	public static IPAddress ECKLGJEFMBN(string PMHDCFBHNIM, AddressFamily AIADLOOADGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6079FE0", Offset = "0x60789E0", VA = "0x186079FE0")]
	internal static int KLFKDJENMPA(int HELKFKEKCOK, int AKPJMLDDHEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D180", Offset = "0x2E5BB80", VA = "0x182E5D180")]
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
		[Cpp2IlInjected.Address(RVA = "0x6067070", Offset = "0x6065A70", VA = "0x186067070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6066F90", Offset = "0x6065990", VA = "0x186066F90")]
		public void AMLGEKNOMHA(IGCJLPHBJAJ BHIJKPOILFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6066FB0", Offset = "0x60659B0", VA = "0x186066FB0")]
		public bool LAPIIOBGIPI(long AINNCKMHEPN, JOGDCLPCEJA OCLFKCJGOOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6067020", Offset = "0x6065A20", VA = "0x186067020")]
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
	[Cpp2IlInjected.Address(RVA = "0x60798F0", Offset = "0x60782F0", VA = "0x1860798F0")]
	public LBFGCCNJJJC(JOGDCLPCEJA OCLFKCJGOOI, bool KKMBPOPPCGC, byte MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60790A0", Offset = "0x6077AA0", VA = "0x1860790A0")]
	private void OANPBEFNKPI(IGCJLPHBJAJ BHIJKPOILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6079440", Offset = "0x6077E40", VA = "0x186079440", Slot = "4")]
	protected override bool OEBPFPLLJIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6078A40", Offset = "0x6077440", VA = "0x186078A40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6066E00", Offset = "0x6065800", VA = "0x186066E00")]
	public AGNCEELJCGC(JOGDCLPCEJA OCLFKCJGOOI, bool CNHIBLBICFI, byte MCAKFNPAKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6066940", Offset = "0x6065340", VA = "0x186066940", Slot = "4")]
	protected override bool OEBPFPLLJIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6066660", Offset = "0x6065060", VA = "0x186066660", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6065BB0", Offset = "0x60645B0", VA = "0x186065BB0")]
	private static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, ulong JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6067200", Offset = "0x6065C00", VA = "0x186067200")]
	private static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60671B0", Offset = "0x6065BB0", VA = "0x1860671B0")]
	public static void JEHFEFKOAIC(byte[] DJOHOLIEOKK, int IEHCONIHMPO, short JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6067110", Offset = "0x6065B10", VA = "0x186067110")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, double KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6067130", Offset = "0x6065B30", VA = "0x186067130")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60671B0", Offset = "0x6065BB0", VA = "0x1860671B0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, short KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60671B0", Offset = "0x6065BB0", VA = "0x1860671B0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, ushort KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6067200", Offset = "0x6065C00", VA = "0x186067200")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6067200", Offset = "0x6065C00", VA = "0x186067200")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, uint KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60671F0", Offset = "0x6065BF0", VA = "0x1860671F0")]
	public static void FBLKHOOKCAH(byte[] CNGBPDKMHBB, int NBPJLJIBBHP, long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60671F0", Offset = "0x6065BF0", VA = "0x1860671F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NENGGNJJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EMKELOPEICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x607C410", Offset = "0x607AE10", VA = "0x18607C410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DGEOHMJGPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x205BC80", Offset = "0x205A680", VA = "0x18205BC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PBPFFLDOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x607CBC0", Offset = "0x607B5C0", VA = "0x18607CBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x607CCD0", Offset = "0x607B6D0", VA = "0x18607CCD0")]
	public void MPOJAPNIAAF(byte[] MKLJJBDOOGE, int IEHCONIHMPO, int GIJEEPMKODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public PKILOIGDLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x607CDC0", Offset = "0x607B7C0", VA = "0x18607CDC0")]
	public PKILOIGDLDE(byte[] MKLJJBDOOGE, int IEHCONIHMPO, int GIJEEPMKODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x607C9D0", Offset = "0x607B3D0", VA = "0x18607C9D0")]
	public IPEndPoint JBPNHLBJJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x607C4E0", Offset = "0x607AEE0", VA = "0x18607C4E0")]
	public byte NPLMJCMCJKF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x607C4E0", Offset = "0x607AEE0", VA = "0x18607C4E0")]
	public sbyte DALFHDIOHIM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2F42BF0", Offset = "0x2F415F0", VA = "0x182F42BF0")]
	public T[] EDODIKJEPFD<T>(ushort BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x607C700", Offset = "0x607B100", VA = "0x18607C700")]
	public bool[] ENIDKJGJEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x607C4A0", Offset = "0x607AEA0", VA = "0x18607C4A0")]
	public ushort[] BGECFKLCFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x607C830", Offset = "0x607B230", VA = "0x18607C830")]
	public short[] GBNMEANACMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x607CD10", Offset = "0x607B710", VA = "0x18607CD10")]
	public int[] NDDKCNCAIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x607C870", Offset = "0x607B270", VA = "0x18607C870")]
	public uint[] GGHHHFMAIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x607C7F0", Offset = "0x607B1F0", VA = "0x18607C7F0")]
	public float[] FMOPHLHDCIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x607C460", Offset = "0x607AE60", VA = "0x18607C460")]
	public double[] ADCKLMJDDHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x607C7B0", Offset = "0x607B1B0", VA = "0x18607C7B0")]
	public long[] FDGHBJAFHPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x607C990", Offset = "0x607B390", VA = "0x18607C990")]
	public ulong[] IOHELNEEHGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x607C5D0", Offset = "0x607AFD0", VA = "0x18607C5D0")]
	public string[] EIPBNLCCILP(int LOJCKNMLPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x607C590", Offset = "0x607AF90", VA = "0x18607C590")]
	public bool EIFNAAKGFFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x607C8B0", Offset = "0x607B2B0", VA = "0x18607C8B0")]
	public char GONLCMGFPMP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x607C8B0", Offset = "0x607B2B0", VA = "0x18607C8B0")]
	public ushort IGNPEAKMHHC()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x607CB50", Offset = "0x607B550", VA = "0x18607CB50")]
	public short KPJBALKOLAF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x607C920", Offset = "0x607B320", VA = "0x18607C920")]
	public long HCEANOIHCHK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x607C740", Offset = "0x607B140", VA = "0x18607C740")]
	public ulong FCKMKKPEOAI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x607CD50", Offset = "0x607B750", VA = "0x18607CD50")]
	public int OAOEEFCMBOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x607CC40", Offset = "0x607B640", VA = "0x18607CC40")]
	public uint MHBCIAHHBLM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x607CBD0", Offset = "0x607B5D0", VA = "0x18607CBD0")]
	public float MFDIJFDHPGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x607CAA0", Offset = "0x607B4A0", VA = "0x18607CAA0")]
	public double JFHDKAKELCP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x607C1E0", Offset = "0x607ABE0", VA = "0x18607C1E0")]
	public string ABBOAADIAKE(int DOBHOIOIHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x607C520", Offset = "0x607AF20", VA = "0x18607C520")]
	public ArraySegment<byte> EIFLJIGOKFP(int FIGHABPEBPG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x607CB10", Offset = "0x607B510", VA = "0x18607CB10")]
	public sbyte[] KILFGEFPNCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x607C420", Offset = "0x607AE20", VA = "0x18607C420")]
	public byte[] ACHECFPMIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x607CCB0", Offset = "0x607B6B0", VA = "0x18607CCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x606A0D0", Offset = "0x6068AD0", VA = "0x18606A0D0")]
	public GDDHLOJHPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x606A150", Offset = "0x6068B50", VA = "0x18606A150")]
	public GDDHLOJHPLL(bool HLLIEAEAPND, int ELEBLFBMJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6069FE0", Offset = "0x60689E0", VA = "0x186069FE0")]
	public static GDDHLOJHPLL PEHDMGJNKEM(string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6069F40", Offset = "0x6068940", VA = "0x186069F40")]
	public void NCDLHGPFAJE(int IEHKAGPEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x20D51E0", Offset = "0x20D3BE0", VA = "0x1820D51E0")]
	public void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6069CA0", Offset = "0x60686A0", VA = "0x186069CA0")]
	public void HHOJKOPNNFC(float KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6069D40", Offset = "0x6068740", VA = "0x186069D40")]
	public void HHOJKOPNNFC(double KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6069970", Offset = "0x6068370", VA = "0x186069970")]
	public void HHOJKOPNNFC(long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6069970", Offset = "0x6068370", VA = "0x186069970")]
	public void HHOJKOPNNFC(ulong KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60698E0", Offset = "0x60682E0", VA = "0x1860698E0")]
	public void HHOJKOPNNFC(int KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60698E0", Offset = "0x60682E0", VA = "0x1860698E0")]
	public void HHOJKOPNNFC(uint KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60699C0", Offset = "0x60683C0", VA = "0x1860699C0")]
	public void HHOJKOPNNFC(char KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60699C0", Offset = "0x60683C0", VA = "0x1860699C0")]
	public void HHOJKOPNNFC(ushort KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60699C0", Offset = "0x60683C0", VA = "0x1860699C0")]
	public void HHOJKOPNNFC(short KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6069A30", Offset = "0x6068430", VA = "0x186069A30")]
	public void HHOJKOPNNFC(sbyte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6069A30", Offset = "0x6068430", VA = "0x186069A30")]
	public void HHOJKOPNNFC(byte KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6069E70", Offset = "0x6068870", VA = "0x186069E70")]
	public void HHOJKOPNNFC(byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60693B0", Offset = "0x6067DB0", VA = "0x1860693B0")]
	public void CEIIPIGOIBK(sbyte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60693B0", Offset = "0x6067DB0", VA = "0x1860693B0")]
	public void GFNLFAEFDEB(byte[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6069EE0", Offset = "0x60688E0", VA = "0x186069EE0")]
	public void HHOJKOPNNFC(bool KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6069720", Offset = "0x6068120", VA = "0x186069720")]
	public void DFJOIBDEJEB(Array OLFJJNHNEOC, int CBNJMEBNJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6069570", Offset = "0x6067F70", VA = "0x186069570")]
	public void DFJOIBDEJEB(float[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6069490", Offset = "0x6067E90", VA = "0x186069490")]
	public void DFJOIBDEJEB(double[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6069490", Offset = "0x6067E90", VA = "0x186069490")]
	public void DFJOIBDEJEB(long[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6069490", Offset = "0x6067E90", VA = "0x186069490")]
	public void DFJOIBDEJEB(ulong[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6069570", Offset = "0x6067F70", VA = "0x186069570")]
	public void DFJOIBDEJEB(int[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6069570", Offset = "0x6067F70", VA = "0x186069570")]
	public void DFJOIBDEJEB(uint[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6069800", Offset = "0x6068200", VA = "0x186069800")]
	public void DFJOIBDEJEB(ushort[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6069800", Offset = "0x6068200", VA = "0x186069800")]
	public void DFJOIBDEJEB(short[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60693B0", Offset = "0x6067DB0", VA = "0x1860693B0")]
	public void DFJOIBDEJEB(bool[] KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6069650", Offset = "0x6068050", VA = "0x186069650")]
	public void DFJOIBDEJEB(string[] KLABJGGMBGH, int LHLAMDPNODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6069DA0", Offset = "0x60687A0", VA = "0x186069DA0")]
	public void HHOJKOPNNFC(IPEndPoint COCCJPGAHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6069D90", Offset = "0x6068790", VA = "0x186069D90")]
	public void HHOJKOPNNFC(string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6069A90", Offset = "0x6068490", VA = "0x186069A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A39B20", Offset = "0x3A38520", VA = "0x183A39B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NEDFPECCBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47DDDB0", Offset = "0x47DC7B0", VA = "0x1847DDDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LIKCNONKGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x44D47F0", Offset = "0x44D31F0", VA = "0x1844D47F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x606A3F0", Offset = "0x6068DF0", VA = "0x18606A3F0")]
	public GHDPNEGIGIO(int LOJCKNMLPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE4A0", Offset = "0x2ACCEA0", VA = "0x182ACE4A0", Slot = "4")]
	protected virtual ulong IEIANCELHGK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x606A270", Offset = "0x6068C70", VA = "0x18606A270", Slot = "5")]
	protected virtual BPPMFMKMAGB JBILEDMMMIE(PKILOIGDLDE JEAKAGANOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5990", Offset = "0x2DA4390", VA = "0x182DA5990", Slot = "6")]
	protected virtual void CHEHIACHMPP<T>(GDDHLOJHPLL NFLODIHODLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x606A1F0", Offset = "0x6068BF0", VA = "0x18606A1F0")]
	public void IABHIPJBNIM(PKILOIGDLDE JEAKAGANOAM, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5D80", Offset = "0x2DA4780", VA = "0x182DA5D80")]
	public void GMAKAKDGBAO<T>(GDDHLOJHPLL NFLODIHODLH, T BHIJKPOILFM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x606A3A0", Offset = "0x6068DA0", VA = "0x18606A3A0")]
	public void LLIFKAJEMLF(PKILOIGDLDE JEAKAGANOAM, object KHBHLJCCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5BC0", Offset = "0x2DA45C0", VA = "0x182DA5BC0")]
	public void FBELDPGCPDF<T>(Action<T> MLJIACDBHFH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5A00", Offset = "0x2DA4400", VA = "0x182DA5A00")]
	public void FBELDPGCPDF<T, TUserData>(Action<T, TUserData> MLJIACDBHFH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ECGLAELGPHM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6067920", Offset = "0x6066320", VA = "0x186067920")]
	public ECGLAELGPHM(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FLEPOIGDNBJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6068910", Offset = "0x6067310", VA = "0x186068910")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E755C0", Offset = "0x3E73FC0", VA = "0x183E755C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x567E310", Offset = "0x567CD10", VA = "0x18567E310", Slot = "7")]
		public override void GHBCPJJLPGK(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x567FAE0", Offset = "0x567E4E0", VA = "0x18567FAE0", Slot = "8")]
		public override void KOEEPLGHGJB(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x567F030", Offset = "0x567DA30", VA = "0x18567F030", Slot = "9")]
		public override void HAOEIECHALI(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x567D3B0", Offset = "0x567BDB0", VA = "0x18567D3B0", Slot = "10")]
		public override void BJBIFECFJFH(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x567F2D0", Offset = "0x567DCD0", VA = "0x18567F2D0")]
		protected TProperty[] ICAJGCKCIDM(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x567DB90", Offset = "0x567C590", VA = "0x18567DB90")]
		protected TProperty[] EPKLLLGNKGM(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5679610", Offset = "0x5678010", VA = "0x185679610", Slot = "4")]
		public override void AMLGEKNOMHA(MethodInfo NBJFCJLOEFB, MethodInfo AOINJBCMIHF, MFLEMJFBBLJ JLAAKHANEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4029050", Offset = "0x4027A50", VA = "0x184029050")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A5B4F0", Offset = "0x3A59EF0", VA = "0x183A5B4F0", Slot = "5")]
		public override void GAPGEIOILGP(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B7A0", Offset = "0x3A5A1A0", VA = "0x183A5B7A0", Slot = "6")]
		public override void GMAKAKDGBAO(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B650", Offset = "0x3A5A050", VA = "0x183A5B650", Slot = "7")]
		public override void GHBCPJJLPGK(TClass DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B8F0", Offset = "0x3A5A2F0", VA = "0x183A5B8F0", Slot = "8")]
		public override void KOEEPLGHGJB(TClass DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B9B0", Offset = "0x3A5A3B0", VA = "0x183A5B9B0")]
		protected ENIFPDMDOPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class NKABCFIODPI<T> : CILLPCCIEME<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x47FD2E0", Offset = "0x47FBCE0", VA = "0x1847FD2E0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F52630", Offset = "0x3F51030", VA = "0x183F52630", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x47FD360", Offset = "0x47FBD60", VA = "0x1847FD360", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F526A0", Offset = "0x3F510A0", VA = "0x183F526A0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public NKABCFIODPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HLHMMAHLJON<T> : CILLPCCIEME<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F52530", Offset = "0x3F50F30", VA = "0x183F52530", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F52630", Offset = "0x3F51030", VA = "0x183F52630", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F525B0", Offset = "0x3F50FB0", VA = "0x183F525B0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F526A0", Offset = "0x3F510A0", VA = "0x183F526A0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public HLHMMAHLJON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class GLBAFLIBEAH<T> : CILLPCCIEME<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3EE34C0", Offset = "0x3EE1EC0", VA = "0x183EE34C0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3EE35C0", Offset = "0x3EE1FC0", VA = "0x183EE35C0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3540", Offset = "0x3EE1F40", VA = "0x183EE3540", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3630", Offset = "0x3EE2030", VA = "0x183EE3630", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public GLBAFLIBEAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DGPBBDKGIJF<T> : CILLPCCIEME<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5B40AA0", Offset = "0x5B3F4A0", VA = "0x185B40AA0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE35C0", Offset = "0x3EE1FC0", VA = "0x183EE35C0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5B40B20", Offset = "0x5B3F520", VA = "0x185B40B20", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3630", Offset = "0x3EE2030", VA = "0x183EE3630", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public DGPBBDKGIJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CGBLGMGAFOG<T> : CILLPCCIEME<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5668940", Offset = "0x5667340", VA = "0x185668940", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4804AC0", Offset = "0x48034C0", VA = "0x184804AC0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x56689C0", Offset = "0x56673C0", VA = "0x1856689C0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A210", Offset = "0x3F58C10", VA = "0x183F5A210", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public CGBLGMGAFOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NMDKPPMNNFO<T> : CILLPCCIEME<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x48049C0", Offset = "0x48033C0", VA = "0x1848049C0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4804AC0", Offset = "0x48034C0", VA = "0x184804AC0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4804A40", Offset = "0x4803440", VA = "0x184804A40", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A210", Offset = "0x3F58C10", VA = "0x183F5A210", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public NMDKPPMNNFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class KCENHFCDOJD<T> : CILLPCCIEME<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F310D0", Offset = "0x3F2FAD0", VA = "0x183F310D0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F311D0", Offset = "0x3F2FBD0", VA = "0x183F311D0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4410360", Offset = "0x440ED60", VA = "0x184410360", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F31240", Offset = "0x3F2FC40", VA = "0x183F31240", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public KCENHFCDOJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HBNLNCIJLGC<T> : CILLPCCIEME<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F310D0", Offset = "0x3F2FAD0", VA = "0x183F310D0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F311D0", Offset = "0x3F2FBD0", VA = "0x183F311D0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F31150", Offset = "0x3F2FB50", VA = "0x183F31150", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F31240", Offset = "0x3F2FC40", VA = "0x183F31240", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public HBNLNCIJLGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CKONHKHDKPJ<T> : CILLPCCIEME<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5857000", Offset = "0x5855A00", VA = "0x185857000", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5857100", Offset = "0x5855B00", VA = "0x185857100", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5857080", Offset = "0x5855A80", VA = "0x185857080", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F526A0", Offset = "0x3F510A0", VA = "0x183F526A0", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public CKONHKHDKPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HOOPCCOJLJI<T> : CILLPCCIEME<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A0A0", Offset = "0x3F58AA0", VA = "0x183F5A0A0", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A1A0", Offset = "0x3F58BA0", VA = "0x183F5A1A0", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A120", Offset = "0x3F58B20", VA = "0x183F5A120", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A210", Offset = "0x3F58C10", VA = "0x183F5A210", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public HOOPCCOJLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NEACBDLCGHD<T> : CILLPCCIEME<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x47DD950", Offset = "0x47DC350", VA = "0x1847DD950", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x47DDA50", Offset = "0x47DC450", VA = "0x1847DDA50", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x47DD9D0", Offset = "0x47DC3D0", VA = "0x1847DD9D0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F31240", Offset = "0x3F2FC40", VA = "0x183F31240", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC400", VA = "0x183EADA00")]
		public NEACBDLCGHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BIMDKHKMJGH<T> : ENIFPDMDOPI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x517AFD0", Offset = "0x51799D0", VA = "0x18517AFD0", Slot = "12")]
		protected override void NMBCLGAHMDP(GDDHLOJHPLL BPBILCHNBCA, char OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x517AFA0", Offset = "0x51799A0", VA = "0x18517AFA0", Slot = "11")]
		protected override void KCBIGHDDOGB(PKILOIGDLDE CGJIPKMEOFC, [Out] char OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C460", Offset = "0x3E5AE60", VA = "0x183E5C460")]
		public BIMDKHKMJGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class MFGJNIAHCKE<T> : ENIFPDMDOPI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x47667B0", Offset = "0x47651B0", VA = "0x1847667B0", Slot = "12")]
		protected override void NMBCLGAHMDP(GDDHLOJHPLL BPBILCHNBCA, IPEndPoint OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4766770", Offset = "0x4765170", VA = "0x184766770", Slot = "11")]
		protected override void KCBIGHDDOGB(PKILOIGDLDE CGJIPKMEOFC, [Out] IPEndPoint OLLAHGLHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C460", Offset = "0x3E5AE60", VA = "0x183E5C460")]
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
		[Cpp2IlInjected.Address(RVA = "0x4444360", Offset = "0x4442D60", VA = "0x184444360")]
		public KNLDJPEIECA(int DOBHOIOIHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4444160", Offset = "0x4442B60", VA = "0x184444160", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4444260", Offset = "0x4442C60", VA = "0x184444260", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x44441E0", Offset = "0x4442BE0", VA = "0x1844441E0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x44442E0", Offset = "0x4442CE0", VA = "0x1844442E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4909D90", Offset = "0x4908790", VA = "0x184909D90")]
		public OOACMFCFDEP(PropertyInfo PKFJNPAMFMB, Type HNOODGILILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4909B00", Offset = "0x4908500", VA = "0x184909B00", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4909C20", Offset = "0x4908620", VA = "0x184909C20", Slot = "6")]
		public override void GMAKAKDGBAO(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4909BC0", Offset = "0x49085C0", VA = "0x184909BC0", Slot = "7")]
		public override void GHBCPJJLPGK(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4909D30", Offset = "0x4908730", VA = "0x184909D30", Slot = "8")]
		public override void KOEEPLGHGJB(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4909CD0", Offset = "0x49086D0", VA = "0x184909CD0", Slot = "9")]
		public override void HAOEIECHALI(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4909AA0", Offset = "0x49084A0", VA = "0x184909AA0", Slot = "10")]
		public override void BJBIFECFJFH(T DBDKDMMKEIK, GDDHLOJHPLL BPBILCHNBCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FHPJNDCKILL<T> : OOACMFCFDEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
		public FHPJNDCKILL(PropertyInfo PKFJNPAMFMB, Type HNOODGILILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5B10", Offset = "0x3DF4510", VA = "0x183DF5B10", Slot = "5")]
		public override void GAPGEIOILGP(T DBDKDMMKEIK, PKILOIGDLDE CGJIPKMEOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5BD0", Offset = "0x3DF45D0", VA = "0x183DF5BD0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E13210", Offset = "0x3E11C10", VA = "0x183E13210")]
		public FPIJGDNPHNC(List<ACIANJCOFEI<T>> LFHCNPKDJNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E13160", Offset = "0x3E11B60", VA = "0x183E13160")]
		public void GMAKAKDGBAO(T GHMNBJIOGAM, GDDHLOJHPLL NFLODIHODLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E130B0", Offset = "0x3E11AB0", VA = "0x183E130B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x607BF60", Offset = "0x607A960", VA = "0x18607BF60")]
	public OAGLOFGPGJB(int LOJCKNMLPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2F15240", Offset = "0x2F13C40", VA = "0x182F15240")]
	private FPIJGDNPHNC<T> OJLHALDDCEP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3970", Offset = "0x2AD2370", VA = "0x182AD3970")]
	public void JJJMHPMEAIK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2F151A0", Offset = "0x2F13BA0", VA = "0x182F151A0")]
	public bool CENBFOHJAFB<T>(PKILOIGDLDE JEAKAGANOAM, T LLMCGMPLMBL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2F15110", Offset = "0x2F13B10", VA = "0x182F15110")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6073480", Offset = "0x6071E80", VA = "0x186073480")]
		get
		{
			return default(CDOFKNGAHHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PIGIHDPANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x60734B0", Offset = "0x6071EB0", VA = "0x1860734B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x60733E0", Offset = "0x6071DE0", VA = "0x1860733E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KGCAFEIIDLI EMGADGGKFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6073420", Offset = "0x6071E20", VA = "0x186073420")]
		get
		{
			return default(KGCAFEIIDLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6073940", Offset = "0x6072340", VA = "0x186073940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FPOMJLHMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6074030", Offset = "0x6072A30", VA = "0x186074030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint CACMOODPKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60742C0", Offset = "0x6072CC0", VA = "0x1860742C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? FHECLHLDILE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6073450", Offset = "0x6071E50", VA = "0x186073450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? NKNIOCLJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6073B80", Offset = "0x6072580", VA = "0x186073B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? KGABLCBDBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6074290", Offset = "0x6072C90", VA = "0x186074290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60740C0", Offset = "0x6072AC0", VA = "0x1860740C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? ENFIOPIAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xE88380", Offset = "0xE86D80", VA = "0x180E88380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xCCF410", Offset = "0xCCDE10", VA = "0x180CCF410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6074450", Offset = "0x6072E50", VA = "0x186074450")]
	public IOKBCLOJJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x60743A0", Offset = "0x6072DA0", VA = "0x1860743A0")]
	internal IOKBCLOJJIH(byte[] CNGBPDKMHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6073BB0", Offset = "0x60725B0", VA = "0x186073BB0")]
	public static IOKBCLOJJIH GAHLIHALLKP(byte[] CNGBPDKMHBB, DateTime NJNIMMDEFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6073980", Offset = "0x6072380", VA = "0x186073980")]
	internal void EMLIELIPOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x60736B0", Offset = "0x60720B0", VA = "0x1860736B0")]
	private void DHGFMPDNCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6073E30", Offset = "0x6072830", VA = "0x186073E30")]
	private DateTime? GLOJKIKEPCL(int IEHCONIHMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x60734E0", Offset = "0x6071EE0", VA = "0x1860734E0")]
	private void DFEJIOCEMFN(int IEHCONIHMPO, DateTime? KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6073CD0", Offset = "0x60726D0", VA = "0x186073CD0")]
	private ulong GLKLILFPPJI(int IEHCONIHMPO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6073880", Offset = "0x6072280", VA = "0x186073880")]
	private void DIHDNKBLFJB(int IEHCONIHMPO, ulong KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6073DA0", Offset = "0x60727A0", VA = "0x186073DA0")]
	private uint GLLNBDOANIG(int IEHCONIHMPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3B560", Offset = "0x5F39F60", VA = "0x185F3B560")]
	private static uint KMCANCFIHCE(uint NCPIGLMANIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6074060", Offset = "0x6072A60", VA = "0x186074060")]
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
		[Cpp2IlInjected.Address(RVA = "0x6067930", Offset = "0x6066330", VA = "0x186067930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6067940", Offset = "0x6066340", VA = "0x186067940")]
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
		[Cpp2IlInjected.Address(RVA = "0x606ACC0", Offset = "0x60696C0", VA = "0x18606ACC0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ODLECPPFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x606A5D0", Offset = "0x6068FD0", VA = "0x18606A5D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FJGIOONILLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x606A6E0", Offset = "0x60690E0", VA = "0x18606A6E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily CBIHBJBAOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x44ABBE0", Offset = "0x44AA5E0", VA = "0x1844ABBE0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x606ACE0", Offset = "0x60696E0", VA = "0x18606ACE0")]
	public GLHHNMMBJKD(AddressFamily AIADLOOADGL, HLFOIBHLJDH JMOCLHPHNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x606A700", Offset = "0x6069100", VA = "0x18606A700", Slot = "8")]
	public bool GOHMKFMJHOE(IPEndPoint COCCJPGAHOG, EGNDMCLNBPC MCKMIFDDEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x606A590", Offset = "0x6068F90", VA = "0x18606A590", Slot = "9")]
	public int BBDFKCGAMMI(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int BHEAFIOEIAD, IPEndPoint EGIABGNOHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x606A5F0", Offset = "0x6068FF0", VA = "0x18606A5F0", Slot = "10")]
	public int EMDCFNEBBEI(byte[] DJOHOLIEOKK, EndPoint BANBMMLEDBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x606A570", Offset = "0x6068F70", VA = "0x18606A570", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x607C0F0", Offset = "0x607AAF0", VA = "0x18607C0F0")]
	public OBIAOFNCOGA(byte[] LKGIJLGOFHC, int PMAKCKDPHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8BFCB0", Offset = "0x8BE6B0", VA = "0x1808BFCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x607C0B0", Offset = "0x607AAB0", VA = "0x18607C0B0", Slot = "4")]
	public bool Equals(OBIAOFNCOGA PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x607C000", Offset = "0x607AA00", VA = "0x18607C000", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x217CBC0", Offset = "0x217B5C0", VA = "0x18217CBC0")]
	public DFKAHLHIEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6067A30", Offset = "0x6066430", VA = "0x186067A30")]
	public void EBACJEABAPF(IPEndPoint COCCJPGAHOG, byte[] LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6068090", Offset = "0x6066A90", VA = "0x186068090")]
	public void LPIFMBCCONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6067BE0", Offset = "0x60665E0", VA = "0x186067BE0", Slot = "4")]
	public override void FOJGGGEDOPP(IPEndPoint COCCJPGAHOG, byte[] JGCMECODHDI, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6068170", Offset = "0x6066B70", VA = "0x186068170", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x607D190", Offset = "0x607BB90", VA = "0x18607D190")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x607D2B0", Offset = "0x607BCB0", VA = "0x18607D2B0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x607CEC0", Offset = "0x607B8C0", VA = "0x18607CEC0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x607CF60", Offset = "0x607B960", VA = "0x18607CF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x60721D0", Offset = "0x6070BD0", VA = "0x1860721D0")]
	private void LFBMALNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6071F70", Offset = "0x6070970", VA = "0x186071F70")]
	private uint DPPFNNEHAEI(uint LEKEIHPCIEI, int GNHPOGJPDFJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6065DD0", Offset = "0x60647D0", VA = "0x186065DD0")]
	private void FHDGGLGJPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6065F80", Offset = "0x6064980", VA = "0x186065F80")]
	private void PJGJOCFIFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6065D40", Offset = "0x6064740", VA = "0x186065D40")]
	private void DCEPFKJGEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6065E80", Offset = "0x6064880", VA = "0x186065E80")]
	private void JDJDODMMEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6071FA0", Offset = "0x60709A0", VA = "0x186071FA0")]
	private void EKGOJCJOOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6072250", Offset = "0x6070C50", VA = "0x186072250")]
	private unsafe void LPHEHNOIJFA(byte* FFLOFEAGGMO, uint* LFOBGDLOPID, uint* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x60720E0", Offset = "0x6070AE0", VA = "0x1860720E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void GKMCHNPBOCM([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6072000", Offset = "0x6070A00", VA = "0x186072000")]
	public static void GKMCHNPBOCM(Span<byte> FFLOFEAGGMO, Span<byte> LFOBGDLOPID, Span<byte> BPFOOPFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6072670", Offset = "0x6071070", VA = "0x186072670")]
	public static void OAAAHKBIHCA(Span<byte> FFLOFEAGGMO, Span<byte> LFOBGDLOPID, Span<byte> BPFOOPFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6072160", Offset = "0x6070B60", VA = "0x186072160")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KOAHKIGHNDJ([NoAlias] byte* FFLOFEAGGMO, [NoAlias] byte* LFOBGDLOPID, [NoAlias] byte* BPFOOPFJNMI, int KHMKAEGDPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x607D500", Offset = "0x607BF00", VA = "0x18607D500")]
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
