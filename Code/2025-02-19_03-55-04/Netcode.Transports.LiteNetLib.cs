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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NPNJAFCDMAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JMIKEJNIKII
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
		private NetworkManager GCMEGDEJNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ODPDJHNBAHH> FAFGADCEKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DNEHOHGCLFO NKPCMJJOHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] BMDKGEHDPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JMIKEJNIKII GBGPCMJJEOC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong OCLIPMGIGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IJFMOHCOHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6831D20", Offset = "0x6830920", VA = "0x186831D20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68312B0", Offset = "0x682FEB0", VA = "0x1868312B0")]
		public void RecRoom_SetEncryptionInfo(ulong NCCHHOJCHHK, byte[] NKANGPLHEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6831290", Offset = "0x682FE90", VA = "0x186831290")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68310A0", Offset = "0x682FCA0", VA = "0x1868310A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6831C20", Offset = "0x6830820", VA = "0x186831C20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68313D0", Offset = "0x682FFD0", VA = "0x1868313D0", Slot = "6")]
		public override void Send(ulong KPGCMDNDABC, ArraySegment<byte> LLDJIJICLJF, NetworkDelivery AABPIHAPOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6831250", Offset = "0x682FE50", VA = "0x186831250", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong KPGCMDNDABC, [Out] ArraySegment<byte> BFDCDDMLJOF, [Out] float KNIBJMJIHCL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68316C0", Offset = "0x68302C0", VA = "0x1868316C0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6831B40", Offset = "0x6830740", VA = "0x186831B40", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6830900", Offset = "0x682F500", VA = "0x186830900", Slot = "10")]
		public override void DisconnectRemoteClient(ulong KPGCMDNDABC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6830810", Offset = "0x682F410", VA = "0x186830810", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6830AF0", Offset = "0x682F6F0", VA = "0x186830AF0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong KPGCMDNDABC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6831650", Offset = "0x6830250", VA = "0x186831650", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6830B90", Offset = "0x682F790", VA = "0x186830B90", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GCMEGDEJNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6830740", Offset = "0x682F340", VA = "0x186830740")]
		private NCMJKIJKFDB DOHOPFLFAHH(NetworkDelivery ADFFEBFOCBD)
		{
			return default(NCMJKIJKFDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6831190", Offset = "0x682FD90", VA = "0x186831190", Slot = "15")]
		private void PIBCPEPNJEN(ODPDJHNBAHH PGFJLIBKENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6830F60", Offset = "0x682FB60", VA = "0x186830F60", Slot = "16")]
		private void LIPFBKIIHBC(ODPDJHNBAHH PGFJLIBKENA, AKMCGDHIHLK PBJOHDNCGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "17")]
		private void HIMJMFLLGBF(IPEndPoint APJFKIEJHHB, SocketError BOJNAEBGNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6830D50", Offset = "0x682F950", VA = "0x186830D50", Slot = "18")]
		private void JKBGIJHKKNP(ODPDJHNBAHH PGFJLIBKENA, EEKOEGJJHLH KLCLFHDKNAH, byte FANKCALENHI, NCMJKIJKFDB INONDCBKBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6830A10", Offset = "0x682F610", VA = "0x186830A10")]
		private void GMLBJHOMKEA(int FJJGAGKDECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "19")]
		private void HBAKKDEDLDP(IPEndPoint FKGGJEKOBPN, EEKOEGJJHLH KLCLFHDKNAH, PJHGBDHACEK DHELBCLPMCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "20")]
		private void KOHHOALPBLJ(ODPDJHNBAHH PGFJLIBKENA, int BKPDKEFKOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6831040", Offset = "0x682FC40", VA = "0x186831040", Slot = "21")]
		private void OJIJFDCNKKG(PHAHPAEKIBH AGFMCIMDGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6830710", Offset = "0x682F310", VA = "0x186830710")]
		private ulong DJMFOMFGFJG(ODPDJHNBAHH PGFJLIBKENA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6831020", Offset = "0x682FC20", VA = "0x186831020")]
		private static int NDJLJFGFCKO(float NOCMKPDPIPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6831C40", Offset = "0x6830840", VA = "0x186831C40")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class MEDGENKKHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ODPDJHNBAHH PDBJNKJFFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<KCOCAACILCA> FGBOEJJAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KACIOHHNAJO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6831E60", Offset = "0x6830A60", VA = "0x186831E60")]
	protected MEDGENKKHJN(ODPDJHNBAHH PGFJLIBKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6831D40", Offset = "0x6830940", VA = "0x186831D40")]
	public void HDEELPHCLLE(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6831DE0", Offset = "0x68309E0", VA = "0x186831DE0")]
	protected void MCEKOFCCBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6831DA0", Offset = "0x68309A0", VA = "0x186831DA0")]
	public bool KDBLBGELEIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool NLCPEBBNPEI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool ABHBAFMACBN(KCOCAACILCA HAPDOAKGICK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum LBBGOOHAIMN
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
public class PHAHPAEKIBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DNEHOHGCLFO KNPMFJKAGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int PJNCNJGMNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal KFKPANKIHJE MBNNGKIILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint JOAOIPIAADB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LBBGOOHAIMN CMBADIJPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x980AE0", Offset = "0x97F6E0", VA = "0x180980AE0")]
		[CompilerGenerated]
		get
		{
			return default(LBBGOOHAIMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC042B0", Offset = "0xC02EB0", VA = "0x180C042B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6836D40", Offset = "0x6835940", VA = "0x186836D40")]
	internal void FAFAONOFJGG(KFKPANKIHJE NDBBHDFGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6836DA0", Offset = "0x68359A0", VA = "0x186836DA0")]
	private bool HIMEACKPHDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6836DD0", Offset = "0x68359D0", VA = "0x186836DD0")]
	internal PHAHPAEKIBH(IPEndPoint FKGGJEKOBPN, KFKPANKIHJE MOHBJCBOHBB, DNEHOHGCLFO JDLCKFEIKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6836CE0", Offset = "0x68358E0", VA = "0x186836CE0")]
	public ODPDJHNBAHH DCLKDJMIIOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PJHGBDHACEK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CDBADPKOKPB
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
public struct AKMCGDHIHLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CDBADPKOKPB JJFCCPFFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BJPOACCLJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EEKOEGJJHLH LCMGCMGOBLA;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPNJAFCDMAN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHLJOFACFG(ODPDJHNBAHH PGFJLIBKENA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAAKOCCCBKK(ODPDJHNBAHH PGFJLIBKENA, AKMCGDHIHLK PBJOHDNCGAG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJEMDPJHOJL(IPEndPoint APJFKIEJHHB, SocketError BOJNAEBGNGI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOHBPBIIOBC(ODPDJHNBAHH PGFJLIBKENA, EEKOEGJJHLH KLCLFHDKNAH, byte FANKCALENHI, NCMJKIJKFDB INONDCBKBCC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFGLFNPFMNL(IPEndPoint FKGGJEKOBPN, EEKOEGJJHLH KLCLFHDKNAH, PJHGBDHACEK DHELBCLPMCL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDGNEJGLFHJ(ODPDJHNBAHH PGFJLIBKENA, int BKPDKEFKOIE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOCALBGIFKP(PHAHPAEKIBH AGFMCIMDGME);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KMJBODKBOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHDAAGJBMEJ(ODPDJHNBAHH PGFJLIBKENA, object DNAMHCLLGDP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KPDMMFFOBGH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHIAFGOAIMD(AAGJPHAMIOK HAPDOAKGICK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CADJEJPCKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHKJDEBNPGC(ODPDJHNBAHH PGFJLIBKENA, IPEndPoint JDFIBBDEAMB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KFKPANKIHJE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int CHEFGMGPDLF = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long KGEPDHFEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte MDLOEODBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] AEBDADKPIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KCLJCFHMMDM JBDHCGELIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int ILBAGIPPDPO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x682FBF0", Offset = "0x682E7F0", VA = "0x18682FBF0")]
	private KFKPANKIHJE(long GOHHEIOGIPD, byte HKFCAEKDAKJ, int JKOPHJKJLOL, byte[] MPMCGIHPLBP, KCLJCFHMMDM LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x682F9B0", Offset = "0x682E5B0", VA = "0x18682F9B0")]
	public static int IBJKLLMBPNK(KCOCAACILCA HAPDOAKGICK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x682F790", Offset = "0x682E390", VA = "0x18682F790")]
	public static KFKPANKIHJE CDDGIJOMOFM(KCOCAACILCA HAPDOAKGICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x682FA10", Offset = "0x682E610", VA = "0x18682FA10")]
	public static KCOCAACILCA OMDGLOGJCFJ(GGJGIJKJIEJ HBONFPBIAAD, SocketAddress OGABLOJPAKO, long BLFCAJEPLOJ, int JKOPHJKJLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class JHBAKDAIGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long KGEPDHFEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte MDLOEODBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int ILBAGIPPDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JPHBJLCCJEL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x682DDA0", Offset = "0x682C9A0", VA = "0x18682DDA0")]
	private JHBAKDAIGCJ(long GOHHEIOGIPD, byte HKFCAEKDAKJ, int ALLKNKLGLIA, bool JBMLFGOMBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x682DA60", Offset = "0x682C660", VA = "0x18682DA60")]
	public static JHBAKDAIGCJ CDDGIJOMOFM(KCOCAACILCA HAPDOAKGICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x682DBB0", Offset = "0x682C7B0", VA = "0x18682DBB0")]
	public static KCOCAACILCA OMDGLOGJCFJ(long BLFCAJEPLOJ, byte BGCBLDMMIPC, int LODGHKIHPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x682DCA0", Offset = "0x682C8A0", VA = "0x18682DCA0")]
	public static KCOCAACILCA PFDHOIHHALP(ODPDJHNBAHH PGFJLIBKENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FKBAPMAFDHA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NALPIHHCJGO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDCEMKAOIFM(IPEndPoint IHOCCEPKCDI, IPEndPoint FKGGJEKOBPN, string IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAFCMCPCKKO(IPEndPoint DFHOAFCHCNC, FKBAPMAFDHA ADFFEBFOCBD, string IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ABAJEJJDHCD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BOLOFNPGOLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint LAPNDBEIHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint JOAOIPIAADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string MOKNDENEOMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct IOKHKDLOLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint DKPKBHBNBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FKBAPMAFDHA JCIALHFDOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string MOKNDENEOMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class JBDMLHNPJBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint JOGIEOMPNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string MOKNDENEOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JBDMLHNPJBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class KNMPJDLMDHH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint JOGIEOMPNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint OHDGPBGDHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string MOKNDENEOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KNMPJDLMDHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class BBIAJJJPAHP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MOKNDENEOMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HGMJGDJLLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963120", VA = "0x180964520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BBIAJJJPAHP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DNEHOHGCLFO LEDAPGADFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<BOLOFNPGOLF> GKCCGEKHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<IOKHKDLOLEO> GGJGMEPHKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KCLJCFHMMDM DEIDALCEIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GGJGIJKJIEJ LAPBGNJBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AFGDFIJDLKA JGKBOOOIMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NALPIHHCJGO PFDEACCFGOH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int AEBGHLPADOH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool POCLPMCILPE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6821420", Offset = "0x6820020", VA = "0x186821420")]
	internal ABAJEJJDHCD(DNEHOHGCLFO BEEIBIPFIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68212A0", Offset = "0x681FEA0", VA = "0x1868212A0")]
	internal void OHLLDDDJOKE(IPEndPoint BFHMDGHNDNN, KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B70", Offset = "0x3AB8770", VA = "0x183AB9B70")]
	private void KOPACEPOEHO<T>(T HAPDOAKGICK, IPEndPoint EJGAMJDEIEL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6821110", Offset = "0x681FD10", VA = "0x186821110")]
	private void NDCEMKAOIFM(JBDMLHNPJBB MDKOIHNFNDH, IPEndPoint BFHMDGHNDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6820FB0", Offset = "0x681FBB0", VA = "0x186820FB0")]
	private void KLMKJLAPDHC(KNMPJDLMDHH MDKOIHNFNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6820E10", Offset = "0x681FA10", VA = "0x186820E10")]
	private void CKBFNEOHDAL(BBIAJJJPAHP MDKOIHNFNDH, IPEndPoint BFHMDGHNDNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NCMJKIJKFDB : byte
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
public enum KEIHABKBHAA : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HFBCEDLBJGM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] ECCJPJPKJME;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int JAEHCHIKOLG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int GAFAADNGMFM;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BMAKNPNAEMA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6821BF0", Offset = "0x68207F0", VA = "0x186821BF0")]
	public BMAKNPNAEMA(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FNNEEEFHCOB : BMAKNPNAEMA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6821BF0", Offset = "0x68207F0", VA = "0x186821BF0")]
	public FNNEEEFHCOB(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OMPIBMKIIAI
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
public interface HHCIHBNBMCO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKDMELLGEAK(OMPIBMKIIAI MJLAHLDPOLN, string FDHHCKGHMND, params object[] IGPONJDPFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MGNJLECCMDH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static HHCIHBNBMCO JIHDFGDKDKJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object IJMAOLADBFI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6832020", Offset = "0x6830C20", VA = "0x186832020")]
	private static void MAHFMJJMAJL(OMPIBMKIIAI CEBNIGEKGFL, string FDHHCKGHMND, params object[] IGPONJDPFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6831FC0", Offset = "0x6830BC0", VA = "0x186831FC0")]
	internal static void LJLDOINFIOD(string FDHHCKGHMND, params object[] IGPONJDPFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6831F00", Offset = "0x6830B00", VA = "0x186831F00")]
	internal static void APGJBHEJAHE(string FDHHCKGHMND, params object[] IGPONJDPFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6831F60", Offset = "0x6830B60", VA = "0x186831F60")]
	internal static void FELHOEBEEJH(string FDHHCKGHMND, params object[] IGPONJDPFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DFAFCKIPGLF
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EEKOEGJJHLH : KCLJCFHMMDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KCOCAACILCA KCOLNBPPGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DNEHOHGCLFO CFCLOIKPOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIPCDJJABCG KGDEAGFNFBC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x682BC10", Offset = "0x682A810", VA = "0x18682BC10")]
	internal EEKOEGJJHLH(DNEHOHGCLFO JHBOJJACLJB, CIPCDJJABCG LGCDAMLMEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x682BBA0", Offset = "0x682A7A0", VA = "0x18682BBA0")]
	internal void HNNJHBBBGHP(KCOCAACILCA HAPDOAKGICK, int CHGFNLLAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x682BB20", Offset = "0x682A720", VA = "0x18682BB20")]
	internal void HIFPPKPHKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x682BAF0", Offset = "0x682A6F0", VA = "0x18682BAF0")]
	public void BPECLHCKNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CIPCDJJABCG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum APPOFLBINLD
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
	public CIPCDJJABCG CHADECDLCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public APPOFLBINLD JCIALHFDOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ODPDJHNBAHH PDBJNKJFFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint JOAOIPIAADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object POGCKLBMPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int JAKIGOJGLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError IOAGLBJIAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public CDBADPKOKPB HODFPAKGLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public PHAHPAEKIBH GNCJEGPAFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NCMJKIJKFDB JAGOFIMHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte GPILAIPJGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly EEKOEGJJHLH KALBNJAKIHG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6821C00", Offset = "0x6820800", VA = "0x186821C00")]
	public CIPCDJJABCG(DNEHOHGCLFO JHBOJJACLJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DNEHOHGCLFO : IEnumerable<ODPDJHNBAHH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LJKLEMFDAME : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68306A0", Offset = "0x682F2A0", VA = "0x1868306A0", Slot = "4")]
		public bool Equals(IPEndPoint MDFKHKOGFDI, IPEndPoint ELJEANFLEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x633CF40", Offset = "0x633BB40", VA = "0x18633CF40", Slot = "5")]
		public int GetHashCode(IPEndPoint CFMCKCBBBKK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LJKLEMFDAME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct OPNINKNBBLN : IEnumerator<ODPDJHNBAHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly ODPDJHNBAHH MLJAMNHACJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ODPDJHNBAHH IMOCOAKBDDI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ODPDJHNBAHH OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC3FAB0", Offset = "0xC3E6B0", VA = "0x180C3FAB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC3FAB0", Offset = "0xC3E6B0", VA = "0x180C3FAB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x177F6F0", Offset = "0x177E2F0", VA = "0x18177F6F0")]
		public OPNINKNBBLN(ODPDJHNBAHH NKBNDBLIKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6836C40", Offset = "0x6835840", VA = "0x186836C40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6836C90", Offset = "0x6835890", VA = "0x186836C90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread EJCHAPBHIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool KJFGLPIODOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CEAKHIEEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CIPCDJJABCG> HILANACEFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CIPCDJJABCG> BOGAEENDEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CIPCDJJABCG GIFHIMNODBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NPNJAFCDMAN GGHDKGJEIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KMJBODKBOLK CCBDAJMBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KPDMMFFOBGH CIENGIKEJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CADJEJPCKCH IKEIEBLAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, ODPDJHNBAHH> DDKIKOFFMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, PHAHPAEKIBH> JPBAOOJDKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, GKMGDGECCCK> PFLDJAECIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LOADABFLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ODPDJHNBAHH DFAEHPDPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OODJNPFMBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ODPDJHNBAHH> HDKOHHNBKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ODPDJHNBAHH[] KNDAJOGEJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DBIMAAODGAJ OHIIPFJDJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int HAEKPFIBGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> MAMNPFINBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BPAGBFFDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LIFKCNIJGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool FMPDJJCPGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool LPMAAIGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GPLPECGMING;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int LMGPGDJOJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FCFAIHJEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GIDDACDJHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool FAPNKJCEOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool ALEPNOKFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LFGLMCGGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HOPOGJCMFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int IECJKNLGIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool POCLPMCILPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool AFOLPKGDMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MJPHKIDAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool FGBCHJHONDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int KJJEHGAGJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int AOOAIEGDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool ICIACOMCDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly CLFIPNKIGDE JONMGMDKPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool NGFMNLNOFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly ABAJEJJDHCD LGNOPEJMFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LLOEGGMBGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public DFAFCKIPGLF AEGDPGGEPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int EPFAEKPLPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GFJFAJNNDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MLHKJLFMMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool JFNMBLGIIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BGIIBPNHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private KCOCAACILCA DOBBOPPOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int ICAFOLAOJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object HBPACCPGKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KCOCAACILCA HPBKNIHNLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int HHFBJFCKADI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int NOGFEJNHMNL = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int MKKLJLABMFI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CBJLBBCNOJK PEFGLCHODMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private CBJLBBCNOJK KHNNBKMMEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread MBNPKDCJKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NIKLCEPCPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint DICGKLMPDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint BDHMEJMLCKK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] KPDAINJDEEH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] AEGELJGFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<KNGFPIAHDMO, IPEndPoint> GALKPGAKCJG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress HPNBIEGNNHF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool FGDBLHLOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GIGJDFAJFPL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LFOIIIBCPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12D4A80", Offset = "0x12D3680", VA = "0x1812D4A80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12D5A90", Offset = "0x12D4690", VA = "0x1812D5A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LPBPFEKNDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x207C220", Offset = "0x207AE20", VA = "0x18207C220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x207C280", Offset = "0x207AE80", VA = "0x18207C280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte MLOAHEKGEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB0D350", Offset = "0xB0BF50", VA = "0x180B0D350")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LFGIJPBCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68294F0", Offset = "0x68280F0", VA = "0x1868294F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GIFMPHJMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68270D0", Offset = "0x6825CD0", VA = "0x1868270D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68265D0", Offset = "0x68251D0", VA = "0x1868265D0")]
	public void DKNBOMKAJFN(IPEndPoint APJFKIEJHHB, byte[] NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x682A4D0", Offset = "0x68290D0", VA = "0x18682A4D0")]
	public void MKLAEDFDKIP(IPEndPoint APJFKIEJHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x682B1F0", Offset = "0x6829DF0", VA = "0x18682B1F0")]
	private bool OFBEMLOBFFM(IPEndPoint APJFKIEJHHB, [Out] ODPDJHNBAHH PGFJLIBKENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x682AD50", Offset = "0x6829950", VA = "0x18682AD50")]
	private void OAMLGMKDFLI(ODPDJHNBAHH PGFJLIBKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6826D20", Offset = "0x6825920", VA = "0x186826D20")]
	private void FEAKHKHKMBM(ODPDJHNBAHH PGFJLIBKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6828EF0", Offset = "0x6827AF0", VA = "0x186828EF0")]
	private void LBAJFHNBHFC(ODPDJHNBAHH PGFJLIBKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x682B4A0", Offset = "0x682A0A0", VA = "0x18682B4A0")]
	public DNEHOHGCLFO(NPNJAFCDMAN JDLCKFEIKMJ, [Optional] DBIMAAODGAJ FLFJLAELIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6829160", Offset = "0x6827D60", VA = "0x186829160")]
	internal void LEEAMAMKKBJ(ODPDJHNBAHH FEHJEMHENAG, int BKPDKEFKOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6825B50", Offset = "0x6824750", VA = "0x186825B50")]
	internal void CCEAPMELFLC(ODPDJHNBAHH FEHJEMHENAG, object DNAMHCLLGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x682B280", Offset = "0x6829E80", VA = "0x18682B280")]
	internal void PBNLGJKHFDJ(ODPDJHNBAHH PGFJLIBKENA, CDBADPKOKPB NCKCEGPNPKI, SocketError FCMDPNCHPAB, KCOCAACILCA MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6824330", Offset = "0x6822F30", VA = "0x186824330")]
	private void AHEHCBGCHBB(ODPDJHNBAHH PGFJLIBKENA, CDBADPKOKPB NCKCEGPNPKI, SocketError FCMDPNCHPAB, bool NBNIPGNLIMD, byte[] LLDJIJICLJF, int BICIFKAHIKL, int EBDKDADIOBA, KCOCAACILCA MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6829510", Offset = "0x6828110", VA = "0x186829510")]
	private void LLMDGOFPKLB(CIPCDJJABCG.APPOFLBINLD ADFFEBFOCBD, [Optional] ODPDJHNBAHH PGFJLIBKENA, [Optional] IPEndPoint FKGGJEKOBPN, SocketError LNJMPIHLDED = SocketError.Success, int BKPDKEFKOIE = 0, CDBADPKOKPB FELLIEEGFAI = CDBADPKOKPB.ConnectionFailed, [Optional] PHAHPAEKIBH EHNNLLJCACM, NCMJKIJKFDB INONDCBKBCC = NCMJKIJKFDB.Unreliable, byte FANKCALENHI = 0, [Optional] KCOCAACILCA KMFANNBFHLN, [Optional] object DNAMHCLLGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6825380", Offset = "0x6823F80", VA = "0x186825380")]
	private void BNDPJODBOOI(CIPCDJJABCG LGCDAMLMEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6824030", Offset = "0x6822C30", VA = "0x186824030")]
	internal void AAIDDEOAPCA(CIPCDJJABCG LGCDAMLMEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68291B0", Offset = "0x6827DB0", VA = "0x1868291B0")]
	private void LGIBKLKGAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x682AA30", Offset = "0x6829630", VA = "0x18682AA30")]
	private void OAJIIBFNFDC(int JBIFIJBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68274F0", Offset = "0x68260F0", VA = "0x1868274F0")]
	internal ODPDJHNBAHH KDJGABIIHGJ(PHAHPAEKIBH AGFMCIMDGME, byte[] AABLILCALMP, int BICIFKAHIKL, int OKLDJMDCMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68267F0", Offset = "0x68253F0", VA = "0x1868267F0")]
	private int EFLDBIHLHML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6826870", Offset = "0x6825470", VA = "0x186826870")]
	private void EPMJOCMFFDH(IPEndPoint FKGGJEKOBPN, ODPDJHNBAHH FNMKJHHCOFG, KFKPANKIHJE LCFBNKFOLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6827B10", Offset = "0x6826710", VA = "0x186827B10")]
	private void KMNNINFNLCE(KCOCAACILCA HAPDOAKGICK, IPEndPoint FKGGJEKOBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6825F70", Offset = "0x6824B70", VA = "0x186825F70")]
	internal void DAHCGDHIMGF(KCOCAACILCA HAPDOAKGICK, NCMJKIJKFDB OOCIHBFKCMN, byte FANKCALENHI, int CHGFNLLAONI, ODPDJHNBAHH FEHJEMHENAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x682A3C0", Offset = "0x6828FC0", VA = "0x18682A3C0")]
	public bool MEKDGOPFPIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x682A430", Offset = "0x6829030", VA = "0x18682A430")]
	public bool MEKDGOPFPIM(IPAddress HPDLDELGMAD, IPAddress OHKIPCCDCGC, int JCJFNFCDOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x682A450", Offset = "0x6829050", VA = "0x18682A450")]
	public bool MEKDGOPFPIM(int JCJFNFCDOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6824140", Offset = "0x6822D40", VA = "0x186824140")]
	public void AALDPPIDLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6824DF0", Offset = "0x68239F0", VA = "0x186824DF0")]
	public ODPDJHNBAHH BLFICMAANCL(string OLHKKFMKCPE, int JCJFNFCDOLA, string NKANGPLHEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6824ED0", Offset = "0x6823AD0", VA = "0x186824ED0")]
	public ODPDJHNBAHH BLFICMAANCL(string OLHKKFMKCPE, int JCJFNFCDOLA, GGJGIJKJIEJ CGHGBBIEEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6824FB0", Offset = "0x6823BB0", VA = "0x186824FB0")]
	public ODPDJHNBAHH BLFICMAANCL(IPEndPoint EJGAMJDEIEL, GGJGIJKJIEJ CGHGBBIEEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6826D70", Offset = "0x6825970", VA = "0x186826D70")]
	public void FLFLNOAJBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6826D80", Offset = "0x6825980", VA = "0x186826D80")]
	public void FLFLNOAJBKH(bool OPGONLDEJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x682A6E0", Offset = "0x68292E0", VA = "0x18682A6E0")]
	public void MOGELNDGGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x682A620", Offset = "0x6829220", VA = "0x18682A620")]
	public void MOGELNDGGEP(byte[] LLDJIJICLJF, int BICIFKAHIKL, int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6824750", Offset = "0x6823350", VA = "0x186824750")]
	public void AHEHCBGCHBB(ODPDJHNBAHH PGFJLIBKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68242F0", Offset = "0x6822EF0", VA = "0x1868242F0")]
	public void AHEHCBGCHBB(ODPDJHNBAHH PGFJLIBKENA, byte[] LLDJIJICLJF, int BICIFKAHIKL, int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x682B2C0", Offset = "0x6829EC0", VA = "0x18682B2C0", Slot = "4")]
	private IEnumerator<ODPDJHNBAHH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x682B350", Offset = "0x6829F50", VA = "0x18682B350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x682B110", Offset = "0x6829D10", VA = "0x18682B110")]
	private KCOCAACILCA OCBAAIPHJOM(GEAPJEJFNOP JENIGBAOHNC, int FJJGAGKDECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x682B030", Offset = "0x6829C30", VA = "0x18682B030")]
	private KCOCAACILCA OCBAAIPHJOM(GEAPJEJFNOP JENIGBAOHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x682A7F0", Offset = "0x68293F0", VA = "0x18682A7F0")]
	internal KCOCAACILCA NIKMGHDLEAN(int FJJGAGKDECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6827190", Offset = "0x6825D90", VA = "0x186827190")]
	internal void GHNHBFGNAGO(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x682B3E0", Offset = "0x6829FE0", VA = "0x18682B3E0")]
	static DNEHOHGCLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12D4A80", Offset = "0x12D3680", VA = "0x1812D4A80")]
	private bool ALCMCMGHEPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6825E60", Offset = "0x6824A60", VA = "0x186825E60")]
	private void CJCBHNJNFLB(IPEndPoint IAELBMBFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68273F0", Offset = "0x6825FF0", VA = "0x1868273F0")]
	private void KAMINLFAGHI(IPEndPoint IAELBMBFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6829A60", Offset = "0x6828660", VA = "0x186829A60")]
	private bool MDILNNOLPGA(SocketException COMMOGJDAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6825BA0", Offset = "0x68247A0", VA = "0x186825BA0")]
	private void CEAFLCPOKBG(CBJLBBCNOJK BEEIBIPFIFE, EndPoint JIADJPJFGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6826250", Offset = "0x6824E50", VA = "0x186826250")]
	private void DBKAADFIOED(object CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6829C10", Offset = "0x6828810", VA = "0x186829C10")]
	public bool MEKDGOPFPIM(IPAddress HPDLDELGMAD, IPAddress OHKIPCCDCGC, int JCJFNFCDOLA, bool LNGNJCIIBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x682A790", Offset = "0x6829390", VA = "0x18682A790")]
	internal int NBBNJBJCPEF(KCOCAACILCA HAPDOAKGICK, IPEndPoint FKGGJEKOBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6824DB0", Offset = "0x68239B0", VA = "0x186824DB0")]
	internal int AHHLDFJFPJH(KCOCAACILCA HAPDOAKGICK, IPEndPoint FKGGJEKOBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6824790", Offset = "0x6823390", VA = "0x186824790")]
	internal int AHHLDFJFPJH(byte[] KBPDEFFIKOJ, int BICIFKAHIKL, int OKLDJMDCMFC, IPEndPoint FKGGJEKOBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68298F0", Offset = "0x68284F0", VA = "0x1868298F0")]
	internal void LPIOAHGKMLO(bool PDJJOCIOLPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GEAPJEJFNOP : byte
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
internal sealed class KCOCAACILCA
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int ICGCNFLINGE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DFALLLDKMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] GEMNGOBHGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BNJMONPHFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object POGCKLBMPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public KCOCAACILCA CHADECDLCFB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GEAPJEJFNOP OLHNMAONGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x682ECC0", Offset = "0x682D8C0", VA = "0x18682ECC0")]
		get
		{
			return default(GEAPJEJFNOP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x682F000", Offset = "0x682DC00", VA = "0x18682F000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MDLOEODBHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x682F040", Offset = "0x682DC40", VA = "0x18682F040")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x682EF90", Offset = "0x682DB90", VA = "0x18682EF90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LOAAAOINGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x682EAC0", Offset = "0x682D6C0", VA = "0x18682EAC0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x682EA80", Offset = "0x682D680", VA = "0x18682EA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AHNDGNFAFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x682EEF0", Offset = "0x682DAF0", VA = "0x18682EEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PKCILHDKGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x682EF20", Offset = "0x682DB20", VA = "0x18682EF20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x682EFD0", Offset = "0x682DBD0", VA = "0x18682EFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort IOCAPELMKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x682EC20", Offset = "0x682D820", VA = "0x18682EC20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x682EC80", Offset = "0x682D880", VA = "0x18682EC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort EPBLNENHKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x682EE30", Offset = "0x682DA30", VA = "0x18682EE30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x682EDF0", Offset = "0x682D9F0", VA = "0x18682EDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort BEMKFIJIGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x682EE90", Offset = "0x682DA90", VA = "0x18682EE90")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x682EF50", Offset = "0x682DB50", VA = "0x18682EF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x682F070", Offset = "0x682DC70", VA = "0x18682F070")]
	static KCOCAACILCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x682EA50", Offset = "0x682D650", VA = "0x18682EA50")]
	public void BFFNKMKFGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x682F440", Offset = "0x682E040", VA = "0x18682F440")]
	public KCOCAACILCA(int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x682F330", Offset = "0x682DF30", VA = "0x18682F330")]
	public KCOCAACILCA(GEAPJEJFNOP JENIGBAOHNC, int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x682EB20", Offset = "0x682D720", VA = "0x18682EB20")]
	public static int DHOOLAJECGN(GEAPJEJFNOP JENIGBAOHNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x682EB90", Offset = "0x682D790", VA = "0x18682EB90")]
	public int DHOOLAJECGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x682ECF0", Offset = "0x682D8F0", VA = "0x18682ECF0")]
	public bool FGDELHDCCGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum PLMLOAHNCHI : byte
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
internal enum MPILDNPHPLE
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
internal enum MHIEKNBCDDG
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum EMDKOJKKAAM
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ODPDJHNBAHH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class OOEOBPPIGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KCOCAACILCA[] NNCBMDLMFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int LFHNDDHAJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int KPHLNKPBIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte PKCILHDKGKN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OOEOBPPIGIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void KGEEEAIIEBE(ulong DENNGEHJBJA, int JJEPICKNIBJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int NBBCBNHDAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int FPHLFCNOMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int BFIBPMFJBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double DGBEJJHOPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int NBILJAILBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int ALHGBKAOCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int MDIIJAMDBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GGJFEMJONCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int APEHPCMJGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FJCIDPELIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object OLLAMPOGEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal ODPDJHNBAHH NLDAGKEBIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal ODPDJHNBAHH FEMCMLMPIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<KCOCAACILCA> GGPADOCOMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<MEDGENKKHJN> GNIIPKAPPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MEDGENKKHJN[] BMFEDIMHFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int PANLHJMKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int HNJBLDFEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool MAHKGHNJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int ADOIJKHKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int KKKNMOACDAN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DACMPKJGPJL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int AAEKMNLCMOF = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object BBDIIKGBAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PBOGDPBAIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, OOEOBPPIGIJ> JPMKCFEMGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> JLNKDEGDCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KCOCAACILCA FFJHBIEEBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int NNEDFJHLBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int KFIJOLNCFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint NMGENHJHLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int ECKHKHOCFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int LIADDJIBNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long NMIEFHDOPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte EDMCIOIAPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private PLMLOAHNCHI IPKNIFAFDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KCOCAACILCA FEDKKBNPNEE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int JCNGLKGGMFH = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LJLCFABOMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly KCOCAACILCA EPLDOADIECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KCOCAACILCA EHBFLCFEGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KCOCAACILCA LKICMKEKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly KCOCAACILCA IFALIMAFCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KEIHABKBHAA GLAIOCCLAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly DNEHOHGCLFO EKJGHMFOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int BJDOFIJCIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object EFKFONJEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CLFIPNKIGDE JONMGMDKPGH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OLGJCMGPENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA8F240", Offset = "0xA8DE40", VA = "0x180A8F240")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68357D0", Offset = "0x68343D0", VA = "0x1868357D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CDBFLLCIGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79C30", VA = "0x180B7B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PLMLOAHNCHI PODMDIHMMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA43410", Offset = "0xA42010", VA = "0x180A43410")]
		get
		{
			return default(PLMLOAHNCHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KDGLPKFKKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x95A5D0", Offset = "0x9591D0", VA = "0x18095A5D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KOPJEEAFLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x13162C0", Offset = "0x1314EC0", VA = "0x1813162C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1BFD8A0", Offset = "0x1BFC4A0", VA = "0x181BFD8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PPFNLBKJPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6833EC0", Offset = "0x6832AC0", VA = "0x186833EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EEJGDCIIBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x968110", Offset = "0x966D10", VA = "0x180968110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double DHIEPMKECOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x493B8B0", Offset = "0x493A4B0", VA = "0x18493B8B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KGEEEAIIEBE JEOEJDMFEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6835720", Offset = "0x6834320", VA = "0x186835720")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6836280", Offset = "0x6834E80", VA = "0x186836280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6836480", Offset = "0x6835080", VA = "0x186836480")]
	internal ODPDJHNBAHH(DNEHOHGCLFO AAACLFHNGHA, IPEndPoint FKGGJEKOBPN, int HGEMPDBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68354C0", Offset = "0x68340C0", VA = "0x1868354C0")]
	internal void HCBKMAMNDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6836250", Offset = "0x6834E50", VA = "0x186836250")]
	internal void MBBCJCFOPKA(IPEndPoint PGEPGLFONDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68363F0", Offset = "0x6834FF0", VA = "0x1868363F0")]
	internal void PIMAHEDMPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6833BD0", Offset = "0x68327D0", VA = "0x186833BD0")]
	private void DLOLDNGOBCB(int ICABENBMIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68354E0", Offset = "0x68340E0", VA = "0x1868354E0")]
	private void INMHJEFILCE(int KBJANPPLBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6836050", Offset = "0x6834C50", VA = "0x186836050")]
	private MEDGENKKHJN LBGEOGKADBC(byte MGPCONLELFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6836AB0", Offset = "0x68356B0", VA = "0x186836AB0")]
	internal ODPDJHNBAHH(DNEHOHGCLFO AAACLFHNGHA, IPEndPoint FKGGJEKOBPN, int HGEMPDBGGBJ, byte BGCBLDMMIPC, GGJGIJKJIEJ HBONFPBIAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68368D0", Offset = "0x68354D0", VA = "0x1868368D0")]
	internal ODPDJHNBAHH(DNEHOHGCLFO AAACLFHNGHA, PHAHPAEKIBH AGFMCIMDGME, int HGEMPDBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6836200", Offset = "0x6834E00", VA = "0x186836200")]
	internal void LJBICLMJKJJ(KFKPANKIHJE LKIPLOHNPCJ, byte[] LLDJIJICLJF, int BICIFKAHIKL, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6836330", Offset = "0x6834F30", VA = "0x186836330")]
	internal bool NCGGMHODJFN(JHBAKDAIGCJ HAPDOAKGICK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6836020", Offset = "0x6834C20", VA = "0x186836020")]
	public void KOPACEPOEHO(byte[] LLDJIJICLJF, int BICIFKAHIKL, int OKLDJMDCMFC, NCMJKIJKFDB DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6833520", Offset = "0x6832120", VA = "0x186833520")]
	private void BHOKDNLLOBB(byte[] LLDJIJICLJF, int BICIFKAHIKL, int OKLDJMDCMFC, byte FANKCALENHI, NCMJKIJKFDB INONDCBKBCC, object DNAMHCLLGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68350E0", Offset = "0x6833CE0", VA = "0x1868350E0")]
	public void GPPHNGGGGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6835880", Offset = "0x6834480", VA = "0x186835880")]
	internal MHIEKNBCDDG JOPHCNJEIBA(KCOCAACILCA HAPDOAKGICK)
	{
		return default(MHIEKNBCDDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6833CA0", Offset = "0x68328A0", VA = "0x186833CA0")]
	internal void ENOMHAMCLEM(MEDGENKKHJN HKGEDMGHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6834DD0", Offset = "0x68339D0", VA = "0x186834DD0")]
	internal EMDKOJKKAAM GFLLHMGKKCM(byte[] LLDJIJICLJF, int BICIFKAHIKL, int OKLDJMDCMFC, bool NBNIPGNLIMD)
	{
		return default(EMDKOJKKAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68363B0", Offset = "0x6834FB0", VA = "0x1868363B0")]
	private void OCEOFOILDPB(int BAAPPBGMLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6833ED0", Offset = "0x6832AD0", VA = "0x186833ED0")]
	internal void FLMEEHOBPFI(NCMJKIJKFDB OOCIHBFKCMN, KCOCAACILCA NKBNDBLIKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6834870", Offset = "0x6833470", VA = "0x186834870")]
	private void GCEMCKBADEI(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6835130", Offset = "0x6833D30", VA = "0x186835130")]
	private void HALNMKOHPDE(int BLINLOHDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6833D00", Offset = "0x6832900", VA = "0x186833D00")]
	internal MPILDNPHPLE EPMJOCMFFDH(KFKPANKIHJE LCFBNKFOLMJ)
	{
		return default(MPILDNPHPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6832BA0", Offset = "0x68317A0", VA = "0x186832BA0")]
	internal void ABHBAFMACBN(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6833A80", Offset = "0x6832680", VA = "0x186833A80")]
	private void CJFIMPBBMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6835520", Offset = "0x6834120", VA = "0x186835520")]
	internal void JFGNFGPCMPD(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6835960", Offset = "0x6834560", VA = "0x186835960")]
	internal void KAFGFLAKMPI(int BLINLOHDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6833260", Offset = "0x6831E60", VA = "0x186833260")]
	internal void BEPCLLKMFEG(KCOCAACILCA HAPDOAKGICK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CLFIPNKIGDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long BKNLLECIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long ICKGMDAIKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long BGJGAOLCPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long FNCPGNDCOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long JIKKIPCDHAJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long DJOMELEPJML;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long EFFKLLFPJED;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long GGBMBGJMPFB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long HCGBHKOLHIM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long PNGHFJKGCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JMJBLBEAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CADIAFEJBGI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FALLGFOLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6821E00", Offset = "0x6820A00", VA = "0x186821E00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long JHAPAJKCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6821D60", Offset = "0x6820960", VA = "0x186821D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long MBLIIJHDHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6822100", Offset = "0x6820D00", VA = "0x186822100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MMLMNINHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6821F60", Offset = "0x6820B60", VA = "0x186821F60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NAAMPLEAHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6821FE0", Offset = "0x6820BE0", VA = "0x186821FE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long AOEOLBBLHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6821EB0", Offset = "0x6820AB0", VA = "0x186821EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long DKEHMIICENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6821E10", Offset = "0x6820A10", VA = "0x186821E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long NPEJLNAIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6822000", Offset = "0x6820C00", VA = "0x186822000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KEIHABKBHAA DOJKBLPCPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6821FF0", Offset = "0x6820BF0", VA = "0x186821FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double MDNBPKFMMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x68220A0", Offset = "0x6820CA0", VA = "0x1868220A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6821DC0", Offset = "0x68209C0", VA = "0x186821DC0")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6821E50", Offset = "0x6820A50", VA = "0x186821E50")]
	public void FBIEDMNEAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6821D70", Offset = "0x6820970", VA = "0x186821D70")]
	public void DNCGOKFHOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6821D00", Offset = "0x6820900", VA = "0x186821D00")]
	public void AJCIMAFFPNF(long KMGCPIPNFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6822040", Offset = "0x6820C40", VA = "0x186822040")]
	public void MOPAOHPJEAM(long PHIEAKJEIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6821CA0", Offset = "0x68208A0", VA = "0x186821CA0")]
	public void ABGFFHOMPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6821F70", Offset = "0x6820B70", VA = "0x186821F70")]
	public void KNIMCMOGGOJ(long HFNFEKNBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6822110", Offset = "0x6820D10", VA = "0x186822110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6821EC0", Offset = "0x6820AC0", VA = "0x186821EC0")]
	public void GBGGKLDKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public CLFIPNKIGDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IDHDFKDAMMM
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> MCPOALDFLKC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x682D780", Offset = "0x682C380", VA = "0x18682D780")]
	public static IPEndPoint LLBOPFDGJJO(string HEBKPNJMBAO, int JCJFNFCDOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x682D580", Offset = "0x682C180", VA = "0x18682D580")]
	public static IPAddress AGMCJILLFNF(string HEBKPNJMBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x682D4F0", Offset = "0x682C0F0", VA = "0x18682D4F0")]
	public static IPAddress AGMCJILLFNF(string HEBKPNJMBAO, AddressFamily BIABMDLIKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x682D750", Offset = "0x682C350", VA = "0x18682D750")]
	internal static int GJEDJHMFAKN(int KBOJIIFDCKB, int ENLAJEPNFNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x33B1540", Offset = "0x33B0140", VA = "0x1833B1540")]
	internal static T[] EKNFMKIKCCI<T>(int EBDKDADIOBA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DKKHOLJDHEN : MEDGENKKHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KFBDFIDBPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KCOCAACILCA KCOLNBPPGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long MDPLOPLKNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool IPJHHLCPDPF;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x682F6F0", Offset = "0x682E2F0", VA = "0x18682F6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x682F610", Offset = "0x682E210", VA = "0x18682F610")]
		public void HGFFJCPBDPD(KCOCAACILCA HAPDOAKGICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x682F680", Offset = "0x682E280", VA = "0x18682F680")]
		public bool PPFMCKLEHDG(long IIHDKBNFNGO, ODPDJHNBAHH PGFJLIBKENA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x682F630", Offset = "0x682E230", VA = "0x18682F630")]
		public bool NGMONOEHMBH(ODPDJHNBAHH PGFJLIBKENA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly KCOCAACILCA CGPKLBOEEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly KFBDFIDBPFA[] OKOHCJEANKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly KCOCAACILCA[] GHGIONHMLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] NEHDDJNKFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int ELKEFDAAHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int FJDKCDKMJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int IDPOFMKHMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int ALBEJCJJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HGPKOPDBKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly NCMJKIJKFDB MMLAANOOBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool FFKMLFFOPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int MCFAELPMMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte NENPDCKLFMI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6823E60", Offset = "0x6822A60", VA = "0x186823E60")]
	public DKKHOLJDHEN(ODPDJHNBAHH PGFJLIBKENA, bool LHCLDNBKDMN, byte HGEMPDBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68235D0", Offset = "0x68221D0", VA = "0x1868235D0")]
	private void MEMAMLKAOEN(KCOCAACILCA HAPDOAKGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6823990", Offset = "0x6822590", VA = "0x186823990", Slot = "4")]
	protected override bool NLCPEBBNPEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6822F70", Offset = "0x6821B70", VA = "0x186822F70", Slot = "5")]
	public override bool ABHBAFMACBN(KCOCAACILCA HAPDOAKGICK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KJPCLNJKOOK : MEDGENKKHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int DGDMKJNHDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort FJDKCDKMJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool HDIEFNCJELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private KCOCAACILCA OKCDPKEGKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly KCOCAACILCA ADBBPJFEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool DHBKLEJOGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte NENPDCKLFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long ABOPLEJCBFG;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6830400", Offset = "0x682F000", VA = "0x186830400")]
	public KJPCLNJKOOK(ODPDJHNBAHH PGFJLIBKENA, bool PMEEFLAPOMK, byte HGEMPDBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x682FF40", Offset = "0x682EB40", VA = "0x18682FF40", Slot = "4")]
	protected override bool NLCPEBBNPEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x682FC60", Offset = "0x682E860", VA = "0x18682FC60", Slot = "5")]
	public override bool ABHBAFMACBN(KCOCAACILCA HAPDOAKGICK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KDINEJKKOAA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EKIBEDMFOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong MLNCOEOKEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double AEPKIIBEBKJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct CKIIKHJCHEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int JNDMANIDDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float CPOCGBJBCKL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x681F530", Offset = "0x681E130", VA = "0x18681F530")]
	private static void OMFMNCBJJJJ(byte[] IOKDPJEDBMO, int KKHFKGIPICC, ulong LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x682F4B0", Offset = "0x682E0B0", VA = "0x18682F4B0")]
	private static void OMFMNCBJJJJ(byte[] IOKDPJEDBMO, int KKHFKGIPICC, int LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x682F520", Offset = "0x682E120", VA = "0x18682F520")]
	public static void OMFMNCBJJJJ(byte[] IOKDPJEDBMO, int KKHFKGIPICC, short LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x682F560", Offset = "0x682E160", VA = "0x18682F560")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, double MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x682F590", Offset = "0x682E190", VA = "0x18682F590")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x682F520", Offset = "0x682E120", VA = "0x18682F520")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, short MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x682F520", Offset = "0x682E120", VA = "0x18682F520")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, ushort MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x682F4B0", Offset = "0x682E0B0", VA = "0x18682F4B0")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x682F4B0", Offset = "0x682E0B0", VA = "0x18682F4B0")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, uint MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x682F580", Offset = "0x682E180", VA = "0x18682F580")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, long MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x682F580", Offset = "0x682E180", VA = "0x18682F580")]
	public static void PCLIINMFIHB(byte[] FOLLKKLPOMJ, int PKAJCFBDMNB, ulong MPDLOLIOGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KCLJCFHMMDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] GMAMOGJFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int FBILOFNDJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int HMPNPHGOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int OAJFBEHLJOD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] GEMNGOBHGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int IOBDLOFHPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HDAPJAHCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x682DFE0", Offset = "0x682CBE0", VA = "0x18682DFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IENNGHOGMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x243BDE0", Offset = "0x243A9E0", VA = "0x18243BDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LNBBBOMHMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x682DE70", Offset = "0x682CA70", VA = "0x18682DE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x682E500", Offset = "0x682D100", VA = "0x18682E500")]
	public void HNNJHBBBGHP(byte[] BIKFHOMEEFN, int KKHFKGIPICC, int ONKKNGCLBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KCLJCFHMMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x682E9F0", Offset = "0x682D5F0", VA = "0x18682E9F0")]
	public KCLJCFHMMDM(byte[] BIKFHOMEEFN, int KKHFKGIPICC, int ONKKNGCLBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x682E430", Offset = "0x682D030", VA = "0x18682E430")]
	public IPEndPoint HLAOCIBKBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x682E0A0", Offset = "0x682CCA0", VA = "0x18682E0A0")]
	public byte GFOABBJDBNJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x682E0A0", Offset = "0x682CCA0", VA = "0x18682E0A0")]
	public sbyte GFPAIAFNOND()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3431E30", Offset = "0x3430A30", VA = "0x183431E30")]
	public T[] MDFGHPDPHHK<T>(ushort FJJGAGKDECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x682E310", Offset = "0x682CF10", VA = "0x18682E310")]
	public bool[] GLFKLGNJCFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x682E660", Offset = "0x682D260", VA = "0x18682E660")]
	public ushort[] KFFBPHFCKID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x682E060", Offset = "0x682CC60", VA = "0x18682E060")]
	public short[] FJDJPMOPOJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x682DDF0", Offset = "0x682C9F0", VA = "0x18682DDF0")]
	public int[] AKLDINEKCEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x682E7F0", Offset = "0x682D3F0", VA = "0x18682E7F0")]
	public uint[] MBIGAIPFGMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x682DFA0", Offset = "0x682CBA0", VA = "0x18682DFA0")]
	public float[] FFCNFHHAJBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x682DE80", Offset = "0x682CA80", VA = "0x18682DE80")]
	public double[] BJDJDDIDOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x682E870", Offset = "0x682D470", VA = "0x18682E870")]
	public long[] NFLCHDKKEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x682E830", Offset = "0x682D430", VA = "0x18682E830")]
	public ulong[] MNGDCACGOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x682E6A0", Offset = "0x682D2A0", VA = "0x18682E6A0")]
	public string[] LKHOPHHCGAE(int KMIDNGLEPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x682E940", Offset = "0x682D540", VA = "0x18682E940")]
	public bool ONHLBCGKHFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x682DFF0", Offset = "0x682CBF0", VA = "0x18682DFF0")]
	public char LHEAANCCHAC()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x682DFF0", Offset = "0x682CBF0", VA = "0x18682DFF0")]
	public ushort FIMIHLAGMLI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x682E8D0", Offset = "0x682D4D0", VA = "0x18682E8D0")]
	public short OLLOGBPLOCH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x682E3C0", Offset = "0x682CFC0", VA = "0x18682E3C0")]
	public long HIGIEHBOBEI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x682E5B0", Offset = "0x682D1B0", VA = "0x18682E5B0")]
	public ulong JLFIPPFGCDN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x682E350", Offset = "0x682CF50", VA = "0x18682E350")]
	public int HCMHMOAIAPG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x682E980", Offset = "0x682D580", VA = "0x18682E980")]
	public uint OOAKEJNPMIC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x682DEC0", Offset = "0x682CAC0", VA = "0x18682DEC0")]
	public float BKCCPFBKMCD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x682DF30", Offset = "0x682CB30", VA = "0x18682DF30")]
	public double CAEMHOIKDFA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x682E0E0", Offset = "0x682CCE0", VA = "0x18682E0E0")]
	public string GGEGGEGMACJ(int NGOEEBFMFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x682E540", Offset = "0x682D140", VA = "0x18682E540")]
	public ArraySegment<byte> IAGCFPHOEAJ(int EBDKDADIOBA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x682E620", Offset = "0x682D220", VA = "0x18682E620")]
	public sbyte[] KCCONBDNCOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x682DE30", Offset = "0x682CA30", VA = "0x18682DE30")]
	public byte[] BDJJBNPCDEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x682E8B0", Offset = "0x682D4B0", VA = "0x18682E8B0")]
	public void NGMONOEHMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GGJGIJKJIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] GMAMOGJFOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FBILOFNDJHD;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int HDMLBMIFMGO = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool GOLACPKJFLF;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding NGDDKHJOABA;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int GBKDAKNBFEC = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] FGJCJFHDGFD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] JBDHCGELIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FMELMONACEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x682CA20", Offset = "0x682B620", VA = "0x18682CA20")]
	public GGJGIJKJIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x682C980", Offset = "0x682B580", VA = "0x18682C980")]
	public GGJGIJKJIEJ(bool HAFCFGFGBNH, int KLOAGNHKHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x682C190", Offset = "0x682AD90", VA = "0x18682C190")]
	public static GGJGIJKJIEJ IPLKBOJBBNL(string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x682C200", Offset = "0x682AE00", VA = "0x18682C200")]
	public void MJFFBKCCNCF(int JEHKPKCIHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24B4ED0", Offset = "0x24B3AD0", VA = "0x1824B4ED0")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x682C6C0", Offset = "0x682B2C0", VA = "0x18682C6C0")]
	public void OGJNOBJDDNF(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x682C860", Offset = "0x682B460", VA = "0x18682C860")]
	public void OGJNOBJDDNF(double MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x682C8B0", Offset = "0x682B4B0", VA = "0x18682C8B0")]
	public void OGJNOBJDDNF(long MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x682C8B0", Offset = "0x682B4B0", VA = "0x18682C8B0")]
	public void OGJNOBJDDNF(ulong MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x682C7D0", Offset = "0x682B3D0", VA = "0x18682C7D0")]
	public void OGJNOBJDDNF(int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x682C7D0", Offset = "0x682B3D0", VA = "0x18682C7D0")]
	public void OGJNOBJDDNF(uint MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x682C650", Offset = "0x682B250", VA = "0x18682C650")]
	public void OGJNOBJDDNF(char MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x682C650", Offset = "0x682B250", VA = "0x18682C650")]
	public void OGJNOBJDDNF(ushort MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x682C650", Offset = "0x682B250", VA = "0x18682C650")]
	public void OGJNOBJDDNF(short MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x682C2A0", Offset = "0x682AEA0", VA = "0x18682C2A0")]
	public void OGJNOBJDDNF(sbyte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x682C2A0", Offset = "0x682AEA0", VA = "0x18682C2A0")]
	public void OGJNOBJDDNF(byte MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x682C760", Offset = "0x682B360", VA = "0x18682C760")]
	public void OGJNOBJDDNF(byte[] LLDJIJICLJF, int KKHFKGIPICC, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x682BF00", Offset = "0x682AB00", VA = "0x18682BF00")]
	public void FFDJONHKHOC(sbyte[] LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x682BF00", Offset = "0x682AB00", VA = "0x18682BF00")]
	public void OLNKFGKFIDI(byte[] LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x682C3E0", Offset = "0x682AFE0", VA = "0x18682C3E0")]
	public void OGJNOBJDDNF(bool MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x682C0B0", Offset = "0x682ACB0", VA = "0x18682C0B0")]
	public void ABILBHEHCJD(Array PKLIEALEDAO, int GLJHGPGODNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x682BD40", Offset = "0x682A940", VA = "0x18682BD40")]
	public void ABILBHEHCJD(float[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x682BC60", Offset = "0x682A860", VA = "0x18682BC60")]
	public void ABILBHEHCJD(double[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x682BC60", Offset = "0x682A860", VA = "0x18682BC60")]
	public void ABILBHEHCJD(long[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x682BC60", Offset = "0x682A860", VA = "0x18682BC60")]
	public void ABILBHEHCJD(ulong[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x682BD40", Offset = "0x682A940", VA = "0x18682BD40")]
	public void ABILBHEHCJD(int[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x682BD40", Offset = "0x682A940", VA = "0x18682BD40")]
	public void ABILBHEHCJD(uint[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x682BE20", Offset = "0x682AA20", VA = "0x18682BE20")]
	public void ABILBHEHCJD(ushort[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x682BE20", Offset = "0x682AA20", VA = "0x18682BE20")]
	public void ABILBHEHCJD(short[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x682BF00", Offset = "0x682AB00", VA = "0x18682BF00")]
	public void ABILBHEHCJD(bool[] MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x682BFE0", Offset = "0x682ABE0", VA = "0x18682BFE0")]
	public void ABILBHEHCJD(string[] MPDLOLIOGJL, int BCCMEPKIKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x682C300", Offset = "0x682AF00", VA = "0x18682C300")]
	public void OGJNOBJDDNF(IPEndPoint APJFKIEJHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x682C3D0", Offset = "0x682AFD0", VA = "0x18682C3D0")]
	public void OGJNOBJDDNF(string MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x682C440", Offset = "0x682B040", VA = "0x18682C440")]
	public void OGJNOBJDDNF(string MPDLOLIOGJL, int NGOEEBFMFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AFGDFIJDLKA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CIDAHBDIFEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong BJDOFIJCIKK;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2680", Offset = "0x5AB1280", VA = "0x185AB2680")]
		static CIDAHBDIFEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KDLKCKAKAPC(KCLJCFHMMDM KLCLFHDKNAH, object DNAMHCLLGDP);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CDNGEFMLOEB<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AFGDFIJDLKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CDNGEFMLOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5AABCA0", Offset = "0x5AAA8A0", VA = "0x185AABCA0")]
		internal void LGIEOEHBLHB(KCLJCFHMMDM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GCIHOKHHKCF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AFGDFIJDLKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GCIHOKHHKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x44BCF20", Offset = "0x44BBB20", VA = "0x1844BCF20")]
		internal void LGIEOEHBLHB(KCLJCFHMMDM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly ODFOMIGDHKJ FGPAPCJNINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, KDLKCKAKAPC> JFMNCOJFDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly GGJGIJKJIEJ BMPDEOLAEIH;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6821A70", Offset = "0x6820670", VA = "0x186821A70")]
	public AFGDFIJDLKA(int KMIDNGLEPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3166550", Offset = "0x3165150", VA = "0x183166550", Slot = "4")]
	protected virtual ulong NLKLAGANLON<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6821870", Offset = "0x6820470", VA = "0x186821870", Slot = "5")]
	protected virtual KDLKCKAKAPC BDBLFDFGEKE(KCLJCFHMMDM KLCLFHDKNAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBFB0", Offset = "0x3ABABB0", VA = "0x183ABBFB0", Slot = "6")]
	protected virtual void MLPDDLLILGB<T>(GGJGIJKJIEJ DGOPMEPLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68219F0", Offset = "0x68205F0", VA = "0x1868219F0")]
	public void DGJHDICLIPL(KCLJCFHMMDM KLCLFHDKNAH, object DNAMHCLLGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF00", Offset = "0x3ABAB00", VA = "0x183ABBF00")]
	public void DHAOIKNHENB<T>(GGJGIJKJIEJ DGOPMEPLAFF, T HAPDOAKGICK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68219A0", Offset = "0x68205A0", VA = "0x1868219A0")]
	public void CDFDDFIHFGC(KCLJCFHMMDM KLCLFHDKNAH, object DNAMHCLLGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBD40", Offset = "0x3ABA940", VA = "0x183ABBD40")]
	public void BOIOAOBENIP<T>(Action<T> GDPFMHOIPNG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB80", Offset = "0x3ABA780", VA = "0x183ABBB80")]
	public void BOIOAOBENIP<T, TUserData>(Action<T, TUserData> GDPFMHOIPNG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PJJIMNLMNNC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6821BF0", Offset = "0x68207F0", VA = "0x186821BF0")]
	public PJJIMNLMNNC(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GNJFDEOEDGO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x682CBA0", Offset = "0x682B7A0", VA = "0x18682CBA0")]
	public GNJFDEOEDGO(string KBPDEFFIKOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ODFOMIGDHKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum FOJMIIGACNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class ILFBHCLGOND<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public FOJMIIGACNP JCIALHFDOME;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x470ABA0", Offset = "0x47097A0", VA = "0x18470ABA0", Slot = "4")]
		public virtual void HGFFJCPBDPD(MethodInfo ENKKAIIFHAC, MethodInfo IMMNGLMBJHG, FOJMIIGACNP ADFFEBFOCBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KLNDJBMDHFN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LHGFCKBKHGF(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		protected ILFBHCLGOND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class IGIONFPLEGN<TClass, TProperty> : ILFBHCLGOND<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> EENHCNMNOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> OMMFPOONFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> NFBHLBGHLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> HBAPLPNDKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> BFJHMELPIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> OHCDDPICENJ;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x46FAE30", Offset = "0x46F9A30", VA = "0x1846FAE30", Slot = "7")]
		public override void KEDPLCJCENN(TClass HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x46F5470", Offset = "0x46F4070", VA = "0x1846F5470", Slot = "8")]
		public override void EHIOBGPHPFE(TClass HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x46FB8B0", Offset = "0x46FA4B0", VA = "0x1846FB8B0", Slot = "9")]
		public override void KLNDJBMDHFN(TClass HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x46FCA30", Offset = "0x46FB630", VA = "0x1846FCA30", Slot = "10")]
		public override void LHGFCKBKHGF(TClass HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x46F5E10", Offset = "0x46F4A10", VA = "0x1846F5E10")]
		protected TProperty[] HCDDACGGLGL(TClass HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x46F5230", Offset = "0x46F3E30", VA = "0x1846F5230")]
		protected TProperty[] CLCHDLAEBHH(TClass HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x46F87D0", Offset = "0x46F73D0", VA = "0x1846F87D0", Slot = "4")]
		public override void HGFFJCPBDPD(MethodInfo ENKKAIIFHAC, MethodInfo IMMNGLMBJHG, FOJMIIGACNP ADFFEBFOCBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x46FCCD0", Offset = "0x46FB8D0", VA = "0x1846FCCD0")]
		protected IGIONFPLEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class OBOKBIFPFKM<TClass, TProperty> : IGIONFPLEGN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void EBJEDOBEDPK(KCLJCFHMMDM JLCBCLJGOML, [Out] TProperty LBPAHDKIKDP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PBFEKDEPHLN(GGJGIJKJIEJ NMGALFAJFCN, TProperty LBPAHDKIKDP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F510", Offset = "0x4F6E110", VA = "0x184F6F510", Slot = "5")]
		public override void ANJKJKJGEOM(TClass HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F5B0", Offset = "0x4F6E1B0", VA = "0x184F6F5B0", Slot = "6")]
		public override void DHAOIKNHENB(TClass HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F910", Offset = "0x4F6E510", VA = "0x184F6F910", Slot = "7")]
		public override void KEDPLCJCENN(TClass HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F6D0", Offset = "0x4F6E2D0", VA = "0x184F6F6D0", Slot = "8")]
		public override void EHIOBGPHPFE(TClass HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x471FD80", Offset = "0x471E980", VA = "0x18471FD80")]
		protected OBOKBIFPFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class PDFPDOIAGCE<T> : IGIONFPLEGN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x503E1A0", Offset = "0x503CDA0", VA = "0x18503E1A0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC2F0", Offset = "0x3FEAEF0", VA = "0x183FEC2F0", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x503E220", Offset = "0x503CE20", VA = "0x18503E220", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC360", Offset = "0x3FEAF60", VA = "0x183FEC360", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public PDFPDOIAGCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class EMGPIOMCNEH<T> : IGIONFPLEGN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC270", Offset = "0x3FEAE70", VA = "0x183FEC270", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC2F0", Offset = "0x3FEAEF0", VA = "0x183FEC2F0", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC3D0", Offset = "0x3FEAFD0", VA = "0x183FEC3D0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC360", Offset = "0x3FEAF60", VA = "0x183FEC360", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public EMGPIOMCNEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HIKCEHGIEND<T> : IGIONFPLEGN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x462B2D0", Offset = "0x4629ED0", VA = "0x18462B2D0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x462B350", Offset = "0x4629F50", VA = "0x18462B350", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x462B430", Offset = "0x462A030", VA = "0x18462B430", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x462B3C0", Offset = "0x4629FC0", VA = "0x18462B3C0", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public HIKCEHGIEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class BPFCONPCMLI<T> : IGIONFPLEGN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x58631C0", Offset = "0x5861DC0", VA = "0x1858631C0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x462B350", Offset = "0x4629F50", VA = "0x18462B350", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5863240", Offset = "0x5861E40", VA = "0x185863240", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x462B3C0", Offset = "0x4629FC0", VA = "0x18462B3C0", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public BPFCONPCMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GFEMFMCHNCN<T> : IGIONFPLEGN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44C3090", Offset = "0x44C1C90", VA = "0x1844C3090", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44C3110", Offset = "0x44C1D10", VA = "0x1844C3110", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44C31F0", Offset = "0x44C1DF0", VA = "0x1844C31F0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44C3180", Offset = "0x44C1D80", VA = "0x1844C3180", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public GFEMFMCHNCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DAEFLMAKHFI<T> : IGIONFPLEGN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x62E0E10", Offset = "0x62DFA10", VA = "0x1862E0E10", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44C3110", Offset = "0x44C1D10", VA = "0x1844C3110", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x62E0E90", Offset = "0x62DFA90", VA = "0x1862E0E90", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x44C3180", Offset = "0x44C1D80", VA = "0x1844C3180", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public DAEFLMAKHFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AILMDLPGNHJ<T> : IGIONFPLEGN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x466FEE0", Offset = "0x466EAE0", VA = "0x18466FEE0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x466FF60", Offset = "0x466EB60", VA = "0x18466FF60", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4670040", Offset = "0x466EC40", VA = "0x184670040", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x466FFD0", Offset = "0x466EBD0", VA = "0x18466FFD0", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public AILMDLPGNHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class OGOJPGINBPM<T> : IGIONFPLEGN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x466FEE0", Offset = "0x466EAE0", VA = "0x18466FEE0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x466FF60", Offset = "0x466EB60", VA = "0x18466FF60", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B4D0", Offset = "0x4F7A0D0", VA = "0x184F7B4D0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x466FFD0", Offset = "0x466EBD0", VA = "0x18466FFD0", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public OGOJPGINBPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ODGENMKNONE<T> : IGIONFPLEGN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F70A60", Offset = "0x4F6F660", VA = "0x184F70A60", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F70AE0", Offset = "0x4F6F6E0", VA = "0x184F70AE0", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F70B50", Offset = "0x4F6F750", VA = "0x184F70B50", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC360", Offset = "0x3FEAF60", VA = "0x183FEC360", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public ODGENMKNONE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MLHDNFJFKHH<T> : IGIONFPLEGN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4D86180", Offset = "0x4D84D80", VA = "0x184D86180", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4D86200", Offset = "0x4D84E00", VA = "0x184D86200", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D86270", Offset = "0x4D84E70", VA = "0x184D86270", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x44C3180", Offset = "0x44C1D80", VA = "0x1844C3180", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public MLHDNFJFKHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JCKGNMMJCGF<T> : IGIONFPLEGN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x491ABC0", Offset = "0x49197C0", VA = "0x18491ABC0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x491AC40", Offset = "0x4919840", VA = "0x18491AC40", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x491ACB0", Offset = "0x49198B0", VA = "0x18491ACB0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x466FFD0", Offset = "0x466EBD0", VA = "0x18466FFD0", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0660", Offset = "0x3FAF260", VA = "0x183FB0660")]
		public JCKGNMMJCGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PBJCFGDGCGE<T> : OBOKBIFPFKM<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x503A8F0", Offset = "0x50394F0", VA = "0x18503A8F0", Slot = "12")]
		protected override void PBFEKDEPHLN(GGJGIJKJIEJ NMGALFAJFCN, char LBPAHDKIKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x503A8C0", Offset = "0x50394C0", VA = "0x18503A8C0", Slot = "11")]
		protected override void EBJEDOBEDPK(KCLJCFHMMDM JLCBCLJGOML, [Out] char LBPAHDKIKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F81250", Offset = "0x3F7FE50", VA = "0x183F81250")]
		public PBJCFGDGCGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OGDFPCLHOMC<T> : OBOKBIFPFKM<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AE40", Offset = "0x4F79A40", VA = "0x184F7AE40", Slot = "12")]
		protected override void PBFEKDEPHLN(GGJGIJKJIEJ NMGALFAJFCN, IPEndPoint LBPAHDKIKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F7AE00", Offset = "0x4F79A00", VA = "0x184F7AE00", Slot = "11")]
		protected override void EBJEDOBEDPK(KCLJCFHMMDM JLCBCLJGOML, [Out] IPEndPoint LBPAHDKIKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F81250", Offset = "0x3F7FE50", VA = "0x183F81250")]
		public OGDFPCLHOMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CFAOHLKOLNB<T> : IGIONFPLEGN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int LNGBNKOAEFL;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC630", Offset = "0x5AAB230", VA = "0x185AAC630")]
		public CFAOHLKOLNB(int NGOEEBFMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC430", Offset = "0x5AAB030", VA = "0x185AAC430", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC4B0", Offset = "0x5AAB0B0", VA = "0x185AAC4B0", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC5B0", Offset = "0x5AAB1B0", VA = "0x185AAC5B0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC530", Offset = "0x5AAB130", VA = "0x185AAC530", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OLKFPMJNNPC<T> : ILFBHCLGOND<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo OLHNMAONGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type FHFJJAEHPGL;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4F880C0", Offset = "0x4F86CC0", VA = "0x184F880C0")]
		public OLKFPMJNNPC(PropertyInfo JENIGBAOHNC, Type EDPLEDJNHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4F87DD0", Offset = "0x4F869D0", VA = "0x184F87DD0", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4F87E90", Offset = "0x4F86A90", VA = "0x184F87E90", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4F87FA0", Offset = "0x4F86BA0", VA = "0x184F87FA0", Slot = "7")]
		public override void KEDPLCJCENN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4F87F40", Offset = "0x4F86B40", VA = "0x184F87F40", Slot = "8")]
		public override void EHIOBGPHPFE(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4F88000", Offset = "0x4F86C00", VA = "0x184F88000", Slot = "9")]
		public override void KLNDJBMDHFN(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4F88060", Offset = "0x4F86C60", VA = "0x184F88060", Slot = "10")]
		public override void LHGFCKBKHGF(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class NFOPGJIOOCA<T> : OLKFPMJNNPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4498400", Offset = "0x4497000", VA = "0x184498400")]
		public NFOPGJIOOCA(PropertyInfo JENIGBAOHNC, Type EDPLEDJNHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA720", Offset = "0x4DF9320", VA = "0x184DFA720", Slot = "5")]
		public override void ANJKJKJGEOM(T HAINLAEGHPN, KCLJCFHMMDM JLCBCLJGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA7E0", Offset = "0x4DF93E0", VA = "0x184DFA7E0", Slot = "6")]
		public override void DHAOIKNHENB(T HAINLAEGHPN, GGJGIJKJIEJ NMGALFAJFCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MHAPJLFMCDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static MHAPJLFMCDF<T> FFLNCJPMHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly ILFBHCLGOND<T>[] HPJJHLMBCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int LMKDAFCPIMM;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4D49820", Offset = "0x4D48420", VA = "0x184D49820")]
		public MHAPJLFMCDF(List<ILFBHCLGOND<T>> OBAPODCOKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4D49770", Offset = "0x4D48370", VA = "0x184D49770")]
		public void DHAOIKNHENB(T CFMCKCBBBKK, GGJGIJKJIEJ DGOPMEPLAFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4D496C0", Offset = "0x4D482C0", VA = "0x184D496C0")]
		public void ANJKJKJGEOM(T CFMCKCBBBKK, KCLJCFHMMDM KLCLFHDKNAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class EFEBBNINDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ILFBHCLGOND<T> IMOGIGFHIEP<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private GGJGIJKJIEJ HHEGGJENAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int GCJCGIKJCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, EFEBBNINDGK> BECMDGHFBLE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6832B00", Offset = "0x6831700", VA = "0x186832B00")]
	public ODFOMIGDHKJ(int KMIDNGLEPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3547DD0", Offset = "0x35469D0", VA = "0x183547DD0")]
	private MHAPJLFMCDF<T> LOKGDMIGEDH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x316A1A0", Offset = "0x3168DA0", VA = "0x18316A1A0")]
	public void CHOGICNNBDH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3547D30", Offset = "0x3546930", VA = "0x183547D30")]
	public bool KOHMJABOPGF<T>(KCLJCFHMMDM KLCLFHDKNAH, T EJGAMJDEIEL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3547CA0", Offset = "0x35468A0", VA = "0x183547CA0")]
	public void DHDDBDHCOJI<T>(GGJGIJKJIEJ DGOPMEPLAFF, T CFMCKCBBBKK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AAGJPHAMIOK
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime KEKNCJCOPHO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] HMDLABGJBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GGOCNABLJKI AOMLKPOOBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6820790", Offset = "0x681F390", VA = "0x186820790")]
		get
		{
			return default(GGOCNABLJKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EBFEINFMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x681FC40", Offset = "0x681E840", VA = "0x18681FC40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x68209A0", Offset = "0x681F5A0", VA = "0x1868209A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DEGBCOCBBKC PODHPPPDFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68206D0", Offset = "0x681F2D0", VA = "0x1868206D0")]
		get
		{
			return default(DEGBCOCBBKC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x68200F0", Offset = "0x681ECF0", VA = "0x1868200F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MJNBHAECADA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6820700", Offset = "0x681F300", VA = "0x186820700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint JOOAPHMFNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6820070", Offset = "0x681EC70", VA = "0x186820070")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? OKLPDLNMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x681FE70", Offset = "0x681EA70", VA = "0x18681FE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? LBIIOJCHFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6820730", Offset = "0x681F330", VA = "0x186820730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? HMAHOEKLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6820760", Offset = "0x681F360", VA = "0x186820760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x681FEA0", Offset = "0x681EAA0", VA = "0x18681FEA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? NNIILCMKHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC4F4F0", Offset = "0xC4E0F0", VA = "0x180C4F4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6820A40", Offset = "0x681F640", VA = "0x186820A40")]
	public AAGJPHAMIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6820D60", Offset = "0x681F960", VA = "0x186820D60")]
	internal AAGJPHAMIOK(byte[] FOLLKKLPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6820520", Offset = "0x681F120", VA = "0x186820520")]
	public static AAGJPHAMIOK IDHCNPIDJGM(byte[] FOLLKKLPOMJ, DateTime JKPJGEFOKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x681FC70", Offset = "0x681E870", VA = "0x18681FC70")]
	internal void BILMDPAHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x68207C0", Offset = "0x681F3C0", VA = "0x1868207C0")]
	private void NGIDLAKOEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6820250", Offset = "0x681EE50", VA = "0x186820250")]
	private DateTime? FBBOFEIDPPL(int KKHFKGIPICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x681FA70", Offset = "0x681E670", VA = "0x18681FA70")]
	private void AIGDNBOGFHA(int KKHFKGIPICC, DateTime? MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6820450", Offset = "0x681F050", VA = "0x186820450")]
	private ulong HHBNKFGAFDJ(int KKHFKGIPICC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6820190", Offset = "0x681ED90", VA = "0x186820190")]
	private void FAABGEEBCMD(int KKHFKGIPICC, ulong MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6820640", Offset = "0x681F240", VA = "0x186820640")]
	private uint INFPKBIPCAB(int KKHFKGIPICC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x66F21F0", Offset = "0x66F0DF0", VA = "0x1866F21F0")]
	private static uint EOCKKKNKBGL(uint MDFKHKOGFDI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6820130", Offset = "0x681ED30", VA = "0x186820130")]
	private static ulong EOCKKKNKBGL(ulong MDFKHKOGFDI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GGOCNABLJKI
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
public enum DEGBCOCBBKC
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GKMGDGECCCK
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int KJOFCOGLNBC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int EFAKBILKMNL = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int PMMPKKBFHFN = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint AMGCBGFFMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int NFCHNGLHNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int DALPNODGEDK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EFKKMOLBJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x682CAA0", Offset = "0x682B6A0", VA = "0x18682CAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x682CAB0", Offset = "0x682B6B0", VA = "0x18682CAB0")]
	public bool KOPACEPOEHO(CBJLBBCNOJK BEEIBIPFIFE, int MKKLKGKOEPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HLOIIPJKCNM : CBJLBBCNOJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket BEEIBIPFIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly DNEHOHGCLFO AAACLFHNGHA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short GIFMPHJMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x682CE00", Offset = "0x682BA00", VA = "0x18682CE00", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DECJKCNOLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x682CCF0", Offset = "0x682B8F0", VA = "0x18682CCF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint LAPNDBEIHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x682CCD0", Offset = "0x682B8D0", VA = "0x18682CCD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily KNODFBCPCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2A30", Offset = "0x4AE1630", VA = "0x184AE2A30", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x682D440", Offset = "0x682C040", VA = "0x18682D440")]
	public HLOIIPJKCNM(AddressFamily BIABMDLIKCO, DNEHOHGCLFO AAACLFHNGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x682CE80", Offset = "0x682BA80", VA = "0x18682CE80", Slot = "8")]
	public bool JPJPLPHPKGG(IPEndPoint APJFKIEJHHB, DFAFCKIPGLF GKJNEFIKGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x682CE40", Offset = "0x682BA40", VA = "0x18682CE40", Slot = "9")]
	public int IEBAHAKPKIM(byte[] IOKDPJEDBMO, int KKHFKGIPICC, int FJJGAGKDECJ, IPEndPoint FKGGJEKOBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x682CD10", Offset = "0x682B910", VA = "0x18682CD10", Slot = "10")]
	public int GBAOCLOFLJD(byte[] IOKDPJEDBMO, EndPoint AEJECOCEFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x682CE20", Offset = "0x682BA20", VA = "0x18682CE20", Slot = "11")]
	public void ICKGPOGJGNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface CBJLBBCNOJK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short GIFMPHJMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int DECJKCNOLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint LAPNDBEIHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily KNODFBCPCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JPJPLPHPKGG(IPEndPoint APJFKIEJHHB, DFAFCKIPGLF GKJNEFIKGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int IEBAHAKPKIM(byte[] IOKDPJEDBMO, int KKHFKGIPICC, int FJJGAGKDECJ, IPEndPoint FKGGJEKOBPN);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GBAOCLOFLJD(byte[] IOKDPJEDBMO, EndPoint FKGGJEKOBPN);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICKGPOGJGNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct KNGFPIAHDMO : IEquatable<KNGFPIAHDMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long DPBBLIENGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long HCCIKKBOAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long ODKFOMEHALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int DDHBFMNCEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int IMMEOIKCDGH;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x68305B0", Offset = "0x682F1B0", VA = "0x1868305B0")]
	public KNGFPIAHDMO(byte[] OLHKKFMKCPE, int MBNEECIIMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x980AE0", Offset = "0x97F6E0", VA = "0x180980AE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6830570", Offset = "0x682F170", VA = "0x186830570", Slot = "4")]
	public bool Equals(KNGFPIAHDMO PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x68304C0", Offset = "0x682F0C0", VA = "0x1868304C0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JGLEHPGICJJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] BOFIFHBBIBI;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class DBIMAAODGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int LFGIJPBCPMF;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
	protected DBIMAAODGAJ(int MFPALEDALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HGMHADOCNOE(IPEndPoint APJFKIEJHHB, byte[] LLDJIJICLJF, int KKHFKGIPICC, int OKLDJMDCMFC);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PEHKCIAOMKA(IPEndPoint APJFKIEJHHB, byte[] LLDJIJICLJF, int KKHFKGIPICC, int OKLDJMDCMFC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DFKBLJLJALA : DBIMAAODGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] NKANGPLHEGE;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator KEGLACINEGB;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2561080", Offset = "0x255FC80", VA = "0x182561080")]
	public DFKBLJLJALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6822930", Offset = "0x6821530", VA = "0x186822930")]
	public void JJJIPNOBPCI(IPEndPoint APJFKIEJHHB, byte[] NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6822AE0", Offset = "0x68216E0", VA = "0x186822AE0")]
	public void NLMJANPKAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6822470", Offset = "0x6821070", VA = "0x186822470", Slot = "4")]
	public override void HGMHADOCNOE(IPEndPoint APJFKIEJHHB, byte[] LLDJIJICLJF, int KKHFKGIPICC, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6822BC0", Offset = "0x68217C0", VA = "0x186822BC0", Slot = "5")]
	public override void PEHKCIAOMKA(IPEndPoint APJFKIEJHHB, byte[] LLDJIJICLJF, int KKHFKGIPICC, int OKLDJMDCMFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct NDOFOJBIKBL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void LIEPHIMCINM([NoAlias] byte* BOPNCKBPADJ, [NoAlias] byte* NKANGPLHEGE, [NoAlias] byte* JHLHAIOLMCI, int OKLDJMDCMFC);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class IDPLPOEIIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr ICCCMGDKIPA;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr APHDEAJPJBH;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x68371C0", Offset = "0x6835DC0", VA = "0x1868371C0")]
		[BurstDiscard]
		private static void KCLBMBELPOO(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6837070", Offset = "0x6835C70", VA = "0x186837070")]
		private static IntPtr FGMIEGBABNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x68372E0", Offset = "0x6835EE0", VA = "0x1868372E0")]
		public static void NLJOLFNAAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public static void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6836E40", Offset = "0x6835A40", VA = "0x186836E40")]
		public unsafe static void AOKANKCOAFH([NoAlias] byte* BOPNCKBPADJ, [NoAlias] byte* NKANGPLHEGE, [NoAlias] byte* JHLHAIOLMCI, int OKLDJMDCMFC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint NKANGPLHEGE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint JHLHAIOLMCI[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint JGDEJJINPJA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint CGAEDGJPOPC[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint LLAFAGKPCOB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint KGLDMOLCKLM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint INJCGJDJADB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint PIKBHOOACLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint ELCKMKDCOCE[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x68324D0", Offset = "0x68310D0", VA = "0x1868324D0")]
	private void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6832A70", Offset = "0x6831670", VA = "0x186832A70")]
	private uint KIJOFBMPMOG(uint FABNDDIHAPL, int OEHDPDELAEL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x681F930", Offset = "0x681E530", VA = "0x18681F930")]
	private void HFCHJJNPCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x681F620", Offset = "0x681E220", VA = "0x18681F620")]
	private void COKKGPGIAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x681F9E0", Offset = "0x681E5E0", VA = "0x18681F9E0")]
	private void OOAKEGJOGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x681F830", Offset = "0x681E430", VA = "0x18681F830")]
	private void FBDDAKKAKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6832AA0", Offset = "0x68316A0", VA = "0x186832AA0")]
	private void NDHIPPBIOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6832550", Offset = "0x6831150", VA = "0x186832550")]
	private unsafe void HBDNHMAPGKB(byte* BOPNCKBPADJ, uint* NKANGPLHEGE, uint* JHLHAIOLMCI, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6832450", Offset = "0x6831050", VA = "0x186832450")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DKKEIJMKJPO([NoAlias] byte* BOPNCKBPADJ, [NoAlias] byte* NKANGPLHEGE, [NoAlias] byte* JHLHAIOLMCI, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6832370", Offset = "0x6830F70", VA = "0x186832370")]
	public static void DKKEIJMKJPO(Span<byte> BOPNCKBPADJ, Span<byte> NKANGPLHEGE, Span<byte> JHLHAIOLMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6832970", Offset = "0x6831570", VA = "0x186832970")]
	public static void IONCNPHLGNI(Span<byte> BOPNCKBPADJ, Span<byte> NKANGPLHEGE, Span<byte> JHLHAIOLMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6832300", Offset = "0x6830F00", VA = "0x186832300")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BODBBAOGKII([NoAlias] byte* BOPNCKBPADJ, [NoAlias] byte* NKANGPLHEGE, [NoAlias] byte* JHLHAIOLMCI, int OKLDJMDCMFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6837480", Offset = "0x6836080", VA = "0x186837480")]
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
