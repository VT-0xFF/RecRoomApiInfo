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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LEPNJGPCINO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum MLBFEMAEIGO
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
		private NetworkManager MGELHMKJJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, CLBGLLCCHCN> PBOGDKENKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GPEKHAJOCAG GCAJKAIEMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] BJOJDHFKGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MLBFEMAEIGO OAMECFEEAOG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong KOKLKHACBGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GIOHJJCMHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x61EC140", Offset = "0x61EB540", VA = "0x1861EC140", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61EB6D0", Offset = "0x61EAAD0", VA = "0x1861EB6D0")]
		public void RecRoom_SetEncryptionInfo(ulong OJJIDGKFJMC, byte[] GMJINMLEEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61EB6B0", Offset = "0x61EAAB0", VA = "0x1861EB6B0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61EB580", Offset = "0x61EA980", VA = "0x1861EB580")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61EC040", Offset = "0x61EB440", VA = "0x1861EC040")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61EB7F0", Offset = "0x61EABF0", VA = "0x1861EB7F0", Slot = "6")]
		public override void Send(ulong EIGAHFMGPMM, ArraySegment<byte> MPMEGOKIEPF, NetworkDelivery NOPAGMJONCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61EB670", Offset = "0x61EAA70", VA = "0x1861EB670", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong EIGAHFMGPMM, [Out] ArraySegment<byte> NNNHDMLPIGD, [Out] float HPNLDHDOONL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61EBAE0", Offset = "0x61EAEE0", VA = "0x1861EBAE0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61EBF60", Offset = "0x61EB360", VA = "0x1861EBF60", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61EAC90", Offset = "0x61EA090", VA = "0x1861EAC90", Slot = "10")]
		public override void DisconnectRemoteClient(ulong EIGAHFMGPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61EAB40", Offset = "0x61E9F40", VA = "0x1861EAB40", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61EB0A0", Offset = "0x61EA4A0", VA = "0x1861EB0A0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong EIGAHFMGPMM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61EBA70", Offset = "0x61EAE70", VA = "0x1861EBA70", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61EB2E0", Offset = "0x61EA6E0", VA = "0x1861EB2E0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MGELHMKJJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61EAA70", Offset = "0x61E9E70", VA = "0x1861EAA70")]
		private IPCMFENNKEO ACKHNJMFAIP(NetworkDelivery LGJDMOCCBDP)
		{
			return default(IPCMFENNKEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61EB4A0", Offset = "0x61EA8A0", VA = "0x1861EB4A0", Slot = "15")]
		private void LJNNOEDGCAO(CLBGLLCCHCN FBEECAAIAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61EB140", Offset = "0x61EA540", VA = "0x1861EB140", Slot = "16")]
		private void HHIEMMMBHCC(CLBGLLCCHCN FBEECAAIAJE, CHFJBLHOANL KJJMEEGNPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "17")]
		private void PPIFBIDBGCP(IPEndPoint CFOFFHENLHF, SocketError BEHJAIIJLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61EAE60", Offset = "0x61EA260", VA = "0x1861EAE60", Slot = "18")]
		private void EGBBAJBHKHO(CLBGLLCCHCN FBEECAAIAJE, NJADAOEPPDA OJMAIJPBMNC, byte PNCAPLLLKGJ, IPCMFENNKEO NLAOGKFEKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61EB200", Offset = "0x61EA600", VA = "0x1861EB200")]
		private void HPDECPOAGOC(int MFKKELONDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "19")]
		private void EPEPKEBHHPC(IPEndPoint ICICJDJLDPH, NJADAOEPPDA OJMAIJPBMNC, DLLLNFGPIEP MLJDNDBGLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "20")]
		private void IFMKKJBCDJH(CLBGLLCCHCN FBEECAAIAJE, int HHILAPEKEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61EAE00", Offset = "0x61EA200", VA = "0x1861EAE00", Slot = "21")]
		private void EFEKGOBCPIL(EHJJADIAJIE JHKMPCADNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61EB070", Offset = "0x61EA470", VA = "0x1861EB070")]
		private ulong ENJIBEIIODN(CLBGLLCCHCN FBEECAAIAJE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61EB560", Offset = "0x61EA960", VA = "0x1861EB560")]
		private static int LODBBJJGKEG(float HEJMBOHMFMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61EC060", Offset = "0x61EB460", VA = "0x1861EC060")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class PLGAOIHCPPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly CLBGLLCCHCN HMEBFKMNFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HCJIDIJDGCA> BALINJHDKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int ALDEDOICELG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61EE520", Offset = "0x61ED920", VA = "0x1861EE520")]
	protected PLGAOIHCPPI(CLBGLLCCHCN FBEECAAIAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61EE4C0", Offset = "0x61ED8C0", VA = "0x1861EE4C0")]
	public void MKLBLICALNH(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61EE400", Offset = "0x61ED800", VA = "0x1861EE400")]
	protected void CGPOHMMLKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61EE480", Offset = "0x61ED880", VA = "0x1861EE480")]
	public bool ILJCAENPECE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool FPKKFBEMKID();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CEHDJJDDLJH(HCJIDIJDGCA PFIAKLEHODL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KNPFKKDOMDH
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
public class EHJJADIAJIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GPEKHAJOCAG GANEIDKMIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LIPKNKLCCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FJHAEOHGDLL EABFBKDMFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IHGAGEEONJL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KNPFKKDOMDH DMDANGLJDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E80", Offset = "0x8D2280", VA = "0x1808D2E80")]
		[CompilerGenerated]
		get
		{
			return default(KNPFKKDOMDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDE8390", Offset = "0xDE7790", VA = "0x180DE8390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD10", Offset = "0x61DD110", VA = "0x1861DDD10")]
	internal void CLNMDLBOGJM(FJHAEOHGDLL IAEOHBGLAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61DDCE0", Offset = "0x61DD0E0", VA = "0x1861DDCE0")]
	private bool CKAPENONBOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61DDDD0", Offset = "0x61DD1D0", VA = "0x1861DDDD0")]
	internal EHJJADIAJIE(IPEndPoint ICICJDJLDPH, FJHAEOHGDLL MFMHFCGCKKD, GPEKHAJOCAG CKGGOPMBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD70", Offset = "0x61DD170", VA = "0x1861DDD70")]
	public CLBGLLCCHCN PEOICNHECMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DLLLNFGPIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CFJIAMHMFBN
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
public struct CHFJBLHOANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CFJIAMHMFBN KLJDMNEMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError IJKLGJDGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NJADAOEPPDA GONCLNKIFNA;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LEPNJGPCINO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANKBINLLCJO(CLBGLLCCHCN FBEECAAIAJE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCKCFEMBLF(CLBGLLCCHCN FBEECAAIAJE, CHFJBLHOANL KJJMEEGNPKN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIMKGFNCHKK(IPEndPoint CFOFFHENLHF, SocketError BEHJAIIJLHM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEAGJJCEEOK(CLBGLLCCHCN FBEECAAIAJE, NJADAOEPPDA OJMAIJPBMNC, byte PNCAPLLLKGJ, IPCMFENNKEO NLAOGKFEKDN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJLKAFGNEKM(IPEndPoint ICICJDJLDPH, NJADAOEPPDA OJMAIJPBMNC, DLLLNFGPIEP MLJDNDBGLII);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDOCKFPKNAA(CLBGLLCCHCN FBEECAAIAJE, int HHILAPEKEGL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMLENACBOIF(EHJJADIAJIE JHKMPCADNAF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GOGDHDDFKEK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHGMDOIGNLO(CLBGLLCCHCN FBEECAAIAJE, object JIDEBNFKLLL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HLCGPHPJACG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBHNIAJLPPK(LPJJEIINLEI PFIAKLEHODL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BHDBBKONINP
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDEBNPBMABD(CLBGLLCCHCN FBEECAAIAJE, IPEndPoint MJNCFHFNJLG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FJHAEOHGDLL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NOALIBIBLLG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long FKFBPJJJHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte OCKIJAENONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] LDCBAHFOOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly ACGKEHIGCJJ BAFNFCIODAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int NFCAOLPNFHF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61DE3B0", Offset = "0x61DD7B0", VA = "0x1861DE3B0")]
	private FJHAEOHGDLL(long GJMOJECKEJO, byte JPCBAEFOHKG, int GKKCCKNHJKG, byte[] HDNAGBJGIDA, ACGKEHIGCJJ MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61DE130", Offset = "0x61DD530", VA = "0x1861DE130")]
	public static int BKDAKMOJEGA(HCJIDIJDGCA PFIAKLEHODL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61DE190", Offset = "0x61DD590", VA = "0x1861DE190")]
	public static FJHAEOHGDLL LILIIJKGODK(HCJIDIJDGCA PFIAKLEHODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61DDF50", Offset = "0x61DD350", VA = "0x1861DDF50")]
	public static HCJIDIJDGCA AKKFPOJPEOA(JGEOPGHBBHN ADPPDGLGFJJ, SocketAddress KCKEDJKLMMA, long IMJMJCGACJJ, int GKKCCKNHJKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class NFPHNPANFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long FKFBPJJJHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte OCKIJAENONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int NFCAOLPNFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool FHGILLAFIGJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE00", Offset = "0x61EC200", VA = "0x1861ECE00")]
	private NFPHNPANFBL(long GJMOJECKEJO, byte JPCBAEFOHKG, int IGPNANFDLAL, bool ICPJGKPKJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61ECCB0", Offset = "0x61EC0B0", VA = "0x1861ECCB0")]
	public static NFPHNPANFBL LILIIJKGODK(HCJIDIJDGCA PFIAKLEHODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61ECAC0", Offset = "0x61EBEC0", VA = "0x1861ECAC0")]
	public static HCJIDIJDGCA AKKFPOJPEOA(long IMJMJCGACJJ, byte CKPKPJJGDAO, int MNMDHLAMANP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61ECBB0", Offset = "0x61EBFB0", VA = "0x1861ECBB0")]
	public static HCJIDIJDGCA JONNDBDCGOB(CLBGLLCCHCN FBEECAAIAJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NKAJKHLJCBO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NKJGMABHCEM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBHABLMPJFJ(IPEndPoint DADONAOCFIE, IPEndPoint ICICJDJLDPH, string FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNAENAGIHOD(IPEndPoint LNAPPMMEEPD, NKAJKHLJCBO LGJDMOCCBDP, string FDAIGOGAKMH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BFHKLIAHALJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OKINEPKNGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint KFNKBFMKLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint IHGAGEEONJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string PLCFFPJIEOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct ACDGJCKHBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint DAMHLBHGEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NKAJKHLJCBO MKIIDBFDPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string PLCFFPJIEOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class KAFNLIGHADJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint FJCLONFJMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string PLCFFPJIEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KAFNLIGHADJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class KLAIAHMCNFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint FJCLONFJMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NPKCFAFEGAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PLCFFPJIEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KLAIAHMCNFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class EAFPKCMBLIH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PLCFFPJIEOD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IBJCHEFNGGD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B60D0", Offset = "0x8B54D0", VA = "0x1808B60D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EAFPKCMBLIH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GPEKHAJOCAG ONAFPCKLGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OKINEPKNGLG> ILNDLHAHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<ACDGJCKHBPG> OOBJFHPPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ACGKEHIGCJJ ONPICEEHHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JGEOPGHBBHN NECLLLECILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CJHIKDDGKML POMHMEEONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NKJGMABHCEM MAJFPDMCMGH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BPLGNMMGHGN = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool CNAPKFFGOAL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61D8970", Offset = "0x61D7D70", VA = "0x1861D8970")]
	internal BFHKLIAHALJ(GPEKHAJOCAG LPGLDDBIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61D84F0", Offset = "0x61D78F0", VA = "0x1861D84F0")]
	internal void IBANFHHFDKN(IPEndPoint BIMELIMHIJK, HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BE50E0", Offset = "0x2BE44E0", VA = "0x182BE50E0")]
	private void JKAHPJDAKCE<T>(T PFIAKLEHODL, IPEndPoint ANHPPPBDANF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61D8360", Offset = "0x61D7760", VA = "0x1861D8360")]
	private void HBHABLMPJFJ(KAFNLIGHADJ KIKIBLNOFAP, IPEndPoint BIMELIMHIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61D8810", Offset = "0x61D7C10", VA = "0x1861D8810")]
	private void OCJIOCFNPDI(KLAIAHMCNFM KIKIBLNOFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61D8670", Offset = "0x61D7A70", VA = "0x1861D8670")]
	private void MIOCBKGKJKL(EAFPKCMBLIH KIKIBLNOFAP, IPEndPoint BIMELIMHIJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IPCMFENNKEO : byte
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
public enum OLBHIJDEILC : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OIKHFJJCHND
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] HIIEFNAJBDH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int NGNMMHFPNHG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int FMDGLHOPJOB;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FIECLDIIDJO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61DDE40", Offset = "0x61DD240", VA = "0x1861DDE40")]
	public FIECLDIIDJO(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IFDNGMEMNHK : FIECLDIIDJO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61DDE40", Offset = "0x61DD240", VA = "0x1861DDE40")]
	public IFDNGMEMNHK(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JBEIGBJFADJ
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
public interface GJOHLDGGCMF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAAHGABEACF(JBEIGBJFADJ JJDCPJHHIHE, string PCMCEFKLCKL, params object[] HJEECPNIDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class IECEPJIHILC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static GJOHLDGGCMF KDAEDJFHHLI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MPCKCOKOKGI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61E6510", Offset = "0x61E5910", VA = "0x1861E6510")]
	private static void LEBKBAGDIDF(JBEIGBJFADJ NABJAFNFEHC, string PCMCEFKLCKL, params object[] HJEECPNIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61E64B0", Offset = "0x61E58B0", VA = "0x1861E64B0")]
	internal static void KLFKOPJPKIL(string PCMCEFKLCKL, params object[] HJEECPNIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61E6450", Offset = "0x61E5850", VA = "0x1861E6450")]
	internal static void IFAJDMCOECH(string PCMCEFKLCKL, params object[] HJEECPNIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61E63F0", Offset = "0x61E57F0", VA = "0x1861E63F0")]
	internal static void AIOIGHAFGBL(string PCMCEFKLCKL, params object[] HJEECPNIDIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LJFPAIHAMFA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NJADAOEPPDA : ACGKEHIGCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HCJIDIJDGCA EDHLJBGDHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GPEKHAJOCAG EIJEICEFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AJGGNMKKDPD HPOFPKFCNGM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61ECF70", Offset = "0x61EC370", VA = "0x1861ECF70")]
	internal NJADAOEPPDA(GPEKHAJOCAG HPCAPMNEHGA, AJGGNMKKDPD PAMPKMKNLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE80", Offset = "0x61EC280", VA = "0x1861ECE80")]
	internal void GEDPAJEEPKJ(HCJIDIJDGCA PFIAKLEHODL, int GDAHGCOAILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61ECEF0", Offset = "0x61EC2F0", VA = "0x1861ECEF0")]
	internal void INKEEDDHNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE50", Offset = "0x61EC250", VA = "0x1861ECE50")]
	public void EBNNHKDABLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class AJGGNMKKDPD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FAGDCAFOEOC
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
	public AJGGNMKKDPD HFOIJEAEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public FAGDCAFOEOC MKIIDBFDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public CLBGLLCCHCN HMEBFKMNFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint IHGAGEEONJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object BBDLEEKFEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GHLNEDLKGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError KAAFEEOFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public CFJIAMHMFBN BOAEMLNLPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public EHJJADIAJIE FDIMMPBNBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public IPCMFENNKEO GALECJJAAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte GHMIINHOBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly NJADAOEPPDA DLKLHIECOLC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61D8220", Offset = "0x61D7620", VA = "0x1861D8220")]
	public AJGGNMKKDPD(GPEKHAJOCAG HPCAPMNEHGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GPEKHAJOCAG : IEnumerable<CLBGLLCCHCN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LHHJACKHLCB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61E9660", Offset = "0x61E8A60", VA = "0x1861E9660", Slot = "4")]
		public bool Equals(IPEndPoint CFANGCOBGCF, IPEndPoint HHLCHNICLGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CABC60", Offset = "0x5CAB060", VA = "0x185CABC60", Slot = "5")]
		public int GetHashCode(IPEndPoint PBAACPJGKNP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LHHJACKHLCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct PDNBHNLFMGB : IEnumerator<CLBGLLCCHCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly CLBGLLCCHCN OLNBGMAAEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CLBGLLCCHCN EOLINGFFHLB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CLBGLLCCHCN BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x93F120", Offset = "0x93E520", VA = "0x18093F120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x13FEC00", Offset = "0x13FE000", VA = "0x1813FEC00")]
		public PDNBHNLFMGB(CLBGLLCCHCN EDLBBMLDLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61EE360", Offset = "0x61ED760", VA = "0x1861EE360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61EE3B0", Offset = "0x61ED7B0", VA = "0x1861EE3B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread GEIICDFPDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool EIABAMKIALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent MOFJGMHMIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<AJGGNMKKDPD> EAAHHPLCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<AJGGNMKKDPD> KIHJGNFGAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private AJGGNMKKDPD LDEDKHBMJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LEPNJGPCINO GHONMNKFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GOGDHDDFKEK GNEOJNIFNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HLCGPHPJACG OOIDPGIHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BHDBBKONINP JLMECEFGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, CLBGLLCCHCN> OBIBEBEBFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, EHJJADIAJIE> JEOBEIPFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, FEACDNGOBFO> NKIHINPAPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim KNCKBPGABKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private CLBGLLCCHCN EOOGIOAIFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OAGCJLMHBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<CLBGLLCCHCN> CGFNEBOMJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private CLBGLLCCHCN[] BGBGOKKIMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PKGMAAOBJIH NKFBLPBIKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int BOGBOHJBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> EFBBIDNDOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte KGOJFCNBLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object FBIIGDCDPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool HOHMIPJHKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool MIFEJJCFLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LIODMAJBCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int INGGIBIOIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JJLEDABKCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int LOMKAFKHGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DJIAJNNOFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool OPCBBHAAHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LKLOJLACCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int AHBKIHCDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int LFBEJJHDELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool CNAPKFFGOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool NHHDLOBONLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PHGPFKBMBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KODHAHGICIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int COADKNLPAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int BPNOECHNNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PIGPMPDELPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly ODKGPICFMFI AALGDOOGMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool NNPCINKIBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly BFHKLIAHALJ DDMJDLALDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool FHBPPFLDEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LJFPAIHAMFA CNDENFGNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PDKECMDIBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool LGDEGPIPLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool PPMIICCPAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool HCLMGDKEBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool ENOFNOFNOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HCJIDIJDGCA IHJFGHNIKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int GGOFJCJAEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object LNLALMPDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HCJIDIJDGCA CPBLDFMEFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MAOBKLMEBLF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int PGFLPMKBONB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int KIJDNHNNOIO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IJGFPNPJPAB CCOIILGFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IJGFPNPJPAB FKDHKFKKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DNEELCNJPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread CMFHHCEJILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint DMELIKBALKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint JKANMDEKFLD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] DMCOEPFINIH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] LONPAJNACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<FNAFMNMJFOK, IPEndPoint> EDEJBDKGNMC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress LHGBNNFKKBB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool LDJNLGAPLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int IKDEMBPGNOO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OLEDNOKCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF08D50", Offset = "0xF08150", VA = "0x180F08D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xF98400", Offset = "0xF97800", VA = "0x180F98400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KIOEHAEBADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19AED70", Offset = "0x19AE170", VA = "0x1819AED70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B0C0", Offset = "0x1D1A4C0", VA = "0x181D1B0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte KIFCKKMJFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD08A00", Offset = "0xD07E00", VA = "0x180D08A00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BMMDGCHLHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61DF0B0", Offset = "0x61DE4B0", VA = "0x1861DF0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short PAHPLNGFNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61E5010", Offset = "0x61E4410", VA = "0x1861E5010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61E1BB0", Offset = "0x61E0FB0", VA = "0x1861E1BB0")]
	public void INKIKBIHDNC(IPEndPoint CFOFFHENLHF, byte[] GMJINMLEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61E0140", Offset = "0x61DF540", VA = "0x1861E0140")]
	public void DHKJPMJAIFF(IPEndPoint CFOFFHENLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61E50D0", Offset = "0x61E44D0", VA = "0x1861E50D0")]
	private bool POGHBEDEHME(IPEndPoint CFOFFHENLHF, [Out] CLBGLLCCHCN FBEECAAIAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61DF3F0", Offset = "0x61DE7F0", VA = "0x1861DF3F0")]
	private void BNGLKDPIGIO(CLBGLLCCHCN FBEECAAIAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61E28F0", Offset = "0x61E1CF0", VA = "0x1861E28F0")]
	private void KAEAFCJCLDG(CLBGLLCCHCN FBEECAAIAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61E2B50", Offset = "0x61E1F50", VA = "0x1861E2B50")]
	private void LNCHAFHNBEL(CLBGLLCCHCN FBEECAAIAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61E5340", Offset = "0x61E4740", VA = "0x1861E5340")]
	public GPEKHAJOCAG(LEPNJGPCINO CKGGOPMBENM, [Optional] PKGMAAOBJIH AEPIAPIDCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61E0290", Offset = "0x61DF690", VA = "0x1861E0290")]
	internal void DNLMHMKGFDL(CLBGLLCCHCN AJGFDMIGALC, int HHILAPEKEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61E2940", Offset = "0x61E1D40", VA = "0x1861E2940")]
	internal void LCJJDNLJHLE(CLBGLLCCHCN AJGFDMIGALC, object JIDEBNFKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61E31A0", Offset = "0x61E25A0", VA = "0x1861E31A0")]
	internal void MBMFLLDFGGA(CLBGLLCCHCN FBEECAAIAJE, CFJIAMHMFBN POKPBEJPBMH, SocketError LDLNGDCKMJB, HCJIDIJDGCA PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61E2690", Offset = "0x61E1A90", VA = "0x1861E2690")]
	private void JHDAKPANKGM(CLBGLLCCHCN FBEECAAIAJE, CFJIAMHMFBN POKPBEJPBMH, SocketError LDLNGDCKMJB, bool DPEDJCGKFCE, byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int MGEMHICLKEP, HCJIDIJDGCA PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61E2DC0", Offset = "0x61E21C0", VA = "0x1861E2DC0")]
	private void LPMGJBDHLIF(AJGGNMKKDPD.FAGDCAFOEOC LGJDMOCCBDP, [Optional] CLBGLLCCHCN FBEECAAIAJE, [Optional] IPEndPoint ICICJDJLDPH, SocketError CCPMBLJCLDM = SocketError.Success, int HHILAPEKEGL = 0, CFJIAMHMFBN GMNFILMMKIJ = CFJIAMHMFBN.ConnectionFailed, [Optional] EHJJADIAJIE NADANKMLIEO, IPCMFENNKEO NLAOGKFEKDN = IPCMFENNKEO.Unreliable, byte PNCAPLLLKGJ = 0, [Optional] HCJIDIJDGCA FJCBIPFFGOA, [Optional] object JIDEBNFKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61DE600", Offset = "0x61DDA00", VA = "0x1861DE600")]
	private void AGAKEECIDKD(AJGGNMKKDPD PAMPKMKNLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61E32D0", Offset = "0x61E26D0", VA = "0x1861E32D0")]
	internal void NECKLDBPFBM(AJGGNMKKDPD PAMPKMKNLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61E0750", Offset = "0x61DFB50", VA = "0x1861E0750")]
	private void EKOBBINDOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61DF0D0", Offset = "0x61DE4D0", VA = "0x1861DF0D0")]
	private void BHCKHGFJDJO(int BADBLBKFDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61DF6D0", Offset = "0x61DEAD0", VA = "0x1861DF6D0")]
	internal CLBGLLCCHCN CCGFILJPDAE(EHJJADIAJIE JHKMPCADNAF, byte[] AIKAADBNPDN, int AKMLIMIBFHO, int IDHDBIDGMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61DFDF0", Offset = "0x61DF1F0", VA = "0x1861DFDF0")]
	private int CMNAIFLBBIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61E47F0", Offset = "0x61E3BF0", VA = "0x1861E47F0")]
	private void OMEEGDOLGCI(IPEndPoint ICICJDJLDPH, CLBGLLCCHCN MGHAGHPLFON, FJHAEOHGDLL LPOJIPHAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61E3A30", Offset = "0x61E2E30", VA = "0x1861E3A30")]
	private void OHJLKPNBLGG(HCJIDIJDGCA PFIAKLEHODL, IPEndPoint ICICJDJLDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61DEDD0", Offset = "0x61DE1D0", VA = "0x1861DEDD0")]
	internal void ALJBGBLAIGF(HCJIDIJDGCA PFIAKLEHODL, IPCMFENNKEO INACCIEGKKO, byte PNCAPLLLKGJ, int GDAHGCOAILA, CLBGLLCCHCN AJGFDMIGALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61E1DD0", Offset = "0x61E11D0", VA = "0x1861E1DD0")]
	public bool IOGIABOPHFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61E1E40", Offset = "0x61E1240", VA = "0x1861E1E40")]
	public bool IOGIABOPHFE(IPAddress HCHJFFFCFDA, IPAddress GAJIHHCKBNO, int MPICFOLCBBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61E1E60", Offset = "0x61E1260", VA = "0x1861E1E60")]
	public bool IOGIABOPHFE(int MPICFOLCBBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61E1850", Offset = "0x61E0C50", VA = "0x1861E1850")]
	public void INCOCNGMFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61E0F40", Offset = "0x61E0340", VA = "0x1861E0F40")]
	public CLBGLLCCHCN EPNPPBONKIG(string IKLMBMAPKMB, int MPICFOLCBBC, string GMJINMLEEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61E0E60", Offset = "0x61E0260", VA = "0x1861E0E60")]
	public CLBGLLCCHCN EPNPPBONKIG(string IKLMBMAPKMB, int MPICFOLCBBC, JGEOPGHBBHN IBCKBHDMGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A90", Offset = "0x61DFE90", VA = "0x1861E0A90")]
	public CLBGLLCCHCN EPNPPBONKIG(IPEndPoint ANHPPPBDANF, JGEOPGHBBHN IBCKBHDMGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61E0740", Offset = "0x61DFB40", VA = "0x1861E0740")]
	public void EJMCDLIDJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61E03F0", Offset = "0x61DF7F0", VA = "0x1861E03F0")]
	public void EJMCDLIDJPF(bool HNEKMMAFMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61E4DF0", Offset = "0x61E41F0", VA = "0x1861E4DF0")]
	public void PEFMFIDDCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61E4EF0", Offset = "0x61E42F0", VA = "0x1861E4EF0")]
	public void PEFMFIDDCOJ(byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61E2840", Offset = "0x61E1C40", VA = "0x1861E2840")]
	public void JHDAKPANKGM(CLBGLLCCHCN FBEECAAIAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61E2780", Offset = "0x61E1B80", VA = "0x1861E2780")]
	public void JHDAKPANKGM(CLBGLLCCHCN FBEECAAIAJE, byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61E5160", Offset = "0x61E4560", VA = "0x1861E5160", Slot = "4")]
	private IEnumerator<CLBGLLCCHCN> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61E51F0", Offset = "0x61E45F0", VA = "0x1861E51F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61E2990", Offset = "0x61E1D90", VA = "0x1861E2990")]
	private HCJIDIJDGCA LEEGANELOMM(NNGKKJNFEFI NHOIMDHCPOO, int MFKKELONDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61E2A70", Offset = "0x61E1E70", VA = "0x1861E2A70")]
	private HCJIDIJDGCA LEEGANELOMM(NNGKKJNFEFI NHOIMDHCPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61E1280", Offset = "0x61E0680", VA = "0x1861E1280")]
	internal HCJIDIJDGCA GIBKIKCLJFM(int MFKKELONDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61E1020", Offset = "0x61E0420", VA = "0x1861E1020")]
	internal void FJNLHOBGLJJ(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61E5280", Offset = "0x61E4680", VA = "0x1861E5280")]
	static GPEKHAJOCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xF08D50", Offset = "0xF08150", VA = "0x180F08D50")]
	private bool CPCHKPINGGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61E02E0", Offset = "0x61DF6E0", VA = "0x1861E02E0")]
	private void EFMAJFACBII(IPEndPoint LGAKEIKKKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61DFCF0", Offset = "0x61DF0F0", VA = "0x1861DFCF0")]
	private void CIPKELMFKFH(IPEndPoint LGAKEIKKKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61E1A00", Offset = "0x61E0E00", VA = "0x1861E1A00")]
	private bool INHGLNOKMMD(SocketException JFJOELAOBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61DFE70", Offset = "0x61DF270", VA = "0x1861DFE70")]
	private void CPIIDLAIEPB(IJGFPNPJPAB LPGLDDBIADG, EndPoint EOPDDHNBLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61E14C0", Offset = "0x61E08C0", VA = "0x1861E14C0")]
	private void HNPANGEFMPE(object NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61E1EE0", Offset = "0x61E12E0", VA = "0x1861E1EE0")]
	public bool IOGIABOPHFE(IPAddress HCHJFFFCFDA, IPAddress GAJIHHCKBNO, int MPICFOLCBBC, bool ANLCGLBPBPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61E3270", Offset = "0x61E2670", VA = "0x1861E3270")]
	internal int MHKIBIJOBBK(HCJIDIJDGCA PFIAKLEHODL, IPEndPoint ICICJDJLDPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61E39F0", Offset = "0x61E2DF0", VA = "0x1861E39F0")]
	internal int NOHDMGPPNNN(HCJIDIJDGCA PFIAKLEHODL, IPEndPoint ICICJDJLDPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61E33E0", Offset = "0x61E27E0", VA = "0x1861E33E0")]
	internal int NOHDMGPPNNN(byte[] ADPAIBGIHMB, int AKMLIMIBFHO, int IDHDBIDGMFM, IPEndPoint ICICJDJLDPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61E4C80", Offset = "0x61E4080", VA = "0x1861E4C80")]
	internal void OOPNHPDINHC(bool OEMOGOAOCGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NNGKKJNFEFI : byte
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
internal sealed class HCJIDIJDGCA
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int CPEHNCDOOMB;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DOACOKGHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] EHODDAPIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int NDEEOPEAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object BBDLEEKFEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HCJIDIJDGCA HFOIJEAEKAE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NNGKKJNFEFI GCIPKKIOABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x61E5EB0", Offset = "0x61E52B0", VA = "0x1861E5EB0")]
		get
		{
			return default(NNGKKJNFEFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61E5EE0", Offset = "0x61E52E0", VA = "0x1861E5EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte OCKIJAENONN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x61E59D0", Offset = "0x61E4DD0", VA = "0x1861E59D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61E5D90", Offset = "0x61E5190", VA = "0x1861E5D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort PICMAIOLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61E5E10", Offset = "0x61E5210", VA = "0x1861E5E10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61E5DD0", Offset = "0x61E51D0", VA = "0x1861E5DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LDKAMLCPJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61E5CD0", Offset = "0x61E50D0", VA = "0x1861E5CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HGMCJAIKBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61E5CA0", Offset = "0x61E50A0", VA = "0x1861E5CA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61E5F80", Offset = "0x61E5380", VA = "0x1861E5F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JEHMFBOGGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61E5F20", Offset = "0x61E5320", VA = "0x1861E5F20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61E5C60", Offset = "0x61E5060", VA = "0x1861E5C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort FLMOHAPCPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61E5D30", Offset = "0x61E5130", VA = "0x1861E5D30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61E5990", Offset = "0x61E4D90", VA = "0x1861E5990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort BHIGGAEMPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x61E5C00", Offset = "0x61E5000", VA = "0x1861E5C00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x61E5E70", Offset = "0x61E5270", VA = "0x1861E5E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61E5FB0", Offset = "0x61E53B0", VA = "0x1861E5FB0")]
	static HCJIDIJDGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61E5D00", Offset = "0x61E5100", VA = "0x1861E5D00")]
	public void FDNMFPIBDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61E6380", Offset = "0x61E5780", VA = "0x1861E6380")]
	public HCJIDIJDGCA(int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61E6270", Offset = "0x61E5670", VA = "0x1861E6270")]
	public HCJIDIJDGCA(NNGKKJNFEFI NHOIMDHCPOO, int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61E5B90", Offset = "0x61E4F90", VA = "0x1861E5B90")]
	public static int CFOPPJPMPEK(NNGKKJNFEFI NHOIMDHCPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61E5B00", Offset = "0x61E4F00", VA = "0x1861E5B00")]
	public int CFOPPJPMPEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61E5A00", Offset = "0x61E4E00", VA = "0x1861E5A00")]
	public bool BFLOEIDFIEN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum CPDOMHLHBNO : byte
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
internal enum DOLBEBLCJJD
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
internal enum GLPFCHDCNDA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum DCFKNHGPLEP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CLBGLLCCHCN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class FICKMOOJFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HCJIDIJDGCA[] MFHJJODDKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int AKIMNIHJKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int NHCAMDKBIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HGMCJAIKBBE;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FICKMOOJFOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void DKAPOOLKMBP(ulong IFHBMAEMBLM, int ALEMJLOADKM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int DPCJPFKLOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int NMCPHICDCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int JCCEIJPAPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FPNENDKIKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int MILHEBEJAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GGFCDJEEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int HKNPCFDFACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch JLHGPLOLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int OIBDDMBMAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long NCNOHBPNONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object OAPGEFDBBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal CLBGLLCCHCN BGAENJBFAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal CLBGLLCCHCN FADAPEMFKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HCJIDIJDGCA> HHANPMPIIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<PLGAOIHCPPI> AHEMEJHIFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly PLGAOIHCPPI[] CEANDDAALIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int MDGKPNEIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int ICAIDPGKAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool KHMHNKMKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int DAJMOLKNFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int GEPAMNOHLJN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int JCHMMAEMJFM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MNJAEBPKJPE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DGOJIHKFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int NDJMJEIPADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, FICKMOOJFOL> IHDODDMCCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BNAGJGPIKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HCJIDIJDGCA OINANGAOBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int DLDAJEPHAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int CLOEHBLKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint BKEMNANBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int LAEGFAJPKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NJKLDGBJJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long JJCFPKPMMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte OHGKGDAMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private CPDOMHLHBNO NDBAGKPJFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HCJIDIJDGCA BKEEHDHEBCF;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int DBEMJICKBNM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JCGDJKKDAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HCJIDIJDGCA BFMHOLHBHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HCJIDIJDGCA FAPIEMJFMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HCJIDIJDGCA MLHGHDLEKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HCJIDIJDGCA HCEHAIGBFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private OLBHIJDEILC FBCGFJFLCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GPEKHAJOCAG LAPLBECCAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int BMLMCKPLKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object DMLPNLILDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly ODKGPICFMFI AALGDOOGMPD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte JBCLAHMHDME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBB91C0", Offset = "0xBB85C0", VA = "0x180BB91C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61DA070", Offset = "0x61D9470", VA = "0x1861DA070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DCBPGABJLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x908230", Offset = "0x907630", VA = "0x180908230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CPDOMHLHBNO BHHGCAOFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x164E710", Offset = "0x164DB10", VA = "0x18164E710")]
		get
		{
			return default(CPDOMHLHBNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long IGFEBJPGBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4BA0", Offset = "0x8B3FA0", VA = "0x1808B4BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PMHOAHNDEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xFDA660", Offset = "0xFD9A60", VA = "0x180FDA660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x18E54E0", Offset = "0x18E48E0", VA = "0x1818E54E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LPBHHIKIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x61DC4A0", Offset = "0x61DB8A0", VA = "0x1861DC4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KOKBPGPNKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1F0", Offset = "0x8B95F0", VA = "0x1808BA1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double AOFPBMBBKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1F66850", Offset = "0x1F65C50", VA = "0x181F66850")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DKAPOOLKMBP HALAIOKILIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61DC4B0", Offset = "0x61DB8B0", VA = "0x1861DC4B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61DC300", Offset = "0x61DB700", VA = "0x1861DC300")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61DD520", Offset = "0x61DC920", VA = "0x1861DD520")]
	internal CLBGLLCCHCN(GPEKHAJOCAG APBFFMHALHH, IPEndPoint ICICJDJLDPH, int IHELCOHOCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x61D9F00", Offset = "0x61D9300", VA = "0x1861D9F00")]
	internal void AHDLKHFECIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61DBD80", Offset = "0x61DB180", VA = "0x1861DBD80")]
	internal void ICKDFPGKMGJ(IPEndPoint EJJEICEDINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61DD450", Offset = "0x61DC850", VA = "0x1861DD450")]
	internal void PPGMKKHBKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61DB750", Offset = "0x61DAB50", VA = "0x1861DB750")]
	private void HMDPJCGMDDB(int LENOBLOCPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61DC3B0", Offset = "0x61DB7B0", VA = "0x1861DC3B0")]
	private void LNJJFHALGPB(int DHGAOCIIGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61DB240", Offset = "0x61DA640", VA = "0x1861DB240")]
	private PLGAOIHCPPI FAFCMFNAPIK(byte HOEIKPCADHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x61DDB50", Offset = "0x61DCF50", VA = "0x1861DDB50")]
	internal CLBGLLCCHCN(GPEKHAJOCAG APBFFMHALHH, IPEndPoint ICICJDJLDPH, int IHELCOHOCAM, byte CKPKPJJGDAO, JGEOPGHBBHN ADPPDGLGFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x61DD970", Offset = "0x61DCD70", VA = "0x1861DD970")]
	internal CLBGLLCCHCN(GPEKHAJOCAG APBFFMHALHH, EHJJADIAJIE JHKMPCADNAF, int IHELCOHOCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x61DB700", Offset = "0x61DAB00", VA = "0x1861DB700")]
	internal void HGOAHDKACPH(FJHAEOHGDLL IJCIJNDDAON, byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x61DB0E0", Offset = "0x61DA4E0", VA = "0x1861DB0E0")]
	internal bool COOOGKKBPPC(NFPHNPANFBL PFIAKLEHODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x61DBE10", Offset = "0x61DB210", VA = "0x1861DBE10")]
	public void JKAHPJDAKCE(byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int IDHDBIDGMFM, IPCMFENNKEO AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61D99A0", Offset = "0x61D8DA0", VA = "0x1861D99A0")]
	private void AFCDPNAHFJN(byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int IDHDBIDGMFM, byte PNCAPLLLKGJ, IPCMFENNKEO NLAOGKFEKDN, object JIDEBNFKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x61DC3F0", Offset = "0x61DB7F0", VA = "0x1861DC3F0")]
	public void MFIKIKAPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x61DB160", Offset = "0x61DA560", VA = "0x1861DB160")]
	internal GLPFCHDCNDA DCLDFGCFCDM(HCJIDIJDGCA PFIAKLEHODL)
	{
		return default(GLPFCHDCNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDB0", Offset = "0x61DB1B0", VA = "0x1861DBDB0")]
	internal void IIKGPLPLNJO(PLGAOIHCPPI DKMFNPFKINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x61DB3F0", Offset = "0x61DA7F0", VA = "0x1861DB3F0")]
	internal DCFKNHGPLEP FDDEHOFINGA(byte[] MPMEGOKIEPF, int AKMLIMIBFHO, int IDHDBIDGMFM, bool DPEDJCGKFCE)
	{
		return default(DCFKNHGPLEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x61DD4E0", Offset = "0x61DC8E0", VA = "0x1861DD4E0")]
	private void PPPKKPGKIDO(int CNBNFHEJEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x61DC8F0", Offset = "0x61DBCF0", VA = "0x1861DC8F0")]
	internal void OHIPLOHNHOI(IPCMFENNKEO INACCIEGKKO, HCJIDIJDGCA EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61DB820", Offset = "0x61DAC20", VA = "0x1861DB820")]
	private void ICBFOEOAABI(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61DC560", Offset = "0x61DB960", VA = "0x1861DC560")]
	private void OBPHDKKAKOJ(int GJPMFKBAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61DD290", Offset = "0x61DC690", VA = "0x1861DD290")]
	internal DOLBEBLCJJD OMEEGDOLGCI(FJHAEOHGDLL LPOJIPHAKMJ)
	{
		return default(DOLBEBLCJJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61DAA20", Offset = "0x61D9E20", VA = "0x1861DAA20")]
	internal void CEHDJJDDLJH(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61D9F20", Offset = "0x61D9320", VA = "0x1861D9F20")]
	private void AOCNIEOKOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61DBE40", Offset = "0x61DB240", VA = "0x1861DBE40")]
	internal void JPHCDLHHAEL(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61DA120", Offset = "0x61D9520", VA = "0x1861DA120")]
	internal void BNOGHBKOPKE(int GJPMFKBAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61DC040", Offset = "0x61DB440", VA = "0x1861DC040")]
	internal void LHIAGEHJDFI(HCJIDIJDGCA PFIAKLEHODL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class ODKGPICFMFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long MEFNALPOLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GBLKPNHCCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long IFEBGODEJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HAALGFKFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long KAPFGHHOPGN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long AJDHCBFPLMM;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long JADBECJMELG;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long CEOMGIHCFCP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long FPOKJKMNBJL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long BDHLMDBIPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long KMEEKAINGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long EGCEGAPCOMM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long KNKPMAAHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61ED340", Offset = "0x61EC740", VA = "0x1861ED340")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DCHOKONADLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61ED330", Offset = "0x61EC730", VA = "0x1861ED330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long HKEGKHBLNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61ED150", Offset = "0x61EC550", VA = "0x1861ED150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long OALFDLAMGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61ED0F0", Offset = "0x61EC4F0", VA = "0x1861ED0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long KHCCFGAPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61ED3B0", Offset = "0x61EC7B0", VA = "0x1861ED3B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long ACKGCJJABHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61ED0A0", Offset = "0x61EC4A0", VA = "0x1861ED0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long PNPCCIOMOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61ED110", Offset = "0x61EC510", VA = "0x1861ED110")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long MDFJIPHKLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61ED0B0", Offset = "0x61EC4B0", VA = "0x1861ED0B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private OLBHIJDEILC NNDMLOFICEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61ED100", Offset = "0x61EC500", VA = "0x1861ED100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double IAAEHGNKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61ED160", Offset = "0x61EC560", VA = "0x1861ED160")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x61ECFC0", Offset = "0x61EC3C0", VA = "0x1861ECFC0")]
	public void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x61ED1C0", Offset = "0x61EC5C0", VA = "0x1861ED1C0")]
	public void JKDDGPDAEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x61ED220", Offset = "0x61EC620", VA = "0x1861ED220")]
	public void JNMDBGFHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x61ED2D0", Offset = "0x61EC6D0", VA = "0x1861ED2D0")]
	public void KFEGNBCOFHN(long AOOHKNJKDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61ED270", Offset = "0x61EC670", VA = "0x1861ED270")]
	public void JPEOLMAOOEK(long ABNAKOACHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61ED350", Offset = "0x61EC750", VA = "0x1861ED350")]
	public void MCDDLJCMMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x61ED3C0", Offset = "0x61EC7C0", VA = "0x1861ED3C0")]
	public void MOEOLDAFPBF(long FJHHMIMKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61ED430", Offset = "0x61EC830", VA = "0x1861ED430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61ED000", Offset = "0x61EC400", VA = "0x1861ED000")]
	public void COJOANLPGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public ODKGPICFMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JHGJNFHDIMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> KNKHNCOIBGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x61E8030", Offset = "0x61E7430", VA = "0x1861E8030")]
	public static IPEndPoint EFHAAIKFMMD(string FLBGPBMFMBG, int MPICFOLCBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x61E8340", Offset = "0x61E7740", VA = "0x1861E8340")]
	public static IPAddress LLCGDMFDNOJ(string FLBGPBMFMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61E82B0", Offset = "0x61E76B0", VA = "0x1861E82B0")]
	public static IPAddress LLCGDMFDNOJ(string FLBGPBMFMBG, AddressFamily JFGCKHEJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61E8280", Offset = "0x61E7680", VA = "0x1861E8280")]
	internal static int KANCAPFHIKF(int KLBOIBJKOOA, int EKLNJAGLKCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE3A0", Offset = "0x2ECD7A0", VA = "0x182ECE3A0")]
	internal static T[] NHMAJOHNDPF<T>(int MGEMHICLKEP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KHGKJIEAHKN : PLGAOIHCPPI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct JEGGHMOBFOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private HCJIDIJDGCA EDHLJBGDHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long PEEMKLNHLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool BBMJAIOFJNO;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61E7150", Offset = "0x61E6550", VA = "0x1861E7150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61E7130", Offset = "0x61E6530", VA = "0x1861E7130")]
		public void LHMGAKDCLGK(HCJIDIJDGCA PFIAKLEHODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61E70C0", Offset = "0x61E64C0", VA = "0x1861E70C0")]
		public bool JKONBGGBAJP(long EJNPHOJBHAC, CLBGLLCCHCN FBEECAAIAJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x61E7070", Offset = "0x61E6470", VA = "0x1861E7070")]
		public bool FLFDAJFNFLK(CLBGLLCCHCN FBEECAAIAJE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly HCJIDIJDGCA LJICMPKLMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly JEGGHMOBFOC[] HMNGIGIHEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly HCJIDIJDGCA[] CKJEOMNIMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] BMCDAGFCANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int HEENEKNDELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int DDABHDKFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int LBIADINCJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int ECKOJBHBCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool MLGLODPPKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly IPCMFENNKEO PKBHKAEEMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool FJPJJIBEGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int DMDGGMOLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte HAMCBIJLNMD;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61E9490", Offset = "0x61E8890", VA = "0x1861E9490")]
	public KHGKJIEAHKN(CLBGLLCCHCN FBEECAAIAJE, bool EOFDNNPDEGC, byte IHELCOHOCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61E85A0", Offset = "0x61E79A0", VA = "0x1861E85A0")]
	private void ADKBFCMHNPO(HCJIDIJDGCA PFIAKLEHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61E8FC0", Offset = "0x61E83C0", VA = "0x1861E8FC0", Slot = "4")]
	protected override bool FPKKFBEMKID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61E8960", Offset = "0x61E7D60", VA = "0x1861E8960", Slot = "5")]
	public override bool CEHDJJDDLJH(HCJIDIJDGCA PFIAKLEHODL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BLHCEEKNIFG : PLGAOIHCPPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int BBMICNGBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort DDABHDKFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool JGOECAADDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private HCJIDIJDGCA IPDNIOPCBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly HCJIDIJDGCA COONHGDHBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool NHJBOIOAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte HAMCBIJLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long GFNKAIENKCK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61D9560", Offset = "0x61D8960", VA = "0x1861D9560")]
	public BLHCEEKNIFG(CLBGLLCCHCN FBEECAAIAJE, bool KECFCBDILBJ, byte IHELCOHOCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61D90A0", Offset = "0x61D84A0", VA = "0x1861D90A0", Slot = "4")]
	protected override bool FPKKFBEMKID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61D8DC0", Offset = "0x61D81C0", VA = "0x1861D8DC0", Slot = "5")]
	public override bool CEHDJJDDLJH(HCJIDIJDGCA PFIAKLEHODL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MCOELJMANJL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct PIFJANKNJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong HIMOGIJPBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double BBIEPOIIOBH;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct PLFFJKFLMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int LGAODPPDFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float CEACEGHJHPA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61D7080", Offset = "0x61D6480", VA = "0x1861D7080")]
	private static void GNCIDHCPKJJ(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, ulong MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61EC1A0", Offset = "0x61EB5A0", VA = "0x1861EC1A0")]
	private static void GNCIDHCPKJJ(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, int MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61EC160", Offset = "0x61EB560", VA = "0x1861EC160")]
	public static void GNCIDHCPKJJ(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, short MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x61EC220", Offset = "0x61EB620", VA = "0x1861EC220")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, double LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61EC240", Offset = "0x61EB640", VA = "0x1861EC240")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61EC160", Offset = "0x61EB560", VA = "0x1861EC160")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, short LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61EC160", Offset = "0x61EB560", VA = "0x1861EC160")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, ushort LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61EC1A0", Offset = "0x61EB5A0", VA = "0x1861EC1A0")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61EC1A0", Offset = "0x61EB5A0", VA = "0x1861EC1A0")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, uint LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61EC210", Offset = "0x61EB610", VA = "0x1861EC210")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, long LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61EC210", Offset = "0x61EB610", VA = "0x1861EC210")]
	public static void PFEEAOBNAAM(byte[] HFHEELJJDFM, int IHLILPEDKCL, ulong LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ACGKEHIGCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] CJJBCBGBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int APAJPKDHIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int MICFHDIALGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int OFLFIJEKPLG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] EHODDAPIENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DEDGIFAMHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DFLEHNFJNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61D81B0", Offset = "0x61D75B0", VA = "0x1861D81B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CMFMHHILALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2132860", Offset = "0x2131C60", VA = "0x182132860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int MAMCAJIHMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61D8000", Offset = "0x61D7400", VA = "0x1861D8000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61D79B0", Offset = "0x61D6DB0", VA = "0x1861D79B0")]
	public void GEDPAJEEPKJ(byte[] PPIMIKDHEBO, int GMCJIJBLJPF, int LAGDBCHADOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public ACGKEHIGCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61D81C0", Offset = "0x61D75C0", VA = "0x1861D81C0")]
	public ACGKEHIGCJJ(byte[] PPIMIKDHEBO, int GMCJIJBLJPF, int LAGDBCHADOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61D76B0", Offset = "0x61D6AB0", VA = "0x1861D76B0")]
	public IPEndPoint DPOFDLKJPEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61D77C0", Offset = "0x61D6BC0", VA = "0x1861D77C0")]
	public byte EOKODDPELHP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x61D77C0", Offset = "0x61D6BC0", VA = "0x1861D77C0")]
	public sbyte GKGNCMHFKLK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3564160", Offset = "0x3563560", VA = "0x183564160")]
	public T[] CNOMKLPJAIN<T>(ushort MFKKELONDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61D8010", Offset = "0x61D7410", VA = "0x1861D8010")]
	public bool[] NBJCKAJMFNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x61D7780", Offset = "0x61D6B80", VA = "0x1861D7780")]
	public ushort[] EEABHCJPBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61D7B40", Offset = "0x61D6F40", VA = "0x1861D7B40")]
	public short[] IBLLEHLHBII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61D7950", Offset = "0x61D6D50", VA = "0x1861D7950")]
	public int[] FDGJNEGKDOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61D7EE0", Offset = "0x61D72E0", VA = "0x1861D7EE0")]
	public uint[] LEAFFCFNOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61D7BC0", Offset = "0x61D6FC0", VA = "0x1861D7BC0")]
	public float[] JKOMHGMMMGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61D75C0", Offset = "0x61D69C0", VA = "0x1861D75C0")]
	public double[] BLMLEMGGOID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61D7670", Offset = "0x61D6A70", VA = "0x1861D7670")]
	public long[] DOHOGJEDDGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61D8050", Offset = "0x61D7450", VA = "0x1861D8050")]
	public ulong[] NEKKINEPBFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61D7800", Offset = "0x61D6C00", VA = "0x1861D7800")]
	public string[] FCDMKNMIPEB(int HACPLEHNMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x61D8090", Offset = "0x61D7490", VA = "0x1861D8090")]
	public bool OBPNNFBILML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61D7F90", Offset = "0x61D7390", VA = "0x1861D7F90")]
	public char MCCHOIDLNMH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x61D7F90", Offset = "0x61D7390", VA = "0x1861D7F90")]
	public ushort PDDOPKBDCBN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61D8140", Offset = "0x61D7540", VA = "0x1861D8140")]
	public short PBJNPIOIBHA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61D7600", Offset = "0x61D6A00", VA = "0x1861D7600")]
	public long DEDJIALHHIC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61D7E70", Offset = "0x61D7270", VA = "0x1861D7E70")]
	public ulong KGNEJGJCBNJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x61D7A60", Offset = "0x61D6E60", VA = "0x1861D7A60")]
	public int HBJOBJGICIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61D7AD0", Offset = "0x61D6ED0", VA = "0x1861D7AD0")]
	public uint HJPJPHJKPKE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x61D7F20", Offset = "0x61D7320", VA = "0x1861D7F20")]
	public float LJEMFBBHFPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61D79F0", Offset = "0x61D6DF0", VA = "0x1861D79F0")]
	public double GNOHNOPFMAF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61D7C40", Offset = "0x61D7040", VA = "0x1861D7C40")]
	public string JPDNOHKAAFH(int ALOHHMGKCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61D80D0", Offset = "0x61D74D0", VA = "0x1861D80D0")]
	public ArraySegment<byte> OOGOGHBCKFB(int MGEMHICLKEP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61D7B80", Offset = "0x61D6F80", VA = "0x1861D7B80")]
	public sbyte[] IIDCFEGHAOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61D7C00", Offset = "0x61D7000", VA = "0x1861D7C00")]
	public byte[] JMHIIJDOMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61D7990", Offset = "0x61D6D90", VA = "0x1861D7990")]
	public void FLFDAJFNFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JGEOPGHBBHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] CJJBCBGBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int APAJPKDHIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int JGFPFLOLLAJ = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool DHPEACJJLBH;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding FOJBCBJCMCH;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int EHIKLNIIAED = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] CLPLMMEFIDE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] BAFNFCIODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x61E7FB0", Offset = "0x61E73B0", VA = "0x1861E7FB0")]
	public JGEOPGHBBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F10", Offset = "0x61E7310", VA = "0x1861E7F10")]
	public JGEOPGHBBHN(bool GINLAJNNEFM, int GEMDCLDIAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x61E71F0", Offset = "0x61E65F0", VA = "0x1861E71F0")]
	public static JGEOPGHBBHN EHPEKOBNMKH(string LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DF0", Offset = "0x61E71F0", VA = "0x1861E7DF0")]
	public void OFKLBBHNEHA(int CKFFDMFLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x21ABA00", Offset = "0x21AAE00", VA = "0x1821ABA00")]
	public void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x61E75C0", Offset = "0x61E69C0", VA = "0x1861E75C0")]
	public void GDCPFBGALOD(float LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7870", Offset = "0x61E6C70", VA = "0x1861E7870")]
	public void GDCPFBGALOD(double LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x61E7300", Offset = "0x61E6700", VA = "0x1861E7300")]
	public void GDCPFBGALOD(long LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x61E7300", Offset = "0x61E6700", VA = "0x1861E7300")]
	public void GDCPFBGALOD(ulong LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x61E7270", Offset = "0x61E6670", VA = "0x1861E7270")]
	public void GDCPFBGALOD(int LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x61E7270", Offset = "0x61E6670", VA = "0x1861E7270")]
	public void GDCPFBGALOD(uint LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x61E73C0", Offset = "0x61E67C0", VA = "0x1861E73C0")]
	public void GDCPFBGALOD(char LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61E73C0", Offset = "0x61E67C0", VA = "0x1861E73C0")]
	public void GDCPFBGALOD(ushort LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x61E73C0", Offset = "0x61E67C0", VA = "0x1861E73C0")]
	public void GDCPFBGALOD(short LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x61E7560", Offset = "0x61E6960", VA = "0x1861E7560")]
	public void GDCPFBGALOD(sbyte LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x61E7560", Offset = "0x61E6960", VA = "0x1861E7560")]
	public void GDCPFBGALOD(byte LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x61E7350", Offset = "0x61E6750", VA = "0x1861E7350")]
	public void GDCPFBGALOD(byte[] MPMEGOKIEPF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x61E78C0", Offset = "0x61E6CC0", VA = "0x1861E78C0")]
	public void MNIMFJAIJCB(sbyte[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x61E78C0", Offset = "0x61E6CC0", VA = "0x1861E78C0")]
	public void HKDDLMMOCEN(byte[] MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x61E7430", Offset = "0x61E6830", VA = "0x1861E7430")]
	public void GDCPFBGALOD(bool LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7C30", Offset = "0x61E7030", VA = "0x1861E7C30")]
	public void NPICMFNBECL(Array DJCEIGBFBPG, int DGLCOIBKPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x61E79A0", Offset = "0x61E6DA0", VA = "0x1861E79A0")]
	public void NPICMFNBECL(float[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B50", Offset = "0x61E6F50", VA = "0x1861E7B50")]
	public void NPICMFNBECL(double[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B50", Offset = "0x61E6F50", VA = "0x1861E7B50")]
	public void NPICMFNBECL(long[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B50", Offset = "0x61E6F50", VA = "0x1861E7B50")]
	public void NPICMFNBECL(ulong[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x61E79A0", Offset = "0x61E6DA0", VA = "0x1861E79A0")]
	public void NPICMFNBECL(int[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x61E79A0", Offset = "0x61E6DA0", VA = "0x1861E79A0")]
	public void NPICMFNBECL(uint[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x61E7D10", Offset = "0x61E7110", VA = "0x1861E7D10")]
	public void NPICMFNBECL(ushort[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61E7D10", Offset = "0x61E7110", VA = "0x1861E7D10")]
	public void NPICMFNBECL(short[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x61E78C0", Offset = "0x61E6CC0", VA = "0x1861E78C0")]
	public void NPICMFNBECL(bool[] LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x61E7A80", Offset = "0x61E6E80", VA = "0x1861E7A80")]
	public void NPICMFNBECL(string[] LIHHDPOHLDK, int ECKKIJIALLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x61E7490", Offset = "0x61E6890", VA = "0x1861E7490")]
	public void GDCPFBGALOD(IPEndPoint CFOFFHENLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61E7260", Offset = "0x61E6660", VA = "0x1861E7260")]
	public void GDCPFBGALOD(string LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7660", Offset = "0x61E6A60", VA = "0x1861E7660")]
	public void GDCPFBGALOD(string LIHHDPOHLDK, int ALOHHMGKCFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CJHIKDDGKML
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JKGIHMDLBPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong BMLMCKPLKGH;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4439CB0", Offset = "0x44390B0", VA = "0x184439CB0")]
		static JKGIHMDLBPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KDJMPIHMGMG(ACGKEHIGCJJ OJMAIJPBMNC, object JIDEBNFKLLL);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CICAKANAFOH<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CJHIKDDGKML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CICAKANAFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x531E150", Offset = "0x531D550", VA = "0x18531E150")]
		internal void GOJEHKLPGOM(ACGKEHIGCJJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LINKDINGFHO<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CJHIKDDGKML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LINKDINGFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4611CC0", Offset = "0x46110C0", VA = "0x184611CC0")]
		internal void GOJEHKLPGOM(ACGKEHIGCJJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly AKEEPGHAKBN DFNDHBHCJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, KDJMPIHMGMG> POJCEHLKAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly JGEOPGHBBHN DLAKFCDFCEF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61D9820", Offset = "0x61D8C20", VA = "0x1861D9820")]
	public CJHIKDDGKML(int HACPLEHNMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB040", Offset = "0x2BEA440", VA = "0x182BEB040", Slot = "4")]
	protected virtual ulong MNDNNEMFDAD<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61D9670", Offset = "0x61D8A70", VA = "0x1861D9670", Slot = "5")]
	protected virtual KDJMPIHMGMG FILNOCDPFJH(ACGKEHIGCJJ OJMAIJPBMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F0F0", Offset = "0x2C4E4F0", VA = "0x182C4F0F0", Slot = "6")]
	protected virtual void CNBOFCHDPNE<T>(JGEOPGHBBHN NPFBBELPJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x61D97A0", Offset = "0x61D8BA0", VA = "0x1861D97A0")]
	public void LOMFEFOLKBJ(ACGKEHIGCJJ OJMAIJPBMNC, object JIDEBNFKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F160", Offset = "0x2C4E560", VA = "0x182C4F160")]
	public void FAEJLNAGKKJ<T>(JGEOPGHBBHN NPFBBELPJIH, T PFIAKLEHODL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61D9620", Offset = "0x61D8A20", VA = "0x1861D9620")]
	public void BFCJBKNAHAJ(ACGKEHIGCJJ OJMAIJPBMNC, object JIDEBNFKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EF30", Offset = "0x2C4E330", VA = "0x182C4EF30")]
	public void ADAHFKNAOJM<T>(Action<T> KMAGICGKMOE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2C4ED70", Offset = "0x2C4E170", VA = "0x182C4ED70")]
	public void ADAHFKNAOJM<T, TUserData>(Action<T, TUserData> KMAGICGKMOE) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EPLLPHOJLIN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x61DDE40", Offset = "0x61DD240", VA = "0x1861DDE40")]
	public EPLLPHOJLIN(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IMJNEOLGLDO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7010", Offset = "0x61E6410", VA = "0x1861E7010")]
	public IMJNEOLGLDO(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class AKEEPGHAKBN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum IIOKGKEHGKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class IHMLJICIJKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IIOKGKEHGKE MKIIDBFDPBM;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x41E6DA0", Offset = "0x41E61A0", VA = "0x1841E6DA0", Slot = "4")]
		public virtual void LHMGAKDCLGK(MethodInfo BKDCHGIGIHH, MethodInfo ONKHHLOPLGH, IIOKGKEHGKE LGJDMOCCBDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HACPJCKHBCG(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MOJCPFDECPF(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		protected IHMLJICIJKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class AMOEKBNNGDL<TClass, TProperty> : IHMLJICIJKE<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> DHNKNDNONHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> POOLOAECHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> EBIIAKPBPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> AKHECLIKFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> EPCAGBJEFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> PNPDHILKJAD;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4037B10", Offset = "0x4036F10", VA = "0x184037B10", Slot = "7")]
		public override void NENPGDCHNBL(TClass OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4031AB0", Offset = "0x4030EB0", VA = "0x184031AB0", Slot = "8")]
		public override void HNINDIPOMBH(TClass OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4030CB0", Offset = "0x40300B0", VA = "0x184030CB0", Slot = "9")]
		public override void HACPJCKHBCG(TClass OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4037090", Offset = "0x4036490", VA = "0x184037090", Slot = "10")]
		public override void MOJCPFDECPF(TClass OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4036DC0", Offset = "0x40361C0", VA = "0x184036DC0")]
		protected TProperty[] LJJJOJJOHOD(TClass OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x40321B0", Offset = "0x40315B0", VA = "0x1840321B0")]
		protected TProperty[] JCCFPBGEDMB(TClass OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4034510", Offset = "0x4033910", VA = "0x184034510", Slot = "4")]
		public override void LHMGAKDCLGK(MethodInfo BKDCHGIGIHH, MethodInfo ONKHHLOPLGH, IIOKGKEHGKE LGJDMOCCBDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4038590", Offset = "0x4037990", VA = "0x184038590")]
		protected AMOEKBNNGDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ODJCHBLAEEO<TClass, TProperty> : AMOEKBNNGDL<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ANONNCLIIHK(ACGKEHIGCJJ CMEHKBHKHFB, [Out] TProperty LLKNDBOAAHA);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IHHMJJOFCJJ(JGEOPGHBBHN AFOFNIJDOHO, TProperty LLKNDBOAAHA);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B440", Offset = "0x4A5A840", VA = "0x184A5B440", Slot = "5")]
		public override void EDHOKJPEEDB(TClass OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B4E0", Offset = "0x4A5A8E0", VA = "0x184A5B4E0", Slot = "6")]
		public override void FAEJLNAGKKJ(TClass OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B780", Offset = "0x4A5AB80", VA = "0x184A5B780", Slot = "7")]
		public override void NENPGDCHNBL(TClass OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B6C0", Offset = "0x4A5AAC0", VA = "0x184A5B6C0", Slot = "8")]
		public override void HNINDIPOMBH(TClass OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B77180", Offset = "0x3B76580", VA = "0x183B77180")]
		protected ODJCHBLAEEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class HPFDKLGGKCJ<T> : AMOEKBNNGDL<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x40C07C0", Offset = "0x40BFBC0", VA = "0x1840C07C0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x40C0840", Offset = "0x40BFC40", VA = "0x1840C0840", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x40C0920", Offset = "0x40BFD20", VA = "0x1840C0920", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x40C08B0", Offset = "0x40BFCB0", VA = "0x1840C08B0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public HPFDKLGGKCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class NFKCMKDKKHO<T> : AMOEKBNNGDL<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x48A62C0", Offset = "0x48A56C0", VA = "0x1848A62C0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x40C0840", Offset = "0x40BFC40", VA = "0x1840C0840", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x48A6340", Offset = "0x48A5740", VA = "0x1848A6340", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x40C08B0", Offset = "0x40BFCB0", VA = "0x1840C08B0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public NFKCMKDKKHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class DBFAACPGFHG<T> : AMOEKBNNGDL<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5BF2820", Offset = "0x5BF1C20", VA = "0x185BF2820", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F86FE0", Offset = "0x3F863E0", VA = "0x183F86FE0", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5BF28A0", Offset = "0x5BF1CA0", VA = "0x185BF28A0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F87050", Offset = "0x3F86450", VA = "0x183F87050", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public DBFAACPGFHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class ADAPLEIAPGH<T> : AMOEKBNNGDL<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3F86F60", Offset = "0x3F86360", VA = "0x183F86F60", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F86FE0", Offset = "0x3F863E0", VA = "0x183F86FE0", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3F870C0", Offset = "0x3F864C0", VA = "0x183F870C0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3F87050", Offset = "0x3F86450", VA = "0x183F87050", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public ADAPLEIAPGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CONGHDMDNOK<T> : AMOEKBNNGDL<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x53E3170", Offset = "0x53E2570", VA = "0x1853E3170", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A680", Offset = "0x4A59A80", VA = "0x184A5A680", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x53E31F0", Offset = "0x53E25F0", VA = "0x1853E31F0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x481B5D0", Offset = "0x481A9D0", VA = "0x18481B5D0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public CONGHDMDNOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OBJJBHIPGAH<T> : AMOEKBNNGDL<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A600", Offset = "0x4A59A00", VA = "0x184A5A600", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A680", Offset = "0x4A59A80", VA = "0x184A5A680", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A6F0", Offset = "0x4A59AF0", VA = "0x184A5A6F0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x481B5D0", Offset = "0x481A9D0", VA = "0x18481B5D0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public OBJJBHIPGAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AINJEOMAMKL<T> : AMOEKBNNGDL<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x402C020", Offset = "0x402B420", VA = "0x18402C020", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x402C0A0", Offset = "0x402B4A0", VA = "0x18402C0A0", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x402C110", Offset = "0x402B510", VA = "0x18402C110", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F31FC0", Offset = "0x3F313C0", VA = "0x183F31FC0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public AINJEOMAMKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MEFHGNJOPLO<T> : AMOEKBNNGDL<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x402C020", Offset = "0x402B420", VA = "0x18402C020", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x402C0A0", Offset = "0x402B4A0", VA = "0x18402C0A0", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4816F20", Offset = "0x4816320", VA = "0x184816F20", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F31FC0", Offset = "0x3F313C0", VA = "0x183F31FC0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public MEFHGNJOPLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BDGJEMELKDL<T> : AMOEKBNNGDL<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x525FCF0", Offset = "0x525F0F0", VA = "0x18525FCF0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x525FD70", Offset = "0x525F170", VA = "0x18525FD70", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x525FDE0", Offset = "0x525F1E0", VA = "0x18525FDE0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x40C08B0", Offset = "0x40BFCB0", VA = "0x1840C08B0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public BDGJEMELKDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MGDLFLOFGPL<T> : AMOEKBNNGDL<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x481B4E0", Offset = "0x481A8E0", VA = "0x18481B4E0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x481B560", Offset = "0x481A960", VA = "0x18481B560", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x481B640", Offset = "0x481AA40", VA = "0x18481B640", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x481B5D0", Offset = "0x481A9D0", VA = "0x18481B5D0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public MGDLFLOFGPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FMLPNNHOKNK<T> : AMOEKBNNGDL<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F31ED0", Offset = "0x3F312D0", VA = "0x183F31ED0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F31F50", Offset = "0x3F31350", VA = "0x183F31F50", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F32030", Offset = "0x3F31430", VA = "0x183F32030", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F31FC0", Offset = "0x3F313C0", VA = "0x183F31FC0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F320B0", Offset = "0x3F314B0", VA = "0x183F320B0")]
		public FMLPNNHOKNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FCKJKLLHBLN<T> : ODJCHBLAEEO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB260", Offset = "0x3EEA660", VA = "0x183EEB260", Slot = "12")]
		protected override void IHHMJJOFCJJ(JGEOPGHBBHN AFOFNIJDOHO, char LLKNDBOAAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB230", Offset = "0x3EEA630", VA = "0x183EEB230", Slot = "11")]
		protected override void ANONNCLIIHK(ACGKEHIGCJJ CMEHKBHKHFB, [Out] char LLKNDBOAAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB290", Offset = "0x3EEA690", VA = "0x183EEB290")]
		public FCKJKLLHBLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class AICOJFHLIOM<T> : ODJCHBLAEEO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0E10", Offset = "0x3FC0210", VA = "0x183FC0E10", Slot = "12")]
		protected override void IHHMJJOFCJJ(JGEOPGHBBHN AFOFNIJDOHO, IPEndPoint LLKNDBOAAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0DD0", Offset = "0x3FC01D0", VA = "0x183FC0DD0", Slot = "11")]
		protected override void ANONNCLIIHK(ACGKEHIGCJJ CMEHKBHKHFB, [Out] IPEndPoint LLKNDBOAAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB290", Offset = "0x3EEA690", VA = "0x183EEB290")]
		public AICOJFHLIOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class HBLMHFLGOMN<T> : AMOEKBNNGDL<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int ABPDHFBCLLI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40773F0", Offset = "0x40767F0", VA = "0x1840773F0")]
		public HBLMHFLGOMN(int ALOHHMGKCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x40771F0", Offset = "0x40765F0", VA = "0x1840771F0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4077270", Offset = "0x4076670", VA = "0x184077270", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4077370", Offset = "0x4076770", VA = "0x184077370", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x40772F0", Offset = "0x40766F0", VA = "0x1840772F0", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FIECKAJNFCG<T> : IHMLJICIJKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo GCIPKKIOABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type LGJJDKEMFAC;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F28E30", Offset = "0x3F28230", VA = "0x183F28E30")]
		public FIECKAJNFCG(PropertyInfo NHOIMDHCPOO, Type JBPNGAMFNJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F28B40", Offset = "0x3F27F40", VA = "0x183F28B40", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F28C00", Offset = "0x3F28000", VA = "0x183F28C00", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F28DD0", Offset = "0x3F281D0", VA = "0x183F28DD0", Slot = "7")]
		public override void NENPGDCHNBL(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F28D10", Offset = "0x3F28110", VA = "0x183F28D10", Slot = "8")]
		public override void HNINDIPOMBH(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F28CB0", Offset = "0x3F280B0", VA = "0x183F28CB0", Slot = "9")]
		public override void HACPJCKHBCG(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F28D70", Offset = "0x3F28170", VA = "0x183F28D70", Slot = "10")]
		public override void MOJCPFDECPF(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MLNPMCMJCHL<T> : FIECKAJNFCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
		public MLNPMCMJCHL(PropertyInfo NHOIMDHCPOO, Type JBPNGAMFNJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4848DB0", Offset = "0x48481B0", VA = "0x184848DB0", Slot = "5")]
		public override void EDHOKJPEEDB(T OGHNNIIBHMB, ACGKEHIGCJJ CMEHKBHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4848E70", Offset = "0x4848270", VA = "0x184848E70", Slot = "6")]
		public override void FAEJLNAGKKJ(T OGHNNIIBHMB, JGEOPGHBBHN AFOFNIJDOHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class LCGOCLHEOHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static LCGOCLHEOHI<T> FKMJLLKHOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly IHMLJICIJKE<T>[] JDIENJELDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int LFHPLAJNGJL;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x45D3A30", Offset = "0x45D2E30", VA = "0x1845D3A30")]
		public LCGOCLHEOHI(List<IHMLJICIJKE<T>> KLLMIDOFBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x45D3980", Offset = "0x45D2D80", VA = "0x1845D3980")]
		public void FAEJLNAGKKJ(T PBAACPJGKNP, JGEOPGHBBHN NPFBBELPJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x45D38D0", Offset = "0x45D2CD0", VA = "0x1845D38D0")]
		public void EDHOKJPEEDB(T PBAACPJGKNP, ACGKEHIGCJJ OJMAIJPBMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NNMDLIIFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract IHMLJICIJKE<T> JEMJOLBMCNL<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JGEOPGHBBHN NMOMFEDAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int HLMKFGKNOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, NNMDLIIFAHK> FLHFCANNLON;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61D82C0", Offset = "0x61D76C0", VA = "0x1861D82C0")]
	public AKEEPGHAKBN(int HACPLEHNMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3571940", Offset = "0x3570D40", VA = "0x183571940")]
	private LCGOCLHEOHI<T> OLBHCLJPLCC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDEC0", Offset = "0x2BDD2C0", VA = "0x182BDDEC0")]
	public void PFLPBBOAAPI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3571810", Offset = "0x3570C10", VA = "0x183571810")]
	public bool GEBAPMNFHGF<T>(ACGKEHIGCJJ OJMAIJPBMNC, T ANHPPPBDANF) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x35718B0", Offset = "0x3570CB0", VA = "0x1835718B0")]
	public void KEEAKGCJIOB<T>(JGEOPGHBBHN NPFBBELPJIH, T PBAACPJGKNP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LPJJEIINLEI
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime KFKAAGPBGAP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] BEBEHBMFBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DBJKHOJMNCE MJGBODBDFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x61E9BE0", Offset = "0x61E8FE0", VA = "0x1861E9BE0")]
		get
		{
			return default(DBJKHOJMNCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BABFPBJOCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x61E9DE0", Offset = "0x61E91E0", VA = "0x1861E9DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61E9ED0", Offset = "0x61E92D0", VA = "0x1861E9ED0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IPNDAMFDHML DBCMAKMNNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x61E9AE0", Offset = "0x61E8EE0", VA = "0x1861E9AE0")]
		get
		{
			return default(IPNDAMFDHML);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61E9BA0", Offset = "0x61E8FA0", VA = "0x1861E9BA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JENPKAEDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61E9E10", Offset = "0x61E9210", VA = "0x1861E9E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PIBPILFNENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x61E99A0", Offset = "0x61E8DA0", VA = "0x1861E99A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HIPJOKCCALH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x61E98A0", Offset = "0x61E8CA0", VA = "0x1861E98A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? GKMBNEPHHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x61E9B10", Offset = "0x61E8F10", VA = "0x1861E9B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? FMDNKMJOHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x61EA0F0", Offset = "0x61E94F0", VA = "0x1861EA0F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x61E9C10", Offset = "0x61E9010", VA = "0x1861E9C10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? GCBEGKBBBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x95EA70", Offset = "0x95DE70", VA = "0x18095EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x61EA6A0", Offset = "0x61E9AA0", VA = "0x1861EA6A0")]
	public LPJJEIINLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x61EA9C0", Offset = "0x61E9DC0", VA = "0x1861EA9C0")]
	internal LPJJEIINLEI(byte[] HFHEELJJDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x61EA520", Offset = "0x61E9920", VA = "0x1861EA520")]
	public static LPJJEIINLEI PIKPMFKHIOJ(byte[] HFHEELJJDFM, DateTime CPAHGEIGJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x61EA320", Offset = "0x61E9720", VA = "0x1861EA320")]
	internal void PBJBCMBBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x61E9F10", Offset = "0x61E9310", VA = "0x1861E9F10")]
	private void NOONNELEDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x61EA120", Offset = "0x61E9520", VA = "0x1861EA120")]
	private DateTime? OJPOKNDCPNG(int GMCJIJBLJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x61E96D0", Offset = "0x61E8AD0", VA = "0x1861E96D0")]
	private void ACAGPNBLPJG(int GMCJIJBLJPF, DateTime? LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x61E98D0", Offset = "0x61E8CD0", VA = "0x1861E98D0")]
	private ulong BNHCONKHGBN(int GMCJIJBLJPF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x61E9A20", Offset = "0x61E8E20", VA = "0x1861E9A20")]
	private void EAKCCJANOJM(int GMCJIJBLJPF, ulong LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x61E9E40", Offset = "0x61E9240", VA = "0x1861E9E40")]
	private uint LNBBEKCKKOK(int GMCJIJBLJPF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x60ABE80", Offset = "0x60AB280", VA = "0x1860ABE80")]
	private static uint GODGELILMGG(uint CFANGCOBGCF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x61E9B40", Offset = "0x61E8F40", VA = "0x1861E9B40")]
	private static ulong GODGELILMGG(ulong CFANGCOBGCF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DBJKHOJMNCE
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
public enum IPNDAMFDHML
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class FEACDNGOBFO
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int FHPOOHDIFJK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int BBIGIJCIJGE = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int DFFPBGHMCFG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint ILMCIFFIBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int HOMFPIKHBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int OCLKDEJCMMA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ONNLEOEMKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x61DDE50", Offset = "0x61DD250", VA = "0x1861DDE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x61DDE60", Offset = "0x61DD260", VA = "0x1861DDE60")]
	public bool JKAHPJDAKCE(IJGFPNPJPAB LPGLDDBIADG, int LBFLJPCMBIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class IFKOMILEHDJ : IJGFPNPJPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket LPGLDDBIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly GPEKHAJOCAG APBFFMHALHH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short PAHPLNGFNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x61E6F40", Offset = "0x61E6340", VA = "0x1861E6F40", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int BKAFKHGKKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x61E67F0", Offset = "0x61E5BF0", VA = "0x1861E67F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint KFNKBFMKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x61E6E10", Offset = "0x61E6210", VA = "0x1861E6E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily MJKBKCLJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x45B68E0", Offset = "0x45B5CE0", VA = "0x1845B68E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x61E6F60", Offset = "0x61E6360", VA = "0x1861E6F60")]
	public IFKOMILEHDJ(AddressFamily JFGCKHEJACL, GPEKHAJOCAG APBFFMHALHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x61E6850", Offset = "0x61E5C50", VA = "0x1861E6850", Slot = "8")]
	public bool GBFAHFHMMOL(IPEndPoint CFOFFHENLHF, LJFPAIHAMFA PHIBHPBJLJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x61E6810", Offset = "0x61E5C10", VA = "0x1861E6810", Slot = "9")]
	public int EGFIALEOEOM(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, int MFKKELONDCC, IPEndPoint ICICJDJLDPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x61E6E50", Offset = "0x61E6250", VA = "0x1861E6E50", Slot = "10")]
	public int NDIMMFIEEHC(byte[] FIJBJOBOOEA, EndPoint JBLDJIJCDJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x61E6E30", Offset = "0x61E6230", VA = "0x1861E6E30", Slot = "11")]
	public void KEGCECCDLCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface IJGFPNPJPAB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short PAHPLNGFNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int BKAFKHGKKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint KFNKBFMKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily MJKBKCLJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GBFAHFHMMOL(IPEndPoint CFOFFHENLHF, LJFPAIHAMFA PHIBHPBJLJG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int EGFIALEOEOM(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, int MFKKELONDCC, IPEndPoint ICICJDJLDPH);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NDIMMFIEEHC(byte[] FIJBJOBOOEA, EndPoint ICICJDJLDPH);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KEGCECCDLCI();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct FNAFMNMJFOK : IEquatable<FNAFMNMJFOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long CCMFOGAOMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long DIBHMLMLLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long BHKCLKMEGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int KIBCPANHOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int EOJPDEBOPFJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x61DE510", Offset = "0x61DD910", VA = "0x1861DE510")]
	public FNAFMNMJFOK(byte[] IKLMBMAPKMB, int APEPANJLLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E80", Offset = "0x8D2280", VA = "0x1808D2E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x61DE420", Offset = "0x61DD820", VA = "0x1861DE420", Slot = "4")]
	public bool Equals(FNAFMNMJFOK OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x61DE460", Offset = "0x61DD860", VA = "0x1861DE460", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HLJMCELNNAB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] HELEAECGABD;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PKGMAAOBJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int BMMDGCHLHGD;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
	protected PKGMAAOBJIH(int FBLIFIBCGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JNJCPLFOBIJ(IPEndPoint CFOFFHENLHF, byte[] MPMEGOKIEPF, int GMCJIJBLJPF, int IDHDBIDGMFM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NFKAIDGFNHF(IPEndPoint CFOFFHENLHF, byte[] MPMEGOKIEPF, int GMCJIJBLJPF, int IDHDBIDGMFM);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PAMNDCBEHBO : PKGMAAOBJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] GMJINMLEEAC;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator NGPODIHGBEB;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x224DD80", Offset = "0x224D180", VA = "0x18224DD80")]
	public PAMNDCBEHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x61ED860", Offset = "0x61ECC60", VA = "0x1861ED860")]
	public void BMGIOBMFNOG(IPEndPoint CFOFFHENLHF, byte[] GMJINMLEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x61EDA10", Offset = "0x61ECE10", VA = "0x1861EDA10")]
	public void GDLEHPGJMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61EDAF0", Offset = "0x61ECEF0", VA = "0x1861EDAF0", Slot = "4")]
	public override void JNJCPLFOBIJ(IPEndPoint CFOFFHENLHF, byte[] MPMEGOKIEPF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x61EDFB0", Offset = "0x61ED3B0", VA = "0x1861EDFB0", Slot = "5")]
	public override void NFKAIDGFNHF(IPEndPoint CFOFFHENLHF, byte[] MPMEGOKIEPF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct NFDKNGGLCHN
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void NPABEBFEFJH([NoAlias] byte* MPGKNGDLLNA, [NoAlias] byte* GMJINMLEEAC, [NoAlias] byte* HNBJACLCFJI, int IDHDBIDGMFM);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class CLIFNPJHONK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x61EE9E0", Offset = "0x61EDDE0", VA = "0x1861EE9E0")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x61EE5C0", Offset = "0x61ED9C0", VA = "0x1861EE5C0")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x61EE710", Offset = "0x61EDB10", VA = "0x1861EE710")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x61EE7B0", Offset = "0x61EDBB0", VA = "0x1861EE7B0")]
		public unsafe static void JNFLGGLMFJH([NoAlias] byte* MPGKNGDLLNA, [NoAlias] byte* GMJINMLEEAC, [NoAlias] byte* HNBJACLCFJI, int IDHDBIDGMFM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint GMJINMLEEAC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint HNBJACLCFJI[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint HPIAGOBEPDJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint DIMPKHKLMGO[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint EPLCLEBBLCM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint COMAKDANAGL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint EMHPDMOPAEK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint ANCPEIHOFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint NPMHLKDFCGD[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x61EC2C0", Offset = "0x61EB6C0", VA = "0x1861EC2C0")]
	private void AEAEDDMNDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x61EC440", Offset = "0x61EB840", VA = "0x1861EC440")]
	private uint IJDDKAMGKKN(uint IDIHIILANOF, int CJBELDKJEIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x61D7170", Offset = "0x61D6570", VA = "0x1861D7170")]
	private void APIMKJNIFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x61D73B0", Offset = "0x61D67B0", VA = "0x1861D73B0")]
	private void GPJMEBFMKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x61D7320", Offset = "0x61D6720", VA = "0x1861D7320")]
	private void EIPIFKHJPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x61D7220", Offset = "0x61D6620", VA = "0x1861D7220")]
	private void BJIOAEHLMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x61EC9F0", Offset = "0x61EBDF0", VA = "0x1861EC9F0")]
	private void MMAEABNIAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x61EC5D0", Offset = "0x61EB9D0", VA = "0x1861EC5D0")]
	private unsafe void MBPFPOIBDJO(byte* MPGKNGDLLNA, uint* GMJINMLEEAC, uint* HNBJACLCFJI, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x61EC550", Offset = "0x61EB950", VA = "0x1861EC550")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JGIDBEAONAP([NoAlias] byte* MPGKNGDLLNA, [NoAlias] byte* GMJINMLEEAC, [NoAlias] byte* HNBJACLCFJI, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x61EC470", Offset = "0x61EB870", VA = "0x1861EC470")]
	public static void JGIDBEAONAP(Span<byte> MPGKNGDLLNA, Span<byte> GMJINMLEEAC, Span<byte> HNBJACLCFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x61EC340", Offset = "0x61EB740", VA = "0x1861EC340")]
	public static void BJGPPHADGIN(Span<byte> MPGKNGDLLNA, Span<byte> GMJINMLEEAC, Span<byte> HNBJACLCFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA50", Offset = "0x61EBE50", VA = "0x1861ECA50")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OCECJDCDHEC([NoAlias] byte* MPGKNGDLLNA, [NoAlias] byte* GMJINMLEEAC, [NoAlias] byte* HNBJACLCFJI, int IDHDBIDGMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x61EEC00", Offset = "0x61EE000", VA = "0x1861EEC00")]
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
