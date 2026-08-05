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
	public sealed class OHWEEZOCSRE : IDisposable, BBNEQAUDUTJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public FWGYWSERRIW Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, FWGYWSERRIW receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B27E60", Offset = "0x2B26860", VA = "0x182B27E60")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class SIWYQYYUWCB : MRFHEYATTPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> OYOPLFKEAPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> HFOAYNMTYCE;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object HRFHZUDJLOZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2B295E0", Offset = "0x2B27FE0", VA = "0x182B295E0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B29630", Offset = "0x2B28030", VA = "0x182B29630")]
			public SIWYQYYUWCB(PENMSEVEISY a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B29580", Offset = "0x2B27F80", VA = "0x182B29580", Slot = "9")]
			protected override bool GHMQXGJIVUR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2B295B0", Offset = "0x2B27FB0", VA = "0x182B295B0")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string PIBRDOYUFXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<TBNPHTPCKFD, CV2DynamicObject> BYNNWYXCOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<KGCIRRULOJF, SIWYQYYUWCB> OQPEZXVHFWJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<HGRDVVOSLAK> CIKXZKSDOLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xDAEDB0", Offset = "0xDAD7B0", VA = "0x180DAEDB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<HGRDVVOSLAK>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x166CCF0", Offset = "0x166B6F0", VA = "0x18166CCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B29120", Offset = "0x2B27B20", VA = "0x182B29120")]
		public OHWEEZOCSRE(string a, Id32<HGRDVVOSLAK> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B28310", Offset = "0x2B26D10", VA = "0x182B28310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B28B00", Offset = "0x2B27500", VA = "0x182B28B00")]
		public void PHWMRHWJZPU(Id32<TBNPHTPCKFD> a, FPSIMBBGQNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B28890", Offset = "0x2B27290", VA = "0x182B28890")]
		public Id32<TBNPHTPCKFD> KKQRWRQVRWA(RRNetworkBehavior a)
		{
			return default(Id32<TBNPHTPCKFD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B290D0", Offset = "0x2B27AD0", VA = "0x182B290D0")]
		public void XTDZSITMBWE(Id32<TBNPHTPCKFD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B28780", Offset = "0x2B27180", VA = "0x182B28780", Slot = "6")]
		public void HDDCMKRVSZN(Id32<TBNPHTPCKFD> a, FPSIMBBGQNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B28480", Offset = "0x2B26E80", VA = "0x182B28480", Slot = "7")]
		public void GERGMYXIDCJ(Id32<TBNPHTPCKFD> a, FPSIMBBGQNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B28370", Offset = "0x2B26D70", VA = "0x182B28370", Slot = "8")]
		public void GCYTTCUHVUW(Id32<TBNPHTPCKFD> a, FPSIMBBGQNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B289F0", Offset = "0x2B273F0", VA = "0x182B289F0", Slot = "9")]
		public void NVGXJDHBZTN(Id32<TBNPHTPCKFD> a, FPSIMBBGQNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B28630", Offset = "0x2B27030", VA = "0x182B28630", Slot = "10")]
		public void GWNGUEHDASF(Id32<TBNPHTPCKFD> a, Id32<HGRDVVOSLAK> b, FPSIMBBGQNW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B28920", Offset = "0x2B27320", VA = "0x182B28920", Slot = "11")]
		public void MAOFQTOBGJJ(Id32<TBNPHTPCKFD> a, FWGYWSERRIW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B28CE0", Offset = "0x2B276E0", VA = "0x182B28CE0", Slot = "12")]
		public Id32<HGRDVVOSLAK> WCLPDTZCLVO(Id32<TBNPHTPCKFD> a)
		{
			return default(Id32<HGRDVVOSLAK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B28D60", Offset = "0x2B27760", VA = "0x182B28D60", Slot = "13")]
		public Id32<KGCIRRULOJF> WTREUOCVIWU(Id32<TBNPHTPCKFD> a, string b, object c, bool d, RBBGDVTZCDL e, LQEKLSRKXJV f)
		{
			return default(Id32<KGCIRRULOJF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B28BE0", Offset = "0x2B275E0", VA = "0x182B28BE0", Slot = "14")]
		public void QFHHBEAISFS(Id32<KGCIRRULOJF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B28C60", Offset = "0x2B27660", VA = "0x182B28C60", Slot = "15")]
		public void SYZGFZNTDJM(Id32<KGCIRRULOJF> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class IKVEEFOXLQG : WNWYUXAFTQH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : OPEKJLKYGKI.FUAHARUPYCB<PZJVNVFLVDC, IKVEEFOXLQG>
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
				public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public IKVEEFOXLQG root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public PZJVNVFLVDC action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2B29C50", Offset = "0x2B28650", VA = "0x182B29C50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B2A090", Offset = "0x2B28A90", VA = "0x182B2A090", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B294B0", Offset = "0x2B27EB0", VA = "0x182B294B0", Slot = "4")]
			public int UOFFTWRMUCJ(IKVEEFOXLQG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x15643B0", Offset = "0x1562DB0", VA = "0x1815643B0", Slot = "5")]
			public int WJRTLBQAYVF(IKVEEFOXLQG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B29220", Offset = "0x2B27C20", VA = "0x182B29220", Slot = "6")]
			public int DQRIOHRLWSI(IKVEEFOXLQG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1099610", Offset = "0x1098010", VA = "0x181099610", Slot = "7")]
			public int AUJNWHPLWZS(IKVEEFOXLQG a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B29450", Offset = "0x2B27E50", VA = "0x182B29450", Slot = "8")]
			public void JZKFDFQOANF(IKVEEFOXLQG a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "9")]
			public bool VYGVEXEQISU(IKVEEFOXLQG a, Id32<HGRDVVOSLAK> b, PZJVNVFLVDC[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B29380", Offset = "0x2B27D80", VA = "0x182B29380", Slot = "10")]
			public bool JANQPHUMUFM(IKVEEFOXLQG a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2B29240", Offset = "0x2B27C40", VA = "0x182B29240", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, LSNRXVKTUTI>> ETHZSTORPJA(IKVEEFOXLQG a, Id32<HGRDVVOSLAK> b, PZJVNVFLVDC c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : OPEKJLKYGKI.SWYTVHETLJM<ActionDeps, WVKEVWTACCJ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps EZESLREZLXA
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public WVKEVWTACCJ.StaticNetSysReceiverDeps WBCJRZAEHOZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "5")]
				get
				{
					return default(WVKEVWTACCJ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps KWZYCCDKLZG
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int SPKVRFCNFAV
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool MYVWKRPZVXI
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string ZBHNAEAZBQE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool JANQPHUMUFM(int a);
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
			public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IKVEEFOXLQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public WVKEVWTACCJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<HGRDVVOSLAK> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PZJVNVFLVDC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2B29710", Offset = "0x2B28110", VA = "0x182B29710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2B29940", Offset = "0x2B28340", VA = "0x182B29940", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LSNRXVKTUTI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IKVEEFOXLQG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PZJVNVFLVDC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, LSNRXVKTUTI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2B299B0", Offset = "0x2B283B0", VA = "0x182B299B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2B29BE0", Offset = "0x2B285E0", VA = "0x182B29BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private KPQCGBJYPPK<PZJVNVFLVDC, None, WVKEVWTACCJ, ActionDeps, WVKEVWTACCJ.StaticNetSysReceiverDeps, RootDeps, IKVEEFOXLQG, Deps> TXYAKHNYNUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int BCVWTJXXBRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int TULZUCIAION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int WTILHVLMNRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly JDLJVPYSLVS<PZJVNVFLVDC, Result<object, LSNRXVKTUTI>> VMIYDTOUPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly JDLJVPYSLVS<PZJVNVFLVDC, Result<object, LSNRXVKTUTI>> HDLIDGKCWFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EDIRCJTODTF FHQCWCTTOJP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SRJGCUOUAGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2B281E0", Offset = "0x2B26BE0", VA = "0x182B281E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int YEBBGRKNXWO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B27EE0", Offset = "0x2B268E0", VA = "0x182B27EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IPASCBUNJKR
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B27EA0", Offset = "0x2B268A0", VA = "0x182B27EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int CUCMVYQLHOY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B28050", Offset = "0x2B26A50", VA = "0x182B28050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B28220", Offset = "0x2B26C20", VA = "0x182B28220")]
		public IKVEEFOXLQG(int a, int b, int c, JDLJVPYSLVS<PZJVNVFLVDC, Result<object, LSNRXVKTUTI>> d, JDLJVPYSLVS<PZJVNVFLVDC, Result<object, LSNRXVKTUTI>> e, EDIRCJTODTF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B28090", Offset = "0x2B26A90", VA = "0x182B28090")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, LSNRXVKTUTI>> QIQIZJQHZIN(WVKEVWTACCJ a, Id32<HGRDVVOSLAK> b, PZJVNVFLVDC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B27F20", Offset = "0x2B26920", VA = "0x182B27F20", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, LSNRXVKTUTI>> ETHZSTORPJA(PZJVNVFLVDC a, bool b)
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
