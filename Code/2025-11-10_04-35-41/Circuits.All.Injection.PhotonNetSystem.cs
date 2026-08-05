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
	public sealed class KJEUEWXPJJQ : IDisposable, GUDZVKDXAAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public YUCPDLXANTQ Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, YUCPDLXANTQ receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x27EB800", Offset = "0x27EAC00", VA = "0x1827EB800")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class PNXKFMCYKVT : ZCNCOROGCBS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> NTFKAHUKAZF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> XVCSZDSRYAY;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object PQRAXCKXLAV
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x27EC740", Offset = "0x27EBB40", VA = "0x1827EC740", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x27EC7F0", Offset = "0x27EBBF0", VA = "0x1827EC7F0")]
			public PNXKFMCYKVT(BZXWFWBHLFW a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x27EC7C0", Offset = "0x27EBBC0", VA = "0x1827EC7C0", Slot = "9")]
			protected override bool WHQBQPGRROV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x27EC790", Offset = "0x27EBB90", VA = "0x1827EC790")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string LTXSLSLZDTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<LPULDJDRFFP, CV2DynamicObject> ZEWALHCMHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<XWVACCFLESD, PNXKFMCYKVT> YWWIRKCKRXH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<FJSVDCFYEAW> BMUYUDKVXKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xC825B0", Offset = "0xC819B0", VA = "0x180C825B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FJSVDCFYEAW>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x131AC60", Offset = "0x131A060", VA = "0x18131AC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x27EC640", Offset = "0x27EBA40", VA = "0x1827EC640")]
		public KJEUEWXPJJQ(string a, Id32<FJSVDCFYEAW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27EB840", Offset = "0x27EAC40", VA = "0x1827EB840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27EBF40", Offset = "0x27EB340", VA = "0x1827EBF40")]
		public void PJGBNQOMEAG(Id32<LPULDJDRFFP> a, RVLJZCKPUDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27EBD20", Offset = "0x27EB120", VA = "0x1827EBD20")]
		public Id32<LPULDJDRFFP> KASDFMDPOOM(RRNetworkBehavior a)
		{
			return default(Id32<LPULDJDRFFP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27EBCD0", Offset = "0x27EB0D0", VA = "0x1827EBCD0")]
		public void JIYRHZTASEE(Id32<LPULDJDRFFP> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27EB920", Offset = "0x27EAD20", VA = "0x1827EB920", Slot = "6")]
		public void FJKNIUNFXPN(Id32<LPULDJDRFFP> a, RVLJZCKPUDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27EC020", Offset = "0x27EB420", VA = "0x1827EC020", Slot = "7")]
		public void QCPDVSOTSWN(Id32<LPULDJDRFFP> a, RVLJZCKPUDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27EBE30", Offset = "0x27EB230", VA = "0x1827EBE30", Slot = "8")]
		public void OQLUUZESNKS(Id32<LPULDJDRFFP> a, RVLJZCKPUDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x27EC530", Offset = "0x27EB930", VA = "0x1827EC530", Slot = "9")]
		public void XVDJDCQYIWL(Id32<LPULDJDRFFP> a, RVLJZCKPUDC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x27EBA30", Offset = "0x27EAE30", VA = "0x1827EBA30", Slot = "10")]
		public void HTOICIXKLDX(Id32<LPULDJDRFFP> a, Id32<FJSVDCFYEAW> b, RVLJZCKPUDC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x27EBB80", Offset = "0x27EAF80", VA = "0x1827EBB80", Slot = "11")]
		public void HWFIGETLHIP(Id32<LPULDJDRFFP> a, YUCPDLXANTQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x27EB8A0", Offset = "0x27EACA0", VA = "0x1827EB8A0", Slot = "12")]
		public Id32<FJSVDCFYEAW> EBCJKALLKNK(Id32<LPULDJDRFFP> a)
		{
			return default(Id32<FJSVDCFYEAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x27EC1D0", Offset = "0x27EB5D0", VA = "0x1827EC1D0", Slot = "13")]
		public Id32<XWVACCFLESD> UFJQSHXUOZW(Id32<LPULDJDRFFP> a, string b, object c, bool d, TMGZVELNEAB e, SJRCXSMXJLR f)
		{
			return default(Id32<XWVACCFLESD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x27EBDB0", Offset = "0x27EB1B0", VA = "0x1827EBDB0", Slot = "14")]
		public void MGTDCLFOEOQ(Id32<XWVACCFLESD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27EBC50", Offset = "0x27EB050", VA = "0x1827EBC50", Slot = "15")]
		public void JCNKJHGJBLQ(Id32<XWVACCFLESD> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class BCUMEVTFALE : ZVRVTWCRUTF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : YTIPMBUMKVK.IFNCQNHDDLL<VLXCXCSSZAI, BCUMEVTFALE>
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
				public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public BCUMEVTFALE root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public VLXCXCSSZAI action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x27ED160", Offset = "0x27EC560", VA = "0x1827ED160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x27ED5B0", Offset = "0x27EC9B0", VA = "0x1827ED5B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x27ECA10", Offset = "0x27EBE10", VA = "0x1827ECA10", Slot = "4")]
			public int QAGHEKWISBL(BCUMEVTFALE a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1204400", Offset = "0x1203800", VA = "0x181204400", Slot = "5")]
			public int QVHKPNEBTNR(BCUMEVTFALE a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x27ECAD0", Offset = "0x27EBED0", VA = "0x1827ECAD0", Slot = "6")]
			public int QZQQGPCSCZK(BCUMEVTFALE a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD6DF00", Offset = "0xD6D300", VA = "0x180D6DF00", Slot = "7")]
			public int VGGJFICIEUU(BCUMEVTFALE a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x27ECBC0", Offset = "0x27EBFC0", VA = "0x1827ECBC0", Slot = "8")]
			public void ZWDWZBNTLLF(BCUMEVTFALE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
			public bool GEXEXFUISJG(BCUMEVTFALE a, Id32<FJSVDCFYEAW> b, VLXCXCSSZAI[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x27ECAF0", Offset = "0x27EBEF0", VA = "0x1827ECAF0", Slot = "10")]
			public bool TJFWXNXVXYK(BCUMEVTFALE a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x27EC8D0", Offset = "0x27EBCD0", VA = "0x1827EC8D0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, RAGLFGQXJZI>> POBPBVGIKFU(BCUMEVTFALE a, Id32<FJSVDCFYEAW> b, VLXCXCSSZAI c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : YTIPMBUMKVK.GIAVPBUDCZA<ActionDeps, AUQKPBYPMDP.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps KFFNEQFMZVE
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public AUQKPBYPMDP.StaticNetSysReceiverDeps HCLLXKAIVCJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "5")]
				get
				{
					return default(AUQKPBYPMDP.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps BQEEJWMMTSM
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int WTPBHXFGQYR
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool TIDHPDTZZBE
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string FMQXCZSXHVK
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool TJFWXNXVXYK(int a);
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
			public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BCUMEVTFALE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AUQKPBYPMDP root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<FJSVDCFYEAW> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public VLXCXCSSZAI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x27ECC20", Offset = "0x27EC020", VA = "0x1827ECC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x27ECE50", Offset = "0x27EC250", VA = "0x1827ECE50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, RAGLFGQXJZI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public BCUMEVTFALE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public VLXCXCSSZAI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, RAGLFGQXJZI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x27ECEC0", Offset = "0x27EC2C0", VA = "0x1827ECEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x27ED0F0", Offset = "0x27EC4F0", VA = "0x1827ED0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private IRZKXQWFHYY<VLXCXCSSZAI, None, AUQKPBYPMDP, ActionDeps, AUQKPBYPMDP.StaticNetSysReceiverDeps, RootDeps, BCUMEVTFALE, Deps> UZFVRNRIZAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int ICCLIXBZVJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int EZBMDDRXVLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int ZMQNNXVDUAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly OQVMOUDNVEM<VLXCXCSSZAI, Result<object, RAGLFGQXJZI>> TQWPNSBQLCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OQVMOUDNVEM<VLXCXCSSZAI, Result<object, RAGLFGQXJZI>> SWKDSMSFDRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ALXXNXZFOSL MKZWHJKZWXT;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KBPQZWQDZMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x27EB3D0", Offset = "0x27EA7D0", VA = "0x1827EB3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OXYAZVQCYOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x27EB690", Offset = "0x27EAA90", VA = "0x1827EB690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int QMNNUIMXUAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x27EB6D0", Offset = "0x27EAAD0", VA = "0x1827EB6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MKRUEQPOBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x27EB390", Offset = "0x27EA790", VA = "0x1827EB390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27EB710", Offset = "0x27EAB10", VA = "0x1827EB710")]
		public BCUMEVTFALE(int a, int b, int c, OQVMOUDNVEM<VLXCXCSSZAI, Result<object, RAGLFGQXJZI>> d, OQVMOUDNVEM<VLXCXCSSZAI, Result<object, RAGLFGQXJZI>> e, ALXXNXZFOSL f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27EB540", Offset = "0x27EA940", VA = "0x1827EB540")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, RAGLFGQXJZI>> UTPQLLOACBH(AUQKPBYPMDP a, Id32<FJSVDCFYEAW> b, VLXCXCSSZAI c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27EB410", Offset = "0x27EA810", VA = "0x1827EB410", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, RAGLFGQXJZI>> POBPBVGIKFU(VLXCXCSSZAI a, bool b)
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
