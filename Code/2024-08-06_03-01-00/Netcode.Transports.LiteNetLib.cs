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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LBCKPHGIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HCABPBBOMNL
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
		private NetworkManager OAALKNBOAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, FHHBIADCJDE> CAAOFINBMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JAPHANJGOOE EDBLAPLILHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] KKKLILAELKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HCABPBBOMNL GDNEFJLEGCM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ENKJMCGBBNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool AIAEBGJKIGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA840", Offset = "0x5DE8E40", VA = "0x185DEA840", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9D50", Offset = "0x5DE8350", VA = "0x185DE9D50")]
		public void RecRoom_SetEncryptionInfo(ulong CADMLGOHPAE, byte[] MNBFPOFIDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9D30", Offset = "0x5DE8330", VA = "0x185DE9D30")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9AC0", Offset = "0x5DE80C0", VA = "0x185DE9AC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA740", Offset = "0x5DE8D40", VA = "0x185DEA740")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9EF0", Offset = "0x5DE84F0", VA = "0x185DE9EF0", Slot = "6")]
		public override void Send(ulong KIGBCPJBALA, ArraySegment<byte> JHLEMCFOEMF, NetworkDelivery LABIPEJLNFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9CF0", Offset = "0x5DE82F0", VA = "0x185DE9CF0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong KIGBCPJBALA, [Out] ArraySegment<byte> JFHMMOFAOJJ, [Out] float ENDGCLHEIFI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA1E0", Offset = "0x5DE87E0", VA = "0x185DEA1E0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA660", Offset = "0x5DE8C60", VA = "0x185DEA660", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9300", Offset = "0x5DE7900", VA = "0x185DE9300", Slot = "10")]
		public override void DisconnectRemoteClient(ulong KIGBCPJBALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE91B0", Offset = "0x5DE77B0", VA = "0x185DE91B0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9750", Offset = "0x5DE7D50", VA = "0x185DE9750", Slot = "12")]
		public override ulong GetCurrentRtt(ulong KIGBCPJBALA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA170", Offset = "0x5DE8770", VA = "0x185DEA170", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DE98D0", Offset = "0x5DE7ED0", VA = "0x185DE98D0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager OAALKNBOAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9680", Offset = "0x5DE7C80", VA = "0x185DE9680")]
		private BIMICFHCNCE GDBBJPDIDIK(NetworkDelivery BDKLEMDNAFL)
		{
			return default(BIMICFHCNCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9810", Offset = "0x5DE7E10", VA = "0x185DE9810", Slot = "15")]
		private void HKGIDPGPBEM(FHHBIADCJDE CIOGEBFOKBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9BB0", Offset = "0x5DE81B0", VA = "0x185DE9BB0", Slot = "16")]
		private void PMNMAFONMGE(FHHBIADCJDE CIOGEBFOKBL, FJGBBNBJDHG NLBCANNIKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "17")]
		private void IEMAAJDCMNC(IPEndPoint IMNCPDLCDPB, SocketError HBEMLEGDLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9470", Offset = "0x5DE7A70", VA = "0x185DE9470", Slot = "18")]
		private void EPMLMDDPFMO(FHHBIADCJDE CIOGEBFOKBL, KJAJKAEDOOG NOHOKOEFICC, byte PEANJLPIMLK, BIMICFHCNCE JNFIGJCBJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9070", Offset = "0x5DE7670", VA = "0x185DE9070")]
		private void DDAGHGIBFLK(int PPOFLGDKIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "19")]
		private void JBEGMCNPLKF(IPEndPoint LGGOIEACOLK, KJAJKAEDOOG NOHOKOEFICC, MCJOCKODIMP MLOJLIODKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "20")]
		private void KCCACCKAJAE(FHHBIADCJDE CIOGEBFOKBL, int NJIKFHDPIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9150", Offset = "0x5DE7750", VA = "0x185DE9150", Slot = "21")]
		private void DPPKDIKEGAJ(HBAJDFOIJDL FALAJMPCHDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9A90", Offset = "0x5DE8090", VA = "0x185DE9A90")]
		private ulong LJGKJNHDIMM(FHHBIADCJDE CIOGEBFOKBL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE97F0", Offset = "0x5DE7DF0", VA = "0x185DE97F0")]
		private static int HHNCKBKIKNP(float OPCFFCHKCFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA760", Offset = "0x5DE8D60", VA = "0x185DEA760")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class BELKIIAEAND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly FHHBIADCJDE KJNIGCBFADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<FAJIFKEGMLL> MEJCDPOLJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int AEPMCFPHHNE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5960", Offset = "0x5DD3F60", VA = "0x185DD5960")]
	protected BELKIIAEAND(FHHBIADCJDE CIOGEBFOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5840", Offset = "0x5DD3E40", VA = "0x185DD5840")]
	public void DCEAFKFEBNC(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DD58E0", Offset = "0x5DD3EE0", VA = "0x185DD58E0")]
	protected void MFPALMCHPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DD58A0", Offset = "0x5DD3EA0", VA = "0x185DD58A0")]
	public bool LCFGJBCEACN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IMCANHCHHEK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool COPAFHEIKPF(FAJIFKEGMLL GGOLENPOCHK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BKNFCEEFOEJ
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
public class HBAJDFOIJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JAPHANJGOOE MHDHGHDAALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int KGDALACKFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CENGALIOPGH DAAOHJHBBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IHGOCGCCKFN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BKNFCEEFOEJ JEHIKDPJHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x885C10", Offset = "0x884210", VA = "0x180885C10")]
		[CompilerGenerated]
		get
		{
			return default(BKNFCEEFOEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBAFE50", Offset = "0xBAE450", VA = "0x180BAFE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD8F0", Offset = "0x5DDBEF0", VA = "0x185DDD8F0")]
	internal void FONOKKCMCOP(CENGALIOPGH JOAKNOPPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD8C0", Offset = "0x5DDBEC0", VA = "0x185DDD8C0")]
	private bool FAHIAEDBMJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD9B0", Offset = "0x5DDBFB0", VA = "0x185DDD9B0")]
	internal HBAJDFOIJDL(IPEndPoint LGGOIEACOLK, CENGALIOPGH MBIIJLJEEHB, JAPHANJGOOE FDLHMKJINEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD950", Offset = "0x5DDBF50", VA = "0x185DDD950")]
	public FHHBIADCJDE HIHLAIDBJKG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MCJOCKODIMP
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OBOCPBMOLPL
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
public struct FJGBBNBJDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OBOCPBMOLPL MMMGIIANKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError MPJPHDDPCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KJAJKAEDOOG AEIGBOHKNEM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LBCKPHGIGMG
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHALAFGCJPE(FHHBIADCJDE CIOGEBFOKBL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIJOBOGAGPA(FHHBIADCJDE CIOGEBFOKBL, FJGBBNBJDHG NLBCANNIKGM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBEKBCLKAMA(IPEndPoint IMNCPDLCDPB, SocketError HBEMLEGDLAI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBGJEGGMEJP(FHHBIADCJDE CIOGEBFOKBL, KJAJKAEDOOG NOHOKOEFICC, byte PEANJLPIMLK, BIMICFHCNCE JNFIGJCBJAP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APKFFMDHBMJ(IPEndPoint LGGOIEACOLK, KJAJKAEDOOG NOHOKOEFICC, MCJOCKODIMP MLOJLIODKBP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFKKBHDOCKF(FHHBIADCJDE CIOGEBFOKBL, int NJIKFHDPIAF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOLLOCEHBDH(HBAJDFOIJDL FALAJMPCHDK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHMALKKGPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LABOFLINMDC(FHHBIADCJDE CIOGEBFOKBL, object ABJMKCJGBOF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ABEGOACKKAD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLGIFKLHENG(DHFICDNACFM GGOLENPOCHK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JNLEOHCAMPK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDCNANNKDCN(FHHBIADCJDE CIOGEBFOKBL, IPEndPoint DPBEBLBPAKI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CENGALIOPGH
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int CNPJFMCECIA = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long LKOALNKMDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte LHJKJDHEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] ODMJDGPJCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KDGLPGOMELM LFHGEGNPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int OIFJNAELMMH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5E70", Offset = "0x5DD4470", VA = "0x185DD5E70")]
	private CENGALIOPGH(long OMJBJPKHEID, byte DGPMGFEHFCJ, int CJKJJBEPLLO, byte[] DHOJMLLNBOJ, KDGLPGOMELM JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5E10", Offset = "0x5DD4410", VA = "0x185DD5E10")]
	public static int FDPPIFEOOEI(FAJIFKEGMLL GGOLENPOCHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5A10", Offset = "0x5DD4010", VA = "0x185DD5A10")]
	public static CENGALIOPGH BMGNGMHOAFO(FAJIFKEGMLL GGOLENPOCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5C30", Offset = "0x5DD4230", VA = "0x185DD5C30")]
	public static FAJIFKEGMLL CEBHKJINCLJ(GAHAODHOLEJ NJKNPCBLLOD, SocketAddress HCNPNAMJJNP, long KGEKIEGMEAB, int CJKJJBEPLLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class IKEECEAIFNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long LKOALNKMDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte LHJKJDHEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int OIFJNAELMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JNMBGLEIJFO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE090", Offset = "0x5DDC690", VA = "0x185DDE090")]
	private IKEECEAIFNH(long OMJBJPKHEID, byte DGPMGFEHFCJ, int KEGKMKAGOAC, bool GOJPLLDJAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDD50", Offset = "0x5DDC350", VA = "0x185DDDD50")]
	public static IKEECEAIFNH BMGNGMHOAFO(FAJIFKEGMLL GGOLENPOCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDEA0", Offset = "0x5DDC4A0", VA = "0x185DDDEA0")]
	public static FAJIFKEGMLL CEBHKJINCLJ(long KGEKIEGMEAB, byte KDOFDNBOMLD, int KHPMANMIDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDF90", Offset = "0x5DDC590", VA = "0x185DDDF90")]
	public static FAJIFKEGMLL NMNMPANAEFC(FHHBIADCJDE CIOGEBFOKBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NCBCDFPIJFC
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CBNOBOIFJON
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJJHAKAPAAC(IPEndPoint AKJPIOIHJKC, IPEndPoint LGGOIEACOLK, string PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFHCCNPJAMG(IPEndPoint IKKCDBGGDNG, NCBCDFPIJFC BDKLEMDNAFL, string PNPIGCGKNPI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DPLGBKCFMEE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BAJCFMKAGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint EEHNCMPDFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint IHGOCGCCKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string AKAKJLCCBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NNLPKIGMGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint HCDBDBBLDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NCBCDFPIJFC FJKMPMDCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string AKAKJLCCBBP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class OICBGLNJNMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BCAHIIDKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string AKAKJLCCBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OICBGLNJNMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class NBALKCDMMLC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BCAHIIDKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint FFLNMJKFPPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string AKAKJLCCBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NBALKCDMMLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KFCOJMCDOBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AKAKJLCCBBP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NDFIAJNCKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85D420", Offset = "0x85BA20", VA = "0x18085D420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KFCOJMCDOBL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JAPHANJGOOE DJABIHAJGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<BAJCFMKAGPL> CADOCPGPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<NNLPKIGMGLH> JFKOFLGPNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KDGLPGOMELM ICKHANEBNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GAHAODHOLEJ OOFNLFDDJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MIOGAMHGFPO AJBKCOPBPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CBNOBOIFJON CPFIGGNIJDL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int IAANFANPLLA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool MKEDJNKJHKA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD79F0", Offset = "0x5DD5FF0", VA = "0x185DD79F0")]
	internal DPLGBKCFMEE(JAPHANJGOOE JMEACLPKCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7890", Offset = "0x5DD5E90", VA = "0x185DD7890")]
	internal void OJEMHJCEOEO(IPEndPoint IAMHCBEPACE, FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29B0110", Offset = "0x29AE710", VA = "0x1829B0110")]
	private void PNEAACIBKKG<T>(T GGOLENPOCHK, IPEndPoint MNAGKONPJOO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7700", Offset = "0x5DD5D00", VA = "0x185DD7700")]
	private void NJJHAKAPAAC(OICBGLNJNMB LGPDBFALGFE, IPEndPoint IAMHCBEPACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DD75A0", Offset = "0x5DD5BA0", VA = "0x185DD75A0")]
	private void GNAAKJCNODB(NBALKCDMMLC LGPDBFALGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7410", Offset = "0x5DD5A10", VA = "0x185DD7410")]
	private void CBALKHKOMCC(KFCOJMCDOBL LGPDBFALGFE, IPEndPoint IAMHCBEPACE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BIMICFHCNCE : byte
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
public enum KDOEOHEDPBK : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HDINIIOCFLA
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] GLGJKBBAKJL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int FKDLFIAJOMG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int OMPNBEPDLID;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DNEBJDEBHGI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5A00", Offset = "0x5DD4000", VA = "0x185DD5A00")]
	public DNEBJDEBHGI(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JMOBBIIECIO : DNEBJDEBHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5A00", Offset = "0x5DD4000", VA = "0x185DD5A00")]
	public JMOBBIIECIO(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IBAJPIIPABI
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
public interface JBNODGBOCKB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKCNKNEIDIF(IBAJPIIPABI MLCOGACEDDA, string GCCBDCNGFBP, params object[] HCHKMMKNKKB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class JFBEMJGPPDI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static JBNODGBOCKB HPFKDOAHJJM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object BMKHBLBNJHH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5310", Offset = "0x5DE3910", VA = "0x185DE5310")]
	private static void AIAHHCPLFFI(IBAJPIIPABI FGJGLFCONOB, string GCCBDCNGFBP, params object[] HCHKMMKNKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DE55F0", Offset = "0x5DE3BF0", VA = "0x185DE55F0")]
	internal static void OHEOAGMLLMP(string GCCBDCNGFBP, params object[] HCHKMMKNKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5590", Offset = "0x5DE3B90", VA = "0x185DE5590")]
	internal static void MFBDKIGMCCL(string GCCBDCNGFBP, params object[] HCHKMMKNKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5530", Offset = "0x5DE3B30", VA = "0x185DE5530")]
	internal static void BBNANMJOAAM(string GCCBDCNGFBP, params object[] HCHKMMKNKKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum JCALLMCKBIG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KJAJKAEDOOG : KDGLPGOMELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private FAJIFKEGMLL LCFHCGFJAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JAPHANJGOOE JCOGNGNPMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CGHJAMCJNLC JEFBLDMMDIP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8490", Offset = "0x5DE6A90", VA = "0x185DE8490")]
	internal KJAJKAEDOOG(JAPHANJGOOE FHLJNPENEDC, CGHJAMCJNLC MHJNANNAHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE83A0", Offset = "0x5DE69A0", VA = "0x185DE83A0")]
	internal void KPFCMALLBMJ(FAJIFKEGMLL GGOLENPOCHK, int MADOPNHEECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8410", Offset = "0x5DE6A10", VA = "0x185DE8410")]
	internal void MNHPDMEMALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8370", Offset = "0x5DE6970", VA = "0x185DE8370")]
	public void FCHJJLPHFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CGHJAMCJNLC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PPIPOIDNOCE
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
	public CGHJAMCJNLC PKGJKBJFPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public PPIPOIDNOCE FJKMPMDCIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public FHHBIADCJDE KJNIGCBFADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint IHGOCGCCKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object DKGOECDOBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int HHIJBGDDFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError NHIHLIOKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public OBOCPBMOLPL OIGELEDFGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public HBAJDFOIJDL AKHOCDLKGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public BIMICFHCNCE MNFFOMIPDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte CACALBADGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly KJAJKAEDOOG HCGIJDGMGGE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5EE0", Offset = "0x5DD44E0", VA = "0x185DD5EE0")]
	public CGHJAMCJNLC(JAPHANJGOOE FHLJNPENEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JAPHANJGOOE : IEnumerable<FHHBIADCJDE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JDAAFCOLKFD : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52A0", Offset = "0x5DE38A0", VA = "0x185DE52A0", Slot = "4")]
		public bool Equals(IPEndPoint OEMFOJFNECE, IPEndPoint DPKOFHFGJKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58857B0", Offset = "0x5883DB0", VA = "0x1858857B0", Slot = "5")]
		public int GetHashCode(IPEndPoint CDBNFNMIHPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JDAAFCOLKFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KKDGIPDPLFC : IEnumerator<FHHBIADCJDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly FHHBIADCJDE DDIDGMFPBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FHHBIADCJDE NPEPFMDMEOE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FHHBIADCJDE LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9A9F00", Offset = "0x9A8500", VA = "0x1809A9F00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9A9F00", Offset = "0x9A8500", VA = "0x1809A9F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x11B5370", Offset = "0x11B3970", VA = "0x1811B5370")]
		public KKDGIPDPLFC(FHHBIADCJDE DCGDLJBAKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE84E0", Offset = "0x5DE6AE0", VA = "0x185DE84E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8530", Offset = "0x5DE6B30", VA = "0x185DE8530", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread LFDOKNDBOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool PGAGGLJMGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CHBKGHOIGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CGHJAMCJNLC> EDNIIJEHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CGHJAMCJNLC> FIAMOAJDHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CGHJAMCJNLC HFCENBCFCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LBCKPHGIGMG CJFFDHKEPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NHMALKKGPPB AAIJBPAJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ABEGOACKKAD IPHIIMCHLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JNLEOHCAMPK KMJCEBAJNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, FHHBIADCJDE> ECENPFJNBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, HBAJDFOIJDL> OOGHFOMFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, DBIHLLOPKNK> OCKJGINGJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim BAIHHNHAABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private FHHBIADCJDE DLALGDLGAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int DKHODHMKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<FHHBIADCJDE> LGGGAKFAEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FHHBIADCJDE[] ANNJOCJKHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JBJABOADJCG MLNBECOBELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int POKOBHPNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> LDMNFIFKMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte OIDMFIPCOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object KBJHEHHBLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool MJENDGBLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NLNLOOLHBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LEEGDBOEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int CMNMJBIAAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HJKFLPMGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int BKLEODBPJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool IGFNPDJKEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool LBFLHNNCELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int ILAFJMAACOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int NANHFEDJJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int HPEOKNFAGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MKEDJNKJHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool ANJBPOEMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ALONHIOLDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool HKHNLBGFPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MNPGNJOPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GDLIGMLIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FHGMNLDEHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KHPGDHPLMHB HIMCJIBFNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool ALNHFAKLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly DPLGBKCFMEE GJDPKEEJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool CCAAHAODEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public JCALLMCKBIG EDLKOGKGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int MCIEADBILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool FCGACKNIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GJOCLAIPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool PELEFBPMNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool DNAFMOFPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private FAJIFKEGMLL ILFODHHLCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int GPEPIHHIBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object AEOKGJCABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FAJIFKEGMLL FHBINGFMFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int PKFMLAFAEKM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int JHCGBIMFMAB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int IOKNOBOCLNC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FDFOCDICDKM NNBLBOKFFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private FDFOCDICDKM GFEDIFEOBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread BNAMMCONKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread AJLOMLHMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint HBDEHMAKAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint PIDGLFOJKIM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] NENLCKHFNJP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] EMMOKDGBAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<ACHGDEGOBFJ, IPEndPoint> CAMNHAKNKOO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress BCDNDFACKGB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool COEBPIICENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MNPGIHNOEMG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool COHFILMNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCB2DA0", Offset = "0xCB13A0", VA = "0x180CB2DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD82560", Offset = "0xD80B60", VA = "0x180D82560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BCPPIPPCHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15D16D0", Offset = "0x15CFCD0", VA = "0x1815D16D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x19015A0", Offset = "0x18FFBA0", VA = "0x1819015A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte AECJAKJFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99A0A0", Offset = "0x9986A0", VA = "0x18099A0A0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GPGBFKAKFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0CC0", Offset = "0x5DDF2C0", VA = "0x185DE0CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FELCMJCBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2380", Offset = "0x5DE0980", VA = "0x185DE2380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0CE0", Offset = "0x5DDF2E0", VA = "0x185DE0CE0")]
	public void DOIMLGFHJIN(IPEndPoint IMNCPDLCDPB, byte[] MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4920", Offset = "0x5DE2F20", VA = "0x185DE4920")]
	public void PMCKANGJOPJ(IPEndPoint IMNCPDLCDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DE02F0", Offset = "0x5DDE8F0", VA = "0x185DE02F0")]
	private bool CBPMHFFBBJK(IPEndPoint IMNCPDLCDPB, [Out] FHHBIADCJDE CIOGEBFOKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DE20C0", Offset = "0x5DE06C0", VA = "0x185DE20C0")]
	private void JLLKKEGGLOH(FHHBIADCJDE CIOGEBFOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DE18B0", Offset = "0x5DDFEB0", VA = "0x185DE18B0")]
	private void GJJKACPGNBN(FHHBIADCJDE CIOGEBFOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2740", Offset = "0x5DE0D40", VA = "0x185DE2740")]
	private void MLPHLPBINAO(FHHBIADCJDE CIOGEBFOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C50", Offset = "0x5DE3250", VA = "0x185DE4C50")]
	public JAPHANJGOOE(LBCKPHGIGMG FDLHMKJINEF, [Optional] JBJABOADJCG MAFABFFODLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1900", Offset = "0x5DDFF00", VA = "0x185DE1900")]
	internal void HHGJCJLFJKI(FHHBIADCJDE DGDMIBFENFF, int NJIKFHDPIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE48D0", Offset = "0x5DE2ED0", VA = "0x185DE48D0")]
	internal void OOIFKHNDFLA(FHHBIADCJDE DGDMIBFENFF, object ABJMKCJGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1490", Offset = "0x5DDFA90", VA = "0x185DE1490")]
	internal void FAFGPLICNCF(FHHBIADCJDE CIOGEBFOKBL, OBOCPBMOLPL HBKEEHODHEK, SocketError OMOEEHADBGC, FAJIFKEGMLL PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1660", Offset = "0x5DDFC60", VA = "0x185DE1660")]
	private void GBEJMNLHEDO(FHHBIADCJDE CIOGEBFOKBL, OBOCPBMOLPL HBKEEHODHEK, SocketError OMOEEHADBGC, bool EFJJGJMLHPN, byte[] JHLEMCFOEMF, int KKKICJLJANF, int FDDANCOAHOL, FAJIFKEGMLL PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3250", Offset = "0x5DE1850", VA = "0x185DE3250")]
	private void MPBECAKPHCI(CGHJAMCJNLC.PPIPOIDNOCE BDKLEMDNAFL, [Optional] FHHBIADCJDE CIOGEBFOKBL, [Optional] IPEndPoint LGGOIEACOLK, SocketError OJPBOBDPLEA = SocketError.Success, int NJIKFHDPIAF = 0, OBOCPBMOLPL ANPNIKFFPNK = OBOCPBMOLPL.ConnectionFailed, [Optional] HBAJDFOIJDL IPKOIIPNNJP, BIMICFHCNCE JNFIGJCBJAP = BIMICFHCNCE.Unreliable, byte PEANJLPIMLK = 0, [Optional] FAJIFKEGMLL ADDEINKGNMD, [Optional] object ABJMKCJGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4130", Offset = "0x5DE2730", VA = "0x185DE4130")]
	private void ONBKAEAMJHF(CGHJAMCJNLC MHJNANNAHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1560", Offset = "0x5DDFB60", VA = "0x185DE1560")]
	internal void FNOEPNOPNPP(CGHJAMCJNLC MHJNANNAHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3DF0", Offset = "0x5DE23F0", VA = "0x185DE3DF0")]
	private void OIGLPOFMOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DE09A0", Offset = "0x5DDEFA0", VA = "0x185DE09A0")]
	private void CJLGACBMACI(int LABKAALOMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE710", Offset = "0x5DDCD10", VA = "0x185DDE710")]
	internal FHHBIADCJDE AHFCONJPGBJ(HBAJDFOIJDL FALAJMPCHDK, byte[] OGIDHHPAJMN, int KKKICJLJANF, int KDDFOIMAIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DE26C0", Offset = "0x5DE0CC0", VA = "0x185DE26C0")]
	private int MKEPGMKKMKI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0540", Offset = "0x5DDEB40", VA = "0x185DE0540")]
	private void CHNLPEDLMFC(IPEndPoint LGGOIEACOLK, FHHBIADCJDE MNOBMJNGGBC, CENGALIOPGH HKEBKHMMDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF540", Offset = "0x5DDDB40", VA = "0x185DDF540")]
	private void BLOODNMAECE(FAJIFKEGMLL GGOLENPOCHK, IPEndPoint LGGOIEACOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEFF0", Offset = "0x5DDD5F0", VA = "0x185DDEFF0")]
	internal void ALIBEBKOJHP(FAJIFKEGMLL GGOLENPOCHK, BIMICFHCNCE JBDDLLAECDN, byte PEANJLPIMLK, int MADOPNHEECN, FHHBIADCJDE DGDMIBFENFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DE29B0", Offset = "0x5DE0FB0", VA = "0x185DE29B0")]
	public bool MNIJFILABEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2990", Offset = "0x5DE0F90", VA = "0x185DE2990")]
	public bool MNIJFILABEH(IPAddress FCKJAFKEHPM, IPAddress ELOHMHGFLJI, int NANHFFBKFEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A20", Offset = "0x5DE1020", VA = "0x185DE2A20")]
	public bool MNIJFILABEH(int NANHFFBKFEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1F20", Offset = "0x5DE0520", VA = "0x185DE1F20")]
	public void JHECDPDCCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0F00", Offset = "0x5DDF500", VA = "0x185DE0F00")]
	public FHHBIADCJDE ENPKLGKBAFI(string JNOIOMLBIAE, int NANHFFBKFEG, string MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0FE0", Offset = "0x5DDF5E0", VA = "0x185DE0FE0")]
	public FHHBIADCJDE ENPKLGKBAFI(string JNOIOMLBIAE, int NANHFFBKFEG, GAHAODHOLEJ AGMIBBEKOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE10C0", Offset = "0x5DDF6C0", VA = "0x185DE10C0")]
	public FHHBIADCJDE ENPKLGKBAFI(IPEndPoint MNAGKONPJOO, GAHAODHOLEJ AGMIBBEKOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3BC0", Offset = "0x5DE21C0", VA = "0x185DE3BC0")]
	public void NLEFALBLLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3870", Offset = "0x5DE1E70", VA = "0x185DE3870")]
	public void NLEFALBLLKB(bool LGNKMCOBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3BD0", Offset = "0x5DE21D0", VA = "0x185DE3BD0")]
	public void NNFHKDBOOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3CD0", Offset = "0x5DE22D0", VA = "0x185DE3CD0")]
	public void NNFHKDBOOKE(byte[] JHLEMCFOEMF, int KKKICJLJANF, int FDDANCOAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1740", Offset = "0x5DDFD40", VA = "0x185DE1740")]
	public void GBEJMNLHEDO(FHHBIADCJDE CIOGEBFOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5DE17F0", Offset = "0x5DDFDF0", VA = "0x185DE17F0")]
	public void GBEJMNLHEDO(FHHBIADCJDE CIOGEBFOKBL, byte[] JHLEMCFOEMF, int KKKICJLJANF, int FDDANCOAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4A70", Offset = "0x5DE3070", VA = "0x185DE4A70", Slot = "4")]
	private IEnumerator<FHHBIADCJDE> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B00", Offset = "0x5DE3100", VA = "0x185DE4B00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0460", Offset = "0x5DDEA60", VA = "0x185DE0460")]
	private FAJIFKEGMLL CHDDELBEJFA(AJPFMHBGGDJ MLBHCALGJAO, int PPOFLGDKIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0380", Offset = "0x5DDE980", VA = "0x185DE0380")]
	private FAJIFKEGMLL CHDDELBEJFA(AJPFMHBGGDJ MLBHCALGJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF310", Offset = "0x5DDD910", VA = "0x185DDF310")]
	internal FAJIFKEGMLL BCIKKHIKBNO(int PPOFLGDKIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1CD0", Offset = "0x5DE02D0", VA = "0x185DE1CD0")]
	internal void IOFLMKGOOCN(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B90", Offset = "0x5DE3190", VA = "0x185DE4B90")]
	static JAPHANJGOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCB2DA0", Offset = "0xCB13A0", VA = "0x180CB2DA0")]
	private bool ADAIPAMBJMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3780", Offset = "0x5DE1D80", VA = "0x185DE3780")]
	private void NKICBEAOEAE(IPEndPoint EHBKOFAJNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DE25E0", Offset = "0x5DE0BE0", VA = "0x185DE25E0")]
	private void MBCMBOPKMPD(IPEndPoint EHBKOFAJNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2440", Offset = "0x5DE0A40", VA = "0x185DE2440")]
	private bool LPJHEPJOEBK(SocketException KLEFNMOCNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DDED20", Offset = "0x5DDD320", VA = "0x185DDED20")]
	private void AIMDKLNAGHG(FDFOCDICDKM JMEACLPKCHG, EndPoint FGOMGBJKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1950", Offset = "0x5DDFF50", VA = "0x185DE1950")]
	private void HMMIOGHEPED(object HJBEGIDNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2AA0", Offset = "0x5DE10A0", VA = "0x185DE2AA0")]
	public bool MNIJFILABEH(IPAddress FCKJAFKEHPM, IPAddress ELOHMHGFLJI, int NANHFFBKFEG, bool IJKHJDEDGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF2B0", Offset = "0x5DDD8B0", VA = "0x185DDF2B0")]
	internal int BCFHKHHBOED(FAJIFKEGMLL GGOLENPOCHK, IPEndPoint LGGOIEACOLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE6D0", Offset = "0x5DDCCD0", VA = "0x185DDE6D0")]
	internal int AEGGGIGGIAH(FAJIFKEGMLL GGOLENPOCHK, IPEndPoint LGGOIEACOLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE0E0", Offset = "0x5DDC6E0", VA = "0x185DDE0E0")]
	internal int AEGGGIGGIAH(byte[] DICMABMCPKO, int KKKICJLJANF, int KDDFOIMAIHK, IPEndPoint LGGOIEACOLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3610", Offset = "0x5DE1C10", VA = "0x185DE3610")]
	internal void NDBKDFCFDOC(bool EPIDOCMPMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum AJPFMHBGGDJ : byte
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
internal sealed class FAJIFKEGMLL
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HLFANCJILNK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] JGDPDOKDLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] CLMGJKCDLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BONHNBEOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object DKGOECDOBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public FAJIFKEGMLL PKGJKBJFPHI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AJPFMHBGGDJ EOPEJPLBMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DD83D0", Offset = "0x5DD69D0", VA = "0x185DD83D0")]
		get
		{
			return default(AJPFMHBGGDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7E40", Offset = "0x5DD6440", VA = "0x185DD7E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte LHJKJDHEHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7F80", Offset = "0x5DD6580", VA = "0x185DD7F80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8220", Offset = "0x5DD6820", VA = "0x185DD8220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MPGKFDBFFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8290", Offset = "0x5DD6890", VA = "0x185DD8290")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8040", Offset = "0x5DD6640", VA = "0x185DD8040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JMFFKAOALNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DD80F0", Offset = "0x5DD66F0", VA = "0x185DD80F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte EPLIKLDLKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8260", Offset = "0x5DD6860", VA = "0x185DD8260")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7FB0", Offset = "0x5DD65B0", VA = "0x185DD7FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort NBFBBBNLNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8330", Offset = "0x5DD6930", VA = "0x185DD8330")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DD82F0", Offset = "0x5DD68F0", VA = "0x185DD82F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort KHHJCFEKHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8400", Offset = "0x5DD6A00", VA = "0x185DD8400")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8390", Offset = "0x5DD6990", VA = "0x185DD8390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort EPLMEEFOCII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7FE0", Offset = "0x5DD65E0", VA = "0x185DD7FE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DD80B0", Offset = "0x5DD66B0", VA = "0x185DD80B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8460", Offset = "0x5DD6A60", VA = "0x185DD8460")]
	static FAJIFKEGMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8080", Offset = "0x5DD6680", VA = "0x185DD8080")]
	public void HBAFOBFKINJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8830", Offset = "0x5DD6E30", VA = "0x185DD8830")]
	public FAJIFKEGMLL(int PPOFLGDKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8720", Offset = "0x5DD6D20", VA = "0x185DD8720")]
	public FAJIFKEGMLL(AJPFMHBGGDJ MLBHCALGJAO, int PPOFLGDKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7F10", Offset = "0x5DD6510", VA = "0x185DD7F10")]
	public static int ALPOELAFEHE(AJPFMHBGGDJ MLBHCALGJAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7E80", Offset = "0x5DD6480", VA = "0x185DD7E80")]
	public int ALPOELAFEHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8120", Offset = "0x5DD6720", VA = "0x185DD8120")]
	public bool JDEIFNBCFMC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OEIIDHFHAJJ : byte
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
internal enum IHHODDOKLPC
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
internal enum HPLHFDBBJLJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum AFENILOAHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FHHBIADCJDE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class APGPAAPLOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FAJIFKEGMLL[] NGMMEFPJIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JJFGPOMMGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int FNJBCLDPJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte EPLIKLDLKEF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public APGPAAPLOOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void NIJHIIAPKAD(ulong MLOJALHHNMJ, int COBLHKHAEGM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int AEOMFMIGMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int OCIBPDLFBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int CHAAMEDNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double IKGONHCGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int AKDIELNGEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int PAPNOFKACDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int HNIHKHKMFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch EFHFCGMGNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int NDJGILBHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long GFGGAJJBECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object GBHJEDKBINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal FHHBIADCJDE IHCGLJNDEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal FHHBIADCJDE HHJJCEKHDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<FAJIFKEGMLL> NPKAOCPNFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<BELKIIAEAND> GBIGNDFPAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly BELKIIAEAND[] MDEPGLACMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int GHKLKIEKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int PBDJNJPLPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool NHINMNJGDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int BGKBMJLHGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int MKLEGCICKKH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int BAEJBHPFJFC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int IFNMOKGNHJE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DONDBIPMBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CBOKFJLLAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, APGPAAPLOOA> HHBJDHMGCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BHLEDPOADIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FAJIFKEGMLL HNNJLBCAILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HJEJDNECGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int AOEFEEDNKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint OEFDNNHBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CDFDBOHMGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HELNDGGNHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long JBOMGHGIPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FFCGCDLPMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OEIIDHFHAJJ CAKIHDNNOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private FAJIFKEGMLL JLMHIPFLIOA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NGCMAELLEJG = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HMLOFLGNKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FAJIFKEGMLL HCMMOOHGFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly FAJIFKEGMLL CCNKDDHJBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly FAJIFKEGMLL PIOIDHBADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly FAJIFKEGMLL MAGGPEIBCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KDOEOHEDPBK JEKNNLMDKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly JAPHANJGOOE HOAFACDFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int EPFHNBBFJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object HCONHNEMFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KHPGDHPLMHB HIMCJIBFNNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte HHECFGFOEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCF57C0", Offset = "0xCF3DC0", VA = "0x180CF57C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB530", Offset = "0x5DD9B30", VA = "0x185DDB530")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint GLCLHMGODIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A2CB0", Offset = "0x9A12B0", VA = "0x1809A2CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OEIIDHFHAJJ JBFMODKHJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1412A20", Offset = "0x1411020", VA = "0x181412A20")]
		get
		{
			return default(OEIIDHFHAJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long GOBJJIECFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8645D0", Offset = "0x862BD0", VA = "0x1808645D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PJGFCGJLPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xDC62E0", Offset = "0xDC48E0", VA = "0x180DC62E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x16BD9D0", Offset = "0x16BBFD0", VA = "0x1816BD9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DGAOFNBPDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DD88A0", Offset = "0x5DD6EA0", VA = "0x185DD88A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HHNLEBDCGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86D300", Offset = "0x86B900", VA = "0x18086D300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CPIAHKDLDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1B66380", Offset = "0x1B64980", VA = "0x181B66380")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NIJHIIAPKAD JNEBEPAIOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBC10", Offset = "0x5DDA210", VA = "0x185DDBC10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA100", Offset = "0x5DD8700", VA = "0x185DDA100")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC450", Offset = "0x5DDAA50", VA = "0x185DDC450")]
	internal FHHBIADCJDE(JAPHANJGOOE MPJGHEIGICL, IPEndPoint LGGOIEACOLK, int KAGKMEDPMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBCC0", Offset = "0x5DDA2C0", VA = "0x185DDBCC0")]
	internal void KBFIHBMHKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC260", Offset = "0x5DDA860", VA = "0x185DDC260")]
	internal void OCNPOBBOOIJ(IPEndPoint HNHKCCLKFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA070", Offset = "0x5DD8670", VA = "0x185DDA070")]
	internal void CJHNPBJBCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9430", Offset = "0x5DD7A30", VA = "0x185DD9430")]
	private void BHBHJGIOGEA(int MJLDGABBHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBFA0", Offset = "0x5DDA5A0", VA = "0x185DDBFA0")]
	private void KOOJGCHEABL(int DCBNGBJFEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD88B0", Offset = "0x5DD6EB0", VA = "0x185DD88B0")]
	private BELKIIAEAND AJGFGGOAKJN(byte HCFIMDJDENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC2C0", Offset = "0x5DDA8C0", VA = "0x185DDC2C0")]
	internal FHHBIADCJDE(JAPHANJGOOE MPJGHEIGICL, IPEndPoint LGGOIEACOLK, int KAGKMEDPMHO, byte KDOFDNBOMLD, GAHAODHOLEJ NJKNPCBLLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC8A0", Offset = "0x5DDAEA0", VA = "0x185DDC8A0")]
	internal FHHBIADCJDE(JAPHANJGOOE MPJGHEIGICL, HBAJDFOIJDL FALAJMPCHDK, int KAGKMEDPMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB170", Offset = "0x5DD9770", VA = "0x185DDB170")]
	internal void FJKNBPMJCKJ(CENGALIOPGH GPLDJIHNADF, byte[] JHLEMCFOEMF, int KKKICJLJANF, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBFE0", Offset = "0x5DDA5E0", VA = "0x185DDBFE0")]
	internal bool MGAECBMNMKJ(IKEECEAIFNH GGOLENPOCHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC290", Offset = "0x5DDA890", VA = "0x185DDC290")]
	public void PNEAACIBKKG(byte[] JHLEMCFOEMF, int KKKICJLJANF, int KDDFOIMAIHK, BIMICFHCNCE KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA860", Offset = "0x5DD8E60", VA = "0x185DDA860")]
	private void DCEEMBFLFLE(byte[] JHLEMCFOEMF, int KKKICJLJANF, int KDDFOIMAIHK, byte PEANJLPIMLK, BIMICFHCNCE JNFIGJCBJAP, object ABJMKCJGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDADB0", Offset = "0x5DD93B0", VA = "0x185DDADB0")]
	public void DGKJHCAGFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB5E0", Offset = "0x5DD9BE0", VA = "0x185DDB5E0")]
	internal HPLHFDBBJLJ HOLPPJOEDED(FAJIFKEGMLL GGOLENPOCHK)
	{
		return default(HPLHFDBBJLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9650", Offset = "0x5DD7C50", VA = "0x185DD9650")]
	internal void CBBNPBALOJM(BELKIIAEAND POGNCCGEMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAE60", Offset = "0x5DD9460", VA = "0x185DDAE60")]
	internal AFENILOAHNC FJFEOEPJCBO(byte[] JHLEMCFOEMF, int KKKICJLJANF, int KDDFOIMAIHK, bool EFJJGJMLHPN)
	{
		return default(AFENILOAHNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8A60", Offset = "0x5DD7060", VA = "0x185DD8A60")]
	private void BCDGFPGEPBJ(int IDFGFKKEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8AA0", Offset = "0x5DD70A0", VA = "0x185DD8AA0")]
	internal void BHAFABBLDPG(BIMICFHCNCE JBDDLLAECDN, FAJIFKEGMLL DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB6C0", Offset = "0x5DD9CC0", VA = "0x185DDB6C0")]
	private void ICNADOKBKDC(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB1C0", Offset = "0x5DD97C0", VA = "0x185DDB1C0")]
	private void FLFLIHNCLIM(int KNACCMPDNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9EB0", Offset = "0x5DD84B0", VA = "0x185DD9EB0")]
	internal IHHODDOKLPC CHNLPEDLMFC(CENGALIOPGH HKEBKHMMDPJ)
	{
		return default(IHHODDOKLPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA1B0", Offset = "0x5DD87B0", VA = "0x185DDA1B0")]
	internal void COPAFHEIKPF(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9500", Offset = "0x5DD7B00", VA = "0x185DD9500")]
	private void BMIPCMOPFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC060", Offset = "0x5DDA660", VA = "0x185DDC060")]
	internal void MPKEOFIENNB(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD96B0", Offset = "0x5DD7CB0", VA = "0x185DD96B0")]
	internal void CCBJGFJMACJ(int KNACCMPDNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBCE0", Offset = "0x5DDA2E0", VA = "0x185DDBCE0")]
	internal void KFGIJCALFED(FAJIFKEGMLL GGOLENPOCHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KHPGDHPLMHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long BALKMCBDKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long HKPIJHOFEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long NGKLFPAHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DEJJGBJAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long DGPGCGNNDDM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long OKKAGDICNKE;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long KGGJLOBLFAN;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long KBIFCIIDPDJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long AJABCBIHBPG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long LOMLJOAIHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long ONAPIJJNAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long HKCIBKCHKOI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long BDBMIGHPKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7E10", Offset = "0x5DE6410", VA = "0x185DE7E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HBBIFPMOLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8020", Offset = "0x5DE6620", VA = "0x185DE8020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long JGCFIMOPBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7E80", Offset = "0x5DE6480", VA = "0x185DE7E80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long CKLBGMIOFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D80", Offset = "0x5DE6380", VA = "0x185DE7D80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BHDCJJICMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7DA0", Offset = "0x5DE63A0", VA = "0x185DE7DA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long KBCNGIAINLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7FB0", Offset = "0x5DE65B0", VA = "0x185DE7FB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long DNFOIIIJAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D00", Offset = "0x5DE6300", VA = "0x185DE7D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long PKDFKDMKABH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7C60", Offset = "0x5DE6260", VA = "0x185DE7C60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KDOEOHEDPBK DLNPCLJAEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D90", Offset = "0x5DE6390", VA = "0x185DE7D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double DHFOMBEMOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7E20", Offset = "0x5DE6420", VA = "0x185DE7E20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7D40", Offset = "0x5DE6340", VA = "0x185DE7D40")]
	public void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7EE0", Offset = "0x5DE64E0", VA = "0x185DE7EE0")]
	public void LLNHDAPFMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7E90", Offset = "0x5DE6490", VA = "0x185DE7E90")]
	public void KJOEACEJMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7DB0", Offset = "0x5DE63B0", VA = "0x185DE7DB0")]
	public void FMEMIJIINDB(long NEICCMFMELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CA0", Offset = "0x5DE62A0", VA = "0x185DE7CA0")]
	public void AMCICCGDKLC(long INAGBHGEIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7FC0", Offset = "0x5DE65C0", VA = "0x185DE7FC0")]
	public void PBICAKINNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7F40", Offset = "0x5DE6540", VA = "0x185DE7F40")]
	public void MGEMNDECHOL(long MGAGLKJEOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8030", Offset = "0x5DE6630", VA = "0x185DE8030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7BC0", Offset = "0x5DE61C0", VA = "0x185DE7BC0")]
	public void ABFPLBCPFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KHPGDHPLMHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PBKEKMHBLID
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> BJFFFPFHCCI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBEF0", Offset = "0x5DEA4F0", VA = "0x185DEBEF0")]
	public static IPEndPoint PHDHPFNECHC(string FPOGNFCNKIN, int NANHFFBKFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBD20", Offset = "0x5DEA320", VA = "0x185DEBD20")]
	public static IPAddress MEEOJKMFLEI(string FPOGNFCNKIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBC90", Offset = "0x5DEA290", VA = "0x185DEBC90")]
	public static IPAddress MEEOJKMFLEI(string FPOGNFCNKIN, AddressFamily PCAOKLFDCGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBC60", Offset = "0x5DEA260", VA = "0x185DEBC60")]
	internal static int DCFEDNAPIOO(int MMICDLLDGNC, int GJJODCBBGNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A0F0", Offset = "0x2D086F0", VA = "0x182D0A0F0")]
	internal static T[] NHGPFFINGJP<T>(int FDDANCOAHOL) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ODCBBIBBIKI : BELKIIAEAND
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct PDBAJIIPBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private FAJIFKEGMLL LCFHCGFJAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long KGMNDHNCFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool LBPMDNPPALG;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC2B0", Offset = "0x5DEA8B0", VA = "0x185DEC2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC1D0", Offset = "0x5DEA7D0", VA = "0x185DEC1D0")]
		public void HACFLNNNDIG(FAJIFKEGMLL GGOLENPOCHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC1F0", Offset = "0x5DEA7F0", VA = "0x185DEC1F0")]
		public bool HKKFOANHAOC(long KHKDAGALAAP, FHHBIADCJDE CIOGEBFOKBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC260", Offset = "0x5DEA860", VA = "0x185DEC260")]
		public bool KFLPEIEEDCE(FHHBIADCJDE CIOGEBFOKBL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly FAJIFKEGMLL HNJLNNHIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly PDBAJIIPBMN[] HCCHKBKLJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly FAJIFKEGMLL[] HLJNKCAHFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] GAGPONJFDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int JDPFOPIGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int ACGBCNNMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int DLCJMAODHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int ICDCOEEBLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool EMOIBBDKFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly BIMICFHCNCE OMEAGAENAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool AEKHJJNCEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int NLMKCGAFEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte PMOMHMFEGKI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBA90", Offset = "0x5DEA090", VA = "0x185DEBA90")]
	public ODCBBIBBIKI(FHHBIADCJDE CIOGEBFOKBL, bool GMJDLHFALGL, byte KAGKMEDPMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEABE0", Offset = "0x5DE91E0", VA = "0x185DEABE0")]
	private void CAEDCPCJPAE(FAJIFKEGMLL GGOLENPOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5E0", Offset = "0x5DE9BE0", VA = "0x185DEB5E0", Slot = "4")]
	protected override bool IMCANHCHHEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAF80", Offset = "0x5DE9580", VA = "0x185DEAF80", Slot = "5")]
	public override bool COPAFHEIKPF(FAJIFKEGMLL GGOLENPOCHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JIHJNANGDBB : BELKIIAEAND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int KNEFKJKDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort ACGBCNNMONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool KKMHPHCLEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private FAJIFKEGMLL ADJPKGGFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly FAJIFKEGMLL NBIBIACAPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool CPCFJOMFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte PMOMHMFEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long KNJLMNPNFLN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5EA0", Offset = "0x5DE44A0", VA = "0x185DE5EA0")]
	public JIHJNANGDBB(FHHBIADCJDE CIOGEBFOKBL, bool DKJDMHPIADJ, byte KAGKMEDPMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5DE59E0", Offset = "0x5DE3FE0", VA = "0x185DE59E0", Slot = "4")]
	protected override bool IMCANHCHHEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5700", Offset = "0x5DE3D00", VA = "0x185DE5700", Slot = "5")]
	public override bool COPAFHEIKPF(FAJIFKEGMLL GGOLENPOCHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HJENOOEMFCF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct DHHHLHFFAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong EAEAKIDBDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double NBJPLKAOMDO;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JEOPFCBPBBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int OBLAFPPNOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float EELCBFAAPPB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5120", Offset = "0x5DD3720", VA = "0x185DD5120")]
	private static void GKPIPHCGHHE(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, ulong JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDC30", Offset = "0x5DDC230", VA = "0x185DDDC30")]
	private static void GKPIPHCGHHE(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCB0", Offset = "0x5DDC2B0", VA = "0x185DDDCB0")]
	public static void GKPIPHCGHHE(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, short JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDC10", Offset = "0x5DDC210", VA = "0x185DDDC10")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, double FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB90", Offset = "0x5DDC190", VA = "0x185DDDB90")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCB0", Offset = "0x5DDC2B0", VA = "0x185DDDCB0")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, short FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCB0", Offset = "0x5DDC2B0", VA = "0x185DDDCB0")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, ushort FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDC30", Offset = "0x5DDC230", VA = "0x185DDDC30")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDC30", Offset = "0x5DDC230", VA = "0x185DDDC30")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, uint FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCA0", Offset = "0x5DDC2A0", VA = "0x185DDDCA0")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCA0", Offset = "0x5DDC2A0", VA = "0x185DDDCA0")]
	public static void CIGIBIKEEEG(byte[] CNNPIMPOGKL, int CHEJIFFIDLB, ulong FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KDGLPGOMELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] CKHJEAIDNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int DHHBENCPDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int KHDPOLKCNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int DBIHOEJCMAA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] CLMGJKCDLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EFDIBAJAGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JOBHNHIDBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6F80", Offset = "0x5DE5580", VA = "0x185DE6F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BFLDAPJMHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1EE5FB0", Offset = "0x1EE45B0", VA = "0x181EE5FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FLHOCIGGNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7690", Offset = "0x5DE5C90", VA = "0x185DE7690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE5BA0", VA = "0x185DE75A0")]
	public void KPFCMALLBMJ(byte[] JOCJMGGBHIC, int LHOLHMCKPEO, int ENCBDPLPCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KDGLPGOMELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7B60", Offset = "0x5DE6160", VA = "0x185DE7B60")]
	public KDGLPGOMELM(byte[] JOCJMGGBHIC, int LHOLHMCKPEO, int ENCBDPLPCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7440", Offset = "0x5DE5A40", VA = "0x185DE7440")]
	public IPEndPoint JEBEAMHLPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE71E0", Offset = "0x5DE57E0", VA = "0x185DE71E0")]
	public byte FHDDKFICHDE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE71E0", Offset = "0x5DE57E0", VA = "0x185DE71E0")]
	public sbyte OMJMMIBBKOJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2C039B0", Offset = "0x2C01FB0", VA = "0x182C039B0")]
	public T[] FJDMHKGLFBI<T>(ushort PPOFLGDKIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7A00", Offset = "0x5DE6000", VA = "0x185DE7A00")]
	public bool[] ODJAJJFINAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6F90", Offset = "0x5DE5590", VA = "0x185DE6F90")]
	public ushort[] AGOCDEKHJCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7160", Offset = "0x5DE5760", VA = "0x185DE7160")]
	public short[] CLJFCLOLKNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DE71A0", Offset = "0x5DE57A0", VA = "0x185DE71A0")]
	public int[] EAFOGPPMIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7400", Offset = "0x5DE5A00", VA = "0x185DE7400")]
	public uint[] IPKLKLHAGKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6FD0", Offset = "0x5DE55D0", VA = "0x185DE6FD0")]
	public float[] AIADEHELDEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7350", Offset = "0x5DE5950", VA = "0x185DE7350")]
	public double[] IIBMCPENAOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75E0", Offset = "0x5DE5BE0", VA = "0x185DE75E0")]
	public long[] LFEECDMOJDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7A40", Offset = "0x5DE6040", VA = "0x185DE7A40")]
	public ulong[] OJLJNDBFJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DE78D0", Offset = "0x5DE5ED0", VA = "0x185DE78D0")]
	public string[] MJGALNJGFKL(int IMANJNONOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7310", Offset = "0x5DE5910", VA = "0x185DE7310")]
	public bool IEHCBBPHHIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DE70F0", Offset = "0x5DE56F0", VA = "0x185DE70F0")]
	public char BGFOHECBAEH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE70F0", Offset = "0x5DE56F0", VA = "0x185DE70F0")]
	public ushort MCPKJBAGKID()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7390", Offset = "0x5DE5990", VA = "0x185DE7390")]
	public short IMPDIFADICH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7010", Offset = "0x5DE5610", VA = "0x185DE7010")]
	public long AKJHKANCMAG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7620", Offset = "0x5DE5C20", VA = "0x185DE7620")]
	public ulong LIIBKHHFFLG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7080", Offset = "0x5DE5680", VA = "0x185DE7080")]
	public int ANKDODMNFGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7AF0", Offset = "0x5DE60F0", VA = "0x185DE7AF0")]
	public uint PJOBNCDPNJG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7A80", Offset = "0x5DE6080", VA = "0x185DE7A80")]
	public float PCAHFLPCINM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7220", Offset = "0x5DE5820", VA = "0x185DE7220")]
	public double HDABNJAIONC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DE76A0", Offset = "0x5DE5CA0", VA = "0x185DE76A0")]
	public string MIJBLGOAGIO(int IHDCDPNCONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7510", Offset = "0x5DE5B10", VA = "0x185DE7510")]
	public ArraySegment<byte> JPIJHMJKEMC(int FDDANCOAHOL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7290", Offset = "0x5DE5890", VA = "0x185DE7290")]
	public sbyte[] HFPEAAGJCAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DE72D0", Offset = "0x5DE58D0", VA = "0x185DE72D0")]
	public byte[] IABAAKKFNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7580", Offset = "0x5DE5B80", VA = "0x185DE7580")]
	public void KFLPEIEEDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GAHAODHOLEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] CKHJEAIDNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int DHHBENCPDLN;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int MKJJEMOCAPH = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool IHAKOCPBOGN;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding HGKGBFOJOPK;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int EEFCGGLKOCL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] MPENDMONHOL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] LFHGEGNPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD7A0", Offset = "0x5DDBDA0", VA = "0x185DDD7A0")]
	public GAHAODHOLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD820", Offset = "0x5DDBE20", VA = "0x185DDD820")]
	public GAHAODHOLEJ(bool JPMFBIELAND, int NFNIGJEKKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCB60", Offset = "0x5DDB160", VA = "0x185DDCB60")]
	public static GAHAODHOLEJ EGJCAICONAN(string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCBD0", Offset = "0x5DDB1D0", VA = "0x185DDCBD0")]
	public void FADHAHDHLID(int OLPDBLKOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F580", Offset = "0x1F5DB80", VA = "0x181F5F580")]
	public void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD1B0", Offset = "0x5DDB7B0", VA = "0x185DDD1B0")]
	public void MDDLFNALLMI(float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD330", Offset = "0x5DDB930", VA = "0x185DDD330")]
	public void MDDLFNALLMI(double FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD6D0", Offset = "0x5DDBCD0", VA = "0x185DDD6D0")]
	public void MDDLFNALLMI(long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD6D0", Offset = "0x5DDBCD0", VA = "0x185DDD6D0")]
	public void MDDLFNALLMI(ulong FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD0C0", Offset = "0x5DDB6C0", VA = "0x185DDD0C0")]
	public void MDDLFNALLMI(int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD0C0", Offset = "0x5DDB6C0", VA = "0x185DDD0C0")]
	public void MDDLFNALLMI(uint FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD2B0", Offset = "0x5DDB8B0", VA = "0x185DDD2B0")]
	public void MDDLFNALLMI(char FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD2B0", Offset = "0x5DDB8B0", VA = "0x185DDD2B0")]
	public void MDDLFNALLMI(ushort FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD2B0", Offset = "0x5DDB8B0", VA = "0x185DDD2B0")]
	public void MDDLFNALLMI(short FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD250", Offset = "0x5DDB850", VA = "0x185DDD250")]
	public void MDDLFNALLMI(sbyte FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD250", Offset = "0x5DDB850", VA = "0x185DDD250")]
	public void MDDLFNALLMI(byte FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD450", Offset = "0x5DDBA50", VA = "0x185DDD450")]
	public void MDDLFNALLMI(byte[] JHLEMCFOEMF, int LHOLHMCKPEO, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCA80", Offset = "0x5DDB080", VA = "0x185DDCA80")]
	public void AOOLPBAJEKH(sbyte[] JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCA80", Offset = "0x5DDB080", VA = "0x185DDCA80")]
	public void FAIFILOGPGC(byte[] JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD150", Offset = "0x5DDB750", VA = "0x185DDD150")]
	public void MDDLFNALLMI(bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCFE0", Offset = "0x5DDB5E0", VA = "0x185DDCFE0")]
	public void GAGNGCAELIH(Array JOGNBCLEEKD, int JIKJIAELMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCD50", Offset = "0x5DDB350", VA = "0x185DDCD50")]
	public void GAGNGCAELIH(float[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCC70", Offset = "0x5DDB270", VA = "0x185DDCC70")]
	public void GAGNGCAELIH(double[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCC70", Offset = "0x5DDB270", VA = "0x185DDCC70")]
	public void GAGNGCAELIH(long[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCC70", Offset = "0x5DDB270", VA = "0x185DDCC70")]
	public void GAGNGCAELIH(ulong[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCD50", Offset = "0x5DDB350", VA = "0x185DDCD50")]
	public void GAGNGCAELIH(int[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCD50", Offset = "0x5DDB350", VA = "0x185DDCD50")]
	public void GAGNGCAELIH(uint[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCF00", Offset = "0x5DDB500", VA = "0x185DDCF00")]
	public void GAGNGCAELIH(ushort[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCF00", Offset = "0x5DDB500", VA = "0x185DDCF00")]
	public void GAGNGCAELIH(short[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCA80", Offset = "0x5DDB080", VA = "0x185DDCA80")]
	public void GAGNGCAELIH(bool[] FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCE30", Offset = "0x5DDB430", VA = "0x185DDCE30")]
	public void GAGNGCAELIH(string[] FEBGGALLBNN, int EOOKLIFLPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD380", Offset = "0x5DDB980", VA = "0x185DDD380")]
	public void MDDLFNALLMI(IPEndPoint IMNCPDLCDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD320", Offset = "0x5DDB920", VA = "0x185DDD320")]
	public void MDDLFNALLMI(string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD4C0", Offset = "0x5DDBAC0", VA = "0x185DDD4C0")]
	public void MDDLFNALLMI(string FEBGGALLBNN, int IHDCDPNCONH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MIOGAMHGFPO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class OEALEANFIGB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong EPFHNBBFJEO;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x46D69F0", Offset = "0x46D4FF0", VA = "0x1846D69F0")]
		static OEALEANFIGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KIAHDDIHNII(KDGLPGOMELM NOHOKOEFICC, object ABJMKCJGBOF);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JOCALBOAACB<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public MIOGAMHGFPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JOCALBOAACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40F8CA0", Offset = "0x40F72A0", VA = "0x1840F8CA0")]
		internal void ALCBLEOLLIH(KDGLPGOMELM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EMAOCFAIOCL<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public MIOGAMHGFPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EMAOCFAIOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x380A4A0", Offset = "0x3808AA0", VA = "0x18380A4A0")]
		internal void ALCBLEOLLIH(KDGLPGOMELM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly HIEPAFFINKH NALMPCEDOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, KIAHDDIHNII> BBKKPPOJIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly GAHAODHOLEJ CMHFKBOOMBC;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAA60", Offset = "0x5DE9060", VA = "0x185DEAA60")]
	public MIOGAMHGFPO(int IMANJNONOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28F93C0", Offset = "0x28F79C0", VA = "0x1828F93C0", Slot = "4")]
	protected virtual ulong KCBJMPEGKLK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA860", Offset = "0x5DE8E60", VA = "0x185DEA860", Slot = "5")]
	protected virtual KIAHDDIHNII ADMJBKJNKEB(KDGLPGOMELM NOHOKOEFICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C599D0", Offset = "0x2C57FD0", VA = "0x182C599D0", Slot = "6")]
	protected virtual void ABFMBPNANBK<T>(GAHAODHOLEJ PLACLKJNIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA9E0", Offset = "0x5DE8FE0", VA = "0x185DEA9E0")]
	public void EACFMFOAMMM(KDGLPGOMELM NOHOKOEFICC, object ABJMKCJGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C59A40", Offset = "0x2C58040", VA = "0x182C59A40")]
	public void HLFLKFIELLH<T>(GAHAODHOLEJ PLACLKJNIBM, T GGOLENPOCHK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA990", Offset = "0x5DE8F90", VA = "0x185DEA990")]
	public void BEJOONOHDLE(KDGLPGOMELM NOHOKOEFICC, object ABJMKCJGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2C59CB0", Offset = "0x2C582B0", VA = "0x182C59CB0")]
	public void LJOLGPCBLCP<T>(Action<T> FDIHJFNOFHI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2C59AF0", Offset = "0x2C580F0", VA = "0x182C59AF0")]
	public void LJOLGPCBLCP<T, TUserData>(Action<T, TUserData> FDIHJFNOFHI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BJEGMAHGGMH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5A00", Offset = "0x5DD4000", VA = "0x185DD5A00")]
	public BJEGMAHGGMH(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class HOOBPBAALNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCF0", Offset = "0x5DDC2F0", VA = "0x185DDDCF0")]
	public HOOBPBAALNF(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HIEPAFFINKH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum BPBNLBCJFJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class ONFBDPJCGBO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public BPBNLBCJFJF FJKMPMDCIGN;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x473C1B0", Offset = "0x473A7B0", VA = "0x18473C1B0", Slot = "4")]
		public virtual void HACFLNNNDIG(MethodInfo FFFCBPAAMNO, MethodInfo AGPKPAHIDCH, BPBNLBCJFJF BDKLEMDNAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KMJLBKCBAKP(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CJHNKPFOIFI(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected ONFBDPJCGBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GPGAABBHCBJ<TClass, TProperty> : ONFBDPJCGBO<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> HONDAEEKLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> NFKCMBODFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> CHGHONOPHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> IKIILHJLEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> EJHKHAINIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> OHEHAMBBDJI;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3CFF5E0", Offset = "0x3CFDBE0", VA = "0x183CFF5E0", Slot = "7")]
		public override void NLACNEDLIPE(TClass ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8940", Offset = "0x3CF6F40", VA = "0x183CF8940", Slot = "8")]
		public override void BBPNNIPCEPA(TClass ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3CFEB60", Offset = "0x3CFD160", VA = "0x183CFEB60", Slot = "9")]
		public override void KMJLBKCBAKP(TClass ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9310", Offset = "0x3CF7910", VA = "0x183CF9310", Slot = "10")]
		public override void CJHNKPFOIFI(TClass ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8DA0", Offset = "0x3CF73A0", VA = "0x183CF8DA0")]
		protected TProperty[] BMLIKAPDINA(TClass ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9A10", Offset = "0x3CF8010", VA = "0x183CF9A10")]
		protected TProperty[] GDOCFIJPBLE(TClass ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE050", Offset = "0x3CFC650", VA = "0x183CFE050", Slot = "4")]
		public override void HACFLNNNDIG(MethodInfo FFFCBPAAMNO, MethodInfo AGPKPAHIDCH, BPBNLBCJFJF BDKLEMDNAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFCE0", Offset = "0x3CFE2E0", VA = "0x183CFFCE0")]
		protected GPGAABBHCBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class PMHBNAOLKGG<TClass, TProperty> : GPGAABBHCBJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void GLCEFBFGDNB(KDGLPGOMELM IIMGHHPJFMO, [Out] TProperty HPJONBNOMIP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KKGPCDJMHBK(GAHAODHOLEJ BABLFAIMKPL, TProperty HPJONBNOMIP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x483B410", Offset = "0x4839A10", VA = "0x18483B410", Slot = "5")]
		public override void OBHAHCLECJI(TClass ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x483B160", Offset = "0x4839760", VA = "0x18483B160", Slot = "6")]
		public override void HLFLKFIELLH(TClass ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x483B2B0", Offset = "0x48398B0", VA = "0x18483B2B0", Slot = "7")]
		public override void NLACNEDLIPE(TClass ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x483AF50", Offset = "0x4839550", VA = "0x18483AF50", Slot = "8")]
		public override void BBPNNIPCEPA(TClass ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37DBDE0", Offset = "0x37DA3E0", VA = "0x1837DBDE0")]
		protected PMHBNAOLKGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class ACFKKKPMDAE<T> : GPGAABBHCBJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C560", Offset = "0x3C6AB60", VA = "0x183C6C560", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C470", Offset = "0x3C6AA70", VA = "0x183C6C470", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C4E0", Offset = "0x3C6AAE0", VA = "0x183C6C4E0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C400", Offset = "0x3C6AA00", VA = "0x183C6C400", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public ACFKKKPMDAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LNMAHJOKDFP<T> : GPGAABBHCBJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x42E9500", Offset = "0x42E7B00", VA = "0x1842E9500", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C470", Offset = "0x3C6AA70", VA = "0x183C6C470", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x42E9480", Offset = "0x42E7A80", VA = "0x1842E9480", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C400", Offset = "0x3C6AA00", VA = "0x183C6C400", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public LNMAHJOKDFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class JNKMMHGPKAL<T> : GPGAABBHCBJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x40F8A40", Offset = "0x40F7040", VA = "0x1840F8A40", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x40F8950", Offset = "0x40F6F50", VA = "0x1840F8950", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x40F89C0", Offset = "0x40F6FC0", VA = "0x1840F89C0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x40F88E0", Offset = "0x40F6EE0", VA = "0x1840F88E0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public JNKMMHGPKAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class KOIOEJFGIKF<T> : GPGAABBHCBJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x42197F0", Offset = "0x4217DF0", VA = "0x1842197F0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x40F8950", Offset = "0x40F6F50", VA = "0x1840F8950", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4219770", Offset = "0x4217D70", VA = "0x184219770", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x40F88E0", Offset = "0x40F6EE0", VA = "0x1840F88E0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public KOIOEJFGIKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JDKOFNOPODO<T> : GPGAABBHCBJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x40091F0", Offset = "0x40077F0", VA = "0x1840091F0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3E57340", Offset = "0x3E55940", VA = "0x183E57340", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4009170", Offset = "0x4007770", VA = "0x184009170", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E572D0", Offset = "0x3E558D0", VA = "0x183E572D0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public JDKOFNOPODO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class INGOOIBDPOB<T> : GPGAABBHCBJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E57430", Offset = "0x3E55A30", VA = "0x183E57430", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E57340", Offset = "0x3E55940", VA = "0x183E57340", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E573B0", Offset = "0x3E559B0", VA = "0x183E573B0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E572D0", Offset = "0x3E558D0", VA = "0x183E572D0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public INGOOIBDPOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class OBNAFLMPGKB<T> : GPGAABBHCBJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x44E3CD0", Offset = "0x44E22D0", VA = "0x1844E3CD0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x44E3BE0", Offset = "0x44E21E0", VA = "0x1844E3BE0", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x46D3540", Offset = "0x46D1B40", VA = "0x1846D3540", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C63000", Offset = "0x3C61600", VA = "0x183C63000", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public OBNAFLMPGKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MDDEDJMAGCE<T> : GPGAABBHCBJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x44E3CD0", Offset = "0x44E22D0", VA = "0x1844E3CD0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x44E3BE0", Offset = "0x44E21E0", VA = "0x1844E3BE0", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x44E3C50", Offset = "0x44E2250", VA = "0x1844E3C50", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C63000", Offset = "0x3C61600", VA = "0x183C63000", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public MDDEDJMAGCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CNGJBNAKKHA<T> : GPGAABBHCBJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x51BAE60", Offset = "0x51B9460", VA = "0x1851BAE60", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x51BAD70", Offset = "0x51B9370", VA = "0x1851BAD70", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x51BADE0", Offset = "0x51B93E0", VA = "0x1851BADE0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C400", Offset = "0x3C6AA00", VA = "0x183C6C400", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public CNGJBNAKKHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MEBJMJFDHLP<T> : GPGAABBHCBJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x44E5EF0", Offset = "0x44E44F0", VA = "0x1844E5EF0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x44E5E00", Offset = "0x44E4400", VA = "0x1844E5E00", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x44E5E70", Offset = "0x44E4470", VA = "0x1844E5E70", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E572D0", Offset = "0x3E558D0", VA = "0x183E572D0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public MEBJMJFDHLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class AAAMPHLOKKP<T> : GPGAABBHCBJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C63160", Offset = "0x3C61760", VA = "0x183C63160", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C63070", Offset = "0x3C61670", VA = "0x183C63070", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C630E0", Offset = "0x3C616E0", VA = "0x183C630E0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C63000", Offset = "0x3C61600", VA = "0x183C63000", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C631E0", Offset = "0x3C617E0", VA = "0x183C631E0")]
		public AAAMPHLOKKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PIPFLELAOJG<T> : PMHBNAOLKGG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x481DC10", Offset = "0x481C210", VA = "0x18481DC10", Slot = "12")]
		protected override void KKGPCDJMHBK(GAHAODHOLEJ BABLFAIMKPL, char HPJONBNOMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x481DBE0", Offset = "0x481C1E0", VA = "0x18481DBE0", Slot = "11")]
		protected override void GLCEFBFGDNB(KDGLPGOMELM IIMGHHPJFMO, [Out] char HPJONBNOMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9BE0", Offset = "0x3CD81E0", VA = "0x183CD9BE0")]
		public PIPFLELAOJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KBFBOEHAEGO<T> : PMHBNAOLKGG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x41C7CE0", Offset = "0x41C62E0", VA = "0x1841C7CE0", Slot = "12")]
		protected override void KKGPCDJMHBK(GAHAODHOLEJ BABLFAIMKPL, IPEndPoint HPJONBNOMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x41C7CA0", Offset = "0x41C62A0", VA = "0x1841C7CA0", Slot = "11")]
		protected override void GLCEFBFGDNB(KDGLPGOMELM IIMGHHPJFMO, [Out] IPEndPoint HPJONBNOMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9BE0", Offset = "0x3CD81E0", VA = "0x183CD9BE0")]
		public KBFBOEHAEGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NCJOMKEEPFE<T> : GPGAABBHCBJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int CAFOGALLPJE;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x456C440", Offset = "0x456AA40", VA = "0x18456C440")]
		public NCJOMKEEPFE(int IHDCDPNCONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x456C3C0", Offset = "0x456A9C0", VA = "0x18456C3C0", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x456C2C0", Offset = "0x456A8C0", VA = "0x18456C2C0", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x456C340", Offset = "0x456A940", VA = "0x18456C340", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x456C240", Offset = "0x456A840", VA = "0x18456C240", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GLKEKJMCHLL<T> : ONFBDPJCGBO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo EOPEJPLBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type CBHCLFGLKPE;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFBC0", Offset = "0x3CDE1C0", VA = "0x183CDFBC0")]
		public GLKEKJMCHLL(PropertyInfo MLBHCALGJAO, Type DKPOHIBNBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFB00", Offset = "0x3CDE100", VA = "0x183CDFB00", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF990", Offset = "0x3CDDF90", VA = "0x183CDF990", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFAA0", Offset = "0x3CDE0A0", VA = "0x183CDFAA0", Slot = "7")]
		public override void NLACNEDLIPE(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF8D0", Offset = "0x3CDDED0", VA = "0x183CDF8D0", Slot = "8")]
		public override void BBPNNIPCEPA(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFA40", Offset = "0x3CDE040", VA = "0x183CDFA40", Slot = "9")]
		public override void KMJLBKCBAKP(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF930", Offset = "0x3CDDF30", VA = "0x183CDF930", Slot = "10")]
		public override void CJHNKPFOIFI(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KJIKENPCINP<T> : GLKEKJMCHLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
		public KJIKENPCINP(PropertyInfo MLBHCALGJAO, Type DKPOHIBNBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x41F9250", Offset = "0x41F7850", VA = "0x1841F9250", Slot = "5")]
		public override void OBHAHCLECJI(T ALNDPLGBFFO, KDGLPGOMELM IIMGHHPJFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x41F91A0", Offset = "0x41F77A0", VA = "0x1841F91A0", Slot = "6")]
		public override void HLFLKFIELLH(T ALNDPLGBFFO, GAHAODHOLEJ BABLFAIMKPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HJDCDCFIMEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static HJDCDCFIMEE<T> HHHOBHGDEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly ONFBDPJCGBO<T>[] FPOANFNCADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int GIFPBLJJAAL;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D497B0", Offset = "0x3D47DB0", VA = "0x183D497B0")]
		public HJDCDCFIMEE(List<ONFBDPJCGBO<T>> IIMDNJPPNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D49650", Offset = "0x3D47C50", VA = "0x183D49650")]
		public void HLFLKFIELLH(T CDBNFNMIHPK, GAHAODHOLEJ PLACLKJNIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D49700", Offset = "0x3D47D00", VA = "0x183D49700")]
		public void OBHAHCLECJI(T CDBNFNMIHPK, KDGLPGOMELM NOHOKOEFICC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MIEKLDEPBME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ONFBDPJCGBO<T> BJJBEHDKBAF<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private GAHAODHOLEJ CMBNIMMIDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int ENICFNKLLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, MIEKLDEPBME> CINHOJCBBHE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDAF0", Offset = "0x5DDC0F0", VA = "0x185DDDAF0")]
	public HIEPAFFINKH(int IMANJNONOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F970", Offset = "0x2B7DF70", VA = "0x182B7F970")]
	private HJDCDCFIMEE<T> ADODGPNPKHB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x29A2960", Offset = "0x29A0F60", VA = "0x1829A2960")]
	public void OOMCOBOGONK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2B80B20", Offset = "0x2B7F120", VA = "0x182B80B20")]
	public bool DIPBOAAMMJI<T>(KDGLPGOMELM NOHOKOEFICC, T MNAGKONPJOO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2B80A90", Offset = "0x2B7F090", VA = "0x182B80A90")]
	public void ALGEABNCNAB<T>(GAHAODHOLEJ PLACLKJNIBM, T CDBNFNMIHPK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DHFICDNACFM
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime NDHJBJKDBKA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] BBMAJBGBBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DMJKPEAFJFC ODMGKLCPMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DD60C0", Offset = "0x5DD46C0", VA = "0x185DD60C0")]
		get
		{
			return default(DMJKPEAFJFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int CAHNALGAFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6D00", Offset = "0x5DD5300", VA = "0x185DD6D00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6690", Offset = "0x5DD4C90", VA = "0x185DD6690")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PJJJLIMKKBG FDDJLGALADM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DD63E0", Offset = "0x5DD49E0", VA = "0x185DD63E0")]
		get
		{
			return default(PJJJLIMKKBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6080", Offset = "0x5DD4680", VA = "0x185DD6080")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HLOGMPMKLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6CD0", Offset = "0x5DD52D0", VA = "0x185DD6CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint CLLOJKJFNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6410", Offset = "0x5DD4A10", VA = "0x185DD6410")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? ONFBKDBBOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DD66D0", Offset = "0x5DD4CD0", VA = "0x185DD66D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DNNOGIFNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6150", Offset = "0x5DD4750", VA = "0x185DD6150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? DFBAEKNBCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6CA0", Offset = "0x5DD52A0", VA = "0x185DD6CA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6700", Offset = "0x5DD4D00", VA = "0x185DD6700")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? LNBIPCPGELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xD35590", Offset = "0xD33B90", VA = "0x180D35590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xB58210", Offset = "0xB56810", VA = "0x180B58210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD70F0", Offset = "0x5DD56F0", VA = "0x185DD70F0")]
	public DHFICDNACFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7040", Offset = "0x5DD5640", VA = "0x185DD7040")]
	internal DHFICDNACFM(byte[] CNNPIMPOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6EC0", Offset = "0x5DD54C0", VA = "0x185DD6EC0")]
	public static DHFICDNACFM PCAAPPEAOGI(byte[] CNNPIMPOGKL, DateTime AIHOACPFLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD68D0", Offset = "0x5DD4ED0", VA = "0x185DD68D0")]
	internal void INFHIDKGHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6210", Offset = "0x5DD4810", VA = "0x185DD6210")]
	private void CKELMOKPKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6490", Offset = "0x5DD4A90", VA = "0x185DD6490")]
	private DateTime? DEOIAJFCGOP(int LHOLHMCKPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6AD0", Offset = "0x5DD50D0", VA = "0x185DD6AD0")]
	private void JELBDIMHKBF(int LHOLHMCKPEO, DateTime? FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6D30", Offset = "0x5DD5330", VA = "0x185DD6D30")]
	private ulong OADPIOPOJGD(int LHOLHMCKPEO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6E00", Offset = "0x5DD5400", VA = "0x185DD6E00")]
	private void OEEIEKPBDAP(int LHOLHMCKPEO, ulong FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6180", Offset = "0x5DD4780", VA = "0x185DD6180")]
	private uint CCBHBNPNCHE(int LHOLHMCKPEO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAA40", Offset = "0x5CA9040", VA = "0x185CAAA40")]
	private static uint BFLIEOKGJDB(uint OEMFOJFNECE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD60F0", Offset = "0x5DD46F0", VA = "0x185DD60F0")]
	private static ulong BFLIEOKGJDB(ulong OEMFOJFNECE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DMJKPEAFJFC
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
public enum PJJJLIMKKBG
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DBIHLLOPKNK
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int BDKFCKGOBHA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int IFEBOPMLKCK = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int FGCNGNBAHMA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint KGJENOKFGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int ECCLBLOGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int COGHECOALOC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JLBBOKOCBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5F80", Offset = "0x5DD4580", VA = "0x185DD5F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5F90", Offset = "0x5DD4590", VA = "0x185DD5F90")]
	public bool PNEAACIBKKG(FDFOCDICDKM JMEACLPKCHG, int ECKAMDKCMCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JMBJGPCOPMP : FDFOCDICDKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket JMEACLPKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly JAPHANJGOOE MPJGHEIGICL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short FELCMJCBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6D80", Offset = "0x5DE5380", VA = "0x185DE6D80", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ICPJADHNLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE67A0", Offset = "0x5DE4DA0", VA = "0x185DE67A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint EEHNCMPDFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6780", Offset = "0x5DE4D80", VA = "0x185DE6780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily CBLKDIILLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x427CDB0", Offset = "0x427B3B0", VA = "0x18427CDB0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6ED0", Offset = "0x5DE54D0", VA = "0x185DE6ED0")]
	public JMBJGPCOPMP(AddressFamily PCAOKLFDCGG, JAPHANJGOOE MPJGHEIGICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE67C0", Offset = "0x5DE4DC0", VA = "0x185DE67C0", Slot = "8")]
	public bool FNMADGMDHFE(IPEndPoint IMNCPDLCDPB, JCALLMCKBIG BJPJFAJBKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6E90", Offset = "0x5DE5490", VA = "0x185DE6E90", Slot = "9")]
	public int PJABMDFBGFD(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int PPOFLGDKIBE, IPEndPoint LGGOIEACOLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6DA0", Offset = "0x5DE53A0", VA = "0x185DE6DA0", Slot = "10")]
	public int OMINCENCJAB(byte[] KGHDKIBNGIE, EndPoint OLFJLDKEFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6760", Offset = "0x5DE4D60", VA = "0x185DE6760", Slot = "11")]
	public void DMJFHHLPFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface FDFOCDICDKM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short FELCMJCBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int ICPJADHNLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint EEHNCMPDFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily CBLKDIILLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNMADGMDHFE(IPEndPoint IMNCPDLCDPB, JCALLMCKBIG BJPJFAJBKGK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PJABMDFBGFD(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int PPOFLGDKIBE, IPEndPoint LGGOIEACOLK);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OMINCENCJAB(byte[] KGHDKIBNGIE, EndPoint LGGOIEACOLK);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DMJFHHLPFDI();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct ACHGDEGOBFJ : IEquatable<ACHGDEGOBFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long HAPCBCPBFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long JIMEGKIIJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long IIBEIFKDCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int HIOKHFOMNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int DPDIKGKGOKB;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5750", Offset = "0x5DD3D50", VA = "0x185DD5750")]
	public ACHGDEGOBFJ(byte[] JNOIOMLBIAE, int MODCNOKNEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x885C10", Offset = "0x884210", VA = "0x180885C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5660", Offset = "0x5DD3C60", VA = "0x185DD5660", Slot = "4")]
	public bool Equals(ACHGDEGOBFJ OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD56A0", Offset = "0x5DD3CA0", VA = "0x185DD56A0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class KNNEMOFHLMA : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] CEHMMJOGELE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class JBJABOADJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int GPGBFKAKFGA;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
	protected JBJABOADJCG(int EPKCPPBALHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BFCOLELFPAC(IPEndPoint IMNCPDLCDPB, byte[] JHLEMCFOEMF, int LHOLHMCKPEO, int KDDFOIMAIHK);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void HPPEPPHFLFJ(IPEndPoint IMNCPDLCDPB, byte[] JHLEMCFOEMF, int LHOLHMCKPEO, int KDDFOIMAIHK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LCDLCBNGPCF : JBJABOADJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] MNBFPOFIDHA;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator HNLJFOLPHDG;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE330", Offset = "0x1FFC930", VA = "0x181FFE330")]
	public LCDLCBNGPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8E70", Offset = "0x5DE7470", VA = "0x185DE8E70")]
	public void INKBIBMCPNM(IPEndPoint IMNCPDLCDPB, byte[] MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8A30", Offset = "0x5DE7030", VA = "0x185DE8A30")]
	public void CJFDHNMNFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8580", Offset = "0x5DE6B80", VA = "0x185DE8580", Slot = "4")]
	public override void BFCOLELFPAC(IPEndPoint IMNCPDLCDPB, byte[] JHLEMCFOEMF, int LHOLHMCKPEO, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8B10", Offset = "0x5DE7110", VA = "0x185DE8B10", Slot = "5")]
	public override void HPPEPPHFLFJ(IPEndPoint IMNCPDLCDPB, byte[] JHLEMCFOEMF, int LHOLHMCKPEO, int KDDFOIMAIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct JIPJODNPFMM
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void PIGKPLLOPPH([NoAlias] byte* OCGHKJLMPBG, [NoAlias] byte* MNBFPOFIDHA, [NoAlias] byte* CCDKPFKMBPM, int KDDFOIMAIHK);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class EHAAOEBKHEL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr MIFFJIJLGGL;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr PLCLPADFFMG;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC350", Offset = "0x5DEA950", VA = "0x185DEC350")]
		[BurstDiscard]
		private static void AAMBOFCDGOG(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC740", Offset = "0x5DEAD40", VA = "0x185DEC740")]
		private static IntPtr PLBPOOLPNKK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC6A0", Offset = "0x5DEACA0", VA = "0x185DEC6A0")]
		public static void OKBCOMNFGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
		public static void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC470", Offset = "0x5DEAA70", VA = "0x185DEC470")]
		public unsafe static void DFDLGJKGLOI([NoAlias] byte* OCGHKJLMPBG, [NoAlias] byte* MNBFPOFIDHA, [NoAlias] byte* CCDKPFKMBPM, int KDDFOIMAIHK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint MNBFPOFIDHA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint CCDKPFKMBPM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint OGPAEOBKAGA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint JOOELOGMKBJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint DIBFKGOCDBD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint KMBOIDLMFDI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint HNHOPOINDKC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint JIMAGIMHJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint IBKAOBFJDCB[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5F60", Offset = "0x5DE4560", VA = "0x185DE5F60")]
	private void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6630", Offset = "0x5DE4C30", VA = "0x185DE6630")]
	private uint MNFPPGKAIPM(uint ONOKCMNNMGN, int JKNLANGFFGJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DD55B0", Offset = "0x5DD3BB0", VA = "0x185DD55B0")]
	private void JJOJGOKKJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5310", Offset = "0x5DD3910", VA = "0x185DD5310")]
	private void FCAHGJEPKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5520", Offset = "0x5DD3B20", VA = "0x185DD5520")]
	private void IMFFLPHJCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5210", Offset = "0x5DD3810", VA = "0x185DD5210")]
	private void DLKINMLHIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5FE0", Offset = "0x5DE45E0", VA = "0x185DE5FE0")]
	private void IOAAICCMNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE61A0", Offset = "0x5DE47A0", VA = "0x185DE61A0")]
	private unsafe void KMCDAMPFBEB(byte* OCGHKJLMPBG, uint* MNBFPOFIDHA, uint* CCDKPFKMBPM, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6040", Offset = "0x5DE4640", VA = "0x185DE6040")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KHKAAGOBLHJ([NoAlias] byte* OCGHKJLMPBG, [NoAlias] byte* MNBFPOFIDHA, [NoAlias] byte* CCDKPFKMBPM, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE60C0", Offset = "0x5DE46C0", VA = "0x185DE60C0")]
	public static void KHKAAGOBLHJ(Span<byte> OCGHKJLMPBG, Span<byte> MNBFPOFIDHA, Span<byte> CCDKPFKMBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6660", Offset = "0x5DE4C60", VA = "0x185DE6660")]
	public static void PPOJPJPEEIG(Span<byte> OCGHKJLMPBG, Span<byte> MNBFPOFIDHA, Span<byte> CCDKPFKMBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5DE65C0", Offset = "0x5DE4BC0", VA = "0x185DE65C0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LFHKDIGIPFH([NoAlias] byte* OCGHKJLMPBG, [NoAlias] byte* MNBFPOFIDHA, [NoAlias] byte* CCDKPFKMBPM, int KDDFOIMAIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC990", Offset = "0x5DEAF90", VA = "0x185DEC990")]
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
