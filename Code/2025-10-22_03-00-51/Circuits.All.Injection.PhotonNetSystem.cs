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
	public sealed class RAXRRIFRUXW : IDisposable, BPLYXASFEBT
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public NTHATILQXOY Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, NTHATILQXOY receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A79A70", Offset = "0x2A78070", VA = "0x182A79A70")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class FQJBKTTQBRB : HCJBDWJWEHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> EOWQXRNTRYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> UZVHLVOWSLQ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object VYANXXDWHSL
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2A79AB0", Offset = "0x2A780B0", VA = "0x182A79AB0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2A79B60", Offset = "0x2A78160", VA = "0x182A79B60")]
			public FQJBKTTQBRB(UXWMPOTYTVA a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A79B00", Offset = "0x2A78100", VA = "0x182A79B00", Slot = "9")]
			protected override bool RNRFTTRIHIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2A79B30", Offset = "0x2A78130", VA = "0x182A79B30")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string ALVLBILORXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<VFXBTZQLZOD, CV2DynamicObject> WGVGVUUVDNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<FDFCSQHAOQZ, FQJBKTTQBRB> OROGWWDPMHJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<CYNSIGMASWI> YWMWMQAZOSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xE02150", Offset = "0xE00750", VA = "0x180E02150", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CYNSIGMASWI>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x16813E0", Offset = "0x167F9E0", VA = "0x1816813E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AEB0", Offset = "0x2A794B0", VA = "0x182A7AEB0")]
		public RAXRRIFRUXW(string a, Id32<CYNSIGMASWI> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A520", Offset = "0x2A78B20", VA = "0x182A7A520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AB10", Offset = "0x2A79110", VA = "0x182A7AB10")]
		public void UORZRGPYECA(Id32<VFXBTZQLZOD> a, VAKNOBNOFZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A410", Offset = "0x2A78A10", VA = "0x182A7A410")]
		public Id32<VFXBTZQLZOD> DGGUSDOWYQK(RRNetworkBehavior a)
		{
			return default(Id32<VFXBTZQLZOD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A7AAC0", Offset = "0x2A790C0", VA = "0x182A7AAC0")]
		public void TXAXDXUOCSO(Id32<VFXBTZQLZOD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A7ADA0", Offset = "0x2A793A0", VA = "0x182A7ADA0", Slot = "6")]
		public void XUYZJIAWPUV(Id32<VFXBTZQLZOD> a, VAKNOBNOFZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A7ABF0", Offset = "0x2A791F0", VA = "0x182A7ABF0", Slot = "7")]
		public void WLKFXURVFSL(Id32<VFXBTZQLZOD> a, VAKNOBNOFZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A6D0", Offset = "0x2A78CD0", VA = "0x182A7A6D0", Slot = "8")]
		public void LQHBXWKSBOQ(Id32<VFXBTZQLZOD> a, VAKNOBNOFZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A860", Offset = "0x2A78E60", VA = "0x182A7A860", Slot = "9")]
		public void MRXVYOAXJJT(Id32<VFXBTZQLZOD> a, VAKNOBNOFZU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A970", Offset = "0x2A78F70", VA = "0x182A7A970", Slot = "10")]
		public void SLAQZMJJDLJ(Id32<VFXBTZQLZOD> a, Id32<CYNSIGMASWI> b, VAKNOBNOFZU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A600", Offset = "0x2A78C00", VA = "0x182A7A600", Slot = "11")]
		public void JRUXEVRDPHH(Id32<VFXBTZQLZOD> a, NTHATILQXOY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A4A0", Offset = "0x2A78AA0", VA = "0x182A7A4A0", Slot = "12")]
		public Id32<CYNSIGMASWI> DTPRYTGELEO(Id32<VFXBTZQLZOD> a)
		{
			return default(Id32<CYNSIGMASWI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A0B0", Offset = "0x2A786B0", VA = "0x182A7A0B0", Slot = "13")]
		public Id32<FDFCSQHAOQZ> CVWPAUHIXGG(Id32<VFXBTZQLZOD> a, string b, object c, bool d, QLZWKPYXAEL e, HAJHCLIAJAB f)
		{
			return default(Id32<FDFCSQHAOQZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A7E0", Offset = "0x2A78DE0", VA = "0x182A7A7E0", Slot = "14")]
		public void MDKRCKWDWSK(Id32<FDFCSQHAOQZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A580", Offset = "0x2A78B80", VA = "0x182A7A580", Slot = "15")]
		public void JBWIYMPGMQY(Id32<FDFCSQHAOQZ> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class POHHIRYJWSY : MPBKAGBRDNH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : ZHESUVALAPM.IDSLKDTIAJN<LOHJEAGYXDY, POHHIRYJWSY>
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
				public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public POHHIRYJWSY root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public LOHJEAGYXDY action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2A7B840", Offset = "0x2A79E40", VA = "0x182A7B840", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2A7BC80", Offset = "0x2A7A280", VA = "0x182A7BC80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B0F0", Offset = "0x2A796F0", VA = "0x182A7B0F0", Slot = "4")]
			public int EZRVIQTMGMP(POHHIRYJWSY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCB3EB0", Offset = "0xCB24B0", VA = "0x180CB3EB0", Slot = "5")]
			public int AOTCMPGPJCJ(POHHIRYJWSY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B210", Offset = "0x2A79810", VA = "0x182A7B210", Slot = "6")]
			public int UFYLWAPWHZU(POHHIRYJWSY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10E96E0", Offset = "0x10E7CE0", VA = "0x1810E96E0", Slot = "7")]
			public int WOMENCSEJCK(POHHIRYJWSY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B1B0", Offset = "0x2A797B0", VA = "0x182A7B1B0", Slot = "8")]
			public void KEQXOPDDHIN(POHHIRYJWSY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
			public bool ODMBGFVNIPY(POHHIRYJWSY a, Id32<CYNSIGMASWI> b, LOHJEAGYXDY[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B230", Offset = "0x2A79830", VA = "0x182A7B230", Slot = "10")]
			public bool YHXDRLICZKA(POHHIRYJWSY a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AFB0", Offset = "0x2A795B0", VA = "0x182A7AFB0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, IQRQYBTPXGA>> BSXHMYMHCVC(POHHIRYJWSY a, Id32<CYNSIGMASWI> b, LOHJEAGYXDY c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : ZHESUVALAPM.UWEOGEPSJXO<ActionDeps, GCFTXZUHCVV.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps QYBEHTLOOOQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public GCFTXZUHCVV.StaticNetSysReceiverDeps KSZGRJVSPTF
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "5")]
				get
				{
					return default(GCFTXZUHCVV.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps TYEEAFXGCBU
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int IOXVRHBLLUH
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool VJFSASDIKRS
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string MEUULFBHMJE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool YHXDRLICZKA(int a);
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
			public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public POHHIRYJWSY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GCFTXZUHCVV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<CYNSIGMASWI> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LOHJEAGYXDY action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B300", Offset = "0x2A79900", VA = "0x182A7B300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B530", Offset = "0x2A79B30", VA = "0x182A7B530", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public POHHIRYJWSY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LOHJEAGYXDY action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B5A0", Offset = "0x2A79BA0", VA = "0x182A7B5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B7D0", Offset = "0x2A79DD0", VA = "0x182A7B7D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private BFTOZJHSVNM<LOHJEAGYXDY, None, GCFTXZUHCVV, ActionDeps, GCFTXZUHCVV.StaticNetSysReceiverDeps, RootDeps, POHHIRYJWSY, Deps> QKHFPAHUBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int PYRMMPWLOYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int MSDZPRWRIYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int KMTIJEXETLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly GQTXCFUZTUW<LOHJEAGYXDY, Result<object, IQRQYBTPXGA>> WYIYHPMAVYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly GQTXCFUZTUW<LOHJEAGYXDY, Result<object, IQRQYBTPXGA>> ZRNDLVAOUNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ETPODEKPKCV KUPOYFERZJZ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XVIQTQHKRRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A79F40", Offset = "0x2A78540", VA = "0x182A79F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int XDSLBDWDDJS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C40", Offset = "0x2A78240", VA = "0x182A79C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int XBOCEIDLPNF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A79DB0", Offset = "0x2A783B0", VA = "0x182A79DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int ZXDENPSDRYK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2A79F80", Offset = "0x2A78580", VA = "0x182A79F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A79FC0", Offset = "0x2A785C0", VA = "0x182A79FC0")]
		public POHHIRYJWSY(int a, int b, int c, GQTXCFUZTUW<LOHJEAGYXDY, Result<object, IQRQYBTPXGA>> d, GQTXCFUZTUW<LOHJEAGYXDY, Result<object, IQRQYBTPXGA>> e, ETPODEKPKCV f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A79DF0", Offset = "0x2A783F0", VA = "0x182A79DF0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, IQRQYBTPXGA>> LGRLWYAUJJR(GCFTXZUHCVV a, Id32<CYNSIGMASWI> b, LOHJEAGYXDY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A79C80", Offset = "0x2A78280", VA = "0x182A79C80", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, IQRQYBTPXGA>> BSXHMYMHCVC(LOHJEAGYXDY a, bool b)
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
