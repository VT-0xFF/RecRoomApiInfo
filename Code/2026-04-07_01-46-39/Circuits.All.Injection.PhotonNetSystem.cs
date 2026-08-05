using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.All.RecRoom;
using Circuits.All.RecRoom.Injection;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.Protobuf;
using CircuitsV2.Dependencies;
using CircuitsV2.DynamicNetSystem;
using CircuitsV2.Lang.Memory;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using RecRoom.Networking;
using RecRoom.Networking.CreationOps;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.All.Injection.PhotonNetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public sealed class KZLWZQWYYEO : IDisposable, BAULKDCDPAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public SYXGFCHGOJQ Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, SYXGFCHGOJQ receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2770", Offset = "0x2AF1770", VA = "0x182AF2770")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class SNPXHUXWQJD : SAFTBJAXEWQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> SHBSUGPEJCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> JZWZUFZABOQ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object KDUWUASGBUN
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF3A00", Offset = "0x2AF2A00", VA = "0x182AF3A00", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3AB0", Offset = "0x2AF2AB0", VA = "0x182AF3AB0")]
			public SNPXHUXWQJD(CFJGLFDIMUU a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3A80", Offset = "0x2AF2A80", VA = "0x182AF3A80", Slot = "9")]
			protected override bool WQFHMYPPRKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3A50", Offset = "0x2AF2A50", VA = "0x182AF3A50")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string QWNLCEWPQKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<ZKEUEWDMUHX, CV2DynamicObject> XJIKIYCBEER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<KEPQSWAPNBZ, SNPXHUXWQJD> KPEVRNZXLZD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<WNPWZNYIVVQ> EYHHRNOAXBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD92F00", Offset = "0xD91F00", VA = "0x180D92F00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WNPWZNYIVVQ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1644920", Offset = "0x1643920", VA = "0x181644920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF35B0", Offset = "0x2AF25B0", VA = "0x182AF35B0")]
		public KZLWZQWYYEO(string a, Id32<WNPWZNYIVVQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2940", Offset = "0x2AF1940", VA = "0x182AF2940", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3320", Offset = "0x2AF2320", VA = "0x182AF3320")]
		public void ZCRIRUPPHLE(Id32<ZKEUEWDMUHX> a, BQTXGPOIMTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3290", Offset = "0x2AF2290", VA = "0x182AF3290")]
		public Id32<ZKEUEWDMUHX> YYSIJTPJHQU(RRNetworkBehavior a)
		{
			return default(Id32<ZKEUEWDMUHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2AF0", Offset = "0x2AF1AF0", VA = "0x182AF2AF0")]
		public void FPFRACUEJVO(Id32<ZKEUEWDMUHX> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF27B0", Offset = "0x2AF17B0", VA = "0x182AF27B0", Slot = "6")]
		public void BYINADOXFPF(Id32<ZKEUEWDMUHX> a, BQTXGPOIMTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3400", Offset = "0x2AF2400", VA = "0x182AF3400", Slot = "7")]
		public void ZFOCAKHOJKR(Id32<ZKEUEWDMUHX> a, BQTXGPOIMTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3180", Offset = "0x2AF2180", VA = "0x182AF3180", Slot = "8")]
		public void XMFKDHFPFRU(Id32<ZKEUEWDMUHX> a, BQTXGPOIMTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3070", Offset = "0x2AF2070", VA = "0x182AF3070", Slot = "9")]
		public void QLWRATPKEGL(Id32<ZKEUEWDMUHX> a, BQTXGPOIMTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF29A0", Offset = "0x2AF19A0", VA = "0x182AF29A0", Slot = "10")]
		public void EFHHZCRZOQR(Id32<ZKEUEWDMUHX> a, Id32<WNPWZNYIVVQ> b, BQTXGPOIMTK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2B40", Offset = "0x2AF1B40", VA = "0x182AF2B40", Slot = "11")]
		public void JBCDOXHVXTR(Id32<ZKEUEWDMUHX> a, SYXGFCHGOJQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2FF0", Offset = "0x2AF1FF0", VA = "0x182AF2FF0", Slot = "12")]
		public Id32<WNPWZNYIVVQ> QDUQRSNZFBW(Id32<ZKEUEWDMUHX> a)
		{
			return default(Id32<WNPWZNYIVVQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C90", Offset = "0x2AF1C90", VA = "0x182AF2C90", Slot = "13")]
		public Id32<KEPQSWAPNBZ> OGFHGXXLWSE(Id32<ZKEUEWDMUHX> a, string b, object c, bool d, XWRQSPGOEYJ e, WCVMITZTDDZ f)
		{
			return default(Id32<KEPQSWAPNBZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF28C0", Offset = "0x2AF18C0", VA = "0x182AF28C0", Slot = "14")]
		public void DFYMZBTYXYA(Id32<KEPQSWAPNBZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C10", Offset = "0x2AF1C10", VA = "0x182AF2C10", Slot = "15")]
		public void JDDYQCYFYMK(Id32<KEPQSWAPNBZ> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UAOQECTEECW : SWFQECRPDPB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : DZRBQUPXGSQ.RHUCFMBNWHH<PYPEGOPZPPS, UAOQECTEECW>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000010")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public UAOQECTEECW root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public PYPEGOPZPPS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2AF40D0", Offset = "0x2AF30D0", VA = "0x182AF40D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF4510", Offset = "0x2AF3510", VA = "0x182AF4510", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3710", Offset = "0x2AF2710", VA = "0x182AF3710", Slot = "4")]
			public int FDEGIOXLPFX(UAOQECTEECW a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1529E50", Offset = "0x1528E50", VA = "0x181529E50", Slot = "5")]
			public int DTRKSXRBFJR(UAOQECTEECW a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF38A0", Offset = "0x2AF28A0", VA = "0x182AF38A0", Slot = "6")]
			public int PEULEIYOSKA(UAOQECTEECW a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x108B120", Offset = "0x108A120", VA = "0x18108B120", Slot = "7")]
			public int GTFDDLUNWDO(UAOQECTEECW a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF36B0", Offset = "0x2AF26B0", VA = "0x182AF36B0", Slot = "8")]
			public void ANMNTYRHGPB(UAOQECTEECW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "9")]
			public bool RTRMJRKTARW(UAOQECTEECW a, Id32<WNPWZNYIVVQ> b, PYPEGOPZPPS[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AF37D0", Offset = "0x2AF27D0", VA = "0x182AF37D0", Slot = "10")]
			public bool GCLNRUDHTPE(UAOQECTEECW a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AF38C0", Offset = "0x2AF28C0", VA = "0x182AF38C0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(UAOQECTEECW a, Id32<WNPWZNYIVVQ> b, PYPEGOPZPPS c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : DZRBQUPXGSQ.IULAIVKNAGW<ActionDeps, COWOBFPVIKZ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps EYKBEKPNGJQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public COWOBFPVIKZ.StaticNetSysReceiverDeps NZQKMTVCVBT
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "5")]
				get
				{
					return default(COWOBFPVIKZ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps YJDSXHZAHFO
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface UYPXTMTCQYP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int CZTUQTPJYFX
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool LPGNWQUSNFE
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string AYASJLRPVWY
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool GCLNRUDHTPE(int a);
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <ReceiveAction>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public UAOQECTEECW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public COWOBFPVIKZ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PYPEGOPZPPS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3B90", Offset = "0x2AF2B90", VA = "0x182AF3B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3DC0", Offset = "0x2AF2DC0", VA = "0x182AF3DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public UAOQECTEECW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PYPEGOPZPPS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3E30", Offset = "0x2AF2E30", VA = "0x182AF3E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4060", Offset = "0x2AF3060", VA = "0x182AF4060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private RHGHGLLFFEI<PYPEGOPZPPS, None, COWOBFPVIKZ, ActionDeps, COWOBFPVIKZ.StaticNetSysReceiverDeps, RootDeps, UAOQECTEECW, Deps> PYYABSCVHMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int MIZYPITKHYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int XZYWIIUBXZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int KNLKXBVPRCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly SVFQTGNILYE<PYPEGOPZPPS, Result<object, MCRZZCNKUJE>> RKETQTINIHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly SVFQTGNILYE<PYPEGOPZPPS, Result<object, MCRZZCNKUJE>> ETQGXJLWRUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly UYPXTMTCQYP BIQCNNIQICF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FROWRYXZPZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4580", Offset = "0x2AF3580", VA = "0x182AF4580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int QSUYSQEVIAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF48C0", Offset = "0x2AF38C0", VA = "0x182AF48C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ZYXUKLPEXQV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4600", Offset = "0x2AF3600", VA = "0x182AF4600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int QAUQITNIJQE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF45C0", Offset = "0x2AF35C0", VA = "0x182AF45C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4900", Offset = "0x2AF3900", VA = "0x182AF4900")]
		public UAOQECTEECW(int a, int b, int c, SVFQTGNILYE<PYPEGOPZPPS, Result<object, MCRZZCNKUJE>> d, SVFQTGNILYE<PYPEGOPZPPS, Result<object, MCRZZCNKUJE>> e, UYPXTMTCQYP f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4770", Offset = "0x2AF3770", VA = "0x182AF4770")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, MCRZZCNKUJE>> VCNDPOOUIXD(COWOBFPVIKZ a, Id32<WNPWZNYIVVQ> b, PYPEGOPZPPS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4640", Offset = "0x2AF3640", VA = "0x182AF4640", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(PYPEGOPZPPS a, bool b)
		{
			return null;
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
