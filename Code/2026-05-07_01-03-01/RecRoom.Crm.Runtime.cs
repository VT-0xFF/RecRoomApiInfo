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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FZKNUSSVGXY : FZLEQITVTUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		[Preserve]
		internal FZKNUSSVGXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public void QDKQBNVAPYW(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
		public void URCFYLSCPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97AA840", Offset = "0x97A9240", VA = "0x1897AA840", Slot = "6")]
		public void AISQCLKBXWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97AA840", Offset = "0x97A9240", VA = "0x1897AA840", Slot = "7")]
		public void IMKTENBYXFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97AA850", Offset = "0x97A9250", VA = "0x1897AA850", Slot = "8")]
		public void MYFFNLUBQXZ(string a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class JIIYMWUAAYB : YUQQZCDFHDM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly FZLEQITVTUR YYBUUBYIFJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly HBQWRBCBWSO DICBJFXZRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly TSHWYQOIFUC QRWUXUOLDLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly WCGVVLFWLNO CKGKROBLZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly FGNKODXRVEL PZEQXPENEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LGHEBYOBKGV ZXMRFEXXLNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XYNTEJINREW VIXJKUCOCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly SMEIDCTWJHT LUXWATDPESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool DYTUYGJLUWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CompilerGenerated]
		private Action YEOOZQMHAIQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool JZTRZRGMTWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2D0", Offset = "0xCD9CD0", VA = "0x180CDB2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool TWRQJLUXIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2B0", Offset = "0xCD9CB0", VA = "0x180CDB2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97AB6B0", Offset = "0x97AA0B0", VA = "0x1897AB6B0")]
		[Preserve]
		internal JIIYMWUAAYB([Inject(null)][NotNull] FZLEQITVTUR brazeAPI, [Inject(null)][NotNull] HBQWRBCBWSO recNetAccounts, [Inject(null)][NotNull] TSHWYQOIFUC platformNotificationManager, [Inject(null)][NotNull] WCGVVLFWLNO crmManager, [Inject(null)][NotNull] FGNKODXRVEL roomManager, [Inject(null)][NotNull] LGHEBYOBKGV gameConfigsProvider, [Inject(null)][NotNull] XYNTEJINREW statsig, [Inject(null)][NotNull] SMEIDCTWJHT analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x97AAC70", Offset = "0x97A9670", VA = "0x1897AAC70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x97AADF0", Offset = "0x97A97F0", VA = "0x1897AADF0")]
		private void NLJPFNDMFJP(PlatformNotification a, PlatformNotificationHandlerContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97AB010", Offset = "0x97A9A10", VA = "0x1897AB010")]
		internal void VJLKCNJAGHJ(CrmAssignmentDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97AAEF0", Offset = "0x97A98F0", VA = "0x1897AAEF0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97AA870", Offset = "0x97A9270", VA = "0x1897AA870")]
		private void BTTCBINSKKX(RoomEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class CVXYJFBIQWL : WCGVVLFWLNO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class MMIDMXRAQIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CrmAssignmentDTO KGCDRCCBLZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Task MLSKJFHAXKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public bool HIQBZHSKWXM;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x97ABB70", Offset = "0x97AA570", VA = "0x1897ABB70")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public MMIDMXRAQIV()
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
			public CVXYJFBIQWL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter<CrmAssignmentDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x97ABBB0", Offset = "0x97AA5B0", VA = "0x1897ABBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x97ABFE0", Offset = "0x97AA9E0", VA = "0x1897ABFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly HBQWRBCBWSO DICBJFXZRYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CLCFZCRGXWR OLYWPCDHQDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MMIDMXRAQIV EVIQUIUBVSF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool HIQBZHSKWXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x97AA3F0", Offset = "0x97A8DF0", VA = "0x1897AA3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x97A9E50", Offset = "0x97A8850", VA = "0x1897A9E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal CrmAssignmentDTO KGCDRCCBLZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69449A0", Offset = "0x69433A0", VA = "0x1869449A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x97AA260", Offset = "0x97A8C60", VA = "0x1897AA260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Task VOETDBXVUWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x18A16C0", Offset = "0x18A00C0", VA = "0x1818A16C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x97A9E70", Offset = "0x97A8870", VA = "0x1897A9E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool SDLEFBKWDAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x97AA690", Offset = "0x97A9090", VA = "0x1897AA690", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CrmType GQBBBLYOQYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x97AA410", Offset = "0x97A8E10", VA = "0x1897AA410", Slot = "4")]
			get
			{
				return default(CrmType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CrmAssignmentDTO> VJLKCNJAGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x97AA290", Offset = "0x97A8C90", VA = "0x1897AA290", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x97AA340", Offset = "0x97A8D40", VA = "0x1897AA340", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x97AA730", Offset = "0x97A9130", VA = "0x1897AA730")]
		[Preserve]
		internal CVXYJFBIQWL([Inject(null)] HBQWRBCBWSO recNetAccounts, [Inject(null)] CLCFZCRGXWR recNetCrmService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97A9DB0", Offset = "0x97A87B0", VA = "0x1897A9DB0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97A9EA0", Offset = "0x97A88A0", VA = "0x1897A9EA0", Slot = "8")]
		public Task Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97AA490", Offset = "0x97A8E90", VA = "0x1897AA490")]
		[AsyncStateMachine(typeof(<TryInitialize>d__23))]
		private Task QWOLGESYFLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97AA560", Offset = "0x97A8F60", VA = "0x1897AA560", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97A9CD0", Offset = "0x97A86D0", VA = "0x1897A9CD0")]
		[CompilerGenerated]
		private object BLCVVAJCGNH()
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
