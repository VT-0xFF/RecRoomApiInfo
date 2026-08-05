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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class NBIWKQPWRWF : DHIZDJTJLSK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class KKOCZAWGQQK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public NBIWKQPWRWF LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool PSGLNOOAXGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action<Tuple<ProgressionEventDTO, ProgressionEventRecordDTO>> CWKBKNFYJZE;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public KKOCZAWGQQK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8825EE0", Offset = "0x88250E0", VA = "0x188825EE0")]
			internal AZBXLTTNREY DONRDALOAUX(long? a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8825E40", Offset = "0x8825040", VA = "0x188825E40")]
			internal void DOIKFTRQRJO(Tuple<ProgressionEventDTO, ProgressionEventRecordDTO> results)
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
			public NBIWKQPWRWF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<int?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8828690", Offset = "0x8827890", VA = "0x188828690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x88289A0", Offset = "0x8827BA0", VA = "0x1888289A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool? RSCZBBPDXPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int? UHTDWYIJHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int DINLEJVDOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool HNFZCJAZQKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private string IICGSGSBQBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly JNUZPEKIFHS UYXZDBACNYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly KVGRDGYLPNU XFFOQCAXUMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OFEBUUMATVW TQWMDGPQEQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OBVQORTVBEB RPUHDUNUSEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly XJPEGCTSSAX QKASJCZUGKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IRRUIPlayerShim UZMUQWGZBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TSCPVZNNMEJ LAYLIKHTYMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDisposable FDIDTUSVRKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private UWQOTZRVAJO SDMAJDXDYTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly GZIJFUXXCLZ DIHLRHTHEEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MVHDAATPYEX YGBJUYIHLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ProgressionEventStatus UELJQDXPHTU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ProgressionEventDTO GIAZZRGZJJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ProgressionEventRecordDTO GJJQHIAYHCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ProgressionEventStatus EUKQIQBWMMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8828050", Offset = "0x8827250", VA = "0x188828050", Slot = "10")]
			get
			{
				return default(ProgressionEventStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int UPHRUCBHGME
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8826FA0", Offset = "0x88261A0", VA = "0x188826FA0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EVNBGEKVLAW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x88281A0", Offset = "0x88273A0", VA = "0x1888281A0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int VPLAYQMKGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8826E90", Offset = "0x8826090", VA = "0x188826E90", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TIKPGYRANIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8827F90", Offset = "0x8827190", VA = "0x188827F90", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int IWMYIPBUGPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8828060", Offset = "0x8827260", VA = "0x188828060", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GCBRVDKEPJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x88269A0", Offset = "0x8825BA0", VA = "0x1888269A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? LBUAPERREXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xBD4480", Offset = "0xBD3680", VA = "0x180BD4480", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool RGEVGPOESMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8826330", Offset = "0x8825530", VA = "0x188826330", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private int IMERNVZJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8827090", Offset = "0x8826290", VA = "0x188827090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ILUITMQBXEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8826450", Offset = "0x8825650", VA = "0x188826450", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88263B0", Offset = "0x88255B0", VA = "0x1888263B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action QYBPDXCSSOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88268E0", Offset = "0x8825AE0", VA = "0x1888268E0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8827320", Offset = "0x8826520", VA = "0x188827320", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8828290", Offset = "0x8827490", VA = "0x188828290")]
		[Preserve]
		internal NBIWKQPWRWF([Inject(null)] JNUZPEKIFHS gameManager, [Inject(null)] KVGRDGYLPNU scheduledUpdateService, [Inject(null)] OFEBUUMATVW recNetProgressionEvents, [Inject(null)] OBVQORTVBEB timeService, [Inject(null)] TSCPVZNNMEJ gameConfigsProvider, [Inject(null)] XJPEGCTSSAX notificationManager, [Inject(null)] IRRUIPlayerShim rruiPlayerShim, [Inject(null)] UWQOTZRVAJO giftManager, [Inject(null)] GZIJFUXXCLZ localPlayer, [Inject(null)] MVHDAATPYEX roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88277C0", Offset = "0x88269C0", VA = "0x1888277C0")]
		private void SUFSTAVVQGI(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8826B10", Offset = "0x8825D10", VA = "0x188826B10")]
		private void NLFQJBXFSNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8826200", Offset = "0x8825400", VA = "0x188826200", Slot = "17")]
		public YUBVFZQANJB<bool> BKDESDWOQSX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88279A0", Offset = "0x8826BA0", VA = "0x1888279A0", Slot = "25")]
		[AsyncStateMachine(typeof(<UpdateLimitedRewardsRemaining>d__59))]
		public Task VJMJTQOTCVL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8827590", Offset = "0x8826790", VA = "0x188827590", Slot = "18")]
		public AZBXLTTNREY Refresh(bool forceUpdateCache = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88265E0", Offset = "0x88257E0", VA = "0x1888265E0", Slot = "19")]
		public AZBXLTTNREY EGODJNPRKIB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8826980", Offset = "0x8825B80", VA = "0x188826980", Slot = "21")]
		public void KRZKUJZPLEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8827270", Offset = "0x8826470", VA = "0x188827270", Slot = "22")]
		public string RBNILVISBKK(ProgressionEventConfigurableTextType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88273C0", Offset = "0x88265C0", VA = "0x1888273C0")]
		private ProgressionEventStatus RUATPGQCXVC()
		{
			return default(ProgressionEventStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8826870", Offset = "0x8825A70", VA = "0x188826870")]
		private void HGUTJYLIYYG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88264F0", Offset = "0x88256F0", VA = "0x1888264F0", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8827A70", Offset = "0x8826C70", VA = "0x188827A70", Slot = "23")]
		public UncollectedRewardsData WBWKYFAXPZA()
		{
			return default(UncollectedRewardsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8827820", Offset = "0x8826A20", VA = "0x188827820")]
		[CompilerGenerated]
		private bool TVAKYBZSTUD(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88277E0", Offset = "0x88269E0", VA = "0x1888277E0")]
		[CompilerGenerated]
		private bool TUVEAVFVKIU(ProgressionEventRewardDTO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8827850", Offset = "0x8826A50", VA = "0x188827850")]
		[CompilerGenerated]
		private void TVKYSPNNMQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88268C0", Offset = "0x8825AC0", VA = "0x1888268C0")]
		[CompilerGenerated]
		private bool HXMKPPMONMX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8827220", Offset = "0x8826420", VA = "0x188827220")]
		[CompilerGenerated]
		private void PQWKDZWYXXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8826350", Offset = "0x8825550", VA = "0x188826350")]
		[CompilerGenerated]
		private bool DCKGTGFGSNO(ProgressionEventRewardDTO a)
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
