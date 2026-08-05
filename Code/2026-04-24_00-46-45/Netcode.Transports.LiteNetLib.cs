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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MNKLAXYNWAY
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
		private NetworkManager PLJEAUEGWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool HUQOXHQHZEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, CBCVDAWZDYR> OTESZMJXLPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VGPRGJKGPSA UFTKLZTEOGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch CEYCFBNYIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] FFOIKWKZUPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType IWXIYVZUTTK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ODOUOLQQGBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6480", Offset = "0x8BC4E80", VA = "0x188BC6480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6430", Offset = "0x8BC4E30", VA = "0x188BC6430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5820", Offset = "0x8BC4220", VA = "0x188BC5820")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5800", Offset = "0x8BC4200", VA = "0x188BC5800")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BC56D0", Offset = "0x8BC40D0", VA = "0x188BC56D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6160", Offset = "0x8BC4B60", VA = "0x188BC6160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5930", Offset = "0x8BC4330", VA = "0x188BC5930", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC57C0", Offset = "0x8BC41C0", VA = "0x188BC57C0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5C00", Offset = "0x8BC4600", VA = "0x188BC5C00", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5F40", Offset = "0x8BC4940", VA = "0x188BC5F40", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4F50", Offset = "0x8BC3950", VA = "0x188BC4F50", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4E60", Offset = "0x8BC3860", VA = "0x188BC4E60", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5200", Offset = "0x8BC3C00", VA = "0x188BC5200", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5B90", Offset = "0x8BC4590", VA = "0x188BC5B90", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BC52A0", Offset = "0x8BC3CA0", VA = "0x188BC52A0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5130", Offset = "0x8BC3B30", VA = "0x188BC5130")]
		private DeliveryMethod GDXURIOWMOR(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BC62A0", Offset = "0x8BC4CA0", VA = "0x188BC62A0", Slot = "16")]
		private void ZBPWTIMVFRY(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BC61D0", Offset = "0x8BC4BD0", VA = "0x188BC61D0", Slot = "17")]
		private void WNVQPNCZCNW(CBCVDAWZDYR a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "18")]
		private void FANQCXPYBDZ(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BC54B0", Offset = "0x8BC3EB0", VA = "0x188BC54B0", Slot = "19")]
		private void JJVIZVTPMBO(CBCVDAWZDYR a, CJLSTYZEZXU b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BC5060", Offset = "0x8BC3A60", VA = "0x188BC5060")]
		private void EDMLNXRMWIH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "20")]
		private void ESFEBGCSBKO(IPEndPoint a, CJLSTYZEZXU b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "21")]
		private void CWFEROHEVGK(CBCVDAWZDYR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4E00", Offset = "0x8BC3800", VA = "0x188BC4E00", Slot = "22")]
		private void CZFDPWWPOQU(ZBLSYRPRLOX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6180", Offset = "0x8BC4B80", VA = "0x188BC6180")]
		private ulong VACWVWWAWYH(CBCVDAWZDYR a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC61B0", Offset = "0x8BC4BB0", VA = "0x188BC61B0")]
		private ulong VACWVWWAWYH(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC56B0", Offset = "0x8BC40B0", VA = "0x188BC56B0")]
		private static int KIPCIJTQLIU(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6360", Offset = "0x8BC4D60", VA = "0x188BC6360")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4DD0", Offset = "0x8BC37D0", VA = "0x188BC4DD0")]
		[CompilerGenerated]
		private void AQAZCQFYQZO(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4DD0", Offset = "0x8BC37D0", VA = "0x188BC4DD0")]
		[CompilerGenerated]
		private void LKRZCMFBPEN(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class WLZWJFUVITE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly CBCVDAWZDYR ZPJQNDXPXFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<EBAXMEIMZCV> WXEUXCKPIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int UMZTPXSPARY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MFLQVMPWYJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BD3000", Offset = "0x8BD1A00", VA = "0x188BD3000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3170", Offset = "0x8BD1B70", VA = "0x188BD3170")]
		protected WLZWJFUVITE(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3090", Offset = "0x8BD1A90", VA = "0x188BD3090")]
		public void KGMWRCAGUID(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BD30F0", Offset = "0x8BD1AF0", VA = "0x188BD30F0")]
		protected void ZQQMNOUMAOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3050", Offset = "0x8BD1A50", VA = "0x188BD3050")]
		public bool CRFURKWSSMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool IABTZETQNCW();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IJXBUZQIPEL(EBAXMEIMZCV a);
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
	public class ZBLSYRPRLOX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly VGPRGJKGPSA XOQKIMPJXRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int ITIZESHBEPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal CCMXBUAMJLI MJGFIBNMVUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint WEUQJNKNGPH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult PAYTDCLMRTF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x165B970", Offset = "0x165A370", VA = "0x18165B970")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x165B960", Offset = "0x165A360", VA = "0x18165B960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4160", Offset = "0x8BD2B60", VA = "0x188BD4160")]
		internal void OIXZNMHXWNW(CCMXBUAMJLI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4130", Offset = "0x8BD2B30", VA = "0x188BD4130")]
		private bool CWQQVPRLFFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BD41C0", Offset = "0x8BD2BC0", VA = "0x188BD41C0")]
		internal ZBLSYRPRLOX(IPEndPoint a, CCMXBUAMJLI b, VGPRGJKGPSA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BD40D0", Offset = "0x8BD2AD0", VA = "0x188BD40D0")]
		public CBCVDAWZDYR Accept()
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
		public CJLSTYZEZXU AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface MNKLAXYNWAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CSEKWXOXUDU(CBCVDAWZDYR a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VLYRUZQLWYU(CBCVDAWZDYR a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VGOQMSYMHZJ(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UEIBYUYLCIE(CBCVDAWZDYR a, CJLSTYZEZXU b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KUJQDDGYFQW(IPEndPoint a, CJLSTYZEZXU b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YKPXXPVJLHE(CBCVDAWZDYR a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void APKVQXYIVFK(ZBLSYRPRLOX a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface XUKKNVJYCDZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RWBLABZNQIS(CBCVDAWZDYR a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ZRYCAJLKSHZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SKHUTWSLYKY(VYHMXRTDIUM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ZJSTNLWUVKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SSGLKHWPQBZ(CBCVDAWZDYR a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class CCMXBUAMJLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int YRJDBSRMVZI = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long JEUGAWKSDGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte QFOYRISMNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] RIBZPJGYXOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly VWTTVVYIPZU IONDNHXDBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int GMUYWHKTDCL;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2300", Offset = "0x8BC0D00", VA = "0x188BC2300")]
		private CCMXBUAMJLI(long a, byte b, int c, byte[] d, VWTTVVYIPZU e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC22D0", Offset = "0x8BC0CD0", VA = "0x188BC22D0")]
		public static int XPQGGTTFFXV(EBAXMEIMZCV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1F00", Offset = "0x8BC0900", VA = "0x188BC1F00")]
		public static CCMXBUAMJLI GGYUYHSGLBE(EBAXMEIMZCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BC20F0", Offset = "0x8BC0AF0", VA = "0x188BC20F0")]
		public static EBAXMEIMZCV SCEIKOTFWHO(XZTMHNLMAEW a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class DSQABMKNKNT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long JEUGAWKSDGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte QFOYRISMNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int GMUYWHKTDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool WJGXOHKYMXS;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3150", Offset = "0x8BC1B50", VA = "0x188BC3150")]
		private DSQABMKNKNT(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2E60", Offset = "0x8BC1860", VA = "0x188BC2E60")]
		public static DSQABMKNKNT GGYUYHSGLBE(EBAXMEIMZCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2F60", Offset = "0x8BC1960", VA = "0x188BC2F60")]
		public static EBAXMEIMZCV SCEIKOTFWHO(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3050", Offset = "0x8BC1A50", VA = "0x188BC3050")]
		public static EBAXMEIMZCV XXCIQWEOVJA(CBCVDAWZDYR a)
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
	public interface SELDPOWJOGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JHNQTUJPVUT(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SKZVWYCGMWR(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class PUOLXEQBXLN
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
		private class DCBHWLMIMTZ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint XRQJWAKBXBF
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string SOUCDIKPLPR
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DCBHWLMIMTZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NCLQBJQGWMF
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint XRQJWAKBXBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint POSCRKBEMCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string SOUCDIKPLPR
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public NCLQBJQGWMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class RKTELCRJORF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string SOUCDIKPLPR
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool BAXFVPEBJCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RKTELCRJORF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly VGPRGJKGPSA UGOLNSRQBGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> RDGBWIUVTGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> JTGIDZZJCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly VWTTVVYIPZU HFGUMHZOLZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly XZTMHNLMAEW UGHLCMHFBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly UMYZVROIPGH MLUNNFWGTTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private SELDPOWJOGQ PVIDEJDDCPM;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int HTMUCMDERSN = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool DPINTJIZTFQ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7B50", Offset = "0x8BC6550", VA = "0x188BC7B50")]
		internal PUOLXEQBXLN(VGPRGJKGPSA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BC76D0", Offset = "0x8BC60D0", VA = "0x188BC76D0")]
		internal void KFOPCGLHHSS(IPEndPoint a, EBAXMEIMZCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2B70", Offset = "0x3DA1570", VA = "0x183DA2B70")]
		private void MWQMSTEBNNG<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7540", Offset = "0x8BC5F40", VA = "0x188BC7540")]
		private void JHNQTUJPVUT(DCBHWLMIMTZ a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7850", Offset = "0x8BC6250", VA = "0x188BC7850")]
		private void PNYWGIRUGCR(NCLQBJQGWMF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC79B0", Offset = "0x8BC63B0", VA = "0x188BC79B0")]
		private void YVGLJJFYGKG(RKTELCRJORF a, IPEndPoint b)
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
	public static class KRCFFTXZRAS
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] IISYTFALHTJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int MHMZNFSICYB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int HZKITRZOCRW;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3FB0", Offset = "0x8BC29B0", VA = "0x188BC3FB0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3FB0", Offset = "0x8BC29B0", VA = "0x188BC3FB0")]
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
	public interface METFUFRAQSI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVLBCNIUKZK(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class FBPMXQCPTDK
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static METFUFRAQSI SFITTCRTNXA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object XUPXRBCHUOO;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C30", Offset = "0x8BC2630", VA = "0x188BC3C30")]
		private static void YAFILYHHCBL(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3B10", Offset = "0x8BC2510", VA = "0x188BC3B10")]
		internal static void OIEOPZYCPJX(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3BD0", Offset = "0x8BC25D0", VA = "0x188BC3BD0")]
		internal static void WYIXESSGFOL(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3B70", Offset = "0x8BC2570", VA = "0x188BC3B70")]
		internal static void PEYUXVRUNJL(string a, params object[] args)
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
	public sealed class CJLSTYZEZXU : VWTTVVYIPZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private EBAXMEIMZCV RXKFARDFRFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly VGPRGJKGPSA XEDICBGGTPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly IOPAGPJIZLZ OWCINEVNELC;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BC25F0", Offset = "0x8BC0FF0", VA = "0x188BC25F0")]
		internal CJLSTYZEZXU(VGPRGJKGPSA a, IOPAGPJIZLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BC24D0", Offset = "0x8BC0ED0", VA = "0x188BC24D0")]
		internal void DXYAIRNHKSX(EBAXMEIMZCV a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2570", Offset = "0x8BC0F70", VA = "0x188BC2570")]
		internal void VKNTBUIIBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2540", Offset = "0x8BC0F40", VA = "0x188BC2540")]
		public void OPCWDWXKMET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class IOPAGPJIZLZ
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
		public IOPAGPJIZLZ WNQXMBRTZCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType AFHKRTOWHTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CBCVDAWZDYR ZPJQNDXPXFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint WEUQJNKNGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object GFOGXHBMBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int FDMULQRPCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError LEOFRHQNHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason JGAWZEXBNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public ZBLSYRPRLOX ZBLSYRPRLOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod YVQAJQWAUVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte RKTLWMRWGBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly CJLSTYZEZXU NCFULVEDZIF;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3F10", Offset = "0x8BC2910", VA = "0x188BC3F10")]
		public IOPAGPJIZLZ(VGPRGJKGPSA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class VGPRGJKGPSA : IEnumerable<CBCVDAWZDYR>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class NFJJSPCDPUF : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6600", Offset = "0x8BC5000", VA = "0x188BC6600", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8BC6670", Offset = "0x8BC5070", VA = "0x188BC6670", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public NFJJSPCDPUF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<CBCVDAWZDYR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly CBCVDAWZDYR _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private CBCVDAWZDYR _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public CBCVDAWZDYR Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DAA030", Offset = "0x1DA8A30", VA = "0x181DAA030")]
			public NetPeerEnumerator(CBCVDAWZDYR p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8BC74B0", Offset = "0x8BC5EB0", VA = "0x188BC74B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8BC7500", Offset = "0x8BC5F00", VA = "0x188BC7500", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread BMPCJRZDOXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool VTMOBXVYLUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool GLFZJMRFKSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private YHEADMLLCAZ YTXADEHERVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent KBECMBNGDRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<IOPAGPJIZLZ> WOMOHLIWTWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<IOPAGPJIZLZ> BMAQGBAYBOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IOPAGPJIZLZ JRWZXNZIVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MNKLAXYNWAY KGESTFQIBSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly XUKKNVJYCDZ HFYNMQSAHXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly ZRYCAJLKSHZ EFLJEOENNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly ZJSTNLWUVKJ LMGHDCJBJVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, CBCVDAWZDYR> UCDOEVXXQFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, ZBLSYRPRLOX> GTMNJPYBIUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, VXAYRRXADXL> OBQOXYJPOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim FPQMRUVVHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private CBCVDAWZDYR PJUIRPGPAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int YHEYYLWOSIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<CBCVDAWZDYR> NZFCXRRZASE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private CBCVDAWZDYR[] HXXRBJRJTXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly OEIHNXCFXWW ZHLEFILVRJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int GLXKLTBPERM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> QFDSEOOQWRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte SLZHCJBKRLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object PLAPPUDJYFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool GELLQYVSCEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool RKICATZXRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int KLJPLLVEBFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int DDVFRLAKFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int MGHKGYCDJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int NCBWAPZXDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool SUTPKPFQJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool JTZNYOEECGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int JLOFEHCIVCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int APNYKQZTRRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int MIHWDFWJZCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool DPINTJIZTFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool TJITXVSFZLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool DFIWKCHAAIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool NOVMGSUCWMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int EHFUFDIAJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int NYWBDPGSYGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool DTAYDAMLJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly KCQZGHZXKOC ERZMUIREZAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool EFAIAVRCJXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly PUOLXEQBXLN PUOLXEQBXLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool TDTBMLTXJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode UUZECHWTBQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int ZFKOXBJRLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool HDHDMWMFCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool BOGEAGDOZRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool YLRNCOKLXEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool XQEQDRZTOGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private EBAXMEIMZCV HVAAADBEMYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int IIJZXHKJEQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object YXKNSQRAMEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private EBAXMEIMZCV WRXNKMUBZVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int BWQJLKDZTBF;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int OTPQUJMVUCZ = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int PLVHCJSEXXA = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private KRBBMXZQAIM IAGGYNONRPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KRBBMXZQAIM HZVTEAASYSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread RQBUCJWTIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread RPRGHWIYPNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint VBNBCDPLGFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint VBCNHQBQNIY;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] EABGAOXSCBM;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] IYUYOHTXPVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> NLRQERVWKZB;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress GEDGWILSZYQ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool EHBYPUSHRSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int TDBFYNVCWAM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EKCWYJKTLOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE78070", Offset = "0xE76A70", VA = "0x180E78070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE77900", Offset = "0xE76300", VA = "0x180E77900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JAPVSTIVZAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x225FDD0", Offset = "0x225E7D0", VA = "0x18225FDD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23785E0", Offset = "0x2376FE0", VA = "0x1823785E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte RSOINRZHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE271D0", Offset = "0xE25BD0", VA = "0x180E271D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int WHTSVULIQPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BD09C0", Offset = "0x8BCF3C0", VA = "0x188BD09C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short QNHHDYHGWAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BCE210", Offset = "0x8BCCC10", VA = "0x188BCE210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CBCVDAWZDYR.OnUpdatedMtuDelegate EGMYBTEHTEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BCB740", Offset = "0x8BCA140", VA = "0x188BCB740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BCE160", Offset = "0x8BCCB60", VA = "0x188BCE160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDF40", Offset = "0x8BCC940", VA = "0x188BCDF40")]
		public void QLEGQRPMPPO(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0120", Offset = "0x8BCEB20", VA = "0x188BD0120")]
		public void WHBPXVQHREN(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0660", Offset = "0x8BCF060", VA = "0x188BD0660")]
		private bool YGDIHBVILGN(IPEndPoint a, [Out] CBCVDAWZDYR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB420", Offset = "0x8BC9E20", VA = "0x188BCB420")]
		private void FJWCEVIWZNL(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEFE0", Offset = "0x8BCD9E0", VA = "0x188BCEFE0")]
		private void TSWJMPPXTOK(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB080", Offset = "0x8BC9A80", VA = "0x188BCB080")]
		private void DGKWZKORYLR(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0C40", Offset = "0x8BCF640", VA = "0x188BD0C40")]
		public VGPRGJKGPSA(MNKLAXYNWAY a, [Optional] OEIHNXCFXWW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDD00", Offset = "0x8BCC700", VA = "0x188BCDD00")]
		internal void KVTUKCDBLAT(CBCVDAWZDYR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC6F0", Offset = "0x8BCB0F0", VA = "0x188BCC6F0")]
		internal void HTLCHFQMUZN(CBCVDAWZDYR a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BD00E0", Offset = "0x8BCEAE0", VA = "0x188BD00E0")]
		internal void VRQYOSGFBIL(CBCVDAWZDYR a, DisconnectReason b, SocketError c, EBAXMEIMZCV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9EB0", Offset = "0x8BC88B0", VA = "0x188BC9EB0")]
		private void CTWZGADYTMA(CBCVDAWZDYR a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, EBAXMEIMZCV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF060", Offset = "0x8BCDA60", VA = "0x188BCF060")]
		private void UOSZWAVLCNE(IOPAGPJIZLZ.EType a, [Optional] CBCVDAWZDYR b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] ZBLSYRPRLOX g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] EBAXMEIMZCV j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA320", Offset = "0x8BC8D20", VA = "0x188BCA320")]
		private void CVVVQNLIUFP(IOPAGPJIZLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDA70", Offset = "0x8BCC470", VA = "0x188BCDA70")]
		internal void IVJRAOJWNHP(IOPAGPJIZLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0300", Offset = "0x8BCED00", VA = "0x188BD0300")]
		private void XHBKARBUAMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9B80", Offset = "0x8BC8580", VA = "0x188BC9B80")]
		private void CQPDJTYBMXX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB9A0", Offset = "0x8BCA3A0", VA = "0x188BCB9A0")]
		internal CBCVDAWZDYR GLJQUZZOIAC(ZBLSYRPRLOX a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB3A0", Offset = "0x8BC9DA0", VA = "0x188BCB3A0")]
		private int EDNRJMDAYJA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF430", Offset = "0x8BCDE30", VA = "0x188BCF430")]
		private void UVSMKDJSOQQ(IPEndPoint a, CBCVDAWZDYR b, CCMXBUAMJLI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC740", Offset = "0x8BCB140", VA = "0x188BCC740")]
		private void ILTHVTAZJAJ(EBAXMEIMZCV a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9470", Offset = "0x8BC7E70", VA = "0x188BC9470")]
		internal void ALNWXCVDAVT(EBAXMEIMZCV a, DeliveryMethod b, byte c, int d, CBCVDAWZDYR e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEAC0", Offset = "0x8BCD4C0", VA = "0x188BCEAC0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEAD0", Offset = "0x8BCD4D0", VA = "0x188BCEAD0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE2D0", Offset = "0x8BCCCD0", VA = "0x188BCE2D0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB7F0", Offset = "0x8BCA1F0", VA = "0x188BCB7F0")]
		public void GJLCDMKBVYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BCAFA0", Offset = "0x8BC99A0", VA = "0x188BCAFA0")]
		public CBCVDAWZDYR Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BCAAF0", Offset = "0x8BC94F0", VA = "0x188BCAAF0")]
		public CBCVDAWZDYR Connect(string address, int port, XZTMHNLMAEW connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCABD0", Offset = "0x8BC95D0", VA = "0x188BCABD0")]
		public CBCVDAWZDYR Connect(IPEndPoint target, XZTMHNLMAEW connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEE50", Offset = "0x8BCD850", VA = "0x188BCEE50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEAF0", Offset = "0x8BCD4F0", VA = "0x188BCEAF0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEE60", Offset = "0x8BCD860", VA = "0x188BCEE60")]
		public void TIPDRNGZZAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEF10", Offset = "0x8BCD910", VA = "0x188BCEF10")]
		public void TIPDRNGZZAX(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA2A0", Offset = "0x8BC8CA0", VA = "0x188BCA2A0")]
		public void CTWZGADYTMA(CBCVDAWZDYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA2E0", Offset = "0x8BC8CE0", VA = "0x188BCA2E0")]
		public void CTWZGADYTMA(CBCVDAWZDYR a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDD50", Offset = "0x8BCC750", VA = "0x188BCDD50", Slot = "4")]
		private IEnumerator<CBCVDAWZDYR> LDNIGVQDUNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0270", Offset = "0x8BCEC70", VA = "0x188BD0270", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9A90", Offset = "0x8BC8490", VA = "0x188BC9A90")]
		private EBAXMEIMZCV BBFWPNLPGUZ(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BC99B0", Offset = "0x8BC83B0", VA = "0x188BC99B0")]
		private EBAXMEIMZCV BBFWPNLPGUZ(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC4B0", Offset = "0x8BCAEB0", VA = "0x188BCC4B0")]
		internal EBAXMEIMZCV HCOTOTDRVXW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9740", Offset = "0x8BC8140", VA = "0x188BC9740")]
		internal void ANAGPQXXSIR(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0B80", Offset = "0x8BCF580", VA = "0x188BD0B80")]
		static VGPRGJKGPSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE78070", Offset = "0xE76A70", VA = "0x180E78070")]
		private bool JBPSQLBCMJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDDE0", Offset = "0x8BCC7E0", VA = "0x188BCDDE0")]
		private void OBJIRORHRYO(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC360", Offset = "0x8BCAD60", VA = "0x188BCC360")]
		private void GUWHAKSXRXH(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD09E0", Offset = "0x8BCF3E0", VA = "0x188BD09E0")]
		private bool ZMSVTTEGFFF(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF040", Offset = "0x8BCDA40", VA = "0x188BCF040")]
		private void TXVNTWUYFAI(YHEADMLLCAZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0700", Offset = "0x8BCF100", VA = "0x188BD0700")]
		private void YLBHLPYERKV(KRBBMXZQAIM a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBFE0", Offset = "0x8BCA9E0", VA = "0x188BCBFE0")]
		private void GMSWYSAJJPN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE350", Offset = "0x8BCCD50", VA = "0x188BCE350")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB340", Offset = "0x8BC9D40", VA = "0x188BCB340")]
		internal int DPZVPBUHEOA(EBAXMEIMZCV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BD00A0", Offset = "0x8BCEAA0", VA = "0x188BD00A0")]
		internal int VQGZFGQCCSO(EBAXMEIMZCV a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF8D0", Offset = "0x8BCE2D0", VA = "0x188BCF8D0")]
		internal int VQGZFGQCCSO(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDB80", Offset = "0x8BCC580", VA = "0x188BCDB80")]
		internal void KIDQAYGZQKX(bool a)
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
	internal sealed class EBAXMEIMZCV
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int ETGHQTSBTFU;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] QKHBPWCWXGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] JFWVLBRHQEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int XFZMLSOCSSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object GFOGXHBMBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public EBAXMEIMZCV WNQXMBRTZCD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty CLXNOASTQRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3500", Offset = "0x8BC1F00", VA = "0x188BC3500")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3490", Offset = "0x8BC1E90", VA = "0x188BC3490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte QFOYRISMNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BC34D0", Offset = "0x8BC1ED0", VA = "0x188BC34D0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3420", Offset = "0x8BC1E20", VA = "0x188BC3420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort YOXVCYJTLZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3630", Offset = "0x8BC2030", VA = "0x188BC3630")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8BC33C0", Offset = "0x8BC1DC0", VA = "0x188BC33C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QOEHWWFVPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3220", Offset = "0x8BC1C20", VA = "0x188BC3220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte BQDODDIKKQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3650", Offset = "0x8BC2050", VA = "0x188BC3650")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3460", Offset = "0x8BC1E60", VA = "0x188BC3460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort MTUIRZUZRXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3400", Offset = "0x8BC1E00", VA = "0x188BC3400")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8BC31A0", Offset = "0x8BC1BA0", VA = "0x188BC31A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort OQHVBTMBMDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3370", Offset = "0x8BC1D70", VA = "0x188BC3370")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3680", Offset = "0x8BC2080", VA = "0x188BC3680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort STJVZKSGKUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3350", Offset = "0x8BC1D50", VA = "0x188BC3350")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BC31E0", Offset = "0x8BC1BE0", VA = "0x188BC31E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC36C0", Offset = "0x8BC20C0", VA = "0x188BC36C0")]
		static EBAXMEIMZCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3390", Offset = "0x8BC1D90", VA = "0x188BC3390")]
		public void MMQMMVHNXRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3990", Offset = "0x8BC2390", VA = "0x188BC3990")]
		public EBAXMEIMZCV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3A00", Offset = "0x8BC2400", VA = "0x188BC3A00")]
		public EBAXMEIMZCV(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3530", Offset = "0x8BC1F30", VA = "0x188BC3530")]
		public static int WCMMWBSILLY(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC35A0", Offset = "0x8BC1FA0", VA = "0x188BC35A0")]
		public int WCMMWBSILLY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3250", Offset = "0x8BC1C50", VA = "0x188BC3250")]
		public bool HGZBYDHMBKX()
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
	public class CBCVDAWZDYR
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class GOWOLOJQCBV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public EBAXMEIMZCV[] RJSYZMMZXPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int GDHKQVBHCIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int QBSFMIVXDPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte BQDODDIKKQE;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GOWOLOJQCBV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int RTJPHBFVQJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int GUVYICCFGLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int VOLYZEYHLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double HTPZUWTVWXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int DYOLQIXWEZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int KIJXTUMFQQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int NXOGVDWPJAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch FURQVLMXDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int IFJKKTZOYOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long KTJKDATJGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object ZRNWFHHWTBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal CBCVDAWZDYR SLEFKJXKFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal CBCVDAWZDYR MWUWDPYKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<EBAXMEIMZCV> OWOFNKNQQAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<WLZWJFUVITE> ZYOBOGBDSKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly WLZWJFUVITE[] DQEHWZAENST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int GCMOSWKXPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int VFBVAAUHBQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool BORXJQYXUNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int VRRNFCCBTDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int RBQUSPGQHDT;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int BFWSSKEWVTX = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int QXBDOBARSRY = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object MKUWBEXZDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int MDFCEKJANSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, GOWOLOJQCBV> BDMOSMDJDGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> MPJZWHMWSMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly EBAXMEIMZCV BBXQTIZXWZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int GXLFFBSUXKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int BUREGJASDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint YDMRRWYMDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int PCPFITNWQPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int SPLUIVDBJUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long DGKUHSNBADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte VQPPHVGGVMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState ZHIGEVYTMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private EBAXMEIMZCV ACKOHRRFNZP;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int WUNUBTRAPYD = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int BDZTFKVCBSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly EBAXMEIMZCV MMGRZPHKQIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly EBAXMEIMZCV LMBTVIHFEXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly EBAXMEIMZCV OMAZJNVXIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly EBAXMEIMZCV NCNWZCMISWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality RIBIHLVTVMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly VGPRGJKGPSA VGPRGJKGPSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int JQHSIUZOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object VBAWELCORRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly KCQZGHZXKOC ERZMUIREZAF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte GWGSIQCHUOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD3E680", Offset = "0xD3D080", VA = "0x180D3E680")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC14B0", Offset = "0x8BBFEB0", VA = "0x188BC14B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint ZDOIKUFGFJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE90C30", Offset = "0xE8F630", VA = "0x180E90C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState MXPHYIEUHQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x14B6C50", Offset = "0x14B5650", VA = "0x1814B6C50")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long LAQCPBCFBAR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD20180", Offset = "0xD1EB80", VA = "0x180D20180")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int FMOBZYHRZSB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x225FDD0", Offset = "0x225E7D0", VA = "0x18225FDD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x23785E0", Offset = "0x2376FE0", VA = "0x1823785E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HWSGRRKOMCS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0440", Offset = "0x8BBEE40", VA = "0x188BC0440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HOGAKXBVBZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED40", Offset = "0xD2D740", VA = "0x180D2ED40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double BZEAXGGLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC20", Offset = "0x2AEE620", VA = "0x182AEFC20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate EGMYBTEHTEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE690", Offset = "0x8BBD090", VA = "0x188BBE690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0450", Offset = "0x8BBEE50", VA = "0x188BC0450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1790", Offset = "0x8BC0190", VA = "0x188BC1790")]
		internal CBCVDAWZDYR(VGPRGJKGPSA a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0500", Offset = "0x8BBEF00", VA = "0x188BC0500")]
		internal void RCMOFHJWFWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0250", Offset = "0x8BBEC50", VA = "0x188BC0250")]
		internal void MRWWLAOBDVS(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDF70", Offset = "0x8BBC970", VA = "0x188BBDF70")]
		internal void ENHVHMEJKMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDDD0", Offset = "0x8BBC7D0", VA = "0x188BBDDD0")]
		private void AGDQSTFPROW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC06C0", Offset = "0x8BBF0C0", VA = "0x188BC06C0")]
		private void SLOQOASXJFI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1560", Offset = "0x8BBFF60", VA = "0x188BC1560")]
		public int VJBGNGLWOMY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1670", Offset = "0x8BC0070", VA = "0x188BC1670")]
		public int VJBGNGLWOMY(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0280", Offset = "0x8BBEC80", VA = "0x188BC0280")]
		private WLZWJFUVITE MTBFLFVHREJ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1D70", Offset = "0x8BC0770", VA = "0x188BC1D70")]
		internal CBCVDAWZDYR(VGPRGJKGPSA a, IPEndPoint b, int c, byte d, XZTMHNLMAEW e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1B90", Offset = "0x8BC0590", VA = "0x188BC1B90")]
		internal CBCVDAWZDYR(VGPRGJKGPSA a, ZBLSYRPRLOX b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0670", Offset = "0x8BBF070", VA = "0x188BC0670")]
		internal void Reject(CCMXBUAMJLI requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDEA0", Offset = "0x8BBC8A0", VA = "0x188BBDEA0")]
		internal bool ATKVVARNMLV(DSQABMKNKNT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0410", Offset = "0x8BBEE10", VA = "0x188BC0410")]
		public void MWQMSTEBNNG(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE000", Offset = "0x8BBCA00", VA = "0x188BBE000")]
		private void FDDYPBHQNFX(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDF20", Offset = "0x8BBC920", VA = "0x188BBDF20")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE5F0", Offset = "0x8BBCFF0", VA = "0x188BBE5F0")]
		internal DisconnectResult FUJCPXNNNKZ(EBAXMEIMZCV a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BC01F0", Offset = "0x8BBEBF0", VA = "0x188BC01F0")]
		internal void KWUFKMCMOGC(WLZWJFUVITE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0910", Offset = "0x8BBF310", VA = "0x188BC0910")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBEFE0", Offset = "0x8BBD9E0", VA = "0x188BBEFE0")]
		private void IIWSUAOPUTV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE740", Offset = "0x8BBD140", VA = "0x188BBE740")]
		internal void GDVREXRMKDR(DeliveryMethod a, EBAXMEIMZCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFCB0", Offset = "0x8BBE6B0", VA = "0x188BBFCB0")]
		private void KFGFESELTWZ(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF6C0", Offset = "0x8BBE0C0", VA = "0x188BBF6C0")]
		private void JMVEPCCVGVL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0C20", Offset = "0x8BBF620", VA = "0x188BC0C20")]
		internal ConnectRequestResult UVSMKDJSOQQ(CCMXBUAMJLI a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF020", Offset = "0x8BBDA20", VA = "0x188BBF020")]
		internal void IJXBUZQIPEL(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0520", Offset = "0x8BBEF20", VA = "0x188BC0520")]
		private void RIANHXSCNZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0700", Offset = "0x8BBF100", VA = "0x188BC0700")]
		internal void SUWIQOUOKXR(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0DE0", Offset = "0x8BBF7E0", VA = "0x188BC0DE0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBFA50", Offset = "0x8BBE450", VA = "0x188BBFA50")]
		internal void KCWFUIIZURL(EBAXMEIMZCV a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class KCQZGHZXKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long NGBWACJNKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long RYBWMKBSMHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long PGTBEHZGSZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long VEKKILRAYJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long LRPZYZMHOUY;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long YCJHOAESYRR;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long CBAKBWYCBMS;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long CIBLLASSXDL;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long VHCWKZKNPZO;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long EKXFTHJPTBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long LFXYYZRFVQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long IQTPVZOUGXC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long KMTGYGMHVCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4720", Offset = "0x8BC3120", VA = "0x188BC4720")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long ILPUWWNXKYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3FE0", Offset = "0x8BC29E0", VA = "0x188BC3FE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long ITMWXTEHGIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4710", Offset = "0x8BC3110", VA = "0x188BC4710")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long TFNNMUQGVPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3FD0", Offset = "0x8BC29D0", VA = "0x188BC3FD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long PEEBOYJDWTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BC40B0", Offset = "0x8BC2AB0", VA = "0x188BC40B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long GRACWBRAERN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3FC0", Offset = "0x8BC29C0", VA = "0x188BC3FC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long ITQFIETBTLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4070", Offset = "0x8BC2A70", VA = "0x188BC4070")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long KMLITBLZUCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BC46D0", Offset = "0x8BC30D0", VA = "0x188BC46D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality PWKKLXRWQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1441140", Offset = "0x143FB40", VA = "0x181441140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double CBEIXMYIUNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8BC4670", Offset = "0x8BC3070", VA = "0x188BC4670")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4200", Offset = "0x8BC2C00", VA = "0x188BC4200")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4730", Offset = "0x8BC3130", VA = "0x188BC4730")]
		public void ZXHVYJQEFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4580", Offset = "0x8BC2F80", VA = "0x188BC4580")]
		public void WBJVTYEZMYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4130", Offset = "0x8BC2B30", VA = "0x188BC4130")]
		public void LCBLFDUFLXY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BC40C0", Offset = "0x8BC2AC0", VA = "0x188BC40C0")]
		public void KKOGWVLFMCD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BC41A0", Offset = "0x8BC2BA0", VA = "0x188BC41A0")]
		public void NRSSLQIPFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3FF0", Offset = "0x8BC29F0", VA = "0x188BC3FF0")]
		public void FGCMVJCLORU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4240", Offset = "0x8BC2C40", VA = "0x188BC4240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8BC45D0", Offset = "0x8BC2FD0", VA = "0x188BC45D0")]
		public void WPRXLQCAGPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KCQZGHZXKOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class KGLTDTGSUHE
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> MYIIIWCRZMT;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4790", Offset = "0x8BC3190", VA = "0x188BC4790")]
		public static IPEndPoint HDIUYEAHHEJ(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4A90", Offset = "0x8BC3490", VA = "0x188BC4A90")]
		public static IPAddress WDZXGPJURLU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8BC4A00", Offset = "0x8BC3400", VA = "0x188BC4A00")]
		public static IPAddress WDZXGPJURLU(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8BC49D0", Offset = "0x8BC33D0", VA = "0x188BC49D0")]
		internal static int QFTJGQPKGHY(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C00250", Offset = "0x3BFEC50", VA = "0x183C00250")]
		internal static T[] UCIJLLGYJZJ<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class BSUKIOKNEXJ : WLZWJFUVITE
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private EBAXMEIMZCV _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8BC8080", Offset = "0x8BC6A80", VA = "0x188BC8080", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8BC8060", Offset = "0x8BC6A60", VA = "0x188BC8060")]
			public void SRPDLCJVRSE(EBAXMEIMZCV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8BC7FA0", Offset = "0x8BC69A0", VA = "0x188BC7FA0")]
			public bool CTMFDZWLALL(long a, CBCVDAWZDYR b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8BC8010", Offset = "0x8BC6A10", VA = "0x188BC8010")]
			public bool Clear(CBCVDAWZDYR peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly EBAXMEIMZCV RUDXMVIBYVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] VAUGNZLWGAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly EBAXMEIMZCV[] YMXSHXTNPRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] NALJJDUSYTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int CCWTYISPRFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ISLHECNDNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int NSBMELBCJHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int NOOONBJLNTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool IYIKSZPGUMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod LXTHQWNYQZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool QADPAVSMOFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int KTYXPIQKSNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte JHEVEMOUEOS;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int UQTRMAWYKBT
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD130", Offset = "0x8BBBB30", VA = "0x188BBD130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBDC10", Offset = "0x8BBC610", VA = "0x188BBDC10")]
		public BSUKIOKNEXJ(CBCVDAWZDYR a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCDB0", Offset = "0x8BBB7B0", VA = "0x188BBCDB0")]
		private void AJKTGUEVOCI(EBAXMEIMZCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD140", Offset = "0x8BBBB40", VA = "0x188BBD140", Slot = "4")]
		protected override bool IABTZETQNCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD610", Offset = "0x8BBC010", VA = "0x188BBD610", Slot = "5")]
		public override bool IJXBUZQIPEL(EBAXMEIMZCV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class RAZDPQWDOAY : WLZWJFUVITE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int DVKNISMRMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort ISLHECNDNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool XPEUBIUXOIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private EBAXMEIMZCV ICUMLXPBILZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly EBAXMEIMZCV DEQNHURNRBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool MHGOWTUKRGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte JHEVEMOUEOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long YKMPOHPFXJC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8830", Offset = "0x8BC7230", VA = "0x188BC8830")]
		public RAZDPQWDOAY(CBCVDAWZDYR a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BC80F0", Offset = "0x8BC6AF0", VA = "0x188BC80F0", Slot = "4")]
		protected override bool IABTZETQNCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BC85B0", Offset = "0x8BC6FB0", VA = "0x188BC85B0", Slot = "5")]
		public override bool IJXBUZQIPEL(EBAXMEIMZCV a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class CHGNHBYNGGB
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
		[Cpp2IlInjected.Address(RVA = "0x8BBC7D0", Offset = "0x8BBB1D0", VA = "0x188BBC7D0")]
		private static void GFADRNKVPUO(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8BC23B0", Offset = "0x8BC0DB0", VA = "0x188BC23B0")]
		private static void GFADRNKVPUO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2370", Offset = "0x8BC0D70", VA = "0x188BC2370")]
		public static void GFADRNKVPUO(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2430", Offset = "0x8BC0E30", VA = "0x188BC2430")]
		public static void WGWXBTQLXAF(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2450", Offset = "0x8BC0E50", VA = "0x188BC2450")]
		public static void WGWXBTQLXAF(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2370", Offset = "0x8BC0D70", VA = "0x188BC2370")]
		public static void WGWXBTQLXAF(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2370", Offset = "0x8BC0D70", VA = "0x188BC2370")]
		public static void WGWXBTQLXAF(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC23B0", Offset = "0x8BC0DB0", VA = "0x188BC23B0")]
		public static void WGWXBTQLXAF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC23B0", Offset = "0x8BC0DB0", VA = "0x188BC23B0")]
		public static void WGWXBTQLXAF(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2420", Offset = "0x8BC0E20", VA = "0x188BC2420")]
		public static void WGWXBTQLXAF(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2420", Offset = "0x8BC0E20", VA = "0x188BC2420")]
		public static void WGWXBTQLXAF(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class VWTTVVYIPZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] UADLOPEYDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int UCQJNJYYXKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int VEIGRVZSOYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int TJTYAALTZDW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] JFWVLBRHQEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int IIIJEHHGDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int SVXKCXLGUTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1510", Offset = "0x8BCFF10", VA = "0x188BD1510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EWVTTOLGOHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2A5A5E0", Offset = "0x2A58FE0", VA = "0x182A5A5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int QEZADIWKBVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8BD14C0", Offset = "0x8BCFEC0", VA = "0x188BD14C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1290", Offset = "0x8BCFC90", VA = "0x188BD1290")]
		public void DXYAIRNHKSX(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public VWTTVVYIPZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1A90", Offset = "0x8BD0490", VA = "0x188BD1A90")]
		public VWTTVVYIPZU(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8BD13F0", Offset = "0x8BCFDF0", VA = "0x188BD13F0")]
		public IPEndPoint GGWPCBQXBJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1480", Offset = "0x8BCFE80", VA = "0x188BD1480")]
		public byte GNIFTCUXITK()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1480", Offset = "0x8BCFE80", VA = "0x188BD1480")]
		public sbyte YOBTTAGOMNH()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x40D01D0", Offset = "0x40CEBD0", VA = "0x1840D01D0")]
		public a[] HIMGNHKEJFV<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD19E0", Offset = "0x8BD03E0", VA = "0x188BD19E0")]
		public bool[] XKHLFLMWVKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD15E0", Offset = "0x8BCFFE0", VA = "0x188BD15E0")]
		public ushort[] NYLBFAASKHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1A50", Offset = "0x8BD0450", VA = "0x188BD1A50")]
		public short[] ZBNHSBIFNSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1620", Offset = "0x8BD0020", VA = "0x188BD1620")]
		public int[] PNQFGXSCZVC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1340", Offset = "0x8BCFD40", VA = "0x188BD1340")]
		public uint[] EEOKVKAEPKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1560", Offset = "0x8BCFF60", VA = "0x188BD1560")]
		public float[] NLONBAFIDCV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1200", Offset = "0x8BCFC00", VA = "0x188BD1200")]
		public double[] BGBVSIQEUGY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8BD15A0", Offset = "0x8BCFFA0", VA = "0x188BD15A0")]
		public long[] NQKQPJLAODT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1520", Offset = "0x8BCFF20", VA = "0x188BD1520")]
		public ulong[] MDKYIVLQSUQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1660", Offset = "0x8BD0060", VA = "0x188BD1660")]
		public string[] QHGCUSFZMWE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1940", Offset = "0x8BD0340", VA = "0x188BD1940")]
		public bool URLPLXUKKSK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8BD13C0", Offset = "0x8BCFDC0", VA = "0x188BD13C0")]
		public char TVXGNKPKWGK()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8BD13C0", Offset = "0x8BCFDC0", VA = "0x188BD13C0")]
		public ushort FUSBACAWXEJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD13C0", Offset = "0x8BCFDC0", VA = "0x188BD13C0")]
		public short FUZMQNIIQQM()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1260", Offset = "0x8BCFC60", VA = "0x188BD1260")]
		public long VDYZKPGFTCM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1260", Offset = "0x8BCFC60", VA = "0x188BD1260")]
		public ulong DVXAJLMXEAT()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD19B0", Offset = "0x8BD03B0", VA = "0x188BD19B0")]
		public int WTAVZZLBJKD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD19B0", Offset = "0x8BD03B0", VA = "0x188BD19B0")]
		public uint XBDCGHKSDSW()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1A20", Offset = "0x8BD0420", VA = "0x188BD1A20")]
		public float YUNQABHQRJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1980", Offset = "0x8BD0380", VA = "0x188BD1980")]
		public double VZJMLGNGXGP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1730", Offset = "0x8BD0130", VA = "0x188BD1730")]
		public string TPBZTRCPNTZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8BD12D0", Offset = "0x8BCFCD0", VA = "0x188BD12D0")]
		public ArraySegment<byte> EAVVZRGOMLE(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1380", Offset = "0x8BCFD80", VA = "0x188BD1380")]
		public sbyte[] ENJNLEZWRJQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8BD14D0", Offset = "0x8BCFED0", VA = "0x188BD14D0")]
		public byte[] KXSEMCAGZQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1240", Offset = "0x8BCFC40", VA = "0x188BD1240")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class XZTMHNLMAEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] UADLOPEYDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int UCQJNJYYXKQ;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int WLPWZMENNQH = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool XJWEUDNHFNC;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding PLTWKUGRASI;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int WJSPKLSCSKV = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] PISMWYTBXKY;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int XNBAVDEQHQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3FB0", Offset = "0x8BD29B0", VA = "0x188BD3FB0")]
		public XZTMHNLMAEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8BD4030", Offset = "0x8BD2A30", VA = "0x188BD4030")]
		public XZTMHNLMAEW(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3290", Offset = "0x8BD1C90", VA = "0x188BD3290")]
		public static XZTMHNLMAEW AEXCNVQJPGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3830", Offset = "0x8BD2230", VA = "0x188BD3830")]
		public void IPNOCXRTNLD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD2AF0", Offset = "0x2AD14F0", VA = "0x182AD2AF0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3920", Offset = "0x8BD2320", VA = "0x188BD3920")]
		public void NCQAIEDBYTF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD38D0", Offset = "0x8BD22D0", VA = "0x188BD38D0")]
		public void NCQAIEDBYTF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3E10", Offset = "0x8BD2810", VA = "0x188BD3E10")]
		public void NCQAIEDBYTF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3E10", Offset = "0x8BD2810", VA = "0x188BD3E10")]
		public void NCQAIEDBYTF(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8BD39C0", Offset = "0x8BD23C0", VA = "0x188BD39C0")]
		public void NCQAIEDBYTF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8BD39C0", Offset = "0x8BD23C0", VA = "0x188BD39C0")]
		public void NCQAIEDBYTF(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3A50", Offset = "0x8BD2450", VA = "0x188BD3A50")]
		public void NCQAIEDBYTF(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3A50", Offset = "0x8BD2450", VA = "0x188BD3A50")]
		public void NCQAIEDBYTF(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3A50", Offset = "0x8BD2450", VA = "0x188BD3A50")]
		public void NCQAIEDBYTF(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3B30", Offset = "0x8BD2530", VA = "0x188BD3B30")]
		public void NCQAIEDBYTF(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3B30", Offset = "0x8BD2530", VA = "0x188BD3B30")]
		public void NCQAIEDBYTF(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3AC0", Offset = "0x8BD24C0", VA = "0x188BD3AC0")]
		public void NCQAIEDBYTF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3300", Offset = "0x8BD1D00", VA = "0x188BD3300")]
		public void CHHVIFUBISX(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3300", Offset = "0x8BD1D00", VA = "0x188BD3300")]
		public void HCAOCZCQILA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3B90", Offset = "0x8BD2590", VA = "0x188BD3B90")]
		public void NCQAIEDBYTF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3750", Offset = "0x8BD2150", VA = "0x188BD3750")]
		public void HJUPURMZPNK(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD34B0", Offset = "0x8BD1EB0", VA = "0x188BD34B0")]
		public void HJUPURMZPNK(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3590", Offset = "0x8BD1F90", VA = "0x188BD3590")]
		public void HJUPURMZPNK(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3590", Offset = "0x8BD1F90", VA = "0x188BD3590")]
		public void HJUPURMZPNK(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3590", Offset = "0x8BD1F90", VA = "0x188BD3590")]
		public void HJUPURMZPNK(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8BD34B0", Offset = "0x8BD1EB0", VA = "0x188BD34B0")]
		public void HJUPURMZPNK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8BD34B0", Offset = "0x8BD1EB0", VA = "0x188BD34B0")]
		public void HJUPURMZPNK(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3670", Offset = "0x8BD2070", VA = "0x188BD3670")]
		public void HJUPURMZPNK(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3670", Offset = "0x8BD2070", VA = "0x188BD3670")]
		public void HJUPURMZPNK(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3300", Offset = "0x8BD1D00", VA = "0x188BD3300")]
		public void HJUPURMZPNK(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8BD33E0", Offset = "0x8BD1DE0", VA = "0x188BD33E0")]
		public void HJUPURMZPNK(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3E60", Offset = "0x8BD2860", VA = "0x188BD3E60")]
		public void NCQAIEDBYTF(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3E00", Offset = "0x8BD2800", VA = "0x188BD3E00")]
		public void NCQAIEDBYTF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3BF0", Offset = "0x8BD25F0", VA = "0x188BD3BF0")]
		public void NCQAIEDBYTF(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class UMYZVROIPGH
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class HHOJXCDRWFB<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong JQHSIUZOJPJ;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x6513930", Offset = "0x6512330", VA = "0x186513930")]
			static HHOJXCDRWFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(VWTTVVYIPZU reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class VIMJCODCDQU<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public UMYZVROIPGH TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a NEOLSCUPIGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> ORHPFUAZMCQ;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public VIMJCODCDQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7ECA790", Offset = "0x7EC9190", VA = "0x187ECA790")]
			internal void ZFRCHUKQUJF(VWTTVVYIPZU a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HNKWMYINXYQ<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public UMYZVROIPGH TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a NEOLSCUPIGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> ORHPFUAZMCQ;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HNKWMYINXYQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x651EEE0", Offset = "0x651D8E0", VA = "0x18651EEE0")]
			internal void ZFRCHUKQUJF(VWTTVVYIPZU a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly XHHDEPVBUOZ EUQDDNTLDSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> BWYXFSFOFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly XZTMHNLMAEW PHMMSPYWOBH;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9320", Offset = "0x8BC7D20", VA = "0x188BC9320")]
		public UMYZVROIPGH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40A0FB0", Offset = "0x409F9B0", VA = "0x1840A0FB0", Slot = "4")]
		protected virtual ulong XTVDHZDSQDA<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9180", Offset = "0x8BC7B80", VA = "0x188BC9180", Slot = "5")]
		protected virtual SubscribeDelegate GCOAJMZBBYB(VWTTVVYIPZU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40A0F30", Offset = "0x409F930", VA = "0x1840A0F30", Slot = "6")]
		protected virtual void TOZHDQCXMSZ<b>(XZTMHNLMAEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9250", Offset = "0x8BC7C50", VA = "0x188BC9250")]
		public void VHUTJZFNMEW(VWTTVVYIPZU a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x40A0EA0", Offset = "0x409F8A0", VA = "0x1840A0EA0")]
		public void RSXNQYUMOFP<j>(XZTMHNLMAEW a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BC92D0", Offset = "0x8BC7CD0", VA = "0x188BC92D0")]
		public void VKQEYFGVWWS(VWTTVVYIPZU a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40A0D20", Offset = "0x409F720", VA = "0x1840A0D20")]
		public void FCXKFVOPSGH<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x40A0D20", Offset = "0x409F720", VA = "0x1840A0D20")]
		public void FCXKFVOPSGH<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3FB0", Offset = "0x8BC29B0", VA = "0x188BC3FB0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7F40", Offset = "0x8BC6940", VA = "0x188BC7F40")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class XHHDEPVBUOZ
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
		private abstract class WBTKRRVZFNJ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType AFHKRTOWHTU;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8723920", Offset = "0x8722320", VA = "0x188723920", Slot = "4")]
			public virtual void SRPDLCJVRSE(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void XQOFLNOTRCW(a a, VWTTVVYIPZU b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void RSXNQYUMOFP(a a, XZTMHNLMAEW b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void DHCHWRHMIEX(a a, VWTTVVYIPZU b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void AWXPAVVNEJA(a a, XZTMHNLMAEW b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void BIDENYGCTXA(a a, VWTTVVYIPZU b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void VJERAZDFDGV(a a, XZTMHNLMAEW b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			protected WBTKRRVZFNJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class NQHQDYMYWWO<a, b> : WBTKRRVZFNJ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> FWIGASNVTON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> EACEWAYWXAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> KAUPTXXLCGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> IRLWBGFTBEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> ISGWASIMMRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> ETBDVVHOZXD;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7166BA0", Offset = "0x71655A0", VA = "0x187166BA0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7166BA0", Offset = "0x71655A0", VA = "0x187166BA0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7166C70", Offset = "0x7165670", VA = "0x187166C70", Slot = "9")]
			public override void BIDENYGCTXA(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7166C70", Offset = "0x7165670", VA = "0x187166C70", Slot = "10")]
			public override void VJERAZDFDGV(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7166D40", Offset = "0x7165740", VA = "0x187166D40")]
			protected b[] KPZSFEPVWFZ(a a, VWTTVVYIPZU b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7167000", Offset = "0x7165A00", VA = "0x187167000")]
			protected b[] OQRLFOWOMRM(a a, XZTMHNLMAEW b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7167170", Offset = "0x7165B70", VA = "0x187167170", Slot = "4")]
			public override void SRPDLCJVRSE(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7167CB0", Offset = "0x71666B0", VA = "0x187167CB0")]
			protected NQHQDYMYWWO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class UOONHIUEIIZ<a, b> : NQHQDYMYWWO<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void ASWMNTNJZNQ(VWTTVVYIPZU a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void DXPOMWBFYXT(XZTMHNLMAEW a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7D27320", Offset = "0x7D25D20", VA = "0x187D27320", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7D270D0", Offset = "0x7D25AD0", VA = "0x187D270D0", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7D27030", Offset = "0x7D25A30", VA = "0x187D27030", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7D26C30", Offset = "0x7D25630", VA = "0x187D26C30", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7D275A0", Offset = "0x7D25FA0", VA = "0x187D275A0")]
			protected UOONHIUEIIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class ZFLHRBRBIEQ<a> : NQHQDYMYWWO<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x51569D0", Offset = "0x51553D0", VA = "0x1851569D0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5156870", Offset = "0x5155270", VA = "0x185156870", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x5156720", Offset = "0x5155120", VA = "0x185156720", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x51565E0", Offset = "0x5154FE0", VA = "0x1851565E0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public ZFLHRBRBIEQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class PYWDGGMJPIF<a> : NQHQDYMYWWO<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x51569D0", Offset = "0x51553D0", VA = "0x1851569D0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x5156870", Offset = "0x5155270", VA = "0x185156870", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x73F5AC0", Offset = "0x73F44C0", VA = "0x1873F5AC0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x51565E0", Offset = "0x5154FE0", VA = "0x1851565E0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public PYWDGGMJPIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class ZPZBWOFKUAX<a> : NQHQDYMYWWO<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x51608D0", Offset = "0x515F2D0", VA = "0x1851608D0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5160890", Offset = "0x515F290", VA = "0x185160890", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5160630", Offset = "0x515F030", VA = "0x185160630", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x51605F0", Offset = "0x515EFF0", VA = "0x1851605F0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public ZPZBWOFKUAX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class VHURNBFFQNA<a> : NQHQDYMYWWO<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x51608D0", Offset = "0x515F2D0", VA = "0x1851608D0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5160890", Offset = "0x515F290", VA = "0x185160890", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7EC8430", Offset = "0x7EC6E30", VA = "0x187EC8430", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x51605F0", Offset = "0x515EFF0", VA = "0x1851605F0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public VHURNBFFQNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class DTWSKEIEMCD<a> : NQHQDYMYWWO<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x53B8F90", Offset = "0x53B7990", VA = "0x1853B8F90", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x53B8E30", Offset = "0x53B7830", VA = "0x1853B8E30", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x53B8BD0", Offset = "0x53B75D0", VA = "0x1853B8BD0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x53B8B90", Offset = "0x53B7590", VA = "0x1853B8B90", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public DTWSKEIEMCD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class EEXAMSUPIVG<a> : NQHQDYMYWWO<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x53B8F90", Offset = "0x53B7990", VA = "0x1853B8F90", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x53B8E30", Offset = "0x53B7830", VA = "0x1853B8E30", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x5B46CE0", Offset = "0x5B456E0", VA = "0x185B46CE0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x53B8B90", Offset = "0x53B7590", VA = "0x1853B8B90", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public EEXAMSUPIVG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class TMNTYTBMDTB<a> : NQHQDYMYWWO<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x652D660", Offset = "0x652C060", VA = "0x18652D660", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x652D3F0", Offset = "0x652BDF0", VA = "0x18652D3F0", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A504B0", Offset = "0x7A4EEB0", VA = "0x187A504B0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x652D150", Offset = "0x652BB50", VA = "0x18652D150", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public TMNTYTBMDTB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class HZUEEBRIYUG<a> : NQHQDYMYWWO<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x652D660", Offset = "0x652C060", VA = "0x18652D660", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x652D3F0", Offset = "0x652BDF0", VA = "0x18652D3F0", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x652D2A0", Offset = "0x652BCA0", VA = "0x18652D2A0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x652D150", Offset = "0x652BB50", VA = "0x18652D150", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public HZUEEBRIYUG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class NTIGGIHGKTV<a> : NQHQDYMYWWO<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x716D3F0", Offset = "0x716BDF0", VA = "0x18716D3F0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x716D290", Offset = "0x716BC90", VA = "0x18716D290", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x716D130", Offset = "0x716BB30", VA = "0x18716D130", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x51565E0", Offset = "0x5154FE0", VA = "0x1851565E0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x716D440", Offset = "0x716BE40", VA = "0x18716D440")]
			public NTIGGIHGKTV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class RRJLFYTZEOY<a> : NQHQDYMYWWO<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x7657770", Offset = "0x7656170", VA = "0x187657770", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7657610", Offset = "0x7656010", VA = "0x187657610", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x76573B0", Offset = "0x7655DB0", VA = "0x1876573B0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x53B8B90", Offset = "0x53B7590", VA = "0x1853B8B90", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public RRJLFYTZEOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class SYMADKPZHOZ<a> : NQHQDYMYWWO<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x79118A0", Offset = "0x79102A0", VA = "0x1879118A0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7911750", Offset = "0x7910150", VA = "0x187911750", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7911700", Offset = "0x7910100", VA = "0x187911700", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x652D150", Offset = "0x652BB50", VA = "0x18652D150", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5156A40", Offset = "0x5155440", VA = "0x185156A40")]
			public SYMADKPZHOZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class RJIZTKWWJGJ<a> : UOONHIUEIIZ<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7647670", Offset = "0x7646070", VA = "0x187647670", Slot = "12")]
			protected override void DXPOMWBFYXT(XZTMHNLMAEW a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7647640", Offset = "0x7646040", VA = "0x187647640", Slot = "11")]
			protected override void ASWMNTNJZNQ(VWTTVVYIPZU a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x76053C0", Offset = "0x7603DC0", VA = "0x1876053C0")]
			public RJIZTKWWJGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class QNRMVVJHEVP<a> : UOONHIUEIIZ<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7605390", Offset = "0x7603D90", VA = "0x187605390", Slot = "12")]
			protected override void DXPOMWBFYXT(XZTMHNLMAEW a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7605350", Offset = "0x7603D50", VA = "0x187605350", Slot = "11")]
			protected override void ASWMNTNJZNQ(VWTTVVYIPZU a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x76053C0", Offset = "0x7603DC0", VA = "0x1876053C0")]
			public QNRMVVJHEVP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class ZEECPEHMZEU<a> : NQHQDYMYWWO<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int LAGZUUPUOUT;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5156430", Offset = "0x5154E30", VA = "0x185156430")]
			public ZEECPEHMZEU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x51563D0", Offset = "0x5154DD0", VA = "0x1851563D0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5156150", Offset = "0x5154B50", VA = "0x185156150", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5155FD0", Offset = "0x51549D0", VA = "0x185155FD0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5155F80", Offset = "0x5154980", VA = "0x185155F80", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class LQDPMUOKECS<a> : WBTKRRVZFNJ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo CLXNOASTQRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type BVLWNZEGZKL;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x68D5EF0", Offset = "0x68D48F0", VA = "0x1868D5EF0")]
			public LQDPMUOKECS(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68D5E50", Offset = "0x68D4850", VA = "0x1868D5E50", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68D5CA0", Offset = "0x68D46A0", VA = "0x1868D5CA0", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x68D5AE0", Offset = "0x68D44E0", VA = "0x1868D5AE0", Slot = "7")]
			public override void DHCHWRHMIEX(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68D5AE0", Offset = "0x68D44E0", VA = "0x1868D5AE0", Slot = "8")]
			public override void AWXPAVVNEJA(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68D5B30", Offset = "0x68D4530", VA = "0x1868D5B30", Slot = "9")]
			public override void BIDENYGCTXA(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x68D5B30", Offset = "0x68D4530", VA = "0x1868D5B30", Slot = "10")]
			public override void VJERAZDFDGV(a a, XZTMHNLMAEW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class FCLUQSQKQHJ<a> : LQDPMUOKECS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x62FA660", Offset = "0x62F9060", VA = "0x1862FA660")]
			public FCLUQSQKQHJ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x62FA5A0", Offset = "0x62F8FA0", VA = "0x1862FA5A0", Slot = "5")]
			public override void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x62FA3F0", Offset = "0x62F8DF0", VA = "0x1862FA3F0", Slot = "6")]
			public override void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class BTEPDEPBBMN<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static BTEPDEPBBMN<a> UIOXUQVVXGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly WBTKRRVZFNJ<a>[] LRQUVKCYOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int UAXTGVZXTAR;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x4F38700", Offset = "0x4F37100", VA = "0x184F38700")]
			public BTEPDEPBBMN(List<WBTKRRVZFNJ<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4F38350", Offset = "0x4F36D50", VA = "0x184F38350")]
			public void RSXNQYUMOFP(a a, XZTMHNLMAEW b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4F38400", Offset = "0x4F36E00", VA = "0x184F38400")]
			public void XQOFLNOTRCW(a a, VWTTVVYIPZU b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class NRNOGRJSQXX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract WBTKRRVZFNJ<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private XZTMHNLMAEW ZGHBPNWIBRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int YPNKTWGNYCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, NRNOGRJSQXX> QGGUOYAJYWQ;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3200", Offset = "0x8BD1C00", VA = "0x188BD3200")]
		public XHHDEPVBUOZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4124C10", Offset = "0x4123610", VA = "0x184124C10")]
		private BTEPDEPBBMN<d> CXBEYNGFMIW<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4125AE0", Offset = "0x41244E0", VA = "0x184125AE0")]
		public void WSFSWRIEDET<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x41259A0", Offset = "0x41243A0", VA = "0x1841259A0")]
		public bool Deserialize<T>(VWTTVVYIPZU reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4125A20", Offset = "0x4124420", VA = "0x184125A20")]
		public void NZJDRENIZKU<f>(XZTMHNLMAEW a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class VYHMXRTDIUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime OKBABSYYJDV;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] LFSCFHASJTT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator WBDNSQGPDDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2B60", Offset = "0x8BD1560", VA = "0x188BD2B60")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int MDXIABDKPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BD29C0", Offset = "0x8BD13C0", VA = "0x188BD29C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x8BD21C0", Offset = "0x8BD0BC0", VA = "0x188BD21C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode EPJXKROSIIV
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BD29F0", Offset = "0x8BD13F0", VA = "0x188BD29F0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1CB0", Offset = "0x8BD06B0", VA = "0x188BD1CB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int OWUMQHKTONQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2A20", Offset = "0x8BD1420", VA = "0x188BD2A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint EVUODLDZKOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2B90", Offset = "0x8BD1590", VA = "0x188BD2B90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? PIFFKWJUTVK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2200", Offset = "0x8BD0C00", VA = "0x188BD2200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? ZRQPRERVFQN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2230", Offset = "0x8BD0C30", VA = "0x188BD2230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? FNXQVNJRNXA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2190", Offset = "0x8BD0B90", VA = "0x188BD2190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2800", Offset = "0x8BD1200", VA = "0x188BD2800")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? AOAHIYVYJZM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF86E00", Offset = "0xF85800", VA = "0x180F86E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2CF0", Offset = "0x8BD16F0", VA = "0x188BD2CF0")]
		public VYHMXRTDIUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2C50", Offset = "0x8BD1650", VA = "0x188BD2C50")]
		internal VYHMXRTDIUM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1EB0", Offset = "0x8BD08B0", VA = "0x188BD1EB0")]
		public static VYHMXRTDIUM GYMGVUYSDES(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2260", Offset = "0x8BD0C60", VA = "0x188BD2260")]
		internal void QIEMTCEAJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2640", Offset = "0x8BD1040", VA = "0x188BD2640")]
		private void UAVNEADBNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1FC0", Offset = "0x8BD09C0", VA = "0x188BD1FC0")]
		private DateTime? ITNUZWPNEKZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1CF0", Offset = "0x8BD06F0", VA = "0x188BD1CF0")]
		private void GHVGPYNRDHH(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2AB0", Offset = "0x8BD14B0", VA = "0x188BD2AB0")]
		private ulong YZBBLQRNLFX(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1BF0", Offset = "0x8BD05F0", VA = "0x188BD1BF0")]
		private void BMZGAJPQPPH(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8BD25E0", Offset = "0x8BD0FE0", VA = "0x188BD25E0")]
		private uint RTRWLYVHAXQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8A87E80", Offset = "0x8A86880", VA = "0x188A87E80")]
		private static uint XTTZQMXWWVD(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2A50", Offset = "0x8BD1450", VA = "0x188BD2A50")]
		private static ulong XTTZQMXWWVD(ulong a)
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
	internal sealed class VXAYRRXADXL
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int FLDZCGHHWKO = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int QTMKIGQMVEX = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int ZXEULUXUCDG = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint ZPUIKRUNKPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int HHJESYHXRMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int FWHNJTYQWDU;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool FSUSTJAVCDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1AF0", Offset = "0x8BD04F0", VA = "0x188BD1AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1B00", Offset = "0x8BD0500", VA = "0x188BD1B00")]
		public bool MWQMSTEBNNG(KRBBMXZQAIM a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class CMJZOKFZALX : KRBBMXZQAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket PSTSKIQWPZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly VGPRGJKGPSA PYJWXMGLALK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short QNHHDYHGWAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2D70", Offset = "0x8BC1770", VA = "0x188BC2D70", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int XDGVVOZDLMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2D90", Offset = "0x8BC1790", VA = "0x188BC2D90", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint WPFKAKPCHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2D10", Offset = "0x8BC1710", VA = "0x188BC2D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily KSEQGFOKLYG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3305EC0", Offset = "0x33048C0", VA = "0x183305EC0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2DB0", Offset = "0x8BC17B0", VA = "0x188BC2DB0")]
		public CMJZOKFZALX(AddressFamily a, VGPRGJKGPSA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2640", Offset = "0x8BC1040", VA = "0x188BC2640", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2D30", Offset = "0x8BC1730", VA = "0x188BC2D30", Slot = "9")]
		public int JHQXFHOFDHT(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2C20", Offset = "0x8BC1620", VA = "0x188BC2C20", Slot = "10")]
		public int DYCBUBETLCD(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2C00", Offset = "0x8BC1600", VA = "0x188BC2C00", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface KRBBMXZQAIM
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short QNHHDYHGWAO
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int XDGVVOZDLMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint WPFKAKPCHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily KSEQGFOKLYG
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
		int JHQXFHOFDHT(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int DYCBUBETLCD(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x8BC71D0", Offset = "0x8BC5BD0", VA = "0x188BC71D0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7270", Offset = "0x8BC5C70", VA = "0x188BC7270")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x165B970", Offset = "0x165A370", VA = "0x18165B970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC70E0", Offset = "0x8BC5AE0", VA = "0x188BC70E0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC7120", Offset = "0x8BC5B20", VA = "0x188BC7120", Slot = "0")]
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
	public class YHEADMLLCAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string OKORWCWGLMZ = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int TTVXWUAWRWD = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int OYFPKCSJXNL = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int COFBOVQWSON = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> DSEHZJYQETC;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback YJZYLUYGUWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int QARJCCXXJHV;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		internal void BRCRSXUOFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		internal void AHJTQACSWKP(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class OEIHNXCFXWW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int WHTSVULIQPP;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
		protected OEIHNXCFXWW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void WJDYPJMLWGU(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void UDNRGLDUFVR(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class NQLLQQZWVJA : OEIHNXCFXWW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] ZOYFTTVDVER;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator HCMXCDRRQWX;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA170", Offset = "0x2BD8B70", VA = "0x182BDA170")]
		public NQLLQQZWVJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8BC66A0", Offset = "0x8BC50A0", VA = "0x188BC66A0")]
		public void GRYDSDTYANS(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6850", Offset = "0x8BC5250", VA = "0x188BC6850")]
		public void OCGOMDZCDGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6C30", Offset = "0x8BC5630", VA = "0x188BC6C30", Slot = "4")]
		public override void WJDYPJMLWGU(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8BC6930", Offset = "0x8BC5330", VA = "0x188BC6930", Slot = "5")]
		public override void UDNRGLDUFVR(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class NTVORHQQWZX
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8BD4540", Offset = "0x8BD2F40", VA = "0x188BD4540")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8BD46D0", Offset = "0x8BD30D0", VA = "0x188BD46D0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8BD42F0", Offset = "0x8BD2CF0", VA = "0x188BD42F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BC8AF0", Offset = "0x8BC74F0", VA = "0x188BC8AF0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8AC0", Offset = "0x8BC74C0", VA = "0x188BC8AC0")]
		private uint QQSGQGTHVSY(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCC60", Offset = "0x8BBB660", VA = "0x188BBCC60")]
		private void XOIMYJCEJPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC9C0", Offset = "0x8BBB3C0", VA = "0x188BBC9C0")]
		private void QXUKSZZFSDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BBCBD0", Offset = "0x8BBB5D0", VA = "0x188BBCBD0")]
		private void RLBPIRHTAXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBC8C0", Offset = "0x8BBB2C0", VA = "0x188BBC8C0")]
		private void IVTISUPEFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8A60", Offset = "0x8BC7460", VA = "0x188BC8A60")]
		private void IZGYFUDQEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8BE0", Offset = "0x8BC75E0", VA = "0x188BC8BE0")]
		private unsafe void UUVMPQXFGOC(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8BC89A0", Offset = "0x8BC73A0", VA = "0x188BC89A0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_000002A7$PostfixBurstDelegate))]
		public unsafe static void GQTGBFQETFZ([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8BC89B0", Offset = "0x8BC73B0", VA = "0x188BC89B0")]
		public static void GQTGBFQETFZ(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8BC88F0", Offset = "0x8BC72F0", VA = "0x188BC88F0")]
		public static void AWHSODSJVHZ(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8B70", Offset = "0x8BC7570", VA = "0x188BC8B70")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		internal unsafe static void SYZBHSPMYWS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8BD4850", Offset = "0x8BD3250", VA = "0x188BD4850")]
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
