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
	public sealed class MAIMPJPMWQW : IDisposable, VYUTWWCJPWH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public EBBCGXLPIMK Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, EBBCGXLPIMK receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4CD0", Offset = "0x2AF36D0", VA = "0x182AF4CD0")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class ZODONPUNYYN : KWMSJOCJUWI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> BAQSTXPDCLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> JECNXMCRPXO;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object VZEVIODPGNP
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF6DC0", Offset = "0x2AF57C0", VA = "0x182AF6DC0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E70", Offset = "0x2AF5870", VA = "0x182AF6E70")]
			public ZODONPUNYYN(RCSERIFJNPS a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E40", Offset = "0x2AF5840", VA = "0x182AF6E40", Slot = "9")]
			protected override bool XCIABATDDRH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E10", Offset = "0x2AF5810", VA = "0x182AF6E10")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string AZQBAWUBPZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<QXDOXFETTHL, CV2DynamicObject> QSQYPMIVIUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<KVBJFKAQQAH, ZODONPUNYYN> MDTJIQRQYNH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<BVHHKRGRDMC> JMPYBRFMZMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD6FF50", Offset = "0xD6E950", VA = "0x180D6FF50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BVHHKRGRDMC>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1636130", Offset = "0x1634B30", VA = "0x181636130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5F80", Offset = "0x2AF4980", VA = "0x182AF5F80")]
		public MAIMPJPMWQW(string a, Id32<BVHHKRGRDMC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF53A0", Offset = "0x2AF3DA0", VA = "0x182AF53A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5C80", Offset = "0x2AF4680", VA = "0x182AF5C80")]
		public void UUATPCZJUVU(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5D60", Offset = "0x2AF4760", VA = "0x182AF5D60")]
		public Id32<QXDOXFETTHL> WAVOYBZULAU(RRNetworkBehavior a)
		{
			return default(Id32<QXDOXFETTHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5860", Offset = "0x2AF4260", VA = "0x182AF5860")]
		public void HVFWPLUXKXG(Id32<QXDOXFETTHL> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5A60", Offset = "0x2AF4460", VA = "0x182AF5A60", Slot = "6")]
		public void RITIFJCKJLN(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF58B0", Offset = "0x2AF42B0", VA = "0x182AF58B0", Slot = "7")]
		public void QHAAXIZSLJL(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5B70", Offset = "0x2AF4570", VA = "0x182AF5B70", Slot = "8")]
		public void RURZAIYIQUK(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5DF0", Offset = "0x2AF47F0", VA = "0x182AF5DF0", Slot = "9")]
		public void XGVLXKOJEAX(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5250", Offset = "0x2AF3C50", VA = "0x182AF5250", Slot = "10")]
		public void BTWOSNSMYTL(Id32<QXDOXFETTHL> a, Id32<BVHHKRGRDMC> b, ISAERBMVTGQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5180", Offset = "0x2AF3B80", VA = "0x182AF5180", Slot = "11")]
		public void AWOAIIBQXHJ(Id32<QXDOXFETTHL> a, EBBCGXLPIMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5760", Offset = "0x2AF4160", VA = "0x182AF5760", Slot = "12")]
		public Id32<BVHHKRGRDMC> FYFOPLXQVBG(Id32<QXDOXFETTHL> a)
		{
			return default(Id32<BVHHKRGRDMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5400", Offset = "0x2AF3E00", VA = "0x182AF5400", Slot = "13")]
		public Id32<KVBJFKAQQAH> FELJHCJFCPK(Id32<QXDOXFETTHL> a, string b, object c, bool d, EWHTDQCKTSR e, KBAXVSULPAP f)
		{
			return default(Id32<KVBJFKAQQAH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5F00", Offset = "0x2AF4900", VA = "0x182AF5F00", Slot = "14")]
		public void ZXKYAUWJHVO(Id32<KVBJFKAQQAH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF57E0", Offset = "0x2AF41E0", VA = "0x182AF57E0", Slot = "15")]
		public void GLBEJTJXRFE(Id32<KVBJFKAQQAH> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class LQXYEJNYYBY : OKXJRNOVLSL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : UXOUZHAFSJC.FWOEJNVWAJL<PXBFMCKNGBK, LQXYEJNYYBY>
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
				public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public LQXYEJNYYBY root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public PXBFMCKNGBK action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2AF6910", Offset = "0x2AF5310", VA = "0x182AF6910", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF6D50", Offset = "0x2AF5750", VA = "0x182AF6D50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF61B0", Offset = "0x2AF4BB0", VA = "0x182AF61B0", Slot = "4")]
			public int KYLVYZAKZUZ(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x152A4B0", Offset = "0x1528EB0", VA = "0x18152A4B0", Slot = "5")]
			public int MZXFTEGTODR(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6270", Offset = "0x2AF4C70", VA = "0x182AF6270", Slot = "6")]
			public int NYJIWCTCCNK(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1071A50", Offset = "0x1070450", VA = "0x181071A50", Slot = "7")]
			public int KMWLZYRAKAM(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6080", Offset = "0x2AF4A80", VA = "0x182AF6080", Slot = "8")]
			public void BZOACXAHRRZ(LQXYEJNYYBY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
			public bool PXSXXPTSZAM(LQXYEJNYYBY a, Id32<BVHHKRGRDMC> b, PXBFMCKNGBK[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AF60E0", Offset = "0x2AF4AE0", VA = "0x182AF60E0", Slot = "10")]
			public bool KNXLLWQUBHM(LQXYEJNYYBY a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6290", Offset = "0x2AF4C90", VA = "0x182AF6290", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(LQXYEJNYYBY a, Id32<BVHHKRGRDMC> b, PXBFMCKNGBK c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : UXOUZHAFSJC.MDFEQTCPLCK<ActionDeps, SCQFSPRNDPD.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps CPHRSEMEXMO
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public SCQFSPRNDPD.StaticNetSysReceiverDeps KYKJOFKQEMR
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "5")]
				get
				{
					return default(SCQFSPRNDPD.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps CXRYLDTXRXC
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface TVWXLXTXIIP
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int JUSWRYVAHHX
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool ENKLODZSGBA
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string LFHDXKWMWGE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool KNXLLWQUBHM(int a);
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LQXYEJNYYBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public SCQFSPRNDPD root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<BVHHKRGRDMC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2AF63D0", Offset = "0x2AF4DD0", VA = "0x182AF63D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6600", Offset = "0x2AF5000", VA = "0x182AF6600", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LQXYEJNYYBY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6670", Offset = "0x2AF5070", VA = "0x182AF6670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF68A0", Offset = "0x2AF52A0", VA = "0x182AF68A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private CSRTKGILMEU<PXBFMCKNGBK, None, SCQFSPRNDPD, ActionDeps, SCQFSPRNDPD.StaticNetSysReceiverDeps, RootDeps, LQXYEJNYYBY, Deps> PLBJGNUDMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int AIIHXCVXYHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int KDYTLWMWBEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int CXIJLQIFFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> XUYUEVMWTRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> CMNXMBZENQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly TVWXLXTXIIP RATSQORCBWB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BURQYRWDJGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4EA0", Offset = "0x2AF38A0", VA = "0x182AF4EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TLCUSICCQQG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5050", Offset = "0x2AF3A50", VA = "0x182AF5050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BQWDYNYCWGV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4EE0", Offset = "0x2AF38E0", VA = "0x182AF4EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SHNVHKIVLOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4E60", Offset = "0x2AF3860", VA = "0x182AF4E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5090", Offset = "0x2AF3A90", VA = "0x182AF5090")]
		public LQXYEJNYYBY(int a, int b, int c, JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> d, JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> e, TVWXLXTXIIP f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4D10", Offset = "0x2AF3710", VA = "0x182AF4D10")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(SCQFSPRNDPD a, Id32<BVHHKRGRDMC> b, PXBFMCKNGBK c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4F20", Offset = "0x2AF3920", VA = "0x182AF4F20", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(PXBFMCKNGBK a, bool b)
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
