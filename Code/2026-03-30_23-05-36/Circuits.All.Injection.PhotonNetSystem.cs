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
	public sealed class OBAXXFTDSTW : IDisposable, DJMRNOIPAQN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HBZQSXBMNSY Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, HBZQSXBMNSY receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28AF4F0", Offset = "0x28AE2F0", VA = "0x1828AF4F0")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class TRXVCTQCGRN : ZNBKDMMEHNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> QHHHHIYMSJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> ADNDMUVJAFM;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object GSFISKTEGFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x28B0C50", Offset = "0x28AFA50", VA = "0x1828B0C50", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x28B0CA0", Offset = "0x28AFAA0", VA = "0x1828B0CA0")]
			public TRXVCTQCGRN(OQBWNKEZELI a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x28B0C20", Offset = "0x28AFA20", VA = "0x1828B0C20", Slot = "9")]
			protected override bool TMJIWVLRJNV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x28B0BF0", Offset = "0x28AF9F0", VA = "0x1828B0BF0")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string CVNLNMMVFRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<UEWLFKNRYNB, CV2DynamicObject> BJFCNKDTBGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<GDGSZWIIVHX, TRXVCTQCGRN> LSIIESKPMOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<YMXYNUJKSYU> TBEAKAQOFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB64900", Offset = "0xB63700", VA = "0x180B64900", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YMXYNUJKSYU>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1413870", Offset = "0x1412670", VA = "0x181413870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28B07A0", Offset = "0x28AF5A0", VA = "0x1828B07A0")]
		public OBAXXFTDSTW(string a, Id32<YMXYNUJKSYU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28AFA30", Offset = "0x28AE830", VA = "0x1828AFA30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28B0310", Offset = "0x28AF110", VA = "0x1828B0310")]
		public void SMNOHUGAGZS(Id32<UEWLFKNRYNB> a, IDXWQJYKOQK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28AF9A0", Offset = "0x28AE7A0", VA = "0x1828AF9A0")]
		public Id32<UEWLFKNRYNB> CPCGHDDCRIG(RRNetworkBehavior a)
		{
			return default(Id32<UEWLFKNRYNB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28AFC40", Offset = "0x28AEA40", VA = "0x1828AFC40")]
		public void FYAQLWNTVZU(Id32<UEWLFKNRYNB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28B0580", Offset = "0x28AF380", VA = "0x1828B0580", Slot = "6")]
		public void WYGYNYDGAXT(Id32<UEWLFKNRYNB> a, IDXWQJYKOQK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28AFA90", Offset = "0x28AE890", VA = "0x1828AFA90", Slot = "7")]
		public void EIUTMHOOIYL(Id32<UEWLFKNRYNB> a, IDXWQJYKOQK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28B0690", Offset = "0x28AF490", VA = "0x1828B0690", Slot = "8")]
		public void ZHYDGNGSAGE(Id32<UEWLFKNRYNB> a, IDXWQJYKOQK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0470", Offset = "0x28AF270", VA = "0x1828B0470", Slot = "9")]
		public void WLZSTBUKAMR(Id32<UEWLFKNRYNB> a, IDXWQJYKOQK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28B0140", Offset = "0x28AEF40", VA = "0x1828B0140", Slot = "10")]
		public void QXTKMOFUZYH(Id32<UEWLFKNRYNB> a, Id32<YMXYNUJKSYU> b, IDXWQJYKOQK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28AFFF0", Offset = "0x28AEDF0", VA = "0x1828AFFF0", Slot = "11")]
		public void JWTUJWGEWUB(Id32<UEWLFKNRYNB> a, HBZQSXBMNSY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B03F0", Offset = "0x28AF1F0", VA = "0x1828B03F0", Slot = "12")]
		public Id32<YMXYNUJKSYU> UUPVHBNUNPY(Id32<UEWLFKNRYNB> a)
		{
			return default(Id32<YMXYNUJKSYU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28AFC90", Offset = "0x28AEA90", VA = "0x1828AFC90", Slot = "13")]
		public Id32<GDGSZWIIVHX> HRCUHZGADMK(Id32<UEWLFKNRYNB> a, string b, object c, bool d, CJRDZWTLPWL e, MVVQZZKTVAZ f)
		{
			return default(Id32<GDGSZWIIVHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28B00C0", Offset = "0x28AEEC0", VA = "0x1828B00C0", Slot = "14")]
		public void NHRDYOCNMNE(Id32<GDGSZWIIVHX> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B0290", Offset = "0x28AF090", VA = "0x1828B0290", Slot = "15")]
		public void RAIPXELYWUY(Id32<GDGSZWIIVHX> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class IHMSQPLNRQQ : LNVUNUKFJTD
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : MTGYOANFZQO.BMXMFFKRFMT<CLHMCDDVOKO, IHMSQPLNRQQ>
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
				public AsyncTaskMethodBuilder<Result<object, WWZNUEBGASM>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public IHMSQPLNRQQ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public CLHMCDDVOKO action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, WWZNUEBGASM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28B12C0", Offset = "0x28B00C0", VA = "0x1828B12C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x28B1700", Offset = "0x28B0500", VA = "0x1828B1700", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28B0AD0", Offset = "0x28AF8D0", VA = "0x1828B0AD0", Slot = "4")]
			public int SHOUXIGTKWT(IHMSQPLNRQQ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x12F8C70", Offset = "0x12F7A70", VA = "0x1812F8C70", Slot = "5")]
			public int MFCPLENTLNT(IHMSQPLNRQQ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28B08A0", Offset = "0x28AF6A0", VA = "0x1828B08A0", Slot = "6")]
			public int DHHZZBCSLRE(IHMSQPLNRQQ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE5CD10", Offset = "0xE5BB10", VA = "0x180E5CD10", Slot = "7")]
			public int MGHDHCGGZKK(IHMSQPLNRQQ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x28B0B90", Offset = "0x28AF990", VA = "0x1828B0B90", Slot = "8")]
			public void UWGJWGDHJYF(IHMSQPLNRQQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "9")]
			public bool STFLURDMCDQ(IHMSQPLNRQQ a, Id32<YMXYNUJKSYU> b, CLHMCDDVOKO[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x28B08C0", Offset = "0x28AF6C0", VA = "0x1828B08C0", Slot = "10")]
			public bool KGIYFPYVGDK(IHMSQPLNRQQ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x28B0990", Offset = "0x28AF790", VA = "0x1828B0990", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, WWZNUEBGASM>> MDBEZPKEWEE(IHMSQPLNRQQ a, Id32<YMXYNUJKSYU> b, CLHMCDDVOKO c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : MTGYOANFZQO.ZSAXAUTJBCY<ActionDeps, QYNLRMWOSJV.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps HVBHFWILFVG
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public QYNLRMWOSJV.StaticNetSysReceiverDeps GLSTCLQFCRF
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "5")]
				get
				{
					return default(QYNLRMWOSJV.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps LDXMZWETNZA
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface WROGKVZRMEZ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int ZEYMCOWNPGD
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool OAOBVDGWPOM
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string SLCLJROZFEC
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool KGIYFPYVGDK(int a);
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
			public AsyncTaskMethodBuilder<Result<object, WWZNUEBGASM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IHMSQPLNRQQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public QYNLRMWOSJV root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<YMXYNUJKSYU> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CLHMCDDVOKO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, WWZNUEBGASM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28B0D80", Offset = "0x28AFB80", VA = "0x1828B0D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x28B0FB0", Offset = "0x28AFDB0", VA = "0x1828B0FB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, WWZNUEBGASM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IHMSQPLNRQQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public CLHMCDDVOKO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, WWZNUEBGASM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x28B1020", Offset = "0x28AFE20", VA = "0x1828B1020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x28B1250", Offset = "0x28B0050", VA = "0x1828B1250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private CDSOWDOGPFE<CLHMCDDVOKO, None, QYNLRMWOSJV, ActionDeps, QYNLRMWOSJV.StaticNetSysReceiverDeps, RootDeps, IHMSQPLNRQQ, Deps> FNWSXRLSEVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int ZRXOMWGFPAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int TDGILJUOKGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int QZFOVAHDQEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly BPOKYGJNLFM<CLHMCDDVOKO, Result<object, WWZNUEBGASM>> EFZKDNHATJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly BPOKYGJNLFM<CLHMCDDVOKO, Result<object, WWZNUEBGASM>> IXUZZQIBSMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly WROGKVZRMEZ PDDKCLIEEXJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LGNSLNJBMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x28AF7F0", Offset = "0x28AE5F0", VA = "0x1828AF7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LQYKGDWYQOU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28AF7B0", Offset = "0x28AE5B0", VA = "0x1828AF7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int WCKRNKTCGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x28AF870", Offset = "0x28AE670", VA = "0x1828AF870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int INRWHLQRCSS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28AF830", Offset = "0x28AE630", VA = "0x1828AF830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28AF8B0", Offset = "0x28AE6B0", VA = "0x1828AF8B0")]
		public IHMSQPLNRQQ(int a, int b, int c, BPOKYGJNLFM<CLHMCDDVOKO, Result<object, WWZNUEBGASM>> d, BPOKYGJNLFM<CLHMCDDVOKO, Result<object, WWZNUEBGASM>> e, WROGKVZRMEZ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF530", Offset = "0x28AE330", VA = "0x1828AF530")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, WWZNUEBGASM>> ATPWSFXBBLF(QYNLRMWOSJV a, Id32<YMXYNUJKSYU> b, CLHMCDDVOKO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28AF680", Offset = "0x28AE480", VA = "0x1828AF680", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, WWZNUEBGASM>> MDBEZPKEWEE(CLHMCDDVOKO a, bool b)
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
