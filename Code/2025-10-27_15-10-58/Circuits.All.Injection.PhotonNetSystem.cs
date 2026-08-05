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
	public sealed class ZAVGDPQXEIN : IDisposable, YYFDGRCCPXY
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public VKKUIVYOEIX Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, VKKUIVYOEIX receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF880", Offset = "0x2AEE880", VA = "0x182AEF880")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class TVRAWBILXWI : OYJCOKSFVXP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> ONXLPDWBPPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> CIEWUWYOUQB;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object JOLWGJEGVLC
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF00E0", Offset = "0x2AEF0E0", VA = "0x182AF00E0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0130", Offset = "0x2AEF130", VA = "0x182AF0130")]
			public TVRAWBILXWI(HHTCNVFGVYJ a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF00B0", Offset = "0x2AEF0B0", VA = "0x182AF00B0", Slot = "9")]
			protected override bool VUSQFFAJXKS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0080", Offset = "0x2AEF080", VA = "0x182AF0080")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string RQMRZXXHNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<LDCKCJVHREK, CV2DynamicObject> SGNAKCUWGOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<QQPDWFLGPJE, TVRAWBILXWI> PALZEQFSDGQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<DQQOGREBWGB> RCVFUAVSNTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xE54500", Offset = "0xE53500", VA = "0x180E54500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DQQOGREBWGB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x16EC390", Offset = "0x16EB390", VA = "0x1816EC390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1A10", Offset = "0x2AF0A10", VA = "0x182AF1A10")]
		public ZAVGDPQXEIN(string a, Id32<DQQOGREBWGB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0D80", Offset = "0x2AEFD80", VA = "0x182AF0D80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C10", Offset = "0x2AEFC10", VA = "0x182AF0C10")]
		public void BQABDNINDRX(Id32<LDCKCJVHREK> a, QXODCZYRTYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0CF0", Offset = "0x2AEFCF0", VA = "0x182AF0CF0")]
		public Id32<LDCKCJVHREK> CIOZYXOEZYT(RRNetworkBehavior a)
		{
			return default(Id32<LDCKCJVHREK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0FC0", Offset = "0x2AEFFC0", VA = "0x182AF0FC0")]
		public void MYWMFBQXYBH(Id32<LDCKCJVHREK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0EB0", Offset = "0x2AEFEB0", VA = "0x182AF0EB0", Slot = "6")]
		public void MDDQGQJWNSU(Id32<LDCKCJVHREK> a, QXODCZYRTYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1090", Offset = "0x2AF0090", VA = "0x182AF1090", Slot = "7")]
		public void VFYMRTPAJWO(Id32<LDCKCJVHREK> a, QXODCZYRTYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1900", Offset = "0x2AF0900", VA = "0x182AF1900", Slot = "8")]
		public void ZWVMSLCZDAX(Id32<LDCKCJVHREK> a, QXODCZYRTYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF16F0", Offset = "0x2AF06F0", VA = "0x182AF16F0", Slot = "9")]
		public void ZIHJKFINYVQ(Id32<LDCKCJVHREK> a, QXODCZYRTYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1240", Offset = "0x2AF0240", VA = "0x182AF1240", Slot = "10")]
		public void WWLRJYNFWZO(Id32<LDCKCJVHREK> a, Id32<DQQOGREBWGB> b, QXODCZYRTYZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0DE0", Offset = "0x2AEFDE0", VA = "0x182AF0DE0", Slot = "11")]
		public void GGEHAASOMUI(Id32<LDCKCJVHREK> a, VKKUIVYOEIX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1880", Offset = "0x2AF0880", VA = "0x182AF1880", Slot = "12")]
		public Id32<DQQOGREBWGB> ZQXTETLBYDN(Id32<LDCKCJVHREK> a)
		{
			return default(Id32<DQQOGREBWGB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1390", Offset = "0x2AF0390", VA = "0x182AF1390", Slot = "13")]
		public Id32<QQPDWFLGPJE> XEHCUYPDZFH(Id32<LDCKCJVHREK> a, string b, object c, bool d, BLUYRSGGJVM e, HHQAWKBEXNQ f)
		{
			return default(Id32<QQPDWFLGPJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1800", Offset = "0x2AF0800", VA = "0x182AF1800", Slot = "14")]
		public void ZJEXOAWXZTJ(Id32<QQPDWFLGPJE> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1010", Offset = "0x2AF0010", VA = "0x182AF1010", Slot = "15")]
		public void NCENUUAEBOD(Id32<QQPDWFLGPJE> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class DUZGPONUNUB : RJNEMTAVLYW
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : DYPZVZBTZVR.NAOLIBVLUKE<AGLENQQYPWD, DUZGPONUNUB>
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
				public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public DUZGPONUNUB root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public AGLENQQYPWD action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2AF0750", Offset = "0x2AEF750", VA = "0x182AF0750", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF0BA0", Offset = "0x2AEFBA0", VA = "0x182AF0BA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFF60", Offset = "0x2AEEF60", VA = "0x182AEFF60", Slot = "4")]
			public int PCEFNSABJBI(DUZGPONUNUB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB79300", Offset = "0xB78300", VA = "0x180B79300", Slot = "5")]
			public int WEXLKHIUPDU(DUZGPONUNUB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFF40", Offset = "0x2AEEF40", VA = "0x182AEFF40", Slot = "6")]
			public int KTSWPXIPLBL(DUZGPONUNUB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x11449A0", Offset = "0x11439A0", VA = "0x1811449A0", Slot = "7")]
			public int ECODOPBRDOF(DUZGPONUNUB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0020", Offset = "0x2AEF020", VA = "0x182AF0020", Slot = "8")]
			public void VOYNRHJEXFS(DUZGPONUNUB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "9")]
			public bool GDVQVJEJIVL(DUZGPONUNUB a, Id32<DQQOGREBWGB> b, AGLENQQYPWD[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFE70", Offset = "0x2AEEE70", VA = "0x182AEFE70", Slot = "10")]
			public bool FBVFPCBLFVJ(DUZGPONUNUB a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFD30", Offset = "0x2AEED30", VA = "0x182AEFD30", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, BGYAXKJXFCB>> CDPQVGWXFFF(DUZGPONUNUB a, Id32<DQQOGREBWGB> b, AGLENQQYPWD c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : DYPZVZBTZVR.XRRCBJBDPQX<ActionDeps, ICGXRSEYDCA.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps NHHGFLRBIOF
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ICGXRSEYDCA.StaticNetSysReceiverDeps HWOFRMPSQIS
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "5")]
				get
				{
					return default(ICGXRSEYDCA.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps YEHKPGJTORZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ICTTKLBYQGC
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int SSYEOGGBJHS
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool XPQZMMOQMET
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string OPRHBEDMIJF
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool FBVFPCBLFVJ(int a);
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
			public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DUZGPONUNUB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ICGXRSEYDCA root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<DQQOGREBWGB> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AGLENQQYPWD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0210", Offset = "0x2AEF210", VA = "0x182AF0210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0440", Offset = "0x2AEF440", VA = "0x182AF0440", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, BGYAXKJXFCB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DUZGPONUNUB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AGLENQQYPWD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, BGYAXKJXFCB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2AF04B0", Offset = "0x2AEF4B0", VA = "0x182AF04B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF06E0", Offset = "0x2AEF6E0", VA = "0x182AF06E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private CTLCXHJCSHR<AGLENQQYPWD, None, ICGXRSEYDCA, ActionDeps, ICGXRSEYDCA.StaticNetSysReceiverDeps, RootDeps, DUZGPONUNUB, Deps> RUBKUPLWLTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int IIKZHTOCGZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int TTNZTEVPUAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int XIQLXRYFVPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HKSGBUZJDCB<AGLENQQYPWD, Result<object, BGYAXKJXFCB>> RFFXPOWHHTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly HKSGBUZJDCB<AGLENQQYPWD, Result<object, BGYAXKJXFCB>> DCXPURTAZDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ICTTKLBYQGC RAESGKCNHZO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DSCHCEGXGDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFB80", Offset = "0x2AEEB80", VA = "0x182AEFB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HRAUEQTOAQX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC00", Offset = "0x2AEEC00", VA = "0x182AEFC00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int MWBVLARCHSW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFBC0", Offset = "0x2AEEBC0", VA = "0x182AEFBC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int ROXHYDGVRWT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFB40", Offset = "0x2AEEB40", VA = "0x182AEFB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFC40", Offset = "0x2AEEC40", VA = "0x182AEFC40")]
		public DUZGPONUNUB(int a, int b, int c, HKSGBUZJDCB<AGLENQQYPWD, Result<object, BGYAXKJXFCB>> d, HKSGBUZJDCB<AGLENQQYPWD, Result<object, BGYAXKJXFCB>> e, ICTTKLBYQGC f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF8C0", Offset = "0x2AEE8C0", VA = "0x182AEF8C0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, BGYAXKJXFCB>> BBSKMHTYCDG(ICGXRSEYDCA a, Id32<DQQOGREBWGB> b, AGLENQQYPWD c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFA10", Offset = "0x2AEEA10", VA = "0x182AEFA10", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, BGYAXKJXFCB>> CDPQVGWXFFF(AGLENQQYPWD a, bool b)
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
