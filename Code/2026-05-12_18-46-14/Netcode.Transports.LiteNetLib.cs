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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAD6A0", Offset = "0x8BAC0A0", VA = "0x188BAD6A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BAD650", Offset = "0x8BAC050", VA = "0x188BAD650", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC840", Offset = "0x8BAB240", VA = "0x188BAC840")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC820", Offset = "0x8BAB220", VA = "0x188BAC820")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC570", Offset = "0x8BAAF70", VA = "0x188BAC570")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD490", Offset = "0x8BABE90", VA = "0x188BAD490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BACC10", Offset = "0x8BAB610", VA = "0x188BACC10", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC730", Offset = "0x8BAB130", VA = "0x188BAC730", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BACEE0", Offset = "0x8BAB8E0", VA = "0x188BACEE0", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD270", Offset = "0x8BABC70", VA = "0x188BAD270", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC0E0", Offset = "0x8BAAAE0", VA = "0x188BAC0E0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BABFF0", Offset = "0x8BAA9F0", VA = "0x188BABFF0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC2C0", Offset = "0x8BAACC0", VA = "0x188BAC2C0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BACE70", Offset = "0x8BAB870", VA = "0x188BACE70", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC360", Offset = "0x8BAAD60", VA = "0x188BAC360", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC660", Offset = "0x8BAB060", VA = "0x188BAC660")]
		private DeliveryMethod PMSASDDZNLZ(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC950", Offset = "0x8BAB350", VA = "0x188BAC950", Slot = "16")]
		private void SXCUYPEORUI(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC1F0", Offset = "0x8BAABF0", VA = "0x188BAC1F0", Slot = "17")]
		private void EJSYHAHQMGC(TIMYJXHKVCH a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "18")]
		private void UJLDHAEVYIZ(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BACA10", Offset = "0x8BAB410", VA = "0x188BACA10", Slot = "19")]
		private void SXFZZPMBDLQ(TIMYJXHKVCH a, MZUGSVMLVMQ b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD4B0", Offset = "0x8BABEB0", VA = "0x188BAD4B0")]
		private void ZSAIVLVUAEZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "20")]
		private void VWUCSTUNITG(IPEndPoint a, MZUGSVMLVMQ b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "21")]
		private void IYKVVNWHRBC(TIMYJXHKVCH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC7C0", Offset = "0x8BAB1C0", VA = "0x188BAC7C0", Slot = "22")]
		private void RFOQBLRVIRM(DLWFWHWSKSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC770", Offset = "0x8BAB170", VA = "0x188BAC770")]
		private ulong QKSDWPEZAPD(TIMYJXHKVCH a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC7A0", Offset = "0x8BAB1A0", VA = "0x188BAC7A0")]
		private ulong QKSDWPEZAPD(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BABFA0", Offset = "0x8BAA9A0", VA = "0x188BABFA0")]
		private static int DITYSUMCHTU(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD580", Offset = "0x8BABF80", VA = "0x188BAD580")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BABFC0", Offset = "0x8BAA9C0", VA = "0x188BABFC0")]
		[CompilerGenerated]
		private void ROWERVOABAK(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BABFC0", Offset = "0x8BAA9C0", VA = "0x188BABFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BB4220", Offset = "0x8BB2C20", VA = "0x188BB4220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4390", Offset = "0x8BB2D90", VA = "0x188BB4390")]
		protected TQWCSWIQAII(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4330", Offset = "0x8BB2D30", VA = "0x188BB4330")]
		public void QVHTRBGHSMV(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4270", Offset = "0x8BB2C70", VA = "0x188BB4270")]
		protected void GFMTVYBLGXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB42F0", Offset = "0x8BB2CF0", VA = "0x188BB42F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1656000", Offset = "0x1654A00", VA = "0x181656000")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1655FF0", Offset = "0x16549F0", VA = "0x181655FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9720", Offset = "0x8BA8120", VA = "0x188BA9720")]
		internal void DLAAWUHOSJA(RROSNJSTLTC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9780", Offset = "0x8BA8180", VA = "0x188BA9780")]
		private bool SPZDXXAETUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BA97B0", Offset = "0x8BA81B0", VA = "0x188BA97B0")]
		internal DLWFWHWSKSB(IPEndPoint a, RROSNJSTLTC b, UBNRAMBMBKO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BA96C0", Offset = "0x8BA80C0", VA = "0x188BA96C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAF9B0", Offset = "0x8BAE3B0", VA = "0x188BAF9B0")]
		private RROSNJSTLTC(long a, byte b, int c, byte[] d, YSTOHTMRBVK e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF5B0", Offset = "0x8BADFB0", VA = "0x188BAF5B0")]
		public static int BODXLSEOYKF(HWKCXZMZNEH a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF5E0", Offset = "0x8BADFE0", VA = "0x188BAF5E0")]
		public static RROSNJSTLTC FXAFTCQCGOA(HWKCXZMZNEH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF7D0", Offset = "0x8BAE1D0", VA = "0x188BAF7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BA9B10", Offset = "0x8BA8510", VA = "0x188BA9B10")]
		private EMFWASLFCIT(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9820", Offset = "0x8BA8220", VA = "0x188BA9820")]
		public static EMFWASLFCIT FXAFTCQCGOA(HWKCXZMZNEH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9920", Offset = "0x8BA8320", VA = "0x188BA9920")]
		public static HWKCXZMZNEH HGHKLSJJEIG(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9A10", Offset = "0x8BA8410", VA = "0x188BA9A10")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool OWAUAKKREDV
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xD0EF00", Offset = "0xD0D900", VA = "0x180D0EF00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAF060", Offset = "0x8BADA60", VA = "0x188BAF060")]
		internal QBUONKTEBDL(UBNRAMBMBKO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEBC0", Offset = "0x8BAD5C0", VA = "0x188BAEBC0")]
		internal void KGGUZMYMYVO(IPEndPoint a, HWKCXZMZNEH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E41A30", Offset = "0x3E40430", VA = "0x183E41A30")]
		private void GIRGWOTPPCC<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEED0", Offset = "0x8BAD8D0", VA = "0x188BAEED0")]
		private void XBPPNBYFTGR(DYWSOVCXWOB a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEA60", Offset = "0x8BAD460", VA = "0x188BAEA60")]
		private void GYWNVYIJBLV(YOYDQXHRLYH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAED40", Offset = "0x8BAD740", VA = "0x188BAED40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAAD40", Offset = "0x8BA9740", VA = "0x188BAAD40")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD40", Offset = "0x8BA9740", VA = "0x188BAAD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BADD50", Offset = "0x8BAC750", VA = "0x188BADD50")]
		private static void APVYZAEEHPV(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BADF80", Offset = "0x8BAC980", VA = "0x188BADF80")]
		internal static void BCXLYHIIMVJ(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE040", Offset = "0x8BACA40", VA = "0x188BAE040")]
		internal static void OHAFWZIPQJT(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BADFE0", Offset = "0x8BAC9E0", VA = "0x188BADFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAE260", Offset = "0x8BACC60", VA = "0x188BAE260")]
		internal MZUGSVMLVMQ(UBNRAMBMBKO a, KROGGBFFGIN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE1C0", Offset = "0x8BACBC0", VA = "0x188BAE1C0")]
		internal void NYHZELGMFRL(HWKCXZMZNEH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE140", Offset = "0x8BACB40", VA = "0x188BAE140")]
		internal void KRMMMXSRYFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE230", Offset = "0x8BACC30", VA = "0x188BAE230")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAB770", Offset = "0x8BAA170", VA = "0x188BAB770")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAE710", Offset = "0x8BAD110", VA = "0x188BAE710", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE780", Offset = "0x8BAD180", VA = "0x188BAE780", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
				[Cpp2IlInjected.Address(RVA = "0xF50610", Offset = "0xF4F010", VA = "0x180F50610", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF50610", Offset = "0xF4F010", VA = "0x180F50610", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D97550", Offset = "0x1D95F50", VA = "0x181D97550")]
			public NetPeerEnumerator(TIMYJXHKVCH p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE680", Offset = "0x8BAD080", VA = "0x188BAE680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE6D0", Offset = "0x8BAD0D0", VA = "0x188BAE6D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xE8D8C0", Offset = "0xE8C2C0", VA = "0x180E8D8C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE8B560", Offset = "0xE89F60", VA = "0x180E8B560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int SBDNLXDNWNW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2249A20", Offset = "0x2248420", VA = "0x182249A20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23583E0", Offset = "0x2356DE0", VA = "0x1823583E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte HMBTUXSTXNN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE21A20", Offset = "0xE20420", VA = "0x180E21A20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int IGKCIEJRXCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5E70", Offset = "0x8BB4870", VA = "0x188BB5E70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short WNEPFAJMIUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BB58C0", Offset = "0x8BB42C0", VA = "0x188BB58C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event TIMYJXHKVCH.OnUpdatedMtuDelegate GCOCNNAPMOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4A90", Offset = "0x8BB3490", VA = "0x188BB4A90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BB45A0", Offset = "0x8BB2FA0", VA = "0x188BB45A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6860", Offset = "0x8BB5260", VA = "0x188BB6860")]
		public void JMOEKSAVAKC(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7AD0", Offset = "0x8BB64D0", VA = "0x188BB7AD0")]
		public void QIDAQFYRKSX(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BB53C0", Offset = "0x8BB3DC0", VA = "0x188BB53C0")]
		private bool GJMFEVEAYQP(IPEndPoint a, [Out] TIMYJXHKVCH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6A80", Offset = "0x8BB5480", VA = "0x188BB6A80")]
		private void KQBZNQNKXWH(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5E90", Offset = "0x8BB4890", VA = "0x188BB5E90")]
		private void IEKNURCEPZC(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6EB0", Offset = "0x8BB58B0", VA = "0x188BB6EB0")]
		private void LQPQIXNVFNL(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBD40", Offset = "0x8BBA740", VA = "0x188BBBD40")]
		public UBNRAMBMBKO(ZMMVXGBZURY a, [Optional] VMZBQHSHGGY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BB52E0", Offset = "0x8BB3CE0", VA = "0x188BB52E0")]
		internal void FMBJCBOGGEJ(TIMYJXHKVCH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4650", Offset = "0x8BB3050", VA = "0x188BB4650")]
		internal void CQDNZZJKUAB(TIMYJXHKVCH a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5CB0", Offset = "0x8BB46B0", VA = "0x188BB5CB0")]
		internal void HNJXNXCZCAF(TIMYJXHKVCH a, DisconnectReason b, SocketError c, HWKCXZMZNEH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5460", Offset = "0x8BB3E60", VA = "0x188BB5460")]
		private void GVFETUZRUGK(TIMYJXHKVCH a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, HWKCXZMZNEH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB46A0", Offset = "0x8BB30A0", VA = "0x188BB46A0")]
		private void CRNLJAIQFCQ(KROGGBFFGIN.EType a, [Optional] TIMYJXHKVCH b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] DLWFWHWSKSB g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] HWKCXZMZNEH j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB97B0", Offset = "0x8BB81B0", VA = "0x188BB97B0")]
		private void UXPPWMEXZYH(KROGGBFFGIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6DA0", Offset = "0x8BB57A0", VA = "0x188BB6DA0")]
		internal void LOBHECCAJGL(KROGGBFFGIN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA230", Offset = "0x8BB8C30", VA = "0x188BBA230")]
		private void YAHSQFLXQPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5980", Offset = "0x8BB4380", VA = "0x188BB5980")]
		private void HDHTLUOFSRN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB71D0", Offset = "0x8BB5BD0", VA = "0x188BB71D0")]
		internal TIMYJXHKVCH PPMLRCPRUEA(DLWFWHWSKSB a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA1B0", Offset = "0x8BB8BB0", VA = "0x188BBA1B0")]
		private int XHUKXXWZSIQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8090", Offset = "0x8BB6A90", VA = "0x188BB8090")]
		private void SFLOCHTYMQK(IPEndPoint a, TIMYJXHKVCH b, RROSNJSTLTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA7D0", Offset = "0x8BB91D0", VA = "0x188BBA7D0")]
		private void ZMQXCWJDKFN(HWKCXZMZNEH a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7C20", Offset = "0x8BB6620", VA = "0x188BB7C20")]
		internal void RDCTTAXFRPF(HWKCXZMZNEH a, DeliveryMethod b, byte c, int d, TIMYJXHKVCH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8A00", Offset = "0x8BB7400", VA = "0x188BB8A00")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9260", Offset = "0x8BB7C60", VA = "0x188BB9260")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8A70", Offset = "0x8BB7470", VA = "0x188BB8A70")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBAD0", Offset = "0x8BBA4D0", VA = "0x188BBBAD0")]
		public void ZMTZTKIMQOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4C20", Offset = "0x8BB3620", VA = "0x188BB4C20")]
		public TIMYJXHKVCH Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4B40", Offset = "0x8BB3540", VA = "0x188BB4B40")]
		public TIMYJXHKVCH Connect(string address, int port, AMLBQLXGWMI connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4D00", Offset = "0x8BB3700", VA = "0x188BB4D00")]
		public TIMYJXHKVCH Connect(IPEndPoint target, AMLBQLXGWMI connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95E0", Offset = "0x8BB7FE0", VA = "0x188BB95E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9280", Offset = "0x8BB7C80", VA = "0x188BB9280")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB51A0", Offset = "0x8BB3BA0", VA = "0x188BB51A0")]
		public void DJUEPVUYNER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB50D0", Offset = "0x8BB3AD0", VA = "0x188BB50D0")]
		public void DJUEPVUYNER(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5840", Offset = "0x8BB4240", VA = "0x188BB5840")]
		public void GVFETUZRUGK(TIMYJXHKVCH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5880", Offset = "0x8BB4280", VA = "0x188BB5880")]
		public void GVFETUZRUGK(TIMYJXHKVCH a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5330", Offset = "0x8BB3D30", VA = "0x188BB5330", Slot = "4")]
		private IEnumerator<TIMYJXHKVCH> GFDWWISPBFT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5250", Offset = "0x8BB3C50", VA = "0x188BB5250", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BB95F0", Offset = "0x8BB7FF0", VA = "0x188BB95F0")]
		private HWKCXZMZNEH UJZCUHQTNPV(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BB96D0", Offset = "0x8BB80D0", VA = "0x188BB96D0")]
		private HWKCXZMZNEH UJZCUHQTNPV(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA590", Offset = "0x8BB8F90", VA = "0x188BBA590")]
		internal HWKCXZMZNEH YDQVIDGPVVQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BB9F50", Offset = "0x8BB8950", VA = "0x188BB9F50")]
		internal void VBHBTPIQXBR(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC80", Offset = "0x8BBA680", VA = "0x188BBBC80")]
		static UBNRAMBMBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE8D8C0", Offset = "0xE8C2C0", VA = "0x180E8D8C0")]
		private bool CZMMUFTRAGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5EF0", Offset = "0x8BB48F0", VA = "0x188BB5EF0")]
		private void IRZUASLKHGM(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB88B0", Offset = "0x8BB72B0", VA = "0x188BB88B0")]
		private void SZUBVGBRBBJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7EF0", Offset = "0x8BB68F0", VA = "0x188BB7EF0")]
		private bool SBSJVAKNJUJ(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4A70", Offset = "0x8BB3470", VA = "0x188BB4A70")]
		private void CWPPXNIQVVY(FMOKRDRDFBR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7800", Offset = "0x8BB6200", VA = "0x188BB7800")]
		private void PTRAQSDZGMP(QWUPXYTCJBQ a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8530", Offset = "0x8BB6F30", VA = "0x188BB8530")]
		private void SOSKMIOKQKR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8AF0", Offset = "0x8BB74F0", VA = "0x188BB8AF0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7170", Offset = "0x8BB5B70", VA = "0x188BB7170")]
		internal int OQAIOSHAOMO(HWKCXZMZNEH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6820", Offset = "0x8BB5220", VA = "0x188BB6820")]
		internal int JFVQZOVMSFK(HWKCXZMZNEH a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6050", Offset = "0x8BB4A50", VA = "0x188BB6050")]
		internal int JFVQZOVMSFK(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5CF0", Offset = "0x8BB46F0", VA = "0x188BB5CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAA8C0", Offset = "0x8BA92C0", VA = "0x188BAA8C0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA490", Offset = "0x8BA8E90", VA = "0x188BAA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte ZDULRGJXQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA790", Offset = "0x8BA9190", VA = "0x188BAA790")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA550", Offset = "0x8BA8F50", VA = "0x188BAA550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort LHRCIMYJMRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA8F0", Offset = "0x8BA92F0", VA = "0x188BAA8F0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA4D0", Offset = "0x8BA8ED0", VA = "0x188BAA4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool UWRQYAETXPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA3F0", Offset = "0x8BA8DF0", VA = "0x188BAA3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte LJUGZLEDBXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA740", Offset = "0x8BA9140", VA = "0x188BAA740")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA6B0", Offset = "0x8BA90B0", VA = "0x188BAA6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort AXRYCIPGDFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA590", Offset = "0x8BA8F90", VA = "0x188BAA590")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA510", Offset = "0x8BA8F10", VA = "0x188BAA510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort XAKPYNFPNEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA6E0", Offset = "0x8BA90E0", VA = "0x188BAA6E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA700", Offset = "0x8BA9100", VA = "0x188BAA700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort PXHICAEZSSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA770", Offset = "0x8BA9170", VA = "0x188BAA770")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BAA450", Offset = "0x8BA8E50", VA = "0x188BAA450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA910", Offset = "0x8BA9310", VA = "0x188BAA910")]
		static HWKCXZMZNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA420", Offset = "0x8BA8E20", VA = "0x188BAA420")]
		public void ANQZBSWQTTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BAABC0", Offset = "0x8BA95C0", VA = "0x188BAABC0")]
		public HWKCXZMZNEH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC30", Offset = "0x8BA9630", VA = "0x188BAAC30")]
		public HWKCXZMZNEH(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA640", Offset = "0x8BA9040", VA = "0x188BAA640")]
		public static int KJOGGLGTNWE(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA5B0", Offset = "0x8BA8FB0", VA = "0x188BAA5B0")]
		public int KJOGGLGTNWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA7C0", Offset = "0x8BA91C0", VA = "0x188BAA7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD37450", Offset = "0xD35E50", VA = "0x180D37450")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0700", Offset = "0x8BAF100", VA = "0x188BB0700")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint VJUTQYSNLYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE86FD0", Offset = "0xE859D0", VA = "0x180E86FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState NYJJRWZNEHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x149F910", Offset = "0x149E310", VA = "0x18149F910")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long HHKVPKBFBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD13BC0", Offset = "0xD125C0", VA = "0x180D13BC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int OFBLEBRYIYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2249A20", Offset = "0x2248420", VA = "0x182249A20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23583E0", Offset = "0x2356DE0", VA = "0x1823583E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int BPXXPXEWOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0DF0", Offset = "0x8BAF7F0", VA = "0x188BB0DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int CLSJKKWPCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD27F50", Offset = "0xD26950", VA = "0x180D27F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double XINCZQPQFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AD67D0", Offset = "0x2AD51D0", VA = "0x182AD67D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate GCOCNNAPMOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0650", Offset = "0x8BAF050", VA = "0x188BB0650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BB0130", Offset = "0x8BAEB30", VA = "0x188BB0130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3E20", Offset = "0x8BB2820", VA = "0x188BB3E20")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0E60", Offset = "0x8BAF860", VA = "0x188BB0E60")]
		internal void KRWRQNJGOTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1440", Offset = "0x8BAFE40", VA = "0x188BB1440")]
		internal void SFXKEFOJWSO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB11A0", Offset = "0x8BAFBA0", VA = "0x188BB11A0")]
		internal void RSKRGMETSMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB33F0", Offset = "0x8BB1DF0", VA = "0x188BB33F0")]
		private void WTLIVQZCNNK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1160", Offset = "0x8BAFB60", VA = "0x188BB1160")]
		private void QTMXMOJCBAM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB01E0", Offset = "0x8BAEBE0", VA = "0x188BB01E0")]
		public int AGESFUPSIYS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB02F0", Offset = "0x8BAECF0", VA = "0x188BB02F0")]
		public int AGESFUPSIYS(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1470", Offset = "0x8BAFE70", VA = "0x188BB1470")]
		private TQWCSWIQAII SPJJQCPRFHZ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3C90", Offset = "0x8BB2690", VA = "0x188BB3C90")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, IPEndPoint b, int c, byte d, AMLBQLXGWMI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3AB0", Offset = "0x8BB24B0", VA = "0x188BB3AB0")]
		internal TIMYJXHKVCH(UBNRAMBMBKO a, DLWFWHWSKSB b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1230", Offset = "0x8BAFC30", VA = "0x188BB1230")]
		internal void Reject(RROSNJSTLTC requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0E80", Offset = "0x8BAF880", VA = "0x188BB0E80")]
		internal bool KWNAENIHMPD(EMFWASLFCIT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB08A0", Offset = "0x8BAF2A0", VA = "0x188BB08A0")]
		public void GIRGWOTPPCC(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB34C0", Offset = "0x8BB1EC0", VA = "0x188BB34C0")]
		private void YGADVOMHRVJ(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB07B0", Offset = "0x8BAF1B0", VA = "0x188BB07B0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0800", Offset = "0x8BAF200", VA = "0x188BB0800")]
		internal DisconnectResult EGBXVYENMJN(HWKCXZMZNEH a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0E00", Offset = "0x8BAF800", VA = "0x188BB0E00")]
		internal void JCUCISBKSKE(TQWCSWIQAII a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1DF0", Offset = "0x8BB07F0", VA = "0x188BB1DF0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0610", Offset = "0x8BAF010", VA = "0x188BB0610")]
		private void CSAUTAXNVJP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2B60", Offset = "0x8BB1560", VA = "0x188BB2B60")]
		internal void VGEWTDEZBPP(DeliveryMethod a, HWKCXZMZNEH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB08D0", Offset = "0x8BAF2D0", VA = "0x188BB08D0")]
		private void GWRUXRROEYD(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2100", Offset = "0x8BB0B00", VA = "0x188BB2100")]
		private void TPFBJZRMKWT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1280", Offset = "0x8BAFC80", VA = "0x188BB1280")]
		internal ConnectRequestResult SFLOCHTYMQK(RROSNJSTLTC a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1600", Offset = "0x8BB0000", VA = "0x188BB1600")]
		internal void SRGYDNZFHJH(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1CA0", Offset = "0x8BB06A0", VA = "0x188BB1CA0")]
		private void SZILAHKFQUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0410", Offset = "0x8BAEE10", VA = "0x188BB0410")]
		internal void AHRPIAKYRER(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2490", Offset = "0x8BB0E90", VA = "0x188BB2490")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0F00", Offset = "0x8BAF900", VA = "0x188BB0F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAB8E0", Offset = "0x8BAA2E0", VA = "0x188BAB8E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long HMUPWUSGKGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BABF30", Offset = "0x8BAA930", VA = "0x188BABF30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long JTVVOUGXMYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BABBF0", Offset = "0x8BAA5F0", VA = "0x188BABBF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long RWGNAYKKWNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB900", Offset = "0x8BAA300", VA = "0x188BAB900")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long XHPFZNOTXKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB8F0", Offset = "0x8BAA2F0", VA = "0x188BAB8F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long FBKUCORNDTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB8D0", Offset = "0x8BAA2D0", VA = "0x188BAB8D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long NFQNCECRKYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BABB50", Offset = "0x8BAA550", VA = "0x188BABB50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long HVFURJTFUKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BABA30", Offset = "0x8BAA430", VA = "0x188BABA30")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality TQQHQFNGHTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1423590", Offset = "0x1421F90", VA = "0x181423590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double NZARBQQIZVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB810", Offset = "0x8BAA210", VA = "0x188BAB810")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BABB10", Offset = "0x8BAA510", VA = "0x188BABB10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB960", Offset = "0x8BAA360", VA = "0x188BAB960")]
		public void KTNGOXAPFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB910", Offset = "0x8BAA310", VA = "0x188BAB910")]
		public void KMPTNEGSWIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB870", Offset = "0x8BAA270", VA = "0x188BAB870")]
		public void EJODYSWAWAA(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BABB90", Offset = "0x8BAA590", VA = "0x188BABB90")]
		public void TKIKZVINPRD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BABF40", Offset = "0x8BAA940", VA = "0x188BABF40")]
		public void ZVUFJHEZNYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB9C0", Offset = "0x8BAA3C0", VA = "0x188BAB9C0")]
		public void MDTWVTDMGOI(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BABC00", Offset = "0x8BAA600", VA = "0x188BABC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8BABA70", Offset = "0x8BAA470", VA = "0x188BABA70")]
		public void RDVYDYRQSTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BADA90", Offset = "0x8BAC490", VA = "0x188BADA90")]
		public static IPEndPoint ZKFQTQNTDOD(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD8A0", Offset = "0x8BAC2A0", VA = "0x188BAD8A0")]
		public static IPAddress CXYEYYEJGDC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD810", Offset = "0x8BAC210", VA = "0x188BAD810")]
		public static IPAddress CXYEYYEJGDC(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8BADA60", Offset = "0x8BAC460", VA = "0x188BADA60")]
		internal static int XTPFLHUQQOI(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C42BC0", Offset = "0x3C415C0", VA = "0x183C42BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAE960", Offset = "0x8BAD360", VA = "0x188BAE960", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE9D0", Offset = "0x8BAD3D0", VA = "0x188BAE9D0")]
			public void VQZGAVQPNPU(HWKCXZMZNEH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE9F0", Offset = "0x8BAD3F0", VA = "0x188BAE9F0")]
			public bool XDHWEDXMHBB(long a, TIMYJXHKVCH b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE910", Offset = "0x8BAD310", VA = "0x188BAE910")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BA8E20", Offset = "0x8BA7820", VA = "0x188BA8E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9430", Offset = "0x8BA7E30", VA = "0x188BA9430")]
		public CQOVEHYRLVH(TIMYJXHKVCH a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA85D0", Offset = "0x8BA6FD0", VA = "0x188BA85D0")]
		private void ISWDGWYJESC(HWKCXZMZNEH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8950", Offset = "0x8BA7350", VA = "0x188BA8950", Slot = "4")]
		protected override bool NMEBGKNATGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8E30", Offset = "0x8BA7830", VA = "0x188BA8E30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAA330", Offset = "0x8BA8D30", VA = "0x188BAA330")]
		public FMWYCXSXRSG(TIMYJXHKVCH a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9BF0", Offset = "0x8BA85F0", VA = "0x188BA9BF0", Slot = "4")]
		protected override bool NMEBGKNATGY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA0B0", Offset = "0x8BA8AB0", VA = "0x188BAA0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BA7250", Offset = "0x8BA5C50", VA = "0x188BA7250")]
		private static void OLFDHSKPQLO(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF490", Offset = "0x8BADE90", VA = "0x188BAF490")]
		private static void OLFDHSKPQLO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF450", Offset = "0x8BADE50", VA = "0x188BAF450")]
		public static void OLFDHSKPQLO(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF590", Offset = "0x8BADF90", VA = "0x188BAF590")]
		public static void GMMDUBYWKNB(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF510", Offset = "0x8BADF10", VA = "0x188BAF510")]
		public static void GMMDUBYWKNB(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF450", Offset = "0x8BADE50", VA = "0x188BAF450")]
		public static void GMMDUBYWKNB(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF450", Offset = "0x8BADE50", VA = "0x188BAF450")]
		public static void GMMDUBYWKNB(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF490", Offset = "0x8BADE90", VA = "0x188BAF490")]
		public static void GMMDUBYWKNB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF490", Offset = "0x8BADE90", VA = "0x188BAF490")]
		public static void GMMDUBYWKNB(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF500", Offset = "0x8BADF00", VA = "0x188BAF500")]
		public static void GMMDUBYWKNB(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF500", Offset = "0x8BADF00", VA = "0x188BAF500")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BTLIKQSQWXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD1B530", Offset = "0xD19F30", VA = "0x180D1B530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CFWUHSMFGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE6D0", Offset = "0x8BBD0D0", VA = "0x188BBE6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DYXLBJXCAVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A42BD0", Offset = "0x2A415D0", VA = "0x182A42BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int PRAISOUCPHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE380", Offset = "0x8BBCD80", VA = "0x188BBE380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE620", Offset = "0x8BBD020", VA = "0x188BBE620")]
		public void NYHZELGMFRL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public YSTOHTMRBVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEAB0", Offset = "0x8BBD4B0", VA = "0x188BBEAB0")]
		public YSTOHTMRBVK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE6E0", Offset = "0x8BBD0E0", VA = "0x188BBE6E0")]
		public IPEndPoint VXQNSJOFEAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE5E0", Offset = "0x8BBCFE0", VA = "0x188BBE5E0")]
		public byte NOADVRABVOS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE5E0", Offset = "0x8BBCFE0", VA = "0x188BBE5E0")]
		public sbyte WXMZWRYNXEH()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x413A470", Offset = "0x4138E70", VA = "0x18413A470")]
		public a[] ITGNGIWUUCZ<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE400", Offset = "0x8BBCE00", VA = "0x188BBE400")]
		public bool[] EAGKTNLDZPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE7B0", Offset = "0x8BBD1B0", VA = "0x188BBE7B0")]
		public ushort[] YKOWQLGLUWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE530", Offset = "0x8BBCF30", VA = "0x188BBE530")]
		public short[] KGAPCNPUFKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE4C0", Offset = "0x8BBCEC0", VA = "0x188BBE4C0")]
		public int[] HVFESDXDOSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE770", Offset = "0x8BBD170", VA = "0x188BBE770")]
		public uint[] WBPDARORNIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE3C0", Offset = "0x8BBCDC0", VA = "0x188BBE3C0")]
		public float[] DZGKJYWFBBV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE480", Offset = "0x8BBCE80", VA = "0x188BBE480")]
		public double[] GSFMQRWRYAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE5A0", Offset = "0x8BBCFA0", VA = "0x188BBE5A0")]
		public long[] NDZVPJIBWKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE340", Offset = "0x8BBCD40", VA = "0x188BBE340")]
		public ulong[] DADHVQKVOYS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE220", Offset = "0x8BBCC20", VA = "0x188BBE220")]
		public string[] AAWLWWQXKYC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE440", Offset = "0x8BBCE40", VA = "0x188BBE440")]
		public bool GPSPSLKAWSU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE570", Offset = "0x8BBCF70", VA = "0x188BBE570")]
		public char VCMPZJKXPGM()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE570", Offset = "0x8BBCF70", VA = "0x188BBE570")]
		public ushort KKAGJSESNDV()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE570", Offset = "0x8BBCF70", VA = "0x188BBE570")]
		public short RPLWSJTIZDQ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE500", Offset = "0x8BBCF00", VA = "0x188BBE500")]
		public long IVXTURTHPRA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE500", Offset = "0x8BBCF00", VA = "0x188BBE500")]
		public ulong JCULMSRZJKZ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE390", Offset = "0x8BBCD90", VA = "0x188BBE390")]
		public int DLJDDQLZGLD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE390", Offset = "0x8BBCD90", VA = "0x188BBE390")]
		public uint FBUWRCKTCSM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE2F0", Offset = "0x8BBCCF0", VA = "0x188BBE2F0")]
		public float BLTYKOCWILM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE660", Offset = "0x8BBD060", VA = "0x188BBE660")]
		public double QKJWRXLLSBD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE8A0", Offset = "0x8BBD2A0", VA = "0x188BBE8A0")]
		public string ZXWWRLSIAEB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE830", Offset = "0x8BBD230", VA = "0x188BBE830")]
		public ArraySegment<byte> ZEGMOJMHFYI(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE7F0", Offset = "0x8BBD1F0", VA = "0x188BBE7F0")]
		public sbyte[] ZEAQHZNMZVO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE690", Offset = "0x8BBD090", VA = "0x188BBE690")]
		public byte[] RPCJRKSMDJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE320", Offset = "0x8BBCD20", VA = "0x188BBE320")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8BA84B0", Offset = "0x8BA6EB0", VA = "0x188BA84B0")]
		public AMLBQLXGWMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8530", Offset = "0x8BA6F30", VA = "0x188BA8530")]
		public AMLBQLXGWMI(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA83C0", Offset = "0x8BA6DC0", VA = "0x188BA83C0")]
		public static AMLBQLXGWMI YYHLVKUHUBL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7790", Offset = "0x8BA6190", VA = "0x188BA7790")]
		public void JKETWGWSYYP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABAAF0", Offset = "0x2AB94F0", VA = "0x182ABAAF0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA79D0", Offset = "0x8BA63D0", VA = "0x188BA79D0")]
		public void RNTOHSCHSKJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7E40", Offset = "0x8BA6840", VA = "0x188BA7E40")]
		public void RNTOHSCHSKJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7AE0", Offset = "0x8BA64E0", VA = "0x188BA7AE0")]
		public void RNTOHSCHSKJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7AE0", Offset = "0x8BA64E0", VA = "0x188BA7AE0")]
		public void RNTOHSCHSKJ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7B90", Offset = "0x8BA6590", VA = "0x188BA7B90")]
		public void RNTOHSCHSKJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7B90", Offset = "0x8BA6590", VA = "0x188BA7B90")]
		public void RNTOHSCHSKJ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7830", Offset = "0x8BA6230", VA = "0x188BA7830")]
		public void RNTOHSCHSKJ(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7830", Offset = "0x8BA6230", VA = "0x188BA7830")]
		public void RNTOHSCHSKJ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7830", Offset = "0x8BA6230", VA = "0x188BA7830")]
		public void RNTOHSCHSKJ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8BA78A0", Offset = "0x8BA62A0", VA = "0x188BA78A0")]
		public void RNTOHSCHSKJ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BA78A0", Offset = "0x8BA62A0", VA = "0x188BA78A0")]
		public void RNTOHSCHSKJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7A70", Offset = "0x8BA6470", VA = "0x188BA7A70")]
		public void RNTOHSCHSKJ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8050", Offset = "0x8BA6A50", VA = "0x188BA8050")]
		public void TQIVOEBWOUN(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8050", Offset = "0x8BA6A50", VA = "0x188BA8050")]
		public void TGOMIOCRLEM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7B30", Offset = "0x8BA6530", VA = "0x188BA7B30")]
		public void RNTOHSCHSKJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA82E0", Offset = "0x8BA6CE0", VA = "0x188BA82E0")]
		public void TEGHYSPDUTI(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7F70", Offset = "0x8BA6970", VA = "0x188BA7F70")]
		public void TEGHYSPDUTI(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7E90", Offset = "0x8BA6890", VA = "0x188BA7E90")]
		public void TEGHYSPDUTI(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7E90", Offset = "0x8BA6890", VA = "0x188BA7E90")]
		public void TEGHYSPDUTI(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7E90", Offset = "0x8BA6890", VA = "0x188BA7E90")]
		public void TEGHYSPDUTI(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7F70", Offset = "0x8BA6970", VA = "0x188BA7F70")]
		public void TEGHYSPDUTI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7F70", Offset = "0x8BA6970", VA = "0x188BA7F70")]
		public void TEGHYSPDUTI(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8130", Offset = "0x8BA6B30", VA = "0x188BA8130")]
		public void TEGHYSPDUTI(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8130", Offset = "0x8BA6B30", VA = "0x188BA8130")]
		public void TEGHYSPDUTI(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8050", Offset = "0x8BA6A50", VA = "0x188BA8050")]
		public void TEGHYSPDUTI(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8210", Offset = "0x8BA6C10", VA = "0x188BA8210")]
		public void TEGHYSPDUTI(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7900", Offset = "0x8BA6300", VA = "0x188BA7900")]
		public void RNTOHSCHSKJ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7C20", Offset = "0x8BA6620", VA = "0x188BA7C20")]
		public void RNTOHSCHSKJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7C30", Offset = "0x8BA6630", VA = "0x188BA7C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x706EAF0", Offset = "0x706D4F0", VA = "0x18706EAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public EIJLBRSJFEW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5C61910", Offset = "0x5C60310", VA = "0x185C61910")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public GNJTQTDCZIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6501760", Offset = "0x6500160", VA = "0x186501760")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BBCCC0", Offset = "0x8BBB6C0", VA = "0x188BBCCC0")]
		public WFGGOIMPZLD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x411D830", Offset = "0x411C230", VA = "0x18411D830", Slot = "4")]
		protected virtual ulong URAAGQKKVUE<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB70", Offset = "0x8BBB570", VA = "0x188BBCB70", Slot = "5")]
		protected virtual SubscribeDelegate VXZIESSPJLF(YSTOHTMRBVK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x411D7B0", Offset = "0x411C1B0", VA = "0x18411D7B0", Slot = "6")]
		protected virtual void MDTRPITMTKT<b>(AMLBQLXGWMI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC40", Offset = "0x8BBB640", VA = "0x188BBCC40")]
		public void YUGQXXUDZVO(YSTOHTMRBVK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x411D720", Offset = "0x411C120", VA = "0x18411D720")]
		public void HHMSAAQYDCT<j>(AMLBQLXGWMI a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCB20", Offset = "0x8BBB520", VA = "0x188BBCB20")]
		public void TRFLKSMFPJS(YSTOHTMRBVK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x411DA30", Offset = "0x411C430", VA = "0x18411DA30")]
		public void ZRFEPWZYNOZ<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x411DA30", Offset = "0x411C430", VA = "0x18411DA30")]
		public void ZRFEPWZYNOZ<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD40", Offset = "0x8BA9740", VA = "0x188BAAD40")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE8B0", Offset = "0x8BAD2B0", VA = "0x188BAE8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x68F6070", Offset = "0x68F4A70", VA = "0x1868F6070", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0x6501980", Offset = "0x6500380", VA = "0x186501980", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6501980", Offset = "0x6500380", VA = "0x186501980", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x6501A50", Offset = "0x6500450", VA = "0x186501A50", Slot = "9")]
			public override void RCXMDCUEAZW(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6501A50", Offset = "0x6500450", VA = "0x186501A50", Slot = "10")]
			public override void CZXDQRUDGPF(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x65027E0", Offset = "0x65011E0", VA = "0x1865027E0")]
			protected b[] ZUDPRMNHCMV(a a, YSTOHTMRBVK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6501B20", Offset = "0x6500520", VA = "0x186501B20")]
			protected b[] GZKHMYYNPZK(a a, AMLBQLXGWMI b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6501CA0", Offset = "0x65006A0", VA = "0x186501CA0", Slot = "4")]
			public override void VQZGAVQPNPU(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6502AB0", Offset = "0x65014B0", VA = "0x186502AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x67C10C0", Offset = "0x67BFAC0", VA = "0x1867C10C0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x67C1350", Offset = "0x67BFD50", VA = "0x1867C1350", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x67C0EC0", Offset = "0x67BF8C0", VA = "0x1867C0EC0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x67C17B0", Offset = "0x67C01B0", VA = "0x1867C17B0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x67C1850", Offset = "0x67C0250", VA = "0x1867C1850")]
			protected JUPWNTUGIVB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class GGEFNVFFDIS<a> : GNPAYXNVLAU<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x64C7DE0", Offset = "0x64C67E0", VA = "0x1864C7DE0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x64C7F60", Offset = "0x64C6960", VA = "0x1864C7F60", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x64C7C80", Offset = "0x64C6680", VA = "0x1864C7C80", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x50CA080", Offset = "0x50C8A80", VA = "0x1850CA080", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public GGEFNVFFDIS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class VMOGOJFGBPJ<a> : GNPAYXNVLAU<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x64C7DE0", Offset = "0x64C67E0", VA = "0x1864C7DE0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x64C7F60", Offset = "0x64C6960", VA = "0x1864C7F60", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x802A800", Offset = "0x8029200", VA = "0x18802A800", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x50CA080", Offset = "0x50C8A80", VA = "0x1850CA080", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public VMOGOJFGBPJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class CCJKREUFPSF<a> : GNPAYXNVLAU<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x51F65C0", Offset = "0x51F4FC0", VA = "0x1851F65C0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x51F6850", Offset = "0x51F5250", VA = "0x1851F6850", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x51F6570", Offset = "0x51F4F70", VA = "0x1851F6570", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x51F69A0", Offset = "0x51F53A0", VA = "0x1851F69A0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public CCJKREUFPSF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class PAULHPIZDAY<a> : GNPAYXNVLAU<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x51F65C0", Offset = "0x51F4FC0", VA = "0x1851F65C0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x51F6850", Offset = "0x51F5250", VA = "0x1851F6850", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7519850", Offset = "0x7518250", VA = "0x187519850", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x51F69A0", Offset = "0x51F53A0", VA = "0x1851F69A0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public PAULHPIZDAY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class IPYPQPQOJWZ<a> : GNPAYXNVLAU<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x517FBD0", Offset = "0x517E5D0", VA = "0x18517FBD0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x517FD50", Offset = "0x517E750", VA = "0x18517FD50", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x66BEE80", Offset = "0x66BD880", VA = "0x1866BEE80", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x517FEA0", Offset = "0x517E8A0", VA = "0x18517FEA0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public IPYPQPQOJWZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class YCOQHBNSRGG<a> : GNPAYXNVLAU<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x517FBD0", Offset = "0x517E5D0", VA = "0x18517FBD0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x517FD50", Offset = "0x517E750", VA = "0x18517FD50", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x517FB80", Offset = "0x517E580", VA = "0x18517FB80", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x517FEA0", Offset = "0x517E8A0", VA = "0x18517FEA0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public YCOQHBNSRGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class DJZYMRZSRMR<a> : GNPAYXNVLAU<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x54D88C0", Offset = "0x54D72C0", VA = "0x1854D88C0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x54D8A20", Offset = "0x54D7420", VA = "0x1854D8A20", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x54D8630", Offset = "0x54D7030", VA = "0x1854D8630", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x54D8A60", Offset = "0x54D7460", VA = "0x1854D8A60", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public DJZYMRZSRMR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class MGOVSKCLDEU<a> : GNPAYXNVLAU<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x54D88C0", Offset = "0x54D72C0", VA = "0x1854D88C0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x54D8A20", Offset = "0x54D7420", VA = "0x1854D8A20", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x706A6B0", Offset = "0x70690B0", VA = "0x18706A6B0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x54D8A60", Offset = "0x54D7460", VA = "0x1854D8A60", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public MGOVSKCLDEU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class XMYPVHNTRRP<a> : GNPAYXNVLAU<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x50C9DB0", Offset = "0x50C87B0", VA = "0x1850C9DB0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x50CA040", Offset = "0x50C8A40", VA = "0x1850CA040", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x50C9C50", Offset = "0x50C8650", VA = "0x1850C9C50", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x50CA080", Offset = "0x50C8A80", VA = "0x1850CA080", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public XMYPVHNTRRP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class ADIVMDANWTM<a> : GNPAYXNVLAU<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x734A370", Offset = "0x7348D70", VA = "0x18734A370", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x734A4D0", Offset = "0x7348ED0", VA = "0x18734A4D0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x734A1F0", Offset = "0x7348BF0", VA = "0x18734A1F0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x517FEA0", Offset = "0x517E8A0", VA = "0x18517FEA0", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public ADIVMDANWTM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class MKEZUFMWFYP<a> : GNPAYXNVLAU<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x706BCD0", Offset = "0x706A6D0", VA = "0x18706BCD0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x706BD20", Offset = "0x706A720", VA = "0x18706BD20", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x706BB50", Offset = "0x706A550", VA = "0x18706BB50", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x54D8A60", Offset = "0x54D7460", VA = "0x1854D8A60", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x50CA1D0", Offset = "0x50C8BD0", VA = "0x1850CA1D0")]
			public MKEZUFMWFYP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class NRMFMFSRDMD<a> : JUPWNTUGIVB<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7299590", Offset = "0x7297F90", VA = "0x187299590", Slot = "12")]
			protected override void OITUVRRQAQL(AMLBQLXGWMI a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x72995C0", Offset = "0x7297FC0", VA = "0x1872995C0", Slot = "11")]
			protected override void WMBRANZZXPG(YSTOHTMRBVK a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x72995F0", Offset = "0x7297FF0", VA = "0x1872995F0")]
			public NRMFMFSRDMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class WQXQJIMWAFR<a> : JUPWNTUGIVB<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x872B000", Offset = "0x8729A00", VA = "0x18872B000", Slot = "12")]
			protected override void OITUVRRQAQL(AMLBQLXGWMI a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x872B030", Offset = "0x8729A30", VA = "0x18872B030", Slot = "11")]
			protected override void WMBRANZZXPG(YSTOHTMRBVK a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x72995F0", Offset = "0x7297FF0", VA = "0x1872995F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0D5C0", Offset = "0x4F0BFC0", VA = "0x184F0D5C0")]
			public BSHQTNXHTZQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D250", Offset = "0x4F0BC50", VA = "0x184F0D250", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D2B0", Offset = "0x4F0BCB0", VA = "0x184F0D2B0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D0D0", Offset = "0x4F0BAD0", VA = "0x184F0D0D0", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x4F0D410", Offset = "0x4F0BE10", VA = "0x184F0D410", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x50DC430", Offset = "0x50DAE30", VA = "0x1850DC430")]
			public XXQLAXDHDZW(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x50DC0D0", Offset = "0x50DAAD0", VA = "0x1850DC0D0", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x50DC2A0", Offset = "0x50DACA0", VA = "0x1850DC2A0", Slot = "6")]
			public override void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x50DC030", Offset = "0x50DAA30", VA = "0x1850DC030", Slot = "7")]
			public override void CCGGUHQANLD(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x50DC030", Offset = "0x50DAA30", VA = "0x1850DC030", Slot = "8")]
			public override void OMMWHSEAROY(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x50DC080", Offset = "0x50DAA80", VA = "0x1850DC080", Slot = "9")]
			public override void RCXMDCUEAZW(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x50DC080", Offset = "0x50DAA80", VA = "0x1850DC080", Slot = "10")]
			public override void CZXDQRUDGPF(a a, AMLBQLXGWMI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class WPJBSGSEAER<a> : XXQLAXDHDZW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x872A4A0", Offset = "0x8728EA0", VA = "0x18872A4A0")]
			public WPJBSGSEAER(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x872A140", Offset = "0x8728B40", VA = "0x18872A140", Slot = "5")]
			public override void EDBAWLRQTGA(a a, YSTOHTMRBVK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x872A430", Offset = "0x8728E30", VA = "0x18872A430", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8740D60", Offset = "0x873F760", VA = "0x188740D60")]
			public WZBNONTILUP(List<KFCFUSFJVEF<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8740C10", Offset = "0x873F610", VA = "0x188740C10")]
			public void HHMSAAQYDCT(a a, AMLBQLXGWMI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8740990", Offset = "0x873F390", VA = "0x188740990")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BA9B60", Offset = "0x8BA8560", VA = "0x188BA9B60")]
		public ESISKMQOJAX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3977B10", Offset = "0x3976510", VA = "0x183977B10")]
		private WZBNONTILUP<d> MGFCAAEMNUM<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x397A7D0", Offset = "0x39791D0", VA = "0x18397A7D0")]
		public void QCIVJGOFOSZ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3977A90", Offset = "0x3976490", VA = "0x183977A90")]
		public bool Deserialize<T>(YSTOHTMRBVK reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x397A810", Offset = "0x3979210", VA = "0x18397A810")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BBD6C0", Offset = "0x8BBC0C0", VA = "0x188BBD6C0")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int KQFKUAHSEFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD290", Offset = "0x8BBBC90", VA = "0x188BBD290")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD2C0", Offset = "0x8BBBCC0", VA = "0x188BBD2C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode GJZIEZBJWHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDBC0", Offset = "0x8BBC5C0", VA = "0x188BBDBC0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD1F0", Offset = "0x8BBBBF0", VA = "0x188BBD1F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int SHPRYTYVCHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDB90", Offset = "0x8BBC590", VA = "0x188BBDB90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint VNPRQFIRMBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDDB0", Offset = "0x8BBC7B0", VA = "0x188BBDDB0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? USPEMYPDLTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD230", Offset = "0x8BBBC30", VA = "0x188BBD230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? ZUOLIMGQNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD260", Offset = "0x8BBBC60", VA = "0x188BBD260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? FHWNMCODTIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD300", Offset = "0x8BBBD00", VA = "0x188BBD300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBDBF0", Offset = "0x8BBC5F0", VA = "0x188BBDBF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? QAPRLMMKVZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF93F80", Offset = "0xF92980", VA = "0x180F93F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDE70", Offset = "0x8BBC870", VA = "0x188BBDE70")]
		public WJNNHGYGOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE180", Offset = "0x8BBCB80", VA = "0x188BBE180")]
		internal WJNNHGYGOFI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDA80", Offset = "0x8BBC480", VA = "0x188BBDA80")]
		public static WJNNHGYGOFI TTIKHGHWWBK(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCE70", Offset = "0x8BBB870", VA = "0x188BBCE70")]
		internal void BJUNATBXQYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD6F0", Offset = "0x8BBC0F0", VA = "0x188BBD6F0")]
		private void RGYQHXXGJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD8B0", Offset = "0x8BBC2B0", VA = "0x188BBD8B0")]
		private DateTime? RITIBEMJFSH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD500", Offset = "0x8BBBF00", VA = "0x188BBD500")]
		private void QSKZIKXBZYH(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD450", Offset = "0x8BBBE50", VA = "0x188BBD450")]
		private ulong LAPYAYMFKWT(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD330", Offset = "0x8BBBD30", VA = "0x188BBD330")]
		private void HJWXZIGNSFJ(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD3F0", Offset = "0x8BBBDF0", VA = "0x188BBD3F0")]
		private uint JBSGVBQZHJG(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A737F0", Offset = "0x8A721F0", VA = "0x188A737F0")]
		private static uint BFVVLERJVUD(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCE10", Offset = "0x8BBB810", VA = "0x188BBCE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAE7B0", Offset = "0x8BAD1B0", VA = "0x188BAE7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE7C0", Offset = "0x8BAD1C0", VA = "0x188BAE7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BBCA10", Offset = "0x8BBB410", VA = "0x188BBCA10", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int ZZHFFPBUDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCA30", Offset = "0x8BBB430", VA = "0x188BBCA30", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint BIUGUECDKLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCA50", Offset = "0x8BBB450", VA = "0x188BBCA50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily KIBFMUSJXAI
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x32CB890", Offset = "0x32CA290", VA = "0x1832CB890", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCA70", Offset = "0x8BBB470", VA = "0x188BBCA70")]
		public VPQKYESXPXR(AddressFamily a, UBNRAMBMBKO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC430", Offset = "0x8BBAE30", VA = "0x188BBC430", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC300", Offset = "0x8BBAD00", VA = "0x188BBC300", Slot = "9")]
		public int AHMQEUIWNXF(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC340", Offset = "0x8BBAD40", VA = "0x188BBC340", Slot = "10")]
		public int BZYPQPJYCIR(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC9F0", Offset = "0x8BBB3F0", VA = "0x188BBC9F0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BAE3A0", Offset = "0x8BACDA0", VA = "0x188BAE3A0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE440", Offset = "0x8BACE40", VA = "0x188BAE440")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1656000", Offset = "0x1654A00", VA = "0x181656000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE2B0", Offset = "0x8BACCB0", VA = "0x188BAE2B0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE2F0", Offset = "0x8BACCF0", VA = "0x188BAE2F0", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		internal void LMMZTNREZWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		internal void DBOUAYPEXYR(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB92F0", Offset = "0x2BB7CF0", VA = "0x182BB92F0")]
		public KLYEORASVUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAD50", Offset = "0x8BA9750", VA = "0x188BAAD50")]
		public void ALDXWDJNVNQ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAF00", Offset = "0x8BA9900", VA = "0x188BAAF00")]
		public void SZYRGXAMMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAFE0", Offset = "0x8BA99E0", VA = "0x188BAAFE0", Slot = "4")]
		public override void UGPGOODTUWO(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB420", Offset = "0x8BA9E20", VA = "0x188BAB420", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BBEF90", Offset = "0x8BBD990", VA = "0x188BBEF90")]
			[BurstDiscard]
			private static void KAZDRKYMGXP(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8BBEBD0", Offset = "0x8BBD5D0", VA = "0x188BBEBD0")]
			private static IntPtr BNVKNLVMKEJ()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8BBED50", Offset = "0x8BBD750", VA = "0x188BBED50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BB0020", Offset = "0x8BAEA20", VA = "0x188BB0020")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB00A0", Offset = "0x8BAEAA0", VA = "0x188BB00A0")]
		private uint XIKHEMXXNCK(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA74D0", Offset = "0x8BA5ED0", VA = "0x188BA74D0")]
		private void RJPALXGPLKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7580", Offset = "0x8BA5F80", VA = "0x188BA7580")]
		private void VCNZQCRQZXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7340", Offset = "0x8BA5D40", VA = "0x188BA7340")]
		private void GWWMAVOJSLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA73D0", Offset = "0x8BA5DD0", VA = "0x188BA73D0")]
		private void KOPMNYHVZVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8BB00D0", Offset = "0x8BAEAD0", VA = "0x188BB00D0")]
		private void ZOPQXKXCTZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFC00", Offset = "0x8BAE600", VA = "0x188BAFC00")]
		private unsafe void JCPNWNMOHBC(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFA20", Offset = "0x8BAE420", VA = "0x188BAFA20")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void DQHIXCDROGB([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFA30", Offset = "0x8BAE430", VA = "0x188BAFA30")]
		public static void DQHIXCDROGB(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFB50", Offset = "0x8BAE550", VA = "0x188BAFB50")]
		public static void FZSQZERSPNX(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFAE0", Offset = "0x8BAE4E0", VA = "0x188BAFAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8BBF120", Offset = "0x8BBDB20", VA = "0x188BBF120")]
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
