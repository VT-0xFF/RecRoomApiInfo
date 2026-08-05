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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, IIAGJLCABEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum PMINMMABBKI
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
		private NetworkManager BJKHAMECNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, EJNLEKAPLCL> CMHLEIAGBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LMIEHNKLMON HLFGOFHEFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] ABEEJEMGCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PMINMMABBKI FFNJNEEOFEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong CIMNKAJIJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CKKPGPDJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x62E8FF0", Offset = "0x62E77F0", VA = "0x1862E8FF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62E85D0", Offset = "0x62E6DD0", VA = "0x1862E85D0")]
		public void RecRoom_SetEncryptionInfo(ulong MBPINLPBDHC, byte[] KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62E85B0", Offset = "0x62E6DB0", VA = "0x1862E85B0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62E83C0", Offset = "0x62E6BC0", VA = "0x1862E83C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62E8EF0", Offset = "0x62E76F0", VA = "0x1862E8EF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62E86F0", Offset = "0x62E6EF0", VA = "0x1862E86F0", Slot = "6")]
		public override void Send(ulong LDJBHMFOPJL, ArraySegment<byte> EBNFOODJNOB, NetworkDelivery EOLDEABOJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62E8570", Offset = "0x62E6D70", VA = "0x1862E8570", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong LDJBHMFOPJL, [Out] ArraySegment<byte> OANAMCHLGCB, [Out] float MFFNAMPAIAL)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62E89E0", Offset = "0x62E71E0", VA = "0x1862E89E0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62E8E10", Offset = "0x62E7610", VA = "0x1862E8E10", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62E7B20", Offset = "0x62E6320", VA = "0x1862E7B20", Slot = "10")]
		public override void DisconnectRemoteClient(ulong LDJBHMFOPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62E7A30", Offset = "0x62E6230", VA = "0x1862E7A30", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62E7D80", Offset = "0x62E6580", VA = "0x1862E7D80", Slot = "12")]
		public override ulong GetCurrentRtt(ulong LDJBHMFOPJL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x62E8970", Offset = "0x62E7170", VA = "0x1862E8970", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62E8060", Offset = "0x62E6860", VA = "0x1862E8060", Slot = "14")]
		public override void Initialize([Optional] NetworkManager BJKHAMECNJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62E7C90", Offset = "0x62E6490", VA = "0x1862E7C90")]
		private NHMEFAMPPNH ENGLHCCCNNL(NetworkDelivery OCLAPBNMMGE)
		{
			return default(NHMEFAMPPNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x62E84B0", Offset = "0x62E6CB0", VA = "0x1862E84B0", Slot = "15")]
		private void PEFNBLEMMOA(EJNLEKAPLCL NAJGPOPJFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62E8300", Offset = "0x62E6B00", VA = "0x1862E8300", Slot = "16")]
		private void MFLMAILNFOG(EJNLEKAPLCL NAJGPOPJFDJ, MPKHHCDLEMO BADFJKMCGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "17")]
		private void FNOKJPOAPPK(IPEndPoint JALBGCIAOLG, SocketError HNMNGCEBJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62E7E20", Offset = "0x62E6620", VA = "0x1862E7E20", Slot = "18")]
		private void HEOGCDEJMLB(EJNLEKAPLCL NAJGPOPJFDJ, OPMFJLEEIBD GKMNBDEFGCI, byte CMDGAMGEIJA, NHMEFAMPPNH LJHKHIKDGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62E8220", Offset = "0x62E6A20", VA = "0x1862E8220")]
		private void JJPACNLHHOG(int BOOADEANLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "19")]
		private void JCOKGBFMGHJ(IPEndPoint BHFFFDFLCFB, OPMFJLEEIBD GKMNBDEFGCI, NEBBDPHJCOK BJLPLJEIHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "20")]
		private void GALONDJADNI(EJNLEKAPLCL NAJGPOPJFDJ, int AINBOEJENBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62E7C30", Offset = "0x62E6430", VA = "0x1862E7C30", Slot = "21")]
		private void EBNCKIJIGBC(CBHHKEFPMBG BPCGMGBPPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62E8030", Offset = "0x62E6830", VA = "0x1862E8030")]
		private ulong HPAALNPJLPP(EJNLEKAPLCL NAJGPOPJFDJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62E7D60", Offset = "0x62E6560", VA = "0x1862E7D60")]
		private static int FDCFFGNIPLE(float CKHMGDGNNBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62E8F10", Offset = "0x62E7710", VA = "0x1862E8F10")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class ODCJMJAMHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly EJNLEKAPLCL LFKPEDBLOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<MEPLDGAPGLF> CPEAOMLNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NEJNJBHCPJL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62EAC80", Offset = "0x62E9480", VA = "0x1862EAC80")]
	protected ODCJMJAMHFN(EJNLEKAPLCL NAJGPOPJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x62EAC20", Offset = "0x62E9420", VA = "0x1862EAC20")]
	public void IKFMIKJFJGH(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62EABA0", Offset = "0x62E93A0", VA = "0x1862EABA0")]
	protected void GGGICJFAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62EAB60", Offset = "0x62E9360", VA = "0x1862EAB60")]
	public bool ABEOICPMBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ANEKAPAANOO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool KOPDOLDBJPC(MEPLDGAPGLF ONHPCHOJKIM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum OEODMBHKJAB
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
public class CBHHKEFPMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LMIEHNKLMON KGNDDIELFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int KHPDFLLGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MHOHAJBJENH DALECJDNLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint OAECAGCNAMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OEODMBHKJAB OCFEIGBDKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8A0", Offset = "0x8DD0A0", VA = "0x1808DE8A0")]
		[CompilerGenerated]
		get
		{
			return default(OEODMBHKJAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98C6C0", Offset = "0x98AEC0", VA = "0x18098C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62D5950", Offset = "0x62D4150", VA = "0x1862D5950")]
	internal void CPHAFPBFGNK(MHOHAJBJENH BOBLPCLAMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62D5A10", Offset = "0x62D4210", VA = "0x1862D5A10")]
	private bool NDICAELDFOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62D5A40", Offset = "0x62D4240", VA = "0x1862D5A40")]
	internal CBHHKEFPMBG(IPEndPoint BHFFFDFLCFB, MHOHAJBJENH FMBAAODGPBC, LMIEHNKLMON POIPOHLPAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62D59B0", Offset = "0x62D41B0", VA = "0x1862D59B0")]
	public EJNLEKAPLCL GAOEHEFDCGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NEBBDPHJCOK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BOEGHLEICOP
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
public struct MPKHHCDLEMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public BOEGHLEICOP INKIMCHKFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PJEPDKBKCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OPMFJLEEIBD AEKHHGKELBC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIAGJLCABEJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJHJPFALCKO(EJNLEKAPLCL NAJGPOPJFDJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPLKDGKOHCK(EJNLEKAPLCL NAJGPOPJFDJ, MPKHHCDLEMO BADFJKMCGGN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCOFBBNGMPM(IPEndPoint JALBGCIAOLG, SocketError HNMNGCEBJNA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAEPALKAJBC(EJNLEKAPLCL NAJGPOPJFDJ, OPMFJLEEIBD GKMNBDEFGCI, byte CMDGAMGEIJA, NHMEFAMPPNH LJHKHIKDGKA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEGLDKDANIH(IPEndPoint BHFFFDFLCFB, OPMFJLEEIBD GKMNBDEFGCI, NEBBDPHJCOK BJLPLJEIHCA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DINNMMKGMEP(EJNLEKAPLCL NAJGPOPJFDJ, int AINBOEJENBM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHDOJBFBAAI(CBHHKEFPMBG BPCGMGBPPCA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MOIILDPOCJK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NODHDHCEJCD(EJNLEKAPLCL NAJGPOPJFDJ, object HOHMNCPBCJA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFHICAPHPEE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOFKBCPJEBI(FJMLAMPPADN ONHPCHOJKIM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GICMEDGGIJB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGDPIAANGDN(EJNLEKAPLCL NAJGPOPJFDJ, IPEndPoint KJCGMDBFJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MHOHAJBJENH
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int GPBGGBGOFLM = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long CJIOJGLJNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte AGFACBNKPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] IPHBJLBLFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LKPPHAFGCLG OPIJNNAEPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int HCJLGAMDKPC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62EA930", Offset = "0x62E9130", VA = "0x1862EA930")]
	private MHOHAJBJENH(long KAHPLCBPLLN, byte MPBKLEGMKOL, int BCECCNCMCGN, byte[] ONNANLNJCIA, LKPPHAFGCLG EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62EA4D0", Offset = "0x62E8CD0", VA = "0x1862EA4D0")]
	public static int ELHLFFNELJA(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62EA710", Offset = "0x62E8F10", VA = "0x1862EA710")]
	public static MHOHAJBJENH OKPFJDBGABJ(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62EA530", Offset = "0x62E8D30", VA = "0x1862EA530")]
	public static MEPLDGAPGLF MMNKBDCNJPO(POECGBCENLG AIIOCKDCOPD, SocketAddress CDNFOHDDENJ, long OFJGDLANGAF, int BCECCNCMCGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PMIFHCDKPKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long CJIOJGLJNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte AGFACBNKPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int HCJLGAMDKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool NJADNDBBLJI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62EB5D0", Offset = "0x62E9DD0", VA = "0x1862EB5D0")]
	private PMIFHCDKPKE(long KAHPLCBPLLN, byte MPBKLEGMKOL, int BGLEGPCOPBH, bool OBMNMKOFIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62EB480", Offset = "0x62E9C80", VA = "0x1862EB480")]
	public static PMIFHCDKPKE OKPFJDBGABJ(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62EB390", Offset = "0x62E9B90", VA = "0x1862EB390")]
	public static MEPLDGAPGLF MMNKBDCNJPO(long OFJGDLANGAF, byte EMECBNCFAAK, int FMGBLHEKENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62EB290", Offset = "0x62E9A90", VA = "0x1862EB290")]
	public static MEPLDGAPGLF JKMKHGHDCKE(EJNLEKAPLCL NAJGPOPJFDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GEOKKEAPLPC
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FJOAOHNEMKN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJPHJGAFJCC(IPEndPoint JNBIGKLOHLA, IPEndPoint BHFFFDFLCFB, string DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEMOACFEEDP(IPEndPoint CEMBJEIBKEM, GEOKKEAPLPC OCLAPBNMMGE, string DJIMHLGHFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MEGEBPOIMKM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OBEIFGGFCFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint EGEDOFDBNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint OAECAGCNAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string NKIMAJGLIDI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HIHAJNDPCFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JLHKAPBNDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GEOKKEAPLPC JDHDLBDLIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string NKIMAJGLIDI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class EPMKNICKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint COGHBPANDBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string NKIMAJGLIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EPMKNICKLFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class EGFMEDBHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint COGHBPANDBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint DPEOKNCHFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NKIMAJGLIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EGFMEDBHPMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class NBPIMLOIOPP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NKIMAJGLIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ABEOJHFNJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9575D0", Offset = "0x955DD0", VA = "0x1809575D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8C0150", Offset = "0x8BE950", VA = "0x1808C0150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NBPIMLOIOPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LMIEHNKLMON MOPLKIFHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OBEIFGGFCFL> NOBIHMELEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<HIHAJNDPCFB> FCOKEMCIEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LKPPHAFGCLG PGDALMPEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly POECGBCENLG IHJGINPNCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KKJFJOGCBPF AIPMHDGJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private FJOAOHNEMKN NLBDMKCKPIB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BKONLPPPBKG = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool AIKCPPICINF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62E9600", Offset = "0x62E7E00", VA = "0x1862E9600")]
	internal MEGEBPOIMKM(LMIEHNKLMON PANAHEEPKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62E9300", Offset = "0x62E7B00", VA = "0x1862E9300")]
	internal void HJICNHNBLJE(IPEndPoint LBOCFOJCAEB, MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3139F40", Offset = "0x3138740", VA = "0x183139F40")]
	private void IFHBBEBHCCB<T>(T ONHPCHOJKIM, IPEndPoint BIINCLMPDMO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62E9480", Offset = "0x62E7C80", VA = "0x1862E9480")]
	private void KJPHJGAFJCC(EPMKNICKLFO GFPBGHEBJOL, IPEndPoint LBOCFOJCAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62E91A0", Offset = "0x62E79A0", VA = "0x1862E91A0")]
	private void GOJOKJMJLMJ(EGFMEDBHPMA GFPBGHEBJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62E9010", Offset = "0x62E7810", VA = "0x1862E9010")]
	private void FMFOCODJEJM(NBPIMLOIOPP GFPBGHEBJOL, IPEndPoint LBOCFOJCAEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NHMEFAMPPNH : byte
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
public enum PDKKBCIDKLD : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HOMEGEKKLFD
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] AEPMBPMFEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int FJHGOHIAPBI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int CMGKGOJGCJM;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GMOPOFOPOJJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62DD040", Offset = "0x62DB840", VA = "0x1862DD040")]
	public GMOPOFOPOJJ(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LJJEHDEIJPD : GMOPOFOPOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62DD040", Offset = "0x62DB840", VA = "0x1862DD040")]
	public LJJEHDEIJPD(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FAHCLPLIPIF
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
public interface KMPEMOCDFGK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMPGPEAJMCA(FAHCLPLIPIF HENLBIBEEIC, string JPJKMDGHCEE, params object[] GIOJKAECAOO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PIEMCOEDBJI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static KMPEMOCDFGK DAGIAHGKHGF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object GFCANGCGBII;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62EAFB0", Offset = "0x62E97B0", VA = "0x1862EAFB0")]
	private static void OGDAKPKFLCA(FAHCLPLIPIF MIFENLPDGAI, string JPJKMDGHCEE, params object[] GIOJKAECAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62EAF50", Offset = "0x62E9750", VA = "0x1862EAF50")]
	internal static void JGOICNIANNO(string JPJKMDGHCEE, params object[] GIOJKAECAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62EAEF0", Offset = "0x62E96F0", VA = "0x1862EAEF0")]
	internal static void HDCMFIIOACI(string JPJKMDGHCEE, params object[] GIOJKAECAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x62EAE90", Offset = "0x62E9690", VA = "0x1862EAE90")]
	internal static void BGHMHCFJNJA(string JPJKMDGHCEE, params object[] GIOJKAECAOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LJCGGDLLAAL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OPMFJLEEIBD : LKPPHAFGCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private MEPLDGAPGLF NNKHNKKFADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LMIEHNKLMON IILPLMCDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly HACCANNLKFH KOFKCCPGGLA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62EAE40", Offset = "0x62E9640", VA = "0x1862EAE40")]
	internal OPMFJLEEIBD(LMIEHNKLMON JIPBFCNFKIF, HACCANNLKFH EFIODEKKONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62EAD20", Offset = "0x62E9520", VA = "0x1862EAD20")]
	internal void AJKCBLFDHAF(MEPLDGAPGLF ONHPCHOJKIM, int KKOJNNCPGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62EAD90", Offset = "0x62E9590", VA = "0x1862EAD90")]
	internal void JMALMOCACCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62EAE10", Offset = "0x62E9610", VA = "0x1862EAE10")]
	public void OLGBGNEOOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class HACCANNLKFH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum MGKNBAAOOHG
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
	public HACCANNLKFH EOOLHCAJLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public MGKNBAAOOHG JDHDLBDLIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public EJNLEKAPLCL LFKPEDBLOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint OAECAGCNAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object CBEMCAOKJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int NLJMFLMNPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError EOLNLEBDDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public BOEGHLEICOP CKKILLCDPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public CBHHKEFPMBG LKPMDKOCPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NHMEFAMPPNH EJOBPBCHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PNJJJGMODOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly OPMFJLEEIBD IHHAANPNPMG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62DD050", Offset = "0x62DB850", VA = "0x1862DD050")]
	public HACCANNLKFH(LMIEHNKLMON JIPBFCNFKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LMIEHNKLMON : IEnumerable<EJNLEKAPLCL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class AAKDPIIJBGN : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62D5100", Offset = "0x62D3900", VA = "0x1862D5100", Slot = "4")]
		public bool Equals(IPEndPoint KHINBLFKKED, IPEndPoint NCCBPIFKDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E10070", Offset = "0x5E0E870", VA = "0x185E10070", Slot = "5")]
		public int GetHashCode(IPEndPoint INCBEIDOHDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AAKDPIIJBGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LGDIBLMGADN : IEnumerator<EJNLEKAPLCL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly EJNLEKAPLCL NMLCPFALGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private EJNLEKAPLCL DEPKGEFBDNP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EJNLEKAPLCL NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BB0B0", VA = "0x1809BC8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BB0B0", VA = "0x1809BC8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x14D8740", Offset = "0x14D6F40", VA = "0x1814D8740")]
		public LGDIBLMGADN(EJNLEKAPLCL DOCBAALINAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x62DF2D0", Offset = "0x62DDAD0", VA = "0x1862DF2D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x62DF320", Offset = "0x62DDB20", VA = "0x1862DF320", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread JJCPGOPPDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool NENEINAEEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent IEDAOIGLNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<HACCANNLKFH> PKDMEPLDDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<HACCANNLKFH> ILHKCBDICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private HACCANNLKFH OJMAKAGKIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IIAGJLCABEJ LNDGGLDBNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MOIILDPOCJK GBPCPGIEAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JFHICAPHPEE HFHHLNEDDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GICMEDGGIJB AGGCKHDIPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, EJNLEKAPLCL> APPMPKKPBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, CBHHKEFPMBG> LGHJGMAPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, KBAKGGFCJOD> DKCEPHOJCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim BDMAOJFBIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EJNLEKAPLCL OLIDFGMBBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int NMOKCFAKCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<EJNLEKAPLCL> AIBLKNFOHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EJNLEKAPLCL[] OLGPAJPBCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HJGOHFJJIKG BMGBJBOEFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int KNBKKKHFEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> ELBLNFLBCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte MNFMDLLBFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object JOLPGIHPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool FADOMLDHLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool HIAOPJCBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NJMFPDBIEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int FNPDPADIIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int ANMOOJNJBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int CAHNEPKBFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool BDJPOFDAABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool IEOHCGOOBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NKKMEDAPNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GDFDDCKNKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int FBHFFKPLMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool AIKCPPICINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool AIBPEPDNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PLAAGIFNLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool EMDBLPEBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int GLLLKLBCCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int MDMDEKECHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PKHOEIGOCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly BOMHHDCAMMB CJPHNJFNHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool BEHPNCAINGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly MEGEBPOIMKM EEJDKBIMIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EMDDEGALLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LJCGGDLLAAL FAHMIAKCGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PCFODIAHKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool PABFMJJPCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NFKFGNGALPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool HHIAJKFMIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BOMFGFBBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private MEPLDGAPGLF MGCHMPMPHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int PGFOOFEEHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object CDPMIAEGMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MEPLDGAPGLF FOAAJJJAGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int LLJLEODPCNK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int MDFFMHFACGF = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int PJFCAPNNHAD = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CBCLFDOJNHD KJBLKOMFJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private CBCLFDOJNHD LKBKDHFLBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OFAJIPOCKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NBFIHKIKJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint DFADHCOIJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint CJAFGAKJBOL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] GHGAJEIFKAP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] IDKEKPDHJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<LEKMJFDMILK, IPEndPoint> MANLAMCPMMJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress CCGMKBLBDNG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool PGKHPEIGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int EMEKDFKJHOB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GDFKLLCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x10621A0", Offset = "0x10609A0", VA = "0x1810621A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1062970", Offset = "0x1061170", VA = "0x181062970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BGKBANOLNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1A3D940", Offset = "0x1A3C140", VA = "0x181A3D940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CA5490", Offset = "0x1CA3C90", VA = "0x181CA5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PJGJHBDDOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x91CF50", Offset = "0x91B750", VA = "0x18091CF50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CFNOPMIADJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62E53C0", Offset = "0x62E3BC0", VA = "0x1862E53C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short DEGJHDJMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62E6800", Offset = "0x62E5000", VA = "0x1862E6800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62E39B0", Offset = "0x62E21B0", VA = "0x1862E39B0")]
	public void GHGMJFAHMJO(IPEndPoint JALBGCIAOLG, byte[] KCGKBDGKIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62E2890", Offset = "0x62E1090", VA = "0x1862E2890")]
	public void DKDGLFCAIGP(IPEndPoint JALBGCIAOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62E6340", Offset = "0x62E4B40", VA = "0x1862E6340")]
	private bool LMPJAHKFPOD(IPEndPoint JALBGCIAOLG, [Out] EJNLEKAPLCL NAJGPOPJFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62E53E0", Offset = "0x62E3BE0", VA = "0x1862E53E0")]
	private void KOCDIEHCGMO(EJNLEKAPLCL NAJGPOPJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62E5BB0", Offset = "0x62E43B0", VA = "0x1862E5BB0")]
	private void LGPICDCPDBD(EJNLEKAPLCL NAJGPOPJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62E3740", Offset = "0x62E1F40", VA = "0x1862E3740")]
	private void FOHNELCKHCC(EJNLEKAPLCL NAJGPOPJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62E73E0", Offset = "0x62E5BE0", VA = "0x1862E73E0")]
	public LMIEHNKLMON(IIAGJLCABEJ POIPOHLPAJF, [Optional] HJGOHFJJIKG HJEIKGJAAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62E67B0", Offset = "0x62E4FB0", VA = "0x1862E67B0")]
	internal void OEHNCFLBNPF(EJNLEKAPLCL LJGAKPAGANI, int AINBOEJENBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62E4FE0", Offset = "0x62E37E0", VA = "0x1862E4FE0")]
	internal void JLLMKKHHKOL(EJNLEKAPLCL LJGAKPAGANI, object HOHMNCPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62DFFE0", Offset = "0x62DE7E0", VA = "0x1862DFFE0")]
	internal void APGMGMACOGL(EJNLEKAPLCL NAJGPOPJFDJ, BOEGHLEICOP HLONLEDABCF, SocketError DJLFMEFJPON, MEPLDGAPGLF NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62E4570", Offset = "0x62E2D70", VA = "0x1862E4570")]
	private void IJPDKGLAEIH(EJNLEKAPLCL NAJGPOPJFDJ, BOEGHLEICOP HLONLEDABCF, SocketError DJLFMEFJPON, bool KHDIFEIJFDB, byte[] EBNFOODJNOB, int EEPGNNLBJAH, int NELOIEKKMHO, MEPLDGAPGLF NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62E56C0", Offset = "0x62E3EC0", VA = "0x1862E56C0")]
	private void KPGHOEDNHFK(HACCANNLKFH.MGKNBAAOOHG OCLAPBNMMGE, [Optional] EJNLEKAPLCL NAJGPOPJFDJ, [Optional] IPEndPoint BHFFFDFLCFB, SocketError EBNOLCJBELN = SocketError.Success, int AINBOEJENBM = 0, BOEGHLEICOP DLBFBCIBKOI = BOEGHLEICOP.ConnectionFailed, [Optional] CBHHKEFPMBG DIGHPOOPIBK, NHMEFAMPPNH LJHKHIKDGKA = NHMEFAMPPNH.Unreliable, byte CMDGAMGEIJA = 0, [Optional] MEPLDGAPGLF NCBCDDFMGNL, [Optional] object HOHMNCPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x62E3D40", Offset = "0x62E2540", VA = "0x1862E3D40")]
	private void IIHOMLHFNLB(HACCANNLKFH EFIODEKKONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x62E3C30", Offset = "0x62E2430", VA = "0x1862E3C30")]
	internal void IANAKDJOGOO(HACCANNLKFH EFIODEKKONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62E6A30", Offset = "0x62E5230", VA = "0x1862E6A30")]
	private void PIBKGMHHHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62E2DC0", Offset = "0x62E15C0", VA = "0x1862E2DC0")]
	private void FILNLAKHFMB(int KKNEEBONADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62E0880", Offset = "0x62DF080", VA = "0x1862E0880")]
	internal EJNLEKAPLCL CMKALCPKANJ(CBHHKEFPMBG BPCGMGBPPCA, byte[] FAKGEDOHIBI, int EEPGNNLBJAH, int OANKAJFHCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62E63D0", Offset = "0x62E4BD0", VA = "0x1862E63D0")]
	private int LOMGMDAMIJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62E3290", Offset = "0x62E1A90", VA = "0x1862E3290")]
	private void FMADDMHNCPD(IPEndPoint BHFFFDFLCFB, EJNLEKAPLCL EHALMCJGHPG, MHOHAJBJENH DBFCDDNBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x62E10F0", Offset = "0x62DF8F0", VA = "0x1862E10F0")]
	private void DAICNIDKCHD(MEPLDGAPGLF ONHPCHOJKIM, IPEndPoint BHFFFDFLCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x62E29E0", Offset = "0x62E11E0", VA = "0x1862E29E0")]
	internal void FAEAFKOBAED(MEPLDGAPGLF ONHPCHOJKIM, NHMEFAMPPNH HKOKPLGLBOO, byte CMDGAMGEIJA, int KKOJNNCPGCI, EJNLEKAPLCL LJGAKPAGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62E07D0", Offset = "0x62DEFD0", VA = "0x1862E07D0")]
	public bool CIICEFGCNDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62E0860", Offset = "0x62DF060", VA = "0x1862E0860")]
	public bool CIICEFGCNDO(IPAddress MHGNMAJNPHD, IPAddress IFEAAADHNEJ, int NHIJINHMIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62E07E0", Offset = "0x62DEFE0", VA = "0x1862E07E0")]
	public bool CIICEFGCNDO(int NHIJINHMIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62E30E0", Offset = "0x62E18E0", VA = "0x1862E30E0")]
	public void FKALGGPNMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x62E60B0", Offset = "0x62E48B0", VA = "0x1862E60B0")]
	public EJNLEKAPLCL LIDFOCCDGAM(string MDIGHMBBJIL, int NHIJINHMIHB, string KCGKBDGKIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62E5FD0", Offset = "0x62E47D0", VA = "0x1862E5FD0")]
	public EJNLEKAPLCL LIDFOCCDGAM(string MDIGHMBBJIL, int NHIJINHMIHB, POECGBCENLG FGOOEPAPHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62E5C00", Offset = "0x62E4400", VA = "0x1862E5C00")]
	public EJNLEKAPLCL LIDFOCCDGAM(IPEndPoint BIINCLMPDMO, POECGBCENLG FGOOEPAPHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62E67A0", Offset = "0x62E4FA0", VA = "0x1862E67A0")]
	public void OBPPMFLMKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62E6450", Offset = "0x62E4C50", VA = "0x1862E6450")]
	public void OBPPMFLMKPD(bool GDDBKEJEFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62E68C0", Offset = "0x62E50C0", VA = "0x1862E68C0")]
	public void PAMKEBGDGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62E6970", Offset = "0x62E5170", VA = "0x1862E6970")]
	public void PAMKEBGDGOJ(byte[] EBNFOODJNOB, int EEPGNNLBJAH, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62E44F0", Offset = "0x62E2CF0", VA = "0x1862E44F0")]
	public void IJPDKGLAEIH(EJNLEKAPLCL NAJGPOPJFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62E4530", Offset = "0x62E2D30", VA = "0x1862E4530")]
	public void IJPDKGLAEIH(EJNLEKAPLCL NAJGPOPJFDJ, byte[] EBNFOODJNOB, int EEPGNNLBJAH, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62E7200", Offset = "0x62E5A00", VA = "0x1862E7200", Slot = "4")]
	private IEnumerator<EJNLEKAPLCL> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62E7290", Offset = "0x62E5A90", VA = "0x1862E7290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62E7030", Offset = "0x62E5830", VA = "0x1862E7030")]
	private MEPLDGAPGLF PPJGGFGBFPF(IIEJDCHAPFJ MFCFAMOHGBK, int BOOADEANLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62E7120", Offset = "0x62E5920", VA = "0x1862E7120")]
	private MEPLDGAPGLF PPJGGFGBFPF(IIEJDCHAPFJ MFCFAMOHGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62E0EA0", Offset = "0x62DF6A0", VA = "0x1862E0EA0")]
	internal MEPLDGAPGLF CNPKOMGCCDC(int BOOADEANLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62E2620", Offset = "0x62E0E20", VA = "0x1862E2620")]
	internal void DJAAAEAPEFB(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62E7320", Offset = "0x62E5B20", VA = "0x1862E7320")]
	static LMIEHNKLMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x10621A0", Offset = "0x10609A0", VA = "0x1810621A0")]
	private bool JFFJPJACBAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62E5AA0", Offset = "0x62E42A0", VA = "0x1862E5AA0")]
	private void LFGKNEOECMA(IPEndPoint DBCHGNFFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62E2CC0", Offset = "0x62E14C0", VA = "0x1862E2CC0")]
	private void FAMDALBCLJP(IPEndPoint DBCHGNFFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62E6190", Offset = "0x62E4990", VA = "0x1862E6190")]
	private bool LJKCOHNBMDH(SocketException HNGGNNBFAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62E6D70", Offset = "0x62E5570", VA = "0x1862E6D70")]
	private void PJJMHEHLDDA(CBCLFDOJNHD PANAHEEPKGF, EndPoint GIIIKBJPPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62E5030", Offset = "0x62E3830", VA = "0x1862E5030")]
	private void JOJFJFJDNND(object LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62E0020", Offset = "0x62DE820", VA = "0x1862E0020")]
	public bool CIICEFGCNDO(IPAddress MHGNMAJNPHD, IPAddress IFEAAADHNEJ, int NHIJINHMIHB, bool HMJALIOMONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x62E3BD0", Offset = "0x62E23D0", VA = "0x1862E3BD0")]
	internal int HKEFHPECPAL(MEPLDGAPGLF ONHPCHOJKIM, IPEndPoint BHFFFDFLCFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62E4980", Offset = "0x62E3180", VA = "0x1862E4980")]
	internal int JCCIFLKJFHO(MEPLDGAPGLF ONHPCHOJKIM, IPEndPoint BHFFFDFLCFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x62E49C0", Offset = "0x62E31C0", VA = "0x1862E49C0")]
	internal int JCCIFLKJFHO(byte[] PJFOMDHJLBF, int EEPGNNLBJAH, int OANKAJFHCKB, IPEndPoint BHFFFDFLCFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x62E24B0", Offset = "0x62E0CB0", VA = "0x1862E24B0")]
	internal void DIMMMIBNGKG(bool CJLLFJMJLBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IIEJDCHAPFJ : byte
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
internal sealed class MEPLDGAPGLF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int CPGGJFDKFED;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DLIBKIBLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] JNOAKJMFKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int LJIEDMFFEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object CBEMCAOKJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public MEPLDGAPGLF EOOLHCAJLBI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IIEJDCHAPFJ HICLNKEGJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62E9BB0", Offset = "0x62E83B0", VA = "0x1862E9BB0")]
		get
		{
			return default(IIEJDCHAPFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62E9B10", Offset = "0x62E8310", VA = "0x1862E9B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AGFACBNKPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62EA040", Offset = "0x62E8840", VA = "0x1862EA040")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62E9D60", Offset = "0x62E8560", VA = "0x1862E9D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort KOKDNNGFGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62E9A50", Offset = "0x62E8250", VA = "0x1862E9A50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62E9DA0", Offset = "0x62E85A0", VA = "0x1862E9DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BBOLNPIMBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62E9F80", Offset = "0x62E8780", VA = "0x1862E9F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte MIIBMPKBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62E9FB0", Offset = "0x62E87B0", VA = "0x1862E9FB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62E9AB0", Offset = "0x62E82B0", VA = "0x1862E9AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LLNGPCAKNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62E9EE0", Offset = "0x62E86E0", VA = "0x1862E9EE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62E9BE0", Offset = "0x62E83E0", VA = "0x1862E9BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort OPHEAMIDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62E9FE0", Offset = "0x62E87E0", VA = "0x1862E9FE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62E9F40", Offset = "0x62E8740", VA = "0x1862E9F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JKDLJGBLDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62E9B50", Offset = "0x62E8350", VA = "0x1862E9B50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62E9D20", Offset = "0x62E8520", VA = "0x1862E9D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62EA070", Offset = "0x62E8870", VA = "0x1862EA070")]
	static MEPLDGAPGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62E9AE0", Offset = "0x62E82E0", VA = "0x1862E9AE0")]
	public void EKNBDCFNKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62EA460", Offset = "0x62E8C60", VA = "0x1862EA460")]
	public MEPLDGAPGLF(int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62EA350", Offset = "0x62E8B50", VA = "0x1862EA350")]
	public MEPLDGAPGLF(IIEJDCHAPFJ MFCFAMOHGBK, int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62E9E70", Offset = "0x62E8670", VA = "0x1862E9E70")]
	public static int JOMFAPAHHFC(IIEJDCHAPFJ MFCFAMOHGBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62E9DE0", Offset = "0x62E85E0", VA = "0x1862E9DE0")]
	public int JOMFAPAHHFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x62E9C20", Offset = "0x62E8420", VA = "0x1862E9C20")]
	public bool HDOGMKFOICL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum EAFKDHEKKBN : byte
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
internal enum HCKIHLLJGNI
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
internal enum JEMNCGOBKEK
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum LIKAJAGFONP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EJNLEKAPLCL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class FIGCKMKNFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public MEPLDGAPGLF[] FFJBHNDBILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NGJDABNMEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BKCMFFDMKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte MIIBMPKBJMC;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FIGCKMKNFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void IOKDGFOJGEB(ulong GCILALPIAOF, int FJEJDNNMODO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int NLEDBFJFALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HBBLGJDIDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int ELCOKEMNNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double LCLOANJDONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int FHMIIFGIBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int FPICAHLGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int FIGGAANENBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch EINCILDFDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int GMFAMCMOAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FMJAIGFDBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object AKDNBLDCLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal EJNLEKAPLCL HILOFOEMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal EJNLEKAPLCL MBJKEMHCGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<MEPLDGAPGLF> HLIIPFHNPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<ODCJMJAMHFN> PKAGAIPMHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly ODCJMJAMHFN[] KEIBLOBOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int OALNJBJKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int GMKHCGMLPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool ALDEGPHNEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int MIJLBFAEKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int CJOOHPGHDPF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int HIOPEFMKIJK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int AIKFDBCCKFJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object CDOCHLPGPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int NDELJCCKLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, FIGCKMKNFEM> FGCCDHONPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> ELIKLDPCAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MEPLDGAPGLF ILMBFGBPAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HAINICFHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int HINBLJDPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint NKAKCEMDOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int MHFBDCOFEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int EMGOBHBCHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long LLGBJIJIOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BKGNFDAIMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private EAFKDHEKKBN PNMJGEKCMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MEPLDGAPGLF CJEPAKFCCJL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int AIGOFGIDKLM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int AJLBNDAOGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly MEPLDGAPGLF LHCICNHNEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly MEPLDGAPGLF JKLBIHIMMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MEPLDGAPGLF MHFGOFAKABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MEPLDGAPGLF JDJMEFOADFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PDKKBCIDKLD LFOEHCMMJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LMIEHNKLMON JFHLBKBKOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int JPPMHDHPBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object AAEKGAAKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly BOMHHDCAMMB CJPHNJFNHDN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FFOKHKNBKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xDF0DC0", Offset = "0xDEF5C0", VA = "0x180DF0DC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x62D8160", Offset = "0x62D6960", VA = "0x1862D8160")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CBDILDFDLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DB530", Offset = "0x9D9D30", VA = "0x1809DB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EAFKDHEKKBN KJNLHFOEBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1744F70", Offset = "0x1743770", VA = "0x181744F70")]
		get
		{
			return default(EAFKDHEKKBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long OBABIPLIFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CA0", Offset = "0x8BF4A0", VA = "0x1808C0CA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int DBKPLBNMJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x10A3ED0", Offset = "0x10A26D0", VA = "0x1810A3ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19A2320", Offset = "0x19A0B20", VA = "0x1819A2320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int HFCPGOALABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x62D70F0", Offset = "0x62D58F0", VA = "0x1862D70F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int OLIABKLCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EE0", Offset = "0x8C46E0", VA = "0x1808C5EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BKNLNIABICI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x59411D0", Offset = "0x593F9D0", VA = "0x1859411D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IOKDGFOJGEB AFEHIGFGHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x62D7100", Offset = "0x62D5900", VA = "0x1862D7100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62D7040", Offset = "0x62D5840", VA = "0x1862D7040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62D9BB0", Offset = "0x62D83B0", VA = "0x1862D9BB0")]
	internal EJNLEKAPLCL(LMIEHNKLMON EEJNJAFBGKL, IPEndPoint BHFFFDFLCFB, int DOBPKLNCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x62D85D0", Offset = "0x62D6DD0", VA = "0x1862D85D0")]
	internal void JBHKIDMDGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x62D9B00", Offset = "0x62D8300", VA = "0x1862D9B00")]
	internal void PDLFDKIEEON(IPEndPoint EAOCLNBKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62D8910", Offset = "0x62D7110", VA = "0x1862D8910")]
	internal void KONEDDCPFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62D8090", Offset = "0x62D6890", VA = "0x1862D8090")]
	private void HEDMBFHLOCA(int IKELLFAJJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62D62D0", Offset = "0x62D4AD0", VA = "0x1862D62D0")]
	private void AHIHPMBKDMB(int ANJIFMNMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62D9950", Offset = "0x62D8150", VA = "0x1862D9950")]
	private ODCJMJAMHFN MPLLLEOIBDM(byte JAIJLDENOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62DA1F0", Offset = "0x62D89F0", VA = "0x1862DA1F0")]
	internal EJNLEKAPLCL(LMIEHNKLMON EEJNJAFBGKL, IPEndPoint BHFFFDFLCFB, int DOBPKLNCBDO, byte EMECBNCFAAK, POECGBCENLG AIIOCKDCOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62DA010", Offset = "0x62D8810", VA = "0x1862DA010")]
	internal EJNLEKAPLCL(LMIEHNKLMON EEJNJAFBGKL, CBHHKEFPMBG BPCGMGBPPCA, int DOBPKLNCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62D71B0", Offset = "0x62D59B0", VA = "0x1862D71B0")]
	internal void EMCFKJNNIAK(MHOHAJBJENH OGELJPMAION, byte[] EBNFOODJNOB, int EEPGNNLBJAH, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62D9B30", Offset = "0x62D8330", VA = "0x1862D9B30")]
	internal bool PFLDHHJOFCH(PMIFHCDKPKE ONHPCHOJKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62D8210", Offset = "0x62D6A10", VA = "0x1862D8210")]
	public void IFHBBEBHCCB(byte[] EBNFOODJNOB, int EEPGNNLBJAH, int OANKAJFHCKB, NHMEFAMPPNH PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x62D7200", Offset = "0x62D5A00", VA = "0x1862D7200")]
	private void ENDBNMMOMDG(byte[] EBNFOODJNOB, int EEPGNNLBJAH, int OANKAJFHCKB, byte CMDGAMGEIJA, NHMEFAMPPNH LJHKHIKDGKA, object HOHMNCPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62D6FF0", Offset = "0x62D57F0", VA = "0x1862D6FF0")]
	public void BDLPHMFFDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62D9060", Offset = "0x62D7860", VA = "0x1862D9060")]
	internal JEMNCGOBKEK LBJEKGAHJIJ(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return default(JEMNCGOBKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62D88B0", Offset = "0x62D70B0", VA = "0x1862D88B0")]
	internal void KNGGGOKKHAM(ODCJMJAMHFN NIEDIBKMFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62D6CE0", Offset = "0x62D54E0", VA = "0x1862D6CE0")]
	internal LIKAJAGFONP BCBJCDIBNBL(byte[] EBNFOODJNOB, int EEPGNNLBJAH, int OANKAJFHCKB, bool KHDIFEIJFDB)
	{
		return default(LIKAJAGFONP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x62D6310", Offset = "0x62D4B10", VA = "0x1862D6310")]
	private void AIEIHNMOGKO(int NPPCAOPBKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62D6350", Offset = "0x62D4B50", VA = "0x1862D6350")]
	internal void AIFDDAMFMKL(NHMEFAMPPNH HKOKPLGLBOO, MEPLDGAPGLF DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62D7B30", Offset = "0x62D6330", VA = "0x1862D7B30")]
	private void GIFCDLAANNF(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x62D8240", Offset = "0x62D6A40", VA = "0x1862D8240")]
	private void IOEOHJBFJEI(int HKMEEJMCKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62D7970", Offset = "0x62D6170", VA = "0x1862D7970")]
	internal HCKIHLLJGNI FMADDMHNCPD(MHOHAJBJENH DBFCDDNBMOM)
	{
		return default(HCKIHLLJGNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62D89A0", Offset = "0x62D71A0", VA = "0x1862D89A0")]
	internal void KOPDOLDBJPC(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62D9800", Offset = "0x62D8000", VA = "0x1862D9800")]
	private void MCKEOCJCOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62D7760", Offset = "0x62D5F60", VA = "0x1862D7760")]
	internal void FIJEGAEKOLK(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62D9140", Offset = "0x62D7940", VA = "0x1862D9140")]
	internal void LHNLPLKLOMD(int HKMEEJMCKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62D85F0", Offset = "0x62D6DF0", VA = "0x1862D85F0")]
	internal void JLFEPOCAPOF(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BOMHHDCAMMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KEBCDCGCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long KCPKHCGMGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HLAGEMMNPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long ILEIGIIDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long IENNBAGHCGL;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long DFCHGLPDEKI;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long HMAIFLHAKJF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long HAHDGLCDAOJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long IEILJEOAMDG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long HKKGDLKMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long HJILKOHLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long KDICLJEPALN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long JMMGGHFPLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x62D5170", Offset = "0x62D3970", VA = "0x1862D5170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LEOAOOPGENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x62D51E0", Offset = "0x62D39E0", VA = "0x1862D51E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FLPONEKIGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x62D5290", Offset = "0x62D3A90", VA = "0x1862D5290")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NFAOCHHOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x62D5540", Offset = "0x62D3D40", VA = "0x1862D5540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MLMEJCHEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x62D51D0", Offset = "0x62D39D0", VA = "0x1862D51D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long GAGGOCNJAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x62D51C0", Offset = "0x62D39C0", VA = "0x1862D51C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long LJJLGILAIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x62D5180", Offset = "0x62D3980", VA = "0x1862D5180")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long IBENMHIBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62D55D0", Offset = "0x62D3DD0", VA = "0x1862D55D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private PDKKBCIDKLD FMGGAEIMPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x62D5300", Offset = "0x62D3B00", VA = "0x1862D5300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double GNDJCCKKDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x62D5310", Offset = "0x62D3B10", VA = "0x1862D5310")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x62D5250", Offset = "0x62D3A50", VA = "0x1862D5250")]
	public void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x62D52A0", Offset = "0x62D3AA0", VA = "0x1862D52A0")]
	public void JBHPOHKKDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x62D5480", Offset = "0x62D3C80", VA = "0x1862D5480")]
	public void LLLJFDCHGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x62D54D0", Offset = "0x62D3CD0", VA = "0x1862D54D0")]
	public void LOENDOLNHLC(long BEKAHMCEIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x62D5370", Offset = "0x62D3B70", VA = "0x1862D5370")]
	public void KCHNNJAPDBB(long ILOMJKPJGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x62D51F0", Offset = "0x62D39F0", VA = "0x1862D51F0")]
	public void FEGKHIAAAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x62D5550", Offset = "0x62D3D50", VA = "0x1862D5550")]
	public void MGGNGOLBILN(long DPFMFDPFAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x62D5610", Offset = "0x62D3E10", VA = "0x1862D5610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x62D53E0", Offset = "0x62D3BE0", VA = "0x1862D53E0")]
	public void KJJIHKCGIMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BOMHHDCAMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EMOJBKADNOI
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> OBLEFJBJLKD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x62DADE0", Offset = "0x62D95E0", VA = "0x1862DADE0")]
	public static IPEndPoint LFNENKKDMKB(string JFACFKAJMKD, int NHIJINHMIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x62DAB80", Offset = "0x62D9380", VA = "0x1862DAB80")]
	public static IPAddress CKFGKJAJLEF(string JFACFKAJMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x62DAD50", Offset = "0x62D9550", VA = "0x1862DAD50")]
	public static IPAddress CKFGKJAJLEF(string JFACFKAJMKD, AddressFamily EIAKDLOMKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x62DB030", Offset = "0x62D9830", VA = "0x1862DB030")]
	internal static int NLGOHANEAHI(int EAABOJNFPKG, int AFABMPLNPIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1560", Offset = "0x2ECFD60", VA = "0x182ED1560")]
	internal static T[] HFDCPIMCLHF<T>(int NELOIEKKMHO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KCAGHNOOHJC : ODCJMJAMHFN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KPNKHMEJHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MEPLDGAPGLF NNKHNKKFADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long LNPBLNFGMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool EGEFNKMHMMK;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62DF050", Offset = "0x62DD850", VA = "0x1862DF050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62DEFC0", Offset = "0x62DD7C0", VA = "0x1862DEFC0")]
		public void LDJJIOLOFEI(MEPLDGAPGLF ONHPCHOJKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62DEFE0", Offset = "0x62DD7E0", VA = "0x1862DEFE0")]
		public bool LFMFKMEGMJM(long NFIGBCOCIDK, EJNLEKAPLCL NAJGPOPJFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62DEF70", Offset = "0x62DD770", VA = "0x1862DEF70")]
		public bool CPGLBCDJJEJ(EJNLEKAPLCL NAJGPOPJFDJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly MEPLDGAPGLF DPEEHPJEPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly KPNKHMEJHOB[] HEPLAOGCKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly MEPLDGAPGLF[] DKLDFNEIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] BCBCHIOKKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int PCFOPLEALLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int LFOPIILDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int OGLOCDPEEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int FOKAHHLIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HIMOENADEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly NHMEFAMPPNH PDEICIBIBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool CMNFHMBMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int JJGAKIOMPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte OHJGJHNFAFF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x62DEA20", Offset = "0x62DD220", VA = "0x1862DEA20")]
	public KCAGHNOOHJC(EJNLEKAPLCL NAJGPOPJFDJ, bool HMMJIADMHJL, byte DOBPKLNCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x62DE000", Offset = "0x62DC800", VA = "0x1862DE000")]
	private void CILMBNJCCJF(MEPLDGAPGLF ONHPCHOJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62DDB30", Offset = "0x62DC330", VA = "0x1862DDB30", Slot = "4")]
	protected override bool ANEKAPAANOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62DE3C0", Offset = "0x62DCBC0", VA = "0x1862DE3C0", Slot = "5")]
	public override bool KOPDOLDBJPC(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JMFGJLOHHOH : ODCJMJAMHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int BBMIEHLIAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort LFOPIILDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool OCKENLPCADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private MEPLDGAPGLF ENJNEJBLNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly MEPLDGAPGLF BBEDPDGOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool KHPEHANIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte OHJGJHNFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long OJOCFPCCOJK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x62DD970", Offset = "0x62DC170", VA = "0x1862DD970")]
	public JMFGJLOHHOH(EJNLEKAPLCL NAJGPOPJFDJ, bool HPMLKCCOJLD, byte DOBPKLNCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62DD1D0", Offset = "0x62DB9D0", VA = "0x1862DD1D0", Slot = "4")]
	protected override bool ANEKAPAANOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x62DD690", Offset = "0x62DBE90", VA = "0x1862DD690", Slot = "5")]
	public override bool KOPDOLDBJPC(MEPLDGAPGLF ONHPCHOJKIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NBBJCCBMEPM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct CKHECNHAEEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong OKNEMOBDKEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double JOAMMIONOMG;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JAJGFGAICMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int BNPALBPFJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float KBGEKHJJCGP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x62D4F70", Offset = "0x62D3770", VA = "0x1862D4F70")]
	private static void MEJDMEBFMFO(byte[] ENCIEGIIIHM, int MHPJBPKHONI, ulong EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x62EAA30", Offset = "0x62E9230", VA = "0x1862EAA30")]
	private static void MEJDMEBFMFO(byte[] ENCIEGIIIHM, int MHPJBPKHONI, int EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x62EAAC0", Offset = "0x62E92C0", VA = "0x1862EAAC0")]
	public static void MEJDMEBFMFO(byte[] ENCIEGIIIHM, int MHPJBPKHONI, short EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x62EAAA0", Offset = "0x62E92A0", VA = "0x1862EAAA0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, double INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x62EA9B0", Offset = "0x62E91B0", VA = "0x1862EA9B0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62EAAC0", Offset = "0x62E92C0", VA = "0x1862EAAC0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, short INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62EAAC0", Offset = "0x62E92C0", VA = "0x1862EAAC0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, ushort INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62EAA30", Offset = "0x62E9230", VA = "0x1862EAA30")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, int INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x62EAA30", Offset = "0x62E9230", VA = "0x1862EAA30")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, uint INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x62EA9A0", Offset = "0x62E91A0", VA = "0x1862EA9A0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, long INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x62EA9A0", Offset = "0x62E91A0", VA = "0x1862EA9A0")]
	public static void CDAOLDIHMPA(byte[] LMGNHIJGDNP, int PPAKOENBJHH, ulong INDENPJBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LKPPHAFGCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] PHPGHIFGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int MAKPOANCDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int MCAPLNJGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int LECDHIMMENN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] JNOAKJMFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DCGDDHBBBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NEMBICHAKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62DF420", Offset = "0x62DDC20", VA = "0x1862DF420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IONCBMEAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2221380", Offset = "0x221FB80", VA = "0x182221380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GLALMMBODNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62DFAA0", Offset = "0x62DE2A0", VA = "0x1862DFAA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x62DF370", Offset = "0x62DDB70", VA = "0x1862DF370")]
	public void AJKCBLFDHAF(byte[] IHDNMHOODCP, int MHPJBPKHONI, int NJOHKGIGMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public LKPPHAFGCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62DFF80", Offset = "0x62DE780", VA = "0x1862DFF80")]
	public LKPPHAFGCLG(byte[] IHDNMHOODCP, int MHPJBPKHONI, int NJOHKGIGMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x62DFAF0", Offset = "0x62DE2F0", VA = "0x1862DFAF0")]
	public IPEndPoint HEJDPMGIHAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x62DF7F0", Offset = "0x62DDFF0", VA = "0x1862DF7F0")]
	public byte PBMAPAOEJBA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x62DF7F0", Offset = "0x62DDFF0", VA = "0x1862DF7F0")]
	public sbyte GIBHHJLNJCB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x31127F0", Offset = "0x3110FF0", VA = "0x1831127F0")]
	public T[] PINGKKGHJKC<T>(ushort BOOADEANLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x62DF500", Offset = "0x62DDD00", VA = "0x1862DF500")]
	public bool[] DOILMJDEDCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x62DFD70", Offset = "0x62DE570", VA = "0x1862DFD70")]
	public ushort[] MOPPFCAJIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x62DFDB0", Offset = "0x62DE5B0", VA = "0x1862DFDB0")]
	public short[] NEBAKENMKBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x62DFBC0", Offset = "0x62DE3C0", VA = "0x1862DFBC0")]
	public int[] IAEOFEIHLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x62DFA60", Offset = "0x62DE260", VA = "0x1862DFA60")]
	public uint[] GPPMHIGGDBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x62DFE60", Offset = "0x62DE660", VA = "0x1862DFE60")]
	public float[] OGMIAPLEAEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62DFC80", Offset = "0x62DE480", VA = "0x1862DFC80")]
	public double[] JDHBDOOINBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62DFC40", Offset = "0x62DE440", VA = "0x1862DFC40")]
	public long[] IPEIMHLIGMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62DFC00", Offset = "0x62DE400", VA = "0x1862DFC00")]
	public ulong[] IFODLOCPPGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x62DF910", Offset = "0x62DE110", VA = "0x1862DF910")]
	public string[] GPLNEANMOHO(int NEILCEFCGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62DF4A0", Offset = "0x62DDCA0", VA = "0x1862DF4A0")]
	public bool CNLEJLLOHKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62DFCC0", Offset = "0x62DE4C0", VA = "0x1862DFCC0")]
	public char NBNIJFMOOAH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x62DFCC0", Offset = "0x62DE4C0", VA = "0x1862DFCC0")]
	public ushort LDHJAIBLBDB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x62DF8A0", Offset = "0x62DE0A0", VA = "0x1862DF8A0")]
	public short GJEEKFBDJFD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x62DFF10", Offset = "0x62DE710", VA = "0x1862DFF10")]
	public long PPMBDLDALCN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62DF3B0", Offset = "0x62DDBB0", VA = "0x1862DF3B0")]
	public ulong BGGGKJNLKPK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62DF830", Offset = "0x62DE030", VA = "0x1862DF830")]
	public int GIEMIGNNLEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x62DF430", Offset = "0x62DDC30", VA = "0x1862DF430")]
	public uint CHPODADDNDL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x62DFEA0", Offset = "0x62DE6A0", VA = "0x1862DFEA0")]
	public float OJPHLPDOAIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x62DF540", Offset = "0x62DDD40", VA = "0x1862DF540")]
	public double ECBBKCJFENP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62DF5B0", Offset = "0x62DDDB0", VA = "0x1862DF5B0")]
	public string FDIJOINEJJJ(int BOHJNNAGEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x62DFDF0", Offset = "0x62DE5F0", VA = "0x1862DFDF0")]
	public ArraySegment<byte> NMPBFKKNDJA(int NELOIEKKMHO)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62DFAB0", Offset = "0x62DE2B0", VA = "0x1862DFAB0")]
	public sbyte[] HDNHJNFOPHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62DFD30", Offset = "0x62DE530", VA = "0x1862DFD30")]
	public byte[] MEIMBFIAMPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62DF4E0", Offset = "0x62DDCE0", VA = "0x1862DF4E0")]
	public void CPGLBCDJJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class POECGBCENLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] PHPGHIFGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int MAKPOANCDFL;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int NHEJNJEGNMD = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool DCPIPKJKCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding GHLIPCJKFDH;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int KCMBCPGODGN = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] ONLHIHFNAGB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] OPIJNNAEPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x62EC3F0", Offset = "0x62EABF0", VA = "0x1862EC3F0")]
	public POECGBCENLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x62EC350", Offset = "0x62EAB50", VA = "0x1862EC350")]
	public POECGBCENLG(bool NJDKILCPLFA, int OGCPGJKDBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x62EBBF0", Offset = "0x62EA3F0", VA = "0x1862EBBF0")]
	public static POECGBCENLG HHJIBCBLGEC(string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x62EB620", Offset = "0x62E9E20", VA = "0x1862EB620")]
	public void AJPMBIAOFNC(int CNAOMLJPIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x229AB00", Offset = "0x2299300", VA = "0x18229AB00")]
	public void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x62EBDC0", Offset = "0x62EA5C0", VA = "0x1862EBDC0")]
	public void JJDDEALPIMH(float INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x62EC270", Offset = "0x62EAA70", VA = "0x1862EC270")]
	public void JJDDEALPIMH(double INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x62EC220", Offset = "0x62EAA20", VA = "0x1862EC220")]
	public void JJDDEALPIMH(long INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x62EC220", Offset = "0x62EAA20", VA = "0x1862EC220")]
	public void JJDDEALPIMH(ulong INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x62EBD30", Offset = "0x62EA530", VA = "0x1862EBD30")]
	public void JJDDEALPIMH(int INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x62EBD30", Offset = "0x62EA530", VA = "0x1862EBD30")]
	public void JJDDEALPIMH(uint INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x62EBC60", Offset = "0x62EA460", VA = "0x1862EBC60")]
	public void JJDDEALPIMH(char INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62EBC60", Offset = "0x62EA460", VA = "0x1862EBC60")]
	public void JJDDEALPIMH(ushort INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62EBC60", Offset = "0x62EA460", VA = "0x1862EBC60")]
	public void JJDDEALPIMH(short INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x62EBCD0", Offset = "0x62EA4D0", VA = "0x1862EBCD0")]
	public void JJDDEALPIMH(sbyte INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x62EBCD0", Offset = "0x62EA4D0", VA = "0x1862EBCD0")]
	public void JJDDEALPIMH(byte INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x62EC1B0", Offset = "0x62EA9B0", VA = "0x1862EC1B0")]
	public void JJDDEALPIMH(byte[] EBNFOODJNOB, int MHPJBPKHONI, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x62EBB10", Offset = "0x62EA310", VA = "0x1862EBB10")]
	public void GLPEMDCDGHM(sbyte[] EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x62EBB10", Offset = "0x62EA310", VA = "0x1862EBB10")]
	public void KHNJGJMMGJF(byte[] EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x62EBE70", Offset = "0x62EA670", VA = "0x1862EBE70")]
	public void JJDDEALPIMH(bool INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x62EB880", Offset = "0x62EA080", VA = "0x1862EB880")]
	public void BIGGKKFCEJM(Array KPIKEGJFCKA, int JDEGGNAPIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x62EB7A0", Offset = "0x62E9FA0", VA = "0x1862EB7A0")]
	public void BIGGKKFCEJM(float[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x62EB6C0", Offset = "0x62E9EC0", VA = "0x1862EB6C0")]
	public void BIGGKKFCEJM(double[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x62EB6C0", Offset = "0x62E9EC0", VA = "0x1862EB6C0")]
	public void BIGGKKFCEJM(long[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x62EB6C0", Offset = "0x62E9EC0", VA = "0x1862EB6C0")]
	public void BIGGKKFCEJM(ulong[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x62EB7A0", Offset = "0x62E9FA0", VA = "0x1862EB7A0")]
	public void BIGGKKFCEJM(int[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x62EB7A0", Offset = "0x62E9FA0", VA = "0x1862EB7A0")]
	public void BIGGKKFCEJM(uint[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x62EB960", Offset = "0x62EA160", VA = "0x1862EB960")]
	public void BIGGKKFCEJM(ushort[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x62EB960", Offset = "0x62EA160", VA = "0x1862EB960")]
	public void BIGGKKFCEJM(short[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x62EBB10", Offset = "0x62EA310", VA = "0x1862EBB10")]
	public void BIGGKKFCEJM(bool[] INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x62EBA40", Offset = "0x62EA240", VA = "0x1862EBA40")]
	public void BIGGKKFCEJM(string[] INDENPJBLHO, int FBFPDBCAKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x62EC0E0", Offset = "0x62EA8E0", VA = "0x1862EC0E0")]
	public void JJDDEALPIMH(IPEndPoint JALBGCIAOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x62EBE60", Offset = "0x62EA660", VA = "0x1862EBE60")]
	public void JJDDEALPIMH(string INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x62EBED0", Offset = "0x62EA6D0", VA = "0x1862EBED0")]
	public void JJDDEALPIMH(string INDENPJBLHO, int BOHJNNAGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KKJFJOGCBPF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PBNADNBGMAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong JPPMHDHPBLI;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4C0FE60", Offset = "0x4C0E660", VA = "0x184C0FE60")]
		static PBNADNBGMAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void ACKOFLLOBID(LKPPHAFGCLG GKMNBDEFGCI, object HOHMNCPBCJA);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class CHJMBFPOBCM<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public KKJFJOGCBPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CHJMBFPOBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x591EF20", Offset = "0x591D720", VA = "0x18591EF20")]
		internal void PFLAHKJOFMH(LKPPHAFGCLG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class INCJHBMDMDI<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public KKJFJOGCBPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public INCJHBMDMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4332CB0", Offset = "0x43314B0", VA = "0x184332CB0")]
		internal void PFLAHKJOFMH(LKPPHAFGCLG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GICMLPANMHK OAMNEEIFNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, ACKOFLLOBID> NBAOCJHDIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly POECGBCENLG MEMKPDNEIMN;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x62DEDF0", Offset = "0x62DD5F0", VA = "0x1862DEDF0")]
	public KKJFJOGCBPF(int NEILCEFCGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9520", Offset = "0x2DE7D20", VA = "0x182DE9520", Slot = "4")]
	protected virtual ulong LJHGKFEJEFN<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x62DEC40", Offset = "0x62DD440", VA = "0x1862DEC40", Slot = "5")]
	protected virtual ACKOFLLOBID KOOFNCPAINN(LKPPHAFGCLG GKMNBDEFGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x31030E0", Offset = "0x31018E0", VA = "0x1831030E0", Slot = "6")]
	protected virtual void BEANOOFAMGA<T>(POECGBCENLG PAOHHJOJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x62DED70", Offset = "0x62DD570", VA = "0x1862DED70")]
	public void MBMHMJCAPCB(LKPPHAFGCLG GKMNBDEFGCI, object HOHMNCPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x31034D0", Offset = "0x3101CD0", VA = "0x1831034D0")]
	public void IIOAHNKJIPB<T>(POECGBCENLG PAOHHJOJGFD, T ONHPCHOJKIM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x62DEBF0", Offset = "0x62DD3F0", VA = "0x1862DEBF0")]
	public void DCNNFEMJNDM(LKPPHAFGCLG GKMNBDEFGCI, object HOHMNCPBCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3103310", Offset = "0x3101B10", VA = "0x183103310")]
	public void CHNDKOIKKLE<T>(Action<T> NMONFFHEOLP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3103150", Offset = "0x3101950", VA = "0x183103150")]
	public void CHNDKOIKKLE<T, TUserData>(Action<T, TUserData> NMONFFHEOLP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class JBFOAFIHODH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x62DD040", Offset = "0x62DB840", VA = "0x1862DD040")]
	public JBFOAFIHODH(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NDFDBOGBIID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x62EAB00", Offset = "0x62E9300", VA = "0x1862EAB00")]
	public NDFDBOGBIID(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class GICMLPANMHK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum HINMGJMLOHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class CLLCDMJJCGB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public HINMGJMLOHB JDHDLBDLIBL;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x59389F0", Offset = "0x59371F0", VA = "0x1859389F0", Slot = "4")]
		public virtual void LDJJIOLOFEI(MethodInfo FNOPLGBCEPJ, MethodInfo ANMOJOMBPJM, HINMGJMLOHB OCLAPBNMMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void NKOGNAPJFAK(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void HICLDJHJMOO(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		protected CLLCDMJJCGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CJGCJKHJHMC<TClass, TProperty> : CLLCDMJJCGB<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> EKLHDGCDHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> AOCEJGEGJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> BGNHJPEHLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> KNGGGKAAKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> MGNMJEGJJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> FFAFPCLBJDK;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x592D8D0", Offset = "0x592C0D0", VA = "0x18592D8D0", Slot = "7")]
		public override void OFHKGMONBEC(TClass AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5926EA0", Offset = "0x59256A0", VA = "0x185926EA0", Slot = "8")]
		public override void FKEJEENJHGN(TClass AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x592CD70", Offset = "0x592B570", VA = "0x18592CD70", Slot = "9")]
		public override void NKOGNAPJFAK(TClass AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5927D20", Offset = "0x5926520", VA = "0x185927D20", Slot = "10")]
		public override void HICLDJHJMOO(TClass AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5928340", Offset = "0x5926B40", VA = "0x185928340")]
		protected TProperty[] ILEFFOFOPMP(TClass AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5927760", Offset = "0x5925F60", VA = "0x185927760")]
		protected TProperty[] GAKCLBMBFPG(TClass AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x592BC90", Offset = "0x592A490", VA = "0x18592BC90", Slot = "4")]
		public override void LDJJIOLOFEI(MethodInfo FNOPLGBCEPJ, MethodInfo ANMOJOMBPJM, HINMGJMLOHB OCLAPBNMMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4C71AA0", Offset = "0x4C702A0", VA = "0x184C71AA0")]
		protected CJGCJKHJHMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ELNODEOLLNF<TClass, TProperty> : CJGCJKHJHMC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PLCMLDJEHDE(LKPPHAFGCLG EBAPCDIJGCL, [Out] TProperty MBHFEEDEEHB);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KKAEKLBEINI(POECGBCENLG PFAJNAEPBBJ, TProperty MBHFEEDEEHB);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7BE0", Offset = "0x3CE63E0", VA = "0x183CE7BE0", Slot = "5")]
		public override void OBHBFJEPBAH(TClass AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7B60", Offset = "0x3CE6360", VA = "0x183CE7B60", Slot = "6")]
		public override void IIOAHNKJIPB(TClass AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7DE0", Offset = "0x3CE65E0", VA = "0x183CE7DE0", Slot = "7")]
		public override void OFHKGMONBEC(TClass AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7A20", Offset = "0x3CE6220", VA = "0x183CE7A20", Slot = "8")]
		public override void FKEJEENJHGN(TClass AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7EA0", Offset = "0x3CE66A0", VA = "0x183CE7EA0")]
		protected ELNODEOLLNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class DKEECCGCPEF<T> : CJGCJKHJHMC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE320", Offset = "0x5DECB20", VA = "0x185DEE320", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4A59500", Offset = "0x4A57D00", VA = "0x184A59500", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE3A0", Offset = "0x5DECBA0", VA = "0x185DEE3A0", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x406C210", Offset = "0x406AA10", VA = "0x18406C210", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public DKEECCGCPEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class NLIPNCLDPBH<T> : CJGCJKHJHMC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4A59570", Offset = "0x4A57D70", VA = "0x184A59570", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4A59500", Offset = "0x4A57D00", VA = "0x184A59500", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4A595F0", Offset = "0x4A57DF0", VA = "0x184A595F0", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x406C210", Offset = "0x406AA10", VA = "0x18406C210", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public NLIPNCLDPBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class EMBAHCHJGFF<T> : CJGCJKHJHMC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7FC0", Offset = "0x3CE67C0", VA = "0x183CE7FC0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7F50", Offset = "0x3CE6750", VA = "0x183CE7F50", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8040", Offset = "0x3CE6840", VA = "0x183CE8040", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7EE0", Offset = "0x3CE66E0", VA = "0x183CE7EE0", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public EMBAHCHJGFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class CEJJAICLCEH<T> : CJGCJKHJHMC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x58403A0", Offset = "0x583EBA0", VA = "0x1858403A0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7F50", Offset = "0x3CE6750", VA = "0x183CE7F50", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5840420", Offset = "0x583EC20", VA = "0x185840420", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7EE0", Offset = "0x3CE66E0", VA = "0x183CE7EE0", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public CEJJAICLCEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CFLNKLGPPJP<T> : CJGCJKHJHMC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5844240", Offset = "0x5842A40", VA = "0x185844240", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x405F390", Offset = "0x405DB90", VA = "0x18405F390", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x58442C0", Offset = "0x5842AC0", VA = "0x1858442C0", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x405F320", Offset = "0x405DB20", VA = "0x18405F320", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public CFLNKLGPPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FDAMPLCOLOP<T> : CJGCJKHJHMC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x405F400", Offset = "0x405DC00", VA = "0x18405F400", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x405F390", Offset = "0x405DB90", VA = "0x18405F390", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x405F480", Offset = "0x405DC80", VA = "0x18405F480", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x405F320", Offset = "0x405DB20", VA = "0x18405F320", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public FDAMPLCOLOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class FBDNJDPIKJC<T> : CJGCJKHJHMC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4050EA0", Offset = "0x404F6A0", VA = "0x184050EA0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4050E30", Offset = "0x404F630", VA = "0x184050E30", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4050F20", Offset = "0x404F720", VA = "0x184050F20", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4050DC0", Offset = "0x404F5C0", VA = "0x184050DC0", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public FBDNJDPIKJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class PFJPCLDPMIG<T> : CJGCJKHJHMC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4050EA0", Offset = "0x404F6A0", VA = "0x184050EA0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4050E30", Offset = "0x404F630", VA = "0x184050E30", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C35240", Offset = "0x4C33A40", VA = "0x184C35240", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4050DC0", Offset = "0x404F5C0", VA = "0x184050DC0", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public PFJPCLDPMIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FJGLGBCKCFK<T> : CJGCJKHJHMC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x406C2F0", Offset = "0x406AAF0", VA = "0x18406C2F0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x406C280", Offset = "0x406AA80", VA = "0x18406C280", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x406C370", Offset = "0x406AB70", VA = "0x18406C370", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x406C210", Offset = "0x406AA10", VA = "0x18406C210", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public FJGLGBCKCFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DKAJGLOGAJG<T> : CJGCJKHJHMC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE220", Offset = "0x5DECA20", VA = "0x185DEE220", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE1B0", Offset = "0x5DEC9B0", VA = "0x185DEE1B0", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE2A0", Offset = "0x5DECAA0", VA = "0x185DEE2A0", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x405F320", Offset = "0x405DB20", VA = "0x18405F320", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public DKAJGLOGAJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class DDMABBMDBAD<T> : CJGCJKHJHMC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5D93D80", Offset = "0x5D92580", VA = "0x185D93D80", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D93D10", Offset = "0x5D92510", VA = "0x185D93D10", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D93E00", Offset = "0x5D92600", VA = "0x185D93E00", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4050DC0", Offset = "0x404F5C0", VA = "0x184050DC0", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3CE80C0", Offset = "0x3CE68C0", VA = "0x183CE80C0")]
		public DDMABBMDBAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class OKOGOALEBDG<T> : ELNODEOLLNF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4B5CAB0", Offset = "0x4B5B2B0", VA = "0x184B5CAB0", Slot = "12")]
		protected override void KKAEKLBEINI(POECGBCENLG PFAJNAEPBBJ, char MBHFEEDEEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4B5CAE0", Offset = "0x4B5B2E0", VA = "0x184B5CAE0", Slot = "11")]
		protected override void PLCMLDJEHDE(LKPPHAFGCLG EBAPCDIJGCL, [Out] char MBHFEEDEEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6850", Offset = "0x3CC5050", VA = "0x183CC6850")]
		public OKOGOALEBDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JGDMADCNAEB<T> : ELNODEOLLNF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x452B910", Offset = "0x452A110", VA = "0x18452B910", Slot = "12")]
		protected override void KKAEKLBEINI(POECGBCENLG PFAJNAEPBBJ, IPEndPoint MBHFEEDEEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x452B940", Offset = "0x452A140", VA = "0x18452B940", Slot = "11")]
		protected override void PLCMLDJEHDE(LKPPHAFGCLG EBAPCDIJGCL, [Out] IPEndPoint MBHFEEDEEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6850", Offset = "0x3CC5050", VA = "0x183CC6850")]
		public JGDMADCNAEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CIFALLLILAA<T> : CJGCJKHJHMC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int ANNFJJOEEON;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5925680", Offset = "0x5923E80", VA = "0x185925680")]
		public CIFALLLILAA(int BOHJNNAGEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5925580", Offset = "0x5923D80", VA = "0x185925580", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5925500", Offset = "0x5923D00", VA = "0x185925500", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5925600", Offset = "0x5923E00", VA = "0x185925600", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5925480", Offset = "0x5923C80", VA = "0x185925480", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FGLCNDCPJNN<T> : CLLCDMJJCGB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo HICLNKEGJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type PKECFHLGJHF;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x406A830", Offset = "0x4069030", VA = "0x18406A830")]
		public FGLCNDCPJNN(PropertyInfo MFCFAMOHGBK, Type AAJLGHJONGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x406A710", Offset = "0x4068F10", VA = "0x18406A710", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x406A600", Offset = "0x4068E00", VA = "0x18406A600", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x406A7D0", Offset = "0x4068FD0", VA = "0x18406A7D0", Slot = "7")]
		public override void OFHKGMONBEC(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x406A540", Offset = "0x4068D40", VA = "0x18406A540", Slot = "8")]
		public override void FKEJEENJHGN(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x406A6B0", Offset = "0x4068EB0", VA = "0x18406A6B0", Slot = "9")]
		public override void NKOGNAPJFAK(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x406A5A0", Offset = "0x4068DA0", VA = "0x18406A5A0", Slot = "10")]
		public override void HICLDJHJMOO(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class LGIEOCFEKCM<T> : FGLCNDCPJNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4350", Offset = "0x3CC2B50", VA = "0x183CC4350")]
		public LGIEOCFEKCM(PropertyInfo MFCFAMOHGBK, Type AAJLGHJONGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4724BE0", Offset = "0x47233E0", VA = "0x184724BE0", Slot = "5")]
		public override void OBHBFJEPBAH(T AHBNIMGOHCK, LKPPHAFGCLG EBAPCDIJGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4724B30", Offset = "0x4723330", VA = "0x184724B30", Slot = "6")]
		public override void IIOAHNKJIPB(T AHBNIMGOHCK, POECGBCENLG PFAJNAEPBBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HJHLBDBDOKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static HJHLBDBDOKJ<T> ODDIIHPHFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly CLLCDMJJCGB<T>[] KJLAAIOLDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int PAEGPPODMLH;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x422D350", Offset = "0x422BB50", VA = "0x18422D350")]
		public HJHLBDBDOKJ(List<CLLCDMJJCGB<T>> PJJACFLDIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x422D1F0", Offset = "0x422B9F0", VA = "0x18422D1F0")]
		public void IIOAHNKJIPB(T INCBEIDOHDO, POECGBCENLG PAOHHJOJGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x422D2A0", Offset = "0x422BAA0", VA = "0x18422D2A0")]
		public void OBHBFJEPBAH(T INCBEIDOHDO, LKPPHAFGCLG GKMNBDEFGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MAANBICKEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract CLLCDMJJCGB<T> EFGCOGNKKLM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private POECGBCENLG AJPOOEFNDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int HHMMAFGBAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, MAANBICKEHD> FLIJHJHHEMD;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x62DCFA0", Offset = "0x62DB7A0", VA = "0x1862DCFA0")]
	public GICMLPANMHK(int NEILCEFCGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x307CB70", Offset = "0x307B370", VA = "0x18307CB70")]
	private HJHLBDBDOKJ<T> PKAOGDCMFAM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DD10", Offset = "0x2E5C510", VA = "0x182E5DD10")]
	public void CCEDGNHHKOL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x307CAD0", Offset = "0x307B2D0", VA = "0x18307CAD0")]
	public bool KDFBDMHOPOO<T>(LKPPHAFGCLG GKMNBDEFGCI, T BIINCLMPDMO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x307CA40", Offset = "0x307B240", VA = "0x18307CA40")]
	public void KBGBIJFEDIC<T>(POECGBCENLG PAOHHJOJGFD, T INCBEIDOHDO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FJMLAMPPADN
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime OGPLABHBDNM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] KLIGPFMOHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CKDAGEIEKDE KPIMFCGAOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x62DB2F0", Offset = "0x62D9AF0", VA = "0x1862DB2F0")]
		get
		{
			return default(CKDAGEIEKDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GENMGDBNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x62DB8B0", Offset = "0x62DA0B0", VA = "0x1862DB8B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x62DB120", Offset = "0x62D9920", VA = "0x1862DB120")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BPOEDGBFGEE BKHKCOOPHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x62DC030", Offset = "0x62DA830", VA = "0x1862DC030")]
		get
		{
			return default(BPOEDGBFGEE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x62DB160", Offset = "0x62D9960", VA = "0x1862DB160")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KIAPGLKCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x62DB0F0", Offset = "0x62D98F0", VA = "0x1862DB0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint IBGAMNNINBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x62DBBE0", Offset = "0x62DA3E0", VA = "0x1862DBBE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? INLHBPABDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x62DB1A0", Offset = "0x62D99A0", VA = "0x1862DB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? NLMHBJMCOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x62DB3E0", Offset = "0x62D9BE0", VA = "0x1862DB3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? HLJEOAGMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x62DB320", Offset = "0x62D9B20", VA = "0x1862DB320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x62DB410", Offset = "0x62D9C10", VA = "0x1862DB410")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BGKMKAGBKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DB680", Offset = "0x9D9E80", VA = "0x1809DB680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x62DC0C0", Offset = "0x62DA8C0", VA = "0x1862DC0C0")]
	public FJMLAMPPADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x62DC3E0", Offset = "0x62DABE0", VA = "0x1862DC3E0")]
	internal FJMLAMPPADN(byte[] LMGNHIJGDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x62DB1D0", Offset = "0x62D99D0", VA = "0x1862DB1D0")]
	public static FJMLAMPPADN CABPIFPLFBD(byte[] LMGNHIJGDNP, DateTime FGCJLKJPEAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x62DBC60", Offset = "0x62DA460", VA = "0x1862DBC60")]
	internal void OKLGEHIGHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x62DBA00", Offset = "0x62DA200", VA = "0x1862DBA00")]
	private void MPIJGJMFLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x62DB5E0", Offset = "0x62D9DE0", VA = "0x1862DB5E0")]
	private DateTime? IGFABAILAFL(int MHPJBPKHONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x62DBE60", Offset = "0x62DA660", VA = "0x1862DBE60")]
	private void PJADCOPBMMF(int MHPJBPKHONI, DateTime? INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x62DB7E0", Offset = "0x62D9FE0", VA = "0x1862DB7E0")]
	private ulong KOGEMOLPBAA(int MHPJBPKHONI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x62DB8E0", Offset = "0x62DA0E0", VA = "0x1862DB8E0")]
	private void MKJCBGPDDCM(int MHPJBPKHONI, ulong INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x62DB350", Offset = "0x62D9B50", VA = "0x1862DB350")]
	private uint FKKDPNIMKAO(int MHPJBPKHONI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x61A78C0", Offset = "0x61A60C0", VA = "0x1861A78C0")]
	private static uint MLFPMDHLPOM(uint KHINBLFKKED)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x62DB9A0", Offset = "0x62DA1A0", VA = "0x1862DB9A0")]
	private static ulong MLFPMDHLPOM(ulong KHINBLFKKED)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CKDAGEIEKDE
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
public enum BPOEDGBFGEE
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class KBAKGGFCJOD
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int HDGEJBAOOKB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int NIOKJBHOCFC = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int CHMMMNGDJDM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint IHBPOLBHPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int IFOBJKPPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int BPHKLFJJDJH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MMBMBGCGLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x62DDA30", Offset = "0x62DC230", VA = "0x1862DDA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x62DDA40", Offset = "0x62DC240", VA = "0x1862DDA40")]
	public bool IFHBBEBHCCB(CBCLFDOJNHD PANAHEEPKGF, int MHAEBFLONHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EFMNADOLIHB : CBCLFDOJNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket PANAHEEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly LMIEHNKLMON EEJNJAFBGKL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short DEGJHDJMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x62D61E0", Offset = "0x62D49E0", VA = "0x1862D61E0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JPAGPOGOCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x62D6200", Offset = "0x62D4A00", VA = "0x1862D6200", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint EGEDOFDBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x62D5BA0", Offset = "0x62D43A0", VA = "0x1862D5BA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily MHMNMCKLBML
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x46CB4E0", Offset = "0x46C9CE0", VA = "0x1846CB4E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x62D6220", Offset = "0x62D4A20", VA = "0x1862D6220")]
	public EFMNADOLIHB(AddressFamily EIAKDLOMKKD, LMIEHNKLMON EEJNJAFBGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x62D5BC0", Offset = "0x62D43C0", VA = "0x1862D5BC0", Slot = "8")]
	public bool HHOJIFCOLIA(IPEndPoint JALBGCIAOLG, LJCGGDLLAAL FCBJLBFDGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x62D61A0", Offset = "0x62D49A0", VA = "0x1862D61A0", Slot = "9")]
	public int OCBMNMHNPNJ(byte[] ENCIEGIIIHM, int MHPJBPKHONI, int BOOADEANLJB, IPEndPoint BHFFFDFLCFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x62D5AB0", Offset = "0x62D42B0", VA = "0x1862D5AB0", Slot = "10")]
	public int CANEIHOBKBP(byte[] ENCIEGIIIHM, EndPoint GLCMPEHINDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x62D6180", Offset = "0x62D4980", VA = "0x1862D6180", Slot = "11")]
	public void NBJDGAMPOMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface CBCLFDOJNHD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short DEGJHDJMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int JPAGPOGOCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint EGEDOFDBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily MHMNMCKLBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHOJIFCOLIA(IPEndPoint JALBGCIAOLG, LJCGGDLLAAL FCBJLBFDGGH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int OCBMNMHNPNJ(byte[] ENCIEGIIIHM, int MHPJBPKHONI, int BOOADEANLJB, IPEndPoint BHFFFDFLCFB);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CANEIHOBKBP(byte[] ENCIEGIIIHM, EndPoint BHFFFDFLCFB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBJDGAMPOMP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct LEKMJFDMILK : IEquatable<LEKMJFDMILK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long GOMIDJDAHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long LLLBGPKCNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long CCPDMKJFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int HGFGIAGAKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int NMIBMOEMOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x62DF1E0", Offset = "0x62DD9E0", VA = "0x1862DF1E0")]
	public LEKMJFDMILK(byte[] MDIGHMBBJIL, int LONJGICKPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8A0", Offset = "0x8DD0A0", VA = "0x1808DE8A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x62DF1A0", Offset = "0x62DD9A0", VA = "0x1862DF1A0", Slot = "4")]
	public bool Equals(LEKMJFDMILK LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x62DF0F0", Offset = "0x62DD8F0", VA = "0x1862DF0F0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class ENMCJFIPLDI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] CKFLLCLNNDL;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HJGOHFJJIKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int CFNOPMIADJE;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
	protected HJGOHFJJIKG(int CHIICKJMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PHHJEHGBIFN(IPEndPoint JALBGCIAOLG, byte[] EBNFOODJNOB, int MHPJBPKHONI, int OANKAJFHCKB);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DLMLPLPJIJC(IPEndPoint JALBGCIAOLG, byte[] EBNFOODJNOB, int MHPJBPKHONI, int OANKAJFHCKB);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FOKMOGPJEOK : HJGOHFJJIKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] KCGKBDGKIOP;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator CHONMFDMLII;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x234A3C0", Offset = "0x2348BC0", VA = "0x18234A3C0")]
	public FOKMOGPJEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x62DC8E0", Offset = "0x62DB0E0", VA = "0x1862DC8E0")]
	public void MGPOHFINFDB(IPEndPoint JALBGCIAOLG, byte[] KCGKBDGKIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x62DC490", Offset = "0x62DAC90", VA = "0x1862DC490")]
	public void BJHGMLNKOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x62DCA90", Offset = "0x62DB290", VA = "0x1862DCA90", Slot = "4")]
	public override void PHHJEHGBIFN(IPEndPoint JALBGCIAOLG, byte[] EBNFOODJNOB, int MHPJBPKHONI, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x62DC570", Offset = "0x62DAD70", VA = "0x1862DC570", Slot = "5")]
	public override void DLMLPLPJIJC(IPEndPoint JALBGCIAOLG, byte[] EBNFOODJNOB, int MHPJBPKHONI, int OANKAJFHCKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct ELPGPEPLACM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void OOLPMAFNJGH([NoAlias] byte* PMAHNMELIJC, [NoAlias] byte* KCGKBDGKIOP, [NoAlias] byte* NHPCNHDMPFC, int OANKAJFHCKB);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KLGJPBPBCEC
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr MJINEFJJNEO;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr GKPNDKPKJLF;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x62EC470", Offset = "0x62EAC70", VA = "0x1862EC470")]
		[BurstDiscard]
		private static void DJPCPJEPBPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x62EC890", Offset = "0x62EB090", VA = "0x1862EC890")]
		private static IntPtr MEPNGLLAIHD()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x62EC5A0", Offset = "0x62EADA0", VA = "0x1862EC5A0")]
		public static void HCADLKKGDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		public static void EHFCOOMFLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x62EC650", Offset = "0x62EAE50", VA = "0x1862EC650")]
		public unsafe static void JOEKNDNMBGL([NoAlias] byte* PMAHNMELIJC, [NoAlias] byte* KCGKBDGKIOP, [NoAlias] byte* NHPCNHDMPFC, int OANKAJFHCKB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint KCGKBDGKIOP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint NHPCNHDMPFC[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint AKPDGNECHBC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint LPPDAPEHAHE[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KDFFIEIKADN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint HGLLLPAOAFM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint MDGMIBFBMKC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint LJBHACGDLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint DFGGKGAMAJC[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x62DA900", Offset = "0x62D9100", VA = "0x1862DA900")]
	private void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x62DA980", Offset = "0x62D9180", VA = "0x1862DA980")]
	private uint HJMHAOAIGAI(uint JBEGGBDGOGM, int GCCIIPGIGLN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x62D4C20", Offset = "0x62D3420", VA = "0x1862D4C20")]
	private void KFHENMDEEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x62D4D60", Offset = "0x62D3560", VA = "0x1862D4D60")]
	private void MBMGPBACIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x62D4CD0", Offset = "0x62D34D0", VA = "0x1862D4CD0")]
	private void LPLDGKHBKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x62D4B20", Offset = "0x62D3320", VA = "0x1862D4B20")]
	private void EOIIMDGEOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x62DA380", Offset = "0x62D8B80", VA = "0x1862DA380")]
	private void BPCJPPPBHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x62DA4E0", Offset = "0x62D8CE0", VA = "0x1862DA4E0")]
	private unsafe void ELFPPLCLECK(byte* PMAHNMELIJC, uint* KCGKBDGKIOP, uint* NHPCNHDMPFC, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x62DAB00", Offset = "0x62D9300", VA = "0x1862DAB00")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JLJFOFPMOML([NoAlias] byte* PMAHNMELIJC, [NoAlias] byte* KCGKBDGKIOP, [NoAlias] byte* NHPCNHDMPFC, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x62DAA20", Offset = "0x62D9220", VA = "0x1862DAA20")]
	public static void JLJFOFPMOML(Span<byte> PMAHNMELIJC, Span<byte> KCGKBDGKIOP, Span<byte> NHPCNHDMPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x62DA3E0", Offset = "0x62D8BE0", VA = "0x1862DA3E0")]
	public static void CBCBHGKENMI(Span<byte> PMAHNMELIJC, Span<byte> KCGKBDGKIOP, Span<byte> NHPCNHDMPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x62DA9B0", Offset = "0x62D91B0", VA = "0x1862DA9B0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JDPOGPDNBCB([NoAlias] byte* PMAHNMELIJC, [NoAlias] byte* KCGKBDGKIOP, [NoAlias] byte* NHPCNHDMPFC, int OANKAJFHCKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x62ECAF0", Offset = "0x62EB2F0", VA = "0x1862ECAF0")]
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
