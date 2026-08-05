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
	public sealed class QBKANNVUFQI : IDisposable, UNRLRPNONNX
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HGPEHRMTQUY Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, HGPEHRMTQUY receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B080F0", Offset = "0x2B070F0", VA = "0x182B080F0")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class TARGUAKVFNJ : BKVGBBESOLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> NZYPBFCZPPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> IQZWHIKATVA;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object FJFTLXBUGFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2B09820", Offset = "0x2B08820", VA = "0x182B09820", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B098A0", Offset = "0x2B088A0", VA = "0x182B098A0")]
			public TARGUAKVFNJ(DSDVCCWMEAG a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B097F0", Offset = "0x2B087F0", VA = "0x182B097F0", Slot = "9")]
			protected override bool AUBWNTYAGOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2B09870", Offset = "0x2B08870", VA = "0x182B09870")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string BIQOKFJBJAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<STFYXSIYFLB, CV2DynamicObject> YYDJZGSMSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<CAFZYIVHGER, TARGUAKVFNJ> SVQOEHSGNMT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<GEJEFIAWMNS> EJOGSUGHHAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xDA88E0", Offset = "0xDA78E0", VA = "0x180DA88E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GEJEFIAWMNS>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1658A10", Offset = "0x1657A10", VA = "0x181658A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B08F30", Offset = "0x2B07F30", VA = "0x182B08F30")]
		public QBKANNVUFQI(string a, Id32<GEJEFIAWMNS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B08130", Offset = "0x2B07130", VA = "0x182B08130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B08B40", Offset = "0x2B07B40", VA = "0x182B08B40")]
		public void PTRNNMOEMXW(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B08260", Offset = "0x2B07260", VA = "0x182B08260")]
		public Id32<STFYXSIYFLB> GEQNJWISKJQ(RRNetworkBehavior a)
		{
			return default(Id32<STFYXSIYFLB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B08C20", Offset = "0x2B07C20", VA = "0x182B08C20")]
		public void YBLWNRYOWAK(Id32<STFYXSIYFLB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B08C70", Offset = "0x2B07C70", VA = "0x182B08C70", Slot = "6")]
		public void ZEQRFDNRLPX(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B08D80", Offset = "0x2B07D80", VA = "0x182B08D80", Slot = "7")]
		public void ZFZWLDOPQGP(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B083F0", Offset = "0x2B073F0", VA = "0x182B083F0", Slot = "8")]
		public void KEPPLIHRJMU(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B089B0", Offset = "0x2B079B0", VA = "0x182B089B0", Slot = "9")]
		public void PBJQSLJLTQN(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B08860", Offset = "0x2B07860", VA = "0x182B08860", Slot = "10")]
		public void NTOWZLRZUKH(Id32<STFYXSIYFLB> a, Id32<GEJEFIAWMNS> b, MTKDKHURMYS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B08190", Offset = "0x2B07190", VA = "0x182B08190", Slot = "11")]
		public void FSSFSABZRBT(Id32<STFYXSIYFLB> a, HGPEHRMTQUY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B08AC0", Offset = "0x2B07AC0", VA = "0x182B08AC0", Slot = "12")]
		public Id32<GEJEFIAWMNS> PHCPYTQYJHA(Id32<STFYXSIYFLB> a)
		{
			return default(Id32<GEJEFIAWMNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B08500", Offset = "0x2B07500", VA = "0x182B08500", Slot = "13")]
		public Id32<CAFZYIVHGER> MLQFQYZZDIC(Id32<STFYXSIYFLB> a, string b, object c, bool d, CQDACIRUNTR e, THSXRYGYBAZ f)
		{
			return default(Id32<CAFZYIVHGER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B08370", Offset = "0x2B07370", VA = "0x182B08370", Slot = "14")]
		public void IPCQDHRUQVE(Id32<CAFZYIVHGER> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B082F0", Offset = "0x2B072F0", VA = "0x182B082F0", Slot = "15")]
		public void GQBBXFBEJXW(Id32<CAFZYIVHGER> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QIWRMZUKYHO : HATGOKICMKB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : BROQOKBSSNY.UPRLNBORNML<FXFJUDAMIWO, QIWRMZUKYHO>
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
				public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public QIWRMZUKYHO root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public FXFJUDAMIWO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2B09EC0", Offset = "0x2B08EC0", VA = "0x182B09EC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2B0A300", Offset = "0x2B09300", VA = "0x182B0A300", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B094A0", Offset = "0x2B084A0", VA = "0x182B094A0", Slot = "4")]
			public int ISUHCPXXNJR(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x153F040", Offset = "0x153E040", VA = "0x18153F040", Slot = "5")]
			public int LJLTCJSCRUV(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2B09630", Offset = "0x2B08630", VA = "0x182B09630", Slot = "6")]
			public int OPMHHXPBDXY(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10A11D0", Offset = "0x10A01D0", VA = "0x1810A11D0", Slot = "7")]
			public int MKIJDGTQQXU(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2B09790", Offset = "0x2B08790", VA = "0x182B09790", Slot = "8")]
			public void XXFVRELNXMN(QIWRMZUKYHO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "9")]
			public bool PXYHTECPKJE(QIWRMZUKYHO a, Id32<GEJEFIAWMNS> b, FXFJUDAMIWO[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2B09560", Offset = "0x2B08560", VA = "0x182B09560", Slot = "10")]
			public bool KZQFYOPIDAU(QIWRMZUKYHO a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2B09650", Offset = "0x2B08650", VA = "0x182B09650", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, LYQWSZGLQZW>> VLZIGITBNZG(QIWRMZUKYHO a, Id32<GEJEFIAWMNS> b, FXFJUDAMIWO c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : BROQOKBSSNY.VCVAKIZRWMY<ActionDeps, XXEAPKVABFJ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps BXKHZXHDMFC
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public XXEAPKVABFJ.StaticNetSysReceiverDeps EBLJZQQZUXJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "5")]
				get
				{
					return default(XXEAPKVABFJ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps KHZDEXQAAHY
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int ETSPTOBSNLJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool FLNWECYHKHG
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string UJMDUVFAAEG
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool KZQFYOPIDAU(int a);
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
			public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public QIWRMZUKYHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public XXEAPKVABFJ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<GEJEFIAWMNS> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FXFJUDAMIWO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2B09980", Offset = "0x2B08980", VA = "0x182B09980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2B09BB0", Offset = "0x2B08BB0", VA = "0x182B09BB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, LYQWSZGLQZW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public QIWRMZUKYHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public FXFJUDAMIWO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, LYQWSZGLQZW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2B09C20", Offset = "0x2B08C20", VA = "0x182B09C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2B09E50", Offset = "0x2B08E50", VA = "0x182B09E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private SXRNIEEEUUS<FXFJUDAMIWO, None, XXEAPKVABFJ, ActionDeps, XXEAPKVABFJ.StaticNetSysReceiverDeps, RootDeps, QIWRMZUKYHO, Deps> LQRVLOPHYNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int PVNTDLHYBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int OATURXZQQZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int SSYCFOVMSHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> XXXAIFZJGXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> KNZUBJHAFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ODRSNXNZSZX XBSGLFJHVQL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GMPVOLCLLXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2B09200", Offset = "0x2B08200", VA = "0x182B09200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JSEQOAZADSI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2B091C0", Offset = "0x2B081C0", VA = "0x182B091C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int FDELJKPQFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2B09030", Offset = "0x2B08030", VA = "0x182B09030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int QKOVIXMJIQW
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B09240", Offset = "0x2B08240", VA = "0x182B09240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B093B0", Offset = "0x2B083B0", VA = "0x182B093B0")]
		public QIWRMZUKYHO(int a, int b, int c, VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> d, VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> e, ODRSNXNZSZX f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B09070", Offset = "0x2B08070", VA = "0x182B09070")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, LYQWSZGLQZW>> PWQNBYGKYEP(XXEAPKVABFJ a, Id32<GEJEFIAWMNS> b, FXFJUDAMIWO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B09280", Offset = "0x2B08280", VA = "0x182B09280", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, LYQWSZGLQZW>> VLZIGITBNZG(FXFJUDAMIWO a, bool b)
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
