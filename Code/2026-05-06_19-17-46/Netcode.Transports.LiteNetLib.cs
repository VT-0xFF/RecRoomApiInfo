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
using AOT;
using Cpp2IlInjected;
using LiteNetLib;
using LiteNetLib.Layers;
using LiteNetLib.Sockets;
using LiteNetLib.Utils;
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BWFQPONRQPS
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HostType
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Client
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Tooltip("The port to listen on (if server) or connect to (if client)")]
		public ushort Port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("The address to connect to as client; ignored if server")]
		public string Address;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Tooltip("Interval between ping packets used for detecting latency and checking connection, in seconds")]
		public float PingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Tooltip("Maximum duration for a connection to survive without receiving packets, in seconds")]
		public float DisconnectTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Delay between connection attempts, in seconds")]
		public float ReconnectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Tooltip("Maximum connection attempts before client stops and reports a disconnection")]
		public int MaxConnectAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Tooltip("Size of default buffer for decoding incoming packets, in bytes")]
		public int MessageBufferSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Tooltip("Simulated chance for a packet to be \"lost\", from 0 (no simulation) to 100 percent")]
		public int SimulatePacketLossChance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Tooltip("Simulated minimum additional latency for packets in milliseconds (0 for no simulation)")]
		public int SimulateMinLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Tooltip("Simulated maximum additional latency for packets in milliseconds (0 for no simulation")]
		public int SimulateMaxLatency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NetworkManager LFPLYOXASJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool DVNLKLYJBEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, IUKCYHJIYJD> JJOOYDSYBQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CCTOFGXGRWY KHMWNRBLVUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch ILKUXJIKIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] PYHLFOZDOZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType RQLUWQFJHOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LZJLSQMBODS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A9E0", Offset = "0x8A693E0", VA = "0x188A6A9E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A990", Offset = "0x8A69390", VA = "0x188A6A990", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F00", Offset = "0x8A68900", VA = "0x188A69F00")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A69EE0", Offset = "0x8A688E0", VA = "0x188A69EE0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A69D60", Offset = "0x8A68760", VA = "0x188A69D60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A8A0", Offset = "0x8A692A0", VA = "0x188A6A8A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A070", Offset = "0x8A68A70", VA = "0x188A6A070", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A69EA0", Offset = "0x8A688A0", VA = "0x188A69EA0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A340", Offset = "0x8A68D40", VA = "0x188A6A340", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A680", Offset = "0x8A69080", VA = "0x188A6A680", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A695B0", Offset = "0x8A67FB0", VA = "0x188A695B0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A694C0", Offset = "0x8A67EC0", VA = "0x188A694C0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A697C0", Offset = "0x8A681C0", VA = "0x188A697C0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A2D0", Offset = "0x8A68CD0", VA = "0x188A6A2D0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A69860", Offset = "0x8A68260", VA = "0x188A69860", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A693F0", Offset = "0x8A67DF0", VA = "0x188A693F0")]
		private DeliveryMethod ATYVWBZURPL(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A69330", Offset = "0x8A67D30", VA = "0x188A69330", Slot = "16")]
		private void AKYLNKATVRQ(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A696F0", Offset = "0x8A680F0", VA = "0x188A696F0", Slot = "17")]
		private void FHQHQTNWNXW(IUKCYHJIYJD a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "18")]
		private void XVVCOLQVKVR(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A69B40", Offset = "0x8A68540", VA = "0x188A69B40", Slot = "19")]
		private void LAIVKDILSFG(IUKCYHJIYJD a, BDATYCOHOFE b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A69A70", Offset = "0x8A68470", VA = "0x188A69A70")]
		private void KJVSEXTTWVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "20")]
		private void QQFTFNEQVSW(IPEndPoint a, BDATYCOHOFE b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
		private void IKFNGGAHJKS(IUKCYHJIYJD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A010", Offset = "0x8A68A10", VA = "0x188A6A010", Slot = "22")]
		private void SGMALFTNEDG(HWKZXQUYVED a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A69E70", Offset = "0x8A68870", VA = "0x188A69E70")]
		private ulong PPSRCQCJASL(IUKCYHJIYJD a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A69E50", Offset = "0x8A68850", VA = "0x188A69E50")]
		private ulong PPSRCQCJASL(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A69D40", Offset = "0x8A68740", VA = "0x188A69D40")]
		private static int NMIARPTVLYE(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A8C0", Offset = "0x8A692C0", VA = "0x188A6A8C0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A696C0", Offset = "0x8A680C0", VA = "0x188A696C0")]
		[CompilerGenerated]
		private void EREPQPNBYFW(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A696C0", Offset = "0x8A680C0", VA = "0x188A696C0")]
		[CompilerGenerated]
		private void GWZZRXYRCKN(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class YGOVBZNOKMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly IUKCYHJIYJD MQAKAQHXIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<GCAKMZMLOAV> VDEDUHYITFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int IGIGQLSQSUC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DIODCFDMGNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DC20", Offset = "0x8A6C620", VA = "0x188A6DC20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DC70", Offset = "0x8A6C670", VA = "0x188A6DC70")]
		protected YGOVBZNOKMS(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DB40", Offset = "0x8A6C540", VA = "0x188A6DB40")]
		public void ECOVDJZTLUP(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DBA0", Offset = "0x8A6C5A0", VA = "0x188A6DBA0")]
		protected void ESKCPQRJKKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DB00", Offset = "0x8A6C500", VA = "0x188A6DB00")]
		public bool AYLQONJGZAS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool KOVOIXGGFHM();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool NYKIXUVJJQL(GCAKMZMLOAV a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal enum ConnectionRequestResult
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Accept,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Reject,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RejectForce
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HWKZXQUYVED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CCTOFGXGRWY HTNWIJRKRPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int EIFJOZRBYLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal NWXAGOGBNCC RJROYKEQOZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint DKZBGTEUXSF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult LFFMOTSPEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1620320", Offset = "0x161ED20", VA = "0x181620320")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1620330", Offset = "0x161ED30", VA = "0x181620330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A62B90", Offset = "0x8A61590", VA = "0x188A62B90")]
		internal void OCUBMUWTRWI(NWXAGOGBNCC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A62B60", Offset = "0x8A61560", VA = "0x188A62B60")]
		private bool FZYAMEXALBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A62BF0", Offset = "0x8A615F0", VA = "0x188A62BF0")]
		internal HWKZXQUYVED(IPEndPoint a, NWXAGOGBNCC b, CCTOFGXGRWY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A62B00", Offset = "0x8A61500", VA = "0x188A62B00")]
		public IUKCYHJIYJD Accept()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum UnconnectedMessageType
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		BasicMessage,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Broadcast
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DisconnectReason
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		ConnectionFailed,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Timeout,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		HostUnreachable,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		NetworkUnreachable,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		RemoteConnectionClose,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		DisconnectPeerCalled,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		ConnectionRejected,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		InvalidProtocol,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		UnknownHost,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Reconnect,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		PeerToPeerConnection,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		PeerNotFound
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DisconnectInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DisconnectReason Reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public SocketError SocketErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public BDATYCOHOFE AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface BWFQPONRQPS
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UYWXBONYCCG(IUKCYHJIYJD a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KEUFFLETOFK(IUKCYHJIYJD a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SYEEZBWUTUD(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QBGSNTGZRQQ(IUKCYHJIYJD a, BDATYCOHOFE b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZDNVHUANTTA(IPEndPoint a, BDATYCOHOFE b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BEYYYEOHWAW(IUKCYHJIYJD a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FWYNINEOJCQ(HWKZXQUYVED a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface UEREJSTGLET
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GWLVZMOQHJM(IUKCYHJIYJD a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NYMBZNTYPYT
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RNORJXGRSHW(ENWPNYEPXMI a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ZIMFIKNURAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VMZGQBLWYAT(IUKCYHJIYJD a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class NWXAGOGBNCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int EFQORRILICC = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long BNKPUHTQTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte ADLHWLNUETR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] JPNCNDXEZSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly LUQYATNJAPE YVVJIHKGLFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int HNXEMUAIPNN;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AF60", Offset = "0x8A69960", VA = "0x188A6AF60")]
		private NWXAGOGBNCC(long a, byte b, int c, byte[] d, LUQYATNJAPE e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AD40", Offset = "0x8A69740", VA = "0x188A6AD40")]
		public static int WLPUPLMELYD(GCAKMZMLOAV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AD70", Offset = "0x8A69770", VA = "0x188A6AD70")]
		public static NWXAGOGBNCC WQNXGLVMKQK(GCAKMZMLOAV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AB60", Offset = "0x8A69560", VA = "0x188A6AB60")]
		public static GCAKMZMLOAV QVHZAINYILO(HSNKFEDGGUG a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class GIYTCFQLWTP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long BNKPUHTQTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte ADLHWLNUETR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int HNXEMUAIPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool VBFADOYYFME;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A61C70", Offset = "0x8A60670", VA = "0x188A61C70")]
		private GIYTCFQLWTP(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A61B70", Offset = "0x8A60570", VA = "0x188A61B70")]
		public static GIYTCFQLWTP WQNXGLVMKQK(GCAKMZMLOAV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A61A80", Offset = "0x8A60480", VA = "0x188A61A80")]
		public static GCAKMZMLOAV QVHZAINYILO(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A61980", Offset = "0x8A60380", VA = "0x188A61980")]
		public static GCAKMZMLOAV KBPCQZHFCLI(IUKCYHJIYJD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum NatAddressType
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		External
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface JBCNJCMQNYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZQMZYQGDGXJ(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GEWXPNTYQGZ(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class KHJUKRVOSMX
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct RequestEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public IPEndPoint LocalEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public IPEndPoint RemoteEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string Token;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct SuccessEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public IPEndPoint TargetEndPoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public NatAddressType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public string Token;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private class ZESCCEGOCKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint GEJNJYCSKGX
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZESCCEGOCKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CLIELUAYJXD
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint GEJNJYCSKGX
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint VIGATXHRUOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public CLIELUAYJXD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class JSLTHHYKJOX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string HMAZRGHHANJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool LXXRXBTJJND
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JSLTHHYKJOX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly CCTOFGXGRWY ZEVPMCRUIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> RAITAEKMKQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> FTHHCZASDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly LUQYATNJAPE YPFHOQYKQLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly HSNKFEDGGUG CNESAWYQLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly POGCMBAQPHV BLIAPAIQBWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JBCNJCMQNYQ TEOEAQMFCXE;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int OPSBJKRKASJ = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool BJADNHVWRJA;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A67B90", Offset = "0x8A66590", VA = "0x188A67B90")]
		internal KHJUKRVOSMX(CCTOFGXGRWY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A67890", Offset = "0x8A66290", VA = "0x188A67890")]
		internal void VSZMDSBKSSW(IPEndPoint a, GCAKMZMLOAV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BC29C0", Offset = "0x3BC13C0", VA = "0x183BC29C0")]
		private void RXBHTTODHVW<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A67A10", Offset = "0x8A66410", VA = "0x188A67A10")]
		private void ZQMZYQGDGXJ(ZESCCEGOCKD a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A675A0", Offset = "0x8A65FA0", VA = "0x188A675A0")]
		private void AUJUZPPQTDL(CLIELUAYJXD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A67700", Offset = "0x8A66100", VA = "0x188A67700")]
		private void BNBYKHDLEEK(JSLTHHYKJOX a, IPEndPoint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum DeliveryMethod : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Unreliable = 4,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ReliableUnordered = 0,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Sequenced = 1,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ReliableOrdered = 2,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ReliableSequenced = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum ConnectionQuality : long
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Excellent,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Fair,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Poor
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class UGYCNQGTZJQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] KDYFQAJCNKL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int JYTUJWEHIMR;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int SDFWZHDULWY;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A66D70", Offset = "0x8A65770", VA = "0x188A66D70")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A66D70", Offset = "0x8A65770", VA = "0x188A66D70")]
		public TooBigPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum NetLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Trace,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Info
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IQBWLEWNNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BCZITCKCBWU(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BZSPZEKGLCE
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static IQBWLEWNNOM KHLKFNYWTNM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object QIFKSYAZMOW;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A56C50", Offset = "0x8A55650", VA = "0x188A56C50")]
		private static void ZCWFDZDVYYV(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A56BF0", Offset = "0x8A555F0", VA = "0x188A56BF0")]
		internal static void UYWJPOCTLMZ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A56B90", Offset = "0x8A55590", VA = "0x188A56B90")]
		internal static void HAWLIORFMTN(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A56B30", Offset = "0x8A55530", VA = "0x188A56B30")]
		internal static void CRFYZRVAMPL(string a, params object[] args)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum IPv6Mode
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		SeparateSocket,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		DualMode
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class BDATYCOHOFE : LUQYATNJAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private GCAKMZMLOAV HYWXXBDAYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CCTOFGXGRWY WNJLULMYZPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly XAPFEPUGBUX SRSLQKXVFLW;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A56AE0", Offset = "0x8A554E0", VA = "0x188A56AE0")]
		internal BDATYCOHOFE(CCTOFGXGRWY a, XAPFEPUGBUX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A56A40", Offset = "0x8A55440", VA = "0x188A56A40")]
		internal void GUCJYSOKIVR(GCAKMZMLOAV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A569C0", Offset = "0x8A553C0", VA = "0x188A569C0")]
		internal void CZMSADAKTPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A56AB0", Offset = "0x8A554B0", VA = "0x188A56AB0")]
		public void VWZSAZHZBWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class XAPFEPUGBUX
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public enum EType
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Connect,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Disconnect,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Receive,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			ReceiveUnconnected,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			ConnectionLatencyUpdated,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			Broadcast,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			ConnectionRequest,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			MessageDelivered,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			PeerAddressChanged
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public XAPFEPUGBUX GQSESNXTZCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType UXYUOXCBTLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IUKCYHJIYJD MQAKAQHXIIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint DKZBGTEUXSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object IHPEQKWQVFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int EGMUSXKGPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError XKGHHUYASSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason NXRVZXRGXQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HWKZXQUYVED HWKZXQUYVED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod PKICWRUKKSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte ETIJUQTCPIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly BDATYCOHOFE AIWJDMCOISV;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A6DA60", Offset = "0x8A6C460", VA = "0x188A6DA60")]
		public XAPFEPUGBUX(CCTOFGXGRWY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CCTOFGXGRWY : IEnumerable<IUKCYHJIYJD>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class YJAZEUQTBEV : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DD00", Offset = "0x8A6C700", VA = "0x188A6DD00", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DD70", Offset = "0x8A6C770", VA = "0x188A6DD70", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public YJAZEUQTBEV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<IUKCYHJIYJD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly IUKCYHJIYJD _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private IUKCYHJIYJD _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IUKCYHJIYJD Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D75370", Offset = "0x1D73D70", VA = "0x181D75370")]
			public NetPeerEnumerator(IUKCYHJIYJD p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B3A0", Offset = "0x8A69DA0", VA = "0x188A6B3A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B3F0", Offset = "0x8A69DF0", VA = "0x188A6B3F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread NROJKLSIJTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool PHZCMJEFEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool MFVSCDBMFSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private XBVVASIKIDT OWWWBSKCRDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent JDFSANPHTVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<XAPFEPUGBUX> LTBDYURUWQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<XAPFEPUGBUX> CMJHHYYDIBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private XAPFEPUGBUX YXDQWTUUGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly BWFQPONRQPS CGOHDWTLGXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly UEREJSTGLET KXPAQDGJTFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly NYMBZNTYPYT HIHREFBUHCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly ZIMFIKNURAF HWEVYARUZWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, IUKCYHJIYJD> DNFTFLDWQMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, HWKZXQUYVED> XWWSARQKZTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, DLESYOQMZPL> UDSIEDGBLFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim FNXNSAJEBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IUKCYHJIYJD XDMQPHPLVSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int ITQJCSYFMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<IUKCYHJIYJD> FXJXTXBFYSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IUKCYHJIYJD[] JRODUJNPGGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly JZGSZEAVDXU QIZJIVMBWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int YFRIXJNRMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> XOZJPZJZRRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte RSXMHLXOYTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object VNVZSVNNMLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool UAFSLQYILIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool BWGXGJDRQXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int CVJSATIJQXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int QJISCGTYLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int IBGKBRDMQKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int TQBIKLRMMBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool APGAOOGGBUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool OTKDSPBWSKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int RHXCVDBRAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int IIYIZSSWYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int WRVWNHALAER;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool BJADNHVWRJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool HXOHWUEKIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool AVPLYQOKVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool NUMUDBUSPXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int NDSFQJBKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int YXTWESTJGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool PBWLYCNTWBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly CHFMEICIMXA GFEHRHNOMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool YRKHVFBQYSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly KHJUKRVOSMX KHJUKRVOSMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool TTSSWYMXZSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode XADSDNPMDSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int CBSPBEILYZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool EBZBVFQFCTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool MVDFCJXAEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool DRSOGWEURCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool XDAZPOXCRFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private GCAKMZMLOAV UYTYFMWBEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int QJQZJUROMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object GCJZWYMGLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private GCAKMZMLOAV FCUPFEAPMXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int QIKMEHKCICX;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int TZJVDVAUUYN = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int QYRSHFFFLCC = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private WKKNWIOZJWM AQSZXVJCXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private WKKNWIOZJWM AQIMDHVIEDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread RVERYQYNQPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread RUUEEDKSXTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint JZFSYDYEERQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint JYVFDQKJLUY;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] HRATQDHAJHM;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] JUZTTKVSWRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> HAKZUQKSSQD;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress EOXXYJKXWPG;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool YOAJCIWWVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int BBSOONLDFMY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ZLVTDCBYXWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE5A140", Offset = "0xE58B40", VA = "0x180E5A140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE57E30", Offset = "0xE56830", VA = "0x180E57E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ENPVCMIYBBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x22278D0", Offset = "0x22262D0", VA = "0x1822278D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23412E0", Offset = "0x233FCE0", VA = "0x1823412E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte UMJSSUUJCDX
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDEE880", Offset = "0xDED280", VA = "0x180DEE880")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int YFVUIQHRRGV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A58780", Offset = "0x8A57180", VA = "0x188A58780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A58510", Offset = "0x8A56F10", VA = "0x188A58510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IUKCYHJIYJD.OnUpdatedMtuDelegate NIAJCBWLFVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A5DA80", Offset = "0x8A5C480", VA = "0x188A5DA80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A58E40", Offset = "0x8A57840", VA = "0x188A58E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A56F30", Offset = "0x8A55930", VA = "0x188A56F30")]
		public void ABBPREUCZQU(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D930", Offset = "0x8A5C330", VA = "0x188A5D930")]
		public void VCCRPLITEWF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A560", Offset = "0x8A58F60", VA = "0x188A5A560")]
		private bool LVSJELNLXJP(IPEndPoint a, [Out] IUKCYHJIYJD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DE00", Offset = "0x8A5C800", VA = "0x188A5DE00")]
		private void YDXXCTXWLEV(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AAA0", Offset = "0x8A594A0", VA = "0x188A5AAA0")]
		private void OEWBOHCIFCK(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A58B20", Offset = "0x8A57520", VA = "0x188A58B20")]
		private void JLCNKCOBVBJ(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E6C0", Offset = "0x8A5D0C0", VA = "0x188A5E6C0")]
		public CCTOFGXGRWY(BWFQPONRQPS a, [Optional] JZGSZEAVDXU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A575B0", Offset = "0x8A55FB0", VA = "0x188A575B0")]
		internal void AJOBCMZAXXN(IUKCYHJIYJD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E450", Offset = "0x8A5CE50", VA = "0x188A5E450")]
		internal void ZKZWZGQWAXZ(IUKCYHJIYJD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B5A0", Offset = "0x8A59FA0", VA = "0x188A5B5A0")]
		internal void SHCBXJEPONN(IUKCYHJIYJD a, DisconnectReason b, SocketError c, GCAKMZMLOAV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A57190", Offset = "0x8A55B90", VA = "0x188A57190")]
		private void ABWNDGIFNZW(IUKCYHJIYJD a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, GCAKMZMLOAV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D560", Offset = "0x8A5BF60", VA = "0x188A5D560")]
		private void ULJNDNSIXDE(XAPFEPUGBUX.EType a, [Optional] IUKCYHJIYJD b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] HWKZXQUYVED g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] GCAKMZMLOAV j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B670", Offset = "0x8A5A070", VA = "0x188A5B670")]
		private void SSLZRBSROON(XAPFEPUGBUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AB00", Offset = "0x8A59500", VA = "0x188A5AB00")]
		internal void OJUROZJTWIB(XAPFEPUGBUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A587A0", Offset = "0x8A571A0", VA = "0x188A587A0")]
		private void GRDGZGKAYVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E120", Offset = "0x8A5CB20", VA = "0x188A5E120")]
		private void YRJAVPIYDRH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AEE0", Offset = "0x8A598E0", VA = "0x188A5AEE0")]
		internal IUKCYHJIYJD QCZHYWDLJMG(HWKZXQUYVED a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B520", Offset = "0x8A59F20", VA = "0x188A5B520")]
		private int QHTUMHJJBNU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A5A600", Offset = "0x8A59000", VA = "0x188A5A600")]
		private void NZEABDRSYUY(IPEndPoint a, IUKCYHJIYJD b, NWXAGOGBNCC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A59260", Offset = "0x8A57C60", VA = "0x188A59260")]
		private void LDZNETRORLL(GCAKMZMLOAV a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A5AC10", Offset = "0x8A59610", VA = "0x188A5AC10")]
		internal void OPVATKDETHT(GCAKMZMLOAV a, DeliveryMethod b, byte c, int d, IUKCYHJIYJD e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BE30", Offset = "0x8A5A830", VA = "0x188A5BE30")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BEC0", Offset = "0x8A5A8C0", VA = "0x188A5BEC0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BE40", Offset = "0x8A5A840", VA = "0x188A5BE40")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A585D0", Offset = "0x8A56FD0", VA = "0x188A585D0")]
		public void FBUHSVHTYNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A57860", Offset = "0x8A56260", VA = "0x188A57860")]
		public IUKCYHJIYJD Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A57780", Offset = "0x8A56180", VA = "0x188A57780")]
		public IUKCYHJIYJD Connect(string address, int port, HSNKFEDGGUG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A57940", Offset = "0x8A56340", VA = "0x188A57940")]
		public IUKCYHJIYJD Connect(IPEndPoint target, HSNKFEDGGUG connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C650", Offset = "0x8A5B050", VA = "0x188A5C650")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C660", Offset = "0x8A5B060", VA = "0x188A5C660")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A581F0", Offset = "0x8A56BF0", VA = "0x188A581F0")]
		public void EDHTBTLICJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A58120", Offset = "0x8A56B20", VA = "0x188A58120")]
		public void EDHTBTLICJZ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A57150", Offset = "0x8A55B50", VA = "0x188A57150")]
		public void ABWNDGIFNZW(IUKCYHJIYJD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A57570", Offset = "0x8A55F70", VA = "0x188A57570")]
		public void ABWNDGIFNZW(IUKCYHJIYJD a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DD70", Offset = "0x8A5C770", VA = "0x188A5DD70", Slot = "4")]
		private IEnumerator<IUKCYHJIYJD> XQDNBEVPDEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A5B5E0", Offset = "0x8A59FE0", VA = "0x188A5B5E0", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A59170", Offset = "0x8A57B70", VA = "0x188A59170")]
		private GCAKMZMLOAV LCVVMFRAMAJ(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A59090", Offset = "0x8A57A90", VA = "0x188A59090")]
		private GCAKMZMLOAV LCVVMFRAMAJ(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A5DB30", Offset = "0x8A5C530", VA = "0x188A5DB30")]
		internal GCAKMZMLOAV XMVARGPPRRK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A582A0", Offset = "0x8A56CA0", VA = "0x188A582A0")]
		internal void EHZRGIQFHCB(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E600", Offset = "0x8A5D000", VA = "0x188A5E600")]
		static CCTOFGXGRWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE5A140", Offset = "0xE58B40", VA = "0x180E5A140")]
		private bool PDOLUVAGPUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5E4A0", Offset = "0x8A5CEA0", VA = "0x188A5E4A0")]
		private void ZSBTVQJTGAC(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A57FD0", Offset = "0x8A569D0", VA = "0x188A57FD0")]
		private void EAXGUSMPEIJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A58EF0", Offset = "0x8A578F0", VA = "0x188A58EF0")]
		private bool KXLWILEGMZJ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A58B00", Offset = "0x8A57500", VA = "0x188A58B00")]
		private void IJJUNSAISWQ(XBVVASIKIDT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A57D10", Offset = "0x8A56710", VA = "0x188A57D10")]
		private void DSSXXQAHHSN(WKKNWIOZJWM a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D1D0", Offset = "0x8A5BBD0", VA = "0x188A5D1D0")]
		private void TUXWNIAFYBF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5BEE0", Offset = "0x8A5A8E0", VA = "0x188A5BEE0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A58DE0", Offset = "0x8A577E0", VA = "0x188A58DE0")]
		internal int JUJQNGNZHKU(GCAKMZMLOAV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5D190", Offset = "0x8A5BB90", VA = "0x188A5D190")]
		internal int TGAJIQLKXFE(GCAKMZMLOAV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C9C0", Offset = "0x8A5B3C0", VA = "0x188A5C9C0")]
		internal int TGAJIQLKXFE(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A57600", Offset = "0x8A56000", VA = "0x188A57600")]
		internal void BBVKTFKIARB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal enum PacketProperty : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Unreliable,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Channeled,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Ack,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Ping,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Pong,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		ConnectRequest,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		ConnectAccept,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		UnconnectedMessage,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		MtuCheck,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		MtuOk,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Merged,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ShutdownOk,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		PeerNotFound,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		InvalidProtocol,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		NatMessage,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Empty
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class GCAKMZMLOAV
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int PMEUNOFFDDQ;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] KTBGLDRZXJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] BEEQTBJBAUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int MQIMAXWABZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object IHPEQKWQVFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GCAKMZMLOAV GQSESNXTZCL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty WIAAFFAKCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8A611F0", Offset = "0x8A5FBF0", VA = "0x188A611F0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A612B0", Offset = "0x8A5FCB0", VA = "0x188A612B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte ADLHWLNUETR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A61030", Offset = "0x8A5FA30", VA = "0x188A61030")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A614B0", Offset = "0x8A5FEB0", VA = "0x188A614B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort FGZHLSIACBV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A611D0", Offset = "0x8A5FBD0", VA = "0x188A611D0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A61240", Offset = "0x8A5FC40", VA = "0x188A61240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IQVNKOSSZUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A61280", Offset = "0x8A5FC80", VA = "0x188A61280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte JEVUVWVPZKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A61440", Offset = "0x8A5FE40", VA = "0x188A61440")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A61310", Offset = "0x8A5FD10", VA = "0x188A61310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort ETMXHSTLTLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A61010", Offset = "0x8A5FA10", VA = "0x188A61010")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A614F0", Offset = "0x8A5FEF0", VA = "0x188A614F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort GRCXOLWKAMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A612F0", Offset = "0x8A5FCF0", VA = "0x188A612F0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A61470", Offset = "0x8A5FE70", VA = "0x188A61470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort CXSJLEHJEMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A61220", Offset = "0x8A5FC20", VA = "0x188A61220")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A61190", Offset = "0x8A5FB90", VA = "0x188A61190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A61530", Offset = "0x8A5FF30", VA = "0x188A61530")]
		static GCAKMZMLOAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A61060", Offset = "0x8A5FA60", VA = "0x188A61060")]
		public void CCHRDHWHLWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A61800", Offset = "0x8A60200", VA = "0x188A61800")]
		public GCAKMZMLOAV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A61870", Offset = "0x8A60270", VA = "0x188A61870")]
		public GCAKMZMLOAV(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A61340", Offset = "0x8A5FD40", VA = "0x188A61340")]
		public static int NYNVNTQGVLI(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A613B0", Offset = "0x8A5FDB0", VA = "0x188A613B0")]
		public int NYNVNTQGVLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A61090", Offset = "0x8A5FA90", VA = "0x188A61090")]
		public bool CTFANBOYOTR()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Flags]
	public enum ConnectionState : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Outgoing = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Connected = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		ShutdownRequested = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Disconnected = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		EndPointChange = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Any = 0x2E
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal enum ConnectRequestResult
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		P2PLose,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Reconnection,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		NewConnection
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal enum DisconnectResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Reject,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Disconnect
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal enum ShutdownResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		WasConnected
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class IUKCYHJIYJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class VKXHCWSNBAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public GCAKMZMLOAV[] XBBQDPUPGRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int FQWIUDLSGUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int AGIOEDGLYWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte JEVUVWVPZKU;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VKXHCWSNBAT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int VVMFAPUXHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int ORIQRDIPMQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int DREPRINWNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double IQKKCETKTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int ENAMVDPPQYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int HGQZEMGTMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int BEWQYHGHOIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch DXWTZLYRTIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int VGDPXIIIWCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long ZNKDFKHQYKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object MDDANJZHOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal IUKCYHJIYJD JNOFCVCOJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal IUKCYHJIYJD YVEVWHLEUDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<GCAKMZMLOAV> ANFZLJNJOQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<YGOVBZNOKMS> OXNEFXEYFQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly YGOVBZNOKMS[] BIQAUUCDNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int DLDGRXWGDIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int XAKNMLXNIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool MBKOZTGXREU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int ZPDLADIKQYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int ZDCGDUVXAPX;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int YCDFLUQWDVT = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int CHEKXMQXQJY = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object WRGICONXCTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int LHKTLTJUTPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, VKXHCWSNBAT> XDQKBIPXBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> QCHXUKYPGKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly GCAKMZMLOAV XUZBNFFPNMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int YACYSVOOFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int FOWXPOVMDRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint YAIWLXONVVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int QCVYYOTQEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int WOWPMBUKPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long XBHZHUHHIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte WCLMLQBMWDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState LIQQZNUWFKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GCAKMZMLOAV HXEOOOSKBMB;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int URUEFUNFEUX = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int ZGZRAYHOOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly GCAKMZMLOAV XTDRHOLQGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly GCAKMZMLOAV KVYHMLCJNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly GCAKMZMLOAV LONRYWGLCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly GCAKMZMLOAV CBTJWYBYBJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality TIHUUNVRFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly CCTOFGXGRWY CCTOFGXGRWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int SGYXLDBUDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object LZHYGFSTXJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly CHFMEICIMXA GFEHRHNOMKN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte HBJNUYEPHWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD033C0", Offset = "0xD01DC0", VA = "0x180D033C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A63D80", Offset = "0x8A62780", VA = "0x188A63D80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint MYONXUJBADV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE54530", Offset = "0xE52F30", VA = "0x180E54530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState SSOQXRBHUMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x147DAC0", Offset = "0x147C4C0", VA = "0x18147DAC0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long RJEKMLTWWMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCE1430", Offset = "0xCDFE30", VA = "0x180CE1430")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int HNGEFDPZETT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x22278D0", Offset = "0x22262D0", VA = "0x1822278D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23412E0", Offset = "0x233FCE0", VA = "0x1823412E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int IMPCINVETVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A63310", Offset = "0x8A61D10", VA = "0x188A63310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int IKIWHDCOFBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCF3DF0", Offset = "0xCF27F0", VA = "0x180CF3DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double QKDBJYNLKRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9010", Offset = "0x2AC7A10", VA = "0x182AC9010")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate NIAJCBWLFVY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A65E10", Offset = "0x8A64810", VA = "0x188A65E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A635C0", Offset = "0x8A61FC0", VA = "0x188A635C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A66790", Offset = "0x8A65190", VA = "0x188A66790")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A65DF0", Offset = "0x8A647F0", VA = "0x188A65DF0")]
		internal void VDOIAAWVREQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A63670", Offset = "0x8A62070", VA = "0x188A63670")]
		internal void LJZGCGEUONG(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A63320", Offset = "0x8A61D20", VA = "0x188A63320")]
		internal void JHTWBTLLLVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A63240", Offset = "0x8A61C40", VA = "0x188A63240")]
		private void IHKXCXSVPVA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A636A0", Offset = "0x8A620A0", VA = "0x188A636A0")]
		private void MSTTJBNUTUK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A65F00", Offset = "0x8A64900", VA = "0x188A65F00")]
		public int YCRIBDMDEVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A66010", Offset = "0x8A64A10", VA = "0x188A66010")]
		public int YCRIBDMDEVW(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A645E0", Offset = "0x8A62FE0", VA = "0x188A645E0")]
		private YGOVBZNOKMS OORBIXNNNKF(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A66600", Offset = "0x8A65000", VA = "0x188A66600")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, IPEndPoint b, int c, byte d, HSNKFEDGGUG e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A66B90", Offset = "0x8A65590", VA = "0x188A66B90")]
		internal IUKCYHJIYJD(CCTOFGXGRWY a, HWKZXQUYVED b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A64B30", Offset = "0x8A63530", VA = "0x188A64B30")]
		internal void Reject(NWXAGOGBNCC requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A664E0", Offset = "0x8A64EE0", VA = "0x188A664E0")]
		internal bool YYCYHIBBRGL(GIYTCFQLWTP a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A64B00", Offset = "0x8A63500", VA = "0x188A64B00")]
		public void RXBHTTODHVW(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A63FF0", Offset = "0x8A629F0", VA = "0x188A63FF0")]
		private void OMXYBRRJSDH(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A631F0", Offset = "0x8A61BF0", VA = "0x188A631F0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A66560", Offset = "0x8A64F60", VA = "0x188A66560")]
		internal DisconnectResult ZTERVFBTGBX(GCAKMZMLOAV a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A63190", Offset = "0x8A61B90", VA = "0x188A63190")]
		internal void CLDPXQZRZVA(YGOVBZNOKMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A65410", Offset = "0x8A63E10", VA = "0x188A65410")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A65EC0", Offset = "0x8A648C0", VA = "0x188A65EC0")]
		private void WUFAKURBJFV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A64B80", Offset = "0x8A63580", VA = "0x188A64B80")]
		internal void SZINCMUSMUH(DeliveryMethod a, GCAKMZMLOAV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A62C60", Offset = "0x8A61660", VA = "0x188A62C60")]
		private void BFIOEQNLFZL(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A64770", Offset = "0x8A63170", VA = "0x188A64770")]
		private void RBELSKEJGPP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A63E30", Offset = "0x8A62830", VA = "0x188A63E30")]
		internal ConnectRequestResult NZEABDRSYUY(NWXAGOGBNCC a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A636E0", Offset = "0x8A620E0", VA = "0x188A636E0")]
		internal void NYKIXUVJJQL(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A66130", Offset = "0x8A64B30", VA = "0x188A66130")]
		private void YQRLHLCLZTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A633B0", Offset = "0x8A61DB0", VA = "0x188A633B0")]
		internal void JTUIWTRYFZJ(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A65720", Offset = "0x8A64120", VA = "0x188A65720")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A66280", Offset = "0x8A64C80", VA = "0x188A66280")]
		internal void YSSCVWBCNGV(GCAKMZMLOAV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class CHFMEICIMXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long GWSBXWLCABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long QQCZEDTKCQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long RBNMUARCTYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long DCDOZRHQSCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long VCUTHATRIPK;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long DEOWWIDWSNJ;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long MDSXPFLWSMG;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long WMBIZJZSESJ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long SWKYAMBZDBG;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long BXMJTBSRAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long MRRAXNLICZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long SZYIGTSIEEA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long CHUMONHWKSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A5ED40", Offset = "0x8A5D740", VA = "0x188A5ED40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long UFYXQQAEGQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A5ED90", Offset = "0x8A5D790", VA = "0x188A5ED90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long SSNUDUZYCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F3C0", Offset = "0x8A5DDC0", VA = "0x188A5F3C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long DLZPQBDHSZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A5EE50", Offset = "0x8A5D850", VA = "0x188A5EE50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long WFQCGRCPSIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A5EE40", Offset = "0x8A5D840", VA = "0x188A5EE40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long VJLLHTKCYDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F430", Offset = "0x8A5DE30", VA = "0x188A5F430")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long QPZBQSGTAXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A5ED50", Offset = "0x8A5D750", VA = "0x188A5ED50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long LEXRBYXBLXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A5EF40", Offset = "0x8A5D940", VA = "0x188A5EF40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality UTXHCKXEQYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x14095A0", Offset = "0x1407FA0", VA = "0x1814095A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double RQJFVNNRBHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A5EEE0", Offset = "0x8A5D8E0", VA = "0x188A5EEE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EFF0", Offset = "0x8A5D9F0", VA = "0x188A5EFF0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F030", Offset = "0x8A5DA30", VA = "0x188A5F030")]
		public void TPCCZOAWKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5ECF0", Offset = "0x8A5D6F0", VA = "0x188A5ECF0")]
		public void AFGOEZCQMCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EF80", Offset = "0x8A5D980", VA = "0x188A5EF80")]
		public void RPJRWXXQEGO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EC80", Offset = "0x8A5D680", VA = "0x188A5EC80")]
		public void AAJIIPFINJZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F3D0", Offset = "0x8A5DDD0", VA = "0x188A5F3D0")]
		public void VUWPHRNUNMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EE60", Offset = "0x8A5D860", VA = "0x188A5EE60")]
		public void MHNOYQWNXCO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F090", Offset = "0x8A5DA90", VA = "0x188A5F090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EDA0", Offset = "0x8A5D7A0", VA = "0x188A5EDA0")]
		public void IZDFAWVDAYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CHFMEICIMXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FQCHWESBWTE
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> VJYJYGOTFML;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8A60AE0", Offset = "0x8A5F4E0", VA = "0x188A60AE0")]
		public static IPEndPoint SKHEGXXBHMB(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A60DB0", Offset = "0x8A5F7B0", VA = "0x188A60DB0")]
		public static IPAddress TZIKFLNVLWO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A60D20", Offset = "0x8A5F720", VA = "0x188A60D20")]
		public static IPAddress TZIKFLNVLWO(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A60AB0", Offset = "0x8A5F4B0", VA = "0x188A60AB0")]
		internal static int GTNWDWHKZKW(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2260", Offset = "0x3AB0C60", VA = "0x183AB2260")]
		internal static T[] KZHOSYGHUDZ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class OWBOZSBACXR : YGOVBZNOKMS
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private GCAKMZMLOAV _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8A6C880", Offset = "0x8A6B280", VA = "0x188A6C880", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A6C860", Offset = "0x8A6B260", VA = "0x188A6C860")]
			public void ORLMZSMEYLO(GCAKMZMLOAV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A6C7F0", Offset = "0x8A6B1F0", VA = "0x188A6C7F0")]
			public bool FYIZWJYZTDX(long a, IUKCYHJIYJD b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A6C7A0", Offset = "0x8A6B1A0", VA = "0x188A6C7A0")]
			public bool Clear(IUKCYHJIYJD peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly GCAKMZMLOAV CPZOZQBSVEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] BRPCOGISXFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly GCAKMZMLOAV[] ZMQYARYXEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] VHMDCNDOILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int QEKFYUNGXQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int FQJDTMUMBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int XPVOUSVGCGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int RIRBCIQDRTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool KOWJITBUEQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod CLGNSCVMTFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool PKPPEDCUWHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int AGTGDJTDGAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte YQIKSJKKWIO;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int KJYIKEHPKNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B430", Offset = "0x8A69E30", VA = "0x188A6B430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C290", Offset = "0x8A6AC90", VA = "0x188A6C290")]
		public OWBOZSBACXR(IUKCYHJIYJD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B440", Offset = "0x8A69E40", VA = "0x188A6B440")]
		private void JBEDJOPDPZW(GCAKMZMLOAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B7C0", Offset = "0x8A6A1C0", VA = "0x188A6B7C0", Slot = "4")]
		protected override bool KOVOIXGGFHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6BC90", Offset = "0x8A6A690", VA = "0x188A6BC90", Slot = "5")]
		public override bool NYKIXUVJJQL(GCAKMZMLOAV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class ROABTRPFKBG : YGOVBZNOKMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int ZDCEVGUCOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort FQJDTMUMBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool EGIQXADCPAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private GCAKMZMLOAV RSEIMQDBBTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly GCAKMZMLOAV QGCNVQNKNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool NBUVFDKUYFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte YQIKSJKKWIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long PXFIQCUWPFK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D030", Offset = "0x8A6BA30", VA = "0x188A6D030")]
		public ROABTRPFKBG(IUKCYHJIYJD a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C8F0", Offset = "0x8A6B2F0", VA = "0x188A6C8F0", Slot = "4")]
		protected override bool KOVOIXGGFHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A6CDB0", Offset = "0x8A6B7B0", VA = "0x188A6CDB0", Slot = "5")]
		public override bool NYKIXUVJJQL(GCAKMZMLOAV a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class DVXSDUIBKCR
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct ConverterHelperDouble
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public ulong Along;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public double Adouble;
		}

		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct ConverterHelperFloat
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int Aint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public float Afloat;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8A563E0", Offset = "0x8A54DE0", VA = "0x188A563E0")]
		private static void SGUPCYATOOG(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F600", Offset = "0x8A5E000", VA = "0x188A5F600")]
		private static void SGUPCYATOOG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F5C0", Offset = "0x8A5DFC0", VA = "0x188A5F5C0")]
		public static void SGUPCYATOOG(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F680", Offset = "0x8A5E080", VA = "0x188A5F680")]
		public static void OTSNVORVUSV(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F540", Offset = "0x8A5DF40", VA = "0x188A5F540")]
		public static void OTSNVORVUSV(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F5C0", Offset = "0x8A5DFC0", VA = "0x188A5F5C0")]
		public static void OTSNVORVUSV(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F5C0", Offset = "0x8A5DFC0", VA = "0x188A5F5C0")]
		public static void OTSNVORVUSV(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F600", Offset = "0x8A5E000", VA = "0x188A5F600")]
		public static void OTSNVORVUSV(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F600", Offset = "0x8A5E000", VA = "0x188A5F600")]
		public static void OTSNVORVUSV(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F670", Offset = "0x8A5E070", VA = "0x188A5F670")]
		public static void OTSNVORVUSV(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F670", Offset = "0x8A5E070", VA = "0x188A5F670")]
		public static void OTSNVORVUSV(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class LUQYATNJAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] DLSQRHEKROT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int RLUMZHWODVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int KBLMHJPEDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int HUPNAREFAZW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] BEEQTBJBAUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NRVGIJHTRIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int DECIKYRRGUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A689F0", Offset = "0x8A673F0", VA = "0x188A689F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool QRXKUPFYYJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A27340", Offset = "0x2A25D40", VA = "0x182A27340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int BFNWEGIJTKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A68E40", Offset = "0x8A67840", VA = "0x188A68E40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8A68C10", Offset = "0x8A67610", VA = "0x188A68C10")]
		public void GUCJYSOKIVR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LUQYATNJAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A69240", Offset = "0x8A67C40", VA = "0x188A69240")]
		public LUQYATNJAPE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A68DB0", Offset = "0x8A677B0", VA = "0x188A68DB0")]
		public IPEndPoint KVLNYDZWFNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A689B0", Offset = "0x8A673B0", VA = "0x188A689B0")]
		public byte AGOTOAHCIOM()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A689B0", Offset = "0x8A673B0", VA = "0x188A689B0")]
		public sbyte TIILXMQIDOZ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB080", Offset = "0x3BD9A80", VA = "0x183BDB080")]
		public a[] BYGHRXBYCRB<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A68D00", Offset = "0x8A67700", VA = "0x188A68D00")]
		public bool[] JJYPHCOSGEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F70", Offset = "0x8A67970", VA = "0x188A68F70")]
		public ushort[] WGRLQOLBQUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A68E90", Offset = "0x8A67890", VA = "0x188A68E90")]
		public short[] TPMJTMPOLJT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A68E50", Offset = "0x8A67850", VA = "0x188A68E50")]
		public int[] RPACAGKZYZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A68FF0", Offset = "0x8A679F0", VA = "0x188A68FF0")]
		public uint[] YYCGCSOZCUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A20", Offset = "0x8A67420", VA = "0x188A68A20")]
		public float[] DDGTBRHWNXD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A68BD0", Offset = "0x8A675D0", VA = "0x188A68BD0")]
		public double[] FXAEEOIONYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A68FB0", Offset = "0x8A679B0", VA = "0x188A68FB0")]
		public long[] WOSCJUQNAGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A68C90", Offset = "0x8A67690", VA = "0x188A68C90")]
		public ulong[] IRJRTXYXGAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A68B00", Offset = "0x8A67500", VA = "0x188A68B00")]
		public string[] FSFHPTGVKIA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F30", Offset = "0x8A67930", VA = "0x188A68F30")]
		public bool VQYKIOKGIEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A90", Offset = "0x8A67490", VA = "0x188A68A90")]
		public char NMQYYXEJQTQ()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A90", Offset = "0x8A67490", VA = "0x188A68A90")]
		public ushort DXUDQPHPOOJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A90", Offset = "0x8A67490", VA = "0x188A68A90")]
		public short VMNEZVGHYME()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A60", Offset = "0x8A67460", VA = "0x188A68A60")]
		public long INHLJWPXJPK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A60", Offset = "0x8A67460", VA = "0x188A68A60")]
		public ulong DEDOHGAEUOX()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A68ED0", Offset = "0x8A678D0", VA = "0x188A68ED0")]
		public int UDVENIWAVAX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A68ED0", Offset = "0x8A678D0", VA = "0x188A68ED0")]
		public uint YCOMYPNMJGO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A68CD0", Offset = "0x8A676D0", VA = "0x188A68CD0")]
		public float JGCNNUQWZNK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F00", Offset = "0x8A67900", VA = "0x188A68F00")]
		public double VCBWHTECNTN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A69030", Offset = "0x8A67A30", VA = "0x188A69030")]
		public string ZCKLFKVEXWD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A68D40", Offset = "0x8A67740", VA = "0x188A68D40")]
		public ArraySegment<byte> JYQFMSLTHVE(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A68AC0", Offset = "0x8A674C0", VA = "0x188A68AC0")]
		public sbyte[] EORALOVMNVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A68C50", Offset = "0x8A67650", VA = "0x188A68C50")]
		public byte[] IKMAHXNPEWB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A68A00", Offset = "0x8A67400", VA = "0x188A68A00")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class HSNKFEDGGUG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] DLSQRHEKROT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int RLUMZHWODVK;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int ORJLNSELRVN = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool LQLHYGYSTWQ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding ZQAZUKVYMSI;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int EKGBINSOJRL = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] ELAWRUJEPAM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int JEDXTOZKJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A62A80", Offset = "0x8A61480", VA = "0x188A62A80")]
		public HSNKFEDGGUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8A629E0", Offset = "0x8A613E0", VA = "0x188A629E0")]
		public HSNKFEDGGUG(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A62290", Offset = "0x8A60C90", VA = "0x188A62290")]
		public static HSNKFEDGGUG PCAIEYWVEWX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A621F0", Offset = "0x8A60BF0", VA = "0x188A621F0")]
		public void KBZRLDFKMCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FB20", Offset = "0x2A9E520", VA = "0x182A9FB20")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8A62620", Offset = "0x8A61020", VA = "0x188A62620")]
		public void YZNWNPIPDWD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8A626C0", Offset = "0x8A610C0", VA = "0x188A626C0")]
		public void YZNWNPIPDWD(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A627E0", Offset = "0x8A611E0", VA = "0x188A627E0")]
		public void YZNWNPIPDWD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8A627E0", Offset = "0x8A611E0", VA = "0x188A627E0")]
		public void YZNWNPIPDWD(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8A62590", Offset = "0x8A60F90", VA = "0x188A62590")]
		public void YZNWNPIPDWD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A62590", Offset = "0x8A60F90", VA = "0x188A62590")]
		public void YZNWNPIPDWD(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A62300", Offset = "0x8A60D00", VA = "0x188A62300")]
		public void YZNWNPIPDWD(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A62300", Offset = "0x8A60D00", VA = "0x188A62300")]
		public void YZNWNPIPDWD(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A62300", Offset = "0x8A60D00", VA = "0x188A62300")]
		public void YZNWNPIPDWD(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8A62830", Offset = "0x8A61230", VA = "0x188A62830")]
		public void YZNWNPIPDWD(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A62830", Offset = "0x8A61230", VA = "0x188A62830")]
		public void YZNWNPIPDWD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8A62890", Offset = "0x8A61290", VA = "0x188A62890")]
		public void YZNWNPIPDWD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A62040", Offset = "0x8A60A40", VA = "0x188A62040")]
		public void HNLMBHQNKHF(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A62040", Offset = "0x8A60A40", VA = "0x188A62040")]
		public void PBEQDFCWTFI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A62900", Offset = "0x8A61300", VA = "0x188A62900")]
		public void YZNWNPIPDWD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8A61E80", Offset = "0x8A60880", VA = "0x188A61E80")]
		public void FPMSNQAQOUY(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DA0", Offset = "0x8A607A0", VA = "0x188A61DA0")]
		public void FPMSNQAQOUY(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CC0", Offset = "0x8A606C0", VA = "0x188A61CC0")]
		public void FPMSNQAQOUY(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CC0", Offset = "0x8A606C0", VA = "0x188A61CC0")]
		public void FPMSNQAQOUY(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8A61CC0", Offset = "0x8A606C0", VA = "0x188A61CC0")]
		public void FPMSNQAQOUY(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DA0", Offset = "0x8A607A0", VA = "0x188A61DA0")]
		public void FPMSNQAQOUY(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A61DA0", Offset = "0x8A607A0", VA = "0x188A61DA0")]
		public void FPMSNQAQOUY(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A61F60", Offset = "0x8A60960", VA = "0x188A61F60")]
		public void FPMSNQAQOUY(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8A61F60", Offset = "0x8A60960", VA = "0x188A61F60")]
		public void FPMSNQAQOUY(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8A62040", Offset = "0x8A60A40", VA = "0x188A62040")]
		public void FPMSNQAQOUY(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A62120", Offset = "0x8A60B20", VA = "0x188A62120")]
		public void FPMSNQAQOUY(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8A62710", Offset = "0x8A61110", VA = "0x188A62710")]
		public void YZNWNPIPDWD(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A62370", Offset = "0x8A60D70", VA = "0x188A62370")]
		public void YZNWNPIPDWD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A62380", Offset = "0x8A60D80", VA = "0x188A62380")]
		public void YZNWNPIPDWD(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class POGCMBAQPHV
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class RWHDONEJNYP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong SGYXLDBUDMX;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x7763480", Offset = "0x7761E80", VA = "0x187763480")]
			static RWHDONEJNYP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(LUQYATNJAPE reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class VULLNNBHPBK<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public POGCMBAQPHV IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a ZVNSXGSSVRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> XMCAYDWEFUI;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VULLNNBHPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7EFC6A0", Offset = "0x7EFB0A0", VA = "0x187EFC6A0")]
			internal void KKAJGCLYKXJ(LUQYATNJAPE a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HSXMHOTZTKE<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public POGCMBAQPHV IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a ZVNSXGSSVRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> XMCAYDWEFUI;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HSXMHOTZTKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x64DDAD0", Offset = "0x64DC4D0", VA = "0x1864DDAD0")]
			internal void KKAJGCLYKXJ(LUQYATNJAPE a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly LYJTWFFXCXP VKKHBKVCLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> SCNSCTOWPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly HSNKFEDGGUG RMNTAFATOFP;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C5F0", Offset = "0x8A6AFF0", VA = "0x188A6C5F0")]
		public POGCMBAQPHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AD20", Offset = "0x3D59720", VA = "0x183D5AD20", Slot = "4")]
		protected virtual ulong SWDGNTTEATI<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C520", Offset = "0x8A6AF20", VA = "0x188A6C520", Slot = "5")]
		protected virtual SubscribeDelegate JIYNEOFRFPD(LUQYATNJAPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5ADA0", Offset = "0x3D597A0", VA = "0x183D5ADA0", Slot = "6")]
		protected virtual void SWLMGWGWIFL<b>(HSNKFEDGGUG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C4A0", Offset = "0x8A6AEA0", VA = "0x188A6C4A0")]
		public void EZQTJCQCXYC(LUQYATNJAPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AC90", Offset = "0x3D59690", VA = "0x183D5AC90")]
		public void SISZBYWUTCR<j>(HSNKFEDGGUG a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C450", Offset = "0x8A6AE50", VA = "0x188A6C450")]
		public void EALOKRSWRTE(LUQYATNJAPE a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AFA0", Offset = "0x3D599A0", VA = "0x183D5AFA0")]
		public void YRNYDOOGLBF<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AFA0", Offset = "0x3D599A0", VA = "0x183D5AFA0")]
		public void YRNYDOOGLBF<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8A66D70", Offset = "0x8A65770", VA = "0x188A66D70")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6C740", Offset = "0x8A6B140", VA = "0x188A6C740")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class LYJTWFFXCXP
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private enum CallType
		{
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			Array,
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			List
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private abstract class LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType UXYUOXCBTLU;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6928CA0", Offset = "0x69276A0", VA = "0x186928CA0", Slot = "4")]
			public virtual void ORLMZSMEYLO(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void DWMISJDBTWO(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void SISZBYWUTCR(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void QSTCCTBXDQD(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void MHQMHLBLONI(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void CMARJVDOIXE(a a, LUQYATNJAPE b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void ZOCLZKLCWCR(a a, HSNKFEDGGUG b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			protected LINHOWVFUBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class SNCOYDQJMQS<a, b> : LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> XNGFNIRFMJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> JDCNMFZHFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> PNASKLRCDWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> RKBYNWZMRZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> JGPFNNPNAQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> QCATUGGJQPX;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x79BF1B0", Offset = "0x79BDBB0", VA = "0x1879BF1B0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x79BF1B0", Offset = "0x79BDBB0", VA = "0x1879BF1B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x79BF0E0", Offset = "0x79BDAE0", VA = "0x1879BF0E0", Slot = "9")]
			public override void CMARJVDOIXE(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x79BF0E0", Offset = "0x79BDAE0", VA = "0x1879BF0E0", Slot = "10")]
			public override void ZOCLZKLCWCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x79BFED0", Offset = "0x79BE8D0", VA = "0x1879BFED0")]
			protected b[] XNXINNJLOEL(a a, LUQYATNJAPE b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x79BF280", Offset = "0x79BDC80", VA = "0x1879BF280")]
			protected b[] NKRUTKNPCWC(a a, HSNKFEDGGUG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x79BF3F0", Offset = "0x79BDDF0", VA = "0x1879BF3F0", Slot = "4")]
			public override void ORLMZSMEYLO(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x79C0170", Offset = "0x79BEB70", VA = "0x1879C0170")]
			protected SNCOYDQJMQS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class YDHONURWCQZ<a, b> : SNCOYDQJMQS<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void KWCQBLYAGFM(LUQYATNJAPE a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void NASFRIFOXRT(HSNKFEDGGUG a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x50E94F0", Offset = "0x50E7EF0", VA = "0x1850E94F0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x50E9C20", Offset = "0x50E8620", VA = "0x1850E9C20", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x50E9A30", Offset = "0x50E8430", VA = "0x1850E9A30", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x50E97A0", Offset = "0x50E81A0", VA = "0x1850E97A0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x50E9E60", Offset = "0x50E8860", VA = "0x1850E9E60")]
			protected YDHONURWCQZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class ZWDOYZYRFOA<a> : SNCOYDQJMQS<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x510F930", Offset = "0x510E330", VA = "0x18510F930", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x510FE30", Offset = "0x510E830", VA = "0x18510FE30", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x510FBE0", Offset = "0x510E5E0", VA = "0x18510FBE0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x510FAA0", Offset = "0x510E4A0", VA = "0x18510FAA0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public ZWDOYZYRFOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class USLAWRCPRNT<a> : SNCOYDQJMQS<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x510F930", Offset = "0x510E330", VA = "0x18510F930", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x510FE30", Offset = "0x510E830", VA = "0x18510FE30", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7E08F20", Offset = "0x7E07920", VA = "0x187E08F20", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x510FAA0", Offset = "0x510E4A0", VA = "0x18510FAA0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public USLAWRCPRNT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class PALMWFEIUJF<a> : SNCOYDQJMQS<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5BADD80", Offset = "0x5BAC780", VA = "0x185BADD80", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE160", Offset = "0x5BACB60", VA = "0x185BAE160", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x74DF0A0", Offset = "0x74DDAA0", VA = "0x1874DF0A0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x5BADDD0", Offset = "0x5BAC7D0", VA = "0x185BADDD0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public PALMWFEIUJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class EVBVMCHHSVA<a> : SNCOYDQJMQS<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x5BADD80", Offset = "0x5BAC780", VA = "0x185BADD80", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE160", Offset = "0x5BACB60", VA = "0x185BAE160", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5BADF10", Offset = "0x5BAC910", VA = "0x185BADF10", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x5BADDD0", Offset = "0x5BAC7D0", VA = "0x185BADDD0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public EVBVMCHHSVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class YRYFPWFOXWH<a> : SNCOYDQJMQS<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x50F1DE0", Offset = "0x50F07E0", VA = "0x1850F1DE0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x50F21C0", Offset = "0x50F0BC0", VA = "0x1850F21C0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F70", Offset = "0x50F0970", VA = "0x1850F1F70", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F30", Offset = "0x50F0930", VA = "0x1850F1F30", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public YRYFPWFOXWH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class WFIJBPVSOPK<a> : SNCOYDQJMQS<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x50F1DE0", Offset = "0x50F07E0", VA = "0x1850F1DE0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x50F21C0", Offset = "0x50F0BC0", VA = "0x1850F21C0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x85C5B20", Offset = "0x85C4520", VA = "0x1885C5B20", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F30", Offset = "0x50F0930", VA = "0x1850F1F30", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public WFIJBPVSOPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class CRFNHEQPNSD<a> : SNCOYDQJMQS<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x501DFC0", Offset = "0x501C9C0", VA = "0x18501DFC0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x501E2A0", Offset = "0x501CCA0", VA = "0x18501E2A0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x501E150", Offset = "0x501CB50", VA = "0x18501E150", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x501E110", Offset = "0x501CB10", VA = "0x18501E110", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public CRFNHEQPNSD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class XQLYXJTEBLU<a> : SNCOYDQJMQS<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x501DFC0", Offset = "0x501C9C0", VA = "0x18501DFC0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x501E2A0", Offset = "0x501CCA0", VA = "0x18501E2A0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x50B2EF0", Offset = "0x50B18F0", VA = "0x1850B2EF0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x501E110", Offset = "0x501CB10", VA = "0x18501E110", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public XQLYXJTEBLU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class ITNVZUMCUXN<a> : SNCOYDQJMQS<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x65EF6B0", Offset = "0x65EE0B0", VA = "0x1865EF6B0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x65EF850", Offset = "0x65EE250", VA = "0x1865EF850", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x65EF700", Offset = "0x65EE100", VA = "0x1865EF700", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x510FAA0", Offset = "0x510E4A0", VA = "0x18510FAA0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public ITNVZUMCUXN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class RNFTALUSQOY<a> : SNCOYDQJMQS<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x773DB70", Offset = "0x773C570", VA = "0x18773DB70", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x773DE20", Offset = "0x773C820", VA = "0x18773DE20", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x773DCD0", Offset = "0x773C6D0", VA = "0x18773DCD0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F30", Offset = "0x50F0930", VA = "0x1850F1F30", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public RNFTALUSQOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class KONPWYFYTZL<a> : SNCOYDQJMQS<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6805380", Offset = "0x6803D80", VA = "0x186805380", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6805520", Offset = "0x6803F20", VA = "0x186805520", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x68054D0", Offset = "0x6803ED0", VA = "0x1868054D0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x501E110", Offset = "0x501CB10", VA = "0x18501E110", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x501E400", Offset = "0x501CE00", VA = "0x18501E400")]
			public KONPWYFYTZL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class EKBOARPXWPL<a> : YDHONURWCQZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5B55D50", Offset = "0x5B54750", VA = "0x185B55D50", Slot = "12")]
			protected override void NASFRIFOXRT(HSNKFEDGGUG a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B55D20", Offset = "0x5B54720", VA = "0x185B55D20", Slot = "11")]
			protected override void KWCQBLYAGFM(LUQYATNJAPE a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5B55D80", Offset = "0x5B54780", VA = "0x185B55D80")]
			public EKBOARPXWPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class VQIWYPDLHGB<a> : YDHONURWCQZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7680", Offset = "0x7EF6080", VA = "0x187EF7680", Slot = "12")]
			protected override void NASFRIFOXRT(HSNKFEDGGUG a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7640", Offset = "0x7EF6040", VA = "0x187EF7640", Slot = "11")]
			protected override void KWCQBLYAGFM(LUQYATNJAPE a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5B55D80", Offset = "0x5B54780", VA = "0x185B55D80")]
			public VQIWYPDLHGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class XMNHTYDGMVG<a> : SNCOYDQJMQS<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int NREAJHSPXHB;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x50A3780", Offset = "0x50A2180", VA = "0x1850A3780")]
			public XMNHTYDGMVG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50A32C0", Offset = "0x50A1CC0", VA = "0x1850A32C0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x50A36E0", Offset = "0x50A20E0", VA = "0x1850A36E0", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x50A3580", Offset = "0x50A1F80", VA = "0x1850A3580", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x50A3320", Offset = "0x50A1D20", VA = "0x1850A3320", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class LGCQNHRJNGW<a> : LINHOWVFUBN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo WIAAFFAKCFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type VJEXQKKNIZJ;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6922680", Offset = "0x6921080", VA = "0x186922680")]
			public LGCQNHRJNGW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6922410", Offset = "0x6920E10", VA = "0x186922410", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6922500", Offset = "0x6920F00", VA = "0x186922500", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x69224B0", Offset = "0x6920EB0", VA = "0x1869224B0", Slot = "7")]
			public override void QSTCCTBXDQD(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x69224B0", Offset = "0x6920EB0", VA = "0x1869224B0", Slot = "8")]
			public override void MHQMHLBLONI(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x69222A0", Offset = "0x6920CA0", VA = "0x1869222A0", Slot = "9")]
			public override void CMARJVDOIXE(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x69222A0", Offset = "0x6920CA0", VA = "0x1869222A0", Slot = "10")]
			public override void ZOCLZKLCWCR(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class TSIBOWZXVMT<a> : LGCQNHRJNGW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B57DE0", Offset = "0x7B567E0", VA = "0x187B57DE0")]
			public TSIBOWZXVMT(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x7B57AA0", Offset = "0x7B564A0", VA = "0x187B57AA0", Slot = "5")]
			public override void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x7B57D70", Offset = "0x7B56770", VA = "0x187B57D70", Slot = "6")]
			public override void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BWNWYDAGBHP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BWNWYDAGBHP<a> LDHSFMFGGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly LINHOWVFUBN<a>[] CTREGFFMPNW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int ZVOLBDYDIWZ;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4F19A80", Offset = "0x4F18480", VA = "0x184F19A80")]
			public BWNWYDAGBHP(List<LINHOWVFUBN<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F199D0", Offset = "0x4F183D0", VA = "0x184F199D0")]
			public void SISZBYWUTCR(a a, HSNKFEDGGUG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F19770", Offset = "0x4F18170", VA = "0x184F19770")]
			public void DWMISJDBTWO(a a, LUQYATNJAPE b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class SJBUDIHCLER
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract LINHOWVFUBN<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private HSNKFEDGGUG FVGHAKMPFXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int LCPHQUSLGOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, SJBUDIHCLER> IHUISQDCGYE;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8A692A0", Offset = "0x8A67CA0", VA = "0x188A692A0")]
		public LYJTWFFXCXP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE0650", Offset = "0x3BDF050", VA = "0x183BE0650")]
		private BWNWYDAGBHP<d> UOMWEFCKSPY<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF7B0", Offset = "0x3BDE1B0", VA = "0x183BDF7B0")]
		public void GZVUEGYMGMP<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF6F0", Offset = "0x3BDE0F0", VA = "0x183BDF6F0")]
		public bool Deserialize<T>(LUQYATNJAPE reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF670", Offset = "0x3BDE070", VA = "0x183BDF670")]
		public void BGVSXQNQAUM<f>(HSNKFEDGGUG a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class ENWPNYEPXMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime QFLGGHCWCXR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] ZTZFZBTKJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator EWRRIOBZXXX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A60210", Offset = "0x8A5EC10", VA = "0x188A60210")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int RCZQBLCXCMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FCD0", Offset = "0x8A5E6D0", VA = "0x188A5FCD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FD00", Offset = "0x8A5E700", VA = "0x188A5FD00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode HBFTZFMHXCV
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A604B0", Offset = "0x8A5EEB0", VA = "0x188A604B0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A60240", Offset = "0x8A5EC40", VA = "0x188A60240")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int WUXJVCEDXVE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FC10", Offset = "0x8A5E610", VA = "0x188A5FC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint ALNUSPNPUDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A601B0", Offset = "0x8A5EBB0", VA = "0x188A601B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? XTUILXLDAFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F860", Offset = "0x8A5E260", VA = "0x188A5F860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? CMSXRDCOFBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FC40", Offset = "0x8A5E640", VA = "0x188A5FC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? RCXABKLLBFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FDF0", Offset = "0x8A5E7F0", VA = "0x188A5FDF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F6A0", Offset = "0x8A5E0A0", VA = "0x188A5F6A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? AYGJAOSQGTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF4EC80", Offset = "0xF4D680", VA = "0x180F4EC80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A607A0", Offset = "0x8A5F1A0", VA = "0x188A607A0")]
		public ENWPNYEPXMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A60700", Offset = "0x8A5F100", VA = "0x188A60700")]
		internal ENWPNYEPXMI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A60280", Offset = "0x8A5EC80", VA = "0x188A60280")]
		public static ENWPNYEPXMI QTHQXQBJXKG(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F890", Offset = "0x8A5E290", VA = "0x188A5F890")]
		internal void BBIPSJEEYTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FE20", Offset = "0x8A5E820", VA = "0x188A5FE20")]
		private void ILLLCDVFASL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FFE0", Offset = "0x8A5E9E0", VA = "0x188A5FFE0")]
		private DateTime? JAENJORIJYZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A604E0", Offset = "0x8A5EEE0", VA = "0x188A604E0")]
		private void ZJUHHREDXQF(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FD40", Offset = "0x8A5E740", VA = "0x188A5FD40")]
		private ulong GLMYIZCKALH(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A60390", Offset = "0x8A5ED90", VA = "0x188A60390")]
		private void SQNJJQLNZLX(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FC70", Offset = "0x8A5E670", VA = "0x188A5FC70")]
		private uint CMVAZOSGNRI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8921C90", Offset = "0x8920690", VA = "0x188921C90")]
		private static uint TXOJZMVFWAV(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A60450", Offset = "0x8A5EE50", VA = "0x188A60450")]
		private static ulong TXOJZMVFWAV(ulong a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum NtpLeapIndicator
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		NoWarning,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		LastMinuteHas61Seconds,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		LastMinuteHas59Seconds,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		AlarmCondition
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum NtpMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Client = 3,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Server
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal sealed class DLESYOQMZPL
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int PQDXJJWZGSG = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int TLMPWUGIDZV = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int FJIOEAKLHBW = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint XORUYHFLJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int QRMNFTHYOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int VTIODPIJTGS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NEEENYCGLWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F440", Offset = "0x8A5DE40", VA = "0x188A5F440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F450", Offset = "0x8A5DE50", VA = "0x188A5F450")]
		public bool RXBHTTODHVW(WKKNWIOZJWM a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class KEVYSQWDZZP : WKKNWIOZJWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket PFXVGPGHMBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly CCTOFGXGRWY QXACBPNSEXS;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8A67490", Offset = "0x8A65E90", VA = "0x188A67490", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int IOQVICFDKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8A674B0", Offset = "0x8A65EB0", VA = "0x188A674B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint OGFTDRHEWHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8A674D0", Offset = "0x8A65ED0", VA = "0x188A674D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily LDMKYLUBREW
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32BBB30", Offset = "0x32BA530", VA = "0x1832BBB30", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A674F0", Offset = "0x8A65EF0", VA = "0x188A674F0")]
		public KEVYSQWDZZP(AddressFamily a, CCTOFGXGRWY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8A66D80", Offset = "0x8A65780", VA = "0x188A66D80", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8A67360", Offset = "0x8A65D60", VA = "0x188A67360", Slot = "9")]
		public int DKMHJAIDLZX(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8A673A0", Offset = "0x8A65DA0", VA = "0x188A673A0", Slot = "10")]
		public int EAXIICUCCUD(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8A67340", Offset = "0x8A65D40", VA = "0x188A67340", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface WKKNWIOZJWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short KBPLVEBKAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int IOQVICFDKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint OGFTDRHEWHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily LDMKYLUBREW
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode);

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "5")]
		int DKMHJAIDLZX(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int EAXIICUCCUD(byte[] a, EndPoint b);

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Close();
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal readonly struct NativeAddr : IEquatable<NativeAddr>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly long _part1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly long _part2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly long _part3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly int _part4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private readonly int _hash;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B0C0", Offset = "0x8A69AC0", VA = "0x188A6B0C0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B160", Offset = "0x8A69B60", VA = "0x188A6B160")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1620320", Offset = "0x161ED20", VA = "0x181620320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AFD0", Offset = "0x8A699D0", VA = "0x188A6AFD0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B010", Offset = "0x8A69A10", VA = "0x188A6B010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class NativeEndPoint : IPEndPoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public readonly byte[] NativeAddress;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class XBVVASIKIDT
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string XEXJSDXAYDH = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int CANTKQTIJYH = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int SAHKUEUZUCN = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int MASUYCIUIIJ = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> WZDZVSKUSNO;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback XBHHZKIPVEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int BUJCPTSEDRJ;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		internal void ZTICFUODRDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		internal void UVPVXLQVMNZ(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JZGSZEAVDXU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int YFVUIQHRRGV;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
		protected JZGSZEAVDXU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void WPFTLQKXJHW(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void QCMCLJSPTFZ(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KZLVRDLDNMC : JZGSZEAVDXU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] WBDMRGPRNOV;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator ALKCAXELTXZ;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3580", Offset = "0x2BA1F80", VA = "0x182BA3580")]
		public KZLVRDLDNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A68360", Offset = "0x8A66D60", VA = "0x188A68360")]
		public void SQVJVFJCUWA(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A67F80", Offset = "0x8A66980", VA = "0x188A67F80")]
		public void CDDLZPLTDGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A68510", Offset = "0x8A66F10", VA = "0x188A68510", Slot = "4")]
		public override void WPFTLQKXJHW(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A68060", Offset = "0x8A66A60", VA = "0x188A68060", Slot = "5")]
		public override void QCMCLJSPTFZ(IPEndPoint a, byte[] b, int c, int d)
		{
		}
	}
}
namespace LiteNetLib.Layers.Ciphers
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	internal struct RabbitCipher
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void Encrypt_000002A7$PostfixBurstDelegate([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class JHKKUYOAWCV
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr LZCUBCGCEZV;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DE60", Offset = "0x8A6C860", VA = "0x188A6DE60")]
			[BurstDiscard]
			private static void DLIEWRUGLGL(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E240", Offset = "0x8A6CC40", VA = "0x188A6E240")]
			private static IntPtr JTCUYQYXPHF()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6DFF0", Offset = "0x8A6C9F0", VA = "0x188A6DFF0")]
			public unsafe static void Invoke([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private unsafe fixed uint key[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private unsafe fixed uint iv[2];

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private unsafe fixed uint X[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private unsafe fixed uint S[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private unsafe fixed uint C[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private unsafe fixed uint old_C[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private unsafe fixed uint A[8];

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private uint carry;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private unsafe fixed uint g[8];

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D600", Offset = "0x8A6C000", VA = "0x188A6D600")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D0F0", Offset = "0x8A6BAF0", VA = "0x188A6D0F0")]
		private uint BNVQMUBANCY(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A56600", Offset = "0x8A55000", VA = "0x188A56600")]
		private void EZIJFBTZETB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A567B0", Offset = "0x8A551B0", VA = "0x188A567B0")]
		private void UEDIGOTUHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A56570", Offset = "0x8A54F70", VA = "0x188A56570")]
		private void BHATTAKBCOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A566B0", Offset = "0x8A550B0", VA = "0x188A566B0")]
		private void NBKPYBYXROG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D730", Offset = "0x8A6C130", VA = "0x188A6D730")]
		private void YDKBKJOJGHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D1E0", Offset = "0x8A6BBE0", VA = "0x188A6D1E0")]
		private unsafe void KTPBJKYQYNE(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D120", Offset = "0x8A6BB20", VA = "0x188A6D120")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void EHINQLBBEXB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D130", Offset = "0x8A6BB30", VA = "0x188A6D130")]
		public static void EHINQLBBEXB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D680", Offset = "0x8A6C080", VA = "0x188A6D680")]
		public static void WGMXAXLYZDR(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A6D790", Offset = "0x8A6C190", VA = "0x188A6D790")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void ZPOZWYFBWEO([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8A6E3C0", Offset = "0x8A6CDC0", VA = "0x188A6E3C0")]
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
