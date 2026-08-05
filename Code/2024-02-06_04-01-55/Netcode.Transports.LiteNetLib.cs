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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LKGHPNJLNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EFLPJCPHPKM
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
		private NetworkManager LFPINGLCPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, EFILJKLFDAA> LOKGIMPOOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OIIDFFJNJHI IMDKPJNIJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] KHBMLGBDHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EFLPJCPHPKM LGMGOFCCPML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong FDKIEMGJEFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OFGLNPDKIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x554B0B0", Offset = "0x554A4B0", VA = "0x18554B0B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x554A5B0", Offset = "0x55499B0", VA = "0x18554A5B0")]
		public void RecRoom_SetEncryptionInfo(ulong NKHNILAAAGK, byte[] GPGELODKPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x554A590", Offset = "0x5549990", VA = "0x18554A590")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x554A430", Offset = "0x5549830", VA = "0x18554A430")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x554AFB0", Offset = "0x554A3B0", VA = "0x18554AFB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x554A7B0", Offset = "0x5549BB0", VA = "0x18554A7B0", Slot = "6")]
		public override void Send(ulong NCCJGGHNBDP, ArraySegment<byte> ALPLHOOHPEL, NetworkDelivery FJEELCJOCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x554A550", Offset = "0x5549950", VA = "0x18554A550", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong NCCJGGHNBDP, [Out] ArraySegment<byte> KFANGHDLFAN, [Out] float FBBPFKJCAJK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x554AAA0", Offset = "0x5549EA0", VA = "0x18554AAA0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x554AED0", Offset = "0x554A2D0", VA = "0x18554AED0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5549A40", Offset = "0x5548E40", VA = "0x185549A40", Slot = "10")]
		public override void DisconnectRemoteClient(ulong NCCJGGHNBDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55498F0", Offset = "0x5548CF0", VA = "0x1855498F0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5549C10", Offset = "0x5549010", VA = "0x185549C10", Slot = "12")]
		public override ulong GetCurrentRtt(ulong NCCJGGHNBDP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x554AA30", Offset = "0x5549E30", VA = "0x18554AA30", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x554A0C0", Offset = "0x55494C0", VA = "0x18554A0C0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LFPINGLCPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x554A360", Offset = "0x5549760", VA = "0x18554A360")]
		private GNOINGNLHKL MEHCOOPJDFJ(NetworkDelivery FICJMFBEBIN)
		{
			return default(GNOINGNLHKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5549CB0", Offset = "0x55490B0", VA = "0x185549CB0", Slot = "15")]
		private void HFDNEDDCNCD(EFILJKLFDAA LMFHKPNLHDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5549F80", Offset = "0x5549380", VA = "0x185549F80", Slot = "16")]
		private void IDJJEPBJCHN(EFILJKLFDAA LMFHKPNLHDO, COCJKHMHEAI LIOPCFLFLLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "17")]
		private void OFJKCHBEAGP(IPEndPoint DFPNKCDGGIE, SocketError MFDGAIHBLIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5549D70", Offset = "0x5549170", VA = "0x185549D70", Slot = "18")]
		private void IAPBOEEAAOL(EFILJKLFDAA LMFHKPNLHDO, EIBIDIFJDJD EMDFNBPIKNJ, byte NIAPJOBEJNF, GNOINGNLHKL KICPMILEPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x554A280", Offset = "0x5549680", VA = "0x18554A280")]
		private void MDDMMHDKFGC(int HFPFBPPBALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "19")]
		private void HOCDKLEOIAK(IPEndPoint DECKPKPMGMK, EIBIDIFJDJD EMDFNBPIKNJ, CHKIBPEPNCK PPELKHEDPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "20")]
		private void GEAEIPODMGL(EFILJKLFDAA LMFHKPNLHDO, int CBAOIAMMEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5549BB0", Offset = "0x5548FB0", VA = "0x185549BB0", Slot = "21")]
		private void EAOIMFHLAKE(EOLDOOFCGIO DKBCOOIEPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x554A520", Offset = "0x5549920", VA = "0x18554A520")]
		private ulong PECDFDDPMIK(EFILJKLFDAA LMFHKPNLHDO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55498D0", Offset = "0x5548CD0", VA = "0x1855498D0")]
		private static int AOCLCAGFDBB(float MINLHDMFCJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x554AFD0", Offset = "0x554A3D0", VA = "0x18554AFD0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class IGHBMFILFCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly EFILJKLFDAA FPCGNGJDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<DLHMOLDGGJG> CLKHBMPAEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int AECHHEKIBFN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5545650", Offset = "0x5544A50", VA = "0x185545650")]
	protected IGHBMFILFCD(EFILJKLFDAA LMFHKPNLHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55455F0", Offset = "0x55449F0", VA = "0x1855455F0")]
	public void MCJGMCGHBOL(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5545530", Offset = "0x5544930", VA = "0x185545530")]
	protected void BPGCONOGDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55455B0", Offset = "0x55449B0", VA = "0x1855455B0")]
	public bool CLBBKIOGIAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool LBIIDJBEDMF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JCMDNLDLOKO(DLHMOLDGGJG LOKMAGFHFCE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum OGEJOOOLKHH
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
public class EOLDOOFCGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OIIDFFJNJHI OAMLNOHMPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int PEHHLICBLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EELIGIDBCGK MNMGAMPKHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint ODMJFFHDIGB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OGEJOOOLKHH LKGCCNDNPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C7730", Offset = "0x7C6B30", VA = "0x1807C7730")]
		[CompilerGenerated]
		get
		{
			return default(OGEJOOOLKHH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD60", Offset = "0x8BD160", VA = "0x1808BDD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5544E00", Offset = "0x5544200", VA = "0x185544E00")]
	internal void OHAHCFHBBII(EELIGIDBCGK BFJGBJGFBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5544D70", Offset = "0x5544170", VA = "0x185544D70")]
	private bool AOLKPEMENID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5544E60", Offset = "0x5544260", VA = "0x185544E60")]
	internal EOLDOOFCGIO(IPEndPoint DECKPKPMGMK, EELIGIDBCGK MIMLFFEANLL, OIIDFFJNJHI PBLAGMGHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5544DA0", Offset = "0x55441A0", VA = "0x185544DA0")]
	public EFILJKLFDAA GLPADJNPIOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CHKIBPEPNCK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MBJKFLHMILE
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
public struct COCJKHMHEAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public MBJKFLHMILE FLNKIGIELKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PIBIGBNFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EIBIDIFJDJD NABHCOGKNAE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKGHPNJLNMJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDHFJPDNIIE(EFILJKLFDAA LMFHKPNLHDO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAMICCDALIC(EFILJKLFDAA LMFHKPNLHDO, COCJKHMHEAI LIOPCFLFLLH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHPANCFJAKB(IPEndPoint DFPNKCDGGIE, SocketError MFDGAIHBLIG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIAMIMAEGNB(EFILJKLFDAA LMFHKPNLHDO, EIBIDIFJDJD EMDFNBPIKNJ, byte NIAPJOBEJNF, GNOINGNLHKL KICPMILEPFA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHPIPAEJCLG(IPEndPoint DECKPKPMGMK, EIBIDIFJDJD EMDFNBPIKNJ, CHKIBPEPNCK PPELKHEDPHE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBHIGAIAJJE(EFILJKLFDAA LMFHKPNLHDO, int CBAOIAMMEKA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GKCCKAGDOKO(EOLDOOFCGIO DKBCOOIEPBC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DECAFHFIMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGOBDEDDHOK(EFILJKLFDAA LMFHKPNLHDO, object PFLIDENGDDC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PBJCCFLMMIK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIDHCBCDDDK(JJFEPOOHDFK LOKMAGFHFCE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHDEOLFKICC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMGHPHNKCAD(EFILJKLFDAA LMFHKPNLHDO, IPEndPoint KJGJHHKNMPM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EELIGIDBCGK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int HJMMODLNAKO = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long PPOEBABJGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte PDHJIGPACGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] PGODHHLNFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NNAJOBMIIPB NCANEPOJAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int NNHJJAFBMLG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5540B40", Offset = "0x553FF40", VA = "0x185540B40")]
	private EELIGIDBCGK(long OIMBHOBANIG, byte NIFDHJLAKIM, int KKLABGAMOPP, byte[] OIMPOLLPNIK, NNAJOBMIIPB ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55406E0", Offset = "0x553FAE0", VA = "0x1855406E0")]
	public static int BEBPMCLEOCM(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5540920", Offset = "0x553FD20", VA = "0x185540920")]
	public static EELIGIDBCGK GPKEGDLFPLB(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5540740", Offset = "0x553FB40", VA = "0x185540740")]
	public static DLHMOLDGGJG DLJHMOCLPIJ(LLPEMFBHHCA ICAFNELOFHL, SocketAddress AKNKJEMGMLM, long DJMEFHHCCGJ, int KKLABGAMOPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class DLHCDLLGMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long PPOEBABJGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte PDHJIGPACGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int NNHJJAFBMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool LCHIFCEMOBK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x553F070", Offset = "0x553E470", VA = "0x18553F070")]
	private DLHCDLLGMKO(long OIMBHOBANIG, byte NIFDHJLAKIM, int LIHBEFIMLGF, bool IAGIMIGLJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x553EE20", Offset = "0x553E220", VA = "0x18553EE20")]
	public static DLHCDLLGMKO GPKEGDLFPLB(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x553ED30", Offset = "0x553E130", VA = "0x18553ED30")]
	public static DLHMOLDGGJG DLJHMOCLPIJ(long DJMEFHHCCGJ, byte HBOLLKIHACA, int DDPHOAMHGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x553EF70", Offset = "0x553E370", VA = "0x18553EF70")]
	public static DLHMOLDGGJG JAJCDLFLMAI(EFILJKLFDAA LMFHKPNLHDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FIAJIOGKICG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KIBFBAIPBPE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MADIDLIAGKD(IPEndPoint BIMOHPAJKGE, IPEndPoint DECKPKPMGMK, string BDHKJODLPCL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJOENOCABGP(IPEndPoint DCEEOLENKPE, FIAJIOGKICG FICJMFBEBIN, string BDHKJODLPCL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MEGCIKEBNIH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JAAIFHGFKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint DDMJHJDLCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint ODMJFFHDIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string LFJGOEKGNKO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DFOGEFBBAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint APGGAJEPAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FIAJIOGKICG KEFOPLEGHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LFJGOEKGNKO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class FHCILDOELND
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint DBEIKCIHMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LFJGOEKGNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public FHCILDOELND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class MJPHEBFFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint DBEIKCIHMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint MCIHCLCLBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LFJGOEKGNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MJPHEBFFEKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class MNDJCILMGNO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LFJGOEKGNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IAGMKBDFINL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF80", Offset = "0x7AC380", VA = "0x1807ACF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MNDJCILMGNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OIIDFFJNJHI IPMPEJGFILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<JAAIFHGFKKF> GBNHLJMDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DFOGEFBBAGD> FAJLADENILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NNAJOBMIIPB ONOKGPGGABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LLPEMFBHHCA EHLLEAHIPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DNNMMCJBGOA BBHAMAAHAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KIBFBAIPBPE HNPFNPFMJFK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int GGKHNEOPMKG = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool MMBOJCONAIO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x554BC90", Offset = "0x554B090", VA = "0x18554BC90")]
	internal MEGCIKEBNIH(OIIDFFJNJHI EHNDAOOFIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x554B6A0", Offset = "0x554AAA0", VA = "0x18554B6A0")]
	internal void BFAPNHKPJBB(IPEndPoint LEEJOCBOBOH, DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x274A6D0", Offset = "0x2749AD0", VA = "0x18274A6D0")]
	private void HAPGKJMBFAP<T>(T LOKMAGFHFCE, IPEndPoint JILDGEDOLHB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x554B800", Offset = "0x554AC00", VA = "0x18554B800")]
	private void MADIDLIAGKD(FHCILDOELND LELOJHKELPH, IPEndPoint LEEJOCBOBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x554BB30", Offset = "0x554AF30", VA = "0x18554BB30")]
	private void PIIKDICMJHD(MJPHEBFFEKN LELOJHKELPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x554B990", Offset = "0x554AD90", VA = "0x18554B990")]
	private void OKGOCBKIOJM(MNDJCILMGNO LELOJHKELPH, IPEndPoint LEEJOCBOBOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GNOINGNLHKL : byte
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
public enum LBHBJDBFHAE : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CBOCHOODFMF
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] AIBBAHOCEGE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int ADDKBCMILML;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int FDJOCDDEMAG;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MMAEFPKKEGB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x553ED20", Offset = "0x553E120", VA = "0x18553ED20")]
	public MMAEFPKKEGB(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DDMAFOOJCBJ : MMAEFPKKEGB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x553ED20", Offset = "0x553E120", VA = "0x18553ED20")]
	public DDMAFOOJCBJ(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KHNKDBNLNJI
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
public interface IPIDHAINFCP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIMOLGENKIF(KHNKDBNLNJI KJBFCIIMCED, string HJAICMGMEBP, params object[] EALPNGKPAMO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class ICKBCHLAEDA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static IPIDHAINFCP AFGHAMIKJIM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object AGHJHCNCDJP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5545190", Offset = "0x5544590", VA = "0x185545190")]
	private static void DOIKJJIHMAB(KHNKDBNLNJI LFEDKCKBIGO, string HJAICMGMEBP, params object[] EALPNGKPAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55453C0", Offset = "0x55447C0", VA = "0x1855453C0")]
	internal static void ILECLNNNJGA(string HJAICMGMEBP, params object[] EALPNGKPAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5545130", Offset = "0x5544530", VA = "0x185545130")]
	internal static void CCGCPJOEHIB(string HJAICMGMEBP, params object[] EALPNGKPAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5545420", Offset = "0x5544820", VA = "0x185545420")]
	internal static void INMFDOGDIHK(string HJAICMGMEBP, params object[] EALPNGKPAMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IJAFGBGLAMG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EIBIDIFJDJD : NNAJOBMIIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DLHMOLDGGJG DIKMEJPOFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OIIDFFJNJHI OBOCDDHILHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OJGPKLLOPFE AGKHBNFDGPO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5544D20", Offset = "0x5544120", VA = "0x185544D20")]
	internal EIBIDIFJDJD(OIIDFFJNJHI IALOIPDIIAG, OJGPKLLOPFE CMDGFCEDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5544CB0", Offset = "0x55440B0", VA = "0x185544CB0")]
	internal void OJNLDIOPNCE(DLHMOLDGGJG LOKMAGFHFCE, int KHIBILDKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5544C30", Offset = "0x5544030", VA = "0x185544C30")]
	internal void LECPPIPNDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5544C00", Offset = "0x5544000", VA = "0x185544C00")]
	public void GNGBHACNDBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OJGPKLLOPFE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum EDEFMPMPMFB
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
	public OJGPKLLOPFE NKLJCNFJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public EDEFMPMPMFB KEFOPLEGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public EFILJKLFDAA FPCGNGJDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint ODMJFFHDIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object DNLNIGOIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int BMENGDEEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError PINFGCEAPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public MBJKFLHMILE HKKMCOKAJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public EOLDOOFCGIO JNJANMNCCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GNOINGNLHKL ECFMCOJEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte ECKLGBCCGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly EIBIDIFJDJD LPHDBDCBHIA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5554960", Offset = "0x5553D60", VA = "0x185554960")]
	public OJGPKLLOPFE(OIIDFFJNJHI IALOIPDIIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OIIDFFJNJHI : IEnumerable<EFILJKLFDAA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class CNGEMIMHIDB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x553ECB0", Offset = "0x553E0B0", VA = "0x18553ECB0", Slot = "4")]
		public bool Equals(IPEndPoint NEEBEKKMNIB, IPEndPoint IGHOLFEOMDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5025B90", Offset = "0x5024F90", VA = "0x185025B90", Slot = "5")]
		public int GetHashCode(IPEndPoint BHPOPDOKECN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public CNGEMIMHIDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct GMFDDKLFHBK : IEnumerator<EFILJKLFDAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly EFILJKLFDAA DGOKBHOMMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private EFILJKLFDAA HADPKDMKBAN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EFILJKLFDAA PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xEB1200", Offset = "0xEB0600", VA = "0x180EB1200")]
		public GMFDDKLFHBK(EFILJKLFDAA IDHPCHNAJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5545030", Offset = "0x5544430", VA = "0x185545030", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5545080", Offset = "0x5544480", VA = "0x185545080", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread KLJLODPOLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool LIAIPIPENGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent ALEGDNFFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<OJGPKLLOPFE> HIKBLPGMLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<OJGPKLLOPFE> NOPEMNLNIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OJGPKLLOPFE KENNNEKPBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LKGHPNJLNMJ AOFINLGBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly DECAFHFIMPF ECCDGNNJFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PBJCCFLMMIK AFJNFNPDAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JHDEOLFKICC JAGALCHAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, EFILJKLFDAA> MGMDHKBIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, EOLDOOFCGIO> MNIBMLDPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, PAMPLABDKBC> ELANPIHKMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim GOCIIJDCFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EFILJKLFDAA BJBPMKMBJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JCLHJLOFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<EFILJKLFDAA> OEDIILPHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EFILJKLFDAA[] FMJHMEMKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HGILLFFKPPC DJGEBKEEGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int IEPLPCGGEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> ALLLJHNKHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte DNGKLADCBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object HIMPOBIPNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool BOKBNHPICBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool CGABPGNMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NCPGPJLPBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int PMAJFMMDGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FKBAFDOGEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ABCPEMFCPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool CJCKFCFJCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NICOHBOOPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int MPLGEDBMHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int PJPBPPHJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int CBPIEMDLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MMBOJCONAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool JHGMMBOFBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool NHAOBNIHIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HMIBEOJIDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JPOOMBLKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PDGGDADEMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool LCHAEGIPLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly MCIGJAFLPPN FPPIHJDLAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool OPOMBOAFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly MEGCIKEBNIH BJGABNKLMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool JCCKEFBPCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public IJAFGBGLAMG COGOKELIAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int LFAGIPGNBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool JGODCHEKMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool CNBMGHCAHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool NJCDLJLJHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FACJEEFDAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private DLHMOLDGGJG MIGBELOCCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int NFOJBGCKEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object BLDACNBGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DLHMOLDGGJG CGENFNNFJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int IAGJPDOKAEI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int GMGBILAENGE = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int LKLBKEGLEBM = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private EOJDLFOGLEC AOOFDMKDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private EOJDLFOGLEC FFPDFEDGFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread CKFKGANCMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NCGLNLODOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ACPNALBFKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NBLMFAGJFCJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] GFEHEDGNHKI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] BMGDBDIPFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<PDNMEJGFNAP, IPEndPoint> PDOJCEANIPO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress FKLCNCBCFJK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool APFGJEOLKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GBKJOFFJOKE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KIECNFPDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DA1D0", Offset = "0x9D95D0", VA = "0x1809DA1D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA67310", Offset = "0xA66710", VA = "0x180A67310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GILELFADICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1546770", Offset = "0x1545B70", VA = "0x181546770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1546340", Offset = "0x1545740", VA = "0x181546340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte HAFLIEKKNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x848310", Offset = "0x847710", VA = "0x180848310")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JNCDCMBJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5553250", Offset = "0x5552650", VA = "0x185553250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short JGGEEAPKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x554ED70", Offset = "0x554E170", VA = "0x18554ED70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5553CD0", Offset = "0x55530D0", VA = "0x185553CD0")]
	public void PBMJMMACAIF(IPEndPoint DFPNKCDGGIE, byte[] GPGELODKPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5551F20", Offset = "0x5551320", VA = "0x185551F20")]
	public void LHKFIKLGCKK(IPEndPoint DFPNKCDGGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55515E0", Offset = "0x55509E0", VA = "0x1855515E0")]
	private bool JCACDBJBKDJ(IPEndPoint DFPNKCDGGIE, [Out] EFILJKLFDAA LMFHKPNLHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x554F180", Offset = "0x554E580", VA = "0x18554F180")]
	private void GBDDEBCGMGK(EFILJKLFDAA LMFHKPNLHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5551670", Offset = "0x5550A70", VA = "0x185551670")]
	private void JOMFCEPFJJM(EFILJKLFDAA LMFHKPNLHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x554EB10", Offset = "0x554DF10", VA = "0x18554EB10")]
	private void EHEEFPMPELH(EFILJKLFDAA LMFHKPNLHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5554310", Offset = "0x5553710", VA = "0x185554310")]
	public OIIDFFJNJHI(LKGHPNJLNMJ PBLAGMGHAKO, [Optional] HGILLFFKPPC MGPFFNNNEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55514B0", Offset = "0x55508B0", VA = "0x1855514B0")]
	internal void IKIFBCJPOFA(EFILJKLFDAA AAGDOGIPHCD, int CBAOIAMMEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5553C80", Offset = "0x5553080", VA = "0x185553C80")]
	internal void OGCJJPJFGNN(EFILJKLFDAA AAGDOGIPHCD, object PFLIDENGDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5553590", Offset = "0x5552990", VA = "0x185553590")]
	internal void ODNKENFBIAO(EFILJKLFDAA LMFHKPNLHDO, MBJKFLHMILE DGPAFACOBJI, SocketError LHJIGGIMKPA, DLHMOLDGGJG AAHHIKMPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55520D0", Offset = "0x55514D0", VA = "0x1855520D0")]
	private void MBOGOIHPKEM(EFILJKLFDAA LMFHKPNLHDO, MBJKFLHMILE DGPAFACOBJI, SocketError LHJIGGIMKPA, bool BICEHKAFMDO, byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int CBPPKGAPPDD, DLHMOLDGGJG AAHHIKMPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5553D70", Offset = "0x5553170", VA = "0x185553D70")]
	private void PBOHAJNPJIK(OJGPKLLOPFE.EDEFMPMPMFB FICJMFBEBIN, [Optional] EFILJKLFDAA LMFHKPNLHDO, [Optional] IPEndPoint DECKPKPMGMK, SocketError GFNHFJLLFBF = SocketError.Success, int CBAOIAMMEKA = 0, MBJKFLHMILE KNIHAGCJMMJ = MBJKFLHMILE.ConnectionFailed, [Optional] EOLDOOFCGIO GHOKKFDBNGD, GNOINGNLHKL KICPMILEPFA = GNOINGNLHKL.Unreliable, byte NIAPJOBEJNF = 0, [Optional] DLHMOLDGGJG GMGGCLBLMGB, [Optional] object PFLIDENGDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x554E350", Offset = "0x554D750", VA = "0x18554E350")]
	private void CIGBJHNBLHC(OJGPKLLOPFE CMDGFCEDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x554DCF0", Offset = "0x554D0F0", VA = "0x18554DCF0")]
	internal void BOBIEBLAJNP(OJGPKLLOPFE CMDGFCEDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x554DDF0", Offset = "0x554D1F0", VA = "0x18554DDF0")]
	private void CCDBCFEFENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5553270", Offset = "0x5552670", VA = "0x185553270")]
	private void OBBMIBCKLKK(int JNBPDJFJNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5553660", Offset = "0x5552A60", VA = "0x185553660")]
	internal EFILJKLFDAA OFOGLABIPGJ(EOLDOOFCGIO DKBCOOIEPBC, byte[] DCADMCMKECI, int PKHCCBJJMMB, int FLCGLAMBOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x554F100", Offset = "0x554E500", VA = "0x18554F100")]
	private int FJJLHPJBMIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5551AC0", Offset = "0x5550EC0", VA = "0x185551AC0")]
	private void KIADOOPIALM(IPEndPoint DECKPKPMGMK, EFILJKLFDAA LFLOHHOOAIB, EELIGIDBCGK IDLIBBABJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5550760", Offset = "0x554FB60", VA = "0x185550760")]
	private void HIDBPGCEAGC(DLHMOLDGGJG LOKMAGFHFCE, IPEndPoint DECKPKPMGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5552320", Offset = "0x5551720", VA = "0x185552320")]
	internal void MBPHCODNPAP(DLHMOLDGGJG LOKMAGFHFCE, GNOINGNLHKL HPALAAEPFDI, byte NIAPJOBEJNF, int KHIBILDKOCH, EFILJKLFDAA AAGDOGIPHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5552E40", Offset = "0x5552240", VA = "0x185552E40")]
	public bool MDMCIMIHPCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5552660", Offset = "0x5551A60", VA = "0x185552660")]
	public bool MDMCIMIHPCE(IPAddress PGKBGIFDNNE, IPAddress NAIPIIFJJJP, int FAPNKFCFBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55525E0", Offset = "0x55519E0", VA = "0x1855525E0")]
	public bool MDMCIMIHPCE(int FAPNKFCFBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5552FC0", Offset = "0x55523C0", VA = "0x185552FC0")]
	public void MGKKFEMALHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x554FF20", Offset = "0x554F320", VA = "0x18554FF20")]
	public EFILJKLFDAA HHENAMEFFPB(string DNEGIHJCAJC, int FAPNKFCFBMJ, string GPGELODKPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x554FE40", Offset = "0x554F240", VA = "0x18554FE40")]
	public EFILJKLFDAA HHENAMEFFPB(string DNEGIHJCAJC, int FAPNKFCFBMJ, LLPEMFBHHCA AAIJDDICIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5550000", Offset = "0x554F400", VA = "0x185550000")]
	public EFILJKLFDAA HHENAMEFFPB(IPEndPoint JILDGEDOLHB, LLPEMFBHHCA AAIJDDICIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x554DCE0", Offset = "0x554D0E0", VA = "0x18554DCE0")]
	public void BHLMHDKNPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x554D990", Offset = "0x554CD90", VA = "0x18554D990")]
	public void BHLMHDKNPAM(bool PBALKGHOCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x554E130", Offset = "0x554D530", VA = "0x18554E130")]
	public void CHMLNPHLOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x554E230", Offset = "0x554D630", VA = "0x18554E230")]
	public void CHMLNPHLOEK(byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55521B0", Offset = "0x55515B0", VA = "0x1855521B0")]
	public void MBOGOIHPKEM(EFILJKLFDAA LMFHKPNLHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5552260", Offset = "0x5551660", VA = "0x185552260")]
	public void MBOGOIHPKEM(EFILJKLFDAA LMFHKPNLHDO, byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5554130", Offset = "0x5553530", VA = "0x185554130", Slot = "4")]
	private IEnumerator<EFILJKLFDAA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55541C0", Offset = "0x55535C0", VA = "0x1855541C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x554F750", Offset = "0x554EB50", VA = "0x18554F750")]
	private DLHMOLDGGJG GNHMPOKEFAH(NABBNDCLDHB PLNALAIILFK, int HFPFBPPBALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x554F670", Offset = "0x554EA70", VA = "0x18554F670")]
	private DLHMOLDGGJG GNHMPOKEFAH(NABBNDCLDHB PLNALAIILFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x554F440", Offset = "0x554E840", VA = "0x18554F440")]
	internal DLHMOLDGGJG GLCALHNLOGG(int HFPFBPPBALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55516C0", Offset = "0x5550AC0", VA = "0x1855516C0")]
	internal void KANBCNMPOBF(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5554250", Offset = "0x5553650", VA = "0x185554250")]
	static OIIDFFJNJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9DA1D0", Offset = "0x9D95D0", VA = "0x1809DA1D0")]
	private bool OOIEMCANFAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5553160", Offset = "0x5552560", VA = "0x185553160")]
	private void MODLDJPGLPJ(IPEndPoint JPJEPEDAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5551500", Offset = "0x5550900", VA = "0x185551500")]
	private void IOMFLDGNNCF(IPEndPoint JPJEPEDAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5551920", Offset = "0x5550D20", VA = "0x185551920")]
	private bool KEKNBEJBFHF(SocketException PPLJOKJMAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x554EE30", Offset = "0x554E230", VA = "0x18554EE30")]
	private void FEOBNPDNONF(EOJDLFOGLEC EHNDAOOFIBO, EndPoint OHPGADIBBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55503D0", Offset = "0x554F7D0", VA = "0x1855503D0")]
	private void HHPOEFKJGNP(object DMBLKCJLHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5552680", Offset = "0x5551A80", VA = "0x185552680")]
	public bool MDMCIMIHPCE(IPAddress PGKBGIFDNNE, IPAddress NAIPIIFJJJP, int FAPNKFCFBMJ, bool JJKHBGMIBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5552070", Offset = "0x5551470", VA = "0x185552070")]
	internal int LONFAFMGJHP(DLHMOLDGGJG LOKMAGFHFCE, IPEndPoint DECKPKPMGMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x554FE00", Offset = "0x554F200", VA = "0x18554FE00")]
	internal int HBLGDIGHELJ(DLHMOLDGGJG LOKMAGFHFCE, IPEndPoint DECKPKPMGMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x554F840", Offset = "0x554EC40", VA = "0x18554F840")]
	internal int HBLGDIGHELJ(byte[] CAIOIMEOMNJ, int PKHCCBJJMMB, int FLCGLAMBOBC, IPEndPoint DECKPKPMGMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5552E50", Offset = "0x5552250", VA = "0x185552E50")]
	internal void MENBGIEKOAB(bool EDEKCECELCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NABBNDCLDHB : byte
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
internal sealed class DLHMOLDGGJG
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int GECKBLHLLDM;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] AAOMJJGDPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] ACCHHAIHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int COAOMNLBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object DNLNIGOIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public DLHMOLDGGJG NKLJCNFJDFB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NABBNDCLDHB FDLPNNGHICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x553F6B0", Offset = "0x553EAB0", VA = "0x18553F6B0")]
		get
		{
			return default(NABBNDCLDHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x553F440", Offset = "0x553E840", VA = "0x18553F440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PDHJIGPACGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x553F410", Offset = "0x553E810", VA = "0x18553F410")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x553F670", Offset = "0x553EA70", VA = "0x18553F670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort EAGDDKLDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x553F2A0", Offset = "0x553E6A0", VA = "0x18553F2A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x553F330", Offset = "0x553E730", VA = "0x18553F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EBKFOEIHLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x553F300", Offset = "0x553E700", VA = "0x18553F300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte EMCMEOCIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x553F640", Offset = "0x553EA40", VA = "0x18553F640")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x553F480", Offset = "0x553E880", VA = "0x18553F480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CFADLKMPEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x553F4E0", Offset = "0x553E8E0", VA = "0x18553F4E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x553F370", Offset = "0x553E770", VA = "0x18553F370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort KFNGMKDKBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x553F3B0", Offset = "0x553E7B0", VA = "0x18553F3B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x553F0C0", Offset = "0x553E4C0", VA = "0x18553F0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort AMALDHOJOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x553F240", Offset = "0x553E640", VA = "0x18553F240")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x553F200", Offset = "0x553E600", VA = "0x18553F200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x553F6E0", Offset = "0x553EAE0", VA = "0x18553F6E0")]
	static DLHMOLDGGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x553F4B0", Offset = "0x553E8B0", VA = "0x18553F4B0")]
	public void JIIEBPGCDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x553F9C0", Offset = "0x553EDC0", VA = "0x18553F9C0")]
	public DLHMOLDGGJG(int HFPFBPPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x553FA30", Offset = "0x553EE30", VA = "0x18553FA30")]
	public DLHMOLDGGJG(NABBNDCLDHB PLNALAIILFK, int HFPFBPPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x553F540", Offset = "0x553E940", VA = "0x18553F540")]
	public static int KLLLGLFKEKG(NABBNDCLDHB PLNALAIILFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x553F5B0", Offset = "0x553E9B0", VA = "0x18553F5B0")]
	public int KLLLGLFKEKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x553F100", Offset = "0x553E500", VA = "0x18553F100")]
	public bool BMNAIKHHPKA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum HKBIGDIGNJK : byte
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
internal enum LCDPLGAOGEK
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
internal enum AODLOFMMEMN
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum PGKDLIHFBIL
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EFILJKLFDAA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MMOMGGJMPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DLHMOLDGGJG[] MFPADJMHMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int IIBLDJJGIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int FINKIJBOPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte EMCMEOCIMAD;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MMOMGGJMPBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void PJHFDALAAIM(ulong HAGPMHMPDHA, int FLDCJGPBAGH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int GNMPPCOFNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int LNLBMBGNBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DMOEOAPAALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double OEJFFKIAAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BIHEPBEBPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int DMGIKBMKMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int EOPDLKMLCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch AOFJKMEPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HGFHEDHEBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long MPFKPHOKABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object LOLIAFPJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal EFILJKLFDAA DPKGMMNNHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal EFILJKLFDAA BKEFLNJFJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<DLHMOLDGGJG> JLMPOLNEIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<IGHBMFILFCD> MPKGMLLLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly IGHBMFILFCD[] GCFJKPBDEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int FJCCOMFHLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int MEDEIGPDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool FPJHJHCDANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int BHEJONDEKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int BEBNEMLCFNB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int LJBIICCKFGL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int APCMNAFPJMC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object FCIOKONLAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int FEODMODKIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, MMOMGGJMPBG> GKHNDKHNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> DFAPHOJAFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DLHMOLDGGJG OKPFLAAJJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int CMHMMEJGHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int CDEJLKDDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint NGPHBIJNOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IHDNOPEHPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NKHKBDCHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long PDFCEHMNJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte AGBGPDGCBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private HKBIGDIGNJK BCLBEOJCPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private DLHMOLDGGJG EFJOKCMCCHD;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NDJFHPIKLGP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int OOPPPCBPBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DLHMOLDGGJG EODKLGOCFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DLHMOLDGGJG FNAJMDPNPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly DLHMOLDGGJG PFMEHGDHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly DLHMOLDGGJG AFEELPBAIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LBHBJDBFHAE JJHKBLLLHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly OIIDFFJNJHI BKLEPOOKAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int CFEBOJMAFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object NAGIMELENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly MCIGJAFLPPN FPPIHJDLAFJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte IPEEPBPELFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA02E00", Offset = "0xA02200", VA = "0x180A02E00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5542980", Offset = "0x5541D80", VA = "0x185542980")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DGLNJGBJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A60", Offset = "0x7F4E60", VA = "0x1807F5A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HKBIGDIGNJK IHJJMLJHIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1562B40", Offset = "0x1561F40", VA = "0x181562B40")]
		get
		{
			return default(HKBIGDIGNJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long MDFCADDLDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A7010", Offset = "0x7A6410", VA = "0x1807A7010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BIBDEKKEKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC5AC0", Offset = "0xAC4EC0", VA = "0x180AC5AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x13A1B90", Offset = "0x13A0F90", VA = "0x1813A1B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KKACCDACOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5540EF0", Offset = "0x55402F0", VA = "0x185540EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EOPBADJNMFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1C0", Offset = "0x7AE5C0", VA = "0x1807AF1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double KAMLFAJJCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x175E5E0", Offset = "0x175D9E0", VA = "0x18175E5E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PJHFDALAAIM PGNMPOOBONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5541250", Offset = "0x5540650", VA = "0x185541250")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5541E10", Offset = "0x5541210", VA = "0x185541E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55445C0", Offset = "0x55439C0", VA = "0x1855445C0")]
	internal EFILJKLFDAA(OIIDFFJNJHI EDONGGEGKCL, IPEndPoint DECKPKPMGMK, int FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5543400", Offset = "0x5542800", VA = "0x185543400")]
	internal void LFKMHBJPEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5541300", Offset = "0x5540700", VA = "0x185541300")]
	internal void GFABCAPPFNC(IPEndPoint DNCJMJBFMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5542240", Offset = "0x5541640", VA = "0x185542240")]
	internal void HOHBBNKPPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5540BF0", Offset = "0x553FFF0", VA = "0x185540BF0")]
	private void CAEJDDIHINA(int OONAKJKDECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5540BB0", Offset = "0x553FFB0", VA = "0x185540BB0")]
	private void APOILGJOBMB(int JNFPJPDEMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5540CC0", Offset = "0x55400C0", VA = "0x185540CC0")]
	private IGHBMFILFCD CKFGHAACBHD(byte NGKFFMDAGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5544430", Offset = "0x5543830", VA = "0x185544430")]
	internal EFILJKLFDAA(OIIDFFJNJHI EDONGGEGKCL, IPEndPoint DECKPKPMGMK, int FNOGEAGAPLC, byte HBOLLKIHACA, LLPEMFBHHCA ICAFNELOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5544A20", Offset = "0x5543E20", VA = "0x185544A20")]
	internal EFILJKLFDAA(OIIDFFJNJHI EDONGGEGKCL, EOLDOOFCGIO DKBCOOIEPBC, int FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5543420", Offset = "0x5542820", VA = "0x185543420")]
	internal void MIMNMACNFBM(EELIGIDBCGK OMACCLLIHOB, byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int FLCGLAMBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5540E70", Offset = "0x5540270", VA = "0x185540E70")]
	internal bool CMDHOLLKCLB(DLHCDLLGMKO LOKMAGFHFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5541CC0", Offset = "0x55410C0", VA = "0x185541CC0")]
	public void HAPGKJMBFAP(byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int FLCGLAMBOBC, GNOINGNLHKL GGBINCNBHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5542BF0", Offset = "0x5541FF0", VA = "0x185542BF0")]
	private void KKFHHNJDPHI(byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int FLCGLAMBOBC, byte NIAPJOBEJNF, GNOINGNLHKL KICPMILEPFA, object PFLIDENGDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5543E30", Offset = "0x5543230", VA = "0x185543E30")]
	public void OPPOANLNEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5540F60", Offset = "0x5540360", VA = "0x185540F60")]
	internal AODLOFMMEMN EHCGHPFLIOH(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return default(AODLOFMMEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5540F00", Offset = "0x5540300", VA = "0x185540F00")]
	internal void EDAEKNLJKLE(IGHBMFILFCD PJCIBFLDGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5543B20", Offset = "0x5542F20", VA = "0x185543B20")]
	internal PGKDLIHFBIL OIJANFMNNOO(byte[] ALPLHOOHPEL, int PKHCCBJJMMB, int FLCGLAMBOBC, bool BICEHKAFMDO)
	{
		return default(PGKDLIHFBIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5541210", Offset = "0x5540610", VA = "0x185541210")]
	private void FLEDHIBEPLJ(int BPAOJIDGKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5541330", Offset = "0x5540730", VA = "0x185541330")]
	internal void GHAKINEIEBC(GNOINGNLHKL HPALAAEPFDI, DLHMOLDGGJG IDHPCHNAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5543EE0", Offset = "0x55432E0", VA = "0x185543EE0")]
	private void PLJLJOIGBPD(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5541EC0", Offset = "0x55412C0", VA = "0x185541EC0")]
	private void HNALEJENDKJ(int FANKMGPLGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5542A30", Offset = "0x5541E30", VA = "0x185542A30")]
	internal LCDPLGAOGEK KIADOOPIALM(EELIGIDBCGK IDLIBBABJKK)
	{
		return default(LCDPLGAOGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55422D0", Offset = "0x55416D0", VA = "0x1855422D0")]
	internal void JCMDNLDLOKO(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5541CF0", Offset = "0x55410F0", VA = "0x185541CF0")]
	private void HCJBHEBKFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5541040", Offset = "0x5540440", VA = "0x185541040")]
	internal void FDIBFLNJDDM(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5543470", Offset = "0x5542870", VA = "0x185543470")]
	internal void NEPLKJNDANP(int FANKMGPLGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5543140", Offset = "0x5542540", VA = "0x185543140")]
	internal void LEEHFKAKHNG(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MCIGJAFLPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long EENCAGBLONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EOKNJHIGKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long COMJAMHNJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long KCCCMPJEOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long JIGAFGMFKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long OCIHOPNCKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long BMBEIHGGMGD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long ACDGOBNAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x554B260", Offset = "0x554A660", VA = "0x18554B260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GOFOCJEEHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x554B160", Offset = "0x554A560", VA = "0x18554B160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PNBOKBBJNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x554B1A0", Offset = "0x554A5A0", VA = "0x18554B1A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GDIFHODJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x554B150", Offset = "0x554A550", VA = "0x18554B150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HJKPFNFDIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x554B0E0", Offset = "0x554A4E0", VA = "0x18554B0E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long ADJHKHFKADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x554B350", Offset = "0x554A750", VA = "0x18554B350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private LBHBJDBFHAE FOFCPJJFHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19B2BF0", Offset = "0x19B1FF0", VA = "0x1819B2BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double IAKPBONBDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x554B2B0", Offset = "0x554A6B0", VA = "0x18554B2B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x554B0F0", Offset = "0x554A4F0", VA = "0x18554B0F0")]
	public void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x554B170", Offset = "0x554A570", VA = "0x18554B170")]
	public void EDECDJICJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x554B0D0", Offset = "0x554A4D0", VA = "0x18554B0D0")]
	public void BEFCPCOOIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x554B250", Offset = "0x554A650", VA = "0x18554B250")]
	public void GABEKGMGPBA(long MLJIHONEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x554B2A0", Offset = "0x554A6A0", VA = "0x18554B2A0")]
	public void IOIIHPGCMPF(long MNAGKNPLLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x554B270", Offset = "0x554A670", VA = "0x18554B270")]
	public void GNHGHFJOODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x554B310", Offset = "0x554A710", VA = "0x18554B310")]
	public void LIGIOIBDBDE(long HLAIOBDJKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x554B360", Offset = "0x554A760", VA = "0x18554B360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x554B1B0", Offset = "0x554A5B0", VA = "0x18554B1B0")]
	public void FMJLAKKADOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public MCIGJAFLPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LBODILBHBIN
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> GELCDGDBBLN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5548770", Offset = "0x5547B70", VA = "0x185548770")]
	public static IPEndPoint GLCDIJKOIMD(string ALLMPIGDACB, int FAPNKFCFBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55485A0", Offset = "0x55479A0", VA = "0x1855485A0")]
	public static IPAddress AHKBNNPCMPL(string ALLMPIGDACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5548510", Offset = "0x5547910", VA = "0x185548510")]
	public static IPAddress AHKBNNPCMPL(string ALLMPIGDACB, AddressFamily PCOBGONPHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55489C0", Offset = "0x5547DC0", VA = "0x1855489C0")]
	internal static int HLKLMAMEBED(int NLGPAPDCPAG, int HIHKGKDDEGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2735BA0", Offset = "0x2734FA0", VA = "0x182735BA0")]
	internal static T[] HDGMDNLKEBM<T>(int CBPPKGAPPDD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JPOIBBEPKOF : IGHBMFILFCD
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KBBMLNJOPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private DLHMOLDGGJG DIKMEJPOFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long GNICMHDCNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool KKPKDODPCID;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5548470", Offset = "0x5547870", VA = "0x185548470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55483E0", Offset = "0x55477E0", VA = "0x1855483E0")]
		public void DLFOKGLGICG(DLHMOLDGGJG LOKMAGFHFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5548400", Offset = "0x5547800", VA = "0x185548400")]
		public bool IBGHAHOPAEM(long BKCOBIPKMLL, EFILJKLFDAA LMFHKPNLHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5548390", Offset = "0x5547790", VA = "0x185548390")]
		public bool BILLODBOEME(EFILJKLFDAA LMFHKPNLHDO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly DLHMOLDGGJG FIBLMAJMICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly KBBMLNJOPJP[] MOGJNIPEJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly DLHMOLDGGJG[] CCGLBLLAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] JLAEELLALEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int OEBGBDNEJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GKMAAMKJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int MMEJJKMMAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int NOHCJGMOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool BPIHKHDDNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly GNOINGNLHKL LDCDJLIBKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool EPFEKPNEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int CGEEBFCHLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte FNBGMELHKBI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55481C0", Offset = "0x55475C0", VA = "0x1855481C0")]
	public JPOIBBEPKOF(EFILJKLFDAA LMFHKPNLHDO, bool GAOOJKAECIN, byte FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55472F0", Offset = "0x55466F0", VA = "0x1855472F0")]
	private void AIONEPHPBNB(DLHMOLDGGJG LOKMAGFHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5547D10", Offset = "0x5547110", VA = "0x185547D10", Slot = "4")]
	protected override bool LBIIDJBEDMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55476B0", Offset = "0x5546AB0", VA = "0x1855476B0", Slot = "5")]
	public override bool JCMDNLDLOKO(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JKDMDOKPIIL : IGHBMFILFCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int JABNDFCCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort GKMAAMKJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool OIOLGKEENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private DLHMOLDGGJG NEPPFNDJIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly DLHMOLDGGJG CPPNLGJDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool GLGLIAPMFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte FNBGMELHKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long ACIIJJPAEEL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5547230", Offset = "0x5546630", VA = "0x185547230")]
	public JKDMDOKPIIL(EFILJKLFDAA LMFHKPNLHDO, bool HBMOACBOHOJ, byte FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5546D90", Offset = "0x5546190", VA = "0x185546D90", Slot = "4")]
	protected override bool LBIIDJBEDMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5546A80", Offset = "0x5545E80", VA = "0x185546A80", Slot = "5")]
	public override bool JCMDNLDLOKO(DLHMOLDGGJG LOKMAGFHFCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FFHILOBAKHL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct FEICMCFJHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong OFBODLPHFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double DFGNELIOCLN;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FPKCLDGGFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int LOCFJFFCHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float GGOEFCHMAAL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x553E9A0", Offset = "0x553DDA0", VA = "0x18553E9A0")]
	private static void HPILDDMDJAD(byte[] DICNEFJIMOI, int JNLHAMBBADE, ulong ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5544FA0", Offset = "0x55443A0", VA = "0x185544FA0")]
	private static void HPILDDMDJAD(byte[] DICNEFJIMOI, int JNLHAMBBADE, int ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5544F60", Offset = "0x5544360", VA = "0x185544F60")]
	public static void HPILDDMDJAD(byte[] DICNEFJIMOI, int JNLHAMBBADE, short ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5545010", Offset = "0x5544410", VA = "0x185545010")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, double ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5544EE0", Offset = "0x55442E0", VA = "0x185544EE0")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5544F60", Offset = "0x5544360", VA = "0x185544F60")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, short ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5544F60", Offset = "0x5544360", VA = "0x185544F60")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, ushort ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5544FA0", Offset = "0x55443A0", VA = "0x185544FA0")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, int ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5544FA0", Offset = "0x55443A0", VA = "0x185544FA0")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, uint ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5544ED0", Offset = "0x55442D0", VA = "0x185544ED0")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, long ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5544ED0", Offset = "0x55442D0", VA = "0x185544ED0")]
	public static void EALEOEBFIEA(byte[] PIOIENDCJNH, int ACGCEBPHGCG, ulong ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NNAJOBMIIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] MHDPHJDDLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int GEDENCILIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int OOEKMADDKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int PFEFDIPBHKL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] ACCHHAIHLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int FCAJDIIECOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LDOCGMBDDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x554CA00", Offset = "0x554BE00", VA = "0x18554CA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OBKMOJCOIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C6A2C0", Offset = "0x1C696C0", VA = "0x181C6A2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OJHMJOHDHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x554C690", Offset = "0x554BA90", VA = "0x18554C690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x554CC50", Offset = "0x554C050", VA = "0x18554CC50")]
	public void OJNLDIOPNCE(byte[] HEKLPNHIOGD, int JNLHAMBBADE, int DNCJCIPEFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public NNAJOBMIIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x554CCD0", Offset = "0x554C0D0", VA = "0x18554CCD0")]
	public NNAJOBMIIPB(byte[] HEKLPNHIOGD, int JNLHAMBBADE, int DNCJCIPEFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x554C790", Offset = "0x554BB90", VA = "0x18554C790")]
	public IPEndPoint LLDGCLNOGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x554C190", Offset = "0x554B590", VA = "0x18554C190")]
	public byte BBBMEDNEPDC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x554C190", Offset = "0x554B590", VA = "0x18554C190")]
	public sbyte DKBDNKOGNJH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27BC5B0", Offset = "0x27BB9B0", VA = "0x1827BC5B0")]
	public T[] IFLBALCDBIF<T>(ushort HFPFBPPBALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x554CC90", Offset = "0x554C090", VA = "0x18554CC90")]
	public bool[] POJNJBPMOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x554C5E0", Offset = "0x554B9E0", VA = "0x18554C5E0")]
	public ushort[] HGBELGPMDLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x554C0E0", Offset = "0x554B4E0", VA = "0x18554C0E0")]
	public short[] AAGKGDFOPGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x554C940", Offset = "0x554BD40", VA = "0x18554C940")]
	public int[] NAHGNHBAEEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x554C750", Offset = "0x554BB50", VA = "0x18554C750")]
	public uint[] LIPLKFMIMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x554C320", Offset = "0x554B720", VA = "0x18554C320")]
	public float[] DPPNCKLOPIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x554C270", Offset = "0x554B670", VA = "0x18554C270")]
	public double[] DEIFAGDOJIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x554C9C0", Offset = "0x554BDC0", VA = "0x18554C9C0")]
	public long[] ODLJGNMKKKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x554C6A0", Offset = "0x554BAA0", VA = "0x18554C6A0")]
	public ulong[] KOABEFOPCIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x554C440", Offset = "0x554B840", VA = "0x18554C440")]
	public string[] FHOCLJKAFMA(int FIGAIMJHKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x554C1F0", Offset = "0x554B5F0", VA = "0x18554C1F0")]
	public bool BKEOKGMAMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x554C6E0", Offset = "0x554BAE0", VA = "0x18554C6E0")]
	public char PJCBILFMMEH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x554C6E0", Offset = "0x554BAE0", VA = "0x18554C6E0")]
	public ushort LEMOGKICPIH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x554C620", Offset = "0x554BA20", VA = "0x18554C620")]
	public short IDMFAINKJED()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x554C570", Offset = "0x554B970", VA = "0x18554C570")]
	public long FIODPNEAEAI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x554C860", Offset = "0x554BC60", VA = "0x18554C860")]
	public ulong MEIBFPHBFKI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x554C360", Offset = "0x554B760", VA = "0x18554C360")]
	public int FEPOEHJCLFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x554C8D0", Offset = "0x554BCD0", VA = "0x18554C8D0")]
	public uint MEPJIOHOMIJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x554C2B0", Offset = "0x554B6B0", VA = "0x18554C2B0")]
	public float DJKKACPAAAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x554C120", Offset = "0x554B520", VA = "0x18554C120")]
	public double AGPAPJDFDPJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x554CA10", Offset = "0x554BE10", VA = "0x18554CA10")]
	public string OFHNCPFICEP(int AKAFCPJAPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x554C3D0", Offset = "0x554B7D0", VA = "0x18554C3D0")]
	public ArraySegment<byte> FGPNJOEOHPC(int CBPPKGAPPDD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x554C980", Offset = "0x554BD80", VA = "0x18554C980")]
	public sbyte[] NKCKEMEICHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x554C230", Offset = "0x554B630", VA = "0x18554C230")]
	public byte[] CCDDNLFMCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x554C1D0", Offset = "0x554B5D0", VA = "0x18554C1D0")]
	public void BILLODBOEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LLPEMFBHHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] MHDPHJDDLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int GEDENCILIHK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int FJFDNOMAIOO = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool CLCIFNOMFEE;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding BJAGGDMCGFO;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int GODNPOBMFNC = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] GKANDMLCAFB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] NCANEPOJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55497B0", Offset = "0x5548BB0", VA = "0x1855497B0")]
	public LLPEMFBHHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5549830", Offset = "0x5548C30", VA = "0x185549830")]
	public LLPEMFBHHCA(bool LEJBODFOBOP, int GHHJCBHGFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55491C0", Offset = "0x55485C0", VA = "0x1855491C0")]
	public static LLPEMFBHHCA GGKCLEHAILI(string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5549230", Offset = "0x5548630", VA = "0x185549230")]
	public void GGLDBOGJPEE(int CMNNOIEHNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3BD0", Offset = "0x1CE2FD0", VA = "0x181CE3BD0")]
	public void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5548C90", Offset = "0x5548090", VA = "0x185548C90")]
	public void DEGMNLKKFJO(float ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5548EC0", Offset = "0x55482C0", VA = "0x185548EC0")]
	public void DEGMNLKKFJO(double ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5548D30", Offset = "0x5548130", VA = "0x185548D30")]
	public void DEGMNLKKFJO(long ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5548D30", Offset = "0x5548130", VA = "0x185548D30")]
	public void DEGMNLKKFJO(ulong ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5549130", Offset = "0x5548530", VA = "0x185549130")]
	public void DEGMNLKKFJO(int ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5549130", Offset = "0x5548530", VA = "0x185549130")]
	public void DEGMNLKKFJO(uint ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5548C20", Offset = "0x5548020", VA = "0x185548C20")]
	public void DEGMNLKKFJO(char ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5548C20", Offset = "0x5548020", VA = "0x185548C20")]
	public void DEGMNLKKFJO(ushort ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5548C20", Offset = "0x5548020", VA = "0x185548C20")]
	public void DEGMNLKKFJO(short ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5548BC0", Offset = "0x5547FC0", VA = "0x185548BC0")]
	public void DEGMNLKKFJO(sbyte ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5548BC0", Offset = "0x5547FC0", VA = "0x185548BC0")]
	public void DEGMNLKKFJO(byte ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5548D80", Offset = "0x5548180", VA = "0x185548D80")]
	public void DEGMNLKKFJO(byte[] ALPLHOOHPEL, int JNLHAMBBADE, int FLCGLAMBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5548A80", Offset = "0x5547E80", VA = "0x185548A80")]
	public void ENKAIHGFFBC(sbyte[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5548A80", Offset = "0x5547E80", VA = "0x185548A80")]
	public void BEFIDNDDIBO(byte[] ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5548B60", Offset = "0x5547F60", VA = "0x185548B60")]
	public void DEGMNLKKFJO(bool ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5549640", Offset = "0x5548A40", VA = "0x185549640")]
	public void KFLFDJKGCCL(Array KNIBGNNBLFL, int CBGNMAFEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x55493B0", Offset = "0x55487B0", VA = "0x1855493B0")]
	public void KFLFDJKGCCL(float[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5549560", Offset = "0x5548960", VA = "0x185549560")]
	public void KFLFDJKGCCL(double[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5549560", Offset = "0x5548960", VA = "0x185549560")]
	public void KFLFDJKGCCL(long[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5549560", Offset = "0x5548960", VA = "0x185549560")]
	public void KFLFDJKGCCL(ulong[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x55493B0", Offset = "0x55487B0", VA = "0x1855493B0")]
	public void KFLFDJKGCCL(int[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55493B0", Offset = "0x55487B0", VA = "0x1855493B0")]
	public void KFLFDJKGCCL(uint[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55492D0", Offset = "0x55486D0", VA = "0x1855492D0")]
	public void KFLFDJKGCCL(ushort[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x55492D0", Offset = "0x55486D0", VA = "0x1855492D0")]
	public void KFLFDJKGCCL(short[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5548A80", Offset = "0x5547E80", VA = "0x185548A80")]
	public void KFLFDJKGCCL(bool[] ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5549490", Offset = "0x5548890", VA = "0x185549490")]
	public void KFLFDJKGCCL(string[] ANJCCKHBJJO, int KLPHAEKIPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5548DF0", Offset = "0x55481F0", VA = "0x185548DF0")]
	public void DEGMNLKKFJO(IPEndPoint DFPNKCDGGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5549120", Offset = "0x5548520", VA = "0x185549120")]
	public void DEGMNLKKFJO(string ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5548F10", Offset = "0x5548310", VA = "0x185548F10")]
	public void DEGMNLKKFJO(string ANJCCKHBJJO, int AKAFCPJAPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DNNMMCJBGOA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FCCCMINIHKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong CFEBOJMAFCI;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x362A440", Offset = "0x3629840", VA = "0x18362A440")]
		static FCCCMINIHKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void JJKJAICHGGP(NNAJOBMIIPB EMDFNBPIKNJ, object PFLIDENGDDC);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FAEDPBMOKLH<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public DNNMMCJBGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public FAEDPBMOKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x36284D0", Offset = "0x36278D0", VA = "0x1836284D0")]
		internal void ADOJCPNFGCO(NNAJOBMIIPB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MGIGOOBAMIJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public DNNMMCJBGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public MGIGOOBAMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9C90", Offset = "0x3DE9090", VA = "0x183DE9C90")]
		internal void ADOJCPNFGCO(NNAJOBMIIPB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BFPNIKIBCCH AGFDICPKPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, JJKJAICHGGP> LDGKNMJEHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly LLPEMFBHHCA PPNNPDFJOOD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x553FD40", Offset = "0x553F140", VA = "0x18553FD40")]
	public DNNMMCJBGOA(int FIGAIMJHKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2455E80", Offset = "0x2455280", VA = "0x182455E80", Slot = "4")]
	protected virtual ulong GPIHIJFHLDJ<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x553FC10", Offset = "0x553F010", VA = "0x18553FC10", Slot = "5")]
	protected virtual JJKJAICHGGP NCOKPNHMPCF(NNAJOBMIIPB EMDFNBPIKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2521120", Offset = "0x2520520", VA = "0x182521120", Slot = "6")]
	protected virtual void FNCGJDGIIAH<T>(LLPEMFBHHCA MGAHLAJFBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x553FB90", Offset = "0x553EF90", VA = "0x18553FB90")]
	public void JOCJICHELBE(NNAJOBMIIPB EMDFNBPIKNJ, object PFLIDENGDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2521090", Offset = "0x2520490", VA = "0x182521090")]
	public void DKGLIBKFBPG<T>(LLPEMFBHHCA MGAHLAJFBKF, T LOKMAGFHFCE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x553FB40", Offset = "0x553EF40", VA = "0x18553FB40")]
	public void FNKGNPBOBKI(NNAJOBMIIPB EMDFNBPIKNJ, object PFLIDENGDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2521310", Offset = "0x2520710", VA = "0x182521310")]
	public void JEHNPLAJBJH<T>(Action<T> FALADIKDLLF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2521190", Offset = "0x2520590", VA = "0x182521190")]
	public void JEHNPLAJBJH<T, TUserData>(Action<T, TUserData> FALADIKDLLF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LMAFCFFHBNL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x553ED20", Offset = "0x553E120", VA = "0x18553ED20")]
	public LMAFCFFHBNL(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HAPLBGMPFNC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x55450D0", Offset = "0x55444D0", VA = "0x1855450D0")]
	public HAPLBGMPFNC(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BFPNIKIBCCH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum DMECGDEEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class GEBKIOGKMKL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public DMECGDEEGMO KEFOPLEGHIO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x36FD860", Offset = "0x36FCC60", VA = "0x1836FD860", Slot = "4")]
		public virtual void DLFOKGLGICG(MethodInfo CNJNFIFCIMM, MethodInfo BCBIFPNGNFJ, DMECGDEEGMO FICJMFBEBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MBGDPCNMNAN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void BNGFPHDNCBF(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		protected GEBKIOGKMKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class NBKEDMLCJMA<TClass, TProperty> : GEBKIOGKMKL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> BEPHHPGAIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> EBEKNHDLBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> DNNOGBPJFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> AIODGCKJHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> BGLMKEOPNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> DLBPIMDKBAB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E6A0", Offset = "0x3E8DAA0", VA = "0x183E8E6A0", Slot = "7")]
		public override void OGHHAOEMOPN(TClass JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E87690", Offset = "0x3E86A90", VA = "0x183E87690", Slot = "8")]
		public override void AFPIABKHJBE(TClass JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E240", Offset = "0x3E8D640", VA = "0x183E8E240", Slot = "9")]
		public override void MBGDPCNMNAN(TClass JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E882D0", Offset = "0x3E876D0", VA = "0x183E882D0", Slot = "10")]
		public override void BNGFPHDNCBF(TClass JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D730", Offset = "0x3E8CB30", VA = "0x183E8D730")]
		protected TProperty[] ENONEIMPEHO(TClass JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D830", Offset = "0x3E8CC30", VA = "0x183E8D830")]
		protected TProperty[] GDCEIFDEIHF(TClass JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E88C70", Offset = "0x3E88070", VA = "0x183E88C70", Slot = "4")]
		public override void DLFOKGLGICG(MethodInfo CNJNFIFCIMM, MethodInfo BCBIFPNGNFJ, DMECGDEEGMO FICJMFBEBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x37541E0", Offset = "0x37535E0", VA = "0x1837541E0")]
		protected NBKEDMLCJMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class KHEPLIAKCAF<TClass, TProperty> : NBKEDMLCJMA<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KMAJIEJKGGF(NNAJOBMIIPB DMMNOJMKOEO, [Out] TProperty EJJMNEPMCIM);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void DEHNJGDNINE(LLPEMFBHHCA ILMPPGIJBNP, TProperty EJJMNEPMCIM);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7EE0", Offset = "0x3AC72E0", VA = "0x183AC7EE0", Slot = "5")]
		public override void FALEBMBGEKM(TClass JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7DF0", Offset = "0x3AC71F0", VA = "0x183AC7DF0", Slot = "6")]
		public override void DKGLIBKFBPG(TClass JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8000", Offset = "0x3AC7400", VA = "0x183AC8000", Slot = "7")]
		public override void OGHHAOEMOPN(TClass JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7CE0", Offset = "0x3AC70E0", VA = "0x183AC7CE0", Slot = "8")]
		public override void AFPIABKHJBE(TClass JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3843A30", Offset = "0x3842E30", VA = "0x183843A30")]
		protected KHEPLIAKCAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EPBDNDIJOHN<T> : NBKEDMLCJMA<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x32E5F70", Offset = "0x32E5370", VA = "0x1832E5F70", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32E5F10", Offset = "0x32E5310", VA = "0x1832E5F10", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x32E5FE0", Offset = "0x32E53E0", VA = "0x1832E5FE0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x32E5EB0", Offset = "0x32E52B0", VA = "0x1832E5EB0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public EPBDNDIJOHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class COPEABBPMKP<T> : NBKEDMLCJMA<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B170", Offset = "0x4B0A570", VA = "0x184B0B170", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x32E5F10", Offset = "0x32E5310", VA = "0x1832E5F10", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B1E0", Offset = "0x4B0A5E0", VA = "0x184B0B1E0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x32E5EB0", Offset = "0x32E52B0", VA = "0x1832E5EB0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public COPEABBPMKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HNBCFDGDCPJ<T> : NBKEDMLCJMA<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3778D80", Offset = "0x3778180", VA = "0x183778D80", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3778D20", Offset = "0x3778120", VA = "0x183778D20", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3778DF0", Offset = "0x37781F0", VA = "0x183778DF0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3778CC0", Offset = "0x37780C0", VA = "0x183778CC0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public HNBCFDGDCPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JIIEGFCMGKJ<T> : NBKEDMLCJMA<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AA60", Offset = "0x3A39E60", VA = "0x183A3AA60", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3778D20", Offset = "0x3778120", VA = "0x183778D20", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3A3AAD0", Offset = "0x3A39ED0", VA = "0x183A3AAD0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3778CC0", Offset = "0x37780C0", VA = "0x183778CC0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public JIIEGFCMGKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EIKOCNOFBAI<T> : NBKEDMLCJMA<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x32B8770", Offset = "0x32B7B70", VA = "0x1832B8770", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x32B8710", Offset = "0x32B7B10", VA = "0x1832B8710", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x32B87E0", Offset = "0x32B7BE0", VA = "0x1832B87E0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x32B86B0", Offset = "0x32B7AB0", VA = "0x1832B86B0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public EIKOCNOFBAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CIAKCEHFIOO<T> : NBKEDMLCJMA<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A28DC0", Offset = "0x4A281C0", VA = "0x184A28DC0", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x32B8710", Offset = "0x32B7B10", VA = "0x1832B8710", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A28E30", Offset = "0x4A28230", VA = "0x184A28E30", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x32B86B0", Offset = "0x32B7AB0", VA = "0x1832B86B0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public CIAKCEHFIOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NLBLECILAEN<T> : NBKEDMLCJMA<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x377CB50", Offset = "0x377BF50", VA = "0x18377CB50", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x377CAF0", Offset = "0x377BEF0", VA = "0x18377CAF0", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED94F0", Offset = "0x3ED88F0", VA = "0x183ED94F0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x377CA90", Offset = "0x377BE90", VA = "0x18377CA90", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public NLBLECILAEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HOAMHBPLGFN<T> : NBKEDMLCJMA<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x377CB50", Offset = "0x377BF50", VA = "0x18377CB50", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x377CAF0", Offset = "0x377BEF0", VA = "0x18377CAF0", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x377CBC0", Offset = "0x377BFC0", VA = "0x18377CBC0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x377CA90", Offset = "0x377BE90", VA = "0x18377CA90", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public HOAMHBPLGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class IPFAJBBJJHL<T> : NBKEDMLCJMA<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x383FE50", Offset = "0x383F250", VA = "0x18383FE50", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x383FDF0", Offset = "0x383F1F0", VA = "0x18383FDF0", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x383FEC0", Offset = "0x383F2C0", VA = "0x18383FEC0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x32E5EB0", Offset = "0x32E52B0", VA = "0x1832E5EB0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public IPFAJBBJJHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class FACAKHEMIEI<T> : NBKEDMLCJMA<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3628280", Offset = "0x3627680", VA = "0x183628280", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3628220", Offset = "0x3627620", VA = "0x183628220", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x36282F0", Offset = "0x36276F0", VA = "0x1836282F0", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x32B86B0", Offset = "0x32B7AB0", VA = "0x1832B86B0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public FACAKHEMIEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HOJOBFOCBHG<T> : NBKEDMLCJMA<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x377D520", Offset = "0x377C920", VA = "0x18377D520", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x377D4C0", Offset = "0x377C8C0", VA = "0x18377D4C0", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x377D590", Offset = "0x377C990", VA = "0x18377D590", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x377CA90", Offset = "0x377BE90", VA = "0x18377CA90", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32B8850", Offset = "0x32B7C50", VA = "0x1832B8850")]
		public HOJOBFOCBHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ODFBEFHKMPM<T> : KHEPLIAKCAF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8D40", Offset = "0x3FC8140", VA = "0x183FC8D40", Slot = "12")]
		protected override void DEHNJGDNINE(LLPEMFBHHCA ILMPPGIJBNP, char EJJMNEPMCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8D70", Offset = "0x3FC8170", VA = "0x183FC8D70", Slot = "11")]
		protected override void KMAJIEJKGGF(NNAJOBMIIPB DMMNOJMKOEO, [Out] char EJJMNEPMCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x32BF2B0", Offset = "0x32BE6B0", VA = "0x1832BF2B0")]
		public ODFBEFHKMPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class FEJIHPPPEKG<T> : KHEPLIAKCAF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3639880", Offset = "0x3638C80", VA = "0x183639880", Slot = "12")]
		protected override void DEHNJGDNINE(LLPEMFBHHCA ILMPPGIJBNP, IPEndPoint EJJMNEPMCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x36398B0", Offset = "0x3638CB0", VA = "0x1836398B0", Slot = "11")]
		protected override void KMAJIEJKGGF(NNAJOBMIIPB DMMNOJMKOEO, [Out] IPEndPoint EJJMNEPMCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x32BF2B0", Offset = "0x32BE6B0", VA = "0x1832BF2B0")]
		public FEJIHPPPEKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GCGFJHLOOIC<T> : NBKEDMLCJMA<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int FJFNPMDPDEL;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x36F9FA0", Offset = "0x36F93A0", VA = "0x1836F9FA0")]
		public GCGFJHLOOIC(int AKAFCPJAPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x36F9EC0", Offset = "0x36F92C0", VA = "0x1836F9EC0", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x36F9E50", Offset = "0x36F9250", VA = "0x1836F9E50", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36F9F30", Offset = "0x36F9330", VA = "0x1836F9F30", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x36F9DE0", Offset = "0x36F91E0", VA = "0x1836F9DE0", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class PNCAFELNLEG<T> : GEBKIOGKMKL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo FDLPNNGHICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type MIIHABOPLGM;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x40B5060", Offset = "0x40B4460", VA = "0x1840B5060")]
		public PNCAFELNLEG(PropertyInfo PLNALAIILFK, Type EHHLDCJKKMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x40B4EE0", Offset = "0x40B42E0", VA = "0x1840B4EE0", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x40B4E30", Offset = "0x40B4230", VA = "0x1840B4E30", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x40B5000", Offset = "0x40B4400", VA = "0x1840B5000", Slot = "7")]
		public override void OGHHAOEMOPN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x40B4D70", Offset = "0x40B4170", VA = "0x1840B4D70", Slot = "8")]
		public override void AFPIABKHJBE(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x40B4FA0", Offset = "0x40B43A0", VA = "0x1840B4FA0", Slot = "9")]
		public override void MBGDPCNMNAN(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x40B4DD0", Offset = "0x40B41D0", VA = "0x1840B4DD0", Slot = "10")]
		public override void BNGFPHDNCBF(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KMDJIOAICEO<T> : PNCAFELNLEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
		public KMDJIOAICEO(PropertyInfo PLNALAIILFK, Type EHHLDCJKKMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3F20", Offset = "0x3AD3320", VA = "0x183AD3F20", Slot = "5")]
		public override void FALEBMBGEKM(T JJOOHKPELEK, NNAJOBMIIPB DMMNOJMKOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3E70", Offset = "0x3AD3270", VA = "0x183AD3E70", Slot = "6")]
		public override void DKGLIBKFBPG(T JJOOHKPELEK, LLPEMFBHHCA ILMPPGIJBNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class IFJOOAGBPKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static IFJOOAGBPKG<T> GHDJCOLHINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly GEBKIOGKMKL<T>[] NGPNLDJIABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int GJLMCGFEAMO;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3825DB0", Offset = "0x38251B0", VA = "0x183825DB0")]
		public IFJOOAGBPKG(List<GEBKIOGKMKL<T>> HHJODLFFCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3825C50", Offset = "0x3825050", VA = "0x183825C50")]
		public void DKGLIBKFBPG(T BHPOPDOKECN, LLPEMFBHHCA MGAHLAJFBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3825D00", Offset = "0x3825100", VA = "0x183825D00")]
		public void FALEBMBGEKM(T BHPOPDOKECN, NNAJOBMIIPB EMDFNBPIKNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NOHJCGPCCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract GEBKIOGKMKL<T> JJNOBLLAEFC<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private LLPEMFBHHCA DAPMFCHKBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int AKHBMAJLNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, NOHJCGPCCIN> DDOEAJAIFML;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x553EB30", Offset = "0x553DF30", VA = "0x18553EB30")]
	public BFPNIKIBCCH(int FIGAIMJHKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2455FE0", Offset = "0x24553E0", VA = "0x182455FE0")]
	private IFJOOAGBPKG<T> PGMNLPCJPBP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2455FD0", Offset = "0x24553D0", VA = "0x182455FD0")]
	public void NLKKEGKJEDJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2455F50", Offset = "0x2455350", VA = "0x182455F50")]
	public bool JCEFODEMOAF<T>(NNAJOBMIIPB EMDFNBPIKNJ, T JILDGEDOLHB) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2455EF0", Offset = "0x24552F0", VA = "0x182455EF0")]
	public void ILCGODJBNBA<T>(LLPEMFBHHCA MGAHLAJFBKF, T BHPOPDOKECN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JJFEPOOHDFK
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime MLCHBCEOAND;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GMLHINFPKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HKHPCJMDIFK PCFKCDCJBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x55456F0", Offset = "0x5544AF0", VA = "0x1855456F0")]
		get
		{
			return default(HKHPCJMDIFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int MPJAPEJHNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5545D70", Offset = "0x5545170", VA = "0x185545D70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5545B60", Offset = "0x5544F60", VA = "0x185545B60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CGAIDHOAFNP DDHMLFAGHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5545E20", Offset = "0x5545220", VA = "0x185545E20")]
		get
		{
			return default(CGAIDHOAFNP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5546350", Offset = "0x5545750", VA = "0x185546350")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OMAOCPEFGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5546320", Offset = "0x5545720", VA = "0x185546320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint LEGOAMOAMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5545DA0", Offset = "0x55451A0", VA = "0x185545DA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? OEIBEMMBKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5545B00", Offset = "0x5544F00", VA = "0x185545B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? GOGLKJLHJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5545B30", Offset = "0x5544F30", VA = "0x185545B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KNGNDMLDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5545E50", Offset = "0x5545250", VA = "0x185545E50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5545F50", Offset = "0x5545350", VA = "0x185545F50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? PHFFIMODPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1FB90", Offset = "0xA1EF90", VA = "0x180A1FB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x895550", Offset = "0x894950", VA = "0x180895550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5546760", Offset = "0x5545B60", VA = "0x185546760")]
	public JJFEPOOHDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x55466B0", Offset = "0x5545AB0", VA = "0x1855466B0")]
	internal JJFEPOOHDFK(byte[] PIOIENDCJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x55457B0", Offset = "0x5544BB0", VA = "0x1855457B0")]
	public static JJFEPOOHDFK DAFGMPDGKMM(byte[] PIOIENDCJNH, DateTime HHAMKDBDCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5546390", Offset = "0x5545790", VA = "0x185546390")]
	internal void PHBEFAILBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5545BA0", Offset = "0x5544FA0", VA = "0x185545BA0")]
	private void GDPKHKCMAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5546120", Offset = "0x5545520", VA = "0x185546120")]
	private DateTime? MLJKAKBAEEF(int JNLHAMBBADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5545930", Offset = "0x5544D30", VA = "0x185545930")]
	private void DMOKPDMHEKB(int JNLHAMBBADE, DateTime? ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5545E80", Offset = "0x5545280", VA = "0x185545E80")]
	private ulong LCJENNFIEAA(int JNLHAMBBADE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5546590", Offset = "0x5545990", VA = "0x185546590")]
	private void PPMNLDKIEEK(int JNLHAMBBADE, ulong ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5545720", Offset = "0x5544B20", VA = "0x185545720")]
	private uint BNGJBKKLDHE(int JNLHAMBBADE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x542E690", Offset = "0x542DA90", VA = "0x18542E690")]
	private static uint DCIGJBGHKAL(uint NEEBEKKMNIB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55458D0", Offset = "0x5544CD0", VA = "0x1855458D0")]
	private static ulong DCIGJBGHKAL(ulong NEEBEKKMNIB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HKHPCJMDIFK
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
public enum CGAIDHOAFNP
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class PAMPLABDKBC
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int ECBFCCKHAPB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int AIOEDHBOLLA = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int DCAJKHEMKHL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint NPJDEKGMFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int FKBAPFJEEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int COKGGBLPFNB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool COJGEIJHHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5554A00", Offset = "0x5553E00", VA = "0x185554A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5554A10", Offset = "0x5553E10", VA = "0x185554A10")]
	public bool HAPGKJMBFAP(EOJDLFOGLEC EHNDAOOFIBO, int OJFBKFAHIPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class DOPHGEHKEMK : EOJDLFOGLEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket EHNDAOOFIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly OIIDFFJNJHI EDONGGEGKCL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short JGGEEAPKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x55404A0", Offset = "0x553F8A0", VA = "0x1855404A0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GCLMDFJDMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5540610", Offset = "0x553FA10", VA = "0x185540610", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint DDMJHJDLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5540480", Offset = "0x553F880", VA = "0x185540480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HJHKAMBNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B45D90", Offset = "0x3B45190", VA = "0x183B45D90", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5540630", Offset = "0x553FA30", VA = "0x185540630")]
	public DOPHGEHKEMK(AddressFamily PCOBGONPHEB, OIIDFFJNJHI EDONGGEGKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x553FEC0", Offset = "0x553F2C0", VA = "0x18553FEC0", Slot = "8")]
	public bool EBECJFLCBOB(IPEndPoint DFPNKCDGGIE, IJAFGBGLAMG ENHGFOPJKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55405D0", Offset = "0x553F9D0", VA = "0x1855405D0", Slot = "9")]
	public int KPGBOPPMPMF(byte[] DICNEFJIMOI, int JNLHAMBBADE, int HFPFBPPBALK, IPEndPoint DECKPKPMGMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55404E0", Offset = "0x553F8E0", VA = "0x1855404E0", Slot = "10")]
	public int KJPPJPGPADO(byte[] DICNEFJIMOI, EndPoint CEDGPMPMJKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55404C0", Offset = "0x553F8C0", VA = "0x1855404C0", Slot = "11")]
	public void JLPBODOJJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface EOJDLFOGLEC
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short JGGEEAPKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int GCLMDFJDMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint DDMJHJDLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily HJHKAMBNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EBECJFLCBOB(IPEndPoint DFPNKCDGGIE, IJAFGBGLAMG ENHGFOPJKKN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KPGBOPPMPMF(byte[] DICNEFJIMOI, int JNLHAMBBADE, int HFPFBPPBALK, IPEndPoint DECKPKPMGMK);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KJPPJPGPADO(byte[] DICNEFJIMOI, EndPoint DECKPKPMGMK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLPBODOJJAH();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct PDNMEJGFNAP : IEquatable<PDNMEJGFNAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long LDDAJKCGMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long JNKHKGNMNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long ELNKHOIDEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int EHBMAJKHELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int CLLEOLGGGIM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5554BF0", Offset = "0x5553FF0", VA = "0x185554BF0")]
	public PDNMEJGFNAP(byte[] DNEGIHJCAJC, int NCMNPEHLGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C7730", Offset = "0x7C6B30", VA = "0x1807C7730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5554BB0", Offset = "0x5553FB0", VA = "0x185554BB0", Slot = "4")]
	public bool Equals(PDNMEJGFNAP KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5554B00", Offset = "0x5553F00", VA = "0x185554B00", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JODFCACMOHH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] ILNINGGKCCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HGILLFFKPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int JNCDCMBJDOA;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
	protected HGILLFFKPPC(int OAGBBELMDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IGBBEFNFFLD(IPEndPoint DFPNKCDGGIE, byte[] ALPLHOOHPEL, int JNLHAMBBADE, int FLCGLAMBOBC);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void EGKCDKEABDE(IPEndPoint DFPNKCDGGIE, byte[] ALPLHOOHPEL, int JNLHAMBBADE, int FLCGLAMBOBC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OCHIOANHFCJ : HGILLFFKPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider OMHFACJHKFE;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator PHCFGNOEGDM;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x554D970", Offset = "0x554CD70", VA = "0x18554D970")]
	public OCHIOANHFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x554D640", Offset = "0x554CA40", VA = "0x18554D640")]
	public void KLEHJLAENGC(IPEndPoint DFPNKCDGGIE, byte[] GPGELODKPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x554D0D0", Offset = "0x554C4D0", VA = "0x18554D0D0")]
	public void FHBDPIHHECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x554D880", Offset = "0x554CC80", VA = "0x18554D880")]
	private byte[] LGHBPPBKOOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x554D1B0", Offset = "0x554C5B0", VA = "0x18554D1B0", Slot = "4")]
	public override void IGBBEFNFFLD(IPEndPoint DFPNKCDGGIE, byte[] ALPLHOOHPEL, int JNLHAMBBADE, int FLCGLAMBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x554CD30", Offset = "0x554C130", VA = "0x18554CD30", Slot = "5")]
	public override void EGKCDKEABDE(IPEndPoint DFPNKCDGGIE, byte[] ALPLHOOHPEL, int JNLHAMBBADE, int FLCGLAMBOBC)
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
