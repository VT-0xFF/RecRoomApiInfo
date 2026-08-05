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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, IWDPUIOQXGH
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
		private NetworkManager IZMSOTJJJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool LVQHFBRDYOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, STMVIUBNLIO> SGEDGNLRCUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IXRPCFLIUHD KYIWJHYJORT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch MUBBUAQWLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] QWEFMJIDNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HostType LTPGMZIMMDP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int HZLUCOOPREZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7683BA0", Offset = "0x76829A0", VA = "0x187683BA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong ServerClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7683B50", Offset = "0x7682950", VA = "0x187683B50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7683050", Offset = "0x7681E50", VA = "0x187683050")]
		public void RecRoom_SetEncryptionInfo(ulong clientTransportId, byte[] key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7683030", Offset = "0x7681E30", VA = "0x187683030")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7682E50", Offset = "0x7681C50", VA = "0x187682E50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7683A60", Offset = "0x7682860", VA = "0x187683A60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7683160", Offset = "0x7681F60", VA = "0x187683160", Slot = "6")]
		public override void Send(ulong clientId, ArraySegment<byte> data, NetworkDelivery qos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7682FA0", Offset = "0x7681DA0", VA = "0x187682FA0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong clientId, [Out] ArraySegment<byte> payload, [Out] float receiveTime)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7683430", Offset = "0x7682230", VA = "0x187683430", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7683770", Offset = "0x7682570", VA = "0x187683770", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7682780", Offset = "0x7681580", VA = "0x187682780", Slot = "11")]
		public override void DisconnectRemoteClient(ulong clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7682690", Offset = "0x7681490", VA = "0x187682690", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7682A90", Offset = "0x7681890", VA = "0x187682A90", Slot = "13")]
		public override ulong GetCurrentRtt(ulong clientId)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76833C0", Offset = "0x76821C0", VA = "0x1876833C0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7682B30", Offset = "0x7681930", VA = "0x187682B30", Slot = "15")]
		public override void Initialize([Optional] NetworkManager networkManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7683990", Offset = "0x7682790", VA = "0x187683990")]
		private DeliveryMethod TFSDSUEWTMM(NetworkDelivery a)
		{
			return default(DeliveryMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7682D40", Offset = "0x7681B40", VA = "0x187682D40", Slot = "16")]
		private void MZAIBWKLDMT(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76825C0", Offset = "0x76813C0", VA = "0x1876825C0", Slot = "17")]
		private void DSADRJITBGL(STMVIUBNLIO a, DisconnectInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "18")]
		private void KPZBILJSVVG(IPEndPoint a, SocketError b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7682890", Offset = "0x7681690", VA = "0x187682890", Slot = "19")]
		private void FLXTOGCSCXB(STMVIUBNLIO a, CHEYXTVBXHL b, byte c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76824F0", Offset = "0x76812F0", VA = "0x1876824F0")]
		private void BAUSOZKPVAE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "20")]
		private void XSFPTSTZRUT(IPEndPoint a, CHEYXTVBXHL b, UnconnectedMessageType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "21")]
		private void BAGMMOUIMRP(STMVIUBNLIO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7682F40", Offset = "0x7681D40", VA = "0x187682F40", Slot = "22")]
		private void PNKLILUCNRP(SIHIWNGOKBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7682E00", Offset = "0x7681C00", VA = "0x187682E00")]
		private ulong OOGGQJLKWMC(STMVIUBNLIO a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7682E30", Offset = "0x7681C30", VA = "0x187682E30")]
		private ulong OOGGQJLKWMC(ulong a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7682FE0", Offset = "0x7681DE0", VA = "0x187682FE0")]
		private static int QZMDTSMCWFR(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7683A80", Offset = "0x7682880", VA = "0x187683A80")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7683000", Offset = "0x7681E00", VA = "0x187683000")]
		[CompilerGenerated]
		private void RKADYRMDXNL(ulong a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7683000", Offset = "0x7681E00", VA = "0x187683000")]
		[CompilerGenerated]
		private void XNRCTAGIASE(ulong a, int b)
		{
		}
	}
}
namespace LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class JGKTPEIUTKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly STMVIUBNLIO DVWFRZYHTCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly ConcurrentQueue<YWFYQVAMFNU> JEGABUMGVAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int HTIIWZWXVPJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WGHLVXFUNXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7681310", Offset = "0x7680110", VA = "0x187681310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7681480", Offset = "0x7680280", VA = "0x187681480")]
		protected JGKTPEIUTKF(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76813E0", Offset = "0x76801E0", VA = "0x1876813E0")]
		public void TGRFUBSGTGO(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7681360", Offset = "0x7680160", VA = "0x187681360")]
		protected void MPHZIKVTKSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7681440", Offset = "0x7680240", VA = "0x187681440")]
		public bool ZGTGKXBZMKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract bool CINDWBAXDRP();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool ECULTPEWGYM(YWFYQVAMFNU a);
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
	public class SIHIWNGOKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly IXRPCFLIUHD KJYLRVTYLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int MDOENHWHMWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal QOQHYDMWJWN VFSMUVOWOXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPEndPoint NEBBUYBLUYM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal ConnectionRequestResult KXSBIDNSIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1664390", Offset = "0x1663190", VA = "0x181664390")]
			[CompilerGenerated]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1664380", Offset = "0x1663180", VA = "0x181664380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7687020", Offset = "0x7685E20", VA = "0x187687020")]
		internal void GKKIPVRZFRN(QOQHYDMWJWN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7686FF0", Offset = "0x7685DF0", VA = "0x187686FF0")]
		private bool EYVYSBXGPCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7687080", Offset = "0x7685E80", VA = "0x187687080")]
		internal SIHIWNGOKBG(IPEndPoint a, QOQHYDMWJWN b, IXRPCFLIUHD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7686F90", Offset = "0x7685D90", VA = "0x187686F90")]
		public STMVIUBNLIO Accept()
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
		public CHEYXTVBXHL AdditionalData;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IWDPUIOQXGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QMCRXSVWTPX(STMVIUBNLIO a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OMVMDMPJUEN(STMVIUBNLIO a, DisconnectInfo b);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SOLEWOURBXM(IPEndPoint a, SocketError b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IBFDRIQKLAJ(STMVIUBNLIO a, CHEYXTVBXHL b, byte c, DeliveryMethod d);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CXSRFILKPWB(IPEndPoint a, CHEYXTVBXHL b, UnconnectedMessageType c);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KZDQHLKVLZF(STMVIUBNLIO a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DTANZYSBJYH(SIHIWNGOKBG a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface LRNNGGIHBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UEOHYJJOLNN(STMVIUBNLIO a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BSDYMBQDNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EQBIHMZTKLZ(DXUUFCVKVJN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface WSKSETYAQXM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XQOHMSNIHFI(STMVIUBNLIO a, IPEndPoint b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class QOQHYDMWJWN
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int HOJVRTRYTED = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly long IDJKMGZQQYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte BGDSKSQJYZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly byte[] JCOONSASPQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly FHXQBUDMLQR JGQJHTLYZSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly int TPEZOKPKVMW;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76857F0", Offset = "0x76845F0", VA = "0x1876857F0")]
		private QOQHYDMWJWN(long a, byte b, int c, byte[] d, FHXQBUDMLQR e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76855D0", Offset = "0x76843D0", VA = "0x1876855D0")]
		public static int SPSSBPMPBCU(YWFYQVAMFNU a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7685600", Offset = "0x7684400", VA = "0x187685600")]
		public static QOQHYDMWJWN UFAMLZLIRIH(YWFYQVAMFNU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76853F0", Offset = "0x76841F0", VA = "0x1876853F0")]
		public static YWFYQVAMFNU RPDPLUQVBLT(JPNPRKXNCWB a, SocketAddress b, long c, int d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class YEKUBQNDJAU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly long IDJKMGZQQYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly byte BGDSKSQJYZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly int TPEZOKPKVMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool HNZFZQCZCQV;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x768B860", Offset = "0x768A660", VA = "0x18768B860")]
		private YEKUBQNDJAU(long a, byte b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x768B760", Offset = "0x768A560", VA = "0x18768B760")]
		public static YEKUBQNDJAU UFAMLZLIRIH(YWFYQVAMFNU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x768B570", Offset = "0x768A370", VA = "0x18768B570")]
		public static YWFYQVAMFNU RPDPLUQVBLT(long a, byte b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x768B660", Offset = "0x768A460", VA = "0x18768B660")]
		public static YWFYQVAMFNU UAIPXEELVAX(STMVIUBNLIO a)
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
	public interface XFCYQLXXERF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ODEUVQSEUZA(IPEndPoint a, IPEndPoint b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOFUWIZGGMI(IPEndPoint a, NatAddressType b, string c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class IZULSFYUPTM
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
		private class PHMDKUKPIFW
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public IPEndPoint QYDWSBXXNRQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string DBFUKZHUNYQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public PHMDKUKPIFW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class UCWFALBPPEQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public IPEndPoint QYDWSBXXNRQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public IPEndPoint EGYRGORUYSQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public string DBFUKZHUNYQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UCWFALBPPEQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class PXPWWBAPOVA
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public string DBFUKZHUNYQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool JXURVVVAUFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAAD5B0", Offset = "0xAAC3B0", VA = "0x180AAD5B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public PXPWWBAPOVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly IXRPCFLIUHD UYWYFAQDOUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ConcurrentQueue<RequestEventData> HVCMBIVIUIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly ConcurrentQueue<SuccessEventData> BEAWIVCIMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly FHXQBUDMLQR VDDUZNIUUDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly JPNPRKXNCWB WOWVPQYVLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly GHQSDFOTQCS DERDTEHAQIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private XFCYQLXXERF BBXXPPOZJKV;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const int PYEVNGXCNRC = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public bool SZBMJEHKGPB;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7680F10", Offset = "0x767FD10", VA = "0x187680F10")]
		internal IZULSFYUPTM(IXRPCFLIUHD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7680900", Offset = "0x767F700", VA = "0x187680900")]
		internal void ATBEDHAMIYL(IPEndPoint a, YWFYQVAMFNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3969BE0", Offset = "0x39689E0", VA = "0x183969BE0")]
		private void FJEWZTPWMSF<a>(a a, IPEndPoint b) where a : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7680BE0", Offset = "0x767F9E0", VA = "0x187680BE0")]
		private void ODEUVQSEUZA(PHMDKUKPIFW a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7680A80", Offset = "0x767F880", VA = "0x187680A80")]
		private void LPEROAPTXBY(UCWFALBPPEQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7680D70", Offset = "0x767FB70", VA = "0x187680D70")]
		private void OPKSSXQSBVJ(PXPWWBAPOVA a, IPEndPoint b)
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
	public static class ZZIHONHUYYD
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal static readonly int[] AXGDPUKYNYE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly int VAVNOJDZIVY;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly int LGDOXJRVUWL;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class InvalidPacketException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7681300", Offset = "0x7680100", VA = "0x187681300")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7681300", Offset = "0x7680100", VA = "0x187681300")]
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
	public interface ITNBDYZNYKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZKJLYLRADIJ(NetLogLevel a, string b, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HEZDNNYGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static ITNBDYZNYKJ YOSGDKAPXAL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly object PNQLLPJWUVZ;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7678780", Offset = "0x7677580", VA = "0x187678780")]
		private static void CDPJOZJZGYA(NetLogLevel a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76789B0", Offset = "0x76777B0", VA = "0x1876789B0")]
		internal static void DYTUDTCTIWA(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7678A10", Offset = "0x7677810", VA = "0x187678A10")]
		internal static void PQWEPARTNTU(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7678A70", Offset = "0x7677870", VA = "0x187678A70")]
		internal static void SXJPQYXFLNS(string a, params object[] args)
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
	public sealed class CHEYXTVBXHL : FHXQBUDMLQR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private YWFYQVAMFNU JZITBBCXSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly IXRPCFLIUHD QJBFTKJCUCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly POCSWJMAYMG SLAJWTALMVT;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7675A20", Offset = "0x7674820", VA = "0x187675A20")]
		internal CHEYXTVBXHL(IXRPCFLIUHD a, POCSWJMAYMG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7675900", Offset = "0x7674700", VA = "0x187675900")]
		internal void UDOEBJQKFXO(YWFYQVAMFNU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x76759A0", Offset = "0x76747A0", VA = "0x1876759A0")]
		internal void YMJXJQVGEKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7675970", Offset = "0x7674770", VA = "0x187675970")]
		public void UPQWOSTJGQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class POCSWJMAYMG
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
		public POCSWJMAYMG XYTCBKNEVMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EType QHIGGIBDJUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public STMVIUBNLIO DVWFRZYHTCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IPEndPoint NEBBUYBLUYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public object NDGCHRGNOIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int KPAYRMUUALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public SocketError THLJYISMVZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DisconnectReason SWFWDUBHBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public SIHIWNGOKBG SIHIWNGOKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DeliveryMethod JHSJRUGNYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public byte WJJPZQPWIVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly CHEYXTVBXHL GUTJMKHNEYA;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7684180", Offset = "0x7682F80", VA = "0x187684180")]
		public POCSWJMAYMG(IXRPCFLIUHD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IXRPCFLIUHD : IEnumerable<STMVIUBNLIO>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class KQLFXWKJBMU : IEqualityComparer<IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7682450", Offset = "0x7681250", VA = "0x187682450", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x76824C0", Offset = "0x76812C0", VA = "0x1876824C0", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public KQLFXWKJBMU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public struct NetPeerEnumerator : IEnumerator<STMVIUBNLIO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private readonly STMVIUBNLIO _initialPeer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private STMVIUBNLIO _p;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public STMVIUBNLIO Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D7E470", Offset = "0x1D7D270", VA = "0x181D7E470")]
			public NetPeerEnumerator(STMVIUBNLIO p)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x76840F0", Offset = "0x7682EF0", VA = "0x1876840F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7684140", Offset = "0x7682F40", VA = "0x187684140", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Thread KVKHKFLSERY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool KRGZNDIHVYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool JMPAKGQKCRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private QABWCBVWNQO JMTUHPOVCFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly AutoResetEvent IXSBWNXVKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Queue<POCSWJMAYMG> DYUDHHXUWMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Queue<POCSWJMAYMG> HOGXVWDXFUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private POCSWJMAYMG OEUQVGGSNWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly IWDPUIOQXGH QMHUJCZZVSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly LRNNGGIHBJE JPKAWFEETKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly BSDYMBQDNPO ASNMALBORAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly WSKSETYAQXM AIKISKJPZBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Dictionary<IPEndPoint, STMVIUBNLIO> DBTLYFMTJWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Dictionary<IPEndPoint, SIHIWNGOKBG> NQWCMWYQESG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Dictionary<IPEndPoint, JROKNXJGYVO> ABASTEBTMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ReaderWriterLockSlim UOUBQANZJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private STMVIUBNLIO EGRNCGVILYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int NUDYQAVLTXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly List<STMVIUBNLIO> ZATBKCJSJZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private STMVIUBNLIO[] NEJDBDLJLWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly AUSIWDMIQWV QSBDIVRJFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int RPWYUTBLKQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ConcurrentQueue<int> IZQZCOLNYWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private byte HLNQZRVGZLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly object TXRTFXJTEFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public bool RZUYOZKIKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool ZUEQKXKGPYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int VRXIHVXDSQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int ADVCYVHNJYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int KXSCWQBDWHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int TLEISDWLONW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public bool JMQWVHRXNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool KQJWLMRRSHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int CZULMWVVUPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int HUXEACPLMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int SUNQJEEWWTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public bool SZBMJEHKGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public bool WXWDYGDAKYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool XVIMORBSREC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool TDUDEHRJOVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int LLRILODPSPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int PMFSJIHWMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool MQRLOJKYPWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly CPBEINFCBGF YAZPNIGNSIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public bool YPTSZFRCRBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly IZULSFYUPTM IZULSFYUPTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool ORTGLGRIQUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IPv6Mode BTHRBIUPAEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int LSFUXLCKVMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool ZJCCTJAUFAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool IWBFNHECGQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool XEXOQLXGHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public bool FQNZLYDOQAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private YWFYQVAMFNU QIWDODSXZLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int CUXRRHXFHVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly object HJKFNKEKYMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private YWFYQVAMFNU CTKVBLPXUXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int KHTFUSVLELK;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const int MICLBLQLNBS = 50;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private const int MMKABIIDMMR = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private THQGKLZTYAT LJBFSEJZLAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private THQGKLZTYAT LJLTMRXUDXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Thread AKQJRDRJESG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Thread AKFVWQDOLVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IPEndPoint LHJBCBWLNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private IPEndPoint LGYNHOIQUMP;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[ThreadStatic]
		private static byte[] PFMKLZPDAUJ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[ThreadStatic]
		private static byte[] XOIOZGKECLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<NativeAddr, IPEndPoint> RKYBNJSFVGS;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly IPAddress VQDDGURCWGZ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly bool JRPWXQUHKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int WKOOHLUAUOR;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool XWYGCXQWHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xBC2AC0", Offset = "0xBC18C0", VA = "0x180BC2AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCC9140", Offset = "0xCC7F40", VA = "0x180CC9140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int FBTXERDTFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB90470", Offset = "0xB8F270", VA = "0x180B90470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x22EBB90", Offset = "0x22EA990", VA = "0x1822EBB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public byte EBNQKOQLQMO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE7C940", Offset = "0xE7B740", VA = "0x180E7C940")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int JLTZHSMDPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x767B800", Offset = "0x767A600", VA = "0x18767B800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal short NLYLZFSUBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x767F660", Offset = "0x767E460", VA = "0x18767F660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event STMVIUBNLIO.OnUpdatedMtuDelegate FJOSLGXZMRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7680190", Offset = "0x767EF90", VA = "0x187680190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x767D0E0", Offset = "0x767BEE0", VA = "0x18767D0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x767B9C0", Offset = "0x767A7C0", VA = "0x18767B9C0")]
		public void KOMTUHKLOQH(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x767B820", Offset = "0x767A620", VA = "0x18767B820")]
		public void HYIHNXBKLYS(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x767CEF0", Offset = "0x767BCF0", VA = "0x18767CEF0")]
		private bool NWCVILGRQPS(IPEndPoint a, [Out] STMVIUBNLIO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x767E970", Offset = "0x767D770", VA = "0x18767E970")]
		private void TEUONGAGAZQ(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7678B80", Offset = "0x7677980", VA = "0x187678B80")]
		private void AMZWNJVYPAX(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x767CC30", Offset = "0x767BA30", VA = "0x18767CC30")]
		private void MKKJVYFLIAK(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7680340", Offset = "0x767F140", VA = "0x187680340")]
		public IXRPCFLIUHD(IWDPUIOQXGH a, [Optional] AUSIWDMIQWV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x767FE70", Offset = "0x767EC70", VA = "0x18767FE70")]
		internal void XDEAKORBJVI(STMVIUBNLIO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x767B970", Offset = "0x767A770", VA = "0x18767B970")]
		internal void ICTEZVLHHKK(STMVIUBNLIO a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7680240", Offset = "0x767F040", VA = "0x187680240")]
		internal void ZDLJXRTYTIM(STMVIUBNLIO a, DisconnectReason b, SocketError c, YWFYQVAMFNU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x767EE90", Offset = "0x767DC90", VA = "0x18767EE90")]
		private void TWYJCIKCVVT(STMVIUBNLIO a, DisconnectReason b, SocketError c, bool d, byte[] e, int f, int g, YWFYQVAMFNU h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x767B410", Offset = "0x767A210", VA = "0x18767B410")]
		private void ELAZBBWMUNT(POCSWJMAYMG.EType a, [Optional] STMVIUBNLIO b, [Optional] IPEndPoint c, SocketError d = SocketError.Success, int e = 0, DisconnectReason f = DisconnectReason.ConnectionFailed, [Optional] SIHIWNGOKBG g, DeliveryMethod h = DeliveryMethod.Unreliable, byte i = 0, [Optional] YWFYQVAMFNU j, [Optional] object k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x767D610", Offset = "0x767C410", VA = "0x18767D610")]
		private void SEYGPHDICZS(POCSWJMAYMG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x767F3D0", Offset = "0x767E1D0", VA = "0x18767F3D0")]
		internal void UBBIEBROPTG(POCSWJMAYMG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x767A280", Offset = "0x7679080", VA = "0x18767A280")]
		private void CQEMUFOGIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7679EF0", Offset = "0x7678CF0", VA = "0x187679EF0")]
		private void BCCKLFMGJDS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x767C5F0", Offset = "0x767B3F0", VA = "0x18767C5F0")]
		internal STMVIUBNLIO MJNBIHIHTMD(SIHIWNGOKBG a, byte[] b, int c, int d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x767FDF0", Offset = "0x767EBF0", VA = "0x18767FDF0")]
		private int WVRIFPESYNT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x767F8C0", Offset = "0x767E6C0", VA = "0x18767F8C0")]
		private void VWJMVFNIJLN(IPEndPoint a, STMVIUBNLIO b, QOQHYDMWJWN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7678BE0", Offset = "0x76779E0", VA = "0x187678BE0")]
		private void AQGAZNQSOFM(YWFYQVAMFNU a, IPEndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x767D190", Offset = "0x767BF90", VA = "0x18767D190")]
		internal void PZHNAEPRLXK(YWFYQVAMFNU a, DeliveryMethod b, byte c, int d, STMVIUBNLIO e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x767E5D0", Offset = "0x767D3D0", VA = "0x18767E5D0")]
		public bool Start()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x767E5E0", Offset = "0x767D3E0", VA = "0x18767E5E0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x767DDD0", Offset = "0x767CBD0", VA = "0x18767DDD0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x767D460", Offset = "0x767C260", VA = "0x18767D460")]
		public void RMXIIHMVVWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x767ADF0", Offset = "0x7679BF0", VA = "0x18767ADF0")]
		public STMVIUBNLIO Connect(string address, int port, string key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x767AED0", Offset = "0x7679CD0", VA = "0x18767AED0")]
		public STMVIUBNLIO Connect(string address, int port, JPNPRKXNCWB connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x767AFB0", Offset = "0x7679DB0", VA = "0x18767AFB0")]
		public STMVIUBNLIO Connect(IPEndPoint target, JPNPRKXNCWB connectionData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x767E960", Offset = "0x767D760", VA = "0x18767E960")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x767E600", Offset = "0x767D400", VA = "0x18767E600")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x767ED60", Offset = "0x767DB60", VA = "0x18767ED60")]
		public void TMINPCUXBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x767EC90", Offset = "0x767DA90", VA = "0x18767EC90")]
		public void TMINPCUXBII(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x767EE50", Offset = "0x767DC50", VA = "0x18767EE50")]
		public void TWYJCIKCVVT(STMVIUBNLIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x767EE10", Offset = "0x767DC10", VA = "0x18767EE10")]
		public void TWYJCIKCVVT(STMVIUBNLIO a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x767B380", Offset = "0x767A180", VA = "0x18767B380", Slot = "4")]
		private IEnumerator<STMVIUBNLIO> EHEWFNKWGLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x767FD60", Offset = "0x767EB60", VA = "0x18767FD60", Slot = "5")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x767C500", Offset = "0x767B300", VA = "0x18767C500")]
		private YWFYQVAMFNU LYUCUICIRBQ(PacketProperty a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x767C420", Offset = "0x767B220", VA = "0x18767C420")]
		private YWFYQVAMFNU LYUCUICIRBQ(PacketProperty a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x767BBE0", Offset = "0x767A9E0", VA = "0x18767BBE0")]
		internal YWFYQVAMFNU KTGPPQOQDAX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x767BE20", Offset = "0x767AC20", VA = "0x18767BE20")]
		internal void LLQZZNBUDIC(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7680280", Offset = "0x767F080", VA = "0x187680280")]
		static IXRPCFLIUHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBC2AC0", Offset = "0xBC18C0", VA = "0x180BC2AC0")]
		private bool UGUWUTTUJCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x767F270", Offset = "0x767E070", VA = "0x18767F270")]
		private void TXQWMBINKYH(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x767CF90", Offset = "0x767BD90", VA = "0x18767CF90")]
		private void OOMVJKXXBJK(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x767F720", Offset = "0x767E520", VA = "0x18767F720")]
		private bool VRUQPMQYLNM(SocketException a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x767B7E0", Offset = "0x767A5E0", VA = "0x18767B7E0")]
		private void FAJEFAELAFH(QABWCBVWNQO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x767FEC0", Offset = "0x767ECC0", VA = "0x18767FEC0")]
		private void YGAVRPSFNJA(THQGKLZTYAT a, EndPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x767C090", Offset = "0x767AE90", VA = "0x18767C090")]
		private void LOBSVKKTDWK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x767DE50", Offset = "0x767CC50", VA = "0x18767DE50")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x767A220", Offset = "0x7679020", VA = "0x18767A220")]
		internal int CCGXVEAUTPR(YWFYQVAMFNU a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x767ADB0", Offset = "0x7679BB0", VA = "0x18767ADB0")]
		internal int CRCKZXDPYXX(YWFYQVAMFNU a, IPEndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x767A5E0", Offset = "0x76793E0", VA = "0x18767A5E0")]
		internal int CRCKZXDPYXX(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x767F4E0", Offset = "0x767E2E0", VA = "0x18767F4E0")]
		internal void UMCBMWREDOU(bool a)
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
	internal sealed class YWFYQVAMFNU
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private static readonly int JORNJXTSNNP;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly int[] OZJNOBXSXEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public byte[] TYGMKPCWCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int YSHPTWWWFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public object NDGCHRGNOIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public YWFYQVAMFNU XYTCBKNEVMS;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PacketProperty NRMYWAZRGMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x768C2E0", Offset = "0x768B0E0", VA = "0x18768C2E0")]
			get
			{
				return default(PacketProperty);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x768C400", Offset = "0x768B200", VA = "0x18768C400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public byte BGDSKSQJYZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x768C380", Offset = "0x768B180", VA = "0x18768C380")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x768C440", Offset = "0x768B240", VA = "0x18768C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ushort RETLHVUNMLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x768C3B0", Offset = "0x768B1B0", VA = "0x18768C3B0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x768C4E0", Offset = "0x768B2E0", VA = "0x18768C4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VXSECDCVFCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x768C520", Offset = "0x768B320", VA = "0x18768C520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public byte UGJSOHZOFMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x768C3D0", Offset = "0x768B1D0", VA = "0x18768C3D0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x768C550", Offset = "0x768B350", VA = "0x18768C550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ushort TPMJTXUHWDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x768C480", Offset = "0x768B280", VA = "0x18768C480")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x768C7A0", Offset = "0x768B5A0", VA = "0x18768C7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ushort YHMSVOJGLSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x768C7E0", Offset = "0x768B5E0", VA = "0x18768C7E0")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x768C340", Offset = "0x768B140", VA = "0x18768C340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ushort SUFLJRQHKSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x768C780", Offset = "0x768B580", VA = "0x18768C780")]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x768C4A0", Offset = "0x768B2A0", VA = "0x18768C4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x768C800", Offset = "0x768B600", VA = "0x18768C800")]
		static YWFYQVAMFNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x768C310", Offset = "0x768B110", VA = "0x18768C310")]
		public void AHASJLNJNRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x768CBE0", Offset = "0x768B9E0", VA = "0x18768CBE0")]
		public YWFYQVAMFNU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x768CAD0", Offset = "0x768B8D0", VA = "0x18768CAD0")]
		public YWFYQVAMFNU(PacketProperty a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x768C680", Offset = "0x768B480", VA = "0x18768C680")]
		public static int OMQICFKBMXH(PacketProperty a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x768C6F0", Offset = "0x768B4F0", VA = "0x18768C6F0")]
		public int OMQICFKBMXH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x768C580", Offset = "0x768B380", VA = "0x18768C580")]
		public bool MBWOMSKQKPE()
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
	public class STMVIUBNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class ZVMXUTRFRJW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public YWFYQVAMFNU[] DZZEEQJFVEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int EGUWKQTPXJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public int PNVMCPSOTKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public byte UGJSOHZOFMH;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public ZVMXUTRFRJW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void OnUpdatedMtuDelegate(ulong transportId, int mtu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int LBNVDTQMWLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int QENLJHFKYIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int FFNBKAIGCPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private double KVCCYVIIKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int EWMLRQWRHUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int XDYPQWCPYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int DOBQDPHDANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Stopwatch IQOQWIFBAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int HSUAJLNYPRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private long KRCRUOMCZCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly object IEFKSCHNDLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		internal STMVIUBNLIO YVDURMNXHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal STMVIUBNLIO CXWMYZNQIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Queue<YWFYQVAMFNU> DKQYUORVRIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ConcurrentQueue<JGKTPEIUTKF> ZUDWLLJSHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly JGKTPEIUTKF[] TISHPLYUJWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int SYYWBTWUVJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int EXFCAVNUWCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool CFDDAUQKWCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int FUVYVYDMKDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int XYMGULWOTYW;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int IAUACKSVFFM = 1000;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int EQCCIAOBNEF = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly object BRHXKEFEDGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int WBUSSMQJAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Dictionary<ushort, ZVMXUTRFRJW> LTERLPVYKZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly Dictionary<ushort, ushort> NQFIDZUAIIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly YWFYQVAMFNU SBQXSQWIBMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int BAEEWZMNLZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int FGDJTWTMYOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IPEndPoint OCSMDLVSRLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private int ZGHGWDLZNAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private int ZPNKRLHHNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private long DGYVAIKMIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private byte SYVJVKGGVXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private ConnectionState KOXADACKKQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private YWFYQVAMFNU MNVRQSCRQZQ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private const int DFOBHRDUAAY = 300;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private int NFTZPJYUQQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly YWFYQVAMFNU WQPAKGYPCWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly YWFYQVAMFNU OZPLRQWJNPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly YWFYQVAMFNU FXCYQEZGLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly YWFYQVAMFNU LJPYYRIGUOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ConnectionQuality QMCUOCSMWSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly IXRPCFLIUHD IXRPCFLIUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly int WBRSHDLSFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public object BUYRLXACKGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public readonly CPBEINFCBGF YAZPNIGNSIM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal byte KTIPEQFQCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xACAB50", Offset = "0xAC9950", VA = "0x180ACAB50")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x76870F0", Offset = "0x7685EF0", VA = "0x1876870F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPEndPoint HWDZIHDGJEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBDB500", Offset = "0xBDA300", VA = "0x180BDB500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ConnectionState JPQZBXCGZUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xBDB140", Offset = "0xBD9F40", VA = "0x180BDB140")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal long FZJDNWSVYGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB8B0", VA = "0x180AACAB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YRBAHRJDPLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB90470", Offset = "0xB8F270", VA = "0x180B90470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x22EBB90", Offset = "0x22EA990", VA = "0x1822EBB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HEDAHUEJYAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7687310", Offset = "0x7686110", VA = "0x187687310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int IGXKHYJAXGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xABBB40", Offset = "0xABA940", VA = "0x180ABBB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal double JFWAONJKXBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2A57130", Offset = "0x2A55F30", VA = "0x182A57130")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OnUpdatedMtuDelegate FJOSLGXZMRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x768A9E0", Offset = "0x76897E0", VA = "0x18768A9E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7689BE0", Offset = "0x76889E0", VA = "0x187689BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x768AA90", Offset = "0x7689890", VA = "0x18768AA90")]
		internal STMVIUBNLIO(IXRPCFLIUHD a, IPEndPoint b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x76872F0", Offset = "0x76860F0", VA = "0x1876872F0")]
		internal void DQAZSNHVSEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7687A10", Offset = "0x7686810", VA = "0x187687A10")]
		internal void FDFBRFTTHND(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7689A80", Offset = "0x7688880", VA = "0x187689A80")]
		internal void LZAZRKJWTEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7689B10", Offset = "0x7688910", VA = "0x187689B10")]
		private void POOHIWINQWP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x768A070", Offset = "0x7688E70", VA = "0x18768A070")]
		private void UYHGUQQLNXH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7689400", Offset = "0x7688200", VA = "0x187689400")]
		public int ISUWTWYTNJT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76892E0", Offset = "0x76880E0", VA = "0x1876892E0")]
		public int ISUWTWYTNJT(byte a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x76884D0", Offset = "0x76872D0", VA = "0x1876884D0")]
		private JGKTPEIUTKF HHXRLQQJZMC(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x768AE90", Offset = "0x7689C90", VA = "0x18768AE90")]
		internal STMVIUBNLIO(IXRPCFLIUHD a, IPEndPoint b, int c, byte d, JPNPRKXNCWB e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x768B020", Offset = "0x7689E20", VA = "0x18768B020")]
		internal STMVIUBNLIO(IXRPCFLIUHD a, SIHIWNGOKBG b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7689D10", Offset = "0x7688B10", VA = "0x187689D10")]
		internal void Reject(QOQHYDMWJWN requestData, byte[] data, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7689C90", Offset = "0x7688A90", VA = "0x187689C90")]
		internal bool RWTBLZUCUQC(YEKUBQNDJAU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7687CA0", Offset = "0x7686AA0", VA = "0x187687CA0")]
		public void FJEWZTPWMSF(byte[] a, int b, int c, DeliveryMethod d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7687CD0", Offset = "0x7686AD0", VA = "0x187687CD0")]
		private void FQZBVSGHLFG(byte[] a, int b, int c, byte d, DeliveryMethod e, object f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7687320", Offset = "0x7686120", VA = "0x187687320")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x768A940", Offset = "0x7689740", VA = "0x18768A940")]
		internal DisconnectResult XSDZUAILGLI(YWFYQVAMFNU a)
		{
			return default(DisconnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7688660", Offset = "0x7687460", VA = "0x187688660")]
		internal void HQCGUDGGKLX(JGKTPEIUTKF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7689D60", Offset = "0x7688B60", VA = "0x187689D60")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7689510", Offset = "0x7688310", VA = "0x187689510")]
		private void KABSVCJERFG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76886C0", Offset = "0x76874C0", VA = "0x1876886C0")]
		internal void IAHJIJGNOEA(DeliveryMethod a, YWFYQVAMFNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7689550", Offset = "0x7688350", VA = "0x187689550")]
		private void LJGPHANGJSA(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7688F50", Offset = "0x7687D50", VA = "0x187688F50")]
		private void ISUKABKQTII(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x768A780", Offset = "0x7689580", VA = "0x18768A780")]
		internal ConnectRequestResult VWJMVFNIJLN(QOQHYDMWJWN a)
		{
			return default(ConnectRequestResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7687370", Offset = "0x7686170", VA = "0x187687370")]
		internal void ECULTPEWGYM(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x76871A0", Offset = "0x7685FA0", VA = "0x1876871A0")]
		private void BSHSYCGVIEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76882C0", Offset = "0x76870C0", VA = "0x1876882C0")]
		internal void GOALRWVGAZM(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x768A0B0", Offset = "0x7688EB0", VA = "0x18768A0B0")]
		internal void Update(int deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7687A40", Offset = "0x7686840", VA = "0x187687A40")]
		internal void FHVBAIQPNRE(YWFYQVAMFNU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class CPBEINFCBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private long WOKDFVKLMRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private long XMYIZDSTIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private long HVWBURWVJRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private long CCKQYHMBCUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private long JWXPUQDCFVB;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static long ACSFDCJIXTU;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private static long GUDGMLANEYD;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static long QTIQGBQKTRK;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static long ZRFVKMVRIYB;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static long VVEWAIKONYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private long RHYDDGHJUWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private long HVBDMBRHJQZ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public long AMECUNLNGWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7675B40", Offset = "0x7674940", VA = "0x187675B40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long IVNKTQUSXCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7675A80", Offset = "0x7674880", VA = "0x187675A80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public long RRIAWYNQNDW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7676210", Offset = "0x7675010", VA = "0x187676210")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long OSHWJYCWNJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7675A70", Offset = "0x7674870", VA = "0x187675A70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public long HSCZDCVWYGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7676220", Offset = "0x7675020", VA = "0x187676220")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long JICRBXYWAZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7675A90", Offset = "0x7674890", VA = "0x187675A90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static long CCDKCADGSFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7675C90", Offset = "0x7674A90", VA = "0x187675C90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static long KQGTWWGDSII
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7675B00", Offset = "0x7674900", VA = "0x187675B00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private ConnectionQuality PDTCLAFWRBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x145E240", Offset = "0x145D040", VA = "0x18145E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double JYPLSCYQQWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7675C30", Offset = "0x7674A30", VA = "0x187675C30")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7675D90", Offset = "0x7674B90", VA = "0x187675D90")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7675AA0", Offset = "0x76748A0", VA = "0x187675AA0")]
		public void FMLHXXAKNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7675D40", Offset = "0x7674B40", VA = "0x187675D40")]
		public void QHSTYYZXRZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7675CD0", Offset = "0x7674AD0", VA = "0x187675CD0")]
		public void PCZVGFUQMNZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7675DD0", Offset = "0x7674BD0", VA = "0x187675DD0")]
		public void SMVUIQMZWWC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7675B50", Offset = "0x7674950", VA = "0x187675B50")]
		public void LIINHZRKYCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7675BB0", Offset = "0x76749B0", VA = "0x187675BB0")]
		public void NCZNAFASMOZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7675E40", Offset = "0x7674C40", VA = "0x187675E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7676170", Offset = "0x7674F70", VA = "0x187676170")]
		public void UFOOALJJKWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public CPBEINFCBGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FZDLEUYUQPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly List<string> SJBNHVADZSC;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7677F30", Offset = "0x7676D30", VA = "0x187677F30")]
		public static IPEndPoint KAEPMOIBCCQ(string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x76781A0", Offset = "0x7676FA0", VA = "0x1876781A0")]
		public static IPAddress YJAXEFMBBGP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7678370", Offset = "0x7677170", VA = "0x187678370")]
		public static IPAddress YJAXEFMBBGP(string a, AddressFamily b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7678170", Offset = "0x7676F70", VA = "0x187678170")]
		internal static int PXZOQRGPRUP(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x38E1870", Offset = "0x38E0670", VA = "0x1838E1870")]
		internal static T[] BMXMTMMCGMW<T>(int a) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class QAYADXELOLW : JGKTPEIUTKF
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PendingPacket
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private YWFYQVAMFNU _packet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private long _timeStamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool _isSent;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x76842D0", Offset = "0x76830D0", VA = "0x1876842D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x76843B0", Offset = "0x76831B0", VA = "0x1876843B0")]
			public void YXKPQQSUPQN(YWFYQVAMFNU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7684340", Offset = "0x7683140", VA = "0x187684340")]
			public bool VQZXFZVKEOC(long a, STMVIUBNLIO b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7684280", Offset = "0x7683080", VA = "0x187684280")]
			public bool Clear(STMVIUBNLIO peer)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly YWFYQVAMFNU YCGETXMLJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly PendingPacket[] VEEIAEWUXLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly YWFYQVAMFNU[] TCJXXNPHVWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly bool[] ROCLDNJXCBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int ZVDVBOSLEVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int VFQXFPBWSPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int SIXCAOJVMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int PDKYRGMELAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool KLUJUGFLDYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly DeliveryMethod RCMQDOQHDOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly bool LNYLKOBMTOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly int SRDARFKPDOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly byte KHPEHWZAOSR;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int RDRPEDVUCAK
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7685220", Offset = "0x7684020", VA = "0x187685220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7685230", Offset = "0x7684030", VA = "0x187685230")]
		public QAYADXELOLW(STMVIUBNLIO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7684EA0", Offset = "0x7683CA0", VA = "0x187684EA0")]
		private void RZUGMFXLAGB(YWFYQVAMFNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76843D0", Offset = "0x76831D0", VA = "0x1876843D0", Slot = "4")]
		protected override bool CINDWBAXDRP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x76848A0", Offset = "0x76836A0", VA = "0x1876848A0", Slot = "5")]
		public override bool ECULTPEWGYM(YWFYQVAMFNU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class QZKRLUXWRPH : JGKTPEIUTKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int ZWOOXXUYZXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ushort VFQXFPBWSPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly bool TVSCUBIQTYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private YWFYQVAMFNU UNGCPOOHLVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private readonly YWFYQVAMFNU ZITWFXJRPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool ZPJPZRSNXOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly byte KHPEHWZAOSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private long BMLYDQULNVB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7685FA0", Offset = "0x7684DA0", VA = "0x187685FA0")]
		public QZKRLUXWRPH(STMVIUBNLIO a, bool b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7685860", Offset = "0x7684660", VA = "0x187685860", Slot = "4")]
		protected override bool CINDWBAXDRP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7685D20", Offset = "0x7684B20", VA = "0x187685D20", Slot = "5")]
		public override bool ECULTPEWGYM(YWFYQVAMFNU a)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class TDFBEIZGQUY
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
		[Cpp2IlInjected.Address(RVA = "0x7675810", Offset = "0x7674610", VA = "0x187675810")]
		private static void NFJPZMUYNOR(byte[] a, int b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x768B200", Offset = "0x768A000", VA = "0x18768B200")]
		private static void NFJPZMUYNOR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x768B270", Offset = "0x768A070", VA = "0x18768B270")]
		public static void NFJPZMUYNOR(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x768B330", Offset = "0x768A130", VA = "0x18768B330")]
		public static void LCWJNSQMAWE(byte[] a, int b, double c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x768B2B0", Offset = "0x768A0B0", VA = "0x18768B2B0")]
		public static void LCWJNSQMAWE(byte[] a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x768B270", Offset = "0x768A070", VA = "0x18768B270")]
		public static void LCWJNSQMAWE(byte[] a, int b, short c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x768B270", Offset = "0x768A070", VA = "0x18768B270")]
		public static void LCWJNSQMAWE(byte[] a, int b, ushort c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x768B200", Offset = "0x768A000", VA = "0x18768B200")]
		public static void LCWJNSQMAWE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x768B200", Offset = "0x768A000", VA = "0x18768B200")]
		public static void LCWJNSQMAWE(byte[] a, int b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x768B350", Offset = "0x768A150", VA = "0x18768B350")]
		public static void LCWJNSQMAWE(byte[] a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x768B350", Offset = "0x768A150", VA = "0x18768B350")]
		public static void LCWJNSQMAWE(byte[] a, int b, ulong c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class FHXQBUDMLQR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		protected byte[] WQXYYCNZQIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		protected int JLTCEANNGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		protected int OXVOQTXEZIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int IKSREAPYJOT;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] TYGMKPCWCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BKQXMUBYETR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int DRVXONGXQXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7677790", Offset = "0x7676590", VA = "0x187677790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool POYBVEIAILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x29C0090", Offset = "0x29BEE90", VA = "0x1829C0090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int JSBMPWFZJXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7677710", Offset = "0x7676510", VA = "0x187677710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7677BE0", Offset = "0x76769E0", VA = "0x187677BE0")]
		public void UDOEBJQKFXO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FHXQBUDMLQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7677ED0", Offset = "0x7676CD0", VA = "0x187677ED0")]
		public FHXQBUDMLQR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x76778C0", Offset = "0x76766C0", VA = "0x1876778C0")]
		public IPEndPoint NLAOQTBJEOZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x76777E0", Offset = "0x76765E0", VA = "0x1876777E0")]
		public byte KBBRSLJOKUD()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x76777E0", Offset = "0x76765E0", VA = "0x1876777E0")]
		public sbyte MIQZDFAJDAQ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x38D9450", Offset = "0x38D8250", VA = "0x1838D9450")]
		public a[] USZOOWGVRFE<a>(ushort a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7677E90", Offset = "0x7676C90", VA = "0x187677E90")]
		public bool[] ZOVWYRCTNAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7677C90", Offset = "0x7676A90", VA = "0x187677C90")]
		public ushort[] VGCCFEEBABV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7677640", Offset = "0x7676440", VA = "0x187677640")]
		public short[] AOCNGJSCOHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7677850", Offset = "0x7676650", VA = "0x187677850")]
		public int[] LFZQKXSPBSL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7677C50", Offset = "0x7676A50", VA = "0x187677C50")]
		public uint[] UVKEBWHVJZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7677DE0", Offset = "0x7676BE0", VA = "0x187677DE0")]
		public float[] XIJCWSNJKIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76777A0", Offset = "0x76765A0", VA = "0x1876777A0")]
		public double[] HKYUQIVZHVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7677DA0", Offset = "0x7676BA0", VA = "0x187677DA0")]
		public long[] WVCQARQBMHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7677BA0", Offset = "0x76769A0", VA = "0x187677BA0")]
		public ulong[] THEFCPFRKTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7677CD0", Offset = "0x7676AD0", VA = "0x187677CD0")]
		public string[] WMZNOBJWOQB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7677720", Offset = "0x7676520", VA = "0x187677720")]
		public bool FRRVSXYXABH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7677760", Offset = "0x7676560", VA = "0x187677760")]
		public char QXRCBHJRZJL()
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7677760", Offset = "0x7676560", VA = "0x187677760")]
		public ushort GJACDSDEUPI()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7677760", Offset = "0x7676560", VA = "0x187677760")]
		public short IUDNOYQUBHH()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7677890", Offset = "0x7676690", VA = "0x187677890")]
		public long USPSXOBHZNJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7677890", Offset = "0x7676690", VA = "0x187677890")]
		public ulong LUAFHMJAOJQ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7677820", Offset = "0x7676620", VA = "0x187677820")]
		public int KMAFLQSQVVE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7677820", Offset = "0x7676620", VA = "0x187677820")]
		public uint RAMQSYAWIBD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7677E60", Offset = "0x7676C60", VA = "0x187677E60")]
		public float ZBRXOSQDDKJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7677C20", Offset = "0x7676A20", VA = "0x187677C20")]
		public double UMJJBFNCAGI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7677990", Offset = "0x7676790", VA = "0x187677990")]
		public string RLTBLLZRBWM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7677680", Offset = "0x7676480", VA = "0x187677680")]
		public ArraySegment<byte> AVJLVMOBPSJ(int a)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7677950", Offset = "0x7676750", VA = "0x187677950")]
		public sbyte[] OXNKZVQHRXP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7677E20", Offset = "0x7676C20", VA = "0x187677E20")]
		public byte[] XSSFVONRAAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x76776F0", Offset = "0x76764F0", VA = "0x1876776F0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class JPNPRKXNCWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		protected byte[] WQXYYCNZQIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		protected int JLTCEANNGCP;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const int DIEOQDLZRNW = 64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly bool JBUIIUBFFDV;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UTF8Encoding KSEJFLENWUV;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int RIVGSIESYJM = 32768;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly byte[] ZZDAZTDZFRJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public byte[] JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int WKYILYEQKLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76822D0", Offset = "0x76810D0", VA = "0x1876822D0")]
		public JPNPRKXNCWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7682230", Offset = "0x7681030", VA = "0x187682230")]
		public JPNPRKXNCWB(bool a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7681510", Offset = "0x7680310", VA = "0x187681510")]
		public static JPNPRKXNCWB IHXEHVYEADY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7681580", Offset = "0x7680380", VA = "0x187681580")]
		public void OBFVQNFSJYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A38490", Offset = "0x2A37290", VA = "0x182A38490")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7681B90", Offset = "0x7680990", VA = "0x187681B90")]
		public void ULFBEMVKFUY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7681C30", Offset = "0x7680A30", VA = "0x187681C30")]
		public void ULFBEMVKFUY(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7681690", Offset = "0x7680490", VA = "0x187681690")]
		public void ULFBEMVKFUY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7681690", Offset = "0x7680490", VA = "0x187681690")]
		public void ULFBEMVKFUY(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x76819D0", Offset = "0x76807D0", VA = "0x1876819D0")]
		public void ULFBEMVKFUY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76819D0", Offset = "0x76807D0", VA = "0x1876819D0")]
		public void ULFBEMVKFUY(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7681620", Offset = "0x7680420", VA = "0x187681620")]
		public void ULFBEMVKFUY(char a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7681620", Offset = "0x7680420", VA = "0x187681620")]
		public void ULFBEMVKFUY(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7681620", Offset = "0x7680420", VA = "0x187681620")]
		public void ULFBEMVKFUY(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76816E0", Offset = "0x76804E0", VA = "0x1876816E0")]
		public void ULFBEMVKFUY(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x76816E0", Offset = "0x76804E0", VA = "0x1876816E0")]
		public void ULFBEMVKFUY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7681960", Offset = "0x7680760", VA = "0x187681960")]
		public void ULFBEMVKFUY(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7681C80", Offset = "0x7680A80", VA = "0x187681C80")]
		public void UXVUWVMHYQY(sbyte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7681C80", Offset = "0x7680A80", VA = "0x187681C80")]
		public void XJNSJUTBDMT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7681B30", Offset = "0x7680930", VA = "0x187681B30")]
		public void ULFBEMVKFUY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7681E40", Offset = "0x7680C40", VA = "0x187681E40")]
		public void YQLTXTUZUZH(Array a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7681D60", Offset = "0x7680B60", VA = "0x187681D60")]
		public void YQLTXTUZUZH(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7681F20", Offset = "0x7680D20", VA = "0x187681F20")]
		public void YQLTXTUZUZH(double[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7681F20", Offset = "0x7680D20", VA = "0x187681F20")]
		public void YQLTXTUZUZH(long[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7681F20", Offset = "0x7680D20", VA = "0x187681F20")]
		public void YQLTXTUZUZH(ulong[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7681D60", Offset = "0x7680B60", VA = "0x187681D60")]
		public void YQLTXTUZUZH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7681D60", Offset = "0x7680B60", VA = "0x187681D60")]
		public void YQLTXTUZUZH(uint[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7682000", Offset = "0x7680E00", VA = "0x187682000")]
		public void YQLTXTUZUZH(ushort[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7682000", Offset = "0x7680E00", VA = "0x187682000")]
		public void YQLTXTUZUZH(short[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7681C80", Offset = "0x7680A80", VA = "0x187681C80")]
		public void YQLTXTUZUZH(bool[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x76820E0", Offset = "0x7680EE0", VA = "0x1876820E0")]
		public void YQLTXTUZUZH(string[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7681A60", Offset = "0x7680860", VA = "0x187681A60")]
		public void ULFBEMVKFUY(IPEndPoint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7681950", Offset = "0x7680750", VA = "0x187681950")]
		public void ULFBEMVKFUY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7681740", Offset = "0x7680540", VA = "0x187681740")]
		public void ULFBEMVKFUY(string a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class GHQSDFOTQCS
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private static class ODKHAXZDNAM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly ulong WBRSHDLSFDA;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5B587F0", Offset = "0x5B575F0", VA = "0x185B587F0")]
			static ODKHAXZDNAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		protected delegate void SubscribeDelegate(FHXQBUDMLQR reader, object userData);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class RIUFFUXYGAP<a> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public GHQSDFOTQCS SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public a IPFIWTSDTZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public Action<a> ZVLZHAFRVFR;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public RIUFFUXYGAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5D422B0", Offset = "0x5D410B0", VA = "0x185D422B0")]
			internal void AWQGLNVFJJC(FHXQBUDMLQR a, object b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BADXQKPHGKX<a, b> where a : class, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GHQSDFOTQCS SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public a IPFIWTSDTZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public Action<a, b> ZVLZHAFRVFR;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public BADXQKPHGKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6FBF410", Offset = "0x6FBE210", VA = "0x186FBF410")]
			internal void AWQGLNVFJJC(FHXQBUDMLQR a, object b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly XAGARMMGQIG KRQYXIJMQMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly Dictionary<ulong, SubscribeDelegate> WAWMOOHJLRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly JPNPRKXNCWB IEVDYLYEHFO;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7678630", Offset = "0x7677430", VA = "0x187678630")]
		public GHQSDFOTQCS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x38F23A0", Offset = "0x38F11A0", VA = "0x1838F23A0", Slot = "4")]
		protected virtual ulong DUPHYCIRWJL<a>()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7678510", Offset = "0x7677310", VA = "0x187678510", Slot = "5")]
		protected virtual SubscribeDelegate RPFHWJCNJWW(FHXQBUDMLQR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x38F24B0", Offset = "0x38F12B0", VA = "0x1838F24B0", Slot = "6")]
		protected virtual void IFNZIVNHKAW<b>(JPNPRKXNCWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7678490", Offset = "0x7677290", VA = "0x187678490")]
		public void JWZPFXEYCJV(FHXQBUDMLQR a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x38F2420", Offset = "0x38F1220", VA = "0x1838F2420")]
		public void GYOQNYAFVSC<j>(JPNPRKXNCWB a, j b) where j : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x76785E0", Offset = "0x76773E0", VA = "0x1876785E0")]
		public void WTYRMGCEDUL(FHXQBUDMLQR a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x38F26B0", Offset = "0x38F14B0", VA = "0x1838F26B0")]
		public void SYQSCVEWWAA<l>(Action<l> a) where l : class, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x38F26B0", Offset = "0x38F14B0", VA = "0x1838F26B0")]
		public void SYQSCVEWWAA<m, n>(Action<m, n> a) where m : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class InvalidTypeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7681300", Offset = "0x7680100", VA = "0x187681300")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ParseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7684220", Offset = "0x7683020", VA = "0x187684220")]
		public ParseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class XAGARMMGQIG
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
		private abstract class GNKZGELWPHQ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CallType QHIGGIBDJUD;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x50AC770", Offset = "0x50AB570", VA = "0x1850AC770", Slot = "4")]
			public virtual void YXKPQQSUPQN(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "5")]
			public abstract void MSEOBYBVTHZ(a a, FHXQBUDMLQR b);

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract void GYOQNYAFVSC(a a, JPNPRKXNCWB b);

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void DGRUOZNUKUI(a a, FHXQBUDMLQR b);

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void BMFSLABCBDB(a a, JPNPRKXNCWB b);

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(Slot = "9")]
			public abstract void CCMJTEXEHHZ(a a, FHXQBUDMLQR b);

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void EXWFRAGXBTE(a a, JPNPRKXNCWB b);

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			protected GNKZGELWPHQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private abstract class YMOSYBGQAZZ<a, b> : GNKZGELWPHQ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			protected Func<a, b> MBZXXBTFXVG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			protected Action<a, b> UVKFBBHLKHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			protected Func<a, b[]> JFAXPURSFQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			protected Action<a, b[]> XBKIUGGWESP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			protected Func<a, List<b>> VGMTEXEHZGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			protected Action<a, List<b>> FEURTSKIIQY;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x410F200", Offset = "0x410E000", VA = "0x18410F200", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x410F200", Offset = "0x410E000", VA = "0x18410F200", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x410F2D0", Offset = "0x410E0D0", VA = "0x18410F2D0", Slot = "9")]
			public override void CCMJTEXEHHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x410F2D0", Offset = "0x410E0D0", VA = "0x18410F2D0", Slot = "10")]
			public override void EXWFRAGXBTE(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x410F3A0", Offset = "0x410E1A0", VA = "0x18410F3A0")]
			protected b[] IFWPKHYJKGM(a a, FHXQBUDMLQR b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x410F630", Offset = "0x410E430", VA = "0x18410F630")]
			protected b[] PCOZONBKFAT(a a, JPNPRKXNCWB b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x410F790", Offset = "0x410E590", VA = "0x18410F790", Slot = "4")]
			public override void YXKPQQSUPQN(MethodInfo a, MethodInfo b, CallType c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4110230", Offset = "0x410F030", VA = "0x184110230")]
			protected YMOSYBGQAZZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private abstract class VMSFXSTOEFC<a, b> : YMOSYBGQAZZ<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract void QCYEWBGUCQJ(FHXQBUDMLQR a, [Out] b b);

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "12")]
			protected abstract void SVBRGILIWYA(JPNPRKXNCWB a, b b);

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6414BE0", Offset = "0x64139E0", VA = "0x186414BE0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6414B80", Offset = "0x6413980", VA = "0x186414B80", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6414710", Offset = "0x6413510", VA = "0x186414710", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6414670", Offset = "0x6413470", VA = "0x186414670", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6414E50", Offset = "0x6413C50", VA = "0x186414E50")]
			protected VMSFXSTOEFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class LXWAHJDPHUT<a> : YMOSYBGQAZZ<a, int>
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4038EC0", Offset = "0x4037CC0", VA = "0x184038EC0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4038D70", Offset = "0x4037B70", VA = "0x184038D70", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x54911F0", Offset = "0x548FFF0", VA = "0x1854911F0", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4038B00", Offset = "0x4037900", VA = "0x184038B00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public LXWAHJDPHUT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class CRTQRSVENLO<a> : YMOSYBGQAZZ<a, uint>
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4038EC0", Offset = "0x4037CC0", VA = "0x184038EC0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4038D70", Offset = "0x4037B70", VA = "0x184038D70", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4038B40", Offset = "0x4037940", VA = "0x184038B40", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4038B00", Offset = "0x4037900", VA = "0x184038B00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public CRTQRSVENLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private class TWKCVDCWRBK<a> : YMOSYBGQAZZ<a, short>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C8A0", Offset = "0x5A3B6A0", VA = "0x185A3C8A0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C760", Offset = "0x5A3B560", VA = "0x185A3C760", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x60FB470", Offset = "0x60FA270", VA = "0x1860FB470", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C5E0", Offset = "0x5A3B3E0", VA = "0x185A3C5E0", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public TWKCVDCWRBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class NQVGFIQZQIP<a> : YMOSYBGQAZZ<a, ushort>
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C8A0", Offset = "0x5A3B6A0", VA = "0x185A3C8A0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C760", Offset = "0x5A3B560", VA = "0x185A3C760", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C620", Offset = "0x5A3B420", VA = "0x185A3C620", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x5A3C5E0", Offset = "0x5A3B3E0", VA = "0x185A3C5E0", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public NQVGFIQZQIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class UQWKDTQWXRU<a> : YMOSYBGQAZZ<a, long>
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4039300", Offset = "0x4038100", VA = "0x184039300", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x40392C0", Offset = "0x40380C0", VA = "0x1840392C0", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x62E42E0", Offset = "0x62E30E0", VA = "0x1862E42E0", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x4039040", Offset = "0x4037E40", VA = "0x184039040", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public UQWKDTQWXRU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private class CSROXLBBCGL<a> : YMOSYBGQAZZ<a, ulong>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4039300", Offset = "0x4038100", VA = "0x184039300", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x40392C0", Offset = "0x40380C0", VA = "0x1840392C0", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4039080", Offset = "0x4037E80", VA = "0x184039080", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4039040", Offset = "0x4037E40", VA = "0x184039040", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public CSROXLBBCGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private class IIVBLZPAPFI<a> : YMOSYBGQAZZ<a, byte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x51DB9F0", Offset = "0x51DA7F0", VA = "0x1851DB9F0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x51DB7A0", Offset = "0x51DA5A0", VA = "0x1851DB7A0", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x51E1FD0", Offset = "0x51E0DD0", VA = "0x1851E1FD0", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x4161A00", Offset = "0x4160800", VA = "0x184161A00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public IIVBLZPAPFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private class IEVAPPSLWKJ<a> : YMOSYBGQAZZ<a, sbyte>
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x51DB9F0", Offset = "0x51DA7F0", VA = "0x1851DB9F0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x51DB7A0", Offset = "0x51DA5A0", VA = "0x1851DB7A0", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x51DB660", Offset = "0x51DA460", VA = "0x1851DB660", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x4161A00", Offset = "0x4160800", VA = "0x184161A00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public IEVAPPSLWKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private class QPLTFKLMQIU<a> : YMOSYBGQAZZ<a, float>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5D0A520", Offset = "0x5D09320", VA = "0x185D0A520", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5D0A2D0", Offset = "0x5D090D0", VA = "0x185D0A2D0", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x5D0A190", Offset = "0x5D08F90", VA = "0x185D0A190", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4038B00", Offset = "0x4037900", VA = "0x184038B00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public QPLTFKLMQIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private class AXMTQNQZVMF<a> : YMOSYBGQAZZ<a, double>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x5635F40", Offset = "0x5634D40", VA = "0x185635F40", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x5635E00", Offset = "0x5634C00", VA = "0x185635E00", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x5635CC0", Offset = "0x5634AC0", VA = "0x185635CC0", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x4039040", Offset = "0x4037E40", VA = "0x184039040", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public AXMTQNQZVMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class ZLXMEKXILAI<a> : YMOSYBGQAZZ<a, bool>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x4161ED0", Offset = "0x4160CD0", VA = "0x184161ED0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x4161D80", Offset = "0x4160B80", VA = "0x184161D80", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x4161B40", Offset = "0x4160940", VA = "0x184161B40", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4161A00", Offset = "0x4160800", VA = "0x184161A00", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4038F30", Offset = "0x4037D30", VA = "0x184038F30")]
			public ZLXMEKXILAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private class LIYBRHUXUEY<a> : VMSFXSTOEFC<a, char>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5489B70", Offset = "0x5488970", VA = "0x185489B70", Slot = "12")]
			protected override void SVBRGILIWYA(JPNPRKXNCWB a, char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5489B40", Offset = "0x5488940", VA = "0x185489B40", Slot = "11")]
			protected override void QCYEWBGUCQJ(FHXQBUDMLQR a, [Out] char b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x402F240", Offset = "0x402E040", VA = "0x18402F240")]
			public LIYBRHUXUEY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private class CBFLFFLWZJW<a> : VMSFXSTOEFC<a, IPEndPoint>
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x402F1F0", Offset = "0x402DFF0", VA = "0x18402F1F0", Slot = "12")]
			protected override void SVBRGILIWYA(JPNPRKXNCWB a, IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x402F1B0", Offset = "0x402DFB0", VA = "0x18402F1B0", Slot = "11")]
			protected override void QCYEWBGUCQJ(FHXQBUDMLQR a, [Out] IPEndPoint b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x402F240", Offset = "0x402E040", VA = "0x18402F240")]
			public CBFLFFLWZJW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private class ZVIJBSFQDJL<a> : YMOSYBGQAZZ<a, string>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly int FLYAFXYHWMS;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x417DF70", Offset = "0x417CD70", VA = "0x18417DF70")]
			public ZVIJBSFQDJL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x417DDB0", Offset = "0x417CBB0", VA = "0x18417DDB0", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x417DD60", Offset = "0x417CB60", VA = "0x18417DD60", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x417DC00", Offset = "0x417CA00", VA = "0x18417DC00", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x417DAA0", Offset = "0x417C8A0", VA = "0x18417DAA0", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private class XMOUBEAHGZJ<a> : GNKZGELWPHQ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			protected readonly PropertyInfo NRMYWAZRGMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			protected readonly Type SCUEQQEQAEW;

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x409D6D0", Offset = "0x409C4D0", VA = "0x18409D6D0")]
			public XMOUBEAHGZJ(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x409D630", Offset = "0x409C430", VA = "0x18409D630", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x409D390", Offset = "0x409C190", VA = "0x18409D390", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x409D2F0", Offset = "0x409C0F0", VA = "0x18409D2F0", Slot = "7")]
			public override void DGRUOZNUKUI(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x409D2F0", Offset = "0x409C0F0", VA = "0x18409D2F0", Slot = "8")]
			public override void BMFSLABCBDB(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x409D340", Offset = "0x409C140", VA = "0x18409D340", Slot = "9")]
			public override void CCMJTEXEHHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x409D340", Offset = "0x409C140", VA = "0x18409D340", Slot = "10")]
			public override void EXWFRAGXBTE(a a, JPNPRKXNCWB b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private class CYZQANMUAIY<a> : XMOUBEAHGZJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x4054D60", Offset = "0x4053B60", VA = "0x184054D60")]
			public CYZQANMUAIY(PropertyInfo a, Type b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x4054B80", Offset = "0x4053980", VA = "0x184054B80", Slot = "5")]
			public override void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x4054A00", Offset = "0x4053800", VA = "0x184054A00", Slot = "6")]
			public override void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private sealed class ZIDOYTFSQOC<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public static ZIDOYTFSQOC<a> VDCQJFYBFAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private readonly GNKZGELWPHQ<a>[] CDQMFKEOXBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private readonly int JTJWYLLVIMS;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x415F4D0", Offset = "0x415E2D0", VA = "0x18415F4D0")]
			public ZIDOYTFSQOC(List<GNKZGELWPHQ<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x415F150", Offset = "0x415DF50", VA = "0x18415F150")]
			public void GYOQNYAFVSC(a a, JPNPRKXNCWB b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x415F390", Offset = "0x415E190", VA = "0x18415F390")]
			public void MSEOBYBVTHZ(a a, FHXQBUDMLQR b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private abstract class SBHPRSEYZBW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract GNKZGELWPHQ<T> Get<T>();
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private JPNPRKXNCWB AQRWZBWAEIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly int JPAHTMFQAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly Dictionary<Type, SBHPRSEYZBW> PMNONBWYLFD;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x768B4E0", Offset = "0x768A2E0", VA = "0x18768B4E0")]
		public XAGARMMGQIG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA81F0", Offset = "0x3EA6FF0", VA = "0x183EA81F0")]
		private ZIDOYTFSQOC<d> AMRTIJATLKH<d>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA90C0", Offset = "0x3EA7EC0", VA = "0x183EA90C0")]
		public void IPFDCTVTWHM<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8F80", Offset = "0x3EA7D80", VA = "0x183EA8F80")]
		public bool Deserialize<T>(FHXQBUDMLQR reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9000", Offset = "0x3EA7E00", VA = "0x183EA9000")]
		public void HPFTFJWMZQX<f>(JPNPRKXNCWB a, f b) where f : class, new()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class DXUUFCVKVJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DateTime WFYXKBJNMGQ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public byte[] KFIRUBXWPBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NtpLeapIndicator RLWHELKPZKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7676A60", Offset = "0x7675860", VA = "0x187676A60")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int AWVAIUEIXUY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7676B40", Offset = "0x7675940", VA = "0x187676B40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7676FB0", Offset = "0x7675DB0", VA = "0x187676FB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public NtpMode EFYEADXIPJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7676B70", Offset = "0x7675970", VA = "0x187676B70")]
			get
			{
				return default(NtpMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x76771F0", Offset = "0x7675FF0", VA = "0x1876771F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int HOGWWUDBJAR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x7676DC0", Offset = "0x7675BC0", VA = "0x187676DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public uint ZDLKAXBWBJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7676BA0", Offset = "0x76759A0", VA = "0x187676BA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DateTime? AFQYZVXIGFV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x76770B0", Offset = "0x7675EB0", VA = "0x1876770B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DateTime? KNGZOHHNDIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7676A30", Offset = "0x7675830", VA = "0x187676A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTime? BXPLBYZDNCV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7676A00", Offset = "0x7675800", VA = "0x187676A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x7676230", Offset = "0x7675030", VA = "0x187676230")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public DateTime? ONVQGWWLVHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xFC94E0", Offset = "0xFC82E0", VA = "0x180FC94E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7677330", Offset = "0x7676130", VA = "0x187677330")]
		public DXUUFCVKVJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7677290", Offset = "0x7676090", VA = "0x187677290")]
		internal DXUUFCVKVJN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x76770E0", Offset = "0x7675EE0", VA = "0x1876770E0")]
		public static DXUUFCVKVJN VSKOGISYVVJ(byte[] a, DateTime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7676680", Offset = "0x7675480", VA = "0x187676680")]
		internal void CHVJOWMBKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7676DF0", Offset = "0x7675BF0", VA = "0x187676DF0")]
		private void OXDGSDYDUXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x76763F0", Offset = "0x76751F0", VA = "0x1876763F0")]
		private DateTime? BBZLFWDQJVQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7676C00", Offset = "0x7675A00", VA = "0x187676C00")]
		private void MEUYXHWXRPA(int a, DateTime? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7676A90", Offset = "0x7675890", VA = "0x187676A90")]
		private ulong GVSJSGZAOBU(int a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x76765C0", Offset = "0x76753C0", VA = "0x1876765C0")]
		private void BQBYFUPQYRY(int a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7677050", Offset = "0x7675E50", VA = "0x187677050")]
		private uint QKVIRCBEDCB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7543FD0", Offset = "0x7542DD0", VA = "0x187543FD0")]
		private static uint QIGCNPFGKLG(uint a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7676FF0", Offset = "0x7675DF0", VA = "0x187676FF0")]
		private static ulong QIGCNPFGKLG(ulong a)
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
	internal sealed class JROKNXJGYVO
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const int JRUTDIIWTUZ = 1000;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int NRISAYWDCTG = 10000;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int CJFDSYGVAKX = 123;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IPEndPoint UUZSAXHBSRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int BTKJSKADPXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int ZMFMGMZGPSZ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ZJPNNNLZZDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7682440", Offset = "0x7681240", VA = "0x187682440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7682350", Offset = "0x7681150", VA = "0x187682350")]
		public bool FJEWZTPWMSF(THQGKLZTYAT a, int b)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Sockets
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class SFXUFBBZKRE : THQGKLZTYAT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly Socket GMWTTFEUCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly IXRPCFLIUHD UVJZOYDVNXX;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public short NLYLZFSUBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x7686DD0", Offset = "0x7685BD0", VA = "0x187686DD0", Slot = "4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int KJVDBIMCKVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7686D70", Offset = "0x7685B70", VA = "0x187686D70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EndPoint UPCCOEIQORB
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7686D50", Offset = "0x7685B50", VA = "0x187686D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public AddressFamily OSYMGCMRMER
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x325F7D0", Offset = "0x325E5D0", VA = "0x18325F7D0", Slot = "7")]
			get
			{
				return default(AddressFamily);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7686EE0", Offset = "0x7685CE0", VA = "0x187686EE0")]
		public SFXUFBBZKRE(AddressFamily a, IXRPCFLIUHD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7686770", Offset = "0x7685570", VA = "0x187686770", Slot = "8")]
		public bool Bind(IPEndPoint endPoint, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7686D90", Offset = "0x7685B90", VA = "0x187686D90", Slot = "9")]
		public int PWRXOHKMIQY(byte[] a, int b, int c, IPEndPoint d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7686DF0", Offset = "0x7685BF0", VA = "0x187686DF0", Slot = "10")]
		public int UXPFNODTIBC(byte[] a, EndPoint b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7686D30", Offset = "0x7685B30", VA = "0x187686D30", Slot = "11")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal interface THQGKLZTYAT
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		short NLYLZFSUBPP
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		int KJVDBIMCKVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		EndPoint UPCCOEIQORB
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		AddressFamily OSYMGCMRMER
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
		int PWRXOHKMIQY(byte[] a, int b, int c, IPEndPoint d);

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int UXPFNODTIBC(byte[] a, EndPoint b);

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
		[Cpp2IlInjected.Address(RVA = "0x7683E10", Offset = "0x7682C10", VA = "0x187683E10")]
		public NativeAddr(byte[] address, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7683EB0", Offset = "0x7682CB0", VA = "0x187683EB0")]
		public NativeAddr(Span<byte> address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1664390", Offset = "0x1663190", VA = "0x181664390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7683D20", Offset = "0x7682B20", VA = "0x187683D20", Slot = "4")]
		public bool Equals(NativeAddr other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7683D60", Offset = "0x7682B60", VA = "0x187683D60", Slot = "0")]
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
	public class QABWCBVWNQO
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal delegate void ReceiveCallback(IPEndPoint address, Span<byte> data);

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private const string ZQELYUIYIHU = "server_socket";

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private const int QERNRXIUGUW = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private const int OFQXJIPCTAE = 28;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private const int MCKAWIBJNTQ = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static Dictionary<NativeAddr, IPEndPoint> MMFATCSIWAX;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static ReceiveCallback LXHGDKXTDDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private int CACYVJAVDWS;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		internal void XHMSAECDBTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		internal void DGFHAZOTFOE(IPEndPoint a, Span<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace LiteNetLib.Layers
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class AUSIWDMIQWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public readonly int JLTZHSMDPNI;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
		protected AUSIWDMIQWV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SWIQNBVZGWJ(IPEndPoint a, byte[] b, int c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EEFQSCLEEYA(IPEndPoint a, byte[] b, int c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class YLWQQRRKNDH : AUSIWDMIQWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private byte[] KUJVGNBDNRA;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly RandomNumberGenerator GCVRRMYAFPK;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B43C90", Offset = "0x2B42A90", VA = "0x182B43C90")]
		public YLWQQRRKNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x768BBB0", Offset = "0x768A9B0", VA = "0x18768BBB0")]
		public void SMPXQFXQMEZ(IPEndPoint a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x768C1A0", Offset = "0x768AFA0", VA = "0x18768C1A0")]
		public void XZEJDIHSQPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x768BD60", Offset = "0x768AB60", VA = "0x18768BD60", Slot = "4")]
		public override void SWIQNBVZGWJ(IPEndPoint a, byte[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x768B8B0", Offset = "0x768A6B0", VA = "0x18768B8B0", Slot = "5")]
		public override void EEFQSCLEEYA(IPEndPoint a, byte[] b, int c, int d)
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
		internal static class ZLNAMVQVFVW
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private static IntPtr DSPEYQURJRW;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x768D080", Offset = "0x768BE80", VA = "0x18768D080")]
			[BurstDiscard]
			private static void PXLSLLLROWI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x768D210", Offset = "0x768C010", VA = "0x18768D210")]
			private static IntPtr SCYUXUGHGTU()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x768CE30", Offset = "0x768BC30", VA = "0x18768CE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x76861B0", Offset = "0x7684FB0", VA = "0x1876861B0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7686180", Offset = "0x7684F80", VA = "0x187686180")]
		private uint RFGHBUDUXNP(uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x76753C0", Offset = "0x76741C0", VA = "0x1876753C0")]
		private void JDZGFSMGADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7675470", Offset = "0x7674270", VA = "0x187675470")]
		private void LFWYXFMOSDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7675680", Offset = "0x7674480", VA = "0x187675680")]
		private void TFJUFKMTSVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7675710", Offset = "0x7674510", VA = "0x187675710")]
		private void WRBATMLPDGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7686710", Offset = "0x7685510", VA = "0x187686710")]
		private void VOQNWELKXEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7686230", Offset = "0x7685030", VA = "0x187686230")]
		private unsafe void SMFGURNFLON(byte* a, uint* b, uint* c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7686700", Offset = "0x7685500", VA = "0x187686700")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(LiteNetLib.Layers.Ciphers.Encrypt_0000039F$PostfixBurstDelegate))]
		public unsafe static void VIBLEIIXQZS([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7686650", Offset = "0x7685450", VA = "0x187686650")]
		public static void VIBLEIIXQZS(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x76860D0", Offset = "0x7684ED0", VA = "0x1876860D0")]
		public static void PEQXHMXTIQI(Span<byte> a, Span<byte> b, Span<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7686060", Offset = "0x7684E60", VA = "0x187686060")]
		[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
		public unsafe static void BBFMBIBTOKP([NoAlias] byte* plainText, [NoAlias] byte* key, [NoAlias] byte* iv, int a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x768CDF0", Offset = "0x768BBF0", VA = "0x18768CDF0")]
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
