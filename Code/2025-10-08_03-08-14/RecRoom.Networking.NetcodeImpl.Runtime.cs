using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Dissonance.Integrations.Unity_NFGO;
using Netcode.Transports.LiteNetLib;
using Nito.Collections;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using UJect;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_NetcodeImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x868B8E0", Offset = "0x868A6E0", VA = "0x18868B8E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class LJJEWIWANYD : IPMVOLERGYH, TGPZRTTESHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class URONGTZTDCI : EREVFMKOODS
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x868B8A0", Offset = "0x868A6A0", VA = "0x18868B8A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public byte ZUPUUKDUHLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int QMPBGCEBLTY
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public object ATGJXGHTYWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7F38940", Offset = "0x7F37740", VA = "0x187F38940")]
			public URONGTZTDCI(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x868B860", Offset = "0x868A660", VA = "0x18868B860", Slot = "8")]
			public bool DBGOVWLVGUF(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState MPYWBQWZDYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch BPQTTCCTHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int ZRQTWXEXQBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<URONGTZTDCI> BVYAGWWSHNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> AKHGAEYLLCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SMQTIOFQADW NUCMNKVZBDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private FJXNWXCPWTY TMLXPCEIUEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool NXDBOTYSWJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool DOZDEWGIQSS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager PEONEXKOKMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport FGEKYTRCFEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8685310", Offset = "0x8684110", VA = "0x188685310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState VWCJQAGFTDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x86879C0", Offset = "0x86867C0", VA = "0x1886879C0", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8684AE0", Offset = "0x86838E0", VA = "0x188684AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MOIQMUZNHTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SMQTIOFQADW BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public FJXNWXCPWTY MLXSNUPGFQH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private YBMGACIJTUK UVBALZCOLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool QPWLCIFHQJV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8686030", Offset = "0x8684E30", VA = "0x188686030", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YEIEDVUFOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8683EF0", Offset = "0x8682CF0", VA = "0x188683EF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DRGQMQQAUXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8683EF0", Offset = "0x8682CF0", VA = "0x188683EF0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KWVDVGADDRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8683EF0", Offset = "0x8682CF0", VA = "0x188683EF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool KFZBVYMRAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB45FE0", Offset = "0xB44DE0", VA = "0x180B45FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8686D60", Offset = "0x8685B60", VA = "0x188686D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Exception RCXLWOYSDWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int EJBOHVUMQQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XUNFKCJXWGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8688710", Offset = "0x8687510", VA = "0x188688710", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8685730", Offset = "0x8684530", VA = "0x188685730", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool YTNBPNOSJHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAC50F0", Offset = "0xAC3EF0", VA = "0x180AC50F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAC5100", Offset = "0xAC3F00", VA = "0x180AC5100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double DIHMSZUWUBM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8684560", Offset = "0x8683360", VA = "0x188684560")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double TDZZAKHNJBX
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8685430", Offset = "0x8684230", VA = "0x188685430")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int SFEDHOALWHF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8685FE0", Offset = "0x8684DE0", VA = "0x188685FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string UUDQRAUXDKU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8687E80", Offset = "0x8686C80", VA = "0x188687E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int EGWRUABWIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8688C10", Offset = "0x8687A10", VA = "0x188688C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BAYKEAXSOXC WGQYKZXWXEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8685F90", Offset = "0x8684D90", VA = "0x188685F90", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool WQRDYAPGRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E90", Offset = "0xFBFC90", VA = "0x180FC0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8685040", Offset = "0x8683E40", VA = "0x188685040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> KJWEIYDRGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8685070", Offset = "0x8683E70", VA = "0x188685070", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8684F30", Offset = "0x8683D30", VA = "0x188684F30", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> HQODSIJJOXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8688160", Offset = "0x8686F60", VA = "0x188688160", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x86857A0", Offset = "0x86845A0", VA = "0x1886857A0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8688C50", Offset = "0x8687A50", VA = "0x188688C50")]
		public LJJEWIWANYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8684040", Offset = "0x8682E40", VA = "0x188684040")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8687C70", Offset = "0x8686A70", VA = "0x188687C70")]
		private void TYYUQBHXABW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8684FE0", Offset = "0x8683DE0", VA = "0x188684FE0")]
		private void IOVTWMEMBRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8686C40", Offset = "0x8685A40", VA = "0x188686C40")]
		public bool QNKIKGYQPDC(XGOJTPBZDNO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8687F80", Offset = "0x8686D80", VA = "0x188687F80")]
		public bool UMVVRRFPOHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8685480", Offset = "0x8684280", VA = "0x188685480")]
		public void KLQZCECNFPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8686340", Offset = "0x8685140", VA = "0x188686340")]
		public void OOEUGGHQNWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8685120", Offset = "0x8683F20", VA = "0x188685120")]
		public void JFXICGQVWSD(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86879E0", Offset = "0x86867E0", VA = "0x1886879E0")]
		public void TXWPTSKXGBT(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8688760", Offset = "0x8687560", VA = "0x188688760")]
		public void WKTEJEZQWEQ(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8688210", Offset = "0x8687010", VA = "0x188688210")]
		public void VVUFAYMMXPR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86845B0", Offset = "0x86833B0", VA = "0x1886845B0")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8686060", Offset = "0x8684E60", VA = "0x188686060")]
		public int NNQKMAKZPGT(EREVFMKOODS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8686E80", Offset = "0x8685C80", VA = "0x188686E80")]
		public bool RaiseEvent(byte eventCode, object eventContent, QBWHSXSYUOT raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8685850", Offset = "0x8684650", VA = "0x188685850")]
		public bool MIIIXJFNYLT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8684340", Offset = "0x8683140", VA = "0x188684340")]
		internal bool DECYRFZFJVP([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86854D0", Offset = "0x86842D0", VA = "0x1886854D0")]
		internal bool KXTNTUDXGYX([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8687FD0", Offset = "0x8686DD0", VA = "0x188687FD0")]
		private void USSVYNGPIXK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8685790", Offset = "0x8684590", VA = "0x188685790")]
		public void LeaveRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86846A0", Offset = "0x86834A0", VA = "0x1886846A0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8683C40", Offset = "0x8682A40", VA = "0x188683C40")]
		private void AROQQJLCNQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8683920", Offset = "0x8682720", VA = "0x188683920")]
		private void AEHGIQVZZZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8686250", Offset = "0x8685050", VA = "0x188686250")]
		private void OERLLQSXEHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8684840", Offset = "0x8683640", VA = "0x188684840")]
		private void EOVKGRCTSWX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8685D00", Offset = "0x8684B00", VA = "0x188685D00")]
		private void MLQSBSTYUAE(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39EE610", Offset = "0x39ED410", VA = "0x1839EE610")]
		private void UKXMJVDYRNG<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8684E00", Offset = "0x8683C00", VA = "0x188684E00")]
		private void FSTUAAXRUPP(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86885F0", Offset = "0x86873F0", VA = "0x1886885F0")]
		private void WAZCOGGBYXA(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8683DA0", Offset = "0x8682BA0", VA = "0x188683DA0")]
		private void AWKJJEMEXLM(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86872D0", Offset = "0x86860D0", VA = "0x1886872D0")]
		private void SLGYVVFRYJB(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8684B10", Offset = "0x8683910", VA = "0x188684B10")]
		private void FQOPRYPWZZT(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86864E0", Offset = "0x86852E0", VA = "0x1886864E0")]
		private void QHUDLQIYLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86846B0", Offset = "0x86834B0", VA = "0x1886846B0")]
		private void EOTFYJSTHNE(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8687800", Offset = "0x8686600", VA = "0x188687800")]
		private void SWBDXBVADCY(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8688960", Offset = "0x8687760", VA = "0x188688960")]
		private void WTGXGZKONUM(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8683DD0", Offset = "0x8682BD0", VA = "0x188683DD0")]
		private void BDLGQEYACKU(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86884A0", Offset = "0x86872A0", VA = "0x1886884A0")]
		private void WAZCOGGBYXA(URONGTZTDCI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8686400", Offset = "0x8685200", VA = "0x188686400")]
		private void QDJZKTHRLKO(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8683F40", Offset = "0x8682D40", VA = "0x188683F40")]
		private void CWKMZUHRTFS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8686850", Offset = "0x8685650", VA = "0x188686850")]
		private void QKELXBIZGEM(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8688C40", Offset = "0x8687A40", VA = "0x188688C40")]
		[CompilerGenerated]
		private void ZOMXNNMFFZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SMQTIOFQADW : XGOJTPBZDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LJJEWIWANYD YBPBAYGJIJF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string ICPOJMBRVOY;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> LLQZNYGPMXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int XAZZBTLCDQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string PLOGINBHRDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt XDOSRVAKYTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? ZKCWMLNNMDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string THJKKZMSXIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong XTLQBBDVBEW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KMTHAWDHBMR
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool TFUAGGFGPDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB856B0", Offset = "0xB844B0", VA = "0x180B856B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xEBEC40", Offset = "0xEBDA40", VA = "0x180EBEC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SBAGTJJUPBT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8689580", Offset = "0x8688380", VA = "0x188689580", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Dictionary<object, object> ZSFLUNPCDWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string ZQLXPWQXVIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8688FC0", Offset = "0x8687DC0", VA = "0x188688FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int VJUKBWXCLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8689610", Offset = "0x8688410", VA = "0x188689610", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8689660", Offset = "0x8688460", VA = "0x188689660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool QAPKXEKLFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6570", VA = "0x1819B7770", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x19B7760", Offset = "0x19B6560", VA = "0x1819B7760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool IZSFGSNCZAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x86894C0", Offset = "0x86882C0", VA = "0x1886894C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string OCRQWACOXWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86896D0", Offset = "0x86884D0", VA = "0x1886896D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string QQZFKEQPJWR
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8688F60", Offset = "0x8687D60", VA = "0x188688F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HWZDJDWALTY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public object WTWTDDQJRSS
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal ulong HUIPWJLJCCR
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8689820", Offset = "0x8688620", VA = "0x188689820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8689950", Offset = "0x8688750", VA = "0x188689950")]
		internal SMQTIOFQADW(LJJEWIWANYD a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8689990", Offset = "0x8688790", VA = "0x188689990")]
		internal SMQTIOFQADW(LJJEWIWANYD a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8689840", Offset = "0x8688640", VA = "0x188689840")]
		internal SMQTIOFQADW(LJJEWIWANYD a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8689770", Offset = "0x8688570", VA = "0x188689770", Slot = "16")]
		public bool WLMFTJNGHST(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86890B0", Offset = "0x8687EB0", VA = "0x1886890B0")]
		public NetworkedPlayerData KPQAMLJMRAJ()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x86891D0", Offset = "0x8687FD0", VA = "0x1886891D0")]
		internal void NQMNZELHDFP([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FJXNWXCPWTY : YBMGACIJTUK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LJJEWIWANYD YBPBAYGJIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> ENLHUFFTFWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, SMQTIOFQADW> KNXPVDZBGFI;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8683520", Offset = "0x8682320", VA = "0x188683520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public byte ROQRHDMODIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8682ED0", Offset = "0x8681CD0", VA = "0x188682ED0", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool CPHQWIZSECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Dictionary<object, object> ZSFLUNPCDWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public SMQTIOFQADW[] EBYZGALCSDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public SMQTIOFQADW[] BKUCDBSYCVX
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0CF0", Offset = "0xABFAF0", VA = "0x180AC0CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public SMQTIOFQADW[] OLHQMCKZNPR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public SMQTIOFQADW[] HISAYXSONDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int OOLCSDCUEYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8683790", Offset = "0x8682590", VA = "0x188683790")]
		public FJXNWXCPWTY(LJJEWIWANYD a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8682F20", Offset = "0x8681D20", VA = "0x188682F20", Slot = "9")]
		public bool IMQSRKQUZQM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86836E0", Offset = "0x86824E0", VA = "0x1886836E0", Slot = "8")]
		public bool WLMFTJNGHST(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8683370", Offset = "0x8682170", VA = "0x188683370")]
		internal bool LKWABCMVFET([In] NetworkedPlayerData playerData, bool a, [Out] SMQTIOFQADW b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8683550", Offset = "0x8682350", VA = "0x188683550")]
		internal void TJJREGLALRU(ulong a, [Out] SMQTIOFQADW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8682A90", Offset = "0x8681890", VA = "0x188682A90")]
		internal void ERPOJJATASD([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8682F80", Offset = "0x8681D80", VA = "0x188682F80")]
		private void LCJWAWMIQDE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TPMMOPEUORO : MZEEYWJGCTA, VJRNQPLOUBG, ZFKUZNNZKYM, WWHPPCVYRNM, NBRUWXWOQFS, EQXCCDYYMVL, JKLWLBPNAMF, TGPZRTTESHD, XXVGCWTLKYM, MCKPOGMFOBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private LJJEWIWANYD YBPBAYGJIJF;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int SFEDHOALWHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x868A0C0", Offset = "0x8688EC0", VA = "0x18868A0C0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int ZAVFUVNWISQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int HQNNTHXHLZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x868A850", Offset = "0x8689650", VA = "0x18868A850", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int MOIQMUZNHTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xE16F50", Offset = "0xE15D50", VA = "0x180E16F50", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool FWKTCXZJHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xE16AE0", Offset = "0xE158E0", VA = "0x180E16AE0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public double DIHMSZUWUBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8689FF0", Offset = "0x8688DF0", VA = "0x188689FF0", Slot = "35")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int XGARBZOEMRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x868ABF0", Offset = "0x86899F0", VA = "0x18868ABF0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool KFTIAJSNIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x250DBB0", Offset = "0x250C9B0", VA = "0x18250DBB0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool YEIEDVUFOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x868B3B0", Offset = "0x868A1B0", VA = "0x18868B3B0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool DRGQMQQAUXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x868B3B0", Offset = "0x868A1B0", VA = "0x18868B3B0", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool KFZBVYMRAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x868A8E0", Offset = "0x86896E0", VA = "0x18868A8E0", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x868B0F0", Offset = "0x8689EF0", VA = "0x18868B0F0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool XYPTCAMMRTK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x868A180", Offset = "0x8688F80", VA = "0x18868A180", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool QPWLCIFHQJV
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x868ACC0", Offset = "0x8689AC0", VA = "0x18868ACC0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object QEFOKQNLXYT
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public XGOJTPBZDNO BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8689EA0", Offset = "0x8688CA0", VA = "0x188689EA0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int XFMRSIFQDJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x868B630", Offset = "0x868A430", VA = "0x18868B630", Slot = "74")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int GPCXEIXJQQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x868AD60", Offset = "0x8689B60", VA = "0x18868AD60", Slot = "75")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public XGOJTPBZDNO EFVVCJCQKSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x868AE00", Offset = "0x8689C00", VA = "0x18868AE00", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x868A620", Offset = "0x8689420", VA = "0x18868A620", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int ROQRHDMODIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x868A120", Offset = "0x8688F20", VA = "0x18868A120", Slot = "78")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string ICPOJMBRVOY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x868A520", Offset = "0x8689320", VA = "0x18868A520", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Func<string, string> LLQZNYGPMXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x868B250", Offset = "0x868A050", VA = "0x18868B250", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public BAYKEAXSOXC WGQYKZXWXEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x868AC70", Offset = "0x8689A70", VA = "0x18868AC70", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool YTNBPNOSJHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x868A8D0", Offset = "0x86896D0", VA = "0x18868A8D0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x868AE70", Offset = "0x8689C70", VA = "0x18868AE70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override float CGQMQWECGFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE32F10", Offset = "0xE31D10", VA = "0x180E32F10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xE33850", Offset = "0xE32650", VA = "0x180E33850", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override IPMVOLERGYH JWWLKRPNCFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool WQRDYAPGRDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x868AD40", Offset = "0x8689B40", VA = "0x18868AD40", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x868A890", Offset = "0x8689690", VA = "0x18868A890", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string UUDQRAUXDKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x868B2A0", Offset = "0x868A0A0", VA = "0x18868B2A0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public long MVTDTYDMUAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x868AD50", Offset = "0x8689B50", VA = "0x18868AD50", Slot = "93")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public long XVNGITVOAIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x868AE90", Offset = "0x8689C90", VA = "0x18868AE90", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IPMVOLERGYH, IPMVOLERGYH> HWTGDJKCIJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x868A3B0", Offset = "0x86891B0", VA = "0x18868A3B0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8689ED0", Offset = "0x8688CD0", VA = "0x188689ED0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<EREVFMKOODS> KPHGKGPQPKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x868B430", Offset = "0x868A230", VA = "0x18868B430", Slot = "68")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8689D70", Offset = "0x8688B70", VA = "0x188689D70", Slot = "69")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<XGOJTPBZDNO> FDYUBXVVHBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x868A920", Offset = "0x8689720", VA = "0x18868A920", Slot = "71")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x868A470", Offset = "0x8689270", VA = "0x18868A470", Slot = "72")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x868A1C0", Offset = "0x8688FC0", VA = "0x18868A1C0")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void FDNTPBIGLET(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x868B730", Offset = "0x868A530", VA = "0x18868B730")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public TPMMOPEUORO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x868A900", Offset = "0x8689700", VA = "0x18868A900", Slot = "21")]
		public void JFXICGQVWSD(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x868B4E0", Offset = "0x868A2E0", VA = "0x18868B4E0", Slot = "23")]
		public void WKTEJEZQWEQ(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x868A9D0", Offset = "0x86897D0", VA = "0x18868A9D0", Slot = "27")]
		public void KJVYWOSJVXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x868AB20", Offset = "0x8689920", VA = "0x18868AB20", Slot = "56")]
		public bool LHWFTWLFLME(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x868A060", Offset = "0x8688E60", VA = "0x18868A060", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x868A090", Offset = "0x8688E90", VA = "0x18868A090", Slot = "55")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x868B220", Offset = "0x868A020", VA = "0x18868B220", Slot = "22")]
		public void TXWPTSKXGBT(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x868B540", Offset = "0x868A340", VA = "0x18868B540", Slot = "83")]
		public XGOJTPBZDNO YBLHDXQBZQW(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x868B1B0", Offset = "0x8689FB0", VA = "0x18868B1B0", Slot = "82")]
		public XGOJTPBZDNO TMCMSHIYMKY(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x868A740", Offset = "0x8689540", VA = "0x18868A740", Slot = "84")]
		public XGOJTPBZDNO HZDVDXSQUJG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x868B150", Offset = "0x8689F50", VA = "0x18868B150", Slot = "18")]
		public bool SDATCZPUNUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x868A240", Offset = "0x8689040", VA = "0x18868A240", Slot = "85")]
		public IReadOnlyList<XGOJTPBZDNO> FTKOFGOJVAY(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x868B6A0", Offset = "0x868A4A0", VA = "0x18868B6A0", Slot = "86")]
		public IReadOnlyList<XGOJTPBZDNO> YQTFVEVPURN(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x868AB70", Offset = "0x8689970", VA = "0x18868AB70", Slot = "54")]
		public bool MIIIXJFNYLT(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x868AB40", Offset = "0x8689940", VA = "0x18868AB40", Slot = "53")]
		public bool LeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x868A2D0", Offset = "0x86890D0", VA = "0x18868A2D0", Slot = "20")]
		public void FYJESVNTQKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x868B110", Offset = "0x8689F10", VA = "0x18868B110", Slot = "70")]
		public bool RaiseEvent(byte eventCode, object eventContent, QBWHSXSYUOT raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x868B410", Offset = "0x868A210", VA = "0x18868B410", Slot = "28")]
		public void VVUFAYMMXPR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x868AD20", Offset = "0x8689B20", VA = "0x18868AD20", Slot = "30")]
		public int NNQKMAKZPGT(EREVFMKOODS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "45")]
		public void DTIDZQVAYDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x868AEC0", Offset = "0x8689CC0", VA = "0x18868AEC0", Slot = "87")]
		public bool QNKIKGYQPDC(XGOJTPBZDNO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "34")]
		public void UAYISVEUPOS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8689E30", Offset = "0x8688C30", VA = "0x188689E30", Slot = "17")]
		public float ASUXFXOABOZ(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8689F90", Offset = "0x8688D90", VA = "0x188689F90", Slot = "8")]
		public override void CKTVASTCHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x868AFE0", Offset = "0x8689DE0", VA = "0x18868AFE0", Slot = "81")]
		public void RLXZEVYDQEG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x868A0C0", Offset = "0x8688EC0", VA = "0x18868A0C0", Slot = "95")]
		public int EEYLIGMBJQJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8689F80", Offset = "0x8688D80", VA = "0x188689F80", Slot = "11")]
		private void CEVPTRHYHGD(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x868B520", Offset = "0x868A320", VA = "0x18868B520", Slot = "12")]
		private void XIOEYAIIAVW(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x868B240", Offset = "0x868A040", VA = "0x18868B240", Slot = "25")]
		private void TYBVLUAJNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8689EC0", Offset = "0x8688CC0", VA = "0x188689EC0", Slot = "26")]
		private void AWUGXKEBZPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x868B690", Offset = "0x868A490", VA = "0x18868B690", Slot = "31")]
		private void YQBYRHFZTBK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x868A050", Offset = "0x8688E50", VA = "0x18868A050", Slot = "32")]
		private void DSSSIQEZHQL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x868A230", Offset = "0x8689030", VA = "0x18868A230", Slot = "57")]
		private void FKLUWRJGZGG(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8689E20", Offset = "0x8688C20", VA = "0x188689E20", Slot = "58")]
		private void ARLWTBRWILF(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x868B510", Offset = "0x868A310", VA = "0x18868B510", Slot = "59")]
		private void WSATYMRZQBB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x868A840", Offset = "0x8689640", VA = "0x18868A840", Slot = "60")]
		private void IIRJQJUURSY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x868AEA0", Offset = "0x8689CA0", VA = "0x18868AEA0", Slot = "61")]
		private void QCCTFADFVKC(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8689D60", Offset = "0x8688B60", VA = "0x188689D60", Slot = "62")]
		private IDisposable ADTQJVTLCRD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x868AD10", Offset = "0x8689B10", VA = "0x18868AD10", Slot = "63")]
		private bool NMGEYPYZEUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x868AB10", Offset = "0x8689910", VA = "0x18868AB10", Slot = "64")]
		private void LBFNUKKYEBK(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x868AEB0", Offset = "0x8689CB0", VA = "0x18868AEB0", Slot = "66")]
		private void QMMVVRPSZWA(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x868A3A0", Offset = "0x86891A0", VA = "0x18868A3A0", Slot = "67")]
		private void GFGSOVWGJMX(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x868A460", Offset = "0x8689260", VA = "0x18868A460", Slot = "88")]
		private void GRKQWVHXOVM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x868B530", Offset = "0x868A330", VA = "0x18868B530", Slot = "89")]
		private void XYZXZZOFLBH(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x868B140", Offset = "0x8689F40", VA = "0x18868B140", Slot = "90")]
		private void SAQZVEZMWJV()
		{
		}
	}
}
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NfgoCommsNetwork NGSZAKIQIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8682880", Offset = "0x8681680", VA = "0x188682880")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8682A40", Offset = "0x8681840", VA = "0x188682A40")]
		private void VXMJZCKGFMX(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8688E70", Offset = "0x8687C70", VA = "0x188688E70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DGQFWDENUAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool VTTJTEIGKOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NetworkManager PEONEXKOKMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NetworkManager KTFBLHXUECG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public INetworkManager TOAKNHGOPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NetworkManager, bool> VXMJZCKGFMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8682710", Offset = "0x8681510", VA = "0x188682710")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8682580", Offset = "0x8681380", VA = "0x188682580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86827C0", Offset = "0x86815C0", VA = "0x1886827C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public DGQFWDENUAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86826A0", Offset = "0x86814A0", VA = "0x1886826A0")]
		[FDNTPBIGLET.Root]
		public static void YCDIBWIIDME(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8682630", Offset = "0x8681430", VA = "0x188682630")]
		public void TPRAGAVLMXW(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TOAKNHGOPGD : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float FIMHQEQKQKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private CustomMessagingManager.HandleNamedMessageDelegate QENKZNHMESQ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8689AC0", Offset = "0x86888C0", VA = "0x188689AC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8689C10", Offset = "0x8688A10", VA = "0x188689C10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8689B70", Offset = "0x8688970", VA = "0x188689B70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8689CC0", Offset = "0x8688AC0", VA = "0x188689CC0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x86899D0", Offset = "0x86887D0", VA = "0x1886899D0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x86899D0", Offset = "0x86887D0", VA = "0x1886899D0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8689A50", Offset = "0x8688850", VA = "0x188689A50")]
		public TOAKNHGOPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x86899F0", Offset = "0x86887F0", VA = "0x1886899F0", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8689A10", Offset = "0x8688810", VA = "0x188689A10", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8689A30", Offset = "0x8688830", VA = "0x188689A30", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "21")]
		public void SendCustomMessage(NamedMessageType namedMessageType, ulong clientId, FastBufferWriter messageStream, NetworkDelivery networkDelivery)
		{
		}
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
