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
	public sealed class INQMLISFTYP : IDisposable, YXPWXONPQVW
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public XXBGSQEASIF Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, XXBGSQEASIF receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2855E70", Offset = "0x2854670", VA = "0x182855E70")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class NXZAXEEVIWO : YQUQTTWDHKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> UIEAUQXPNTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> YKCOGMSQSQX;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object FHQMLGCUYOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2856DC0", Offset = "0x28555C0", VA = "0x182856DC0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2856E70", Offset = "0x2855670", VA = "0x182856E70")]
			public NXZAXEEVIWO(ZDTJWVAUIKL a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2856E10", Offset = "0x2855610", VA = "0x182856E10", Slot = "9")]
			protected override bool KRALCBTAFHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2856E40", Offset = "0x2855640", VA = "0x182856E40")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string UAEEKKBQMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<SJYBMYLJCNS, CV2DynamicObject> RHGMGVWVNGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<JCHFTPSLWKY, NXZAXEEVIWO> RJAJTHNVDDE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<ZORKRESYKMD> YCINBNIEXJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD16190", Offset = "0xD14990", VA = "0x180D16190", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<ZORKRESYKMD>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x13A2FA0", Offset = "0x13A17A0", VA = "0x1813A2FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2856CC0", Offset = "0x28554C0", VA = "0x182856CC0")]
		public INQMLISFTYP(string a, Id32<ZORKRESYKMD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28560B0", Offset = "0x28548B0", VA = "0x1828560B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2855FD0", Offset = "0x28547D0", VA = "0x182855FD0")]
		public void CFVWESSWICH(Id32<SJYBMYLJCNS> a, PJJLODNDMKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2856980", Offset = "0x2855180", VA = "0x182856980")]
		public Id32<SJYBMYLJCNS> UNTTNZPWAKF(RRNetworkBehavior a)
		{
			return default(Id32<SJYBMYLJCNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2855F80", Offset = "0x2854780", VA = "0x182855F80")]
		public void CATEDCHPHZB(Id32<SJYBMYLJCNS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2856760", Offset = "0x2854F60", VA = "0x182856760", Slot = "6")]
		public void TUWFWRPKLCW(Id32<SJYBMYLJCNS> a, PJJLODNDMKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2856B10", Offset = "0x2855310", VA = "0x182856B10", Slot = "7")]
		public void ZWDGKNDJFFK(Id32<SJYBMYLJCNS> a, PJJLODNDMKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2856870", Offset = "0x2855070", VA = "0x182856870", Slot = "8")]
		public void TUWXLEEPPJD(Id32<SJYBMYLJCNS> a, PJJLODNDMKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2856480", Offset = "0x2854C80", VA = "0x182856480", Slot = "9")]
		public void MFXUYILGSDO(Id32<SJYBMYLJCNS> a, PJJLODNDMKD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2856610", Offset = "0x2854E10", VA = "0x182856610", Slot = "10")]
		public void TSRMAXHWSNY(Id32<SJYBMYLJCNS> a, Id32<ZORKRESYKMD> b, PJJLODNDMKD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2855EB0", Offset = "0x28546B0", VA = "0x182855EB0", Slot = "11")]
		public void APJPEMZBMAO(Id32<SJYBMYLJCNS> a, XXBGSQEASIF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2856590", Offset = "0x2854D90", VA = "0x182856590", Slot = "12")]
		public Id32<ZORKRESYKMD> QGJRRKXMENX(Id32<SJYBMYLJCNS> a)
		{
			return default(Id32<ZORKRESYKMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2856110", Offset = "0x2854910", VA = "0x182856110", Slot = "13")]
		public Id32<JCHFTPSLWKY> LPGBWPIAFTB(Id32<SJYBMYLJCNS> a, string b, object c, bool d, IEAGUDBCKHG e, ZVKVRWIYDGI f)
		{
			return default(Id32<JCHFTPSLWKY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2856A90", Offset = "0x2855290", VA = "0x182856A90", Slot = "14")]
		public void YVTSAOUQMSJ(Id32<JCHFTPSLWKY> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2856A10", Offset = "0x2855210", VA = "0x182856A10", Slot = "15")]
		public void XSSONRKMHWJ(Id32<JCHFTPSLWKY> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class WWIYLMJTFZJ : KIQIZMMDNIQ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : WJCXSIBAOJT.HMLSSQKIODE<UZPYRKQPSNH, WWIYLMJTFZJ>
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
				public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public WWIYLMJTFZJ root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public UZPYRKQPSNH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28577F0", Offset = "0x2855FF0", VA = "0x1828577F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2857C30", Offset = "0x2856430", VA = "0x182857C30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2857180", Offset = "0x2855980", VA = "0x182857180", Slot = "4")]
			public int WSOGVUHINFS(WWIYLMJTFZJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x12A1C10", Offset = "0x12A0410", VA = "0x1812A1C10", Slot = "5")]
			public int VYEZWTOFYRG(WWIYLMJTFZJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2857020", Offset = "0x2855820", VA = "0x182857020", Slot = "6")]
			public int NZSPPUAEWSL(WWIYLMJTFZJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDEBEC0", Offset = "0xDEA6C0", VA = "0x180DEBEC0", Slot = "7")]
			public int IRNSUYDTTQH(WWIYLMJTFZJ a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2857250", Offset = "0x2855A50", VA = "0x182857250", Slot = "8")]
			public void ZLEQPNFHISW(WWIYLMJTFZJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "9")]
			public bool DSHGFRIPKZJ(WWIYLMJTFZJ a, Id32<ZORKRESYKMD> b, UZPYRKQPSNH[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2856F50", Offset = "0x2855750", VA = "0x182856F50", Slot = "10")]
			public bool LBWGEGASKVP(WWIYLMJTFZJ a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2857040", Offset = "0x2855840", VA = "0x182857040", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(WWIYLMJTFZJ a, Id32<ZORKRESYKMD> b, UZPYRKQPSNH c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : WJCXSIBAOJT.BZZUHUVHMDL<ActionDeps, WUFOVRVICVI.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps LWSNPQXCZQP
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public WUFOVRVICVI.StaticNetSysReceiverDeps WEZIQYCHWJG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "5")]
				get
				{
					return default(WUFOVRVICVI.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps ZFZDSYKPXUR
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZVDGYJVWQXS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int JDAJQBKUZGG
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool XAFKBQQQRLD
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string BVCWBSLNGND
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool LBWGEGASKVP(int a);
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
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public WWIYLMJTFZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public WUFOVRVICVI root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public UZPYRKQPSNH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28572B0", Offset = "0x2855AB0", VA = "0x1828572B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x28574E0", Offset = "0x2855CE0", VA = "0x1828574E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public WWIYLMJTFZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public UZPYRKQPSNH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2857550", Offset = "0x2855D50", VA = "0x182857550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2857780", Offset = "0x2855F80", VA = "0x182857780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private VHQOYNGRXXL<UZPYRKQPSNH, None, WUFOVRVICVI, ActionDeps, WUFOVRVICVI.StaticNetSysReceiverDeps, RootDeps, WWIYLMJTFZJ, Deps> IHWJHUUFOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int QPOYNSYJYCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int WSPZVNWNXPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int QAYSIOOUTBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly WNPYWWLVWDN<UZPYRKQPSNH, Result<object, SPRIBHSTRKT>> XPLVLHRWNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly WNPYWWLVWDN<UZPYRKQPSNH, Result<object, SPRIBHSTRKT>> JUBHNVEFLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ZVDGYJVWQXS FPRKQLVLHLA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LXJWXKXCYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2857E70", Offset = "0x2856670", VA = "0x182857E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int YETBOLNTCWN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2857CA0", Offset = "0x28564A0", VA = "0x182857CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GBRIAOSPTAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2857CE0", Offset = "0x28564E0", VA = "0x182857CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int XHYSPHLCNYV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2857FE0", Offset = "0x28567E0", VA = "0x182857FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2858020", Offset = "0x2856820", VA = "0x182858020")]
		public WWIYLMJTFZJ(int a, int b, int c, WNPYWWLVWDN<UZPYRKQPSNH, Result<object, SPRIBHSTRKT>> d, WNPYWWLVWDN<UZPYRKQPSNH, Result<object, SPRIBHSTRKT>> e, ZVDGYJVWQXS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2857D20", Offset = "0x2856520", VA = "0x182857D20")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, SPRIBHSTRKT>> NPBBJAIZAHE(WUFOVRVICVI a, Id32<ZORKRESYKMD> b, UZPYRKQPSNH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2857EB0", Offset = "0x28566B0", VA = "0x182857EB0", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(UZPYRKQPSNH a, bool b)
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
