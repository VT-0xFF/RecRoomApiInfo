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
	public sealed class TXJSDEATPHX : IDisposable, SILNEZLGRTM
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HNXUMQZYUXF Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, HNXUMQZYUXF receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2D485C0", Offset = "0x2D471C0", VA = "0x182D485C0")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class ZDYICAXLZAQ : CLLIMHRVKUN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> XQEZSHUWVAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> HYAGJIGCCTH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object DYBMBACJTSY
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2D4A6B0", Offset = "0x2D492B0", VA = "0x182D4A6B0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A760", Offset = "0x2D49360", VA = "0x182D4A760")]
			public ZDYICAXLZAQ(ENGUIRZTRVL a, string b, object c, Action d, Action<object> e, Func<bool> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A700", Offset = "0x2D49300", VA = "0x182D4A700", Slot = "9")]
			protected override bool NVUYPQPPZTM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A730", Offset = "0x2D49330", VA = "0x182D4A730")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string ZXHHERYQRPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<JCZZZGYZEZI, CV2DynamicObject> KUMKPAJOIVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<DYGAYOUURZQ, ZDYICAXLZAQ> YLEPTZPARQA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<NAXUEJSETKJ> NQXKXYOLGTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xDDA760", Offset = "0xDD9360", VA = "0x180DDA760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<NAXUEJSETKJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x16F99D0", Offset = "0x16F85D0", VA = "0x1816F99D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2D49740", Offset = "0x2D48340", VA = "0x182D49740")]
		public TXJSDEATPHX(string a, Id32<NAXUEJSETKJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2D48A60", Offset = "0x2D47660", VA = "0x182D48A60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2D48D70", Offset = "0x2D47970", VA = "0x182D48D70")]
		public void LEPSMFXASBX(Id32<JCZZZGYZEZI> a, LWCFQVZRHOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2D48CE0", Offset = "0x2D478E0", VA = "0x182D48CE0")]
		public Id32<JCZZZGYZEZI> KLBAFAAOCCP(RRNetworkBehavior a)
		{
			return default(Id32<JCZZZGYZEZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2D48C10", Offset = "0x2D47810", VA = "0x182D48C10")]
		public void IFFWWMUHBJH(Id32<JCZZZGYZEZI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2D49260", Offset = "0x2D47E60", VA = "0x182D49260", Slot = "6")]
		public void UHGZUXXNTIU(Id32<JCZZZGYZEZI> a, LWCFQVZRHOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2D48FA0", Offset = "0x2D47BA0", VA = "0x182D48FA0", Slot = "7")]
		public void TDUSJHRSNIG(Id32<JCZZZGYZEZI> a, LWCFQVZRHOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2D48950", Offset = "0x2D47550", VA = "0x182D48950", Slot = "8")]
		public void BDHCBMQPJZR(Id32<JCZZZGYZEZI> a, LWCFQVZRHOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D49150", Offset = "0x2D47D50", VA = "0x182D49150", Slot = "9")]
		public void UDGDBGPKQQG(Id32<JCZZZGYZEZI> a, LWCFQVZRHOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2D48AC0", Offset = "0x2D476C0", VA = "0x182D48AC0", Slot = "10")]
		public void HVKDPAMLJUY(Id32<JCZZZGYZEZI> a, Id32<NAXUEJSETKJ> b, LWCFQVZRHOJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2D48E50", Offset = "0x2D47A50", VA = "0x182D48E50", Slot = "11")]
		public void LNXSUKGFGXW(Id32<JCZZZGYZEZI> a, HNXUMQZYUXF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2D48F20", Offset = "0x2D47B20", VA = "0x182D48F20", Slot = "12")]
		public Id32<NAXUEJSETKJ> QXGWVINWTMT(Id32<JCZZZGYZEZI> a)
		{
			return default(Id32<NAXUEJSETKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2D49370", Offset = "0x2D47F70", VA = "0x182D49370", Slot = "13")]
		public Id32<DYGAYOUURZQ> UIPCARLSUNP(Id32<JCZZZGYZEZI> a, string b, object c, QVVEGMKXHXU d, HPXOTNIQIPU e)
		{
			return default(Id32<DYGAYOUURZQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D496C0", Offset = "0x2D482C0", VA = "0x182D496C0", Slot = "14")]
		public void XONZEUNQGOL(Id32<DYGAYOUURZQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2D48C60", Offset = "0x2D47860", VA = "0x182D48C60", Slot = "15")]
		public void JCOZDKUZOMP(Id32<DYGAYOUURZQ> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UQAABPDFGBP : GGQWPRURVBI
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : CKZYRSCPJVN.CSUFSUEQYQE<FJCTCRTIJZZ, UQAABPDFGBP>
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
				public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public UQAABPDFGBP root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public FJCTCRTIJZZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2D49D80", Offset = "0x2D48980", VA = "0x182D49D80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2D4A1D0", Offset = "0x2D48DD0", VA = "0x182D4A1D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2D48600", Offset = "0x2D47200", VA = "0x182D48600", Slot = "4")]
			public int EVEAETAQEGW(UQAABPDFGBP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCDF130", Offset = "0xCDDD30", VA = "0x180CDF130", Slot = "5")]
			public int MQAMUWJMKPE(UQAABPDFGBP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2D486C0", Offset = "0x2D472C0", VA = "0x182D486C0", Slot = "6")]
			public int FOTZMWPLMIN(UQAABPDFGBP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x114AB70", Offset = "0x1149770", VA = "0x18114AB70", Slot = "7")]
			public int FLXODIRSMIZ(UQAABPDFGBP a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2D488F0", Offset = "0x2D474F0", VA = "0x182D488F0", Slot = "8")]
			public void ZUHSUOIBOVK(UQAABPDFGBP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			public bool OWYSWTKXADL(UQAABPDFGBP a, Id32<NAXUEJSETKJ> b, FJCTCRTIJZZ[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2D48820", Offset = "0x2D47420", VA = "0x182D48820", Slot = "10")]
			public bool YDIRSQIOCRR(UQAABPDFGBP a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2D486E0", Offset = "0x2D472E0", VA = "0x182D486E0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(UQAABPDFGBP a, Id32<NAXUEJSETKJ> b, FJCTCRTIJZZ c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : CKZYRSCPJVN.MQBQDZFUSGT<ActionDeps, QBUZPCMMQEU.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps UCLDKFGCKUV
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public QBUZPCMMQEU.StaticNetSysReceiverDeps RXVTFWJVISK
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "5")]
				get
				{
					return default(QBUZPCMMQEU.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps VCRSLRIZTTN
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int RIIVSVWNMVO
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool WUUQIAPXVNZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string ZICFPXBXHDZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool YDIRSQIOCRR(int a);
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public UQAABPDFGBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public QBUZPCMMQEU root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<NAXUEJSETKJ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FJCTCRTIJZZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2D49840", Offset = "0x2D48440", VA = "0x182D49840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2D49A70", Offset = "0x2D48670", VA = "0x182D49A70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public UQAABPDFGBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public FJCTCRTIJZZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2D49AE0", Offset = "0x2D486E0", VA = "0x182D49AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2D49D10", Offset = "0x2D48910", VA = "0x182D49D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MXXKGDIFLPR<FJCTCRTIJZZ, None, QBUZPCMMQEU, ActionDeps, QBUZPCMMQEU.StaticNetSysReceiverDeps, RootDeps, UQAABPDFGBP, Deps> OEGDIYQRJYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int LSJFJXRXIYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int OGLOOFNUHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int XTZRDDCTPOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly ROLVKSJBXNX<FJCTCRTIJZZ, Result<object, JGXPLWKAZER>> MUGXBSSTVCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly ROLVKSJBXNX<FJCTCRTIJZZ, Result<object, JGXPLWKAZER>> QANEAFHXAJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ZWBQGEKCHWS KOIFGESKYOE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CTPZTJZRKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A3D0", Offset = "0x2D48FD0", VA = "0x182D4A3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int XMFWTVHCFNV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A580", Offset = "0x2D49180", VA = "0x182D4A580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ACAPPMDAAZY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A410", Offset = "0x2D49010", VA = "0x182D4A410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int AIBTNVIBNTN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2D4A240", Offset = "0x2D48E40", VA = "0x182D4A240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A5C0", Offset = "0x2D491C0", VA = "0x182D4A5C0")]
		public UQAABPDFGBP(int a, int b, int c, ROLVKSJBXNX<FJCTCRTIJZZ, Result<object, JGXPLWKAZER>> d, ROLVKSJBXNX<FJCTCRTIJZZ, Result<object, JGXPLWKAZER>> e, ZWBQGEKCHWS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A280", Offset = "0x2D48E80", VA = "0x182D4A280")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, JGXPLWKAZER>> KREQFJWIICM(QBUZPCMMQEU a, Id32<NAXUEJSETKJ> b, FJCTCRTIJZZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A450", Offset = "0x2D49050", VA = "0x182D4A450", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(FJCTCRTIJZZ a, bool b)
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
