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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class GOJUWGBQVSP : FUFVWINYFFS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class CCXHNTXDVSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public GOJUWGBQVSP NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool JMTCSOXUFCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action<Tuple<ProgressionEventDTO, ProgressionEventRecordDTO>> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCXHNTXDVSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9DB94E0", Offset = "0x9DB84E0", VA = "0x189DB94E0")]
			internal UXDBKRJQXAW HBKHFRREPMZ(long? a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9440", Offset = "0x9DB8440", VA = "0x189DB9440")]
			internal void HBFAIKXHGBQ(Tuple<ProgressionEventDTO, ProgressionEventRecordDTO> results)
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
			public GOJUWGBQVSP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<int?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9DBBCF0", Offset = "0x9DBACF0", VA = "0x189DBBCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC000", Offset = "0x9DBB000", VA = "0x189DBC000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool? QNADIZQNRNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int? EARJILIQDWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int WLJNXQJUDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool QPLLGHETAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private string PYZJAELLHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly SMTSCQMYOKS THVFWGJNPIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly RXDWYWNEING RTCMRRKYWNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly QJZZZWVIAHQ LSPUWQZSJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EISYRYWLKLZ EWZGLEPWTEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DOAQABMDRNX ISCHTFNHMZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IRRUIPlayerShim FZYOSEMKJDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private JCHPYLHNCOT LCSKAHGVXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDisposable QQCAJYVCLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private FKJKWBIGBPM ISRQNYFZICX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LARJLMTIWJL YDQVSUYIDXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly NWEKUKHUYBX AYETESNHKOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ProgressionEventStatus UFDAFTDREXO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ProgressionEventDTO VAZWWMVAXHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ProgressionEventRecordDTO BTCTNYWMNLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ProgressionEventStatus RZDNMGNBFQG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9EC0", Offset = "0x9DB8EC0", VA = "0x189DB9EC0", Slot = "10")]
			get
			{
				return default(ProgressionEventStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PJCMWGFHJQC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9B70", Offset = "0x9DB8B70", VA = "0x189DB9B70", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EYVQWQXWGQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9DBB230", Offset = "0x9DBA230", VA = "0x189DBB230", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LIDUOFLJLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9DBA6A0", Offset = "0x9DB96A0", VA = "0x189DBA6A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LRCKWHQNZSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9DBB880", Offset = "0x9DBA880", VA = "0x189DBB880", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int AFXKHLXIGTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9C60", Offset = "0x9DB8C60", VA = "0x189DB9C60", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool DMMJUOIIBXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9DBB050", Offset = "0x9DBA050", VA = "0x189DBB050", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? IDBSFUZHNRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xE326F0", Offset = "0xE316F0", VA = "0x180E326F0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ZVSYSIOGJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9DBA680", Offset = "0x9DB9680", VA = "0x189DBA680", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private int DYKYGAEPDZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9DBAB40", Offset = "0x9DB9B40", VA = "0x189DBAB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HGUBOJEKYEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DBA7B0", Offset = "0x9DB97B0", VA = "0x189DBA7B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9DBA0C0", Offset = "0x9DB90C0", VA = "0x189DBA0C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action FKIPTAZYPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9A30", Offset = "0x9DB8A30", VA = "0x189DB9A30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9DB9AD0", Offset = "0x9DB8AD0", VA = "0x189DB9AD0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB940", Offset = "0x9DBA940", VA = "0x189DBB940")]
		[Preserve]
		internal GOJUWGBQVSP([Inject(null)] SMTSCQMYOKS gameManager, [Inject(null)] RXDWYWNEING scheduledUpdateService, [Inject(null)] QJZZZWVIAHQ recNetProgressionEvents, [Inject(null)] EISYRYWLKLZ timeService, [Inject(null)] JCHPYLHNCOT gameConfigsProvider, [Inject(null)] DOAQABMDRNX notificationManager, [Inject(null)] IRRUIPlayerShim rruiPlayerShim, [Inject(null)] FKJKWBIGBPM giftManager, [Inject(null)] LARJLMTIWJL localPlayer, [Inject(null)] NWEKUKHUYBX roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9800", Offset = "0x9DB8800", VA = "0x189DB9800", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9ED0", Offset = "0x9DB8ED0", VA = "0x189DB9ED0")]
		private void NXAICCXTCXE(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DBACD0", Offset = "0x9DB9CD0", VA = "0x189DBACD0")]
		private void VXLBVXOXWNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA160", Offset = "0x9DB9160", VA = "0x189DBA160", Slot = "17")]
		public DLXOODTYWKJ<bool> QVJSVOWJREN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9960", Offset = "0x9DB8960", VA = "0x189DB9960", Slot = "25")]
		[AsyncStateMachine(typeof(<UpdateLimitedRewardsRemaining>d__60))]
		public Task EXPQCNCDOZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA450", Offset = "0x9DB9450", VA = "0x189DBA450", Slot = "18")]
		public UXDBKRJQXAW Refresh(bool forceUpdateCache = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA850", Offset = "0x9DB9850", VA = "0x189DBA850", Slot = "19")]
		public UXDBKRJQXAW UNPZPFTDFFZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB210", Offset = "0x9DBA210", VA = "0x189DBB210", Slot = "21")]
		public void XZDQAZIFORJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9E10", Offset = "0x9DB8E10", VA = "0x189DB9E10", Slot = "22")]
		public string MXESBWJSCVO(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9EF0", Offset = "0x9DB8EF0", VA = "0x189DB9EF0")]
		private ProgressionEventStatus NZYYYFTLNYC()
		{
			return default(ProgressionEventStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB1C0", Offset = "0x9DBA1C0", VA = "0x189DBB1C0")]
		private void XPNALLLVLTG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB320", Offset = "0x9DBA320", VA = "0x189DBB320", Slot = "23")]
		public UncollectedRewardsData YFJVLHZVWGE()
		{
			return default(UncollectedRewardsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA290", Offset = "0x9DB9290", VA = "0x189DBA290")]
		[CompilerGenerated]
		private bool RVIEKZCEBMU(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA2C0", Offset = "0x9DB92C0", VA = "0x189DBA2C0")]
		[CompilerGenerated]
		private bool RVNLIFWBKYD(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA300", Offset = "0x9DB9300", VA = "0x189DBA300")]
		[CompilerGenerated]
		private void RVSSFMPYUJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9DF0", Offset = "0x9DB8DF0", VA = "0x189DB9DF0")]
		[CompilerGenerated]
		private bool MBIVZULNQDY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9DA0", Offset = "0x9DB8DA0", VA = "0x189DB9DA0")]
		[CompilerGenerated]
		private void LOYMURVDKXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAAE0", Offset = "0x9DB9AE0", VA = "0x189DBAAE0")]
		[CompilerGenerated]
		private bool USWDBIEGACG(ProgressionEventRewardDTO a)
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
