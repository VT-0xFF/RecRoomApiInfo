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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ZTOWVYNIYPB
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
		private NetworkManager PNGIVIFGQAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool MCHYTGMSYAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, AKJAPHQGYVY> IJOVBBIWSPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MZHZGYRVCOF AVVJQXRWMWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch RIAIXTGBFYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] AQIQJGNKIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType VIOAJBDXFUB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int NITSPVPPNAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77B3120", Offset = "0x77B1F20", VA = "0x1877B3120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x77B30D0", Offset = "0x77B1ED0", VA = "0x1877B30D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77B2420", Offset = "0x77B1220", VA = "0x1877B2420")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77B2400", Offset = "0x77B1200", VA = "0x1877B2400")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77B2080", Offset = "0x77B0E80", VA = "0x1877B2080")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77B2F10", Offset = "0x77B1D10", VA = "0x1877B2F10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77B2530", Offset = "0x77B1330", VA = "0x1877B2530", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77B2170", Offset = "0x77B0F70", VA = "0x1877B2170", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77B2800", Offset = "0x77B1600", VA = "0x1877B2800", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77B2B80", Offset = "0x77B1980", VA = "0x1877B2B80", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77B1CC0", Offset = "0x77B0AC0", VA = "0x1877B1CC0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77B1BD0", Offset = "0x77B09D0", VA = "0x1877B1BD0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77B1DD0", Offset = "0x77B0BD0", VA = "0x1877B1DD0", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77B2790", Offset = "0x77B1590", VA = "0x1877B2790", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77B1E70", Offset = "0x77B0C70", VA = "0x1877B1E70", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77B1B00", Offset = "0x77B0900", VA = "0x1877B1B00")]
		private DeliveryMethod DQSDSHUJBIM(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77B2DA0", Offset = "0x77B1BA0", VA = "0x1877B2DA0", Slot = "16")]
		private void TAYSPCFAIXR(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77B2F30", Offset = "0x77B1D30", VA = "0x1877B2F30", Slot = "17")]
		private void VTPVBBKPDQH(AKJAPHQGYVY a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "18")]
		private void ZZWWICHBWWY(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77B21B0", Offset = "0x77B0FB0", VA = "0x1877B21B0", Slot = "19")]
		private void QHXKJVTWXJR(AKJAPHQGYVY a, YNEGQIYBCDP b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77B1A30", Offset = "0x77B0830", VA = "0x1877B1A30")]
		private void ALRPGUMHPMM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		private void KLWBITPJFGH(IPEndPoint a, YNEGQIYBCDP b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "21")]
		private void VORZUFUJDOB(AKJAPHQGYVY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77B2E60", Offset = "0x77B1C60", VA = "0x1877B2E60", Slot = "22")]
		private void TIUHXPKBNPD(BDDSFFUZVIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77B23D0", Offset = "0x77B11D0", VA = "0x1877B23D0")]
		private ulong RJKHRJCKHIO(AKJAPHQGYVY a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77B23B0", Offset = "0x77B11B0", VA = "0x1877B23B0")]
		private ulong RJKHRJCKHIO(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77B2EC0", Offset = "0x77B1CC0", VA = "0x1877B2EC0")]
		private static int ULZYIJZTLEX(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77B3000", Offset = "0x77B1E00", VA = "0x1877B3000")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77B2EE0", Offset = "0x77B1CE0", VA = "0x1877B2EE0")]
		[CompilerGenerated]
		private void URURCWRUUIJ(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x77B2EE0", Offset = "0x77B1CE0", VA = "0x1877B2EE0")]
		[CompilerGenerated]
		private void XQRTQFTXOGU(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class RMEDDXOHKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly AKJAPHQGYVY XDUHCBXENNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<UYPDASYCUQS> IAQCEYDVBUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PSSLJXSHPZF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GNYGKZTLBES
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x77BD6E0", Offset = "0x77BC4E0", VA = "0x1877BD6E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77BD790", Offset = "0x77BC590", VA = "0x1877BD790")]
		protected RMEDDXOHKPH(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77BD730", Offset = "0x77BC530", VA = "0x1877BD730")]
		public void ZLLMHVWVMGK(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77BD660", Offset = "0x77BC460", VA = "0x1877BD660")]
		protected void NDKUVSSMHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77BD620", Offset = "0x77BC420", VA = "0x1877BD620")]
		public bool NACDEHXXTMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool ZGAVMTADSRL();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool QQBQXHXGWXO(UYPDASYCUQS a);
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
	public class BDDSFFUZVIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MZHZGYRVCOF FESHRTSVHJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int NFDAAEWPZDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal VGFGDICEMTH VHWEADWXVVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint GQETUQIGEYM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult FKHMXBGPVWG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77AD270", Offset = "0x77AC070", VA = "0x1877AD270")]
		internal void SMGAFSXQCZJ(VGFGDICEMTH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77AD240", Offset = "0x77AC040", VA = "0x1877AD240")]
		private bool KFBOMYVONVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77AD2D0", Offset = "0x77AC0D0", VA = "0x1877AD2D0")]
		internal BDDSFFUZVIE(IPEndPoint a, VGFGDICEMTH b, MZHZGYRVCOF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x77AD1E0", Offset = "0x77ABFE0", VA = "0x1877AD1E0")]
		public AKJAPHQGYVY Accept()
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
		public YNEGQIYBCDP AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ZTOWVYNIYPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RIWVPPSAIFP(AKJAPHQGYVY a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HHFSZEZJNFX(AKJAPHQGYVY a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SJVZENVRSNE(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SYBXWZLYWSR(AKJAPHQGYVY a, YNEGQIYBCDP b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GITPZIZAZWB(IPEndPoint a, YNEGQIYBCDP b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GGWFFNDOEUT(AKJAPHQGYVY a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GVUIDQPEDWD(BDDSFFUZVIE a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface JFBJOASAHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AKWYVBCEXQH(AKJAPHQGYVY a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HCSZFBUHJWA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YHMPJHDEQYP(BJOMOTRJYQL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BORTHJZWLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PKUUFTNCTYC(AKJAPHQGYVY a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class VGFGDICEMTH
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int VKJEIEFOTAT = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long ALEJSGKTDZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte MVMQQFTLOMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] IRZUCPBNYZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly QZBYXHGJXZH YTUDXKSFVRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int TBSDNROCYZA;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77BF340", Offset = "0x77BE140", VA = "0x1877BF340")]
		private VGFGDICEMTH(long a, byte b, int c, byte[] d, QZBYXHGJXZH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77BEF40", Offset = "0x77BDD40", VA = "0x1877BEF40")]
		public static int HINCDWYOABC(UYPDASYCUQS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77BEF70", Offset = "0x77BDD70", VA = "0x1877BEF70")]
		public static VGFGDICEMTH JOZNNTTCSLN(UYPDASYCUQS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77BF160", Offset = "0x77BDF60", VA = "0x1877BF160")]
		public static UYPDASYCUQS TRLWQACHZKF(ABSNBGOLVYZ a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class PAIMRXHUJTW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long ALEJSGKTDZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte MVMQQFTLOMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int TBSDNROCYZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool YUDJVLBCAJT;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77BC310", Offset = "0x77BB110", VA = "0x1877BC310")]
		private PAIMRXHUJTW(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77BC120", Offset = "0x77BAF20", VA = "0x1877BC120")]
		public static PAIMRXHUJTW JOZNNTTCSLN(UYPDASYCUQS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77BC220", Offset = "0x77BB020", VA = "0x1877BC220")]
		public static UYPDASYCUQS TRLWQACHZKF(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77BC020", Offset = "0x77BAE20", VA = "0x1877BC020")]
		public static UYPDASYCUQS IICQQUHUVCD(AKJAPHQGYVY a)
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
	public interface FBVQYWTVLYL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JUGWJSIRCVA(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RIMBQOKIETS(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class BFQLIJFVAQG
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
		private class CWVWYXZWKAQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint LMFVQXDNQKS
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string SLWSKAZDOHW
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CWVWYXZWKAQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class IKTKELZVYWA
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint LMFVQXDNQKS
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint XKAVLIAABPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string SLWSKAZDOHW
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IKTKELZVYWA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class KLSJYDSNLBM
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string SLWSKAZDOHW
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool XIMKJLXUAEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABBF40", VA = "0x180ABD140")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KLSJYDSNLBM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MZHZGYRVCOF XVFRCZUFWLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> YIRMUWSVUZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> MIUGFEASSAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly QZBYXHGJXZH RYVVTFOBFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly ABSNBGOLVYZ FRGZOSNPLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly BELFVSLIQHA TNHJJKILEAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FBVQYWTVLYL UEPFYOENFEJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int CMIOVDPHLNS = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool SBIMSMQIHVJ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77ADC40", Offset = "0x77ACA40", VA = "0x1877ADC40")]
		internal BFQLIJFVAQG(MZHZGYRVCOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77AD920", Offset = "0x77AC720", VA = "0x1877AD920")]
		internal void PZCYTUAHTOT(IPEndPoint a, UYPDASYCUQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36183F0", Offset = "0x36171F0", VA = "0x1836183F0")]
		private void IDYEONHPVDX<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77AD790", Offset = "0x77AC590", VA = "0x1877AD790")]
		private void JUGWJSIRCVA(CWVWYXZWKAQ a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77AD630", Offset = "0x77AC430", VA = "0x1877AD630")]
		private void GSXJYPNNRJY(IKTKELZVYWA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77ADAA0", Offset = "0x77AC8A0", VA = "0x1877ADAA0")]
		private void TEAGUCUUVXN(KLSJYDSNLBM a, IPEndPoint b)
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
	public static class WWXQKOQEBBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] WUNDTLXWZCI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int JLYOPCHHAEK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int PFFANBCMUZN;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77B10E0", Offset = "0x77AFEE0", VA = "0x1877B10E0")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77B10E0", Offset = "0x77AFEE0", VA = "0x1877B10E0")]
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
	public interface VZSALRUBJZX
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AXWXHHCXOSZ(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class FNPRPKUMAWB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static VZSALRUBJZX YWDKRTOZIIP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object QVEZPSQDNAX;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77B04F0", Offset = "0x77AF2F0", VA = "0x1877B04F0")]
		private static void FXYKXWERTDG(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77B0780", Offset = "0x77AF580", VA = "0x1877B0780")]
		internal static void NVZKLKCDIMM(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77B0720", Offset = "0x77AF520", VA = "0x1877B0720")]
		internal static void NBOCQIWCELI(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77B07E0", Offset = "0x77AF5E0", VA = "0x1877B07E0")]
		internal static void OMZZMRMCIEI(string a, params object[] args)
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
	public sealed class YNEGQIYBCDP : QZBYXHGJXZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private UYPDASYCUQS YOWNKABUADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly MZHZGYRVCOF XTNYCCRRYWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly KLOSQWAALIK NQASVPJFCOJ;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77BF640", Offset = "0x77BE440", VA = "0x1877BF640")]
		internal YNEGQIYBCDP(MZHZGYRVCOF a, KLOSQWAALIK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77BF5D0", Offset = "0x77BE3D0", VA = "0x1877BF5D0")]
		internal void WOVSMTJHCXK(UYPDASYCUQS a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77BF520", Offset = "0x77BE320", VA = "0x1877BF520")]
		internal void VCTBLVRPXDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77BF5A0", Offset = "0x77BE3A0", VA = "0x1877BF5A0")]
		public void WCWQDCEYKSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class KLOSQWAALIK
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
		public KLOSQWAALIK PVDFPFOYGDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType QCFSUOQZRCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AKJAPHQGYVY XDUHCBXENNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint GQETUQIGEYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object FXBMCHJBTXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int GXGEFVMIVOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError EBMGKWTFWZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason JWDAPLPOVSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BDDSFFUZVIE BDDSFFUZVIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod LPPBHUXXRNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte ZNDTIXTQRCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly YNEGQIYBCDP EBERRXZXHKY;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77B1890", Offset = "0x77B0690", VA = "0x1877B1890")]
		public KLOSQWAALIK(MZHZGYRVCOF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class MZHZGYRVCOF : IEnumerable<AKJAPHQGYVY>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class WKDJXUDQIBG : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x77BF3B0", Offset = "0x77BE1B0", VA = "0x1877BF3B0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x77BF420", Offset = "0x77BE220", VA = "0x1877BF420", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WKDJXUDQIBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<AKJAPHQGYVY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly AKJAPHQGYVY _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private AKJAPHQGYVY _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public AKJAPHQGYVY Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D0ACD0", Offset = "0x1D09AD0", VA = "0x181D0ACD0")]
			public NetPeerEnumerator(AKJAPHQGYVY p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x77BBF90", Offset = "0x77BAD90", VA = "0x1877BBF90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x77BBFE0", Offset = "0x77BADE0", VA = "0x1877BBFE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread LPVFXELMYNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool THYBZKIBVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool BXGMMQUGDVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private RGZPEAAMONA WEYLMJRMWNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent ZQHIWRGJFSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<KLOSQWAALIK> SYQYVWCZJIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<KLOSQWAALIK> IZVNGCKBQXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KLOSQWAALIK VYVBWIIXFZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly ZTOWVYNIYPB HGGCAMAZKAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly JFBJOASAHDI OATGYDQRREM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly HCSZFBUHJWA GHKQBOQCTQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly BORTHJZWLDA VMHASILTWQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, AKJAPHQGYVY> IABMAWZZWAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, BDDSFFUZVIE> OIEQBCWLSJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, KLPKBFSOOUY> TMWRPRTIIWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim MMPYZDNUXPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private AKJAPHQGYVY UDDFVBNHYJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int YFAALDKEGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<AKJAPHQGYVY> PRMEBJHTMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private AKJAPHQGYVY[] WDNZNSZFSOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly OMEQSRIDONX HVQHBUNFFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int GJPOMYNUGIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> DSYBCNMMQKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte FXLPNZQALNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object ZLXSUZVPFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool GATTDOZLLNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool TXZKYFFHPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int WWPMQNIUFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int IRAHTMXTBIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int VGARZPNLOTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int IBFMFWKKQEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool QUYPMGWWLDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool IXMSGASSVNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int CQHGPBBBPAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int UTPJHUDOHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int WSHGQAWTPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool SBIMSMQIHVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool LXVPZAPHAWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool XUWTDXFPECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool QYEMJSGJNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int BPIAMKYKGTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int PVAAKFJKWQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool FCBKDPVDIQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly KKPEVFYFQAF QSJVEWIHCYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool VLCKSCJVPSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly BFQLIJFVAQG BFQLIJFVAQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool WXAHCMZUJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode FNWQUEWHHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int JZEYDLYAZKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool MMSRZPRYLIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool PYWQJIPCENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool OKQNSIFWONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool PUMHLUSZNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private UYPDASYCUQS MIMMJOBTVDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int TRXCRPXGCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object AOOLJNSYVWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private UYPDASYCUQS ICWUZSXWQWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int KANRZAABYOE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int AQSEPKRNKMI = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int UQZOFUCHBOR = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private ACPZTYJTQIL RAPBXKQSDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private ACPZTYJTQIL RAZPRYEMWJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread FFBTTJBKKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread FERFYVNPSBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint NNBEOPHWHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint NMQQUBUBOYP;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] TURODXKARUV;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] DJSLEFSYMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> MSBMRGHOQBY;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress RBPICSPLHBH;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool LLSVXBOZFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int MXVVUNGMVQB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ABCKEUAFXRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB80790", Offset = "0xB7F590", VA = "0x180B80790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBE20B0", Offset = "0xBE0EB0", VA = "0x180BE20B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int UGNUPSVJXVL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB4CD70", Offset = "0xB4BB70", VA = "0x180B4CD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBAA180", Offset = "0xBA8F80", VA = "0x180BAA180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte JEJCLZQGGFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE1D040", Offset = "0xE1BE40", VA = "0x180E1D040")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int LAIXXHUQWZU
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x77BA520", Offset = "0x77B9320", VA = "0x1877BA520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short FZRZCTUXIIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x77B5480", Offset = "0x77B4280", VA = "0x1877B5480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AKJAPHQGYVY.OnUpdatedMtuDelegate MGSILLUASYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x77B4400", Offset = "0x77B3200", VA = "0x1877B4400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x77B8620", Offset = "0x77B7420", VA = "0x1877B8620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x77B71F0", Offset = "0x77B5FF0", VA = "0x1877B71F0")]
		public void LESFSGPHFYT(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77BA3D0", Offset = "0x77B91D0", VA = "0x1877BA3D0")]
		public void XNCJXOCPEDQ(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77B5870", Offset = "0x77B4670", VA = "0x1877B5870")]
		private bool IZKFYDENMYQ(IPEndPoint a, [Out] AKJAPHQGYVY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x77B7410", Offset = "0x77B6210", VA = "0x1877B7410")]
		private void LKZFJWNWEAS(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77B43A0", Offset = "0x77B31A0", VA = "0x1877B43A0")]
		private void EWZPGSVCSJZ(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77B89A0", Offset = "0x77B77A0", VA = "0x1877B89A0")]
		private void SREFXXGFUJY(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x77BAA70", Offset = "0x77B9870", VA = "0x1877BAA70")]
		public MZHZGYRVCOF(ZTOWVYNIYPB a, [Optional] OMEQSRIDONX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x77B7000", Offset = "0x77B5E00", VA = "0x1877B7000")]
		internal void KCAIQOIEHYS(AKJAPHQGYVY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77B4350", Offset = "0x77B3150", VA = "0x1877B4350")]
		internal void DXUMMLZJGCG(AKJAPHQGYVY a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x77B5540", Offset = "0x77B4340", VA = "0x1877B5540")]
		internal void HUVOUBLJWLS(AKJAPHQGYVY a, DisconnectReason b, SocketError c, UYPDASYCUQS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x77BA5C0", Offset = "0x77B93C0", VA = "0x1877BA5C0")]
		private void ZOMQLJKBYVX(AKJAPHQGYVY a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, UYPDASYCUQS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77B6C30", Offset = "0x77B5A30", VA = "0x1877B6C30")]
		private void JKNABMHVIWJ(KLOSQWAALIK.EType a, [Optional] AKJAPHQGYVY b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] BDDSFFUZVIE g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] UYPDASYCUQS j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x77B4CC0", Offset = "0x77B3AC0", VA = "0x1877B4CC0")]
		private void GBPPPFGNNUY(KLOSQWAALIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x77B5700", Offset = "0x77B4500", VA = "0x1877B5700")]
		internal void IKHYFHGFVGQ(KLOSQWAALIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x77B9EB0", Offset = "0x77B8CB0", VA = "0x1877B9EB0")]
		private void XFAGYTXWVAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x77B3310", Offset = "0x77B2110", VA = "0x1877B3310")]
		private void AFSKWTNQUOQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x77B3640", Offset = "0x77B2440", VA = "0x1877B3640")]
		internal AKJAPHQGYVY BFMKALVBXKP(BDDSFFUZVIE a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x77B3290", Offset = "0x77B2090", VA = "0x1877B3290")]
		private int AFQQFTTMDAB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x77B8180", Offset = "0x77B6F80", VA = "0x1877B8180")]
		private void RENVBIEOJFB(IPEndPoint a, AKJAPHQGYVY b, VGFGDICEMTH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x77B5910", Offset = "0x77B4710", VA = "0x1877B5910")]
		private void JGQZDMXUTPM(UYPDASYCUQS a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x77B86D0", Offset = "0x77B74D0", VA = "0x1877B86D0")]
		internal void SIUUALSFUPO(UYPDASYCUQS a, DeliveryMethod b, byte c, int d, AKJAPHQGYVY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x77B9470", Offset = "0x77B8270", VA = "0x1877B9470")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x77B93D0", Offset = "0x77B81D0", VA = "0x1877B93D0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x77B93F0", Offset = "0x77B81F0", VA = "0x1877B93F0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77B9D00", Offset = "0x77B8B00", VA = "0x1877B9D00")]
		public void WKNBTPRQYSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x77B4270", Offset = "0x77B3070", VA = "0x1877B4270")]
		public AKJAPHQGYVY Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x77B3DC0", Offset = "0x77B2BC0", VA = "0x1877B3DC0")]
		public AKJAPHQGYVY Connect(string address, int port, ABSNBGOLVYZ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x77B3EA0", Offset = "0x77B2CA0", VA = "0x1877B3EA0")]
		public AKJAPHQGYVY Connect(IPEndPoint target, ABSNBGOLVYZ connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77B94E0", Offset = "0x77B82E0", VA = "0x1877B94E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77B94F0", Offset = "0x77B82F0", VA = "0x1877B94F0")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77B5580", Offset = "0x77B4380", VA = "0x1877B5580")]
		public void HWHWVECHAAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77B5630", Offset = "0x77B4430", VA = "0x1877B5630")]
		public void HWHWVECHAAU(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77BA540", Offset = "0x77B9340", VA = "0x1877BA540")]
		public void ZOMQLJKBYVX(AKJAPHQGYVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77BA580", Offset = "0x77B9380", VA = "0x1877BA580")]
		public void ZOMQLJKBYVX(AKJAPHQGYVY a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x77B7D50", Offset = "0x77B6B50", VA = "0x1877B7D50", Slot = "4")]
		private IEnumerator<AKJAPHQGYVY> NUVZUCUFIAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x77B9C70", Offset = "0x77B8A70", VA = "0x1877B9C70", Slot = "5")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x77BA2F0", Offset = "0x77B90F0", VA = "0x1877BA2F0")]
		private UYPDASYCUQS XKRGGJTCRPM(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x77BA210", Offset = "0x77B9010", VA = "0x1877BA210")]
		private UYPDASYCUQS XKRGGJTCRPM(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x77B7B10", Offset = "0x77B6910", VA = "0x1877B7B10")]
		internal UYPDASYCUQS NSZKGHMPVVN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x77B78B0", Offset = "0x77B66B0", VA = "0x1877B78B0")]
		internal void MRHDRFFOTBQ(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x77BA9B0", Offset = "0x77B97B0", VA = "0x1877BA9B0")]
		static MZHZGYRVCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB80790", Offset = "0xB7F590", VA = "0x180B80790")]
		private bool VZFJAZRJIEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x77B9B10", Offset = "0x77B8910", VA = "0x1877B9B10")]
		private void URBTENEBRNB(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x77B3C70", Offset = "0x77B2A70", VA = "0x1877B3C70")]
		private void BUUZTCJUDCY(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x77B7050", Offset = "0x77B5E50", VA = "0x1877B7050")]
		private bool LEGZZGYVUFY(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x77B7DE0", Offset = "0x77B6BE0", VA = "0x1877B7DE0")]
		private void OXBNLBRZXWJ(RGZPEAAMONA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x77B9850", Offset = "0x77B8650", VA = "0x1877B9850")]
		private void TPXLDTMWVMC(ACPZTYJTQIL a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x77B7E00", Offset = "0x77B6C00", VA = "0x1877B7E00")]
		private void PHRYUIJMOHU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x77B8C60", Offset = "0x77B7A60", VA = "0x1877B8C60")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x77B5810", Offset = "0x77B4610", VA = "0x1877B5810")]
		internal int IXCXAQSWETN(UYPDASYCUQS a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x77B4C80", Offset = "0x77B3A80", VA = "0x1877B4C80")]
		internal int FVXWNHRJCZT(UYPDASYCUQS a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x77B44B0", Offset = "0x77B32B0", VA = "0x1877B44B0")]
		internal int FVXWNHRJCZT(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x77B7730", Offset = "0x77B6530", VA = "0x1877B7730")]
		internal void MREPVMAXNFG(bool a)
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
	internal sealed class UYPDASYCUQS
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int NLDEJKLPEEN;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] USISXOQIQLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] DPZRQZCAAXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int EPHMJNQYOKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object FXBMCHJBTXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public UYPDASYCUQS PVDFPFOYGDQ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty DETGYEJXBPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x77BE9A0", Offset = "0x77BD7A0", VA = "0x1877BE9A0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x77BE870", Offset = "0x77BD670", VA = "0x1877BE870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte MVMQQFTLOMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x77BE740", Offset = "0x77BD540", VA = "0x1877BE740")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x77BE920", Offset = "0x77BD720", VA = "0x1877BE920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort HZCJCGCQOSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x77BEAB0", Offset = "0x77BD8B0", VA = "0x1877BEAB0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x77BE960", Offset = "0x77BD760", VA = "0x1877BE960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool USUBJWNYLMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x77BE8B0", Offset = "0x77BD6B0", VA = "0x1877BE8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte IVHMQNESOKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x77BE5F0", Offset = "0x77BD3F0", VA = "0x1877BE5F0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x77BEA00", Offset = "0x77BD800", VA = "0x1877BEA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort VQUMJCGODYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x77BEA70", Offset = "0x77BD870", VA = "0x1877BEA70")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x77BEAD0", Offset = "0x77BD8D0", VA = "0x1877BEAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort OYAHVYZKQAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x77BE620", Offset = "0x77BD420", VA = "0x1877BE620")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x77BE8E0", Offset = "0x77BD6E0", VA = "0x1877BE8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort YEGJYPIGWKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x77BEA90", Offset = "0x77BD890", VA = "0x1877BEA90")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x77BEA30", Offset = "0x77BD830", VA = "0x1877BEA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x77BEB10", Offset = "0x77BD910", VA = "0x1877BEB10")]
		static UYPDASYCUQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77BE9D0", Offset = "0x77BD7D0", VA = "0x1877BE9D0")]
		public void QIGODXRQDZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77BEED0", Offset = "0x77BDCD0", VA = "0x1877BEED0")]
		public UYPDASYCUQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x77BEDC0", Offset = "0x77BDBC0", VA = "0x1877BEDC0")]
		public UYPDASYCUQS(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77BE800", Offset = "0x77BD600", VA = "0x1877BE800")]
		public static int HPFQSIRGZJP(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77BE770", Offset = "0x77BD570", VA = "0x1877BE770")]
		public int HPFQSIRGZJP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x77BE640", Offset = "0x77BD440", VA = "0x1877BE640")]
		public bool DPUKGUYRUAC()
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
	public class AKJAPHQGYVY
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class AUYTCIEKGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public UYPDASYCUQS[] PEHIDLFQEBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int PUGQMQTQTTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int BIBEBWEHDWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte IVHMQNESOKP;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public AUYTCIEKGJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int VDPWUJQAQIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int EEPZVCEGDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int IPLRHIUDPVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double DDUSIFTHSKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int NXQNALSABRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int EJOFXGFKHRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int PMKXIISLWTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch POHQDPRTAVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int CCRKNZCWHUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long JSBLEIFWTCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object TSEKVLUWFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal AKJAPHQGYVY NXIFYXROXMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal AKJAPHQGYVY ZGBCLSTUNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<UYPDASYCUQS> UBWQQJOAPQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<RMEDDXOHKPH> YWUOWBJCWWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly RMEDDXOHKPH[] KWVRFLGERIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int KAZPXQTLKXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int TGHMPUQWVTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool KDYZNBZTFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int UWQKQWOGTRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int HKTXXDVBMGG;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int NPKAGHMRKDU = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int WRGTWEMMKER = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object FGTZUDGMZJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int YVRRKVZAAYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, AUYTCIEKGJC> FOCGBLXYHEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> TCGERTJBVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly UYPDASYCUQS RPXGTNDBLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int YTWADBAXPZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int ZWPATRQNDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint BDSABBEFOWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int OMCPLKMGIRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int QCNARXIMABV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long CQJQGVRYQCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte FHUJQKOWMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState MBDHWHFNRFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private UYPDASYCUQS OTQOFTEAZRM;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int YADUMGRLNLW = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int JDDVANMWQCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly UYPDASYCUQS DRYLKFBDARG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly UYPDASYCUQS WIJKDSYBZEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly UYPDASYCUQS MRBLIHTOPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly UYPDASYCUQS HANRSRIYKZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality KRILBBXQHTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly MZHZGYRVCOF MZHZGYRVCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int QXVQSTMOTBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object DOFLWACKTRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly KKPEVFYFQAF QSJVEWIHCYE;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte DMDXXEHIPLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAEB700", Offset = "0xAEA500", VA = "0x180AEB700")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x77A9610", Offset = "0x77A8410", VA = "0x1877A9610")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint TEHMODLAZAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB880E0", Offset = "0xB86EE0", VA = "0x180B880E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState RXMCNRUJGZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xB880A0", Offset = "0xB86EA0", VA = "0x180B880A0")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long NAKHCKEMLGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC7170", Offset = "0xAC5F70", VA = "0x180AC7170")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int WLFCCIDKYRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB4CD70", Offset = "0xB4BB70", VA = "0x180B4CD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xBAA180", Offset = "0xBA8F80", VA = "0x180BAA180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int NTZHVRZMIQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x77A9950", Offset = "0x77A8750", VA = "0x1877A9950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int BVFAVVVDWNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double DIEKVPHVEXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2A27450", Offset = "0x2A26250", VA = "0x182A27450")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate MGSILLUASYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x77A9F50", Offset = "0x77A8D50", VA = "0x1877A9F50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x77AB6F0", Offset = "0x77AA4F0", VA = "0x1877AB6F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x77ACDE0", Offset = "0x77ABBE0", VA = "0x1877ACDE0")]
		internal AKJAPHQGYVY(MZHZGYRVCOF a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x77AB890", Offset = "0x77AA690", VA = "0x1877AB890")]
		internal void SSLVFXZCHZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x77A9510", Offset = "0x77A8310", VA = "0x1877A9510")]
		internal void BTLEDDXAEDT(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x77A9480", Offset = "0x77A8280", VA = "0x1877A9480")]
		internal void BOABGGCLEHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x77A9540", Offset = "0x77A8340", VA = "0x1877A9540")]
		private void DABKNZAWZIH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x77AA420", Offset = "0x77A9220", VA = "0x1877AA420")]
		private void KGUINOQLWGF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x77ABBC0", Offset = "0x77AA9C0", VA = "0x1877ABBC0")]
		public int UWUYMJXAIBX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x77ABCD0", Offset = "0x77AAAD0", VA = "0x1877ABCD0")]
		public int UWUYMJXAIBX(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x77AA460", Offset = "0x77A9260", VA = "0x1877AA460")]
		private RMEDDXOHKPH OSHTXEYNPDM(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x77ACC50", Offset = "0x77ABA50", VA = "0x1877ACC50")]
		internal AKJAPHQGYVY(MZHZGYRVCOF a, IPEndPoint b, int c, byte d, ABSNBGOLVYZ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x77ACA70", Offset = "0x77AB870", VA = "0x1877ACA70")]
		internal AKJAPHQGYVY(MZHZGYRVCOF a, BDDSFFUZVIE b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x77AB7A0", Offset = "0x77AA5A0", VA = "0x1877AB7A0")]
		internal void Reject(VGFGDICEMTH requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x77AC4C0", Offset = "0x77AB2C0", VA = "0x1877AC4C0")]
		internal bool VRGNWYMQVLY(PAIMRXHUJTW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x77AA3F0", Offset = "0x77A91F0", VA = "0x1877AA3F0")]
		public void IDYEONHPVDX(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x77A9960", Offset = "0x77A8760", VA = "0x1877A9960")]
		private void EQKMXGDQIOI(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x77A98C0", Offset = "0x77A86C0", VA = "0x1877A98C0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x77AB7F0", Offset = "0x77AA5F0", VA = "0x1877AB7F0")]
		internal DisconnectResult SHHUDYBEXUK(UYPDASYCUQS a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x77AA000", Offset = "0x77A8E00", VA = "0x1877AA000")]
		internal void GBLABPGVFYJ(RMEDDXOHKPH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x77AB8B0", Offset = "0x77AA6B0", VA = "0x1877AB8B0")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77A9910", Offset = "0x77A8710", VA = "0x1877A9910")]
		private void EEFHOTGAJBG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x77AAC90", Offset = "0x77A9A90", VA = "0x1877AAC90")]
		internal void RBNXJNAZBLW(DeliveryMethod a, UYPDASYCUQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x77AC540", Offset = "0x77AB340", VA = "0x1877AC540")]
		private void XZGKYLCEVZS(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x77AA060", Offset = "0x77A8E60", VA = "0x1877AA060")]
		private void GKIAJENRCHW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77AB530", Offset = "0x77AA330", VA = "0x1877AB530")]
		internal ConnectRequestResult RENVBIEOJFB(VGFGDICEMTH a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x77AA5F0", Offset = "0x77A93F0", VA = "0x1877AA5F0")]
		internal void QQBQXHXGWXO(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77A9330", Offset = "0x77A8130", VA = "0x1877A9330")]
		private void APMOARAYNYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77A96C0", Offset = "0x77A84C0", VA = "0x1877A96C0")]
		internal void DSOZUUOPSXY(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x77ABDF0", Offset = "0x77AABF0", VA = "0x1877ABDF0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x77A90D0", Offset = "0x77A7ED0", VA = "0x1877A90D0")]
		internal void AISLAOBZMBQ(UYPDASYCUQS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class KKPEVFYFQAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long IZFGGPINFJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long QMOMDFOVDBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long IHZVHAXOWGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long NBQJRXNTDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long NKHUJDRIKDJ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long FVQJXKYPNVI;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long GICCGUPVRUP;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long GRSZZPXOGWU;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long XMAUVAYULOZ;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long JWINNUMPYJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long HPJHHHXMSQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long TYATOOXBXZP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long JKAWYLFLJZY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x77B13F0", Offset = "0x77B01F0", VA = "0x1877B13F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long THHGRDEWCUL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x77B10F0", Offset = "0x77AFEF0", VA = "0x1877B10F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long VVNIAMWGNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x77B1220", Offset = "0x77B0020", VA = "0x1877B1220")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long UEADPZLZMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x77B17E0", Offset = "0x77B05E0", VA = "0x1877B17E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long ITOQQIIQXGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x77B1800", Offset = "0x77B0600", VA = "0x1877B1800")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long YWTRBZUNKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x77B17F0", Offset = "0x77B05F0", VA = "0x1877B17F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long WTEJFDCWQEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x77B1810", Offset = "0x77B0610", VA = "0x1877B1810")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long NQRWKBQVVGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x77B1850", Offset = "0x77B0650", VA = "0x1877B1850")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality PLLHXEWDZLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double FJFJRIZNTMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x77B1390", Offset = "0x77B0190", VA = "0x1877B1390")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x77B1400", Offset = "0x77B0200", VA = "0x1877B1400")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77B11C0", Offset = "0x77AFFC0", VA = "0x1877B11C0")]
		public void GOZELHGNIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x77B1230", Offset = "0x77B0030", VA = "0x1877B1230")]
		public void IPBSYPOCEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x77B1160", Offset = "0x77AFF60", VA = "0x1877B1160")]
		public void GESTBJMBYBB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77B1440", Offset = "0x77B0240", VA = "0x1877B1440")]
		public void TELOSXTWJMK(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x77B1100", Offset = "0x77AFF00", VA = "0x1877B1100")]
		public void EQRLBMDEAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77B1320", Offset = "0x77B0120", VA = "0x1877B1320")]
		public void MGWJLAJHYCR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x77B14A0", Offset = "0x77B02A0", VA = "0x1877B14A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77B1280", Offset = "0x77B0080", VA = "0x1877B1280")]
		public void LIQOUXKYWVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KKPEVFYFQAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class TQFTQQGXILR
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> USATIHJHONY;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77BE1B0", Offset = "0x77BCFB0", VA = "0x1877BE1B0")]
		public static IPEndPoint XKWEASHEKGI(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77BDF60", Offset = "0x77BCD60", VA = "0x1877BDF60")]
		public static IPAddress OBITBSWWQLR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77BE120", Offset = "0x77BCF20", VA = "0x1877BE120")]
		public static IPAddress OBITBSWWQLR(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77BDF30", Offset = "0x77BCD30", VA = "0x1877BDF30")]
		internal static int EJCKATMMFLZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D396A0", Offset = "0x3D384A0", VA = "0x183D396A0")]
		internal static T[] YMSLBBJKKLI<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class FNKNIIOOXBG : RMEDDXOHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private UYPDASYCUQS _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x77BC4A0", Offset = "0x77BB2A0", VA = "0x1877BC4A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x77BC480", Offset = "0x77BB280", VA = "0x1877BC480")]
			public void RWFLESYWDGJ(UYPDASYCUQS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x77BC410", Offset = "0x77BB210", VA = "0x1877BC410")]
			public bool FQRBAVKDYBE(long a, AKJAPHQGYVY b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x77BC3C0", Offset = "0x77BB1C0", VA = "0x1877BC3C0")]
			public bool Clear(AKJAPHQGYVY peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly UYPDASYCUQS DRIOHAOTHSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] RNAETJGVHTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly UYPDASYCUQS[] AACIGUFNUUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] KHOIGQAHZZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int IHZOKYGTUIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int BKVPQEQGKYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int DRHZMPGRLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int SYURLXVZNYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool SKRBFYCHFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod MEESFJUNXEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LPGHYWPBEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int VPVTVHGOZHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte VRXOEZOKJWV;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int CELELDVUEFY
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x77AFE50", Offset = "0x77AEC50", VA = "0x1877AFE50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x77B0330", Offset = "0x77AF130", VA = "0x1877B0330")]
		public FNKNIIOOXBG(AKJAPHQGYVY a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x77AF4D0", Offset = "0x77AE2D0", VA = "0x1877AF4D0")]
		private void GANVEYVPZCN(UYPDASYCUQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x77AFE60", Offset = "0x77AEC60", VA = "0x1877AFE60", Slot = "4")]
		protected override bool ZGAVMTADSRL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x77AF850", Offset = "0x77AE650", VA = "0x1877AF850", Slot = "5")]
		public override bool QQBQXHXGWXO(UYPDASYCUQS a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class IOILOXCOKVP : RMEDDXOHKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int KZTDIWWALFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort BKVPQEQGKYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool UNIKUIRXURM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private UYPDASYCUQS GTDRRGALNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly UYPDASYCUQS NYSNCTVNDSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool MATOJJABPEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte VRXOEZOKJWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long SIMSOHDGZYT;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x77B1020", Offset = "0x77AFE20", VA = "0x1877B1020")]
		public IOILOXCOKVP(AKJAPHQGYVY a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x77B0B60", Offset = "0x77AF960", VA = "0x1877B0B60", Slot = "4")]
		protected override bool ZGAVMTADSRL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x77B08E0", Offset = "0x77AF6E0", VA = "0x1877B08E0", Slot = "5")]
		public override bool QQBQXHXGWXO(UYPDASYCUQS a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class NBWONLEJMRG
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
		[Cpp2IlInjected.Address(RVA = "0x77A7D50", Offset = "0x77A6B50", VA = "0x1877A7D50")]
		private static void VGSEDTSLWRP(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x77BB030", Offset = "0x77B9E30", VA = "0x1877BB030")]
		private static void VGSEDTSLWRP(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0A0", Offset = "0x77B9EA0", VA = "0x1877BB0A0")]
		public static void VGSEDTSLWRP(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0F0", Offset = "0x77B9EF0", VA = "0x1877BB0F0")]
		public static void ZEBHRTIUUAI(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x77BB110", Offset = "0x77B9F10", VA = "0x1877BB110")]
		public static void ZEBHRTIUUAI(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0A0", Offset = "0x77B9EA0", VA = "0x1877BB0A0")]
		public static void ZEBHRTIUUAI(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0A0", Offset = "0x77B9EA0", VA = "0x1877BB0A0")]
		public static void ZEBHRTIUUAI(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x77BB030", Offset = "0x77B9E30", VA = "0x1877BB030")]
		public static void ZEBHRTIUUAI(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x77BB030", Offset = "0x77B9E30", VA = "0x1877BB030")]
		public static void ZEBHRTIUUAI(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0E0", Offset = "0x77B9EE0", VA = "0x1877BB0E0")]
		public static void ZEBHRTIUUAI(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77BB0E0", Offset = "0x77B9EE0", VA = "0x1877BB0E0")]
		public static void ZEBHRTIUUAI(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class QZBYXHGJXZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] XSMUKZOICPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int KEDWXZSAMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int JBJOOPHUEUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int ZCVCYLIDBEH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] DPZRQZCAAXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int TPJRFEOFMSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int WCQYTCINKVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x77BD570", Offset = "0x77BC370", VA = "0x1877BD570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HOFWKYUPMDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x298FF60", Offset = "0x298ED60", VA = "0x18298FF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int UYMPVMRQZFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x77BD1F0", Offset = "0x77BBFF0", VA = "0x1877BD1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x77BD580", Offset = "0x77BC380", VA = "0x1877BD580")]
		public void WOVSMTJHCXK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public QZBYXHGJXZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x77BD5C0", Offset = "0x77BC3C0", VA = "0x1877BD5C0")]
		public QZBYXHGJXZH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x77BD4E0", Offset = "0x77BC2E0", VA = "0x1877BD4E0")]
		public IPEndPoint UKRIZGWPTRH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x77BD0B0", Offset = "0x77BBEB0", VA = "0x1877BD0B0")]
		public byte CYJKMDOVKKH()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x77BD0B0", Offset = "0x77BBEB0", VA = "0x1877BD0B0")]
		public sbyte LMZWAIAXGMU()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3C27830", Offset = "0x3C26630", VA = "0x183C27830")]
		public a[] NPYJVQUHHQW<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x77BD200", Offset = "0x77BC000", VA = "0x1877BD200")]
		public bool[] KRHQLISAPXY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x77BD280", Offset = "0x77BC080", VA = "0x1877BD280")]
		public ushort[] OBHYBSWJPKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x77BD370", Offset = "0x77BC170", VA = "0x1877BD370")]
		public short[] RFLSYDQTHEW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x77BD3F0", Offset = "0x77BC1F0", VA = "0x1877BD3F0")]
		public int[] RVBFEPBZCVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x77BD4A0", Offset = "0x77BC2A0", VA = "0x1877BD4A0")]
		public uint[] TEDGNYEJSQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x77BD3B0", Offset = "0x77BC1B0", VA = "0x1877BD3B0")]
		public float[] RHIWILDOAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x77BD240", Offset = "0x77BC040", VA = "0x1877BD240")]
		public double[] MKYXHRYDOSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x77BD330", Offset = "0x77BC130", VA = "0x1877BD330")]
		public long[] QSVSHKCXNDS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x77BD1B0", Offset = "0x77BBFB0", VA = "0x1877BD1B0")]
		public ulong[] HGBLUIJIIVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x77BCDA0", Offset = "0x77BBBA0", VA = "0x1877BCDA0")]
		public string[] BCRSGPLCITD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x77BD430", Offset = "0x77BC230", VA = "0x1877BD430")]
		public bool RXGZVDFHRJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x77BD110", Offset = "0x77BBF10", VA = "0x1877BD110")]
		public char DJIFYBZGJFT()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x77BD110", Offset = "0x77BBF10", VA = "0x1877BD110")]
		public ushort HFNMBYQEMEO()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x77BD110", Offset = "0x77BBF10", VA = "0x1877BD110")]
		public short RRXQMXMEBXP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x77BD2C0", Offset = "0x77BC0C0", VA = "0x1877BD2C0")]
		public long SGSNBPGNPZB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x77BD2C0", Offset = "0x77BC0C0", VA = "0x1877BD2C0")]
		public ulong PJLZMABSFVE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x77BCE70", Offset = "0x77BBC70", VA = "0x1877BCE70")]
		public int BUCKMWIGAPM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x77BCE70", Offset = "0x77BBC70", VA = "0x1877BCE70")]
		public uint CFKDOQSMVAR()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x77BD180", Offset = "0x77BBF80", VA = "0x1877BD180")]
		public float GWGHEQORKHT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x77BD470", Offset = "0x77BC270", VA = "0x1877BD470")]
		public double SNZXIKNDNMI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x77BCEA0", Offset = "0x77BBCA0", VA = "0x1877BCEA0")]
		public string CMBNBSIGIWQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x77BCD30", Offset = "0x77BBB30", VA = "0x1877BCD30")]
		public ArraySegment<byte> AQTSSEGGURP(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x77BD2F0", Offset = "0x77BC0F0", VA = "0x1877BD2F0")]
		public sbyte[] QBRBOKQZWCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x77BD140", Offset = "0x77BBF40", VA = "0x1877BD140")]
		public byte[] EFSJPSKMGZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77BD0F0", Offset = "0x77BBEF0", VA = "0x1877BD0F0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ABSNBGOLVYZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] XSMUKZOICPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int KEDWXZSAMHF;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int OLXWLFCMDJW = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool FIGCJKTWSPZ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding YJIQQYLTKIV;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int BQQRHOWHGXI = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] LBXQKVXNPXN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x77A8FB0", Offset = "0x77A7DB0", VA = "0x1877A8FB0")]
		public ABSNBGOLVYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77A9030", Offset = "0x77A7E30", VA = "0x1877A9030")]
		public ABSNBGOLVYZ(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x77A88F0", Offset = "0x77A76F0", VA = "0x1877A88F0")]
		public static ABSNBGOLVYZ JVVTESJDXCW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77A8E90", Offset = "0x77A7C90", VA = "0x1877A8E90")]
		public void SYWZGTVUTIU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A07E30", Offset = "0x2A06C30", VA = "0x182A07E30")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x77A8450", Offset = "0x77A7250", VA = "0x1877A8450")]
		public void DGMHUUXVDYY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x77A85C0", Offset = "0x77A73C0", VA = "0x1877A85C0")]
		public void DGMHUUXVDYY(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x77A8330", Offset = "0x77A7130", VA = "0x1877A8330")]
		public void DGMHUUXVDYY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x77A8330", Offset = "0x77A7130", VA = "0x1877A8330")]
		public void DGMHUUXVDYY(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x77A82A0", Offset = "0x77A70A0", VA = "0x1877A82A0")]
		public void DGMHUUXVDYY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x77A82A0", Offset = "0x77A70A0", VA = "0x1877A82A0")]
		public void DGMHUUXVDYY(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77A8380", Offset = "0x77A7180", VA = "0x1877A8380")]
		public void DGMHUUXVDYY(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x77A8380", Offset = "0x77A7180", VA = "0x1877A8380")]
		public void DGMHUUXVDYY(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x77A8380", Offset = "0x77A7180", VA = "0x1877A8380")]
		public void DGMHUUXVDYY(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x77A83F0", Offset = "0x77A71F0", VA = "0x1877A83F0")]
		public void DGMHUUXVDYY(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x77A83F0", Offset = "0x77A71F0", VA = "0x1877A83F0")]
		public void DGMHUUXVDYY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x77A8550", Offset = "0x77A7350", VA = "0x1877A8550")]
		public void DGMHUUXVDYY(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x77A8960", Offset = "0x77A7760", VA = "0x1877A8960")]
		public void NXZZMMDJSIY(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x77A8960", Offset = "0x77A7760", VA = "0x1877A8960")]
		public void TJJWHOHLCKD(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x77A84F0", Offset = "0x77A72F0", VA = "0x1877A84F0")]
		public void DGMHUUXVDYY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x77A8C00", Offset = "0x77A7A00", VA = "0x1877A8C00")]
		public void PGARQOSTOTD(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B20", Offset = "0x77A7920", VA = "0x1877A8B20")]
		public void PGARQOSTOTD(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x77A8A40", Offset = "0x77A7840", VA = "0x1877A8A40")]
		public void PGARQOSTOTD(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x77A8A40", Offset = "0x77A7840", VA = "0x1877A8A40")]
		public void PGARQOSTOTD(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x77A8A40", Offset = "0x77A7840", VA = "0x1877A8A40")]
		public void PGARQOSTOTD(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B20", Offset = "0x77A7920", VA = "0x1877A8B20")]
		public void PGARQOSTOTD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B20", Offset = "0x77A7920", VA = "0x1877A8B20")]
		public void PGARQOSTOTD(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x77A8DB0", Offset = "0x77A7BB0", VA = "0x1877A8DB0")]
		public void PGARQOSTOTD(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x77A8DB0", Offset = "0x77A7BB0", VA = "0x1877A8DB0")]
		public void PGARQOSTOTD(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x77A8960", Offset = "0x77A7760", VA = "0x1877A8960")]
		public void PGARQOSTOTD(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x77A8CE0", Offset = "0x77A7AE0", VA = "0x1877A8CE0")]
		public void PGARQOSTOTD(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x77A8820", Offset = "0x77A7620", VA = "0x1877A8820")]
		public void DGMHUUXVDYY(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x77A8290", Offset = "0x77A7090", VA = "0x1877A8290")]
		public void DGMHUUXVDYY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x77A8610", Offset = "0x77A7410", VA = "0x1877A8610")]
		public void DGMHUUXVDYY(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class BELFVSLIQHA
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class WXVWVCXEMBW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong QXVQSTMOTBE;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x69236C0", Offset = "0x69224C0", VA = "0x1869236C0")]
			static WXVWVCXEMBW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(QZBYXHGJXZH reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class NJECMPUCVZR<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public BELFVSLIQHA WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a WRKSSQWVXXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> KGJYPGCUEDJ;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public NJECMPUCVZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5AE40D0", Offset = "0x5AE2ED0", VA = "0x185AE40D0")]
			internal void WCRCSMPJFWY(QZBYXHGJXZH a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class EPOEIDBVCCP<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public BELFVSLIQHA WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a WRKSSQWVXXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> KGJYPGCUEDJ;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EPOEIDBVCCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4A14630", Offset = "0x4A13430", VA = "0x184A14630")]
			internal void WCRCSMPJFWY(QZBYXHGJXZH a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly BSLMFUTRRQS DESFTOPTDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> KZNHFKPQCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly ABSNBGOLVYZ RQCKTPGDPAQ;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x77AD4E0", Offset = "0x77AC2E0", VA = "0x1877AD4E0")]
		public BELFVSLIQHA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3617920", Offset = "0x3616720", VA = "0x183617920", Slot = "4")]
		protected virtual ulong THTQRHFTNVP<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x77AD340", Offset = "0x77AC140", VA = "0x1877AD340", Slot = "5")]
		protected virtual SubscribeDelegate FYNIJQYVMKK(QZBYXHGJXZH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x36179A0", Offset = "0x36167A0", VA = "0x1836179A0", Slot = "6")]
		protected virtual void XTIJFFGPVXM<b>(ABSNBGOLVYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x77AD460", Offset = "0x77AC260", VA = "0x1877AD460")]
		public void SZFELAFQIVN(QZBYXHGJXZH a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3617590", Offset = "0x3616390", VA = "0x183617590")]
		public void BMAIBKUWEXE<j>(ABSNBGOLVYZ a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x77AD410", Offset = "0x77AC210", VA = "0x1877AD410")]
		public void RHLKBPIKTHF(QZBYXHGJXZH a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x36177A0", Offset = "0x36165A0", VA = "0x1836177A0")]
		public void BRADDTTKYQA<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x36177A0", Offset = "0x36165A0", VA = "0x1836177A0")]
		public void BRADDTTKYQA<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x77B10E0", Offset = "0x77AFEE0", VA = "0x1877B10E0")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77BC360", Offset = "0x77BB160", VA = "0x1877BC360")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class BSLMFUTRRQS
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
		private abstract class EMOEHDPCWYC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType QCFSUOQZRCP;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4A14250", Offset = "0x4A13050", VA = "0x184A14250", Slot = "4")]
			public virtual void RWFLESYWDGJ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void MYNUIMAJKFJ(a a, QZBYXHGJXZH b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void BMAIBKUWEXE(a a, ABSNBGOLVYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void ITHCHFPJSYA(a a, QZBYXHGJXZH b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void TIRBIUPFKBB(a a, ABSNBGOLVYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void MNKYQYWHTYP(a a, QZBYXHGJXZH b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void OXYLHTVJUEG(a a, ABSNBGOLVYZ b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			protected EMOEHDPCWYC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class CZBLPPXVYKP<a, b> : EMOEHDPCWYC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> XYAMPFUQSGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> NKHKUDTQEAY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> CJVJGZTPINF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> TQYLVZRKUVJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> NQZPHNGZHYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> FKWOYTEYTJK;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3F83910", Offset = "0x3F82710", VA = "0x183F83910", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3F83910", Offset = "0x3F82710", VA = "0x183F83910", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3F839E0", Offset = "0x3F827E0", VA = "0x183F839E0", Slot = "9")]
			public override void MNKYQYWHTYP(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3F839E0", Offset = "0x3F827E0", VA = "0x183F839E0", Slot = "10")]
			public override void OXYLHTVJUEG(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x3F83AB0", Offset = "0x3F828B0", VA = "0x183F83AB0")]
			protected b[] RIASBMCLDDO(a a, QZBYXHGJXZH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3F837A0", Offset = "0x3F825A0", VA = "0x183F837A0")]
			protected b[] FWCXUPTCPWX(a a, ABSNBGOLVYZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3F83D70", Offset = "0x3F82B70", VA = "0x183F83D70", Slot = "4")]
			public override void RWFLESYWDGJ(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3F848B0", Offset = "0x3F836B0", VA = "0x183F848B0")]
			protected CZBLPPXVYKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class SOCCYKHTZAA<a, b> : CZBLPPXVYKP<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void LWKNEGXOJND(QZBYXHGJXZH a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void RVQWCTQPKBG(ABSNBGOLVYZ a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x60F8010", Offset = "0x60F6E10", VA = "0x1860F8010", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x60F7D10", Offset = "0x60F6B10", VA = "0x1860F7D10", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x60F7F70", Offset = "0x60F6D70", VA = "0x1860F7F70", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x60F8290", Offset = "0x60F7090", VA = "0x1860F8290", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x60F8530", Offset = "0x60F7330", VA = "0x1860F8530")]
			protected SOCCYKHTZAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class ULYYBSMPBFZ<a> : CZBLPPXVYKP<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D9F0", Offset = "0x5B3C7F0", VA = "0x185B3D9F0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D760", Offset = "0x5B3C560", VA = "0x185B3D760", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x641EDE0", Offset = "0x641DBE0", VA = "0x18641EDE0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x52EBA20", Offset = "0x52EA820", VA = "0x1852EBA20", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public ULYYBSMPBFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class NLUDHZJXQTC<a> : CZBLPPXVYKP<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D9F0", Offset = "0x5B3C7F0", VA = "0x185B3D9F0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D760", Offset = "0x5B3C560", VA = "0x185B3D760", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D9A0", Offset = "0x5B3C7A0", VA = "0x185B3D9A0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x52EBA20", Offset = "0x52EA820", VA = "0x1852EBA20", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public NLUDHZJXQTC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class NJLTKQGWNOA<a> : CZBLPPXVYKP<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x53CFD20", Offset = "0x53CEB20", VA = "0x1853CFD20", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x53CF950", Offset = "0x53CE750", VA = "0x1853CF950", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4130", Offset = "0x5AE2F30", VA = "0x185AE4130", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x53CFD70", Offset = "0x53CEB70", VA = "0x1853CFD70", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public NJLTKQGWNOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class JKIJFPPHCOT<a> : CZBLPPXVYKP<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x53CFD20", Offset = "0x53CEB20", VA = "0x1853CFD20", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x53CF950", Offset = "0x53CE750", VA = "0x1853CF950", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x53CFAA0", Offset = "0x53CE8A0", VA = "0x1853CFAA0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x53CFD70", Offset = "0x53CEB70", VA = "0x1853CFD70", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public JKIJFPPHCOT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class RVXNUPYRENI<a> : CZBLPPXVYKP<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E6D0", Offset = "0x5E8D4D0", VA = "0x185E8E6D0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E430", Offset = "0x5E8D230", VA = "0x185E8E430", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E680", Offset = "0x5E8D480", VA = "0x185E8E680", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x517D080", Offset = "0x517BE80", VA = "0x18517D080", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public RVXNUPYRENI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class VZJNNRMRDSH<a> : CZBLPPXVYKP<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E6D0", Offset = "0x5E8D4D0", VA = "0x185E8E6D0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x5E8E430", Offset = "0x5E8D230", VA = "0x185E8E430", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x657D840", Offset = "0x657C640", VA = "0x18657D840", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x517D080", Offset = "0x517BE80", VA = "0x18517D080", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public VZJNNRMRDSH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class TWPDLIDRXRA<a> : CZBLPPXVYKP<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x6237520", Offset = "0x6236320", VA = "0x186237520", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x6237390", Offset = "0x6236190", VA = "0x186237390", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x62373D0", Offset = "0x62361D0", VA = "0x1862373D0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x42FE290", Offset = "0x42FD090", VA = "0x1842FE290", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public TWPDLIDRXRA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class VOHPPVEHYXX<a> : CZBLPPXVYKP<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x6237520", Offset = "0x6236320", VA = "0x186237520", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x6237390", Offset = "0x6236190", VA = "0x186237390", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6571D20", Offset = "0x6570B20", VA = "0x186571D20", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x42FE290", Offset = "0x42FD090", VA = "0x1842FE290", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public VOHPPVEHYXX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class IUKCRFZJMOY<a> : CZBLPPXVYKP<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x52EB8C0", Offset = "0x52EA6C0", VA = "0x1852EB8C0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x52EB610", Offset = "0x52EA410", VA = "0x1852EB610", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x52EB650", Offset = "0x52EA450", VA = "0x1852EB650", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x52EBA20", Offset = "0x52EA820", VA = "0x1852EBA20", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public IUKCRFZJMOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class GJVBZQBEAMZ<a> : CZBLPPXVYKP<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x517CF10", Offset = "0x517BD10", VA = "0x18517CF10", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x517CC70", Offset = "0x517BA70", VA = "0x18517CC70", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x517CDC0", Offset = "0x517BBC0", VA = "0x18517CDC0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x517D080", Offset = "0x517BE80", VA = "0x18517D080", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public GJVBZQBEAMZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class DLQZTHCFNSM<a> : CZBLPPXVYKP<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x42FE120", Offset = "0x42FCF20", VA = "0x1842FE120", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x42FDF90", Offset = "0x42FCD90", VA = "0x1842FDF90", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x42FDFD0", Offset = "0x42FCDD0", VA = "0x1842FDFD0", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x42FE290", Offset = "0x42FD090", VA = "0x1842FE290", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD200", VA = "0x1842FE400")]
			public DLQZTHCFNSM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class AGIOVQRXWNO<a> : SOCCYKHTZAA<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x567D010", Offset = "0x567BE10", VA = "0x18567D010", Slot = "12")]
			protected override void RVQWCTQPKBG(ABSNBGOLVYZ a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x567CFE0", Offset = "0x567BDE0", VA = "0x18567CFE0", Slot = "11")]
			protected override void LWKNEGXOJND(QZBYXHGJXZH a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x567D040", Offset = "0x567BE40", VA = "0x18567D040")]
			public AGIOVQRXWNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class TGPGFZWCTBG<a> : SOCCYKHTZAA<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6209B70", Offset = "0x6208970", VA = "0x186209B70", Slot = "12")]
			protected override void RVQWCTQPKBG(ABSNBGOLVYZ a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6209B30", Offset = "0x6208930", VA = "0x186209B30", Slot = "11")]
			protected override void LWKNEGXOJND(QZBYXHGJXZH a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x567D040", Offset = "0x567BE40", VA = "0x18567D040")]
			public TGPGFZWCTBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class OQUPWRPBYJX<a> : CZBLPPXVYKP<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int GHNQXEQSIDE;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F390", Offset = "0x5C6E190", VA = "0x185C6F390")]
			public OQUPWRPBYJX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F1D0", Offset = "0x5C6DFD0", VA = "0x185C6F1D0", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5C6EEE0", Offset = "0x5C6DCE0", VA = "0x185C6EEE0", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F050", Offset = "0x5C6DE50", VA = "0x185C6F050", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F340", Offset = "0x5C6E140", VA = "0x185C6F340", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class EQPZMNXZBMH<a> : EMOEHDPCWYC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo DETGYEJXBPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type VIWLZDLVUWS;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x4A15E30", Offset = "0x4A14C30", VA = "0x184A15E30")]
			public EQPZMNXZBMH(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x4A15D30", Offset = "0x4A14B30", VA = "0x184A15D30", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x4A159C0", Offset = "0x4A147C0", VA = "0x184A159C0", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x4A15B60", Offset = "0x4A14960", VA = "0x184A15B60", Slot = "7")]
			public override void ITHCHFPJSYA(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x4A15B60", Offset = "0x4A14960", VA = "0x184A15B60", Slot = "8")]
			public override void TIRBIUPFKBB(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x4A15BB0", Offset = "0x4A149B0", VA = "0x184A15BB0", Slot = "9")]
			public override void MNKYQYWHTYP(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x4A15BB0", Offset = "0x4A149B0", VA = "0x184A15BB0", Slot = "10")]
			public override void OXYLHTVJUEG(a a, ABSNBGOLVYZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class LMWJUXVQXEM<a> : EQPZMNXZBMH<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x558FCE0", Offset = "0x558EAE0", VA = "0x18558FCE0")]
			public LMWJUXVQXEM(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x558FB10", Offset = "0x558E910", VA = "0x18558FB10", Slot = "5")]
			public override void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x558FA90", Offset = "0x558E890", VA = "0x18558FA90", Slot = "6")]
			public override void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class EGZHMOEEYXQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static EGZHMOEEYXQ<a> GUIRZRNRSLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly EMOEHDPCWYC<a>[] AWGQRYEBNKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int EPYZOVYWUNY;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x49585C0", Offset = "0x49573C0", VA = "0x1849585C0")]
			public EGZHMOEEYXQ(List<EMOEHDPCWYC<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4957FC0", Offset = "0x4956DC0", VA = "0x184957FC0")]
			public void BMAIBKUWEXE(a a, ABSNBGOLVYZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4958470", Offset = "0x4957270", VA = "0x184958470")]
			public void MYNUIMAJKFJ(a a, QZBYXHGJXZH b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class NUQKGTVKAZC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract EMOEHDPCWYC<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private ABSNBGOLVYZ BQTGYZOMMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int PHUNNERMZPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, NUQKGTVKAZC> BYEDIYADBUF;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x77AF440", Offset = "0x77AE240", VA = "0x1877AF440")]
		public BSLMFUTRRQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3627950", Offset = "0x3626750", VA = "0x183627950")]
		private EGZHMOEEYXQ<d> GNECCRRHLID<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3628710", Offset = "0x3627510", VA = "0x183628710")]
		public void PUOFOOQAOVA<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3626AB0", Offset = "0x36258B0", VA = "0x183626AB0")]
		public bool Deserialize<T>(QZBYXHGJXZH reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3628750", Offset = "0x3627550", VA = "0x183628750")]
		public void VVUFAYMMXPR<f>(ABSNBGOLVYZ a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class BJOMOTRJYQL
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime PJLQKPFTROU;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] OVSVNULYFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator OOYZDQBQCAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x77AE910", Offset = "0x77AD710", VA = "0x1877AE910")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ZGHTNYKOBDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x77AEA90", Offset = "0x77AD890", VA = "0x1877AEA90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x77AED90", Offset = "0x77ADB90", VA = "0x1877AED90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode CPOFFPFYKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x77AEDD0", Offset = "0x77ADBD0", VA = "0x1877AEDD0")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x77AEE00", Offset = "0x77ADC00", VA = "0x1877AEE00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int JYOZGBJJYGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x77AEA60", Offset = "0x77AD860", VA = "0x1877AEA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint MHWHANVRIRX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x77AE030", Offset = "0x77ACE30", VA = "0x1877AE030")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? JSQQRITFJQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x77AE640", Offset = "0x77AD440", VA = "0x1877AE640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? YRYNPJPDIQE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x77AE830", Offset = "0x77AD630", VA = "0x1877AE830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? EIOYBFPLSBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x77AEE40", Offset = "0x77ADC40", VA = "0x1877AEE40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x77AE670", Offset = "0x77AD470", VA = "0x1877AE670")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? TUBWEMLCTZV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xF76460", Offset = "0xF75260", VA = "0x180F76460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x77AF090", Offset = "0x77ADE90", VA = "0x1877AF090")]
		public BJOMOTRJYQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x77AF3A0", Offset = "0x77AE1A0", VA = "0x1877AF3A0")]
		internal BJOMOTRJYQL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x77AEAC0", Offset = "0x77AD8C0", VA = "0x1877AEAC0")]
		public static BJOMOTRJYQL QXBTLGSHSVF(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x77AE2C0", Offset = "0x77AD0C0", VA = "0x1877AE2C0")]
		internal void BRGSOHXOCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x77AEE70", Offset = "0x77ADC70", VA = "0x1877AEE70")]
		private void VOTCGCLRRJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x77AE090", Offset = "0x77ACE90", VA = "0x1877AE090")]
		private DateTime? AOFNTJSBNXM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x77AEBD0", Offset = "0x77AD9D0", VA = "0x1877AEBD0")]
		private void RCYVGYDNUTE(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x77AE860", Offset = "0x77AD660", VA = "0x1877AE860")]
		private ulong LKQRYJSVNVQ(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x77AE9A0", Offset = "0x77AD7A0", VA = "0x1877AE9A0")]
		private void QEOGFNAAFXQ(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x77AE940", Offset = "0x77AD740", VA = "0x1877AE940")]
		private uint OFNPOGHRTTX(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x76775F0", Offset = "0x76763F0", VA = "0x1876775F0")]
		private static uint AUYNLMWUXTK(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x77AE260", Offset = "0x77AD060", VA = "0x1877AE260")]
		private static ulong AUYNLMWUXTK(ulong a)
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
	internal sealed class KLPKBFSOOUY
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int XEBPVZEXRPD = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int ETXWGUEDGBC = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int ATFOOLHHNSL = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint CATSCYOZDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int FDYABFUHIBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int ZMQXJCDHBQF;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool SKUQEEOSLBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x77B1A20", Offset = "0x77B0820", VA = "0x1877B1A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x77B1930", Offset = "0x77B0730", VA = "0x1877B1930")]
		public bool IDYEONHPVDX(ACPZTYJTQIL a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class QIZADKBBMLA : ACPZTYJTQIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket KZUHYTRHPHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly MZHZGYRVCOF QYVZIJZXXXX;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short FZRZCTUXIIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x77BCAF0", Offset = "0x77BB8F0", VA = "0x1877BCAF0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int OVULLCBLXOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x77BCC60", Offset = "0x77BBA60", VA = "0x1877BCC60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint DSKUOINOISH
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x77BCC00", Offset = "0x77BBA00", VA = "0x1877BCC00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily CSZMNDCVDAV
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x321C3F0", Offset = "0x321B1F0", VA = "0x18321C3F0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x77BCC80", Offset = "0x77BBA80", VA = "0x1877BCC80")]
		public QIZADKBBMLA(AddressFamily a, MZHZGYRVCOF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x77BC510", Offset = "0x77BB310", VA = "0x1877BC510", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x77BCC20", Offset = "0x77BBA20", VA = "0x1877BCC20", Slot = "9")]
		public int SPESWVPFQGM(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x77BCB10", Offset = "0x77BB910", VA = "0x1877BCB10", Slot = "10")]
		public int MNPGMRMVISQ(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x77BCAD0", Offset = "0x77BB8D0", VA = "0x1877BCAD0", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface ACPZTYJTQIL
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short FZRZCTUXIIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int OVULLCBLXOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint DSKUOINOISH
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily CSZMNDCVDAV
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
		int SPESWVPFQGM(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int MNPGMRMVISQ(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x77BBCB0", Offset = "0x77BAAB0", VA = "0x1877BBCB0")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x77BBD50", Offset = "0x77BAB50", VA = "0x1877BBD50")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x77BBBC0", Offset = "0x77BA9C0", VA = "0x1877BBBC0", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x77BBC00", Offset = "0x77BAA00", VA = "0x1877BBC00", Slot = "0")]
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
	public class RGZPEAAMONA
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string ILUCAWXVDGC = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int ONXNVXLUBJQ = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int HZQEMBTKBYU = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int LDXITEBBQKW = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> VSBNTULTJBR;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback HDFODXLSRZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int GIMAHPDCQRA;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		internal void ZUJVSBJBSOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		internal void YLAOAPHNRXS(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class OMEQSRIDONX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int LAIXXHUQWZU;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
		protected OMEQSRIDONX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void QFKRCYSSVDL(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OVLFEOSQMVG(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class NOPYAXTJEON : OMEQSRIDONX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] NFCNRPBPDKW;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator YCOSQNVFRTC;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F500", Offset = "0x2B0E300", VA = "0x182B0F500")]
		public NOPYAXTJEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x77BB9C0", Offset = "0x77BA7C0", VA = "0x1877BB9C0")]
		public void TWBJZYCVDXP(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x77BB190", Offset = "0x77B9F90", VA = "0x1877BB190")]
		public void LTTACUJDBIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x77BB570", Offset = "0x77BA370", VA = "0x1877BB570", Slot = "4")]
		public override void QFKRCYSSVDL(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x77BB270", Offset = "0x77BA070", VA = "0x1877BB270", Slot = "5")]
		public override void OVLFEOSQMVG(IPEndPoint a, byte[] b, int c, int d)
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
		public unsafe delegate void Encrypt_0000039F$PostfixBurstDelegate([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int length);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		internal static class SDKIKYPILDC
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr USMXZPUWDBO;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x77BF990", Offset = "0x77BE790", VA = "0x1877BF990")]
			[BurstDiscard]
			private static void WSKWTBGSAEU(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x77BFB10", Offset = "0x77BE910", VA = "0x1877BFB10")]
			private static IntPtr XNOYTSCMGOG()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x77BF750", Offset = "0x77BE550", VA = "0x1877BF750")]
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
		[Cpp2IlInjected.Address(RVA = "0x77BD8B0", Offset = "0x77BC6B0", VA = "0x1877BD8B0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x77BD880", Offset = "0x77BC680", VA = "0x1877BD880")]
		private uint PJNCKCEZRPD(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x77A8050", Offset = "0x77A6E50", VA = "0x1877A8050")]
		private void QKQBUWWKNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x77A7E40", Offset = "0x77A6C40", VA = "0x1877A7E40")]
		private void GNEILOEHFRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x77A8100", Offset = "0x77A6F00", VA = "0x1877A8100")]
		private void VHWPKYZFZND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x77A8190", Offset = "0x77A6F90", VA = "0x1877A8190")]
		private void VZXPCYEALYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x77BD820", Offset = "0x77BC620", VA = "0x1877BD820")]
		private void HSMUIJGKZAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x77BD930", Offset = "0x77BC730", VA = "0x1877BD930")]
		private unsafe void SBEWMBHRWSR(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x77BDEB0", Offset = "0x77BCCB0", VA = "0x1877BDEB0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void VBWDKRFWARS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x77BDE00", Offset = "0x77BCC00", VA = "0x1877BDE00")]
		public static void VBWDKRFWARS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x77BDD50", Offset = "0x77BCB50", VA = "0x1877BDD50")]
		public static void SUGKAPXCEYY(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x77BDEC0", Offset = "0x77BCCC0", VA = "0x1877BDEC0")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void XBJJTDRDSHV([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x77BFC90", Offset = "0x77BEA90", VA = "0x1877BFC90")]
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
