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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class YDOYCKUMZHA : UXLOSDMIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		[Preserve]
		internal YDOYCKUMZHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void OHCXEZYINJI(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void SWMKDFCAMJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84A0640", Offset = "0x849F440", VA = "0x1884A0640", Slot = "6")]
		public void RRCUPHGRFZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84A0640", Offset = "0x849F440", VA = "0x1884A0640", Slot = "7")]
		public void FNODSXURTDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84A0650", Offset = "0x849F450", VA = "0x1884A0650", Slot = "8")]
		public void SZUOUIDCCMD(string a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class ZZVFGDLZDIJ : NBVMKQOBSCO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly UXLOSDMIEHL HNMRKZANOSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MQDSKNLIASK PCCHTWLGDVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MLFRTJYXKFA DOTNVOFAGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly LIRBUQJLPCI CBNQEASGXSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BPKCFRLPRRV ULFEOCUXIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MNPPKFJRFBH AAHYVDZJSGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XCPQFGYWTBQ RIFSMTIEHLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly XGHVQINIOKV ZSXJVNGUFXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool TSXHIGRRWQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CompilerGenerated]
		private Action ELUPZQDBWOQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool BFGWSPBKCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAD1280", Offset = "0xAD0080", VA = "0x180AD1280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool MZKSDFEEYGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AF0", Offset = "0xAD08F0", VA = "0x180AD1AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84A14B0", Offset = "0x84A02B0", VA = "0x1884A14B0")]
		[Preserve]
		internal ZZVFGDLZDIJ([Inject(null)][NotNull] UXLOSDMIEHL brazeAPI, [Inject(null)][NotNull] MQDSKNLIASK recNetAccounts, [Inject(null)][NotNull] MLFRTJYXKFA platformNotificationManager, [Inject(null)][NotNull] LIRBUQJLPCI crmManager, [Inject(null)][NotNull] BPKCFRLPRRV roomManager, [Inject(null)][NotNull] MNPPKFJRFBH gameConfigsProvider, [Inject(null)][NotNull] XCPQFGYWTBQ statsig, [Inject(null)][NotNull] XGHVQINIOKV analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84A0670", Offset = "0x849F470", VA = "0x1884A0670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1290", Offset = "0x84A0090", VA = "0x1884A1290")]
		private void QPEXWZCLMYZ(PlatformNotification a, PlatformNotificationHandlerContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84A07F0", Offset = "0x849F5F0", VA = "0x1884A07F0")]
		internal void LEXXQJGXLNF(CrmAssignmentDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84A1390", Offset = "0x84A0190", VA = "0x1884A1390", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84A0E90", Offset = "0x849FC90", VA = "0x1884A0E90")]
		private void LILJRHFUDBB(RoomEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class MHYTPPVTVDZ : LIRBUQJLPCI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class LPVDJCKKDVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CrmAssignmentDTO KLWQNMSZATL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Task CDHPFNQTSQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public bool BHAWNKQRCGC;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x849F600", Offset = "0x849E400", VA = "0x18849F600")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public LPVDJCKKDVL()
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
			public MHYTPPVTVDZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter<CrmAssignmentDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84A01B0", Offset = "0x849EFB0", VA = "0x1884A01B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84A05E0", Offset = "0x849F3E0", VA = "0x1884A05E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly MQDSKNLIASK PCCHTWLGDVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ALWWWLKCHEB OVFXUSWTCRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LPVDJCKKDVL AVMCXNIYQRP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool BHAWNKQRCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x849FC30", Offset = "0x849EA30", VA = "0x18849FC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x84A0050", Offset = "0x849EE50", VA = "0x1884A0050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal CrmAssignmentDTO KLWQNMSZATL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4F90690", Offset = "0x4F8F490", VA = "0x184F90690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84A0070", Offset = "0x849EE70", VA = "0x1884A0070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Task UCHHSRKSFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1683A60", Offset = "0x1682860", VA = "0x181683A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x849F840", Offset = "0x849E640", VA = "0x18849F840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CQCXKHTYZRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x849FD00", Offset = "0x849EB00", VA = "0x18849FD00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CrmType DYVWLDGMXTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x849F6E0", Offset = "0x849E4E0", VA = "0x18849F6E0", Slot = "4")]
			get
			{
				return default(CrmType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CrmAssignmentDTO> LEXXQJGXLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x849FC50", Offset = "0x849EA50", VA = "0x18849FC50", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x849FFA0", Offset = "0x849EDA0", VA = "0x18849FFA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84A00A0", Offset = "0x849EEA0", VA = "0x1884A00A0")]
		[Preserve]
		internal MHYTPPVTVDZ([Inject(null)] MQDSKNLIASK recNetAccounts, [Inject(null)] ALWWWLKCHEB recNetCrmService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x849F640", Offset = "0x849E440", VA = "0x18849F640", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x849F870", Offset = "0x849E670", VA = "0x18849F870", Slot = "8")]
		public Task Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x849FDA0", Offset = "0x849EBA0", VA = "0x18849FDA0")]
		[AsyncStateMachine(typeof(<TryInitialize>d__23))]
		private Task PFPXJQAQWEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x849FE70", Offset = "0x849EC70", VA = "0x18849FE70", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x849F760", Offset = "0x849E560", VA = "0x18849F760")]
		[CompilerGenerated]
		private object FVCMRILIJRX()
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
