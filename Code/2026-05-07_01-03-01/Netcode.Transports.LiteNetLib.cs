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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ZMMVXGBZURY
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
		private NetworkManager VGYHIIGDQLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ZUGJDUSTZVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, TIMYJXHKVCH> KWLMJHNAOGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private UBNRAMBMBKO PYPYRIAWWKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch JPWRETECFZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] WBKPWKMOINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType OHMVVMRJFVA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TWPMDXEWHKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A35750", Offset = "0x8A34150", VA = "0x188A35750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A35700", Offset = "0x8A34100", VA = "0x188A35700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A34940", Offset = "0x8A33340", VA = "0x188A34940")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A34920", Offset = "0x8A33320", VA = "0x188A34920")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A34670", Offset = "0x8A33070", VA = "0x188A34670")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A35540", Offset = "0x8A33F40", VA = "0x188A35540")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A34D10", Offset = "0x8A33710", VA = "0x188A34D10", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A34830", Offset = "0x8A33230", VA = "0x188A34830", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A34FE0", Offset = "0x8A339E0", VA = "0x188A34FE0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A35320", Offset = "0x8A33D20", VA = "0x188A35320", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A341E0", Offset = "0x8A32BE0", VA = "0x188A341E0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A340F0", Offset = "0x8A32AF0", VA = "0x188A340F0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A343C0", Offset = "0x8A32DC0", VA = "0x188A343C0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A34F70", Offset = "0x8A33970", VA = "0x188A34F70", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A34460", Offset = "0x8A32E60", VA = "0x188A34460", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A34760", Offset = "0x8A33160", VA = "0x188A34760")]
		private DeliveryMethod PMSASDDZNLZ(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A34A50", Offset = "0x8A33450", VA = "0x188A34A50", Slot = "16")]
		private void SXCUYPEORUI(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A342F0", Offset = "0x8A32CF0", VA = "0x188A342F0", Slot = "17")]
		private void EJSYHAHQMGC(TIMYJXHKVCH a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "18")]
		private void UJLDHAEVYIZ(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A34B10", Offset = "0x8A33510", VA = "0x188A34B10", Slot = "19")]
		private void SXFZZPMBDLQ(TIMYJXHKVCH a, MZUGSVMLVMQ b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A35560", Offset = "0x8A33F60", VA = "0x188A35560")]
		private void ZSAIVLVUAEZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "20")]
		private void VWUCSTUNITG(IPEndPoint a, MZUGSVMLVMQ b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
		private void IYKVVNWHRBC(TIMYJXHKVCH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A348C0", Offset = "0x8A332C0", VA = "0x188A348C0", Slot = "22")]
		private void RFOQBLRVIRM(DLWFWHWSKSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A34870", Offset = "0x8A33270", VA = "0x188A34870")]
		private ulong QKSDWPEZAPD(TIMYJXHKVCH a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A348A0", Offset = "0x8A332A0", VA = "0x188A348A0")]
		private ulong QKSDWPEZAPD(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A340A0", Offset = "0x8A32AA0", VA = "0x188A340A0")]
		private static int DITYSUMCHTU(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A35630", Offset = "0x8A34030", VA = "0x188A35630")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A340C0", Offset = "0x8A32AC0", VA = "0x188A340C0")]
		[CompilerGenerated]
		private void ROWERVOABAK(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A340C0", Offset = "0x8A32AC0", VA = "0x188A340C0")]
		[CompilerGenerated]
		private void DTNETFJFCWH(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class TQWCSWIQAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly TIMYJXHKVCH BWPIIBQDSVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<HWKCXZMZNEH> BKGCRIGHGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int ATSCNZTWHZO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ABLDIRKFYAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C320", Offset = "0x8A3AD20", VA = "0x188A3C320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C490", Offset = "0x8A3AE90", VA = "0x188A3C490")]
		protected TQWCSWIQAII(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C430", Offset = "0x8A3AE30", VA = "0x188A3C430")]
		public void QVHTRBGHSMV(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C370", Offset = "0x8A3AD70", VA = "0x188A3C370")]
		protected void GFMTVYBLGXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C3F0", Offset = "0x8A3ADF0", VA = "0x188A3C3F0")]
		public bool NXCUTXOJWKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool NMEBGKNATGY();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool SRGYDNZFHJH(HWKCXZMZNEH a);
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
	public class DLWFWHWSKSB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly UBNRAMBMBKO OEJBNSWRJXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CPIZDGFOQCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal RROSNJSTLTC WEVYORZYPZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint OGEZTDWKNHN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult QYXPWVJMNON
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1625A70", Offset = "0x1624470", VA = "0x181625A70")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1625A60", Offset = "0x1624460", VA = "0x181625A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A317C0", Offset = "0x8A301C0", VA = "0x188A317C0")]
		internal void DLAAWUHOSJA(RROSNJSTLTC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A31820", Offset = "0x8A30220", VA = "0x188A31820")]
		private bool SPZDXXAETUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A31850", Offset = "0x8A30250", VA = "0x188A31850")]
		internal DLWFWHWSKSB(IPEndPoint a, RROSNJSTLTC b, UBNRAMBMBKO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A31760", Offset = "0x8A30160", VA = "0x188A31760")]
		public TIMYJXHKVCH Accept()
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
		public MZUGSVMLVMQ AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ZMMVXGBZURY
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IWJOLXFYDVO(TIMYJXHKVCH a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PWGYSDSXYOC(TIMYJXHKVCH a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KYSQFRPTXFT(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YNCQVFMHKSW(TIMYJXHKVCH a, MZUGSVMLVMQ b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OIDPAWCMONK(IPEndPoint a, MZUGSVMLVMQ b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UKJNULAHMDK(TIMYJXHKVCH a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QXGCQXPTAPI(DLWFWHWSKSB a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SZJVTTIZRWJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FZWDPHAOOVK(TIMYJXHKVCH a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface WSPSASPPUBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JNLBJHDEDBI(WJNNHGYGOFI a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface QGMZQLSUITV
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ABEQANHTJJH(TIMYJXHKVCH a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class RROSNJSTLTC
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int RRXXMZCSYEY = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long PGARIQRUJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte ZDULRGJXQZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] MUSVIQGXGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly YSTOHTMRBVK JYJRJZUXYDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int RIHXEFVZSFD;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A37A90", Offset = "0x8A36490", VA = "0x188A37A90")]
		private RROSNJSTLTC(long a, byte b, int c, byte[] d, YSTOHTMRBVK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A37690", Offset = "0x8A36090", VA = "0x188A37690")]
		public static int BODXLSEOYKF(HWKCXZMZNEH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A376C0", Offset = "0x8A360C0", VA = "0x188A376C0")]
		public static RROSNJSTLTC FXAFTCQCGOA(HWKCXZMZNEH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A378B0", Offset = "0x8A362B0", VA = "0x188A378B0")]
		public static HWKCXZMZNEH HGHKLSJJEIG(AMLBQLXGWMI a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class EMFWASLFCIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long PGARIQRUJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte ZDULRGJXQZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int RIHXEFVZSFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool JWUJOGEAZRM;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A31BB0", Offset = "0x8A305B0", VA = "0x188A31BB0")]
		private EMFWASLFCIT(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A318C0", Offset = "0x8A302C0", VA = "0x188A318C0")]
		public static EMFWASLFCIT FXAFTCQCGOA(HWKCXZMZNEH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A319C0", Offset = "0x8A303C0", VA = "0x188A319C0")]
		public static HWKCXZMZNEH HGHKLSJJEIG(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A31AB0", Offset = "0x8A304B0", VA = "0x188A31AB0")]
		public static HWKCXZMZNEH XQZIVBHAOBW(TIMYJXHKVCH a)
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
	public interface KNFWBTPQQNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XBPPNBYFTGR(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OVVZMCDVNUP(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class QBUONKTEBDL
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
		private class DYWSOVCXWOB
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint BPTAOGHCZFH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string RKVLDHKLRBL
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public DYWSOVCXWOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class YOYDQXHRLYH
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint BPTAOGHCZFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint DARJRUGKZAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string RKVLDHKLRBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public YOYDQXHRLYH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class TKVBCABTFXP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string RKVLDHKLRBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool OWAUAKKREDV
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xCD5F00", Offset = "0xCD4900", VA = "0x180CD5F00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TKVBCABTFXP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly UBNRAMBMBKO YBDJPEPBBTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> GMBWKVFBBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> PCIQVYMCIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly YSTOHTMRBVK IQFYEVWNGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly AMLBQLXGWMI CPEIPDNFBQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly WFGGOIMPZLD MEAMNECBTSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private KNFWBTPQQNM TDACGDRJOEI;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int SOLWPTVNVYL = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool LCMMYZZFAPK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A37140", Offset = "0x8A35B40", VA = "0x188A37140")]
		internal QBUONKTEBDL(UBNRAMBMBKO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A36CB0", Offset = "0x8A356B0", VA = "0x188A36CB0")]
		internal void KGGUZMYMYVO(IPEndPoint a, HWKCXZMZNEH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E300", Offset = "0x3E1CD00", VA = "0x183E1E300")]
		private void GIRGWOTPPCC<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A36FC0", Offset = "0x8A359C0", VA = "0x188A36FC0")]
		private void XBPPNBYFTGR(DYWSOVCXWOB a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A36B50", Offset = "0x8A35550", VA = "0x188A36B50")]
		private void GYWNVYIJBLV(YOYDQXHRLYH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A36E30", Offset = "0x8A35830", VA = "0x188A36E30")]
		private void RRHILDOPJYY(TKVBCABTFXP a, IPEndPoint b)
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
	public static class DHRLEVWFMSM
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] FHFSDUCBGIF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int XHXRLXEDDMX;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int KRZOPOLPTZQ;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32E00", Offset = "0x8A31800", VA = "0x188A32E00")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32E00", Offset = "0x8A31800", VA = "0x188A32E00")]
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
	public interface RWCFVWPHWXA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HOSNPQPRZTM(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class MMXGOHAOCYG
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static RWCFVWPHWXA NQUYRTUWWJO;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object DNPDWWGMCGI;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A35E30", Offset = "0x8A34830", VA = "0x188A35E30")]
		private static void APVYZAEEHPV(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A36060", Offset = "0x8A34A60", VA = "0x188A36060")]
		internal static void BCXLYHIIMVJ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A36120", Offset = "0x8A34B20", VA = "0x188A36120")]
		internal static void OHAFWZIPQJT(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A360C0", Offset = "0x8A34AC0", VA = "0x188A360C0")]
		internal static void ECHFTVCLHGL(string a, params object[] args)
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
	public sealed class MZUGSVMLVMQ : YSTOHTMRBVK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private HWKCXZMZNEH YUPNGAICOTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly UBNRAMBMBKO IRSDOLPYZZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly KROGGBFFGIN URBXLXITLSW;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A36350", Offset = "0x8A34D50", VA = "0x188A36350")]
		internal MZUGSVMLVMQ(UBNRAMBMBKO a, KROGGBFFGIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A362B0", Offset = "0x8A34CB0", VA = "0x188A362B0")]
		internal void NYHZELGMFRL(HWKCXZMZNEH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A36230", Offset = "0x8A34C30", VA = "0x188A36230")]
		internal void KRMMMXSRYFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A36320", Offset = "0x8A34D20", VA = "0x188A36320")]
		public void VRKXHHSDKQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class KROGGBFFGIN
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
		public KROGGBFFGIN EEMQUSMSXGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType MERZPCICCKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public TIMYJXHKVCH BWPIIBQDSVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint OGEZTDWKNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object QHFPOEOEZUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int RSORUMTPLUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError WZSNZDOJWGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason KMWRLWUBEQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DLWFWHWSKSB DLWFWHWSKSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod RXBWBQFFYVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte ISEUWMQSJDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly MZUGSVMLVMQ LKGACUFISWD;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A33840", Offset = "0x8A32240", VA = "0x188A33840")]
		public KROGGBFFGIN(UBNRAMBMBKO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class UBNRAMBMBKO : IEnumerable<TIMYJXHKVCH>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class PMPUUMLKZHB : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8A36800", Offset = "0x8A35200", VA = "0x188A36800", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A36870", Offset = "0x8A35270", VA = "0x188A36870", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public PMPUUMLKZHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<TIMYJXHKVCH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly TIMYJXHKVCH _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private TIMYJXHKVCH _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public TIMYJXHKVCH Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D6D650", Offset = "0x1D6C050", VA = "0x181D6D650")]
			public NetPeerEnumerator(TIMYJXHKVCH p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A36770", Offset = "0x8A35170", VA = "0x188A36770", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A367C0", Offset = "0x8A351C0", VA = "0x188A367C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread KYQZNIEIBQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool FIFJRCTJKNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool GSHRFWQDVUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private FMOKRDRDFBR DKRYRJKJUHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent IKJVFNAQOWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<KROGGBFFGIN> FMOHANGAKSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<KROGGBFFGIN> GGSYSJPHBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KROGGBFFGIN FEBRTZMAHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly ZMMVXGBZURY CQCSTXBPBRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly SZJVTTIZRWJ LBQRYKEMABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly WSPSASPPUBP IHDSIVOOFUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly QGMZQLSUITV ZQCTNHCCKLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, TIMYJXHKVCH> AUEJEFXTMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, DLWFWHWSKSB> HYCBNXMYRQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, PXDCSXNYGTR> HRJGFURIQQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim MQTSUQJGWWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TIMYJXHKVCH JFHDJGRPUPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int NHERGRGMBYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<TIMYJXHKVCH> NOYESAIRVSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TIMYJXHKVCH[] WUYCIQCZZEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly VMZBQHSHGGY JMZQQUONTSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int RRNLBIWTZJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> HSSIQAKYZMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte BENRVVUAXCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object SPSLDQZAUTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool WZEKMPVFGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool WXMUCFKRVGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int KKMPCJMHDEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int GRDOZRMKHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int WMMLRLYHGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int HHNTJMAGYKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool NDGOGDTRBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool FZFTPNNZNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int NQWGOHHEEXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int YURQMYCTBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int AERKXTHHJYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool LCMMYZZFAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool GEHOUROFJVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool KAMKJMYDLGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool BWBDLUVYKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int TPPAAXBMTCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int OARXOHNCQJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool CEAPBAQXARC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly KWZMJJOGVWM IJMHYQMWRFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool JUNAHJWEWNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly QBUONKTEBDL QBUONKTEBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool FPINBWILIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode TQSCCYDOSLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int XIHZWWLGCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool AWZNMCYLLTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool FLYNXGZKJPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool XZBFHANTJWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool DUEBGBWWGZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private HWKCXZMZNEH WFHXZELPFWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int HAMDDERCPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object JMDIFZMJVJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private HWKCXZMZNEH PTNATNQIXLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int YGWGSKUMEFT;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int DPBJSLWVCRB = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int GEDIJHVVSGQ = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private QWUPXYTCJBQ PCTXOQXBTSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private QWUPXYTCJBQ PDELJEKWMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread YTTHWXNPCYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread YUDVRLBJVUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint QJOUTBBAYUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint QJZINOOVRRQ;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] KLGNXGYCTVK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] KCKVKPPQXYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> XXUYHTPHTIN;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress JQGBURKLEJE;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool JHGPOTTLXHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int XFLIVXIYNCG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ZTMGEHKILBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE54E10", Offset = "0xE53810", VA = "0x180E54E10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE52AB0", Offset = "0xE514B0", VA = "0x180E52AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int SBDNLXDNWNW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x22230D0", Offset = "0x2221AD0", VA = "0x1822230D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x233B1A0", Offset = "0x2339BA0", VA = "0x18233B1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte HMBTUXSTXNN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDEB7D0", Offset = "0xDEA1D0", VA = "0x180DEB7D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int IGKCIEJRXCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DF70", Offset = "0x8A3C970", VA = "0x188A3DF70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short WNEPFAJMIUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D9C0", Offset = "0x8A3C3C0", VA = "0x188A3D9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event TIMYJXHKVCH.OnUpdatedMtuDelegate GCOCNNAPMOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A3CB90", Offset = "0x8A3B590", VA = "0x188A3CB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C6A0", Offset = "0x8A3B0A0", VA = "0x188A3C6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E960", Offset = "0x8A3D360", VA = "0x188A3E960")]
		public void JMOEKSAVAKC(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FBD0", Offset = "0x8A3E5D0", VA = "0x188A3FBD0")]
		public void QIDAQFYRKSX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D4C0", Offset = "0x8A3BEC0", VA = "0x188A3D4C0")]
		private bool GJMFEVEAYQP(IPEndPoint a, [Out] TIMYJXHKVCH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EB80", Offset = "0x8A3D580", VA = "0x188A3EB80")]
		private void KQBZNQNKXWH(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DF90", Offset = "0x8A3C990", VA = "0x188A3DF90")]
		private void IEKNURCEPZC(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EFB0", Offset = "0x8A3D9B0", VA = "0x188A3EFB0")]
		private void LQPQIXNVFNL(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A43E30", Offset = "0x8A42830", VA = "0x188A43E30")]
		public UBNRAMBMBKO(ZMMVXGBZURY a, [Optional] VMZBQHSHGGY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D3E0", Offset = "0x8A3BDE0", VA = "0x188A3D3E0")]
		internal void FMBJCBOGGEJ(TIMYJXHKVCH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C750", Offset = "0x8A3B150", VA = "0x188A3C750")]
		internal void CQDNZZJKUAB(TIMYJXHKVCH a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DDB0", Offset = "0x8A3C7B0", VA = "0x188A3DDB0")]
		internal void HNJXNXCZCAF(TIMYJXHKVCH a, DisconnectReason b, SocketError c, HWKCXZMZNEH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D560", Offset = "0x8A3BF60", VA = "0x188A3D560")]
		private void GVFETUZRUGK(TIMYJXHKVCH a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, HWKCXZMZNEH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C7A0", Offset = "0x8A3B1A0", VA = "0x188A3C7A0")]
		private void CRNLJAIQFCQ(KROGGBFFGIN.EType a, [Optional] TIMYJXHKVCH b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] DLWFWHWSKSB g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] HWKCXZMZNEH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A41870", Offset = "0x8A40270", VA = "0x188A41870")]
		private void UXPPWMEXZYH(KROGGBFFGIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3EEA0", Offset = "0x8A3D8A0", VA = "0x188A3EEA0")]
		internal void LOBHECCAJGL(KROGGBFFGIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A42320", Offset = "0x8A40D20", VA = "0x188A42320")]
		private void YAHSQFLXQPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DA80", Offset = "0x8A3C480", VA = "0x188A3DA80")]
		private void HDHTLUOFSRN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F2D0", Offset = "0x8A3DCD0", VA = "0x188A3F2D0")]
		internal TIMYJXHKVCH PPMLRCPRUEA(DLWFWHWSKSB a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A422A0", Offset = "0x8A40CA0", VA = "0x188A422A0")]
		private int XHUKXXWZSIQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A40190", Offset = "0x8A3EB90", VA = "0x188A40190")]
		private void SFLOCHTYMQK(IPEndPoint a, TIMYJXHKVCH b, RROSNJSTLTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A428C0", Offset = "0x8A412C0", VA = "0x188A428C0")]
		private void ZMQXCWJDKFN(HWKCXZMZNEH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FD20", Offset = "0x8A3E720", VA = "0x188A3FD20")]
		internal void RDCTTAXFRPF(HWKCXZMZNEH a, DeliveryMethod b, byte c, int d, TIMYJXHKVCH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A40B10", Offset = "0x8A3F510", VA = "0x188A40B10")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A41310", Offset = "0x8A3FD10", VA = "0x188A41310")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A40B20", Offset = "0x8A3F520", VA = "0x188A40B20")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A43BC0", Offset = "0x8A425C0", VA = "0x188A43BC0")]
		public void ZMTZTKIMQOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CD20", Offset = "0x8A3B720", VA = "0x188A3CD20")]
		public TIMYJXHKVCH Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CC40", Offset = "0x8A3B640", VA = "0x188A3CC40")]
		public TIMYJXHKVCH Connect(string address, int port, AMLBQLXGWMI connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CE00", Offset = "0x8A3B800", VA = "0x188A3CE00")]
		public TIMYJXHKVCH Connect(IPEndPoint target, AMLBQLXGWMI connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A41690", Offset = "0x8A40090", VA = "0x188A41690")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A41330", Offset = "0x8A3FD30", VA = "0x188A41330")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D2A0", Offset = "0x8A3BCA0", VA = "0x188A3D2A0")]
		public void DJUEPVUYNER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D1D0", Offset = "0x8A3BBD0", VA = "0x188A3D1D0")]
		public void DJUEPVUYNER(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D940", Offset = "0x8A3C340", VA = "0x188A3D940")]
		public void GVFETUZRUGK(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D980", Offset = "0x8A3C380", VA = "0x188A3D980")]
		public void GVFETUZRUGK(TIMYJXHKVCH a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D430", Offset = "0x8A3BE30", VA = "0x188A3D430", Slot = "4")]
		private IEnumerator<TIMYJXHKVCH> GFDWWISPBFT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D350", Offset = "0x8A3BD50", VA = "0x188A3D350", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A416A0", Offset = "0x8A400A0", VA = "0x188A416A0")]
		private HWKCXZMZNEH UJZCUHQTNPV(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A41790", Offset = "0x8A40190", VA = "0x188A41790")]
		private HWKCXZMZNEH UJZCUHQTNPV(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A42680", Offset = "0x8A41080", VA = "0x188A42680")]
		internal HWKCXZMZNEH YDQVIDGPVVQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A42030", Offset = "0x8A40A30", VA = "0x188A42030")]
		internal void VBHBTPIQXBR(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A43D70", Offset = "0x8A42770", VA = "0x188A43D70")]
		static UBNRAMBMBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE54E10", Offset = "0xE53810", VA = "0x180E54E10")]
		private bool CZMMUFTRAGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DFF0", Offset = "0x8A3C9F0", VA = "0x188A3DFF0")]
		private void IRZUASLKHGM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A409C0", Offset = "0x8A3F3C0", VA = "0x188A409C0")]
		private void SZUBVGBRBBJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FFF0", Offset = "0x8A3E9F0", VA = "0x188A3FFF0")]
		private bool SBSJVAKNJUJ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CB70", Offset = "0x8A3B570", VA = "0x188A3CB70")]
		private void CWPPXNIQVVY(FMOKRDRDFBR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F910", Offset = "0x8A3E310", VA = "0x188A3F910")]
		private void PTRAQSDZGMP(QWUPXYTCJBQ a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A40630", Offset = "0x8A3F030", VA = "0x188A40630")]
		private void SOSKMIOKQKR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A40BA0", Offset = "0x8A3F5A0", VA = "0x188A40BA0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A3F270", Offset = "0x8A3DC70", VA = "0x188A3F270")]
		internal int OQAIOSHAOMO(HWKCXZMZNEH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E920", Offset = "0x8A3D320", VA = "0x188A3E920")]
		internal int JFVQZOVMSFK(HWKCXZMZNEH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A3E150", Offset = "0x8A3CB50", VA = "0x188A3E150")]
		internal int JFVQZOVMSFK(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DDF0", Offset = "0x8A3C7F0", VA = "0x188A3DDF0")]
		internal void HYJVZSRQBSZ(bool a)
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
	internal sealed class HWKCXZMZNEH
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int HQJPNELNWYQ;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] CHIKZXZBKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] AJUFNVZTGES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int QJKZWMHVCXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object QHFPOEOEZUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HWKCXZMZNEH EEMQUSMSXGV;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty ZKCBLCFMUPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8A32960", Offset = "0x8A31360", VA = "0x188A32960")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A32530", Offset = "0x8A30F30", VA = "0x188A32530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte ZDULRGJXQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A32830", Offset = "0x8A31230", VA = "0x188A32830")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A325F0", Offset = "0x8A30FF0", VA = "0x188A325F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort LHRCIMYJMRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8A32990", Offset = "0x8A31390", VA = "0x188A32990")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A32570", Offset = "0x8A30F70", VA = "0x188A32570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool UWRQYAETXPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A32490", Offset = "0x8A30E90", VA = "0x188A32490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte LJUGZLEDBXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A327E0", Offset = "0x8A311E0", VA = "0x188A327E0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A32750", Offset = "0x8A31150", VA = "0x188A32750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort AXRYCIPGDFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32630", Offset = "0x8A31030", VA = "0x188A32630")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A325B0", Offset = "0x8A30FB0", VA = "0x188A325B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort XAKPYNFPNEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A32780", Offset = "0x8A31180", VA = "0x188A32780")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8A327A0", Offset = "0x8A311A0", VA = "0x188A327A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort PXHICAEZSSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A32810", Offset = "0x8A31210", VA = "0x188A32810")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A324F0", Offset = "0x8A30EF0", VA = "0x188A324F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A329B0", Offset = "0x8A313B0", VA = "0x188A329B0")]
		static HWKCXZMZNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A324C0", Offset = "0x8A30EC0", VA = "0x188A324C0")]
		public void ANQZBSWQTTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C80", Offset = "0x8A31680", VA = "0x188A32C80")]
		public HWKCXZMZNEH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A32CF0", Offset = "0x8A316F0", VA = "0x188A32CF0")]
		public HWKCXZMZNEH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A326E0", Offset = "0x8A310E0", VA = "0x188A326E0")]
		public static int KJOGGLGTNWE(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32650", Offset = "0x8A31050", VA = "0x188A32650")]
		public int KJOGGLGTNWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32860", Offset = "0x8A31260", VA = "0x188A32860")]
		public bool SPNZPERNJNL()
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
	public class TIMYJXHKVCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class HAUWKUBJUKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public HWKCXZMZNEH[] RIFQJAUBOMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int DSYUOZMBZAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int ARNFJOVCHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte LJUGZLEDBXI;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public HAUWKUBJUKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int HRGXWVIIIHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int LYCYOATRSOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int PPNIUMQEAZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double IATWDIZBHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int ONDIMBKHUFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int CDDVGBDHFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int DRNCOAFUQCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch GSVEWSRCDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int YNOFEYPJYXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long CKSFGBSQUXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object DZTTEVGFHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal TIMYJXHKVCH PSPQVQRHIAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal TIMYJXHKVCH OPQEPPOKQKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<HWKCXZMZNEH> MUZZPOPZBNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<TQWCSWIQAII> DMMFJFNLBTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly TQWCSWIQAII[] CCBGNOFFQMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int DJCJKHMKBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int RUXKZTWMFZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool QMHSAVUWBBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int PLDAXULWHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int IIWJTNJFGUD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int KFWQDJLUOLZ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int ZKADPZBMUBS = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object LEFUWOOCEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int EVBODIRSLWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, HAUWKUBJUKN> VNGWWDXYXXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> GUXLOXRXTAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly HWKCXZMZNEH OAUSWIDIVZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int APNVBEEMZMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int WGGNLWDURNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint IAJKLGKTVGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int JVVRDNGGEAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int PXELQGLYUDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long QZGDPLNFUFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte XABJKBHDNST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState WCCWDIIROTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private HWKCXZMZNEH DBSMEUXOPKT;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int LLEUZHQESYJ = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int FEUQEIOOSWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly HWKCXZMZNEH EGAWHEZFUCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly HWKCXZMZNEH YWMOZKTEYTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly HWKCXZMZNEH NTMZDHBFIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly HWKCXZMZNEH VIWEGMWBWNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality VZWYZMYQTGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly UBNRAMBMBKO UBNRAMBMBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int LVYPECRPQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object GFFFTRADSEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly KWZMJJOGVWM IJMHYQMWRFB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte YLXFFGDAZTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCFE120", Offset = "0xCFCB20", VA = "0x180CFE120")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A387F0", Offset = "0x8A371F0", VA = "0x188A387F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint VJUTQYSNLYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE4FC70", Offset = "0xE4E670", VA = "0x180E4FC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState NYJJRWZNEHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1479570", Offset = "0x1477F70", VA = "0x181479570")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long HHKVPKBFBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCDABC0", Offset = "0xCD95C0", VA = "0x180CDABC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int OFBLEBRYIYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x22230D0", Offset = "0x2221AD0", VA = "0x1822230D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x233B1A0", Offset = "0x2339BA0", VA = "0x18233B1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BPXXPXEWOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A38EF0", Offset = "0x8A378F0", VA = "0x188A38EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int CLSJKKWPCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCEED60", Offset = "0xCED760", VA = "0x180CEED60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double XINCZQPQFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AB6A00", Offset = "0x2AB5400", VA = "0x182AB6A00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate GCOCNNAPMOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A38740", Offset = "0x8A37140", VA = "0x188A38740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A38210", Offset = "0x8A36C10", VA = "0x188A38210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BF20", Offset = "0x8A3A920", VA = "0x188A3BF20")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A38F60", Offset = "0x8A37960", VA = "0x188A38F60")]
		internal void KRWRQNJGOTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A39540", Offset = "0x8A37F40", VA = "0x188A39540")]
		internal void SFXKEFOJWSO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A392A0", Offset = "0x8A37CA0", VA = "0x188A392A0")]
		internal void RSKRGMETSMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B4F0", Offset = "0x8A39EF0", VA = "0x188A3B4F0")]
		private void WTLIVQZCNNK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A39260", Offset = "0x8A37C60", VA = "0x188A39260")]
		private void QTMXMOJCBAM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A382C0", Offset = "0x8A36CC0", VA = "0x188A382C0")]
		public int AGESFUPSIYS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A383D0", Offset = "0x8A36DD0", VA = "0x188A383D0")]
		public int AGESFUPSIYS(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A39570", Offset = "0x8A37F70", VA = "0x188A39570")]
		private TQWCSWIQAII SPJJQCPRFHZ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BD90", Offset = "0x8A3A790", VA = "0x188A3BD90")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, IPEndPoint b, int c, byte d, AMLBQLXGWMI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BBB0", Offset = "0x8A3A5B0", VA = "0x188A3BBB0")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, DLWFWHWSKSB b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A39330", Offset = "0x8A37D30", VA = "0x188A39330")]
		internal void Reject(RROSNJSTLTC requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A38F80", Offset = "0x8A37980", VA = "0x188A38F80")]
		internal bool KWNAENIHMPD(EMFWASLFCIT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A38990", Offset = "0x8A37390", VA = "0x188A38990")]
		public void GIRGWOTPPCC(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B5C0", Offset = "0x8A39FC0", VA = "0x188A3B5C0")]
		private void YGADVOMHRVJ(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A388A0", Offset = "0x8A372A0", VA = "0x188A388A0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A388F0", Offset = "0x8A372F0", VA = "0x188A388F0")]
		internal DisconnectResult EGBXVYENMJN(HWKCXZMZNEH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A38F00", Offset = "0x8A37900", VA = "0x188A38F00")]
		internal void JCUCISBKSKE(TQWCSWIQAII a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A39EF0", Offset = "0x8A388F0", VA = "0x188A39EF0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A38700", Offset = "0x8A37100", VA = "0x188A38700")]
		private void CSAUTAXNVJP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AC60", Offset = "0x8A39660", VA = "0x188A3AC60")]
		internal void VGEWTDEZBPP(DeliveryMethod a, HWKCXZMZNEH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A389C0", Offset = "0x8A373C0", VA = "0x188A389C0")]
		private void GWRUXRROEYD(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A200", Offset = "0x8A38C00", VA = "0x188A3A200")]
		private void TPFBJZRMKWT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A39380", Offset = "0x8A37D80", VA = "0x188A39380")]
		internal ConnectRequestResult SFLOCHTYMQK(RROSNJSTLTC a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A39700", Offset = "0x8A38100", VA = "0x188A39700")]
		internal void SRGYDNZFHJH(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A39DA0", Offset = "0x8A387A0", VA = "0x188A39DA0")]
		private void SZILAHKFQUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A384F0", Offset = "0x8A36EF0", VA = "0x188A384F0")]
		internal void AHRPIAKYRER(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A590", Offset = "0x8A38F90", VA = "0x188A3A590")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A39000", Offset = "0x8A37A00", VA = "0x188A39000")]
		internal void PPXSKPUPEIH(HWKCXZMZNEH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class KWZMJJOGVWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long DYOMFOLFCKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long WLUDRSYTQGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long KDYAXQILRVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long HQQZVEZYLCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long MLESBIRPQPE;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long JHROBTTKYVT;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long GLTNEISMESI;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long VASTPTNBOKH;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long FYJFEKIUVMS;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long RWFTVUDMFRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long FYLGKJYRXOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long QYVLWQPBSWG;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long TNYOQCDBUNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A339C0", Offset = "0x8A323C0", VA = "0x188A339C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long HMUPWUSGKGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A34030", Offset = "0x8A32A30", VA = "0x188A34030")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long JTVVOUGXMYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A33CF0", Offset = "0x8A326F0", VA = "0x188A33CF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long RWGNAYKKWNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A339E0", Offset = "0x8A323E0", VA = "0x188A339E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long XHPFZNOTXKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A339D0", Offset = "0x8A323D0", VA = "0x188A339D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long FBKUCORNDTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A339B0", Offset = "0x8A323B0", VA = "0x188A339B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long NFQNCECRKYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A33C40", Offset = "0x8A32640", VA = "0x188A33C40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long HVFURJTFUKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A33B20", Offset = "0x8A32520", VA = "0x188A33B20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality TQQHQFNGHTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x14045E0", Offset = "0x1402FE0", VA = "0x1814045E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double NZARBQQIZVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A338E0", Offset = "0x8A322E0", VA = "0x188A338E0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A33C00", Offset = "0x8A32600", VA = "0x188A33C00")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A33A40", Offset = "0x8A32440", VA = "0x188A33A40")]
		public void KTNGOXAPFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A339F0", Offset = "0x8A323F0", VA = "0x188A339F0")]
		public void KMPTNEGSWIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A33940", Offset = "0x8A32340", VA = "0x188A33940")]
		public void EJODYSWAWAA(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A33C80", Offset = "0x8A32680", VA = "0x188A33C80")]
		public void TKIKZVINPRD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A34040", Offset = "0x8A32A40", VA = "0x188A34040")]
		public void ZVUFJHEZNYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8A33AA0", Offset = "0x8A324A0", VA = "0x188A33AA0")]
		public void MDTWVTDMGOI(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8A33D00", Offset = "0x8A32700", VA = "0x188A33D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A33B60", Offset = "0x8A32560", VA = "0x188A33B60")]
		public void RDVYDYRQSTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KWZMJJOGVWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class MLEQXSNXGHS
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> VZBFAGATNJL;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8A35B60", Offset = "0x8A34560", VA = "0x188A35B60")]
		public static IPEndPoint ZKFQTQNTDOD(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A35960", Offset = "0x8A34360", VA = "0x188A35960")]
		public static IPAddress CXYEYYEJGDC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A358D0", Offset = "0x8A342D0", VA = "0x188A358D0")]
		public static IPAddress CXYEYYEJGDC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A35B30", Offset = "0x8A34530", VA = "0x188A35B30")]
		internal static int XTPFLHUQQOI(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F060", Offset = "0x3C2DA60", VA = "0x183C2F060")]
		internal static T[] ZQNFHFRPTIV<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class CQOVEHYRLVH : TQWCSWIQAII
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private HWKCXZMZNEH _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8A36A50", Offset = "0x8A35450", VA = "0x188A36A50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A36AC0", Offset = "0x8A354C0", VA = "0x188A36AC0")]
			public void VQZGAVQPNPU(HWKCXZMZNEH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8A36AE0", Offset = "0x8A354E0", VA = "0x188A36AE0")]
			public bool XDHWEDXMHBB(long a, TIMYJXHKVCH b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A36A00", Offset = "0x8A35400", VA = "0x188A36A00")]
			public bool Clear(TIMYJXHKVCH peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly HWKCXZMZNEH EMNETPXGQSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] SWZCCOOVERX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly HWKCXZMZNEH[] WEYAXYXFMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] LHTXCKNGBIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int XVYZFMMCRBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int NLIPTRGLSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int QGYVKMCAJUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int KBGUTFSSPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool WXJBRJPUOZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod PSDCXRPIOZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LRUYJDYMMTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int PLJUXSNHHBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte UVUKOKJGVHK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int GFNMJAKGXQD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8A30EB0", Offset = "0x8A2F8B0", VA = "0x188A30EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8A314C0", Offset = "0x8A2FEC0", VA = "0x188A314C0")]
		public CQOVEHYRLVH(TIMYJXHKVCH a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8A30660", Offset = "0x8A2F060", VA = "0x188A30660")]
		private void ISWDGWYJESC(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A309E0", Offset = "0x8A2F3E0", VA = "0x188A309E0", Slot = "4")]
		protected override bool NMEBGKNATGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A30EC0", Offset = "0x8A2F8C0", VA = "0x188A30EC0", Slot = "5")]
		public override bool SRGYDNZFHJH(HWKCXZMZNEH a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class FMWYCXSXRSG : TQWCSWIQAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int PPMJZYDVWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort NLIPTRGLSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool FFIESZYCOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private HWKCXZMZNEH FZHJADQIMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly HWKCXZMZNEH KCFCPQMWNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool TEPXNPALVYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte UVUKOKJGVHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long NTEBOCIUNUO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8A323D0", Offset = "0x8A30DD0", VA = "0x188A323D0")]
		public FMWYCXSXRSG(TIMYJXHKVCH a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8A31C90", Offset = "0x8A30690", VA = "0x188A31C90", Slot = "4")]
		protected override bool NMEBGKNATGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8A32150", Offset = "0x8A30B50", VA = "0x188A32150", Slot = "5")]
		public override bool SRGYDNZFHJH(HWKCXZMZNEH a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class RKPVBWJMRKP
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
		[Cpp2IlInjected.Address(RVA = "0x8A2F2E0", Offset = "0x8A2DCE0", VA = "0x188A2F2E0")]
		private static void OLFDHSKPQLO(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8A37570", Offset = "0x8A35F70", VA = "0x188A37570")]
		private static void OLFDHSKPQLO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8A37530", Offset = "0x8A35F30", VA = "0x188A37530")]
		public static void OLFDHSKPQLO(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A37670", Offset = "0x8A36070", VA = "0x188A37670")]
		public static void GMMDUBYWKNB(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A375F0", Offset = "0x8A35FF0", VA = "0x188A375F0")]
		public static void GMMDUBYWKNB(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A37530", Offset = "0x8A35F30", VA = "0x188A37530")]
		public static void GMMDUBYWKNB(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A37530", Offset = "0x8A35F30", VA = "0x188A37530")]
		public static void GMMDUBYWKNB(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A37570", Offset = "0x8A35F70", VA = "0x188A37570")]
		public static void GMMDUBYWKNB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8A37570", Offset = "0x8A35F70", VA = "0x188A37570")]
		public static void GMMDUBYWKNB(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8A375E0", Offset = "0x8A35FE0", VA = "0x188A375E0")]
		public static void GMMDUBYWKNB(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8A375E0", Offset = "0x8A35FE0", VA = "0x188A375E0")]
		public static void GMMDUBYWKNB(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class YSTOHTMRBVK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] JQQLQPAMKVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int GRGJYHWTZPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int WIJYVBEJYKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int HBWGVJDCZYK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] AJUFNVZTGES
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BTLIKQSQWXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CFWUHSMFGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8A467C0", Offset = "0x8A451C0", VA = "0x188A467C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DYXLBJXCAVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A22380", Offset = "0x2A20D80", VA = "0x182A22380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int PRAISOUCPHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8A46470", Offset = "0x8A44E70", VA = "0x188A46470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8A46710", Offset = "0x8A45110", VA = "0x188A46710")]
		public void NYHZELGMFRL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public YSTOHTMRBVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8A46BA0", Offset = "0x8A455A0", VA = "0x188A46BA0")]
		public YSTOHTMRBVK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8A467D0", Offset = "0x8A451D0", VA = "0x188A467D0")]
		public IPEndPoint VXQNSJOFEAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8A466D0", Offset = "0x8A450D0", VA = "0x188A466D0")]
		public byte NOADVRABVOS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A466D0", Offset = "0x8A450D0", VA = "0x188A466D0")]
		public sbyte WXMZWRYNXEH()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4116DD0", Offset = "0x41157D0", VA = "0x184116DD0")]
		public a[] ITGNGIWUUCZ<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8A464F0", Offset = "0x8A44EF0", VA = "0x188A464F0")]
		public bool[] EAGKTNLDZPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8A468A0", Offset = "0x8A452A0", VA = "0x188A468A0")]
		public ushort[] YKOWQLGLUWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A46620", Offset = "0x8A45020", VA = "0x188A46620")]
		public short[] KGAPCNPUFKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8A465B0", Offset = "0x8A44FB0", VA = "0x188A465B0")]
		public int[] HVFESDXDOSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8A46860", Offset = "0x8A45260", VA = "0x188A46860")]
		public uint[] WBPDARORNIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8A464B0", Offset = "0x8A44EB0", VA = "0x188A464B0")]
		public float[] DZGKJYWFBBV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8A46570", Offset = "0x8A44F70", VA = "0x188A46570")]
		public double[] GSFMQRWRYAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8A46690", Offset = "0x8A45090", VA = "0x188A46690")]
		public long[] NDZVPJIBWKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A46430", Offset = "0x8A44E30", VA = "0x188A46430")]
		public ulong[] DADHVQKVOYS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8A46310", Offset = "0x8A44D10", VA = "0x188A46310")]
		public string[] AAWLWWQXKYC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A46530", Offset = "0x8A44F30", VA = "0x188A46530")]
		public bool GPSPSLKAWSU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8A46660", Offset = "0x8A45060", VA = "0x188A46660")]
		public char VCMPZJKXPGM()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8A46660", Offset = "0x8A45060", VA = "0x188A46660")]
		public ushort KKAGJSESNDV()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A46660", Offset = "0x8A45060", VA = "0x188A46660")]
		public short RPLWSJTIZDQ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A465F0", Offset = "0x8A44FF0", VA = "0x188A465F0")]
		public long IVXTURTHPRA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A465F0", Offset = "0x8A44FF0", VA = "0x188A465F0")]
		public ulong JCULMSRZJKZ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A46480", Offset = "0x8A44E80", VA = "0x188A46480")]
		public int DLJDDQLZGLD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A46480", Offset = "0x8A44E80", VA = "0x188A46480")]
		public uint FBUWRCKTCSM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8A463E0", Offset = "0x8A44DE0", VA = "0x188A463E0")]
		public float BLTYKOCWILM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A46750", Offset = "0x8A45150", VA = "0x188A46750")]
		public double QKJWRXLLSBD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8A46990", Offset = "0x8A45390", VA = "0x188A46990")]
		public string ZXWWRLSIAEB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A46920", Offset = "0x8A45320", VA = "0x188A46920")]
		public ArraySegment<byte> ZEGMOJMHFYI(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A468E0", Offset = "0x8A452E0", VA = "0x188A468E0")]
		public sbyte[] ZEAQHZNMZVO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A46780", Offset = "0x8A45180", VA = "0x188A46780")]
		public byte[] RPCJRKSMDJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A46410", Offset = "0x8A44E10", VA = "0x188A46410")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AMLBQLXGWMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] JQQLQPAMKVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int GRGJYHWTZPE;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int TGNZCWTQYWN = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool CFWXLRSJSEW;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding ZRKCPRIUVXI;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int WTSCGJOQXUX = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] PRCOJGFMHAK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8A30540", Offset = "0x8A2EF40", VA = "0x188A30540")]
		public AMLBQLXGWMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8A305C0", Offset = "0x8A2EFC0", VA = "0x188A305C0")]
		public AMLBQLXGWMI(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8A30450", Offset = "0x8A2EE50", VA = "0x188A30450")]
		public static AMLBQLXGWMI YYHLVKUHUBL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F820", Offset = "0x8A2E220", VA = "0x188A2F820")]
		public void JKETWGWSYYP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AB60", Offset = "0x2A99560", VA = "0x182A9AB60")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FA60", Offset = "0x8A2E460", VA = "0x188A2FA60")]
		public void RNTOHSCHSKJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FED0", Offset = "0x8A2E8D0", VA = "0x188A2FED0")]
		public void RNTOHSCHSKJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FB70", Offset = "0x8A2E570", VA = "0x188A2FB70")]
		public void RNTOHSCHSKJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FB70", Offset = "0x8A2E570", VA = "0x188A2FB70")]
		public void RNTOHSCHSKJ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FC20", Offset = "0x8A2E620", VA = "0x188A2FC20")]
		public void RNTOHSCHSKJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FC20", Offset = "0x8A2E620", VA = "0x188A2FC20")]
		public void RNTOHSCHSKJ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F8C0", Offset = "0x8A2E2C0", VA = "0x188A2F8C0")]
		public void RNTOHSCHSKJ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F8C0", Offset = "0x8A2E2C0", VA = "0x188A2F8C0")]
		public void RNTOHSCHSKJ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F8C0", Offset = "0x8A2E2C0", VA = "0x188A2F8C0")]
		public void RNTOHSCHSKJ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F930", Offset = "0x8A2E330", VA = "0x188A2F930")]
		public void RNTOHSCHSKJ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F930", Offset = "0x8A2E330", VA = "0x188A2F930")]
		public void RNTOHSCHSKJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FB00", Offset = "0x8A2E500", VA = "0x188A2FB00")]
		public void RNTOHSCHSKJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8A300E0", Offset = "0x8A2EAE0", VA = "0x188A300E0")]
		public void TQIVOEBWOUN(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8A300E0", Offset = "0x8A2EAE0", VA = "0x188A300E0")]
		public void TGOMIOCRLEM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FBC0", Offset = "0x8A2E5C0", VA = "0x188A2FBC0")]
		public void RNTOHSCHSKJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8A30370", Offset = "0x8A2ED70", VA = "0x188A30370")]
		public void TEGHYSPDUTI(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8A30000", Offset = "0x8A2EA00", VA = "0x188A30000")]
		public void TEGHYSPDUTI(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FF20", Offset = "0x8A2E920", VA = "0x188A2FF20")]
		public void TEGHYSPDUTI(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FF20", Offset = "0x8A2E920", VA = "0x188A2FF20")]
		public void TEGHYSPDUTI(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FF20", Offset = "0x8A2E920", VA = "0x188A2FF20")]
		public void TEGHYSPDUTI(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A30000", Offset = "0x8A2EA00", VA = "0x188A30000")]
		public void TEGHYSPDUTI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A30000", Offset = "0x8A2EA00", VA = "0x188A30000")]
		public void TEGHYSPDUTI(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A301C0", Offset = "0x8A2EBC0", VA = "0x188A301C0")]
		public void TEGHYSPDUTI(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8A301C0", Offset = "0x8A2EBC0", VA = "0x188A301C0")]
		public void TEGHYSPDUTI(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8A300E0", Offset = "0x8A2EAE0", VA = "0x188A300E0")]
		public void TEGHYSPDUTI(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A302A0", Offset = "0x8A2ECA0", VA = "0x188A302A0")]
		public void TEGHYSPDUTI(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F990", Offset = "0x8A2E390", VA = "0x188A2F990")]
		public void RNTOHSCHSKJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FCB0", Offset = "0x8A2E6B0", VA = "0x188A2FCB0")]
		public void RNTOHSCHSKJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FCC0", Offset = "0x8A2E6C0", VA = "0x188A2FCC0")]
		public void RNTOHSCHSKJ(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class WFGGOIMPZLD
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class MLLUAPEJMER<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong LVYPECRPQWF;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x6F79900", Offset = "0x6F78300", VA = "0x186F79900")]
			static MLLUAPEJMER()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(YSTOHTMRBVK reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class EIJLBRSJFEW<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public WFGGOIMPZLD AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a YLZDTXRKOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> IXEOHVCTWKW;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public EIJLBRSJFEW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5BE17E0", Offset = "0x5BE01E0", VA = "0x185BE17E0")]
			internal void HAYXUHOFWRL(YSTOHTMRBVK a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class GNJTQTDCZIC<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public WFGGOIMPZLD AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a YLZDTXRKOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> IXEOHVCTWKW;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public GNJTQTDCZIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6442FB0", Offset = "0x64419B0", VA = "0x186442FB0")]
			internal void HAYXUHOFWRL(YSTOHTMRBVK a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly ESISKMQOJAX BJTGQHAIBFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> JRVJXPHSYVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly AMLBQLXGWMI DXLNRSNCQNJ;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8A44DB0", Offset = "0x8A437B0", VA = "0x188A44DB0")]
		public WFGGOIMPZLD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40FA0F0", Offset = "0x40F8AF0", VA = "0x1840FA0F0", Slot = "4")]
		protected virtual ulong URAAGQKKVUE<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A44C60", Offset = "0x8A43660", VA = "0x188A44C60", Slot = "5")]
		protected virtual SubscribeDelegate VXZIESSPJLF(YSTOHTMRBVK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40FA070", Offset = "0x40F8A70", VA = "0x1840FA070", Slot = "6")]
		protected virtual void MDTRPITMTKT<b>(AMLBQLXGWMI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8A44D30", Offset = "0x8A43730", VA = "0x188A44D30")]
		public void YUGQXXUDZVO(YSTOHTMRBVK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x40F9FE0", Offset = "0x40F89E0", VA = "0x1840F9FE0")]
		public void HHMSAAQYDCT<j>(AMLBQLXGWMI a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A44C10", Offset = "0x8A43610", VA = "0x188A44C10")]
		public void TRFLKSMFPJS(YSTOHTMRBVK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40FA2F0", Offset = "0x40F8CF0", VA = "0x1840FA2F0")]
		public void ZRFEPWZYNOZ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x40FA2F0", Offset = "0x40F8CF0", VA = "0x1840FA2F0")]
		public void ZRFEPWZYNOZ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32E00", Offset = "0x8A31800", VA = "0x188A32E00")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8A369A0", Offset = "0x8A353A0", VA = "0x188A369A0")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class ESISKMQOJAX
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
		private abstract class KFCFUSFJVEF<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType MERZPCICCKQ;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6839510", Offset = "0x6837F10", VA = "0x186839510", Slot = "4")]
			public virtual void VQZGAVQPNPU(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void EDBAWLRQTGA(a a, YSTOHTMRBVK b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void HHMSAAQYDCT(a a, AMLBQLXGWMI b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void CCGGUHQANLD(a a, YSTOHTMRBVK b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void OMMWHSEAROY(a a, AMLBQLXGWMI b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void RCXMDCUEAZW(a a, YSTOHTMRBVK b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void CZXDQRUDGPF(a a, AMLBQLXGWMI b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			protected KFCFUSFJVEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class GNPAYXNVLAU<a, b> : KFCFUSFJVEF<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> LQIKMAAHQKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> JRZEEFCRAUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> LSTXRZVKHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> KPBSWKHOCSC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> UZSRKOLXJXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> OQMFOUWINKP;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x64431C0", Offset = "0x6441BC0", VA = "0x1864431C0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x64431C0", Offset = "0x6441BC0", VA = "0x1864431C0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x6443290", Offset = "0x6441C90", VA = "0x186443290", Slot = "9")]
			public override void RCXMDCUEAZW(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6443290", Offset = "0x6441C90", VA = "0x186443290", Slot = "10")]
			public override void CZXDQRUDGPF(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6443FB0", Offset = "0x64429B0", VA = "0x186443FB0")]
			protected b[] ZUDPRMNHCMV(a a, YSTOHTMRBVK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6443360", Offset = "0x6441D60", VA = "0x186443360")]
			protected b[] GZKHMYYNPZK(a a, AMLBQLXGWMI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x64434D0", Offset = "0x6441ED0", VA = "0x1864434D0", Slot = "4")]
			public override void VQZGAVQPNPU(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6444250", Offset = "0x6442C50", VA = "0x186444250")]
			protected GNPAYXNVLAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class JUPWNTUGIVB<a, b> : GNPAYXNVLAU<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void WMBRANZZXPG(YSTOHTMRBVK a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void OITUVRRQAQL(AMLBQLXGWMI a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x670EB70", Offset = "0x670D570", VA = "0x18670EB70", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x670EDF0", Offset = "0x670D7F0", VA = "0x18670EDF0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x670E980", Offset = "0x670D380", VA = "0x18670E980", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x670F220", Offset = "0x670DC20", VA = "0x18670F220", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x670F2C0", Offset = "0x670DCC0", VA = "0x18670F2C0")]
			protected JUPWNTUGIVB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class GGEFNVFFDIS<a> : GNPAYXNVLAU<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x64378B0", Offset = "0x64362B0", VA = "0x1864378B0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x6437A20", Offset = "0x6436420", VA = "0x186437A20", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6437760", Offset = "0x6436160", VA = "0x186437760", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x5092340", Offset = "0x5090D40", VA = "0x185092340", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x6437B60", Offset = "0x6436560", VA = "0x186437B60")]
			public GGEFNVFFDIS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class VMOGOJFGBPJ<a> : GNPAYXNVLAU<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x64378B0", Offset = "0x64362B0", VA = "0x1864378B0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x6437A20", Offset = "0x6436420", VA = "0x186437A20", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7EC9020", Offset = "0x7EC7A20", VA = "0x187EC9020", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x5092340", Offset = "0x5090D40", VA = "0x185092340", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public VMOGOJFGBPJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class CCJKREUFPSF<a> : GNPAYXNVLAU<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x51B42F0", Offset = "0x51B2CF0", VA = "0x1851B42F0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x51B4560", Offset = "0x51B2F60", VA = "0x1851B4560", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x51B42A0", Offset = "0x51B2CA0", VA = "0x1851B42A0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x51B46A0", Offset = "0x51B30A0", VA = "0x1851B46A0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public CCJKREUFPSF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class PAULHPIZDAY<a> : GNPAYXNVLAU<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x51B42F0", Offset = "0x51B2CF0", VA = "0x1851B42F0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x51B4560", Offset = "0x51B2F60", VA = "0x1851B4560", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x740CDD0", Offset = "0x740B7D0", VA = "0x18740CDD0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x51B46A0", Offset = "0x51B30A0", VA = "0x1851B46A0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public PAULHPIZDAY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class IPYPQPQOJWZ<a> : GNPAYXNVLAU<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x515E4A0", Offset = "0x515CEA0", VA = "0x18515E4A0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x515E610", Offset = "0x515D010", VA = "0x18515E610", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x65FCED0", Offset = "0x65FB8D0", VA = "0x1865FCED0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x515E750", Offset = "0x515D150", VA = "0x18515E750", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public IPYPQPQOJWZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class YCOQHBNSRGG<a> : GNPAYXNVLAU<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x515E4A0", Offset = "0x515CEA0", VA = "0x18515E4A0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x515E610", Offset = "0x515D010", VA = "0x18515E610", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x515E450", Offset = "0x515CE50", VA = "0x18515E450", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x515E750", Offset = "0x515D150", VA = "0x18515E750", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public YCOQHBNSRGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class DJZYMRZSRMR<a> : GNPAYXNVLAU<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5483A40", Offset = "0x5482440", VA = "0x185483A40", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5483B90", Offset = "0x5482590", VA = "0x185483B90", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x54837D0", Offset = "0x54821D0", VA = "0x1854837D0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5483BD0", Offset = "0x54825D0", VA = "0x185483BD0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public DJZYMRZSRMR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class MGOVSKCLDEU<a> : GNPAYXNVLAU<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5483A40", Offset = "0x5482440", VA = "0x185483A40", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5483B90", Offset = "0x5482590", VA = "0x185483B90", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6F75650", Offset = "0x6F74050", VA = "0x186F75650", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5483BD0", Offset = "0x54825D0", VA = "0x185483BD0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public MGOVSKCLDEU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class XMYPVHNTRRP<a> : GNPAYXNVLAU<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x50920A0", Offset = "0x5090AA0", VA = "0x1850920A0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5092300", Offset = "0x5090D00", VA = "0x185092300", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x5091F50", Offset = "0x5090950", VA = "0x185091F50", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x5092340", Offset = "0x5090D40", VA = "0x185092340", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public XMYPVHNTRRP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class ADIVMDANWTM<a> : GNPAYXNVLAU<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x7218BA0", Offset = "0x72175A0", VA = "0x187218BA0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7218CF0", Offset = "0x72176F0", VA = "0x187218CF0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7218A40", Offset = "0x7217440", VA = "0x187218A40", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x515E750", Offset = "0x515D150", VA = "0x18515E750", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public ADIVMDANWTM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class MKEZUFMWFYP<a> : GNPAYXNVLAU<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6F76C10", Offset = "0x6F75610", VA = "0x186F76C10", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6F76C60", Offset = "0x6F75660", VA = "0x186F76C60", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6F76AA0", Offset = "0x6F754A0", VA = "0x186F76AA0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x5483BD0", Offset = "0x54825D0", VA = "0x185483BD0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5092480", Offset = "0x5090E80", VA = "0x185092480")]
			public MKEZUFMWFYP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class NRMFMFSRDMD<a> : JUPWNTUGIVB<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x71AD3E0", Offset = "0x71ABDE0", VA = "0x1871AD3E0", Slot = "12")]
			protected override void OITUVRRQAQL(AMLBQLXGWMI a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x71AD410", Offset = "0x71ABE10", VA = "0x1871AD410", Slot = "11")]
			protected override void WMBRANZZXPG(YSTOHTMRBVK a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x71AD440", Offset = "0x71ABE40", VA = "0x1871AD440")]
			public NRMFMFSRDMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class WQXQJIMWAFR<a> : JUPWNTUGIVB<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x85A8770", Offset = "0x85A7170", VA = "0x1885A8770", Slot = "12")]
			protected override void OITUVRRQAQL(AMLBQLXGWMI a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x85A87A0", Offset = "0x85A71A0", VA = "0x1885A87A0", Slot = "11")]
			protected override void WMBRANZZXPG(YSTOHTMRBVK a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x71AD440", Offset = "0x71ABE40", VA = "0x1871AD440")]
			public WQXQJIMWAFR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class BSHQTNXHTZQ<a> : GNPAYXNVLAU<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int MCGFZRKLWCR;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0150", Offset = "0x4ECEB50", VA = "0x184ED0150")]
			public BSHQTNXHTZQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4ECFE00", Offset = "0x4ECE800", VA = "0x184ECFE00", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4ECFE60", Offset = "0x4ECE860", VA = "0x184ECFE60", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4ECFC90", Offset = "0x4ECE690", VA = "0x184ECFC90", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4ECFFB0", Offset = "0x4ECE9B0", VA = "0x184ECFFB0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class XXQLAXDHDZW<a> : KFCFUSFJVEF<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo ZKCBLCFMUPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type PUWYYXQKJVH;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x50A3F60", Offset = "0x50A2960", VA = "0x1850A3F60")]
			public XXQLAXDHDZW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x50A3C20", Offset = "0x50A2620", VA = "0x1850A3C20", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x50A3DE0", Offset = "0x50A27E0", VA = "0x1850A3DE0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x50A3B80", Offset = "0x50A2580", VA = "0x1850A3B80", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x50A3B80", Offset = "0x50A2580", VA = "0x1850A3B80", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x50A3BD0", Offset = "0x50A25D0", VA = "0x1850A3BD0", Slot = "9")]
			public override void RCXMDCUEAZW(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x50A3BD0", Offset = "0x50A25D0", VA = "0x1850A3BD0", Slot = "10")]
			public override void CZXDQRUDGPF(a a, AMLBQLXGWMI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class WPJBSGSEAER<a> : XXQLAXDHDZW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x85A7C70", Offset = "0x85A6670", VA = "0x1885A7C70")]
			public WPJBSGSEAER(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x85A7930", Offset = "0x85A6330", VA = "0x1885A7930", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x85A7C00", Offset = "0x85A6600", VA = "0x1885A7C00", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class WZBNONTILUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static WZBNONTILUP<a> IWMDTGRRYAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly KFCFUSFJVEF<a>[] XWEUIONJKSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int LQEDRWHPVZV;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x85BE0D0", Offset = "0x85BCAD0", VA = "0x1885BE0D0")]
			public WZBNONTILUP(List<KFCFUSFJVEF<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x85BDF90", Offset = "0x85BC990", VA = "0x1885BDF90")]
			public void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x85BDD30", Offset = "0x85BC730", VA = "0x1885BDD30")]
			public void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class NIUGKNOYDSH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract KFCFUSFJVEF<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private AMLBQLXGWMI XBFSVBZSVDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int TDVMMQKNSCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, NIUGKNOYDSH> WNIHZQYBSIS;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8A31C00", Offset = "0x8A30600", VA = "0x188A31C00")]
		public ESISKMQOJAX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x395AD50", Offset = "0x3959750", VA = "0x18395AD50")]
		private WZBNONTILUP<d> MGFCAAEMNUM<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x395BB50", Offset = "0x395A550", VA = "0x18395BB50")]
		public void QCIVJGOFOSZ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3959E70", Offset = "0x3958870", VA = "0x183959E70")]
		public bool Deserialize<T>(YSTOHTMRBVK reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x395BB90", Offset = "0x395A590", VA = "0x18395BB90")]
		public void XQIXCNAGDPI<f>(AMLBQLXGWMI a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class WJNNHGYGOFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime ZZPADOGEXKB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] LGKVKYTNBED
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator HYJLVAKGNQP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A457B0", Offset = "0x8A441B0", VA = "0x188A457B0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int KQFKUAHSEFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A45380", Offset = "0x8A43D80", VA = "0x188A45380")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A453B0", Offset = "0x8A43DB0", VA = "0x188A453B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode GJZIEZBJWHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8A45CB0", Offset = "0x8A446B0", VA = "0x188A45CB0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A452E0", Offset = "0x8A43CE0", VA = "0x188A452E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int SHPRYTYVCHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A45C80", Offset = "0x8A44680", VA = "0x188A45C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint VNPRQFIRMBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A45EA0", Offset = "0x8A448A0", VA = "0x188A45EA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? USPEMYPDLTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A45320", Offset = "0x8A43D20", VA = "0x188A45320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? ZUOLIMGQNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A45350", Offset = "0x8A43D50", VA = "0x188A45350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? FHWNMCODTIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A453F0", Offset = "0x8A43DF0", VA = "0x188A453F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A45CE0", Offset = "0x8A446E0", VA = "0x188A45CE0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? QAPRLMMKVZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xD6A2B0", Offset = "0xD68CB0", VA = "0x180D6A2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF4A770", Offset = "0xF49170", VA = "0x180F4A770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A45F60", Offset = "0x8A44960", VA = "0x188A45F60")]
		public WJNNHGYGOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A46270", Offset = "0x8A44C70", VA = "0x188A46270")]
		internal WJNNHGYGOFI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A45B70", Offset = "0x8A44570", VA = "0x188A45B70")]
		public static WJNNHGYGOFI TTIKHGHWWBK(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A44F60", Offset = "0x8A43960", VA = "0x188A44F60")]
		internal void BJUNATBXQYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A457E0", Offset = "0x8A441E0", VA = "0x188A457E0")]
		private void RGYQHXXGJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A459A0", Offset = "0x8A443A0", VA = "0x188A459A0")]
		private DateTime? RITIBEMJFSH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A455F0", Offset = "0x8A43FF0", VA = "0x188A455F0")]
		private void QSKZIKXBZYH(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A45540", Offset = "0x8A43F40", VA = "0x188A45540")]
		private ulong LAPYAYMFKWT(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A45420", Offset = "0x8A43E20", VA = "0x188A45420")]
		private void HJWXZIGNSFJ(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8A454E0", Offset = "0x8A43EE0", VA = "0x188A454E0")]
		private uint JBSGVBQZHJG(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x88FA990", Offset = "0x88F9390", VA = "0x1888FA990")]
		private static uint BFVVLERJVUD(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A44F00", Offset = "0x8A43900", VA = "0x188A44F00")]
		private static ulong BFVVLERJVUD(ulong a)
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
	internal sealed class PXDCSXNYGTR
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int USHQFMGZROM = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int OHOJQVOKKZD = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int HBGKYMLUVRM = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint PWABZRBREDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int CLNEOXIRFUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int YASOMIDLOVS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool CCUAPMZRHUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8A368A0", Offset = "0x8A352A0", VA = "0x188A368A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A368B0", Offset = "0x8A352B0", VA = "0x188A368B0")]
		public bool GIRGWOTPPCC(QWUPXYTCJBQ a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class VPQKYESXPXR : QWUPXYTCJBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket IEAXEIAQXZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly UBNRAMBMBKO BNCVRCFQXMC;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short WNEPFAJMIUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8A44B00", Offset = "0x8A43500", VA = "0x188A44B00", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int ZZHFFPBUDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8A44B20", Offset = "0x8A43520", VA = "0x188A44B20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint BIUGUECDKLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8A44B40", Offset = "0x8A43540", VA = "0x188A44B40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily KIBFMUSJXAI
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32B8830", Offset = "0x32B7230", VA = "0x1832B8830", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A44B60", Offset = "0x8A43560", VA = "0x188A44B60")]
		public VPQKYESXPXR(AddressFamily a, UBNRAMBMBKO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8A44520", Offset = "0x8A42F20", VA = "0x188A44520", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8A443F0", Offset = "0x8A42DF0", VA = "0x188A443F0", Slot = "9")]
		public int AHMQEUIWNXF(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8A44430", Offset = "0x8A42E30", VA = "0x188A44430", Slot = "10")]
		public int BZYPQPJYCIR(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8A44AE0", Offset = "0x8A434E0", VA = "0x188A44AE0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface QWUPXYTCJBQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short WNEPFAJMIUI
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int ZZHFFPBUDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint BIUGUECDKLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily KIBFMUSJXAI
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
		int AHMQEUIWNXF(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int BZYPQPJYCIR(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x8A36490", Offset = "0x8A34E90", VA = "0x188A36490")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8A36530", Offset = "0x8A34F30", VA = "0x188A36530")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1625A70", Offset = "0x1624470", VA = "0x181625A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A363A0", Offset = "0x8A34DA0", VA = "0x188A363A0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A363E0", Offset = "0x8A34DE0", VA = "0x188A363E0", Slot = "0")]
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
	public class FMOKRDRDFBR
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string UHGKMHUDJUX = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int ZLMAHGDZRND = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int NPLIGAPUMAD = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int RSVQKFIMMUD = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> CKGGUQKOBXE;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback TUUISTRGUZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int VLZKXCJHXAR;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		internal void LMMZTNREZWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		internal void DBOUAYPEXYR(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class VMZBQHSHGGY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int IGKCIEJRXCD;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
		protected VMZBQHSHGGY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UGPGOODTUWO(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZVLKCELCXTL(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class KLYEORASVUQ : VMZBQHSHGGY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] OXRGMRPMYAT;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator YFSUWBIPMAR;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A660", Offset = "0x2B99060", VA = "0x182B9A660")]
		public KLYEORASVUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A32E10", Offset = "0x8A31810", VA = "0x188A32E10")]
		public void ALDXWDJNVNQ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A32FC0", Offset = "0x8A319C0", VA = "0x188A32FC0")]
		public void SZYRGXAMMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A330A0", Offset = "0x8A31AA0", VA = "0x188A330A0", Slot = "4")]
		public override void UGPGOODTUWO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A334E0", Offset = "0x8A31EE0", VA = "0x188A334E0", Slot = "5")]
		public override void ZVLKCELCXTL(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class IHDTRVTNGZN
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr PGKIETPGQPH;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8A47090", Offset = "0x8A45A90", VA = "0x188A47090")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8A46CC0", Offset = "0x8A456C0", VA = "0x188A46CC0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8A46E40", Offset = "0x8A45840", VA = "0x188A46E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A38100", Offset = "0x8A36B00", VA = "0x188A38100")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8A38180", Offset = "0x8A36B80", VA = "0x188A38180")]
		private uint XIKHEMXXNCK(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F560", Offset = "0x8A2DF60", VA = "0x188A2F560")]
		private void RJPALXGPLKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F610", Offset = "0x8A2E010", VA = "0x188A2F610")]
		private void VCNZQCRQZXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F3D0", Offset = "0x8A2DDD0", VA = "0x188A2F3D0")]
		private void GWWMAVOJSLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F460", Offset = "0x8A2DE60", VA = "0x188A2F460")]
		private void KOPMNYHVZVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A381B0", Offset = "0x8A36BB0", VA = "0x188A381B0")]
		private void ZOPQXKXCTZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A37CE0", Offset = "0x8A366E0", VA = "0x188A37CE0")]
		private unsafe void JCPNWNMOHBC(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8A37B00", Offset = "0x8A36500", VA = "0x188A37B00")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void DQHIXCDROGB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8A37B10", Offset = "0x8A36510", VA = "0x188A37B10")]
		public static void DQHIXCDROGB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8A37C30", Offset = "0x8A36630", VA = "0x188A37C30")]
		public static void FZSQZERSPNX(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8A37BC0", Offset = "0x8A365C0", VA = "0x188A37BC0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void DZHGZPZJTEA([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8A47220", Offset = "0x8A45C20", VA = "0x188A47220")]
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
