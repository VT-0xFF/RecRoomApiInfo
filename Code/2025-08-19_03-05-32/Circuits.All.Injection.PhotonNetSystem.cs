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
	public sealed class MZNRVYZUFJJ : IDisposable, OYPORLQHLJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public OCOZJWLZQSN Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, OCOZJWLZQSN receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CC80", Offset = "0x2A5BA80", VA = "0x182A5CC80")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class DQWVCFXSOOK : ZQLNMWUAXWD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> ZORIPNDADUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> JSRRBRQUHYH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object NJNGLULNCQC
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2A5CCC0", Offset = "0x2A5BAC0", VA = "0x182A5CCC0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CD70", Offset = "0x2A5BB70", VA = "0x182A5CD70")]
			public DQWVCFXSOOK(ZNLKIYOYHAH a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CD10", Offset = "0x2A5BB10", VA = "0x182A5CD10", Slot = "9")]
			protected override bool OGNBFCPMXHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2A5CD40", Offset = "0x2A5BB40", VA = "0x182A5CD40")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string DPYTSOROJZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<DMDLWDYEPPG, CV2DynamicObject> CQELMJDTJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<RJRZNMVKEWM, DQWVCFXSOOK> FGWABBILQAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<YCAINYDNLEL> NVSFGYYCCSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD857B0", Offset = "0xD845B0", VA = "0x180D857B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YCAINYDNLEL>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1617730", Offset = "0x1616530", VA = "0x181617730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A5DC60", Offset = "0x2A5CA60", VA = "0x182A5DC60")]
		public MZNRVYZUFJJ(string a, Id32<YCAINYDNLEL> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CFE0", Offset = "0x2A5BDE0", VA = "0x182A5CFE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A5DA70", Offset = "0x2A5C870", VA = "0x182A5DA70")]
		public void ZJVNXHVMUHR(Id32<DMDLWDYEPPG> a, AONVCVTLWUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D7B0", Offset = "0x2A5C5B0", VA = "0x182A5D7B0")]
		public Id32<DMDLWDYEPPG> TVLRBCBVJDL(RRNetworkBehavior a)
		{
			return default(Id32<DMDLWDYEPPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D760", Offset = "0x2A5C560", VA = "0x182A5D760")]
		public void TRBDGOLNVMX(Id32<DMDLWDYEPPG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A5DB50", Offset = "0x2A5C950", VA = "0x182A5DB50", Slot = "6")]
		public void ZOKTQDCGBEO(Id32<DMDLWDYEPPG> a, AONVCVTLWUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D8C0", Offset = "0x2A5C6C0", VA = "0x182A5D8C0", Slot = "7")]
		public void XSEICIBOPTC(Id32<DMDLWDYEPPG> a, AONVCVTLWUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D110", Offset = "0x2A5BF10", VA = "0x182A5D110", Slot = "8")]
		public void LSIEPYXSRLD(Id32<DMDLWDYEPPG> a, AONVCVTLWUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CED0", Offset = "0x2A5BCD0", VA = "0x182A5CED0", Slot = "9")]
		public void DLZDNUXSOWE(Id32<DMDLWDYEPPG> a, AONVCVTLWUL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D610", Offset = "0x2A5C410", VA = "0x182A5D610", Slot = "10")]
		public void PPKGUPWEOWK(Id32<DMDLWDYEPPG> a, Id32<YCAINYDNLEL> b, AONVCVTLWUL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D040", Offset = "0x2A5BE40", VA = "0x182A5D040", Slot = "11")]
		public void GQIUOEXFVBU(Id32<DMDLWDYEPPG> a, OCOZJWLZQSN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D840", Offset = "0x2A5C640", VA = "0x182A5D840", Slot = "12")]
		public Id32<YCAINYDNLEL> XKQCIOLUVWF(Id32<DMDLWDYEPPG> a)
		{
			return default(Id32<YCAINYDNLEL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D2A0", Offset = "0x2A5C0A0", VA = "0x182A5D2A0", Slot = "13")]
		public Id32<RJRZNMVKEWM> PIYTJJWZYBV(Id32<DMDLWDYEPPG> a, string b, object c, bool d, QSDFVRLZKQI e, KMEMKTPISBC f)
		{
			return default(Id32<RJRZNMVKEWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CE50", Offset = "0x2A5BC50", VA = "0x182A5CE50", Slot = "14")]
		public void ATVKYEUEJJD(Id32<RJRZNMVKEWM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D220", Offset = "0x2A5C020", VA = "0x182A5D220", Slot = "15")]
		public void OLGNAWMGTFP(Id32<RJRZNMVKEWM> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class WNOPFITHNTZ : EGZVYBEHFSY
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : XQXZMUBXLZL.QFLDHTOWAFU<TWGQWHZWPAR, WNOPFITHNTZ>
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
				public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public WNOPFITHNTZ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public TWGQWHZWPAR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x2A5E600", Offset = "0x2A5D400", VA = "0x182A5E600", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2A5EA50", Offset = "0x2A5D850", VA = "0x182A5EA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A5DEA0", Offset = "0x2A5CCA0", VA = "0x182A5DEA0", Slot = "4")]
			public int TKJQFCXPDOU(WNOPFITHNTZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC8BA50", Offset = "0xC8A850", VA = "0x180C8BA50", Slot = "5")]
			public int NFMPCAPEQJK(WNOPFITHNTZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E040", Offset = "0x2A5CE40", VA = "0x182A5E040", Slot = "6")]
			public int UZAFVYNSNKT(WNOPFITHNTZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x10745A0", Offset = "0x10733A0", VA = "0x1810745A0", Slot = "7")]
			public int BSHILDBKITZ(WNOPFITHNTZ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E060", Offset = "0x2A5CE60", VA = "0x182A5E060", Slot = "8")]
			public void YWJTXHAPEPI(WNOPFITHNTZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
			public bool JPVFAMKTODJ(WNOPFITHNTZ a, Id32<YCAINYDNLEL> b, TWGQWHZWPAR[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2A5DF70", Offset = "0x2A5CD70", VA = "0x182A5DF70", Slot = "10")]
			public bool UNIXUYNVGAN(WNOPFITHNTZ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A5DD60", Offset = "0x2A5CB60", VA = "0x182A5DD60", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, IGWAJAWUKJF>> LPHQPRKRJUZ(WNOPFITHNTZ a, Id32<YCAINYDNLEL> b, TWGQWHZWPAR c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : XQXZMUBXLZL.XZMMFITJJKF<ActionDeps, SQESMBBMMXQ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps DVNQKRUYLUT
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public SQESMBBMMXQ.StaticNetSysReceiverDeps GDJIGDISKVC
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "5")]
				get
				{
					return default(SQESMBBMMXQ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps ZMLMIOGTBQV
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZLOMSCLYJNW
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int DAVHDBWUNSK
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool FBPYJNSPUOV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string LIQRVSRNWHT
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool UNIXUYNVGAN(int a);
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
			public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public WNOPFITHNTZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public SQESMBBMMXQ root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<YCAINYDNLEL> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TWGQWHZWPAR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E0C0", Offset = "0x2A5CEC0", VA = "0x182A5E0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E2F0", Offset = "0x2A5D0F0", VA = "0x182A5E2F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public WNOPFITHNTZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TWGQWHZWPAR action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E360", Offset = "0x2A5D160", VA = "0x182A5E360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E590", Offset = "0x2A5D390", VA = "0x182A5E590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ZGXQDPSSUNX<TWGQWHZWPAR, None, SQESMBBMMXQ, ActionDeps, SQESMBBMMXQ.StaticNetSysReceiverDeps, RootDeps, WNOPFITHNTZ, Deps> AWGGIHKHCIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int USSPRQGHTGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int TFVYNWONFVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int PTQRCUBCKBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MNNSULOVEWD<TWGQWHZWPAR, Result<object, IGWAJAWUKJF>> OFFZDTWJFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MNNSULOVEWD<TWGQWHZWPAR, Result<object, IGWAJAWUKJF>> YIIXZWHHDBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ZLOMSCLYJNW JGLYIVPXDNI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BKBYEKHTUCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A5EAC0", Offset = "0x2A5D8C0", VA = "0x182A5EAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AIVXFEHRMWB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A5EE00", Offset = "0x2A5DC00", VA = "0x182A5EE00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ZDVRATQKETO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A5ED80", Offset = "0x2A5DB80", VA = "0x182A5ED80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MNSSMKQVAOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2A5EDC0", Offset = "0x2A5DBC0", VA = "0x182A5EDC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EE40", Offset = "0x2A5DC40", VA = "0x182A5EE40")]
		public WNOPFITHNTZ(int a, int b, int c, MNNSULOVEWD<TWGQWHZWPAR, Result<object, IGWAJAWUKJF>> d, MNNSULOVEWD<TWGQWHZWPAR, Result<object, IGWAJAWUKJF>> e, ZLOMSCLYJNW f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EC30", Offset = "0x2A5DA30", VA = "0x182A5EC30")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, IGWAJAWUKJF>> SXKEKMTCUKK(SQESMBBMMXQ a, Id32<YCAINYDNLEL> b, TWGQWHZWPAR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EB00", Offset = "0x2A5D900", VA = "0x182A5EB00", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, IGWAJAWUKJF>> LPHQPRKRJUZ(TWGQWHZWPAR a, bool b)
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
