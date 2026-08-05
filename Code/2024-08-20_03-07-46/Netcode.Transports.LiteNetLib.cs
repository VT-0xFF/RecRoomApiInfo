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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, COKHJMJKDLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum FAOPENLMIJL
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
		private NetworkManager LFEPPALFOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, GNNFPDNOJDE> NMMJKNACAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private PJDKHDDLKCF FDOPOAPPFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] BGMMJMLODCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FAOPENLMIJL NHMBANPLEOH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong AMCBAHHPGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NJBNNOEDLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F590", Offset = "0x5D8E590", VA = "0x185D8F590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EAF0", Offset = "0x5D8DAF0", VA = "0x185D8EAF0")]
		public void RecRoom_SetEncryptionInfo(ulong LGDGODOOFPJ, byte[] GMFCIHEFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EAD0", Offset = "0x5D8DAD0", VA = "0x185D8EAD0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E970", Offset = "0x5D8D970", VA = "0x185D8E970")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F490", Offset = "0x5D8E490", VA = "0x185D8F490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EC90", Offset = "0x5D8DC90", VA = "0x185D8EC90", Slot = "6")]
		public override void Send(ulong AOJMKBHJMCG, ArraySegment<byte> AHGAPHMJDIB, NetworkDelivery MLFDONFPKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EA90", Offset = "0x5D8DA90", VA = "0x185D8EA90", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong AOJMKBHJMCG, [Out] ArraySegment<byte> KLINFCCHIED, [Out] float OCMGDMBPMDA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EF80", Offset = "0x5D8DF80", VA = "0x185D8EF80", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F3B0", Offset = "0x5D8E3B0", VA = "0x185D8F3B0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DF80", Offset = "0x5D8CF80", VA = "0x185D8DF80", Slot = "10")]
		public override void DisconnectRemoteClient(ulong AOJMKBHJMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DE30", Offset = "0x5D8CE30", VA = "0x185D8DE30", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E3C0", Offset = "0x5D8D3C0", VA = "0x185D8E3C0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong AOJMKBHJMCG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EF10", Offset = "0x5D8DF10", VA = "0x185D8EF10", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E460", Offset = "0x5D8D460", VA = "0x185D8E460", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LFEPPALFOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E8A0", Offset = "0x5D8D8A0", VA = "0x185D8E8A0")]
		private AHDJNCAFOKJ MOIAGPCLFAG(NetworkDelivery HNGLFCFOHLI)
		{
			return default(AHDJNCAFOKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E0F0", Offset = "0x5D8D0F0", VA = "0x185D8E0F0", Slot = "15")]
		private void ECOJAPNFLME(GNNFPDNOJDE LCEDCINCAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E700", Offset = "0x5D8D700", VA = "0x185D8E700", Slot = "16")]
		private void MFCHMOCAANH(GNNFPDNOJDE LCEDCINCAFN, BIOAGOPMMAC IDKGJCGMLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "17")]
		private void BEDAPBPAINO(IPEndPoint FFEBFHANJGE, SocketError HHECOIGBGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E1B0", Offset = "0x5D8D1B0", VA = "0x185D8E1B0", Slot = "18")]
		private void FHHDMKKODIJ(GNNFPDNOJDE LCEDCINCAFN, KOBODHBCCMK JBMHGCNDNMN, byte PNAHNGJFNDL, AHDJNCAFOKJ OPNAHJLJDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E620", Offset = "0x5D8D620", VA = "0x185D8E620")]
		private void KFCFMEBCNII(int GHACOABIHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "19")]
		private void PPILHKCMHPC(IPEndPoint OFIACCKOODP, KOBODHBCCMK JBMHGCNDNMN, KKNIICDPAIA FKACLEPPPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "20")]
		private void ELLHINHNIIK(GNNFPDNOJDE LCEDCINCAFN, int KBOPCNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E840", Offset = "0x5D8D840", VA = "0x185D8E840", Slot = "21")]
		private void MJGHECIENHB(LNKHFIBCDEJ HHNBCLDGHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EA60", Offset = "0x5D8DA60", VA = "0x185D8EA60")]
		private ulong PPDJMMGCMBO(GNNFPDNOJDE LCEDCINCAFN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DE10", Offset = "0x5D8CE10", VA = "0x185D8DE10")]
		private static int BPAPKKIAMLJ(float GHCGFNCODKM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F4B0", Offset = "0x5D8E4B0", VA = "0x185D8F4B0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class MKKMDFDFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GNNFPDNOJDE LHAIJLAKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HLFIMAMELCD> GHOJDADBOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int LIMFHLPCALB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FED0", Offset = "0x5D8EED0", VA = "0x185D8FED0")]
	protected MKKMDFDFEIO(GNNFPDNOJDE LCEDCINCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FE30", Offset = "0x5D8EE30", VA = "0x185D8FE30")]
	public void GOPMIOCBNLF(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FDB0", Offset = "0x5D8EDB0", VA = "0x185D8FDB0")]
	protected void AHOJJDDIFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FE90", Offset = "0x5D8EE90", VA = "0x185D8FE90")]
	public bool OANAEEOKHOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool AHNJFKPOAID();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LCEFFBOHKCE(HLFIMAMELCD KGNFHMDHCAG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CJPOKDOOLPB
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
public class LNKHFIBCDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly PJDKHDDLKCF ANLBHEPGAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FDBODHCCJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NEEOBLHIECI NGJFGMJFGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint EOMNFKNMACJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CJPOKDOOLPB PKJIEJGMNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87A110", Offset = "0x879110", VA = "0x18087A110")]
		[CompilerGenerated]
		get
		{
			return default(CJPOKDOOLPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBA6780", Offset = "0xBA5780", VA = "0x180BA6780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DD40", Offset = "0x5D8CD40", VA = "0x185D8DD40")]
	internal void OGLJLCDDCDA(NEEOBLHIECI PFPFKAICEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DD10", Offset = "0x5D8CD10", VA = "0x185D8DD10")]
	private bool FOFBBAHDFJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DDA0", Offset = "0x5D8CDA0", VA = "0x185D8DDA0")]
	internal LNKHFIBCDEJ(IPEndPoint OFIACCKOODP, NEEOBLHIECI EMOOFGDDKPK, PJDKHDDLKCF AMEOOEAAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DCB0", Offset = "0x5D8CCB0", VA = "0x185D8DCB0")]
	public GNNFPDNOJDE DEMJMOJAMCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KKNIICDPAIA
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LILBJGLMEPD
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
public struct BIOAGOPMMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public LILBJGLMEPD OGAALLPGFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BBOAECOMAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KOBODHBCCMK MHPAMMHHJHE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface COKHJMJKDLO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPIFPDJALLH(GNNFPDNOJDE LCEDCINCAFN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNHCJDENMID(GNNFPDNOJDE LCEDCINCAFN, BIOAGOPMMAC IDKGJCGMLHD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJLILACIIOD(IPEndPoint FFEBFHANJGE, SocketError HHECOIGBGFB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KANOHOLMDJI(GNNFPDNOJDE LCEDCINCAFN, KOBODHBCCMK JBMHGCNDNMN, byte PNAHNGJFNDL, AHDJNCAFOKJ OPNAHJLJDIP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKDFOCLELAC(IPEndPoint OFIACCKOODP, KOBODHBCCMK JBMHGCNDNMN, KKNIICDPAIA FKACLEPPPIO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGDAICAOBJC(GNNFPDNOJDE LCEDCINCAFN, int KBOPCNOMMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GCLLPELCCAM(LNKHFIBCDEJ HHNBCLDGHCL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BPEGEHDOMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJLGJBDBDPC(GNNFPDNOJDE LCEDCINCAFN, object KPACPHOFLCO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MOMELMKMBIE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKGPIOFNJHE(MLJBJNENIIK KGNFHMDHCAG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OBNLHGEDPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEMGICADFME(GNNFPDNOJDE LCEDCINCAFN, IPEndPoint ODCFHNMCNBN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NEEOBLHIECI
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NFBDIANGKAD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long BJCOHDCOKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte MOKMHFBJBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] CAIGEADJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly ENAPLDGHBMC KHBLMBBNMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int JGNLONAFIGF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D91760", Offset = "0x5D90760", VA = "0x185D91760")]
	private NEEOBLHIECI(long KPEBFGKGOJM, byte DJCPALCOECM, int BAAPAEECMJF, byte[] OMDLDIMOEAN, ENAPLDGHBMC AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D914E0", Offset = "0x5D904E0", VA = "0x185D914E0")]
	public static int BNAKCDLGBKE(HLFIMAMELCD KGNFHMDHCAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D91540", Offset = "0x5D90540", VA = "0x185D91540")]
	public static NEEOBLHIECI EMGPOKCPICN(HLFIMAMELCD KGNFHMDHCAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D91300", Offset = "0x5D90300", VA = "0x185D91300")]
	public static HLFIMAMELCD AJCNHLKDJCJ(BIJJKECMEEC MMCNJFFCOIL, SocketAddress CEEAJIICMDK, long JJOBGDBAFMG, int BAAPAEECMJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OAHMAAACENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long BJCOHDCOKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte MOKMHFBJBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int JGNLONAFIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool LHANGPLNJMM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D92180", Offset = "0x5D91180", VA = "0x185D92180")]
	private OAHMAAACENB(long KPEBFGKGOJM, byte DJCPALCOECM, int PDDAPGCDMOF, bool NODDHDCEFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D92030", Offset = "0x5D91030", VA = "0x185D92030")]
	public static OAHMAAACENB EMGPOKCPICN(HLFIMAMELCD KGNFHMDHCAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D91E40", Offset = "0x5D90E40", VA = "0x185D91E40")]
	public static HLFIMAMELCD AJCNHLKDJCJ(long JJOBGDBAFMG, byte KGHJLLGMACN, int NCMEIODKKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D91F30", Offset = "0x5D90F30", VA = "0x185D91F30")]
	public static HLFIMAMELCD EIIBECEHPHJ(GNNFPDNOJDE LCEDCINCAFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum APCLIOIDKBA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DMHFGHMMPNP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIDEOECHFIF(IPEndPoint ACOBGJBIINC, IPEndPoint OFIACCKOODP, string DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFDBADLMODI(IPEndPoint FAGFLFNBPKF, APCLIOIDKBA HNGLFCFOHLI, string DJIBMMAIGPE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GPAOABBIDLO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct LFKCDJDICNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint PABAJIMPLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint EOMNFKNMACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string JHMMBMAJEJP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PHADBNNNAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint NNKAGOIDLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public APCLIOIDKBA PNINAMLCHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JHMMBMAJEJP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class LPJGDDEGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint HCBENJFHOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JHMMBMAJEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LPJGDDEGIKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class OGLACCLJDAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint HCBENJFHOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NHIKPEKPNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string JHMMBMAJEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OGLACCLJDAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CHGDAHDCEIF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JHMMBMAJEJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MIOEGHEELPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85AE40", Offset = "0x859E40", VA = "0x18085AE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CHGDAHDCEIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PJDKHDDLKCF NADMIJFHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<LFKCDJDICNO> OHBJFFCJEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<PHADBNNNAKE> IBKGELOFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ENAPLDGHBMC NDMHLOGKIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BIJJKECMEEC OBFEMFAAPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ECALNBIKDAP HIMKGKGEPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DMHFGHMMPNP HDAJNEAEFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int AJGFFFNLPPI = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool ANEMGNHKPEK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BA30", Offset = "0x5D8AA30", VA = "0x185D8BA30")]
	internal GPAOABBIDLO(PJDKHDDLKCF JMJDJIFHNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B8D0", Offset = "0x5D8A8D0", VA = "0x185D8B8D0")]
	internal void NGHABGGKFLK(IPEndPoint NONDLEKHGLJ, HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB740", Offset = "0x2BBA740", VA = "0x182BBB740")]
	private void FFFJPMNGKIK<T>(T KGNFHMDHCAG, IPEndPoint KAEDHDLBKFF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B740", Offset = "0x5D8A740", VA = "0x185D8B740")]
	private void MIDEOECHFIF(LPJGDDEGIKA HBLPEPAPJNH, IPEndPoint NONDLEKHGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B440", Offset = "0x5D8A440", VA = "0x185D8B440")]
	private void FAPBDMKOKJN(OGLACCLJDAF HBLPEPAPJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B5A0", Offset = "0x5D8A5A0", VA = "0x185D8B5A0")]
	private void JOCIAAKMHEI(CHGDAHDCEIF HBLPEPAPJNH, IPEndPoint NONDLEKHGLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum AHDJNCAFOKJ : byte
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
public enum GGKIALDICHE : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PMBFEMKFIEL
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] GBAEFCADMIA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int EOEJFELEEBA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int IHLILOAEOPN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EBGLBKBMKAP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D85740", Offset = "0x5D84740", VA = "0x185D85740")]
	public EBGLBKBMKAP(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HDIAIKMOMKG : EBGLBKBMKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D85740", Offset = "0x5D84740", VA = "0x185D85740")]
	public HDIAIKMOMKG(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EGCKPNIEJKA
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
public interface HNNOFJIPAKN
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOJHCDBPEED(EGCKPNIEJKA ICOALOKNPII, string AFJFNKAODGK, params object[] DJNIHGJAOCO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LKNMKONLCKB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static HNNOFJIPAKN JHGOJHLNJPJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PEMCFNCEFPO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D970", Offset = "0x5D8C970", VA = "0x185D8D970")]
	private static void GJJJBBHIDPI(EGCKPNIEJKA HDKDJOOJJKH, string AFJFNKAODGK, params object[] DJNIHGJAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D910", Offset = "0x5D8C910", VA = "0x185D8D910")]
	internal static void FJHACGBOHBH(string AFJFNKAODGK, params object[] DJNIHGJAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D8B0", Offset = "0x5D8C8B0", VA = "0x185D8D8B0")]
	internal static void FIBPELOKFGO(string AFJFNKAODGK, params object[] DJNIHGJAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DBA0", Offset = "0x5D8CBA0", VA = "0x185D8DBA0")]
	internal static void KCBLHDGOGLN(string AFJFNKAODGK, params object[] DJNIHGJAOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HDCGELEGHHA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KOBODHBCCMK : ENAPLDGHBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HLFIMAMELCD NGHHKHBLGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PJDKHDDLKCF ODMHJMNPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JOKBCGEJMMF PPNDPJCNHPB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D860", Offset = "0x5D8C860", VA = "0x185D8D860")]
	internal KOBODHBCCMK(PJDKHDDLKCF HADKCEDAMNP, JOKBCGEJMMF AAOINKFEEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D7C0", Offset = "0x5D8C7C0", VA = "0x185D8D7C0")]
	internal void HPDIPHCJHBC(HLFIMAMELCD KGNFHMDHCAG, int NKKPHEIGMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D740", Offset = "0x5D8C740", VA = "0x185D8D740")]
	internal void CPFHHLKMBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D830", Offset = "0x5D8C830", VA = "0x185D8D830")]
	public void MEOHEHIILNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JOKBCGEJMMF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum BMMNNJKCAPO
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
	public JOKBCGEJMMF BKINHHIOKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public BMMNNJKCAPO PNINAMLCHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GNNFPDNOJDE LHAIJLAKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint EOMNFKNMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object EPKENPFLOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int HLAJCPCKMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError KBDGPDOLENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public LILBJGLMEPD KBGBHMEIGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public LNKHFIBCDEJ CADAAOCABPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AHDJNCAFOKJ AIDCGPFJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte AHJENBEJBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly KOBODHBCCMK ENPCGJLABJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C970", Offset = "0x5D8B970", VA = "0x185D8C970")]
	public JOKBCGEJMMF(PJDKHDDLKCF HADKCEDAMNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PJDKHDDLKCF : IEnumerable<GNNFPDNOJDE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class JMABGKMNGCI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C900", Offset = "0x5D8B900", VA = "0x185D8C900", Slot = "4")]
		public bool Equals(IPEndPoint PONGAOGJLMF, IPEndPoint FOJLHADHAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58A6000", Offset = "0x58A5000", VA = "0x1858A6000", Slot = "5")]
		public int GetHashCode(IPEndPoint NOPFNIKINJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JMABGKMNGCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct EDEFLDMGPIJ : IEnumerator<GNNFPDNOJDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly GNNFPDNOJDE ANCFFCCOHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GNNFPDNOJDE HHONHCHHDNI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GNNFPDNOJDE NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x99F860", Offset = "0x99E860", VA = "0x18099F860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x11DE130", Offset = "0x11DD130", VA = "0x1811DE130")]
		public EDEFLDMGPIJ(GNNFPDNOJDE GEMGCEDHMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D85B30", Offset = "0x5D84B30", VA = "0x185D85B30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D85B80", Offset = "0x5D84B80", VA = "0x185D85B80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread GIPPIHNECMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool GFAJLAOFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent FPBJGEIALPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JOKBCGEJMMF> FHDGGDLMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JOKBCGEJMMF> PDNOMADBGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JOKBCGEJMMF PPPLJPOMGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly COKHJMJKDLO NMLOOLFABEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly BPEGEHDOMDB BAPFJMJGMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MOMELMKMBIE HNDKNCMCAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OBNLHGEDPDI DKNLBFIICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, GNNFPDNOJDE> LOKNNOOLIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, LNKHFIBCDEJ> PNPMPODPKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, NKICKLNOFAM> GPNJLJPGJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim KPHHANFJKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GNNFPDNOJDE PKKGPIDHFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GJMEFFHEFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<GNNFPDNOJDE> NCEJOEJIPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GNNFPDNOJDE[] JNBMCGOOMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AGLGGEGCKDI PDKKGPFCKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int KDLMLBLEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> KNMDDBKIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte FGCPPBPLKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object IBIANHACPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool GBEFPBJNCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool POJJKJAMJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NCLNJNOPIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HEADNMEILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LNIPJIAMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int FGDADONBBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool LEJMEHFOFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool KEKIJOECOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int PAJNKNHBNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CIELGPKBBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int FIOBLNMOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool ANEMGNHKPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool PCGDPIHBIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool OEPMGJCMAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool GJMMPBCBCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int IGDAGFPMMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int FJBFCOPNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool MOFJNLHKPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly MBDEEFDHFGM CFJGCECKANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool OKCNIGGKENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly GPAOABBIDLO GFKFGEAJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LFDMBPMICMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public HDCGELEGHHA GKPMNEBGEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int EDOFBADGAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool FAOGCHDJOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FDKELAIMCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool MFDLPBNMHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BBGFJCLGIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HLFIMAMELCD JOIEIGKFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int HHJDFKJELME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object PHFFKOGHBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HLFIMAMELCD CHDPEDOIOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MLCFOKKHJIF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int OCKMGNBEPCF = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int NIIEOLDOJCL = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private MIBPPPMCIME MPODOPMMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private MIBPPPMCIME EAKJFFOOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread HHJAFPBALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread DFNPOENOBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint FCJPGAFLPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint JIEMNJLNFGK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] KAJHKLCCILN;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] HPFKLAPHCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<GLABKGOJCKJ, IPEndPoint> BAMCGNFBDKO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress GODFJGHELFI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool LGLIJGPKJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int NADFNECJPON;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BBOOGOEKLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCB5290", Offset = "0xCB4290", VA = "0x180CB5290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD85A20", Offset = "0xD84A20", VA = "0x180D85A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MPCOAOOADLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15E30A0", Offset = "0x15E20A0", VA = "0x1815E30A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1916A90", Offset = "0x1915A90", VA = "0x181916A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ACHOFEIGJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB1A2C0", Offset = "0xB192C0", VA = "0x180B1A2C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JHMNBAHPFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D94980", Offset = "0x5D93980", VA = "0x185D94980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short AJBJHIFLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D952F0", Offset = "0x5D942F0", VA = "0x185D952F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D988A0", Offset = "0x5D978A0", VA = "0x185D988A0")]
	public void ODPPEOHDNEB(IPEndPoint FFEBFHANJGE, byte[] GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D98360", Offset = "0x5D97360", VA = "0x185D98360")]
	public void LMLHPLMMMPA(IPEndPoint FFEBFHANJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D948F0", Offset = "0x5D938F0", VA = "0x185D948F0")]
	private bool EPKFECHHION(IPEndPoint FFEBFHANJGE, [Out] GNNFPDNOJDE LCEDCINCAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D980A0", Offset = "0x5D970A0", VA = "0x185D980A0")]
	private void LMEDHKLIGFP(GNNFPDNOJDE LCEDCINCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D93A80", Offset = "0x5D92A80", VA = "0x185D93A80")]
	private void EGIJENGFHDL(GNNFPDNOJDE LCEDCINCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D97A00", Offset = "0x5D96A00", VA = "0x185D97A00")]
	private void LCPBDICBNPM(GNNFPDNOJDE LCEDCINCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D98D70", Offset = "0x5D97D70", VA = "0x185D98D70")]
	public PJDKHDDLKCF(COKHJMJKDLO AMEOOEAAAOE, [Optional] AGLGGEGCKDI KNCMLPBGOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D92DA0", Offset = "0x5D91DA0", VA = "0x185D92DA0")]
	internal void BLGOHHFKJDL(GNNFPDNOJDE KCIKLMPGLJB, int KBOPCNOMMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D98B40", Offset = "0x5D97B40", VA = "0x185D98B40")]
	internal void PLKIGIKGJOF(GNNFPDNOJDE KCIKLMPGLJB, object KPACPHOFLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D987D0", Offset = "0x5D977D0", VA = "0x185D987D0")]
	internal void NBCPBLNLIOG(GNNFPDNOJDE LCEDCINCAFN, LILBJGLMEPD JMFILHLKOGK, SocketError GKAALDGOHLK, HLFIMAMELCD AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D97140", Offset = "0x5D96140", VA = "0x185D97140")]
	private void JKCKMKGOLEL(GNNFPDNOJDE LCEDCINCAFN, LILBJGLMEPD JMFILHLKOGK, SocketError GKAALDGOHLK, bool HPJKELEMMFE, byte[] AHGAPHMJDIB, int KKONFBKDDLI, int DOPPKGNLPAC, HLFIMAMELCD AOIHJKDLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D93130", Offset = "0x5D92130", VA = "0x185D93130")]
	private void CBPHIGEKGCG(JOKBCGEJMMF.BMMNNJKCAPO HNGLFCFOHLI, [Optional] GNNFPDNOJDE LCEDCINCAFN, [Optional] IPEndPoint OFIACCKOODP, SocketError CMBMLLGKBPM = SocketError.Success, int KBOPCNOMMMJ = 0, LILBJGLMEPD INLIINBGJOE = LILBJGLMEPD.ConnectionFailed, [Optional] LNKHFIBCDEJ BLOGDFECAKN, AHDJNCAFOKJ OPNAHJLJDIP = AHDJNCAFOKJ.Unreliable, byte PNAHNGJFNDL = 0, [Optional] HLFIMAMELCD IFIIJNAIABP, [Optional] object KPACPHOFLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D96550", Offset = "0x5D95550", VA = "0x185D96550")]
	private void JGMOHPCINKC(JOKBCGEJMMF AAOINKFEEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D97900", Offset = "0x5D96900", VA = "0x185D97900")]
	internal void KFONGGIANKE(JOKBCGEJMMF AAOINKFEEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D92DF0", Offset = "0x5D91DF0", VA = "0x185D92DF0")]
	private void BODNPMLIJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D984B0", Offset = "0x5D974B0", VA = "0x185D984B0")]
	private void MKNCFNNBCLL(int LCIMKFMJEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D953B0", Offset = "0x5D943B0", VA = "0x185D953B0")]
	internal GNNFPDNOJDE GLFBMODCIFD(LNKHFIBCDEJ HHNBCLDGHCL, byte[] NHCCCMAADHF, int KKONFBKDDLI, int IGIHBEMLMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D98AC0", Offset = "0x5D97AC0", VA = "0x185D98AC0")]
	private int PDBGEEHBEJF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D972D0", Offset = "0x5D962D0", VA = "0x185D972D0")]
	private void JLPDFANLBBA(IPEndPoint OFIACCKOODP, GNNFPDNOJDE HGPEBGJJDOD, NEEOBLHIECI CEJEJGEJDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D93B30", Offset = "0x5D92B30", VA = "0x185D93B30")]
	private void EPFFLDPGFPD(HLFIMAMELCD KGNFHMDHCAG, IPEndPoint OFIACCKOODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D959D0", Offset = "0x5D949D0", VA = "0x185D959D0")]
	internal void GNBELBGOBIO(HLFIMAMELCD KGNFHMDHCAG, AHDJNCAFOKJ BDBPCDDLHPE, byte PNAHNGJFNDL, int NKKPHEIGMLD, GNNFPDNOJDE KCIKLMPGLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D925C0", Offset = "0x5D915C0", VA = "0x185D925C0")]
	public bool BHMAKOOBFHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D92D80", Offset = "0x5D91D80", VA = "0x185D92D80")]
	public bool BHMAKOOBFHF(IPAddress OJEIAJOHJLD, IPAddress BPEIEOFBNPG, int APLBJFAIJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D92540", Offset = "0x5D91540", VA = "0x185D92540")]
	public bool BHMAKOOBFHF(int APLBJFAIJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D949A0", Offset = "0x5D939A0", VA = "0x185D949A0")]
	public void FHAFHOPIDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D939A0", Offset = "0x5D929A0", VA = "0x185D939A0")]
	public GNNFPDNOJDE CHEILNIPNIB(string JPMKJCMAIBB, int APLBJFAIJKB, string GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D938C0", Offset = "0x5D928C0", VA = "0x185D938C0")]
	public GNNFPDNOJDE CHEILNIPNIB(string JPMKJCMAIBB, int APLBJFAIJKB, BIJJKECMEEC MGIJGGOGEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D934F0", Offset = "0x5D924F0", VA = "0x185D934F0")]
	public GNNFPDNOJDE CHEILNIPNIB(IPEndPoint KAEDHDLBKFF, BIJJKECMEEC MGIJGGOGEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D96D20", Offset = "0x5D95D20", VA = "0x185D96D20")]
	public void JIGALPPIBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D96D30", Offset = "0x5D95D30", VA = "0x185D96D30")]
	public void JIGALPPIBNO(bool BFFLDEELOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D97C50", Offset = "0x5D96C50", VA = "0x185D97C50")]
	public void LEGJMCBLNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D97D50", Offset = "0x5D96D50", VA = "0x185D97D50")]
	public void LEGJMCBLNAN(byte[] AHGAPHMJDIB, int KKONFBKDDLI, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D97220", Offset = "0x5D96220", VA = "0x185D97220")]
	public void JKCKMKGOLEL(GNNFPDNOJDE LCEDCINCAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D97080", Offset = "0x5D96080", VA = "0x185D97080")]
	public void JKCKMKGOLEL(GNNFPDNOJDE LCEDCINCAFN, byte[] AHGAPHMJDIB, int KKONFBKDDLI, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D98B90", Offset = "0x5D97B90", VA = "0x185D98B90", Slot = "4")]
	private IEnumerator<GNNFPDNOJDE> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D98C20", Offset = "0x5D97C20", VA = "0x185D98C20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D97810", Offset = "0x5D96810", VA = "0x185D97810")]
	private HLFIMAMELCD JPAPENCNFCC(FJHIAEOCIBB HNKKKCPLLDH, int GHACOABIHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D97730", Offset = "0x5D96730", VA = "0x185D97730")]
	private HLFIMAMELCD JPAPENCNFCC(FJHIAEOCIBB HNKKKCPLLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D97E70", Offset = "0x5D96E70", VA = "0x185D97E70")]
	internal HLFIMAMELCD LEPFONINLGK(int GHACOABIHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D962F0", Offset = "0x5D952F0", VA = "0x185D962F0")]
	internal void IMJOKMGLGGI(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D98CB0", Offset = "0x5D97CB0", VA = "0x185D98CB0")]
	static PJDKHDDLKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCB5290", Offset = "0xCB4290", VA = "0x180CB5290")]
	private bool LEDIDDIHCAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D92450", Offset = "0x5D91450", VA = "0x185D92450")]
	private void AMECJPBPIOB(IPEndPoint NNFJDJGJNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D92370", Offset = "0x5D91370", VA = "0x185D92370")]
	private void AJKAALMOEOC(IPEndPoint NNFJDJGJNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D921D0", Offset = "0x5D911D0", VA = "0x185D921D0")]
	private bool ADHJKJAGKBM(SocketException APIEMOLNMPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D96020", Offset = "0x5D95020", VA = "0x185D96020")]
	private void IDLKGFBLCDA(MIBPPPMCIME JMJDJIFHNCD, EndPoint PCIBGBHJPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D95C90", Offset = "0x5D94C90", VA = "0x185D95C90")]
	private void HAOMEAGCIDG(object JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D925D0", Offset = "0x5D915D0", VA = "0x185D925D0")]
	public bool BHMAKOOBFHF(IPAddress OJEIAJOHJLD, IPAddress BPEIEOFBNPG, int APLBJFAIJKB, bool IKCGIONNFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D93AD0", Offset = "0x5D92AD0", VA = "0x185D93AD0")]
	internal int EHLFCCCCMFA(HLFIMAMELCD KGNFHMDHCAG, IPEndPoint OFIACCKOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D94B40", Offset = "0x5D93B40", VA = "0x185D94B40")]
	internal int FJPMFPGGAOE(HLFIMAMELCD KGNFHMDHCAG, IPEndPoint OFIACCKOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D94B80", Offset = "0x5D93B80", VA = "0x185D94B80")]
	internal int FJPMFPGGAOE(byte[] KKHEHGHPOAA, int KKONFBKDDLI, int IGIHBEMLMOK, IPEndPoint OFIACCKOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D95180", Offset = "0x5D94180", VA = "0x185D95180")]
	internal void FKLDDMMMGIH(bool OCDJLDHKOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FJHIAEOCIBB : byte
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
internal sealed class HLFIMAMELCD
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int AFOCIEGEMIK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] PMKNNLJIFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] KIGIDCFMOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int ODOBBFBPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object EPKENPFLOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HLFIMAMELCD BKINHHIOKAO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FJHIAEOCIBB EINHPALGPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C320", Offset = "0x5D8B320", VA = "0x185D8C320")]
		get
		{
			return default(FJHIAEOCIBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C2B0", Offset = "0x5D8B2B0", VA = "0x185D8C2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MOKMHFBJBGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C350", Offset = "0x5D8B350", VA = "0x185D8C350")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C0B0", Offset = "0x5D8B0B0", VA = "0x185D8C0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort ONOOEPMFCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BF10", Offset = "0x5D8AF10", VA = "0x185D8BF10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C3C0", Offset = "0x5D8B3C0", VA = "0x185D8C3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KFFGECOKGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BE80", Offset = "0x5D8AE80", VA = "0x185D8BE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte OLJOKECHGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C0F0", Offset = "0x5D8B0F0", VA = "0x185D8C0F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C2F0", Offset = "0x5D8B2F0", VA = "0x185D8C2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort PPMOJLDBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BEB0", Offset = "0x5D8AEB0", VA = "0x185D8BEB0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C380", Offset = "0x5D8B380", VA = "0x185D8C380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort BMBGJGOJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C120", Offset = "0x5D8B120", VA = "0x185D8C120")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BF70", Offset = "0x5D8AF70", VA = "0x185D8BF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort OEPBCMBEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C400", Offset = "0x5D8B400", VA = "0x185D8C400")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C460", Offset = "0x5D8B460", VA = "0x185D8C460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C4A0", Offset = "0x5D8B4A0", VA = "0x185D8C4A0")]
	static HLFIMAMELCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C180", Offset = "0x5D8B180", VA = "0x185D8C180")]
	public void HNOBMHACANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C890", Offset = "0x5D8B890", VA = "0x185D8C890")]
	public HLFIMAMELCD(int GHACOABIHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C780", Offset = "0x5D8B780", VA = "0x185D8C780")]
	public HLFIMAMELCD(FJHIAEOCIBB HNKKKCPLLDH, int GHACOABIHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C1B0", Offset = "0x5D8B1B0", VA = "0x185D8C1B0")]
	public static int HOHHOIHNKFP(FJHIAEOCIBB HNKKKCPLLDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C220", Offset = "0x5D8B220", VA = "0x185D8C220")]
	public int HOHHOIHNKFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BFB0", Offset = "0x5D8AFB0", VA = "0x185D8BFB0")]
	public bool DNIELPKCFME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum HKDDNGFNMBH : byte
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
internal enum JABCFGKOJJD
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
internal enum JEDKHNMOHDD
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum LKJPIPGPJAA
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GNNFPDNOJDE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class PCNIDIGMNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HLFIMAMELCD[] FOLLIFPMNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JKJJAABMDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int CELLEHDDAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte OLJOKECHGJL;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PCNIDIGMNOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void CFPMNOPNMAD(ulong BHBPDNFKPKH, int MAMFPJOGOEB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CBPEDIAMOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int EBDNMFIMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int JPIFDEEDALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double OHLPDPGJGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int JEMNCJEMPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int NHJLPMCBEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int DOLLEPFOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch PENCBEODPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int JHMOBGLAIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long KCGNHPEECLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object FINJODBBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal GNNFPDNOJDE PIKDEFIBPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal GNNFPDNOJDE HIINEFJAEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HLFIMAMELCD> KINLFDBENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<MKKMDFDFEIO> AHCKACPKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MKKMDFDFEIO[] JGBBEFGJNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int HMFNIMFICOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int FGHHKLCJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool MKEIEHMDACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int MCOIEODFICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HCBFGMMFAHI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int KCCJAANDOPP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int FBKMNNJLJOH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object NNMIJJBBNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int BMLJMOHENKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, PCNIDIGMNOG> AOPKANOCFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> EGPHBDOKFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HLFIMAMELCD AALIPBGOPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GGHGGKOEMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int JKPFNMBOCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint CHIJKEFBACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NDGCLPLADKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KHPEOKNEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long OFAKJLJPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BFPGCCAGJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private HKDDNGFNMBH NEJNGFBMHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HLFIMAMELCD MNPHJOGLDOM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int JPGHHIFPICE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EJLPGMFJPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HLFIMAMELCD CFAJOHBGMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HLFIMAMELCD BAABGEOJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HLFIMAMELCD PHACBMCIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HLFIMAMELCD AFNIMHPGNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private GGKIALDICHE JGOICOCLNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly PJDKHDDLKCF BELOEILBHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int BJDAIFPCLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object IJFEOFLCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly MBDEEFDHFGM CFJGCECKANC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte GKOBBNBJLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x98F1F0", Offset = "0x98E1F0", VA = "0x18098F1F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D89370", Offset = "0x5D88370", VA = "0x185D89370")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ICHENGJHJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x998240", Offset = "0x997240", VA = "0x180998240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HKDDNGFNMBH JLEGECDFBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1421960", Offset = "0x1420960", VA = "0x181421960")]
		get
		{
			return default(HKDDNGFNMBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long DMAELLCALDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85D2E0", Offset = "0x85C2E0", VA = "0x18085D2E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HGMFCAKMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xDC8BC0", Offset = "0xDC7BC0", VA = "0x180DC8BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x16D06E0", Offset = "0x16CF6E0", VA = "0x1816D06E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CNEPOGPJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D88830", Offset = "0x5D87830", VA = "0x185D88830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BDMPHDOODEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x861470", Offset = "0x860470", VA = "0x180861470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BMKGAAKKDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DC40", Offset = "0x1B6CC40", VA = "0x181B6DC40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CFPMNOPNMAD NFMBBLMDKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D89B20", Offset = "0x5D88B20", VA = "0x185D89B20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D88840", Offset = "0x5D87840", VA = "0x185D88840")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D8AE50", Offset = "0x5D89E50", VA = "0x185D8AE50")]
	internal GNNFPDNOJDE(PJDKHDDLKCF ADMDPLMCGED, IPEndPoint OFIACCKOODP, int KHLDDJPHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D895E0", Offset = "0x5D885E0", VA = "0x185D895E0")]
	internal void JPAHIOHDDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D872B0", Offset = "0x5D862B0", VA = "0x185D872B0")]
	internal void DBIEEAHBINL(IPEndPoint POLGOMOBFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D8ABE0", Offset = "0x5D89BE0", VA = "0x185D8ABE0")]
	internal void PIOGNNOJKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D87640", Offset = "0x5D86640", VA = "0x185D87640")]
	private void EGNFFFPDAHG(int LDJIACFIMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D8AB60", Offset = "0x5D89B60", VA = "0x185D8AB60")]
	private void MAFOJHIPINI(int GMIEAFPAILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D89910", Offset = "0x5D88910", VA = "0x185D89910")]
	private MKKMDFDFEIO KDCIOPPGLOB(byte NHKHFGOJKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B2B0", Offset = "0x5D8A2B0", VA = "0x185D8B2B0")]
	internal GNNFPDNOJDE(PJDKHDDLKCF ADMDPLMCGED, IPEndPoint OFIACCKOODP, int KHLDDJPHOBA, byte KGHJLLGMACN, BIJJKECMEEC MMCNJFFCOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D8AC70", Offset = "0x5D89C70", VA = "0x185D8AC70")]
	internal GNNFPDNOJDE(PJDKHDDLKCF ADMDPLMCGED, LNKHFIBCDEJ HHNBCLDGHCL, int KHLDDJPHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D887E0", Offset = "0x5D877E0", VA = "0x185D887E0")]
	internal void HBBAHHKIMDP(NEEOBLHIECI IOIFAAENCNM, byte[] AHGAPHMJDIB, int KKONFBKDDLI, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D87F50", Offset = "0x5D86F50", VA = "0x185D87F50")]
	internal bool FOMCHOIJLCL(OAHMAAACENB KGNFHMDHCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D87F20", Offset = "0x5D86F20", VA = "0x185D87F20")]
	public void FFFJPMNGKIK(byte[] AHGAPHMJDIB, int KKONFBKDDLI, int IGIHBEMLMOK, AHDJNCAFOKJ OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D86710", VA = "0x185D87710")]
	private void FBABILCGEHD(byte[] AHGAPHMJDIB, int KKONFBKDDLI, int IGIHBEMLMOK, byte PNAHNGJFNDL, AHDJNCAFOKJ OPNAHJLJDIP, object KPACPHOFLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D87200", Offset = "0x5D86200", VA = "0x185D87200")]
	public void CGMCPKIJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D89290", Offset = "0x5D88290", VA = "0x185D89290")]
	internal JEDKHNMOHDD JBGNIFGONAC(HLFIMAMELCD KGNFHMDHCAG)
	{
		return default(JEDKHNMOHDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D89AC0", Offset = "0x5D88AC0", VA = "0x185D89AC0")]
	internal void KDFDPEDJGPL(MKKMDFDFEIO KCGMPLKNLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D89600", Offset = "0x5D88600", VA = "0x185D89600")]
	internal LKJPIPGPJAA KAICENFOACA(byte[] AHGAPHMJDIB, int KKONFBKDDLI, int IGIHBEMLMOK, bool HPJKELEMMFE)
	{
		return default(LKJPIPGPJAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D8ABA0", Offset = "0x5D89BA0", VA = "0x185D8ABA0")]
	private void NMOFHHNNABB(int FEGNHNPFBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D888F0", Offset = "0x5D878F0", VA = "0x185D888F0")]
	internal void IOLEHCBGOEJ(AHDJNCAFOKJ BDBPCDDLHPE, HLFIMAMELCD GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A280", Offset = "0x5D89280", VA = "0x185D8A280")]
	private void LHBKOIPNKJG(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A7E0", Offset = "0x5D897E0", VA = "0x185D8A7E0")]
	private void LKKKACOMDIE(int HEGNCBOIFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D89420", Offset = "0x5D88420", VA = "0x185D89420")]
	internal JABCFGKOJJD JLPDFANLBBA(NEEOBLHIECI CEJEJGEJDLG)
	{
		return default(JABCFGKOJJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D89BD0", Offset = "0x5D88BD0", VA = "0x185D89BD0")]
	internal void LCEFFBOHKCE(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D874F0", Offset = "0x5D864F0", VA = "0x185D874F0")]
	private void DIHHALMFNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D872E0", Offset = "0x5D862E0", VA = "0x185D872E0")]
	internal void DGFHJIJGGDI(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D87FD0", Offset = "0x5D86FD0", VA = "0x185D87FD0")]
	internal void GACAEOGENLN(int HEGNCBOIFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D87C60", Offset = "0x5D86C60", VA = "0x185D87C60")]
	internal void FCOMDAFHHIA(HLFIMAMELCD KGNFHMDHCAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MBDEEFDHFGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KMOMOPJJCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long PHHKEFMCHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long FIODNMDMDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HLIIPFACFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long BNBOJOFFMFI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long BFIGGLDENKG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long BIHNKCFBNPM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long EFDPCLKPFPG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long MKBCBKBHEFI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long BKAPCPFKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long BEFFMAIICCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CDINOKFNNEI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long OIHPJIDCGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F720", Offset = "0x5D8E720", VA = "0x185D8F720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long OEDENFGMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F9D0", Offset = "0x5D8E9D0", VA = "0x185D8F9D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long IKFGNCHBADN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F9E0", Offset = "0x5D8E9E0", VA = "0x185D8F9E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KHLMEONALDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F9F0", Offset = "0x5D8E9F0", VA = "0x185D8F9F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BENNHKIIDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F790", Offset = "0x5D8E790", VA = "0x185D8F790")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long AGLOABGBONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F710", Offset = "0x5D8E710", VA = "0x185D8F710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long JPGGAIANALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F8C0", Offset = "0x5D8E8C0", VA = "0x185D8F8C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long BOJKOKFFAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FA10", Offset = "0x5D8EA10", VA = "0x185D8FA10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private GGKIALDICHE FKLELBAIOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FA00", Offset = "0x5D8EA00", VA = "0x185D8FA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double JEKLNBHMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F860", Offset = "0x5D8E860", VA = "0x185D8F860")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F6D0", Offset = "0x5D8E6D0", VA = "0x185D8F6D0")]
	public void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F730", Offset = "0x5D8E730", VA = "0x185D8F730")]
	public void FLHFKHDKFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F7A0", Offset = "0x5D8E7A0", VA = "0x185D8F7A0")]
	public void GFHEMCOPAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F900", Offset = "0x5D8E900", VA = "0x185D8F900")]
	public void KGEJLPPOLKL(long OMGNCDHOEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F7F0", Offset = "0x5D8E7F0", VA = "0x185D8F7F0")]
	public void IJIHCMOLHDO(long LDIAKMAJCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F970", Offset = "0x5D8E970", VA = "0x185D8F970")]
	public void KNDGGFHOJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F650", Offset = "0x5D8E650", VA = "0x185D8F650")]
	public void BPGDNIAJDAH(long HICIFGAOEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FA50", Offset = "0x5D8EA50", VA = "0x185D8FA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F5B0", Offset = "0x5D8E5B0", VA = "0x185D8F5B0")]
	public void AFIDDFBNNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public MBDEEFDHFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NHDGGCABJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> CCADMDCGOGO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D917D0", Offset = "0x5D907D0", VA = "0x185D917D0")]
	public static IPEndPoint ADFANNOMFOI(string OMJBGEFEOKF, int APLBJFAIJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D91AE0", Offset = "0x5D90AE0", VA = "0x185D91AE0")]
	public static IPAddress EEFMHDAHICN(string OMJBGEFEOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D91A50", Offset = "0x5D90A50", VA = "0x185D91A50")]
	public static IPAddress EEFMHDAHICN(string OMJBGEFEOKF, AddressFamily EKFBCCBBEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D91A20", Offset = "0x5D90A20", VA = "0x185D91A20")]
	internal static int BNFIKNNDIDJ(int HGOHGDFONHC, int OEAJJMJNJLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A6E0", Offset = "0x2D096E0", VA = "0x182D0A6E0")]
	internal static T[] DJDOJCCKLCC<T>(int DOPPKGNLPAC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ACKEEDMHIOE : MKKMDFDFEIO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KMHENKGLBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private HLFIMAMELCD NGHHKHBLGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long DGAJEAONHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool BCAICOIMGGH;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D6A0", Offset = "0x5D8C6A0", VA = "0x185D8D6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D5C0", Offset = "0x5D8C5C0", VA = "0x185D8D5C0")]
		public void BEDHOPCKIAC(HLFIMAMELCD KGNFHMDHCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D5E0", Offset = "0x5D8C5E0", VA = "0x185D8D5E0")]
		public bool JFJIEBAAPNH(long JAKDMONMIBD, GNNFPDNOJDE LCEDCINCAFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D650", Offset = "0x5D8C650", VA = "0x185D8D650")]
		public bool PKAGCAPLLKG(GNNFPDNOJDE LCEDCINCAFN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly HLFIMAMELCD OKDILILNDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly KMHENKGLBNP[] KGOFHPPEFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly HLFIMAMELCD[] OOKMKOAIJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] OPLJIPDABAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int IKJIFOEAFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int BPDFFMFDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int NIKGHNMHCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int KJKCNBJDLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool ALGMEPHCNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly AHDJNCAFOKJ ECHDHCAOHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool LACAAOEODEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int PEJGNEJNAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte ICDGBMIJOEG;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D845C0", Offset = "0x5D835C0", VA = "0x185D845C0")]
	public ACKEEDMHIOE(GNNFPDNOJDE LCEDCINCAFN, bool NPJHCKKLEJP, byte KHLDDJPHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D83BC0", Offset = "0x5D82BC0", VA = "0x185D83BC0")]
	private void CJEPMNPKBOC(HLFIMAMELCD KGNFHMDHCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D83710", Offset = "0x5D82710", VA = "0x185D83710", Slot = "4")]
	protected override bool AHNJFKPOAID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D83F60", Offset = "0x5D82F60", VA = "0x185D83F60", Slot = "5")]
	public override bool LCEFFBOHKCE(HLFIMAMELCD KGNFHMDHCAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PNCEKIEOPLH : MKKMDFDFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int PKGAHDJEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort BPDFFMFDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool JCLCBJJJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private HLFIMAMELCD BJKFEENIJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly HLFIMAMELCD PIAIBDJHFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool NGLEAIGGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte ICDGBMIJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long DBHOOCOOFIN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D99C40", Offset = "0x5D98C40", VA = "0x185D99C40")]
	public PNCEKIEOPLH(GNNFPDNOJDE LCEDCINCAFN, bool LCBJLMJCCGL, byte KHLDDJPHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5D994A0", Offset = "0x5D984A0", VA = "0x185D994A0", Slot = "4")]
	protected override bool AHNJFKPOAID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D99960", Offset = "0x5D98960", VA = "0x185D99960", Slot = "5")]
	public override bool LCEFFBOHKCE(HLFIMAMELCD KGNFHMDHCAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AFAFPAIHBGM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MBEAGJKHFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong CMFINEBCOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double LFHEIJMNHAJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct LMDOEEEGPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int AEKFNDAPOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float MNPPACOEING;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D82910", Offset = "0x5D81910", VA = "0x185D82910")]
	private static void DHKFOJHDEBK(byte[] EPDCHNAKJIF, int BEMLKOBANDO, ulong AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D847D0", Offset = "0x5D837D0", VA = "0x185D847D0")]
	private static void DHKFOJHDEBK(byte[] EPDCHNAKJIF, int BEMLKOBANDO, int AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D84790", Offset = "0x5D83790", VA = "0x185D84790")]
	public static void DHKFOJHDEBK(byte[] EPDCHNAKJIF, int BEMLKOBANDO, short AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D84840", Offset = "0x5D83840", VA = "0x185D84840")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, double JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D84870", Offset = "0x5D83870", VA = "0x185D84870")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D84790", Offset = "0x5D83790", VA = "0x185D84790")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, short JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D84790", Offset = "0x5D83790", VA = "0x185D84790")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, ushort JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D847D0", Offset = "0x5D837D0", VA = "0x185D847D0")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D847D0", Offset = "0x5D837D0", VA = "0x185D847D0")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, uint JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D84860", Offset = "0x5D83860", VA = "0x185D84860")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5D84860", Offset = "0x5D83860", VA = "0x185D84860")]
	public static void HKGCONOJLCM(byte[] KABOAHAAMFF, int EFHNBALPFBO, ulong JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ENAPLDGHBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] IKBIPBFMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int FBKOFOENDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int PKMIFAKENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int DFACGJMPMOD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] KIGIDCFMOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HEMIKHNMFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LLLKGNHAFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D85E30", Offset = "0x5D84E30", VA = "0x185D85E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BAOGKPFOOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F09A50", Offset = "0x1F08A50", VA = "0x181F09A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int KAEPIEEPDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5D85DB0", Offset = "0x5D84DB0", VA = "0x185D85DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D85F50", Offset = "0x5D84F50", VA = "0x185D85F50")]
	public void HPDIPHCJHBC(byte[] IEJOAHLDAPK, int BEMLKOBANDO, int AKPDKEMJBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ENAPLDGHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D867C0", Offset = "0x5D857C0", VA = "0x185D867C0")]
	public ENAPLDGHBMC(byte[] IEJOAHLDAPK, int BEMLKOBANDO, int AKPDKEMJBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D85E80", Offset = "0x5D84E80", VA = "0x185D85E80")]
	public IPEndPoint HJOKHINIMCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5D861F0", Offset = "0x5D851F0", VA = "0x185D861F0")]
	public byte KGMDKEAMKAF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D861F0", Offset = "0x5D851F0", VA = "0x185D861F0")]
	public sbyte KEIMJNFLCLC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A41760", Offset = "0x2A40760", VA = "0x182A41760")]
	public T[] GJGGAAMIBPK<T>(ushort GHACOABIHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D86390", Offset = "0x5D85390", VA = "0x185D86390")]
	public bool[] LONKHOHBEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D86440", Offset = "0x5D85440", VA = "0x185D86440")]
	public ushort[] MNPGIHGBOKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D85CC0", Offset = "0x5D84CC0", VA = "0x185D85CC0")]
	public short[] EGONOJODEFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D86040", Offset = "0x5D85040", VA = "0x185D86040")]
	public int[] JFEJMJIEIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D85BD0", Offset = "0x5D84BD0", VA = "0x185D85BD0")]
	public uint[] BFHNMCJCIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D861B0", Offset = "0x5D851B0", VA = "0x185D861B0")]
	public float[] JPDNFINBGKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D86000", Offset = "0x5D85000", VA = "0x185D86000")]
	public double[] IPBGFCNCOOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D862E0", Offset = "0x5D852E0", VA = "0x185D862E0")]
	public long[] LLIAHAKBJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D86230", Offset = "0x5D85230", VA = "0x185D86230")]
	public ulong[] KNBJCFLKOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D86080", Offset = "0x5D85080", VA = "0x185D86080")]
	public string[] JLFKPFNBJOG(int EPMJNDFBGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D85D00", Offset = "0x5D84D00", VA = "0x185D85D00")]
	public bool EJGANMEBEAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D86270", Offset = "0x5D85270", VA = "0x185D86270")]
	public char LNLJKIHDIMI()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D86270", Offset = "0x5D85270", VA = "0x185D86270")]
	public ushort LJAGEBLNJBN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D85C50", Offset = "0x5D84C50", VA = "0x185D85C50")]
	public short DLFPKBNCBAK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D85F90", Offset = "0x5D84F90", VA = "0x185D85F90")]
	public long IFLGNEGJKOI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D863D0", Offset = "0x5D853D0", VA = "0x185D863D0")]
	public ulong MNGKBPCJMCA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D85DC0", Offset = "0x5D84DC0", VA = "0x185D85DC0")]
	public int GAAPCCBOLEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D86320", Offset = "0x5D85320", VA = "0x185D86320")]
	public uint LOJJKPABPEB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D86730", Offset = "0x5D85730", VA = "0x185D86730")]
	public float OLCIBHFCCCK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D86480", Offset = "0x5D85480", VA = "0x185D86480")]
	public double NNHOKCBKMNM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D864F0", Offset = "0x5D854F0", VA = "0x185D864F0")]
	public string OBIFGHCIBHP(int BEFMODGHLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D85D40", Offset = "0x5D84D40", VA = "0x185D85D40")]
	public ArraySegment<byte> FFHFMECBBMN(int DOPPKGNLPAC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D85C10", Offset = "0x5D84C10", VA = "0x185D85C10")]
	public sbyte[] DGEKMFMBBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D85E40", Offset = "0x5D84E40", VA = "0x185D85E40")]
	public byte[] GONOJOINHLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5D867A0", Offset = "0x5D857A0", VA = "0x185D867A0")]
	public void PKAGCAPLLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BIJJKECMEEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] IKBIPBFMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FBKOFOENDAB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int ALBBEILPNCP = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool CEODODCHMNC;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding ONBALILLGJN;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int BAKFCMCELDF = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] NCMAAKNAGLE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] KHBLMBBNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D85620", Offset = "0x5D84620", VA = "0x185D85620")]
	public BIJJKECMEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D856A0", Offset = "0x5D846A0", VA = "0x185D856A0")]
	public BIJJKECMEEC(bool DONPEIMLHOF, int HLLGDBCIONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5D85030", Offset = "0x5D84030", VA = "0x185D85030")]
	public static BIJJKECMEEC FDHJLEHJGNO(string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D850A0", Offset = "0x5D840A0", VA = "0x185D850A0")]
	public void GBFANBKJPBF(int NPCJGJBLMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1F83270", Offset = "0x1F82270", VA = "0x181F83270")]
	public void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D84B30", Offset = "0x5D83B30", VA = "0x185D84B30")]
	public void BMBAJFDCAFE(float JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D84BD0", Offset = "0x5D83BD0", VA = "0x185D84BD0")]
	public void BMBAJFDCAFE(double JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F70", Offset = "0x5D83F70", VA = "0x185D84F70")]
	public void BMBAJFDCAFE(long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F70", Offset = "0x5D83F70", VA = "0x185D84F70")]
	public void BMBAJFDCAFE(ulong JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D849D0", Offset = "0x5D839D0", VA = "0x185D849D0")]
	public void BMBAJFDCAFE(int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D849D0", Offset = "0x5D839D0", VA = "0x185D849D0")]
	public void BMBAJFDCAFE(uint JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F00", Offset = "0x5D83F00", VA = "0x185D84F00")]
	public void BMBAJFDCAFE(char JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F00", Offset = "0x5D83F00", VA = "0x185D84F00")]
	public void BMBAJFDCAFE(ushort JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F00", Offset = "0x5D83F00", VA = "0x185D84F00")]
	public void BMBAJFDCAFE(short JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D84C30", Offset = "0x5D83C30", VA = "0x185D84C30")]
	public void BMBAJFDCAFE(sbyte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D84C30", Offset = "0x5D83C30", VA = "0x185D84C30")]
	public void BMBAJFDCAFE(byte JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D84FC0", Offset = "0x5D83FC0", VA = "0x185D84FC0")]
	public void BMBAJFDCAFE(byte[] AHGAPHMJDIB, int BEMLKOBANDO, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D848F0", Offset = "0x5D838F0", VA = "0x185D848F0")]
	public void EILPMBCJHDE(sbyte[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D848F0", Offset = "0x5D838F0", VA = "0x185D848F0")]
	public void ANCJHCCJNFE(byte[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D84EA0", Offset = "0x5D83EA0", VA = "0x185D84EA0")]
	public void BMBAJFDCAFE(bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D854B0", Offset = "0x5D844B0", VA = "0x185D854B0")]
	public void KAFMKJMDGDH(Array NPJKGHONCPP, int MNLOMLMHLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D85220", Offset = "0x5D84220", VA = "0x185D85220")]
	public void KAFMKJMDGDH(float[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D853D0", Offset = "0x5D843D0", VA = "0x185D853D0")]
	public void KAFMKJMDGDH(double[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D853D0", Offset = "0x5D843D0", VA = "0x185D853D0")]
	public void KAFMKJMDGDH(long[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D853D0", Offset = "0x5D843D0", VA = "0x185D853D0")]
	public void KAFMKJMDGDH(ulong[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D85220", Offset = "0x5D84220", VA = "0x185D85220")]
	public void KAFMKJMDGDH(int[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D85220", Offset = "0x5D84220", VA = "0x185D85220")]
	public void KAFMKJMDGDH(uint[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D85140", Offset = "0x5D84140", VA = "0x185D85140")]
	public void KAFMKJMDGDH(ushort[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D85140", Offset = "0x5D84140", VA = "0x185D85140")]
	public void KAFMKJMDGDH(short[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D848F0", Offset = "0x5D838F0", VA = "0x185D848F0")]
	public void KAFMKJMDGDH(bool[] JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D85300", Offset = "0x5D84300", VA = "0x185D85300")]
	public void KAFMKJMDGDH(string[] JJCEIJMGOAB, int IFIBIOGPOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D84A60", Offset = "0x5D83A60", VA = "0x185D84A60")]
	public void BMBAJFDCAFE(IPEndPoint FFEBFHANJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D84C20", Offset = "0x5D83C20", VA = "0x185D84C20")]
	public void BMBAJFDCAFE(string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D84C90", Offset = "0x5D83C90", VA = "0x185D84C90")]
	public void BMBAJFDCAFE(string JJCEIJMGOAB, int BEFMODGHLMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ECALNBIKDAP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class GPMDKIENNGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong BJDAIFPCLMA;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3D9A020", Offset = "0x3D99020", VA = "0x183D9A020")]
		static GPMDKIENNGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void EADECNAMGGO(ENAPLDGHBMC JBMHGCNDNMN, object KPACPHOFLCO);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PNEPHMDKEOJ<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public ECALNBIKDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PNEPHMDKEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47C6550", Offset = "0x47C5550", VA = "0x1847C6550")]
		internal void ALGMPGLPAND(ENAPLDGHBMC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NNJKDGOKAJM<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public ECALNBIKDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NNJKDGOKAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x46037D0", Offset = "0x46027D0", VA = "0x1846037D0")]
		internal void ALGMPGLPAND(ENAPLDGHBMC reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly KJLPDECCBAO MHGMJJLDOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, EADECNAMGGO> MBCGHNJOMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly BIJJKECMEEC NDCEGMKJBOB;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D85950", Offset = "0x5D84950", VA = "0x185D85950")]
	public ECALNBIKDAP(int EPMJNDFBGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x29302E0", Offset = "0x292F2E0", VA = "0x1829302E0", Slot = "4")]
	protected virtual ulong LFEMKGOKFBB<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D85820", Offset = "0x5D84820", VA = "0x185D85820", Slot = "5")]
	protected virtual EADECNAMGGO POKNMDOLEGA(ENAPLDGHBMC JBMHGCNDNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A31450", Offset = "0x2A30450", VA = "0x182A31450", Slot = "6")]
	protected virtual void BFNKCADGLPF<T>(BIJJKECMEEC KOHNEKCBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D85750", Offset = "0x5D84750", VA = "0x185D85750")]
	public void CEAJIJKBDDO(ENAPLDGHBMC JBMHGCNDNMN, object KPACPHOFLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A314C0", Offset = "0x2A304C0", VA = "0x182A314C0")]
	public void GJJFJNBFMKE<T>(BIJJKECMEEC KOHNEKCBPBH, T KGNFHMDHCAG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5D857D0", Offset = "0x5D847D0", VA = "0x185D857D0")]
	public void OMJDPFCGKLA(ENAPLDGHBMC JBMHGCNDNMN, object KPACPHOFLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2A31720", Offset = "0x2A30720", VA = "0x182A31720")]
	public void LCFOCGBLAHA<T>(Action<T> PIJNIIMMPMA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2A31570", Offset = "0x2A30570", VA = "0x182A31570")]
	public void LCFOCGBLAHA<T, TUserData>(Action<T, TUserData> PIJNIIMMPMA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DJCEEKOLDGB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5D85740", Offset = "0x5D84740", VA = "0x185D85740")]
	public DJCEEKOLDGB(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EDECPGLHNKO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D85AD0", Offset = "0x5D84AD0", VA = "0x185D85AD0")]
	public EDECPGLHNKO(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class KJLPDECCBAO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum AJPIHJGIEIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BCFALFLBGMO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AJPIHJGIEIL PNINAMLCHFD;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4E73770", Offset = "0x4E72770", VA = "0x184E73770", Slot = "4")]
		public virtual void BEDHOPCKIAC(MethodInfo IBAKHPLOEHB, MethodInfo EEGALMONHBG, AJPIHJGIEIL HNGLFCFOHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GMNGGMPOKON(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JCOJAEMBFAB(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		protected BCFALFLBGMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class IHFPHMFCDFC<TClass, TProperty> : BCFALFLBGMO<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> AGJBLPFOEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> KPCIJJIKOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> OKJDAMJDPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> JGPEABPECJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> IMKOGLNLIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> BHFNHKECLFH;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F32720", Offset = "0x3F31720", VA = "0x183F32720", Slot = "7")]
		public override void MOKGHBHGGOI(TClass KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EB00", Offset = "0x3F2DB00", VA = "0x183F2EB00", Slot = "8")]
		public override void AFCKNMEDEHD(TClass KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F31960", Offset = "0x3F30960", VA = "0x183F31960", Slot = "9")]
		public override void GMNGGMPOKON(TClass KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F322A0", Offset = "0x3F312A0", VA = "0x183F322A0", Slot = "10")]
		public override void JCOJAEMBFAB(TClass KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F32460", Offset = "0x3F31460", VA = "0x183F32460")]
		protected TProperty[] JFLALGLCAEE(TClass KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F31DC0", Offset = "0x3F30DC0", VA = "0x183F31DC0")]
		protected TProperty[] IIJJDLMMDKB(TClass KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F30C60", Offset = "0x3F2FC60", VA = "0x183F30C60", Slot = "4")]
		public override void BEDHOPCKIAC(MethodInfo IBAKHPLOEHB, MethodInfo EEGALMONHBG, AJPIHJGIEIL HNGLFCFOHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3D22760", Offset = "0x3D21760", VA = "0x183D22760")]
		protected IHFPHMFCDFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class OEHIPOKGKFG<TClass, TProperty> : IHFPHMFCDFC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KPHIEMAEOJN(ENAPLDGHBMC IELHIIDGIMN, [Out] TProperty MBADFNLOLBF);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void NKHBMPBCHPK(BIJJKECMEEC EPJGIIKPLND, TProperty MBADFNLOLBF);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x46E13B0", Offset = "0x46E03B0", VA = "0x1846E13B0", Slot = "5")]
		public override void MIPAHJGEBFN(TClass KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x46E1210", Offset = "0x46E0210", VA = "0x1846E1210", Slot = "6")]
		public override void GJJFJNBFMKE(TClass KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x46E1510", Offset = "0x46E0510", VA = "0x1846E1510", Slot = "7")]
		public override void MOKGHBHGGOI(TClass KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x46E1150", Offset = "0x46E0150", VA = "0x1846E1150", Slot = "8")]
		public override void AFCKNMEDEHD(TClass KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FD80", Offset = "0x3F4ED80", VA = "0x183F4FD80")]
		protected OEHIPOKGKFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class ICHOBLJPKKK<T> : IHFPHMFCDFC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7BD0", Offset = "0x3EB6BD0", VA = "0x183EB7BD0", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAD90", Offset = "0x3DC9D90", VA = "0x183DCAD90", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7C50", Offset = "0x3EB6C50", VA = "0x183EB7C50", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C2F0", Offset = "0x3C8B2F0", VA = "0x183C8C2F0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public ICHOBLJPKKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HFFGBIEJHJK<T> : IHFPHMFCDFC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAE00", Offset = "0x3DC9E00", VA = "0x183DCAE00", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAD90", Offset = "0x3DC9D90", VA = "0x183DCAD90", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAE80", Offset = "0x3DC9E80", VA = "0x183DCAE80", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C2F0", Offset = "0x3C8B2F0", VA = "0x183C8C2F0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public HFFGBIEJHJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class NMLLDHJNCLM<T> : IHFPHMFCDFC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4601D60", Offset = "0x4600D60", VA = "0x184601D60", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3D33140", Offset = "0x3D32140", VA = "0x183D33140", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4601DE0", Offset = "0x4600DE0", VA = "0x184601DE0", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3D330D0", Offset = "0x3D320D0", VA = "0x183D330D0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public NMLLDHJNCLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class GAHINLNDKJF<T> : IHFPHMFCDFC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D331B0", Offset = "0x3D321B0", VA = "0x183D331B0", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3D33140", Offset = "0x3D32140", VA = "0x183D33140", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3D33230", Offset = "0x3D32230", VA = "0x183D33230", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D330D0", Offset = "0x3D320D0", VA = "0x183D330D0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public GAHINLNDKJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class ODGIJBOHAAD<T> : IHFPHMFCDFC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x46DCC30", Offset = "0x46DBC30", VA = "0x1846DCC30", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x46DCBC0", Offset = "0x46DBBC0", VA = "0x1846DCBC0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x46DCCB0", Offset = "0x46DBCB0", VA = "0x1846DCCB0", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x41182C0", Offset = "0x41172C0", VA = "0x1841182C0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public ODGIJBOHAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OPAKLCEFCJD<T> : IHFPHMFCDFC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4701D50", Offset = "0x4700D50", VA = "0x184701D50", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x46DCBC0", Offset = "0x46DBBC0", VA = "0x1846DCBC0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4701DD0", Offset = "0x4700DD0", VA = "0x184701DD0", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x41182C0", Offset = "0x41172C0", VA = "0x1841182C0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public OPAKLCEFCJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PJJPOJJDFLN<T> : IHFPHMFCDFC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x389CB10", Offset = "0x389BB10", VA = "0x18389CB10", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x389CAA0", Offset = "0x389BAA0", VA = "0x18389CAA0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x47AA5F0", Offset = "0x47A95F0", VA = "0x1847AA5F0", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x389CA30", Offset = "0x389BA30", VA = "0x18389CA30", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public PJJPOJJDFLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EIBFBMEHJCM<T> : IHFPHMFCDFC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x389CB10", Offset = "0x389BB10", VA = "0x18389CB10", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x389CAA0", Offset = "0x389BAA0", VA = "0x18389CAA0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x389CB90", Offset = "0x389BB90", VA = "0x18389CB90", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x389CA30", Offset = "0x389BA30", VA = "0x18389CA30", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public EIBFBMEHJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FNCIOJPIEFB<T> : IHFPHMFCDFC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C3D0", Offset = "0x3C8B3D0", VA = "0x183C8C3D0", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C360", Offset = "0x3C8B360", VA = "0x183C8C360", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C450", Offset = "0x3C8B450", VA = "0x183C8C450", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C2F0", Offset = "0x3C8B2F0", VA = "0x183C8C2F0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public FNCIOJPIEFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class JLIKJGPDNCI<T> : IHFPHMFCDFC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x41183A0", Offset = "0x41173A0", VA = "0x1841183A0", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4118330", Offset = "0x4117330", VA = "0x184118330", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4118420", Offset = "0x4117420", VA = "0x184118420", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x41182C0", Offset = "0x41172C0", VA = "0x1841182C0", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public JLIKJGPDNCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KIAGHKDPNJJ<T> : IHFPHMFCDFC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x421C680", Offset = "0x421B680", VA = "0x18421C680", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x421C610", Offset = "0x421B610", VA = "0x18421C610", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x421C700", Offset = "0x421B700", VA = "0x18421C700", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x389CA30", Offset = "0x389BA30", VA = "0x18389CA30", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x389CC10", Offset = "0x389BC10", VA = "0x18389CC10")]
		public KIAGHKDPNJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KLCOMCCIFGM<T> : OEHIPOKGKFG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x424B8A0", Offset = "0x424A8A0", VA = "0x18424B8A0", Slot = "12")]
		protected override void NKHBMPBCHPK(BIJJKECMEEC EPJGIIKPLND, char MBADFNLOLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x424B870", Offset = "0x424A870", VA = "0x18424B870", Slot = "11")]
		protected override void KPHIEMAEOJN(ENAPLDGHBMC IELHIIDGIMN, [Out] char MBADFNLOLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BC50", Offset = "0x3D1AC50", VA = "0x183D1BC50")]
		public KLCOMCCIFGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KABKPGDIEGH<T> : OEHIPOKGKFG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x41BB650", Offset = "0x41BA650", VA = "0x1841BB650", Slot = "12")]
		protected override void NKHBMPBCHPK(BIJJKECMEEC EPJGIIKPLND, IPEndPoint MBADFNLOLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x41BB610", Offset = "0x41BA610", VA = "0x1841BB610", Slot = "11")]
		protected override void KPHIEMAEOJN(ENAPLDGHBMC IELHIIDGIMN, [Out] IPEndPoint MBADFNLOLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BC50", Offset = "0x3D1AC50", VA = "0x183D1BC50")]
		public KABKPGDIEGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NAJCAOLBJFI<T> : IHFPHMFCDFC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int JMEBAMBCKEM;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x45D0280", Offset = "0x45CF280", VA = "0x1845D0280")]
		public NAJCAOLBJFI(int BEFMODGHLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x45D0180", Offset = "0x45CF180", VA = "0x1845D0180", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x45D0100", Offset = "0x45CF100", VA = "0x1845D0100", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x45D0200", Offset = "0x45CF200", VA = "0x1845D0200", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x45D0080", Offset = "0x45CF080", VA = "0x1845D0080", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HOIJNILEPII<T> : BCFALFLBGMO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo EINHPALGPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type OBKIIJDEALE;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFED30", Offset = "0x3DFDD30", VA = "0x183DFED30")]
		public HOIJNILEPII(PropertyInfo HNKKKCPLLDH, Type MHLDANHKOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEC10", Offset = "0x3DFDC10", VA = "0x183DFEC10", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEAA0", Offset = "0x3DFDAA0", VA = "0x183DFEAA0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFECD0", Offset = "0x3DFDCD0", VA = "0x183DFECD0", Slot = "7")]
		public override void MOKGHBHGGOI(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEA40", Offset = "0x3DFDA40", VA = "0x183DFEA40", Slot = "8")]
		public override void AFCKNMEDEHD(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEB50", Offset = "0x3DFDB50", VA = "0x183DFEB50", Slot = "9")]
		public override void GMNGGMPOKON(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEBB0", Offset = "0x3DFDBB0", VA = "0x183DFEBB0", Slot = "10")]
		public override void JCOJAEMBFAB(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BHMHBHCBKCO<T> : HOIJNILEPII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
		public BHMHBHCBKCO(PropertyInfo HNKKKCPLLDH, Type MHLDANHKOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E900A0", Offset = "0x4E8F0A0", VA = "0x184E900A0", Slot = "5")]
		public override void MIPAHJGEBFN(T KBIDOOLLLPO, ENAPLDGHBMC IELHIIDGIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FFF0", Offset = "0x4E8EFF0", VA = "0x184E8FFF0", Slot = "6")]
		public override void GJJFJNBFMKE(T KBIDOOLLLPO, BIJJKECMEEC EPJGIIKPLND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class FPIHLAIKFCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static FPIHLAIKFCO<T> PNNELGGLBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly BCFALFLBGMO<T>[] PFCCBNFLIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int KCHFDEDOOCG;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E9A0", Offset = "0x3C9D9A0", VA = "0x183C9E9A0")]
		public FPIHLAIKFCO(List<BCFALFLBGMO<T>> JIBEFAKCFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E840", Offset = "0x3C9D840", VA = "0x183C9E840")]
		public void GJJFJNBFMKE(T NOPFNIKINJA, BIJJKECMEEC KOHNEKCBPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E8F0", Offset = "0x3C9D8F0", VA = "0x183C9E8F0")]
		public void MIPAHJGEBFN(T NOPFNIKINJA, ENAPLDGHBMC JBMHGCNDNMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class IHFELPMEKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BCFALFLBGMO<T> MKHPGHPCCLG<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private BIJJKECMEEC ODAFHLGGONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int PAHLGBLFACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, IHFELPMEKLG> LBKBGELOLGE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D520", Offset = "0x5D8C520", VA = "0x185D8D520")]
	public KJLPDECCBAO(int EPMJNDFBGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C722C0", Offset = "0x2C712C0", VA = "0x182C722C0")]
	private FPIHLAIKFCO<T> LCLIDKAIKAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x298BBC0", Offset = "0x298ABC0", VA = "0x18298BBC0")]
	public void GGLLICMBJNI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2C733D0", Offset = "0x2C723D0", VA = "0x182C733D0")]
	public bool PPFECFLIGJE<T>(ENAPLDGHBMC JBMHGCNDNMN, T KAEDHDLBKFF) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2C72230", Offset = "0x2C71230", VA = "0x182C72230")]
	public void JMNIMAIKKED<T>(BIJJKECMEEC KOHNEKCBPBH, T NOPFNIKINJA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MLJBJNENIIK
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime IOOIIGKMBAK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] FHMKJFFONJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public POAONIOGGPO GODBLGHHNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D904D0", Offset = "0x5D8F4D0", VA = "0x185D904D0")]
		get
		{
			return default(POAONIOGGPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IJOGIGDFKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D90180", Offset = "0x5D8F180", VA = "0x185D90180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D90500", Offset = "0x5D8F500", VA = "0x185D90500")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IBKHFFPILCM AAHOPFOMJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D90540", Offset = "0x5D8F540", VA = "0x185D90540")]
		get
		{
			return default(IBKHFFPILCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D900E0", Offset = "0x5D8F0E0", VA = "0x185D900E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JNNJMHDMFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D900B0", Offset = "0x5D8F0B0", VA = "0x185D900B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint HGDPOHMOPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D90030", Offset = "0x5D8F030", VA = "0x185D90030")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? DCLDADKMAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D90C10", Offset = "0x5D8FC10", VA = "0x185D90C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? GNEMDHBNLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D90570", Offset = "0x5D8F570", VA = "0x185D90570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? EHJHJCLOHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D904A0", Offset = "0x5D8F4A0", VA = "0x185D904A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D90670", Offset = "0x5D8F670", VA = "0x185D90670")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? PNJMIAGJPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xB5FC50", Offset = "0xB5EC50", VA = "0x180B5FC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D90FE0", Offset = "0x5D8FFE0", VA = "0x185D90FE0")]
	public MLJBJNENIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D90F30", Offset = "0x5D8FF30", VA = "0x185D90F30")]
	internal MLJBJNENIIK(byte[] KABOAHAAMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D90380", Offset = "0x5D8F380", VA = "0x185D90380")]
	public static MLJBJNENIIK FLJPFFGMDOO(byte[] KABOAHAAMFF, DateTime KFGJPBNJBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D90A10", Offset = "0x5D8FA10", VA = "0x185D90A10")]
	internal void LJKPLOLOIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D90840", Offset = "0x5D8F840", VA = "0x185D90840")]
	private void LCKDGBJBFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D90CD0", Offset = "0x5D8FCD0", VA = "0x185D90CD0")]
	private DateTime? ONDJNGBFCJE(int BEMLKOBANDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D901B0", Offset = "0x5D8F1B0", VA = "0x185D901B0")]
	private void CFHLMBNHADI(int BEMLKOBANDO, DateTime? JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D905A0", Offset = "0x5D8F5A0", VA = "0x185D905A0")]
	private ulong KCPNMMAJOIJ(int BEMLKOBANDO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D8FF70", Offset = "0x5D8EF70", VA = "0x185D8FF70")]
	private void AHHEFFBBHDE(int BEMLKOBANDO, ulong JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D90C40", Offset = "0x5D8FC40", VA = "0x185D90C40")]
	private uint NFNPCGJNPEE(int BEMLKOBANDO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5C56DF0", Offset = "0x5C55DF0", VA = "0x185C56DF0")]
	private static uint BIFFJJBCCCM(uint PONGAOGJLMF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D90120", Offset = "0x5D8F120", VA = "0x185D90120")]
	private static ulong BIFFJJBCCCM(ulong PONGAOGJLMF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum POAONIOGGPO
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
public enum IBKHFFPILCM
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NKICKLNOFAM
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int GMFINOPFDGC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int DCGIDPNIGPC = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int LIFOBMNNGKA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint FCLAKDNLOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int MJEHIGDBNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int BFMMFEEOCKL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool APKPMOPIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D91E30", Offset = "0x5D90E30", VA = "0x185D91E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D91D40", Offset = "0x5D90D40", VA = "0x185D91D40")]
	public bool FFFJPMNGKIK(MIBPPPMCIME JMJDJIFHNCD, int PJONDALPKNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class AABDILAGBGN : MIBPPPMCIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket JMJDJIFHNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly PJDKHDDLKCF ADMDPLMCGED;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short AJBJHIFLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D834F0", Offset = "0x5D824F0", VA = "0x185D834F0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FMIPICMAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D83530", Offset = "0x5D82530", VA = "0x185D83530", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint PABAJIMPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D83510", Offset = "0x5D82510", VA = "0x185D83510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily NIKOFFENIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x42AB920", Offset = "0x42AA920", VA = "0x1842AB920", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D83660", Offset = "0x5D82660", VA = "0x185D83660")]
	public AABDILAGBGN(AddressFamily EKFBCCBBEDB, PJDKHDDLKCF ADMDPLMCGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D82F30", Offset = "0x5D81F30", VA = "0x185D82F30", Slot = "8")]
	public bool ELJBBJPHKKO(IPEndPoint FFEBFHANJGE, HDCGELEGHHA KPBDLKHMGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D82EF0", Offset = "0x5D81EF0", VA = "0x185D82EF0", Slot = "9")]
	public int EHNJKPJDKBD(byte[] EPDCHNAKJIF, int BEMLKOBANDO, int GHACOABIHDA, IPEndPoint OFIACCKOODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D83570", Offset = "0x5D82570", VA = "0x185D83570", Slot = "10")]
	public int MFOJGLPJLBJ(byte[] EPDCHNAKJIF, EndPoint CDGCBMPLODP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D83550", Offset = "0x5D82550", VA = "0x185D83550", Slot = "11")]
	public void LCIALDHMACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface MIBPPPMCIME
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short AJBJHIFLAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int FMIPICMAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint PABAJIMPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily NIKOFFENIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ELJBBJPHKKO(IPEndPoint FFEBFHANJGE, HDCGELEGHHA KPBDLKHMGAI);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int EHNJKPJDKBD(byte[] EPDCHNAKJIF, int BEMLKOBANDO, int GHACOABIHDA, IPEndPoint OFIACCKOODP);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MFOJGLPJLBJ(byte[] EPDCHNAKJIF, EndPoint OFIACCKOODP);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCIALDHMACE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct GLABKGOJCKJ : IEquatable<GLABKGOJCKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long PEOAEIKAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long KPBJFOEBJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long BEEDCCJEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int DLMGDDIHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int ACFGFBJOGEF;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D87110", Offset = "0x5D86110", VA = "0x185D87110")]
	public GLABKGOJCKJ(byte[] JPMKJCMAIBB, int DJCEKFCICKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x87A110", Offset = "0x879110", VA = "0x18087A110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5D870D0", Offset = "0x5D860D0", VA = "0x185D870D0", Slot = "4")]
	public bool Equals(GLABKGOJCKJ ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5D87020", Offset = "0x5D86020", VA = "0x185D87020", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CEKIHADMGPA : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] GLJLLDBLPGE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class AGLGGEGCKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int JHMNBAHPFPF;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
	protected AGLGGEGCKDI(int FFJDDADEBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KNJHLJDJHBJ(IPEndPoint FFEBFHANJGE, byte[] AHGAPHMJDIB, int BEMLKOBANDO, int IGIHBEMLMOK);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LDGBKAACLLA(IPEndPoint FFEBFHANJGE, byte[] AHGAPHMJDIB, int BEMLKOBANDO, int IGIHBEMLMOK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KHNNCLKDLMC : AGLGGEGCKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] GMFCIHEFPPO;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator HMALOOMJNJF;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2023AB0", Offset = "0x2022AB0", VA = "0x182023AB0")]
	public KHNNCLKDLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CAF0", Offset = "0x5D8BAF0", VA = "0x185D8CAF0")]
	public void CAFEDAFDKJL(IPEndPoint FFEBFHANJGE, byte[] GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CA10", Offset = "0x5D8BA10", VA = "0x185D8CA10")]
	public void BCNNMGHOMCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CCA0", Offset = "0x5D8BCA0", VA = "0x185D8CCA0", Slot = "4")]
	public override void KNJHLJDJHBJ(IPEndPoint FFEBFHANJGE, byte[] AHGAPHMJDIB, int BEMLKOBANDO, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D150", Offset = "0x5D8C150", VA = "0x185D8D150", Slot = "5")]
	public override void LDGBKAACLLA(IPEndPoint FFEBFHANJGE, byte[] AHGAPHMJDIB, int BEMLKOBANDO, int IGIHBEMLMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct GGDDMAAPEPG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void AGJCPFJAOOJ([NoAlias] byte* GEHKMBDLDLH, [NoAlias] byte* GMFCIHEFPPO, [NoAlias] byte* DGLDNCOBOBF, int IGIHBEMLMOK);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NCDIAIJIEJL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A250", Offset = "0x5D99250", VA = "0x185D9A250")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5D99E00", Offset = "0x5D98E00", VA = "0x185D99E00")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A1A0", Offset = "0x5D991A0", VA = "0x185D9A1A0")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5D99F60", Offset = "0x5D98F60", VA = "0x185D99F60")]
		public unsafe static void GHKHNOGELCE([NoAlias] byte* GEHKMBDLDLH, [NoAlias] byte* GMFCIHEFPPO, [NoAlias] byte* DGLDNCOBOBF, int IGIHBEMLMOK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint GMFCIHEFPPO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint DGLDNCOBOBF[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint INCJJNLFKPK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint AIEAOFGEGID[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint MNNDOBJDOOE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint EPFHAJFMBKH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint OMENEKNGBAA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint NKJCMLNLCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint LBMGJIJOKFL[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D86820", Offset = "0x5D85820", VA = "0x185D86820")]
	private void CLDDABPDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D86A60", Offset = "0x5D85A60", VA = "0x185D86A60")]
	private uint IBFBMNEBPBM(uint CKOKPBDJPNC, int GOEMJHAJDMM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D82D40", Offset = "0x5D81D40", VA = "0x185D82D40")]
	private void GMGAJFDGEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D82B30", Offset = "0x5D81B30", VA = "0x185D82B30")]
	private void ENDPEHLIHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D82AA0", Offset = "0x5D81AA0", VA = "0x185D82AA0")]
	private void DAPDDNGFGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5D82DF0", Offset = "0x5D81DF0", VA = "0x185D82DF0")]
	private void OIOEOAFFPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D86A00", Offset = "0x5D85A00", VA = "0x185D86A00")]
	private void GMEBJAKIFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D86B00", Offset = "0x5D85B00", VA = "0x185D86B00")]
	private unsafe void MFIMMGLHLLK(byte* GEHKMBDLDLH, uint* GMFCIHEFPPO, uint* DGLDNCOBOBF, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D868A0", Offset = "0x5D858A0", VA = "0x185D868A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void EKPBIIFIKCA([NoAlias] byte* GEHKMBDLDLH, [NoAlias] byte* GMFCIHEFPPO, [NoAlias] byte* DGLDNCOBOBF, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D86920", Offset = "0x5D85920", VA = "0x185D86920")]
	public static void EKPBIIFIKCA(Span<byte> GEHKMBDLDLH, Span<byte> GMFCIHEFPPO, Span<byte> DGLDNCOBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5D86F20", Offset = "0x5D85F20", VA = "0x185D86F20")]
	public static void NJKCOGLFOHM(Span<byte> GEHKMBDLDLH, Span<byte> GMFCIHEFPPO, Span<byte> DGLDNCOBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5D86A90", Offset = "0x5D85A90", VA = "0x185D86A90")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KIAJBABCDFG([NoAlias] byte* GEHKMBDLDLH, [NoAlias] byte* GMFCIHEFPPO, [NoAlias] byte* DGLDNCOBOBF, int IGIHBEMLMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5D9A380", Offset = "0x5D99380", VA = "0x185D9A380")]
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
