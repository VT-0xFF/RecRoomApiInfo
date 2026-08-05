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
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC000", VA = "0x1810DD600")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, HGPEHRMTQUY receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AF0D90", Offset = "0x2AEF790", VA = "0x182AF0D90")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF24C0", Offset = "0x2AF0EC0", VA = "0x182AF24C0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2540", Offset = "0x2AF0F40", VA = "0x182AF2540")]
			public TARGUAKVFNJ(DSDVCCWMEAG a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2490", Offset = "0x2AF0E90", VA = "0x182AF2490", Slot = "9")]
			protected override bool AUBWNTYAGOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2510", Offset = "0x2AF0F10", VA = "0x182AF2510")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8D3C0", Offset = "0xD8BDC0", VA = "0x180D8D3C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GEJEFIAWMNS>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x163CED0", Offset = "0x163B8D0", VA = "0x18163CED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1BD0", Offset = "0x2AF05D0", VA = "0x182AF1BD0")]
		public QBKANNVUFQI(string a, Id32<GEJEFIAWMNS> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0DD0", Offset = "0x2AEF7D0", VA = "0x182AF0DD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF17E0", Offset = "0x2AF01E0", VA = "0x182AF17E0")]
		public void PTRNNMOEMXW(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F00", Offset = "0x2AEF900", VA = "0x182AF0F00")]
		public Id32<STFYXSIYFLB> GEQNJWISKJQ(RRNetworkBehavior a)
		{
			return default(Id32<STFYXSIYFLB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF18C0", Offset = "0x2AF02C0", VA = "0x182AF18C0")]
		public void YBLWNRYOWAK(Id32<STFYXSIYFLB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1910", Offset = "0x2AF0310", VA = "0x182AF1910", Slot = "6")]
		public void ZEQRFDNRLPX(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1A20", Offset = "0x2AF0420", VA = "0x182AF1A20", Slot = "7")]
		public void ZFZWLDOPQGP(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1090", Offset = "0x2AEFA90", VA = "0x182AF1090", Slot = "8")]
		public void KEPPLIHRJMU(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1650", Offset = "0x2AF0050", VA = "0x182AF1650", Slot = "9")]
		public void PBJQSLJLTQN(Id32<STFYXSIYFLB> a, MTKDKHURMYS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1500", Offset = "0x2AEFF00", VA = "0x182AF1500", Slot = "10")]
		public void NTOWZLRZUKH(Id32<STFYXSIYFLB> a, Id32<GEJEFIAWMNS> b, MTKDKHURMYS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0E30", Offset = "0x2AEF830", VA = "0x182AF0E30", Slot = "11")]
		public void FSSFSABZRBT(Id32<STFYXSIYFLB> a, HGPEHRMTQUY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1760", Offset = "0x2AF0160", VA = "0x182AF1760", Slot = "12")]
		public Id32<GEJEFIAWMNS> PHCPYTQYJHA(Id32<STFYXSIYFLB> a)
		{
			return default(Id32<GEJEFIAWMNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF11A0", Offset = "0x2AEFBA0", VA = "0x182AF11A0", Slot = "13")]
		public Id32<CAFZYIVHGER> MLQFQYZZDIC(Id32<STFYXSIYFLB> a, string b, object c, bool d, CQDACIRUNTR e, THSXRYGYBAZ f)
		{
			return default(Id32<CAFZYIVHGER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1010", Offset = "0x2AEFA10", VA = "0x182AF1010", Slot = "14")]
		public void IPCQDHRUQVE(Id32<CAFZYIVHGER> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F90", Offset = "0x2AEF990", VA = "0x182AF0F90", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x2AF2B60", Offset = "0x2AF1560", VA = "0x182AF2B60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF2FA0", Offset = "0x2AF19A0", VA = "0x182AF2FA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2140", Offset = "0x2AF0B40", VA = "0x182AF2140", Slot = "4")]
			public int ISUHCPXXNJR(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1522A10", Offset = "0x1521410", VA = "0x181522A10", Slot = "5")]
			public int LJLTCJSCRUV(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF22D0", Offset = "0x2AF0CD0", VA = "0x182AF22D0", Slot = "6")]
			public int OPMHHXPBDXY(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10854F0", Offset = "0x1083EF0", VA = "0x1810854F0", Slot = "7")]
			public int MKIJDGTQQXU(QIWRMZUKYHO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2430", Offset = "0x2AF0E30", VA = "0x182AF2430", Slot = "8")]
			public void XXFVRELNXMN(QIWRMZUKYHO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "9")]
			public bool PXYHTECPKJE(QIWRMZUKYHO a, Id32<GEJEFIAWMNS> b, FXFJUDAMIWO[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2200", Offset = "0x2AF0C00", VA = "0x182AF2200", Slot = "10")]
			public bool KZQFYOPIDAU(QIWRMZUKYHO a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AF22F0", Offset = "0x2AF0CF0", VA = "0x182AF22F0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public XXEAPKVABFJ.StaticNetSysReceiverDeps EBLJZQQZUXJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "5")]
				get
				{
					return default(XXEAPKVABFJ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps KHZDEXQAAHY
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF2620", Offset = "0x2AF1020", VA = "0x182AF2620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2850", Offset = "0x2AF1250", VA = "0x182AF2850", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF28C0", Offset = "0x2AF12C0", VA = "0x182AF28C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2AF0", Offset = "0x2AF14F0", VA = "0x182AF2AF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF1EA0", Offset = "0x2AF08A0", VA = "0x182AF1EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JSEQOAZADSI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1E60", Offset = "0x2AF0860", VA = "0x182AF1E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int FDELJKPQFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1CD0", Offset = "0x2AF06D0", VA = "0x182AF1CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int QKOVIXMJIQW
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF1EE0", Offset = "0x2AF08E0", VA = "0x182AF1EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2050", Offset = "0x2AF0A50", VA = "0x182AF2050")]
		public QIWRMZUKYHO(int a, int b, int c, VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> d, VZFXAYHJZPI<FXFJUDAMIWO, Result<object, LYQWSZGLQZW>> e, ODRSNXNZSZX f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1D10", Offset = "0x2AF0710", VA = "0x182AF1D10")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, LYQWSZGLQZW>> PWQNBYGKYEP(XXEAPKVABFJ a, Id32<GEJEFIAWMNS> b, FXFJUDAMIWO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1F20", Offset = "0x2AF0920", VA = "0x182AF1F20", Slot = "4")]
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
