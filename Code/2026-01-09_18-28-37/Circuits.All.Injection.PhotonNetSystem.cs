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
	public sealed class HTEYUDIRHDA : IDisposable, FZUHJKMKOUD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public JJTCGSUBOXA Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, JJTCGSUBOXA receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2833F50", Offset = "0x2833350", VA = "0x182833F50")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class HMIZBHDZGBH : TOFCCKEDOJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> VXZCFFERRYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> AEYUPFYLNIQ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object VSJXXYIUWYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2833F90", Offset = "0x2833390", VA = "0x182833F90", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2834040", Offset = "0x2833440", VA = "0x182834040")]
			public HMIZBHDZGBH(JLPEVSHEISE a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2833FE0", Offset = "0x28333E0", VA = "0x182833FE0", Slot = "9")]
			protected override bool SIVIGIIKJWZ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2834010", Offset = "0x2833410", VA = "0x182834010")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string RYXEKYDXFHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<JDQQUBYOTBT, CV2DynamicObject> ERDBIRCBNVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<DSZQEJPSUJJ, HMIZBHDZGBH> NEAFHAVTUCR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<GPNZGVDAJTA> XKVMHZWGJUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xCAE680", Offset = "0xCADA80", VA = "0x180CAE680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GPNZGVDAJTA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x134B640", Offset = "0x134AA40", VA = "0x18134B640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2834F20", Offset = "0x2834320", VA = "0x182834F20")]
		public HTEYUDIRHDA(string a, Id32<GPNZGVDAJTA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2834170", Offset = "0x2833570", VA = "0x182834170", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2834960", Offset = "0x2833D60", VA = "0x182834960")]
		public void MLLWWARUIKW(Id32<JDQQUBYOTBT> a, KMDWRSUVLAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2834E90", Offset = "0x2834290", VA = "0x182834E90")]
		public Id32<JDQQUBYOTBT> XCDLBYNARJO(RRNetworkBehavior a)
		{
			return default(Id32<JDQQUBYOTBT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2834120", Offset = "0x2833520", VA = "0x182834120")]
		public void BYNVBKITKUA(Id32<JDQQUBYOTBT> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2834C70", Offset = "0x2834070", VA = "0x182834C70", Slot = "6")]
		public void RXPLDSCOUID(Id32<JDQQUBYOTBT> a, KMDWRSUVLAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2834AC0", Offset = "0x2833EC0", VA = "0x182834AC0", Slot = "7")]
		public void PSFINALWZYB(Id32<JDQQUBYOTBT> a, KMDWRSUVLAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2834D80", Offset = "0x2834180", VA = "0x182834D80", Slot = "8")]
		public void UFZJAQPVYAO(Id32<JDQQUBYOTBT> a, KMDWRSUVLAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2834320", Offset = "0x2833720", VA = "0x182834320", Slot = "9")]
		public void EJBKDSXBOHN(Id32<JDQQUBYOTBT> a, KMDWRSUVLAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28341D0", Offset = "0x28335D0", VA = "0x1828341D0", Slot = "10")]
		public void EEGAXYDOVXL(Id32<JDQQUBYOTBT> a, Id32<GPNZGVDAJTA> b, KMDWRSUVLAA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2834810", Offset = "0x2833C10", VA = "0x182834810", Slot = "11")]
		public void IKNTUCQKSHB(Id32<JDQQUBYOTBT> a, JJTCGSUBOXA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2834A40", Offset = "0x2833E40", VA = "0x182834A40", Slot = "12")]
		public Id32<GPNZGVDAJTA> NMVWPDZXJRK(Id32<JDQQUBYOTBT> a)
		{
			return default(Id32<GPNZGVDAJTA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2834430", Offset = "0x2833830", VA = "0x182834430", Slot = "13")]
		public Id32<DSZQEJPSUJJ> GAIXMUYDOQU(Id32<JDQQUBYOTBT> a, string b, object c, bool d, UAIHKBQAJZH e, BPZOLTUSHZR f)
		{
			return default(Id32<DSZQEJPSUJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2834790", Offset = "0x2833B90", VA = "0x182834790", Slot = "14")]
		public void GDHDAFMZOOM(Id32<DSZQEJPSUJJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28348E0", Offset = "0x2833CE0", VA = "0x1828348E0", Slot = "15")]
		public void JXBUNLROPGW(Id32<DSZQEJPSUJJ> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class XNWWTJRMXKG : AEMOPZBEDBJ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : NTEFXKGQILC.OAYYLTXYXIF<HJODGUBVAZG, XNWWTJRMXKG>
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
				public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public XNWWTJRMXKG root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public HJODGUBVAZG action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28358B0", Offset = "0x2834CB0", VA = "0x1828358B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2835D00", Offset = "0x2835100", VA = "0x182835D00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28350F0", Offset = "0x28344F0", VA = "0x1828350F0", Slot = "4")]
			public int VLIUWXXGURX(XNWWTJRMXKG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1255670", Offset = "0x1254A70", VA = "0x181255670", Slot = "5")]
			public int JDANBMRGQFJ(XNWWTJRMXKG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2835350", Offset = "0x2834750", VA = "0x182835350", Slot = "6")]
			public int ZUMNGMYOUGM(XNWWTJRMXKG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDBFEB0", Offset = "0xDBF2B0", VA = "0x180DBFEB0", Slot = "7")]
			public int UDIXAIGHGZW(XNWWTJRMXKG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x28351B0", Offset = "0x28345B0", VA = "0x1828351B0", Slot = "8")]
			public void XLKHBMVVKRZ(XNWWTJRMXKG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			public bool YFEHDFHPGAU(XNWWTJRMXKG a, Id32<GPNZGVDAJTA> b, HJODGUBVAZG[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2835020", Offset = "0x2834420", VA = "0x182835020", Slot = "10")]
			public bool VEJHIFQZBRU(XNWWTJRMXKG a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2835210", Offset = "0x2834610", VA = "0x182835210", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, ZEEUKBHYSTE>> YYSLKNAWHOS(XNWWTJRMXKG a, Id32<GPNZGVDAJTA> b, HJODGUBVAZG c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : NTEFXKGQILC.UCTXXJIHGPQ<ActionDeps, PRNNMMJSLKB.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps ULQFZKOZFIK
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public PRNNMMJSLKB.StaticNetSysReceiverDeps BQTRRBSIUGJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "5")]
				get
				{
					return default(PRNNMMJSLKB.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps GSGOEREMWPK
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface VUJTJJOWWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int FFXUTVAYNYR
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool GDYICUGLHYC
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string NAEGJWRFADW
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool VEJHIFQZBRU(int a);
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
			public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public XNWWTJRMXKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public PRNNMMJSLKB root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<GPNZGVDAJTA> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HJODGUBVAZG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2835370", Offset = "0x2834770", VA = "0x182835370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x28355A0", Offset = "0x28349A0", VA = "0x1828355A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, ZEEUKBHYSTE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public XNWWTJRMXKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public HJODGUBVAZG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, ZEEUKBHYSTE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2835610", Offset = "0x2834A10", VA = "0x182835610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2835840", Offset = "0x2834C40", VA = "0x182835840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private AKOCMCLIYNG<HJODGUBVAZG, None, PRNNMMJSLKB, ActionDeps, PRNNMMJSLKB.StaticNetSysReceiverDeps, RootDeps, XNWWTJRMXKG, Deps> STJJAEGTVHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int AMAQWZJLZTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int RSSACNMXZIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int JRYXWSLNEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly OCBELOTUFUY<HJODGUBVAZG, Result<object, ZEEUKBHYSTE>> TLWTMYZNILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OCBELOTUFUY<HJODGUBVAZG, Result<object, ZEEUKBHYSTE>> SBWUTFOEHPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly VUJTJJOWWBJ GOSNOUTRNRX;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool STEHAJGVWFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2835EC0", Offset = "0x28352C0", VA = "0x182835EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AHFBOSYDYEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2835F00", Offset = "0x2835300", VA = "0x182835F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int KVRWRTDCJRP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2835F80", Offset = "0x2835380", VA = "0x182835F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int RCFOPLEOWTO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2835F40", Offset = "0x2835340", VA = "0x182835F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28360F0", Offset = "0x28354F0", VA = "0x1828360F0")]
		public XNWWTJRMXKG(int a, int b, int c, OCBELOTUFUY<HJODGUBVAZG, Result<object, ZEEUKBHYSTE>> d, OCBELOTUFUY<HJODGUBVAZG, Result<object, ZEEUKBHYSTE>> e, VUJTJJOWWBJ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2835D70", Offset = "0x2835170", VA = "0x182835D70")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, ZEEUKBHYSTE>> BSDHRXLMENL(PRNNMMJSLKB a, Id32<GPNZGVDAJTA> b, HJODGUBVAZG c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2835FC0", Offset = "0x28353C0", VA = "0x182835FC0", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, ZEEUKBHYSTE>> YYSLKNAWHOS(HJODGUBVAZG a, bool b)
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
