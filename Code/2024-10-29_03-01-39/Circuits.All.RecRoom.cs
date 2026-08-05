using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x22C4A30", Offset = "0x22C3A30", VA = "0x1822C4A30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BBEDDGOLNGI : IDisposable, IFIFLHGNABH, KPBPBKPGHBL, LKDEBCPMEFE, LBGIIGGCLFM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class KJADFDJPMAC : CAKCBPDDBNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int CFGELINOLEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x22C18E0", Offset = "0x22C08E0", VA = "0x1822C18E0", Slot = "5")]
		public COBDIBOJKOD MHAOOJHMJNN(JPPOPAKFKPF.BPOCMCHBGPP IKBDGBPPCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NEKEIIDKODB();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void IBBMEKDLBEM();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22C18A0", Offset = "0x22C08A0", VA = "0x1822C18A0", Slot = "13")]
		public virtual void GDGJCPFFLOH(BBEDDGOLNGI BFIEGGNBNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22C1820", Offset = "0x22C0820", VA = "0x1822C1820", Slot = "14")]
		public virtual void DHHJPBBHCHJ(BBEDDGOLNGI BFIEGGNBNMB, CFJMCGPIICE NDLMGANFCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		protected KJADFDJPMAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CAKCBPDDBNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int CFGELINOLEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		COBDIBOJKOD MHAOOJHMJNN(JPPOPAKFKPF.BPOCMCHBGPP IKBDGBPPCAB);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NEKEIIDKODB();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IBBMEKDLBEM();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GDGJCPFFLOH(BBEDDGOLNGI BFIEGGNBNMB);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DHHJPBBHCHJ(BBEDDGOLNGI BFIEGGNBNMB, CFJMCGPIICE NDLMGANFCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct IGIELBJNNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FCIELBGBPJB<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> OLHLCHGCLHP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x22BEC60", Offset = "0x22BDC60", VA = "0x1822BEC60")]
		internal IGIELBJNNKB(FCIELBGBPJB<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> PHOINLFJEFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ANBPDLBFCEN : MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ANBPDLBFCEN LONLOOPDCMJ;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		private ANBPDLBFCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x142A560", Offset = "0x1429560", VA = "0x18142A560", Slot = "4")]
		public MOMCKELODOF FLLLBHNMOIF(CFJMCGPIICE GFJPFDOHONG)
		{
			return default(MOMCKELODOF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x22A9CB0", Offset = "0x22A8CB0", VA = "0x1822A9CB0", Slot = "5")]
		public void GDGJCPFFLOH(BBEDDGOLNGI BAOAKGNNKEP, CFJMCGPIICE NDLMGANFCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x22A9BA0", Offset = "0x22A8BA0", VA = "0x1822A9BA0", Slot = "6")]
		public void DHHJPBBHCHJ(BBEDDGOLNGI BAOAKGNNKEP, CFJMCGPIICE NDLMGANFCBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IABDHLEDEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LDIGABEBEBD<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> OLHLCHGCLHP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x22BEC50", Offset = "0x22BDC50", VA = "0x1822BEC50")]
		internal IABDHLEDEAF(LDIGABEBEBD<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22BEC00", Offset = "0x22BDC00", VA = "0x1822BEC00")]
		public static IABDHLEDEAF EJLELCHFLID()
		{
			return default(IABDHLEDEAF);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct KPFMHNLEDPB : LONMEFHAMIO.HDIGBLCADNP<CFJMCGPIICE, BBEDDGOLNGI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct MEAKCPNEBLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public BBEDDGOLNGI receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CFJMCGPIICE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KPFMHNLEDPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x22C3B90", Offset = "0x22C2B90", VA = "0x1822C3B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x22C3D70", Offset = "0x22C2D70", VA = "0x1822C3D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB0A9E0", Offset = "0xB099E0", VA = "0x180B0A9E0", Slot = "4")]
		public FCEODKAEDJI<FIEOABOJMBC> HFMMBMBBEOF(BBEDDGOLNGI BGLJKFHLJGM)
		{
			return default(FCEODKAEDJI<FIEOABOJMBC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x22C34D0", Offset = "0x22C24D0", VA = "0x1822C34D0", Slot = "5")]
		[AsyncStateMachine(typeof(MEAKCPNEBLF))]
		public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> DJACEGEOFCI(BBEDDGOLNGI BGLJKFHLJGM, CFJMCGPIICE NDLMGANFCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22C34B0", Offset = "0x22C24B0", VA = "0x1822C34B0", Slot = "6")]
		public CFJMCGPIICE[] BPIAEHNEPMA(BBEDDGOLNGI BGLJKFHLJGM)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EJGFDFAKAFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BBEDDGOLNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public DPJKEOMANBI rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JPOKLPJBGMB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public DPOFJEJGEFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x22AE6F0", Offset = "0x22AD6F0", VA = "0x1822AE6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x22AE970", Offset = "0x22AD970", VA = "0x1822AE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ONBEECEOCLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BBEDDGOLNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22C5050", Offset = "0x22C4050", VA = "0x1822C5050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22C52E0", Offset = "0x22C42E0", VA = "0x1822C52E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ILPKBFLNDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BBEDDGOLNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x22BEF50", Offset = "0x22BDF50", VA = "0x1822BEF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x22BF130", Offset = "0x22BE130", VA = "0x1822BF130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GOMCKCFEOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public BBEDDGOLNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public CFJMCGPIICE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x22BB2A0", Offset = "0x22BA2A0", VA = "0x1822BB2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x22BB490", Offset = "0x22BA490", VA = "0x1822BB490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EJNDBDKDFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public BBEDDGOLNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x22AE9E0", Offset = "0x22AD9E0", VA = "0x1822AE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x22AF1C0", Offset = "0x22AE1C0", VA = "0x1822AF1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FCEODKAEDJI<FIEOABOJMBC> FACPAOBCPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IGIELBJNNKB MEFLDPOGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AOIJBGKAFCC CCNBCPGPNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly IIFBNMNFIOK PBGBBEALHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NLCDGFHNHBA OHDBHIAOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MGBJLEOMPFP.MDPOGKBGECF HCDAMBIEKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PGJBLGLILPF KFGKBGKDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BEPHFBMMFMM FHBBOIIHCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FLBBKAFFALA FBKAICALPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1990")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EJKIKAMGKCO HIBMOLFHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1998")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CLDGHIOOLNP ABILOPFHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AILEFPALPCL BOJHAFCHDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly AOIJBGKAFCC.AAPLMMEFKDD LKIBCIJIFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly DBDFFFNPCNF BEMIBHIPGHD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AOIJBGKAFCC PGBGBMKCMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22AB2C0", Offset = "0x22AA2C0", VA = "0x1822AB2C0")]
		get
		{
			return default(AOIJBGKAFCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal CAKCBPDDBNM KAOBDMPHKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22AA800", Offset = "0x22A9800", VA = "0x1822AA800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal COBDIBOJKOD OECMCDPFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22AAEE0", Offset = "0x22A9EE0", VA = "0x1822AAEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22AB2D0", Offset = "0x22AA2D0", VA = "0x1822AB2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EJOFCNFFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22AA1F0", Offset = "0x22A91F0", VA = "0x1822AA1F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22AB180", Offset = "0x22AA180", VA = "0x1822AB180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BPOIDGDGCGF CKILNCCNKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x22AB7D0", Offset = "0x22AA7D0", VA = "0x1822AB7D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IBLCDIMFNHL OPJOOJGFCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x22AB7E0", Offset = "0x22AA7E0", VA = "0x1822AB7E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HIOHKLHBHOJ IPPILFDIINP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22AB800", Offset = "0x22AA800", VA = "0x1822AB800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CDPGENLNKMM JKLOGONMBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x22AB7F0", Offset = "0x22AA7F0", VA = "0x1822AB7F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MGBJLEOMPFP? AIAPIHFEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x22AAE60", Offset = "0x22A9E60", VA = "0x1822AAE60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private LPOMMCFINGD? PPEGHDJNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x22AB190", Offset = "0x22AA190", VA = "0x1822AB190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22AB4D0", Offset = "0x22AA4D0", VA = "0x1822AB4D0")]
	private BBEDDGOLNGI(NLCDGFHNHBA PGNIOBCKEAK, FCEODKAEDJI<FIEOABOJMBC> EJNEHCOECHP, [In] IGIELBJNNKB IHPFMNANCHF, [In] AOIJBGKAFCC HBBNLMFGDNJ, [In] IIFBNMNFIOK CDKPJAPDOHA, COBDIBOJKOD AOHMHLKPDIC, [In] MGBJLEOMPFP.MDPOGKBGECF FNPMMPLBNKE, AOIJBGKAFCC.AAPLMMEFKDD KKJOLDCIMJN, DBDFFFNPCNF BOIJJLHDPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22AAD20", Offset = "0x22A9D20", VA = "0x1822AAD20")]
	public static BBEDDGOLNGI EJLELCHFLID(NLCDGFHNHBA IKBDGBPPCAB, [In] OOEPDPBIMMJ NBPALJOLHDB, PNDJEOKCIML NPDOFLMGPPJ, [In] NEMCIPLOPAC FDDPAPFHIGA, PCJBKHMCKCO DDCPMPOCLMO, FCEODKAEDJI<FIEOABOJMBC> EJNEHCOECHP, FCEODKAEDJI<IHHADENBLNO> JDMDBFFKLIG, OJMMLAAPKNG DOPPDHAGGED, FGDNNINANOC DKABEPDKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22AAA40", Offset = "0x22A9A40", VA = "0x1822AAA40")]
	public static BBEDDGOLNGI EJLELCHFLID(NLCDGFHNHBA PGNIOBCKEAK, [In] AOIJBGKAFCC HBBNLMFGDNJ, [In] IIFBNMNFIOK CDKPJAPDOHA, FCEODKAEDJI<FIEOABOJMBC> EJNEHCOECHP, FCEODKAEDJI<IHHADENBLNO> JDMDBFFKLIG, OJMMLAAPKNG DOPPDHAGGED, FGDNNINANOC DKABEPDKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22AA850", Offset = "0x22A9850", VA = "0x1822AA850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22AB2F0", Offset = "0x22AA2F0", VA = "0x1822AB2F0")]
	[AsyncStateMachine(typeof(EJGFDFAKAFC))]
	internal Task<OBFFLKDLIBJ<bool, FGHJECBDJBN>> OPEEJJFJIBF(DPJKEOMANBI LEEIJCNMFOE, JPOKLPJBGMB ENHBGMCFLOO, DPOFJEJGEFI NMDHLPMFPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22AAEF0", Offset = "0x22A9EF0", VA = "0x1822AAEF0")]
	[AsyncStateMachine(typeof(ONBEECEOCLC))]
	public Task<OBFFLKDLIBJ<bool, FGHJECBDJBN>> HHKLOMGCPFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22AA590", Offset = "0x22A9590", VA = "0x1822AA590")]
	[AsyncStateMachine(typeof(ILPKBFLNDAI))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> DABKLLAEHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22A9FE0", Offset = "0x22A8FE0", VA = "0x1822A9FE0")]
	internal void AOEIHDGMEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22AB450", Offset = "0x22AA450", VA = "0x1822AB450")]
	internal BHNGMIADPIG<CFJMCGPIICE> PPOJFCOPIDC([In] AKAIDABCOKM DLKEPFELHEH)
	{
		return default(BHNGMIADPIG<CFJMCGPIICE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x22AA790", Offset = "0x22A9790", VA = "0x1822AA790")]
	internal bool DMHEEIAJIPI([In] AKAIDABCOKM DLKEPFELHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22AAFE0", Offset = "0x22A9FE0", VA = "0x1822AAFE0")]
	internal BHNGMIADPIG<CFJMCGPIICE> HJGGMHNPFOE([In] AKNFMCFCFGH LBEAHGLOJKB)
	{
		return default(BHNGMIADPIG<CFJMCGPIICE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22AA680", Offset = "0x22A9680", VA = "0x1822AA680")]
	[AsyncStateMachine(typeof(GOMCKCFEOJK))]
	internal Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> DJLDNCLIIDA(CFJMCGPIICE NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22AA200", Offset = "0x22A9200", VA = "0x1822AA200")]
	private CFJMCGPIICE[] BPIAEHNEPMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22AB060", Offset = "0x22AA060", VA = "0x1822AB060")]
	[AsyncStateMachine(typeof(EJNDBDKDFLB))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> JAOJOMHNMNA(Guid MHNPGBMGCOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LIGCMODJBPO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x304C080", Offset = "0x304B080", VA = "0x18304C080")]
	public static GPBKJLMPJDE<(TPrev?, BBEDDGOLNGI?), LPOMMCFINGD> OKMCBOLACJA<TPrev>([In] this GPBKJLMPJDE<TPrev, BBEDDGOLNGI> GFJPFDOHONG)
	{
		return default(GPBKJLMPJDE<(TPrev, BBEDDGOLNGI), LPOMMCFINGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x304BE60", Offset = "0x304AE60", VA = "0x18304BE60")]
	public static GPBKJLMPJDE<TPrev?, BBEDDGOLNGI?> DOIDIAPBEFJ<TPrev>([In] this GPBKJLMPJDE<TPrev, BBEDDGOLNGI> GFJPFDOHONG)
	{
		return default(GPBKJLMPJDE<TPrev, BBEDDGOLNGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LIPHNDKCJHJ<TData> : PPOILIOPEKP, NNPOBHFDOBB, HJOFKELFHOB where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GGKCCFNJFJC<IMDHLBELCNK>? POAJAFCNMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData CKGGEHCOAJK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GGKCCFNJFJC<IMDHLBELCNK>? LJEGDKLHIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24ECA00", Offset = "0x24EBA00", VA = "0x1824ECA00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x475A7C0", Offset = "0x47597C0", VA = "0x18475A7C0")]
	internal LIPHNDKCJHJ([In] GGKCCFNJFJC<IMDHLBELCNK>? OIJEHONBJFG, FCEODKAEDJI<ENCMEEMGAFC>? DNFOFOFEIAO, IOKind? APMPPMAINBI, string ABHPFCOODAJ, [In] TData CONAFKKIHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EBIMHBBKMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22ADFF0", Offset = "0x22ACFF0", VA = "0x1822ADFF0")]
	public static OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB> HNEOBPBDDON([In] this HDNNHEPENMP<NFDMJCCKKOH> GCGPCLGKNEG)
	{
		return default(OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4E50", Offset = "0x2DD3E50", VA = "0x182DD4E50")]
	public static OBFFLKDLIBJ<TOk, NNPOBHFDOBB> EBHJLAALFAI<TOk>([In] this OBFFLKDLIBJ<TOk, NNPOBHFDOBB> GFJPFDOHONG, [In] GGKCCFNJFJC<IMDHLBELCNK>? OIJEHONBJFG, FCEODKAEDJI<ENCMEEMGAFC>? DNFOFOFEIAO, IOKind? APMPPMAINBI, string ABHPFCOODAJ) where TOk : notnull
	{
		return default(OBFFLKDLIBJ<TOk, NNPOBHFDOBB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NLCDGFHNHBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LCLBJLFHNEE.PNNFLCHBOCG PKIFPLDDJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JPPOPAKFKPF.BPOCMCHBGPP EBFMOMEBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BBEDDGOLNGI.CAKCBPDDBNM GHDODIJBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HDMJCHBILCF.GGOIENNIAAG IFPBACAPONC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI> MPFBDECMEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MABFKOKBBPE OPNCNDDJCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LENBKECFBMO CPBOIKHHFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KBJIJGMCEEK PKEGMGFGEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MMMOBGGKOHB AFPLNKGIHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MMNIBMJPACE GIBLNJGMDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class POHKOLEBENE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22C5AE0", Offset = "0x22C4AE0", VA = "0x1822C5AE0")]
	public static CFJMCGPIICE MHDIADIMOOB(this CFJMCGPIICE GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22C5A10", Offset = "0x22C4A10", VA = "0x1822C5A10")]
	public static CFJMCGPIICE EBELLMLJPKA(this IHHDNKJKBND GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IHHDNKJKBND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ALIPOKBHPGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BBEDDGOLNGI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IHHDNKJKBND self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x22A9870", Offset = "0x22A8870", VA = "0x1822A9870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x22A9B30", Offset = "0x22A8B30", VA = "0x1822A9B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString DMNEEJMINJG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	private IHHDNKJKBND(ByteString BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22BEE30", Offset = "0x22BDE30", VA = "0x1822BEE30")]
	public static CFJMCGPIICE EDPEDKPCBAH(ByteString BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22BEC70", Offset = "0x22BDC70", VA = "0x1822BEC70")]
	public static DBJDFKLHOGP<MOMCKELODOF, IHHDNKJKBND> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, IHHDNKJKBND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22BED20", Offset = "0x22BDD20", VA = "0x1822BED20")]
	[AsyncStateMachine(typeof(ALIPOKBHPGC))]
	public static Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> DJLDNCLIIDA(BBEDDGOLNGI BAOAKGNNKEP, IHHDNKJKBND GFJPFDOHONG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FJECDKJIBFL
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x22BA640", Offset = "0x22B9640", VA = "0x1822BA640")]
	public static CFJMCGPIICE EDPEDKPCBAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x22BA5D0", Offset = "0x22B95D0", VA = "0x1822BA5D0")]
	public static DBJDFKLHOGP<MOMCKELODOF, FJECDKJIBFL> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, FJECDKJIBFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22BA6E0", Offset = "0x22B96E0", VA = "0x1822BA6E0")]
	public static OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP> KICADFKANDI(BBEDDGOLNGI BAOAKGNNKEP, [In] FJECDKJIBFL GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DCBJOHCONOP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FFDBINPOMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public BBEDDGOLNGI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public DCBJOHCONOP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x22BA1F0", Offset = "0x22B91F0", VA = "0x1822BA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x22BA560", Offset = "0x22B9560", VA = "0x1822BA560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly DPJKEOMANBI? KKKGALNHMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JPOKLPJBGMB? ONJKNIKAAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly DPOFJEJGEFI? OCGGMLLGPII;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x21E39D0", Offset = "0x21E29D0", VA = "0x1821E39D0")]
	private DCBJOHCONOP(DPJKEOMANBI? LEEIJCNMFOE, JPOKLPJBGMB? ENHBGMCFLOO, DPOFJEJGEFI? NMDHLPMFPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22ADEF0", Offset = "0x22ACEF0", VA = "0x1822ADEF0")]
	public static CFJMCGPIICE? EDPEDKPCBAH(DPJKEOMANBI? LEEIJCNMFOE, JPOKLPJBGMB? ENHBGMCFLOO, DPOFJEJGEFI? NMDHLPMFPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x22ADCA0", Offset = "0x22ACCA0", VA = "0x1822ADCA0")]
	public static DBJDFKLHOGP<MOMCKELODOF, DCBJOHCONOP> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, DCBJOHCONOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22ADDB0", Offset = "0x22ACDB0", VA = "0x1822ADDB0")]
	[AsyncStateMachine(typeof(FFDBINPOMIN))]
	public static Task<OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP>> DJLDNCLIIDA(BBEDDGOLNGI BAOAKGNNKEP, DCBJOHCONOP GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct JEPKMOJPOHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OJIKOMCBLCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JEPKMOJPOHE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BBEDDGOLNGI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OBFFLKDLIBJ<object, HJOFKELFHOB>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private OBFFLKDLIBJ<object, HJOFKELFHOB> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OBFFLKDLIBJ<object, HJOFKELFHOB>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22C4B80", Offset = "0x22C3B80", VA = "0x1822C4B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22C4FE0", Offset = "0x22C3FE0", VA = "0x1822C4FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<CFJMCGPIICE> IMJEKKHHGBN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	private JEPKMOJPOHE(IReadOnlyList<CFJMCGPIICE> DGAJIBMPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22BFE20", Offset = "0x22BEE20", VA = "0x1822BFE20")]
	public static CFJMCGPIICE EDPEDKPCBAH(IReadOnlyList<CFJMCGPIICE> DGAJIBMPJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22BFC40", Offset = "0x22BEC40", VA = "0x1822BFC40")]
	public static DBJDFKLHOGP<MOMCKELODOF, JEPKMOJPOHE> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, JEPKMOJPOHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22BFCE0", Offset = "0x22BECE0", VA = "0x1822BFCE0")]
	[AsyncStateMachine(typeof(OJIKOMCBLCF))]
	public static Task<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> DJLDNCLIIDA(BBEDDGOLNGI BAOAKGNNKEP, JEPKMOJPOHE GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct AKNFMCFCFGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int BCEJCMKMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int HOLNAIGPNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] CKGGEHCOAJK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x215DA90", Offset = "0x215CA90", VA = "0x18215DA90")]
	private AKNFMCFCFGH(int DCEOMHJEBBP, int KHAIDMGPIED, byte[] CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22A9540", Offset = "0x22A8540", VA = "0x1822A9540")]
	public static CFJMCGPIICE EDPEDKPCBAH(int DCEOMHJEBBP, int KHAIDMGPIED, ByteString CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22A9620", Offset = "0x22A8620", VA = "0x1822A9620")]
	public static CFJMCGPIICE[] EFFNCDMHBFA(CFJMCGPIICE NDLMGANFCBJ, int BCJOPBPJKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x22A9460", Offset = "0x22A8460", VA = "0x1822A9460")]
	public static DBJDFKLHOGP<MOMCKELODOF, AKNFMCFCFGH> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, AKNFMCFCFGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x22A9750", Offset = "0x22A8750", VA = "0x1822A9750")]
	public static OBFFLKDLIBJ<CFJMCGPIICE, DCDJFOHHJCP> KICADFKANDI(BBEDDGOLNGI BAOAKGNNKEP, [In] AKNFMCFCFGH GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<CFJMCGPIICE, DCDJFOHHJCP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AKAIDABCOKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct HACGNKDGBNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, DCDJFOHHJCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BBEDDGOLNGI root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AKAIDABCOKM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private OBFFLKDLIBJ<bool, DCDJFOHHJCP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, DCDJFOHHJCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x22BB500", Offset = "0x22BA500", VA = "0x1822BB500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x22BBB40", Offset = "0x22BAB40", VA = "0x1822BBB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int BCEJCMKMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int HOLNAIGPNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] CKGGEHCOAJK;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x215DA90", Offset = "0x215CA90", VA = "0x18215DA90")]
	private AKAIDABCOKM(int DCEOMHJEBBP, int KHAIDMGPIED, byte[] CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22A9190", Offset = "0x22A8190", VA = "0x1822A9190")]
	public static CFJMCGPIICE EDPEDKPCBAH(int DCEOMHJEBBP, int KHAIDMGPIED, ByteString CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x22A9270", Offset = "0x22A8270", VA = "0x1822A9270")]
	public static CFJMCGPIICE?[]? LPIKFCGNKJO(int BCJOPBPJKCD, DPJKEOMANBI? LEEIJCNMFOE, JPOKLPJBGMB? ENHBGMCFLOO, DPOFJEJGEFI? NMDHLPMFPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22A8F80", Offset = "0x22A7F80", VA = "0x1822A8F80")]
	public static DBJDFKLHOGP<MOMCKELODOF, AKAIDABCOKM> ACONAHCCLGG(CFJMCGPIICE IOJKCDBEFPG)
	{
		return default(DBJDFKLHOGP<MOMCKELODOF, AKAIDABCOKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22A9060", Offset = "0x22A8060", VA = "0x1822A9060")]
	[AsyncStateMachine(typeof(HACGNKDGBNJ))]
	public static Task<OBFFLKDLIBJ<bool, DCDJFOHHJCP>> DJLDNCLIIDA(BBEDDGOLNGI BAOAKGNNKEP, AKAIDABCOKM GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PGJBLGLILPF : BPOIDGDGCGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OKPPCKCMDBH? LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x22C5910", Offset = "0x22C4910", VA = "0x1822C5910", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	internal PGJBLGLILPF(BBEDDGOLNGI BFIEGGNBNMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PBAFFHEOEOD : OKPPCKCMDBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MPOJCAAMAMA DLNMPPDDJEH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	public PBAFFHEOEOD(BBEDDGOLNGI BFIEGGNBNMB, MPOJCAAMAMA CLAKBPODJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x22C5630", Offset = "0x22C4630", VA = "0x1822C5630", Slot = "4")]
	public OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB> OHIJJAIOMIB(GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<JIHNPCGMGAN> MMPLNFLCEPN)
	{
		return default(OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x22C5350", Offset = "0x22C4350", VA = "0x1822C5350", Slot = "5")]
	public OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB> NNOLOPADDKE(GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<IAIFMMANJAN> LKEMMOGOMAB)
	{
		return default(OBFFLKDLIBJ<KFDIIAKFDFA, NNPOBHFDOBB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LCLBJLFHNEE : ELKIMLJDGFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface PNNFLCHBOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MPOJCAAMAMA> IONDELJDFGH(BBEDDGOLNGI BFIEGGNBNMB, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ, CancellationToken CLIKNEKJHEI);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EHAFEJGIAEB KJFDPCHFLJN(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class INBJDAMJJOA : PNNFLCHBOCG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct FBNHCAEMCJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<MPOJCAAMAMA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public BBEDDGOLNGI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public JPOKLPJBGMB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public DPOFJEJGEFI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<HDMJCHBILCF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x22AF230", Offset = "0x22AE230", VA = "0x1822AF230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x22AF400", Offset = "0x22AE400", VA = "0x1822AF400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly INBJDAMJJOA LONLOOPDCMJ;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		private INBJDAMJJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x22BF1A0", Offset = "0x22BE1A0", VA = "0x1822BF1A0", Slot = "4")]
		[AsyncStateMachine(typeof(FBNHCAEMCJC))]
		public Task<MPOJCAAMAMA> IONDELJDFGH(BBEDDGOLNGI BFIEGGNBNMB, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ, CancellationToken CLIKNEKJHEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x22BF300", Offset = "0x22BE300", VA = "0x1822BF300", Slot = "5")]
		public EHAFEJGIAEB KJFDPCHFLJN(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JMEFJFNIIKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<LCLBJLFHNEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BBEDDGOLNGI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JPOKLPJBGMB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DPOFJEJGEFI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DPJKEOMANBI evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private PNNFLCHBOCG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<MPOJCAAMAMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x22C0370", Offset = "0x22BF370", VA = "0x1822C0370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x22C0870", Offset = "0x22BF870", VA = "0x1822C0870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MPOJCAAMAMA DLNMPPDDJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EHAFEJGIAEB AKGJGPBBLMM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MGBJLEOMPFP AIAPIHFEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x22C3720", Offset = "0x22C2720", VA = "0x1822C3720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LPOMMCFINGD HLJDNHNGCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x22C3600", Offset = "0x22C2600", VA = "0x1822C3600", Slot = "5")]
		get
		{
			return default(LPOMMCFINGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PBAFFHEOEOD HOHOBEOKJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GMDCICKDEGH BEFOMFPKECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xB8E7A0", Offset = "0xB8D7A0", VA = "0x180B8E7A0")]
	private LCLBJLFHNEE(MPOJCAAMAMA CLAKBPODJDK, EHAFEJGIAEB DJDEHDIDCJL, PBAFFHEOEOD GGCDOMOALBH, GMDCICKDEGH CNDACCKIAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x22C3770", Offset = "0x22C2770", VA = "0x1822C3770")]
	[AsyncStateMachine(typeof(JMEFJFNIIKN))]
	public static Task<LCLBJLFHNEE> IIDEAGOGCBF(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22C36C0", Offset = "0x22C26C0", VA = "0x1822C36C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JPPOPAKFKPF : COBDIBOJKOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface BPOCMCHBGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ELKIMLJDGFO> DFCPEBAAAEG(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ, CancellationToken CLIKNEKJHEI);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PMGOHNBJFJH();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BFIIHADBCCG();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class KHOKNADALBL : BPOCMCHBGPP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct JFDPJJMCBAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<ELKIMLJDGFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BBEDDGOLNGI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public DPJKEOMANBI evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public JPOKLPJBGMB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public DPOFJEJGEFI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<LCLBJLFHNEE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x22BFEE0", Offset = "0x22BEEE0", VA = "0x1822BFEE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x22C0220", Offset = "0x22BF220", VA = "0x1822C0220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x22C16C0", Offset = "0x22C06C0", VA = "0x1822C16C0", Slot = "4")]
		[AsyncStateMachine(typeof(JFDPJJMCBAB))]
		public Task<ELKIMLJDGFO> DFCPEBAAAEG(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ, CancellationToken CLIKNEKJHEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PMGOHNBJFJH();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BFIIHADBCCG();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		protected KHOKNADALBL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct AFHOAKLEPKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<ELKIMLJDGFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JPPOPAKFKPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<MKHCENILMPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x22A8D10", Offset = "0x22A7D10", VA = "0x1822A8D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x22A8F10", Offset = "0x22A7F10", VA = "0x1822A8F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HIFEJIOFFFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JPPOPAKFKPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public BBEDDGOLNGI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DPJKEOMANBI evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public JPOKLPJBGMB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DPOFJEJGEFI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<ELKIMLJDGFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x22BBBB0", Offset = "0x22BABB0", VA = "0x1822BBBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x22BC0E0", Offset = "0x22BB0E0", VA = "0x1822BC0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BPOCMCHBGPP PBAEBCPCIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<MKHCENILMPB> DNGCIACECEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<MKHCENILMPB> FDFDPDFDHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource KKJGIJJKAEE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool EJOFCNFFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x93B330", Offset = "0x93A330", VA = "0x18093B330", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93A590", Offset = "0x939590", VA = "0x18093A590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GIKNMPKMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3A0", Offset = "0xA1A3A0", VA = "0x180A1B3A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xEABD40", Offset = "0xEAAD40", VA = "0x180EABD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MCGLCHAICLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x14F2DF0", Offset = "0x14F1DF0", VA = "0x1814F2DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x22C0B80", Offset = "0x22BFB80", VA = "0x1822C0B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ELKIMLJDGFO? EDMBIALIABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9ED0", Offset = "0x8B8ED0", VA = "0x1808B9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22C0E70", Offset = "0x22BFE70", VA = "0x1822C0E70", Slot = "7")]
	[AsyncStateMachine(typeof(AFHOAKLEPKC))]
	public Task<ELKIMLJDGFO> MGHOKCAFJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x22C0F60", Offset = "0x22BFF60", VA = "0x1822C0F60")]
	public JPPOPAKFKPF(BPOCMCHBGPP IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x22C0D10", Offset = "0x22BFD10", VA = "0x1822C0D10", Slot = "8")]
	[AsyncStateMachine(typeof(HIFEJIOFFFJ))]
	public Task JAKCEHEPPNA(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22C0B90", Offset = "0x22BFB90", VA = "0x1822C0B90", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HMMFEKIBPBL : FDADFNLPHKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GMDCICKDEGH ADABFGOGMNJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public HMMFEKIBPBL(GMDCICKDEGH CNDACCKIAKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class MGKGHNKNLBH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class KJDNAPKHMJI<TGraph> : BOOIFAHNHOE where TGraph : HAPCABKPMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph EPDJMPACFCG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual FJAJHMJKDEB? FFNCCFEEBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1327D80", Offset = "0x1326D80", VA = "0x181327D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x46899B0", Offset = "0x46889B0", VA = "0x1846899B0", Slot = "5")]
			get
			{
				return default(FCEODKAEDJI<OMEMEDNNNNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public FCEODKAEDJI<OMEMEDNNNNN>? MOMCAACDMFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x46899D0", Offset = "0x46889D0", VA = "0x1846899D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
		public KJDNAPKHMJI(TGraph ABNOEFGAADG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JCJGEOJDIFI : KJDNAPKHMJI<DGLPJIPFGBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FJAJHMJKDEB? FFNCCFEEBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x22BF390", Offset = "0x22BE390", VA = "0x1822BF390", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x22BF3B0", Offset = "0x22BE3B0", VA = "0x1822BF3B0")]
		public JCJGEOJDIFI(DGLPJIPFGBJ DNIHPKEDABO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22C3DE0", Offset = "0x22C2DE0", VA = "0x1822C3DE0")]
	public static BOOIFAHNHOE EJLELCHFLID(HAPCABKPMLK ABNOEFGAADG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class HJPBNIHKMEC : DPJHFMNLECA, MMIDPNEOGKG, ABNPAAPNOHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class BCBHEBMCEHC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public BCBHEBMCEHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public MABFKOKBBPE errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x22C5BF0", Offset = "0x22C4BF0", VA = "0x1822C5BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x22C5E60", Offset = "0x22C4E60", VA = "0x1822C5E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HJPBNIHKMEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BCBHEBMCEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x22AB810", Offset = "0x22AA810", VA = "0x1822AB810")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task JEADPHEGBFE(MABFKOKBBPE errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KOIIFKLKMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HJPBNIHKMEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x22C2F40", Offset = "0x22C1F40", VA = "0x1822C2F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x22C3450", Offset = "0x22C2450", VA = "0x1822C3450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OACLNGHHLIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public OACLNGHHLIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x22C5EC0", Offset = "0x22C4EC0", VA = "0x1822C5EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x22C61A0", Offset = "0x22C51A0", VA = "0x1822C61A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HJPBNIHKMEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OACLNGHHLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x22C4AB0", Offset = "0x22C3AB0", VA = "0x1822C4AB0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task EAFBEOCLFBG(MABFKOKBBPE errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JLKPIKKEAEN KGHFAIDFMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<NKLDBPFAFIE> BLNGPEKDHHO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private NLCDGFHNHBA FKIJPKLLNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x22BC630", Offset = "0x22BB630", VA = "0x1822BC630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FCEODKAEDJI<JIHNPCGMGAN> KODJNPDOELF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB46860", Offset = "0xB45860", VA = "0x180B46860", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FCEODKAEDJI<JIHNPCGMGAN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB484A0", Offset = "0xB474A0", VA = "0x180B484A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private FCEODKAEDJI<KKOGEBIBMKE> GJOMPLANGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEA5CC0", Offset = "0xEA4CC0", VA = "0x180EA5CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public FCEODKAEDJI<IDMOAGMBHCD> DMAEEKAFNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE10", Offset = "0x8DBE10", VA = "0x1808DCE10", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FCEODKAEDJI<IDMOAGMBHCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override FCEODKAEDJI<ENCMEEMGAFC> NBHDOBAJEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x22BC6F0", Offset = "0x22BB6F0", VA = "0x1822BC6F0", Slot = "20")]
		get
		{
			return default(FCEODKAEDJI<ENCMEEMGAFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool EMGLJGGFNGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x22BE0F0", Offset = "0x22BD0F0", VA = "0x1822BE0F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22BE970", Offset = "0x22BD970", VA = "0x1822BE970")]
	private HJPBNIHKMEC(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI, JLKPIKKEAEN NIMEPOJNGEG, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<JIHNPCGMGAN> MMPLNFLCEPN, FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, bool MGHDOJGGAPE, string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22BC970", Offset = "0x22BB970", VA = "0x1822BC970")]
	public static HJPBNIHKMEC EJLELCHFLID(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI, JLKPIKKEAEN EDAMLOGMMEK, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, FCEODKAEDJI<JIHNPCGMGAN> MMPLNFLCEPN, bool MGHDOJGGAPE, bool MLBPDNMLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22BC650", Offset = "0x22BB650", VA = "0x1822BC650", Slot = "21")]
	protected override void CPDDJGLEDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22BC800", Offset = "0x22BB800", VA = "0x1822BC800", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22BC140", Offset = "0x22BB140", VA = "0x1822BC140", Slot = "30")]
	public void AAINJOBMDMC(NKLDBPFAFIE NGHMJJGOBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22BE170", Offset = "0x22BD170", VA = "0x1822BE170", Slot = "27")]
	public void OGCJONDGHKD(AGBDGPANEPP HNPIAGKEMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22BD390", Offset = "0x22BC390", VA = "0x1822BD390", Slot = "28")]
	public void IKFIJFJAOJE(FMBJCGHGOGL OFNGHPPKKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22BC4E0", Offset = "0x22BB4E0", VA = "0x1822BC4E0", Slot = "23")]
	protected override void CACBIILDCFM(PDPLHJCEOFC CCLHNNFMGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22BD000", Offset = "0x22BC000", VA = "0x1822BD000", Slot = "32")]
	public string GHNCDCCNMDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22BE6B0", Offset = "0x22BD6B0", VA = "0x1822BE6B0", Slot = "29")]
	public string PFIIAOLCJAI(int FDICHMHOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22BD160", Offset = "0x22BC160", VA = "0x1822BD160")]
	private void GLNLOLPPJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22BE030", Offset = "0x22BD030", VA = "0x1822BE030", Slot = "31")]
	public void NHBBFJEBDNB(NKLDBPFAFIE NGHMJJGOBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE40", Offset = "0x22BBE40", VA = "0x1822BCE40")]
	private void GHFKJLGCAAG(bool BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x22BDD30", Offset = "0x22BCD30", VA = "0x1822BDD30", Slot = "33")]
	[AsyncStateMachine(typeof(KOIIFKLKMOJ))]
	public Task JKEIOBHHNPE(string BJDKOHEGDOK, bool AEKHJFNBFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x22BE560", Offset = "0x22BD560", VA = "0x1822BE560")]
	public void OLBLPJPGCOI(string BJDKOHEGDOK, bool AEKHJFNBFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x22BC280", Offset = "0x22BB280", VA = "0x1822BC280")]
	private void BEFPJCGODDG(int BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB484A0", Offset = "0xB474A0", VA = "0x180B484A0")]
	internal void IHCGEBCILJK(FCEODKAEDJI<JIHNPCGMGAN> BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x22BCD20", Offset = "0x22BBD20", VA = "0x1822BCD20")]
	[CompilerGenerated]
	private void EKLKEAFLKDG(string BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x22BC740", Offset = "0x22BB740", VA = "0x1822BC740")]
	[CompilerGenerated]
	private bool DGCEBCKOJFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22BC420", Offset = "0x22BB420", VA = "0x1822BC420")]
	[CompilerGenerated]
	private bool BGCMNBFKDGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x22BDFE0", Offset = "0x22BCFE0", VA = "0x1822BDFE0")]
	[CompilerGenerated]
	private int PKFCAJILHKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22BC1A0", Offset = "0x22BB1A0", VA = "0x1822BC1A0")]
	[CompilerGenerated]
	private bool AOJBDIOPCDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22BDF00", Offset = "0x22BCF00", VA = "0x1822BDF00")]
	[CompilerGenerated]
	private void LFCNOHGLNJG(string BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22BDE40", Offset = "0x22BCE40", VA = "0x1822BDE40")]
	[CompilerGenerated]
	private bool JLBJAFKNFKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22BC230", Offset = "0x22BB230", VA = "0x1822BC230")]
	[CompilerGenerated]
	private bool APPKNKLEOPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22BCDB0", Offset = "0x22BBDB0", VA = "0x1822BCDB0")]
	[CompilerGenerated]
	private bool GCNFLGJBEKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22BDFE0", Offset = "0x22BCFE0", VA = "0x1822BDFE0")]
	[CompilerGenerated]
	private int NGGIFHJMBMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22BDF10", Offset = "0x22BCF10", VA = "0x1822BDF10")]
	[CompilerGenerated]
	private bool LKGKMEAHMIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x22BCD30", Offset = "0x22BBD30", VA = "0x1822BCD30")]
	[CompilerGenerated]
	private object FOKJBNANBPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22BE4E0", Offset = "0x22BD4E0", VA = "0x1822BE4E0")]
	[CompilerGenerated]
	private void OIBJDKNLIEB(object BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x22BC8A0", Offset = "0x22BB8A0", VA = "0x1822BC8A0")]
	[CompilerGenerated]
	private bool EIBHPDPAKCJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KKGHNCIBBAB
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class IIOOLPBGKCM : BEKOHDADJKB<MNFLOICDIFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override LJPAABOJMBN DEDLBHOBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x941F20", Offset = "0x940F20", VA = "0x180941F20", Slot = "126")]
			get
			{
				return default(LJPAABOJMBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x22BEEF0", Offset = "0x22BDEF0", VA = "0x1822BEEF0")]
		public IIOOLPBGKCM(BBEDDGOLNGI BFIEGGNBNMB, MNFLOICDIFJ PHOINLFJEFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NCCACCGFLHD : NAEDGBHPGMP<FANKCOEHCDI>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x22C49C0", Offset = "0x22C39C0", VA = "0x1822C49C0")]
		public NCCACCGFLHD(BBEDDGOLNGI BFIEGGNBNMB, FANKCOEHCDI CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x22C47F0", Offset = "0x22C37F0", VA = "0x1822C47F0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x22C4970", Offset = "0x22C3970", VA = "0x1822C4970")]
		[CompilerGenerated]
		private bool OALGMOIDNJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x22C46D0", Offset = "0x22C36D0", VA = "0x1822C46D0")]
		[CompilerGenerated]
		private void CFLKADGPEOP(bool BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class KCGMMIFKCBN : NAEDGBHPGMP<IPGDMDFLIMP>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class EIMMMAMCNEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public KCGMMIFKCBN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public EIMMMAMCNEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x22AE6A0", Offset = "0x22AD6A0", VA = "0x1822AE6A0")]
			internal void PNGABOJOMPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x22AE490", Offset = "0x22AD490", VA = "0x1822AE490")]
			internal bool FAMOKMKDKKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x22AE4E0", Offset = "0x22AD4E0", VA = "0x1822AE4E0")]
			internal bool FDMPEPACCLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x22AE530", Offset = "0x22AD530", VA = "0x1822AE530")]
			internal void KJNPAOHKELN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x22AE650", Offset = "0x22AD650", VA = "0x1822AE650")]
			internal bool NJDCIIADDJC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x22C1650", Offset = "0x22C0650", VA = "0x1822C1650")]
		public KCGMMIFKCBN(BBEDDGOLNGI BFIEGGNBNMB, IPGDMDFLIMP CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x22C1310", Offset = "0x22C0310", VA = "0x1822C1310", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class JECMNMDHHKL : NAEDGBHPGMP<EAPGHDCMBJM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class MJFIDHBMGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public JECMNMDHHKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public MJFIDHBMGCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x22C45D0", Offset = "0x22C35D0", VA = "0x1822C45D0")]
			internal object PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x22C3F70", Offset = "0x22C2F70", VA = "0x1822C3F70")]
			internal bool AGDNAAGEMMJ(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x22C4110", Offset = "0x22C3110", VA = "0x1822C4110")]
			internal void FAMOKMKDKKI(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x22C4360", Offset = "0x22C3360", VA = "0x1822C4360")]
			internal string FDMPEPACCLB(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x22C44C0", Offset = "0x22C34C0", VA = "0x1822C44C0")]
			internal IReadOnlyList<object> KJNPAOHKELN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x22C4510", Offset = "0x22C3510", VA = "0x1822C4510")]
			internal bool NJDCIIADDJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x22C4580", Offset = "0x22C3580", VA = "0x1822C4580")]
			internal bool NKGNNNLAKJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x22C3FF0", Offset = "0x22C2FF0", VA = "0x1822C3FF0")]
			internal void CFMGDNFEKBF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x22BFBD0", Offset = "0x22BEBD0", VA = "0x1822BFBD0")]
		public JECMNMDHHKL(BBEDDGOLNGI BFIEGGNBNMB, EAPGHDCMBJM CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x22BF480", Offset = "0x22BE480", VA = "0x1822BF480", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KBIFFKABKKJ : NAEDGBHPGMP<JGLMNAABCFD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class CKAOCFBJPKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KBIFFKABKKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public CKAOCFBJPKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x22ADC50", Offset = "0x22ACC50", VA = "0x1822ADC50")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x22ADAE0", Offset = "0x22ACAE0", VA = "0x1822ADAE0")]
			internal void FAMOKMKDKKI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x22ADC00", Offset = "0x22ACC00", VA = "0x1822ADC00")]
			internal bool FDMPEPACCLB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x22C12A0", Offset = "0x22C02A0", VA = "0x1822C12A0")]
		public KBIFFKABKKJ(BBEDDGOLNGI BFIEGGNBNMB, JGLMNAABCFD CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x22C1070", Offset = "0x22C0070", VA = "0x1822C1070", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class MCKHOKFHGHM<TNode> : NAEDGBHPGMP<TNode> where TNode : notnull, DFPEMFAICCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct JMMOAKLOGKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public MCKHOKFHGHM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x45AC0B0", Offset = "0x45AB0B0", VA = "0x1845AC0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x45AC4B0", Offset = "0x45AB4B0", VA = "0x1845AC4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct EDEOKLBCPKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public MCKHOKFHGHM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3C4A7F0", Offset = "0x3C497F0", VA = "0x183C4A7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3C4ABF0", Offset = "0x3C49BF0", VA = "0x183C4ABF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool JKDNDADNJHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override FCEODKAEDJI<OAOFJLCKBCA>? GODHPJAPEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4931D70", Offset = "0x4930D70", VA = "0x184931D70", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4768770", Offset = "0x4767770", VA = "0x184768770")]
		protected MCKHOKFHGHM(BBEDDGOLNGI BFIEGGNBNMB, TNode CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4931AA0", Offset = "0x4930AA0", VA = "0x184931AA0", Slot = "100")]
		[AsyncStateMachine(typeof(MCKHOKFHGHM<>.JMMOAKLOGKO))]
		public override Task<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> MMCLHLDGLNC(string DMCFPOLFNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4931960", Offset = "0x4930960", VA = "0x184931960", Slot = "124")]
		public sealed override bool IKOKPOEJCJE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4931BC0", Offset = "0x4930BC0", VA = "0x184931BC0", Slot = "112")]
		protected sealed override bool NDJPBEKFIPI(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4931A00", Offset = "0x4930A00", VA = "0x184931A00", Slot = "113")]
		protected override bool MDDCOPMAMGB(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4931C60", Offset = "0x4930C60", VA = "0x184931C60", Slot = "101")]
		[AsyncStateMachine(typeof(MCKHOKFHGHM<>.EDEOKLBCPKH))]
		public override Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> PCNOKLALDDA(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class LCMBKPOIGGD : PHOOLPHLEBB<DEBDDGNHLKI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class AOEAKAHCLFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public LCMBKPOIGGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public AOEAKAHCLFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x22A9E20", Offset = "0x22A8E20", VA = "0x1822A9E20")]
			internal bool BAPIHCNKLHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x22A9EA0", Offset = "0x22A8EA0", VA = "0x1822A9EA0")]
			internal void PCDAMGLFIFK(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x22C3B30", Offset = "0x22C2B30", VA = "0x1822C3B30")]
		public LCMBKPOIGGD(BBEDDGOLNGI BFIEGGNBNMB, DEBDDGNHLKI PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x22C38E0", Offset = "0x22C28E0", VA = "0x1822C38E0", Slot = "126")]
		protected override void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class AFCJCIBJDOA : KCCPCGCGMLE<DENABOBABBD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x22A8CB0", Offset = "0x22A7CB0", VA = "0x1822A8CB0")]
		public AFCJCIBJDOA(BBEDDGOLNGI BFIEGGNBNMB, DENABOBABBD CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class KCCPCGCGMLE<TNode> : NAEDGBHPGMP<TNode> where TNode : notnull, HONJPFMKNEP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct NEDBOOMKKPG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x49C6850", Offset = "0x49C5850", VA = "0x1849C6850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x49C6D00", Offset = "0x49C5D00", VA = "0x1849C6D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct JKLCEKOPCDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x45A49E0", Offset = "0x45A39E0", VA = "0x1845A49E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x45A4E70", Offset = "0x45A3E70", VA = "0x1845A4E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct MIIPIMEAGIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x49519D0", Offset = "0x49509D0", VA = "0x1849519D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x49520A0", Offset = "0x49510A0", VA = "0x1849520A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FPDLAADFBGE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public FPDLAADFBGE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x393E8E0", Offset = "0x393D8E0", VA = "0x18393E8E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public IHMICECIEIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FPDLAADFBGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x401DF20", Offset = "0x401CF20", VA = "0x18401DF20")]
			internal bool CFMGDNFEKBF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x401E430", Offset = "0x401D430", VA = "0x18401E430")]
			internal void PNGABOJOMPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x401DE80", Offset = "0x401CE80", VA = "0x18401DE80")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.FPDLAADFBGE.<<BuildConfigMenuInternal>b__7>d))]
			internal void AGDNAAGEMMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x401E000", Offset = "0x401D000", VA = "0x18401E000")]
			internal bool FAMOKMKDKKI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class LLDMCMBKFAI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public LLDMCMBKFAI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x393E560", Offset = "0x393D560", VA = "0x18393E560", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public FPDLAADFBGE CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public LLDMCMBKFAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x475D660", Offset = "0x475C660", VA = "0x18475D660")]
			internal void FDMPEPACCLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			internal string KJNPAOHKELN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			internal void NJDCIIADDJC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x475DA80", Offset = "0x475CA80", VA = "0x18475DA80")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.LLDMCMBKFAI.<<BuildConfigMenuInternal>b__5>d))]
			internal void NKGNNNLAKJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class FHIPDAPLFKB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public FHIPDAPLFKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x393E090", Offset = "0x393D090", VA = "0x18393E090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public FHIPDAPLFKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<KKOGEBIBMKE>, FGHJECBDJBN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x393E270", Offset = "0x393D270", VA = "0x18393E270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public FHIPDAPLFKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<PLLHIIMKMMI>, FGHJECBDJBN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x393D9C0", Offset = "0x393C9C0", VA = "0x18393D9C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public IHMICECIEIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public MJCJHKBHLNK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public HFDGOBILPDJ selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<BJNHBEDOFDB> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public HFDGOBILPDJ selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<BJNHBEDOFDB> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FHIPDAPLFKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4002800", Offset = "0x4001800", VA = "0x184002800")]
			internal bool LDLFOBILFGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x40022D0", Offset = "0x40012D0", VA = "0x1840022D0")]
			internal void ECKOCBHIKOH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4002670", Offset = "0x4001670", VA = "0x184002670")]
			internal bool ILAFJJGBEEH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4002750", Offset = "0x4001750", VA = "0x184002750")]
			internal bool IMBJADEJJDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x40028B0", Offset = "0x40018B0", VA = "0x1840028B0")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.FHIPDAPLFKB.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void LHBBLMGIGKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4002870", Offset = "0x4001870", VA = "0x184002870")]
			internal bool LEEJACOPHCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4002210", Offset = "0x4001210", VA = "0x184002210")]
			internal void BCAMHPJOIJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4002560", Offset = "0x4001560", VA = "0x184002560")]
			internal bool IBELJECEJKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4002150", Offset = "0x4001150", VA = "0x184002150")]
			internal void AOCMFKGFNGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4002A20", Offset = "0x4001A20", VA = "0x184002A20")]
			internal bool PLCMHALDDDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4002790", Offset = "0x4001790", VA = "0x184002790")]
			internal bool LDCAEAFMMIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4002450", Offset = "0x4001450", VA = "0x184002450")]
			internal void HJAAALMHKDF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x40024C0", Offset = "0x40014C0", VA = "0x1840024C0")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.FHIPDAPLFKB.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void HJHIPPDIPDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4002610", Offset = "0x4001610", VA = "0x184002610")]
			internal bool IEIEIAGMPGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4002950", Offset = "0x4001950", VA = "0x184002950")]
			internal bool LJNIALGINPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4002340", Offset = "0x4001340", VA = "0x184002340")]
			internal void GKFLFLFHJNN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x40023B0", Offset = "0x40013B0", VA = "0x1840023B0")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.FHIPDAPLFKB.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void GLCKCIIJILH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x40029C0", Offset = "0x40019C0", VA = "0x1840029C0")]
			internal bool OELDAIGBBJO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class PIEAEMJPBID
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public PIEAEMJPBID <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x393DCB0", Offset = "0x393CCB0", VA = "0x18393DCB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public FHIPDAPLFKB CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public PIEAEMJPBID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4BE5FC0", Offset = "0x4BE4FC0", VA = "0x184BE5FC0")]
			internal void PDPLMBOCADN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			internal string HBLPBFMBCOP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			internal void IJJDIKLAALA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x4BE5F20", Offset = "0x4BE4F20", VA = "0x184BE5F20")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.PIEAEMJPBID.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void IGGOKNDCFKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class LHMLKBELLNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MJCJHKBHLNK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<BJNHBEDOFDB> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public KCCPCGCGMLE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public LHMLKBELLNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4748110", Offset = "0x4747110", VA = "0x184748110")]
			internal bool OPLFNAANMFD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class DADDGKEDKBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ABNPAAPNOHH port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public LHMLKBELLNP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public DADDGKEDKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x5D248D0", Offset = "0x5D238D0", VA = "0x185D248D0")]
			internal void MNIFNOBJCJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x5D24760", Offset = "0x5D23760", VA = "0x185D24760")]
			internal bool CANLCLGEHGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x5D247B0", Offset = "0x5D237B0", VA = "0x185D247B0")]
			internal void KJMOEGOAHNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x5D249E0", Offset = "0x5D239E0", VA = "0x185D249E0")]
			internal bool OKAEGIMHBNB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class OCMHHIBBNAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public BJNHBEDOFDB portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public DADDGKEDKBD CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public OCMHHIBBNAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4AEA4E0", Offset = "0x4AE94E0", VA = "0x184AEA4E0")]
			internal void MHPOFMOCAJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class GNFINNMGEKP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public GNFINNMGEKP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x393FD50", Offset = "0x393ED50", VA = "0x18393FD50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public HFDGOBILPDJ selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public MJCJHKBHLNK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public ABNPAAPNOHH port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GNFINNMGEKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x418F460", Offset = "0x418E460", VA = "0x18418F460")]
			internal int DLHGJHJDDNP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x418F210", Offset = "0x418E210", VA = "0x18418F210")]
			internal void CDDGOAIOIDK(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			internal string IFFMFNIPBOA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x418F150", Offset = "0x418E150", VA = "0x18418F150")]
			[AsyncStateMachine(typeof(KCCPCGCGMLE<>.GNFINNMGEKP.<<CreatePortItemV2>b__3>d))]
			internal void BHADPGMDOCH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x418F4A0", Offset = "0x418E4A0", VA = "0x18418F4A0")]
			internal bool GPLONAENOJD(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> BLKJACAIBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> GFABMCJABCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> LIHBLJDCCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> CDALPLCKEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> JFGMBAOPLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<FCEODKAEDJI<OAOFJLCKBCA>, bool> CPDOEKFGDFI;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool JHINDFHMOFG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool GPOEOKFJKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool AKINJFCMGHF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool GNCNJECNFLL
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override FCEODKAEDJI<OMEMEDNNNNN>? AIGABCLHHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x46663A0", Offset = "0x46653A0", VA = "0x1846663A0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FCEODKAEDJI<OAOFJLCKBCA>? GODHPJAPEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4666670", Offset = "0x4665670", VA = "0x184666670", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>>? DOPBIDNCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4666460", Offset = "0x4665460", VA = "0x184666460", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4666180", Offset = "0x4665180", VA = "0x184666180")]
		public KCCPCGCGMLE(BBEDDGOLNGI BFIEGGNBNMB, TNode CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "129")]
		protected virtual bool AIAAFNPEPMK(int NMPGFNHOLDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "130")]
		protected virtual bool AIFOKKEBEGO(int NMPGFNHOLDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "131")]
		protected virtual bool IPABFDAJLFD(int NMPGFNHOLDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "132")]
		protected virtual void ODHINEJLOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4661D90", Offset = "0x4660D90", VA = "0x184661D90", Slot = "124")]
		public override bool IKOKPOEJCJE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x46652F0", Offset = "0x46642F0", VA = "0x1846652F0", Slot = "100")]
		[AsyncStateMachine(typeof(KCCPCGCGMLE<>.NEDBOOMKKPG))]
		public override Task<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> MMCLHLDGLNC(string DMCFPOLFNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4666070", Offset = "0x4665070", VA = "0x184666070", Slot = "101")]
		[AsyncStateMachine(typeof(KCCPCGCGMLE<>.JKLCEKOPCDI))]
		public override Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> PCNOKLALDDA(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x46617D0", Offset = "0x46607D0", VA = "0x1846617D0", Slot = "102")]
		public override void EMLBINBMGHM(FCEODKAEDJI<OAOFJLCKBCA> KHAIDMGPIED, FCEODKAEDJI<OAOFJLCKBCA> CECLKDDLGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4661B10", Offset = "0x4660B10", VA = "0x184661B10", Slot = "103")]
		public override IEnumerable<CFJMCGPIICE> HKDILKNINAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4661970", Offset = "0x4660970", VA = "0x184661970")]
		[AsyncStateMachine(typeof(KCCPCGCGMLE<>.MIIPIMEAGIP))]
		private Task<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> ENNBGOMDMII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "133")]
		protected virtual bool KBNGFBGNCEE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "134")]
		protected virtual bool HJBDLGKLFIM(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "135")]
		protected virtual bool FKACNCOOAFJ(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "136")]
		protected virtual bool HILLKDJPNAA(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "137")]
		protected virtual bool PLEBICLMEMG(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int GLHGOOONDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "138")]
		protected virtual bool BHPMLFFEBKK(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int GLHGOOONDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "139")]
		protected virtual bool OJNFLDIFNLE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int PCNDPBHMGLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "140")]
		protected virtual bool PGPOIPGOBNG(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int PCNDPBHMGLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "141")]
		protected virtual bool GKLIPNCBCIK(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int KLCJBCDLHHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "142")]
		protected virtual bool HNLNADKILPD(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, int HDFKMLJJHIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4661E30", Offset = "0x4660E30", VA = "0x184661E30", Slot = "143")]
		protected virtual List<HFDGOBILPDJ> JEHEMOLOLCO(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "144")]
		protected virtual void LMDGIKGHMNJ(IHMICECIEIN CEGALCHFBFE, NNPOGLKAKEH BBJOGPDLIGO, MJCJHKBHLNK DOEDMOCBPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4665600", Offset = "0x4664600", VA = "0x184665600", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4663210", Offset = "0x4662210", VA = "0x184663210")]
		private NNPOGLKAKEH LIFGBGJKEBP(IHMICECIEIN CEGALCHFBFE, MJCJHKBHLNK DOEDMOCBPOH, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x46620D0", Offset = "0x46610D0", VA = "0x1846620D0")]
		private List<BJNHBEDOFDB> KECOAKIAABD(IHMICECIEIN CEGALCHFBFE, MJCJHKBHLNK DOEDMOCBPOH, NNPOGLKAKEH GGLMEGJBNON, bool GHPOJDLNEJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4664990", Offset = "0x4663990", VA = "0x184664990")]
		private List<BJNHBEDOFDB> MLKPGBOOFEK(IHMICECIEIN CEGALCHFBFE, MJCJHKBHLNK DOEDMOCBPOH, ABNPAAPNOHH FBADOLDPNBJ, bool GHPOJDLNEJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4665410", Offset = "0x4664410", VA = "0x184665410")]
		private HFDGOBILPDJ MMNHDCBNGBO(List<HFDGOBILPDJ> GEFKHOCKOJC, ABNPAAPNOHH FBADOLDPNBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4661A70", Offset = "0x4660A70", VA = "0x184661A70")]
		[CompilerGenerated]
		private CFJMCGPIICE EPHPLMJLCBD(JENJIJHPILB MEJGJHNGKCJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class BDHHAANNFGG : NAEDGBHPGMP<HCOPAOKFKAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class JJDFFKNGBJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public BDHHAANNFGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public JJDFFKNGBJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x22C0320", Offset = "0x22BF320", VA = "0x1822C0320")]
			internal int PNGABOJOMPN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x22C0290", Offset = "0x22BF290", VA = "0x1822C0290")]
			internal void FAMOKMKDKKI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x22ABAC0", Offset = "0x22AAAC0", VA = "0x1822ABAC0")]
		public BDHHAANNFGG(BBEDDGOLNGI BFIEGGNBNMB, HCOPAOKFKAJ CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22AB900", Offset = "0x22AA900", VA = "0x1822AB900", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class JMKKDPNKABF : PHOOLPHLEBB<IBAHEBJMDGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class BFLHLDHAIND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public JMKKDPNKABF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public BFLHLDHAIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x22ABB30", Offset = "0x22AAB30", VA = "0x1822ABB30")]
			internal int BAPIHCNKLHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x22ABBB0", Offset = "0x22AABB0", VA = "0x1822ABBB0")]
			internal void PCDAMGLFIFK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x22C0B20", Offset = "0x22BFB20", VA = "0x1822C0B20")]
		public JMKKDPNKABF(BBEDDGOLNGI BFIEGGNBNMB, IBAHEBJMDGJ PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x22C08E0", Offset = "0x22BF8E0", VA = "0x1822C08E0", Slot = "126")]
		protected override void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class HPAIOCDIIHP : NAEDGBHPGMP<NIMGLMBCLEE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9DADF0", Offset = "0x9D9DF0", VA = "0x1809DADF0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x22BEB90", Offset = "0x22BDB90", VA = "0x1822BEB90")]
		public HPAIOCDIIHP(BBEDDGOLNGI BFIEGGNBNMB, NIMGLMBCLEE CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class BNFFCKHJJLG : NAEDGBHPGMP<MPCPOEGFDOH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class FELOBGKIDFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public BNFFCKHJJLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public IHMICECIEIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FELOBGKIDFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x22BA040", Offset = "0x22B9040", VA = "0x1822BA040")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x22B0C60", Offset = "0x22AFC60", VA = "0x1822B0C60")]
			internal void FAMOKMKDKKI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x22B3730", Offset = "0x22B2730", VA = "0x1822B3730")]
			internal bool NJDCIIADDJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x22B3780", Offset = "0x22B2780", VA = "0x1822B3780")]
			internal bool NKGNNNLAKJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x22AFE00", Offset = "0x22AEE00", VA = "0x1822AFE00")]
			internal void CFMGDNFEKBF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x22B1820", Offset = "0x22B0820", VA = "0x1822B1820")]
			internal bool HIFHHPEDFEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x22AF8B0", Offset = "0x22AE8B0", VA = "0x1822AF8B0")]
			internal bool BANNBNBGMIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x22B2080", Offset = "0x22B1080", VA = "0x1822B2080")]
			internal void IHBAFKCIMMH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x22B2FA0", Offset = "0x22B1FA0", VA = "0x1822B2FA0")]
			internal bool LOHMGPBJPEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x22B1EF0", Offset = "0x22B0EF0", VA = "0x1822B1EF0")]
			internal bool IFFHOAFDDIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x22B3680", Offset = "0x22B2680", VA = "0x1822B3680")]
			internal void NFNHAICNONB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x22B24F0", Offset = "0x22B14F0", VA = "0x1822B24F0")]
			internal bool JIILIHAAONI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x22B1A20", Offset = "0x22B0A20", VA = "0x1822B1A20")]
			internal bool HNFILFBIIKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x22B2A40", Offset = "0x22B1A40", VA = "0x1822B2A40")]
			internal bool KKMPEPHNBJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x22AF640", Offset = "0x22AE640", VA = "0x1822AF640")]
			internal bool AJGJNMAIPNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x22B1580", Offset = "0x22B0580", VA = "0x1822B1580")]
			internal bool HBIJHAFADMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x22AFB70", Offset = "0x22AEB70", VA = "0x1822AFB70")]
			internal bool BKJKAGKLIHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x22B0E10", Offset = "0x22AFE10", VA = "0x1822B0E10")]
			internal bool FLBCCKLKKNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x22B0B70", Offset = "0x22AFB70", VA = "0x1822B0B70")]
			internal bool EJIDIPBMFLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x22B2D20", Offset = "0x22B1D20", VA = "0x1822B2D20")]
			internal bool LHNNDFGEGFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x22B06E0", Offset = "0x22AF6E0", VA = "0x1822B06E0")]
			internal void DFBNPLGEAOD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x22AF950", Offset = "0x22AE950", VA = "0x1822AF950")]
			internal bool BCLABHJFBHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x22B2E10", Offset = "0x22B1E10", VA = "0x1822B2E10")]
			internal bool LKAKJOAAFNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x22B1B10", Offset = "0x22B0B10", VA = "0x1822B1B10")]
			internal bool HOKOEANFNHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x22B3A10", Offset = "0x22B2A10", VA = "0x1822B3A10")]
			internal bool OEBEPBNLCJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x22B3B00", Offset = "0x22B2B00", VA = "0x1822B3B00")]
			internal bool OIDHJJCIKDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x22B9F50", Offset = "0x22B8F50", VA = "0x1822B9F50")]
			internal bool PKJINIADBLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x22AF810", Offset = "0x22AE810", VA = "0x1822AF810")]
			internal bool AOGNOIELMAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x22B1490", Offset = "0x22B0490", VA = "0x1822B1490")]
			internal bool GNGAHKMKEEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x22B1C40", Offset = "0x22B0C40", VA = "0x1822B1C40")]
			internal void HPNOKFCCPAG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x22B2CD0", Offset = "0x22B1CD0", VA = "0x1822B2CD0")]
			internal bool LFDOKIIKFAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x22B0D60", Offset = "0x22AFD60", VA = "0x1822B0D60")]
			internal bool FFLAGBPMGHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x22B0100", Offset = "0x22AF100", VA = "0x1822B0100")]
			internal void DABJNCPKIEN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x22B28B0", Offset = "0x22B18B0", VA = "0x1822B28B0")]
			internal bool KDDPECFDDOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x22B01B0", Offset = "0x22AF1B0", VA = "0x1822B01B0")]
			internal bool DCJPMGAJMNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x22B0740", Offset = "0x22AF740", VA = "0x1822B0740")]
			internal void DGFGKBOBBHA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x22B3E00", Offset = "0x22B2E00", VA = "0x1822B3E00")]
			internal List<BJNHBEDOFDB> PEGGCMLIOCH(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x22AF6E0", Offset = "0x22AE6E0", VA = "0x1822AF6E0")]
			internal bool AKFPFHCGDDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x22B07A0", Offset = "0x22AF7A0", VA = "0x1822B07A0")]
			internal int DGPKJLCIGCN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x22AFA00", Offset = "0x22AEA00", VA = "0x1822AFA00")]
			internal void BHACAHDAMGA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22B2290", Offset = "0x22B1290", VA = "0x1822B2290")]
			internal bool IMOBJNIPMOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x22B17D0", Offset = "0x22B07D0", VA = "0x1822B17D0")]
			internal bool HGHHLNKDNJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x22B2180", Offset = "0x22B1180", VA = "0x1822B2180")]
			internal bool IINIIOIEEAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x22B1730", Offset = "0x22B0730", VA = "0x1822B1730")]
			internal int HFMPPPLAABD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x22B3BA0", Offset = "0x22B2BA0", VA = "0x1822B3BA0")]
			internal void OLENHBJENED(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x22B1CF0", Offset = "0x22B0CF0", VA = "0x1822B1CF0")]
			internal bool IBGPHJOBADC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x22B0BC0", Offset = "0x22AFBC0", VA = "0x1822B0BC0")]
			internal bool ELBMNIFNAFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x22AFD60", Offset = "0x22AED60", VA = "0x1822AFD60")]
			internal bool CEGLJPAFIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x22B2330", Offset = "0x22B1330", VA = "0x1822B2330")]
			internal bool JCKGKCMHCAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x22B3550", Offset = "0x22B2550", VA = "0x1822B3550")]
			internal bool NFDGJLFBHCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x22B0CC0", Offset = "0x22AFCC0", VA = "0x1822B0CC0")]
			internal bool FCFFICNANHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x22B9FF0", Offset = "0x22B8FF0", VA = "0x1822B9FF0")]
			internal string PNDBLLBAKIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x22B3610", Offset = "0x22B2610", VA = "0x1822B3610")]
			internal void NFLAEIKFMIA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x22B0FF0", Offset = "0x22AFFF0", VA = "0x1822B0FF0")]
			internal int GECMCADPMAP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x22B3820", Offset = "0x22B2820", VA = "0x1822B3820")]
			internal void NNJDCGDBBKP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x22B16E0", Offset = "0x22B06E0", VA = "0x1822B16E0")]
			internal bool HFGJHMKNCFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x22B3910", Offset = "0x22B2910", VA = "0x1822B3910")]
			internal bool NPHEIJGKCCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x22B2E60", Offset = "0x22B1E60", VA = "0x1822B2E60")]
			internal bool LKCGIOGICFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x22B0000", Offset = "0x22AF000", VA = "0x1822B0000")]
			internal float COJFNCFNFGM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x22AFF00", Offset = "0x22AEF00", VA = "0x1822AFF00")]
			internal void CJEALBPAEAA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x22B23E0", Offset = "0x22B13E0", VA = "0x1822B23E0")]
			internal bool JGGKPGEHLFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x22B0990", Offset = "0x22AF990", VA = "0x1822B0990")]
			internal bool EBAPNKOCEFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22B1D90", Offset = "0x22B0D90", VA = "0x1822B1D90")]
			internal bool IDEGMDALEEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22B2750", Offset = "0x22B1750", VA = "0x1822B2750")]
			internal bool JNAIJJKNCEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x22B2A90", Offset = "0x22B1A90", VA = "0x1822B2A90")]
			internal bool KMJMJCGAKNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x22B19D0", Offset = "0x22B09D0", VA = "0x1822B19D0")]
			internal bool HNDIFNMAOHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x22B0200", Offset = "0x22AF200", VA = "0x1822B0200")]
			internal void DDGNLBOAEMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x22AF550", Offset = "0x22AE550", VA = "0x1822AF550")]
			internal string AGHLIHNFBHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x22AF7A0", Offset = "0x22AE7A0", VA = "0x1822AF7A0")]
			internal void ALCAHNOBPND(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x22B1440", Offset = "0x22B0440", VA = "0x1822B1440")]
			internal bool GNCAPCOHMCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x22B08A0", Offset = "0x22AF8A0", VA = "0x1822B08A0")]
			internal bool DMDGHKBNAEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x22B2860", Offset = "0x22B1860", VA = "0x1822B2860")]
			internal bool KANPKGFLADN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x22B1090", Offset = "0x22B0090", VA = "0x1822B1090")]
			internal void GKKOFKEELFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x22B32E0", Offset = "0x22B22E0", VA = "0x1822B32E0")]
			internal bool MMFHJLNOKCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x22B1F90", Offset = "0x22B0F90", VA = "0x1822B1F90")]
			internal bool IGGICFLNDJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x22AFEB0", Offset = "0x22AEEB0", VA = "0x1822AFEB0")]
			internal bool CJALOHCEMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x22B29F0", Offset = "0x22B19F0", VA = "0x1822B29F0")]
			internal bool KJDFBDECPJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x22AFD00", Offset = "0x22AED00", VA = "0x1822AFD00")]
			internal void CAHOGNBEMBJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x22B29A0", Offset = "0x22B19A0", VA = "0x1822B29A0")]
			internal bool KHLJIPGDMME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x22B39C0", Offset = "0x22B29C0", VA = "0x1822B39C0")]
			internal bool OCJMINEBAOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x22B2FF0", Offset = "0x22B1FF0", VA = "0x1822B2FF0")]
			internal bool MAFIENCOOFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x22AF500", Offset = "0x22AE500", VA = "0x1822AF500")]
			internal bool AEKDPGKBJHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x22B3190", Offset = "0x22B2190", VA = "0x1822B3190")]
			internal void MDACFCAFIGI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x22B0F50", Offset = "0x22AFF50", VA = "0x1822B0F50")]
			internal bool GCOKJFKOJEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x22AFBC0", Offset = "0x22AEBC0", VA = "0x1822AFBC0")]
			internal bool BKPFCJFEKBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x22B2D70", Offset = "0x22B1D70", VA = "0x1822B2D70")]
			internal bool LHPBNLGJDJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x22B2C80", Offset = "0x22B1C80", VA = "0x1822B2C80")]
			internal bool LFDMHGNKLPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x22AFB00", Offset = "0x22AEB00", VA = "0x1822AFB00")]
			internal object BJFOHCDDMCH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x22B3880", Offset = "0x22B2880", VA = "0x1822B3880")]
			internal void NOJPPBDHMAH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x22B30F0", Offset = "0x22B20F0", VA = "0x1822B30F0")]
			internal bool MCJPOIHLOIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x22B36E0", Offset = "0x22B26E0", VA = "0x1822B36E0")]
			internal bool NIBPKGMGNNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x22B3CF0", Offset = "0x22B2CF0", VA = "0x1822B3CF0")]
			internal int PAFKAAIDHBH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x22B00A0", Offset = "0x22AF0A0", VA = "0x1822B00A0")]
			internal void CPJLCJLGIHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x22B0940", Offset = "0x22AF940", VA = "0x1822B0940")]
			internal bool DNFLKLAFNPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x22B3DB0", Offset = "0x22B2DB0", VA = "0x1822B3DB0")]
			internal bool PDIJOLGOFDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x22B33F0", Offset = "0x22B23F0", VA = "0x1822B33F0")]
			internal int MPGPJJPDPBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22B3040", Offset = "0x22B2040", VA = "0x1822B3040")]
			internal void MAJJKMLKCEC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x22B18C0", Offset = "0x22B08C0", VA = "0x1822B18C0")]
			internal bool HMACDMCMNIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x22B2B90", Offset = "0x22B1B90", VA = "0x1822B2B90")]
			internal bool LCNKBEKEEKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x22B0B20", Offset = "0x22AFB20", VA = "0x1822B0B20")]
			internal bool EJIAGBIBHED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x22B0050", Offset = "0x22AF050", VA = "0x1822B0050")]
			internal int CPFIPMLNJDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x22B3960", Offset = "0x22B2960", VA = "0x1822B3960")]
			internal void NPKHKGHPDHH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x22B26A0", Offset = "0x22B16A0", VA = "0x1822B26A0")]
			internal bool JMKDCNLPOLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x22B0A80", Offset = "0x22AFA80", VA = "0x1822B0A80")]
			internal bool EHJCGHNGPDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x22B2650", Offset = "0x22B1650", VA = "0x1822B2650")]
			internal bool JMAFNACMPCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x22B2220", Offset = "0x22B1220", VA = "0x1822B2220")]
			internal object IKFOJGOAFPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x22B1BB0", Offset = "0x22B0BB0", VA = "0x1822B1BB0")]
			internal void HONOPGKKMOG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x22B14E0", Offset = "0x22B04E0", VA = "0x1822B14E0")]
			internal bool GOPIGDHMEFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x22B20E0", Offset = "0x22B10E0", VA = "0x1822B20E0")]
			internal bool IICDLIJODAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x22B1960", Offset = "0x22B0960", VA = "0x1822B1960")]
			internal object HMICOKCHALM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x22AF470", Offset = "0x22AE470", VA = "0x1822AF470")]
			internal void AAEKEHIKAOA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x22B1FE0", Offset = "0x22B0FE0", VA = "0x1822B1FE0")]
			internal bool IGLMEFMELKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x22AFC10", Offset = "0x22AEC10", VA = "0x1822AFC10")]
			internal int BNNGNIBEHLP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x22AF9A0", Offset = "0x22AE9A0", VA = "0x1822AF9A0")]
			internal void BFLPKOEDGEH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x22AF5F0", Offset = "0x22AE5F0", VA = "0x1822AF5F0")]
			internal bool AJBGIIEINMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x22B3330", Offset = "0x22B2330", VA = "0x1822B3330")]
			internal bool MOAPJPBLBLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x22B3A60", Offset = "0x22B2A60", VA = "0x1822B3A60")]
			internal bool OHHMJDOFFGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x22B2810", Offset = "0x22B1810", VA = "0x1822B2810")]
			internal int KADKHKPPAMH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x22B2AE0", Offset = "0x22B1AE0", VA = "0x1822B2AE0")]
			internal void LAIADJBPABP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x22B31F0", Offset = "0x22B21F0", VA = "0x1822B31F0")]
			internal bool MFBIFFELPHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x22B2130", Offset = "0x22B1130", VA = "0x1822B2130")]
			internal bool IICJHDLLNDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x22B0AD0", Offset = "0x22AFAD0", VA = "0x1822B0AD0")]
			internal bool EJFEMNKLJOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x22AFE60", Offset = "0x22AEE60", VA = "0x1822AFE60")]
			internal float CIKHKEAGBFF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x22B2380", Offset = "0x22B1380", VA = "0x1822B2380")]
			internal void JFGFMOIIFME(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x22AFDB0", Offset = "0x22AEDB0", VA = "0x1822AFDB0")]
			internal bool CEMKNFPDAEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x22B1690", Offset = "0x22B0690", VA = "0x1822B1690")]
			internal bool HFAFNPAGBPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x22B3C00", Offset = "0x22B2C00", VA = "0x1822B3C00")]
			internal bool OMGPGEGCIGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x22B0F00", Offset = "0x22AFF00", VA = "0x1822B0F00")]
			internal float GAFAAHOPAOE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x22B0840", Offset = "0x22AF840", VA = "0x1822B0840")]
			internal void DLJABPFANBK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x22BA090", Offset = "0x22B9090", VA = "0x1822BA090")]
			internal bool PNOEKNDJMEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x22B9FA0", Offset = "0x22B8FA0", VA = "0x1822B9FA0")]
			internal bool PLNEBIOFOFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x22B34B0", Offset = "0x22B24B0", VA = "0x1822B34B0")]
			internal string NADEFEPIGME()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x22B2540", Offset = "0x22B1540", VA = "0x1822B2540")]
			internal void JIPHFLGIEOL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x22B2F00", Offset = "0x22B1F00", VA = "0x1822B2F00")]
			internal bool LLKBBDDEAIE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x22B9F00", Offset = "0x22B8F00", VA = "0x1822B9F00")]
			internal bool PKBCFEBMLGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x22B22E0", Offset = "0x22B12E0", VA = "0x1822B22E0")]
			internal bool JBLAFCDAKDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B27D0", VA = "0x1822B37D0")]
			internal bool NKOBFJIHBDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x22B3C50", Offset = "0x22B2C50", VA = "0x1822B3C50")]
			internal string OMOKGNHBIJK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x22B3380", Offset = "0x22B2380", VA = "0x1822B3380")]
			internal void MOHIJFMFBBO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x22B1CA0", Offset = "0x22B0CA0", VA = "0x1822B1CA0")]
			internal bool IBBKNJFEIAL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x22AFF60", Offset = "0x22AEF60", VA = "0x1822AFF60")]
			internal bool CKALIBLPIKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x22AFA60", Offset = "0x22AEA60", VA = "0x1822AFA60")]
			internal bool BILMDLINFCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x22BA0E0", Offset = "0x22B90E0", VA = "0x1822BA0E0")]
			internal bool POMAODHNAPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x22B1D40", Offset = "0x22B0D40", VA = "0x1822B1D40")]
			internal string IBIHCAOCGGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x22BA130", Offset = "0x22B9130", VA = "0x1822BA130")]
			internal void PPMIPEPNALE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x22B09E0", Offset = "0x22AF9E0", VA = "0x1822B09E0")]
			internal bool EBIMMFFAPGD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x22AF690", Offset = "0x22AE690", VA = "0x1822AF690")]
			internal bool AKBLFICKKKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x22B2BE0", Offset = "0x22B1BE0", VA = "0x1822B2BE0")]
			internal bool LDCAHJIBDOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x22B1780", Offset = "0x22B0780", VA = "0x1822B1780")]
			internal bool HGDNGDDACGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x22AFFB0", Offset = "0x22AEFB0", VA = "0x1822AFFB0")]
			internal string CKLHFLIBABI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x22B1620", Offset = "0x22B0620", VA = "0x1822B1620")]
			internal void HCPAFPMDIKA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x22B2B40", Offset = "0x22B1B40", VA = "0x1822B2B40")]
			internal bool LCIHPCCBOOC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x22B1350", Offset = "0x22B0350", VA = "0x1822B1350")]
			internal bool GLGACJGKPIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x22B0690", Offset = "0x22AF690", VA = "0x1822B0690")]
			internal bool DEKMCCPJNAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x22B3240", Offset = "0x22B2240", VA = "0x1822B3240")]
			internal bool MIKHBNIKGKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x22B1530", Offset = "0x22B0530", VA = "0x1822B1530")]
			internal string HAAJIACJNBA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x22B27A0", Offset = "0x22B17A0", VA = "0x1822B27A0")]
			internal void JNLEPGCCGHM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x22B0E60", Offset = "0x22AFE60", VA = "0x1822B0E60")]
			internal bool FLFMMFOEEOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x22B2950", Offset = "0x22B1950", VA = "0x1822B2950")]
			internal bool KENDMLOCGFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x22B2030", Offset = "0x22B1030", VA = "0x1822B2030")]
			internal bool IGPAAEEPIBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x22B30A0", Offset = "0x22B20A0", VA = "0x1822B30A0")]
			internal bool MBOKLADDLHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x22B3B50", Offset = "0x22B2B50", VA = "0x1822B3B50")]
			internal string OIKIPMMMHKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x22B05B0", Offset = "0x22AF5B0", VA = "0x1822B05B0")]
			internal void DEIFNAJLGHB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x22B9EB0", Offset = "0x22B8EB0", VA = "0x1822B9EB0")]
			internal bool PGBKOOAHPED(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x22AFCB0", Offset = "0x22AECB0", VA = "0x1822AFCB0")]
			internal bool BPEHLIFIKJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x22AFAB0", Offset = "0x22AEAB0", VA = "0x1822AFAB0")]
			internal bool BJDEFPKEDIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x22B24A0", Offset = "0x22B14A0", VA = "0x1822B24A0")]
			internal bool JGMGKOMKAGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x22B1DE0", Offset = "0x22B0DE0", VA = "0x1822B1DE0")]
			internal string IDIIMNJKALM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22B3D40", Offset = "0x22B2D40", VA = "0x1822B3D40")]
			internal void PBECNCMPNGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x22B1040", Offset = "0x22B0040", VA = "0x1822B1040")]
			internal bool GIJGLFPFAHA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x22B1910", Offset = "0x22B0910", VA = "0x1822B1910")]
			internal bool HMDPBGLJEIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x22AFC60", Offset = "0x22AEC60", VA = "0x1822AFC60")]
			internal bool BOJGNAEDGIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x22B2C30", Offset = "0x22B1C30", VA = "0x1822B2C30")]
			internal bool LEMCLMFIFKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x22B3290", Offset = "0x22B2290", VA = "0x1822B3290")]
			internal string MLKGKINBHGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x22B3440", Offset = "0x22B2440", VA = "0x1822B3440")]
			internal void MPPONKJBLKK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x22AF5A0", Offset = "0x22AE5A0", VA = "0x1822AF5A0")]
			internal bool AIGAMAOMIBF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x22BA1A0", Offset = "0x22B91A0", VA = "0x1822BA1A0")]
			internal bool PPMMLDGJGPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x22B0D10", Offset = "0x22AFD10", VA = "0x1822B0D10")]
			internal bool FDILJDFHEOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x22B3CA0", Offset = "0x22B2CA0", VA = "0x1822B3CA0")]
			internal bool OPKAICFJCEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x22B13A0", Offset = "0x22B03A0", VA = "0x1822B13A0")]
			internal string GMIMBEAGEOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x22AF730", Offset = "0x22AE730", VA = "0x1822AF730")]
			internal void AKILCJCBJCB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x22B0A30", Offset = "0x22AFA30", VA = "0x1822B0A30")]
			internal bool EFMHPBIGPEF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x22B15D0", Offset = "0x22B05D0", VA = "0x1822B15D0")]
			internal bool HCIFFMMPEBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x22B2EB0", Offset = "0x22B1EB0", VA = "0x1822B2EB0")]
			internal bool LLIIBAOJFNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x22B1B60", Offset = "0x22B0B60", VA = "0x1822B1B60")]
			internal bool HOMIBHKFEPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x22B0EB0", Offset = "0x22AFEB0", VA = "0x1822B0EB0")]
			internal string FMPFFMLOMIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x22B0620", Offset = "0x22AF620", VA = "0x1822B0620")]
			internal void DEJIBIGJGFI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x22B0160", Offset = "0x22AF160", VA = "0x1822B0160")]
			internal bool DBNLOJHINOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x22B1F40", Offset = "0x22B0F40", VA = "0x1822B1F40")]
			internal bool IFLKFKMOJAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x22B2DC0", Offset = "0x22B1DC0", VA = "0x1822B2DC0")]
			internal bool LINAFBCKLFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x22AF860", Offset = "0x22AE860", VA = "0x1822AF860")]
			internal string AOJKAGGGCLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x22B35A0", Offset = "0x22B25A0", VA = "0x1822B35A0")]
			internal void NFDLKPMOAIJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x22B1870", Offset = "0x22B0870", VA = "0x1822B1870")]
			internal bool HKBAAMPFGDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x22B3140", Offset = "0x22B2140", VA = "0x1822B3140")]
			internal bool MCNFKKGLFPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x22B2600", Offset = "0x22B1600", VA = "0x1822B2600")]
			internal bool JJLLADHDGNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x22B13F0", Offset = "0x22B03F0", VA = "0x1822B13F0")]
			internal string GNBKKKJAPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x22B1E80", Offset = "0x22B0E80", VA = "0x1822B1E80")]
			internal void IELGNBCCGAP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x22B2F50", Offset = "0x22B1F50", VA = "0x1822B2F50")]
			internal bool LNBIAGJLMIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x22B2900", Offset = "0x22B1900", VA = "0x1822B2900")]
			internal bool KDIOCBPCMAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x22AF900", Offset = "0x22AE900", VA = "0x1822AF900")]
			internal bool BCFAMJDECBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x22B0C10", Offset = "0x22AFC10", VA = "0x1822B0C10")]
			internal string FAGNFCIDFEL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x22B2430", Offset = "0x22B1430", VA = "0x1822B2430")]
			internal void JGIPIAFCNHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x22B1AC0", Offset = "0x22B0AC0", VA = "0x1822B1AC0")]
			internal bool HNLKIHANEOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x22B08F0", Offset = "0x22AF8F0", VA = "0x1822B08F0")]
			internal bool DNBNEBONGKD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x22B1A70", Offset = "0x22B0A70", VA = "0x1822B1A70")]
			internal float HNKOOPNAMGL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x22B0DB0", Offset = "0x22AFDB0", VA = "0x1822B0DB0")]
			internal void FGPFDPGHAKD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x22B07F0", Offset = "0x22AF7F0", VA = "0x1822B07F0")]
			internal bool DHDGEGMOPIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x22B3500", Offset = "0x22B2500", VA = "0x1822B3500")]
			internal bool NDFOHGHKOJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x22B21D0", Offset = "0x22B11D0", VA = "0x1822B21D0")]
			internal bool IJFJDCGBPHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x22B3AB0", Offset = "0x22B2AB0", VA = "0x1822B3AB0")]
			internal int OHOGDDEGPLD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x22B26F0", Offset = "0x22B16F0", VA = "0x1822B26F0")]
			internal void JMPKEIJEAOD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x22B25B0", Offset = "0x22B15B0", VA = "0x1822B25B0")]
			internal bool JJGKADNIJEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x22B1E30", Offset = "0x22B0E30", VA = "0x1822B1E30")]
			internal bool IDJEKHHMJBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x22B0FA0", Offset = "0x22AFFA0", VA = "0x1822B0FA0")]
			internal bool GDNCGPAGPBJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class GBAKGAKLIGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public FELOBGKIDFO CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GBAKGAKLIGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x22BA760", Offset = "0x22B9760", VA = "0x1822BA760")]
			internal void KGFIJHBBGPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class BBBDFGDOCJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public BBBDFGDOCJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x22A9F60", Offset = "0x22A8F60", VA = "0x1822A9F60")]
			internal bool POCGPHKPJKF(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly IBINMGAJJHI OPDAOBJMJEP;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x22AD980", Offset = "0x22AC980", VA = "0x1822AD980")]
		public BNFFCKHJJLG(BBEDDGOLNGI BFIEGGNBNMB, MPCPOEGFDOH CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x22ABC50", Offset = "0x22AAC50", VA = "0x1822ABC50", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class AIPLMIMPFBA : NAEDGBHPGMP<MIJKBPNBLHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class JELDOPABDFF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public JELDOPABDFF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x22E26F0", Offset = "0x22E16F0", VA = "0x1822E26F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public AIPLMIMPFBA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public JELDOPABDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x22DC3F0", Offset = "0x22DB3F0", VA = "0x1822DC3F0")]
			internal string PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x22DC240", Offset = "0x22DB240", VA = "0x1822DC240")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FAMOKMKDKKI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x22DC310", Offset = "0x22DB310", VA = "0x1822DC310")]
			internal int FDMPEPACCLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x22DC360", Offset = "0x22DB360", VA = "0x1822DC360")]
			internal void KJNPAOHKELN(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x22C7B20", Offset = "0x22C6B20", VA = "0x1822C7B20")]
		public AIPLMIMPFBA(BBEDDGOLNGI BFIEGGNBNMB, MIJKBPNBLHJ PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x22C77D0", Offset = "0x22C67D0", VA = "0x1822C77D0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class EHEPDHFFBBF : NAEDGBHPGMP<JMLBBBFFJCF>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class NPLBBOODJML
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public NPLBBOODJML <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x22E23B0", Offset = "0x22E13B0", VA = "0x1822E23B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public NPLBBOODJML <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x22E2A00", Offset = "0x22E1A00", VA = "0x1822E2A00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public EHEPDHFFBBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public NPLBBOODJML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x22E09F0", Offset = "0x22DF9F0", VA = "0x1822E09F0")]
			internal string PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x22E04F0", Offset = "0x22DF4F0", VA = "0x1822E04F0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FAMOKMKDKKI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x22E05C0", Offset = "0x22DF5C0", VA = "0x1822E05C0")]
			internal int FDMPEPACCLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x22E07D0", Offset = "0x22DF7D0", VA = "0x1822E07D0")]
			internal void KJNPAOHKELN(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x22E08D0", Offset = "0x22DF8D0", VA = "0x1822E08D0")]
			internal string NJDCIIADDJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x22E0920", Offset = "0x22DF920", VA = "0x1822E0920")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void NKGNNNLAKJI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x22E03F0", Offset = "0x22DF3F0", VA = "0x1822E03F0")]
			internal bool CFMGDNFEKBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x22E0310", Offset = "0x22DF310", VA = "0x1822E0310")]
			internal void AGDNAAGEMMJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x22E04A0", Offset = "0x22DF4A0", VA = "0x1822E04A0")]
			internal bool EJMILACBDDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x22E0610", Offset = "0x22DF610", VA = "0x1822E0610")]
			internal void HIFHHPEDFEH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x22E03A0", Offset = "0x22DF3A0", VA = "0x1822E03A0")]
			internal float BANNBNBGMIF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x22E06A0", Offset = "0x22DF6A0", VA = "0x1822E06A0")]
			internal void IHBAFKCIMMH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x22E0440", Offset = "0x22DF440", VA = "0x1822E0440")]
			internal int DEAAIMNLLKC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x22E0730", Offset = "0x22DF730", VA = "0x1822E0730")]
			internal void JHHKJBEICBL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x22E0860", Offset = "0x22DF860", VA = "0x1822E0860")]
			internal bool LOHMGPBJPEJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x22CB470", Offset = "0x22CA470", VA = "0x1822CB470")]
		public EHEPDHFFBBF(BBEDDGOLNGI BFIEGGNBNMB, JMLBBBFFJCF CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x22CAA20", Offset = "0x22C9A20", VA = "0x1822CAA20", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class JDFOKDFEJFI : NAEDGBHPGMP<APNDBGNPNAP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class HGFCGHGAIOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public JDFOKDFEJFI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HGFCGHGAIOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x22D3700", Offset = "0x22D2700", VA = "0x1822D3700")]
			internal Dictionary<string, GBEIEIMAINC> PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x22D3510", Offset = "0x22D2510", VA = "0x1822D3510")]
			internal int FAMOKMKDKKI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x22D3560", Offset = "0x22D2560", VA = "0x1822D3560")]
			internal void FDMPEPACCLB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x22D3680", Offset = "0x22D2680", VA = "0x1822D3680")]
			internal bool KJNPAOHKELN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x22DC1D0", Offset = "0x22DB1D0", VA = "0x1822DC1D0")]
		public JDFOKDFEJFI(BBEDDGOLNGI BFIEGGNBNMB, APNDBGNPNAP PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x22DBF00", Offset = "0x22DAF00", VA = "0x1822DBF00", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class JOPLHFGBHPK : NAEDGBHPGMP<CBJFDACMHNG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class HGOPGPCICBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public JOPLHFGBHPK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HGOPGPCICBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x22D37A0", Offset = "0x22D27A0", VA = "0x1822D37A0")]
			internal void PNGABOJOMPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x22DD2E0", Offset = "0x22DC2E0", VA = "0x1822DD2E0")]
		public JOPLHFGBHPK(BBEDDGOLNGI BFIEGGNBNMB, CBJFDACMHNG PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x22DD160", Offset = "0x22DC160", VA = "0x1822DD160", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class OFINJONDANP : KCCPCGCGMLE<BMAIPNEDEHE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DLMPNLFPPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool LFFOPIOOGFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x22E0AA0", Offset = "0x22DFAA0", VA = "0x1822E0AA0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9DA700", Offset = "0x9D9700", VA = "0x1809DA700", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x22E0A40", Offset = "0x22DFA40", VA = "0x1822E0A40")]
		public OFINJONDANP(BBEDDGOLNGI BFIEGGNBNMB, BMAIPNEDEHE CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class HADGDOIKKFI : NAEDGBHPGMP<OHMANEOMCON>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC53750", Offset = "0xC52750", VA = "0x180C53750", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x22D32C0", Offset = "0x22D22C0", VA = "0x1822D32C0")]
		public HADGDOIKKFI(BBEDDGOLNGI BFIEGGNBNMB, OHMANEOMCON CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class MEGANBMNDOM : NAEDGBHPGMP<AKILLHOEBFG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x937EA0", Offset = "0x936EA0", VA = "0x180937EA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x22DF690", Offset = "0x22DE690", VA = "0x1822DF690")]
		public MEGANBMNDOM(BBEDDGOLNGI BFIEGGNBNMB, AKILLHOEBFG CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "112")]
		protected override bool NDJPBEKFIPI(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class HHPNENPEPIC : NAEDGBHPGMP<CCMJIILDDHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x935310", Offset = "0x934310", VA = "0x180935310", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool OPIOEOHLDKM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x22D39D0", Offset = "0x22D29D0", VA = "0x1822D39D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool FIHLNKJIKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x22D3960", Offset = "0x22D2960", VA = "0x1822D3960")]
		public HHPNENPEPIC(BBEDDGOLNGI BFIEGGNBNMB, CCMJIILDDHJ CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class KJLFEMMIPPH : NAEDGBHPGMP<BDDGHCPBHCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x941F20", Offset = "0x940F20", VA = "0x180941F20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool OPIOEOHLDKM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x22DD3E0", Offset = "0x22DC3E0", VA = "0x1822DD3E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool FIHLNKJIKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x22DD370", Offset = "0x22DC370", VA = "0x1822DD370")]
		public KJLFEMMIPPH(BBEDDGOLNGI BFIEGGNBNMB, BDDGHCPBHCF CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class CDHNPHGKMEF : PHOOLPHLEBB<HOPIAJNJDEL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class EJEEDNIPJDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CDHNPHGKMEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public EJEEDNIPJDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x22CB4E0", Offset = "0x22CA4E0", VA = "0x1822CB4E0")]
			internal float BAPIHCNKLHD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x22CB560", Offset = "0x22CA560", VA = "0x1822CB560")]
			internal void PCDAMGLFIFK(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x22C8C30", Offset = "0x22C7C30", VA = "0x1822C8C30")]
		public CDHNPHGKMEF(BBEDDGOLNGI BFIEGGNBNMB, HOPIAJNJDEL PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x22C89B0", Offset = "0x22C79B0", VA = "0x1822C89B0", Slot = "126")]
		protected override void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class EMGCBMGIGJJ : NAEDGBHPGMP<HEPFMLCJENE>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class MEBGHLKLAIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public EMGCBMGIGJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public MEBGHLKLAIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x22DF640", Offset = "0x22DE640", VA = "0x1822DF640")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x22DF520", Offset = "0x22DE520", VA = "0x1822DF520")]
			internal void FAMOKMKDKKI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x22CC270", Offset = "0x22CB270", VA = "0x1822CC270")]
		public EMGCBMGIGJJ(BBEDDGOLNGI BFIEGGNBNMB, HEPFMLCJENE PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x22CBFC0", Offset = "0x22CAFC0", VA = "0x1822CBFC0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class EMNFDCOPCDI : NAEDGBHPGMP<BOGABPFCNPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class LOCNFAPLONA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public EMNFDCOPCDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public LOCNFAPLONA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x22DEF80", Offset = "0x22DDF80", VA = "0x1822DEF80")]
			internal object PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x22DE920", Offset = "0x22DD920", VA = "0x1822DE920")]
			internal bool AGDNAAGEMMJ(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x22DEAC0", Offset = "0x22DDAC0", VA = "0x1822DEAC0")]
			internal void FAMOKMKDKKI(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x22DED10", Offset = "0x22DDD10", VA = "0x1822DED10")]
			internal string FDMPEPACCLB(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x22DEE70", Offset = "0x22DDE70", VA = "0x1822DEE70")]
			internal IReadOnlyList<object> KJNPAOHKELN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x22DEEC0", Offset = "0x22DDEC0", VA = "0x1822DEEC0")]
			internal bool NJDCIIADDJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x22DEF30", Offset = "0x22DDF30", VA = "0x1822DEF30")]
			internal bool NKGNNNLAKJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x22DE9A0", Offset = "0x22DD9A0", VA = "0x1822DE9A0")]
			internal void CFMGDNFEKBF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x22CCAF0", Offset = "0x22CBAF0", VA = "0x1822CCAF0")]
		public EMNFDCOPCDI(BBEDDGOLNGI BFIEGGNBNMB, BOGABPFCNPJ PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x22CC2E0", Offset = "0x22CB2E0", VA = "0x1822CC2E0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class HAFLIEPEKJC : MCKHOKFHGHM<NFIGGGHKOBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9E8E80", Offset = "0x9E7E80", VA = "0x1809E8E80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x22D3330", Offset = "0x22D2330", VA = "0x1822D3330")]
		public HAFLIEPEKJC(BBEDDGOLNGI BFIEGGNBNMB, NFIGGGHKOBA CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class AEHMLKODNPC : PHOOLPHLEBB<OKHJKFCJILD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class PIOBKFMADMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AEHMLKODNPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public PIOBKFMADMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x22E1C30", Offset = "0x22E0C30", VA = "0x1822E1C30")]
			internal int BAPIHCNKLHD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x22E1CB0", Offset = "0x22E0CB0", VA = "0x1822E1CB0")]
			internal void PCDAMGLFIFK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x22C7770", Offset = "0x22C6770", VA = "0x1822C7770")]
		public AEHMLKODNPC(BBEDDGOLNGI BFIEGGNBNMB, OKHJKFCJILD PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x22C74E0", Offset = "0x22C64E0", VA = "0x1822C74E0", Slot = "126")]
		protected override void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class MBNLODBJPIP : NAEDGBHPGMP<GJBHLJGDIEI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class ONNLMPMLEJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public MBNLODBJPIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public ONNLMPMLEJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x22E1990", Offset = "0x22E0990", VA = "0x1822E1990")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x22E1900", Offset = "0x22E0900", VA = "0x1822E1900")]
			internal void FAMOKMKDKKI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x22DF290", Offset = "0x22DE290", VA = "0x1822DF290")]
		public MBNLODBJPIP(BBEDDGOLNGI BFIEGGNBNMB, GJBHLJGDIEI PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x22DF0B0", Offset = "0x22DE0B0", VA = "0x1822DF0B0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class PCBLCIFENDP : NAEDGBHPGMP<PNHHNIAEAMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class AEFLCGOBJJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public PCBLCIFENDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public AEFLCGOBJJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x22C7490", Offset = "0x22C6490", VA = "0x1822C7490")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x22C7400", Offset = "0x22C6400", VA = "0x1822C7400")]
			internal void FAMOKMKDKKI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x22E1BC0", Offset = "0x22E0BC0", VA = "0x1822E1BC0")]
		public PCBLCIFENDP(BBEDDGOLNGI BFIEGGNBNMB, PNHHNIAEAMJ PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x22E19E0", Offset = "0x22E09E0", VA = "0x1822E19E0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class POCKNJHJIJH : NAEDGBHPGMP<HIACIDDHNPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class IOJJCELNKJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public POCKNJHJIJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public IOJJCELNKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x22DBEB0", Offset = "0x22DAEB0", VA = "0x1822DBEB0")]
			internal int PNGABOJOMPN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x22DBE20", Offset = "0x22DAE20", VA = "0x1822DBE20")]
			internal void FAMOKMKDKKI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x22E2030", Offset = "0x22E1030", VA = "0x1822E2030")]
		public POCKNJHJIJH(BBEDDGOLNGI BFIEGGNBNMB, HIACIDDHNPO PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x22E1DC0", Offset = "0x22E0DC0", VA = "0x1822E1DC0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class IFILFHIIGJN : BEKOHDADJKB<IPABAFNFKIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override LJPAABOJMBN DEDLBHOBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "126")]
			get
			{
				return default(LJPAABOJMBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x22DBDC0", Offset = "0x22DADC0", VA = "0x1822DBDC0")]
		public IFILFHIIGJN(BBEDDGOLNGI BFIEGGNBNMB, IPABAFNFKIJ PHOINLFJEFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class LLAFONGNOIJ : NAEDGBHPGMP<JENJIJHPILB>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x22D3160", Offset = "0x22D2160", VA = "0x1822D3160")]
		public LLAFONGNOIJ(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class NAEDGBHPGMP<TNode> : NAOHBAGGJLN, IDisposable where TNode : notnull, JENJIJHPILB
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class CNEHPJHAIOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public NAEDGBHPGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public BBEDDGOLNGI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public CNEHPJHAIOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x5905E60", Offset = "0x5904E60", VA = "0x185905E60")]
			internal IAALGNLDOBC OICGIKAIEHH(NDDGPDFANNN portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct GFIDAHDLKLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public NAEDGBHPGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4161870", Offset = "0x4160870", VA = "0x184161870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct CMOECDNLGPG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public NAEDGBHPGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public HOOPJPCIOLN? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public FLAJGLHFMML? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x5900ED0", Offset = "0x58FFED0", VA = "0x185900ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x5901180", Offset = "0x5900180", VA = "0x185901180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class DEFNKOOFOGM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public DEFNKOOFOGM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x393EAF0", Offset = "0x393DAF0", VA = "0x18393EAF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public NAEDGBHPGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public IHMICECIEIN configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public DEFNKOOFOGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			internal string DPJAMIHLALP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			internal void BHFFHMHIKEB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x5D74B00", Offset = "0x5D73B00", VA = "0x185D74B00")]
			[AsyncStateMachine(typeof(NAEDGBHPGMP<>.DEFNKOOFOGM.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void JENKABKOOOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class MOANNBCCPCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public MOANNBCCPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x496EC60", Offset = "0x496DC60", VA = "0x18496EC60")]
			internal bool AFJHJEIPMOH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x496ED40", Offset = "0x496DD40", VA = "0x18496ED40")]
			internal bool LDMHFIPHFIN(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct HEJJCMMLLDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public NAEDGBHPGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x41E8400", Offset = "0x41E7400", VA = "0x1841E8400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x41E8790", Offset = "0x41E7790", VA = "0x1841E8790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly BBEDDGOLNGI HCJOFDDNBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool PNAPHCEEEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private KNBBEPKOHCG<OAOFJLCKBCA, IAALGNLDOBC> LAOPHILFMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private KNBBEPKOHCG<OAOFJLCKBCA, MJCJHKBHLNK> AIIGFJPHIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> JGFANEDHECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<FCEODKAEDJI<OAOFJLCKBCA>>? BJKEMHHFDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK>? DNOEIBBCCCF;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected GMNAMPPAFMB BEFOMFPKECK
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x49B7580", Offset = "0x49B6580", VA = "0x1849B7580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected ADPHOMBBGPJ GIEDCBAEBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x49B9D00", Offset = "0x49B8D00", VA = "0x1849B9D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode OKJCJFPNKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public GGKCCFNJFJC<EHIJNIOBBMM> KMOOKAOLLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xF0D3E0", Offset = "0xF0C3E0", VA = "0x180F0D3E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GGKCCFNJFJC<EHIJNIOBBMM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public FCEODKAEDJI<BHBNFANLIBI> DHKPHFJDPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x49BC670", Offset = "0x49BB670", VA = "0x1849BC670", Slot = "6")]
			get
			{
				return default(FCEODKAEDJI<BHBNFANLIBI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object FHMIHKKAAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3CC0220", Offset = "0x3CBF220", VA = "0x183CC0220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool LGHECJBOBDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int EBJKJODGGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x49BC2A0", Offset = "0x49BB2A0", VA = "0x1849BC2A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IGNHFMPOJGB FGIOLOPKIJD
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x49BC240", Offset = "0x49BB240", VA = "0x1849BC240", Slot = "10")]
			get
			{
				return default(IGNHFMPOJGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string FJBPEPCIMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x49BC830", Offset = "0x49BB830", VA = "0x1849BC830", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool FIHLNKJIKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public FCEODKAEDJI<EPMGPLBAOIN> MACIEJBGGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA984D0", Offset = "0xA974D0", VA = "0x180A984D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(FCEODKAEDJI<EPMGPLBAOIN>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA978D0", Offset = "0xA968D0", VA = "0x180A978D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool OPIOEOHLDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool DLMPNLFPPDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual DEMGCAGOAGF AGJKJLCFIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xB729D0", Offset = "0xB719D0", VA = "0x180B729D0", Slot = "94")]
			get
			{
				return default(DEMGCAGOAGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool FKHJAJMHGDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x49BBF50", Offset = "0x49BAF50", VA = "0x1849BBF50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool JDBKGGPMAIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x49BBFC0", Offset = "0x49BAFC0", VA = "0x1849BBFC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool BEFFDIOGKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x49BC030", Offset = "0x49BB030", VA = "0x1849BC030", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int CHPEILDNMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x49BC610", Offset = "0x49BB610", VA = "0x1849BC610", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool CILLDAIALPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x49BC430", Offset = "0x49BB430", VA = "0x1849BC430", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool CICLPJBEDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x49BC160", Offset = "0x49BB160", VA = "0x1849BC160", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool JOFPIDEPFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x49BC0F0", Offset = "0x49BB0F0", VA = "0x1849BC0F0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool JJIIJHIFGLB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB4A640", Offset = "0xB49640", VA = "0x180B4A640", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x1058410", Offset = "0x1057410", VA = "0x181058410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool FLBIEJJCHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool AFLNKMKBLBB
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x49BC0A0", Offset = "0x49BB0A0", VA = "0x1849BC0A0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool CEBOMMNFNDI
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x49BC360", Offset = "0x49BB360", VA = "0x1849BC360", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public HOOPJPCIOLN DIHMGFFLLEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x49BC550", Offset = "0x49BB550", VA = "0x1849BC550", Slot = "28")]
			get
			{
				return default(HOOPJPCIOLN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FLAJGLHFMML FMEMKMLEONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x49BC5B0", Offset = "0x49BB5B0", VA = "0x1849BC5B0", Slot = "30")]
			get
			{
				return default(FLAJGLHFMML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool EIHECDLPJLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual MGMBKPNKILE? KFHOBBAHADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual HBAHHGPDAGD? OMMAAICDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>>? DOPBIDNCKCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool AJHGOBCKIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x49BC1D0", Offset = "0x49BB1D0", VA = "0x1849BC1D0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x49BC490", Offset = "0x49BB490", VA = "0x1849BC490", Slot = "62")]
			get
			{
				return default(GGKCCFNJFJC<OMEMEDNNNNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x49BC300", Offset = "0x49BB300", VA = "0x1849BC300", Slot = "56")]
			get
			{
				return default(FCEODKAEDJI<OMEMEDNNNNN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool JKDNDADNJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual FCEODKAEDJI<OMEMEDNNNNN>? AIGABCLHHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool LFFOPIOOGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool EIBJJGGKHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x49BC3C0", Offset = "0x49BB3C0", VA = "0x1849BC3C0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B71A0", VA = "0x1808B81A0", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8B8320", Offset = "0x8B7320", VA = "0x1808B8320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string DKGEJEKCMMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8B8380", Offset = "0x8B7380", VA = "0x1808B8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x49BC4F0", Offset = "0x49BB4F0", VA = "0x1849BC4F0", Slot = "63")]
			get
			{
				return default(GGKCCFNJFJC<IMDHLBELCNK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public GGKCCFNJFJC<IMDHLBELCNK>? DPBJDPLJOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x49BC700", Offset = "0x49BB700", VA = "0x1849BC700", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public FPBBBHOCOJI<OAOFJLCKBCA, MJCJHKBHLNK> DMCECBBHENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x49BC7F0", Offset = "0x49BB7F0", VA = "0x1849BC7F0", Slot = "65")]
			get
			{
				return default(FPBBBHOCOJI<OAOFJLCKBCA, MJCJHKBHLNK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual FCEODKAEDJI<OAOFJLCKBCA>? GODHPJAPEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool JHINDFHMOFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool LHLPIOHOAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MEGPKLFHEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x49B7640", Offset = "0x49B6640", VA = "0x1849B7640", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x49BAEA0", Offset = "0x49B9EA0", VA = "0x1849BAEA0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OGMJEJNAJGE JJIIFNBOOFO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x49B9BA0", Offset = "0x49B8BA0", VA = "0x1849B9BA0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x49B9860", Offset = "0x49B8860", VA = "0x1849B9860", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MAOMNCENHIA LDCHNDBGCEK
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x49B76E0", Offset = "0x49B66E0", VA = "0x1849B76E0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x49B6E70", Offset = "0x49B5E70", VA = "0x1849B6E70", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action KHBAAHMNBJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x49B9DF0", Offset = "0x49B8DF0", VA = "0x1849B9DF0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x49B75E0", Offset = "0x49B65E0", VA = "0x1849B75E0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KLCEIFADLGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x49B97C0", Offset = "0x49B87C0", VA = "0x1849B97C0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x49B9720", Offset = "0x49B8720", VA = "0x1849B9720", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> LOCHINKILFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x49BA080", Offset = "0x49B9080", VA = "0x1849BA080", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x49B6DB0", Offset = "0x49B5DB0", VA = "0x1849B6DB0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> CINFKJHECFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x49BB0A0", Offset = "0x49BA0A0", VA = "0x1849BB0A0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x49B9AE0", Offset = "0x49B8AE0", VA = "0x1849B9AE0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>> OPKJCPGKEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x49BA340", Offset = "0x49B9340", VA = "0x1849BA340", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x49BAC10", Offset = "0x49B9C10", VA = "0x1849BAC10", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>, FCEODKAEDJI<OAOFJLCKBCA>> HNKJNPKOJBC
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x49B9C40", Offset = "0x49B8C40", VA = "0x1849B9C40", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x49B89A0", Offset = "0x49B79A0", VA = "0x1849B89A0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>, MJCJHKBHLNK> MLCLPNJCPDA
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x49BAD10", Offset = "0x49B9D10", VA = "0x1849BAD10", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x49B9FC0", Offset = "0x49B8FC0", VA = "0x1849B9FC0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<FCEODKAEDJI<OAOFJLCKBCA>, FCEODKAEDJI<OAOFJLCKBCA>> HCANKAEIMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x49BAAE0", Offset = "0x49B9AE0", VA = "0x1849BAAE0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x49B7060", Offset = "0x49B6060", VA = "0x1849B7060", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x49BB950", Offset = "0x49BA950", VA = "0x1849BB950")]
		[GKFAPCOLABH("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[GKFAPCOLABH("Need to handle `Name` better.")]
		protected NAEDGBHPGMP(BBEDDGOLNGI BFIEGGNBNMB, TNode CHMIAHGMJKI, bool MLBPDNMLOJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x49B77F0", Offset = "0x49B67F0", VA = "0x1849B77F0", Slot = "87")]
		protected virtual void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x49B80C0", Offset = "0x49B70C0", VA = "0x1849B80C0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x49BAFF0", Offset = "0x49B9FF0", VA = "0x1849BAFF0", Slot = "9")]
		[AsyncStateMachine(typeof(NAEDGBHPGMP<>.GFIDAHDLKLK))]
		public void NLJGDNHDBFD(int FOOJHNAHHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x49B7780", Offset = "0x49B6780", VA = "0x1849B7780")]
		public bool BOBNODJHLPJ([In] HOOPJPCIOLN BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x49B6D40", Offset = "0x49B5D40", VA = "0x1849B6D40")]
		public bool AGDLPCAEDBA([In] FLAJGLHFMML BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x49BB260", Offset = "0x49BA260", VA = "0x1849BB260", Slot = "32")]
		public void PBEKJIGPNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x49B9900", Offset = "0x49B8900", VA = "0x1849B9900", Slot = "33")]
		[AsyncStateMachine(typeof(NAEDGBHPGMP<>.CMOECDNLGPG))]
		public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> HGMDMCOHOIM(HOOPJPCIOLN? OFOBLJHNFGM, FLAJGLHFMML? FEOKMKIDJOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "97")]
		public virtual void BMEANIOOHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "98")]
		public virtual void AJGHKBGFMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "99")]
		public virtual void DBMBLHPFMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xB189D0", Offset = "0xB179D0", VA = "0x180B189D0")]
		protected void CLHGABFDGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2C480", VA = "0x180A2D480")]
		protected void FLFOIDNPCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x24D6040", Offset = "0x24D5040", VA = "0x1824D6040")]
		private void JDGHINAHJCC([In] FLAJGLHFMML JKJHCABJJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x49BADD0", Offset = "0x49B9DD0", VA = "0x1849BADD0", Slot = "100")]
		public virtual Task<OBFFLKDLIBJ<FCEODKAEDJI<OAOFJLCKBCA>, FGHJECBDJBN>> MMCLHLDGLNC(string DMCFPOLFNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x49BB470", Offset = "0x49BA470", VA = "0x1849BB470", Slot = "101")]
		public virtual Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> PCNOKLALDDA(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "102")]
		public virtual void EMLBINBMGHM(FCEODKAEDJI<OAOFJLCKBCA> IMCLMKPPOOI, FCEODKAEDJI<OAOFJLCKBCA> BBELNBCDMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x49B9A50", Offset = "0x49B8A50", VA = "0x1849B9A50", Slot = "103")]
		public virtual IEnumerable<CFJMCGPIICE> HKDILKNINAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x49B9690", Offset = "0x49B8690", VA = "0x1849B9690", Slot = "104")]
		public OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN> GEOPPCICKKD(string GNOEHPKGKMF)
		{
			return default(OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x49B6F10", Offset = "0x49B5F10", VA = "0x1849B6F10", Slot = "47")]
		public bool AJNPCHPCGDP([Out] Guid CDNKEEMBKMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x49BA820", Offset = "0x49B9820", VA = "0x1849BA820")]
		public bool JLDIKKAKODO([In] Guid EFMPIMPFJNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "105")]
		public virtual void CMJEOBEPHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "106")]
		public virtual void BMNKNFDCDOD(bool NADIHCKKKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "107")]
		public virtual PFDHHIHKKHP ALIPBMDKPHF([In] CPMDGFFHIND MMFNKEEMOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x49BA140", Offset = "0x49B9140", VA = "0x1849BA140")]
		protected void IJAGALAIPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x49BAF40", Offset = "0x49B9F40", VA = "0x1849BAF40", Slot = "112")]
		protected virtual bool NDJPBEKFIPI(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "113")]
		protected virtual bool MDDCOPMAMGB(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected virtual void NBGHNJPIFDH(IHMICECIEIN MKCGEPJDNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x49B8A60", Offset = "0x49B7A60", VA = "0x1849B8A60")]
		protected void ENGPEEFGNDE(IHMICECIEIN CEGALCHFBFE, Func<string> FKCCNFNOOFJ, Action<string> OLJFOABGOAP, string NNOOJKIHBIA, string EBLBAENNIAC, string BFNKKIHKACM, HBMLAOAKPPE JGMDJNCCPDP, DLEAPOLBNAL BPPODLEGJOK, Func<string, bool> OIFCGBMCOIO, string FFKOLMEFCGL, Func<string, bool> PANDHBGBHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x49B7190", Offset = "0x49B6190", VA = "0x1849B7190")]
		protected void APIBKPHGDKO(IHMICECIEIN CEGALCHFBFE, Func<string> FKCCNFNOOFJ, Action<string> OLJFOABGOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x49B94D0", Offset = "0x49B84D0", VA = "0x1849B94D0", Slot = "121")]
		protected virtual void FNACFCOFINI(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x49BA400", Offset = "0x49B9400", VA = "0x1849BA400", Slot = "80")]
		public void IKFIJFJAOJE(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x49BB160", Offset = "0x49BA160", VA = "0x1849BB160", Slot = "81")]
		public AMGGLIGKMHC NNBAJEDLLHN()
		{
			return default(AMGGLIGKMHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "124")]
		public virtual bool IKOKPOEJCJE(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x196A6D0", Offset = "0x19696D0", VA = "0x18196A6D0")]
		private void NDHMHIEKKEE([In] HOOPJPCIOLN PAMMLHPIJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x49B7F60", Offset = "0x49B6F60", VA = "0x1849B7F60")]
		private void DFFBNKFLDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x49B8E70", Offset = "0x49B7E70", VA = "0x1849B8E70")]
		private void ENNHFHOCNEP(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, NDDGPDFANNN NDGPKINOGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xC80150", Offset = "0xC7F150", VA = "0x180C80150")]
		private void HMDENPPPLII(FCEODKAEDJI<OAOFJLCKBCA> JHCIODFGPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x49B9E90", Offset = "0x49B8E90", VA = "0x1849B9E90")]
		private void IFHFGEHKHIH(FCEODKAEDJI<OAOFJLCKBCA> JHCIODFGPNM, NDDGPDFANNN BOCGCDCCDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x49BA450", Offset = "0x49B9450", VA = "0x1849BA450")]
		private void ILFLMDOLPDO(FCEODKAEDJI<OAOFJLCKBCA> IMCLMKPPOOI, FCEODKAEDJI<OAOFJLCKBCA> BBELNBCDMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xC80680", Offset = "0xC7F680", VA = "0x180C80680")]
		private void KIKBJNPHNJA(FCEODKAEDJI<OAOFJLCKBCA> IMCLMKPPOOI, FCEODKAEDJI<OAOFJLCKBCA> BBELNBCDMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x49BA800", Offset = "0x49B9800", VA = "0x1849BA800")]
		private void IMEHLMJFBAB(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x49BB540", Offset = "0x49BA540", VA = "0x1849BB540")]
		private void PHACDLLNJCH(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, NDDGPDFANNN NDGPKINOGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x49BAF80", Offset = "0x49B9F80", VA = "0x1849BAF80")]
		private void NIDKAHJMCPJ(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, NDDGPDFANNN BOCGCDCCDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x49B93B0", Offset = "0x49B83B0", VA = "0x1849B93B0", Slot = "125")]
		[AsyncStateMachine(typeof(NAEDGBHPGMP<>.HEJJCMMLLDK))]
		public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> FGJJFALPKNI(string GNOEHPKGKMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x49B7120", Offset = "0x49B6120", VA = "0x1849B7120", Slot = "54")]
		private void AOIJOMLAIOB(object JGDCPCEFPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x49BABA0", Offset = "0x49B9BA0", VA = "0x1849BABA0", Slot = "55")]
		private void KLNJOEDNAJO(object JGDCPCEFPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x49BACD0", Offset = "0x49B9CD0", VA = "0x1849BACD0", Slot = "29")]
		private bool MEKPAGEOHIP([In] HOOPJPCIOLN BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x49B6D00", Offset = "0x49B5D00", VA = "0x1849B6D00", Slot = "31")]
		private bool AFOICNIJHPP([In] FLAJGLHFMML BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x49B7490", Offset = "0x49B6490", VA = "0x1849B7490", Slot = "48")]
		private bool BAGOKDDHEJB([In] Guid EFMPIMPFJNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x49B9E50", Offset = "0x49B8E50", VA = "0x1849B9E50")]
		[CompilerGenerated]
		private string IFCNNFHAKHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x49B74D0", Offset = "0x49B64D0", VA = "0x1849B74D0")]
		[CompilerGenerated]
		private void BAOHGBEDNCA(string DMCFPOLFNCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class CPDDBBMPDLA : MCKHOKFHGHM<LGDMBBDFJJN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x9C9AC0", Offset = "0x9C8AC0", VA = "0x1809C9AC0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x22C8C90", Offset = "0x22C7C90", VA = "0x1822C8C90")]
		public CPDDBBMPDLA(BBEDDGOLNGI BFIEGGNBNMB, LGDMBBDFJJN CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class GIMBMNPHFBL : KCCPCGCGMLE<KIFALBGCNCA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x22CDB80", Offset = "0x22CCB80", VA = "0x1822CDB80")]
		public GIMBMNPHFBL(BBEDDGOLNGI BFIEGGNBNMB, KIFALBGCNCA CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class BEKOHDADJKB<T> : NAEDGBHPGMP<T> where T : notnull, JNBKCJBMDKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class NLDOHBCCLIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, GBEIEIMAINC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public BEKOHDADJKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public LJPAABOJMBN clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public NLDOHBCCLIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			internal IReadOnlyList<KeyValuePair<string, GBEIEIMAINC>> PNGABOJOMPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x49F41A0", Offset = "0x49F31A0", VA = "0x1849F41A0")]
			internal int FAMOKMKDKKI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x49F4300", Offset = "0x49F3300", VA = "0x1849F4300")]
			internal void FDMPEPACCLB(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x49F4760", Offset = "0x49F3760", VA = "0x1849F4760")]
			internal void KJNPAOHKELN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x49F47B0", Offset = "0x49F37B0", VA = "0x1849F47B0")]
			internal void NJDCIIADDJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x49F3FA0", Offset = "0x49F2FA0", VA = "0x1849F3FA0")]
			internal bool NKGNNNLAKJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x49F4090", Offset = "0x49F3090", VA = "0x1849F4090")]
			internal void CFMGDNFEKBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x49F3FA0", Offset = "0x49F2FA0", VA = "0x1849F3FA0")]
			internal bool AGDNAAGEMMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x49F4140", Offset = "0x49F3140", VA = "0x1849F4140")]
			internal float EJMILACBDDB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x49F4520", Offset = "0x49F3520", VA = "0x1849F4520")]
			internal void HIFHHPEDFEH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x49F4030", Offset = "0x49F3030", VA = "0x1849F4030")]
			internal float BANNBNBGMIF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x49F45E0", Offset = "0x49F35E0", VA = "0x1849F45E0")]
			internal void IHBAFKCIMMH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x49F40E0", Offset = "0x49F30E0", VA = "0x1849F40E0")]
			internal float DEAAIMNLLKC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x49F46A0", Offset = "0x49F36A0", VA = "0x1849F46A0")]
			internal void JHHKJBEICBL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xC945E0", Offset = "0xC935E0", VA = "0x180C945E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract LJPAABOJMBN DEDLBHOBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x45BE930", Offset = "0x45BD930", VA = "0x1845BE930")]
		public BEKOHDADJKB(BBEDDGOLNGI BFIEGGNBNMB, T CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x53345B0", Offset = "0x53335B0", VA = "0x1853345B0", Slot = "120")]
		protected sealed override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class DJLJANHPIKD : NAEDGBHPGMP<OPKKFPJHAOC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9D3170", Offset = "0x9D2170", VA = "0x1809D3170", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x22C9070", Offset = "0x22C8070", VA = "0x1822C9070")]
		public DJLJANHPIKD(BBEDDGOLNGI BFIEGGNBNMB, OPKKFPJHAOC CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class EFJNJLOIBJM : NAEDGBHPGMP<BHHNLHACJIB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class GKLEIEKCLNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public EFJNJLOIBJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GKLEIEKCLNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x22CDBE0", Offset = "0x22CCBE0", VA = "0x1822CDBE0")]
			internal int FAMOKMKDKKI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x22CDC30", Offset = "0x22CCC30", VA = "0x1822CDC30")]
			internal void FDMPEPACCLB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, GBEIEIMAINC>? BKDHDDFCCCJ;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x22CA9B0", Offset = "0x22C99B0", VA = "0x1822CA9B0")]
		public EFJNJLOIBJM(BBEDDGOLNGI BFIEGGNBNMB, BHHNLHACJIB CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x22CA640", Offset = "0x22C9640", VA = "0x1822CA640", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class KPOJEFLEGKL : BEKOHDADJKB<KCAIOJAIGHI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override LJPAABOJMBN DEDLBHOBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "126")]
			get
			{
				return default(LJPAABOJMBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x22DD940", Offset = "0x22DC940", VA = "0x1822DD940")]
		public KPOJEFLEGKL(BBEDDGOLNGI BFIEGGNBNMB, KCAIOJAIGHI PHOINLFJEFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class DONBCAAAOJC : KCCPCGCGMLE<AJIFFGNLHDL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x22C90E0", Offset = "0x22C80E0", VA = "0x1822C90E0")]
		public DONBCAAAOJC(BBEDDGOLNGI BFIEGGNBNMB, AJIFFGNLHDL CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class NAPAGBLKBGA : KCCPCGCGMLE<KDCNLCOEKAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x22DFDD0", Offset = "0x22DEDD0", VA = "0x1822DFDD0")]
		public NAPAGBLKBGA(BBEDDGOLNGI BFIEGGNBNMB, KDCNLCOEKAE CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class OILDGMKEDOG : PHOOLPHLEBB<IJDMNGIOHLO>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class NGNFJMCDDOM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public NGNFJMCDDOM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x22E20A0", Offset = "0x22E10A0", VA = "0x1822E20A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public OILDGMKEDOG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public NGNFJMCDDOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x22E01E0", Offset = "0x22DF1E0", VA = "0x1822E01E0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void BAPIHCNKLHD(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x22E11E0", Offset = "0x22E01E0", VA = "0x1822E11E0")]
		public OILDGMKEDOG(BBEDDGOLNGI BFIEGGNBNMB, IJDMNGIOHLO PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x22E0F00", Offset = "0x22DFF00", VA = "0x1822E0F00", Slot = "126")]
		protected override void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class KPKANNFBGPM : BEKOHDADJKB<NNEIOOJFPJN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override LJPAABOJMBN DEDLBHOBLBL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x935310", Offset = "0x934310", VA = "0x180935310", Slot = "126")]
			get
			{
				return default(LJPAABOJMBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x22DD8E0", Offset = "0x22DC8E0", VA = "0x1822DD8E0")]
		public KPKANNFBGPM(BBEDDGOLNGI BFIEGGNBNMB, NNEIOOJFPJN PHOINLFJEFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class PNJHLDNFBAD : NAEDGBHPGMP<FNOEHNDFNOC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xCED220", Offset = "0xCEC220", VA = "0x180CED220", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x22E1D50", Offset = "0x22E0D50", VA = "0x1822E1D50")]
		public PNJHLDNFBAD(BBEDDGOLNGI BFIEGGNBNMB, FNOEHNDFNOC CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class LICLHAKCCID : NAEDGBHPGMP<EJDLAGBCILM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool OPIOEOHLDKM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool FIHLNKJIKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x22DE4F0", Offset = "0x22DD4F0", VA = "0x1822DE4F0")]
		public LICLHAKCCID(BBEDDGOLNGI BFIEGGNBNMB, EJDLAGBCILM CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x22DE1C0", Offset = "0x22DD1C0", VA = "0x1822DE1C0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x22DE180", Offset = "0x22DD180", VA = "0x1822DE180")]
		private int LKEOOOOIFJO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x22DE120", Offset = "0x22DD120", VA = "0x1822DE120")]
		private void FDICPBJPDLH(int FIAIOBCELLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class GPPFNOCKMKL : LLAFONGNOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x22D3160", Offset = "0x22D2160", VA = "0x1822D3160")]
		public GPPFNOCKMKL(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class NOCLLJILHPL : PHOOLPHLEBB<KKCAEKNEHGH>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x22E02B0", Offset = "0x22DF2B0", VA = "0x1822E02B0")]
		public NOCLLJILHPL(BBEDDGOLNGI BFIEGGNBNMB, KKCAEKNEHGH CHMIAHGMJKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class PHOOLPHLEBB<TVariableNode> : NAEDGBHPGMP<TVariableNode> where TVariableNode : notnull, KKCAEKNEHGH
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class KHJPONCHKME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public PHOOLPHLEBB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public KHJPONCHKME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x467B5E0", Offset = "0x467A5E0", VA = "0x18467B5E0")]
			internal bool PNGABOJOMPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x467B350", Offset = "0x467A350", VA = "0x18467B350")]
			internal void FAMOKMKDKKI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x467B410", Offset = "0x467A410", VA = "0x18467B410")]
			internal bool FDMPEPACCLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x467B470", Offset = "0x467A470", VA = "0x18467B470")]
			internal void KJNPAOHKELN(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x467B530", Offset = "0x467A530", VA = "0x18467B530")]
			internal bool NJDCIIADDJC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class FPAIEKCINDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public ADPHOMBBGPJ nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public PHOOLPHLEBB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FPAIEKCINDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x401D8C0", Offset = "0x401C8C0", VA = "0x18401D8C0")]
			internal void BAPIHCNKLHD(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x93C870", Offset = "0x93B870", VA = "0x18093C870", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override DEMGCAGOAGF AGJKJLCFIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4BE3940", Offset = "0x4BE2940", VA = "0x184BE3940", Slot = "94")]
			get
			{
				return default(DEMGCAGOAGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3790", Offset = "0x4BE2790", VA = "0x184BE3790")]
		protected PHOOLPHLEBB(BBEDDGOLNGI BFIEGGNBNMB, TVariableNode CHMIAHGMJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4BE3140", Offset = "0x4BE2140", VA = "0x184BE3140", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4BE32E0", Offset = "0x4BE22E0", VA = "0x184BE32E0", Slot = "120")]
		protected override void NBGHNJPIFDH(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x4BE2DA0", Offset = "0x4BE1DA0", VA = "0x184BE2DA0", Slot = "126")]
		protected virtual void DODFNLPIAHC(IHMICECIEIN CEGALCHFBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x4BE2CA0", Offset = "0x4BE1CA0", VA = "0x184BE2CA0", Slot = "105")]
		public override void CMJEOBEPHJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x22C1A30", Offset = "0x22C0A30", VA = "0x1822C1A30")]
	public static NAOHBAGGJLN EJLELCHFLID(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class IEENJEPPADL : DPJHFMNLECA, BOAGOIHOCGF, ABNPAAPNOHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public FCEODKAEDJI<DJNGCDCAKKJ> ANINGDBGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6280", Offset = "0x9E5280", VA = "0x1809E6280", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FCEODKAEDJI<DJNGCDCAKKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FCEODKAEDJI<IAIFMMANJAN> FAIOIBKFEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xADB8E0", Offset = "0xADA8E0", VA = "0x180ADB8E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FCEODKAEDJI<IAIFMMANJAN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x22DB720", Offset = "0x22DA720", VA = "0x1822DB720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private FCEODKAEDJI<PLLHIIMKMMI> IINADMGCIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9D91E0", Offset = "0x9D81E0", VA = "0x1809D91E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override FCEODKAEDJI<ENCMEEMGAFC> NBHDOBAJEND
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x22DB730", Offset = "0x22DA730", VA = "0x1822DB730", Slot = "20")]
		get
		{
			return default(FCEODKAEDJI<ENCMEEMGAFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x22DBAD0", Offset = "0x22DAAD0", VA = "0x1822DBAD0")]
	private IEENJEPPADL(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI, FPJLHGJNPEI AIFKEMNGFHL, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<IAIFMMANJAN> LKEMMOGOMAB, FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, bool MGHDOJGGAPE, string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x22DB780", Offset = "0x22DA780", VA = "0x1822DB780")]
	public static IEENJEPPADL EJLELCHFLID(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI, FPJLHGJNPEI KLPHLLIDBFC, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, FCEODKAEDJI<IAIFMMANJAN> LKEMMOGOMAB, bool MGHDOJGGAPE, bool MLBPDNMLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x22DB720", Offset = "0x22DA720", VA = "0x1822DB720")]
	internal void MJDPKMGLKLD(FCEODKAEDJI<IAIFMMANJAN> BJDKOHEGDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class DPJHFMNLECA : ABNPAAPNOHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct HHOPJOBBFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private FJGIHOIADGN? CAEBCOGILDE;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x22D38B0", Offset = "0x22D28B0", VA = "0x1822D38B0")]
		public void EGPGCHCMHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x22D38C0", Offset = "0x22D28C0", VA = "0x1822D38C0")]
		public FJGIHOIADGN IDEIAGEKAAD(DPJHFMNLECA IGGLIMGEEIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly JENJIJHPILB NGAMAJBINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private HHOPJOBBFEI JNIAKHJIAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly AKCCNLLMBCN KAGDNCFOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<NFMHPDNEMLP> PEFJIDPLAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<EFEPAOJOINK> MCFOHDIEDCL;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[GKFAPCOLABH("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> HFAAKKNPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x22C9740", Offset = "0x22C8740", VA = "0x1822C9740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind PLLAHMHCLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C3EE0", VA = "0x1808C4EE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FCEODKAEDJI<OMEMEDNNNNN> PHLICIJICOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x22C9C20", Offset = "0x22C8C20", VA = "0x1822C9C20", Slot = "6")]
		get
		{
			return default(FCEODKAEDJI<OMEMEDNNNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x22C9670", Offset = "0x22C8670", VA = "0x1822C9670", Slot = "7")]
		get
		{
			return default(GGKCCFNJFJC<OMEMEDNNNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public LKBDFEKEMKA JPJACBKEPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF540", Offset = "0x9AE540", VA = "0x1809AF540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public KCFBAGCAKEO NNPGNDFBPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x22C96A0", Offset = "0x22C86A0", VA = "0x1822C96A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected FJGIHOIADGN OPDGMGAMKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x22C96A0", Offset = "0x22C86A0", VA = "0x1822C96A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage EEEJGHCFNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x22C9D10", Offset = "0x22C8D10", VA = "0x1822C9D10", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x22CA4C0", Offset = "0x22C94C0", VA = "0x1822CA4C0", Slot = "9")]
		get
		{
			return default(GGKCCFNJFJC<IMDHLBELCNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x98E5D0", Offset = "0x98D5D0", VA = "0x18098E5D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(FCEODKAEDJI<OAOFJLCKBCA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xABC630", Offset = "0xABB630", VA = "0x180ABC630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract FCEODKAEDJI<ENCMEEMGAFC> NBHDOBAJEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x22CA4E0", Offset = "0x22C94E0", VA = "0x1822CA4E0")]
	protected DPJHFMNLECA(BBEDDGOLNGI BFIEGGNBNMB, JENJIJHPILB CHMIAHGMJKI, AKCCNLLMBCN FBADOLDPNBJ, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, bool MGHDOJGGAPE, string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x22C93D0", Offset = "0x22C83D0", VA = "0x1822C93D0", Slot = "21")]
	protected virtual void CPDDJGLEDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x22C9520", Offset = "0x22C8520", VA = "0x1822C9520", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x22C9140", Offset = "0x22C8140", VA = "0x1822C9140", Slot = "14")]
	public void AAAIPLFJNBC(NFMHPDNEMLP EDPOEFODAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x22C9CB0", Offset = "0x22C8CB0", VA = "0x1822C9CB0", Slot = "15")]
	public void JIBNAOKGFPG(EFEPAOJOINK EDPOEFODAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x22C9E40", Offset = "0x22C8E40", VA = "0x1822C9E40", Slot = "16")]
	public void LMDODAEOFOF(PDPLHJCEOFC CCLHNNFMGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x22C9350", Offset = "0x22C8350", VA = "0x1822C9350", Slot = "23")]
	protected virtual void CACBIILDCFM(PDPLHJCEOFC CCLHNNFMGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x22C9A90", Offset = "0x22C8A90", VA = "0x1822C9A90")]
	private void ILGDGNHMCEL(bool BEELICCCBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x22C91A0", Offset = "0x22C81A0", VA = "0x1822C91A0")]
	private void APEFPEEBDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x22C98E0", Offset = "0x22C88E0", VA = "0x1822C98E0")]
	private void IBPCNBNOKIL([In] DDOPIFIDJPF FOKFEHDKCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x22C9C50", Offset = "0x22C8C50", VA = "0x1822C9C50", Slot = "17")]
	public void JFBKMJOGIKN(NFMHPDNEMLP EDPOEFODAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x22C9880", Offset = "0x22C8880", VA = "0x1822C9880", Slot = "18")]
	public void HNNPBEJKBEP(EFEPAOJOINK EDPOEFODAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	internal void JJKPKAJGAOK(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x22C93B0", Offset = "0x22C83B0", VA = "0x1822C93B0")]
	internal void CKJOAMHOFEO(FDFODKCMKED IKBDGBPPCAB, LKBDFEKEMKA PFCMGBLCCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xABC630", Offset = "0xABB630", VA = "0x180ABC630")]
	internal void NEBCBGCEIHF(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class IAALGNLDOBC : MJCJHKBHLNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class OGJBIOBJIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public BBEDDGOLNGI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JENJIJHPILB node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OGJBIOBJIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x22E0B70", Offset = "0x22DFB70", VA = "0x1822E0B70")]
		internal HJPBNIHKMEC HEHHFPJICHG((int PortDescIndex, int PortIndex, JLKPIKKEAEN InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x22E0AE0", Offset = "0x22DFAE0", VA = "0x1822E0AE0")]
		internal IEENJEPPADL AOAEBIJAPFN(FPJLHGJNPEI i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct BBAMJLFKACA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x22C84C0", Offset = "0x22C74C0", VA = "0x1822C84C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x22C8920", Offset = "0x22C7920", VA = "0x1822C8920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct LAMJEKLPFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public FCEODKAEDJI<KKOGEBIBMKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x22DD9A0", Offset = "0x22DC9A0", VA = "0x1822DD9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x22DDCF0", Offset = "0x22DCCF0", VA = "0x1822DDCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct LNENAFBEGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public FCEODKAEDJI<PLLHIIMKMMI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x22DE560", Offset = "0x22DD560", VA = "0x1822DE560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x22DE8B0", Offset = "0x22DD8B0", VA = "0x1822DE8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct FMOLFCKNCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public FCEODKAEDJI<KKOGEBIBMKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public FCEODKAEDJI<KKOGEBIBMKE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x22CD7C0", Offset = "0x22CC7C0", VA = "0x1822CD7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x22CDB10", Offset = "0x22CCB10", VA = "0x1822CDB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct FCJPINJEDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public FCEODKAEDJI<PLLHIIMKMMI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public FCEODKAEDJI<PLLHIIMKMMI> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x22CCB60", Offset = "0x22CBB60", VA = "0x1822CCB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x22CCEB0", Offset = "0x22CBEB0", VA = "0x1822CCEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct ANKBOGAAEPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x22C7B90", Offset = "0x22C6B90", VA = "0x1822C7B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x22C8000", Offset = "0x22C7000", VA = "0x1822C8000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct LBLHCEOPEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x22DDD60", Offset = "0x22DCD60", VA = "0x1822DDD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22DE0B0", Offset = "0x22DD0B0", VA = "0x1822DE0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct MNCPHOBOODO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public FCEODKAEDJI<KKOGEBIBMKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x22DFA10", Offset = "0x22DEA10", VA = "0x1822DFA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x22DFD60", Offset = "0x22DED60", VA = "0x1822DFD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct GNMIJLLJAJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public FCEODKAEDJI<PLLHIIMKMMI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x22D2DA0", Offset = "0x22D1DA0", VA = "0x1822D2DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x22D30F0", Offset = "0x22D20F0", VA = "0x1822D30F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct FLCBIOCLCLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public HFDGOBILPDJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FCEODKAEDJI<KKOGEBIBMKE> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x22CD3C0", Offset = "0x22CC3C0", VA = "0x1822CD3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x22CD750", Offset = "0x22CC750", VA = "0x1822CD750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FIECPOFFJMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public IAALGNLDOBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public HFDGOBILPDJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public FCEODKAEDJI<PLLHIIMKMMI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private MABFKOKBBPE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x22CCF20", Offset = "0x22CBF20", VA = "0x1822CCF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x22CD2B0", Offset = "0x22CC2B0", VA = "0x1822CD2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool COFKOACGAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool ANLJPHEFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private FPBBBHOCOJI<JIHNPCGMGAN, HJPBNIHKMEC> MBFCJLOCNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private FPBBBHOCOJI<JIHNPCGMGAN, MMIDPNEOGKG> KNNCGFOHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly JENJIJHPILB NGAMAJBINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private FPBBBHOCOJI<IAIFMMANJAN, IEENJEPPADL> GGAMGDKCIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private FPBBBHOCOJI<IAIFMMANJAN, BOAGOIHOCGF> HLHJMOEPCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? LGFGMGFPOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly NDDGPDFANNN KEPPMGNADJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FCEODKAEDJI<OAOFJLCKBCA> KEEJJPFNKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool PNAPHCEEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? DJGIMMFMJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? LJJHCBACGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<FCEODKAEDJI<JIHNPCGMGAN>>? NDHDEJFFLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<FCEODKAEDJI<IAIFMMANJAN>>? FENKEFBCLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private MJCJHKBHLNK.JLOBMFFFBED? DJFBDDJFANI;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OLDPCNECNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x22D8730", Offset = "0x22D7730", VA = "0x1822D8730", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LFNGCEBOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x22D5AC0", Offset = "0x22D4AC0", VA = "0x1822D5AC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool MBDACGJGJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x22D9280", Offset = "0x22D8280", VA = "0x1822D9280", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public GGKCCFNJFJC<OMEMEDNNNNN> FBEFCMGLKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x22D88A0", Offset = "0x22D78A0", VA = "0x1822D88A0", Slot = "7")]
		get
		{
			return default(GGKCCFNJFJC<OMEMEDNNNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool NKMFPHGNEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x22D9340", Offset = "0x22D8340", VA = "0x1822D9340", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public FPBBBHOCOJI<JIHNPCGMGAN, MMIDPNEOGKG> IJCKOKHAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "9")]
		get
		{
			return default(FPBBBHOCOJI<JIHNPCGMGAN, MMIDPNEOGKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x22DAFC0", Offset = "0x22D9FC0", VA = "0x1822DAFC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GGKCCFNJFJC<IMDHLBELCNK> ONNABPEGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x22DA9B0", Offset = "0x22D99B0", VA = "0x1822DA9B0", Slot = "11")]
		get
		{
			return default(GGKCCFNJFJC<IMDHLBELCNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FPBBBHOCOJI<IAIFMMANJAN, BOAGOIHOCGF> HBLJCINIKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "12")]
		get
		{
			return default(FPBBBHOCOJI<IAIFMMANJAN, BOAGOIHOCGF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FCEODKAEDJI<OAOFJLCKBCA> DOKOJPMHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9260", Offset = "0x9D8260", VA = "0x1809D9260", Slot = "13")]
		get
		{
			return default(FCEODKAEDJI<OAOFJLCKBCA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action NNKFNCDINBF
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x22D6510", Offset = "0x22D5510", VA = "0x1822D6510", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x22D5C80", Offset = "0x22D4C80", VA = "0x1822D5C80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action LKBOLGKCOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x22D7280", Offset = "0x22D6280", VA = "0x1822D7280", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x22D87F0", Offset = "0x22D77F0", VA = "0x1822D87F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<FCEODKAEDJI<JIHNPCGMGAN>, FCEODKAEDJI<JIHNPCGMGAN>> MEDNFFKDEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x22D5750", Offset = "0x22D4750", VA = "0x1822D5750", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x22D7E30", Offset = "0x22D6E30", VA = "0x1822D7E30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<FCEODKAEDJI<JIHNPCGMGAN>, FCEODKAEDJI<JIHNPCGMGAN>> PHCNHCLIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x22D5830", Offset = "0x22D4830", VA = "0x1822D5830", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x22D5B00", Offset = "0x22D4B00", VA = "0x1822D5B00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<FCEODKAEDJI<IAIFMMANJAN>, FCEODKAEDJI<IAIFMMANJAN>> ECJHPDCCIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x22D5DE0", Offset = "0x22D4DE0", VA = "0x1822D5DE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22DB4A0", Offset = "0x22DA4A0", VA = "0x1822DB4A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FCEODKAEDJI<IAIFMMANJAN>, FCEODKAEDJI<IAIFMMANJAN>> MAOEKFDECHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22D5D20", Offset = "0x22D4D20", VA = "0x1822D5D20", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x22DB560", Offset = "0x22DA560", VA = "0x1822DB560", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FCEODKAEDJI<JIHNPCGMGAN>, MMIDPNEOGKG> NFIDKNLNBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x22DA9D0", Offset = "0x22D99D0", VA = "0x1822DA9D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x22DA800", Offset = "0x22D9800", VA = "0x1822DA800", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FCEODKAEDJI<JIHNPCGMGAN>> NGKHGCBMJND
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F70", Offset = "0x22D8F70", VA = "0x1822D9F70", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x22D88D0", Offset = "0x22D78D0", VA = "0x1822D88D0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FCEODKAEDJI<JIHNPCGMGAN>, MMIDPNEOGKG> HCPKNFNDCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x22D9DF0", Offset = "0x22D8DF0", VA = "0x1822D9DF0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x22DAA90", Offset = "0x22D9A90", VA = "0x1822DAA90", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FCEODKAEDJI<IAIFMMANJAN>, BOAGOIHOCGF> OHKFIIJLJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x22D9EB0", Offset = "0x22D8EB0", VA = "0x1822D9EB0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x22D93C0", Offset = "0x22D83C0", VA = "0x1822D93C0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FCEODKAEDJI<IAIFMMANJAN>> HDBFCDDNDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x22D8AC0", Offset = "0x22D7AC0", VA = "0x1822D8AC0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x22D96C0", Offset = "0x22D86C0", VA = "0x1822D96C0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FCEODKAEDJI<IAIFMMANJAN>, BOAGOIHOCGF> JHCFIKKMMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x22D5BC0", Offset = "0x22D4BC0", VA = "0x1822D5BC0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x22D5A00", Offset = "0x22D4A00", VA = "0x1822D5A00", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x22DB620", Offset = "0x22DA620", VA = "0x1822DB620")]
	private IAALGNLDOBC(bool MGHDOJGGAPE, BBEDDGOLNGI BFIEGGNBNMB, bool HHDCKDJMLDF, FPBBBHOCOJI<JIHNPCGMGAN, HJPBNIHKMEC> GHPOJDLNEJJ, FPBBBHOCOJI<JIHNPCGMGAN, MMIDPNEOGKG> GLBNAGGAIJI, JENJIJHPILB CHMIAHGMJKI, FPBBBHOCOJI<IAIFMMANJAN, IEENJEPPADL> OEOCEOHLKPP, FPBBBHOCOJI<IAIFMMANJAN, BOAGOIHOCGF> PNCNJKCLNGK, string? IJLMCCHNAGA, NDDGPDFANNN NDGPKINOGNA, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, bool MLBPDNMLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x22D8160", Offset = "0x22D7160", VA = "0x1822D8160")]
	public static IAALGNLDOBC EJLELCHFLID(bool MGHDOJGGAPE, BBEDDGOLNGI BFIEGGNBNMB, bool HHDCKDJMLDF, JENJIJHPILB CHMIAHGMJKI, NDDGPDFANNN NDGPKINOGNA, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, bool MLBPDNMLOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x22D69B0", Offset = "0x22D59B0", VA = "0x1822D69B0")]
	private void CPDDJGLEDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x22D7330", Offset = "0x22D6330", VA = "0x1822D7330", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22DA8C0", Offset = "0x22D98C0", VA = "0x1822DA8C0", Slot = "38")]
	[AsyncStateMachine(typeof(BBAMJLFKACA))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> MEGOOCEJHLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x22D8B80", Offset = "0x22D7B80", VA = "0x1822D8B80")]
	private (FNBLGPDPKEB, int)? GAFFGONLMDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x22D95D0", Offset = "0x22D85D0", VA = "0x1822D95D0")]
	private void HBNOBKFFEAM(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x19E7CD0", Offset = "0x19E6CD0", VA = "0x1819E7CD0")]
	private void DJKCCHJHABE(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x22D8DB0", Offset = "0x22D7DB0", VA = "0x1822D8DB0")]
	private void GCGGFAFDHIK(int FMKCOBCDONB, int CBKJBIFFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x22D6950", Offset = "0x22D5950", VA = "0x1822D6950")]
	private void CNIJDKGOEHE(int FMKCOBCDONB, int CBKJBIFFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x22D9780", Offset = "0x22D8780", VA = "0x1822D9780")]
	private void HNFDJLNEPFF(int NHOIJPPALDN, FCEODKAEDJI<JIHNPCGMGAN> GJHAIMMBNGC, JLKPIKKEAEN NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x22D5810", Offset = "0x22D4810", VA = "0x1822D5810")]
	private void AIPOCGKFIOC(int BEELICCCBAC, FCEODKAEDJI<JIHNPCGMGAN> GJHAIMMBNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x22DA6D0", Offset = "0x22D96D0", VA = "0x1822DA6D0")]
	private void LNKFIAINMBC(int BEELICCCBAC, FCEODKAEDJI<JIHNPCGMGAN> GJHAIMMBNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x22DA170", Offset = "0x22D9170", VA = "0x1822DA170")]
	private void KBDIMNLIOCJ(int NHOIJPPALDN, FCEODKAEDJI<JIHNPCGMGAN> GJHAIMMBNGC, JLKPIKKEAEN NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x22D9480", Offset = "0x22D8480", VA = "0x1822D9480")]
	private void GMPGFLNFMDO(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xEA5CD0", Offset = "0xEA4CD0", VA = "0x180EA5CD0")]
	private void ECCOGKAEPCN(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x22DB3B0", Offset = "0x22DA3B0", VA = "0x1822DB3B0")]
	private void NKONOKCONIJ(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x19E7CD0", Offset = "0x19E6CD0", VA = "0x1819E7CD0")]
	private void BIMDABGMECN(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x22D65B0", Offset = "0x22D55B0", VA = "0x1822D65B0")]
	private void CLILMHMPPDD(int FMKCOBCDONB, int CBKJBIFFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x22D86D0", Offset = "0x22D76D0", VA = "0x1822D86D0")]
	private void FBCPJNMFHKJ(int FMKCOBCDONB, int CBKJBIFFOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x22D5EA0", Offset = "0x22D4EA0", VA = "0x1822D5EA0")]
	private void CDJCFOFMBDO(int NHOIJPPALDN, FCEODKAEDJI<IAIFMMANJAN> GJHAIMMBNGC, FPJLHGJNPEI NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x22DA150", Offset = "0x22D9150", VA = "0x1822DA150")]
	private void JMAELLJGCJH(int BEELICCCBAC, FCEODKAEDJI<IAIFMMANJAN> GJHAIMMBNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x22DA5C0", Offset = "0x22D95C0", VA = "0x1822DA5C0")]
	private void KICMBPODEHI(int BEELICCCBAC, FCEODKAEDJI<IAIFMMANJAN> GJHAIMMBNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x22DAB50", Offset = "0x22D9B50", VA = "0x1822DAB50")]
	private void MKMEHLEPKPG(int NHOIJPPALDN, FCEODKAEDJI<IAIFMMANJAN> GJHAIMMBNGC, FPJLHGJNPEI NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x22D8010", Offset = "0x22D7010", VA = "0x1822D8010")]
	private void EIJPPGHAOED(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xEA5CD0", Offset = "0xEA4CD0", VA = "0x180EA5CD0")]
	private void IHDMOMMDKLH(int NHOIJPPALDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x22DA6F0", Offset = "0x22D96F0", VA = "0x1822DA6F0", Slot = "39")]
	[AsyncStateMachine(typeof(LAMJEKLPFEN))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> LOALKMMMNFG(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x22D58F0", Offset = "0x22D48F0", VA = "0x1822D58F0", Slot = "40")]
	[AsyncStateMachine(typeof(LNENAFBEGMM))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> AKOFIGIIAAB(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x22DA030", Offset = "0x22D9030", VA = "0x1822DA030", Slot = "41")]
	[AsyncStateMachine(typeof(FMOLFCKNCKF))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> JBBNHMDGLAI(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, FCEODKAEDJI<KKOGEBIBMKE> LKANECPEFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x22D7EF0", Offset = "0x22D6EF0", VA = "0x1822D7EF0", Slot = "42")]
	[AsyncStateMachine(typeof(FCJPINJEDAO))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> ECKDPHEOBFL(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, FCEODKAEDJI<PLLHIIMKMMI> LKANECPEFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x22DA5E0", Offset = "0x22D95E0", VA = "0x1822DA5E0", Slot = "43")]
	[AsyncStateMachine(typeof(ANKBOGAAEPF))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> KMKKBHNIHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x22D7160", Offset = "0x22D6160", VA = "0x1822D7160", Slot = "44")]
	[AsyncStateMachine(typeof(LBLHCEOPEFO))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> DAJLAJJCFGG(string GNOEHPKGKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x22D63E0", Offset = "0x22D53E0", VA = "0x1822D63E0", Slot = "45")]
	[AsyncStateMachine(typeof(MNCPHOBOODO))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> CEKHGIOHDDA(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, string DMCFPOLFNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x22D8990", Offset = "0x22D7990", VA = "0x1822D8990", Slot = "46")]
	[AsyncStateMachine(typeof(GNMIJLLJAJH))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> FMFBOOEKKFC(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, string DMCFPOLFNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x22D9150", Offset = "0x22D8150", VA = "0x1822D9150", Slot = "47")]
	[AsyncStateMachine(typeof(FLCBIOCLCLM))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> GEBLCIPFIGJ(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF, HFDGOBILPDJ PFCMGBLCCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x22D9CC0", Offset = "0x22D8CC0", VA = "0x1822D9CC0", Slot = "48")]
	[AsyncStateMachine(typeof(FIECPOFFJMI))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> IDCLDIMKNFH(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK, HFDGOBILPDJ PFCMGBLCCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x22DAFF0", Offset = "0x22D9FF0", VA = "0x1822DAFF0")]
	internal void NEBCBGCEIHF(FCEODKAEDJI<OAOFJLCKBCA> BJDKOHEGDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class HDMJCHBILCF : MPOJCAAMAMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface GGOIENNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		FDFODKCMKED AIOEGFMLMHE
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JPOKLPJBGMB> DICCLNPPGAF(CancellationToken CLIKNEKJHEI);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<DPOFJEJGEFI> NKJBDLOFGCE(CancellationToken CLIKNEKJHEI);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<GCKCDKOFDGL> MIHPOPIKLLI(CancellationToken CLIKNEKJHEI);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct JNCJCKPPINH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HDMJCHBILCF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public BBEDDGOLNGI circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JPOKLPJBGMB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public DPOFJEJGEFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private GGOIENNIAAG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private DPOFJEJGEFI <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<JPOKLPJBGMB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<DPOFJEJGEFI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<GCKCDKOFDGL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<MGBJLEOMPFP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x22DC6F0", Offset = "0x22DB6F0", VA = "0x1822DC6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x22DD0F0", Offset = "0x22DC0F0", VA = "0x1822DD0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly MGBJLEOMPFP JEMFOCDFNHM;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MGBJLEOMPFP AIAPIHFEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	private HDMJCHBILCF(MGBJLEOMPFP HHHDEECOCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x22D33B0", Offset = "0x22D23B0", VA = "0x1822D33B0")]
	[AsyncStateMachine(typeof(JNCJCKPPINH))]
	public static Task<HDMJCHBILCF> IIDEAGOGCBF(BBEDDGOLNGI BFIEGGNBNMB, JPOKLPJBGMB? EBLANDLJNLN, DPOFJEJGEFI? NMDHLPMFPLI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x22D3390", Offset = "0x22D2390", VA = "0x1822D3390", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct DBDFFFNPCNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct OIGGPNMCPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public DBDFFFNPCNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public CFJMCGPIICE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x22E0C00", Offset = "0x22DFC00", VA = "0x1822E0C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x22E0E90", Offset = "0x22DFE90", VA = "0x1822E0E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BAPJBPJLHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DPJKEOMANBI rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public JPOKLPJBGMB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public DPOFJEJGEFI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public DBDFFFNPCNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private CFJMCGPIICE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x22C8070", Offset = "0x22C7070", VA = "0x1822C8070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x22C8450", Offset = "0x22C7450", VA = "0x1822C8450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JIGGKPPGDFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public DBDFFFNPCNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x22DC440", Offset = "0x22DB440", VA = "0x1822DC440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x22DC680", Offset = "0x22DB680", VA = "0x1822DC680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly OJMMLAAPKNG GCLMAMCEALP;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public DBDFFFNPCNF(OJMMLAAPKNG DOPPDHAGGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x22C8DE0", Offset = "0x22C7DE0", VA = "0x1822C8DE0")]
	[AsyncStateMachine(typeof(OIGGPNMCPFI))]
	private Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> BEOAJFIPBFB(CFJMCGPIICE NDLMGANFCBJ, bool PADNGJCAHBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x22C8F10", Offset = "0x22C7F10", VA = "0x1822C8F10")]
	[AsyncStateMachine(typeof(BAPJBPJLHLE))]
	public Task<OBFFLKDLIBJ<bool, FGHJECBDJBN?>>? LNNPFFLPBJL(int BCJOPBPJKCD, DPJKEOMANBI? LEEIJCNMFOE, JPOKLPJBGMB? ENHBGMCFLOO, DPOFJEJGEFI? NMDHLPMFPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x22C8CF0", Offset = "0x22C7CF0", VA = "0x1822C8CF0")]
	[AsyncStateMachine(typeof(JIGGKPPGDFH))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> BACJDAIFIKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class MCEACHNJEKH : EHAFEJGIAEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly KFCEICDPJNJ GKOMECFKEPE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KFCEICDPJNJ LDNHDLCANIF
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	private MCEACHNJEKH(KFCEICDPJNJ LAMJBGNMDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x22DF320", Offset = "0x22DE320", VA = "0x1822DF320")]
	public static MCEACHNJEKH OGCNNFLPKKP(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x22DF300", Offset = "0x22DE300", VA = "0x1822DF300", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface ELKIMLJDGFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	MGBJLEOMPFP AIAPIHFEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	LPOMMCFINGD HLJDNHNGCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	PBAFFHEOEOD HOHOBEOKJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	GMDCICKDEGH BEFOMFPKECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface COBDIBOJKOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	ELKIMLJDGFO? EDMBIALIABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool GIKNMPKMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool EJOFCNFFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<ELKIMLJDGFO?>? MGHOKCAFJKB();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JAKCEHEPPNA(BBEDDGOLNGI BFIEGGNBNMB, DPJKEOMANBI BCBBOHNCBJI, JPOKLPJBGMB? KJOAKMNFKCB, DPOFJEJGEFI? FEEPKIMPGIJ);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[JBAHBGCJJND("IStaticCV2Instance")]
public interface MPOJCAAMAMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MGBJLEOMPFP AIAPIHFEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[JBAHBGCJJND("IStaticEVInstance")]
public interface EHAFEJGIAEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	KFCEICDPJNJ LDNHDLCANIF
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class KPEALFIIGHD
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x22DD430", Offset = "0x22DC430", VA = "0x1822DD430")]
	public static LDIGABEBEBD<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> LDAMFBOIBMK([In] this LDIGABEBEBD<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>> GENCNPBIIEK)
	{
		return default(LDIGABEBEBD<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI, MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class BEPHFBMMFMM : IBLCDIMFNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool EJOFCNFFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x22C8990", Offset = "0x22C7990", VA = "0x1822C8990", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	internal BEPHFBMMFMM(BBEDDGOLNGI BFIEGGNBNMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class FLBBKAFFALA : CDPGENLNKMM
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x22CD320", Offset = "0x22CC320", VA = "0x1822CD320", Slot = "4")]
	public NIGGPLJDENH? BBFGKICKBGE(string? IEFIBPPJBJH, string? EEEJEEEHFLK, string? EHCEMFAJMCO, JEOMDBFFGDF.KMJPFHJLCGH.DKBMCDEOKAD BNJLMECCNOD, bool MCFEGEFBNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public FLBBKAFFALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class EJKIKAMGKCO : HIOHKLHBHOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct MHEONPHHFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<GMNAMPPAFMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public EJKIKAMGKCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<ELKIMLJDGFO?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x22DF700", Offset = "0x22DE700", VA = "0x1822DF700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x22DF9A0", Offset = "0x22DE9A0", VA = "0x1822DF9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<GGKCCFNJFJC<EHIJNIOBBMM>>? FLAHCEJAGKE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public GMNAMPPAFMB? LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x22CB750", Offset = "0x22CA750", VA = "0x1822CB750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public GMDCICKDEGH? OHDIFLJMAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x22CBD70", Offset = "0x22CAD70", VA = "0x1822CBD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool IFHMNCPJANH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x22CBD10", Offset = "0x22CAD10", VA = "0x1822CBD10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HMNKLCPPBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x22CB600", Offset = "0x22CA600", VA = "0x1822CB600", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	internal EJKIKAMGKCO(BBEDDGOLNGI BFIEGGNBNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x22CB660", Offset = "0x22CA660", VA = "0x1822CB660", Slot = "7")]
	[AsyncStateMachine(typeof(MHEONPHHFPC))]
	public Task<GMNAMPPAFMB> AELHCLBLGLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x22CB9A0", Offset = "0x22CA9A0", VA = "0x1822CB9A0", Slot = "9")]
	public IReadOnlyDictionary<GGKCCFNJFJC<OMEMEDNNNNN>, Guid> DNCOFJMBLLP(IEnumerable<KGIKLNIIDMO> AGNKIFOLGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x22CB7D0", Offset = "0x22CA7D0", VA = "0x1822CB7D0")]
	public OBFFLKDLIBJ<FIJCKAEAPLG, HJOFKELFHOB> CAOFHKIIFKB([In] FIJCKAEAPLG OAGAMDMLKKI, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH, int HNNDCDNFMNM)
	{
		return default(OBFFLKDLIBJ<FIJCKAEAPLG, HJOFKELFHOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x22CBDF0", Offset = "0x22CADF0", VA = "0x1822CBDF0", Slot = "8")]
	private OBFFLKDLIBJ<FIJCKAEAPLG, HJOFKELFHOB> PMACNOJNONB([In] FIJCKAEAPLG OAGAMDMLKKI, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH, int HNNDCDNFMNM)
	{
		return default(OBFFLKDLIBJ<FIJCKAEAPLG, HJOFKELFHOB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class GMDCICKDEGH : GMNAMPPAFMB
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class HIAJIAONHPL
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class HAANJBJGFBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public MGBJLEOMPFP state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public HAPCABKPMLK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HAANJBJGFBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x22D31D0", Offset = "0x22D21D0", VA = "0x1822D31D0")]
			internal bool FKKCFPEELEL(EHGCIDBIDGP n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class KAJBEJCPCOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public KAJBEJCPCOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x22DD350", Offset = "0x22DC350", VA = "0x1822DD350")]
			internal void PHKGLEJFHII(EHGCIDBIDGP n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x22D4980", Offset = "0x22D3980", VA = "0x1822D4980")]
		public static OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG> LAHPNPBPBKK(GMDCICKDEGH GFJPFDOHONG, [In] GMNAMPPAFMB.FLEEKDMOBGG NABJMDALPIF)
		{
			return default(OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x22D3A20", Offset = "0x22D2A20", VA = "0x1822D3A20")]
		internal static OBFFLKDLIBJ<(NDOPLOGMLPA, OANNEOPDIHC), EOAIFLFPKCG> EANMACMMGOE(GMDCICKDEGH GFJPFDOHONG, OANNEOPDIHC IACLLBEJBMA, bool HLALKKOCMBI, [In] GGKCCFNJFJC<OMEMEDNNNNN> GNAKPJEGJEN, [In] int? CLMJKKBMPNJ, [In] AMGGLIGKMHC? MEDGOMBLEGL, [In] AMGGLIGKMHC? KKEFCBIIJPH)
		{
			return default(OBFFLKDLIBJ<(NDOPLOGMLPA, OANNEOPDIHC), EOAIFLFPKCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x22D4EE0", Offset = "0x22D3EE0", VA = "0x1822D4EE0")]
		private static void LKHENOHOIBM(bool HLALKKOCMBI, KGIKLNIIDMO DBMIMADNHFB, NDOPLOGMLPA KNBPGBKNMLI, [In] GGKCCFNJFJC<OMEMEDNNNNN> GNAKPJEGJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x22D5350", Offset = "0x22D4350", VA = "0x1822D5350")]
		public static void NGNGJIBOHOH(BMFHAPDBCMF OHIGECHLODG, [In] GMNAMPPAFMB.GKELPECPCNF AKONCNONFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x22D4890", Offset = "0x22D3890", VA = "0x1822D4890")]
		[CompilerGenerated]
		internal static bool FGNBOMNBDBK(MGBJLEOMPFP LHOEHBBNDBN, HAPCABKPMLK IBIHBJEEPNG, EHGCIDBIDGP PPEFHAJBIDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x22D5320", Offset = "0x22D4320", VA = "0x1822D5320")]
		[CompilerGenerated]
		internal static bool NEKKGCMLLLB(EHGCIDBIDGP CGLIBNPLPJF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct OMIOKHBPIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public GMDCICKDEGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public FCEODKAEDJI<OMEMEDNNNNN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public FCEODKAEDJI<DJNGCDCAKKJ> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FCEODKAEDJI<IDMOAGMBHCD> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x22E1240", Offset = "0x22E0240", VA = "0x1822E1240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x22E1890", Offset = "0x22E0890", VA = "0x1822E1890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct NAPCLEGPCNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public GMDCICKDEGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public GGKCCFNJFJC<IMDHLBELCNK> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public GGKCCFNJFJC<OMEMEDNNNNN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public FCEODKAEDJI<OAOFJLCKBCA> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public FCEODKAEDJI<JIHNPCGMGAN> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x22DFE30", Offset = "0x22DEE30", VA = "0x1822DFE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x22E0170", Offset = "0x22DF170", VA = "0x1822E0170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct IPEBFGFELJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public GMDCICKDEGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public GGKCCFNJFJC<IMDHLBELCNK> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public GGKCCFNJFJC<OMEMEDNNNNN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public FCEODKAEDJI<OAOFJLCKBCA> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public FCEODKAEDJI<IAIFMMANJAN> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x22E68D0", Offset = "0x22E58D0", VA = "0x1822E68D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x22E6C10", Offset = "0x22E5C10", VA = "0x1822E6C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly BBEDDGOLNGI HCJOFDDNBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly MPOJCAAMAMA DLNMPPDDJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly EHAFEJGIAEB AKGJGPBBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly IBINMGAJJHI OPDAOBJMJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly EJKIKAMGKCO KGFMIMIAHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<GGKCCFNJFJC<IMDHLBELCNK>, NAOHBAGGJLN> ADIJACNKCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<GGKCCFNJFJC<IMDHLBELCNK>>? KHBAAHMNBJM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GGKCCFNJFJC<OMEMEDNNNNN> ELHJLCPALNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x22CDEF0", Offset = "0x22CCEF0", VA = "0x1822CDEF0", Slot = "4")]
		get
		{
			return default(GGKCCFNJFJC<OMEMEDNNNNN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public IBINMGAJJHI JACJEOGKLME
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x22AB2C0", Offset = "0x22AA2C0", VA = "0x1822AB2C0", Slot = "5")]
		get
		{
			return default(IBINMGAJJHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x22D2880", Offset = "0x22D1880", VA = "0x1822D2880")]
	public GMDCICKDEGH(BBEDDGOLNGI BFIEGGNBNMB, MPOJCAAMAMA CLAKBPODJDK, EHAFEJGIAEB DJDEHDIDCJL, EJKIKAMGKCO NJNFKGDGPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x22CDDF0", Offset = "0x22CCDF0", VA = "0x1822CDDF0", Slot = "48")]
	public FCEODKAEDJI<OOEPOIHBEEC> AJHKHDBPLIP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(FCEODKAEDJI<OOEPOIHBEEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x22D16F0", Offset = "0x22D06F0", VA = "0x1822D16F0", Slot = "49")]
	public FCEODKAEDJI<MHCMNEOALJM> MBMPNHEEBJC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(FCEODKAEDJI<MHCMNEOALJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x22CE770", Offset = "0x22CD770", VA = "0x1822CE770", Slot = "6")]
	public (bool, bool) CANKHHEHCEA(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x22D0170", Offset = "0x22CF170", VA = "0x1822D0170")]
	public bool JMMPIFPOPHJ(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x22D0FB0", Offset = "0x22CFFB0", VA = "0x1822D0FB0", Slot = "8")]
	public bool LIBKFOHFDOP(MMIDPNEOGKG EEFLJODFNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x22D0F30", Offset = "0x22CFF30", VA = "0x1822D0F30", Slot = "9")]
	public bool LHDIAKOOIAE(BOAGOIHOCGF BMKEMECOFMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x22D1770", Offset = "0x22D0770", VA = "0x1822D1770", Slot = "10")]
	public IKHKKILINMA? MDKGIKAHLKB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x22CEE60", Offset = "0x22CDE60", VA = "0x1822CEE60", Slot = "11")]
	public DPKDDFHGADN? EFHPAHCBDFI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x22CF790", Offset = "0x22CE790", VA = "0x1822CF790", Slot = "12")]
	public IEnumerable<FCEODKAEDJI<EEENFPNJEIF>> HENBNOJDAIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x22D1DF0", Offset = "0x22D0DF0", VA = "0x1822D1DF0", Slot = "13")]
	public string MKLPOLKHLDI(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x22CED70", Offset = "0x22CDD70", VA = "0x1822CED70", Slot = "14")]
	public string DEIGEOHGNOC(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x22CFFB0", Offset = "0x22CEFB0", VA = "0x1822CFFB0")]
	public NAOHBAGGJLN? ILHPBGKBOKP([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x22CF290", Offset = "0x22CE290", VA = "0x1822CF290")]
	public FCEODKAEDJI<IMDHLBELCNK> GJHJJINDAGI(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x22D0500", Offset = "0x22CF500", VA = "0x1822D0500", Slot = "26")]
	public FCEODKAEDJI<IMDHLBELCNK> KFPKIJNLHDP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x22D2800", Offset = "0x22D1800", VA = "0x1822D2800", Slot = "27")]
	public FCEODKAEDJI<IMDHLBELCNK> PJEDFIEPEHB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x22D1D60", Offset = "0x22D0D60", VA = "0x1822D1D60")]
	private void MKKJNEICMGG(GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x22CEF20", Offset = "0x22CDF20", VA = "0x1822CEF20")]
	public IEnumerable<NAOHBAGGJLN> ENPEJCFFIOL([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x22D2710", Offset = "0x22D1710", VA = "0x1822D2710", Slot = "25")]
	public FCEODKAEDJI<IDMOAGMBHCD> PIKDNMBINLF(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OOEPOIHBEEC> KLCJBCDLHHJ)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x22CDF50", Offset = "0x22CCF50", VA = "0x1822CDF50", Slot = "28")]
	public FCEODKAEDJI<DJNGCDCAKKJ> BEANJDGDAIM(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<MHCMNEOALJM> HDFKMLJJHIN)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x22D1FC0", Offset = "0x22D0FC0", VA = "0x1822D1FC0")]
	private NAOHBAGGJLN? NDBKFKDGPMM([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x22CFD80", Offset = "0x22CED80", VA = "0x1822CFD80")]
	private NAOHBAGGJLN IAAHKJIIGKD([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, JENJIJHPILB CHMIAHGMJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x22D0EA0", Offset = "0x22CFEA0", VA = "0x1822D0EA0")]
	public JENJIJHPILB? LDDFFJGJBDG([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x22CE740", Offset = "0x22CD740", VA = "0x1822CE740")]
	public BOOIFAHNHOE? CAEMKJBEMGG([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x22CF310", Offset = "0x22CE310", VA = "0x1822CF310", Slot = "20")]
	public IEnumerable<NLABAOACMJG> GMOPLLNHLOB(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x22CE0D0", Offset = "0x22CD0D0", VA = "0x1822CE0D0", Slot = "21")]
	public bool BKAJMFMPPBC(FCEODKAEDJI<EEENFPNJEIF> MNBBIIOGDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x22CF920", Offset = "0x22CE920", VA = "0x1822CF920", Slot = "22")]
	public IEnumerable<HIKLHIHFALH> HJAJOLLOKIG(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x22D22B0", Offset = "0x22D12B0", VA = "0x1822D22B0", Slot = "23")]
	public IEnumerable<HIKLHIHFALH> ONOAJOBKOMN(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x22CDE70", Offset = "0x22CCE70", VA = "0x1822CDE70")]
	public FCEODKAEDJI<OMEMEDNNNNN> PCJHLDODIBF([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return default(FCEODKAEDJI<OMEMEDNNNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x22CF190", Offset = "0x22CE190", VA = "0x1822CF190")]
	public FCEODKAEDJI<OMEMEDNNNNN>? OLLIBOBPGJF([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x22D00B0", Offset = "0x22CF0B0", VA = "0x1822D00B0")]
	private HAPCABKPMLK? INJABCELBBH([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x22CE740", Offset = "0x22CD740", VA = "0x1822CE740")]
	private BOOIFAHNHOE? GIOKONFJEDB([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x22CFF40", Offset = "0x22CEF40", VA = "0x1822CFF40", Slot = "32")]
	public GGKCCFNJFJC<OMEMEDNNNNN> IJAFKONEBBE(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return default(GGKCCFNJFJC<OMEMEDNNNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x22CEC70", Offset = "0x22CDC70", VA = "0x1822CEC70", Slot = "29")]
	public IEnumerable<HFDGOBILPDJ> CJJFOLPAOEI(CBOIOFDJHEI HKLHPGCGGEO, bool GFJMDLGCFKF, bool MJPLPIKJCMP, bool JIEAFJLJDNH, bool LNBMKDNMOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x22D0710", Offset = "0x22CF710", VA = "0x1822D0710", Slot = "30")]
	public HFDGOBILPDJ LAENENNHPOG(CBOIOFDJHEI HKLHPGCGGEO, ABNPAAPNOHH MAFFFNNDKNN, bool GFJMDLGCFKF, bool MJPLPIKJCMP, bool JIEAFJLJDNH, bool LNBMKDNMOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x22CE250", Offset = "0x22CD250", VA = "0x1822CE250")]
	public NLABAOACMJG EDEEFMJJPIC(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED)
	{
		return default(NLABAOACMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x22D2010", Offset = "0x22D1010", VA = "0x1822D2010", Slot = "33")]
	public HIKLHIHFALH NILDEFONEAM(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
		return default(HIKLHIHFALH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x22CDCC0", Offset = "0x22CCCC0", VA = "0x1822CDCC0", Slot = "34")]
	public bool AFOCKOPFPFA(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x22CF210", Offset = "0x22CE210", VA = "0x1822CF210", Slot = "35")]
	public bool GIANGPPEBMP(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x22CEDE0", Offset = "0x22CDDE0", VA = "0x1822CEDE0", Slot = "36")]
	public bool EEFGEBJDNMH(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x22CDDC0", Offset = "0x22CCDC0", VA = "0x1822CDDC0")]
	public OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG> AHGNEIGHNCP([In] GMNAMPPAFMB.FLEEKDMOBGG NABJMDALPIF)
	{
		return default(OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x22CF000", Offset = "0x22CE000", VA = "0x1822CF000", Slot = "38")]
	[AsyncStateMachine(typeof(OMIOKHBPIKF))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> FKAJCDGMFJD(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x22CF3D0", Offset = "0x22CE3D0", VA = "0x1822CF3D0", Slot = "39")]
	public OBFFLKDLIBJ<PNNOENNOEAA, HJOFKELFHOB> GPDGCNFCJNN(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, PNNOENNOEAA GDMIHLHPKJN, FLAJGLHFMML ABGMKDALCOP)
	{
		return default(OBFFLKDLIBJ<PNNOENNOEAA, HJOFKELFHOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x22D2530", Offset = "0x22D1530", VA = "0x1822D2530", Slot = "40")]
	[AsyncStateMachine(typeof(NAPCLEGPCNH))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> OOEFCIKECDI(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> KGMJGCLHFFI, FCEODKAEDJI<OAOFJLCKBCA> LIDEOOBDIOH, FCEODKAEDJI<JIHNPCGMGAN> MMPLNFLCEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x22D1E60", Offset = "0x22D0E60", VA = "0x1822D1E60", Slot = "41")]
	[AsyncStateMachine(typeof(IPEBFGFELJM))]
	public Task<OBFFLKDLIBJ<MKHCENILMPB, FGHJECBDJBN>> MOIHMOJPNKC(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> DBEOAFJFJEL, FCEODKAEDJI<OAOFJLCKBCA> DPIHCFAFGAD, FCEODKAEDJI<IAIFMMANJAN> LKEMMOGOMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x22CFBB0", Offset = "0x22CEBB0", VA = "0x1822CFBB0", Slot = "42")]
	public LBBHHBKMHGF HMMNIOPJKLN(IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH)
	{
		return default(LBBHHBKMHGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x22D05F0", Offset = "0x22CF5F0", VA = "0x1822D05F0", Slot = "43")]
	public LBBHHBKMHGF KNKJHNCKDKJ()
	{
		return default(LBBHHBKMHGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x22D1B50", Offset = "0x22D0B50", VA = "0x1822D1B50")]
	private KEIFAHMIGDI MGGPNLJFJBI(PHBDFBFLGBL IANLAEECIJK, FCEODKAEDJI<OMEMEDNNNNN> LDHIGPEHLAP, IEnumerable<GGKCCFNJFJC<OMEMEDNNNNN>> JBBAKPEKKBK, IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>> LNBOMMCIFCA)
	{
		return default(KEIFAHMIGDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x22D1830", Offset = "0x22D0830", VA = "0x1822D1830", Slot = "44")]
	public KEIFAHMIGDI MGGPNLJFJBI(PHBDFBFLGBL IANLAEECIJK, FCEODKAEDJI<OMEMEDNNNNN> LDHIGPEHLAP, IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>> LNBOMMCIFCA, IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH)
	{
		return default(KEIFAHMIGDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x22CE3C0", Offset = "0x22CD3C0", VA = "0x1822CE3C0")]
	private static IEnumerable<GGKCCFNJFJC<OMEMEDNNNNN>> CAAJGJIPJJH(IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x22D0A10", Offset = "0x22CFA10", VA = "0x1822D0A10")]
	private IEnumerable<GGKCCFNJFJC<IMDHLBELCNK>> LBLHMABIPGB(IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x22CDD30", Offset = "0x22CCD30", VA = "0x1822CDD30", Slot = "45")]
	public List<KLNACLEPDMM> AGABGHBEIGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x22D1030", Offset = "0x22D0030", VA = "0x1822D1030")]
	public (List<KLNACLEPDMM>, bool) MBFCFAKNGAF([In] MPOOPGKGMDJ ILGHNJKCJDN, string NDMMIOJEOEB, [In] BDLCOGNBOKL GNFPEMNOJIL, FAMAMOGJFCI GKOPBEJIIOG, BBKGGAENLCO GDMAMBPDFDE)
	{
		return default((List<KLNACLEPDMM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x22CDFE0", Offset = "0x22CCFE0", VA = "0x1822CDFE0", Slot = "47")]
	public bool BFMNJCFFLNL(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x22D1D00", Offset = "0x22D0D00", VA = "0x1822D1D00")]
	internal void MIAJBKFKGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x22D27A0", Offset = "0x22D17A0", VA = "0x1822D27A0")]
	internal Task PJDDGJFHNCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x22D2000", Offset = "0x22D1000", VA = "0x1822D2000", Slot = "7")]
	private bool NHMEIKDEDFK(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x22CE740", Offset = "0x22CD740", VA = "0x1822CE740", Slot = "15")]
	private BOOIFAHNHOE EIKGLHGLLML([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x22CDE70", Offset = "0x22CCE70", VA = "0x1822CDE70", Slot = "16")]
	private FCEODKAEDJI<OMEMEDNNNNN> AMFHCJGIOFJ([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return default(FCEODKAEDJI<OMEMEDNNNNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x22CF190", Offset = "0x22CE190", VA = "0x1822CF190", Slot = "17")]
	private FCEODKAEDJI<OMEMEDNNNNN>? GGEMGCHPAOJ([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x22CE160", Offset = "0x22CD160", VA = "0x1822CE160", Slot = "18")]
	private NAOHBAGGJLN BLGAGFIPMPK([In] GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x22CF290", Offset = "0x22CE290", VA = "0x1822CF290", Slot = "19")]
	private FCEODKAEDJI<IMDHLBELCNK> HAKBIIHABLH(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] GGKCCFNJFJC<IMDHLBELCNK> CAPJEFONOPC)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x22CF840", Offset = "0x22CE840", VA = "0x1822CF840", Slot = "24")]
	private IEnumerable<NAOHBAGGJLN> HILHJHLEIMP([In] GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x22CE250", Offset = "0x22CD250", VA = "0x1822CE250", Slot = "31")]
	private NLABAOACMJG BODJLJIGEMF(FCEODKAEDJI<OMEMEDNNNNN> EFMPIMPFJNO, [In] HIKLHIHFALH PLNNKOJNAED)
	{
		return default(NLABAOACMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x22CDDC0", Offset = "0x22CCDC0", VA = "0x1822CDDC0", Slot = "37")]
	private OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG> PNKDEDMGGNJ([In] GMNAMPPAFMB.FLEEKDMOBGG NABJMDALPIF)
	{
		return default(OBFFLKDLIBJ<GMNAMPPAFMB.IKCJMMMLOEG, EOAIFLFPKCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x22CF130", Offset = "0x22CE130", VA = "0x1822CF130", Slot = "46")]
	private (List<KLNACLEPDMM>, bool) FNAIDOLIGHG([In] MPOOPGKGMDJ ILGHNJKCJDN, string NDMMIOJEOEB, [In] BDLCOGNBOKL GNFPEMNOJIL, FAMAMOGJFCI GKOPBEJIIOG, BBKGGAENLCO GDMAMBPDFDE)
	{
		return default((List<KLNACLEPDMM>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x22CFE50", Offset = "0x22CEE50", VA = "0x1822CFE50")]
	[CompilerGenerated]
	private NAOHBAGGJLN IDNOGEADLEM(JENJIJHPILB MEJGJHNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x22D2690", Offset = "0x22D1690", VA = "0x1822D2690")]
	[CompilerGenerated]
	private IGABFHHADKF PGFKDBJHKBA(LKBDFEKEMKA MEJGJHNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x22D0580", Offset = "0x22CF580", VA = "0x1822D0580")]
	[CompilerGenerated]
	private JENJIJHPILB KHCCLLOBIOL(GGKCCFNJFJC<IMDHLBELCNK> MEJGJHNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x22D2240", Offset = "0x22D1240", VA = "0x1822D2240")]
	[CompilerGenerated]
	private HAPCABKPMLK NNKDPNNKHEF(GGKCCFNJFJC<OMEMEDNNNNN> MEJGJHNGKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IGABFHHADKF : HFDGOBILPDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct LANDFBILMAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<FCEODKAEDJI<KKOGEBIBMKE>, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public IGABFHHADKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public GGKCCFNJFJC<OMEMEDNNNNN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public GGKCCFNJFJC<IMDHLBELCNK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<KKOGEBIBMKE>, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x22E7070", Offset = "0x22E6070", VA = "0x1822E7070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x22E72F0", Offset = "0x22E62F0", VA = "0x1822E72F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct HOKPPAELPOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<FCEODKAEDJI<PLLHIIMKMMI>, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public IGABFHHADKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public GGKCCFNJFJC<OMEMEDNNNNN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GGKCCFNJFJC<IMDHLBELCNK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public FCEODKAEDJI<OAOFJLCKBCA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<OBFFLKDLIBJ<FCEODKAEDJI<PLLHIIMKMMI>, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x22E6260", Offset = "0x22E5260", VA = "0x1822E6260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x22E64E0", Offset = "0x22E54E0", VA = "0x1822E64E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly LKBDFEKEMKA GEGBJEPNOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly MPOJCAAMAMA DLNMPPDDJEH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey OLANDIMLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string EGOFGBMPBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x22E4A70", Offset = "0x22E3A70", VA = "0x1822E4A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public LKBDFEKEMKA JHLNCGJNAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x22E6830", Offset = "0x22E5830", VA = "0x1822E6830")]
	public IGABFHHADKF(LKBDFEKEMKA DOGCIDAFJDA, MPOJCAAMAMA CLAKBPODJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x22E6550", Offset = "0x22E5550", VA = "0x1822E6550", Slot = "6")]
	[AsyncStateMachine(typeof(LANDFBILMAD))]
	public Task<OBFFLKDLIBJ<FCEODKAEDJI<KKOGEBIBMKE>, FGHJECBDJBN>> IPPIPDCEAPK(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, string DMCFPOLFNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x22E66C0", Offset = "0x22E56C0", VA = "0x1822E66C0", Slot = "7")]
	[AsyncStateMachine(typeof(HOKPPAELPOP))]
	public Task<OBFFLKDLIBJ<FCEODKAEDJI<PLLHIIMKMMI>, FGHJECBDJBN>> MONAMFBDKNG(GGKCCFNJFJC<OMEMEDNNNNN> EFMPIMPFJNO, GGKCCFNJFJC<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK, string DMCFPOLFNCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class FJGIHOIADGN : KCFBAGCAKEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly LKBDFEKEMKA PEADGGKOPNG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<LKBDFEKEMKA> ECCAMPIFPIM;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<LKBDFEKEMKA> DDALACLNOFA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<LKBDFEKEMKA> BFHKDKFEAKB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey AEDGBICBIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x22E5C00", Offset = "0x22E4C00", VA = "0x1822E5C00", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CLIEHPNDAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x22E5BF0", Offset = "0x22E4BF0", VA = "0x1822E5BF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool HJNPAGHFHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x22E5C50", Offset = "0x22E4C50", VA = "0x1822E5C50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool CAPIAKMPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x22E5B70", Offset = "0x22E4B70", VA = "0x1822E5B70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x22E4800", Offset = "0x22E3800", VA = "0x1822E4800")]
	public bool DMGNOKPIHLJ(string BJDKOHEGDOK, [Out] NMKMLDPKACE GNKABNLDOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public FJGIHOIADGN(LKBDFEKEMKA PHOINLFJEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x22E4670", Offset = "0x22E3670", VA = "0x1822E4670")]
	internal static TypeKey AKBEIAMFDHA(LKBDFEKEMKA PFCMGBLCCPJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x22E4A70", Offset = "0x22E3A70", VA = "0x1822E4A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct DGFLDECDINE : LONMEFHAMIO.CNDBABGKLBM<CFJMCGPIICE, MKHCENILMPB>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x22E3D40", Offset = "0x22E2D40", VA = "0x1822E3D40", Slot = "4")]
	public int OEAJMMOEJAL(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x22E3CF0", Offset = "0x22E2CF0", VA = "0x1822E3CF0", Slot = "5")]
	public CFJMCGPIICE JLEFOKIJIHL(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x22E3C40", Offset = "0x22E2C40", VA = "0x1822E3C40", Slot = "6")]
	public CFJMCGPIICE FEHPIKDKNMG(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x22E3CB0", Offset = "0x22E2CB0", VA = "0x1822E3CB0", Slot = "7")]
	public IReadOnlyList<CFJMCGPIICE> IKHCGLACIEG(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x22E3C30", Offset = "0x22E2C30", VA = "0x1822E3C30", Slot = "8")]
	public CFJMCGPIICE[] BLIJMGPDNOO(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ, int ONLJKJKOGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x22E3D00", Offset = "0x22E2D00", VA = "0x1822E3D00", Slot = "9")]
	public bool LFEOICJOKPA(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x22E3CD0", Offset = "0x22E2CD0", VA = "0x1822E3CD0", Slot = "10")]
	public bool IOECBJCMBFN(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x22E3D20", Offset = "0x22E2D20", VA = "0x1822E3D20", Slot = "11")]
	public bool LJOBGAMPMGI(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x22E3C90", Offset = "0x22E2C90", VA = "0x1822E3C90", Slot = "12")]
	public bool IBMPDNCMIFD(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x22E3D60", Offset = "0x22E2D60", VA = "0x1822E3D60", Slot = "13")]
	public bool OIJICBKNBPH(MKHCENILMPB JNIANPFJBBA, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x22E3C70", Offset = "0x22E2C70", VA = "0x1822E3C70", Slot = "14")]
	public bool HBCKCDCJMAL(MKHCENILMPB BEELICCCBAC, CFJMCGPIICE NDLMGANFCBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class MCDAMMLNFCC : NLCDGFHNHBA
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LCLBJLFHNEE.PNNFLCHBOCG PKIFPLDDJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x22E7590", Offset = "0x22E6590", VA = "0x1822E7590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract JPPOPAKFKPF.BPOCMCHBGPP EBFMOMEBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract BBEDDGOLNGI.CAKCBPDDBNM GHDODIJBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract HDMJCHBILCF.GGOIENNIAAG IFPBACAPONC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public MNKKGBFNDJP.MNGJFPJAFCM<MOMCKELODOF, CFJMCGPIICE, BBEDDGOLNGI> MPFBDECMEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7540", Offset = "0x22E6540", VA = "0x1822E7540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract MABFKOKBBPE OPNCNDDJCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract LENBKECFBMO CPBOIKHHFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract KBJIJGMCEEK PKEGMGFGEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract MMMOBGGKOHB AFPLNKGIHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract MMNIBMJPACE GIBLNJGMDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected MCDAMMLNFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CDHLDJLEJGL : KEOGADFNLJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct FNFPEFGHFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public CDHLDJLEJGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CFJMCGPIICE action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x22E5D70", Offset = "0x22E4D70", VA = "0x1822E5D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x22E6010", Offset = "0x22E5010", VA = "0x1822E6010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct JDIKFKHDCGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public CDHLDJLEJGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<CFJMCGPIICE> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x22E6C80", Offset = "0x22E5C80", VA = "0x1822E6C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x22E7000", Offset = "0x22E6000", VA = "0x1822E7000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly OJMMLAAPKNG GCLMAMCEALP;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public CDHLDJLEJGL(OJMMLAAPKNG DOPPDHAGGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x22E3970", Offset = "0x22E2970", VA = "0x1822E3970")]
	[AsyncStateMachine(typeof(FNFPEFGHFAN))]
	private Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> BEOAJFIPBFB(CFJMCGPIICE NDLMGANFCBJ, bool PADNGJCAHBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x22E3AA0", Offset = "0x22E2AA0", VA = "0x1822E3AA0", Slot = "4")]
	[AsyncStateMachine(typeof(JDIKFKHDCGO))]
	public Task<OBFFLKDLIBJ<KGEGMCMOEKL, FGHJECBDJBN>> PPKHPIMHCFC(IReadOnlyList<CFJMCGPIICE> DGAJIBMPJKI, bool PADNGJCAHBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct AILEFPALPCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal POHJBOLIAMD<AKNFMCFCFGH, CFJMCGPIICE, GJDPHDPPHCD> PEADGGKOPNG;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x22BEC60", Offset = "0x22BDC60", VA = "0x1822BEC60")]
	private AILEFPALPCL([In] POHJBOLIAMD<AKNFMCFCFGH, CFJMCGPIICE, GJDPHDPPHCD> BGAIFPEHLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x22E3800", Offset = "0x22E2800", VA = "0x1822E3800")]
	public static AILEFPALPCL EJLELCHFLID()
	{
		return default(AILEFPALPCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class FFBNEJMIDDC
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static POHJBOLIAMD<AKNFMCFCFGH, CFJMCGPIICE, GJDPHDPPHCD> IHLHELPCCAL(this AILEFPALPCL GFJPFDOHONG)
	{
		return default(POHJBOLIAMD<AKNFMCFCFGH, CFJMCGPIICE, GJDPHDPPHCD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct GJDPHDPPHCD : EKJGJANFMMG.IEIKKJCOLGF<AKNFMCFCFGH, CFJMCGPIICE>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x22E6080", Offset = "0x22E5080", VA = "0x1822E6080", Slot = "5")]
	public CFJMCGPIICE FDCMNALNFDH(AKNFMCFCFGH[] LPJKFNAKNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0")]
	public int DMMOFIFBLPP([In] AKNFMCFCFGH OOBOPPMIJBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0", Slot = "4")]
	private int DNJGMJNIGJL([In] AKNFMCFCFGH CFEHMMIHPBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct CLDGHIOOLNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal AENABONOLMA<AKAIDABCOKM, CFJMCGPIICE, LJKAIKNAMED> PEADGGKOPNG;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x22BEC60", Offset = "0x22BDC60", VA = "0x1822BEC60")]
	private CLDGHIOOLNP([In] AENABONOLMA<AKAIDABCOKM, CFJMCGPIICE, LJKAIKNAMED> KKBOALCPKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x22E3BD0", Offset = "0x22E2BD0", VA = "0x1822E3BD0")]
	public static CLDGHIOOLNP EJLELCHFLID()
	{
		return default(CLDGHIOOLNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class BENCPOAMJJM
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static AENABONOLMA<AKAIDABCOKM, CFJMCGPIICE, LJKAIKNAMED> IHLHELPCCAL(this CLDGHIOOLNP GFJPFDOHONG)
	{
		return default(AENABONOLMA<AKAIDABCOKM, CFJMCGPIICE, LJKAIKNAMED>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct LJKAIKNAMED : ICDEKEFHGBC.PGKJNNAGGLM<AKAIDABCOKM, CFJMCGPIICE>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0")]
	public int FBLNDGBIBLD([In] AKAIDABCOKM OOBOPPMIJBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x22E7360", Offset = "0x22E6360", VA = "0x1822E7360", Slot = "5")]
	public CFJMCGPIICE FHFFMHCMFIB(AKAIDABCOKM[] IHHIMAHPALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0", Slot = "4")]
	private int CKIALKHNDFL([In] AKAIDABCOKM OOBOPPMIJBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class AGBGMIDBJHG : PPOILIOPEKP, EOAIFLFPKCG, FGHJECBDJBN, HJOFKELFHOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly HJOFKELFHOB? DDAMIENOFDL;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public JEKPODOGHBG BMBBEAGMMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(JEKPODOGHBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8C12F0", Offset = "0x8C02F0", VA = "0x1808C12F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override HJOFKELFHOB? OAOEHALMHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x22E35D0", Offset = "0x22E25D0", VA = "0x1822E35D0", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x22E37C0", Offset = "0x22E27C0", VA = "0x1822E37C0")]
	private AGBGMIDBJHG(JEKPODOGHBG LLLGBHDHFFG, HJOFKELFHOB? KMNPAHKOEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x22E34E0", Offset = "0x22E24E0", VA = "0x1822E34E0")]
	public static AGBGMIDBJHG AMPHAFECPIJ(HJOFKELFHOB KMNPAHKOEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x22E3750", Offset = "0x22E2750", VA = "0x1822E3750")]
	public static AGBGMIDBJHG MDPGAKPFKKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x22E3560", Offset = "0x22E2560", VA = "0x1822E3560")]
	public static AGBGMIDBJHG DFCHGEMBOPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class MOLFEPIGNBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x308C920", Offset = "0x308B920", VA = "0x18308C920")]
	public static OBFFLKDLIBJ<TOk, EOAIFLFPKCG> GMCPNIAGLEO<TOk>([In] this OBFFLKDLIBJ<TOk, EOAIFLFPKCG> GFJPFDOHONG, HJOFKELFHOB KMNPAHKOEDL) where TOk : notnull
	{
		return default(OBFFLKDLIBJ<TOk, EOAIFLFPKCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x308C730", Offset = "0x308B730", VA = "0x18308C730")]
	public static OBFFLKDLIBJ<TOk?, EOAIFLFPKCG?> EFJBGFEJPDI<TOk>([In] this OBFFLKDLIBJ<TOk, EOAIFLFPKCG> GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<TOk, EOAIFLFPKCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x308C820", Offset = "0x308B820", VA = "0x18308C820")]
	public static OBFFLKDLIBJ<TOk?, EOAIFLFPKCG?> GLLAJFKKPOJ<TOk>([In] this OBFFLKDLIBJ<TOk, EOAIFLFPKCG> GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<TOk, EOAIFLFPKCG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface MABFKOKBBPE
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLCPEKDPPMD([In] OBFFLKDLIBJ<MKHCENILMPB, HJOFKELFHOB> POCKBMKNJHC);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class PMJGJHBIFBC
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x315C0C0", Offset = "0x315B0C0", VA = "0x18315C0C0")]
	public static bool NLCPEKDPPMD<TOk, TErr>(this MABFKOKBBPE GFJPFDOHONG, [In] OBFFLKDLIBJ<TOk, TErr> POCKBMKNJHC) where TOk : notnull where TErr : notnull, HJOFKELFHOB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface LENBKECFBMO
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	EPFJBAPCNDM ALNJDCIIMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface KBJIJGMCEEK
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGNHFMPOJGB HMCMAHBBGAJ(int OCABHBLBJNF);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface GJIHBDJHNPP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface LHCHFABJNAG
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDNBNEFLDKK? CAKDAOFPHPH(FCEODKAEDJI<OAOFJLCKBCA> IEIACFCAAPK);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface LMHFHLNDKDH
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface NDNBNEFLDKK
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string KKNEIOOKBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMHFHLNDKDH? CJIEEHCPNHN(FCEODKAEDJI<KKOGEBIBMKE> KEGCOCLNJDF);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GJIHBDJHNPP? COMMJFLHDNI(FCEODKAEDJI<PLLHIIMKMMI> KDAPAOGAHKK);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface MMMOBGGKOHB
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OGPODAMKAGN(string BJDKOHEGDOK, string NDMMIOJEOEB);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface MMNIBMJPACE
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LHCHFABJNAG? HDDFPHHJGJA([In] GGKCCFNJFJC<EHIJNIOBBMM> CANLHMFPAIK);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class ENKNIFBJGBF
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct AMNLHOOOMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int HOLNAIGPNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public JPOKLPJBGMB? FIKNLIKGIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public JPOKLPJBGMB? MLFLJJIAOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<CFJMCGPIICE> IMJEKKHHGBN;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x22E3920", Offset = "0x22E2920", VA = "0x1822E3920")]
		private AMNLHOOOMEL(int KHAIDMGPIED, JPOKLPJBGMB? JBGIHMBMFAE, JPOKLPJBGMB? NJOKPPDBMMB, List<CFJMCGPIICE> DGAJIBMPJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x22E3860", Offset = "0x22E2860", VA = "0x1822E3860")]
		public static AMNLHOOOMEL EJLELCHFLID()
		{
			return default(AMNLHOOOMEL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly GMPHPPCOFJN<AMNLHOOOMEL> AIEEEBEACGA;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static ENKNIFBJGBF LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x22E3E40", Offset = "0x22E2E40", VA = "0x1822E3E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool NOLPOFHNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x98E930", Offset = "0x98D930", VA = "0x18098E930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA3A990", Offset = "0xA39990", VA = "0x180A3A990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x22E3D80", Offset = "0x22E2D80", VA = "0x1822E3D80")]
	public void AIBILABNOFM(MGBJLEOMPFP NJOKPPDBMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x22E41D0", Offset = "0x22E31D0", VA = "0x1822E41D0")]
	public void IIIKNPOIDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x22E3E90", Offset = "0x22E2E90", VA = "0x1822E3E90")]
	private static string? GLHNBGDNEAK([In] AMNLHOOOMEL LGABJJJGGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x22E45C0", Offset = "0x22E35C0", VA = "0x1822E45C0")]
	public ENKNIFBJGBF()
	{
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
