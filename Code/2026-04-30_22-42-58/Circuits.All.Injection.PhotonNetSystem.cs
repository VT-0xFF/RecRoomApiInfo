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
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, EBBCGXLPIMK receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5AA0", Offset = "0x2AF4EA0", VA = "0x182AF5AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2AF7BC0", Offset = "0x2AF6FC0", VA = "0x182AF7BC0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7C70", Offset = "0x2AF7070", VA = "0x182AF7C70")]
			public ZODONPUNYYN(RCSERIFJNPS a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7C40", Offset = "0x2AF7040", VA = "0x182AF7C40", Slot = "9")]
			protected override bool XCIABATDDRH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7C10", Offset = "0x2AF7010", VA = "0x182AF7C10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8DF10", Offset = "0xD8D310", VA = "0x180D8DF10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BVHHKRGRDMC>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1647490", Offset = "0x1646890", VA = "0x181647490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6D60", Offset = "0x2AF6160", VA = "0x182AF6D60")]
		public MAIMPJPMWQW(string a, Id32<BVHHKRGRDMC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6170", Offset = "0x2AF5570", VA = "0x182AF6170", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6A60", Offset = "0x2AF5E60", VA = "0x182AF6A60")]
		public void UUATPCZJUVU(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6B40", Offset = "0x2AF5F40", VA = "0x182AF6B40")]
		public Id32<QXDOXFETTHL> WAVOYBZULAU(RRNetworkBehavior a)
		{
			return default(Id32<QXDOXFETTHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6640", Offset = "0x2AF5A40", VA = "0x182AF6640")]
		public void HVFWPLUXKXG(Id32<QXDOXFETTHL> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6840", Offset = "0x2AF5C40", VA = "0x182AF6840", Slot = "6")]
		public void RITIFJCKJLN(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6690", Offset = "0x2AF5A90", VA = "0x182AF6690", Slot = "7")]
		public void QHAAXIZSLJL(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6950", Offset = "0x2AF5D50", VA = "0x182AF6950", Slot = "8")]
		public void RURZAIYIQUK(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6BD0", Offset = "0x2AF5FD0", VA = "0x182AF6BD0", Slot = "9")]
		public void XGVLXKOJEAX(Id32<QXDOXFETTHL> a, ISAERBMVTGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6020", Offset = "0x2AF5420", VA = "0x182AF6020", Slot = "10")]
		public void BTWOSNSMYTL(Id32<QXDOXFETTHL> a, Id32<BVHHKRGRDMC> b, ISAERBMVTGQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5F50", Offset = "0x2AF5350", VA = "0x182AF5F50", Slot = "11")]
		public void AWOAIIBQXHJ(Id32<QXDOXFETTHL> a, EBBCGXLPIMK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6540", Offset = "0x2AF5940", VA = "0x182AF6540", Slot = "12")]
		public Id32<BVHHKRGRDMC> FYFOPLXQVBG(Id32<QXDOXFETTHL> a)
		{
			return default(Id32<BVHHKRGRDMC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61D0", Offset = "0x2AF55D0", VA = "0x182AF61D0", Slot = "13")]
		public Id32<KVBJFKAQQAH> FELJHCJFCPK(Id32<QXDOXFETTHL> a, string b, object c, bool d, EWHTDQCKTSR e, KBAXVSULPAP f)
		{
			return default(Id32<KVBJFKAQQAH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6CE0", Offset = "0x2AF60E0", VA = "0x182AF6CE0", Slot = "14")]
		public void ZXKYAUWJHVO(Id32<KVBJFKAQQAH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF65C0", Offset = "0x2AF59C0", VA = "0x182AF65C0", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x2AF7700", Offset = "0x2AF6B00", VA = "0x182AF7700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2AF7B50", Offset = "0x2AF6F50", VA = "0x182AF7B50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6F90", Offset = "0x2AF6390", VA = "0x182AF6F90", Slot = "4")]
			public int KYLVYZAKZUZ(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x153C820", Offset = "0x153BC20", VA = "0x18153C820", Slot = "5")]
			public int MZXFTEGTODR(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7060", Offset = "0x2AF6460", VA = "0x182AF7060", Slot = "6")]
			public int NYJIWCTCCNK(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10877A0", Offset = "0x1086BA0", VA = "0x1810877A0", Slot = "7")]
			public int KMWLZYRAKAM(LQXYEJNYYBY a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E60", Offset = "0x2AF6260", VA = "0x182AF6E60", Slot = "8")]
			public void BZOACXAHRRZ(LQXYEJNYYBY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			public bool PXSXXPTSZAM(LQXYEJNYYBY a, Id32<BVHHKRGRDMC> b, PXBFMCKNGBK[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6EC0", Offset = "0x2AF62C0", VA = "0x182AF6EC0", Slot = "10")]
			public bool KNXLLWQUBHM(LQXYEJNYYBY a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7080", Offset = "0x2AF6480", VA = "0x182AF7080", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public SCQFSPRNDPD.StaticNetSysReceiverDeps KYKJOFKQEMR
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "5")]
				get
				{
					return default(SCQFSPRNDPD.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps CXRYLDTXRXC
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF71C0", Offset = "0x2AF65C0", VA = "0x182AF71C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2AF73F0", Offset = "0x2AF67F0", VA = "0x182AF73F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF7460", Offset = "0x2AF6860", VA = "0x182AF7460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7690", Offset = "0x2AF6A90", VA = "0x182AF7690", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF5C70", Offset = "0x2AF5070", VA = "0x182AF5C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TLCUSICCQQG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5E20", Offset = "0x2AF5220", VA = "0x182AF5E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BQWDYNYCWGV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5CB0", Offset = "0x2AF50B0", VA = "0x182AF5CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int SHNVHKIVLOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5C30", Offset = "0x2AF5030", VA = "0x182AF5C30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E60", Offset = "0x2AF5260", VA = "0x182AF5E60")]
		public LQXYEJNYYBY(int a, int b, int c, JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> d, JWLEHDRUXAM<PXBFMCKNGBK, Result<object, SKKNIPYCQUO>> e, TVWXLXTXIIP f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5AE0", Offset = "0x2AF4EE0", VA = "0x182AF5AE0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(SCQFSPRNDPD a, Id32<BVHHKRGRDMC> b, PXBFMCKNGBK c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5CF0", Offset = "0x2AF50F0", VA = "0x182AF5CF0", Slot = "4")]
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
