using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Analytics.Statsig;
using RecRoom.NoEngine.Common;
using RecRoom.PlatformNotifications;
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class EIDPXNLYPRH : AQSYLDTHXHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[Preserve]
		internal EIDPXNLYPRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		public void DQPSINTFMXF(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public void KIUEJZWOFSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8147750", Offset = "0x8146350", VA = "0x188147750", Slot = "6")]
		public void CCURCLQJFRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8147750", Offset = "0x8146350", VA = "0x188147750", Slot = "7")]
		public void QCTHJAHLGQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8147760", Offset = "0x8146360", VA = "0x188147760", Slot = "8")]
		public void HMIFACSUHAE(string a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class FGKZKVOSMHI : RKRCXXZWHDF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly AQSYLDTHXHG LMTZWRNXFMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly IGMBDSAWMRJ EHCPCXAGGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly SFHAJDWYLQV BZVABAOPBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly CYQWOSXZXCR DCGJWQLPGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ZVONWTEYZLG PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LKPBYOVSSIG RGEXJSEYBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UWTFUWBHDBX JLEQEFITJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly HXFXHNYTPOW ECOIXTNYGAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool RFHIJCXCFZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CompilerGenerated]
		private Action WKKNOHDYMYX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool IEPHBOKZRBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA0AD0", Offset = "0xA9F6D0", VA = "0x180AA0AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool WSPIEYVKXOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BD0", Offset = "0xA9F7D0", VA = "0x180AA0BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81485D0", Offset = "0x81471D0", VA = "0x1881485D0")]
		[Preserve]
		internal FGKZKVOSMHI([Inject(null)][NotNull] AQSYLDTHXHG brazeAPI, [Inject(null)][NotNull] IGMBDSAWMRJ recNetAccounts, [Inject(null)][NotNull] SFHAJDWYLQV platformNotificationManager, [Inject(null)][NotNull] CYQWOSXZXCR crmManager, [Inject(null)][NotNull] ZVONWTEYZLG roomManager, [Inject(null)][NotNull] LKPBYOVSSIG gameConfigsProvider, [Inject(null)][NotNull] UWTFUWBHDBX statsig, [Inject(null)][NotNull] HXFXHNYTPOW analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8147B90", Offset = "0x8146790", VA = "0x188147B90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81484D0", Offset = "0x81470D0", VA = "0x1881484D0")]
		private void UZAKAZZXZDM(PlatformNotification a, PlatformNotificationHandlerContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8147D10", Offset = "0x8146910", VA = "0x188147D10")]
		internal void KTDAVNLJEHQ(CrmAssignmentDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81483B0", Offset = "0x8146FB0", VA = "0x1881483B0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8147780", Offset = "0x8146380", VA = "0x188147780")]
		private void BNLALFOIVUE(RoomEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class HNPFNWFCVCU : CYQWOSXZXCR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class XZAHEHATUBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CrmAssignmentDTO ZAUQLFPGOWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Task VEHTDVOTPMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public bool SBXCGAGFKXF;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8149AA0", Offset = "0x81486A0", VA = "0x188149AA0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XZAHEHATUBK()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <TryInitialize>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HNPFNWFCVCU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter<CrmAssignmentDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8149600", Offset = "0x8148200", VA = "0x188149600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8149A40", Offset = "0x8148640", VA = "0x188149A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly IGMBDSAWMRJ EHCPCXAGGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CWYBNMIOMIE HLQMZEJKOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly XZAHEHATUBK TEAOTXAZWKI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool SBXCGAGFKXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x81491F0", Offset = "0x8147DF0", VA = "0x1881491F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x81490A0", Offset = "0x8147CA0", VA = "0x1881490A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal CrmAssignmentDTO ZAUQLFPGOWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4005FE0", Offset = "0x4004BE0", VA = "0x184005FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8149210", Offset = "0x8147E10", VA = "0x188149210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Task BZFPAVPPWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x158AB40", Offset = "0x1589740", VA = "0x18158AB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x81494C0", Offset = "0x81480C0", VA = "0x1881494C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OEKRGZZDMWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8149420", Offset = "0x8148020", VA = "0x188149420", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CrmType RCCMTQOBZPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x81490C0", Offset = "0x8147CC0", VA = "0x1881490C0", Slot = "4")]
			get
			{
				return default(CrmType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CrmAssignmentDTO> KTDAVNLJEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8149140", Offset = "0x8147D40", VA = "0x188149140", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8149370", Offset = "0x8147F70", VA = "0x188149370", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81494F0", Offset = "0x81480F0", VA = "0x1881494F0")]
		[Preserve]
		internal HNPFNWFCVCU([Inject(null)] IGMBDSAWMRJ recNetAccounts, [Inject(null)] CWYBNMIOMIE recNetCrmService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8148A90", Offset = "0x8147690", VA = "0x188148A90", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8148CE0", Offset = "0x81478E0", VA = "0x188148CE0", Slot = "8")]
		public Task Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8148C10", Offset = "0x8147810", VA = "0x188148C10")]
		[AsyncStateMachine(typeof(<TryInitialize>d__23))]
		private Task HKOHKHCMLZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8149240", Offset = "0x8147E40", VA = "0x188149240", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8148B30", Offset = "0x8147730", VA = "0x188148B30")]
		[CompilerGenerated]
		private object FLKGGUKYRBM()
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
