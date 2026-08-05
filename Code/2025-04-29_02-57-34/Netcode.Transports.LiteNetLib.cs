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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BKJALBIBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EAFINBLHHNK
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
		private NetworkManager HEDEHCGCEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KLFAAEKFNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, HPHHCLPJOLD> CNNNPMAENMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CNJKFPBKODA IAHNKLBMMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch PBMCBPFCFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] JDNAICMACDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EAFINBLHHNK MEPBPAJGDKE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong DINAKBIPMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IMPNFOKDOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6D7F440", Offset = "0x6D7E840", VA = "0x186D7F440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EA10", Offset = "0x6D7DE10", VA = "0x186D7EA10")]
		public void RecRoom_SetEncryptionInfo(ulong EGIBLGCAMOP, byte[] IICGAABOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E9F0", Offset = "0x6D7DDF0", VA = "0x186D7E9F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E8C0", Offset = "0x6D7DCC0", VA = "0x186D7E8C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F340", Offset = "0x6D7E740", VA = "0x186D7F340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB30", Offset = "0x6D7DF30", VA = "0x186D7EB30", Slot = "6")]
		public override void Send(ulong LPEAHPLMOMA, ArraySegment<byte> AOFGGGKINCN, NetworkDelivery KPHBDCHMJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E9B0", Offset = "0x6D7DDB0", VA = "0x186D7E9B0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong LPEAHPLMOMA, [Out] ArraySegment<byte> CFFKMBGFAOG, [Out] float MEOPFBNMPAA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EE20", Offset = "0x6D7E220", VA = "0x186D7EE20", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F260", Offset = "0x6D7E660", VA = "0x186D7F260", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DF50", Offset = "0x6D7D350", VA = "0x186D7DF50", Slot = "11")]
		public override void DisconnectRemoteClient(ulong LPEAHPLMOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DE60", Offset = "0x6D7D260", VA = "0x186D7DE60", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E060", Offset = "0x6D7D460", VA = "0x186D7E060", Slot = "13")]
		public override ulong GetCurrentRtt(ulong LPEAHPLMOMA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EDB0", Offset = "0x6D7E1B0", VA = "0x186D7EDB0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E160", Offset = "0x6D7D560", VA = "0x186D7E160", Slot = "15")]
		public override void Initialize([Optional] NetworkManager HEDEHCGCEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E710", Offset = "0x6D7DB10", VA = "0x186D7E710")]
		private HNMAIMNJJAH LMPHPJKHGBH(NetworkDelivery KHNCICOHHHJ)
		{
			return default(HNMAIMNJJAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E370", Offset = "0x6D7D770", VA = "0x186D7E370", Slot = "16")]
		private void KNHEGDHNBKN(HPHHCLPJOLD OIEGKBOHBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E640", Offset = "0x6D7DA40", VA = "0x186D7E640", Slot = "17")]
		private void LMDODJGPCOE(HPHHCLPJOLD OIEGKBOHBKO, DCFLFEFDIJJ IPCPPPHJHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "18")]
		private void EDGPKEMGBMC(IPEndPoint ILJEIFNEHJN, SocketError LLOMMMEAOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E430", Offset = "0x6D7D830", VA = "0x186D7E430", Slot = "19")]
		private void LCACBBAKCHA(HPHHCLPJOLD OIEGKBOHBKO, DFCHHHDHKPB PABEDPKBAJJ, byte INIJAHMNNJC, HNMAIMNJJAH LODIIIHAHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E7E0", Offset = "0x6D7DBE0", VA = "0x186D7E7E0")]
		private void MKPJCBKCCOF(int LLBNOFGPNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "20")]
		private void MENMGNOIIDE(IPEndPoint DAHIKICCCCL, DFCHHHDHKPB PABEDPKBAJJ, NIOMLNIOFBE AMDMAMLIDJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "21")]
		private void HCEAGHGLAHN(HPHHCLPJOLD OIEGKBOHBKO, int GGKEEKADIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E100", Offset = "0x6D7D500", VA = "0x186D7E100", Slot = "22")]
		private void HOHCBEHAGNG(HPKEPDBDGLL LFFAIMMKIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DE30", Offset = "0x6D7D230", VA = "0x186D7DE30")]
		private ulong CGEALEKLALK(HPHHCLPJOLD OIEGKBOHBKO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DE10", Offset = "0x6D7D210", VA = "0x186D7DE10")]
		private static int BICAGJOGIHP(float FGNAOOMAGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F360", Offset = "0x6D7E760", VA = "0x186D7F360")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EAIFJEBAKPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly HPHHCLPJOLD BHOEHEMMBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<DECMEKNDOAL> KPIJLIPPLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int OJHCGOODECK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D747A0", Offset = "0x6D73BA0", VA = "0x186D747A0")]
	protected EAIFJEBAKPJ(HPHHCLPJOLD OIEGKBOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D746C0", Offset = "0x6D73AC0", VA = "0x186D746C0")]
	public void HLIBPABIPIM(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D74720", Offset = "0x6D73B20", VA = "0x186D74720")]
	protected void IGBGIMBHAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D74680", Offset = "0x6D73A80", VA = "0x186D74680")]
	public bool AONIPMIEBIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool KGLNNLGDAHB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool ABIIMJGBPKK(DECMEKNDOAL CDBLEJFCKMN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum OOMKPGAIABA
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HPKEPDBDGLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CNJKFPBKODA KLIAODBOMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int CDAANCJOJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MDANMOEKFFE DECENIHEMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint CMKMHHJCJBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OOMKPGAIABA KLAGANJLCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F2840", Offset = "0x9F1C40", VA = "0x1809F2840")]
		[CompilerGenerated]
		get
		{
			return default(OOMKPGAIABA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD2EED0", Offset = "0xD2E2D0", VA = "0x180D2EED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BB70", Offset = "0x6D7AF70", VA = "0x186D7BB70")]
	internal void BKGAPKPNMDB(MDANMOEKFFE KNCHPEGGFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BC30", Offset = "0x6D7B030", VA = "0x186D7BC30")]
	private bool GCEPOOKGDPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BC60", Offset = "0x6D7B060", VA = "0x186D7BC60")]
	internal HPKEPDBDGLL(IPEndPoint DAHIKICCCCL, MDANMOEKFFE HCGEKCKJNJF, CNJKFPBKODA FMFJELOACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BBD0", Offset = "0x6D7AFD0", VA = "0x186D7BBD0")]
	public HPHHCLPJOLD EPNKIHAGEIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NIOMLNIOFBE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KDNFPGINFMK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DCFLFEFDIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KDNFPGINFMK DBPGHLKJPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError FEBFGLOBCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public DFCHHHDHKPB MJIAGKKKMBB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BKJALBIBHJB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABJKMJGEIPD(HPHHCLPJOLD OIEGKBOHBKO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJBPMLFMHKN(HPHHCLPJOLD OIEGKBOHBKO, DCFLFEFDIJJ IPCPPPHJHIM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IADJAJADNNE(IPEndPoint ILJEIFNEHJN, SocketError LLOMMMEAOAB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJPCDKMHOGB(HPHHCLPJOLD OIEGKBOHBKO, DFCHHHDHKPB PABEDPKBAJJ, byte INIJAHMNNJC, HNMAIMNJJAH LODIIIHAHLJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPHCPGIGAKB(IPEndPoint DAHIKICCCCL, DFCHHHDHKPB PABEDPKBAJJ, NIOMLNIOFBE AMDMAMLIDJH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMHHOBPNFDP(HPHHCLPJOLD OIEGKBOHBKO, int GGKEEKADIMK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHNFHPIJMLF(HPKEPDBDGLL LFFAIMMKIAM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MCPFKMAEAEE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJFMPGDDHBB(HPHHCLPJOLD OIEGKBOHBKO, object ECFBCCAHJAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IAJKAJFOCCO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIAAOIDIPDP(LBIPADFKJLI CDBLEJFCKMN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NNACOCJGPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOKMPIONHEI(HPHHCLPJOLD OIEGKBOHBKO, IPEndPoint OOCMGIDJHAK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MDANMOEKFFE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int PBLDAPMMBKL = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long HDBKHFEAAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte MIFLMMABJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] PBOACDPLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GLAGCGMPGLD ODKGCMKKMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int HCCFOIEILBG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F8C0", Offset = "0x6D7ECC0", VA = "0x186D7F8C0")]
	private MDANMOEKFFE(long EPLOIIHMPOB, byte ANKCMICBLDF, int LAOCDNNIMLF, byte[] EIHFGNPJIFE, GLAGCGMPGLD AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F680", Offset = "0x6D7EA80", VA = "0x186D7F680")]
	public static int MKBAOOICCFI(DECMEKNDOAL CDBLEJFCKMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F460", Offset = "0x6D7E860", VA = "0x186D7F460")]
	public static MDANMOEKFFE AOMDIBAGPHI(DECMEKNDOAL CDBLEJFCKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F6E0", Offset = "0x6D7EAE0", VA = "0x186D7F6E0")]
	public static DECMEKNDOAL NFKMGIGADBG(MHEEFBCBLKL CHMHIDMFKBH, SocketAddress JPHGHHDCGDC, long OHKEFMNNIJI, int LAOCDNNIMLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HCEIIOOKBLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long HDBKHFEAAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte MIFLMMABJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int HCCFOIEILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool FMFCCHKOJCI;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D774E0", Offset = "0x6D768E0", VA = "0x186D774E0")]
	private HCEIIOOKBLI(long EPLOIIHMPOB, byte ANKCMICBLDF, int JPAMOANFEMJ, bool JGJCCGEAMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D771A0", Offset = "0x6D765A0", VA = "0x186D771A0")]
	public static HCEIIOOKBLI AOMDIBAGPHI(DECMEKNDOAL CDBLEJFCKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D773F0", Offset = "0x6D767F0", VA = "0x186D773F0")]
	public static DECMEKNDOAL NFKMGIGADBG(long OHKEFMNNIJI, byte FNNHOALJMJJ, int NHFOLAHIMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D772F0", Offset = "0x6D766F0", VA = "0x186D772F0")]
	public static DECMEKNDOAL GHEEOGLAMNH(HPHHCLPJOLD OIEGKBOHBKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum PHGPECEBMFP
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BOAIDACPDCF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DABOMDHOMLK(IPEndPoint KMFINDPBJKC, IPEndPoint DAHIKICCCCL, string PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJECHMBNAAG(IPEndPoint FHJLNKGOBHP, PHGPECEBMFP KHNCICOHHHJ, string PAHPIGHLKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EAOFFECOBIH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IAFBNAJOIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint KDLKGPPLJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint CMKMHHJCJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string BJEHHDHHFKA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct IPPCJBJIPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint ENCECFAHLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PHGPECEBMFP PLJKCMOLLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string BJEHHDHHFKA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class POECKIFDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint JCKOEOBACLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string BJEHHDHHFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public POECKIFDNGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class JBEOEGGMKKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint JCKOEOBACLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint PKMFJKFLGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string BJEHHDHHFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JBEOEGGMKKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class BNIFGMMIMJH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BJEHHDHHFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ICDIKKMCHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9CBEE0", Offset = "0x9CB2E0", VA = "0x1809CBEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BNIFGMMIMJH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly CNJKFPBKODA DMBPFDCGMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<IAFBNAJOIGL> DHMJKDKIAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<IPPCJBJIPDH> IBJDFAPADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GLAGCGMPGLD JGBDLEGPHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MHEEFBCBLKL PMOMJBNNAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CIGIHHOGHLL HGGMMONNOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private BOAIDACPDCF MMHCBIMBLDG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int MAGAJJFCFJB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool AJLNAAFFLHJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D74E50", Offset = "0x6D74250", VA = "0x186D74E50")]
	internal EAOFFECOBIH(CNJKFPBKODA JHPBGLFIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D74CD0", Offset = "0x6D740D0", VA = "0x186D74CD0")]
	internal void JEBFCPDFIMN(IPEndPoint BFCMJMBHPLF, DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35268E0", Offset = "0x3525CE0", VA = "0x1835268E0")]
	private void KEONIDJGMED<T>(T CDBLEJFCKMN, IPEndPoint EJCNBBIIFBE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D74840", Offset = "0x6D73C40", VA = "0x186D74840")]
	private void DABOMDHOMLK(POECKIFDNGM DFIDMOKLJAI, IPEndPoint BFCMJMBHPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D74B70", Offset = "0x6D73F70", VA = "0x186D74B70")]
	private void GNBMEGCKFIB(JBEOEGGMKKH DFIDMOKLJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D749D0", Offset = "0x6D73DD0", VA = "0x186D749D0")]
	private void FFLLOGOJNIO(BNIFGMMIMJH DFIDMOKLJAI, IPEndPoint BFCMJMBHPLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum HNMAIMNJJAH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KOLBPMMGEOK : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JFPEIBFFLKP
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] KAHPGLLMBMA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int NBHKNABBFLM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int IKAMJLEJBHN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GDHLNGGIHOO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D764C0", Offset = "0x6D758C0", VA = "0x186D764C0")]
	public GDHLNGGIHOO(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HDCBBDINBEC : GDHLNGGIHOO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D764C0", Offset = "0x6D758C0", VA = "0x186D764C0")]
	public HDCBBDINBEC(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CLCGGCIIKJF
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MBKPPGKODKM
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MALLBBMLPJD(CLCGGCIIKJF FNGDFPLAMIG, string EMIHGGEGHBP, params object[] KBIBHMCLJNL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NAHBHEFGEOG
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static MBKPPGKODKM PNIOBEMBHLE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object NJPGCBPHHAO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D80940", Offset = "0x6D7FD40", VA = "0x186D80940")]
	private static void PKCKHGDDCHC(CLCGGCIIKJF JHOJDDEJNAI, string EMIHGGEGHBP, params object[] KBIBHMCLJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D80880", Offset = "0x6D7FC80", VA = "0x186D80880")]
	internal static void ENNLIMHHPPG(string EMIHGGEGHBP, params object[] KBIBHMCLJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D80820", Offset = "0x6D7FC20", VA = "0x186D80820")]
	internal static void DCKDBPGIDBD(string EMIHGGEGHBP, params object[] KBIBHMCLJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D808E0", Offset = "0x6D7FCE0", VA = "0x186D808E0")]
	internal static void FJPPNPIHKPI(string EMIHGGEGHBP, params object[] KBIBHMCLJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum GMELMPBOAPJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DFCHHHDHKPB : GLAGCGMPGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private DECMEKNDOAL BOPHEHHIEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CNJKFPBKODA FBKJKKNJEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MNMMKIAGBID BMFAIEIBOPL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D744B0", Offset = "0x6D738B0", VA = "0x186D744B0")]
	internal DFCHHHDHKPB(CNJKFPBKODA BIGODBDFGBM, MNMMKIAGBID CEMDIHDCAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D74410", Offset = "0x6D73810", VA = "0x186D74410")]
	internal void NBLPFHPAFOB(DECMEKNDOAL CDBLEJFCKMN, int OPABBGFLMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D74390", Offset = "0x6D73790", VA = "0x186D74390")]
	internal void GPJAFACHFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D74480", Offset = "0x6D73880", VA = "0x186D74480")]
	public void NCPOJDPOODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MNMMKIAGBID
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GLELILGIOPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public MNMMKIAGBID GCFJBIFLLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public GLELILGIOPF PLJKCMOLLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public HPHHCLPJOLD BHOEHEMMBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint CMKMHHJCJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object KKFKIOIAMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int MOMGGGLBAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError FOLHDFACNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public KDNFPGINFMK GKHDGFJHKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public HPKEPDBDGLL GNGNCEDKFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public HNMAIMNJJAH PAKFDHPGDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte FFCFBENBOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly DFCHHHDHKPB HBFOAFOENPG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D80780", Offset = "0x6D7FB80", VA = "0x186D80780")]
	public MNMMKIAGBID(CNJKFPBKODA BIGODBDFGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CNJKFPBKODA : IEnumerable<HPHHCLPJOLD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class DBEBIPAJPHA : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D738A0", Offset = "0x6D72CA0", VA = "0x186D738A0", Slot = "4")]
		public bool Equals(IPEndPoint COBPEJEHIHC, IPEndPoint CEJJJCAALLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6902A50", Offset = "0x6901E50", VA = "0x186902A50", Slot = "5")]
		public int GetHashCode(IPEndPoint KLANNNFBLNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DBEBIPAJPHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct JLOALGGEPHA : IEnumerator<HPHHCLPJOLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly HPHHCLPJOLD IJLKOPFGDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private HPHHCLPJOLD MJGFNMAOBAA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HPHHCLPJOLD CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD5AA00", Offset = "0xD59E00", VA = "0x180D5AA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD5AA00", Offset = "0xD59E00", VA = "0x180D5AA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x195E650", Offset = "0x195DA50", VA = "0x18195E650")]
		public JLOALGGEPHA(HPHHCLPJOLD OHELNHAJILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C1D0", Offset = "0x6D7B5D0", VA = "0x186D7C1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C220", Offset = "0x6D7B620", VA = "0x186D7C220", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread BOCDOCEHFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool CLCLPGGHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool BLMBFDEEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JHIJBPDLCNJ IKFAEBBMLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent PGBHMKLALBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<MNMMKIAGBID> EHHJJCKBGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<MNMMKIAGBID> NBGIAIIABML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MNMMKIAGBID LBMLJACFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BKJALBIBHJB FOHHEKLOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MCPFKMAEAEE EIKGHHKFKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IAJKAJFOCCO ECEIEHECICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NNACOCJGPLB MNCDEFFIMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, HPHHCLPJOLD> HMAKADKGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, HPKEPDBDGLL> DHDLEEFCCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, ODIHAFNBANL> KGNBJJDNGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim HOEMCBOMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private HPHHCLPJOLD MEMJHEONCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int PGNCLFJFOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<HPHHCLPJOLD> JEPPPEHMMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HPHHCLPJOLD[] EMOOIEECCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PPAONDBGLIE ELEKCGOJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int HKCOPLLKBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> ECENJLJMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte CKDDHLIOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object NLMLBJHIKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool POAOAFFDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool EGLAHPEMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int KMHIHNJNOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CJBMJOEBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HLDBKEFCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int JHKDNDNMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool GPIKFMEFLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EANNJOGGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int MJPPCIHEGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int HAELAHCIIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int IMAHNAICPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool AJLNAAFFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool JNJABFCPNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool KHFCLOLMGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool LNKGAPGAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int ILLNJPAIIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int MDLOFPMINDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool GKACJPPOHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly DBBAIHLALPO DFDMHLJIJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PMFBFPEJIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly EAOFFECOBIH DDHFNOLDDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MDLEAGMGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public GMELMPBOAPJ CCBMFCCGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int HJHKPFKFCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool IMKEEMBALOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool LNLNAPPFPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool HGOOOCJOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool DJKFMNNHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private DECMEKNDOAL PPKKIOACDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int HJBIKDEHJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object BEIBBOKODLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DECMEKNDOAL PPLLIEEFLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int IPDCECPOFLE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int HFDALHHBECE = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int OPOKPFPEHHC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private CHGLDGAEBIM OMDNDKOOEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private CHGLDGAEBIM AEMKOCFMFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread ECLJMKMAJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread OGGJBBKDNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint AJMEDBKOJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint OOHOFJHEDPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] GFMBKCPKEHB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] PPEFCCJGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<INKBHKHHCHN, IPEndPoint> NDGBMNFNDKG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress EGPMKAPMOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool PNGNLGHOPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int GJDFGIGHDJE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BEKLNNHOMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x13C68C0", Offset = "0x13C5CC0", VA = "0x1813C68C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1DBCD40", Offset = "0x1DBC140", VA = "0x181DBCD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BEIMGMKANEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x14CFC50", Offset = "0x14CF050", VA = "0x1814CFC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DBCE30", Offset = "0x1DBC230", VA = "0x181DBCE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte MODGADCGMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xED1800", Offset = "0xED0C00", VA = "0x180ED1800")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EGJJDKMLFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B620", Offset = "0x6D6AA20", VA = "0x186D6B620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short KNPLMIGKLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C520", Offset = "0x6D6B920", VA = "0x186D6C520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C8C0", Offset = "0x6D6BCC0", VA = "0x186D6C8C0")]
	public void DCOBPNHNPCF(IPEndPoint ILJEIFNEHJN, byte[] IICGAABOENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B4D0", Offset = "0x6D6A8D0", VA = "0x186D6B4D0")]
	public void AJOBKHENDBI(IPEndPoint ILJEIFNEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F0D0", Offset = "0x6D6E4D0", VA = "0x186D6F0D0")]
	private bool JANDBGGABHE(IPEndPoint ILJEIFNEHJN, [Out] HPHHCLPJOLD OIEGKBOHBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D711E0", Offset = "0x6D705E0", VA = "0x186D711E0")]
	private void MCPOMEAINJF(HPHHCLPJOLD OIEGKBOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E9F0", Offset = "0x6D6DDF0", VA = "0x186D6E9F0")]
	private void GEBCFIEAAFN(HPHHCLPJOLD OIEGKBOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F170", Offset = "0x6D6E570", VA = "0x186D6F170")]
	private void JANPPNENLMB(HPHHCLPJOLD OIEGKBOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D72A40", Offset = "0x6D71E40", VA = "0x186D72A40")]
	public CNJKFPBKODA(BKJALBIBHJB FMFJELOACJF, [Optional] PPAONDBGLIE IKNDAMAENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D71190", Offset = "0x6D70590", VA = "0x186D71190")]
	internal void LCCGIKDLPNE(HPHHCLPJOLD CBFDJGFMJLL, int GGKEEKADIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DED0", Offset = "0x6D6D2D0", VA = "0x186D6DED0")]
	internal void DPDBDPNAKIA(HPHHCLPJOLD CBFDJGFMJLL, object ECFBCCAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C4E0", Offset = "0x6D6B8E0", VA = "0x186D6C4E0")]
	internal void CHKPFBJGLDA(HPHHCLPJOLD OIEGKBOHBKO, KDNFPGINFMK HJCCPGPOLBJ, SocketError EMODAGPKJDJ, DECMEKNDOAL NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D70510", Offset = "0x6D6F910", VA = "0x186D70510")]
	private void LBGLAJLBMGL(HPHHCLPJOLD OIEGKBOHBKO, KDNFPGINFMK HJCCPGPOLBJ, SocketError EMODAGPKJDJ, bool IMJBLFBLNHJ, byte[] AOFGGGKINCN, int KAHCMHKHPHM, int PCGLBCNIEAP, DECMEKNDOAL NIIPCCMNFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D717C0", Offset = "0x6D70BC0", VA = "0x186D717C0")]
	private void MJCNKFBFBMM(MNMMKIAGBID.GLELILGIOPF KHNCICOHHHJ, [Optional] HPHHCLPJOLD OIEGKBOHBKO, [Optional] IPEndPoint DAHIKICCCCL, SocketError HJPLLMGICPE = SocketError.Success, int GGKEEKADIMK = 0, KDNFPGINFMK BPCIPIHLHKI = KDNFPGINFMK.ConnectionFailed, [Optional] HPKEPDBDGLL HPNHNLHHADM, HNMAIMNJJAH LODIIIHAHLJ = HNMAIMNJJAH.Unreliable, byte INIJAHMNNJC = 0, [Optional] DECMEKNDOAL JGPCGKBBONI, [Optional] object ECFBCCAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D71BA0", Offset = "0x6D70FA0", VA = "0x186D71BA0")]
	private void OHPMFJBOKCC(MNMMKIAGBID CEMDIHDCAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D6ECA0", Offset = "0x6D6E0A0", VA = "0x186D6ECA0")]
	internal void HJNOMJJONGO(MNMMKIAGBID CEMDIHDCAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D72360", Offset = "0x6D71760", VA = "0x186D72360")]
	private void PHOFCMIBOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EDB0", Offset = "0x6D6E1B0", VA = "0x186D6EDB0")]
	private void IOOGOEBDFLA(int ABBIJDFKMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BEC0", Offset = "0x6D6B2C0", VA = "0x186D6BEC0")]
	internal HPHHCLPJOLD CFOADNEGABB(HPKEPDBDGLL LFFAIMMKIAM, byte[] AFPLFFJHICF, int KAHCMHKHPHM, int CFKBLDHNBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F9E0", Offset = "0x6D6EDE0", VA = "0x186D6F9E0")]
	private int KJICMCKKAAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DF20", Offset = "0x6D6D320", VA = "0x186D6DF20")]
	private void EAFPLDCMGMC(IPEndPoint DAHIKICCCCL, HPHHCLPJOLD DPFFGNEKFGD, MDANMOEKFFE NBPPFCEAIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CAE0", Offset = "0x6D6BEE0", VA = "0x186D6CAE0")]
	private void DLDHDFOFAND(DECMEKNDOAL CDBLEJFCKMN, IPEndPoint DAHIKICCCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C5E0", Offset = "0x6D6B9E0", VA = "0x186D6C5E0")]
	internal void CKKLEFDJEFO(DECMEKNDOAL CDBLEJFCKMN, HNMAIMNJJAH ECNMMLALMGP, byte INIJAHMNNJC, int OPABBGFLMDF, HPHHCLPJOLD CBFDJGFMJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B640", Offset = "0x6D6AA40", VA = "0x186D6B640")]
	public bool BOFHKCJPDLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B650", Offset = "0x6D6AA50", VA = "0x186D6B650")]
	public bool BOFHKCJPDLE(IPAddress MEALNEDJHKC, IPAddress HGCPEFGAAKO, int NELIGLJDGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BE40", Offset = "0x6D6B240", VA = "0x186D6BE40")]
	public bool BOFHKCJPDLE(int NELIGLJDGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D726B0", Offset = "0x6D71AB0", VA = "0x186D726B0")]
	public void PLDJLICHBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FF20", Offset = "0x6D6F320", VA = "0x186D6FF20")]
	public HPHHCLPJOLD KMBGCNMHCDI(string DAKGFMMPBKB, int NELIGLJDGIK, string IICGAABOENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FE40", Offset = "0x6D6F240", VA = "0x186D6FE40")]
	public HPHHCLPJOLD KMBGCNMHCDI(string DAKGFMMPBKB, int NELIGLJDGIK, MHEEFBCBLKL LDOGJGOGCHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FA60", Offset = "0x6D6EE60", VA = "0x186D6FA60")]
	public HPHHCLPJOLD KMBGCNMHCDI(IPEndPoint EJCNBBIIFBE, MHEEFBCBLKL LDOGJGOGCHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D704C0", Offset = "0x6D6F8C0", VA = "0x186D704C0")]
	public void KPIGIAJPEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D70160", Offset = "0x6D6F560", VA = "0x186D70160")]
	public void KPIGIAJPEDM(bool KDHBKFNIJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B420", Offset = "0x6D6A820", VA = "0x186D6B420")]
	public void AFNJLGGMAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B350", Offset = "0x6D6A750", VA = "0x186D6B350")]
	public void AFNJLGGMAIP(byte[] AOFGGGKINCN, int KAHCMHKHPHM, int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D70930", Offset = "0x6D6FD30", VA = "0x186D70930")]
	public void LBGLAJLBMGL(HPHHCLPJOLD OIEGKBOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D704D0", Offset = "0x6D6F8D0", VA = "0x186D704D0")]
	public void LBGLAJLBMGL(HPHHCLPJOLD OIEGKBOHBKO, byte[] AOFGGGKINCN, int KAHCMHKHPHM, int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D72860", Offset = "0x6D71C60", VA = "0x186D72860", Slot = "4")]
	private IEnumerator<HPHHCLPJOLD> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D728F0", Offset = "0x6D71CF0", VA = "0x186D728F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E6A0", Offset = "0x6D6DAA0", VA = "0x186D6E6A0")]
	private DECMEKNDOAL EPIEGKBCOOP(KODIEABABFD EKNPKHOHCLO, int LLBNOFGPNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E790", Offset = "0x6D6DB90", VA = "0x186D6E790")]
	private DECMEKNDOAL EPIEGKBCOOP(KODIEABABFD EKNPKHOHCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EA50", Offset = "0x6D6DE50", VA = "0x186D6EA50")]
	internal DECMEKNDOAL HBOKJKLAFJO(int LLBNOFGPNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D71550", Offset = "0x6D70950", VA = "0x186D71550")]
	internal void MHNADBJLFDC(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D72980", Offset = "0x6D71D80", VA = "0x186D72980")]
	static CNJKFPBKODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x13C68C0", Offset = "0x13C5CC0", VA = "0x1813C68C0")]
	private bool CAKAJLHCMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B1D0", Offset = "0x6D6A5D0", VA = "0x186D6B1D0")]
	private void AAENPFHBCHA(IPEndPoint BMPKPNNCCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D70000", Offset = "0x6D6F400", VA = "0x186D70000")]
	private void KOGDIKDFDEH(IPEndPoint BMPKPNNCCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F830", Offset = "0x6D6EC30", VA = "0x186D6F830")]
	private bool KJFGJLPGDJF(SocketException CCEMNOMFFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D71530", Offset = "0x6D70930", VA = "0x186D71530")]
	private void MDLLGFANOPO(JHIJBPDLCNJ JHPBGLFIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E3D0", Offset = "0x6D6D7D0", VA = "0x186D6E3D0")]
	private void EPIDGLHKHJN(CHGLDGAEBIM JHPBGLFIFNC, EndPoint KMILCPLIBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F440", Offset = "0x6D6E840", VA = "0x186D6F440")]
	private void JKEEKAIEONI(object FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B670", Offset = "0x6D6AA70", VA = "0x186D6B670")]
	public bool BOFHKCJPDLE(IPAddress MEALNEDJHKC, IPAddress HGCPEFGAAKO, int NELIGLJDGIK, bool OEDHMHJBAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F7D0", Offset = "0x6D6EBD0", VA = "0x186D6F7D0")]
	internal int KDGDCPBKDNN(DECMEKNDOAL CDBLEJFCKMN, IPEndPoint DAHIKICCCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D70970", Offset = "0x6D6FD70", VA = "0x186D70970")]
	internal int LBIJDHMJIBA(DECMEKNDOAL CDBLEJFCKMN, IPEndPoint DAHIKICCCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D709B0", Offset = "0x6D6FDB0", VA = "0x186D709B0")]
	internal int LBIJDHMJIBA(byte[] FGEBHLNNMNH, int KAHCMHKHPHM, int CFKBLDHNBAA, IPEndPoint DAHIKICCCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E870", Offset = "0x6D6DC70", VA = "0x186D6E870")]
	internal void FPHDIEOGABN(bool NCDPHGFFKGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum KODIEABABFD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class DECMEKNDOAL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int GFIBKBIFKMD;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] FEDDCEDKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] DPDMHHAIFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int JFMOMNOKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object KKFKIOIAMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public DECMEKNDOAL GCFJBIFLLLA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KODIEABABFD NIAHJHIDLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D73CF0", Offset = "0x6D730F0", VA = "0x186D73CF0")]
		get
		{
			return default(KODIEABABFD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D73AC0", Offset = "0x6D72EC0", VA = "0x186D73AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MIFLMMABJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D73E90", Offset = "0x6D73290", VA = "0x186D73E90")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D73950", Offset = "0x6D72D50", VA = "0x186D73950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort DDGDIGJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D73C30", Offset = "0x6D73030", VA = "0x186D73C30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D739C0", Offset = "0x6D72DC0", VA = "0x186D739C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KNHCGKPKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D73C00", Offset = "0x6D73000", VA = "0x186D73C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LHFKNCGOPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D73990", Offset = "0x6D72D90", VA = "0x186D73990")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D73E60", Offset = "0x6D73260", VA = "0x186D73E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CKAEPCGCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D73A60", Offset = "0x6D72E60", VA = "0x186D73A60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D73910", Offset = "0x6D72D10", VA = "0x186D73910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JLDFLBBOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D73A00", Offset = "0x6D72E00", VA = "0x186D73A00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D73EF0", Offset = "0x6D732F0", VA = "0x186D73EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort KFGGJIDJMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D73C90", Offset = "0x6D73090", VA = "0x186D73C90")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D73E20", Offset = "0x6D73220", VA = "0x186D73E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D73F30", Offset = "0x6D73330", VA = "0x186D73F30")]
	static DECMEKNDOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D73EC0", Offset = "0x6D732C0", VA = "0x186D73EC0")]
	public void OJKMMLPCIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D74320", Offset = "0x6D73720", VA = "0x186D74320")]
	public DECMEKNDOAL(int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D74210", Offset = "0x6D73610", VA = "0x186D74210")]
	public DECMEKNDOAL(KODIEABABFD EKNPKHOHCLO, int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D73DB0", Offset = "0x6D731B0", VA = "0x186D73DB0")]
	public static int MINHKFBLIEM(KODIEABABFD EKNPKHOHCLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D73D20", Offset = "0x6D73120", VA = "0x186D73D20")]
	public int MINHKFBLIEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D73B00", Offset = "0x6D72F00", VA = "0x186D73B00")]
	public bool JGONPCIILBP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum AMEIGOOCPHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal enum AJMELELNPDL
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum EENFLPPEOIC
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum KPCCHLCPJBD
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HPHHCLPJOLD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NEBKNDCLIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DECMEKNDOAL[] GBEPNHOOENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int AOOMPBKLJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int EDBONJDLMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte LHFKNCGOPIE;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NEBKNDCLIPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void FEKHNIBMEHM(ulong NKLFFHDBNFO, int IDGFJPPCPAJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int MPBPLGLNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int KBELJKGNMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int FPOHAOCKDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double JAJIAMKAOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FJMKEPOIEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int OBEMBICCBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int GBLEEMBJJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch BLLPDDNCGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int OMEPMHENOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long CNKKNKLKGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object FBMOJGNGNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal HPHHCLPJOLD OAHAPAICNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal HPHHCLPJOLD MPOEHANDBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<DECMEKNDOAL> IFFFFBIHEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<EAIFJEBAKPJ> DJBPKLJBJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly EAIFJEBAKPJ[] KOBFEOADIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int IEPOCHFAFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int MKOKEMBBOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool HFPABEKOEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int MGGEIEFJHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int HPMPHKDBHFF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int JPFPCMPDOML = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int ECBBOMPEDKK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object EJPPJNNNHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int FIOLPMLIJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, NEBKNDCLIPG> GBIEKJGOMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> AHFNLJJAIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly DECMEKNDOAL MEDFOPFGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int GECKAGPNMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GINBECKPEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint EJCBFNGMKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int KDNJEMFANGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int OGMBGAELENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long PCBMICHGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte ILBIKHPLIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private AMEIGOOCPHE IOPLNPNLFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private DECMEKNDOAL BONCFLIIEJN;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int BHPLADBDGBG = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int KFHILMHJAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly DECMEKNDOAL MCFBCKPEBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly DECMEKNDOAL LPKDECPBKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly DECMEKNDOAL LODEJEGELDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly DECMEKNDOAL EFIKPJNIOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private KOLBPMMGEOK DHAMFBKFNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CNJKFPBKODA FBHKKILNNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int NKGPMMKCOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object FHOJKPJGHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly DBBAIHLALPO DFDMHLJIJDH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte EBKODMPIAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA673B0", Offset = "0xA667B0", VA = "0x180A673B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D7AD80", Offset = "0x6D7A180", VA = "0x186D7AD80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DANDMDNOHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC85E40", Offset = "0xC85240", VA = "0x180C85E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AMEIGOOCPHE GFBPNOIPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB5D0E0", Offset = "0xB5C4E0", VA = "0x180B5D0E0")]
		get
		{
			return default(AMEIGOOCPHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HPOGPMALGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9D3EB0", Offset = "0x9D32B0", VA = "0x1809D3EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JIBGMKFKOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x14CFC20", Offset = "0x14CF020", VA = "0x1814CFC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DBCDC0", Offset = "0x1DBC1C0", VA = "0x181DBCDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int GAJJNBAGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D7AC10", Offset = "0x6D7A010", VA = "0x186D7AC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HAELHOENPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9DA090", Offset = "0x9D9490", VA = "0x1809DA090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BBENCFBGEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5484E20", Offset = "0x5484220", VA = "0x185484E20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FEKHNIBMEHM FFMAHGGGCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D78470", Offset = "0x6D77870", VA = "0x186D78470")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A210", Offset = "0x6D79610", VA = "0x186D7A210")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B580", Offset = "0x6D7A980", VA = "0x186D7B580")]
	internal HPHHCLPJOLD(CNJKFPBKODA JJFHEKHDDOA, IPEndPoint DAHIKICCCCL, int FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D791F0", Offset = "0x6D785F0", VA = "0x186D791F0")]
	internal void GMLDHDHDOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ACF0", Offset = "0x6D7A0F0", VA = "0x186D7ACF0")]
	internal void MOGPBBJJJFP(IPEndPoint OJFDPLNOPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D78C20", Offset = "0x6D78020", VA = "0x186D78C20")]
	internal void ECKDKHCJMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AC20", Offset = "0x6D7A020", VA = "0x186D7AC20")]
	private void MGKJKMHPOJK(int LJHDKHMDBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D79BB0", Offset = "0x6D78FB0", VA = "0x186D79BB0")]
	private void HFEJCICJBAO(int HCGINNOMIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D78520", Offset = "0x6D77920", VA = "0x186D78520")]
	private EAIFJEBAKPJ BPCLCLIEHKD(byte MLHFFBNEEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B9E0", Offset = "0x6D7ADE0", VA = "0x186D7B9E0")]
	internal HPHHCLPJOLD(CNJKFPBKODA JJFHEKHDDOA, IPEndPoint DAHIKICCCCL, int FBLIJIPJKFJ, byte FNNHOALJMJJ, MHEEFBCBLKL CHMHIDMFKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B3A0", Offset = "0x6D7A7A0", VA = "0x186D7B3A0")]
	internal HPHHCLPJOLD(CNJKFPBKODA JJFHEKHDDOA, HPKEPDBDGLL LFFAIMMKIAM, int FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A9B0", Offset = "0x6D79DB0", VA = "0x186D7A9B0")]
	internal void LGHBAPFGJCG(MDANMOEKFFE AJJFMCDIAOP, byte[] AOFGGGKINCN, int KAHCMHKHPHM, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A150", Offset = "0x6D79550", VA = "0x186D7A150")]
	internal bool IDDEFOHPMGB(HCEIIOOKBLI CDBLEJFCKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A2C0", Offset = "0x6D796C0", VA = "0x186D7A2C0")]
	public void KEONIDJGMED(byte[] AOFGGGKINCN, int KAHCMHKHPHM, int CFKBLDHNBAA, HNMAIMNJJAH EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D79BF0", Offset = "0x6D78FF0", VA = "0x186D79BF0")]
	private void HNOAFCCKJFG(byte[] AOFGGGKINCN, int KAHCMHKHPHM, int CFKBLDHNBAA, byte INIJAHMNNJC, HNMAIMNJJAH LODIIIHAHLJ, object ECFBCCAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D78160", Offset = "0x6D77560", VA = "0x186D78160")]
	public void ACFOIMKMFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D79110", Offset = "0x6D78510", VA = "0x186D79110")]
	internal EENFLPPEOIC GICJEBJDHEM(DECMEKNDOAL CDBLEJFCKMN)
	{
		return default(EENFLPPEOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AD20", Offset = "0x6D7A120", VA = "0x186D7AD20")]
	internal void NKMHHAJEEIJ(EAIFJEBAKPJ OLFIPCFIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D78CB0", Offset = "0x6D780B0", VA = "0x186D78CB0")]
	internal KPCCHLCPJBD FIMLLKDDKLB(byte[] AOFGGGKINCN, int KAHCMHKHPHM, int CFKBLDHNBAA, bool IMJBLFBLNHJ)
	{
		return default(KPCCHLCPJBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A1D0", Offset = "0x6D795D0", VA = "0x186D7A1D0")]
	private void IOAGFMDFHHJ(int GNNPPKGFIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D79210", Offset = "0x6D78610", VA = "0x186D79210")]
	internal void GPEPHGPMNHA(HNMAIMNJJAH ECNMMLALMGP, DECMEKNDOAL OHELNHAJILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AE30", Offset = "0x6D7A230", VA = "0x186D7AE30")]
	private void PCGAPFMDPIJ(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D786D0", Offset = "0x6D77AD0", VA = "0x186D786D0")]
	private void CCKFFKNMMNC(int KMHBKELIILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D78A60", Offset = "0x6D77E60", VA = "0x186D78A60")]
	internal AJMELELNPDL EAFPLDCMGMC(MDANMOEKFFE NBPPFCEAIOC)
	{
		return default(AJMELELNPDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D77AA0", Offset = "0x6D76EA0", VA = "0x186D77AA0")]
	internal void ABIIMJGBPKK(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D78FC0", Offset = "0x6D783C0", VA = "0x186D78FC0")]
	private void FOEMEEFNLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AA00", Offset = "0x6D79E00", VA = "0x186D7AA00")]
	internal void LNJHBGJAGHK(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A2F0", Offset = "0x6D796F0", VA = "0x186D7A2F0")]
	internal void LFKOACHICEI(int KMHBKELIILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D781B0", Offset = "0x6D775B0", VA = "0x186D781B0")]
	internal void AEGGBJMDOEL(DECMEKNDOAL CDBLEJFCKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DBBAIHLALPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long IGHPHDLENKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long FJDFEDAPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long LAKDJCJIKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long BJKJFDIEEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long HKPAIPBAPHL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long JBLKDGBFMCD;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long DKFOKCMOPPI;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long HJNFPENDJPC;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long PHCMKGFHEPA;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long KOPFIFGDOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long COFHAHFPFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long OPCPAKMOKLH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LADIMNDCBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D73320", Offset = "0x6D72720", VA = "0x186D73320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long MCDOIHBEGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D73490", Offset = "0x6D72890", VA = "0x186D73490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long HLEDLHFCPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D732B0", Offset = "0x6D726B0", VA = "0x186D732B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KLAJDEMIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D732A0", Offset = "0x6D726A0", VA = "0x186D732A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BENNDHJMLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D730A0", Offset = "0x6D724A0", VA = "0x186D730A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long BEHFLMAMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D731D0", Offset = "0x6D725D0", VA = "0x186D731D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long MKOCFKOCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D73120", Offset = "0x6D72520", VA = "0x186D73120")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long COHMIDJMMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D73330", Offset = "0x6D72730", VA = "0x186D73330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KOLBPMMGEOK OOKDDJHPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D73370", Offset = "0x6D72770", VA = "0x186D73370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double FNNPOBNCLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D731E0", Offset = "0x6D725E0", VA = "0x186D731E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D73380", Offset = "0x6D72780", VA = "0x186D73380")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D732C0", Offset = "0x6D726C0", VA = "0x186D732C0")]
	public void FPLIDDELAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D733C0", Offset = "0x6D727C0", VA = "0x186D733C0")]
	public void JKHGGBCOOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D730B0", Offset = "0x6D724B0", VA = "0x186D730B0")]
	public void BAAIOFCLFIL(long GFJFODGFDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D73160", Offset = "0x6D72560", VA = "0x186D73160")]
	public void DAODFEMPBLE(long PKJOCLDKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D73240", Offset = "0x6D72640", VA = "0x186D73240")]
	public void EKOOIPAOFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D73410", Offset = "0x6D72810", VA = "0x186D73410")]
	public void LPFPBOJLGOJ(long EHFAEBIFAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D73540", Offset = "0x6D72940", VA = "0x186D73540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D734A0", Offset = "0x6D728A0", VA = "0x186D734A0")]
	public void PPHIEDCAJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DBBAIHLALPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HDGJMHOCECM
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> IEIKOAFHGJO;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D77790", Offset = "0x6D76B90", VA = "0x186D77790")]
	public static IPEndPoint MBDINLHMHHB(string OFFEAIKGPND, int NELIGLJDGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D77530", Offset = "0x6D76930", VA = "0x186D77530")]
	public static IPAddress KILEJGFENNM(string OFFEAIKGPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D77700", Offset = "0x6D76B00", VA = "0x186D77700")]
	public static IPAddress KILEJGFENNM(string OFFEAIKGPND, AddressFamily MBDFFFAJIIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D779E0", Offset = "0x6D76DE0", VA = "0x186D779E0")]
	internal static int MEEENLHIGJE(int NMEIAFHCHBI, int FLPHAKFDHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3700280", Offset = "0x36FF680", VA = "0x183700280")]
	internal static T[] HLIOBLDAEHF<T>(int PCGLBCNIEAP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EGIIHBIAICF : EAIFJEBAKPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DHDCEBFAPOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private DECMEKNDOAL BOPHEHHIEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long BDDDBACMLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool BFKGMCGNBEO;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D745E0", Offset = "0x6D739E0", VA = "0x186D745E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D74550", Offset = "0x6D73950", VA = "0x186D74550")]
		public void HGEPFBBIJLL(DECMEKNDOAL CDBLEJFCKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D74570", Offset = "0x6D73970", VA = "0x186D74570")]
		public bool JDOJDGMFKAG(long NFJHHAIAPEL, HPHHCLPJOLD OIEGKBOHBKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D74500", Offset = "0x6D73900", VA = "0x186D74500")]
		public bool ENAIKFMHAAL(HPHHCLPJOLD OIEGKBOHBKO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DECMEKNDOAL LIFCCCJEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly DHDCEBFAPOO[] HNCNJJFEIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly DECMEKNDOAL[] FMEKDOCPFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] DKHEDMJFBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int EDDDEDOFDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int KGBPOKOLOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int JGGKLBBHODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int PHFDLHJABOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool EBPBJNOHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly HNMAIMNJJAH FIKMGOCBJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool MPDIMGHJGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int DDAPNACCHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte GHKAPDDELMF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D76190", Offset = "0x6D75590", VA = "0x186D76190")]
	public EGIIHBIAICF(HPHHCLPJOLD OIEGKBOHBKO, bool HNAOCKJGPFK, byte FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D75900", Offset = "0x6D74D00", VA = "0x186D75900")]
	private void EEMLICBHOAL(DECMEKNDOAL CDBLEJFCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D75CC0", Offset = "0x6D750C0", VA = "0x186D75CC0", Slot = "4")]
	protected override bool KGLNNLGDAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D752A0", Offset = "0x6D746A0", VA = "0x186D752A0", Slot = "5")]
	public override bool ABIIMJGBPKK(DECMEKNDOAL CDBLEJFCKMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NLHHHHNGDOE : EAIFJEBAKPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int ELOFCILKMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort KGBPOKOLOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool LHFHALDNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private DECMEKNDOAL JHMFFCIJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly DECMEKNDOAL LNEEPKAMGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool LNCFCGEFHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte GHKAPDDELMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long MGFNNOMEIPI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D813C0", Offset = "0x6D807C0", VA = "0x186D813C0")]
	public NLHHHHNGDOE(HPHHCLPJOLD OIEGKBOHBKO, bool HNOFEAAHHDC, byte FBLIJIPJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D80F00", Offset = "0x6D80300", VA = "0x186D80F00", Slot = "4")]
	protected override bool KGLNNLGDAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D80C20", Offset = "0x6D80020", VA = "0x186D80C20", Slot = "5")]
	public override bool ABIIMJGBPKK(DECMEKNDOAL CDBLEJFCKMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EIHLEHCHNNC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct CALEPIAACEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong JJBBKOPPHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double JEJKGEINBOH;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct MBBADDHGPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int EEICFEOJPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float IFBEJHKHGNN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D69530", Offset = "0x6D68930", VA = "0x186D69530")]
	private static void PJPNINMALKO(byte[] HDBNDELHALH, int IALPEJIGIPD, ulong AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D76360", Offset = "0x6D75760", VA = "0x186D76360")]
	private static void PJPNINMALKO(byte[] HDBNDELHALH, int IALPEJIGIPD, int AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D76480", Offset = "0x6D75880", VA = "0x186D76480")]
	public static void PJPNINMALKO(byte[] HDBNDELHALH, int IALPEJIGIPD, short AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D76460", Offset = "0x6D75860", VA = "0x186D76460")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, double OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D763E0", Offset = "0x6D757E0", VA = "0x186D763E0")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6D76480", Offset = "0x6D75880", VA = "0x186D76480")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, short OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D76480", Offset = "0x6D75880", VA = "0x186D76480")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, ushort OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D76360", Offset = "0x6D75760", VA = "0x186D76360")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6D76360", Offset = "0x6D75760", VA = "0x186D76360")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, uint OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6D763D0", Offset = "0x6D757D0", VA = "0x186D763D0")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, long OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D763D0", Offset = "0x6D757D0", VA = "0x186D763D0")]
	public static void LNILNNAGBFD(byte[] FLIFCMNPFIN, int NHKONNPHPEL, ulong OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GLAGCGMPGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] JJMDGJOCOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int CLOFOOKJEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int OAHHPLAGBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int AGDINJIPHOE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] DPDMHHAIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GBOICNMGODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BDJBDOJAEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D765F0", Offset = "0x6D759F0", VA = "0x186D765F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EKNINJLKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x25FD840", Offset = "0x25FCC40", VA = "0x1825FD840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FJNDEKCLKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D765A0", Offset = "0x6D759A0", VA = "0x186D765A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D77100", Offset = "0x6D76500", VA = "0x186D77100")]
	public void NBLPFHPAFOB(byte[] ILNONAAFECI, int IALPEJIGIPD, int HNMIGALEMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public GLAGCGMPGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D77140", Offset = "0x6D76540", VA = "0x186D77140")]
	public GLAGCGMPGLD(byte[] ILNONAAFECI, int IALPEJIGIPD, int HNMIGALEMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D76F70", Offset = "0x6D76370", VA = "0x186D76F70")]
	public IPEndPoint LOIONOHKLID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D76840", Offset = "0x6D75C40", VA = "0x186D76840")]
	public byte DAIGNCOPLCA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D76840", Offset = "0x6D75C40", VA = "0x186D76840")]
	public sbyte GCKJKICFCDE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x36AA2A0", Offset = "0x36A96A0", VA = "0x1836AA2A0")]
	public T[] OFEKHLIAOKA<T>(ushort LLBNOFGPNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D76880", Offset = "0x6D75C80", VA = "0x186D76880")]
	public bool[] DNPALDMPABL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D76A00", Offset = "0x6D75E00", VA = "0x186D76A00")]
	public ushort[] GCGNLOEEFLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D77040", Offset = "0x6D76440", VA = "0x186D77040")]
	public short[] MAOAEHAILGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D768C0", Offset = "0x6D75CC0", VA = "0x186D768C0")]
	public int[] EFGOGINMMBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D76E80", Offset = "0x6D76280", VA = "0x186D76E80")]
	public uint[] KCJBIFLFJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D76DD0", Offset = "0x6D761D0", VA = "0x186D76DD0")]
	public float[] HPDABIAAHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D76D90", Offset = "0x6D76190", VA = "0x186D76D90")]
	public double[] HPCGIAIBEGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D77080", Offset = "0x6D76480", VA = "0x186D77080")]
	public long[] MLOKGEICMBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D76C70", Offset = "0x6D76070", VA = "0x186D76C70")]
	public ulong[] HAMINMNELNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D76AB0", Offset = "0x6D75EB0", VA = "0x186D76AB0")]
	public string[] GMFFAECMMLI(int FBAJIAFLNEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D770C0", Offset = "0x6D764C0", VA = "0x186D770C0")]
	public bool MPMKMAFNJFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D76920", Offset = "0x6D75D20", VA = "0x186D76920")]
	public char FJKOBIMCPIF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D76920", Offset = "0x6D75D20", VA = "0x186D76920")]
	public ushort OAFDKCGJLAG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D76E10", Offset = "0x6D76210", VA = "0x186D76E10")]
	public short KBIDILDDBCA()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6D76990", Offset = "0x6D75D90", VA = "0x186D76990")]
	public long FOMNENMCAKF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6D76D20", Offset = "0x6D76120", VA = "0x186D76D20")]
	public ulong HMLLJAGCPOO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6D76C00", Offset = "0x6D76000", VA = "0x186D76C00")]
	public int GPAHOIIPCJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D76A40", Offset = "0x6D75E40", VA = "0x186D76A40")]
	public uint GIPGFMHBALE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6D76530", Offset = "0x6D75930", VA = "0x186D76530")]
	public float AJJJLCHIKIH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6D76CB0", Offset = "0x6D760B0", VA = "0x186D76CB0")]
	public double HIEDIMFLJKE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D76600", Offset = "0x6D75A00", VA = "0x186D76600")]
	public string CJAGICHEPKP(int CMOFODPGFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6D76EC0", Offset = "0x6D762C0", VA = "0x186D76EC0")]
	public ArraySegment<byte> LEPFHPDPDDN(int PCGLBCNIEAP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6D765B0", Offset = "0x6D759B0", VA = "0x186D765B0")]
	public sbyte[] BINIKGPCHLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6D76F30", Offset = "0x6D76330", VA = "0x186D76F30")]
	public byte[] LJJPKGKPKDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6D76900", Offset = "0x6D75D00", VA = "0x186D76900")]
	public void ENAIKFMHAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MHEEFBCBLKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] JJMDGJOCOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int CLOFOOKJEDI;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int HAENLCKEHHM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool AHHKNDDFKBH;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding PHFGJONNGBN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int GJJBOKJPCJH = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] GFFCAIHAJGB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] ODKGCMKKMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D80660", Offset = "0x6D7FA60", VA = "0x186D80660")]
	public MHEEFBCBLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D806E0", Offset = "0x6D7FAE0", VA = "0x186D806E0")]
	public MHEEFBCBLKL(bool PGLHFGOKMOE, int DFOLIIOPLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F930", Offset = "0x6D7ED30", VA = "0x186D7F930")]
	public static MHEEFBCBLKL AAAFCDEPJAH(string OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FA80", Offset = "0x6D7EE80", VA = "0x186D7FA80")]
	public void FKNIGFJHMIA(int FHFIKCKHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xCE4B20", Offset = "0xCE3F20", VA = "0x180CE4B20")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D802C0", Offset = "0x6D7F6C0", VA = "0x186D802C0")]
	public void NNHOJMINGDK(float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D804D0", Offset = "0x6D7F8D0", VA = "0x186D804D0")]
	public void NNHOJMINGDK(double OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D80580", Offset = "0x6D7F980", VA = "0x186D80580")]
	public void NNHOJMINGDK(long OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D80580", Offset = "0x6D7F980", VA = "0x186D80580")]
	public void NNHOJMINGDK(ulong OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D80440", Offset = "0x6D7F840", VA = "0x186D80440")]
	public void NNHOJMINGDK(int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D80440", Offset = "0x6D7F840", VA = "0x186D80440")]
	public void NNHOJMINGDK(uint OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D80040", Offset = "0x6D7F440", VA = "0x186D80040")]
	public void NNHOJMINGDK(char OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D80040", Offset = "0x6D7F440", VA = "0x186D80040")]
	public void NNHOJMINGDK(ushort OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D80040", Offset = "0x6D7F440", VA = "0x186D80040")]
	public void NNHOJMINGDK(short OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D80520", Offset = "0x6D7F920", VA = "0x186D80520")]
	public void NNHOJMINGDK(sbyte OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D80520", Offset = "0x6D7F920", VA = "0x186D80520")]
	public void NNHOJMINGDK(byte OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6D80360", Offset = "0x6D7F760", VA = "0x186D80360")]
	public void NNHOJMINGDK(byte[] AOFGGGKINCN, int IALPEJIGIPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F9A0", Offset = "0x6D7EDA0", VA = "0x186D7F9A0")]
	public void COOPHKEJNFJ(sbyte[] AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F9A0", Offset = "0x6D7EDA0", VA = "0x186D7F9A0")]
	public void APNNDFFKKOE(byte[] AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D803E0", Offset = "0x6D7F7E0", VA = "0x186D803E0")]
	public void NNHOJMINGDK(bool OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FC00", Offset = "0x6D7F000", VA = "0x186D7FC00")]
	public void NINAIFBGIMP(Array CIFNBCBMCKF, int EMCBHOKMHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FDC0", Offset = "0x6D7F1C0", VA = "0x186D7FDC0")]
	public void NINAIFBGIMP(float[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FB20", Offset = "0x6D7EF20", VA = "0x186D7FB20")]
	public void NINAIFBGIMP(double[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FB20", Offset = "0x6D7EF20", VA = "0x186D7FB20")]
	public void NINAIFBGIMP(long[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FB20", Offset = "0x6D7EF20", VA = "0x186D7FB20")]
	public void NINAIFBGIMP(ulong[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FDC0", Offset = "0x6D7F1C0", VA = "0x186D7FDC0")]
	public void NINAIFBGIMP(int[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FDC0", Offset = "0x6D7F1C0", VA = "0x186D7FDC0")]
	public void NINAIFBGIMP(uint[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FCE0", Offset = "0x6D7F0E0", VA = "0x186D7FCE0")]
	public void NINAIFBGIMP(ushort[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FCE0", Offset = "0x6D7F0E0", VA = "0x186D7FCE0")]
	public void NINAIFBGIMP(short[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F9A0", Offset = "0x6D7EDA0", VA = "0x186D7F9A0")]
	public void NINAIFBGIMP(bool[] OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FEA0", Offset = "0x6D7F2A0", VA = "0x186D7FEA0")]
	public void NINAIFBGIMP(string[] OOEMJLHLIHJ, int IOPPEJEHAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FF70", Offset = "0x6D7F370", VA = "0x186D7FF70")]
	public void NNHOJMINGDK(IPEndPoint ILJEIFNEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D803D0", Offset = "0x6D7F7D0", VA = "0x186D803D0")]
	public void NNHOJMINGDK(string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D800B0", Offset = "0x6D7F4B0", VA = "0x186D800B0")]
	public void NNHOJMINGDK(string OOEMJLHLIHJ, int CMOFODPGFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CIGIHHOGHLL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LPPCADHNJCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong NKGPMMKCOJL;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7460", Offset = "0x4ED6860", VA = "0x184ED7460")]
		static LPPCADHNJCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void EDGOFKLCFBH(GLAGCGMPGLD PABEDPKBAJJ, object ECFBCCAHJAJ);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DEAGONLGGDC<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public CIGIHHOGHLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DEAGONLGGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x68877B0", Offset = "0x6886BB0", VA = "0x1868877B0")]
		internal void ABFMDJDOBCF(GLAGCGMPGLD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HCLEHLHNJEL<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CIGIHHOGHLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HCLEHLHNJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x49107C0", Offset = "0x490FBC0", VA = "0x1849107C0")]
		internal void ABFMDJDOBCF(GLAGCGMPGLD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly NOPDGJCAAAJ PBBNAPOINHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, EDGOFKLCFBH> PGDDBBOECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly MHEEFBCBLKL BMGPNNDNBFJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A530", Offset = "0x6D69930", VA = "0x186D6A530")]
	public CIGIHHOGHLL(int FBAJIAFLNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x343C060", Offset = "0x343B460", VA = "0x18343C060", Slot = "4")]
	protected virtual ulong EDOCNNBDGCL<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A400", Offset = "0x6D69800", VA = "0x186D6A400", Slot = "5")]
	protected virtual EDGOFKLCFBH PMFHJOFDIHK(GLAGCGMPGLD PABEDPKBAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x34C1C70", Offset = "0x34C1070", VA = "0x1834C1C70", Slot = "6")]
	protected virtual void HOEKPEKJLCP<T>(MHEEFBCBLKL CELBHBDDEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A380", Offset = "0x6D69780", VA = "0x186D6A380")]
	public void NMFGCNLNFHG(GLAGCGMPGLD PABEDPKBAJJ, object ECFBCCAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x34C1CE0", Offset = "0x34C10E0", VA = "0x1834C1CE0")]
	public void NCDIIFOABOB<T>(MHEEFBCBLKL CELBHBDDEKA, T CDBLEJFCKMN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A330", Offset = "0x6D69730", VA = "0x186D6A330")]
	public void CIPPFGKJMMJ(GLAGCGMPGLD PABEDPKBAJJ, object ECFBCCAHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x34C1AB0", Offset = "0x34C0EB0", VA = "0x1834C1AB0")]
	public void GHFBLDJLOOL<T>(Action<T> LGECOEPMAHC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x34C18F0", Offset = "0x34C0CF0", VA = "0x1834C18F0")]
	public void GHFBLDJLOOL<T, TUserData>(Action<T, TUserData> LGECOEPMAHC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PJDHJPMLLJK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D764C0", Offset = "0x6D758C0", VA = "0x186D764C0")]
	public PJDHJPMLLJK(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class GELPOILJAJF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D764D0", Offset = "0x6D758D0", VA = "0x186D764D0")]
	public GELPOILJAJF(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NOPDGJCAAAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum EDAJOJKMALF
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class PNNELPLGDFF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public EDAJOJKMALF PLJKCMOLLLF;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x54C8800", Offset = "0x54C7C00", VA = "0x1854C8800", Slot = "4")]
		public virtual void HGEPFBBIJLL(MethodInfo NBGOLFPBIBE, MethodInfo EKIDJGGJOGC, EDAJOJKMALF KHNCICOHHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void PCOCDDNILID(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void NHFKIHKCCLL(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		protected PNNELPLGDFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MLCGACGNMHK<TClass, TProperty> : PNNELPLGDFF<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> DOJMENBDACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> HPNMANOMHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> MGJAKHIDIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> DAHBONGNGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> FLDOAGLNCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> HLOHDJHFNJA;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x50DA000", Offset = "0x50D9400", VA = "0x1850DA000", Slot = "7")]
		public override void KMKPPHJNFAI(TClass EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x50D46A0", Offset = "0x50D3AA0", VA = "0x1850D46A0", Slot = "8")]
		public override void BIHHCCGEDLO(TClass EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x50DB960", Offset = "0x50DAD60", VA = "0x1850DB960", Slot = "9")]
		public override void PCOCDDNILID(TClass EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x50DAA80", Offset = "0x50D9E80", VA = "0x1850DAA80", Slot = "10")]
		public override void NHFKIHKCCLL(TClass EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x50D9A10", Offset = "0x50D8E10", VA = "0x1850D9A10")]
		protected TProperty[] HJLIBDLHMFB(TClass EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x50D9B20", Offset = "0x50D8F20", VA = "0x1850D9B20")]
		protected TProperty[] IJDKMLNOKFK(TClass EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x50D6B90", Offset = "0x50D5F90", VA = "0x1850D6B90", Slot = "4")]
		public override void HGEPFBBIJLL(MethodInfo NBGOLFPBIBE, MethodInfo EKIDJGGJOGC, EDAJOJKMALF KHNCICOHHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4C8A000", Offset = "0x4C89400", VA = "0x184C8A000")]
		protected MLCGACGNMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class JIFDENJAIGM<TClass, TProperty> : MLCGACGNMHK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OPAHCABGGBE(GLAGCGMPGLD DEBKLEONCCD, [Out] TProperty OLIJEPJAPPO);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IIHPEKIANGA(MHEEFBCBLKL LBBKKDPILOD, TProperty OLIJEPJAPPO);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4C94E00", Offset = "0x4C94200", VA = "0x184C94E00", Slot = "5")]
		public override void PIILCCNLJDB(TClass EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4C94C40", Offset = "0x4C94040", VA = "0x184C94C40", Slot = "6")]
		public override void NCDIIFOABOB(TClass EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4C94B80", Offset = "0x4C93F80", VA = "0x184C94B80", Slot = "7")]
		public override void KMKPPHJNFAI(TClass EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4C94940", Offset = "0x4C93D40", VA = "0x184C94940", Slot = "8")]
		public override void BIHHCCGEDLO(TClass EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x497C050", Offset = "0x497B450", VA = "0x18497C050")]
		protected JIFDENJAIGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class DKPCIAAAJND<T> : MLCGACGNMHK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x68E1C50", Offset = "0x68E1050", VA = "0x1868E1C50", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x54846C0", Offset = "0x5483AC0", VA = "0x1854846C0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x68E1BD0", Offset = "0x68E0FD0", VA = "0x1868E1BD0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x54845D0", Offset = "0x54839D0", VA = "0x1854845D0", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public DKPCIAAAJND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class PDPJMIBJAHN<T> : MLCGACGNMHK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5484730", Offset = "0x5483B30", VA = "0x185484730", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x54846C0", Offset = "0x5483AC0", VA = "0x1854846C0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5484640", Offset = "0x5483A40", VA = "0x185484640", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x54845D0", Offset = "0x54839D0", VA = "0x1854845D0", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public PDPJMIBJAHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class GPAGFOAOAHK<T> : MLCGACGNMHK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x48D59B0", Offset = "0x48D4DB0", VA = "0x1848D59B0", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x48D5940", Offset = "0x48D4D40", VA = "0x1848D5940", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x48D58C0", Offset = "0x48D4CC0", VA = "0x1848D58C0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x48D5850", Offset = "0x48D4C50", VA = "0x1848D5850", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public GPAGFOAOAHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JHPDNDAAALO<T> : MLCGACGNMHK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4C90FF0", Offset = "0x4C903F0", VA = "0x184C90FF0", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x48D5940", Offset = "0x48D4D40", VA = "0x1848D5940", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4C90F70", Offset = "0x4C90370", VA = "0x184C90F70", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x48D5850", Offset = "0x48D4C50", VA = "0x1848D5850", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public JHPDNDAAALO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DEOHPDDKHIG<T> : MLCGACGNMHK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x688BF70", Offset = "0x688B370", VA = "0x18688BF70", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5379070", Offset = "0x5378470", VA = "0x185379070", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x688BEF0", Offset = "0x688B2F0", VA = "0x18688BEF0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5224000", Offset = "0x5223400", VA = "0x185224000", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public DEOHPDDKHIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OOMPDIDJPLP<T> : MLCGACGNMHK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x53790E0", Offset = "0x53784E0", VA = "0x1853790E0", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5379070", Offset = "0x5378470", VA = "0x185379070", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5378FF0", Offset = "0x53783F0", VA = "0x185378FF0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5224000", Offset = "0x5223400", VA = "0x185224000", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public OOMPDIDJPLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MGCIENMIEMI<T> : MLCGACGNMHK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50B9F60", Offset = "0x50B9360", VA = "0x1850B9F60", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x50B9EF0", Offset = "0x50B92F0", VA = "0x1850B9EF0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x50B9E70", Offset = "0x50B9270", VA = "0x1850B9E70", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x50B9E00", Offset = "0x50B9200", VA = "0x1850B9E00", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public MGCIENMIEMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MLBICHJJPLJ<T> : MLCGACGNMHK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x50B9F60", Offset = "0x50B9360", VA = "0x1850B9F60", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x50B9EF0", Offset = "0x50B92F0", VA = "0x1850B9EF0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x50D42A0", Offset = "0x50D36A0", VA = "0x1850D42A0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x50B9E00", Offset = "0x50B9200", VA = "0x1850B9E00", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public MLBICHJJPLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PHFCCPJNIMG<T> : MLCGACGNMHK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x549C090", Offset = "0x549B490", VA = "0x18549C090", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x549C020", Offset = "0x549B420", VA = "0x18549C020", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x549BFA0", Offset = "0x549B3A0", VA = "0x18549BFA0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x54845D0", Offset = "0x54839D0", VA = "0x1854845D0", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public PHFCCPJNIMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class NKMGDICFFJL<T> : MLCGACGNMHK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5224160", Offset = "0x5223560", VA = "0x185224160", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x52240F0", Offset = "0x52234F0", VA = "0x1852240F0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5224070", Offset = "0x5223470", VA = "0x185224070", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5224000", Offset = "0x5223400", VA = "0x185224000", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public NKMGDICFFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OIAEPJBIEPN<T> : MLCGACGNMHK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5347D30", Offset = "0x5347130", VA = "0x185347D30", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5347CC0", Offset = "0x53470C0", VA = "0x185347CC0", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5347C40", Offset = "0x5347040", VA = "0x185347C40", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x50B9E00", Offset = "0x50B9200", VA = "0x1850B9E00", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x43AB590", Offset = "0x43AA990", VA = "0x1843AB590")]
		public OIAEPJBIEPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class DCANEIKIOCO<T> : JIFDENJAIGM<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6881690", Offset = "0x6880A90", VA = "0x186881690", Slot = "12")]
		protected override void IIHPEKIANGA(MHEEFBCBLKL LBBKKDPILOD, char OLIJEPJAPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68816C0", Offset = "0x6880AC0", VA = "0x1868816C0", Slot = "11")]
		protected override void OPAHCABGGBE(GLAGCGMPGLD DEBKLEONCCD, [Out] char OLIJEPJAPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
		public DCANEIKIOCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class IGNKINLMBCL<T> : JIFDENJAIGM<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A8E0", Offset = "0x4A59CE0", VA = "0x184A5A8E0", Slot = "12")]
		protected override void IIHPEKIANGA(MHEEFBCBLKL LBBKKDPILOD, IPEndPoint OLIJEPJAPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A910", Offset = "0x4A59D10", VA = "0x184A5A910", Slot = "11")]
		protected override void OPAHCABGGBE(GLAGCGMPGLD DEBKLEONCCD, [Out] IPEndPoint OLIJEPJAPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
		public IGNKINLMBCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JCOODEMDAIH<T> : MLCGACGNMHK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int FDLMLHHMNOM;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4C84720", Offset = "0x4C83B20", VA = "0x184C84720")]
		public JCOODEMDAIH(int CMOFODPGFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4C846A0", Offset = "0x4C83AA0", VA = "0x184C846A0", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4C84620", Offset = "0x4C83A20", VA = "0x184C84620", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C845A0", Offset = "0x4C839A0", VA = "0x184C845A0", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4C84520", Offset = "0x4C83920", VA = "0x184C84520", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GMIKLHMFNEP<T> : PNNELPLGDFF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo NIAHJHIDLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type LLFNFBAMNKN;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x48C8BC0", Offset = "0x48C7FC0", VA = "0x1848C8BC0")]
		public GMIKLHMFNEP(PropertyInfo EKNPKHOHCLO, Type FPHHFGCPBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x48C8B00", Offset = "0x48C7F00", VA = "0x1848C8B00", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x48C8990", Offset = "0x48C7D90", VA = "0x1848C8990", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x48C8930", Offset = "0x48C7D30", VA = "0x1848C8930", Slot = "7")]
		public override void KMKPPHJNFAI(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x48C88D0", Offset = "0x48C7CD0", VA = "0x1848C88D0", Slot = "8")]
		public override void BIHHCCGEDLO(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x48C8AA0", Offset = "0x48C7EA0", VA = "0x1848C8AA0", Slot = "9")]
		public override void PCOCDDNILID(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x48C8A40", Offset = "0x48C7E40", VA = "0x1848C8A40", Slot = "10")]
		public override void NHFKIHKCCLL(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KFCANEIFFGB<T> : GMIKLHMFNEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
		public KFCANEIFFGB(PropertyInfo EKNPKHOHCLO, Type FPHHFGCPBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4DE8300", Offset = "0x4DE7700", VA = "0x184DE8300", Slot = "5")]
		public override void PIILCCNLJDB(T EAGPAJDNIMM, GLAGCGMPGLD DEBKLEONCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4DE8250", Offset = "0x4DE7650", VA = "0x184DE8250", Slot = "6")]
		public override void NCDIIFOABOB(T EAGPAJDNIMM, MHEEFBCBLKL LBBKKDPILOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class EACAJMAIJJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static EACAJMAIJJA<T> IADGMEFIGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly PNNELPLGDFF<T>[] AIJAPEBFNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int KPKFIHEEHJM;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x437D2C0", Offset = "0x437C6C0", VA = "0x18437D2C0")]
		public EACAJMAIJJA(List<PNNELPLGDFF<T>> MKKCEIEGOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x437D160", Offset = "0x437C560", VA = "0x18437D160")]
		public void NCDIIFOABOB(T KLANNNFBLNB, MHEEFBCBLKL CELBHBDDEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x437D210", Offset = "0x437C610", VA = "0x18437D210")]
		public void PIILCCNLJDB(T KLANNNFBLNB, GLAGCGMPGLD PABEDPKBAJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class PDJODFPLKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract PNNELPLGDFF<T> DANLDNLMJMK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private MHEEFBCBLKL BKDAIILKJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int BPPOJAFKOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, PDJODFPLKMG> BLMLHEDAONH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D81480", Offset = "0x6D80880", VA = "0x186D81480")]
	public NOPDGJCAAAJ(int FBAJIAFLNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38633B0", Offset = "0x38627B0", VA = "0x1838633B0")]
	private EACAJMAIJJA<T> CJIKOLLCLMJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3446860", Offset = "0x3445C60", VA = "0x183446860")]
	public void KECNLMAOALC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38644E0", Offset = "0x38638E0", VA = "0x1838644E0")]
	public bool ILOIKAMJPOD<T>(GLAGCGMPGLD PABEDPKBAJJ, T EJCNBBIIFBE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3864580", Offset = "0x3863980", VA = "0x183864580")]
	public void PEGKBLBFNLH<T>(MHEEFBCBLKL CELBHBDDEKA, T KLANNNFBLNB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LBIPADFKJLI
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime ADLLBEAGLIP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] CCPFBOMMMII
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DGJAFPFAJFI FOLNCHMOIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C980", Offset = "0x6D7BD80", VA = "0x186D7C980")]
		get
		{
			return default(DGJAFPFAJFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KALCLKFONGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D180", Offset = "0x6D7C580", VA = "0x186D7D180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C900", Offset = "0x6D7BD00", VA = "0x186D7C900")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BDMIAEHJFOO EPFLNBHKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C790", Offset = "0x6D7BB90", VA = "0x186D7C790")]
		get
		{
			return default(BDMIAEHJFOO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C940", Offset = "0x6D7BD40", VA = "0x186D7C940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DLCKCPAOKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C760", Offset = "0x6D7BB60", VA = "0x186D7C760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint AEIDLJFBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C7C0", Offset = "0x6D7BBC0", VA = "0x186D7C7C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? JDNJAAGADPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D7CF70", Offset = "0x6D7C370", VA = "0x186D7CF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? CMGONBMOGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C730", Offset = "0x6D7BB30", VA = "0x186D7C730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? HFJKNDMIPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D1B0", Offset = "0x6D7C5B0", VA = "0x186D7D1B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C560", Offset = "0x6D7B960", VA = "0x186D7C560")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? PJAFIBOJIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xD96400", Offset = "0xD95800", VA = "0x180D96400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D2F0", Offset = "0x6D7C6F0", VA = "0x186D7D2F0")]
	public LBIPADFKJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D240", Offset = "0x6D7C640", VA = "0x186D7D240")]
	internal LBIPADFKJLI(byte[] FLIFCMNPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CBB0", Offset = "0x6D7BFB0", VA = "0x186D7CBB0")]
	public static LBIPADFKJLI KCMCBHAJCDA(byte[] FLIFCMNPFIN, DateTime BNJBNLDGLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C270", Offset = "0x6D7B670", VA = "0x186D7C270")]
	internal void ADHLPDBGNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CFA0", Offset = "0x6D7C3A0", VA = "0x186D7CFA0")]
	private void PCGHFPENHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C9B0", Offset = "0x6D7BDB0", VA = "0x186D7C9B0")]
	private DateTime? JKPEAAGJEIB(int IALPEJIGIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CCD0", Offset = "0x6D7C0D0", VA = "0x186D7CCD0")]
	private void NIPFCAMGCGA(int IALPEJIGIPD, DateTime? OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CEA0", Offset = "0x6D7C2A0", VA = "0x186D7CEA0")]
	private ulong OAPAIHKMFGF(int IALPEJIGIPD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C840", Offset = "0x6D7BC40", VA = "0x186D7C840")]
	private void FFMGGKJCKLH(int IALPEJIGIPD, ulong OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C470", Offset = "0x6D7B870", VA = "0x186D7C470")]
	private uint AHMBCJJAKBF(int IALPEJIGIPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C34ED0", Offset = "0x6C342D0", VA = "0x186C34ED0")]
	private static uint BBDHHAEIPIA(uint COBPEJEHIHC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C500", Offset = "0x6D7B900", VA = "0x186D7C500")]
	private static ulong BBDHHAEIPIA(ulong COBPEJEHIHC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DGJAFPFAJFI
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum BDMIAEHJFOO
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ODIHAFNBANL
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int ABKGCEKHAGP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int JNKADDBLHNO = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int CIMBJHOGMKH = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint DJNHBDMDNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int JDGBKFNGFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int FDPFCKOHFEM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KKHPBCMMBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D81610", Offset = "0x6D80A10", VA = "0x186D81610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D81520", Offset = "0x6D80920", VA = "0x186D81520")]
	public bool KEONIDJGMED(CHGLDGAEBIM JHPBGLFIFNC, int ILKAOEMIOFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AANBBMGIACA : CHGLDGAEBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket JHPBGLFIFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly CNJKFPBKODA JJFHEKHDDOA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short KNPLMIGKLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D69B70", Offset = "0x6D68F70", VA = "0x186D69B70", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LGIANCENLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D69B50", Offset = "0x6D68F50", VA = "0x186D69B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint KDLKGPPLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D69C80", Offset = "0x6D69080", VA = "0x186D69C80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily MLPMPKLMNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4E79030", Offset = "0x4E78430", VA = "0x184E79030", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A280", Offset = "0x6D69680", VA = "0x186D6A280")]
	public AANBBMGIACA(AddressFamily MBDFFFAJIIF, CNJKFPBKODA JJFHEKHDDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D69CC0", Offset = "0x6D690C0", VA = "0x186D69CC0", Slot = "8")]
	public bool MDFACAFLJLD(IPEndPoint ILJEIFNEHJN, GMELMPBOAPJ NIDEDJJFLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D69B10", Offset = "0x6D68F10", VA = "0x186D69B10", Slot = "9")]
	public int AMGDHGLALKA(byte[] HDBNDELHALH, int IALPEJIGIPD, int LLBNOFGPNDN, IPEndPoint DAHIKICCCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D69B90", Offset = "0x6D68F90", VA = "0x186D69B90", Slot = "10")]
	public int FCPEJJJJLFM(byte[] HDBNDELHALH, EndPoint NDJPCGLGGCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D69CA0", Offset = "0x6D690A0", VA = "0x186D69CA0", Slot = "11")]
	public void IOFMADCDDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface CHGLDGAEBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short KNPLMIGKLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int LGIANCENLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint KDLKGPPLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily MLPMPKLMNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDFACAFLJLD(IPEndPoint ILJEIFNEHJN, GMELMPBOAPJ NIDEDJJFLKH);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int AMGDHGLALKA(byte[] HDBNDELHALH, int IALPEJIGIPD, int LLBNOFGPNDN, IPEndPoint DAHIKICCCCL);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FCPEJJJJLFM(byte[] HDBNDELHALH, EndPoint DAHIKICCCCL);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IOFMADCDDHK();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct INKBHKHHCHN : IEquatable<INKBHKHHCHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long CCDMLIJDFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long HEKGMPANFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long KLHAMMPLKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int GIGIIOMLFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int JBCJABFIJEE;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BDC0", Offset = "0x6D7B1C0", VA = "0x186D7BDC0")]
	public INKBHKHHCHN(byte[] DAKGFMMPBKB, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BE80", Offset = "0x6D7B280", VA = "0x186D7BE80")]
	public INKBHKHHCHN(Span<byte> DAKGFMMPBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9F2840", Offset = "0x9F1C40", VA = "0x1809F2840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BCD0", Offset = "0x6D7B0D0", VA = "0x186D7BCD0", Slot = "4")]
	public bool Equals(INKBHKHHCHN DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BD10", Offset = "0x6D7B110", VA = "0x186D7BD10", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JEGEIKIGBPI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] MINNNANIIGL;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JHIJBPDLCNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void AJNACAKDFCB(IPEndPoint DAKGFMMPBKB, Span<byte> AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string APILGPEKFIM = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int ECGKAADEMKE = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int HKOIHDGLJHH = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<INKBHKHHCHN, IPEndPoint> MPLOBKOGKGB;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static AJNACAKDFCB FEGGOMGLMCI;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	internal void PGAENEKDOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	internal void NDMIAKDNIAJ(IPEndPoint DAHIKICCCCL, Span<byte> AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class PPAONDBGLIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int EGJJDKMLFEG;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
	protected PPAONDBGLIE(int ADMBHNNAFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LCCMEMEPLFF(IPEndPoint ILJEIFNEHJN, byte[] AOFGGGKINCN, int IALPEJIGIPD, int CFKBLDHNBAA);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LEGKBLEBMCA(IPEndPoint ILJEIFNEHJN, byte[] AOFGGGKINCN, int IALPEJIGIPD, int CFKBLDHNBAA);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CJKCNJHACOK : PPAONDBGLIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] IICGAABOENK;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator IKOJDMJOCEF;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2727D40", Offset = "0x2727140", VA = "0x182727D40")]
	public CJKCNJHACOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A790", Offset = "0x6D69B90", VA = "0x186D6A790")]
	public void IPFLMKIOBDJ(IPEndPoint ILJEIFNEHJN, byte[] IICGAABOENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A6B0", Offset = "0x6D69AB0", VA = "0x186D6A6B0")]
	public void IBAGJGDGOGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A940", Offset = "0x6D69D40", VA = "0x186D6A940", Slot = "4")]
	public override void LCCMEMEPLFF(IPEndPoint ILJEIFNEHJN, byte[] AOFGGGKINCN, int IALPEJIGIPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AE00", Offset = "0x6D6A200", VA = "0x186D6AE00", Slot = "5")]
	public override void LEGKBLEBMCA(IPEndPoint ILJEIFNEHJN, byte[] AOFGGGKINCN, int IALPEJIGIPD, int CFKBLDHNBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct LJBHKGBELNO
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void OEOGAFIFANL([NoAlias] byte* ABCKPAFNANM, [NoAlias] byte* IICGAABOENK, [NoAlias] byte* KIFKIMPDJPD, int CFKBLDHNBAA);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class ELJHDEOCCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr HANAJKEMOIL;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr HFMPIJMLIEF;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6D81A70", Offset = "0x6D80E70", VA = "0x186D81A70")]
		[BurstDiscard]
		private static void NJIFBOKCMHI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6D81620", Offset = "0x6D80A20", VA = "0x186D81620")]
		private static IntPtr AFPKNMODFAC()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6D819C0", Offset = "0x6D80DC0", VA = "0x186D819C0")]
		public static void MHNPPHJMEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public static void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6D81780", Offset = "0x6D80B80", VA = "0x186D81780")]
		public unsafe static void HFGDGIKOIHK([NoAlias] byte* ABCKPAFNANM, [NoAlias] byte* IICGAABOENK, [NoAlias] byte* KIFKIMPDJPD, int CFKBLDHNBAA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint IICGAABOENK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint KIFKIMPDJPD[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint DLABECJGFDH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint OOOBHDJOHBO[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint BAFPOELKILH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint BAJNGNJBFJC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint PINFLFCKOLH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint FKPJNOKEPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint MLJCKALDKNN[8];

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D7A0", Offset = "0x6D7CBA0", VA = "0x186D7D7A0")]
	private void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D710", Offset = "0x6D7CB10", VA = "0x186D7D710")]
	private uint GJHFFOBCNEO(uint LLEKGMDPLMK, int DEPOCFBBMPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6D698C0", Offset = "0x6D68CC0", VA = "0x186D698C0")]
	private void GEMEIJAFHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6D696B0", Offset = "0x6D68AB0", VA = "0x186D696B0")]
	private void FBKIMFAKNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6D69620", Offset = "0x6D68A20", VA = "0x186D69620")]
	private void BGNONHOHJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6D69970", Offset = "0x6D68D70", VA = "0x186D69970")]
	private void KCDIMDMFNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D740", Offset = "0x6D7CB40", VA = "0x186D7D740")]
	private void HEPPKFDFJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D980", Offset = "0x6D7CD80", VA = "0x186D7D980")]
	private unsafe void JDLNCHFPNIL(byte* ABCKPAFNANM, uint* IICGAABOENK, uint* KIFKIMPDJPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D820", Offset = "0x6D7CC20", VA = "0x186D7D820")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IODIKCHCLMB([NoAlias] byte* ABCKPAFNANM, [NoAlias] byte* IICGAABOENK, [NoAlias] byte* KIFKIMPDJPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D8A0", Offset = "0x6D7CCA0", VA = "0x186D7D8A0")]
	public static void IODIKCHCLMB(Span<byte> ABCKPAFNANM, Span<byte> IICGAABOENK, Span<byte> KIFKIMPDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D610", Offset = "0x6D7CA10", VA = "0x186D7D610")]
	public static void FFNLIBNLGPD(Span<byte> ABCKPAFNANM, Span<byte> IICGAABOENK, Span<byte> KIFKIMPDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DDA0", Offset = "0x6D7D1A0", VA = "0x186D7DDA0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void ONBOHAAPPOK([NoAlias] byte* ABCKPAFNANM, [NoAlias] byte* IICGAABOENK, [NoAlias] byte* KIFKIMPDJPD, int CFKBLDHNBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6D81CA0", Offset = "0x6D810A0", VA = "0x186D81CA0")]
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
