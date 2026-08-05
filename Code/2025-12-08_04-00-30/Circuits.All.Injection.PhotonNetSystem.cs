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
			[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, LDIAONDUDJP receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x282E900", Offset = "0x282D100", VA = "0x18282E900")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x282E9A0", Offset = "0x282D1A0", VA = "0x18282E9A0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x282E9F0", Offset = "0x282D1F0", VA = "0x18282E9F0")]
			public HXCXIABZQUK(GPQEQALGKDB a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x282E940", Offset = "0x282D140", VA = "0x18282E940", Slot = "9")]
			protected override bool CHNXLMNUERG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x282E970", Offset = "0x282D170", VA = "0x18282E970")]
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
			[Cpp2IlInjected.Address(RVA = "0xCA9660", Offset = "0xCA7E60", VA = "0x180CA9660", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<KQPBKUZCJXR>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1348A60", Offset = "0x1347260", VA = "0x181348A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x282F8D0", Offset = "0x282E0D0", VA = "0x18282F8D0")]
		public KVHLEZUABCD(string a, Id32<KQPBKUZCJXR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x282EB60", Offset = "0x282D360", VA = "0x18282EB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x282F0E0", Offset = "0x282D8E0", VA = "0x18282F0E0")]
		public void OYKZLNVFUHF(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x282EAD0", Offset = "0x282D2D0", VA = "0x18282EAD0")]
		public Id32<XMKDLRJXOXG> AELXWYBUGSV(RRNetworkBehavior a)
		{
			return default(Id32<XMKDLRJXOXG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x282ED50", Offset = "0x282D550", VA = "0x18282ED50")]
		public void FQHKWXOAHBB(Id32<XMKDLRJXOXG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x282F390", Offset = "0x282DB90", VA = "0x18282F390", Slot = "6")]
		public void WTVJTSMZFHM(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x282EDA0", Offset = "0x282D5A0", VA = "0x18282EDA0", Slot = "7")]
		public void JRYSRZTSXFC(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x282EF50", Offset = "0x282D750", VA = "0x18282EF50", Slot = "8")]
		public void KBUOHYGCGEZ(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x282EC40", Offset = "0x282D440", VA = "0x18282EC40", Slot = "9")]
		public void FEEHZNZNFVO(Id32<XMKDLRJXOXG> a, NPSRPKJGUTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x282F1C0", Offset = "0x282D9C0", VA = "0x18282F1C0", Slot = "10")]
		public void QSUHWYQTPHA(Id32<XMKDLRJXOXG> a, Id32<KQPBKUZCJXR> b, NPSRPKJGUTZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x282F4A0", Offset = "0x282DCA0", VA = "0x18282F4A0", Slot = "11")]
		public void XNGHNUGCMHY(Id32<XMKDLRJXOXG> a, LDIAONDUDJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x282F060", Offset = "0x282D860", VA = "0x18282F060", Slot = "12")]
		public Id32<KQPBKUZCJXR> NXVRBGFPEMB(Id32<XMKDLRJXOXG> a)
		{
			return default(Id32<KQPBKUZCJXR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x282F570", Offset = "0x282DD70", VA = "0x18282F570", Slot = "13")]
		public Id32<OTODRBWJKCQ> YGFXLXDKIOP(Id32<XMKDLRJXOXG> a, string b, object c, bool d, EXLPNTVNDUA e, FJPWASEVZWQ f)
		{
			return default(Id32<OTODRBWJKCQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x282EBC0", Offset = "0x282D3C0", VA = "0x18282EBC0", Slot = "14")]
		public void EOERINMXIKJ(Id32<OTODRBWJKCQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x282F310", Offset = "0x282DB10", VA = "0x18282F310", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x2830260", Offset = "0x282EA60", VA = "0x182830260", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x28306A0", Offset = "0x282EEA0", VA = "0x1828306A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x282FC40", Offset = "0x282E440", VA = "0x18282FC40", Slot = "4")]
			public int VPHMZSLMVHW(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1250A80", Offset = "0x124F280", VA = "0x181250A80", Slot = "5")]
			public int JPAEUDOPCFO(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x282FD00", Offset = "0x282E500", VA = "0x18282FD00", Slot = "6")]
			public int ZJDSVGWEYOT(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDBB360", Offset = "0xDB9B60", VA = "0x180DBB360", Slot = "7")]
			public int DXHOFZAPIJB(WNWJDNVOTVZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x282FBE0", Offset = "0x282E3E0", VA = "0x18282FBE0", Slot = "8")]
			public void VGUKRHLEOQS(WNWJDNVOTVZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
			public bool IXQFEAGUHSL(WNWJDNVOTVZ a, Id32<KQPBKUZCJXR> b, LPVLEQQBKYR[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x282FB10", Offset = "0x282E310", VA = "0x18282FB10", Slot = "10")]
			public bool SEWGPPCUKWN(WNWJDNVOTVZ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x282F9D0", Offset = "0x282E1D0", VA = "0x18282F9D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public VFRMMNWEYJQ.StaticNetSysReceiverDeps HODMCQRGIFW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "5")]
				get
				{
					return default(VFRMMNWEYJQ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps DLPYXPIZNYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x282FD20", Offset = "0x282E520", VA = "0x18282FD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x282FF50", Offset = "0x282E750", VA = "0x18282FF50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x282FFC0", Offset = "0x282E7C0", VA = "0x18282FFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x28301F0", Offset = "0x282E9F0", VA = "0x1828301F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28308A0", Offset = "0x282F0A0", VA = "0x1828308A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MSSPYVRHCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2830A50", Offset = "0x282F250", VA = "0x182830A50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ZXAABHLYLOY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2830A10", Offset = "0x282F210", VA = "0x182830A10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPVWFCMTTRT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2830860", Offset = "0x282F060", VA = "0x182830860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2830A90", Offset = "0x282F290", VA = "0x182830A90")]
		public WNWJDNVOTVZ(int a, int b, int c, BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> d, BJQPTMXILSD<LPVLEQQBKYR, Result<object, AGEZPYTJJRF>> e, HYKMXKQCBUU f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2830710", Offset = "0x282EF10", VA = "0x182830710")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, AGEZPYTJJRF>> DCSRMRGONDI(VFRMMNWEYJQ a, Id32<KQPBKUZCJXR> b, LPVLEQQBKYR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28308E0", Offset = "0x282F0E0", VA = "0x1828308E0", Slot = "4")]
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
