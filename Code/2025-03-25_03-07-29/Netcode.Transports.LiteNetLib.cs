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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LEBBNOCHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JGNHDABGMHB
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
		private NetworkManager GKFFANLLIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool NGDDOFNEDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, MMOAOFJNGCJ> ABCCDJGCKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NDPNMFCPABG FKICKDBMFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch INBJGEMIBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] LBEJBAOPDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JGNHDABGMHB JCEOLBOKILK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong DOOLLOGOKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool BFFILGJAMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6AE1CC0", Offset = "0x6AE10C0", VA = "0x186AE1CC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1240", Offset = "0x6AE0640", VA = "0x186AE1240")]
		public void RecRoom_SetEncryptionInfo(ulong GAOHLLDFAJO, byte[] MCBJECJLDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1220", Offset = "0x6AE0620", VA = "0x186AE1220")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AE10F0", Offset = "0x6AE04F0", VA = "0x186AE10F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1BC0", Offset = "0x6AE0FC0", VA = "0x186AE1BC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1360", Offset = "0x6AE0760", VA = "0x186AE1360", Slot = "6")]
		public override void Send(ulong EHBCLENPDLO, ArraySegment<byte> AMHCLKHIFKH, NetworkDelivery FPDMLENOFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE11E0", Offset = "0x6AE05E0", VA = "0x186AE11E0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong EHBCLENPDLO, [Out] ArraySegment<byte> KGCLHKOHKLJ, [Out] float ECAECANHPPP)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1650", Offset = "0x6AE0A50", VA = "0x186AE1650", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1AE0", Offset = "0x6AE0EE0", VA = "0x186AE1AE0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0AF0", Offset = "0x6ADFEF0", VA = "0x186AE0AF0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong EHBCLENPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0A00", Offset = "0x6ADFE00", VA = "0x186AE0A00", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0C00", Offset = "0x6AE0000", VA = "0x186AE0C00", Slot = "13")]
		public override ulong GetCurrentRtt(ulong EHBCLENPDLO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6AE15E0", Offset = "0x6AE09E0", VA = "0x186AE15E0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0DE0", Offset = "0x6AE01E0", VA = "0x186AE0DE0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager GKFFANLLIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0FF0", Offset = "0x6AE03F0", VA = "0x186AE0FF0")]
		private IDOGBCMDMEF LBFJKGKBJII(NetworkDelivery MAIGGPEPIHD)
		{
			return default(IDOGBCMDMEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0D20", Offset = "0x6AE0120", VA = "0x186AE0D20", Slot = "16")]
		private void HKIACONAOAI(MMOAOFJNGCJ JANOAOHDNEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0850", Offset = "0x6ADFC50", VA = "0x186AE0850", Slot = "17")]
		private void AHEPOFDHIEA(MMOAOFJNGCJ JANOAOHDNEG, AKMOAKCCNNC KLLKMFCEFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "18")]
		private void LANGOHBOCDL(IPEndPoint GLLKALOCBHK, SocketError DNJOHPDDMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0640", Offset = "0x6ADFA40", VA = "0x186AE0640", Slot = "19")]
		private void AFMPEBMAEMD(MMOAOFJNGCJ JANOAOHDNEG, FODDGOHOKNP KILJCGGJECG, byte EGPCMKGPGJG, IDOGBCMDMEF KLNFAJPKLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0920", Offset = "0x6ADFD20", VA = "0x186AE0920")]
		private void CGCJDPBIAOM(int EOKAMHLPIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "20")]
		private void NBDHJNHIGOA(IPEndPoint LDGPJCAKDIC, FODDGOHOKNP KILJCGGJECG, CDDLLHICOGM KNDLPHBBPCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "21")]
		private void COEMCFFOPIO(MMOAOFJNGCJ JANOAOHDNEG, int HOLPBOGNIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0CC0", Offset = "0x6AE00C0", VA = "0x186AE0CC0", Slot = "22")]
		private void HKEBOPBPGGL(KAPMKOEKCNP INLHACAOAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE10C0", Offset = "0x6AE04C0", VA = "0x186AE10C0")]
		private ulong LPEHEPLGLNI(MMOAOFJNGCJ JANOAOHDNEG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0CA0", Offset = "0x6AE00A0", VA = "0x186AE0CA0")]
		private static int HGAKKGJEIOE(float LLAIDEDFOJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1BE0", Offset = "0x6AE0FE0", VA = "0x186AE1BE0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class LEEKIOOPFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly MMOAOFJNGCJ JGIFAAAPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<HPCPBKBEEMB> JPGKBJPPFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int LKJPEELNLMF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE00D0", Offset = "0x6ADF4D0", VA = "0x186AE00D0")]
	protected LEEKIOOPFMN(MMOAOFJNGCJ JANOAOHDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0070", Offset = "0x6ADF470", VA = "0x186AE0070")]
	public void IGBANBLDNJG(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFFF0", Offset = "0x6ADF3F0", VA = "0x186ADFFF0")]
	protected void IAKPJIGCFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFFB0", Offset = "0x6ADF3B0", VA = "0x186ADFFB0")]
	public bool EDBKJPKKAEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MLFKPBMAHLE();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool POBHDIICJOL(HPCPBKBEEMB MBJFCAKDJJM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum LENKKJHOIMG
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
public class KAPMKOEKCNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly NDPNMFCPABG IICOAEBDEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int DFIBAKJBJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal LKGDHEABPEK AEBEFJGBEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint LCGJMNNEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LENKKJHOIMG NECKINNBEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B9CD0", Offset = "0x9B90D0", VA = "0x1809B9CD0")]
		[CompilerGenerated]
		get
		{
			return default(LENKKJHOIMG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCA0400", Offset = "0xC9F800", VA = "0x180CA0400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEA80", Offset = "0x6ADDE80", VA = "0x186ADEA80")]
	internal void PIIDEBKOCCD(LKGDHEABPEK LFBHJDGGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEA50", Offset = "0x6ADDE50", VA = "0x186ADEA50")]
	private bool NDMIMKKOGMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEAE0", Offset = "0x6ADDEE0", VA = "0x186ADEAE0")]
	internal KAPMKOEKCNP(IPEndPoint LDGPJCAKDIC, LKGDHEABPEK NGCCAMNPFJN, NDPNMFCPABG JDJFEKKOFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE9F0", Offset = "0x6ADDDF0", VA = "0x186ADE9F0")]
	public MMOAOFJNGCJ BFDJNFJDLHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CDDLLHICOGM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MNFHADBGMLE
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
public struct AKMOAKCCNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MNFHADBGMLE MKCGIMJJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError ECFMONAPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FODDGOHOKNP ALCADLFBIGN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LEBBNOCHFAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOJJJHNGFLB(MMOAOFJNGCJ JANOAOHDNEG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGCHDKLAOBB(MMOAOFJNGCJ JANOAOHDNEG, AKMOAKCCNNC KLLKMFCEFBD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDOKAJKIBBI(IPEndPoint GLLKALOCBHK, SocketError DNJOHPDDMOH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMBELPEPMNA(MMOAOFJNGCJ JANOAOHDNEG, FODDGOHOKNP KILJCGGJECG, byte EGPCMKGPGJG, IDOGBCMDMEF KLNFAJPKLGN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNCICIPBFGK(IPEndPoint LDGPJCAKDIC, FODDGOHOKNP KILJCGGJECG, CDDLLHICOGM KNDLPHBBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBOPENMFAHD(MMOAOFJNGCJ JANOAOHDNEG, int HOLPBOGNIMA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKMEDFDDMJM(KAPMKOEKCNP INLHACAOAMD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HNIEJOCNLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHDBGJNHNPI(MMOAOFJNGCJ JANOAOHDNEG, object CPLCNCAFBDG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KCJDDJGKLGO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPEDGDEHCOM(JEGCPMLEIPE MBJFCAKDJJM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LINFBCHDBFK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDKOMMJKHKC(MMOAOFJNGCJ JANOAOHDNEG, IPEndPoint PNIJJBHDKID);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LKGDHEABPEK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int CJHPFPHICJA = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long EBIGOJAHIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte LANBDILAFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] GILENJOCFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KKNPENMGICP CBNHMBHNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int DEIOCDHHOEE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AE05D0", Offset = "0x6ADF9D0", VA = "0x186AE05D0")]
	private LKGDHEABPEK(long ICMBLDEPFEF, byte IJDOIIHAAKN, int MBPEAJOCCID, byte[] FDBPOCCAABE, KKNPENMGICP AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0390", Offset = "0x6ADF790", VA = "0x186AE0390")]
	public static int EAKDDJLFKDK(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0170", Offset = "0x6ADF570", VA = "0x186AE0170")]
	public static LKGDHEABPEK BFIKLOHBFEK(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AE03F0", Offset = "0x6ADF7F0", VA = "0x186AE03F0")]
	public static HPCPBKBEEMB PDIJFPPKPMN(IAKLECKPNKG CCPCCLOHBHH, SocketAddress JHIFACMEIKK, long MACBEHNEHNO, int MBPEAJOCCID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OHNNFNLDJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long EBIGOJAHIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte LANBDILAFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int DEIOCDHHOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool KHACHGLIDAP;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AEED60", Offset = "0x6AEE160", VA = "0x186AEED60")]
	private OHNNFNLDJPF(long ICMBLDEPFEF, byte IJDOIIHAAKN, int EPMODCCIJAB, bool PIKELLEONCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEA20", Offset = "0x6AEDE20", VA = "0x186AEEA20")]
	public static OHNNFNLDJPF BFIKLOHBFEK(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEC70", Offset = "0x6AEE070", VA = "0x186AEEC70")]
	public static HPCPBKBEEMB PDIJFPPKPMN(long MACBEHNEHNO, byte IAKFPNFBCEB, int BIHHPLPHPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEB70", Offset = "0x6AEDF70", VA = "0x186AEEB70")]
	public static HPCPBKBEEMB LHOEHKJHAMK(MMOAOFJNGCJ JANOAOHDNEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum AEFPJBIKLHM
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EBOMELJKAKH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KONCOJLKNFG(IPEndPoint LKAILKFKFKP, IPEndPoint LDGPJCAKDIC, string HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PODIDJCNCCG(IPEndPoint PJNDOHLPIIL, AEFPJBIKLHM MAIGGPEPIHD, string HEJFDMJNIGB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class OHDILHOBLGA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OLEIDMFNBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint PFHHJNHLAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint LCGJMNNEEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string OCLINABENBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FAOBMKDIFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint NCODMAHLNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AEFPJBIKLHM PONMJFHCNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string OCLINABENBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class FPBIBOGJKPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint OBHCMAPMIMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string OCLINABENBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FPBIBOGJKPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class FHNPFBEKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint OBHCMAPMIMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NDCPNNGBBJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string OCLINABENBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FHNPFBEKNAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class DAMCCCADBFO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OCLINABENBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ALPHJEJHHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x996F20", Offset = "0x996320", VA = "0x180996F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DAMCCCADBFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly NDPNMFCPABG HJLLJFPBCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<OLEIDMFNBCN> JENOGCMGMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<FAOBMKDIFIL> FNEBCCEACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KKNPENMGICP NJOCBBKHMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IAKLECKPNKG AAEIIGJJIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly MPPLDFABDPK JDJDNJILHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EBOMELJKAKH EEICCELDPHC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int GCPHGJHFPML = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool KNDGAMGKDKH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE5D0", Offset = "0x6AED9D0", VA = "0x186AEE5D0")]
	internal OHDILHOBLGA(NDPNMFCPABG NBLDEEBAIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE160", Offset = "0x6AED560", VA = "0x186AEE160")]
	internal void GPFGIBEHEEM(IPEndPoint OCIHPHKNJKE, HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37CDCE0", Offset = "0x37CD0E0", VA = "0x1837CDCE0")]
	private void PKEBBBGBIGG<T>(T MBJFCAKDJJM, IPEndPoint JMBMDICGCNK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE2E0", Offset = "0x6AED6E0", VA = "0x186AEE2E0")]
	private void KONCOJLKNFG(FPBIBOGJKPM GLJPMPKNDKK, IPEndPoint OCIHPHKNJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE470", Offset = "0x6AED870", VA = "0x186AEE470")]
	private void OPHNHFCMKHC(FHNPFBEKNAM GLJPMPKNDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDFC0", Offset = "0x6AED3C0", VA = "0x186AEDFC0")]
	private void GJNPHMCGENA(DAMCCCADBFO GLJPMPKNDKK, IPEndPoint OCIHPHKNJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IDOGBCMDMEF : byte
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
public enum MFKBKGIBDBH : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class ENHPMILAKJD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] AEPNNOBHIPI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int FPHKECECOOH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int NMEMMJBLOBA;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HNMOEJJGFPM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7F90", Offset = "0x6AD7390", VA = "0x186AD7F90")]
	public HNMOEJJGFPM(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PJAFCIMABKG : HNMOEJJGFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7F90", Offset = "0x6AD7390", VA = "0x186AD7F90")]
	public PJAFCIMABKG(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OFEFKDKDENH
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
public interface MMDEGPIHBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCGJHONAMHP(OFEFKDKDENH FHNCPADKJBC, string DBFOBELGJDB, params object[] JOIGLCNPHIH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EDGOJDCHCIA
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static MMDEGPIHBMJ EFDCKABGFHP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object KCCIEHIFCMH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9B00", Offset = "0x6AD8F00", VA = "0x186AD9B00")]
	private static void JFJEIMNEELP(OFEFKDKDENH PEFAGHJHMCC, string DBFOBELGJDB, params object[] JOIGLCNPHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9D30", Offset = "0x6AD9130", VA = "0x186AD9D30")]
	internal static void NEFEHODGLFJ(string DBFOBELGJDB, params object[] JOIGLCNPHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9D90", Offset = "0x6AD9190", VA = "0x186AD9D90")]
	internal static void PHJBBFPLCHE(string DBFOBELGJDB, params object[] JOIGLCNPHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9AA0", Offset = "0x6AD8EA0", VA = "0x186AD9AA0")]
	internal static void EBCPIOCNNJM(string DBFOBELGJDB, params object[] JOIGLCNPHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FHHKPDKJADB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FODDGOHOKNP : KKNPENMGICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private HPCPBKBEEMB FJPOPHEEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NDPNMFCPABG NFHJMGNHPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly DLIDPLMNNOK DCEEOMCMFMK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA190", Offset = "0x6AD9590", VA = "0x186ADA190")]
	internal FODDGOHOKNP(NDPNMFCPABG ECPDNOJCJEA, DLIDPLMNNOK LIJAPOOCIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA070", Offset = "0x6AD9470", VA = "0x186ADA070")]
	internal void CLECNLFEHOL(HPCPBKBEEMB MBJFCAKDJJM, int DJAHEDKDMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA0E0", Offset = "0x6AD94E0", VA = "0x186ADA0E0")]
	internal void DEFKOALANOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA160", Offset = "0x6AD9560", VA = "0x186ADA160")]
	public void NLDMEOEMDMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class DLIDPLMNNOK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PJNGLCMLNPG
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
	public DLIDPLMNNOK FOBEBPIMKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public PJNGLCMLNPG PONMJFHCNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public MMOAOFJNGCJ JGIFAAAPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint LCGJMNNEEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object BBMFKBNLACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int EPJBNHODOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError NGJNNPHKGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public MNFHADBGMLE PKBOJPFBFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public KAPMKOEKCNP PGBNOIINFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public IDOGBCMDMEF CIPNPEAGLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte IPEBCNNHJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly FODDGOHOKNP OGFPEDJMCOO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9A00", Offset = "0x6AD8E00", VA = "0x186AD9A00")]
	public DLIDPLMNNOK(NDPNMFCPABG ECPDNOJCJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NDPNMFCPABG : IEnumerable<MMOAOFJNGCJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class BKDIAPPDMFH : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8800", Offset = "0x6AD7C00", VA = "0x186AD8800", Slot = "4")]
		public bool Equals(IPEndPoint JFJPEDLJOKC, IPEndPoint MJINJIJLGDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6608640", Offset = "0x6607A40", VA = "0x186608640", Slot = "5")]
		public int GetHashCode(IPEndPoint HAPOBHMBDHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BKDIAPPDMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CMOAEFLCOGG : IEnumerator<MMOAOFJNGCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly MMOAOFJNGCJ PMCBIOIGGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MMOAOFJNGCJ ANCJPAALAIN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MMOAOFJNGCJ NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCDD060", Offset = "0xCDC460", VA = "0x180CDD060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCDD060", Offset = "0xCDC460", VA = "0x180CDD060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x18A9940", Offset = "0x18A8D40", VA = "0x1818A9940")]
		public CMOAEFLCOGG(MMOAOFJNGCJ GGAJNINGNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9040", Offset = "0x6AD8440", VA = "0x186AD9040", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9090", Offset = "0x6AD8490", VA = "0x186AD9090", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread MDAJELBEDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool KCIIAHGDGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool MHIMGLBMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private PMNDJJNCCOO JJGLFOKDIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent JHONNJMDCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<DLIDPLMNNOK> FEGLPNOLFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<DLIDPLMNNOK> GBJMJMNPCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private DLIDPLMNNOK LJICMABMKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly LEBBNOCHFAJ HGNFJGNANBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly HNIEJOCNLDA FLFOJBBEODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly KCJDDJGKLGO ALFICPBJKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LINFBCHDBFK GCDEFLEGNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, MMOAOFJNGCJ> INBDPKIDMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, KAPMKOEKCNP> ONPJNLMMDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, DAGLLEKPHGJ> LFOIAJODODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim DPKCBOAMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private MMOAOFJNGCJ JNPPNCKCNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int EAMGFJGAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<MMOAOFJNGCJ> EFGABAGHGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private MMOAOFJNGCJ[] FDOKBCKBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OBNGAHJIPEC NHNDNANGGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int CJHAEAGAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> AIHGOAAJMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte CNENIKNNDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object NPCKPKHAJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool CMECJOPHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool ANGIICGKABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int PNNCNFCEBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int LPAKNKBHPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int PGNBILCOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int IHNCEABCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool KNBECPHKGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool OLPNFPBMCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int IGFODJJNIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int BMNLGPGAIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int JDKFMEOJMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool KNDGAMGKDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool NCJMKDKAMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool HKMEACCJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool LOEDDGPCDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int FIDHJAFEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int LCODPIPIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CIHLFOOHENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly CKDIIEEEGHA ODFEAKAPHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PPNMGHKDHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly OHDILHOBLGA BGFOPCCJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FJGAEPGHMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public FHHKPDKJADB BDOIJCMHPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int ANPMHLIMFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool OHAHHJMCBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool NFKCFEHGCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool KCOBFGDFNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool EHIBKKPNMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HPCPBKBEEMB IDNMLLHHAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int COACEIMFDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object MKLBFODODBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HPCPBKBEEMB MPBOKEBLBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int FDKHPJNLHMF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int DDGMIJDNJCA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int JAAFNPCMIIO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private DAOEGEAAGNP HNCIIPLGPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private DAOEGEAAGNP GJHNAHBLMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread DBKFEFGPEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread DLGNHDKIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint CNFIBHEIJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint PKDIEOCMGKD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] IBBKKIIBPEG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] JELMKBKBLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<JCPFIEGALPM, IPEndPoint> LKNCLBGGGKL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress IMOAGEIOEFJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool NFIEPAOHPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int EOMEICINIFO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BNINIPMDHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1326110", Offset = "0x1325510", VA = "0x181326110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1CFBF30", Offset = "0x1CFB330", VA = "0x181CFBF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ACNDIFKEKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1420300", Offset = "0x141F700", VA = "0x181420300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1CFBF20", Offset = "0x1CFB320", VA = "0x181CFBF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte CGGDAFLJJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE584A0", Offset = "0xE578A0", VA = "0x180E584A0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MBEBFPFEDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6BB0", Offset = "0x6AE5FB0", VA = "0x186AE6BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GBNFCKNGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA700", Offset = "0x6AE9B00", VA = "0x186AEA700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AE61A0", Offset = "0x6AE55A0", VA = "0x186AE61A0")]
	public void AJAHPLEOKPE(IPEndPoint GLLKALOCBHK, byte[] MCBJECJLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AED630", Offset = "0x6AECA30", VA = "0x186AED630")]
	public void PJIJOIEAEED(IPEndPoint GLLKALOCBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6100", Offset = "0x6AE5500", VA = "0x186AE6100")]
	private bool AEBLBCBKCPJ(IPEndPoint GLLKALOCBHK, [Out] MMOAOFJNGCJ JANOAOHDNEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBC40", Offset = "0x6AEB040", VA = "0x186AEBC40")]
	private void OFHAACIDIAP(MMOAOFJNGCJ JANOAOHDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB890", Offset = "0x6AEAC90", VA = "0x186AEB890")]
	private void NMIEGODKOOG(MMOAOFJNGCJ JANOAOHDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB8F0", Offset = "0x6AEACF0", VA = "0x186AEB8F0")]
	private void OCJNNFJHNBE(MMOAOFJNGCJ JANOAOHDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AED960", Offset = "0x6AECD60", VA = "0x186AED960")]
	public NDPNMFCPABG(LEBBNOCHFAJ JDJFEKKOFGG, [Optional] OBNGAHJIPEC DANMCKCNAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6870", Offset = "0x6AE5C70", VA = "0x186AE6870")]
	internal void CIENLJMMNEB(MMOAOFJNGCJ ONFPCGJHIFP, int HOLPBOGNIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB190", Offset = "0x6AEA590", VA = "0x186AEB190")]
	internal void LGPLKEELINK(MMOAOFJNGCJ ONFPCGJHIFP, object CPLCNCAFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7D60", Offset = "0x6AE7160", VA = "0x186AE7D60")]
	internal void FJJLKEGCHEL(MMOAOFJNGCJ JANOAOHDNEG, MNFHADBGMLE CIAFGFLDDGN, SocketError GNEGBDMJOOJ, HPCPBKBEEMB JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA2A0", Offset = "0x6AE96A0", VA = "0x186AEA2A0")]
	private void JFKEICGPLKL(MMOAOFJNGCJ JANOAOHDNEG, MNFHADBGMLE CIAFGFLDDGN, SocketError GNEGBDMJOOJ, bool HEGINIGEJIB, byte[] AMHCLKHIFKH, int LLNIGMDIFON, int PPLOBPJCNII, HPCPBKBEEMB JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8730", Offset = "0x6AE7B30", VA = "0x186AE8730")]
	private void IHKALLIOBCL(DLIDPLMNNOK.PJNGLCMLNPG MAIGGPEPIHD, [Optional] MMOAOFJNGCJ JANOAOHDNEG, [Optional] IPEndPoint LDGPJCAKDIC, SocketError BGDJGAKNCHF = SocketError.Success, int HOLPBOGNIMA = 0, MNFHADBGMLE JBFOHFKJDBG = MNFHADBGMLE.ConnectionFailed, [Optional] KAPMKOEKCNP CAPDLIEMMKE, IDOGBCMDMEF KLNFAJPKLGN = IDOGBCMDMEF.Unreliable, byte EGPCMKGPGJG = 0, [Optional] HPCPBKBEEMB DNPIDNKOMMF, [Optional] object CPLCNCAFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7DA0", Offset = "0x6AE71A0", VA = "0x186AE7DA0")]
	private void GKONLHHJMCC(DLIDPLMNNOK LIJAPOOCIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAD60", Offset = "0x6AEA160", VA = "0x186AEAD60")]
	internal void LCDPLCFJNHB(DLIDPLMNNOK LIJAPOOCIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE57C0", VA = "0x186AE63C0")]
	private void CDECNJJLNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAE70", Offset = "0x6AEA270", VA = "0x186AEAE70")]
	private void LGJJOCEDBCL(int PPILNHBBBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6BD0", Offset = "0x6AE5FD0", VA = "0x186AE6BD0")]
	internal MMOAOFJNGCJ EDEOJFIKNKO(KAPMKOEKCNP INLHACAOAMD, byte[] BBBBMGPCCPB, int LLNIGMDIFON, int GHDAIPOHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBBC0", Offset = "0x6AEAFC0", VA = "0x186AEBBC0")]
	private int OFAHNMGHMHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AE71F0", Offset = "0x6AE65F0", VA = "0x186AE71F0")]
	private void EDKHDJIPALC(IPEndPoint LDGPJCAKDIC, MMOAOFJNGCJ NFCCAIKOIMD, LKGDHEABPEK BDEDDGKKKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8E70", Offset = "0x6AE8270", VA = "0x186AE8E70")]
	private void JDMOCKDNBED(HPCPBKBEEMB MBJFCAKDJJM, IPEndPoint LDGPJCAKDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7A80", Offset = "0x6AE6E80", VA = "0x186AE7A80")]
	internal void FENEFJGCHFO(HPCPBKBEEMB MBJFCAKDJJM, IDOGBCMDMEF OKKKMOEHFMD, byte EGPCMKGPGJG, int DJAHEDKDMHB, MMOAOFJNGCJ ONFPCGJHIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC7B0", Offset = "0x6AEBBB0", VA = "0x186AEC7B0")]
	public bool OJDEIJAKKMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AED060", Offset = "0x6AEC460", VA = "0x186AED060")]
	public bool OJDEIJAKKMA(IPAddress KGFFFHGDDJE, IPAddress BNAJJDCFAKB, int MDPDGBLOFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC820", Offset = "0x6AEBC20", VA = "0x186AEC820")]
	public bool OJDEIJAKKMA(int MDPDGBLOFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB6E0", Offset = "0x6AEAAE0", VA = "0x186AEB6E0")]
	public void NEFLOJHIDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA7C0", Offset = "0x6AE9BC0", VA = "0x186AEA7C0")]
	public MMOAOFJNGCJ KPJJENPAIAL(string ENIHAJKAFII, int MDPDGBLOFCH, string MCBJECJLDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAC80", Offset = "0x6AEA080", VA = "0x186AEAC80")]
	public MMOAOFJNGCJ KPJJENPAIAL(string ENIHAJKAFII, int MDPDGBLOFCH, IAKLECKPNKG AFIGLLNKJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA8A0", Offset = "0x6AE9CA0", VA = "0x186AEA8A0")]
	public MMOAOFJNGCJ KPJJENPAIAL(IPEndPoint JMBMDICGCNK, IAKLECKPNKG AFIGLLNKJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8E60", Offset = "0x6AE8260", VA = "0x186AE8E60")]
	public void IMMAKLHENCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8B10", Offset = "0x6AE7F10", VA = "0x186AE8B10")]
	public void IMMAKLHENCD(bool GLLAIKJCGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7770", Offset = "0x6AE6B70", VA = "0x186AE7770")]
	public void ENJCKNOCAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AE76A0", Offset = "0x6AE6AA0", VA = "0x186AE76A0")]
	public void ENJCKNOCAHN(byte[] AMHCLKHIFKH, int LLNIGMDIFON, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA260", Offset = "0x6AE9660", VA = "0x186AEA260")]
	public void JFKEICGPLKL(MMOAOFJNGCJ JANOAOHDNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA6C0", Offset = "0x6AE9AC0", VA = "0x186AEA6C0")]
	public void JFKEICGPLKL(MMOAOFJNGCJ JANOAOHDNEG, byte[] AMHCLKHIFKH, int LLNIGMDIFON, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6AED780", Offset = "0x6AECB80", VA = "0x186AED780", Slot = "4")]
	private IEnumerator<MMOAOFJNGCJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6AED810", Offset = "0x6AECC10", VA = "0x186AED810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AED230", Offset = "0x6AEC630", VA = "0x186AED230")]
	private HPCPBKBEEMB PDEIADCALEK(DMAFDAAPONM ODLMGDFMFJG, int EOKAMHLPIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AED310", Offset = "0x6AEC710", VA = "0x186AED310")]
	private HPCPBKBEEMB PDEIADCALEK(DMAFDAAPONM ODLMGDFMFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6AED3F0", Offset = "0x6AEC7F0", VA = "0x186AED3F0")]
	internal HPCPBKBEEMB PHAMIJAEFGJ(int EOKAMHLPIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7820", Offset = "0x6AE6C20", VA = "0x186AE7820")]
	internal void FCOEGEFJJAB(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6AED8A0", Offset = "0x6AECCA0", VA = "0x186AED8A0")]
	static NDPNMFCPABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1326110", Offset = "0x1325510", VA = "0x181326110")]
	private bool EEIEAOPBBGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB1E0", Offset = "0x6AEA5E0", VA = "0x186AEB1E0")]
	private void LPJJJGMIBDC(IPEndPoint HDOEMEFIDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6710", Offset = "0x6AE5B10", VA = "0x186AE6710")]
	private void CFLGPICHPFJ(IPEndPoint HDOEMEFIDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6AED080", Offset = "0x6AEC480", VA = "0x186AED080")]
	private bool PCFBBNMBIJC(SocketException GEEGJFAONEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6B90", Offset = "0x6AE5F90", VA = "0x186AE6B90")]
	private void CPJCHBKCMPA(PMNDJJNCCOO NBLDEEBAIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6AE68C0", Offset = "0x6AE5CC0", VA = "0x186AE68C0")]
	private void CJDDHFAACNC(DAOEGEAAGNP NBLDEEBAIHE, EndPoint CPPKBIHCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB360", Offset = "0x6AEA760", VA = "0x186AEB360")]
	private void MKKFOBHMAOI(object FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC8A0", Offset = "0x6AEBCA0", VA = "0x186AEC8A0")]
	public bool OJDEIJAKKMA(IPAddress KGFFFHGDDJE, IPAddress BNAJJDCFAKB, int MDPDGBLOFCH, bool BPNJPBBEKEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8560", Offset = "0x6AE7960", VA = "0x186AE8560")]
	internal int HGPDGCCFIDP(HPCPBKBEEMB MBJFCAKDJJM, IPEndPoint LDGPJCAKDIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBF90", Offset = "0x6AEB390", VA = "0x186AEBF90")]
	internal int OJBMHPDOIAN(HPCPBKBEEMB MBJFCAKDJJM, IPEndPoint LDGPJCAKDIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBFD0", Offset = "0x6AEB3D0", VA = "0x186AEBFD0")]
	internal int OJBMHPDOIAN(byte[] EIGJGBPHOMK, int LLNIGMDIFON, int GHDAIPOHNAO, IPEndPoint LDGPJCAKDIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE85C0", Offset = "0x6AE79C0", VA = "0x186AE85C0")]
	internal void HMEDOINECCO(bool JGKAMDLACJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum DMAFDAAPONM : byte
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
internal sealed class HPCPBKBEEMB
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int HKPIFOCILML;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] OMLBNDOLJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] KFIPBHDJANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int FONFMMJKOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object BBMFKBNLACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public HPCPBKBEEMB FOBEBPIMKCK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DMAFDAAPONM PNDGDLAEPID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC80", Offset = "0x6ADA080", VA = "0x186ADAC80")]
		get
		{
			return default(DMAFDAAPONM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAAD0", Offset = "0x6AD9ED0", VA = "0x186ADAAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte LANBDILAFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAD40", Offset = "0x6ADA140", VA = "0x186ADAD40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC10", Offset = "0x6ADA010", VA = "0x186ADAC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GGFOGMJPOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAA70", Offset = "0x6AD9E70", VA = "0x186ADAA70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA8D0", Offset = "0x6AD9CD0", VA = "0x186ADA8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AGLFDJGPOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ADACB0", Offset = "0x6ADA0B0", VA = "0x186ADACB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HDIKNGCOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAD10", Offset = "0x6ADA110", VA = "0x186ADAD10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC50", Offset = "0x6ADA050", VA = "0x186ADAC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CMCOMBIKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ADABB0", Offset = "0x6AD9FB0", VA = "0x186ADABB0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA850", Offset = "0x6AD9C50", VA = "0x186ADA850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JOMPHDFIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAB10", Offset = "0x6AD9F10", VA = "0x186ADAB10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA890", Offset = "0x6AD9C90", VA = "0x186ADA890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JGAJINPHLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAA10", Offset = "0x6AD9E10", VA = "0x186ADAA10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAB70", Offset = "0x6AD9F70", VA = "0x186ADAB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAD70", Offset = "0x6ADA170", VA = "0x186ADAD70")]
	static HPCPBKBEEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6ADACE0", Offset = "0x6ADA0E0", VA = "0x186ADACE0")]
	public void PKBECAPHAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB140", Offset = "0x6ADA540", VA = "0x186ADB140")]
	public HPCPBKBEEMB(int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB030", Offset = "0x6ADA430", VA = "0x186ADB030")]
	public HPCPBKBEEMB(DMAFDAAPONM ODLMGDFMFJG, int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA7E0", Offset = "0x6AD9BE0", VA = "0x186ADA7E0")]
	public static int AAEKFAPFBOC(DMAFDAAPONM ODLMGDFMFJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA750", Offset = "0x6AD9B50", VA = "0x186ADA750")]
	public int AAEKFAPFBOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA910", Offset = "0x6AD9D10", VA = "0x186ADA910")]
	public bool FPPEDICBAND()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum EIBOLMBFOBE : byte
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
internal enum OCOGADBFLBD
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
internal enum ECBLLLFMNDC
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum DGLCMKNCAME
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MMOAOFJNGCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class DFKIGLOMAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HPCPBKBEEMB[] KFCAMGLBCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int IAAJCOIKKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int DPHINNJAFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte HDIKNGCOKJI;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DFKIGLOMAML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void OMFJKLOFBIB(ulong IPEGPMCNHHG, int GECNJHHKAMB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int OKPEKLECCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int FEMEHKHKEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int FPDOKOCGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double GDNLMGEKDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int GLIAHHOKMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int HOMEBBCDCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int INPCNJNMCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch MCBAGNFNNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int BJFMIBIAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long ALIFHBKGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object HJAENPMFNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal MMOAOFJNGCJ EDJBJHABKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal MMOAOFJNGCJ EJKIJMOGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<HPCPBKBEEMB> OFBIAFHEMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<LEEKIOOPFMN> OKNIONKDAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly LEEKIOOPFMN[] HHLLDLMPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int LOGMEKPDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int MGHBJMDNLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool PLMMJJDGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int GLANHHIDMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MMNKIJGKLGI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int FDGLICDNDGL = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int BFDDEGOBFPC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object KGKLEEEAHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int NCHNFAKBPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, DFKIGLOMAML> CEGJMBNHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> NPKEHKOKHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly HPCPBKBEEMB FAFECAALBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int BCEHDNPOLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int OKFNPAOJNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint HACAGMBDFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int CMAMBNEAGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int FGAOFKCIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long GAAAEAILGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte FIOJLPPPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private EIBOLMBFOBE IGBJLJGAANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private HPCPBKBEEMB MEIFMJLJOHL;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int HJJKPBEBACP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int EHALJCJDJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly HPCPBKBEEMB JMCMAMBBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly HPCPBKBEEMB LHKPLBDLKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly HPCPBKBEEMB GNGPPPAHELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly HPCPBKBEEMB CFNKEEILMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private MFKBKGIBDBH BCOLICFCGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly NDPNMFCPABG EBNCMHGMKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int PEOBHBKAJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object FEDICNOJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly CKDIIEEEGHA ODFEAKAPHDJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte JPDLHLKCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAE4F90", Offset = "0xAE4390", VA = "0x180AE4F90")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1CE0", Offset = "0x6AE10E0", VA = "0x186AE1CE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint PAIMIEEFDID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC16AE0", Offset = "0xC15EE0", VA = "0x180C16AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EIBOLMBFOBE DPPFFBPPFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAE4FB0", Offset = "0xAE43B0", VA = "0x180AE4FB0")]
		get
		{
			return default(EIBOLMBFOBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long ONGFHKEOIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x999C40", Offset = "0x999040", VA = "0x180999C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int APOIENPHIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x14202D0", Offset = "0x141F6D0", VA = "0x1814202D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1CFBD10", Offset = "0x1CFB110", VA = "0x181CFBD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BIABHGLHAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE44A0", Offset = "0x6AE38A0", VA = "0x186AE44A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ONNJOEPMLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A1080", Offset = "0x9A0480", VA = "0x1809A1080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double HGFEAJJKEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x52D01C0", Offset = "0x52CF5C0", VA = "0x1852D01C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OMFJKLOFBIB ACDFNDHMHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE34E0", Offset = "0x6AE28E0", VA = "0x186AE34E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2A90", Offset = "0x6AE1E90", VA = "0x186AE2A90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE55C0", Offset = "0x6AE49C0", VA = "0x186AE55C0")]
	internal MMOAOFJNGCJ(NDPNMFCPABG ADMANJOJOJB, IPEndPoint LDGPJCAKDIC, int IIKCEJDFBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3700", Offset = "0x6AE2B00", VA = "0x186AE3700")]
	internal void MKHEGNBHCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3ED0", Offset = "0x6AE32D0", VA = "0x186AE3ED0")]
	internal void NHDOMCNPHNO(IPEndPoint DGLCIKONIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3E40", Offset = "0x6AE3240", VA = "0x186AE3E40")]
	internal void NGJEIOBAIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2120", Offset = "0x6AE1520", VA = "0x186AE2120")]
	private void BHEPMEIJLEL(int KECBBJFGEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3F00", Offset = "0x6AE3300", VA = "0x186AE3F00")]
	private void NMCMCHKJCGO(int AFCDNIAPPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4A10", Offset = "0x6AE3E10", VA = "0x186AE4A10")]
	private LEEKIOOPFMN PJFHBOCOMND(byte MGJOIMHBHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5A10", Offset = "0x6AE4E10", VA = "0x186AE5A10")]
	internal MMOAOFJNGCJ(NDPNMFCPABG ADMANJOJOJB, IPEndPoint LDGPJCAKDIC, int IIKCEJDFBDH, byte IAKFPNFBCEB, IAKLECKPNKG CCPCCLOHBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5BA0", Offset = "0x6AE4FA0", VA = "0x186AE5BA0")]
	internal MMOAOFJNGCJ(NDPNMFCPABG ADMANJOJOJB, KAPMKOEKCNP INLHACAOAMD, int IIKCEJDFBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AE21F0", Offset = "0x6AE15F0", VA = "0x186AE21F0")]
	internal void CICAMDOGOIB(LKGDHEABPEK OLDEIGHOMEP, byte[] AMHCLKHIFKH, int LLNIGMDIFON, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2A10", Offset = "0x6AE1E10", VA = "0x186AE2A10")]
	internal bool HIPMDAPEOPA(OHNNFNLDJPF MBJFCAKDJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4BC0", Offset = "0x6AE3FC0", VA = "0x186AE4BC0")]
	public void PKEBBBGBIGG(byte[] AMHCLKHIFKH, int LLNIGMDIFON, int GHDAIPOHNAO, IDOGBCMDMEF PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3F40", Offset = "0x6AE3340", VA = "0x186AE3F40")]
	private void NPALLCFHFPN(byte[] AMHCLKHIFKH, int LLNIGMDIFON, int GHDAIPOHNAO, byte EGPCMKGPGJG, IDOGBCMDMEF KLNFAJPKLGN, object CPLCNCAFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE36B0", Offset = "0x6AE2AB0", VA = "0x186AE36B0")]
	public void MCDOIJBEAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AE35D0", Offset = "0x6AE29D0", VA = "0x186AE35D0")]
	internal ECBLLLFMNDC JPFBAMNCFMA(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return default(ECBLLLFMNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3DE0", Offset = "0x6AE31E0", VA = "0x186AE3DE0")]
	internal void NCBIJJAKGBG(LEEKIOOPFMN JLNFNGNFJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4BF0", Offset = "0x6AE3FF0", VA = "0x186AE4BF0")]
	internal DGLCMKNCAME PNPDLKKOPHE(byte[] AMHCLKHIFKH, int LLNIGMDIFON, int GHDAIPOHNAO, bool HEGINIGEJIB)
	{
		return default(DGLCMKNCAME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3590", Offset = "0x6AE2990", VA = "0x186AE3590")]
	private void JKNBFELLLLJ(int JPAMIPLCHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2B40", Offset = "0x6AE1F40", VA = "0x186AE2B40")]
	internal void IPBJEGJMGPD(IDOGBCMDMEF OKKKMOEHFMD, HPCPBKBEEMB GGAJNINGNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AE44B0", Offset = "0x6AE38B0", VA = "0x186AE44B0")]
	private void PGPIMLPNOIN(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1D90", Offset = "0x6AE1190", VA = "0x186AE1D90")]
	private void BDIKBECICLA(int NFEBFCGCNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2240", Offset = "0x6AE1640", VA = "0x186AE2240")]
	internal OCOGADBFLBD EDKHDJIPALC(LKGDHEABPEK BDEDDGKKKOH)
	{
		return default(OCOGADBFLBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4F00", Offset = "0x6AE4300", VA = "0x186AE4F00")]
	internal void POBHDIICJOL(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AE28C0", Offset = "0x6AE1CC0", VA = "0x186AE28C0")]
	private void HGEFJHOJLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6AE26C0", Offset = "0x6AE1AC0", VA = "0x186AE26C0")]
	internal void GKEOEKCFCKM(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3720", Offset = "0x6AE2B20", VA = "0x186AE3720")]
	internal void NABACIPFMBC(int NFEBFCGCNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2400", Offset = "0x6AE1800", VA = "0x186AE2400")]
	internal void GGJNDCMKLNC(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CKDIIEEEGHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long FNDCNPKPIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long ABMMJPEKCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long JJCANPDOJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long JFJIAHGAAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long ACMBLEGEOPA;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long NLKOOEGDPCK;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long OFNIOLFEHEL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long PLGKNINFBAA;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long JFPPDOKNEEE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long IPHEFJLMIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long KPDADEFHBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long AKDHMMAACKK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long EDEBEAJKPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD89B0", Offset = "0x6AD7DB0", VA = "0x186AD89B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KAPDFLPJIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8A70", Offset = "0x6AD7E70", VA = "0x186AD8A70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long KJIBGOAFKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8AE0", Offset = "0x6AD7EE0", VA = "0x186AD8AE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DMBGPHEDEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C20", Offset = "0x6AD8020", VA = "0x186AD8C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long GMBMGDKGGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8B50", Offset = "0x6AD7F50", VA = "0x186AD8B50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long GIGAGJHJLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8CD0", Offset = "0x6AD80D0", VA = "0x186AD8CD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long FFLBEBBPGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8870", Offset = "0x6AD7C70", VA = "0x186AD8870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long OFPANGHKEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C90", Offset = "0x6AD8090", VA = "0x186AD8C90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MFKBKGIBDBH CHOFDHJJANC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8A60", Offset = "0x6AD7E60", VA = "0x186AD8A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double BBANDCCJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6AD89C0", Offset = "0x6AD7DC0", VA = "0x186AD89C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8A20", Offset = "0x6AD7E20", VA = "0x186AD8A20")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8AF0", Offset = "0x6AD7EF0", VA = "0x186AD8AF0")]
	public void GMDNMCIFCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8B60", Offset = "0x6AD7F60", VA = "0x186AD8B60")]
	public void IIPICLCFPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8C30", Offset = "0x6AD8030", VA = "0x186AD8C30")]
	public void LMOFGGLOCAC(long EMELAFCCLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD88B0", Offset = "0x6AD7CB0", VA = "0x186AD88B0")]
	public void AMOLKFDDLCL(long KBHCKDNMMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8A80", Offset = "0x6AD7E80", VA = "0x186AD8A80")]
	public void FHINFGGAEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8BB0", Offset = "0x6AD7FB0", VA = "0x186AD8BB0")]
	public void KCFKHDDIFKP(long LLGPHPGBBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8CE0", Offset = "0x6AD80E0", VA = "0x186AD8CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8910", Offset = "0x6AD7D10", VA = "0x186AD8910")]
	public void BAKHKPGJOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CKDIIEEEGHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HGPIKJAMFNI
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> FICMIFCDDNC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA1E0", Offset = "0x6AD95E0", VA = "0x186ADA1E0")]
	public static IPEndPoint CJDINNAIIPD(string EHICLABMPMJ, int MDPDGBLOFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA460", Offset = "0x6AD9860", VA = "0x186ADA460")]
	public static IPAddress LJGPOOKPGMI(string EHICLABMPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA630", Offset = "0x6AD9A30", VA = "0x186ADA630")]
	public static IPAddress LJGPOOKPGMI(string EHICLABMPMJ, AddressFamily GIIOMKKIHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA430", Offset = "0x6AD9830", VA = "0x186ADA430")]
	internal static int HJCMHJADCEC(int BJEOONBEPPM, int EEBGFPOICDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x35D6420", Offset = "0x35D5820", VA = "0x1835D6420")]
	internal static T[] FMFABJCAGID<T>(int PPLOBPJCNII) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JKDMANNCDIJ : LEEKIOOPFMN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct IMFIOFGEGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private HPCPBKBEEMB FJPOPHEEMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long FDODOMDMBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool LCOADANCKJG;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC0D0", Offset = "0x6ADB4D0", VA = "0x186ADC0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBFF0", Offset = "0x6ADB3F0", VA = "0x186ADBFF0")]
		public void AEJOPFDILPE(HPCPBKBEEMB MBJFCAKDJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC060", Offset = "0x6ADB460", VA = "0x186ADC060")]
		public bool HHIBKEHLJDE(long GCGCDOCGAJH, MMOAOFJNGCJ JANOAOHDNEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC010", Offset = "0x6ADB410", VA = "0x186ADC010")]
		public bool GAPBPDEBKKO(MMOAOFJNGCJ JANOAOHDNEG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly HPCPBKBEEMB JMKHABOKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly IMFIOFGEGFO[] MHCMBMDPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly HPCPBKBEEMB[] OHAIFBAHAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] KAJLDBPKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int IFCDPNNDDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int HLNEGBJMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NFAADMNKKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HFCPDIFIPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool CAHDFIKJHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly IDOGBCMDMEF NCKFDKKPMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool GEKHMNEKIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int DPOFMNDPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte NCHBEAEOGMA;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE820", Offset = "0x6ADDC20", VA = "0x186ADE820")]
	public JKDMANNCDIJ(MMOAOFJNGCJ JANOAOHDNEG, bool BGCIOOHPJLK, byte IIKCEJDFBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD930", Offset = "0x6ADCD30", VA = "0x186ADD930")]
	private void INHKFHAPBKG(HPCPBKBEEMB MBJFCAKDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDCF0", Offset = "0x6ADD0F0", VA = "0x186ADDCF0", Slot = "4")]
	protected override bool MLFKPBMAHLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE1C0", Offset = "0x6ADD5C0", VA = "0x186ADE1C0", Slot = "5")]
	public override bool POBHDIICJOL(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class ANKPILPNLOK : LEEKIOOPFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int BFLEFLBAALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort HLNEGBJMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool HADBDEELFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private HPCPBKBEEMB BLBDBABNGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly HPCPBKBEEMB LNAIEMPCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool LLBLLNPFGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte NCHBEAEOGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long KLJLAMALGBN;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8740", Offset = "0x6AD7B40", VA = "0x186AD8740")]
	public ANKPILPNLOK(MMOAOFJNGCJ JANOAOHDNEG, bool AGKHIBNEPMG, byte IIKCEJDFBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7FA0", Offset = "0x6AD73A0", VA = "0x186AD7FA0", Slot = "4")]
	protected override bool MLFKPBMAHLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8460", Offset = "0x6AD7860", VA = "0x186AD8460", Slot = "5")]
	public override bool POBHDIICJOL(HPCPBKBEEMB MBJFCAKDJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OOIFAIJHJPE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct HMJANKKIJHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong FFMPLDGFBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double OGBICGHGMBO;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct LNEILFONLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int ECJFJDFJMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float FENJFOHKGCK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7EA0", Offset = "0x6AD72A0", VA = "0x186AD7EA0")]
	private static void BHKOCHKBODL(byte[] GODPNOEEIEP, int NPELPNMIGOA, ulong AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEDB0", Offset = "0x6AEE1B0", VA = "0x186AEEDB0")]
	private static void BHKOCHKBODL(byte[] GODPNOEEIEP, int NPELPNMIGOA, int AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEE20", Offset = "0x6AEE220", VA = "0x186AEEE20")]
	public static void BHKOCHKBODL(byte[] GODPNOEEIEP, int NPELPNMIGOA, short AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEEF0", Offset = "0x6AEE2F0", VA = "0x186AEEEF0")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, double FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEE60", Offset = "0x6AEE260", VA = "0x186AEEE60")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEE20", Offset = "0x6AEE220", VA = "0x186AEEE20")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, short FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEE20", Offset = "0x6AEE220", VA = "0x186AEEE20")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, ushort FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEDB0", Offset = "0x6AEE1B0", VA = "0x186AEEDB0")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEDB0", Offset = "0x6AEE1B0", VA = "0x186AEEDB0")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, uint FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEEE0", Offset = "0x6AEE2E0", VA = "0x186AEEEE0")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, long FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEEE0", Offset = "0x6AEE2E0", VA = "0x186AEEEE0")]
	public static void LDEHGLFKELA(byte[] FIKLNMFCLIL, int FOGJBEMBBDP, ulong FIIKLGCIAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KKNPENMGICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] PFLAJOJDOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int BGLGGIDKBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int KILMCJJIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int MDNMLPGOADH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] KFIPBHDJANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JOJPLELMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HAOIHICNCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEE80", Offset = "0x6ADE280", VA = "0x186ADEE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AOAPBCNHFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x254C8E0", Offset = "0x254BCE0", VA = "0x18254C8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int JICLHPEJCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEB50", Offset = "0x6ADDF50", VA = "0x186ADEB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6ADECA0", Offset = "0x6ADE0A0", VA = "0x186ADECA0")]
	public void CLECNLFEHOL(byte[] PBOFAFGAOJF, int NPELPNMIGOA, int JNJPCIMBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public KKNPENMGICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF750", Offset = "0x6ADEB50", VA = "0x186ADF750")]
	public KKNPENMGICP(byte[] PBOFAFGAOJF, int NPELPNMIGOA, int JNJPCIMBAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF680", Offset = "0x6ADEA80", VA = "0x186ADF680")]
	public IPEndPoint PMNEAMAEHKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE40", Offset = "0x6ADE240", VA = "0x186ADEE40")]
	public byte JIENJBLGDDF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE40", Offset = "0x6ADE240", VA = "0x186ADEE40")]
	public sbyte EFIEBDLPHOE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x36B4640", Offset = "0x36B3A40", VA = "0x1836B4640")]
	public T[] KMDJECDINOI<T>(ushort EOKAMHLPIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE00", Offset = "0x6ADE200", VA = "0x186ADEE00")]
	public bool[] EADFFMMBEBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEC60", Offset = "0x6ADE060", VA = "0x186ADEC60")]
	public ushort[] BKPBGCPOIJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEC20", Offset = "0x6ADE020", VA = "0x186ADEC20")]
	public short[] BDKJONHIMGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEBE0", Offset = "0x6ADDFE0", VA = "0x186ADEBE0")]
	public int[] BADGGOMKOLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEBA0", Offset = "0x6ADDFA0", VA = "0x186ADEBA0")]
	public uint[] AOHHCILFCFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF210", Offset = "0x6ADE610", VA = "0x186ADF210")]
	public float[] IAEPFMDFPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEDC0", Offset = "0x6ADE1C0", VA = "0x186ADEDC0")]
	public double[] DLEJFNPPOKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEED0", Offset = "0x6ADE2D0", VA = "0x186ADEED0")]
	public long[] EJMDPOJGMEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEB60", Offset = "0x6ADDF60", VA = "0x186ADEB60")]
	public ulong[] AFKGOMGMBPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF3E0", Offset = "0x6ADE7E0", VA = "0x186ADF3E0")]
	public string[] MDFBLPABPAD(int GLAMLDOEBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF1D0", Offset = "0x6ADE5D0", VA = "0x186ADF1D0")]
	public bool HOGOKEDBAIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF250", Offset = "0x6ADE650", VA = "0x186ADF250")]
	public char MOBGCDFGACP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF250", Offset = "0x6ADE650", VA = "0x186ADF250")]
	public ushort ICEJJMKIEDI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF300", Offset = "0x6ADE700", VA = "0x186ADF300")]
	public short JGEFIGEOPHH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF610", Offset = "0x6ADEA10", VA = "0x186ADF610")]
	public long PHEMMPKPPBO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADED50", Offset = "0x6ADE150", VA = "0x186ADED50")]
	public ulong DKHFMEMPENE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF370", Offset = "0x6ADE770", VA = "0x186ADF370")]
	public int LIFNJMKDHCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6ADECE0", Offset = "0x6ADE0E0", VA = "0x186ADECE0")]
	public uint DAAKLBEDBAL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF530", Offset = "0x6ADE930", VA = "0x186ADF530")]
	public float MDHOLLOOGGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF160", Offset = "0x6ADE560", VA = "0x186ADF160")]
	public double HIEGDJAPJDD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEF30", Offset = "0x6ADE330", VA = "0x186ADEF30")]
	public string GDHEONACOIK(int CGKHNEOJKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF5A0", Offset = "0x6ADE9A0", VA = "0x186ADF5A0")]
	public ArraySegment<byte> NMAGNIDIKGK(int PPLOBPJCNII)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE90", Offset = "0x6ADE290", VA = "0x186ADEE90")]
	public sbyte[] EHLBDEGPHCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF2C0", Offset = "0x6ADE6C0", VA = "0x186ADF2C0")]
	public byte[] IOBCHGAMDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEF10", Offset = "0x6ADE310", VA = "0x186ADEF10")]
	public void GAPBPDEBKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IAKLECKPNKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] PFLAJOJDOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int BGLGGIDKBIC;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int FMGDNFKGJKG = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool GHGDBCGPLHE;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding MCJNCDNNMDE;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int HNFHKLNPHGG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] NIBILBGLKAP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] CBNHMBHNHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBED0", Offset = "0x6ADB2D0", VA = "0x186ADBED0")]
	public IAKLECKPNKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBF50", Offset = "0x6ADB350", VA = "0x186ADBF50")]
	public IAKLECKPNKG(bool NKCFKKIBJKE, int LGIKBLBADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB8F0", Offset = "0x6ADACF0", VA = "0x186ADB8F0")]
	public static IAKLECKPNKG JOAIHPOADKE(string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB960", Offset = "0x6ADAD60", VA = "0x186ADB960")]
	public void KKGPAJIEEPC(int DOGNDPLMNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x25C5740", Offset = "0x25C4B40", VA = "0x1825C5740")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB640", Offset = "0x6ADAA40", VA = "0x186ADB640")]
	public void FFODAHJMFDE(float FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB5F0", Offset = "0x6ADA9F0", VA = "0x186ADB5F0")]
	public void FFODAHJMFDE(double FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB4D0", Offset = "0x6ADA8D0", VA = "0x186ADB4D0")]
	public void FFODAHJMFDE(long FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB4D0", Offset = "0x6ADA8D0", VA = "0x186ADB4D0")]
	public void FFODAHJMFDE(ulong FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB290", Offset = "0x6ADA690", VA = "0x186ADB290")]
	public void FFODAHJMFDE(int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB290", Offset = "0x6ADA690", VA = "0x186ADB290")]
	public void FFODAHJMFDE(uint FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB320", Offset = "0x6ADA720", VA = "0x186ADB320")]
	public void FFODAHJMFDE(char FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB320", Offset = "0x6ADA720", VA = "0x186ADB320")]
	public void FFODAHJMFDE(ushort FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB320", Offset = "0x6ADA720", VA = "0x186ADB320")]
	public void FFODAHJMFDE(short FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB390", Offset = "0x6ADA790", VA = "0x186ADB390")]
	public void FFODAHJMFDE(sbyte FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB390", Offset = "0x6ADA790", VA = "0x186ADB390")]
	public void FFODAHJMFDE(byte FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB450", Offset = "0x6ADA850", VA = "0x186ADB450")]
	public void FFODAHJMFDE(byte[] AMHCLKHIFKH, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB1B0", Offset = "0x6ADA5B0", VA = "0x186ADB1B0")]
	public void KCKGPKLHDIN(sbyte[] AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB1B0", Offset = "0x6ADA5B0", VA = "0x186ADB1B0")]
	public void ANJPGIEMKNA(byte[] AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB3F0", Offset = "0x6ADA7F0", VA = "0x186ADB3F0")]
	public void FFODAHJMFDE(bool FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBD70", Offset = "0x6ADB170", VA = "0x186ADBD70")]
	public void MJDOHAOGLMB(Array IJCGJAGFPED, int ELGJNJODDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBA00", Offset = "0x6ADAE00", VA = "0x186ADBA00")]
	public void MJDOHAOGLMB(float[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBC90", Offset = "0x6ADB090", VA = "0x186ADBC90")]
	public void MJDOHAOGLMB(double[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBC90", Offset = "0x6ADB090", VA = "0x186ADBC90")]
	public void MJDOHAOGLMB(long[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBC90", Offset = "0x6ADB090", VA = "0x186ADBC90")]
	public void MJDOHAOGLMB(ulong[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBA00", Offset = "0x6ADAE00", VA = "0x186ADBA00")]
	public void MJDOHAOGLMB(int[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBA00", Offset = "0x6ADAE00", VA = "0x186ADBA00")]
	public void MJDOHAOGLMB(uint[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBAE0", Offset = "0x6ADAEE0", VA = "0x186ADBAE0")]
	public void MJDOHAOGLMB(ushort[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBAE0", Offset = "0x6ADAEE0", VA = "0x186ADBAE0")]
	public void MJDOHAOGLMB(short[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB1B0", Offset = "0x6ADA5B0", VA = "0x186ADB1B0")]
	public void MJDOHAOGLMB(bool[] FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBBC0", Offset = "0x6ADAFC0", VA = "0x186ADBBC0")]
	public void MJDOHAOGLMB(string[] FIIKLGCIAGG, int HLIFJACJEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB520", Offset = "0x6ADA920", VA = "0x186ADB520")]
	public void FFODAHJMFDE(IPEndPoint GLLKALOCBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB4C0", Offset = "0x6ADA8C0", VA = "0x186ADB4C0")]
	public void FFODAHJMFDE(string FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB6E0", Offset = "0x6ADAAE0", VA = "0x186ADB6E0")]
	public void FFODAHJMFDE(string FIIKLGCIAGG, int CGKHNEOJKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MPPLDFABDPK
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MNGAMJIJELA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong PEOBHBKAJCM;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3C30", Offset = "0x4FA3030", VA = "0x184FA3C30")]
		static MNGAMJIJELA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void GMODAGHMLPA(KKNPENMGICP KILJCGGJECG, object CPLCNCAFBDG);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ENMOHGBLEIK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public MPPLDFABDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ENMOHGBLEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x42A02E0", Offset = "0x429F6E0", VA = "0x1842A02E0")]
		internal void MBCIHCIMLBP(KKNPENMGICP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BODMFEMPNIO<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public MPPLDFABDPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BODMFEMPNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5D74610", Offset = "0x5D73A10", VA = "0x185D74610")]
		internal void MBCIHCIMLBP(KKNPENMGICP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly FFJBKNLKNJL EMCGLMLNHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, GMODAGHMLPA> BDPLJGPLKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly IAKLECKPNKG FHIGMNJGLAJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5F80", Offset = "0x6AE5380", VA = "0x186AE5F80")]
	public MPPLDFABDPK(int GLAMLDOEBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x335E090", Offset = "0x335D490", VA = "0x18335E090", Slot = "4")]
	protected virtual ulong DCEPNABFPEP<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5E50", Offset = "0x6AE5250", VA = "0x186AE5E50", Slot = "5")]
	protected virtual GMODAGHMLPA LAIEALOHIFB(KKNPENMGICP KILJCGGJECG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3706070", Offset = "0x3705470", VA = "0x183706070", Slot = "6")]
	protected virtual void AGCNMJBPMFA<T>(IAKLECKPNKG NACIMEJMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5D80", Offset = "0x6AE5180", VA = "0x186AE5D80")]
	public void AJKPJDMKPDC(KKNPENMGICP KILJCGGJECG, object CPLCNCAFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x37060E0", Offset = "0x37054E0", VA = "0x1837060E0")]
	public void AHGLPFENCIH<T>(IAKLECKPNKG NACIMEJMHHK, T MBJFCAKDJJM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5E00", Offset = "0x6AE5200", VA = "0x186AE5E00")]
	public void CKMIJICOFCE(KKNPENMGICP KILJCGGJECG, object CPLCNCAFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3706350", Offset = "0x3705750", VA = "0x183706350")]
	public void DAMLHFKAPNO<T>(Action<T> HEFPCAFLFKD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3706190", Offset = "0x3705590", VA = "0x183706190")]
	public void DAMLHFKAPNO<T, TUserData>(Action<T, TUserData> HEFPCAFLFKD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AMDKGMCBAMC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7F90", Offset = "0x6AD7390", VA = "0x186AD7F90")]
	public AMDKGMCBAMC(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FAPKKOKBPPH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9F70", Offset = "0x6AD9370", VA = "0x186AD9F70")]
	public FAPKKOKBPPH(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class FFJBKNLKNJL
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum HHGKGEPMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class DLMNJILGMKO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HHGKGEPMJEA PONMJFHCNDE;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x65F6A60", Offset = "0x65F5E60", VA = "0x1865F6A60", Slot = "4")]
		public virtual void AEJOPFDILPE(MethodInfo KCJAIMOILBA, MethodInfo IBBPNEHKAFJ, HHGKGEPMJEA MAIGGPEPIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JKDIHHFLDNO(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LNGCPPOJIMA(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		protected DLMNJILGMKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class OECPPGFIOBI<TClass, TProperty> : DLMNJILGMKO<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> COHLIBJLMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> NGIGOFDMCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> ACJIALCEKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> IBNCMAPBMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> OIGLCBIHIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> NEAGDPKKEBB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x514DF50", Offset = "0x514D350", VA = "0x18514DF50", Slot = "7")]
		public override void AGIIAKMNLGM(TClass AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x514FB20", Offset = "0x514EF20", VA = "0x18514FB20", Slot = "8")]
		public override void NNNAJDDCJAC(TClass AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x514EAE0", Offset = "0x514DEE0", VA = "0x18514EAE0", Slot = "9")]
		public override void JKDIHHFLDNO(TClass AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x514F260", Offset = "0x514E660", VA = "0x18514F260", Slot = "10")]
		public override void LNGCPPOJIMA(TClass AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x514E570", Offset = "0x514D970", VA = "0x18514E570")]
		protected TProperty[] BKDDFCBPMAI(TClass AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x514EE60", Offset = "0x514E260", VA = "0x18514EE60")]
		protected TProperty[] LBAIMFAPINN(TClass AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x514D7F0", Offset = "0x514CBF0", VA = "0x18514D7F0", Slot = "4")]
		public override void AEJOPFDILPE(MethodInfo KCJAIMOILBA, MethodInfo IBBPNEHKAFJ, HHGKGEPMJEA MAIGGPEPIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4F59CE0", Offset = "0x4F590E0", VA = "0x184F59CE0")]
		protected OECPPGFIOBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BIGMGHHHNBL<TClass, TProperty> : OECPPGFIOBI<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ODPKKLBMBJL(KKNPENMGICP NAEIDONDAPA, [Out] TProperty JNEDANLGGBL);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GFGGAEJHOJN(IAKLECKPNKG FIMFKJDMEKB, TProperty JNEDANLGGBL);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5D611E0", Offset = "0x5D605E0", VA = "0x185D611E0", Slot = "5")]
		public override void AHKKEODFCBM(TClass AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5D610C0", Offset = "0x5D604C0", VA = "0x185D610C0", Slot = "6")]
		public override void AHGLPFENCIH(TClass AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5D60F80", Offset = "0x5D60380", VA = "0x185D60F80", Slot = "7")]
		public override void AGIIAKMNLGM(TClass AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5D61280", Offset = "0x5D60680", VA = "0x185D61280", Slot = "8")]
		public override void NNNAJDDCJAC(TClass AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x482D370", Offset = "0x482C770", VA = "0x18482D370")]
		protected BIGMGHHHNBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class GBADCIILPIP<T> : OECPPGFIOBI<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x47E4F40", Offset = "0x47E4340", VA = "0x1847E4F40", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x47E4ED0", Offset = "0x47E42D0", VA = "0x1847E4ED0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x47E4E50", Offset = "0x47E4250", VA = "0x1847E4E50", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x47E4FC0", Offset = "0x47E43C0", VA = "0x1847E4FC0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public GBADCIILPIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class DACJIACFIKO<T> : OECPPGFIOBI<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65A0E90", Offset = "0x65A0290", VA = "0x1865A0E90", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x47E4ED0", Offset = "0x47E42D0", VA = "0x1847E4ED0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x65A0E10", Offset = "0x65A0210", VA = "0x1865A0E10", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x47E4FC0", Offset = "0x47E43C0", VA = "0x1847E4FC0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public DACJIACFIKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FDIPPFNLMPC<T> : OECPPGFIOBI<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x46C1D80", Offset = "0x46C1180", VA = "0x1846C1D80", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x46C1D10", Offset = "0x46C1110", VA = "0x1846C1D10", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x46C1C90", Offset = "0x46C1090", VA = "0x1846C1C90", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E00", Offset = "0x46C1200", VA = "0x1846C1E00", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public FDIPPFNLMPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OJMNINNDFJC<T> : OECPPGFIOBI<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x51D4DE0", Offset = "0x51D41E0", VA = "0x1851D4DE0", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x46C1D10", Offset = "0x46C1110", VA = "0x1846C1D10", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x51D4D60", Offset = "0x51D4160", VA = "0x1851D4D60", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E00", Offset = "0x46C1200", VA = "0x1846C1E00", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public OJMNINNDFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OCHBEJDGHLK<T> : OECPPGFIOBI<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x513FFF0", Offset = "0x513F3F0", VA = "0x18513FFF0", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x46E5AC0", Offset = "0x46E4EC0", VA = "0x1846E5AC0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x513FF70", Offset = "0x513F370", VA = "0x18513FF70", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x46E5BB0", Offset = "0x46E4FB0", VA = "0x1846E5BB0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public OCHBEJDGHLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FIINEJFNOAL<T> : OECPPGFIOBI<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x46E5B30", Offset = "0x46E4F30", VA = "0x1846E5B30", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x46E5AC0", Offset = "0x46E4EC0", VA = "0x1846E5AC0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x46E5A40", Offset = "0x46E4E40", VA = "0x1846E5A40", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x46E5BB0", Offset = "0x46E4FB0", VA = "0x1846E5BB0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public FIINEJFNOAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class LALIINJDIAF<T> : OECPPGFIOBI<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DEB0", Offset = "0x4D6D2B0", VA = "0x184D6DEB0", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DE40", Offset = "0x4D6D240", VA = "0x184D6DE40", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DDC0", Offset = "0x4D6D1C0", VA = "0x184D6DDC0", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x48939C0", Offset = "0x4892DC0", VA = "0x1848939C0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public LALIINJDIAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class NKJBHADOFBK<T> : OECPPGFIOBI<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DEB0", Offset = "0x4D6D2B0", VA = "0x184D6DEB0", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4D6DE40", Offset = "0x4D6D240", VA = "0x184D6DE40", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5029810", Offset = "0x5028C10", VA = "0x185029810", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48939C0", Offset = "0x4892DC0", VA = "0x1848939C0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public NKJBHADOFBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ABGCIPMFGGG<T> : OECPPGFIOBI<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x47ECA20", Offset = "0x47EBE20", VA = "0x1847ECA20", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x47EC9B0", Offset = "0x47EBDB0", VA = "0x1847EC9B0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x47EC930", Offset = "0x47EBD30", VA = "0x1847EC930", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x47E4FC0", Offset = "0x47E43C0", VA = "0x1847E4FC0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public ABGCIPMFGGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class KNLINNLEHEK<T> : OECPPGFIOBI<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4CE7A60", Offset = "0x4CE6E60", VA = "0x184CE7A60", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4CE79F0", Offset = "0x4CE6DF0", VA = "0x184CE79F0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CE7970", Offset = "0x4CE6D70", VA = "0x184CE7970", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46E5BB0", Offset = "0x46E4FB0", VA = "0x1846E5BB0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public KNLINNLEHEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HLBNMECFFLB<T> : OECPPGFIOBI<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4893940", Offset = "0x4892D40", VA = "0x184893940", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x48938D0", Offset = "0x4892CD0", VA = "0x1848938D0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4893850", Offset = "0x4892C50", VA = "0x184893850", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x48939C0", Offset = "0x4892DC0", VA = "0x1848939C0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C1270", VA = "0x1846C1E70")]
		public HLBNMECFFLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HMGFJJDGPCB<T> : BIGMGHHHNBL<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x489C650", Offset = "0x489BA50", VA = "0x18489C650", Slot = "12")]
		protected override void GFGGAEJHOJN(IAKLECKPNKG FIMFKJDMEKB, char JNEDANLGGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x489C680", Offset = "0x489BA80", VA = "0x18489C680", Slot = "11")]
		protected override void ODPKKLBMBJL(KKNPENMGICP NAEIDONDAPA, [Out] char JNEDANLGGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x41C9C80", Offset = "0x41C9080", VA = "0x1841C9C80")]
		public HMGFJJDGPCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class HGFFBDAOIEB<T> : BIGMGHHHNBL<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4884B10", Offset = "0x4883F10", VA = "0x184884B10", Slot = "12")]
		protected override void GFGGAEJHOJN(IAKLECKPNKG FIMFKJDMEKB, IPEndPoint JNEDANLGGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4884B40", Offset = "0x4883F40", VA = "0x184884B40", Slot = "11")]
		protected override void ODPKKLBMBJL(KKNPENMGICP NAEIDONDAPA, [Out] IPEndPoint JNEDANLGGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x41C9C80", Offset = "0x41C9080", VA = "0x1841C9C80")]
		public HGFFBDAOIEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OGOOIEGCFJC<T> : OECPPGFIOBI<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int CFPNDDBFMGG;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5158E90", Offset = "0x5158290", VA = "0x185158E90")]
		public OGOOIEGCFJC(int CGKHNEOJKPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5158D90", Offset = "0x5158190", VA = "0x185158D90", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5158D10", Offset = "0x5158110", VA = "0x185158D10", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5158C90", Offset = "0x5158090", VA = "0x185158C90", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5158E10", Offset = "0x5158210", VA = "0x185158E10", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class PACAHBGJMPL<T> : DLMNJILGMKO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo PNDGDLAEPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type KDPMAEAPPCL;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5292E30", Offset = "0x5292230", VA = "0x185292E30")]
		public PACAHBGJMPL(PropertyInfo ODLMGDFMFJG, Type BHNMIPFGLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5292C50", Offset = "0x5292050", VA = "0x185292C50", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5292BA0", Offset = "0x5291FA0", VA = "0x185292BA0", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5292B40", Offset = "0x5291F40", VA = "0x185292B40", Slot = "7")]
		public override void AGIIAKMNLGM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5292DD0", Offset = "0x52921D0", VA = "0x185292DD0", Slot = "8")]
		public override void NNNAJDDCJAC(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5292D10", Offset = "0x5292110", VA = "0x185292D10", Slot = "9")]
		public override void JKDIHHFLDNO(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5292D70", Offset = "0x5292170", VA = "0x185292D70", Slot = "10")]
		public override void LNGCPPOJIMA(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class ACCDJAAIDJH<T> : PACAHBGJMPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
		public ACCDJAAIDJH(PropertyInfo ODLMGDFMFJG, Type BHNMIPFGLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x47F2F20", Offset = "0x47F2320", VA = "0x1847F2F20", Slot = "5")]
		public override void AHKKEODFCBM(T AHFMFBJMBME, KKNPENMGICP NAEIDONDAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x47F2E70", Offset = "0x47F2270", VA = "0x1847F2E70", Slot = "6")]
		public override void AHGLPFENCIH(T AHFMFBJMBME, IAKLECKPNKG FIMFKJDMEKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class BDEGPLKABGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static BDEGPLKABGN<T> DMADMDPHOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly DLMNJILGMKO<T>[] LHLDJOELOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int ILDGMHGJODP;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C680", Offset = "0x5B5BA80", VA = "0x185B5C680")]
		public BDEGPLKABGN(List<DLMNJILGMKO<T>> HAGPHAKKHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C520", Offset = "0x5B5B920", VA = "0x185B5C520")]
		public void AHGLPFENCIH(T HAPOBHMBDHP, IAKLECKPNKG NACIMEJMHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C5D0", Offset = "0x5B5B9D0", VA = "0x185B5C5D0")]
		public void AHKKEODFCBM(T HAPOBHMBDHP, KKNPENMGICP KILJCGGJECG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class LNDEKOEMIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract DLMNJILGMKO<T> CNKKCIMLPML<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private IAKLECKPNKG FGHKNGNEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int GFMBIFPBINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, LNDEKOEMIHB> KBEIBINMMJB;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9FD0", Offset = "0x6AD93D0", VA = "0x186AD9FD0")]
	public FFJBKNLKNJL(int GLAMLDOEBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x359DF80", Offset = "0x359D380", VA = "0x18359DF80")]
	private BDEGPLKABGN<T> ABEJFDKFECO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x359F0A0", Offset = "0x359E4A0", VA = "0x18359F0A0")]
	public void ELBDPICAHPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x359F160", Offset = "0x359E560", VA = "0x18359F160")]
	public bool OJJOMCGFFJC<T>(KKNPENMGICP KILJCGGJECG, T JMBMDICGCNK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x359F0D0", Offset = "0x359E4D0", VA = "0x18359F0D0")]
	public void LMGGAKIACNI<T>(IAKLECKPNKG NACIMEJMHHK, T HAPOBHMBDHP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JEGCPMLEIPE
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime NIOGOEMPAFP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] GFOIFMPIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EOELGKIPFHA GAHJEMHEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC890", Offset = "0x6ADBC90", VA = "0x186ADC890")]
		get
		{
			return default(EOELGKIPFHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FMEIOFKJHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC8C0", Offset = "0x6ADBCC0", VA = "0x186ADC8C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD120", Offset = "0x6ADC520", VA = "0x186ADD120")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LKDEJOEGDGA DFCEMBAMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD0F0", Offset = "0x6ADC4F0", VA = "0x186ADD0F0")]
		get
		{
			return default(LKDEJOEGDGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC850", Offset = "0x6ADBC50", VA = "0x186ADC850")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PLMMBMJBOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD230", Offset = "0x6ADC630", VA = "0x186ADD230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint FAEFDLAEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC5F0", Offset = "0x6ADB9F0", VA = "0x186ADC5F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? DFOCGCMCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD0C0", Offset = "0x6ADC4C0", VA = "0x186ADD0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? FGKILPAONID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC790", Offset = "0x6ADBB90", VA = "0x186ADC790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? EIPOHECDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCAC0", Offset = "0x6ADBEC0", VA = "0x186ADCAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCCF0", Offset = "0x6ADC0F0", VA = "0x186ADCCF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? GHLEHLDLHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xD240D0", Offset = "0xD234D0", VA = "0x180D240D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD610", Offset = "0x6ADCA10", VA = "0x186ADD610")]
	public JEGCPMLEIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD560", Offset = "0x6ADC960", VA = "0x186ADD560")]
	internal JEGCPMLEIPE(byte[] FIKLNMFCLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC670", Offset = "0x6ADBA70", VA = "0x186ADC670")]
	public static JEGCPMLEIPE CMNHBBEPPBO(byte[] FIKLNMFCLIL, DateTime JKGAODLDCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCAF0", Offset = "0x6ADBEF0", VA = "0x186ADCAF0")]
	internal void KOBIBMNDDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD320", Offset = "0x6ADC720", VA = "0x186ADD320")]
	private void PONEGHHKJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCEC0", Offset = "0x6ADC2C0", VA = "0x186ADCEC0")]
	private DateTime? MDOBOKDIMPL(int NPELPNMIGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC8F0", Offset = "0x6ADBCF0", VA = "0x186ADC8F0")]
	private void IGKOEGKODML(int NPELPNMIGOA, DateTime? FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD160", Offset = "0x6ADC560", VA = "0x186ADD160")]
	private ulong OLJNEHKJNCM(int NPELPNMIGOA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD260", Offset = "0x6ADC660", VA = "0x186ADD260")]
	private void PIKPHJDBGBK(int NPELPNMIGOA, ulong FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC7C0", Offset = "0x6ADBBC0", VA = "0x186ADC7C0")]
	private uint DMAIAMAMIAB(int NPELPNMIGOA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69A4EF0", Offset = "0x69A42F0", VA = "0x1869A4EF0")]
	private static uint BGMPLMEFJBM(uint JFJPEDLJOKC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC590", Offset = "0x6ADB990", VA = "0x186ADC590")]
	private static ulong BGMPLMEFJBM(ulong JFJPEDLJOKC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum EOELGKIPFHA
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
public enum LKDEJOEGDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DAGLLEKPHGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int GDINFMPICNF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int HNLNOKBLALC = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int FADGKCOPBIA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint IGAMEONBFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int FJGDEEKFHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int PNAPNJGHKPD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IKBEMODCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD90E0", Offset = "0x6AD84E0", VA = "0x186AD90E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD90F0", Offset = "0x6AD84F0", VA = "0x186AD90F0")]
	public bool PKEBBBGBIGG(DAOEGEAAGNP NBLDEEBAIHE, int AKIEJPDFOGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class DHPIJBECKAD : DAOEGEAAGNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket NBLDEEBAIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly NDPNMFCPABG ADMANJOJOJB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short GBNFCKNGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9910", Offset = "0x6AD8D10", VA = "0x186AD9910", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int OMEOMMMBPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9930", Offset = "0x6AD8D30", VA = "0x186AD9930", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint PFHHJNHLAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD98F0", Offset = "0x6AD8CF0", VA = "0x186AD98F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily JELBIEDMFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1072130", Offset = "0x1071530", VA = "0x181072130", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9950", Offset = "0x6AD8D50", VA = "0x186AD9950")]
	public DHPIJBECKAD(AddressFamily GIIOMKKIHAO, NDPNMFCPABG ADMANJOJOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD91E0", Offset = "0x6AD85E0", VA = "0x186AD91E0", Slot = "8")]
	public bool BEIDJPODPAI(IPEndPoint GLLKALOCBHK, FHHKPDKJADB EKIHFAEHICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD98B0", Offset = "0x6AD8CB0", VA = "0x186AD98B0", Slot = "9")]
	public int IKNMAFLOPEI(byte[] GODPNOEEIEP, int NPELPNMIGOA, int EOKAMHLPIFK, IPEndPoint LDGPJCAKDIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6AD97A0", Offset = "0x6AD8BA0", VA = "0x186AD97A0", Slot = "10")]
	public int DCEMCEFFLNK(byte[] GODPNOEEIEP, EndPoint DALIEOGFBCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9890", Offset = "0x6AD8C90", VA = "0x186AD9890", Slot = "11")]
	public void DFBMNNHEJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface DAOEGEAAGNP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short GBNFCKNGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int OMEOMMMBPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint PFHHJNHLAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily JELBIEDMFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BEIDJPODPAI(IPEndPoint GLLKALOCBHK, FHHKPDKJADB EKIHFAEHICB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int IKNMAFLOPEI(byte[] GODPNOEEIEP, int NPELPNMIGOA, int EOKAMHLPIFK, IPEndPoint LDGPJCAKDIC);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DCEMCEFFLNK(byte[] GODPNOEEIEP, EndPoint LDGPJCAKDIC);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFBMNNHEJLF();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct JCPFIEGALPM : IEquatable<JCPFIEGALPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long APDKBLEAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long GKPIAFONLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long NEBDNNMPEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int IJJFLMLCCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int NBMMBCNBIKI;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC4D0", Offset = "0x6ADB8D0", VA = "0x186ADC4D0")]
	public JCPFIEGALPM(byte[] ENIHAJKAFII, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC260", Offset = "0x6ADB660", VA = "0x186ADC260")]
	public JCPFIEGALPM(Span<byte> ENIHAJKAFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9B9CD0", Offset = "0x9B90D0", VA = "0x1809B9CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC220", Offset = "0x6ADB620", VA = "0x186ADC220", Slot = "4")]
	public bool Equals(JCPFIEGALPM JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC170", Offset = "0x6ADB570", VA = "0x186ADC170", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AFLKFFOHAOM : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] AJAAJKCKBFC;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PMNDJJNCCOO
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void NCFKEDJHPEO(IPEndPoint ENIHAJKAFII, Span<byte> AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string DEBLLEKLBDH = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int FJOAEHOBMAD = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int MLKDIIGIJNO = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<JCPFIEGALPM, IPEndPoint> MOPDKBDIKIP;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static NCFKEDJHPEO CKICHGGAGHE;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	internal void LFNIJAIGLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	internal void AOPGBLFDCMN(IPEndPoint LDGPJCAKDIC, Span<byte> AMHCLKHIFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class OBNGAHJIPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int MBEBFPFEDLL;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
	protected OBNGAHJIPEC(int IPKECBHKMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LIDKBKPPCIF(IPEndPoint GLLKALOCBHK, byte[] AMHCLKHIFKH, int NPELPNMIGOA, int GHDAIPOHNAO);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LCDOFCMDKKC(IPEndPoint GLLKALOCBHK, byte[] AMHCLKHIFKH, int NPELPNMIGOA, int GHDAIPOHNAO);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class POMCCCCICNJ : OBNGAHJIPEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] MCBJECJLDOM;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator LOAGIPIIABL;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2675350", Offset = "0x2674750", VA = "0x182675350")]
	public POMCCCCICNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEF10", Offset = "0x6AEE310", VA = "0x186AEEF10")]
	public void CJALCJAJAOJ(IPEndPoint GLLKALOCBHK, byte[] MCBJECJLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF8E0", Offset = "0x6AEECE0", VA = "0x186AEF8E0")]
	public void OCIMFKHGFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF420", Offset = "0x6AEE820", VA = "0x186AEF420", Slot = "4")]
	public override void LIDKBKPPCIF(IPEndPoint GLLKALOCBHK, byte[] AMHCLKHIFKH, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF0C0", Offset = "0x6AEE4C0", VA = "0x186AEF0C0", Slot = "5")]
	public override void LCDOFCMDKKC(IPEndPoint GLLKALOCBHK, byte[] AMHCLKHIFKH, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct LDPNJMFNICN
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void NBEMLIAHCNA([NoAlias] byte* IHPHEONJMLM, [NoAlias] byte* MCBJECJLDOM, [NoAlias] byte* PHBGMCJLKBP, int GHDAIPOHNAO);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class MIKHFAFMIDH
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr LOPONDELPMP;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr MILPEKLHBJI;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFCE0", Offset = "0x6AEF0E0", VA = "0x186AEFCE0")]
		[BurstDiscard]
		private static void EANECPNBHPI(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFE00", Offset = "0x6AEF200", VA = "0x186AEFE00")]
		private static IntPtr LIDENFBOIFM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFA10", Offset = "0x6AEEE10", VA = "0x186AEFA10")]
		public static void ANIEHGJAMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		public static void MBHBIOMKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFAB0", Offset = "0x6AEEEB0", VA = "0x186AEFAB0")]
		public unsafe static void BHNBAFNFKNN([NoAlias] byte* IHPHEONJMLM, [NoAlias] byte* MCBJECJLDOM, [NoAlias] byte* PHBGMCJLKBP, int GHDAIPOHNAO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint MCBJECJLDOM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint PHBGMCJLKBP[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint FBFNHGAPOAD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint OENEBFFHJND[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint DJLLEIEBDMJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint BHANAMNIKLF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint KPPEKJPGEPC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint JGBCKJEMJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint CEENAEAMICL[8];

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF940", Offset = "0x6ADED40", VA = "0x186ADF940")]
	private void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF7B0", Offset = "0x6ADEBB0", VA = "0x186ADF7B0")]
	private uint BKBJKLMMMCA(uint AEPDMGGJHKC, int EHANEAIKKIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7BE0", Offset = "0x6AD6FE0", VA = "0x186AD7BE0")]
	private void MBDEPPMOJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7C90", Offset = "0x6AD7090", VA = "0x186AD7C90")]
	private void MNGJDOHFGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7A50", Offset = "0x6AD6E50", VA = "0x186AD7A50")]
	private void BMFGMDAJICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7AE0", Offset = "0x6AD6EE0", VA = "0x186AD7AE0")]
	private void FPNILCINFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF9C0", Offset = "0x6ADEDC0", VA = "0x186ADF9C0")]
	private void DGPMCDJAIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFA90", Offset = "0x6ADEE90", VA = "0x186ADFA90")]
	private unsafe void OEDAHAKPAFG(byte* IHPHEONJMLM, uint* MCBJECJLDOM, uint* PHBGMCJLKBP, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF7E0", Offset = "0x6ADEBE0", VA = "0x186ADF7E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void CCBOCFPFHMP([NoAlias] byte* IHPHEONJMLM, [NoAlias] byte* MCBJECJLDOM, [NoAlias] byte* PHBGMCJLKBP, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF860", Offset = "0x6ADEC60", VA = "0x186ADF860")]
	public static void CCBOCFPFHMP(Span<byte> IHPHEONJMLM, Span<byte> MCBJECJLDOM, Span<byte> PHBGMCJLKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFEB0", Offset = "0x6ADF2B0", VA = "0x186ADFEB0")]
	public static void PIHKPFKKCKK(Span<byte> IHPHEONJMLM, Span<byte> MCBJECJLDOM, Span<byte> PHBGMCJLKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFA20", Offset = "0x6ADEE20", VA = "0x186ADFA20")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void GCILOIKNDPA([NoAlias] byte* IHPHEONJMLM, [NoAlias] byte* MCBJECJLDOM, [NoAlias] byte* PHBGMCJLKBP, int GHDAIPOHNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0050", Offset = "0x6AEF450", VA = "0x186AF0050")]
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
