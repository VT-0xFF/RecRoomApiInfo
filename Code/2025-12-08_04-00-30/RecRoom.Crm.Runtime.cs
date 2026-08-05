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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UJJLYPDTOGV : QTVQFWWKATO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[Preserve]
		internal UJJLYPDTOGV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public void MFKPGPOOYWT(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void XCQBTTIDKKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81C1A80", Offset = "0x81C0280", VA = "0x1881C1A80", Slot = "6")]
		public void WJNYFWSYFQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81C1A80", Offset = "0x81C0280", VA = "0x1881C1A80", Slot = "7")]
		public void PZZNKTIUPUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81C1A60", Offset = "0x81C0260", VA = "0x1881C1A60", Slot = "8")]
		public void OZDJUZUJQCI(string a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class SCKWGKGGHHQ : PLSPMQMNGJB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly QTVQFWWKATO LHQNKLZPWYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly UUYQXOEWWAP AMPBOWBEICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly DOZBLDLYMUV UXPBZMXAZUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly ABRHTLCJVTL CJJJBBNUZXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BXGIVVXEUAM VJVHJERFUNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly VPWSVWWBFFU UAPRCYUEGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly LQJJUOWYIRI BYMDEFTNGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool RKBABXFNEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CompilerGenerated]
		private Action KAKYAAFCWSX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool IDNYRORTFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA8660", Offset = "0xAA6E60", VA = "0x180AA8660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool QPUQIFQAZRM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D50", Offset = "0xAA6550", VA = "0x180AA7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81C1110", Offset = "0x81BF910", VA = "0x1881C1110")]
		[Preserve]
		internal SCKWGKGGHHQ([Inject(null)][NotNull] QTVQFWWKATO brazeAPI, [Inject(null)][NotNull] UUYQXOEWWAP recNetAccounts, [Inject(null)][NotNull] DOZBLDLYMUV platformNotificationManager, [Inject(null)][NotNull] ABRHTLCJVTL crmManager, [Inject(null)][NotNull] BXGIVVXEUAM roomManager, [Inject(null)][NotNull] VPWSVWWBFFU gameConfigsProvider, [Inject(null)][NotNull] XXWNNZHXIHL statsig, [Inject(null)][NotNull] LQJJUOWYIRI analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81C03F0", Offset = "0x81BEBF0", VA = "0x1881C03F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81C02F0", Offset = "0x81BEAF0", VA = "0x1881C02F0")]
		private void CETTHUELGNQ(PlatformNotification a, PlatformNotificationHandlerContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81C0570", Offset = "0x81BED70", VA = "0x1881C0570")]
		internal void GACGWQGAELM(CrmAssignmentDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81C1000", Offset = "0x81BF800", VA = "0x1881C1000", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81C0C00", Offset = "0x81BF400", VA = "0x1881C0C00")]
		private void IXHZIUAORAY(RoomEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class BUMFGWMJXOQ : ABRHTLCJVTL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KGEGQNZGHHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CrmAssignmentDTO JSLVAPQDHUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Task EBLEICVJBTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public bool FGQUDCOSCRV;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x81C02B0", Offset = "0x81BEAB0", VA = "0x1881C02B0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KGEGQNZGHHG()
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
			public BUMFGWMJXOQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter<CrmAssignmentDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x81C15D0", Offset = "0x81BFDD0", VA = "0x1881C15D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x81C1A00", Offset = "0x81C0200", VA = "0x1881C1A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly UUYQXOEWWAP AMPBOWBEICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BLZYMPJDKBO JQPJWNOWQGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KGEGQNZGHHG XWQVGVNHHOI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool FGQUDCOSCRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x81C00A0", Offset = "0x81BE8A0", VA = "0x1881C00A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x81BF750", Offset = "0x81BDF50", VA = "0x1881BF750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal CrmAssignmentDTO JSLVAPQDHUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5A05F30", Offset = "0x5A04730", VA = "0x185A05F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x81C0170", Offset = "0x81BE970", VA = "0x1881C0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Task XUVKVJPPNDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x15B3460", Offset = "0x15B1C60", VA = "0x1815B3460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x81BFF40", Offset = "0x81BE740", VA = "0x1881BFF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IXCUXPPJMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x81BF770", Offset = "0x81BDF70", VA = "0x1881BF770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CrmType TNSBVZEXJQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x81BFA60", Offset = "0x81BE260", VA = "0x1881BFA60", Slot = "4")]
			get
			{
				return default(CrmType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CrmAssignmentDTO> GACGWQGAELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x81BFAE0", Offset = "0x81BE2E0", VA = "0x1881BFAE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x81C00C0", Offset = "0x81BE8C0", VA = "0x1881C00C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81C01A0", Offset = "0x81BE9A0", VA = "0x1881C01A0")]
		[Preserve]
		internal BUMFGWMJXOQ([Inject(null)] UUYQXOEWWAP recNetAccounts, [Inject(null)] BLZYMPJDKBO recNetCrmService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81BF810", Offset = "0x81BE010", VA = "0x1881BF810", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81BFB90", Offset = "0x81BE390", VA = "0x1881BFB90", Slot = "8")]
		public Task Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81BF990", Offset = "0x81BE190", VA = "0x1881BF990")]
		[AsyncStateMachine(typeof(<TryInitialize>d__23))]
		private Task FFCUZTITDGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81BFF70", Offset = "0x81BE770", VA = "0x1881BFF70", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81BF8B0", Offset = "0x81BE0B0", VA = "0x1881BF8B0")]
		[CompilerGenerated]
		private object EQYSBTPYKHI()
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
