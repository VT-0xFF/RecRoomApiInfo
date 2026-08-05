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
	public sealed class WWHEYDZHEUX : IDisposable, SPVIFMMAWWI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct CV2DynamicObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public readonly RRNetworkBehavior MonoBehaviourPun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public DCRGBHKLLZL Receiver;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			private CV2DynamicObject(RRNetworkBehavior monoBehaviourPun, DCRGBHKLLZL receiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2895750", Offset = "0x2894750", VA = "0x182895750")]
			public static CV2DynamicObject New(RRNetworkBehavior monoBehaviourPun)
			{
				return default(CV2DynamicObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private sealed class THNPIREFVUK : VNLFEPUTBSL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly Action<object> QWMONQZIABC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly Func<bool> UTKGBSDCBVN;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			protected override object NUNSJCDTDVM
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "7")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2895AE0", Offset = "0x2894AE0", VA = "0x182895AE0", Slot = "8")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2895B90", Offset = "0x2894B90", VA = "0x182895B90")]
			public THNPIREFVUK(FFHJLRAELVV a, string b, object c, bool d, Action e, Action<object> f, Func<bool> g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2895B60", Offset = "0x2894B60", VA = "0x182895B60", Slot = "9")]
			protected override bool WDXESVPTVBW()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2895B30", Offset = "0x2894B30", VA = "0x182895B30")]
			public void Set(object newValue)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly string JQBLFLWVLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private SOAId32Field<UYHKNYSICNO, CV2DynamicObject> XXCJIHNHJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32Field<TETUOZPDWQY, THNPIREFVUK> CIZRRRQPJEW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<OFTCEQFRRMD> SGKZBGDKDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD1F8D0", Offset = "0xD1E8D0", VA = "0x180D1F8D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<OFTCEQFRRMD>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x13CE520", Offset = "0x13CD520", VA = "0x1813CE520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28978E0", Offset = "0x28968E0", VA = "0x1828978E0")]
		public WWHEYDZHEUX(string a, Id32<OFTCEQFRRMD> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2896D00", Offset = "0x2895D00", VA = "0x182896D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2897450", Offset = "0x2896450", VA = "0x182897450")]
		public void SIOSHWSPYVN(Id32<UYHKNYSICNO> a, LUDZPBIZHHZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2897530", Offset = "0x2896530", VA = "0x182897530")]
		public Id32<UYHKNYSICNO> UAVWIQDJTWV(RRNetworkBehavior a)
		{
			return default(Id32<UYHKNYSICNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2896AE0", Offset = "0x2895AE0", VA = "0x182896AE0")]
		public void AHDACWPLCVJ(Id32<UYHKNYSICNO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28970C0", Offset = "0x28960C0", VA = "0x1828970C0", Slot = "6")]
		public void IGXFTZCMFSC(Id32<UYHKNYSICNO> a, LUDZPBIZHHZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28972A0", Offset = "0x28962A0", VA = "0x1828972A0", Slot = "7")]
		public void OEGJEUJVREI(Id32<UYHKNYSICNO> a, LUDZPBIZHHZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2897750", Offset = "0x2896750", VA = "0x182897750", Slot = "8")]
		public void WRBOLMTFFJP(Id32<UYHKNYSICNO> a, LUDZPBIZHHZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28975C0", Offset = "0x28965C0", VA = "0x1828975C0", Slot = "9")]
		public void VSKCWQORRBS(Id32<UYHKNYSICNO> a, LUDZPBIZHHZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2896B30", Offset = "0x2895B30", VA = "0x182896B30", Slot = "10")]
		public void AODQQDRRCUW(Id32<UYHKNYSICNO> a, Id32<OFTCEQFRRMD> b, LUDZPBIZHHZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28971D0", Offset = "0x28961D0", VA = "0x1828971D0", Slot = "11")]
		public void KOQAEJKWWVQ(Id32<UYHKNYSICNO> a, DCRGBHKLLZL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2897860", Offset = "0x2896860", VA = "0x182897860", Slot = "12")]
		public Id32<OFTCEQFRRMD> XXOIPUYBCYF(Id32<UYHKNYSICNO> a)
		{
			return default(Id32<OFTCEQFRRMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2896D60", Offset = "0x2895D60", VA = "0x182896D60", Slot = "13")]
		public Id32<TETUOZPDWQY> GPUMNMEIKJF(Id32<UYHKNYSICNO> a, string b, object c, bool d, VWDJTLBCZIU e, RVXIGOQBMTO f)
		{
			return default(Id32<TETUOZPDWQY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2896C80", Offset = "0x2895C80", VA = "0x182896C80", Slot = "14")]
		public void CVIHMMNIXVD(Id32<TETUOZPDWQY> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28976D0", Offset = "0x28966D0", VA = "0x1828976D0", Slot = "15")]
		public void VUTICDYFKCJ(Id32<TETUOZPDWQY> a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class VIXKZIDAJMX : BKAMUOKSWTC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private readonly struct RootDeps : NKGUVMYRRNL.LSMBPXCSTGO<PQYWNUACEKJ, VIXKZIDAJMX>
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
				public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public VIXKZIDAJMX root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public PQYWNUACEKJ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public bool buffered;

				[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x28961B0", Offset = "0x28951B0", VA = "0x1828961B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x2896600", Offset = "0x2895600", VA = "0x182896600", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28958E0", Offset = "0x28948E0", VA = "0x1828958E0", Slot = "4")]
			public int MYCMEDJGDUA(VIXKZIDAJMX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x12B1310", Offset = "0x12B0310", VA = "0x1812B1310", Slot = "5")]
			public int QEWGVXSYCDO(VIXKZIDAJMX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28957F0", Offset = "0x28947F0", VA = "0x1828957F0", Slot = "6")]
			public int EUPNHNMHDRN(VIXKZIDAJMX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE1C890", Offset = "0xE1B890", VA = "0x180E1C890", Slot = "7")]
			public int PGFUGAVLHJZ(VIXKZIDAJMX a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2895790", Offset = "0x2894790", VA = "0x182895790", Slot = "8")]
			public void BCIFMGYBRGO(VIXKZIDAJMX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "9")]
			public bool ROKYPSMZANN(VIXKZIDAJMX a, Id32<OFTCEQFRRMD> b, PQYWNUACEKJ[] c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2895810", Offset = "0x2894810", VA = "0x182895810", Slot = "10")]
			public bool FTSBWEDBMPP(VIXKZIDAJMX a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x28959A0", Offset = "0x28949A0", VA = "0x1828959A0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, WENLUTALDTF>> TDXULBVXUUN(VIXKZIDAJMX a, Id32<OFTCEQFRRMD> b, PQYWNUACEKJ c, bool d = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct Deps : NKGUVMYRRNL.GJLSAJUAVJH<ActionDeps, UOILJAPMYSC.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public ActionDeps YTBGAMRZLNR
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public UOILJAPMYSC.StaticNetSysReceiverDeps CGGLGLGIODW
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "5")]
				get
				{
					return default(UOILJAPMYSC.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public RootDeps RUTUCFMPLRT
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			int FDWDDNNYYQC
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			bool MORRYUENCCF
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			string REYYSJNETNL
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool FTSBWEDBMPP(int a);
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
			public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public VIXKZIDAJMX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public UOILJAPMYSC root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Id32<OFTCEQFRRMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PQYWNUACEKJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2895C70", Offset = "0x2894C70", VA = "0x182895C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2895EA0", Offset = "0x2894EA0", VA = "0x182895EA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, WENLUTALDTF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public VIXKZIDAJMX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PQYWNUACEKJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<Result<object, WENLUTALDTF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2895F10", Offset = "0x2894F10", VA = "0x182895F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2896140", Offset = "0x2895140", VA = "0x182896140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private URRAEHSBISN<PQYWNUACEKJ, None, UOILJAPMYSC, ActionDeps, UOILJAPMYSC.StaticNetSysReceiverDeps, RootDeps, VIXKZIDAJMX, Deps> WMRFDFDZTOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly int FOJAEBPGLZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int NVUBDIUNYMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int BLUJGIXULEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly IJPJQWORRUD<PQYWNUACEKJ, Result<object, WENLUTALDTF>> OMJZDZBQLUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly IJPJQWORRUD<PQYWNUACEKJ, Result<object, WENLUTALDTF>> ONFITFKCZQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OAIZGCDVQOY USEUOEMXTCW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WQOVAXRJIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2896840", Offset = "0x2895840", VA = "0x182896840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GDJSVWPPSSB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28966B0", Offset = "0x28956B0", VA = "0x1828966B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GEFVBWTLIZK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2896670", Offset = "0x2895670", VA = "0x182896670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int YDDJUZQHHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2896880", Offset = "0x2895880", VA = "0x182896880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28969F0", Offset = "0x28959F0", VA = "0x1828969F0")]
		public VIXKZIDAJMX(int a, int b, int c, IJPJQWORRUD<PQYWNUACEKJ, Result<object, WENLUTALDTF>> d, IJPJQWORRUD<PQYWNUACEKJ, Result<object, WENLUTALDTF>> e, OAIZGCDVQOY f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28966F0", Offset = "0x28956F0", VA = "0x1828966F0")]
		[AsyncStateMachine(typeof(<ReceiveAction>d__16))]
		public Task<Result<object, WENLUTALDTF>> GYVMBXXLYIG(UOILJAPMYSC a, Id32<OFTCEQFRRMD> b, PQYWNUACEKJ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28968C0", Offset = "0x28958C0", VA = "0x1828968C0", Slot = "4")]
		[AsyncStateMachine(typeof(<SendActionToAll>d__17))]
		public Task<Result<object, WENLUTALDTF>> TDXULBVXUUN(PQYWNUACEKJ a, bool b)
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
