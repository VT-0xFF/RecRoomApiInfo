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
			[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, VJPPLTLUTFR receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B26DD0", Offset = "0x2B257D0", VA = "0x182B26DD0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2B281C0", Offset = "0x2B26BC0", VA = "0x182B281C0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B28240", Offset = "0x2B26C40", VA = "0x182B28240")]
			public QBJEDGXNDSI(SABLHYKIBLD a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B28190", Offset = "0x2B26B90", VA = "0x182B28190", Slot = "9")]
			protected override bool BTXDAICSWIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2B28210", Offset = "0x2B26C10", VA = "0x182B28210")]
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
			[Cpp2IlInjected.Address(RVA = "0xDAA0E0", Offset = "0xDA8AE0", VA = "0x180DAA0E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QOLQCAXXJSV>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x166CE80", Offset = "0x166B880", VA = "0x18166CE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B27C20", Offset = "0x2B26620", VA = "0x182B27C20")]
		public ECNOLZNNRMJ(string a, Id32<QOLQCAXXJSV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E10", Offset = "0x2B25810", VA = "0x182B26E10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B273C0", Offset = "0x2B25DC0", VA = "0x182B273C0")]
		public void LLCEZHBXDUR(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B27A80", Offset = "0x2B26480", VA = "0x182B27A80")]
		public Id32<KXSFMFRUWWC> ZBVJWZPVWHZ(RRNetworkBehavior a)
		{
			return default(Id32<KXSFMFRUWWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E70", Offset = "0x2B25870", VA = "0x182B26E70")]
		public void GNKQCEMWZZT(Id32<KXSFMFRUWWC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B272B0", Offset = "0x2B25CB0", VA = "0x182B272B0", Slot = "6")]
		public void KQXYXULFOVC(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B27850", Offset = "0x2B26250", VA = "0x182B27850", Slot = "7")]
		public void XXMFVZJQNPM(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B274A0", Offset = "0x2B25EA0", VA = "0x182B274A0", Slot = "8")]
		public void RJCLTCXTDMX(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B27B10", Offset = "0x2B26510", VA = "0x182B27B10", Slot = "9")]
		public void ZNDLLTQLNZM(Id32<KXSFMFRUWWC> a, BEONJKLMCWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B27630", Offset = "0x2B26030", VA = "0x182B27630", Slot = "10")]
		public void SQTNMTCQIDC(Id32<KXSFMFRUWWC> a, Id32<QOLQCAXXJSV> b, BEONJKLMCWR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B27780", Offset = "0x2B26180", VA = "0x182B27780", Slot = "11")]
		public void XAELVQEHYMI(Id32<KXSFMFRUWWC> a, VJPPLTLUTFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B27A00", Offset = "0x2B26400", VA = "0x182B27A00", Slot = "12")]
		public Id32<QOLQCAXXJSV> YHRZAFEFSDN(Id32<KXSFMFRUWWC> a)
		{
			return default(Id32<QOLQCAXXJSV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B26F40", Offset = "0x2B25940", VA = "0x182B26F40", Slot = "13")]
		public Id32<GAVLBTBZLWC> JZGONJCZZPL(Id32<KXSFMFRUWWC> a, string b, object c, bool d, ULTBGYHPOHE e, JAUKFLYXGQW f)
		{
			return default(Id32<GAVLBTBZLWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B275B0", Offset = "0x2B25FB0", VA = "0x182B275B0", Slot = "14")]
		public void RWDRTNORWZR(Id32<GAVLBTBZLWC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B26EC0", Offset = "0x2B258C0", VA = "0x182B26EC0", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x2B28BC0", Offset = "0x2B275C0", VA = "0x182B28BC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B29000", Offset = "0x2B27A00", VA = "0x182B29000", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B28320", Offset = "0x2B26D20", VA = "0x182B28320", Slot = "4")]
			public int AMZRAALQQCS(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1562780", Offset = "0x1561180", VA = "0x181562780", Slot = "5")]
			public int WOYOVDRSFGG(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B28660", Offset = "0x2B27060", VA = "0x182B28660", Slot = "6")]
			public int RZUZNWBZXRT(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10A59D0", Offset = "0x10A43D0", VA = "0x1810A59D0", Slot = "7")]
			public int CMWKWEPXYAF(ENVTHGQGRSN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B28600", Offset = "0x2B27000", VA = "0x182B28600", Slot = "8")]
			public void PZDVVTGVBBS(ENVTHGQGRSN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "9")]
			public bool HTAFTXVFYIF(ENVTHGQGRSN a, Id32<QOLQCAXXJSV> b, JGWKKBUFZYH[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B283F0", Offset = "0x2B26DF0", VA = "0x182B283F0", Slot = "10")]
			public bool JJICXKGUYEX(ENVTHGQGRSN a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2B284C0", Offset = "0x2B26EC0", VA = "0x182B284C0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public LLXPXHNGEHC.StaticNetSysReceiverDeps DULRKHWZBMG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "5")]
				get
				{
					return default(LLXPXHNGEHC.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps ABHRITSRZDR
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B28680", Offset = "0x2B27080", VA = "0x182B28680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2B288B0", Offset = "0x2B272B0", VA = "0x182B288B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B28920", Offset = "0x2B27320", VA = "0x182B28920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2B28B50", Offset = "0x2B27550", VA = "0x182B28B50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B28060", Offset = "0x2B26A60", VA = "0x182B28060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AMJJOVLYDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B28020", Offset = "0x2B26A20", VA = "0x182B28020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int VOYAXXEHLVI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B27E70", Offset = "0x2B26870", VA = "0x182B27E70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int RHOTTVGVXNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B27FE0", Offset = "0x2B269E0", VA = "0x182B27FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B280A0", Offset = "0x2B26AA0", VA = "0x182B280A0")]
		public ENVTHGQGRSN(int a, int b, int c, TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> d, TBJGERXGLVD<JGWKKBUFZYH, Result<object, KXUOEYSOWHL>> e, VAEKADQIRNQ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B27D20", Offset = "0x2B26720", VA = "0x182B27D20")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, KXUOEYSOWHL>> DLYYCINMCJS(LLXPXHNGEHC a, Id32<QOLQCAXXJSV> b, JGWKKBUFZYH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B27EB0", Offset = "0x2B268B0", VA = "0x182B27EB0", Slot = "4")]
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
