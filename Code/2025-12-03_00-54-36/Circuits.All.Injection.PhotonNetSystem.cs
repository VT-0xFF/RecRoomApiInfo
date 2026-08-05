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
	public sealed class DNWVZMEIZSP : IDisposable, LYKTLMTPRMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public SBXFSVIVCAZ Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, SBXFSVIVCAZ receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x281BB60", Offset = "0x281A760", VA = "0x18281BB60")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class BRCVJCZRFWW : CZFSATCABIX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> QVWOTQBDQCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> FIZRIUQBNMP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object ZZILBUZQHDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x281BA00", Offset = "0x281A600", VA = "0x18281BA00", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x281BA80", Offset = "0x281A680", VA = "0x18281BA80")]
			public BRCVJCZRFWW(CCOVUQOLKKP a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x281B9D0", Offset = "0x281A5D0", VA = "0x18281B9D0", Slot = "9")]
			protected override bool NCXQNSUSOPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x281BA50", Offset = "0x281A650", VA = "0x18281BA50")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string UNRJXEKCAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<KJUTVDVUHQM, CV2DynamicObject> TLWHOWMVXTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<DUXMLVOEJNS, BRCVJCZRFWW> AUEFNXVHPMO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<VXOAABITZCX> PNPKCJIEICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xC80A20", Offset = "0xC7F620", VA = "0x180C80A20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<VXOAABITZCX>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1321C30", Offset = "0x1320830", VA = "0x181321C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x281C9B0", Offset = "0x281B5B0", VA = "0x18281C9B0")]
		public DNWVZMEIZSP(string a, Id32<VXOAABITZCX> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x281BD40", Offset = "0x281A940", VA = "0x18281BD40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x281C510", Offset = "0x281B110", VA = "0x18281C510")]
		public void QPJZCWPOUDZ(Id32<KJUTVDVUHQM> a, TWKJOSGKHLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x281BBA0", Offset = "0x281A7A0", VA = "0x18281BBA0")]
		public Id32<KJUTVDVUHQM> BROFAMAUDON(RRNetworkBehavior a)
		{
			return default(Id32<KJUTVDVUHQM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x281BDA0", Offset = "0x281A9A0", VA = "0x18281BDA0")]
		public void GHPQRRTQKTF(Id32<KJUTVDVUHQM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x281C400", Offset = "0x281B000", VA = "0x18281C400", Slot = "6")]
		public void QODAQMFCCLU(Id32<KJUTVDVUHQM> a, TWKJOSGKHLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x281C700", Offset = "0x281B300", VA = "0x18281C700", Slot = "7")]
		public void SLWIPBHXRGU(Id32<KJUTVDVUHQM> a, TWKJOSGKHLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x281C5F0", Offset = "0x281B1F0", VA = "0x18281C5F0", Slot = "8")]
		public void RGWAHLQYUDX(Id32<KJUTVDVUHQM> a, TWKJOSGKHLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x281BC30", Offset = "0x281A830", VA = "0x18281BC30", Slot = "9")]
		public void DXRPSLBIQDK(Id32<KJUTVDVUHQM> a, TWKJOSGKHLZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x281BDF0", Offset = "0x281A9F0", VA = "0x18281BDF0", Slot = "10")]
		public void JOWKKNPQVLM(Id32<KJUTVDVUHQM> a, Id32<VXOAABITZCX> b, TWKJOSGKHLZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x281C2B0", Offset = "0x281AEB0", VA = "0x18281C2B0", Slot = "11")]
		public void OBJELSJPHLI(Id32<KJUTVDVUHQM> a, SBXFSVIVCAZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x281C8B0", Offset = "0x281B4B0", VA = "0x18281C8B0", Slot = "12")]
		public Id32<VXOAABITZCX> TZALTPGNUHH(Id32<KJUTVDVUHQM> a)
		{
			return default(Id32<VXOAABITZCX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x281BF40", Offset = "0x281AB40", VA = "0x18281BF40", Slot = "13")]
		public Id32<DUXMLVOEJNS> MPQDZMDDJZR(Id32<KJUTVDVUHQM> a, string b, object c, bool d, SIQXSFHKWGE e, BKIBIFOYVUI f)
		{
			return default(Id32<DUXMLVOEJNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x281C380", Offset = "0x281AF80", VA = "0x18281C380", Slot = "14")]
		public void OMWFCVXXKLT(Id32<DUXMLVOEJNS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x281C930", Offset = "0x281B530", VA = "0x18281C930", Slot = "15")]
		public void XUAYHYMZCRT(Id32<DUXMLVOEJNS> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class HDCUBONNWOX : BOOLTIYANOI
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : BFACBNGTTJL.ZGIMNPCIEIW<NOYQGYRQTEZ, HDCUBONNWOX>
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
				public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public HDCUBONNWOX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public NOYQGYRQTEZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x281D7C0", Offset = "0x281C3C0", VA = "0x18281D7C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x281DC00", Offset = "0x281C800", VA = "0x18281DC00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x281CF20", Offset = "0x281BB20", VA = "0x18281CF20", Slot = "4")]
			public int ATYYUNSMBGE(HDCUBONNWOX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x120BF70", Offset = "0x120AB70", VA = "0x18120BF70", Slot = "5")]
			public int WDKMPPXLGGY(HDCUBONNWOX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x281D0C0", Offset = "0x281BCC0", VA = "0x18281D0C0", Slot = "6")]
			public int IIDQNLBXFRF(HDCUBONNWOX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD74310", Offset = "0xD72F10", VA = "0x180D74310", Slot = "7")]
			public int GUZGQOYBNXF(HDCUBONNWOX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x281D220", Offset = "0x281BE20", VA = "0x18281D220", Slot = "8")]
			public void QAIXRDFEKBU(HDCUBONNWOX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "9")]
			public bool XYXZOUVUBGH(HDCUBONNWOX a, Id32<VXOAABITZCX> b, NOYQGYRQTEZ[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x281CFF0", Offset = "0x281BBF0", VA = "0x18281CFF0", Slot = "10")]
			public bool GHBKDHYPXSF(HDCUBONNWOX a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x281D0E0", Offset = "0x281BCE0", VA = "0x18281D0E0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(HDCUBONNWOX a, Id32<VXOAABITZCX> b, NOYQGYRQTEZ c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : BFACBNGTTJL.LGUBDHHAHFH<ActionDeps, TGMYLJQNIMW.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps UXRPJJYGSOT
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public TGMYLJQNIMW.StaticNetSysReceiverDeps SQUTMCRJUCQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "5")]
				get
				{
					return default(TGMYLJQNIMW.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps HGEEJBTONKJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface HGULJDEHQOI
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int HIWOZOTNARQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool ZGCCMAQYZFT
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string IIZAWZXRBWR
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool GHBKDHYPXSF(int a);
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HDCUBONNWOX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TGMYLJQNIMW root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<VXOAABITZCX> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NOYQGYRQTEZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x281D280", Offset = "0x281BE80", VA = "0x18281D280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x281D4B0", Offset = "0x281C0B0", VA = "0x18281D4B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HDCUBONNWOX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NOYQGYRQTEZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x281D520", Offset = "0x281C120", VA = "0x18281D520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x281D750", Offset = "0x281C350", VA = "0x18281D750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MTNHRKQBEEZ<NOYQGYRQTEZ, None, TGMYLJQNIMW, ActionDeps, TGMYLJQNIMW.StaticNetSysReceiverDeps, RootDeps, HDCUBONNWOX, Deps> OOQKGEWCCDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int ZHEAOJBNKEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int KDCQQOXMZJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int BKBRTFNFGWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly SWBUAODINQD<NOYQGYRQTEZ, Result<object, GGHDNJMZMXZ>> BCHBASURPOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly SWBUAODINQD<NOYQGYRQTEZ, Result<object, GGHDNJMZMXZ>> DUOAAJTKOYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HGULJDEHQOI GSCBNDREEJU;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QTTFVDNOGNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x281CDB0", Offset = "0x281B9B0", VA = "0x18281CDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PACSUDLWZZH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x281CDF0", Offset = "0x281B9F0", VA = "0x18281CDF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int WQBMWFVSJYY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x281CAB0", Offset = "0x281B6B0", VA = "0x18281CAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int KDNBSMRZYKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x281CD70", Offset = "0x281B970", VA = "0x18281CD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x281CE30", Offset = "0x281BA30", VA = "0x18281CE30")]
		public HDCUBONNWOX(int a, int b, int c, SWBUAODINQD<NOYQGYRQTEZ, Result<object, GGHDNJMZMXZ>> d, SWBUAODINQD<NOYQGYRQTEZ, Result<object, GGHDNJMZMXZ>> e, HGULJDEHQOI f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x281CAF0", Offset = "0x281B6F0", VA = "0x18281CAF0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, GGHDNJMZMXZ>> FXWPUQGUJCW(TGMYLJQNIMW a, Id32<VXOAABITZCX> b, NOYQGYRQTEZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x281CC40", Offset = "0x281B840", VA = "0x18281CC40", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(NOYQGYRQTEZ a, bool b)
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
