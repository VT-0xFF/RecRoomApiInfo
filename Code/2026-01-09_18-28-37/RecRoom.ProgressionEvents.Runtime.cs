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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class XELZIJKFNUH : MWDJOFCSZRG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IZJIXEHNGYM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public XELZIJKFNUH ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool JAAKTMNFQFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action<Tuple<ProgressionEventDTO, ProgressionEventRecordDTO>> LVMRPUOMYKQ;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IZJIXEHNGYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x85FEFB0", Offset = "0x85FE3B0", VA = "0x1885FEFB0")]
			internal SKSLBBUJUBM XRCZZBGCCTL(long? a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85FEF10", Offset = "0x85FE310", VA = "0x1885FEF10")]
			internal void XQXTBUMETIC(Tuple<ProgressionEventDTO, ProgressionEventRecordDTO> results)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <UpdateLimitedRewardsRemaining>d__59 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public XELZIJKFNUH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<int?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85FF380", Offset = "0x85FE780", VA = "0x1885FF380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85FF690", Offset = "0x85FEA90", VA = "0x1885FF690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool? QXAGZKPWPYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int? NBGEABGDKJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BTWDZOWCVBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool TCRRQGBVLLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private string HPQTAFZCTEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly IYLDAOGRJGC QFIWXXZILNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly MALIMZOAGHO MEFUIGCVURJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly YKCYTWDULVM QQKDGFDIIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly VCQGIVMPMOX ZHROFOHIFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DNQORTKTICF UVCSOEPCKAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IRRUIPlayerShim HTUNBLBCEXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FDEVKWFMIHV RVLMCPXRBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDisposable WSRAQPSBWMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private UKQLQRLYPIW EMLOGITTYCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly EPYBJJYOFVD BHBKYGFKAGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly QWALVQCWMFL VNVNKTUZYMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ProgressionEventStatus UUOBCAQVEZG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ProgressionEventDTO HYHIQBPDUAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ProgressionEventRecordDTO ZGKJTBIDCMR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ProgressionEventStatus VRZJWWNTNDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x85FFD50", Offset = "0x85FF150", VA = "0x1885FFD50", Slot = "10")]
			get
			{
				return default(ProgressionEventStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int POQQQJOOPIW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x85FFBC0", Offset = "0x85FEFC0", VA = "0x1885FFBC0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IXNRFIZHLBG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85FFAD0", Offset = "0x85FEED0", VA = "0x1885FFAD0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int NGQUABXJFUR
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8600B80", Offset = "0x85FFF80", VA = "0x188600B80", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int SBPWOMDPTRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85FF9C0", Offset = "0x85FEDC0", VA = "0x1885FF9C0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int VIHNUIMYNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8600A40", Offset = "0x85FFE40", VA = "0x188600A40", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FXJEGGWJGWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85FFE60", Offset = "0x85FF260", VA = "0x1885FFE60", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? QGKFEJKIKBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB52590", Offset = "0xB51990", VA = "0x180B52590", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IIBWMMGBDWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8601010", Offset = "0x8600410", VA = "0x188601010", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private int LEHIUJAHWDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8601550", Offset = "0x8600950", VA = "0x188601550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action WHKPHYJLPUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x85FFCB0", Offset = "0x85FF0B0", VA = "0x1885FFCB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x85FF920", Offset = "0x85FED20", VA = "0x1885FF920", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action QJHQDRKSGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x85FF880", Offset = "0x85FEC80", VA = "0x1885FF880", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8600560", Offset = "0x85FF960", VA = "0x188600560", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86016E0", Offset = "0x8600AE0", VA = "0x1886016E0")]
		[Preserve]
		internal XELZIJKFNUH([Inject(null)] IYLDAOGRJGC gameManager, [Inject(null)] MALIMZOAGHO scheduledUpdateService, [Inject(null)] YKCYTWDULVM recNetProgressionEvents, [Inject(null)] VCQGIVMPMOX timeService, [Inject(null)] FDEVKWFMIHV gameConfigsProvider, [Inject(null)] DNQORTKTICF notificationManager, [Inject(null)] IRRUIPlayerShim rruiPlayerShim, [Inject(null)] UKQLQRLYPIW giftManager, [Inject(null)] EPYBJJYOFVD localPlayer, [Inject(null)] QWALVQCWMFL roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8600600", Offset = "0x85FFA00", VA = "0x188600600")]
		private void PUOVGAFIJYK(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8600C90", Offset = "0x8600090", VA = "0x188600C90")]
		private void TYKWRUSAWMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86006D0", Offset = "0x85FFAD0", VA = "0x1886006D0", Slot = "17")]
		public KOPZSJWAQQR<bool> QQKQFZICCRL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8600270", Offset = "0x85FF670", VA = "0x188600270", Slot = "25")]
		[AsyncStateMachine(typeof(<UpdateLimitedRewardsRemaining>d__59))]
		public Task LMKXZYJKOWD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8600800", Offset = "0x85FFC00", VA = "0x188600800", Slot = "18")]
		public SKSLBBUJUBM Refresh(bool forceUpdateCache = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85FFFE0", Offset = "0x85FF3E0", VA = "0x1885FFFE0", Slot = "19")]
		public SKSLBBUJUBM JSJBWAFLPJV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85FF770", Offset = "0x85FEB70", VA = "0x1885FF770", Slot = "21")]
		public void DKNQCMBJNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8600620", Offset = "0x85FFA20", VA = "0x188600620", Slot = "22")]
		public string PVUNYXUKXIQ(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8600340", Offset = "0x85FF740", VA = "0x188600340")]
		private ProgressionEventStatus NQEVTKUIMUK()
		{
			return default(ProgressionEventStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85FFA80", Offset = "0x85FEE80", VA = "0x1885FFA80")]
		private void GSSWESKELZW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85FF790", Offset = "0x85FEB90", VA = "0x1885FF790", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8601030", Offset = "0x8600430", VA = "0x188601030", Slot = "23")]
		public UncollectedRewardsData YNLDIVBRAFK()
		{
			return default(UncollectedRewardsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85FFE30", Offset = "0x85FF230", VA = "0x1885FFE30")]
		[CompilerGenerated]
		private bool IEGYVJIPQJD(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85FFDF0", Offset = "0x85FF1F0", VA = "0x1885FFDF0")]
		[CompilerGenerated]
		private bool IEBRYCOSGXU(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85FFD60", Offset = "0x85FF160", VA = "0x1885FFD60")]
		[CompilerGenerated]
		private void IDWLAVUUXML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85FF750", Offset = "0x85FEB50", VA = "0x1885FF750")]
		[CompilerGenerated]
		private bool BCHGGBQNZUJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8600510", Offset = "0x85FF910", VA = "0x188600510")]
		[CompilerGenerated]
		private void OIEPRDIKKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85FF6F0", Offset = "0x85FEAF0", VA = "0x1885FF6F0")]
		[CompilerGenerated]
		private bool AHCNZFGCAFM(ProgressionEventRewardDTO a)
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
