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
	public sealed class CNYGEAGZCLB : IDisposable, REYULGVCMLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public WOVAONPGCSF Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, WOVAONPGCSF receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E6E0", Offset = "0x2A8D4E0", VA = "0x182A8E6E0")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class ENLRZNVNQDQ : PFISPVVPEOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> IHCWSJRXHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> KENHRPWRITF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object ZENXFYCEGAS
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2A8E720", Offset = "0x2A8D520", VA = "0x182A8E720", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E7D0", Offset = "0x2A8D5D0", VA = "0x182A8E7D0")]
			public ENLRZNVNQDQ(XQQWUKBJKDN a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E770", Offset = "0x2A8D570", VA = "0x182A8E770", Slot = "9")]
			protected override bool QGBTRMNCGDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E7A0", Offset = "0x2A8D5A0", VA = "0x182A8E7A0")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string HGSJLXHDJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<FQTHCTXUYZW, CV2DynamicObject> UHYBFQEIHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<UACOCYSWUWU, ENLRZNVNQDQ> WRAERLVWUXM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<VCZWSUVCRXV> OOUJPTZLKJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xDFC820", Offset = "0xDFB620", VA = "0x180DFC820", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<VCZWSUVCRXV>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x16841A0", Offset = "0x1682FA0", VA = "0x1816841A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E5E0", Offset = "0x2A8D3E0", VA = "0x182A8E5E0")]
		public CNYGEAGZCLB(string a, Id32<VCZWSUVCRXV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D7D0", Offset = "0x2A8C5D0", VA = "0x182A8D7D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D830", Offset = "0x2A8C630", VA = "0x182A8D830")]
		public void FQWKDGRLAST(Id32<FQTHCTXUYZW> a, XIKUPAMMEQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E550", Offset = "0x2A8D350", VA = "0x182A8E550")]
		public Id32<FQTHCTXUYZW> ZNNMJZQMKHP(RRNetworkBehavior a)
		{
			return default(Id32<FQTHCTXUYZW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E430", Offset = "0x2A8D230", VA = "0x182A8E430")]
		public void XYYMOVLSEJZ(Id32<FQTHCTXUYZW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D910", Offset = "0x2A8C710", VA = "0x182A8D910", Slot = "6")]
		public void FRZLKGIDXMW(Id32<FQTHCTXUYZW> a, XIKUPAMMEQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DDC0", Offset = "0x2A8CBC0", VA = "0x182A8DDC0", Slot = "7")]
		public void VEQZMRGASRC(Id32<FQTHCTXUYZW> a, XIKUPAMMEQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DB20", Offset = "0x2A8C920", VA = "0x182A8DB20", Slot = "8")]
		public void IWTEJHXANSF(Id32<FQTHCTXUYZW> a, XIKUPAMMEQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DCB0", Offset = "0x2A8CAB0", VA = "0x182A8DCB0", Slot = "9")]
		public void QWPWOJNSTNC(Id32<FQTHCTXUYZW> a, XIKUPAMMEQL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E2E0", Offset = "0x2A8D0E0", VA = "0x182A8E2E0", Slot = "10")]
		public void WXFTJJLRMSK(Id32<FQTHCTXUYZW> a, Id32<VCZWSUVCRXV> b, XIKUPAMMEQL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E480", Offset = "0x2A8D280", VA = "0x182A8E480", Slot = "11")]
		public void XZOOGKETUTM(Id32<FQTHCTXUYZW> a, WOVAONPGCSF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAA0", Offset = "0x2A8C8A0", VA = "0x182A8DAA0", Slot = "12")]
		public Id32<VCZWSUVCRXV> IWADKNKYAZT(Id32<FQTHCTXUYZW> a)
		{
			return default(Id32<VCZWSUVCRXV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DF70", Offset = "0x2A8CD70", VA = "0x182A8DF70", Slot = "13")]
		public Id32<UACOCYSWUWU> VHZYYHWVFDV(Id32<FQTHCTXUYZW> a, string b, object c, bool d, OYGAHFARWRG e, HVXPYDFAQPW f)
		{
			return default(Id32<UACOCYSWUWU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA20", Offset = "0x2A8C820", VA = "0x182A8DA20", Slot = "14")]
		public void IFCKZSGTMUJ(Id32<UACOCYSWUWU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC30", Offset = "0x2A8CA30", VA = "0x182A8DC30", Slot = "15")]
		public void KLMEHFZVJBP(Id32<UACOCYSWUWU> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class ZRXRXYPQPZV : SVBMWMSSDIU
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : ELLZGADELWZ.FMDFQZYEHTU<ELPAQFNEADX, ZRXRXYPQPZV>
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
				public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public ZRXRXYPQPZV root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public ELPAQFNEADX action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F150", Offset = "0x2A8DF50", VA = "0x182A8F150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2A8F5A0", Offset = "0x2A8E3A0", VA = "0x182A8F5A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EAC0", Offset = "0x2A8D8C0", VA = "0x182A8EAC0", Slot = "4")]
			public int DMTTQFWTEDG(ZRXRXYPQPZV a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCB6160", Offset = "0xCB4F60", VA = "0x180CB6160", Slot = "5")]
			public int ASUODZTOWAE(ZRXRXYPQPZV a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EB90", Offset = "0x2A8D990", VA = "0x182A8EB90", Slot = "6")]
			public int XHSTINAOAPN(ZRXRXYPQPZV a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10E5610", Offset = "0x10E4410", VA = "0x1810E5610", Slot = "7")]
			public int EMFCDWYYTLV(ZRXRXYPQPZV a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EBB0", Offset = "0x2A8D9B0", VA = "0x182A8EBB0", Slot = "8")]
			public void XZZWNENXRDU(ZRXRXYPQPZV a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			public bool HWNLDEIWMBF(ZRXRXYPQPZV a, Id32<VCZWSUVCRXV> b, ELPAQFNEADX[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E8B0", Offset = "0x2A8D6B0", VA = "0x182A8E8B0", Slot = "10")]
			public bool BTQNSYLBMWR(ZRXRXYPQPZV a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E980", Offset = "0x2A8D780", VA = "0x182A8E980", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SJKUUBAWOPB>> CMMOBWCVPLD(ZRXRXYPQPZV a, Id32<VCZWSUVCRXV> b, ELPAQFNEADX c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : ELLZGADELWZ.YUERGOQQINL<ActionDeps, RGZHVGRSJVI.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps SVNCPQCMXVR
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public RGZHVGRSJVI.StaticNetSysReceiverDeps NNWJILXMSXW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "5")]
				get
				{
					return default(RGZHVGRSJVI.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps FJBEGZAIDYN
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface XQEIROEEFNO
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int OPFEYAEZCTM
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool UPNFUZFODKR
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string QHVFYQAGFHX
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool BTQNSYLBMWR(int a);
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
			public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ZRXRXYPQPZV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public RGZHVGRSJVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<VCZWSUVCRXV> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ELPAQFNEADX action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EC10", Offset = "0x2A8DA10", VA = "0x182A8EC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EE40", Offset = "0x2A8DC40", VA = "0x182A8EE40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SJKUUBAWOPB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ZRXRXYPQPZV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ELPAQFNEADX action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, SJKUUBAWOPB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EEB0", Offset = "0x2A8DCB0", VA = "0x182A8EEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F0E0", Offset = "0x2A8DEE0", VA = "0x182A8F0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private EVHQYCJXJQV<ELPAQFNEADX, None, RGZHVGRSJVI, ActionDeps, RGZHVGRSJVI.StaticNetSysReceiverDeps, RootDeps, ZRXRXYPQPZV, Deps> CWEPRURLXRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int DQSQZFNICTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int PYODSOBRKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int VXGMBGSDPRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly IJHCLIKQXBZ<ELPAQFNEADX, Result<object, SJKUUBAWOPB>> HSQUQFPPFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly IJHCLIKQXBZ<ELPAQFNEADX, Result<object, SJKUUBAWOPB>> HZMMKGMOCIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly XQEIROEEFNO RHEDUJJJYXY;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NPDESZMDTYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F780", Offset = "0x2A8E580", VA = "0x182A8F780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ZMFWJCJVIIV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F740", Offset = "0x2A8E540", VA = "0x182A8F740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int FLJLRCVOAWI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F800", Offset = "0x2A8E600", VA = "0x182A8F800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BOYNFYWSSBD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F7C0", Offset = "0x2A8E5C0", VA = "0x182A8F7C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F990", Offset = "0x2A8E790", VA = "0x182A8F990")]
		public ZRXRXYPQPZV(int a, int b, int c, IJHCLIKQXBZ<ELPAQFNEADX, Result<object, SJKUUBAWOPB>> d, IJHCLIKQXBZ<ELPAQFNEADX, Result<object, SJKUUBAWOPB>> e, XQEIROEEFNO f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F840", Offset = "0x2A8E640", VA = "0x182A8F840")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, SJKUUBAWOPB>> VEKDJDGRJDM(RGZHVGRSJVI a, Id32<VCZWSUVCRXV> b, ELPAQFNEADX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F610", Offset = "0x2A8E410", VA = "0x182A8F610", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, SJKUUBAWOPB>> CMMOBWCVPLD(ELPAQFNEADX a, bool b)
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
