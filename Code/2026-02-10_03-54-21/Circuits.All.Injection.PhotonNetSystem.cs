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
	public sealed class RUOJUIUYFFK : IDisposable, KDTPHZGDKFX
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public UONXEOOHNDK Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, UONXEOOHNDK receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x287A470", Offset = "0x2879670", VA = "0x18287A470")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class QNETCXNULLZ : JJFNUFKEFJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> MSHNCYNLANL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> HKMLTTKGPAG;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object OAVHUUDPALB
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x287A4E0", Offset = "0x28796E0", VA = "0x18287A4E0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x287A560", Offset = "0x2879760", VA = "0x18287A560")]
			public QNETCXNULLZ(BAHQEQVTEDE a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x287A4B0", Offset = "0x28796B0", VA = "0x18287A4B0", Slot = "9")]
			protected override bool AAIFTDEXDKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x287A530", Offset = "0x2879730", VA = "0x18287A530")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string QKUCWJOPPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<EWGMMJRBQBF, CV2DynamicObject> DBCWBUQIZWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<YEBAVXANZUR, QNETCXNULLZ> WIWOVSXEYPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<WBUFIROFFZC> SFCNOYKIGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB33070", Offset = "0xB32270", VA = "0x180B33070", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WBUFIROFFZC>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x13D57D0", Offset = "0x13D49D0", VA = "0x1813D57D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x287B440", Offset = "0x287A640", VA = "0x18287B440")]
		public RUOJUIUYFFK(string a, Id32<WBUFIROFFZC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x287A640", Offset = "0x2879840", VA = "0x18287A640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x287ABE0", Offset = "0x2879DE0", VA = "0x18287ABE0")]
		public void LOGIQLHLVHW(Id32<EWGMMJRBQBF> a, JTJUXJHUUIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x287AB50", Offset = "0x2879D50", VA = "0x18287AB50")]
		public Id32<EWGMMJRBQBF> JKSHMJDUPXM(RRNetworkBehavior a)
		{
			return default(Id32<EWGMMJRBQBF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x287B150", Offset = "0x287A350", VA = "0x18287B150")]
		public void TZKMEBTZRYS(Id32<EWGMMJRBQBF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x287B330", Offset = "0x287A530", VA = "0x18287B330", Slot = "6")]
		public void ZXOGBJIVFHT(Id32<EWGMMJRBQBF> a, JTJUXJHUUIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x287AFA0", Offset = "0x287A1A0", VA = "0x18287AFA0", Slot = "7")]
		public void QUFIGGIYNTV(Id32<EWGMMJRBQBF> a, JTJUXJHUUIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x287AE90", Offset = "0x287A090", VA = "0x18287AE90", Slot = "8")]
		public void QQVWDFMOAWA(Id32<EWGMMJRBQBF> a, JTJUXJHUUIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x287B220", Offset = "0x287A420", VA = "0x18287B220", Slot = "9")]
		public void WFKQXGSMYIV(Id32<EWGMMJRBQBF> a, JTJUXJHUUIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x287AD40", Offset = "0x2879F40", VA = "0x18287AD40", Slot = "10")]
		public void OESUDQEJDIL(Id32<EWGMMJRBQBF> a, Id32<WBUFIROFFZC> b, JTJUXJHUUIO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x287A720", Offset = "0x2879920", VA = "0x18287A720", Slot = "11")]
		public void JIBXTVCKECJ(Id32<EWGMMJRBQBF> a, UONXEOOHNDK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x287A6A0", Offset = "0x28798A0", VA = "0x18287A6A0", Slot = "12")]
		public Id32<WBUFIROFFZC> GOEFGJWDJBA(Id32<EWGMMJRBQBF> a)
		{
			return default(Id32<WBUFIROFFZC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x287A7F0", Offset = "0x28799F0", VA = "0x18287A7F0", Slot = "13")]
		public Id32<YEBAVXANZUR> JKRDGKHTGUS(Id32<EWGMMJRBQBF> a, string b, object c, bool d, SENDBEGBGCT e, OKDUMEVVPFL f)
		{
			return default(Id32<YEBAVXANZUR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x287B1A0", Offset = "0x287A3A0", VA = "0x18287B1A0", Slot = "14")]
		public void UKIWYYPDBJU(Id32<YEBAVXANZUR> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x287ACC0", Offset = "0x2879EC0", VA = "0x18287ACC0", Slot = "15")]
		public void OBPCQLHPYMM(Id32<YEBAVXANZUR> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UGFZIBWVBJS : DLOXXYQFPRD
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : EFFEKHEHDBI.SPPQSEQBPDZ<USPEKNRWVPE, UGFZIBWVBJS>
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
				public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public UGFZIBWVBJS root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public USPEKNRWVPE action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x287BDD0", Offset = "0x287AFD0", VA = "0x18287BDD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x287C210", Offset = "0x287B410", VA = "0x18287C210", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x287B6A0", Offset = "0x287A8A0", VA = "0x18287B6A0", Slot = "4")]
			public int OJMFVDRGOBB(UGFZIBWVBJS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x12BEC30", Offset = "0x12BDE30", VA = "0x1812BEC30", Slot = "5")]
			public int FMSITNXPEGZ(UGFZIBWVBJS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x287B540", Offset = "0x287A740", VA = "0x18287B540", Slot = "6")]
			public int DJXILAZTWKS(UGFZIBWVBJS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE2CC90", Offset = "0xE2BE90", VA = "0x180E2CC90", Slot = "7")]
			public int DZYFWPRONGG(UGFZIBWVBJS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x287B760", Offset = "0x287A960", VA = "0x18287B760", Slot = "8")]
			public void TMVLAUPQAPH(UGFZIBWVBJS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "9")]
			public bool TVUSOXTFEZQ(UGFZIBWVBJS a, Id32<WBUFIROFFZC> b, USPEKNRWVPE[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x287B7C0", Offset = "0x287A9C0", VA = "0x18287B7C0", Slot = "10")]
			public bool VTCUAOWZHAA(UGFZIBWVBJS a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x287B560", Offset = "0x287A760", VA = "0x18287B560", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(UGFZIBWVBJS a, Id32<WBUFIROFFZC> b, USPEKNRWVPE c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : EFFEKHEHDBI.IRGRAGFCDUQ<ActionDeps, RRHCIMKELZN.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps FZGUDAFCUUI
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public RRHCIMKELZN.StaticNetSysReceiverDeps URLACMZNMGP
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "5")]
				get
				{
					return default(RRHCIMKELZN.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps OEQZUDEYNPI
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ELSNTWPCDON
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int ZDJGKGRUPDN
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool SWZIVJZFZVS
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string BBDSLQBNKIS
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool VTCUAOWZHAA(int a);
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
			public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public UGFZIBWVBJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public RRHCIMKELZN root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<WBUFIROFFZC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x287B890", Offset = "0x287AA90", VA = "0x18287B890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x287BAC0", Offset = "0x287ACC0", VA = "0x18287BAC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public UGFZIBWVBJS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x287BB30", Offset = "0x287AD30", VA = "0x18287BB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x287BD60", Offset = "0x287AF60", VA = "0x18287BD60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private VJFYTYEQCPQ<USPEKNRWVPE, None, RRHCIMKELZN, ActionDeps, RRHCIMKELZN.StaticNetSysReceiverDeps, RootDeps, UGFZIBWVBJS, Deps> WABJXDDZNEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int CYQIJPQPHSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int ZNONOCXOMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int VLHJQJXUGYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly RUVZIZBNEGS<USPEKNRWVPE, Result<object, JDUFGOJEPGU>> NGSXZDXZJUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly RUVZIZBNEGS<USPEKNRWVPE, Result<object, JDUFGOJEPGU>> GTWGTAWOMRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ELSNTWPCDON SNMLORCJSFB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EFLDEENZWFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x287C3F0", Offset = "0x287B5F0", VA = "0x18287C3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int CKPDXJQKJAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x287C580", Offset = "0x287B780", VA = "0x18287C580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int OYWJIWXVSCT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x287C5C0", Offset = "0x287B7C0", VA = "0x18287C5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int QQKQDXRTUCG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x287C3B0", Offset = "0x287B5B0", VA = "0x18287C3B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x287C600", Offset = "0x287B800", VA = "0x18287C600")]
		public UGFZIBWVBJS(int a, int b, int c, RUVZIZBNEGS<USPEKNRWVPE, Result<object, JDUFGOJEPGU>> d, RUVZIZBNEGS<USPEKNRWVPE, Result<object, JDUFGOJEPGU>> e, ELSNTWPCDON f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x287C430", Offset = "0x287B630", VA = "0x18287C430")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, JDUFGOJEPGU>> PZGKDFDFRQX(RRHCIMKELZN a, Id32<WBUFIROFFZC> b, USPEKNRWVPE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x287C280", Offset = "0x287B480", VA = "0x18287C280", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(USPEKNRWVPE a, bool b)
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
