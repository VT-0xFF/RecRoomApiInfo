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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class JIWWGWDHFBI : GYICPPGRLVZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JDVJARIRCLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JIWWGWDHFBI BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool GXXKFBNYBEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action<Tuple<ProgressionEventDTO, ProgressionEventRecordDTO>> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JDVJARIRCLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x86EF2F0", Offset = "0x86EDAF0", VA = "0x1886EF2F0")]
			internal QNKHPYUXYMH JMWYTPZWLIC(long? a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x86EF610", Offset = "0x86EDE10", VA = "0x1886EF610")]
			internal void JNCFQWTTUTL(Tuple<ProgressionEventDTO, ProgressionEventRecordDTO> results)
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
			public JIWWGWDHFBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<int?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x86F1A90", Offset = "0x86F0290", VA = "0x1886F1A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86F1DA0", Offset = "0x86F05A0", VA = "0x1886F1DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool? IDAAEZZGMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int? XYBBKPTNEMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int LXYVKGEIIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool YRHVDBNVYCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private string SQKSUJMEEFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly RNBGQIWDUWP RCMTPSKWASE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly OQYUPHXYZAD WXFNFTMYQPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly BZRCXVPRWDB IARDRRLGCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly SYHZZDRBJQG JLOOTJTKPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly UPSJOSMUUAU CONEDBBZITF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IRRUIPlayerShim ANICCZGJMPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private XZAWTOQHWWO GSJXGBIKGBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDisposable KAOPOFWCVXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private SYIUAXCCAKH JPTBUVSROBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OAVXIMKDQPK XRRNROMOAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KAMLVFGMCJS RFAJTSEXAKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ProgressionEventStatus CNHNMNVSMJT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ProgressionEventDTO UNACIRBFYXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ProgressionEventRecordDTO SPNYISQJNTM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ProgressionEventStatus AYQTUREXSNX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x86F0920", Offset = "0x86EF120", VA = "0x1886F0920", Slot = "10")]
			get
			{
				return default(ProgressionEventStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WKFUWMZOKAV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86EFE40", Offset = "0x86EE640", VA = "0x1886EFE40", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int VFJNXQFYPKT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x86F0FD0", Offset = "0x86EF7D0", VA = "0x1886F0FD0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DJXCFTPCGWY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x86F0810", Offset = "0x86EF010", VA = "0x1886F0810", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int WBQBYKONGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x86F1160", Offset = "0x86EF960", VA = "0x1886F1160", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int TRRUWPHMZQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86F1520", Offset = "0x86EFD20", VA = "0x1886F1520", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NFPXAXXIJBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x86F1220", Offset = "0x86EFA20", VA = "0x1886F1220", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? XLLIBTAKEZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBA9480", Offset = "0xBA7C80", VA = "0x180BA9480", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool XPQWNQAXOKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x86F1660", Offset = "0x86EFE60", VA = "0x1886F1660", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private int MMYECOGOKZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86F1390", Offset = "0x86EFB90", VA = "0x1886F1390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action SOLOHISSAAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x86F10C0", Offset = "0x86EF8C0", VA = "0x1886F10C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x86EF8A0", Offset = "0x86EE0A0", VA = "0x1886EF8A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ZQQWTUAPFUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x86EFFE0", Offset = "0x86EE7E0", VA = "0x1886EFFE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x86F06A0", Offset = "0x86EEEA0", VA = "0x1886F06A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86F1680", Offset = "0x86EFE80", VA = "0x1886F1680")]
		[Preserve]
		internal JIWWGWDHFBI([Inject(null)] RNBGQIWDUWP gameManager, [Inject(null)] OQYUPHXYZAD scheduledUpdateService, [Inject(null)] BZRCXVPRWDB recNetProgressionEvents, [Inject(null)] SYHZZDRBJQG timeService, [Inject(null)] XZAWTOQHWWO gameConfigsProvider, [Inject(null)] UPSJOSMUUAU notificationManager, [Inject(null)] IRRUIPlayerShim rruiPlayerShim, [Inject(null)] SYIUAXCCAKH giftManager, [Inject(null)] OAVXIMKDQPK localPlayer, [Inject(null)] KAMLVFGMCJS roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86EF880", Offset = "0x86EE080", VA = "0x1886EF880")]
		private void CLSRBVSFPSP(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86EFA50", Offset = "0x86EE250", VA = "0x1886EFA50")]
		private void FFNYUSWZLUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86F0BC0", Offset = "0x86EF3C0", VA = "0x1886F0BC0", Slot = "17")]
		public JIREGIBPOUE<bool> RNXTLWSZPSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86F0740", Offset = "0x86EEF40", VA = "0x1886F0740", Slot = "25")]
		[AsyncStateMachine(typeof(<UpdateLimitedRewardsRemaining>d__59))]
		public Task OUAJYJPLJAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86F0CF0", Offset = "0x86EF4F0", VA = "0x1886F0CF0", Slot = "18")]
		public QNKHPYUXYMH Refresh(bool forceUpdateCache = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86F0930", Offset = "0x86EF130", VA = "0x1886F0930", Slot = "19")]
		public QNKHPYUXYMH PXFEOMHAKLK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86EFDD0", Offset = "0x86EE5D0", VA = "0x1886EFDD0", Slot = "21")]
		public void GPMFEHLTXZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86EFF30", Offset = "0x86EE730", VA = "0x1886EFF30", Slot = "22")]
		public string HYHIZVEILDJ(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86EF6B0", Offset = "0x86EDEB0", VA = "0x1886EF6B0")]
		private ProgressionEventStatus CAQQIQAGCGD()
		{
			return default(ProgressionEventStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86F0F20", Offset = "0x86EF720", VA = "0x1886F0F20")]
		private void UAHMNFGSGGF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86EF940", Offset = "0x86EE140", VA = "0x1886EF940", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86F0180", Offset = "0x86EE980", VA = "0x1886F0180", Slot = "23")]
		public UncollectedRewardsData NPTZCJWAQFJ()
		{
			return default(UncollectedRewardsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86F0110", Offset = "0x86EE910", VA = "0x1886F0110")]
		[CompilerGenerated]
		private bool NJHCEIPFPWS(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86F0140", Offset = "0x86EE940", VA = "0x1886F0140")]
		[CompilerGenerated]
		private bool NJMJBPJCZIB(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86F0080", Offset = "0x86EE880", VA = "0x1886F0080")]
		[CompilerGenerated]
		private void NIWOJVBKXAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86EFA30", Offset = "0x86EE230", VA = "0x1886EFA30")]
		[CompilerGenerated]
		private bool ERRSTSNODFM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86EFDF0", Offset = "0x86EE5F0", VA = "0x1886EFDF0")]
		[CompilerGenerated]
		private void HMFTYAGKXEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86F0F70", Offset = "0x86EF770", VA = "0x1886F0F70")]
		[CompilerGenerated]
		private bool VFYEOZSXUNJ(ProgressionEventRewardDTO a)
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
