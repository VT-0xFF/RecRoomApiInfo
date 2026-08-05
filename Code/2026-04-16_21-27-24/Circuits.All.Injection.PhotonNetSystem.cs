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
	public sealed class ECNOLZNNRMJ : IDisposable, QJXQIKIKVWS
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public VJPPLTLUTFR Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, VJPPLTLUTFR receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8F90", Offset = "0x2AE7D90", VA = "0x182AE8F90")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class QBJEDGXNDSI : DSZGRWEPSDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> WCYSCHRYJJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> RAVRTUPAHPX;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object ZSUBFNTLSZS
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AEA370", Offset = "0x2AE9170", VA = "0x182AEA370", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA3F0", Offset = "0x2AE91F0", VA = "0x182AEA3F0")]
			public QBJEDGXNDSI(SABLHYKIBLD a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA340", Offset = "0x2AE9140", VA = "0x182AEA340", Slot = "9")]
			protected override bool BTXDAICSWIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA3C0", Offset = "0x2AE91C0", VA = "0x182AEA3C0")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string EYGXMNDHKPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<KXSFMFRUWWC, CV2DynamicObject> AJXONREMRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<GAVLBTBZLWC, QBJEDGXNDSI> OXCPNJQONWQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<QOLQCAXXJSV> RUKDXKNBBVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD7FE30", Offset = "0xD7EC30", VA = "0x180D7FE30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QOLQCAXXJSV>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1636950", Offset = "0x1635750", VA = "0x181636950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9DD0", Offset = "0x2AE8BD0", VA = "0x182AE9DD0")]
		public ECNOLZNNRMJ(string a, Id32<QOLQCAXXJSV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8FD0", Offset = "0x2AE7DD0", VA = "0x182AE8FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9570", Offset = "0x2AE8370", VA = "0x182AE9570")]
		public void LLCEZHBXDUR(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9C30", Offset = "0x2AE8A30", VA = "0x182AE9C30")]
		public Id32<KXSFMFRUWWC> ZBVJWZPVWHZ(RRNetworkBehavior a)
		{
			return default(Id32<KXSFMFRUWWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9030", Offset = "0x2AE7E30", VA = "0x182AE9030")]
		public void GNKQCEMWZZT(Id32<KXSFMFRUWWC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9460", Offset = "0x2AE8260", VA = "0x182AE9460", Slot = "6")]
		public void KQXYXULFOVC(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9A00", Offset = "0x2AE8800", VA = "0x182AE9A00", Slot = "7")]
		public void XXMFVZJQNPM(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9650", Offset = "0x2AE8450", VA = "0x182AE9650", Slot = "8")]
		public void RJCLTCXTDMX(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9CC0", Offset = "0x2AE8AC0", VA = "0x182AE9CC0", Slot = "9")]
		public void ZNDLLTQLNZM(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AE97E0", Offset = "0x2AE85E0", VA = "0x182AE97E0", Slot = "10")]
		public void SQTNMTCQIDC(Id32<KXSFMFRUWWC> a, Id32<QOLQCAXXJSV> b, BEONJKLMCWR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9930", Offset = "0x2AE8730", VA = "0x182AE9930", Slot = "11")]
		public void XAELVQEHYMI(Id32<KXSFMFRUWWC> a, VJPPLTLUTFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9BB0", Offset = "0x2AE89B0", VA = "0x182AE9BB0", Slot = "12")]
		public Id32<QOLQCAXXJSV> YHRZAFEFSDN(Id32<KXSFMFRUWWC> a)
		{
			return default(Id32<QOLQCAXXJSV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9100", Offset = "0x2AE7F00", VA = "0x182AE9100", Slot = "13")]
		public Id32<GAVLBTBZLWC> JZGONJCZZPL(Id32<KXSFMFRUWWC> a, string b, object c, bool d, ULTBGYHPOHE e, JAUKFLYXGQW f)
		{
			return default(Id32<GAVLBTBZLWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9760", Offset = "0x2AE8560", VA = "0x182AE9760", Slot = "14")]
		public void RWDRTNORWZR(Id32<GAVLBTBZLWC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9080", Offset = "0x2AE7E80", VA = "0x182AE9080", Slot = "15")]
		public void GRKOXTHEBXB(Id32<GAVLBTBZLWC> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class ENVTHGQGRSN : KVHMMDKOSSW
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : CACFZSSVVJB.QHUWUHZIAAI<JGWKKBUFZYH, ENVTHGQGRSN>
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
				public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public ENVTHGQGRSN root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public JGWKKBUFZYH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2AEAD60", Offset = "0x2AE9B60", VA = "0x182AEAD60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AEB1A0", Offset = "0x2AE9FA0", VA = "0x182AEB1A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA4D0", Offset = "0x2AE92D0", VA = "0x182AEA4D0", Slot = "4")]
			public int AMZRAALQQCS(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x151A880", Offset = "0x1519680", VA = "0x18151A880", Slot = "5")]
			public int WOYOVDRSFGG(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA800", Offset = "0x2AE9600", VA = "0x182AEA800", Slot = "6")]
			public int RZUZNWBZXRT(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x107D290", Offset = "0x107C090", VA = "0x18107D290", Slot = "7")]
			public int CMWKWEPXYAF(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA7A0", Offset = "0x2AE95A0", VA = "0x182AEA7A0", Slot = "8")]
			public void PZDVVTGVBBS(ENVTHGQGRSN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "9")]
			public bool HTAFTXVFYIF(ENVTHGQGRSN a, Id32<QOLQCAXXJSV> b, JGWKKBUFZYH[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA590", Offset = "0x2AE9390", VA = "0x182AEA590", Slot = "10")]
			public bool JJICXKGUYEX(ENVTHGQGRSN a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA660", Offset = "0x2AE9460", VA = "0x182AEA660", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(ENVTHGQGRSN a, Id32<QOLQCAXXJSV> b, JGWKKBUFZYH c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : CACFZSSVVJB.EXOUKTTMMZJ<ActionDeps, LLXPXHNGEHC.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps TSKMQTSYGXD
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public LLXPXHNGEHC.StaticNetSysReceiverDeps DULRKHWZBMG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "5")]
				get
				{
					return default(LLXPXHNGEHC.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps ABHRITSRZDR
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface VAEKADQIRNQ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int WOEHPBBWMCI
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool BHNEWGHPYBB
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string DBAGCKYMLLN
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool JJICXKGUYEX(int a);
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
			public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ENVTHGQGRSN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LLXPXHNGEHC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<QOLQCAXXJSV> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA820", Offset = "0x2AE9620", VA = "0x182AEA820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AEAA50", Offset = "0x2AE9850", VA = "0x182AEAA50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ENVTHGQGRSN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2AEAAC0", Offset = "0x2AE98C0", VA = "0x182AEAAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AEACF0", Offset = "0x2AE9AF0", VA = "0x182AEACF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private EQMPTCYXFUT<JGWKKBUFZYH, None, LLXPXHNGEHC, ActionDeps, LLXPXHNGEHC.StaticNetSysReceiverDeps, RootDeps, ENVTHGQGRSN, Deps> SWAVKVRSZMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int UMWYLYWFPVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int XKYDOWNEBWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int VHAVGYFFIXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> CVWDLXDGDGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> QETWWVQMFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly VAEKADQIRNQ BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PPEXLZCTGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA210", Offset = "0x2AE9010", VA = "0x182AEA210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AMJJOVLYDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA1D0", Offset = "0x2AE8FD0", VA = "0x182AEA1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int VOYAXXEHLVI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA020", Offset = "0x2AE8E20", VA = "0x182AEA020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int RHOTTVGVXNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AEA190", Offset = "0x2AE8F90", VA = "0x182AEA190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA250", Offset = "0x2AE9050", VA = "0x182AEA250")]
		public ENVTHGQGRSN(int a, int b, int c, TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> d, TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> e, VAEKADQIRNQ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9ED0", Offset = "0x2AE8CD0", VA = "0x182AE9ED0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, KXUOEYSOWHL>> DLYYCINMCJS(LLXPXHNGEHC a, Id32<QOLQCAXXJSV> b, JGWKKBUFZYH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA060", Offset = "0x2AE8E60", VA = "0x182AEA060", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(JGWKKBUFZYH a, bool b)
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
