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
	public sealed class KVHLEZUABCD : IDisposable, IDYIPMVXRGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public LDIAONDUDJP Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, LDIAONDUDJP receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2841150", Offset = "0x283FB50", VA = "0x182841150")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class HXCXIABZQUK : HJDNNOWCJGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> GLVRJMQQBCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> PLSKWORVUXZ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object WHXERYUCZBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x28411F0", Offset = "0x283FBF0", VA = "0x1828411F0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2841240", Offset = "0x283FC40", VA = "0x182841240")]
			public HXCXIABZQUK(GPQEQALGKDB a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2841190", Offset = "0x283FB90", VA = "0x182841190", Slot = "9")]
			protected override bool CHNXLMNUERG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x28411C0", Offset = "0x283FBC0", VA = "0x1828411C0")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string LLAHMECCEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<XMKDLRJXOXG, CV2DynamicObject> VXDPVVOAQOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<OTODRBWJKCQ, HXCXIABZQUK> PDGVGWHNSBE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<KQPBKUZCJXR> ZIFBBETZDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xCC09E0", Offset = "0xCBF3E0", VA = "0x180CC09E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<KQPBKUZCJXR>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1360350", Offset = "0x135ED50", VA = "0x181360350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2842130", Offset = "0x2840B30", VA = "0x182842130")]
		public KVHLEZUABCD(string a, Id32<KQPBKUZCJXR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28413B0", Offset = "0x283FDB0", VA = "0x1828413B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2841930", Offset = "0x2840330", VA = "0x182841930")]
		public void OYKZLNVFUHF(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2841320", Offset = "0x283FD20", VA = "0x182841320")]
		public Id32<XMKDLRJXOXG> AELXWYBUGSV(RRNetworkBehavior a)
		{
			return default(Id32<XMKDLRJXOXG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28415A0", Offset = "0x283FFA0", VA = "0x1828415A0")]
		public void FQHKWXOAHBB(Id32<XMKDLRJXOXG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2841BE0", Offset = "0x28405E0", VA = "0x182841BE0", Slot = "6")]
		public void WTVJTSMZFHM(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28415F0", Offset = "0x283FFF0", VA = "0x1828415F0", Slot = "7")]
		public void JRYSRZTSXFC(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28417A0", Offset = "0x28401A0", VA = "0x1828417A0", Slot = "8")]
		public void KBUOHYGCGEZ(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2841490", Offset = "0x283FE90", VA = "0x182841490", Slot = "9")]
		public void FEEHZNZNFVO(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2841A10", Offset = "0x2840410", VA = "0x182841A10", Slot = "10")]
		public void QSUHWYQTPHA(Id32<XMKDLRJXOXG> a, Id32<KQPBKUZCJXR> b, NPSRPKJGUTZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2841CF0", Offset = "0x28406F0", VA = "0x182841CF0", Slot = "11")]
		public void XNGHNUGCMHY(Id32<XMKDLRJXOXG> a, LDIAONDUDJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28418B0", Offset = "0x28402B0", VA = "0x1828418B0", Slot = "12")]
		public Id32<KQPBKUZCJXR> NXVRBGFPEMB(Id32<XMKDLRJXOXG> a)
		{
			return default(Id32<KQPBKUZCJXR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2841DC0", Offset = "0x28407C0", VA = "0x182841DC0", Slot = "13")]
		public Id32<OTODRBWJKCQ> YGFXLXDKIOP(Id32<XMKDLRJXOXG> a, string b, object c, bool d, EXLPNTVNDUA e, FJPWASEVZWQ f)
		{
			return default(Id32<OTODRBWJKCQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2841410", Offset = "0x283FE10", VA = "0x182841410", Slot = "14")]
		public void EOERINMXIKJ(Id32<OTODRBWJKCQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2841B60", Offset = "0x2840560", VA = "0x182841B60", Slot = "15")]
		public void RJUTEYMQMQZ(Id32<OTODRBWJKCQ> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class WNWJDNVOTVZ : ZYLAWNEORYA
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : NRKRHHBELOV.FNDZURQZCIS<LPVLEQQBKYR, WNWJDNVOTVZ>
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
				public AsyncTaskMethodBuilder<Result<object, AGEZPYTJJRF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public WNWJDNVOTVZ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public LPVLEQQBKYR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, AGEZPYTJJRF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2842AD0", Offset = "0x28414D0", VA = "0x182842AD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2842F10", Offset = "0x2841910", VA = "0x182842F10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28424A0", Offset = "0x2840EA0", VA = "0x1828424A0", Slot = "4")]
			public int VPHMZSLMVHW(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1268CA0", Offset = "0x12676A0", VA = "0x181268CA0", Slot = "5")]
			public int JPAEUDOPCFO(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2842570", Offset = "0x2840F70", VA = "0x182842570", Slot = "6")]
			public int ZJDSVGWEYOT(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDD29F0", Offset = "0xDD13F0", VA = "0x180DD29F0", Slot = "7")]
			public int DXHOFZAPIJB(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2842440", Offset = "0x2840E40", VA = "0x182842440", Slot = "8")]
			public void VGUKRHLEOQS(WNWJDNVOTVZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			public bool IXQFEAGUHSL(WNWJDNVOTVZ a, Id32<KQPBKUZCJXR> b, LPVLEQQBKYR[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2842370", Offset = "0x2840D70", VA = "0x182842370", Slot = "10")]
			public bool SEWGPPCUKWN(WNWJDNVOTVZ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2842230", Offset = "0x2840C30", VA = "0x182842230", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, AGEZPYTJJRF>> ONLJJASTUMB(WNWJDNVOTVZ a, Id32<KQPBKUZCJXR> b, LPVLEQQBKYR c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : NRKRHHBELOV.AGLKOFUJYKN<ActionDeps, VFRMMNWEYJQ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps XFCHQEZDBNN
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public VFRMMNWEYJQ.StaticNetSysReceiverDeps HODMCQRGIFW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "5")]
				get
				{
					return default(VFRMMNWEYJQ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps DLPYXPIZNYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface HYKMXKQCBUU
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int SKQDXUYPADI
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool FSJXISKJFJH
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string RTJRVVGMKKB
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool SEWGPPCUKWN(int a);
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
			public AsyncTaskMethodBuilder<Result<object, AGEZPYTJJRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public WNWJDNVOTVZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public VFRMMNWEYJQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<KQPBKUZCJXR> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LPVLEQQBKYR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, AGEZPYTJJRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2842590", Offset = "0x2840F90", VA = "0x182842590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x28427C0", Offset = "0x28411C0", VA = "0x1828427C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, AGEZPYTJJRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public WNWJDNVOTVZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LPVLEQQBKYR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, AGEZPYTJJRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2842830", Offset = "0x2841230", VA = "0x182842830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2842A60", Offset = "0x2841460", VA = "0x182842A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private SCLZCADIRNH<LPVLEQQBKYR, None, VFRMMNWEYJQ, ActionDeps, VFRMMNWEYJQ.StaticNetSysReceiverDeps, RootDeps, WNWJDNVOTVZ, Deps> SYITPSUGMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int LEJSDNWQUTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int BQLOLFSOEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int YNRIWRUZDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> WXYTELGZDOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> LNQZMDKERPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HYKMXKQCBUU EONMVLIXIRY;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QSBWAXRZCWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2843110", Offset = "0x2841B10", VA = "0x182843110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MSSPYVRHCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28432C0", Offset = "0x2841CC0", VA = "0x1828432C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ZXAABHLYLOY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2843280", Offset = "0x2841C80", VA = "0x182843280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPVWFCMTTRT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28430D0", Offset = "0x2841AD0", VA = "0x1828430D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2843300", Offset = "0x2841D00", VA = "0x182843300")]
		public WNWJDNVOTVZ(int a, int b, int c, BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> d, BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> e, HYKMXKQCBUU f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2842F80", Offset = "0x2841980", VA = "0x182842F80")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, AGEZPYTJJRF>> DCSRMRGONDI(VFRMMNWEYJQ a, Id32<KQPBKUZCJXR> b, LPVLEQQBKYR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2843150", Offset = "0x2841B50", VA = "0x182843150", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, AGEZPYTJJRF>> ONLJJASTUMB(LPVLEQQBKYR a, bool b)
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
