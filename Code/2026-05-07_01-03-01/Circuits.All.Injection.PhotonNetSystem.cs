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
	public sealed class KBITNPSXADS : IDisposable, RMMDEDBMVOB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public XRFLWTQTKUE Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10DE880", Offset = "0x10DD280", VA = "0x1810DE880")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, XRFLWTQTKUE receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFD10", Offset = "0x2AEE710", VA = "0x182AEFD10")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class TJVBHCFBMGX : QPOMEWQYEQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> JETPPNQRUDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> MGIOSAIXLIG;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object DRRYLFOYJRR
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF1470", Offset = "0x2AEFE70", VA = "0x182AF1470", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF14C0", Offset = "0x2AEFEC0", VA = "0x182AF14C0")]
			public TJVBHCFBMGX(CIZSGDLSXXQ a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1410", Offset = "0x2AEFE10", VA = "0x182AF1410", Slot = "9")]
			protected override bool PQFWYVDNDFR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1440", Offset = "0x2AEFE40", VA = "0x182AF1440")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string TIBFEUSUPVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<SLTVKIGDHLN, CV2DynamicObject> LDDKNFVEKUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<YFBJPXYJORD, TJVBHCFBMGX> BEBJGGNUJKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<QEBRWUBFUFW> HGMEIUADVSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD6D560", Offset = "0xD6BF60", VA = "0x180D6D560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QEBRWUBFUFW>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1630A90", Offset = "0x162F490", VA = "0x181630A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0B50", Offset = "0x2AEF550", VA = "0x182AF0B50")]
		public KBITNPSXADS(string a, Id32<QEBRWUBFUFW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0010", Offset = "0x2AEEA10", VA = "0x182AF0010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0070", Offset = "0x2AEEA70", VA = "0x182AF0070")]
		public void FZZEZGZJWLC(Id32<SLTVKIGDHLN> a, YOWRGPCINZI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF09C0", Offset = "0x2AEF3C0", VA = "0x182AF09C0")]
		public Id32<SLTVKIGDHLN> WXSFFCSMOWS(RRNetworkBehavior a)
		{
			return default(Id32<SLTVKIGDHLN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0320", Offset = "0x2AEED20", VA = "0x182AF0320")]
		public void PMERSJUNXAS(Id32<SLTVKIGDHLN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0370", Offset = "0x2AEED70", VA = "0x182AF0370", Slot = "6")]
		public void PZANMLEIQCJ(Id32<SLTVKIGDHLN> a, YOWRGPCINZI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFE60", Offset = "0x2AEE860", VA = "0x182AEFE60", Slot = "7")]
		public void BQZHTXSZRZZ(Id32<SLTVKIGDHLN> a, YOWRGPCINZI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFD50", Offset = "0x2AEE750", VA = "0x182AEFD50", Slot = "8")]
		public void AUYBRXCOAZK(Id32<SLTVKIGDHLN> a, YOWRGPCINZI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF07E0", Offset = "0x2AEF1E0", VA = "0x182AF07E0", Slot = "9")]
		public void RNQFJWSXYDH(Id32<SLTVKIGDHLN> a, YOWRGPCINZI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF01D0", Offset = "0x2AEEBD0", VA = "0x182AF01D0", Slot = "10")]
		public void PEXCDCVVNRR(Id32<SLTVKIGDHLN> a, Id32<QEBRWUBFUFW> b, YOWRGPCINZI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF08F0", Offset = "0x2AEF2F0", VA = "0x182AF08F0", Slot = "11")]
		public void RTGHZGHWXLL(Id32<SLTVKIGDHLN> a, XRFLWTQTKUE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0AD0", Offset = "0x2AEF4D0", VA = "0x182AF0AD0", Slot = "12")]
		public Id32<QEBRWUBFUFW> ZXBMCXLDMPQ(Id32<SLTVKIGDHLN> a)
		{
			return default(Id32<QEBRWUBFUFW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0480", Offset = "0x2AEEE80", VA = "0x182AF0480", Slot = "13")]
		public Id32<YFBJPXYJORD> QMZLKHZKJJU(Id32<SLTVKIGDHLN> a, string b, object c, bool d, QHMMCWYGQBV e, HZOEHZSWUUR f)
		{
			return default(Id32<YFBJPXYJORD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0A50", Offset = "0x2AEF450", VA = "0x182AF0A50", Slot = "14")]
		public void XALELJNVKPM(Id32<YFBJPXYJORD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0150", Offset = "0x2AEEB50", VA = "0x182AF0150", Slot = "15")]
		public void KZIKNIQBEGQ(Id32<YFBJPXYJORD> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class MUWWCPKACGM : ISJHRHKEWBX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : DFCGLAFPUYG.YKCEPJNVAWP<SYXPYTMUMKS, MUWWCPKACGM>
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
				public AsyncTaskMethodBuilder<Result<object, RYUTMMKYXMA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public MUWWCPKACGM root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public SYXPYTMUMKS action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2AF1AE0", Offset = "0x2AF04E0", VA = "0x182AF1AE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF1F20", Offset = "0x2AF0920", VA = "0x182AF1F20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF10C0", Offset = "0x2AEFAC0", VA = "0x182AF10C0", Slot = "4")]
			public int CQNPPJSTBXJ(MUWWCPKACGM a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1527A20", Offset = "0x1526420", VA = "0x181527A20", Slot = "5")]
			public int PQYBQQBRHUJ(MUWWCPKACGM a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1320", Offset = "0x2AEFD20", VA = "0x182AF1320", Slot = "6")]
			public int SAJYTHLOYKK(MUWWCPKACGM a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x105B450", Offset = "0x1059E50", VA = "0x18105B450", Slot = "7")]
			public int NPCGWFXLLNI(MUWWCPKACGM a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1180", Offset = "0x2AEFB80", VA = "0x182AF1180", Slot = "8")]
			public void LLLWOQZUJWF(MUWWCPKACGM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "9")]
			public bool YRBFDIRBOEC(MUWWCPKACGM a, Id32<QEBRWUBFUFW> b, SYXPYTMUMKS[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1340", Offset = "0x2AEFD40", VA = "0x182AF1340", Slot = "10")]
			public bool XCADZIAIFAI(MUWWCPKACGM a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AF11E0", Offset = "0x2AEFBE0", VA = "0x182AF11E0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(MUWWCPKACGM a, Id32<QEBRWUBFUFW> b, SYXPYTMUMKS c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : DFCGLAFPUYG.ZFCLKDKZCRS<ActionDeps, BOPULBRGFUP.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps NUVFWHTIZFS
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public BOPULBRGFUP.StaticNetSysReceiverDeps MKTGHAQBKUD
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "5")]
				get
				{
					return default(BOPULBRGFUP.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps ZRRPLJGSDRE
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface VQSBDUUAFGN
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int WPZAYJAYMTB
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool QSXSAMQZBHG
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string GIEMZKXHVPY
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool XCADZIAIFAI(int a);
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
			public AsyncTaskMethodBuilder<Result<object, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MUWWCPKACGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BOPULBRGFUP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<QEBRWUBFUFW> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public SYXPYTMUMKS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2AF15A0", Offset = "0x2AEFFA0", VA = "0x182AF15A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF17D0", Offset = "0x2AF01D0", VA = "0x182AF17D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public MUWWCPKACGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public SYXPYTMUMKS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1840", Offset = "0x2AF0240", VA = "0x182AF1840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1A70", Offset = "0x2AF0470", VA = "0x182AF1A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private JUSAZMDMCXI<SYXPYTMUMKS, None, BOPULBRGFUP, ActionDeps, BOPULBRGFUP.StaticNetSysReceiverDeps, RootDeps, MUWWCPKACGM, Deps> XNVEPLJVSPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int FHYZSKCVWFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int PYNDOPCPGPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int BUFXYLWFZJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly RTKFLMISILA<SYXPYTMUMKS, Result<object, RYUTMMKYXMA>> XZDURSDLOUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly RTKFLMISILA<SYXPYTMUMKS, Result<object, RYUTMMKYXMA>> OZAFVUZTDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly VQSBDUUAFGN ANTAOVGZRYP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DQHABCLBIZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0F90", Offset = "0x2AEF990", VA = "0x182AF0F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KLGQNQTBKME
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0C50", Offset = "0x2AEF650", VA = "0x182AF0C50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int TPVZSICLGPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0F50", Offset = "0x2AEF950", VA = "0x182AF0F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int THRQKNTIVSC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0F10", Offset = "0x2AEF910", VA = "0x182AF0F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0FD0", Offset = "0x2AEF9D0", VA = "0x182AF0FD0")]
		public MUWWCPKACGM(int a, int b, int c, RTKFLMISILA<SYXPYTMUMKS, Result<object, RYUTMMKYXMA>> d, RTKFLMISILA<SYXPYTMUMKS, Result<object, RYUTMMKYXMA>> e, VQSBDUUAFGN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C90", Offset = "0x2AEF690", VA = "0x182AF0C90")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, RYUTMMKYXMA>> IQOLMAAGTUX(BOPULBRGFUP a, Id32<QEBRWUBFUFW> b, SYXPYTMUMKS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0DE0", Offset = "0x2AEF7E0", VA = "0x182AF0DE0", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(SYXPYTMUMKS a, bool b)
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
