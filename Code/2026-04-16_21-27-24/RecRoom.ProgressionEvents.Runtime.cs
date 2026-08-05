using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RRUI.Data;
using RecNet;
using RecRoom.Async;
using RecRoom.Core;
using RecRoom.NoEngine.Common;
using RecRoom.Notifications;
using RecRoom.RoomEconomy.Store;
using RecRoom.RoomLoading;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class CIVWSDQGGVS : CZQWKYEIRQV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class SVTGHULILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public CIVWSDQGGVS XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool EFVYKKEIRKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action<Tuple<ProgressionEventDTO, ProgressionEventRecordDTO>> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SVTGHULILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9C44DB0", Offset = "0x9C43BB0", VA = "0x189C44DB0")]
			internal NFPDGBDVXFD DTXKDGRHNGQ(long? a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9C450D0", Offset = "0x9C43ED0", VA = "0x189C450D0")]
			internal void DUCRANLEWRZ(Tuple<ProgressionEventDTO, ProgressionEventRecordDTO> results)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <UpdateLimitedRewardsRemaining>d__60 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CIVWSDQGGVS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<int?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9C45220", Offset = "0x9C44020", VA = "0x189C45220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9C45530", Offset = "0x9C44330", VA = "0x189C45530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool? KDMESUDSOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int? MQVUMNOOGZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int QYLCHGWLBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool VDNKEYGEUUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private string FAJLPGIWOES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly HBQHGCJQFAF MESINCYLFAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly BRFEONBCMGV YOABLYJXPSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly IDAZYIFTYBL EBHDRSRPYHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HEEDIBIRDAE ECARVLQRWXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CZCWLLIVLZI EZHJIKVNUAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IRRUIPlayerShim RVDGJDDYDPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OTIPMTGRWOI ISQYLUVHVMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDisposable UGHMQLOXMYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TZWLJGXBICZ HDTEYDKDJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KROGZNLLANA RSJIXBVYVJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly SXLXUYLFDUW HQFSYBDCUCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ProgressionEventStatus XFPPVXTTHGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ProgressionEventDTO KQAPOUUKCGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ProgressionEventRecordDTO QABJTFCZSUA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ProgressionEventStatus BPDCVTKFSZR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9C44A60", Offset = "0x9C43860", VA = "0x189C44A60", Slot = "10")]
			get
			{
				return default(ProgressionEventStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WHPOITGJBAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9C435D0", Offset = "0x9C423D0", VA = "0x189C435D0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int CSZRLLTNGIF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9C42D50", Offset = "0x9C41B50", VA = "0x189C42D50", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int TBQSHXOISZI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9C436C0", Offset = "0x9C424C0", VA = "0x189C436C0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NHFULGLXEGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9C42970", Offset = "0x9C41770", VA = "0x189C42970", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int XYZKJIBTTSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9C44070", Offset = "0x9C42E70", VA = "0x189C44070", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DDFRXMHKQTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9C42A30", Offset = "0x9C41830", VA = "0x189C42A30", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? VOHGWRIGNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xE20170", Offset = "0xE1EF70", VA = "0x180E20170", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ESNMOECOCYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9C44770", Offset = "0x9C43570", VA = "0x189C44770", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private int JXKQXARNIVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9C42F30", Offset = "0x9C41D30", VA = "0x189C42F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OGIYCDGNLAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9C441B0", Offset = "0x9C42FB0", VA = "0x189C441B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C44420", Offset = "0x9C43220", VA = "0x189C44420", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action GSHVILVJNYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C42E40", Offset = "0x9C41C40", VA = "0x189C42E40", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9C44790", Offset = "0x9C43590", VA = "0x189C44790", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C44AB0", Offset = "0x9C438B0", VA = "0x189C44AB0")]
		[Preserve]
		internal CIVWSDQGGVS([Inject(null)] HBQHGCJQFAF gameManager, [Inject(null)] BRFEONBCMGV scheduledUpdateService, [Inject(null)] IDAZYIFTYBL recNetProgressionEvents, [Inject(null)] HEEDIBIRDAE timeService, [Inject(null)] OTIPMTGRWOI gameConfigsProvider, [Inject(null)] CZCWLLIVLZI notificationManager, [Inject(null)] IRRUIPlayerShim rruiPlayerShim, [Inject(null)] TZWLJGXBICZ giftManager, [Inject(null)] KROGZNLLANA localPlayer, [Inject(null)] SXLXUYLFDUW roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C42BF0", Offset = "0x9C419F0", VA = "0x189C42BF0", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C44A90", Offset = "0x9C43890", VA = "0x189C44A90")]
		private void ZDVSRHOKRQF(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C431F0", Offset = "0x9C41FF0", VA = "0x189C431F0")]
		private void HASSYWUJUFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C430C0", Offset = "0x9C41EC0", VA = "0x189C430C0", Slot = "17")]
		public CCAFLELIKTY<bool> GUZFTWHTIYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C444C0", Offset = "0x9C432C0", VA = "0x189C444C0", Slot = "25")]
		[AsyncStateMachine(typeof(<UpdateLimitedRewardsRemaining>d__60))]
		public Task OGNPMBBGRGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C44830", Offset = "0x9C43630", VA = "0x189C44830", Slot = "18")]
		public NFPDGBDVXFD Refresh(bool forceUpdateCache = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C437D0", Offset = "0x9C425D0", VA = "0x189C437D0", Slot = "19")]
		public NFPDGBDVXFD IUHQVVQLFBU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C44A70", Offset = "0x9C43870", VA = "0x189C44A70", Slot = "21")]
		public void SLVNJYITWPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C43A60", Offset = "0x9C42860", VA = "0x189C43A60", Slot = "22")]
		public string JDAHLDNNUMV(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C44250", Offset = "0x9C43050", VA = "0x189C44250")]
		private ProgressionEventStatus NKYBSPSBYDD()
		{
			return default(ProgressionEventStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C42BA0", Offset = "0x9C419A0", VA = "0x189C42BA0")]
		private void DLLQLXKFEEP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C43B10", Offset = "0x9C42910", VA = "0x189C43B10", Slot = "23")]
		public UncollectedRewardsData MIHTDOQVYBP()
		{
			return default(UncollectedRewardsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C44740", Offset = "0x9C43540", VA = "0x189C44740")]
		[CompilerGenerated]
		private bool RAYQYECIZBT(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C44700", Offset = "0x9C43500", VA = "0x189C44700")]
		[CompilerGenerated]
		private bool RATKAXILPQK(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C445B0", Offset = "0x9C433B0", VA = "0x189C445B0")]
		[CompilerGenerated]
		private void RAODDQOOGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C44590", Offset = "0x9C43390", VA = "0x189C44590")]
		[CompilerGenerated]
		private bool PKMDJBLRLBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C42EE0", Offset = "0x9C41CE0", VA = "0x189C42EE0")]
		[CompilerGenerated]
		private void FURDQYJGDIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C43570", Offset = "0x9C42370", VA = "0x189C43570")]
		[CompilerGenerated]
		private bool HCZVDENJCLD(ProgressionEventRewardDTO a)
		{
			return default(bool);
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
