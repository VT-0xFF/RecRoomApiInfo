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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OBNJBGFNKMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum PEMIFKJCAKL
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
		private NetworkManager FEAAIHBEBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, OHCGKEBIENN> JJGIJLLFCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LMANDBIPEEG OPEPIKJEHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] DAKOKKOMDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PEMIFKJCAKL PHDAIPGDMLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong FOOEJNMADPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MDINIBEPLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5CD0750", Offset = "0x5CCEF50", VA = "0x185CD0750", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFC00", Offset = "0x5CCE400", VA = "0x185CCFC00")]
		public void RecRoom_SetEncryptionInfo(ulong GFECPNLNKPD, byte[] JOEHGGMHBAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFBE0", Offset = "0x5CCE3E0", VA = "0x185CCFBE0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF970", Offset = "0x5CCE170", VA = "0x185CCF970")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0650", Offset = "0x5CCEE50", VA = "0x185CD0650")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFE00", Offset = "0x5CCE600", VA = "0x185CCFE00", Slot = "6")]
		public override void Send(ulong IAHONLPBBCJ, ArraySegment<byte> MLKNGAFFKGE, NetworkDelivery CGANNHEKKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFBA0", Offset = "0x5CCE3A0", VA = "0x185CCFBA0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong IAHONLPBBCJ, [Out] ArraySegment<byte> EMIMPCIEFOP, [Out] float GOCJFKPNFHM)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD00F0", Offset = "0x5CCE8F0", VA = "0x185CD00F0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0570", Offset = "0x5CCED70", VA = "0x185CD0570", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF2E0", Offset = "0x5CCDAE0", VA = "0x185CCF2E0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong IAHONLPBBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF190", Offset = "0x5CCD990", VA = "0x185CCF190", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF450", Offset = "0x5CCDC50", VA = "0x185CCF450", Slot = "12")]
		public override ulong GetCurrentRtt(ulong IAHONLPBBCJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0080", Offset = "0x5CCE880", VA = "0x185CD0080", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF510", Offset = "0x5CCDD10", VA = "0x185CCF510", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FEAAIHBEBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF700", Offset = "0x5CCDF00", VA = "0x185CCF700")]
		private OIDCMAJEMAP KJNCEDJHDKB(NetworkDelivery HKAKMPIMEOA)
		{
			return default(OIDCMAJEMAP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF8B0", Offset = "0x5CCE0B0", VA = "0x185CCF8B0", Slot = "15")]
		private void MOAICFIKPGE(OHCGKEBIENN IEJMPGOKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFA60", Offset = "0x5CCE260", VA = "0x185CCFA60", Slot = "16")]
		private void PJCHIPOODBH(OHCGKEBIENN IEJMPGOKBNN, DAMLJOMOBIO DFPBKJIEMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "17")]
		private void IEDCKJFLMHB(IPEndPoint ELIOKBGDCDJ, SocketError GGHOBMBHGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEF80", Offset = "0x5CCD780", VA = "0x185CCEF80", Slot = "18")]
		private void CPGJMAINKCJ(OHCGKEBIENN IEJMPGOKBNN, FFAJBHBKLIA PJOJHFLPHKO, byte DHOJHCANKMO, OIDCMAJEMAP NICHEHJHEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF7D0", Offset = "0x5CCDFD0", VA = "0x185CCF7D0")]
		private void KOMAGEOAPHL(int GGKCGCGFHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "19")]
		private void DJJFFKJMFNI(IPEndPoint EIAFMACBHBC, FFAJBHBKLIA PJOJHFLPHKO, EIHHLCPIHEB GILPJEDOLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "20")]
		private void LOPOOPECMCB(OHCGKEBIENN IEJMPGOKBNN, int AJFLACEBFAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CCEF20", Offset = "0x5CCD720", VA = "0x185CCEF20", Slot = "21")]
		private void CHPMPNCMDNM(AENNLBEJKPH LOGLBHMJLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF6D0", Offset = "0x5CCDED0", VA = "0x185CCF6D0")]
		private ulong KBCEFFJEJHE(OHCGKEBIENN IEJMPGOKBNN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CCF4F0", Offset = "0x5CCDCF0", VA = "0x185CCF4F0")]
		private static int IDJCMJMALNL(float JCJNKLHAGJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0670", Offset = "0x5CCEE70", VA = "0x185CD0670")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class IGOGIEJIJIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly OHCGKEBIENN IGPHOGJEADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<IGONKJDANIP> NFKLLAIKEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HCHFLMDMHFD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC47A0", Offset = "0x5CC2FA0", VA = "0x185CC47A0")]
	protected IGOGIEJIJIF(OHCGKEBIENN IEJMPGOKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4740", Offset = "0x5CC2F40", VA = "0x185CC4740")]
	public void DOGCCPJIFHF(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CC46C0", Offset = "0x5CC2EC0", VA = "0x185CC46C0")]
	protected void BGNBHABLGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4680", Offset = "0x5CC2E80", VA = "0x185CC4680")]
	public bool ACCBABKBLNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CKKCHHBNMDN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool KDBICOOBFJE(IGONKJDANIP GENHPDPJDMD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum HOGLCJEAKHG
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
public class AENNLBEJKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LMANDBIPEEG JDILEAFNEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LKKGFMIMHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FGIMFBGELLG BAIJNELEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint DGPLLCIIILP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HOGLCJEAKHG PIJAHACDKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86AF00", Offset = "0x869700", VA = "0x18086AF00")]
		[CompilerGenerated]
		get
		{
			return default(HOGLCJEAKHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA84D90", Offset = "0xA83590", VA = "0x180A84D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CC27E0", Offset = "0x5CC0FE0", VA = "0x185CC27E0")]
	internal void DNIALPGBPJH(FGIMFBGELLG APCJFLDEHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2840", Offset = "0x5CC1040", VA = "0x185CC2840")]
	private bool OOEDALHPLJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2870", Offset = "0x5CC1070", VA = "0x185CC2870")]
	internal AENNLBEJKPH(IPEndPoint EIAFMACBHBC, FGIMFBGELLG EMFLKHMMEHN, LMANDBIPEEG FAGDFPGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2780", Offset = "0x5CC0F80", VA = "0x185CC2780")]
	public OHCGKEBIENN CCMDMEDGMOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EIHHLCPIHEB
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DCNEMBJPOOE
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
public struct DAMLJOMOBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DCNEMBJPOOE KMLAADJKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PCDHHLKBOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FFAJBHBKLIA MJCCHDOIEDI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OBNJBGFNKMN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCMPBNGNKK(OHCGKEBIENN IEJMPGOKBNN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIHJBIEMNOE(OHCGKEBIENN IEJMPGOKBNN, DAMLJOMOBIO DFPBKJIEMBB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFDAGOMGHIO(IPEndPoint ELIOKBGDCDJ, SocketError GGHOBMBHGAL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOGGLBIKNKB(OHCGKEBIENN IEJMPGOKBNN, FFAJBHBKLIA PJOJHFLPHKO, byte DHOJHCANKMO, OIDCMAJEMAP NICHEHJHEOL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDELMILCEBH(IPEndPoint EIAFMACBHBC, FFAJBHBKLIA PJOJHFLPHKO, EIHHLCPIHEB GILPJEDOLIL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDNKIJCOCEP(OHCGKEBIENN IEJMPGOKBNN, int AJFLACEBFAA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFLNOEPFEGM(AENNLBEJKPH LOGLBHMJLPF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HHOHJLNIFGN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIAFKEPAMJI(OHCGKEBIENN IEJMPGOKBNN, object OENIOELPLPB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PODKICLCIPM
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEHGBIANMHM(MBFMPBHAKBL GENHPDPJDMD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JBONPJACOEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFEPPBAEDAG(OHCGKEBIENN IEJMPGOKBNN, IPEndPoint POKELLGHIOF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FGIMFBGELLG
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int MGJKGGPILKH = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long HNKLHMANELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EDMPIMNHCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] HAELBACHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KFBANCBEOEK IGFBHOELDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int MFOLBMHHOLP;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3070", Offset = "0x5CC1870", VA = "0x185CC3070")]
	private FGIMFBGELLG(long GMFDEBAOIKP, byte MGKFLHGJKOG, int PHFFNGDOHAF, byte[] IFMADJHCJKH, KFBANCBEOEK MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2DF0", Offset = "0x5CC15F0", VA = "0x185CC2DF0")]
	public static int GJODKOBDAJK(IGONKJDANIP GENHPDPJDMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2E50", Offset = "0x5CC1650", VA = "0x185CC2E50")]
	public static FGIMFBGELLG HMIBFBAKFLL(IGONKJDANIP GENHPDPJDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2C10", Offset = "0x5CC1410", VA = "0x185CC2C10")]
	public static IGONKJDANIP FKHBMHAMJLI(NHMHDECCKKC MIOHMHNBNKP, SocketAddress IINPBFHKMFG, long KFHGLJNLBJL, int PHFFNGDOHAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MIPLIIFONOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long HNKLHMANELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte EDMPIMNHCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int MFOLBMHHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool CIHJFFPCFNA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1E40", Offset = "0x5CD0640", VA = "0x185CD1E40")]
	private MIPLIIFONOC(long GMFDEBAOIKP, byte MGKFLHGJKOG, int AJEOGPMMCLH, bool HEJPKCFFFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1BF0", Offset = "0x5CD03F0", VA = "0x185CD1BF0")]
	public static MIPLIIFONOC HMIBFBAKFLL(IGONKJDANIP GENHPDPJDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1B00", Offset = "0x5CD0300", VA = "0x185CD1B00")]
	public static IGONKJDANIP FKHBMHAMJLI(long KFHGLJNLBJL, byte IBFIILDKKIB, int NLCKBCNNEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1D40", Offset = "0x5CD0540", VA = "0x185CD1D40")]
	public static IGONKJDANIP KKBEBEEDMID(OHCGKEBIENN IEJMPGOKBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NGCHNDMIGAF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JIAKPCNPICH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIPOBLODKMJ(IPEndPoint DJEKFALIGKH, IPEndPoint EIAFMACBHBC, string OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKCMBHPIMGK(IPEndPoint MEELJJNJJCC, NGCHNDMIGAF HKAKMPIMEOA, string OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MONLGKBEPNE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KCDLICODBIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HMIODBDDING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint DGPLLCIIILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string KMHMOFNNKFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct EDHIFMDADDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint NJHAOEMHOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NGCHNDMIGAF LBCGEBEPPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string KMHMOFNNKFG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class HCEFIHNPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EMPDFCPBJKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string KMHMOFNNKFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HCEFIHNPEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class FPMBNHPFMKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EMPDFCPBJKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint FONKJKEPMIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string KMHMOFNNKFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FPMBNHPFMKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class JJDBLHFGPGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KMHMOFNNKFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JOHGEIJEPKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84DAC0", Offset = "0x84C2C0", VA = "0x18084DAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JJDBLHFGPGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LMANDBIPEEG CMIIOKFPCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<KCDLICODBIC> JFHHNDAIEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<EDHIFMDADDH> BAOAPKAMNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KFBANCBEOEK HJIPPPFCMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NHMHDECCKKC BCDHEAEIEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KFNLHMBJLPH NNNCKPECNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private JIAKPCNPICH DLGKCEKFFEE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int HKABPHEGDGO = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool NIOHONEELOB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2480", Offset = "0x5CD0C80", VA = "0x185CD2480")]
	internal MONLGKBEPNE(LMANDBIPEEG EAGGHHCNHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD21C0", Offset = "0x5CD09C0", VA = "0x185CD21C0")]
	internal void IBPPGBFBILL(IPEndPoint IJGHCIJBGCB, IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B72F50", Offset = "0x2B71750", VA = "0x182B72F50")]
	private void ADGFAOFDKAI<T>(T GENHPDPJDMD, IPEndPoint LFFBLPMMGND) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1E90", Offset = "0x5CD0690", VA = "0x185CD1E90")]
	private void AIPOBLODKMJ(HCEFIHNPEGN JPODJCACHCC, IPEndPoint IJGHCIJBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2320", Offset = "0x5CD0B20", VA = "0x185CD2320")]
	private void PHKKBNKEPEE(FPMBNHPFMKN JPODJCACHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2020", Offset = "0x5CD0820", VA = "0x185CD2020")]
	private void GKBIFGAEGGM(JJDBLHFGPGP JPODJCACHCC, IPEndPoint IJGHCIJBGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OIDCMAJEMAP : byte
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
public enum DHLPDKGAMBC : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FPJJDPIIGBP
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] JOAAHLDHPII;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int OIACALKCAIE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HJJDACGMBAB;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KGKADIONNEL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CC29F0", Offset = "0x5CC11F0", VA = "0x185CC29F0")]
	public KGKADIONNEL(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KNLKLKEIHBF : KGKADIONNEL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CC29F0", Offset = "0x5CC11F0", VA = "0x185CC29F0")]
	public KNLKLKEIHBF(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LPAGCIHPPHE
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
public interface BAJCBCBOCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBNGPGODPCG(LPAGCIHPPHE KPGPHGOAFPC, string KKDAHIDPNBA, params object[] EKJLJLJONBC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class IPHFJOIOKIP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static BAJCBCBOCFG GMGCPGCHIEF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object JEJEKFAGPNP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5360", Offset = "0x5CC3B60", VA = "0x185CC5360")]
	private static void IKLBDMNAPDE(LPAGCIHPPHE CGFMLBIKLGA, string KKDAHIDPNBA, params object[] EKJLJLJONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CC52A0", Offset = "0x5CC3AA0", VA = "0x185CC52A0")]
	internal static void AHJFGODCGDN(string KKDAHIDPNBA, params object[] EKJLJLJONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5300", Offset = "0x5CC3B00", VA = "0x185CC5300")]
	internal static void GLFPIMNHJEC(string KKDAHIDPNBA, params object[] EKJLJLJONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5580", Offset = "0x5CC3D80", VA = "0x185CC5580")]
	internal static void JCFJEOFEPBF(string KKDAHIDPNBA, params object[] EKJLJLJONBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IBCHHCJJMBO
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FFAJBHBKLIA : KFBANCBEOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private IGONKJDANIP ENGHNGFNKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LMANDBIPEEG IAFGOFNKDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JEJEHLOMIAB FPPAJNHJIPM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2BC0", Offset = "0x5CC13C0", VA = "0x185CC2BC0")]
	internal FFAJBHBKLIA(LMANDBIPEEG KOFDOJONBID, JEJEHLOMIAB KIHHPPMFIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2B50", Offset = "0x5CC1350", VA = "0x185CC2B50")]
	internal void LMAGBJHNIJF(IGONKJDANIP GENHPDPJDMD, int JMDEHOKAMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2AD0", Offset = "0x5CC12D0", VA = "0x185CC2AD0")]
	internal void JPHALLDNGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2AA0", Offset = "0x5CC12A0", VA = "0x185CC2AA0")]
	public void CGCJPOCHDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JEJEHLOMIAB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FAIMFFGFKAA
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
	public JEJEHLOMIAB AOCMNLBJEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public FAIMFFGFKAA LBCGEBEPPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public OHCGKEBIENN IGPHOGJEADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint DGPLLCIIILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object LBAOGDHEMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int PCEDNIAMDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JBDCGEMOCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DCNEMBJPOOE IOEGEPJDCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public AENNLBEJKPH ADECGILHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public OIDCMAJEMAP KBNDALEEDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte BCCAFKBBIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly FFAJBHBKLIA FHHHHODMOEA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5690", Offset = "0x5CC3E90", VA = "0x185CC5690")]
	public JEJEHLOMIAB(LMANDBIPEEG KOFDOJONBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LMANDBIPEEG : IEnumerable<OHCGKEBIENN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class AFEPIAGDNCF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CC28E0", Offset = "0x5CC10E0", VA = "0x185CC28E0", Slot = "4")]
		public bool Equals(IPEndPoint PNGIKMLKECD, IPEndPoint MADKMAGKKBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57C0720", Offset = "0x57BEF20", VA = "0x1857C0720", Slot = "5")]
		public int GetHashCode(IPEndPoint GHDJADLHPAA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AFEPIAGDNCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct AMMHIKHDLMI : IEnumerator<OHCGKEBIENN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly OHCGKEBIENN HKFKFGGDKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private OHCGKEBIENN LHDHNGAOLJE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OHCGKEBIENN APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B78C0", VA = "0x1808B90C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B78C0", VA = "0x1808B90C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1089C30", Offset = "0x1088430", VA = "0x181089C30")]
		public AMMHIKHDLMI(OHCGKEBIENN IGEIIMLGHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2950", Offset = "0x5CC1150", VA = "0x185CC2950", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC29A0", Offset = "0x5CC11A0", VA = "0x185CC29A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread GOGCHENDFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool IPGJLJOJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent LECPCHJKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JEJEHLOMIAB> KONMJBBKHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JEJEHLOMIAB> PIILLDKBBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JEJEHLOMIAB PMMNCDLIHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OBNJBGFNKMN HJCLNJONJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HHOHJLNIFGN NPMCELJKFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PODKICLCIPM NNKGAOBIBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JBONPJACOEJ HFCBMAIMANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, OHCGKEBIENN> ENGJIEDCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, AENNLBEJKPH> GGOHANEKHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, NFBJDHGPIIL> PMPPEECOAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim FKJECAJELKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private OHCGKEBIENN NAMBLOEFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int DOKAGOACHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<OHCGKEBIENN> EEGCOILANOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private OHCGKEBIENN[] KAKKHFBOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly OHFBMBCOPHG BBACLFHDBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int EGKHLJCBALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> GEDMIGEKKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte EBPDBPBOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object CNICKJAGJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool EMICFBEOMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool INDFKDAEAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DLFDBCJDGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int BAAMMHACIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int KHEEMAJANJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HPECHAOMDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool KNPLBEFFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NHGFAKFPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NCNJIGGEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CMPLKFNDCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GPGDEPNCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool NIOHONEELOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool CJBGLCBBDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ANNJKBGLOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KMCPAONNMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EBCKOMGHKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int ADBPEBAFLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool NALCGEBGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KCMCDBFHKJI KHFMOLCMALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KOKDMHJHCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly MONLGKBEPNE JFIFOKELOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool JLCGEOIGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public IBCHHCJJMBO NMOKOJFFEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int MGAJFJNDEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool EPNIMDOOBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GACOLPLPEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GOANINGIANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool GINMOMLJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IGONKJDANIP DOCLPCAGHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int AMGPCMBDAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object OPOJCAKHCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IGONKJDANIP NPBJJMNBBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KIGCJNEENPA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int EHEEEJLCNGH = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int AACONMCJKFI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BOGCLMPJCBA GLNAJEPBNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BOGCLMPJCBA JPJLPBBDFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread KHKGKKPJKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread EFHGDAMKGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ODNGIJCDEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint KIJPKDKOACP;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] LJIMJFKANCG;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] KFGJFLALLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NJKLAIEHJOP, IPEndPoint> BBMLEPDNNMB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress GGFIGODIHMN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool EIMGJMHJLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int KMMDMKBAFEO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GOIMIFGEBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB91FF0", Offset = "0xB907F0", VA = "0x180B91FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC408A0", Offset = "0xC3F0A0", VA = "0x180C408A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MFGJODKFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14812D0", Offset = "0x147FAD0", VA = "0x1814812D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17A6DF0", Offset = "0x17A55F0", VA = "0x1817A6DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NJAJPLANNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DD720", Offset = "0x9DBF20", VA = "0x1809DD720")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CHELPLBFBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CCADB0", Offset = "0x5CC95B0", VA = "0x185CCADB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short CINGOBNBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB210", Offset = "0x5CC9A10", VA = "0x185CCB210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8460", Offset = "0x5CC6C60", VA = "0x185CC8460")]
	public void BDJKFJBNHJA(IPEndPoint ELIOKBGDCDJ, byte[] JOEHGGMHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAF20", Offset = "0x5CC9720", VA = "0x185CCAF20")]
	public void IJGGFOGAHOL(IPEndPoint ELIOKBGDCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CC89E0", Offset = "0x5CC71E0", VA = "0x185CC89E0")]
	private bool EEPMGDANLKC(IPEndPoint ELIOKBGDCDJ, [Out] OHCGKEBIENN IEJMPGOKBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC610", Offset = "0x5CCAE10", VA = "0x185CCC610")]
	private void MCKJOLHDEDE(OHCGKEBIENN IEJMPGOKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAED0", Offset = "0x5CC96D0", VA = "0x185CCAED0")]
	private void HNJBOHHFCGB(OHCGKEBIENN IEJMPGOKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8210", Offset = "0x5CC6A10", VA = "0x185CC8210")]
	private void AMACLABBJOK(OHCGKEBIENN IEJMPGOKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE8D0", Offset = "0x5CCD0D0", VA = "0x185CCE8D0")]
	public LMANDBIPEEG(OBNJBGFNKMN FAGDFPGILCF, [Optional] OHFBMBCOPHG HCOOOFJNLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDAC0", Offset = "0x5CCC2C0", VA = "0x185CCDAC0")]
	internal void OLBGHBBIKMK(OHCGKEBIENN MDPGAKECJGM, int AJFLACEBFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8500", Offset = "0x5CC6D00", VA = "0x185CC8500")]
	internal void BJKABHAKPKD(OHCGKEBIENN MDPGAKECJGM, object OENIOELPLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDD60", Offset = "0x5CCC560", VA = "0x185CCDD60")]
	internal void PMIGADLNDHE(OHCGKEBIENN IEJMPGOKBNN, DCNEMBJPOOE DAGAMHLIEBK, SocketError BAOHFMGAOFD, IGONKJDANIP BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDBD0", Offset = "0x5CCC3D0", VA = "0x185CCDBD0")]
	private void PKNGFGFOKDD(OHCGKEBIENN IEJMPGOKBNN, DCNEMBJPOOE DAGAMHLIEBK, SocketError BAOHFMGAOFD, bool AIDFLNGPPBP, byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int POAAACAIHKJ, IGONKJDANIP BNEKFHGOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB790", Offset = "0x5CC9F90", VA = "0x185CCB790")]
	private void LBEAMBNOGLE(JEJEHLOMIAB.FAIMFFGFKAA HKAKMPIMEOA, [Optional] OHCGKEBIENN IEJMPGOKBNN, [Optional] IPEndPoint EIAFMACBHBC, SocketError FOBCBIEDHCL = SocketError.Success, int AJFLACEBFAA = 0, DCNEMBJPOOE JHIFEHHEMAA = DCNEMBJPOOE.ConnectionFailed, [Optional] AENNLBEJKPH IGANABINCBF, OIDCMAJEMAP NICHEHJHEOL = OIDCMAJEMAP.Unreliable, byte DHOJHCANKMO = 0, [Optional] IGONKJDANIP KOEEGPCENCG, [Optional] object OENIOELPLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBC30", Offset = "0x5CCA430", VA = "0x185CCBC30")]
	private void LIKINHNKPIE(JEJEHLOMIAB KIHHPPMFIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CCADD0", Offset = "0x5CC95D0", VA = "0x185CCADD0")]
	internal void HLIHDHKKDFJ(JEJEHLOMIAB KIHHPPMFIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8C10", Offset = "0x5CC7410", VA = "0x185CC8C10")]
	private void EJOKHGNBHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8550", Offset = "0x5CC6D50", VA = "0x185CC8550")]
	private void CKHCILJHBDH(int ELBIDKLAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCEE0", Offset = "0x5CCB6E0", VA = "0x185CCCEE0")]
	internal OHCGKEBIENN NKECFPOPBGE(AENNLBEJKPH LOGLBHMJLPF, byte[] PIMIOIGPGKK, int CKMEAPHLBGJ, int IDGMEKAEIMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC8D0", Offset = "0x5CCB0D0", VA = "0x185CCC8D0")]
	private int MNFAJBBNKCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB2D0", Offset = "0x5CC9AD0", VA = "0x185CCB2D0")]
	private void IOPEBINOLEM(IPEndPoint EIAFMACBHBC, OHCGKEBIENN BDFDPODAKEG, FGIMFBGELLG KIIFGOKDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8F50", Offset = "0x5CC7750", VA = "0x185CC8F50")]
	private void EKJNLACFOFO(IGONKJDANIP GENHPDPJDMD, IPEndPoint EIAFMACBHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7F50", Offset = "0x5CC6750", VA = "0x185CC7F50")]
	internal void AIGDEOCACAH(IGONKJDANIP GENHPDPJDMD, OIDCMAJEMAP KLGJKLPJJAN, byte DHOJHCANKMO, int JMDEHOKAMJL, OHCGKEBIENN MDPGAKECJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDED0", Offset = "0x5CCC6D0", VA = "0x185CCDED0")]
	public bool PPJONGAFJGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDE30", Offset = "0x5CCC630", VA = "0x185CCDE30")]
	public bool PPJONGAFJGD(IPAddress BOCPGOOBDDN, IPAddress AOHIOIFMEKM, int MEOPEAGBICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDE50", Offset = "0x5CCC650", VA = "0x185CCDE50")]
	public bool PPJONGAFJGD(int MEOPEAGBICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8A70", Offset = "0x5CC7270", VA = "0x185CC8A70")]
	public void EGEOJOEDMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCE00", Offset = "0x5CCB600", VA = "0x185CCCE00")]
	public OHCGKEBIENN NHGBKKDCAPJ(string DPKBONFELAE, int MEOPEAGBICP, string JOEHGGMHBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC950", Offset = "0x5CCB150", VA = "0x185CCC950")]
	public OHCGKEBIENN NHGBKKDCAPJ(string DPKBONFELAE, int MEOPEAGBICP, NHMHDECCKKC DOCGKKCBKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCCA30", Offset = "0x5CCB230", VA = "0x185CCCA30")]
	public OHCGKEBIENN NHGBKKDCAPJ(IPEndPoint LFFBLPMMGND, NHMHDECCKKC DOCGKKCBKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAAD0", Offset = "0x5CC92D0", VA = "0x185CCAAD0")]
	public void GPKNLNKGLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA780", Offset = "0x5CC8F80", VA = "0x185CCA780")]
	public void GPKNLNKGLCO(bool GPADDCDOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC3F0", Offset = "0x5CCABF0", VA = "0x185CCC3F0")]
	public void LOHPMPFCLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC4F0", Offset = "0x5CCACF0", VA = "0x185CCC4F0")]
	public void LOHPMPFCLLF(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int POAAACAIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDCB0", Offset = "0x5CCC4B0", VA = "0x185CCDCB0")]
	public void PKNGFGFOKDD(OHCGKEBIENN IEJMPGOKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDB10", Offset = "0x5CCC310", VA = "0x185CCDB10")]
	public void PKNGFGFOKDD(OHCGKEBIENN IEJMPGOKBNN, byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int POAAACAIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE6F0", Offset = "0x5CCCEF0", VA = "0x185CCE6F0", Slot = "4")]
	private IEnumerator<OHCGKEBIENN> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE780", Offset = "0x5CCCF80", VA = "0x185CCE780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9D80", Offset = "0x5CC8580", VA = "0x185CC9D80")]
	private IGONKJDANIP FEMDPDLENMP(HKHGPAIIGAL ABBFPCPEMEH, int GGKCGCGFHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9CA0", Offset = "0x5CC84A0", VA = "0x185CC9CA0")]
	private IGONKJDANIP FEMDPDLENMP(HKHGPAIIGAL ABBFPCPEMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9F50", Offset = "0x5CC8750", VA = "0x185CC9F50")]
	internal IGONKJDANIP GADFPILJJNP(int GGKCGCGFHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD870", Offset = "0x5CCC070", VA = "0x185CCD870")]
	internal void OABLKADFPHF(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE810", Offset = "0x5CCD010", VA = "0x185CCE810")]
	static LMANDBIPEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xB91FF0", Offset = "0xB907F0", VA = "0x180B91FF0")]
	private bool PDCENHLCBFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9E60", Offset = "0x5CC8660", VA = "0x185CC9E60")]
	private void FKPKEJKKNGA(IPEndPoint AGEOMHJAKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBB50", Offset = "0x5CCA350", VA = "0x185CCBB50")]
	private void LHDEHAGENHL(IPEndPoint AGEOMHJAKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB070", Offset = "0x5CC9870", VA = "0x185CCB070")]
	private bool ILDHBPDELMG(SocketException BCGGAGLBPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAAE0", Offset = "0x5CC92E0", VA = "0x185CCAAE0")]
	private void HEMPJNMLNJC(BOGCLMPJCBA EAGGHHCNHNH, EndPoint MDIIGHMNIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD4F0", Offset = "0x5CCBCF0", VA = "0x185CCD4F0")]
	private void NNOJAOCKPCJ(object DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDF40", Offset = "0x5CCC740", VA = "0x185CCDF40")]
	public bool PPJONGAFJGD(IPAddress BOCPGOOBDDN, IPAddress AOHIOIFMEKM, int MEOPEAGBICP, bool ODCEMEHGOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB730", Offset = "0x5CC9F30", VA = "0x185CCB730")]
	internal int KFMLDHPPOEA(IGONKJDANIP GENHPDPJDMD, IPEndPoint EIAFMACBHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA180", Offset = "0x5CC8980", VA = "0x185CCA180")]
	internal int GMOKJABPIHB(IGONKJDANIP GENHPDPJDMD, IPEndPoint EIAFMACBHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA1C0", Offset = "0x5CC89C0", VA = "0x185CCA1C0")]
	internal int GMOKJABPIHB(byte[] CLBGCJICGJG, int CKMEAPHLBGJ, int IDGMEKAEIMD, IPEndPoint EIAFMACBHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8870", Offset = "0x5CC7070", VA = "0x185CC8870")]
	internal void COBFDNLBOJK(bool HNJKNMNMDHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum HKHGPAIIGAL : byte
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
internal sealed class IGONKJDANIP
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int GLHHEGKCGHH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] JIOEMFKLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] OECNLFHKLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int JAFNMFMLFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object LBAOGDHEMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public IGONKJDANIP AOCMNLBJEJA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public HKHGPAIIGAL ILFOMNGOANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4A20", Offset = "0x5CC3220", VA = "0x185CC4A20")]
		get
		{
			return default(HKHGPAIIGAL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CC49A0", Offset = "0x5CC31A0", VA = "0x185CC49A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte EDMPIMNHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4DB0", Offset = "0x5CC35B0", VA = "0x185CC4DB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC49E0", Offset = "0x5CC31E0", VA = "0x185CC49E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort BMDNBGNCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4C60", Offset = "0x5CC3460", VA = "0x185CC4C60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4AC0", Offset = "0x5CC32C0", VA = "0x185CC4AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GJIGLECOLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4CC0", Offset = "0x5CC34C0", VA = "0x185CC4CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte OAAHHLCEMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4A50", Offset = "0x5CC3250", VA = "0x185CC4A50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4B30", Offset = "0x5CC3330", VA = "0x185CC4B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GHLKDBAEONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4940", Offset = "0x5CC3140", VA = "0x185CC4940")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4E20", Offset = "0x5CC3620", VA = "0x185CC4E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort KOMJCPEFLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4D50", Offset = "0x5CC3550", VA = "0x185CC4D50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4A80", Offset = "0x5CC3280", VA = "0x185CC4A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DPAHDEFKKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4CF0", Offset = "0x5CC34F0", VA = "0x185CC4CF0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4DE0", Offset = "0x5CC35E0", VA = "0x185CC4DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4E60", Offset = "0x5CC3660", VA = "0x185CC4E60")]
	static IGONKJDANIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4B00", Offset = "0x5CC3300", VA = "0x185CC4B00")]
	public void JDEJKFJMAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5120", Offset = "0x5CC3920", VA = "0x185CC5120")]
	public IGONKJDANIP(int GGKCGCGFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5190", Offset = "0x5CC3990", VA = "0x185CC5190")]
	public IGONKJDANIP(HKHGPAIIGAL ABBFPCPEMEH, int GGKCGCGFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4B60", Offset = "0x5CC3360", VA = "0x185CC4B60")]
	public static int JHOGJKCHIFG(HKHGPAIIGAL ABBFPCPEMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4BD0", Offset = "0x5CC33D0", VA = "0x185CC4BD0")]
	public int JHOGJKCHIFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4840", Offset = "0x5CC3040", VA = "0x185CC4840")]
	public bool AABCPFCCIDH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum ACFOMCHEGFJ : byte
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
internal enum BMECPMBOOBC
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
internal enum PCCFGGDCKDN
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OHAAFDMPGBL
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class OHCGKEBIENN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class IBGFFCAMPPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public IGONKJDANIP[] HHLAMPENGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int DLFAKEAEOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int ENEPIOMPIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte OAAHHLCEMIA;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public IBGFFCAMPPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void NHOILMFLLBM(ulong LMHOKPJDMMI, int EPAFNMDMECA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int JGGGIKPFFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int GKOMLOLDHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OJJPLHNDHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double NGILHBOMAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int HIKLJOALEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int HCCLHBNIJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int HMDAEHFAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch DEJJGABMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int OKCJAFMOPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PMJKOLDDDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object NJCNECHPAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal OHCGKEBIENN HCGBJCNAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal OHCGKEBIENN PAPEMJBMAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<IGONKJDANIP> GGIOIJJMNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<IGOGIEJIJIF> AJCBCDFHCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly IGOGIEJIJIF[] PGOGIAMBOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int DEGGJDHHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int CPPPDNCJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool EMPGOMMGEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int IJNKCAMLNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int GGDJHKFPILG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int JANPOAFHBEJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int JOAHELKAEOP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object EBGAHOKJJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int ACMIEJLEEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, IBGFFCAMPPE> ENNOAEHHHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> GNBJDNNKKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly IGONKJDANIP NJNBCKJKEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HCAEODPDLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int BGBEFHLFEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint JIJKKOJLIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int BFLAFGNBJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NIFNJOFOFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long PPDBPBMONNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte GKBJEOEHNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private ACFOMCHEGFJ FPBFIKNCBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IGONKJDANIP BABLMNAJJFA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int COLEDKIMPHH = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IDMBCECLHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly IGONKJDANIP IBIMANBDGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly IGONKJDANIP EOHLFNNNNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly IGONKJDANIP IKMDMPFNILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly IGONKJDANIP GIDLFCINMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DHLPDKGAMBC MFKOJONFLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LMANDBIPEEG JLKKFEEIPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int ACEJJAKLDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object AMMIMINBIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KCMCDBFHKJI KHFMOLCMALI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FCJIIIKOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBD5070", Offset = "0xBD3870", VA = "0x180BD5070")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD63B0", Offset = "0x5CD4BB0", VA = "0x185CD63B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint JCBMMADLPPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B3D90", Offset = "0x8B2590", VA = "0x1808B3D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ACFOMCHEGFJ EIPKEGADEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x12BABC0", Offset = "0x12B93C0", VA = "0x1812BABC0")]
		get
		{
			return default(ACFOMCHEGFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long ALBICEBOIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x849960", Offset = "0x848160", VA = "0x180849960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PBFCIHMPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xC84B10", Offset = "0xC83310", VA = "0x180C84B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1585C20", Offset = "0x1584420", VA = "0x181585C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HGDHHNJEFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6B20", Offset = "0x5CD5320", VA = "0x185CD6B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DLDCNCAIPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double FIAIMPOEOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A07570", Offset = "0x1A05D70", VA = "0x181A07570")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NHOILMFLLBM NKGPLJOHCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3A60", Offset = "0x5CD2260", VA = "0x185CD3A60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD71C0", Offset = "0x5CD59C0", VA = "0x185CD71C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7400", Offset = "0x5CD5C00", VA = "0x185CD7400")]
	internal OHCGKEBIENN(LMANDBIPEEG PFIDLLHMDPD, IPEndPoint EIAFMACBHBC, int EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD71A0", Offset = "0x5CD59A0", VA = "0x185CD71A0")]
	internal void PKKMODGDJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6460", Offset = "0x5CD4C60", VA = "0x185CD6460")]
	internal void KJOIPIFNKPD(IPEndPoint BAGLFHGOGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD69E0", Offset = "0x5CD51E0", VA = "0x185CD69E0")]
	internal void LDJNOEPGNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5290", Offset = "0x5CD3A90", VA = "0x185CD5290")]
	private void KCMPMFOHONK(int JELDGCAGFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD41C0", Offset = "0x5CD29C0", VA = "0x185CD41C0")]
	private void FCJNLKHPCFE(int JBDFAAHKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6C50", Offset = "0x5CD5450", VA = "0x185CD6C50")]
	private IGOGIEJIJIF NMALNDPLNMO(byte GGPLCIIKAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7270", Offset = "0x5CD5A70", VA = "0x185CD7270")]
	internal OHCGKEBIENN(LMANDBIPEEG PFIDLLHMDPD, IPEndPoint EIAFMACBHBC, int EGNLNANJFMI, byte IBFIILDKKIB, NHMHDECCKKC MIOHMHNBNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7850", Offset = "0x5CD6050", VA = "0x185CD7850")]
	internal OHCGKEBIENN(LMANDBIPEEG PFIDLLHMDPD, AENNLBEJKPH LOGLBHMJLPF, int EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6AD0", Offset = "0x5CD52D0", VA = "0x185CD6AD0")]
	internal void MDHBCBBBDEK(FGIMFBGELLG AMJBNLOEFAD, byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD42B0", Offset = "0x5CD2AB0", VA = "0x185CD42B0")]
	internal bool HDHMKNEOGIF(MIPLIIFONOC GENHPDPJDMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD39F0", Offset = "0x5CD21F0", VA = "0x185CD39F0")]
	public void ADGFAOFDKAI(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int IDGMEKAEIMD, OIDCMAJEMAP KBIBKNJKDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6490", Offset = "0x5CD4C90", VA = "0x185CD6490")]
	private void LBLJKCOFEEP(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int IDGMEKAEIMD, byte DHOJHCANKMO, OIDCMAJEMAP NICHEHJHEOL, object OENIOELPLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4200", Offset = "0x5CD2A00", VA = "0x185CD4200")]
	public void GLDPDLOPNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CD70C0", Offset = "0x5CD58C0", VA = "0x185CD70C0")]
	internal PCCFGGDCKDN PEJPGJCNGOA(IGONKJDANIP GENHPDPJDMD)
	{
		return default(PCCFGGDCKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6A70", Offset = "0x5CD5270", VA = "0x185CD6A70")]
	internal void LKDLEPPONJP(IGOGIEJIJIF CIDLDHDAJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4C10", Offset = "0x5CD3410", VA = "0x185CD4C10")]
	internal OHAAFDMPGBL JFEOJICGONL(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ, int IDGMEKAEIMD, bool AIDFLNGPPBP)
	{
		return default(OHAAFDMPGBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3A20", Offset = "0x5CD2220", VA = "0x185CD3A20")]
	private void COHPPOALFFI(int JIFCCDGKBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5A10", Offset = "0x5CD4210", VA = "0x185CD5A10")]
	internal void KDOCANEEAHK(OIDCMAJEMAP KLGJKLPJJAN, IGONKJDANIP IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4500", Offset = "0x5CD2D00", VA = "0x185CD4500")]
	private void INKLHDJDJPM(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4F20", Offset = "0x5CD3720", VA = "0x185CD4F20")]
	private void KBBCKODNFBI(int PNBNBIDOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4A50", Offset = "0x5CD3250", VA = "0x185CD4A50")]
	internal BMECPMBOOBC IOPEBINOLEM(FGIMFBGELLG KIIFGOKDDFE)
	{
		return default(BMECPMBOOBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5360", Offset = "0x5CD3B60", VA = "0x185CD5360")]
	internal void KDBICOOBFJE(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6B30", Offset = "0x5CD5330", VA = "0x185CD6B30")]
	private void MNMFCKNEKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4330", Offset = "0x5CD2B30", VA = "0x185CD4330")]
	internal void HIDDPLHFLEE(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3B10", Offset = "0x5CD2310", VA = "0x185CD3B10")]
	internal void EAHBMFPNBAD(int PNBNBIDOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6E00", Offset = "0x5CD5600", VA = "0x185CD6E00")]
	internal void OMGHPOMFMJJ(IGONKJDANIP GENHPDPJDMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KCMCDBFHKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long HKCFLODAGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EDAHFJPGOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long BBIFJMADBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HMJHHNLDHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long KAHFGFNOOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long NJNIIJFEBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long AMPPGCEFEAG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FMCBIAFADEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6870", Offset = "0x5CC5070", VA = "0x185CC6870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DMNKMMHMLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6850", Offset = "0x5CC5050", VA = "0x185CC6850")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long IOCOPBOEBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6970", Offset = "0x5CC5170", VA = "0x185CC6970")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FEJBJPIIEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6980", Offset = "0x5CC5180", VA = "0x185CC6980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long KNAIDFNECCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6990", Offset = "0x5CC5190", VA = "0x185CC6990")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long BKONLIHJILE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC67E0", Offset = "0x5CC4FE0", VA = "0x185CC67E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DHLPDKGAMBC NGAPFBGMHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6860", Offset = "0x5CC5060", VA = "0x185CC6860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double CJAIBBFPGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC67F0", Offset = "0x5CC4FF0", VA = "0x185CC67F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CC69B0", Offset = "0x5CC51B0", VA = "0x185CC69B0")]
	public void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6A10", Offset = "0x5CC5210", VA = "0x185CC6A10")]
	public void OKKIAEDGOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC67D0", Offset = "0x5CC4FD0", VA = "0x185CC67D0")]
	public void AKLCOBBLKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CC69A0", Offset = "0x5CC51A0", VA = "0x185CC69A0")]
	public void NJBIEPKHOJL(long BFKEJCIMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6920", Offset = "0x5CC5120", VA = "0x185CC6920")]
	public void IIAFMMHJHMA(long HLPNMEEEKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6A40", Offset = "0x5CC5240", VA = "0x185CC6A40")]
	public void PCGKKOJJBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6930", Offset = "0x5CC5130", VA = "0x185CC6930")]
	public void KBJBMNFHKEM(long KFFGIBLBMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6A70", Offset = "0x5CC5270", VA = "0x185CC6A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6880", Offset = "0x5CC5080", VA = "0x185CC6880")]
	public void HLKOLHFCJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KCMCDBFHKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OHGICHIFEPJ
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> CPFLNKMKFLL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7A60", Offset = "0x5CD6260", VA = "0x185CD7A60")]
	public static IPEndPoint MLJBHPGCIID(string MDLDMCABKFM, int MEOPEAGBICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7D40", Offset = "0x5CD6540", VA = "0x185CD7D40")]
	public static IPAddress OKGHIGKOBAF(string MDLDMCABKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7CB0", Offset = "0x5CD64B0", VA = "0x185CD7CB0")]
	public static IPAddress OKGHIGKOBAF(string MDLDMCABKFM, AddressFamily HNGJKKPPKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7A30", Offset = "0x5CD6230", VA = "0x185CD7A30")]
	internal static int HAADINMAMCB(int COHDBBMCFKL, int DKMMFHMIHHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C34F60", Offset = "0x2C33760", VA = "0x182C34F60")]
	internal static T[] HJLOGAHBPCG<T>(int POAAACAIHKJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JIIFDDOGBLF : IGOGIEJIJIF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct PCKAKILIDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private IGONKJDANIP ENGHNGFNKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HANGMKEPCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool PHFAFBAMDCD;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8080", Offset = "0x5CD6880", VA = "0x185CD8080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7FF0", Offset = "0x5CD67F0", VA = "0x185CD7FF0")]
		public void LMDILLFIIGI(IGONKJDANIP GENHPDPJDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8010", Offset = "0x5CD6810", VA = "0x185CD8010")]
		public bool OEEKOIKPDCL(long BDJBDOPLEGE, OHCGKEBIENN IEJMPGOKBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7FA0", Offset = "0x5CD67A0", VA = "0x185CD7FA0")]
		public bool GLOOIBDLHCC(OHCGKEBIENN IEJMPGOKBNN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly IGONKJDANIP IIFBOJEOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly PCKAKILIDBA[] FCJOHLOOEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly IGONKJDANIP[] JALLIGKHOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] JDCAOMPGLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CDADLKKABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int OLJNBKKDLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int MMNHACHHOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int CNHIGDKPMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool PHOCAMADPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly OIDCMAJEMAP LCCDECBIAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool GAPCFHJBNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int HNOHJHGPNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte BBLLFHNFDOA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6600", Offset = "0x5CC4E00", VA = "0x185CC6600")]
	public JIIFDDOGBLF(OHCGKEBIENN IEJMPGOKBNN, bool OEFHOIPMDBE, byte EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6240", Offset = "0x5CC4A40", VA = "0x185CC6240")]
	private void PILGPCNIAPG(IGONKJDANIP GENHPDPJDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5730", Offset = "0x5CC3F30", VA = "0x185CC5730", Slot = "4")]
	protected override bool CKKCHHBNMDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5BE0", Offset = "0x5CC43E0", VA = "0x185CC5BE0", Slot = "5")]
	public override bool KDBICOOBFJE(IGONKJDANIP GENHPDPJDMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GBOLGPCPPAD : IGOGIEJIJIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FOJAKAHDHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort OLJNBKKDLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool GOBKIPFHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private IGONKJDANIP BHLLPFLJJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly IGONKJDANIP JIPNAPDFMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool GHBCAAFJBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte BBLLFHNFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long OBJCGHPAHAB;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3960", Offset = "0x5CC2160", VA = "0x185CC3960")]
	public GBOLGPCPPAD(OHCGKEBIENN IEJMPGOKBNN, bool NFAECGNLAPC, byte EGNLNANJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CC31B0", Offset = "0x5CC19B0", VA = "0x185CC31B0", Slot = "4")]
	protected override bool CKKCHHBNMDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3650", Offset = "0x5CC1E50", VA = "0x185CC3650", Slot = "5")]
	public override bool KDBICOOBFJE(IGONKJDANIP GENHPDPJDMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KDGDNACCKPP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NDDAEFDLCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong JEMHNNOLLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double BAILEOEPJNK;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct HNICOCMODAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int FGLEGKOCHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float BOMDDAGGMFM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1DD0", Offset = "0x5CC05D0", VA = "0x185CC1DD0")]
	private static void BOFHIGFAJKD(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, ulong MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6E10", Offset = "0x5CC5610", VA = "0x185CC6E10")]
	private static void BOFHIGFAJKD(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, int MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6DD0", Offset = "0x5CC55D0", VA = "0x185CC6DD0")]
	public static void BOFHIGFAJKD(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, short MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F10", Offset = "0x5CC5710", VA = "0x185CC6F10")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, double IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6E80", Offset = "0x5CC5680", VA = "0x185CC6E80")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6DD0", Offset = "0x5CC55D0", VA = "0x185CC6DD0")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, short IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6DD0", Offset = "0x5CC55D0", VA = "0x185CC6DD0")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, ushort IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6E10", Offset = "0x5CC5610", VA = "0x185CC6E10")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6E10", Offset = "0x5CC5610", VA = "0x185CC6E10")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, uint IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F00", Offset = "0x5CC5700", VA = "0x185CC6F00")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, long IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F00", Offset = "0x5CC5700", VA = "0x185CC6F00")]
	public static void GEHENODKDEL(byte[] GHFEJDPMJDG, int JDPLFEPKJAC, ulong IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KFBANCBEOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] LEJBFAOMBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int MNKDNEIKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int DCJCBEOHALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int NEAMEFEOLEM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] OECNLFHKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int GGIEJOFCNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FCGMEBGIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7590", Offset = "0x5CC5D90", VA = "0x185CC7590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BPLNLLJLFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F7D0", Offset = "0x1E3DFD0", VA = "0x181E3F7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AHPGGBMPDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7A50", Offset = "0x5CC6250", VA = "0x185CC7A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CC78B0", Offset = "0x5CC60B0", VA = "0x185CC78B0")]
	public void LMAGBJHNIJF(byte[] CMAEAOPOFPD, int MFLLOPOPNNG, int PLLOMCAEJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KFBANCBEOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7B10", Offset = "0x5CC6310", VA = "0x185CC7B10")]
	public KFBANCBEOEK(byte[] CMAEAOPOFPD, int MFLLOPOPNNG, int PLLOMCAEJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7480", Offset = "0x5CC5C80", VA = "0x185CC7480")]
	public IPEndPoint GMOKBLHPFMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7080", Offset = "0x5CC5880", VA = "0x185CC7080")]
	public byte OKPBOBFFCOA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7080", Offset = "0x5CC5880", VA = "0x185CC7080")]
	public sbyte BNCDEHEEACK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B267E0", Offset = "0x2B24FE0", VA = "0x182B267E0")]
	public T[] OHIPNBBHBLN<T>(ushort GGKCGCGFHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC73E0", Offset = "0x5CC5BE0", VA = "0x185CC73E0")]
	public bool[] FCLMHMDHHOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7A60", Offset = "0x5CC6260", VA = "0x185CC7A60")]
	public ushort[] OMLKCFCDLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7550", Offset = "0x5CC5D50", VA = "0x185CC7550")]
	public short[] HEPHIDIIILD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC79A0", Offset = "0x5CC61A0", VA = "0x185CC79A0")]
	public int[] MGBDEONDELI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7960", Offset = "0x5CC6160", VA = "0x185CC7960")]
	public uint[] LOOKGFFDECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7170", Offset = "0x5CC5970", VA = "0x185CC7170")]
	public float[] DOHOPFFGMDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7130", Offset = "0x5CC5930", VA = "0x185CC7130")]
	public double[] CHNFCJJBEHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7420", Offset = "0x5CC5C20", VA = "0x185CC7420")]
	public long[] FHHCHAAEKGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7620", Offset = "0x5CC5E20", VA = "0x185CC7620")]
	public ulong[] HLMHFNFCCBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5CC76D0", Offset = "0x5CC5ED0", VA = "0x185CC76D0")]
	public string[] ILBEJELPGHJ(int COBEMBADPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CC75E0", Offset = "0x5CC5DE0", VA = "0x185CC75E0")]
	public bool HLFNMEJLEED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6FA0", Offset = "0x5CC57A0", VA = "0x185CC6FA0")]
	public char APFPELMCNON()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6FA0", Offset = "0x5CC57A0", VA = "0x185CC6FA0")]
	public ushort AMMKDDFLFMC()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CC70C0", Offset = "0x5CC58C0", VA = "0x185CC70C0")]
	public short BOIFKLDPDBF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7010", Offset = "0x5CC5810", VA = "0x185CC7010")]
	public long BLHEAANNAIJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F30", Offset = "0x5CC5730", VA = "0x185CC6F30")]
	public ulong AJEKLLCABJF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7AA0", Offset = "0x5CC62A0", VA = "0x185CC7AA0")]
	public int PIMPPGEHIKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC78F0", Offset = "0x5CC60F0", VA = "0x185CC78F0")]
	public uint LMHFIANBIDF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7660", Offset = "0x5CC5E60", VA = "0x185CC7660")]
	public float IAGEGHGIICO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7800", Offset = "0x5CC6000", VA = "0x185CC7800")]
	public double JAGGDMNNEMI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5CC71B0", Offset = "0x5CC59B0", VA = "0x185CC71B0")]
	public string EIONBALEGDI(int JBKJHFHKKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CC79E0", Offset = "0x5CC61E0", VA = "0x185CC79E0")]
	public ArraySegment<byte> NDMPOHLBOII(int POAAACAIHKJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5CC75A0", Offset = "0x5CC5DA0", VA = "0x185CC75A0")]
	public sbyte[] HLEEJCMNEMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7870", Offset = "0x5CC6070", VA = "0x185CC7870")]
	public byte[] LCNCCPOHBBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7460", Offset = "0x5CC5C60", VA = "0x185CC7460")]
	public void GLOOIBDLHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NHMHDECCKKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] LEJBFAOMBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int MNKDNEIKOFL;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int BLPEKHDAEHC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool NHNPKNKNMMF;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding DKEDMAHIOKN;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int KJMIMGLDGIN = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] NJFEGMGIEDM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] IGFBHOELDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FDFCDEPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5CD36F0", Offset = "0x5CD1EF0", VA = "0x185CD36F0")]
	public NHMHDECCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3770", Offset = "0x5CD1F70", VA = "0x185CD3770")]
	public NHMHDECCKKC(bool OHGFFNJCJKI, int LONGIHLPAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3600", Offset = "0x5CD1E00", VA = "0x185CD3600")]
	public static NHMHDECCKKC KFLHOMHDHMD(string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2F00", Offset = "0x5CD1700", VA = "0x185CD2F00")]
	public void DBGAOAPCLMG(int BHDGLHEOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8E90", Offset = "0x1EB7690", VA = "0x181EB8E90")]
	public void NJEEDNGOJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3080", Offset = "0x5CD1880", VA = "0x185CD3080")]
	public void DPNKMPBMCPH(float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3030", Offset = "0x5CD1830", VA = "0x185CD3030")]
	public void DPNKMPBMCPH(double IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3260", Offset = "0x5CD1A60", VA = "0x185CD3260")]
	public void DPNKMPBMCPH(long IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3260", Offset = "0x5CD1A60", VA = "0x185CD3260")]
	public void DPNKMPBMCPH(ulong IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2FA0", Offset = "0x5CD17A0", VA = "0x185CD2FA0")]
	public void DPNKMPBMCPH(int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2FA0", Offset = "0x5CD17A0", VA = "0x185CD2FA0")]
	public void DPNKMPBMCPH(uint IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5CD31F0", Offset = "0x5CD19F0", VA = "0x185CD31F0")]
	public void DPNKMPBMCPH(char IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5CD31F0", Offset = "0x5CD19F0", VA = "0x185CD31F0")]
	public void DPNKMPBMCPH(ushort IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5CD31F0", Offset = "0x5CD19F0", VA = "0x185CD31F0")]
	public void DPNKMPBMCPH(short IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3190", Offset = "0x5CD1990", VA = "0x185CD3190")]
	public void DPNKMPBMCPH(sbyte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3190", Offset = "0x5CD1990", VA = "0x185CD3190")]
	public void DPNKMPBMCPH(byte IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3120", Offset = "0x5CD1920", VA = "0x185CD3120")]
	public void DPNKMPBMCPH(byte[] MLKNGAFFKGE, int MFLLOPOPNNG, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5CD29D0", Offset = "0x5CD11D0", VA = "0x185CD29D0")]
	public void BJKDKBLFFGH(sbyte[] MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5CD29D0", Offset = "0x5CD11D0", VA = "0x185CD29D0")]
	public void MKHHFAJOHON(byte[] MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD32B0", Offset = "0x5CD1AB0", VA = "0x185CD32B0")]
	public void DPNKMPBMCPH(bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2D40", Offset = "0x5CD1540", VA = "0x185CD2D40")]
	public void CBCAHKMBLPM(Array EJOKFOGAAII, int JJLHDCIDGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E20", Offset = "0x5CD1620", VA = "0x185CD2E20")]
	public void CBCAHKMBLPM(float[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2AB0", Offset = "0x5CD12B0", VA = "0x185CD2AB0")]
	public void CBCAHKMBLPM(double[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2AB0", Offset = "0x5CD12B0", VA = "0x185CD2AB0")]
	public void CBCAHKMBLPM(long[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2AB0", Offset = "0x5CD12B0", VA = "0x185CD2AB0")]
	public void CBCAHKMBLPM(ulong[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E20", Offset = "0x5CD1620", VA = "0x185CD2E20")]
	public void CBCAHKMBLPM(int[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2E20", Offset = "0x5CD1620", VA = "0x185CD2E20")]
	public void CBCAHKMBLPM(uint[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2B90", Offset = "0x5CD1390", VA = "0x185CD2B90")]
	public void CBCAHKMBLPM(ushort[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2B90", Offset = "0x5CD1390", VA = "0x185CD2B90")]
	public void CBCAHKMBLPM(short[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5CD29D0", Offset = "0x5CD11D0", VA = "0x185CD29D0")]
	public void CBCAHKMBLPM(bool[] IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2C70", Offset = "0x5CD1470", VA = "0x185CD2C70")]
	public void CBCAHKMBLPM(string[] IPHHABIKCHD, int GCPDHKLJIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3310", Offset = "0x5CD1B10", VA = "0x185CD3310")]
	public void DPNKMPBMCPH(IPEndPoint ELIOKBGDCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CD35F0", Offset = "0x5CD1DF0", VA = "0x185CD35F0")]
	public void DPNKMPBMCPH(string IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CD33E0", Offset = "0x5CD1BE0", VA = "0x185CD33E0")]
	public void DPNKMPBMCPH(string IPHHABIKCHD, int JBKJHFHKKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KFNLHMBJLPH
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class NDICFMJIHPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong ACEJJAKLDLF;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x44268E0", Offset = "0x44250E0", VA = "0x1844268E0")]
		static NDICFMJIHPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void PDIABEBOHFD(KFBANCBEOEK PJOJHFLPHKO, object OENIOELPLPB);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PBPPCJBHFLN<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public KFNLHMBJLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PBPPCJBHFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x464E590", Offset = "0x464CD90", VA = "0x18464E590")]
		internal void NBMMOIOPILI(KFBANCBEOEK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class AJDBOPANILC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KFNLHMBJLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AJDBOPANILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC5F0", Offset = "0x3BAADF0", VA = "0x183BAC5F0")]
		internal void NBMMOIOPILI(KFBANCBEOEK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DMKPAKADLNM FIBJIIMLFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, PDIABEBOHFD> NMOKGPIFFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly NHMHDECCKKC JALDONMFAGG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7D70", Offset = "0x5CC6570", VA = "0x185CC7D70")]
	public KFNLHMBJLPH(int COBEMBADPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x282F730", Offset = "0x282DF30", VA = "0x18282F730", Slot = "4")]
	protected virtual ulong HLDBGADLHGP<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7BF0", Offset = "0x5CC63F0", VA = "0x185CC7BF0", Slot = "5")]
	protected virtual PDIABEBOHFD CJHGAJFGIIH(KFBANCBEOEK PJOJHFLPHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B28100", Offset = "0x2B26900", VA = "0x182B28100", Slot = "6")]
	protected virtual void JPJOIALFBIN<T>(NHMHDECCKKC COHNONCDMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7B70", Offset = "0x5CC6370", VA = "0x185CC7B70")]
	public void BPKIAHEEKEO(KFBANCBEOEK PJOJHFLPHKO, object OENIOELPLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2B28050", Offset = "0x2B26850", VA = "0x182B28050")]
	public void IINHDBGECBD<T>(NHMHDECCKKC COHNONCDMOG, T GENHPDPJDMD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7D20", Offset = "0x5CC6520", VA = "0x185CC7D20")]
	public void JKILBJBHPOG(KFBANCBEOEK PJOJHFLPHKO, object OENIOELPLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2B27E90", Offset = "0x2B26690", VA = "0x182B27E90")]
	public void EPKCJPEGEMC<T>(Action<T> NPHGIOJNEPO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2B27CD0", Offset = "0x2B264D0", VA = "0x182B27CD0")]
	public void EPKCJPEGEMC<T, TUserData>(Action<T, TUserData> NPHGIOJNEPO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BBGIIENAEMI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC29F0", Offset = "0x5CC11F0", VA = "0x185CC29F0")]
	public BBGIIENAEMI(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LGJEBEGMMHF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7EF0", Offset = "0x5CC66F0", VA = "0x185CC7EF0")]
	public LGJEBEGMMHF(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class DMKPAKADLNM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum CLLKEGECCHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FPGHNGNOGDB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CLLKEGECCHD LBCGEBEPPGP;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E4C0", Offset = "0x3B1CCC0", VA = "0x183B1E4C0", Slot = "4")]
		public virtual void LMDILLFIIGI(MethodInfo EBNIDDGOFCL, MethodInfo PLDEKIKIAAM, CLLKEGECCHD HKAKMPIMEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void CAJDNPICDFE(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FIBGNIHOEAK(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		protected FPGHNGNOGDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class NJIKNEBJFCN<TClass, TProperty> : FPGHNGNOGDB<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> AFENMFKHCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> BPCPNOOCBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> JDMFNNMOAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> KNHCGBIDJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> HDOJEHGOPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> AIGBIGGMOKH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x444E460", Offset = "0x444CC60", VA = "0x18444E460", Slot = "7")]
		public override void EFHLBEKOJHH(TClass EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4453D10", Offset = "0x4452510", VA = "0x184453D10", Slot = "8")]
		public override void MDENIKOEGEJ(TClass EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x444D900", Offset = "0x444C100", VA = "0x18444D900", Slot = "9")]
		public override void CAJDNPICDFE(TClass EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x444EFC0", Offset = "0x444D7C0", VA = "0x18444EFC0", Slot = "10")]
		public override void FIBGNIHOEAK(TClass EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4454810", Offset = "0x4453010", VA = "0x184454810")]
		protected TProperty[] PFFHBAIIAFG(TClass EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4454790", Offset = "0x4452F90", VA = "0x184454790")]
		protected TProperty[] PCEDMEICNAA(TClass EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4452AC0", Offset = "0x44512C0", VA = "0x184452AC0", Slot = "4")]
		public override void LMDILLFIIGI(MethodInfo EBNIDDGOFCL, MethodInfo PLDEKIKIAAM, CLLKEGECCHD HKAKMPIMEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3FC0", Offset = "0x3CC27C0", VA = "0x183CC3FC0")]
		protected NJIKNEBJFCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class MNFMNFBGMDN<TClass, TProperty> : NJIKNEBJFCN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ADKCPPKLOGG(KFBANCBEOEK KEIFIHHDEOD, [Out] TProperty NCGPGHKFLCK);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void HEHKKGIJJLF(NHMHDECCKKC NCACLCNGFPK, TProperty NCGPGHKFLCK);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x43BD030", Offset = "0x43BB830", VA = "0x1843BD030", Slot = "5")]
		public override void FJPNMKBHKGN(TClass EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x43BD170", Offset = "0x43BB970", VA = "0x1843BD170", Slot = "6")]
		public override void IINHDBGECBD(TClass EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x43BCEB0", Offset = "0x43BB6B0", VA = "0x1843BCEB0", Slot = "7")]
		public override void EFHLBEKOJHH(TClass EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x43BD350", Offset = "0x43BBB50", VA = "0x1843BD350", Slot = "8")]
		public override void MDENIKOEGEJ(TClass EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA2E0", Offset = "0x3DB8AE0", VA = "0x183DBA2E0")]
		protected MNFMNFBGMDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class ONOALDPHJNN<T> : NJIKNEBJFCN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45A1450", Offset = "0x459FC50", VA = "0x1845A1450", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EB20", Offset = "0x3F5D320", VA = "0x183F5EB20", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x45A13D0", Offset = "0x459FBD0", VA = "0x1845A13D0", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A570", Offset = "0x3D88D70", VA = "0x183D8A570", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public ONOALDPHJNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class JAHPEFILCBK<T> : NJIKNEBJFCN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EAA0", Offset = "0x3F5D2A0", VA = "0x183F5EAA0", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EB20", Offset = "0x3F5D320", VA = "0x183F5EB20", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EA20", Offset = "0x3F5D220", VA = "0x183F5EA20", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A570", Offset = "0x3D88D70", VA = "0x183D8A570", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public JAHPEFILCBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class LJJKKLFHGNJ<T> : NJIKNEBJFCN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x41545B0", Offset = "0x4152DB0", VA = "0x1841545B0", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4154630", Offset = "0x4152E30", VA = "0x184154630", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4154530", Offset = "0x4152D30", VA = "0x184154530", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x41546A0", Offset = "0x4152EA0", VA = "0x1841546A0", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public LJJKKLFHGNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NJMLFKHGHAL<T> : NJIKNEBJFCN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x44554D0", Offset = "0x4453CD0", VA = "0x1844554D0", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4154630", Offset = "0x4152E30", VA = "0x184154630", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4455450", Offset = "0x4453C50", VA = "0x184455450", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x41546A0", Offset = "0x4152EA0", VA = "0x1841546A0", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public NJMLFKHGHAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class HMBCCDJBBIH<T> : NJIKNEBJFCN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3370", Offset = "0x3CB1B70", VA = "0x183CB3370", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB33F0", Offset = "0x3CB1BF0", VA = "0x183CB33F0", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB32F0", Offset = "0x3CB1AF0", VA = "0x183CB32F0", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3460", Offset = "0x3CB1C60", VA = "0x183CB3460", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public HMBCCDJBBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class BLBMGPBMOAP<T> : NJIKNEBJFCN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4D34180", Offset = "0x4D32980", VA = "0x184D34180", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB33F0", Offset = "0x3CB1BF0", VA = "0x183CB33F0", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4D34100", Offset = "0x4D32900", VA = "0x184D34100", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3460", Offset = "0x3CB1C60", VA = "0x183CB3460", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public BLBMGPBMOAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MCDBAOFLPPL<T> : NJIKNEBJFCN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F63E00", Offset = "0x3F62600", VA = "0x183F63E00", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F63E80", Offset = "0x3F62680", VA = "0x183F63E80", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x433C750", Offset = "0x433AF50", VA = "0x18433C750", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F63EF0", Offset = "0x3F626F0", VA = "0x183F63EF0", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public MCDBAOFLPPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class JCDNNJAONAE<T> : NJIKNEBJFCN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F63E00", Offset = "0x3F62600", VA = "0x183F63E00", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F63E80", Offset = "0x3F62680", VA = "0x183F63E80", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F63D80", Offset = "0x3F62580", VA = "0x183F63D80", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F63EF0", Offset = "0x3F626F0", VA = "0x183F63EF0", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public JCDNNJAONAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class IFOAPMDAEOB<T> : NJIKNEBJFCN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A480", Offset = "0x3D88C80", VA = "0x183D8A480", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A500", Offset = "0x3D88D00", VA = "0x183D8A500", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A400", Offset = "0x3D88C00", VA = "0x183D8A400", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A570", Offset = "0x3D88D70", VA = "0x183D8A570", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public IFOAPMDAEOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class JJCNAHFCDNO<T> : NJIKNEBJFCN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1B80", Offset = "0x3FA0380", VA = "0x183FA1B80", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1C00", Offset = "0x3FA0400", VA = "0x183FA1C00", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1B00", Offset = "0x3FA0300", VA = "0x183FA1B00", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3460", Offset = "0x3CB1C60", VA = "0x183CB3460", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public JJCNAHFCDNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NLFCFEKDJOF<T> : NJIKNEBJFCN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x44627C0", Offset = "0x4460FC0", VA = "0x1844627C0", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4462840", Offset = "0x4461040", VA = "0x184462840", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4462740", Offset = "0x4460F40", VA = "0x184462740", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F63EF0", Offset = "0x3F626F0", VA = "0x183F63EF0", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
		public NLFCFEKDJOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class GCILBEODEDC<T> : MNFMNFBGMDN<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5180", Offset = "0x3BC3980", VA = "0x183BC5180", Slot = "12")]
		protected override void HEHKKGIJJLF(NHMHDECCKKC NCACLCNGFPK, char NCGPGHKFLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5150", Offset = "0x3BC3950", VA = "0x183BC5150", Slot = "11")]
		protected override void ADKCPPKLOGG(KFBANCBEOEK KEIFIHHDEOD, [Out] char NCGPGHKFLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3BC51B0", Offset = "0x3BC39B0", VA = "0x183BC51B0")]
		public GCILBEODEDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ICHLJDCFDOB<T> : MNFMNFBGMDN<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D64A90", Offset = "0x3D63290", VA = "0x183D64A90", Slot = "12")]
		protected override void HEHKKGIJJLF(NHMHDECCKKC NCACLCNGFPK, IPEndPoint NCGPGHKFLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D64A50", Offset = "0x3D63250", VA = "0x183D64A50", Slot = "11")]
		protected override void ADKCPPKLOGG(KFBANCBEOEK KEIFIHHDEOD, [Out] IPEndPoint NCGPGHKFLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BC51B0", Offset = "0x3BC39B0", VA = "0x183BC51B0")]
		public ICHLJDCFDOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KAFPCHDJENG<T> : NJIKNEBJFCN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int ANGPONBHGLO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x40757A0", Offset = "0x4073FA0", VA = "0x1840757A0")]
		public KAFPCHDJENG(int JBKJHFHKKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4075620", Offset = "0x4073E20", VA = "0x184075620", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40756A0", Offset = "0x4073EA0", VA = "0x1840756A0", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x40755A0", Offset = "0x4073DA0", VA = "0x1840755A0", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4075720", Offset = "0x4073F20", VA = "0x184075720", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JCNCMLDLFJH<T> : FPGHNGNOGDB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo ILFOMNGOANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type APGJMDCOICP;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F707F0", Offset = "0x3F6EFF0", VA = "0x183F707F0")]
		public JCNCMLDLFJH(PropertyInfo ABBFPCPEMEH, Type EPDILKJOBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F70620", Offset = "0x3F6EE20", VA = "0x183F70620", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F706E0", Offset = "0x3F6EEE0", VA = "0x183F706E0", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F70560", Offset = "0x3F6ED60", VA = "0x183F70560", Slot = "7")]
		public override void EFHLBEKOJHH(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F70790", Offset = "0x3F6EF90", VA = "0x183F70790", Slot = "8")]
		public override void MDENIKOEGEJ(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F70500", Offset = "0x3F6ED00", VA = "0x183F70500", Slot = "9")]
		public override void CAJDNPICDFE(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F705C0", Offset = "0x3F6EDC0", VA = "0x183F705C0", Slot = "10")]
		public override void FIBGNIHOEAK(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class HPIBOHFBFCD<T> : JCNCMLDLFJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
		public HPIBOHFBFCD(PropertyInfo ABBFPCPEMEH, Type EPDILKJOBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0C30", Offset = "0x3CCF430", VA = "0x183CD0C30", Slot = "5")]
		public override void FJPNMKBHKGN(T EBLEPDFMMFK, KFBANCBEOEK KEIFIHHDEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0CF0", Offset = "0x3CCF4F0", VA = "0x183CD0CF0", Slot = "6")]
		public override void IINHDBGECBD(T EBLEPDFMMFK, NHMHDECCKKC NCACLCNGFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class AFDLDLPCCBJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static AFDLDLPCCBJ<T> DCEJKJKKEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly FPGHNGNOGDB<T>[] GGGDEKFDNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int CHHAFEOGOOE;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3B986A0", Offset = "0x3B96EA0", VA = "0x183B986A0")]
		public AFDLDLPCCBJ(List<FPGHNGNOGDB<T>> MOHCMANEAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B985F0", Offset = "0x3B96DF0", VA = "0x183B985F0")]
		public void IINHDBGECBD(T GHDJADLHPAA, NHMHDECCKKC COHNONCDMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B98540", Offset = "0x3B96D40", VA = "0x183B98540")]
		public void FJPNMKBHKGN(T GHDJADLHPAA, KFBANCBEOEK PJOJHFLPHKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class CMPDINBJLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FPGHNGNOGDB<T> NBGKOOJKKKA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NHMHDECCKKC NCBABBIACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int KOILIFDBHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, CMPDINBJLAJ> ICLLOGFEJON;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2A00", Offset = "0x5CC1200", VA = "0x185CC2A00")]
	public DMKPAKADLNM(int COBEMBADPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28F70C0", Offset = "0x28F58C0", VA = "0x1828F70C0")]
	private AFDLDLPCCBJ<T> INILCBLBGPH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2831230", Offset = "0x282FA30", VA = "0x182831230")]
	public void MPPLGFJBDHC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28F81E0", Offset = "0x28F69E0", VA = "0x1828F81E0")]
	public bool PKPMANIAHDL<T>(KFBANCBEOEK PJOJHFLPHKO, T LFFBLPMMGND) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28F7030", Offset = "0x28F5830", VA = "0x1828F7030")]
	public void HNAIEAEAFJH<T>(NHMHDECCKKC COHNONCDMOG, T GHDJADLHPAA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MBFMPBHAKBL
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime NLABLCAEFIH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] MOPNBKPJBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ABHLCCAONAE BPCJEAMOBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD07D0", Offset = "0x5CCEFD0", VA = "0x185CD07D0")]
		get
		{
			return default(ABHLCCAONAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int EBIJIGKMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD12F0", Offset = "0x5CCFAF0", VA = "0x185CD12F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1150", Offset = "0x5CCF950", VA = "0x185CD1150")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ABAKPIMFAPG MFEKHJJCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0800", Offset = "0x5CCF000", VA = "0x185CD0800")]
		get
		{
			return default(ABAKPIMFAPG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CD12B0", Offset = "0x5CCFAB0", VA = "0x185CD12B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IIEKEBFJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1120", Offset = "0x5CCF920", VA = "0x185CD1120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint MDIGJBGLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1320", Offset = "0x5CCFB20", VA = "0x185CD1320")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? FELFGCCODAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0B50", Offset = "0x5CCF350", VA = "0x185CD0B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? GGMHMPFFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0770", Offset = "0x5CCEF70", VA = "0x185CD0770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? FLIEKDFJLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD07A0", Offset = "0x5CCEFA0", VA = "0x185CD07A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0F50", Offset = "0x5CCF750", VA = "0x185CD0F50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? JAKANGHDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3A170", Offset = "0xA38970", VA = "0x180A3A170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1730", Offset = "0x5CCFF30", VA = "0x185CD1730")]
	public MBFMPBHAKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1A50", Offset = "0x5CD0250", VA = "0x185CD1A50")]
	internal MBFMPBHAKBL(byte[] GHFEJDPMJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0830", Offset = "0x5CCF030", VA = "0x185CD0830")]
	public static MBFMPBHAKBL EGMNMLMFDGJ(byte[] GHFEJDPMJDG, DateTime JGBCLJPNGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0B80", Offset = "0x5CCF380", VA = "0x185CD0B80")]
	internal void GIJHAJIJGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0D80", Offset = "0x5CCF580", VA = "0x185CD0D80")]
	private void GNJNKOJFEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0950", Offset = "0x5CCF150", VA = "0x185CD0950")]
	private DateTime? FNEIAIBJMDJ(int MFLLOPOPNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1500", Offset = "0x5CCFD00", VA = "0x185CD1500")]
	private void PLEDEOHNJHE(int MFLLOPOPNNG, DateTime? IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CD13A0", Offset = "0x5CCFBA0", VA = "0x185CD13A0")]
	private ulong OMGHNLHEAHB(int MFLLOPOPNNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1190", Offset = "0x5CCF990", VA = "0x185CD1190")]
	private void KGIIBCLJLLF(int MFLLOPOPNNG, ulong IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1470", Offset = "0x5CCFC70", VA = "0x185CD1470")]
	private uint PCOGFMFLNMD(int MFLLOPOPNNG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B95590", Offset = "0x5B93D90", VA = "0x185B95590")]
	private static uint LENPHAGBHOE(uint PNGIKMLKECD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1250", Offset = "0x5CCFA50", VA = "0x185CD1250")]
	private static ulong LENPHAGBHOE(ulong PNGIKMLKECD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ABHLCCAONAE
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
public enum ABAKPIMFAPG
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NFBJDHGPIIL
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int MFIMHMKIBHB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int MMLCOGNKHAL = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int HKLCGNBKLKA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint GCJMKBAKBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int LGPIIAHKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int NBPFHDLCMLP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IGONBOEHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CD29C0", Offset = "0x5CD11C0", VA = "0x185CD29C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CD28D0", Offset = "0x5CD10D0", VA = "0x185CD28D0")]
	public bool ADGFAOFDKAI(BOGCLMPJCBA EAGGHHCNHNH, int KJAPNCDOIOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class ACNBGJNAHIJ : BOGCLMPJCBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket EAGGHHCNHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LMANDBIPEEG PFIDLLHMDPD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short CINGOBNBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC25A0", Offset = "0x5CC0DA0", VA = "0x185CC25A0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int AMINMGJHCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1F60", Offset = "0x5CC0760", VA = "0x185CC1F60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint HMIODBDDING
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC26B0", Offset = "0x5CC0EB0", VA = "0x185CC26B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily KNEFMGFJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x412B3F0", Offset = "0x4129BF0", VA = "0x18412B3F0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CC26D0", Offset = "0x5CC0ED0", VA = "0x185CC26D0")]
	public ACNBGJNAHIJ(AddressFamily HNGJKKPPKKH, LMANDBIPEEG PFIDLLHMDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1FA0", Offset = "0x5CC07A0", VA = "0x185CC1FA0", Slot = "8")]
	public bool GCFCFMMHKNM(IPEndPoint ELIOKBGDCDJ, IBCHHCJJMBO JPBGADEEEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2560", Offset = "0x5CC0D60", VA = "0x185CC2560", Slot = "9")]
	public int HHEICODBNGE(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, int GGKCGCGFHKJ, IPEndPoint EIAFMACBHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC25C0", Offset = "0x5CC0DC0", VA = "0x185CC25C0", Slot = "10")]
	public int JIKMDLAAAFL(byte[] PAJEBKJPIBK, EndPoint FNEDBPKKCIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1F80", Offset = "0x5CC0780", VA = "0x185CC1F80", Slot = "11")]
	public void CHJIEDPFKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface BOGCLMPJCBA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short CINGOBNBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int AMINMGJHCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint HMIODBDDING
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily KNEFMGFJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GCFCFMMHKNM(IPEndPoint ELIOKBGDCDJ, IBCHHCJJMBO JPBGADEEEGM);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int HHEICODBNGE(byte[] PAJEBKJPIBK, int MFLLOPOPNNG, int GGKCGCGFHKJ, IPEndPoint EIAFMACBHBC);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JIKMDLAAAFL(byte[] PAJEBKJPIBK, EndPoint EIAFMACBHBC);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHJIEDPFKFL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NJKLAIEHJOP : IEquatable<NJKLAIEHJOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long AOMBPFALAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long ALAOKMIFDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long BLLFPEPLMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int CBJKNOHDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int LNGAAOLDHHE;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3900", Offset = "0x5CD2100", VA = "0x185CD3900")]
	public NJKLAIEHJOP(byte[] DPKBONFELAE, int PFMDBCNIBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x86AF00", Offset = "0x869700", VA = "0x18086AF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5CD38C0", Offset = "0x5CD20C0", VA = "0x185CD38C0", Slot = "4")]
	public bool Equals(NJKLAIEHJOP OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3810", Offset = "0x5CD2010", VA = "0x185CD3810", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FHGCABANKID : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] EDKEAOLLKBG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class OHFBMBCOPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int CHELPLBFBMK;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
	protected OHFBMBCOPHG(int CHAMGGNDCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DODBMNFNHHM(IPEndPoint ELIOKBGDCDJ, byte[] MLKNGAFFKGE, int MFLLOPOPNNG, int IDGMEKAEIMD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FBHDHOKICFK(IPEndPoint ELIOKBGDCDJ, byte[] MLKNGAFFKGE, int MFLLOPOPNNG, int IDGMEKAEIMD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GKOFOIILLDC : OHFBMBCOPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider GEDAHEHFOBE;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator DFBOCGCLHJB;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4660", Offset = "0x5CC2E60", VA = "0x185CC4660")]
	public GKOFOIILLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC43D0", Offset = "0x5CC2BD0", VA = "0x185CC43D0")]
	public void IGGJEGBKHPA(IPEndPoint ELIOKBGDCDJ, byte[] JOEHGGMHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC42F0", Offset = "0x5CC2AF0", VA = "0x185CC42F0")]
	public void IDIBPIEHBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3EC0", Offset = "0x5CC26C0", VA = "0x185CC3EC0")]
	private byte[] EIEAJIGOPDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3A20", Offset = "0x5CC2220", VA = "0x185CC3A20", Slot = "4")]
	public override void DODBMNFNHHM(IPEndPoint ELIOKBGDCDJ, byte[] MLKNGAFFKGE, int MFLLOPOPNNG, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3F50", Offset = "0x5CC2750", VA = "0x185CC3F50", Slot = "5")]
	public override void FBHDHOKICFK(IPEndPoint ELIOKBGDCDJ, byte[] MLKNGAFFKGE, int MFLLOPOPNNG, int IDGMEKAEIMD)
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
